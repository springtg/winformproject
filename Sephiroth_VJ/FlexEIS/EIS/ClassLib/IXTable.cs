using System;

namespace FlexEIS.ClassLib
{

    #region Production

    #region Production Daily Report

    public enum TBEPM_PROD_DAILY_REPORT : int
    {
        IxMaxCt = 31,	// ÀÎµ¦½º Count
        IxLEVEL = 1, 	// Level : ()
        IxLINE_NAME = 2, 	// Line / Model : ()
        IxSTYLE_NAME = 3, 	// Model : ()
        IxOBS_TYPE = 4, 	// OBS Type : ()
        IxMAN_POWER = 5, 	// Man Power : ()
        IxPLAN_QTY = 6, 	// Plan : ()
        IxUPS_LINE = 7, 	// Line No# : ()
        IxUPS_OT = 8, 	// Over Time : ()
        IxUPS_QTY = 9, 	// Stitching : ()
        IxFSS_QTY = 10, 	// Stockfit : ()
        IxFGA_QTY = 11, 	// Lasting : ()
        IxFGA_OT = 12, 	// Over Time : ()
        IxPOD = 13, 	// POD : ()
        IxUNIT_PRICE = 14, 	// Unit Price : ()
        IxAVG_FOB = 15, 	// FOB : ()
        IxPROD_AMOUNT = 16, 	// Amount : ()
        IxSHIP_QTY = 17, 	// Q'ty : ()
        IxISSUED_CD = 18, 	// Code : ()
        IxISSUED_DESC = 19, 	// Description : ()
        IxPROBLEM_SOL = 20, 	// Problem Solving : ()
        IxPLAN_QTY_NEXT = 21, 	// Tomorrow : ()
        IxUPPER_INV = 22, 	// Upper : ()
        IxSOLE_INV = 23, 	// F/Sole : ()
        IxREMARKS = 24, 	// Remarks : ()
        IxOBS_ID = 25, 	// Id : ()
        IxFACTORY = 26, 	// Factory : ()
        IxPLAN_YMD = 27, 	// Plan Date : ()
        IxLINE_CD = 28, 	// Line Code : ()
        IxSTYLE_CD = 29, 	// Style Code : ()
        IxUPD_USER = 30, 	// Upd User : ()
        IxUPD_YMD = 31 	// Upd Date : ()
    }

    public enum TBEPM_PROD_DAILY_REPORT_SUM_VJ : int
    {
        lxMaxCt = 11,	            // ÀÎµ¦½º Count
        lxPLAN_QTY_TITLE = 1, 	    //   : ()
        lxPLAN_QTY_VALUE = 2, 	    //   : ()
        lxPLAN_AMOUNT_TITLE = 3, 	//   : ()
        lxPLAN_AMOUNT_VALUE = 4, 	//   : ()
        lxWORK_DAY_TITLE = 5,   	//   : ()
        lxWORK_DAY_VALUE = 6, 	    //   : ()
        lxWORK_DATE_TITLE = 7,  	//   : ()
        lxWORK_DATE_VALUE = 8,  	//   : ()
        lxWORK_SHIP_QTY = 9,  	    //   : ()
        lxSHIP_QTY_TITLE = 10, 	    //   : ()
        lxSHIP_QTY_VALUE = 11 	    //   : ()
    }

    public enum TBEPM_PROD_DAILY_REPORT_SUM_QD : int
    {
        IxMaxCt = 11,	            // ÀÎµ¦½º Count
        IxTITLE = 1, 	            //   : ()
        IxFGA_QTY_TITLE = 2, 	    //   : ()
        IxFGA_QTY_VALUE = 3, 	    //   : ()
        IxFGA_AMOUNT_TITLE = 4, 	//   : ()
        IxFGA_AMOUNT_VALUE = 5, 	//   : ()
        IxWORK_DAY_TITLE = 6, 	    //   : ()
        IxWORK_DAY_VALUE = 7, 	    //   : ()
        IxAVG_FGA_TITLE = 8, 	    //   : ()
        IxAVG_FGA_VALUE = 9, 	    //   : ()
        IxAVG_PRICE_TITLE = 10, 	//   : ()
        IxAVG_PRICE_VALUE = 11 	    //   : ()
    }


    public enum TBEPM_PROD_DAILY_TARGET : int
    {
        IxMaxCt = 3,	    // ÀÎµ¦½º Count
        IxLINE = 1, 	    //   : ()
        IxSTYLE_CD = 2,   	//   : ()
        IxTOTAL_QTY = 3,   	//   : ()
        IxPROD_RATE = 4   	//   : ()
    }

    #endregion

    #endregion

    #region Material Price

    #region Material Price - Common


    /// <summary>
    /// TBSBC_ITEM_GROUP : item group all search 위한 popup index
    /// </summary>
    public enum TBSBC_ITEM_GROUP : int
    {

        IxDIVISION = 0,
        IxGROUP_NAME = 1,
        IxGROUP_CD = 2,
        IxGROUP_LEVEL = 3,
        IxGROUP_TYPE = 4,
        IxGROUP_L = 5,
        IxGROUP_M = 6,
        IxGROUP_S = 7,
        IxATTRIBUTE_MODEL = 8,
        IxATTRIBUTE_STYLE = 9,
        IxATTRIBUTE_CMP = 10,
        IxATTRIBUTE_GENDER = 11,
        IxATTRIBUTE = 12,
        IxUSE_YN = 13,
        IxMAN_CHARGE_DS = 14,
        IxMAN_CHARGE_QD = 15,
        IxMAN_CHARGE_VJ = 16,
        IxVALIDATION_KEY_01 = 17,
        IxVALIDATION_VALUE_01 = 18,
        IxSEND_CHK = 19,
        IxSEND_YMD = 20,
        IxUPD_USER = 21,
    }


    #endregion

    #region MPS forecast


    /// <summary>
    /// TBEIS_MATPRICE_MPS_FORECAST : 
    /// </summary>
    public enum TBEIS_MATPRICE_MPS_FORECAST : int
    {

        IxLINE_GROUP = 1,
        IxLINE_GROUP_NAME = 2,
        IxLINE_CD = 3,
        IxLINE = 4,
        IxMPS_QTY = 5,
        IxFOB_AMOUNT = 6,
        IxSTANDARD_AMOUNT = 7,
        IxSTANDARD_RATIO = 8,
        IxCMP_CD_START = 9,


    }



    /// <summary>
    /// TBEIS_MATPRICE_MPS_FORECAST_TABLE : 
    /// </summary>
    public enum TBEIS_MATPRICE_MPS_FORECAST_TABLE : int
    {

        IxLINE_GROUP = 0,
        IxLINE_GROUP_NAME = 1,
        IxLINE_CD = 2,
        IxLINE = 3,
        IxMPS_QTY = 4,
        IxFOB_AMOUNT = 5,
        IxSTANDARD_AMOUNT = 6,
        IxSTANDARD_RATIO = 7,
        IxOP_GROUP = 8,
        IxOP_CD = 9,
        IxSTANDARD_OP_AMOUNT = 10,
        IxSTANDARD_OP_RATIO = 11,

    }




    /// <summary>
    /// TBEIS_MATPRICE_MPS_FORECAST_STYLE : 
    /// </summary>
    public enum TBEIS_MATPRICE_MPS_FORECAST_STYLE : int
    {

        IxLINE_GROUP = 1,
        IxLINE_GROUP_NAME = 2,
        IxLINE_CD = 3,
        IxLINE = 4,
        IxSTYLE_CD = 5,
        IxSTYLE_NAME = 6,
        IxOBS_ID = 7,
        IxOBS_TYPE = 8,
        IxFOB = 9,
        IxMPS_QTY = 10,
        IxFOB_AMOUNT = 11,
        IxSTANDARD_AMOUNT = 12,
        IxSTANDARD_RATIO = 13,
        IxCMP_CD_START = 14,


    }



    /// <summary>
    /// TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE : 
    /// </summary>
    public enum TBEIS_MATPRICE_MPS_FORECAST_STYLE_TABLE : int
    {

        IxLINE_GROUP = 0,
        IxLINE_GROUP_NAME = 1,
        IxLINE_CD = 2,
        IxLINE = 3,
        IxSTYLE_CD = 4,
        IxSTYLE_NAME = 5,
        IxOBS_ID = 6,
        IxOBS_TYPE = 7,
        IxFOB = 8,
        IxMPS_QTY = 9,
        IxFOB_AMOUNT = 10,
        IxSTANDARD_AMOUNT = 11,
        IxSTANDARD_RATIO = 12,
        IxOP_GROUP = 13,
        IxOP_CD = 14,
        IxSTANDARD_OP_AMOUNT = 15,
        IxSTANDARD_OP_RATIO = 16,

    }


    /// <summary>
    /// TBEIS_MATPRICE_MPS_FORECAST_ALL : 
    /// </summary>
    public enum TBEIS_MATPRICE_MPS_FORECAST_ALL : int
    {

        IxDISPLAY_DESC = 1,
        IxPLAN_YMD = 2,
        IxFACTORY = 3,
        IxDIV_ORDER = 4,
        IxDIV_DESC = 5,
        IxDEDUCTION_RATIO = 6,
        IxMPS_QTY = 7,
        IxSALE_AMOUNT = 8,
        IxFOB_AVERAGE = 9,
        IxSTANDARD_AMOUNT = 10,
        IxSTANDARD_RATIO = 11,
        IxLAST_UPD_YMD = 12,

    }



    #endregion

    #region Material Price Weekly




    /// <summary>
    /// TBEIS_MATPRICE_WEEKLY_RUN_AGAIN : 
    /// </summary>
    public enum TBEIS_MATPRICE_WEEKLY_RUN_AGAIN : int
    {


        IxPLAN_WEEK = 1,
        IxPLAN_WEEK_DESC = 2,
        IxFORECAST_YN = 3,
        IxSTATUS = 4,

    }






    /// <summary>
    /// TBEIS_MATPRICE_WEEKLY_DIV_FACTORY : 
    /// </summary>
    public enum TBEIS_MATPRICE_WEEKLY_DIV_FACTORY : int
    {


        IxFACTORY = 1,
        IxPLAN_MONTH = 2,
        IxPLAN_WEEK = 3,
        IxPLAN_WEEK_DESC = 4,
        IxLINE_GROUP_NAME = 5,
        IxLINE_NAME = 6,
        IxPRS_QTY = 7,
        IxSALE_AMOUNT = 8,
        IxAMOUNT_ADJUST = 9,
        IxAMOUNT_OUT_ALL = 10,
        IxAMOUNT_OUT_ALL_PROD_RATIO = 11,
        IxAMOUNT_OUT_ALL_LINE_RATIO = 12,
        IxAMOUNT_OUT_PROFIT_RATIO = 13,
        IxAMOUNT_OUT_NORMAL = 14,
        IxAMOUNT_OUT_NORMAL_RATIO = 15,
        IxAMOUNT_OUT_DEFECTIVE = 16,
        IxAMOUNT_OUT_DEFECTIVE_RATIO = 17,
        IxAMOUNT_OUT_OVERUSAGE = 18,
        IxAMOUNT_OUT_OVERUSAGE_RATIO = 19,
        IxAMOUNT_OUT_OTHER = 20,
        IxAMOUNT_OUT_OTHER_RATIO = 21,
        IxAMOUNT_OUT_OTHERS_ALL = 22,
        IxAMOUNT_OUT_OTHERS_ALL_RATIO = 23,
        IxFORECAST_YN = 24,




    }



    /// <summary>
    /// TBEIS_MATPRICE_WEEKLY_DIVISION : 
    /// </summary>
    public enum TBEIS_MATPRICE_WEEKLY_DIVISION : int
    {


        IxFACTORY = 1,
        IxPLAN_MONTH = 2,
        IxPLAN_WEEK = 3,
        IxPLAN_WEEK_DESC = 4,
        IxOUT_TYPE = 5,
        IxLINE_GROUP_NAME = 6,
        IxLINE_NAME = 7,
        IxSTYLE_CD = 8,
        IxSTYLE_NAME = 9,
        IxAMOUNT_ADJUST = 10,
        IxAMOUNT_OUT_ALL = 11,
        IxAMOUNT_OUT_PROFIT_RATIO = 12,
        IxAMOUNT_OUT_NORMAL = 13,
        IxAMOUNT_OUT_NORMAL_RATIO = 14,
        IxAMOUNT_OUT_DEFECTIVE = 15,
        IxAMOUNT_OUT_DEFECTIVE_RATIO = 16,
        IxAMOUNT_OUT_OVERUSAGE = 17,
        IxAMOUNT_OUT_OVERUSAGE_RATIO = 18,
        IxAMOUNT_OUT_OTHER = 19,
        IxAMOUNT_OUT_OTHER_RATIO = 20,
        IxFORECAST_YN = 21,



    }



    /// <summary>
    /// TBEIS_MATPRICE_WEEKLY_DIVISION_ITEM : 
    /// </summary>
    public enum TBEIS_MATPRICE_WEEKLY_DIVISION_ITEM : int
    {


        IxFACTORY = 1,
        IxPLAN_MONTH = 2,
        IxPLAN_WEEK = 3,
        IxPLAN_WEEK_DESC = 4,
        IxLINE_GROUP_NAME = 5,
        IxLINE_NAME = 6,
        IxSTYLE_CD = 7,
        IxSTYLE_NAME = 8,
        IxAMOUNT_OUT_PROFIT_RATIO_WEEK = 9,
        IxAMOUNT_OUT_PROFIT_RATIO_GROUP = 10,
        IxAMOUNT_OUT_PROFIT_RATIO_LINE = 11,
        IxAMOUNT_OUT_PROFIT_RATIO_STYLE = 12,
        IxAMOUNT_ADJUST_STYLE = 13,
        IxAMOUNT_OUT_ALL_STYLE = 14,
        IxIMPORT_DIV = 15,
        IxIMPORT_DIV_NAME = 16,
        IxITEM_NAME = 17,
        IxSPEC_NAME = 18,
        IxCOLOR_NAME = 19,
        IxUNIT = 20,
        IxPK_UNIT_QTY = 21,
        IxGROUP_CD = 22,
        IxITEM_GROUP = 23,
        IxFIRST_CLASS = 24,
        IxSECOND_CLASS = 25,
        IxSTYLE_ITEM_DIV = 26,
        IxOUT_TYPE = 27,
        IxAMOUNT_ADJUST = 28,
        IxAMOUNT_OUT_ALL = 29,
        IxAMOUNT_OUT_PROFIT_RATIO = 30,
        IxAMOUNT_OUT_NORMAL = 31,
        IxAMOUNT_OUT_NORMAL_RATIO = 32,
        IxAMOUNT_OUT_DEFECTIVE = 33,
        IxAMOUNT_OUT_DEFECTIVE_RATIO = 34,
        IxAMOUNT_OUT_OVERUSAGE = 35,
        IxAMOUNT_OUT_OVERUSAGE_RATIO = 36,
        IxAMOUNT_OUT_OTHER = 37,
        IxAMOUNT_OUT_OTHER_RATIO = 38,
        IxITEM_CD = 39,
        IxSPEC_CD = 40,
        IxCOLOR_CD = 41,



    }



    /// <summary>
    /// TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS : 
    /// </summary>
    public enum TBEIS_MATPRICE_WEEKLY_DIVISION_OTHERS : int
    {


        IxFACTORY = 1,
        IxPLAN_MONTH = 2,
        IxPLAN_WEEK = 3,
        IxPLAN_WEEK_DESC = 4,
        IxLINE_GROUP_NAME = 5,
        IxOUT_TYPE = 6,
        IxLINE_NAME = 7,
        IxOP_CD = 8,
        IxIMPORT_DIV = 9,
        IxIMPORT_DIV_NAME = 10,
        IxITEM_NAME = 11,
        IxSPEC_NAME = 12,
        IxCOLOR_NAME = 13,
        IxUNIT = 14,
        IxPK_UNIT_QTY = 15,
        IxGROUP_CD = 16,
        IxITEM_GROUP = 17,
        IxFIRST_CLASS = 18,
        IxSECOND_CLASS = 19,
        IxSTYLE_ITEM_DIV = 20,
        IxAMOUNT_ADJUST = 21,
        IxAMOUNT_OUT_ALL = 22,
        IxAMOUNT_OUT_NORMAL = 23,
        IxAMOUNT_OUT_NORMAL_RATIO = 24,
        IxAMOUNT_OUT_OTHERS_ALL = 25,
        IxAMOUNT_OUT_OTHERS_ALL_RATIO = 26,
        IxAMOUNT_OUT_DEFECTIVE = 27,
        IxAMOUNT_OUT_DEFECTIVE_RATIO = 28,
        IxAMOUNT_OUT_OVERUSAGE = 29,
        IxAMOUNT_OUT_OVERUSAGE_RATIO = 30,
        IxAMOUNT_OUT_OTHER = 31,
        IxAMOUNT_OUT_OTHER_RATIO = 32,
        IxITEM_CD = 33,
        IxSPEC_CD = 34,
        IxCOLOR_CD = 35,



    }





    #endregion


    #endregion 

}
