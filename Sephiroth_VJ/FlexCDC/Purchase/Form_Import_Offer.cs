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
    public partial class Form_Import_Offer : COM.PCHWinForm.Form_Top
    {
        #region 생성자
        public Form_Import_Offer()
        {
            InitializeComponent();
        }
        #endregion

        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성

        private string combo_category = "BA65";
        private string combo_season   = "BA66";
        private string combo_purpose  = "BA67";

        private bool click_flg = false;

        private string power_level = COM.ComVar.This_CDCPower_Level;
        private string group_cd    = COM.ComVar.This_CDCGroup_Code;

        #endregion

        #region Form Loading
        private void Form_Import_Offer_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                click_flg = true;
                Init_Form();
                click_flg = false;
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
            //Title Setting
            this.Text = "PCC_Import Offer";
            this.lbl_MainTitle.Text = "PCC_Import Offer";
            this.lbl_title.Text = "         Import Offer Information";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            //Order Date
            dtp_from.Value = DateTime.Now.AddDays(-7);
            dtp_to.Value = DateTime.Now;

            //Category
            DataTable dt_list = Select_cm_code(combo_category);
            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_category_h, 0, 0, true, 0, 130);
            cmb_category_h.SelectedIndex = 0;

            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_category_t, 0, 0, false, 0, 180);
            cmb_category_t.SelectedIndex = 0;

            //Season
            dt_list = Select_cm_code(combo_season);
            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_season_h, 0, 0, true, 0, 130);
            cmb_season_h.SelectedIndex = 0;

            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_season_t, 0, 0, false, 0, 180);
            cmb_season_t.SelectedIndex = 0;

            //Purpose
            dt_list = Select_cm_code(combo_purpose);
            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_purpose_h, 0, 0, true, 0, 130);
            cmb_purpose_h.SelectedIndex = 0;

            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_purpose, 0, 0, false, 0, 180);
            cmb_purpose.SelectedIndex = 0;

            
                   
            #region Upload  User설정            
            if (!power_level.Substring(0,1).Equals("D") && !power_level.Equals("I01") && !power_level.Substring(0, 1).Equals("E"))
            {
                cmb_upd_user_h.Enabled = true;
                dt_list = Select_upd_user();
                ClassLib.ComCtl.Set_ComboList(dt_list, cmb_upd_user_h, 0, 0, true, 0, 183);
                cmb_upd_user_h.SelectedIndex = 0;
            }
            else
            {
                cmb_upd_user_h.Enabled = false;

                DataTable user_datatable = new DataTable("UserList");
                DataRow newrow;

                user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                newrow = user_datatable.NewRow();
                newrow["Code"] = ClassLib.ComVar.This_User;
                newrow["Name"] = ClassLib.ComVar.This_User;

                user_datatable.Rows.Add(newrow);

                ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_upd_user_h, 0, 0, true, 0, 183);
                cmb_upd_user_h.SelectedValue = ClassLib.ComVar.This_User;
            }
            #endregion

            //Department
            dt_list = Select_department();
            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_department, 0, 1, false, 0, 180);
            cmb_department.SelectedValue = "000001";
            txt_dhl_acc.Text             = "961306030"; 

            dt_list.Dispose();
            #endregion

            #region Grid Setting
            fgrid_head.Set_Grid_CDC("SXZ_IMPORT_OFFER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_head.Set_Action_Image(img_Action);
            fgrid_head.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_head.Rows.Count = fgrid_head.Rows.Fixed;

            fgrid_tail.Set_Grid_CDC("SXZ_IMPORT_OFFER", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_tail.Set_Action_Image(img_Action);
            fgrid_tail.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_tail.Rows.Count = fgrid_tail.Rows.Fixed;
            #endregion

            #region Control Setting
            txt_offer_no_tail.Enabled = false;
            txt_offer_no_tail.BackColor = SystemColors.Control;
            txt_vendor.Enabled = false;
            txt_vendor.BackColor = SystemColors.Control;
            txt_history_no.Enabled = false;
            txt_history_no.BackColor = SystemColors.Control;
            txt_dhl_acc.Enabled = false;
            txt_dhl_acc.BackColor = SystemColors.Control;
            #endregion 

            #region Button Setting
            tbtn_New.ToolTipText     = "Create";
            tbtn_Search.ToolTipText  = "Search";
            tbtn_Save.ToolTipText    = "Save";
            tbtn_Delete.ToolTipText  = "Delete";
            tbtn_Print.ToolTipText   = "Print";
            tbtn_Confirm.ToolTipText = "Confirm";
            tbtn_Create.ToolTipText  = "Rejection";

            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = true;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;              
            
            if (power_level.Equals("P01") && group_cd.Equals("SHC"))
            {//이정민씨 또는 김종열씨 일때
                tbtn_Confirm.Enabled = true;
                tbtn_Create.Enabled  = true; 
            }
            else if (power_level.Equals("S00"))
            {// 정보실
                tbtn_Confirm.Enabled = true;
                tbtn_Create.Enabled  = true;  
            }
            #endregion
                      

            tbtn_Search_Click(null, null);
        }

        private DataTable Select_cm_code(string arg_mcode)
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "pkg_sxp_pur_99_select.select_cm_code";

            MyOraDB.Parameter_Name[0] = "arg_mcode";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_mcode;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_upd_user()
        {
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_sxp_pur_99_select.select_upd_user";

            MyOraDB.Parameter_Name[0] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable Select_department()
        {
            MyOraDB.ReDim_Parameter(1);

            MyOraDB.Process_Name = "pkg_sxp_pur_99_select.select_department";

            MyOraDB.Parameter_Name[0] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();
            
            if(ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Button Event

        #region Create Data
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                fgrid_head.Rows.Insert(fgrid_head.Rows.Fixed);
                fgrid_tail.Rows.Count = fgrid_tail.Rows.Fixed;
                fgrid_tail.Rows.Insert(fgrid_tail.Rows.Fixed);
                fgrid_tail[fgrid_tail.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxDIV] = "I";

                Control_Clear();
                
                fgrid_head.Select(fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO);                

                fgrid_head[fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV]        = "I";
                fgrid_head[fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK]        = "True";
                fgrid_head[fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDEPT_CD]    = cmb_department.SelectedValue.ToString();
                fgrid_head[fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDEPT_NAME]  = cmb_department.Text;
                fgrid_head[fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_DATE] = dtp_order_date.Value.ToString("yyyyMMdd");
                fgrid_head[fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCATEGORY]   = cmb_category_t.SelectedValue.ToString();
                fgrid_head[fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxSEASON]     = cmb_season_t.SelectedValue.ToString();
                fgrid_head[fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxPURPOSE]    = cmb_purpose.SelectedValue.ToString();
                fgrid_head[fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxVIA]        = txt_dhl_acc.Text;
            }
            catch
            {
 
            }
        }
        private void mnu_insert_head_Click(object sender, EventArgs e)
        {
            try
            {                
                int sct_row = fgrid_head.Selection.r1 + 1;


                fgrid_head.Rows.Insert(fgrid_head.Rows.Fixed);
                fgrid_tail.Rows.Count = fgrid_tail.Rows.Fixed;
                fgrid_tail.Rows.Insert(fgrid_tail.Rows.Fixed);
                fgrid_tail[fgrid_tail.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxDIV] = "I";

                txt_offer_no.Text = "";
                txt_dhl_acc.Text = "961306030";
                fgrid_head.Select(fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO);

                fgrid_head[fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "I";
                fgrid_head[fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";

                for (int i = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDEPT_CD; i <= (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxLC_NO; i++)
                {
                    fgrid_head[fgrid_head.Rows.Fixed, i] = fgrid_head[sct_row, i].ToString();
                }
                
            }
            catch
            {

            }
        }
        private void mnu_insert_tail_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_tail.Selection.r1;

                fgrid_tail.Rows.Add();
                fgrid_tail[fgrid_tail.Rows.Count - 1, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxDIV] = "I";
                fgrid_tail[fgrid_tail.Rows.Count - 1, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCHK] = "False";
                fgrid_tail[fgrid_tail.Rows.Count - 1, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxSEQ] = "";
                fgrid_tail.Select(fgrid_tail.Rows.Count - 1, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxMAT_NAME);

                for (int i = (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxMAT_NAME; i <= (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxBLNO; i++)
                {
                    fgrid_tail[fgrid_tail.Rows.Count - 1, i] = fgrid_tail[sct_row, i].ToString();
                }                
            }
            catch
            {
 
            }
        }


        private void Control_Clear()
        {
            click_flg = true;

            txt_offer_no_tail.Clear();
            cmb_department.SelectedIndex = 0;
            dtp_order_date.Value = DateTime.Now;
            cmb_category_t.SelectedIndex = 0;
            cmb_season_t.SelectedIndex = 0;
            txt_model.Clear();
            txt_dev_cd.Clear();
            txt_vendor.Clear();
            txt_nike_dev.Clear();
            txt_cdc_dev.Clear();
            cmb_purpose.SelectedIndex = 0;
            txt_dhl_acc.Text = "961306030";
            txt_rta.Clear();
            txt_prod_code.Clear();
            txt_spl_ddd.Clear();
            txt_history_no.Clear();
            
            click_flg = false;
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                fgrid_head.Rows.Count = fgrid_head.Rows.Fixed;
                fgrid_tail.Rows.Count = fgrid_tail.Rows.Fixed;
                Clear_control();

                string[] arg_value = new string[9];

                arg_value[0] = txt_offer_no.Text.Trim();                       //offer_no
                arg_value[1] = dtp_from.Value.ToString("yyyyMMdd");            //date_from
                arg_value[2] = dtp_to.Value.ToString("yyyyMMdd");              //date_to
                arg_value[3] = cmb_category_h.SelectedValue.ToString().Trim(); //category
                arg_value[4] = cmb_season_h.SelectedValue.ToString().Trim();   //season
                arg_value[5] = cmb_purpose_h.SelectedValue.ToString().Trim();  //purpose
                arg_value[6] = cmb_upd_user_h.SelectedValue.ToString().Trim(); //upd_user
                arg_value[7] = txt_vendor_h.Text.Trim();                       //vendor
                arg_value[8] = txt_model_h.Text.Trim();                        //model

                DataTable dt_list = Select_import_offer_head(arg_value);

                if (dt_list.Rows.Count > 0)
                {
                    Display_Data(dt_list, fgrid_head);
                    ControlValueChange_by_GridClick(fgrid_head.Rows.Fixed);
                    Display_Grid_Tail(fgrid_head[fgrid_head.Rows.Fixed, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO].ToString());
                }
                else
                {
                    tbtn_New_Click(null, null); 
                }
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
        }

        private void Display_Data(DataTable arg_dt, C1FlexGrid arg_grid)
        {
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                arg_grid.Rows.Add();

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {
                    arg_grid[arg_grid.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                }

                string his_no = arg_grid[arg_grid.Rows.Count - 1, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxLC_NO].ToString();

                if (his_no.Equals("Rejection"))
                    arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO).StyleNew.ForeColor = Color.Red;
            }
        }

        private void Clear_control()
        {
            click_flg = true;

            txt_offer_no_tail.Clear();
            cmb_department.SelectedIndex = 0;
            dtp_order_date.Value = DateTime.Now;
            cmb_category_t.SelectedIndex = 0;
            cmb_season_t.SelectedIndex = 0;
            txt_model.Clear();
            txt_dev_cd.Clear();
            txt_vendor.Clear();
            txt_nike_dev.Clear();
            txt_cdc_dev.Clear();
            cmb_purpose.SelectedIndex = 0;
            txt_dhl_acc.Clear();
            txt_rta.Clear();
            txt_prod_code.Clear();
            txt_spl_ddd.Clear();
            txt_history_no.Clear();

            click_flg = false;

        }
        private DataTable Select_import_offer_head(string [] arg_value)
        {
            MyOraDB.ReDim_Parameter(10);

            MyOraDB.Process_Name = "pkg_sxp_pur_99_select.select_import_offer_head";

            MyOraDB.Parameter_Name[0] = "arg_offer_no";
            MyOraDB.Parameter_Name[1] = "arg_date_from";
            MyOraDB.Parameter_Name[2] = "arg_date_to";
            MyOraDB.Parameter_Name[3] = "arg_category";
            MyOraDB.Parameter_Name[4] = "arg_season";
            MyOraDB.Parameter_Name[5] = "arg_purpose";
            MyOraDB.Parameter_Name[6] = "arg_upd_user";
            MyOraDB.Parameter_Name[7] = "arg_vendor";
            MyOraDB.Parameter_Name[8] = "arg_model";
            MyOraDB.Parameter_Name[9] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = arg_value[6];
            MyOraDB.Parameter_Values[7] = arg_value[7];
            MyOraDB.Parameter_Values[8] = arg_value[8];
            MyOraDB.Parameter_Values[9] = "";
           
            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Data Save
        //Save
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int sct_row = fgrid_head.Selection.r1;
                int sct_col = fgrid_head.Selection.c1;
                fgrid_head.Select(sct_row, sct_col);
                fgrid_tail.Select(fgrid_tail.Selection.r1, fgrid_tail.Selection.c1);

                if (!Check_save())
                    return;

                #region Head Save
                string offer_no = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO);

                if (fgrid_head[sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "")
                {
                    string[] arg_value = new string[24];

                    arg_value[0] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV);         //arg_division   ,
                    arg_value[1] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO);    //arg_offer_no   
                    arg_value[2] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDEPT_CD);     //arg_dept_cd    
                    arg_value[3] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDEPT_NAME);   //arg_dept_name  
                    arg_value[4] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_DATE);  //arg_offer_date 
                    arg_value[5] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCATEGORY);    //arg_category   
                    arg_value[6] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxMODEL);       //arg_model      
                    arg_value[7] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDEV_CODE);    //arg_dev_code   
                    arg_value[8] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxSEASON);      //arg_season     
                    arg_value[9] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxPURPOSE);     //arg_purpose    
                    arg_value[10] = COM.ComVar.This_User;                                                                     //arg_upd_user   
                    arg_value[11] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxREMARK);     //arg_remark     
                    arg_value[12] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxLC_NO);      //arg_lc_no      
                    arg_value[13] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCUST_NAME);  //arg_cust_name  
                    arg_value[14] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxPROD_CODE);  //arg_prod_code
                    arg_value[15] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxNIKE_DEV);   //arg_nike_dev   
                    arg_value[16] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxSE_DIV);     //arg_se_div     
                    arg_value[17] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxPO);         //arg_po         
                    arg_value[18] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxVIA);        //arg_via        
                    arg_value[19] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxAMOUNT_CD);  //arg_amount_cd  
                    arg_value[20] = Set_empty_value(fgrid_head, sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCUST_CD);    //arg_cust_cd    
                    
                    
                    Save_sxz_import_offer_head(arg_value);
                    
                    if (fgrid_head[sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() == "I")
                        offer_no = Get_offer_no().Rows[0].ItemArray[0].ToString();
                }
                #endregion

                #region Tail Save

                for (int i = fgrid_tail.Rows.Fixed; i < fgrid_tail.Rows.Count; i++)
                {
                    if (fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxDIV].ToString() != "")
                    {                       

                        string[] arg_value = new string[19];

                        arg_value[0] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxDIV);        //arg_division"; 
                        arg_value[1] = offer_no;                                                                           //arg_offer_no"; 
                        arg_value[2] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxSEQ);        //arg_seq";      
                        arg_value[3] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxMAT_NAME);   //arg_mat_name"; 
                        arg_value[4] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCLR_CD);     //arg_clr_cd";   
                        arg_value[5] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCLR_NAME);   //arg_clr_name"; 
                        arg_value[6] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCOMP);       //arg_comp";     
                        arg_value[7] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxADDPROC);    //arg_addproc";  
                        arg_value[8] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxMTL);        //arg_mtl";      
                        arg_value[9] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxUNIT);       //arg_unit";
                        arg_value[10] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxQTY);       //arg_qty";      
                        arg_value[11] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxPRICE);     //arg_price";    
                        arg_value[12] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxMAT_CLASS); //arg_mat_class";
                        arg_value[13] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxRTA);       //arg_rta";      
                        arg_value[14] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxETS1);      //arg_pi_date";  
                        arg_value[15] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxTHICKNESS); //arg_ets2";     
                        arg_value[16] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxWIDTH);     //arg_ship_date";
                        arg_value[17] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxLENGTH);    //arg_arr_date"; 
                        arg_value[18] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxREMARKS);   //arg_leadtime"; 
                                 
                        Save_sxz_import_offer_tail(arg_value);
                    }
                }
                   
                #endregion

                tbtn_Search_Click(null, null);
                fgrid_head.Select(sct_row, sct_col);
                Display_Grid_Tail(offer_no);
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
            }

        }       
        //Delete
        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                for (int i = fgrid_head.Rows.Fixed; i < fgrid_head.Rows.Count; i++)
                {
                    string chk = fgrid_head[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK].ToString();
                    string ord_yn = fgrid_head[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxORD_YN].ToString();

                    if (chk.Equals("True") && ord_yn.Equals("False"))
                    {
                        string[] arg_value = new string[24];

                        arg_value[0] = "D"; //arg_division   
                        arg_value[1] = fgrid_head[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO].ToString();//arg_offer_no   
                        arg_value[2] = "";//arg_dept_cd    
                        arg_value[3] = "";//arg_dept_name  
                        arg_value[4] = "";//arg_offer_date 
                        arg_value[5] = "";//arg_category   
                        arg_value[6] = "";//arg_model      
                        arg_value[7] = "";//arg_dev_code   
                        arg_value[8] = "";//arg_season     
                        arg_value[9] = "";//arg_purpose    
                        arg_value[10] = "";//arg_upd_user   
                        arg_value[11] = "";//arg_remark     
                        arg_value[12] = "";//arg_lc_no      
                        arg_value[13] = "";//arg_cust_name  
                        arg_value[14] = "";//arg_imp_country
                        arg_value[15] = "";//arg_prod_code  
                        arg_value[16] = "";//arg_nike_dev   
                        arg_value[17] = "";//arg_se_div     
                        arg_value[18] = "";//arg_po         
                        arg_value[19] = "";//arg_via        
                        arg_value[20] = "";//arg_amount_cd  
                        arg_value[21] = "";//arg_cust_cd    
                        arg_value[22] = "";//arg_status     
                        arg_value[23] = "";//arg_factory     

                        Save_sxz_import_offer_head(arg_value);
                    }
                }

                tbtn_Search_Click(null, null);                
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndDelete, this); 
            }

        }
        //Rejection
        private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int sct_row = fgrid_head.Selection.r1;
                int sct_col = fgrid_head.Selection.c1;
                string offer_no = fgrid_head[sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO].ToString();

                for (int i = fgrid_head.Rows.Fixed; i < fgrid_head.Rows.Count; i++)
                {
                    string chk    = fgrid_head[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK].ToString();
                    string ord_yn = fgrid_head[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxORD_YN].ToString();

                    if (chk.Equals("True") && ord_yn.Equals("False"))
                    {
                        string arg_offer_no = fgrid_head[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO].ToString();
                        Save_sxz_import_offer_rejection(arg_offer_no);
                    }
                }

                tbtn_Search_Click(null, null);
                fgrid_head.Select(sct_row, sct_col);
                Display_Grid_Tail(offer_no);
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

        private bool Check_save()
        {
            if (fgrid_head.Rows.Count == fgrid_head.Rows.Fixed)
            {
                MessageBox.Show("Please Click Create Button");
                return false;
            }

            string dev_cd    = txt_dev_cd.Text.Trim();
            string vendor    = txt_vendor.Text.Trim();
            string model     = txt_model.Text.Trim();
            string cdc_dev   = txt_cdc_dev.Text.Trim();
            string prod_code = txt_prod_code.Text.Trim();
            string spl_ddd   = txt_spl_ddd.Text.Trim();

            if (dev_cd.Equals(""))
            {
                MessageBox.Show("Please input Dev Code");
                return false; 
            }
            if (vendor.Equals(""))
            {
                MessageBox.Show("Please input Vendor");
                return false;
            }
            if (model.Equals(""))
            {
                MessageBox.Show("Please input Model Name");
                return false;
            }
            if (cdc_dev.Equals(""))
            {
                MessageBox.Show("Please input CDC Dev");
                return false;
            }
            if (prod_code.Equals(""))
            {
                MessageBox.Show("Please input Prod. Code");
                return false;
            }
            if (spl_ddd.Equals(""))
            {
                MessageBox.Show("Please input SPL.DDD");
                return false;
            }


            for (int i = fgrid_tail.Rows.Fixed; i < fgrid_tail.Rows.Count; i++)
            {
                try
                {
                    double qty = Double.Parse(fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxQTY].ToString());
                }
                catch
                {
                    MessageBox.Show("Qty is wrong format");
                    fgrid_tail.Select(i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxQTY);
                    return false;
                }

                string mat_name   = (fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxMAT_NAME] == null) ? "" :fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxMAT_NAME].ToString().Trim();
                string color_code = (fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCLR_CD] == null) ? "" : fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCLR_CD].ToString().Trim();
                string color_name = (fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCLR_NAME] == null) ? "" : fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCLR_NAME].ToString().Trim();
                string comp       = (fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCOMP] == null) ? "" : fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCOMP].ToString().Trim();
                string unit       = (fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxUNIT] == null) ? "" : fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxUNIT].ToString().Trim();


                if (mat_name.Equals(""))
                {
                    MessageBox.Show("Please input Material Name");
                    return false; 
                }
                if (color_code.Equals(""))
                {
                    MessageBox.Show("Please input Color Code");
                    return false;
                }
                if (color_name.Equals(""))
                {
                    MessageBox.Show("Please input Color Name");
                    return false;
                }
                if (comp.Equals(""))
                {
                    MessageBox.Show("Please input Comp.");
                    return false;
                }
                if (unit.Equals(""))
                {
                    MessageBox.Show("Please input Unit");
                    return false;
                }

            }      
                 
            return true;
        }

        private string Set_empty_value(C1FlexGrid arg_grid, int arg_row, int arg_col)
        {
            string return_value = "";
            try
            {   
                return_value = (arg_grid[arg_row, arg_col] == null) ? "" : arg_grid[arg_row, arg_col].ToString().Trim();                
            }
            catch
            {
                return_value = ""; 
            }

            return return_value;
        }

        private DataTable Get_offer_no()
        {
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_sxp_pur_99_select.get_offer_no";

            MyOraDB.Parameter_Name[0] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private void Save_sxz_import_offer_head(string[] arg_value)
        {            
            MyOraDB.ReDim_Parameter(21);
            MyOraDB.Process_Name = "pkg_sxp_pur_99.update_sxz_import_offer_head";

            MyOraDB.Parameter_Name[0]  = "arg_division";
            MyOraDB.Parameter_Name[1]  = "arg_offer_no";
            MyOraDB.Parameter_Name[2]  = "arg_dept_cd";
            MyOraDB.Parameter_Name[3]  = "arg_dept_name";
            MyOraDB.Parameter_Name[4]  = "arg_offer_date";
            MyOraDB.Parameter_Name[5]  = "arg_category";
            MyOraDB.Parameter_Name[6]  = "arg_model";
            MyOraDB.Parameter_Name[7]  = "arg_dev_code";
            MyOraDB.Parameter_Name[8]  = "arg_season";
            MyOraDB.Parameter_Name[9]  = "arg_purpose";
            MyOraDB.Parameter_Name[10] = "arg_upd_user";
            MyOraDB.Parameter_Name[11] = "arg_remark";
            MyOraDB.Parameter_Name[12] = "arg_lc_no";
            MyOraDB.Parameter_Name[13] = "arg_cust_name";
            MyOraDB.Parameter_Name[14] = "arg_prod_code";
            MyOraDB.Parameter_Name[15] = "arg_nike_dev";
            MyOraDB.Parameter_Name[16] = "arg_se_div";
            MyOraDB.Parameter_Name[17] = "arg_po";
            MyOraDB.Parameter_Name[18] = "arg_via";
            MyOraDB.Parameter_Name[19] = "arg_amount_cd";
            MyOraDB.Parameter_Name[20] = "arg_cust_cd";            

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
            MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[20] = (int)OracleType.VarChar;
            
            MyOraDB.Parameter_Values[0] = arg_value[0]; 
            MyOraDB.Parameter_Values[1] = arg_value[1]; 
            MyOraDB.Parameter_Values[2] = arg_value[2]; 
            MyOraDB.Parameter_Values[3] = arg_value[3]; 
            MyOraDB.Parameter_Values[4] = arg_value[4]; 
            MyOraDB.Parameter_Values[5] = arg_value[5]; 
            MyOraDB.Parameter_Values[6] = arg_value[6]; 
            MyOraDB.Parameter_Values[7] = arg_value[7]; 
            MyOraDB.Parameter_Values[8] = arg_value[8]; 
            MyOraDB.Parameter_Values[9] = arg_value[9]; 
            MyOraDB.Parameter_Values[10] = arg_value[10];
            MyOraDB.Parameter_Values[11] = arg_value[11];
            MyOraDB.Parameter_Values[12] = arg_value[12];
            MyOraDB.Parameter_Values[13] = arg_value[13];
            MyOraDB.Parameter_Values[14] = arg_value[14];
            MyOraDB.Parameter_Values[15] = arg_value[15];
            MyOraDB.Parameter_Values[16] = arg_value[16];
            MyOraDB.Parameter_Values[17] = arg_value[17];
            MyOraDB.Parameter_Values[18] = arg_value[18];
            MyOraDB.Parameter_Values[19] = arg_value[19];
            MyOraDB.Parameter_Values[20] = arg_value[20];            
           
            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        private void Save_sxz_import_offer_tail(string[] arg_value)
        {
            MyOraDB.ReDim_Parameter(19);
            MyOraDB.Process_Name = "pkg_sxp_pur_99.update_sxz_import_offer_tail";

            MyOraDB.Parameter_Name[0]  = "arg_division"; 
            MyOraDB.Parameter_Name[1]  = "arg_offer_no"; 
            MyOraDB.Parameter_Name[2]  = "arg_seq";      
            MyOraDB.Parameter_Name[3]  = "arg_mat_name"; 
            MyOraDB.Parameter_Name[4]  = "arg_clr_cd";   
            MyOraDB.Parameter_Name[5]  = "arg_clr_name"; 
            MyOraDB.Parameter_Name[6]  = "arg_comp";     
            MyOraDB.Parameter_Name[7]  = "arg_addproc";  
            MyOraDB.Parameter_Name[8]  = "arg_mtl";      
            MyOraDB.Parameter_Name[9]  = "arg_unit";     
            MyOraDB.Parameter_Name[10] = "arg_qty";      
            MyOraDB.Parameter_Name[11] = "arg_price";    
            MyOraDB.Parameter_Name[12] = "arg_mat_class";
            MyOraDB.Parameter_Name[13] = "arg_rta";      
            MyOraDB.Parameter_Name[14] = "arg_pi_date";  
            MyOraDB.Parameter_Name[15] = "arg_ets2";     
            MyOraDB.Parameter_Name[16] = "arg_ship_date";
            MyOraDB.Parameter_Name[17] = "arg_arr_date"; 
            MyOraDB.Parameter_Name[18] = "arg_leadtime";                  

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

            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = arg_value[6];
            MyOraDB.Parameter_Values[7] = arg_value[7];
            MyOraDB.Parameter_Values[8] = arg_value[8];
            MyOraDB.Parameter_Values[9] = arg_value[9];
            MyOraDB.Parameter_Values[10] = arg_value[10];
            MyOraDB.Parameter_Values[11] = arg_value[11];
            MyOraDB.Parameter_Values[12] = arg_value[12];
            MyOraDB.Parameter_Values[13] = arg_value[13];
            MyOraDB.Parameter_Values[14] = arg_value[14];
            MyOraDB.Parameter_Values[15] = arg_value[15];
            MyOraDB.Parameter_Values[16] = arg_value[16];
            MyOraDB.Parameter_Values[17] = arg_value[17];
            MyOraDB.Parameter_Values[18] = arg_value[18];              

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        private void Save_sxz_import_offer_rejection(string arg_offer_no)
        {
            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = "pkg_sxp_pur_99.update_sxz_import_offer_rej";

            MyOraDB.Parameter_Name[0] = "arg_offer_no";
                        
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = arg_offer_no;
            
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

                for (int i = fgrid_head.Rows.Fixed; i < fgrid_head.Rows.Count; i++)
                {
                    string chk = fgrid_head[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK].ToString();

                    if (chk.Equals("True"))
                    {
                        string arg_offer_no = fgrid_head[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO].ToString();

                        Confirm_sxz_import_offer(arg_offer_no, "O");
                    }
                }

                tbtn_Search_Click(null, null);                
            }
            catch
            {
 
            }
        }
        private void Confirm_sxz_import_offer(string arg_offer_no, string arg_ord_yn)
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "pkg_sxp_pur_99.confirm_sxz_import_offer";

            MyOraDB.Parameter_Name[0] = "arg_offer_no";
            MyOraDB.Parameter_Name[1] = "arg_ord_yn";            

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = arg_offer_no;
            MyOraDB.Parameter_Values[1] = arg_ord_yn;            

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                int sct_row = fgrid_head.Selection.r1;
                int sct_col = fgrid_head.Selection.c1;

                string arg_offer_no  = fgrid_head[sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO].ToString();
                string arg_dept_cd   = fgrid_head[sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDEPT_CD].ToString();
                string arg_date_from = dtp_from.Value.ToString("yyyyMMdd");
                string arg_date_to   = dtp_to.Value.ToString("yyyyMMdd");

                Pop_Pur_List_PrintOption pop_print = new Pop_Pur_List_PrintOption("IMPORT", arg_offer_no, arg_dept_cd, arg_date_from, arg_date_to);                
                pop_print.ShowDialog();
            }
            catch
            {

            }
        }
        #endregion

        #region Label btn Event
        private void btn_vendor_Click(object sender, EventArgs e)
        {
            try
            {
                Pop_Import_Offer_Vendor vendor = new Pop_Import_Offer_Vendor();
                vendor.ShowDialog();

                if (vendor.save_flg)
                {
                    fgrid_head[fgrid_head.Selection.r1, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCUST_CD]   = vendor.ven_cd;
                    fgrid_head[fgrid_head.Selection.r1, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCUST_NAME] = vendor.ven_name;
                    txt_vendor.Text = vendor.ven_name;

                    if (fgrid_head[fgrid_head.Selection.r1, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                        fgrid_head[fgrid_head.Selection.r1, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                    fgrid_head[fgrid_head.Selection.r1, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
                }
                
            }
            catch
            {
 
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            fgrid_tail.Rows.Add();

            fgrid_tail[fgrid_tail.Rows.Count - 1, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxDIV] = "I";
            fgrid_tail[fgrid_tail.Rows.Count - 1, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCHK] = "False";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {           
            
            for (int i = fgrid_tail.Rows.Count - 1; i >= fgrid_tail.Rows.Fixed ; i--)
            {
                string chk =(fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCHK] == null) ? "False" :fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCHK].ToString();
                string div = fgrid_tail[i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxDIV].ToString();

                if (chk.Equals("True"))
                {
                    if (div.Equals("I"))
                    {
                        fgrid_tail.Rows.Remove(i);
                    }
                    else
                    {                        
                        string[] arg_value = new string[19];

                        arg_value[0] = "D";                                                                                //arg_division 
                        arg_value[1] = fgrid_head[fgrid_head.Selection.r1, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO].ToString();                                                                           //arg_offer_no 
                        arg_value[2] = Set_empty_value(fgrid_tail, i, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxSEQ);        //arg_seq      
                        arg_value[3] = "";
                        arg_value[4] = "";
                        arg_value[5] = "";
                        arg_value[6] = "";
                        arg_value[7] = "";
                        arg_value[8] = "";
                        arg_value[9] = "";
                        arg_value[10] = "";
                        arg_value[11] = "";
                        arg_value[12] = "";
                        arg_value[13] = "";
                        arg_value[14] = "";
                        arg_value[15] = "";
                        arg_value[16] = "";
                        arg_value[17] = "";
                        arg_value[18] = "";

                        Save_sxz_import_offer_tail(arg_value);
                        fgrid_tail.Rows.Remove(i);
                    }
                }                
            }
        }
        #endregion

        #endregion

        #region Grid Event
        private void fgrid_head_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (fgrid_head.Rows.Count == fgrid_head.Rows.Fixed)
                {
                    mnu_insert_head.Enabled = false;
                    return;
                }
                else
                {
                    mnu_insert_head.Enabled = true; 
                }

                int sct_row = fgrid_head.Selection.r1;
                
                string arg_offer_no = (fgrid_head[sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO] == null)?"":fgrid_head[sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO].ToString();
                string arg_ord_yn   = (fgrid_head[sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxORD_YN] == null) ? "False" : fgrid_head[sct_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxORD_YN].ToString();
                
                if (arg_offer_no.Equals(""))
                    fgrid_tail.Rows.Count = fgrid_tail.Rows.Fixed;
                                                
                ControlValueChange_by_GridClick(sct_row);
                Display_Grid_Tail(arg_offer_no);

                if (arg_ord_yn.Equals("True"))
                    Control_enable_setting(true);
                else
                    Control_enable_setting(false);

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
        
        private void fgrid_tail_Click(object sender, EventArgs e)
        {

        }
        private void fgrid_tail_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                if (fgrid_tail.Selection.c1 == (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxCHK)
                    return;

                if (fgrid_tail[fgrid_tail.Selection.r1, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxDIV].ToString() != "I")
                    fgrid_tail[fgrid_tail.Selection.r1, (int)ClassLib.TBSXZ_IMPORT_OFFER_TAIL.IxDIV] = "U";
            }
            catch
            {

            }
        }

        private void ControlValueChange_by_GridClick(int arg_row)
        {
            click_flg = true;

            txt_offer_no_tail.Text          = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_NO);
            cmb_department.SelectedValue    = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDEPT_CD);

            int offer_year  = int.Parse(fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_DATE].ToString().Substring(0, 4));
            int offer_month = int.Parse(fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_DATE].ToString().Substring(4, 2));
            int offer_day   = int.Parse(fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_DATE].ToString().Substring(6, 2));
            DateTime date = new DateTime(offer_year, offer_month, offer_day);
            dtp_order_date.Value            = date;
            
            cmb_category_t.SelectedValue    = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCATEGORY);
            cmb_season_t.SelectedValue      = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxSEASON);
            txt_model.Text                  = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxMODEL);
            txt_dev_cd.Text                 = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDEV_CODE);
            txt_vendor.Text                 = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCUST_NAME);
            txt_nike_dev.Text               = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxNIKE_DEV);
            txt_cdc_dev.Text                = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxSE_DIV);
            cmb_purpose.SelectedValue       = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxPURPOSE);
            txt_dhl_acc.Text                = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxVIA);
            txt_rta.Text                    = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxAMOUNT_CD);            
            txt_prod_code.Text              = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxPROD_CODE);
            txt_spl_ddd.Text                = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxREMARK);
            txt_history_no.Text             = Set_empty_value(fgrid_head, arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxLC_NO);
            
            click_flg = false;
        }

        private void Display_Grid_Tail(string arg_offer_no)
        {
            DataTable dt_list = Select_import_offer_tail(arg_offer_no);

            fgrid_tail.Rows.Count = fgrid_tail.Rows.Fixed;

            for (int i = 0; i < dt_list.Rows.Count; i++)
            {
                fgrid_tail.Rows.Add();

                for (int j = 0; j < dt_list.Columns.Count; j++)
                {
                    fgrid_tail[fgrid_tail.Rows.Count - 1, j] = dt_list.Rows[i].ItemArray[j].ToString();
                }
            }
        }

        private void Control_enable_setting(bool arg_ord)
        {
            if (arg_ord && (power_level.Substring(0, 1).Equals("D") || power_level.Equals("I01")))
            {
                cmb_department.Enabled = false;
                dtp_order_date.Enabled = false;
                cmb_category_t.Enabled = false;
                cmb_season_t.Enabled   = false;
                txt_model.Enabled      = false;
                txt_dev_cd.Enabled     = false;                
                txt_nike_dev.Enabled   = false;
                txt_cdc_dev.Enabled    = false;
                cmb_purpose.Enabled    = false;                
                txt_rta.Enabled        = false;
                txt_prod_code.Enabled  = false;
                txt_spl_ddd.Enabled    = false;

                //cmb_department.BackColor = SystemColors.Control;
                dtp_order_date.BackColor = SystemColors.Control;
                //cmb_category_t.BackColor = SystemColors.Control;
                //cmb_season_t.BackColor   = SystemColors.Control;
                txt_model.BackColor      = SystemColors.Control;
                txt_dev_cd.BackColor     = SystemColors.Control;
                txt_nike_dev.BackColor   = SystemColors.Control;
                txt_cdc_dev.BackColor    = SystemColors.Control;
                //cmb_purpose.BackColor    = SystemColors.Control;
                txt_rta.BackColor        = SystemColors.Control;
                txt_prod_code.BackColor  = SystemColors.Control;
                txt_spl_ddd.BackColor    = SystemColors.Control;

                btn_plus.Enabled   = false;
                btn_minus.Enabled  = false;
                btn_vendor.Enabled = false;

                fgrid_tail.Enabled = false;
                mnu_insert_tail.Enabled = false;
                
            }
            else
            {
                cmb_department.Enabled = true;
                dtp_order_date.Enabled = true;
                cmb_category_t.Enabled = true;
                cmb_season_t.Enabled   = true;
                txt_model.Enabled      = true;
                txt_dev_cd.Enabled     = true;                
                txt_nike_dev.Enabled   = true;
                txt_cdc_dev.Enabled    = true;
                cmb_purpose.Enabled    = true;
                txt_rta.Enabled        = true;
                txt_prod_code.Enabled  = true;
                txt_spl_ddd.Enabled    = true;                

                //cmb_department.BackColor = Color.White;
                dtp_order_date.BackColor = SystemColors.Window;
                //cmb_category_t.BackColor = Color.White;
                //cmb_season_t.BackColor   = Color.White;
                txt_model.BackColor      = SystemColors.Window;
                txt_dev_cd.BackColor     = SystemColors.Window;
                txt_nike_dev.BackColor   = SystemColors.Window;
                txt_cdc_dev.BackColor    = SystemColors.Window;
                //cmb_purpose.BackColor    = Color.White;
                txt_rta.BackColor        = SystemColors.Window;
                txt_prod_code.BackColor  = SystemColors.Window;
                txt_spl_ddd.BackColor    = SystemColors.Window;

                btn_plus.Enabled   = true;
                btn_minus.Enabled  = true;
                btn_vendor.Enabled = true;

                fgrid_tail.Enabled = true;
                mnu_insert_tail.Enabled = true;
            }
        }

        private DataTable Select_import_offer_tail(string arg_offer_no)
        {
            MyOraDB.ReDim_Parameter(2);

            MyOraDB.Process_Name = "pkg_sxp_pur_99_select.select_import_offer_tail";

            MyOraDB.Parameter_Name[0] = "arg_offer_no";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_offer_no;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name]; 
        }
        #endregion

        #region Control Value Change Event
        private void cmb_department_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = cmb_department.SelectedValue.ToString();
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDEPT_CD;

                if (arg_value.Equals("000001"))
                {//CDC
                    txt_dhl_acc.Text = "961306030"; 
                }
                if (arg_value.Equals("000002"))
                {//SHC
                    txt_dhl_acc.Text = "968977514";
                }
                if (arg_value.Equals("000003"))
                {//QD
                    txt_dhl_acc.Text = "967145051";
                }
                if (arg_value.Equals("000004"))
                {//VJ
                    txt_dhl_acc.Text = "964866108";
                }

                fgrid_head[arg_row, arg_col] = arg_value;

                arg_value = cmb_department.Text;
                arg_row = fgrid_head.Selection.r1;
                arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDEPT_NAME;

                fgrid_head[arg_row, arg_col] = arg_value;
                if(fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {
 
            }

        }

        private void dtp_order_date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = dtp_order_date.Value.ToString("yyyyMMdd");
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxOFFER_DATE;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }

        private void cmb_category_t_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = cmb_category_t.SelectedValue.ToString();
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCATEGORY;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }

        private void cmb_season_t_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = cmb_season_t.SelectedValue.ToString();
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxSEASON;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }

        private void txt_model_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = txt_model.Text;
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxMODEL;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }

        private void txt_dev_cd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = txt_dev_cd.Text;
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDEV_CODE;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }

        private void txt_nike_dev_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = txt_nike_dev.Text;
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxNIKE_DEV;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }

        private void txt_cdc_dev_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = txt_cdc_dev.Text;
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxSE_DIV;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }

        private void cmb_purpose_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = cmb_purpose.SelectedValue.ToString();
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxPURPOSE;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }

        private void txt_dhl_acc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = txt_dhl_acc.Text;
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxVIA;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }

        private void txt_rta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = txt_rta.Text;
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxAMOUNT_CD;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }

        private void txt_prod_code_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = txt_prod_code.Text;
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxPROD_CODE;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }

        private void txt_spl_ddd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = txt_spl_ddd.Text;
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxREMARK;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }

        private void txt_history_no_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (click_flg) return;

                string arg_value = txt_history_no.Text;
                int arg_row = fgrid_head.Selection.r1;
                int arg_col = (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxLC_NO;

                fgrid_head[arg_row, arg_col] = arg_value;
                if (fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV].ToString() != "I")
                    fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxDIV] = "U";
                fgrid_head[arg_row, (int)ClassLib.TBSXZ_IMPORT_OFFER_HEAD.IxCHK] = "True";
            }
            catch
            {

            }
        }
        #endregion

    }
}


