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
    public partial class Pop_Sch_Management_File : COM.PCHWinForm.Pop_Large_Light
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private string _factory  = "";
        private string _model_id = "";
        private string _srf_no   = "";
        private string _bom_id   = "";
        private string _nf_cd    = "";
        private string _nf_seq   = "";
        private string _tk_cd    = "";
        #endregion

        #region 생성자
        public Pop_Sch_Management_File()
        {
            InitializeComponent();
        }
        public Pop_Sch_Management_File(string [] arg_value)
        {
            _factory  = arg_value[0];
            _model_id = arg_value[1];
            _srf_no   = arg_value[2];
            _bom_id   = arg_value[3];
            _nf_cd    = arg_value[4];
            _nf_seq   = arg_value[5];
            _tk_cd    = arg_value[6];

            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Pop_Sch_Management_File_Load(object sender, EventArgs e)
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

            fgrid_main.Set_Grid_CDC("SXC_SCH_MNG_POP", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);            
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.ExtendLastCol = false;

            c1ToolBar1.Visible = false;

            Display_Data();
        }

        private void Display_Data()
        {
            DataTable dt_ret = SELECT_SCH_HEAD_FILE_LIST();

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_main.Rows.Add();

                for (int j = 0; j < fgrid_main.Cols.Count; j++)
                {
                    fgrid_main[fgrid_main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString();
                }

                fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxFILE_SEQ, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxUPD_YMD).StyleNew.BackColor = Color.White;
            }

            if (dt_ret.Rows.Count.Equals(1))
            {
                fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxCHK] = "TRUE";

                btn_apply_Click(null, null);
            }            
        }
        private DataTable SELECT_SCH_HEAD_FILE_LIST()
        {
            MyOraDB.ReDim_Parameter(8);
            MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_HEAD_POP";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
            MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[4] = "ARG_NF_CD";
            MyOraDB.Parameter_Name[5] = "ARG_NF_SEQ";
            MyOraDB.Parameter_Name[6] = "ARG_TK_CD";
            MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = _factory;
            MyOraDB.Parameter_Values[1] = _model_id;
            MyOraDB.Parameter_Values[2] = _srf_no;
            MyOraDB.Parameter_Values[3] = _bom_id;
            MyOraDB.Parameter_Values[4] = _nf_cd;
            MyOraDB.Parameter_Values[5] = _nf_seq;
            MyOraDB.Parameter_Values[6] = _tk_cd;
            MyOraDB.Parameter_Values[7] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Button Control
        private void btn_apply_Click(object sender, EventArgs e)
        {

            string save_path = "C:\\Program Files\\PCC_Sephiroth\\sch_file";


            DirectoryInfo dr = new DirectoryInfo(save_path);

            if (!dr.Exists)
            {
                dr.Create();
            }

            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                try
                {
                    string chk = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxCHK].ToString().Trim().ToUpper();

                    if (chk.Equals("TRUE"))
                    {
                        string factory = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxFACTORY].ToString().Trim();
                        string file_cd = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxFILE_CD].ToString().Trim();
                        string file_name = int.Parse(fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxFILE_CD].ToString()).ToString() + "_"
                        + fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxFILE_NAME].ToString().Trim().Replace("/", "_");

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
                    string file_name = int.Parse(fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxFILE_CD].ToString()).ToString() + "_"
                        + fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxFILE_NAME].ToString().Trim().Replace("/", "_");

                    MessageBox.Show(file_name + "\r\n\r\nThis File have a problem,\r\n\r\nPlease ask System.");
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
                        string chk = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxCHK].ToString().Trim().ToUpper();

                        if (chk.Equals("TRUE"))
                        {
                            string factory = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxFACTORY].ToString().Trim();
                            string file_cd = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxFILE_CD].ToString().Trim();
                            string file_name = "NO" + int.Parse(fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxFILE_CD].ToString()).ToString() + "_"
                                               + fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxBOM_ID].ToString() + "_"
                                               + fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxFILE_NAME].ToString().Trim().Replace("/", "_");

                            string file_path = save_path + "\\" + file_name;
                            File.WriteAllBytes(file_path, SELECT_FILE(factory, file_cd));                            
                        }
                    }
                    catch
                    {
                        string file_name = fgrid_main[i, (int)ClassLib.TBSXC_SCH_MANAGEMENT_POP.IxFILE_NAME].ToString().Trim().Replace("/", "_");

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

        private DataTable SELECT_SCH_HEAD_FILE(string arg_file_seq)
        {
            MyOraDB.ReDim_Parameter(8);
            MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_HEAD_FILE";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
            MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[4] = "ARG_NF_CD";
            MyOraDB.Parameter_Name[5] = "ARG_NF_SEQ";
            MyOraDB.Parameter_Name[6] = "ARG_FILE_SEQ";
            MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = _factory;
            MyOraDB.Parameter_Values[1] = _model_id;
            MyOraDB.Parameter_Values[2] = _srf_no;
            MyOraDB.Parameter_Values[3] = _bom_id;
            MyOraDB.Parameter_Values[4] = _nf_cd;
            MyOraDB.Parameter_Values[5] = _nf_seq;
            MyOraDB.Parameter_Values[6] = arg_file_seq;
            MyOraDB.Parameter_Values[7] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region SQL Server 관련
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
        #endregion

        
    }
}


