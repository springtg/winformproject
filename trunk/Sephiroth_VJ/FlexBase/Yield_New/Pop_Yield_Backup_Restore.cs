using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using RecursiveFileExplorer;

namespace FlexBase.Yield_New
{
    public partial class Pop_Yield_Backup_Restore : COM.PCHWinForm.Pop_Large_Light
    {


        #region 생성자


        private string _Factory;
        private string _StyleCd;
        private string _StyleName;


        public Pop_Yield_Backup_Restore(string arg_factory, string arg_style_cd, string arg_style_name)
        {
            InitializeComponent();


            _Factory = arg_factory;
            _StyleCd = arg_style_cd;
            _StyleName = arg_style_name;


            Init_Form();

        }


        #endregion

        #region 변수 정의

        private COM.OraDB MyOraDB = new COM.OraDB();


        #endregion

        #region 멤버 메서드

        public void Init_Form()
        {
            try
            {

                //Title
                this.Text = "Restore Yield Data";
                lbl_MainTitle.Text = "Restore Yield Data";


                ClassLib.ComFunction.SetLangDic(this);

                // control setting
                Init_Control();



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        /// <summary>
        /// Init_Control : textbox, combobox setting
        /// </summary>
        private void Init_Control()
        {


            c1ToolBar1.Visible = false;


            txt_Factory.Text = _Factory;
            txt_StyleCd.Text = _StyleCd;
            txt_StyleName.Text = _StyleName;


            Display_Head();



        }



        /// <summary>
        /// Display_Head : 
        /// </summary>
        private void Display_Head()
        {

            // 실행 폴더 내에 "Factory_StyleCode" 형태의 폴더생성해서,  backup 파일보관
            string start_path = Application.StartupPath.ToString() + "\\" + "Yield_Backup" + "\\";
            string directory_name = _Factory + "_" + _StyleCd.Replace("-", "");
            string directory_full_name = start_path + directory_name;


            if (!System.IO.Directory.Exists(directory_full_name)) return;


            ArrayList extensions_array = new ArrayList();
            extensions_array.Add(".ZIP");
            RecursiveFileExplorer.FileExplorer file_explorer = new FileExplorer(directory_full_name, extensions_array, true);



            //fgrid_Head.DataSource = file_explorer.FileList;

            //--------------------------------------------------------------------------------------------------------------------
            // file list 표시
            fgrid_Head.Font = new Font("Verdana", 8);
            fgrid_Head.ExtendLastCol = true;
            fgrid_Head.AllowEditing = false;
            fgrid_Head.Rows.Count = fgrid_Head.Rows.Fixed;
            fgrid_Head.Cols.Count = 3;
            fgrid_Head.Cols[0].Width = 20;
            fgrid_Head.Cols[2].Visible = false;
            fgrid_Head[fgrid_Head.Rows.Fixed - 1, 1] = "File Name";

            // 최신 수정된 파일부터 표시
            for (int i = file_explorer.FileList.Count - 1; i >= 0; i--)
            {

                fgrid_Head.Rows.Add();
                fgrid_Head[fgrid_Head.Rows.Count - 1, 1] = ((FileData)file_explorer.FileList[i]).Name.ToString();
                fgrid_Head[fgrid_Head.Rows.Count - 1, 2] = ((FileData)file_explorer.FileList[i]).FullName.ToString();

            } // end for i
            //--------------------------------------------------------------------------------------------------------------------





        }




        #region 그리드 관련 메서드



        private void Display_Detail()
        {


            if (fgrid_Head.Rows.Count <= fgrid_Head.Rows.Fixed) return;


            txt_SelectFileName.Text = fgrid_Head[fgrid_Head.Row, 1].ToString().Trim();
            txt_SelectFileName.Tag = fgrid_Head[fgrid_Head.Row, 2].ToString().Trim();  // file full name


            // .ZIP 해제
            C1.C1Zip.C1ZipFile zipFile = new C1.C1Zip.C1ZipFile();	// the zip file   
            string file_name = fgrid_Head[fgrid_Head.Row, 2].ToString().Trim(); // file full name
            zipFile.Open(file_name);
            zipFile.Entries.Extract(zipFile.Entries[0].FileName);



            Display_XML(file_name.Replace(".ZIP", ".XML").Replace(".zip", ".XML"));
            Display_Grid(file_name.Replace(".ZIP", ".XML").Replace(".zip", ".XML"));


        }



        /// <summary>
        /// Display_XML : 
        /// </summary>
        /// <param name="arg_file_name"></param>
        private void Display_XML(string arg_file_name)
        {

            this.Cursor = Cursors.WaitCursor;

            object temp = null;
            ax_xml_viewer.Navigate(arg_file_name, ref temp, ref temp, ref temp, ref temp);

            this.Cursor = Cursors.Default;

        }


        private DataSet _DSXML;


        /// <summary>
        /// Display_Grid : 
        /// </summary>
        /// <param name="arg_file_name"></param>
        private void Display_Grid(string arg_file_name)
        {


            this.Cursor = Cursors.WaitCursor;


            fgrid_Detail.Font = new Font("Verdana", 8);
            fgrid_Detail.Cols[0].Width = 20;

            _DSXML = new DataSet();

            _DSXML.ReadXml(arg_file_name, XmlReadMode.Auto);

            cmb_TableName.AddItemTitles("Table");


            for (int i = 0; i < _DSXML.Tables.Count; i++)
            {
                cmb_TableName.AddItem(_DSXML.Tables[i].TableName);
            }

            cmb_TableName.ValueMember = "Table";
            cmb_TableName.Splits[0].DisplayColumns[0].Width = 220;
            cmb_TableName.SelectedIndex = -1;
            cmb_TableName.SelectedIndex = 0;
            //Search();




            this.Cursor = Cursors.Default;

        }


        private void Search()
        {

            try
            {

                string table_name = cmb_TableName.SelectedValue.ToString();
                DataTable vDt = _DSXML.Tables[table_name];
                fgrid_Detail.DataSource = vDt;

                ClassLib.ComFunction.User_Message("Search Complete.", "Run Restore Search", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                ClassLib.ComFunction.User_Message("Search Failed.", "Run Restore Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }




        #endregion

        #region 버튼 이벤트 관련 메서드




        /// <summary>
        /// Run_Restore : 
        /// </summary>
        private void Run_Restore()
        {

            string message = "Do you continue restore ?";
            DialogResult result = ClassLib.ComFunction.User_Message(message, "Run Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Apply_DataBase();
            }
            else
            {
                return;
            }

        }




        /// <summary>
        /// Apply_DataBase : 
        /// </summary>
        private void Apply_DataBase()
        {


            DataSet ds_ret = new DataSet();
            DataSet ds_xml = new DataSet();
            string[] update_query = null;
            ArrayList query_array = new ArrayList();
            string col_list = null;
            string value_list = null;


            string strFullName = txt_SelectFileName.Tag.ToString().Trim().Replace(".ZIP", ".XML").Replace(".zip", ".XML");

            ds_xml.ReadXml(strFullName, XmlReadMode.Auto);



            for (int h = 0; h < ds_xml.Tables.Count; h++)
            {


                int col = ds_xml.Tables[h].Columns.Count;
                int row = ds_xml.Tables[h].Rows.Count;
                string where = "";
                string table = "";


                for (int i = 0; i < row; i++)
                {


                    if (!(ds_xml.Tables[h].Rows[i]["WHERE"] is System.DBNull))
                    {
                        where = ds_xml.Tables[h].Rows[i]["WHERE"].ToString();
                        table = ds_xml.Tables[h].TableName.ToString();

                        // 기존 데이타는 Delete
                        string delete_sql = " DELETE "
                                                + "    FROM " + table
                                                + "  WHERE " + where;


                        query_array.Add(delete_sql);

                        continue;
                    }

                    col_list = "";
                    value_list = "";


                    // 마지막 인덱스 찾기
                    int start_col = 0;
                    int end_col = ds_xml.Tables[h].Columns.Count - 3;
                    if (ds_xml.Tables[h].Columns["WHERE"].Ordinal == 0)
                    {
                        start_col++;
                        end_col++;
                    }


                    for (int j = start_col; j < end_col; j++)
                    {


                        if (ds_xml.Tables[h].Columns[j].ColumnName.ToString().Equals("WHERE")) continue;

                        string col_name = ds_xml.Tables[h].Columns[j].ColumnName.ToString() + ", ";
                        string col_type = ds_xml.Tables[h].Columns[j].Namespace.ToString();
                        string data_value = "";




                        if (col_type.ToString() == "System.DateTime")
                        {
                            if (ds_xml.Tables[h].Rows[i].ItemArray[j].ToString().Trim().Equals(""))
                            {
                                data_value = "'" + ds_xml.Tables[h].Rows[i].ItemArray[j].ToString() + "', ";
                            }
                            else
                            {
                                data_value = @"to_date('" + ds_xml.Tables[h].Rows[i].ItemArray[j].ToString() + @"', 'yyyy-mm-dd am hh:mi:ss'), ";
                            }

                        }
                        else
                        {
                            data_value = "'" + ds_xml.Tables[h].Rows[i].ItemArray[j].ToString().Replace("'", "''") + "', ";
                        }


                        col_list = col_list + col_name;
                        value_list = value_list + data_value;

                    }

                    col_list = col_list.Substring(0, col_list.Length - 2);
                    value_list = value_list.Substring(0, value_list.Length - 2);

                    string sql = " INSERT INTO " + table + " "
                                    + " (" + col_list + ")  "
                                    + " VALUES (" + value_list + ")";


                    query_array.Add(sql);


                } // end for(int j = start_col ; j < end_col ; j++)



            } // end for table count for(int i = 0 ; i < row ; i++)




            // 트랜잭션 처리 한 쿼리 실행
            update_query = (string[])query_array.ToArray(typeof(string));

            string db_result = Execute_Query(update_query);


            // ret 결과 값이 숫자이면 정상
            // 숫자가 아니면 오류 메세지 이므로 실패
            double temp = 0;


            try      // 성공
            {

                temp = Convert.ToDouble(db_result);

                ClassLib.ComFunction.User_Message("Restore Complete.", "Run Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch  // 실패
            {

                ds_xml.Dispose();
                ds_ret.Dispose();


                ClassLib.ComFunction.User_Message("Restore Failed.", "Run Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }







        }


        /// <summary>
        /// Execute_Query : 
        /// </summary>
        /// <param name="arg_query"></param>
        /// <returns></returns>
        private string Execute_Query(string[] arg_query)
        {



            try
            {

                string[] RunUser = COM.ComFunction.Set_UserInfo(COM.ComVar.Log_Type.Write_File_DB);

                string ret = Convert.ToString(ClassLib.ComVar._WebSvc.Ora_MultiModify(RunUser, arg_query));

                return ret.ToString();


            }
            catch
            {
                return "";
            }



        }





        #endregion



        #endregion

        #region 이벤트 처리


        private void fgrid_Head_DoubleClick(object sender, System.EventArgs e)
        {


            try
            {

                this.Cursor = Cursors.WaitCursor;


                Display_Detail();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Run Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }


        private void cmb_TableName_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;

                if (cmb_TableName.SelectedIndex == -1) return;

                Search();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "cmb_TableName_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void btn_Search_Click(object sender, System.EventArgs e)
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;


                Search();


            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "btn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void btn_Apply_Click(object sender, System.EventArgs e)
        {


            try
            {


                this.Cursor = Cursors.WaitCursor;


                Run_Restore();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }



        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {

            this.Close();

        }

       


        #endregion



    }
}