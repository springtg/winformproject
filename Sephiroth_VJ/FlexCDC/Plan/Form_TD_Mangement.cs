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
    public partial class Form_TD_Mangement : COM.PCHWinForm.Form_Top
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성

        private string[] nf_cd_dev  = new string[(int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxMAX_CNT];
        private string[] nf_cd_comm = new string[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxMAX_CNT];

        private bool grid_flg = false;

        private string power_level = COM.ComVar.This_CDCPower_Level;
        #endregion

        #region 생성자
        public Form_TD_Mangement()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loading
        private void Form_TD_Mangement_Load(object sender, EventArgs e)
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
            this.Text = "PCC_Master Schedule / Season";
            this.lbl_MainTitle.Text = "PCC_Master Schedule / Season";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            // Factory
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedIndex = 0;

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

                cmb_season_from.SelectedIndex = cmb_season_from.SelectedIndex + 2;
                cmb_season_to.SelectedIndex = cmb_season_to.SelectedIndex - 3;
            }
            else
            {
                cmb_season_from.SelectedValue = "201001";
                cmb_season_to.SelectedValue = "201001";
            }

            //Prod. Factory
            dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SXC35");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_p_factory, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_p_factory.SelectedIndex = 0;
            cmb_p_factory.Enabled = false;

            //Category
            string arg_division = "DEV";
            if (tabControl1.SelectedIndex.Equals(1))
                arg_division = "COMM";

            dt_ret = SELECT_CATEGORY(arg_division);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_category.SelectedIndex = 0;
            #endregion

            #region Grid Setting 
            
            #region Dev Grid
            fgrid_dev.Set_Grid_CDC("SXC_TD_MANAGEMENT_DEV", "1", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_dev.Set_Action_Image(img_Action);
            fgrid_dev.AllowDragging = AllowDraggingEnum.None;
            fgrid_dev.AllowSorting = AllowSortingEnum.None;
            fgrid_dev.ExtendLastCol = false;

            fgrid_dev.GetCellRange(fgrid_dev.Rows.Fixed - 3, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_010_YMD, fgrid_dev.Rows.Fixed - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_090_YMD).StyleNew.BackColor = Color.LightGreen;
            fgrid_dev.GetCellRange(fgrid_dev.Rows.Fixed - 3, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_010_YMD, fgrid_dev.Rows.Fixed - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_090_YMD).StyleNew.ForeColor = Color.Black;
            #endregion

            #region Comm Grid
            fgrid_main.Set_Grid_CDC("SXC_TD_MANAGEMENT_COMM", "1", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.AllowSorting  = AllowSortingEnum.None;           
            fgrid_main.ExtendLastCol = false;
            
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_YN, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_280_DAYS).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_YN, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_280_DAYS).StyleNew.ForeColor = Color.Black;

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_290_YN, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_DAYS).StyleNew.BackColor = Color.LightGoldenrodYellow;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 3, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_290_YN, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_DAYS).StyleNew.ForeColor = Color.Black;

            CellStyle cellst = fgrid_main.Styles.Add("P_FACTORY");
            cellst.TextAlign = TextAlignEnum.LeftCenter;
            CellRange cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxP_FACOTRY_V, fgrid_main.Rows.Fixed - 4, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxP_FACOTRY_V);
            cellrg.Style = fgrid_main.Styles["P_FACTORY"];

            cellst = fgrid_main.Styles.Add("MST_TITLE");
            cellst.TextAlign = TextAlignEnum.LeftCenter;
            cellst.BackColor = Color.LightPink;
            cellst.ForeColor = Color.Black;            
            cellrg = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_YN, fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_280_DAYS);
            cellrg.Style = fgrid_main.Styles["MST_TITLE"];

            for (int j = (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_YN; j <= (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_DAYS; j++)
            {
                fgrid_main.Cols[j].AllowEditing = true;
            }
            #endregion

            #region Task Grid
            fgrid_task.Set_Grid_CDC("SXC_TD_MANAGEMENT_TASK", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_task.Set_Action_Image(img_Action);
            fgrid_task.AllowDragging = AllowDraggingEnum.None;
            fgrid_task.AllowSorting = AllowSortingEnum.None;

            fgrid_task.ExtendLastCol = false;
            fgrid_task.AllowDragging = AllowDraggingEnum.None;
            #endregion

            #endregion

            #region Control Setting
            if (power_level.Equals("D00") || power_level.Equals("S00"))
            {
                tbtn_New.Enabled     = false;
                tbtn_Search.Enabled  = true;
                tbtn_Save.Enabled    = true;
                tbtn_Delete.Enabled  = false;
                tbtn_Print.Enabled   = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Create.Enabled  = false;                
            }
            else
            {
                tbtn_New.Enabled     = false;
                tbtn_Search.Enabled  = true;
                tbtn_Save.Enabled    = false;
                tbtn_Delete.Enabled  = false;
                tbtn_Print.Enabled   = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Create.Enabled  = false;

                fgrid_dev.AllowEditing = false;
                fgrid_main.AllowEditing = false;
                fgrid_task.AllowEditing = false;

                fgrid_dev.ContextMenu = null;
                fgrid_main.ContextMenu = null;
                fgrid_task.ContextMenu = null;
                
            }

            mnu_insert.Enabled = false;
            mnu_delete.Enabled = false;

            #endregion

            GET_NF_CD();
        }
        private void GET_NF_CD()
        {
            nf_cd_dev[(int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_010_YMD] = "010";
            nf_cd_dev[(int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_020_YMD] = "020";
            nf_cd_dev[(int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_030_YMD] = "030";
            nf_cd_dev[(int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_040_YMD] = "040";
            nf_cd_dev[(int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_050_YMD] = "050";
            nf_cd_dev[(int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_060_YMD] = "060";
            nf_cd_dev[(int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_070_YMD] = "070";
            nf_cd_dev[(int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_080_YMD] = "080";
            nf_cd_dev[(int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_090_YMD] = "090";            

            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_YN  ] = "100";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_DAYS] = "100";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_110_YN  ] = "110";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_110_DAYS] = "110";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_120_YN  ] = "120";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_120_DAYS] = "120";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_130_YN  ] = "130";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_130_DAYS] = "130";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_140_YN  ] = "140";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_140_DAYS] = "140";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_150_YN  ] = "150";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_150_DAYS] = "150";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_160_YN  ] = "160";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_160_DAYS] = "160";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_170_YN  ] = "170";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_170_DAYS] = "170";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_180_YN  ] = "180";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_180_DAYS] = "180";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_190_YN  ] = "190";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_190_DAYS] = "190";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_200_YN  ] = "200";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_200_DAYS] = "200";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_210_YN  ] = "210";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_210_DAYS] = "210";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_220_YN  ] = "220";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_220_DAYS] = "220";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_230_YN  ] = "230";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_230_DAYS] = "230";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_240_YN  ] = "240";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_240_DAYS] = "240";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_250_YN  ] = "250";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_250_DAYS] = "250";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_260_YN  ] = "260";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_260_DAYS] = "260";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_270_YN  ] = "270";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_270_DAYS] = "270";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_280_YN  ] = "280";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_280_DAYS] = "280";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_290_YN  ] = "290";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_290_DAYS] = "290";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_YN  ] = "300";
            nf_cd_comm[(int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_DAYS] = "300";
        }

        private DataTable SELECT_CATEGORY(string arg_division)
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_CATEGORY";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_division;
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
            if (tabControl1.SelectedIndex.Equals(0))
            {
                grid_flg = true;
                fgrid_dev.Rows.Count = fgrid_dev.Rows.Fixed;

                string[] arg_value = new string[6];
                arg_value[0] = "DEV";
                arg_value[1] = cmb_factory.SelectedValue.ToString().Trim();
                arg_value[2] = cmb_p_factory.SelectedValue.ToString().Trim();
                arg_value[3] = cmb_season_from.SelectedValue.ToString().Trim();
                arg_value[4] = cmb_season_to.SelectedValue.ToString().Trim();
                arg_value[5] = cmb_category.SelectedValue.ToString().Trim();

                DataTable dt_ret = SELECT_TD_MANAGEMENT(arg_value);

                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {
                    fgrid_dev.Rows.Add();

                    for (int j = 0; j < fgrid_dev.Cols.Count; j++)
                    {
                        fgrid_dev[fgrid_dev.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();
                    }
                }

                if (dt_ret.Rows.Count > 0)
                {
                    CellRange cellrg = fgrid_dev.GetCellRange(fgrid_dev.Rows.Fixed, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_010_YMD, fgrid_dev.Rows.Count - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_090_YMD);
                    CellStyle cellst = fgrid_dev.Styles.Add("DATE_TIME");
                    cellst.DataType = typeof(DateTime);
                    cellst.Format = "yyyyMMdd";
                    cellst.TextAlign = TextAlignEnum.CenterCenter;
                    cellst.BackColor = Color.MintCream;
                    cellst.ForeColor = Color.Black;
                    cellrg.Style = fgrid_dev.Styles["DATE_TIME"];
                    
                    fgrid_dev.GetCellRange(fgrid_dev.Rows.Fixed, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxUPD_USER, fgrid_dev.Rows.Count - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxUPD_YMD).StyleNew.BackColor = Color.White;

                    grid_flg = false; 
                    fgrid_dev.Select(fgrid_dev.Rows.Fixed, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_020_YMD);
                    fgrid_dev_AfterSelChange(null, null);
                }

                grid_flg = false;
                
            }
            else if (tabControl1.SelectedIndex.Equals(1))
            {
                grid_flg = true;
                fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

                string[] arg_value = new string[6];
                arg_value[0] = "COMM";
                arg_value[1] = cmb_factory.SelectedValue.ToString().Trim();
                arg_value[2] = cmb_p_factory.SelectedValue.ToString().Trim();
                arg_value[3] = cmb_season_from.SelectedValue.ToString().Trim();
                arg_value[4] = cmb_season_to.SelectedValue.ToString().Trim();
                arg_value[5] = cmb_category.SelectedValue.ToString().Trim();

                DataTable dt_ret = SELECT_TD_MANAGEMENT(arg_value);

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
                    fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_YN, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_280_DAYS).StyleNew.BackColor = Color.Snow;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_290_YN, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_DAYS).StyleNew.BackColor = Color.LightYellow;
                    fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxSTATUS, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxUPD_YMD).StyleNew.BackColor = Color.White;

                    grid_flg = false; 
                    fgrid_main.Select(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_DAYS);
                    fgrid_main_AfterSelChange(null, null);
                }

                grid_flg = false;                
            }

            
        }
        private DataTable SELECT_TD_MANAGEMENT(string [] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_TD_TYPE_MANAGEMENT";

                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_P_FACTORY";
                MyOraDB.Parameter_Name[3] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[4] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[5] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = "";

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
                if (tabControl1.SelectedIndex.Equals(0))
                {
                    SAVE_DEV_DATA();
                    fgrid_dev.ClearFlags(); 
                }
                else
                {
                    SAVE_COMM_DATA();
                    fgrid_main.ClearFlags(); 
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

        private void SAVE_DEV_DATA()
        {
            int vcnt = 13;

            MyOraDB.ReDim_Parameter(vcnt);
            MyOraDB.Process_Name = "PKG_SXC_SCH_02.SAVE_TD_MANAGEMENT_DEV";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[2] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[3] = "ARG_NF_010_YMD";
            MyOraDB.Parameter_Name[4] = "ARG_NF_020_YMD";
            MyOraDB.Parameter_Name[5] = "ARG_NF_030_YMD";
            MyOraDB.Parameter_Name[6] = "ARG_NF_040_YMD";
            MyOraDB.Parameter_Name[7] = "ARG_NF_050_YMD";
            MyOraDB.Parameter_Name[8] = "ARG_NF_060_YMD";
            MyOraDB.Parameter_Name[9] = "ARG_NF_070_YMD";
            MyOraDB.Parameter_Name[10] = "ARG_NF_080_YMD";
            MyOraDB.Parameter_Name[11] = "ARG_NF_090_YMD";
            MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";
                                               
            for (int para = 0; para < vcnt; para++)
            {                      
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }                      

            int vRow = 0;
            for (int i = fgrid_dev.Rows.Fixed; i < fgrid_dev.Rows.Count; i++)
            {
                string _div = fgrid_dev[i, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxDIVISION].ToString().Trim();

                if (!_div.Equals(""))
                {
                    vRow++;
                }
            }

            vcnt = vcnt * vRow;
            MyOraDB.Parameter_Values = new string[vcnt];
            vcnt = 0;

            for (int row = fgrid_dev.Rows.Fixed; row < fgrid_dev.Rows.Count; row++)
            {
                string _div = fgrid_dev[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxDIVISION].ToString().Trim();

                if (_div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = (fgrid_dev[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxFACTORY]    == null) ? "" : fgrid_dev[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxFACTORY].ToString().Trim();   
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_dev[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxSEASON_CD]  == null) ? "" : fgrid_dev[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxSEASON_CD].ToString().Trim(); 
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_dev[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxCATEGORY]   == null) ? "" : fgrid_dev[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxCATEGORY].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_010_YMD);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_020_YMD);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_030_YMD);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_040_YMD);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_050_YMD);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_060_YMD);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_070_YMD);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_080_YMD);
                MyOraDB.Parameter_Values[vcnt++] = GET_GRID_DATA_CHANGE(row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_090_YMD);
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();            
        }
        private string GET_GRID_DATA_CHANGE(int arg_row, int arg_col)
        {
            string value = "";

            try
            {
                value = Convert.ToDateTime(fgrid_dev[arg_row, arg_col].ToString().Trim()).ToString("yyyyMMdd");
            }
            catch
            {
                value = (fgrid_dev[arg_row, arg_col] == null) ? "" : fgrid_dev[arg_row, arg_col].ToString().Trim();
            }

            return value;
        }

        private void SAVE_COMM_DATA()
        {
            int vcnt = 48;

            MyOraDB.ReDim_Parameter(vcnt);
            MyOraDB.Process_Name = "PKG_SXC_SCH_02.SAVE_TD_MANAGEMENT_COMM";

            MyOraDB.Parameter_Name[0 ] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1 ] = "ARG_P_FACTORY";
            MyOraDB.Parameter_Name[2 ] = "ARG_SEASON_CD";
            MyOraDB.Parameter_Name[3 ] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[4 ] = "ARG_T_D";
            MyOraDB.Parameter_Name[5] = "ARG_NF_100_YN";
            MyOraDB.Parameter_Name[6] = "ARG_NF_100_DAYS";
            MyOraDB.Parameter_Name[7] = "ARG_NF_110_YN";
            MyOraDB.Parameter_Name[8] = "ARG_NF_110_DAYS";
            MyOraDB.Parameter_Name[9] = "ARG_NF_120_YN";
            MyOraDB.Parameter_Name[10] = "ARG_NF_120_DAYS";
            MyOraDB.Parameter_Name[11] = "ARG_NF_130_YN";
            MyOraDB.Parameter_Name[12] = "ARG_NF_130_DAYS";
            MyOraDB.Parameter_Name[13] = "ARG_NF_140_YN";
            MyOraDB.Parameter_Name[14] = "ARG_NF_140_DAYS";
            MyOraDB.Parameter_Name[15] = "ARG_NF_150_YN";
            MyOraDB.Parameter_Name[16] = "ARG_NF_150_DAYS";
            MyOraDB.Parameter_Name[17] = "ARG_NF_160_YN";
            MyOraDB.Parameter_Name[18] = "ARG_NF_160_DAYS";
            MyOraDB.Parameter_Name[19] = "ARG_NF_170_YN";
            MyOraDB.Parameter_Name[20] = "ARG_NF_170_DAYS";
            MyOraDB.Parameter_Name[21] = "ARG_NF_180_YN";
            MyOraDB.Parameter_Name[22] = "ARG_NF_180_DAYS";
            MyOraDB.Parameter_Name[23] = "ARG_NF_190_YN";
            MyOraDB.Parameter_Name[24] = "ARG_NF_190_DAYS";
            MyOraDB.Parameter_Name[25] = "ARG_NF_200_YN";
            MyOraDB.Parameter_Name[26] = "ARG_NF_200_DAYS";
            MyOraDB.Parameter_Name[27] = "ARG_NF_210_YN";
            MyOraDB.Parameter_Name[28] = "ARG_NF_210_DAYS";
            MyOraDB.Parameter_Name[29] = "ARG_NF_220_YN";
            MyOraDB.Parameter_Name[30] = "ARG_NF_220_DAYS";
            MyOraDB.Parameter_Name[31] = "ARG_NF_230_YN";
            MyOraDB.Parameter_Name[32] = "ARG_NF_230_DAYS";
            MyOraDB.Parameter_Name[33] = "ARG_NF_240_YN";
            MyOraDB.Parameter_Name[34] = "ARG_NF_240_DAYS";
            MyOraDB.Parameter_Name[35] = "ARG_NF_250_YN";
            MyOraDB.Parameter_Name[36] = "ARG_NF_250_DAYS";
            MyOraDB.Parameter_Name[37] = "ARG_NF_260_YN";
            MyOraDB.Parameter_Name[38] = "ARG_NF_260_DAYS";
            MyOraDB.Parameter_Name[39] = "ARG_NF_270_YN";
            MyOraDB.Parameter_Name[40] = "ARG_NF_270_DAYS";
            MyOraDB.Parameter_Name[41] = "ARG_NF_280_YN";
            MyOraDB.Parameter_Name[42] = "ARG_NF_280_DAYS";
            MyOraDB.Parameter_Name[43] = "ARG_NF_290_YN";
            MyOraDB.Parameter_Name[44] = "ARG_NF_290_DAYS";
            MyOraDB.Parameter_Name[45] = "ARG_NF_300_YN";
            MyOraDB.Parameter_Name[46] = "ARG_NF_300_DAYS";
            MyOraDB.Parameter_Name[47] = "ARG_UPD_USER";
                                               
            for (int para = 0; para < vcnt; para++)
            {                      
                MyOraDB.Parameter_Type[para] = (int)OracleType.VarChar;
            }                      

            int vRow = 0;
            for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
            {
                string _div = fgrid_main[i, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxDIVISION].ToString().Trim();

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
                string _div = fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxDIVISION].ToString().Trim();

                if (_div.Equals(""))
                    continue;

                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxFACTORY]   == null) ? ""      : fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxFACTORY].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxP_FACTORY] == null) ? ""      : fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxP_FACTORY].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxSEASON_CD] == null) ? ""      : fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxSEASON_CD].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxCATEGORY]  == null) ? ""      : fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxCATEGORY].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxTD_CD]     == null) ? ""      : fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxTD_CD].ToString().Trim();                
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_110_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_110_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_110_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_110_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_120_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_120_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_120_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_120_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_130_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_130_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_130_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_130_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_140_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_140_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_140_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_140_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_150_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_150_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_150_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_150_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_160_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_160_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_160_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_160_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_170_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_170_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_170_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_170_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_180_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_180_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_180_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_180_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_190_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_190_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_190_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_190_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_200_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_200_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_200_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_200_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_210_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_210_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_210_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_210_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_220_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_220_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_220_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_220_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_230_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_230_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_230_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_230_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_240_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_240_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_240_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_240_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_250_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_250_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_250_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_250_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_260_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_260_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_260_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_260_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_270_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_270_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_270_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_270_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_280_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_280_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_280_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_280_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_290_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_290_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_290_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_290_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_YN  ]  == null) ? "FALSE" : (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_YN  ].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";
                MyOraDB.Parameter_Values[vcnt++] = (fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_DAYS]  == null) ? ""      :  fgrid_main[row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_DAYS].ToString().Trim();
                MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();            
        }
        #endregion

        #region Grid Event

        #region Grid Head
        #region Dev Grid
        private void fgrid_dev_AfterSelChange(object sender, RangeEventArgs e)
        {
            try
            {
                if (grid_flg)
                    return;

                if (fgrid_dev.Rows.Count.Equals(fgrid_dev.Rows.Fixed))
                    return;

                int sct_row = fgrid_dev.Selection.r1;
                int sct_col = fgrid_dev.Selection.c1;

                fgrid_task.Rows.Count = fgrid_task.Rows.Fixed;

                if (sct_col < (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_010_YMD || sct_col > (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_090_YMD)
                {                    
                    mnu_insert.Enabled = false;
                    mnu_delete.Enabled = false;
                    mnu_data_clear.Enabled = false;                    
                }
                else
                {
                    mnu_insert.Enabled = true;
                    mnu_delete.Enabled = true;
                    mnu_data_clear.Enabled = true;

                    string[] arg_value = new string[2];

                    arg_value[0] = fgrid_dev[sct_row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxFACTORY].ToString().Trim();
                    arg_value[1] = nf_cd_dev[sct_col];
                                        
                    Display_Task_Data(arg_value);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        private void fgrid_dev_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = fgrid_dev.Selection.r1;
                int sct_col = fgrid_dev.Selection.c1;
                int[] sct_rows = fgrid_dev.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    fgrid_dev[sct_rows[i], (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxDIVISION] = "U";
                    fgrid_dev[sct_rows[i], sct_col] = fgrid_dev[sct_row, sct_col];
                }
            }
            catch
            {

            }
        }
        private void fgrid_dev_BeforeEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = fgrid_dev.Selection.r1;
                int sct_col = fgrid_dev.Selection.c1;

                string cell_value = (fgrid_dev[sct_row, sct_col] == null) ? "" : fgrid_dev[sct_row, sct_col].ToString();

                if (!cell_value.Equals(""))
                {
                    try
                    {
                        if (cell_value.Length > 8)
                        {
                            fgrid_dev.Buffer_CellData = cell_value;
                        }
                        else
                        {
                            int year  = int.Parse(cell_value.Substring(0, 4));
                            int month = int.Parse(cell_value.Substring(4, 2));
                            int day   = int.Parse(cell_value.Substring(6, 2));

                            DateTime dt = new DateTime(year, month, day);

                            fgrid_dev.Buffer_CellData = dt.ToString();
                        }
                    }
                    catch
                    {
                        fgrid_dev.Buffer_CellData = DateTime.Now.ToString();
                    }

                    fgrid_dev[sct_row, sct_col] = fgrid_dev.Buffer_CellData.ToString();
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

        #region Comm Grid
        private void fgrid_main_AfterSelChange(object sender, RangeEventArgs e)
        {
            try
            {
                if (grid_flg)
                    return;

                if(fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;

                fgrid_task.Rows.Count = fgrid_task.Rows.Fixed;

                if (sct_col < (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_YN || sct_col > (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_DAYS)
                {                    
                    mnu_insert.Enabled = false;
                    mnu_delete.Enabled = false;                    
                }
                else
                {
                    mnu_insert.Enabled = true;
                    mnu_delete.Enabled = true;

                    string[] arg_value = new string[2];

                    arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxFACTORY].ToString().Trim();
                    arg_value[1] = nf_cd_comm[sct_col];
                    
                    Display_Task_Data(arg_value);
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }
        private void fgrid_main_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                int sct_row = fgrid_main.Selection.r1;
                int sct_col = fgrid_main.Selection.c1;
                int[] sct_rows = fgrid_main.Selections;

                for (int i = 0; i < sct_rows.Length; i++)
                {
                    fgrid_main[sct_rows[i], (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxDIVISION] = "U";
                    fgrid_main[sct_rows[i], sct_col] = fgrid_main[sct_row, sct_col];
                }
            }
            catch
            {
 
            }
        }
        #endregion

        private void Display_Task_Data(string [] arg_value)
        {
            DataTable dt_ret = SELECT_TASK_MANAGEMENT(arg_value);

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                fgrid_task.Rows.Add();

                for (int j = 0; j < fgrid_task.Cols.Count; j++)
                {
                    fgrid_task[fgrid_task.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();
                }
            }
        }

        private DataTable SELECT_TASK_MANAGEMENT(string [] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02_SELECT.SELECT_TASK_MANAGEMENT";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";                
                MyOraDB.Parameter_Name[1] = "ARG_ROUND";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;                
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];                
                MyOraDB.Parameter_Values[2] = "";

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

        #region Grid Tail
        private void fgrid_task_AfterEdit(object sender, RowColEventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex.Equals(0))
                {
                    if (fgrid_dev.Rows.Count.Equals(fgrid_dev.Rows.Fixed))
                        return;
                }
                else
                {
                    if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                        return; 
                }

                if (fgrid_task.Rows.Count.Equals(fgrid_task.Rows.Fixed))
                    return;

                int sct_row = fgrid_task.Selection.r1;
                int sct_col = fgrid_task.Selection.c1;
                
                string[] arg_value = new string[7];

                arg_value[0] = "U";
                arg_value[1] = fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxFACTORY].ToString().Trim();
                arg_value[2] = fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxNF_CD].ToString().Trim();
                arg_value[3] = fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxNF_SEQ].ToString().Trim();
                arg_value[4] = (fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxTK_CD].Equals(null)) ? "" : fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxTK_CD].ToString().Trim();
                arg_value[5] = (fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxTK_DAYS].Equals(null)) ? "" : fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxTK_DAYS].ToString().Trim();
                arg_value[6] = (fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxTK_YN].Equals(null)) ? "FALSE" : (fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxTK_YN].ToString().Trim().ToUpper().Equals("TRUE")) ? "Y" : "N";

                SAVE_TASK_MANAGEMENT(arg_value);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        #endregion

        #endregion

        #region Context Menu

        #region Dev Grid
        private void ctmnu_dev_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = fgrid_dev.Selection.r1;
                int[] sct_rows = fgrid_dev.Selections;
                int sct_col = fgrid_dev.Selection.c1;

                if (sct_col >= (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_010_YMD && sct_col <= (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_090_YMD)
                {
                    for (int i = 0; i < sct_rows.Length; i++)
                    {
                        fgrid_dev[sct_rows[i], sct_col] = null;
                        fgrid_dev[sct_rows[i], (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxDIVISION] = "U";
                    }
                }
            }
            catch
            {
 
            }
        }
        #endregion

        #region Task Grid
        private void mnu_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex.Equals(0))
                {
                    if (fgrid_dev.Rows.Count.Equals(fgrid_dev.Rows.Fixed))
                        return;

                    int sct_row = fgrid_dev.Selection.r1;
                    int sct_col = fgrid_dev.Selection.c1;

                    if (sct_col < (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_010_YMD || sct_col > (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_090_YMD)
                        return;

                    string[] arg_value = new string[7];

                    arg_value[0] = "I";
                    arg_value[1] = fgrid_dev[sct_row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxFACTORY].ToString().Trim();
                    arg_value[2] = nf_cd_dev[sct_col];
                    
                    int nf_seq = int.Parse(fgrid_task[fgrid_task.Selection.r1, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxNF_SEQ].ToString().Trim());
                    if(nf_seq >= 500)
                        arg_value[3] = "9";
                    else
                        arg_value[3] = "5";
                    
                    arg_value[4] = "001";
                    arg_value[5] = "0";
                    arg_value[6] = "";

                    if (SAVE_TASK_MANAGEMENT(arg_value))
                    {
                        arg_value[0] = fgrid_dev[sct_row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxFACTORY].ToString().Trim();
                        arg_value[1] = nf_cd_dev[sct_col];

                        fgrid_task.Rows.Count = fgrid_task.Rows.Fixed;
                        Display_Task_Data(arg_value);

                        if (nf_seq >= 500)
                        {
                            fgrid_task.Select(fgrid_task.Rows.Count - 1, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxTK_CD);
                        }
                        else
                        {
                            int row = fgrid_task.Rows.Fixed;
                            for (int i = row; i < fgrid_task.Rows.Count; i++)
                            {
                                string _nf_seq = fgrid_task[i, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxNF_SEQ].ToString().Trim();

                                if (_nf_seq.Substring(0, 1).Equals("5"))
                                    break;

                                row = i;
                            }

                            fgrid_task.Select(row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxTK_CD);
                        }                        
                    }
                }
                else
                {
                    if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                        return;

                    int sct_row = fgrid_main.Selection.r1;
                    int sct_col = fgrid_main.Selection.c1;

                    if (sct_col < (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_YN || sct_col > (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_DAYS)
                        return;

                    string[] arg_value = new string[7];

                    arg_value[0] = "I";
                    arg_value[1] = fgrid_main[sct_row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxFACTORY].ToString().Trim();
                    arg_value[2] = nf_cd_comm[sct_col];

                    int nf_seq = int.Parse(fgrid_task[fgrid_task.Selection.r1, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxNF_SEQ].ToString().Trim());
                    if (nf_seq >= 500)
                        arg_value[3] = "9";
                    else
                        arg_value[3] = "5";

                    arg_value[4] = "001";
                    arg_value[5] = "0";
                    arg_value[6] = "";

                    if (SAVE_TASK_MANAGEMENT(arg_value))
                    {
                        arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxFACTORY].ToString().Trim();
                        arg_value[1] = nf_cd_comm[sct_col];

                        fgrid_task.Rows.Count = fgrid_task.Rows.Fixed;
                        Display_Task_Data(arg_value);

                        if (nf_seq >= 500)
                        {
                            fgrid_task.Select(fgrid_task.Rows.Count - 1, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxTK_CD);
                        }
                        else
                        {
                            int row = fgrid_task.Rows.Fixed;
                            for (int i = row; i < fgrid_task.Rows.Count; i++)
                            {
                                string _nf_seq = fgrid_task[i, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxNF_SEQ].ToString().Trim();

                                if (_nf_seq.Substring(0, 1).Equals("5"))
                                    break;

                                row = i;
                            }

                            fgrid_task.Select(row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxTK_CD);
                        }       
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
 
            }
        }

        private void mnu_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                    return;

                if (fgrid_task.Rows.Count.Equals(fgrid_task.Rows.Fixed))
                    return;

                int sct_row = fgrid_task.Selection.r1;
                int sct_col = fgrid_task.Selection.c1;

                if (sct_row < fgrid_task.Rows.Fixed)
                    return;
                
                string[] arg_value = new string[8];

                arg_value[0] = "D";
                arg_value[1] = fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxFACTORY].ToString().Trim();
                arg_value[2] = fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxNF_CD].ToString().Trim();
                arg_value[3] = fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxNF_SEQ].ToString().Trim();
                arg_value[4] = "";
                arg_value[5] = "";
                arg_value[6] = "";

                if (SAVE_TASK_MANAGEMENT(arg_value))
                {
                    arg_value[0] = fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxFACTORY].ToString().Trim();                    
                    arg_value[1] = fgrid_task[sct_row, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxNF_CD].ToString().Trim();

                    fgrid_task.Rows.Count = fgrid_task.Rows.Fixed;
                    Display_Task_Data(arg_value);

                    fgrid_task.Select(fgrid_task.Rows.Count - 1, (int)ClassLib.TBSXC_TASK_MANAGEMENT.IxTK_CD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private bool SAVE_TASK_MANAGEMENT(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(8);
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.SAVE_TASK_MANAGEMENT";

                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";                
                MyOraDB.Parameter_Name[2] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[3] = "ARG_NF_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_TK_CD";
                MyOraDB.Parameter_Name[5] = "ARG_TK_DAYS";
                MyOraDB.Parameter_Name[6] = "ARG_TK_YN";
                MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;                

                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];                
                MyOraDB.Parameter_Values[7] = COM.ComVar.This_User;

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

        #endregion

        #region Control Event
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex.Equals(0))
                {
                    DataTable dt_ret = SELECT_CATEGORY("DEV");
                    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
                    cmb_category.SelectedIndex = 0;

                    cmb_season_from.Enabled = true;
                    cmb_season_to.Enabled = true;

                    cmb_p_factory.Enabled = false;

                    fgrid_task.Rows.Count = fgrid_task.Rows.Fixed;

                    if (fgrid_dev.Rows.Count.Equals(fgrid_dev.Rows.Fixed))
                        return;

                    int sct_row = fgrid_dev.Selection.r1;
                    int sct_col = fgrid_dev.Selection.c1;

                    if (sct_col < (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_010_YMD || sct_col > (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxNF_090_YMD)
                    {
                        
                        mnu_insert.Enabled = false;
                        mnu_delete.Enabled = false;
                        mnu_data_clear.Enabled = false;                        
                    }
                    else
                    {
                        mnu_insert.Enabled = true;
                        mnu_delete.Enabled = true;
                        mnu_data_clear.Enabled = true;

                        string[] arg_value = new string[2];

                        arg_value[0] = fgrid_dev[sct_row, (int)ClassLib.TBSXC_TD_MANAGEMENT_DEV.IxFACTORY].ToString().Trim();
                        arg_value[1] = nf_cd_dev[sct_col];
                        
                        Display_Task_Data(arg_value);
                    }
                }
                else
                {
                    DataTable dt_ret = SELECT_CATEGORY("COMM");
                    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
                    cmb_category.SelectedIndex = 0;

                    cmb_season_from.Enabled = false;
                    cmb_season_to.Enabled = false;

                    cmb_p_factory.Enabled = true;

                    fgrid_task.Rows.Count = fgrid_task.Rows.Fixed;

                    if (fgrid_main.Rows.Count.Equals(fgrid_main.Rows.Fixed))
                        return;

                    int sct_row = fgrid_main.Selection.r1;
                    int sct_col = fgrid_main.Selection.c1;                    

                    if (sct_col < (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_100_YN || sct_col > (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxNF_300_DAYS)
                    {
                        mnu_insert.Enabled = false;
                        mnu_delete.Enabled = false;                        
                    }
                    else
                    {
                        mnu_insert.Enabled = true;
                        mnu_delete.Enabled = true;

                        string[] arg_value = new string[2];

                        arg_value[0] = fgrid_main[sct_row, (int)ClassLib.TBSXC_TD_MANAGEMENT_COMM.IxFACTORY].ToString().Trim();
                        arg_value[1] = nf_cd_comm[sct_col];

                        Display_Task_Data(arg_value);
                    } 
                }
            }
            catch
            {
 
            }
        }
        #endregion

        
    }
}


