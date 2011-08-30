using System;

namespace FlexCDC.ClassLib
{
    #region Base Info
    public enum TBSXB_SRF_COLOR : int
    {
        IxMaxCt = 8,
        IxFACTORY = 1,
        IxLOAD_YMD = 2,
        IxCOLOR_CD = 3,
        IxCOLOR_DESC = 4,
        IxSTATUS = 5,
        IxUPD_USER = 6,
        IxUPD_YMD = 7,
        IxCHECK = 8
    }
    public enum TBSXB_SRF_STYLE : int
    {
        IxMaxCt = 11,
        IxFACTORY = 1,
        IxLOAD_YMD = 2,
        IxSRF_NO = 3,
        IxBOM_ID = 4,
        IxBOM_REV = 5,
        IxSTYLE_CD = 6,
        IxXDM_DIM_CD = 7,
        IxSTATUS = 8,
        IxUPD_USER = 9,
        IxUPD_YMD = 10,
        IxCHECK = 11
    }
    public enum TBSXB_SRF_MAT_TAIL : int
    {
        IIxMaxCt = 29,		// ÀÎµ¦½º Count 

        IxDIVISION = 0,
        IxFACTORY = 1,
        IxMAT_NUMBER = 2,
        IxMAT_NAME = 3,
        IxMAT_STATUE = 4,
        IxMAT_TYPE = 5,
        IxMAT_SUBTYPE = 6,
        IxMAT_VARIATION = 7,
        IxMAT_SUBVARIATION = 8,
        IxMAT_DESCRIPTION = 9,
        IxMXS_NUMBER = 10,
        IxMXS_NAME = 11,
        IxMXS_STATE = 12,
        IxMXS_MCS = 13,
        IxMXS_QUOTEDPRICE = 14,
        IxMXS_QUOTEDCURRENCY = 15,
        IxMXS_QUOTEDUOM = 16,
        IxMXS_DELIVERYTERM = 17,
        IxMXS_WIDTH = 18,
        IxMXS_WIDTHUOM = 19,
        IxMXS_LENGTH = 20,
        IxMXS_LENGTHUOM = 21,
        IxMXS_THICKNESS = 22,
        IxMXS_THICKNESSUOM = 23,
        IxMXS_LOCATIONCODE = 24,
        IxMXS_LOCATIONNAME = 25,
        IxNIKE_SUPPLIER_CODE = 26,
        IxUPD_USER = 27,
        IxUPD_YMD = 28,


    }  

    public enum TBSXD_SRF_M_MAT : int
    {
        IxMaxCt = 46,		     // ÀÎµ¦½º Count

        IxDIVISION = 0,
        IxFACTORY = 1,
        IxMAT_CD = 2,
        IxMAT_NAME = 3,
        IxMAT_COMMENT = 4,
        IxMAT_DESC = 5,
        IxMAT_NAME_KNAME = 6,
        IxMAT_TYPE = 7,
        IxMAT_SUBTYPE = 8,
        IxPUR_USER = 9,
        IxVENDOR_DESC = 10,
        IxPRICE_YN = 11,
        IxPUR_DIV = 12,
        IxPCC_UNIT_CD = 13,
        IxPCC_SPEC_CD = 14,
        IxSPEC_DESC = 15,
        IxPCC_LENGTH = 16,
        IxPCC_LENGTHUOM = 17,
        IxPCC_WIDTH = 18,
        IxPCC_WIDTHUOM = 19,
        IxPCC_QTYUOM = 20,
        IxYIELD_VALUE = 21,
        IxLOSS_VALUE = 22,
        IxCOMMON_YN = 23,
        IxMRP_YN = 24,
        IxPK_QTY = 25,
        IxSTYLE_ITEM_DIV = 26,
        IxPUR_PRICE = 27,
        IxPUR_CURRENCY = 28,
        IxCBD_PRICE = 29,
        IxCBD_CURRENCY = 30,
        IxLAMINATION_PRICE = 31,
        IxLAMINATION_CURRENCY = 32,
        IxVEN_SEQ = 33,
        IxDELIVERY_DAYS = 34,
        IxHS_NO = 35,
        IxCBM = 36,
        IxGROSS_WEIGHT = 37,
        IxNET_WEIGHT = 38,
        IxNIKE_FLG = 39,
        IxUSE_YN = 40,
        IxSEND_CHK = 41,
        IxSEND_YMD = 42,
        IxSTATUS = 43,
        IxUPD_USER = 44,
        IxUPD_YMD = 45,
    }
    public enum TBSXD_SRF_M_SPEC : int
    {
        IxMaxCt = 11,		     // ÀÎµ¦½º Count

        IxDIVISION = 0,
        IxFACTORY = 1,
        IxSPEC_CD = 2,
        IxSPEC_DESC = 3,
        IxUSE_YN = 4,
        IxSEND_CHK = 5,
        IxSEND_YMD = 6,
        IxSTATUS = 7,
        IxUPD_USER = 9,
        IxUPD_YMD = 10,
    }
    public enum TBSXD_SRF_M_COLOR : int
    {
        IxMaxCt = 13,		     // ÀÎµ¦½º Count

        IxDIVISION = 0,
        IxFACTORY = 1,
        IxCOLOR_CD = 2,
        IxCOLOR_DESC = 3,
        IxCOLOR_COMMENT = 4,
        IxCOLOR_DESC_KNAME = 5,
        IxNIKE_FLG = 6,
        IxUSE_YN = 7,
        IxSEND_CHK = 8,
        IxSEND_YMD = 9,
        IxSTATUS = 10,
        IxUPD_USER = 11,
        IxUPD_YMD = 12,
    }
    public enum TBSXD_SRF_M_PART : int
    {
        IxMaxCt = 14,		     // ÀÎµ¦½º Count

        IxDIVISION = 0,
        IxFACTORY = 1,
        IxPART_SEQ = 2,
        IxPART_NO = 3,
        IxPART_TYPE = 4,
        IxPART_DESC = 5,
        IxPART_COMMENT = 6,
        IxPART_DESC_KNAME = 7,
        IxUSE_YN = 8,
        IxSEND_CHK = 9,
        IxSEND_YMD = 10,
        IxSTATUS = 11,
        IxUPD_USER = 12,
        IxUPD_YMD = 13,

    }
    public enum TBSXD_SRF_M_MCS : int
    {
        IxMaxCt = 11,		     // ÀÎµ¦½º Count

        IxDIVISION = 0,
        IxFACTORY = 1,
        IxMCS_CD = 2,
        IxMCS_DESC = 3,
        IxUSE_YN = 4,
        IxSEND_CHK = 5,
        IxSEND_YMD = 6,
        IxSTATUS = 7,
        IxUPD_USER = 9,
        IxUPD_YMD = 10,
    }
    public enum TBSXD_SRF_M_VENDOR : int
    {
        IxMaxCt = 15,		     // ÀÎµ¦½º Count

        IxDIVISION = 0,
        IxFACTORY = 1,
        IxVEN_SEQ = 2,
        IxVENDOR_DESC = 3,
        IxPOPULA_NAME = 4,
        IxNIKE_FLG = 5,
        IxUSE_YN = 6,
        IxSTATUS = 7,
        IxCUST_CD = 8,
        IxCUST_NAME = 9,
        IxEMAIL = 10,
        lxCUST_WEB_ID = 11,
        lxCUST_WEB_PASS = 12,
        IxUPD_USER = 13,
        IxUPD_YMD = 14,

    }
    public enum TBSXD_SRF_M_CBD : int
    {
        IxMaxCt = 32,		     // ÀÎµ¦½º Count

        IxDIVISION = 0,
        IxFACTORY = 1,
        IxMAT_CD = 2,
        IxMAT_NAME = 3,
        IxPCC_SPEC_CD = 4,
        IxSPEC_DESC = 5,
        IxCOLOR_CD = 6,
        IxCOLOR_DESC = 7,
        IxPUR_USER = 8,
        IxPK_QTY = 9,
        IxPUR_CURRENCY = 10,
        IxPUR_PRICE = 11,
        IxOUTSIDE_CURRENCY = 12,
        IxOUTSIDE_PRICE = 13,
        IxCBD_CURRENCY = 14,
        IxCBD_PRICE = 15,
        IxSHIP_CURRENCY = 16,
        IxSHIP_PRICE = 17,
        IxLAMINATION_CURRENCY = 18,
        IxLAMINATION_PRICE = 19,
        IxVEN_SEQ = 20,
        IxVENDOR_DESC = 21,
        IxCBM = 22,
        IxGROSS_WEIGHT = 23,
        IxNET_WEIGHT = 24,
        IxNIKE_FLG = 25,
        IxUSE_YN = 26,
        IxSEND_CHK = 27,
        IxSEND_YMD = 28,
        IxSTATUS = 29,
        IxUPD_USER = 30,
        IxUPD_YMD = 31,

    }

    public enum SXD_MATERIAL_POP : int
    {
        lxMax = 18,

        lxFACTORY = 1,
        lxPART_SEQ = 2,
        lxPART_TYPE = 3,
        lxPART_DESC = 4,
        lxPART_QTY = 5,
        lxMAT_CD = 6,
        lxMAT_COMMENT = 7,
        lxMAT_NAME = 8,
        lxMAT_DESC = 9,
        lxMAT_YIELD = 10,
        lxCOLOR_CD = 11,
        lxCOLOR_DESC = 12,
        lxCOLOR_COMMENT = 13,
        lxSPEC_CD = 14,
        lxSPEC_NAME = 15,
        lxMCS_CD = 16,
        lxUNIT_CD = 17,
    }

    public enum TBSXF_CBD_M_FXRATE : int
    {
        IxMaxCt = 11,	        // 인덱스 Count
        IxSEASON_NAME = 1, 	    //   : ()
        IxCURR_NAME = 2, 	    //   : ()
        IxCOUNTRY_NAME = 3,     //   : ()
        IxFX_RATE = 4, 	        //   : ()
        IxSTATUS = 5, 	        //   : ()
        IxAPP_DATE = 6, 	    //   : ()
        IxFACTORY = 7, 	        //   : ()
        IxSEASON_CD = 8, 	    //   : ()
        IxCURR_CD = 9, 	        //   : ()
        IxUPD_USER = 10, 	    //   : ()
        IxUPD_YMD = 11 	        //   : ()
    }
    #endregion

    #region BOM

    #region New XML BOM Loading
    public enum TBSXD_SRF_TAIL_LOAD_NEW : int
    {
        IxMaxCt    = 29,	

        IxDIVISION = 0,

        IxFACTORY       = 1,
        IxSR_NO         = 2,
        IxSRF_NO        = 3,
        IxBOM_ID        = 4,
        IxBOM_REV       = 5,
        IxNF_CD         = 6,
        IxPART_NO       = 7,
        IxPART_TYPE     = 8,
        IxPART_NAME     = 9,
        IxPART_COMMENT  = 10,
        IxPART_QTY      = 11,
        IxMAT_CD        = 12,
        IxMAT_NAME      = 13,
        IxMAT_COMMENT   = 14,
        IxMAT_DESC      = 15,
        IxMAT_SIZE      = 16, 
        IxMAT_MIN       = 17,
        IXMAT_MAX       = 18,
        IxMAT_STATE     = 19,
        IxMAT_TYPE      = 20,
        IxCOLOR_CD      = 21,
        IxCOLOR_DESC    = 22,		
        IxCOLOR_COMMENT = 23,	
        IxMCS_CD        = 24,
        IxMXS_NUMBER    = 25,
        IxSTATUS        = 26,
        IxUPD_USER      = 27,
        IxUPD_YMD       = 28,
    }
    public enum TBSXD_SRF_ORDER_LOAD_NEW : int
    {
        IxMaxCt        = 24,		// ÀÎµ¦½º Count

        IxDIVISION     = 0,
        IxFACTORY      = 1,
        IxSR_NO        = 2,
        IxSRF_NO       = 3,
        IxBOM_ID       = 4,
        IxBOM_REV      = 5,
        IxNF_CD        = 6,
        IxSIZE_CD      = 7,
        IxORD_TYPE     = 8,
        IxSR_LINE_ITEM = 9,
        IxSIDE_TYPE    = 10,
        IxORD_QTY      = 11,
        IxREQUESTER    = 12,
        IxORD_YMD      = 13,
        IxNEED_BY      = 14,
        IxDESTINATION  = 15,
        IxGEN_CD       = 16,
        IxWIDTH        = 17,
        IxFIT          = 18,
        IxAGE          = 19,
        IxATTN         = 20,
        IxNIKE_FLG     = 21,
        IxSTATUS       = 22,
        IxUPD_USER     = 23,

    }
    public enum TBSXD_SRF_RULE_LOAD_NEW : int
    {
        IxMaxCt = 24,		// ÀÎµ¦½º Count
        IxDIVISION = 0,

        IxFACTORY        = 1,
        IxSR_NO          = 2,
        IxSRF_NO         = 3,
        IxBOM_ID         = 4,
        IxBOM_REV        = 5,
        IxNF_CD          = 6,
        IxRULE_TYPE      = 7,
        IxREGION         = 8,
        IxEXCLUSIVE_TYPE = 9,
        IxEXCLUSIVE_TO   = 10,        
        IxSTATUS         = 11,
        IxUPD_USER       = 12,
        IxUPD_YMD        = 13,

    }
    #endregion
        
    public enum TBSXD_SAVE_HEAD_MUTI : int
    {
        lxCHECK = 1,
        lxFACTORY = 2,
        lxSR_NO = 3,
        lxSRF_NO = 4,
        lxBOM_ID = 5,
        lxBOM_REV = 6,
        lxNF_CD = 7,
        lxSRF_SEQ = 8,
        lxBOM_SATATE = 9,
        lxREQUESTOR = 10,

        lxORD_YMD = 11,
        lxNEED_BY = 12,
        lxETS = 13,
        lxMO_ALIAS = 14,
        lxWHQ_PLM = 15,
        lxWHQ_DEV = 16,
        lxNLO_DEV = 17,
        lxSILHOUETTE = 18,
        lxTECHNOLOGY = 19,
        lxLASTING_ME = 20,

        lxMS_ME = 21,
        lxSOLE_LAYING = 22,
        lxMTO_ACC = 23,
        lxBOM_COMMENT = 24,
        lxFACTORY_DV = 25,
        lxSESN = 26,
        lxPATTERN = 27,
        lxLAST_CD = 28,
        lxDEV_NAME = 29,
        lxMTL_VER = 30,

        lxCOLOR_VER = 31,
        lxSAMPLE_TYPES = 32,
        lxSTA = 33,
        lxCURRENT_IPW = 34,
        lxPRODUCT_CODE = 35,
        lxPUR_FLG = 36,
        lxSTYLE_CD = 37,
        lxREMARKS = 38,
        lxSTATUS = 39,
        lxLOAD_UPD_USER = 40,

        lxLOAD_UPD_YMD = 41,
        lxUPD_USER = 42,

        lxPROD_EXT_COLOR = 43,
        lxPCC_FACTORY    = 44,
        lxSS_FACTORY  = 45,
        lxP_PROD_FACTORY = 46,
        lxS_PROD_FACTORY = 47,     



    }
    public enum TBSXD_SAVE_TAIL_MUTI : int
    {


        lxCHECK = 1,
        lxFACTORY = 2,
        lxSR_NO = 3,
        lxSRF_NO = 4,
        lxBOM_ID = 5,
        lxBOM_REV = 6,
        lxNF_CD = 7,
        lxSRF_SEQ = 8,
        lxSRF_SEQ_MAX = 9,
        lxSRF_LEVEL = 10,

        lxPUR_FLG = 11,
        lxPUR_FLG_DESC = 12,
        lxCHANGE_R_FLG = 13,
        lxCHANGE_R_FLG_DESC = 14,
        lxSTATUS = 15,
        lxSTATUS_DESC = 16,
        lxSORT_NO = 17,
        lxPART_SEQ = 18,
        lxPART_NO = 19,
        lxPART_TYPE = 20,

        lxPART_DESC = 21,
        lxPART_COMMENT = 22,
        lxPART_QTY = 23,
        lxMAT_CD = 24,
        lxMAT_NAME = 25,
        lxMAT_COMMENT = 26,
        lxMAT_DESC = 27,
        lxMCS_CD = 28,
        lxCOLOR_CD = 29,
        lxCOLOR_DESC = 30,

        lxCOLOR_COMMENT = 31,
        lxPCC_UNIT_CD = 32,
        lxPCC_SPEC_NAME = 33,
        lxPCC_SPEC_CD = 34,
        lxPCC_LENGTH = 35,
        lxPCC_LENGTHUOM = 36,
        lxPCC_WIDTH = 37,
        lxPCC_WIDTHUOM = 38,
        lxPCC_QTYUOM = 39,
        lxYIELD_VALUE = 40,

        lxLOSS_VALUE = 41,
        lxCOMMON_YN = 42,
        lxCBD_PRICE = 43,
        lxPUR_DIV = 44,
        lxVEN_SEQ = 45,
        lxPART_DESC_KNAME = 46,
        lxMAT_NAME_KNAME = 47,
        lxCOLOR_DESC_KNAME = 48,
        lxISKDESC = 49,
        lxAUTO_FLG = 50,

        lxREMARKS = 51,
        lxUPD_USER = 52,






    }
    public enum TBSXD_SAVE_ORDER_MUTI : int
    {
        lxCHECK = 1,
        lxFACTORY = 2,
        lxSR_NO = 3,
        lxSRF_NO = 4,
        lxBOM_ID = 5,
        lxBOM_REV = 6,
        lxNF_CD = 7,
        lxSRF_SEQ = 8,
        lxSRF_LEVEL = 9,
        lxPUR_FLG = 10,

        lxPUR_FLG_DESC = 11,
        lxCHANGE_R_FLG = 12,
        lxCHANGE_R_FLG_DESC = 13,
        lxSTATUS = 14,
        lxSTATUS_DESC = 15,
        lxSIZE_CD = 16,
        lxORD_TYPE = 17,
        lxSR_LINE_ITEM = 18,
        lxSIDE_TYPE = 19,
        lxORD_QTY = 20,

        lxREQUESTOR = 21,
        lxORD_YMD = 22,
        lxNEED_BY = 23,
        lxDESTINATION = 24,
        lxGEN_CD = 25,
        lxWIDTH = 26,
        lxFIT = 27,
        lxAGE = 28,
        lxATTN = 29,
        lxNIKE_FLG = 30,

        lxAUTO_FLG = 31,
        lxREMARKS = 32,
        lxUPD_USER = 33,
        //lxUPD_YMD				=34,


    }
    public enum TBSXD_CONFIRM_SRF : int
    {


        lxCHECK = 1,
        lxFACTORY = 2,
        lxSR_NO = 3,
        lxSRF_NO = 4,
        lxBOM_ID = 5,
        lxBOM_REV = 6,
        lxNF_CD = 7,
        lxSRF_SEQ = 8,
        lxBOM_SATATE = 9,
        lxREQUESTOR = 10,
        lxORD_YMD = 11,
        lxNEED_BY = 12,
        lxETS = 13,
        lxMO_ALIAS = 14,
        lxWHQ_PLM = 15,
        lxWHQ_DEV = 16,
        lxNLO_DEV = 17,
        lxSILHOUETTE = 18,
        lxTECHNOLOGY = 19,
        lxLASTING_ME = 20,
        lxMS_ME = 21,
        lxSOLE_LAYING = 22,
        lxMTO_ACC = 23,
        lxBOM_COMMENT = 24,
        lxFACTORY_DV = 25,
        lxSESN = 26,
        lxPATTERN = 27,
        lxLAST_CD = 28,
        lxDEV_NAME = 29,
        lxMTL_VER = 30,
        lxCOLOR_VER = 31,
        lxSAMPLE_TYPES = 32,
        lxSTA = 33,
        lxCURRENT_IPW = 34,
        lxPRODUCT_CODE = 35,
        lxPUR_FLG = 36,
        lxSTYLE_CD = 37,
        lxREMARKS = 38,
        lxSTATUS = 39,
        lxLOAD_UPD_USER = 40,
        lxLOAD_UPD_YMD = 41,
        lxUPD_USER = 42,
    }

    public enum TBSXD_SMF_XML : int
    {
        IxMax                = 15,

        lxDIVISION           = 0,
        lxXML_CREATE         = 1,
        lxSTATUS             = 2,
        lxSTATUS_DESC        = 3,
        lxLOAD_XML_FLAG      = 4,
        lxLOAD_XML_FLAG_DESC = 5,
        lxFACTORY            = 6,
        lxSTYLE_CD           = 7,
        lxNIKE_XDM_DIM_CD    = 8,
        lxMODEL_CD           = 9,
        lxSTYLE_NAME         = 10,
        lxSEASON_CD          = 11,
        lxGENDER             = 12,
        lxDEV_CD             = 13,
        lxJOB_COMPLETE       = 14,
    }
    public enum TBSXD_SMF_XML_TAIL : int
    {
        IxMax = 23,

        lxDIVISION         = 0,
        lxPCC_SEQ_NO       = 1,
        lxPCC_PART_NAME    = 2,
        lxITEM_CD          = 3,
        lxITEM_NAME        = 4,
        lxSPEC_CD          = 5,
        lxSPEC_NAME        = 6,
        lxCOLOR_CD         = 7,
        lxCOLOR_NAME       = 8,
        lxMNG_UNIT         = 9,
        lxPCC_YIELD        = 10,
        lxPCC_LOSS_PERCENT = 11,
        lxPCC_USAGE        = 12,
        lxPCC_UNIT         = 13,
        lxPCC_SPEC         = 14,
        lxPCC_SPECNAME     = 15,
        lxPCC_LENGTH       = 16,
        lxPCC_LENGTHUOM    = 17,
        lxPCC_WIDTH        = 18,
        lxPCC_WIDTHUOM     = 19,
        lxPCC_QTYUOM       = 20,
        lxUPD_USER         = 21,
        lxUPD_YMD          = 22,
    }
    public enum TBSXD_SMF_XML_CREATE : int
    {
        IxMax = 22,

        lxDIVISION                  = 0,
        lxPCC                       = 1,
        lxNIKE_SY_STY_NBR           = 2,
        lxNIKE_SY_COLR_CD_ID        = 3,
        lxNIKE_XDM_DIM_CD           = 4,
        lxNIKE_BOM_ID               = 5,
        lxNIKE_MODEL_OFFERING_ID    = 6,
        lxNIKE_MATERIAL_ID          = 7,
        lxNIKE_MATERIAL_BY_SUPPLIER = 8,
        lxNIKE_COLOR_CD             = 9,
        lxPCC_SEQ_NO                = 10,
        lxPCC_PART_NAME             = 11,
        lxPCC_YIELD                 = 12,
        lxPCC_LOSS_PERCENT          = 13,
        lxPCC_USAGE                 = 14,
        lxPCC_LENGTH                = 15,
        lxPCC_LENGTHUOM             = 16,
        lxPCC_WIDTH                 = 17,
        lxPCC_WIDTHUOM              = 18,
        lxPCC_QTYUOM                = 19,
        lxUPD_USER                  = 20,
        lxUPD_YMD                   = 21,

    } 
    public enum TBSXD_SRF_ORDER_MODIFY : int 
	{ 
		IxMaxCt = 35,		// ÀÎµ¦½º Count 

		
		IxDIVISION         = 0,
		IxCHECK           = 1,
		IxFACTORY =2,			// °øÀåÄÚµå	:VARCHAR2(5) 
		IxSR_NO =3,			// SR_NO	:VARCHAR2(10) 
		IxSRF_NO =4,			// SRF_NO	:VARCHAR2(20) 
		IxBOM_ID =5,			// BOM_ID	:VARCHAR2(17) 
		IxBOM_REV =6,			// BOM_REV	:VARCHAR2(5) 
		IxNF_CD =7,			// NF_CD	:VARCHAR2(5) 
		IxSRF_SEQ =8,			// SRF_SEQ	:VARCHAR2(3) 
		IxSRF_LEVEL =9,			// SRF_SEQ	:VARCHAR2(3) 
		IxPUR_FLG =10,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
		IxPUR_FLG_DESC =11,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
		IxCHANGE_R_FLG =12,			// ·¹ÄÚµå¼öÁ¤»óÅÂ	:VARCHAR2(1) 
		IxCHANGE_R_FLG_DESC =13,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
		IxSTATUS =14,			// »óÅÂ	:VARCHAR2(1)
		IxSTATUS_DESC = 15, 
		IxSIZE_CD =16,			// »çÀÌÁîÄÚµå	:VARCHAR2(50)  
		IxORD_TYPE =17,			// ORD_TYPE	:VARCHAR2(50) 
		IxSR_LINE_ITEM =18,			// SR_LINE_ITEM	:VARCHAR2(50) 
		IxSIDE_TYPE =19,			// SIDE_TYPE	:VARCHAR2(50)
		IxORD_QTY =20,			// ORD_QTY	:NUMBER(22) 
		IxREQUESTOR =21,			// REQUESTOR	:VARCHAR2(50) 
		IxORD_YMD =22,			// ORD_YMD	:VARCHAR2(50) 
		IxNEED_BY =23,			// NEED_BY	:VARCHAR2(50) 
		IxDESTINATION =24,			// DESTINATION	:VARCHAR2(300) 
		IxGEN_CD =25,			// Á¨´õÄÚµå	:VARCHAR2(50) 
		IxWIDTH =26,			// WIDTH	:VARCHAR2(50) 
		IxFIT =27,			// FIT	:VARCHAR2(50) 
		IxAGE =28,			// AGE	:VARCHAR2(50) 
		IxATTN =29,			// ATTN	:VARCHAR2(50) 
		IxNIKE_FLG =30,			// NIKE_FLG	:VARCHAR2(1) 
		IxAUTO_FLG =31,			// AUTO_FLG	:VARCHAR2(1) 
		IxREMARKS =32,			// ºñ°í	:VARCHAR2(500) 
		IxUPD_USER =33,			// ÀÛ¼ºÀÚ	:VARCHAR2(30) 
		IxUPD_YMD =34,			// ÀÛ¼ºÀÏ	:DATE(7) 
	}
	public enum TBSXD_SRF_HEAD_MODIFY : int 
	{
		IxMaxCt               = 37,

		IxDIVISION            = 0,
		IxCHECK               = 1,
		IxFACTORY             = 2,	
		IxSR_NO               = 3,        
		IxSRF_SEQ             = 4,    
		IxSRF_NO              = 5,      
		IxBOM_ID              = 6,
		IxNF_CD               = 7,        
		IxSAMPLE_TYPES        = 8, 
		IxDEV_NAME            = 9,   
		IxMO_ALIAS            = 10,    
		IxFACTORY_DV          = 11,  
		IxSTA                 = 12,
		IxREQUESTOR           = 13,     
		IxORD_YMD             = 14,      
		IxNEED_BY             = 15,    
		IxETS                 = 16,         
		IxPATTERN             = 17,     
		IxSTYLE_CD            = 18,
		IxSILHOUETTE          = 19,   
		IxTECHNOLOGY          = 20,   
		IxLASTING_ME          = 21, 
		IxMS_ME               = 22,       
		IxSOLE_LAYING         = 23, 
		IxLAST_CD             = 24,
		IxPRODUCT_CODE        = 25, 
		IxCURRENT_IPW         = 26,  
		IxSESN                = 27,       
		IxMTO_ACC             = 28,     
		IxWHQ_PLM             = 29,     
		IxWHQ_DEV             = 30,
		IxNLO_DEV             = 31,      
		IxMTL_VER             = 32,      
		IxCOLOR_VER           = 33, 
		IxBOM_COMMENT         = 34, 
		IxUPD_USER            = 35,     
		IxUPD_YMD             = 36,

	}
	public enum TBSXD_SRF_TAIL_MODIFY : int 
	{ 
		IxMaxCt               = 54,		// ÀÎµ¦½º Count
		IxDIVISION            = 0,
		IxCHECK               = 1,
		IxFACTORY             = 2,			// °øÀåÄÚµå	:VARCHAR2(5) 
		IxSR_NO               = 3,			// SR_NO	:VARCHAR2(10) 
		IxSRF_NO              = 4,			// SRF_NO	:VARCHAR2(20) 
		IxBOM_ID              = 5,			// BOM_ID	:VARCHAR2(17) 
		IxBOM_REV             = 6,			// BOM_REV	:VARCHAR2(5) 
		IxNF_CD               = 7,			// NF_CD	:VARCHAR2(5) 
		IxSRF_SEQ             = 8,			// SRF_SEQ	:VARCHAR2(3) 		
		IxSRF_SEQ_MAX         = 9,			// SRF_SEQ_MAX	:VARCHAR2(3) 
		IxSRF_LEVEL           = 10,			// SRF_SEQ_MAX	:VARCHAR2(3) 
		IxPUR_FLG             = 11,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
		IxPUR_FLG_DESC        = 12,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
		IxCHANGE_R_FLG        = 13,			// ·¹ÄÚµå¼öÁ¤»óÅÂ	:VARCHAR2(1) 
		IxCHANGE_R_FLG_DESC   = 14,			// ·¹ÄÚµå¼öÁ¤»óÅÂ	:VARCHAR2(1) 
		IxSTATUS =15,			// »óÅÂ	:VARCHAR2(1) 
		IxSTATUS_DESC =16,			// »óÅÂ	:VARCHAR2(1) 
		IxSORT_NO =17,			// SORT_NO	:NUMBER(22) 		
		IxPART_SEQ =18,			// PART_SEQ	:NUMBER(22) 
		IxPART_NO =19,			// PART_NO	:VARCHAR2(50) 
		IxPART_TYPE =20,			// PART_TYPE	:VARCHAR2(50) 
		IxPART_DESC =21,			// PART_DESC	:VARCHAR2(200) 
		IxPART_COMMENT =22,			// PART_COMMENT	:VARCHAR2(500) 
		IxPART_QTY =23,			// PART_QTY	:NUMBER(22) 
		IxMAT_CD =24,			// Ç°¸ñÄÚµå	:VARCHAR2(50) 
		IxMAT_NAME =25,			// MAT_NAME	:VARCHAR2(1024) 
		IxMAT_COMMENT =26,			// MAT_COMMENT	:VARCHAR2(500) 
		IxMAT_DESC =27,			// MAT_DESC	:VARCHAR2(1024) 
		IxMCS_CD =28,			// MCS_CD	:VARCHAR2(50) 
		IxCOLOR_CD =29,			// COLOR_CD	:VARCHAR2(50) 
		IxCOLOR_DESC =30,			// COLOR_DESC	:VARCHAR2(200) 
		IxCOLOR_COMMENT =31,			// COLOR_COMMENT	:VARCHAR2(200) 
		IxPCC_UNIT_CD =32,			// PCC_UNIT_CD	:VARCHAR2(50) 
		IxPCC_SPEC_NAME =33,			// PCC_SPEC_CD	:VARCHAR2(50) 
		IxPCC_SPEC_CD =34,			// PCC_SPEC_CD	:VARCHAR2(50) 		
		IxPCC_LENGTH =35,			// PCC_LENGTH	:NUMBER(22) 
		IxPCC_LENGTHUOM =36,			// PCC_LENGTHUOM	:VARCHAR2(50) 
		IxPCC_WIDTH =37,			// PCC_WIDTH	:NUMBER(22) 
		IxPCC_WIDTHUOM =38,			// PCC_WIDTHUOM	:VARCHAR2(50) 
		IxPCC_QTYUOM =39,			// PCC_QTYUOM	:VARCHAR2(50) 
		IxYIELD_VALUE =40,			// ´ëÇ¥Ã¤»ê°ª	:NUMBER(22) 
		IxLOSS_VALUE =41,			// LOSS_VALUE	:NUMBER(22) 
		IxCOMMON_YN =42,			// ¼öÀÔÀÚÀçÀ¯¹«	:VARCHAR2(1) 
		IxCBD_PRICE =43,			// ÀÓ°¡°øÀ¯¹«	:VARCHAR2(1) 
		IxPUR_DIV =44,			// MAT_DIV	:VARCHAR2(2) 
		IxVEN_SEQ =45,			// VEN_SEQ	:NUMBER(22) 
		IxPART_DESC_KNAME =46,			// PART_DESC_KNAME	:VARCHAR2(200) 
		IxMAT_NAME_KNAME =47,    // MAT_NAME_KNAME	:VARCHAR2(200) 
		IxCOLOR_DESC_KNAME =48,			// COLOR_DESC_KNAME	:VARCHAR2(200)
		IxISKNAME =49,			// COLOR_DESC_KNAME	:VARCHAR2(200) 
		IxAUTO_FLG =50,			// AUTO_FLG	:VARCHAR2(1) 
		IxREMARKS =51,			// ºñ°í	:VARCHAR2(500) 
		IxUPD_USER =52,			// ÀÛ¼ºÀÚ	:VARCHAR2(30) 
		IxUPD_YMD =53,			// ÀÛ¼ºÀÏ	:DATE(7) 
    }
    public enum TBSXD_MATERIAL_LIST : int
    {
        IxDIVISION    = 0,
        IxLEVEL       = 1,

        IxFACTORY     = 2,
        IxPUR_DIV     = 3,
        IxCATEGORY_H = 4,
        IxSEASON_H   = 5,
        IxMAT_NAME    = 6,
        IxMAT_CD      = 7,
        IxMAT_COMMENT = 8,
        IxPCC_SPEC_CD = 9,
        IxCOLOR_CD    = 10,
        
        IxCAT_SESN    = 11,        
        IxITEM_01     = 12,
        IxITEM_02     = 13,
        IxITEM_03     = 14,
        IxITEM_04     = 15,
        IxPCC_UNIT_CD = 16,
        IxMCS_CD      = 17,        
        IxYIELD_VALUE = 18,
        IxLOSS_VALUE  = 19,
        IxCOMMON_YN   = 20,
        IxPUR_FLG     = 21,
        IXPUR_DIV_T   = 22,
    }

    #region by ½ÂÇö
    public enum TBSXE_RECV_LOT : int
    {
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxSRF_NO = 2,
        IxBOM_ID = 3,
        IxBOM_REV = 4,
        IxNF_CD = 5,
        IxNF_NAME = 6,
        IxS_FACTORY = 7,
        IxS_SR_NO = 8,
        IxS_SRF_NO = 9,
        IxS_BOM_ID = 10,
        IxS_BOM_REV = 11,
        IxS_NF_CD = 12,
        IxCATEGORY = 13,
        IxCATEGORY_NAME = 14,
        IxSEASON_CD = 15,
        IxSEASON_NAME = 16,
        IxSTYLE_CD = 17,
        IxSTYLE_NAME = 18,
        IxCOLOR_VER = 19,
        IxORD_YMD = 20,
        IxNEED_BY = 21,
        IxETS = 22,
        IxSIZE_CD = 23,
        IxLOT_QTY = 24,
        IxLOSS_QTY = 25,
        IxWHQ_PLM = 26,
        IxWHQ_DEV = 27,
        IxNLO_DEV = 28,
        IxCDC_DEV = 29,
        IxCDC_DEV_SABUN = 30,
        IxCDC_DEV_NAME = 31,

        IxLOAD_UPD_USER = 32,

    }

    public enum TBSPB_CMP : int
    {
        IxMaxCt = 9,		// ÀÎµ¦½º Count 
        IxFACTORY = 1,			// °øÀå	:VARCHAR2(5) 
        IxCMP_CD = 2,			// Ç°¸ñ ÄÚµå	:VARCHAR2(10) 
        IxCMP_NAME = 3,			// Ç°¸ñ¸í	:VARCHAR2(60) 
        IxCMP_UNIT = 4,			// Ç°¸ñ ´ÜÀ§	:VARCHAR2(5) 
        IxCMP_DIV = 5,			// Ç°¸ñ °èÁ¤ (¿¹ : ¿ÏÁ¦, ¹ÝÁ¦, COMPONENT µî)	:VARCHAR2(20) 
        IxAVAIL_YMD = 6,			// À¯È¿±â°£	:VARCHAR2(8) 
        IxREMARKS = 7,			// ºñ°í	:VARCHAR2(100) 
        IxUPD_USER = 8,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 9,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
    }

    public enum TBSPB_ROUT_BOM : int
    {
        IxMaxCt = 17,		// ÀÎµ¦½º Count 
        IxFACTORY = 1,			// °øÀå	:VARCHAR2(5) 
        IxBOM_CD = 2,			// BOM ÄÚµå	:VARCHAR2(10) 
        IxCMP_CD = 3,			// Ç°¸ñ (¹ÝÁ¦) ÄÚµå	:VARCHAR2(10) 
        IxROUT_TYPE = 4,			// ¶ó¿ìÆÃ Å¸ÀÔ (¿¹ : ´ëÇü¶óÀÎ ¶ó¿ìÆÃ, NOS¶ó¿ìÆÃ, NIC ¶ó¿ìÆÃ µî)	:VARCHAR2(5) 
        IxROUT_SEQ = 5,			// °øÁ¤¼ø¹ø	:VARCHAR2(3) 
        IxCMP_NAME = 6,			// Ç°¸ñ (¹ÝÁ¦) ¸í	:VARCHAR2(50) 
        IxUP_CMP_CD = 7,			// »óÀ§ Ç°¸ñ (¹ÝÁ¦) ÄÚµå	:VARCHAR2(10) 
        IxCMP_TYPE = 8,			// Ç°¸ñ (¹ÝÁ¦)  Å¸ÀÔ	:VARCHAR2(5) 
        IxCMP_LEVEL = 9,			// Ç°¸ñ (¹ÝÁ¦) ·¹º§	:VARCHAR2(5) 
        IxCMP_ORD = 10,			// Ç°¸ñ (¹ÝÁ¦) ¼ø¼­	:VARCHAR2(5) 
        IxOP_CD = 11,			// °øÁ¤ÄÚµå	:VARCHAR2(10) 
        IxOP_TYPE = 12,			// °øÁ¤ Å¸ÀÔ : ¶ó¿ìÆÃ ¿¬°áÀ» À§ÇÑ ÇÊµå	:VARCHAR2(10) 
        IxOP_GROUP = 13,			// °øÁ¤ ±×·ì : ¶ó¿ìÆÃ ¿¬°áÀ» À§ÇÑ ÇÊµå	:VARCHAR2(10) 
        IxOP_LEVEL = 14,			// °øÁ¤ ·¹º§ : ½ÃÀÛÀº 1, ¼øÂ÷ÀûÀ¸·Î 1·¹º§¾¿ Áõ°¡ÇÑ´Ù.	:VARCHAR2(5) 
        IxREMARKS = 15,			// ºñ°í	:VARCHAR2(100) 
        IxUPD_USER = 16,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 17,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)

        IxH_ROUT_SEQ = 18,
        IxNODE_NO = 19,          // ±×·ÁÁö´Â ³ëµå ¼ø¹ø
        IxOP_NAME = 20,

    }

    public enum TBSPB_ROUT : int
    {
        IxMaxCt = 30,  //29,		// ÀÎµ¦½º Count 
        IxFACTORY = 1,			// °øÀå	:VARCHAR2(5) 
        IxCMP_CD = 2,			// Ç°¸ñ (¹ÝÁ¦) ÄÚµå	:VARCHAR2(10) 
        IxROUT_TYPE = 3,			// ¶ó¿ìÆÃ Å¸ÀÔ (¿¹ : ´ëÇü¶óÀÎ ¶ó¿ìÆÃ, NOS¶ó¿ìÆÃ, NIC ¶ó¿ìÆÃ µî)	:VARCHAR2(5) 
        IxROUT_SEQ = 4,			// °øÁ¤ ¼ø¹ø	:VARCHAR2(3) 
        IxROUT_NAME = 5,			// ¶ó¿ìÆÃ¸í	:VARCHAR2(50) 
        IxOP_CD = 6,			// °øÁ¤ÄÚµå	:VARCHAR2(10) 
        IxOP_TYPE = 7,			// °øÁ¤ Å¸ÀÔ : ¶ó¿ìÆÃ ¿¬°áÀ» À§ÇÑ ÇÊµå	:VARCHAR2(10) 
        IxOP_GROUP = 8,			// °øÁ¤ ±×·ì : ¶ó¿ìÆÃ ¿¬°áÀ» À§ÇÑ ÇÊµå	:VARCHAR2(10) 
        IxBEFORE_OPCD = 9,			// ¼±°øÁ¤	:VARCHAR2(100) 
        IxNEXT_OPCD = 10,			// ÈÄ°øÁ¤	:VARCHAR2(100) 
        IxOP_LEVEL = 11,			// °øÁ¤ ·¹º§ : ½ÃÀÛÀº 1, ¼øÂ÷ÀûÀ¸·Î 1·¹º§¾¿ Áõ°¡ÇÑ´Ù. °øÁ¤ seq¿Í 10ÀÇ ¹è¼öÀÇ °ü°è¿¡ ÀÖ´Ù	:VARCHAR2(5) 
        IxOP_FIRST_YN = 12,			// Ç°¸ñ Ã¹°øÁ¤ ¿©ºÎ	:VARCHAR2(1) 
        IxOP_LAST_YN = 13,			// Ç°¸ñ ³¡°øÁ¤ ¿©ºÎ	:VARCHAR2(1) 
        IxMULTI_IN_YN = 14,			// ¸ÖÆ¼ IN ¿©ºÎ	:VARCHAR2(1) 
        IxMULTI_OUT_YN = 15,			// ¸ÖÆ¼ OUT ¿©ºÎ	:VARCHAR2(1) 
        IxFB_YN = 16,			// ÇÇµå¹é ¿©ºÎ	:VARCHAR2(1) 
        IxFB_IN_YN = 17,			// ÇÇµå¹é IN ¿©ºÎ	:VARCHAR2(1) 
        IxFB_OUT_IN = 18,			// ÇÇµå¹é OUT ¿©ºÎ	:VARCHAR2(1) 
        IxFB_MULTI_IN_YN = 19,			// ÇÇµå¹é ¸ÖÆ¼ IN ¿©ºÎ	:VARCHAR2(1) 
        IxFB_MULTI_OUT_YN = 20,			// ÇÇµå¹é ¸ÖÆ¼ OUT ¿©ºÎ	:VARCHAR2(1) 
        IxFB_BEFORE_OPCD = 21,			// ÇÇµå¹é ¼±°øÁ¤	:VARCHAR2(100) 
        IxFB_NEXT_OPCD = 22,			// ÇÇµå¹é ÈÄ°øÁ¤	:VARCHAR2(100) 
        IxCOMPONENT_YN = 23,			// ÀÏºÎ»ý»ê ¿©ºÎ	:VARCHAR2(1) 
        IxSETUP_TIME = 24,			// ÁØºñ½Ã°£	:VARCHAR2(9) 
        IxOVER_TYPE = 25,			// ¿À¹ö·¦ Å¸ÀÔ (¿¹ : SSEE, SESE)	:VARCHAR2(4) 
        IxOVER_TIME = 26,			// ¿À¹ö·¦ ¸®µåÅ¸ÀÓ	:VARCHAR2(9) 
        IxREMARKS = 27,			// ºñ°í	:VARCHAR2(100)
        IxH_ROUT_SEQ = 28,      // Å°°¡ µÇ´Â ¼ø¹ø
        IxUPD_USER = 29,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 30,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 

        IxNODE_NO = 31,         // ±×·ÁÁö´Â ³ëµå ¼ø¹ø 
    }

    public enum TBSPB_NODE_OPDEF : int
    {
        IxMaxCt = 24,		// ÀÎµ¦½º Count 
        IxFACTORY = 1,			// °øÀå	:VARCHAR2(5) 
        IxOP_TYPE = 2,			// °øÁ¤ ºÐ·ù (¿¹ : °¡»ó°øÁ¤, Á¶¸³°øÁ¤, ¿ÜÁÖ°øÁ¤, COMPONENT °øÁ¤ µî)	:VARCHAR2(10) 
        IxOP_TYPE_NAME = 3,			// °øÁ¤ ºÐ·ù¸í	:VARCHAR2(50) 
        IxPHANTOM_YN = 4,			// °¡»óÅ¸ÀÔ ¿©ºÎ	:VARCHAR2(1) 
        IxALIGNMENT = 5,			// ÅØ½ºÆ® Á¤·Ä ¹æ½Ä	:VARCHAR2(10) 
        IxDASHSTYLE = 6,			// ³ëµå Å×µÎ¸® ½ºÅ¸ÀÏ	:VARCHAR2(10) 
        IxDRAWCOLOR = 7,			// ³ëµå Å×µÎ¸® »ö±ò	:VARCHAR2(10) 
        IxDRAWWIDTH = 8,			// ³ëµå Å×µÎ¸® ¼± µÎ²²	:VARCHAR2(10) 
        IxFILLCOLOR = 9,			// ³ëµå Ã¤¿ì±â »ö±ò	:VARCHAR2(10) 
        IxFONT = 10,			// ÅØ½ºÆ® ÆùÆ® ¼Ó¼º	:VARCHAR2(60) 
        IxGRADI_YN = 11,			// GRADIANT ¿©ºÎ	:VARCHAR2(1) 
        IxGRADICOLOR = 12,			// GRADIANT »ö±ò	:VARCHAR2(10) 
        IxGRADIMODE = 13,			// GRADIANT ¸ðµå (½ºÅ¸ÀÏ)	:VARCHAR2(10) 
        IxHEIGHT = 14,			// ³ëµå ³ôÀÌ	:VARCHAR2(10) 
        IxSHADOW = 15,			// ³ëµå ±×¸²ÀÚ Ç¥½Ã ¼Ó¼º	:VARCHAR2(60) 
        IxSHAPE = 16,			// ³ëµå Å×µÎ¸® ¸ð¾ç ¼Ó¼º	:VARCHAR2(60) 
        IxTAG = 17,			// ÅÂ±× ¼Ó¼º	:VARCHAR2(60) 
        IxTEXT = 18,			// ÅØ½ºÆ®	:VARCHAR2(60) 
        IxTEXTCOLOR = 19,			// ÅØ½ºÆ® Ç¥½Ã »ö±ò	:VARCHAR2(10) 
        IxTOOLTIP = 20,			// ÅøÆÁ	:VARCHAR2(60) 
        IxWIDTH = 21,			// ³ëµå ³Êºñ	:VARCHAR2(10) 
        IxREMARKS = 22,			// ºñ°í	:VARCHAR2(100) 
        IxUPD_USER = 23,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 24,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
    }

    public enum TBSPB_OPCD_INDETAIL : int
    {
        IxFACTORY = 0,
        IxPARENT_CMP = 1,
        IxPARENT_OPCD = 2,
        IxOP_CD = 3,
        IxAREA_CD = 4,
        IxOP_NAME = 5,
        IxOP_TYPE = 6,
        IxDEPT_CD = 7,
        IxOP_COLOR = 8,
        IxREAL_YN = 9,
        IxCAPA_YN = 10,
        IxMOLD_YN = 11,
        IxOUT_YN = 12,
        IxJOB_YN = 13,
        IxPCARD_YN = 14,
        IxRST_YN = 15,
        IxJIT_YN = 16,
        IxIN_DETAIL_YN = 17,
        IxMOLD_TYPE = 18,
        IxDIR_MARGIN = 19,
        IxREMARKS = 20,
        IxUPD_USER = 21,
        IxUPD_YMD = 22,
        IxOP_LEVEL = 23,
        IxDETAIL_OPCD = 24,
        IxH_OP_CD = 25,
    }

    public enum TBSPB_OPCD_GRID : int
    {
        IxFACTORY = 1,			// °øÀå	:VARCHAR2(5) 
        IxSG_CMP_CD = 2,			// °øÁ¤ÀÇ »óÀ§ ±×·ì Ç°¸ñ ÄÚµå	:VARCHAR2(10) 
        IxOP_CD = 3,			// °øÁ¤ ÄÚµå	:VARCHAR2(10)  
        IxAREA_CD = 4,			// Ç¥ÁØ ÀÛ¾÷Àå ÄÚµå	:VARCHAR2(10) 
        IxOP_NAME = 5,			// °øÁ¤¸í	:VARCHAR2(50) 
        IxOP_TYPE = 6,			// °øÁ¤ ºÐ·ù ÄÚµå	:VARCHAR2(10) 
        IxDEPT_CD = 7,			// °øÁ¤ ºÎ¼­ ÄÚµå	:VARCHAR2(6) 
        IxOP_COLOR = 8,			// °øÁ¤ »ö±ò	:VARCHAR2(10) 
        IxREAL_YN = 9,			// ½Ç°øÁ¤ ¿©ºÎ	:VARCHAR2(1) 
        IxCAPA_YN = 10,			// CAPACITY ºÐ¼® °øÁ¤ ¿©ºÎ	:VARCHAR2(1) 
        IxMOLD_YN = 11,			// ¸ôµå °øÁ¤ ¿©ºÎ	:VARCHAR2(1) 
        IxOUT_YN = 12,			// ¿ÜÁÖ ¿©ºÎ	:VARCHAR2(1) 
        IxJOB_YN = 13,			// ÀÛ¾÷Áö½Ã ¿©ºÎ	:VARCHAR2(1) 
        IxPCARD_YN = 14,			// ÆÐ½ºÄ«µå ¿©ºÎ	:VARCHAR2(1) 
        IxRST_YN = 15,			// ½ÇÀû ¿©ºÎ	:VARCHAR2(1) 
        IxMAT_AREA_YN = 16,			// JIT ¿©ºÎ	:VARCHAR2(1) 
        IxIN_DETAIL_YN = 17,
        IxMOLD_TYPE = 18,			// ¸ôµå Å¸ÀÔ : MOLE_YN = Y ÀÎ °æ¿ì¿¡ ¼±ÅÃ	:VARCHAR2(2)
        IxDIR_MARGIN = 19,
        IxDISPLAY_YN = 20,
        IxUSE_YN = 21,
        IxREMARKS = 22,			// ºñ°í	:VARCHAR2(100) 
        IxUPD_USER = 23,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 24,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)  
        IxOP_LEVEL = 25,
        IxDETAIL_OPCD = 26,
        IxH_OP_CD = 27,
    }

    public enum TBSPB_OPCD_LINE_HEAD : int
    {
        IxMaxCt = 5,		// ÀÎµ¦½º Count 
        IxOP_CD = 1,			// °øÁ¤ ÄÚµå	:VARCHAR2(10) 
        IxAREA_CD = 2,			// Ç¥ÁØ ÀÛ¾÷Àå ÄÚµå	:VARCHAR2(10) 
        IxOP_NAME = 3,			// °øÁ¤¸í	:VARCHAR2(50) 
        IxREMARKS = 4,			// ºñ°í	:VARCHAR2(100) 
        IxCOUNT = 5,
        IxDIV = 6,              // 1: spb_opcd, 2 : spb_opcd_indetail
        IxPARENT_OPCD = 7,

    }
    
    public enum TBSPB_OPCD : int
    {
        IxFACTORY = 0,			// °øÀå	:VARCHAR2(5) 
        IxSG_CMP_CD = 1,			// °øÁ¤ÀÇ »óÀ§ ±×·ì Ç°¸ñ ÄÚµå	:VARCHAR2(10) 
        IxOP_CD = 2,			// °øÁ¤ ÄÚµå	:VARCHAR2(10) 
        IxAREA_CD = 3,			// Ç¥ÁØ ÀÛ¾÷Àå ÄÚµå	:VARCHAR2(10) 
        IxOP_NAME = 4,			// °øÁ¤¸í	:VARCHAR2(50) 
        IxOP_TYPE = 5,			// °øÁ¤ ºÐ·ù ÄÚµå	:VARCHAR2(10) 
        IxDEPT_CD = 6,			// °øÁ¤ ºÎ¼­ ÄÚµå	:VARCHAR2(6) 
        IxOP_COLOR = 7,			// °øÁ¤ »ö±ò	:VARCHAR2(10) 
        IxREAL_YN = 8,			// ½Ç°øÁ¤ ¿©ºÎ	:VARCHAR2(1) 
        IxCAPA_YN = 9,			// CAPACITY ºÐ¼® °øÁ¤ ¿©ºÎ	:VARCHAR2(1) 
        IxMOLD_YN = 10,			// ¸ôµå °øÁ¤ ¿©ºÎ	:VARCHAR2(1) 
        IxOUT_YN = 11,			// ¿ÜÁÖ ¿©ºÎ	:VARCHAR2(1) 
        IxJOB_YN = 12,			// ÀÛ¾÷Áö½Ã ¿©ºÎ	:VARCHAR2(1) 
        IxPCARD_YN = 13,			// ÆÐ½ºÄ«µå ¿©ºÎ	:VARCHAR2(1) 
        IxRST_YN = 14,			// ½ÇÀû ¿©ºÎ	:VARCHAR2(1) 
        IxMAT_AREA_YN = 15,			// JIT ¿©ºÎ	:VARCHAR2(1) 
        IxIN_DETAIL_YN = 16,
        IxMOLD_TYPE = 17,			// ¸ôµå Å¸ÀÔ : MOLE_YN = Y ÀÎ °æ¿ì¿¡ ¼±ÅÃ	:VARCHAR2(2)
        IxDIR_MARGIN = 18,
        IxDISPLAY_YN = 19,
        IxUSE_YN = 20,
        IxREMARKS = 21,			// ºñ°í	:VARCHAR2(100) 
        IxUPD_USER = 22,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 23,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)  
        IxOP_LEVEL = 24,
        IxDETAIL_OPCD = 25,
        IxH_OP_CD = 26,
    }

    public enum TBSPB_LINK_ROUT : int
    {
        IxMaxCt = 18, //23,		// ÀÎµ¦½º Count 
        //		IxFACTORY =1,			// °øÀå	:VARCHAR2(5) 
        //		IxCMP_CD =2,			// Ç°¸ñ (¹ÝÁ¦) ÄÚµå	:VARCHAR2(10) 
        //		IxROUT_TYPE =3,			// ¶ó¿ìÆÃ Å¸ÀÔ	:VARCHAR2(5) 
        //		IxLINK_SEQ =4,			// ¸µÅ©¼ø¹ø	:VARCHAR2(5) 
        IxORG_NODE = 1,			// ¸µÅ©ÇÒ ORIGIN NODE	:VARCHAR2(10) 
        IxDST_NODE = 2,			// ¸µÅ©ÇÒ DESTINATION NODE	:VARCHAR2(10) 
        //		IxPOINT =3,			// ¸µÅ© ÁÂÇ¥Á¡	:VARCHAR2(60) 
        IxARROW_DST = 3,			// ¸µÅ© ³¡ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxARROW_MID = 4,			// ¸µÅ© ²ªÀÎÁ¡ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxARROW_ORG = 5,			// ¸µÅ© Ã¹ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxDASHSTYLE = 6,			// ¸µÅ© ¼± ½ºÅ¸ÀÏ	:VARCHAR2(10) 
        IxDRAWCOLOR = 7,			// ¸µÅ© ¼± »ö±ò	:VARCHAR2(10) 
        IxDRAWWIDTH = 8,			// ¸µÅ© ¼± µÎ²²	:VARCHAR2(10) 
        IxFONT = 9,			// ¸µÅ© À§ ÅØ½ºÆ® ÆùÆ® ¼Ó¼º	:VARCHAR2(60) 
        IxJUMP = 10,			// JUMP ¼Ó¼º	:VARCHAR2(10) 
        IxLINE_STYLE = 11,			// ¶óÀÎ ½ºÅ¸ÀÏ (¿¹ : °î¼±, Á÷¼± µî)	:VARCHAR2(10) 
        IxLINE_ROUND = 12,			// ¶óÀÎ ¶ó¿îµå ¼Ó¼º : ¸µÅ© ²ªÀÎÁ¡ ºÎºÐ ¶ó¿îµå Ã³¸® ¿©ºÎ	:VARCHAR2(10) 
        IxTAG = 13,			// ÅÂ±× ¼Ó¼º	:VARCHAR2(60) 
        IxTEXT = 14,			// ÅØ½ºÆ®	:VARCHAR2(60) 
        IxTEXTCOLOR = 15,			// ÅØ½ºÆ® »ö±ò	:VARCHAR2(10) 
        IxTOOLTIP = 16,			// ÅøÆÁ	:VARCHAR2(60) 
        IxUPD_USER = 17,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 18,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
    }
    
    public enum TBSPB_NODE_ROUT : int
    {
        IxMaxCt = 23,  //26,		// ÀÎµ¦½º Count 
        //		IxFACTORY =1,			// °øÀå	:VARCHAR2(5) 
        //		IxCMP_CD =2,			// Ç°¸ñ (¹ÝÁ¦) ÄÚµå	:VARCHAR2(10) 
        //		IxROUT_TYPE =3,			// ¶ó¿ìÆÃ Å¸ÀÔ (¿¹ : ´ëÇü¶óÀÎ ¶ó¿ìÆÃ, NOS¶ó¿ìÆÃ, NIC ¶ó¿ìÆÃ µî)	:VARCHAR2(5) 
        IxROUT_SEQ = 1,			// °øÁ¤¼ø¹ø	:VARCHAR2(3) 
        IxNODE_CD = 2,			// ³ëµåÄÚµå : °øÀåÄÚµå + BOM ÄÚµå + Seq(4)	:VARCHAR2(30) 
        IxLEFT = 3,			// ³ëµå ¿ÞÂÊ ÁÂÇ¥	:VARCHAR2(10) 
        IxTOP = 4,			// ³ëµå À§ ÁÂÇ¥	:VARCHAR2(10) 
        IxALIGNMENT = 5,			// ÅØ½ºÆ® Á¤·Ä ¹æ½Ä	:VARCHAR2(10) 
        IxDASHSTYLE = 6,			// ³ëµå Å×µÎ¸® ½ºÅ¸ÀÏ	:VARCHAR2(10) 
        IxDRAWCOLOR = 7,			// ³ëµå Å×µÎ¸® »ö±ò	:VARCHAR2(10) 
        IxDRAWWIDTH = 8,			// ³ëµå Å×µÎ¸® ¼± µÎ²²	:VARCHAR2(10) 
        IxFILLCOLOR = 9,			// ³ëµå Ã¤¿ì±â »ö±ò	:VARCHAR2(10) 
        IxFONT = 10,			// ÅØ½ºÆ® ÆùÆ® ¼Ó¼º	:VARCHAR2(60) 
        IxGRADI_YN = 11,			// GRADIANT ¿©ºÎ	:VARCHAR2(1) 
        IxGRADICOLOR = 12,			// GRADIANT »ö±ò	:VARCHAR2(10) 
        IxGRADIMODE = 13,			// GRADIANT ¸ðµå (½ºÅ¸ÀÏ)	:VARCHAR2(10) 
        IxHEIGHT = 14,			// ³ëµå ³ôÀÌ	:VARCHAR2(10) 
        IxSHADOW = 15,			// ³ëµå ±×¸²ÀÚ Ç¥½Ã ¼Ó¼º	:VARCHAR2(60) 
        IxSHAPE = 16,			// ³ëµå Å×µÎ¸® ¸ð¾ç ¼Ó¼º	:VARCHAR2(60) 
        IxTAG = 17,			// ÅÂ±× ¼Ó¼º	:VARCHAR2(60) 
        IxTEXT = 18,			// ÅØ½ºÆ®	:VARCHAR2(60) 
        IxTEXTCOLOR = 19,			// ÅØ½ºÆ® Ç¥½Ã »ö±ò	:VARCHAR2(10) 
        IxTOOLTIP = 20,			// ÅøÆÁ	:VARCHAR2(60) 
        IxWIDTH = 21,			// ³ëµå ³Êºñ	:VARCHAR2(10) 
        IxUPD_USER = 22,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 23,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
    }

    public enum TBSPB_BOM_CD : int
    {
        IxMaxCt = 13,		// ÀÎµ¦½º Count 
        IxFACTORY = 1,			// °øÀå	:VARCHAR2(5) 
        IxBOM_CD = 2,			// BOM ÄÚµå	:VARCHAR2(10) 
        IxBOM_DESC = 3,			// BOM ÄÚµå ¼³¸í	:VARCHAR2(60) 
        IxJOB_CD = 4,			// ¾÷¹«ÄÚµå	:VARCHAR2(10) 
        IxMODEL_CD = 5,			// ¸ðµ¨ÄÚµå	:VARCHAR2(6) 
        IxSTYLE_CD = 6,			// ½ºÅ¸ÀÏ ÄÚµå	:VARCHAR2(9) 
        IxLINE_CD = 7,			// ¶óÀÎ ÄÚµå	:VARCHAR2(3) 
        IxLINK_TYPE = 8,			// ¸µÅ© Å¸ÀÔ : ¶ó¿ìÆÃ ¼Ó¼º Á¤ÀÇ (AddFlow ¿¡¼­ Link ¼Ó¼º Á¤ÀÇ) ¿¡¼­ BOM ¿¬°á Å¸ÀÔ ¼±ÅÃ	:VARCHAR2(10) 
        IxDEFAULT_YN = 9,			// °øÀåÀÇ DEFAULT BOM ¿©ºÎ	:VARCHAR2(1)
        IxORD = 10,
        IxREMARKS = 11,			// ºñ°í	:VARCHAR2(100) 
        IxUPD_USER = 12,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 13,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
    }

    public enum TBSPB_NODE_DEF : int
    {
        IxMaxCt = 24,		// ÀÎµ¦½º Count 
        IxFACTORY = 1,			// °øÀå	:VARCHAR2(5) 
        IxCMP_TYPE = 2,			// BOM CMP ºÐ·ùÄÚµå : SG(SemiGood), TP(Type), GP(Group), BM(Base Mat.)	:VARCHAR2(10) 
        IxTYPE_NAME = 3,			// BOM CMP ºÐ·ù ÄÚµå¸í	:VARCHAR2(60) 
        IxPHANTOM_YN = 4,			// °¡»óÅ¸ÀÔ ¿©ºÎ	:VARCHAR2(1) 
        IxALIGNMENT = 5,			// ÅØ½ºÆ® Á¤·Ä ¹æ½Ä	:VARCHAR2(10) 
        IxDASHSTYLE = 6,			// ³ëµå Å×µÎ¸® ½ºÅ¸ÀÏ	:VARCHAR2(10) 
        IxDRAWCOLOR = 7,			// ³ëµå Å×µÎ¸® »ö±ò	:VARCHAR2(10) 
        IxDRAWWIDTH = 8,			// ³ëµå Å×µÎ¸® ¼± µÎ²²	:VARCHAR2(10) 
        IxFILLCOLOR = 9,			// ³ëµå Ã¤¿ì±â »ö±ò	:VARCHAR2(10) 
        IxFONT = 10,			// ÅØ½ºÆ® ÆùÆ® ¼Ó¼º	:VARCHAR2(60) 
        IxGRADI_YN = 11,			// GRADIANT ¿©ºÎ	:VARCHAR2(1) 
        IxGRADICOLOR = 12,			// GRADIANT »ö±ò	:VARCHAR2(10) 
        IxGRADIMODE = 13,			// GRADIANT ¸ðµå (½ºÅ¸ÀÏ)	:VARCHAR2(10) 
        IxHEIGHT = 14,			// ³ëµå ³ôÀÌ	:VARCHAR2(10) 
        IxSHADOW = 15,			// ³ëµå ±×¸²ÀÚ Ç¥½Ã ¼Ó¼º	:VARCHAR2(60) 
        IxSHAPE = 16,			// ³ëµå Å×µÎ¸® ¸ð¾ç ¼Ó¼º	:VARCHAR2(60) 
        IxTAG = 17,			// ÅÂ±× ¼Ó¼º	:VARCHAR2(60) 
        IxTEXT = 18,			// ÅØ½ºÆ®	:VARCHAR2(60) 
        IxTEXTCOLOR = 19,			// ÅØ½ºÆ® Ç¥½Ã »ö±ò	:VARCHAR2(10) 
        IxTOOLTIP = 20,			// ÅøÆÁ	:VARCHAR2(60) 
        IxWIDTH = 21,			// ³ëµå ³Êºñ	:VARCHAR2(10) 
        IxREMARKS = 22,			// ºñ°í	:VARCHAR2(100) 
        IxUPD_USER = 23,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 24,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
    }

    public enum TBSPB_LINK_DEF : int
    {
        IxMaxCt = 19,		// ÀÎµ¦½º Count 
        IxFACTORY = 1,			// °øÀå	:VARCHAR2(5) 
        IxLINK_TYPE = 2,			// ¸µÅ© ¼Ó¼º ÄÚµå : BOM, ROUTING µîÀÇ ±¸ºÐ ÄÚµå	:VARCHAR2(10) 
        IxARROW_DST = 3,			// ¸µÅ© ³¡ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxARROW_MID = 4,			// ¸µÅ© ²ªÀÎÁ¡ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxARROW_ORG = 5,			// ¸µÅ© Ã¹ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxDASHSTYLE = 6,			// ¸µÅ© ¼± ½ºÅ¸ÀÏ	:VARCHAR2(10) 
        IxDRAWCOLOR = 7,			// ¸µÅ© ¼± »ö±ò	:VARCHAR2(10) 
        IxDRAWWIDTH = 8,			// ¸µÅ© ¼± µÎ²²	:VARCHAR2(10) 
        IxFONT = 9,			// ¸µÅ© À§ ÅØ½ºÆ® ÆùÆ® ¼Ó¼º	:VARCHAR2(60) 
        IxJUMP = 10,			// JUMP ¼Ó¼º	:VARCHAR2(10) 
        IxLINE_STYLE = 11,			// ¶óÀÎ ½ºÅ¸ÀÏ (¿¹ : °î¼±, Á÷¼± µî)	:VARCHAR2(10) 
        IxLINE_ROUND = 12,			// ¶óÀÎ ¶ó¿îµå ¼Ó¼º : ¸µÅ© ²ªÀÎÁ¡ ºÎºÐ ¶ó¿îµå Ã³¸® ¿©ºÎ	:VARCHAR2(10) 
        IxTAG = 13,			// ÅÂ±× ¼Ó¼º	:VARCHAR2(60) 
        IxTEXT = 14,			// ÅØ½ºÆ®	:VARCHAR2(60) 
        IxTEXTCOLOR = 15,			// ÅØ½ºÆ® »ö±ò	:VARCHAR2(10) 
        IxTOOLTIP = 16,			// ÅøÆÁ	:VARCHAR2(60) 
        IxREMARKS = 17,			// ºñ°í	:VARCHAR2(100) 
        IxUPD_USER = 18,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 19,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
    }

    public enum TBSPB_BOM : int
    {
        IxMaxCt = 10,		// ÀÎµ¦½º Count  
        IxCMP_TYPE = 1,			// Ç°¸ñ (¹ÝÁ¦) Å¸ÀÔ	:VARCHAR2(5) 
        IxCMP_CD = 2,			// Ç°¸ñ (¹ÝÁ¦) ÄÚµå	:VARCHAR2(10) 
        IxUP_CMP_CD = 3,			// »óÀ§ Ç°¸ñ (¹ÝÁ¦) ÄÚµå	:VARCHAR2(10) 
        IxCMP_NAME = 4,			// Ç°¸ñ (¹ÝÁ¦) ¸í	:VARCHAR2(60) 
        IxCMP_LEVEL = 5,			// Ç°¸ñ (¹ÝÁ¦) ·¹º§	:VARCHAR2(5) 
        IxCMP_ORD = 6,			// Ç°¸ñ (¹ÝÁ¦) ¼ø¼­ : µ¿µî·¹º§¿¡¼­ÀÇ ¼ø¼­	:VARCHAR2(5) 
        IxLEAFCMP_LEVEL = 7,		// ÃÖÇÏÀ§ Ç°¸ñ ·¹º§ : µ¿ÀÏÇ°¸ñ¿¡ ÇÑÇÏ¿© ÃÖÇÏÀ§ Ç°¸ñ ·¹º§À» ¼³Á¤ÇÑ´Ù   (ÀÚµ¿µî·Ï)	:VARCHAR2(5) 
        IxAVAIL_YMD = 8,			// À¯È¿±â°£	:VARCHAR2(8) 
        IxREMARKS = 9,			// ºñ°í	:VARCHAR2(100) 
        IxROUT_YN = 10,
    }
   
    public enum TBSXO_REQ_TAIL01 : int
    {
        IxMaxCt = 19,		// ÀÎµ¦½º Count 
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxREQ_YMD = 2,
        IXREQ_NO = 3,
        IxREQ_DIV_V = 4,
        IxMAT_CD = 5,
        IxPCC_SPEC_CD = 6,
        IxCOLOR_CD = 7,
        IxPCC_UNIT_CD = 8,
        IxT_LEVEL = 9,
        IxSTATUS = 10,
        IxREQ_YMD_V = 11,
        IXREQ_NO_N = 12,
        IxREQ_DIV = 13,
        IxMAT_NAME = 14,
        IxMAT_COMMENT = 15,
        IxCOLOR_NAME = 16,
        IxPCC_UNIT_NAME = 17,
        IxPCC_SPEC_NAME = 18,
        IxVALUE = 19,
        IxREMARKS = 20,
    }

    public enum TBSXO_REQ_TAIL02 : int
    {
        IxMaxCt = 26,		// ÀÎµ¦½º Count 
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxREQ_YMD = 2,
        IXREQ_NO = 3,
        IxREQ_DIV = 4,
        IxLOT_NO = 5,
        IxLOT_SEQ = 6,
        IxSR_NO = 7,
        IxSRF_NO = 8,
        IxBOM_ID = 9,
        IxBOM_REV = 10,
        IxNF_CD = 11,
        IxSTYLE_NAME = 12,
        IxT_LEVEL = 13,
        IxSTATUS = 14,
        IxREQ_YMD_V = 15,
        IxREQ_DIV_V = 16,
        IxLOT_NO_V = 17,
        IxLOT_SEQ_V = 18,
        IxITEM = 19,
        IxSTYLE_NAME_V = 20,
        IxNF_CD_V = 21,
        IxPCC_UNIT_NAME = 22,
        IxSIZE_CD = 23,
        IxPROD_YIELD = 24,
        IxREMARKS = 25,
    }

    public enum TBSXD_SRF_TAIL_LOAD : int
    {
        IxMaxCt = 23,		// ÀÎµ¦½º Count 
        IxDIVISION = 0,

        IxFACTORY = 1,			// °øÀåÄÚµå	:VARCHAR2(5) 
        IxSR_NO = 2,			// SR_NO	:VARCHAR2(10) 
        IxSRF_NO = 3,			// SRF_NO	:VARCHAR2(20)
        IxBOM_ID = 4,			// SRF_NO	:VARCHAR2(20) 
        IxBOM_REV = 5,			// SRF_NO	:VARCHAR2(20) 

        IxNF_CD = 6,			// SRF_NO	:VARCHAR2(20) 

        IxPART_NO = 7,			// ÄÄÆ÷³ÍÆ®¼ø¹ø	:VARCHAR2(10) 
        IxPART_TYPE = 8,			// ÄÄÆ÷³ÍÆ®ÆÄÆ®	:VARCHAR2(50) 
        IxPART_NAME = 9,			// PART_DESC	:VARCHAR2(200) 
        IxPART_COMMENT = 10,			// PART_DESC	:VARCHAR2(200) 
        IxPART_QTY = 11,			// ÄÄÆ÷³ÍÆ® ¼ö·®	:NUMBER(22)

        IxMAT_CD = 12,			// ÀÚÀçÄÚµå	:VARCHAR2(50) 
        IxMAT_NAME = 13,			// ÀÚÀçÄÚµå	:VARCHAR2(50)  
        IxMAT_COMMENT = 14,			// MAT_COMMENT	:VARCHAR2(200) 
        IxMAT_DESC = 15,			// MAT_DESC	:VARCHAR2(200) 

        IxCOLOR_CD = 16,			// COLOR	:VARCHAR2(50) 
        IxCOLOR_DESC = 17,			// COLOR_DESC	:VARCHAR2(200) 
        IxCOLOR_COMMENT = 18,			// COLOR_COMMENT	:VARCHAR2(200) 
        IxMCS_CD = 19,			// MCS	:VARCHAR2(50) 

        IxSTATUS = 20,			// »óÅÂ	:VARCHAR2(1) 
        IxUPD_USER = 21,			// ÀÛ¼ºÀÚ	:VARCHAR2(30) 
        IxUPD_YMD = 22,			// ÀÛ¼ºÀÏ	:DATE(7) 
    }

    public enum SXD_SRF_TAIL_LOAD_AT : int
    {
        lxFACTORY = 1,
        lxSR_NO = 2,
        lxSRF_NO = 3,
        lxBOM_ID = 4,
        lxBOM_REV = 5,
        lxNF_CD = 6,
        lxPART_NO = 7,
        lxPART_TYPE = 8,
        lxPART_DESC = 9,
        lxPART_COMMENT = 10,
        lxPART_QTY = 11,
        lxMAT_CD = 12,
        lxREQ_CD = 13,
        lxMAT_NAME = 14,
        lxMAT_COMMENT = 15,
        lxMAT_DESC = 16,
        lxMAT_REQ_STATUS = 17,
        lxEF = 18,
        lxVENDOR_DESC = 19,
        lxMCS_CD = 20,
        lxCOLOR_CD = 21,
        lxCOLOR_DESC = 22,
        lxCOLOR_COMMENT = 23,
        lxPANTONE_CODE = 24,
        lxRCY = 25,
        lxSTATUS = 26,
        lxUPD_USER = 27,
        lxUPD_YMD = 28,


    }

    public enum SXD_SRF_ORDER_LOAD : int
    {



        lxMax = 24,

        lxFACTORY = 1,
        lxSR_NO = 2,
        lxSRF_NO = 3,
        lxBOM_ID = 4,
        lxBOM_REV = 5,
        lxNF_CD = 6,
        lxSIZE_CD = 7,
        lxORD_TYPE = 8,
        lxSR_LINE_ITEM = 9,
        lxSIDE_TYPE = 10,
        lxORD_QTY = 11,
        lxREQUESTOR = 12,
        lxORD_YMD = 13,
        lxNEED_BY = 14,
        lxDESTINATION = 15,
        lxGEN_CD = 16,
        lxWIDTH = 17,
        lxFIT = 18,
        lxAGE = 19,
        lxATTN = 20,
        lxNIKE_FLG = 21,
        lxSTATUS = 22,
        lxUPD_USER = 23,
        lxUPD_YMD = 24,




    }

    public enum SXD_SRF_MASTER_TITLE : int
    {



        lxMax = 14,

        lxFACTORY = 1,
        lxSRF_NO = 2,
        lxBOM_ID = 3,
        lxBOM_REV = 4,
        lxNF_CD = 5,
        lxSTYLE_CD = 6,
        lxSTYLE_NAME = 7,
        lxCATEGORY = 8,
        lxGEN_CD = 9,
        lxAGE = 10,
        lxSILHOUETTE = 11,
        lxTECHNOLOGY = 12,
        lxIPW = 13,
        lxREMARKS = 14,



    }

    public enum SXD_SRF_MASTER_LIST_P : int
    {



        lxMax = 11,

        lxFACTORY = 1,
        lxSRF_NO = 2,
        lxBOM_ID = 3,
        lxBOM_REV = 4,
        lxNF_CD = 5,
        lxCATEGORY = 6,
        lxSEASON_CD = 7,
        lxSTYLE_CD = 8,
        lxXDM_DIM_CD = 9,
        lxSTYLE_NAME = 10,
        lxGEN_CD = 11,


    }

    public enum SXD_SRF_MASTER_LIST_B : int
    {
        
        lxMax = 12,

        lxFACTORY = 1,
        lxSR_NO = 2,
        lxSRF_NO = 3,
        lxBOM_ID = 4,
        lxBOM_REV = 5,
        lxNF_CD = 6,
        lxCATEGORY = 7,
        lxSEASON_CD = 8,
        lxSTYLE_CD = 9,
        lxXDM_DIM_CD = 10,
        lxSTYLE_NAME = 11,
        lxGEN_CD = 1,


    }

    public enum SXD_SRF_TAIL_UPDATE : int
    {



        lxMax = 55,

        lxLEVEL = 1,
        lxFACTORY = 2,
        lxSR_NO = 3,
        lxSRF_NO = 4,
        lxBOM_ID = 5,
        lxBOM_REV = 6,
        lxNF_CD = 7,
        lxSRF_SEQ = 8,
        lxPUR_FLG = 9,
        lxCHANGE_R_FLG = 10,
        lxSTATUS = 11,
        lxPART_NO = 12,
        lxSORT_NO = 13,
        lxPART_TYPE = 14,
        lxPART_DESC = 15,
        lxPART_COMMENT = 16,
        lxPART_QTY = 17,
        lxMAT_CD = 18,
        lxREQ_CD = 19,
        lxMAT_NAME = 20,
        lxMAT_COMMENT = 21,
        lxMAT_DESC = 22,
        lxMAT_REQ_STATUS = 23,
        lxEF = 24,
        lxVENDOR_DESC = 25,
        lxMCS_CD = 26,
        lxCOLOR_CD = 27,
        lxCOLOR_DESC = 28,
        lxCOLOR_COMMENT = 29,
        lxPANTONE_CODE = 30,
        lxRCY = 31,
        lxPART_SEQ = 32,
        lxMAT_COMMENT_SEQ = 33,
        lxSRF_SEQ_MAX = 34,
        lxPCC_UNIT_CD = 35,
        lxPCC_SPEC_CD = 36,
        lxPCC_SPEC_NAME = 37,
        lxPCC_LENGTH = 38,
        lxPCC_LENGTHUOM = 39,
        lxPCC_WIDTH = 40,
        lxPCC_WIDTHUOM = 41,
        lxPCC_QTYUOM = 42,
        lxYIELD_VALUE = 43,
        lxLOSS_VALUE = 44,
        lxIMPORT_YN = 45,
        lxLAMINATION_YN = 46,
        lxDELIVERY_DAYS = 47,
        lxVEN_SEQ = 48,
        lxPART_DESC_KNAME = 49,
        lxMAT_NAME_KNAME = 50,
        lxCOLOR_DESC_KNAME = 51,
        lxAUTO_FLG = 52,
        lxREMARKS = 53,
        lxUPD_USER = 54,
        lxUPD_YMD = 55,




    }

    public enum SXD_SRF_ORDER_UPDATE : int
    {


        lxMax = 30,

        lxLEVEL = 1,
        lxFACTORY = 2,
        lxSR_NO = 3,
        lxSRF_NO = 4,
        lxBOM_ID = 5,
        lxBOM_REV = 6,
        lxNF_CD = 7,
        lxSRF_SEQ = 8,
        lxPUR_FLAG = 9,
        lxCHANGE_R_FLG = 10,
        lxSTATUS = 11,
        lxSIZE_CD = 12,
        lxORD_TYPE = 13,
        lxSR_LINE_ITEM = 14,
        lxSIDE_TYPE = 15,
        lxORD_QTY = 16,
        lxREQUESTOR = 17,
        lxORD_YMD = 18,
        lxNEED_BY = 19,
        lxDESTINATION = 20,
        lxGEN_CD = 21,
        lxWIDTH = 22,
        lxFIT = 23,
        lxAGE = 24,
        lxATTN = 25,
        lxNIKE_FLG = 26,
        lxAUTO_FLG = 27,
        lxREMARKS = 28,
        lxUPD_USER = 29,
        lxUPD_YMD = 30,


    }

    public enum SXD_SRF_VENDER_UPDATE : int
    {



        lxMax = 15,

        lxFACTORY = 1,
        lxSR_NO = 2,
        lxSRF_NO = 3,
        lxBOM_ID = 4,
        lxBOM_REV = 5,
        lxNF_CD = 6,
        lxMAT_CD = 7,
        lxVEN_SEQ = 8,
        lxPOPULA_NAME = 9,
        lxVENDOR_DESC = 10,
        lxNIKE_FLG = 11,
        lxREMARKS = 12,
        lxSTATUS = 13,
        lxUPD_USER = 14,
        lxUPD_YMD = 15,





    }

    public enum SXD_SRF_VENDER_LOAD : int
    {



        lxMax = 12,

        lxFACTORY = 1,
        lxSR_NO = 2,
        lxSRF_NO = 3,
        lxBOM_ID = 4,
        lxBOM_REV = 5,
        lxNF_CD = 6,
        lxMAT_CD = 7,
        lxPOPULA_NAME = 8,
        lxVENDOR_DESC = 9,
        lxSTATUS = 10,
        lxUPD_USER = 11,
        lxUPD_YMD = 12,





    }

    public enum SXD_SRF_M_PART_POP : int
    {
        lxMax = 5,

        lxFACTORY = 1,
        lxPART_SEQ = 2,
        lxPART_TYPE = 3,
        lxPART_DESC = 4,
        IxPART_QTY = 5,


    }

    public enum SXD_SRF_M_MATERIAL_POP : int
    {
        lxMax = 5,

        lxFACTORY = 1,
        lxMAT_CD = 2,
        lxMAT_NAME = 3,
        lxMAT_COMMENT = 4,
        lxMAT_DESC = 5,




    }

    public enum SXD_SRF_M_SPEC_POP : int
    {
        lxMax = 9,


        lxFACTORY = 1,
        lxSPEC_CD = 2,
        lxSPEC_DESC = 3,
        lxUSE_YN = 4,
        lxSEND_CHK = 5,
        lxSEND_YMD = 6,
        lxSTATUS = 7,
        lxUPD_USER = 8,
        lxUPD_YMD = 9,


    }

    public enum SXD_SRF_M_COLOR_POP : int
    {
        lxMax = 5,

        lxFACTORY = 1,
        lxCOLOR_CD = 2,
        lxCOLOR_DESC = 3,
        lxCOLOR_COMMENT = 4,



    }

    public enum SXD_SRF_M_MCS_POP : int
    {
        lxMax = 3,

        lxFACTORY = 1,
        lxMCS_CD = 2,



    }

    public enum SXD_SRF_M_UNIT_POP : int
    {
        lxMax = 9,

        lxFACTORY = 1,
        lxUNIT_CD = 2,
        lxSPEC_CD = 3,
        lxSPEC_DESC = 4,




    }
    
    public enum TBSDD_SRF_XML_HEAD : int
    {

        IxMaxCt = 6,		// ÀÎµ¦½º Count 

        lxPCC = 1,
        lxNIKE_SY_STY_NBR = 2,
        lxNIKE_SY_COLR_CD_ID = 3,
        lxNIKE_XDM_DIM_CD = 4,
        lxNIKE_BOM_ID = 5,
        lxNIKE_MODEL_OFFERING_ID = 6,

    }

    public enum TBSDD_SRF_XML_TAIL : int
    {

        IxMaxCt = 13,		// ÀÎµ¦½º Count 

        lxNIKE_MATERIAL_ID = 1,
        lxNIKE_MATERIAL_BY_SUPPLIER = 2,
        lxNIKE_COLOR_CD = 3,
        lxPCC_SEQ_NO = 4,
        lxPCC_PART_NAME = 5,
        lxPCC_YIELD = 6,
        lxPCC_LOSS_PERCENT = 7,
        lxPCC_USAGE = 8,
        lxPCC_LENGTH = 9,
        lxPCC_LENGTHUOM = 10,
        lxPCC_WIDTH = 11,
        lxPCC_WIDTHUOM = 12,
        lxPCC_QTYUOM = 13,


    }

    public enum SXD_SRF_HEAD : int
    {



        lxMax = 67,

        lxFACTORY = 1,
        lxSR_NO = 2,
        lxSRF_NO = 3,
        lxBOM_ID = 4,
        lxBOM_REV = 5,
        lxNF_CD = 6,
        lxSRF_SEQ = 7,
        lxBOM_STATE = 8,
        lxREQUESTOR = 9,
        lxORD_QTY = 10,
        lxORD_YMD = 11,
        lxNEED_BY = 12,
        lxETS = 13,
        lxGEN_CD = 14,
        lxWIDTH = 15,
        lxFIT = 16,
        lxAGE = 17,
        lxATTN = 18,
        lxSIDE_TYPE = 19,
        lxMO_ALIAS = 20,
        lxWHQ_PLM = 21,
        lxWHQ_DEV = 22,
        lxNLO_DEV = 23,
        lxSILHOUETTE = 24,
        lxTECHNOLOGY = 25,
        lxLASTING_ME = 26,
        lxMS_ME = 27,
        lxSOLE_LAYING = 28,
        lxMTO_ACC = 29,
        lxBOM_COMMENT = 30,
        lxFACTORY_DV = 31,
        lxPRD = 32,
        lxBVTN_PDM = 33,
        lxASIAN_PDM = 34,
        lxPRC_RQT = 35,
        lxDIM = 36,
        lxSESN = 37,
        lxPTRN_NO = 38,
        lxSIZE_CD = 39,
        lxLAST_CD = 40,
        lxASSOC_MTWAY = 41,
        lxDEV_NAME = 42,
        lxPURPOSE = 43,
        lxMODIFIED = 44,
        lxCONST = 45,
        lxMTL_VER = 46,
        lxCOLOR_VER = 47,
        lxSAMPLE_TYPES = 48,
        lxTRGT_IPM = 49,
        lxCNF_SSR = 50,
        lxPH_AD = 51,
        lxCREATE_YMD = 52,
        lxRTA = 53,
        lxETC = 54,
        lxREC = 55,
        lxPAIRS_NO = 56,
        lxPRIORITY = 57,
        lxRNDS_NO = 58,
        lxSTA = 59,
        lxCOMMENTS = 60,
        lxSTYLE_CD = 61,
        lxNEW_OLD_FLG = 62,
        lxPUR_FLG = 63,
        lxREMARKS = 64,
        lxSTATUS = 65,
        lxUPD_USER = 66,
        lxUPD_YMD = 67,


    }

    public enum SXB_SRF_MANAGER : int
    {



        lxMax = 30,


        lxFLAG = 1,
        lxFACTORY = 2,
        lxSEASON_CD = 3,
        lxSTYLE_CD = 4,
        lxSTYLE_NAME = 5,
        lxBOM_CD = 6,
        lxAGE = 7,
        lxSUKHOUETTE = 8,
        lxTECHNOLOGY = 9,
        lxCATEGORY = 10,
        lxSR_NO = 11,
        lxSRF_NO = 12,
        lxBOM_ID = 13,
        lxBOM_REV = 14,
        lxNF_CD = 15,
        lxP_FLAG = 16,
        lxSAMPLE_TYPES = 17,
        lxGED_CD = 18,
        lxPLN_FLG = 19,
        lxI_FLAG = 20,
        lxO_FLAG = 21,
        lxSTATUS = 22,
        lxSIZE_CD = 23,
        lxSCH_STA_YMD = 24,
        lxSCH_FIN_YMD = 25,
        lxREMARKS = 26,
        lxLOAD_UPD_USER = 27,
        lxLOAD_UPD_YMD = 28,
        lxDEP_FLG = 29,
        LxXML_JOB_FLG = 30,




    }

    public enum TBSXD_SRF_HEAD : int
    {
        IxMaxCt = 74,		// ÀÎµ¦½º Count 

        IxFACTORY = 0,			// °øÀåÄÚµå	:VARCHAR2(5) 
        IxSR_NO = 1,			// SR_NO	:VARCHAR2(10) 
        IxSRF_NO = 2,			// SRF_NO	:VARCHAR2(20) 
        IxBOM_ID = 3,			// BOM_ID	:VARCHAR2(17) 
        IxBOM_REV = 4,			// BOM_REV	:VARCHAR2(5) 
        IxNF_CD = 5,			// NF_CD	:VARCHAR2(5) 
        IxSRF_SEQ = 6,			// SRF_SEQ	:VARCHAR2(3) 

        IxBOM_STATE = 7,			// BOM_STATE	:VARCHAR2(50) 
        IxREQUESTOR = 8,			// REQUESTOR	:VARCHAR2(50) 
        IxORD_YMD = 9,			// ORD_YMD	:VARCHAR2(50) 
        IxNEED_BY = 10,			// NEED_BY	:VARCHAR2(50) 
        IxETS = 11,			// ETS	:VARCHAR2(50) 

        IxMO_ALIAS = 12,			// MO_ALIAS	:VARCHAR2(50) 
        IxWHQ_PLM = 13,			// WHQ_PLM	:VARCHAR2(50) 
        IxWHQ_DEV = 14,			// WHQ_DEV	:VARCHAR2(50) 
        IxNLO_DEV = 15,			// NLO_DEV	:VARCHAR2(50) 
        IxSILHOUETTE = 16,			// SILHOUETTE	:VARCHAR2(100) 

        IxTECHNOLOGY = 17,			// TECHNOLOGY	:VARCHAR2(100) 
        IxLASTING_ME = 18,			// LASTING_ME	:VARCHAR2(100) 
        IxMS_ME = 19,			// MS_ME	:VARCHAR2(100) 
        IxSOLE_LAYING = 20,			// SOLE_LAYING	:VARCHAR2(100) 
        IxMTO_ACC = 21,			// MTO_ACC	:VARCHAR2(100) 

        IxBOM_COMMENT = 22,			// BOM_COMMENT	:VARCHAR2(2048) 
        IxFACTORY_DV = 23,			// »ý»ê°øÀåÄÚµå	:VARCHAR2(50) 
        IxSESN = 24,			// ½ÃÁð	:VARCHAR2(50) 
        IxPATTERN = 25,			// PATTERN	:VARCHAR2(50) 
        IxLAST_CD = 26,			// ¶ó½ºÅÍÄÚµå	:VARCHAR2(50) 

        IxDEV_NAME = 27,			// DEV_NAME	:VARCHAR2(50) 
        IxMTL_VER = 28,			// MTL_VER	:VARCHAR2(100) 
        IxCOLOR_VER = 29,			// COLOR_VER	:VARCHAR2(100) 
        IxSAMPLE_TYPES = 30,			// SAMPLE_TYPES	:VARCHAR2(50) 
        IxSTA = 31,			// STA	:VARCHAR2(50) 

        IxCURRENT_IPW = 32,			// CURRENT_IPW	:VARCHAR2(50) 
        IxPRODUCT_CODE = 33,			// PRODUCT_CODE	:VARCHAR2(50) 
        IxPUR_FLG = 34,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
        IxSTYLE_CD = 35,
        IxREMARKS = 36,			// ºñ°í	:VARCHAR2(500) 
        IxSTATUS = 37,			// »óÅÂ	:VARCHAR2(1) 
        IxLOAD_UPD_USER = 38,			// LOAD_UPD_USER	:VARCHAR2(30) 
        IxLOAD_UPD_YMD = 39,
        IxUPD_USER = 40,			// ÀÛ¼ºÀÚ	:VARCHAR2(30) 
        IxUPD_YMD = 41,

        IxPROD_EXT_COLOR = 42, 
        IxPCC_FACTORY = 43, 
        IxSS_FACTORY = 44, 
        IxP_PROD_FACTORY = 45, 
        IxS_PROD_FACTORY = 46,
        
        IxSR_INSTRUCTIONS     = 47,
        IxBOM_DIMENSION       = 48,
        IxBOM_PLATFORM        = 49,
        IxBOM_LASTDIM         = 50,
        IxBOM_METHOD          = 51,
        IxPRODUCTID           = 52,
        IxBOM_INLINESIZERANGE = 53,
        IxBOM_PROMOSIZERANGE  = 54,
        IxCM_NAME             = 55,
        IxCM_TYPE             = 56,
        IxCM_DUTYCODE         = 57,
        IxCM_TFOB             = 58,
        IxDEVPROJ_ALIAS       = 59,
        IxDEVPROJ_ID          = 60,
        IxTDCODE              = 61,
        IxPLM                 = 62,
        IxBIZ_ORG             = 63,
        IxCONSUMER_PURPOSE    = 64,
        IxCONSUMER_FOCUS      = 65,
        IxCONSUMER_USE        = 66,
        IxMODEL_ID            = 67,
        IxSPC_YN              = 68,
        IxGTM_DIV             = 69,
        IxMARKETING_NAME      = 70,
        IxOFFSHORE_YN         = 71,
        IxPU_PUCK_YN          = 72,
        IxPU_PUCK_DESC        = 73,

    }

    public enum TBSELECT_SDO_REQ_MAT_INFO : int
    {
        IxMaxCt = 10,		// ÀÎµ¦½º Count
        IxDIVISION = 0,
        IxMAT_CD = 1,
        IxMAT_COMMENT_SEQ = 2,
        IxMAT_NAME = 3,
        IxMAT_COMMENT = 4,
        IxPCC_UNIT = 5,
        IxPCC_SPEC = 6,
        IxPCC_LENGTH = 7,
        IxPCC_LENGTHUOM = 8,
        IxPCC_WIDTH = 9,
        IxPCC_WIDTHUOM = 10,
        IxPCC_QTYUOM = 11,
        IxYIELD_VALUE = 12,
        IxLOSS_VALUE = 13,
        IxIMPORT_YN = 14,
        IxLAMINATION_YN = 15,
        IxMAT_DIV = 16,
        IxMAT_DIV_DESC = 17,
    }

    public enum TBSELECT_SDO_REQ_COLOR_INFO : int
    {
        IxMaxCt = 4,		// ÀÎµ¦½º Count
        IxDIVISION = 0,
        IxCOLOR_CD = 1,
        IxCOLOR_NAME = 2,
        IxCOLOR_COMMENT = 3,
    }

    public enum TBSELECT_SDO_REQ_MCS_INFO : int
    {
        IxMaxCt = 2,		// ÀÎµ¦½º Count
        IxDIVISION = 0,
        IxMCS_NAME = 1,
    }

    public enum TBSXC_PJ_MAST_SCTER : int
    {
        IxMaxCt = 34,		// ÀÎµ¦½º Count 
        IxDIVISION     = 0,			// °øÀåÄÚµå	:VARCHAR2(5)
        IxXML_CRT      = 1,			// °øÀåÄÚµå	:VARCHAR2(5)
        IxPLN_FLG      = 2,			// °øÀåÄÚµå	:VARCHAR2(5)
        IxPUR_FLG      = 3,			// °øÀåÄÚµå	:VARCHAR2(5)
        IxIN_FLG       = 4,			// BOMÄÚµå	:VARCHAR2(10)
        IxOUT_FLG      = 5,			// PJ_SEQ1	:VARCHAR2(7) 
        IxPROD_FLG     = 6,			// PJ_SEQ2	:VARCHAR2(3)
        IxREMARKS      = 7,				// BOMÄÚµå	:VARCHAR2(10)
        IxFACTORY      = 8,			// ¸ðµ¨ÄÚµå	:VARCHAR2(6)
        IxCATEGORY     = 9,			// ¸ðµ¨¸í	:VARCHAR2(50)
        IxSEASON_CD    = 10,		// BOMÄÚµå	:VARCHAR2(10)
        IxSTYLE_CD     = 11,			// AGE	:VARCHAR2(10) 
        IxSTYLE_NAME   = 12,			// SILHOUETTE	:VARCHAR2(10)
        IxBOM_CD       = 13,			// BOMÄÚµå	:VARCHAR2(10) 
        IxSR_NO        = 14,			// TECHNOLOGY	:VARCHAR2(10) 
        IxSRF_NO       = 15,			// CATEGORY	:VARCHAR2(4)
        IxBOM_ID       = 16,			// PJ_SEQ1	:VARCHAR2(7) 
        IxBOM_REV      = 17,			// PJ_SEQ2	:VARCHAR2(3)
        IxSAMPLE_TYPES = 18,			// BOMÄÚµå	:VARCHAR2(10)
        IxNF_CD        = 19,			// BOMÄÚµå	:VARCHAR2(10)
        IxORD_YMD      = 20,			// PJ_SEQ2	:VARCHAR2(3)
        IxNEED_BY      = 21,			// SRF_NO	:VARCHAR2(20)
        IxDEP_FLG      = 22,			// SRF_NO	:VARCHAR2(20)
        IxXML_MAKE     = 23,			// SRF_NO	:VARCHAR2(20)
        IxUPLOAD_USER  = 24,			// BOMÄÚµå	:VARCHAR2(10)
        

    }

    public enum TBSXD_SRF_TAIL_PART_LIST : int
    {
        IxMaxCt = 11,		// ÀÎµ¦½º Count
        IxDIVISION = 0,
        IxSRF_NO = 1,
        IxBOM_ID = 2,
        IxBOM_REV = 3,
        IxNF_CD = 4,
        IxNF_F_DESC = 5,
        IxSORT_NO = 6,
        IxPART_SEQ = 7,
        IxPART_DESC = 8,
        IxMAT_CD = 9,
        IxMAT_NAME = 10,

    }

    public enum TBSDD_SRF_VENDOR : int
    {
        IxMaxCt = 9,		// ÀÎµ¦½º Count 
        IxFACTORY = 1,			// °øÀåÄÚµå	:VARCHAR2(5) 
        IxSR_NO = 2,			// SR_NO	:VARCHAR2(10) 
        IxSRF_NO = 3,			// SRF_NO	:VARCHAR2(20)
        IxBOM_ID = 4,			// SRF_NO	:VARCHAR2(20) 
        IxBOM_REV = 5,			// SRF_NO	:VARCHAR2(20) 
        IxNF_CD = 6,			// SRF_NO	:VARCHAR2(20) 
        IxMAT_CD = 7,			// ÀÚÀçÄÚµå	:VARCHAR2(50) 
        IxVEN_SEQ = 8,			// SRF_NO	:VARCHAR2(20) 
        IxPOPULA_NAME = 9,			// POPULA_NAME	:VARCHAR2(200) 
        IxVENDOR_DESC = 10,			// °Å·¡Ã³ÄÚµå	:VARCHAR2(200) 
        IxNIKE_FLG = 11,			// °Å·¡Ã³ÄÚµå	:VARCHAR2(200) 
        IxREMARKS = 12,			// °Å·¡Ã³ÄÚµå	:VARCHAR2(200) 
        IxSTATUS = 13,			// »óÅÂ	:VARCHAR2(1) 
        IxUPD_USER = 14,			// ÀÛ¼ºÀÚ	:VARCHAR2(30) 
        IxUPD_YMD = 15,			// ÀÛ¼ºÀÏ	:DATE(7) 
    }

    public enum TBSXD_SRF_ORDER : int
    {
        IxMaxCt = 29,		// ÀÎµ¦½º Count 
        IxDIVISION = 0,
        IxFACTORY = 1,			// °øÀåÄÚµå	:VARCHAR2(5) 
        IxSR_NO = 2,			// SR_NO	:VARCHAR2(10) 
        IxSRF_NO = 3,			// SRF_NO	:VARCHAR2(20) 
        IxBOM_ID = 4,			// BOM_ID	:VARCHAR2(17) 
        IxBOM_REV = 5,			// BOM_REV	:VARCHAR2(5) 
        IxNF_CD = 6,			// NF_CD	:VARCHAR2(5) 
        IxSRF_SEQ = 7,			// SRF_SEQ	:VARCHAR2(3) 
        IxSRF_LEVEL = 8,			// SRF_SEQ	:VARCHAR2(3) 
        IxPUR_FLG = 9,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
        IxPUR_FLG_DESC = 10,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
        IxCHANGE_R_FLG = 11,			// ·¹ÄÚµå¼öÁ¤»óÅÂ	:VARCHAR2(1) 
        IxCHANGE_R_FLG_DESC = 12,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
        IxSTATUS = 13,			// »óÅÂ	:VARCHAR2(1)
        IxSTATUS_DESC = 14,
        IxSIZE_CD = 15,			// »çÀÌÁîÄÚµå	:VARCHAR2(50)  
        IxORD_TYPE = 16,			// ORD_TYPE	:VARCHAR2(50) 
        IxSR_LINE_ITEM = 17,			// SR_LINE_ITEM	:VARCHAR2(50) 
        IxSIDE_TYPE = 18,			// SIDE_TYPE	:VARCHAR2(50)
        IxORD_QTY = 19,			// ORD_QTY	:NUMBER(22) 
        IxREQUESTOR = 20,			// REQUESTOR	:VARCHAR2(50) 
        IxORD_YMD = 21,			// ORD_YMD	:VARCHAR2(50) 
        IxNEED_BY = 22,			// NEED_BY	:VARCHAR2(50) 
        IxDESTINATION = 23,			// DESTINATION	:VARCHAR2(300) 
        IxGEN_CD = 24,			// Á¨´õÄÚµå	:VARCHAR2(50) 
        IxWIDTH = 25,			// WIDTH	:VARCHAR2(50) 
        IxFIT = 26,			// FIT	:VARCHAR2(50) 
        IxAGE = 27,			// AGE	:VARCHAR2(50) 
        IxATTN = 28,			// ATTN	:VARCHAR2(50) 
        IxNIKE_FLG = 29,			// NIKE_FLG	:VARCHAR2(1) 
        IxAUTO_FLG = 30,			// AUTO_FLG	:VARCHAR2(1) 
        IxREMARKS = 31,			// ºñ°í	:VARCHAR2(500) 
        IxUPD_USER = 32,			// ÀÛ¼ºÀÚ	:VARCHAR2(30) 
        IxUPD_YMD = 33,			// ÀÛ¼ºÀÏ	:DATE(7) 
    }

    public enum TBSXD_SRF_ORDER_LOAD : int
    {
        IxMaxCt = 24,		// ÀÎµ¦½º Count
        IxDIVISION = 0,

        IxFACTORY = 1,
        IxSR_NO = 2,
        IxSRF_NO = 3,
        IxBOM_ID = 4,
        IxBOM_REV = 5,
        IxNF_CD = 6,
        IxSIZE_CD = 7,
        IxORD_TYPE = 8,
        IxSR_LINE_ITEM = 9,
        IxSIDE_TYPE = 10,
        IxORD_QTY = 11,
        IxREQUESTER = 12,
        IxORD_YMD = 13,
        IxNEED_BY = 14,
        IxDESTINATION = 15,
        IxGEN_CD = 16,
        IxWIDTH = 17,
        IxFIT = 18,
        IxAGE = 19,
        IxATTN = 20,
        IxNIKE_FLG = 21,
        IxSTATUS = 22,
        IxUPD_USER = 23,

    }

    public enum TBSXD_SRF_TAIL : int
    {
        IxMaxCt = 47,		// ÀÎµ¦½º Count
        IxDIVISION = 0,
        IxFACTORY = 1,			// °øÀåÄÚµå	:VARCHAR2(5) 
        IxSR_NO = 2,			// SR_NO	:VARCHAR2(10) 
        IxSRF_NO = 3,			// SRF_NO	:VARCHAR2(20) 
        IxBOM_ID = 4,			// BOM_ID	:VARCHAR2(17) 
        IxBOM_REV = 5,			// BOM_REV	:VARCHAR2(5) 
        IxNF_CD = 6,			// NF_CD	:VARCHAR2(5) 
        IxSRF_SEQ = 7,			// SRF_SEQ	:VARCHAR2(3) 

        IxSRF_SEQ_MAX = 8,			// SRF_SEQ_MAX	:VARCHAR2(3) 
        IxSRF_LEVEL = 9,			// SRF_SEQ_MAX	:VARCHAR2(3) 
        IxPUR_FLG = 10,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
        IxPUR_FLG_DESC = 11,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
        IxCHANGE_R_FLG = 12,			// ·¹ÄÚµå¼öÁ¤»óÅÂ	:VARCHAR2(1) 
        IxCHANGE_R_FLG_DESC = 13,			// ·¹ÄÚµå¼öÁ¤»óÅÂ	:VARCHAR2(1) 
        IxSTATUS = 14,			// »óÅÂ	:VARCHAR2(1) 
        IxSTATUS_DESC = 15,			// »óÅÂ	:VARCHAR2(1) 
        IxSORT_NO = 16,			// SORT_NO	:NUMBER(22) 

        IxPART_SEQ = 17,			// PART_SEQ	:NUMBER(22) 
        IxPART_NO = 18,			// PART_NO	:VARCHAR2(50) 
        IxPART_TYPE = 19,			// PART_TYPE	:VARCHAR2(50) 
        IxPART_DESC = 20,			// PART_DESC	:VARCHAR2(200) 
        IxPART_COMMENT = 21,			// PART_COMMENT	:VARCHAR2(500) 
        IxPART_QTY = 22,			// PART_QTY	:NUMBER(22) 
        IxMAT_CD = 23,			// Ç°¸ñÄÚµå	:VARCHAR2(50) 
        IxMAT_NAME = 24,			// MAT_NAME	:VARCHAR2(1024) 
        IxMAT_COMMENT = 25,			// MAT_COMMENT	:VARCHAR2(500) 
        IxMAT_DESC = 26,			// MAT_DESC	:VARCHAR2(1024) 
        IxMCS_CD = 27,			// MCS_CD	:VARCHAR2(50) 
        IxCOLOR_CD = 28,			// COLOR_CD	:VARCHAR2(50) 
        IxCOLOR_DESC = 29,			// COLOR_DESC	:VARCHAR2(200) 
        IxCOLOR_COMMENT = 30,			// COLOR_COMMENT	:VARCHAR2(200) 
        IxPCC_UNIT_CD = 31,			// PCC_UNIT_CD	:VARCHAR2(50) 
        IxPCC_SPEC_NAME = 32,			// PCC_SPEC_CD	:VARCHAR2(50) 
        IxPCC_SPEC_CD = 33,			// PCC_SPEC_CD	:VARCHAR2(50) 

        IxPCC_LENGTH = 34,			// PCC_LENGTH	:NUMBER(22) 
        IxPCC_LENGTHUOM = 35,			// PCC_LENGTHUOM	:VARCHAR2(50) 
        IxPCC_WIDTH = 36,			// PCC_WIDTH	:NUMBER(22) 
        IxPCC_WIDTHUOM = 37,			// PCC_WIDTHUOM	:VARCHAR2(50) 
        IxPCC_QTYUOM = 38,			// PCC_QTYUOM	:VARCHAR2(50) 
        IxYIELD_VALUE = 39,			// ´ëÇ¥Ã¤»ê°ª	:NUMBER(22) 
        IxLOSS_VALUE = 40,			// LOSS_VALUE	:NUMBER(22) 
        IxCOMMON_YN = 41,			// ¼öÀÔÀÚÀçÀ¯¹«	:VARCHAR2(1) 
        IxCBD_PRICE = 42,			// ÀÓ°¡°øÀ¯¹«	:VARCHAR2(1) 
        IxPUR_DIV = 43,			// MAT_DIV	:VARCHAR2(2) 
        IxVEN_SEQ = 44,			// VEN_SEQ	:NUMBER(22) 
        IxPART_DESC_KNAME = 45,			// PART_DESC_KNAME	:VARCHAR2(200) 
        IxMAT_NAME_KNAME = 46,			// MAT_NAME_KNAME	:VARCHAR2(200) 
        IxCOLOR_DESC_KNAME = 47,			// COLOR_DESC_KNAME	:VARCHAR2(200)
        IxISKNAME = 48,			// COLOR_DESC_KNAME	:VARCHAR2(200) 
        IxAUTO_FLG = 49,			// AUTO_FLG	:VARCHAR2(1) 
        IxREMARKS = 50,			// ºñ°í	:VARCHAR2(500) 
        IxUPD_USER = 51,			// ÀÛ¼ºÀÚ	:VARCHAR2(30) 
        IxUPD_YMD = 52,			// ÀÛ¼ºÀÏ	:DATE(7) 
    }

    public enum TBSXD_SRF_TAIL_SELECTER : int
    {
        IxMaxCt = 56,		// ÀÎµ¦½º Count
        IxDIVISION = 0,

        IxFACTORY = 1,			// °øÀåÄÚµå	:VARCHAR2(5) 
        IxSR_NO = 2,			// SR_NO	:VARCHAR2(10) 
        IxSRF_NO = 3,			// SRF_NO	:VARCHAR2(20) 
        IxBOM_ID = 4,			// BOM_ID	:VARCHAR2(17) 
        IxBOM_REV = 5,			// BOM_REV	:VARCHAR2(5) 

        IxLOT_NO = 6,			// NF_CD	:VARCHAR2(5) 
        IxLOT_SEQ = 7,			// NF_CD	:VARCHAR2(5) 
        IxSRF_SEQ = 8,			// SRF_SEQ_MAX	:VARCHAR2(3) 
        IxSRF_SEQ_MAX = 9,			// SRF_SEQ_MAX	:VARCHAR2(3) 
        IxSRF_LEVEL = 10,			// SRF_SEQ_MAX	:VARCHAR2(3) 

        IxPUR_FLG = 11,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
        IxPUR_FLG_DESC = 12,			// ¹ßÁÖÀ¯¹«	:VARCHAR2(1) 
        IxCHANGE_R_FLG = 13,			// ·¹ÄÚµå¼öÁ¤»óÅÂ	:VARCHAR2(1) 
        IxCHANGE_R_FLG_DESC = 14,			// ·¹ÄÚµå¼öÁ¤»óÅÂ	:VARCHAR2(1) 
        IxSTATUS = 15,			// »óÅÂ	:VARCHAR2(1) 

        IxSTATUS_DESC = 16,			// »óÅÂ	:VARCHAR2(1) 
        IxSORT_NO = 17,			// SORT_NO	:NUMBER(22) 
        IxPART_SEQ = 18,			// PART_SEQ	:NUMBER(22) 
        IxPART_NO = 19,			// PART_NO	:VARCHAR2(50) 
        IxPART_TYPE = 20,			// PART_TYPE	:VARCHAR2(50) 

        IxPART_DESC = 21,			// PART_DESC	:VARCHAR2(200) 
        IxPART_COMMENT = 22,			// PART_COMMENT	:VARCHAR2(500) 
        IxPART_QTY = 23,			// PART_QTY	:NUMBER(22) 
        IxMAT_CD = 24,			// Ç°¸ñÄÚµå	:VARCHAR2(50) 
        IxMAT_NAME = 25,			// MAT_NAME	:VARCHAR2(1024) 

        IxMAT_COMMENT = 26,			// MAT_COMMENT	:VARCHAR2(500) 
        IxMAT_DESC = 27,			// MAT_DESC	:VARCHAR2(1024) 
        IxMCS_CD = 28,			// MCS_CD	:VARCHAR2(50) 
        IxCOLOR_CD = 29,			// COLOR_CD	:VARCHAR2(50) 
        IxCOLOR_DESC = 30,			// COLOR_DESC	:VARCHAR2(200) 

        IxCOLOR_COMMENT = 31,			// COLOR_COMMENT	:VARCHAR2(200) 
        IxPCC_UNIT_CD = 32,			// PCC_UNIT_CD	:VARCHAR2(50) 
        IxPCC_SPEC_NAME = 33,			// PCC_SPEC_CD	:VARCHAR2(50) 
        IxPCC_SPEC_CD = 34,			// PCC_SPEC_CD	:VARCHAR2(50) 
        IxPCC_LENGTH = 35,			// PCC_LENGTH	:NUMBER(22) 

        IxPCC_LENGTHUOM = 36,			// PCC_LENGTHUOM	:VARCHAR2(50) 
        IxPCC_WIDTH = 37,			// PCC_WIDTH	:NUMBER(22) 
        IxPCC_WIDTHUOM = 38,			// PCC_WIDTHUOM	:VARCHAR2(50) 
        IxPCC_QTYUOM = 39,			// PCC_QTYUOM	:VARCHAR2(50) 
        IxYIELD_VALUE = 40,			// ´ëÇ¥Ã¤»ê°ª	:NUMBER(22) 

        IxLOSS_VALUE = 41,			// LOSS_VALUE	:NUMBER(22) 
        IxCOMMON_YN = 42,			// ¼öÀÔÀÚÀçÀ¯¹«	:VARCHAR2(1) 
        IxCBD_PRICE = 43,			// ÀÓ°¡°øÀ¯¹«	:VARCHAR2(1) 
        IxPUR_DIV = 44,			// MAT_DIV	:VARCHAR2(2) 
        IxVEN_SEQ = 45,			// VEN_SEQ	:NUMBER(22) 

        IxCATEGORY = 46,			// VEN_SEQ	:NUMBER(22) 
        IxSEASON_CD = 47,			// VEN_SEQ	:NUMBER(22)
        IxSEASON_NAME = 48,			// VEN_SEQ	:NUMBER(22) 
        IxSTYLE_CD = 49,
        IxSTYLE_NAME = 50,			// VEN_SEQ	:NUMBER(22) 
        IxAUTO_FLG = 51,			// AUTO_FLG	:VARCHAR2(1) 

        IxREMARKS = 52,			// ºñ°í	:VARCHAR2(500)
        IxCS_SIZE = 53,			// ºñ°í	:VARCHAR2(500) 
        IxUPD_USER = 54,			// ÀÛ¼ºÀÚ	:VARCHAR2(30) 
        IxUPD_YMD = 55,			// ÀÛ¼ºÀÏ	:DATE(7) 
    }

    public enum TBSELECT_SDO_REQ_PART_INFO : int
    {
        IxMaxCt = 10,		// ÀÎµ¦½º Count
        IxDIVISION = 0,
        IxPART_SEQ = 1,
        IxPART_TYPE = 2,
        IxPART_DESC = 3,
    }

    public enum TBSXC_PJ_MAST : int
    {
        IxMaxCt = 24,		// ÀÎµ¦½º Count 
        IxFACTORY = 1,			// °øÀåÄÚµå	:VARCHAR2(5) 
        IxSRF_NO = 2,			// SRF_NO	:VARCHAR2(20) 
        IxBOM_ID = 3,			// BOM_ID	:VARCHAR2(17) 
        IxCATEGORY = 4,			// CATEGORY	:VARCHAR2(2) 
        IxSEASON_CD = 5,			// ½ÃÁð	:VARCHAR2(6) 
        IxSTYLE_CD = 6,			// ½ºÅ¸ÀÏÄÚµå	:VARCHAR2(9) 
        IxXDM_DIM_CD = 7,			// XDM_DIM_CD	:VARCHAR2(2) 
        IxSTYLE_NAME = 8,			// ½ºÅ¸ÀÏ¸í	:VARCHAR2(50) 
        IxBOM_CD = 9,			// BOM_CD	:VARCHAR2(10) 
        IxUPPER_MAT = 10,			// UPPER_MAT	:VARCHAR2(50) 
        IxMS_MAT = 11,			// MS_MAT	:VARCHAR2(50) 
        IxOS_MAT = 12,			// OS_MAT	:VARCHAR2(50) 
        IxDEV_PROD = 13,			// DEV_PROD	:VARCHAR2(50) 
        IxT_D = 14,			// T_D	:VARCHAR2(30) 
        IxTARGET_FOB = 15,			// TARGET_FOB	:NUMBER(22) 
        IxCURRENT_FOB = 16,			// CURRENT_FOB	:NUMBER(22) 
        IxRETAIL_PRICE = 17,			// RETAIL_PRICE	:NUMBER(22) 
        IxIPW_YMD = 18,			// IPW_YMD	:VARCHAR2(8) 
        IxREMARKS = 19,			// ºñ°í	:VARCHAR2(500) 
        IxSTATUS = 20,			// »óÅÂ	:VARCHAR2(1) 
        IxUPD_USER = 21,			// ÀÛ¼ºÀÚ	:VARCHAR2(30) 
        IxUPD_YMD = 22,			// ÀÛ¼ºÀÏ	:DATE(7) 
        IxGEN_CD = 23,
    }

    public enum NODE_DEF : int
    {
        IxALIGNMENT = 5,			// ÅØ½ºÆ® Á¤·Ä ¹æ½Ä	:VARCHAR2(10) 
        IxDASHSTYLE = 6,			// ³ëµå Å×µÎ¸® ½ºÅ¸ÀÏ	:VARCHAR2(10) 
        IxDRAWCOLOR = 7,			// ³ëµå Å×µÎ¸® »ö±ò	:VARCHAR2(10) 
        IxDRAWWIDTH = 8,			// ³ëµå Å×µÎ¸® ¼± µÎ²²	:VARCHAR2(10) 
        IxFILLCOLOR = 9,			// ³ëµå Ã¤¿ì±â »ö±ò	:VARCHAR2(10) 
        IxFONT = 10,			// ÅØ½ºÆ® ÆùÆ® ¼Ó¼º	:VARCHAR2(60) 
        IxGRADI_YN = 11,			// GRADIANT ¿©ºÎ	:VARCHAR2(1) 
        IxGRADICOLOR = 12,			// GRADIANT »ö±ò	:VARCHAR2(10) 
        IxGRADIMODE = 13,			// GRADIANT ¸ðµå (½ºÅ¸ÀÏ)	:VARCHAR2(10) 
        IxHEIGHT = 14,			// ³ëµå ³ôÀÌ	:VARCHAR2(10) 
        IxSHADOW = 15,			// ³ëµå ±×¸²ÀÚ Ç¥½Ã ¼Ó¼º	:VARCHAR2(60) 
        IxSHAPE = 16,			// ³ëµå Å×µÎ¸® ¸ð¾ç ¼Ó¼º	:VARCHAR2(60) 
        IxTAG = 17,			// ÅÂ±× ¼Ó¼º	:VARCHAR2(60) 
        IxTEXT = 18,			// ÅØ½ºÆ®	:VARCHAR2(60) 
        IxTEXTCOLOR = 19,			// ÅØ½ºÆ® Ç¥½Ã »ö±ò	:VARCHAR2(10) 
        IxTOOLTIP = 20,			// ÅøÆÁ	:VARCHAR2(60) 
        IxWIDTH = 21,			// ³ëµå ³Êºñ	:VARCHAR2(10) 

    }

    public enum TBSPB_NODE_BOM : int
    {
        IxMaxCt = 23,		// ÀÎµ¦½º Count 
        //		IxFACTORY =1,			// °øÀå	:VARCHAR2(5) 
        //		IxBOM_CD =2,			// BOM ÄÚµå	:VARCHAR2(10) 
        IxCMP_CD = 1,			// Ç°¸ñ (¹ÝÁ¦) ÄÚµå	:VARCHAR2(10) 
        IxNODE_CD = 2,			// ³ëµåÄÚµå : °øÀåÄÚµå + BOM ÄÚµå + Seq(4)	:VARCHAR2(20) 
        IxLEFT = 3,			// ³ëµå ¿ÞÂÊ ÁÂÇ¥	:VARCHAR2(10) 
        IxTOP = 4,			// ³ëµå À§ ÁÂÇ¥	:VARCHAR2(10) 
        IxALIGNMENT = 5,			// ÅØ½ºÆ® Á¤·Ä ¹æ½Ä	:VARCHAR2(10) 
        IxDASHSTYLE = 6,			// ³ëµå Å×µÎ¸® ½ºÅ¸ÀÏ	:VARCHAR2(10) 
        IxDRAWCOLOR = 7,			// ³ëµå Å×µÎ¸® »ö±ò	:VARCHAR2(10) 
        IxDRAWWIDTH = 8,			// ³ëµå Å×µÎ¸® ¼± µÎ²²	:VARCHAR2(10) 
        IxFILLCOLOR = 9,			// ³ëµå Ã¤¿ì±â »ö±ò	:VARCHAR2(10) 
        IxFONT = 10,			// ÅØ½ºÆ® ÆùÆ® ¼Ó¼º	:VARCHAR2(60) 
        IxGRADI_YN = 11,			// GRADIANT ¿©ºÎ	:VARCHAR2(1) 
        IxGRADICOLOR = 12,			// GRADIANT »ö±ò	:VARCHAR2(10) 
        IxGRADIMODE = 13,			// GRADIANT ¸ðµå (½ºÅ¸ÀÏ)	:VARCHAR2(10) 
        IxHEIGHT = 14,			// ³ëµå ³ôÀÌ	:VARCHAR2(10) 
        IxSHADOW = 15,			// ³ëµå ±×¸²ÀÚ Ç¥½Ã ¼Ó¼º	:VARCHAR2(60) 
        IxSHAPE = 16,			// ³ëµå Å×µÎ¸® ¸ð¾ç ¼Ó¼º	:VARCHAR2(60) 
        IxTAG = 17,			// ÅÂ±× ¼Ó¼º	:VARCHAR2(60) 
        IxTEXT = 18,			// ÅØ½ºÆ®	:VARCHAR2(60) 
        IxTEXTCOLOR = 19,			// ÅØ½ºÆ® Ç¥½Ã »ö±ò	:VARCHAR2(10) 
        IxTOOLTIP = 20,			// ÅøÆÁ	:VARCHAR2(60) 
        IxWIDTH = 21,			// ³ëµå ³Êºñ	:VARCHAR2(10) 
        IxUPD_USER = 22,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 23,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
    }

    public enum TBSPB_LINK_BOM : int
    {
        IxMaxCt = 19,		// ÀÎµ¦½º Count 
        //		IxFACTORY =1,			// °øÀå	:VARCHAR2(5) 
        //		IxBOM_CD =2,			// BOM ÄÚµå	:VARCHAR2(10) 
        //		IxLINK_SEQ =3,			// ¸µÅ© ¼ø¹ø	:VARCHAR2(10) 
        IxORG_NODE = 1,			// ¸µÅ©ÇÒ ORIGIN NODE	:VARCHAR2(10) 
        IxDST_NODE = 2,			// ¸µÅ©ÇÒ DESTINATION NODE	:VARCHAR2(10) 
        //		IxPOINT =3,			// ¸µÅ© ÁÂÇ¥Á¡	:VARCHAR2(60) 
        IxARROW_DST = 3,			// ¸µÅ© ³¡ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxARROW_MID = 4,			// ¸µÅ© ²ªÀÎÁ¡ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxARROW_ORG = 5,			// ¸µÅ© Ã¹ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxDASHSTYLE = 6,			// ¸µÅ© ¼± ½ºÅ¸ÀÏ	:VARCHAR2(10) 
        IxDRAWCOLOR = 7,			// ¸µÅ© ¼± »ö±ò	:VARCHAR2(10) 
        IxDRAWWIDTH = 8,			// ¸µÅ© ¼± µÎ²²	:VARCHAR2(10) 
        IxFONT = 9,			// ¸µÅ© À§ ÅØ½ºÆ® ÆùÆ® ¼Ó¼º	:VARCHAR2(60) 
        IxJUMP = 10,			// JUMP ¼Ó¼º	:VARCHAR2(10) 
        IxLINE_STYLE = 11,			// ¶óÀÎ ½ºÅ¸ÀÏ (¿¹ : °î¼±, Á÷¼± µî)	:VARCHAR2(10) 
        IxLINE_ROUND = 12,			// ¶óÀÎ ¶ó¿îµå ¼Ó¼º : ¸µÅ© ²ªÀÎÁ¡ ºÎºÐ ¶ó¿îµå Ã³¸® ¿©ºÎ	:VARCHAR2(10) 
        IxTAG = 13,			// ÅÂ±× ¼Ó¼º	:VARCHAR2(60) 
        IxTEXT = 14,			// ÅØ½ºÆ®	:VARCHAR2(60) 
        IxTEXTCOLOR = 15,			// ÅØ½ºÆ® »ö±ò	:VARCHAR2(10) 
        IxTOOLTIP = 16,			// ÅøÆÁ	:VARCHAR2(60) 
        IxUPD_USER = 17,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxUPD_YMD = 18,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
    }

    public enum TBSXP_PUR_VENDOR : int
    {
        xMaxCt = 13,		// ÀÎµ¦½º COUNT 
        IxFACTORY = 1,			// °øÀåÄÚµå	:VARCHAR2(5) 
        lxMAT_CD = 2,
        IxVEN_SEQ = 3,			// VEN_SEQ	:NUMBER(22) 
        IxPOPULA_NAME = 4,			// POPULA_NAME	:VARCHAR2(200) 
        IxVENDOR = 5,			// °Å·¡Ã³ÄÚµå	:VARCHAR2(200) 
        IxCURRENCY_DIV = 6,			// 	:VARCHAR2(10) 
        IxFOB_PRICE = 7,			// 	:NUMBER(22) 
        IxCBD_PRICE = 8,			// 	:NUMBER(22) 
        IxPUR_PRICE = 9,			// 	:NUMBER(22) 
        IxNIKE_FLG = 10,			// 	:VARCHAR2(1) 
        IxSTATUS = 11,			// »óÅÂ	:VARCHAR2(1) 
        IxUPD_USER = 12,			// ÀÛ¼ºÀÚ	:VARCHAR2(30) 
        IxUPD_YMD = 13,			// ÀÛ¼ºÀÏ	:DATE(7) 
    }

    public enum TBSXO_MAT_INFO : int
    {
        IxMaxCt = 7,		// ÀÎµ¦½º Count 
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxMAT_CD = 2,
        IxMAT_NAME = 3,
        IxCOLOR_CD = 4,
        IxCOLOR_DESC = 5,
        IxPCC_UNIT_CD = 6,
        IxPCC_SPEC_CD = 7,
        IxPCC_SPEC_NAME = 8,
        IxYIELD_VALUE = 9,
        IxORD_QTY = 10,
        IxPROD_YIELD = 11,
        IxVALUE_PUR = 12,
        IxVALUE_IN = 13,
        IxVALUE_STOCK = 14,

    }

    public enum TBSXO_OUT_SCH : int
    {
        IxMaxCt = 39,		

        IxDIVISION         = 0,
        IxFACTORY          = 1,
        IxLOT_NO           = 2,
        IxLOT_SEQ          = 3,
        IxDAY_SEQ          = 4,
        IxLINE_CD          = 5,
        IxCMP_CD           = 6,
        IxOP_CD            = 7,
        IxSR_NO            = 8,
        IxSRF_NO           = 9,
        IxBOM_ID           = 10,
        IxBOM_REV          = 11,
        IxCATEGORY         = 12,
        IxSEASON_CD        = 13,
        IxSTYLE_NAME       = 14,
        IxPLAN_YMD         = 15,
        IxSTATUS           = 16,        
        IxPRINT_CHK        = 17,
        IxTAG_CHK          = 18,
        IxFORMULA_CHK      = 19,
        IxCAT              = 20,
        IxSEASON           = 21,
        IxMODEL_NAME       = 22,
        IxCOLOR_VER        = 23,
        IxBOM_STYLECD      = 24,
        IxGEN_SIZE         = 25,
        IxSAMPLE_TYPE      = 26,
        IxREQ_YMD          = 27,
        IxWORK_QTY         = 28,
        IxWORK_DATE        = 29,
        IxMAT_YMD          = 30,
        IxIPW_YMD          = 31,
        IxCDC_DEV_NAME     = 32,
        IxOP_NAME          = 33,
        IxREMARKS          = 34,        
        IxTAG_COMMENT      = 35,
        IxSORT_NO          = 36,
        IxPCARD_YN         = 37,
        IxPCARD_STATUS     = 38

        //IxDIVISION         = 0,
        //IxFACTORY          = 1,
        //IxLOT_NO           = 2,
        //IxLOT_SEQ          = 3,
        //IxDAY_SEQ          = 4,
        //IxLINE_CD          = 5,
        //IxCMP_CD           = 6,
        //IxOP_CD            = 7,
        //IxSR_NO            = 8,
        //IxSRF_NO           = 9,
        //IxBOM_ID           = 10,
        //IxBOM_REV          = 11,
        //IxCATEGORY         = 12,
        //IxSEASON_CD        = 13,
        //IxSTYLE_NAME       = 14,
        //IxPLAN_YMD         = 15,
        //IxPRINT_CHK        = 16,
        //IxTAG_CHK          = 17,
        //IxFORMULA_CHK      = 18,
        //IxCAT              = 19,
        //IxSEASON           = 20,
        //IxMODEL_NAME       = 21,
        //IxCOLOR_VER        = 22,
        //IxBOM_STYLECD      = 23,
        //IxGEN_SIZE         = 24,
        //IxSAMPLE_TYPE      = 25,
        //IxREQ_YMD          = 26,
        //IxWORK_QTY         = 27,
        //IxWORK_DATE        = 28,
        //IxMAT_YMD          = 29,
        //IxIPW_YMD          = 30,
        //IxCDC_DEV_NAME     = 31,
        //IxOP_NAME          = 32,
        //IxREMARKS          = 33,
        //IxSTATUS           = 34,        
        //IxTAG_COMMENT      = 35,
        //IxSORT_NO          = 36,
        //IxPCARD_YN         = 37,
        //IxPCARD_STATUS     = 38,
            
    }

    public enum TBSXO_OUT_SCH_POP : int
    {
        IxMaxCt = 18,		// ÀÎµ¦½º Count 

        IxDIVISION    = 0,
        IxPRINT_CHK   = 1,
        IxFACTORY     = 2,
        IxMODEL       = 3,
        IxCOLOR_VER   = 4,
        IxBOM_STYLE   = 5,
        IxSAMPLE_TYPE = 6,
        IxUSER        = 7,
        IxOP_NAME     = 8,
        IxQTY         = 9,
        IxLOT_NO      = 10,
        IxLOT_SEQ     = 11,
        IxDAY_SEQ     = 12,
        IxLINE_CD     = 13,
        IxCMP_CD      = 14,
        IxOP_CD       = 15,
        IxUPS_USER    = 16,
        IxREMARKS     = 17,

    }

    public enum TBSXE_LOT : int
    {
        IxDIVISION = 0,
        IxFACTORY = 1,

        IxSET_CHK = 2,
        IxBOM_CD = 3,
        IxLOT_NO = 4,
        IxLOT_SEQ = 5,
        IxSTYLE_CD = 6,
        IxSTYLE_NAME = 7,
        IxLOT_INFO = 8,
        IxNF_CD = 9,

    }

    public enum TBSXO_OUT_MAT_LIST : int
    {
        IxMaxCt = 18,		// ÀÎµ¦½º Count 
        
        
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxCATEGORY = 2,
        IxSEASON_CD = 3,  
        IxLOT_NO = 4,
        IxLOT_SEQ = 5,
        IxTREE_LEV = 6,       
        IxCOL_1 = 7,
        IxCOL_2 = 8,
        IxCOL_3 = 9,
        IxCOL_4 = 10,
        IxCOL_5 = 11,
        IxCOL_6 = 12,
        IxCOL_7 = 13,
        IxCOL_8 = 14,
        IxCOL_9 = 15,
        IxCOL_10 = 16,
        IxCOL_11 = 17,
        IxCOL_12 = 18,
        IxCOL_13 = 19,
        IxCOL_14 = 20,
        IxCOL_15 = 21,        
    }

    public enum TBSXO_REQ_TAIL : int
    {
        IxMaxCt = 19,		// ÀÎµ¦½º Count 
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxREQ_YMD = 2,
        IxMAT_CD = 3,
        IxPCC_SPEC_CD = 4,
        IxCOLOR_CD = 5,
        IxMAT_NAME_KEY = 6,
        IxSPEC_NAME_KEY = 7,
        IxCOLOR_NAME_KEY = 8,
        IxLOT_NO = 9,
        IxLOT_SEQ = 10,
        IxT_LEV = 11,
        IxCOL1 = 12,
        IxCOL2 = 13,
        IxOUT_YN = 14,
        IxCOL3 = 15,
        IxCOL4 = 16,
        IxCOL5 = 17,
        IxCOL6 = 18,
        IxCOL7 = 19,
        IxCOL8 = 20,
        IxCOL9 = 21,
        IxCOL10 = 22,
        IxCOL11 = 23,
        IxCOL12 = 24,
        IxCOL13 = 25,
        IxCOL14 = 26,
        IxREMARKS = 27,
    }

    public enum TBSXO_OUT_TAIL : int
    {
        IxMaxCt = 18,		// ÀÎµ¦½º Count 
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxSTATUS = 2,
        IxOUT_DEPT = 3,
        IxOUT_DEPT_DESC = 4,
        IxOUT_USER = 5,
        IxOUT_YMD = 6,
        IxOUT_NO = 7,
        IxOUT_DIV = 8,
        IxMAT_CD = 9,
        IxMAT_NAME = 10,
        IxMAT_COMMENT = 11,
        IxCOLOR_CD = 12,
        IxCOLOR_NAME = 13,
        IxPCC_SPEC_CD = 14,
        IxSPEC_NAME = 15,
        IxREAL_VALUE = 16,
        IxREMARKS = 17,
    }

    public enum TBSXD_PART_INFO : int
    {
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxDEV_NAME = 2,
        IxCHK = 3,
        IxSR_NO = 4,
        IxSRF_NO = 5,
        IxBOM_ID = 6,
        IxBOM_REV = 7,
        IxNF_CD = 8,

    }

    public enum TBSXD_PART_INFO1 : int
    {
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxPART_TYPE = 2,
        IxPART_DESC = 3,
        IxT_LEV = 4,
        IxCOL1 = 5,
        IxCOL2 = 6,
        IxCOL3 = 7,
        IxCOL4 = 8,
        IxCOL5 = 9,
        IxCOL6 = 10,
        IxCOL7 = 11,

    }

    public enum TBSXD_PART_INFO2 : int
    {
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxSR_NO = 2,
        IxSRF_NO = 3,
        IxBOM_ID = 4,
        IxBOM_REV = 5,
        IxNF_CD = 6,
        IxT_LEV = 7,
        IxCOL1 = 8,
        IxCOL2 = 9,
        IxCOL3 = 10,
        IxCOL4 = 11,
        IxCOL5 = 12,

    }

    public enum TBSELECT_MAT_PURSUIT_00 : int
    {
        IxDIVISION       = 0,
        IxFACTORY        = 1,
        IxLOT_NO         = 2,
        IxLOT_SEQ        = 3,
        IxSORT_NO        = 4,
        IxMAT_CD         = 5,
        IxPCC_SPEC_CD    = 6,
        IxCOLOR_CD       = 7,
        IxSR_NO          = 8,
        IxSRF_NO         = 9,
        IxBOM_ID         = 10,
        IxBOM_REV        = 11,
        IxNF_CD          = 12,
        IxPART_NO        = 13,
        IxPART_DESC      = 14,
        IxMAT_NAME       = 15,
        IxSPEC_DESC      = 16,
        IxCOLOR_DESC     = 17,
        IxVALUE_CURR_PUR = 18,
        IxMRP_NO         = 19,
        IxMRP_YMD        = 20,

    }

    public enum TBSELECT_MAT_PURSUIT_01 : int
    {
        IxFACTORY     = 0,
        IxLOT_NO      = 1,
        IxLOT_SEQ     = 2,
        IxPART_NO     = 3,
        IxMAT_CD      = 4,
        IxPCC_SPEC_CD = 5,
        IxCOLOR_CD    = 6,
        IxMRP_NO      = 7,
        IxMRP_YMD     = 8,
        IxPUR_NO      = 9,
        IxPUR_YMD     = 10,
        IxETC_YMD     = 11,
        IxIN_NO       = 12,
        IxIN_YMD      = 13,
        IxSHIP_NO     = 14,
        IxSHIP_YMD    = 15,
        IxETA_YMD     = 16,

    }

    public enum TBSXP_MAT_RERSULT : int
    {
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxLOT_NO = 2,
        IxLOT_SEQ = 3,
        IxSORT_NO = 4,
        IxMAT_CD = 5,
        IxPCC_SPEC_CD = 6,
        IxCOLOR_CD = 7,
        IxSR_NO = 8,
        IxSRF_NO = 9,
        IxBOM_ID = 10,
        IxBOM_REV = 11,
        IxNF_CD = 12,
        IxPART_NO = 13,
        IxPART_DESC = 14,
        IxMAT_NAME = 15,
        IxSPEC_DESC = 16,
        IxCOLOR_DESC = 17,
        IxVALUE_CURR_PUR = 18,
        IxPUR_FLG = 19,
        IxPUR_DIV = 20,
        IxMRP_NO = 21,
        IxMRP_YMD = 22,
        IxPUR_NO = 23,
        IxPUR_YMD = 24,
        IxETC_YMD = 25,
        IxIN_NO = 26,
        IxIN_YMD = 27,
        IxSHIP_NO = 28,
        IxSHIP_YMD = 29,
        IxETA_YMD = 30,

    }
    
    public enum TBSXG_PROD_BAR : int
    {
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxLOT_NO = 2,
        IxLOT_SEQ = 3,
        IxDAY_SEQ = 4,
        IxLINE_CD = 5,
        IxT_LEVEL = 6,
        IxSR_NO = 7,
        IxSRF_NO = 8,
        IxBOM_ID = 9,
        IxBOM_REV = 10,
        IxNF_CD = 11,
        IxSIZE_CD = 12,
        IxDIR_QTY = 13,
        IxDIR_YMD = 14,

    }

    public enum DBSELECT_SXG_PROD_OP_INFO : int
    {       
       
        IxBAR_CODE = 0,
        IxDIR_YMD = 1,
        IxREMARKS = 2,
        IxCDC_DEV_NAME = 3,
        IxDIR_QTY = 4,
        IxSCAN_QTY = 5,

        
        IxSR_NO = 6,
        IxSRF_NO = 7,
        IxBOM_ID = 8,
        IxBOM_REV = 9,
        IxSTYLE_CD = 10,
        IxSTYLE_NAME = 11,
        IxCOLOR_VER = 12,
        IxCATEGORY = 13,
        IxSEASON_CD = 14,
        IxNEED_BY = 15,
        IxETS = 16,
        IxPROD_QTY = 17,

    }

    public enum DBSELECT_SXG_PROD_OP_LIST : int
    {
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxLINE_CD = 2,
        IxOP_CD = 3,
        IxOP_NAME = 4,
        IxLOT_NO = 5,
        IxLOT_SEQ = 6,

        IxSR_NO = 7,
        IxSRF_NO = 8,
        IxBOM_ID = 9,
        IxBOM_REV = 10,
        IxNF_CD = 11,

        IxDAY_SEQ = 12,
        IxBAR_CODE = 13,
        IxSTATUS = 14,
        IxDIR_YMD = 15,
        IxRST_YMD = 16,
        IxDIR_QTY = 17,
        IxRST_QTY = 18,
    }

    public enum DBSELECT_SXG_PROD_ALL_OP_LIST : int
    {
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxLINE_CD = 2,
        IxLOT_NO = 3,
        IxLOT_SEQ = 4,
        IxDAY_SEQ = 5,

        IxSR_NO = 6,
        IxSRF_NO = 7,
        IxBOM_ID = 8,
        IxBOM_REV = 9,
        IxNF_CD = 10,

        IxSTATUS = 11,
        IxBAR_CODE = 12,
        IxPLAN_YMD = 13,
        IxPLAN_QTY = 14,

        IxLINE_CD_S = 15,
        IxLOT_NO_S = 16,
        IxLOT_SEQ_S = 17,
        IxDAY_SEQ_S = 18,


        IxPROD_OK = 19,
        IxSTATUS_S = 20,
        IxBAR_CODE_S = 21,
        IxPLAN_YMD_S = 22,
        IxPLAN_QTY_S = 23,


        IxT_VALUE = 24,
        IxT_LEVEL = 25,

        IxOP_CD = 26,
        IxDIR_YMD = 27,
        IxDIR_QTY = 28,

    }
    #endregion

    #endregion

    #region MRP
    public enum TBSXD_MRP_MANAGER : int
    {
        IxMaxCt = 28,		     // ÀÎµ¦½º Count

        lxFACTORY = 1,
        lxITEM_01 = 2,       //mat div - bom info		
        lxITEM_02 = 3,  		//style nanme 
        lxITEM_03 = 4, 		//category - season
        lxITEM_04 = 5, 		//sample types
        lxITEM_05 = 6, 		//size
        lxCATEGORY = 7,
        lxSEASON_CD = 8,
        lxSR_NO = 9,
        lxSRF_NO = 10,
        lxBOM_ID = 11,
        lxBOM_REV = 12,
        lxNF_CD = 13,
        lxLOT_NO = 14,
        lxLOT_SEQ = 15,
        lxCS_SIZE = 16,
        lxMAT_DIV = 17,
        lxPUR_FLG = 18,
        lxPUR_DESC = 19,
        lxMRP_FLG = 20,
        lxSTATUS = 21,
        lxSTATUS_DESC = 22,
        lxQTY_CURR_PALN = 23,
        lxQTY_CURR_PUR = 24,
        lxQTY_ADD_PUR = 25,
        lxREMARK = 26,
        lxLOAD_UPD_USER = 27,
        lxLOAD_UPD_YMD = 28,
    }
    public enum TBSXD_ERR_CHECK_ERROR_LEVEL : int
    {
        IxMaxCt = 33,	     // ÀÎµ¦½º Count

        lxLEVELS = 1,
        lxFACTORY = 2,
        lxITEM_01 = 3,
        lxITEM_02 = 4,
        lxITEM_03 = 5,
        lxITEM_04 = 6,
        lxITEM_05 = 7,
        lxMAT_CD = 8,
        lxMAT_COMMENT_SEQ = 9,
        lxCOLOR_CD = 10,
        lxPCC_UNIT = 11,
        lxPCC_SPEC = 12,
        lxPCC_SPEC_NAME = 13,
        lxMAT_DIV = 14,
        lxMAT_DIV_DESC = 15,
        lxYIELD_VALUE = 16,
        lxLOSS_VALUE = 17,
        lxCOMMON_YN = 18,
        lxCBD_PRICE = 19,
        lxREMARKS = 20,
        lxSR_NO = 21,
        lxSRF_NO = 22,
        lxBOM_ID = 23,
        lxBOM_REV = 24,
        lxNF_CD = 25,
        lxLOT_NO = 26,
        lxLOT_SEQ = 27,
        lxSRF_SEQ = 28,
        lxPART_SEQ = 29,
        lxPART_NO = 30,
        lxCATEGORY = 31,
        lxSEASON_CD = 32,
        lxCOL_ORDER = 33,
    }
    public enum TBSXD_ERR_CHECK_MRP : int
    {
        IxMaxCt = 4,		     // ÀÎµ¦½º Count
        
        lxFACTORY = 1,
        lxMRP_YN = 2,
        lxMAT_CD = 3,
        lxMAT_NAME = 4,
    }
    public enum TBSXD_ERR_CHECK_OA : int
    {
        IxMaxCt = 51,		     // ÀÎµ¦½º Count

        lxLEVEL = 1,
        lxFACTORY = 2,
        lxITEM_01 = 3,
        lxITEM_02 = 4,
        lxITEM_03 = 5,
        lxITEM_04 = 6,
        lxITEM_05 = 7,
        lxCATEGORY = 8,
        lxSEASON_CD = 9,
        lxPUR_FLG = 10,
        lxPUR_DESC = 11,
        lxMRP_FLG = 12,
        lxSTATUS = 13,
        lxSTATUS_DESC = 14,
        lxPCC_UNIT_CD = 15,
        lxMCS_CD = 16,
        lxCOMMON_YN = 17,
        lxCBD_PRICE = 18,
        lxPRICE_YN = 19,
        lxPURCHASE_YN = 20,
        TRANSPORT_TYPE = 21,
        lxYIELD_VALUE = 22,
        lxLOSS_VALUE = 23,
        lxUSAGE_VALUE = 24,
        lxPUR_RATE = 25,
        lxMAT_RATE = 26,
        lxQTY_BEFO_PUR = 27,
        lxQTY_CURR_PLAN = 28,
        lxQTY_CURR_PUR = 29,
        lxQTY_ADD_PUR = 30,
        lxSR_NO = 31,
        lxSRF_NO = 32,
        lxBOM_ID = 33,
        lxBOM_REV = 34,
        lxNF_CD = 35,
        lxMRP_NO = 36,
        lxLOT_NO = 37,
        lxLOT_SEQ = 38,
        lxCS_SIZE = 39,
        lxPUR_DIV = 40,
        lxPART_SEQ = 41,
        lxSRF_SEQ = 42,
        lxPART_NO = 43,
        lxMAT_CD = 44,
        lxMAT_COMMENT_SEQ = 45,
        lxPCC_SPEC_CD = 46,
        lxCOLOR_CD = 47,
        lxREMARKS = 48,
        lxLOAD_USER = 49,
        lxLOAD_DATE = 50,
        lxCOL_ORDER = 51,



    }
    public enum TBSXD_MRP_ITEM_01 : int
    {
        IxMaxCt = 60,		     // ÀÎµ¦½º Count

        lxLEVEL = 1,
        lxFACTORY = 2,
        lxITEM_01 = 3,
        lxITEM_02 = 4,
        lxITEM_03 = 5,
        lxITEM_04 = 6,
        lxITEM_05 = 7,
        lxSTATUS = 8,
        lxSTATUS_DESC = 9,
        lxCATEGORY = 10,
        lxSEASON_CD = 11,
        lxPUR_FLG = 12,
        lxPUR_DESC = 13,
        lxMRP_FLG = 14,
        lxPCC_UNIT_CD = 15,
        lxMCS_CD = 16,
        lxCOMMON_YN = 17,
        lxCBD_PRICE = 18,
        lxPRICE_YN = 19,
        lxYIELD_VALUE = 20,
        lxLOSS_VALUE = 21,
        lxUSAGE_VALUE = 22,
        lxPUR_RATE = 23,
        lxMAT_RATE = 24,
        lxQTY_BEFO_PUR = 25,
        lxQTY_CURR_PLAN = 26,
        lxQTY_CURR_PUR = 27,
        lxQTY_ADD_PUR = 28,
        lxVALUE_CURR_PLAN = 29,
        lxVALUE_CURR_PUR = 30,
        lxVALUE_ADD_PUR = 31,
        lxVALUE_EST_STOCK = 32,
        lxVALUE_REAL_NEED = 33,
        lxVALUE_SAFT_STOCK = 34,
        lxALUE_PACK_NEED = 35,
        lxVALUE_ADV_PUR = 36,
        lxVALUE_ADJ_PUR = 37,
        lxVALUE_CONF_PUR = 38,
        lxSR_NO = 39,
        lxSRF_NO = 40,
        lxBOM_ID = 41,
        lxBOM_REV = 42,
        lxNF_CD = 43,
        lxLOT_NO = 44,
        lxLOT_SEQ = 45,
        lxCS_SIZE = 46,
        lxMAT_DIV = 47,
        lxPART_SEQ = 48,
        lxSRF_SEQ = 49,
        lxPART_NO = 50,
        lxMAT_CD = 51,
        lxMAT_COMMENT_SEQ = 52,
        lxPCC_SPEC_CD = 53,
        lxCOLOR_CD = 54,
        lxPURCHASE_YN = 55,
        lxTRANSPORT_TYPE = 56,
        lxPUR_DIV = 57,
        lxPUR_USER = 58,
        lxREMARKS = 59,
        lxLOAD_USER = 60,
        lxLOAD_DATE = 61,
        lxCOL_ORDER = 62,


    }
    public enum TBSXD_MRP_ITEM_02 : int
    {
        IxMaxCt = 60,		     // ÀÎµ¦½º Count

        lxLEVEL = 1,
        lxFACTORY = 2,
        lxITEM_01 = 3,
        lxITEM_02 = 4,
        lxITEM_03 = 5,
        lxITEM_04 = 6,
        lxITEM_05 = 7,
        lxSTATUS = 8,
        lxSTATUS_DESC = 9,
        lxCATEGORY = 10,
        lxSEASON_CD = 11,
        lxPUR_FLG = 12,
        lxPUR_DESC = 13,
        lxMRP_FLG = 14,
        lxPCC_UNIT_CD = 15,
        lxMCS_CD = 16,
        lxCOMMON_YN = 17,
        lxCBD_PRICE = 18,
        lxPRICE_YN = 19,
        lxYIELD_VALUE = 20,
        lxLOSS_VALUE = 21,
        lxUSAGE_VALUE = 22,
        lxPUR_RATE = 23,
        lxMAT_RATE = 24,
        lxQTY_BEFO_PUR = 25,
        lxQTY_CURR_PLAN = 26,
        lxQTY_CURR_PUR = 27,
        lxQTY_ADD_PUR = 28,
        lxVALUE_CURR_PLAN = 29,
        lxVALUE_CURR_PUR = 30,
        lxVALUE_ADD_PUR = 31,
        lxVALUE_EST_STOCK = 32,
        lxVALUE_REAL_NEED = 33,
        lxVALUE_SAFT_STOCK = 34,
        lxALUE_PACK_NEED = 35,
        lxVALUE_ADV_PUR = 36,
        lxVALUE_ADJ_PUR = 37,
        lxVALUE_CONF_PUR = 38,
        lxSR_NO = 39,
        lxSRF_NO = 40,
        lxBOM_ID = 41,
        lxBOM_REV = 42,
        lxNF_CD = 43,
        lxLOT_NO = 44,
        lxLOT_SEQ = 45,
        lxCS_SIZE = 46,
        lxMAT_DIV = 47,
        lxPART_SEQ = 48,
        lxSRF_SEQ = 49,
        lxPART_NO = 50,
        lxMAT_CD = 51,
        lxMAT_COMMENT_SEQ = 52,
        lxPCC_SPEC_CD = 53,
        lxCOLOR_CD = 54,
        lxPURCHASE_YN = 55,
        lxTRANSPORT_TYPE = 56,
        lxPUR_DIV = 57,
        lxPUR_USER = 58,
        lxREMARKS = 59,
        lxLOAD_USER = 60,
        lxLOAD_DATE = 61,
        lxCOL_ORDER = 62,

    }
    public enum TBSXD_MRP_REQ_MAST : int
    {
        IxMaxCt = 60,		     // ÀÎµ¦½º Count



        lxLEVEL = 1,
        lxFACTORY = 2,
        lxITEM_01 = 3,
        lxITEM_02 = 4,
        lxITEM_03 = 5,
        lxITEM_04 = 6,
        lxITEM_05 = 7,
        lxCATEGORY = 8,
        lxSEASON = 9,
        lxPCC_UNIT_CD = 10,

        lxMCS_CD = 11,
        lxCOMMON_YN = 12,
        lxCBD_PRICE = 13,
        lxCDB_CURRENCY = 14,        
        lxPURCHASE_YN = 15,
        lxPUR_DIV = 16,
        lxTRANSPORT = 17,
        lxPRICE_YN = 18,
        lxSTYLE_ITEM_DIV = 19,
        lxYIELD_VALUE = 20,

        lxLOSS_VALUE = 21,
        lxUSAGE_VALUE = 22,
        lxQTY_CURR_PUR = 23,
        lxVALUE_CURR_PUR = 24,
        lxSIZE_CD = 25,
        lxSORT_NO = 26,
        lxPART_SEQ = 27,
        lxSR_NO = 28,
        lxSRF_SEQ = 29,
        lxBOM_ID = 30,

        lxBOM_REV = 31,
        lxMRP_SEQ = 32,
        lxMRP_NO = 33,
        lxLOT_NO = 34,
        lxLOT_SEQ = 35,
        lxPART_NO = 36,
        lxMAT_CD = 37,
        lxMAT_COMMENT_SEQ = 38,
        lxPCC_SPEC_CD = 39,
        lxCOLOR_CD = 40,
        lxREQ_DIV = 41,

        lxREQ_REASON = 42,
        lxREQ_NO = 43,
        lxREQ_SEQ = 44,
        lxREQ_DEPT = 45,
        lxREQ_USER = 46,
        lxUSE_DEPT = 47,
        lxSTYLE_CD = 48,
        lxSTYLE_NAME = 49,
        lxNF_CD = 50,
        lxRTA_YMD = 51,

        lxETC_YMD = 52,
        lxMRP_REQ_FLG = 53,
        lxPUR_FLG = 54,
        lxSEND_CHK = 55,
        lxSEND_YMD = 56,
        lxBOM_STATUS = 57,
        lxREMARKS = 58,
        lxUPD_USER = 59,
        lxUPD_YMD = 60,
        lxCOL_ORDER = 61,



    }
    #endregion
    
    #region Purchase
    #region New Version
    public enum TBSXP_PUR_MANAGER_NEW : int
    {
        IxMaxCt = 29,
	
        IxDIV             = 0,        
        IxFACTORY         = 1,
        IxMRP_SEQ         = 2,
        IxSTATUS_SORT     = 3,
        IxMRP_REQ_FLG     = 4,
        IxP_USER          = 5,
        IxPUR_DIV         = 6,
        IxMAT_NAME        = 7,
        IxMAT_CD          = 8, 
        IxCOLOR_CD        = 9, 
        IxPCC_SPEC_CD     = 10,     
        IxT_LEVEL         = 11,
        IxPUR_USER        = 12,
        IxSTATUS          = 13,
        IxMRP_TYPE        = 14,
        IxPUR_DIV_NAME    = 15,
        IxITEM_01         = 16,
        IxITEM_02         = 17,
        IxITEM_03         = 18,
        IxITEM_04         = 19,
        IxITEM_05         = 20,
        IxMCS_CD          = 21,
        IxRTA_YMD         = 22,
        IxETC_YMD         = 23,
        lxQTY_CURR_PUR    = 24,
        IxVALUE_CURR_PUR  = 25,
        IxPUR_NO          = 26,
        IxREMARKS         = 27,
        IxUPD_USER        = 28,
        IxUPD_YMD         = 29,
    }

    public enum TBSXP_PUR_MANAGER_NEW_02 : int
    {
        IxMaxCt = 32,
	
        IxDIV             = 0,        
        IxFACTORY         = 1,
        IxMRP_SEQ         = 2,
        IxSTATUS_SORT     = 3,
        IxMRP_REQ_FLG     = 4,
        IxPUR_USER        = 5,
        IxPUR_DIV         = 6,        
        IxMAT_NAME        = 7, 
        IxMAT_CD          = 8, 
        IxMAT_COMMENT     = 9,
        IxCOLOR_CD        = 10,
        IxCOLOR_COMMENT   = 11,
        IxPCC_SPEC_CD     = 12,
        IxMAT_SUB_FLG     = 13,
        IxT_LEVEL         = 14,
        IxP_USER          = 15,
        IxSTATUS          = 16,        
        IxMRP_TYPE        = 17,
        IxPUR_DIV_V       = 18,
        IxITEM_01         = 19,
        IxITEM_02         = 20,
        IxITEM_03         = 21,
        IxITEM_04         = 22,
        IxITEM_05         = 23,
        IxITEM_06         = 24,
        lxMCS_CD          = 25,
        IxRTA_YMD         = 26,
        IxETC_YMD         = 27,
        IxQTY_CURR_PUR    = 28,
        IxVALUE_CURR_PUR  = 29,
        IxPUR_NO          = 30,
        IxMAT_SUB_FLG_V   = 31,
        IxREMARKS         = 22,
        IxUPD_USER        = 23,
        IxUPD_YMD         = 24,             
    }

    public enum TBSXP_PUR_ORDER_NEW : int
    {
        IxMaxCt = 49,		// ÀÎµ¦½º Count 

        IxDIVISION         = 0,
        IxT_LEVEL          = 1,	
        IxFACTORY          = 2,			
        IxPUR_NO           = 3,			
        IxMRP_REQ_FLG      = 4,			
        IxPUR_DIV          = 5,			
        IxSRF_NO           = 6,			
        IxMAT_NAME_V       = 7,			
        IxMAT_CD           = 8,		
        IxMAT_CMT          = 9,	
        IxPCC_SPEC_CD      = 10,		
        IxCOLOR_CD         = 11,			
        IxCOLOR_CMT        = 12,
        IxPRICE_YN         = 13,			
        IxTRANSPORT_TYPE   = 14,			        			
        IxSTATUS           = 15,			
        IxPUR_USER         = 16,			
        IxPUR_NO_V         = 17,			
        IxMRP_REQ_FLG_V    = 18,			
        IxPUR_DIV_V        = 19,			
        IxMAT_NAME         = 20,			
        IxMAT_COMMENT      = 21,			
        IxPCC_SPEC_NAME    = 22,			
        IxCOLOR_NAME       = 23,			
        IxCOLOR_COMMENT    = 24,
        IxPCC_UNIT_CD      = 25,			
        IxMCS_CD           = 26,			
        IxPUR_DIV_E        = 27,
        IxVEN_SEQ          = 28,			
        IxVEN_NAME         = 29,			        
        IxVALUE_PUR        = 30,
        IxRTA_YMD          = 31,
        IxETC_YMD          = 32,
        IxBAR_CODE         = 33,        
        IxPUR_PRICE        = 34,		
        IxPUR_CURRENCY     = 35,		
        IxCBD_PRICE        = 36,		
        IxCBD_CURRCNCY     = 37,		
        IxCOMMON_YN        = 38,		
        IxPRICE_YN_V       = 39,		
        IxTRANSPORT_TYPE_V = 40,        
        IxREQ_DIV          = 41,
        IxREQ_REASON       = 42,
        IxREQ_NO           = 43,
        IxREQ_DEPT         = 44,
        IxREQ_USER         = 45,
        IxREMARKS          = 46,
        IxUPD_USER         = 47,
        IxUPD_YMD          = 48,
    }

    public enum TBSXP_PUR_ORDER_NEW_02 : int
    {
        IxMaxCt = 51,		// ÀÎµ¦½º Count 

        IxDIVISION         = 0,
        IxT_LEVEL          = 1,	
        IxFACTORY          = 2,			
        IxPUR_NO           = 3,			
        IxMRP_REQ_FLG      = 4,			
        IxPUR_DIV          = 5,			
        IxSRF_NO           = 6,			
        IxMAT_NAME_V       = 7,			
        IxMAT_CD           = 8,		
        IxMAT_CMT          = 9,	
        IxPCC_SPEC_CD      = 10,		
        IxCOLOR_CD         = 11,			
        IxCOLOR_CMT        = 12,
        IxPRICE_YN         = 13,			
        IxTRANSPORT_TYPE   = 14,
        IxMAT_SUB_FLG_V    = 15,
        IxSTATUS           = 16,			
        IxPUR_USER         = 17,			
        IxPUR_NO_V         = 18,			
        IxMRP_REQ_FLG_V    = 19,			
        IxPUR_DIV_V        = 20,			
        IxMAT_NAME         = 21,			
        IxMAT_COMMENT      = 22,			
        IxPCC_SPEC_NAME    = 23,			
        IxCOLOR_NAME       = 24,			
        IxCOLOR_COMMENT    = 25,
        IxPCC_UNIT_CD      = 26,			
        IxMCS_CD           = 27,
		IxMAT_SUB_FLG      = 28,	
        IxPUR_DIV_E        = 29,
        IxVEN_SEQ          = 30,			
        IxVEN_NAME         = 31,			        
        IxVALUE_PUR        = 32,
        IxRTA_YMD          = 33,
        IxETC_YMD          = 34,
        IxBAR_CODE         = 35,        
        IxPUR_PRICE        = 36,		
        IxPUR_CURRENCY     = 37,		
        IxCBD_PRICE        = 38,		
        IxCBD_CURRCNCY     = 39,		
        IxCOMMON_YN        = 40,		
        IxPRICE_YN_V       = 41,		
        IxTRANSPORT_TYPE_V = 42,        
        IxREQ_DIV          = 43,
        IxREQ_REASON       = 44,
        IxREQ_NO           = 45,
        IxREQ_DEPT         = 46,
        IxREQ_USER         = 47,
        IxREMARKS          = 48,
        IxUPD_USER         = 49,
        IxUPD_YMD          = 50,
    }

    public enum TBSXP_PUR_VENDOR_POP : int
    {
        IxMaxCt = 4,		// ÀÎµ¦½º Count 

        IxDIVISION         = 0,
        IxVEN_SEQ          = 1,
        IxVEN_NAME         = 2,
        IxPOPULA_NAME      = 3,
    }
    #endregion

    public enum TBSXP_PUR_ORDER_LIST : int
    {

        IxMaxCt = 34,

        IxDIV = 0,
        IxFACTORY = 1,
        IxSEASON = 2,
        IxCATEGORY = 3,
        IxPURPOSE = 4,
        IxCDC_DEV = 5,
        IxSTYLE_NAME = 6,
        IxMODEL_CODE = 7,
        IxSTYLE_CD = 8,
        IxMAT_NAME = 9,
        IxMAT_COMMENT = 10,
        IxMAT_CD = 11,
        IxPART_SUM = 12,
        IxMCS_CD = 13,
        IxPUR_PRICE = 14,
        IxCOLOR_DESC = 15,
        IxCOLOR_CD = 16,
        IxVALUE_PUR = 17,
        IxPCC_UNIT_CD = 18,
        IxYIELD_VALUE = 19,
        IxPUR_NO = 20,
        IxBAR_CODE = 21,
        IxPUR_YMD = 22,
        IxRTA_YMD = 23,
        IxETC_YMD = 24,
        IxIN_YMD = 25,
        IxLEADTIME = 26,
        IxVENDOR_DESC = 27,
        IxIMP = 28,
        IxREMARKS = 29,
        IxMRP_REQ_FLG = 30,
        IxPCC_SPEC_CD = 31,
        IxUPD_USER = 32,
        IxUPD_YMD = 33,
    }
    public enum TBSXP_PUR_ORDER_LIST_CSC : int
    {

        IxMaxCt = 47,		// ÀÎµ¦½º Count 

        IxDIVISION = 0,			// °øÀå	:VARCHAR2(5) 
        IxFACTORY = 1,			// °øÀå	:VARCHAR2(5) 
        IxPUR_NO = 2,			// °øÀå	:VARCHAR2(5) 
        IxMRP_REQ_FLG = 3,			// BOM ÄÚµå	:VARCHAR2(10) 
        IxPUR_DIV = 4,			// BOM ÄÚµå	:VARCHAR2(10) 
        IxSRF_NO = 5,			// ¸µÅ© ¼ø¹ø	:VARCHAR2(10) 
        IxMAT_CD = 6,			// ¸µÅ©ÇÒ ORIGIN NODE	:VARCHAR2(10) 
        IxMAT_CMT = 7,
        IxPCC_SPEC_CD = 8,			// ¸µÅ©ÇÒ DESTINATION NODE	:VARCHAR2(10) 
        IxCOLOR_CD = 9,			// ¸µÅ© ÁÂÇ¥Á¡	:VARCHAR2(60) 
        IxCOLOR_CMT = 10,
        IxPRICE_YN = 11,			// ¸µÅ© ³¡ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxTRANSPORT_TYPE = 12,			// ¸µÅ© ²ªÀÎÁ¡ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxT_LEVEL = 13,			// ¸µÅ© Ã¹ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxSTATUS = 14,			// ¸µÅ© ¼± ½ºÅ¸ÀÏ	:VARCHAR2(10) 
        IxPUR_USER = 15,			// ¸µÅ© ¼± µÎ²²	:VARCHAR2(10) 
        IxPUR_NO_V = 16,			// ¸µÅ© À§ ÅØ½ºÆ® ÆùÆ® ¼Ó¼º	:VARCHAR2(60) 
        IxMRP_REQ_FLG_V = 17,			// JUMP ¼Ó¼º	:VARCHAR2(10) 
        IxPUR_DIV_V = 18,			// ¶óÀÎ ½ºÅ¸ÀÏ (¿¹ : °î¼±, Á÷¼± µî)	:VARCHAR2(10) 

        IxMAT_NAME = 19,			// ÅØ½ºÆ® »ö±ò	:VARCHAR2(10) 
        IxMAT_COMMENT = 20,			// ÅøÆÁ	:VARCHAR2(60) 
        IxPCC_SPEC_NAME = 21,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxCOLOR_NAME = 22,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
        IxCOLOR_COMMENT = 23,
        IxPCC_UNIT_CD = 24,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
        IxMCS_CD = 25,			// ¶óÀÎ ¶ó¿îµå ¼Ó¼º : ¸µÅ© ²ªÀÎÁ¡ ºÎºÐ ¶ó¿îµå Ã³¸® ¿©ºÎ	:VARCHAR2(10) 
        IxVEN_SEQ = 26,			// ÅÂ±× ¼Ó¼º	:VARCHAR2(60) 
        IxVEN_NAME = 27,			// ÅØ½ºÆ®	:VARCHAR2(60) 
        IxPUR_PRICE = 28,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxPUR_CURRENCY = 29,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxCBD_PRICE = 30,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxCBD_CURRCNCY = 31,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxCOMMON_YN = 32,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxPRICE_YN_V = 33,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxTRANSPORT_TYPE_V = 34,
        IxVALUE_PUR = 35,
        IxRTA_YMD = 36,
        IxETC_YMD = 37,
        IxBAR_CODE = 38,
        IxREQ_DIV = 39,

        IxREQ_REASON = 40,
        IxREQ_NO = 41,
        IxREQ_DEPT = 42,
        IxREQ_USER = 43,

        IxREMARKS = 44,
        IxUPD_USER = 45,
        IxUPD_YMD = 46,
    }
    public enum TBSXP_SWATCH_BOX : int
    {
        IxMaxCt = 33,

        IxDIV = 0,
        IxFACTORY = 1,
        IxSESN = 2,
        IxSAMPLE_TYPES = 3,
        IxDEV_NAME = 4,
        IxDEV_PROD_CD = 5,
        IxCOLOR_VER = 6,
        IxBVTN_PDM = 7,
        IxNLO_DEV = 8,
        IxCHECK = 9,
        IxVALUE_PUR = 10,
        IxMAT_NAME = 11,
        IxMAT_COMMENT = 12,
        IxCOLOR_CD = 13,
        IxCOLOR_COMMENT = 14,
        IxVENDOR_DESC = 15,
        IxPART_DESC = 16,
        IxSR_NO = 17,
        IxSRF_NO = 18,
        IxBOM_ID = 19,
        IxBOM_REV = 20,
        IxNF_CD = 21,
        IxSTYLE_CD = 22,
        IxSRF_SEQ = 23,
        IxPART_NO = 24,
        IxSORT_NO = 25,
        IxMAT_CD = 26,
        IxPCC_SPEC_CD = 27,
        IxPART_SEQ = 28,
        IxVEN_SEQ = 29,
        IxPUR_YMD = 30,
        IxETC_YMD = 31,
        IxIN_YMD = 32,


    }
    public enum TBSXS_BAR_LIST : int
    {
        IxMaxCt = 40,		// ÀÎµ¦½º Count

        IxFACTORY = 0,
        IxFLAG = 1,
        IxBAR_CODE = 2,
        IxPUR_USER = 3,
        IxPUR_NO = 4,
        IxPUR_YMD = 5,
        IxPUR_DIV = 6,
        IxVALUE_PUR = 7,
        IxTRANSPORT_TYPE = 8,
        IxRTA_YMD = 9,
        IxETC_YMD = 10,
        IxSRF_NO = 11,
        IxSTYLE_NAME = 12,
        IxMAT_CD = 13,
        IxMAT_NAME = 14,
        IxMAT_COMMENT = 15,
        IxCOLOR_CD = 16,
        IxCOLOR_DESC = 17,
        IxCOLOR_COMMENT = 18,
        IxPCC_SPEC_CD = 19,
        IxSPEC_DESC = 20,
        IxPCC_UNIT_CD = 21,
        IxVENDOR_DESC = 22,
        IxMRP_REQ_FLG = 23,
        IxPRICE_YN = 24,
        IxQTY_PUR = 25,
        IxSHIP_QTY = 26,
        IxCT_QTY = 27,
        IxSHIP_YMD = 28,
        IxPACKING = 29,
        IxPK_NO = 30,
        IxPK_NO_FROM = 31,
        IxPK_NO_TO = 32,
        IxPK_UNIT_QTY = 33,
        IxIN_CHK = 34,
        IxREMARKS = 35,
        IxSEND_CHK = 36,
        IxSEND_YMD = 37,
        IxUPD_USER = 38,
        IxUPD_YMD = 39,

    }

    
    #region Old Version
    public enum TBSXP_PUR_M_VENDOR : int
    {
        IxMaxCt = 4,		    // ÀÎµ¦½º COUNT 
        IxFACTORY = 1,			// °øÀåÄÚµå	:VARCHAR2(5)        
        IxVEN_SEQ = 2,			// VEN_SEQ	:NUMBER(22) 
        IxPOPULA_NAME = 3,		// POPULA_NAME	:VARCHAR2(200) 
        IxVENDOR_DESC = 4,		// °Å·¡Ã³ÄÚµå	:VARCHAR2(200) 
    }
    public enum TBSXP_PUR_ORDER : int
    {
        IxMaxCt = 49,		// ÀÎµ¦½º Count 

        IxDIVISION       = 0,			// °øÀå	:VARCHAR2(5) 
        IxFACTORY        = 1,			// °øÀå	:VARCHAR2(5) 
        IxPUR_NO         = 2,			// °øÀå	:VARCHAR2(5) 
        IxMRP_REQ_FLG    = 3,			// BOM ÄÚµå	:VARCHAR2(10) 
        IxPUR_DIV        = 4,			// BOM ÄÚµå	:VARCHAR2(10) 
        IxSRF_NO         = 5,			// ¸µÅ© ¼ø¹ø	:VARCHAR2(10) 
        IxMAT_NAME_V     = 6,			// ¸µÅ© ¼ø¹ø	:VARCHAR2(10) 
        IxMAT_CD         = 7,			// ¸µÅ©ÇÒ ORIGIN NODE	:VARCHAR2(10) 
        IxMAT_CMT        = 8,
        IxPCC_SPEC_CD    = 9,			// ¸µÅ©ÇÒ DESTINATION NODE	:VARCHAR2(10) 
        IxCOLOR_CD       = 10,			// ¸µÅ© ÁÂÇ¥Á¡	:VARCHAR2(60) 
        IxCOLOR_CMT      = 11,
        IxPRICE_YN       = 12,			// ¸µÅ© ³¡ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxTRANSPORT_TYPE = 13,			// ¸µÅ© ²ªÀÎÁ¡ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxT_LEVEL        = 14,			// ¸µÅ© Ã¹ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxSTATUS         = 15,			// ¸µÅ© ¼± ½ºÅ¸ÀÏ	:VARCHAR2(10) 
        IxPUR_USER       = 16,			// ¸µÅ© ¼± µÎ²²	:VARCHAR2(10) 
        IxPUR_NO_V       = 17,			// ¸µÅ© À§ ÅØ½ºÆ® ÆùÆ® ¼Ó¼º	:VARCHAR2(60) 
        IxMRP_REQ_FLG_V  = 18,			// JUMP ¼Ó¼º	:VARCHAR2(10) 
        IxPUR_DIV_V      = 19,			// ¶óÀÎ ½ºÅ¸ÀÏ (¿¹ : °î¼±, Á÷¼± µî)	:VARCHAR2(10) 

        IxMAT_NAME      = 20,			// ÅØ½ºÆ® »ö±ò	:VARCHAR2(10) 
        IxMAT_COMMENT   = 21,			// ÅøÆÁ	:VARCHAR2(60) 
        IxPCC_SPEC_NAME = 22,			// ÀÛ¼ºÀÚ	:VARCHAR2(10) 
        IxCOLOR_NAME    = 23,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
        IxCOLOR_COMMENT = 24,
        IxPCC_UNIT_CD   = 25,			// ÀÛ¼ºÀÏÀÚ	:DATE(7) 
        IxMCS_CD        = 26,			// ¶óÀÎ ¶ó¿îµå ¼Ó¼º : ¸µÅ© ²ªÀÎÁ¡ ºÎºÐ ¶ó¿îµå Ã³¸® ¿©ºÎ	:VARCHAR2(10) 
        IxPUR_DIV_E     = 27,
        IxVEN_SEQ       = 28,			// ÅÂ±× ¼Ó¼º	:VARCHAR2(60) 
        IxVEN_NAME      = 29,			// ÅØ½ºÆ®	:VARCHAR2(60) 
        
        IxVALUE_PUR     = 30,
        IxRTA_YMD       = 31,
        IxETC_YMD       = 32,
        IxBAR_CODE      = 33,
        
        IxPUR_PRICE        = 34,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxPUR_CURRENCY     = 35,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxCBD_PRICE        = 36,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxCBD_CURRCNCY     = 37,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxCOMMON_YN        = 38,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxPRICE_YN_V       = 39,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxTRANSPORT_TYPE_V = 40,
        
        IxREQ_DIV          = 41,

        IxREQ_REASON       = 42,
        IxREQ_NO           = 43,
        IxREQ_DEPT         = 44,
        IxREQ_USER         = 45,

        IxREMARKS          = 46,
        IxUPD_USER         = 47,
        IxUPD_YMD          = 48,
    }
    public enum TBSXP_PUR_MANAGER : int
    {
        IxMaxCt = 24,		// ÀÎµ¦½º Count 
        IxDIVISION = 0,			// °øÀå	:VARCHAR2(5) 
        IxL_FACTORY = 1,			// °øÀå	:VARCHAR2(5) 
        IxL_STATUS = 2,			// °øÀå	:VARCHAR2(5) 
        IxL_PUR_USER = 3,
        IxL_MRP_REQ_FLG = 4,
        IxL_PUR_DIV = 5,
        IxL_MAT_CD = 6,
        IxL_COLOR_CD = 7,
        IxL_PCC_SPEC_CD = 8,
        IxT_LEVEL = 9,			// BOM ÄÚµå	:VARCHAR2(10) 
        IxPUR_USER = 10,			// ¸µÅ© ¼ø¹ø	:VARCHAR2(10) 
        IxSTATUS = 11,			// ¸µÅ©ÇÒ ORIGIN NODE	:VARCHAR2(10) 
        IxMRP_REQ_FLG = 12,			// ¸µÅ©ÇÒ DESTINATION NODE	:VARCHAR2(10) 
        IxPUR_DIV = 13,			// ¸µÅ© ³¡ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxMAT_NAME = 14,			// ¸µÅ© Ã¹ ½ºÅ¸ÀÏ	:VARCHAR2(60) 
        IxMAT_COMMENT = 15,		// ¸µÅ© ¼± µÎ²²	:VARCHAR2(10) 
        IxSPEC_DESC = 17,
        IxCOLOR_DESC = 16,			// ¶óÀÎ ½ºÅ¸ÀÏ (¿¹ : °î¼±, Á÷¼± µî)	:VARCHAR2(10) 		
        IxUNIT_CD = 18,	        // ¶óÀÎ ¶ó¿îµå ¼Ó¼º : ¸µÅ© ²ªÀÎÁ¡ ºÎºÐ ¶ó¿îµå Ã³¸® ¿©ºÎ	:VARCHAR2(10) 
        lxMCS = 19,
        IxQTY_CURR_PUR = 20,			// ÅÂ±× ¼Ó¼º	:VARCHAR2(60) 
        IxVALUE_CURR_PUR = 21,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxRTA_YMD = 22,
        IxETC_YMD = 23,
        IxREMARKS = 24,
        IxUPD_USER = 25,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
        IxUPD_YMD = 26,			// ÀÛ¼ºÀÏÀÚ	:DATE(7)
    }
    public enum TBSXO_PUR_REQ : int
    {

        IxMaxCt = 55,
        // ÀÎµ¦½º Count 
        IxDIVISION        = 0,
        IxSTATUS          = 1,
        IxFACTORY         = 2,
        IxREQ_DEPT        = 3,
        IxREQ_DEPT_DESC   = 4,
        IxREQ_USER        = 5,
        IxUSE_DEPT        = 6,
        IxUSE_DEPT_DESC   = 7,
        IxREQ_YMD         = 8,
        IxREQ_NO          = 9,
        IxREQ_SEQ         = 10,
        IxPUR_FLG         = 11,
        IxIN_FLG          = 12,
        IxLOT_NO          = 13,
        IxLOT_SEQ         = 14,
        IxSRF_SEQ         = 15,
        IxPART_SEQ        = 16,
        IxPART_NO         = 17,
        IxPART_TYPE       = 18,
        IxPART_DESC       = 19,
        IxPART_COMMENT    = 20,
        IxMAT_CD          = 21,
        IxMAT_NAME        = 22,
        IxMAT_COMMENT     = 23,
        IxMCS_CD          = 24,
        IxCOLOR_CD        = 25,
        IxCOLOR_DESC      = 26,
        IxCOLOR_KNAME     = 27,
        IxCOLOR_COMMENT   = 28,
        IxPCC_UNIT_CD     = 29,
        IxPCC_SPEC_CD     = 30,
        IxPCC_SPEC_DESC   = 31,
        IxCOMMON_YN       = 32,
        IxCATEGORY        = 33,
        IxSEASON_CD       = 34,
        IxSEASON_NAME     = 35,
        IxSTYLE_CD        = 36,
        IxSTYLE_NAME      = 37,
        IxNF_CD           = 38,
        IxCS_SIZE         = 39,
        IxPRICE_YN        = 40,
        IxCBD_PRICE       = 41,
        IxPUR_DIV         = 42,
        IxTRANSPORT_TYPE  = 43,
        IxREQ_REASON      = 44,
        IxQTY_REQ         = 45,
        IxPURCHAE_YN      = 46,
        IxVALUE_REQ       = 47,
        IxRTA_YMD         = 48,
        IxETC_YMD         = 49,
        IxREMARKS         = 50,
        IxSEND_CHK        = 51,
        IxSEND_YMD        = 52,
        IxUPD_USER        = 53,
        IxUPD_YMD         = 54,
    }

    public enum TBSXZ_IMPORT_OFFER_HEAD : int
    {
        IxMaxCt = 23,		// ÀÎµ¦½º Count

        IxDIV         = 0,   
        IxCHK         = 1,   
        IxOFFER_NO    = 2,   
        IxORD_YN      = 3,   
        IxDEPT_CD     = 4,   
        IxDEPT_NAME   = 5,   
        IxOFFER_DATE  = 6,   
        IxCATEGORY    = 7,   
        IxSEASON      = 8,   
        IxMODEL       = 9,   
        IxDEV_CODE    = 10,  
        IxCUST_CD     = 11,  
        IxCUST_NAME   = 12,  
        IxNIKE_DEV    = 13,  
        IxSE_DIV      = 14,  
        IxPURPOSE     = 15,    
        IxPROD_CODE   = 16,  
        IxPO          = 17,  
        IxUPD_USER    = 18,  
        IxREMARK      = 19,  
        IxVIA         = 20,
        IxAMOUNT_CD   = 21,
        IxLC_NO       = 22,  
                  
    }
    public enum TBSXZ_IMPORT_OFFER_TAIL : int
    {
        IxMaxCt = 22,		// ÀÎµ¦½º Count

        IxDIV       = 0,
        IxCHK       = 1,
        IxSEQ       = 2,
        IxMAT_NAME  = 3,
        IxCLR_CD    = 4,
        IxCLR_NAME  = 5,
        IxCOMP      = 6,
        IxADDPROC   = 7,
        IxMTL       = 8,
        IxUNIT      = 9,
        IxQTY       = 10,
        IxPRICE     = 11,
        IxMAT_CLASS = 12,
        IxRTA       = 13,     
        IxETS1      = 14,
        IxARR_DATE  = 15,        
        IxTHICKNESS = 16,
        IxWIDTH     = 17,
        IxLENGTH    = 18,
        IxREMARKS   = 19,
        IxPASS_QTY  = 20,
        IxIN_QTY    = 21,
        IxBLNO      = 22,         
                      
    }

    #endregion
    #endregion

    #region Request Purchase
    public enum TBSXP_PUR_REQ_HEAD : int
    {
        IxMaxCt       = 26,

        IxDIV         = 0,        
        IxFACTORY     = 1,
        IxREQ_NO      = 2,
        IxREQ_YMD     = 3,
        IxREQ_DEPT    = 4,
        IxREQ_USER    = 5,
        IxCATEGORY    = 6,
        IxSEASON_CD   = 7,
        IxSEASON      = 8,
        IxSRF_NO      = 9,
        IxBOM_ID      = 10,
        IxSTYLE_CD    = 11,
        IxSTYLE_NAME  = 12,
        IxNF_CD       = 13,
        IxWHQ_DEV     = 14,
        IxCDC_DEV     = 15,
        IxDHL_ACCOUNT = 16,
        IxRTA_YMD     = 17,
        IxSPL_DDD_YMD = 18,
        IxMRP_NO      = 19,        
        IxLOT_NO      = 20,
        IxLOT_SEQ     = 21,
        IxREMARKS     = 22,
        IxSTATUS      = 23,
        IxUPD_USER    = 24,
        IxUPD_YMD     = 25,    
    }      
    
    public enum TBSXP_PUR_REQ_TAIL : int
    {
        IxMaxCt         = 29,

        IxDIV           = 0,        
        IxFACTORY       = 1,
        IxREQ_NO        = 2,
        IxREQ_SEQ       = 3,
        IxPART_NO       = 4,
        IxPART_DESC     = 5,        
        IxMAT_CD        = 6,
        IxMAT_NAME      = 7,
        IxMAT_COMMENT   = 8,
        IxCOLOR_CD      = 9,
        IxCOLOR_NAME    = 10,
        IxCOLOR_COMMENT = 11,
        IxPCC_UNIT_CD   = 12,
        IxPCC_SPEC_CD   = 13,
        IxSPEC_NAME     = 14,
        IxSIZE_CD       = 15,
        IxMAT_CLASS     = 16,
        IxPUR_DIV       = 17,
        IxVALUE_REQ     = 18,
        IxRTA_YMD       = 19,
        IxETS_YMD       = 20,
        IxMAT_SUB_FLG   = 21,
        IxVEN_SEQ       = 22,
        IxVENDOR        = 23,
        IxREMARKS       = 24,
        IxIMG_YN        = 25,        
        IxSTATUS        = 26,
        IxUPD_USER      = 27,
        IxUPD_YMD       = 28,    
    }        

    public enum TBSXP_PUR_REQ_POP_HEAD : int
    {
        IxMaxCt           = 18,	
        
        IxDIV             = 0,
        IxFACTORY         = 1,
        IxCATEGORY        = 2,
        IxSEASON_CD       = 3,
        IxSEASON          = 4,
        IxSTYLE_CD        = 5,
        IxSTYLE_NAME      = 6,
        IxSR_NO           = 7,
        IxSRF_NO          = 8,
        IxBOM_ID          = 9,
        IxBOM_REV         = 10,
        IxNF_CD           = 11,
        IxNIKE_DEV        = 12,
        IxCDC_DEV         = 13,
        IxLOT_NO          = 14,
        IxLOT_SEQ         = 15,
        IxLOAD_UPD_USER   = 16,
        IxLOAD_UPD_YMD    = 17,
    }             
    public enum TBSXP_PUR_REQ_POP_TAIL : int
    {
        IxMaxCt            = 18,	
        
        IxDIV              = 0,
        IxCHK              = 1,
        IxFACTORY          = 2,
        IxPART_NO          = 3,
        IxPART_TYPE        = 4,
        IxMAT_CD           = 5,
        IxMAT_NAME         = 6,
        IxMAT_COMMENT      = 7,
        IxCOLOR_CD         = 8,
        IxCOLOR_DESC       = 9,
        IxCOLOR_COMMENT    = 10,
        IxPCC_UNIT_CD      = 11,
        IxPCC_SPEC_CD      = 12,
        IxSPEC_NAME        = 13,
        IxVEN_SEQ          = 14,
        IxVENDOR           = 15,
        IxUPD_USER         = 16,
        IxUPD_YMD          = 17,
    }                   
    #endregion

    #region Incoming
    public enum TBSXI_IN_LIST : int
    {
        IxMaxCt = 33,

        IxDIVISION = 0,
        IxSTATUS = 1,
        IxY_FLG = 2,
        IxLEVEL = 3,
        IxIN_NO = 4,
        IxIN_SEQ = 5,
        IxIN_DIV = 6,
        IxIN_YMD = 7,
        IxITEM01 = 8,
        IxITEM02 = 9,
        IxITEM03 = 10,
        IxITEM04 = 11,
        IxVALUE_PUR = 12,
        IxVALUE_PREV_IN = 13,
        IxVALUE_IN = 14,
        IxBL_NO = 15,
        IxINV_NO = 16,
        IxDEC_NO = 17,
        IxDEC_YMD = 18,
        IxPUR_CURRENCY = 19,
        IxPUR_PRICE = 20,
        IxCBD_CURRENCY = 21,
        IxCBD_PRICE = 22,
        IxBAR_CODE = 23,
        IxPUR_DIV = 24,
        IxMRP_REQ_FLG = 25,
        IxTRANSPORT_TYPE = 26,
        IxVENDOR = 27,
        IxREMARKS = 28,
        IxUPD_USER = 29,
        IxUPD_YMD = 30,
        IxPUR_NO = 31,
        IxPUR_SEQ = 32,

    }
    public enum TBSXI_IN_LIST_PUR : int
    {
        IxMaxCt = 27,		// ÀÎµ¦½º Count

        IxDIVISION = 0,
        IxSTATUS = 1,
        IxY_FLG = 2,
        IxLEVEL = 3,
        IxPUR_NO = 4,
        IxPUR_SEQ = 5,
        IxPUR_DIV = 6,
        IxPUR_YMD = 7,
        IxITEM01 = 8,
        IxITEM02 = 9,
        IxITEM03 = 10,
        IxITEM04 = 11,
        IxVALUE_PUR = 12,
        IxVALUE_IN = 13,
        IxVALUE_ADV_IN = 14,
        IxPUR_CURRENCY = 15,
        IxPUR_PRICE = 16,
        IxCBD_CURRENCY = 17,
        IxCBD_PRICE = 18,
        IxBAR_CODE = 19,
        IxMRP_REQ_FLG = 20,
        IxPRICE_YN = 21,
        IxTRANSPORT_TYPE = 22,
        IxVENDOR_DESC = 23,
        IxREMARKS = 24,
        IxUPD_USER = 25,
        IxUPD_YMD = 26,


    }
    public enum TBSXI_IN_LIST_BAR : int
    {
        IxMaxCt = 27,		// ÀÎµ¦½º Count

        IxDIVISION = 0,
        IxSTATUS = 1,
        IxY_FLG = 2,
        IxLEVEL = 3,
        IxPUR_NO = 4,
        IxPUR_SEQ = 5,
        IxPUR_DIV = 6,
        IxPUR_YMD = 7,
        IxITEM01 = 8,
        IxITEM02 = 9,
        IxITEM03 = 10,
        IxITEM04 = 11,
        IxVALUE_PUR = 12,
        IxVALUE_IN = 13,
        IxVALUE_ADV_IN = 14,
        IxPUR_CURRENCY = 15,
        IxPUR_PRICE = 16,
        IxCBD_CURRENCY = 17,
        IxCBD_PRICE = 18,
        IxBAR_CODE = 19,
        IxMRP_REQ_FLG = 20,
        IxPRICE_YN = 21,
        IxTRANSPORT_TYPE = 22,
        IxVENDOR_DESC = 23,
        IxREMARKS = 24,
        IxUPD_USER = 25,
        IxUPD_YMD = 26,
    }
    public enum TBSXI_IN_LIST_DEAL : int
    {

        IxMaxCt = 28,		// ÀÎµ¦½º Count

        IxDIVISION = 0,
        IxSTATUS = 1,
        IxY_FLG = 2,
        IxLEVEL = 3,
        IxPUR_NO = 4,
        IxPUR_SEQ = 5,
        IxPUR_DIV = 6,
        IxPUR_YMD = 7,
        IxITEM01 = 8,
        IxITEM02 = 9,
        IxITEM03 = 10,
        IxITEM04 = 11,
        IxVALUE_PUR = 12,
        IxVALUE_IN = 13,
        IxBAR_IN = 14,
        IxVALUE_ADV_IN = 15,
        IxPUR_CURRENCY = 16,
        IxPUR_PRICE = 17,
        IxCBD_CURRENCY = 18,
        IxCBD_PRICE = 19,
        IxBAR_CODE = 20,
        IxMRP_REQ_FLG = 21,
        IxPRICE_YN = 22,
        IxTRANSPORT_TYPE = 23,
        IxVENDOR_DESC = 24,
        IxREMARKS = 25,
        IxUPD_USER = 26,
        IxUPD_YMD = 27,

    }
    public enum TBSXI_IN_LIST_INV : int
    {
        IxMaxCt = 28,		// ÀÎµ¦½º Count

        IxDIVISION = 0,
        IxFACTORY = 1,
        IxY_FLG = 2,
        IxLEVEL = 3,
        IxSHIP_NO = 4,
        IxMRP_NO = 5,
        IxINV_NO = 6,
        IxPACKING = 7,
        IxITEM01 = 8,
        IxITEM02 = 9,
        IxITEM03 = 10,
        IxITEM04 = 11,
        IxVALUE_PUR = 12,
        IxVALUE_ADV_IN = 13,
        IxPUR_CURRENCY = 14,
        IxPUR_PRICE = 15,
        IxCBD_CURRENCY = 16,
        IxCBD_PRICE = 17,
        IxBAR_CODE = 18,
        IxBAR_CODE_TRADE = 19,
        IxMRP_REQ_FLG = 20,
        IxPRICE_YN = 21,
        IxTRANSPORT_TYPE = 22,
        IxREMARKS = 23,
        IxUPD_USER = 24,
        IxUPD_YMD = 25,
        IxPUR_NO = 26,
        IxPUR_SEQ = 27,

    }
    public enum TBSXI_IN_LIST_ANA : int
    {
        IxMaxCt = 28,

        IxLEVEL = 0,
        IxIN_NO = 1,
        IxIN_DIV = 2,
        IxIN_YMD = 3,
        IxMAT_NAME = 4,
        IxMAT_COMMENT = 5,
        IxSPEC_NAME = 6,
        IxCOLOR_CD = 7,
        IxCOLOR_DESC = 8,
        IxCOLOR_COMMENT = 9,
        IxPCC_UNIT_CD = 10,
        IxVALUE_IN = 11,
        IxPUR_PRICE = 12,
        IxPUR_CURRENCY = 13,
        IxCBD_PRICE = 14,
        IxCBD_CURRENCY = 15,
        IxAMOUNT_USD = 16,
        IxAMOUNT_KRW = 17,
        IxMODEL_NO = 18,
        IxSTYLE_NAME = 19,
        IxPUR_DIV = 20,
        IxMRP_REQ_FLG = 21,
        IxPRICE_YN = 22,
        IxTRANSPORT_TYPE = 23,
        IxVENDOR_DESC = 24,
        IxREMARKS = 25,
        IxUPD_USER = 26,
        IxUPD_YMD = 27,

    }
    #endregion

    #region Product
    public enum TBSXE_CREATE_LOT : int
    {
        IxDIVISION       = 0,
        IxFACTORY        = 1,
        IxSTATUS         = 2,
        IxREQ_YN         = 3,
        IxBOM_CHK        = 4,
        IxWH_COVER       = 5,
        IxIMAGE_CHK      = 6,
        IxCATEGORY       = 7,
        IxSEASON_CD      = 8,
        IxSTYLE_NAME     = 9,
        IxCOLOR_VER      = 10,
        IxBOM_STYLE      = 11,
        IxGEN_SIZE       = 12,
        IxROUND          = 13,
        IxORD_YMD        = 14,
        IxNEED_BY        = 15,
        IxETS            = 16,
        IxMAT_LEADTIME   = 17,
        IxLOT_QTY        = 18,
        IxBOM_INFO       = 19,
        IxLOAD_UPD_USER  = 20,
        IxLOAD_UPD_DATE  = 21,
        IxREMARKS        = 22,
        IxLOT_NO         = 23,
        IxLOT_SEQ        = 24,
        IxT_LEVEL        = 25,
        IxSR_NO          = 26,
        IxBOM_CD         = 27,
        IxSRF_NO         = 28,
        IxCATEGORY_S     = 29,
        IxMTO_ACC        = 30,
        IxSEASON         = 31,
        IxGENDER         = 32,
        IxWHQ_DEV        = 33,
        IxDEV_PROD       = 34,
        IxBOM_ID         = 35,
        IxLASTING_ME     = 36,
        IxMS_ME          = 37,
        IxSOLELAYING     = 38,
        IxCOLOR          = 39,
        IxLAST_CD        = 40,
        IxPATTERN        = 41,
        IxSTL_FILE       = 42,
        IxRETAIL_PRICE   = 43,
        IxCURRENT_FOB    = 44,
        IxSAMPLE_WEI     = 45,
        IxREQ_YMD        = 46,
        IxCOLLAR_HEI     = 47,
        IxDISPATCH_YMD   = 48,
        IxHEEL_HEI       = 49,
        IxCDC_DEV        = 50,
        IxMEDIAL_HEI     = 51,
        IxNLO_DEV        = 52,
        IxLATERAL_HEI    = 53,
        IxFGA_QTY        = 54,
        IxLACE_LENGTH    = 55,
        IxDISPATCH_QTY   = 56,
        IxMS_HARDNESS    = 57,
        IxIDS_LENGTH     = 58,
        IxBARCODE_DATE   = 59,
        IxWIDTH          = 60,
        IxFIT            = 61,
        IxUPPER_MAT      = 62,
        IxBARCODE        = 63,
        IxLACE_DESC      = 64,
        IxINSOLE_DESC    = 65,
        IxT_D            = 66,
        IxIPW_YMD        = 67,
        IxSTYLE_CD       = 68,
        IxSIZE_CD        = 69,
        IxGEN_NAME       = 70,
        IxSAMPLE_TPYES   = 71,
        IxFILE_PATH      = 72,
        IxTAG_COMMENT    = 73,
        IxCOPY_USER      = 74,

        IxNIKE_DEV_SEQ        = 75,
        IxNIKE_PE_SEQ         = 76, 
        IxNIKE_TE_SEQ         = 77, 
        IxNIKE_CE_SEQ         = 78, 
        IxCDC_PE_SABUN        = 79,  
        IxCDC_TE_SABUN        = 80,  
        IxPCC_DD              = 81,     
        IxCUTTING             = 82,  
        IxCUTTING_QTY         = 83,  
        IxCMP_PRESS           = 84,  
        IxCMP_PRESS_QTY       = 85,  
        IxPU_SPRAY            = 86,  
        IxPU_SPRAY_QTY        = 87,  
        IxIP_SPRAY            = 88,  
        IxIP_SPRAY_QTY        = 89,  
        IxOS_PRESS            = 90,  
        IxOS_PRESS_QTY        = 91,  
        IxEMBROIDERY          = 92,  
        IxEMBROIDERY_QTY      = 93,  
        IxAIRBAG_SPRAY        = 94,  
        IxAIRBAG_SPRAY_QTY    = 95,  
        IxEMISSION_SHANK      = 96,  
        IxEMISSION_SHANK_QTY  = 97,  
        IxSTITCHING           = 98,  
        IxSTITCHING_QTY       = 99,  
        IxSTOCKFIT            = 100, 
        IxSTOCKFIT_QTY        = 101, 
        IxASSEMBLY            = 102,
        IxASSEMBLY_QTY        = 103,

    }
    public enum TBSXE_WORKSHEET_POP : int
    {
        IxDIVISION    = 0,
        IxCHK         = 1,
        IxLEV         = 2,

        IxFACTORY     = 3,
        IxLOT_NO      = 4,
        IxLOT_SEQ     = 5,
        IxCATEGORY    = 6,
        IxSEASON      = 7,
        IxSTYLE_NAME  = 8,
        IxCOLOR_VER   = 9,
        IxBOM_STYLE   = 10,
        IxGEN_SIZE    = 11,
        IxSAMPLE_TYPE = 12,


        IxSAMPLE_WEI      = 13,
        IxCOLLAR_HEI      = 14,
        IxHEEL_HEI        = 15,
        IxMEDIAL_HEI      = 16,
        IxLATERAL_HEI     = 17,
        IxSOLE_HARDNESS   = 18,
        IxDISPATCH_YMD    = 19,
        IxCDC_DEV         = 20,
        IxNLO_DEV         = 21,
        IxFGA_QTY         = 22,
        IxDISPATCH_QTY    = 23,
        IxIDS_LENGTH      = 24,
        IxBARCODE_DATE    = 25,
        IxWIDTH           = 26,
        IxFIT             = 27,
        IxUPPER_MAT       = 28,
        IxBARCODE         = 29,
        IxLACE_DESC       = 30,
        IxINSOLE_DESC     = 31,
        IxT_D             = 32,        
        IxIPW_YMD         = 33,
        IxTAG_COMMENT     = 34,
    }
    public enum TBSXE_OP_CD : int
    {
        IxCUTTING            = 1,
        IxCUTTING_QTY        = 2,
        IxCMP_PRESS          = 3,
        IxCMP_PRESS_QTY      = 4,
        IxPU_SPRAY           = 5,
        IxPU_SPRAY_QTY       = 6,
        IxIP_SPRAY           = 7,
        IxIP_SPRAY_QTY       = 8,
        IxOS_PRESS           = 9,
        IxOS_PRESS_QTY       = 10,
        IxEMBROIDERY         = 11,
        IxEMBROIDERY_QTY     = 12,
        IxAIRBAG_SPRAY       = 13,
        IxAIRBAG_SPRAY_QTY   = 14,
        IxEMISSION_SHANK     = 15,
        IxEMISSION_SHANK_QTY = 16,
        IxSTITCHING          = 17,
        IxSTITCHING_QTY      = 18,
        IxSTOCKFIT           = 19,
        IxSTOCKFIT_QTY       = 20,
        IxASSEMBLY           = 21,
        IxASSEMBLY_QTY       = 22,
    }                        
    public enum TBSXG_PROD_MANAGER : int
    {

        IxDIVISION  = 0,
        IxFACTORY   = 1,
        IxLOT_NO    = 2,
        IxLOT_SEQ   = 3,
        IxDAY_SEQ   = 4,

        IxLINE_CD   = 5,
        IxCMP_CD    = 6,
        IxOP_CD     = 7,
        IxBAR_CODE  = 8,
        IxT_LEVEL   = 9,

        IxCATEGORY  = 10,
        IxSEASON    = 11,
        IxCOL_01    = 12,
        IxCOL_02    = 13,
        IxCOL_03    = 14,

        IxCOL_04    = 15,
        IxCOL_05    = 16,
        IxCOL_06    = 17,
    
    }
    public enum TBSXG_PROD_RESULT_OP : int
    {
        IxDIVISION       = 0,
        IxFACTORY        = 1,
        IxCATEGORY       = 2,
        IxSEASON_CD      = 3,
        IxSTYLE_NAME     = 4,
        IxCOLOR_VER      = 5,
        IxBOM_STYLE      = 6,
        IxGEN_SIZE       = 7,
        IxSAMPLE_TYPE    = 8,
        IxREQ_YMD        = 9,
        IxFGA_QTY        = 10,
        IxETS            = 11,
        IxMAT_YMD        = 12,
        IxIN_YMD         = 13,
        IxIN_REMARK      = 14,
        IxIPW_YMD        = 15,
        IxCDC_DEV_NAME   = 16,
        IxUPC_DIR        = 17,
        IxUPC_RST        = 18,
        IxI_UPC_RST      = 19,
        IxT_UPC_RST      = 20,
        IxP_UPC_RST      = 21,
        IxO_UPC_RST      = 22,
        IxPHC_DIR        = 23,
        IxPHC_RST        = 24,
        IxI_PHC_RST      = 25,
        IxT_PHC_RST      = 26,
        IxP_PHC_RST      = 27,
        IxO_PHC_RST      = 28,
        IxPUS_DIR        = 29,
        IxPUS_RST        = 30,
        IxI_PUS_RST      = 31,
        IxT_PUS_RST      = 32,
        IxP_PUS_RST      = 33,
        IxO_PUS_RST      = 34,
        IxIPS_DIR        = 35,
        IxIPS_RST        = 36,
        IxI_IPS_RST      = 37,
        IxT_IPS_RST      = 38,
        IxP_IPS_RST      = 39,
        IxO_IPS_RST      = 40,
        IxOSP_DIR        = 41,
        IxOSP_RST        = 42,
        IxI_OSP_RST      = 43,
        IxT_OSP_RST      = 44,
        IxP_OSP_RST      = 45,
        IxO_OSP_RST      = 46,        
        IxABS_DIR        = 47,
        IxABS_RST        = 48,
        IxI_ABS_RST      = 49,
        IxT_ABS_RST      = 50,
        IxP_ABS_RST      = 51,
        IxO_ABS_RST      = 52,
        IxEMS_DIR        = 53,
        IxEMS_RST        = 54,
        IxI_EMS_RST      = 55,
        IxT_EMS_RST      = 56,
        IxP_EMS_RST      = 57,
        IxO_EMS_RST      = 58,
        IxUPE_DIR        = 59,
        IxUPE_RST        = 60,
        IxI_UPE_RST      = 61,
        IxT_UPE_RST      = 62,
        IxP_UPE_RST      = 63,
        IxO_UPE_RST      = 64,
        IxUPS_DIR        = 65,
        IxUPS_RST        = 66,
        IxI_UPS_RST      = 67,
        IxT_UPS_RST      = 68,
        IxP_UPS_RST      = 69,
        IxO_UPS_RST      = 70,
        IxFSS_DIR        = 71,
        IxFSS_RST        = 72,
        IxI_FSS_RST      = 73,
        IxT_FSS_RST      = 74,
        IxP_FSS_RST      = 75,
        IxO_FSS_RST      = 76,
        IxFGA_DIR        = 77,
        IxFGA_RST        = 78,
        IxI_FGA_RST      = 79,
        IxT_FGA_RST      = 80,
        IxP_FGA_RST      = 81,
        IxO_FGA_RST      = 82,
        IxUPS_REMAIN     = 83,
        IxFGA_REMAIN     = 84,
        IxUPS_USER       = 85,        
        IxFGA_REMARKS    = 86,
        IxUPE_REMARKS    = 87,
        IxUPC_REMARKS    = 88,
        IxREMARKS        = 89,
        IxLOT_INFO       = 90,
        IxLOT_NO         = 91,
        IxLOT_SEQ        = 92,
        IxLINE_CD        = 93,
        IxDAY_SEQ        = 94,
        IxPCARD_ID       = 95,
        IxSTATUS         = 96,
    }
    
    public enum TBSXG_PROD_RESULT_POP : int
    {

        IxDIVISION       = 0,
        IxCHK            = 1,
        IxBAR_CODE       = 2,
        IxDIR_QTY        = 3,
        IxRST_QTY        = 4,
        IxCMP_CD         = 5,
        IxOP_CD          = 6,
    }    
    public enum TBSXG_PROD_RESULT_POP_NEW : int
    {

        IxDIVISION       = 0,
        IxCHK            = 1,
        IxBAR_CODE       = 2,
        IxDIR_QTY        = 3,
        IxPCARD_QTY      = 4,
        IxRST_QTY        = 5,        
        IxREMAIN_QTY     = 6,
        IxINSERT_QTY     = 7,
        IxCFM_CHK        = 8,
        IxCMP_CD         = 9,
        IxOP_CD          = 10,
    }    
    public enum TBSXB_PJ_PRODUCT_WS : int
    {
        IxDIVISION     = 0,
        IxFACTORY      = 1,
        IxLOT_NO       = 2,
        IxLOT_SEQ      = 3,
        IxDAY_SEQ      = 4,
        IxLINE_CD      = 5, 

        IxSR_NO        = 6,
        IxSRF_NO       = 7,
        IxBOM_ID       = 8,
        IxBON_REV      = 9,

        IxCATEGORY     = 10,
        IxSEASON       = 11,
        IxSTYLE_NAME   = 12,
        IxCOLOR_VER    = 13,
        IxBOM_STYLE    = 14,
        IxGEN_SIZE     = 15,
        IxSAMPLE_TYPES = 16,
        IxREQ_YMD      = 17,
        IxFGA_QTY      = 18,
        IxETS          = 19,
        IxMAT_YMD      = 20,
        IxIPW_YMD      = 21,
        IxDEV_USER     = 22,
        IxUPC          = 23,
        IxPHC          = 24,              
        IxPUS          = 25,              
        IxIPS          = 26,              
        IxOSP          = 27,              
        IxUPE          = 28,              
        IxABS          = 29,              
        IxEMS          = 30,              
        IxUPS          = 31,             
        IxFSS          = 32,
        IxFGA          = 33,
        IxUPS_USER     = 34,             
        IxREMARKS      = 35,      
        IxSTATUS       = 36,
       
    }
    #endregion             

    #region SMS
    public enum TBSDK_SMS_SEND : int
    {
        lxDIVISION     = 0,        
        lxMSG_ID       = 1,
        lxUSER_ID      = 2,
        lxJOB_ID       = 3,
        lxDEST_NAME    = 4,
        lxPHONE_NUMBER = 5,
        lxSUBJECT      = 6,
        lxSMS_MSG      = 7,
        lxNOW_DATE     = 8,
        lxSEND_DATE    = 9,
        lxCALLBACK     = 10,
        lxDEST_INFO    = 11,
           
    
    }
    #endregion

    #region Inventory
    public enum TBSXG_PROD_INV : int
    {
        IxDIV                 = 0,
        IxFACTORY             = 1,
        IxLOT_NO              = 2,
        IxLOT_SEQ             = 3,
        IxDAY_SEQ             = 4,
        IxLINE_CD             = 5,
        IxOP_CD               = 6,
        IxP_STATUS            = 7,
        IxCHECK               = 8,
        IxFGA_YMD             = 9,
        IxSCAN_YMD            = 10,
        IxSTYLE_NAME          = 11,
        IxSTYLE_CD            = 12,
        IxBOM_ID              = 13,
        IxCOPY_DEV_NAME       = 14,
        IxROUND               = 15,
        IxRST_QTY             = 16,                
        IxHALF_TOTAL          = 17,
        IxINV_UPC             = 18,
        IxINV_SILHOUETTE      = 19,
        IxINV_UPS             = 20,        
        IxINV_LASTED_UPPER    = 21,        
        IxPROD_QTY            = 22,
        IxINV_TOTAL           = 23,
        IxINV_NIKE            = 24,
        IxINV_VJ              = 25,
        IxINV_QD              = 26,
        IxINV_5523            = 27,
        IxINV_YIELD_COST      = 28,
        IxINV_SHC_QA          = 29,
        IxINV_SL_KEEP         = 30,
        IxINV_DEV_KEEP        = 31,
        IxINV_CE_TEST         = 32,  
        IxINV_PATTERN_TEST    = 33,
        IxINV_PAD_PROD        = 34,
        IxINV_OTHER           = 35,
        IxINV_NIKE_MEET       = 36,
        IxINV_DEFFECTIVE      = 37,
        IxPROBLEM_DESC        = 38,       
    }
    #endregion

    #region Formula
    public enum TBSXG_SPECIFIC_FORMULA : int
    {
        IxMODEL_NAME        = 0,
        IxWORK_YMD          = 1,
        IxMACHINE_TYPE      = 2,
        IxBOM_STYLE         = 3,
        IxOPERATOR          = 4,
        IxMAT_SMALL         = 5,
        IxMAT_LARGE         = 6,
        IxMAT_TOT_RQD       = 7,
        IxMCS_CD            = 8,
        IxMCS_COLOR         = 9,
        IxMCS_COLOR_NAME    = 10,
        IxMAT_LOT_NO        = 11,
        IxMAT_LOT_NO_SMALL  = 12,
        IxMED_LOT_NO        = 13,
        IxMAT_RATE_RQD      = 14,
        IxMIX_RATE_FROM     = 15,
        IxMIX_RATE_TO       = 16,
        IxMIX_RATE_SMALL    = 17,
        IxMIX_RATE_LARGE    = 18,
        IxADJ_TARGET_LENGTH = 19,
        IxADJ_MESURE_LENGTH = 20,
        IxADJ_EXP_RATE      = 21,
        IxADJ_EXP_RANGTH    = 22,
        IxPRESS_SET         = 23,
        IxBACK_PSR          = 24,
        IxSCREW_RPM         = 25,
        IxDIS_PRS           = 26,
        IxDIS_SPD           = 27,
        IxCMPRS_PRS         = 28,
        IxCMPRS_SPD         = 29,
        IxTEMP_ZONE1        = 30,
        IxTEMP_ZONE2        = 31,
        IxTEMP_ZONE3        = 32,
        IxTEMP_ZONE4        = 33,
        IxTEMP_ZONE5        = 34,
        IxVACUUM_CHECK      = 35,
        IxVACUUM_MEASURE    = 36,
        IxTEMP_LOWER        = 37,
        IxTEMP_UPPER        = 38,
        IxVOLUME            = 39,
        IxSPEED1            = 40,
        IxSPEED2            = 41,
        IxSPEED3            = 42,
        IxSPEED4            = 43,
        IxSPEED5            = 44,
        IxTIMES             = 45,
        IxCURE_TIME         = 46,
        IxPRESSURE          = 47,
        IxREMARKS           = 48,
    }
    #endregion

    #region Outgoing
    public enum TBSXO_OUT_LIST : int
    {
        IxMaxCt = 25,

        IxDIVISION = 0,
        IxLEVEL = 1,
        IxFACTORY = 2,
        IxOUT_NO_V = 3,
        IxMAT_NAME = 4,
        IxMAT_CD = 5,
        IxPCC_SPEC_CD = 6,
        IxCOLOR_CD = 7,
        IxSTATUS = 8,
        IxOUT_YMD = 9,
        IxOUT_NO = 10,
        IxOUT_SEQ = 11,
        IxOUT_DIV = 12,
        IxOUT_USER = 13,
        IxITEM_01 = 14,
        IxITEM_02 = 15,
        IxITEM_03 = 16,
        IxITEM_04 = 17,
        IxPROD_YIELD = 18,
        IxOUT_VALUE = 19,
        IxIN_VALUE = 20,
        IxREAL_VALUE = 21,
        IxREMARKS = 22,
        IxUPD_USER = 23,
        IxUPD_YMD = 24,

    } 
    #endregion

    #region Shipping
    public enum TBSXS_SHIP_REQUEST : int
    {
        IxMaxCt = 41,

        IxDIV               = 0,
        IxFACTORY           = 1, 
        IxSHIP_FLG          = 2, 
        IxMRP_REQ_FLG       = 3, 
        IxMRP_NO            = 4, 
        IxPUR_DIV           = 5, 
        IxSRF_NO            = 6, 
        IxBAR_CODE          = 7, 
        IxSORT_FLG          = 8,
        IxITEM_01           = 9, 
        IxITEM_02           = 10, 
        IxITEM_03           = 11, 
        IxITEM_04           = 12,
        IxPCC_UNIT_CD       = 13,
        IxVALUE_PUR         = 14, 
        IxVALUE_IN          = 15, 
        IxVALUE_OUT         = 16,
        IxTRANSPORT_TYPE    = 17, 
        IxPACKING           = 18, 
        IxPK_NO             = 19, 
        IxPK_NO_FROM        = 20, 
        IxPK_NO_TO          = 21, 
        IxPK_UNIT_QTY       = 22,
        IxCBM               = 23,
        IxWEIGHT            = 24, 
        IxCT_QTY            = 25,
        IxBL_NO             = 26, 
        IxINV_NO            = 27, 
        IxDEC_NO            = 28, 
        IxDEC_YMD           = 29,
        IxPUR_CURRENCY      = 30, 
        IxPUR_PRICE         = 31, 
        IxOUTSIDE_CURRENCY  = 32, 
        IxOUTSIDE_PRICE     = 33, 
        IxCBD_CURRENCY      = 34, 
        IxCBD_PRICE         = 35,        
        IxUPD_USER          = 36, 
        IxUPD_YMD           = 37,
        IxSHIP_NO           = 38, 
        IxSHIP_SEQ          = 39,
        IxSTATUS            = 40,
    }  	
    #endregion

    #region Stock
    public enum TBSXK_STOCK_INOUT : int
    {
        lxFACTORY = 0,
        lxLEVEL = 1,
        lxMAT_CD = 2,
        lxMAT_DESC = 3,
        lxMAT_COMMENT = 4,
        lxPCC_SPEC = 5,
        lxSPEC_NAME = 6,
        lxPCC_UNIT = 7,
        lxCOLOR = 8,
        lxCOLOR_DESC = 9,
        lxINOUT_YMD = 10,
        lxVENDOR = 11,
        lxVALUE_INIT = 12,
        lxVALUE_IN = 13,
        lxVALUE_OUT = 14,
        lxVALUE_STOCK = 15,
        lxREMARKS = 16,
        lxUPD_USER = 17,
    }
    public enum TBSXK_STOCK : int
    {

        lxDIVISION = 0,
        lxFACTORY = 1,
        lxLOCATION = 3,
        lxMAT_CD = 4,
        lxMAT_DESC = 5,
        lxMAT_COMMENT = 6,
        IxPCC_SPEC = 7,
        lxSPEC_NAME = 8,
        lxPCC_UNIT = 9,
        lxCOLOR = 10,
        lxCOLOR_DESC = 11,
        lxSTOCK_YMD1 = 12,
        lxVALUE_INIT = 13,
        lxVALUE_IN = 14,
        lxVALUE_OUT = 15,
        lxVALUE_STOCK = 16,
        lxVALUE_ADJUST = 17,
        lxADJUST_DESC = 18,
        lxREMARKS = 19,
        lxPUR_CURRENCY = 20,
        lxPUR_PRICE = 21,
        lxCBD_CURRENCY = 22,
        lxCBD_PRICE = 23,
        lxSTATUS = 24,
        lxUPD_USER = 25,
        lxUPD_YMD = 26,
        lxMAT_COMMENT_SEQ = 27,
    }

    #endregion

    #region EIS Analisys
    //DD Report by Season
    public enum TBEIS_DD_REPORT_SEASON : int
    {
        IxDIVISION = 0,
        IxSESN_CD  = 1,
        IxTD_CODE  = 2,
        IxSEASON   = 3,
        IxFACTORY  = 4,
        IxCLASS    = 5,
        IxTOT_QTY  = 6,
        IxTOT_RATE = 7,
        IxLKS_QTY  = 8,
        IxLKS_RATE = 9,
        IxSMM_QTY  = 10,
        IxSMM_RATE = 11,
        IxRLF_QTY  = 12,
        IxRLF_RATE = 13,
        IxGTM_QTY  = 14,
        IxGTM_RATE = 15,
        IxACN_QTY  = 16,
        IxACN_RATE = 17,
        IxPRE_QTY  = 18,
        IxPRE_RATE = 19,
        IxRFC_QTY  = 20,
        IxRFC_RATE = 21,
        IxPRO_QTY  = 22,
        IxPRO_RATE = 23,
    }

    public enum TBEIS_DD_REPORT_SEASON_NEW : int
    {
        IxDIV           = 0,
        IxSEASON_CD     = 1,
        IxSEASON_NAME   = 2,
        IxFACTORY       = 3,
        IxP_FACTORY     = 4,
        IxMODEL_ID      = 5,
        IxSRF_NO        = 6,
        IxSTYLE_CD      = 7,
        IxBOM_ID        = 8,
        IxSTYLE_NAME    = 9,
        IxCOLOR_VER     = 10,
        IxLEV           = 11,
        IxITEM_01       = 12,
        IxC11B          = 13,
        IxC11S          = 14,
        IxC11M          = 15,
        IxC12B          = 16,
        IxC12S          = 17,
        IxC12M          = 18,
        IxC13B          = 19,
        IxC13S          = 20,
        IxC13M          = 21,
        IxC14B          = 22,
        IxC14S          = 23,
        IxC14M          = 24,
        IxC21B          = 25,
        IxC21S          = 26,
        IxC21M          = 27,
        IxC22B          = 28,
        IxC22S          = 29,
        IxC22M          = 30,
        IxC23B          = 31,
        IxC23S          = 32,
        IxC23M          = 33,
        IxC24B          = 34,
        IxC24S          = 35,
        IxC24M          = 36,
        IxC31B          = 37,
        IxC31S          = 38,
        IxC31M          = 39,
        IxC32B          = 40,
        IxC32S          = 41,
        IxC32M          = 42,
        IxC33B          = 43,
        IxC33S          = 44,
        IxC33M          = 45,
        IxC34B          = 46,
        IxC34S          = 47,
        IxC34M          = 48,
        IxC41B          = 49,
        IxC41S          = 50,
        IxC41M          = 51,
        IxC42B          = 52,
        IxC42S          = 53,
        IxC42M          = 54,
        IxC43B          = 55,
        IxC43S          = 56,
        IxC43M          = 57,
        IxC44B          = 58,
        IxC44S          = 59,
        IxC44M          = 60,
        IxC51B          = 61,
        IxC51S          = 62,
        IxC51M          = 63,
        IxC52B          = 64,
        IxC52S          = 65,
        IxC52M          = 66,
        IxC53B          = 67,
        IxC53S          = 68,
        IxC53M          = 69,
        IxC54B          = 70,
        IxC54S          = 71,
        IxC54M          = 72,
        IxC61B          = 73,
        IxC61S          = 74,
        IxC61M          = 75,
        IxC62B          = 76,
        IxC62S          = 77,
        IxC62M          = 78,
        IxC63B          = 79,
        IxC63S          = 80,
        IxC63M          = 81,
        IxC64B          = 82,
        IxC64S          = 83,
        IxC64M          = 84,
        IxC71B          = 85,
        IxC71S          = 86,
        IxC71M          = 87,
        IxC72B          = 88,
        IxC72S          = 89,
        IxC72M          = 90,
        IxC73B          = 91,
        IxC73S          = 92,
        IxC73M          = 93,
        IxC74B          = 94,
        IxC74S          = 95,
        IxC74M          = 96,
        IxC81B          = 97,
        IxC81B_PER      = 98,
        IxC81S          = 99,
        IxC81S_PER      = 100,
        IxC81M          = 101,
        IxC81M_PER      = 102,
        IxC91B          = 103,
        IxC91S          = 104,
        IxC91M          = 105,
        
    }

    public enum TBEIS_DD_REPORT_SEASON_NEW_02 : int
    {
        IxDIV           = 0,
        IxSEASON_CD     = 1,
        IxSEASON_NAME   = 2,
        IxFACTORY       = 3,
        IxP_FACTORY     = 4,
        IxMODEL_ID      = 5,
        IxSRF_NO        = 6,
        IxSTYLE_CD      = 7,
        IxBOM_ID        = 8,
        IxSTYLE_NAME    = 9,
        IxCOLOR_VER     = 10,
        IxLEV           = 11,
        IxITEM_01       = 12,
        IxRUN_01B       = 13,
        IxRUN_01S       = 14,
        IxRUN_01M       = 15,
        IxRUN_02B       = 16,
        IxRUN_02S       = 17,
        IxRUN_02M       = 18,
        IxRUN_03B       = 19,
        IxRUN_03S       = 20,
        IxRUN_03M       = 21,
        IxRUN_04B       = 22,
        IxRUN_04S       = 23,
        IxRUN_04M       = 24,
        IxWTR_01B       = 25,
        IxWTR_01S       = 26,
        IxWTR_01M       = 27,
        IxWTR_02B       = 28,
        IxWTR_02S       = 29,
        IxWTR_02M       = 30,
        IxWTR_03B       = 31,
        IxWTR_03S       = 32,
        IxWTR_03M       = 33,
        IxWTR_04B       = 34,
        IxWTR_04S       = 35,
        IxWTR_04M       = 36,
        IxSPW_01B       = 37,
        IxSPW_01S       = 38,
        IxSPW_01M       = 39,
        IxSPW_02B       = 40,
        IxSPW_02S       = 41,
        IxSPW_02M       = 42,
        IxSPW_03B       = 43,
        IxSPW_03S       = 44,
        IxSPW_03M       = 45,
        IxSPW_04B       = 46,
        IxSPW_04S       = 47,
        IxSPW_04M       = 48,
        IxTEN_01B       = 49,
        IxTEN_01S       = 50,
        IxTEN_01M       = 51,
        IxTEN_02B       = 52,
        IxTEN_02S       = 53,
        IxTEN_02M       = 54,
        IxTEN_03B       = 55,
        IxTEN_03S       = 56,
        IxTEN_03M       = 57,
        IxTEN_04B       = 58,
        IxTEN_04S       = 59,
        IxTEN_04M       = 60,
        IxKID_01B       = 61,
        IxKID_01S       = 62,
        IxKID_01M       = 63,
        IxKID_02B       = 64,
        IxKID_02S       = 65,
        IxKID_02M       = 66, 
        IxKID_03B       = 67,
        IxKID_03S       = 68,
        IxKID_03M       = 69,
        IxKID_04B       = 70,
        IxKID_04S       = 71,
        IxKID_04M       = 72,
        IxKID_05B       = 73,
        IxKID_05S       = 74,
        IxKID_05M       = 75,       
        IxTRA_01B       = 76,
        IxTRA_01S       = 77,
        IxTRA_01M       = 78,
        IxTRA_02B       = 79,
        IxTRA_02S       = 80,
        IxTRA_02M       = 81,
        IxTRA_03B       = 82,
        IxTRA_03S       = 83,
        IxTRA_03M       = 84,
        IxTRA_04B       = 85,
        IxTRA_04S       = 86,
        IxTRA_04M       = 87,
        IxCPA_01B       = 88,
        IxCPA_01S       = 89,
        IxCPA_01M       = 90,
        IxCPA_02B       = 91,
        IxCPA_02S       = 92,
        IxCPA_02M       = 93,
        IxCPA_03B       = 94,
        IxCPA_03S       = 95,
        IxCPA_03M       = 96,
        IxCPA_04B       = 97,
        IxCPA_04S       = 98,
        IxCPA_04M       = 99,
        IxTOT_DD_BOM    = 100,
        IxTOT_DD_BOM_P  = 101,
        IxTOT_DD_SKU    = 102,
        IxTOT_DD_SKU_P  = 103,
        IxTOT_DD_MOD    = 104,
        IxTOT_DD_MOD_P  = 105,
        IxTOT_SPC_BOM   = 106,
        IxTOT_SPC_BOM_P = 107,
        IxTOT_SPC_SKU   = 108,
        IxTOT_SPC_SKU_P = 109,
        IxTOT_SPC_MOD   = 110,
        IxTOT_SPC_MOD_P = 111,
        IxTOT_NON_BOM   = 112,
        IxTOT_NON_BOM_P = 113,
        IxTOT_NON_SKU   = 114,
        IxTOT_NON_SKU_P = 115,
        IxTOT_NON_MOD   = 116,
        IxTOT_NON_MOD_P = 117,
        IxTOT_BOM       = 118,
        IxTOT_BOM_P     = 119,
        IxTOT_SKU       = 120,
        IxTOT_SKU_P     = 121,
        IxTOT_MOD       = 122,
        IxTOT_MOD_P     = 123,
    }

    public enum TBEIS_DD_REPORT_SEASON_POP : int
    {
        IxDIVISION   = 0,
        IxCHK        = 1,
        IxFACTORY    = 2,
        IxMODEL_ID   = 3,
        IxSRF_NO     = 4,
        IxBOM_ID     = 5,
        IxT_D        = 6,
        IxSEASON_V   = 7,
        IxFACTORY_V  = 8,        
        IxSTYLE_NAME = 9,
        IxMODEL_ID_V = 10,        
        IxCOLOR_VER  = 11,
        IxBOM_ID_V   = 12,
        IxCOPY_DEV   = 13,
        IxCATEGORY_V = 14,
        IxSTYLE_CD   = 15,
        IxT_D_V      = 16,
        IxP_FACTORY  = 17,
        IxSPC_YN     = 18,
        IxLKS        = 19,
        IxSMM        = 20,
        IxRLF        = 21,
        IxACN        = 22,
        IxGTM        = 23,
        IxPRE        = 24,
        IxRFC        = 25,
        IxPRO        = 26,
        IxOTH        = 27,
        IxUPD_USER   = 28,
        IxUPD_YMD    = 29,
                       
    }
    public enum TBEIS_DD_REPORT_SEASON_POP_NEW : int
    {
        IxDIVISION   = 0,
        IxCHK        = 1,
        IxFACTORY    = 2,
        IxMODEL_ID   = 3,
        IxSRF_NO     = 4,
        IxBOM_ID     = 5,
        IxT_D        = 6,
        IxSEASON_V   = 7,
        IxFACTORY_V  = 8,        
        IxSTYLE_NAME = 9,        
        IxSRF_NO_V   = 10,
        IxCOLOR_VER  = 11,
        IxBOM_ID_V   = 12,
        IxCOPY_DEV   = 13,        
        IxMODEL_ID_V = 14,
        IxGEN_CD     = 15,
        IxCATEGORY_V = 16,
        IxSTYLE_CD   = 17,
        IxT_D_V      = 18,
        IxP_FACTORY  = 19,
        IxSPC_YN     = 20,
        IxOFF_YN     = 21,
        IxLKS        = 22,
        IxSMM        = 23,
        IxRLF        = 24,
        IxACN        = 25,
        IxGTM        = 26,
        IxPRE        = 27,
        IxRFC        = 28,
        IxPRO        = 29,
        IxOTH        = 30,
        IxDROP_YN    = 31,
        IxUPD_USER   = 32,
        IxUPD_YMD    = 33,
                       
    }


    public enum TBEIS_DD_REPORT_MODEL : int
    {
        IxDIV             = 0, 
        IxLEV             = 1, 
        IxSEASON_CD       = 2,  
        IxFACTORY         = 3, 
        IxSTYLE_NAME      = 4, 
        IxITEM_01         = 5,
        IxC01B            = 6,
        IxC01M            = 7,
        IxC02B            = 8,
        IxC02M            = 9,
        IxC11B            = 10,
        IxC11M            = 11,
        IxC12B            = 12,
        IxC12M            = 13,
        IxC21B            = 14,
        IxC21M            = 15,
        IxC22B            = 16,
        IxC22M            = 17,
        IxC31B            = 18,
        IxC31M            = 19,
        IxC32B            = 20,
        IxC32M            = 21,
        IxC41B            = 22, 
        IxC41M            = 23,
        IxC42B            = 24,
        IxC42M            = 25,
        IxC51B            = 26,
        IxC51M            = 27,
        IxC52B            = 28,
        IxC52M            = 29,
        IxC61B            = 30,
        IxC61M            = 31,
        IxC62B            = 32,
        IxC62M            = 33,
        
                          
    }                     
           
    //Model/BOM Tracking
    public enum TBEIS_MODEL_BOM_TRACKING : int
    {
        IxDIV            = 0, 
        IxSEASON_CD      = 1, 
        IxFACTORY        = 2,   
        IxCATEGORY       = 3, 
        IxSRF_NO         = 4, 
        IxBOM_ID         = 5,     
        IxLEV            = 6,
        IxITEM_01        = 7,
        IxWOKER_CNT      = 8,
        IxMODEL_CNT      = 9,
        IxBOM_CNT        = 10,
        IxTD_CNT         = 11,
        IxCOLOR_VER      = 12,
        IxT_D            = 13,
        IxCOPY_DEV       = 14,
        IxNLO_DEV        = 15,
        IxWHQ_DEV        = 16,
        IxP_FACTORY      = 17,
        IxSTYLE_CD       = 18,   
        IxDPO_QTY        = 19,
        IxFOB            = 20,
        IxSUM_FGA_QTY    = 21,
        IxLKS_FGA_QTY    = 22,
        IxSMM_FGA_QTY    = 23,
        IxRLF_FGA_QTY    = 24,
        IxGTM_FGA_QTY    = 25,
        IxACN_FGA_QTY    = 26,
        IxPRE_FGA_QTY    = 27,
        IxRFC_FGA_QTY    = 28,
        IxPRO_FGA_QTY    = 29,
        IxOTH_FGA_QTY    = 30,        
    } 
    
    public enum TBEIS_MODEL_BOM_TRACKING_NEW : int
    {
        IxDIV            = 0,
        IxSEASON_CD      = 1,
        IxFACTORY        = 2,
        IxCATEGORY       = 3,
        IxSRF_NO         = 4,
        IxBOM_ID         = 5,
        IxLEV            = 6,
        IxITEM_01        = 7,
        IxWOKER_CNT      = 8,
        IxTD_CNT         = 9,
        IxCOLOR_VER      = 10,
        IxT_D            = 11,
        IxCOPY_DEV       = 12,
        IxNLO_DEV        = 13,
        IxWHQ_DEV        = 14,
        IxP_FACTORY      = 15,
        IxSTYLE_CD       = 16,
        IxDPO_QTY        = 17,
        IxFOB            = 18,
        IxMODEL_CNT      = 19,
        IxBOM_CNT        = 20,
        IxSUM_FGA_QTY    = 21,
        IxLKS_FGA_QTY    = 22,
        IxSMM_FGA_QTY    = 23,
        IxRLF_FGA_QTY    = 24,
        IxGTM_FGA_QTY    = 25,
        IxACN_FGA_QTY    = 26,
        IxPRE_FGA_QTY    = 27,
        IxRFC_FGA_QTY    = 28,
        IxPRO_FGA_QTY    = 29,
    }
    
    //Production Analysis
    public enum TBEDM_PCC_PROD_MONTH : int
    {
        IxMAX_CNT   = 9,

        IxDIV       = 0,
        IxT_LEV     = 1,
        IxFACTORY   = 2,        
        IxOP_CD     = 3,
        IxCATEGORY  = 4,
        IxNF_CD     = 5,
        IxITEM      = 6,
        IxDATE      = 7,
        IxQTY       = 8,        
    }
    public enum TBEDM_PCC_PROD_DAY : int
    {
         
        IxDIV       = 0,
        IxT_LEV     = 1,
        IxFACTORY   = 2,
        IxCATEGORY  = 3,
        IxNF_CD     = 4,
        IxTITLE     = 5,
        IxTOTAL_SUM = 6,
        IxDAY_01    = 7,
        IxDAY_02    = 8,
        IxDAY_03    = 9,
        IxDAY_04    = 10,
        IxDAY_05    = 11,
        IxDAY_06    = 12,
        IxDAY_07    = 13,
        IxDAY_08    = 14,
        IxDAY_09    = 15,
        IxDAY_10    = 16,
        IxDAY_11    = 17,
        IxDAY_12    = 18,
        IxDAY_13    = 19,
        IxDAY_14    = 20,
        IxDAY_15    = 21,
        IxDAY_16    = 22,
        IxDAY_17    = 23,
        IxDAY_18    = 24,
        IxDAY_19    = 25,
        IxDAY_20    = 26,
        IxDAY_21    = 27,
        IxDAY_22    = 28,
        IxDAY_23    = 29,
        IxDAY_24    = 30,
        IxDAY_25    = 31,
        IxDAY_26    = 32,
        IxDAY_27    = 33,
        IxDAY_28    = 34,
        IxDAY_29    = 35,
        IxDAY_30    = 36,
        IxDAY_31    = 37,

    }

    //Production Life Cycle
    public enum TBEDM_PCC_PROD_LIFE : int
    {
        IxDIV       = 0,
        IxT_LEV     = 1,
        IxSEASON_CD = 2,
        IxFACTORY   = 3,
        IxCATEGORY  = 4,
        IxSRF_NO    = 5,
        IxBOM_ID    = 6,
        IxITEM      = 7, 
        IxLKS_F_YMD = 8, 
        IxLKS_T_YMD = 9, 
        IxSMM_F_YMD = 10,
        IxSMM_T_YMD = 11, 
        IxRLF_F_YMD = 12, 
        IxRLF_T_YMD = 13, 
        IxGTM_F_YMD = 14, 
        IxGTM_T_YMD = 15, 
        IxACN_F_YMD = 16, 
        IxACN_T_YMD = 17, 
        IxPRE_F_YMD = 18, 
        IxPRE_T_YMD = 19, 
        IxRFC_F_YMD = 20, 
        IxRFC_T_YMD = 21, 
        IxPRO_F_YMD = 22, 
        IxPRO_T_YMD = 23, 
        IxOTH_F_YMD = 24, 
        IxOTH_T_YMD = 25,         
    }       

    public enum TBEIS_DD_STATUS : int
    {
        IxMAX_CNT = 15,

        IxDIV         = 0,
        IxSEASON_CD   = 1,
        IxFACTORY     = 2,
        IxP_FACTORY   = 3,
        IxSEASON_NAME = 4,
        IxFACTORY_V   = 5,
        IxRUNNING     = 6,
        IxWS_TRAINING = 7,
        IxSPORT_WEAR  = 8,
        IxCP_TENNIS   = 9,
        IxKIDS        = 10,
        IxTRACK_FIELD = 11,
        IxTOT_DD_BOM  = 12,
        IxPERCENT     = 13,
        IxREMARKS     = 14,        
    }

    public enum TBEIS_DD_PROD_FTY : int
    {
        IxMAX_CNT = 9,

        IxDIV           = 0,
        IxSEASON_CD     = 1,
        IxSEASON_NAME   = 2,
        IxQD_FACTORY    = 3,
        IxTOT_QD        = 4,
        IxPER_QD        = 5,
        IxVJ_FACTORY    = 6,
        IxTOT_VJ        = 7,
        IxPER_VJ        = 8,           
    }
    #endregion

    #region EIS Category
    //Production SRF Category
    public enum TBEDM_PCC_SRF_CATEGORY : int
    {
        lxDIVISION = 0,
        lxLEVELS = 1,
        lxLEVELS_NAME = 2,
        lxREP_SRF_NO = 3,
        lxSRF_NO = 4,
        lxSTYLE_CD = 5,
        lxSTYLE_NAME = 6,
        lxCATEGORY_CD = 7,
        lxCATEGORY_NAME = 8,
        lxCOLOR_DEV = 9,
        lxPCC_DEV = 10,
        lxSEASON_CD = 11,
        lxSTATUS = 12,
        lxCOL_ORDER = 13,

    }
    #endregion

   #region EIS FOB

    public enum TBEIS_FOB_MASTER : int
    {
        IxMaxCt                = 56,	// 인덱스 Count
        IxDIV                  = 0,     // Division
        IxROUND                = 1, 	// Round : ()
        IxFACTORY              = 2, 	// Factory : ()
        IxMO_ALIAS             = 3, 	// MO Alias : ()
        IxSEASON               = 4, 	// Season : ()
        IxCATEGORY             = 5, 	// Category : ()
        IxSTYLE_NAME           = 6, 	// Model : ()
        IxSTYLE_CD             = 7, 	// Style : ()
        IxOBS_ID               = 8, 	// OBS ID : ()
        IxOBS_TYPE             = 9, 	// OBS Type : ()
        IxBOM_ID               = 10, 	// BOM ID : ()
        IxFOB_TYPE             = 11, 	// FOB Type : ()
        IxCHK                  = 12, 	// Detail : ()
        IxQUOTED_YMD           = 13, 	// Quoted Date : ()
        IxGEN_CD               = 14, 	// Gender : ()
        IxSIZE_CD              = 15, 	// Code : ()
        IxSIZE_UP              = 16, 	// Up   : ()
        IxUP                   = 17, 	// Up : ()
        IxBOTTOM               = 18, 	// Bottom : ()
        IxEXTRA                = 19, 	// Extra : ()
        IxM_UPPER              = 20, 	// Upper : ()
        IxM_PACKAGING          = 21, 	// Packing : ()
        IxM_MIDSOLE            = 22, 	// Midsole : ()
        IxM_OUT_SOLE           = 23, 	// Outsole : ()
        IxM_SIZE_UP            = 24, 	// Size Up : ()
        IxM_PRICE              = 25, 	// M Total : ()
        IxM_RATIO              = 26, 	// M Ratio : ()
        IxL_OH                 = 27, 	// L OH : ()
        IxPROFIT               = 28, 	// Profit : ()
        IxOTHER_AD             = 29, 	// Other AD : ()
        IxNM_PRICE             = 30, 	// NM Total : ()
        IxT_SAMPLE             = 31, 	// Sample : ()
        IxT_PRODUCTION         = 32, 	// Production : ()
        IxTOOLING              = 33, 	// T  Total : ()
        IxFOB                  = 34, 	// FOB : ()
        IxFOB_STATUS           = 35, 	// Status : ()
        IxFACTORY_FOB          = 36, 	// Factory : ()
        IxMARGIN_RATE          = 37, 	// Margin Rate : ()
        IxRATE_IDR             = 38, 	// IDR : ()
        IxRATE_INR             = 39, 	// INR : ()
        IxRATE_KRW             = 40, 	// KRW : ()
        IxRATE_RMB             = 41, 	// RMB : ()
        IxRATE_THB             = 42, 	// THB : ()
        IxRATE_TWD             = 43, 	// TWD : ()
        IxRATE_USD             = 44, 	// USD : ()
        IxRATE_VND             = 45, 	// VND : ()
        IxFORECAST             = 46, 	// Forecast : ()
        IxPEAK                 = 47, 	// Peak : ()
        IxRETAIL               = 48, 	// Retail : ()
        IxTARGET               = 49, 	// Target : ()
        IxPATTERN_DESC         = 50, 	// Pattern : ()
        IxTOOLING_DESC         = 51, 	// Tooling : ()
        IxSIZE_DESC            = 52, 	// Size : ()
        IxREMARKS              = 53, 	// Remarks : ()
        IxSTATUS               = 54, 	// Status : ()
        IxUPD_USER             = 55, 	// User : ()
        IxUPD_YMD              = 56 	// Date : ()
    }


    public enum TBEIS_FOB_DETAIL : int
    {
        IxDIV                 = 0,
        IxFACTORY             = 1,
        IxOBS_ID              = 2,
        IxOBS_TYPE            = 3,
        IxSTYLE_CD            = 4,
        IxSEQ                 = 5,
        IxBOM_ID              = 6,
        IxSIZE_EXCLD          = 7,
        IxCLASS               = 8,
        IxSUB_CLASS           = 9,
        IxCBD                 = 10,
        IxPART                = 11,
        IxMAT_NAME            = 12,
        IxVENDOR              = 13,
        IxCOLOR               = 14,
        IxMAT_NO              = 15,
        IxUOM                 = 16,
        IxCURR                = 17,
        IxFX_RATE             = 18,
        IxMAT_PRICE           = 19,
        IxFRT_TRM             = 20,
        IxFCT_LND_RATE        = 21,
        IxFCT_LND_TOT         = 22,
        IxFCT_LND_USD_TOT     = 23,
        IxYIELD               = 24,
        IxLOSS_RATE           = 25,
        IxUSAGE               = 26,
        IxUS_COST             = 27,
        IxSIZE_TOT_COST       = 28,
        IxSIZING_UP_CHARGE    = 29,
        IxPROCESSING_COST     = 30,
        IxUPDATE_YMD          = 31,
        IxREMARKS             = 32,
        IxSTATUS              = 33,
        IxUPD_USER            = 34,
        IxUPD_YMD             = 35,
    }
    public enum TBEIS_FOB_LABOR : int
    {
        IxDIV                  = 0,
        IxFACTORY              = 1,
        IxOBS_ID               = 2,
        IxSTYLE_CD             = 3,
        IxSEQ                  = 4,
        IxCLASS                = 5,
        IxSUB_CLASS            = 6,
        IxCURR                 = 7,
        IxFX_RATE              = 8,
        IxPROCESS              = 9,
        IxDIRECT_ANNUAL_WAGES  = 10,
        IxDIRECT_LABOR_WORKER  = 11,
        IxDAY_PAID_ANNUALY     = 12,
        IxMINUTE_DAY_WORKER    = 13,
        IxEFFCTV_RATE          = 14,
        IxCOST_STD_MINUTE      = 15,
        IxSTD_MINUTES_PAIR     = 16,
        IxCOST_PAIR_LOCAL      = 17,
        IxCOST_PAIR_USD        = 18,
        IxOV_COST_PR           = 19,
        IxUPDATE_YMD           = 20,
        IxREMARKS              = 21,
        IxSTATUS               = 22,
        IxUPD_USER             = 23,
        IxUPD_YMD              = 24,             
    }
    public enum TBEIS_FOB_OVERHEAD : int
    {
        IxDIV           = 0,
        IxFACTORY       = 1,
        IxOBS_ID        = 2,
        IxSTYLE_CD      = 3,
        IxSEQ           = 4,
        IxCLASS         = 5,
        IxSUB_CLASS     = 6,
        IxCURR          = 7,
        IxFX_RATE       = 8,
        IxITEM          = 9,
        IxLOCAL_COST    = 10,
        IxUSD_COST      = 11,
        IxUPDATE_YMD    = 12,
        IxREMARKS       = 13,
        IxSTATUS        = 14,
        IxUPD_USER      = 15,
        IxUPD_YMD       = 16,       
    }
    public enum TBEIS_FOB_MOLD : int
    {
        IxMaxCt         = 24,	// 인덱스 Count
        IxFACTORY       = 1, 	// Factory : ()
        IxOBS_ID        = 2, 	// OBS ID : ()
        IxSTYLE_CD      = 3, 	// Style : ()
        IxSEQ           = 4, 	// Seq : ()
        IxCLASS         = 5, 	// Class : ()
        IxMOLD_SET      = 6, 	// Set : ()
        IxMOLD_TYPE     = 7, 	// Type : ()
        IxMOLD_CODE     = 8, 	// Code : ()
        IxPIM_SEQ       = 9, 	// Seq : ()
        IxDESCRIPTION   = 10, 	// Description : ()
        IxMOLDS_NO      = 11, 	// # of Molds : ()
        IxCURR          = 12, 	// Curr. : ()
        IxFX_RATE       = 13, 	// FX Rate : ()
        IxMOLD_COST     = 14, 	// Cost/Mold : ()
        IxTOTAL_COST    = 15, 	// Total Cost : ()
        IxUSD           = 16, 	// USD : ()
        IxAMORT_PAIRS   = 17, 	// Amort Pairs : ()
        IxUSD_PAIR      = 18, 	// USD/Pair : ()
        IxNOTES         = 19, 	// Notes : ()
        IxUPDATE_YMD    = 20, 	// Update Date : ()
        IxREMARKS       = 21, 	// Remarks : ()
        IxSTATUS        = 22, 	// Status : ()
        IxUPD_USER      = 23, 	// User : ()
        IxUPD_YMD       = 24 	// Date : ()
    }
    public enum TBEBM_FOB_DETAIL_LOAD : int
    {
        IxMaxCt         = 35,	// 인덱스 Count 
        IxFACTORY       = 1,	// 	:VARCHAR2(100) 
        IxOBS_ID        = 2,	// 	:VARCHAR2(100) 
        IxOBS_TYPE      = 3,	// 	:VARCHAR2(100) 
        IxSTYLE_CD      = 4,	// 	:VARCHAR2(100) 
        IxSEQ           = 5,	// 	:NUMBER(22) 
        IxBOM_ID        = 6,	// 	:VARCHAR2(100) 
        IxSIZE_EXCLD    = 7,	// 	:VARCHAR2(100) 
        IxCLASS         = 8,	// 	:VARCHAR2(100) 
        IxSUB_CLASS     = 9,	// 	:VARCHAR2(100) 
        IxCBD           = 10,	// 	:VARCHAR2(100) 
        IxPART          = 11,	// 	:VARCHAR2(100) 
        IxMAT_NAME      = 12,	// 	:VARCHAR2(100) 
        IxVENDOR        = 13,	// 	:VARCHAR2(100) 
        IxCOLOR         = 14,	// 	:VARCHAR2(100) 
        IxMAT_NO        = 15,	// 	:VARCHAR2(100) 
        IxUOM           = 16,	// 	:VARCHAR2(100) 
        IxCURR          = 17,	// 	:VARCHAR2(100) 
        IxFX_RATE       = 18,	// 	:NUMBER(22) 
        IxMAT_PRICE     = 19,	// 	:VARCHAR2(100) 
        IxFRT_TRM       = 20,	// 	:VARCHAR2(100) 
        IxFCT_LND_RATE  = 21,	// 	:NUMBER(22) 
        IxFCT_LND_TOT   = 22,	// 	:NUMBER(22) 
        IxFCT_LND_USD_TOT = 23,	// 	:NUMBER(22) 
        IxYIELD         = 24,	// 	:NUMBER(22) 
        IxLOSS_RATE     = 25,	// 	:NUMBER(22) 
        IxUSAGE         = 26,	// 	:NUMBER(22) 
        IxUS_COST       = 27,	// 	:NUMBER(22) 
        IxSIZE_TOT_COST = 28,	// 	:NUMBER(22) 
        IxSIZING_UP_CHARGE = 29,// 	:NUMBER(22) 
        IxPROCESSING_COST = 30,	// 	:NUMBER(22) 
        IxUPDATE_YMD    = 31,	// 	:VARCHAR2(8) 
        IxREMARKS       = 32,	// 	:VARCHAR2(100) 
        IxSTATUS        = 33,	// 	:VARCHAR2(100) 
        IxUPD_USER      = 34,	// 	:VARCHAR2(100) 
        IxUPD_YMD       = 35,	// 	:DATE(7) 
    }

    public enum TBEIS_FOB_LIST_IN_MPS : int
    { 
       
        IxFACTORY       = 1,
        IxCATEGORY_CD   = 2,
        IxCATEGORY_NAME = 3,
        IxMODEL_CD      = 4,
        IxMODEL_NAME    = 5,
        IxSTYLE_CD      = 6,
        IxOBS_ID        = 7,
        IxOBS_TYPE      = 8,
        lxSTATUS        = 9,
        IxCOMPONENT     = 10,
        IxGAC_YMD       = 11,
        lxOVER_GAC      = 12,       
        IxDETAIL        = 13,
        IxUP            = 14,
        IxBOTTOM        = 15,
        IxM_PRICE       = 16,
        IxM_RATIO       = 17,
        IxEXTRA         = 18,
        IxL_OH          = 19,
        IxPROFIT        = 20,
        IxTOOLING       = 21,
        IxFOB           = 22,
        IxDEDUCTION     = 23,
        IxREMARKS       = 24,
        IxUPD_USER      = 25,
        IxNEW_YN        = 26,   

    }
    public enum TBEIS_MATPRICE_MODEL_QTY : int
    {

        IxFACTORY = 1,
        IxMODEL_CD = 2,
        IxMODEL_NAME = 3,
        IxOBS_ID = 4,
        IxOBS_TYPE = 5,
        IxOBS_QTY = 6,


    }
    public enum TBEIS_FOB_TREND_ANALYSIS : int
    {
        IxDIVISION = 0,
        IxFACTORY = 1,
        IxEIS_MONTH = 2,
        IxFOB_AVG = 3,
        IxFOB_AMT = 4,
        IxMAT_AVG = 5,
        IxMAT_AMT = 6,
        IxTOOLING_AVG = 7,
        IxTOOLING_AMT = 8,
        IxEXTRA_AVG = 9,
        IxEXTRA_AMT = 10,
        IxPROFIT_AVG = 11,
        IxPROFIT_AMT = 12,
        IxL_OH_AVG = 13,
        IxL_OH_AMT = 14,
    }
    #endregion

    #region ÀÚÀç MPS
    /// <summary> 
	/// MPS By OP Å×ÀÌºí ÀÎµ¦½º Enum 
	/// </summary> 
	public enum TBSPD_WORKSHEET_MPS_BSC : int 
	{  		  
		
		IxLINE_CD			= 1,			 
		IxLINE_NAME			= 2,
		IxMODEL_NAME		= 3,
		IxSTYLE_CD			= 4,		
		IxGEN				= 5,
		IxOBS_ID			= 6,
		IxOBS_TYPE			= 7,  
		IxLOT				= 8, 
		IxRTS_YMD			= 9,  
		IxOGAC				=10, 
		IxPO_NO				=11,  
		IxORD_QTY			=12,
		IxLOSS_QTY			=13,
		IxSUM_QTY			=14, 
		IxPLAN_STATUS		=15, 
		IxREAL_LOTYN		=16,  
		IxYMD_START			=17,
 
 
		IxTBYMD_THEDAY		= 0,
		IxTBYMD_WEEKDAY		= 1, 
		IxTBYMD_HOLI_YN		= 2,
	 

		IxTBH_LINE_CD		= 0,			 
		IxTBH_LINE_NAME		= 1,
		IxTBH_MODEL_NAME	= 2,
		IxTBH_STYLE_CD		= 3,	
		IxTBH_GEN			= 4,
		IxTBH_OBS_ID		= 5,
		IxTBH_OBS_TYPE		= 6, 
		IxTBH_LOT			= 7, 
		IxTBH_RTS_YMD		= 8,  	
		IxTBH_OGAC			= 9, 
		IxTBH_PO_NO			=10, 
		IxTBH_ORD_QTY		=11, 
		IxTBH_LOSS_QTY		=12,
		IxTBH_SUM_QTY		=13, 		
		IxTBH_PLAN_STATUS	=14,  
		IxTBH_REAL_LOTYN	=15,  

		IxTBD_LOT			= 0,
		IxTBD_PLAN_STATUS	= 1,
		IxTBD_REAL_LOTYN	= 2,
		IxTBD_OP_STR_YMD	= 3,
		IxTBD_SIZE_QTY		= 4,
		IxTBD_DEADLINE_YN	= 5,
		IxTBD_TS_FINISH_YN  = 6,


    }
    #endregion

    #region PMS

    #region TD Management
    public enum TBSXC_TD_MANAGEMENT_DEV : int 
	{
        IxMAX_CNT     = 19,

        IxDIVISION    = 0,
        IxFACTORY     = 1,        
        IxSEASON_CD   = 2,
        IxCATEGORY    = 3,        
        IxFACTORY_V   = 4,        
        IxSEASON_V    = 5,
        IxCATEGORY_V  = 6,        
        IxNF_010_YMD  = 7,
        IxNF_020_YMD  = 8,
        IxNF_030_YMD  = 9,
        IxNF_040_YMD  = 10,
        IxNF_050_YMD  = 11,
        IxNF_060_YMD  = 12,
        IxNF_070_YMD  = 13,
        IxNF_080_YMD  = 14,
        IxNF_090_YMD  = 15,        
        IxSTATUS      = 16,
        IxUPD_USER    = 17,
        IxUPD_YMD     = 18,        
    }
    public enum TBSXC_TD_MANAGEMENT_COMM : int 
	{
        IxMAX_CNT     = 56,

        IxDIVISION    = 0,
        IxFACTORY     = 1,
        IxP_FACTORY   = 2,
        IxSEASON_CD   = 3,
        IxCATEGORY    = 4,
        IxTD_CD       = 5,
        IxFACTORY_V   = 6,
        IxP_FACOTRY_V = 7,
        IxSEASON_V    = 8,
        IxCATEGORY_V  = 9,
        IxTD_CD_V     = 10,
        IxNF_100_YN   = 11,
        IxNF_100_DAYS = 12,
        IxNF_110_YN   = 13,
        IxNF_110_DAYS = 14,
        IxNF_120_YN   = 15,
        IxNF_120_DAYS = 16,
        IxNF_130_YN   = 17,
        IxNF_130_DAYS = 18,
        IxNF_140_YN   = 19,
        IxNF_140_DAYS = 20,
        IxNF_150_YN   = 21,
        IxNF_150_DAYS = 22,
        IxNF_160_YN   = 23,
        IxNF_160_DAYS = 24,
        IxNF_170_YN   = 25,
        IxNF_170_DAYS = 26,
        IxNF_180_YN   = 27,
        IxNF_180_DAYS = 28,
        IxNF_190_YN   = 29,
        IxNF_190_DAYS = 30,
        IxNF_200_YN   = 31,
        IxNF_200_DAYS = 32,
        IxNF_210_YN   = 33,
        IxNF_210_DAYS = 34,
        IxNF_220_YN   = 35,
        IxNF_220_DAYS = 36,
        IxNF_230_YN   = 37,
        IxNF_230_DAYS = 38,
        IxNF_240_YN   = 39,
        IxNF_240_DAYS = 40,
        IxNF_250_YN   = 41,
        IxNF_250_DAYS = 42,
        IxNF_260_YN   = 43,
        IxNF_260_DAYS = 44,
        IxNF_270_YN   = 45,
        IxNF_270_DAYS = 46,
        IxNF_280_YN   = 47,
        IxNF_280_DAYS = 48,
        IxNF_290_YN   = 49,
        IxNF_290_DAYS = 50,
        IxNF_300_YN   = 51,
        IxNF_300_DAYS = 52,
        IxSTATUS      = 53,
        IxUPD_USER    = 54,
        IxUPD_YMD     = 55,        
    }
  
    public enum TBSXC_TASK_MANAGEMENT : int 
	{
        IxMAX_CNT    = 12,

        IxDIV        = 0,
        IxFACTORY    = 1,
        IxNF_CD      = 2,
        IxNF_SEQ     = 3,
        IxNF_DESC    = 4,
        IxNF_SEQ_V   = 5,
        IxTK_CD      = 6,
        IxTK_DAYS    = 7,
        IxTK_YN      = 8,
        IxSTATUS     = 9,
        IxUPD_USER   = 10,
        IxUPD_YMD    = 11,
    }
    #endregion

    #region Schedule Management    
    public enum TBSXC_SCH_MANAGEMENT: int
    {
        IxMAX_CNT       = 134,

        IxDIV           = 0,
        IxFACTORY       = 1,
        IxMODEL_ID      = 2,
        IxSRF_NO        = 3,
        IxLEV           = 4,
        IxITEM_SEQ      = 5,
        IxSTYLE_NAME    = 6,
        IxSEASON_CD     = 7,
        IxP_FACTORY     = 8,
        IxCATEGORY      = 9,
        IxCHK_PT        = 10, 
        IxCHK_FILE      = 11, 
        IxCHK_IMAGE     = 12, 
        IxFACTORY_V     = 13, 
        IxSEASON_V      = 14,   
        IxCATEGORY_V    = 15,
        IxREP_YN        = 16,
        IxITEM_NAME     = 17, 
        IxGENDER        = 18, 
        IxMO_ID         = 19, 
        IxTD            = 20,
        IxN010_T01      = 21,
        IxN010_T01_P    = 22,
        IxN010_T02      = 23,
        IxN010_T02_P    = 24,
        IxN010_T03      = 25,
        IxN010_T03_P    = 26,
        IxN010_T04      = 27,
        IxN010_T04_P    = 28,
        IxN010_T05      = 29,
        IxN010_T05_P    = 30,
        IxN020_T01      = 31,
        IxN020_T01_P    = 32,
        IxN020_T02      = 33,
        IxN020_T02_P    = 34,
        IxN020_T03      = 35,
        IxN020_T03_P    = 36,
        IxN020_T04      = 37,
        IxN020_T04_P    = 38,
        IxN020_T05      = 39,
        IxN020_T05_P    = 40,
        IxN030_T01      = 41,
        IxN030_T01_P    = 42,
        IxN040_T01      = 43,
        IxN040_T01_P    = 44,
        IxN040_T02      = 45,
        IxN040_T02_P    = 46,
        IxN040_T03      = 47,
        IxN040_T03_P    = 48,
        IxN040_T04      = 49,
        IxN040_T04_P    = 50,
        IxN040_T05      = 51,
        IxN040_T05_P    = 52,
        IxN050_T01      = 53,
        IxN050_T01_P    = 54,
        IxN050_T02      = 55,
        IxN050_T02_P    = 56,
        IxN050_T03      = 57,
        IxN050_T03_P    = 58,
        IxN050_T04      = 59,
        IxN050_T04_P    = 60,
        IxN050_T05      = 61,
        IxN050_T05_P    = 62,
        IxN060_T01      = 63,
        IxN060_T01_P    = 64,
        IxN070_T01      = 65,
        IxN070_T01_P    = 66,
        IxN070_T02      = 67,
        IxN070_T02_P    = 68,
        IxN070_T03      = 69,
        IxN070_T03_P    = 70,
        IxN070_T04      = 71,
        IxN070_T04_P    = 72,
        IxN070_T05      = 73,
        IxN070_T05_P    = 74,
        IxN080_T01      = 75,
        IxN080_T01_P    = 76,
        IxN080_T02      = 77,
        IxN080_T02_P    = 78,
        IxN080_T03      = 79,
        IxN080_T03_P    = 80,
        IxN080_T04      = 81,
        IxN080_T04_P    = 82,
        IxN080_T05      = 83,
        IxN080_T05_P    = 84,
        IxN090_T01      = 85,
        IxN090_T01_P    = 86,
        IxN100_T01      = 87,
        IxN100_T01_P    = 88,
        IxN110_T01      = 89,
        IxN110_T01_P    = 90,
        IxN120_T01      = 91,
        IxN120_T01_P    = 92,
        IxN130_T01      = 93,
        IxN130_T01_P    = 94,
        IxN140_T01      = 95,
        IxN140_T01_P    = 96,
        IxN150_T01      = 97,
        IxN150_T01_P    = 98,
        IxN160_T01      = 99,
        IxN160_T01_P    = 100,
        IxN170_T01      = 101,
        IxN170_T01_P    = 102,
        IxN180_T01      = 103,
        IxN180_T01_P    = 104,
        IxN190_T01      = 105,
        IxN190_T01_P    = 106,
        IxN200_T01      = 107,
        IxN200_T01_P    = 108,
        IxN210_T01      = 109,
        IxN210_T01_P    = 110,
        IxN220_T01      = 111,
        IxN220_T01_P    = 112,
        IxN230_T01      = 113,
        IxN230_T01_P    = 114,
        IxN240_T01      = 115,
        IxN240_T01_P    = 116,
        IxN250_T01      = 117,
        IxN250_T01_P    = 118,
        IxN260_T01      = 119,
        IxN260_T01_P    = 120,
        IxN270_T01      = 121,
        IxN270_T01_P    = 122,
        IxN280_T01      = 123,
        IxN280_T01_P    = 124,
        IxN290_T01      = 125,
        IxN290_T01_P    = 126,
        IxN300_T01      = 127,
        IxN300_T01_P    = 128,
        IxIPW_YMD       = 129,
        IxREMARKS       = 130,
        IxSTATUS        = 131,
        IxUPD_USER      = 132,
        IxUPD_YMD       = 133,
                
    }

    public enum TBSXC_SCH_MANAGEMENT_NEW: int
    {
        IxMAX_CNT       = 117,

        IxDIV           = 0,
        IxFACTORY       = 1,
        IxMODEL_ID      = 2,
        IxSRF_NO        = 3,
        IxLEV           = 4,
        IxITEM_SEQ      = 5,
        IxSTYLE_NAME    = 6,
        IxSEASON_CD     = 7,
        IxP_FACTORY     = 8,
        IxCATEGORY      = 9,
        IxCHK_PT        = 10, 
        IxCHK_FILE      = 11, 
        IxFACTORY_V     = 12, 
        IxSEASON_V      = 13,    
        IxCATEGORY_V    = 14,
        IxREP_YN        = 15,
        IxITEM_NAME     = 16,
        IxGENDER        = 17, 
        IxMO_ID         = 18, 
        IxTD            = 19, 
        IxN010_T01      = 20,
        IxN010_T01_P    = 21,           
        IxN020_T01      = 22,
        IxN020_T01_P    = 23,
        IxN020_T02      = 24,
        IxN020_T02_P    = 25,
        IxN020_T03      = 26,
        IxN020_T03_P    = 27,
        IxN020_T04      = 28,
        IxN020_T04_P    = 29,
        IxN020_T05      = 30,
        IxN020_T05_P    = 31,
        IxN030_T01      = 32,
        IxN030_T01_P    = 33,
        IxN040_T01      = 34,
        IxN040_T01_P    = 35,
        IxN040_T02      = 36,
        IxN040_T02_P    = 37,
        IxN040_T03      = 38,
        IxN040_T03_P    = 39,
        IxN040_T04      = 40,
        IxN040_T04_P    = 41,
        IxN040_T05      = 42,
        IxN040_T05_P    = 43,
        IxN050_T01      = 44,
        IxN050_T01_P    = 45,
        IxN060_T01      = 46,
        IxN060_T01_P    = 47,
        IxN070_T01      = 48,
        IxN070_T01_P    = 49,
        IxN070_T02      = 50,
        IxN070_T02_P    = 51,
        IxN070_T03      = 52,
        IxN070_T03_P    = 53,
        IxN070_T04      = 54,
        IxN070_T04_P    = 55,
        IxN070_T05      = 56,
        IxN070_T05_P    = 57,
        IxN080_T01      = 58,
        IxN080_T01_P    = 59,
        IxN080_T02      = 60,
        IxN080_T02_P    = 61,
        IxN080_T03      = 62,
        IxN080_T03_P    = 63,
        IxN080_T04      = 64,
        IxN080_T04_P    = 65,
        IxN080_T05      = 66,
        IxN080_T05_P    = 67,
        IxN090_T01      = 68,
        IxN090_T01_P    = 69,
        IxN100_T01      = 70,
        IxN100_T01_P    = 71,
        IxN110_T01      = 72,
        IxN110_T01_P    = 73,
        IxN120_T01      = 74,
        IxN120_T01_P    = 75,
        IxN130_T01      = 76,
        IxN130_T01_P    = 77,
        IxN140_T01      = 78,
        IxN140_T01_P    = 79,
        IxN150_T01      = 80,
        IxN150_T01_P    = 81,
        IxN160_T01      = 82,
        IxN160_T01_P    = 83,
        IxN170_T01      = 84,
        IxN170_T01_P    = 85,
        IxN180_T01      = 86,
        IxN180_T01_P    = 87,
        IxN190_T01      = 88,
        IxN190_T01_P    = 89,
        IxN200_T01      = 90,
        IxN200_T01_P    = 91,
        IxN210_T01      = 92,
        IxN210_T01_P    = 93,
        IxN220_T01      = 94,
        IxN220_T01_P    = 95,
        IxN230_T01      = 96,
        IxN230_T01_P    = 97,
        IxN240_T01      = 98,
        IxN240_T01_P    = 99,
        IxN250_T01      = 100,
        IxN250_T01_P    = 101,
        IxN260_T01      = 102,
        IxN260_T01_P    = 103,
        IxN270_T01      = 104,
        IxN270_T01_P    = 105,
        IxN280_T01      = 106,
        IxN280_T01_P    = 107,
        IxN290_T01      = 108,
        IxN290_T01_P    = 109,
        IxN300_T01      = 110,
        IxN300_T01_P    = 111,
        IxIPW_YMD       = 112,
        IxREMARKS       = 113,
        IxSTATUS        = 114,
        IxUPD_USER      = 115,
        IxUPD_YMD       = 116,
                
    }

    public enum TBSXC_SCH_MANAGEMENT_DETAIL: int
    {
        IxMAX_CNT       = 42,

        IxDIV           = 0,
        IxFACTORY       = 1,
        IxMODEL_ID      = 2,
        IxSRF_NO        = 3,
        IxBOM_ID        = 4,
        IxNF_CD         = 5,
        IxITEM_SEQ      = 6,
        IxREP_YN        = 7,
        IxFACTORY_V     = 8,
        IxSEASON        = 9,
        IxCATEGORY      = 10,
        IxMODEL         = 11,
        IxMO_ID         = 12,
        IxROUND         = 13,
        IxBOM_ID_V      = 14,
        IxSTYLE_CD      = 15,
        IxCOLOR_VER     = 16,
        IxTD_CODE       = 17,
        IxSHOE_VER      = 18,
        IxTASK_BOM_YN   = 19,
        IxTASK_BOM      = 20,
        IxTASK_BOM_P    = 21,        
        IxTASK_YIELD_YN = 22,
        IxTASK_YIELD    = 23,
        IxTASK_YIELD_P  = 24,        
        IxTASK_PFC_YN   = 25,
        IxTASK_PFC      = 26,
        IxTASK_PFC_P    = 27,        
        IxTASK_SBOOK_YN = 28,
        IxTASK_SBOOK    = 29,
        IxTASK_SBOOK_P  = 30,        
        IxTASK_CFM_YN   = 31,
        IxTASK_CFM      = 32,
        IxTASK_CFM_P    = 33,
        IxTASK_TP_YN    = 34,
        IxTASK_TP       = 35,
        IxTASK_TP_P     = 36,
        IxIPW_YMD       = 37,
        IxPPW_YMD       = 38,
        IxSTATUS        = 39,
        IxUPD_USER      = 40,
        IxUPD_YMD       = 41,         
    }

    public enum TBSXC_SCH_MANAGEMENT_FILE: int
    {
        IxMAX_CNT       = 29,

        IxDIV         = 0,
        IxFACTORY     = 1,
        IxMODEL_ID    = 2,
        IxSRF_NO      = 3,
        IxBOM_ID      = 4,
        IxNF_CD       = 5,
        IxNF_SEQ      = 6,
        IxTK_CD       = 7,
        IxFILE_SEQ    = 8,
        IxFILE_CD     = 9,
        IxFILE_NAME   = 10,
        IxREP_YN      = 11,
        IxFACTORY_V   = 12,
        IxSEASON      = 13,
        IxCATEGORY    = 14,
        IxMODEL       = 15,
        IxMO_ID       = 16,
        IxROUND       = 17,
        IxBOM_ID_V    = 18,
        IxSTYLE_CD    = 19,
        IxCOLOR_VER   = 20,
        IxTD_CODE     = 21,
        IxSHOE_VER    = 22,
        IxTASK_V      = 23,
        IxCHK         = 24,
        IxFILE_SEQ_V  = 25,
        IxFILE_NAME_V = 26,
        IxUPD_USER    = 27,
        IxUPD_YMD     = 28,          
    }   

    public enum TBSXC_SCH_MANAGEMENT_POP: int
    {
        IxMAX_CNT       = 14,

        IxDIV           = 0,
        IxFACTORY       = 1,
        IxMODEL_ID      = 2,
        IxSRF_NO        = 3,
        IxBOM_ID        = 4,
        IxROUND         = 5,
        IxSEQ           = 6,
        IxTASK          = 7,
        IxCHK           = 8,
        IxFILE_SEQ      = 9,
        IxFILE_CD       = 10,
        IxFILE_NAME     = 11,
        IxUPD_USER      = 12,
        IxUPD_YMD       = 13,            
    }
    #endregion

    #region Dev. Check
    public enum TBSXC_SCH_DEVCHECK : int 
	{
        IxMAX_CNT     = 46,

        IxDIV            = 0,
        IxFACTORY        = 1,
        IxMODEL_ID       = 2,
        IxSRF_NO         = 3,
        IxP_FACTORY      = 4,
        IxREP_YN         = 5,
        IxPRINT_YN       = 6,
        IxFILE_YN        = 7,
        IxIMG_YN         = 8, 
        IxFACTORY_V      = 9, 
        IxSEASON_V       = 10,
        IxCATEGORY_V     = 11,      
        IxMODEL          = 12,
        IxGENDER         = 13,
        IxT_D            = 14,
        IxDEV_USER       = 15,
        IxSRF_NO_DESC    = 16,
        IxP_FACTORY_DESC = 17,
        IxCATEGORY       = 18,
        IxSEASON_CD      = 19,        
        IxGEN_CD         = 20,
        IxLAST_CD        = 21,
        IxTARGET_FOB     = 22,
        IxCURRENT_FOB    = 23,
        IxRETAIL_PRICE   = 24,
        IxFORECAST       = 25,
        IxMIDSOLE        = 26,
        IxAIRBAG         = 27,
        IxOUTSOLE        = 28,
        IxIPW_YMD        = 29,
        IxWHQ_DEV        = 30,
        IxNLO_DEV        = 31,
        IxNLO_PE         = 32,
        IxNLO_TE         = 33,
        IxCDC_DEV        = 34,
        IxCDC_PE         = 35,
        IxCDC_TE         = 36,
        IxREMARK         = 37,
        IxSTATUS         = 38,
        IxUPD_USER       = 39,
        IxUPD_YMD        = 40,
        IxNF_CD_01       = 41,
        IxNF_CD_02       = 42,
        IxNF_CD_03       = 43,
        IxNF_CD_04       = 44,
        IxNF_CD_05       = 45,
    }

    public enum TBSXC_SCH_DEVCHECK_TASK : int
    {
        IxMAX_CNT       = 37,

        IxDIV         = 0,
        IxFACTORY     = 1,
        IxMODEL_ID    = 2,
        IxSRF_NO      = 3,
        IxNF_SEQ      = 4,
        IxDATE_COL    = 5,
        IxN010_T01    = 6,
        IxN010_T02    = 7,
        IxN010_T03    = 8,
        IxN010_T04    = 9,
        IxN020_T01    = 10,
        IxN020_T02    = 11,
        IxN020_T03    = 12,
        IxN020_T04    = 13,
        IxN040_T01    = 14,
        IxN040_T02    = 15,
        IxN040_T03    = 16,
        IxN040_T04    = 17,
        IxN050_T01    = 18,
        IxN050_T02    = 19,
        IxN050_T03    = 20,
        IxN050_T04    = 21,
        IxN070_T01    = 22,
        IxN070_T02    = 23,
        IxN070_T03    = 24,
        IxN070_T04    = 25,
        IxN110_T01    = 26,
        IxN130_T01    = 27,
        IxN150_T01    = 28,
        IxN140_T01    = 29,
        IxN170_T01    = 30,
        IxN180_T01    = 31,
        IxN200_T01    = 32,
        IxN210_T01    = 33,
        IxN220_T01    = 34,
        IxN270_T01    = 35,
        IxN280_T01    = 36,         
    }

    public enum TBSXC_SCH_DEVCHECK_POP : int
    {
        IxMAX_CNT       = 14,

        IxDIV           = 0,
        IxFACTORY       = 1,
        IxMODEL_ID      = 2,
        IxSRF_NO        = 3,
        IxFILE_CD       = 4,
        IxFACTORY_V     = 5,
        IxSEASON_V      = 6,
        IxCATEGORY_V    = 7,
        IxMODEL         = 8,
        IxFILE_SEQ      = 9,        
        IxCHK           = 10,        
        IxFILE_NAME     = 11,
        IxUPD_USER      = 12,
        IxUPD_YMD       = 13,       
    }
    #endregion

    #region CFM Schedule
    public enum TBSXC_SCH_CFM_SCHEDULE : int
    {
        IxMAX_CNT       = 35,

        IxDIV             = 0,
        IxFACTORY         = 1,
        IxP_FACTORY       = 2,
        IxSTYLE_CD        = 3,
        IxSHIP_YMD        = 4,
        IxDPO             = 5,
        IxSTYLE_NAME      = 6,
        IxGEN_CD          = 7,
        IxCATEGORY        = 8,
        IxDPO_QTY         = 9,
        IxCDC_DEV         = 10,
        IxG_SPEC_YMD_TA   = 11,
        IxG_SPEC_YMD_AC   = 12,
        IxG_YIELD_YMD_TA  = 13,
        IxG_YIELD_YMD_AC  = 14,
        IxG_PFC_YMD_TA    = 15,
        IxG_PFC_YMD_AC    = 16,
        IxG_S_BOOK_YMD_TA = 17,
        IxG_S_BOOK_YMD_AC = 18,
        IxG_CFM_YMD_TA    = 19,
        IxG_CFM_YMD_AC    = 20,
        IxC_SPEC_YMD_TA   = 21,
        IxC_SPEC_YMD_AC   = 22,
        IxC_YIELD_YMD_TA  = 23,
        IxC_YIELD_YMD_AC  = 24,
        IxC_PFC_YMD_TA    = 25,
        IxC_PFC_YMD_AC    = 26,
        IxC_S_BOOK_YMD_TA = 27,
        IxC_S_BOOK_YMD_AC = 28,
        IxC_CFM_YMD_TA    = 29,
        IxC_CFM_YMD_AC    = 30,
        IxFGA_YMD         = 31,
        IxREMARKS         = 32,
        IxUPD_USER        = 33,
        IxUPD_YMD         = 34,
    }
    #endregion

    #region Sample Schedule
    public enum TBSXC_SCH_SMP_SCHEDULE : int
    {
        IxMAX_CNT       = 21,

        IxDIV        = 0,
        IxFACTORY    = 1,
        IxP_FACTORY  = 2,
        IxSEASON_CD  = 3,
        IxCATEGORY   = 4,
        IxSTYLE_NAME = 5,
        IxSRF_NO     = 6,
        IxBOM_ID     = 7,
        IxSTYLE_CD   = 8,
        IxNF_CD      = 9,
        IxT_D        = 10,
        IxISSUE_YMD  = 11,
        IxMAT_ETS    = 12,
        IxSAMPLE_WS  = 13,
        IxSAMPLE_DDD = 14,
        IxIDS_ETS    = 15,
        IxNEED_BY    = 16,
        IxIPW_YMD    = 17,
        IxREMARK     = 18,
        IxUPD_USER   = 19,
        IxUPD_YMD    = 20,
    }
    #endregion

    #region New Model Tracking
    public enum TBSXC_SCH_NEW_MODEL : int
    {
        IxMAX_CNT       = 19,

        IxDIV        = 0,
        IxFACTORY    = 1,
        IxMODEL_ID   = 2,
        IxSRF_NO     = 3,
        IxFTY        = 4,
        IxSEASON     = 5,
        IxCATEGORY   = 6,
        IxMODEL      = 7,
        IxIMAGE      = 8,        
        IxGENDER     = 9,
        IxTD_CODE    = 10,
        IxMS         = 11,
        IxFORECAST   = 12,
        IxTARGET_FOB = 13,
        IxUPPER      = 14,
        IxTOOLING    = 15,
        IxREMARKS    = 16,
        IxUPD_USER   = 17,
        IxUPD_YMD    = 18,
    }
    #endregion

    #region Model Schedule
    public enum TBSXC_SCH_MODEL_SCHEDULE : int
    {
        IxMAX_CNT       = 15,

        IxDIV           = 0,
        IxFACTORY       = 1,
        IxMODEL_ID      = 2,
        IxSRF_NO        = 3,
        IxSEASON_CD     = 4,
        IxCATEGORY_CD   = 5,
        IxFACTORY_V     = 6,
        IxSEASON_V      = 7,
        IxCATEGORY_V    = 8, 
        IxMODEL_V       = 9, 
        IxIMAGE         = 10,
        IxGENDER_V      = 11,       
        IxMO_ID_V       = 12,       
        IxTD_V          = 13,
        IxSTATUS        = 14,     
    }
    #endregion

    #endregion

    #region 기타
    public enum LINK_DEF : int
    {

        IxARROW_DST = 3,			// 링크 끝 스타일	:VARCHAR2(60) 
        IxARROW_MID = 4,			// 링크 꺾인점 스타일	:VARCHAR2(60) 
        IxARROW_ORG = 5,			// 링크 첫 스타일	:VARCHAR2(60) 
        IxDASHSTYLE = 6,			// 링크 선 스타일	:VARCHAR2(10) 
        IxDRAWCOLOR = 7,			// 링크 선 색깔	:VARCHAR2(10) 
        IxDRAWWIDTH = 8,			// 링크 선 두께	:VARCHAR2(10) 
        IxFONT = 9,			// 링크 위 텍스트 폰트 속성	:VARCHAR2(60) 
        IxJUMP = 10,			// JUMP 속성	:VARCHAR2(10) 
        IxLINE_STYLE = 11,			// 라인 스타일 (예 : 곡선, 직선 등)	:VARCHAR2(10) 
        IxLINE_ROUND = 12,			// 라인 라운드 속성 : 링크 꺾인점 부분 라운드 처리 여부	:VARCHAR2(10) 
        IxTAG = 13,			// 태그 속성	:VARCHAR2(60) 
        IxTEXT = 14,			// 텍스트	:VARCHAR2(60) 
        IxTEXTCOLOR = 15,			// 텍스트 색깔	:VARCHAR2(10) 
        IxTOOLTIP = 16,			// 툴팁	:VARCHAR2(60) 

    }

    public enum TBEBM_FOB_5523_HEAD : int
    {
        IxMaxCt                 = 21,	// 인덱스 Count
        IxCHK                   = 1, 	//   : ()
        IxFACTORY               = 2, 	// Factory : ()
        IxSTYLE_CD              = 3, 	// Style : ()
        IxREGION                = 4, 	// Region : ()
        IxBOM_ID                = 5, 	// BOM ID : ()
        IxPROD_CODE             = 6, 	// Product Code : ()
        IxDEV_CODE              = 7, 	// Dev Code : ()
        IxPROD_NAME             = 8, 	// Product Name : ()
        IxPROD_TYPE             = 9, 	// Product type : ()
        IxSEASON_CD             = 10, 	// Season : ()
        IxAPP_YMD               = 11, 	// Applied Date : ()
        IxLEATHER_PCT           = 12, 	// Leather : ()
        IxSYNTHETIC_PCT         = 13, 	// synthetic : ()
        IxTEXTILE_PCT           = 14, 	// Textile : ()
        IxOTHER_PCT             = 15, 	// Other : ()
        IxREMARKS               = 16, 	// Remarks : ()
        IxSTATUS                = 17, 	// Status : ()
        IxUPD_USER              = 18, 	// User : ()
        IxUPD_YMD               = 19, 	// Date : ()
        IxUPDATE_FACTORY        = 20, 	// Upload factory : ()
        IxDETAIL_YN             = 21, 	// Detail : ()
        IxFOB_TYPE              = 22 	// Fob Type : ()
    }

    public enum TBEBM_FOB_5523_TAIL : int
    {
        IxMaxCt                 = 13,	// 인덱스 Count
        IxFACTORY               = 1, 	// Factory : ()
        IxSTYLE_CD              = 2, 	// Style : ()
        IxREGION                = 3, 	// Region : ()
        IxSEQ                   = 4, 	// Seq : ()
        IxCOMP_DIV              = 5, 	// Component division : ()
        IxCOMP_NAME             = 6, 	// Component name : ()
        IxMEASUAL_DATA          = 7, 	// Measurement data : ()
        IxBOM_COMP_READ         = 8, 	// BOM Component reading : ()
        IxREMARKS               = 9, 	// Remarks : ()
        IxSTATUS                = 10, 	// Status : ()
        IxUPD_USER              = 11, 	// User : ()
        IxUPD_YMD               = 12, 	// Date : ()
        IxUPDATE_FACTORY        = 13, 	// Upload factory : ()
        IxDEV_CODE              = 14, 	// Dev Code : ()
        IxFOB_TYPE              = 15, 	// Fob Type : ()
        IxBOM_ID                = 16 	// BOM ID : ()
    }

    public enum TBEBM_FOB_5523_TAIL_2 : int
    {
        IxMaxCt                 = 5,	// 인덱스 Count
        IxSEQ                   = 1, 	// Seq : ()
        IxREGION                = 2, 	// Region : ()
        IxCOMP_DIV              = 3, 	//   : ()
        IxCOMP_NAME             = 4, 	// Component : ()
        IxMEASUAL_DATA          = 5 	// Measurement data : ()
    }

    public enum TBEBM_FOB_MEOF_HEAD_1 : int
    {
        IxMaxCt                 = 11,	// 인덱스 Count
        IxROW_NAME              = 1, 	//   : ()
        IxSUBJECT               = 2, 	//   : ()
        IxCELL_ROW              = 3, 	//   : ()
        IxCELL_COL              = 4, 	//   : ()
        IxMOLD_1                = 5, 	//   : ()
        IxMOLD_2                = 6, 	//   : ()
        IxMOLD_3                = 7, 	//   : ()
        IxMOLD_4                = 8, 	//   : ()
        IxMOLD_5                = 9, 	//   : ()
        IxMOLD_6                = 10, 	//   : ()
        IxMOLD_7                = 11 	//   : ()
    }

    public enum TBEBM_FOB_MEOF_HEAD_2 : int
    {
        IxMaxCt                 = 35,	// 인덱스 Count
        IxFACTORY               = 1, 	// Factory : ()
        IxMOID                  = 2, 	// MOID : ()
        IxPIM_SEQ               = 3, 	// Seq : ()
        IxSEASON_CD             = 4, 	// Season Code : ()
        IxPART_TYPE             = 5, 	// Type of Part : ()
        IxMOLD_CD               = 6, 	// Mold Code : ()
        IxLAST_CD               = 7, 	// Last Code : ()
        IxDEV_MOLD_SHOP         = 8, 	// Dev. Mold Shop : ()
        IxPROD_MOLD_SHOP        = 9, 	// Prod. Mold Shop : ()
        IxMOLD_MAT              = 10, 	// Mold Material : ()
        IxMOLD_MFG_TECH         = 11, 	// Mold MFG Technology : ()
        IxMOLDED_MAT            = 12, 	// Molded Material : ()
        IxSAMP_MOLD_COST        = 13, 	// Mold Cost - Sample : ()
        IxMOLD_A_COST           = 14, 	// "A" Mold Cost : ()
        IxMOLD_B_COST           = 15, 	// "B" Mold Cost : ()
        IxMOLD_ROUND            = 16, 	// Mold Round : ()
        IxCOMP_SHARED           = 17, 	// Comp. Shared With : ()
        IxSHIFT_PER_DAY         = 18, 	// Shifts Per Day : ()
        IxHOURS_PER_SHIFT       = 19, 	// Hours Per Shift : ()
        IxHOURS_PER_DAY         = 20, 	// Hours Per Day : ()
        IxWORKING_DAYS          = 21, 	// Working Days : ()
        IxEFFICIENCY_RATE       = 22, 	// Efficiency % : ()
        IxPAIRS_PER_DAY         = 23, 	// Pairs Per Day : ()
        IxPEAK_PAIRAGE          = 24, 	// Peak Pairage : ()
        IxAMORT_PAIRAGE         = 25, 	// Amortization Pairage : ()
        IxMOLD_A_QTY            = 26, 	// "A" Molds Required : ()
        IxMOLD_B_QTY            = 27, 	// Est.  Extra Molds : ()
        IxMDF                   = 28, 	// MDF : ()
        IxSIZE_RUN              = 29, 	// Size Run : ()
        IxREMARKS               = 30, 	// Remarks : ()
        IxSTATUS                = 31, 	// Status : ()
        IxUPD_USER              = 32, 	// User : ()
        IxUPD_YMD               = 33, 	// Date : ()
        IxUPDATE_FACTORY        = 34, 	// Update Factory : ()
        IxPIM_COUNT             = 35 	// Count : ()
    }

    public enum TBEBM_FOB_MEOF_HEAD_4 : int
    {
        IxMaxCt                 = 31,	// 인덱스 Count
        IxPART_TYPE             = 1, 	// Type of Part : ()
        IxPIM_SEQ               = 2, 	// Seq : ()
        IxPIM                   = 3, 	// PIM : ()
        IxMOLD_CD               = 4, 	// Mold Code : ()
        IxLAST_CD               = 5, 	// Last Code : ()
        IxDEV_MOLD_SHOP         = 6, 	// Dev. Mold Shop : ()
        IxPROD_MOLD_SHOP        = 7, 	// Prod. Mold Shop : ()
        IxMOLD_MAT              = 8, 	// Mold Material : ()
        IxMOLD_MFG_TECH         = 9, 	// Mold MFG Technology : ()
        IxMOLDED_MAT            = 10, 	// Molded Material : ()
        IxSAMP_MOLD_COST        = 11, 	// Mold Cost - Sample : ()
        IxMOLD_A_COST           = 12, 	// "A" Mold Cost : ()
        IxMOLD_B_COST           = 13, 	// "B" Mold Cost : ()
        IxMOLD_ROUND            = 14, 	// Mold Round : ()
        IxCOMP_SHARED           = 15, 	// Comp. Shared With : ()
        IxSHIFT_PER_DAY         = 16, 	// Shifts Per Day : ()
        IxHOURS_PER_SHIFT       = 17, 	// Hours Per Shift : ()
        IxHOURS_PER_DAY         = 18, 	// Hours Per Day : ()
        IxWORKING_DAYS          = 19, 	// Working Days : ()
        IxEFFICIENCY_RATE       = 20, 	// Efficiency % : ()
        IxPAIRS_PER_DAY         = 21, 	// Pairs Per Day : ()
        IxPEAK_PAIRAGE          = 22, 	// Peak Pairage : ()
        IxAMORT_PAIRAGE         = 23, 	// Amortization Pairage : ()
        IxMOLD_A_QTY            = 24, 	// "A" Molds Required : ()
        IxMOLD_B_QTY            = 25, 	// Est.  Extra Molds : ()
        IxMDF                   = 26, 	// MDF : ()
        IxSIZE_RUN              = 27, 	// Size Run : ()
        IxREMARKS               = 28, 	// Remarks : ()
        IxUPD_USER              = 29, 	// User : ()
        IxUPD_YMD               = 30, 	// Date : ()
        IxUPDATE_FACTORY        = 31 	// Update Factory : ()
    }

    public enum TBEBM_FOB_MEOF_TAIL : int
    {
        IxMaxCt                 = 98,	// 인덱스 Count
        Ix1_MOLD_CD             = 1, 	//   : ()
        Ix1_PIM_SEQ             = 2, 	//   : ()
        Ix1_SEQ                 = 3, 	//   : ()
        Ix1_CS_SIZE             = 4, 	//   : ()
        Ix1_SIZE_PCT            = 5, 	//   : ()
        Ix1_SIZE_PAIRS          = 6, 	//   : ()
        Ix1_MOLD_REQ            = 7, 	//   : ()
        Ix1_PIM                 = 8, 	//   : ()
        Ix1_MD                  = 9, 	//   : ()
        Ix1_REMARKS             = 10, 	//   : ()
        Ix1_STATUS              = 11, 	//   : ()
        Ix1_UPD_USER            = 12, 	//   : ()
        Ix1_UPD_YMD             = 13, 	//   : ()
        Ix1_UPDATE_FACTORY      = 14 	//   : ()
    }    
    #endregion 
    

    #region Production for VJ

    #region Worksheet for Developer
    public enum TBSXG_WS_DEV_VJ : int
    {
        IxDIVISION       = 0,
        IxFACTORY        = 1,
        IxSTATUS         = 2,
        IxREQ_YN         = 3,
        IxBOM_CHK        = 4,
        IxWH_COVER       = 5,
        IxIMAGE_CHK      = 6,
        IxCATEGORY       = 7,
        IxSEASON_CD      = 8,
        IxSTYLE_NAME     = 9,
        IxCOLOR_VER      = 10,
        IxBOM_STYLE      = 11,
        IxGEN_SIZE       = 12,
        IxROUND          = 13,
        IxORD_YMD        = 14,
        IxNEED_BY        = 15,
        IxETS            = 16,
        IxMAT_LEADTIME   = 17,
        IxLOT_QTY        = 18,
        IxBOM_INFO       = 19,
        IxLOAD_UPD_USER  = 20,
        IxLOAD_UPD_DATE  = 21,
        IxREMARKS        = 22,
        IxLOT_NO         = 23,
        IxLOT_SEQ        = 24,
        IxT_LEVEL        = 25,
        IxSR_NO          = 26,
        IxBOM_CD         = 27,
        IxSRF_NO         = 28,
        IxCATEGORY_S     = 29,
        IxMTO_ACC        = 30,
        IxSEASON         = 31,
        IxGENDER         = 32,
        IxWHQ_DEV        = 33,
        IxDEV_PROD       = 34,
        IxBOM_ID         = 35,
        IxLASTING_ME     = 36,
        IxMS_ME          = 37,
        IxSOLELAYING     = 38,
        IxCOLOR          = 39,
        IxLAST_CD        = 40,
        IxPATTERN        = 41,
        IxSTL_FILE       = 42,
        IxRETAIL_PRICE   = 43,
        IxCURRENT_FOB    = 44,
        IxSAMPLE_WEI     = 45,
        IxREQ_YMD        = 46,
        IxCOLLAR_HEI     = 47,
        IxDISPATCH_YMD   = 48,
        IxHEEL_HEI       = 49,
        IxCDC_DEV        = 50,
        IxMEDIAL_HEI     = 51,
        IxNLO_DEV        = 52,
        IxLATERAL_HEI    = 53,
        IxFGA_QTY        = 54,
        IxLACE_LENGTH    = 55,
        IxDISPATCH_QTY   = 56,
        IxMS_HARDNESS    = 57,
        IxIDS_LENGTH     = 58,
        IxBARCODE_DATE   = 59,
        IxWIDTH          = 60,
        IxFIT            = 61,
        IxUPPER_MAT      = 62,
        IxBARCODE        = 63,
        IxLACE_DESC      = 64,
        IxINSOLE_DESC    = 65,
        IxT_D            = 66,
        IxIPW_YMD        = 67,
        IxSTYLE_CD       = 68,
        IxSIZE_CD        = 69,
        IxGEN_NAME       = 70,
        IxSAMPLE_TPYES   = 71,
        IxFILE_PATH      = 72,
        IxTAG_COMMENT    = 73,
        IxCOPY_USER      = 74,

        IxNIKE_DEV_SEQ        = 75,
        IxNIKE_PE_SEQ         = 76, 
        IxNIKE_TE_SEQ         = 77, 
        IxNIKE_CE_SEQ         = 78, 
        IxCDC_PE_SABUN        = 79,  
        IxCDC_TE_SABUN        = 80,  
        IxPCC_DD              = 81,     
        IxCUTTING             = 82,  
        IxCUTTING_QTY         = 83,  
        IxCMP_PRESS           = 84,  
        IxCMP_PRESS_QTY       = 85,  
        IxPU_SPRAY            = 86,  
        IxPU_SPRAY_QTY        = 87,  
        IxIP_SPRAY            = 88,  
        IxIP_SPRAY_QTY        = 89,  
        IxOS_PRESS            = 90,  
        IxOS_PRESS_QTY        = 91,  
        IxEMBROIDERY          = 92,  
        IxEMBROIDERY_QTY      = 93,  
        IxHF                  = 94,  
        IxHF_QTY              = 95,  
        IxHP                  = 96,  
        IxHP_QTY              = 97,  
        IxSTITCHING           = 98,  
        IxSTITCHING_QTY       = 99,  
        IxSTOCKFIT            = 100, 
        IxSTOCKFIT_QTY        = 101, 
        IxASSEMBLY            = 102,
        IxASSEMBLY_QTY        = 103,

    }
    /// <summary> 
    /// TBEIS_MATPRICE_FOB_INSPECTION  테이블 인덱스 Class 
    /// </summary> 
    public enum TBEIS_MATPRICE_FOB_INSPECTION : int
    {

        IxFACTORY = 1,
        IxPLAN_YMD = 2,
        IxCATEGORY = 3,
        IxCATEGORY_NAME = 4,
        IxMODEL_CD = 5,
        IxMODEL_NAME = 6,
        IxSTYLE_CD = 7,
        IxSTYLE_NAME = 8,
        IxOBS_ID = 9,
        IxOBS_TYPE = 10,
        IxPRS_QTY = 11,
        IxCOST_FOB = 12,
        IxTRADE_FOB = 13,
        IxBALANCE = 14,


    }
    #endregion

    #region MPS
    public enum TBSXG_MPS_VJ : int
    {
        IxMaxCt = 39,		

        IxDIVISION         = 0,
        IxFACTORY          = 1,
        IxLOT_NO           = 2,
        IxLOT_SEQ          = 3,
        IxDAY_SEQ          = 4,
        IxLINE_CD          = 5,
        IxCMP_CD           = 6,
        IxOP_CD            = 7,
        IxSR_NO            = 8,
        IxSRF_NO           = 9,
        IxBOM_ID           = 10,
        IxBOM_REV          = 11,
        IxCATEGORY         = 12,
        IxSEASON_CD        = 13,
        IxSTYLE_NAME       = 14,
        IxPLAN_YMD         = 15,
        IxSTATUS           = 16,        
        IxPRINT_CHK        = 17,
        IxTAG_CHK          = 18,
        IxFORMULA_CHK      = 19,
        IxCAT              = 20,
        IxSEASON           = 21,
        IxMODEL_NAME       = 22,
        IxCOLOR_VER        = 23,
        IxBOM_STYLECD      = 24,
        IxGEN_SIZE         = 25,
        IxSAMPLE_TYPE      = 26,
        IxREQ_YMD          = 27,
        IxWORK_QTY         = 28,
        IxWORK_DATE        = 29,
        IxMAT_YMD          = 30,
        IxIPW_YMD          = 31,
        IxCDC_DEV_NAME     = 32,
        IxOP_NAME          = 33,
        IxREMARKS          = 34,        
        IxTAG_COMMENT      = 35,
        IxSORT_NO          = 36,
        IxPCARD_YN         = 37,
        IxPCARD_STATUS     = 38,
    }

    public enum TBSXG_MPS_POP_VJ : int
    {
        IxMaxCt = 18,		// ÀÎµ¦½º Count 

        IxDIVISION    = 0,
        IxPRINT_CHK   = 1,
        IxFACTORY     = 2,
        IxMODEL       = 3,
        IxCOLOR_VER   = 4,
        IxBOM_STYLE   = 5,
        IxSAMPLE_TYPE = 6,
        IxUSER        = 7,
        IxOP_NAME     = 8,
        IxQTY         = 9,
        IxLOT_NO      = 10,
        IxLOT_SEQ     = 11,
        IxDAY_SEQ     = 12,
        IxLINE_CD     = 13,
        IxCMP_CD      = 14,
        IxOP_CD       = 15,
        IxUPS_USER    = 16,
        IxREMARKS     = 17,

    }
    #endregion

    public enum TBSXG_PROD_RESULT_OP_VJ : int
    {
        IxDIVISION       = 0,
        IxFACTORY        = 1,
        IxLOT_NO         = 2,
        IxLOT_SEQ        = 3,
        IxLINE_CD        = 4,
        IxDAY_SEQ        = 5,
        IxPCARD_ID       = 6,
        IxSTATUS         = 7,
        IxCATEGORY       = 8,
        IxSEASON_CD      = 9,
        IxSTYLE_NAME     = 10,
        IxCOLOR_VER      = 11,
        IxBOM_STYLE      = 12,
        IxGEN_SIZE       = 13,
        IxSAMPLE_TYPE    = 14,
        IxREQ_YMD        = 15,
        IxFGA_QTY        = 16,
        IxETS            = 17,
        IxMAT_YMD        = 18,
        IxIN_YMD         = 19,
        IxIN_REMARK      = 20,
        IxIPW_YMD        = 21,
        IxSBOOK_YMD      = 22,
        IxYIELD_YMD      = 23,
        IxCDC_DEV_NAME   = 24,
        IxUPC_DIR        = 25,
        IxUPC_RST        = 26,
        IxI_UPC_RST      = 27,
        IxT_UPC_RST      = 28,
        IxP_UPC_RST      = 29,
        IxO_UPC_RST      = 30,
        IxPHC_DIR        = 31,
        IxPHC_RST        = 32,
        IxI_PHC_RST      = 33,
        IxT_PHC_RST      = 34,
        IxP_PHC_RST      = 35,
        IxO_PHC_RST      = 36,
        IxPUS_DIR        = 37,
        IxPUS_RST        = 38,
        IxI_PUS_RST      = 39,
        IxT_PUS_RST      = 40,
        IxP_PUS_RST      = 41,
        IxO_PUS_RST      = 42,
        IxIPS_DIR        = 43,
        IxIPS_RST        = 44,
        IxI_IPS_RST      = 45,
        IxT_IPS_RST      = 46,
        IxP_IPS_RST      = 47,
        IxO_IPS_RST      = 48,
        IxOSP_DIR        = 49,
        IxOSP_RST        = 50,
        IxI_OSP_RST      = 51,
        IxT_OSP_RST      = 52,
        IxP_OSP_RST      = 53,
        IxO_OSP_RST      = 54,        
        IxUPE_DIR        = 55,
        IxUPE_RST        = 56,
        IxI_UPE_RST      = 57,
        IxT_UPE_RST      = 58,
        IxP_UPE_RST      = 59,
        IxO_UPE_RST      = 60,
        IxHF_DIR         = 61,
        IxHF_RST         = 62,
        IxI_HF_RST       = 63,
        IxT_HF_RST       = 64,
        IxP_HF_RST       = 65,
        IxO_HF_RST       = 66,
        IxHP_DIR         = 67,
        IxHP_RST         = 68,
        IxI_HP_RST       = 69,
        IxT_HP_RST       = 70,
        IxP_HP_RST       = 71,
        IxO_HP_RST       = 72,
        IxUPS_DIR        = 73,
        IxUPS_RST        = 74,
        IxI_UPS_RST      = 75,
        IxT_UPS_RST      = 76,
        IxP_UPS_RST      = 77,
        IxO_UPS_RST      = 78,
        IxFSS_DIR        = 79,
        IxFSS_RST        = 80,
        IxI_FSS_RST      = 81,
        IxT_FSS_RST      = 82,
        IxP_FSS_RST      = 83,
        IxO_FSS_RST      = 84,
        IxFGA_DIR        = 85,
        IxFGA_RST        = 86,
        IxI_FGA_RST      = 87,
        IxT_FGA_RST      = 88,
        IxP_FGA_RST      = 89,
        IxO_FGA_RST      = 90,
        IxUPS_REMAIN     = 91,
        IxFGA_REMAIN     = 92,
        IxUPS_USER       = 93,     
        IxFGA_REMARKS    = 94,
        IxUPE_REMARKS    = 95,
        IxUPC_REMARKS    = 96,
        IxREMARKS        = 97,
    }

    #region Analisys
    public enum TBEDM_PCC_PROD_MONTH_VJ : int
    {
        IxMAX_CNT   = 9,

        IxDIV       = 0,
        IxT_LEV     = 1,
        IxFACTORY   = 2,        
        IxOP_CD     = 3,
        IxCATEGORY  = 4,
        IxNF_CD     = 5,
        IxITEM      = 6,
        IxDATE      = 7,
        IxQTY       = 8,        
    }
    public enum TBEDM_PCC_PROD_DAY_VJ : int
    {
         
        IxDIV       = 0,
        IxT_LEV     = 1,
        IxFACTORY   = 2,
        IxCATEGORY  = 3,
        IxNF_CD     = 4,
        IxTITLE     = 5,
        IxTOTAL_SUM = 6,
        IxDAY_01    = 7,
        IxDAY_02    = 8,
        IxDAY_03    = 9,
        IxDAY_04    = 10,
        IxDAY_05    = 11,
        IxDAY_06    = 12,
        IxDAY_07    = 13,
        IxDAY_08    = 14,
        IxDAY_09    = 15,
        IxDAY_10    = 16,
        IxDAY_11    = 17,
        IxDAY_12    = 18,
        IxDAY_13    = 19,
        IxDAY_14    = 20,
        IxDAY_15    = 21,
        IxDAY_16    = 22,
        IxDAY_17    = 23,
        IxDAY_18    = 24,
        IxDAY_19    = 25,
        IxDAY_20    = 26,
        IxDAY_21    = 27,
        IxDAY_22    = 28,
        IxDAY_23    = 29,
        IxDAY_24    = 30,
        IxDAY_25    = 31,
        IxDAY_26    = 32,
        IxDAY_27    = 33,
        IxDAY_28    = 34,
        IxDAY_29    = 35,
        IxDAY_30    = 36,
        IxDAY_31    = 37,

    }
    #endregion

    #endregion

    #region Incoming for VJ
    public enum TBSXI_IN_LIST_VJ : int
    {
        IxMaxCt = 33,

        IxDIVISION       = 0,
        IxSTATUS         = 1,
        IxY_FLG          = 2,
        IxLEVEL          = 3,
        IxIN_NO          = 4,
        IxIN_SEQ         = 5,
        IxIN_DIV         = 6,
        IxIN_YMD         = 7,
        IxITEM01         = 8,
        IxITEM02         = 9,
        IxITEM03         = 10,
        IxITEM04         = 11,
        IxVALUE_PUR      = 12,
        IxVALUE_PREV_IN  = 13,
        IxVALUE_IN       = 14,
        IxBL_NO          = 15,
        IxINV_NO         = 16,
        IxDEC_NO         = 17,
        IxDEC_YMD        = 18,
        IxPUR_CURRENCY   = 19,
        IxPUR_PRICE      = 20,
        IxCBD_CURRENCY   = 21,
        IxCBD_PRICE      = 22,
        IxBAR_CODE       = 23,
        IxPUR_DIV        = 24,
        IxMRP_REQ_FLG    = 25,
        IxTRANSPORT_TYPE = 26,
        IxVENDOR         = 27,
        IxREMARKS        = 28,
        IxUPD_USER       = 29,
        IxUPD_YMD        = 30,
        IxPUR_NO         = 31,
        IxPUR_SEQ        = 32,

    }
    public enum TBSXI_IN_LIST_BAR_VJ : int
    {
        IxMaxCt          = 27,		// ÀÎµ¦½º Count

        IxDIVISION       = 0,
        IxSTATUS         = 1,
        IxY_FLG          = 2,
        IxLEVEL          = 3,
        IxPUR_NO         = 4,
        IxPUR_SEQ        = 5,
        IxPUR_DIV        = 6,
        IxPUR_YMD        = 7,
        IxITEM01         = 8,
        IxITEM02         = 9,
        IxITEM03         = 10,
        IxITEM04         = 11,
        IxVALUE_PUR      = 12,
        IxVALUE_IN       = 13,
        IxVALUE_ADV_IN   = 14,
        IxPUR_CURRENCY   = 15,
        IxPUR_PRICE      = 16,
        IxCBD_CURRENCY   = 17,
        IxCBD_PRICE      = 18,
        IxBAR_CODE       = 19,
        IxMRP_REQ_FLG    = 20,
        IxPRICE_YN       = 21,
        IxTRANSPORT_TYPE = 22,
        IxVENDOR_DESC    = 23,
        IxREMARKS        = 24,
        IxUPD_USER       = 25,
        IxUPD_YMD        = 26,
    }
    #endregion

    #region CFM Schedule 

    public enum TBSXC_SCH_CFM_SHOE : int
    {
        IxMAX_CNT = 32,

        IxDIV = 0,
        IxFACTORY = 1,
        IxOBS_ID = 2,
        IxOBS_TYPE = 3,
        IxSTYLE_CD = 4,
        IxFACTORY_V = 5,
        IxSHIP_YMD = 6,
        IxARRIVAL_YMD = 7,
        IxDPO = 8,
        IxDPO_TYPE = 9,
        IxSTYLE_V = 10,
        IxCFM_DIV = 11,
        IxPK_NO = 12,
        IxMODEL = 13,
        IxGEN = 14,
        IxCAT = 15,
        IxQTY = 16,
        IxLOSS = 17,
        IxDD_YN = 18,
        IxDEVELOPER = 19,
        IxYIELD = 20,
        IxS_TGT_YMD = 21,
        IxS_PLAN_YMD = 22,
        IxS_STATUS = 23,
        IxC_TGT_YMD = 24,
        IxC_PLAN_YMD = 25,
        IxC_STATUS = 26,
        IxASSEMBLY = 27,
        IxMRP_YMD = 28,
        IxREMARKS = 29,
        IxSTATUS = 30,
        IxUPD_USER = 31,
        IxUPD_YMD = 32,
    }

    #endregion
}

