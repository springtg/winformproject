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
    public partial class Form_Pur_List_CSC : COM.PCHWinForm.Form_Top
    {
        public Form_Pur_List_CSC()
        {
            InitializeComponent();
        }

        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private int _RowFixed;
        private int show_lev = 1;
        private bool FirstFlg;
        #endregion

        #region 공통메서드
        private void Init_Form()
        {
            
            this.Text = "PCC_Purchase List_SHC";
            this.lbl_MainTitle.Text = "PCC_Purchase List_SHC";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting

            FirstFlg = true;

            dpk_get_from.Value = DateTime.Now;
            dpk_get_to.Value = DateTime.Now;

            //pur master Status
            DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_MatDiv);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_div, 1, 2, true, false);
            //cmb_pur_div.SelectedValue = "21";
            //cmb_pur_div.Enabled = false;
            cmb_pur_div.SelectedIndex = 0;

            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_DataType);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_data_type, 1, 2, true, false);
            cmb_data_type.SelectedIndex = 0;
           
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurOrder_Status);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2, true, false);
            cmb_status.SelectedIndex = 3;
            cmb_status.Enabled = false;

            //dt_ret = Select_sdc_nf_desc();
            //ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_purpose, 0, 2, true, COM.ComVar.ComboList_Visible.Name);
            //cmb_purpose.SelectedIndex = 0;

            //dt_ret = Select_cdc_dev();
            //ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_cdc, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            //cmb_cdc.SelectedIndex = 0;

            #region Upload  User설정

            dt_ret = Select_sxp_pur_user();


            cmb_pur_user.Enabled = true;
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_pur_user.SelectedIndex = 0;
            cmb_pur_user.Enabled = false;

            //if (ClassLib.ComVar.This_Admin_YN == "Y")
            //{
            //    cmb_pur_user.Enabled = true;
            //    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            //    cmb_pur_user.SelectedIndex = 0;
            //}
            //else
            //{
            //    cmb_pur_user.Enabled = false;

            //    DataTable user_datatable = new DataTable("UserList");
            //    DataRow newrow;

            //    user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
            //    user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

            //    newrow = user_datatable.NewRow();
            //    newrow["Code"] = ClassLib.ComVar.This_User;
            //    newrow["Name"] = ClassLib.ComVar.This_User;

            //    user_datatable.Rows.Add(newrow);

            //    ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_pur_user, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
            //    cmb_pur_user.SelectedValue = ClassLib.ComVar.This_User;

            //}
            #endregion

            try
            {
                Set_po_no();
            }
            catch
            {
            }

            //dt_ret = Select_season();
            //ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            //cmb_season.SelectedIndex = 0;
            FirstFlg = false;
            #endregion

            #region Grid Setting
            flg_pur_order.Set_Grid_CDC("SXP_PUR_LIST_CSC", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            flg_pur_order.Set_Action_Image(img_Action);
            flg_pur_order.ExtendLastCol = false;
            _RowFixed = flg_pur_order.Rows.Count;
            #endregion
            cmb_pur_user.Enabled = false;
            cmb_data_type.Enabled = false;
            
            button_control();
        }
        private void Set_po_no()
        {
            DataTable dt_ret = Get_Pur_No();

            //ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_no, 0, 0, true, false);
            //cmb_pur_no.SelectedIndex = 0;

            try
            {
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_pur_no, true, 0, 0, 0, 211);
                cmb_pur_no.SelectedIndex = 0;
            }
            catch
            {

            }
        }
        private void button_control()
        {
            try
            {
                tbtn_Confirm.Enabled = false;
                tbtn_Create.Enabled = false;
                tbtn_Print.Enabled = true;
                tbtn_Delete.Enabled = false;
                tbtn_Save.Enabled = false;
            }
            catch
            {

            }
        }
        #endregion 

        #region 이벤트처리

        #region ToolBar Button Event
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

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;

                flg_pur_order.Rows.Count = _RowFixed;
                DataTable dt = Search_pur_order(cmb_factory.SelectedValue.ToString(), cmb_pur_user.SelectedValue.ToString(), dpk_get_from.Value.ToString("yyyyMMdd"),
                                                dpk_get_to.Value.ToString("yyyyMMdd"), cmb_status.SelectedValue.ToString(), cmb_pur_no.SelectedValue.ToString(),
                                                cmb_data_type.SelectedValue.ToString(), cmb_pur_div.SelectedValue.ToString(), cmb_vendor.SelectedValue.ToString(),
                                                cmb_model.SelectedValue.ToString(), txt_mat_name.Text.Trim().ToUpper(), txt_srf_no.Text.Trim().ToUpper());


                int dt_rows = dt.Rows.Count;
                int dt_cols = dt.Columns.Count;

                if (dt_rows > 0)
                {

                    for (int i = 0; i < dt_rows; i++)
                    {

                        flg_pur_order.AddItem(dt.Rows[i].ItemArray, flg_pur_order.Rows.Count, 1);

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

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                 
                string _factory  = cmb_factory.SelectedValue.ToString();
                string _pur_user = cmb_pur_user.SelectedValue.ToString(); 
                string _get_from = dpk_get_from.Text.Replace("-", "");   
                string _get_to   = dpk_get_to.Text.Replace("-", "");
                string _status   = cmb_status.SelectedValue.ToString();
                string _pur_no   = cmb_pur_no.SelectedValue.ToString(); 
                string _datatype = cmb_data_type.SelectedValue.ToString();
                string _pur_div  = cmb_pur_div.SelectedValue.ToString();
                string _vendor   = cmb_vendor.SelectedValue.ToString(); 
                string _style    = ClassLib.ComFunction.Empty_Combo(cmb_model, ""); 
                string _mat_name = ClassLib.ComFunction.Empty_TextBox(txt_mat_name, ""); 
                string _srf_no   = ClassLib.ComFunction.Empty_TextBox(txt_srf_no, "");

                Pop_Pur_List_PrintOption pop_print = new Pop_Pur_List_PrintOption("SHC", _factory, _pur_user, _get_from, _get_to, _status, _pur_no, _datatype, _pur_div, _vendor, _style, _mat_name, _srf_no, "", "", "", "", "", "", "", "");
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

        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            
        }
        #endregion

        #region Control Event
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

        private void cmb_pur_user_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_pur_user.SelectedIndex == -1) return;
                if (FirstFlg) return;
                //try
                //{
                //    //select_pur_vendor();
                //}
                //catch
                //{
                //}

                try
                {

                    Set_po_no();
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

                Set_po_no();               
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

                Set_po_no();
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
                //try
                //{
                //    //select_pur_vendor();
                //}
                //catch
                //{
                //}

                try
                {
                    Set_po_no();
                }
                catch
                {
                }

                button_control();
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
                    select_pur_vendor();
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

                try
                {
                    Set_po_no();
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

        private void cmb_pur_no_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_pur_no.SelectedIndex == -1) return;

                try
                {
                    select_pur_vendor();
                    button_control();

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


                DataTable dt_ret = Select_category();
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


                DataTable dt_ret = Select_sdc_nf_desc();
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


                DataTable dt_ret = Select_cdc_dev();
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


                DataTable dt_ret = Select_season();
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

                select_model();

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

        #endregion

        #region DB Connect

        #region Display 관련
        private DataTable Select_sdc_nf_desc()
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_PURPOSE_CSC";

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

        private DataTable Select_season()
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SEASON_CSC";

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

        private DataTable Select_category()
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_CATEGORY_CSC";

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

        private DataTable Select_cdc_dev()
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_CDC_DEV_LIST_CSC";

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

        private DataTable Select_sxp_pur_user()
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

        private DataTable Get_Pur_No()
        {

            MyOraDB.ReDim_Parameter(7);

            MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.GET_SXP_PUR_NO_CSC";

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

        private void select_pur_vendor()
        {

            MyOraDB.ReDim_Parameter(9);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXP_PUR_VENDOR_CSC";

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
            DataSet ds_Search = MyOraDB.Exe_Select_Procedure();

            DataTable dt = ds_Search.Tables[MyOraDB.Process_Name];

            ClassLib.ComCtl.Set_ComboList_AddItem(dt, cmb_vendor, true, 0, 1, 0, 211);
            cmb_vendor.SelectedIndex = 0;


        }

        private void select_model()
        {

            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXP_PUR_MODEL_CSC";

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

        private DataTable Search_pur_order(string arg_factory, string arg_pur_user, string arg_get_from,
                                           string arg_get_to, string arg_status, string arg_pur_no,
                                           string arg_data_type, string arg_pur_div, string arg_ven_seq,
                                           string arg_style_name, string arg_mat_name, string arg_srf_no)
        {

            MyOraDB.ReDim_Parameter(17);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXP_PUR_ORDER_LIST_CSC";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PUR_USER";
            MyOraDB.Parameter_Name[2] = "ARG_GET_FROM";
            MyOraDB.Parameter_Name[3] = "ARG_GET_TO";
            MyOraDB.Parameter_Name[4] = "ARG_STATUS";
            MyOraDB.Parameter_Name[5] = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[6] = "ARG_mrp_req_flg";
            MyOraDB.Parameter_Name[7] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[8] = "ARG_VEN_SEQ";
            MyOraDB.Parameter_Name[9] = "ARG_STYLE_NAME";
            MyOraDB.Parameter_Name[10] = "ARG_MAT_NAME";
            MyOraDB.Parameter_Name[11] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[12] = "ARG_SEASON";
            MyOraDB.Parameter_Name[13] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[14] = "ARG_PURPOSE";
            MyOraDB.Parameter_Name[15] = "ARG_CDC_DEV";
            MyOraDB.Parameter_Name[16] = "OUT_CURSOR";

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
            MyOraDB.Parameter_Type[16] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_pur_user;
            MyOraDB.Parameter_Values[2] = arg_get_from;
            MyOraDB.Parameter_Values[3] = arg_get_to;
            MyOraDB.Parameter_Values[4] = arg_status;
            MyOraDB.Parameter_Values[5] = arg_pur_no;
            MyOraDB.Parameter_Values[6] = arg_data_type;
            MyOraDB.Parameter_Values[7] = arg_pur_div;
            MyOraDB.Parameter_Values[8] = arg_ven_seq;
            MyOraDB.Parameter_Values[9] = arg_style_name;
            MyOraDB.Parameter_Values[10] = arg_mat_name;
            MyOraDB.Parameter_Values[11] = arg_srf_no;
            MyOraDB.Parameter_Values[12] = cmb_season.SelectedValue.ToString();
            MyOraDB.Parameter_Values[13] = cmb_category.SelectedValue.ToString();
            MyOraDB.Parameter_Values[14] = cmb_purpose.SelectedValue.ToString();
            MyOraDB.Parameter_Values[15] = cmb_cdc.SelectedValue.ToString();
            MyOraDB.Parameter_Values[16] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_Search = MyOraDB.Exe_Select_Procedure();

            return ds_Search.Tables[MyOraDB.Process_Name];

        }
        #endregion

        #endregion

        private void Form_Pur_List_CSC_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);

                cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
                cmb_factory.Enabled = false;
            }
            catch
            {

            }

        }

        

        
     
    }
}

