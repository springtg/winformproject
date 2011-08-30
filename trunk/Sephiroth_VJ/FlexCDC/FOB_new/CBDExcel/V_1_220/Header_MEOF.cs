using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;

namespace FlexCDC.FOB.CBDExcel.V_1_220
{
    class Header_MEOF
    {
        private COM.OraDB MyOraDB = new COM.OraDB();

        private Microsoft.Office.Interop.Excel.Workbook workbook = null;
        private System.Data.DataSet vDS_Head = new System.Data.DataSet("Header");
        private System.Data.DataSet vDS_Tail = new System.Data.DataSet("Detail");

        private string version = "";

        #region 0. 버전 체크하기

        // 1. 버전 체크
        public bool CheckFormat()
        {
            try
            {

                #region Version Check

                version = "1.0";

                #endregion

                for (int iIdx = 1; iIdx <= workbook.Sheets.Count; iIdx++)
                {
                    Worksheet worksheet = (Worksheet)workbook.Sheets[iIdx];
                    string sheet_name = worksheet.Name;

                    if (version.Equals("1.0"))
                    {

                        #region Head Data Check

                        /*  
                            factory, moid, season 

                            Type of Part
                            Mold Code
                            Last Code
                            Dev. Mold Shop
                            Prod. Mold Shop
                            Mold Material
                            Mold MFG Technology
                            Molded Material
                            Mold Cost - Sample
                            "A" Mold Cost
                            "B" Mold Cost
                            Mold Round
                            Comp. Shared With
                            Shifts Per Day
                            Hours Per Shift / Day
                            Working Days
                            Efficiency %
                            Pairs Per Day
                            Peak Pairage
                            Amortization Pairage
                        */


                        if (worksheet.Name.Equals("Mold Efficiency Form"))
                        {
                            // Title 
                            if (!SubjectCheck(worksheet, "Factory", 6, 29))
                                return false;
                            if (!SubjectCheck(worksheet, "MO ID", 6, 13))
                                return false;
                            if (!SubjectCheck(worksheet, "Season", 5, 1))
                                return false;

                            string sFactory = (worksheet.get_Range(worksheet.Cells[6, 37], worksheet.Cells[6, 37]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[6, 37], worksheet.Cells[6, 37]).Value2.ToString().Trim();
                            string sMOID = (worksheet.get_Range(worksheet.Cells[6, 21], worksheet.Cells[6, 21]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[6, 21], worksheet.Cells[6, 21]).Value2.ToString().Trim();

                            System.Data.DataTable vDT = SELECT_EBM_FOB_DETAIL_CNT(sFactory, sMOID.Replace(" ", "").Replace("-", ""));

                            if (vDT != null && vDT.Rows.Count > 0)
                            {

                            }
                            else
                            {
                                MessageBox.Show(sMOID + " Not found");
                                return false;
                            }

                            if (!SubjectCheck(worksheet, "Type of Part", 8, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Mold Code", 9, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Last Code", 10, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Dev. Mold Shop", 11, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Prod. Mold Shop", 12, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Mold Material", 13, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Mold MFG Technology", 14, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Molded Material", 15, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Mold Cost - Sample", 16, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "\"A\" Mold Cost", 17, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "\"B\" Mold Cost", 18, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Mold Round", 19, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Comp. Shared With", 20, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Shifts Per Day", 21, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Hours Per Shift / Day", 22, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Working Days", 23, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Efficiency %", 24, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Pairs Per Day", 25, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Peak Pairage", 26, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Amortization Pairage", 27, 1))
                                return false;

                            if (!SubjectCheck(worksheet, "\"A\" Molds Required", 81, 1))
                                return false;
                            if (!SubjectCheck(worksheet, "Est.  Extra Molds", 83, 1))
                                return false;

                            // start : 81, 13
                            // next : 11
                            int iMoldCnt = 0;
                            for (int iMQtyCol = 13; iMQtyCol < 1024; iMQtyCol += 13)
                            {
                                if (ValueCheck(worksheet, 81, iMQtyCol))
                                    iMoldCnt++;
                                else
                                    break;
                            }
                        }

                        #endregion
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool SubjectCheck(Worksheet worksheet, string sSubject, int iRow, int iCol)
        {
            string sItem = (worksheet.get_Range(worksheet.Cells[iRow, iCol], worksheet.Cells[iRow, iCol]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[iRow, iCol], worksheet.Cells[iRow, iCol]).Value2.ToString().Trim();
            if (sItem.IndexOf(sSubject) < 0)
            {
                MessageBox.Show("Sheet Name : " + worksheet.Name + "\r\n\r\n" + sSubject + " is worng.");
                return false;
            }

            return true;
        }

        private bool ValueCheck(Worksheet worksheet, int iRow, int iCol)
        {
            object sItem = worksheet.get_Range(worksheet.Cells[iRow, iCol], worksheet.Cells[iRow, iCol]).Value2;
            if (sItem == null)
            {
                return false;
            }

            return true;
        }

        #endregion


        #region 1, 데이터 테이블 만들기

        private System.Data.DataTable CreateNewHeadDateTable(string arg_DTName)
        {
            try
            {
                System.Data.DataTable vDT = new System.Data.DataTable(arg_DTName);

                vDT.Columns.Add(new DataColumn("CHK"));
                vDT.Columns.Add(new DataColumn("FACTORY"));
                vDT.Columns.Add(new DataColumn("STYLE_CD"));
                vDT.Columns.Add(new DataColumn("REGION"));
                vDT.Columns.Add(new DataColumn("BOM_ID"));
                vDT.Columns.Add(new DataColumn("PROD_CODE"));
                vDT.Columns.Add(new DataColumn("DEV_CODE"));
                vDT.Columns.Add(new DataColumn("PROD_NAME"));
                vDT.Columns.Add(new DataColumn("PROD_TYPE"));
                vDT.Columns.Add(new DataColumn("SEASON_CD"));
                vDT.Columns.Add(new DataColumn("APP_YMD"));
                vDT.Columns.Add(new DataColumn("LEATHER_PCT"));
                vDT.Columns.Add(new DataColumn("SYNTHETIC_PCT"));
                vDT.Columns.Add(new DataColumn("TEXTILE_PCT"));
                vDT.Columns.Add(new DataColumn("OTHER_PCT"));
                vDT.Columns.Add(new DataColumn("REMARKS"));
                vDT.Columns.Add(new DataColumn("STATUS"));
                vDT.Columns.Add(new DataColumn("UPD_USER"));
                vDT.Columns.Add(new DataColumn("UPD_YMD"));
                vDT.Columns.Add(new DataColumn("UPDATE_FACTORY"));
                vDT.Columns.Add(new DataColumn("DETAIL_YN"));

                return vDT;
            }
            catch
            {
                return null;
            }
        }

        private System.Data.DataTable CreateNewTailDateTable(string arg_DTName)
        {
            try
            {
                System.Data.DataTable vDT = new System.Data.DataTable(arg_DTName);

                vDT.Columns.Add(new DataColumn("FACTORY"));
                vDT.Columns.Add(new DataColumn("STYLE_CD"));
                vDT.Columns.Add(new DataColumn("REGION"));
                vDT.Columns.Add(new DataColumn("SEQ"));
                vDT.Columns.Add(new DataColumn("COMP_DIV"));
                vDT.Columns.Add(new DataColumn("COMP_NAME"));
                vDT.Columns.Add(new DataColumn("MEASUAL_DATA"));
                vDT.Columns.Add(new DataColumn("BOM_COMP_READ"));
                vDT.Columns.Add(new DataColumn("REMARKS"));
                vDT.Columns.Add(new DataColumn("STATUS"));
                vDT.Columns.Add(new DataColumn("UPD_USER"));
                vDT.Columns.Add(new DataColumn("UPD_YMD"));
                vDT.Columns.Add(new DataColumn("UPDATE_FACTORY"));

                return vDT;
            }
            catch
            {
                return null;
            }
        }

        #endregion


        #region 2. 데이터 체워 넣기

        private int _HeaderCount = 0;
        private string _Factory = null, _MOID = null, _Season = null;

        public bool FillHeadData(COM.FSP fgrid_head)
        {
            try
            {
                int iSeq = 1;

                for (int iIdx = 1; iIdx <= workbook.Sheets.Count; iIdx++)
                {
                    Worksheet workSheet = (Worksheet)workbook.Sheets[iIdx];
                    int iFixedRow = fgrid_head.Rows.Fixed - 1;

                    if (workSheet.Name.Equals("Mold Efficiency Form"))
                    {
                        // Primary key ( factory, moid, + season )
                        string scRow = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxFACTORY + iFixedRow, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_ROW].ToString();
                        string scCol = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxFACTORY + iFixedRow, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_COL].ToString();
                        _Factory = GetExcelData(workSheet, scRow, scCol);

                        scRow = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOID + iFixedRow, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_ROW].ToString();
                        scCol = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOID + iFixedRow, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_COL].ToString();
                        _MOID = GetExcelData(workSheet, scRow, scCol).Replace("-", "");

                        scRow = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxSEASON_CD + iFixedRow, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_ROW].ToString();
                        scCol = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxSEASON_CD + iFixedRow, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_COL].ToString();
                        _Season = GetExcelData(workSheet, scRow, scCol);

                        // Header data table
                        for (int iCol = (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxMOLD_1; iCol < (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxMaxCt; iCol++)
                        {
                            if (!fgrid_head[fgrid_head.Rows.Fixed - 4, iCol].ToString().Trim().Equals(""))
                            {
                                for (int iRow = (int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxPART_TYPE + iFixedRow; iRow < (int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_A_QTY + iFixedRow; iRow++)
                                {
                                    string sSubject = fgrid_head[iRow, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxSUBJECT].ToString();

                                    scRow = fgrid_head[iRow, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_ROW].ToString();
                                    scCol = fgrid_head[fgrid_head.Rows.Fixed - 4, iCol].ToString();
                                    int icRow = int.Parse(scRow);
                                    int icCol = int.Parse(scCol);

                                    string sValue = (workSheet.get_Range(workSheet.Cells[icRow, icCol], workSheet.Cells[icRow, icCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[icRow, icCol], workSheet.Cells[icRow, icCol]).Value2.ToString().Trim();

                                    if (sSubject.Equals("Type of Part"))
                                    {
                                        if (sValue.Trim().Equals(""))
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            // Primary key ( seq )
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxFACTORY + iFixedRow, iCol] = _Factory;
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOID + iFixedRow, iCol] = _MOID;
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxPIM_SEQ + iFixedRow, iCol] = iSeq++;
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxSEASON_CD + iFixedRow, iCol] = _Season;
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxSTATUS + iFixedRow, iCol] = "N";
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxUPD_USER + iFixedRow, iCol] = COM.ComVar.This_User;
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxUPD_YMD + iFixedRow, iCol] = System.DateTime.Now;
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxUPDATE_FACTORY + iFixedRow, iCol] = COM.ComVar.This_Factory;

                                            // Mold Qty (A, B)
                                            string scTRow = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_A_QTY + iFixedRow, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_ROW].ToString();
                                            string scTCol = fgrid_head[fgrid_head.Rows.Fixed - 3, iCol].ToString();
                                            int icTRow = int.Parse(scTRow);
                                            int icTCol = int.Parse(scTCol);
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_A_QTY + iFixedRow, iCol] = workSheet.get_Range(workSheet.Cells[icTRow, icTCol], workSheet.Cells[icTRow, icTCol]).Value2;

                                            scTRow = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_B_QTY + iFixedRow, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_ROW].ToString();
                                            scTCol = fgrid_head[fgrid_head.Rows.Fixed - 3, iCol].ToString();
                                            icTRow = int.Parse(scTRow);
                                            icTCol = int.Parse(scTCol);
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_B_QTY + iFixedRow, iCol] = workSheet.get_Range(workSheet.Cells[icTRow, icTCol], workSheet.Cells[icTRow, icTCol]).Value2;

                                            // MDF
                                            scTRow = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMDF + iFixedRow, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_ROW].ToString();
                                            scTCol = fgrid_head[fgrid_head.Rows.Fixed - 2, iCol].ToString();
                                            icTRow = int.Parse(scTRow);
                                            icTCol = int.Parse(scTCol);
                                            string sMDF = (workSheet.get_Range(workSheet.Cells[icTRow, icTCol], workSheet.Cells[icTRow, icTCol]).Value2 == null ? "0" : workSheet.get_Range(workSheet.Cells[icTRow, icTCol], workSheet.Cells[icTRow, icTCol]).Value2.ToString());
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMDF + iFixedRow, iCol] = sMDF.Equals(".05") ? "0" + sMDF : sMDF;

                                            // Size Run
                                            scTRow = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxSIZE_RUN + iFixedRow, (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxCELL_ROW].ToString();
                                            scTCol = fgrid_head[fgrid_head.Rows.Fixed - 1, iCol].ToString();
                                            icTRow = int.Parse(scTRow);
                                            icTCol = int.Parse(scTCol);
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxSIZE_RUN + iFixedRow, iCol] = workSheet.get_Range(workSheet.Cells[icTRow, icTCol], workSheet.Cells[icTRow, icTCol]).Value2;

                                            _HeaderCount++;
                                        }
                                    }

                                    fgrid_head[iRow, iCol] = sValue;
                                }
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private string GetExcelData(Worksheet workSheet, string sRow, string sCol)
        {
            int icRow = 0;
            int icCol = 0;

            if (int.TryParse(sRow, out icRow) && int.TryParse(sCol, out icCol))
            {
                string sValue = (workSheet.get_Range(workSheet.Cells[icRow, icCol], workSheet.Cells[icRow, icCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[icRow, icCol], workSheet.Cells[icRow, icCol]).Value2.ToString().Trim();
                return sValue;
            }
            else
            {
                return null;
            }
        }

        public bool FillTailData(COM.FSP fgrid_head, COM.FSP fgrid_size)
        {
            try
            {
                int iFixedRow = fgrid_size.Rows.Fixed - 1;
                int iSubjectRow = 42, iStartRow = 43, iEndRow = iStartRow + 1000;
                int iHeadStartCol = ((int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxMOLD_1) - 1;

                for (int iIdx = 1; iIdx <= workbook.Sheets.Count; iIdx++)
                {
                    Worksheet workSheet = (Worksheet)workbook.Sheets[iIdx];

                    if (workSheet.Name.Equals("Mold Efficiency Form"))
                    {
                        for (int iCol = 1; iCol < fgrid_size.Cols.Count; iCol++)
                        {
                            if (!fgrid_size[iFixedRow, iCol].ToString().Trim().Equals(""))
                            {
                                // Detail 정보 
                                string scCol = fgrid_size[iFixedRow, iCol].ToString();
                                int icCol = int.Parse(scCol);

                                string sSubject = (workSheet.get_Range(workSheet.Cells[iSubjectRow, icCol], workSheet.Cells[iSubjectRow, icCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[iSubjectRow, icCol], workSheet.Cells[iSubjectRow, icCol]).Value2.ToString().Trim();

                                // Size column
                                if (sSubject.Equals("Size"))
                                {
                                    // Header 정보 ( Mold code ) 가져오기
                                    object oMoldCode = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_CD + fgrid_head.Rows.Fixed - 1, iHeadStartCol + 1];
                                    if (oMoldCode == null)
                                        return true;
                                    
                                    string sMoldCode = oMoldCode.ToString();
                                    iHeadStartCol++;
                                    iEndRow = iStartRow + 1000;

                                    for (int icRow = iStartRow, iRow = fgrid_size.Rows.Fixed, iTIdx = 1; icRow < iEndRow; icRow++, iRow++, iTIdx++)
                                    {
                                        string sValue = (workSheet.get_Range(workSheet.Cells[icRow, icCol], workSheet.Cells[icRow, icCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[icRow, icCol], workSheet.Cells[icRow, icCol]).Value2.ToString().Trim();
                                        if (sValue.Equals("0"))
                                        {
                                            // 첫줄이 빈경우 종료
                                            if (iRow == fgrid_size.Rows.Fixed)
                                            {
                                                return true;
                                            }
                                            else
                                            {
                                                iEndRow = iRow;
                                                break;
                                            }
                                        }

                                        if (iRow >= fgrid_size.Rows.Count)
                                            fgrid_size.Rows.Add();

                                        fgrid_size[iRow, iCol - 3] = sMoldCode;
                                        fgrid_size[iRow, iCol - 1] = iTIdx;
                                        fgrid_size[iRow, iCol] = sValue;
                                    }
                                }
                                // PIM column
                                else if (sSubject.Equals("PIM"))
                                {
                                    string sTPIM = "";
                                    int sPIMSeq = 0;

                                    for (int icRow = iStartRow, iRow = fgrid_size.Rows.Fixed; iRow < iEndRow; icRow++, iRow++)
                                    {
                                        object oValue = workSheet.get_Range(workSheet.Cells[icRow, icCol], workSheet.Cells[icRow, icCol]).Value2;
                                        if (!sTPIM.Equals(oValue.ToString()))
                                        {
                                            sPIMSeq++;
                                            fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxPIM_COUNT + (fgrid_head.Rows.Fixed - 1), iHeadStartCol] = sPIMSeq;
                                            sTPIM = oValue.ToString();
                                        }
                                        fgrid_size[iRow, iCol - 6] = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxPIM_SEQ + (fgrid_head.Rows.Fixed - 1), iHeadStartCol];
                                        fgrid_size[iRow, iCol] = oValue;
                                        fgrid_size[iRow, iCol + 3] = "N";
                                        fgrid_size[iRow, iCol + 4] = COM.ComVar.This_User;
                                        fgrid_size[iRow, iCol + 5] = System.DateTime.Now;
                                        fgrid_size[iRow, iCol + 6] = COM.ComVar.This_Factory;
                                    }
                                }
                                // Etc column
                                else
                                {
                                    for (int icRow = iStartRow, iRow = fgrid_size.Rows.Fixed; iRow < iEndRow; icRow++, iRow++)
                                    {
                                        object oValue = workSheet.get_Range(workSheet.Cells[icRow, icCol], workSheet.Cells[icRow, icCol]).Value2;
                                        fgrid_size[iRow, iCol] = oValue;
                                    }
                                }
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion


        #region 데이터베이스

        private string Get_Season_code(string arg_season_cd)
        {
            if (arg_season_cd.Equals(""))
                return "";

            string season_year = "20" + arg_season_cd.Substring(2, 2);
            string season_code = arg_season_cd.Substring(0, 2);

            if (season_code.Equals("SP"))
                season_code = "01";
            else if (season_code.Equals("SU"))
                season_code = "02";
            else if (season_code.Equals("FA"))
                season_code = "03";
            else if (season_code.Equals("HO"))
                season_code = "04";

            return season_year + season_code;
        }


        /// <summary>
        /// PKG_EBM_FOB_MEOF.SELECT_EBM_FOB_DETAIL_CNT : 
        /// </summary>
        public System.Data.DataTable SELECT_EBM_FOB_DETAIL_CNT(string arg_factory, string arg_moid)
        {
            try
            {

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_MEOF.SELECT_EBM_FOB_DETAIL_CNT";

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

        #endregion


        #region Properties

        public Microsoft.Office.Interop.Excel.Workbook Workbook
        {
            get { return workbook; }
            set { workbook = value; }
        }

        public int HeaderCount
        {
            get { return _HeaderCount; }
            set { _HeaderCount = value; }
        }
        public string Season
        {
            get { return _Season; }
            set { _Season = value; }
        }

        public string MOID
        {
            get { return _MOID; }
            set { _MOID = value; }
        }

        public string Factory
        {
            get { return _Factory; }
            set { _Factory = value; }
        }

        #endregion
    }
}
