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
    public partial class Form_Prod_Result_All : COM.PCHWinForm.Form_Top
    {
        private COM.OraDB OraDB = new COM.OraDB();
        private int _RowFixed = 0;
        private int t_level_def = 0;
        public Form_Prod_Result_All()
        {
            InitializeComponent();
        }

        private void Form_Prod_Result_All_Load(object sender, EventArgs e)
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            //Init_Form();
        }

        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_factory.SelectedIndex == -1) return;
            COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
            Init_Form();
        }

        private void Init_Form()
        {
            this.Text = "PCC_Production Result";
            this.lbl_MainTitle.Text = "PCC_Production Result";
            ClassLib.ComFunction.SetLangDic(this);



            DataTable dt_ret = Select_sxb_scan_op(cmb_factory.SelectedValue.ToString());
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_op, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_op.SelectedIndex = 0;


            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), "SXO03");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_status.SelectedIndex = 0;




            dpk_dpk_work.Value = DateTime.Now;


            //get_out_no();


            flg_result.Set_Grid_CDC("SXG_PROD_RESULT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            flg_result.Set_Action_Image(img_Action);
            flg_result.ExtendLastCol = false;
            //flg_result.Font = new Font("Verdana", 15, FontStyle.Bold);
            _RowFixed = flg_result.Rows.Count;
            flg_result.Tree.Column = (int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxT_VALUE;

            tbtn_Append.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Save.Enabled = true;
            tbtn_Search.Enabled = true;
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {


            flg_result.Set_Grid_CDC("SXG_PROD_RESULT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            flg_result.Set_Action_Image(img_Action);
            flg_result.ExtendLastCol = false;
            //flg_result.Font = new Font("Verdana", 15, FontStyle.Bold);
            _RowFixed = flg_result.Rows.Count;
            flg_result.Tree.Column = (int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxT_VALUE;


            string arg_factory = cmb_factory.SelectedValue.ToString();
            string arg_set_date = dpk_dpk_work.Value.ToString("yyyyMMdd");
            string arg_op_cd = cmb_op.SelectedValue.ToString();
            string arg_status = cmb_status.SelectedValue.ToString();


            DataTable dt = Select_sxg_prod_op(arg_factory, arg_op_cd);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    flg_result.Cols.Add();
                    flg_result[flg_result.Rows.Count - 2, flg_result.Cols.Count - 1] = dt.Rows[i].ItemArray[1].ToString();
                    flg_result[flg_result.Rows.Count - 1, flg_result.Cols.Count - 1] = dt.Rows[i].ItemArray[0].ToString();
                    flg_result.Cols[flg_result.Cols.Count - 1].Width = 65;
                    flg_result.Cols[flg_result.Cols.Count - 1].Visible = false;
                    flg_result.Cols[flg_result.Cols.Count - 1].TextAlign = TextAlignEnum.CenterCenter;
                    
                    
                    flg_result.Cols.Add();
                    flg_result[flg_result.Rows.Count - 2, flg_result.Cols.Count - 1] = dt.Rows[i].ItemArray[1].ToString();
                    flg_result[flg_result.Rows.Count - 1, flg_result.Cols.Count - 1] = "Date";
                    flg_result.Cols[flg_result.Cols.Count - 1].Width = 80;
                    flg_result.Cols[flg_result.Cols.Count - 1].TextAlign = TextAlignEnum.CenterCenter;
                    
                    
                    flg_result.Cols.Add();
                    flg_result[flg_result.Rows.Count - 2, flg_result.Cols.Count - 1] = dt.Rows[i].ItemArray[1].ToString();
                    flg_result[flg_result.Rows.Count - 1, flg_result.Cols.Count - 1] = "Qty";
                    flg_result.Cols[flg_result.Cols.Count - 1].Width = 40;
                    flg_result.Cols[flg_result.Cols.Count - 1].TextAlign = TextAlignEnum.RightCenter;
                    //flg_result.Cols[flg_result.Cols.Count - 1].AllowEditing = true;


                }
            }


            flg_result.Rows.Count = _RowFixed;




            dt = Select_sxg_prod_all_op_list(arg_factory, arg_set_date, arg_op_cd, arg_status);


            int dt_rows = dt.Rows.Count;
			int dt_cols = dt.Columns.Count;


            string data_div_old = "";
            string data_div_new = "";

            if (dt_rows > 0)
            {
                for (int i = 0; i < dt_rows; i++)
                {

                    data_div_new = dt.Rows[i].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxBAR_CODE].ToString();
                    data_div_new += dt.Rows[i].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxT_LEVEL].ToString();



                    if (!data_div_old.Equals(data_div_new))
                    {

                        int t_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxT_LEVEL].ToString());
                        flg_result.Rows.InsertNode(flg_result.Rows.Count, t_level);


                        for (int k = (int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxOP_CD; k < flg_result.Cols.Count; k++)
                        {
                            flg_result[flg_result.Rows.Count - 1, k] = "X";
                        }





                        if (t_level.Equals(0))
                        {
                            flg_result.Rows[flg_result.Rows.Count - 1].AllowEditing = true;
                            flg_result.Rows[flg_result.Rows.Count - 1].StyleNew.ForeColor = Color.Green;
                        }
                        else
                        {
                            flg_result.Rows[flg_result.Rows.Count - 1].AllowEditing = false;
                            flg_result.Rows[flg_result.Rows.Count - 1].StyleNew.ForeColor = Color.Red;
                            flg_result.Rows[flg_result.Rows.Count - 1].StyleNew.Font = new Font("Verdana", 8, FontStyle.Bold);
                        }



                        for (int j = 0; j < (int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxT_LEVEL + 1; j++)
                        {
                            flg_result[flg_result.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();
                        }

                        data_div_old = data_div_new;
                    }

                    string op_cd = dt.Rows[i].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxOP_CD].ToString();
                    string op_ymd = dt.Rows[i].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxDIR_YMD].ToString();
                    string op_qty = dt.Rows[i].ItemArray[(int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxDIR_QTY].ToString();



                    for (int j = (int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxT_LEVEL + 1; j < flg_result.Cols.Count; j = j + 3)
                    {
                        if (flg_result[_RowFixed-1, j].ToString().Equals(op_cd))
                        {
                            flg_result[flg_result.Rows.Count - 1, j] = op_cd;
                            flg_result[flg_result.Rows.Count - 1, j + 1] = op_ymd;
                            flg_result[flg_result.Rows.Count - 1, j + 2] = op_qty;
                        }
                    }
                }

                flg_result.Tree.Show(t_level_def);
            }
        }


        private DataTable Select_sxg_prod_all_op_list(string arg_factory, string arg_set_date, string arg_op_cd, string arg_status)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(5);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_PROD_01_SELECT.SELECT_SXG_PROD_ALL_OP_LIST";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SET_DATE";
            OraDB.Parameter_Name[2] = "ARG_OP_CD";
            OraDB.Parameter_Name[3] = "ARG_STATUS";
            OraDB.Parameter_Name[4] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_set_date;
            OraDB.Parameter_Values[2] = arg_op_cd;
            OraDB.Parameter_Values[3] = arg_status;
            OraDB.Parameter_Values[4] = "";




            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }

        private DataTable Select_sxg_prod_op(string arg_factory, string arg_op_cd)
        {

            DataSet ds_Search;

            OraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_PROD_01_SELECT.SELECT_SXG_PROD_OP";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_OP_CD";
            OraDB.Parameter_Name[2] = "OUT_CURSOR";

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

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            flg_result.Select(flg_result.Selection.r1, 0, flg_result.Selection.r1, flg_result.Cols.Count - 1, false);
            for (int i = _RowFixed; i < flg_result.Rows.Count; i++)
            {
                if (flg_result[i, (int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxPROD_OK].ToString().Equals("True"))
                {
                    string arg_bar_code = flg_result[i, (int)ClassLib.DBSELECT_SXG_PROD_ALL_OP_LIST.IxBAR_CODE].ToString();

                    confirm_sxg_prod(arg_bar_code);
                }
            }


            tbtn_Search_Click(null, null);
        }


        private void confirm_sxg_prod(string arg_bar_code)
        {

            string Proc_Name = "PKG_SXG_PROD_01.CONFIRM_SXG_PROD";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_BAR_CODE";
            OraDB.Parameter_Name[1] = "ARG_UPD_USER";


            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[0] = arg_bar_code;
            OraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }

        private DataTable Select_sxb_scan_op(string arg_factory)
        {
            string Proc_Name = "PKG_SXG_PROD_01_SELECT.SELECT_SXB_SCAN_OP";

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

        private void scheduleDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t_level_def = 0;
            flg_result.Tree.Show(t_level_def);
        }

        private void resultDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t_level_def = 1;
            flg_result.Tree.Show(t_level_def);
        }
    }
}

