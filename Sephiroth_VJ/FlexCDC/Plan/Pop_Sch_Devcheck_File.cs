using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;

namespace FlexCDC.Plan
{
    public partial class Pop_Sch_Devcheck_File : COM.PCHWinForm.Pop_Large_Light
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private string _form_type;
        private string[] _main_value;
        #endregion

        #region Resource
        public Pop_Sch_Devcheck_File()
        {
            InitializeComponent();
        }
        public Pop_Sch_Devcheck_File(string arg_form_type, string [] arg_value)
        {
            _form_type = arg_form_type;
            _main_value = arg_value;
            InitializeComponent();
        }
        
        #endregion

        #region Form Loading
        private void Pop_Sch_Devcheck_File_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch
            {

            }
            finally
            {

            }
        }       

        private void Init_Form()
        {
            this.Text = "File Loading";
            this.lbl_MainTitle.Text = "File Loading";

            fgrid_main.Set_Grid_CDC("SXC_SCH_DEVCHECK_POP", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);            
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.ExtendLastCol = false;
            fgrid_main.Set_Action_Image(img_Action);

            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = false;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = true;
            tbtn_Print.Enabled   = false;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled  = false;

            Display_Data();
        }

        private void Display_Data()
        {
            if (_form_type.Equals("DEV"))
            {
                fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

                DataTable dt_ret = SELECT_SCH_DEVCHECK_FILE_POP();

                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {
                    fgrid_main.Rows.Add();

                    for (int j = 0; j < fgrid_main.Cols.Count; j++)
                    {
                        fgrid_main[fgrid_main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString();
                    }
                }
            }
            else
            {
                fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

                DataTable dt_ret = SELECT_SCH_MNG_FILE_POP();

                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {
                    fgrid_main.Rows.Add();

                    for (int j = 0; j < fgrid_main.Cols.Count; j++)
                    {
                        fgrid_main[fgrid_main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString();
                    }
                } 
            }
        }
        private DataTable SELECT_SCH_MNG_FILE_POP()
        {
            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_MNG_FILE_POP";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
            MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = _main_value[0];
            MyOraDB.Parameter_Values[1] = _main_value[1];
            MyOraDB.Parameter_Values[2] = _main_value[2];
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];            
        }
        private DataTable SELECT_SCH_DEVCHECK_FILE_POP()
        {
            MyOraDB.ReDim_Parameter(9);
            MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_DEVCHECK_FILE_POP";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";            
            MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
            MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[4] = "ARG_MODEL";
            MyOraDB.Parameter_Name[5] = "ARG_USER";
            MyOraDB.Parameter_Name[6] = "ARG_CHK_PT";
            MyOraDB.Parameter_Name[7] = "ARG_CHK_IMAGE";
            MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;            
            MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = _main_value[0];
            MyOraDB.Parameter_Values[1] = _main_value[1];
            MyOraDB.Parameter_Values[2] = _main_value[2];
            MyOraDB.Parameter_Values[3] = _main_value[3];
            MyOraDB.Parameter_Values[4] = _main_value[4];
            MyOraDB.Parameter_Values[5] = _main_value[5];
            MyOraDB.Parameter_Values[6] = _main_value[6];
            MyOraDB.Parameter_Values[7] = _main_value[7];
            MyOraDB.Parameter_Values[8] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Button Control
        private void btn_apply_Click(object sender, EventArgs e)
        {
            string save_path = Application.StartupPath + "\\" + "sch_file";


            DirectoryInfo dr = new DirectoryInfo(save_path);

            if (!dr.Exists)
            {
                dr.Create();
            }

            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                try
                {
                    string chk = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxCHK].ToString().Trim().ToUpper();

                    if (chk.Equals("TRUE"))
                    {
                        string factory = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFACTORY].ToString().Trim();
                        string file_cd = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFILE_CD].ToString().Trim();
                        string file_name = "NO" + int.Parse(fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFILE_CD].ToString()).ToString() + "_"
                                           + fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxSEASON_V].ToString() + "_"
                                           + fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxMODEL].ToString() + "_"
                                           + fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFILE_NAME].ToString().Trim().Replace("/", "_");

                        string file_path = save_path + "\\" + file_name;

                        File.WriteAllBytes(file_path, SELECT_FILE(factory, file_cd));

                        ProcessStartInfo ps = new ProcessStartInfo();
                        ps.WorkingDirectory = save_path;
                        ps.FileName = file_name;

                        Process.Start(ps);
                    }
                }
                catch
                {
                    string file_name = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFILE_NAME].ToString().Trim().Replace("/", "_");

                    MessageBox.Show(file_name + "\r\n\r\nThis File have a problem, \r\n\r\nPlease ask System.");
                    continue;
                }
            }

            this.Close();

            
        }
        private void btn_download_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog save_file = new FolderBrowserDialog();

            if (save_file.ShowDialog() == DialogResult.OK)
            {
                string save_path = save_file.SelectedPath;

                for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                {
                    try
                    {
                        string chk   = fgrid_main[i,  (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxCHK].ToString().Trim().ToUpper();

                        if (chk.Equals("TRUE"))
                        {
                            string factory = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFACTORY].ToString().Trim();
                            string file_cd = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFILE_CD].ToString().Trim();
                            string file_name = "NO" + int.Parse(fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFILE_CD].ToString()).ToString() + "_" 
                                               + fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxSEASON_V].ToString() + "_"
                                               + fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxMODEL].ToString() + "_"
                                               + fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFILE_NAME].ToString().Trim().Replace("/", "_");
                            
                            string file_path = save_path + "\\" + file_name;

                            File.WriteAllBytes(file_path, SELECT_FILE(factory, file_cd));
                        }
                    }
                    catch
                    {
                        string file_name = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFILE_NAME].ToString().Trim().Replace("/", "_");

                        MessageBox.Show(file_name + "\r\nThis File have a problem,\r\nPlease ask System.");
                        continue;
                    }
                }

                MessageBox.Show("File Download Completed.");
                this.Close();
            }            
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        #endregion

        #region TBTN Button Event
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                {
                    string div = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxDIV].ToString().Trim();

                    if (div.Equals("D"))
                    {
                        string arg_factory = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFACTORY].ToString().Trim();
                        string arg_file_cd = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFILE_CD].ToString().Trim();

                        if (DELETE_FILE(arg_factory, arg_file_cd))
                        {
                            string[] arg_value = new string[4];

                            arg_value[0] = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFACTORY].ToString().Trim();
                            arg_value[1] = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxMODEL_ID].ToString().Trim();
                            arg_value[2] = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxSRF_NO].ToString().Trim();
                            arg_value[3] = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxFILE_SEQ].ToString().Trim();

                            if (DELETE_SCH_HEAD_FILE(arg_value))
                            {
                                Display_Data(); 
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                {
                    string chk = fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxCHK].ToString().Trim().ToUpper();

                    if (chk.Equals("TRUE"))
                    {
                        fgrid_main[i, (int)ClassLib.TBSXC_SCH_DEVCHECK_POP.IxDIV] = "D";
                    }
                }
            }
            catch
            {
 
            }
        }

        private bool DELETE_SCH_HEAD_FILE(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_03.DELETE_SXC_SCH_HEAD_FILE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_FILE_SEQ";
                
                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                
                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                
                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "File Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region SQL Server
        private SqlConnection SQL_CONNECTION()
        {
            try
            {
                string sqlConnection = "server=203.228.108.30;database=PCC_Schedule;uid=sa;pwd=csiroot1128;Connection Timeout=300;";
                if (COM.ComVar.This_Factory.Equals("VJ"))
                    sqlConnection = "server=211.54.128.3;database=PCC_Schedule;uid=sa;pwd=csiroot1;Connection Timeout=300;";
                if(COM.ComVar.This_Factory.Equals("QD"))
                    sqlConnection = "server=119.119.119.18;database=PCC_Schedule;uid=sa;pwd=csiroot1;Connection Timeout=300;";
                
                SqlConnection conn = new SqlConnection(sqlConnection);
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {

            }
        }
        
        private string select_query()
        {
            string select_query = "SELECT RAW_FILE FROM SXC_SCH_FILE WHERE FACTORY = @FACTORY AND FILE_CD = @FILE_CD";

            return select_query;
        }
        private string delete_query()
        {
            string select_query = "DELETE FROM SXC_SCH_FILE WHERE FACTORY = @FACTORY AND FILE_CD = @FILE_CD";

            return select_query;
        }
        private byte[] SELECT_FILE(string arg_factory, string arg_file_cd)
        {
            try
            {               
                SqlConnection conn = SQL_CONNECTION();
                conn.Open();

                SqlCommand com = new SqlCommand(select_query(), conn);
                com.Parameters.AddWithValue("@FACTORY", arg_factory);
                com.Parameters.AddWithValue("@FILE_CD", arg_file_cd);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds, "SXC_SCH_FILE");
                byte[] MyData = null;


                if(ds.Tables[0].Rows.Count > 0)
                {
                    MyData = (byte[])ds.Tables[0].Rows[0].ItemArray[0];
                }
                
                conn.Close();

                return MyData;
            }
            catch
            {
                return null;
            }
        }
        private bool DELETE_FILE(string arg_factory, string arg_file_cd)
        {
            try
            {                
                SqlConnection conn = SQL_CONNECTION();
                conn.Open();

                SqlCommand com = new SqlCommand(delete_query(), conn);
                com.Parameters.AddWithValue("@FACTORY", arg_factory);
                com.Parameters.AddWithValue("@FILE_CD", arg_file_cd);                

                com.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion                

    }
}


