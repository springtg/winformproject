using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;

namespace FlexCDC.Shipping
{
    public partial class Form_Shipping : COM.PCHWinForm.Form_Top
    {
        #region 생성자
        public Form_Shipping()
        {
            InitializeComponent();
        }
        #endregion

        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private bool first_flg = true;
        #endregion

        #region Form Loading
        private void Form_Shipping_Load(object sender, EventArgs e)
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();            
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Factory.SelectedValue = "VJ";            
        }
        private void cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_Factory.SelectedIndex == -1)
                    return;

                COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();

                Init_Form();
                cmb_pur_div.Enabled = true;
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
            this.Text = "PCC_Request for Shipping";
            this.lbl_MainTitle.Text = "PCC_Request for Shipping";
            this.lbl_title.Text = "     Shipping Information";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            first_flg = true;
            dtp_From_Date.Value = DateTime.Now;
            dtp_To_Date.Value = DateTime.Now;
            //Ship No
            DataTable dt_ret = SELECT_SHIP_NO();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_ship_no, false, 0, 1, 0, 200);
            if (dt_ret.Rows.Count != 0)
            {
                cmb_ship_no.SelectedIndex = 0;
            }

            //MRP_no
            dt_ret = SELECT_MRP_NO();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_mrp_no, true, 0, 0, 0, 200);
            cmb_mrp_no.SelectedIndex = 0;
            //Purchase Division
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_MatDiv);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_div, 1, 2, true, false);
            cmb_pur_div.SelectedValue = "11";
            cmb_pur_div.Enabled = false;
            //MRP Type
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_DataType);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_mrp_req_flg, 1, 2, true, false);
            cmb_mrp_req_flg.SelectedIndex = 0;

            dt_ret.Dispose();
            first_flg = false;
            #endregion

            #region Grid Setting
            fgrid_Main.Set_Grid_CDC("SXS_SHIP_REQUEST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
            #endregion

            mnu_toss.Visible = false;
            mnu_value.Visible = false;
            txt_srf_no.CharacterCasing = CharacterCasing.Upper;
            txt_mat_name.CharacterCasing = CharacterCasing.Upper;
            txt_srf_no.Focus();
            Button_Control();
            cmb_pur_div.Enabled = true;
        }
        private void Button_Control()
        {

            if (cmb_ship_no.SelectedValue == null)
            {
                tbtn_New.Enabled = false;
                tbtn_Search.Enabled = false;
                tbtn_Save.Enabled = false;
                tbtn_Delete.Enabled = false;
                tbtn_Print.Enabled = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Create.Enabled = true;
            }
            if (cmb_ship_no.Text.Substring(0, 1).Trim() == "C")
            {
                tbtn_New.Enabled = false;
                tbtn_Search.Enabled = true;
                tbtn_Save.Enabled = false;
                tbtn_Delete.Enabled = false;
                tbtn_Print.Enabled = true;
                tbtn_Confirm.Enabled = false;
                tbtn_Create.Enabled = true;
            }
            if (cmb_ship_no.Text.Substring(0, 1).Trim() == "R")
            {
                tbtn_New.Enabled = false;
                tbtn_Search.Enabled = true;
                tbtn_Save.Enabled = true;
                tbtn_Delete.Enabled = false;
                tbtn_Print.Enabled = false;
                tbtn_Confirm.Enabled = true;
                tbtn_Create.Enabled = true;
            }
            cmb_pur_div.Enabled = true;
        }

        private DataTable SELECT_MRP_NO()
        {

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = "PKG_SXS_SHIP_01_SELECT.SELECT_SXS_MRP_NO";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(cmb_ship_no, "");
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Create Data
        private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Create_Data();
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
        private void Create_Data()
        {
            CREATE_LIST();

            DataTable dt_ret = SELECT_SHIP_NO();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_ship_no, false, 0, 1, 0, 200);
            cmb_ship_no.SelectedIndex = 0;

            Display_Grid();
        }

        private void CREATE_LIST()
        {

            MyOraDB.ReDim_Parameter(5);

            //01. PROCEDURE명 
            MyOraDB.Process_Name = "PKG_SXS_SHIP_01.INSERT_SXS_SHIP_HEAD";

            //02. ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[2] = "ARG_F_PUR_YMD";
            MyOraDB.Parameter_Name[3] = "ARG_T_PUR_YMD";
            MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

            //04. DATA 정의 
            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = cmb_pur_div.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = dtp_From_Date.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = dtp_To_Date.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }
        private DataTable SELECT_SHIP_NO()
        {

            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXS_SHIP_01_SELECT.SELECT_SXS_SHIP_NO";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Display_Grid();
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

        private void Display_Grid()
        {
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
            if (cmb_ship_no.SelectedValue == null)
                return;

            fgrid_Main.Tree.Column = (int)ClassLib.TBSXS_SHIP_REQUEST.IxITEM_01;

            DataTable dt_list = SELECT_LIST();
            bool type_flg_m = true;
            bool type_flg_r = true;
            bool srf_flg = true;
            string mrp_no = "";
            string mrp_no_next = "";
            string pur_div = "";
            string pur_div_next = "";

            for (int i = 0; i < dt_list.Rows.Count; i++)
            {
                #region Level 1 Setting
                if (dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxMRP_REQ_FLG - 1].ToString().Trim() == "M")
                {
                    mrp_no = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxMRP_NO - 1].ToString().Trim();
                    mrp_no_next = "";
                    pur_div = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxPUR_DIV - 1].ToString().Trim();
                    pur_div_next = "";


                    if (i - 1 < 0)
                    {
                        mrp_no_next = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxMRP_NO - 1].ToString().Trim();
                        pur_div_next = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxPUR_DIV - 1].ToString().Trim();
                    }
                    else
                    {
                        mrp_no_next = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxMRP_NO - 1].ToString().Trim();
                        pur_div_next = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxPUR_DIV - 1].ToString().Trim();
                    }

                    string div = "";
                    if (pur_div == "11")
                        div = "Korea";
                    if (pur_div == "12")
                        div = "Local";
                    if (pur_div == "21")
                        div = "Import";
                    if (type_flg_m)
                    {
                        fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, 1);

                        for (int j = 0; j < dt_list.Columns.Count; j++)
                        {
                            //if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG - 1)
                            //    fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "FALSE";


                            if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxITEM_01 - 1)
                                fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "MRP(" + mrp_no + "_" + div + ")";
                            else
                                fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "";

                            fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.ForeColor = Color.Red;
                            fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.Beige;
                            fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;
                        }

                    }

                    if (!type_flg_m)
                    {
                        if (pur_div != pur_div_next || mrp_no != mrp_no_next)
                        {

                            fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, 1);

                            for (int j = 0; j < dt_list.Columns.Count; j++)
                            {
                                //if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG - 1)
                                //    fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "FALSE";


                                if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxITEM_01 - 1)
                                    fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "MRP(" + mrp_no + "_" + div + ")";
                                else
                                    fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "";

                                fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.ForeColor = Color.Red;
                                fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.Beige;
                                fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;
                            }

                        }
                    }
                    type_flg_m = false;
                }
                if (dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxMRP_REQ_FLG - 1].ToString().Trim() == "R")
                {
                    mrp_no = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxMRP_NO - 1].ToString().Trim();
                    mrp_no_next = "";
                    pur_div = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxPUR_DIV - 1].ToString().Trim();
                    pur_div_next = "";

                    if (i - 1 < 0)
                    {
                        mrp_no_next = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxMRP_NO - 1].ToString().Trim();
                        pur_div_next = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxPUR_DIV - 1].ToString().Trim();
                    }
                    else
                    {
                        mrp_no_next = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxMRP_NO - 1].ToString().Trim();
                        pur_div_next = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxPUR_DIV - 1].ToString().Trim();
                    }

                    string div = "";
                    if (pur_div == "11")
                        div = "Korea";
                    if (pur_div == "12")
                        div = "Local";
                    if (pur_div == "21")
                        div = "Import";

                    if (type_flg_r)
                    {
                        fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, 1);

                        for (int j = 0; j < dt_list.Columns.Count; j++)
                        {
                            //if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG - 1)
                            //    fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "FALSE";


                            if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxITEM_01 - 1)
                                fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "Request(" + mrp_no + "_" + div + ")";
                            else
                                fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "";

                            fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.ForeColor = Color.Red;
                            fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.Beige;
                            fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;
                        }

                    }

                    if (!type_flg_r)
                    {
                        if (mrp_no != mrp_no_next || pur_div != pur_div_next)
                        {

                            fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, 1);

                            for (int j = 0; j < dt_list.Columns.Count; j++)
                            {
                                //if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG - 1)
                                //    fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "FALSE";


                                if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxITEM_01 - 1)
                                    fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "Request(" + mrp_no + "_" + div + ")";
                                else
                                    fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "";

                                fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.ForeColor = Color.Red;
                                fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.Beige;
                                fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;
                            }

                        }
                    }
                    type_flg_r = false;
                }
                #endregion

                #region Level 2 Setting
                string srf_no = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxSRF_NO - 1].ToString().Trim();
                string srf_no_next = "";
                string style = "";


                if (i - 1 < 0)
                {
                    srf_no_next = dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxSRF_NO - 1].ToString().Trim();
                }
                else
                {
                    srf_no_next = dt_list.Rows[i - 1].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxSRF_NO - 1].ToString().Trim();
                }

                if (i + 1 < dt_list.Rows.Count)
                {
                    style = dt_list.Rows[i + 1].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxITEM_02 - 1].ToString().Trim();
                }

                if (srf_flg)
                {
                    fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, 2);

                    for (int j = 0; j < dt_list.Columns.Count; j++)
                    {

                        if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxITEM_01 - 1)
                            fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = srf_no;
                        else if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxITEM_02 - 1)
                            fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = style;
                        else
                            fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "";

                        fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.ForeColor = Color.Blue;
                        fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.White;
                        fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;
                    }
                }
                if (!srf_flg)
                {
                    if (mrp_no != mrp_no_next || pur_div != pur_div_next || srf_no != srf_no_next)
                    {
                        fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, 2);

                        for (int j = 0; j < dt_list.Columns.Count; j++)
                        {

                            if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxITEM_01 - 1)
                                fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = srf_no;
                            else if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxITEM_02 - 1)
                                fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = style;
                            else
                                fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = "";

                            fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.ForeColor = Color.Blue;
                            fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.White;
                            fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;
                        }
                    }
                }
                srf_flg = false;


                #endregion

                int tree_level = int.Parse(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG - 1].ToString()) + 2;
                fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, tree_level);

                for (int j = 0; j < dt_list.Columns.Count; j++)
                {
                    if (j == (int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG - 1)
                        fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = (dt_list.Rows[i].ItemArray[j].ToString().Trim() == "Y") ? "TRUE" : "FALSE";
                    else
                        fgrid_Main[fgrid_Main.Rows.Count - 1, j + 1] = dt_list.Rows[i].ItemArray[j].ToString();
                }

                #region Level에 따른 Grid Edit & BackColor 설정
                if (tree_level == 3)
                {
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = true;
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.White;
                    if (fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSTATUS].ToString().Trim() == "C")
                        fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;
                }
                else if (tree_level == 4)
                {
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].AllowEditing = false;
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke;
                }
                #endregion

            }

            fgrid_Main.Tree.Show(2);
            cmb_pur_div.Enabled = true;

        }

        private DataTable SELECT_LIST()
        {

            MyOraDB.ReDim_Parameter(7);
            MyOraDB.Process_Name = "PKG_SXS_SHIP_01_SELECT.SELECT_SXS_SHIP_HEAD";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
            MyOraDB.Parameter_Name[2] = "ARG_MRP_NO";
            MyOraDB.Parameter_Name[3] = "ARG_MRP_REQ_FLG";
            MyOraDB.Parameter_Name[4] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[5] = "ARG_MAT_NAME";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = cmb_ship_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = cmb_mrp_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[3] = cmb_mrp_req_flg.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = txt_srf_no.Text;
            MyOraDB.Parameter_Values[5] = txt_mat_name.Text;
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Sava Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Save_Data();
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
        private void Save_Data()
        {
            for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
            {
                if (fgrid_Main[i, (int)ClassLib.TBSXS_SHIP_REQUEST.IxDIV] != null && fgrid_Main[i, (int)ClassLib.TBSXS_SHIP_REQUEST.IxDIV].ToString() == "U")
                {
                    if (fgrid_Main[i, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() == "1")
                    {
                        UPDATE_SXS_SHIP_TAIL(i);
                    }
                    fgrid_Main[i, (int)ClassLib.TBSXS_SHIP_REQUEST.IxDIV] = "";
                }
            }
        }

        private void UPDATE_SXS_SHIP_TAIL(int arg_rowcnt)
        {

            MyOraDB.ReDim_Parameter(13);

            //01. PROCEDURE명 
            MyOraDB.Process_Name = "PKG_SXS_SHIP_01.UPDATE_SXS_SHIP_TAIL";

            //02. ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
            MyOraDB.Parameter_Name[2] = "ARG_BAR_CODE";
            MyOraDB.Parameter_Name[3] = "ARG_SHIP_FLG";
            MyOraDB.Parameter_Name[4] = "ARG_TRANSPORT_TYPE";
            MyOraDB.Parameter_Name[5] = "ARG_VALUE_IN";
            MyOraDB.Parameter_Name[6] = "ARG_VALUE_OUT";
            MyOraDB.Parameter_Name[7] = "ARG_PACKING";
            MyOraDB.Parameter_Name[8] = "ARG_PK_NO";
            MyOraDB.Parameter_Name[9] = "ARG_PUR_PRICE";
            MyOraDB.Parameter_Name[10] = "ARG_CBM";
            MyOraDB.Parameter_Name[11] = "ARG_WEIGHT";
            MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;

            //04. DATA 정의 
            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = cmb_ship_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXS_SHIP_REQUEST.IxBAR_CODE].ToString();
            MyOraDB.Parameter_Values[3] = (fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG].ToString() == "True") ? "Y" : "N";
            MyOraDB.Parameter_Values[4] = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXS_SHIP_REQUEST.IxTRANSPORT_TYPE].ToString();
            MyOraDB.Parameter_Values[5] = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_IN].ToString();
            MyOraDB.Parameter_Values[6] = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_OUT].ToString();
            MyOraDB.Parameter_Values[7] = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXS_SHIP_REQUEST.IxPACKING].ToString();
            MyOraDB.Parameter_Values[8] = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXS_SHIP_REQUEST.IxPK_NO].ToString();
            MyOraDB.Parameter_Values[9] = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXS_SHIP_REQUEST.IxPUR_PRICE].ToString();
            MyOraDB.Parameter_Values[10] = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXS_SHIP_REQUEST.IxCBM].ToString();
            MyOraDB.Parameter_Values[11] = fgrid_Main[arg_rowcnt, (int)ClassLib.TBSXS_SHIP_REQUEST.IxWEIGHT].ToString();
            MyOraDB.Parameter_Values[12] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }
        #endregion

        #region Confirm Data
        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                CONFIRM_DATA();
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

        private void CONFIRM_DATA()
        {
            if (cmb_ship_no.SelectedValue == null)
                return;

            CONF_SXS_SHIP_TAIL();

            DataTable dt_ret = SELECT_SHIP_NO();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_ship_no, false, 0, 1, 0, 200);
            cmb_ship_no.SelectedIndex = 0;

            Display_Grid();
        }

        private void CONF_SXS_SHIP_TAIL()
        {
            MyOraDB.ReDim_Parameter(3);

            //01. PROCEDURE명 
            MyOraDB.Process_Name = "PKG_SXS_SHIP_01.SAVE_CONF_SXS_SHIP_TAIL";

            //02. ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            //04. DATA 정의 
            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = cmb_ship_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Print_Data();
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

        private void Print_Data()
        {
            string factory     = cmb_Factory.SelectedValue.ToString();
            string ship_no     = cmb_ship_no.SelectedValue.ToString();
            string mrp_no      = cmb_mrp_no.SelectedValue.ToString();
            string mrp_req_flg = cmb_mrp_req_flg.SelectedValue.ToString();
            string srf_no      = ClassLib.ComFunction.Empty_TextBox(txt_srf_no, "");
            string mat_name    = ClassLib.ComFunction.Empty_TextBox(txt_mat_name, "");

            Pop_Print_Option pop_print = new Pop_Print_Option(factory, ship_no, mrp_no, mrp_req_flg, srf_no, mat_name);
            pop_print.ShowDialog();
        }
        #endregion

        #region Grid Event
        private void fgrid_Main_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int[] selectRows = fgrid_Main.Selections;

                int sct_row = fgrid_Main.Selection.r1;
                int sct_col = fgrid_Main.Selection.c1;

                for (int i = 0; i < fgrid_Main.Selections.Length; i++)
                {

                    if (!fgrid_Main.Cols[sct_col].AllowEditing || sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG)
                    {
                        if (fgrid_Main[selectRows[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() != "")
                        {
                            fgrid_Main[selectRows[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG] = fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG].ToString();
                            fgrid_Main.Update_Row(selectRows[i]);

                            try
                            {
                                for (int j = selectRows[i] + 1; j < fgrid_Main.Rows.Count; j++)
                                {
                                    if (fgrid_Main[j, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString() == "1" || fgrid_Main[j, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() == "")
                                        break;

                                    fgrid_Main[j, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG] = fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG].ToString();
                                    fgrid_Main.Update_Row(j);
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    else
                    {

                        if (fgrid_Main[selectRows[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() != "")
                        {
                            fgrid_Main[selectRows[i], sct_col] = fgrid_Main[sct_row, sct_col].ToString();
                            fgrid_Main.Update_Row(selectRows[i]);

                            try
                            {
                                for (int j = selectRows[i] + 1; j < fgrid_Main.Rows.Count; j++)
                                {
                                    if (fgrid_Main[j, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString() == "1" || fgrid_Main[j, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() == "")
                                        break;

                                    fgrid_Main[j, sct_col] = fgrid_Main[sct_row, sct_col].ToString();
                                    fgrid_Main.Update_Row(j);
                                }
                            }
                            catch
                            {

                            }
                        }

                    }
                }
            }
            catch
            {

            }
        }
        private void fgrid_Main_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selectRows = fgrid_Main.Selections;

                int sct_row = fgrid_Main.Selection.r1;
                int sct_col = fgrid_Main.Selection.c1;

                //Status가 Confirm 이거나 1 또는 2 레벨일때
                //if (fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSTATUS].ToString().Trim() == "C" || fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() == "")
                //{
                //    mnu_value.Visible = false;
                //    mnu_toss.Visible = false;
                //    return;
                //}


                if (fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSTATUS].ToString().Trim() == "C" || fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() == "")
                {
                    mnu_value.Visible = false;
                    mnu_toss.Visible = false;
                    return;
                }

                //string lev_div = "";
                //if (fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxITEM_01].ToString().Trim().Substring(0, 3) == "MRP" || fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxITEM_01].ToString().Trim().Substring(0, 3).ToUpper() == "REQ")
                //{
                //    lev_div = "M"; 
                //}

                //if (lev_div == "M" && fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() == "")
                //{
                //    mnu_value.ForeColor = Color.Red;
                //    mnu_toss.ForeColor = Color.Red;

                //    //Packing 또는 PK No 선택시
                //    if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxPACKING || sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxPK_NO)
                //    {
                //        mnu_value.Visible = true;
                //        mnu_toss.Visible = false;
                //    }
                //    //Value In 또는 Out 선택시
                //    if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_IN || sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_OUT)
                //    {
                //        mnu_value.Visible = false;
                //        mnu_toss.Visible = true;
                //    }
                //}

                //if (lev_div == "" &&  fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() == "")
                //{
                //    mnu_value.ForeColor = Color.Blue;
                //    mnu_toss.ForeColor = Color.Blue;

                //    //Packing 또는 PK No 선택시
                //    if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxPACKING || sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxPK_NO)
                //    {
                //        mnu_value.Visible = true;
                //        mnu_toss.Visible = false;
                //    }
                //    //Value In 또는 Out 선택시
                //    if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_IN || sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_OUT)
                //    {
                //        mnu_value.Visible = false;
                //        mnu_toss.Visible = true;
                //    }
                //}

                //if (fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() == "")
                //{
                //    mnu_value.ForeColor = Color.Blue ;
                //    mnu_toss.ForeColor = Color.Blue;

                //    //Packing 또는 PK No 선택시
                //    if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxPACKING || sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxPK_NO)
                //    {
                //        mnu_value.Visible = true;
                //        mnu_toss.Visible = false;
                //    }
                //    //Value In 또는 Out 선택시
                //    if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_IN || sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_OUT)
                //    {
                //        mnu_value.Visible = false;
                //        mnu_toss.Visible = true; 
                //    }
                //}
                //else
                //{
                //    mnu_value.ForeColor = Color.Black;
                //    mnu_toss.ForeColor = Color.Black;

                //    //Packing 또는 PK No 선택시
                //    if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxPACKING || sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxPK_NO)
                //    {
                //        mnu_value.Visible = true;
                //        mnu_toss.Visible = false;
                //    }
                //    //Value In 또는 Out 선택시
                //    if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_IN || sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_OUT)
                //    {
                //        mnu_value.Visible = false;
                //        mnu_toss.Visible = true;
                //    }
                //}

                //Packing 또는 PK No 선택시
                if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxPACKING || sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxPK_NO)
                {
                    if (fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() == "1")
                        mnu_value.Visible = true;
                    else
                        mnu_value.Visible = false;
                }
                else
                {
                    mnu_value.Visible = false;
                }

                //Value In 또는 Out 선택시
                if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_IN || sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_OUT)
                {
                    if (fgrid_Main[sct_row, (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() == "1")
                        mnu_toss.Visible = true;
                    else
                        mnu_toss.Visible = false;
                }
                else
                {
                    mnu_toss.Visible = false;
                }

                if (fgrid_Main.Cols[sct_col].AllowEditing && sct_col != (int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG)
                    fgrid_Main.Cols[(int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG].AllowEditing = false;
                else
                    fgrid_Main.Cols[(int)ClassLib.TBSXS_SHIP_REQUEST.IxSHIP_FLG].AllowEditing = true;
            }
            catch
            {

            }

        }
        #endregion

        #region Context Menu Event
        private void mnu_srf_no_Click(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(2);
        }
        private void mnu_mat_Click(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(3);
        }

        private void mnu_bom_Click(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(4);
        }
        private void mnu_value_Click(object sender, EventArgs e)
        {
            Pop_Common_Text pop = new Pop_Common_Text(this);
            pop.ShowDialog();
        }
        private void mnu_toss_Click(object sender, EventArgs e)
        {
            int[] selectRows = fgrid_Main.Selections;

            int sct_row = fgrid_Main.Selection.r1;
            int sct_col = fgrid_Main.Selection.c1;

            for (int i = 0; i < fgrid_Main.Selections.Length; i++)
            {
                if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_IN)
                {
                    if (fgrid_Main[selectRows[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() != "")
                    {
                        fgrid_Main[selectRows[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_IN] = fgrid_Main[selectRows[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_PUR].ToString().Trim();
                        fgrid_Main.Update_Row(selectRows[i]);
                    }
                }
                if (sct_col == (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_OUT)
                {
                    if (fgrid_Main[selectRows[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxSORT_FLG].ToString().Trim() != "")
                    {
                        fgrid_Main[selectRows[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_OUT] = fgrid_Main[selectRows[i], (int)ClassLib.TBSXS_SHIP_REQUEST.IxVALUE_PUR].ToString().Trim();
                        fgrid_Main.Update_Row(selectRows[i]);
                    }
                }

            }
        }
        #endregion

        #region Control Event

        private void cmb_ship_no_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (cmb_ship_no.SelectedIndex == -1) return;

                if (first_flg)
                    return;

                Button_Control();

                DataTable dt_ret = SELECT_MRP_NO();
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_mrp_no, true, 0, 0, 0, 200);
                cmb_mrp_no.SelectedIndex = 0;
                dt_ret.Dispose();
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
        #endregion         
    }
}

