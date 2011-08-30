using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;
using System.Text;

namespace FlexCDC.Plan
{
    public partial class Form_Plan_ws : COM.PCHWinForm.Form_Top
    {
        #region 사용자 정의 변수
        private int _RowFixed;
        private COM.OraDB OraDB = new COM.OraDB();        
        private string tmp_factory = null;
        private string tmp_op_cd = null;
        private string tmp_dir_ymd = null;
        private COM.ComFunction comfunction = new COM.ComFunction();
        private Encoding K_Encode = Encoding.GetEncoding("euc-kr");
        private bool grid_size = false;
        #endregion

        #region 리소스 정의
        public Form_Plan_ws()
        {
            InitializeComponent();
        }        
        public Form_Plan_ws(string arg_factory, string arg_op_cd, string arg_dir_ymd)
        {
            InitializeComponent();
            
            tmp_factory = arg_factory;
            tmp_op_cd   = arg_op_cd;
            tmp_dir_ymd = arg_dir_ymd;
        }
        #endregion
        
        #region Form Loading
        private void Form_Plan_ws_Load(object sender, EventArgs e)
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
        }
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_factory.SelectedIndex == -1) return;
                COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
                Init_Form();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void Init_Form()
        {
            this.Text = "PCC_Daily Worksheet";
            this.lbl_MainTitle.Text = "PCC_Daily Worksheet";
            
            //OP Setting
            DataTable dt_ret = Select_op_cd();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_opcd, 0, 1, false, 40, 120);

            //Grid Setting
            flg_wsheet.Set_Grid_CDC("SXB_PJ_PRODUCT_SW", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            flg_wsheet.Set_Action_Image(img_Action);
            flg_wsheet.ExtendLastCol = false;
            _RowFixed = flg_wsheet.Rows.Count;

            
            if (tmp_factory != null)//Form을 MPS에서 Loading 했을 경우
            {                
                cmb_opcd.SelectedValue = tmp_op_cd;
                dpk_sw_date.Text = comfunction.ConvertDate2Type(tmp_dir_ymd);
            }
            else
            {
                cmb_opcd.SelectedValue = "";
                dpk_sw_date.Value = DateTime.Now;
            }

            //Button Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Insert.Enabled  = false;
            tbtn_Print.Enabled   = true;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;

            Set_Grid(cmb_factory.SelectedValue.ToString(), cmb_opcd.SelectedValue.ToString(), dpk_sw_date.Value.ToString("yyyyMMdd"));

            flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxCATEGORY].Visible  = false;
            flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxSEASON].Visible    = false;
            //flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxBOM_STYLE].Visible = false;
            flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxGEN_SIZE].Visible  = false;

            
            string power_level = ClassLib.ComVar.This_CDCPower_Level.ToString();

            if (power_level.Substring(0, 1) != "W" && power_level != "S00")
            {
                flg_wsheet.AllowEditing = false;
                tbtn_Save.Enabled = false;
            }
            
        }
        
        private DataTable Select_op_cd()
        {
            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = "pkg_sxg_mps_02_select.select_op_cd_add_ets";

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[OraDB.Process_Name];
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                flg_wsheet.Rows.Count = flg_wsheet.Rows.Fixed;

                Set_Grid(cmb_factory.SelectedValue.ToString(), cmb_opcd.SelectedValue.ToString(), dpk_sw_date.Value.ToString("yyyyMMdd"));
            }
            catch
            {
 
            }
        }
        
        private void Set_Grid(string arg_factory, string arg_op_cd, string arg_dir_ymd)
        {

            string op = (arg_op_cd == "")?"ETS":arg_op_cd;

            DataTable dt_list = Select_daily_worksheet(arg_factory, op, arg_dir_ymd);
            float sum_qty = 0;

            flg_wsheet.AllowEditing = true;

            for (int i = 0; i < dt_list.Rows.Count; i++)
            {
                flg_wsheet.AddItem(dt_list.Rows[i].ItemArray);                
                string status = flg_wsheet[flg_wsheet.Rows.Count - 1, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxSTATUS].ToString();

                if (status.Equals("C"))//Confirm된 데이터 일때
                {
                    flg_wsheet.GetCellRange(flg_wsheet.Rows.Count - 1, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxCATEGORY, flg_wsheet.Rows.Count - 1, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxREMARKS).StyleNew.ForeColor = Color.Red;
                    //flg_wsheet.Rows[flg_wsheet.Rows.Count - 1].StyleNew.ForeColor = Color.Red;
                    flg_wsheet.Rows[flg_wsheet.Rows.Count - 1].AllowEditing = false;
                }
                else
                {
                    flg_wsheet.GetCellRange(flg_wsheet.Rows.Count - 1, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxCATEGORY, flg_wsheet.Rows.Count - 1, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxREMARKS).StyleNew.ForeColor = Color.Black;
                    //flg_wsheet.Rows[flg_wsheet.Rows.Count - 1].StyleNew.ForeColor = Color.Black;
                    flg_wsheet.Rows[flg_wsheet.Rows.Count - 1].AllowEditing = true; 
                }
                sum_qty = sum_qty + float.Parse(flg_wsheet[flg_wsheet.Rows.Count - 1, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxFGA_QTY].ToString());
            }


            if (arg_op_cd == "")
                arg_op_cd = "FGA";
       
            string op_name = get_sxg_op_cd(arg_factory, arg_op_cd).Rows[0].ItemArray[2].ToString();

            for (int j = (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxUPC; j < flg_wsheet.Cols.Count; j++)
            {
                string grid_op_name = flg_wsheet[flg_wsheet.Rows.Fixed - 1, j].ToString();
                if (op_name.Equals(grid_op_name))
                    flg_wsheet.Cols[j].StyleNew.BackColor = Color.Gold;

                    //flg_wsheet.GetCellRange(flg_wsheet.Rows.Fixed, j, flg_wsheet.Rows.Count - 1, j).StyleNew.BackColor = Color.Gold;
                //flg_wsheet.Cols[j].StyleNew.ForeColor = Color.Black;
            }

            flg_wsheet.Add_Row(flg_wsheet.Rows.Count - 1);
            flg_wsheet[flg_wsheet.Rows.Count - 1, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxFGA_QTY] = sum_qty.ToString();
            flg_wsheet[flg_wsheet.Rows.Count - 1, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxDIVISION] = "";
            flg_wsheet.Rows[flg_wsheet.Rows.Count - 1].StyleNew.BackColor = COM.ComVar.GridDarkFixed_Color;
            flg_wsheet.Rows[flg_wsheet.Rows.Count - 1].StyleNew.ForeColor = COM.ComVar.GridForeColor;
            flg_wsheet.Rows[flg_wsheet.Rows.Count - 1].AllowEditing = false;

        }

        private DataTable Select_daily_worksheet(string arg_factory, string arg_op_cd , string arg_dir_ymd)
        {
            OraDB.ReDim_Parameter(4);
            OraDB.Process_Name = "pkg_sxg_mps_02_select.select_daily_worksheet";

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_op_cd";
            OraDB.Parameter_Name[2] = "arg_dir_ymd";
            OraDB.Parameter_Name[3] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_op_cd;
            OraDB.Parameter_Values[2] = arg_dir_ymd;
            OraDB.Parameter_Values[3] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[OraDB.Process_Name];
        }
        private DataTable Select_UPS_User()
        {
            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = "pkg_sxg_mps_02_select.select_ups_user";

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[OraDB.Process_Name];
        }
        #endregion

        #region Grid Event & Save Data
        private void flg_wsheet_AfterEdit(object sender, RowColEventArgs e)
        {
            int sct_row = flg_wsheet.Selection.r1;
            int sct_col = flg_wsheet.Selection.c1;

            string _date = (flg_wsheet[sct_row, sct_col] == null) ? "" : flg_wsheet[sct_row, sct_col].ToString().ToUpper();

            if (!_date.Equals("X") && !sct_col.Equals((int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxUPS_USER) && !sct_col.Equals((int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxREMARKS))
            {

                if (!_date.Length.Equals(8))
                {
                    MessageBox.Show("Input Error :  Wrong DateType");
                    return;
                }

                try
                {
                    int year = int.Parse(_date.Substring(0, 4));
                    int month = int.Parse(_date.Substring(4, 2));
                    int day = int.Parse(_date.Substring(6, 2));

                    DateTime datetime = new DateTime(year, month, day);
                }
                catch
                {
                    MessageBox.Show("Input Error :  Wrong DateType");
                    return;
                }

            }


            flg_wsheet.Update_Row(sct_row);
        }
        private void flg_wsheet_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Middle)
                {
                    if (grid_size)
                    {
                        flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxCATEGORY].Visible = false;
                        flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxSEASON].Visible = false;
                        //flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxBOM_STYLE].Visible = false;
                        flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxGEN_SIZE].Visible = false;
                        flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxREQ_YMD].Visible = false;

                        grid_size = false;
                    }
                    else
                    {
                        flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxCATEGORY].Visible = true;
                        flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxSEASON].Visible = true;
                        //flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxBOM_STYLE].Visible = true;
                        flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxGEN_SIZE].Visible = true;
                        flg_wsheet.Cols[(int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxREQ_YMD].Visible = true;

                        grid_size = true;
                    }
                }
            }
            catch
            {
 
            }
        }   
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            flg_wsheet.Select(flg_wsheet.Selection.r1, 0, flg_wsheet.Selection.r1, flg_wsheet.Cols.Count - 1, false);

            for (int i = _RowFixed; i < flg_wsheet.Rows.Count - 1; i++)
            {
                string arg_factory = flg_wsheet[i, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxFACTORY].ToString();
                string arg_lot_no = flg_wsheet[i, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxLOT_NO].ToString();
                string arg_lot_seq = flg_wsheet[i, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxLOT_SEQ].ToString();
                string arg_day_seq = flg_wsheet[i, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxDAY_SEQ].ToString();
                
                if (flg_wsheet[i, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxDIVISION].ToString().Equals("U"))
                {
                    //UPS User 사번, 이름 가져오기.
                    string arg_work_sabun = (flg_wsheet[i, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxUPS_USER] == null) ? "" : flg_wsheet[i, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxUPS_USER].ToString();
                    DataTable dt_name = get_ups_user_name(arg_factory, arg_work_sabun);
                    string arg_work_name = "";
                    if (dt_name.Rows.Count > 0)
                        arg_work_name = dt_name.Rows[0].ItemArray[0].ToString().Trim();
                    dt_name.Dispose();
                    string arg_remarks = (flg_wsheet[i, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxREMARKS] == null) ? "" : flg_wsheet[i, (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxREMARKS].ToString();
                    
                    DataTable dt_op = get_sxg_op_cd(arg_factory, "");

                    for (int j = 0; j < dt_op.Rows.Count; j++)
                    {
                        string arg_line_cd = "001";
                        string arg_op_cd   = dt_op.Rows[j].ItemArray[0].ToString();
                        string arg_cmp_cd  = dt_op.Rows[j].ItemArray[1].ToString();
                        string arg_work_day = flg_wsheet[i, j + (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxUPC].ToString();

                        try
                        {                            
                            Save_OP_Work_Day(arg_factory, arg_lot_no, arg_lot_seq, arg_day_seq, arg_line_cd, arg_op_cd, arg_cmp_cd, arg_work_day, arg_work_sabun, arg_work_name, arg_remarks);
                        }
                        catch
                        {
                            MessageBox.Show("Input Error : Wrong Date Type.");
                            return;
                        }
                    }             
                }
            }

            tbtn_Search_Click(null, null);


        }

        private DataTable get_sxg_op_cd(string arg_factory, string arg_op_cd)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            OraDB.Process_Name = "pkg_sxg_mps_02_select.get_sxg_op_cd";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_op_cd";
            OraDB.Parameter_Name[2] = "out_cursor";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_op_cd;
            OraDB.Parameter_Values[2] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        private DataTable get_ups_user_name(string arg_factory, string arg_sabun)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            OraDB.Process_Name = "pkg_sxg_mps_02_select.get_ups_user_name";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_sabun";
            OraDB.Parameter_Name[2] = "out_cursor";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_sabun;
            OraDB.Parameter_Values[2] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        private DataTable Save_OP_Work_Day(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_day_seq, string arg_line_cd, string arg_op_cd, string arg_cmp_cd, string arg_dir_ymd, string arg_cdc_work_sabun, string arg_cdc_work_name, string arg_remarks)
        {

            string Proc_Name = "pkg_sxg_mps_02.save_sxg_mps_worksheet";

            OraDB.ReDim_Parameter(12);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_LOT_NO";
            OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[3] = "ARG_DAY_SEQ";
            OraDB.Parameter_Name[4] = "ARG_LINE_CD";
            OraDB.Parameter_Name[5] = "ARG_CMP_CD";
            OraDB.Parameter_Name[6] = "ARG_OP_CD";
            OraDB.Parameter_Name[7] = "ARG_DIR_YMD";            
            OraDB.Parameter_Name[8] = "ARG_CDC_WORK_NAME";
            OraDB.Parameter_Name[9] = "ARG_REMARKS";
            OraDB.Parameter_Name[10] = "ARG_UPD_USER";
            OraDB.Parameter_Name[11] = "OUT_CURSOR";


            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[9] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[10] = (int)OracleType.VarChar;            
            OraDB.Parameter_Type[11] = (int)OracleType.Cursor;


            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_lot_no;
            OraDB.Parameter_Values[2] = arg_lot_seq;
            OraDB.Parameter_Values[3] = arg_day_seq;
            OraDB.Parameter_Values[4] = arg_line_cd;
            OraDB.Parameter_Values[5] = arg_cmp_cd;
            OraDB.Parameter_Values[6] = arg_op_cd;
            OraDB.Parameter_Values[7] = arg_dir_ymd;            
            OraDB.Parameter_Values[8] = arg_cdc_work_name;
            OraDB.Parameter_Values[9] = arg_remarks;
            OraDB.Parameter_Values[10] = COM.ComVar.This_User;
            OraDB.Parameter_Values[11] = "";
            OraDB.Add_Select_Parameter(true);


            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion
        
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string mrd_Filename = Application.StartupPath + @"\Product_Worksheet.mrd";
                string txt_Filename = "Product_Worksheet.txt";
                string Para = " ";

                #region 파라미터
                Para = "/rfn [" + Application.StartupPath + @"\" + txt_Filename + "]  /rv ";

                #endregion

                #region 파일만들기
                FileInfo file = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                if (!file.Exists)
                {
                    file.Create().Close();
                }
                file = null;
                

                FileStream sDatalist = new FileStream(txt_Filename, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(sDatalist, K_Encode);

                
                for (int i = flg_wsheet.Rows.Fixed; i < flg_wsheet.Rows.Count-1; i++)
                {
                    string sData = "";

                    for (int j = 0; j < flg_wsheet.Cols.Count; j++)
                    {
                        if (flg_wsheet[i, j] == null)
                            sData = sData + "@";
                        else
                        {
                            if (j >= (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxUPC && j <= (int)ClassLib.TBSXB_PJ_PRODUCT_WS.IxFGA)
                            {
                                if (flg_wsheet[i, j].ToString().Replace("\r\n", "").ToUpper() != "X")
                                {
                                    string date = flg_wsheet[i, j].ToString().Replace("\r\n", "").Substring(4, 2) + "/" + flg_wsheet[i, j].ToString().Replace("\r\n", "").Substring(6, 2);
                                    sData = sData + date + " @";
                                }
                                else
                                {
                                    sData = sData + flg_wsheet[i, j].ToString().Replace("\r\n", "") + " @"; 
                                }
                            }
                            else
                            {
                                sData = sData + flg_wsheet[i, j].ToString().Replace("\r\n", "") + " @";
                            }
                        }
                    }
                    sData = sData + cmb_opcd.Text+ "@";
                    sData = sData + dpk_sw_date.Text + "@";
                    sData = sData + cmb_opcd.SelectedValue.ToString() + "@";
                    sw.WriteLine(sData);
                }
                
                sw.Flush();               
                sw.Close();
                
                sDatalist.Close();

                #endregion

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(txt_Filename, mrd_Filename, Para);
                report.ShowDialog();
                
                FileInfo file_delete = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                file_delete.Delete();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
                
            }

        }
        
    }
}

