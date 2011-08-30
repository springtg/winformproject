using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;


namespace FlexCDC.Plan
{
    public partial class Form_Sch_Sample_Schedule : COM.PCHWinForm.Form_Top
    {
        #region 사용자 정의 변수 
        
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성        
        #endregion

        #region 생성자
        public Form_Sch_Sample_Schedule()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Sch_Sample_Schedule_Load(object sender, EventArgs e)
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
            this.Text = "PCC_Sample Output Result";
            this.lbl_MainTitle.Text = "PCC_Sample Output Result";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            //Factory
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedIndex = 0;

            //Prod. Factory
            dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SXC35");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_p_factory, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_p_factory.SelectedIndex = 0;

            //Season
            dt_ret = SELECT_SEASON();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);            
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);

            dt_ret = SELECT_SEASON_DEFAULT();

            if (dt_ret.Rows.Count > 0)
            {
                string default_season = dt_ret.Rows[0].ItemArray[0].ToString().Trim();
                cmb_season_from.SelectedValue = default_season;
                cmb_season_to.SelectedValue = default_season;
            }
            else
            {
                cmb_season_from.SelectedValue = "201001";
                cmb_season_to.SelectedValue = "201001";
            }

            //Category
            dt_ret = SELECT_CATEGORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_category.SelectedIndex = 0;

            dt_ret = SELECT_ROUND();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round, 0, 1, true, 0, 120);
            cmb_round.SelectedIndex = 0;

            //User
            dt_ret = SELECT_USER();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_user.SelectedIndex = 0;

            //Need By
            dtp_need_from.Value = DateTime.Now.AddMonths(-6);
            dtp_need_to.Value = DateTime.Now.AddMonths(+2);

            //Sample DDD
            dtp_sample_from.Value = DateTime.Now.AddMonths(-6);
            dtp_sample_to.Value = DateTime.Now.AddMonths(+2);
            #endregion

            #region Grid Setting 
            //Main Grid
            fgrid_main.Set_Grid_CDC("SXC_SCH_SMP_SCHEDULE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.AllowSorting  = AllowSortingEnum.None;
            fgrid_main.ExtendLastCol = false;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxISSUE_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxISSUE_YMD).StyleNew.BackColor = Color.LightSkyBlue;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxISSUE_YMD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxISSUE_YMD).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxMAT_ETS, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxMAT_ETS).StyleNew.BackColor = Color.Ivory;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxMAT_ETS, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxMAT_ETS).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxSAMPLE_WS, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxSAMPLE_WS).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxSAMPLE_WS, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxSAMPLE_WS).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxSAMPLE_DDD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxSAMPLE_DDD).StyleNew.BackColor = Color.LightGreen;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxSAMPLE_DDD, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxSAMPLE_DDD).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxIDS_ETS, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxIDS_ETS).StyleNew.BackColor = Color.FromArgb(255, 255, 101); ;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxIDS_ETS, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxIDS_ETS).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxNEED_BY, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxNEED_BY).StyleNew.BackColor = Color.FromArgb(255, 210, 145);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxNEED_BY, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxNEED_BY).StyleNew.ForeColor = Color.Black;

            #endregion

            #region Control Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;

            txt_model.CharacterCasing = CharacterCasing.Upper;
            #endregion 
        }

        private DataTable SELECT_SEASON()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_SEASON";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = Proc_Name;
                                
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

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
        private DataTable SELECT_ROUND()
        {
            string Proc_Name = "PKG_SXC_SCH_03_SELECT.SELECT_ROUND";

            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                        
            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                        
            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }       
        private DataTable SELECT_USER()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_USER";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

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
        private DataTable SELECT_SEASON_DEFAULT()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_SEASON_DEFAULT";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_YEAR_MONTH";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = DateTime.Now.ToString("yyyyMM");
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

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Display_Data();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private void Display_Data()
        {
            fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

            string[] arg_value = new string[12];

            arg_value[0]  = cmb_factory.SelectedValue.ToString();
            arg_value[1]  = cmb_p_factory.SelectedValue.ToString();
            arg_value[2]  = cmb_season_from.SelectedValue.ToString();
            arg_value[3]  = cmb_season_to.SelectedValue.ToString();
            arg_value[4]  = cmb_category.SelectedValue.ToString();
            arg_value[5]  = cmb_round.SelectedValue.ToString();
            arg_value[6]  = txt_model.Text.Trim();
            arg_value[7]  = cmb_user.SelectedValue.ToString();
            arg_value[8]  = dtp_need_from.Value.ToString("yyyyMMdd");
            arg_value[9]  = dtp_need_to.Value.ToString("yyyyMMdd");
            arg_value[10] = dtp_sample_from.Value.ToString("yyyyMMdd");
            arg_value[11] = dtp_sample_to.Value.ToString("yyyyMMdd");

            DataTable dt_ret = SELECT_CFM_SCHEDULE(arg_value);

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_main.Rows.Add();

                for (int j = 0; j < fgrid_main.Cols.Count; j++)
                {
                    fgrid_main[fgrid_main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();
                }
            }

            if (dt_ret.Rows.Count > 0)
            {
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxISSUE_YMD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxISSUE_YMD).StyleNew.BackColor = Color.FromArgb(192, 236, 251);
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxMAT_ETS, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxMAT_ETS).StyleNew.BackColor = Color.FromArgb(247, 251, 251);
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxSAMPLE_WS, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxSAMPLE_WS).StyleNew.BackColor = Color.FromArgb(254, 239, 220);
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxSAMPLE_DDD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxSAMPLE_DDD).StyleNew.BackColor = Color.FromArgb(223, 250, 197);
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxIDS_ETS, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxIDS_ETS).StyleNew.BackColor = Color.FromArgb(255, 255, 156);
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxNEED_BY, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxNEED_BY).StyleNew.BackColor = Color.FromArgb(255, 239, 190);
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxIPW_YMD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_SMP_SCHEDULE.IxUPD_YMD).StyleNew.BackColor = Color.White;
            }
        }

        private DataTable SELECT_CFM_SCHEDULE(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(13);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_SAMPLE_SCHEDULE";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_P_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[3] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[5] = "ARG_ROUND";
                MyOraDB.Parameter_Name[6] = "ARG_MODEL";
                MyOraDB.Parameter_Name[7] = "ARG_USER";
                MyOraDB.Parameter_Name[8] = "ARG_NEED_FROM";
                MyOraDB.Parameter_Name[9] = "ARG_NEED_TO";
                MyOraDB.Parameter_Name[10] = "ARG_SAMPLE_FROM";
                MyOraDB.Parameter_Name[11] = "ARG_SAMPLE_TO";
                MyOraDB.Parameter_Name[12] = "OUT_CURSOR";
                
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
                MyOraDB.Parameter_Type[12] = (int)OracleType.Cursor;

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
                MyOraDB.Parameter_Values[12] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;  
            }
        }
        #endregion

        #region Grid Event
        private void fgrid_main_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                
            }
            catch
            {
 
            }
        }

        private void fgrid_main_EnterCell(object sender, EventArgs e)
        {
           
        }
        private void fgrid_main_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                
            }
            catch
            {

            }
        }
        #endregion                                      

        
    }
}


