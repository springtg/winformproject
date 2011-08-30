using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using C1.Win.C1FlexGrid;
using ChartFX.WinForms;
using ChartFX.WinForms.DataProviders;
using System.Diagnostics;
using System.Xml;
using System.IO;

namespace FlexCDC.Analisys
{
    public partial class Form_EIS_DD_Report_New : COM.APSWinForm.Form_Top
    {
        #region 생성자
        public Form_EIS_DD_Report_New()
        {
            InitializeComponent();

            _memoryStream = new System.IO.MemoryStream();
            chart_01.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);            
        }
        #endregion

        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private COM.ComFunction MyComFunction = new COM.ComFunction();
        private System.IO.MemoryStream _memoryStream;
        private Encoding K_Encode = Encoding.GetEncoding("euc-kr");
        private bool first_flg = true;
        private BaseInfo.Pop_BS_Shipping_List_Wait _pop = null;
        private Thread temp_thread = null;
        delegate void DelegateSetn(); // 대리자 선언     
        #endregion
        
        #region Form Loading
        private void Form_EIS_DD_Report_New_Load(object sender, EventArgs e)
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
            try
            {
                //Title
                this.Text = " DD Report by Season ";
                lbl_MainTitle.Text = " DD Report by Season ";
                lbl_title.Text = "       Search Condition ";
                
                Init_Grid();
                Init_Control();
                Init_Toolbar();
                Set_Chart_Before();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Init_Grid()
        {
            fgrid_Main.Set_Grid("EIS_DD_REPORT", "1", 3, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.AllowSorting = AllowSortingEnum.None;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;            
            fgrid_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Main.ExtendLastCol = false;
            fgrid_Main.Tree.Column = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxITEM_01;

            #region Grid Title Style
            //Running
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B, fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_04M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_02M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_03B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_03M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_03B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_03M).StyleNew.ForeColor = Color.Black;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_04M).StyleNew.BackColor = Color.LightGreen;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_04M).StyleNew.ForeColor = Color.Black;

            //Ws Training
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_03B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_03M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_03B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_03M).StyleNew.ForeColor = Color.Black;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_04M).StyleNew.BackColor = Color.LightGreen;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_04M).StyleNew.ForeColor = Color.Black;

            //Sport Wear
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_01B, fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_04M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_01B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_02M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_03B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_03M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_03B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_03M).StyleNew.ForeColor = Color.Black;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_04M).StyleNew.BackColor = Color.LightGreen;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_04M).StyleNew.ForeColor = Color.Black;

            //Tennis
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_03B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_03M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_03B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_03M).StyleNew.ForeColor = Color.Black;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_04M).StyleNew.BackColor = Color.LightGreen;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_04M).StyleNew.ForeColor = Color.Black;

            //KIDS
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_01B, fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_05M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_01B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_03M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_04M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_04M).StyleNew.ForeColor = Color.Black;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_05B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_05M).StyleNew.BackColor = Color.LightGreen;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_05B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_05M).StyleNew.ForeColor = Color.Black;

            //Track & Field
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_03B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_03M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_03B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_03M).StyleNew.ForeColor = Color.Black;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_04M).StyleNew.BackColor = Color.LightGreen;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_04M).StyleNew.ForeColor = Color.Black;

            //Core-Performance
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_01B, fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_01B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_02M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_03B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_03M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_03B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_03M).StyleNew.ForeColor = Color.Black;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M).StyleNew.BackColor = Color.LightGreen;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M).StyleNew.ForeColor = Color.Black;

            //SubTotal            
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD_P).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD_P).StyleNew.ForeColor = Color.Black;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD_P).StyleNew.BackColor = Color.LightGreen;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD_P).StyleNew.ForeColor = Color.Black;

            //Total
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_BOM, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_MOD_P).StyleNew.BackColor = Color.LightPink;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_BOM, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_MOD_P).StyleNew.ForeColor = Color.Black;
            #endregion
        }
        private void Init_Control()
        {
            // Combobox Add Items
            DataTable dt_ret = SELECT_SEASON();

            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Season_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Season_from.SelectedValue = "200904";
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Season_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Season_to.SelectedValue = "200904";

            // Factory Combobox Setting
            dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, true, COM.ComVar.ComboList_Visible.Name);            
            cmb_factory.SelectedIndex = 0;
            
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
            int dd = cmb_Season_to.ItemHeight;

            #region Chart Dislpay ComboBox
            cmb_chart_01.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_chart_01.ClearItems();

            cmb_chart_01.AddItemTitles("Code;Name");
            cmb_chart_01.ValueMember = "Code";
            cmb_chart_01.DisplayMember = "Name";
            cmb_chart_01.AddItem("BOM;BOM");
            cmb_chart_01.AddItem("SKU;SKU");
            cmb_chart_01.AddItem("MODEL;MODEL");

            cmb_chart_01.SelectedIndex = -1;
            cmb_chart_01.MaxDropDownItems = 10;
            cmb_chart_01.Splits[0].DisplayColumns[0].Width = 0;
            cmb_chart_01.Splits[0].DisplayColumns[1].Width = 180;

            cmb_chart_01.ExtendRightColumn = true;
            cmb_chart_01.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_chart_01.HScrollBar.Height = 0;

            cmb_chart_01.SelectedIndex = 0;

            cmb_chart_02.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_chart_02.ClearItems();

            cmb_chart_02.AddItemTitles("Code;Name");
            cmb_chart_02.ValueMember = "Code";
            cmb_chart_02.DisplayMember = "Name";
            cmb_chart_02.AddItem("BOM;BOM");
            cmb_chart_02.AddItem("SKU;SKU");
            cmb_chart_02.AddItem("MODEL;MODEL");

            cmb_chart_02.SelectedIndex = -1;
            cmb_chart_02.MaxDropDownItems = 10;
            cmb_chart_02.Splits[0].DisplayColumns[0].Width = 0;
            cmb_chart_02.Splits[0].DisplayColumns[1].Width = 180;

            cmb_chart_02.ExtendRightColumn = true;
            cmb_chart_02.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_chart_02.HScrollBar.Height = 0;

            cmb_chart_02.SelectedIndex = 0;

            cmb_chart_03.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_chart_03.ClearItems();

            cmb_chart_03.AddItemTitles("Code;Name");
            cmb_chart_03.ValueMember = "Code";
            cmb_chart_03.DisplayMember = "Name";
            cmb_chart_03.AddItem("BOM;BOM");
            cmb_chart_03.AddItem("SKU;SKU");
            cmb_chart_03.AddItem("MODEL;MODEL");

            cmb_chart_03.SelectedIndex = -1;
            cmb_chart_03.MaxDropDownItems = 10;
            cmb_chart_03.Splits[0].DisplayColumns[0].Width = 0;
            cmb_chart_03.Splits[0].DisplayColumns[1].Width = 180;

            cmb_chart_03.ExtendRightColumn = true;
            cmb_chart_03.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_chart_03.HScrollBar.Height = 0;

            cmb_chart_03.SelectedIndex = 0;
            #endregion
            
            first_flg = false;

            chk_spc.Checked = true;
            chk_nondd.Checked = true;
        }
        private void Init_Toolbar()
        {
            // Disabled tbutton            
            tbtn_Save.Enabled = false;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;
        }

        private DataTable SELECT_SEASON()
        {
            try
            {
                string Proc_Name = "PKG_EDM_PCC_01.SELECT_SEASON";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "DS";
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
            MyOraDB.Parameter_Values[2] = cmb_Season_from.SelectedValue.ToString();
            MyOraDB.Parameter_Values[3] = cmb_Season_to.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = cmb_category.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = "";

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
                fgrid_Main.ClearAll();



                temp_thread = new Thread(new ThreadStart(Thread_Loading));
                
                if (temp_thread != null)
                {                       
                    temp_thread.Start();
                    _pop = new BaseInfo.Pop_BS_Shipping_List_Wait();
                    _pop.Start();                
                
                    //Display_Data();
                }
                               
                temp_thread.Abort();                
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "tbtn_search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
        }

        public void Thread_Loading()
        {
            Invoke(new DelegateSetn(Display_Data)); // 폼 스레드에 작업 넘김            
        }        
        public void Display_Data()
        {           
            //Grid
            Display_Grid();

            ////Chart
            fgrid_Main.Select(fgrid_Main.Rows.Fixed, 1);
            DataSet vDS = MakeChartData();
            Display_Chart(vDS);

            _pop.Close();
        }

        #region Grid Data Search
        private void Display_Grid()
        {
            #region Data Display
            string[] arg_value = new string[6];
            
            arg_value[0] = cmb_Season_from.SelectedValue.ToString();
            arg_value[1] = cmb_Season_to.SelectedValue.ToString();
            arg_value[2] = cmb_factory.SelectedValue.ToString().Trim();
            arg_value[3] = cmb_p_factory.SelectedValue.ToString().Trim();
            arg_value[4] = cmb_category.SelectedValue.ToString().Trim();
            arg_value[5] = cmb_model.SelectedValue.ToString().Trim();

            DataTable dt_ret = SELECT_DD_LIST(arg_value);

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                int lev = int.Parse(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxLEV].ToString());
                fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, lev);

                for (int j = fgrid_Main.Cols.Fixed; j < fgrid_Main.Cols.Count; j++)
                {
                    if (dt_ret.Rows[i].ItemArray[j].ToString().Equals("0"))
                        fgrid_Main[fgrid_Main.Rows.Count - 1, j] = " ";
                    else
                        fgrid_Main[fgrid_Main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString();  
                
                    if(j >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B && j <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M)
                        fgrid_Main.Cols[j].Visible = true;
                }

                if (lev.Equals(1))
                {
                    fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B, fgrid_Main.Rows.Count - 1, fgrid_Main.Cols.Count - 1).StyleNew.BackColor = Color.FromArgb(255, 255, 153);
                }
                else if (lev.Equals(2))
                {
                    fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B, fgrid_Main.Rows.Count - 1, fgrid_Main.Cols.Count - 1).StyleNew.BackColor = Color.FromArgb(204, 255, 255);
                }
                else if (lev.Equals(3))
                {
                    fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B, fgrid_Main.Rows.Count - 1, fgrid_Main.Cols.Count - 1).StyleNew.BackColor = Color.FromArgb(236, 246, 206);
                }
                else
                {
                    fgrid_Main.GetCellRange(fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B, fgrid_Main.Rows.Count - 1, fgrid_Main.Cols.Count - 1).StyleNew.BackColor = Color.White;
                }
            }
            #endregion

            Radio_Button_Check(null, null);

            if (!chk_spc.Checked && chk_nondd.Checked)
            {
                chk_spc_CheckedChanged(null, null);
            }
            else if (chk_spc.Checked && !chk_nondd.Checked)
            {
                chk_nondd_CheckedChanged(null, null);
            }
            else if (!chk_spc.Checked && !chk_nondd.Checked)
            {
                chk_spc_CheckedChanged(null, null);
            }
            else
            {
                Category_Select();
                Total_Percentage(fgrid_Main);
            }
        }

        private void Data_Total_ALL(C1FlexGrid arg_grid)
        {
            #region Data Sum
            double value_bom   = 0;
            double value_sku   = 0;
            double value_model = 0;
            
            for (int i = arg_grid.Rows.Fixed; i < arg_grid.Rows.Count; i++)
            {
                try
                {
                    value_bom = double.Parse((arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM] == null || arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM].ToString().Trim().Equals("")) ? "0" : arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM].ToString().Trim());
                }
                catch
                {
                    value_bom = 0; 
                }

                try
                {
                    value_sku = double.Parse((arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU] == null || arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU].ToString().Trim().Equals("")) ? "0" : arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU].ToString().Trim());
                }
                catch
                {
                    value_sku = 0;
                }

                try
                {
                    value_model = double.Parse((arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD] == null || arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD].ToString().Trim().Equals("")) ? "0" : arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD].ToString().Trim());
                }
                catch
                {
                    value_model = 0;
                }


                if (chk_spc.Checked)
                {
                    try
                    {
                        value_bom += double.Parse((arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM] == null || arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM].ToString().Trim().Equals("")) ? "0" : arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM].ToString().Trim());
                    }
                    catch
                    {
                        value_bom += 0;
                    }

                    try
                    {
                        value_sku += double.Parse((arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU] == null || arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU].ToString().Trim().Equals("")) ? "0" : arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU].ToString().Trim());
                    }
                    catch
                    {
                        value_sku += 0;
                    }

                    try
                    {
                        value_model += double.Parse((arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD] == null || arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD].ToString().Trim().Equals("")) ? "0" : arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD].ToString().Trim());
                    }
                    catch
                    {
                        value_model += 0;
                    }                    
                }

                if (chk_nondd.Checked)
                {
                    try
                    {
                        value_bom += double.Parse((arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM] == null || arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM].ToString().Trim().Equals("")) ? "0" : arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM].ToString().Trim());
                    }
                    catch
                    {
                        value_bom += 0;
                    }

                    try
                    {
                        value_sku += double.Parse((arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU] == null || arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU].ToString().Trim().Equals("")) ? "0" : arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU].ToString().Trim());
                    }
                    catch
                    {
                        value_sku += 0;
                    }

                    try
                    {
                        value_model += double.Parse((arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD] == null || arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD].ToString().Trim().Equals("")) ? "0" : arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD].ToString().Trim());
                    }
                    catch
                    {
                        value_model += 0;
                    }
                }

                arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_BOM] = value_bom.ToString();
                arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SKU] = value_sku.ToString();
                arg_grid[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_MOD] = value_model.ToString();
            }
            #endregion                       
        }

        private void Total_Percentage(C1FlexGrid arg_grid)
        {
            #region Total Percentage
            double tot_dd_bom_01 = 0;
            double tot_dd_bom_02 = 0;
            double tot_dd_sku_01 = 0;
            double tot_dd_sku_02 = 0;
            double tot_dd_model_01 = 0;
            double tot_dd_model_02 = 0;

            double tot_spc_bom_01 = 0;
            double tot_spc_bom_02 = 0;
            double tot_spc_sku_01 = 0;
            double tot_spc_sku_02 = 0;
            double tot_spc_model_01 = 0;
            double tot_spc_model_02 = 0;

            double tot_non_bom_01 = 0;
            double tot_non_bom_02 = 0;
            double tot_non_sku_01 = 0;
            double tot_non_sku_02 = 0;
            double tot_non_model_01 = 0;
            double tot_non_model_02 = 0;

            double tot_bom_01 = 0;
            double tot_bom_02 = 0;
            double tot_sku_01 = 0;
            double tot_sku_02 = 0;
            double tot_model_01 = 0;
            double tot_model_02 = 0;
            
            for (int tot_row = arg_grid.Rows.Fixed; tot_row < arg_grid.Rows.Count; tot_row++)
            {
                string lev = arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxLEV].ToString().Trim();

                if (lev.Equals("1"))
                {
                    #region 1 Level
                    tot_dd_bom_01   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM].ToString().Trim());
                    tot_dd_sku_01   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU].ToString().Trim());
                    tot_dd_model_01 = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD].ToString().Trim());

                    tot_spc_bom_01   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM].ToString().Trim());
                    tot_spc_sku_01   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU].ToString().Trim());
                    tot_spc_model_01 = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD].ToString().Trim());

                    tot_non_bom_01   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM].ToString().Trim());
                    tot_non_sku_01   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU].ToString().Trim());
                    tot_non_model_01 = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD].ToString().Trim());

                    tot_bom_01   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_BOM] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_BOM].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_BOM].ToString().Trim());
                    tot_sku_01   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SKU] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SKU].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SKU].ToString().Trim());
                    tot_model_01 = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_MOD] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_MOD].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_MOD].ToString().Trim());

                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM_P] = (tot_dd_bom_01.Equals(0)) ? "" : "100";
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU_P] = (tot_dd_sku_01.Equals(0)) ? "" : "100";
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD_P] = (tot_dd_model_01.Equals(0)) ? "" : "100";

                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM_P] = (tot_spc_bom_01.Equals(0)) ? "" : "100";
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU_P] = (tot_spc_sku_01.Equals(0)) ? "" : "100";
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD_P] = (tot_spc_model_01.Equals(0)) ? "" : "100";

                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM_P] = (tot_non_bom_01.Equals(0)) ? "" : "100";
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU_P] = (tot_non_sku_01.Equals(0)) ? "" : "100";
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD_P] = (tot_non_model_01.Equals(0)) ? "" : "100";

                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_BOM_P] = (tot_bom_01.Equals(0)) ? "" : "100";
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SKU_P] = (tot_sku_01.Equals(0)) ? "" : "100";
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_MOD_P] = (tot_model_01.Equals(0)) ? "" : "100";
                    #endregion
                }
                else if (lev.Equals("2"))
                {
                    #region 2 Level
                    tot_dd_bom_02   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM].ToString().Trim());
                    tot_dd_sku_02   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU].ToString().Trim());
                    tot_dd_model_02 = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD].ToString().Trim());

                    tot_spc_bom_02   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM].ToString().Trim());
                    tot_spc_sku_02   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU].ToString().Trim());
                    tot_spc_model_02 = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD].ToString().Trim());

                    tot_non_bom_02   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM].ToString().Trim());
                    tot_non_sku_02   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU].ToString().Trim());
                    tot_non_model_02 = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD].ToString().Trim());

                    tot_bom_02   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_BOM] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_BOM].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_BOM].ToString().Trim());
                    tot_sku_02   = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SKU] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SKU].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SKU].ToString().Trim());
                    tot_model_02 = int.Parse((arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_MOD] == null || arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_MOD].ToString().Trim().Equals("")) ? "0" : arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_MOD].ToString().Trim());

                    double dd_bom_per   = (tot_dd_bom_02.Equals(0)) ? 0 : 100 * tot_dd_bom_02 / tot_dd_bom_01;
                    double dd_sku_per   = (tot_dd_sku_02.Equals(0)) ? 0 : 100 * tot_dd_sku_02 / tot_dd_sku_01;
                    double dd_model_per = (tot_dd_model_02.Equals(0)) ? 0 : 100 * tot_dd_model_02 / tot_dd_model_01;

                    double spc_bom_per   = (tot_spc_bom_02.Equals(0)) ? 0 : 100 * tot_spc_bom_02 / tot_spc_bom_01;
                    double spc_sku_per   = (tot_spc_sku_02.Equals(0)) ? 0 : 100 * tot_spc_sku_02 / tot_spc_sku_01;
                    double spc_model_per = (tot_spc_model_02.Equals(0)) ? 0 : 100 * tot_spc_model_02 / tot_spc_model_01;

                    double non_bom_per   = (tot_non_bom_02.Equals(0)) ? 0 : 100 * tot_non_bom_02 / tot_non_bom_01;
                    double non_sku_per   = (tot_non_sku_02.Equals(0)) ? 0 : 100 * tot_non_sku_02 / tot_non_sku_01;
                    double non_model_per = (tot_non_model_02.Equals(0)) ? 0 : 100 * tot_non_model_02 / tot_non_model_01;

                    double bom_per = (tot_bom_02.Equals(0)) ? 0 : 100 * tot_bom_02 / tot_bom_01;
                    double sku_per = (tot_sku_02.Equals(0)) ? 0 : 100 * tot_sku_02 / tot_sku_01;
                    double model_per = (tot_model_02.Equals(0)) ? 0 : 100 * tot_model_02 / tot_model_01;

                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM_P] = (dd_bom_per.Equals(0)) ? "" : dd_bom_per.ToString("####0");
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU_P] = (dd_sku_per.Equals(0)) ? "" : dd_sku_per.ToString("####0");
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD_P] = (dd_model_per.Equals(0)) ? "" : dd_model_per.ToString("####0");

                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM_P] = (spc_bom_per.Equals(0)) ? "" : spc_bom_per.ToString("####0");
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU_P] = (spc_sku_per.Equals(0)) ? "" : spc_sku_per.ToString("####0");
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD_P] = (spc_model_per.Equals(0)) ? "" : spc_model_per.ToString("####0");

                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM_P] = (non_bom_per.Equals(0)) ? "" : non_bom_per.ToString("####0");
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU_P] = (non_sku_per.Equals(0)) ? "" : non_sku_per.ToString("####0");
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD_P] = (non_model_per.Equals(0)) ? "" : non_model_per.ToString("####0");

                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_BOM_P] = (bom_per.Equals(0)) ? "" : bom_per.ToString("####0");
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SKU_P] = (sku_per.Equals(0)) ? "" : sku_per.ToString("####0");
                    arg_grid[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_MOD_P] = (model_per.Equals(0)) ? "" : model_per.ToString("####0");
                    #endregion
                }                                                                                
            }            
            #endregion                          
        }

        private void Category_Select()
        {
            string category = cmb_category.SelectedValue.ToString();

            if (category.Equals("10"))
            {
                #region Running
                for (int i = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M; i++)
                {
                    if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_04M)
                    {
                        fgrid_Main.Cols[i].Visible = true;

                        if (!chk_spc.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_03B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_03M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                        if (!chk_nondd.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_04B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_04M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                    }
                    else
                        fgrid_Main.Cols[i].Visible = false;
                }
                #endregion
            }
            else if (category.Equals("30"))
            {
                #region Ws Training
                for (int i = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M; i++)
                {
                    if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_01B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_04M)
                    {
                        fgrid_Main.Cols[i].Visible = true;

                        if (!chk_spc.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_03B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_03M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                        if (!chk_nondd.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_04B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxWTR_04M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                    }
                    else
                        fgrid_Main.Cols[i].Visible = false;
                }
                #endregion
            }
            else if (category.Equals("40"))
            {
                #region Sport Wear
                for (int i = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M; i++)
                {
                    if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_01B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_04M)
                    {
                        fgrid_Main.Cols[i].Visible = true;

                        if (!chk_spc.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_03B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_03M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                        if (!chk_nondd.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_04B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSPW_04M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                    }
                    else
                        fgrid_Main.Cols[i].Visible = false;
                }
                #endregion
            }
            else if (category.Equals("50"))
            {
                #region Tennis
                for (int i = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M; i++)
                {
                    if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_01B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_04M)
                    {
                        fgrid_Main.Cols[i].Visible = true;

                        if (!chk_spc.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_03B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_03M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                        if (!chk_nondd.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_04B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTEN_04M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                    }
                    else
                        fgrid_Main.Cols[i].Visible = false;
                }
                #endregion
            }
            else if (category.Equals("70"))
            {
                #region Kids
                for (int i = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M; i++)
                {
                    if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_01B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_05M)
                    {
                        fgrid_Main.Cols[i].Visible = true;

                        if (!chk_spc.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_04B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_04M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                        if (!chk_nondd.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_05B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxKID_05M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                    }
                    else
                        fgrid_Main.Cols[i].Visible = false;
                }
                #endregion
            }
            else if (category.Equals("80")) 
            {
                #region Track & Field
                for (int i = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M; i++)
                {
                    if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_01B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_04M)
                    {
                        fgrid_Main.Cols[i].Visible = true;

                        if (!chk_spc.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_03B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_03M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                        if (!chk_nondd.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_04B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTRA_04M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                    }
                    else
                        fgrid_Main.Cols[i].Visible = false;
                }
                #endregion
            }
            else if (category.Equals("90"))
            {
                #region Core Performance
                for (int i = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M; i++)
                {
                    if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_01B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M)
                    {
                        fgrid_Main.Cols[i].Visible = true;

                        if (!chk_spc.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_03B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_03M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                        if (!chk_nondd.Checked)
                        {
                            if (i >= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04B && i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxCPA_04M)
                                fgrid_Main.Cols[i].Visible = false;
                        }
                    }
                    else
                        fgrid_Main.Cols[i].Visible = false;
                }
                #endregion
            }            
        }

        private DataTable SELECT_DD_LIST(string [] arg_value)
        {
            try
            {
                string Proc_Name = "PKG_EDM_PCC_01.SELECT_DD_LIST_SEASON";

                MyOraDB.ReDim_Parameter(7);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[2] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[3] = "ARG_P_FACTORY";
                MyOraDB.Parameter_Name[4] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[5] = "ARG_SRF_NO";
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

        #region Chart Data Search
        private void Set_Chart_Before()
        {
            //chart_bom
            _memoryStream.Position = 0;
            chart_01.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_01.Data.Clear();
            
            //chart_sku
            _memoryStream.Position = 0;
            chart_02.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_02.Data.Clear();

            //chart_model
            _memoryStream.Position = 0;
            chart_03.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_03.Data.Clear();
        }
        private DataSet MakeChartData()
        {
            try
            {
                DataSet vDSChartData = new DataSet("Chart DataSet");
                DataTable vDT_TABLE = new DataTable("DataTable");
                vDT_TABLE.Columns.Add(new DataColumn("X_LABLE"));
                
                if (fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed)
                {
                    for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count; row++)
                    {
                        string lev = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxLEV].ToString();

                        if (lev.Equals("1"))
                        {
                            vDT_TABLE.Columns.Add(fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxSEASON_NAME].ToString());                                               
                        }
                    }
                }

                #region Data Table Create
                string[] pcc_qd = new string[vDT_TABLE.Columns.Count];
                string[] pcc_vj = new string[vDT_TABLE.Columns.Count];
                string[] qd_qd  = new string[vDT_TABLE.Columns.Count];
                string[] vj_vj  = new string[vDT_TABLE.Columns.Count];             

                int pcc_qd_cnt = 1;
                int pcc_vj_cnt = 1;
                int qd_qd_cnt = 1;
                int vj_vj_cnt = 1;
               
                if (fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed)
                {
                    for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count; row++)
                    {
                        string lev = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxLEV].ToString();

                        if (lev.Equals("2"))
                        {
                            string item_name = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxITEM_01].ToString().Trim().Replace(" ", "");

                            if (item_name.Equals("PCC/QD"))
                            {
                                #region PCC/QD
                                int col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM_P;

                                if (tab_cntrol.SelectedIndex.Equals(0))
                                {
                                    string chart_combo = cmb_chart_01.SelectedValue.ToString().Trim();

                                    if (chart_combo.Equals("BOM"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM_P; 
                                    }
                                    else if (chart_combo.Equals("SKU"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU_P;
                                    }
                                    else
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD_P;
                                    }
                                }
                                else if (tab_cntrol.SelectedIndex.Equals(1))
                                {
                                    string chart_combo = cmb_chart_02.SelectedValue.ToString().Trim();

                                    if (chart_combo.Equals("BOM"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM_P;
                                    }
                                    else if (chart_combo.Equals("SKU"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU_P;
                                    }
                                    else
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD_P;
                                    }
                                }
                                else
                                {
                                    string chart_combo = cmb_chart_03.SelectedValue.ToString().Trim();

                                    if (chart_combo.Equals("BOM"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM_P;
                                    }
                                    else if (chart_combo.Equals("SKU"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU_P;
                                    }
                                    else
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD_P;
                                    }
                                }

                                object item = fgrid_Main[row, col];

                                if (fgrid_Main[row, col] == null || fgrid_Main[row, col].ToString().Trim().Equals(""))
                                    item = "0";                                

                                pcc_qd[0] = item_name;
                                pcc_qd[pcc_qd_cnt] = item.ToString();
                                pcc_qd_cnt++;
                                #endregion
                            }
                            else if (item_name.Equals("PCC/VJ"))
                            {
                                #region PCC/VJ
                                int col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM_P;

                                if (tab_cntrol.SelectedIndex.Equals(0))
                                {
                                    string chart_combo = cmb_chart_01.SelectedValue.ToString().Trim();

                                    if (chart_combo.Equals("BOM"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM_P;
                                    }
                                    else if (chart_combo.Equals("SKU"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU_P;
                                    }
                                    else
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD_P;
                                    }
                                }
                                else if (tab_cntrol.SelectedIndex.Equals(1))
                                {
                                    string chart_combo = cmb_chart_02.SelectedValue.ToString().Trim();

                                    if (chart_combo.Equals("BOM"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM_P;
                                    }
                                    else if (chart_combo.Equals("SKU"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU_P;
                                    }
                                    else
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD_P;
                                    }
                                }
                                else
                                {
                                    string chart_combo = cmb_chart_03.SelectedValue.ToString().Trim();

                                    if (chart_combo.Equals("BOM"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM_P;
                                    }
                                    else if (chart_combo.Equals("SKU"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU_P;
                                    }
                                    else
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD_P;
                                    }
                                }

                                object item = fgrid_Main[row, col];

                                if (fgrid_Main[row, col] == null || fgrid_Main[row, col].ToString().Trim().Equals(""))
                                    item = "0";

                                pcc_vj[0] = item_name;
                                pcc_vj[pcc_vj_cnt] = item.ToString();
                                pcc_vj_cnt++;
                                #endregion
                            }                
                            else if (item_name.Equals("QD/QD"))
                            {
                                #region QD/QD
                                int col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM_P;

                                if (tab_cntrol.SelectedIndex.Equals(0))
                                {
                                    string chart_combo = cmb_chart_01.SelectedValue.ToString().Trim();

                                    if (chart_combo.Equals("BOM"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM_P;
                                    }
                                    else if (chart_combo.Equals("SKU"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU_P;
                                    }
                                    else
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD_P;
                                    }
                                }
                                else if (tab_cntrol.SelectedIndex.Equals(1))
                                {
                                    string chart_combo = cmb_chart_02.SelectedValue.ToString().Trim();

                                    if (chart_combo.Equals("BOM"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM_P;
                                    }
                                    else if (chart_combo.Equals("SKU"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU_P;
                                    }
                                    else
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD_P;
                                    }
                                }
                                else
                                {
                                    string chart_combo = cmb_chart_03.SelectedValue.ToString().Trim();

                                    if (chart_combo.Equals("BOM"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM_P;
                                    }
                                    else if (chart_combo.Equals("SKU"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU_P;
                                    }
                                    else
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD_P;
                                    }
                                }

                                object item = fgrid_Main[row, col];

                                if (fgrid_Main[row, col] == null || fgrid_Main[row, col].ToString().Trim().Equals(""))
                                    item = "0";

                                qd_qd[0] = "QD";
                                qd_qd[qd_qd_cnt] = item.ToString();
                                qd_qd_cnt++;
                                #endregion
                            }
                            else if (item_name.Equals("VJ/VJ"))
                            {
                                #region VJ/VJ
                                int col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM_P;

                                if (tab_cntrol.SelectedIndex.Equals(0))
                                {
                                    string chart_combo = cmb_chart_01.SelectedValue.ToString().Trim();

                                    if (chart_combo.Equals("BOM"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_BOM_P;
                                    }
                                    else if (chart_combo.Equals("SKU"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_SKU_P;
                                    }
                                    else
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_DD_MOD_P;
                                    }
                                }
                                else if (tab_cntrol.SelectedIndex.Equals(1))
                                {
                                    string chart_combo = cmb_chart_02.SelectedValue.ToString().Trim();

                                    if (chart_combo.Equals("BOM"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_BOM_P;
                                    }
                                    else if (chart_combo.Equals("SKU"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_SKU_P;
                                    }
                                    else
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_SPC_MOD_P;
                                    }
                                }
                                else
                                {
                                    string chart_combo = cmb_chart_03.SelectedValue.ToString().Trim();

                                    if (chart_combo.Equals("BOM"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_BOM_P;
                                    }
                                    else if (chart_combo.Equals("SKU"))
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_SKU_P;
                                    }
                                    else
                                    {
                                        col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxTOT_NON_MOD_P;
                                    }
                                }

                                object item = fgrid_Main[row, col];

                                if (fgrid_Main[row, col] == null || fgrid_Main[row, col].ToString().Trim().Equals(""))
                                    item = "0";

                                vj_vj[0] = "VJ";
                                vj_vj[vj_vj_cnt] = item.ToString();
                                vj_vj_cnt++;
                                #endregion
                            }
                        }
                    }
                }

                DataRow drBOM_pcc = vDT_TABLE.NewRow();
                DataRow drBOM_qd  = vDT_TABLE.NewRow();
                DataRow drBOM_vj  = vDT_TABLE.NewRow();

                for (int col = 0; col < vDT_TABLE.Columns.Count; col++)
                {
                    if (col > 0)
                    {
                        int bom_pcc = int.Parse((pcc_qd[col] == null) ? "0" : pcc_qd[col]) + int.Parse((pcc_vj[col] == null) ? "0" : pcc_vj[col]);                        
                        
                        drBOM_pcc[col]   = bom_pcc.ToString();                                
                    }
                    else
                    {
                        drBOM_pcc[col] = "PCC";                        
                    }

                    drBOM_qd[col]    = qd_qd[col];
                    drBOM_vj[col]    = vj_vj[col];                  
                    
                }

                vDT_TABLE.Rows.Add(drBOM_pcc);
                vDT_TABLE.Rows.Add(drBOM_qd);
                vDT_TABLE.Rows.Add(drBOM_vj);                
                #endregion

                vDSChartData.Tables.AddRange(new DataTable[] { vDT_TABLE });
                return vDSChartData;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Chart Data Creation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void Display_Chart(DataSet arg_ds)
        {
            Set_Chart_Before();

            DataTable vDT_TABLE = arg_ds.Tables[0];

            // BOM Chart
            if (tab_cntrol.SelectedIndex.Equals(0))
            {
                chart_01.Data.Series = vDT_TABLE.Columns.Count;
                chart_01.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("X_LABLE", ChartFX.WinForms.FieldUsage.Label));
                for (int i = 1; i < vDT_TABLE.Columns.Count; i++)
                {
                    chart_01.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap(vDT_TABLE.Columns[i].ColumnName.ToString(), ChartFX.WinForms.FieldUsage.Value));
                }

                chart_01.DataSource = vDT_TABLE;
                chart_01.Font = new Font("Verdana", 8);
                chart_01.Gallery = ChartFX.WinForms.Gallery.Pie;
                chart_01.AllSeries.FillMode = FillMode.Gradient;
                chart_01.AllSeries.PointLabels.Visible = true;
                chart_01.LegendBox.Visible = false;
            }
            else if (tab_cntrol.SelectedIndex.Equals(1))
            {
                chart_02.Data.Series = vDT_TABLE.Columns.Count;
                chart_02.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("X_LABLE", ChartFX.WinForms.FieldUsage.Label));
                for (int i = 1; i < vDT_TABLE.Columns.Count; i++)
                {
                    chart_02.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap(vDT_TABLE.Columns[i].ColumnName.ToString(), ChartFX.WinForms.FieldUsage.Value));
                }

                chart_02.DataSource = vDT_TABLE;
                chart_02.Font = new Font("Verdana", 8);
                chart_02.Gallery = ChartFX.WinForms.Gallery.Pie;
                chart_02.AllSeries.FillMode = FillMode.Gradient;
                chart_02.AllSeries.PointLabels.Visible = true;
                chart_02.LegendBox.Visible = false;
            }
            else
            {
                chart_03.Data.Series = vDT_TABLE.Columns.Count;
                chart_03.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("X_LABLE", ChartFX.WinForms.FieldUsage.Label));
                for (int i = 1; i < vDT_TABLE.Columns.Count; i++)
                {
                    chart_03.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap(vDT_TABLE.Columns[i].ColumnName.ToString(), ChartFX.WinForms.FieldUsage.Value));
                }

                chart_03.DataSource = vDT_TABLE;
                chart_03.Font = new Font("Verdana", 8);
                chart_03.Gallery = ChartFX.WinForms.Gallery.Pie;
                chart_03.AllSeries.FillMode = FillMode.Gradient;
                chart_03.AllSeries.PointLabels.Visible = true;
                chart_03.LegendBox.Visible = false;
            }
        }
        #endregion 

        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                Pop_DD_Report_Option pop = new Pop_DD_Report_Option(this);
                pop.ShowDialog();

                #region 주석
                //string arg_season_from = cmb_Season_from.SelectedValue.ToString();
                //string arg_season_to   = cmb_Season_to.SelectedValue.ToString();
                //string arg_factory     = cmb_factory.SelectedValue.ToString();
                //string arg_p_factory   = cmb_p_factory.SelectedValue.ToString();
                //string arg_category    = cmb_category.SelectedValue.ToString();
                //string arg_model_id    = cmb_model.SelectedValue.ToString();
                                
                //Pop_EIS_DD_Report_Check pop = new Pop_EIS_DD_Report_Check(arg_season_from, arg_season_to, arg_factory, arg_p_factory, arg_category, arg_model_id);
                //pop.WindowState = FormWindowState.Normal;
                //pop.ShowDialog();


                //string mrd_Filename = "";
                //string txt_Filename = "DD_Report.txt";
                //string Para = "/rfn [" + Application.StartupPath + @"\" + txt_Filename + "]  /rv ";

                //#region 파일만들기
                //FileInfo file = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                //if (!file.Exists)
                //{
                //    file.Create().Close();
                //}                

                //FileStream sDatalist = new FileStream(txt_Filename, FileMode.Create, FileAccess.Write);
                //StreamWriter sw = new StreamWriter(sDatalist, K_Encode);
                //#endregion

                //#region Level에 따른 Data Flush
                //if (lbl_viewSeason.Checked || lbl_viewFactory.Checked) // 1, 2 Level
                //{
                //    mrd_Filename = Application.StartupPath + @"\Report\DD_Report_new.mrd";                    
                                        
                //    #region Data Flush
                //    string season = "";                   

                //    for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                //    {
                //        string sData = "";
                //        string lev = fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxLEV].ToString().Trim();

                //        if (lev.Equals("1"))
                //        {
                //            season = fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxITEM_01].ToString().Trim();
                //        }
                //        else if (lev.Equals("2"))
                //        {                            
                //            sData = season + "@" + fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxITEM_01].ToString().Replace("\r\n", "") + " @";

                //            for (int j = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; j < fgrid_Main.Cols.Count; j++)
                //            {
                //                if (fgrid_Main[i, j] == null)
                //                {
                //                    sData = sData + "@";
                //                }
                //                else
                //                {
                //                    sData = sData + fgrid_Main[i, j].ToString().Replace("\r\n", "") + " @";
                //                }
                //            }

                //            sw.WriteLine(sData);
                //        }                        
                //    }

                //    sw.Flush();
                //    sw.Close();

                //    sDatalist.Close();
                //    #endregion
                //}
                //else if (lbl_viewModel.Checked) // 3 Level
                //{
                //    mrd_Filename = Application.StartupPath + @"\Report\DD_Report_4Level_new.mrd";

                //    #region Data Flush
                //    for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                //    {
                //        string sData = "";

                //        string lev = fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxLEV].ToString().Trim();

                //        if (!lev.Equals("4"))
                //        {
                //            sData = lev + "@" + fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxITEM_01].ToString().Replace("\r\n", "") + " @";

                //            for (int j = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; j < fgrid_Main.Cols.Count; j++)
                //            {
                //                if (fgrid_Main[i, j] == null)
                //                {
                //                    sData = sData + "@";
                //                }
                //                else
                //                {
                //                    sData = sData + fgrid_Main[i, j].ToString().Replace("\r\n", "") + " @";
                //                }
                //            }

                //            sw.WriteLine(sData);    
                //        }                        
                //    }

                //    sw.Flush();
                //    sw.Close();

                //    sDatalist.Close();
                //    #endregion
                //}
                //else if (lbl_viewBom.Checked) // 4 Level
                //{
                //    mrd_Filename = Application.StartupPath + @"\Report\DD_Report_4Level_new.mrd";
                                        
                //    #region Data Flush
                //    for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                //    {
                //        string sData = "";

                //        string lev = fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxLEV].ToString().Trim();

                //        sData = lev + "@" + fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxITEM_01].ToString().Replace("\r\n", "") + " @";

                //        for (int j = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; j < fgrid_Main.Cols.Count; j++)
                //        {
                //            if (fgrid_Main[i, j] == null)
                //            {
                //                sData = sData + "@";
                //            }
                //            else
                //            {
                //                sData = sData + fgrid_Main[i, j].ToString().Replace("\r\n", "") + " @";
                //            }
                //        }

                //        sw.WriteLine(sData);
                //    }

                //    sw.Flush();
                //    sw.Close();

                //    sDatalist.Close();
                //    #endregion
                //}
                //#endregion

                ////Report View
                //Report.Form_RdViewer report = new Report.Form_RdViewer(txt_Filename, mrd_Filename, Para);
                //report.ShowDialog();

                ////File Delete
                //file.Delete();
                #endregion
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }
        #endregion

        #region Grid Event
        private void fgrid_Main_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {                
               
            }
            catch
            {
                
            }
            finally
            {
                
            }
        }
        private void fgrid_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int sct_row = fgrid_Main.Selection.r1;

                int col_point = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B;

                for (int i = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; i < fgrid_Main.Cols.Count; i++)
                {
                    string value = (fgrid_Main[sct_row, i] == null) ? "" : fgrid_Main[sct_row, i].ToString().Trim();

                    if (!value.Equals(""))
                    {
                        col_point = i;
                        break;
                    }
                }

                fgrid_Main.LeftCol = col_point;
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
        private void cmb_Season_from_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flg)
                    return;

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
        private void cmb_Season_to_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flg)
                    return;

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
        private void cmb_factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flg)
                    return;

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
        private void cmb_category_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (first_flg)
                    return;

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
        private void Radio_Button_Check(object sender, EventArgs e)
        {
            if (lbl_viewSeason.Checked)
                fgrid_Main.Tree.Show(1);
            else if (lbl_viewFactory.Checked)
                fgrid_Main.Tree.Show(2);
            else if (lbl_viewModel.Checked)
                fgrid_Main.Tree.Show(3);
            else if (lbl_viewBom.Checked)
                fgrid_Main.Tree.Show(4);
        }
        private void chk_spc_CheckedChanged(object sender, EventArgs e)
        {
            checkbox_event("SPC");

            Data_Total_ALL(fgrid_Main);
            Total_Percentage(fgrid_Main);
            Category_Select();
        }
        private void chk_nondd_CheckedChanged(object sender, EventArgs e)
        {
            checkbox_event("NON");

            Data_Total_ALL(fgrid_Main);
            Total_Percentage(fgrid_Main);
            Category_Select();
        }
        private void checkbox_event(string arg_div)
        {
            if (arg_div.Equals("SPC"))
            {
                for (int i = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; i < fgrid_Main.Cols.Count; i++)
                {
                    if (fgrid_Main[fgrid_Main.Rows.Fixed - 2, i].ToString().Trim().Equals("SPC"))
                    {
                        if (chk_spc.Checked)
                        {
                            fgrid_Main.Cols[i].Visible = true;
                        }
                        else
                        {
                            fgrid_Main.Cols[i].Visible = false;
                        }
                    }

                    if (!chk_spc.Checked && !chk_nondd.Checked)
                    {
                        if (fgrid_Main[fgrid_Main.Rows.Fixed - 3, i].ToString().Trim().Equals("SubTotal") && fgrid_Main[fgrid_Main.Rows.Fixed - 2, i].ToString().Trim().Equals("DD"))
                        {
                            fgrid_Main.Cols[i].Visible = false;
                        }
                    }
                    else
                    {
                        if (fgrid_Main[fgrid_Main.Rows.Fixed - 3, i].ToString().Trim().Equals("SubTotal") && fgrid_Main[fgrid_Main.Rows.Fixed - 2, i].ToString().Trim().Equals("DD"))
                        {
                            fgrid_Main.Cols[i].Visible = true;
                        }
                    }
                }
            }
            else if (arg_div.Equals("NON"))
            {
                for (int i = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW_02.IxRUN_01B; i < fgrid_Main.Cols.Count; i++)
                {
                    if (fgrid_Main[fgrid_Main.Rows.Fixed - 2, i].ToString().Trim().Equals("Non DD"))
                    {
                        if (chk_nondd.Checked)
                        {
                            fgrid_Main.Cols[i].Visible = true;
                        }
                        else
                        {
                            fgrid_Main.Cols[i].Visible = false;
                        }
                    }

                    if (!chk_spc.Checked && !chk_nondd.Checked)
                    {
                        if (fgrid_Main[fgrid_Main.Rows.Fixed - 3, i].ToString().Trim().Equals("SubTotal") && fgrid_Main[fgrid_Main.Rows.Fixed - 2, i].ToString().Trim().Equals("DD"))
                        {
                            fgrid_Main.Cols[i].Visible = false;
                        }
                    }
                    else
                    {
                        if (fgrid_Main[fgrid_Main.Rows.Fixed - 3, i].ToString().Trim().Equals("SubTotal") && fgrid_Main[fgrid_Main.Rows.Fixed - 2, i].ToString().Trim().Equals("DD"))
                        {
                            fgrid_Main.Cols[i].Visible = true;
                        }
                    }
                } 
            }

            
        }
        
        private void tab_cntrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet vDS = MakeChartData();
            Display_Chart(vDS); 
        }
        private void cmb_chart_01_SelectedValueChanged(object sender, EventArgs e)
        {
            DataSet vDS = MakeChartData();
            Display_Chart(vDS);

            
        }
        private void cmb_chart_02_SelectedValueChanged(object sender, EventArgs e)
        {
            DataSet vDS = MakeChartData();
            Display_Chart(vDS); 
        }
        private void cmb_chart_03_SelectedValueChanged(object sender, EventArgs e)
        {
            DataSet vDS = MakeChartData();
            Display_Chart(vDS); 
        }
        #endregion

        #region Context Menu
        private void mnu_popup_Click(object sender, EventArgs e)
        {
            try
            {
                Pop_EIS_DD_Report pop = new Pop_EIS_DD_Report(this);
                pop.WindowState = FormWindowState.Normal;
                pop.ShowDialog();
            }
            catch
            {

            }
            finally
            {
 
            }
        }
        #endregion        

       
    }
}