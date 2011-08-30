using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using System.Windows.Forms;

using Excel;

namespace FlexCDC.FOB.CBDExcel.V_1_220
{
    class Header_5523
    {
        private COM.OraDB MyOraDB = new COM.OraDB();

        private Excel.Workbook workbook = null;
        public System.Data.DataSet vDS_Head = new System.Data.DataSet("Header");
        public System.Data.DataSet vDS_Tail = new System.Data.DataSet("Detail");

        private string version = "";
        private string fob_type = "";

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

                        /*  1. Header Information 
                            Product Code: 1, 1
                            Dev Code: 2, 1
                            Product Name: 3, 1
                            Product Type: 4, 1
                            Factory: 5, 1
                            Season: 6, 1
                            Date: 7, 1
                            LEATHER : Total + 1, 6
                            SYNTHETIC : Total + 2, 6
                            TEXTILE : Total + 3, 6
                            OTHER : Total + 4, 6
                        */

                        // Title ( round 와 무괂 )
                        if (fob_type.Equals(""))
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "FOB Type code is worng.");
                            return false;
                        }

                        string sProdCode = (worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, 1]).Value2.ToString().Trim();
                        if (sProdCode.IndexOf("Product Code") < 0)
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Product code is worng.");
                            return false;
                        }

                        string sDevCode = (worksheet.get_Range(worksheet.Cells[2, 1], worksheet.Cells[2, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[2, 1], worksheet.Cells[2, 1]).Value2.ToString().Trim();
                        if (sDevCode.IndexOf("Dev Code") < 0)
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Dev Name is worng.");
                            return false;
                        }

                        string sProdName = (worksheet.get_Range(worksheet.Cells[3, 1], worksheet.Cells[3, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[3, 1], worksheet.Cells[3, 1]).Value2.ToString().Trim();
                        if (sProdName.IndexOf("Product Name") < 0)
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Product Name is worng.");
                            return false;
                        }

                        string sProdType = (worksheet.get_Range(worksheet.Cells[4, 1], worksheet.Cells[4, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 1], worksheet.Cells[4, 1]).Value2.ToString().Trim();
                        if (sProdType.IndexOf("Product Type") < 0)
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Product Type is worng.");
                            return false;
                        }

                        string sFactory = (worksheet.get_Range(worksheet.Cells[5, 1], worksheet.Cells[5, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 1], worksheet.Cells[5, 1]).Value2.ToString().Trim();
                        if (sFactory.IndexOf("Factory") < 0)
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Factory is worng.");
                            return false;
                        }

                        string sSeason = (worksheet.get_Range(worksheet.Cells[6, 1], worksheet.Cells[6, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[6, 1], worksheet.Cells[6, 1]).Value2.ToString().Trim();
                        if (sSeason.IndexOf("Season") < 0)
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Season is worng.");
                            return false;
                        }

                        string sDate = (worksheet.get_Range(worksheet.Cells[7, 1], worksheet.Cells[7, 1]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[7, 1], worksheet.Cells[7, 1]).Value2.ToString().Trim();
                        if (sDate.IndexOf("Date") < 0)
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Date is worng.");
                            return false;
                        }

                        // Value ( round 무시 )
                        sSeason = (worksheet.get_Range(worksheet.Cells[6, 4], worksheet.Cells[6, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[6, 4], worksheet.Cells[6, 4]).Value2.ToString().Trim();
                        if (sSeason == null || sSeason.Length <= 0)
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Season is worng.");
                            return false;
                        }

                        sDevCode = (worksheet.get_Range(worksheet.Cells[2, 4], worksheet.Cells[2, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[2, 4], worksheet.Cells[2, 4]).Value2.ToString().Trim();
                        if (sDevCode == null || sDevCode.Length <= 0)
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Dev Name is worng.");
                            return false;
                        }

                        sFactory = (worksheet.get_Range(worksheet.Cells[5, 4], worksheet.Cells[5, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[5, 4], worksheet.Cells[5, 4]).Value2.ToString().Trim();
                        if (sFactory == null || sFactory.Length <= 0)
                        {
                            MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Factory is worng.");
                            return false;
                        }

                        // Value ( GTM 단계에서만 체크됨 )
                        if (fob_type.Equals("CFM"))
                        {
                            sProdCode = (worksheet.get_Range(worksheet.Cells[1, 4], worksheet.Cells[1, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[1, 4], worksheet.Cells[1, 4]).Value2.ToString().Trim();
                            if (sProdCode == null || sProdCode.Length <= 0)
                            {
                                MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Product code is worng.");
                                return false;
                            }

                            sProdName = (worksheet.get_Range(worksheet.Cells[3, 4], worksheet.Cells[3, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[3, 4], worksheet.Cells[3, 4]).Value2.ToString().Trim();
                            if (sProdName == null || sProdName.Length <= 0)
                            {
                                MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Product Name is worng.");
                                return false;
                            }

                            sProdType = (worksheet.get_Range(worksheet.Cells[4, 4], worksheet.Cells[4, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[4, 4], worksheet.Cells[4, 4]).Value2.ToString().Trim();
                            if (sProdType == null || sProdType.Length <= 0)
                            {
                                MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Product Type is worng.");
                                return false;
                            }


                            sDate = (worksheet.get_Range(worksheet.Cells[7, 4], worksheet.Cells[7, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[7, 4], worksheet.Cells[7, 4]).Value2.ToString().Trim();
                            if (sDate == null || sDate.Length <= 0)
                            {
                                MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Date is worng.");
                                return false;
                            }
                        }

                        int iTotRow = -1;
                        for (int iRow = 1; iRow < 500; iRow++)
                        {
                            string sTmpSubject = (worksheet.get_Range(worksheet.Cells[iRow, 4], worksheet.Cells[iRow, 4]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[iRow, 4], worksheet.Cells[iRow, 4]).Value2.ToString().Trim();

                            if (sTmpSubject.IndexOf("TOTAL") >= 0)
                            {
                                iTotRow = iRow;
                                break;
                            }
                        }

                        if (iTotRow == -1)
                        {
                            MessageBox.Show(sheet_name + " sheet is not appropriate : [XLS-001]");
                            return false;
                        }

                        // value check 
                        //if (iTotRow != -1)
                        //{
                        //    string sLeather = (worksheet.get_Range(worksheet.Cells[iTotRow + 1, 6], worksheet.Cells[iTotRow + 1, 6]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[iTotRow + 1, 6], worksheet.Cells[iTotRow + 1, 6]).Value2.ToString().Trim();
                        //    if (sLeather.IndexOf("LEATHER") < 0)
                        //    {
                        //        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "LEATHER is worng.");
                        //        return false;
                        //    }

                        //    string sSynthetic = (worksheet.get_Range(worksheet.Cells[iTotRow + 2, 6], worksheet.Cells[iTotRow + 2, 6]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[iTotRow + 2, 6], worksheet.Cells[iTotRow + 2, 6]).Value2.ToString().Trim();
                        //    if (sSynthetic.IndexOf("SYNTHETIC") < 0)
                        //    {
                        //        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "SYNTHETIC is worng.");
                        //        return false;
                        //    }

                        //    string sTextile = (worksheet.get_Range(worksheet.Cells[iTotRow + 3, 6], worksheet.Cells[iTotRow + 3, 6]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[iTotRow + 3, 6], worksheet.Cells[iTotRow + 3, 6]).Value2.ToString().Trim();
                        //    if (sTextile.IndexOf("TEXTILE") < 0)
                        //    {
                        //        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "TEXTILE is worng.");
                        //        return false;
                        //    }

                        //    string sOther = (worksheet.get_Range(worksheet.Cells[iTotRow + 4, 6], worksheet.Cells[iTotRow + 4, 6]).Value2 == null) ? "" : worksheet.get_Range(worksheet.Cells[iTotRow + 4, 6], worksheet.Cells[iTotRow + 4, 6]).Value2.ToString().Trim();
                        //    if (sOther.IndexOf("OTHER") < 0)
                        //    {
                        //        MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "OTHER is worng.");
                        //        return false;
                        //    }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Sheet Name : " + sheet_name + "\r\n\r\n" + "Total Row is worng.");
                        //    return false;
                        //}

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

                vDT.Columns.Add(new DataColumn("FOB_TYPE"));

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

                vDT.Columns.Add(new DataColumn("DEV_CODE"));
                vDT.Columns.Add(new DataColumn("FOB_TYPE"));
                vDT.Columns.Add(new DataColumn("BOM_ID"));

                return vDT;
            }
            catch
            {
                return null;
            }
        }

        #endregion


        #region 2. 데이터 체워 넣기

        public System.Data.DataSet[] FillHeadData()
        {
            try
            {
                for (int iIdx = 1; iIdx <= workbook.Sheets.Count; iIdx++)
                {
                    Worksheet workSheet = (Worksheet)workbook.Sheets[iIdx];

                    System.Data.DataTable vDT = CreateNewHeadDateTable(workSheet.Name);
                    string sStyle = "", sBOMs = "";

                    string sProdCode = (workSheet.get_Range(workSheet.Cells[1, 4], workSheet.Cells[1, 4]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[1, 4], workSheet.Cells[1, 4]).Value2.ToString().Trim();
                    string sDevCode = (workSheet.get_Range(workSheet.Cells[2, 4], workSheet.Cells[2, 4]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[2, 4], workSheet.Cells[2, 4]).Value2.ToString().Trim();
                    string sProdName = (workSheet.get_Range(workSheet.Cells[3, 4], workSheet.Cells[3, 4]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[3, 4], workSheet.Cells[3, 4]).Value2.ToString().Trim();
                    string sProdType = (workSheet.get_Range(workSheet.Cells[4, 4], workSheet.Cells[4, 4]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[4, 4], workSheet.Cells[4, 4]).Value2.ToString().Trim();
                    string sFactory = (workSheet.get_Range(workSheet.Cells[5, 4], workSheet.Cells[5, 4]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[5, 4], workSheet.Cells[5, 4]).Value2.ToString().Trim();
                    string sSeason = (workSheet.get_Range(workSheet.Cells[6, 4], workSheet.Cells[6, 4]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[6, 4], workSheet.Cells[6, 4]).Value2.ToString().Trim();
                    string sDate = (workSheet.get_Range(workSheet.Cells[7, 4], workSheet.Cells[7, 4]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[7, 4], workSheet.Cells[7, 4]).Text.ToString();
                    sDate = sDate.Replace("-", "");

                    int iTotRow = -1;
                    for (int iRow = 1; iRow < 500; iRow++)
                    {
                        string sTmpSubject = (workSheet.get_Range(workSheet.Cells[iRow, 4], workSheet.Cells[iRow, 4]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[iRow, 4], workSheet.Cells[iRow, 4]).Value2.ToString().Trim();

                        if (sTmpSubject.ToUpper().IndexOf("TOTAL") >= 0)
                        {
                            iTotRow = iRow;
                            break;
                        }
                    }

                    for (int iCol = 7; iCol < 7 + 100; iCol++)
                    {
                        if ((bool)workSheet.get_Range(workSheet.Cells[1, iCol], workSheet.Cells[1, iCol]).Columns.Hidden)
                            continue;

                        string sBOM = (workSheet.get_Range(workSheet.Cells[11, iCol], workSheet.Cells[11, iCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[11, iCol], workSheet.Cells[11, iCol]).Value2.ToString().Trim(); ;
                        string sColor = (workSheet.get_Range(workSheet.Cells[12, iCol], workSheet.Cells[12, iCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[12, iCol], workSheet.Cells[12, iCol]).Value2.ToString().Trim(); ;

                        if (sBOM.Equals(""))
                        {
                            break;
                        }
                        else
                        {
                            sStyle += "'" + sProdCode + sColor.PadLeft(3, '0') + "',";
                            sBOMs += "'" + sBOM + "',";
                        }
                    }

                    sStyle = sStyle.TrimEnd(',');
                    sBOMs = sBOMs.TrimEnd(',');

                    System.Data.DataTable vDT2 = SELECT_EBM_FOB_DETAIL_CNT(sFactory, sStyle.Equals("") ? "''" : sStyle, 
                        sDevCode.Replace(" ", "").Replace("-", ""), fob_type, sBOMs.Equals("") ? "" : sBOMs);

                    for (int iCol = 7; iCol < 7 + 100; iCol++)
                    {
                        if ((bool)workSheet.get_Range(workSheet.Cells[1, iCol], workSheet.Cells[1, iCol]).Columns.Hidden)
                            continue;

                        string sColor = (workSheet.get_Range(workSheet.Cells[12, iCol], workSheet.Cells[12, iCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[12, iCol], workSheet.Cells[12, iCol]).Value2.ToString().Trim(); ;
                        string sStyleCD = sProdCode + sColor.PadLeft(3, '0');
                        string sBOM = (workSheet.get_Range(workSheet.Cells[11, iCol], workSheet.Cells[11, iCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[11, iCol], workSheet.Cells[11, iCol]).Value2.ToString().Trim(); ;

                        if (sBOM.Equals(""))
                        {
                            break;
                        }

                        string sLEATHER = "0", sSYNTHETIC = "0", sTEXTILE = "0", sOTHER = "0";
                        if (iTotRow > 0)
                        {
                            for (int iTotRow1 = iTotRow + 1; iTotRow1 < iTotRow + 10; iTotRow1++)
                            {
                                string sTotSub = (workSheet.get_Range(workSheet.Cells[iTotRow1, 6], workSheet.Cells[iTotRow1, 6]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[iTotRow1, 6], workSheet.Cells[iTotRow1, 6]).Value2.ToString().Trim();

                                if (sTotSub.ToUpper().IndexOf("LEATHER") >= 0)
                                    sLEATHER = (workSheet.get_Range(workSheet.Cells[iTotRow1, iCol], workSheet.Cells[iTotRow1, iCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[iTotRow1, iCol], workSheet.Cells[iTotRow1, iCol]).Value2.ToString().Trim();
                                else if (sTotSub.ToUpper().IndexOf("SYNTHETIC") >= 0)
                                    sSYNTHETIC = (workSheet.get_Range(workSheet.Cells[iTotRow1, iCol], workSheet.Cells[iTotRow1, iCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[iTotRow1, iCol], workSheet.Cells[iTotRow1, iCol]).Value2.ToString().Trim();
                                else if (sTotSub.ToUpper().IndexOf("TEXTILE") >= 0)
                                    sTEXTILE = (workSheet.get_Range(workSheet.Cells[iTotRow1, iCol], workSheet.Cells[iTotRow1, iCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[iTotRow1, iCol], workSheet.Cells[iTotRow1, iCol]).Value2.ToString().Trim();
                                else if (sTotSub.ToUpper().IndexOf("OTHER") >= 0)
                                    sOTHER = (workSheet.get_Range(workSheet.Cells[iTotRow1, iCol], workSheet.Cells[iTotRow1, iCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[iTotRow1, iCol], workSheet.Cells[iTotRow1, iCol]).Value2.ToString().Trim();
                            }
                        }

                        if (!sBOM.Equals(""))
                        {
                            System.Data.DataRow ndr = vDT.NewRow();

                            ndr["FACTORY"] = sFactory;
                            ndr["STYLE_CD"] = sStyleCD;
                            ndr["REGION"] = workSheet.Name;
                            ndr["BOM_ID"] = sBOM;
                            ndr["PROD_CODE"] = sProdCode;
                            ndr["DEV_CODE"] = sDevCode;
                            ndr["PROD_NAME"] = sProdName;
                            ndr["PROD_TYPE"] = sProdType;
                            ndr["SEASON_CD"] = sSeason;
                            ndr["APP_YMD"] = sDate;
                            ndr["LEATHER_PCT"] = sLEATHER;
                            ndr["SYNTHETIC_PCT"] = sSYNTHETIC;
                            ndr["TEXTILE_PCT"] = sTEXTILE;
                            ndr["OTHER_PCT"] = sOTHER;
                            ndr["REMARKS"] = null;
                            ndr["STATUS"] = "N";
                            ndr["UPD_USER"] = COM.ComVar.This_User;
                            ndr["UPD_YMD"] = System.DateTime.Now;
                            ndr["UPDATE_FACTORY"] = COM.ComVar.This_Factory;

                            DataRow[] drs = null;
                            if (fob_type.Equals("CFM"))
                                drs = vDT2.Select("style_cd = '" + sStyleCD + "'");
                            else
                                drs = vDT2.Select("bom_id = '" + sBOM + "'");

                            if (drs.Length > 0)
                            {
                                ndr["CHK"] = true;
                                ndr["DETAIL_YN"] = "Y";
                            }
                            else
                            {
                                ndr["CHK"] = false;
                                ndr["DETAIL_YN"] = "N";
                            }

                            ndr["FOB_TYPE"] = fob_type;

                            vDT.Rows.Add(ndr);

                            if (iTotRow > 13)
                            {
                                System.Data.DataTable vDTT = FillTailData(13, iTotRow, iCol,
                                    sFactory, sStyleCD, workSheet.Name, sDevCode, sBOM, workSheet);

                                vDS_Tail.Tables.Add(vDTT);
                            }
                        }
                    }

                    vDS_Head.Tables.Add(vDT);
                }

                return new DataSet[] { vDS_Head, vDS_Tail };
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private System.Data.DataTable FillTailData(int iSRow, int iERow, int iCol, 
            string sFactory, string sStyle, string sRegion, string sDevCode, string sBOM, 
            Worksheet workSheet)
        {
            System.Data.DataTable vDT = CreateNewTailDateTable(sRegion + "_" + sBOM);
            string sCOMP_DIV = "";

            for (int iRow = iSRow, iIdx = 1; iRow < iERow; iRow++, iIdx++)
            {
                DataRow ndr = vDT.NewRow();

                ndr["FACTORY"] = sFactory;
                ndr["STYLE_CD"] = sStyle;
                ndr["REGION"] = sRegion;
                ndr["SEQ"] = iIdx;

                string sTCOMP_DIV = (workSheet.get_Range(workSheet.Cells[iRow, 3], workSheet.Cells[iRow, 3]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[iRow, 3], workSheet.Cells[iRow, 3]).Value2.ToString().Trim();
                sCOMP_DIV = !sTCOMP_DIV.Equals("") ? sTCOMP_DIV : sCOMP_DIV;
                string sCOMP_NAME = (workSheet.get_Range(workSheet.Cells[iRow, 4], workSheet.Cells[iRow, 4]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[iRow, 4], workSheet.Cells[iRow, 4]).Value2.ToString().Trim();
                string sMEASUAL_DATA = (workSheet.get_Range(workSheet.Cells[iRow, 5], workSheet.Cells[iRow, 5]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[iRow, 5], workSheet.Cells[iRow, 5]).Value2.ToString().Trim();
                string sBOM_COMP_READ = (workSheet.get_Range(workSheet.Cells[iRow, iCol], workSheet.Cells[iRow, iCol]).Value2 == null) ? "" : workSheet.get_Range(workSheet.Cells[iRow, iCol], workSheet.Cells[iRow, iCol]).Value2.ToString().Trim(); ;

                ndr["COMP_DIV"] = sCOMP_DIV;
                ndr["COMP_NAME"] = sCOMP_NAME;
                ndr["MEASUAL_DATA"] = sMEASUAL_DATA;
                ndr["BOM_COMP_READ"] = sBOM_COMP_READ;
                ndr["REMARKS"] = null;
                ndr["STATUS"] = "N";
                ndr["UPD_USER"] = COM.ComVar.This_User;
                ndr["UPD_YMD"] = System.DateTime.Now;
                ndr["UPDATE_FACTORY"] = COM.ComVar.This_Factory;

                ndr["DEV_CODE"] = sDevCode;
                ndr["FOB_TYPE"] = fob_type;
                ndr["BOM_ID"] = sBOM;

                vDT.Rows.Add(ndr);
            }

            return vDT;
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
        /// PKG_EBM_FOB_5523.SELECT_EBM_FOB_DETAIL_CNT : 
        /// </summary>
        private System.Data.DataTable SELECT_EBM_FOB_DETAIL_CNT(string arg_factory, string arg_style_cd, string arg_mo_alias, string arg_fob_type, string arg_boms)
        {
            try
            {
                MyOraDB.ReDim_Parameter(6);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_5523.SELECT_EBM_FOB_DETAIL_CNT";

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
                MyOraDB.Parameter_Values[4] = arg_boms;

                MyOraDB.Parameter_Values[5] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet vDS = MyOraDB.Exe_Select_Procedure();

                if (vDS != null)
                    return vDS.Tables[0];

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region Properties

        public Excel.Workbook Workbook
        {
            get { return workbook; }
            set { workbook = value; }
        }

        public string Fob_type
        {
            get { return fob_type; }
            set { fob_type = value; }
        }

        #endregion
    }
}
