using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;


namespace FlexCDC.Purchase
{
    public partial class Form_Pur_Order_List : COM.PCHWinForm.Form_Top
    {
        #region 생성자
        public Form_Pur_Order_List()
        {
            InitializeComponent();
        }
        #endregion

        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private int _RowFixed;
        private int show_lev = 1;
        private bool FirstFlg;
        #endregion

        #region Form Loading
        private void Form_Pur_Order_List_Load(object sender, EventArgs e)
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
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
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
            this.Text = "PCC_Purchase List";
            this.lbl_MainTitle.Text = "PCC_Purchase List";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            FirstFlg = true;

            dpk_get_from.Value = DateTime.Now.AddDays(-7);
            dpk_get_to.Value = DateTime.Now;

            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_MatDiv);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_div, 1, 2, true, false);
            cmb_pur_div.SelectedIndex = 0;


            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_DataType);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_data_type, 1, 2, true, false);
            cmb_data_type.SelectedIndex = 0;

            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurOrder_Status);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2, true, false);
            cmb_status.SelectedIndex = 3;
            cmb_status.Enabled = false;

            dt_ret = SELECT_SXP_PUR_USER();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_pur_user.SelectedIndex = 0;

            try
            {
                Set_Pur_No();
            }
            catch
            {
            }

            cmb_sort.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_sort.ClearItems();

            cmb_sort.AddItemTitles("Code;Name");

            cmb_sort.ValueMember = "Code";
            cmb_sort.DisplayMember = "Name";

            cmb_sort.AddItem("ALL;ALL");
            cmb_sort.AddItem("01;ETC Date is existed");
            cmb_sort.AddItem("02;ETC Date is not existed");
            cmb_sort.AddItem("03;Incoming Date is not existed");

            cmb_sort.SelectedIndex = -1;

            cmb_sort.MaxDropDownItems = 10;
            cmb_sort.Splits[0].DisplayColumns[0].Width = 0;
            cmb_sort.Splits[0].DisplayColumns[1].Width = 211;

            cmb_sort.ExtendRightColumn = true;
            cmb_sort.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_sort.HScrollBar.Height = 0;

            cmb_sort.SelectedIndex = 0;

            FirstFlg = false;
            #endregion

            #region Grid Setting
            flg_pur_order.Set_Grid_CDC("SXP_PUR_ORDER_LIST", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            flg_pur_order.Set_Action_Image(img_Action);
            flg_pur_order.ExtendLastCol = false;
            _RowFixed = flg_pur_order.Rows.Count;
            #endregion

            Button_Control();
        }
        private void Button_Control()
        {
            try
            {
                tbtn_Confirm.Enabled = false;
                tbtn_Create.Enabled  = false;
                tbtn_Print.Enabled   = true;
                tbtn_Delete.Enabled  = false;
                
                if (ClassLib.ComVar.This_CDCPower_Level.ToString().Substring(0, 1) != "P" && ClassLib.ComVar.This_CDCPower_Level.ToString() != "S00")
                {
                    tbtn_Save.Enabled = false;
                }
            }
            catch
            {

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

                flg_pur_order.Rows.Count = _RowFixed;
                DataTable dt = SEARCH_DATA();

                int dt_rows = dt.Rows.Count;
                int dt_cols = dt.Columns.Count;

                if (dt_rows > 0)
                {
                    for (int i = 0; i < dt_rows; i++)
                    {
                        flg_pur_order.AddItem(dt.Rows[i].ItemArray, flg_pur_order.Rows.Count, 1);

                        if (flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxVALUE_PUR].ToString() == "0")
                        {
                            flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxIN_YMD] = flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxETC_YMD].ToString();
                            flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxLEADTIME] = "0";
                        }
                    }
                }

                flg_pur_order.Tree.Show(show_lev);
            }
            catch
            {
                this.Cursor = Cursors.Default;
                COM.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private DataTable SEARCH_DATA()
        {

            MyOraDB.ReDim_Parameter(20);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXP_PUR_LIST";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PUR_USER";
            MyOraDB.Parameter_Name[2] = "ARG_GET_FROM";
            MyOraDB.Parameter_Name[3] = "ARG_GET_TO";
            MyOraDB.Parameter_Name[4] = "ARG_STATUS";
            MyOraDB.Parameter_Name[5] = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[6] = "ARG_MRP_REQ_FLG";
            MyOraDB.Parameter_Name[7] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[8] = "ARG_VEN_SEQ";
            MyOraDB.Parameter_Name[9] = "ARG_STYLE_NAME";
            MyOraDB.Parameter_Name[10] = "ARG_MAT_NAME";
            MyOraDB.Parameter_Name[11] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[12] = "ARG_SEASON";
            MyOraDB.Parameter_Name[13] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[14] = "ARG_PURPOSE";
            MyOraDB.Parameter_Name[15] = "ARG_CDC_DEV";
            MyOraDB.Parameter_Name[16] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[17] = "ARG_SORT";
            MyOraDB.Parameter_Name[18] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[19] = "OUT_CURSOR";

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
            MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[19] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = cmb_pur_user.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = dpk_get_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = dpk_get_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[4] = cmb_status.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = cmb_pur_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[6] = cmb_data_type.SelectedValue.ToString();
            MyOraDB.Parameter_Values[7] = cmb_pur_div.SelectedValue.ToString();
            MyOraDB.Parameter_Values[8] = cmb_vendor.SelectedValue.ToString();
            MyOraDB.Parameter_Values[9] = cmb_model.SelectedValue.ToString();
            MyOraDB.Parameter_Values[10] = txt_mat_name.Text.Trim().ToUpper();
            MyOraDB.Parameter_Values[11] = txt_srf_no.Text.Trim().ToUpper();
            MyOraDB.Parameter_Values[12] = cmb_season.SelectedValue.ToString();
            MyOraDB.Parameter_Values[13] = cmb_category.SelectedValue.ToString();
            MyOraDB.Parameter_Values[14] = cmb_purpose.SelectedValue.ToString();
            MyOraDB.Parameter_Values[15] = cmb_cdc.SelectedValue.ToString();
            MyOraDB.Parameter_Values[16] = txt_bom_id.Text;
            MyOraDB.Parameter_Values[17] = cmb_sort.SelectedValue.ToString();
            MyOraDB.Parameter_Values[18] = txt_style_cd.Text.Trim();
            MyOraDB.Parameter_Values[19] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_Search = MyOraDB.Exe_Select_Procedure();

            return ds_Search.Tables[MyOraDB.Process_Name];

        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (flg_pur_order.Rows.Count == flg_pur_order.Rows.Fixed) return;

                for (int i = flg_pur_order.Rows.Fixed; i < flg_pur_order.Rows.Count; i++)
                {
                    if (flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxDIV] != null && flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxDIV].ToString() == "U")
                    {
                        string arg_bar_code = flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxBAR_CODE].ToString();
                        string arg_etc_ymd  = flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxETC_YMD].ToString();

                        SAVE_DATA(arg_bar_code, arg_etc_ymd);
                        flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxDIV] = "";
                    }
                }

            }
            catch
            {
                this.Cursor = Cursors.Default;

                COM.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave);

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void SAVE_DATA(string arg_bar_code, string arg_etc_ymd)
        {

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_02.SAVE_SXP_PUR_TAIL";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_BAR_CODE";
            MyOraDB.Parameter_Name[1] = "ARG_ETC_YMD";
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_bar_code;
            MyOraDB.Parameter_Values[1] = arg_etc_ymd;
            MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;

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

                string _factory  = cmb_factory.SelectedValue.ToString();
                string _pur_user = cmb_pur_user.SelectedValue.ToString();
                string _get_from = dpk_get_from.Value.ToString("yyyyMMdd");
                string _get_to   = dpk_get_to.Value.ToString("yyyyMMdd");
                string _status   = cmb_status.SelectedValue.ToString();

                string _pur_no   = cmb_pur_no.SelectedValue.ToString();
                string _datatype = cmb_data_type.SelectedValue.ToString();
                string _pur_div  = cmb_pur_div.SelectedValue.ToString();
                string _vendor   = cmb_vendor.SelectedValue.ToString();
                string _style    = ClassLib.ComFunction.Empty_Combo(cmb_model, "");

                string _mat_name = ClassLib.ComFunction.Empty_TextBox(txt_mat_name, "");
                string _srf_no   = ClassLib.ComFunction.Empty_TextBox(txt_srf_no, "");
                string _season   = ClassLib.ComFunction.Empty_Combo(cmb_season, "");
                string _category = ClassLib.ComFunction.Empty_Combo(cmb_category, "");
                string _purpose  = ClassLib.ComFunction.Empty_Combo(cmb_purpose, "");

                string _cdc      = ClassLib.ComFunction.Empty_Combo(cmb_cdc, "");
                string _bom_id   = ClassLib.ComFunction.Empty_TextBox(txt_bom_id, "");
                string _style_cd = ClassLib.ComFunction.Empty_TextBox(txt_style_cd, "");
                string _etc_from = "N";
                string _etc_to   = "";

                Pop_Pur_List_PrintOption pop_print = new Pop_Pur_List_PrintOption("PCC", _factory, _pur_user, _get_from, _get_to,
                                                                                  _status, _pur_no, _datatype, _pur_div, _vendor,
                                                                                  _style, _mat_name, _srf_no, _season, _category, 
                                                                                  _purpose, _cdc, _bom_id, _style_cd, _etc_from, _etc_to);
                pop_print.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsNotPrint, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        #endregion

        #region Control Event
        private void cmb_pur_user_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_pur_user.SelectedIndex == -1) return;
                if (FirstFlg) return;

                try
                {
                    Set_Pur_No();
                }
                catch
                {


                }
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

        private void dpk_get_from_CloseUp(object sender, EventArgs e)
        {

            if (FirstFlg) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Set_Pur_No();
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

        private void dpk_get_to_CloseUp(object sender, EventArgs e)
        {
            if (FirstFlg) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Set_Pur_No();
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

        private void cmb_status_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_status.SelectedIndex == -1) return;
                if (FirstFlg) return;

                try
                {
                    Set_Pur_No();
                }
                catch
                {
                }

                Button_Control();
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

        private void cmb_data_type_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_data_type.SelectedIndex == -1) return;
                if (FirstFlg) return;

                try
                {
                    GET_PUR_VENDOR();
                }
                catch
                {
                }
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

        private void cmb_pur_div_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (cmb_pur_div.SelectedIndex == -1) return;
                if (FirstFlg) return;

                Set_Pur_No();

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

        private void cmb_pur_no_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_pur_no.SelectedIndex == -1) return;

                try
                {
                    GET_PUR_VENDOR();
                    Button_Control();

                }
                catch
                {
                }
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

        private void cmb_season_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_season.SelectedIndex == -1) return;


                DataTable dt_ret = GET_PUR_CATEGORY();
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_category, true, 0, 1, 0, 211);
                cmb_category.SelectedIndex = 0;

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

        private void cmb_category_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_category.SelectedIndex == -1) return;


                DataTable dt_ret = GET_ROUND();
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_purpose, true, 0, 1, 0, 211);
                cmb_purpose.SelectedIndex = 0;

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

        private void cmb_purpose_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_purpose.SelectedIndex == -1) return;


                DataTable dt_ret = GET_CDC_DEV();
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_cdc, true, 0, 0, 0, 211);
                cmb_cdc.SelectedIndex = 0;

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

        private void cmb_vendor_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_vendor.SelectedIndex == -1) return;


                DataTable dt_ret = GET_SEASON();
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_season, true, 0, 1, 0, 211);
                cmb_season.SelectedIndex = 0;

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

        private void cmb_cdc_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_cdc.SelectedIndex == -1) return;

                GET_MODEL();

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


        private void Set_Pur_No()
        {
            DataTable dt_ret = GET_PUR_NO();

            try
            {
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_pur_no, true, 0, 0, 0, 211);
                cmb_pur_no.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private DataTable GET_PUR_NO()
        {
            MyOraDB.ReDim_Parameter(7);

            MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.GET_SXP_PUR_NO_LIST";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PUR_USER";
            MyOraDB.Parameter_Name[2] = "ARG_GET_FROM";
            MyOraDB.Parameter_Name[3] = "ARG_GET_TO";
            MyOraDB.Parameter_Name[4] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[5] = "ARG_STATUS";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = cmb_pur_user.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = dpk_get_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = dpk_get_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[4] = cmb_pur_div.SelectedValue.ToString();
            try
            {
                MyOraDB.Parameter_Values[5] = cmb_status.SelectedValue.ToString();
            }
            catch
            {
                MyOraDB.Parameter_Values[5] = " ";
            }
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }
        private void GET_PUR_VENDOR()
        {

            DataSet ds_Search;

            MyOraDB.ReDim_Parameter(9);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXP_PUR_LIST_VENDOR";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PUR_USER";
            MyOraDB.Parameter_Name[2] = "ARG_GET_FROM";
            MyOraDB.Parameter_Name[3] = "ARG_GET_TO";
            MyOraDB.Parameter_Name[4] = "ARG_STATUS";
            MyOraDB.Parameter_Name[5] = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[6] = "ARG_MRP_REQ_FLG";
            MyOraDB.Parameter_Name[7] = "ARG_PUR_DIV";
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
            MyOraDB.Parameter_Values[1] = cmb_pur_user.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = dpk_get_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = dpk_get_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[4] = cmb_status.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = cmb_pur_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[6] = cmb_data_type.SelectedValue.ToString();
            MyOraDB.Parameter_Values[7] = cmb_pur_div.SelectedValue.ToString();
            MyOraDB.Parameter_Values[8] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_Search = MyOraDB.Exe_Select_Procedure();

            DataTable dt = ds_Search.Tables[MyOraDB.Process_Name];

            try
            {
                ClassLib.ComCtl.Set_ComboList_AddItem(dt, cmb_vendor, true, 0, 1, 0, 211);
                cmb_vendor.SelectedIndex = 0;
            }
            catch
            {

            }
        }
        private DataTable GET_PUR_CATEGORY()
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_CATEGORY";

            MyOraDB.ReDim_Parameter(7);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
            MyOraDB.Parameter_Name[3] = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[4] = "ARG_VEN_SEQ";
            MyOraDB.Parameter_Name[5] = "ARG_SEASON";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = dpk_get_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = cmb_pur_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = cmb_vendor.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = cmb_season.SelectedValue.ToString();
            MyOraDB.Parameter_Values[6] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable GET_ROUND()
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_PURPOSE";

            MyOraDB.ReDim_Parameter(8);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
            MyOraDB.Parameter_Name[3] = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[4] = "ARG_VEN_SEQ";
            MyOraDB.Parameter_Name[5] = "ARG_SEASON";
            MyOraDB.Parameter_Name[6] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

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
            MyOraDB.Parameter_Values[3] = cmb_pur_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = cmb_vendor.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = cmb_season.SelectedValue.ToString();
            MyOraDB.Parameter_Values[6] = cmb_category.SelectedValue.ToString();
            MyOraDB.Parameter_Values[7] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable GET_CDC_DEV()
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_CDC_DEV_LIST";

            MyOraDB.ReDim_Parameter(9);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
            MyOraDB.Parameter_Name[3] = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[4] = "ARG_VEN_SEQ";
            MyOraDB.Parameter_Name[5] = "ARG_SEASON";
            MyOraDB.Parameter_Name[6] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[7] = "ARG_PURPOSE";
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

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = dpk_get_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = cmb_pur_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = cmb_vendor.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = cmb_season.SelectedValue.ToString();
            MyOraDB.Parameter_Values[6] = cmb_category.SelectedValue.ToString();
            MyOraDB.Parameter_Values[7] = cmb_purpose.SelectedValue.ToString();
            MyOraDB.Parameter_Values[8] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable GET_SEASON()
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SEASON";

            MyOraDB.ReDim_Parameter(6);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
            MyOraDB.Parameter_Name[3] = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[4] = "ARG_VEN_SEQ";
            MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = dpk_get_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = cmb_pur_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = cmb_vendor.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private void GET_MODEL()
        {


            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXP_PUR_MODEL";

            MyOraDB.ReDim_Parameter(9);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
            MyOraDB.Parameter_Name[3] = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[4] = "ARG_VEN_SEQ";
            MyOraDB.Parameter_Name[5] = "ARG_SEASON";
            MyOraDB.Parameter_Name[6] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[7] = "ARG_PURPOSE";
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

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = dpk_get_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = dpk_get_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = cmb_pur_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = cmb_vendor.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = cmb_season.SelectedValue.ToString();
            MyOraDB.Parameter_Values[6] = cmb_category.SelectedValue.ToString();
            MyOraDB.Parameter_Values[7] = cmb_purpose.SelectedValue.ToString();
            MyOraDB.Parameter_Values[8] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            DataTable dt = DS_Ret.Tables[MyOraDB.Process_Name];
            try
            {
                ClassLib.ComCtl.Set_ComboList_AddItem(dt, cmb_model, true, 0, 0, 0, 211);
                cmb_model.SelectedIndex = 0;
            }
            catch
            {

            }

        }
        #endregion
       
        #region Grid Event
        private void flg_pur_order_AfterEdit(object sender, RowColEventArgs e)
        {
            int[] selectRows = flg_pur_order.Selections;

            int sct_row = flg_pur_order.Selection.r1;
            int sct_col = flg_pur_order.Selection.c1;

            if (sct_col == (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxETC_YMD)
            {
                string etc = flg_pur_order[sct_row, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxETC_YMD].ToString();


                if (etc.Length != 0)
                {
                    int etcYear = 0;
                    int etcMonth = 0;
                    int etcDay = 0;
                    try
                    {
                        etcYear = int.Parse(etc.Trim().Substring(0, 4));
                        etcMonth = int.Parse(etc.Trim().Substring(4, 2));
                        etcDay = int.Parse(etc.Trim().Substring(6, 2));
                    }
                    catch
                    {
                        MessageBox.Show("Input Error : Wrong Date.");
                        flg_pur_order[sct_row, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxETC_YMD] = "";
                        return;
                    }

                    if (etcMonth == 0 || etcMonth > 12)
                    {
                        MessageBox.Show("Input Error : Wrong Date.");
                        flg_pur_order[sct_row, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxETC_YMD] = "";
                        return;
                    }

                    if (etcDay > int.Parse(DateTime.DaysInMonth(etcYear, etcMonth).ToString()))
                    {
                        MessageBox.Show("Input Error : Wrong Date.");
                        flg_pur_order[sct_row, (int)ClassLib.TBSXP_PUR_ORDER_LIST.IxETC_YMD] = "";
                        return;
                    }
                }

            }

            for (int i = 0; i <flg_pur_order.Selections.Length; i++)
            {
                flg_pur_order[selectRows[i], sct_col] = flg_pur_order[sct_row, sct_col].ToString();
                flg_pur_order.Update_Row(selectRows[i]);
            }
        }     
        #endregion               
    }
}

