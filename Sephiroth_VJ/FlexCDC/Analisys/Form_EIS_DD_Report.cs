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
    public partial class Form_EIS_DD_Report : COM.APSWinForm.Form_Top
    {
        #region 생성자
        public Form_EIS_DD_Report()
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
        private BaseInfo.Pop_MaterialXML_Wait _pop = null;       
        private Thread temp_thread = null;
        #endregion       
        
        #region Form Loading
        private void Form_EIS_DD_Report_Load(object sender, EventArgs e)
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
            fgrid_Main.Set_Grid("EIS_SHOE_MONITORING", "2", 3, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.AllowSorting = AllowSortingEnum.None;
            fgrid_Main.AllowDragging = AllowDraggingEnum.None;            
            fgrid_Main.Styles.Alternate.BackColor = Color.Empty;
            fgrid_Main.ExtendLastCol = false;
            fgrid_Main.Tree.Column = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxITEM_01;

            #region Grid Title Style
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER).StyleNew.ForeColor = Color.Black;


            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11M).StyleNew.ForeColor = Color.Black;
                        
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC21B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC21M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC21B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC21M).StyleNew.ForeColor = Color.Black;

            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC31B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC31M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC31B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC31M).StyleNew.ForeColor = Color.Black;

            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC41B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC41M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC41B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC41M).StyleNew.ForeColor = Color.Black;

            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC51B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC51M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC51B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC51M).StyleNew.ForeColor = Color.Black;

            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC61B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC61M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC61B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC61M).StyleNew.ForeColor = Color.Black;

            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC71B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC71M).StyleNew.BackColor = Color.Yellow;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC71B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC71M).StyleNew.ForeColor = Color.Black;

            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B, fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC14M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC31B, fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC34M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC51B, fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC54M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC71B, fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC74M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC12B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC14M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC32B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC34M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC52B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC54M).StyleNew.BackColor = Color.SkyBlue;
            fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed - 3, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC72B, fgrid_Main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC74M).StyleNew.BackColor = Color.SkyBlue;                        
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

            first_flg = false;
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

                _pop = new BaseInfo.Pop_MaterialXML_Wait();
                temp_thread = new Thread(new ThreadStart(_pop.Start));

                if (temp_thread != null)
                {
                    temp_thread.Start();
                    Display_Data();                            
                }

                

                Radio_Button_Check(null, null);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "tbtn_search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (temp_thread != null)
                {
                    temp_thread.Abort();                                  
                }

                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
        }
        private void Display_Data()
        {
            //Grid
            Display_Grid();
            //Chart
            fgrid_Main.Select(fgrid_Main.Rows.Fixed, 1);
            DataSet vDS = MakeChartData();
            Display_Chart(vDS); 
        }

        #region Grid Data Search
        private void Display_Grid()
        {
            #region Data Display
            string[] arg_value = new string[6];
            C1FlexGrid arg_grid = fgrid_Main;

            arg_value[0] = cmb_Season_from.SelectedValue.ToString();
            arg_value[1] = cmb_Season_to.SelectedValue.ToString();
            arg_value[2] = cmb_factory.SelectedValue.ToString().Trim();
            arg_value[3] = cmb_p_factory.SelectedValue.ToString().Trim();
            arg_value[4] = cmb_category.SelectedValue.ToString().Trim();
            arg_value[5] = cmb_model.SelectedValue.ToString().Trim();

            DataTable dt_ret = SELECT_DD_LIST(arg_value);

            for (int i = 0; i < dt_ret.Rows.Count; i++)
            {
                int lev = int.Parse(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxLEV].ToString());

                
                arg_grid.Rows.InsertNode(arg_grid.Rows.Count, lev);

                for (int j = arg_grid.Cols.Fixed; j < arg_grid.Cols.Count; j++)
                {
                    if (dt_ret.Rows[i].ItemArray[j].ToString().Equals("0"))
                        arg_grid[arg_grid.Rows.Count - 1, j] = " ";
                    else
                        arg_grid[arg_grid.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString();                  
                }

                if (lev.Equals(1))
                {
                    arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B, arg_grid.Rows.Count - 1, arg_grid.Cols.Count - 1).StyleNew.BackColor = Color.FromArgb(255, 255, 153);
                }
                else if (lev.Equals(2))
                {
                    arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B, arg_grid.Rows.Count - 1, arg_grid.Cols.Count - 1).StyleNew.BackColor = Color.FromArgb(204, 255, 255);
                }
                else if (lev.Equals(3))
                {
                    arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B, arg_grid.Rows.Count - 1, arg_grid.Cols.Count - 1).StyleNew.BackColor = Color.FromArgb(236, 246, 206);
                }
                else
                {
                    arg_grid.GetCellRange(arg_grid.Rows.Count - 1, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B, arg_grid.Rows.Count - 1, arg_grid.Cols.Count - 1).StyleNew.BackColor = Color.White;
                }
            }
            #endregion

            #region Data Sum
            int value_04 = 0;
            int value_03 = 0;
            int value_02 = 0;
            int model_tot_01 = 0;
            int model_tot_02 = 0;
            int model_tot_03 = 0;
            string style_cd = "";

            for (int col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B; col < arg_grid.Cols.Count; col++)
            {
                for (int row = arg_grid.Rows.Count - 1; row >= arg_grid.Rows.Fixed; row--)
                {
                    string lev = arg_grid[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxLEV].ToString().Trim();

                    if (lev.Equals("4"))
                    {
                        if (arg_grid[arg_grid.Rows.Fixed - 1, col].ToString().Trim().Equals("BOM"))
                        {
                            int value = int.Parse((arg_grid[row, col] == null || arg_grid[row, col].ToString().Trim().Equals("")) ? "0" : arg_grid[row, col].ToString().Trim());

                            value_04 += value;
                        }
                        else if (arg_grid[arg_grid.Rows.Fixed - 1, col].ToString().Trim().Equals("SKU"))
                        {
                            string vstyle_cd = arg_grid[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxSTYLE_CD].ToString().Trim();
                            int value = int.Parse((arg_grid[row, col] == null || arg_grid[row, col].ToString().Trim().Equals("")) ? "0" : arg_grid[row, col].ToString().Trim());
                            
                            if (vstyle_cd.Equals(""))
                            {
                                value_04 += value;
                            }
                            else if (!style_cd.Equals(vstyle_cd))
                            {
                                if (value.Equals(0))
                                    style_cd = "";
                                else
                                    style_cd = vstyle_cd;

                                value_04 += value;
                            }
                        }
                    }
                    else if (lev.Equals("3"))
                    {
                        if (arg_grid[arg_grid.Rows.Fixed - 1, col].ToString().Trim().Equals("BOM"))
                        {
                            arg_grid[row, col] = (value_04.Equals(0)) ? "" : value_04.ToString();
                            value_03 += value_04;
                            value_04 = 0;
                        }
                        else if (arg_grid[arg_grid.Rows.Fixed - 1, col].ToString().Trim().Equals("SKU"))
                        {
                            arg_grid[row, col] = (value_04.Equals(0)) ? "" : value_04.ToString();
                            value_03 += value_04;
                            value_04 = 0; 
                        }
                        else if (arg_grid[arg_grid.Rows.Fixed - 1, col].ToString().Trim().Equals("Model"))
                        {
                            if (arg_grid[arg_grid.Rows.Fixed - 3, col].ToString().Trim().Equals("Total"))
                            {
                                for (int m_tot = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B; m_tot < (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC74M; m_tot++)
                                {
                                    string spc = arg_grid[arg_grid.Rows.Fixed - 2, m_tot].ToString().Trim();

                                    if (!spc.Equals("SPC"))
                                    {
                                        if (arg_grid[arg_grid.Rows.Fixed - 1, m_tot].ToString().Trim().Equals("Model"))
                                        {
                                            int m_value = int.Parse((arg_grid[row, m_tot] == null || arg_grid[row, m_tot].ToString().Trim().Equals("")) ? "0" : arg_grid[row, m_tot].ToString().Trim());
                                            model_tot_03 += m_value;
                                        }
                                    }
                                }

                                arg_grid[row, col] = (model_tot_03.Equals(0)) ? "" : model_tot_03.ToString();
                                model_tot_03 = 0;
                            }
                            else
                            {
                                if (!arg_grid[row, col - 2].ToString().Trim().Equals(""))
                                {
                                    arg_grid[row, col] = "1";
                                    value_03 += 1;
                                }
                            }

                        }
                    }
                    else if (lev.Equals("2"))
                    {
                        if (arg_grid[arg_grid.Rows.Fixed - 1, col].ToString().Trim().Equals("BOM"))
                        {
                            arg_grid[row, col] = (value_03.Equals(0)) ? "" : value_03.ToString();
                            value_02 += value_03;
                            value_03 = 0;
                        }
                        else if (arg_grid[arg_grid.Rows.Fixed - 1, col].ToString().Trim().Equals("SKU"))
                        {
                            arg_grid[row, col] = (value_03.Equals(0)) ? "" : value_03.ToString();
                            value_02 += value_03;
                            value_03 = 0;
                        }
                        else if (arg_grid[arg_grid.Rows.Fixed - 1, col].ToString().Trim().Equals("Model"))
                        {
                            if (arg_grid[arg_grid.Rows.Fixed - 3, col].ToString().Trim().Equals("Total"))
                            {
                                for (int m_tot = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B; m_tot < (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC74M; m_tot++)
                                {
                                    string spc = arg_grid[arg_grid.Rows.Fixed - 2, m_tot].ToString().Trim();

                                    if (!spc.Equals("SPC"))
                                    {
                                        if (arg_grid[arg_grid.Rows.Fixed - 1, m_tot].ToString().Trim().Equals("Model"))
                                        {
                                            int m_value = int.Parse((arg_grid[row, m_tot] == null || arg_grid[row, m_tot].ToString().Trim().Equals("")) ? "0" : arg_grid[row, m_tot].ToString().Trim());
                                            model_tot_02 += m_value;
                                        }
                                    }
                                }

                                arg_grid[row, col] = (model_tot_02.Equals(0)) ? "" : model_tot_02.ToString();
                                model_tot_02 = 0;
                            }
                            else
                            {
                                if (!arg_grid[row, col - 2].ToString().Trim().Equals(""))
                                {
                                    arg_grid[row, col] = (value_03.Equals(0)) ? "" : value_03.ToString();
                                    value_02 += value_03;
                                    value_03 = 0;
                                }
                            }
                        }
                    }
                    else if (lev.Equals("1"))
                    {
                        if (arg_grid[arg_grid.Rows.Fixed - 1, col].ToString().Trim().Equals("BOM"))
                        {
                            arg_grid[row, col] = (value_02.Equals(0)) ? "" : value_02.ToString();
                            value_02 = 0;
                        }
                        else if (arg_grid[arg_grid.Rows.Fixed - 1, col].ToString().Trim().Equals("SKU"))
                        {
                            arg_grid[row, col] = (value_02.Equals(0)) ? "" : value_02.ToString();
                            value_02 = 0;
                        }
                        else if (arg_grid[arg_grid.Rows.Fixed - 1, col].ToString().Trim().Equals("Model"))
                        {
                            if (arg_grid[arg_grid.Rows.Fixed - 3, col].ToString().Trim().Equals("Total"))
                            {
                                for (int m_tot = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B; m_tot < (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC74M; m_tot++)
                                {
                                    string spc = arg_grid[arg_grid.Rows.Fixed - 2, m_tot].ToString().Trim();

                                    if (!spc.Equals("SPC"))
                                    {
                                        if (arg_grid[arg_grid.Rows.Fixed - 1, m_tot].ToString().Trim().Equals("Model"))
                                        {
                                            int m_value = int.Parse((arg_grid[row, m_tot] == null || arg_grid[row, m_tot].ToString().Trim().Equals("")) ? "0" : arg_grid[row, m_tot].ToString().Trim());
                                            model_tot_01 += m_value;
                                        }
                                    }
                                }

                                arg_grid[row, col] = (model_tot_01.Equals(0)) ? "" : model_tot_01.ToString();
                                model_tot_01 = 0;
                            }
                            else
                            {
                                if (!arg_grid[row, col - 2].ToString().Trim().Equals(""))
                                {
                                    arg_grid[row, col] = (value_02.Equals(0)) ? "" : value_02.ToString();                                    
                                    value_02 = 0;
                                }
                            }
                        }
                    }
                }
            }

            //int value_04 = 0;
            //int value_03 = 0;            
            //int value_02 = 0;            
            //string style_cd = "";

            //for (int col = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B; col < fgrid_Main.Cols.Count; col++)
            //{
            //    for (int row = fgrid_Main.Rows.Count - 1; row >= fgrid_Main.Rows.Fixed; row--)
            //    {
            //        string lev = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxLEV].ToString().Trim();

            //        if (lev.Equals("4"))
            //        {
            //            if (fgrid_Main[fgrid_Main.Rows.Fixed - 1, col].ToString().Trim().Equals("SKU"))
            //            {
            //                string vstyle_cd = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxSTYLE_CD].ToString().Trim();
            //                int value = int.Parse((fgrid_Main[row, col] == null || fgrid_Main[row, col].ToString().Trim().Equals("")) ? "0" : fgrid_Main[row, col].ToString().Trim());


            //                if (vstyle_cd.Equals(""))
            //                {                                
            //                    value_04 += value;  
            //                }
            //                else if (!style_cd.Equals(vstyle_cd))
            //                {                                
            //                    if(value.Equals(0))
            //                        style_cd = "";
            //                    else
            //                        style_cd = vstyle_cd;

            //                    value_04 += value; 
            //                }
            //            }
            //            else
            //            {
            //                int value = int.Parse((fgrid_Main[row, col] == null || fgrid_Main[row, col].ToString().Trim().Equals("")) ? "0" : fgrid_Main[row, col].ToString().Trim());
            //                value_04 += value;
            //            }
            //        }
            //        else if (lev.Equals("3"))
            //        {
            //            if (fgrid_Main[fgrid_Main.Rows.Fixed - 1, col].ToString().Trim().Equals("Model"))
            //            {
            //                if (!fgrid_Main[fgrid_Main.Rows.Fixed - 3, col].ToString().Trim().Equals("Total"))
            //                {
            //                    if (!fgrid_Main[row, col - 2].ToString().Trim().Equals(""))
            //                    {
            //                        fgrid_Main[row, col] = "1";
            //                        value_03 += 1;
            //                        value_04 = 0;

            //                        string tot_value = Convert.ToString( int.Parse((fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC91M] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC91M].ToString().Trim().Equals("")) ? "0" : fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC91M].ToString().Trim()) + 1);
            //                        fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC91M] = tot_value;
            //                    }
            //                }
            //                else
            //                {
            //                    value_03 += int.Parse((fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC91M] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC91M].ToString().Trim().Equals("")) ? "0" : fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC91M].ToString().Trim());
            //                    value_04 = 0;                                                    
            //                }
            //            }
            //            else
            //            {
            //                fgrid_Main[row, col] = (value_04.Equals(0)) ? "" : value_04.ToString();
            //                value_03 += value_04;
            //                value_04 = 0;
            //            }
            //        }
            //        else if (lev.Equals("2"))
            //        {
            //            fgrid_Main[row, col] = (value_03.Equals(0)) ? "" : value_03.ToString();
            //            value_02 += value_03;
            //            value_03 = 0;
            //        }
            //        else if (lev.Equals("1"))
            //        {
            //            fgrid_Main[row, col] = (value_02.Equals(0)) ? "" : value_02.ToString();                        
            //            value_02 = 0;
            //        }
            //    }
            //}

            #endregion

            #region Total Percentage
            double tot_bom_value_01 = 0;
            double tot_bom_value_02 = 0;
            double tot_bom_value_03 = 0;
            double tot_bom_value_04 = 0;

            double tot_sku_value_01 = 0;
            double tot_sku_value_02 = 0;
            double tot_sku_value_03 = 0;

            double tot_model_value_01 = 0;
            double tot_model_value_02 = 0;
            double tot_model_value_03 = 0;
            

            for (int tot_row = fgrid_Main.Rows.Fixed; tot_row < fgrid_Main.Rows.Count; tot_row++)
            {
                string lev = fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxLEV].ToString().Trim();

                if (lev.Equals("1"))
                {
                    tot_bom_value_01   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim());
                    tot_sku_value_01   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S].ToString().Trim());
                    tot_model_value_01 = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim());
                    
                    fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER] = (tot_bom_value_01.Equals(0)) ? "0" : "100";
                    fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER] = (tot_sku_value_01.Equals(0)) ? "0" : "100";
                    fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER] = (tot_model_value_01.Equals(0)) ? "0" : "100";
                }
                else if (lev.Equals("2"))
                {
                    tot_bom_value_02   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim());
                    tot_sku_value_02   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S].ToString().Trim());
                    tot_model_value_02 = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim());
                    
                    double bom_per   = (tot_bom_value_02.Equals(0)) ? 0 : 100 * tot_bom_value_02 / tot_bom_value_01;
                    double sku_per   = (tot_sku_value_02.Equals(0)) ? 0 : 100 * tot_sku_value_02 / tot_sku_value_01;
                    double model_per = (tot_model_value_02.Equals(0)) ? 0 : 100 * tot_model_value_02 / tot_model_value_01;
                   
                    fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER] = (bom_per.Equals(0)) ? "" : bom_per.ToString("####0");
                    fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER] = (sku_per.Equals(0)) ? "" : sku_per.ToString("####0");
                    fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER] = (model_per.Equals(0)) ? "" : model_per.ToString("####0");
                }
                else if (lev.Equals("3"))
                {
                    tot_bom_value_03   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim());
                    tot_sku_value_03   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S].ToString().Trim());
                    tot_model_value_03 = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim());
                    
                    double bom_per   = (tot_bom_value_03.Equals(0)) ? 0 : 100 * tot_bom_value_03 / tot_bom_value_02;
                    double sku_per   = (tot_sku_value_03.Equals(0)) ? 0 : 100 * tot_sku_value_03 / tot_sku_value_02;
                    double model_per = (tot_model_value_03.Equals(0)) ? 0 : 100 * tot_model_value_03 / tot_model_value_02;

                    fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER] = (bom_per.Equals(0)) ? "" : bom_per.ToString("####0");
                    fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER] = (sku_per.Equals(0)) ? "" : sku_per.ToString("####0");
                    fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER] = (model_per.Equals(0)) ? "" : model_per.ToString("####0");
                }
                else if (lev.Equals("4"))
                {
                    tot_bom_value_04 = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim());

                    double bom_per = (tot_bom_value_04.Equals(0)) ? 0 : 100 * tot_bom_value_04 / tot_bom_value_03;

                    fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER] = (bom_per.Equals(0)) ? "" : bom_per.ToString("####0");
                }
            }

            //double tot_bom_value_01 = 0;
            //double tot_bom_value_02 = 0;
            //double tot_bom_value_03 = 0;
            //double tot_bom_value_04 = 0;
            //double tot_sku_value_01 = 0;
            //double tot_sku_value_02 = 0;
            //double tot_sku_value_03 = 0;
            
            //double tot_model_value_01 = 0;
            //double tot_model_value_02 = 0;
            //double tot_model_value_03 = 0;
            

            //for (int tot_row = fgrid_Main.Rows.Fixed; tot_row < fgrid_Main.Rows.Count; tot_row++)
            //{
            //    string lev = fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxLEV].ToString().Trim();

            //    if (lev.Equals("1"))
            //    {
            //        tot_bom_value_01   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim());
            //        tot_sku_value_01   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S].ToString().Trim());
            //        tot_model_value_01 = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim());

            //        fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER] = (tot_bom_value_01.Equals(0)) ? "0" : "100";
            //        fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER] = (tot_sku_value_01.Equals(0)) ? "0" : "100";
            //        fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER] = (tot_model_value_01.Equals(0)) ? "0" : "100";
            //    }
            //    else if (lev.Equals("2"))
            //    {
            //        tot_bom_value_02   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC91B] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim().Equals("")) ? "0" : (fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim());
            //        tot_sku_value_02   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC91S] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S].ToString().Trim().Equals("")) ? "0" : (fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S].ToString().Trim());
            //        tot_model_value_02 = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC91M] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim().Equals("")) ? "0" : (fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim());

            //        double bom_per   = (tot_bom_value_02.Equals(0)) ? 0 : 100 * tot_bom_value_02 / tot_bom_value_01;
            //        double sku_per   = (tot_sku_value_02.Equals(0)) ? 0 : 100 * tot_sku_value_02 / tot_sku_value_01;
            //        double model_per = (tot_model_value_02.Equals(0)) ? 0 : 100 * tot_model_value_02 / tot_model_value_01;

            //        fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER] = bom_per.ToString("####0");
            //        fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER] = sku_per.ToString("####0");
            //        fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER] = model_per.ToString("####0");
            //    }
            //    else if (lev.Equals("3"))
            //    {
            //        tot_bom_value_03   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim());
            //        tot_sku_value_03   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S].ToString().Trim());
            //        tot_model_value_03 = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M].ToString().Trim());

            //        double bom_per   = (tot_bom_value_03.Equals(0)) ? 0 : 100 * tot_bom_value_03 / tot_bom_value_02;
            //        double sku_per   = (tot_sku_value_03.Equals(0)) ? 0 : 100 * tot_sku_value_03 / tot_sku_value_02;
            //        double model_per = (tot_model_value_03.Equals(0)) ? 0 : 100 * tot_model_value_03 / tot_model_value_02;

            //        fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER] = bom_per.ToString("####0");
            //        fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER] = sku_per.ToString("####0");
            //        fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER] = model_per.ToString("####0");
            //    }
            //    else if (lev.Equals("4"))
            //    {
            //        tot_bom_value_04   = int.Parse((fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B] == null || fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim().Equals("")) ? "0" : fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B].ToString().Trim());

            //        double bom_per = (tot_bom_value_04.Equals(0)) ? 0 : 100 * tot_bom_value_04 / tot_bom_value_03;                    

            //        fgrid_Main[tot_row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER] = bom_per.ToString("####0");                    
            //    }
            //}
            #endregion                        
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
                DataTable vDT_BOM    = new DataTable("BOM DataTable");
                DataTable vDT_SKU    = new DataTable("SKU DataTable");
                DataTable vDT_MODEL  = new DataTable("MODEL DataTable");
                DataSet vDSChartData = new DataSet("Chart DataSet");
                vDT_BOM.Columns.Add(new DataColumn("X_LABLE"));
                vDT_SKU.Columns.Add(new DataColumn("X_LABLE"));
                vDT_MODEL.Columns.Add(new DataColumn("X_LABLE"));


                if (fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed)
                {
                    for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count; row++)
                    {
                        string lev = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxLEV].ToString();

                        if (lev.Equals("1"))
                        {
                            vDT_BOM.Columns.Add(fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxSEASON_NAME].ToString());
                            vDT_SKU.Columns.Add(fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxSEASON_NAME].ToString());
                            vDT_MODEL.Columns.Add(fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxSEASON_NAME].ToString()); 
                        }
                    }
                }

                string[] pcc_qd = new string[vDT_BOM.Columns.Count];
                string[] pcc_vj = new string[vDT_BOM.Columns.Count];
                string[] qd_qd  = new string[vDT_BOM.Columns.Count];
                string[] vj_vj  = new string[vDT_BOM.Columns.Count];

                string[] pcc_qd_02 = new string[vDT_SKU.Columns.Count];
                string[] pcc_vj_02 = new string[vDT_SKU.Columns.Count];
                string[] qd_qd_02  = new string[vDT_SKU.Columns.Count];
                string[] vj_vj_02  = new string[vDT_SKU.Columns.Count];

                string[] pcc_qd_03 = new string[vDT_MODEL.Columns.Count];
                string[] pcc_vj_03 = new string[vDT_MODEL.Columns.Count];
                string[] qd_qd_03  = new string[vDT_MODEL.Columns.Count];
                string[] vj_vj_03  = new string[vDT_MODEL.Columns.Count];

                int pcc_qd_cnt = 1;
                int pcc_vj_cnt = 1;
                int qd_qd_cnt  = 1;
                int vj_vj_cnt  = 1;


                if (fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed)
                {
                    for (int row = fgrid_Main.Rows.Fixed; row < fgrid_Main.Rows.Count; row++)
                    {
                        string lev = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxLEV].ToString();

                        if (lev.Equals("2"))
                        {
                            string item_name = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxITEM_01].ToString().Trim().Replace(" ", "");

                            if (item_name.Equals("PCC/QD"))
                            {
                                 object item    = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER];
                                 object item_02 = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER];
                                 object item_03 = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER];


                                 if (fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER].ToString().Trim().Equals(""))                                 
                                     item = "0";
                                 if (fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER].ToString().Trim().Equals(""))
                                     item_02 = "0";
                                 if (fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER].ToString().Trim().Equals(""))
                                     item_03 = "0";

                                 pcc_qd[0] = item_name;
                                 pcc_qd[pcc_qd_cnt] = item.ToString();

                                 pcc_qd_02[0] = item_name;
                                 pcc_qd_02[pcc_qd_cnt] = item_02.ToString();

                                 pcc_qd_03[0] = item_name;
                                 pcc_qd_03[pcc_qd_cnt] = item_03.ToString();

                                 pcc_qd_cnt++;
                            }
                            else if (item_name.Equals("PCC/VJ"))
                            {
                                object item = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER];
                                object item_02 = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER];
                                object item_03 = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER];


                                if (fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER].ToString().Trim().Equals(""))
                                    item = "0";
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER].ToString().Trim().Equals(""))
                                    item_02 = "0";
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER].ToString().Trim().Equals(""))
                                    item_03 = "0";


                                pcc_vj[0] = item_name;
                                pcc_vj[pcc_vj_cnt] = item.ToString();

                                pcc_vj_02[0] = item_name;
                                pcc_vj_02[pcc_vj_cnt] = item_02.ToString();

                                pcc_vj_03[0] = item_name;
                                pcc_vj_03[pcc_vj_cnt] = item_03.ToString();

                                pcc_vj_cnt++;
                            }
                            else if (item_name.Equals("QD/QD"))
                            {
                                object item = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER];
                                object item_02 = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER];
                                object item_03 = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER];


                                if (fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER].ToString().Trim().Equals(""))
                                    item = "0";
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER].ToString().Trim().Equals(""))
                                    item_02 = "0";
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER].ToString().Trim().Equals(""))
                                    item_03 = "0";

                                qd_qd[0] = item_name;
                                qd_qd[qd_qd_cnt] = item.ToString();

                                qd_qd_02[0] = item_name;
                                qd_qd_02[qd_qd_cnt] = item_02.ToString();

                                qd_qd_03[0] = item_name;
                                qd_qd_03[qd_qd_cnt] = item_03.ToString();

                                qd_qd_cnt++;
                            }
                            else if (item_name.Equals("VJ/VJ"))
                            {
                                object item = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER];
                                object item_02 = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER];
                                object item_03 = fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER];


                                if (fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81B_PER].ToString().Trim().Equals(""))
                                    item = "0";
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81S_PER].ToString().Trim().Equals(""))
                                    item_02 = "0";
                                if (fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER] == null || fgrid_Main[row, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC81M_PER].ToString().Trim().Equals(""))
                                    item_03 = "0";


                                vj_vj[0] = item_name;
                                vj_vj[vj_vj_cnt] = item.ToString();

                                vj_vj_02[0] = item_name;
                                vj_vj_02[vj_vj_cnt] = item_02.ToString();

                                vj_vj_03[0] = item_name;
                                vj_vj_03[vj_vj_cnt] = item_03.ToString();

                                vj_vj_cnt++;
                            }
                        }
                    }
                }

                DataRow drBOM_pccqd = vDT_BOM.NewRow();
                DataRow drBOM_pccvj = vDT_BOM.NewRow();
                DataRow drBOM_qd    = vDT_BOM.NewRow();
                DataRow drBOM_vj    = vDT_BOM.NewRow();

                DataRow drSKU_pccqd = vDT_SKU.NewRow();
                DataRow drSKU_pccvj = vDT_SKU.NewRow();
                DataRow drSKU_qd    = vDT_SKU.NewRow();
                DataRow drSKU_vj    = vDT_SKU.NewRow();

                DataRow drMODEL_pccqd = vDT_MODEL.NewRow();
                DataRow drMODEL_pccvj = vDT_MODEL.NewRow();
                DataRow drMODEL_qd    = vDT_MODEL.NewRow();
                DataRow drMODEL_vj    = vDT_MODEL.NewRow();

                for (int col = 0; col < vDT_BOM.Columns.Count; col++)
                {
                    drBOM_pccqd[col] = pcc_qd[col];
                    drBOM_pccvj[col] = pcc_vj[col];
                    drBOM_qd[col]    = qd_qd[col];
                    drBOM_vj[col]    = vj_vj[col];

                    drSKU_pccqd[col] = pcc_qd_02[col];
                    drSKU_pccvj[col] = pcc_vj_02[col];
                    drSKU_qd[col]    = qd_qd_02[col];
                    drSKU_vj[col]    = vj_vj_02[col];

                    drMODEL_pccqd[col] = pcc_qd_03[col];
                    drMODEL_pccvj[col] = pcc_vj_03[col];
                    drMODEL_qd[col]    = qd_qd_03[col];
                    drMODEL_vj[col]    = vj_vj_03[col];
                }

                vDT_BOM.Rows.Add(drBOM_pccqd);
                vDT_BOM.Rows.Add(drBOM_pccvj);
                vDT_BOM.Rows.Add(drBOM_qd);
                vDT_BOM.Rows.Add(drBOM_vj);

                vDT_SKU.Rows.Add(drSKU_pccqd);
                vDT_SKU.Rows.Add(drSKU_pccvj);
                vDT_SKU.Rows.Add(drSKU_qd);
                vDT_SKU.Rows.Add(drSKU_vj);

                vDT_MODEL.Rows.Add(drMODEL_pccqd);
                vDT_MODEL.Rows.Add(drMODEL_pccvj);
                vDT_MODEL.Rows.Add(drMODEL_qd);
                vDT_MODEL.Rows.Add(drMODEL_vj);

                vDSChartData.Tables.AddRange(new DataTable[] { vDT_BOM, vDT_SKU, vDT_MODEL });
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

            // BOM Chart
            DataTable vDTBOM = arg_ds.Tables[0];

            chart_01.Data.Series = vDTBOM.Columns.Count;
            chart_01.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("X_LABLE", ChartFX.WinForms.FieldUsage.Label));
            for (int i = 1; i < vDTBOM.Columns.Count; i++)
            {
                chart_01.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap(vDTBOM.Columns[i].ColumnName.ToString(), ChartFX.WinForms.FieldUsage.Value));
            }

            chart_01.DataSource = vDTBOM;
            chart_01.Font = new Font("Verdana", 8);
            chart_01.Gallery = ChartFX.WinForms.Gallery.Pie;
            chart_01.AllSeries.FillMode = FillMode.Gradient;
            chart_01.AllSeries.PointLabels.Visible = true;
            chart_01.LegendBox.Visible = false;

            // SKU Chart
            DataTable vDTSKU = arg_ds.Tables[1];

            chart_02.Data.Series = vDTSKU.Columns.Count;
            chart_02.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("X_LABLE", ChartFX.WinForms.FieldUsage.Label));
            for (int i = 1; i < vDTSKU.Columns.Count; i++)
            {
                chart_02.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap(vDTSKU.Columns[i].ColumnName.ToString(), ChartFX.WinForms.FieldUsage.Value));
            }

            chart_02.DataSource = vDTSKU;
            chart_02.Font = new Font("Verdana", 8);
            chart_02.Gallery = ChartFX.WinForms.Gallery.Pie;
            chart_02.AllSeries.FillMode = FillMode.Gradient;
            chart_02.AllSeries.PointLabels.Visible = true;
            chart_02.LegendBox.Visible = false;

            // Model Chart
            DataTable vDTMODEL = arg_ds.Tables[2];

            chart_03.Data.Series = vDTMODEL.Columns.Count;
            chart_03.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("X_LABLE", ChartFX.WinForms.FieldUsage.Label));
            for (int i = 1; i < vDTMODEL.Columns.Count; i++)
            {
                chart_03.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap(vDTMODEL.Columns[i].ColumnName.ToString(), ChartFX.WinForms.FieldUsage.Value));
            }

            chart_03.DataSource = vDTMODEL;
            chart_03.Font = new Font("Verdana", 8);
            chart_03.Gallery = ChartFX.WinForms.Gallery.Pie;
            chart_03.AllSeries.FillMode = FillMode.Gradient;
            chart_03.AllSeries.PointLabels.Visible = true;
            chart_03.LegendBox.Visible = false;
        }
        #endregion

        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                string arg_season_from = cmb_Season_from.SelectedValue.ToString();
                string arg_season_to   = cmb_Season_to.SelectedValue.ToString();
                string arg_factory     = cmb_factory.SelectedValue.ToString();
                string arg_p_factory   = cmb_p_factory.SelectedValue.ToString();
                string arg_category    = cmb_category.SelectedValue.ToString();
                string arg_model_id    = cmb_model.SelectedValue.ToString();

                Pop_EIS_DD_Report_Check pop = new Pop_EIS_DD_Report_Check(arg_season_from, arg_season_to, arg_factory, arg_p_factory, arg_category, arg_model_id);
                pop.WindowState = FormWindowState.Normal;
                pop.ShowDialog();


                string mrd_Filename = "";
                string txt_Filename = "DD_Report.txt";
                string Para = "/rfn [" + Application.StartupPath + @"\" + txt_Filename + "]  /rv ";

                #region 파일만들기
                FileInfo file = new FileInfo(Application.StartupPath + @"\" + txt_Filename);
                if (!file.Exists)
                {
                    file.Create().Close();
                }                

                FileStream sDatalist = new FileStream(txt_Filename, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(sDatalist, K_Encode);
                #endregion

                #region Level에 따른 Data Flush
                if (lbl_viewSeason.Checked || lbl_viewFactory.Checked) // 1, 2 Level
                {
                    mrd_Filename = Application.StartupPath + @"\Report\DD_Report.mrd";                    
                                        
                    #region Data Flush
                    string season = "";                   

                    for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                    {
                        string sData = "";
                        string lev = fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxLEV].ToString().Trim();

                        if (lev.Equals("1"))
                        {
                            season = fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxITEM_01].ToString().Trim();
                        }
                        else if (lev.Equals("2"))
                        {                            
                            sData = season + "@" + fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxITEM_01].ToString().Replace("\r\n", "") + " @";

                            for (int j = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B; j < fgrid_Main.Cols.Count; j++)
                            {
                                if (fgrid_Main[i, j] == null)
                                {
                                    sData = sData + "@";
                                }
                                else
                                {
                                    sData = sData + fgrid_Main[i, j].ToString().Replace("\r\n", "") + " @";
                                }
                            }

                            sw.WriteLine(sData);
                        }                        
                    }

                    sw.Flush();
                    sw.Close();

                    sDatalist.Close();
                    #endregion
                }
                else if (lbl_viewModel.Checked) // 3 Level
                {
                    mrd_Filename = Application.StartupPath + @"\Report\DD_Report_4Level.mrd";

                    #region Data Flush
                    for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                    {
                        string sData = "";

                        string lev = fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxLEV].ToString().Trim();

                        if (!lev.Equals("4"))
                        {
                            sData = lev + "@" + fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxITEM_01].ToString().Replace("\r\n", "") + " @";

                            for (int j = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B; j < fgrid_Main.Cols.Count; j++)
                            {
                                if (fgrid_Main[i, j] == null)
                                {
                                    sData = sData + "@";
                                }
                                else
                                {
                                    sData = sData + fgrid_Main[i, j].ToString().Replace("\r\n", "") + " @";
                                }
                            }

                            sw.WriteLine(sData);    
                        }                        
                    }

                    sw.Flush();
                    sw.Close();

                    sDatalist.Close();
                    #endregion
                }
                else if (lbl_viewBom.Checked) // 4 Level
                {
                    mrd_Filename = Application.StartupPath + @"\Report\DD_Report_4Level.mrd";
                                        
                    #region Data Flush
                    for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                    {
                        string sData = "";

                        string lev = fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxLEV].ToString().Trim();

                        sData = lev + "@" + fgrid_Main[i, (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxITEM_01].ToString().Replace("\r\n", "") + " @";

                        for (int j = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B; j < fgrid_Main.Cols.Count; j++)
                        {
                            if (fgrid_Main[i, j] == null)
                            {
                                sData = sData + "@";
                            }
                            else
                            {
                                sData = sData + fgrid_Main[i, j].ToString().Replace("\r\n", "") + " @";
                            }
                        }

                        sw.WriteLine(sData);
                    }

                    sw.Flush();
                    sw.Close();

                    sDatalist.Close();
                    #endregion
                }
                #endregion

                //Report View
                Report.Form_RdViewer report = new Report.Form_RdViewer(txt_Filename, mrd_Filename, Para);
                report.ShowDialog();

                //File Delete
                file.Delete();
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

                int col_point = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B;

                for (int i = (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC11B; i <= (int)ClassLib.TBEIS_DD_REPORT_SEASON_NEW.IxC91S; i++)
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
                ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_model, 0, 1, true, 100, 220); ;
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
                ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_model, 0, 1, true, 100, 220); ;
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
                ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_model, 0, 1, true, 100, 220); ;
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
                ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_model, 0, 1, true, 100, 220); ;
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
                ClassLib.ComFunction.Set_ComboList_Width(dt_ret, cmb_model, 0, 1, true, 100, 220); ;
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
        #endregion                 

        #region Context Menu
        private void mnu_popup_Click(object sender, EventArgs e)
        {
            try
            {
                Pop_EIS_DD_Report pop = new Pop_EIS_DD_Report(this);
                pop.WindowState = FormWindowState.Normal;
                pop.ShowDialog();

                if (pop.save_flg)
                {                    
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

        
    }
}