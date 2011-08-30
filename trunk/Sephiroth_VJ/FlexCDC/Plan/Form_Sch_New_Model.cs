using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;
using ChartFX.WinForms;
using ChartFX.WinForms.Annotation;
using ChartFX.WinForms.DataProviders;
using System.Diagnostics;
using System.Threading;
using C1.Win.C1Chart;

namespace FlexCDC.Plan
{
    public partial class Form_Sch_New_Model : COM.PCHWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 立加 俺眉 积己        
        private System.IO.MemoryStream _memoryStream;
        private bool first_flg = false;
        private bool grid_flg = false;
        #endregion

        #region Resource
        public Form_Sch_New_Model()
        {                        
            InitializeComponent();

            _memoryStream = new System.IO.MemoryStream();
            chart_Category.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);            
        }
        #endregion

        #region Form Loading
        private void Form_Sch_New_Model_Load(object sender, EventArgs e)
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
            this.Text = "PCC_New Model Tracking";
            this.lbl_MainTitle.Text = "PCC_New Model Tracking";
            ClassLib.ComFunction.SetLangDic(this);

            #region ComboBox Setting
            //Factory
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_factory.SelectedIndex = 0;

            dt_ret = SELECT_SEASON();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            
            cmb_season_from.SelectedValue = "201004";
            cmb_season_to.SelectedValue = "201102";
            
            //Category
            dt_ret = SELECT_CATEGORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_category.SelectedIndex = 0;

            //User
            dt_ret = SELECT_USER();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_user.SelectedIndex = 0;

            //Chart
            first_flg = true;
            cmb_chart.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            cmb_chart.ClearItems();

            cmb_chart.AddItemTitles("Code;Name");

            cmb_chart.ValueMember = "Code";
            cmb_chart.DisplayMember = "Name";

            cmb_chart.AddItem(";Total");
            cmb_chart.AddItem("QD;QD");
            cmb_chart.AddItem("VJ;VJ");

            cmb_chart.SelectedIndex = -1;

            cmb_chart.MaxDropDownItems = 10;
            cmb_chart.Splits[0].DisplayColumns[0].Width = 0;
            cmb_chart.Splits[0].DisplayColumns[1].Width = 150;

            cmb_chart.ExtendRightColumn = true;
            cmb_chart.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
            cmb_chart.HScrollBar.Height = 0;

            cmb_chart.SelectedIndex = 0;
            first_flg = false;
            #endregion

            #region Grid Setting 
            //Main Grid
            fgrid_main.Set_Grid_CDC("SXC_SCH_NEW_MODEL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.AllowSorting  = AllowSortingEnum.None;
            fgrid_main.ExtendLastCol = false;            
            #endregion

            #region Control Setting
            tbtn_New.Enabled     = false;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = false;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = true;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;

            txt_model.CharacterCasing = CharacterCasing.Upper;
            #endregion 

            chart_Category.Data.Clear();            
        }
        private void Set_Chart_Before()
        {
            //chart_Category
            _memoryStream.Position = 0;
            chart_Category.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_Category.Data.Clear();            
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

                MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
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

            string[] arg_value = new string[6];

            arg_value[0] = cmb_factory.SelectedValue.ToString();
            arg_value[1] = cmb_season_from.SelectedValue.ToString();
            arg_value[2] = cmb_season_to.SelectedValue.ToString();
            arg_value[3] = cmb_category.SelectedValue.ToString();
            arg_value[4] = cmb_user.SelectedValue.ToString();
            arg_value[5] = txt_model.Text.Trim();

            DataTable dt_ret = SELECT_NEW_MODEL_TRACKING(arg_value);

            if (dt_ret.Rows.Count > 0)
            {
                Display_Grid(dt_ret);
                                
                fgrid_main.Select(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL);

                Set_Chart_Before();
                Display_Chart();             
            }            
        }
        private void Display_Grid(DataTable arg_dt)
        {
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                fgrid_main.Rows.Add();
                fgrid_main.Rows[fgrid_main.Rows.Count - 1].Height = 50;
                for (int j = 0; j < fgrid_main.Cols.Count; j++)
                {
                    if (j.Equals((int)ClassLib.TBSXC_SCH_NEW_MODEL.IxIMAGE))
                    {
                        try
                        {
                            byte[] MyData = null;
                            MyData = (byte[])arg_dt.Rows[i].ItemArray[j];

                            MemoryStream ms = new MemoryStream(MyData);
                            Size imgsize = new Size(100, 50);
                            System.Drawing.Bitmap true_image = new System.Drawing.Bitmap(ms);
                            Image img = true_image;
                            System.Drawing.Bitmap grid_image = new System.Drawing.Bitmap(img, imgsize);
                            img = grid_image;

                            Hashtable Imgmap = new Hashtable();
                            Imgmap.Clear();
                            Imgmap.Add("", img);

                            fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, j).StyleNew.ImageMap = Imgmap;
                        }
                        catch
                        {
                            fgrid_main[fgrid_main.Rows.Count - 1, j] = "";
                        }
                    }
                    else
                    {
                        fgrid_main[fgrid_main.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j].ToString().Trim();
                    }
                }
            }

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMS, fgrid_main.Rows.Count - 1, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxUPD_YMD).StyleNew.BackColor = Color.White;
        }
        
        private void Display_Chart()
        {
            string vsCurSeason = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxSEASON].ToString();
            
            DataSet vDS = MakeChartData();
            DataTable vDT_CATEGORY = vDS.Tables[0];            

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

            chart_Category.Font = new System.Drawing.Font("Verdana", 6F, FontStyle.Bold);
            chart_Category.LegendBox.Font = new System.Drawing.Font("Verdana", 7F, FontStyle.Bold);
            chart_Category.AxisY.Font = new System.Drawing.Font("Verdana", 7F, FontStyle.Bold);
            chart_Category.AxisX.Font = new System.Drawing.Font("Verdana", 8F, FontStyle.Bold);
            
            
            chart_Category.AllSeries.PointLabels.Visible = true;
            chart_Category.AllSeries.Gallery = Gallery.Bar;
            chart_Category.AllSeries.FillMode = FillMode.Gradient;
            chart_Category.AllSeries.Volume = 30;
            chart_Category.Series[0].Gallery = Gallery.Curve;            

            chart_Category.LegendBox.Visible = true;
            chart_Category.LegendBox.Dock = ChartFX.WinForms.DockArea.Right;
                        
            chart_Category.AxisY.Step = 1000;
            chart_Category.AxisY.DataFormat.Format = AxisFormat.Number;
            chart_Category.AxisY.LabelsFormat.Format = AxisFormat.Number;
            chart_Category.AxisY.Title.Alignment = StringAlignment.Far;
            chart_Category.Cursor = Cursors.Default;

            string title = cmb_season_from.SelectedText + " - " + cmb_season_to.SelectedText;
            if (!cmb_chart.SelectedValue.ToString().Trim().Equals(""))
            {
                title = cmb_chart.SelectedValue.ToString().Trim() + " : " + title;
            }            
            
            TitleDockable t_01 = new TitleDockable(title);
            t_01.Font = new System.Drawing.Font("Verdana", 13F, FontStyle.Bold);
            chart_Category.Titles.Add(t_01);            
            #endregion            
        }
        private DataSet MakeChartData()
        {
            try
            {
                DataTable vDT_CATEGORY = new DataTable("CATEGORY DataTable");
                DataSet vDSChartData = new DataSet("Chart DataSet");

                if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
                {                    
                    vDT_CATEGORY.Columns.Add(new DataColumn("X_LABLE"));
                    vDT_CATEGORY.Columns.Add("Total");
                    vDT_CATEGORY.Columns.Add("Ruuning");
                    vDT_CATEGORY.Columns.Add("WS Training");
                    vDT_CATEGORY.Columns.Add("Sports Culture");
                    vDT_CATEGORY.Columns.Add("Court");
                    vDT_CATEGORY.Columns.Add("Young athletes");
                    vDT_CATEGORY.Columns.Add("Track & Field");
                    vDT_CATEGORY.Columns.Add("Core Performance");

                    DataTable dt_season = SELECT_SCH_SEASON_CHART();

                    if (dt_season.Rows.Count > 0)
                    {
                        object x_label = "";

                        string chart_div = cmb_chart.SelectedValue.ToString().Trim();

                        for (int i = 0; i < dt_season.Rows.Count; i++)
                        {
                            #region Data Creation
                            string season = dt_season.Rows[i].ItemArray[0].ToString().Trim();
                            x_label = season;

                            double category_total = 0; //Total
                            double category_rn = 0; //10
                            double category_ws = 0; //30
                            double category_sc = 0; //40
                            double category_ct = 0; //50
                            double category_ya = 0; //70
                            double category_tf = 0; //80
                            double category_cp = 0; //90

                            for (int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++)
                            {
                                string season_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxSEASON].ToString().Trim();

                                if (season.Equals(season_row))
                                {
                                    string category = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxCATEGORY].ToString().Trim();

                                    if (category.Equals("10")) 
                                    {
                                        #region Running
                                        if (chart_div.Equals(""))
                                        {
                                            #region Total
                                            try
                                            {
                                                string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                double forecast_result = 0;
                                                if (!forecast_row.Equals(""))
                                                {
                                                    string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                    forecast_result = double.Parse(forecast_cut);
                                                }

                                                string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                double target_fob_result = 0;
                                                if (!target_fob_row.Equals(""))
                                                {
                                                    string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                    target_fob_result = double.Parse(target_fob_cut);
                                                }

                                                double value = forecast_result * target_fob_result;
                                                category_rn += value;

                                            }
                                            catch (Exception ex)
                                            {
                                                string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                return null;
                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("QD"))
                                        {
                                            #region QD
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("QD"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_rn += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("VJ"))
                                        {
                                            #region VJ
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("VJ"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_rn += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        #endregion
                                    }
                                    else if (category.Equals("30"))
                                    {
                                        #region WS Training
                                        if (chart_div.Equals(""))
                                        {
                                            #region Total
                                            try
                                            {
                                                string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                double forecast_result = 0;
                                                if (!forecast_row.Equals(""))
                                                {
                                                    string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                    forecast_result = double.Parse(forecast_cut);
                                                }

                                                string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                double target_fob_result = 0;
                                                if (!target_fob_row.Equals(""))
                                                {
                                                    string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                    target_fob_result = double.Parse(target_fob_cut);
                                                }

                                                double value = forecast_result * target_fob_result;
                                                category_ws += value;

                                            }
                                            catch (Exception ex)
                                            {
                                                string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                return null;
                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("QD"))
                                        {
                                            #region QD
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("QD"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_ws += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("VJ"))
                                        {
                                            #region VJ
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("VJ"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_ws += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        #endregion
                                    }
                                    else if (category.Equals("40"))
                                    {
                                        #region Sports Culture
                                        if (chart_div.Equals(""))
                                        {
                                            #region Total
                                            try
                                            {
                                                string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                double forecast_result = 0;
                                                if (!forecast_row.Equals(""))
                                                {
                                                    string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                    forecast_result = double.Parse(forecast_cut);
                                                }

                                                string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                double target_fob_result = 0;
                                                if (!target_fob_row.Equals(""))
                                                {
                                                    string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                    target_fob_result = double.Parse(target_fob_cut);
                                                }

                                                double value = forecast_result * target_fob_result;
                                                category_sc += value;

                                            }
                                            catch (Exception ex)
                                            {
                                                string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                return null;
                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("QD"))
                                        {
                                            #region QD
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("QD"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_sc += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("VJ"))
                                        {
                                            #region VJ
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("VJ"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_sc += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        #endregion
                                    }
                                    else if (category.Equals("50"))
                                    {
                                        #region Court
                                        if (chart_div.Equals(""))
                                        {
                                            #region Total
                                            try
                                            {
                                                string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                double forecast_result = 0;
                                                if (!forecast_row.Equals(""))
                                                {
                                                    string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                    forecast_result = double.Parse(forecast_cut);
                                                }

                                                string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                double target_fob_result = 0;
                                                if (!target_fob_row.Equals(""))
                                                {
                                                    string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                    target_fob_result = double.Parse(target_fob_cut);
                                                }

                                                double value = forecast_result * target_fob_result;
                                                category_ct += value;

                                            }
                                            catch (Exception ex)
                                            {
                                                string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                return null;
                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("QD"))
                                        {
                                            #region QD
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("QD"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_ct += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("VJ"))
                                        {
                                            #region VJ
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("VJ"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_ct += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        #endregion
                                    }
                                    else if (category.Equals("70"))
                                    {
                                        #region Young athletes
                                        if (chart_div.Equals(""))
                                        {
                                            #region Total
                                            try
                                            {
                                                string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                double forecast_result = 0;
                                                if (!forecast_row.Equals(""))
                                                {
                                                    string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                    forecast_result = double.Parse(forecast_cut);
                                                }

                                                string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                double target_fob_result = 0;
                                                if (!target_fob_row.Equals(""))
                                                {
                                                    string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                    target_fob_result = double.Parse(target_fob_cut);
                                                }

                                                double value = forecast_result * target_fob_result;
                                                category_ya += value;

                                            }
                                            catch (Exception ex)
                                            {
                                                string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                return null;
                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("QD"))
                                        {
                                            #region QD
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("QD"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_ya += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("VJ"))
                                        {
                                            #region VJ
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("VJ"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_ya += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        #endregion
                                    }
                                    else if (category.Equals("80"))
                                    {
                                        #region Track & Field
                                        if (chart_div.Equals(""))
                                        {
                                            #region Total
                                            try
                                            {
                                                string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                double forecast_result = 0;
                                                if (!forecast_row.Equals(""))
                                                {
                                                    string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                    forecast_result = double.Parse(forecast_cut);
                                                }

                                                string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                double target_fob_result = 0;
                                                if (!target_fob_row.Equals(""))
                                                {
                                                    string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                    target_fob_result = double.Parse(target_fob_cut);
                                                }

                                                double value = forecast_result * target_fob_result;
                                                category_tf += value;

                                            }
                                            catch (Exception ex)
                                            {
                                                string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                return null;
                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("QD"))
                                        {
                                            #region QD
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("QD"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_tf += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("VJ"))
                                        {
                                            #region VJ
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("VJ"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_tf += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        #endregion
                                    }
                                    else if (category.Equals("90"))
                                    {
                                        #region Core Performance
                                        if (chart_div.Equals(""))
                                        {
                                            #region Total
                                            try
                                            {
                                                string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                double forecast_result = 0;
                                                if (!forecast_row.Equals(""))
                                                {
                                                    string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                    forecast_result = double.Parse(forecast_cut);
                                                }

                                                string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                double target_fob_result = 0;
                                                if (!target_fob_row.Equals(""))
                                                {
                                                    string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                    target_fob_result = double.Parse(target_fob_cut);
                                                }

                                                double value = forecast_result * target_fob_result;
                                                category_cp += value;

                                            }
                                            catch (Exception ex)
                                            {
                                                string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                return null;
                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("QD"))
                                        {
                                            #region QD
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("QD"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_cp += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        else if (chart_div.Equals("VJ"))
                                        {
                                            #region VJ
                                            string factory = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFTY].ToString().Trim();

                                            if (factory.Equals("VJ"))
                                            {
                                                try
                                                {
                                                    string forecast_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    double forecast_result = 0;
                                                    if (!forecast_row.Equals(""))
                                                    {
                                                        string forecast_cut = forecast_row.Substring(0, forecast_row.Length - 1) + "000";
                                                        forecast_result = double.Parse(forecast_cut);
                                                    }

                                                    string target_fob_row = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();
                                                    double target_fob_result = 0;
                                                    if (!target_fob_row.Equals(""))
                                                    {
                                                        string target_fob_cut = target_fob_row.Substring(1, target_fob_row.Length - 1);
                                                        target_fob_result = double.Parse(target_fob_cut);
                                                    }

                                                    double value = forecast_result * target_fob_result;
                                                    category_cp += value;

                                                }
                                                catch (Exception ex)
                                                {
                                                    string model = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL].ToString().Trim();
                                                    string forecast = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFORECAST].ToString().Trim();
                                                    string target_fob = fgrid_main[row, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxTARGET_FOB].ToString().Trim();

                                                    MessageBox.Show(model + "\r\n" + "Forecast : " + forecast + "\r\n" + "Target FOB : " + target_fob + "\r\n\r\n" + ex.ToString());
                                                    return null;
                                                }

                                            }
                                            #endregion
                                        }
                                        #endregion
                                    }

                                    category_total = category_rn + category_ws + category_sc + category_ct + category_ya + category_tf + category_cp;
                                }
                            }
                            #endregion

                            DataRow dr_CATEGORY = vDT_CATEGORY.NewRow();

                            category_total = category_total / 1000; //Total
                            category_rn = category_rn / 1000; //10
                            category_ws = category_ws / 1000; //30
                            category_sc = category_sc / 1000; //40
                            category_ct = category_ct / 1000; //50
                            category_ya = category_ya / 1000; //70
                            category_tf = category_tf / 1000; //80
                            category_cp = category_cp / 1000; //90

                            object total            = double.Parse(category_total.ToString("0")); //Total
                            object running          = double.Parse(category_rn.ToString("0")); //10
                            object ws_traning       = double.Parse(category_ws.ToString("0")); //30
                            object sport_culture    = double.Parse(category_sc.ToString("0")); //40
                            object court            = double.Parse(category_ct.ToString("0")); //50
                            object young_athletes   = double.Parse(category_ya.ToString("0")); //70
                            object track_field      = double.Parse(category_tf.ToString("0")); //80
                            object core_performance = double.Parse(category_cp.ToString("0")); //90

                            dr_CATEGORY["X_LABLE"]          = x_label;
                            dr_CATEGORY["Total"]            = total;
                            dr_CATEGORY["Ruuning"]          = running;
                            dr_CATEGORY["WS Training"]      = ws_traning;
                            dr_CATEGORY["Sports Culture"]   = sport_culture;
                            dr_CATEGORY["Court"]            = court;
                            dr_CATEGORY["Young athletes"]   = young_athletes;
                            dr_CATEGORY["Track & Field"]    = track_field;
                            dr_CATEGORY["Core Performance"] = core_performance;
                            
                            vDT_CATEGORY.Rows.Add(dr_CATEGORY);
                        }                        
                    }

                    
                }

                vDSChartData.Tables.AddRange(new DataTable[] { vDT_CATEGORY });
                return vDSChartData;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Chart Data Creation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        private DataTable SELECT_NEW_MODEL_TRACKING(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(7);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_NEW_MODEL_TRACKING";

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";                
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[4] = "ARG_USER";
                MyOraDB.Parameter_Name[5] = "ARG_MODEL";
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
        private DataTable SELECT_SCH_SEASON_CHART()
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = "PKG_SXC_SCH_03_SELECT.SELECT_SCH_SEASON_CHART";

                MyOraDB.Parameter_Name[0] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_TO";                
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = cmb_season_from.SelectedValue.ToString();
                MyOraDB.Parameter_Values[1] = cmb_season_to.SelectedValue.ToString();
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

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                string mrd_Filename = Application.StartupPath + @"\Plan_new_model_tracking" + ".mrd";

                
                string[] arg_value = new string[6];
                                 
                arg_value[0] = cmb_factory.SelectedValue.ToString();
                arg_value[1] = cmb_season_from.SelectedValue.ToString();
                arg_value[2] = cmb_season_to.SelectedValue.ToString();
                arg_value[3] = cmb_category.SelectedValue.ToString();
                arg_value[4] = cmb_user.SelectedValue.ToString();
                arg_value[5] = txt_model.Text.Trim();


                string sPara = " /rp " + "[" + arg_value[0] + "]" + " [" + arg_value[1] + "]" + " [" + arg_value[2] + "]" + " [" + arg_value[3] + "]" + " [" + arg_value[4] + "]" + " [" + arg_value[5] + "]";
                
                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
            }
            catch
            {
 
            }
        }
        #endregion

        #region Grid Event
        private void fgrid_main_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Middle)
                {
                    if (grid_flg)
                    {
                        pnl_chart.Height = 250;
                        grid_flg = false;
                    }
                    else
                    {
                        pnl_chart.Height = 0;
                        grid_flg = true; 
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }
        #endregion

        #region Control Event
        private void cmb_chart_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (first_flg)
                    return;

                Set_Chart_Before();
                Display_Chart();
            }
            catch
            {
 
            }
        }
        #endregion

        #region ContextMenu Event
        private void mnu_open_subfile_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arg_value = new string[3];

                arg_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFACTORY].ToString().Trim();
                arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL_ID].ToString().Trim();
                arg_value[2] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxSRF_NO].ToString().Trim();
                                
                Pop_Sch_Devcheck_File pop = new Pop_Sch_Devcheck_File("MNG", arg_value);
                pop.ShowDialog();
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void mnu_print_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arg_value = new string[3];

                arg_value[0] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxFACTORY].ToString().Trim();
                arg_value[1] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxMODEL_ID].ToString().Trim();
                arg_value[2] = fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSXC_SCH_NEW_MODEL.IxSRF_NO].ToString().Trim();
                
                string mrd_Filename = Application.StartupPath + @"\Development_Meeting_03.mrd";
                string sPara = " /rp" + " [" + arg_value[0] + "]" + " [" + arg_value[1] + "]" + " [" + arg_value[2] + "]";

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
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

