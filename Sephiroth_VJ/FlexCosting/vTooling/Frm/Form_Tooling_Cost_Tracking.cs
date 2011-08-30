using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.vTooling.Frm
{

    public partial class Form_Tooling_Cost_Tracking : COM.PCHWinForm.Form_Top
    {
        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();
        private FlexCosting.vTooling.Pop.Pop_Tooling_Cost_Tracking_Calc vPop = null;
        #endregion

        #region Constructor
        public Form_Tooling_Cost_Tracking()
        {
            InitializeComponent();
        }
        #endregion 

        #region Form Loading
        private void Form_Tooling_Cost_Tracking_Load(object sender, EventArgs e)
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
            this.Text = "CS Tooling Monthly Tracking";
            this.lbl_MainTitle.Text = "CS Tooling Monthly Tracking";
            ClassLib.ComFunction.SetLangDic(this);

            Init_Grid();
            Init_Control();
        }

        private void Init_Grid()
        {
            fgrid_tooling.Set_Grid("SFX_CBD_TOOL_COST_TRACKING", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_tooling.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_tooling.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_tooling.Set_Action_Image(img_Action);
            fgrid_tooling.ExtendLastCol = false;
            fgrid_tooling.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            fgrid_tooling.Font = new Font(fgrid_tooling.Font.FontFamily, (float)8.5);
            fgrid_tooling.Tree.Column = (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxCAT_NAME;
        }

        private void Init_Control()
        {
            DataTable vDT = ClassLib.ComFunction.Select_Prod_Factory_List_Cost();
            COM.ComCtl.Set_ComboList(vDT, cmb_Factory, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
            cmb_Factory.SelectedIndex = 0;
            vDT.Dispose();

            ClassLib.ComFunction_Cost comFnc = new ClassLib.ComFunction_Cost();

            // Season
            vDT = comFnc.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_month_from, 0, 1, true, false);
            COM.ComCtl.Set_ComboList(vDT, cmb_month_to, 0, 1, true, false);

            string sCurSeaMon = Math.Truncate((double)DateTime.Now.AddYears(1).Month / 4) + 1 + "";
            string sCurSea = "SP";
            if (sCurSeaMon.Equals("1"))
                sCurSea = "SP";
            else if (sCurSeaMon.Equals("2"))
                sCurSea = "SU";
            else if (sCurSeaMon.Equals("3"))
                sCurSea = "FA";
            else
                sCurSea = "HO";
            cmb_month_from.SelectedValue = System.DateTime.Now.Year.ToString() + "0" + sCurSeaMon;
            cmb_month_to.SelectedValue = System.DateTime.Now.Year.ToString() + "0" + sCurSeaMon;

            vDT.Dispose();

            tbtn_New.Enabled     = true;
            tbtn_Search.Enabled  = true;
            tbtn_Save.Enabled    = true;
            tbtn_Delete.Enabled  = false;
            tbtn_Print.Enabled   = true;
            tbtn_Confirm.Enabled = false;
            tbtn_Create.Enabled  = false;            
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
            catch (Exception ex)
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

            fgrid_tooling.Rows.Count = fgrid_tooling.Rows.Fixed;

            string[] arg_value = new string[4];
            arg_value[0] = cmb_Factory.SelectedValue.ToString();
            arg_value[1] = cmb_month_from.SelectedValue.ToString();
            arg_value[2] = cmb_month_to.SelectedValue.ToString();
            arg_value[3] = txt_style_cd.Text.Trim();


            DataTable dt = SELECT_SFX_CBD_TRACKING(arg_value);

            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                C1.Win.C1FlexGrid.Row vNewRow = fgrid_tooling.Rows.Add();
                int row = fgrid_tooling.Rows.Count - 1;
                for (int j = fgrid_tooling.Cols.Fixed; j < fgrid_tooling.Cols.Count; j++)
                {
                    fgrid_tooling[fgrid_tooling.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString().Trim();
                }

                fgrid_tooling.Rows[row].IsNode = true;
                fgrid_tooling.Rows[row].Node.Level = Convert.ToInt32(fgrid_tooling[row, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxLEVEL].ToString());
                fgrid_tooling.GetCellRange(row, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxDIV, row, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxCHARGE).StyleNew.BackColor = Color.White;
                fgrid_tooling.GetCellRange(row, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxMODEL, row, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxCOMMENTS).StyleNew.BackColor = Color.LightYellow;

                string sStatus = fgrid_tooling[row, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxSTATUS].ToString();
                if (sStatus.Equals("Y"))
                {
                    fgrid_tooling.GetCellRange(row, 0, row, fgrid_tooling.Cols.Count - 1).StyleNew.BackColor = Color.LightGray;
                }
            }

            fgrid_tooling.Tree.Show(0);
        }

        private DataTable SELECT_SFX_CBD_TRACKING(string[] arg_value)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TRACKING";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID_FROM";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_TO";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
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

        #region Print Data
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                Print_Data();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void Print_Data()
        {
            if (fgrid_tooling.Rows.Count.Equals(fgrid_tooling.Rows.Fixed))
                return;            
            
            string[] arg_value = new string[4];

            arg_value[0] = cmb_Factory.SelectedValue.ToString();
            arg_value[1] = cmb_month_from.SelectedValue.ToString();
            arg_value[2] = cmb_month_to.SelectedValue.ToString();
            arg_value[3] = txt_style_cd.Text.Trim();

            string mrd_Filename = Application.StartupPath + @"\\Report\Costing\rd_CBD_Cost_Tracking.mrd";
            string sPara = " /rp " + " [" + arg_value[0] + "]"
                                   + " [" + arg_value[1] + "]"
                                   + " [" + arg_value[2] + "]"
                                   + " [" + arg_value[3] + "]";

            FlexCosting.Report.Form_RdViewer report = new FlexCosting.Report.Form_RdViewer(mrd_Filename, sPara);
            report.ShowDialog();   
        }
        #endregion

        #region Control Event
        private void cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Factory.SelectedIndex < 0)
                    return;

                if (cmb_Factory.SelectedValue == null)
                    return;

            }
            catch
            {

            }
            finally
            {

            }
        }

        private void Set_ComboBox_DPO_ID()
        {
            DataTable vDT = SELECT_DPO_ID(cmb_Factory.SelectedValue.ToString());
            COM.ComCtl.Set_ComboList(vDT, cmb_month_from, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            COM.ComCtl.Set_ComboList(vDT, cmb_month_to, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_month_from.SelectedIndex = 0;
            cmb_month_to.SelectedIndex = 0;
            vDT.Dispose();
        }

        public DataTable SELECT_DPO_ID(string arg_factory)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_DPO_ID";

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

        #region Context Event

        private void ctxt_amort_Click(object sender, EventArgs e)
        {
            try
            {
                //fgrid_tooling.Select(fgrid_tooling.Row, fgrid_tooling.Col); 
                ShowAmortPopup(); 
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Amortization", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void ShowAmortPopup()
        {
            int iCurRow = fgrid_tooling.Row, iCurCol = fgrid_tooling.Col;

            double dForecast = 0, dToolingAmount = 0;

            double.TryParse(fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFORECAST].ToString(), out dForecast);
            double.TryParse(fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxTTL_AMOUNT].ToString(), out dToolingAmount);

            if (dToolingAmount <= 0)
            {
                MessageBox.Show("Tooling total amount is 0");
                fgrid_tooling.Select(iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxTTL_AMOUNT);
                return;
            }

            if (dForecast <= 0)
            {
                MessageBox.Show("Forecast q'ty is 0");
                fgrid_tooling.Select(iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFORECAST);
                return;
            }

            vPop = new FlexCosting.vTooling.Pop.Pop_Tooling_Cost_Tracking_Calc();
            vPop.Disposed += new EventHandler(vPop_Disposed);

            if (fgrid_tooling.Rows[iCurRow].Node.Level == 0)
            {
                vPop.SAmortDiv = "NEW";
            }
            else
            {
                vPop.SAmortDiv = "ADD";
            }

            vPop.SModelName = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxMODEL].ToString();

            vPop.SProdFac = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFACTORY].ToString();
            vPop.SSeasonCode = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxSEASON].ToString();
            vPop.SModelID = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxMODEL_ID].ToString();
            vPop.SOBSType = "FT";
            vPop.SRoundCode = "Y0000";

            vPop.SStartPO = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxSTART_PO].ToString();
            vPop.SEndPO = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxEND_PO].ToString();

            vPop.SStatus = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxSTATUS].ToString();

            vPop.DForecast = dForecast;
            vPop.DToolingAmount = dToolingAmount;

            vPop.TopMost = true;
            vPop.Show();
        }

        //private void ShowAmortPopup()
        //{
        //    int iCurRow = fgrid_tooling.Row, iCurCol = fgrid_tooling.Col;

        //    double dForecast = 0, dToolingAmount = 0;

        //    double.TryParse(fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFORECAST].ToString(), out dForecast);
        //    double.TryParse(fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxTTL_AMOUNT].ToString(), out dToolingAmount);

        //    if (dToolingAmount <= 0)
        //    {
        //        MessageBox.Show("Tooling total amount is 0");
        //        fgrid_tooling.Select(iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxTTL_AMOUNT);
        //        return;
        //    }

        //    if (dForecast <= 0)
        //    {
        //        MessageBox.Show("Forecast q'ty is 0");
        //        fgrid_tooling.Select(iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFORECAST);
        //        return;
        //    }

        //    vPop = new FlexCosting.vTooling.Pop.Pop_Tooling_Cost_Tracking_Calc();
        //    vPop.Disposed += new EventHandler(vPop_Disposed);

        //    if (fgrid_tooling.Rows[iCurRow].Node.Level == 0)
        //    {
        //        vPop.SAmortDiv = "NEW";
        //    }
        //    else
        //    {
        //        vPop.SAmortDiv = "ADD";
        //    }

        //    int[] iSels = fgrid_tooling.Selections;
        //    C1.Win.C1FlexGrid.Row[] vSelectModels = new C1.Win.C1FlexGrid.Row[iSels.Length];
        //    int iIdx = 0;
        //    foreach (int iRow in iSels)
        //    {
        //        if (fgrid_tooling.Rows[iRow].Node.Level == 1)
        //        {
        //            vSelectModels[iIdx++] = fgrid_tooling.Rows[iRow];
        //        }
        //    }

        //    vPop.SProdFac = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFACTORY].ToString();
        //    vPop.SSeasonCode = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxSEASON].ToString();
        //    vPop.SModelID = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxMODEL_ID].ToString();
        //    vPop.SOBSType = "FT";
        //    vPop.SRoundCode = "Y0000";

        //    vPop.SStartPO = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxSTART_PO].ToString();
        //    vPop.SEndPO = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxEND_PO].ToString();

        //    vPop.DForecast = dForecast;
        //    vPop.DToolingAmount = dToolingAmount;

        //    vPop.VSelectModels = vSelectModels;
        //    vPop.TopMost = true;
        //    vPop.Show();
        //}

        void vPop_Disposed(object sender, EventArgs e)
        {
            vPop = null;
        }

        private void ctxt_ShowModel_Click(object sender, EventArgs e)
        {
            fgrid_tooling.Tree.Show(0);
        }

        private void ctxt_ShowStyle_Click(object sender, EventArgs e)
        {
            fgrid_tooling.Tree.Show(0);
        }
        private void ctxt_AddStyle_Click(object sender, EventArgs e)
        {
            try
            {
                if (vPop != null)
                {
                    int iCurRow = fgrid_tooling.Row, iCurCol = fgrid_tooling.Col;

                    string sProdFac = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFACTORY].ToString();
                    string sSeasonCode = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxSEASON].ToString();
                    string sModelID = fgrid_tooling[iCurRow, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxMODEL_ID].ToString();
                    string sOBSType = "FT";
                    string sRoundCode = "Y0000";

                    vPop.SearchStyleByModel(sProdFac, sSeasonCode, sModelID, sOBSType, sRoundCode);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "add style", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        //private void ctxt_AddStyle_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (vPop != null)
        //        {
        //            int iCurRow = fgrid_tooling.Row, iCurCol = fgrid_tooling.Col;

        //            if (fgrid_tooling.Rows[iCurRow].Node.Level == 0)
        //            {
        //                fgrid_tooling.Select(iCurRow, iCurCol, iCurRow + fgrid_tooling.Rows[iCurRow].Node.Children, iCurCol);
        //            }

        //            int[] iSels = fgrid_tooling.Selections;
        //            C1.Win.C1FlexGrid.Row[] vSelectModels = new C1.Win.C1FlexGrid.Row[iSels.Length];
        //            int iIdx = 0;
        //            foreach (int iRow in iSels)
        //            {
        //                if (fgrid_tooling.Rows[iRow].Node.Level == 1)
        //                {
        //                    vSelectModels[iIdx++] = fgrid_tooling.Rows[iRow];
        //                }
        //            }

        //            vPop.VSelectModels = vSelectModels;
        //            vPop.InputStyle();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "add style", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
        //    }
        //}

        private void ctxt_AddTooling_Click(object sender, EventArgs e)
        {
            try
            {
                AddTooling();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Add Tooling", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void AddTooling()
        {
            int iRow = fgrid_tooling.Row;

            C1.Win.C1FlexGrid.Row vRow = fgrid_tooling.Rows.Insert(iRow + 1);
            vRow.Node.Level = 1;

            vRow[0] = "I";
            for (int iCol = 1; iCol < (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFACTORY_V; iCol++)
            {
                vRow[iCol] = fgrid_tooling[iRow, iCol];
            }            
        }

        #endregion

        #region save event

        /// <summary>
        /// Save event 
        /// </summary>
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (ClassLib.ComFunction.User_Message("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            } // end if : save continue? 

            try
            {
                    this.Cursor = Cursors.WaitCursor;
                    if (Save())
                    {
                        COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndSave, this);
                        ClassLib.ComFunction.User_Message("Save complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Display_Data();
                    } // end if : save complete
                    else
                    {
                        COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSave, this);
                        ClassLib.ComFunction.User_Message("Save fail", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } // end else : save fail 
            }
            catch (Exception ex)
            {
                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsDoNotSave, this);
                ClassLib.ComFunction.User_Message(ex.Message, "save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Save logic 
        /// </summary>
        private bool Save()
        {
            // Save logic 
            //if (SAVE_SFX_CBD_TRACKING())
            if (MyOraDB.Save_FlexGird("PKG_SFX_CBD_TOOLING.SAVE_SFX_CBD_TRACKING", fgrid_tooling))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// PKG_SFX_CBD_TOOLING.SAVE_SFX_CBD_TRACKING : Saveing modified data
        /// </summary>
        public bool SAVE_SFX_CBD_TRACKING()
        {
            try
            {

                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SAVE_SFX_CBD_TRACKING";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_NAME";
                MyOraDB.Parameter_Name[3] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[4] = "ARG_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_TOT_COST_USD";
                MyOraDB.Parameter_Name[6] = "ARG_FORECAST";
                MyOraDB.Parameter_Name[7] = "ARG_START_PO";
                MyOraDB.Parameter_Name[8] = "ARG_END_PO";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;

                //04.DATA 정의
                //for (int iRow = fgrid_tooling.Rows.Fixed; 

                //MyOraDB.Parameter_Values[0] = arg_division;
                //MyOraDB.Parameter_Values[1] = arg_factory;
                //MyOraDB.Parameter_Values[2] = arg_season_name;
                //MyOraDB.Parameter_Values[3] = arg_model_id;
                //MyOraDB.Parameter_Values[4] = arg_seq;
                //MyOraDB.Parameter_Values[5] = arg_tot_cost_usd;
                //MyOraDB.Parameter_Values[6] = arg_forecast;
                //MyOraDB.Parameter_Values[7] = arg_start_po;
                //MyOraDB.Parameter_Values[8] = arg_end_po;

                MyOraDB.Add_Modify_Parameter(true);
                if (MyOraDB.Exe_Modify_Procedure() == null)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region grid event 
        
        private void fgrid_tooling_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (vPop != null)
                {
                    ctxt_amort.Enabled = false;
                    ctxt_AddStyle.Enabled = true;
                }
                else
                {
                    ctxt_amort.Enabled = true;
                    ctxt_AddStyle.Enabled = false;
                    ctxt_AddTooling.Enabled = false;

                    string sStatus = fgrid_tooling[fgrid_tooling.Row, (int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxSTATUS].ToString();
                    if (sStatus.Equals("Y"))
                    {
                        ctxt_AddTooling.Enabled = true;
                    }
                    else
                    {
                        ctxt_AddTooling.Enabled = false;
                    }
                }
            }
        }
        private void fgrid_tooling_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                Grid_AterEdit_Event();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Grid_AterEdit_Event()
        {
            fgrid_tooling.Update_Row();
        }

        #endregion
    }
}

