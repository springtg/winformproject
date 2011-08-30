using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.IO;


namespace FlexCDC.Purchase
{
    public partial class Form_Pur_Request : COM.PCHWinForm.Form_Top
    {
        #region User Define Variabke
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService Connection
        private bool click_flg = false;
        private bool size_flg = false;
        private bool chk_flg = false;

        private Hashtable Imgmap = new Hashtable();
        #endregion

        #region Resource
        public Form_Pur_Request()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Pur_Request_Load(object sender, EventArgs e)
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
            finally
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
            this.Text = "PCC_Request for Purchasing";
            this.lbl_MainTitle.Text = "PCC_Request for Purchasing";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting 
            dtp_from.Value = DateTime.Now;
            dtp_to.Value   = DateTime.Now;

            //Category
            DataTable dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxCDC_Category);            
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category_t, 1, 2, false, 0, 200);            
            cmb_category_t.SelectedIndex = -1;

            //Season
            dt_ret = SELECT_SEASON();            
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_t, 0, 1, false, 0, 200);            
            cmb_season_t.SelectedIndex = -1;

            //Round
            dt_ret = SELECT_ROUND();            
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 2, false, 0, 200);            
            cmb_round.SelectedIndex = -1;

            //Department
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), "SXP17");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_req_dept, 1, 2, false, 0, 200);

            //User
            string _power_lev = COM.ComVar.This_CDCPower_Level;

            if (_power_lev.Equals("S00"))// || _power_lev.Substring(0, 1).Equals("P"))
            {
                dt_ret = SELECT_USER();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, 0, 200);
                cmb_user.SelectedIndex = 0;

                tbtn_Create.Enabled = true;
                cmb_req_dept.SelectedValue = "000005";
            }
            else
            {
                cmb_user.Enabled = false;

                DataTable user_datatable = new DataTable("UserList");
                DataRow newrow;

                user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                newrow = user_datatable.NewRow();
                newrow["Code"] = ClassLib.ComVar.This_User;
                newrow["Name"] = ClassLib.ComVar.This_User;

                user_datatable.Rows.Add(newrow);
                ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_user, 0, 0, false, 0, 200);
                cmb_user.SelectedValue = ClassLib.ComVar.This_User;

                tbtn_Create.Enabled = false;               
            }                     
            #endregion

            #region Grid Setting 
            fgrid_top.Set_Grid_CDC("SXP_PUR_REQUEST_HEAD", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_top.Set_Action_Image(img_Action);
            fgrid_top.AllowDragging = AllowDraggingEnum.None;
            fgrid_top.AllowSorting  = AllowSortingEnum.None;
            fgrid_top.ExtendLastCol = false;

            fgrid_detail.Set_Grid_CDC("SXP_PUR_REQUEST_TAIL", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_detail.Set_Action_Image(img_Action);
            fgrid_detail.AllowDragging = AllowDraggingEnum.None;
            fgrid_detail.AllowSorting  = AllowSortingEnum.None;
            fgrid_detail.ExtendLastCol = false;
            #endregion

            #region Control Setting
            tbtn_New.Enabled     = true;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = true;
            tbtn_Print.Enabled   = false;
            tbtn_Confirm.Enabled = true;

            if (COM.ComVar.This_Factory.Equals("DS"))
                tbtn_Create.Enabled = false;
            else
            {
                string power_level = COM.ComVar.This_CDCPower_Level.Substring(0, 1);

                if(power_level.Equals("S") || power_level.Equals("P"))
                    tbtn_Create.Enabled = true;
                else
                    tbtn_Create.Enabled = false;
            }
                        
            txt_bom_id_t.CharacterCasing   = CharacterCasing.Upper;
            txt_dev_name.CharacterCasing   = CharacterCasing.Upper;
            txt_dhl_acc.CharacterCasing    = CharacterCasing.Upper;
            txt_rta.CharacterCasing        = CharacterCasing.Upper;
            txt_spl_ddd.CharacterCasing    = CharacterCasing.Upper;
            txt_srf_no.CharacterCasing     = CharacterCasing.Upper;
            
            lbl_save.BackColor    = Color.White;
            lbl_sub_cfm.BackColor = Color.LightYellow;
            lbl_confirm.BackColor = Color.Bisque;
            #endregion            
        }
        private DataTable SELECT_SEASON()
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable SELECT_ROUND()
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXB_NF_DESC";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private DataTable SELECT_USER()
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.SELECT_REQ_USER";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Create Data
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                fgrid_top.Rows.Count = fgrid_top.Rows.Fixed;
                fgrid_detail.Rows.Count = fgrid_detail.Rows.Fixed;
                fgrid_detail.AllowEditing = true;

                fgrid_top.Rows.Add();
                fgrid_top.Select(fgrid_top.Rows.Fixed, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME);

                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV]         = "I";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxFACTORY]     = cmb_factory.SelectedValue.ToString();
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_NO]      = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_YMD]     = DateTime.Now.ToString("yyyyMMdd");
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_DEPT]    = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_USER]    = COM.ComVar.This_User;
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY]    = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON_CD]   = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON]      = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSRF_NO]      = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID]      = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_CD]    = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME]  = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxNF_CD]       = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxWHQ_DEV]     = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCDC_DEV]     = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDHL_ACCOUNT] = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD]     = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD] = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxMRP_NO]      = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxLOT_NO]      = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxLOT_SEQ]     = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREMARKS]     = "";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTATUS]      = "N";
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxUPD_USER]    = COM.ComVar.This_User;
                fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxUPD_YMD]     = "";

                click_flg = true;

                int sct_row = fgrid_top.Selection.r1;

                cmb_req_dept.SelectedValue   = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_DEPT]    == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_DEPT].ToString().Trim();
                cmb_category_t.SelectedValue = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY]    == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY].ToString().Trim();
                cmb_season_t.SelectedValue   = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON_CD]   == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON_CD].ToString().Trim();
                txt_srf_no.Text              = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSRF_NO]      == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSRF_NO].ToString().Trim();
                txt_bom_id_t.Text            = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID]      == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID].ToString().Trim();
                txt_style_cd_t.Text          = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_CD]    == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_CD].ToString().Trim();
                txt_dev_name.Text            = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME]  == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME].ToString().Trim();
                cmb_round.SelectedValue      = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxNF_CD]       == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxNF_CD].ToString().Trim();
                txt_nike_dev.Text            = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxWHQ_DEV]     == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxWHQ_DEV].ToString().Trim();
                txt_cdc_dev.Text             = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCDC_DEV]     == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCDC_DEV].ToString().Trim();
                txt_dhl_acc.Text             = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDHL_ACCOUNT] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDHL_ACCOUNT].ToString().Trim();
                txt_rta.Text                 = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD]     == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD].ToString().Trim();
                txt_spl_ddd.Text             = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD].ToString().Trim();
                
                click_flg = false;       
         
                cmb_req_dept.Enabled   = true;
                cmb_category_t.Enabled = true;
                cmb_season_t.Enabled   = true;
                txt_srf_no.Enabled     = true;
                txt_bom_id_t.Enabled   = true;
                txt_style_cd_t.Enabled = true;
                txt_dev_name.Enabled   = true;
                cmb_round.Enabled      = true;
                txt_nike_dev.Enabled   = true;
                txt_cdc_dev.Enabled    = true;
                txt_dhl_acc.Enabled    = true;
                txt_rta.Enabled        = true;
                txt_spl_ddd.Enabled    = true;

                btn_plus.Enabled  = true;
                btn_minus.Enabled = true;

                fgrid_detail.Enabled = true;
            }
            catch
            {

            }
            finally
            {
 
            }
        }
        private void btn_select_bom_Click(object sender, EventArgs e)
        {
            try
            {                
                Pop_Pur_Request pop_req = new Pop_Pur_Request(this);
                pop_req.ShowDialog();

                if(pop_req.save_flg)
                {
                    fgrid_top.Select(fgrid_top.Rows.Fixed, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME);

                    click_flg = true;

                    int sct_row = fgrid_top.Selection.r1;
                    cmb_req_dept.SelectedValue   = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_DEPT]    == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_DEPT].ToString().Trim();
                    cmb_category_t.SelectedValue = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY]    == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY].ToString().Trim();
                    cmb_season_t.SelectedValue   = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON_CD]   == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON_CD].ToString().Trim();
                    txt_srf_no.Text              = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSRF_NO]      == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSRF_NO].ToString().Trim();
                    txt_bom_id_t.Text            = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID]      == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID].ToString().Trim();
                    txt_style_cd_t.Text          = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_CD]    == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_CD].ToString().Trim();
                    txt_dev_name.Text            = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME]  == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME].ToString().Trim();
                    cmb_round.SelectedValue      = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxNF_CD]       == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxNF_CD].ToString().Trim();
                    txt_nike_dev.Text            = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxWHQ_DEV]     == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxWHQ_DEV].ToString().Trim();
                    txt_cdc_dev.Text             = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCDC_DEV]     == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCDC_DEV].ToString().Trim();
                    txt_dhl_acc.Text             = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDHL_ACCOUNT] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDHL_ACCOUNT].ToString().Trim();
                    txt_rta.Text                 = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD]     == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD].ToString().Trim();
                    txt_spl_ddd.Text             = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD].ToString().Trim();
                    
                    click_flg = false;       
             
                    cmb_req_dept.Enabled   = true;
                    cmb_category_t.Enabled = true;
                    cmb_season_t.Enabled   = true;
                    txt_srf_no.Enabled     = true;
                    txt_bom_id_t.Enabled   = true;
                    txt_style_cd_t.Enabled = true;
                    txt_dev_name.Enabled   = true;
                    cmb_round.Enabled      = true;
                    txt_nike_dev.Enabled   = true;
                    txt_cdc_dev.Enabled    = true;
                    txt_dhl_acc.Enabled    = true;
                    txt_rta.Enabled        = true;
                    txt_spl_ddd.Enabled    = true;

                    btn_plus.Enabled  = true;
                    btn_minus.Enabled = true;

                    fgrid_detail.AllowEditing = true;
                }                
            }
            catch
            {

            }
            finally
            {
 
            }
        }

        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                fgrid_top.Rows.Count = fgrid_top.Rows.Fixed;
                fgrid_detail.Rows.Count = fgrid_detail.Rows.Fixed;

                string[] arg_value = new string[5];
                arg_value[0] = cmb_factory.SelectedValue.ToString();
                arg_value[1] = dtp_from.Value.ToString("yyyyMMdd");
                arg_value[2] = dtp_to.Value.ToString("yyyyMMdd");
                arg_value[3] = cmb_user.SelectedValue.ToString();
                arg_value[4] = (chk_status.Checked) ? "X" : "";
                
                DataTable dt_ret = SELECT_PUR_REQUEST_HEAD(arg_value);

                if (dt_ret.Rows.Count > 0)
                {
                    Display_Grid_Head(dt_ret);

                    Checkbox_Event();
                    fgrid_top.Select(fgrid_top.Rows.Fixed, 2);
                    fgrid_top_Click(null, null);
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
        private DataTable SELECT_PUR_REQUEST_HEAD(string [] arg_value)
        {
            MyOraDB.ReDim_Parameter(6);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.SELECT_REQ_HEAD_01";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_DATE_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_DATE_TO";
            MyOraDB.Parameter_Name[3] = "ARG_REQ_USER";
            MyOraDB.Parameter_Name[4] = "ARG_STATUS";
            MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private void Display_Grid_Head(DataTable arg_dt)
        {
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                fgrid_top.Rows.Add();

                for (int j = fgrid_top.Cols.Fixed; j < fgrid_top.Cols.Count; j++)
                {
                    fgrid_top[fgrid_top.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();                    
                }

                string _status = fgrid_top[fgrid_top.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTATUS].ToString().Trim();

                if(_status.Equals("N"))
                    fgrid_top.Rows[fgrid_top.Rows.Count - 1].StyleNew.BackColor = Color.White;
                else if (_status.Equals("Y"))
                    fgrid_top.Rows[fgrid_top.Rows.Count - 1].StyleNew.BackColor = Color.LightYellow;
                else if (_status.Equals("C"))
                    fgrid_top.Rows[fgrid_top.Rows.Count - 1].StyleNew.BackColor = Color.Bisque;
            }
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int sct_row     = fgrid_detail.Selection.r1;
                int sct_col     = fgrid_detail.Selection.c1;

                int sct_row_top = fgrid_top.Selection.r1;
                fgrid_detail.Select(sct_row, sct_col);
                
                string _div = fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Trim();
                string _req_no = "";
                
                if (_div.Equals("I"))
                    _req_no = GET_REQ_NO().Rows[0].ItemArray[0].ToString();
                else
                    _req_no = fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_NO].ToString().Trim();

                if (CHECK_REQ_HEAD())
                {
                    if (CHECK_REQ_TAIL())
                    {
                        if (SAVE_REQUEST(_req_no))
                        {
                            MessageBox.Show("Save Completed, \r\n\r\nPlease Confirm Data.");

                            tbtn_Search_Click(null, null);
                            fgrid_top.Select(sct_row_top, sct_col);
                            fgrid_top_Click(null, null);
                        } 
                    }                    
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

        private bool CHECK_REQ_HEAD()
        {
            try
            {
                int sct_row = fgrid_top.Selection.r1;

                string srf_no   = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSRF_NO]      == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSRF_NO].ToString().Trim();
                string bom_id   = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID]      == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID].ToString().Trim();
                string style_cd = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_CD]    == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_CD].ToString().Trim();
                string rta_ymd  = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD]     == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD].ToString().Trim();
                string spl_ddd  = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD].ToString().Trim();

                string dept     = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_DEPT] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_DEPT].ToString().Trim();
                string category = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY].ToString().Trim();
                string season   = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON_CD] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON_CD].ToString().Trim();
                string round    = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxNF_CD] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxNF_CD].ToString().Trim();
                string model    = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME].ToString().Trim();


                if (dept.Equals(""))
                {
                    MessageBox.Show("Input Error : Department is empty.");
                    fgrid_detail.Select(sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_DEPT);
                    cmb_req_dept.Focus();
                    return false; 
                }
                if (category.Equals(""))
                {
                    MessageBox.Show("Input Error : Category is empty.");
                    fgrid_detail.Select(sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY);
                    cmb_category_t.Focus();
                    return false; 
                }
                if (season.Equals(""))
                {
                    MessageBox.Show("Input Error : Season is empty.");
                    fgrid_detail.Select(sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON);
                    cmb_season_t.Focus();
                    return false; 
                }
                if (round.Equals(""))
                {
                    MessageBox.Show("Input Error : Round is empty.");
                    fgrid_detail.Select(sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxNF_CD);
                    cmb_round.Focus();
                    return false; 
                }

                if (model.Equals(""))
                {
                    MessageBox.Show("Input Error : Model Name is empty.");
                    fgrid_detail.Select(sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME);
                    txt_dev_name.Focus();
                    return false;
                }

                if (srf_no.Length > 20)
                {
                    MessageBox.Show("Input Error : SRF No data length is too long.");
                    fgrid_detail.Select(sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSRF_NO);
                    txt_srf_no.Focus();
                    return false;
                }

                if (bom_id.Length > 17)
                {
                    MessageBox.Show("Input Error : BOM ID data length is too long.");
                    fgrid_detail.Select(sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID);
                    txt_bom_id_t.Focus();
                    return false;
                }

                if (style_cd.Length != 9 && !style_cd.Equals(""))
                {
                    MessageBox.Show("Input Error : Style Code data length is too long.");
                    fgrid_detail.Select(sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_CD);
                    txt_style_cd_t.Focus();
                    return false;
                }

                if (rta_ymd.Length.Equals(8))
                {
                    try
                    {
                        int year  = int.Parse(rta_ymd.Substring(0, 4));
                        int month = int.Parse(rta_ymd.Substring(4, 2));
                        int day   = int.Parse(rta_ymd.Substring(6, 2));

                        DateTime dt = new DateTime(year, month, day);
                    }
                    catch
                    {
                        MessageBox.Show("Input Error : RTA is wrong format.\r\n\r\nFormat : YYYYMMDD (ex. 20090908)");
                        fgrid_detail.Select(sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD);
                        txt_rta.Focus();
                        return false; 
                    }
                }
                else if (!rta_ymd.Equals(""))
                {
                    MessageBox.Show("Input Error : RTA is wrong format.\r\n\r\nFormat : YYYYMMDD (ex. 20090908)");
                    fgrid_detail.Select(sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD);
                    txt_rta.Focus();
                    return false;
                }

                if (spl_ddd.Length.Equals(8))
                {
                    try
                    {
                        int year  = int.Parse(spl_ddd.Substring(0, 4));
                        int month = int.Parse(spl_ddd.Substring(4, 2));
                        int day   = int.Parse(spl_ddd.Substring(6, 2));

                        DateTime dt = new DateTime(year, month, day);
                    }
                    catch
                    {
                        MessageBox.Show("Input Error : SPL DDD is wrong format.");
                        fgrid_detail.Select(sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD);
                        txt_spl_ddd.Focus();
                        return false;
                    }
                }
                else if (!spl_ddd.Equals(""))
                {
                    MessageBox.Show("Input Error : SPL DDD is wrong format.");
                    fgrid_detail.Select(sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD);
                    txt_spl_ddd.Focus();
                    return false;
                }

                return true;
            }
            catch
            {
                return false; 
            }
 
        }
        private bool CHECK_REQ_TAIL()
        {
            try
            {

                if (fgrid_detail.Rows.Count == fgrid_detail.Rows.Fixed)
                {
                    MessageBox.Show("Input Error : Material Data is Empty.");                    
                    return false;  
                }

                for (int i = fgrid_detail.Rows.Fixed; i < fgrid_detail.Rows.Count; i++)
                {
                    string part_name = (fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC].ToString().Trim();
                    string mat_cd    = (fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CD] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CD].ToString().Trim();
                    string mat_name  = (fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_NAME] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_NAME].ToString().Trim();
                    string color_cd  = (fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_CD] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_CD].ToString().Trim();
                    string unit_cd   = (fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_UNIT_CD] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_UNIT_CD].ToString().Trim();
                    string spec_cd   = (fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_SPEC_CD] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_SPEC_CD].ToString().Trim();
                    string pur_div   = (fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPUR_DIV] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPUR_DIV].ToString().Trim();
                    string ven_seq   = (fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVEN_SEQ] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVEN_SEQ].ToString().Trim();
                    string vendor    = (fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVENDOR] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVENDOR].ToString().Trim();
                    string qty       = (fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVALUE_REQ] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVALUE_REQ].ToString().Trim();

                    string rta_ymd   = (fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxRTA_YMD] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxRTA_YMD].ToString().Trim();
                    string ets_ymd   = (fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxETS_YMD] == null) ? "" : fgrid_detail[i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxETS_YMD].ToString().Trim();

                    if (part_name.Equals(""))
                    {
                        MessageBox.Show("Input Error : Please insert Part Name information.");
                        fgrid_detail.Select(i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC);
                        return false;
                    }
                    if (mat_cd.Equals("") || mat_name.Equals(""))
                    {
                        MessageBox.Show("Input Error : Please insert Material information.");
                        fgrid_detail.Select(i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_NAME);
                        return false;
                    }
                    if (color_cd.Equals(""))
                    {
                        MessageBox.Show("Input Error : Please insert Color information.");
                        fgrid_detail.Select(i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_CD);
                        return false;
                    }
                    if (unit_cd.Equals("") || spec_cd.Equals(""))
                    {
                        MessageBox.Show("Input Error : Please insert Unit/Spec information.");
                        fgrid_detail.Select(i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_SPEC_CD);
                        return false;
                    }
                    if (pur_div.Equals(""))
                    {
                        MessageBox.Show("Input Error : Please insert Purchase Division information.");
                        fgrid_detail.Select(i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPUR_DIV);
                        return false;
                    }

                    try
                    {
                        if (qty.Equals(""))
                        {
                            MessageBox.Show("Input Error : Please insert Qty information.");
                            fgrid_detail.Select(i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVALUE_REQ);
                            return false;
                        }

                        double.Parse(qty);
                    }
                    catch
                    {
                        MessageBox.Show("Input Error : Qty is wrong format.");
                        fgrid_detail.Select(i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVALUE_REQ);
                        return false;
                    }
                    //if (ven_seq.Equals("") || vendor.Equals(""))
                    //{
                    //    MessageBox.Show("Input Error : Please insert Vendor information.");
                    //    fgrid_detail.Select(i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVENDOR);
                    //    return false;
                    //}
                    if (rta_ymd.Length.Equals(8))
                    {
                        try
                        {
                            int year  = int.Parse(rta_ymd.Substring(0, 4));
                            int month = int.Parse(rta_ymd.Substring(4, 2));
                            int day   = int.Parse(rta_ymd.Substring(6, 2));

                            DateTime dt = new DateTime(year, month, day);
                        }
                        catch
                        {
                            MessageBox.Show("Input Error : RTA is wrong format.");
                            fgrid_detail.Select(i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxRTA_YMD);
                            return false; 
                        }
                    }
                    else if (!rta_ymd.Equals(""))
                    {
                        MessageBox.Show("Input Error : RTA is wrong format.");
                        fgrid_detail.Select(i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxRTA_YMD);
                        return false;
                    }

                    if (ets_ymd.Length.Equals(8))
                    {
                        try
                        {
                            int year  = int.Parse(ets_ymd.Substring(0, 4));
                            int month = int.Parse(ets_ymd.Substring(4, 2));
                            int day   = int.Parse(ets_ymd.Substring(6, 2));

                            DateTime dt = new DateTime(year, month, day);
                        }
                        catch
                        {
                            MessageBox.Show("Input Error : ETS is wrong format.");
                            fgrid_detail.Select(i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxETS_YMD);
                            return false;
                        }
                    }
                    else if (!ets_ymd.Equals(""))
                    {
                        MessageBox.Show("Input Error : ETS is wrong format.");
                        fgrid_detail.Select(i, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxETS_YMD);
                        return false;
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }    

        private bool SAVE_REQUEST(string arg_req_no)
        {
            try
            {
                MyOraDB.ReDim_Parameter(22);
                MyOraDB.Process_Name = "PKG_SXP_REQ_01.SAVE_SXP_REQ_HEAD";

                MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2]  = "ARG_REQ_NO";
                MyOraDB.Parameter_Name[3]  = "ARG_REQ_DEPT";
                MyOraDB.Parameter_Name[4]  = "ARG_REQ_USER";
                MyOraDB.Parameter_Name[5]  = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[6]  = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[7]  = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[8]  = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[9]  = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[10] = "ARG_STYLE_NAME";
                MyOraDB.Parameter_Name[11] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[12] = "ARG_WHQ_DEV";
                MyOraDB.Parameter_Name[13] = "ARG_CDC_DEV";
                MyOraDB.Parameter_Name[14] = "ARG_DHL_ACCOUNT";
                MyOraDB.Parameter_Name[15] = "ARG_RTA_YMD";
                MyOraDB.Parameter_Name[16] = "ARG_SPL_DDD_YMD";
                MyOraDB.Parameter_Name[17] = "ARG_MRP_NO";
                MyOraDB.Parameter_Name[18] = "ARG_LOT_NO";
                MyOraDB.Parameter_Name[19] = "ARG_LOT_SEQ";
                MyOraDB.Parameter_Name[20] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[21] = "ARG_UPD_USER";


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
                MyOraDB.Parameter_Type[21] = (int)OracleType.VarChar;
                

                MyOraDB.Parameter_Values = new string[22];

                MyOraDB.Parameter_Values[0]  = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV]         == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Trim();
                MyOraDB.Parameter_Values[1]  = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxFACTORY]     == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxFACTORY].ToString().Trim();
                MyOraDB.Parameter_Values[2]  = arg_req_no;
                MyOraDB.Parameter_Values[3]  = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_DEPT]    == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_DEPT].ToString().Trim();
                MyOraDB.Parameter_Values[4]  = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_USER]    == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_USER].ToString().Trim();
                MyOraDB.Parameter_Values[5]  = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY]    == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY].ToString().Trim();
                MyOraDB.Parameter_Values[6]  = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON_CD]   == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON_CD].ToString().Trim();
                MyOraDB.Parameter_Values[7]  = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSRF_NO]      == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSRF_NO].ToString().Trim();
                MyOraDB.Parameter_Values[8]  = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID]      == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID].ToString().Trim();
                MyOraDB.Parameter_Values[9]  = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_CD]    == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_CD].ToString().Trim();
                MyOraDB.Parameter_Values[10] = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME]  == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME].ToString().Trim();
                MyOraDB.Parameter_Values[11] = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxNF_CD]       == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxNF_CD].ToString().Trim();
                MyOraDB.Parameter_Values[12] = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxWHQ_DEV]     == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxWHQ_DEV].ToString().Trim();
                MyOraDB.Parameter_Values[13] = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCDC_DEV]     == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCDC_DEV].ToString().Trim();


                string dhl_accnt = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDHL_ACCOUNT] == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDHL_ACCOUNT].ToString().Trim();
                if (dhl_accnt.Equals(""))
                {
                    string dept = (cmb_req_dept.SelectedValue == null) ? "000001" : cmb_req_dept.SelectedValue.ToString();

                    if (dept.Equals("000001")) // CDC                    
                        dhl_accnt = "961306030";
                    else if (dept.Equals("000002")) // SHC
                        dhl_accnt = "968977514";
                    else if (dept.Equals("000003")) // QD
                        dhl_accnt = "967145051";
                    else if (dept.Equals("000004")) //VJ
                        dhl_accnt = "964866108"; 
                }

                MyOraDB.Parameter_Values[14] = dhl_accnt;                                
                MyOraDB.Parameter_Values[15] = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD]     == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD].ToString().Trim();
                MyOraDB.Parameter_Values[16] = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD] == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD].ToString().Trim();
                MyOraDB.Parameter_Values[17] = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxMRP_NO]      == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxMRP_NO].ToString().Trim();
                MyOraDB.Parameter_Values[18] = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxLOT_NO]      == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxLOT_NO].ToString().Trim();
                MyOraDB.Parameter_Values[19] = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxLOT_SEQ]     == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxLOT_SEQ].ToString().Trim();
                MyOraDB.Parameter_Values[20] = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREMARKS]     == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREMARKS].ToString().Trim();
                MyOraDB.Parameter_Values[21] = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxUPD_USER]    == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxUPD_USER].ToString().Trim();
                
                MyOraDB.Add_Modify_Parameter(true);
                
                int vcnt = 23;             

                MyOraDB.ReDim_Parameter(vcnt);
                MyOraDB.Process_Name = "PKG_SXP_REQ_01.SAVE_SXP_REQ_TAIL_01";

                MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2]  = "ARG_REQ_NO";
                MyOraDB.Parameter_Name[3]  = "ARG_REQ_SEQ";
                MyOraDB.Parameter_Name[4]  = "ARG_RTA_YMD";
                MyOraDB.Parameter_Name[5]  = "ARG_ETS_YMD";
                MyOraDB.Parameter_Name[6]  = "ARG_PART_NO";
                MyOraDB.Parameter_Name[7]  = "ARG_PART_DESC";
                MyOraDB.Parameter_Name[8]  = "ARG_MAT_CLASS";
                MyOraDB.Parameter_Name[9]  = "ARG_MAT_CD";
                MyOraDB.Parameter_Name[10] = "ARG_MAT_NAME";
                MyOraDB.Parameter_Name[11] = "ARG_MAT_COMMENT";
                MyOraDB.Parameter_Name[12] = "ARG_PCC_SPEC_CD";
                MyOraDB.Parameter_Name[13] = "ARG_COLOR_CD";
                MyOraDB.Parameter_Name[14] = "ARG_COLOR_COMMENT";
                MyOraDB.Parameter_Name[15] = "ARG_PCC_UNIT_CD";
                MyOraDB.Parameter_Name[16] = "ARG_VALUE_REQ";
                MyOraDB.Parameter_Name[17] = "ARG_VEN_SEQ";
                MyOraDB.Parameter_Name[18] = "ARG_PUR_DIV";
                MyOraDB.Parameter_Name[19] = "ARG_MAT_SUB_FLG";
                MyOraDB.Parameter_Name[20] = "ARG_SIZE_CD";
                MyOraDB.Parameter_Name[21] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[22] = "ARG_UPD_USER";

                for (int para = 0; para < vcnt; para++)
                {
                    MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
                }
                
                int vRow = 0;
                for (int i = fgrid_detail.Rows.Fixed; i < fgrid_detail.Rows.Count; i++)
                {
                    string _div = fgrid_detail[i, (int)ClassLib.TBSXP_PUR_MANAGER_NEW.IxDIV].ToString().Trim();

                    if (!_div.Equals(""))
                    {                            
                        vRow++;                      
                    }
                }

                vcnt = vcnt * vRow;
                MyOraDB.Parameter_Values = new string[vcnt];
                vcnt = 0;

                for (int row = fgrid_detail.Rows.Fixed; row < fgrid_detail.Rows.Count; row++)
                {
                    string _div = fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxDIV].ToString().Trim();

                    if (_div.Equals(""))
                        continue;

                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxDIV]           == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxDIV].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxFACTORY]       == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxFACTORY].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = arg_req_no;
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREQ_SEQ]       == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREQ_SEQ].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxRTA_YMD]       == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxRTA_YMD].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxETS_YMD]       == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxETS_YMD].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_NO]       == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_NO].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC]     == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CLASS]     == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CLASS].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CD]        == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CD].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_NAME]      == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_NAME].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_COMMENT]   == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_COMMENT].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_SPEC_CD]   == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_SPEC_CD].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_CD]      == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_CD].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_COMMENT] == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_COMMENT].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_UNIT_CD]   == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_UNIT_CD].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVALUE_REQ]     == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVALUE_REQ].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVEN_SEQ]       == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVEN_SEQ].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPUR_DIV]       == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPUR_DIV].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_SUB_FLG]   == null) ? "N" : (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_SUB_FLG].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSIZE_CD]       == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSIZE_CD].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREMARKS]       == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREMARKS].ToString().Trim();
                    MyOraDB.Parameter_Values[vcnt++] = (fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxUPD_USER]      == null) ? "" : fgrid_detail[row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxUPD_USER].ToString().Trim();
                }

                MyOraDB.Add_Modify_Parameter(false);                
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch
            {
                return false;
            }
        }         
        private DataTable GET_REQ_NO()
        {
            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.GET_REQ_NO";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        #endregion

        #region Delete Data
        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                int sct_row = fgrid_top.Selection.r1;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTATUS].ToString().Trim().Equals("C"))
                {
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "D";                    
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

                int [] sct_rows = fgrid_top.Selections;
                int sct_row = fgrid_top.Selection.r1;
                int sct_col = fgrid_top.Selection.c1;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _status   = fgrid_top[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTATUS].ToString().Trim();
                    string _factory  = fgrid_top[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxFACTORY].ToString().Trim();
                    string _req_no   = fgrid_top[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_NO].ToString().Trim();
                    string _upd_user = COM.ComVar.This_User;
                                        
                    if (_status.Equals("N"))
                        SUB_CONFIRM_REQUEST(_factory, _req_no, _upd_user);               
                }

                if (COM.ComVar.This_Factory.Equals("DS"))
                {
                    string _factory = cmb_factory.SelectedValue.ToString();
                    string _date_from = dtp_from.Value.ToString("yyyyMMdd");
                    string _date_to = dtp_to.Value.ToString("yyyyMMdd");
                    string _upd_user = COM.ComVar.This_User;

                    CONFIRM_REQUEST(_factory, _date_from, _date_to, _upd_user);

                    MessageBox.Show("Confirm Completed");
                }

                tbtn_Search_Click(null, null);
                fgrid_top.Select(sct_row, sct_col);
                fgrid_top_Click(null, null);

            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string _factory   = cmb_factory.SelectedValue.ToString();
                string _date_from = dtp_from.Value.ToString("yyyyMMdd");
                string _date_to   = dtp_to.Value.ToString("yyyyMMdd");
                string _upd_user  = COM.ComVar.This_User;

                CONFIRM_REQUEST(_factory, _date_from, _date_to, _upd_user);

                MessageBox.Show("Confirm Completed");

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
        private void SUB_CONFIRM_REQUEST(string arg_factory, string arg_req_no, string arg_upd_user)
        {
            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01.SUB_CONF_SXP_REQ_HEAD";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_req_no;
            MyOraDB.Parameter_Values[2] = arg_upd_user;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        private void CONFIRM_REQUEST(string arg_factory, string arg_date_from, string arg_date_to, string arg_upd_user)
        {
            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01.CONF_SXP_REQ_HEAD";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_DATE_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_DATE_TO";
            MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_date_from;
            MyOraDB.Parameter_Values[2] = arg_date_to;
            MyOraDB.Parameter_Values[3] = arg_upd_user;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Grid Event

        #region Grid Top
        private void fgrid_top_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count == fgrid_top.Rows.Fixed)
                    return;               

                #region Tail Data Load        
                int sct_row = fgrid_top.Selection.r1;

                click_flg = true;

                cmb_req_dept.SelectedValue   = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_DEPT].ToString().Trim();
                cmb_category_t.SelectedValue = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY].ToString().Trim();
                cmb_season_t.SelectedValue   = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON_CD].ToString().Trim();
                txt_srf_no.Text              = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSRF_NO].ToString().Trim();
                txt_bom_id_t.Text            = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID].ToString().Trim();
                txt_style_cd_t.Text          = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_CD].ToString().Trim();
                txt_dev_name.Text            = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME].ToString().Trim();
                cmb_round.SelectedValue      = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxNF_CD].ToString().Trim();
                txt_nike_dev.Text            = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxWHQ_DEV].ToString().Trim();
                txt_cdc_dev.Text             = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCDC_DEV].ToString().Trim();
                txt_dhl_acc.Text             = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDHL_ACCOUNT].ToString().Trim();
                txt_rta.Text                 = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD].ToString().Trim();
                txt_spl_ddd.Text             = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD].ToString().Trim();
                
                click_flg = false;

                string div = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Trim();

                if (!div.Equals("I"))
                {
                    string arg_factory = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxFACTORY] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxFACTORY].ToString().Trim();
                    string arg_req_no = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_NO] == null) ? "" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_NO].ToString().Trim();


                    if (arg_req_no.Equals(""))
                        return;

                    fgrid_detail.Rows.Count = fgrid_detail.Rows.Fixed;
                    DataTable dt_ret = SELECT_PUR_REQUEST_TAIL(arg_factory, arg_req_no);
                    Display_Grid_Tail(dt_ret);
                }
                #endregion

                #region 조건별 기능 설정
                string _status = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTATUS] == null) ? "N" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTATUS].ToString().Trim();

                if (!_status.Equals("N"))
                {
                    cmb_req_dept.Enabled   = false;
                    cmb_category_t.Enabled = false;
                    cmb_season_t.Enabled   = false;
                    txt_srf_no.Enabled     = false;
                    txt_bom_id_t.Enabled   = false;
                    txt_style_cd_t.Enabled = false;
                    txt_dev_name.Enabled   = false;
                    cmb_round.Enabled      = false;
                    txt_nike_dev.Enabled   = false;
                    txt_cdc_dev.Enabled    = false;
                    txt_dhl_acc.Enabled    = false;
                    txt_rta.Enabled        = false;
                    txt_spl_ddd.Enabled    = false;

                    btn_plus.Enabled  = false;
                    btn_minus.Enabled = false;

                    fgrid_detail.AllowEditing = false;
                    
                    if(_status.Equals("Y"))
                        mnu_release.Visible = true;
                    else
                        mnu_release.Visible = false;
                }
                else
                {
                    cmb_req_dept.Enabled   = true;
                    cmb_category_t.Enabled = true;
                    cmb_season_t.Enabled   = true;
                    txt_srf_no.Enabled     = true;
                    txt_bom_id_t.Enabled   = true;
                    txt_style_cd_t.Enabled = true;
                    txt_dev_name.Enabled   = true;
                    cmb_round.Enabled      = true;
                    txt_nike_dev.Enabled   = true;
                    txt_cdc_dev.Enabled    = true;
                    txt_dhl_acc.Enabled    = true;
                    txt_rta.Enabled        = true;
                    txt_spl_ddd.Enabled    = true;

                    btn_plus.Enabled  = true;
                    btn_minus.Enabled = true;

                    fgrid_detail.AllowEditing = true;

                    mnu_release.Visible = false;
                }
                #endregion
            }
            catch
            {
 
            }
        }
        private void fgrid_top_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (size_flg)
                {
                    c1Sizer1.Grid.Rows[1].Size = 264;
                    size_flg = false;
                }
                else
                {
                    c1Sizer1.Grid.Rows[1].Size = 400;
                    size_flg = true;
                }
                
            }
        }
        private DataTable SELECT_PUR_REQUEST_TAIL(string arg_factory, string arg_req_no)
        {
            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.SELECT_REQ_TAIL_01";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";            
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;            
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_req_no;            
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }
        private void Display_Grid_Tail(DataTable arg_dt)
        {            
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                fgrid_detail.Rows.Add();

                for (int j = fgrid_detail.Cols.Fixed; j < fgrid_detail.Cols.Count; j++)
                {
                    fgrid_detail[fgrid_detail.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();                    
                }

                string _status = fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSTATUS].ToString().Trim();

                if (_status.Equals("N"))
                    fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].StyleNew.BackColor = Color.White;
                else if (_status.Equals("Y"))
                    fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].StyleNew.BackColor = Color.LightYellow;
                else if (_status.Equals("C"))
                    fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].StyleNew.BackColor = Color.Bisque;
            }
        }
        #endregion

        #region Grid Detail
        private void fgrid_detail_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_detail.Rows.Count == fgrid_detail.Rows.Fixed)
                    return;

                int sct_row = fgrid_top.Selection.r1;

                string _status = (fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTATUS] == null) ? "N" : fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTATUS].ToString().Trim();

                if (!_status.Equals("N"))
                {
                    mnu_image.Enabled      = false;
                    mnu_delete_img.Enabled = false;
                    mnu_insert.Enabled     = false;
                }
                else
                {
                    string div = fgrid_detail[fgrid_detail.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxDIV].ToString().Trim();

                
                    if (div.Equals("I"))                
                    {                    
                        mnu_image.Enabled = false;                    
                        mnu_delete_img.Enabled = false;
                        mnu_insert.Enabled = true;
                    }                
                    else                
                    {                    
                        mnu_image.Enabled = true;                    
                        mnu_delete_img.Enabled = true;
                        mnu_insert.Enabled = true;
                    }
                }
                
            }
            catch
            {
 
            }
        }

        private void fgrid_detail_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_detail.Rows.Count == fgrid_detail.Rows.Fixed)
                    return;

                int top_row = fgrid_top.Selection.r1;

                string _status = (fgrid_top[top_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTATUS] == null || fgrid_top[top_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTATUS].ToString().Trim().Equals("")) ? "N" : fgrid_top[top_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTATUS].ToString().Trim();

                if (_status.Equals("N"))
                {
                    int sct_col = fgrid_detail.Selection.c1;

                    if (sct_col < (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_NO || sct_col > (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSPEC_NAME)
                    {
                        if (sct_col.Equals((int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVENDOR) || sct_col.Equals((int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREMARKS))
                        {
                            Pop_Pur_Request_Detail pop = new Pop_Pur_Request_Detail(this);
                            pop.ShowDialog();
                        }
                    }
                    else
                    {
                        Pop_Pur_Request_Detail pop = new Pop_Pur_Request_Detail(this);
                        pop.ShowDialog();
                    }
                }                
                
            }
            catch
            {

            }
            finally
            {

            }
        }
        private void fgrid_detail_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = fgrid_detail.Selection.r1;
                int [] sct_rows = fgrid_detail.Selections;


                for (int i = 0; i < sct_rows.Length; i++)
                {

                    if (!fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxDIV].ToString().Equals("I"))
                        fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxDIV] = "U";

                    string pur_div = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPUR_DIV].ToString().Trim();

                    if (pur_div.Equals("11"))
                    {
                        fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVEN_SEQ] = "X2";
                        fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVENDOR] = "CHANGSHIN KOREA";
                    }
                }


            }
            catch
            {
 
            }
        }
        #endregion

        #endregion

        #region Control Event

        #region For Head Data  
        private void cmb_req_dept_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = (cmb_req_dept.SelectedValue == null) ? "" : cmb_req_dept.SelectedValue.ToString();

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_DEPT] = value;

                if(!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV]      = "U";

            }
            catch
            {

            }
        }
        private void cmb_category_t_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = (cmb_category_t.SelectedValue == null) ? "" : cmb_category_t.SelectedValue.ToString();

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY] = value;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void cmb_season_t_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = (cmb_season_t.SelectedValue == null) ? "" : cmb_season_t.SelectedValue.ToString();
                string value_02 = (cmb_season_t.Text == null) ? "" : cmb_season_t.Text;

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON_CD] = value;
                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSEASON] = value_02;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_srf_no_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = txt_srf_no.Text.Trim();

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSRF_NO] = value;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_bom_id_t_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = txt_bom_id_t.Text.Trim();

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID] = value;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_style_cd_t_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = txt_style_cd_t.Text.Trim();

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_CD] = value;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_dev_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = txt_dev_name.Text.Trim();

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME] = value;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void cmb_round_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = (cmb_round.SelectedValue == null) ? "" : cmb_round.SelectedValue.ToString();

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxNF_CD] = value;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_nike_dev_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = txt_nike_dev.Text.Trim();

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxWHQ_DEV] = value;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_cdc_dev_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = txt_cdc_dev.Text.Trim();

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCDC_DEV] = value;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_dhl_acc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = txt_dhl_acc.Text.Trim();

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDHL_ACCOUNT] = value;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_rta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = txt_rta.Text.Trim();

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxRTA_YMD] = value;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "U";
            }
            catch
            {

            }
        }
        private void txt_spl_ddd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count.Equals(fgrid_top.Rows.Fixed))
                    return;

                if (click_flg)
                    return;

                int sct_row = fgrid_top.Selection.r1;
                string value = txt_spl_ddd.Text.Trim();

                fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSPL_DDD_YMD] = value;

                if (!fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV].ToString().Equals("I"))
                    fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxDIV] = "U";
            }
            catch
            {

            }
        }
        #endregion
                
        #region For Tail Data
        private void btn_plus_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_top.Rows.Count == fgrid_top.Rows.Fixed)
                {
                    tbtn_New_Click(null, null); 
                }

                fgrid_detail.Rows.Add();

                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxDIV] = "I";
                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxFACTORY] = fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxFACTORY].ToString();
                fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxUPD_USER] = COM.ComVar.This_User;
                fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].StyleNew.BackColor = Color.White;
                fgrid_detail.Select(fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_NO);
                
                Pop_Pur_Request_Detail pop = new Pop_Pur_Request_Detail(this);
                pop.ShowDialog();
            }
            catch
            {
 
            }
        }
        private void btn_minus_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_detail.Rows.Count == fgrid_detail.Rows.Fixed)
                    return;

                int sct_row = fgrid_detail.Selection.r1;
                int [] sct_rows = fgrid_detail.Selections;
                int sct_col = fgrid_detail.Selection.c1;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _div = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxDIV].ToString();

                    if (!_div.Equals("I"))
                    {
                        string arg_factory = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxFACTORY].ToString();
                        string arg_req_no  = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREQ_NO].ToString();
                        string arg_req_seq = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREQ_SEQ].ToString();

                        DELETE_REQ_TAIL(arg_factory, arg_req_no, arg_req_seq);
                    }

                    fgrid_detail.Rows.Remove(sct_rows[i]);

                }

                if(sct_row.Equals(fgrid_detail.Rows.Count))
                    fgrid_detail.Select(sct_row - 1, sct_col);
                else
                    fgrid_detail.Select(sct_row, sct_col);
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void DELETE_REQ_TAIL(string arg_factory, string arg_req_no, string arg_req_seq)
        {
            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01.DELETE_SXP_REQ_TAIL";

            MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1]  = "ARG_REQ_NO";
            MyOraDB.Parameter_Name[2]  = "ARG_REQ_SEQ";
            
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_req_no;
            MyOraDB.Parameter_Values[2] = arg_req_seq;
           
            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion                
        #endregion     
   
        #region Context Menu 
        
        #region Head Data
        private void mnu_insert_data_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int sct_row = fgrid_top.Selection.r1;
                                
                string _factory     = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxFACTORY].ToString();
                string _req_no      = fgrid_top[sct_row, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_NO].ToString();
                string _req_user    = COM.ComVar.This_User;

                if (COPY_REQUEST(_factory, _req_no))
                {
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

        private bool COPY_REQUEST(string arg_factory, string arg_req_no)
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = "PKG_SXP_REQ_01.COPY_SXP_REQ_HEAD";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
                MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";
                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_req_no;
                MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;
                
                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch
            {
                return false;
            }
        }         
        private void mnu_release_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int[] sct_rows = fgrid_top.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _status   = fgrid_top[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTATUS].ToString().Trim();
                    string _factory  = fgrid_top[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxFACTORY].ToString().Trim();
                    string _req_no   = fgrid_top[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_NO].ToString().Trim();
                    string _upd_user = COM.ComVar.This_User;

                    if (_status.Equals("Y"))
                        RELEASE_CONFIRM_REQUEST(_factory, _req_no, _upd_user);

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
        private void RELEASE_CONFIRM_REQUEST(string arg_factory, string arg_req_no, string arg_upd_user)
        {
            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = "PKG_SXP_REQ_01.RELEASE_SXP_REQ_HEAD";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
            MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_req_no;
            MyOraDB.Parameter_Values[2] = arg_upd_user;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Tail Data
        private void mnu_insert_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_detail.Selection.r1;
                int [] sct_rows = fgrid_detail.Selections;

                if (sct_row >= fgrid_detail.Rows.Fixed)
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        fgrid_detail.Rows.Add();

                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxDIV]         = "I";
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxFACTORY]     = fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxFACTORY].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREQ_NO]      = (fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_NO] == null) ? "" : fgrid_top[fgrid_top.Selection.r1, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_NO].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREQ_SEQ]     = "";
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_NO]     = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_NO]     == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_NO].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC]   = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC]   == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CLASS]   = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CLASS]   == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CLASS].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CD]      = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CD]      == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_CD].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_NAME]    = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_NAME]    == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxMAT_NAME].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_CD]    = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_CD]    == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_CD].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_NAME]  = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_NAME]  == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxCOLOR_NAME].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_UNIT_CD] = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_UNIT_CD] == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_UNIT_CD].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_SPEC_CD] = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_SPEC_CD] == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPCC_SPEC_CD].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSPEC_NAME]   = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSPEC_NAME]   == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSPEC_NAME].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPUR_DIV]     = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPUR_DIV]     == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPUR_DIV].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVALUE_REQ]   = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVALUE_REQ]   == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVALUE_REQ].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVEN_SEQ]     = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVEN_SEQ]     == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVEN_SEQ].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVENDOR]      = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVENDOR]      == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxVENDOR].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxRTA_YMD]     = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxRTA_YMD]     == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxRTA_YMD].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxETS_YMD]     = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxETS_YMD]     == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxETS_YMD].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREMARKS]     = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREMARKS]     == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREMARKS].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSTATUS]      = (fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSTATUS]      == null) ? "" : fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxSTATUS].ToString();
                        fgrid_detail[fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxUPD_USER]    = COM.ComVar.This_User;

                        fgrid_detail.Rows[fgrid_detail.Rows.Count - 1].StyleNew.BackColor = Color.White;
                    }
                }

                fgrid_detail.Select(fgrid_detail.Rows.Count - 1, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxPART_DESC);
            }
            catch
            {
 
            }
        }
        private void mnu_image_Click(object sender, EventArgs e)
        {
            try
            {
                Pop_Pur_Request_IMG pop = new Pop_Pur_Request_IMG(this);
                pop.ShowDialog();

                if (pop.save_flg)
                {
                    int sct_row = fgrid_detail.Selection.r1;

                    fgrid_detail[sct_row, (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxIMG_YN] = "TRUE";
                    MessageBox.Show("Image File Save Complete.");                    
                }
            }
            catch
            {

            }
            finally
            {
 
            }
        }
        private void mnu_delete_img_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int [] sct_rows = fgrid_detail.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _factory = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxFACTORY].ToString().Trim();
                    string _req_no  = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREQ_NO].ToString().Trim();
                    string _req_seq = fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxREQ_SEQ].ToString().Trim();

                    if (DELETE_REQ_IMAGE(_factory, _req_no, _req_seq))
                        fgrid_detail[sct_rows[i], (int)ClassLib.TBSXP_PUR_REQ_TAIL.IxIMG_YN] = "FALSE";
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

        private bool DELETE_REQ_IMAGE(string arg_factory, string arg_req_no, string arg_req_seq)
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXP_REQ_01.DELETE_SXP_REQ_IMAGE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
                MyOraDB.Parameter_Name[2] = "ARG_REQ_SEQ";
               
                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                
                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_req_no;
                MyOraDB.Parameter_Values[2] = arg_req_seq;

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();
                return true;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Save_Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        
        
        #endregion

        #region CheckBox Event
        private void chk_category_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                chk_flg = true;
                chk_bom.Checked = false;
                chk_model.Checked = false;
                chk_flg = false;

                Checkbox_Event();
            }
            catch
            {
 
            }
        }
        private void chk_bom_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                chk_flg = true;
                chk_category.Checked = false;
                chk_model.Checked = false;
                chk_flg = false;

                Checkbox_Event();
            }
            catch
            {

            }
        }
        private void chk_model_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                chk_flg = true;
                chk_category.Checked = false;
                chk_bom.Checked = false;
                chk_flg = false;


                Checkbox_Event();
            }
            catch
            {

            }
        }

        private void Checkbox_Event()
        {
            if (chk_category.Checked)
            {                
                fgrid_top.Sort(SortFlags.Ascending, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxCATEGORY);
            }
            else if (chk_bom.Checked)
            {
                fgrid_top.Sort(SortFlags.Ascending, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxBOM_ID);
            }
            else if (chk_model.Checked)
            {                
                fgrid_top.Sort(SortFlags.Ascending, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxSTYLE_NAME);
            }
            else
            {
                fgrid_top.Sort(SortFlags.Descending, (int)ClassLib.TBSXP_PUR_REQ_HEAD.IxREQ_NO); 
            }
        }
        #endregion

        //private void mnu_change_value_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("test");
        //}
    }
}


