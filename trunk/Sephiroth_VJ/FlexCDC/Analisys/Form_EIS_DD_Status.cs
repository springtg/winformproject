using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using C1.Win.C1Chart;
using ChartFX.WinForms;
using ChartFX.WinForms.Annotation;
using ChartFX.WinForms.DataProviders;
using System.IO;

namespace FlexCDC.Analisys
{
    public partial class Form_EIS_DD_Status : COM.APSWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();
        private System.IO.MemoryStream _memoryStream;
        private bool chk_flg = false;
        #endregion

        #region Resource
        public Form_EIS_DD_Status()
        {
            InitializeComponent();

            _memoryStream = new System.IO.MemoryStream();
            chart_main.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);

            _memoryStream = new System.IO.MemoryStream();
            chart_prod.Export(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
        }
       
        #endregion       

        #region Form Loading
        private void Form_EIS_DD_Status_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }

        }

        private void Init_Form()
        {
            //Title
            this.Text = " Seasonal DD Status";
            lbl_MainTitle.Text = " Seasonal DD Status";
            lbl_title.Text = "       Search Condition ";

            Init_Grid();
            Init_Control();
            Init_Toolbar();
            Init_Chart();
        }

        private void Init_Grid()
        {
            #region DD Status
            fgrid_main.Set_Grid("EIS_DD_STATUS", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_main.Set_Action_Image(img_Action);
            fgrid_main.AllowDragging = AllowDraggingEnum.None;
            fgrid_main.ExtendLastCol = false;

            fgrid_main.AllowMerging = AllowMergingEnum.Free;

            for (int j = (int)ClassLib.TBEIS_DD_STATUS.IxSEASON_NAME; j <= (int)ClassLib.TBEIS_DD_STATUS.IxREMARKS; j++)
            {
                if (j.Equals((int)ClassLib.TBEIS_DD_STATUS.IxSEASON_NAME) || j.Equals((int)ClassLib.TBEIS_DD_STATUS.IxREMARKS))
                {
                    fgrid_main.Cols[j].AllowMerging = true;
                }
                else
                {
                    fgrid_main.Cols[j].AllowMerging = false;
                }
            }

            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_STATUS.IxTOT_DD_BOM).StyleNew.BackColor = Color.Yellow;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_STATUS.IxTOT_DD_BOM).StyleNew.ForeColor = Color.Black;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_STATUS.IxPERCENT).StyleNew.BackColor = Color.LightPink;
            fgrid_main.GetCellRange(fgrid_main.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_STATUS.IxPERCENT).StyleNew.ForeColor = Color.Black;
            #endregion

            #region Prod. Factory
            fgrid_prod.Set_Grid("EIS_DD_PROD_FACTORY", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_prod.Set_Action_Image(img_Action);
            fgrid_prod.AllowDragging = AllowDraggingEnum.None;
            fgrid_prod.ExtendLastCol = false;

            fgrid_prod.AllowMerging = AllowMergingEnum.Free;

            for (int j = (int)ClassLib.TBEIS_DD_PROD_FTY.IxSEASON_NAME; j <= (int)ClassLib.TBEIS_DD_PROD_FTY.IxPER_VJ; j++)
            {
                if (j.Equals((int)ClassLib.TBEIS_DD_PROD_FTY.IxSEASON_NAME) || j.Equals((int)ClassLib.TBEIS_DD_PROD_FTY.IxQD_FACTORY) || j.Equals((int)ClassLib.TBEIS_DD_PROD_FTY.IxVJ_FACTORY))
                {
                    fgrid_prod.Cols[j].AllowMerging = true;
                }
                else
                {
                    fgrid_prod.Cols[j].AllowMerging = false;
                }
            }

            fgrid_prod.GetCellRange(fgrid_prod.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_PROD_FTY.IxQD_FACTORY, fgrid_prod.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_PROD_FTY.IxPER_QD).StyleNew.BackColor = Color.Yellow;
            fgrid_prod.GetCellRange(fgrid_prod.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_PROD_FTY.IxQD_FACTORY, fgrid_prod.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_PROD_FTY.IxPER_QD).StyleNew.ForeColor = Color.Black;
            fgrid_prod.GetCellRange(fgrid_prod.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_PROD_FTY.IxVJ_FACTORY, fgrid_prod.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_PROD_FTY.IxPER_VJ).StyleNew.BackColor = Color.LightPink;
            fgrid_prod.GetCellRange(fgrid_prod.Rows.Fixed - 2, (int)ClassLib.TBEIS_DD_PROD_FTY.IxVJ_FACTORY, fgrid_prod.Rows.Fixed - 1, (int)ClassLib.TBEIS_DD_PROD_FTY.IxPER_VJ).StyleNew.ForeColor = Color.Black;
            #endregion
        }
        private void Init_Control()
        {       
            DataTable dt_ret = SELECT_SEASON();                
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sesn_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sesn_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_sesn_from.SelectedValue = "200904";
            cmb_sesn_to.SelectedValue = "200904";

            // Factory Combobox Setting
            dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, true, COM.ComVar.ComboList_Visible.Name);

            cmb_factory.SelectedIndex = 0;            

            //Prod. Factory
            dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SXC35");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_p_factory, 1, 2, true, COM.ComVar.ComboList_Visible.Name);
            cmb_p_factory.SelectedIndex = 0;           
        }    
        private void Init_Toolbar()
        {
            // Disabled tbutton         
            tbtn_New.Enabled = false;
            tbtn_Search.Enabled = true;
            tbtn_Save.Enabled = false;
            tbtn_Append.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Print.Enabled = true;
        }
        private void Init_Chart()
        {
            //main
            _memoryStream.Position = 0;
            chart_main.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_main.Data.Clear();
            chart_main.BackColor = Color.FloralWhite;

            //prod
            _memoryStream.Position = 0;
            chart_prod.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
            chart_prod.Data.Clear();
            chart_prod.BackColor = Color.MintCream;
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
            MyOraDB.Parameter_Values[2] = cmb_sesn_from.SelectedValue.ToString();
            MyOraDB.Parameter_Values[3] = cmb_sesn_to.SelectedValue.ToString();
            MyOraDB.Parameter_Values[4] = "";//cmb_category.SelectedValue.ToString();
            MyOraDB.Parameter_Values[5] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_DEV_USER()
        {
            string Proc_Name = "PKG_EDM_PCC_01.SELECT_DEV_USER_DD";

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
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (tab_main.SelectedIndex.Equals(0))
                {
                    Display_DD_Status();
                }
                else if (tab_main.SelectedIndex.Equals(1))
                {
                    Display_DD_Prod();
                }
                else
                {
 
                }
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

        #region DD Status
        private void Display_DD_Status()
        {
            Set_Chart_Before();

            if (Display_DD_Status_Grid())
            {
                Display_DD_Status_Chart(); 
            }
        }
        private bool Display_DD_Status_Grid()
        {
            try
            {
                fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

                string[] arg_value = new string[14];
                arg_value[0 ] = cmb_sesn_from.SelectedValue.ToString().Trim();
                arg_value[1 ] = cmb_sesn_to.SelectedValue.ToString().Trim();
                arg_value[2 ] = cmb_factory.SelectedValue.ToString().Trim();
                arg_value[3 ] = cmb_p_factory.SelectedValue.ToString().Trim();
                arg_value[4 ] = (chk_offshore.Checked) ? "Y" : "";
                arg_value[5 ] = (chk_all.Checked) ? "Y" : "N";
                arg_value[6 ] = (chk_lks.Checked) ? "Y" : "N";
                arg_value[7 ] = (chk_smm.Checked) ? "Y" : "N";
                arg_value[8 ] = (chk_rlf.Checked) ? "Y" : "N";
                arg_value[9 ] = (chk_acn.Checked) ? "Y" : "N";
                arg_value[10] = (chk_gtm.Checked) ? "Y" : "N";
                arg_value[11] = (chk_pre.Checked) ? "Y" : "N";
                arg_value[12] = (chk_rfc.Checked) ? "Y" : "N";
                arg_value[13] = (chk_prod.Checked) ? "Y" : "N";

                DataTable dt_ret = SELECT_DD_STATUS(arg_value);

                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {
                    fgrid_main.Rows.Add();

                    for (int j = fgrid_main.Cols.Fixed; j < fgrid_main.Cols.Count; j++)
                    {
                        fgrid_main[fgrid_main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();
                    }

                    string factory = fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_STATUS.IxFACTORY].ToString().Trim();

                    if (factory.Equals(""))
                    {
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_STATUS.IxRUNNING, fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_STATUS.IxTRACK_FIELD).StyleNew.BackColor = Color.WhiteSmoke;
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_STATUS.IxTOT_DD_BOM).StyleNew.BackColor = Color.LightGoldenrodYellow;
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_STATUS.IxPERCENT).StyleNew.BackColor = Color.Wheat;
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_STATUS.IxREMARKS).StyleNew.BackColor = Color.WhiteSmoke;
                    }
                    else
                    {
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_STATUS.IxRUNNING, fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_STATUS.IxTRACK_FIELD).StyleNew.BackColor = Color.White;
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_STATUS.IxTOT_DD_BOM).StyleNew.BackColor = Color.LightYellow;
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_STATUS.IxPERCENT).StyleNew.BackColor = Color.AntiqueWhite;
                        fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1, (int)ClassLib.TBEIS_DD_STATUS.IxREMARKS).StyleNew.BackColor = Color.White;
                    }
                }

                if (dt_ret.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private DataTable SELECT_DD_STATUS(string[] arg_value)
        {
            MyOraDB.ReDim_Parameter(15);
            MyOraDB.Process_Name = "PKG_EDM_PCC_01.SELECT_DD_STATUS";
                        
            MyOraDB.Parameter_Name[0 ] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[1 ] = "ARG_SEASON_TO";
            MyOraDB.Parameter_Name[2 ] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[3 ] = "ARG_P_FACTORY";
            MyOraDB.Parameter_Name[4 ] = "ARG_OFFSHORE";
            MyOraDB.Parameter_Name[5 ] = "ARG_ALL";
            MyOraDB.Parameter_Name[6 ] = "ARG_LKS";
            MyOraDB.Parameter_Name[7 ] = "ARG_SMM";
            MyOraDB.Parameter_Name[8 ] = "ARG_RLF";
            MyOraDB.Parameter_Name[9 ] = "ARG_ACN";
            MyOraDB.Parameter_Name[10] = "ARG_GTM";
            MyOraDB.Parameter_Name[11] = "ARG_PRE";
            MyOraDB.Parameter_Name[12] = "ARG_RFC";
            MyOraDB.Parameter_Name[13] = "ARG_PRO";
            MyOraDB.Parameter_Name[14] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;            
            MyOraDB.Parameter_Type[14] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0 ] = arg_value[0 ];
            MyOraDB.Parameter_Values[1 ] = arg_value[1 ];
            MyOraDB.Parameter_Values[2 ] = arg_value[2 ];
            MyOraDB.Parameter_Values[3 ] = arg_value[3 ];
            MyOraDB.Parameter_Values[4 ] = arg_value[4 ];
            MyOraDB.Parameter_Values[5 ] = arg_value[5 ];
            MyOraDB.Parameter_Values[6 ] = arg_value[6 ];
            MyOraDB.Parameter_Values[7 ] = arg_value[7 ];
            MyOraDB.Parameter_Values[8 ] = arg_value[8 ];
            MyOraDB.Parameter_Values[9 ] = arg_value[9 ];
            MyOraDB.Parameter_Values[10] = arg_value[10];
            MyOraDB.Parameter_Values[11] = arg_value[11];
            MyOraDB.Parameter_Values[12] = arg_value[12];
            MyOraDB.Parameter_Values[13] = arg_value[13];
            MyOraDB.Parameter_Values[14] = "";
            
            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }

        private void Display_DD_Status_Chart()
        {
            DataSet vDS = Make_DD_Status_ChartData();
            DataTable vDT_DD_STATUS = vDS.Tables[0];            

            #region Category
            chart_main.Data.Series = vDT_DD_STATUS.Columns.Count;
            chart_main.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("X_LABLE", ChartFX.WinForms.FieldUsage.Label));

            for (int i = 1; i < vDT_DD_STATUS.Columns.Count; i++)
            {
                chart_main.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap(vDT_DD_STATUS.Columns[i].ColumnName.ToString(), ChartFX.WinForms.FieldUsage.Value));
            }

            chart_main.DataSource = vDT_DD_STATUS;

            chart_main.View3D.Enabled = false;
            chart_main.ToolTipFormat = "%v";

            chart_main.Font = new System.Drawing.Font("Verdana", 7F, FontStyle.Bold);
            chart_main.LegendBox.Font = new System.Drawing.Font("Verdana", 9F, FontStyle.Bold);
            chart_main.AxisY.Font = new System.Drawing.Font("Verdana", 10F, FontStyle.Bold);
            chart_main.AxisX.Font = new System.Drawing.Font("Verdana", 10F, FontStyle.Bold);
            
            
            chart_main.AllSeries.PointLabels.Visible = true;
            chart_main.AllSeries.Gallery = Gallery.Bar;
            chart_main.AllSeries.FillMode = FillMode.Gradient;
            chart_main.AllSeries.Volume = 30;
            
            chart_main.LegendBox.Visible = true;
            chart_main.LegendBox.Dock = ChartFX.WinForms.DockArea.Right;
                        
            chart_main.AxisY.Step = 0.1;
            chart_main.AxisY.DataFormat.Format = AxisFormat.Percentage;            
            chart_main.AxisY.LabelsFormat.Format = AxisFormat.Percentage;
            chart_main.AxisY.Title.Alignment = StringAlignment.Far;
            chart_main.AxisY.Max = 1;
            
            chart_main.Cursor = Cursors.Default;

            string title = cmb_sesn_from.SelectedText + " - " + cmb_sesn_to.SelectedText + " : Rate by Dev. Factory";            
            TitleDockable t_01 = new TitleDockable(title);
            t_01.Font = new System.Drawing.Font("Verdana", 13F, FontStyle.Bold);
            chart_main.Titles.Add(t_01);            
            #endregion            
        }
        private DataSet Make_DD_Status_ChartData()
        {
            try
            {
                DataTable vDT_DD_STATUS = new DataTable("DD DataTable");
                DataSet vDSChartData = new DataSet("Chart DataSet");
                
                vDT_DD_STATUS.Columns.Add(new DataColumn("X_LABLE"));
                vDT_DD_STATUS.Columns.Add("PCC");
                vDT_DD_STATUS.Columns.Add("QD");
                vDT_DD_STATUS.Columns.Add("VJ");

                #region Data Creation
                double value_pcc      = 0;
                double value_qd       = 0;
                double value_vj       = 0;

                DataTable dt_season = SELECT_DD_SEASON_CHART();

                for (int row = 0; row < dt_season.Rows.Count; row++)
                {
                    string row_season_cd   = dt_season.Rows[row].ItemArray[0].ToString().Trim();
                    string row_season_name = dt_season.Rows[row].ItemArray[1].ToString().Trim();

                    #region Grid
                    for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                    {
                        string curr_season_cd = fgrid_main[i, (int)ClassLib.TBEIS_DD_STATUS.IxSEASON_CD].ToString().Trim();

                        if (row_season_cd.Equals(curr_season_cd))
                        {
                            string factory = fgrid_main[i, (int)ClassLib.TBEIS_DD_STATUS.IxFACTORY].ToString().Trim();

                            if (factory.Equals("DS"))
                            {
                                string value = fgrid_main[i, (int)ClassLib.TBEIS_DD_STATUS.IxPERCENT].ToString().Trim().Replace("%", "");

                                try
                                {
                                    value_pcc += double.Parse(value);
                                }
                                catch
                                {
                                    value_pcc += 0;
                                }
                            }
                            else if (factory.Equals("QD"))
                            {
                                string value = fgrid_main[i, (int)ClassLib.TBEIS_DD_STATUS.IxPERCENT].ToString().Trim().Replace("%", "");

                                try
                                {
                                    value_qd += double.Parse(value);
                                }
                                catch
                                {
                                    value_qd += 0;
                                }
                            }
                            if (factory.Equals("VJ"))
                            {
                                string value = fgrid_main[i, (int)ClassLib.TBEIS_DD_STATUS.IxPERCENT].ToString().Trim().Replace("%", "");

                                try
                                {
                                    value_vj += double.Parse(value);
                                }
                                catch
                                {
                                    value_vj += 0;
                                }
                            }                            
                        }
                    }
                    #endregion

                    if (!row_season_cd.Equals(""))
                    {                        
                        DataRow dr_DD_STATUS = vDT_DD_STATUS.NewRow();

                        object x_label = row_season_name;
                        object PCC = value_pcc * 0.01;
                        object QD = value_qd * 0.01;
                        object VJ = value_vj * 0.01;

                        dr_DD_STATUS["X_LABLE"] = x_label;
                        dr_DD_STATUS["PCC"] = PCC;
                        dr_DD_STATUS["QD"] = QD;
                        dr_DD_STATUS["VJ"] = VJ;

                        vDT_DD_STATUS.Rows.Add(dr_DD_STATUS);

                        value_pcc = 0;
                        value_qd = 0;
                        value_vj = 0;
                    }
                }

                #endregion

                vDSChartData.Tables.AddRange(new DataTable[] { vDT_DD_STATUS });
                return vDSChartData;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Chart Data Creation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private DataTable SELECT_DD_SEASON_CHART()
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = "PKG_EDM_PCC_01.SELECT_DD_SEASON_CHART";

                MyOraDB.Parameter_Name[0] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = cmb_sesn_from.SelectedValue.ToString();
                MyOraDB.Parameter_Values[1] = cmb_sesn_to.SelectedValue.ToString();
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

        #region Prod. Factory
        private void Display_DD_Prod()
        {
            Set_Chart_Before();

            if (Display_DD_Prod_Grid())
            {
                Display_DD_Prod_Chart();
            }
        }
        private bool Display_DD_Prod_Grid()
        {
            try
            {
                fgrid_prod.Rows.Count = fgrid_prod.Rows.Fixed;

                string[] arg_value = new string[14];
                arg_value[0] = cmb_sesn_from.SelectedValue.ToString().Trim();
                arg_value[1] = cmb_sesn_to.SelectedValue.ToString().Trim();
                arg_value[2] = cmb_factory.SelectedValue.ToString().Trim();
                arg_value[3] = cmb_p_factory.SelectedValue.ToString().Trim();
                arg_value[4] = (chk_offshore.Checked) ? "Y" : "";
                arg_value[5] = (chk_all.Checked) ? "Y" : "N";
                arg_value[6] = (chk_lks.Checked) ? "Y" : "N";
                arg_value[7] = (chk_smm.Checked) ? "Y" : "N";
                arg_value[8] = (chk_rlf.Checked) ? "Y" : "N";
                arg_value[9] = (chk_acn.Checked) ? "Y" : "N";
                arg_value[10] = (chk_gtm.Checked) ? "Y" : "N";
                arg_value[11] = (chk_pre.Checked) ? "Y" : "N";
                arg_value[12] = (chk_rfc.Checked) ? "Y" : "N";
                arg_value[13] = (chk_prod.Checked) ? "Y" : "N";

                DataTable dt_ret = SELECT_DD_PROD_FACTORY(arg_value);

                for (int i = 0; i < dt_ret.Rows.Count; i++)
                {
                    fgrid_prod.Rows.Add();

                    for (int j = fgrid_prod.Cols.Fixed; j < fgrid_prod.Cols.Count; j++)
                    {
                        fgrid_prod[fgrid_prod.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j].ToString().Trim();
                    }

                    string factory = fgrid_prod[fgrid_prod.Rows.Count - 1, (int)ClassLib.TBEIS_DD_PROD_FTY.IxQD_FACTORY].ToString().Trim();

                    if (factory.Equals("Total"))
                    {
                        fgrid_prod.GetCellRange(fgrid_prod.Rows.Count - 1, (int)ClassLib.TBEIS_DD_PROD_FTY.IxSEASON_NAME, fgrid_prod.Rows.Count - 1, (int)ClassLib.TBEIS_DD_PROD_FTY.IxPER_VJ).StyleNew.BackColor = Color.WhiteSmoke;
                    }
                    else
                    {
                        fgrid_prod.GetCellRange(fgrid_prod.Rows.Count - 1, (int)ClassLib.TBEIS_DD_PROD_FTY.IxSEASON_NAME, fgrid_prod.Rows.Count - 1, (int)ClassLib.TBEIS_DD_PROD_FTY.IxPER_VJ).StyleNew.BackColor = Color.White;
                    }
                }

                if (dt_ret.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private DataTable SELECT_DD_PROD_FACTORY(string[] arg_value)
        {
            MyOraDB.ReDim_Parameter(15);
            MyOraDB.Process_Name = "PKG_EDM_PCC_01.SELECT_DD_PROD_FACTORY";

            MyOraDB.Parameter_Name[0 ] = "ARG_SEASON_FROM";
            MyOraDB.Parameter_Name[1 ] = "ARG_SEASON_TO";
            MyOraDB.Parameter_Name[2 ] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[3 ] = "ARG_P_FACTORY";
            MyOraDB.Parameter_Name[4 ] = "ARG_OFFSHORE";
            MyOraDB.Parameter_Name[5 ] = "ARG_ALL";
            MyOraDB.Parameter_Name[6 ] = "ARG_LKS";
            MyOraDB.Parameter_Name[7 ] = "ARG_SMM";
            MyOraDB.Parameter_Name[8 ] = "ARG_RLF";
            MyOraDB.Parameter_Name[9 ] = "ARG_ACN";
            MyOraDB.Parameter_Name[10] = "ARG_GTM";
            MyOraDB.Parameter_Name[11] = "ARG_PRE";
            MyOraDB.Parameter_Name[12] = "ARG_RFC";
            MyOraDB.Parameter_Name[13] = "ARG_PRO";
            MyOraDB.Parameter_Name[14] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9 ] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;            
            MyOraDB.Parameter_Type[14] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0 ] = arg_value[0 ];
            MyOraDB.Parameter_Values[1 ] = arg_value[1 ];
            MyOraDB.Parameter_Values[2 ] = arg_value[2 ];
            MyOraDB.Parameter_Values[3 ] = arg_value[3 ];
            MyOraDB.Parameter_Values[4 ] = arg_value[4 ];
            MyOraDB.Parameter_Values[5 ] = arg_value[5 ];
            MyOraDB.Parameter_Values[6 ] = arg_value[6 ];
            MyOraDB.Parameter_Values[7 ] = arg_value[7 ];
            MyOraDB.Parameter_Values[8 ] = arg_value[8 ];
            MyOraDB.Parameter_Values[9 ] = arg_value[9 ];
            MyOraDB.Parameter_Values[10] = arg_value[10];
            MyOraDB.Parameter_Values[11] = arg_value[11];
            MyOraDB.Parameter_Values[12] = arg_value[12];
            MyOraDB.Parameter_Values[13] = arg_value[13];
            MyOraDB.Parameter_Values[14] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[MyOraDB.Process_Name];
        }

        private void Display_DD_Prod_Chart()
        {
            Set_Chart_Before();
            
            DataSet vDS = Make_DD_Prod_ChartData();
            DataTable vDT_DD_PROD = vDS.Tables[0];

            if (vDT_DD_PROD.Rows.Count > 0)
            {
                chart_prod.DataSource = vDT_DD_PROD;

                chart_prod.Gallery = ChartFX.WinForms.Gallery.Bar;
                chart_prod.AllSeries.BarShape = ChartFX.WinForms.BarShape.Cylinder;
                chart_prod.AllSeries.Stacked = ChartFX.WinForms.Stacked.Normal;
                chart_prod.AllSeries.PointLabels.Visible = true;
                chart_prod.AxisY.DataFormat.Format = AxisFormat.Percentage;
                chart_prod.AxisY.LabelsFormat.Format = AxisFormat.Percentage;
                chart_prod.AxisY.Title.Alignment = StringAlignment.Far;
                chart_prod.AxisY.DataFormat.Format = AxisFormat.Percentage;
                chart_prod.AxisY.Max = 1;
                chart_prod.AxisX.Font = new System.Drawing.Font("Verdana", 7F);
                chart_prod.Series[0].Color = Color.LightBlue;
                chart_prod.Series[1].Color = Color.FloralWhite;
                chart_prod.Font = new System.Drawing.Font("Verdana", 7F);
                chart_prod.View3D.Enabled = false;
                chart_prod.LegendBox.Visible = true;
                chart_prod.Cursor = Cursors.Default;
            }
        }
        private DataSet Make_DD_Prod_ChartData()
        {
            try
            {
                string[] arg_value = new string[14];
                arg_value[0] = cmb_sesn_from.SelectedValue.ToString().Trim();
                arg_value[1] = cmb_sesn_to.SelectedValue.ToString().Trim();
                arg_value[2] = cmb_factory.SelectedValue.ToString().Trim();
                arg_value[3] = cmb_p_factory.SelectedValue.ToString().Trim();
                arg_value[4] = (chk_offshore.Checked) ? "Y" : "";
                arg_value[5] = (chk_all.Checked) ? "Y" : "N";
                arg_value[6] = (chk_lks.Checked) ? "Y" : "N";
                arg_value[7] = (chk_smm.Checked) ? "Y" : "N";
                arg_value[8] = (chk_rlf.Checked) ? "Y" : "N";
                arg_value[9] = (chk_acn.Checked) ? "Y" : "N";
                arg_value[10] = (chk_gtm.Checked) ? "Y" : "N";
                arg_value[11] = (chk_pre.Checked) ? "Y" : "N";
                arg_value[12] = (chk_rfc.Checked) ? "Y" : "N";
                arg_value[13] = (chk_prod.Checked) ? "Y" : "N";

                DataSet vDSChartData = SELECT_DD_PROD_CHART(arg_value);

                return vDSChartData;                
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Chart Data Creation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private DataSet SELECT_DD_PROD_CHART(string [] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(15);
                MyOraDB.Process_Name = "PKG_EDM_PCC_01.SELECT_DD_PROD_CHART";

                MyOraDB.Parameter_Name[0] = "ARG_SEASON_FROM";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_TO";
                MyOraDB.Parameter_Name[2] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[3] = "ARG_P_FACTORY";
                MyOraDB.Parameter_Name[4] = "ARG_OFFSHORE";
                MyOraDB.Parameter_Name[5] = "ARG_ALL";
                MyOraDB.Parameter_Name[6] = "ARG_LKS";
                MyOraDB.Parameter_Name[7] = "ARG_SMM";
                MyOraDB.Parameter_Name[8] = "ARG_RLF";
                MyOraDB.Parameter_Name[9] = "ARG_ACN";
                MyOraDB.Parameter_Name[10] = "ARG_GTM";
                MyOraDB.Parameter_Name[11] = "ARG_PRE";
                MyOraDB.Parameter_Name[12] = "ARG_RFC";
                MyOraDB.Parameter_Name[13] = "ARG_PRO";
                MyOraDB.Parameter_Name[14] = "OUT_CURSOR";

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
                MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[14] = (int)OracleType.Cursor;

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
                MyOraDB.Parameter_Values[12] = arg_value[12];
                MyOraDB.Parameter_Values[13] = arg_value[13];
                MyOraDB.Parameter_Values[14] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        #endregion

        private void Set_Chart_Before()
        {
            if (tab_main.SelectedIndex.Equals(0))
            {
                //main
                _memoryStream.Position = 0;
                chart_main.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
                chart_main.Data.Clear();
                chart_main.BackColor = Color.FloralWhite;
            }
            else
            {
                //prod
                _memoryStream.Position = 0;
                chart_prod.Import(ChartFX.WinForms.FileFormat.Binary, _memoryStream);
                chart_prod.Data.Clear();
                chart_prod.BackColor = Color.MintCream;
            }
        }        
        #endregion

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try            
            {
                string _directory = @"C:\WINDOWS\ReportDesigner";
                DirectoryInfo dr = new DirectoryInfo(_directory);

                if (!dr.Exists)
                {
                    dr.Create();
                }

                string _report_file = Application.StartupPath + @"\Report\DD_Status_Detail" + ".mrd";

                FileInfo fi = new FileInfo(_report_file);

                if (fi.Exists)
                {
                    fi.CopyTo(_directory + @"\DD_Status_Detail.mrd", true);
                }
                else
                {
                    MessageBox.Show("Report File is not exist, Please ask SYSTEM");
                    return;
                }


                string mrd_Filename = Application.StartupPath + @"\Report\DD_Status_Report.mrd";
                
                string[] arg_value = new string[14];
                arg_value[0 ] = cmb_sesn_from.SelectedValue.ToString().Trim();
                arg_value[1 ] = cmb_sesn_to.SelectedValue.ToString().Trim();
                arg_value[2 ] = cmb_factory.SelectedValue.ToString().Trim();
                arg_value[3 ] = cmb_p_factory.SelectedValue.ToString().Trim();
                arg_value[4 ] = (chk_offshore.Checked) ? "Y" : "";
                arg_value[5 ] = (chk_all.Checked) ? "Y" : "N";
                arg_value[6 ] = (chk_lks.Checked) ? "Y" : "N";
                arg_value[7 ] = (chk_smm.Checked) ? "Y" : "N";
                arg_value[8 ] = (chk_rlf.Checked) ? "Y" : "N";
                arg_value[9 ] = (chk_acn.Checked) ? "Y" : "N";
                arg_value[10] = (chk_gtm.Checked) ? "Y" : "N";
                arg_value[11] = (chk_pre.Checked) ? "Y" : "N";
                arg_value[12] = (chk_rfc.Checked) ? "Y" : "N";
                arg_value[13] = (chk_prod.Checked) ? "Y" : "N";

                string sPara = " /rp"  + " [" + arg_value[0 ] + "]" 
                                       + " [" + arg_value[1 ] + "]" 
                                       + " [" + arg_value[2 ] + "]" 
                                       + " [" + arg_value[3 ] + "]"
                                       + " [" + arg_value[4 ] + "]" 
                                       + " [" + arg_value[5 ] + "]" 
                                       + " [" + arg_value[6 ] + "]" 
                                       + " [" + arg_value[7 ] + "]"
                                       + " [" + arg_value[8 ] + "]" 
                                       + " [" + arg_value[9 ] + "]" 
                                       + " [" + arg_value[10] + "]" 
                                       + " [" + arg_value[11] + "]"
                                       + " [" + arg_value[12] + "]" 
                                       + " [" + arg_value[13] + "]";
                                      

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

        #region CheckBox Event
        private void chk_all_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                if (chk_all.Checked)
                {
                    chk_lks.Checked = false;
                    chk_smm.Checked = false;
                    chk_rlf.Checked = false;
                    chk_acn.Checked = false;
                    chk_gtm.Checked = false;
                    chk_pre.Checked = false;
                    chk_rfc.Checked = false;
                    chk_prod.Checked = false;
                }
                else
                {
                    if (!chk_lks.Checked && !chk_smm.Checked && !chk_rlf.Checked && !chk_acn.Checked && !chk_gtm.Checked && !chk_pre.Checked && !chk_rfc.Checked && !chk_prod.Checked)
                    {
                        chk_all.Checked = true;
                    }
                }
            }
            catch
            {
 
            }
        }

        private void chk_lks_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;
                
                CheckBox_Event();
            }
            catch
            {

            }
        }

        private void chk_smm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                CheckBox_Event();
            }
            catch
            {

            }
        }

        private void chk_rlf_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                CheckBox_Event();
            }
            catch
            {

            }
        }

        private void chk_acn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                CheckBox_Event();
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

                CheckBox_Event();
            }
            catch
            {

            }
        }

        private void chk_pre_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                CheckBox_Event();
            }
            catch
            {

            }
        }

        private void chk_rfc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                CheckBox_Event();
            }
            catch
            {

            }
        }

        private void chk_prod_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_flg)
                    return;

                CheckBox_Event();
            }
            catch
            {

            }
        }

        private void CheckBox_Event()
        {
            chk_flg = true;

            if (!chk_lks.Checked && !chk_smm.Checked && !chk_rlf.Checked && !chk_acn.Checked && !chk_gtm.Checked && !chk_pre.Checked && !chk_rfc.Checked && !chk_prod.Checked)
            {
                chk_all.Checked = true;

                chk_lks.Checked = false;
                chk_smm.Checked = false;
                chk_rlf.Checked = false;
                chk_acn.Checked = false;
                chk_gtm.Checked = false;
                chk_pre.Checked = false;
                chk_rfc.Checked = false;
                chk_prod.Checked = false;
            }
            else
            {
                chk_all.Checked = false;
            }

            chk_flg = false;
        }
        #endregion
    }
}



