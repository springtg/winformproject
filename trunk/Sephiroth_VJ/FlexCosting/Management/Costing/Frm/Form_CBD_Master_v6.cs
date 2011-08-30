using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Management.Costing.Frm
{
    public partial class Form_CBD_Master_v6 : COM.PCHWinForm.Form_Top
    {
        #region 생성자

        public Form_CBD_Master_v6()
        {
            InitializeComponent();

            _ms_summary = new MemoryStream();
            chart_summary.Export(ChartFX.WinForms.FileFormat.Binary, _ms_summary);
        }

        #endregion

        #region 전역변수

        private COM.OraDB MyOraDB = new COM.OraDB();

        private ClassLib.ComFunction_Cost _ComFnc = new FlexCosting.ClassLib.ComFunction_Cost();
        private Control[] _EditableControls = null;
        private MemoryStream _ms_summary;
        private int _BOMNo = 1;
        private int _OrderBy = 1;
        private string _Division = "I";
        private object[][] _copyRange;

        private Basic.Pop.Pop_Type_And_Search_Part _TypePopPart = new FlexCosting.Basic.Pop.Pop_Type_And_Search_Part();

        #endregion

        #region 이벤트

        #region 폼 이벤트

        private void Form_CBD_Master_v6_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

        private bool _isVisibleDetail = false;
        private void Form_CBD_Master_v6_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (_isVisibleDetail)
                {
                    sizer_Main.Grid.Rows[1].Size = (int)(sizer_Main.Height * 0.50);
                    _isVisibleDetail = false;
                }
                else
                {
                    sizer_Main.Grid.Rows[1].Size = (int)(sizer_Main.Height * 0.20);
                    _isVisibleDetail = true;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (tabControl1.SelectedTab.Name.Equals("tabPage10"))
                {
                    Display5523();
                }
                if (tabControl1.SelectedTab.Name.Equals("tabPage9"))
                {
                    DisplayMEF();
                }
            }      
        }

        #endregion

        #region 툴바 이벤트

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                New();
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
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
                Search();
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (cmb_hDEV_FAC.SelectedValue == null)
                    return;

                this.Cursor = Cursors.WaitCursor;
                if (Save())
                {
                    SearchForRefesh();
                    ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
                }
                else
                {
                    ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
                ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                if (cmb_hDEV_FAC.SelectedValue == null)
                    return;

                this.Cursor = Cursors.WaitCursor;
                if (Delete())
                    ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndDelete, this);
                else
                    ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotDelete, this);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotDelete, this);
                ClassLib.ComFunction.User_Message(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                FlexCosting.Management.Costing.Pop.Pop_CBD_Master_Print vPrintPop = new FlexCosting.Management.Costing.Pop.Pop_CBD_Master_Print("20", this);
                vPrintPop.ShowDialog();

                /*
                if (cmb_hDEV_FAC.SelectedValue == null)
                    return;

                FolderBrowserDialog vFBO = new FolderBrowserDialog();
                if (vFBO.ShowDialog() == DialogResult.OK)
                {
                    string sDevFac = cmb_hDEV_FAC.SelectedValue.ToString();
                    string sMOID = txt_hMOID.Text.Replace("-", "");
                    string sCBDID = txt_hCBD_ID.Text;
                    string sCBDVer = txt_hCBD_VER.Text;
                    string sFobType = cmb_hFOB_TYPE_CD.SelectedValue.ToString();
                    string sSeasonCode = cmb_hSEASON_CD.SelectedValue.ToString();
                    string sPath = vFBO.SelectedPath + "\\";
                    
                    string sSeason = cmb_hSEASON_CD.SelectedText;
                    string sDevName = txt_hMOID.Text;
                    string sModelName = txt_hMODEL_NAME.Text;
                    string sBOMID = txt_hCBD_ID.Text;
                    string sRound = cmb_hROUND_CD.SelectedText;
                    
                    FlexCosting.Management.Costing.Frm.XMLExporter vExp = new FlexCosting.Management.Costing.Frm.XMLExporter(sDevFac, sMOID, sCBDID, sCBDVer, sFobType);

                    // _path, _season, _dev_name, _model_name, _bom_id, _fob_type;
                    vExp.Path = sPath;
                    vExp.Season = sSeason;
                    vExp.Dev_name = sDevName;
                    vExp.Model_name = sModelName;
                    vExp.Bom_id = sBOMID;
                    vExp.Fob_type = sRound;
                    vExp.ExportXML();

                    ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);


                    string[] sKeys = new string[] { sDevFac, sMOID, sCBDID, sCBDVer, sFobType, sSeasonCode };
                    FlexCosting.Management.Costing.Frm.CBDExcel.V_1_220.ExcelExport vExp2 = new FlexCosting.Management.Costing.Frm.CBDExcel.V_1_220.ExcelExport();
                    System.Collections.ArrayList vArr = new System.Collections.ArrayList();
                    vArr.Add(sKeys);
                    vExp2.vKeys = vArr;

                    System.Threading.Thread vTh = new System.Threading.Thread(new System.Threading.ThreadStart(vExp2.OpenFile));
                    vTh.Start();
                }
                */
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
                ClassLib.ComFunction.User_Message(ex.Message, "Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_hDEV_FAC.SelectedValue != null)
                {
                    if (!COM.ComVar.This_Factory.Equals("DS"))
                    {
                        if (!COM.ComVar.This_Factory.Equals(cmb_hDEV_FAC.SelectedValue.ToString()))
                        {
                            return;
                        }
                    }

                    if (cmb_hROUND_CD.SelectedValue.ToString().Equals("Y0000"))
                    {
                        string sProdCode = COM.ComFunction.Empty_TextBox(txt_hPRODUCT_CD, "").Trim().Replace("-", "").Replace("_", "");
                        if (sProdCode.Equals("") || sProdCode.Equals("00"))
                        {
                            txt_hPRODUCT_CD.Focus();
                            MessageBox.Show("Input product code (ex. 309207151)", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (COM.ComFunction.Empty_Combo(cmb_hOBS_ID, "").Trim().Equals(""))
                        {
                            cmb_hOBS_ID.Focus();
                            MessageBox.Show("Select DPO", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    if (ConfirmReady())
                    {
                        ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
                        SearchForRefesh();
                    }
                    else
                    {
                        ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);
                ClassLib.ComFunction.User_Message(ex.Message, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region 그리드 이벤트

        #region Grid Calculation 

        private void fgrid_GridError(object sender, C1.Win.C1FlexGrid.GridErrorEventArgs e)
        {
            COM.FSP vFSP = (sender as COM.FSP);
            if (vFSP.Cols[vFSP.Col].DataType == typeof(System.Double))
            {
                double dResult = Calculation(e.Exception.Message);
                if (dResult != -1)
                {
                    //e.Handled = true;
                    vFSP[e.Row, e.Col] = dResult;

                    if (vFSP.Name.Equals(fgrid_upper.Name))
                        fgrid_upper_AfterEdit(fgrid_upper, new C1.Win.C1FlexGrid.RowColEventArgs(e.Row, e.Col));
                    else if (vFSP.Name.Equals(fgrid_packaging.Name))
                        fgrid_packaging_AfterEdit(fgrid_packaging, new C1.Win.C1FlexGrid.RowColEventArgs(e.Row, e.Col));
                    else if (vFSP.Name.Equals(fgrid_midsole.Name))
                        fgrid_midsole_AfterEdit(fgrid_midsole, new C1.Win.C1FlexGrid.RowColEventArgs(e.Row, e.Col));
                    else if (vFSP.Name.Equals(fgrid_outsole.Name))
                        fgrid_outsole_AfterEdit(fgrid_outsole, new C1.Win.C1FlexGrid.RowColEventArgs(e.Row, e.Col));
                    else if (vFSP.Name.Equals(fgrid_labor.Name))
                        fgrid_labor_AfterEdit(fgrid_labor, new C1.Win.C1FlexGrid.RowColEventArgs(e.Row, e.Col));
                    else if (vFSP.Name.Equals(fgrid_overhead.Name))
                        fgrid_overhead_AfterEdit(fgrid_overhead, new C1.Win.C1FlexGrid.RowColEventArgs(e.Row, e.Col));
                    else if (vFSP.Name.Equals(fgrid_sampMold.Name))
                        fgrid_sampMold_AfterEdit(fgrid_sampMold, new C1.Win.C1FlexGrid.RowColEventArgs(e.Row, e.Col));
                    else if (vFSP.Name.Equals(fgrid_prodMold.Name))
                        fgrid_prodMold_AfterEdit(fgrid_prodMold, new C1.Win.C1FlexGrid.RowColEventArgs(e.Row, e.Col));
                }
            }
        }

        private double Calculation(string sArg)
        {
            try
            {
                int iLIdx = sArg.IndexOf("'", 0) + 1;
                int iRIdx = sArg.LastIndexOf("'");
                string sRealArg = sArg.Substring(iLIdx, iRIdx - iLIdx);

                char[] cArray = sRealArg.ToCharArray();

                string sTempCalc = null;
                string sTempNum = null;
                for (int iIdx = 0; iIdx < cArray.Length; iIdx++)
                {
                    if (cArray[iIdx] == '+' || cArray[iIdx] == '-' || cArray[iIdx] == '*' || cArray[iIdx] == '/')
                    {
                        sTempCalc += cArray[iIdx];
                        sTempNum += "|";
                    }
                    else
                    {
                        sTempNum += cArray[iIdx];
                    }
                }

                char[] cCalcs = sTempCalc.ToCharArray();
                string[] sTempNums = sTempNum.Split(new char[] { '|' }, StringSplitOptions.None);

                double dResult = Convert.ToDouble(sTempNums[0]);
                for (int iCalcIdx = 0, iNumIdx = 1; iCalcIdx < cCalcs.Length; iCalcIdx++)
                {
                    double sSu2 = Convert.ToDouble(sTempNums[iNumIdx++]);

                    switch (cCalcs[iCalcIdx])
                    {
                        case '+':
                            dResult = dResult + sSu2;
                            break;
                        case '-':
                            dResult = dResult - sSu2;
                            break;
                        case '*':
                            dResult = dResult * sSu2;
                            break;
                        case '/':
                            dResult = dResult / sSu2;
                            break;
                    }
                }

                return dResult;
            }
            catch
            {
                // 계산 되지 않는 수식입력
                return -1;
            }
        }

        #endregion

        #region Before ad after edit

        private void fgrid_upper_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {            
            bool bCancel = false;
            int iBaseRow = e.Row, iBaseCol = e.Col;
            foreach (int iRow in fgrid_upper.Selections)
            {
                if (!bCancel) fgrid_upper[iRow, iBaseCol] = fgrid_upper[iBaseRow, iBaseCol];
                e = new C1.Win.C1FlexGrid.RowColEventArgs(iRow, iBaseCol);

                switch (e.Col)
                {
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxPART_NAME:
                        SelectPart("UPPER", sender as COM.FSP, e);
                        break;
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxCURR:
                        SetFXRate(sender as COM.FSP, e.Row, e.Row,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                        fgrid_upper.Update_Row(e.Row);
                        break;
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS:
                        string sCBDClass = fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS] == null ? "" : fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS].ToString();
                        if (sCBDClass.Equals("PC"))
                            fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE] = fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST];
                        else
                            fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE] = 0;
                        fgrid_upper.Update_Row(e.Row);
                        break;
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM:
                        string sFRTTRM = fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM] == null ? "" : fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM].ToString();
                        if (sFRTTRM.Equals("FOB"))
                            fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT] = 3;
                        else
                            fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT] = 0;
                        fgrid_upper.Update_Row(e.Row);
                        break;
                    default:
                        fgrid_upper.Update_Row(e.Row);
                        break;
                }

                //ModifyDetail(fgrid_upper, e.Row, e.Col);
                CalcUpper(e.Row, e.Row);
            }
            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();
        }

        private void fgrid_packaging_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            bool bCancel = false;
            int iBaseRow = e.Row, iBaseCol = e.Col;
            foreach (int iRow in fgrid_packaging.Selections)
            {
                if (!bCancel) fgrid_packaging[iRow, iBaseCol] = fgrid_packaging[iBaseRow, iBaseCol];
                e = new C1.Win.C1FlexGrid.RowColEventArgs(iRow, iBaseCol);
                switch (e.Col)
                {
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxPART_NAME:
                        SelectPart("PACKAGING", sender as COM.FSP, e);
                        break;
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxCURR:
                        SetFXRate(sender as COM.FSP, e.Row, e.Row,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                        fgrid_packaging.Update_Row(e.Row);
                        break;
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM:
                        string sFRTTRM = fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM] == null ? "" : fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM].ToString();
                        if (sFRTTRM.Equals("FOB"))
                            fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT] = 3;
                        else
                            fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT] = 0;
                        fgrid_packaging.Update_Row(e.Row);
                        break;
                    default:
                        fgrid_packaging.Update_Row(e.Row);
                        break;
                }

                //ModifyDetail(fgrid_packaging, e.Row, e.Col);
                CalcPackaging(e.Row, e.Row);
            }
            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();
        }

        private void fgrid_midsole_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            bool bCancel = false;
            int iBaseRow = e.Row, iBaseCol = e.Col;
            foreach (int iRow in fgrid_midsole.Selections)
            {
                if (!bCancel) fgrid_midsole[iRow, iBaseCol] = fgrid_midsole[iBaseRow, iBaseCol];
                e = new C1.Win.C1FlexGrid.RowColEventArgs(iRow, iBaseCol);
                switch (e.Col)
                {
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxPART_NAME:
                        SelectPart("MIDSOLE", sender as COM.FSP, e);
                        break;
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxCURR:
                        SetFXRate(sender as COM.FSP, e.Row, e.Row,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                        fgrid_midsole.Update_Row(e.Row);
                        break;
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM:
                        string sFRTTRM = fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM] == null ? "" : fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM].ToString();
                        if (sFRTTRM.Equals("FOB"))
                            fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT] = 3;
                        else
                            fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT] = 0;
                        fgrid_midsole.Update_Row(e.Row);
                        break;
                    default:
                        fgrid_midsole.Update_Row(e.Row);
                        break;
                }
                
                //ModifyDetail(fgrid_midsole, e.Row, e.Col);
                CalcMidsole(e.Row, e.Row);
            }
            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();
        }

        private void fgrid_outsole_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            bool bCancel = false;
            int iBaseRow = e.Row, iBaseCol = e.Col;
            foreach (int iRow in fgrid_outsole.Selections)
            {
                if (!bCancel) fgrid_outsole[iRow, iBaseCol] = fgrid_outsole[iBaseRow, iBaseCol];
                e = new C1.Win.C1FlexGrid.RowColEventArgs(iRow, iBaseCol);
                switch (e.Col)
                {
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxPART_NAME:
                        SelectPart("OUTSOLE", sender as COM.FSP, e);
                        break;
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxCURR:
                        SetFXRate(sender as COM.FSP, e.Row, e.Row,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                        fgrid_outsole.Update_Row(e.Row);
                        break;
                    case (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM:
                        string sFRTTRM = fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM] == null ? "" : fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM].ToString();
                        if (sFRTTRM.Equals("FOB"))
                            fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT] = 3;
                        else
                            fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT] = 0;
                        fgrid_outsole.Update_Row(e.Row);
                        break;
                    default:
                        fgrid_outsole.Update_Row(e.Row);
                        break;
                }
                
                //ModifyDetail(fgrid_outsole, e.Row, e.Col);
                CalcOutsole(e.Row, e.Row);
            }
            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();
        }

        private void fgrid_labor_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            int iBaseRow = e.Row, iBaseCol = e.Col;
            foreach (int iRow in fgrid_labor.Selections)
            {
                fgrid_labor[iRow, iBaseCol] = fgrid_labor[iBaseRow, iBaseCol];
                e = new C1.Win.C1FlexGrid.RowColEventArgs(iRow, iBaseCol);
                switch (e.Col)
                {
                    case (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCURR:
                        SetFXRate(sender as COM.FSP, e.Row, e.Row,
                            (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL_LB.IxFX_RATE);
                        break;
                    default:
                        fgrid_labor.Update_Row(e.Row);
                        break;
                }
                
                //ModifyDetail(fgrid_labor, e.Row, e.Col);
                CalcLabor(e.Row, e.Row);
            }
            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();
        }

        private void fgrid_overhead_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            int iBaseRow = e.Row, iBaseCol = e.Col;
            foreach (int iRow in fgrid_overhead.Selections)
            {
                fgrid_overhead[iRow, iBaseCol] = fgrid_overhead[iBaseRow, iBaseCol];
                e = new C1.Win.C1FlexGrid.RowColEventArgs(iRow, iBaseCol);
                switch (e.Col)
                {
                    case (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCURR:
                        SetFXRate(sender as COM.FSP, e.Row, e.Row,
                            (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL_OH.IxFX_RATE);
                        break;
                    default:
                        fgrid_overhead.Update_Row(e.Row);
                        break;
                }
                
                //ModifyDetail(fgrid_overhead, e.Row, e.Col);
                CalcOverhead(e.Row, e.Row);
            }
            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();
        }

        private void fgrid_sampMold_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            int iBaseRow = e.Row, iBaseCol = e.Col;
            foreach (int iRow in fgrid_sampMold.Selections)
            {
                fgrid_sampMold[iRow, iBaseCol] = fgrid_sampMold[iBaseRow, iBaseCol];
                e = new C1.Win.C1FlexGrid.RowColEventArgs(iRow, iBaseCol);
                switch (e.Col)
                {
                    case (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCURR:
                        SetFXRate(sender as COM.FSP, e.Row, e.Row,
                            (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxFX_RATE);
                        break;
                    default:
                        fgrid_sampMold.Update_Row(e.Row);
                        break;
                }
                
                //ModifyDetail(fgrid_sampMold, e.Row, e.Col);
                CalcSampMold(e.Row, e.Row);
            }
            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();
        }

        private void fgrid_prodMold_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            int iBaseRow = e.Row, iBaseCol = e.Col;
            foreach (int iRow in fgrid_prodMold.Selections)
            {
                fgrid_prodMold[iRow, iBaseCol] = fgrid_prodMold[iBaseRow, iBaseCol];
                e = new C1.Win.C1FlexGrid.RowColEventArgs(iRow, iBaseCol);
                switch (e.Col)
                {
                    case (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCURR:
                        SetFXRate(sender as COM.FSP, e.Row, e.Row,
                            (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxFX_RATE);
                        break;
                    default:
                        fgrid_prodMold.Update_Row(e.Row);
                        break;
                }
                
                //ModifyDetail(fgrid_prodMold, e.Row, e.Col);
                CalcProdMold(e.Row, e.Row);
            }
            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();
        }


        private void Grid_StartEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            COM.FSP fsp = sender as COM.FSP;
            fsp.Buffer_CellData = fsp[e.Row, e.Col] == null ? "" : fsp[e.Row, e.Col].ToString();
        }

        #endregion

        #region Grid double click

        private void fgrid_upper_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int iCurRow = fgrid_upper.Row;
                DisplayBOMDetailTree(fgrid_upper, iCurRow);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "apply price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_packaging_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (fgrid_packaging.Row >= fgrid_packaging.Rows.Fixed)
                {
                    int iCurRow = fgrid_packaging.Row, iCurCol = fgrid_packaging.Col;
                    if (fgrid_packaging.Rows[iCurRow].Node.Level == 1)
                    {
                        C1.Win.C1FlexGrid.Node vParent = fgrid_packaging.Rows[iCurRow].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent);
                        fgrid_packaging[vParent.Row.Index, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE] = fgrid_packaging[iCurRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE];
                        //ModifyDetail(fgrid_packaging, vParent.Row.Index, vParent.Row.Index);
                        CalcPackaging(vParent.Row.Index, vParent.Row.Index);
                        CalcETCSummary();
                        CalcSummary();
                        CalcSummaryPersent();
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "apply price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_midsole_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int iCurRow = fgrid_midsole.Row;
                DisplayBOMDetailTree(fgrid_midsole, iCurRow);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "apply price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_outsole_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int iCurRow = fgrid_outsole.Row;
                DisplayBOMDetailTree(fgrid_outsole, iCurRow);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "apply price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fgrid_pm_meof_head_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DisplayMEOFSize(fgrid_pm_meof_head, fgrid_pm_meof_size);

                if (fgrid_prodMold.Rows.Count > fgrid_prodMold.Rows.Fixed && fgrid_prodMold.Row >= fgrid_prodMold.Rows.Fixed)
                {
                    if (fgrid_pm_meof_head.Rows.Count > fgrid_pm_meof_head.Rows.Fixed && fgrid_pm_meof_head.Row >= fgrid_pm_meof_head.Rows.Fixed)
                    {
                        int iPMCurRow = fgrid_prodMold.Row;
                        int iPRow = fgrid_pm_meof_head.Rows[fgrid_pm_meof_head.Row].Node.Row.Index;
                        if (fgrid_pm_meof_head.Rows[fgrid_pm_meof_head.Row].Node.Level > 0)
                            iPRow = fgrid_pm_meof_head.Rows[fgrid_pm_meof_head.Row].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent).Row.Index;

                        string sMoldCD = fgrid_pm_meof_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_4.IxMOLD_CD + (iPRow - 1), 2].ToString();
                        string sPIMSeq = fgrid_pm_meof_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_4.IxPIM_SEQ + (iPRow - 1), 2].ToString();

                        fgrid_prodMold[iPMCurRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxMOLD_CD] = sMoldCD;
                        fgrid_prodMold[iPMCurRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxTEMP0] = sPIMSeq;
                        fgrid_prodMold.Update_Row(iPMCurRow);
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "MEF Head double click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Grid selection total

        private void fgrid_upper_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                COM.FSP vFSP = GetActiveGrid();

                if (vFSP != null)
                {
                    if (vFSP.Rows.Count > vFSP.Rows.Fixed)
                    {
                        double vSumData = 0;

                        int[] iSelRows = vFSP.Selections;
                        foreach(int iRow in iSelRows)
                        {
                            if (vFSP.Rows[iRow].Visible)
                            {
                                for (int iCol = vFSP.Selection.c1; iCol <= vFSP.Selection.c2; iCol++)
                                {
                                    vSumData += vFSP.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                                            vFSP.GetCellRange(iRow, iCol, iRow, iCol)
                                        );
                                }
                            }
                        }

                        stbar.Panels[1].Text = vSumData.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Selection total", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        #region 버튼 및 기타 이벤트

        private void cmb_hSEASON_CD_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //SeasonChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Season changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ProCost_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_hDEV_FAC.SelectedValue == null)
                    return;

                FlexCosting.Management.Costing.Pop.Pop_ProCost_Yield_Search vPop = new FlexCosting.Management.Costing.Pop.Pop_ProCost_Yield_Search(this);
                // dev_fac, moid, cbd_id, cbd_ver, fob_type_cd 
                // season, category
                vPop.DevFac = cmb_hDEV_FAC.SelectedValue.ToString();
                vPop.MOID = txt_hMOID.Text.Replace("-", "");
                vPop.CBDID = txt_hCBD_ID.Text;
                vPop.CBDVer = txt_hCBD_SEQ.Text;
                vPop.FOBTypeCD = cmb_hFOB_TYPE_CD.SelectedValue.ToString();
                vPop.SeasonCode = cmb_hSEASON_CD.SelectedValue.ToString();
                vPop.CategoryCode = cmb_hCAT_CD.SelectedValue.ToString();

                vPop.ShowDialog();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Procost", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_hRETAIL_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e == null || e.KeyChar == (char)Keys.Enter)
                {
                    string sRetail = txt_hRETAIL_PRICE.Text.Replace(",", "");
                    double dRetail = 0;

                    if (double.TryParse(sRetail, out dRetail))
                    {

                        if (fgrid_labor.Rows.Count > fgrid_labor.Rows.Fixed && fgrid_overhead.Rows.Count > fgrid_overhead.Rows.Fixed)
                        {
                            string sLabor = txt_hLABOR_SUMM_CBD.Text;
                            string sOverhead = txt_hOVERHEAD_SUMM_CBD.Text;
                            double dLabor = 0, dOverhead = 0;
                            double.TryParse(sLabor, out dLabor);
                            double.TryParse(sOverhead, out dOverhead);

                            if (MessageBox.Show("Current Labor & Overhead is $" + (dLabor + dOverhead) + "\r\nDo you want to update Labor & Overhead?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                UpdateRetail();
                                TextToCurrency(sender as TextBox);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Retail price is not number");
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Retail price", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_hOTHER_ADJUST_KeyUp(object sender, EventArgs e)
        {
            try
            {
                //if (e.KeyCode == Keys.Enter)
                //{
                    txt_hOTHERADJ_SUMM_CBD.Text = txt_hOTHER_ADJUST.Text;

                    CalcETCSummary();
                    CalcSummary();
                    CalcSummaryPersent();
                //}
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "SIZEUP PCT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_hSIZEUP_PCT_KeyUp(object sender, EventArgs e)
        {
            try
            {
                //if (e.KeyCode == Keys.Enter)
                //{
                    //int iRow = 0;

                    txt_hSIZEUP_PCT_KeyPress_Modify(fgrid_upper, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE);
                    txt_hSIZEUP_PCT_KeyPress_Modify(fgrid_packaging, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE);
                    txt_hSIZEUP_PCT_KeyPress_Modify(fgrid_midsole, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE);
                    txt_hSIZEUP_PCT_KeyPress_Modify(fgrid_outsole, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE);

                    CalcETCSummary();
                    CalcSummary();
                    CalcSummaryPersent();
                //}
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "SIZEUP PCT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_hPROFIT_PCT_KeyUp(object sender, EventArgs e)
        {
            try
            {
                //if (e.KeyCode == Keys.Enter)
                //{
                    CalcETCSummary();
                    CalcSummary();
                    CalcSummaryPersent();
                //}
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Profit PCT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_hSIZEUP_PCT_KeyPress_Modify(COM.FSP arg_fsp, int iCol)
        {
            int iRow = 0;
            int iFixedRow = arg_fsp.Rows.Fixed, iRowCount = arg_fsp.Rows.Count;
            object[] oBeforeData = new object[iRowCount];

            // Before Update 
            for (iRow = iFixedRow; iRow < iRowCount; iRow++)
            {
                oBeforeData[iRow] = arg_fsp[iRow, iCol];
            }

            if (arg_fsp.Name.Equals(fgrid_upper.Name))
                CalcUpper(-1, -1);
            if (arg_fsp.Name.Equals(fgrid_packaging.Name))
                CalcPackaging(-1, -1);
            if (arg_fsp.Name.Equals(fgrid_midsole.Name))
                CalcMidsole(-1, -1);
            if (arg_fsp.Name.Equals(fgrid_outsole.Name))
                CalcOutsole(-1, -1);

            // After Update 
            for (iRow = iFixedRow; iRow < iRowCount; iRow++)
            {
                object oTmpData = arg_fsp[iRow, iCol];

                if (oTmpData != oBeforeData[iRow])
                {
                    arg_fsp.Update_Row(iRow);
                }
            }
        }

        private void cmb_region_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Display5523();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Region select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_CopyCBD_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_hDEV_FAC.SelectedValue == null || !_Division.Equals("U"))
                    return;

                FlexCosting.Management.Costing.Pop.Pop_CBD_Master_CopyCBD vPop = new FlexCosting.Management.Costing.Pop.Pop_CBD_Master_CopyCBD();
                vPop.DevFac = cmb_hDEV_FAC.SelectedValue.ToString();
                vPop.ProdFac = cmb_hPROD_FAC.SelectedValue.ToString();
                vPop.MOID = txt_hMOID.Text.Replace("-", "");
                vPop.CBDID = txt_hCBD_ID.Text;
                vPop.CBDVer = txt_hCBD_SEQ.Text;
                vPop.FOBType = cmb_hFOB_TYPE_CD.SelectedValue.ToString();
                vPop.RoundCD = cmb_hROUND_CD.SelectedValue.ToString();
                vPop.Season = cmb_hSEASON_CD.SelectedValue.ToString();

                if (vPop.ShowDialog() == DialogResult.OK)
                {
                    if (ClassLib.ComFunction.User_Message("CBD Copy complete.\r\nDo you want to move copied CBD?", "Copy CBD", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        cmb_hDEV_FAC.SelectedValue = vPop.NewDevFac;
                        txt_hMOID.Text = vPop.NewMOID;
                        txt_hCBD_ID.Text = vPop.NewCBDID;
                        cmb_hFOB_TYPE_CD.SelectedValue = vPop.NewRoundCD;
                        txt_hCBD_SEQ.Text = vPop.NewCBDVer;

                        SearchForRefesh();
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Copy CBD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_CutSignOfDecimal(object sender, EventArgs e)
        {
            TextBox vTB = sender as TextBox;
            string sTxt = vTB.Text.Equals("") ? "0" : vTB.Text;
            vTB.Text = Convert.ToString(Math.Round(Convert.ToDouble(sTxt), 2));
            vTB.Tag = sTxt;
        }

        private void btn_MatAdd(object sender, EventArgs e)
        {
            COM.FSP vFSP = GetActiveGrid();
            C1.Win.C1FlexGrid.Row vNewRow = AddDetail(vFSP, vFSP.Row);
            if (vNewRow != null)
            {
                vFSP.Select(vNewRow.Index, 1);
            }
        }

        private void txt_hSTATUS_TextChanged(object sender, EventArgs e)
        {
            if (txt_hSTATUS.Text.Equals("C"))
            {
                txt_hSTATUS_VALUE.Text = "Confirm";
                txt_hSTATUS_VALUE.BackColor = Color.FromArgb(255, 192, 192);
            }
            else if (txt_hSTATUS.Text.Equals("S"))
            {
                txt_hSTATUS_VALUE.Text = "Save";
                txt_hSTATUS_VALUE.BackColor = Color.FromArgb(192, 255, 192);
            }
            else
            {
                txt_hSTATUS_VALUE.Text = "";
                txt_hSTATUS_VALUE.BackColor = Color.White;
            }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox vTB = sender as TextBox;
            vTB.Text = vTB.Text.Replace(",", "");
        }

        private void txt_hFORECAST_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e == null || e.KeyChar == (Char)Keys.Enter)
                {
                    string sForecast = txt_hFORECAST.Text.Replace(",", "");
                    double dForecast = 0;
                    if (double.TryParse(sForecast, out dForecast))
                    {
                        if (MessageBox.Show("Do you want to update tooling forecast? ( " + txt_hFORECAST.Text + " )", "Foreacat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //txt_hFORECAST.Text = String.Format("{0:#,###}", dForecast);
                            TextToCurrency(sender as TextBox);

                            int iForecastCol = (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxAMORT_PAIRS;
                            for (int iRow = fgrid_sampMold.Rows.Fixed; iRow < fgrid_sampMold.Rows.Count; iRow++)
                            {
                                fgrid_sampMold[iRow, iForecastCol] = dForecast;
                                if (fgrid_sampMold[iRow, 0] == null || fgrid_sampMold[iRow, 0].ToString().Equals(""))
                                {
                                    fgrid_sampMold.Update_Row(iRow);
                                }
                            }

                            for (int iRow = fgrid_prodMold.Rows.Fixed; iRow < fgrid_prodMold.Rows.Count; iRow++)
                            {
                                fgrid_prodMold[iRow, iForecastCol] = dForecast;
                                if (fgrid_prodMold[iRow, 0] == null || fgrid_prodMold[iRow, 0].ToString().Equals(""))
                                {
                                    fgrid_prodMold.Update_Row(iRow);
                                }
                            }

                            CalcSampMold(-1, -1);
                            CalcProdMold(-1, -1);
                            CalcETCSummary();
                            CalcSummary();
                            CalcSummaryPersent();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Forecast q'ty is not number");
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Forecast changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_NumberFormatChange(object sender, EventArgs e)
        {
            try
            {
                TextToCurrency(sender as TextBox);
            }
            catch 
            {
                
            }
        }

        private void btn_FxRateUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_hDEV_FAC.SelectedValue == null || cmb_hSEASON_CD.SelectedValue == null)
                    return;

                // Fxrate update
                string sDevFac = cmb_hDEV_FAC.SelectedValue.ToString();
                string sSeason = cmb_hSEASON_CD.SelectedValue.ToString();
                DataTable vDT = _ComFnc.SELECT_SFX_CBD_M_FXRATE(sDevFac, sSeason);

                if (vDT != null && vDT.Rows.Count > 0)
                {
                    DisplayFXRate(vDT);
                    vDT.Dispose();

                    // Summary 
                    SetFXRate(fgrid_upper, -1, -1,
                        (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                        (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                    SetFXRate(fgrid_packaging, -1, -1,
                        (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                        (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                    SetFXRate(fgrid_midsole, -1, -1,
                        (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                        (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                    SetFXRate(fgrid_outsole, -1, -1,
                        (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                        (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                    SetFXRate(fgrid_labor, -1, -1,
                        (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCURR,
                        (int)ClassLib.TBSFX_CBD_TAIL_LB.IxFX_RATE);
                    SetFXRate(fgrid_overhead, -1, -1,
                        (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCURR,
                        (int)ClassLib.TBSFX_CBD_TAIL_OH.IxFX_RATE);
                    SetFXRate(fgrid_sampMold, -1, -1,
                        (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCURR,
                        (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxFX_RATE);
                    SetFXRate(fgrid_prodMold, -1, -1,
                        (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCURR,
                        (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxFX_RATE);

                    txt_hOTHER_ADJUST_KeyUp(null, null);
                    txt_hSIZEUP_PCT_KeyUp(null, null);

                    CalcUpper(-1, -1);
                    CalcPackaging(-1, -1);
                    CalcMidsole(-1, -1);
                    CalcOutsole(-1, -1);
                    CalcLabor(-1, -1);
                    CalcOverhead(-1, -1);
                    CalcSampMold(-1, -1);
                    CalcProdMold(-1, -1);
                    CalcETCSummary();
                    CalcSummary();
                    CalcSummaryPersent();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "FxRate update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmb_hROUND_CD_SelectedValueChanged(object sender, EventArgs e)
        {
            string sRound = COM.ComFunction.Empty_Combo(cmb_hROUND_CD, "");

            if (sRound.Equals("Y0000"))
            {
                cmb_hOBS_TYPE.SelectedValue = cmb_hOBS_TYPE.Tag == null ? "" : cmb_hOBS_TYPE.Tag;
                cmb_hOBS_ID.SelectedValue = cmb_hOBS_ID.Tag == null ? "" : cmb_hOBS_ID.Tag;
                cmb_hOBS_TYPE.ReadOnly = false;
                cmb_hOBS_ID.ReadOnly = false;
            }
            else
            {
                cmb_hOBS_TYPE.SelectedIndex = -1;
                cmb_hOBS_ID.SelectedIndex = -1;
                cmb_hOBS_ID.ClearItems();
                cmb_hOBS_TYPE.ReadOnly = true;
                cmb_hOBS_ID.ReadOnly = true;
            }
        }

        private void cmb_hOBS_TYPE_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int iSelIdx = -1;
                string sOBSType1 = COM.ComFunction.Empty_Combo(cmb_hOBS_TYPE, "");

                DataTable vDT = GetOBSIDList(sOBSType1, out iSelIdx);
                ClassLib.ComFunction.Set_ComboList(vDT, cmb_hOBS_ID, 0, 1, false, COM.ComVar.ComboList_Visible.Name);

                string sOBSType2 = cmb_hOBS_TYPE.Tag == null ? "" : cmb_hOBS_TYPE.Tag.ToString();
                if (sOBSType1.Equals(sOBSType2))
                {
                    cmb_hOBS_ID.SelectedValue = cmb_hOBS_ID.Tag == null ? "" : cmb_hOBS_ID.Tag;
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "OBSType Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region 컨텍스트 메뉴 이벤트

        #region Upper

        // Upper 
        private void ctxt_UPAdd_Click(object sender, EventArgs e)
        {
            C1.Win.C1FlexGrid.Row vNewRow = AddDetail(fgrid_upper, fgrid_upper.Row);
            if (vNewRow != null)
            {
                fgrid_upper.Select(vNewRow.Index, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME);
            }
        }

        private void ctxt_UPInsert_Click(object sender, EventArgs e)
        {
            if (fgrid_upper.Rows.Count > fgrid_upper.Rows.Fixed && fgrid_upper.Row >= fgrid_upper.Rows.Fixed)
            {
                C1.Win.C1FlexGrid.Row vNewRow = AddDetail(fgrid_upper, fgrid_upper.Row);
                if (vNewRow != null)
                {
                    fgrid_upper.Select(vNewRow.Index, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME);
                }
            }
        }

        private void ctxt_UPDel_Click(object sender, EventArgs e)
        {
            if (fgrid_upper.Rows.Count > fgrid_upper.Rows.Fixed && fgrid_upper.Row >= fgrid_upper.Rows.Fixed)
                DelDetail(fgrid_upper);
        }

        private void ctxt_UPRemove_Click(object sender, EventArgs e)
        {
            if (fgrid_upper.Rows.Count > fgrid_upper.Rows.Fixed && fgrid_upper.Row >= fgrid_upper.Rows.Fixed)
                RemoveDetail(fgrid_upper);
        }

        private void ctxt_UPCancel_Click(object sender, EventArgs e)
        {
            if (fgrid_upper.Rows.Count > fgrid_upper.Rows.Fixed)
                CancelDetail(fgrid_upper);
        }

        private void ctxt_SchMat_Click(object sender, EventArgs e)
        {
            try
            {
                COM.FSP vFSP = GetActiveGrid();

                if (vFSP != null)
                {
                    if (vFSP.Rows.Fixed < vFSP.Rows.Count && vFSP.Row >= vFSP.Rows.Fixed)
                    {
                        SelectMaterial(vFSP);
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select material by item master", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_schRP_Click(object sender, EventArgs e)
        {
            try
            {
                if (fgrid_upper.Row >= fgrid_upper.Rows.Fixed && fgrid_upper.Rows.Count > fgrid_upper.Rows.Fixed)
                {
                    if (fgrid_upper.Rows[fgrid_upper.Row].Node.Level == 0)
                    {
                        if (fgrid_upper[fgrid_upper.Row, (int)ClassLib.TBSFX_CBD_TAIL.IxVEN_CD] != null)
                        {
                            FlexCosting.Management.Costing.Pop.Pop_CBD_Master_Charge vPop = new FlexCosting.Management.Costing.Pop.Pop_CBD_Master_Charge();
                            vPop.CustCode = fgrid_upper[fgrid_upper.Row, (int)ClassLib.TBSFX_CBD_TAIL.IxVEN_CD].ToString();
                            vPop.CustName = fgrid_upper[fgrid_upper.Row, (int)ClassLib.TBSFX_CBD_TAIL.IxVEN_NAME].ToString();

                            if (vPop.ShowDialog() == DialogResult.OK)
                            {
                                double dCurPrice = fgrid_upper.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                                    fgrid_upper.GetCellRange(fgrid_upper.Row, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE, fgrid_upper.Row, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE));

                                dCurPrice = dCurPrice + Convert.ToDouble(COM.ComVar.Parameter_PopUp[0]);
                                fgrid_upper[fgrid_upper.Row, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE] = dCurPrice;

                                string sMatCmt = fgrid_upper[fgrid_upper.Row, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT] == null ? "" : fgrid_upper[fgrid_upper.Row, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT].ToString();
                                fgrid_upper[fgrid_upper.Row, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT] = sMatCmt + COM.ComVar.Parameter_PopUp[1];

                                CalcUpper(fgrid_upper.Row, fgrid_upper.Row);
                                CalcETCSummary();
                                CalcSummary();
                                CalcSummaryPersent();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Select R/P", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ctxt_FindMat_Click(object sender, EventArgs e)
        {
            try
            {
                COM.FSP vFSP = GetActiveGrid();

                if (vFSP != null)
                {
                    FlexCosting.Management.Costing.Pop.Pop_CBD_Master_Find vPop = new FlexCosting.Management.Costing.Pop.Pop_CBD_Master_Find();
                    vPop.TargetGrid = vFSP;
                    vPop.TopMost = true;
                    vPop.Show();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Find material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_SchMatOtherCBD_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_hDEV_FAC.SelectedValue == null)
                    return;

                COM.FSP vFSP = GetActiveGrid();

                FlexCosting.Management.Costing.Pop.Pop_Search_Part_For_Upper vPop = new FlexCosting.Management.Costing.Pop.Pop_Search_Part_For_Upper(this);
                vPop.DEV_FACTORY = cmb_hDEV_FAC.SelectedValue.ToString();
                vPop.PROD_FACTORY = cmb_hPROD_FAC.SelectedValue.ToString();
                vPop.SEASON = cmb_hSEASON_CD.SelectedValue.ToString();
                vPop.FOB_TYPE = cmb_hROUND_CD.SelectedValue.ToString();
                vPop.ShowDialog();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search material by other CBD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_check_Click(object sender, EventArgs e)
        {
            try
            {
                COM.FSP vFSP = GetActiveGrid();

                if (vFSP.Row >= vFSP.Rows.Fixed && vFSP.Rows.Fixed < vFSP.Rows.Count)
                {
                    foreach (int iRow in vFSP.Selections)
                    {
                        int iCol = FindCol(vFSP, "REF");

                        if (iCol >= vFSP.Rows.Fixed)
                        {
                            if (vFSP.Rows[iRow].IsNode)
                            {
                                if (vFSP.Rows[iRow].Node.Level == 0)
                                {
                                    string sCurRef = vFSP[iRow, iCol] == null ? "" : vFSP[iRow, iCol].ToString().Trim();
                                    if (sCurRef.Equals(""))
                                    {
                                        vFSP[iRow, iCol] = "U";
                                        vFSP.Rows[iRow].Style.BackColor = Color.Yellow;
                                    }
                                    else
                                    {
                                        vFSP[iRow, iCol] = "";
                                        vFSP.Rows[iRow].Style.BackColor = Color.White;
                                    }

                                    vFSP.Update_Row(iRow);
                                }
                            }
                            else
                            {
                                string sCurRef = vFSP[iRow, iCol] == null ? "" : vFSP[iRow, iCol].ToString().Trim();
                                if (sCurRef.Equals(""))
                                {
                                    vFSP[iRow, iCol] = "U";
                                    vFSP.Rows[iRow].Style.BackColor = Color.Yellow;
                                }
                                else
                                {
                                    vFSP[iRow, iCol] = "";
                                    vFSP.Rows[iRow].Style.BackColor = Color.White;
                                }

                                vFSP.Update_Row(iRow);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search material by other CBD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Packaging

        // Packaging 
        private void ctxt_PKAdd_Click(object sender, EventArgs e)
        {
            C1.Win.C1FlexGrid.Row vNewRow = AddDetail(fgrid_packaging, fgrid_packaging.Row);
            if (vNewRow != null)
            {
                fgrid_packaging.Select(vNewRow.Index, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME);
            }
        }

        private void ctxt_PKDel_Click(object sender, EventArgs e)
        {
            if (fgrid_packaging.Rows.Count > fgrid_packaging.Rows.Fixed && fgrid_packaging.Row >= fgrid_packaging.Rows.Fixed)
                DelDetail(fgrid_packaging);
        }

        private void ctxt_PKRemove_Click(object sender, EventArgs e)
        {
            if (fgrid_packaging.Rows.Count > fgrid_packaging.Rows.Fixed && fgrid_packaging.Row >= fgrid_packaging.Rows.Fixed)
                RemoveDetail(fgrid_packaging);
        }

        private void ctxt_PKCancel_Click(object sender, EventArgs e)
        {
            if (fgrid_packaging.Rows.Count > fgrid_packaging.Rows.Fixed)
                CancelDetail(fgrid_packaging);
        }

        private void ctxt_GeneralVer_Click(object sender, EventArgs e)
        {
            try
            {
                SearchPKMatByBaseInfo("N");
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "FxRate update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ctxt_SDMVer_Click(object sender, EventArgs e)
        {
            try
            {
                SearchPKMatByBaseInfo("Y");
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "FxRate update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchPKMatByBaseInfo(string sSDMYN)
        {
            if (cmb_hDEV_FAC.SelectedValue == null || cmb_hSEASON_CD.SelectedValue == null || cmb_hGENDER.SelectedValue == null || cmb_hCAT_CD.SelectedValue == null)
                return;

            string sDevFac = cmb_hDEV_FAC.SelectedValue.ToString();
            string sSRNo = txt_hMOID.Text.Replace("-", "");
            string sMOID = txt_hMOID.Text.Replace("-", "");
            string sBOMID = txt_hCBD_ID.Text;
            string sBOMRev = txt_hCBD_SEQ.Text;
            string sNFCD = cmb_hFOB_TYPE_CD.SelectedValue.ToString();
            string sSRFSeq = null;

            string sSeasonCD = cmb_hSEASON_CD.SelectedValue.ToString();
            string sCategoryCD = cmb_hCAT_CD.SelectedValue.ToString();
            string sGenderCD = cmb_hGENDER.SelectedValue.ToString();
            string sModelID = txt_hMODEL_ID.Text;
            string sModelName = txt_hMODEL_NAME.Text;

            _ComFnc.SELECT_SXD_SRF_TAIL_PK(sDevFac, sSRNo, sMOID, sBOMID, sBOMRev, sNFCD, sSRFSeq, sSeasonCD, sCategoryCD, sGenderCD, sSDMYN);

            DataSet vDS = _ComFnc.MyOraDBInstance.Exe_Select_Procedure();
            if (vDS != null && vDS.Tables.Count > 0)
            {
                DataTable vDT = vDS.Tables["PKG_SFX_CBD_MASTER_BOM.SELECT_SXD_SRF_TAIL_PK"];
                if (vDT != null && vDT.Rows.Count > 0)
                {
                    DisplayBOMDetail(vDT, fgrid_packaging, false);
                    CalcPackaging(-1, -1);
                    CalcETCSummary();
                    CalcSummary();
                    CalcSummaryPersent();

                    for (int iRow = fgrid_packaging.Rows.Count - 1, iIdx = vDT.Rows.Count; iIdx > 0; iRow--, iIdx--)
                    {
                        fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxBOM_NO] = "";
                        fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_NO] = "";
                        fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_NO_VIEW] = "";
                    }
                }
            }
        }

        #endregion

        #region Midsole

        // Midsole 
        private void ctxt_MSAdd_Click(object sender, EventArgs e)
        {
            C1.Win.C1FlexGrid.Row vNewRow = AddDetail(fgrid_midsole, fgrid_midsole.Row);
            if (vNewRow != null)
            {
                fgrid_midsole.Select(vNewRow.Index, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME);
            }
        }

        private void ctxt_MSDel_Click(object sender, EventArgs e)
        {
            if (fgrid_midsole.Rows.Count > fgrid_midsole.Rows.Fixed && fgrid_midsole.Row >= fgrid_midsole.Rows.Fixed)
                DelDetail(fgrid_midsole);
        }

        private void ctxt_MSRemove_Click(object sender, EventArgs e)
        {
            if (fgrid_midsole.Rows.Count > fgrid_midsole.Rows.Fixed && fgrid_midsole.Row >= fgrid_midsole.Rows.Fixed)
                RemoveDetail(fgrid_midsole);
        }

        private void ctxt_MSCancel_Click(object sender, EventArgs e)
        {
            if (fgrid_midsole.Rows.Count > fgrid_midsole.Rows.Fixed)
                CancelDetail(fgrid_midsole);
        }

        #endregion

        #region Outsole

        // Outsole 
        private void ctxt_OSAdd_Click(object sender, EventArgs e)
        {
            C1.Win.C1FlexGrid.Row vNewRow = AddDetail(fgrid_outsole, fgrid_outsole.Row);
            if (vNewRow != null)
            {
                fgrid_outsole.Select(vNewRow.Index, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME);
            }
        }

        private void ctxt_OSDel_Click(object sender, EventArgs e)
        {
            if (fgrid_outsole.Rows.Count > fgrid_outsole.Rows.Fixed && fgrid_outsole.Row >= fgrid_outsole.Rows.Fixed)
                DelDetail(fgrid_outsole);
        }

        private void ctxt_OSRemove_Click(object sender, EventArgs e)
        {
            if (fgrid_outsole.Rows.Count > fgrid_outsole.Rows.Fixed && fgrid_outsole.Row >= fgrid_outsole.Rows.Fixed)
                RemoveDetail(fgrid_outsole);
        }

        private void ctxt_OSCancel_Click(object sender, EventArgs e)
        {
            if (fgrid_outsole.Rows.Count > fgrid_outsole.Rows.Fixed)
                CancelDetail(fgrid_outsole);
        }

        #endregion

        #region Labor

        private void ctxt_LBAdd_Click(object sender, EventArgs e)
        {
            AddDetail(fgrid_labor, fgrid_labor.Row);
        }

        private void ctxt_LBDel_Click(object sender, EventArgs e)
        {
            if (fgrid_labor.Rows.Count > fgrid_labor.Rows.Fixed && fgrid_labor.Row >= fgrid_labor.Rows.Fixed)
                DelDetail(fgrid_labor);
        }

        private void ctxt_LBRemove_Click(object sender, EventArgs e)
        {
            if (fgrid_labor.Rows.Count > fgrid_labor.Rows.Fixed && fgrid_labor.Row >= fgrid_labor.Rows.Fixed)
                RemoveDetail(fgrid_labor);
        }

        private void ctxt_LBCancel_Click(object sender, EventArgs e)
        {
            if (fgrid_labor.Rows.Count > fgrid_labor.Rows.Fixed)
                CancelDetail(fgrid_labor);
        }

        #endregion

        #region Overhead

        private void ctxt_OHAdd_Click(object sender, EventArgs e)
        {
            AddDetail(fgrid_overhead, fgrid_overhead.Row);
        }

        private void ctxt_OHDel_Click(object sender, EventArgs e)
        {
            if (fgrid_overhead.Rows.Count > fgrid_overhead.Rows.Fixed && fgrid_overhead.Row >= fgrid_overhead.Rows.Fixed)
                DelDetail(fgrid_overhead);
        }

        private void ctxt_OHRemove_Click(object sender, EventArgs e)
        {
            if (fgrid_overhead.Rows.Count > fgrid_overhead.Rows.Fixed && fgrid_overhead.Row >= fgrid_overhead.Rows.Fixed)
                RemoveDetail(fgrid_overhead);
        }

        private void ctxt_OHCancel_Click(object sender, EventArgs e)
        {
            if (fgrid_overhead.Rows.Count > fgrid_overhead.Rows.Fixed)
                CancelDetail(fgrid_overhead);
        }

        #endregion

        #region Sample Tooling

        private void ctxt_SMAdd_Click(object sender, EventArgs e)
        {
            C1.Win.C1FlexGrid.Row vNewRow = AddDetail(fgrid_sampMold, fgrid_sampMold.Row);
            if (vNewRow != null)
            {
                fgrid_sampMold.Select(vNewRow.Index, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOMPONENT);
            }
        }

        private void ctxt_SMDel_Click(object sender, EventArgs e)
        {
            if (fgrid_sampMold.Rows.Count > fgrid_sampMold.Rows.Fixed && fgrid_sampMold.Row >= fgrid_sampMold.Rows.Fixed)
                DelDetail(fgrid_sampMold);
        }

        private void ctxt_SMRemove_Click(object sender, EventArgs e)
        {
            if (fgrid_sampMold.Rows.Count > fgrid_sampMold.Rows.Fixed && fgrid_sampMold.Row >= fgrid_sampMold.Rows.Fixed)
                RemoveDetail(fgrid_sampMold);
        }

        private void ctxt_SMCancel_Click(object sender, EventArgs e)
        {
            if (fgrid_sampMold.Rows.Count > fgrid_sampMold.Rows.Fixed)
                CancelDetail(fgrid_sampMold);
        }

        #endregion

        #region Production Tooling

        private void ctxt_PMAdd_Click(object sender, EventArgs e)
        {
            C1.Win.C1FlexGrid.Row vNewRow = AddDetail(fgrid_prodMold, fgrid_prodMold.Row);
            if (vNewRow != null)
            {
                fgrid_prodMold.Select(vNewRow.Index, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOMPONENT);
            }
        }

        private void ctxt_PMDel_Click(object sender, EventArgs e)
        {
            if (fgrid_prodMold.Rows.Count > fgrid_prodMold.Rows.Fixed && fgrid_prodMold.Row >= fgrid_prodMold.Rows.Fixed)
                DelDetail(fgrid_prodMold);
        }

        private void ctxt_PMRemove_Click(object sender, EventArgs e)
        {
            if (fgrid_prodMold.Rows.Count > fgrid_prodMold.Rows.Fixed && fgrid_prodMold.Row >= fgrid_prodMold.Rows.Fixed)
                RemoveDetail(fgrid_prodMold);
        }

        private void ctxt_PMCancel_Click(object sender, EventArgs e)
        {
            if (fgrid_prodMold.Rows.Count > fgrid_prodMold.Rows.Fixed)
                CancelDetail(fgrid_prodMold);
        }

        #endregion

        #endregion

        #endregion

        #region 이벤트 처리

        #region Init

        /// <summary>
        /// Inti_Form : Form Load 시 초기화 작업
        /// </summary>
        private void Init_Form()
        {
            try
            {
                //Title
                this.Text = "CBD Create";
                this.lbl_MainTitle.Text = "CBD Create";

                Init_Grid();
                Init_Control();
                Init_Toolbar();
                Init_Chart(chart_summary, _ms_summary);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 그리드 초기화
        /// </summary>
        private void Init_Grid()
        {
            System.Collections.Hashtable Imgmap = new System.Collections.Hashtable();
            Imgmap.Add("I", img_Action.Images[0]);
            Imgmap.Add("D", img_Action.Images[1]);
            Imgmap.Add("U", img_Action.Images[2]);
            Imgmap.Add("R", img_Action.Images[3]);

            fgrid_upper.Set_Grid("SFX_CBD_TAIL_UP", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_upper.Tree.Column = (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME;
            SetGridDesign(fgrid_upper, Imgmap);
            fgrid_upper.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].StyleNew.BackColor = Color.Yellow;
            fgrid_upper.GetCellRange(
                fgrid_upper.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT,
                fgrid_upper.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT).StyleNew.BackColor = Color.OrangeRed;
            fgrid_upper.GetCellRange(
                fgrid_upper.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE,
                fgrid_upper.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE).StyleNew.BackColor = Color.OrangeRed;
            fgrid_upper.GetCellRange(
                fgrid_upper.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE,
                fgrid_upper.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE).StyleNew.BackColor = Color.OrangeRed;
            fgrid_upper.GetCellRange(
                fgrid_upper.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST,
                fgrid_upper.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST).StyleNew.BackColor = Color.OrangeRed;
            fgrid_upper.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].Style.Format = "#,##0.00";


            fgrid_packaging.Set_Grid("SFX_CBD_TAIL_PK", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_packaging.Tree.Column = (int)ClassLib.TBSFX_CBD_TAIL.IxPART_NAME;
            SetGridDesign(fgrid_packaging, Imgmap);
            fgrid_packaging.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT].Visible = false;
            fgrid_packaging.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].StyleNew.BackColor = Color.Yellow;

            fgrid_packaging.GetCellRange(
                fgrid_packaging.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE,
                fgrid_packaging.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE).StyleNew.BackColor = Color.OrangeRed;
            fgrid_packaging.GetCellRange(
                fgrid_packaging.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST,
                fgrid_packaging.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST).StyleNew.BackColor = Color.OrangeRed;
            fgrid_packaging.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].Style.Format = "#,##0.00";


            fgrid_midsole.Set_Grid("SFX_CBD_TAIL_MS", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_midsole.Tree.Column = (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME;
            SetGridDesign(fgrid_midsole, Imgmap);
            fgrid_midsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT].Visible = false;
            fgrid_midsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].StyleNew.BackColor = Color.Yellow;

            fgrid_midsole.GetCellRange(
                fgrid_midsole.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE,
                fgrid_midsole.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE).StyleNew.BackColor = Color.OrangeRed;
            fgrid_midsole.GetCellRange(
                fgrid_midsole.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST,
                fgrid_midsole.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST).StyleNew.BackColor = Color.OrangeRed;
            fgrid_midsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].Style.Format = "#,##0.00";


            fgrid_outsole.Set_Grid("SFX_CBD_TAIL_OS", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_outsole.Tree.Column = (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME;
            SetGridDesign(fgrid_outsole, Imgmap);
            fgrid_outsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT].Visible = false;
            fgrid_outsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].StyleNew.BackColor = Color.Yellow;

            fgrid_outsole.GetCellRange(
                fgrid_outsole.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE,
                fgrid_outsole.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE).StyleNew.BackColor = Color.OrangeRed;
            fgrid_outsole.GetCellRange(
                fgrid_outsole.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST,
                fgrid_outsole.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST).StyleNew.BackColor = Color.OrangeRed;
            fgrid_outsole.Cols[(int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST].Style.Format = "#,##0.00";


            fgrid_labor.Set_Grid("SFX_CBD_TAIL_LB", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_labor, Imgmap);
            fgrid_labor.GetCellRange(
                fgrid_labor.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCOST_USD,
                fgrid_labor.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCOST_USD).StyleNew.BackColor = Color.OrangeRed;
            fgrid_labor.Cols[(int)ClassLib.TBSFX_CBD_TAIL_LB.IxCOST_USD].StyleNew.BackColor = Color.Yellow;
            fgrid_labor.Cols[(int)ClassLib.TBSFX_CBD_TAIL_LB.IxCOST_USD].Style.Format = "#,##0.00";

            fgrid_overhead.Set_Grid("SFX_CBD_TAIL_OH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_overhead, Imgmap);
            fgrid_overhead.Cols[(int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_USD].StyleNew.BackColor = Color.Yellow;
            fgrid_overhead.GetCellRange(
                fgrid_overhead.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_USD,
                fgrid_overhead.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_USD).StyleNew.BackColor = Color.OrangeRed;
            fgrid_overhead.Cols[(int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_USD].Style.Format = "#,##0.00";


            fgrid_sampMold.Set_Grid("SFX_CBD_TAIL_MOLD", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_sampMold, Imgmap);
            fgrid_sampMold.Cols[(int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR].StyleNew.BackColor = Color.Yellow;
            fgrid_sampMold.GetCellRange(
                fgrid_sampMold.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR,
                fgrid_sampMold.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR).StyleNew.BackColor = Color.OrangeRed;
            fgrid_sampMold.Cols[(int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxTOT_COST_USD].Style.Format = "#,##0.00";


            fgrid_prodMold.Set_Grid("SFX_CBD_TAIL_MOLD", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_prodMold, Imgmap);
            fgrid_prodMold.Cols[(int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR].StyleNew.BackColor = Color.Yellow;
            fgrid_prodMold.GetCellRange(
                fgrid_prodMold.Rows.Fixed - 2, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR,
                fgrid_prodMold.Rows.Fixed - 1, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR).StyleNew.BackColor = Color.OrangeRed;
            fgrid_prodMold.Cols[(int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxTOT_COST_USD].Style.Format = "#,##0.00";

            fgrid_5523.Set_Grid("EBM_FOB_5523_TAIL", "2", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_5523.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgrid_5523.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            fgrid_5523.Font = new Font(fgrid_5523.Font.FontFamily, (float)8.5);
            fgrid_5523.ExtendLastCol = false;

            //PROD MOLD COST - MOEF Head
            fgrid_pm_meof_head.Set_Grid("EBM_FOB_MEOF_HEAD", "3", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_pm_meof_head, Imgmap);

            //PROD MOLD COST - MEOF Size
            fgrid_pm_meof_size.Set_Grid("EBM_FOB_MEOF_TAIL", "2", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            SetGridDesign(fgrid_pm_meof_size, Imgmap);

            fgrid_pm_meof_head.Width = Convert.ToInt32(tabControl1.Width * 0.15);
            fgrid_pm_meof_size.Width = Convert.ToInt32(tabControl1.Width * 0.15);
            fgrid_pm_meof_head.ClearAll();
            fgrid_pm_meof_size.ClearAll();
        }

        /// <summary>
        /// 그리드 디자인
        /// </summary>
        /// <param name="arg_grid">Grid</param>
        /// <param name="arg_Imgmap">Imagelist</param>
        private void SetGridDesign(COM.FSP arg_grid, System.Collections.Hashtable arg_Imgmap)
        {
            arg_grid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            arg_grid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            arg_grid.Cols[0].ImageMap = arg_Imgmap;
            arg_grid.Font = new Font(arg_grid.Font.FontFamily, (float)8.5);
            //arg_grid.Rows[fgrid_upper.Rows.Fixed - 2].HeightDisplay = arg_grid.Rows[arg_grid.Rows.Fixed - 2].HeightDisplay * 2;
            arg_grid.Rows[fgrid_upper.Rows.Fixed - 2].Style.WordWrap = true;
            arg_grid.ExtendLastCol = false;
            

            for (int iCol = 1; iCol < arg_grid.Cols.Count; iCol++)
            {
                if (arg_grid.Cols[iCol].DataType == typeof(System.Double))
                {
                    arg_grid.Cols[iCol].Style.Format = "#,##0.00##";
                }
            }
        }

        /// <summary>
        /// 컨트롤 초기화 ( 콤보 )
        /// </summary>
        private void Init_Control()
        {
            string sDevFac = COM.ComVar.This_Factory;

            // Prod Factory
            DataTable vDT = ClassLib.ComFunction.Select_Factory_List_Cost();
            COM.ComCtl.Set_ComboList(vDT, cmb_hPROD_FAC, 0, 1, false);
            COM.ComCtl.Set_ComboList(vDT, cmb_hDEV_FAC, 0, 1, false);
            cmb_hPROD_FAC.ReadOnly = cmb_hDEV_FAC.ReadOnly = false;
            cmb_hPROD_FAC.Enabled = cmb_hDEV_FAC.Enabled = true;
            vDT.Dispose();

            // Fob Status
            vDT = COM.ComVar.Select_ComCode(sDevFac, "SFB_05");
            COM.ComCtl.Set_ComboList(vDT, cmb_hFOB_STATUS, 1, 2, false, false);
            vDT.Dispose();

            // Round Code
            vDT = COM.ComVar.Select_ComCode(sDevFac, "SXB01");
            COM.ComCtl.Set_ComboList(vDT, cmb_hFOB_TYPE_CD, 1, 2, false, false);
            vDT.Dispose();

            // Round Code
            vDT = COM.ComVar.Select_ComCode(sDevFac, "SFB_06");
            COM.ComCtl.Set_ComboList(vDT, cmb_hROUND_CD, 1, 2, false, false);
            vDT.Dispose();

            // Gender
            vDT = COM.ComVar.Select_ComCode(sDevFac, "SEM01");
            COM.ComCtl.Set_ComboList(vDT, cmb_hGENDER, 1, 2, false, false);
            vDT.Dispose();

            // Category
            vDT = COM.ComVar.Select_ComCode(sDevFac, "SFB_48");
            COM.ComCtl.Set_ComboList(vDT, cmb_hCAT_CD, 1, 2, false, false);
            vDT.Dispose();

            // TD 
            vDT = COM.ComVar.Select_ComCode(sDevFac, "CM06");
            COM.ComCtl.Set_ComboList(vDT, cmb_hTD_CD, 1, 2, false, false);
            vDT.Dispose();

            // Season 
            vDT = _ComFnc.Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_hSEASON_CD, 0, 1, false, false);
            vDT.Dispose();

            // DPO 
            vDT = _ComFnc.Select_DPO(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_hOBS_ID, 0, 1, true, false);
            vDT.Dispose();

            // OBS TYPE
            vDT = COM.ComVar.Select_ComCode(sDevFac, "SFB_58");
            COM.ComCtl.Set_ComboList(vDT, cmb_hOBS_TYPE,  1, 2, false, false);
            cmb_hOBS_TYPE.SelectedValue = "FT";
            vDT.Dispose();

            // 5523 Region
            vDT = COM.ComVar.Select_ComCode(sDevFac, "SFB_52");
            COM.ComCtl.Set_ComboList(vDT, cmb_region, 1, 2, false, false);
            vDT.Dispose();


            _EditableControls = new Control[] { 
            cmb_hDEV_FAC, cmb_hPROD_FAC, cmb_hCAT_CD, cmb_hFOB_STATUS, cmb_hFOB_TYPE_CD, dpick_hDATE_QUOTED, cmb_hROUND_CD,  txt_hPRODUCT_CD, 
            cmb_hGENDER, txt_hSIZE_REP, txt_hSIZEUP_PCT, txt_hFORECAST, cmb_hCBD_CHARGE, txt_hPCC_CHARGE, txt_hNLO_CHARGE, 
            txt_hLABOR_CMT, txt_hOVERHEAD_CMT, txt_hPROFIT_PCT, txt_hOTHER_ADJUST, txt_hLEAN_SAVE_TGT, 
            txt_hSIZERUN, txt_hTOT_SIZERUN, txt_hRETAIL_PRICE, txt_hTARGET_FOB };
        }

        /// <summary>
        /// 툴바 버튼 초기화
        /// </summary>
        private void Init_Toolbar()
        {
            tbtn_New.Enabled = true;
            tbtn_Search.Enabled = true;
            tbtn_Save.Enabled = true;
            tbtn_Delete.Enabled = true;
            tbtn_Print.Enabled = true;
            tbtn_Create.Enabled = false;
            tbtn_Confirm.Enabled = false;
        }

        /// <summary>
        /// 차트 초기화
        /// </summary>
        /// <param name="arg_chart">Chart</param>
        /// <param name="arg_stream">MemoryStream</param>
        private void Init_Chart(ChartFX.WinForms.Chart arg_chart, MemoryStream arg_stream)
        {
            arg_stream.Position = 0;
            arg_chart.Import(ChartFX.WinForms.FileFormat.Binary, arg_stream);
            arg_chart.Data.Clear();
        }

        #endregion

        #region Toolbar event process

        #region Clear

        private void ClearHead()
        {
            foreach (Control ctl in pnl_head.Controls)
            {
                if (ctl is TextBox)
                {
                    (ctl as TextBox).Text = "";
                    (ctl as TextBox).Tag = null;

                }
                else if (ctl is C1.Win.C1List.C1Combo)
                {
                    (ctl as C1.Win.C1List.C1Combo).SelectedIndex = -1;
                    (ctl as C1.Win.C1List.C1Combo).Tag = null;
                }
                else if (ctl is DateTimePicker)
                {
                    (ctl as DateTimePicker).Value = DateTime.Now;
                }
            }

            for (int iIdx = pnl_head.Controls.Count - 1; iIdx >= 0; iIdx--)
            {
                if (pnl_head.Controls[iIdx] is TextBox)
                {
                    if (pnl_head.Controls[iIdx].Name.StartsWith("txt_hCURR_CD_") ||
                        pnl_head.Controls[iIdx].Name.StartsWith("txt_hFX_RATE_") ||
                        pnl_head.Controls[iIdx].Name.StartsWith("txt_hCOUNTRY_") ||
                        pnl_head.Controls[iIdx].Name.StartsWith("txt_hNON_FX_RATE"))
                        pnl_head.Controls.RemoveAt(iIdx);
                }
            }

            foreach (Control ctl in pnl_CBDDetailSummary.Controls)
            {
                if (ctl is TextBox)
                {
                    (ctl as TextBox).Text = "";
                }
                else if (ctl is C1.Win.C1List.C1Combo)
                {
                    (ctl as C1.Win.C1List.C1Combo).SelectedIndex = -1;
                }
                else if (ctl is DateTimePicker)
                {
                    (ctl as DateTimePicker).Value = DateTime.Now;
                }
            }

            tabPage1.Text = tabPage1.Tag.ToString();
            tabPage2.Text = tabPage2.Tag.ToString();
            tabPage3.Text = tabPage3.Tag.ToString();
            tabPage4.Text = tabPage4.Tag.ToString();
            tabPage5.Text = tabPage5.Tag.ToString();
            tabPage6.Text = tabPage6.Tag.ToString();
            tabPage7.Text = tabPage7.Tag.ToString();
            tabPage8.Text = tabPage8.Tag.ToString();
            tabPage9.Text = tabPage9.Tag.ToString();

            txt_hOVERHEAD_CMT.Text = "";
            txt_hLABOR_CMT.Text = "";
        }

        private void ClearDetail()
        {
            // Detail
            fgrid_upper.ClearAll();
            fgrid_packaging.ClearAll();
            fgrid_midsole.ClearAll();
            fgrid_outsole.ClearAll();
            fgrid_labor.ClearAll();
            fgrid_overhead.ClearAll();
            fgrid_sampMold.ClearAll();
            fgrid_prodMold.ClearAll();

            // 5523
            fgrid_5523.ClearAll(); ;
            fgrid_5523.Cols.Count = fgrid_5523.Cols.Frozen;
            txt_prodCode_5523.Text = ""; txt_devCode_5523.Text = ""; txt_prodName_5523.Text = "";
            txt_prodType_5523.Text = ""; txt_factory_5523.Text = ""; txt_season_5523.Text = "";
            txt_date_5523.Text = "";
            txt_leather_5523.Text = ""; txt_synthetic_5523.Text = ""; txt_textile_5523.Text = "";
            txt_other_5523.Text = "";

            // MEF
            fgrid_pm_meof_head.ClearAll();
            fgrid_pm_meof_size.ClearAll();
        }

        #endregion

        #region New, Search, Save

        private void New()
        {
            FlexCosting.Management.Costing.Pop.Pop_BOM_Search_From_CBD_Mst_v6 vMstPop = new FlexCosting.Management.Costing.Pop.Pop_BOM_Search_From_CBD_Mst_v6("10", this);
            vMstPop.ShowDialog(this);
            _Division = "I";
        }

        private void Search()
        {
            FlexCosting.Management.Costing.Pop.Pop_BOM_Search_From_CBD_Mst_v6 vMstPop = new FlexCosting.Management.Costing.Pop.Pop_BOM_Search_From_CBD_Mst_v6("30", this);
            vMstPop.TopMost = true;
            vMstPop.Show();
            _Division = "U";
        }

        private void SearchForRefesh()
        {
            try
            {
                ClassLib.ComFunction_Cost costCom = new FlexCosting.ClassLib.ComFunction_Cost();

                string sDevFac = cmb_hDEV_FAC.SelectedValue.ToString();
                string sMOID = txt_hMOID.Text.Replace("-", "");
                string sCBDID = txt_hCBD_ID.Text;
                string sCBDVer = txt_hCBD_SEQ.Text;
                string sFOBType = cmb_hFOB_TYPE_CD.SelectedValue.ToString();

                // Header 
                DataTable vDTH = costCom.SELECT_SFX_CBD_HEAD(sDevFac, sMOID, sCBDID, sCBDVer, sFOBType);
                LoadCBDHead(vDTH);
                vDTH.Dispose();

                // F/X Rate
                string sSeason = cmb_hSEASON_CD.SelectedValue.ToString();
                DataTable vDT = costCom.SELECT_SFX_CBD_FXRATE(sDevFac, sMOID, sCBDID, sCBDVer, sFOBType, sSeason);
                DisplayFXRate(vDT);
                vDT.Dispose();

                // Detail 
                string[] procs = new string[] {
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL",
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_LB",
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_OH",
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_SM",
                    "PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_PM", };

                DataSet vDST = costCom.SELECT_SFX_CBD_TAIL(procs, sDevFac, sMOID, sCBDID, sCBDVer, sFOBType);
                LoadCBDDetail(vDST);
                vDST.Dispose();

                _Division = "U";
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Search for refresh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BeforeSave()
        {
            if (fgrid_upper.Rows.Fixed < fgrid_upper.Rows.Count)
            {
                fgrid_upper.SetData(
                fgrid_upper.GetCellRange(
                    fgrid_upper.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_VER,
                    fgrid_upper.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_VER),
                txt_hCBD_SEQ.Text);
                BeforeSaveOrderBy(fgrid_upper);
            }

            if (fgrid_packaging.Rows.Fixed < fgrid_packaging.Rows.Count)
            {
                fgrid_packaging.SetData(
                fgrid_packaging.GetCellRange(
                    fgrid_packaging.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_VER,
                    fgrid_packaging.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_VER),
                txt_hCBD_SEQ.Text);
                BeforeSaveOrderBy(fgrid_packaging);
            }

            if (fgrid_midsole.Rows.Fixed < fgrid_midsole.Rows.Count)
            {
                fgrid_midsole.SetData(
                fgrid_midsole.GetCellRange(
                    fgrid_midsole.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_VER,
                    fgrid_midsole.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_VER),
                txt_hCBD_SEQ.Text);
                BeforeSaveOrderBy(fgrid_midsole);
            }

            if (fgrid_outsole.Rows.Fixed < fgrid_outsole.Rows.Count)
            {
                fgrid_outsole.SetData(
                fgrid_outsole.GetCellRange(
                    fgrid_outsole.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_VER,
                    fgrid_outsole.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_VER),
                txt_hCBD_SEQ.Text);
                BeforeSaveOrderBy(fgrid_outsole);
            }

            if (fgrid_labor.Rows.Fixed < fgrid_labor.Rows.Count)
                fgrid_labor.SetData(
                fgrid_labor.GetCellRange(
                    fgrid_labor.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCBD_VER,
                    fgrid_labor.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCBD_VER),
                txt_hCBD_SEQ.Text);
            BeforeSaveOrderBy(fgrid_labor);

            if (fgrid_overhead.Rows.Fixed < fgrid_overhead.Rows.Count)
                fgrid_overhead.SetData(
                fgrid_overhead.GetCellRange(
                    fgrid_overhead.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCBD_VER,
                    fgrid_overhead.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCBD_VER),
                txt_hCBD_SEQ.Text);
            BeforeSaveOrderBy(fgrid_overhead);

            if (fgrid_sampMold.Rows.Fixed < fgrid_sampMold.Rows.Count)
            {
                fgrid_sampMold.SetData(
                fgrid_sampMold.GetCellRange(
                    fgrid_sampMold.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCBD_VER,
                    fgrid_sampMold.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCBD_VER),
                txt_hCBD_SEQ.Text);
                BeforeSaveOrderBy(fgrid_sampMold);
            }

            if (fgrid_prodMold.Rows.Fixed < fgrid_prodMold.Rows.Count)
            {
                fgrid_prodMold.SetData(
                fgrid_prodMold.GetCellRange(
                    fgrid_prodMold.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCBD_VER,
                    fgrid_prodMold.Rows.Count - 1, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCBD_VER),
                txt_hCBD_SEQ.Text);
                BeforeSaveOrderBy(fgrid_prodMold);
            }
        }

        private bool BeforeSaveZeroCheck(COM.FSP vFSP, int iCol)
        {
            for (int iRow = vFSP.Rows.Fixed; iRow < vFSP.Rows.Count; iRow++)
            {
                string sNum = vFSP[iRow, iCol] == null ? "0" : vFSP[iRow, iCol].ToString();
                string sDiv = vFSP[iRow, 0] == null ? "" : vFSP[iRow, 0].ToString();
                if (vFSP.Rows[iRow].IsNode && vFSP.Rows[iRow].Node.Level > 0 || sDiv.Equals("R"))
                    continue;

                double dNum = 0;
                if (double.TryParse(sNum, out dNum))
                {
                    if (dNum == 0)
                    {
                        vFSP.Select(iRow, iCol);
                        if (MessageBox.Show("Check loss %", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    vFSP.Select(iRow, iCol);
                    MessageBox.Show("This data is not numeric", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            return true;
        }

        private bool BeforeSaveSummaryCheck()
        {
            bool bResult = true;

            string sDevFac = COM.ComFunction.Empty_Combo(cmb_hDEV_FAC, "");
            string sMOID = txt_hMOID.Text.Replace("-", "");
            string sCBDID = txt_hCBD_ID.Text;
            string sFOBType = COM.ComFunction.Empty_Combo(cmb_hROUND_CD, ""); ;
            string sFOBStatus = COM.ComFunction.Empty_Combo(cmb_hFOB_STATUS, ""); ;

            string sRetail, sTarget, sForecast;
            double dData = 0;

            if (sDevFac.Trim().Equals(""))
            {
                MessageBox.Show("Select FACTORY");
                cmb_hDEV_FAC.Focus();
                return false;
            }

            if (sMOID.Trim().Equals(""))
            {
                MessageBox.Show("Empty MOID");
                txt_hMOID.Focus();
                return false;
            }

            if (sCBDID.Trim().Equals(""))
            {
                MessageBox.Show("Empty CBD ID");
                txt_hCBD_ID.Focus();
                return false;
            }

            if (sFOBType.Trim().Equals(""))
            {
                MessageBox.Show("Select FOB TYPE");
                cmb_hROUND_CD.Focus();
                return false;
            }

            if (sFOBStatus.Trim().Equals(""))
            {
                MessageBox.Show("Select FOB STATUS");
                cmb_hFOB_STATUS.Focus();
                return false;
            }

            if (cmb_hROUND_CD.SelectedValue.ToString().Equals("Y0000"))
            {
                string sProdCode = COM.ComFunction.Empty_TextBox(txt_hPRODUCT_CD, "").Trim().Replace("-", "").Replace("_", "");
                if (sProdCode.Equals("") || sProdCode.Equals("00"))
                {
                    txt_hPRODUCT_CD.Focus();
                    MessageBox.Show("Input product code (ex. 309207151)", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (COM.ComFunction.Empty_Combo(cmb_hOBS_ID, "").Trim().Equals(""))
                {
                    cmb_hOBS_ID.Focus();
                    MessageBox.Show("Select DPO", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    DataTable vDT2 = CHECK_SFX_CBD_HEAD();
                    if (vDT2 != null)
                    {
                        if (vDT2.Rows.Count > 0)
                        {
                            // MessageBox.Show("Exist DPO, please check again");
                            FlexCosting.Management.Costing.Pop.Pop_CBD_Master_CheckDPO vDPOPop = new FlexCosting.Management.Costing.Pop.Pop_CBD_Master_CheckDPO();
                            vDPOPop.DisplayGrid(vDT2);
                            vDPOPop.ShowDialog();
                            return false;
                        }
                    }
                }
            }

            sRetail = txt_hRETAIL_PRICE.Text;
            sTarget = txt_hTARGET_FOB.Text;
            sForecast = txt_hFORECAST.Text;

            if (!sRetail.Equals(""))
            {
                if (!double.TryParse(sRetail, out dData))
                {
                    MessageBox.Show("Retail price is not numeric", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_hRETAIL_PRICE.Focus();
                    return false;
                }
            }
            else
            {
                txt_hRETAIL_PRICE.Text = "0";
            }

            if (!sTarget.Equals(""))
            {
                if (!double.TryParse(sTarget, out dData))
                {
                    MessageBox.Show("Target FOB is not numeric", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_hTARGET_FOB.Focus();
                    return false;
                }
            }
            else
            {
                txt_hTARGET_FOB.Text = "0";
            }

            if (!sForecast.Equals(""))
            {
                if (!double.TryParse(sForecast, out dData))
                {
                    MessageBox.Show("Forecast Q'ty is not numeric", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_hFORECAST.Focus();
                    return false;
                }
            }
            else
            {
                txt_hFORECAST.Text = "0";
            }



            return bResult;
        }

        private bool BeforeSaveEmptyCheck(TabPage vTP, COM.FSP vFSP, int[] iCols)
        {
            bool bResult = true;
            int iErrCnt = 0;

            for (int iRow = vFSP.Rows.Fixed; iRow < vFSP.Rows.Count; iRow++)
            {
                string sDiv = vFSP[iRow, 0] == null ? "" : vFSP[iRow, 0].ToString();
                if (vFSP.Rows[iRow].IsNode && vFSP.Rows[iRow].Node.Level > 0 || sDiv.Equals("R"))
                    continue;

                foreach (int iCol in iCols)
                {
                    if (vFSP.Cols[iCol].DataType.Equals(typeof(System.Double)))
                    {
                        string sData = vFSP[iRow, iCol] == null ? "0" : vFSP[iRow, iCol].ToString().Trim();
                        if (sData.Equals("0"))
                        {
                            string sColumn = vFSP[vFSP.Rows.Fixed - 1, iCol] == null ? "" : vFSP[vFSP.Rows.Fixed - 1, iCol].ToString();
                            vFSP.GetCellRange(iRow, iCol).StyleNew.BackColor = Color.Red;
                            bResult = false;

                            vTP.Text = vTP.Tag.ToString() + " (" + ++iErrCnt + ")";
                        }
                    }
                    else
                    {
                        string sData = vFSP[iRow, iCol] == null ? "" : vFSP[iRow, iCol].ToString().Trim();
                        if (sData.Equals(""))
                        {
                            string sColumn = vFSP[vFSP.Rows.Fixed - 1, iCol] == null ? "" : vFSP[vFSP.Rows.Fixed - 1, iCol].ToString();
                            vFSP.GetCellRange(iRow, iCol).StyleNew.BackColor = Color.Red;
                            bResult = false;

                            vTP.Text = vTP.Tag.ToString() + " (" + ++iErrCnt + ")";
                        }
                    }
                }
            }

            return bResult;
        }

        private void BeforeSaveOrderBy(COM.FSP vFSP)
        {
            try
            {
                int iOrdCol = (int)ClassLib.TBSFX_CBD_TAIL.IxORDER_BY;
                if (vFSP.Name.Equals(fgrid_sampMold.Name) || vFSP.Name.Equals(fgrid_prodMold.Name))
                {
                    iOrdCol = (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxORDER_BY;
                }
                else if (vFSP.Name.Equals(fgrid_labor.Name))
                {
                    iOrdCol = (int)ClassLib.TBSFX_CBD_TAIL_LB.IxORDER_BY;
                }
                else if (vFSP.Name.Equals(fgrid_overhead.Name))
                {
                    iOrdCol = (int)ClassLib.TBSFX_CBD_TAIL_OH.IxORDER_BY;
                }

                //int iOrdBy = 1;
                for (int iRow = vFSP.Rows.Fixed; iRow < vFSP.Rows.Count; iRow++)
                {
                    string sCurDiv = vFSP[iRow, 0] == null ? "" : vFSP[iRow, 0].ToString();
                    string sCurOrd = vFSP[iRow, iOrdCol] == null ? "" : vFSP[iRow, iOrdCol].ToString();
                    int iCurOrd = 0;
                    int.TryParse(sCurOrd, out iCurOrd);

                    if (vFSP.Rows[iRow].IsNode)
                    {
                        if (iCurOrd != _OrderBy && vFSP.Rows[iRow].Node.Level == 0)
                        {
                            if (sCurDiv.Equals(""))
                                vFSP.Update_Row(iRow);

                            vFSP[iRow, iOrdCol] = _OrderBy;
                        }

                        if (vFSP.Rows[iRow].Node.Level == 0 && !sCurDiv.Equals("R"))
                            _OrderBy++;
                    }
                    else
                    {
                        if (iCurOrd != _OrderBy)
                        {
                            if (sCurDiv.Equals(""))
                                vFSP.Update_Row(iRow);

                            vFSP[iRow, iOrdCol] = _OrderBy;
                        }

                        if (!sCurDiv.Equals("R"))
                            _OrderBy++;
                    }

                }
            }
            catch (Exception ex)
            {
                _BOMNo = 1;
                _OrderBy = 1;
                throw ex;
            }
        }

        /// <summary>
        /// 전체 저장
        /// </summary>
        /// <returns>true : 정상, false : 오류</returns>
        private bool Save()
        {
            string sDevFac = COM.ComFunction.Empty_Combo(cmb_hDEV_FAC, "");
            string sMOID = txt_hMOID.Text.Replace("-", "");
            string sCBDID = txt_hCBD_ID.Text;
            string sFOBType = COM.ComFunction.Empty_Combo(cmb_hROUND_CD, "");

            if (!BeforeSaveSummaryCheck())
            {
                return false;
            }

            if (_Division.Equals("I"))
            {
                DataTable vDT = SELECT_NEXT_CBD_VER(sDevFac, sMOID, sCBDID, sFOBType);
                if (vDT.Rows.Count == 1)
                {
                    txt_hCBD_SEQ.Text = vDT.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("CBD version error");
                    return false;
                }
            }

            bool bCheckUP = !BeforeSaveEmptyCheck(tabPage1, fgrid_upper, new int[] { (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS, (int)ClassLib.TBSFX_CBD_TAIL.IxCURR, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE, (int)ClassLib.TBSFX_CBD_TAIL.IxLOSS_PCT, (int)ClassLib.TBSFX_CBD_TAIL.IxYIELD });
            bool bCheckPK = !BeforeSaveEmptyCheck(tabPage2, fgrid_packaging, new int[] { (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS, (int)ClassLib.TBSFX_CBD_TAIL.IxCURR, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE });
            bool bCheckMS = !BeforeSaveEmptyCheck(tabPage3, fgrid_midsole, new int[] { (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS, (int)ClassLib.TBSFX_CBD_TAIL.IxCURR, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE });
            bool bCheckOS = !BeforeSaveEmptyCheck(tabPage4, fgrid_outsole, new int[] { (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS, (int)ClassLib.TBSFX_CBD_TAIL.IxCURR, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE });
            bool bCheckLB = !BeforeSaveEmptyCheck(tabPage5, fgrid_labor, new int[] { (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCBD_CLASS, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxSUB_CLASS });
            bool bCheckOH = !BeforeSaveEmptyCheck(tabPage6, fgrid_overhead, new int[] { (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCBD_CLASS, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxSUB_CLASS });
            bool bCheckSM = !BeforeSaveEmptyCheck(tabPage8, fgrid_sampMold, new int[] { (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCBD_CLASS, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxPROD_PER_DAY });
            bool bCheckPM = !BeforeSaveEmptyCheck(tabPage9, fgrid_prodMold, new int[] { (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCBD_CLASS, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxPROD_PER_DAY });

            if (bCheckUP || bCheckPK || bCheckMS || bCheckOS || bCheckLB || bCheckOH || bCheckSM || bCheckPM)
            {
                DialogResult vDR = MessageBox.Show("Please, check data.", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (vDR == DialogResult.Cancel)
                    return false;
            }

            // Summary 
            SetFXRate(fgrid_upper, -1, -1,
                (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
            SetFXRate(fgrid_packaging, -1, -1,
                (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
            SetFXRate(fgrid_midsole, -1, -1,
                (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
            SetFXRate(fgrid_outsole, -1, -1,
                (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
            SetFXRate(fgrid_labor, -1, -1,
                (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCURR,
                (int)ClassLib.TBSFX_CBD_TAIL_LB.IxFX_RATE);
            SetFXRate(fgrid_overhead, -1, -1,
                (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCURR,
                (int)ClassLib.TBSFX_CBD_TAIL_OH.IxFX_RATE);

             // forecast update check
            if (fgrid_sampMold.Rows.Count > fgrid_sampMold.Rows.Fixed || fgrid_prodMold.Rows.Count > fgrid_prodMold.Rows.Fixed)
            {
                    txt_hFORECAST_KeyPress(txt_hFORECAST, null);
            }

            txt_hOTHER_ADJUST_KeyUp(txt_hOTHER_ADJUST, null);
            txt_hSIZEUP_PCT_KeyUp(txt_hSIZEUP_PCT, null);

            // Labor & Overhead double check 
            CalcLabor(-1, -1);
            CalcSummary();
            CalcSummaryPersent();

            txt_hRETAIL_PRICE_KeyPress(txt_hRETAIL_PRICE, null);

            CalcUpper(-1, -1);
            CalcPackaging(-1, -1);
            CalcMidsole(-1, -1);
            CalcOutsole(-1, -1);
            CalcLabor(-1, -1);
            CalcOverhead(-1, -1);
            CalcSampMold(-1, -1);
            CalcProdMold(-1, -1);
            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();

            if (SAVE_SFM_CBD_HEAD(_Division))
            {
                if (SAVE_SFM_CBD_FXRATE())
                {
                    // Detail save 전 새로운 CBD Version 을 설정하고, 순서를 다시 정렬함.
                    BeforeSave();
                    bool error = false;

                    // Save_FlexGird_Ready : 오류 발생시 false 가 리턴됨.
                    error = MyOraDB.Save_FlexGird_Ready("PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_TAIL_UP", fgrid_upper, false);
                    if (!error)
                    {
                        tabControl1.SelectedIndex = 0;
                        return error;
                    }

                    error = MyOraDB.Save_FlexGird_Ready("PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_TAIL_PK", fgrid_packaging, false);
                    if (!error)
                    {
                        tabControl1.SelectedIndex = 1;
                        return error;
                    }

                    error = MyOraDB.Save_FlexGird_Ready("PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_TAIL_MS", fgrid_midsole, false);
                    if (!error)
                    {
                        tabControl1.SelectedIndex = 2;
                        return error;
                    }

                    error = MyOraDB.Save_FlexGird_Ready("PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_TAIL_OS", fgrid_outsole, false);
                    if (!error)
                    {
                        tabControl1.SelectedIndex = 3;
                        return error;
                    }

                    error = MyOraDB.Save_FlexGird_Ready("PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_TAIL_LB", fgrid_labor, false);
                    if (!error)
                    {
                        tabControl1.SelectedIndex = 4;
                        return error;
                    }

                    error = MyOraDB.Save_FlexGird_Ready("PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_TAIL_OH", fgrid_overhead, false);
                    if (!error)
                    {
                        tabControl1.SelectedIndex = 5;
                        return error;
                    }

                    error = MyOraDB.Save_FlexGird_Ready("PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_TAIL_SM", fgrid_sampMold, false);
                    if (!error)
                    {
                        tabControl1.SelectedIndex = 6;
                        return error;
                    }

                    error = MyOraDB.Save_FlexGird_Ready("PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_TAIL_PM", fgrid_prodMold, false);
                    if (!error)
                    {
                        tabControl1.SelectedIndex = 7;
                        return error;
                    }

                    error = ConfirmReady();

                    //string sFOBStatus = COM.ComFunction.Empty_Combo(cmb_hFOB_STATUS, "");
                    //if (sFOBStatus.Equals("Confirmed"))
                    //{
                    //    if (!COM.ComVar.This_Factory.Equals("DS"))
                    //    {
                    //        if (!COM.ComVar.This_Factory.Equals(cmb_hDEV_FAC.SelectedValue.ToString()))
                    //        {
                    //            error = false;
                    //        }
                    //        else
                    //        {
                    //            error = ConfirmReady();
                    //        }
                    //    }
                    //    else
                    //    {
                    //        error = ConfirmReady();
                    //    }
                    //}

                    if (error)
                    {
                        if (MyOraDB.Exe_Modify_Procedure() == null)
                            return false;
                    }
                }
            }

            return true;
        }

        private bool ConfirmReady()
        {
            string sDiv = "C";
            string sDevFac = COM.ComFunction.Empty_Combo(cmb_hDEV_FAC, "");
            string sMOID = COM.ComFunction.Empty_TextBox(txt_hMOID, "");
            string sCBDID = COM.ComFunction.Empty_TextBox(txt_hCBD_ID, "");
            string sCBDVer = COM.ComFunction.Empty_TextBox(txt_hCBD_SEQ, "");
            string sFobType = COM.ComFunction.Empty_Combo(cmb_hFOB_TYPE_CD, "");
            string sUpdUser = COM.ComVar.This_User;

            return SAVE_SFX_CBD_MASTER_CONFIRM(sDiv, sDevFac, sMOID, sCBDID, sCBDVer, sFobType, sUpdUser);
        }

        private bool Delete()
        {
            if (MessageBox.Show("Do you want to delete CBD?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Division = "D";

                if (SAVE_SFM_CBD_HEAD(_Division))
                {
                    if (MyOraDB.Exe_Modify_Procedure() == null)
                        return false;
                }

                ClearHead();
                ClearDetail();
            }

            return true;
        }

        #endregion

        #region data load and display method

        #region loading

        public void LoadBOMHead(DataTable vDT)
        {
            ClearHead();
            DisplayCBDHead(vDT);
        }

        public void LoadBOMDetail(DataSet vDS)
        {
            ClearDetail();

            DataTable vOrgDT = vDS.Tables["PKG_SFX_CBD_MASTER_BOM.SELECT_SXD_SRF_TAIL"];
            DataTable vUPDT = null, vMSDT = null, vOSDT = null;

            if (vOrgDT != null && vOrgDT.Rows.Count > 0)
            {
                vUPDT = new DataTable("UPPER");
                vMSDT = new DataTable("MIDSOLE");
                vOSDT = new DataTable("OUTSOLE");

                for (int icidx = 0; icidx < vOrgDT.Columns.Count; icidx++)
                {
                    vUPDT.Columns.Add(vOrgDT.Columns[icidx].ColumnName);
                    vMSDT.Columns.Add(vOrgDT.Columns[icidx].ColumnName);
                    vOSDT.Columns.Add(vOrgDT.Columns[icidx].ColumnName);
                }

                for (int iridx = 0; iridx < vOrgDT.Rows.Count; iridx++)
                {
                    string sCBDClass = vOrgDT.Rows[iridx]["DIV"].ToString();

                    if (sCBDClass.Equals("MIDSOLE"))
                    {
                        vMSDT.Rows.Add(vOrgDT.Rows[iridx].ItemArray);
                    }
                    else if (sCBDClass.Equals("OUTSOLE"))
                    {
                        vOSDT.Rows.Add(vOrgDT.Rows[iridx].ItemArray);
                    }
                    else
                    {
                        vUPDT.Rows.Add(vOrgDT.Rows[iridx].ItemArray);
                    }
                }
            }

            DisplayBOMDetail(vUPDT, fgrid_upper, true);
            DisplayBOMDetailTree(fgrid_upper, -1);
            DisplayBOMDetail(vDS.Tables["PKG_SFX_CBD_MASTER_BOM.SELECT_SXD_SRF_TAIL_PK"], fgrid_packaging, true);
            DisplayBOMDetailTree(fgrid_packaging, -1);
            DisplayBOMDetail(vMSDT, fgrid_midsole, true);
            DisplayBOMDetailTree(fgrid_midsole, -1);
            DisplayBOMDetail(vOSDT, fgrid_outsole, true);
            DisplayBOMDetailTree(fgrid_outsole, -1);

            DisplayBOMDetail(vDS.Tables["PKG_SFX_CBD_MASTER_BOM.SELECT_SXD_SRF_TAIL_LB"], fgrid_labor, true);
            DisplayBOMDetail(vDS.Tables["PKG_SFX_CBD_MASTER_BOM.SELECT_SXD_SRF_TAIL_OH"], fgrid_overhead, true);

            _OrderBy = 1;
            _BOMNo = 1;

            // Summary 
            UpdateRetail();
            CalcUpper(-1, -1);
            CalcPackaging(-1, -1);
            CalcMidsole(-1, -1);
            CalcOutsole(-1, -1);
            CalcLabor(-1, -1);
            CalcOverhead(-1, -1);
            CalcSampMold(-1, -1);
            CalcProdMold(-1, -1);
            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();
            
        }

        public void LoadCBDHead(DataTable vDT)
        {
            ClearHead();
            DisplayCBDHead(vDT);
        }

        public void LoadCBDDetail(DataSet vDS)
        {
            ClearDetail();

            DataTable vOrgDT = vDS.Tables["PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL"];
            DataTable vUPDT = null, vPKDT = null, vMSDT = null, vOSDT = null;

            if (vOrgDT != null && vOrgDT.Rows.Count > 0)
            {
                vUPDT = new DataTable("UPPER");
                vPKDT = new DataTable("PACKAGING");
                vMSDT = new DataTable("MIDSOLE");
                vOSDT = new DataTable("OUTSOLE");

                for (int icidx = 0; icidx < vOrgDT.Columns.Count; icidx++)
                {
                    vUPDT.Columns.Add(vOrgDT.Columns[icidx].ColumnName);
                    vPKDT.Columns.Add(vOrgDT.Columns[icidx].ColumnName);
                    vMSDT.Columns.Add(vOrgDT.Columns[icidx].ColumnName);
                    vOSDT.Columns.Add(vOrgDT.Columns[icidx].ColumnName);
                }

                for (int iridx = 0; iridx < vOrgDT.Rows.Count; iridx++)
                {
                    string sCBDClass = vOrgDT.Rows[iridx]["DIV"].ToString();

                    if (sCBDClass.Equals("MIDSOLE"))
                    {
                        vMSDT.Rows.Add(vOrgDT.Rows[iridx].ItemArray);
                    }
                    else if (sCBDClass.Equals("OUTSOLE"))
                    {
                        vOSDT.Rows.Add(vOrgDT.Rows[iridx].ItemArray);
                    }
                    else if (sCBDClass.Equals("PACKAGING"))
                    {
                        vPKDT.Rows.Add(vOrgDT.Rows[iridx].ItemArray);
                    }
                    else
                    {
                        vUPDT.Rows.Add(vOrgDT.Rows[iridx].ItemArray);
                    }
                }
            }

            DisplayCBDDetail(vUPDT, fgrid_upper);
            DisplayCBDDetail(vPKDT, fgrid_packaging);
            DisplayCBDDetail(vMSDT, fgrid_midsole);
            DisplayCBDDetail(vOSDT, fgrid_outsole);

            DisplayCBDDetail(vDS.Tables["PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_LB"], fgrid_labor);
            DisplayCBDDetail(vDS.Tables["PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_OH"], fgrid_overhead);
            DisplayCBDDetail(vDS.Tables["PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_SM"], fgrid_sampMold);
            DisplayCBDDetail(vDS.Tables["PKG_SFX_CBD_MASTER_CBD.SELECT_SFX_CBD_TAIL_PM"], fgrid_prodMold);

            _BOMNo = 1;
            _OrderBy = 1;

            // Summary 
            DisplaySummaryChart();

            Display5523();
            DisplayMEF();

            //CalcUpper(-1, -1);
            //CalcPackaging(-1, -1);
            //CalcMidsole(-1, -1);
            //CalcOutsole(-1, -1);
            //CalcLabor(-1, -1);
            //CalcOverhead(-1, -1);
            //CalcSampMold(-1, -1);
            //CalcProdMold(-1, -1);
            //CalcETCSummary();
            //CalcSummary();
            //CalcSummaryPersent();

            //txt_hFORECAST_Leave(txt_hFORECAST, null);
        }

        #endregion

        #region display

        private void DisplayCBDHead(DataTable vDT)
        {
            if (vDT != null && vDT.Rows.Count == 1)
            {
                for (int iCIdx = 0; iCIdx < vDT.Rows[0].ItemArray.Length; iCIdx++)
                {
                    string sColName = vDT.Columns[iCIdx].ColumnName;

                    if (pnl_head.Controls["txt_h" + sColName] != null)
                    {
                        TextBox vTxt = pnl_head.Controls["txt_h" + sColName] as TextBox;

                        vTxt.Tag = vDT.Rows[0][iCIdx].ToString();
                        vTxt.Text = vDT.Rows[0][iCIdx].ToString();
                        vTxt.Update();
                    }
                    else if (pnl_head.Controls["cmb_h" + sColName] != null)
                    {
                        C1.Win.C1List.C1Combo vCmb = pnl_head.Controls["cmb_h" + sColName] as C1.Win.C1List.C1Combo;
                        vCmb.SelectedValue = vDT.Rows[0][iCIdx].ToString();
                        vCmb.Tag = vDT.Rows[0][iCIdx].ToString();
                    }
                    else if (pnl_head.Controls["dpick_h" + sColName] != null)
                    {
                        DateTimePicker vDPK = pnl_head.Controls["dpick_h" + sColName] as DateTimePicker;

                        if (vDT.Rows[0][iCIdx] != null && vDT.Rows[0][iCIdx].ToString().Length == 8)
                        {
                            string sAppDate = vDT.Rows[0][iCIdx].ToString();
                            string sAppYear = sAppDate.Substring(0, 4);
                            string sAppMonth = sAppDate.Substring(4, 2);
                            string sAppDay = sAppDate.Substring(6, 2);

                            DateTime vAppDate = new DateTime(Convert.ToInt32(sAppYear), Convert.ToInt32(sAppMonth), Convert.ToInt32(sAppDay));
                            vDPK.Value = vAppDate;
                        }
                        else
                        {
                            vDPK.Value = System.DateTime.Now;
                        }
                    }
                    else if (pnl_CBDDetailSummary.Controls["txt_h" + sColName] != null)
                    {
                        TextBox vTxt = pnl_CBDDetailSummary.Controls["txt_h" + sColName] as TextBox;
                        vTxt.Text = vDT.Rows[0][iCIdx].ToString();
                    }
                }
            
                txt_hOVERHEAD_CMT.Text = (vDT.Rows[0]["OVERHEAD_CMT"] == null ? "" : vDT.Rows[0]["OVERHEAD_CMT"].ToString());
                txt_hLABOR_CMT.Text = vDT.Rows[0]["LABOR_CMT"] == null ? "" : vDT.Rows[0]["LABOR_CMT"].ToString();
            }

            TextToCurrency(txt_hFORECAST);
            TextToCurrency(txt_hRETAIL_PRICE);
            TextToCurrency(txt_hTARGET_FOB);
        }

        private void DisplayCBDDetail(DataTable vDT, COM.FSP grid)
        {
            grid.ClearAll();

            int iRefCol = FindCol(grid, "REF");
            int iSingleYNCol = FindCol(grid, "SINGLE_YN");

            if (vDT != null && vDT.Rows.Count > 0)
            {
                for (int i = 0; i < vDT.Rows.Count; i++)
                {
                    C1.Win.C1FlexGrid.Row row = grid.AddItem(vDT.Rows[i].ItemArray, grid.Rows.Count, 1);
                    if (!grid.Name.Equals(fgrid_labor.Name) && !grid.Name.Equals(fgrid_overhead.Name))
                    {
                        row.IsNode = true;
                        row.Node.Level = 0;
                        row.StyleNew.BackColor = Color.White;
                        row.AllowEditing = true;
                    }

                    if (iRefCol > 0)
                    {
                        string sRef = row[iRefCol] == null ? "" : row[iRefCol].ToString();
                        C1.Win.C1FlexGrid.CellRange vRange = grid.GetCellRange(row.Index, iRefCol);
                        vRange.UserData = sRef;

                        if (sRef.Equals("D"))
                        {
                            row.StyleNew.ForeColor = Color.Red;
                        }
                        else if (sRef.Equals("A"))
                        {
                            row.StyleNew.ForeColor = Color.Green;
                        }
                        else if (sRef.Equals("U"))
                        {
                            //row.StyleNew.Font = new Font(row.StyleNew.Font.FontFamily, row.StyleNew.Font.Size, FontStyle.Bold);
                            row.StyleNew.BackColor = Color.Yellow;
                        }
                        else
                        {
                            if (iSingleYNCol > 0)
                            {
                                string sSingleYN = row[iSingleYNCol] == null ? "" : row[iSingleYNCol].ToString();
                                if (sSingleYN.Equals("Y"))
                                    row.StyleNew.Font = new Font(row.StyleNew.Font.FontFamily, row.StyleNew.Font.Size, FontStyle.Italic);

                            }
                            else
                            {
                                row.StyleNew.Font = new Font(row.StyleNew.Font.FontFamily, row.StyleNew.Font.Size, FontStyle.Regular);
                                row.StyleNew.ForeColor = Color.Black;
                            }
                        }
                    }
                }

                vDT.Dispose();
            }
        }

        private void DisplayBOMHead(DataTable vDT)
        {
            if (vDT != null && vDT.Rows.Count == 1)
            {
                for (int iCIdx = 0; iCIdx < vDT.Rows[0].ItemArray.Length; iCIdx++)
                {
                    string sColName = vDT.Columns[iCIdx].ColumnName;

                    if (pnl_head.Controls["txt_h" + sColName] != null)
                    {
                        TextBox vTxt = pnl_head.Controls["txt_h" + sColName] as TextBox;
                        vTxt.Text = vDT.Rows[0][iCIdx].ToString();
                        vTxt.Tag = vDT.Rows[0][iCIdx].ToString();
                    }
                    else if (pnl_head.Controls["cmb_h" + sColName] != null)
                    {
                        C1.Win.C1List.C1Combo vCmb = pnl_head.Controls["cmb_h" + sColName] as C1.Win.C1List.C1Combo;
                        vCmb.SelectedValue = vDT.Rows[0][iCIdx].ToString();
                    }
                    else if (pnl_head.Controls["dpick_h" + sColName] != null)
                    {
                        DateTimePicker vDPK = pnl_head.Controls["dpick_h" + sColName] as DateTimePicker;

                        if (vDT.Rows[0][iCIdx] != null && vDT.Rows[0][iCIdx].ToString().Length == 8)
                        {
                            string sAppDate = vDT.Rows[0][iCIdx].ToString();
                            string sAppYear = sAppDate.Substring(0, 4);
                            string sAppMonth = sAppDate.Substring(4, 2);
                            string sAppDay = sAppDate.Substring(6, 2);

                            DateTime vAppDate = new DateTime(Convert.ToInt32(sAppYear), Convert.ToInt32(sAppMonth), Convert.ToInt32(sAppDay));
                            vDPK.Value = vAppDate;
                        }
                        else
                        {
                            vDPK.Value = System.DateTime.Now;
                        }
                    }
                    else if (pnl_CBDDetailSummary.Controls["txt_h" + sColName] != null)
                    {
                        TextBox vTxt = pnl_CBDDetailSummary.Controls["txt_h" + sColName] as TextBox;
                        vTxt.Text = vDT.Rows[0][iCIdx].ToString();
                    }
                }

                Display5523();
                DisplayMEF();
            }
        }

        private void DisplayBOMDetail(DataTable vDT, COM.FSP grid, bool clear)
        {
            if (clear)
                grid.ClearAll();

            int iRefCol = FindCol(grid, "REF");
            int iSingleYNCol = FindCol(grid, "SINGLE_YN");
            int iCBDNo = 1;

            if (vDT != null && vDT.Rows.Count > 0)
            {
                for (int i = 0; i < vDT.Rows.Count; i++)
                {
                    C1.Win.C1FlexGrid.Row row = grid.AddItem(vDT.Rows[i].ItemArray, grid.Rows.Count, 1);
                    if (!grid.Name.Equals(fgrid_labor.Name) && !grid.Name.Equals(fgrid_overhead.Name))
                    {
                        row.IsNode = true;

                        string sLev = row[(int)ClassLib.TBSFX_CBD_TAIL.IxLEVEL].ToString();
                        row.Node.Level = Convert.ToInt32(sLev);

                        if (row.Node.Level == 0)
                        {
                            row[(int)ClassLib.TBSFX_CBD_TAIL.IxBOM_NO] = _BOMNo++;
                            row[(int)ClassLib.TBSFX_CBD_TAIL.IxCBD_NO] = iCBDNo++;
                            row[(int)ClassLib.TBSFX_CBD_TAIL.IxCBD_NO_VIEW] = _OrderBy++;
                            row.StyleNew.BackColor = Color.White;
                            row.AllowEditing = true;
                            row[0] = "I";
                        }
                        else
                        {
                            row.StyleNew.BackColor = Color.LightGray;
                            grid.GetCellRange(row.Index, 1, row.Index, grid.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
                            row.AllowEditing = false;
                        }
                    }
                    else
                    {
                        row[0] = "I";
                    }

                    if (iRefCol > 0)
                    {
                        string sRef = row[iRefCol] == null ? "" : row[iRefCol].ToString();
                        C1.Win.C1FlexGrid.CellRange vRange = grid.GetCellRange(row.Index, iRefCol);
                        vRange.UserData = sRef;

                        if (sRef.Equals("D"))
                        {
                            row.StyleNew.ForeColor = Color.Red;
                        }
                        else if (sRef.Equals("A"))
                        {
                            row.StyleNew.ForeColor = Color.Green;
                        }
                        else if (sRef.Equals("U"))
                        {
                            row.StyleNew.Font = new Font(row.StyleNew.Font.FontFamily, row.StyleNew.Font.Size, FontStyle.Bold);
                        }
                        else
                        {

                            if (iSingleYNCol > 0)
                            {
                                string sSingleYN = row[iSingleYNCol] == null ? "" : row[iSingleYNCol].ToString();
                                if (sSingleYN.Equals("Y"))
                                    row.StyleNew.Font = new Font(row.StyleNew.Font.FontFamily, row.StyleNew.Font.Size, FontStyle.Italic);

                            }
                            else
                            {
                                row.StyleNew.Font = new Font(row.StyleNew.Font.FontFamily, row.StyleNew.Font.Size, FontStyle.Regular);
                                row.StyleNew.ForeColor = Color.Black;
                            }
                        }
                    }
                }

                vDT.Dispose();
            }

            Display5523();
            DisplayMEF();
        }
 
        private void DisplayBOMDetailTree(COM.FSP vFSP, int iSelRow)
        {
            if (iSelRow == -1)
            {
                for (int iRow = vFSP.Rows.Fixed; iRow < vFSP.Rows.Count; iRow++)
                {
                    if (vFSP.Rows[iRow].Node.Children > 0 && !vFSP.Name.Equals(fgrid_packaging.Name))
                    {
                        // CBD_CLASS 강제 적용
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS] = vFSP[iRow + 1, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS];

                        for (int iCol = (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT; iCol < vFSP.Cols.Count; iCol++)
                        {
                            if (iCol != (int)ClassLib.TBSFX_CBD_TAIL.IxCURR && iCol != (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE)
                                vFSP[iRow, iCol] = vFSP[iRow + 1, iCol];
                        }

                        string sMatPrice = vFSP[iRow + 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE] == null ? "0" : vFSP[iRow + 1, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE].ToString();
                        string sExtraCharge = vFSP[iRow + 1, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE] == null ? "0" : vFSP[iRow + 1, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE].ToString();
                        double dMatPrice = 0, dExtraCharge = 0;
                        double.TryParse(sMatPrice, out dMatPrice);
                        double.TryParse(sExtraCharge, out dExtraCharge);

                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE] = dMatPrice + dExtraCharge;
                    }

                    if (vFSP.Rows[iRow].Node.Level == 0)
                    {
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxORDER_BY] = _OrderBy++;
                    }
                }

                vFSP.Tree.Show(0);
            }
            else if (vFSP.Col == (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE || vFSP.Col == (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE)
            {
                if (vFSP.Rows[iSelRow].Node.Level == 1)
                {
                    int iRow = vFSP.Rows[iSelRow].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent).Row.Index;

                    if (vFSP.Rows[iRow].Node.Children > 0)
                    {
                        for (int iCol = (int)ClassLib.TBSFX_CBD_TAIL.IxVEN_NAME; iCol < vFSP.Cols.Count; iCol++)
                        {
                            if (iCol != (int)ClassLib.TBSFX_CBD_TAIL.IxCURR && iCol != (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE)
                                vFSP[iRow, iCol] = vFSP[iSelRow, iCol];
                        }

                        double dUnitPrice = Convert.ToDouble(vFSP[iSelRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE].ToString());
                        if (vFSP.Col == (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE)
                        {
                            vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE] = dUnitPrice;
                            vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT] = "";

                        }
                        else if (vFSP.Col == (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE)
                        {
                            double dLoss = Convert.ToDouble(vFSP[iSelRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE].ToString());
                            vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE] = dUnitPrice + dLoss;
                            vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT] = vFSP[iSelRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT];
                        }

                        if (vFSP.Name.Equals(fgrid_upper.Name))
                            CalcUpper(iRow, iRow);
                        if (vFSP.Name.Equals(fgrid_packaging.Name))
                            CalcPackaging(iRow, iRow);
                        if (vFSP.Name.Equals(fgrid_midsole.Name))
                            CalcMidsole(iRow, iRow);
                        if (vFSP.Name.Equals(fgrid_outsole.Name))
                            CalcOutsole(iRow, iRow);

                        CalcETCSummary();
                        CalcSummary();
                        CalcSummaryPersent();
                    }
                }
            }
        }

        public void DisplayFXRate(DataTable vDT)
        {
            for (int iIdx = pnl_head.Controls.Count - 1; iIdx >= 0; iIdx--)
            {
                if (pnl_head.Controls[iIdx] is TextBox)
                {
                    if (pnl_head.Controls[iIdx].Name.StartsWith("txt_hCURR_CD_") ||
                        pnl_head.Controls[iIdx].Name.StartsWith("txt_hFX_RATE_") ||
                        pnl_head.Controls[iIdx].Name.StartsWith("txt_hCOUNTRY_") ||
                        pnl_head.Controls[iIdx].Name.StartsWith("txt_hNON_FX_RATE"))
                        pnl_head.Controls.RemoveAt(iIdx);
                }
            }

            if (vDT != null && vDT.Rows.Count > 0)
            {
                Label vLblCurr = lbl_hCurr;
                Label vFXRate = lbl_hFXRate;
                Label vCountry = lbl_hCountry;

                if (vDT.Columns.Contains("STATUS"))
                    txt_hCBD_STAGE.Text = vDT.Rows[0]["STATUS"] == null ? "Initial" : vDT.Rows[0]["STATUS"].ToString();

                for (int iRIdx = 0; iRIdx < vDT.Rows.Count; iRIdx++)
                {
                    TextBox vTxtCurr = new TextBox();
                    vTxtCurr.Font = txt_hMODEL_ID.Font;
                    vTxtCurr.Size = vLblCurr.Size;
                    vTxtCurr.BorderStyle = BorderStyle.None;
                    vTxtCurr.ReadOnly = true;
                    vTxtCurr.BackColor = Color.WhiteSmoke;
                    vTxtCurr.TextAlign = HorizontalAlignment.Center;
                    vTxtCurr.Name = "txt_hCURR_CD_" + vDT.Rows[iRIdx]["CURR"].ToString();
                    vTxtCurr.Location = new Point(vLblCurr.Left, vLblCurr.Bottom + ((vLblCurr.Height * iRIdx) + (iRIdx + 1)));

                    TextBox vTxtFXRate = new TextBox();
                    vTxtFXRate.Font = txt_hMODEL_ID.Font;
                    vTxtFXRate.Size = vFXRate.Size;
                    vTxtFXRate.BorderStyle = BorderStyle.None;
                    vTxtFXRate.TextAlign = HorizontalAlignment.Right;
                    //vTxtFXRate.ReadOnly = true;
                    vTxtFXRate.BackColor = Color.White;
                    vTxtFXRate.Name = "txt_hFX_RATE_" + vDT.Rows[iRIdx]["CURR"].ToString();
                    vTxtFXRate.Location = new Point(vFXRate.Left, vFXRate.Bottom + ((vFXRate.Height * iRIdx) + (iRIdx + 1)));

                    TextBox vTxtCountry = new TextBox();
                    vTxtCountry.Font = txt_hMODEL_ID.Font;
                    vTxtCountry.Size = vCountry.Size;
                    vTxtCountry.BorderStyle = BorderStyle.None;
                    vTxtCountry.ReadOnly = true;
                    vTxtCountry.BackColor = Color.WhiteSmoke;
                    vTxtCountry.TextAlign = HorizontalAlignment.Center;
                    vTxtCountry.Name = "txt_hCOUNTRY_" + vDT.Rows[iRIdx]["CURR"].ToString();
                    vTxtCountry.Location = new Point(vCountry.Left, vCountry.Bottom + ((vCountry.Height * iRIdx) + (iRIdx + 1)));

                    vTxtCurr.Text = vDT.Rows[iRIdx]["CURR"] == null ? "" : vDT.Rows[iRIdx]["CURR"].ToString();
                    vTxtFXRate.Text = vDT.Rows[iRIdx]["FX_RATE"] == null ? "" : vDT.Rows[iRIdx]["FX_RATE"].ToString();
                    vTxtCountry.Text = vDT.Rows[iRIdx]["COUNTRY"] == null ? "" : vDT.Rows[iRIdx]["COUNTRY"].ToString();

                    pnl_head.Controls.Add(vTxtCurr);
                    pnl_head.Controls.Add(vTxtFXRate);
                    pnl_head.Controls.Add(vTxtCountry);
                }
            }
            else
            {
                Label vLblCurr = lbl_hCurr;

                TextBox vTxtCurr = new TextBox();
                vTxtCurr.Font = txt_hMODEL_ID.Font;
                vTxtCurr.Size = new Size(vLblCurr.Width * 3 + 2, vLblCurr.Height);
                vTxtCurr.BorderStyle = BorderStyle.FixedSingle;
                vTxtCurr.Name = "txt_hNON_FX_RATE";
                vTxtCurr.Location = new Point(vLblCurr.Left, vLblCurr.Bottom + 1);

                pnl_head.Controls.Add(vTxtCurr);
            }
        }

        //private void Display5523Reason()
        //{
        //    if (cmb_hPROD_FAC.SelectedValue == null)
        //        return;

        //    string sFactory = cmb_hPROD_FAC.SelectedValue.ToString();
        //    string sStyle = txt_hSTYLE_CD.Text;
        //    string sMOID = txt_hMOID.Text;
        //    string sBOMID = txt_hCBD_ID.Text;
        //    string sFobType = cmb_hROUND_CD.SelectedText;

        //    System.Data.DataTable vDT = SELECT_EBM_FOB_DETAIL_REGION(sFactory, sStyle, sMOID, sBOMID, sFobType);
        //    if (vDT != null && vDT.Rows.Count > 0)
        //    {
        //        ClassLib.ComFunction.Set_ComboList(vDT, cmb_region, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
        //        cmb_region.SelectedValue = "US";

        //        if (cmb_region.SelectedIndex == -1)
        //            cmb_region.SelectedIndex = vDT.Rows.Count > 0 ? 0 : -1;
        //    }
        //    else
        //    {
        //        cmb_region.SelectedIndex = -1;
        //    }
        //}

        #endregion

        #endregion

        #endregion

        #region button and etc event process

        //private void Display_Grid_5523(System.Data.DataTable arg_dt)
        //{
        //    fgrid_5523.ClearAll();
        //    fgrid_5523.Cols.Count = fgrid_5523.Cols.Frozen;
        //    txt_prodCode_5523.Text = ""; txt_devCode_5523.Text = ""; txt_prodName_5523.Text = "";
        //    txt_prodType_5523.Text = ""; txt_factory_5523.Text = ""; txt_season_5523.Text = "";
        //    txt_date_5523.Text = "";
        //    txt_leather_5523.Text = ""; txt_synthetic_5523.Text = ""; txt_textile_5523.Text = "";
        //    txt_other_5523.Text = "";

        //    if (arg_dt.Rows.Count == 0)
        //        return;

        //    string sTBOM = "";
        //    string sTStyle = "";

        //    for (int i = 0; i < arg_dt.Rows.Count; i++)
        //    {
        //        // Set header
        //        if (i == 0)
        //        {
        //            txt_prodCode_5523.Text = arg_dt.Rows[i]["prod_code"].ToString();
        //            txt_devCode_5523.Text = arg_dt.Rows[i]["dev_code"].ToString();
        //            txt_prodName_5523.Text = arg_dt.Rows[i]["prod_name"].ToString();
        //            txt_prodType_5523.Text = arg_dt.Rows[i]["prod_type"].ToString();
        //            txt_factory_5523.Text = arg_dt.Rows[i]["factory"].ToString();
        //            txt_season_5523.Text = arg_dt.Rows[i]["season_cd"].ToString();
        //            txt_date_5523.Text = arg_dt.Rows[i]["app_ymd"].ToString();

        //            txt_leather_5523.Text = arg_dt.Rows[i]["leather_pct"].ToString();
        //            txt_synthetic_5523.Text = arg_dt.Rows[i]["synthetic_pct"].ToString();
        //            txt_textile_5523.Text = arg_dt.Rows[i]["textile_pct"].ToString();
        //            txt_other_5523.Text = arg_dt.Rows[i]["other_pct"].ToString();

        //            string sBOM = arg_dt.Rows[i]["bom_id"].ToString();
        //            string sStyle = arg_dt.Rows[i]["style_cd"].ToString();

        //            C1.Win.C1FlexGrid.Column col = fgrid_5523.Cols.Add();
        //            col.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
        //            col[fgrid_5523.Rows.Fixed - 1] = sStyle;
        //            col[fgrid_5523.Rows.Fixed - 2] = sBOM;

        //            for (int ii = i; ii < arg_dt.Rows.Count; ii++, i++)
        //            {
        //                sTBOM = arg_dt.Rows[ii]["bom_id"].ToString();
        //                sTStyle = arg_dt.Rows[ii]["style_cd"].ToString();
        //                if (!sBOM.Equals(sTBOM) && !sStyle.Equals(sTStyle))
        //                {
        //                    i = ii;
        //                    break;
        //                }

        //                C1.Win.C1FlexGrid.Row row = fgrid_5523.Rows.Add();
        //                row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxSEQ] = arg_dt.Rows[ii]["seq"];
        //                row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxCOMP_DIV] = arg_dt.Rows[ii]["comp_div"];
        //                row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxCOMP_NAME] = arg_dt.Rows[ii]["comp_name"];
        //                row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxMEASUAL_DATA] = arg_dt.Rows[ii]["measual_data"];
        //                row[col.Index] = arg_dt.Rows[ii]["bom_comp_read"];
        //            }
        //        }
        //        else
        //        {
        //            int iRow = fgrid_5523.Rows.Fixed;
        //            string sBOM2 = arg_dt.Rows[i]["bom_id"].ToString();
        //            string sStyle2 = arg_dt.Rows[i]["style_cd"].ToString();

        //            C1.Win.C1FlexGrid.Column col2 = fgrid_5523.Cols.Add();
        //            col2[fgrid_5523.Rows.Fixed - 1] = sStyle2;
        //            col2[fgrid_5523.Rows.Fixed - 2] = sBOM2;

        //            for (int ii = i; ii < arg_dt.Rows.Count; ii++)
        //            {
        //                sTBOM = arg_dt.Rows[ii]["bom_id"].ToString();
        //                sTStyle = arg_dt.Rows[ii]["style_cd"].ToString();
        //                if (sBOM2.Equals(sTBOM) && sStyle2.Equals(sTStyle))
        //                {
        //                    i = ii;
        //                    break;
        //                }

        //                fgrid_5523[iRow, (int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxMEASUAL_DATA] = arg_dt.Rows[ii]["measual_data"];
        //                fgrid_5523[iRow, col2.Index] = arg_dt.Rows[ii]["bom_comp_read"];
        //            }
        //        }
        //    }
        //}

        //private void Display5523()
        //{
        //    string sRegion = ClassLib.ComFunction.Empty_Combo(cmb_region, "");
        //    if (!sRegion.Equals(""))
        //    {
        //        string sFactory = cmb_hPROD_FAC.SelectedValue.ToString();
        //        string sStyle = txt_hSTYLE_CD.Text;

        //        string sMOID = txt_hMOID.Text;
        //        string sBOMID = txt_hCBD_ID.Text;
        //        string sFobType = cmb_hROUND_CD.SelectedText;
        //        //string sRound = sFobType.Equals("CFM") ? "Prod" : "Etc";
        //        string sRound = "Etc";

        //        System.Data.DataTable vDT = _ComFnc.SELECT_EBM_FOB_5523(sFactory, sStyle, sRegion, sMOID, sBOMID, sFobType, sRound);

        //        if (vDT != null)
        //        {
        //            DisplayGrid5523(vDT);
        //        }
        //    }
        //}

        private void Display5523()
        {
            fgrid_5523.ClearAll();
            fgrid_5523.Cols.Count = fgrid_5523.Cols.Frozen;
            txt_prodCode_5523.Text = ""; txt_devCode_5523.Text = ""; txt_prodName_5523.Text = "";
            txt_prodType_5523.Text = ""; txt_factory_5523.Text = ""; txt_season_5523.Text = "";
            txt_date_5523.Text = "";
            txt_leather_5523.Text = ""; txt_synthetic_5523.Text = ""; txt_textile_5523.Text = "";
            txt_other_5523.Text = "";

            string sSFactory = ClassLib.ComFunction.Empty_Combo(cmb_hDEV_FAC, "");
            string sSProdFac = ClassLib.ComFunction.Empty_Combo(cmb_hPROD_FAC, "");
            string sSRegion = ClassLib.ComFunction.Empty_Combo(cmb_region, "");
            string sSStyle = txt_hSTYLE_CD.Text.Replace("-", "").Trim();

            if (!sSFactory.Equals("") && !sSRegion.Equals(""))
            {
                string sSMOID = txt_hMOID.Text.Replace("-", "").Trim();
                string sSSeason = cmb_hSEASON_CD.SelectedValue.ToString();
                string sSBOMID = txt_hBOM_ID.Text;
                string sSRound = cmb_hROUND_CD.SelectedValue.ToString();

                //System.Data.DataTable vDT = _ComFnc.SELECT_SFX_CBD_M_5523(sSFactory, sSMOID, sSRegion, sSSeason, sSBOMID, sSRound);
                System.Data.DataTable vDT = _ComFnc.SELECT_EBM_FOB_5523(sSFactory, sSProdFac, sSStyle, sSRegion, sSMOID, sSBOMID, sSRound, sSSeason);

                if (vDT != null && vDT.Rows.Count > 0)
                {
                    string sTBOM = "";
                    string sTStyle = "";

                    for (int i = 0; i < vDT.Rows.Count; i++)
                    {
                        // Set header
                        if (i == 0)
                        {
                            txt_prodCode_5523.Text = vDT.Rows[i]["product_code"].ToString();
                            txt_devCode_5523.Text = vDT.Rows[i]["dev_code"].ToString();
                            txt_prodName_5523.Text = vDT.Rows[i]["product_name"].ToString();
                            txt_prodType_5523.Text = vDT.Rows[i]["product_type"].ToString();
                            txt_factory_5523.Text = vDT.Rows[i]["factory"].ToString();
                            txt_season_5523.Text = vDT.Rows[i]["season_cd"].ToString();
                            txt_date_5523.Text = vDT.Rows[i]["app_ymd"].ToString();

                            txt_leather_5523.Text = vDT.Rows[i]["leather_pct"].ToString();
                            txt_synthetic_5523.Text = vDT.Rows[i]["synthetic_pct"].ToString();
                            txt_textile_5523.Text = vDT.Rows[i]["textile_pct"].ToString();
                            txt_other_5523.Text = vDT.Rows[i]["other_pct"].ToString();

                            string sBOM = vDT.Rows[i]["bom_id"].ToString();
                            string sStyle = vDT.Rows[i]["style_cd"].ToString();

                            C1.Win.C1FlexGrid.Column col = fgrid_5523.Cols.Add();
                            col.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
                            col[fgrid_5523.Rows.Fixed - 1] = sStyle;
                            col[fgrid_5523.Rows.Fixed - 2] = sBOM;

                            for (int ii = i; ii < vDT.Rows.Count; ii++, i++)
                            {
                                sTBOM = vDT.Rows[ii]["bom_id"].ToString();
                                sTStyle = vDT.Rows[ii]["style_cd"].ToString();
                                if (!sBOM.Equals(sTBOM) && !sStyle.Equals(sTStyle))
                                {
                                    i = ii;
                                    break;
                                }

                                C1.Win.C1FlexGrid.Row row = fgrid_5523.Rows.Add();
                                row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxSEQ] = vDT.Rows[ii]["component_seq"];
                                row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxCOMP_DIV] = vDT.Rows[ii]["component_div"];
                                row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxCOMP_NAME] = vDT.Rows[ii]["components"];
                                row[(int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxMEASUAL_DATA] = vDT.Rows[ii]["measurement"];
                                row[col.Index] = vDT.Rows[ii]["material_style"];
                            }
                        }
                        else
                        {
                            int iRow = fgrid_5523.Rows.Fixed;
                            string sBOM2 = vDT.Rows[i]["bom_id"].ToString();
                            string sStyle2 = vDT.Rows[i]["style_cd"].ToString();

                            C1.Win.C1FlexGrid.Column col2 = fgrid_5523.Cols.Add();
                            col2[fgrid_5523.Rows.Fixed - 1] = sStyle2;
                            col2[fgrid_5523.Rows.Fixed - 2] = sBOM2;

                            for (int ii = i; ii < vDT.Rows.Count; ii++)
                            {
                                sTBOM = vDT.Rows[ii]["bom_id"].ToString();
                                sTStyle = vDT.Rows[ii]["style_cd"].ToString();
                                if (sBOM2.Equals(sTBOM) && sStyle2.Equals(sTStyle))
                                {
                                    i = ii;
                                    break;
                                }

                                fgrid_5523[iRow, (int)ClassLib.TBEBM_FOB_5523_TAIL_2.IxMEASUAL_DATA] = vDT.Rows[ii]["measurement"];
                                fgrid_5523[iRow, col2.Index] = vDT.Rows[ii]["material_style"];
                            }
                        }
                    }
                }
            }
        }

        private void btn_5523_Click(object sender, EventArgs e)
        {
            try
            {
                FlexCosting.Management.Costing.Frm.ExcelUpload_5523 uploader = new FlexCosting.Management.Costing.Frm.ExcelUpload_5523();
                uploader.Round = " ";

                uploader.WindowState = FormWindowState.Normal;
                uploader.ShowDialog();

                if (cmb_hDEV_FAC.SelectedValue != null)
                    Display5523();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "5523", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_meof_Click(object sender, EventArgs e)
        {
            try
            {
                FlexCosting.Management.Costing.Frm.ExcelUpload_MEOF uploader = new FlexCosting.Management.Costing.Frm.ExcelUpload_MEOF();
                uploader.WindowState = FormWindowState.Normal;
                uploader.ShowDialog();
                
                if (cmb_hDEV_FAC.SelectedValue != null)
                    DisplayMEF();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "MEOF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region grid event process

        #region Material search

        private void SelectMaterial(COM.FSP vFSP)
        {
            int iRow = vFSP.Row, iCol = vFSP.Col;

            if (iCol == (int)ClassLib.TBSFX_CBD_TAIL.IxVEN_NAME ||
                iCol == (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_CD ||
                iCol == (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME)
            {
                if (vFSP.Rows[iRow].Node.Level == 0)
                {
                    // "0. MAT_CD", "1. MAT_NAME", "2. UOM", "3. FRT_TRM", "4. FOB", "5. CURR", "6. MAT_UPRICE", "7. VEN_NAME", "8. VEN_CD", "9. LOSS_PCT, 10. SPECIAL_OPTION"
                    COM.ComVar.Parameter_PopUp = new string[10];
                    COM.ComVar.Parameter_PopUp[0] = vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_CD] == null ? "" : vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_CD].ToString();
                    COM.ComVar.Parameter_PopUp[1] = vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME] == null ? "" : vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME].ToString();
                    COM.ComVar.Parameter_PopUp[2] = vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUOM] == null ? "" : vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUOM].ToString();
                    COM.ComVar.Parameter_PopUp[3] = vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM] == null ? "" : vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM].ToString();
                    COM.ComVar.Parameter_PopUp[4] = vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT] == null ? "" : vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT].ToString();
                    COM.ComVar.Parameter_PopUp[5] = vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCURR] == null ? "" : vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCURR].ToString();
                    COM.ComVar.Parameter_PopUp[6] = vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE] == null ? "0" : vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE].ToString();
                    COM.ComVar.Parameter_PopUp[7] = vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxVEN_NAME] == null ? "" : vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxVEN_NAME].ToString();
                    COM.ComVar.Parameter_PopUp[8] = vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxVEN_CD] == null ? "" : vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxVEN_CD].ToString();
                    COM.ComVar.Parameter_PopUp[9] = vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxLOSS_PCT] == null ? "0" : vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxLOSS_PCT].ToString();

                    FlexCosting.Management.Costing.Pop.Pop_CBD_Master_Mat vPop = new FlexCosting.Management.Costing.Pop.Pop_CBD_Master_Mat();

                    switch (vFSP.Col)
                    {
                        case (int)ClassLib.TBSFX_CBD_TAIL.IxVEN_NAME:
                            vPop.CustName = vFSP[iRow, iCol] == null ? "" : vFSP[iRow, iCol].ToString();
                            break;
                        case (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_CD:
                            vPop.MatCode = vFSP[iRow, iCol] == null ? "" : vFSP[iRow, iCol].ToString();
                            break;
                        case (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME:
                            vPop.MatName = vFSP[iRow, iCol] == null ? "" : vFSP[iRow, iCol].ToString();
                            break;
                    }

                    vPop.Size = new Size((int)(vPop.Width + (vPop.Width * 0.3)), (int)(vPop.Height + (vPop.Height * 0.3)));
                    if (vPop.ShowDialog() == DialogResult.OK)
                    {
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_CD] = COM.ComVar.Parameter_PopUp[0];
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_NAME] = COM.ComVar.Parameter_PopUp[1];
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUOM] = COM.ComVar.Parameter_PopUp[2];
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFRT_TRM] = COM.ComVar.Parameter_PopUp[3];
                        if (COM.ComVar.Parameter_PopUp[3].Trim().Equals("") || COM.ComVar.Parameter_PopUp[3].Trim().Equals("FOB"))
                            vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT] = 3;
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT] = COM.ComVar.Parameter_PopUp[4];
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCURR] = COM.ComVar.Parameter_PopUp[5];
                        Control vCtl = pnl_head.Controls["txt_hFX_RATE_" + COM.ComVar.Parameter_PopUp[5]];
                        if (vCtl != null)
                            vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE] = vCtl.Text;
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE] = COM.ComVar.Parameter_PopUp[6];
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxVEN_NAME] = COM.ComVar.Parameter_PopUp[7];
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxVEN_CD] = COM.ComVar.Parameter_PopUp[8];
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxLOSS_PCT] = COM.ComVar.Parameter_PopUp[9];
                        vFSP[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_COMMENT] = COM.ComVar.Parameter_PopUp[10];
                        vFSP.Update_Row(iRow);

                        if (vFSP.Name.Equals(fgrid_upper.Name))
                            CalcUpper(iRow, iRow);
                        else if (vFSP.Name.Equals(fgrid_packaging.Name))
                            CalcPackaging(iRow, iRow);
                        else if (vFSP.Name.Equals(fgrid_midsole.Name))
                            CalcMidsole(iRow, iRow);
                        else if (vFSP.Name.Equals(fgrid_outsole.Name))
                            CalcOutsole(iRow, iRow);

                        CalcETCSummary();
                        CalcSummary();
                        CalcSummaryPersent();
                    }
                }
            }
        }

        private void DisplayMEF()
        {
            try
            {
                if (cmb_hPROD_FAC.SelectedValue != null)
                {
                    fgrid_pm_meof_head.Size = new Size(Convert.ToInt32(tabControl1.Width * 0.15), fgrid_pm_meof_head.Height);
                    fgrid_pm_meof_size.Size = new Size(Convert.ToInt32(tabControl1.Width * 0.15), fgrid_pm_meof_size.Height);

                    //if (fgrid_prodMold.Rows.Fixed < fgrid_prodMold.Rows.Count &&
                    //    fgrid_prodMold.Row >= fgrid_prodMold.Rows.Fixed)
                    //{
                    string sFactory = cmb_hPROD_FAC.SelectedValue.ToString();
                    string sMOID = txt_hMOID.Text.Replace("-", "");

                    DisplayMEOFHead(fgrid_pm_meof_head, fgrid_pm_meof_size, sFactory, sMOID);
                    //}
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Sample mold click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMEOFHead(COM.FSP fgrid_meof_head, COM.FSP fgrid_meof_size, string sFactory, string sMOID)
        {
            try
            {
                fgrid_meof_head.ClearAll();
                fgrid_meof_size.ClearAll();

                System.Data.DataTable vDDT = SELECT_EBM_FOB_MEOF_HEAD(sFactory, sMOID);
                System.Data.DataTable vHDT = MyOraDB.Select_GridHead("EBM_FOB_MEOF_HEAD", "4");

                if (vDDT != null && vHDT != null)
                {
                    for (int iDIdx = 0; iDIdx < vDDT.Rows.Count; iDIdx++)
                    {
                        for (int iDCol = 0, iHIdx = 0; iDCol < vDDT.Rows[iDIdx].ItemArray.Length; iDCol++, iHIdx++)
                        {
                            C1.Win.C1FlexGrid.Row newRow = fgrid_meof_head.Rows.Add();
                            newRow[1] = vHDT.Rows[iHIdx]["head_desc1"];
                            newRow[2] = vDDT.Rows[iDIdx][iDCol];

                            newRow.IsNode = true;

                            if (iDCol == 0)
                            {
                                newRow.Node.Level = 0;
                                newRow.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
                            }
                            else
                            {
                                newRow.Node.Level = 1;
                                newRow.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
                            }
                        }
                    }

                    fgrid_meof_head.Tree.Column = 1;
                    fgrid_meof_head.Tree.Show(0);
                    fgrid_meof_head.ExtendLastCol = true;
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "MEOF Head", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMEOFSize(COM.FSP fgrid_meof_head, COM.FSP fgrid_meof_size)
        {
            try
            {
                if (fgrid_meof_head.Rows.Fixed < fgrid_meof_head.Rows.Count &&
                    fgrid_meof_head.Row >= fgrid_meof_head.Rows.Fixed)
                {
                    fgrid_meof_size.ClearAll();

                    string sFactory = cmb_hPROD_FAC.SelectedValue.ToString();
                    string sMOID = txt_hMOID.Text.Replace("-", "");

                    int iPRow = fgrid_meof_head.Rows[fgrid_meof_head.Row].Node.Row.Index;
                    if (fgrid_meof_head.Rows[fgrid_meof_head.Row].Node.Level > 0)
                        iPRow = fgrid_meof_head.Rows[fgrid_meof_head.Row].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent).Row.Index;

                    string sMoldCD = fgrid_meof_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_4.IxMOLD_CD + (iPRow - 1), 2].ToString();
                    string sPIMSeq = fgrid_meof_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_4.IxPIM_SEQ + (iPRow - 1), 2].ToString();

                    DataTable vDT = SELECT_EBM_FOB_MEOF_SIZE(sFactory, sMOID, sMoldCD, sPIMSeq);

                    if (vDT != null && vDT.Rows.Count > 0)
                    {
                        fgrid_meof_size.Display_Grid(vDT, false);
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "MEOF size", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Part
        private void SelectPart(string arg_part_type, object arg_fsp, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            COM.FSP fsp = arg_fsp as COM.FSP;

            try
            {
                string sCurData = fsp[e.Row, e.Col] == null ? "" : fsp[e.Row, e.Col].ToString();

                DataTable vDT = null;
                if (!sCurData.Equals(""))
                    vDT = _ComFnc.SELECT_SXD_SRF_M_PART_LIST(cmb_hDEV_FAC.SelectedValue.ToString(), sCurData, arg_part_type);

                if (vDT == null || vDT.Rows.Count <= 0)
                {
                    foreach (int iRow in fsp.Selections)
                    {
                        fsp[iRow, FindCol(fsp, "PART_NO")] = "";
                        fsp[iRow, FindCol(fsp, "PART_SEQ")] = "";
                        fsp[iRow, FindCol(fsp, "PART_NAME")] = "";

                        fsp[iRow, e.Col] = sCurData;
                        fsp.Update_Row(iRow);
                    }
                    return;
                }

                _TypePopPart.ShowData(vDT);
                _TypePopPart.StartPosition = FormStartPosition.CenterScreen;

                if (_TypePopPart.ShowDialog() == DialogResult.OK)
                {
                    foreach (int iRow in fsp.Selections)
                    {
                        fsp[iRow, FindCol(fsp, "PART_NO")] = _TypePopPart.VRow[(int)ClassLib.TBSFM_CBD_PART_4.IxPART_NO];
                        fsp[iRow, FindCol(fsp, "PART_SEQ")] = _TypePopPart.VRow[(int)ClassLib.TBSFM_CBD_PART_4.IxPART_SEQ];
                        fsp[iRow, FindCol(fsp, "PART_NAME")] = _TypePopPart.VRow[(int)ClassLib.TBSFM_CBD_PART_4.IxPART_DESC];

                        fsp.Update_Row(iRow);
                    }
                }
                else
                {
                    fsp[e.Row, FindCol(fsp, "PART_NO")] = "";
                    fsp[e.Row, FindCol(fsp, "PART_SEQ")] = "";
                    fsp[e.Row, FindCol(fsp, "PART_NAME")] = "";

                    fsp[e.Row, e.Col] = sCurData;
                    fsp.Update_Row(e.Row);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Part", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fsp[e.Row, e.Col] = fsp.Buffer_CellData;
            }
        }

        private void TextToCurrency(TextBox vTB)
        {
            string sNum = vTB.Text.Replace(",", "");
            double dNum = 0;
            if (double.TryParse(sNum, out dNum))
            {
                if (vTB.Name.Equals(txt_hTARGET_FOB.Name) || vTB.Name.Equals(txt_hRETAIL_PRICE.Name))
                {
                    vTB.Text = String.Format("{0:#,##0.00}", dNum);
                }
                else
                {
                    vTB.Text = String.Format("{0:#,##0}", dNum);
                }
            }
        }

        #endregion

        #region Calculation

        #region 0. Exchange rate

        // Set FX RAte 
        private void SetFXRate(COM.FSP grid, int iStartRow, int iEndRow, int iCurr, int iFxRate)
        {
            try
            {
                iStartRow = iStartRow == -1 ? grid.Rows.Fixed : iStartRow;
                iEndRow = iEndRow == -1 ? grid.Rows.Count - 1 : iEndRow;

                for (int iRow = iStartRow; iRow <= iEndRow; iRow++)
                {
                    string sCurr = grid[iRow, iCurr] == null ? "" : grid[iRow, iCurr].ToString();
                    Control vCtl = pnl_head.Controls["txt_hFX_RATE_" + sCurr];

                    if (vCtl != null)
                    {
                        string sCurFxRate = grid[iRow, iFxRate] == null ? "" : grid[iRow, iFxRate].ToString();
                        grid[iRow, iFxRate] = vCtl.Text;

                        if (!sCurFxRate.Equals(vCtl.Text))
                            grid.Update_Row(iRow);
                    }
                    else
                        grid[iRow, iFxRate] = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region 1. UP, PACKAGING, MIDSOLE, OUTSOLE

        // 1-1. Upper
        private void CalcUpper(int iStartRow, int iEndRow)
        {
            try
            {
                double dSizeUpPct = 0;
                double.TryParse(txt_hSIZEUP_PCT.Text, out dSizeUpPct);

                iStartRow = iStartRow == -1 ? fgrid_upper.Rows.Fixed : iStartRow;
                iEndRow = iEndRow == -1 ? fgrid_upper.Rows.Count - 1 : iEndRow;

                for (int iRow = iStartRow; iRow <= iEndRow; iRow++)
                {
                    // FCT LND TOT
                    double dFxRate = fgrid_upper.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                    double dMatPrice = fgrid_upper.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE);
                    double dFCTLNDPCT = fgrid_upper.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT);
                    double dFCTLNDTOT = DoubleCheck(dMatPrice + (dMatPrice * (dFCTLNDPCT / 100)));
                    fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_TOT] = dFCTLNDTOT.ToString();

                    // FCT LND USD TOT
                    double dFCTLNDTOTUSD = DoubleCheck(dFCTLNDTOT / dFxRate);
                    fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_USD_TOT] = dFCTLNDTOTUSD.ToString();

                    // USAGE 
                    double dYield = fgrid_upper.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxYIELD, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxYIELD);
                    double dLossPCT = fgrid_upper.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxLOSS_PCT, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxLOSS_PCT);
                    double dUsage = DoubleCheck(dYield + (dYield * (dLossPCT / 100)));
                    fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSAGE] = dUsage.ToString();

                    // USD Cost
                    double dUSDCost = dFCTLNDTOTUSD * dUsage;
                    fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST] = dUSDCost.ToString();

                    // Sizing UP Charges
                    string sSizeYN = fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZE_EXC] == null ? "" : fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZE_EXC].ToString();
                    double dSizeUP = sSizeYN.Equals("Y") ? 0 : DoubleCheck(dUSDCost * (dSizeUpPct / 100));
                    fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE] = dSizeUP.ToString();

                    // Process charge
                    string sClass = fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS] == null ? "" : fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS].ToString();
                    fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE] = sClass.Equals("PC") ? dUSDCost.ToString() : "";
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "CalcUpper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 1-2. Packageing
        private void CalcPackaging(int iStartRow, int iEndRow)
        {
            try
            {
                double dSizeUpPct = 0;
                double.TryParse(txt_hSIZEUP_PCT.Text, out dSizeUpPct);

                iStartRow = iStartRow == -1 ? fgrid_packaging.Rows.Fixed : iStartRow;
                iEndRow = iEndRow == -1 ? fgrid_packaging.Rows.Count - 1 : iEndRow;

                for (int iRow = iStartRow; iRow <= iEndRow; iRow++)
                {
                    // FCT LND TOT
                    double dFxRate = fgrid_packaging.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                    double dMatPrice = fgrid_packaging.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE);
                    double dFCTLNDPCT = fgrid_packaging.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT);
                    double dFCTLNDTOT = DoubleCheck(dMatPrice + (dMatPrice * (dFCTLNDPCT / 100)));
                    fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_TOT] = dFCTLNDTOT.ToString();

                    // FCT LND USD TOT
                    double dFCTLNDTOTUSD = DoubleCheck(dFCTLNDTOT / dFxRate);
                    fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_USD_TOT] = dFCTLNDTOTUSD.ToString();

                    // USAGE 
                    double dYield = fgrid_packaging.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxYIELD, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxYIELD);
                    double dLossPCT = fgrid_packaging.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxLOSS_PCT, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxLOSS_PCT);
                    double dUsage = DoubleCheck(dYield + (dYield * (dLossPCT / 100)));
                    fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSAGE] = dUsage.ToString();

                    // USD Cost
                    double dUSDCost = dFCTLNDTOTUSD * dUsage;
                    fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST] = dUSDCost.ToString();

                    // Sizing UP Charges
                    string sSizeYN = fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZE_EXC] == null ? "" : fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZE_EXC].ToString();
                    double dSizeUP = sSizeYN.Equals("Y") ? 0 : DoubleCheck(dUSDCost * (dSizeUpPct / 100));
                    fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE] = dSizeUP.ToString();

                    // Process charge
                    string sClass = fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS] == null ? "" : fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS].ToString();
                    fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE] = sClass.Equals("PC") ? dUSDCost.ToString() : "";
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "CalcPackaging", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 1-3. Midsole 
        private void CalcMidsole(int iStartRow, int iEndRow)
        {
            try
            {
                double dSizeUpPct = 0;
                double.TryParse(txt_hSIZEUP_PCT.Text, out dSizeUpPct);

                iStartRow = iStartRow == -1 ? fgrid_midsole.Rows.Fixed : iStartRow;
                iEndRow = iEndRow == -1 ? fgrid_midsole.Rows.Count - 1 : iEndRow;

                for (int iRow = iStartRow; iRow <= iEndRow; iRow++)
                {
                    // FCT LND TOT
                    double dFxRate = fgrid_midsole.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                    double dMatPrice = fgrid_midsole.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE);
                    double dFCTLNDPCT = fgrid_midsole.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT);
                    double dFCTLNDTOT = DoubleCheck(dMatPrice + (dMatPrice * (dFCTLNDPCT / 100)));
                    fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_TOT] = dFCTLNDTOT.ToString();

                    // FCT LND USD TOT
                    double dFCTLNDTOTUSD = DoubleCheck(dFCTLNDTOT / dFxRate);
                    fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_USD_TOT] = dFCTLNDTOTUSD.ToString();

                    // USAGE 
                    double dYield = fgrid_midsole.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxYIELD, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxYIELD);
                    double dLossPCT = fgrid_midsole.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxLOSS_PCT, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxLOSS_PCT);
                    double dUsage = DoubleCheck(dYield + (dYield * (dLossPCT / 100)));
                    fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSAGE] = dUsage.ToString();

                    // USD Cost
                    double dUSDCost = dFCTLNDTOTUSD * dUsage;
                    fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST] = dUSDCost.ToString();

                    // Sizing UP Charges
                    string sSizeYN = fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZE_EXC] == null ? "" : fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZE_EXC].ToString();
                    double dSizeUP = sSizeYN.Equals("Y") ? 0 : DoubleCheck(dUSDCost * (dSizeUpPct / 100));
                    fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE] = dSizeUP.ToString();

                    // Process charge
                    string sClass = fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS] == null ? "" : fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS].ToString();
                    fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE] = sClass.Equals("PC") ? dUSDCost.ToString() : "";
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "CalcMidsole", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 1-4. Outsole 
        private void CalcOutsole(int iStartRow, int iEndRow)
        {
            try
            {
                double dSizeUpPct = 0;
                double.TryParse(txt_hSIZEUP_PCT.Text, out dSizeUpPct);

                iStartRow = iStartRow == -1 ? fgrid_outsole.Rows.Fixed : iStartRow;
                iEndRow = iEndRow == -1 ? fgrid_outsole.Rows.Count - 1 : iEndRow;

                for (int iRow = iStartRow; iRow <= iEndRow; iRow++)
                {
                    // FCT LND TOT
                    double dFxRate = fgrid_outsole.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                    double dMatPrice = fgrid_outsole.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxMAT_UPRICE);
                    double dFCTLNDPCT = fgrid_outsole.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_PCT);
                    double dFCTLNDTOT = DoubleCheck(dMatPrice + (dMatPrice * (dFCTLNDPCT / 100)));
                    fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_TOT] = dFCTLNDTOT.ToString();

                    // FCT LND USD TOT
                    double dFCTLNDTOTUSD = DoubleCheck(dFCTLNDTOT / dFxRate);
                    fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxFCT_LND_USD_TOT] = dFCTLNDTOTUSD.ToString();

                    // USAGE 
                    double dYield = fgrid_outsole.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxYIELD, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxYIELD);
                    double dLossPCT = fgrid_outsole.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxLOSS_PCT, iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxLOSS_PCT);
                    double dUsage = DoubleCheck(dYield + (dYield * (dLossPCT / 100)));
                    fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSAGE] = dUsage.ToString();

                    // USD Cost
                    double dUSDCost = dFCTLNDTOTUSD * dUsage;
                    fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST] = dUSDCost.ToString();

                    // Sizing UP Charges
                    string sSizeYN = fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZE_EXC] == null ? "" : fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZE_EXC].ToString();
                    double dSizeUP = sSizeYN.Equals("Y") ? 0 : DoubleCheck(dUSDCost * (dSizeUpPct / 100));
                    fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE] = dSizeUP.ToString();

                    // Process charge
                    string sClass = fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS] == null ? "" : fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS].ToString();
                    fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE] = sClass.Equals("PC") ? dUSDCost.ToString() : "";
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "CalcOutsole", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 1-5. Labor 
        private void CalcLabor(int iStartRow, int iEndRow)
        {
            try
            {
                iStartRow = iStartRow == -1 ? fgrid_labor.Rows.Fixed : iStartRow;
                iEndRow = iEndRow == -1 ? fgrid_labor.Rows.Count - 1 : iEndRow;

                for (int iRow = iStartRow; iRow <= iEndRow; iRow++)
                {
                    // Cost / STD Minute
                    double dWageYR = fgrid_labor.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxWAGE_YR,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxWAGE_YR);

                    double dDirtWorker = fgrid_labor.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxDIRT_WORKER,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxDIRT_WORKER);
                    double dDayPaidYR = fgrid_labor.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxDAY_PAID_YR,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxDAY_PAID_YR);
                    double dMinDayWorker = fgrid_labor.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxMIN_DAY_WORKER,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxMIN_DAY_WORKER);
                    double dEffctyRate = fgrid_labor.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxEFFCTV_RATE,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxEFFCTV_RATE);

                    double dCostSTD = DoubleCheck(dWageYR / (dDirtWorker * dDayPaidYR * dMinDayWorker * dEffctyRate));
                    fgrid_labor[iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCOST_STD] = dCostSTD;


                    // Cost / Pair ( LOCAL ) 
                    double dOVCost = fgrid_labor.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxOV_COST,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxOV_COST);
                    double dSTDMin = fgrid_labor.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxSTD_MIN,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxSTD_MIN);

                    double dCostLocal = dOVCost == 0 ? dCostSTD * dSTDMin : dOVCost;
                    fgrid_labor[iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCOST_LOCAL] = dCostLocal;


                    // Cost / Pair ( USD ) 
                    double dFXRate = fgrid_labor.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxFX_RATE,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxFX_RATE);

                    double dCostUSD = DoubleCheck((dOVCost > 0 && dFXRate > 0) ? dOVCost / dFXRate : dCostLocal / dFXRate);
                    fgrid_labor[iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCOST_USD] = dCostUSD;
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "CalcLabor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 1-6. Overhead 
        private void CalcOverhead(int iStartRow, int iEndRow)
        {
            try
            {
                iStartRow = iStartRow == -1 ? fgrid_overhead.Rows.Fixed : iStartRow;
                iEndRow = iEndRow == -1 ? fgrid_overhead.Rows.Count - 1 : iEndRow;

                for (int iRow = iStartRow; iRow <= iEndRow; iRow++)
                {
                    // USD / Cost 
                    double dCostLocal = fgrid_overhead.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_LOCAL,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_LOCAL);

                    double dFXRate = fgrid_overhead.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxFX_RATE,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxFX_RATE);

                    double dCostUSD = DoubleCheck(dCostLocal / dFXRate);
                    fgrid_overhead[iRow, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_USD] = dCostUSD;
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "CalcOverhead", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 1-7. Sample mold 
        private void CalcSampMold(int iStartRow, int iEndRow)
        {
            try
            {
                iStartRow = iStartRow == -1 ? fgrid_sampMold.Rows.Fixed : iStartRow;
                iEndRow = iEndRow == -1 ? fgrid_sampMold.Rows.Count - 1 : iEndRow;

                for (int iRow = iStartRow; iRow <= iEndRow; iRow++)
                {
                    // Total Cost (KRW) ( Mold Cnt * Mold Cost)
                    double dAMoldCnt = fgrid_sampMold.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxMOLDA_CNT,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxMOLDA_CNT);
                    double dAMoldCost = fgrid_sampMold.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_MOLDA,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_MOLDA);

                    double dBMoldCnt = fgrid_sampMold.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxMOLDB_CNT,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxMOLDB_CNT);
                    double dBMoldCost = fgrid_sampMold.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_MOLDB,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_MOLDB);

                    double dCostTotal = (dAMoldCnt * dAMoldCost) + (dBMoldCnt * dBMoldCost);
                    fgrid_sampMold[iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxTOT_COST] = dCostTotal;

                    // Total Cost USD ( Total Cost (KRW) / FxRate)
                    double dFXRate = fgrid_sampMold.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxFX_RATE,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxFX_RATE);

                    double dCostUSD = DoubleCheck(dCostTotal / dFXRate);
                    fgrid_sampMold[iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxTOT_COST_USD] = dCostUSD;

                    // USD Pair ( Total Cost (USD) / Amourt Pair)
                    double dAmortPair = fgrid_sampMold.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxAMORT_PAIRS,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxAMORT_PAIRS);

                    double dUSDPair = DoubleCheck(dCostUSD / dAmortPair);
                    fgrid_sampMold[iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR] = dUSDPair;
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "CalcSampMold", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 1-8. Production mold 
        private void CalcProdMold(int iStartRow, int iEndRow)
        {
            try
            {
                iStartRow = iStartRow == -1 ? fgrid_prodMold.Rows.Fixed : iStartRow;
                iEndRow = iEndRow == -1 ? fgrid_prodMold.Rows.Count - 1 : iEndRow;

                for (int iRow = iStartRow; iRow <= iEndRow; iRow++)
                {
                    // Total Cost (KRW) ( Mold Cnt * Mold Cost)
                    double dAMoldCnt = fgrid_prodMold.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxMOLDA_CNT,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxMOLDA_CNT);
                    double dAMoldCost = fgrid_prodMold.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_MOLDA,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_MOLDA);

                    double dBMoldCnt = fgrid_prodMold.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxMOLDB_CNT,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxMOLDB_CNT);
                    double dBMoldCost = fgrid_prodMold.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_MOLDB,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_MOLDB);

                    double dCostTotal = (dAMoldCnt * dAMoldCost) + (dBMoldCnt * dBMoldCost);
                    fgrid_prodMold[iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxTOT_COST] = dCostTotal;

                    // Total Cost USD ( Total Cost (KRW) / FxRate)
                    double dFXRate = fgrid_prodMold.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxFX_RATE,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxFX_RATE);

                    double dCostUSD = DoubleCheck(dCostTotal / dFXRate);
                    fgrid_prodMold[iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxTOT_COST_USD] = dCostUSD;

                    // USD Pair ( Total Cost (USD) / Amourt Pair)
                    double dAmortPair = fgrid_prodMold.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxAMORT_PAIRS,
                        iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxAMORT_PAIRS);

                    double dUSDPair = DoubleCheck(dCostUSD / dAmortPair);
                    fgrid_prodMold[iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR] = dUSDPair;
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "CalcProdMold", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region 2. 총계

        // Header summary 
        /*
            txt_hMAT_TOTAL		        txt_hMAT_TOTAL_PCT
            txt_hMAT_UPPER		        txt_hMAT_UPPER_PCT
            txt_hMAT_PACKAGING	        txt_hMAT_PACKAGING_PCT
            txt_hMAT_MIDSOLE		    txt_hMAT_MIDSOLE_PCT
            txt_hMAT_OUTSOLE	        txt_hMAT_OUTSOLE_PCT

            txt_hNON_MAT_TOTAL		    txt_hNON_MAT_TOTAL_PCT
            txt_hNON_MAT_LABOR		    txt_hNON_MAT_LABOR_PCT
            txt_hNON_MAT_OVERHEAD	    txt_hNON_MAT_OVERHEAD_PCT
            txt_hNON_MAT_PROFIT		    txt_hNON_MAT_PROFIT_PCT
            txt_hNON_MAT_PROC_COST 	    txt_hNON_MAT_PROC_COST_PCT
            txt_hNON_MAT_PROC_COST 	    txt_hNON_MAT_PROC_COST_PCT
            txt_hNON_MAT_OTHER_ADJUST	txt_hNON_MAT_OTHER_ADJUST_PCT

            txt_hTOOLING_TOTAL 		    txt_hTOOLING_TOTAL_PCT
            txt_hSAMPLE_TOOLING 		txt_hSAMPLE_TOOLING_PCT
            txt_hPROD_TOOLING		    txt_hPROD_TOOLING_PCT
        */

        // Upper 
        private double CalcSummaryUP()
        {
            double dUP = 0;

            for (int iRow = fgrid_upper.Rows.Fixed; iRow < fgrid_upper.Rows.Count; iRow++)
            {
                string sRef = fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF] == null ? "" : fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF].ToString();

                if (!sRef.Equals("D") && !sRef.Equals("R"))
                {
                    string sUSDCost = NullCheck(fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST], "0");
                    string sPrssCharge = NullCheck(fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE], "0");

                    double dUSDCost = 0, dPrssCharge = 0;
                    double.TryParse(sUSDCost, out dUSDCost);
                    double.TryParse(sPrssCharge, out dPrssCharge);

                    dUP += (dUSDCost - dPrssCharge);
                }
            }

            txt_hUPPER_SUMM_CBD.Text = dUP.ToString();
            return dUP;
        }

        // Packaging 
        private double CalcSummaryPK()
        {
            double dPK = 0;

            for (int iRow = fgrid_packaging.Rows.Fixed; iRow < fgrid_packaging.Rows.Count; iRow++)
            {
                string sRef = fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF] == null ? "" : fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF].ToString();

                if (!sRef.Equals("D") && !sRef.Equals("R"))
                {
                    string sUSDCost = NullCheck(fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST], "0");
                    string sPrssCharge = NullCheck(fgrid_packaging[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE], "0");

                    double dUSDCost = 0, dPrssCharge = 0;
                    double.TryParse(sUSDCost, out dUSDCost);
                    double.TryParse(sPrssCharge, out dPrssCharge);

                    dPK += (dUSDCost - dPrssCharge);
                }
            }

            txt_hPACKING_SUMM_CBD.Text = dPK.ToString();
            return dPK;
        }

        // Midsole 
        private double CalcSummaryMS()
        {
            double dMS = 0;

            for (int iRow = fgrid_midsole.Rows.Fixed; iRow < fgrid_midsole.Rows.Count; iRow++)
            {
                string sRef = fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF] == null ? "" : fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF].ToString();

                if (!sRef.Equals("D") && !sRef.Equals("R"))
                {
                    string sUSDCost = NullCheck(fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST], "0");
                    string sPrssCharge = NullCheck(fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE], "0");

                    double dUSDCost = 0, dPrssCharge = 0;
                    double.TryParse(sUSDCost, out dUSDCost);
                    double.TryParse(sPrssCharge, out dPrssCharge);

                    dMS += (dUSDCost - dPrssCharge);
                }
            }

            txt_hMIDSOLE_SUMM_CBD.Text = dMS.ToString();
            return dMS;
        }

        // Outsole 
        private double CalcSummaryOS()
        {
            double dOS = 0;

            for (int iRow = fgrid_outsole.Rows.Fixed; iRow < fgrid_outsole.Rows.Count; iRow++)
            {
                string sRef = fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF] == null ? "" : fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF].ToString();

                if (!sRef.Equals("D") && !sRef.Equals("R"))
                {
                    string sUSDCost = NullCheck(fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxUSS_COST], "0");
                    string sPrssCharge = NullCheck(fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE], "0");

                    double dUSDCost = 0, dPrssCharge = 0;
                    double.TryParse(sUSDCost, out dUSDCost);
                    double.TryParse(sPrssCharge, out dPrssCharge);

                    dOS += (dUSDCost - dPrssCharge);
                }
            }

            txt_hOUTSOLE_SUMM_CBD.Text = dOS.ToString();
            return dOS;
        }

        // Labor 
        private double CalcSummaryLB()
        {
            double dLB = 0;

            for (int iRow = fgrid_labor.Rows.Fixed; iRow < fgrid_labor.Rows.Count; iRow++)
            {
                string sRef = fgrid_labor[iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxREF] == null ? "" : fgrid_labor[iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxREF].ToString();

                if (!sRef.Equals("D") && !sRef.Equals("R"))
                {
                    string sUSDCost = NullCheck(fgrid_labor[iRow, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxCOST_USD], "0");

                    double dUSDCost = 0;
                    double.TryParse(sUSDCost, out dUSDCost);

                    dLB += dUSDCost;
                }
            }

            txt_hLABOR_SUMM_CBD.Text = dLB.ToString();
            return dLB;
        }

        // Overhead 
        private double CalcSummaryOH()
        {
            double dOH = 0;

            for (int iRow = fgrid_overhead.Rows.Fixed; iRow < fgrid_overhead.Rows.Count; iRow++)
            {
                string sRef = fgrid_overhead[iRow, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxREF] == null ? "" : fgrid_overhead[iRow, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxREF].ToString();

                if (!sRef.Equals("D") && !sRef.Equals("R"))
                {
                    string sUSDCost = NullCheck(fgrid_overhead[iRow, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_USD], "0");

                    double dUSDCost = 0;
                    double.TryParse(sUSDCost, out dUSDCost);

                    dOH += dUSDCost;
                }
            }

            txt_hOVERHEAD_SUMM_CBD.Text = dOH.ToString();
            return dOH;
        }

        // Sample Mold
        private double CalcSummarySM()
        {
            double dSM = 0;

            for (int iRow = fgrid_sampMold.Rows.Fixed; iRow < fgrid_sampMold.Rows.Count; iRow++)
            {
                string sRef = fgrid_sampMold[iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxREF] == null ? "" : fgrid_sampMold[iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxREF].ToString();

                if (!sRef.Equals("D") && !sRef.Equals("R"))
                {
                    string sUSDCost = NullCheck(fgrid_sampMold[iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR], "0");

                    double dUSDCost = 0;
                    double.TryParse(sUSDCost, out dUSDCost);

                    dSM += dUSDCost;
                }
            }

            txt_hSMPL_TOOL_SUMM_CBD.Text = dSM.ToString();
            return dSM;
        }

        // Prod Mold
        private double CalcSummaryPM()
        {
            double dPM = 0;

            for (int iRow = fgrid_prodMold.Rows.Fixed; iRow < fgrid_prodMold.Rows.Count; iRow++)
            {
                string sRef = fgrid_prodMold[iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxREF] == null ? "" : fgrid_prodMold[iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxREF].ToString();

                if (!sRef.Equals("D") && !sRef.Equals("R"))
                {
                    string sUSDCost = NullCheck(fgrid_prodMold[iRow, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCOST_USD_PAIR], "0");

                    double dUSDCost = 0;
                    double.TryParse(sUSDCost, out dUSDCost);

                    dPM += dUSDCost;
                }
            }

            txt_hPROD_TOOL_SUMM_CBD.Text = dPM.ToString();
            return dPM;
        }


        // Process charge total and sizeing up charge total
        private double CalcSummaryUPEtc(int iCol)
        {
            double dPrssUP = 0;

            for (int iRow = fgrid_upper.Rows.Fixed; iRow < fgrid_upper.Rows.Count; iRow++)
            {
                string sRef = fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF] == null ? "" : fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF].ToString();

                if (!sRef.Equals("D") && !sRef.Equals("R"))
                {
                    string sPrssCharge = "0";
                    if (fgrid_upper[iRow, iCol] != null)
                        sPrssCharge = fgrid_upper[iRow, iCol].ToString();

                    double dPrssCharge = 0;
                    double.TryParse(sPrssCharge, out dPrssCharge);

                    dPrssUP += dPrssCharge;
                }
            }

            return dPrssUP;
        }

        private double CalcSummaryMSEtc(int iCol)
        {
            double dPrssMS = 0;

            for (int iRow = fgrid_midsole.Rows.Fixed; iRow < fgrid_midsole.Rows.Count; iRow++)
            {
                string sRef = fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF] == null ? "" : fgrid_midsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF].ToString();

                if (!sRef.Equals("D") && !sRef.Equals("R"))
                {
                    string sPrssCharge = "0";
                    if (fgrid_midsole[iRow, iCol] != null)
                        sPrssCharge = fgrid_midsole[iRow, iCol].ToString();

                    double dPrssCharge = 0;
                    double.TryParse(sPrssCharge, out dPrssCharge);

                    dPrssMS += dPrssCharge;
                }
            }

            return dPrssMS;
        }

        private double CalcSummaryOSEtc(int iCol)
        {
            double dPrssOS = 0;

            for (int iRow = fgrid_outsole.Rows.Fixed; iRow < fgrid_outsole.Rows.Count; iRow++)
            {
                string sRef = fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF] == null ? "" : fgrid_outsole[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxREF].ToString();

                if (!sRef.Equals("D") && !sRef.Equals("R"))
                {
                    string sPrssCharge = "0";
                    if (fgrid_outsole[iRow, iCol] != null)
                        sPrssCharge = fgrid_outsole[iRow, iCol].ToString();

                    double dPrssCharge = 0;
                    double.TryParse(sPrssCharge, out dPrssCharge);

                    dPrssOS += dPrssCharge;
                }
            }

            return dPrssOS;
        }


        // Summary 
        private void CalcSummary()
        {
            try
            {
                // Upper
                double dUp = DoubleCheck(CalcSummaryUP());
                txt_hUPPER_SUMM_CBD.Text = Convert.ToString(dUp);

                double dPK = DoubleCheck(CalcSummaryPK());
                txt_hPACKING_SUMM_CBD.Text = Convert.ToString(dPK);

                double dMS = DoubleCheck(CalcSummaryMS());
                txt_hMIDSOLE_SUMM_CBD.Text = Convert.ToString(dMS);

                double dOS = DoubleCheck(CalcSummaryOS());
                txt_hOUTSOLE_SUMM_CBD.Text = Convert.ToString(dOS);

                double dSizeUpUP = DoubleCheck(CalcSummaryUPEtc((int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE));
                double dSizeUpMS = DoubleCheck(CalcSummaryMSEtc((int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE));
                double dSizeUpOS = DoubleCheck(CalcSummaryOSEtc((int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE));
                double dSizeUp = dSizeUpUP + dSizeUpMS + dSizeUpOS;

                txt_hSIZEUP_SUMM_CBD.Text = Convert.ToString(dSizeUp);

                txt_hMAT_SUMM_CBD.Text = Convert.ToString(dUp + dPK + dMS + dOS + dSizeUp);


                double dLabor = DoubleCheck(CalcSummaryLB());
                txt_hLABOR_SUMM_CBD.Text = Convert.ToString(dLabor);

                double dOverhead = DoubleCheck(CalcSummaryOH());
                txt_hOVERHEAD_SUMM_CBD.Text = Convert.ToString(dOverhead);

                double dProfit = 0;
                double.TryParse(txt_hPROFIT.Tag == null ? "0" : txt_hPROFIT.Tag.ToString(), out dProfit);
                txt_hPROFIT_SUMM_CBD.Text = Convert.ToString(dProfit);

                // Process Cost 
                double dPrssUP = DoubleCheck(CalcSummaryUPEtc((int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE));
                double dPrssMS = DoubleCheck(CalcSummaryMSEtc((int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE));
                double dPrssOS = DoubleCheck(CalcSummaryOSEtc((int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE));
                double dPrss = dPrssUP + dPrssMS + dPrssOS;

                txt_hPRSS_SUMM_CBD.Text = Convert.ToString(dPrss);

                double dAdjust = 0;
                double.TryParse(txt_hOTHER_ADJUST.Text, out dAdjust);
                txt_hOTHERADJ_SUMM_CBD.Text = Convert.ToString(dAdjust);

                txt_hNON_MAT_SUMM_CBD.Text = Convert.ToString(dLabor + dOverhead + dProfit + dPrss + dAdjust);


                double dSM = DoubleCheck(CalcSummarySM());
                txt_hSMPL_TOOL_SUMM_CBD.Text = Convert.ToString(dSM);

                double dPM = DoubleCheck(CalcSummaryPM());
                txt_hPROD_TOOL_SUMM_CBD.Text = Convert.ToString(dPM);

                txt_hTOOL_SUMM_CBD.Text = Convert.ToString(dSM + dPM);

                txt_hFOB.Text = Convert.ToString(dUp + dPK + dMS + dOS + dSizeUp + dLabor + dOverhead + dProfit + dPrss + dAdjust + dSM + dPM);

                DisplaySummaryChart();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Summary Persentage
        private void CalcSummaryPersent()
        {
            try
            {
                double dTotal = 0;
                double.TryParse(txt_hFOB.Tag == null ? txt_hFOB.Text : txt_hFOB.Tag.ToString(), out dTotal);
                txt_hFOB_PCT.Text = "100";

                double dUP = 0;
                double.TryParse(txt_hUPPER_SUMM_CBD.Tag == null ? txt_hUPPER_SUMM_CBD.Text : txt_hUPPER_SUMM_CBD.Tag.ToString(), out dUP);
                txt_hUPPER_SUMM_PCT.Text = Convert.ToString(DoubleCheck((dUP / dTotal) * 100));

                double dPK = 0;
                double.TryParse(txt_hPACKING_SUMM_CBD.Tag == null ? txt_hPACKING_SUMM_CBD.Text : txt_hPACKING_SUMM_CBD.Tag.ToString(), out dPK);
                txt_hPACKING_SUMM_PCT.Text = Convert.ToString(DoubleCheck((dPK / dTotal) * 100));

                double dMS = 0;
                double.TryParse(txt_hMIDSOLE_SUMM_CBD.Tag == null ? txt_hMIDSOLE_SUMM_CBD.Text : txt_hMIDSOLE_SUMM_CBD.Tag.ToString(), out dMS);
                txt_hMIDSOLE_SUMM_PCT.Text = Convert.ToString(DoubleCheck((dMS / dTotal) * 100));

                double dOS = 0;
                double.TryParse(txt_hOUTSOLE_SUMM_CBD.Tag == null ? txt_hOUTSOLE_SUMM_CBD.Text : txt_hOUTSOLE_SUMM_CBD.Tag.ToString(), out dOS);
                txt_hOUTSOLE_SUMM_PCT.Text = Convert.ToString(DoubleCheck((dOS / dTotal) * 100));

                double dSizeUp = 0;
                double.TryParse(txt_hSIZEUP_SUMM_CBD.Tag == null ? txt_hSIZEUP_SUMM_CBD.Text : txt_hSIZEUP_SUMM_CBD.Tag.ToString(), out dSizeUp);
                txt_hSIZEUP_SUMM_PCT.Text = Convert.ToString(DoubleCheck((dSizeUp / dTotal) * 100));

                txt_hMAT_SUMM_PCT.Text = Convert.ToString(DoubleCheck(((dUP + dPK + dMS + dOS + dSizeUp) / dTotal) * 100));


                double dLabor = 0;
                double.TryParse(txt_hLABOR_SUMM_CBD.Tag == null ? txt_hLABOR_SUMM_CBD.Text : txt_hLABOR_SUMM_CBD.Tag.ToString(), out dLabor);
                txt_hLABOR_SUMM_PCT.Text = Convert.ToString(DoubleCheck((dLabor / dTotal) * 100));

                double dOverhead = 0;
                double.TryParse(txt_hOVERHEAD_SUMM_CBD.Tag == null ? txt_hOVERHEAD_SUMM_CBD.Text : txt_hOVERHEAD_SUMM_CBD.Tag.ToString(), out dOverhead);
                txt_hOVERHEAD_SUMM_PCT.Text = Convert.ToString(DoubleCheck((dOverhead / dTotal) * 100));

                double dProfit = 0;
                double.TryParse(txt_hPROFIT.Tag == null ? txt_hPROFIT.Text : txt_hPROFIT.Tag.ToString(), out dProfit);
                txt_hPROFIT_SUMM_PCT.Text = Convert.ToString(DoubleCheck((dProfit / dTotal) * 100));

                double dPrss = 0;
                double.TryParse(txt_hPRSS_SUMM_CBD.Tag == null ? txt_hPRSS_SUMM_CBD.Text : txt_hPRSS_SUMM_CBD.Tag.ToString(), out dPrss);
                txt_hPRSS_SUMM_PCT.Text = Convert.ToString(DoubleCheck((dPrss / dTotal) * 100));

                double dAdjust = 0;
                double.TryParse(txt_hOTHER_ADJUST.Tag == null ? txt_hOTHER_ADJUST.Text : txt_hOTHER_ADJUST.Tag.ToString(), out dAdjust);
                txt_hOTHERADJ_SUMM_PCT.Text = Convert.ToString(DoubleCheck((dAdjust / dTotal) * 100));

                txt_hNON_MAT_SUMM_PCT.Text = Convert.ToString(DoubleCheck(((dLabor + dOverhead + dProfit + dPrss + dAdjust) / dTotal) * 100));


                double dSM = 0;
                double.TryParse(txt_hSMPL_TOOL_SUMM_CBD.Tag == null ? txt_hSMPL_TOOL_SUMM_CBD.Text : txt_hSMPL_TOOL_SUMM_CBD.Tag.ToString(), out dSM);
                txt_hSMPL_TOOL_SUMM_PCT.Text = Convert.ToString(DoubleCheck((dSM / dTotal) * 100));

                double dPM = 0;
                double.TryParse(txt_hPROD_TOOL_SUMM_CBD.Tag == null ? txt_hPROD_TOOL_SUMM_CBD.Text : txt_hPROD_TOOL_SUMM_CBD.Tag.ToString(), out dPM);
                txt_hPROD_TOOL_SUMM_PCT.Text = Convert.ToString(DoubleCheck((dPM / dTotal) * 100));

                txt_hTOOL_SUMM_PCT.Text = Convert.ToString((DoubleCheck((dSM + dPM) / dTotal) * 100));
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Summary PCT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private double DoubleCheck(double arg_data)
        {
            if (double.IsNaN(arg_data) || double.IsInfinity(arg_data))
                return 0;
            else
                return arg_data;
        }

        private string NullCheck(object arg_obj, string arg_ret)
        {
            if (arg_obj == null)
                return arg_ret;
            else
                return arg_obj.ToString();
        }

        #endregion

        #region 3. ETC Summary

        private void CalcETCSummary()
        {
            // Total Material, Labor, Overhead, Size Up : txt_hTOT_MLOS 
            double dUPUSDCost = DoubleCheck(CalcSummaryUP());
            double dPKUSDCost = DoubleCheck(CalcSummaryPK());
            double dMSUSDCost = DoubleCheck(CalcSummaryMS());
            double dOSUSDCost = DoubleCheck(CalcSummaryOS());
            double dLBUSDCostPerPair = DoubleCheck(CalcSummaryLB());
            double dOHUSDCost = DoubleCheck(CalcSummaryOH());

            double dUPSizeUpCharge = DoubleCheck(CalcSummaryUPEtc((int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE));
            double dMSSizeUpCharge = DoubleCheck(CalcSummaryMSEtc((int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE));
            double dOSSizeUpCharge = DoubleCheck(CalcSummaryOSEtc((int)ClassLib.TBSFX_CBD_TAIL.IxSIZEUP_CHARGE));
            double dSizeUp = dUPSizeUpCharge + dMSSizeUpCharge + dOSSizeUpCharge;

            double dPrssUP = DoubleCheck(CalcSummaryUPEtc((int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE));
            double dPrssMS = DoubleCheck(CalcSummaryMSEtc((int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE));
            double dPrssOS = DoubleCheck(CalcSummaryOSEtc((int)ClassLib.TBSFX_CBD_TAIL.IxPRSS_CHARGE));
            double dPrss = dPrssUP + dPrssMS + dPrssOS;

            double dTot_MLOS = dUPUSDCost + dPKUSDCost + dMSUSDCost + dOSUSDCost + dLBUSDCostPerPair + dOHUSDCost + dSizeUp + dPrss;
            txt_hTOT_MLOS.Text = dTot_MLOS.ToString();


            // Profit : txt_hPROFIT, txt_hPROFIT_PCT 
            double dProfitPCT = txt_hPROFIT_PCT.Text.Equals("") ? 0 : Convert.ToDouble(txt_hPROFIT_PCT.Text);
            double dProfit = dTot_MLOS * (dProfitPCT / 100);
            txt_hPROFIT.Text = dProfit.ToString();


            // Tooling ( Sample + Production Molds ) : txt_hTOT_TOOLING ( Non database field ) 
            double dSMUSDCostPerPair = DoubleCheck(CalcSummarySM());
            double dPMUSDCostPerPair = DoubleCheck(CalcSummaryPM());

            double dTot_Tooling = dSMUSDCostPerPair + dPMUSDCostPerPair;
            txt_hTOT_TOOLING.Text = dTot_Tooling.ToString();


            // Total FOB : txt_hTOT_FOB ( Non database field ) 
            double dOtherAdj = txt_hOTHER_ADJUST.Text.Equals("") ? 0 : Convert.ToDouble(txt_hOTHER_ADJUST.Text);
            double dTotFob = dTot_MLOS + dProfit + dOtherAdj + dTot_Tooling;
            txt_hTOT_FOB.Text = dTotFob.ToString();
        }

        #endregion

        #endregion

        #region Copy & Paste Old

        //private void fgrid_KeyDown(object sender, KeyEventArgs e)
        //{
        //    try
        //    {
        //        COM.FSP grid = (sender as COM.FSP);

        //        if (grid.Rows.Count > grid.Rows.Fixed)
        //        {
        //            if (e.Control && e.KeyCode == Keys.C)
        //            {
        //                DataCopy(sender as COM.FSP);
        //            }
        //            else if (e.Control && e.KeyCode == Keys.V)
        //            {
        //                DataPaste(sender as COM.FSP);
        //            }
        //            //else if (e.Control && e.KeyCode == Keys.X)
        //            //{
        //            //    DataCut(sender as COM.FSP);
        //            //}
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ClassLib.ComFunction.User_Message(ex.Message, "Grid Copy & Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void DataCopy(COM.FSP arg_grid)
        //{
        //    foreach (int iRow in iSels)
        //    {
        //        if (arg_grid.Rows[iRow].Node.Children > 0)
        //        {
        //            for (int iCRow = iRow + 1; iCRow < arg_grid.Rows[iRow].Node.Children; iCRow++)
        //            {
        //                arg_grid.Rows[iRow].Selected = true;
        //            }
        //        }
        //    }

        //    int[] iSels = arg_grid.Selections;
        //    int rIdx = iSels.Length;
        //    int cIdx = arg_grid.Cols.Count;
        //    _copyRange = new object[rIdx][];

        //    for (int idx = 0; idx < _copyRange.Length; idx++)
        //    {
        //        _copyRange[idx] = new object[cIdx - 1];
        //    }

        //    int oRow = 0;
        //    foreach (int iRow in iSels)
        //    {
        //        for (int nCol = 1, oCol = 0; nCol < cIdx; nCol++, oCol++)
        //        {
        //            _copyRange[oRow][oCol] = arg_grid[iRow, nCol];
        //        }

        //        oRow++;
        //    }
        //}

        //private void DataCut(COM.FSP arg_grid)
        //{
        //    int[] iSels = arg_grid.Selections;
        //    int rIdx = iSels.Length;
        //    int cIdx = arg_grid.Cols.Count;

        //    string copyData = "";
        //    _copyRange = new object[rIdx][];

        //    for (int idx = 0; idx < _copyRange.Length; idx++)
        //    {
        //        _copyRange[idx] = new object[cIdx - 1];
        //    }

        //    int oRow = 0;
        //    foreach (int iRow in iSels)
        //    {
        //        for (int nCol = 1, oCol = 0; nCol < cIdx; nCol++, oCol++)
        //        {
        //            _copyRange[oRow][oCol] = arg_grid[iRow, nCol];
        //            copyData += arg_grid[iRow, nCol] + (nCol == (cIdx - 1) ? "\n" : "\t");
        //        }

        //        oRow++;
        //    }

        //    for (int nRow = iSels.Length - 1; nRow >= 0; nRow--)
        //    {
        //        if (arg_grid[iSels[nRow], 0].Equals("I"))
        //        {
        //            arg_grid.Rows.Remove(iSels[nRow]);
        //        }
        //        else
        //        {
        //            arg_grid[iSels[nRow], 0] = "R";
        //        }
        //    }

        //    Clipboard.Clear();

        //    if (copyData != null && !copyData.Equals(""))
        //        Clipboard.SetText(copyData);
        //}

        //private void DataPaste(COM.FSP arg_grid)
        //{
        //    string sClip = Clipboard.GetText();

        //    string[] sRowClip = sClip.Split('\n');
        //    _copyRange = new object[sRowClip.Length - 1][];
        //    int row = arg_grid.Row, col = arg_grid.Col;

        //    for (int idx = 0; idx < sRowClip.Length - 1; idx++)
        //    {
        //        _copyRange[idx] = sRowClip[idx].Split('\t');
        //        C1.Win.C1FlexGrid.Row vNewRow = AddDetail(arg_grid, arg_grid.Rows.Count - 1);
        //        vNewRow[0] = "I";
        //        if (idx == 0)
        //            row = vNewRow.Index;
        //    }

        //    if (_copyRange != null && _copyRange.Length > 0)
        //    {
        //        int rowCount = _copyRange.Length;
        //        int colCount = _copyRange[0].Length;

        //        for (int nRow = row, oRow = 0; oRow < rowCount; nRow++, oRow++)
        //        {
        //            for (int nCol = 1, oCol = 0; oCol < colCount; nCol++, oCol++)
        //            {
        //                if (nRow < arg_grid.Rows.Count && nCol < arg_grid.Cols.Count && arg_grid.Cols[nCol].AllowEditing)
        //                {
        //                    arg_grid[nRow, nCol] = _copyRange[oRow][oCol];
        //                    arg_grid.Update_Row(nRow);

        //                    ModifyDetail(arg_grid, nRow, nCol);
        //                }
        //            }
        //        }

        //        for (int nRow = row, oRow = 0; oRow < rowCount; nRow++, oRow++)
        //        {
        //            if (nRow < arg_grid.Rows.Count)
        //            {
        //                if (arg_grid.Name.Equals(fgrid_upper.Name))
        //                {
        //                    SetFXRate(arg_grid as COM.FSP, nRow, nRow, 
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
        //                    CalcUpper(nRow, nRow);
        //                }
        //                else if (arg_grid.Name.Equals(fgrid_packaging.Name))
        //                {
        //                    SetFXRate(arg_grid as COM.FSP, nRow, nRow, 
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
        //                    CalcPackaging(nRow, nRow);
        //                }
        //                else if (arg_grid.Name.Equals(fgrid_midsole.Name))
        //                {
        //                    SetFXRate(arg_grid as COM.FSP, nRow, nRow, 
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
        //                    CalcMidsole(nRow, nRow);
        //                }
        //                else if (arg_grid.Name.Equals(fgrid_outsole.Name))
        //                {
        //                    SetFXRate(arg_grid as COM.FSP, nRow, nRow, 
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
        //                    CalcOutsole(nRow, nRow);
        //                }
        //                else if (arg_grid.Name.Equals(fgrid_labor.Name))
        //                {
        //                    SetFXRate(arg_grid as COM.FSP, nRow, nRow, 
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
        //                    CalcLabor(nRow, nRow);
        //                }
        //                else if (arg_grid.Name.Equals(fgrid_overhead.Name))
        //                {
        //                    SetFXRate(arg_grid as COM.FSP, nRow, nRow, 
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
        //                    CalcOverhead(nRow, nRow);
        //                }
        //                else if (arg_grid.Name.Equals(fgrid_sampMold.Name))
        //                {
        //                    SetFXRate(arg_grid as COM.FSP, nRow, nRow, 
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
        //                    CalcSampMold(nRow, nRow);
        //                }
        //                else if (arg_grid.Name.Equals(fgrid_prodMold.Name))
        //                {
        //                    SetFXRate(arg_grid as COM.FSP, nRow, nRow, 
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
        //                        (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
        //                    CalcProdMold(nRow, nRow);
        //                }
        //            }
        //        }

        //        CalcETCSummary();
        //        CalcSummary();
        //        CalcSummaryPersent();
        //    }
        //}

        #endregion

        #region Copy & Paste New

        private System.Collections.ArrayList _CopyArray = null;
        private COM.FSP _CopyGrid = null;
        private string _CopyType = null;

        private void fgrid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                COM.FSP grid = (sender as COM.FSP);

                if (grid.Rows.Count > grid.Rows.Fixed)
                {
                    if (e.Control && e.KeyCode == Keys.C)
                    {
                        DataCopy(sender as COM.FSP);
                    }
                    else if (e.Control && e.KeyCode == Keys.V && _CopyArray != null)
                    {
                        DataPaste(sender as COM.FSP);
                    }
                    else if (e.Control && e.KeyCode == Keys.X)
                    {
                        DataCut(sender as COM.FSP);
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Grid Copy & Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_DataCopy(object sender, EventArgs e)
        {
            try
            {
                if (cmb_hDEV_FAC.SelectedValue == null)
                    return;

                COM.FSP vFSP = GetActiveGrid();

                if (vFSP.Rows.Count > vFSP.Rows.Fixed)
                {
                    DataCopy(vFSP);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Data Copy (Ctx)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_DataCut(object sender, EventArgs e)
        {
            try
            {
                if (cmb_hDEV_FAC.SelectedValue == null)
                    return;

                COM.FSP vFSP = GetActiveGrid();

                if (vFSP.Rows.Count > vFSP.Rows.Fixed)
                {
                    DataCut(vFSP);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Data Cut (Ctx)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxt_DataPaste(object sender, EventArgs e)
        {
            try
            {
                if (cmb_hDEV_FAC.SelectedValue == null)
                    return;

                COM.FSP vFSP = GetActiveGrid();

                if (vFSP.Rows.Count > vFSP.Rows.Fixed)
                {
                    DataPaste(vFSP);
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Data Paste (Ctx)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataCopy(COM.FSP arg_grid)
        {
            string sClipboard = "";
            SetDefaultBorderColor();
            int[] iSels = arg_grid.Selections;
            foreach (int iRow in iSels)
            {
                if (arg_grid.Rows[iRow].Node.Children > 0)
                {
                    for (int iCRow = iRow + 1; iCRow <= iRow + arg_grid.Rows[iRow].Node.Children; iCRow++)
                    {
                        arg_grid.Rows[iCRow].Selected = true;
                    }
                }
            }

            if (_CopyArray == null)
                _CopyArray = new System.Collections.ArrayList();
            _CopyArray.Clear();
            _CopyType = "COPY";
            _CopyGrid = arg_grid;

            for (int iIdx = iSels.Length - 1; iIdx >= 0; iIdx--)
            {
                _CopyArray.Add(arg_grid.Rows[iSels[iIdx]]);
                arg_grid.Rows[iSels[iIdx]].StyleNew.Border.Color = Color.Blue;
                arg_grid.Rows[iSels[iIdx]].StyleNew.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Horizontal;

                for (int iCol = 1; iCol < arg_grid.Cols.Count; iCol++)
                {
                    if (arg_grid.Cols[iCol].Visible)
                        sClipboard += arg_grid[iSels[iIdx], iCol] + "\t";
                }

                sClipboard += "\n";
            }

            Clipboard.Clear();
            if (!sClipboard.Equals(""))
                Clipboard.SetText(sClipboard);
        }

        private void DataCut(COM.FSP arg_grid)
        {
            string sClipboard = "";
            SetDefaultBorderColor();
            int[] iSels = arg_grid.Selections;
            foreach (int iRow in arg_grid.Selections)
            {
                if (arg_grid.Rows[iRow].Node.Children > 0)
                {
                    for (int iCRow = iRow + 1; iCRow < arg_grid.Rows[iRow].Node.Children; iCRow++)
                    {
                        arg_grid.Rows[iRow].Selected = true;
                    }
                }
            }

            if (_CopyArray == null)
                _CopyArray = new System.Collections.ArrayList();
            _CopyArray.Clear();
            _CopyType = "CUT";
            _CopyGrid = arg_grid;

            for (int iIdx = iSels.Length - 1; iIdx >= 0; iIdx--)
            {
                _CopyArray.Add(arg_grid.Rows[iSels[iIdx]]);
                arg_grid.Rows[iSels[iIdx]].StyleNew.Border.Color = Color.Red;
                arg_grid.Rows[iSels[iIdx]].StyleNew.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Horizontal;

                for (int iCol = 1; iCol < arg_grid.Cols.Count; iCol++)
                {
                    if (arg_grid.Cols[iCol].Visible)
                        sClipboard += arg_grid[iSels[iIdx], iCol] + "\t";
                }

                sClipboard += "\n";
            }

            Clipboard.Clear();

            if (!sClipboard.Equals(""))
                Clipboard.SetText(sClipboard);
        }

        private void SetDefaultBorderColor()
        {
            if (_CopyArray != null)
            {
                foreach (C1.Win.C1FlexGrid.Row vRow in _CopyArray)
                {
                    vRow.Style.Border.Color = Color.FromArgb(255, 236, 233, 216);
                    vRow.Style.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Both;
                }
            }
        }

        private void DataPaste(COM.FSP arg_grid)
        {
            if (arg_grid.Name.Equals(fgrid_sampMold.Name) || arg_grid.Name.Equals(fgrid_prodMold.Name))
            {
                if (_CopyGrid.Name.Equals(fgrid_sampMold.Name) || _CopyGrid.Name.Equals(fgrid_prodMold.Name))
                {
                    DataPasteMold(arg_grid);
                }
            }
            else
            {
                if (_CopyGrid.Name.Equals(fgrid_upper.Name) ||
                    _CopyGrid.Name.Equals(fgrid_packaging.Name) ||
                    _CopyGrid.Name.Equals(fgrid_midsole.Name) ||
                    _CopyGrid.Name.Equals(fgrid_outsole.Name))
                {
                    DataPasteNormal(arg_grid);
                }
            }
        }

        private void DataPasteNormal(COM.FSP arg_grid)
        {
            int row = arg_grid.Row, IChildCount = arg_grid.Rows[row].Node.Children;

            foreach (C1.Win.C1FlexGrid.Row vRow in _CopyArray)
            {
                C1.Win.C1FlexGrid.Node vNode = arg_grid.Rows.InsertNode(row + 1 + IChildCount, vRow.Node.Level);

                for (int iCol = 0; iCol < arg_grid.Cols.Count; iCol++)
                {
                    vNode.Row[iCol] = vRow[iCol];
                    vNode.Row[(int)ClassLib.TBSFX_CBD_TAIL.IxBOM_NO] = "";
                }

                vNode.Row[0] = "I";

                if (vNode.Level == 0)
                {
                    if (arg_grid.Name.Equals(fgrid_upper.Name))
                    {
                        SetFXRate(arg_grid as COM.FSP, vNode.Row.Index, vNode.Row.Index,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                        CalcUpper(vNode.Row.Index, vNode.Row.Index);
                    }
                    else if (arg_grid.Name.Equals(fgrid_packaging.Name))
                    {
                        SetFXRate(arg_grid as COM.FSP, vNode.Row.Index, vNode.Row.Index,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                        CalcPackaging(vNode.Row.Index, vNode.Row.Index);
                    }
                    else if (arg_grid.Name.Equals(fgrid_midsole.Name))
                    {
                        SetFXRate(arg_grid as COM.FSP, vNode.Row.Index, vNode.Row.Index,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                        CalcMidsole(vNode.Row.Index, vNode.Row.Index);
                    }
                    else if (arg_grid.Name.Equals(fgrid_outsole.Name))
                    {
                        SetFXRate(arg_grid as COM.FSP, vNode.Row.Index, vNode.Row.Index,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                        CalcOutsole(vNode.Row.Index, vNode.Row.Index);
                    }
                }

                if (_CopyType.Equals("CUT"))
                {
                    if (vRow[0] == null || !vRow[0].ToString().Equals("I"))
                        vRow[0] = "R";
                }
            }

            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();

        }

        private void DataPasteMold(COM.FSP arg_grid)
        {
            int row = arg_grid.Row, IChildCount = arg_grid.Rows[row].Node.Children;

            foreach (C1.Win.C1FlexGrid.Row vRow in _CopyArray)
            {
                C1.Win.C1FlexGrid.Node vNode = arg_grid.Rows.InsertNode(row + 1 + IChildCount, vRow.Node.Level);

                for (int iCol = 0; iCol < arg_grid.Cols.Count; iCol++)
                {
                    vNode.Row[iCol] = vRow[iCol];                    
                }

                vNode.Row[0] = "I";

                if (vNode.Level == 0)
                {
                    if (arg_grid.Name.Equals(fgrid_sampMold.Name))
                    {
                        SetFXRate(arg_grid as COM.FSP, vNode.Row.Index, vNode.Row.Index,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                        CalcSampMold(vNode.Row.Index, vNode.Row.Index);
                        fgrid_sampMold[vNode.Row.Index, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxDIV] = "SMPL_MOLD";
                    }
                    else if (arg_grid.Name.Equals(fgrid_prodMold.Name))
                    {
                        SetFXRate(arg_grid as COM.FSP, vNode.Row.Index, vNode.Row.Index,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                            (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                        CalcProdMold(vNode.Row.Index, vNode.Row.Index);
                        fgrid_prodMold[vNode.Row.Index, (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxDIV] = "PROD_MOLD";
                    }
                }

                if (_CopyType.Equals("CUT"))
                {
                    if (vRow[0] == null || !vRow[0].ToString().Equals("I"))
                        vRow[0] = "R";
                }
            }

            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();

        }

        #endregion

        #region Chart

        private void DisplaySummaryChart()
        {
            DataTable vDT = new DataTable();

            vDT.Columns.Add("SUBJECT");
            vDT.Columns.Add("VALUE");

            // Material + Labor, Overhead, Tooling 
            DataRow vDR = vDT.NewRow();
            vDR["SUBJECT"] = "Material";
            vDR["VALUE"] = Convert.ToDouble(txt_hMAT_SUMM_CBD.Text);
            vDT.Rows.Add(vDR);

            vDR = vDT.NewRow();
            vDR["SUBJECT"] = "Overhead + Labor";
            vDR["VALUE"] = Convert.ToDouble(txt_hOVERHEAD_SUMM_CBD.Text) + Convert.ToDouble(txt_hLABOR_SUMM_CBD.Text);
            vDT.Rows.Add(vDR);

            vDR = vDT.NewRow();
            vDR["SUBJECT"] = "Tooling";
            vDR["VALUE"] = Convert.ToDouble(txt_hTOOL_SUMM_CBD.Text);
            vDT.Rows.Add(vDR);

            Init_Chart(chart_summary, _ms_summary);

            chart_summary.Data.Series = 1;

            chart_summary.Series[0].AxisY = chart_summary.AxisY;

            chart_summary.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("SUBJECT", ChartFX.WinForms.FieldUsage.Label));
            chart_summary.DataSourceSettings.Fields.Add(new ChartFX.WinForms.FieldMap("VALUE", ChartFX.WinForms.FieldUsage.Value));
            
            //chart_summary.LegendBox.Visible = true;
            //chart_summary.LegendBox.Dock = ChartFX.WinForms.DockArea.Bottom;
            //chart_summary.LegendBox.Font = new Font(chart_summary.LegendBox.Font.FontFamily, (float)7);

            chart_summary.Series[0].PointLabels.Visible = false;
            //chart_summary.Series[0].PointLabels.Font = new Font(chart_summary.Series[0].PointLabels.Font.FontFamily, (float)7.5);

            chart_summary.DataSource = vDT;
            vDT.Dispose();
        }

        #endregion

        #region Material copy from other cbd

        public void CopyCBDFormOtherCBD(string sDiv, C1.Win.C1FlexGrid.Row[] vDatas)
        {
            try
            {
                if (vDatas != null)
                {
                    COM.FSP vFSP = GetActiveGrid();

                    if (sDiv.Equals("MAT") && (vFSP.Name.Equals(fgrid_upper.Name) || vFSP.Name.Equals(fgrid_packaging.Name) || vFSP.Name.Equals(fgrid_midsole.Name) || vFSP.Name.Equals(fgrid_outsole.Name)))
                    {
                        foreach (C1.Win.C1FlexGrid.Row vData in vDatas)
                        {
                            C1.Win.C1FlexGrid.Row vNewRow = null;

                            int iRow = vFSP.Row;

                            int IChildCount = 0;
                            if (vFSP.Row > vFSP.Rows.Fixed)
                            {
                                if (vFSP.Rows[iRow].Node.Level > 0)
                                    iRow = vFSP.Rows[iRow].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent).Row.Index;
                                IChildCount = vFSP.Rows[iRow].Node.Children;
                            }
                            vNewRow = AddDetail(vFSP, iRow + IChildCount);

                            if (vNewRow != null)
                            {
                                vFSP.Select(vNewRow.Index, 0);

                                vNewRow[0] = "I";
                                vNewRow[(int)ClassLib.TBSFX_CBD_TAIL.IxSIZE_EXC] = vData[(int)ClassLib.TBSFX_CBD_TAIL.IxSIZE_EXC];
                                vNewRow[(int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS] = vData[(int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS];
                                vNewRow[(int)ClassLib.TBSFX_CBD_TAIL.IxSUB_CLASS] = vData[(int)ClassLib.TBSFX_CBD_TAIL.IxSUB_CLASS];

                                for (int iCol = (int)ClassLib.TBSFX_CBD_TAIL.IxPART_NAME; iCol < vFSP.Cols.Count; iCol++)
                                {
                                    vNewRow[iCol] = vData[iCol];
                                }

                                if (vFSP.Name.Equals(fgrid_upper.Name))
                                    CalcUpper(vNewRow.Index, vNewRow.Index);
                                else if (vFSP.Name.Equals(fgrid_packaging.Name))
                                    CalcPackaging(vNewRow.Index, vNewRow.Index);
                                else if (vFSP.Name.Equals(fgrid_midsole.Name))
                                    CalcMidsole(vNewRow.Index, vNewRow.Index);
                                else if (vFSP.Name.Equals(fgrid_outsole.Name))
                                    CalcOutsole(vNewRow.Index, vNewRow.Index);

                                SetFXRate(vFSP, vNewRow.Index, vNewRow.Index,
                                    (int)ClassLib.TBSFX_CBD_TAIL.IxCURR,
                                    (int)ClassLib.TBSFX_CBD_TAIL.IxFX_RATE);
                            }
                        }
                    }
                    else if (sDiv.Equals("MOLD") && (vFSP.Name.Equals(fgrid_sampMold.Name) || vFSP.Name.Equals(fgrid_prodMold.Name)))
                    {
                        foreach (C1.Win.C1FlexGrid.Row vData in vDatas)
                        {                          
                            int iRow = vFSP.Row;
                            C1.Win.C1FlexGrid.Row vNewRow = AddDetail(vFSP, iRow);

                            if (vNewRow != null)
                            {
                                vFSP.Select(vNewRow.Index, 0);

                                for (int iCol = (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxDIV; iCol < vFSP.Cols.Count; iCol++)
                                {
                                    vNewRow[iCol] = vData[iCol];
                                }

                                vNewRow[0] = "I";                                

                                if (vFSP.Name.Equals(fgrid_sampMold.Name))
                                {
                                    CalcSampMold(vNewRow.Index, vNewRow.Index);
                                    vNewRow[(int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS] = "SM";
                                }
                                else
                                {
                                    CalcProdMold(vNewRow.Index, vNewRow.Index);
                                    vNewRow[(int)ClassLib.TBSFX_CBD_TAIL.IxCBD_CLASS] = "PM";
                                }

                                SetFXRate(vFSP, vNewRow.Index, vNewRow.Index,
                                    (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxCURR,
                                    (int)ClassLib.TBSFX_CBD_TAIL_MOLD.IxFX_RATE);
                            }
                        }
                    }

                    CalcETCSummary();
                    CalcSummary();
                    CalcSummaryPersent();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Drag & Drop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        #region Button and etc

        private void UpdateRetail()
        {
            if (fgrid_labor.Rows.Count > fgrid_labor.Rows.Fixed && fgrid_overhead.Rows.Count > fgrid_overhead.Rows.Fixed)
            {
                string sFactory = cmb_hPROD_FAC.SelectedValue.ToString();
                string sSeason = cmb_hSEASON_CD.SelectedValue.ToString();
                string sCategory = cmb_hCAT_CD.SelectedValue.ToString();
                string sGender = COM.ComFunction.Empty_Combo(cmb_hGENDER, "");
                string sRetail = txt_hRETAIL_PRICE.Text.Replace(",", "");
                double dRetail = 0;
                string sResult = "";

                if (double.TryParse(sRetail, out dRetail))
                {
                    DataTable vDT = SELECT_SFX_GET_LABOR(sFactory, sSeason, sCategory, sGender, sRetail);
                    if (vDT != null && vDT.Rows.Count >= 1)
                    {
                        sResult = vDT.Rows[0][0].ToString();
                        fgrid_labor[fgrid_labor.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxOV_COST] = sResult;
                        fgrid_labor.Update_Row(fgrid_labor.Rows.Fixed);
                        //ModifyDetail(fgrid_labor, fgrid_labor.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxOV_COST);
                        CalcLabor(fgrid_labor.Rows.Fixed, fgrid_labor.Rows.Fixed);

                        sResult = vDT.Rows[0][1].ToString();
                        fgrid_overhead[fgrid_overhead.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_LOCAL] = sResult;
                        fgrid_overhead.Update_Row(fgrid_overhead.Rows.Fixed);
                        //ModifyDetail(fgrid_overhead, fgrid_overhead.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_LOCAL);
                        CalcOverhead(fgrid_overhead.Rows.Fixed, fgrid_overhead.Rows.Fixed);

                        CalcETCSummary();
                        CalcSummary();
                        CalcSummaryPersent();
                        return;
                    }
                }

                fgrid_labor[fgrid_labor.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL_LB.IxOV_COST] = 0;
                fgrid_labor.Update_Row(fgrid_labor.Rows.Fixed);
                CalcLabor(fgrid_labor.Rows.Fixed, fgrid_labor.Rows.Fixed);

                fgrid_overhead[fgrid_overhead.Rows.Fixed, (int)ClassLib.TBSFX_CBD_TAIL_OH.IxCOST_LOCAL] = 0;
                fgrid_overhead.Update_Row(fgrid_overhead.Rows.Fixed);
                CalcOverhead(fgrid_overhead.Rows.Fixed, fgrid_overhead.Rows.Fixed);

                CalcETCSummary();
                CalcSummary();
                CalcSummaryPersent();
            }
        }

        private void SeasonChanged()
        {
            string sDevFac = cmb_hDEV_FAC.SelectedValue.ToString();
            string sMOID = txt_hMOID.Text.Replace("-", "");
            string sCBDID = txt_hCBD_ID.Text;
            string sCBDVer = txt_hCBD_SEQ.Text;
            string sFOBType = cmb_hROUND_CD.SelectedValue.ToString();
            string sSeason = cmb_hSEASON_CD.SelectedValue.ToString();

            DataTable vDT = _ComFnc.SELECT_SFX_CBD_FXRATE(sDevFac, sMOID, sCBDID, sCBDVer, sFOBType, sSeason);
            DisplayFXRate(vDT);
            vDT.Dispose();

            // Summary 
            CalcUpper(-1, -1);
            CalcPackaging(-1, -1);
            CalcMidsole(-1, -1);
            CalcOutsole(-1, -1);
            CalcLabor(-1, -1);
            CalcOverhead(-1, -1);
            CalcSampMold(-1, -1);
            CalcProdMold(-1, -1);

            CalcETCSummary();
            CalcSummary();
            CalcSummaryPersent();

            // Update
            ModifyAllDetail(fgrid_upper);
            ModifyAllDetail(fgrid_packaging);
            ModifyAllDetail(fgrid_midsole);
            ModifyAllDetail(fgrid_outsole);
            ModifyAllDetail(fgrid_labor);
            ModifyAllDetail(fgrid_overhead);
            ModifyAllDetail(fgrid_sampMold);
            ModifyAllDetail(fgrid_prodMold);
        }

        #endregion

        #region Context menu

        private C1.Win.C1FlexGrid.Row AddDetail(COM.FSP arg_fsp, int arg_idx)
        {
            if (cmb_hDEV_FAC.SelectedIndex < 0)
                return null;

            C1.Win.C1FlexGrid.Row row = null;

            try
            {
                if (arg_idx == arg_fsp.Rows.Count - 1 || arg_idx < arg_fsp.Rows.Fixed)
                {
                    row = arg_fsp.Rows.Add();
                }
                else
                {
                    if (arg_fsp.Rows[arg_idx].IsNode)
                    {
                        if (arg_fsp.Rows[arg_idx].Node.Level == 0)
                        {
                            row = arg_fsp.Rows.Insert(arg_idx + 1 + arg_fsp.Rows[arg_idx].Node.Children);
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        row = arg_fsp.Rows.Insert(arg_idx + 1);
                    }
                }
                arg_fsp.Select(row.Index, 0);
                arg_fsp[row.Index, 0] = "I";
                row.IsNode = true;
                row.Node.Level = 0;

                // dev_fac, prod_fac, moid, cbd_id, cbd_ver, fob_type_cd
                row[FindCol(arg_fsp, "DEV_FAC")] = cmb_hDEV_FAC.SelectedValue;
                row[FindCol(arg_fsp, "MOID")] = txt_hMOID.Text.Replace("-", "");
                row[FindCol(arg_fsp, "CBD_ID")] = txt_hCBD_ID.Text;
                row[FindCol(arg_fsp, "CBD_SEQ")] = txt_hCBD_SEQ.Text;
                row[FindCol(arg_fsp, "FOB_TYPE_CD")] = cmb_hFOB_TYPE_CD.SelectedValue.ToString();
                //row[FindCol(arg_fsp, "REF")] = "A";
                int iDivCol = FindCol(arg_fsp, "DIV");
                if (iDivCol > 0)
                {
                    row[iDivCol] = GetTailDivision(arg_fsp);
                }

                // upper, packaging, midsole. outsole
                int iCurrCol = FindCol(arg_fsp, "CURR");
                if (iCurrCol > 1)
                {
                    if (arg_fsp.Name.Equals(fgrid_sampMold.Name) || arg_fsp.Name.Equals(fgrid_prodMold.Name))
                        row[iCurrCol] = "KRW";
                    else
                        row[iCurrCol] = "USD";
                }
                int iFxRateCol = FindCol(arg_fsp, "FX_RATE");
                if (iFxRateCol > 1)
                {
                    Control vCtl = pnl_head.Controls["txt_hFX_RATE_" + row[iCurrCol]];
                    row[iFxRateCol] = vCtl.Text;
                }
                int iMatUpriceCol = FindCol(arg_fsp, "MAT_UPRICE");
                if (iMatUpriceCol > 1)
                {
                    row[iMatUpriceCol] = 0;
                }
                int iFctLndPctCol = FindCol(arg_fsp, "FCT_LND_PCT");
                if (iFctLndPctCol > 1)
                {
                    row[iFctLndPctCol] = 0;
                }
                int iFctLndTotCol = FindCol(arg_fsp, "FCT_LND_TOT");
                if (iFctLndTotCol > 1)
                {
                    row[iFctLndTotCol] = 0;
                }
                int iFctLndUsdTotCol = FindCol(arg_fsp, "FCT_LND_USD_TOT");
                if (iFctLndUsdTotCol > 1)
                {
                    row[iFctLndUsdTotCol] = 0;
                }
                int iYieldCol = FindCol(arg_fsp, "YIELD");
                if (iYieldCol > 1)
                {
                    row[iYieldCol] = 0;
                }
                int iLossPctCol = FindCol(arg_fsp, "LOSS_PCT");
                if (iLossPctCol > 1)
                {
                    row[iLossPctCol] = 1;
                }
                int iUsageCol = FindCol(arg_fsp, "USAGE");
                if (iUsageCol > 1)
                {
                    row[iUsageCol] = 0;
                }
                int iUSCostCol = FindCol(arg_fsp, "USS_COST");
                if (iUSCostCol > 1)
                {
                    row[iUSCostCol] = 0;
                }
                int iSizeTotCostCol = FindCol(arg_fsp, "SIZE_TOTAL_COST");
                if (iSizeTotCostCol > 1)
                {
                    row[iSizeTotCostCol] = 0;
                }
                int iSizeUpChargeCol = FindCol(arg_fsp, "SIZEUP_CHARGE");
                if (iSizeUpChargeCol > 1)
                {
                    row[iSizeUpChargeCol] = 0;
                }
                int iPrssChargeCol = FindCol(arg_fsp, "PRSS_CHARGE");
                if (iPrssChargeCol > 1)
                {
                    row[iPrssChargeCol] = 0;
                }

                // mold
                if (arg_fsp.Name.Equals(fgrid_sampMold.Name) || arg_fsp.Name.Equals(fgrid_prodMold.Name))
                {
                    int ICBDClassCol = FindCol(arg_fsp, "CBD_CLASS");
                    if (ICBDClassCol > 1)
                    {
                        row[ICBDClassCol] = arg_fsp.Name.Equals(fgrid_sampMold.Name) ? "SM" : "PM";
                    }

                    int iMoldACntCol = FindCol(arg_fsp, "MOLDA_CNT");
                    if (iMoldACntCol > 1)
                    {
                        row[iMoldACntCol] = 0;
                    }
                    int iCostMoldACol = FindCol(arg_fsp, "COST_MOLDA");
                    if (iCostMoldACol > 1)
                    {
                        row[iCostMoldACol] = 0;
                    }
                    int iTotalCostCol = FindCol(arg_fsp, "TOT_COST");
                    if (iTotalCostCol > 1)
                    {
                        row[iTotalCostCol] = 0;
                    }
                    int iTotalCostUSDCol = FindCol(arg_fsp, "TOT_COST_USD");
                    if (iTotalCostUSDCol > 1)
                    {
                        row[iTotalCostUSDCol] = 0;
                    }
                    int iCostUSDPairCol = FindCol(arg_fsp, "COST_USD_PAIR");
                    if (iCostUSDPairCol > 1)
                    {
                        row[iCostUSDPairCol] = 0;
                    }
                    int iAmortPairsCol = FindCol(arg_fsp, "AMORT_PAIRS");
                    if (iAmortPairsCol > 1)
                    {
                        row[iAmortPairsCol] = txt_hFORECAST.Text;
                    }
                }

                return row;
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (row != null)
                    arg_fsp.Rows.Remove(row);
                return null;
            }
        }

        private void DelDetail(COM.FSP arg_fsp)
        {
            if (arg_fsp.Rows.Fixed < arg_fsp.Rows.Count && arg_fsp.Row >= arg_fsp.Rows.Fixed)
            {
                int iRefCol = FindCol(arg_fsp, "REF");

                int[] iSels = arg_fsp.Selections;
                for (int iIdx = iSels.Length - 1; iIdx >= 0; iIdx--)
                {
                    int iRow = iSels[iIdx];
                    if (arg_fsp[iRow, 0] == null || !arg_fsp[iRow, 0].ToString().Equals("I"))
                    {
                        if (arg_fsp.Rows[iRow].IsNode)
                        {
                            if (arg_fsp.Rows[iRow].Node.Level == 0)
                            {
                                arg_fsp[iRow, 0] = "D";
                                arg_fsp[iRow, iRefCol] = "D";
                            }
                        }
                        else
                        {
                            arg_fsp[iRow, 0] = "D";
                            arg_fsp[iRow, iRefCol] = "D";
                        }
                    }
                    else
                    {
                        if (arg_fsp.Rows[iRow].IsNode)
                        {
                            for (int iCRow = iRow + arg_fsp.Rows[iRow].Node.Children; iCRow >= iRow + 1; iCRow--)
                            {
                                arg_fsp.Rows.Remove(iCRow);
                            }
                        }

                        arg_fsp.Rows.Remove(iRow);
                    }
                }
            }
        }

        private void RemoveDetail(COM.FSP arg_fsp)
        {
            if (arg_fsp.Rows.Fixed < arg_fsp.Rows.Count && arg_fsp.Row >= arg_fsp.Rows.Fixed)
            {
                int iRefCol = FindCol(arg_fsp, "REF");

                int[] iSels = arg_fsp.Selections;
                for (int iIdx = iSels.Length - 1; iIdx >= 0; iIdx--)
                {
                    int iRow = iSels[iIdx];
                    if (arg_fsp[iRow, 0] == null || !arg_fsp[iRow, 0].ToString().Equals("I"))
                    {
                        if (arg_fsp.Rows[iRow].IsNode)
                        {
                            if (arg_fsp.Rows[iRow].Node.Level == 0)
                            {
                                arg_fsp[iRow, 0] = "R";
                                arg_fsp[iRow, iRefCol] = "R";
                            }
                        }
                        else
                        {
                            arg_fsp[iRow, 0] = "R";
                            arg_fsp[iRow, iRefCol] = "R";
                        }
                    }
                    else
                    {
                        if (arg_fsp.Rows[iRow].IsNode)
                        {
                            for (int iCRow = iRow + arg_fsp.Rows[iRow].Node.Children; iCRow >= iRow + 1; iCRow--)
                            {
                                arg_fsp.Rows.Remove(iCRow);
                            }
                        }

                        arg_fsp.Rows.Remove(iRow);
                    }
                }
            }
        }

        private void CancelDetail(COM.FSP arg_fsp)
        {
            if (arg_fsp.Rows.Fixed < arg_fsp.Rows.Count && arg_fsp.Row >= arg_fsp.Rows.Fixed)
            {
                int iRefCol = FindCol(arg_fsp, "REF");
                if (iRefCol > 0)
                {
                    for (int iRow = arg_fsp.Rows.Count - 1; iRow >= arg_fsp.Rows.Fixed; iRow--)
                    {
                        arg_fsp[iRow, iRefCol] = arg_fsp.GetCellRange(iRow, iRefCol).UserData;

                        if (arg_fsp[iRow, 0] != null && !arg_fsp[iRow, 0].ToString().Equals(""))
                        {
                            if (arg_fsp[iRow, 0].ToString().Equals("I"))
                                arg_fsp.RemoveItem(iRow);
                            else
                                arg_fsp[iRow, 0] = arg_fsp[iRow, iRefCol] = "";
                        }
                    }
                }
            }
        }

        private void ModifyDetail(COM.FSP arg_fsp, int iRow, int iCol)
        {
            if (arg_fsp.Rows.Fixed < arg_fsp.Rows.Count && iRow >= arg_fsp.Rows.Fixed)
            {
                if (arg_fsp.Rows[iRow].IsNode)
                {
                    if (arg_fsp.Rows[iRow].Node.Level == 0)
                    {
                        int iRefCol = FindCol(arg_fsp, "REF");
                        string sCurRef = arg_fsp[iRow, iRefCol] == null ? "" : arg_fsp[iRow, iRefCol].ToString().Trim();
                        if (sCurRef.Equals(""))
                            arg_fsp[iRow, iRefCol] = "U";
                    }
                }
                else
                {
                    int iRefCol = FindCol(arg_fsp, "REF");
                    string sCurRef = arg_fsp[iRow, iRefCol] == null ? "" : arg_fsp[iRow, iRefCol].ToString().Trim();
                    if (sCurRef.Equals(""))
                        arg_fsp[iRow, iRefCol] = "U";
                }
            }
        }

        private void ModifyAllDetail(COM.FSP arg_fsp)
        {
            if (arg_fsp.Rows.Fixed < arg_fsp.Rows.Count)
            {
                for (int iRow = arg_fsp.Rows.Fixed; iRow < arg_fsp.Rows.Count; iRow++)
                {
                    if (arg_fsp.Rows[iRow].IsNode)
                    {
                        if (arg_fsp.Rows[iRow].Node.Level == 0)
                        {
                            arg_fsp.Update_Row(iRow);
                        }
                    }
                    else
                    {
                        arg_fsp.Update_Row(iRow);
                    }
                }
            }
        }

        public void SetUpperYieldFLD()
        {
            string sDevFac = COM.ComFunction.Empty_Combo(cmb_hDEV_FAC, "");
            string sMOID = txt_hMOID.Text.Replace("-", "");
            string sCBDID = txt_hCBD_ID.Text;
            string sCBDVer = txt_hCBD_SEQ.Text;
            string sFOBTypeCD = COM.ComFunction.Empty_Combo(cmb_hFOB_TYPE_CD, "");

            DataTable vDT = SELECT_SFM_CBD_YIELD_FLD(sDevFac, sMOID, sCBDID, sCBDVer, sFOBTypeCD);

            if (vDT != null)
            {
                for (int iIdx = 0; iIdx < vDT.Rows.Count; iIdx++)
                {
                    string sCBDUPNo1 = vDT.Rows[iIdx][0].ToString();
                    string sYieldCnt = vDT.Rows[iIdx][1].ToString();
                    string sYieldFLD = vDT.Rows[iIdx][2].ToString();

                    for (int iRow = fgrid_upper.Rows.Fixed; iRow < fgrid_upper.Rows.Count; iRow++)
                    {
                        string sCBDUPNo2 = fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxCBD_NO].ToString();

                        if (sCBDUPNo1.Equals(sCBDUPNo2))
                        {
                            fgrid_upper[iRow, (int)ClassLib.TBSFX_CBD_TAIL.IxYIELD] = sYieldFLD;
                            fgrid_upper.Update_Row(iRow);
                            CalcUpper(iRow, iRow);
                        }
                    }
                }

                CalcETCSummary();
                CalcSummary();
                CalcSummaryPersent();
            }
        }

        #endregion

        #region Utility

        private string GetTailDivision(COM.FSP arg_fsp)
        {
            string sDiv = "";

            if (arg_fsp.Name.Equals(fgrid_upper.Name))
            {
                sDiv = "UPPER";
            }
            else if (arg_fsp.Name.Equals(fgrid_packaging.Name))
            {
                sDiv = "PACKAGING";
            }
            else if (arg_fsp.Name.Equals(fgrid_midsole.Name))
            {
                sDiv = "MIDSOLE";
            }
            else if (arg_fsp.Name.Equals(fgrid_outsole.Name))
            {
                sDiv = "OUTSOLE";
            }
            else if (arg_fsp.Name.Equals(fgrid_sampMold.Name))
            {
                sDiv = "SMPL_MOLD";
            }
            else if (arg_fsp.Name.Equals(fgrid_prodMold.Name))
            {
                sDiv = "PROD_MOLD";
            }

            return sDiv;
        }

        private int FindCol(COM.FSP arg_fsp, string col_name)
        {
            int iFindCol = -1;

            for (int ICol = 1; ICol < arg_fsp.Cols.Count; ICol++)
            {
                if (arg_fsp[0, ICol].ToString().Equals(col_name))
                    iFindCol = ICol;
            }

            return iFindCol;
        }

        private COM.FSP GetActiveGrid()
        {
            string sCurTabName = tabControl1.SelectedTab.Name;
            COM.FSP vFSP = null;

            switch (sCurTabName)
            {
                case "tabPage1":
                    vFSP = fgrid_upper;
                    break;
                case "tabPage2":
                    vFSP = fgrid_packaging;
                    break;
                case "tabPage3":
                    vFSP = fgrid_midsole;
                    break;
                case "tabPage4":
                    vFSP = fgrid_outsole;
                    break;
                case "tabPage5":
                    vFSP = fgrid_labor;
                    break;
                case "tabPage6":
                    vFSP = fgrid_overhead;
                    break;
                case "tabPage8":
                    vFSP = fgrid_sampMold;
                    break;
                case "tabPage9":
                    vFSP = fgrid_prodMold;
                    break;
            }

            return vFSP;
        }

        // 외부 접근용
        public DialogResult ShowDialog(string sDevFac, string sMOID, string sCBDID, string sCBDVer, string sFOBType)
        {
            try
            {
                cmb_hDEV_FAC.SelectedValue = sDevFac;
                txt_hMOID.Text = sMOID;
                txt_hCBD_ID.Text = sCBDID;
                txt_hCBD_SEQ.Text = sCBDVer;
                cmb_hFOB_TYPE_CD.SelectedValue = sFOBType;

                SearchForRefesh();

                return DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Show");
                return DialogResult.Abort;
            }
        }

        public string DIVISION
        {
            set
            {
                _Division = value;
            }
        }

        private DataTable GetOBSIDList(string arg_type, out int iSelIdx)
        {
            DataTable vDT = new DataTable("OBS_ID");
            vDT.Columns.Add("OBS_ID_CODE");
            vDT.Columns.Add("OBS_ID_NAME");
            iSelIdx = -1;

            int iIdx = 0;
            DateTime CurDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));

            switch (arg_type)
            {
                case "OR":
                    for (iIdx = -1; iIdx <= 1; iIdx++)
                    {
                        DataRow vDR = vDT.NewRow();
                        vDR[0] = CurDate.AddYears(iIdx).ToString("yyyy-MM-dd").Substring(2, 2) + "0605";
                        vDR[1] = CurDate.AddYears(iIdx).ToString("yyyy-MM-dd").Substring(2, 2) + "0605";
                        vDT.Rows.Add(vDR);
                    }

                    iSelIdx = 1;
                    break;

                case "SS":
                    for (iIdx = -1; iIdx <= 1; iIdx++)
                    {
                        DataRow vDR = vDT.NewRow();
                        vDR[0] = CurDate.AddYears(iIdx).ToString("yyyy-MM-dd").Substring(2, 2) + "0112";
                        vDR[1] = CurDate.AddYears(iIdx).ToString("yyyy-MM-dd").Substring(2, 2) + "0112";
                        vDT.Rows.Add(vDR);
                    }

                    iSelIdx = 1;
                    break;

                case "PS":
                    for (iIdx = -1; iIdx <= 1; iIdx++)
                    {
                        DataRow vDR = vDT.NewRow();
                        vDR[0] = CurDate.AddYears(iIdx).ToString("yyyy-MM-dd").Substring(2, 2) + "0112";
                        vDR[1] = CurDate.AddYears(iIdx).ToString("yyyy-MM-dd").Substring(2, 2) + "0112";
                        vDT.Rows.Add(vDR);
                    }

                    iSelIdx = 1;
                    break;

                case "TS":
                case "TP":
                case "ID":
                    for (iIdx = -15; iIdx <= 10; iIdx++)
                    {
                        DataRow vDR = vDT.NewRow();

                        string sDate = CurDate.AddMonths(iIdx).ToString("yyyy-MM-dd");
                        sDate = sDate.Substring(2, 2) + sDate.Substring(5, 2) + "01";

                        vDR[0] = sDate;
                        vDR[1] = sDate;
                        vDT.Rows.Add(vDR);
                    }

                    iSelIdx = 3;
                    break;

                case "QQ":

                    for (iIdx = -3; iIdx <= 10; iIdx++)
                    {
                        string sDate1 = CurDate.AddMonths(iIdx).ToString("yyyy-MM-dd");
                        string sDate2 = CurDate.AddMonths(iIdx + 1).ToString("yyyy-MM-dd");
                        sDate1 = sDate1.Substring(2, 2) + sDate1.Substring(5, 2) + sDate2.Substring(5, 2); ;

                        DataRow vDR = vDT.NewRow();
                        vDR[0] = sDate1;
                        vDR[1] = sDate1;
                        vDT.Rows.Add(vDR);
                    }

                    iSelIdx = 3;
                    break;

                case "FT": 
                    for (iIdx = -15; iIdx <= 10; iIdx++)
                    {
                        string sDate1 = CurDate.AddMonths(iIdx).ToString("yyyy-MM-dd");
                        string sDate2 = CurDate.AddMonths(iIdx + 2).ToString("yyyy-MM-dd");

                        sDate1 = sDate1.Substring(2, 2) + sDate1.Substring(5, 2) + sDate2.Substring(5, 2);

                        DataRow vDR = vDT.NewRow();
                        vDR[0] = sDate1;
                        vDR[1] = sDate1;
                        vDT.Rows.Add(vDR);
                    }

                    iSelIdx = 5;
                    break;
            }

            return vDT;
        }

        #endregion

        #endregion

        #region 데이터베이스

        #region Save

        /// <summary>
        /// PKG_SFX_CBD_MASTER_SAVE.CHECK_SFX_CBD_HEAD : 
        /// </summary>
        public DataTable CHECK_SFX_CBD_HEAD()
        {
            try
            {

                MyOraDB.ReDim_Parameter(10);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_SAVE.CHECK_SFX_CBD_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[3] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[4] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[6] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[7] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[8] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[9] = "OUT_CURSOR";

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
                MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_hDEV_FAC, "");
                MyOraDB.Parameter_Values[1] = txt_hMOID.Text;
                MyOraDB.Parameter_Values[2] = txt_hCBD_ID.Text;
                MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_hFOB_TYPE_CD, "");
                MyOraDB.Parameter_Values[4] = txt_hCBD_SEQ.Text;
                MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_Combo(cmb_hPROD_FAC, "");
                MyOraDB.Parameter_Values[6] = txt_hPRODUCT_CD.Text.Replace("-", "");
                MyOraDB.Parameter_Values[7] = COM.ComFunction.Empty_Combo(cmb_hOBS_ID, "");
                MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_Combo(cmb_hOBS_TYPE, "");
                MyOraDB.Parameter_Values[9] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();

                return vDS.Tables["PKG_SFX_CBD_MASTER_SAVE.CHECK_SFX_CBD_HEAD"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PKG_SFX_CBD_MASTER_SAVE.SAVE_SFM_CBD_HEAD : 
        /// </summary>
        private bool SAVE_SFM_CBD_HEAD(string arg_division)
        {
            try
            {
                MyOraDB.ReDim_Parameter(86);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[2] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[3] = "ARG_CLASS_CD";
                MyOraDB.Parameter_Name[4] = "ARG_MOID";
                MyOraDB.Parameter_Name[5] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[6] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[7] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[8] = "ARG_BOM_REV";
                MyOraDB.Parameter_Name[9] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[10] = "ARG_FOB_TYPE";
                
                MyOraDB.Parameter_Name[11] = "ARG_ROUND_CD";
                MyOraDB.Parameter_Name[12] = "ARG_FOB_STATUS";
                MyOraDB.Parameter_Name[13] = "ARG_CBD_STAGE";
                MyOraDB.Parameter_Name[14] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[15] = "ARG_PRODUCT_CD";
                MyOraDB.Parameter_Name[16] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[17] = "ARG_MODEL_NAME";
                MyOraDB.Parameter_Name[18] = "ARG_MARKETING_NAME";
                MyOraDB.Parameter_Name[19] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[20] = "ARG_SEASON";
                
                MyOraDB.Parameter_Name[21] = "ARG_CAT_CD";
                MyOraDB.Parameter_Name[22] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[23] = "ARG_DATE_QUOTED";
                MyOraDB.Parameter_Name[24] = "ARG_GENDER";
                MyOraDB.Parameter_Name[25] = "ARG_SIZE_REP";
                MyOraDB.Parameter_Name[26] = "ARG_SIZEUP_PCT";
                MyOraDB.Parameter_Name[27] = "ARG_TD_CD";
                MyOraDB.Parameter_Name[28] = "ARG_TD";
                MyOraDB.Parameter_Name[29] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[30] = "ARG_OBS_TYPE";
                
                MyOraDB.Parameter_Name[31] = "ARG_RETAIL_PRICE";
                MyOraDB.Parameter_Name[32] = "ARG_TARGET_FOB";
                MyOraDB.Parameter_Name[33] = "ARG_FORECAST";

                MyOraDB.Parameter_Name[34] = "ARG_UPPER_SUMM_CBD";
                MyOraDB.Parameter_Name[35] = "ARG_UPPER_SUMM_PCT";
                MyOraDB.Parameter_Name[36] = "ARG_PACKING_SUMM_CBD";
                MyOraDB.Parameter_Name[37] = "ARG_PACKING_SUMM_PCT";
                MyOraDB.Parameter_Name[38] = "ARG_MIDSOLE_SUMM_CBD";
                MyOraDB.Parameter_Name[39] = "ARG_MIDSOLE_SUMM_PCT";
                MyOraDB.Parameter_Name[40] = "ARG_OUTSOLE_SUMM_CBD";                
                MyOraDB.Parameter_Name[41] = "ARG_OUTSOLE_SUMM_PCT";
                MyOraDB.Parameter_Name[42] = "ARG_SIZEUP_SUMM_CBD";
                MyOraDB.Parameter_Name[43] = "ARG_SIZEUP_SUMM_PCT";
                MyOraDB.Parameter_Name[44] = "ARG_MAT_SUMM_CBD";
                MyOraDB.Parameter_Name[45] = "ARG_MAT_SUMM_PCT";

                MyOraDB.Parameter_Name[46] = "ARG_LABOR_SUMM_CBD";
                MyOraDB.Parameter_Name[47] = "ARG_LABOR_SUMM_PCT";
                MyOraDB.Parameter_Name[48] = "ARG_OVERHEAD_SUMM_CBD";
                MyOraDB.Parameter_Name[49] = "ARG_OVERHEAD_SUMM_PCT";
                MyOraDB.Parameter_Name[50] = "ARG_PROFIT_SUMM_CBD";
                MyOraDB.Parameter_Name[51] = "ARG_PROFIT_SUMM_PCT";
                MyOraDB.Parameter_Name[52] = "ARG_PRSS_SUMM_CBD";                
                MyOraDB.Parameter_Name[53] = "ARG_PRSS_SUMM_PCT";
                MyOraDB.Parameter_Name[54] = "ARG_OTHERADJ_SUMM_CBD";
                MyOraDB.Parameter_Name[55] = "ARG_OTHERADJ_SUMM_PCT";
                MyOraDB.Parameter_Name[56] = "ARG_NON_MAT_SUMM_CBD";
                MyOraDB.Parameter_Name[57] = "ARG_NON_MAT_SUMM_PCT";

                MyOraDB.Parameter_Name[58] = "ARG_SMPL_TOOL_SUMM_CBD";
                MyOraDB.Parameter_Name[59] = "ARG_SMPL_TOOL_SUMM_PCT";
                MyOraDB.Parameter_Name[60] = "ARG_PROD_TOOL_SUMM_CBD";
                MyOraDB.Parameter_Name[61] = "ARG_PROD_TOOL_SUMM_PCT";
                MyOraDB.Parameter_Name[62] = "ARG_TOOL_SUMM_CBD";
                MyOraDB.Parameter_Name[63] = "ARG_TOOL_SUMM_PCT";
                MyOraDB.Parameter_Name[64] = "ARG_FOB";

                MyOraDB.Parameter_Name[65] = "ARG_LABOR_CMT";
                MyOraDB.Parameter_Name[66] = "ARG_OVERHEAD_CMT";
                MyOraDB.Parameter_Name[67] = "ARG_TOT_MLOS";
                
                MyOraDB.Parameter_Name[68] = "ARG_PROFIT_PCT";
                MyOraDB.Parameter_Name[69] = "ARG_PROFIT";
                MyOraDB.Parameter_Name[70] = "ARG_LEAN_SAVE_TGT";
                MyOraDB.Parameter_Name[71] = "ARG_SIZERUN";
                MyOraDB.Parameter_Name[72] = "ARG_TOT_SIZERUN";
                MyOraDB.Parameter_Name[73] = "ARG_LEATHER";
                MyOraDB.Parameter_Name[74] = "ARG_RP";
                MyOraDB.Parameter_Name[75] = "ARG_TEXTILE";
                MyOraDB.Parameter_Name[76] = "ARG_WHQ_DEV";
                MyOraDB.Parameter_Name[77] = "ARG_NLO_DEV";                
                MyOraDB.Parameter_Name[78] = "ARG_PCC_DEV";
                MyOraDB.Parameter_Name[79] = "ARG_PCC_PE";
                MyOraDB.Parameter_Name[80] = "ARG_PCC_TE";
                MyOraDB.Parameter_Name[81] = "ARG_NLO_COSTER";
                MyOraDB.Parameter_Name[82] = "ARG_PCC_COSTER";
                MyOraDB.Parameter_Name[83] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[84] = "ARG_CHECK_COMMENTS";
                MyOraDB.Parameter_Name[85] = "ARG_UPD_USER";


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
                MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[20] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[21] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[22] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[23] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[24] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[25] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[26] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[27] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[28] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[29] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[30] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[31] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[32] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[33] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[34] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[35] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[36] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[37] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[38] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[39] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[40] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[41] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[42] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[43] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[44] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[45] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[46] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[47] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[48] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[49] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[50] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[51] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[52] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[53] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[54] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[55] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[56] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[57] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[58] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[59] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[60] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[61] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[62] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[63] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[64] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[65] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[66] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[67] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[68] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[69] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[70] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[71] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[72] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[73] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[74] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[75] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[76] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[77] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[78] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[79] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[80] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[81] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[82] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[83] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[84] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[85] = (int)OracleType.VarChar;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_division;
                MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_hDEV_FAC, "");                    // arg_dev_fact
                MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_hPROD_FAC, "");                   // arg_prod_fac
                MyOraDB.Parameter_Values[3] = null;                                                             // arg_class_cd;
                MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_TextBox(txt_hMOID, "").Replace("-", "");    // moid
                MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_TextBox(txt_hCBD_ID, "");                   // arg_cbd_id;
                MyOraDB.Parameter_Values[6] = COM.ComFunction.Empty_TextBox(txt_hCBD_SEQ, "");                  // arg_cbd_seq;
                MyOraDB.Parameter_Values[7] = COM.ComFunction.Empty_TextBox(txt_hBOM_ID, "");                   // arg_bom_id
                MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_TextBox(txt_hBOM_REV, "");                  // arg_bom_rev;
                MyOraDB.Parameter_Values[9] = COM.ComFunction.Empty_Combo(cmb_hFOB_TYPE_CD, "");                // arg_fob_type_cd
                MyOraDB.Parameter_Values[10] = cmb_hFOB_TYPE_CD.SelectedText;                                   // arg_fob_type
                
                MyOraDB.Parameter_Values[11] = COM.ComFunction.Empty_Combo(cmb_hROUND_CD, "");                  // arg_round_cd
                MyOraDB.Parameter_Values[12] = COM.ComFunction.Empty_Combo(cmb_hFOB_STATUS, "");                // arg_fob_status
                MyOraDB.Parameter_Values[13] = COM.ComFunction.Empty_TextBox(txt_hCBD_STAGE, ""); ;             // arg_cbd_stage;
                MyOraDB.Parameter_Values[14] = COM.ComFunction.Empty_TextBox(txt_hPRODUCT_CD, "").Replace("-", ""); // arg_style_cd
                MyOraDB.Parameter_Values[15] = COM.ComFunction.Empty_TextBox(txt_hPRODUCT_CD, "").Replace("-", ""); // arg_product_cd
                MyOraDB.Parameter_Values[16] = COM.ComFunction.Empty_TextBox(txt_hMODEL_ID, "");                // arg_model_id
                MyOraDB.Parameter_Values[17] = COM.ComFunction.Empty_TextBox(txt_hMODEL_NAME, "");              // arg_model_name
                MyOraDB.Parameter_Values[18] = null;                                                            // arg_marketing_name;
                MyOraDB.Parameter_Values[19] = COM.ComFunction.Empty_Combo(cmb_hSEASON_CD, "");                 // arg_season_cd
                MyOraDB.Parameter_Values[20] = cmb_hSEASON_CD.SelectedText;                                     // arg_season
                
                MyOraDB.Parameter_Values[21] = COM.ComFunction.Empty_Combo(cmb_hCAT_CD, "");                    // arg_cat_cd
                MyOraDB.Parameter_Values[22] = cmb_hCAT_CD.SelectedText;                                        // arg_category
                MyOraDB.Parameter_Values[23] = dpick_hDATE_QUOTED.Value.ToString("yyyyMMdd");                   // arg_date_quoted
                MyOraDB.Parameter_Values[24] = COM.ComFunction.Empty_Combo(cmb_hGENDER, "");                    // arg_gender
                MyOraDB.Parameter_Values[25] = COM.ComFunction.Empty_TextBox(txt_hSIZE_REP, "");                // arg_size_rep
                MyOraDB.Parameter_Values[26] = COM.ComFunction.Empty_TextBox(txt_hSIZEUP_PCT, "");              // arg_sizeup_pct
                MyOraDB.Parameter_Values[27] = COM.ComFunction.Empty_Combo(cmb_hTD_CD, "");                     // arg_td_cd
                MyOraDB.Parameter_Values[28] = cmb_hTD_CD.SelectedText;                                         // arg_td
                MyOraDB.Parameter_Values[29] = COM.ComFunction.Empty_Combo(cmb_hOBS_ID, "");                    // arg_obs_id
                MyOraDB.Parameter_Values[30] = COM.ComFunction.Empty_Combo(cmb_hOBS_TYPE, "FT");                // arg_obs_type

                MyOraDB.Parameter_Values[31] = txt_hRETAIL_PRICE.Text.Replace(",", "");                         // arg_retail_price;
                MyOraDB.Parameter_Values[32] = txt_hTARGET_FOB.Text.Replace(",", "");                           // arg_target_fob;
                MyOraDB.Parameter_Values[33] = COM.ComFunction.Empty_TextBox(txt_hFORECAST, "").Replace(",", "");                     // Boxarg_forecast

                MyOraDB.Parameter_Values[34] = txt_hUPPER_SUMM_CBD.Tag == null ? "0" : txt_hUPPER_SUMM_CBD.Tag.ToString();            // arg_upper_summ_cbd
                MyOraDB.Parameter_Values[35] = txt_hUPPER_SUMM_PCT.Tag == null ? "0" : txt_hUPPER_SUMM_PCT.Tag.ToString();            // arg_upper_summ_pct
                MyOraDB.Parameter_Values[36] = txt_hPACKING_SUMM_CBD.Tag == null ? "0" : txt_hPACKING_SUMM_CBD.Tag.ToString();        // arg_packing_summ_cbd
                MyOraDB.Parameter_Values[37] = txt_hPACKING_SUMM_PCT.Tag == null ? "0" : txt_hPACKING_SUMM_PCT.Tag.ToString();        // arg_packing_summ_pct
                MyOraDB.Parameter_Values[38] = txt_hMIDSOLE_SUMM_CBD.Tag == null ? "0" : txt_hMIDSOLE_SUMM_CBD.Tag.ToString();        // arg_midsole_summ_cbd
                MyOraDB.Parameter_Values[39] = txt_hMIDSOLE_SUMM_PCT.Tag == null ? "0" : txt_hMIDSOLE_SUMM_PCT.Tag.ToString();        // arg_midsole_summ_pct
                MyOraDB.Parameter_Values[40] = txt_hOUTSOLE_SUMM_CBD.Tag == null ? "0" : txt_hOUTSOLE_SUMM_CBD.Tag.ToString();        // arg_outsole_summ_cbd                
                MyOraDB.Parameter_Values[41] = txt_hOUTSOLE_SUMM_PCT.Tag == null ? "0" : txt_hOUTSOLE_SUMM_PCT.Tag.ToString();        // arg_outsole_summ_pct
                MyOraDB.Parameter_Values[42] = txt_hSIZEUP_SUMM_CBD.Tag == null ? "0" : txt_hSIZEUP_SUMM_CBD.Tag.ToString();          // arg_sizeup_summ_cbd
                MyOraDB.Parameter_Values[43] = txt_hSIZEUP_SUMM_PCT.Tag == null ? "0" : txt_hSIZEUP_SUMM_PCT.Tag.ToString();          // arg_sizeup_summ_pct
                MyOraDB.Parameter_Values[44] = txt_hMAT_SUMM_CBD.Tag == null ? "0" : txt_hMAT_SUMM_CBD.Tag.ToString();                // arg_mat_summ_cbd
                MyOraDB.Parameter_Values[45] = txt_hMAT_SUMM_PCT.Tag == null ? "0" : txt_hMAT_SUMM_PCT.Tag.ToString();                // arg_mat_summ_pct

                MyOraDB.Parameter_Values[46] = txt_hLABOR_SUMM_CBD.Tag == null ? "0" : txt_hLABOR_SUMM_CBD.Tag.ToString();            // arg_labor_summ_cbd
                MyOraDB.Parameter_Values[47] = txt_hLABOR_SUMM_PCT.Tag == null ? "0" : txt_hLABOR_SUMM_PCT.Tag.ToString();            // arg_labor_summ_pct
                MyOraDB.Parameter_Values[48] = txt_hOVERHEAD_SUMM_CBD.Tag == null ? "0" : txt_hOVERHEAD_SUMM_CBD.Tag.ToString();      // arg_overhead_summ_cbd
                MyOraDB.Parameter_Values[49] = txt_hOVERHEAD_SUMM_PCT.Tag == null ? "0" : txt_hOVERHEAD_SUMM_PCT.Tag.ToString();      // arg_overhead_summ_pct
                MyOraDB.Parameter_Values[50] = txt_hPROFIT_SUMM_CBD.Tag == null ? "0" : txt_hPROFIT_SUMM_CBD.Tag.ToString();          //arg_profit_summ_cbd
                MyOraDB.Parameter_Values[51] = txt_hPROFIT_SUMM_PCT.Tag == null ? "0" : txt_hPROFIT_SUMM_PCT.Tag.ToString();          //arg_profit_summ_pct
                MyOraDB.Parameter_Values[52] = txt_hPRSS_SUMM_CBD.Tag == null ? "0" : txt_hPRSS_SUMM_CBD.Tag.ToString();              // arg_prss_summ_cbd                
                MyOraDB.Parameter_Values[53] = txt_hPRSS_SUMM_PCT.Tag == null ? "0" : txt_hPRSS_SUMM_PCT.Tag.ToString();              // arg_prss_summ_pct
                MyOraDB.Parameter_Values[54] = txt_hOTHERADJ_SUMM_CBD.Tag == null ? "0" : txt_hOTHERADJ_SUMM_CBD.Tag.ToString();      // arg_otheradj_summ_cbd
                MyOraDB.Parameter_Values[55] = txt_hOTHERADJ_SUMM_PCT.Tag == null ? "0" : txt_hOTHERADJ_SUMM_PCT.Tag.ToString();      // arg_otheradj_summ_pct
                MyOraDB.Parameter_Values[56] = txt_hNON_MAT_SUMM_CBD.Tag == null ? "0" : txt_hNON_MAT_SUMM_CBD.Tag.ToString();        // arg_non_mat_summ_cbd
                MyOraDB.Parameter_Values[57] = txt_hNON_MAT_SUMM_PCT.Tag == null ? "0" : txt_hNON_MAT_SUMM_PCT.Tag.ToString();        // arg_non_mat_summ_pct

                MyOraDB.Parameter_Values[58] = txt_hSMPL_TOOL_SUMM_CBD.Tag == null ? "0" : txt_hSMPL_TOOL_SUMM_CBD.Tag.ToString();    // arg_smpl_tool_summ_cbd
                MyOraDB.Parameter_Values[59] = txt_hSMPL_TOOL_SUMM_PCT.Tag == null ? "0" : txt_hSMPL_TOOL_SUMM_PCT.Tag.ToString();    // arg_smpl_tool_summ_pct
                MyOraDB.Parameter_Values[60] = txt_hPROD_TOOL_SUMM_CBD.Tag == null ? "0" : txt_hPROD_TOOL_SUMM_CBD.Tag.ToString();    // arg_prod_tool_summ_cbd
                MyOraDB.Parameter_Values[61] = txt_hPROD_TOOL_SUMM_PCT.Tag == null ? "0" : txt_hPROD_TOOL_SUMM_PCT.Tag.ToString();    // arg_prod_tool_summ_pct
                MyOraDB.Parameter_Values[62] = txt_hTOOL_SUMM_CBD.Tag == null ? "0" : txt_hTOOL_SUMM_CBD.Tag.ToString();              // arg_tool_summ_cbd
                MyOraDB.Parameter_Values[63] = txt_hTOOL_SUMM_PCT.Tag == null ? "0" : txt_hTOOL_SUMM_PCT.Tag.ToString();              // arg_tool_summ_pct
                MyOraDB.Parameter_Values[64] = txt_hFOB.Tag == null ? "0" : txt_hFOB.Tag.ToString();                                  // arg_prod_tool_summ_pct

                MyOraDB.Parameter_Values[65] = COM.ComFunction.Empty_TextBox(txt_hLABOR_CMT, "");               // arg_labor_cmt
                MyOraDB.Parameter_Values[66] = COM.ComFunction.Empty_TextBox(txt_hOVERHEAD_CMT, "");            // arg_overhead_cmt
                MyOraDB.Parameter_Values[67] = txt_hTOT_MLOS.Tag == null ? "0" : txt_hTOT_MLOS.Tag.ToString();  // arg_tot_mlos;
                
                MyOraDB.Parameter_Values[68] = COM.ComFunction.Empty_TextBox(txt_hPROFIT_PCT, "0");             // arg_profit_pct;
                MyOraDB.Parameter_Values[69] = txt_hPROFIT.Tag == null ? "0" : txt_hPROFIT.Tag.ToString();      // arg_profit;
                MyOraDB.Parameter_Values[70] = COM.ComFunction.Empty_TextBox(txt_hLEAN_SAVE_TGT, "");           // arg_lean_save_tgt
                MyOraDB.Parameter_Values[71] = COM.ComFunction.Empty_TextBox(txt_hSIZERUN, "");                 // arg_sizerun
                MyOraDB.Parameter_Values[72] = COM.ComFunction.Empty_TextBox(txt_hTOT_SIZERUN, "0");            // arg_tot_sizerun;
                MyOraDB.Parameter_Values[73] = null;    // arg_leather;
                MyOraDB.Parameter_Values[74] = null;    // arg_rp;
                MyOraDB.Parameter_Values[75] = null;    // arg_textile;
                MyOraDB.Parameter_Values[76] = null;    // arg_whq_dev;
                MyOraDB.Parameter_Values[77] = COM.ComFunction.Empty_TextBox(txt_hNLO_CHARGE, "");                // arg_nlo_dev                
                MyOraDB.Parameter_Values[78] = COM.ComFunction.Empty_TextBox(txt_hPCC_CHARGE, "");                // arg_pcc_dev
                MyOraDB.Parameter_Values[79] = null;    // arg_pcc_pe;
                MyOraDB.Parameter_Values[80] = null;    // arg_pcc_te;
                MyOraDB.Parameter_Values[81] = null;    // arg_nlo_coster;
                MyOraDB.Parameter_Values[82] = null;    // arg_pcc_coster;
                MyOraDB.Parameter_Values[83] = txt_hREMARKS.Text;
                MyOraDB.Parameter_Values[84] = txt_hCHECK_COMMENTS.Text;
                MyOraDB.Parameter_Values[85] = COM.ComVar.This_User;

                return MyOraDB.Add_Modify_Parameter(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFX_CBD_MASTER_SAVE.SAVE_SFM_CBD_FXRATE : 
        /// </summary>
        private bool SAVE_SFM_CBD_FXRATE()
        {
            try
            {
                MyOraDB.ReDim_Parameter(13);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_FXRATE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[2] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[3] = "ARG_MOID";
                MyOraDB.Parameter_Name[4] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[5] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[6] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[7] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[8] = "ARG_STATUS";
                MyOraDB.Parameter_Name[9] = "ARG_CURR";
                MyOraDB.Parameter_Name[10] = "ARG_COUNTRY";
                MyOraDB.Parameter_Name[11] = "ARG_FX_RATE";
                MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";

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

                //04.DATA 정의
                int iTotIdx = 0;
                int iIdx = 0;
                foreach (System.Windows.Forms.Control ctl in pnl_head.Controls)
                {
                    if (ctl.Name.StartsWith("txt_hCURR_CD_"))
                    {
                        iTotIdx += MyOraDB.Parameter_Name.Length;
                    }
                }

                if (iTotIdx > 0)
                {
                    iTotIdx += MyOraDB.Parameter_Name.Length;
                    MyOraDB.Parameter_Values = new string[iTotIdx];

                    MyOraDB.Parameter_Values[iIdx++] = "D";
                    MyOraDB.Parameter_Values[iIdx++] = COM.ComFunction.Empty_Combo(cmb_hDEV_FAC, "");
                    MyOraDB.Parameter_Values[iIdx++] = COM.ComFunction.Empty_Combo(cmb_hPROD_FAC, "");
                    MyOraDB.Parameter_Values[iIdx++] = txt_hMOID.Text.Replace("-", "");
                    MyOraDB.Parameter_Values[iIdx++] = txt_hCBD_ID.Text;
                    MyOraDB.Parameter_Values[iIdx++] = txt_hCBD_SEQ.Text;
                    MyOraDB.Parameter_Values[iIdx++] = cmb_hFOB_TYPE_CD.SelectedValue.ToString();
                    MyOraDB.Parameter_Values[iIdx++] = COM.ComFunction.Empty_Combo(cmb_hSEASON_CD, "");
                    MyOraDB.Parameter_Values[iIdx++] = txt_hCBD_STAGE.Text;
                    MyOraDB.Parameter_Values[iIdx++] = null;
                    MyOraDB.Parameter_Values[iIdx++] = null;
                    MyOraDB.Parameter_Values[iIdx++] = null;
                    MyOraDB.Parameter_Values[iIdx++] = COM.ComVar.This_User;
                }

                foreach (System.Windows.Forms.Control ctl in pnl_head.Controls)
                {
                    if (ctl.Name.StartsWith("txt_hCURR_CD_"))
                    {
                        System.Windows.Forms.Control vCurr = pnl_head.Controls["txt_hCURR_CD_" + ctl.Text];
                        System.Windows.Forms.Control vFXRate = pnl_head.Controls["txt_hFX_RATE_" + ctl.Text];
                        System.Windows.Forms.Control vCountry = pnl_head.Controls["txt_hCOUNTRY_" + ctl.Text];

                        MyOraDB.Parameter_Values[iIdx++] = "I";
                        MyOraDB.Parameter_Values[iIdx++] = COM.ComFunction.Empty_Combo(cmb_hDEV_FAC, "");
                        MyOraDB.Parameter_Values[iIdx++] = COM.ComFunction.Empty_Combo(cmb_hPROD_FAC, "");
                        MyOraDB.Parameter_Values[iIdx++] = txt_hMOID.Text.Replace("-", "");
                        MyOraDB.Parameter_Values[iIdx++] = txt_hCBD_ID.Text;
                        MyOraDB.Parameter_Values[iIdx++] = txt_hCBD_SEQ.Text;
                        MyOraDB.Parameter_Values[iIdx++] = cmb_hFOB_TYPE_CD.SelectedValue.ToString();
                        MyOraDB.Parameter_Values[iIdx++] = COM.ComFunction.Empty_Combo(cmb_hSEASON_CD, "");
                        MyOraDB.Parameter_Values[iIdx++] = txt_hCBD_STAGE.Text;
                        MyOraDB.Parameter_Values[iIdx++] = vCurr.Text;
                        MyOraDB.Parameter_Values[iIdx++] = vCountry.Text;
                        MyOraDB.Parameter_Values[iIdx++] = vFXRate.Text;
                        MyOraDB.Parameter_Values[iIdx++] = COM.ComVar.This_User;
                    }
                }

                return MyOraDB.Add_Modify_Parameter(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_MASTER_CONFIRM : 
        /// </summary>
        public bool SAVE_SFX_CBD_MASTER_CONFIRM(string arg_div, string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd, string arg_upd_user)
        {
            try
            {

                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_MASTER_CONFIRM";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[2] = "ARG_MOID";
                MyOraDB.Parameter_Name[3] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[4] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_div;
                MyOraDB.Parameter_Values[1] = arg_dev_fac;
                MyOraDB.Parameter_Values[2] = arg_moid;
                MyOraDB.Parameter_Values[3] = arg_cbd_id;
                MyOraDB.Parameter_Values[4] = arg_cbd_seq;
                MyOraDB.Parameter_Values[5] = arg_fob_type_cd;
                MyOraDB.Parameter_Values[6] = arg_upd_user;

                MyOraDB.Add_Modify_Parameter(false);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Search

        /// <summary>
        /// PKG_SFX_CBD_MASTER_SAVE.SELECT_NEXT_CBD_VER : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_NEXT_CBD_VER(string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_fob_type_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_SAVE.SELECT_NEXT_CBD_VER";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[3] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_dev_fac;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = arg_cbd_id;
                MyOraDB.Parameter_Values[3] = arg_fob_type_cd;
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

        /// <summary>
        /// PKG_SFB_COMMON.SELECT_SFX_GET_LABOR : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_GET_LABOR(string arg_factory, string arg_season_cd, string arg_category, string arg_gender, string arg_retail_rate)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFB_COMMON.SELECT_SFX_GET_LABOR";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[2] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[3] = "ARG_GENDER";
                MyOraDB.Parameter_Name[4] = "ARG_RETAIL_RATE";
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
                MyOraDB.Parameter_Values[2] = arg_category;
                MyOraDB.Parameter_Values[3] = arg_gender;
                MyOraDB.Parameter_Values[4] = arg_retail_rate;
                MyOraDB.Parameter_Values[5] = "";

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

        /// <summary>
        /// PKG_SFX_CBD_TAIL_PROCOST.SELECT_SFM_CBD_YIELD_FLD : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFM_CBD_YIELD_FLD(string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_TAIL_PROCOST.SELECT_SFX_CBD_YIELD_FLD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[3] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_dev_fac;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = arg_cbd_id;
                MyOraDB.Parameter_Values[3] = arg_cbd_seq;
                MyOraDB.Parameter_Values[4] = arg_fob_type_cd;
                MyOraDB.Parameter_Values[5] = "";

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

        #region MEF, 5523

        /// <summary>
        /// PKG_EBM_FOB_5523.SELECT_EBM_FOB_DETAIL_REGION : 
        /// </summary>
        public System.Data.DataTable SELECT_EBM_FOB_DETAIL_REGION(
            string arg_factory, string arg_style_cd,
            string arg_mo_alias, string arg_bom_id, string arg_fob_type)
        {
            try
            {

                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_5523.SELECT_EBM_FOB_DETAIL_REGION";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[3] = "ARG_FOB_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_ID";
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
                MyOraDB.Parameter_Values[1] = arg_style_cd;
                MyOraDB.Parameter_Values[2] = arg_mo_alias;
                MyOraDB.Parameter_Values[3] = arg_fob_type;
                MyOraDB.Parameter_Values[4] = arg_bom_id;
                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();
                if (vDS != null)
                    return vDS.Tables[MyOraDB.Process_Name];

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MEOF_HEAD : 
        /// </summary>
        public System.Data.DataTable SELECT_EBM_FOB_MEOF_HEAD(string arg_factory, string arg_moid)
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MEOF_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();
                if (vDS != null)
                    return vDS.Tables[MyOraDB.Process_Name];

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MEOF_SIZE : 
        /// </summary>
        public System.Data.DataTable SELECT_EBM_FOB_MEOF_SIZE(string arg_factory, string arg_moid, string arg_mold_cd, string arg_pim_seq)
        {
            try
            {

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.SELECT_EBM_FOB_MEOF_SIZE";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_MOLD_CD";
                MyOraDB.Parameter_Name[3] = "ARG_PIM_SEQ";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = arg_mold_cd;
                MyOraDB.Parameter_Values[3] = arg_pim_seq;
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();
                if (vDS != null)
                    return vDS.Tables[MyOraDB.Process_Name];

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #endregion

    }
}

