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


namespace FlexCDC.Product
{
    public partial class Form_Prod_BarScan : COM.PCHWinForm.Form_Top
    {
        #region 사용자 정의 변수 
        private int _Rowfixed = 0;
        private COM.OraDB OraDB = new COM.OraDB();
        private string settingfile = @"C:\sephroth_setting.ini";
        #endregion

        public Form_Prod_BarScan()
        {
            InitializeComponent();
        }

        #region Form Loading
        private void Form_Prod_Result_Load(object sender, EventArgs e)
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
            //Title Setting
            this.Text = "PCC_Product Barcode Scan";
            this.lbl_MainTitle.Text = "PCC_Product Barcode Scan";
            ClassLib.ComFunction.SetLangDic(this);
                        
            #region Grid Setting
            flg_prod.Set_Grid_CDC("SXG_PROD_BAR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            flg_prod.Set_Action_Image(img_Action);
            flg_prod.Font = new Font("Verdana", 35, FontStyle.Bold);
            flg_prod.ExtendLastCol = false;
            flg_prod.Cols[(int)ClassLib.TBSXG_PROD_BAR.IxDIVISION].Visible = false;
            _Rowfixed = flg_prod.Rows.Count;
            #endregion

            #region Button Setting
            tbtn_Append.Enabled  = false;
            tbtn_Color.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Insert.Enabled  = false;
            tbtn_New.Enabled     = false;
            tbtn_Print.Enabled   = false;
            tbtn_Save.Enabled    = false;
            tbtn_Search.Enabled  = false;
            #endregion
        }
        #endregion

        #region Barcode Scan
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            flg_prod.Rows.Count = _Rowfixed;

            DataTable dt = Select_sxg_prod_bar(txt_bar_code.Text, txt_op_cd.Text);

            int dt_rows = dt.Rows.Count;
            int dt_cols = dt.Columns.Count;


            for (int i = 0; i < dt_rows; i++)
            {
                flg_prod.AddItem(dt.Rows[i].ItemArray);
            }

            if (flg_prod.Rows.Count != _Rowfixed)
            {
                flg_prod.Rows[flg_prod.Rows.Count - 2].Height = 400;
                flg_prod.Rows[flg_prod.Rows.Count - 2].StyleNew.Font = new Font("Verdana", 90, FontStyle.Bold);

                flg_prod.Cols[2].StyleNew.ForeColor = Color.Red;
            }


        }

        private DataTable Select_sxg_prod_bar(string arg_barcode, string arg_op_cd)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_PROD_01_SELECT.SELECT_SXG_PROD_BAR_CODE";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_BARCODE";
            OraDB.Parameter_Name[1] = "ARG_OP_CD";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_barcode;
            OraDB.Parameter_Values[1] = arg_op_cd;
            OraDB.Parameter_Values[2] = "";




            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }

        private void txt_bar_code_TextChanged(object sender, EventArgs e)
        {
            if (txt_bar_code.Text.Trim().Length.Equals(15))
            {


                DataTable dt = Select_sxg_prod_op_info(txt_bar_code.Text, txt_op_cd.Text);

                txt_work_date.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxDIR_YMD].ToString();
                txt_op_sch_qty.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxDIR_QTY].ToString();
                txt_dever.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxCDC_DEV_NAME].ToString();
                txt_op_rst_qty.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxSCAN_QTY].ToString();


                txt_sr_no.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxSR_NO].ToString();
                txt_srf_no.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxSRF_NO].ToString();
                txt_bom_id.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxBOM_ID].ToString();
                txt_bom_rev.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxBOM_REV].ToString();
                txt_style_cd.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxSTYLE_CD].ToString();
                txt_style_name.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxSTYLE_NAME].ToString();
                txt_category.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxCATEGORY].ToString();
                txt_season.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxSEASON_CD].ToString();
                txt_need_by.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxNEED_BY].ToString();
                txt_ets.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxETS].ToString();
                txt_prod_qty.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxPROD_QTY].ToString();
                txt_cor_ver.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxCOLOR_VER].ToString();


                txt_op_remarks.Text = dt.Rows[0].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_OP_INFO.IxREMARKS].ToString();




                //if (!txt_op_rst_qty.Text.Equals("0"))
                //{
                //    save_sxg_prod_result(txt_bar_code.Text, txt_op_cd.Text, txt_op_rst_qty.Text);
                //}


                //tbtn_Search_Click(null, null);
            }
        }

        private DataTable Select_sxg_prod_op_info(string arg_barcode, string arg_op_cd)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_PROD_01_SELECT.SELECT_SXG_SCAN_INFO";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_BAR_CODE";
            OraDB.Parameter_Name[1] = "ARG_OP_CD";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_barcode;
            OraDB.Parameter_Values[1] = arg_op_cd;
            OraDB.Parameter_Values[2] = "";




            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        #endregion

        #region Qty Save
        private void save_sxg_prod_result(string arg_bar_code, string arg_op_cd, string arg_op_qty)
        {

            string Proc_Name = "PKG_SXG_PROD_01.SAVE_SXG_PROD_RESULT";

            OraDB.ReDim_Parameter(4);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_BAR_CODE";
            OraDB.Parameter_Name[1] = "ARG_OP_CD";
            OraDB.Parameter_Name[2] = "ARG_OP_QTY";
            OraDB.Parameter_Name[3] = "ARG_UPD_USER";


            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[0] = arg_bar_code;
            OraDB.Parameter_Values[1] = arg_op_cd;
            OraDB.Parameter_Values[2] = arg_op_qty;
            OraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }


        private void update_sxg_prod_result(string arg_bar_code, string arg_op_cd, string arg_op_qty)
        {

            string Proc_Name = "PKG_SXG_PROD_01.UPDATE_SXG_PROD_RESULT";

            OraDB.ReDim_Parameter(4);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_BAR_CODE";
            OraDB.Parameter_Name[1] = "ARG_OP_CD";
            OraDB.Parameter_Name[2] = "ARG_OP_QTY";
            OraDB.Parameter_Name[3] = "ARG_UPD_USER";


            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[0] = arg_bar_code;
            OraDB.Parameter_Values[1] = arg_op_cd;
            OraDB.Parameter_Values[2] = arg_op_qty;
            OraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }

        private void btn_op_save_Click(object sender, EventArgs e)
        {
            update_sxg_prod_result(txt_bar_code.Text, txt_op_cd.Text, txt_op_rst_qty.Text);
           
            tbtn_Search_Click(null, null);
        }
        #endregion
    }
}