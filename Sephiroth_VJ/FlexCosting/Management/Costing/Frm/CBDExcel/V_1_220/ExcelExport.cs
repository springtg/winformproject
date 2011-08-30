using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

using Excel;
using ODataTable = System.Data.DataTable;

namespace FlexCosting.Management.Costing.Frm.CBDExcel.V_1_220
{
    class ExcelExport
    {
        // Column
        private string spcMODEL = "D";
        private string spcMOID = "D";
        private string spcBOMID = "D";
        private string spcPROD_CODE = "D";
        private string spcPROD_FAC = "D";
        private string spcCATEGORY = "D";
        private string spcFOB_STATUS = "D";
        private string spcFOB_TYPE = "D";
        private string spcSEASON = "D";
        private string spcDATE_QUOTED = "D";
        private string spcGENDER = "D";
        private string spcSIZE = "D";
        private string spcSIZEUP_PCT = "D";
        private string spcREMARKS = "U";
        private string spcREMARKS_VALUE = "V";

        private string spcOV_COMMENT = "D";
        private string spcLB_COMMENT = "D";
        private string spcPROFIT_PCT = "C";
        private string spcTOOLING = "D";
        private string spcOTHER_ADJ = "F";
        private string spcLEAN_SAV_TGT = "F";
        private string spcSIZE_RUN = "D";
        private string spcTOTAL_SIZE_RUN = "D";

        private string spcFX_IDR = "R";
        private string spcFX_INR = "R";
        private string spcFX_KRW = "R";
        private string spcFX_RMB = "R";
        private string spcFX_THB = "R";
        private string spcFX_TWD = "R";
        private string spcFX_USD = "R";
        private string spcFX_VND = "R";

        // Row
        private string sprMODEL = "1";
        private string sprMOID = "3";
        private string sprBOMID = "5";
        private string sprPROD_CODE = "7";
        private string sprPROD_FAC = "9";
        private string sprCATEGORY = "11";
        private string sprFOB_STATUS = "13";
        private string sprFOB_TYPE = "15";
        private string sprSEASON = "17";
        private string sprDATE_QUOTED = "19";
        private string sprGENDER = "21";
        private string sprSIZE = "22";
        private string sprSIZEUP_PCT = "23";
        private string sprREMARKS = "4";

        private string sprOV_COMMENT = "69";
        private string sprLB_COMMENT = "69";
        private string sprPROFIT_PCT = "73";
        private string sprTOOLING = "77";
        private string sprOTHER_ADJ = "75";
        private string sprLEAN_SAV_TGT = "81";
        private string sprSIZE_RUN = "83";
        private string sprTOTAL_SIZE_RUN = "84";

        private string sprFX_IDR = "3";
        private string sprFX_INR = "4";
        private string sprFX_KRW = "5";
        private string sprFX_RMB = "6";
        private string sprFX_THB = "7";
        private string sprFX_TWD = "8";
        private string sprFX_USD = "9";
        private string sprFX_VND = "10";

        private int iprUPPER = 37;
        private int iprPACKAGING = 41;
        private int iprMIDSOLE = 45;
        private int iprOUTSOLE = 49;
        private int iprLABOR = 53;
        private int iprOVERHEAD = 64;
        private int iprSAMP_MOLD = 88;
        private int iprPROD_MOLD = 92;

        private Excel.Workbook vWB = null;
        //private Excel.Worksheet vWS = null;
        private Excel.Application vApp = null;

        private int iCurSheetNum = 2;

        public ArrayList vKeys;
        public string sFilePath = @"C:\";
        public string sFileName = "Test_CBD.xls";

        public void OpenFile()
        {
            try
            {
                sFileName = "CopyCBD" + System.DateTime.Now.Ticks.ToString() + ".xls";

                if (File.Exists("CBD_Template.xls"))
                {
                    File.Copy("CBD_Template.xls", sFilePath + sFileName, true);
                }
                else
                {
                    if (!File.Exists(@"C:\CBD_Template.xls"))
                    {
                        File.Copy(@"\\203.228.108.19\system_liveupdate\SEPHIROTH\CBD_Template.xls", @"C:\CBD_Template.xls");
                    }
                    File.Copy(@"C:\CBD_Template.xls", sFilePath + sFileName, true);
                }

                vApp = new Excel.Application();

                vWB = (Workbook)(vApp.Workbooks.Open(sFilePath + sFileName, Type.Missing, false,
                                                                 Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                                                 false, Type.Missing, Type.Missing, Type.Missing, true, false));

                vApp.Visible = false;
                vApp.DisplayAlerts = false;

                //vWS = (Excel.Worksheet)vWB.Sheets[iCurSheetNum];

                // Fill data 
                FillData();

                // Show excel 
                ShowExcelAndCloseFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CloseFile();
            }            
        }

        public bool FillData()
        {
            if (vKeys != null)
            {
                foreach (string[] sKeys in vKeys)
                {
                    //vWS.Copy(Type.Missing, vWB.Sheets[vWB.Sheets.Count]);
                    //vWB.Sheets.Copy(vWS, Type.Missing);
                    Excel.Worksheet vWS2 = (Excel.Worksheet)vWB.Sheets[iCurSheetNum++];
                    vWS2.Name = sKeys[2] + "-" + sKeys[3];
                    //vWS2.EnableAutoFilter = false;
                    //vWS2.EnableCalculation = false;
                    vWS2.Activate();
                    vWS2.Visible = XlSheetVisibility.xlSheetVisible;

                    iTOTAL_COUNT = 0;
                    iCURRENT_COUNT = 0;
                    iCURRENT_STATUS_IDX = 0;
                    sCURRENT_CBD = sKeys[2];
                    DisplayData(vWS2, sKeys[0], sKeys[1], sKeys[2], sKeys[3], sKeys[4], sKeys[5]);
                }
            }

            return true;
        }

        private bool DisplayData(Excel.Worksheet vWS2, string sDevFac, string sMOID, string sCBDID, string sCBDVer, string sFobType, string sSeason)
        {
            ClassLib.ComFunction_Cost costCom = new FlexCosting.ClassLib.ComFunction_Cost();

            // Select
            ODataTable vDTH = costCom.SELECT_SFX_CBD_HEAD("PKG_SFX_CBD_MASTER_REPORT.SELECT_SFX_CBD_HEAD", sDevFac, sMOID, sCBDID, sCBDVer, sFobType);
            ODataTable vDT = costCom.SELECT_SFX_CBD_FXRATE(sDevFac, sMOID, sCBDID, sCBDVer, sFobType, sSeason);

            string[] procs = new string[] {
                    "PKG_SFX_CBD_MASTER_REPORT.SELECT_SFX_CBD_TAIL",
                    "PKG_SFX_CBD_MASTER_REPORT.SELECT_SFX_CBD_TAIL_LB",
                    "PKG_SFX_CBD_MASTER_REPORT.SELECT_SFX_CBD_TAIL_OH",
                    "PKG_SFX_CBD_MASTER_REPORT.SELECT_SFX_CBD_TAIL_SM",
                    "PKG_SFX_CBD_MASTER_REPORT.SELECT_SFX_CBD_TAIL_PM", }; 
            
            DataSet vDST = costCom.SELECT_SFX_CBD_TAIL(procs, sDevFac, sMOID, sCBDID, sCBDVer, sFobType);

            iTOTAL_COUNT = vDTH.Rows.Count;
            iTOTAL_COUNT += vDT.Rows.Count;

            foreach (ODataTable vTDT in vDST.Tables)
            {
                iTOTAL_COUNT += vTDT.Rows.Count;
            }
            

            // Header 
            iCURRENT_STATUS_IDX = 1;
            DisplayHead(vWS2, vDTH);

            // F/X Rate
            iCURRENT_STATUS_IDX = 2;
            DisplayFxRate(vWS2, vDT);

            // Detail 
            ODataTable vDTTemp = vDST.Tables["PKG_SFX_CBD_MASTER_REPORT.SELECT_SFX_CBD_TAIL"];
            
            iCURRENT_STATUS_IDX = 3;
            DataRow[] vDRs = vDTTemp.Select("DIV='UPPER'");
            DisplayDetail(vWS2, vDRs, iprUPPER);

            iCURRENT_STATUS_IDX = 4;
            vDRs = vDTTemp.Select("DIV='PACKAGING'");
            DisplayDetail(vWS2, vDRs, iprPACKAGING);

            iCURRENT_STATUS_IDX = 5;
            vDRs = vDTTemp.Select("DIV='MIDSOLE'");
            DisplayDetail(vWS2, vDRs, iprMIDSOLE);

            iCURRENT_STATUS_IDX = 6;
            vDRs = vDTTemp.Select("DIV='OUTSOLE'");
            DisplayDetail(vWS2, vDRs, iprOUTSOLE);

            iCURRENT_STATUS_IDX = 7;
            DisplayDetailLabor(vWS2, vDST.Tables["PKG_SFX_CBD_MASTER_REPORT.SELECT_SFX_CBD_TAIL_LB"], iprLABOR);

            iCURRENT_STATUS_IDX = 8;
            DisplayDetailOverhead(vWS2, vDST.Tables["PKG_SFX_CBD_MASTER_REPORT.SELECT_SFX_CBD_TAIL_OH"], iprOVERHEAD);

            iCURRENT_STATUS_IDX = 9;
            DisplayDetailMold(vWS2, vDST.Tables["PKG_SFX_CBD_MASTER_REPORT.SELECT_SFX_CBD_TAIL_SM"], iprSAMP_MOLD);

            iCURRENT_STATUS_IDX = 10;
            DisplayDetailMold(vWS2, vDST.Tables["PKG_SFX_CBD_MASTER_REPORT.SELECT_SFX_CBD_TAIL_PM"], iprPROD_MOLD);

            vWS2.Application.GetType().InvokeMember("Run", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod,
                null, vWS2.Application, new object[] { "Main_Validation" });

            iprUPPER = 37;
            iprPACKAGING = 41;
            iprMIDSOLE = 45;
            iprOUTSOLE = 49;
            iprLABOR = 53;
            iprOVERHEAD = 64;
            iprSAMP_MOLD = 88;
            iprPROD_MOLD = 92;

            return true;
        }

        private void DisplayHead(Excel.Worksheet vWS2, ODataTable vDTH)
        {
            vWS2.Cells[sprMODEL, spcMODEL] = vDTH.Rows[0]["MODEL_NAME"];
            vWS2.Cells[sprMOID, spcMOID] = vDTH.Rows[0]["MOID"];
            vWS2.Cells[sprBOMID, spcBOMID] = vDTH.Rows[0]["BOM_ID"];
            vWS2.Cells[sprPROD_CODE, spcPROD_CODE] = vDTH.Rows[0]["PRODUCT_CD"];
            vWS2.Cells[sprPROD_FAC, spcPROD_FAC] = vDTH.Rows[0]["PROD_FAC"];
            vWS2.Cells[sprCATEGORY, spcCATEGORY] = vDTH.Rows[0]["CAT_CD"];
            vWS2.Cells[sprFOB_STATUS, spcFOB_STATUS] = vDTH.Rows[0]["FOB_STATUS"];
            vWS2.Cells[sprFOB_TYPE, spcFOB_TYPE] = vDTH.Rows[0]["ROUND_CD"];
            vWS2.Cells[sprSEASON, spcSEASON] = vDTH.Rows[0]["SEASON_CD"];
            vWS2.Cells[sprDATE_QUOTED, spcDATE_QUOTED] = vDTH.Rows[0]["DATE_QUOTED"];
            vWS2.Cells[sprGENDER, spcGENDER] = vDTH.Rows[0]["GENDER"];
            vWS2.Cells[sprSIZE, spcSIZE] = vDTH.Rows[0]["SIZE_REP"];
            vWS2.Cells[sprSIZEUP_PCT, spcSIZEUP_PCT] = vDTH.Rows[0]["SIZEUP_PCT"];
            vWS2.Cells[sprOV_COMMENT, spcOV_COMMENT] = vDTH.Rows[0]["OVERHEAD_CMT"];
            vWS2.Cells[sprLB_COMMENT, spcLB_COMMENT] = vDTH.Rows[0]["LABOR_CMT"];
            
            object oProfitPCT = vDTH.Rows[0]["PROFIT_PCT"];
            double dProfitPCT = 0;
            double.TryParse(oProfitPCT == null ? "0" : oProfitPCT.ToString(), out dProfitPCT);
            vWS2.Cells[sprPROFIT_PCT, spcPROFIT_PCT] = dProfitPCT / 100;
            
            //vWS2.Cells[sprTOOLING, spcTOOLING] = vDTH.Rows[0]["MODEL_NAME"];
            vWS2.Cells[sprOTHER_ADJ, spcOTHER_ADJ] = vDTH.Rows[0]["OTHER_ADJUST"];
            vWS2.Cells[sprLEAN_SAV_TGT, spcLEAN_SAV_TGT] = vDTH.Rows[0]["LEAN_SAVE_TGT"];
            vWS2.Cells[sprSIZE_RUN, spcSIZE_RUN] = vDTH.Rows[0]["SIZERUN"];
            vWS2.Cells[sprTOTAL_SIZE_RUN, spcTOTAL_SIZE_RUN] = vDTH.Rows[0]["TOT_SIZERUN"];
            vWS2.Cells[sprREMARKS, spcREMARKS] = "Forecast";
            vWS2.Cells[sprREMARKS, spcREMARKS_VALUE] = vDTH.Rows[0]["FORECAST"];
            vWS2.Cells[Convert.ToString((Convert.ToInt32(sprREMARKS) + 1)), spcREMARKS] = "Retail";
            vWS2.Cells[Convert.ToString((Convert.ToInt32(sprREMARKS) + 1)), spcREMARKS_VALUE] = vDTH.Rows[0]["RETAIL_PRICE"];
            vWS2.Cells[Convert.ToString((Convert.ToInt32(sprREMARKS) + 2)), spcREMARKS] = "Target";
            vWS2.Cells[Convert.ToString((Convert.ToInt32(sprREMARKS) + 2)), spcREMARKS_VALUE] = vDTH.Rows[0]["TARGET_FOB"];
            vWS2.Cells[Convert.ToString((Convert.ToInt32(sprREMARKS) + 3)), spcREMARKS] = vDTH.Rows[0]["REMARKS"];

            iCURRENT_COUNT++;
        }

        private void DisplayFxRate(Excel.Worksheet vWS2, ODataTable vDTF)
        {
            DataRow[] vDR = vDTF.Select("CURR='IDR'");
            vWS2.Cells[sprFX_IDR, spcFX_IDR] = vDR.Length == 0 ? "" : vDR[0]["FX_RATE"];
            iCURRENT_COUNT++;

            vDR = vDTF.Select("CURR='INR'");
            vWS2.Cells[sprFX_INR, spcFX_INR] = vDR.Length == 0 ? "" : vDR[0]["FX_RATE"];
            iCURRENT_COUNT++;
            
            vDR = vDTF.Select("CURR='KRW'");
            vWS2.Cells[sprFX_KRW, spcFX_KRW] = vDR.Length == 0 ? "" : vDR[0]["FX_RATE"];
            iCURRENT_COUNT++;
            
            vDR = vDTF.Select("CURR='RMB'");            
            vWS2.Cells[sprFX_RMB, spcFX_RMB] = vDR.Length == 0 ? "" : vDR[0]["FX_RATE"];
            iCURRENT_COUNT++;
            
            vDR = vDTF.Select("CURR='THB'");
            vWS2.Cells[sprFX_THB, spcFX_THB] = vDR.Length == 0 ? "" : vDR[0]["FX_RATE"];
            iCURRENT_COUNT++;
            
            vDR = vDTF.Select("CURR='TWD'");
            vWS2.Cells[sprFX_TWD, spcFX_TWD] = vDR.Length == 0 ? "" : vDR[0]["FX_RATE"];
            iCURRENT_COUNT++;
            
            vDR = vDTF.Select("CURR='USD'");
            vWS2.Cells[sprFX_USD, spcFX_USD] = vDR.Length == 0 ? "" : vDR[0]["FX_RATE"];
            iCURRENT_COUNT++;
            
            vDR = vDTF.Select("CURR='VND'");
            vWS2.Cells[sprFX_VND, spcFX_VND] = vDR.Length == 0 ? "" : vDR[0]["FX_RATE"];
            iCURRENT_COUNT++;
        }

        // Upper, Packaging, Midsole, Outsole 
        private void DisplayDetail(Excel.Worksheet vWS2, DataRow[] vDRs, int ipTailStartRow)
        {
            for (int iIdx = 0, iRow = ipTailStartRow; iIdx < vDRs.Length; iIdx++, iRow++)
            {
                Range vRng = vWS2.get_Range(vWS2.Cells[iRow + 1, "A"], vWS2.Cells[iRow + 1, "A"]);
                vRng.EntireRow.Insert(XlInsertShiftDirection.xlShiftDown, Type.Missing);
                //DataRow sData = vDRs[iIdx];
                // List
                //vWS2.Cells[iRow, "L"] = StringCheckAndNullReturn(sData["CURR"]);
                //string sCBDClass = StringCheckAndNullReturn(sData["CBD_CLASS"]);
                //vWS2.Cells[iRow, "B"] = sCBDClass == null ? "UP" : sCBDClass;
                //vWS2.Cells[iRow, "C"] = StringCheckAndNullReturn(sData["SUB_CLASS"]);
                //vWS2.Cells[iRow, "O"] = StringCheckAndNullReturn(sData["FRT_TRM"]);

                //// Text
                //vWS2.Cells[iRow, "A"] = StringCheckAndNullReturn(sData["SIZE_EXC"]);
                //vWS2.Cells[iRow, "D"] = sData["BOM_NO"];
                //vWS2.Cells[iRow, "E"] = sData["CBD_NO"];
                //vWS2.Cells[iRow, "F"] = sData["PART_NAME"];
                //vWS2.Cells[iRow, "G"] = sData["MAT_NAME"].ToString() + sData["MAT_COMMENT"].ToString();
                //vWS2.Cells[iRow, "H"] = sData["VEN_NAME"];
                //vWS2.Cells[iRow, "I"] = sData["COLOR_NAME"];
                //vWS2.Cells[iRow, "J"] = sData["MAT_CD"];
                //vWS2.Cells[iRow, "K"] = sData["UOM"];
                
                //// Number                
                //vWS2.Cells[iRow, "N"] = sData["MAT_UPRICE"];
                ////vWS2.Cells[iRow, "P"] = "0.0" + sData["FCT_LND_PCT"];
                //vWS2.Cells[iRow, "P"] = sData["FCT_LND_PCT"];
                //vWS2.Cells[iRow, "S"] = sData["YIELD"];
                ////vWS2.Cells[iRow, "T"] = "0.0" + sData["LOSS_PCT"];
                //vWS2.Cells[iRow, "T"] = sData["LOSS_PCT"];

                //iCURRENT_COUNT++;
                //iprUPPER++;
                //iprPACKAGING++;
                //iprMIDSOLE++;
                //iprOUTSOLE++;
                //iprLABOR++;
                //iprOVERHEAD++;
                //iprSAMP_MOLD++;
                //iprPROD_MOLD++;
            }

            for (int iIdx = 0, iRow = ipTailStartRow; iIdx < vDRs.Length; iIdx++, iRow++)
            {
                DataRow sData = vDRs[iIdx];

                // List
                vWS2.Cells[iRow, "L"] = StringCheckAndNullReturn(sData["CURR"]);
                string sCBDClass = StringCheckAndNullReturn(sData["CBD_CLASS"]);
                vWS2.Cells[iRow, "B"] = sCBDClass == null ? "UP" : sCBDClass;
                vWS2.Cells[iRow, "C"] = StringCheckAndNullReturn(sData["SUB_CLASS"]);
                vWS2.Cells[iRow, "O"] = StringCheckAndNullReturn(sData["FRT_TRM"]);

                // Text
                vWS2.Cells[iRow, "A"] = StringCheckAndNullReturn(sData["SIZE_EXC"]);
                vWS2.Cells[iRow, "D"] = sData["BOM_NO"];
                vWS2.Cells[iRow, "E"] = sData["CBD_NO"];
                vWS2.Cells[iRow, "F"] = sData["PART_NAME"];
                vWS2.Cells[iRow, "G"] = sData["MAT_NAME"].ToString() + sData["MAT_COMMENT"].ToString();
                vWS2.Cells[iRow, "H"] = sData["VEN_NAME"];
                vWS2.Cells[iRow, "I"] = sData["COLOR_NAME"];
                vWS2.Cells[iRow, "J"] = sData["MAT_CD"];
                vWS2.Cells[iRow, "K"] = sData["UOM"];

                // Number                
                vWS2.Cells[iRow, "N"] = sData["MAT_UPRICE"];
                //vWS2.Cells[iRow, "P"] = "0.0" + sData["FCT_LND_PCT"];
                vWS2.Cells[iRow, "P"] = sData["FCT_LND_PCT"];
                vWS2.Cells[iRow, "S"] = sData["YIELD"];
                //vWS2.Cells[iRow, "T"] = "0.0" + sData["LOSS_PCT"];
                vWS2.Cells[iRow, "T"] = sData["LOSS_PCT"];

                iCURRENT_COUNT++;
                iprUPPER++;
                iprPACKAGING++;
                iprMIDSOLE++;
                iprOUTSOLE++;
                iprLABOR++;
                iprOVERHEAD++;
                iprSAMP_MOLD++;
                iprPROD_MOLD++;
            }
        }

        // Labor
        private void DisplayDetailLabor(Excel.Worksheet vWS2, ODataTable vDT, int ipTailStartRow)
        {
            for (int iIdx = 0, iRow = ipTailStartRow; iIdx < vDT.Rows.Count; iIdx++, iRow++)
            {
                DataRow sData = vDT.Rows[iIdx];
                // List
                vWS2.Cells[iRow, "D"] = StringCheckAndNullReturn(sData["CURR"]);
                vWS2.Cells[iRow, "C"] = StringCheckAndNullReturn(sData["SUB_CLASS"]);

                // Text
                vWS2.Cells[iRow, "F"] = sData["PROCESS"];
                vWS2.Cells[iRow, "G"] = sData["WAGE_YR"];

                // Number
                vWS2.Cells[iRow, "H"] = sData["DIRT_WORKER"];
                vWS2.Cells[iRow, "I"] = sData["DAY_PAID_YR"];
                vWS2.Cells[iRow, "J"] = sData["MIN_DAY_WORKER"];
                vWS2.Cells[iRow, "K"] = sData["EFFCTV_RATE"];
                vWS2.Cells[iRow, "M"] = sData["STD_MIN"];
                vWS2.Cells[iRow, "P"] = sData["OV_COST"];

                iCURRENT_COUNT++;
            }
        }

        // Overhead
        private void DisplayDetailOverhead(Excel.Worksheet vWS2, ODataTable vDT, int ipTailStartRow)
        {
            for (int iIdx = 0, iRow = ipTailStartRow; iIdx < vDT.Rows.Count; iIdx++, iRow++)
            {
                DataRow sData = vDT.Rows[iIdx];
                // List
                vWS2.Cells[iRow, "D"] = StringCheckAndNullReturn(sData["CURR"]);
                vWS2.Cells[iRow, "C"] = StringCheckAndNullReturn(sData["SUB_CLASS"]);

                // Text
                vWS2.Cells[iRow, "F"] = sData["ITEM"];

                // Number
                vWS2.Cells[iRow, "G"] = sData["COST_LOCAL"];

                iCURRENT_COUNT++;
            }
        }

        // Tooling
        private void DisplayDetailMold(Excel.Worksheet vWS2, ODataTable vDT, int ipTailStartRow)
        {
            for (int iIdx = 0, iRow = ipTailStartRow; iIdx < vDT.Rows.Count; iIdx++, iRow++)
            {
                Range vRng = vWS2.get_Range(vWS2.Cells[iRow + 1, "A"], vWS2.Cells[iRow + 1, "A"]);
                vRng.EntireRow.Insert(XlInsertShiftDirection.xlShiftDown, Type.Missing);

                DataRow sData = vDT.Rows[iIdx];
                // List
                vWS2.Cells[iRow, "H"] = StringCheckAndNullReturn(sData["CURR"]);
                vWS2.Cells[iRow, "B"] = StringCheckAndNullReturn(sData["CBD_CLASS"]);

                // Text
                vWS2.Cells[iRow, "C"] = sData["COMPONENT"];
                vWS2.Cells[iRow, "D"] = sData["MOLD_TYPE"];
                vWS2.Cells[iRow, "E"] = sData["MOLD_CD"];
                vWS2.Cells[iRow, "F"] = sData["MOLD_DESC"];
                vWS2.Cells[iRow, "O"] = sData["NOTE"];

                // Number
                vWS2.Cells[iRow, "G"] = sData["MOLDA_CNT"];
                vWS2.Cells[iRow, "J"] = sData["COST_MOLDA"];
                vWS2.Cells[iRow, "M"] = sData["AMORT_PAIRS"];

                iprPROD_MOLD++;
                iCURRENT_COUNT++;
            }
        }

        public bool ShowExcelAndCloseFile()
        {
            try
            {
                vApp.Visible = true;
                vApp.WindowState = XlWindowState.xlNormal;

                vWB = null;
                //vWS = null;
                vApp = null;
                return true;
            }
            catch (Exception ex)
            {
                vWB = null;
                //vWS = null;
                vApp = null;

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                GC.Collect();
            }
        }

        public bool CloseFile()
        {
            try
            {
                vWB = null;
                //vWS = null;
                vApp = null;
                return true;
            }
            catch (Exception ex)
            {
                vWB = null;
                //vWS = null;
                vApp = null;

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                GC.Collect();
            }
        }

        private string StringCheckAndNullReturn(object arg_obj)
        {
            if (arg_obj == null)
            {
                return null;
            }
            else
            {
                if (arg_obj.ToString().Trim().Replace("-", "").Equals(""))
                {
                    return null;
                }
                else
                {
                    return arg_obj.ToString();
                }
            }
        }


        #region Properties

        private int iTOTAL_COUNT = 0;
        private int iCURRENT_COUNT = 0;
        private int iCURRENT_STATUS_IDX = 0;
        private string sCURRENT_CBD = "";
        private string[] sSTATUS_CODE = new string[] { "Ready", "Write summary", "Write F/X Rate", "Write upper", "Write upper", "Write packaging", "Write midsole", "Write outsole", "Write labor", "Write overhead", "Write sample mold", "Write product mold" };

        public string CURRENT_STATUS
        {
            get 
            {
                return sCURRENT_CBD + " [" + sSTATUS_CODE[iCURRENT_STATUS_IDX] + "]";
            }
        }

        public int CURRENT_COUNT 
        {
            get 
            {
                return iCURRENT_COUNT;
            }
        }

        public int TOTAL_COUNT 
        {
            get 
            {
                return iTOTAL_COUNT;
            }
        }

        #endregion
    }
}
