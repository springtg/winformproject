using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Product
{
    public partial class Pop_Prod_Result : COM.PCHWinForm.Pop_Large_Light
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성

        private string tmp_pcard_id, tmp_op_cd, tmp_rst_div, tmp_op_name;
        private string tmp_factory, tmp_category, tmp_season, tmp_model, tmp_color, tmp_sample_type;
        Form_Prod_Result_OPCD _main_form = null;        
        public bool save_flg = false;
        #endregion

        #region 리소스 정의 
        public Pop_Prod_Result()
        {
            InitializeComponent();
        }
        public Pop_Prod_Result(string arg_pcard_id, string arg_op_cd, string arg_rtd_div, string arg_op_name, string arg_factory, string arg_category, string arg_season, string arg_model, string arg_color, string arg_sample_type, Form_Prod_Result_OPCD arg_form)
        {
            tmp_pcard_id = arg_pcard_id;
            tmp_op_cd    = arg_op_cd;
            tmp_rst_div  = arg_rtd_div;
            tmp_op_name  = arg_op_name;

            tmp_factory     = arg_factory;
            tmp_category    = arg_category;
            tmp_season      = arg_season;
            tmp_model       = arg_model;
            tmp_color       = arg_color;
            tmp_sample_type = arg_sample_type;

            _main_form = arg_form;

            InitializeComponent();
        }

        
        #endregion

        #region Form Loading
        private void Pop_Prod_Result_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch
            {
 
            }
        }

        private void Init_Form()
        {
            this.Text = "Passcard Information";
            this.lbl_MainTitle.Text = "Passcard Information";

            #region Button Setting
            c1ToolBar1.Visible   = false;
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = false;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Conform.Enabled = false;
            tbtn_Print.Enabled   = false;
            tbtn_Create.Enabled  = false;
            #endregion

            #region Control Setting
            cmb_factory.Text     = tmp_factory;
            cmb_factory.Enabled  = false;
            cmb_category.Text    = tmp_category;
            cmb_category.Enabled = false;
            cmb_season.Text      = tmp_season;
            cmb_season.Enabled   = false;
            txt_model.Text       = tmp_model;
            txt_model.Enabled    = false;
            txt_color.Text       = tmp_color;
            txt_color.Enabled    = false;
            cmb_round.Text       = tmp_sample_type;
            cmb_round.Enabled    = false;
            #endregion

            #region Grid Setting
            fgrid_result.Set_Grid_CDC("SXG_PROD_RESULT_POP", "3", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);           
            fgrid_result.Rows.Count = fgrid_result.Rows.Fixed;
            //fgrid_result.ExtendLastCol = false;
            
            if (tmp_rst_div.Equals("I"))
            {
                fgrid_result[fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxRST_QTY] = "입고";
                fgrid_result[fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxRST_QTY] = "입고";
            }
            else if (tmp_rst_div.Equals("T"))
            {
                fgrid_result[fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxRST_QTY] = "투입";
                fgrid_result[fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxRST_QTY] = "투입";
            }
            else if (tmp_rst_div.Equals("P"))
            {
                fgrid_result[fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxRST_QTY] = "실적";
                fgrid_result[fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxRST_QTY] = "실적";
            }
            else if (tmp_rst_div.Equals("O"))
            {
                fgrid_result[fgrid_result.Rows.Fixed - 1, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxRST_QTY] = "출고";
                fgrid_result[fgrid_result.Rows.Fixed - 2, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxRST_QTY] = "출고";
            }
            if (tmp_op_cd.Equals("FGA") || tmp_op_cd.Equals("UPS"))
            {
                fgrid_result.Cols[(int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxINSERT_QTY].AllowEditing = true;

                if (tmp_rst_div.Equals("P"))
                {
                    chk_confirm.Visible = true;
                }
            }
            #endregion

            Display_Grid();
        }

        private void Display_Grid()
        {
            DataTable dt = Select_barcode_list(tmp_rst_div);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fgrid_result.Rows.Add();

                for (int j = fgrid_result.Cols.Fixed; j < fgrid_result.Cols.Count; j++)
                {
                    fgrid_result[fgrid_result.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();
                }

                string remain_qty = fgrid_result[fgrid_result.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxREMAIN_QTY].ToString().Trim();
                string cfm_chk    = fgrid_result[fgrid_result.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxCFM_CHK].ToString().Trim();

                if (!remain_qty.Equals("0") && !cfm_chk.Equals("C"))
                {
                    fgrid_result[fgrid_result.Rows.Count - 1, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxCHK] = "TRUE";
                }
            }
        }
        
        private DataTable Select_barcode_list(string arg_rst_div)
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_PROD_01_SELECT.SELECT_SXG_PROD_RESULT_POP_01";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_PCARD_ID";
            MyOraDB.Parameter_Name[1] = "ARG_OP_CD";
            MyOraDB.Parameter_Name[2] = "ARG_RST_DIV";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = tmp_pcard_id;
            MyOraDB.Parameter_Values[1] = tmp_op_cd;
            MyOraDB.Parameter_Values[2] = arg_rst_div;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Save Data
        private System.Data.DataTable get_rst_ymd()
        {
            string Proc_Name = "pkg_sxg_prod_01_select.get_rst_ymd";

            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }
        
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                fgrid_result.Select(fgrid_result.Selection.r1, fgrid_result.Selection.c1);

                string rst_ymd = get_rst_ymd().Rows[0].ItemArray[0].ToString();
                string rst_hms = get_rst_ymd().Rows[0].ItemArray[1].ToString();

                for (int i = fgrid_result.Rows.Fixed; i < fgrid_result.Rows.Count; i++)
                {
                    if (fgrid_result[i, 1].ToString().ToLower() == "true")
                    {
                        string bar_code   = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxBAR_CODE].ToString();
                        string cmp_cd     = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxCMP_CD].ToString();
                        string op_cd      = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxOP_CD].ToString();
                        string qty        = fgrid_result[i, (int)ClassLib.TBSXG_PROD_RESULT_POP_NEW.IxINSERT_QTY].ToString();

                        if (double.Parse(qty) < 0)
                        {
                            MessageBox.Show("Worng Qty");
                            return;
                        }

                        Save_data(bar_code, cmp_cd, op_cd, tmp_rst_div, rst_ymd, rst_hms, qty);
                    }
                }

                if (chk_confirm.Checked)
                {
                    btn_confirm_Click(null, null); 
                }

                save_flg = true;
                this.Close();
            }
            catch
            {
 
            }
        }
        private void Save_data(string arg_bar_code, string arg_cmp_cd, string arg_op_cd, string arg_rst_div, string arg_rst_ymd, string arg_rst_hms, string arg_rst_qty)
        {
            MyOraDB.ReDim_Parameter(8);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "pkg_sxg_prod_01.save_sxg_prod_pcard";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "arg_bar_code";
            MyOraDB.Parameter_Name[1] = "arg_cmp_cd";
            MyOraDB.Parameter_Name[2] = "arg_op_cd";
            MyOraDB.Parameter_Name[3] = "arg_rst_div";
            MyOraDB.Parameter_Name[4] = "arg_rst_ymd";
            MyOraDB.Parameter_Name[5] = "arg_rst_hms";
            MyOraDB.Parameter_Name[6] = "arg_rst_qty";
            MyOraDB.Parameter_Name[7] = "arg_upd_user";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_bar_code;
            MyOraDB.Parameter_Values[1] = arg_cmp_cd;
            MyOraDB.Parameter_Values[2] = arg_op_cd;
            MyOraDB.Parameter_Values[3] = arg_rst_div;
            MyOraDB.Parameter_Values[4] = arg_rst_ymd;
            MyOraDB.Parameter_Values[5] = arg_rst_hms;
            MyOraDB.Parameter_Values[6] = arg_rst_qty;
            MyOraDB.Parameter_Values[7] = COM.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }

        
        #endregion

        #region Control Setting 
        private void btn_save_Click(object sender, EventArgs e)
        {
            tbtn_Save_Click(null, null);
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Confirm Data
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (tmp_op_cd.Equals("FGA"))
                {
                    int sct_row = _main_form.fgrid_result.Selection.r1;
                    int start_col = (int)ClassLib.TBSXG_PROD_RESULT_OP.IxUPC_DIR;
                    int end_col = (int)ClassLib.TBSXG_PROD_RESULT_OP.IxO_FGA_RST;

                    for (int i = start_col; i <= end_col; i++)
                    {
                        int _length = _main_form.fgrid_result[sct_row, i].ToString().Trim().Length;

                        if (_length > 1)
                        {
                            string arg_pcard_id = _main_form.fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxPCARD_ID].ToString();
                            string arg_op_cd = _main_form.fgrid_result[fgrid_result.Rows.Fixed - 1, i + 1].ToString();
                            string arg_cmp_cd = get_cmp_cd(arg_op_cd).Rows[0].ItemArray[1].ToString();

                            Click_Save(arg_pcard_id, arg_cmp_cd, arg_op_cd);

                            _main_form.fgrid_result.GetCellRange(sct_row, i).StyleNew.BackColor = Color.Aqua;
                        }
                    }
                }
                else if (tmp_op_cd.Equals("UPS"))
                {
                    int sct_row = _main_form.fgrid_result.Selection.r1;

                    string arg_pcard_id = _main_form.fgrid_result[sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxPCARD_ID].ToString();
                    string arg_op_cd    = "UPS";
                    string arg_cmp_cd   = get_cmp_cd(arg_op_cd).Rows[0].ItemArray[1].ToString();

                    Click_Save(arg_pcard_id, arg_cmp_cd, arg_op_cd);

                    _main_form.fgrid_result.GetCellRange(sct_row, (int)ClassLib.TBSXG_PROD_RESULT_OP.IxUPS_DIR).StyleNew.BackColor = Color.Aqua;
                }

                this.Close();
            }
            catch
            {

            }
            finally
            {
 
            }
        }
        private void Click_Save(string arg_pcard_id, string arg_cmp_cd, string arg_op_cd)
        {
            DataTable dt_rst = get_bar_code(arg_pcard_id, arg_cmp_cd, arg_op_cd);

            if (dt_rst.Rows.Count > 0)
            {
                for (int j = 0; j < dt_rst.Rows.Count; j++)
                {
                    string bar_code = dt_rst.Rows[j].ItemArray[0].ToString();
                    string rst_qty  = dt_rst.Rows[j].ItemArray[1].ToString();
                    string rst_ymd  = dt_rst.Rows[j].ItemArray[2].ToString();
                    string rst_hms  = dt_rst.Rows[j].ItemArray[3].ToString();

                    Confirm_Data(bar_code, arg_cmp_cd, arg_op_cd);
                }
            }
        }
        private DataTable get_cmp_cd(string arg_op_cd)
        {
            string Proc_Name = "pkg_sxg_mps_02_select.get_sxg_op_cd";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_op_cd";
            MyOraDB.Parameter_Name[2] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_CDC_Factory;
            MyOraDB.Parameter_Values[1] = arg_op_cd;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }
        private DataTable get_bar_code(string arg_pcard_id, string arg_cmp_cd, string arg_op_cd)
        {
            string Proc_Name = "pkg_sxg_prod_01_select.get_bar_code";

            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "arg_pcard_id";
            MyOraDB.Parameter_Name[1] = "arg_cmp_cd";
            MyOraDB.Parameter_Name[2] = "arg_op_cd";
            MyOraDB.Parameter_Name[3] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_pcard_id;
            MyOraDB.Parameter_Values[1] = arg_cmp_cd;
            MyOraDB.Parameter_Values[2] = arg_op_cd;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

        }
        private void Confirm_Data(string arg_bar_code, string arg_cmp_cd, string arg_op_cd)
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXG_PROD_01.CONFIRM_SXG_PROD_PCARD";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_BAR_CODE";
            MyOraDB.Parameter_Name[1] = "ARG_CMP_CD";
            MyOraDB.Parameter_Name[2] = "ARG_OP_CD";            
            MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;            
           
            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_bar_code;
            MyOraDB.Parameter_Values[1] = arg_cmp_cd;
            MyOraDB.Parameter_Values[2] = arg_op_cd;
            MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }
        #endregion
    }
}

