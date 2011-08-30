using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Product
{
    public partial class Form_Prod_Bar : COM.PCHWinForm.Form_Top
    {
        private COM.OraDB OraDB = new COM.OraDB();
        private int _RowFixed = 0;
        public Form_Prod_Bar()
        {
            InitializeComponent();
        }

        private void Form_Prod_Bar_Load(object sender, EventArgs e)
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
        }

        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_factory.SelectedIndex == -1) return;
            COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
            Init_Form();
        }

        private void Init_Form()
        {
            this.Text = "PCC_Product Barcode List";
            this.lbl_MainTitle.Text = "PCC_Product Barcode List";
            ClassLib.ComFunction.SetLangDic(this);



            DataTable dt_ret = Select_sxb_scan_op(cmb_factory.SelectedValue.ToString());
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_op, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_op.SelectedIndex = 0;


            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), "SXO03");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_status.SelectedIndex = 0;




            dpk_sct_work.Value = DateTime.Now;


            //get_out_no();


            flg_prod_bar.Set_Grid_CDC("SXG_PROD_BAR", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            flg_prod_bar.Set_Action_Image(img_Action);
            flg_prod_bar.ExtendLastCol = false;
            //flg_result.Font = new Font("Verdana", 15, FontStyle.Bold);
            _RowFixed = flg_prod_bar.Rows.Count;
           // flg_prod_bar.Tree.Column = (int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxT_VALUE;

            tbtn_Append.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Print.Enabled = true;
            tbtn_Save.Enabled = false;
            tbtn_Search.Enabled = true;
        }


        private DataTable Select_sxb_scan_op(string arg_factory)
        {
            string Proc_Name = "PKG_SXG_PROD_01_SELECT.SELECT_SXB_FIRST_OP";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            flg_prod_bar.Rows.Count = _RowFixed;
            string arg_factory = cmb_factory.SelectedValue.ToString();
            string arg_set_date = dpk_sct_work.Value.ToString("yyyyMMdd");
            string arg_op_cd = cmb_op.SelectedValue.ToString();
            string arg_status = cmb_status.SelectedValue.ToString();
            string arg_print_yn = "";


            DataTable dt = Select_sxg_prod_bar_list(arg_factory, arg_set_date, arg_op_cd, arg_status, arg_print_yn);


            int dt_rows = dt.Rows.Count;
            int dt_cols = dt.Columns.Count;

            if (dt_rows > 0)
            {
                for (int i = 0; i < dt_rows; i++)
                {
                    flg_prod_bar.AddItem(dt.Rows[i].ItemArray, flg_prod_bar.Rows.Count, 0);
                }
            }
        }


        private DataTable Select_sxg_prod_bar_list(string arg_factory, string arg_set_date, string arg_op_cd, string arg_status, string arg_print_yn )
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(6);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_PROD_01_SELECT.SELECT_SXG_PROD_BAR_PRINT";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SET_DATE";
            OraDB.Parameter_Name[2] = "ARG_OP_CD";
            OraDB.Parameter_Name[3] = "ARG_STATUS";
            OraDB.Parameter_Name[4] = "ARG_PRINT_YN";
            OraDB.Parameter_Name[5] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_set_date;
            OraDB.Parameter_Values[2] = arg_op_cd;
            OraDB.Parameter_Values[3] = arg_status;
            OraDB.Parameter_Values[4] = arg_print_yn;
            OraDB.Parameter_Values[5] = "";




            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
    }
}

