using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using C1.Win.C1FlexGrid;

namespace ERP.ErpCom
{
    public partial class Form_PC_DataDictionary : COM.APSWinForm.Form_Top
    {

        #region 생성자


        public Form_PC_DataDictionary()
        {
            InitializeComponent();
        
            //Init_Form();

        }


        #endregion

        #region 변수 정의


        private COM.OraDB MyOraDB = new COM.OraDB();

      
        #endregion

        #region 멤버 메서드


        #region 초기화

        /// <summary>
        /// Inti_Form : Form Load 시 초기화 작업
        /// </summary>
        private void Init_Form()
        {

            try
            {


                //Title
                this.Text = "Data Language Dictionary";
                lbl_MainTitle.Text = "Data Language Dictionary";


                //// 언어 적용
                //ClassLib.ComFunction.Set_Language_Dictionary(this);


                Init_Grid();

                Init_Control();



            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void Init_Grid()
        {

            fgrid_Main.Set_Grid("SPC_DATA_DIC", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Set_Action_Image(img_Action);
            
            //fgrid_Main.Font = new Font("Verdana", 7);
            fgrid_Main.ExtendLastCol = false;
           


        }


        /// <summary>
        /// Init_Control : 
        /// </summary>
        private void Init_Control()
        {


            // Disabled tbutton
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Color.Enabled = false;


            chk_Form.Checked = true;
            chk_Label.Checked = true;
            chk_Button.Checked = true;
            chk_RadioButton.Checked = true;
            chk_CheckBox.Checked = true;
            chk_GroupBox.Checked = true;



            // Factory Combobox Add Items
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);

            dt_ret.Dispose();

            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;



        }


        


        #endregion

        #region 툴바 이벤트 메서드



        /// <summary>
        /// Event_Tbtn_New : 
        /// </summary>
        private void Event_Tbtn_New()
        {

            //cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
            //cmb_Language.SelectedValue = ClassLib.ComVar.This_Lang;
            //txt_Program.Text = "";


            //chk_Form.Checked = true;
            //chk_Label.Checked = true;
            //chk_Button.Checked = true;
            //chk_RadioButton.Checked = true;
            //chk_CheckBox.Checked = true;
            //chk_GroupBox.Checked = true;
            //chk_Tooltip.Checked = false;


            txt_Program.Text = "";
            fgrid_Main.ClearAll();


            _DT_Scan_Dictionary = null;



            if (cmb_Factory.SelectedIndex == -1 || cmb_Language.SelectedIndex == -1) return;


            string factory = cmb_Factory.SelectedValue.ToString();
            string lang_cd = cmb_Language.SelectedValue.ToString();
            string pg_id = " ";

            DataTable dt_ret = SELECT_SPC_DATA_DIC_COMBO(factory, lang_cd, pg_id);
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_Program, 0, 1, true, 250, 50);
            cmb_Program.ValueMember = "CODE";
            cmb_Program.DisplayMember = "CODE";





        }



        /// <summary>
        /// Event_Tbtn_Search : 
        /// </summary>
        private void Event_Tbtn_Search()
        {

            //Scan_Dictionary_DataTable();
            Scan_Dictionary();

        }


        /// <summary>
        /// 
        /// </summary>
        private void Event_Tbtn_Save()
        {

            bool save_flag = MyOraDB.Save_FlexGird("PKG_SPC_DATA_DIC.SAVE_SPC_DATA_DIC", fgrid_Main);

            if (save_flag)
            {
                fgrid_Main.Refresh_Division();

                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave);
            }
            else
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave);
            }


            
        }


        private void Event_Tbtn_Delete()
        {

            if (fgrid_Main[fgrid_Main.Row, 0] == null || fgrid_Main[fgrid_Main.Row, 0].ToString() != "I")
            {
                fgrid_Main.Delete_Row();
            }
            else
            {
                fgrid_Main.Rows.Remove(fgrid_Main.Row);
            }

        }


        /// <summary>
        /// Event_Tbtn_Print : 
        /// </summary>
        private void Event_Tbtn_Print()
        {

            //saveFileDialog1.Filter = "Excel 파일|*.xls";

            //if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;


            //if (saveFileDialog1.FileName != "")
            //{

            //    fgrid_Main.SaveExcel(saveFileDialog1.FileName, FileFlags.IncludeFixedCells);

            //    ClassLib.ComFunction.User_Message("Complete Save to Excel file.", "Data Language Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}


        }



        #endregion

        #region 그리드 이벤트 메서드

        /// <summary>
        /// Event_fgrid_Main_BeforeEdit : 
        /// </summary>
        private void Event_fgrid_Main_BeforeEdit()
        {
            if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
            {
                fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
            }

        }


        /// <summary>
        /// Event_fgrid_Main_AfterEdit : 
        /// </summary>
        private void Event_fgrid_Main_AfterEdit()
        {

            string current_data = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();

            if (fgrid_Main.Buffer_CellData == current_data) return;

            fgrid_Main.Update_Row();

        }

        #endregion

        #region 버튼 및 기타 이벤트 메서드

        private void Form_PC_DataDictionary_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

  

        /// <summary>
        /// Event_cmb_Factory_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Factory_SelectedValueChanged()
        {


            if (cmb_Factory.SelectedIndex == -1) return;


            Event_Tbtn_New();




            string factory = cmb_Factory.SelectedValue.ToString();


            DataTable dt_ret = null;

            // language
            dt_ret = ClassLib.ComVar.Select_ComCode(factory, ClassLib.ComVar.CxLangCode);  // "DA02";
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Language, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name);

            dt_ret.Dispose();
            cmb_Language.SelectedValue = ClassLib.ComVar.This_Lang;

            

        }



        /// <summary>
        /// Event_cmb_Language_SelectedValueChanged : 
        /// </summary>
        private void Event_cmb_Language_SelectedValueChanged()
        {


            txt_Program.Text = "";
            fgrid_Main.ClearAll();


            if (cmb_Factory.SelectedIndex == -1 || cmb_Language.SelectedIndex == -1) return;


            string factory = cmb_Factory.SelectedValue.ToString();
            string lang_cd = cmb_Language.SelectedValue.ToString();
            string pg_id = ClassLib.ComFunction.Empty_TextBox(txt_Program, " ");

            DataTable dt_ret = SELECT_SPC_DATA_DIC_COMBO(factory, lang_cd, pg_id);

            //cmb_Program.DataMode = C1.Win.C1List.DataModeEnum.AddItem;

            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_Program, 0, 1, true, 250, 50);
            cmb_Program.ValueMember = "CODE";
            cmb_Program.DisplayMember = "CODE";



        }


        private void Event_cmb_Program_SelectedValueChanged()
        {

            if (cmb_Program.SelectedIndex == -1) return;

            
            if (txt_Program.Text.Trim() != cmb_Program.SelectedValue.ToString())
            {
                _DT_Scan_Dictionary = null;
            }



            txt_Program.Text = cmb_Program.SelectedValue.ToString();
            

            Scan_Dictionary();

        }




        /// <summary>
        /// Event_btn_OpenFile_Click : 
        /// </summary>
        private void Event_btn_OpenFile_Click()
        {


            if (cmb_Factory.SelectedIndex == -1 || cmb_Language.SelectedIndex == -1) return;





            //cs파일 선택 
            openFileDialog1.Filter = "cs 파일 (*.cs)|*.cs|모든 파일(*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;


            string file_full_name = openFileDialog1.FileName;

            int div = file_full_name.LastIndexOf(@"\");
            string filename1 = file_full_name.Substring(div + 1);
            div = filename1.LastIndexOf(".");
            string file_name = filename1.Substring(0, div);

            txt_Program.Text = file_name;
            txt_Program.Tag = file_full_name;


            if (txt_Program.Text.Length == 0)
            {
                ClassLib.ComFunction.User_Message("Select **.cs file");
                return;
            }
            

            string factory = cmb_Factory.SelectedValue.ToString();
            string lang_cd = cmb_Language.SelectedValue.ToString();
            string pg_id = txt_Program.Tag.ToString().Trim().Replace(@"\", @".").Replace(@".cs", "");
            div = pg_id.IndexOf("Flex", 0);
            pg_id = pg_id.Substring(div);



            string duplicate_yn = CHECK_SPC_DATA_DIC_DUPLICATE(factory, lang_cd, pg_id); 




            // 한번 적용 된 후 refresh 하기 -> 신규 입력 여부 판단하여 조회, 신규표시 등등
            //if (cmb_Program.FindString(txt_Program.Text.Trim(), 0, 0) == -1)
            if(duplicate_yn == "N")
            {

                pg_id = " ";

                DataTable dt_ret = SELECT_SPC_DATA_DIC_COMBO(factory, lang_cd, pg_id);
                DataRow newrow = dt_ret.NewRow();
                newrow[0] = file_name;
                newrow[1] = file_full_name;
                dt_ret.Rows.Add(newrow);

                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_Program, 0, 1, true, 250, 50);
                cmb_Program.ValueMember = "CODE";
                cmb_Program.DisplayMember = "CODE";

                txt_Program.Text = file_name;


                Scan_Dictionary_DataTable();
                //Scan_Dictionary();

            }


            cmb_Program.SelectedValue = txt_Program.Text.Trim();
            


        }



        private DataTable _DT_Scan_Dictionary;


        /// <summary>
        /// Scan_Dictionary_DataTable : 
        /// </summary>
        private void Scan_Dictionary_DataTable()
        {

            // data table 생성
            #region data table 생성
            _DT_Scan_Dictionary = new DataTable("Scan Dictionary");

            #endregion

            // data column 생성
            #region data column 생성


            for (int i = 0; i < fgrid_Main.Cols.Count; i++)
            {
                _DT_Scan_Dictionary.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
            } // end for i


            _DT_Scan_Dictionary.Columns[(int)ClassLib.TBSPC_DATA_DIC.IxFACTORY].ColumnName = "FACTORY"; 
            _DT_Scan_Dictionary.Columns[(int)ClassLib.TBSPC_DATA_DIC.IxLAN_CD].ColumnName = "LAN_CD"; 
            _DT_Scan_Dictionary.Columns[(int)ClassLib.TBSPC_DATA_DIC.IxPG_PROJ].ColumnName = "PG_PROJ";
            _DT_Scan_Dictionary.Columns[(int)ClassLib.TBSPC_DATA_DIC.IxPG_ID].ColumnName = "PG_ID";
            _DT_Scan_Dictionary.Columns[(int)ClassLib.TBSPC_DATA_DIC.IxCTL_NAME].ColumnName = "CTL_NAME"; 
            _DT_Scan_Dictionary.Columns[(int)ClassLib.TBSPC_DATA_DIC.IxSTD_TEXT].ColumnName = "STDTEXT";

            #endregion

            // data row생성
            #region data row 생성


            string file_full_name = txt_Program.Tag.ToString();
            System.IO.FileStream file = new System.IO.FileStream(file_full_name, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.StreamReader sr = new System.IO.StreamReader(file, Encoding.GetEncoding("euc-kr"));

            string next_line;
            string name_space = "" ;


            while ((next_line = sr.ReadLine()) != null)
            {

                

                if (next_line.IndexOf("namespace ") != -1)
                {
                    name_space = next_line.Replace("namespace ", "");
                }

                //Form 텍스트 추출
                if (chk_Form.Checked)
                {
                    if (next_line.IndexOf("this.Text = ") != -1)
                    {
                        InsertData(name_space, txt_Program.Text, "Form", next_line);
                    }
                }



                //Label 텍스트 추출
                if (chk_Label.Checked)
                {

                    if (next_line.IndexOf("this." + chk_Label.Tag.ToString()) != -1
                        || next_line.IndexOf(chk_Label.Tag.ToString()) != -1)
                    {


                        if (next_line.IndexOf("Text = ") != -1)
                        {
                            InsertData(name_space, txt_Program.Text, "Label", next_line);
                        }


                    } // end if

                } // end if (chk_Label.Checked)



                //button 텍스트 추출
                if (chk_Button.Checked)
                {
                    if (next_line.IndexOf("this." + chk_Button.Tag.ToString()) != -1
                        || next_line.IndexOf(chk_Button.Tag.ToString()) != -1)
                    {

                        if (next_line.IndexOf("Text = ") != -1)
                        {
                            InsertData(name_space, txt_Program.Text, "Button", next_line);
                        }


                    }
                }


                //radio button 텍스트 추출
                if (chk_RadioButton.Checked)
                {
                    if (next_line.IndexOf("this." + chk_RadioButton.Tag.ToString()) != -1
                        || next_line.IndexOf(chk_RadioButton.Tag.ToString()) != -1)
                    {

                        if (next_line.IndexOf("Text = ") != -1)
                        {
                            InsertData(name_space, txt_Program.Text, "RadioButton", next_line);
                        }


                    }
                }


                //check box 텍스트 추출
                if (chk_CheckBox.Checked)
                {

                    if (next_line.IndexOf("this." + chk_CheckBox.Tag.ToString()) != -1
                        || next_line.IndexOf(chk_CheckBox.Tag.ToString()) != -1)
                    {

                        if (next_line.IndexOf("Text = ") != -1)
                        {
                            InsertData(name_space, txt_Program.Text, "CheckBox", next_line);
                        }

                    }
                }


                //group box 텍스트 추출
                if (chk_GroupBox.Checked)
                {

                    if (next_line.IndexOf("this." + chk_GroupBox.Tag.ToString()) != -1
                        || next_line.IndexOf(chk_GroupBox.Tag.ToString()) != -1)
                    {

                        if (next_line.IndexOf("Text = ") != -1)
                        {
                            InsertData(name_space, txt_Program.Text, "GroupBox", next_line);
                        }

                    }
                }

            }



            sr.Close();


            #endregion


        }




        /// <summary>
        /// Scan_Dictionary : 
        /// </summary>
        private void Scan_Dictionary()
        {


            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;



            string factory = cmb_Factory.SelectedValue.ToString();
            string lang_cd = cmb_Language.SelectedValue.ToString();
            
            string pg_proj = "";
            string pg_id = "";

            //if (_DT_Scan_Dictionary != null || _DT_Scan_Dictionary.Rows.Count > 0)
            //{
            //    pg_proj = _DT_Scan_Dictionary.Rows[0].ItemArray[(int)ClassLib.TBSPC_DATA_DIC.IxPG_PROJ].ToString();
            //    pg_id = _DT_Scan_Dictionary.Rows[0].ItemArray[(int)ClassLib.TBSPC_DATA_DIC.IxPG_ID].ToString();
            //}
            //else
            //{
            //    pg_proj = cmb_Program.Columns[1].Text;
            //    pg_id = cmb_Program.SelectedValue.ToString();
            //}


            if (_DT_Scan_Dictionary == null)
            {
                pg_proj = cmb_Program.Columns[1].Text;
                pg_id = cmb_Program.SelectedValue.ToString();
            }
            else
            {
                pg_proj = _DT_Scan_Dictionary.Rows[0].ItemArray[(int)ClassLib.TBSPC_DATA_DIC.IxPG_PROJ].ToString();
                pg_id = _DT_Scan_Dictionary.Rows[0].ItemArray[(int)ClassLib.TBSPC_DATA_DIC.IxPG_ID].ToString();
            }



            DataTable dt_ret = Select_SPC_DATA_DIC(factory, lang_cd, pg_proj, pg_id);

            //if (dt_ret == null || dt_ret.Rows.Count == 0) return;

            // db data 표시
            fgrid_Main.Display_Grid(dt_ret, false);






            // 중복이나 신규 처리
            if (_DT_Scan_Dictionary == null) return;




            string scan_data = "";


            for (int i = 0; i < _DT_Scan_Dictionary.Rows.Count; i++)
            {

                scan_data = _DT_Scan_Dictionary.Rows[i].ItemArray[(int)ClassLib.TBSPC_DATA_DIC.IxCTL_NAME].ToString();

                int find_row = fgrid_Main.FindRow(scan_data, fgrid_Main.Rows.Fixed, (int)ClassLib.TBSPC_DATA_DIC.IxCTL_NAME, false, true, false);


                if (find_row == -1) // 신규
                {

                    fgrid_Main.Rows.Add();

                    for (int j = 0; j < fgrid_Main.Cols.Count; j++)
                    {
                        fgrid_Main[fgrid_Main.Rows.Count - 1, j] = _DT_Scan_Dictionary.Rows[i].ItemArray[j].ToString();
                    }

                    fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "I";


                }
                else // 중복
                {

                    for (int j = 1; j < fgrid_Main.Cols.Count; j++)
                    {
                        fgrid_Main[find_row, j] = _DT_Scan_Dictionary.Rows[i].ItemArray[j].ToString();
                    }


                    //fgrid_Main[find_row, 0] = "U";


                }


            } // end for i




                    
        }


        /// <summary>
        /// InsertData : 
        /// </summary>
        /// <param name="arg_name_space"></param>
        /// <param name="arg_file_name"></param>
        /// <param name="arg_desc"></param>
        /// <param name="arg_next_line"></param>
        /// <returns></returns>
        private void InsertData(string arg_name_space, string arg_file_name, string arg_desc, string arg_next_line)
        {

            int start_div = -1;

            if (arg_next_line.IndexOf("this") == -1)
            {
                start_div = -1;
            }
            else
            {
                start_div = arg_next_line.Trim().IndexOf(".");
            }
          
            
            int stop_div = arg_next_line.Trim().LastIndexOf(".Text = ");

            string name = "";

            if (start_div < stop_div)
            {
                name = arg_next_line.Trim().Substring(start_div + 1, (stop_div - start_div) - 1);
            }


            // control 명이 없는 경우 : this.text 인 경우이므로 "Form" 이라고 설정해 줌
            if (name.Trim().Equals(""))
            {
                name = "Form";
            }



            start_div = arg_next_line.Trim().IndexOf("\"");
            stop_div = arg_next_line.Trim().LastIndexOf("\"");

            string text = "";

            if (start_div < stop_div)
            {
                text = arg_next_line.Trim().Substring(start_div + 1, (stop_div - start_div) - 1);
            }

            


            DataRow newrow = _DT_Scan_Dictionary.NewRow();

            for (int i = 0; i < _DT_Scan_Dictionary.Columns.Count; i++)
            {
                newrow[i] = "";
            }

            newrow["FACTORY"] = cmb_Factory.SelectedValue.ToString();
            newrow["LAN_CD"] = cmb_Language.SelectedValue.ToString();
            newrow["PG_PROJ"] = arg_name_space; // pg_project
            newrow["PG_ID"] = arg_file_name; // pg_id
            newrow["CTL_NAME"] = name; // control name
            newrow["STDTEXT"] = text; // text

            _DT_Scan_Dictionary.Rows.Add(newrow);




        }

  


        #endregion

        #region 컨텍스트 메뉴 이벤트 메서드

        #endregion



        #endregion

        #region 이벤트 처리

        #region 툴바 이벤트


        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_New();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Search();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Save();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Delete();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_Tbtn_Print();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }



        #endregion

        #region 그리드 이벤트

        private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {

            try
            {
                Event_fgrid_Main_AfterEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {

            try
            {
                Event_fgrid_Main_BeforeEdit();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_fgrid_Main_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #endregion

        #region 버튼 및 기타 이벤트


        #region 버튼클릭시 이미지변경


        private void btn_MouseHover(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }

        }

        private void btn_MouseLeave(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }

        }

        private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 0, 2, 4
            if (src.ImageIndex % 2 == 0)
            {
                src.ImageIndex = src.ImageIndex + 1;
            }
        }

        private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Windows.Forms.Label src = sender as System.Windows.Forms.Label;

            //image index default : 1, 3, 5
            if (src.ImageIndex % 2 == 1)
            {
                src.ImageIndex = src.ImageIndex - 1;
            }
        }




        #endregion



        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Factory_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

     
        private void cmb_Language_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Language_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Language_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void cmb_Program_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Program_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Program_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_btn_OpenFile_Click();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_OpenFile_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }



        #endregion

        #region 컨텍스트 메뉴 이벤트

     

        #endregion

        #endregion

        #region 디비 연결


        #region 콤보


        /// <summary>
        /// SELECT_SPC_DATA_DIC_COMBO : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_lang_cd"></param>
        /// <param name="arg_pg_id"></param>
        /// <returns></returns>
        private DataTable SELECT_SPC_DATA_DIC_COMBO(string arg_factory, string arg_lang_cd, string arg_pg_id)
        {

            try
            {

                MyOraDB.ReDim_Parameter(4);


                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SPC_DATA_DIC.SELECT_SPC_DATA_DIC_COMBO";


                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LANG_CD";
                MyOraDB.Parameter_Name[2] = "ARG_PG_ID";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_lang_cd;
                MyOraDB.Parameter_Values[2] = arg_pg_id;
                MyOraDB.Parameter_Values[3] = "";



                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];


            }
            catch
            {
                return null;
            }


        }



        #endregion

        #region 조회




        /// <summary>
        /// Select_SPC_DATA_DIC : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_lang_cd"></param>
        /// <param name="arg_pg_proj"></param>
        /// <param name="arg_pg_id"></param>
        /// <returns></returns>
        private DataTable Select_SPC_DATA_DIC(string arg_factory, string arg_lang_cd, string arg_pg_proj, string arg_pg_id)
        {

            try
            {

                MyOraDB.ReDim_Parameter(5);


                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SPC_DATA_DIC.SELECT_SPC_DATA_DIC";


                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LANG_CD";
                MyOraDB.Parameter_Name[2] = "ARG_PG_PROJ";
                MyOraDB.Parameter_Name[3] = "ARG_PG_ID";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                   
                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_lang_cd;
                MyOraDB.Parameter_Values[2] = arg_pg_proj;
                MyOraDB.Parameter_Values[3] = arg_pg_id;
                MyOraDB.Parameter_Values[4] = "";



                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];


            }
            catch
            {
                return null;
            }


        }



        /// <summary>
        /// CHECK_SPC_DATA_DIC_DUPLICATE : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_lang_cd"></param>
        /// <param name="arg_pg_id"></param>
        /// <returns></returns>
        private string CHECK_SPC_DATA_DIC_DUPLICATE(string arg_factory, string arg_lang_cd, string arg_pg_id)
        {

            try
            {

                MyOraDB.ReDim_Parameter(4);


                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SPC_DATA_DIC.CHECK_SPC_DATA_DIC_DUPLICATE";


                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LANG_CD";
                MyOraDB.Parameter_Name[2] = "ARG_PG_ID";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;



                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_lang_cd;
                MyOraDB.Parameter_Values[2] = arg_pg_id;
                MyOraDB.Parameter_Values[3] = "";



                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return "N";
                if (ds_ret.Tables[MyOraDB.Process_Name].Rows.Count == 0) return "N";

                return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString();


            }
            catch
            {
                return "N";
            }


        }




        #endregion

       
        #endregion

       


    }
}