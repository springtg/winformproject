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
using System.Diagnostics;
using System.Xml;
using System.IO;
using ChartFX.WinForms.DataProviders;

namespace FlexCDC.Analisys
{
    public partial class Form_EIS_PCC_Prod_Status : COM.APSWinForm.Form_Top
    {
        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private Color[] _rowColors = new Color[] { ClassLib.ComVar.ClrLevel_1st, ClassLib.ComVar.ClrLevel_2nd, ClassLib.ComVar.ClrLevel_3rd };
        private System.IO.MemoryStream _memoryStream;
        #endregion

        #region 생성자
        public Form_EIS_PCC_Prod_Status()
        {
            InitializeComponent();

            _memoryStream = new System.IO.MemoryStream();
            chart_month.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);            
        }        
        #endregion

        #region Form Loading
        private void Form_EIS_PCC_Prod_Status_Load(object sender, EventArgs e)
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
            this.Text = "PCC Production Analysis";
            lbl_MainTitle.Text = "PCC Production Analysis";

            //월별 생산 계획
            fgrid_year.Set_Grid("EDM_PCC_PROD", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_year.Set_Action_Image(img_Action);
            fgrid_year.ExtendLastCol = false;
            fgrid_year.AllowSorting = AllowSortingEnum.None;
            fgrid_year.AllowDragging = AllowDraggingEnum.None;
            fgrid_year.Tree.Column = (int)ClassLib.TBEDM_PCC_PROD_MONTH.IxITEM;

            //일별 생산 계획
            fgrid_month.Set_Grid("EDM_PCC_PROD", "2", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_month.Set_Action_Image(img_Action);
            fgrid_month.ExtendLastCol = false;
            fgrid_month.AllowSorting = AllowSortingEnum.None;
            fgrid_month.AllowDragging = AllowDraggingEnum.None;
            fgrid_month.Tree.Column = (int)ClassLib.TBEDM_PCC_PROD_DAY.IxTITLE;

            tbtn_New.Enabled = false;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Save.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Search.Enabled = true;            

            dtp_date_to.Value = DateTime.Now;
            dtp_date_from.Value = DateTime.Now.AddMonths(-6);

            string arg_from = dtp_date_from.Value.ToString("yyyyMM") + "01";
            string arg_to   = dtp_date_to.Value.ToString("yyyyMM") + "31";

            DataTable dt_ret = SET_MONTH_COMBO(arg_from, arg_to);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_month, 2, 3, false, COM.ComVar.ComboList_Visible.Name);
           // cmb_month.SelectedIndex = 0;
            
            Display_Grid_Month();            
        }       
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string arg_from = dtp_date_from.Value.ToString("yyyyMM") + "01";
                string arg_to = dtp_date_to.Value.ToString("yyyyMM") + "31";

                DataTable dt_ret = SET_MONTH_COMBO(arg_from, arg_to);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_month, 2, 3, false, COM.ComVar.ComboList_Visible.Name);
                cmb_month.SelectedIndex = dt_ret.Rows.Count - 1;

                Display_Grid_Month();
                Display_Grid_Day();
                                
                Radio_Button_Check(null, null);
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #region Grid Data Search
        private void Display_Grid_Month()
        {
            fgrid_year.Rows.Count = fgrid_year.Rows.Fixed;
            fgrid_year.Cols.Count = (int)ClassLib.TBEDM_PCC_PROD_MONTH.IxMAX_CNT;

            string arg_year_date_from = dtp_date_from.Value.ToString("yyyyMM") + "01";
            string arg_year_date_to = dtp_date_to.Value.ToString("yyyyMM") + "31";

            DataSet ds_ret = SELECT_GRID_MONTH(arg_year_date_from, arg_year_date_to);

            DataTable dt_month_grid = ds_ret.Tables[0];
            DataTable dt_month = ds_ret.Tables[1];

            #region Year Grid Setting
            for (int col_cnt = 0; col_cnt < dt_month_grid.Rows.Count; col_cnt++)
            {
                fgrid_year.Cols.Add();

                fgrid_year[fgrid_year.Rows.Fixed - 2, (int)ClassLib.TBEDM_PCC_PROD_MONTH.IxMAX_CNT + col_cnt] = dt_month_grid.Rows[col_cnt].ItemArray[0].ToString();
                fgrid_year[fgrid_year.Rows.Fixed - 1, (int)ClassLib.TBEDM_PCC_PROD_MONTH.IxMAX_CNT + col_cnt] = dt_month_grid.Rows[col_cnt].ItemArray[1].ToString();
            }

            string check_point = "";

            for (int i = 0; i < dt_month.Rows.Count; i++)
            {
                int lev = int.Parse(dt_month.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_MONTH.IxT_LEV].ToString());

                string op_cd    = dt_month.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_MONTH.IxOP_CD].ToString().Trim();
                string category = dt_month.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_MONTH.IxCATEGORY].ToString().Trim();
                string round    = dt_month.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_MONTH.IxNF_CD].ToString().Trim();
                string date     = dt_month.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_MONTH.IxDATE].ToString().Trim();
                string qty      = dt_month.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_MONTH.IxQTY].ToString().Trim();

                string check_key = op_cd + category + round;

                if (!check_key.Equals(check_point))
                {
                    fgrid_year.Rows.InsertNode(fgrid_year.Rows.Count, lev);

                    for (int j = fgrid_year.Cols.Fixed; j < fgrid_year.Cols.Count; j++)
                    {
                        if (j <= (int)ClassLib.TBEDM_PCC_PROD_MONTH.IxQTY)
                            fgrid_year[fgrid_year.Rows.Count - 1, j] = dt_month.Rows[i].ItemArray[j].ToString().Trim();
                        else
                            fgrid_year[fgrid_year.Rows.Count - 1, j] = " ";

                        if (lev == 1)
                            fgrid_year.Rows[fgrid_year.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(239, 231, 241);

                        else if (lev == 2)
                            fgrid_year.Rows[fgrid_year.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(255, 242, 238);

                        else
                            fgrid_year.Rows[fgrid_year.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(249, 249, 251);
                    }

                    check_point = op_cd + category + round;
                }

                for (int j = (int)ClassLib.TBEDM_PCC_PROD_MONTH.IxMAX_CNT; j < fgrid_year.Cols.Count; j++)
                {
                    string date_title = fgrid_year[fgrid_year.Rows.Fixed - 2, j].ToString() + fgrid_year[fgrid_year.Rows.Fixed - 1, j].ToString();

                    if (date_title.Equals(date))
                    {                        
                        fgrid_year[fgrid_year.Rows.Count - 1, j] = double.Parse(qty).ToString("###,###,###.##");

                        break;
                    }
                }
            }
            #endregion


            DataTable vDS = MakeChartData_Month();
            Display_Chart_Month(vDS);
        }
        private DataSet SELECT_GRID_MONTH(string arg_year_date_from, string arg_year_date_to)
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_EDM_PCC_02.SELECT_PCC_PROD_MONTH_GRID";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_DATE_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_DATE_TO";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = arg_year_date_from;
            MyOraDB.Parameter_Values[2] = arg_year_date_to;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);



            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_EDM_PCC_02.SELECT_PCC_PROD_MONTH";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_DATE_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_DATE_TO";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = arg_year_date_from;
            MyOraDB.Parameter_Values[2] = arg_year_date_to;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(false);

            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();
            return ds_ret;
        }

        private void Display_Grid_Day()
        {
            string arg_year_month = cmb_month.SelectedValue.ToString();

            DataSet ds_ret = SELECT_GRID_DAY(arg_year_month);

            DataTable dt_day_grid = ds_ret.Tables[0];
            DataTable dt_day = ds_ret.Tables[1];

            fgrid_month.Rows.Count = fgrid_month.Rows.Fixed;

            int max_date = int.Parse(dt_day_grid.Rows[0].ItemArray[0].ToString());

            for (int i = 0; i < dt_day.Rows.Count; i++)
            {
                int lev = int.Parse(dt_day.Rows[i].ItemArray[(int)ClassLib.TBEDM_PCC_PROD_DAY.IxT_LEV].ToString());

                fgrid_month.Rows.InsertNode(fgrid_month.Rows.Count, lev);

                for (int j = fgrid_month.Cols.Fixed; j < fgrid_month.Cols.Count; j++)
                {
                    fgrid_month[fgrid_month.Rows.Count - 1, j] = dt_day.Rows[i].ItemArray[j].ToString();

                    if (j > 6)
                        fgrid_month.Cols[j].Visible = true;                    
                    if (j > max_date + 6)
                        fgrid_month.Cols[j].Visible = false;
                }
                if (lev == 1)
                {
                    fgrid_month.Rows[fgrid_month.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(239, 231, 241);
                }
                else if (lev == 2)
                {
                    fgrid_month.Rows[fgrid_month.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(255, 242, 238);
                }
                else
                    fgrid_month.Rows[fgrid_month.Rows.Count - 1].StyleNew.BackColor = Color.FromArgb(249, 249, 251);
            }


            DataTable vDS = MakeChartData_Daily();
            Display_Chart_Daily(vDS);
        }
        private DataSet SELECT_GRID_DAY(string arg_year_month)
        {
            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_EDM_PCC_02.SELECT_PCC_PROD_DAY_GRID";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_YEAR_MONTH";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = arg_year_month;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);


            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_EDM_PCC_02.SELECT_PCC_PROD_DAY";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_YEAR_MONTH";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = arg_year_month;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(false);


            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();
            return ds_ret;
        }
        #endregion

        #region Chart Data Search
        private DataTable MakeChartData_Month()
        {
            try
            {
                DataTable vDTmonth = new DataTable("Month DataTable"); //월별생산추이                

                if (fgrid_year.Rows.Count > fgrid_year.Rows.Fixed)
                {
                    int viStartCol = (int)ClassLib.TBEDM_PCC_PROD_MONTH.IxMAX_CNT;
                    int viEndCol = fgrid_year.Cols.Count;
                    int viTitle1Row = fgrid_year.Rows.Fixed - 2;
                    int viTitle2Row = fgrid_year.Rows.Fixed - 1;
                    System.Collections.ArrayList vaTotRow = new System.Collections.ArrayList();


                    // title set
                    vDTmonth.Columns.Add(new DataColumn("X_LABLE"));

                    for (int row = fgrid_year.Rows.Fixed; row < fgrid_year.Rows.Count; row++)
                    {
                        if (fgrid_year[row, (int)ClassLib.TBEDM_PCC_PROD_MONTH.IxOP_CD].ToString().Equals("FGA") &&
                            fgrid_year[row, (int)ClassLib.TBEDM_PCC_PROD_MONTH.IxNF_CD].ToString().Equals(""))
                        {
                            vaTotRow.Add(row);
                            vDTmonth.Columns.Add(fgrid_year[row, (int)ClassLib.TBEDM_PCC_PROD_MONTH.IxITEM].ToString());
                        }
                    }

                    // data set
                    for (int col = viStartCol; col < viEndCol; col++)
                    {
                        DataRow drMonth = vDTmonth.NewRow();

                        foreach (int row in vaTotRow)
                        {
                            object x_label = fgrid_year[viTitle1Row, col].ToString() + "년 " + int.Parse(fgrid_year[viTitle2Row, col].ToString()).ToString() + "월";
                            drMonth["X_LABLE"] = x_label;

                            object item = fgrid_year[row, col];
                            if (fgrid_year[row, col].ToString().Equals(" "))
                                item = "0";

                            drMonth[fgrid_year[row, (int)ClassLib.TBEDM_PCC_PROD_MONTH.IxITEM].ToString()] = item;
                        }

                        vDTmonth.Rows.Add(drMonth);
                    }
                }
                return vDTmonth;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Chart Data Creation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void Display_Chart_Month(DataTable arg_dt)
        {
            _memoryStream.Position = 0;
            chart_month.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_month.Data.Clear();

            // Rate Chart
            DataTable vDTmonth = arg_dt;

            chart_month.Data.Series = 3;
            chart_month.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("X_LABLE", ChartFX.WinForms.FieldUsage.Label));
            for (int i = 1; i < vDTmonth.Columns.Count; i++)
            {
                chart_month.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap(vDTmonth.Columns[i].ColumnName.ToString(), ChartFX.WinForms.FieldUsage.Value));
            }

            chart_month.DataSource = vDTmonth;

            chart_month.View3D.Enabled = false;
            chart_month.ToolTipFormat = "%v";
            chart_month.LegendBox.Visible = true;
            chart_month.AllSeries.PointLabels.Visible = true;
            
            chart_month.Series[0].Gallery = Gallery.Lines;
            chart_month.Series[1].Gallery = Gallery.Bar;
            chart_month.Series[2].Gallery = Gallery.Bar;
            chart_month.Series[3].Gallery = Gallery.Bar;
            chart_month.Series[4].Gallery = Gallery.Bar;
            chart_month.Series[5].Gallery = Gallery.Bar;
            chart_month.Series[6].Gallery = Gallery.Bar;
            chart_month.Series[7].Gallery = Gallery.Bar;
            chart_month.Series[8].Gallery = Gallery.Bar;

            chart_month.LegendBox.Dock = ChartFX.WinForms.DockArea.Bottom;
            chart_month.Font = new System.Drawing.Font("Verdana", 6F);
            chart_month.Cursor = Cursors.Arrow;
        }

        private DataTable MakeChartData_Daily()
        {
            try
            {                
                DataTable vDTday = new DataTable("Day DataTable");   //일별생산추이
                
                if (fgrid_month.Rows.Count > fgrid_month.Rows.Fixed)
                {
                    int viStartCol = (int)ClassLib.TBEDM_PCC_PROD_DAY.IxDAY_01;
                    int viEndCol = fgrid_month.Cols.Count;                    
                    int viTitle2Row = fgrid_month.Rows.Fixed - 1;
                    System.Collections.ArrayList vaTotRow = new System.Collections.ArrayList();


                    // title set
                    vDTday.Columns.Add(new DataColumn("X_LABLE"));

                    vaTotRow.Add(0);
                    vDTday.Columns.Add("Daily Total");
                   
                    // data set
                    for (int col = viStartCol; col < viEndCol; col++)
                    {
                        if (fgrid_month.Cols[col].Visible)
                        {
                            DataRow drDay = vDTday.NewRow();

                            double item_tot = 0;

                            object x_label = fgrid_month[viTitle2Row, col].ToString() + "일";
                            drDay["X_LABLE"] = x_label;

                            for (int row = fgrid_month.Rows.Fixed; row < fgrid_month.Rows.Count; row++)
                            {
                                double item = 0;

                                if (fgrid_month[row, (int)ClassLib.TBEDM_PCC_PROD_DAY.IxT_LEV].ToString().Equals("1"))
                                {
                                    if (fgrid_month[row, col].ToString().Equals(" "))
                                        item = 0;
                                    else
                                        item = double.Parse(fgrid_month[row, col].ToString());

                                    item_tot = item_tot + item;
                                }
                            }

                            object value = item_tot.ToString();
                            drDay["Daily Total"] = value;
                            vDTday.Rows.Add(drDay);
                        }
                    }                
                }

                return vDTday;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Chart Data Creation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void Display_Chart_Daily(DataTable arg_dt)
        {
            _memoryStream.Position = 0;
            chart_day.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_day.Data.Clear();

            // Rate Chart
            DataTable vDTday = arg_dt;

            chart_day.Data.Series = vDTday.Columns.Count;
            chart_day.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("X_LABLE", ChartFX.WinForms.FieldUsage.Label));

            for (int i = 1; i < vDTday.Columns.Count; i++)
            {
                chart_day.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap(vDTday.Columns[i].ColumnName.ToString(), ChartFX.WinForms.FieldUsage.Value));
            }

            chart_day.DataSource = vDTday;

            chart_day.View3D.Enabled = false;
            chart_day.ToolTipFormat = "%v";
            chart_day.LegendBox.Visible = true;
            chart_day.AllSeries.PointLabels.Visible = true;
            chart_day.AllSeries.Gallery = Gallery.Lines;

            chart_day.LegendBox.Dock = ChartFX.WinForms.DockArea.Bottom;
            chart_day.Font = new System.Drawing.Font("Verdana", 6F);
            chart_day.Cursor = Cursors.Arrow;
        }

        #endregion

        #endregion

        #region Control Event
        private void dtp_date_from_CloseUp(object sender, EventArgs e)
        {
            try
            {
                string arg_from = dtp_date_from.Value.ToString("yyyyMM") + "01";
                string arg_to = dtp_date_to.Value.ToString("yyyyMM") + "31";

                DataTable dt_ret = SET_MONTH_COMBO(arg_from, arg_to);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_month, 2, 3, false, COM.ComVar.ComboList_Visible.Name);
                cmb_month.SelectedIndex = 0;
                
            }
            catch
            {
 
            }
        }
        private void dtp_date_to_CloseUp(object sender, EventArgs e)
        {
            try
            {
                string arg_from = dtp_date_from.Value.ToString("yyyyMM") + "01";
                string arg_to = dtp_date_to.Value.ToString("yyyyMM") + "31";

                DataTable dt_ret = SET_MONTH_COMBO(arg_from, arg_to);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_month, 2, 3, false, COM.ComVar.ComboList_Visible.Name);
                cmb_month.SelectedIndex = 0;

                
            }
            catch
            {
 
            }
        }
        private DataTable SET_MONTH_COMBO(string arg_date_from, string arg_date_to)
        {            
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_EDM_PCC_02.SELECT_PCC_PROD_MONTH_GRID";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_DATE_FROM";
            MyOraDB.Parameter_Name[2] = "ARG_DATE_TO";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
            MyOraDB.Parameter_Values[1] = arg_date_from;
            MyOraDB.Parameter_Values[2] = arg_date_to;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);

            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        private void Radio_Button_Check(object sender, EventArgs e)
        {
            //------------------------------------------------------------------------------------
            //Radio Button 검색 조건
            //------------------------------------------------------------------------------------
            if (rad_Op.Checked)
            {
                fgrid_year.Tree.Show(1);
                fgrid_month.Tree.Show(1);
            }
            else if (rad_Category.Checked)
            {
                fgrid_year.Tree.Show(2);
                fgrid_month.Tree.Show(1);
            }
            else if (rad_Round.Checked)
            {
                fgrid_year.Tree.Show(3);
                fgrid_month.Tree.Show(2);
            }
            

        }
        private void cmb_month_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_month.SelectedIndex == -1)
                    return;

                for (int j = (int)ClassLib.TBEDM_PCC_PROD_DAY.IxDAY_01; j < fgrid_month.Cols.Count; j++)
                    fgrid_month[fgrid_month.Rows.Fixed - 2, j] = cmb_month.SelectedValue.ToString();

                Display_Grid_Day();
                Radio_Button_Check(null, null);
            }
            catch
            {
 
            }
        }        
        #endregion

    }
}

