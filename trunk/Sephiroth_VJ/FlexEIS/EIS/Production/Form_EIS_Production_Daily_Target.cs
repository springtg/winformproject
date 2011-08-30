using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexEIS.EIS.Production
{
    public partial class Form_EIS_Production_Daily_Target : COM.APSWinForm.Form_Top
    {

         #region 생성자

        public Form_EIS_Production_Daily_Target()
        {
            InitializeComponent();

            _ms_main = new MemoryStream();
            chart_Main.Export(ChartFX.WinForms.FileFormat.Binary, _ms_main);

            Init_Form();
        }

        #endregion

        #region 변수 정의


        private COM.OraDB MyOraDB = new COM.OraDB();
        private Hashtable _columns = null;
        private Color[] _colors = null;

        private MemoryStream _ms_main;


        #endregion

        #region 멤버 메서드


        #region 초기화
               
        /// <summary>
        /// Inti_Form : Form Load 시 초기화 작업
        /// </summary>
        private void Init_Form()
        {

            try
            {
                //Title
                this.Text = "Target by contrast with actually";
                lbl_MainTitle.Text = "Target by contrast with actually";

                Init_Grid();
                Init_Control();
                Init_Toolbar();
                resetChart(chart_Main, _ms_main);

                if (COM.ComVar.Parameter_PopUp != null)
                {
                    if (COM.ComVar.Parameter_PopUp[0].Equals("Form_EIS_Production_Daily_Target"))
                    {
                        cmb_Factory.SelectedValue = COM.ComVar.Parameter_PopUp[1];
                        cmb_Month.SelectedValue = COM.ComVar.Parameter_PopUp[2];
                        Search();
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init_Grid()
        {
            fgrid_Main.Set_Grid("EPM_PROD_DAILY_TARGET", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Sub.Set_Grid("EPM_PROD_DAILY_TARGET", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            _columns = new Hashtable(31);
        }

        private void Init_Control()
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Factory.SelectedValue = "VJ";
            dt_ret.Dispose();

            _colors = new Color[] { ClassLib.ComVar.ClrLevel_1st, ClassLib.ComVar.ClrLevel_2nd, ClassLib.ComVar.ClrLevel_3rd, Color.White };
        }

        private void Init_Toolbar()
        {
            tbtn_Save.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Append.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Print.Enabled = false;
        }

        #endregion

        #region 툴바 이벤트 메서드

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                ClearAll();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Search();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region 그리드 이벤트 메서드

        private void fgrid_Main_AfterScroll(object sender, RangeEventArgs e)
        {
            if (ExistData)
                ScrollChanged(fgrid_Main, fgrid_Sub);
        }

        private void fgrid_Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (ExistData)
                SelectRow(fgrid_Main, fgrid_Sub);
        }

        private void fgrid_Sub_AfterScroll(object sender, RangeEventArgs e)
        {
            if (ExistData)
                ScrollChanged(fgrid_Sub, fgrid_Main);
        }

        private void fgrid_Sub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ExistData)
                SelectRow(fgrid_Sub, fgrid_Main);
        }

        private void ScrollChanged(COM.FSP arg_act, COM.FSP arg_Tar)
        {
            arg_Tar.ScrollPosition = arg_act.ScrollPosition;
        }

        private void SelectRow(COM.FSP arg_act, COM.FSP arg_tar)
        {
            RowSearch(arg_act, arg_tar);            
        }

        private void RowSearch(COM.FSP arg_act, COM.FSP arg_tar)
        {
            arg_tar.Select(arg_act.Row, arg_act.Col);
        }

        #endregion

        #region 버튼 및 기타 이벤트 메서드

        private void cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                ClearAll();
                SearchLine();
                SearchMonths();
                SearchModel();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Factory Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void cmb_Month_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                ClearAll();
                SearchDays();
                SearchModel();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Month Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void cmb_line_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
                SearchModel();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Line Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_viewGroup_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(1);
            fgrid_Sub.Tree.Show(1);
        }

        private void lbl_viewLine_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(2);
            fgrid_Sub.Tree.Show(2);
        }

        private void lbl_viewModel_CheckedChanged(object sender, EventArgs e)
        {
            fgrid_Main.Tree.Show(3);
            fgrid_Sub.Tree.Show(3);
        }

        #endregion

        #endregion

        #region 이벤트 처리

        #region 툴바 이벤트

        private void ClearAll()
        {
            fgrid_Main.ClearAll();
            fgrid_Sub.ClearAll();
            resetChart(chart_Main, _ms_main);
        }

        private void Search()
        {
            ClearAll();

            DataSet vDS = null;

            if (SELECT_PROD_DAILY_ACTUALLY() && SELECT_PROD_DAILY_TARGET())
            {
                vDS = SELECT_PROD_DAILY_CHART();
            }

            DataTable vDT_T = vDS.Tables["PKG_EPM_PROD_DAILY_TARGET.SELECT_PROD_DAILY_TARGET"];
            DataTable vDT_A = vDS.Tables["PKG_EPM_PROD_DAILY_ACTUALLY.SELECT_PROD_DAILY_ACTUALLY"];
            DataTable vDT_Chart = vDS.Tables["PKG_EPM_PROD_DAILY_ACTUALLY.SELECT_PROD_DAILY_CHART"];

            DisplayGrid(fgrid_Main, vDT_T, "PLAN_QTY");
            DisplayGrid(fgrid_Sub, vDT_A, "FGA_QTY");
            DisplayChart(vDT_Chart);

            vDS.Dispose();
        }

        private void DisplayGrid(COM.FSP arg_grid, DataTable vDT, string arg_QtyCol)
        {
            int vCol = -1, vRow = arg_grid.Rows.Count, vGroupIdx = 1;
            string vPlanYMD = "", vStyle = "NONE", vStyleTemp = "";

            if (vDT.Rows.Count > 0)
            {
                vRow = arg_grid.Rows.Add().Index;
                arg_grid.Rows[vRow].IsNode = true;
                arg_grid.Rows[vRow].Node.Level = 0;
                arg_grid.Rows[vRow].StyleNew.BackColor = _colors[arg_grid.Rows[vRow].Node.Level];
                arg_grid[vRow, (int)ClassLib.TBEPM_PROD_DAILY_TARGET.IxLINE] = cmb_Factory.SelectedText;

                vStyleTemp = vDT.Rows[0]["LINE_CD"].ToString();

                for (int i = 0; i < vDT.Rows.Count; i++)
                {
                    vPlanYMD = vDT.Rows[i]["PLAN_YMD"].ToString();
                    vStyleTemp = vDT.Rows[i]["LINE_CD"].ToString();
                    if (!vStyle.Equals(vStyleTemp))
                    {
                        vRow = arg_grid.Rows.Add().Index;
                        arg_grid.Rows[vRow].IsNode = true;
                        arg_grid.Rows[vRow].Node.Level = Convert.ToInt32(vDT.Rows[i]["LEV"].ToString());
                        arg_grid.Rows[vRow].StyleNew.BackColor = _colors[arg_grid.Rows[vRow].Node.Level];

                        arg_grid[vRow, (int)ClassLib.TBEPM_PROD_DAILY_TARGET.IxLINE] = vDT.Rows[i]["LINE_CD"].ToString();
                        arg_grid[vRow, (int)ClassLib.TBEPM_PROD_DAILY_TARGET.IxSTYLE_CD] = vDT.Rows[i]["STYLE_CD"].ToString();
                        vStyle = vStyleTemp;

                        if (vDT.Rows[i]["LINE_CD"].ToString().Equals("Group"))
                        {
                            arg_grid[vRow, (int)ClassLib.TBEPM_PROD_DAILY_TARGET.IxLINE] = vDT.Rows[i]["LINE_CD"].ToString() + vGroupIdx++;
                        }
                    }

                    if (_columns.ContainsKey(vPlanYMD))
                    {
                        vCol = (int)_columns[vPlanYMD];
                        arg_grid[vRow, vCol] = vDT.Rows[i][arg_QtyCol].ToString();
                    }
                }

                arg_grid.Tree.Column = (int)ClassLib.TBEPM_PROD_DAILY_TARGET.IxLINE;

                if (lbl_viewGroup.Checked)
                    arg_grid.Tree.Show(1);
                else if (lbl_viewLine.Checked)
                    arg_grid.Tree.Show(2);
                else
                    arg_grid.Tree.Show(3);

                RowTotal(arg_grid);
                vDT.Dispose();
            }
        }

        private void RowTotal(COM.FSP arg_grid)
        {
            int vTotalCol = (int)ClassLib.TBEPM_PROD_DAILY_TARGET.IxTOTAL_QTY;

            double[] vColTotal = new double[arg_grid.Cols.Count];

            for (int row = arg_grid.Rows.Fixed + 1; row < arg_grid.Rows.Count; row++)
            {
                arg_grid[row, vTotalCol] = arg_grid.Aggregate(AggregateEnum.Sum, row, arg_grid.Cols.Frozen, row, arg_grid.Cols.Count - 1);

                if (arg_grid.Rows[row].Node.Level == 3)
                {
                    for (int col = arg_grid.Cols.Frozen; col < arg_grid.Cols.Count; col++)
                    {
                        vColTotal[col] = vColTotal[col] + arg_grid.Aggregate(AggregateEnum.Sum, row, col, row, col);
                    }
                }
            }

            for (int cIdx = arg_grid.Cols.Frozen; cIdx < arg_grid.Cols.Count; cIdx++)
            {
                arg_grid[arg_grid.Rows.Fixed, cIdx] = vColTotal[cIdx];
            }

            arg_grid[arg_grid.Rows.Fixed, vTotalCol] = arg_grid.Aggregate(AggregateEnum.Sum, arg_grid.Rows.Fixed, arg_grid.Cols.Frozen, arg_grid.Rows.Fixed, arg_grid.Cols.Count - 1);
        }

        private void DisplayChart(DataTable arg_dt)
        {
            if (ExistData)
            {
                chart_Main.Font = new Font("Verdana", 8);
                chart_Main.AxisY.LabelsFormat.Format = ChartFX.WinForms.AxisFormat.Number;

                chart_Main.Data.Series = 2;

                chart_Main.Series[0].Color = Color.LightBlue;
                chart_Main.Series[1].Color = Color.LightPink;

                chart_Main.Series[0].AxisY = chart_Main.AxisY;
                chart_Main.Series[1].AxisY = chart_Main.AxisY;

                chart_Main.Series[0].Gallery = ChartFX.WinForms.Gallery.Lines;
                chart_Main.Series[1].Gallery = ChartFX.WinForms.Gallery.Lines;

                chart_Main.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("MONTH", ChartFX.WinForms.FieldUsage.Label));
                chart_Main.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("PLAN_QTY", ChartFX.WinForms.FieldUsage.Value));
                chart_Main.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("FGA_QTY", ChartFX.WinForms.FieldUsage.Value));

                chart_Main.DataSourceSettings.Fields[1].DisplayName = "Plan";
                chart_Main.DataSourceSettings.Fields[2].DisplayName = "Production";

                chart_Main.Series[0].AxisY.DataFormat.CustomFormat = "#,##0";
                chart_Main.Series[1].AxisY.DataFormat.CustomFormat = "#,##0";

                chart_Main.DataSource = arg_dt;

                arg_dt.Dispose();
            }
        }

        #endregion

        #region 그리드 이벤트



        #endregion

        #region 버튼 및 기타 이벤트

        private void SearchLine()
        {
            try
            {
                if (!FactorySelected) return;

                string factory = cmb_Factory.SelectedValue.ToString();

                DataTable dt_ret = SELECT_LINE(factory);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_line, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Name);
                cmb_line.SelectedIndex = 0;
                dt_ret.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("SearchLine : " + ex.Message);
            }
        }

        private void SearchMonths()
        {
            try
            {
                if (!FactorySelected) return;

                DataTable dt_ret = SELECT_PROD_MONTHS();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Month, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
                cmb_Month.SelectedValue = System.DateTime.Now.ToString("yyyyMM");
                dt_ret.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("SearchMonths : " + ex.Message);
            }
        }

        private void SearchDays()
        {
            try
            {
                if (!FactorySelected || !MonthSelected) return;

                DataTable dt_ret = SELECT_PROD_DAYS();
                DisplayDays(fgrid_Main, dt_ret);
                DisplayDays(fgrid_Sub, dt_ret);
                dt_ret.Dispose();

            }
            catch (Exception ex)
            {
                throw new Exception("SearchDays : " + ex.Message);
            }
        }

        private void SearchModel()
        {
            try
            {
                if (cmb_Factory.SelectedIndex == -1 || cmb_Month.SelectedIndex == -1) return;

                string factory = cmb_Factory.SelectedValue.ToString();
                string line = COM.ComFunction.Empty_Combo(cmb_line, "");
                string from = cmb_Month.SelectedValue.ToString() + "01";
                string to = cmb_Month.SelectedValue.ToString() + "31";

                DataTable dt_ret = SELECT_MODEL_LIST(factory, line, from, to);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_model, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Name);
                cmb_model.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DisplayDays(COM.FSP arg_grid, DataTable arg_dt)
        {
            try
            {
                arg_grid.Cols.Count = arg_grid.Cols.Frozen;
                _columns.Clear();

                for (int i = 0; i < arg_dt.Rows.Count; i++)
                {
                    Column newCol = arg_grid.Cols.Add();

                    newCol[0] = arg_dt.Rows[i][0];
                    newCol[1] = arg_dt.Rows[i][1];
                    newCol.AllowEditing = false;
                    newCol.DataType = typeof(double);
                    newCol.Format = "#,##0.##########";
                    newCol.TextAlign = TextAlignEnum.RightCenter;
                    newCol.Width = 60;
                    _columns.Add(arg_dt.Rows[i][0], newCol.Index);
                }

                /*
                // Total
                Column newCol2 = arg_grid.Cols.Add();
                newCol2[0] = "TOTAL";
                newCol2[1] = "Total";
                newCol2.AllowEditing = false;
                newCol2.DataType = typeof(double);
                newCol2.Format = "#,##0.##########";
                newCol2.TextAlign = TextAlignEnum.RightCenter;
                newCol2.Width = 80;

                // Ration
                Column newCol3 = arg_grid.Cols.Add();
                newCol3[0] = "RATION";
                newCol3[1] = "Ration";
                newCol3.AllowEditing = false;
                newCol3.DataType = typeof(double);
                newCol3.Format = "#,##0.##########";
                newCol3.TextAlign = TextAlignEnum.RightCenter;
                newCol3.Width = 80;
                */
            }
            catch (Exception ex)
            {
                throw new Exception("DisplayDays : " + ex.Message);
            }
        }

        #region 차트 

        private void resetChart(ChartFX.WinForms.Chart arg_chart, MemoryStream arg_stream)
        {
            arg_stream.Position = 0;
            arg_chart.Import(ChartFX.WinForms.FileFormat.Binary, arg_stream);
            arg_chart.Data.Clear();
        }

        #endregion

        #endregion

        #region 사전 체크

        private bool FactorySelected
        {
            get
            {
                if (cmb_Factory.SelectedIndex == -1) return false;
                else return true;
            }
        }

        private bool MonthSelected
        {
            get
            {
                if (cmb_Month.SelectedIndex == -1) return false;
                else return true;
            }
        }

        private bool ExistData
        {
            get
            {
                if (fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed) return true;
                else return false;
            }
        }

        #endregion

        #endregion

        #region 디비 연결

        #region 콤보

        private DataTable SELECT_LINE(string arg_factory)
        {
            try
            {
                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_BY_LINE.SELECT_LINE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_factory, " ");
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw new Exception("SELECT_LINE : " + ex.Message);
            }
        }

        /// <summary>
        /// PKG_EPM_PROD_DAILY_REPORT : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_PROD_MONTHS()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_REPORT.SELECT_PROD_MONTHS";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }

        /// <summary>
        /// PKG_EPM_PROD_DAILY_REPORT : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_PROD_DAYS()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_REPORT.SELECT_PROD_DAYS";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PLAN_YM";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
            MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_Month, "");
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }

        /// <summary>
        /// PKG_EPM_PROD_BY_LINE.SELECT_MODEL_LIST : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_MODEL_LIST(string arg_factory, string arg_line_cd, string arg_plan_from, string arg_plan_to)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_BY_LINE.SELECT_MODEL_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_PLAN_FROM";
                MyOraDB.Parameter_Name[3] = "ARG_PLAN_TO";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_line_cd;
                MyOraDB.Parameter_Values[2] = arg_plan_from;
                MyOraDB.Parameter_Values[3] = arg_plan_to;
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 조회

        /// <summary>
        /// SELECT_PROD_DAILY_ACTUALLY : 
        /// </summary>
        /// <returns>DataTable</returns>
        public bool SELECT_PROD_DAILY_ACTUALLY()
        {
            try
            {
                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_ACTUALLY.SELECT_PROD_DAILY_ACTUALLY";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_YM";
                MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
                MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_Month, "");
                MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_line, "");
                MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_model, "");
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// SELECT_PROD_DAILY_TARGET : 
        /// </summary>
        /// <returns>DataTable</returns>
        public bool SELECT_PROD_DAILY_TARGET()
        {
            try
            {
                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_TARGET.SELECT_PROD_DAILY_TARGET";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_PLAN_YM";
                MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
                MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_Month, "");
                MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_line, "");
                MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_model, "");
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(false);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// SELECT_PROD_DAILY_CHART : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataSet SELECT_PROD_DAILY_CHART()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(5);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_EPM_PROD_DAILY_ACTUALLY.SELECT_PROD_DAILY_CHART";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PLAN_YM";
            MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
            MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
            MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_Month, "");
            MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_line, "");
            MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_model, "");
            MyOraDB.Parameter_Values[4] = "";

            MyOraDB.Add_Select_Parameter(false);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret; 
        }
 
        #endregion 

        #endregion

    }
}

