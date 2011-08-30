using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;

namespace FlexCDC.Analisys
{
    public partial class Pop_EIS_DD_Report : COM.APSWinForm.Form_Top
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        Form_EIS_DD_Report_New _main_form = null;

        private bool first_flg = true;
        public bool save_flg = false;        
        #endregion

        #region 생성자
        public Pop_EIS_DD_Report()
        {
            InitializeComponent();            
        }
        public Pop_EIS_DD_Report(Form_EIS_DD_Report_New arg_main_form)
        {
            _main_form = arg_main_form;

            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Pop_EIS_DD_Report_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

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
            //Title
            this.Text = " Update DD Report";
            lbl_MainTitle.Text = " Update DD Report";
            lbl_title.Text = "       Search Condition ";

            Init_Grid();
            Init_Control();
            Init_Toolbar();

            if (_main_form != null)
                tbtn_Search_Click(null, null);
        }
        private void Init_Grid()
        {
            fgrid_main.Set_Grid("EIS_DD_REPORT_POP", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.ExtendLastCol = false;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxLKS, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOTH).StyleNew.BackColor = Color.SkyBlue;

            if (!COM.ComVar.This_Factory.Equals("DS"))
            {
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxP_FACTORY].AllowEditing = false;
            }
        }
        private void Init_Control()
        {
            if (_main_form != null)
            {
                #region Pop으로 Loading 시
                int sct_row = _main_form.fgrid_Main.Selection.r1;

                string season    = _main_form.fgrid_Main[sct_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSEASON_CD].ToString().Trim();
                string facotry   = _main_form.fgrid_Main[sct_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxFACTORY].ToString().Trim();
                string p_facotry = _main_form.fgrid_Main[sct_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxP_FACTORY].ToString().Trim();
                string model_id  = _main_form.fgrid_Main[sct_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxMODEL_ID].ToString().Trim();
                string bom_id    = _main_form.fgrid_Main[sct_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxBOM_ID].ToString().Trim();

                DataTable dt_ret = SELECT_SEASON();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sesn_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sesn_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_sesn_from.SelectedValue = season;
                cmb_sesn_to.SelectedValue   = season;

                // Factory Combobox Setting
                dt_ret = ClassLib.ComFunction.Select_Factory_List();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);

                if (COM.ComVar.This_Factory.Equals("DS"))
                {
                    if (facotry.Equals(""))
                        cmb_factory.SelectedValue = "DS";
                    else
                        cmb_factory.SelectedValue = facotry;

                    cmb_factory.Enabled = true;
                }
                else
                {
                    cmb_factory.SelectedValue = COM.ComVar.This_Factory;
                    cmb_factory.Enabled = false;
                }

                //Prod. Factory
                dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SXC35");
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_p_factory, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
                if (p_facotry.Equals(""))
                    cmb_p_factory.SelectedIndex = 0;
                else
                    cmb_p_factory.SelectedValue = p_facotry;

                // Category Combobox Setting
                dt_ret = SELECT_CATEGORY();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
                cmb_category.SelectedIndex = 0;

                // Model Combobox Setting
                dt_ret = SELECT_MODEL();
                ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_model, 0, 1, true, 100, 220);
                if (model_id.Equals(""))
                    cmb_model.SelectedIndex = 0;
                else
                    cmb_model.SelectedValue = model_id;

                // Dev. User Combobox Setting
                if (COM.ComVar.This_CDCPower_Level.Equals("S00") || COM.ComVar.This_CDCPower_Level.Equals("D00") || (!COM.ComVar.This_Factory.Equals("DS") && COM.ComVar.This_CDCPower_Level.Equals("P01")))
                {
                    dt_ret = SELECT_DEV_USER();
                    ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_user, 0, 0, true, 0, 180);

                    if (COM.ComVar.This_CDCPower_Level.Equals("D00"))
                    {
                        try
                        {
                            cmb_user.SelectedValue = COM.ComVar.This_User;
                        }
                        catch
                        {
                            cmb_user.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        cmb_user.SelectedIndex = 0;
                    }
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

                    ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_user, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
                    cmb_user.SelectedValue = ClassLib.ComVar.This_User;
                }

                txt_bom.Text = bom_id;

                first_flg = false;
                #endregion
            }
            else
            {
                #region Menu에서 Loading 시
                DataTable dt_ret = SELECT_SEASON();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sesn_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sesn_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_sesn_from.SelectedValue = "200904";
                cmb_sesn_to.SelectedValue   = "200904";

                // Factory Combobox Setting
                dt_ret = ClassLib.ComFunction.Select_Factory_List();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);

                if (COM.ComVar.This_Factory.Equals("DS"))
                {
                    cmb_factory.SelectedValue = "DS";
                    cmb_factory.Enabled = true;
                }   
                else
                {
                    cmb_factory.SelectedValue = COM.ComVar.This_Factory;
                    cmb_factory.Enabled = false; 
                }
                

                //Prod. Factory
                dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SXC35");
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_p_factory, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
                cmb_p_factory.SelectedIndex = 0;
                
                // Category Combobox Setting
                dt_ret = SELECT_CATEGORY();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
                cmb_category.SelectedIndex = 0;

                // Model Combobox Setting
                dt_ret = SELECT_MODEL();
                ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_model, 0, 1, true, 100, 220);
                cmb_model.SelectedIndex = 0;

                // Dev. User Combobox Setting
                if (COM.ComVar.This_CDCPower_Level.Equals("S00") || COM.ComVar.This_CDCPower_Level.Equals("D00") || (!COM.ComVar.This_Factory.Equals("DS")&& COM.ComVar.This_CDCPower_Level.Equals("P01")))
                {
                    dt_ret = SELECT_DEV_USER();
                    ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_user, 0, 0, true, 0, 180);

                    if (COM.ComVar.This_CDCPower_Level.Equals("D00"))
                    {
                        try
                        {
                            string group = COM.ComVar.This_CDCGroup_Code;

                            if(group.Equals("EXP"))
                                cmb_user.SelectedIndex = 0;
                            else
                                cmb_user.SelectedValue = COM.ComVar.This_User;
                        }
                        catch
                        {
                            cmb_user.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        cmb_user.SelectedIndex = 0;
                    }
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

                    ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_user, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
                    cmb_user.SelectedValue = ClassLib.ComVar.This_User;
                }

                first_flg = false;
                #endregion
            }

            if (COM.ComVar.This_Factory.Equals("DS") && (COM.ComVar.This_CDCPower_Level.Equals("S00") || COM.ComVar.This_CDCPower_Level.Equals("D00")))
            {
                mnu_model_id.Enabled = true;
                mnu_release.Enabled = true;
                mnu_model_id.Visible = true;
                mnu_release.Visible = true;
            }
            else
            {
                mnu_model_id.Enabled = false;
                mnu_release.Enabled = false;
                mnu_model_id.Visible = false;
                mnu_release.Visible = false; 
            }

        }
        private void Init_Toolbar()
        {
            // Disabled tbutton         
            tbtn_New.Enabled    = false;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;            
            tbtn_Color.Enabled = false;
            tbtn_Print.Enabled  = false;
        }
        private DataTable SELECT_SEASON()
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_SEASON";

            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_CATEGORY()
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_CATEGORY";

            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_MODEL()
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_MODEL_LIST_DD";

            MyOraDB.ReDim_Parameter(6);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_P_FACTORY";
            MyOraDB.Parameter_Name[2] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[3] = "ARG_SEASON_TO";
            MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = cmb_p_factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = cmb_sesn_from.SelectedValue.ToString();
            MyOraDB.Parameter_Values[3] = cmb_sesn_to.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = cmb_category.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_DEV_USER()
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_DEV_USER_DD";

            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

                string [] arg_value = new string[8];

                arg_value[0] = cmb_sesn_from.SelectedValue.ToString();
                arg_value[1] = cmb_sesn_to.SelectedValue.ToString();
                arg_value[2] = cmb_factory.SelectedValue.ToString();
                arg_value[3] = cmb_p_factory.SelectedValue.ToString();
                arg_value[4] = cmb_category.SelectedValue.ToString();
                arg_value[5] = cmb_model.SelectedValue.ToString();
                arg_value[6] = txt_bom.Text.Trim();
                arg_value[7] = cmb_user.SelectedValue.ToString();

                DataTable dt_ret = SELECT_DD_REPORT_POP(arg_value);
                Display_Grid(dt_ret);

                fgrid_main.Select(fgrid_main.Rows.Fixed, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCHK);
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void Display_Grid(DataTable arg_dt)
        {
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                fgrid_main.Rows.Add();

                for (int j = fgrid_main.Cols.Fixed; j < fgrid_main.Cols.Count; j++)
                {
                    fgrid_main[fgrid_main.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                }

                string drop_yn = fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxDROP_YN].ToString().Trim();

                if (drop_yn.Equals("Y"))
                {
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCHK, fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxBOM_ID_V).StyleNew.BackColor = Color.LightGray;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCOPY_DEV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOFF_YN).StyleNew.BackColor = Color.LightGray;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxLKS, fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOTH).StyleNew.BackColor = Color.LightGray;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxUPD_USER, fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxUPD_YMD).StyleNew.BackColor = Color.LightGray;
                    fgrid_main.Rows[fgrid_main.Rows.Count - 1].AllowEditing = false;
                }
                else
                {
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCHK, fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxBOM_ID_V).StyleNew.BackColor = Color.Beige;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCOPY_DEV, fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOFF_YN).StyleNew.BackColor = Color.White;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxLKS, fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOTH).StyleNew.BackColor = Color.LightYellow;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxUPD_USER, fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxUPD_YMD).StyleNew.BackColor = Color.White;
                    fgrid_main.Rows[fgrid_main.Rows.Count - 1].AllowEditing = true;
                }
                
            }            
        }
        private DataTable SELECT_DD_REPORT_POP(string[] arg_value)
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_DD_REPORT_POP";

            MyOraDB.ReDim_Parameter(9);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[1] = "ARG_SEASON_TO";
            MyOraDB.Parameter_Name[2] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[3] = "ARG_P_FACTORY";
            MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[5] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[6] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[7] = "ARG_DEV_USER";
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

            MyOraDB.Parameter_Values[0] = arg_value[0];
            MyOraDB.Parameter_Values[1] = arg_value[1];
            MyOraDB.Parameter_Values[2] = arg_value[2];
            MyOraDB.Parameter_Values[3] = arg_value[3];
            MyOraDB.Parameter_Values[4] = arg_value[4];
            MyOraDB.Parameter_Values[5] = arg_value[5];
            MyOraDB.Parameter_Values[6] = arg_value[6];
            MyOraDB.Parameter_Values[7] = arg_value[7];
            MyOraDB.Parameter_Values[8] = "";

            string factory = cmb_factory.SelectedValue.ToString();
            if (!factory.Equals("DS"))
            {
                if (factory.Equals("QD"))
                    COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;
                if (factory.Equals("VJ"))
                    COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;
            }
            else
            {
                COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
            }

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;


            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (Check_Save_Data())
                {
                    if (SAVE_DD_REPORT())
                    {
                        if (SAVE_USER_CHK())
                        {
                            fgrid_main.ClearFlags();
                            save_flg = true;
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

        private bool Check_Save_Data()
        {
            try
            {
                for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                {
                    string div = fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxDIVISION].ToString().Trim();

                    if (div.Equals("U"))
                    {
                        string category  = (fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCATEGORY_V] == null) ? "" : fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCATEGORY_V].ToString().Trim();
                        string gender    = (fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxGEN_CD] == null) ? "" : fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxGEN_CD].ToString().Trim();
                        string p_factory = (fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxP_FACTORY] == null) ? "" : fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxP_FACTORY].ToString().Trim();
                        string t_d       = (fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxT_D_V] == null) ? "" : fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxT_D_V].ToString().Trim();

                        if (category.Equals(""))
                        {
                            MessageBox.Show("Category is Empty");
                            fgrid_main.Select(i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCATEGORY_V);
                            return false;
                        }
                        if (gender.Equals(""))
                        {
                            MessageBox.Show("Gender is Empty");
                            fgrid_main.Select(i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxGEN_CD);
                            return false;
                        }
                        if (p_factory.Equals(""))
                        {
                            MessageBox.Show("Product Factory is Empty");
                            fgrid_main.Select(i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxP_FACTORY);
                            return false;
                        }
                        if (t_d.Equals(""))
                        {
                            MessageBox.Show("TD Code is Empty");
                            fgrid_main.Select(i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxT_D_V);
                            return false;
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool SAVE_DD_REPORT()
        {
            try
            {
                int col_ct = 13;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_EDM_BATCH_01.UPDATE_EDM_LIFE_CYCLE";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1]  = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2]  = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3]  = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4]  = "ARG_T_D";
                MyOraDB.Parameter_Name[5]  = "ARG_TO_CATEGORY";
                MyOraDB.Parameter_Name[6]  = "ARG_TO_GENDER";
                MyOraDB.Parameter_Name[7]  = "ARG_TO_P_FACTORY";
                MyOraDB.Parameter_Name[8]  = "ARG_TO_T_D";
                MyOraDB.Parameter_Name[9]  = "ARG_TO_STYLE_CD";
                MyOraDB.Parameter_Name[10]  = "ARG_TO_SPC_YN";
                MyOraDB.Parameter_Name[11] = "ARG_TO_OFF_YN";
                MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";
                
                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }

                ArrayList vList = new ArrayList();

                for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                {
                    if (fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxDIVISION] == null || fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxDIVISION].ToString().Equals("")) 
                        continue;
                    
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxFACTORY].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSRF_NO].ToString().Replace("-", ""));
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxBOM_ID].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxT_D].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCATEGORY_V].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxGEN_CD].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxP_FACTORY].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxT_D_V].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSTYLE_CD].ToString());
                    vList.Add((fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSPC_YN].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N");
                    vList.Add((fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOFF_YN].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N");
                    vList.Add(COM.ComVar.This_User);

                }

                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

                string factory = cmb_factory.SelectedValue.ToString();
                if (!factory.Equals("DS"))
                {
                    if (factory.Equals("QD"))
                        COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;
                    if (factory.Equals("VJ"))
                        COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;
                }
                else
                {
                    COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
                }

                MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가  
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

                COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;

                if (ds_ret == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }


        }
        private bool SAVE_USER_CHK()
        {
            try
            {
                int col_ct = 7;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_EDM_BATCH_01.UPDATE_USER_CHK_YN";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4] = "ARG_T_D";
                MyOraDB.Parameter_Name[5] = "ARG_USER_CHK_YN";
                MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";

                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }

                ArrayList vList = new ArrayList();

                for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                {
                    if (fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxDIVISION] == null || fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxDIVISION].ToString().Equals(""))
                        continue;

                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxFACTORY].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSRF_NO].ToString().Replace("-", ""));
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxBOM_ID].ToString());
                    vList.Add(fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxT_D].ToString());                    
                    vList.Add((fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCHK].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N");
                    vList.Add(COM.ComVar.This_User);
                }

                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

                string factory = cmb_factory.SelectedValue.ToString();
                if (!factory.Equals("DS"))
                {
                    if (factory.Equals("QD"))
                        COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;
                    if (factory.Equals("VJ"))
                        COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;
                }
                else
                {
                    COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
                }


                MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가  
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();
                COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;

                if (ds_ret == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }


        }
        #endregion

        #region Confirm Data
        private void tbtn_Color_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (CONFIRM_DATA())
                {
                    MessageBox.Show("Data Transfer Completed");
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

        private bool CONFIRM_DATA()
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = "PKG_EDM_BATCH_01.RECEIPT_EDM_LIFE_CYCLE";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";
                
                // 파라미터의 데이터 Type
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                
                // DATA 정의
                MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[1] = COM.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();
                
                if (ds_ret == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion

        #region Grid Event
        private void fgrid_main_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if(fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;                
            }
            catch
            {
 
            }
        }
        private void fgrid_main_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int[] sct_rows = fgrid_main.Selections;
                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;

                if (sct_col.Equals((int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSTYLE_CD))
                {
                    string style_cd = fgrid_main[sct_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSTYLE_CD].ToString().Trim();

                    if (style_cd.Length != 0 && style_cd.Length != 9)
                    {
                        MessageBox.Show("Style Code Format is worng");
                        fgrid_main.StartEditing(sct_row, sct_col);
                        return;
                    }
                }

                if (sct_col.Equals((int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCHK) ||
                    sct_col.Equals((int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCATEGORY_V) ||
                    sct_col.Equals((int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID_V) ||
                    sct_col.Equals((int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSTYLE_CD) ||
                    sct_col.Equals((int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSPC_YN) ||
                    sct_col.Equals((int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOFF_YN) ||
                    sct_col.Equals((int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxP_FACTORY) ||
                    sct_col.Equals((int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxT_D_V) ||
                    sct_col.Equals((int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxGEN_CD))
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        fgrid_main[sct_rows[i], sct_col] = fgrid_main[sct_row, sct_col].ToString();
                        fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxDIVISION] = "U";

                        if (!sct_col.Equals((int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCHK))
                            fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCHK] = "TRUE";
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
        #endregion

        #region Control Event
        private void chk_Round_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Round.Checked)
            {
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxLKS].Visible = true;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSMM].Visible = true;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxRLF].Visible = true;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxACN].Visible = true;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxGTM].Visible = true;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxPRE].Visible = true;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxRFC].Visible = true;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxPRO].Visible = true;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOTH].Visible = true;
            }
            else
            {
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxLKS].Visible = false;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSMM].Visible = false;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxRLF].Visible = false;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxACN].Visible = false;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxGTM].Visible = false;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxPRE].Visible = false;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxRFC].Visible = false;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxPRO].Visible = false;
                fgrid_main.Cols[(int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOTH].Visible = false; 
            }
        }
        private void cmb_sesn_from_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flg)
                    return;

                // Model Combobox Setting
                DataTable dt_ret = SELECT_MODEL();
                ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_model, 0, 1, true, 100, 220); ;
                cmb_model.SelectedIndex = 0;

            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }
        private void cmb_sesn_to_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flg)
                    return;

                // Model Combobox Setting
                DataTable dt_ret = SELECT_MODEL();
                ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_model, 0, 1, true, 100, 220); ;
                cmb_model.SelectedIndex = 0;
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flg)
                    return;

                if (COM.ComVar.This_Factory.Equals("DS") && (COM.ComVar.This_CDCPower_Level.Equals("S00") || COM.ComVar.This_CDCPower_Level.Equals("D00")))
                {
                    if (!cmb_factory.SelectedValue.ToString().Equals("DS"))
                    {
                        tbtn_Color.Enabled = true;
                    }
                    else
                    {
                        tbtn_Color.Enabled = false; 
                    }
                }


                // Model Combobox Setting
                DataTable dt_ret = SELECT_MODEL();
                ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_model, 0, 1, true, 100, 220);
                cmb_model.SelectedIndex = 0;
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void cmb_p_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flg)
                    return;

                // Model Combobox Setting
                DataTable dt_ret = SELECT_MODEL();
                ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_model, 0, 1, true, 100, 220); ;
                cmb_model.SelectedIndex = 0;
            }
            catch
            {

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

                if (first_flg)
                    return;

                // Model Combobox Setting
                DataTable dt_ret = SELECT_MODEL();
                ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_model, 0, 1, true, 100, 220); ;
                cmb_model.SelectedIndex = 0;
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

        #region Context Menu        
        private void mnu_model_id_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int[] sct_rows = fgrid_main.Selections;
                
                string _model_id = "";
                bool same_flg = true;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _model_id_same = fgrid_main[sct_rows[0], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID_V].ToString().Trim();
                    string _model_id_chk  = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID_V].ToString().Trim();

                    if (!_model_id_same.Equals(_model_id_chk))
                    {
                        same_flg = false;
                        break;
                    }
                }

                if (same_flg)
                {
                    _model_id = GET_NEW_MODEL_ID().Rows[0].ItemArray[0].ToString();

                    if (UPDATE_MODEL_ID(_model_id))
                    {
                        for (int i = 0; i < sct_rows.Length; i++)
                        {
                            fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID_V] = _model_id;
                            fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID] = _model_id;
                        }

                        return;
                    }
                }


                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string _model_id_chk = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID_V].ToString().Trim();
                                        
                    if (_model_id_chk.Length < 9)
                    {
                        _model_id = _model_id_chk;
                        break;
                    }        
                }

                if (_model_id.Equals(""))
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        string _model_id_chk = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID_V].ToString().Trim();

                        if (_model_id_chk.Substring(0, 1).Equals("X"))
                        {
                            _model_id = _model_id_chk;
                            break;
                        }
                    }
                }

                if (_model_id.Equals(""))
                {
                    _model_id = GET_NEW_MODEL_ID().Rows[0].ItemArray[0].ToString();
                }

                if (UPDATE_MODEL_ID(_model_id))
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID_V] = _model_id;
                        fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID]   = _model_id;
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
        private void mnu_release_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string model_id = RELEASE_MODEL_ID(sct_rows[i]).Rows[0].ItemArray[0].ToString();

                    fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID_V] = model_id;
                    fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID] = model_id;
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
        private void mnu_drop_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;


                int[] sct_rows = fgrid_main.Selections;
                
                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string drop_yn = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxDROP_YN].ToString().Trim();

                    if (drop_yn.Equals("N"))
                    {
                        string[] arg_value = new string[7];
                        arg_value[0] = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxFACTORY].ToString().Trim();
                        arg_value[1] = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID].ToString().Trim();
                        arg_value[2] = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSRF_NO].ToString().Trim();
                        arg_value[3] = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxBOM_ID].ToString().Trim();
                        arg_value[4] = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxT_D].ToString().Trim();
                        arg_value[5] = "Y";
                        arg_value[6] = COM.ComVar.This_User;
                        if (UPDATE_DROP_YN(arg_value))
                        {
                            fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxDROP_YN] = "Y";
                            fgrid_main.GetCellRange(sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCHK, sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxBOM_ID_V).StyleNew.BackColor = Color.LightGray;
                            fgrid_main.GetCellRange(sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCOPY_DEV, sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOFF_YN).StyleNew.BackColor = Color.LightGray;
                            fgrid_main.GetCellRange(sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxLKS, sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOTH).StyleNew.BackColor = Color.LightGray;
                            fgrid_main.GetCellRange(sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxUPD_USER, sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxUPD_YMD).StyleNew.BackColor = Color.LightGray;
                            fgrid_main.Rows[sct_rows[i]].AllowEditing = false;
                        }
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
        private void mnu_cancel_drop_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;


                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    string drop_yn = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxDROP_YN].ToString().Trim();

                    if (drop_yn.Equals("Y"))
                    {
                        string[] arg_value = new string[7];
                        arg_value[0] = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxFACTORY].ToString().Trim();
                        arg_value[1] = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID].ToString().Trim();
                        arg_value[2] = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSRF_NO].ToString().Trim();
                        arg_value[3] = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxBOM_ID].ToString().Trim();
                        arg_value[4] = fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxT_D].ToString().Trim();
                        arg_value[5] = "N";
                        arg_value[6] = COM.ComVar.This_User;

                        if (UPDATE_DROP_YN(arg_value))
                        {
                            fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxDROP_YN] = "N";
                            fgrid_main.GetCellRange(sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCHK, sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxBOM_ID_V).StyleNew.BackColor = Color.Beige;
                            fgrid_main.GetCellRange(sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCOPY_DEV, sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOFF_YN).StyleNew.BackColor = Color.White;
                            fgrid_main.GetCellRange(sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxLKS, sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxOTH).StyleNew.BackColor = Color.LightYellow;
                            fgrid_main.GetCellRange(sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxUPD_USER, sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxUPD_YMD).StyleNew.BackColor = Color.White;
                            fgrid_main.Rows[sct_rows[i]].AllowEditing = true;
                        }
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

        private void mnu_select_all_Click(object sender, EventArgs e)
        {
            if (fgrid_main.Selection.r1 < 0 || fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                return;

            string chk = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCHK].ToString().Trim().ToUpper();

            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                if (chk.Equals("TRUE"))
                    fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCHK] = "FALSE";
                else
                    fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxCHK] = "TRUE";

                fgrid_main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxDIVISION] = "U";
            }

        }
        private DataTable GET_NEW_MODEL_ID()
        {
            string Proc_Name = "PKG_EDM_PCC_01.GET_NEW_MODEL_ID";

            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = "";

            string factory = cmb_factory.SelectedValue.ToString();
            if (!factory.Equals("DS"))
            {
                if (factory.Equals("QD"))
                    COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;
                if (factory.Equals("VJ"))
                    COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;
            }
            else
            {
                COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
            }

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private bool UPDATE_MODEL_ID(string arg_model_id)
        {
            try
            {
                int col_ct = 7;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_EDM_BATCH_01.UPDATE_MODEL_ID";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4] = "ARG_T_D";
                MyOraDB.Parameter_Name[5] = "ARG_TO_MODEL_ID";
                MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";

                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }

                ArrayList vList = new ArrayList();
                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    vList.Add(fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxFACTORY].ToString());
                    vList.Add(fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID].ToString());
                    vList.Add(fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSRF_NO].ToString());
                    vList.Add(fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxBOM_ID].ToString());
                    vList.Add(fgrid_main[sct_rows[i], (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxT_D].ToString());
                    vList.Add(arg_model_id);
                    vList.Add(COM.ComVar.This_User);
                }

                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

                string factory = cmb_factory.SelectedValue.ToString();
                if (!factory.Equals("DS"))
                {
                    if (factory.Equals("QD"))
                        COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;
                    if (factory.Equals("VJ"))
                        COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;
                }
                else
                {
                    COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
                }

                MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가  
                DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

                COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;

                if (ds_ret == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }


        }        
        private DataTable RELEASE_MODEL_ID(int arg_row)
        {
            int col_ct = 7;

            MyOraDB.ReDim_Parameter(col_ct);
            MyOraDB.Process_Name = "PKG_EDM_BATCH_01.RELEASE_MODEL_ID";

            // 파라미터 이름 설정
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
            MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
            MyOraDB.Parameter_Name[4] = "ARG_T_D";            
            MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";
            
            // 파라미터의 데이터 Type
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = fgrid_main[arg_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxFACTORY].ToString().Trim();
            MyOraDB.Parameter_Values[1] = fgrid_main[arg_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxMODEL_ID].ToString().Trim();
            MyOraDB.Parameter_Values[2] = fgrid_main[arg_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxSRF_NO].ToString().Trim();
            MyOraDB.Parameter_Values[3] = fgrid_main[arg_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxBOM_ID].ToString().Trim();
            MyOraDB.Parameter_Values[4] = fgrid_main[arg_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_POP_NEW.IxT_D].ToString().Trim();
            MyOraDB.Parameter_Values[5] = COM.ComVar.This_User;
            MyOraDB.Parameter_Values[6] = "";

            string factory = cmb_factory.SelectedValue.ToString();
            if (!factory.Equals("DS"))
            {
                if (factory.Equals("QD"))
                    COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;
                if (factory.Equals("VJ"))
                    COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;
            }
            else
            {
                COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
            }

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();
            COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;


            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }
        private bool UPDATE_DROP_YN(string []  arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);
                MyOraDB.Process_Name = "PKG_EDM_BATCH_01.UPDATE_DROP_YN";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4] = "ARG_T_D";
                MyOraDB.Parameter_Name[5] = "ARG_DROP_YN";
                MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";

                // 파라미터의 데이터 Type
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                                
                string factory = cmb_factory.SelectedValue.ToString();
                if (!factory.Equals("DS"))
                {
                    if (factory.Equals("QD"))
                        COM.ComVar._WebSvc.Url = COM.ComVar.QD_WebSvc_Url;
                    if (factory.Equals("VJ"))
                        COM.ComVar._WebSvc.Url = COM.ComVar.VJ_WebSvc_Url;
                }
                else
                {
                    COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
                }

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                COM.ComVar._WebSvc.Url = COM.ComVar.DS_WebSvc_Url;
                             
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }


        }        

        #endregion
    }
}



