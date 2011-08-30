using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Purchase
{
    public partial class Form_Pur_Order_New_02 : COM.PCHWinForm.Form_Top
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private bool first_flg = true;

        #endregion

        #region 생성자
        public Form_Pur_Order_New_02()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Pur_Order_New_02_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
            }
            catch
            {
 
            }
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
                
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void Init_Form()
        {
            this.Text = "PCC_Purchase Order";
            this.lbl_MainTitle.Text = "PCC_Purchase Order";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            dpk_get_from.Value = DateTime.Now;
            dpk_get_to.Value = DateTime.Now;

            DataTable dt_ret;
            string _factory = cmb_factory.SelectedValue.ToString();

            #region Upload  User설정
            if (ClassLib.ComVar.This_CDCPower_Level.Substring(0, 1) == "P")
            {
                cmb_pur_user.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
                cmb_pur_user.ClearItems();

                cmb_pur_user.AddItemTitles("Code;Name");

                cmb_pur_user.ValueMember = "Code";
                cmb_pur_user.DisplayMember = "Name";
                cmb_pur_user.AddItem(ClassLib.ComVar.This_User + ";" + ClassLib.ComVar.This_User);

                cmb_pur_user.SelectedIndex = -1;

                cmb_pur_user.MaxDropDownItems = 10;
                cmb_pur_user.Splits[0].DisplayColumns[0].Width = 0;
                cmb_pur_user.Splits[0].DisplayColumns[1].Width = 211;

                cmb_pur_user.ExtendRightColumn = true;
                cmb_pur_user.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
                cmb_pur_user.HScrollBar.Height = 0;

                cmb_pur_user.SelectedIndex = 0;              
                cmb_pur_user.Enabled = false;
            }
            else 
            {
                dt_ret = SELECT_SXP_PUR_USER();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_user, 0, 0, true, 0, 211);
                cmb_pur_user.SelectedIndex = 0;
                cmb_pur_user.Enabled = false;

                if (ClassLib.ComVar.This_CDCPower_Level == "S00")
                    cmb_pur_user.Enabled = true;
                
            }
            #endregion
            
            //Status
            dt_ret = ClassLib.ComVar.Select_ComCode(_factory, COM.ComVar.CxCDC_PurOrder_Status);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2, true, false);
            cmb_status.SelectedIndex = 0;

            //MRP/Req Type
            dt_ret = ClassLib.ComVar.Select_ComCode(_factory, COM.ComVar.CxCDC_PurManaget_DataType);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_data_type, 1, 2, true, false);
            cmb_data_type.SelectedIndex = 0;

            //Purchase Division
            dt_ret = ClassLib.ComVar.Select_ComCode(_factory, COM.ComVar.CxCDC_PurManaget_MatDiv);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_div, 1, 2, true, false);
            cmb_pur_div.SelectedIndex = 0;

            dt_ret = SELECT_SXP_PUR_NO();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_pur_no, true, 0, 0, 0, 211);
            cmb_pur_no.SelectedIndex = 0;

            dt_ret = SELECT_SXP_PUR_VENDOR();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_vendor, true, 0, 1, 0, 211);
            cmb_vendor.SelectedIndex = 0;

            first_flg = false;
            #endregion

            #region Grid Setting
            fgrid_order.Set_Grid_CDC("SXP_PUR_ORDER_NEW", "3", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_order.Set_Action_Image(img_Action);
            fgrid_order.ExtendLastCol = false;
            fgrid_order.AllowDragging = AllowDraggingEnum.None;
            fgrid_order.AllowSorting = AllowSortingEnum.None;
            fgrid_order.Tree.Column = (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxMAT_NAME;
            #endregion

            Button_Control();

            lbl_ready.BackColor   = Color.LightYellow;
            lbl_save.BackColor    = Color.White;
            lbl_confirm.BackColor = Color.Bisque;
        }
        private void Button_Control()
        {
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = true;
            tbtn_Print.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;
            mnu_release.Enabled  = false;            
            tbtn_Create.Enabled  = true;

            if (cmb_pur_no.SelectedIndex > 0)
            {
                tbtn_Confirm.Enabled = true;                
                mnu_release.Enabled  = true;

                if (cmb_vendor.SelectedIndex > 0 && cmb_pur_div.SelectedIndex > 0)
                {
                    tbtn_Print.Enabled = true;
                }
            }            
        }

        private DataTable SELECT_SXP_PUR_USER()
        {            
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "PKG_SXP_PUR_01_SELECT.SELECT_SXP_PURUSER";

            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                        
            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable SELECT_SXP_PUR_NO()
        {        
            MyOraDB.ReDim_Parameter(8);
            MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXP_PUR_NO";

            MyOraDB.Parameter_Name[0] = "arg_factory";            
            MyOraDB.Parameter_Name[1] = "arg_get_from";
            MyOraDB.Parameter_Name[2] = "arg_get_to";
            MyOraDB.Parameter_Name[3] = "arg_pur_user";
            MyOraDB.Parameter_Name[4] = "arg_status";
            MyOraDB.Parameter_Name[5] = "arg_data_type";
            MyOraDB.Parameter_Name[6] = "arg_pur_div";
            MyOraDB.Parameter_Name[7] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();            
            MyOraDB.Parameter_Values[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = dpk_get_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = cmb_pur_user.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = cmb_status.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = cmb_data_type.SelectedValue.ToString();
            MyOraDB.Parameter_Values[6] = cmb_pur_div.SelectedValue.ToString();
            MyOraDB.Parameter_Values[7] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable SELECT_SXP_PUR_VENDOR()
        {           
            MyOraDB.ReDim_Parameter(9);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXP_PUR_VENDOR";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";            
            MyOraDB.Parameter_Name[1] = "ARG_GET_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_GET_TO";
            MyOraDB.Parameter_Name[3] = "ARG_PUR_USER";
            MyOraDB.Parameter_Name[4] = "ARG_STATUS";
            MyOraDB.Parameter_Name[5] = "ARG_MRP_REQ_FLG";
            MyOraDB.Parameter_Name[6] = "ARG_PUR_DIV";            
            MyOraDB.Parameter_Name[7] = "ARG_PUR_NO";            
            MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();            
            MyOraDB.Parameter_Values[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = dpk_get_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = cmb_pur_user.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = cmb_status.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = cmb_data_type.SelectedValue.ToString();
            MyOraDB.Parameter_Values[6] = cmb_pur_div.SelectedValue.ToString();
            MyOraDB.Parameter_Values[7] = cmb_pur_no.SelectedValue.ToString();            
            MyOraDB.Parameter_Values[8] = "";

            MyOraDB.Add_Select_Parameter(true);            
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Create Data
        private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string arg_factory  = cmb_factory.SelectedValue.ToString();
                string arg_pur_user = cmb_pur_user.SelectedValue.ToString();

                DataTable dt_ret = CREATE_PUR_ORDER(arg_factory, arg_pur_user);

                if (dt_ret.Rows.Count > 0)
                {
                    string _pur_no = dt_ret.Rows[0].ItemArray[0].ToString();

                    dt_ret = SELECT_SXP_PUR_NO();
                    ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_pur_no, true, 0, 0, 0, 211);
                    cmb_pur_no.SelectedValue = _pur_no;

                    tbtn_Search_Click(null, null);
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private DataTable CREATE_PUR_ORDER(string arg_factory, string arg_pur_user)
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_02.INSERT_SXP_PUR_HEAD";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PUR_USER";
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_pur_user;
            MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                fgrid_order.Rows.Count = fgrid_order.Rows.Fixed;

                string[] arg_value = new string[12];
                arg_value[0] = cmb_factory.SelectedValue.ToString();
                arg_value[1] = dpk_get_from.Value.ToString("yyyyMMdd");
                arg_value[2] = dpk_get_to.Value.ToString("yyyyMMdd");
                arg_value[3] = cmb_pur_user.SelectedValue.ToString();
                arg_value[4] = cmb_status.SelectedValue.ToString();
                arg_value[5] = cmb_data_type.SelectedValue.ToString();
                arg_value[6] = cmb_pur_div.SelectedValue.ToString();
                arg_value[7] = cmb_pur_no.SelectedValue.ToString();
                arg_value[8] = cmb_vendor.SelectedValue.ToString();
                arg_value[9] = txt_srf_no.Text.Trim();
                arg_value[10] = txt_style_name.Text.Trim();
                arg_value[11] = txt_mat_name.Text.Trim();

                DataTable dt_ret = SELECT_PUR_ORDER(arg_value);
                Display_Grid(dt_ret);

                fgrid_order.Tree.Show(1);
                fgrid_order.Select(fgrid_order.Rows.Fixed + 1, fgrid_order.Cols.Fixed + 1);
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private DataTable SELECT_PUR_ORDER(string [] arg_value)
        {
            MyOraDB.ReDim_Parameter(13);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXP_PUR_ORDER";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";            
            MyOraDB.Parameter_Name[1]  = "ARG_GET_FROM";
            MyOraDB.Parameter_Name[2]  = "ARG_GET_TO";
            MyOraDB.Parameter_Name[3]  = "ARG_PUR_USER";
            MyOraDB.Parameter_Name[4]  = "ARG_STATUS";            
            MyOraDB.Parameter_Name[5]  = "ARG_DATA_TYPE";
            MyOraDB.Parameter_Name[6]  = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[7]  = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[8]  = "ARG_VEN_SEQ";
            MyOraDB.Parameter_Name[9]  = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[10] = "ARG_STYLE_NAME";
            MyOraDB.Parameter_Name[11] = "ARG_MAT_NAME";            
            MyOraDB.Parameter_Name[12] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[12] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0]  = arg_value[0];
            MyOraDB.Parameter_Values[1]  = arg_value[1];
            MyOraDB.Parameter_Values[2]  = arg_value[2];
            MyOraDB.Parameter_Values[3]  = arg_value[3];
            MyOraDB.Parameter_Values[4]  = arg_value[4];
            MyOraDB.Parameter_Values[5]  = arg_value[5];
            MyOraDB.Parameter_Values[6]  = arg_value[6];
            MyOraDB.Parameter_Values[7]  = arg_value[7];
            MyOraDB.Parameter_Values[8]  = arg_value[8];
            MyOraDB.Parameter_Values[9]  = arg_value[9];
            MyOraDB.Parameter_Values[10] = arg_value[10];
            MyOraDB.Parameter_Values[11] = arg_value[11];
            MyOraDB.Parameter_Values[12] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private void Display_Grid(DataTable arg_dt)
        {
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                int _level = int.Parse(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxT_LEVEL].ToString());
                fgrid_order.Rows.InsertNode(fgrid_order.Rows.Count, _level);

                for (int j = 0; j < fgrid_order.Cols.Count; j++)
                {
                    fgrid_order[fgrid_order.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                }

                if (_level.Equals(1))
                {                    
                    string _status = fgrid_order[fgrid_order.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxSTATUS].ToString();

                    if (_status.Equals("C"))
                    {
                        fgrid_order.Rows[fgrid_order.Rows.Count - 1].StyleNew.BackColor = Color.Bisque;
                        fgrid_order.Rows[fgrid_order.Rows.Count - 1].AllowEditing = false;
                    }
                    else if (_status.Equals("Y"))
                    {
                        fgrid_order.Rows[fgrid_order.Rows.Count - 1].StyleNew.BackColor = Color.White;
                        fgrid_order.Rows[fgrid_order.Rows.Count - 1].AllowEditing = true;
                    }
                    else if (_status.Equals("N"))
                    {
                        fgrid_order.Rows[fgrid_order.Rows.Count - 1].StyleNew.BackColor = Color.LightYellow;
                        fgrid_order.Rows[fgrid_order.Rows.Count - 1].AllowEditing = true;
                    }
                }
                else
                {
                    fgrid_order.Rows[fgrid_order.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke;
                    fgrid_order.Rows[fgrid_order.Rows.Count - 1].AllowEditing = false;
                }
            }
 
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_order.Rows.Count == fgrid_order.Rows.Fixed)
                    return;

                fgrid_order.Select(fgrid_order.Selection.r1, fgrid_order.Selection.c1);

                SAVE_PUR_ORDER();
                CALCULATE_PUR_ORDER();
                tbtn_Search_Click(null, null);
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void SAVE_PUR_ORDER()
        {
            int vCol = 16;
            MyOraDB.ReDim_Parameter(vCol);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_02.SAVE_SXP_PUR_HEAD_01";

            //02.ARGURMENT 명            
            MyOraDB.Parameter_Name[0]  = "arg_division";
            MyOraDB.Parameter_Name[1]  = "arg_bar_code";
            MyOraDB.Parameter_Name[2]  = "arg_ven_seq";
            MyOraDB.Parameter_Name[3]  = "arg_rta_ymd";
            MyOraDB.Parameter_Name[4]  = "arg_etc_ymd";
            MyOraDB.Parameter_Name[5]  = "arg_pur_div";
            MyOraDB.Parameter_Name[6]  = "arg_common_yn";
            MyOraDB.Parameter_Name[7]  = "arg_price_yn";
            MyOraDB.Parameter_Name[8]  = "arg_transport_type";
            MyOraDB.Parameter_Name[9]  = "arg_value_temp";
            MyOraDB.Parameter_Name[10] = "arg_pur_currency";
            MyOraDB.Parameter_Name[11] = "arg_pur_price";
            MyOraDB.Parameter_Name[12] = "arg_cbd_currency";
            MyOraDB.Parameter_Name[13] = "arg_cbd_price";
            MyOraDB.Parameter_Name[14] = "arg_sub_mat";
            MyOraDB.Parameter_Name[15] = "arg_upd_user";
            
            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;

            //04.DATA 정의
            int vRow = 0;
            for (int i = fgrid_order.Rows.Fixed; i < fgrid_order.Rows.Count; i++)
            {
                string _div = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxDIVISION].ToString().Trim();
                if (!_div.Equals(""))
                {       
                    vRow++;                  
                }
            }

            int vCnt = vCol * vRow;
            MyOraDB.Parameter_Values = new string[vCnt];

            vCnt = 0;
            for (int i = fgrid_order.Rows.Fixed; i < fgrid_order.Rows.Count; i++)
            {
                string _level = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxT_LEVEL].ToString().Trim();
                string _div = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxDIVISION].ToString().Trim();
                
                if (_level.Equals("2") || _div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vCnt++] = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxDIVISION].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxBAR_CODE].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxVEN_SEQ].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxRTA_YMD].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxETC_YMD].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxPUR_DIV_E].ToString().Trim();

                string _common_yn = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxCOMMON_YN].ToString().ToUpper().Trim();
                if(_common_yn.Equals("TRUE"))
                    _common_yn = "Y";
                else
                    _common_yn = "N";
                MyOraDB.Parameter_Values[vCnt++] = _common_yn;

                string _price_yn = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxPRICE_YN_V].ToString().ToUpper().Trim();
                if(_price_yn.Equals("TRUE"))
                    _price_yn = "Y";
                else
                    _price_yn = "N";
                MyOraDB.Parameter_Values[vCnt++] = _price_yn;
                MyOraDB.Parameter_Values[vCnt++] = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxTRANSPORT_TYPE].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxVALUE_PUR].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxPUR_CURRENCY].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxPUR_PRICE].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxCBD_CURRCNCY].ToString().Trim();
                MyOraDB.Parameter_Values[vCnt++] = fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxCBD_PRICE].ToString().Trim();
                string sub_mat_flg = (fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxMAT_SUB_FLG] == null) ? "FALSE" : fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxMAT_SUB_FLG].ToString().Trim().ToUpper();

                if (sub_mat_flg.Equals("TRUE"))
                    sub_mat_flg = "Y";
                else
                    sub_mat_flg = "N";

                MyOraDB.Parameter_Values[vCnt++] = sub_mat_flg;
                MyOraDB.Parameter_Values[vCnt++] = COM.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure(); 
        }
        private void CALCULATE_PUR_ORDER()
        {            
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_02.CALCULAT_SXP_PUR_TAIL";

            //02.ARGURMENT 명            
            MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1]  = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[2]  = "ARG_STATUS";
            MyOraDB.Parameter_Name[3]  = "ARG_UPD_USER";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = cmb_pur_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = "Y";
            MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;
            
            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure(); 
        }
        #endregion

        #region Return Data
        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                int[] sct_rows = fgrid_order.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _lev = fgrid_order[sct_rows[i], (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxT_LEVEL].ToString();

                    if (_lev.Equals("1"))
                    {
                        fgrid_order[sct_rows[i], (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxDIVISION] = "D";
                    } 
                }
            }
            catch
            {
 
            }
        }
        #endregion

        #region Confirm Data
        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                for (int i = fgrid_order.Rows.Fixed; i < fgrid_order.Rows.Count; i++)
                {
                    string vendor = (fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxVEN_NAME] == null) ? "" : fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxVEN_NAME].ToString().Trim();
                    string lev = (fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxT_LEVEL] == null) ? "" : fgrid_order[i, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxT_LEVEL].ToString().Trim();

                    if (lev.Equals("1"))
                    {
                        if (vendor.Equals(""))
                        {
                            ClassLib.ComFunction.User_Message("Input Error : Vendor", "Confirm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                string arg_factory = cmb_factory.SelectedValue.ToString();
                string arg_pur_no  = cmb_pur_no.SelectedValue.ToString();
                string arg_status  = "C";

                CONFIRM_PUR_ORDER(arg_factory, arg_pur_no, arg_status);

                tbtn_Search_Click(null, null);
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void CONFIRM_PUR_ORDER(string arg_factory, string arg_pur_no, string arg_status)
        {            
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_02.CONF_SXP_PUR_HEAD";

            //02.ARGURMENT 명            
            MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1]  = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[2]  = "ARG_STATUS";
            MyOraDB.Parameter_Name[3]  = "ARG_UPD_USER";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_pur_no;
            MyOraDB.Parameter_Values[2] = arg_status;
            MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;
            
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

                //행 수정 상태 해제
                fgrid_order.Select(fgrid_order.Selection.r1, 0, fgrid_order.Selection.r1, fgrid_order.Cols.Count - 1, false);

                if (cmb_pur_div.SelectedValue.ToString() == "11")
                    return;

                string mrd_Filename = "";
                string sPara = "";

                string[] arg_value = new string[6];
                arg_value[0] = cmb_factory.SelectedValue.ToString();
                arg_value[1] = dpk_get_from.Value.ToString("yyyyMMdd");
                arg_value[2] = dpk_get_to.Value.ToString("yyyyMMdd");
                arg_value[3] = cmb_pur_no.SelectedValue.ToString();
                arg_value[4] = cmb_pur_div.SelectedValue.ToString();
                arg_value[5] = cmb_vendor.SelectedValue.ToString();
                
                sPara = " /rp " + "[" + arg_value[0] + "]" 
                               + " [" + arg_value[1] + "]" 
                               + " [" + arg_value[2] + "]" 
                               + " [" + arg_value[3] + "]" 
                               + " [" + arg_value[4] + "]" 
                               + " [" + arg_value[5] + "]";

                if (!chk_print_shc.Checked)
                {
                    if (ClassLib.ComVar.This_Factory == "DS")
                    {
                        if (cmb_pur_div.SelectedValue.ToString() == "12")
                            mrd_Filename = Application.StartupPath + @"\Order_sheet_list_new_02" + ".mrd";
                        else if (cmb_pur_div.SelectedValue.ToString() == "21")
                            mrd_Filename = Application.StartupPath + @"\Order_sheet_list_import_new" + ".mrd";
                    }
                    else if (ClassLib.ComVar.This_Factory == "VJ")
                    {
                        if (cmb_pur_div.SelectedValue.ToString() == "12")
                            mrd_Filename = Application.StartupPath + @"\Order_sheet_list_VJ_new" + ".mrd";
                        else if (cmb_pur_div.SelectedValue.ToString() == "21")
                            mrd_Filename = Application.StartupPath + @"\Order_sheet_list_import_VJ_new" + ".mrd";
                    }
                    else if (ClassLib.ComVar.This_Factory == "QD")
                    {
                        if (cmb_pur_div.SelectedValue.ToString() == "12")
                            mrd_Filename = Application.StartupPath + @"\Order_sheet_list_QD_new" + ".mrd";
                        else if (cmb_pur_div.SelectedValue.ToString() == "21")
                            mrd_Filename = Application.StartupPath + @"\Order_sheet_list_import_QD_new" + ".mrd";
                    }

                    FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                    report.ShowDialog();
                }
                else
                {
                    Pop_Pur_List_PrintOption pop = new Pop_Pur_List_PrintOption("PURCHASE_SHC", arg_value[0], arg_value[3], arg_value[5]);
                    pop.ShowDialog();
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btn_print_list_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //행 수정 상태 해제
                fgrid_order.Select(fgrid_order.Selection.r1, 0, fgrid_order.Selection.r1, fgrid_order.Cols.Count - 1, false);
                                
                string mrd_Filename = "";
                string sPara = "";

                string[] arg_value = new string[7];
                arg_value[0] = cmb_factory.SelectedValue.ToString();
                arg_value[1] = dpk_get_from.Value.ToString("yyyyMMdd");
                arg_value[2] = dpk_get_to.Value.ToString("yyyyMMdd");
                arg_value[3] = cmb_pur_no.SelectedValue.ToString();
                arg_value[4] = cmb_vendor.SelectedValue.ToString();
                arg_value[5] = cmb_pur_div.SelectedValue.ToString();
                arg_value[6] = cmb_pur_user.SelectedValue.ToString();

                if (chk_print_shc.Checked)
                {
                    mrd_Filename = Application.StartupPath + @"\Import_Offer_List" + ".mrd";
                    sPara = " /rp " + "[" + arg_value[0] + "]"
                                   + " [" + arg_value[1] + "]"
                                   + " [" + arg_value[2] + "]"
                                   + " [" + arg_value[3] + "]"
                                   + " [" + arg_value[4] + "]"
                                   + " [" + arg_value[5] + "]"
                                   + " [" + arg_value[6] + "]";
                }
                else
                {
                    mrd_Filename = Application.StartupPath + @"\Purchase_List_Check" + ".mrd";
                    sPara = " /rp " + "[" + arg_value[0] + "]"
                                   + " [" + arg_value[1] + "]"
                                   + " [" + arg_value[2] + "]"
                                   + " [" + arg_value[3] + "]"
                                   + " [" + arg_value[4] + "]";
                }

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Control Event
        private void dpk_get_from_CloseUp(object sender, EventArgs e)
        {
            if (first_flg)
                return;

            DataTable dt_ret = SELECT_SXP_PUR_NO();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_pur_no, true, 0, 0, 0, 211);
            cmb_pur_no.SelectedIndex = 0;

            Button_Control();
        }

        private void dpk_get_to_CloseUp(object sender, EventArgs e)
        {
            if (first_flg)
                return;

            DataTable dt_ret = SELECT_SXP_PUR_NO();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_pur_no, true, 0, 0, 0, 211);
            cmb_pur_no.SelectedIndex = 0;

            Button_Control();
        }

        private void cmb_pur_user_SelectedValueChanged(object sender, EventArgs e)
        {
            if (first_flg)
                return;

            if (cmb_pur_user.SelectedIndex < 0)
                return;

            DataTable dt_ret = SELECT_SXP_PUR_NO();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_pur_no, true, 0, 0, 0, 211);
            cmb_pur_no.SelectedIndex = 0;

            Button_Control();
        }

        private void cmb_status_SelectedValueChanged(object sender, EventArgs e)
        {
            if (first_flg)
                return;

            if (cmb_status.SelectedIndex < 0)
                return;

            DataTable dt_ret = SELECT_SXP_PUR_NO();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_pur_no, true, 0, 0, 0, 211);
            cmb_pur_no.SelectedIndex = 0;

            Button_Control();
        }

        private void cmb_data_type_SelectedValueChanged(object sender, EventArgs e)
        {
            if (first_flg)
                return;

            if (cmb_data_type.SelectedIndex < 0)
                return;

            DataTable dt_ret = SELECT_SXP_PUR_NO();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_pur_no, true, 0, 0, 0, 211);
            cmb_pur_no.SelectedIndex = 0;

            Button_Control();
        }

        private void cmb_pur_div_SelectedValueChanged(object sender, EventArgs e)
        {
            if (first_flg)
                return;

            if (cmb_pur_div.SelectedIndex < 0)
                return;

            DataTable dt_ret = SELECT_SXP_PUR_NO();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_pur_no, true, 0, 0, 0, 211);
            cmb_pur_no.SelectedIndex = 0;

            Button_Control();
        }

        private void cmb_pur_no_SelectedValueChanged(object sender, EventArgs e)
        {
            if (first_flg)
                return;

            if (cmb_pur_no.SelectedIndex < 0)
                return;

            DataTable dt_ret = SELECT_SXP_PUR_VENDOR();
            ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_vendor, true, 0, 1, 0, 211);
            cmb_vendor.SelectedIndex = 0;

            Button_Control();
        }

        private void cmb_vendor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (first_flg)
                return;

            Button_Control();
        }
        #endregion

        #region Context Menu
        private void mnu_mat_Click(object sender, EventArgs e)
        {
            fgrid_order.Tree.Show(1);
        }

        private void mnu_bom_Click(object sender, EventArgs e)
        {
            fgrid_order.Tree.Show(2);
        }

        private void mnu_vendor_Click(object sender, EventArgs e)
        {
            try
            {
                int [] sct_rows = fgrid_order.Selections;

                COM.ComVar.Parameter_PopUp = new string[2];

                Pop_Pur_Order_Vendor pop_vendor = new Pop_Pur_Order_Vendor();
                pop_vendor.ShowDialog();


                if (pop_vendor.save_flg)
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        if (fgrid_order[sct_rows[i], (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxT_LEVEL].ToString() == "1")
                        {
                            fgrid_order[sct_rows[i], (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxVEN_SEQ]  = COM.ComVar.Parameter_PopUp[0];
                            fgrid_order[sct_rows[i], (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxVEN_NAME] = COM.ComVar.Parameter_PopUp[1];
                            fgrid_order.Update_Row(sct_rows[i]);
                        }
                    }
                }
            }
            catch
            {
 
            }
        }

        private void mnu_release_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string arg_factory = cmb_factory.SelectedValue.ToString();
                string arg_pur_no = cmb_pur_no.SelectedValue.ToString();
                string arg_status = "Y";

                CONFIRM_PUR_ORDER(arg_factory, arg_pur_no, arg_status);

                tbtn_Search_Click(null, null);
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Grid Event
        private void fgrid_order_AfterEdit(object sender, RowColEventArgs e)
        {
            int [] sct_rows = fgrid_order.Selections;
            int sct_row = fgrid_order.Selection.r1;
            int sct_col = fgrid_order.Selection.c1;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                string _lev = fgrid_order[sct_rows[i], (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxT_LEVEL].ToString().Trim();

                if (_lev.Equals("1"))
                {
                    fgrid_order[sct_rows[i], (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxDIVISION] = "U";
                    fgrid_order[sct_rows[i], sct_col] = fgrid_order[sct_row, sct_col].ToString().Trim();

                    if (sct_col.Equals((int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxVEN_NAME))
                        fgrid_order[sct_rows[i], (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxVEN_SEQ] = fgrid_order[sct_row, sct_col].ToString().Trim();
                }
            }

            if (sct_col == (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxVALUE_PUR)
            {
                ClassLib.ComFunction.NextRow_Focus_FlexGrid(fgrid_order, fgrid_order.Selection.r1, fgrid_order.Selection.c1, true, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxT_LEVEL, "1");
            }
        }
        private void fgrid_order_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                //int sct_row = fgrid_order.MouseRow;
                //int sct_col = fgrid_order.MouseCol;

                //if (sct_row >= fgrid_order.Rows.Fixed)
                //{
                //    if (!fgrid_order[sct_row, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxSTATUS].ToString().Equals("C") && sct_col == (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxVEN_NAME)
                //    {
                //        string vMatcd = fgrid_order[fgrid_order.Selection.r1, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxMAT_CD].ToString();
                //        string vPurno = fgrid_order[fgrid_order.Selection.r1, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxPUR_NO].ToString();

                //        if (vMatcd == "") return;
                //        if (vPurno == "") return;

                //        DataTable dt = SELECT_PUR_GRID_VENDOR(vPurno, vMatcd);
                //        string ven_seq = "";
                //        string ven_name = "";

                //        System.Collections.Specialized.ListDictionary ld = new System.Collections.Specialized.ListDictionary();
                //        ld.Add("", "");

                //        if (dt.Rows.Count > 0)
                //        {
                //            for (int i = 0; i < dt.Rows.Count; i++)
                //            {
                //                ven_name = dt.Rows[i].ItemArray[0].ToString();
                //                ven_seq  = dt.Rows[i].ItemArray[1].ToString();

                //                ld.Add(ven_seq, ven_name);
                //            }
                //        }

                //        fgrid_order.Cols[sct_col].DataMap = ld;                        
                //    }
                //}
            }
            catch
            {

            }
        }
        private void fgrid_order_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_col = fgrid_order.Selection.c1;
                int sct_row = fgrid_order.Selection.r1;                

                mnu_vendor.Enabled = false;

                if (sct_row >= fgrid_order.Rows.Fixed)
                {
                    if (!fgrid_order[sct_row, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxSTATUS].ToString().Equals("C") && sct_col == (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxVEN_NAME)
                    {
                        mnu_vendor.Enabled = true;

                        string vMatcd = fgrid_order[sct_row, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxMAT_CD].ToString();
                        string vPurno = fgrid_order[sct_row, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxPUR_NO].ToString();

                        if (vMatcd == "") return;
                        if (vPurno == "") return;

                        DataTable dt = SELECT_PUR_GRID_VENDOR(vPurno, vMatcd);
                        string ven_seq = "";
                        string ven_name = "";

                        System.Collections.Specialized.ListDictionary ld = new System.Collections.Specialized.ListDictionary();
                        ld.Add("", "");

                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                ven_name = dt.Rows[i].ItemArray[0].ToString();
                                ven_seq  = dt.Rows[i].ItemArray[1].ToString();

                                ld.Add(ven_seq, ven_name);
                            }
                        }

                        fgrid_order.GetCellRange(fgrid_order.Selection.r1, sct_col, fgrid_order.Selection.r2, sct_col).StyleNew.DataMap = ld;
                    }

                    if (fgrid_order[sct_row, (int)ClassLib.TBSXP_PUR_ORDER_NEW_02.IxSTATUS].ToString().Equals("C"))
                    {
                        mnu_release.Enabled = true;

                    }
                    else
                    {
                        mnu_release.Enabled = false; 
                    }
                }                           
            }
            catch
            {
 
            }
        }

        private DataTable SELECT_PUR_GRID_VENDOR(string arg_pur_no, string arg_mat)
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_PUR_VENDOR_GRID";

            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[2] = "ARG_MAT_CD";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = ClassLib.ComVar.This_CDC_Factory;
            MyOraDB.Parameter_Values[1] = arg_pur_no;
            MyOraDB.Parameter_Values[2] = arg_mat;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion
                            
    }
}

