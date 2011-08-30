using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Text;

namespace FlexCosting.Management.Costing.Frm
{
    class DBManager
    {
        COM.OraDB MyOraDB = new COM.OraDB();

        #region 등록

        #region 5523 

        /// <summary>
        /// PKG_EBM_FOB_5523.DEL_EBM_FOB_5523 : 
        /// </summary>
        public bool DEL_EBM_FOB_5523(COM.FSP fgrid_head)
        {
            try
            {

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_5523.DEL_EBM_FOB_5523";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";

                MyOraDB.Parameter_Name[2] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[3] = "ARG_FOB_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_BOM_ID";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

                //04.DATA 정의
                int iValueCount = 0;
                for (int iRow1 = fgrid_head.Rows.Fixed; iRow1 < fgrid_head.Rows.Count; iRow1++)
                {
                    if (fgrid_head[iRow1, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxCHK] != null)
                    {
                        string sChk = fgrid_head[iRow1, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxCHK].ToString();
                        if (Convert.ToBoolean(sChk))
                            iValueCount += MyOraDB.Parameter_Name.Length;
                    }
                }

                MyOraDB.Parameter_Values = new string[iValueCount];

                int iTIdx = 0;
                for (int iRow2 = fgrid_head.Rows.Fixed; iRow2 < fgrid_head.Rows.Count; iRow2++)
                {
                    if (fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxCHK] != null)
                    {
                        string sChk = fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxCHK].ToString();

                        if (Convert.ToBoolean(sChk))
                        {
                            MyOraDB.Parameter_Values[iTIdx++] = fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxFACTORY] == null ? "" : fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxFACTORY].ToString();
                            MyOraDB.Parameter_Values[iTIdx++] = fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxSTYLE_CD] == null ? "" : fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxSTYLE_CD].ToString();

                            MyOraDB.Parameter_Values[iTIdx++] = fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxSTYLE_CD] == null ? "" : fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxDEV_CODE].ToString().Replace(" ", "");
                            MyOraDB.Parameter_Values[iTIdx++] = fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxSTYLE_CD] == null ? "" : fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxFOB_TYPE].ToString();
                            MyOraDB.Parameter_Values[iTIdx++] = fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxSTYLE_CD] == null ? "" : fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxBOM_ID].ToString();
                        }
                    }
                }

                MyOraDB.Add_Modify_Parameter(true);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_EBM_FOB_5523.SAVE_EBM_FOB_5523_HEAD : 
        /// </summary>
        public bool SAVE_EBM_FOB_5523_HEAD(COM.FSP fgrid_head)
        {
            try
            {

                MyOraDB.ReDim_Parameter(21);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_5523.SAVE_EBM_FOB_5523_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_REGION";
                MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[4] = "ARG_PROD_CODE";
                MyOraDB.Parameter_Name[5] = "ARG_DEV_CODE";
                MyOraDB.Parameter_Name[6] = "ARG_PROD_NAME";
                MyOraDB.Parameter_Name[7] = "ARG_PROD_TYPE";
                MyOraDB.Parameter_Name[8] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[9] = "ARG_APP_YMD";
                MyOraDB.Parameter_Name[10] = "ARG_LEATHER_PCT";
                MyOraDB.Parameter_Name[11] = "ARG_SYNTHETIC_PCT";
                MyOraDB.Parameter_Name[12] = "ARG_TEXTILE_PCT";
                MyOraDB.Parameter_Name[13] = "ARG_OTHER_PCT";
                MyOraDB.Parameter_Name[14] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[15] = "ARG_STATUS";
                MyOraDB.Parameter_Name[16] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[17] = "ARG_UPD_YMD";
                MyOraDB.Parameter_Name[18] = "ARG_UPDATE_FACTORY";
                MyOraDB.Parameter_Name[19] = "ARG_DETAIL_YN";

                MyOraDB.Parameter_Name[20] = "ARG_FOB_TYPE";


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


                //04.DATA 정의
                int iValueCount = 0;
                for (int iRow1 = fgrid_head.Rows.Fixed; iRow1 < fgrid_head.Rows.Count; iRow1++)
                {
                    if (fgrid_head[iRow1, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxCHK] != null)
                    {
                        string sChk = fgrid_head[iRow1, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxCHK].ToString();
                        if (Convert.ToBoolean(sChk))
                            iValueCount += MyOraDB.Parameter_Name.Length;
                    }
                }

                MyOraDB.Parameter_Values = new string[iValueCount];

                int iTIdx = 0;
                for (int iRow2 = fgrid_head.Rows.Fixed; iRow2 < fgrid_head.Rows.Count; iRow2++)
                {
                    if (fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxCHK] != null)
                    {
                        string sChk = fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxCHK].ToString();

                        if (Convert.ToBoolean(sChk))
                        {
                            for (int iCol2 = (int)ClassLib.TBEBM_FOB_5523_HEAD.IxFACTORY; iCol2 < fgrid_head.Cols.Count; iCol2++, iTIdx++)
                            {
                                MyOraDB.Parameter_Values[iTIdx] = fgrid_head[iRow2, iCol2] == null ? "" : fgrid_head[iRow2, iCol2].ToString();
                            }
                        }
                    }
                }

                MyOraDB.Add_Modify_Parameter(false);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_EBM_FOB_5523.SAVE_EBM_FOB_5523_TAIL : 
        /// </summary>
        public DataSet SAVE_EBM_FOB_5523_TAIL(COM.FSP fgrid_head, DataSet vTDS)
        {
            try
            {
                MyOraDB.ReDim_Parameter(16);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_5523.SAVE_EBM_FOB_5523_TAIL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "ARG_REGION";
                MyOraDB.Parameter_Name[3] = "ARG_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_COMP_DIV";
                MyOraDB.Parameter_Name[5] = "ARG_COMP_NAME";
                MyOraDB.Parameter_Name[6] = "ARG_MEASUAL_DATA";
                MyOraDB.Parameter_Name[7] = "ARG_BOM_COMP_READ";
                MyOraDB.Parameter_Name[8] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[9] = "ARG_STATUS";
                MyOraDB.Parameter_Name[10] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[11] = "ARG_UPD_YMD";
                MyOraDB.Parameter_Name[12] = "ARG_UPDATE_FACTORY";

                MyOraDB.Parameter_Name[13] = "ARG_DEV_CODE";
                MyOraDB.Parameter_Name[14] = "ARG_FOB_TYPE";
                MyOraDB.Parameter_Name[15] = "ARG_BOM_ID";


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


                //04.DATA 정의
                int iValueCount = 0;
                for (int iRow1 = fgrid_head.Rows.Fixed; iRow1 < fgrid_head.Rows.Count; iRow1++)
                {
                    if (fgrid_head[iRow1, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxCHK] != null)
                    {
                        string sChk = fgrid_head[iRow1, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxCHK].ToString();
                        if (Convert.ToBoolean(sChk))
                        {
                            string sTailNM =
                                fgrid_head[iRow1, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxREGION].ToString() +
                                "_" +
                                fgrid_head[iRow1, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxBOM_ID].ToString();

                            System.Data.DataTable vTDT = vTDS.Tables[sTailNM];
                            if (vTDT != null)
                                iValueCount += MyOraDB.Parameter_Name.Length * vTDT.Rows.Count;
                        }
                    }
                }

                MyOraDB.Parameter_Values = new string[iValueCount];

                int iTIdx = 0;
                for (int iRow2 = fgrid_head.Rows.Fixed; iRow2 < fgrid_head.Rows.Count; iRow2++)
                {
                    if (fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxCHK] != null)
                    {
                        string sChk = fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxCHK].ToString();
                        if (Convert.ToBoolean(sChk))
                        {
                            string sTailNM =
                                fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxREGION].ToString() +
                                "_" +
                                fgrid_head[iRow2, (int)ClassLib.TBEBM_FOB_5523_HEAD.IxBOM_ID].ToString();

                            System.Data.DataTable vTDT = vTDS.Tables[sTailNM];
                            if (vTDT != null)
                            {
                                for (int iTRIdx = 0; iTRIdx < vTDT.Rows.Count; iTRIdx++)
                                {
                                    for (int iTCIdx = 0; iTCIdx < vTDT.Rows[iTRIdx].ItemArray.Length; iTCIdx++, iTIdx++)
                                    {
                                        MyOraDB.Parameter_Values[iTIdx] = vTDT.Rows[iTRIdx][iTCIdx].ToString();
                                    }
                                }
                            }
                        }
                    }
                }

                MyOraDB.Add_Modify_Parameter(false);
                return MyOraDB.Exe_Modify_Procedure();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region MEOF

        /// <summary>
        /// PKG_EBM_FOB_MEOF.DEL_EBM_FOB_MEOF : 
        /// </summary>
        public bool DEL_EBM_FOB_MEOF(string arg_factory, string arg_moid)
        {
            try
            {

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_MEOF.DEL_EBM_FOB_MEOF";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_moid;

                return MyOraDB.Add_Modify_Parameter(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_EBM_FOB_MEOF.SAVE_EBM_FOB_MEOF_HEAD : 
        /// </summary>
        public bool SAVE_EBM_FOB_MEOF_HEAD(COM.FSP fgrid_head)
        {
            try
            {

                MyOraDB.ReDim_Parameter(36);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_MEOF.SAVE_EBM_FOB_MEOF_HEAD";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_MOID";
                MyOraDB.Parameter_Name[3] = "ARG_PIM_SEQ";
                MyOraDB.Parameter_Name[4] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[5] = "ARG_PART_TYPE";
                MyOraDB.Parameter_Name[6] = "ARG_MOLD_CD";
                MyOraDB.Parameter_Name[7] = "ARG_LAST_CD";
                MyOraDB.Parameter_Name[8] = "ARG_DEV_MOLD_SHOP";
                MyOraDB.Parameter_Name[9] = "ARG_PROD_MOLD_SHOP";
                MyOraDB.Parameter_Name[10] = "ARG_MOLD_MAT";
                MyOraDB.Parameter_Name[11] = "ARG_MOLD_MFG_TECH";
                MyOraDB.Parameter_Name[12] = "ARG_MOLDED_MAT";
                MyOraDB.Parameter_Name[13] = "ARG_SAMP_MOLD_COST";
                MyOraDB.Parameter_Name[14] = "ARG_MOLD_A_COST";
                MyOraDB.Parameter_Name[15] = "ARG_MOLD_B_COST";
                MyOraDB.Parameter_Name[16] = "ARG_MOLD_ROUND";
                MyOraDB.Parameter_Name[17] = "ARG_COMP_SHARED";
                MyOraDB.Parameter_Name[18] = "ARG_SHIFT_PER_DAY";
                MyOraDB.Parameter_Name[19] = "ARG_HOURS_PER_SHIFT";
                MyOraDB.Parameter_Name[20] = "ARG_HOURS_PER_DAY";
                MyOraDB.Parameter_Name[21] = "ARG_WORKING_DAYS";
                MyOraDB.Parameter_Name[22] = "ARG_EFFICIENCY_RATE";
                MyOraDB.Parameter_Name[23] = "ARG_PAIRS_PER_DAY";
                MyOraDB.Parameter_Name[24] = "ARG_PEAK_PAIRAGE";
                MyOraDB.Parameter_Name[25] = "ARG_AMORT_PAIRAGE";
                MyOraDB.Parameter_Name[26] = "ARG_MOLD_A_QTY";
                MyOraDB.Parameter_Name[27] = "ARG_MOLD_B_QTY";
                MyOraDB.Parameter_Name[28] = "ARG_MDF";
                MyOraDB.Parameter_Name[29] = "ARG_SIZE_RUN";
                MyOraDB.Parameter_Name[30] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[31] = "ARG_STATUS";
                MyOraDB.Parameter_Name[32] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[33] = "ARG_UPD_YMD";
                MyOraDB.Parameter_Name[34] = "ARG_UPDATE_FACTORY";
                MyOraDB.Parameter_Name[35] = "ARG_PIM_COUNT";

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

                //04.DATA 정의
                int iValueCount = 0;
                int iFixedRow = fgrid_head.Rows.Fixed - 1;
                int iIdx = 0;

                for (int iCol1 = (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxMOLD_1; iCol1 <= (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxMOLD_7; iCol1++)
                {
                    object oFactory = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxFACTORY + iFixedRow, iCol1];

                    if (oFactory != null)
                    {
                        if (!oFactory.ToString().Equals(""))
                        {
                            iValueCount += MyOraDB.Parameter_Name.Length;
                        }
                    }
                }

                MyOraDB.Parameter_Values = new string[iValueCount];
                for (int iCol2 = (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxMOLD_1; iCol2 <= (int)ClassLib.TBEBM_FOB_MEOF_HEAD_1.IxMOLD_7; iCol2++)
                {
                    object oFactory = fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxFACTORY + (fgrid_head.Rows.Fixed - 1), iCol2];

                    if (oFactory != null)
                    {
                        if (!oFactory.ToString().Equals(""))
                        {

                            // SAMP_MOLD_COST, MOLD_A_COST, MOLD_B_COST, SHIFT_PER_DAY, HOURS_PER_SHIFT, HOURS_PER_DAY, 
                            // WORKING_DAYS, EFFICIENCY_RATE, PAIRS_PER_DAY, PEAK_PAIRAGE, AMORT_PAIRAGE, MOLD_A_QTY, 
                            // MOLD_B_QTY, MDF
                            MyOraDB.Parameter_Values[iIdx++] = "I";
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxFACTORY + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOID + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxPIM_SEQ + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxSEASON_CD + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxPART_TYPE + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_CD + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxLAST_CD + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxDEV_MOLD_SHOP + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxPROD_MOLD_SHOP + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_MAT + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_MFG_TECH + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLDED_MAT + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxSAMP_MOLD_COST + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_A_COST + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_B_COST + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_ROUND + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxCOMP_SHARED + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxSHIFT_PER_DAY + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxHOURS_PER_SHIFT + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxHOURS_PER_DAY + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxWORKING_DAYS + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxEFFICIENCY_RATE + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxPAIRS_PER_DAY + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxPEAK_PAIRAGE + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxAMORT_PAIRAGE + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_A_QTY + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMOLD_B_QTY + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToDString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxMDF + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxSIZE_RUN + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxREMARKS + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxSTATUS + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxUPD_USER + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxUPD_YMD + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxUPDATE_FACTORY + iFixedRow, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_head[(int)ClassLib.TBEBM_FOB_MEOF_HEAD_2.IxPIM_COUNT + iFixedRow, iCol2]);
                        }
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
        /// PKG_EBM_FOB_MEOF.SAVE_EBM_FOB_MEOF_TAIL : 
        /// </summary>
        public bool SAVE_EBM_FOB_MEOF_TAIL(COM.FSP fgrid_head, COM.FSP fgrid_size, 
            string arg_factory, string arg_moid)
        {
            try
            {

                MyOraDB.ReDim_Parameter(17);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_MEOF.SAVE_EBM_FOB_MEOF_TAIL";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_MOID";
                MyOraDB.Parameter_Name[3] = "ARG_MOLD_CD";
                MyOraDB.Parameter_Name[4] = "ARG_PIM_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_SEQ";
                MyOraDB.Parameter_Name[6] = "ARG_CS_SIZE";
                MyOraDB.Parameter_Name[7] = "ARG_SIZE_PCT";
                MyOraDB.Parameter_Name[8] = "ARG_SIZE_PAIRS";
                MyOraDB.Parameter_Name[9] = "ARG_MOLD_REQ";
                MyOraDB.Parameter_Name[10] = "ARG_PIM";
                MyOraDB.Parameter_Name[11] = "ARG_MD";
                MyOraDB.Parameter_Name[12] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[13] = "ARG_STATUS";
                MyOraDB.Parameter_Name[14] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[15] = "ARG_UPD_YMD";
                MyOraDB.Parameter_Name[16] = "ARG_UPDATE_FACTORY";

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

                //04.DATA 정의
                int iValueCount = 0;
                int iFixedRow = fgrid_head.Rows.Fixed - 1;
                int iIdx = 0;

                for (int iCol1 = (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_MOLD_CD; iCol1 < fgrid_size.Cols.Count; iCol1++)
                {
                    string sSubject = fgrid_size[fgrid_size.Rows.Fixed - 3, iCol1].ToString();
                    if (sSubject.Equals("Mold Code"))
                    {
                        for (int iRow1 = fgrid_size.Rows.Fixed; iRow1 < fgrid_size.Rows.Count; iRow1++)
                        {
                            string sMoldCd = ObjectToString(fgrid_size[iRow1, iCol1]);
                            if (sMoldCd.Equals(""))
                                break;

                            iValueCount += MyOraDB.Parameter_Name.Length;
                        }
                    }
                }

                MyOraDB.Parameter_Values = new string[iValueCount];
                for (int iCol2 = (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_MOLD_CD; iCol2 < fgrid_size.Cols.Count; iCol2++)
                {
                    string sSubject = fgrid_size[fgrid_size.Rows.Fixed - 3, iCol2].ToString();
                    if (sSubject.Equals("Mold Code"))
                    {
                        for (int iRow2 = fgrid_size.Rows.Fixed; iRow2 < fgrid_size.Rows.Count; iRow2++)
                        {
                            string sMoldCd = ObjectToString(fgrid_size[iRow2, iCol2]);
                            if (sMoldCd.Equals(""))
                                break;

                            MyOraDB.Parameter_Values[iIdx++] = "I";
                            MyOraDB.Parameter_Values[iIdx++] = arg_factory;
                            MyOraDB.Parameter_Values[iIdx++] = arg_moid;
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, iCol2]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_PIM_SEQ + (iCol2 - 1)]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_SEQ + (iCol2 - 1)]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_CS_SIZE + (iCol2 - 1)]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_SIZE_PCT + (iCol2 - 1)]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_SIZE_PAIRS + (iCol2 - 1)]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_MOLD_REQ + (iCol2 - 1)]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_PIM + (iCol2 - 1)]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_MD + (iCol2 - 1)]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_REMARKS + (iCol2 - 1)]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_STATUS + (iCol2 - 1)]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_UPD_USER + (iCol2 - 1)]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_UPD_YMD + (iCol2 - 1)]);
                            MyOraDB.Parameter_Values[iIdx++] = ObjectToString(fgrid_size[iRow2, (int)ClassLib.TBEBM_FOB_MEOF_TAIL.Ix1_UPDATE_FACTORY + (iCol2 - 1)]);
                        }
                    }
                }

                DataSet vDS = null;
                MyOraDB.Add_Modify_Parameter(false);
                vDS = MyOraDB.Exe_Modify_Procedure();
                if (vDS == null)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

        private double StringToDouble(string str)
        {
            double result = 0;
            if (double.TryParse(str, out result))
                return double.Parse(str);
            else
                return result;
        }

        private string ObjectToDString(object obj)
        {
            string sResult = "0";
            double dResult = 0;

            if (obj != null)
            {
                if (double.TryParse(obj.ToString(), out dResult))
                    return obj.ToString();
                else
                    return sResult;
            }

            return sResult;
        }

        private string ObjectToString(object obj)
        {
            if (obj != null)
                return obj.ToString();

            return "";
        }

        #endregion
    }
}
