using System;
using System.IO;
using System.Text;
using System.Data;
using C1.Win.C1Chart;
using System.Drawing;
using ChartFX.WinForms;
using System.Threading;
using C1.Win.C1FlexGrid;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Data.OracleClient;
using System.Collections.Generic;
using ChartFX.WinForms.Annotation;
using ChartFX.WinForms.DataProviders;

namespace FlexCDC.Analisys
{
    public partial class Form_EIS_SCMR : COM.APSWinForm.Form_Top
    {

        #region 생성자
        public Form_EIS_SCMR()
        {
            InitializeComponent();

            _memoryStream = new System.IO.MemoryStream();

            //chart_People.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_round.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);            
            chart_Category.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);            
        }        
        #endregion

        #region 사용자 정의 변수
        private int vTreeLevel;
        private COM.OraDB MyOraDB = new COM.OraDB();
        private System.IO.MemoryStream _memoryStream;
        private COM.ComFunction MyComFunction = new COM.ComFunction();
        private bool init_flg = true;
        private string vsCurSeason_name = "";
        #endregion

        #region Form Loading
        private void Form_EIS_SCMR_Load(object sender, EventArgs e)
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
            {   //Title
                this.Text = " Model/BOM Tracking";
                lbl_MainTitle.Text = " Model/BOM Tracking";
                lbl_title.Text = "       Search Condition ";

                Set_Chart_Before();
                Init_Grid();
                Init_Control();
                Init_Toolbar();                
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Init_Grid()
        {
            fgrid_Main.Set_Grid("EIS_TD_MONITORING", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.ExtendLastCol = false;
            fgrid_Main.AllowSorting = AllowSortingEnum.None;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;
            fgrid_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Main.Tree.Column = (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxITEM_01;
            
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxLKS_FGA_QTY, fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxPRO_FGA_QTY).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxSUM_FGA_QTY, fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxPRO_FGA_QTY).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxMODEL_CNT, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxBOM_CNT).StyleNew.BackColor = Color.LightPink;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxMODEL_CNT, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxBOM_CNT).StyleNew.ForeColor = Color.Black;
        }
        private void Init_Control()
        {
            // Factory Combobox Setting
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_Factory.SelectedIndex = 0;

            // Season Combobox Setting            
            dt_ret = SELECT_SEASON();
            string season = DateTime.Now.Month.ToString();
            if (season.Equals("1") || season.Equals("2") || season.Equals("3"))
                season = DateTime.Now.Year.ToString() + "02";
            else if (season.Equals("4") || season.Equals("5") || season.Equals("6"))
                season = DateTime.Now.Year.ToString() + "03";
            else if (season.Equals("7") || season.Equals("8") || season.Equals("9"))
                season = DateTime.Now.Year.ToString() + "04";
            else if (season.Equals("10") || season.Equals("11") || season.Equals("12"))
                season = DateTime.Now.AddYears(1).Year.ToString() + "01";

            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Season_from, 0, 1, false, 0, 100);
            cmb_Season_from.SelectedValue = "200904";
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Season_to, 0, 1, false, 0, 100);
            cmb_Season_to.SelectedValue = "200904";

            // Category Combobox Setting
            dt_ret = SELECT_CATEGORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_Category.SelectedIndex = 0;

            // TD Combobox Setting
            dt_ret = SELECT_TD();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_TD_from, 0, 1, true, 0, 100);
            cmb_TD_from.SelectedIndex = 0;

            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_TD_to, 0, 1, true, 0, 100);
            cmb_TD_to.SelectedIndex = 0;

            dt_ret = SELECT_MODEL();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Model2, 0, 1, true, 100, 200);
            cmb_Model2.SelectedIndex = 0;

            dt_ret = SELECT_ROUND();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round_from, 0, 1, false, 0, 100);
            cmb_round_from.SelectedValue = "K";

            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_round_to, 0, 1, false, 0, 100);
            cmb_round_to.SelectedValue = "K";

            #region Chart Dislpay ComboBox
            cmb_chart_cat.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_chart_cat.ClearItems();

            cmb_chart_cat.AddItemTitles("Code;Name");
            cmb_chart_cat.ValueMember = "Code";
            cmb_chart_cat.DisplayMember = "Name";
            cmb_chart_cat.AddItem("BOM;BOM");            
            cmb_chart_cat.AddItem("MODEL;MODEL");

            cmb_chart_cat.SelectedIndex = -1;
            cmb_chart_cat.MaxDropDownItems = 10;
            cmb_chart_cat.Splits[0].DisplayColumns[0].Width = 0;
            cmb_chart_cat.Splits[0].DisplayColumns[1].Width = 150;

            cmb_chart_cat.ExtendRightColumn = true;
            cmb_chart_cat.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_chart_cat.HScrollBar.Height = 0;
            cmb_chart_cat.SelectedIndex = 0;
            #endregion

            //radio btn setting
            lbl_viewSeason.Checked   = false;
            lbl_viewFactory.Checked  = false;
            lbl_viewCategory.Checked = true;
            lbl_viewModel.Checked    = false;
            lbl_viewBom.Checked      = false;

            dt_ret.Dispose();

            init_flg = false;
        }
        private void Init_Toolbar()
        {
            // Disabled tbutton
            tbtn_Print.Enabled  = false;
            tbtn_Save.Enabled   = false;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled  = false;
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
        private DataTable SELECT_TD()
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_TD_CMB_LIST";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[1] = "ARG_SEASON_TO";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_Season_from.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = cmb_Season_to.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_MODEL()
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_MODEL_LIST";

            MyOraDB.ReDim_Parameter(5);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
            MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = cmb_Season_from.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = cmb_Season_to.SelectedValue.ToString();
            MyOraDB.Parameter_Values[3] = cmb_Category.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = "";
            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_ROUND()
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_ROUND_LIST";

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
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {                
                this.Cursor = Cursors.WaitCursor;

                string[] arg_value = new string[9];
                arg_value[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
                arg_value[1] = COM.ComFunction.Empty_Combo(cmb_Season_from, "");
                arg_value[2] = COM.ComFunction.Empty_Combo(cmb_Season_to, "");                
                arg_value[3] = COM.ComFunction.Empty_Combo(cmb_Category, "");
                arg_value[4] = COM.ComFunction.Empty_Combo(cmb_TD_from, "");
                arg_value[5] = COM.ComFunction.Empty_Combo(cmb_TD_to, "");
                arg_value[6] = COM.ComFunction.Empty_Combo(cmb_Model2, "");
                arg_value[7] = COM.ComFunction.Empty_Combo(cmb_round_from, "");
                arg_value[8] = COM.ComFunction.Empty_Combo(cmb_round_to, "");

                DataTable dt_ret = SELECT_MODEL_BOM_LIST(arg_value);
                                
                Display_Grid(dt_ret, fgrid_Main);

                Set_Chart_Before();

                if (dt_ret.Rows.Count > 0)
                {
                    DataSet vDS = MakeChartData();
                    Display_Chart(vDS);
                }

                dt_ret.Dispose();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #region Grid Data Search
        private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
        {
            try
            {
                arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;

                if (arg_dt.Rows.Count > 0)
                {
                    for (int i = 0; i < arg_dt.Rows.Count; i++)
                    {
                        vTreeLevel = int.Parse(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxLEV].ToString());
                        arg_fgrid.Rows.InsertNode(arg_fgrid.Rows.Count, vTreeLevel);

                        for (int j = 0; j < arg_fgrid.Cols.Count; j++)
                        {
                            if (j >= (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxDPO_QTY)
                            {
                                if (arg_dt.Rows[i].ItemArray[j].ToString().Trim().Equals("0"))
                                    arg_fgrid[arg_fgrid.Rows.Count - 1, j] = "";
                                else
                                {
                                    try
                                    {
                                        arg_fgrid[arg_fgrid.Rows.Count - 1, j] = double.Parse(arg_dt.Rows[i].ItemArray[j].ToString()).ToString("#,###.##");
                                    }
                                    catch
                                    {
                                        arg_fgrid[arg_fgrid.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                                    }
                                }
                            }
                            else
                                arg_fgrid[arg_fgrid.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                        }

                        Set_Grid_Color(arg_dt, fgrid_Main);
                    }

                    Radio_Button_Check(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Set_Grid_Color(DataTable arg_dt, COM.FSP arg_fgrid)
        {
            if (vTreeLevel.Equals(1))
            {
                arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(255, 255, 153);
            }
            else if (vTreeLevel.Equals(2))
            {
                arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(204, 255, 255);
            }
            else if (vTreeLevel.Equals(3))
            {
                arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(236, 246, 206);
            }
            else if (vTreeLevel.Equals(4))
            {
                arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.BackColor = Color.Beige;
            }
            else
            {
                arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke;
            }
            
        }
        
        private DataTable SELECT_MODEL_BOM_LIST(string [] arg_value)
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_MODEL_BOM_LIST";

            MyOraDB.ReDim_Parameter(10);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
            MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
            MyOraDB.Parameter_Name[4] = "ARG_TD_FROM";
            MyOraDB.Parameter_Name[5] = "ARG_TD_TO";
            MyOraDB.Parameter_Name[6] = "ARG_SRF_NO";
            MyOraDB.Parameter_Name[7] = "ARG_ROUND_F";
            MyOraDB.Parameter_Name[8] = "ARG_ROUND_T";
            MyOraDB.Parameter_Name[9] = "OUT_CURSOR";

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
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion

        #region Chart Data Search
        private DataSet MakeChartData()
        {
            try
            {
                DataTable vDT_CATEGORY       = new DataTable("CATEGORY DataTable");
                DataTable vDT_TD             = new DataTable("TD DataTable");
                DataTable vDT_ROUND          = new DataTable("Round DataTable");

                DataSet vDSChartData = new DataSet("Chart DataSet");

                if (fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed)
                {
                    int viTitle1Row    = fgrid_Main.Rows.Fixed - 2;
                    int viTitle2Row    = fgrid_Main.Rows.Fixed - 1;
                    string vsCurSeason = fgrid_Main[fgrid_Main.Row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxSEASON_CD].ToString();
                                      
                    #region Category
                    vDT_CATEGORY.Columns.Add(new DataColumn("X_LABLE"));
                    vDT_CATEGORY.Columns.Add("PCC");
                    vDT_CATEGORY.Columns.Add("QD");
                    vDT_CATEGORY.Columns.Add("VJ");                                       

                    for (int cat_cnt = 10; cat_cnt <= 90; cat_cnt += 10)
                    {
                        if (cat_cnt.ToString().Equals("20") || cat_cnt.ToString().Equals("60"))
                            continue;

                        object ds_cat = "0";
                        object qd_cat = "0";
                        object vj_cat = "0";
                        object x_label = "";


                        for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count; row++)
                        {
                            if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxSEASON_CD].ToString().Equals(vsCurSeason))
                            {
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxLEV].ToString().Equals("3"))
                                {
                                    if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxFACTORY].ToString().Equals("DS") && fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxCATEGORY].ToString().Equals(cat_cnt.ToString()))
                                    {
                                        if(cmb_chart_cat.SelectedValue.ToString().Equals("BOM"))
                                            ds_cat = fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxBOM_CNT].ToString();
                                        else
                                            ds_cat = fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxMODEL_CNT].ToString();
                                    }
                                    if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxFACTORY].ToString().Equals("QD") && fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxCATEGORY].ToString().Equals(cat_cnt.ToString()))
                                    {
                                        if (cmb_chart_cat.SelectedValue.ToString().Equals("BOM"))
                                            qd_cat = fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxBOM_CNT].ToString();
                                        else
                                            qd_cat = fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxMODEL_CNT].ToString();
                                    }
                                    if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxFACTORY].ToString().Equals("VJ") && fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxCATEGORY].ToString().Equals(cat_cnt.ToString()))
                                    {
                                        if (cmb_chart_cat.SelectedValue.ToString().Equals("BOM"))
                                            vj_cat = fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxBOM_CNT].ToString();
                                        else
                                            vj_cat = fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxMODEL_CNT].ToString();
                                    }
                                }
                            }
                        }

                        if(cat_cnt.ToString().Equals("10"))
                            x_label = "Running";                        
                        else if(cat_cnt.ToString().Equals("30"))
                            x_label = "WS Training";
                        else if(cat_cnt.ToString().Equals("40"))
                            x_label = "Sports Culture";
                        else if(cat_cnt.ToString().Equals("50"))
                            x_label = "Tennis";                        
                        else if(cat_cnt.ToString().Equals("70"))
                            x_label = "Kids";
                        else if(cat_cnt.ToString().Equals("80"))
                            x_label = "Track & Field";
                        else if (cat_cnt.ToString().Equals("90"))
                            x_label = "Core Performance";

                        DataRow dr_CATEGORY = vDT_CATEGORY.NewRow();

                        dr_CATEGORY["X_LABLE"] = x_label;
                        dr_CATEGORY["PCC"] = ds_cat;
                        dr_CATEGORY["QD"] = qd_cat;
                        dr_CATEGORY["VJ"] = vj_cat;

                        vDT_CATEGORY.Rows.Add(dr_CATEGORY);
                    }
                    #endregion

                    #region TD
                    string season_name = "";
                    int TD_A1 = 0;
                    int TD_A2 = 0;
                    int TD_A3 = 0;
                    int TD_B1 = 0;
                    int TD_B2 = 0;
                    int TD_B3 = 0;
                    int TD_C1 = 0;
                    int TD_C2 = 0;
                    int TD_C3 = 0;
                    int TD_D1 = 0;
                    int TD_D2 = 0;
                    int TD_D3 = 0;
                    int TD_E1 = 0;
                    int TD_E2 = 0;
                    int TD_E3 = 0;
                    int TD_F1 = 0;
                    int TD_F2 = 0;
                    int TD_F3 = 0;
                    
                    for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count; row++)
                    {
                        if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxSEASON_CD].ToString().Equals(vsCurSeason))
                        {
                            if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxLEV].ToString().Equals("1"))
                            {
                                vsCurSeason_name = fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxITEM_01].ToString();
                                season_name = fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxITEM_01].ToString(); 
                            }
                            else if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxLEV].ToString().Equals("5"))
                            {
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("A+"))
                                    TD_A1 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("A"))
                                    TD_A2 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("A-"))
                                    TD_A3 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("B+"))
                                    TD_B1 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("B"))
                                    TD_B2 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("B-"))
                                    TD_B3 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("C+"))
                                    TD_C1 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("C"))
                                    TD_C2 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("C-"))
                                    TD_C3 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("D+"))
                                    TD_D1 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("D"))
                                    TD_D2 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("D-"))
                                    TD_D3 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("E+"))
                                    TD_E1 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("E"))
                                    TD_E2 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("E-"))
                                    TD_E3 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("F+"))
                                    TD_F1 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("F"))
                                    TD_F2 += 1;
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxT_D].ToString().Equals("F-"))
                                    TD_F3 += 1;
                            }                            
                        }
                    }
                    vDT_TD.Columns.Add(new DataColumn("X_LABLE"));
                    vDT_TD.Columns.Add(season_name);
                    
                    DataRow dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "A+";                          
                    dr_TD[season_name] = TD_A1;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "A";  
                    dr_TD[season_name]  = TD_A2;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "A-";  
                    dr_TD[season_name] = TD_A3;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "B+";  
                    dr_TD[season_name] = TD_B1;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "B";  
                    dr_TD[season_name]  = TD_B2;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "B-";  
                    dr_TD[season_name] = TD_B3;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "C+";  
                    dr_TD[season_name] = TD_C1;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "C";  
                    dr_TD[season_name]  = TD_C2;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "C-";  
                    dr_TD[season_name] = TD_C3;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "D+";  
                    dr_TD[season_name] = TD_D1;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "D";  
                    dr_TD[season_name]  = TD_D2;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "D-";  
                    dr_TD[season_name] = TD_D3;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "E+";  
                    dr_TD[season_name] = TD_E1;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "E";  
                    dr_TD[season_name]  = TD_E2;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "E-";  
                    dr_TD[season_name] = TD_E3;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "F+";  
                    dr_TD[season_name] = TD_F1;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "F";  
                    dr_TD[season_name]  = TD_F2;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;

                    dr_TD = vDT_TD.NewRow();
                    dr_TD["X_LABLE"] = "F-";  
                    dr_TD[season_name] = TD_F3;
                    vDT_TD.Rows.Add(dr_TD);
                    dr_TD = null;                    
                    #endregion                  

                    #region Round
                    vDT_ROUND.Columns.Add(new DataColumn("X_LABLE"));                    
                    vDT_ROUND.Columns.Add("PCC");
                    vDT_ROUND.Columns.Add("QD");
                    vDT_ROUND.Columns.Add("VJ");
                    vDT_ROUND.Columns.Add("Total");
                    int total_qty = 0;
                    int pcc_qty   = 0;
                    int qd_qty    = 0;
                    int vj_qty    = 0;

                    for (int col = (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxLKS_FGA_QTY; col <= (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxPRO_FGA_QTY; col++)
                    {
                        for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count; row++)
                        {
                            if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxSEASON_CD].ToString().Equals(vsCurSeason))
                            {
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxLEV].ToString().Equals("1"))
                                {
                                    string qty = (fgrid_Main[row, col] == null || fgrid_Main[row, col].ToString().Trim() == "") ? "0" : fgrid_Main[row, col].ToString().Trim();

                                    try
                                    {
                                        total_qty = int.Parse(qty);
                                    }
                                    catch
                                    {
                                        total_qty = 0;
                                    } 
                                }
                                else if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxLEV].ToString().Equals("2"))
                                {
                                    if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxFACTORY].ToString().Equals("DS"))
                                    {
                                        string qty = (fgrid_Main[row, col] == null || fgrid_Main[row, col].ToString().Trim() == "") ? "0" :fgrid_Main[row, col].ToString().Trim();

                                        try
                                        {
                                            pcc_qty = int.Parse(qty);
                                        }
                                        catch
                                        {
                                            pcc_qty = 0; 
                                        }
                                    }
                                    if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxFACTORY].ToString().Equals("QD"))
                                    {
                                        string qty = (fgrid_Main[row, col] == null || fgrid_Main[row, col].ToString().Trim() == "") ? "0" : fgrid_Main[row, col].ToString().Trim();

                                        try
                                        {
                                            qd_qty = int.Parse(qty);
                                        }
                                        catch
                                        {
                                            qd_qty = 0;
                                        }
                                    }
                                    if (fgrid_Main[row, (int)ClassLib.TBEIS_MODEL_BOM_TRACKING_NEW.IxFACTORY].ToString().Equals("VJ"))
                                    {
                                        string qty = (fgrid_Main[row, col] == null || fgrid_Main[row, col].ToString().Trim() == "") ? "0" : fgrid_Main[row, col].ToString().Trim();

                                        try
                                        {
                                            vj_qty = int.Parse(qty);
                                        }
                                        catch
                                        {
                                            vj_qty = 0;
                                        }
                                    }
                                }
                            }
                        }

                        DataRow dr_ROUND = vDT_ROUND.NewRow();
                        dr_ROUND["X_LABLE"] = fgrid_Main[fgrid_Main.Rows.Fixed - 1, col].ToString().Trim();
                        dr_ROUND["PCC"] = pcc_qty;
                        dr_ROUND["QD"] = qd_qty;
                        dr_ROUND["VJ"] = vj_qty;
                        dr_ROUND["Total"] = total_qty;
                        vDT_ROUND.Rows.Add(dr_ROUND);
                    }
                    #endregion                    
                }

                vDSChartData.Tables.AddRange(new DataTable[] { vDT_CATEGORY, vDT_TD, vDT_ROUND });
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
            DataTable vDT_CATEGORY       = arg_ds.Tables[0];
            DataTable vDT_TD             = arg_ds.Tables[1];
            DataTable vDT_ROUND          = arg_ds.Tables[2];
                                    
            #region Category
            chart_Category.Data.Series = vDT_CATEGORY.Columns.Count;
            chart_Category.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("X_LABLE", ChartFX.WinForms.FieldUsage.Label));

            for (int i = 1; i < vDT_CATEGORY.Columns.Count; i++)
            {
                chart_Category.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap(vDT_CATEGORY.Columns[i].ColumnName.ToString(), ChartFX.WinForms.FieldUsage.Value));
            }

            chart_Category.DataSource = vDT_CATEGORY;

            chart_Category.View3D.Enabled = false;
            chart_Category.ToolTipFormat = "%v";
            chart_Category.LegendBox.Visible = true;
            chart_Category.AllSeries.PointLabels.Visible = true;
            chart_Category.AllSeries.Gallery = Gallery.Bar;
            chart_Category.AllSeries.Volume = 30;
            chart_Category.LegendBox.Dock = ChartFX.WinForms.DockArea.Bottom;
            chart_Category.Font = new System.Drawing.Font("Verdana", 8F, FontStyle.Bold);
            chart_Category.AllSeries.FillMode = FillMode.Gradient;
            chart_Category.AxisY.Step = 50;
            chart_Category.Cursor = Cursors.Arrow;

            if(cmb_chart_cat.SelectedValue.ToString().Equals("BOM"))
                chart_Category.AxisY.Title.Text = "BOM Count";
            else
                chart_Category.AxisY.Title.Text = "MODEL Count";

            chart_Category.AxisY.Title.Font = new System.Drawing.Font("Verdana", 8F, FontStyle.Bold);
            chart_Category.AxisY.Title.Alignment = StringAlignment.Far;
            chart_Category.Titles.Add(new TitleDockable(vsCurSeason_name));
            chart_Category.Titles[chart_Category.Titles.Count - 1].Font = new Font("Verdana", 10F, FontStyle.Bold);
            chart_Category.Titles[chart_Category.Titles.Count - 1].Alignment = StringAlignment.Center;
            #endregion

            #region TD
            chart_TD.Data.Series = vDT_TD.Columns.Count;
            chart_TD.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("X_LABLE", ChartFX.WinForms.FieldUsage.Label));

            for (int i = 1; i < vDT_TD.Columns.Count; i++)
            {
                chart_TD.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap(vDT_TD.Columns[i].ColumnName.ToString(), ChartFX.WinForms.FieldUsage.Value));
            }

            chart_TD.DataSource = vDT_TD;

            chart_TD.View3D.Enabled = false;
            chart_TD.ToolTipFormat = "%v";
            chart_TD.LegendBox.Visible = false;
            chart_TD.AllSeries.PointLabels.Visible = true;
            chart_TD.AllSeries.Gallery = Gallery.Bar;
            chart_TD.AllSeries.Volume = 30;
            chart_TD.LegendBox.Dock = ChartFX.WinForms.DockArea.Bottom;
            chart_TD.Font = new System.Drawing.Font("Verdana", 8F, FontStyle.Bold);
            chart_TD.AllSeries.FillMode = FillMode.Gradient;
            chart_TD.AxisY.Step = 50;
            chart_TD.Cursor = Cursors.Arrow;
            chart_TD.AxisY.Title.Text = "TD Count";
            chart_TD.AxisY.Title.Font = new System.Drawing.Font("Verdana", 8F, FontStyle.Bold);
            chart_TD.AxisY.Title.Alignment = StringAlignment.Far;
            chart_TD.Titles.Add(new TitleDockable(vsCurSeason_name));
            chart_TD.Titles[chart_TD.Titles.Count - 1].Font = new Font("Verdana", 10F, FontStyle.Bold);
            chart_TD.Titles[chart_TD.Titles.Count - 1].Alignment = StringAlignment.Center;
            #endregion      
      
            #region Round
            chart_round.Data.Series = vDT_ROUND.Columns.Count;
            chart_round.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("X_LABLE", ChartFX.WinForms.FieldUsage.Label));

            for (int i = 1; i < vDT_ROUND.Columns.Count; i++)
            {
                chart_round.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap(vDT_ROUND.Columns[i].ColumnName.ToString(), ChartFX.WinForms.FieldUsage.Value));
            }

            chart_round.DataSource = vDT_ROUND;

            chart_round.View3D.Enabled = false;
            chart_round.ToolTipFormat = "%v";
            chart_round.LegendBox.Visible = true;
            chart_round.AllSeries.PointLabels.Visible = true;
            chart_round.AllSeries.Gallery = Gallery.Bar;
            chart_round.Series[3].Gallery = Gallery.Curve;
            chart_round.AllSeries.Volume = 30;
            chart_round.LegendBox.Dock = ChartFX.WinForms.DockArea.Bottom;
            chart_round.Font = new System.Drawing.Font("Verdana", 8F, FontStyle.Bold);
            chart_round.AllSeries.FillMode = FillMode.Gradient;
            chart_round.Cursor = Cursors.Arrow;
            chart_round.AxisY.Title.Text = "BOM Count";
            chart_round.AxisY.Title.Font = new System.Drawing.Font("Verdana", 8F, FontStyle.Bold);
            chart_round.AxisY.Title.Alignment = StringAlignment.Far;
            chart_round.Titles.Add(new TitleDockable(vsCurSeason_name));
            chart_round.Titles[chart_round.Titles.Count - 1].Font = new Font("Verdana", 10F, FontStyle.Bold);
            chart_round.Titles[chart_round.Titles.Count - 1].Alignment = StringAlignment.Center;
            #endregion
        }
        private void Set_Chart_Before()
        {            
            //chart_TD
            _memoryStream.Position = 0;
            chart_TD.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_TD.Data.Clear();
            
            //chart_Category
            _memoryStream.Position = 0;
            chart_Category.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_Category.Data.Clear();

            //chart_round
            _memoryStream.Position = 0;
            chart_round.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_round.Data.Clear();    
        }        
        #endregion

        #endregion
                
        #region Grid Event
        private void fgrid_Main_Click(object sender, EventArgs e)
        {
            try
            {        
                Set_Chart_Before();
                DataSet vDS = MakeChartData();
                Display_Chart(vDS);
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
        private void Radio_Button_Check(object sender, EventArgs e)
        {           
            if (lbl_viewSeason.Checked)
                fgrid_Main.Tree.Show(1);
            else if (lbl_viewFactory.Checked)
                fgrid_Main.Tree.Show(2);
            else if (lbl_viewCategory.Checked)
                fgrid_Main.Tree.Show(3);
            else if (lbl_viewModel.Checked)
                fgrid_Main.Tree.Show(4);
            else
                fgrid_Main.Tree.Show(5);            
        }        

        private void cmb_Category_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt_ret;

            if (init_flg) return;

            dt_ret = SELECT_MODEL();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Model2, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_Model2.SelectedIndex = 0;
        }

        private void cmb_TD_from_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_TD_to.SelectedIndex == -1) return;

            if (cmb_TD_from.SelectedIndex <= cmb_TD_to.SelectedIndex)
                return;
            else
                cmb_TD_to.SelectedIndex = cmb_TD_from.SelectedIndex;

            cmb_Category.SelectedIndex = 0;
            cmb_Model2.SelectedIndex = 0;            
        }
        private void cmb_TD_to_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_TD_from.SelectedIndex <= cmb_TD_to.SelectedIndex)
                return;
            else
                cmb_TD_to.SelectedIndex = cmb_TD_from.SelectedIndex;
            cmb_TD_to.SelectedIndex = cmb_TD_from.SelectedIndex;


            cmb_Category.SelectedIndex = 0;
            cmb_Model2.SelectedIndex = 0;
        }

        private void cmb_chart_cat_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Set_Chart_Before();
                DataSet vDS = MakeChartData();
                Display_Chart(vDS);
            }
            catch
            {

            }
        }

        private void cmb_round_from_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_round_from.SelectedIndex < 0)
                    return;

                if (cmb_round_from.SelectedIndex > cmb_round_to.SelectedIndex)
                    cmb_round_to.SelectedIndex = cmb_round_from.SelectedIndex;
            }
            catch
            {
 
            }
        }

        private void cmb_round_to_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_round_to.SelectedIndex < 0)
                    return;

                if (cmb_round_from.SelectedIndex > cmb_round_to.SelectedIndex)
                    cmb_round_from.SelectedIndex = cmb_round_to.SelectedIndex;
            }
            catch
            {
 
            }
        }
        #endregion
    }
}
               
