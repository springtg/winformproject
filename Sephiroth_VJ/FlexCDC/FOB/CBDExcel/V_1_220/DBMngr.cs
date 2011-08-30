using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Text;

namespace FlexCDC.FOB.CBDExcel.V_1_220
{
    class DBMngr
    {
        COM.OraDB MyOraDB = new COM.OraDB();

        #region 등록

        public bool SAVE_EBM_FOB(System.Data.DataTable arg_dt)
        {
            try
            {
                int col_ct = 55;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_EBM_FOB_SAVE.SAVE_EBM_FOB";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "arg_division";
                MyOraDB.Parameter_Name[1] = "arg_factory";
                MyOraDB.Parameter_Name[2] = "arg_obs_id";
                MyOraDB.Parameter_Name[3] = "arg_obs_type";
                MyOraDB.Parameter_Name[4] = "arg_style_cd";
                MyOraDB.Parameter_Name[5] = "arg_dev_name";
                MyOraDB.Parameter_Name[6] = "arg_mo_alias";
                MyOraDB.Parameter_Name[7] = "arg_bom_id";
                MyOraDB.Parameter_Name[8] = "arg_category";
                MyOraDB.Parameter_Name[9] = "arg_fob_status";
                MyOraDB.Parameter_Name[10] = "arg_fob_type";
                MyOraDB.Parameter_Name[11] = "arg_season_cd";
                MyOraDB.Parameter_Name[12] = "arg_quoted_ymd";
                MyOraDB.Parameter_Name[13] = "arg_gen_cd";
                MyOraDB.Parameter_Name[14] = "arg_size_cd";
                MyOraDB.Parameter_Name[15] = "arg_size_up";
                MyOraDB.Parameter_Name[16] = "arg_factory_fob";
                MyOraDB.Parameter_Name[17] = "arg_margin_rate";
                MyOraDB.Parameter_Name[18] = "arg_up";
                MyOraDB.Parameter_Name[19] = "arg_bottom";
                MyOraDB.Parameter_Name[20] = "arg_m_upper";
                MyOraDB.Parameter_Name[21] = "arg_m_packaging";
                MyOraDB.Parameter_Name[22] = "arg_m_midsole";
                MyOraDB.Parameter_Name[23] = "arg_m_outsole";
                MyOraDB.Parameter_Name[24] = "arg_m_size_up";
                MyOraDB.Parameter_Name[25] = "arg_m_price";
                MyOraDB.Parameter_Name[26] = "arg_m_ratio";
                MyOraDB.Parameter_Name[27] = "arg_extra";
                MyOraDB.Parameter_Name[28] = "arg_l_oh";
                MyOraDB.Parameter_Name[29] = "arg_profit";
                MyOraDB.Parameter_Name[30] = "arg_other_ad";
                MyOraDB.Parameter_Name[31] = "arg_nm_price";
                MyOraDB.Parameter_Name[32] = "arg_t_sample";
                MyOraDB.Parameter_Name[33] = "arg_t_production";
                MyOraDB.Parameter_Name[34] = "arg_tooling";
                MyOraDB.Parameter_Name[35] = "arg_fob";
                MyOraDB.Parameter_Name[36] = "arg_rate_idr";
                MyOraDB.Parameter_Name[37] = "arg_rate_inr";
                MyOraDB.Parameter_Name[38] = "arg_rate_krw";
                MyOraDB.Parameter_Name[39] = "arg_rate_rmb";
                MyOraDB.Parameter_Name[40] = "arg_rate_thb";
                MyOraDB.Parameter_Name[41] = "arg_rate_twd";
                MyOraDB.Parameter_Name[42] = "arg_rate_usd";
                MyOraDB.Parameter_Name[43] = "arg_rate_vnd";
                MyOraDB.Parameter_Name[44] = "arg_forecast";
                MyOraDB.Parameter_Name[45] = "arg_peak";
                MyOraDB.Parameter_Name[46] = "arg_retail";
                MyOraDB.Parameter_Name[47] = "arg_target";
                MyOraDB.Parameter_Name[48] = "arg_pattern_desc";
                MyOraDB.Parameter_Name[49] = "arg_tooling_desc";
                MyOraDB.Parameter_Name[50] = "arg_size_desc";
                MyOraDB.Parameter_Name[51] = "arg_remarks";
                MyOraDB.Parameter_Name[52] = "arg_status";
                MyOraDB.Parameter_Name[53] = "arg_upd_user";
                MyOraDB.Parameter_Name[54] = "arg_upd_method";

                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }


                // 파라미터 값에 저장할 배열
                ArrayList vList = new ArrayList();

                for (int i = 0; i < arg_dt.Rows.Count; i++)
                {
                    //if (arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxDIV] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxDIV].ToString().Equals("")) continue;

                    //vList.Add("D");
                    //vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString());
                    //vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID].ToString());
                    //vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxOBS_TYPE].ToString());
                    //vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD].ToString().Replace("-", ""));

                    //for (int k = 5; k < col_ct - 1; k++)
                    //    vList.Add("");

                    //vList.Add("E");


                    // Delete 
                    vList.Add("D");
                    vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString());
                    vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID].ToString());
                    vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxOBS_TYPE].ToString());
                    vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD].ToString().Replace("-", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxCATEGORY] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxCATEGORY].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB_STATUS] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB_STATUS].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSEASON] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSEASON].ToString().Trim());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxQUOTED_YMD] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxQUOTED_YMD].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxGEN_CD] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxGEN_CD].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_CD] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_CD].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY_FOB] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY_FOB].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY_FOB].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxMARGIN_RATE] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxMARGIN_RATE].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxMARGIN_RATE].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxUP] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxUP].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxUP].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_UPPER] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_UPPER].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_UPPER].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_PACKAGING] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_PACKAGING].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_PACKAGING].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_MIDSOLE] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_MIDSOLE].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_MIDSOLE].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_OUT_SOLE] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_OUT_SOLE].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_OUT_SOLE].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_SIZE_UP] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_SIZE_UP].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_SIZE_UP].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxL_OH] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxL_OH].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxL_OH].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxT_SAMPLE] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxT_SAMPLE].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxT_SAMPLE].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxT_PRODUCTION] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxT_PRODUCTION].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxT_PRODUCTION].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPEAK] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPEAK].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPEAK].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTARGET] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTARGET].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTARGET].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPATTERN_DESC] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPATTERN_DESC].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING_DESC] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING_DESC].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_DESC] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_DESC].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxREMARKS] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxREMARKS].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSTATUS] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSTATUS].ToString());
                    vList.Add(COM.ComVar.This_User);
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxUPD_YMD] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxUPD_YMD].ToString());


                    // Insert
                    vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxDIV].ToString());
                    vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY].ToString());
                    vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxOBS_ID].ToString());
                    vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxOBS_TYPE].ToString());
                    vList.Add(arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_CD].ToString().Replace("-", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSTYLE_NAME].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxMO_ALIAS].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxBOM_ID].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxCATEGORY] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxCATEGORY].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB_STATUS] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB_STATUS].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB_TYPE].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSEASON] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSEASON].ToString().Trim());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxQUOTED_YMD] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxQUOTED_YMD].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxGEN_CD] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxGEN_CD].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_CD] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_CD].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_UP].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY_FOB] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY_FOB].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFACTORY_FOB].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxMARGIN_RATE] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxMARGIN_RATE].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxMARGIN_RATE].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxUP] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxUP].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxUP].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxBOTTOM].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_UPPER] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_UPPER].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_UPPER].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_PACKAGING] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_PACKAGING].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_PACKAGING].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_MIDSOLE] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_MIDSOLE].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_MIDSOLE].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_OUT_SOLE] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_OUT_SOLE].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_OUT_SOLE].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_SIZE_UP] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_SIZE_UP].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_SIZE_UP].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_PRICE].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxM_RATIO].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxEXTRA].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxL_OH] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxL_OH].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxL_OH].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPROFIT].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxOTHER_AD].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxNM_PRICE].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxT_SAMPLE] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxT_SAMPLE].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxT_SAMPLE].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxT_PRODUCTION] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxT_PRODUCTION].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxT_PRODUCTION].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFOB].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_IDR].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_INR].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_KRW].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_RMB].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_THB].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_TWD].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_USD].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRATE_VND].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxFORECAST].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPEAK] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPEAK].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPEAK].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxRETAIL].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTARGET] == null || arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTARGET].ToString().Trim().Equals("")) ? "0" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTARGET].ToString().Replace(",", ""));
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPATTERN_DESC] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxPATTERN_DESC].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING_DESC] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxTOOLING_DESC].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_DESC] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSIZE_DESC].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxREMARKS] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxREMARKS].ToString());
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSTATUS] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxSTATUS].ToString());
                    vList.Add(COM.ComVar.This_User);
                    vList.Add((arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxUPD_YMD] == null) ? "" : arg_dt.Rows[i][(int)ClassLib.TBEIS_FOB_MASTER.IxUPD_YMD].ToString());

                } //end for i

                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));
                MyOraDB.Add_Modify_Parameter(true);

                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool SAVE_EBM_FOB_DETAIL(System.Data.DataSet arg_ds_value)
        {
            try
            {
                #region Detail
                int col_ct = 37;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_EBM_FOB_SAVE.INSERT_EBM_FOB_DETAIL";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_obs_id_01";
                MyOraDB.Parameter_Name[2] = "arg_obs_id_02";
                MyOraDB.Parameter_Name[3] = "arg_obs_id_03";
                MyOraDB.Parameter_Name[4] = "arg_obs_type";
                MyOraDB.Parameter_Name[5] = "arg_style_cd";
                MyOraDB.Parameter_Name[6] = "arg_size_excld";
                MyOraDB.Parameter_Name[7] = "arg_class";
                MyOraDB.Parameter_Name[8] = "arg_sub_class";
                MyOraDB.Parameter_Name[9] = "arg_bom_id";
                MyOraDB.Parameter_Name[10] = "arg_cbd";
                MyOraDB.Parameter_Name[11] = "arg_part";
                MyOraDB.Parameter_Name[12] = "arg_mat_name";
                MyOraDB.Parameter_Name[13] = "arg_vendor";
                MyOraDB.Parameter_Name[14] = "arg_color";
                MyOraDB.Parameter_Name[15] = "arg_mat_no";
                MyOraDB.Parameter_Name[16] = "arg_uom";
                MyOraDB.Parameter_Name[17] = "arg_curr";
                MyOraDB.Parameter_Name[18] = "arg_fx_rate";
                MyOraDB.Parameter_Name[19] = "arg_mat_price";
                MyOraDB.Parameter_Name[20] = "arg_frt_trm";
                MyOraDB.Parameter_Name[21] = "arg_fct_lnd_rate";
                MyOraDB.Parameter_Name[22] = "arg_fct_lnd_tot";
                MyOraDB.Parameter_Name[23] = "arg_fct_lnd_usd_tot";
                MyOraDB.Parameter_Name[24] = "arg_yield";
                MyOraDB.Parameter_Name[25] = "arg_loss_rate";
                MyOraDB.Parameter_Name[26] = "arg_usage";
                MyOraDB.Parameter_Name[27] = "arg_us_cost";
                MyOraDB.Parameter_Name[28] = "arg_size_tot_cost";
                MyOraDB.Parameter_Name[29] = "arg_sizing_up_charge";
                MyOraDB.Parameter_Name[30] = "arg_processing_cost";
                MyOraDB.Parameter_Name[31] = "arg_remarks";
                MyOraDB.Parameter_Name[32] = "arg_status";
                MyOraDB.Parameter_Name[33] = "arg_upd_user";

                MyOraDB.Parameter_Name[34] = "arg_mo_alias";
                MyOraDB.Parameter_Name[35] = "arg_fob_type";
                MyOraDB.Parameter_Name[36] = "arg_upd_method";


                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }

                // 파라미터 값에 저장할 배열
                ArrayList vList = new ArrayList();
                System.Data.DataTable dt_detail = arg_ds_value.Tables["Upper"];

                for (int row = 0; row < dt_detail.Rows.Count; row++)
                {
                    vList.Add(dt_detail.Rows[row].ItemArray[0].ToString());  //"arg_factory";
                    vList.Add(dt_detail.Rows[row].ItemArray[1].ToString());  //"arg_obs_id";
                    vList.Add(dt_detail.Rows[row].ItemArray[2].ToString());  //"arg_obs_id";
                    vList.Add(dt_detail.Rows[row].ItemArray[3].ToString());  //"arg_obs_id";
                    vList.Add(dt_detail.Rows[row].ItemArray[4].ToString());  //"arg_obs_type";
                    vList.Add(dt_detail.Rows[row].ItemArray[5].ToString().Replace("-", "").Substring(0, 9));  //"arg_style_cd";
                    vList.Add((dt_detail.Rows[row].ItemArray[6].ToString().Trim() == "") ? "N" : dt_detail.Rows[row].ItemArray[6].ToString());  //"arg_size_excld";
                    vList.Add(dt_detail.Rows[row].ItemArray[7].ToString());  //"arg_class";
                    vList.Add(dt_detail.Rows[row].ItemArray[8].ToString());  //"arg_sub_class";
                    vList.Add(dt_detail.Rows[row].ItemArray[9].ToString());  //"arg_bom_id";
                    vList.Add(dt_detail.Rows[row].ItemArray[10].ToString());  //"arg_cbd";
                    vList.Add(dt_detail.Rows[row].ItemArray[11].ToString());  //"arg_part";
                    vList.Add(dt_detail.Rows[row].ItemArray[12].ToString());  //"arg_mat_name";
                    vList.Add(dt_detail.Rows[row].ItemArray[13].ToString()); //"arg_vendor";
                    vList.Add(dt_detail.Rows[row].ItemArray[14].ToString()); //"arg_color";
                    vList.Add(dt_detail.Rows[row].ItemArray[15].ToString()); //"arg_mat_no";                    
                    vList.Add(dt_detail.Rows[row].ItemArray[16].ToString().Replace('"', '`')); //"arg_uom";
                    vList.Add(dt_detail.Rows[row].ItemArray[17].ToString()); //"arg_curr";

                    try
                    {
                        vList.Add(double.Parse(dt_detail.Rows[row].ItemArray[18].ToString().Trim()).ToString("########0.######"));//"arg_fx_rate";
                    }
                    catch
                    {
                        vList.Add("0"); //"arg_fx_rate";
                    }
                    try
                    {
                        vList.Add(double.Parse(dt_detail.Rows[row].ItemArray[19].ToString().Trim()).ToString("########0.######")); //"arg_mat_price"
                    }
                    catch
                    {
                        vList.Add("0"); //"arg_mat_price";
                    }
                    vList.Add(dt_detail.Rows[row].ItemArray[20].ToString()); //"arg_frt_trm";
                    try
                    {
                        double fct_lnd_rate = double.Parse(dt_detail.Rows[row].ItemArray[21].ToString().Trim()) * 100;
                        vList.Add(fct_lnd_rate.ToString("########0.######")); //"arg_fct_lnd_rate";
                    }
                    catch
                    {
                        vList.Add("0"); //"arg_fct_lnd_rate";
                    }
                    try
                    {
                        vList.Add(double.Parse(dt_detail.Rows[row].ItemArray[22].ToString().Trim()).ToString("########0.######")); //"arg_fct_lnd_tot";
                    }
                    catch
                    {
                        vList.Add("0"); //"arg_fct_lnd_tot";
                    }
                    try
                    {
                        vList.Add(double.Parse(dt_detail.Rows[row].ItemArray[23].ToString().Trim()).ToString("########0.######")); //"arg_fct_lnd_usd_tot";
                    }
                    catch
                    {
                        vList.Add("0"); //"arg_fct_lnd_usd_tot";
                    }
                    try
                    {
                        vList.Add(double.Parse(dt_detail.Rows[row].ItemArray[24].ToString().Trim()).ToString("########0.######")); //"arg_yield";
                    }
                    catch
                    {
                        vList.Add("0"); //"arg_yield";
                    }
                    try
                    {
                        double loss_rate = double.Parse(dt_detail.Rows[row].ItemArray[25].ToString().Trim()) * 100;
                        vList.Add(loss_rate.ToString("########0.######")); //"arg_loss_rate";
                    }
                    catch
                    {
                        vList.Add("0"); //"arg_loss_rate";
                    }
                    try
                    {
                        vList.Add(double.Parse(dt_detail.Rows[row].ItemArray[26].ToString().Trim()).ToString("########0.######"));
                    }
                    catch
                    {
                        vList.Add("0");
                    } try
                    {
                        vList.Add(double.Parse(dt_detail.Rows[row].ItemArray[27].ToString().Trim()).ToString("########0.######")); //"arg_us_cost";
                    }
                    catch
                    {
                        vList.Add("0"); //"arg_us_cost";
                    }
                    try
                    {
                        vList.Add(double.Parse(dt_detail.Rows[row].ItemArray[28].ToString().Trim()).ToString("########0.######")); //"arg_size_tot_cost";
                    }
                    catch
                    {
                        vList.Add("0"); //"arg_size_tot_cost";
                    }
                    try
                    {
                        vList.Add(double.Parse(dt_detail.Rows[row].ItemArray[29].ToString().Trim()).ToString("########0.######")); //"arg_sizing_up_charge";
                    }
                    catch
                    {
                        vList.Add("0"); //"arg_sizing_up_charge";
                    }
                    try
                    {
                        vList.Add(double.Parse(dt_detail.Rows[row].ItemArray[30].ToString().Trim()).ToString("########0.######")); //"arg_processing_cost";
                    }
                    catch
                    {
                        vList.Add("0"); //"arg_processing_cost";
                    }
                    vList.Add(dt_detail.Rows[row].ItemArray[31].ToString());        //"arg_remarks";
                    vList.Add("N");                                                 //"arg_status";
                    vList.Add(COM.ComVar.This_User);                                //"arg_upd_user";
                    vList.Add(dt_detail.Rows[row].ItemArray[34].ToString());        //"arg_mo_alias";
                    vList.Add(dt_detail.Rows[row].ItemArray[35].ToString());        //"arg_fob_type";
                    vList.Add(dt_detail.Rows[row].ItemArray[36].ToString());        //"arg_upd_method";
                }

                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));
                MyOraDB.Add_Modify_Parameter(false);
                #endregion

                #region 주석
                #region Labor
                col_ct = 28;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_EBM_FOB_SAVE.INSERT_EBM_FOB_LABOR";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_obs_id_01";
                MyOraDB.Parameter_Name[2] = "arg_obs_id_02";
                MyOraDB.Parameter_Name[3] = "arg_obs_id_03";
                MyOraDB.Parameter_Name[4] = "arg_obs_type";
                MyOraDB.Parameter_Name[5] = "arg_style_cd";
                MyOraDB.Parameter_Name[6] = "arg_class";
                MyOraDB.Parameter_Name[7] = "arg_sub_class";
                MyOraDB.Parameter_Name[8] = "arg_curr";
                MyOraDB.Parameter_Name[9] = "arg_fx_rate";
                MyOraDB.Parameter_Name[10] = "arg_process";
                MyOraDB.Parameter_Name[11] = "arg_direct_annual_wages";
                MyOraDB.Parameter_Name[12] = "arg_direct_labor_worker";
                MyOraDB.Parameter_Name[13] = "arg_day_paid_annualy";
                MyOraDB.Parameter_Name[14] = "arg_minute_day_worker";
                MyOraDB.Parameter_Name[15] = "arg_effctv_rate";
                MyOraDB.Parameter_Name[16] = "arg_cost_std_minute";
                MyOraDB.Parameter_Name[17] = "arg_std_minutes_pair";
                MyOraDB.Parameter_Name[18] = "arg_cost_pair_local";
                MyOraDB.Parameter_Name[19] = "arg_cost_pair_usd";
                MyOraDB.Parameter_Name[20] = "arg_ov_cost_pr";
                MyOraDB.Parameter_Name[21] = "arg_remarks";
                MyOraDB.Parameter_Name[22] = "arg_status";
                MyOraDB.Parameter_Name[23] = "arg_upd_user";

                MyOraDB.Parameter_Name[24] = "arg_mo_alias";
                MyOraDB.Parameter_Name[25] = "arg_bom_id";
                MyOraDB.Parameter_Name[26] = "arg_fob_type";
                MyOraDB.Parameter_Name[27] = "arg_upd_method";


                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }

                // 파라미터 값에 저장할 배열
                vList = new ArrayList();
                System.Data.DataTable dt_labor = arg_ds_value.Tables["Labor"];

                for (int labor_row = 0; labor_row < dt_labor.Rows.Count; labor_row++)
                {
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[0].ToString());  //"arg_factory";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[1].ToString());  //"arg_obs_id";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[2].ToString());  //"arg_obs_id";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[3].ToString());  //"arg_obs_id";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[4].ToString());  //"arg_obs_type";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[5].ToString().Replace("-", ""));  //"arg_style_cd";                    
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[6].ToString());  //"arg_class";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[7].ToString());  //"arg_sub_class";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[8].ToString());  //"arg_curr";                    
                    try
                    {
                        vList.Add(double.Parse(dt_labor.Rows[labor_row].ItemArray[9].ToString().Trim()).ToString("########0.##"));  //"arg_fx_rate";
                    }
                    catch
                    {
                        vList.Add("0");  //"arg_fx_rate";
                    }
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[10].ToString()); //"arg_process";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[11].ToString()); //"arg_direct_annual_wages";                    
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[12].ToString()); //"arg_direct_labor_worker";                    
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[13].ToString()); //"arg_day_paid_annualy";                   
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[14].ToString()); //"arg_minute_day_worker";                    
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[15].ToString()); //"arg_effctv_rate";                   
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[16].ToString()); //"arg_cost_std_minute";                    
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[17].ToString()); //"arg_std_minutes_pair";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[18].ToString()); //"arg_cost_pair_local";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[19].ToString()); //"arg_cost_pair_usd";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[20].ToString()); //"arg_ov_cost_pr";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[21].ToString()); //"arg_remarks";
                    vList.Add("N");                                               //"arg_status";
                    vList.Add(COM.ComVar.This_User);                              //"arg_upd_user";         

                    vList.Add(dt_labor.Rows[labor_row].ItemArray[24].ToString()); //"arg_mo_alias";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[25].ToString()); //"arg_bom_id";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[26].ToString()); //"arg_fob_type";
                    vList.Add(dt_labor.Rows[labor_row].ItemArray[27].ToString()); //"arg_upd_method";
                }

                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));
                MyOraDB.Add_Modify_Parameter(false);
                #endregion

                #region Overhead
                col_ct = 20;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_EBM_FOB_SAVE.INSERT_EBM_FOB_OVERHEAD";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_obs_id_01";
                MyOraDB.Parameter_Name[2] = "arg_obs_id_02";
                MyOraDB.Parameter_Name[3] = "arg_obs_id_03";
                MyOraDB.Parameter_Name[4] = "arg_obs_type";
                MyOraDB.Parameter_Name[5] = "arg_style_cd";
                MyOraDB.Parameter_Name[6] = "arg_class";
                MyOraDB.Parameter_Name[7] = "arg_sub_class";
                MyOraDB.Parameter_Name[8] = "arg_curr";
                MyOraDB.Parameter_Name[9] = "arg_fx_rate";
                MyOraDB.Parameter_Name[10] = "arg_item";
                MyOraDB.Parameter_Name[11] = "arg_local_cost";
                MyOraDB.Parameter_Name[12] = "arg_usd_cost";
                MyOraDB.Parameter_Name[13] = "arg_remarks";
                MyOraDB.Parameter_Name[14] = "arg_status";
                MyOraDB.Parameter_Name[15] = "arg_upd_user";

                MyOraDB.Parameter_Name[16] = "arg_mo_alias";
                MyOraDB.Parameter_Name[17] = "arg_bom_id";
                MyOraDB.Parameter_Name[18] = "arg_fob_type";
                MyOraDB.Parameter_Name[19] = "arg_upd_method";

                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }

                // 파라미터 값에 저장할 배열
                vList = new ArrayList();
                System.Data.DataTable dt_over = arg_ds_value.Tables[2];

                for (int over_row = 0; over_row < dt_over.Rows.Count; over_row++)
                {
                    vList.Add(dt_over.Rows[over_row].ItemArray[0].ToString());                   //"arg_factory";
                    vList.Add(dt_over.Rows[over_row].ItemArray[1].ToString());                   //"arg_obs_id";
                    vList.Add(dt_over.Rows[over_row].ItemArray[2].ToString());                   //"arg_obs_id";
                    vList.Add(dt_over.Rows[over_row].ItemArray[3].ToString());                   //"arg_obs_id";
                    vList.Add(dt_over.Rows[over_row].ItemArray[4].ToString());                   //"arg_obs_type";
                    vList.Add(dt_over.Rows[over_row].ItemArray[5].ToString().Replace("-", ""));  //"arg_style_cd";                    
                    vList.Add(dt_over.Rows[over_row].ItemArray[6].ToString());                   //"arg_class";
                    vList.Add(dt_over.Rows[over_row].ItemArray[7].ToString());                   //"arg_sub_class";
                    vList.Add(dt_over.Rows[over_row].ItemArray[8].ToString());                   //"arg_curr";
                    vList.Add(dt_over.Rows[over_row].ItemArray[9].ToString());                   //"arg_fx_rate";
                    vList.Add(dt_over.Rows[over_row].ItemArray[10].ToString());                  //"arg_item";
                    vList.Add(dt_over.Rows[over_row].ItemArray[11].ToString());                  //"arg_local_cost";
                    vList.Add(dt_over.Rows[over_row].ItemArray[12].ToString());                  //"arg_usd_cost";
                    vList.Add(dt_over.Rows[over_row].ItemArray[13].ToString());                  //"arg_remarks";
                    vList.Add("N");                                                              //"arg_status";
                    vList.Add(COM.ComVar.This_User);                                             //"arg_upd_user";  

                    vList.Add(dt_over.Rows[over_row].ItemArray[16].ToString());                  //"arg_mo_alias";
                    vList.Add(dt_over.Rows[over_row].ItemArray[17].ToString());                  //"arg_bom_id";
                    vList.Add(dt_over.Rows[over_row].ItemArray[18].ToString());                  //"arg_fob_type";
                    vList.Add(dt_over.Rows[over_row].ItemArray[19].ToString());                  //"arg_upd_method";
                }

                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));
                MyOraDB.Add_Modify_Parameter(false);
                #endregion

                #region Sample Mold
                col_ct = 27;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_EBM_FOB_SAVE.INSERT_EBM_FOB_MOLD";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_obs_id_01";
                MyOraDB.Parameter_Name[2] = "arg_obs_id_02";
                MyOraDB.Parameter_Name[3] = "arg_obs_id_03";
                MyOraDB.Parameter_Name[4] = "arg_obs_type";
                MyOraDB.Parameter_Name[5] = "arg_style_cd";
                MyOraDB.Parameter_Name[6] = "arg_class";
                MyOraDB.Parameter_Name[7] = "arg_mold_set";
                MyOraDB.Parameter_Name[8] = "arg_mold_type";
                MyOraDB.Parameter_Name[9] = "arg_mold_code";
                MyOraDB.Parameter_Name[10] = "arg_description";
                MyOraDB.Parameter_Name[11] = "arg_molds_no"; ;
                MyOraDB.Parameter_Name[12] = "arg_curr";
                MyOraDB.Parameter_Name[13] = "arg_fx_rate";
                MyOraDB.Parameter_Name[14] = "arg_mold_cost";
                MyOraDB.Parameter_Name[15] = "arg_total_cost";
                MyOraDB.Parameter_Name[16] = "arg_usd";
                MyOraDB.Parameter_Name[17] = "arg_amort_pairs";
                MyOraDB.Parameter_Name[18] = "arg_usd_pair";
                MyOraDB.Parameter_Name[19] = "arg_notes";
                MyOraDB.Parameter_Name[20] = "arg_remarks";
                MyOraDB.Parameter_Name[21] = "arg_status";
                MyOraDB.Parameter_Name[22] = "arg_upd_user";

                MyOraDB.Parameter_Name[23] = "arg_mo_alias";
                MyOraDB.Parameter_Name[24] = "arg_bom_id";
                MyOraDB.Parameter_Name[25] = "arg_fob_type";
                MyOraDB.Parameter_Name[26] = "arg_upd_method";

                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }

                // 파라미터 값에 저장할 배열
                vList = new ArrayList();
                System.Data.DataTable dt_sample = arg_ds_value.Tables["MOLD"];

                for (int sample_row = 0; sample_row < dt_sample.Rows.Count; sample_row++)
                {
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[0].ToString()); //"arg_factory";    
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[1].ToString()); //"arg_obs_id";     
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[2].ToString()); //"arg_obs_id";     
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[3].ToString()); //"arg_obs_id";     
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[4].ToString()); //"arg_obs_type";     
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[5].ToString().Replace("-", "")); //"arg_style_cd";                         
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[6].ToString()); //"arg_class";      
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[7].ToString()); //"arg_mold_set";   
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[8].ToString()); //"arg_mold_type";  
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[9].ToString());   //"arg_mold_code";  
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[10].ToString());  //"arg_description";
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[11].ToString());  //"arg_molds_no";   
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[12].ToString());  //"arg_curr";       
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[13].ToString());  //"arg_fx_rate";    
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[14].ToString());  //"arg_mold_cost";  
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[15].ToString());  //"arg_total_cost"; 
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[16].ToString());  //"arg_usd";        
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[17].ToString());  //"arg_amort_pairs";
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[18].ToString());  //"arg_usd_pair";   
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[19].ToString());  //"arg_notes";                    
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[20].ToString());  //"arg_remarks
                    vList.Add("N");                                                  //"arg_status
                    vList.Add(COM.ComVar.This_User);                                 //"arg_upd_user

                    vList.Add(dt_sample.Rows[sample_row].ItemArray[23].ToString());  //"arg_mo_alias
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[24].ToString());  //"arg_bom_id
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[25].ToString());  //"arg_fob_type
                    vList.Add(dt_sample.Rows[sample_row].ItemArray[26].ToString());  //"arg_upd_method
                }

                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));
                MyOraDB.Add_Modify_Parameter(false);
                #endregion   
             
                #region ETC
                col_ct = 23;

                MyOraDB.ReDim_Parameter(col_ct);
                MyOraDB.Process_Name = "PKG_EBM_FOB_SAVE.INSERT_EBM_FOB_ETC";

                // 파라미터 이름 설정
                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_obs_id_01";
                MyOraDB.Parameter_Name[2] = "arg_obs_id_02";
                MyOraDB.Parameter_Name[3] = "arg_obs_id_03";
                MyOraDB.Parameter_Name[4] = "arg_obs_type";
                MyOraDB.Parameter_Name[5] = "arg_style_cd";
                MyOraDB.Parameter_Name[6] = "arg_total_cost";
                MyOraDB.Parameter_Name[7] = "arg_profit";
                MyOraDB.Parameter_Name[8] = "arg_other_adjust";
                MyOraDB.Parameter_Name[9] = "arg_total_tooling";
                MyOraDB.Parameter_Name[10] = "arg_total_fob";
                MyOraDB.Parameter_Name[11] = "arg_lean_saving_target";
                MyOraDB.Parameter_Name[12] = "arg_labor_comments"; ;
                MyOraDB.Parameter_Name[13] = "arg_oh_comments";
                MyOraDB.Parameter_Name[14] = "arg_size_run";
                MyOraDB.Parameter_Name[15] = "arg_total_size_run";
                MyOraDB.Parameter_Name[16] = "arg_remarks";
                MyOraDB.Parameter_Name[17] = "arg_status";
                MyOraDB.Parameter_Name[18] = "arg_upd_user";

                MyOraDB.Parameter_Name[19] = "arg_mo_alias";
                MyOraDB.Parameter_Name[20] = "arg_bom_id";
                MyOraDB.Parameter_Name[21] = "arg_fob_type";
                MyOraDB.Parameter_Name[22] = "arg_upd_method";

                // 파라미터의 데이터 Type
                for (int i = 0; i < col_ct; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }

                // 파라미터 값에 저장할 배열
                vList = new ArrayList();
                System.Data.DataTable dt_etc = arg_ds_value.Tables["ETC"];

                for (int etc_row = 0; etc_row < dt_etc.Rows.Count; etc_row++)
                {
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[0].ToString());                    //"arg_factory";    
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[1].ToString());                    //"arg_obs_id";     
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[2].ToString());                    //"arg_obs_id";     
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[3].ToString());                    //"arg_obs_id";     
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[4].ToString());                    //"arg_obs_type";     
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[5].ToString().Replace("-", ""));   //"arg_style_cd"; 
                    vList.Add(StringToDouble(dt_etc.Rows[etc_row].ItemArray[6].ToString()).ToString());  //"arg_total_cost"; 
                    vList.Add(StringToDouble(dt_etc.Rows[etc_row].ItemArray[7].ToString()).ToString());  //"arg_profit"; 
                    vList.Add(StringToDouble(dt_etc.Rows[etc_row].ItemArray[8].ToString()).ToString());  //"arg_other_adjust";  
                    vList.Add(StringToDouble(dt_etc.Rows[etc_row].ItemArray[9].ToString()).ToString());  //"arg_total_tooling";  
                    vList.Add(StringToDouble(dt_etc.Rows[etc_row].ItemArray[10].ToString()).ToString()); //"arg_total_tooling";  
                    vList.Add(StringToDouble(dt_etc.Rows[etc_row].ItemArray[11].ToString()).ToString()); //"arg_lean_saving_target";
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[12].ToString());                   //"arg_labor_comments";   
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[13].ToString());                   //"arg_oh_comments"; 
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[14].ToString());                   //"arg_size_run";    
                    vList.Add(StringToDouble(dt_etc.Rows[etc_row].ItemArray[15].ToString()).ToString()); //"arg_total_size_run";  
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[16].ToString());                   //"arg_remarks
                    vList.Add("N");                                                             //"arg_status
                    vList.Add(COM.ComVar.This_User);                                            //"arg_upd_user

                    vList.Add(dt_etc.Rows[etc_row].ItemArray[19].ToString());                   //"arg_mo_alias
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[20].ToString());                   //"arg_bom_id
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[21].ToString());                   //"arg_fob_type
                    vList.Add(dt_etc.Rows[etc_row].ItemArray[22].ToString());                   //"arg_upd_method
                }
                
                MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));
                MyOraDB.Add_Modify_Parameter(false);
                #endregion

                #endregion

                DataSet vDS = MyOraDB.Exe_Modify_Procedure();
                if (vDS == null)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

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

        #region 조회 ( XML 용 )

        public System.Data.DataSet SELECT_EBM_FOB (
            string arg_factory, string arg_obs_id, string arg_obs_type, string arg_style,   // orignal table
            string arg_mo_alias, string arg_bom_id, string arg_fob_type,                    // new table 
            string arg_round )
        {
            try
            {
                MyOraDB.ReDim_Parameter(9);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_XML.SELECT_EBM_FOB";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                MyOraDB.Parameter_Name[3] = "ARG_STYLE";

                MyOraDB.Parameter_Name[4] = "ARG_MO_ALIAS";
                MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
                MyOraDB.Parameter_Name[6] = "ARG_FOB_TYPE";

                MyOraDB.Parameter_Name[7] = "ARG_ROUND";
                MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                int idx2 = 0;
                for (; idx2 < MyOraDB.Parameter_Name.Length - 1; idx2++)
                {
                    MyOraDB.Parameter_Type[idx2] = (int)OracleType.VarChar;
                }
                MyOraDB.Parameter_Type[idx2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_obs_id;
                MyOraDB.Parameter_Values[2] = arg_obs_type;
                MyOraDB.Parameter_Values[3] = arg_style;

                MyOraDB.Parameter_Values[4] = arg_mo_alias;
                MyOraDB.Parameter_Values[5] = arg_bom_id;
                MyOraDB.Parameter_Values[6] = arg_fob_type;

                MyOraDB.Parameter_Values[7] = arg_round;
                MyOraDB.Parameter_Values[8] = "";

                MyOraDB.Add_Select_Parameter(true);

                string[] procs = new string[] {
                        "PKG_EBM_FOB_XML.SELECT_EBM_FOB_UPPER", 
                        "PKG_EBM_FOB_XML.SELECT_EBM_FOB_PACKING", 
                        "PKG_EBM_FOB_XML.SELECT_EBM_FOB_MIDSOLE", 
                        "PKG_EBM_FOB_XML.SELECT_EBM_FOB_OUTSOLE", 
                        "PKG_EBM_FOB_XML.SELECT_EBM_FOB_LABOR", 
                        "PKG_EBM_FOB_XML.SELECT_EBM_FOB_OVERHEAD", 
                        "PKG_EBM_FOB_XML.SELECT_EBM_FOB_SAMPLE_MOLD", 
                        "PKG_EBM_FOB_XML.SELECT_EBM_FOB_PROD_MOLD", 
                        "PKG_EBM_FOB_XML.SELECT_EBM_FOB_5523", 
                        "PKG_EBM_FOB_XML.SELECT_EBM_FOB_MEOF", 
                        "PKG_EBM_FOB_XML.SELECT_EBM_FOB_MAX_COUNT"
                };

                return SELECT_EBM_FOB_DETAIL(
                    procs, arg_factory, arg_obs_id, arg_obs_type, arg_style, 
                    arg_mo_alias, arg_bom_id, arg_fob_type, arg_round );
            }
            catch
            {
                return null;
            }
        }

        private System.Data.DataSet SELECT_EBM_FOB_DETAIL(string[] arg_proc_names, 
            string arg_factory, string arg_obs_id, string arg_obs_type, string arg_style,   // orignal table
            string arg_mo_alias, string arg_bom_id, string arg_fob_type,                    // new table 
            string arg_round ) 
        {
            try
            {
                for (int idx = 0; idx < arg_proc_names.Length; idx++)
                {
                    MyOraDB.ReDim_Parameter(9);

                    //01.PROCEDURE명
                    MyOraDB.Process_Name = arg_proc_names[idx];

                    //02.ARGURMENT 명
                    MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                    MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                    MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                    MyOraDB.Parameter_Name[3] = "ARG_STYLE";

                    MyOraDB.Parameter_Name[4] = "ARG_MO_ALIAS";
                    MyOraDB.Parameter_Name[5] = "ARG_BOM_ID";
                    MyOraDB.Parameter_Name[6] = "ARG_FOB_TYPE";

                    MyOraDB.Parameter_Name[7] = "ARG_ROUND";
                    MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

                    //03.DATA TYPE 정의
                    int idx2 = 0;
                    for (; idx2 < MyOraDB.Parameter_Name.Length - 1; idx2++)
                    {
                        MyOraDB.Parameter_Type[idx2] = (int)OracleType.VarChar;
                    }
                    MyOraDB.Parameter_Type[idx2] = (int)OracleType.Cursor;

                    //04.DATA 정의
                    MyOraDB.Parameter_Values[0] = arg_factory;
                    MyOraDB.Parameter_Values[1] = arg_obs_id;
                    MyOraDB.Parameter_Values[2] = arg_obs_type;
                    MyOraDB.Parameter_Values[3] = arg_style;

                    MyOraDB.Parameter_Values[4] = arg_mo_alias;
                    MyOraDB.Parameter_Values[5] = arg_bom_id;
                    MyOraDB.Parameter_Values[6] = arg_fob_type;

                    MyOraDB.Parameter_Values[7] = arg_round;
                    MyOraDB.Parameter_Values[8] = "";

                    MyOraDB.Add_Select_Parameter(false);
                }

                //#region UPPER
                //MyOraDB.ReDim_Parameter(5);

                ////01.PROCEDURE명
                //MyOraDB.Process_Name = "PKG_EBM_FOB_XML.SELECT_EBM_FOB_UPPER";

                ////02.ARGURMENT 명
                //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                //MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                //MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                //MyOraDB.Parameter_Name[3] = "ARG_STYLE";


                //MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                ////03.DATA TYPE 정의
                //MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                ////04.DATA 정의
                //MyOraDB.Parameter_Values[0] = arg_factory;
                //MyOraDB.Parameter_Values[1] = arg_obs_id;
                //MyOraDB.Parameter_Values[2] = arg_obs_type;
                //MyOraDB.Parameter_Values[3] = arg_style;
                //MyOraDB.Parameter_Values[4] = "";

                //MyOraDB.Add_Select_Parameter(false);
                //#endregion


                //#region PACKING
                //MyOraDB.ReDim_Parameter(5);

                ////01.PROCEDURE명
                //MyOraDB.Process_Name = "PKG_EBM_FOB_XML.SELECT_EBM_FOB_PACKING";

                ////02.ARGURMENT 명
                //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                //MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                //MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                //MyOraDB.Parameter_Name[3] = "ARG_STYLE";
                //MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                ////03.DATA TYPE 정의
                //MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                ////04.DATA 정의
                //MyOraDB.Parameter_Values[0] = arg_factory;
                //MyOraDB.Parameter_Values[1] = arg_obs_id;
                //MyOraDB.Parameter_Values[2] = arg_obs_type;
                //MyOraDB.Parameter_Values[3] = arg_style;
                //MyOraDB.Parameter_Values[4] = "";

                //MyOraDB.Add_Select_Parameter(false);
                //#endregion


                //#region MIDSOLE + OUTSOLE
                //MyOraDB.ReDim_Parameter(5);

                ////01.PROCEDURE명
                //MyOraDB.Process_Name = "PKG_EBM_FOB_XML.SELECT_EBM_FOB_MIDSOLE";

                ////02.ARGURMENT 명
                //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                //MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                //MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                //MyOraDB.Parameter_Name[3] = "ARG_STYLE";
                //MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                ////03.DATA TYPE 정의
                //MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                ////04.DATA 정의
                //MyOraDB.Parameter_Values[0] = arg_factory;
                //MyOraDB.Parameter_Values[1] = arg_obs_id;
                //MyOraDB.Parameter_Values[2] = arg_obs_type;
                //MyOraDB.Parameter_Values[3] = arg_style;
                //MyOraDB.Parameter_Values[4] = "";

                //MyOraDB.Add_Select_Parameter(false);


                //MyOraDB.ReDim_Parameter(5);

                ////01.PROCEDURE명
                //MyOraDB.Process_Name = "PKG_EBM_FOB_XML.SELECT_EBM_FOB_OUTSOLE";

                ////02.ARGURMENT 명
                //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                //MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                //MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                //MyOraDB.Parameter_Name[3] = "ARG_STYLE";
                //MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                ////03.DATA TYPE 정의
                //MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                ////04.DATA 정의
                //MyOraDB.Parameter_Values[0] = arg_factory;
                //MyOraDB.Parameter_Values[1] = arg_obs_id;
                //MyOraDB.Parameter_Values[2] = arg_obs_type;
                //MyOraDB.Parameter_Values[3] = arg_style;
                //MyOraDB.Parameter_Values[4] = "";

                //MyOraDB.Add_Select_Parameter(false);
                //#endregion


                //#region LABOR
                //MyOraDB.ReDim_Parameter(5);

                ////01.PROCEDURE명
                //MyOraDB.Process_Name = "PKG_EBM_FOB_XML.SELECT_EBM_FOB_LABOR";

                ////02.ARGURMENT 명
                //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                //MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                //MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                //MyOraDB.Parameter_Name[3] = "ARG_STYLE";
                //MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                ////03.DATA TYPE 정의
                //MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                ////04.DATA 정의
                //MyOraDB.Parameter_Values[0] = arg_factory;
                //MyOraDB.Parameter_Values[1] = arg_obs_id;
                //MyOraDB.Parameter_Values[2] = arg_obs_type;
                //MyOraDB.Parameter_Values[3] = arg_style;
                //MyOraDB.Parameter_Values[4] = "";

                //MyOraDB.Add_Select_Parameter(false);
                //#endregion


                //#region OVERHEAD
                //MyOraDB.ReDim_Parameter(5);

                ////01.PROCEDURE명
                //MyOraDB.Process_Name = "PKG_EBM_FOB_XML.SELECT_EBM_FOB_OVERHEAD";

                ////02.ARGURMENT 명
                //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                //MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                //MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                //MyOraDB.Parameter_Name[3] = "ARG_STYLE";
                //MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                ////03.DATA TYPE 정의
                //MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                ////04.DATA 정의
                //MyOraDB.Parameter_Values[0] = arg_factory;
                //MyOraDB.Parameter_Values[1] = arg_obs_id;
                //MyOraDB.Parameter_Values[2] = arg_obs_type;
                //MyOraDB.Parameter_Values[3] = arg_style;
                //MyOraDB.Parameter_Values[4] = "";

                //MyOraDB.Add_Select_Parameter(false);
                //#endregion


                //#region MOLD
                //MyOraDB.ReDim_Parameter(5);

                ////01.PROCEDURE명
                //MyOraDB.Process_Name = "PKG_EBM_FOB_XML.SELECT_EBM_FOB_SAMPLE_MOLD";

                ////02.ARGURMENT 명
                //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                //MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                //MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                //MyOraDB.Parameter_Name[3] = "ARG_STYLE";
                //MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                ////03.DATA TYPE 정의
                //MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                ////04.DATA 정의
                //MyOraDB.Parameter_Values[0] = arg_factory;
                //MyOraDB.Parameter_Values[1] = arg_obs_id;
                //MyOraDB.Parameter_Values[2] = arg_obs_type;
                //MyOraDB.Parameter_Values[3] = arg_style;
                //MyOraDB.Parameter_Values[4] = "";

                //MyOraDB.Add_Select_Parameter(false);


                //MyOraDB.ReDim_Parameter(5);

                ////01.PROCEDURE명
                //MyOraDB.Process_Name = "PKG_EBM_FOB_XML.SELECT_EBM_FOB_PROD_MOLD";

                ////02.ARGURMENT 명
                //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                //MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                //MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                //MyOraDB.Parameter_Name[3] = "ARG_STYLE";
                //MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                ////03.DATA TYPE 정의
                //MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                ////04.DATA 정의
                //MyOraDB.Parameter_Values[0] = arg_factory;
                //MyOraDB.Parameter_Values[1] = arg_obs_id;
                //MyOraDB.Parameter_Values[2] = arg_obs_type;
                //MyOraDB.Parameter_Values[3] = arg_style;
                //MyOraDB.Parameter_Values[4] = "";

                //MyOraDB.Add_Select_Parameter(false);
                //#endregion

                //#region 5523
                //MyOraDB.ReDim_Parameter(5);

                ////01.PROCEDURE명
                //MyOraDB.Process_Name = "PKG_EBM_FOB_XML.SELECT_EBM_FOB_5523";

                ////02.ARGURMENT 명
                //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                //MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                //MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                //MyOraDB.Parameter_Name[3] = "ARG_STYLE";
                //MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                ////03.DATA TYPE 정의
                //MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                ////04.DATA 정의
                //MyOraDB.Parameter_Values[0] = arg_factory;
                //MyOraDB.Parameter_Values[1] = arg_obs_id;
                //MyOraDB.Parameter_Values[2] = arg_obs_type;
                //MyOraDB.Parameter_Values[3] = arg_style;
                //MyOraDB.Parameter_Values[4] = "";

                //MyOraDB.Add_Select_Parameter(false);
                //#endregion

                //#region MEOF
                //MyOraDB.ReDim_Parameter(5);

                ////01.PROCEDURE명
                //MyOraDB.Process_Name = "PKG_EBM_FOB_XML.SELECT_EBM_FOB_MEOF";

                ////02.ARGURMENT 명
                //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                //MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                //MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                //MyOraDB.Parameter_Name[3] = "ARG_STYLE";
                //MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                ////03.DATA TYPE 정의
                //MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                ////04.DATA 정의
                //MyOraDB.Parameter_Values[0] = arg_factory;
                //MyOraDB.Parameter_Values[1] = arg_obs_id;
                //MyOraDB.Parameter_Values[2] = arg_obs_type;
                //MyOraDB.Parameter_Values[3] = arg_style;
                //MyOraDB.Parameter_Values[4] = "";

                //MyOraDB.Add_Select_Parameter(false);
                //#endregion

                //#region Max count
                //MyOraDB.ReDim_Parameter(5);

                ////01.PROCEDURE명
                //MyOraDB.Process_Name = "PKG_EBM_FOB_XML.SELECT_EBM_FOB_MAX_COUNT";

                ////02.ARGURMENT 명
                //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                //MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
                //MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
                //MyOraDB.Parameter_Name[3] = "ARG_STYLE";
                //MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                ////03.DATA TYPE 정의
                //MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                ////04.DATA 정의
                //MyOraDB.Parameter_Values[0] = arg_factory;
                //MyOraDB.Parameter_Values[1] = arg_obs_id;
                //MyOraDB.Parameter_Values[2] = arg_obs_type;
                //MyOraDB.Parameter_Values[3] = arg_style;
                //MyOraDB.Parameter_Values[4] = "";

                //MyOraDB.Add_Select_Parameter(false);
                //#endregion

                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret;
            }
            catch
            {
                return null;
            }
        }

        #endregion

    }
}
