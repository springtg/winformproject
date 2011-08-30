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
    public partial class Form_Sch_CFM_Schedule : COM.PCHWinForm.Form_Top
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private bool chk_flg = false;
        #endregion

        #region 생성자
        public Form_Sch_CFM_Schedule()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_Sch_CFM_Schedule_Load(object sender, EventArgs e)
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
            this.Text = "PCC_CFM Schedule";
            this.lbl_MainTitle.Text = "PCC_CFM Schedule";
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
            cmb_season_from.SelectedValue = "201004";
            cmb_season_to.SelectedValue = "201102";

            //dt_ret = SELECT_SEASON_DEFAULT();

            //if (dt_ret.Rows.Count > 0)
            //{
            //    string default_season = dt_ret.Rows[0].ItemArray[0].ToString().Trim();
            //    cmb_season_from.SelectedValue = default_season;
            //    cmb_season_to.SelectedValue = default_season;
            //}
            //else
            //{
            //    cmb_season_from.SelectedValue = "201001";
            //    cmb_season_to.SelectedValue = "201001";
            //}

            //Category
            dt_ret = SELECT_CATEGORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_category.SelectedIndex = 0;

            //User
            dt_ret = SELECT_USER();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_user.SelectedIndex = 0;
            #endregion

            #region Grid Setting 
            //Main Grid
            fgrid_main.Set_Grid_CDC("SXC_SCH_CFM_SCHEDULE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.AllowSorting  = AllowSortingEnum.None;
            fgrid_main.ExtendLastCol = false;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_TA, fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_AC).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_TA, fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_AC).StyleNew.ForeColor = Color.Black;
            
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_AC).StyleNew.BackColor = Color.LightSkyBlue;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_AC).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_AC).StyleNew.BackColor = Color.Ivory;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_AC).StyleNew.ForeColor = Color.Black;            

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_AC).StyleNew.BackColor = Color.LightGreen;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_AC).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_AC).StyleNew.BackColor = Color.FromArgb(255, 255, 101);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_AC).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_AC).StyleNew.BackColor = Color.FromArgb(255, 210, 145);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_AC).StyleNew.ForeColor = Color.Black;


            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_TA, fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_AC).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_TA, fgrid_main.Rows.Fixed - 2, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_AC).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_AC).StyleNew.BackColor = Color.LightSkyBlue;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_AC).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_AC).StyleNew.BackColor = Color.Ivory;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_AC).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_AC).StyleNew.BackColor = Color.LightGreen;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_AC).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_AC).StyleNew.BackColor = Color.FromArgb(255, 255, 101); ;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_AC).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_AC).StyleNew.BackColor = Color.FromArgb(255, 210, 145);
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_TA, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_AC).StyleNew.ForeColor = Color.Black;
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

            string[] arg_value = new string[7];

            arg_value[0] = cmb_factory.SelectedValue.ToString();
            arg_value[1] = cmb_p_factory.SelectedValue.ToString();
            arg_value[2] = cmb_season_from.SelectedValue.ToString();
            arg_value[3] = cmb_season_to.SelectedValue.ToString();
            arg_value[4] = cmb_category.SelectedValue.ToString();
            arg_value[5] = txt_model.Text.Trim();
            arg_value[6] = cmb_user.SelectedValue.ToString();

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
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxDPO_QTY, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxCDC_DEV).StyleNew.BackColor = Color.White;
                

                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxFGA_YMD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxUPD_YMD).StyleNew.BackColor = Color.White;
                fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxSHIP_YMD, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxSHIP_YMD).StyleNew.BackColor = Color.FromArgb(254, 239, 220);

                CellRange cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_TA, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_AC);
                CellStyle cellst = fgrid_main.Styles.Add("DATETIME_PFC");
                cellst.DataType = typeof(DateTime);
                cellst.Format = "yyyyMMdd";
                cellst.BackColor = Color.FromArgb(192, 236, 251);
                cellst.TextAlign = TextAlignEnum.CenterCenter;
                cellrg.Style = fgrid_main.Styles["DATETIME_PFC"];
                cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_TA, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_AC);
                cellrg.Style = fgrid_main.Styles["DATETIME_PFC"];

                cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_TA, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_AC);
                cellst = fgrid_main.Styles.Add("DATETIME_YIELD");
                cellst.DataType = typeof(DateTime);
                cellst.Format = "yyyyMMdd";
                cellst.BackColor = Color.FromArgb(247, 251, 251);
                cellst.TextAlign = TextAlignEnum.CenterCenter;
                cellrg.Style = fgrid_main.Styles["DATETIME_YIELD"];
                cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_TA, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_AC);
                cellrg.Style = fgrid_main.Styles["DATETIME_YIELD"];

                cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_TA, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_AC);
                cellst = fgrid_main.Styles.Add("DATETIME_SPEC");
                cellst.DataType = typeof(DateTime);
                cellst.Format = "yyyyMMdd";
                cellst.BackColor = Color.FromArgb(223, 250, 197);
                cellst.TextAlign = TextAlignEnum.CenterCenter;
                cellrg.Style = fgrid_main.Styles["DATETIME_SPEC"];
                cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_TA, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_AC);
                cellrg.Style = fgrid_main.Styles["DATETIME_SPEC"];

                cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_TA, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_AC);
                cellst = fgrid_main.Styles.Add("DATETIME_SBOOK");
                cellst.DataType = typeof(DateTime);
                cellst.Format = "yyyyMMdd";
                cellst.BackColor = Color.FromArgb(223, 250, 197);
                cellst.TextAlign = TextAlignEnum.CenterCenter;
                cellrg.Style = fgrid_main.Styles["DATETIME_SBOOK"];
                cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_TA, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_AC);
                cellrg.Style = fgrid_main.Styles["DATETIME_SBOOK"];

                cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_TA, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_AC);
                cellst = fgrid_main.Styles.Add("DATETIME_CFM");
                cellst.DataType = typeof(DateTime);
                cellst.Format = "yyyyMMdd";
                cellst.BackColor = Color.FromArgb(255, 239, 190);
                cellst.TextAlign = TextAlignEnum.CenterCenter;
                cellrg.Style = fgrid_main.Styles["DATETIME_CFM"];
                cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_TA, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_AC);
                cellrg.Style = fgrid_main.Styles["DATETIME_CFM"];

            }
        }

        private DataTable SELECT_CFM_SCHEDULE(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(8);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_CFM_SCHEDULE";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_P_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[3] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[5] = "ARG_MODEL";
                MyOraDB.Parameter_Name[6] = "ARG_USER";
                MyOraDB.Parameter_Name[7] = "OUT_CURSOR";
                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = "";

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

                SAVE_DATA();
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

        private void SAVE_DATA()
        {
            int vcnt = 24;

            MyOraDB.ReDim_Parameter(vcnt);
            MyOraDB.Process_Name = "PKG_SXC_SCH_03.SAVE_SXC_SCH_CFM";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_P_FACTORY";
            MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[3] = "ARG_G_PFC_YMD_TA";
            MyOraDB.Parameter_Name[4] = "ARG_G_PFC_YMD_AC";
            MyOraDB.Parameter_Name[5] = "ARG_G_YIELD_YMD_TA";
            MyOraDB.Parameter_Name[6] = "ARG_G_YIELD_YMD_AC";
            MyOraDB.Parameter_Name[7] = "ARG_G_SPEC_YMD_TA";
            MyOraDB.Parameter_Name[8] = "ARG_G_SPEC_YMD_AC";
            MyOraDB.Parameter_Name[9] = "ARG_G_S_BOOK_YMD_TA";
            MyOraDB.Parameter_Name[10] = "ARG_G_S_BOOK_YMD_AC";
            MyOraDB.Parameter_Name[11] = "ARG_G_CFM_YMD_TA";
            MyOraDB.Parameter_Name[12] = "ARG_G_CFM_YMD_AC";
            MyOraDB.Parameter_Name[13] = "ARG_C_PFC_YMD_TA";
            MyOraDB.Parameter_Name[14] = "ARG_C_PFC_YMD_AC";
            MyOraDB.Parameter_Name[15] = "ARG_C_YIELD_YMD_TA";
            MyOraDB.Parameter_Name[16] = "ARG_C_YIELD_YMD_AC";
            MyOraDB.Parameter_Name[17] = "ARG_C_SPEC_YMD_TA";
            MyOraDB.Parameter_Name[18] = "ARG_C_SPEC_YMD_AC";
            MyOraDB.Parameter_Name[19] = "ARG_C_S_BOOK_YMD_TA";
            MyOraDB.Parameter_Name[20] = "ARG_C_S_BOOK_YMD_AC";
            MyOraDB.Parameter_Name[21] = "ARG_C_CFM_YMD_TA";
            MyOraDB.Parameter_Name[22] = "ARG_C_CFM_YMD_AC";
            MyOraDB.Parameter_Name[23] = "ARG_UPD_USER";

            for (int para = 0; para < vcnt; para++)
            {
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }

            int vRow = 0;
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                string _div = fgrid_main[i, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxDIV].ToString().Trim();

                if (!_div.Equals(""))
                {
                    vRow++;
                }
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++)
            {
                string _div = fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxDIV].ToString().Trim();

                if (_div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxFACTORY].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxP_FACTORY].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = fgrid_main[row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxSTYLE_CD].ToString().Trim().Replace("-", "");
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_TA);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_AC);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_TA);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_AC);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_TA);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_AC);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_TA);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_AC);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_TA);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_AC);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_TA);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_AC);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_TA);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_AC);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_TA);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_AC);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_TA);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_AC);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_TA);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_AC);
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;          
            }                                                                     

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

            fgrid_main.ClearFlags();
        }
        private string GET_GRID_DATA_CHANGE(int arg_row, int arg_col)
        {
            string value = "";

            try
            {
                value = Convert.ToDateTime(fgrid_main[arg_row, arg_col].ToString().Trim()).ToString("yyyyMMdd");
            }
            catch
            {
                value = (fgrid_main[arg_row, arg_col] == null) ? "" : fgrid_main[arg_row, arg_col].ToString().Trim();
            }

            return value;
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
                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;
                string _value = "";

                try
                {
                    _value = Convert.ToDateTime(fgrid_main[sct_row, sct_col].ToString().Trim()).ToString("yyyyMMdd");
                }
                catch
                {
                    _value = (fgrid_main[sct_row, sct_col] == null) ? "" : fgrid_main[sct_row, sct_col].ToString().Trim();
                }

                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxDIV] = "U";
                    fgrid_main[sct_rows[i], sct_col] = _value;
                }
            }
            catch
            {

            }
        }
        private void fgrid_main_BeforeEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;

                string cell_value = (fgrid_main[sct_row, sct_col] == null) ? "" : fgrid_main[sct_row, sct_col].ToString();

                if (!cell_value.Equals(""))
                {
                    try
                    {
                        if (cell_value.Length > 8)
                        {
                            fgrid_main.Buffer_CellData = cell_value;
                        }
                        else
                        {
                            int year  = int.Parse(cell_value.Substring(0, 4));
                            int month = int.Parse(cell_value.Substring(4, 2));
                            int day   = int.Parse(cell_value.Substring(6, 2));

                            DateTime dt = new DateTime(year, month, day);

                            fgrid_main.Buffer_CellData = dt.ToString();
                        }
                    }
                    catch
                    {
                        fgrid_main.Buffer_CellData = DateTime.Now.ToString();
                    }

                    fgrid_main[sct_row, sct_col] = fgrid_main.Buffer_CellData.ToString();
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

        #region CheckBox Event
        private void chk_cfm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                if (chk_cfm.Checked)
                {
                    chk_flg = true;
                    chk_gtm.Checked = false;
                    chk_flg = false;

                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_AC].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_TA].Visible  = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_AC].Visible  = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_TA].Visible   = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_AC].Visible   = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_TA].Visible = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_AC].Visible = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_AC].Visible    = false;

                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_AC].Visible    = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_TA].Visible  = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_AC].Visible  = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_TA].Visible   = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_AC].Visible   = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_TA].Visible = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_AC].Visible = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_AC].Visible    = true;

                }
                else
                {
                    chk_flg = true;
                    chk_gtm.Checked = true;
                    chk_flg = false;
                    
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_AC].Visible    = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_TA].Visible  = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_AC].Visible  = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_TA].Visible   = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_AC].Visible   = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_TA].Visible = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_AC].Visible = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_AC].Visible    = true;

                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_AC].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_TA].Visible  = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_AC].Visible  = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_TA].Visible   = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_AC].Visible   = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_TA].Visible = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_AC].Visible = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_AC].Visible    = false;
                }
            }
            catch
            {
 
            }
        }

        private void chk_gtm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                if (chk_gtm.Checked)
                {
                    chk_flg = true;
                    chk_cfm.Checked = false;
                    chk_flg = false;

                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_AC].Visible    = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_TA].Visible  = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_AC].Visible  = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_TA].Visible   = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_AC].Visible   = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_TA].Visible = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_AC].Visible = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_AC].Visible    = true;

                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_AC].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_TA].Visible  = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_AC].Visible  = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_TA].Visible   = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_AC].Visible   = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_TA].Visible = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_AC].Visible = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_AC].Visible    = false;
                }
                else
                {
                    chk_flg = true;
                    chk_cfm.Checked = true;
                    chk_flg = false;

                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_PFC_YMD_AC].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_TA].Visible  = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_YIELD_YMD_AC].Visible  = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_TA].Visible   = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_SPEC_YMD_AC].Visible   = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_TA].Visible = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_S_BOOK_YMD_AC].Visible = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxG_CFM_YMD_AC].Visible    = false;

                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_PFC_YMD_AC].Visible    = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_TA].Visible  = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_YIELD_YMD_AC].Visible  = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_TA].Visible   = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_SPEC_YMD_AC].Visible   = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_TA].Visible = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_S_BOOK_YMD_AC].Visible = true;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_TA].Visible    = false;
                    fgrid_main.Cols[(int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxC_CFM_YMD_AC].Visible    = true;
                }
            }
            catch
            {

            }
        }
        #endregion

        #region ContextMenu Event
        private void mnu_data_clear_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;

                fgrid_main[sct_row, sct_col] = null;
                fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_CFM_SCHEDULE.IxDIV] = "U";
            }
            catch
            {
 
            }
        }
        #endregion

        
    }
}

