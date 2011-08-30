using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexCosting.vTooling.Pop
{
    struct CBD
    {
        public string sDEV_FAC;
        public string sMOID;
        public string sCBD_ID;
        public string sFOB_TYPE_CD;
        public string sCBD_SEQ;

        public double dORG_FOB;
        public double dNEW_FOB;
        public double dTOOL_SUM_CBD;
        public double dFORECAST;
    }

    public partial class Pop_Tooling_Cost_Tracking_Calc : COM.PCHWinForm.Pop_Large
    {
        #region constructor

        public Pop_Tooling_Cost_Tracking_Calc()
        {
            InitializeComponent();
            Init_Form();
        }

        #endregion


        #region extrn variable 

        private COM.OraDB MyOraDB = new COM.OraDB();
        
        // select rows 
        private C1.Win.C1FlexGrid.Row[] _vSelectModels;

        // model information
        private string sModelName;

        // for search 
        private string _sProdFac, _sSeasonCode, _sModelID, _sOBSType, _sRoundCode, _sStartPO, _sEndPO, _sAmortDiv, _sStatus;

        // for calculation 
        private double _dForecast, _dToolingAmount;

        private Row _vToolingCostRow = null, _vOrderRow = null;
        private Column _vAmortDPOCol = null; 

        // amortization grid 
        private Color[] _vCalcBG = null;
        private Color[] _vCalcFG = null;
        private string[] _sCalcSubject = null;

        private enum TBSFX_CBD_TOOLING_CALC_AMORT
        {
            IxFORECAST = 0,
            IxTOOL_AMT = 1,
            IxTOOL_COST = 2,
            IxBOOKED_ORD_QTY = 3,
            IxBOOKED_ORD_AMT = 4,
            IxUNAMORT_AMT = 5,
            IxFINAL_BOOKED_ORD_QTY = 6,
            IxREVISED_TOOL_COST = 7
        }

        #endregion


        #region event handler


        #region initialize

        private void Pop_Tooling_Cost_Calc_Load(object sender, EventArgs args)
        {
            try
            {
                //InputStyle();
                ClearAll();
                this.Text = SProdFac + " / " + SSeasonCode + " / " + SModelName + " / " + SOBSType + " / " + SStartPO + "~" + SEndPO;
                SearchStyleByModel(SProdFac, SSeasonCode, SModelID, SOBSType, SRoundCode);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "load", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }            
        }

        private void Pop_Tooling_Cost_Tracking_Calc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void Init_Form()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                this.Text = "Tooling amortization";
                this.lbl_MainTitle.Text = "Tooling amortization";
                ClassLib.ComFunction.SetLangDic(this);

                Init_Grid();

                tbtn_Append.Enabled = false;
                tbtn_Insert.Enabled = false;
                tbtn_Delete.Enabled = false;
                tbtn_Create.Enabled = false;
                tbtn_Conform.Enabled = false;
                tbtn_Color.Enabled = false;
            }
            catch (Exception e)
            {
                ClassLib.ComFunction.User_Message(e.Message, "Init", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void Init_Grid()
        {
            fgrid_fob.Set_Grid("SFX_CBD_TOOLING_CALC", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_fob.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_fob.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_fob.Set_Action_Image(img_Action);
            fgrid_fob.ExtendLastCol = false;
            fgrid_fob.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            fgrid_fob.Font = new Font(fgrid_fob.Font.FontFamily, (float)8.5);

            fgrid_calc.Font = new Font(fgrid_calc.Font.FontFamily, (float)8.5);
            fgrid_calc.Styles.EmptyArea.BackColor = Color.White;
            size_main.Grid.Rows[1].Size = 0;
        }

        #endregion


        #region clear

        private void ClearAll()
        {
            fgrid_fob.ClearAll();
            fgrid_fob.Cols.Count = fgrid_fob.Cols.Frozen;

            fgrid_calc.Rows.Count = 0;
            fgrid_calc.Cols.Count = 0;
        }

        #endregion

        #region new

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                New();
                size_main.Grid.Rows[1].Size = 0;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void New()
        {
            if (_vOrderRow != null)
            {
                fgrid_fob.Rows.Remove(_vOrderRow.Index);
                _vOrderRow = null;
            }
            if (_vToolingCostRow != null)
            {
                fgrid_fob.Rows.Remove(_vToolingCostRow.Index);
                _vToolingCostRow = null;
            }
        }

        private void NewAddStyle()
        {
            if (_vOrderRow != null)
            {
                fgrid_fob.Rows.Remove(_vOrderRow.Index);
                _vOrderRow = null;
            }
            if (_vToolingCostRow != null)
            {
                fgrid_fob.Rows.Remove(_vToolingCostRow.Index);
                _vToolingCostRow = null;
            }

            fgrid_fob.Cols.Count = fgrid_fob.Cols.Frozen;

            fgrid_calc.Rows.Count = 0;
            fgrid_calc.Cols.Count = 0;
        }

        #endregion

        #region search

        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                SearchDPO();

                for (int iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
                {
                    object oData = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN];

                    if (oData != null)
                        DisplayData(iRow);
                }

                if (fgrid_fob.Cols.Frozen + 1 < fgrid_fob.Cols.Count && _dForecast > 0 && _dToolingAmount > 0)
                {
                    ToolingAmortization();
                }
                else
                    MessageBox.Show("When amortization tooling cost required more DPO");
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "search", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void DisplaySavedData()
        {
            try
            {

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "display saved data", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        //private void SearchData()
        //{
        //    //DataTable vDT = SELECT_SFX_CBD_TRACKING_DPO(true, false, SProdFac, SSeasonCode, SModelID, SOBSType, SRoundCode, SStartPO, SEndPO);
        //    //if (vDT.TableName.Equals("SUCCESS"))
        //    //{
        //        DataTable vDT = SELECT_SFX_CBD_TRACKING_STYLE(true, false, SProdFac, SSeasonCode, SModelID, SOBSType, SRoundCode);
        //        if (vDT.TableName.Equals("SUCCESS"))
        //        {
        //            DataSet vDS = SELECT_SFX_CBD_TRACKING_CALC(false, true, SProdFac, SSeasonCode, SModelID, SOBSType, SRoundCode);
        //            if (vDS != null)
        //            {
        //                if (InitGrid(vDS.Tables[0], vDS.Tables[1]) == 1)
        //                {
        //                    DisplayData(vDS.Tables[2]);
        //                }
        //            }
        //        }
        //    //}
        //}

        //private void SearchDataVer2()
        //{
        //    foreach (C1.Win.C1FlexGrid.Row vRow in _vSelectModels)
        //    {
        //        SProdFac = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFACTORY].ToString();
        //        SSeasonCode = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxSEASON].ToString();
        //        SModelID = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxMODEL_ID].ToString();
        //        SOBSType = "FT";
        //        SRoundCode = "Y0000";

        //        SStartPO = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxSTART_PO].ToString();
        //        SEndPO = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxEND_PO].ToString();

        //        double dForecast = 0, dToolingAmount = 0;

        //        double.TryParse(vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFORECAST].ToString(), out dForecast);
        //        double.TryParse(vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxTTL_AMOUNT].ToString(), out dToolingAmount);

        //        DForecast += dForecast;
        //        DToolingAmount += dToolingAmount;

        //        string sModelName = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxMODEL].ToString();

        //        DataTable vDT = SELECT_SFX_CBD_TRACKING_STYLE(true, true, SProdFac, SSeasonCode, SModelID, SOBSType, SRoundCode);

        //        if (vDT != null && vDT.Rows.Count > 0)
        //        {
        //            Row vNewRowStyle = fgrid_style.Rows.Add();
        //            vNewRowStyle[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMOID] = sModelName;
        //            vNewRowStyle.StyleNew.BackColor = Color.Black;
        //            vNewRowStyle.StyleNew.ForeColor = Color.White;
        //            vNewRowStyle.IsNode = true;
        //            vNewRowStyle.Node.Level = 0;

        //            for (int iIdx = 0; iIdx < vDT.Rows.Count; iIdx++)
        //            {
        //                Row vNewRow = fgrid_fob.Rows.Add();
        //                vNewRowStyle = fgrid_style.Rows.Add();
        //                for (int iCol = 0; iCol < fgrid_fob.Cols.Frozen; iCol++)
        //                {
        //                    vNewRow[iCol] = vDT.Rows[iIdx][iCol].ToString();

        //                    vNewRowStyle[iCol] = vDT.Rows[iIdx][iCol].ToString();
        //                    vNewRowStyle.StyleNew.BackColor = Color.White;
        //                    vNewRowStyle.IsNode = true;
        //                    vNewRowStyle.Node.Level = 1;
        //                }
        //            } // end for loop display style 
        //        } // end if exist searched data 
        //    }
        //}

        public void SearchStyleByModel(string aSProdFac, string aSSeasonCode, string aSModelID, string aSOBSType, string aSRoundCode)
        {
            NewAddStyle(); 

            DataTable vStyleDT = null;
            if (SStatus.Equals("Y"))
                vStyleDT = SELECT_SFX_CBD_TRACKING_STYLE(true, true, aSProdFac, aSSeasonCode, aSModelID, aSOBSType, aSRoundCode);
            else
                vStyleDT = SELECT_SFX_CBD_TRACKING_STYLE(true, true, aSProdFac, aSSeasonCode, aSModelID, aSOBSType, aSRoundCode);

            // set row 
            for (int iIdx = 0; iIdx < vStyleDT.Rows.Count; iIdx++)
            {
                Row vNewRow = fgrid_fob.Rows.Add();

                for (int iCol = 0; iCol < fgrid_fob.Cols.Frozen; iCol++)
                {
                    vNewRow[iCol] = vStyleDT.Rows[iIdx][iCol].ToString();
                }
            } // end for loop display style 
        }

        private void DeleteStyle(int iRow)
        {
            fgrid_fob.Rows.Remove(iRow);
        }

        //public void InputStyle()
        //{            
        //    NewAddStyle();            

        //    foreach (C1.Win.C1FlexGrid.Row vRow in _vSelectModels)
        //    {
        //        if (vRow != null)
        //        {
        //            bool bExist = false;
        //            string sProdFac1 = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFACTORY].ToString();
        //            string sCategory1 = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxCAT_NAME].ToString();
        //            string sModel1 = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxMODEL].ToString();
        //            string sProdCode1 = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFACTORY_V].ToString();

        //            for (int iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
        //            {
        //                string sProdFac2 = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_FAC].ToString();
        //                string sCategory2 = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxGENDER].ToString();
        //                string sModel2 = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMOID].ToString();
        //                string sProdCode2 = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_CODE].ToString();

        //                if (sProdFac1.Equals(sProdFac2) && sCategory1.Equals(sCategory2) && sModel1.Equals(sModel2) && sProdCode1.Equals(sProdCode2))
        //                {
        //                    MessageBox.Show("Exist color up : " + sProdCode2);
        //                    bExist = true;
        //                    break;
        //                }
        //            }

        //            if (bExist)
        //                continue;

        //            C1.Win.C1FlexGrid.Row vNewRow = fgrid_fob.Rows.Add();
        //            vNewRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN] = true;
        //            vNewRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_FAC] = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFACTORY];
        //            vNewRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxGENDER] = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxCAT_NAME];
        //            vNewRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMOID] = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxMODEL];
        //            vNewRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_CODE] = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFACTORY_V];
        //            vNewRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCFM_FOB] = vRow[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxTTL_AMOUNT];
        //            vNewRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxTTL_AMOUNT] = vRow.Node.GetNode(NodeTypeEnum.Parent).Row[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxTTL_AMOUNT];
        //            vNewRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxFORECAST] = vRow.Node.GetNode(NodeTypeEnum.Parent).Row[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxFORECAST];
        //            vNewRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMODEL_ID] = vRow.Node.GetNode(NodeTypeEnum.Parent).Row[(int)ClassLib.TBSFX_CBD_TOOLING_TRACKING.IxMODEL_ID];
        //        }
        //    }
        //}

        private void SearchDPO()
        {
            string sStyleList = "";
            if (_vToolingCostRow != null)
                fgrid_fob.Rows.Remove(_vToolingCostRow.Index);
            if (_vOrderRow != null)
                fgrid_fob.Rows.Remove(_vOrderRow.Index);
            fgrid_fob.Cols.Count = fgrid_fob.Cols.Frozen;

            for (int iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
            {
                sStyleList += "'" + fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_CODE].ToString() + "', ";
            }
            sStyleList = sStyleList.Length > 10 ? sStyleList.Substring(0, sStyleList.Length - 2) : "";

            DataTable avDPODT = null;
            avDPODT = SELECT_SFX_CBD_TRACKING_DPO(true, true, _sProdFac, _sOBSType, _sStartPO, _sEndPO, sStyleList);

            // dpo qty row 
            _vToolingCostRow = fgrid_fob.Rows.Add();
            _vToolingCostRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxGENDER] = "TOOLING COST";
            CellRange vCR = fgrid_fob.GetCellRange(_vToolingCostRow.Index, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN);
            vCR.StyleNew.DataType = typeof(string);
            _vToolingCostRow.StyleNew.BackColor = Color.LightGray;
            _vToolingCostRow.AllowEditing = false;

            // dpo qty row 
            _vOrderRow = fgrid_fob.Rows.Add();
            if (avDPODT.Rows.Count > 1)
            {
                _vOrderRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxGENDER] = avDPODT.Rows[0]["season"].ToString();
            }
            vCR = fgrid_fob.GetCellRange(_vOrderRow.Index, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN);
            vCR.StyleNew.DataType = typeof(string);
            _vOrderRow.StyleNew.BackColor = Color.LightGreen;
            _vOrderRow.AllowEditing = false;

            // set column 
            for (int iIdx = 0; iIdx < avDPODT.Rows.Count; iIdx++)
            {
                Column vNewCol = fgrid_fob.Cols.Add();
                vNewCol.DataType = typeof(double);
                vNewCol.Format = "#,##0.##########";
                vNewCol.Caption = avDPODT.Rows[iIdx]["obs_id"].ToString();
                vNewCol.Name = avDPODT.Rows[iIdx]["obs_id"].ToString();
                vNewCol[0] = avDPODT.Rows[iIdx]["obs_id"].ToString();
                vNewCol[1] = avDPODT.Rows[iIdx]["obs_id"].ToString();

                vNewCol[_vOrderRow.Index] = avDPODT.Rows[iIdx]["ord_qty"].ToString();
            } // end for loop display dpo 

            // amortization dpo select 
            _vAmortDPOCol = fgrid_fob.Cols[fgrid_fob.Cols.Count - 1];

            fgrid_calc.Rows.Count = 0;
            fgrid_calc.Cols.Count = 0;
            InitCalcGrid();
        }



        //private int InitGrid(DataTable avDPODT, DataTable avStyleDT)
        //{
        //    int iIdx = 0;

        //    ClearAll();

        //    // set row 
        //    for (iIdx = 0; iIdx < avStyleDT.Rows.Count; iIdx++)
        //    {
        //        Row vNewRow = fgrid_fob.Rows.Add();
        //        for (int iCol = 0; iCol < fgrid_fob.Cols.Frozen; iCol++)
        //        {
        //            vNewRow[iCol] = avStyleDT.Rows[iIdx][iCol].ToString();
        //        }
        //    } // end for loop display style 

        //    // dpo qty row 
        //    _vToolingCostRow = fgrid_fob.Rows.Add();
        //    _vToolingCostRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxGENDER] = "TOOLING COST";
        //    CellRange vCR = fgrid_fob.GetCellRange(_vToolingCostRow.Index, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN);
        //    vCR.StyleNew.DataType = typeof(string); 
        //    _vToolingCostRow.StyleNew.BackColor = Color.LightGray;
        //    _vToolingCostRow.AllowEditing = false;

        //    // dpo qty row 
        //    _vOrderRow = fgrid_fob.Rows.Add();
        //    if (avDPODT.Rows.Count > 1)
        //    {
        //        _vOrderRow[(int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxGENDER] = avDPODT.Rows[0]["season"].ToString();
        //    }
        //    vCR = fgrid_fob.GetCellRange(_vOrderRow.Index, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN);
        //    vCR.StyleNew.DataType = typeof(string); 
        //    _vOrderRow.StyleNew.BackColor = Color.LightGreen;
        //    _vOrderRow.AllowEditing = false;

        //    // set column 
        //    for (iIdx = 0; iIdx < avDPODT.Rows.Count; iIdx++)
        //    {
        //        Column vNewCol = fgrid_fob.Cols.Add();
        //        vNewCol.DataType = typeof(double);
        //        vNewCol.Format = "#,##0.##########"; 
        //        vNewCol.Caption = avDPODT.Rows[iIdx]["obs_id"].ToString();
        //        vNewCol.Name = avDPODT.Rows[iIdx]["obs_id"].ToString();
        //        vNewCol[0] = avDPODT.Rows[iIdx]["obs_id"].ToString();
        //        vNewCol[1] = avDPODT.Rows[iIdx]["obs_id"].ToString();

        //        vNewCol[_vOrderRow.Index] = avDPODT.Rows[iIdx]["ord_qty"].ToString(); 
        //    } // end for loop display dpo 

        //    // amortization dpo select 
        //    _vAmortDPOCol = fgrid_fob.Cols[fgrid_fob.Cols.Count - 1];

        //    InitCalcGrid();

        //    return 1;
        //}

        private void InitCalcGrid()
        {
            _vCalcBG = new Color[] { Color.LightGreen, Color.LightGreen, Color.LightGreen, 
                Color.GreenYellow, Color.GreenYellow, 
                Color.Yellow, Color.Green, Color.Red };

            _vCalcFG = new Color[] { Color.Black, Color.Black, Color.Black, 
                Color.Black, Color.Black, 
                Color.Black, Color.Black, Color.Yellow };

            _sCalcSubject = new string[] { 
                "Forecast", 
                "Tooling amount", 
                "Tooling cost", 
                "Booked order q'ty by previous last PO " + fgrid_fob.Cols[_vAmortDPOCol.Index - 1].Name, 
                "", 
                "Unamortized amount ================>", 
                "Final #PO(" + _vAmortDPOCol.Name + ") booked q'ty ===================> ", 
                "Revised tooling cost per pair ==================>" };

            Column vSubjectCol = fgrid_calc.Cols.Add();
            vSubjectCol.DataType = typeof(string);
            vSubjectCol.Width = 300;

            Column vDataCol = fgrid_calc.Cols.Add();
            vDataCol.DataType = typeof(double);
            vDataCol.Format = "#,##0.##########";
            vDataCol.Width = 100;
            vDataCol.TextAlign = TextAlignEnum.RightCenter;

            for (int iRow = 0; iRow < _sCalcSubject.Length; iRow++)
            {
                Row vNewRow = fgrid_calc.Rows.Add();
                vNewRow[vSubjectCol.Index] = _sCalcSubject[iRow];
                vNewRow.StyleNew.BackColor = _vCalcBG[iRow];
                vNewRow.Style.ForeColor = _vCalcFG[iRow];
                vNewRow.Height = 25;

                vNewRow[vDataCol.Index] = 0;
            }
        }

        private void DisplayData(int aiRow)
        {
            //string sStyleList = "";
            //for (int iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count - 2; iRow++)
            //{
            //    sStyleList += "'" + fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_CODE].ToString() + "', ";
            //}
            //sStyleList = sStyleList.Length > 10 ? sStyleList.Substring(0, sStyleList.Length - 2) : "";

            string sProdFac = fgrid_fob[aiRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_FAC].ToString();
            string sStyleList = fgrid_fob[aiRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_CODE].ToString();

            DataTable vDT = SELECT_SFX_CBD_TRACKING_CALC(true, true, sProdFac, _sOBSType, _sStartPO, _sEndPO, "'" + sStyleList + "'");

            int iFixedRow = fgrid_fob.Rows.Fixed;

            if (vDT != null)
            {
                for (int iIdx = 0; iIdx < vDT.Rows.Count; iIdx++)
                {
                    // datatable key 
                    string sDTDPO = vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxOBS_ID].ToString();
                    string sDTStyle = vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxSTYLE_CD].ToString();

                    // grid key 
                    int iGridStyleRow = -1;

                    string sProdFac1 = vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxPROD_FAC].ToString();
                    string sCategory1 = vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxGENDER].ToString();
                    string sModel1 = vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxMOID].ToString();
                    string sProdCode1 = vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxSTYLE_CD].ToString();

                    for (int iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
                    {
                        string sProdFac2 = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_FAC].ToString();
                        string sCategory2 = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxGENDER].ToString();
                        string sModel2 = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMOID].ToString();
                        string sProdCode2 = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_CODE].ToString();

                        if (sProdFac1.Equals(sProdFac2) && sCategory1.Equals(sCategory2) && sModel1.Equals(sModel2) && sProdCode1.Equals(sProdCode2))
                        {
                            iGridStyleRow = iRow;
                            break;
                        }
                    }

                    Column vCol = fgrid_fob.Cols[sDTDPO];
                    int iGridDPOCol = vCol == null ? -1 : vCol.Index;

                    // bind data 
                    if (iGridStyleRow >= iFixedRow && iGridDPOCol >= fgrid_fob.Cols.Frozen)
                    {
                        CBD vCBD = new CBD();
                        vCBD.sDEV_FAC = vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxDEV_FAC].ToString();
                        vCBD.sMOID = vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxMOID].ToString();
                        vCBD.sCBD_ID = vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxCBD_ID].ToString();
                        vCBD.sFOB_TYPE_CD = vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxFOB_TYPE_CD].ToString();
                        vCBD.sCBD_SEQ = vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxCBD_SEQ].ToString();

                        double dFOB = 0;
                        double.TryParse(vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxFOB].ToString(), out dFOB);
                        vCBD.dORG_FOB = dFOB;
                        vCBD.dNEW_FOB = dFOB;
                        vCBD.dFORECAST = 0;
                        vCBD.dTOOL_SUM_CBD = 0;

                        fgrid_fob[iGridStyleRow, iGridDPOCol] = vDT.Rows[iIdx].ItemArray[(int)ClassLib.TBSFX_CBD_TOOLING_CALC_DATATABLE.IxFOB].ToString();
                        CellRange vCR = fgrid_fob.GetCellRange(iGridStyleRow, iGridDPOCol);
                        vCR.UserData = vCBD;
                    }
                } // end for loop display data  
            }
        }

        /*
                "Forecast", 
                "Tooling amount", 
                "Tooling cost", 
                "Booked order q'ty by previous last PO ${LAST_DPO}", 
                "", 
                "Unamortized amount ================>", 
                "Final #PO(${FINAL_DPO}) booked q'ty ===================> ", 
                "Revised tooling cost per pair ==================>" };
         */

        private void ToolingAmortization()
        {
            size_main.Grid.Rows[1].Size = 200;

            DForecast = DToolingAmount = 0;
            string sModel = "";
            for (int iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
            {
                if (fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMODEL_ID] != null)
                {
                    string sCurModel = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMODEL_ID].ToString();
                    if (!sModel.Equals(sCurModel))
                    {
                        object oForecast = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxFORECAST];
                        string sForecast = oForecast == null ? "0" : oForecast.ToString();
                        double dForecast = 0;
                        double.TryParse(sForecast, out dForecast);

                        DForecast += dForecast;

                        object oTTLAmount = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxTTL_AMOUNT];
                        string sTTLAmount = oTTLAmount == null ? "0" : oTTLAmount.ToString();
                        double dTTLAmount = 0;
                        double.TryParse(sTTLAmount, out dTTLAmount);

                        DToolingAmount += dTTLAmount;
                        sModel = sCurModel;
                    }
                }
            }

            // Forecast, Tooling amount
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxFORECAST, 1] = DForecast;
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxTOOL_AMT, 1] = DToolingAmount;

            // Tooling cost
            double dToolingCost = DToolingAmount / DForecast;
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxTOOL_COST, 1] = Math.Round(dToolingCost, 2);
            for (int iCol = fgrid_fob.Cols.Frozen; iCol < fgrid_fob.Cols.Count; iCol++)
            {
                _vToolingCostRow[iCol] = Math.Round(dToolingCost, 2);
            }

            // Booked order q'ty by previous last PO
            double vBookdedOrdQty = fgrid_fob.Aggregate(AggregateEnum.Sum, fgrid_fob.GetCellRange(_vOrderRow.Index, fgrid_fob.Cols.Frozen, _vOrderRow.Index, _vAmortDPOCol.Index - 1));
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxBOOKED_ORD_QTY, 1] = vBookdedOrdQty;

            // Booked order amount by previous last PO
            double vBookdedOrdAmt = dToolingCost * vBookdedOrdQty;
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxBOOKED_ORD_AMT, 1] = Math.Round(vBookdedOrdAmt, 2);

            // Unamortized amount 
            double dUnamortAmt = DToolingAmount - vBookdedOrdAmt;
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxUNAMORT_AMT, 1] = Math.Round(dUnamortAmt, 2);

            // Final #PO booked q'ty
            double vFinalBookdedOrdQty = fgrid_fob.Aggregate(AggregateEnum.Sum, fgrid_fob.GetCellRange(_vOrderRow.Index, _vAmortDPOCol.Index, _vOrderRow.Index, _vAmortDPOCol.Index));
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxFINAL_BOOKED_ORD_QTY, 1] = vFinalBookdedOrdQty;

            // Revised tooling cost per pair
            double vRevisedToolCost = dUnamortAmt / vFinalBookdedOrdQty;
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxREVISED_TOOL_COST, 1] = Math.Round(vRevisedToolCost, 2);

            _vToolingCostRow[fgrid_fob.Cols.Count - 1] = Math.Round(vRevisedToolCost, 2);
            for (int iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
            {
                object oCBD = fgrid_fob.GetCellRange(iRow, _vAmortDPOCol.Index).UserData;
                if (oCBD != null)
                {
                    CellRange vCR = fgrid_fob.GetCellRange(iRow, _vAmortDPOCol.Index);
                    object oChk = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN];
                    if (oChk != null)
                    {
                        if ((bool)oChk)
                        {
                            CBD vCBD = (CBD)oCBD;
                            //double dFOB = vCBD.dORG_FOB;
                            double dFOB = Convert.ToDouble(fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCFM_FOB].ToString());
                            double dNewFob = dFOB - (dToolingCost) + vRevisedToolCost;
                            vCBD.dNEW_FOB = dNewFob;
                            vCBD.dFORECAST = vFinalBookdedOrdQty;
                            vCBD.dTOOL_SUM_CBD = vRevisedToolCost;

                            vCR.UserData = vCBD;

                            _vAmortDPOCol[iRow] = Math.Round(dNewFob, 2);

                            vCR.StyleNew.ForeColor = Color.Blue;
                            vCR.Style.Font = new Font(_vAmortDPOCol.Style.Font.FontFamily, _vAmortDPOCol.Style.Font.Size, FontStyle.Bold);
                        } // end if : checked is true
                        else
                        {
                            CBD vCBD = (CBD)oCBD;
                            _vAmortDPOCol[iRow] = vCBD.dORG_FOB;

                            vCR.StyleNew.ForeColor = Color.Black;
                            vCR.Style.Font = new Font(_vAmortDPOCol.Style.Font.FontFamily, _vAmortDPOCol.Style.Font.Size, FontStyle.Regular);
                        } // end else : checked is false
                    } // end if : check box is not null 
                    else
                    {
                        CBD vCBD = (CBD)oCBD;
                        _vAmortDPOCol[iRow] = vCBD.dORG_FOB;

                        vCR.StyleNew.ForeColor = Color.Black;
                        vCR.Style.Font = new Font(_vAmortDPOCol.Style.Font.FontFamily, _vAmortDPOCol.Style.Font.Size, FontStyle.Regular);
                    } // end else : check box is null 
                } // end if : input full CBD 
            } // end loop : looping all rows 
        }

        private void AddToolingAmortization()
        {
            size_main.Grid.Rows[1].Size = 200;

            DForecast = DToolingAmount = 0;
            string sModel = "";
            for (int iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
            {
                if (fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMODEL_ID] != null)
                {
                    string sCurModel = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMODEL_ID].ToString();
                    if (!sModel.Equals(sCurModel))
                    {
                        object oForecast = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxFORECAST];
                        string sForecast = oForecast == null ? "0" : oForecast.ToString();
                        double dForecast = 0;
                        double.TryParse(sForecast, out dForecast);

                        DForecast += dForecast;

                        object oTTLAmount = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxTTL_AMOUNT];
                        string sTTLAmount = oTTLAmount == null ? "0" : oTTLAmount.ToString();
                        double dTTLAmount = 0;
                        double.TryParse(sTTLAmount, out dTTLAmount);

                        DToolingAmount += dTTLAmount;
                        sModel = sCurModel;
                    }
                }
            }

            // Forecast, Tooling amount
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxFORECAST, 1] = DForecast;
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxTOOL_AMT, 1] = DToolingAmount;

            // Tooling cost
            double dToolingCost = DToolingAmount / DForecast;
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxTOOL_COST, 1] = Math.Round(dToolingCost, 2);
            for (int iCol = fgrid_fob.Cols.Frozen; iCol < fgrid_fob.Cols.Count; iCol++)
            {
                _vToolingCostRow[iCol] = Math.Round(dToolingCost, 2);
            }

            // Booked order q'ty by previous last PO
            double vBookdedOrdQty = fgrid_fob.Aggregate(AggregateEnum.Sum, fgrid_fob.GetCellRange(_vOrderRow.Index, fgrid_fob.Cols.Frozen, _vOrderRow.Index, _vAmortDPOCol.Index - 1));
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxBOOKED_ORD_QTY, 1] = vBookdedOrdQty;

            // Booked order amount by previous last PO
            double vBookdedOrdAmt = dToolingCost * vBookdedOrdQty;
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxBOOKED_ORD_AMT, 1] = Math.Round(vBookdedOrdAmt, 2);

            // Unamortized amount 
            double dUnamortAmt = DToolingAmount - vBookdedOrdAmt;
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxUNAMORT_AMT, 1] = Math.Round(dUnamortAmt, 2);

            // Final #PO booked q'ty
            double vFinalBookdedOrdQty = fgrid_fob.Aggregate(AggregateEnum.Sum, fgrid_fob.GetCellRange(_vOrderRow.Index, _vAmortDPOCol.Index, _vOrderRow.Index, _vAmortDPOCol.Index));
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxFINAL_BOOKED_ORD_QTY, 1] = vFinalBookdedOrdQty;

            // Revised tooling cost per pair
            double vRevisedToolCost = dUnamortAmt / vFinalBookdedOrdQty;
            fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxREVISED_TOOL_COST, 1] = Math.Round(vRevisedToolCost, 2);

            _vToolingCostRow[fgrid_fob.Cols.Count - 1] = Math.Round(vRevisedToolCost, 2);
            for (int iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
            {
                object oCBD = fgrid_fob.GetCellRange(iRow, _vAmortDPOCol.Index).UserData;
                if (oCBD != null)
                {
                    CellRange vCR = fgrid_fob.GetCellRange(iRow, _vAmortDPOCol.Index);
                    object oChk = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN];
                    if (oChk != null)
                    {
                        if ((bool)oChk)
                        {
                            CBD vCBD = (CBD)oCBD;
                            double dFOB = vCBD.dORG_FOB;
                            double dNewFob = dFOB - (dToolingCost) + vRevisedToolCost;
                            vCBD.dNEW_FOB = dNewFob;
                            vCBD.dFORECAST = vFinalBookdedOrdQty;
                            vCBD.dTOOL_SUM_CBD = vRevisedToolCost;

                            vCR.UserData = vCBD;

                            _vAmortDPOCol[iRow] = Math.Round(dNewFob, 2);

                            vCR.StyleNew.ForeColor = Color.Blue;
                            vCR.Style.Font = new Font(_vAmortDPOCol.Style.Font.FontFamily, _vAmortDPOCol.Style.Font.Size, FontStyle.Bold);
                        } // end if : checked is true
                        else
                        {
                            CBD vCBD = (CBD)oCBD;
                            _vAmortDPOCol[iRow] = vCBD.dORG_FOB;

                            vCR.StyleNew.ForeColor = Color.Black;
                            vCR.Style.Font = new Font(_vAmortDPOCol.Style.Font.FontFamily, _vAmortDPOCol.Style.Font.Size, FontStyle.Regular);
                        } // end else : checked is false
                    } // end if : check box is not null 
                    else
                    {
                        CBD vCBD = (CBD)oCBD;
                        _vAmortDPOCol[iRow] = vCBD.dORG_FOB;

                        vCR.StyleNew.ForeColor = Color.Black;
                        vCR.Style.Font = new Font(_vAmortDPOCol.Style.Font.FontFamily, _vAmortDPOCol.Style.Font.Size, FontStyle.Regular);
                    } // end else : check box is null 
                } // end if : input full CBD 
            } // end loop : looping all rows 
        }

        #endregion // end search

        #region save 

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Save();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "save", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Save()
        {
            MyOraDB.Clear_Modify_DataSet();
            if (SAVE_SFX_CBD_TOOL_AMORT_TAIL())
            {
                if (SAVE_SFX_CBD_TOOLING_AMORT())
                {
                    if (MyOraDB.Exe_Modify_Procedure() != null)
                    {
                        MessageBox.Show("Save complete");
                    } // end if : end save 
                    else
                    {
                        MessageBox.Show("Save fail");
                    } // end else : do not save    
                }
            }    
        }

        #endregion // end Save 

        #region print 
                
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                Print();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void Print()
        {
            string _reportPath = Application.StartupPath + "\\";
            string mrd_Filename = "rd_Tooling_Amortization.mrd";
            string txt_Filename = "rd_Tooling_Amortization.txt";

            string Para = "/rfn [" + _reportPath + txt_Filename + "]  /rv ";

            Para = " /rp ";
            Para += "[" + SProdFac + "] ";
            Para += "[" + sModelName + "]";

            #region 파일만들기

            FileInfo file = new FileInfo(_reportPath + txt_Filename);

            if (!file.Exists)
            {
                file.Create().Close();
            }

            file = null;

            FileStream fs = new FileStream(_reportPath + txt_Filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                for (int i = fgrid_fob.Rows.Fixed; i < fgrid_fob.Rows.Count; i++)
                {
                    for (int j = fgrid_fob.Cols.Frozen; j < fgrid_fob.Cols.Count; j++)
                    {
                        string sData = " ";

                        sData += nullToBlank(fgrid_fob[i, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxGENDER]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_fob[i, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMOID]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_fob[i, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_CODE]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_fob[i, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCFM_FOB]).Trim().Replace("\r\n", "") + "@";

                        sData += nullToBlank(fgrid_fob[0, j]).Trim().Replace("\r\n", "") + "@";
                        sData += nullToBlank(fgrid_fob[i, j]).Trim().Replace("\r\n", "") + "@";

                        sw.WriteLine(sData);
                    }

                    //sData += " BLANK" + "@";                    
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Flush();
                    sw.Close();
                }

                if (fs != null)
                    fs.Close();
            }

            #endregion

            Report.Form_RdViewer report = new Report.Form_RdViewer(
                _reportPath + txt_Filename,
                _reportPath + mrd_Filename,
                Para);
            report.ShowDialog();
        }

        private string nullToBlank(object obj)
        {
            if (obj != null)
            {
                return obj.ToString();
            }
            else
            {
                return "";
            }
        }

        #endregion

        #region delete row

        private void cctxt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int[] iSels = fgrid_fob.Selections;

                for (int iIdx = iSels.Length - 1; iIdx >= 0; iIdx--)
                {
                    DeleteStyle(iSels[iIdx]);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "delete", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        #endregion // end delete row

        #endregion // end event handler


        #region database

        /// <summary>
        /// PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TRACKING_DPO : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_TRACKING_DPO(
            bool arg_clear, bool arg_exec, 
            string arg_factory, string arg_obs_type, string arg_obs_id_from, string arg_obs_id_to, string arg_style_list)
        {
            try
            {
                DataSet vDS;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TRACKING_DPO";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[2] = "ARG_START_PO";
                MyOraDB.Parameter_Name[3] = "ARG_END_PO";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_LIST";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_type;
                MyOraDB.Parameter_Values[2] = arg_obs_id_from;
                MyOraDB.Parameter_Values[3] = arg_obs_id_to;
                MyOraDB.Parameter_Values[4] = arg_style_list;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(arg_clear);

                if (arg_exec)
                {
                    vDS = MyOraDB.Exe_Select_Procedure();
                    if (vDS == null) return null;

                    return vDS.Tables[MyOraDB.Process_Name];
                }
                else
                {
                    return GetReturnMessage("SUCCESS", "1");
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TRACKING_DPO : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_TRACKING_CALC(
            bool arg_clear, bool arg_exec,
            string arg_factory, string arg_obs_type, string arg_obs_id_from, string arg_obs_id_to, string arg_style_list)
        {
            try
            {
                DataSet vDS;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TRACKING_CALC";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[2] = "ARG_START_PO";
                MyOraDB.Parameter_Name[3] = "ARG_END_PO";
                MyOraDB.Parameter_Name[4] = "ARG_STYLE_LIST";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_type;
                MyOraDB.Parameter_Values[2] = arg_obs_id_from;
                MyOraDB.Parameter_Values[3] = arg_obs_id_to;
                MyOraDB.Parameter_Values[4] = arg_style_list;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(arg_clear);

                if (arg_exec)
                {
                    vDS = MyOraDB.Exe_Select_Procedure();
                    if (vDS == null) return null;

                    return vDS.Tables[MyOraDB.Process_Name];
                }
                else
                {
                    return GetReturnMessage("SUCCESS", "1");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TRACKING_STYLE : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_TRACKING_STYLE(bool arg_clear, bool arg_exec, string arg_factory, string arg_season_cd, string arg_model_id, string arg_obs_type, string arg_round_cd)
        {
            try
            {
                DataSet vDS;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TRACKING_STYLE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[2] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_ROUND_CD";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_season_cd;
                MyOraDB.Parameter_Values[2] = arg_model_id;
                MyOraDB.Parameter_Values[3] = arg_obs_type;
                MyOraDB.Parameter_Values[4] = arg_round_cd;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(arg_clear);
                if (arg_exec)
                {
                    vDS = MyOraDB.Exe_Select_Procedure();
                    if (vDS == null) return null;

                    return vDS.Tables[MyOraDB.Process_Name];
                }
                else
                {
                    return GetReturnMessage("SUCCESS", "1");
                }  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        ///// <summary>
        ///// PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TRACKING_CALC : 
        ///// </summary>
        ///// <returns>DataTable</returns>
        //public DataSet SELECT_SFX_CBD_TRACKING_CALC(bool arg_clear, bool arg_exec, string arg_factory, string arg_season_cd, string arg_model_id, string arg_obs_type, string arg_round_cd)
        //{
        //    try
        //    {
        //        DataSet vDS;

        //        MyOraDB.ReDim_Parameter(6);

        //        //01.PROCEDURE명
        //        MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SELECT_SFX_CBD_TRACKING_CALC";

        //        //02.ARGURMENT 명
        //        MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
        //        MyOraDB.Parameter_Name[1] = "ARG_SEASON_CD";
        //        MyOraDB.Parameter_Name[2] = "ARG_MODEL_ID";
        //        MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
        //        MyOraDB.Parameter_Name[4] = "ARG_ROUND_CD";
        //        MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

        //        //03.DATA TYPE 정의
        //        MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

        //        //04.DATA 정의
        //        MyOraDB.Parameter_Values[0] = arg_factory;
        //        MyOraDB.Parameter_Values[1] = arg_season_cd;
        //        MyOraDB.Parameter_Values[2] = arg_model_id;
        //        MyOraDB.Parameter_Values[3] = arg_obs_type;
        //        MyOraDB.Parameter_Values[4] = arg_round_cd;
        //        MyOraDB.Parameter_Values[5] = "";

        //        MyOraDB.Add_Select_Parameter(arg_clear);
        //        if (arg_exec)
        //        {
        //            vDS = MyOraDB.Exe_Select_Procedure();
        //            if (vDS == null) return null;

        //            return vDS;
        //        }

        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        private DataTable GetReturnMessage(string arg_TName, string arg_RtnMsg)
        {
            DataTable vDT = new DataTable(arg_TName);

            vDT.Columns.Add("RETURN");
            DataRow vDR = vDT.NewRow();
            vDR.ItemArray = new object[] { arg_RtnMsg };
            vDT.Rows.Add(vDR);

            return vDT;
        }


        /// <summary>
        /// PKG_SFX_CBD_MASTER_SAVE_TOOL.SAVE_SFX_CBD_TOOL_AMORT_HEAD : 
        /// </summary>
        //public void SAVE_SFX_CBD_TOOL_AMORT_HEAD()
        //{
        //    try
        //    {

        //        MyOraDB.ReDim_Parameter(17);

        //        //01.PROCEDURE명
        //        MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_SAVE_TOOL.SAVE_SFX_CBD_TOOL_AMORT_HEAD";

        //        //02.ARGURMENT 명
        //        MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
        //        MyOraDB.Parameter_Name[1] = "ARG_PROD_FAC";
        //        MyOraDB.Parameter_Name[2] = "ARG_SEASON_CD";
        //        MyOraDB.Parameter_Name[3] = "ARG_MODEL_ID";
        //        MyOraDB.Parameter_Name[4] = "ARG_FORECAST";
        //        MyOraDB.Parameter_Name[5] = "ARG_TOT_COST_USD";
        //        MyOraDB.Parameter_Name[6] = "ARG_TOOL_COST";
        //        MyOraDB.Parameter_Name[7] = "ARG_LAST_PO";
        //        MyOraDB.Parameter_Name[8] = "ARG_BOOKED_ORD_QTY";
        //        MyOraDB.Parameter_Name[9] = "ARG_BOOKED_ORD_AMT";
        //        MyOraDB.Parameter_Name[10] = "ARG_UNAMORT_AMT";
        //        MyOraDB.Parameter_Name[11] = "ARG_FINAL_PO";
        //        MyOraDB.Parameter_Name[12] = "ARG_BOOKED_FIN_QTY";
        //        MyOraDB.Parameter_Name[13] = "ARG_REV_TOOL_COST";
        //        MyOraDB.Parameter_Name[14] = "ARG_TAR_STYLE_CD";
        //        MyOraDB.Parameter_Name[15] = "ARG_REMARKS";
        //        MyOraDB.Parameter_Name[16] = "ARG_UPD_USER";

        //        //03.DATA TYPE 정의
        //        MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
        //        MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;

        //        //04.DATA 정의
        //                        int iRow = fgrid_fob.Rows.Fixed, iArrLen = 0, iIdx = 0;
        //        for (iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
        //        {
        //            if (fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN] != null)
        //            {
        //                iArrLen++;
        //            }

        //        }

        //        MyOraDB.Parameter_Values = new string[(iArrLen * (fgrid_fob.Cols.Count - fgrid_fob.Cols.Frozen)) * MyOraDB.Parameter_Name.Length];
        //        for (iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
        //        {
        //            if (fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN] != null)
        //            {
        //                string sDiv = fgrid_fob[iRow, 0] == null ? "I" : fgrid_fob[iRow, 0].ToString().Trim();
        //                if (sDiv.Equals("I"))
        //                {
        //                    if (fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMODEL_ID] != null)
        //                    {
        //                        string sCurModel = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMODEL_ID].ToString();
        //                        if (!sModel.Equals(sCurModel))
        //                        {
        //                            /*
        //                                    "Forecast", 
        //                                    "Tooling amount", 
        //                                    "Tooling cost", 
        //                                    "Booked order q'ty by previous last PO ${LAST_DPO}", 
        //                                    "", 
        //                                    "Unamortized amount ================>", 
        //                                    "Final #PO(${FINAL_DPO}) booked q'ty ===================> ", 
        //                                    "Revised tooling cost per pair ==================>" };
        //                             */

        //                            MyOraDB.Parameter_Values[0] = "I";
        //                            MyOraDB.Parameter_Values[1] = arg_prod_fac;
        //                            MyOraDB.Parameter_Values[2] = arg_season_cd;
        //                            MyOraDB.Parameter_Values[3] = arg_model_id;
        //                            MyOraDB.Parameter_Values[4] = arg_forecast;
        //                            MyOraDB.Parameter_Values[5] = arg_tot_cost_usd;
        //                            MyOraDB.Parameter_Values[6] = arg_tool_cost;
        //                            MyOraDB.Parameter_Values[7] = arg_last_po;
        //                            MyOraDB.Parameter_Values[8] = fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxBOOKED_ORD_QTY, 1].ToString();
        //                            MyOraDB.Parameter_Values[9] = fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxBOOKED_ORD_AMT, 1].ToString();
        //                            MyOraDB.Parameter_Values[10] = fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxUNAMORT_AMT, 1].ToString();
        //                            MyOraDB.Parameter_Values[11] = arg_final_po;
        //                            MyOraDB.Parameter_Values[12] = fgrid_calc[(int)TBSFX_CBD_TOOLING_CALC_AMORT.IxFINAL_BOOKED_ORD_QTY, 1].ToString();
        //                            MyOraDB.Parameter_Values[13] = arg_rev_tool_cost;
        //                            MyOraDB.Parameter_Values[14] = arg_tar_style_cd;
        //                            MyOraDB.Parameter_Values[15] = arg_remarks;
        //                            MyOraDB.Parameter_Values[16] = arg_upd_user;
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        MyOraDB.Add_Modify_Parameter(true);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        /// <summary>
        /// PKG_SFX_CBD_MASTER_SAVE_TOOL.SAVE_SFX_CBD_TOOL_AMORT_TAIL : 
        /// </summary>
        public bool SAVE_SFX_CBD_TOOL_AMORT_TAIL()
        {
            try
            {

                MyOraDB.ReDim_Parameter(14);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_SAVE_TOOL.SAVE_SFX_CBD_TOOL_AMORT_TAIL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[2] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[3] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[4] = "ARG_MOID";
                MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[6] = "ARG_GENDER";
                MyOraDB.Parameter_Name[7] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[8] = "ARG_CFM_FOB";
                MyOraDB.Parameter_Name[9] = "ARG_TOT_COST_USD";
                MyOraDB.Parameter_Name[10] = "ARG_FORECAST";
                MyOraDB.Parameter_Name[11] = "ARG_FOB";
                MyOraDB.Parameter_Name[12] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[13] = "ARG_UPD_USER";

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
                MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;

                //04.DATA 정의
                int iRow = fgrid_fob.Rows.Fixed, iArrLen = 0, iIdx = 0;
                for (iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
                {
                    if (fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN] != null)
                    {
                        iArrLen++;
                    }
                }

                MyOraDB.Parameter_Values = new string[(iArrLen * (fgrid_fob.Cols.Count - fgrid_fob.Cols.Frozen)) * MyOraDB.Parameter_Name.Length];
                for (iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
                {
                    if (fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN] != null)
                    {
                        for (int iCol = fgrid_fob.Cols.Frozen; iCol < fgrid_fob.Cols.Count; iCol++)
                        {
                            string sDiv = fgrid_fob[iRow, 0] == null ? "I" : fgrid_fob[iRow, 0].ToString().Trim();
                            if (sDiv.Equals("I"))
                            {
                                MyOraDB.Parameter_Values[iIdx++] = fgrid_fob[iRow, 0] == null ? "I" : fgrid_fob[iRow, 0].ToString();
                                MyOraDB.Parameter_Values[iIdx++] = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_FAC].ToString();
                                MyOraDB.Parameter_Values[iIdx++] = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMOID].ToString().Substring(0, 4);
                                MyOraDB.Parameter_Values[iIdx++] = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMODEL_ID].ToString();
                                MyOraDB.Parameter_Values[iIdx++] = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxMOID].ToString().Replace("-", "");
                                MyOraDB.Parameter_Values[iIdx++] = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxPROD_CODE].ToString().Replace("-", "");
                                MyOraDB.Parameter_Values[iIdx++] = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxGENDER].ToString();
                                MyOraDB.Parameter_Values[iIdx++] = fgrid_fob[0, iCol].ToString();
                                MyOraDB.Parameter_Values[iIdx++] = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCFM_FOB].ToString();
                                MyOraDB.Parameter_Values[iIdx++] = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxTTL_AMOUNT].ToString();
                                MyOraDB.Parameter_Values[iIdx++] = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxFORECAST].ToString();
                                MyOraDB.Parameter_Values[iIdx++] = fgrid_fob[iRow, iCol] == null ? "0" : fgrid_fob[iRow, iCol].ToString();
                                MyOraDB.Parameter_Values[iIdx++] = "";
                                MyOraDB.Parameter_Values[iIdx++] = COM.ComVar.This_User;
                            }
                        }
                    }
                }

                return MyOraDB.Add_Modify_Parameter(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFX_CBD_TOOLING.SAVE_SFX_CBD_TOOLING_AMORT : 
        /// </summary>
        public bool SAVE_SFX_CBD_TOOLING_AMORT()
        {
            try
            {

                MyOraDB.ReDim_Parameter(8);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TOOLING.SAVE_SFX_CBD_TOOLING_AMORT";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[3] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_FORECAST";
                MyOraDB.Parameter_Name[6] = "ARG_NEW_TOOL_SUMM_CBD";
                MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

                //04.DATA 정의
                int iIdx = 0;
                for (int iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
                {
                    object oCBD = fgrid_fob.GetCellRange(iRow, _vAmortDPOCol.Index).UserData;
                    if (oCBD != null)
                    {
                        object oChk = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN];
                        if (oChk != null)
                        {
                            iIdx++;
                        }
                    }
                }

                MyOraDB.Parameter_Values = new string[MyOraDB.Parameter_Name.Length * iIdx];
                iIdx = 0;
                for (int iRow = fgrid_fob.Rows.Fixed; iRow < fgrid_fob.Rows.Count; iRow++)
                {
                    object oCBD = fgrid_fob.GetCellRange(iRow, _vAmortDPOCol.Index).UserData;
                    if (oCBD != null)
                    {
                        object oChk = fgrid_fob[iRow, (int)ClassLib.TBSFX_CBD_TOOLING_CALC.IxCALC_YN];
                        if (oChk != null)
                        {
                            if ((bool)oChk)
                            {
                                // save CBD 
                                CBD vCBD = (CBD)oCBD;
                                MyOraDB.Parameter_Values[iIdx++] = vCBD.sDEV_FAC;
                                MyOraDB.Parameter_Values[iIdx++] = vCBD.sMOID;
                                MyOraDB.Parameter_Values[iIdx++] = vCBD.sCBD_ID;
                                MyOraDB.Parameter_Values[iIdx++] = vCBD.sFOB_TYPE_CD;
                                MyOraDB.Parameter_Values[iIdx++] = vCBD.sCBD_SEQ;
                                MyOraDB.Parameter_Values[iIdx++] = vCBD.dFORECAST.ToString();
                                MyOraDB.Parameter_Values[iIdx++] = vCBD.dTOOL_SUM_CBD.ToString();
                                MyOraDB.Parameter_Values[iIdx++] = COM.ComVar.This_User;
                            } // end if : checked is true 
                        } // end if : check box is not null 
                    } // end if : input full CBD 
                } // end loop : looping all rows 

                return MyOraDB.Add_Modify_Parameter(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion


        #region Properties 

        // for search 
        public string SProdFac
        {
            get { return _sProdFac; }
            set { _sProdFac = value; }
        }

        public string SSeasonCode
        {
            get { return _sSeasonCode; }
            set { _sSeasonCode = value; }
        }

        public string SModelID
        {
            get { return _sModelID; }
            set { _sModelID = value; }
        }

        public string SOBSType
        {
            get { return _sOBSType; }
            set { _sOBSType = value; }
        }

        public string SRoundCode
        {
            get { return _sRoundCode; }
            set { _sRoundCode = value; }
        }

        // for calculation 
        public double DForecast
        {
            get { return _dForecast; }
            set { _dForecast = value; }
        }

        public double DToolingAmount
        {
            get { return _dToolingAmount; }
            set { _dToolingAmount = value; }
        }


        public string SStartPO
        {
            get { return _sStartPO; }
            set { _sStartPO = value; }
        }

        public string SEndPO
        {
            get { return _sEndPO; }
            set { _sEndPO = value; }
        }

        public C1.Win.C1FlexGrid.Row[] VSelectModels
        {
            get { return _vSelectModels; }
            set { _vSelectModels = value; }
        }

        public string SAmortDiv
        {
            get { return _sAmortDiv; }
            set { _sAmortDiv = value; }
        }

        public string SStatus
        {
            get { return _sStatus; }
            set { _sStatus = value; }
        }

        public string SModelName
        {
            get { return sModelName; }
            set { sModelName = value; }
        }

        #endregion


    }
}

