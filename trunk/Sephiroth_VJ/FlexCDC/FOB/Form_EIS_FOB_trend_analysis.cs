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

namespace FlexCDC.FOB
{
    public partial class Form_EIS_FOB_trend_analysis : COM.APSWinForm.Form_Top
    {

        #region 생성자

        public Form_EIS_FOB_trend_analysis()
        {
            InitializeComponent();

            _memoryStream = new System.IO.MemoryStream();

            chart_Fob.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);

            Init_Form();
        }
        #endregion

        #region 변수 정의

        private COM.OraDB MyOraDB = new COM.OraDB();
        private COM.ComFunction MyComFunction = new COM.ComFunction();
        private System.IO.MemoryStream _memoryStream;

        #endregion

        #region  멤버메쏘드

        private void Init_Form()
        {
            try
            {
                this.Text = "FOB Trend Analysis";
                lbl_MainTitle.Text = "FOB Trend Analysis";
                lbl_title.Text = "         Search Condition";

                Init_Grid();
                Init_Control();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void Init_Control()
        {
            // Disabled tbutton            
            tbtn_New.Enabled = false;
            tbtn_Save.Enabled = false;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Print.Enabled = false;

            // Factory Combobox Setting
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_Factory.SelectedIndex = 1;
            dt_ret.Dispose();

        }
        private void Init_Grid()
        {
            fgrid_Main.Set_Grid("EIS_FOB_TREND_ANALYSIS", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Font = new Font("Verdana", 8);
        }
        private void Display_Grid(DataTable arg_dt)
        {

            fgrid_Main.Display_Grid(arg_dt, false);


            if (fgrid_Main.Rows.Count != 1)
            {


                fgrid_Main.AllowMerging = AllowMergingEnum.Free;
                fgrid_Main.Rows[1].AllowMerging = true;


                //Row vrAvgRow = fgrid_Main.Rows.Add();
                Row vrTotRow = fgrid_Main.Rows.Add();

                //double vdAvg = 0;
                double  vdTot = 0;
                

                for (int col = fgrid_Main.Cols.Frozen; col < fgrid_Main.Cols.Count; col++)
                {

                    //vdAvg = fgrid_Main.Aggregate(AggregateEnum.Average, fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed, col, fgrid_Main.Rows.Count - 1, col));
                    vdTot = fgrid_Main.Aggregate(AggregateEnum.Sum, fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed, col, fgrid_Main.Rows.Count - 1, col));

                    if ((col % 2) == 0)
                    {
                        vrTotRow[col] = string.Format("{0:#,###.##}", Math.Round(vdTot, 2));
                    }
                    else
                    {


                        //vrAvgRow[col] = Math.Round(vdAvg, 2);
                    }





                    fgrid_Main[fgrid_Main.Rows.Count - 2, (int)ClassLib.TBEIS_FOB_TREND_ANALYSIS.IxEIS_MONTH] = "Average($)";
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 2].StyleNew.BackColor = Color.Beige;
                    fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBEIS_FOB_TREND_ANALYSIS.IxEIS_MONTH] = "   Total($)";
                    fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = Color.LightPink;

                }
            }
            else
            {
                return;
            }


        }
        private void Display_Chart()
        {
            Set_Chart_Before();

            DataTable dt_ret = SELECT_EBM_FOB_TREND_CHART(ClassLib.ComFunction.Empty_Combo(cmb_Factory, " "),
                                 cmb_Month_From.SelectedValue.ToString().Replace("-", ""),
                                 cmb_Month_To.SelectedValue.ToString().Replace("-", ""));
            dt_ret.Dispose();

            #region Fob

            if (dt_ret == null || dt_ret.Rows.Count == 0) return;

            chart_Fob.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("EIS_MONTH", ChartFX.WinForms.FieldUsage.Label));
            chart_Fob.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("FOB_AVG", ChartFX.WinForms.FieldUsage.Value));
            chart_Fob.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("MAT_AVG", ChartFX.WinForms.FieldUsage.Value));
            chart_Fob.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("FOB_AMT", ChartFX.WinForms.FieldUsage.Value));

            chart_Fob.DataSourceSettings.Fields[1].DisplayName = "FOB Price";
            chart_Fob.DataSourceSettings.Fields[2].DisplayName = "Mat Price";
            chart_Fob.DataSourceSettings.Fields[3].DisplayName = "FOB Amount";

            chart_Fob.Series[0].AxisY.Font = new Font("Verdana", 8);
            chart_Fob.Series[1].AxisY.Font = new Font("Verdana", 8);
            chart_Fob.Series[2].AxisY.Font = new Font("Verdana", 8);
            chart_Fob.Series[2].Color = Color.LightGray;
            chart_Fob.AxisY.Title.Text = "($)";
            chart_Fob.Series[2].Volume = 45;

            chart_Fob.AxisY2.Visible = true;
            chart_Fob.Series[0].AxisY = chart_Fob.AxisY;
            chart_Fob.Series[1].AxisY = chart_Fob.AxisY;
            chart_Fob.Series[2].AxisY = chart_Fob.AxisY2;
            chart_Fob.AxisX.Visible = true;
            

            chart_Fob.AxisY2.ScaleUnit = 1000000;
            chart_Fob.AxisY2.Title.Text = "In million($)"; //100만 달러
            chart_Fob.AxisY2.LabelsFormat.Decimals = 0;

            chart_Fob.Series[0].Gallery = ChartFX.WinForms.Gallery.Lines;
            chart_Fob.Series[1].Gallery = ChartFX.WinForms.Gallery.Lines;
            chart_Fob.Series[2].Gallery = ChartFX.WinForms.Gallery.Bar;

            chart_Fob.AxisY.LabelsFormat.Format = AxisFormat.Number;
            chart_Fob.AxisY2.LabelsFormat.Format = AxisFormat.Number;
            chart_Fob.AllSeries.AxisY.DataFormat.CustomFormat = "#,##0";


            chart_Fob.DataSource = dt_ret;


            #endregion


            Set_Chart_After();


        }
        private void Set_Chart_Before()
        {
            #region chart_Fob
            _memoryStream.Position = 0;
            chart_Fob.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_Fob.Data.Clear();

            chart_Fob.Data.Series = 3;

            #endregion



        }
        private void Set_Chart_After()
        {
            #region chart_Fob

            chart_Fob.LegendBox.Visible = true;
            chart_Fob.LegendBox.Dock = ChartFX.WinForms.DockArea.Bottom;
            chart_Fob.LegendBox.Font = new Font("Verdana", 8);


            if (cmb_Factory.SelectedIndex == 2)
            {
                chart_Fob.LegendBox.Titles.Clear();
                chart_Fob.LegendBox.Titles.Add(new TitleDockable("QD"));
            }
            else if (cmb_Factory.SelectedIndex == 4)
            {
                chart_Fob.LegendBox.Titles.Clear();
                chart_Fob.LegendBox.Titles.Add(new TitleDockable("VJ"));
            }

            chart_Fob.ToolTipFormat = "%v";

            #endregion


        }
        private void Event_cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                Set_Chart_Before();
                if (cmb_Factory.SelectedIndex == -1) return;

                string factory = cmb_Factory.SelectedValue.ToString();
                DataTable dt_ret = SELECT_EBM_FOB_MONTH(factory);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Month_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Month_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name);
                cmb_Month_To.SelectedValue = System.DateTime.Now.AddMonths(-1).ToString("yyyyMM");
                cmb_Month_From.SelectedValue = System.DateTime.Now.AddMonths(-13).ToString("yyyyMM");

               

                dt_ret.Dispose();
            }
            catch
            {
            }
        }
        private void Event_cmb_Month_From_SelectedValueChanged(object sender, EventArgs e)
        {
            fgrid_Main.ClearAll();
            Set_Chart_Before();
        }
        private void Event_cmb_Month_To_SelectedValueChanged(object sender, EventArgs e)
        {
            fgrid_Main.ClearAll();
            Set_Chart_Before();


        }


        #endregion

        #region  이벤트처리
        
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {



                //그리드와 차트 검색 시 마다 초기값으로 재 설정
                fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

                this.Cursor = Cursors.WaitCursor;
                string factory = cmb_Factory.SelectedValue.ToString();
                string month_from = cmb_Month_From.SelectedValue.ToString();
                string month_to = cmb_Month_To.SelectedValue.ToString();

                DataTable dt_ret = SELECT_EBM_FOB_TREND(factory, month_from, month_to);

                dt_ret.Dispose();

                Display_Grid(dt_ret);
                Display_Chart();

            }
            catch
            {
                //this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }


        #endregion

        #region  DB컨넥트

        private DataTable SELECT_EBM_FOB_MONTH(string arg_factory)
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_TREND.SELECT_EBM_FOB_MONTH";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch
            {
                return null;
            }

        }
        private DataTable SELECT_EBM_FOB_TREND(string arg_factory, string arg_month_from, string arg_month_to)
        {
            try
            {
                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_TREND.SELECT_EBM_FOB_TREND";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MONTH_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_MONTH_TO";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_month_from;
                MyOraDB.Parameter_Values[2] = arg_month_to;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);

                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch
            {
                return null;
            }

        }
        private DataTable SELECT_EBM_FOB_TREND_CHART(string arg_factory, string arg_month_from, string arg_month_to)
        {
            try
            {


                MyOraDB.ReDim_Parameter(4);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_TREND.SELECT_EBM_FOB_TREND_CHART";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MONTH_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_MONTH_TO";
                MyOraDB.Parameter_Name[3] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_month_from;
                MyOraDB.Parameter_Values[2] = arg_month_to;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(false);



                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch
            {
                return null;
            }

        }


        #endregion




    }
}

