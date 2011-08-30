using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Plan
{
    public partial class Pop_Sch_ValueChange_01 : COM.PCHWinForm.Pop_Large_B
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private Plan.Form_Sch_Management_02 _main_form = null;
        private string _form_type = "";
        #endregion
        
        #region Resource
        public Pop_Sch_ValueChange_01()
        {
            InitializeComponent();            
        }
        public Pop_Sch_ValueChange_01(Plan.Form_Sch_Management_02 arg_form)
        {
            InitializeComponent();
            _main_form = arg_form;
        }
        
        #endregion

        #region Form Loading
        private void Pop_Sch_ValueChange_01_Load(object sender, EventArgs e)
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
            //1. Title Setting
            this.Text = "Model Info. Change";
            this.lbl_MainTitle.Text = "Model Info. Change";
            ClassLib.ComFunction.SetLangDic(this);            

            //2. tbtn Button Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = false;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Conform.Enabled = false;
            tbtn_Create.Enabled  = false;

            DataTable dt_ret = SELECT_CATEGORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);


            Control_Setting();
        }

        private void Control_Setting()
        {
            int sct_row = _main_form.fgrid_main.Selection.r1;


            cmb_category.SelectedValue = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxCATEGORY].ToString().Trim();
            txt_model.Text             = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTYLE_NAME].ToString().Trim();
            txt_gender.Text            = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxGENDER].ToString().Trim();
            txt_td.Text                = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxTD].ToString().Trim();            
        }

        private DataTable SELECT_CATEGORY()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_CATEGORY";

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
            catch
            {
                return null;
            }
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                int sct_row = _main_form.fgrid_main.Selection.r1;

                string[] arg_value = new string[7];

                arg_value[0] = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                arg_value[1] = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                arg_value[2] = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
                arg_value[3] = cmb_category.SelectedValue.ToString().Trim();
                arg_value[4] = txt_model.Text.Trim();
                arg_value[5] = txt_gender.Text.Trim();
                arg_value[6] = txt_td.Text.Trim();


                if (UPDATE_SXC_SCH_HEAD_DESC(arg_value))
                {
                    _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxCATEGORY]   = arg_value[3];
                    _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxCATEGORY_V] = cmb_category.SelectedText.Trim();
                    _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxITEM_NAME]  = arg_value[4];
                    _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSTYLE_NAME] = arg_value[4];
                    _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxGENDER]     = arg_value[5];
                    _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxTD]         = arg_value[6];

                    this.Close();
                }


            }
            catch
            {
 
            }
        }

        private bool UPDATE_SXC_SCH_HEAD_DESC(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(8);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.UPDATE_SXC_SCH_HEAD_DESC";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[4] = "ARG_MODEL_NAME";
                MyOraDB.Parameter_Name[5] = "ARG_GENDER";
                MyOraDB.Parameter_Name[6] = "ARG_TD_CODE";
                MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

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

