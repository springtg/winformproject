using System;

namespace FlexPurchase.ClassLib
{


    #region 입고



	/// <summary> 
	/// SBI_IN_TAIL 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBI_IN_TAIL : int
	{
		IxMaxCt            = 50,	// 인덱스 Count
		IxDIVISION         = 0,
		IxSEQ              = 1, 	// Seq : ()
		IxFACTORY          = 2, 	// Factory : VARCHAR2(5)
		IxIN_NO            = 3, 	// In No : VARCHAR2(20)
		IxIN_SEQ           = 4, 	// Seq : NUMBER(22)
		IxITEM             = 5, 	// Material : ()
		IxITEM_CD          = 6, 	// Item : VARCHAR2(10)
		IxITEM_NAME        = 7, 	// Item : ()
		IxSPEC_CD          = 8, 	// Specification : VARCHAR2(5)
		IxSPEC_NAME        = 9, 	// Specification : ()
		IxCOLOR_CD         = 10, 	// Color : VARCHAR2(5)
		IxCOLOR_NAME       = 11, 	// Color : ()
		IxIN_QTY           = 12, 	// In Qty : NUMBER(22)
		IxUNIT             = 13, 	// Unit : ()
		IxPUR_CURRENCY     = 14, 	// Currency : VARCHAR2(10)
		IxPUR_PRICE        = 15, 	// Price : NUMBER(22)
		IxCUST_CD          = 16, 	// Code : VARCHAR2(10)
		IxCUST_NAME        = 17, 	// Name : ()
		IxOUTSIDE_CURRENCY = 18, 	// Currency : VARCHAR2(10)
		IxOUTSIDE_PRICE    = 19, 	// Price : NUMBER(22)
		IxCBD_CURRENCY     = 20, 	// Currency : VARCHAR2(10)
		IxCBD_PRICE        = 21, 	// Price : NUMBER(22)
		IxSHIP_CURRENCY    = 22, 	// Currency : VARCHAR2(10)
		IxSHIP_PRICE       = 23, 	// Price : NUMBER(22)
		IxPUR_DIV          = 24, 	// Price : NUMBER(22)
		IxBUY_DIV          = 25, 	// Price : NUMBER(22)
		IxPK_UNIT_QTY      = 26, 	// P/K Qty : NUMBER(22)
		IxPRICE_YN         = 27, 	// Price Y/N : VARCHAR2(1)
		IxTAX_CD           = 28, 	// Tax : VARCHAR2(10)
		IxBAR_CODE         = 29, 	// BAR CODE : VARCHAR2(24)
		IxBAR_KIND         = 30, 	// Barcode Kind : VARCHAR2(4)
		IxCONT_NO          = 31, 	// Container No : VARCHAR2(20)
		IxSHIP_YMD         = 32, 	// Date : VARCHAR2(8)
		IxSHIP_NO          = 33, 	// No : VARCHAR2(20)
		IxSHIP_SEQ         = 34, 	// Seq : VARCHAR2(4)
		IxSHIP_QTY         = 35, 	// Qty : NUMBER(22)
		IxLOT_NO           = 36, 	// No : VARCHAR2(12)
		IxLOT_SEQ          = 37, 	// Seq : VARCHAR2(2)
		IxSTYLE_CD         = 38, 	// Code : VARCHAR2(9)
		IxSTYLE_NAME       = 39, 	// Name : ()
		IxWH_CD            = 40, 	// WareHouse : VARCHAR2(10)
		IxWH_NAME          = 41, 	// WareHouse : ()
		IxPAY_CD           = 42, 	// Pay Code : VARCHAR2(10)
		IxPUR_NO           = 43, 	// No : VARCHAR2(20)
		IxPUR_SEQ          = 44, 	// Seq : NUMBER(22)
		IxPUR_USER         = 45, 	// User : VARCHAR2(30)
		IxPUR_DEPT         = 46, 	// Dept : VARCHAR2(10)
		IxIN_STATUS        = 47, 	// In Status : VARCHAR2(10)
		IxREMARKS          = 48, 	// Remarks : VARCHAR2(500)
		IxMOD_QTY          = 49, 	//   : NUMBER(22)
		IxTRAN_DIV         = 50, 	//   : VARCHAR2(1)
		IxLEDGER_CURRENCY  = 51, 	// Currency : VARCHAR2(10)
		IxLEDGER_PRICE     = 52, 	// Price : NUMBER(22)
		IxUPD_USER         = 53, 	//   : VARCHAR2(30)
		IxUPD_YMD          = 54, 	//   : DATE(7)
		

	}




    public enum TBSBI_INCOMING_PUR : int
    {
        IxMaxCt = 49,	// 인덱스 Count
        IxCHK = 1, 	// C : ()
        IxIN_CHK = 2, 	// C : ()
        IxFACTORY = 3, 	// Factory : ()
        IxPUR_NO = 4, 	// No : ()
        IxPUR_SEQ = 5, 	// Seq : ()
        IxPUR_YMD = 6, 	// Date : ()
        IxPUR_USER = 7, 	// User : ()
        IxITEM_CD = 8, 	// Item : ()
        IxITEM_NAME = 9, 	// Item : ()
        IxSPEC_CD = 10, 	// Specification : ()
        IxSPEC_NAME = 11, 	// Specification : ()
        IxCOLOR_CD = 12, 	// Color : ()
        IxCOLOR_NAME = 13, 	// Color : ()
        IxPUR_QTY = 14, 	// Pur Qty : ()
        IxIN_QTY = 15, 	// In Qty : ()
        IxUNIT = 16, 	// Unit : ()
        IxPK_UNIT_QTY = 17, 	// P/K Qty : ()
        IxPUR_DEPT = 18, 	// Dept : ()
        IxDEPT_NAME = 19, 	// Dept : ()
        IxPUR_CURRENCY = 20, 	// Currency : ()
        IxCBD_PUR_CURRENCY = 21, 	//   : ()
        IxCHECK_PUR = 22, 	//   : ()
        IxPUR_PRICE = 23, 	// Price : ()
        IxPRICE_YN = 24, 	// Price : ()
        IxOUTSIDE_CURRENCY = 25, 	// Currency : ()
        IxCBD_OUTSIDE_CURRENCY = 26, 	//   : ()
        IxCHECK_OUTSIDE = 27, 	//   : ()
        IxOUTSIDE_PRICE = 28, 	// Price : ()
        IxCBD_CURRENCY = 29, 	// Currency : ()
        IxCBD_CBD_CURRENCY = 30, 	//   : ()
        IxCHECK_CBD = 31, 	//   : ()
        IxCBD_PRICE = 32, 	// Price : ()
        IxCUST_CD = 33, 	// Code : ()
        IxCUST_NAME = 34, 	// Name : ()
        IxTAX_CD = 35, 	// TAX : ()
        IxPAY_CD = 36, 	// Pay : ()
        IxOFFER_NO = 37, 	// Offer No : ()
        IxLC_NO = 38, 	// LC No : ()
        IxINV_NO = 39, 	// Inv No : ()
        IxLOT_NO = 40, 	// No : ()
        IxLOT_SEQ = 41, 	// Seq : ()
        IxLOT_QTY = 42, 	// Qty : ()
        IxSTYLE_CD = 43, 	// Code : ()
        IxSTYLE_NAME = 44, 	// Name : ()
        IxSHIP_QTY = 45, 	// Qty : ()
        IxSHIP_NO = 46, 	// No : ()
        IxSHIP_YMD = 47, 	// Date : ()
        IxUPD_USER = 48, 	//   : ()
        IxUPD_YMD = 49 	//   : ()
    }




    public enum TBSBI_INCOMING_INVOICE : int
    {

        IxCHK = 1,
        IxFACTORY = 2,
        IxSHIP_YMD = 3,
        IxSHIP_NO = 4,
        IxSHIP_SEQ = 5,
        IxINV_NO = 6,
        IxLC_NO = 7,
        IxPK_NO = 8,
        IxITEM_NAME = 9,
        IxSPEC_NAME = 10,
        IxCOLOR_NAME = 11,
        IxSHIP_QTY = 12,
        IxIN_QTY = 13,
        IxPK_QTY = 14,
        IxUNIT = 15,
        IxTRADE_PRICE = 16,
        IxCBD_PRICE = 17,
        IxSELL_PRICE = 18,
        IxLEDGER_PRICE = 19,
        IxLOT_NO = 20,
        IxCONT_NO = 21,
        IxCUST_CD = 22,
        IxCUST_NAME = 23,
        IxSTYLE_CD = 24,
        IxSTYLE_NAME = 25,
        IxBAR_MOVE = 26,
        IxITEM_CD = 27,
        IxSPEC_CD = 28,
        IxCOLOR_CD = 29,

    }



    public enum TBSBI_IN_SIZE : int
    {
        IxMaxCt = 7,	// 인덱스 Count
        IxKIND = 1, 	//   : ()
        IxTOTAL = 2, 	//   : ()
        IxCOL = 3, 	//   : ()
        IxFACTORY = 4, 	//   : VARCHAR2(5)
        IxIN_NO = 5, 	//   : VARCHAR2(20)
        IxUPD_USER = 6, 	//   : VARCHAR2(30)
        IxUPD_YMD = 7 	//   : DATE(7)
    }



	/// <summary> 
	/// TBSBI_IN_OVERSEAS 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBI_IN_OVERSEAS : int
	{  

		IxDIVISION					= 0,
		IxTREE_LEVEL                = 1, 	
		IxDESC1						= 2,
		IxDESC2						= 3,
		IxDESC3						= 4,
		IxFACTORY					= 5, 	
		IxIN_NO						= 6, 	
		IxIN_SEQ					= 7, 	
		IxIN_YMD					= 8,
		IxIN_TYPE					= 9,
		IxPUR_DIV					= 10,
		IxBUY_DIV					= 11,
		IxIN_SIZE					= 12,
		IxINV_NO					= 13,
		IxLC_NO						= 14,
		IxIN_STATUS					= 15,
		IxCONFIRM_YN				= 16,
		IxREMARKS				    = 17, 
		IxITEM_NAME					= 18, 	
		IxSPEC_NAME				    = 19, 	
		IxCOLOR_NAME                = 20, 	
		IxIN_QTY					= 21, 	
		IxUNIT                      = 22, 	
		IxPUR_CURRENCY              = 23, 	
		IxPUR_PRICE					= 24, 	
		IxCUST_CD					= 25,	
		IxCUST_NAME				    = 26, 	
		IxOUTSIDE_CURRENCY	        = 27, 	
		IxOUTSIDE_PRICE			    = 28,  	
		IxCBD_CURRENCY		        = 29, 	 
		IxCBD_PRICE				    = 30,	
		IxSHIP_CURRENCY			    = 31,  	
		IxSHIP_PRICE				= 32,	
		IxLEDGER_CURRENCY	        = 33,  	
		IxLEDGER_PRICE			    = 34, 	
		IxPUR_DIV_D				    = 35, 	
		IxBUY_DIV_D				    = 36,	
		IxPK_UNIT_QTY				= 37,  	
		IxPRICE_YN					= 38, 	
		IxTAX_CD					= 39,	
		IxBAR_CODE					= 40,  	
		IxBAR_KIND					= 41,	
		IxBAR_MOVE                  = 42,
		IxCONT_NO					= 43,   	
		IxSHIP_YMD					= 44, 	
		IxSHIP_NO					= 45, 	
		IxSHIP_SEQ					= 46, 	
		IxSHIP_QTY					= 47, 	
		IxLOT_NO					= 48, 	
		IxLOT_SEQ					= 49, 	
		IxSTYLE_CD					= 50, 	
		IxSTYLE_NAME				= 51, 	
		IxWH_CD						= 52, 	
		IxWH_NAME					= 53, 	
		IxPAY_CD					= 54, 	
		IxPUR_NO					= 55, 	
		IxPUR_SEQ					= 56, 	
		IxPUR_USER					= 57, 	
		IxPUR_DEPT					= 58, 	
		IxIN_STATUS_D			    = 59, 	 	
		IxREMARKS_D				    = 60, 	
		IxMOD_QTY					= 61, 	
		IxTRAN_DIV					= 62, 	
		IxITEM_CD					= 63, 	
		IxSPEC_CD					= 64, 	
		IxCOLOR_CD					= 65,
	}


    public enum TBSBI_IN_OVERSEAS_VJ : int
    {

        IxDIVISION                  = 0,
        IxTREE_LEVEL                = 1,
        IxDESC1                     = 2,
        IxDESC2                     = 3,
        IxDESC3                     = 4,
        IxFACTORY                   = 5,
        IxIN_NO                     = 6,
        IxIN_SEQ                    = 7,
        IxIN_YMD                    = 8,
        IxIN_TYPE                   = 9,
        IxPUR_DIV                   = 10,
        IxBUY_DIV                   = 11,
        IxIN_SIZE                   = 12,
        IxINV_NO                    = 13,
        IxLC_NO                     = 14,
        IxIN_STATUS                 = 15,
        IxCONFIRM_YN                = 16,
        IxREMARKS                   = 17,
        IxITEM_NAME                 = 18,
        IxSPEC_NAME                 = 19,
        IxCOLOR_NAME                = 20,
        IxIN_QTY                    = 21,
        IxUNIT                      = 22,
        IxPUR_CURRENCY              = 23,
        IxPUR_PRICE                 = 24,
        IxCUST_CD                   = 25,
        IxCUST_NAME                 = 26,
        IxOUTSIDE_CURRENCY          = 27,
        IxOUTSIDE_PRICE             = 28,
        IxCBD_CURRENCY              = 29,
        IxCBD_PRICE                 = 30,
        IxSHIP_CURRENCY             = 31,
        IxSHIP_PRICE                = 32,
        IxLEDGER_CURRENCY           = 33,
        IxLEDGER_PRICE              = 34,
        IxPUR_DIV_D                 = 35,
        IxBUY_DIV_D                 = 36,
        IxPK_UNIT_QTY               = 37,
        IxPRICE_YN                  = 38,
        IxTAX_CD                    = 39,
        IxBAR_CODE                  = 40,
        IxBAR_KIND                  = 41,
        IxBAR_MOVE                  = 42,
        IxCONT_NO                   = 43,
        IxSHIP_YMD                  = 44,
        IxSHIP_NO                   = 45,
        IxSHIP_SEQ                  = 46,
        IxSHIP_QTY                  = 47,
        IxLOT_NO                    = 48,
        IxLOT_SEQ                   = 49,
        IxSTYLE_CD                  = 50,
        IxSTYLE_NAME                = 51,
        IxWH_CD                     = 52,
        IxWH_NAME                   = 53,
        IxPAY_CD                    = 54,
        IxPUR_NO                    = 55,
        IxPUR_SEQ                   = 56,
        IxPUR_USER                  = 57,
        IxPUR_DEPT                  = 58,
        IxIN_STATUS_D               = 59,
        IxREMARKS_D                 = 60,
        IxMOD_QTY                   = 61,
        IxTRAN_DIV                  = 62,
        IxITEM_CD                   = 63,
        IxSPEC_CD                   = 64,
        IxCOLOR_CD                  = 65,
        IxPAY_DIV                   = 66,
        IxEX_RATE                   = 67,
    }

	/// <summary>
	/// TBSBI_IN_OVERSEAS_PUR  테이블 인덱스 Enum 
	/// </summary>
	public enum TBSBI_IN_OVERSEAS_PUR : int
	{  
 
		IxTREE_LEVEL					    = 1, 	
		IxDESC1								= 2,
		IxDESC2								= 3,
		IxDESC3								= 4,
		IxFACTORY							= 5, 	
		IxPUR_NO								= 6, 	
		IxPUR_SEQ							= 7, 	
		IxPUR_YMD							= 8, 	
		IxPUR_USER							= 9, 	
		IxITEM_NAME							= 10, 	
		IxSPEC_NAME						= 11,
		IxCOLOR_NAME						= 12,
		IxPUR_QTY							= 13, 
		IxIN_QTY								= 14, 
		IxNOW_QTY						    = 15, 
		IxUNIT									= 16, 
		IxPK_UNIT_QTY						= 17, 
		IxPUR_DEPT							= 18, 
		IxDEPT_NAME						= 19, 
		IxPUR_CURRENCY					= 20, 
		IxCBD_PUR_CURRENCY			= 21, 
		IxCHECK_PUR						= 22, 
		IxPUR_PRICE							= 23, 
		IxPRICE_YN							= 24, 
		IxOUTSIDE_CURRENCY			= 25, 
		IxCBD_OUTSIDE_CURRENCY	= 26, 
		IxCHECK_OUTSIDE				= 27, 
		IxOUTSIDE_PRICE					= 28, 
		IxCBD_CURRENCY					= 29, 
		IxCBD_CBD_CURRENCY			= 30, 
		IxCHECK_CBD						= 31, 
		IxCBD_PRICE						= 32, 
		IxCUST_CD							= 33, 
		IxCUST_NAME						= 34, 
		IxTAX_CD								= 35, 
		IxPAY_CD								= 36, 
		IxOFFER_NO							= 37, 
		IxLC_NO								= 38, 
		IxINV_NO								= 39, 
		IxLOT_NO								= 40, 
		IxLOT_SEQ							= 41, 
		IxLOT_QTY							= 42, 
		IxSTYLE_CD							= 43, 
		IxSTYLE_NAME						= 44, 
		IxSHIP_QTY							= 45, 
		IxSHIP_NO							= 46, 
		IxSHIP_YMD							= 47, 
		IxITEM_CD							= 48, 	
		IxSPEC_CD							= 49,
		IxCOLOR_CD							= 50,
		

	}




    public enum TBSBI_IN_MOVING_METHOD : int
    {
        IxMaxCt = 15,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : ()
        IxCUST_CD = 2, 	// Vendor : ()
        IxCUST_NAME = 3, 	// Vendor : ()
        IxGROUP_L_CD = 4, 	//   : ()
        IxFIRST_CLASS = 5, 	// First Class : ()
        IxPUR_USER = 6, 	// User : ()
        IxSHIP_QTY = 7, 	// Qty : ()
        IxSHIP_USD = 8, 	// Amt($) : ()
        IxSHIP_KRW = 9, 	// Amt(W) : ()
        IxAF_QTY = 10, 	// Qty : ()
        IxAF_USD = 11, 	// Amt($) : ()
        IxAF_KRW = 12, 	// Amt(W) : ()
        IxHC_QTY = 13, 	// Qty : ()
        IxHC_USD = 14, 	// Amt($) : ()
        IxHC_KRW = 15 	// Amt(W) : ()
    }




	public enum TBSBP_ITEM_LIST_POP : int
	{
		IxCHK = 1,
		IxITEM_NAME = 2,
		IxSPEC_NAME = 3,
		IxCOLOR_NAME = 4,
		IxITEM_DIV_VALUE = 5,
		IxCUST_CD = 6,
		IxCUST_NAME = 7,
		IxPUR_PRICE = 8,
		IxPUR_CURRENCY = 9,
		IxOUTSIDE_PRICE = 10,
		IxOUTSIDE_CURRENCY = 11,
		IxCBD_PRICE = 12,
		IxCBD_CURRENCY = 13,
		IxUNIT = 14,
		IxCBM = 15,
		IxWEIGHT = 16,
		IxREMARKS = 17,
		IxFACTORY = 18,
		IxITEM_DIV_CD = 19,
		IxITEM_CD = 20,
		IxSPEC_CD = 21,
		IxCOLOR_CD = 22,
		IxUPD_USER = 23,
		IxUPD_YMD = 24
	}



    public enum TBSBI_INCOMING_NOSHIP : int
    {
        IxMaxCt = 41,	// 인덱스 Count
        IxCHK = 1, 	// C : ()
        IxITEM_CD = 2, 	// Item : ()
        IxITEM_NAME = 3, 	// Item : ()
        IxSPEC_CD = 4, 	// Specification : ()
        IxSPEC_NAME = 5, 	// Specification : ()
        IxCOLOR_CD = 6, 	// Color : ()
        IxCOLOR_NAME = 7, 	// Color : ()
        IxPUR_QTY = 8, 	// Pur Qty : ()
        IxSHIP_QTY = 9, 	// Ship Qty : ()
        IxUSE_IN_QTY = 10, 	// In Qty : ()
        IxUNIT = 11, 	// Unit : ()
        IxPUR_CURRENCY = 12, 	// Currency : ()
        IxCBD_PUR_CURRENCY = 13, 	//   : ()
        IxCHECK_PUR = 14, 	//   : ()
        IxPUR_PRICE = 15, 	// Price : ()
        IxCBD_CURRENCY = 16, 	// Currency : ()
        IxCBD_CBD_CURRENCY = 17, 	//   : ()
        IxCHECK_CBD = 18, 	//   : ()
        IxCBD_PRICE = 19, 	// Price : ()
        IxSHIP_CURRENCY = 20, 	// Currency : ()
        IxCBD_SHIP_CURRENCY = 21, 	//   : ()
        IxCHECK_SHIP = 22, 	//   : ()
        IxSHIP_PRICE = 23, 	// Price : ()
        IxBAR_CODE_REP = 24, 	// Barcode Rep : ()
        IxFACTORY = 25, 	// Factory : ()
        IxSHIP_YMD = 26, 	// Date : ()
        IxSHIP_NO = 27, 	// No : ()
        IxSHIP_SEQ = 28, 	// Seq : ()
        IxLOT_NO = 29, 	// No : ()
        IxLOT_SEQ = 30, 	// Seq : ()
        IxSTYLE_CD = 31, 	// Code : ()
        IxSTYLE_NAME = 32, 	// Name : ()
        IxPK_NO = 33, 	// PK No : ()
        IxPK_UNIT_QTY = 34, 	// P/K Qty : ()
        IxCUST_CD = 35, 	// Code : ()
        IxCUST_NAME = 36, 	// Name : ()
        IxPUR_USER = 37, 	// Purchase User : ()
        IxPRICE_YN = 38, 	// Price Y/N : ()
        IxREMARKS = 39, 	// Remarks : ()
        IxUPD_USER = 40, 	// User : ()
        IxUPD_YMD = 41 	// Date : ()
    }



    public enum TBSBI_IN_ADJUST_VENDOR : int
    {
        IxMaxCt = 23,	// 인덱스 Count
        IxDIVISION = 0, 	// Factory : ()
        IxFACTORY = 1, 	// Factory : ()
        IxBUY_DIV = 2, 	//   : ()
        IxPUR_USER = 3, 	//   : ()
        IxCUST_CD = 4, 	// 거래처코드 : ()
        IxCUST_NAME = 5, 	//   : ()
        IxCUST_YM = 6, 	//   : ()
        IxITEM_CD = 7, 	// Item : ()
        IxITEM_NAME = 8, 	//   : ()
        IxIN_QTY = 9, 	//   : ()
        IxUSD_PRICE = 10, 	//   : ()
        IxCUR_PRICE = 11, 	//   : ()
        IxPOS = 12, 	//   : ()
        IxAMOUNT_USD = 13, 	//   : ()
        IxAMOUNT_KRW = 14, 	//   : ()
        IxADJUST_USD = 15, 	//   : ()
        IxADJUST_KRW = 16, 	//   : ()
        IxVAT_KRW = 17, 	//   : ()
        IxADJUST_DESC = 18, 	//   : ()
        IxFACT_LOC = 19, 	//   : ()
        IxACCOUNT_STATUS = 20, 	//   : ()
        IxACCOUNT_CONF = 21, 	//   : ()
        IxTREE_LEVEL = 22, 	//   : ()
        IxUPD_USER = 23, 	//   : ()
        IxUPD_YMD = 24 	//   : ()
    }



    public enum TBSBI_IN_MONTHLY_VEND : int
    {
        IxMaxCt = 12,	// 인덱스 Count
        IxFACTORY = 1, 	//   : ()
        IxCUST_CD = 2, 	// 거래처코드 : ()
        IxCUST_NAME = 3, 	//   : ()
        IxIN_YM = 4, 	//   : ()
        IxIN_QTY = 5, 	//   : ()
        IxMAT_USD = 6, 	//   : ()
        IxMAT_KRW = 7, 	//   : ()
        IxACC_USD = 8, 	//   : ()
        IxACC_KRW = 9, 	//   : ()
        IxPUR_USER = 10, 	//   : ()
        IxBUY_DIV = 11, 	//   : ()
        IxUPD_YMD = 12 	//   : ()
    }



	public enum TBSBI_INCOMING_ADJUST : int
	{
		IxMaxCt            = 35,	// 인덱스 Count
		IxITEM             = 1, 	// Material : ()
		IxITEM_CD          = 2, 	// Item : ()
		IxITEM_NAME        = 3, 	// Item : ()
		IxSPEC_CD          = 4, 	// Specification : ()
		IxSPEC_NAME        = 5, 	// Specification : ()
		IxCOLOR_CD         = 6, 	// Color : ()
		IxCOLOR_NAME       = 7, 	// Color : ()
		IxIN_YMD           = 8, 	// Date : ()
		IxIN_QTY           = 9, 	// In Qty : ()
		IxUNIT             = 10, 	// Unit : ()
		IxPUR_CURRENCY     = 11, 	// Currency : ()
		IxPUR_PRICE        = 12, 	// Price : ()
		IxAMOUNT_USD       = 13, 	// Price : ()
		IxAMOUNT_KRW       = 14, 	// Price : ()
		IxBUY_DIV          = 15, 	// Buy Division : ()
		IxPUR_DIV          = 16, 	// Purchase Division : ()
		IxOUTSIDE_CURRENCY = 17, 	// Currency : ()
		IxOUTSIDE_PRICE    = 18, 	// Price : ()
		IxCBD_CURRENCY     = 19, 	// Currency : ()
		IxCBD_PRICE        = 20, 	// Price : ()
		IxSHIP_CURRENCY    = 21, 	// Currency : ()
		IxSHIP_PRICE       = 22, 	// Price : ()
		IxPK_UNIT_QTY      = 23, 	// P/K Qty : ()
		IxPRICE_YN         = 24, 	// Price Y/N : ()
		IxWH_CD            = 25, 	// WareHouse : ()
		IxCUST_CD          = 26, 	// Code : ()
		IxCUST_NAME        = 27, 	// Name : ()
		IxSTYLE_CD         = 28, 	// Code : ()
		IxSTYLE_NAME       = 29, 	// Name : ()
		IxFACTORY          = 30, 	// Factory : ()
		IxIN_NO            = 31, 	// No : ()
		IxIN_SEQ           = 32, 	// Seq : ()
		IxLC_NO            = 33, 	// L/C No : ()
		IxINV_NO           = 34, 	// INV No : ()
		IxIN_STATUS        = 35, 	// Status : ()
		IxIN_PUR_USER      = 36, 	// Status : ()
		IxUPD_USER         = 37, 	// User : ()
		IxUPD_YMD          = 38 	// Upd Date : ()
	}




    public enum TBSBI_INCOMING_NO : int
    {
        IxMaxCt = 21,	// 인덱스 Count
        IxFACTORY = 1, 	//   : ()
        IxIN_NO = 2, 	// 입고번호 : ()
        IxIN_YMD = 3, 	// 입고일자 : ()
        IxIN_TYPE = 4, 	// 입고형식 : ()
        IxIN_TYPE_NM = 5, 	//   : ()
        IxPUR_DIV = 6, 	// 구매형태 : ()
        IxPUR_DIV_NM = 7, 	//   : ()
        IxBUY_DIV = 8, 	// 구매분류 : ()
        IxBUY_DIV_NM = 9, 	//   : ()
        IxIN_SIZE = 10, 	//   : ()
        IxLC_NO = 11, 	// LC No : ()
        IxINV_NO = 12, 	// I/V NO : ()
        IxIN_STATUS = 13, 	// 입고상태 : ()
        IxIN_STATUS_NM = 14, 	//   : ()
        IxCONFIRM_YN = 15, 	// 발주확정유무 : ()
        IxACC_UPD_YN = 16, 	// 회계I/F여부 : ()
        IxREMARKS = 17, 	// 비고 : ()
        IxSEND_CHK = 18, 	// Send : ()
        IxSEND_YMD = 19, 	// Send Date : ()
        IxUPD_USER = 20, 	// User : ()
        IxUPD_YMD = 21 	// Date : ()
    }




	public enum TBSBI_INCOMING_MANUAL_BARCODE : int
	{
		IxMaxCt         = 45,	// 인덱스 Count
		IxCHK           = 1, 	// C : ()
		IxQTY_CHK       = 2, 	// C : ()
		IxROW_CNT       = 3, 	// C : ()
		IxFACTORY       = 4, 	//   : ()
		IxITEM_CD       = 5, 	// Item : ()
		IxITEM_NAME     = 6, 	// Item : ()
		IxSPEC_CD       = 7, 	// Specification : ()
		IxSEPC_NAME     = 8, 	// Specification : ()
		IxCOLOR_CD      = 9, 	// Color : ()
		IxCOLOR_NAME    = 10, 	// Color : ()
		IxSHIP_QTY      = 11, 	// Seq : ()
		IxIN_QTY        = 12, 	// In Qty : ()
		IxSCAN_QTY      = 13, 	// Scan Qty : ()
		lxSCAN_DATE     = 14,
		IxPACKING       = 15,
		IxPK_UNIT_QTY   = 16, 	// P/K Qty : ()
		IxUNIT          = 17, 	// Unit : ()
		IxPUR_USER      = 18,
		IxSTYLE_CD      = 19, 	// Code : ()
		IxSTYLE_NAME    = 20, 	// Name : ()
		IxPRICE_YN      = 21, 	// Price Y/N : ()
		IxSHIP_DIV_CODE = 22, 	// Price Y/N : ()
		IxSHIP_DIV      = 23, 	// Price Y/N : ()
		IxPUR_PRICE     = 24, 	// Price : ()
		IxPUR_CURRENCY  = 25, 	// Currency : ()
		IxAMT_PRICE     = 26, 	// Price : ()
		IxAMT_CURRENCY  = 27, 	// Currency : ()
		IxCBD_PRICE     = 28, 	// Price : ()
		IxCBD_CURRENCY  = 29, 	// Currency : ()
		IxSHIP_PRICE    = 30, 	// Ship Price : ()
		IxSHIP_CURRENCY = 31, 	// Currency : ()
		IxSHIP_YMD      = 32, 	// Date : ()
		IxSHIP_NO       = 33, 	// No : ()
		IxSHIP_SEQ      = 34, 	// Seq : ()
		IxLOT_NO        = 35, 	// No : ()
		IxLOT_SEQ       = 36, 	// Seq : ()
		IxCUST_CD       = 37, 	// Code : ()
		IxCUST_NAME     = 38, 	// Name : ()
		IxWH_CD         = 39, 	// WareHouse : ()
		IxWH_NAME       = 40, 	// WareHouse : ()
		IxBAR_CODE      = 41, 	// Barcode : ()
		IxBAR_KIND      = 42, 	// Barcode Kind : ()
		IxCONT_NO       = 43, 	// Container No : ()
		IxIN_OK         = 44, 	// Container No : ()
		IxATTRIBUTE     = 45, 	// Container No : ()
	}


  	public enum TBSBI_INCOMING_AUTO_BARCODE : int
	{
		IxMaxCt         = 46,	// 인덱스 Count
		IxCHK           = 1, 	// C : ()
		IxQTY_CHK       = 2, 	// C : ()
		IxROW_CNT       = 3, 	// C : ()
		IxFACTORY       = 4, 	//   : ()
		IxITEM_CD       = 5, 	// Item : ()
		IxITEM_NAME     = 6, 	// Item : ()
		IxSPEC_CD       = 7, 	// Specification : ()
		IxSEPC_NAME     = 8, 	// Specification : ()
		IxCOLOR_CD      = 9, 	// Color : ()
		IxCOLOR_NAME    = 10, 	// Color : ()
		IxSHIP_QTY      = 11, 	// Seq : ()
		IxIN_QTY        = 12, 	// In Qty : ()
		IxSCAN_QTY      = 13, 	// Scan Qty : ()
		IxVENDER_IN_QTY    = 14, 	// Scan Qty : ()
		IxVENDER_SCAN_QTY  = 15, 	// Scan Qty : ()
		IxPACKING       = 16,
		IxPK_UNIT_QTY   = 17, 	// P/K Qty : ()
		IxUNIT          = 18, 	// Unit : ()
		IxPUR_USER      = 19,
		IxSTYLE_CD      = 20, 	// Code : ()
		IxSTYLE_NAME    = 21, 	// Name : ()
		IxPRICE_YN      = 22, 	// Price Y/N : ()
		IxSHIP_DIV_CODE = 23, 	// Price Y/N : ()
		IxSHIP_DIV      = 24, 	// Price Y/N : ()
		IxPUR_PRICE     = 25, 	// Price : ()
		IxPUR_CURRENCY  = 26, 	// Currency : ()
		IxAMT_PRICE     = 27, 	// Price : ()
		IxAMT_CURRENCY  = 28, 	// Currency : ()
		IxCBD_PRICE     = 29, 	// Price : ()
		IxCBD_CURRENCY  = 30, 	// Currency : ()
		IxSHIP_PRICE    = 31, 	// Ship Price : ()
		IxSHIP_CURRENCY = 32, 	// Currency : ()
		IxSHIP_YMD      = 33, 	// Date : ()
		IxSHIP_NO       = 34, 	// No : ()
		IxSHIP_SEQ      = 35, 	// Seq : ()
		IxLOT_NO        = 36, 	// No : ()
		IxLOT_SEQ       = 37, 	// Seq : ()
		IxCUST_CD       = 38, 	// Code : ()
		IxCUST_NAME     = 39, 	// Name : ()
		IxWH_CD         = 40, 	// WareHouse : ()
		IxWH_NAME       = 41, 	// WareHouse : ()
		IxBAR_CODE      = 42, 	// Barcode : ()
		IxBAR_KIND      = 43, 	// Barcode Kind : ()
		IxCONT_NO       = 44, 	// Container No : ()
		IxIN_OK         = 45, 	// Container No : ()
		IxATTRIBUTE     = 46, 	// Container No : ()
	}

 

	public enum TBSBI_IN_ITEM_INSPECT_M : int
	{
		IxMaxCt        = 37,	// 인덱스 Count
		IxTOTAL        = 1, 	// Factory : ()
		IxCUST_CD      = 2, 	// Vendor : ()
		IxCUST_NAME    = 3, 	// Vendor : ()
		IxITEM_CD      = 4, 	// Item : ()
		IxITEM_NAME    = 5, 	// Item : ()
		IxSPEC_CD      = 6, 	// Specification : ()
		IxSPEC_NAME    = 7, 	// Specification : ()
		IxCOLOR_CD     = 8, 	// Color : ()
		IxCOLOR_NAME   = 9, 	// Color : ()
		IxIN_YMD       = 10, 	// In Date : ()
		lxFACTORY	   = 11, 
		IxIN_QTY       = 12, 	// In Qty : ()
		IxUNIT         = 13, 	// Unit : ()
		IxPUR_DIV      = 14, 	// Unit : ()
		IxBUY_DIV      = 15, 	// Unit : ()
		IxPUR_PRICE    = 16, 	// Price : ()
		IxAMOUNT_USD   = 17, 	// Amount($) : ()
		IxAMOUNT_KRW   = 18, 	// Amount(W) : ()
		IxPUR_CURRENCY = 19, 	// Currency : ()
		IxPUR_NO       = 20, 	// No : ()
		IxPUR_SEQ      = 21, 	// Seq : ()
		IxLOT_NO       = 22, 	// No : ()
		IxLOT_SEQ      = 23, 	// Seq : ()
		IxPUR_USER     = 24, 	// User : ()
		IxSTYLE_CD     = 25, 	// Code : ()
		IxSTYLE_NAME   = 26, 	// Name : ()
		IxREMARKS      = 27, 	// Remarks : ()
		IxITEM         = 28, 	// Item : ()
		IxGROUP_T_CD   = 29, 	//   : ()
		IxGROUP_L_CD   = 30, 	//   : ()
		IxGROUP_M_CD   = 31, 	//   : ()
		IxCLASS_TYPE   = 32, 	//   : ()
		IxFIRST_CLASS  = 33, 	//   : ()
		IxSECOND_CLASS = 34, 	//   : ()
		IxGROUP_CD     = 35, 	//   : ()
		IxYMD_VENDOR   = 36, 	//   : ()
		IxYMD_ITEM     = 37, 	//   : ()
		IxVENDOR_ITEM  = 38, 	//   : ()
		IxUPD_YMD      = 39, 	//   : ()
		IxORDER_BY     = 40 	//   : ()
	}



    public enum TBSBI_IN_ITEM_INSPECT_F : int
    {
        IxMaxCt = 37,	// 인덱스 Count
        IxTOTAL = 1, 	// Factory : ()
        IxFACTORY = 2, 	// Factory : ()
        IxCUST_CD = 3, 	// Vendor : ()
        IxCUST_NAME = 4, 	// Vendor : ()
        IxPUR_USER = 5, 	// User : ()
        IxITEM_CD = 6, 	// Item : ()
        IxITEM_NAME = 7, 	// Item : ()
        IxSPEC_CD = 8, 	// Specification : ()
        IxSPEC_NAME = 9, 	// Specification : ()
        IxCOLOR_CD = 10, 	// Color : ()
        IxCOLOR_NAME = 11, 	// Color : ()
        IxIN_QTY = 12, 	// In Qty : ()
        IxUNIT = 13, 	// Unit : ()
        IxIN_YMD = 14, 	// In Date : ()
        IxPUR_DIV = 15, 	// Unit : ()
        IxBUY_DIV = 16, 	// Unit : ()
        IxPUR_PRICE = 17, 	// Price : ()
        IxAMOUNT_USD = 18, 	// Amount($) : ()
        IxAMOUNT_KRW = 19, 	// Amount(W) : ()
        IxPUR_CURRENCY = 20, 	// Currency : ()
        IxPUR_NO = 21, 	// No : ()
        IxPUR_SEQ = 22, 	// Seq : ()
        IxLOT_NO = 23, 	// No : ()
        IxLOT_SEQ = 24, 	// Seq : ()
        IxSTYLE_CD = 25, 	// Code : ()
        IxSTYLE_NAME = 26, 	// Name : ()
        IxREMARKS = 27, 	// Remarks : ()
        IxITEM = 28, 	// Item : ()
        IxGROUP_T_CD = 29, 	//   : ()
        IxGROUP_L_CD = 30, 	//   : ()
        IxGROUP_M_CD = 31, 	//   : ()
        IxCLASS_TYPE = 32, 	//   : ()
        IxFIRST_CLASS = 33, 	//   : ()
        IxSECOND_CLASS = 34, 	//   : ()
        IxGROUP_CD = 35, 	//   : ()
        IxYMD_VENDOR = 36, 	//   : ()
        IxYMD_ITEM = 37, 	//   : ()
        IxVENDOR_ITEM = 38, 	//   : ()
        IxUPD_YMD = 39 	//   : ()
    }



    public enum TBSBI_IN_ITEM_INSPECT_V : int
    {
        IxMaxCt = 37,	// 인덱스 Count
        IxTOTAL = 1, 	// Factory : ()
        IxFACTORY = 2, 	// Factory : ()
        IxCUST_CD = 3, 	// Vendor : ()
        IxCUST_NAME = 4, 	// Vendor : ()
        IxPUR_USER = 5, 	// User : ()
        IxITEM_CD = 6, 	// Item : ()
        IxITEM_NAME = 7, 	// Item : ()
        IxSPEC_CD = 8, 	// Specification : ()
        IxSPEC_NAME = 9, 	// Specification : ()
        IxCOLOR_CD = 10, 	// Color : ()
        IxCOLOR_NAME = 11, 	// Color : ()
        IxIN_QTY = 12, 	// In Qty : ()
        IxUNIT = 13, 	// Unit : ()
        IxIN_YMD = 14, 	// In Date : ()
        IxPUR_DIV = 15, 	// Unit : ()
        IxBUY_DIV = 16, 	// Unit : ()
        IxPUR_PRICE = 17, 	// Price : ()
        IxAMOUNT_USD = 18, 	// Amount($) : ()
        IxAMOUNT_KRW = 19, 	// Amount(W) : ()
        IxPUR_CURRENCY = 20, 	// Currency : ()
        IxPUR_NO = 21, 	// No : ()
        IxPUR_SEQ = 22, 	// Seq : ()
        IxLOT_NO = 23, 	// No : ()
        IxLOT_SEQ = 24, 	// Seq : ()
        IxSTYLE_CD = 25, 	// Code : ()
        IxSTYLE_NAME = 26, 	// Name : ()
        IxREMARKS = 27, 	// Remarks : ()
        IxITEM = 28, 	//   : ()
        IxGROUP_T_CD = 29, 	//   : ()
        IxGROUP_L_CD = 30, 	//   : ()
        IxGROUP_M_CD = 31, 	//   : ()
        IxCLASS_TYPE = 32, 	//   : ()
        IxFIRST_CLASS = 33, 	//   : ()
        IxSECOND_CLASS = 34, 	//   : ()
        IxGROUP_CD = 35, 	//   : ()
        IxYMD_VENDOR = 36, 	//   : ()
        IxYMD_ITEM = 37, 	//   : ()
        IxVENDOR_ITEM = 38, 	//   : ()
        IxUPD_YMD = 39 	//   : ()
    }



    public enum TBSBI_IN_ITEM_INSPECT_C : int
    {
        IxMaxCt = 37,	// 인덱스 Count
        IxTOTAL = 1, 	// Factory : ()
        IxFACTORY = 2, 	//   : ()
        IxCLASS_TYPE = 3, 	//   : ()
        IxFIRST_CLASS = 4, 	// First : ()
        IxSECOND_CLASS = 5, 	// Second : ()
        IxGROUP_T_CD = 6, 	//   : ()
        IxGROUP_L_CD = 7, 	//   : ()
        IxGROUP_M_CD = 8, 	//   : ()
        IxCUST_CD = 9, 	// Vendor : ()
        IxCUST_NAME = 10, 	// Vendor : ()
        IxPUR_USER = 11, 	// User : ()
        IxITEM_CD = 12, 	// Item : ()
        IxITEM_NAME = 13, 	// Item : ()
        IxSPEC_CD = 14, 	// Specification : ()
        IxSPEC_NAME = 15, 	// Specification : ()
        IxCOLOR_CD = 16, 	// Color : ()
        IxCOLOR_NAME = 17, 	// Color : ()
        IxIN_QTY = 18, 	// In Qty : ()
        IxUNIT = 19, 	// Unit : ()
        IxIN_YMD = 20, 	// In Date : ()
        IxPUR_DIV = 21, 	// Unit : ()
        IxBUY_DIV = 22, 	// Unit : ()
        IxPUR_PRICE = 23, 	// Price : ()
        IxAMOUNT_USD = 24, 	// Amount($) : ()
        IxAMOUNT_KRW = 25, 	// Amount(W) : ()
        IxPUR_CURRENCY = 26, 	// Currency : ()
        IxPUR_NO = 27, 	// No : ()
        IxPUR_SEQ = 28, 	// Seq : ()
        IxLOT_NO = 29, 	// No : ()
        IxLOT_SEQ = 30, 	// Seq : ()
        IxSTYLE_CD = 31, 	// Code : ()
        IxSTYLE_NAME = 32, 	// Name : ()
        IxREMARKS = 33, 	// Remarks : ()
        IxITEM = 34, 	//   : ()
        IxGROUP_CD = 35, 	//   : ()
        IxUPD_YMD = 36, 	//   : ()
        IxYMD_VENDOR = 37, 	//   : ()
        IxYMD_ITEM = 38, 	//   : ()
        IxVENDOR_ITEM = 39 	//   : ()
    }




    public enum TBSBI_IN_ITEM_INSPECT_H : int
    {
        IxMaxCt = 37,	// 인덱스 Count
        IxTOTAL = 1, 	// Factory : ()\
        IxCUST_CD = 2, 	// Vendor : ()
        IxCUST_NAME = 3, 	// Vendor : ()
        IxPUR_USER = 4, 	// User : ()
        IxITEM_CD = 5, 	// Item : ()
        IxITEM_NAME = 6, 	// Item : ()
        IxSPEC_CD = 7, 	// Specification : ()
        IxSPEC_NAME = 8, 	// Specification : ()
        IxCOLOR_CD = 9, 	// Color : ()
        IxCOLOR_NAME = 10, 	// Color : ()
        IxIN_QTY = 11, 	// In Qty : ()
        IxUNIT = 12, 	// Unit : ()
        IxIN_YMD = 13, 	// In Date : ()
        IxPUR_DIV = 14, 	// Unit : ()
        IxBUY_DIV = 15, 	// Unit : ()
        IxPUR_PRICE = 16, 	// Price : ()
        IxAMOUNT_USD = 17, 	// Amount($) : ()
        IxAMOUNT_KRW = 18, 	// Amount(W) : ()
        IxPUR_CURRENCY = 19, 	// Currency : ()
        IxPUR_NO = 20, 	// No : ()
        IxPUR_SEQ = 21, 	// Seq : ()
        IxLOT_NO = 22, 	// No : ()
        IxLOT_SEQ = 23, 	// Seq : ()
        IxSTYLE_CD = 24, 	// Code : ()
        IxSTYLE_NAME = 25, 	// Name : ()
        IxREMARKS = 26, 	// Remarks : ()
        IxITEM = 27, 	//   : ()
        IxGROUP_T_CD = 28, 	//   : ()
        IxGROUP_L_CD = 29, 	//   : ()
        IxGROUP_M_CD = 30, 	//   : ()
        IxCLASS_TYPE = 31, 	//   : ()
        IxFISRT_CLASS = 32, 	//   : ()
        IxSECOND_CLASS = 33, 	//   : ()
        IxGROUP_CD = 34, 	//   : ()
        IxYMD_VENDOR = 35, 	//   : ()
        IxYMD_ITEM = 36, 	//   : ()
        IxVENDOR_ITEM = 37, 	//   : ()
        IxUPD_YMD = 38, 	//   : ()
        IxFACTORY = 39, 	//   : ()
    }



    public enum TBSBI_IN_ITEM_INSPECT_D : int
    {
        IxMaxCt = 37,	// 인덱스 Count
        IxTOTAL = 1, 	// Factory : ()
        IxIN_YMD = 2, 	// In Date : ()
        IxCUST_CD = 3, 	// Vendor : ()
        IxCUST_NAME = 4, 	// Vendor : ()
        IxPUR_USER = 5, 	// User : ()
        IxITEM_CD = 6, 	// Item : ()
        IxITEM_NAME = 7, 	// Item : ()
        IxSPEC_CD = 8, 	// Specification : ()
        IxSPEC_NAME = 9, 	// Specification : ()
        IxCOLOR_CD = 10, 	// Color : ()
        IxCOLOR_NAME = 11, 	// Color : ()
        IxIN_QTY = 12, 	// In Qty : ()
        IxUNIT = 13, 	// Unit : ()
        IxPUR_DIV = 14, 	// Unit : ()
        IxBUY_DIV = 15, 	// Unit : ()
        IxPUR_PRICE = 16, 	// Price : ()
        IxAMOUNT_USD = 17, 	// Amount($) : ()
        IxAMOUNT_KRW = 18, 	// Amount(W) : ()
        IxPUR_CURRENCY = 19, 	// Currency : ()
        IxPUR_NO = 20, 	// No : ()
        IxPUR_SEQ = 21, 	// Seq : ()
        IxLOT_NO = 22, 	// No : ()
        IxLOT_SEQ = 23, 	// Seq : ()
        IxSTYLE_CD = 24, 	// Code : ()
        IxSTYLE_NAME = 25, 	// Name : ()
        IxREMARKS = 26, 	// Remarks : ()
        IxITEM = 27, 	//   : ()
        IxGROUP_T_CD = 28, 	//   : ()
        IxGROUP_L_CD = 29, 	//   : ()
        IxGROUP_M_CD = 30, 	//   : ()
        IxCLASS_TYPE = 31, 	//   : ()
        IxFIRST_CLASS = 32, 	//   : ()
        IxSECOND_CLASS = 33, 	//   : ()
        IxGROUP_CD = 34, 	//   : ()
        IxYMD_VENDOR = 35, 	//   : ()
        IxYMD_ITEM = 36, 	//   : ()
        IxVENDOR_ITEM = 37, 	//   : ()
        IxUPD_YMD = 38, 	//   : ()
        IxFACTORY = 39, 	//   : ()
    }



    public enum TBSBI_IN_ITEM_INSPECT_A : int
    {
        IxMaxCt = 37,	// 인덱스 Count
        IxTOTAL = 1, 	// Factory : ()
        IxIN_YMD = 2, 	// In Date : ()
        IxCUST_CD = 3, 	// Vendor : ()
        IxCUST_NAME = 4, 	// Vendor : ()
        IxPUR_USER = 5, 	// User : ()
        IxITEM_CD = 6, 	// Item : ()
        IxITEM_NAME = 7, 	// Item : ()
        IxSPEC_CD = 8, 	// Specification : ()
        IxSPEC_NAME = 9, 	// Specification : ()
        IxCOLOR_CD = 10, 	// Color : ()
        IxCOLOR_NAME = 11, 	// Color : ()
        IxIN_QTY = 12, 	// In Qty : ()
        IxUNIT = 13, 	// Unit : ()
        IxPUR_DIV = 14, 	// Unit : ()
        IxBUY_DIV = 15, 	// Unit : ()
        IxPUR_PRICE = 16, 	// Price : ()
        IxAMOUNT_USD = 17, 	// Amount($) : ()
        IxAMOUNT_KRW = 18, 	// Amount(W) : ()
        IxPUR_CURRENCY = 19, 	// Currency : ()
        IxPUR_NO = 20, 	// No : ()
        IxPUR_SEQ = 21, 	// Seq : ()
        IxLOT_NO = 22, 	// No : ()
        IxLOT_SEQ = 23, 	// Seq : ()
        IxSTYLE_CD = 24, 	// Code : ()
        IxSTYLE_NAME = 25, 	// Name : ()
        IxREMARKS = 26, 	// Remarks : ()
        IxITEM = 27, 	// User : ()
        IxGROUP_T_CD = 28, 	//   : ()
        IxGROUP_L_CD = 29, 	//   : ()
        IxGROUP_M_CD = 30, 	//   : ()
        IxCLASS_TYPE = 31, 	//   : ()
        IxFIRST_CLASS = 32, 	//   : ()
        IxSECOND_CLASS = 33, 	//   : ()
        IxGROUP_CD = 34, 	//   : ()
        IxYMD_ITEM = 35, 	//   : ()
        IxYMD_VENDOR = 36, 	//   : ()
        IxVENDOR_ITEM = 37, 	//   : ()
        IxUPD_YMD = 38, 	//   : ()
        IxFACTORY = 39, 	// Factory : ()
    }




	/// <summary> 
	/// SBI_IN_PURPRICE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBI_IN_PURPRICE : int
	{
		IxMaxCt         = 13,	// 인덱스 Count
		IxDIVISION      = 0 , 	// Factory : VARCHAR2(5)
		IxCUST_CD       = 1, 	// Currency : VARCHAR2(10)
		IxCUST_NAME     = 2, 	// Currency : VARCHAR2(10)
		IxITEM_CD       = 3, 	// Item : ()
		IxSPEC_CD       = 4, 	// Spec Code : VARCHAR2(5)
		IxCOLOR_CD      = 5, 	// Color Code : VARCHAR2(5)
		IxITEM_NAME     = 6, 	// Item : ()
		IxSPEC_NAME     = 7, 	// Specification : ()
		IxCOLOR_NAME    = 8, 	// Color : ()
		IxNEW_PUR_PRICE = 9, 	// Currency : VARCHAR2(10)
		IxOLD_PUR_PRICE = 10, 	// Price : NUMBER(22)
		IxROW_CTN       = 11, 	// Price : NUMBER(22)
		IxBUY_DIV       = 12, 	// Currency : VARCHAR2(10)
		IxPUR_DIV       = 13, 	// Currency : VARCHAR2(10)
		IxIN_YMD        = 14, 	// Currency : VARCHAR2(10)
		IxFACTORY       = 15, 	// Factory : VARCHAR2(5)
		IxIN_NO         = 16, 	// Item : VARCHAR2(10)
		IxIN_SEQ        = 17, 	// Item : VARCHAR2(10)
	}






    #endregion

    #region 출고


    public enum TBSBO_OUT_HEAD : int
    {
        IxMaxCt = 16,	// 인덱스 Count
        IxFACTORY = 1, 	// 공장코드 : VARCHAR2(5)
        IxOUT_NO = 2, 	// 출고NO : VARCHAR2(20)
        IxOUT_YMD = 3, 	//   : VARCHAR2(8)
        IxOUT_TYPE = 4, 	//   : VARCHAR2(10)
        IxOUT_SIZE = 5, 	//   : VARCHAR2(1)
        IxOUT_PROCESS = 6, 	//   : VARCHAR2(10)
        IxOUT_LINE = 7, 	//   : VARCHAR2(3)
        IxOUT_DIVISION = 8, 	//   : VARCHAR2(1)
        IxREAL_OUT_YMD = 9, 	//   : VARCHAR2(8)
        IxOUT_STATUS = 10, 	//   : VARCHAR2(10)
        IxCONFIRM_YN = 11, 	//   : VARCHAR2(1)
        IxREMARKS = 12, 	// 비고 : VARCHAR2(500)
        IxSEND_CHK = 13, 	// Send : VARCHAR2(10)
        IxSEND_YMD = 14, 	// Send Date : DATE(7)
        IxUPD_USER = 15, 	//   : VARCHAR2(30)
        IxUPD_YMD = 16 	//   : DATE(7)
    }



    public enum TBSBO_OUT_TAIL : int
    {
        IxMaxCt = 49,	// 인덱스 Count
        IxSEQ = 1, 	// Seq : ()
        IxFACTORY = 2, 	// Factory : VARCHAR2(5)
        IxOUT_NO = 3, 	// No : VARCHAR2(20)
        IxOUT_SEQ = 4, 	// Seq : NUMBER(22)
        IxITEM_CD = 5, 	// Item : VARCHAR2(10)
        IxITEM_NAME = 6, 	// Item : ()
        IxSPEC_CD = 7, 	// Specification : VARCHAR2(5)
        IxSPEC_NAME = 8, 	// Specification : ()
        IxCOLOR_CD = 9, 	// Color : VARCHAR2(5)
        IxCOLOR_NAME = 10, 	// Color : ()
        IxOUT_QTY = 11, 	// Out Qty : NUMBER(22)
        IxUNIT = 12, 	// Unit : ()
        IxPK_UNIT_QTY = 13, 	// P/K Qty : NUMBER(22)
        IxPUR_CURRENCY = 14, 	// Currency : VARCHAR2(10)
        IxPUR_PRICE = 15, 	// Price : NUMBER(22)
        IxOUTSIDE_CURRENCY = 16, 	// Currency : VARCHAR2(10)
        IxOUTSIDE_PRICE = 17, 	// Price : NUMBER(22)
        IxCBD_CURRENCY = 18, 	// Currency : VARCHAR2(10)
        IxCBD_PRICE = 19, 	// Price : NUMBER(22)
        IxSHIP_CURRENCY = 20, 	// Currency : VARCHAR2(10)
        IxSHIP_PRICE = 21, 	// Price : NUMBER(22)
        IxPRICE_YN = 22, 	// Price Y/N : VARCHAR2(1)
        IxCUST_CD = 23, 	// Code : VARCHAR2(10)
        IxCUST_NAME = 24, 	// Name : ()
        IxBAR_CODE = 25, 	// code : VARCHAR2(24)
        IxBAR_KIND = 26, 	// Kind : VARCHAR2(4)
        IxBAR_MOVE = 27, 	// Move : VARCHAR2(4)
        IxCONT_NO = 28, 	// Container No : VARCHAR2(20)
        IxSHIP_YMD = 29, 	// Date : VARCHAR2(8)
        IxSHIP_NO = 30, 	// No : VARCHAR2(20)
        IxSHIP_SEQ = 31, 	// Seq : VARCHAR2(4)
        IxSHIP_QTY = 32, 	// Qty : NUMBER(22)
        IxLOT_NO = 33, 	// No : VARCHAR2(9)
        IxLOT_SEQ = 34, 	// Seq : VARCHAR2(2)
        IxSTYLE_CD = 35, 	// Code : VARCHAR2(9)
        IxSTYLE_NAME = 36, 	// Name : ()
        IxDIR_QTY = 37, 	// Dir Qty : NUMBER(22)
        IxWH_CD = 38, 	// WareHouse : VARCHAR2(10)
        IxPAY_CD = 39, 	// Pay Code : VARCHAR2(10)
        IxREQ_NO = 40, 	// No : VARCHAR2(20)
        IxREQ_SEQ = 41, 	// Seq : NUMBER(22)
        IxREQ_USER = 42, 	// User : VARCHAR2(30)
        IxREQ_DEPT = 43, 	// Dept Code : VARCHAR2(10)
        IxOUT_STATUS = 44, 	// Status : VARCHAR2(10)
        IxREMARKS = 45, 	// Remarks : VARCHAR2(500)
        IxMOD_QTY = 46, 	// Mod Qty : NUMBER(22)
        IxTRAN_DIV = 47, 	// Tran Div : VARCHAR2(1)
        IxUPD_USER = 48, 	//   : VARCHAR2(30)
        IxUPD_YMD = 49 	//   : DATE(7)
    }



	public enum TBSBO_OUTGOING_PRODUCTION : int
	{
		 
		IxTREE_LEVEL = 1, 	
		IxFACTORY = 2, 	 
		IxOUT_PROCESS = 3, 	
		IxOUT_LINE = 4, 	
		IxOUT_NO = 5, 	 
		IxOUT_SEQ = 6, 	 
		IxSTYLE_CD = 7, 	
		IxSTYLE_NAME = 8,  
		IxCOL_ITEM_NAME = 9, 	 
		IxCOL_SPEC_NAME = 10, 	
		IxCOL_COLOR_NAME = 11, 	 
		IxDIR_QTY = 12, 	
		IxOUT_QTY = 13,  
		IxREMAINDER_QTY = 14, 
		IxUNIT = 15, 	
		IxOUT_STATUS = 16, 	
		IxITEM_CD = 17,  
		IxSPEC_CD = 18, 	
		IxCOLOR_CD = 19, 	
		IxITEM_NAME = 20, 	 
		IxSPEC_NAME = 21, 	 
		IxCOLOR_NAME = 22,
		IxORG_REMAINDER_QTY = 23,
		IxWH_CD = 24,
	 
	}




	public enum TBSBO_OUTGOING_OTHER : int
	{

		IxSEQ               = 1, 
		IxFACTORY			= 2, 
		IxOUT_NO			= 3, 
		IxOUT_SEQ			= 4, 
		IxITEM_NAME			= 5, 
		IxSPEC_NAME			= 6, 
		IxCOLOR_NAME		= 7, 
		IxDIR_QTY			= 8, 
		IxOUT_QTY			= 9, 
		IxPK_UNIT_QTY		= 10, 
		IxUNIT				= 11, 
		IxPUR_CURRENCY		= 12, 
		IxPUR_PRICE			= 13, 
		IxOUTSIDE_CURRENCY	= 14, 
		IxOUTSIDE_PRICE		= 15, 
		IxCBD_CURRENCY		= 16, 
		IxCBD_PRICE			= 17, 
		IxSHIP_CURRENCY     = 18,
		IxSHIP_PRICE		= 19,
		IxPRICE_YN			= 20,
		IxCUST_CD			= 21,
		IxCUST_NAME			= 22,
		IxBAR_CODE			= 23,
		IxBAR_KIND			= 24,
		IxBAR_MOVE			= 25,
		IxCONT_NO			= 26,
		IxSHIP_YMD			= 27,
		IxSHIP_NO			= 28,
		IxSHIP_SEQ			= 29,
		IxSHIP_QTY			= 30,
		IxLOT_NO			= 31,
		IxLOT_SEQ			= 32,
		IxSTYLE_CD			= 33,
		IxSTYLE_NAME		= 34,
		IxWH_CD             = 35,
		IxPAY_CD			= 36,
		IxREQ_NO			= 37,
		IxREQ_SEQ			= 38,
		IxREQ_USER			= 39,
		IxREQ_DEPT			= 40,
		IxOUT_STATUS		= 41,
		IxREMARKS			= 42,
		IxMOD_QTY			= 43,
		IxTRAN_DIV			= 44,
		IxITEM_CD			= 45,
		IxSPEC_CD			= 46,
		IxCOLOR_CD			= 47,

		IxOUT_TYPE			= 48,
		IxOUT_DIVISION	    = 49,
		IxOUT_LINE			= 50,
		IxOUT_PROCESS		= 51,
		IxOUT_SIZE			= 52, 
		IxREMARKS_HEAD      = 53,
 

	}	 





    public enum TBSBB_REMAINDER : int
    {
        IxMaxCt = 20,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : VARCHAR2(5)
        IxWORK_MONTH = 2, 	// YM : VARCHAR2(6)
        IxLINE_CD = 3, 	// Line : VARCHAR2(3)
        IxLINE_NAME = 4, 	// Line : ()
        IxOP_CD = 5, 	// Process : VARCHAR2(10)
        IxOP_NAME = 6, 	// Process : ()
        IxITEM_CD = 7, 	// Item : VARCHAR2(10)
        IxITEM_NAME = 8, 	// Item : ()
        IxSPEC_CD = 9, 	// Specification : VARCHAR2(5)
        IxSPEC_NAME = 10, 	// Specification : ()
        IxCOLOR_CD = 11, 	// Color : VARCHAR2(5)
        IxCOLOR_NAME = 12, 	// Color : ()
        IxUNIT = 13, 	// Unit : ()
        IxREMAINDER_QTY = 14, 	// Remainder : NUMBER(22)
        IxADJUST_QTY = 15, 	// Adjust : NUMBER(22)
        IxREMARKS = 16, 	// Adjust_Reason : VARCHAR2(500)
        IxREASON = 17, 	// Adjust_Reason : ()
        IxSTATUS = 18, 	// Status : VARCHAR2(1)
        IxUPD_USER = 19, 	// 수정자 : VARCHAR2(30)
        IxUPD_YMD = 20 	// 수정일 : DATE(7)
    }



	public enum TBSBO_OUT_EXPEND : int
	{
		IxITEM_NAME			= 1, 	 
		IxSPEC_NAME			= 2, 	 
		IxCOLOR_NAME		= 3,
		IxLOT				= 4, 	 
		IxDIR_QTY			= 5, 	
		IxOUT_QTY			= 6, 	
		IxREAL_OUT_YMD		= 7, 
		IxOUT_STATUS_VALUE	= 8, 
		IxREMARKS			= 9, 	 
		IxFACTORY			= 10, 	 
		IxOUT_YMD			= 11, 	
		IxOUT_PROCESS		= 12,  
		IxOUT_LINE			= 13, 	 
		IxSTYLE_CD			= 14, 	
		IxCOMPONENT_CD		= 15, 	 
		IxLOT_NO			= 16, 	
		IxLOT_SEQ			= 17,  
		IxITEM_CD			= 18, 
		IxSPEC_CD			= 19, 	
		IxCOLOR_CD			= 20, 
		IxUPD_USER			= 21, 
		IxOUT_STATUS		= 22
	}



    public enum TBSBO_CONTAINER_OUTGOING : int
    {
        IxMaxCt = 27,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : ()
        IxOUT_NO = 2, 	// No : ()
        IxREAL_OUT_YMD = 3, 	// Out Date : ()
        IxITEM_CD = 4, 	// Item : ()
        IxITEM_NAME = 5, 	// Item : ()
        IxSPEC_CD = 6, 	// Specification : ()
        IxSPEC_NAME = 7, 	// Specification : ()
        IxCOLOR_CD = 8, 	// Color : ()
        IxCOLOR_NAME = 9, 	// Color : ()
        IxOUT_QTY = 10, 	// Out Qty : ()
        IxUNIT = 11, 	// Unit : ()
        IxCUST_CD = 12, 	// Code : ()
        IxCUST_NAME = 13, 	// Name : ()
        IxBAR_CODE = 14, 	// code : ()
        IxBAR_KIND = 15, 	// Kind : ()
        IxBAR_MOVE = 16, 	// Move : ()
        IxCONT_NO = 17, 	// Container No : ()
        IxSHIP_YMD = 18, 	// Date : ()
        IxSHIP_NO = 19, 	// No : ()
        IxSHIP_SEQ = 20, 	// Seq : ()
        IxSHIP_QTY = 21, 	// Qty : ()
        IxLOT_NO = 22, 	// No : ()
        IxLOT_SEQ = 23, 	// Seq : ()
        IxSTYLE_CD = 24, 	// Code : ()
        IxSTYLE_NAME = 25, 	// Name : ()
        IxUPD_USER = 26, 	//   : ()
        IxUPD_YMD = 27 	//   : ()
    }




    public enum TBSBO_OUTGOING_REQ : int
    {
        IxMaxCt = 27,	// 인덱스 Count
        IxCHK = 1, 	// C : ()
        IxFACTORY = 2, 	//   : ()
        IxREQ_NO = 3, 	//   : ()
        IxREQ_SEQ = 4, 	//   : ()
        IxREQ_YMD = 5, 	//   : ()
        IxREQ_USER = 6, 	//   : ()
        IxITEM_CD = 7, 	// Item : ()
        IxITEM_NAME = 8, 	// Item : ()
        IxSPEC_CD = 9, 	// Specification : ()
        IxSEPC_NAME = 10, 	// Specification : ()
        IxCOLOR_CD = 11, 	// Color : ()
        IxCOLOR_NAME = 12, 	// Color : ()
        IxREQ_QTY = 13, 	// Req : ()
        IxOUT_QTY = 14, 	// Outgoing : ()
        IxUNIT = 15, 	// Unit : ()
        IxREQ_DEPT = 16, 	// Code : ()
        IxDEPT_NAME = 17, 	// Name : ()
        IxPUR_CURRENCY = 18, 	// Currency : ()
        IxPUR_PRICE = 19, 	// Price : ()
        IxCBD_CURRENCY = 20, 	// Currency : ()
        IxCBD_PRICE = 21, 	// Price : ()
        IxSHIP_CURRENCY = 22, 	// Currency : ()
        IxSHIP_PRICE = 23, 	// Price : ()
        IxSTYLE_CD = 24, 	// Code : ()
        IxSTYLE_NAME = 25, 	// Name : ()
        IxUPD_USER = 26, 	// User : ()
        IxUPD_YMD = 27 	//   : ()
    }



    public enum TBSBO_OUTGOING_PUR : int
    {
        IxCHK = 1,
        IxFACTORY = 2,
        IxPUR_NO = 3,
        IxPUR_SEQ = 4,
        IxIN_YMD = 5,
        IxPUR_USER = 6,
        IxITEM_CD = 7,
        IxITEM_NAME = 8,
        IxSPEC_CD = 9,
        IxSEPC_NAME = 10,
        IxCOLOR_CD = 11,
        IxCOLOR_NAME = 12,
        IxIN_QTY = 13,
        IxUNIT = 14,
        IxPK_UNIT_QTY = 15,
        IxPUR_PRICE = 16,
        IxPUR_CURRENCY = 17,
        IxCBD_PRICE = 18,
        IxCBD_CURRENCY = 19,
        IxSHIP_PRICE = 20,
        IxSHIP_CURRENCY = 21,
        IxSTYLE_CD = 22,
        IxSTYLE_NAME = 23,
        IxCUST_CD = 24,
        IxCUST_NAME = 25,
        IxBAR_CODE_REP = 26,
        IxBAR_KIND = 27,
        IxBAR_MOVE = 28,
        IxCONT_NO = 29,
        IxSHIP_YMD = 30,
        IxSHIP_NO = 31,
        IxSHIP_SEQ = 32,
        IxSHIP_QTY = 33,
        IxLOT_NO = 34,
        IxLOT_SEQ = 35,
        IxPRICE_YN = 36,
        IxTRANS_DIV = 37,
        IxWH_CD = 38,
        IxUPD_USER = 39,
        IxUPD_YMD = 40
    }




    public enum TBSBO_OUTGOING_CONT : int
    {
        IxMaxCt = 41,	// 인덱스 Count
        IxCHK = 1, 	// C : ()
        IxBAR_CODE = 2, 	// Barcode : ()
        IxFACTORY = 3, 	//   : ()
        IxITEM_CD = 4, 	// Item : ()
        IxITEM_NAME = 5, 	// Item : ()
        IxSPEC_CD = 6, 	// Specification : ()
        IxSEPC_NAME = 7, 	// Specification : ()
        IxCOLOR_CD = 8, 	// Color : ()
        IxCOLOR_NAME = 9, 	// Color : ()
        IxSCAN_QYT = 10, 	// Scan : ()
        IxOUT_QTY = 11, 	// Outgoing : ()
        IxUNIT = 12, 	// Unit : ()
        IxSHIP_YMD = 13, 	// Date : ()
        IxSHIP_NO = 14, 	// No : ()
        IxSHIP_SEQ = 15, 	// Seq : ()
        IxLOT_NO = 16, 	// No : ()
        IxLOT_SEQ = 17, 	// Seq : ()
        IxSTYLE_CD = 18, 	// Code : ()
        IxSTYLE_NAME = 19, 	// Name : ()
        IxPK_UNIT_QTY = 20, 	// P/K Qty : ()
        IxCUST_CD = 21, 	// Vendor : ()
        IxCUST_NAME = 22, 	// Vendor : ()
        IxWH_CD = 23, 	// WareHouse : ()
        IxWH_NAME = 24, 	// WareHouse : ()
        IxBAR_MOVE = 25, 	// Barcode Move : ()
        IxCONT_NO = 26, 	// Container No : ()
        IxPUR_CURRENCY = 27, 	// Currency : ()
        IxCBD_PUR_CURRENCY = 28, 	//   : ()
        IxCHECK_PUR = 29, 	//   : ()
        IxPUR_PRICE = 30, 	// Price : ()
        IxCBD_CURRENCY = 31, 	// Currency : ()
        IxCBD_CBD_CURRENCY = 32, 	//   : ()
        IxCHECK_CBD = 33, 	//   : ()
        IxCBD_PRICE = 34, 	// Price : ()
        IxSHIP_CURRENCY = 35, 	// Currency : ()
        IxCBD_SHIP_CURRENCY = 36, 	//   : ()
        IxCHECK_SHIP = 37, 	//   : ()
        IxSHIP_PRICE = 38, 	// Price : ()
        IxPRICE_YN = 39, 	// Price Y/N : ()
        IxUPD_USER = 40, 	// User : ()
        IxUPD_YMD = 41 	//   : ()
    }





    #endregion

    #region 발주


    public enum TBSBP_ORDER : int
    {
        IxMaxCt = 27,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : VARCHAR2(5)
        IxSEASON = 2, 	// Season : VARCHAR2(10)
        IxSTYLE_CD = 3, 	// Style Code : VARCHAR2(9)
        IxSTYLE_NAME = 4, 	// Model Name : ()
        IxCS_SIZE = 5, 	// Size : VARCHAR2(10)
        IxORDER_QTY = 6, 	// Order Qty : NUMBER(22)
        IxADD_QTY = 7, 	// Add Qty : NUMBER(22)
        IxSRF_NO = 8, 	// SRF No : VARCHAR2(20)
        IxORDER_TYPE = 9, 	// Order Type : VARCHAR2(2)
        IxOLD_STYLE_CD = 10, 	// Old Style No : VARCHAR2(9)
        IxBU_NO = 11, 	// BU No : VARCHAR2(4)
        IxCATEGORY = 12, 	// Category : VARCHAR2(20)
        IxDEVELOPER = 13, 	// Developer : VARCHAR2(20)
        IxBOM_ISSUE = 14, 	// BOM Issue : VARCHAR2(8)
        IxCFM_PO = 15, 	// CFM PO : VARCHAR2(8)
        IxCFM_SET = 16, 	// CFM Set : VARCHAR2(8)
        IxSWATCH = 17, 	// Swatch : VARCHAR2(8)
        IxCFM_SHOE = 18, 	// CFM SHOE : VARCHAR2(8)
        IxMUL_ISSUE = 19, 	// M.U.L Issue : VARCHAR2(8)
        IxERP_INPUT = 20, 	// ERP Input : VARCHAR2(8)
        IxSC_ISSUE = 21, 	// S/C Issue : VARCHAR2(8)
        IxMSET_TARGET = 22, 	// M/Set Target : VARCHAR2(8)
        IxMIN_BAL_SET = 23, 	// MIN/BAL Set : VARCHAR2(8)
        IxREMARKS = 24, 	// Remarks : VARCHAR2(500)
        IxSTATUS = 25, 	// Status : VARCHAR2(10)
        IxUPD_USER = 26, 	// Upd User : VARCHAR2(30)
        IxUPD_YMD = 27 	// Upd Ymd : DATE(7)
    }




	// item list
	public enum TBSBP_ITEM_LIST : int
	{
		IxITEM_NAME			= 1,
		IxSPEC_NAME			= 2,
		IxCOLOR_NAME		= 3,
		IxITEM_DIV_VALUE	= 4, 
		IxCUST_CD			= 5,
		IxCUST_NAME			= 6, 
		IxPUR_PRICE			= 7,
		IxPUR_CURRENCY		= 8, 
		IxOUTSIDE_PRICE		= 9,
		IxOUTSIDE_CURRENCY	= 10, 
		IxCBD_PRICE			= 11,
		IxCBD_CURRENCY		= 12, 
		IxUNIT				= 13, 
		IxCBM				= 14,
		IxWEIGHT			= 15, 
		IxREMARKS			= 16,
		IxFACTORY			= 17, 
		IxITEM_DIV_CD		= 18,
		IxITEM_CD			= 19, 
		IxSPEC_CD			= 20,
		IxCOLOR_CD			= 21,
		IxUPD_USER			= 22
	}



    // Purchase Order - Outside Calculaation Popup
    public enum TBSBP_OUTSIDE_INFO_2 : int
    {
        IxMaxCt = 24,			// 인덱스 Count
        IxLEVEL = 1, 			// Level : ()
        IxFACTORY = 2, 			// Factory : ()
        IxCHK = 3,				// check box
        IxITEM = 4, 			// Item : ()
        IxSEMI_GOOD_CD = 5, 	// Semi : ()
        IxCOMPONENT_CD = 6, 	// Component : ()
        IxYIELD_M = 7,			// yield
        IxPUR_PRICE = 8, 		// Price : ()
        IxPUR_CURRENCY = 9, 	// Currency : ()
        IxOUTSIDE_PRICE = 10, 	// Price : ()
        IxOUTSIDE_CURRENCY = 11, // Currency : ()
        IxCBD_PRICE = 12, 		// Price : ()
        IxCBD_CURRENCY = 13, 	// Currency : ()
        IxSUBTOTAL_PUR = 14, 	// Price : ()
        IxSUBTOTAL_CBD = 15, 	// Currency : ()
        IxTEMP1 = 16, 			// Temp1 : ()
        IxTEMP2 = 17, 			// Temp2 : ()
        IxSTYLE_CD = 18, 		// Style : ()
        IxTEMPLETE_LEVEL = 19, 	// Templete Level : ()
        IxITEM_DIVISION = 20, 	// Item Division : ()
        IxOBS_ID = 21, 			// Obs Id : ()
        IxITEM_CD = 22, 		// Obs Id : ()
        IxSPEC_CD = 23, 		// Obs Id : ()
        IxCOLOR_CD = 24 		// Obs Id : ()
    }



    // Purchase : SBP_PURCHASE_TAIL
    public enum TBSBP_PURCHASE_TAIL_2 : int
    {
        IxMaxCt = 46,	// 인덱스 Count
        IxLEVEL = 1, 	// Level : ()
        IxITEM_NAME = 2, 	// Style Code : ()
        IxSPEC_NAME = 3, 	// Style Name : ()
        IxCOLOR_NAME = 4, 	// Lot No : ()
        IxUNIT = 5, 	// Unit : ()
        IxSHIP_QTY = 6, 	// Ship Qty : NUMBER(22)
        IxREQ_QTY = 7, 	// Request : NUMBER(22)
        IxNEED_QTY = 8, 	// Nees : NUMBER(22)
        IxPUR_QTY = 9, 	// Purchase : NUMBER(22)
        IxIN_QTY = 10, 	// Incoming : NUMBER(22)
        IxPUR_PRICE = 11, 	// Price : NUMBER(22)
        IxPUR_CURRENCY = 12, 	// Currency : VARCHAR2(10)
        IxOUTSIDE_PRICE = 13, 	// Price : NUMBER(22)
        IxOUTSIDE_CURRENCY = 14, 	// Currency : VARCHAR2(10)
        IxCBD_PRICE = 15, 	// Price : NUMBER(22)
        IxCBD_CURRENCY = 16, 	// Currency : VARCHAR2(10)
        IxCUST_CD = 17, 	// Code : VARCHAR2(10)
        IxCUST_NAME = 18, 	// Name : ()
        IxPK_UNIT_QTY = 19, 	// P/K Qty : NUMBER(22)
        IxCBM = 20, 	// CBM : NUMBER(22)
        IxWEIGHT = 21, 	// Weight : NUMBER(22)
        IxRTA_YMD = 22, 	// RTA : VARCHAR2(8)
        IxETS_YMD1 = 23, 	// Date1 : VARCHAR2(8)
        IxETS_YMD2 = 24, 	// Date2 : VARCHAR2(8)
        IxETS_YMD3 = 25, 	// Date3 : VARCHAR2(8)
        IxREQ_NO = 26, 	// No : VARCHAR2(20)
        IxREQ_SEQ = 27, 	// Seq : NUMBER(22)
        IxOBS_ID = 28, 	// ID : VARCHAR2(6)
        IxOBS_TYPE = 29, 	// Type : VARCHAR2(2)
        IxOBS_YN = 30, 	// Y/N : VARCHAR2(1)
        IxPO_NO = 31, 	// PO No : VARCHAR2(8)
        IxLC_NO = 32, 	// L/C No : VARCHAR2(20)
        IxTAX_CD = 33, 	// Tax : VARCHAR2(10)
        IxPAY_CD = 34, 	// Pay : VARCHAR2(10)
        IxREQ_DEPT = 35, 	// Request Dept : VARCHAR2(10)
        IxPUR_DEPT = 36, 	// Purchase Dept : VARCHAR2(10)
        IxOFFER_NO = 37, 	// Offer No : VARCHAR2(20)
        IxYIELD_STATUS = 38, 	// Yield : VARCHAR2(1)
        IxPUR_STATUS = 39, 	// Purchase : VARCHAR2(1)
        IxREMARKS = 40, 	// Remarks : VARCHAR2(500)
        IxFACTORY = 41, 	// Factory : VARCHAR2(5)
        IxPUR_NO = 42, 	// Pur No : VARCHAR2(20)
        IxPUR_SEQ = 43, 	// Seq : NUMBER(22)
        IxITEM_CD = 44, 	// Item : VARCHAR2(10)
        IxSPEC_CD = 45, 	// Specification : VARCHAR2(5)
        IxCOLOR_CD = 46, 	// Color : VARCHAR2(5)
        IxGROUP_CD = 47 	// Color : VARCHAR2(5)
    }



    // seq : 3
    public enum TBSBM_SHIP_REQ_ITEM : int
    {
        IxMaxCt = 16,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : VARCHAR2(5)
        IxSHIP_NO = 2, 	// Ship No. : VARCHAR2(20)
        IxSTYLE_CD = 3, 	// 스타일코드 : VARCHAR2(9)
        IxSTYLE_NAME = 4, 	// 스타일명 : ()
        IxTOT_SHIP_QTY_STYLE = 5, 	// 선적수량(Style) : ()
        IxSHIPPING_YN = 6, 	//   : ()
        IxLOT_NO = 7, 	// Lot No : VARCHAR2(9)
        IxTOT_SHIP_QTY_LOT = 8, 	// 선적수량(Lot) : ()
        IxSIZE_ITEM_YN = 9, 	// 사이즈구분 : VARCHAR2(1)
        IxOBS_ID = 10, 	//   : VARCHAR2(6)
        IxOBS_TYPE = 11, 	//   : VARCHAR2(2)
        IxPUR_DIV = 12, 	// Division : VARCHAR2(10)
        IxSHIP_TYPE = 13, 	// Ship Type : ()
        IxEST_SHIP_YMD = 14, 	// Ship Date : ()
        IxUPD_USER = 15, 	//   : VARCHAR2(30)
        IxUPD_YMD = 16 	//   : DATE(7)
    }




	public enum TBSBP_IMPORT : int
	{
		IxMaxCt			= 25,	// 인덱스 Count
		IxFACTORY		= 1, 	//   : VARCHAR2(5)
		IxOFFER_NO		= 2, 	// 오퍼번호 : VARCHAR2(20)
		IxCATEGORY		= 3, 	// 카테고리 : 모델에 대한 유형 : VARCHAR2(30)
		IxMODEL_CD		= 4, 	//   : VARCHAR2(6)
		IxDEV_CODE		= 5, 	// 디벨로프코드 : VARCHAR2(30)
		IxPROD_CODE		= 6, 	// PROD_CODE : VARCHAR2(20)
		IxSEASON		= 7, 	// 시즌 : VARCHAR2(10)
		IxPURPOSE		= 8, 	//  : VARCHAR2(30)
		IxLC_NO			= 9, 	// LC No : VARCHAR2(30)
		IxINVOICE_NO	= 10, 	//  : VARCHAR2(30)
		IxIMP_COUNTRY	= 11, 	// 수입국가 : VARCHAR2(20)
		IxNIKE_DEV		= 12, 	//  : VARCHAR2(20)
		IxSE_DIV		= 13, 	//  : VARCHAR2(20)
		IxVIA			= 14, 	//  : VARCHAR2(30)
		IxAMOUNT_CD		= 15, 	//  : VARCHAR2(30)
		IxDHL_ACCOUNT	= 16, 	//  : VARCHAR2(15)
		IxRTA_BUSAN		= 17, 	//  : VARCHAR2(15)
		IxSPL_DDD		= 18, 	//  : VARCHAR2(20)
		IxHISTORY_NO	= 19, 	//  : VARCHAR2(15)
		IxREMARKS		= 20, 	// 비고 : VARCHAR2(500)
		IxSTATUS		= 21, 	// Status : VARCHAR2(10)
		IxSEND_CHK		= 22, 	// Send : VARCHAR2(10)
		IxSEND_YMD		= 23, 	// Send Date : DATE(7)
		IxUPD_YMD		= 24, 	// Date : DATE(7)
		IxUPD_USER		= 25 	// User : VARCHAR2(30)
	}



    public enum TBSBP_PUR_HEAD_LIST : int
    {
        IxMaxCt = 13,	// 인덱스 Count
        IxFACTORY = 1, 	//   : ()
        IxPUR_NO = 2, 	//   : ()
        IxPUR_USER = 3, 	//   : ()
        IxPUR_YMD = 4, 	//   : ()
        IxRTA_YMD = 5, 	//   : ()
        IxETS_YMD = 6, 	//   : ()
        IxPUR_DIV_CD = 7, 	//   : ()
        IxPUR_DIV = 8, 	//   : ()
        IxBUY_DIV_CD = 9, 	//   : ()
        IxBUY_DIV = 10, 	//   : ()
        IxPUR_STATUS = 11, 	//   : ()
        IxMRP_NO = 12, 	//   : ()
        IxREMARKS = 13 	//   : ()
    }



	public enum TBSBC_YIELD_REQ : int
	{
		IxMaxCt					= 22,	// 인덱스 Count
		IxLEVEL1				= 1, 	//   : ()
		IxKEY1					= 2, 	//   : ()
		IxTYPE_DIVISION			= 3, 	//   : ()
		IxCHK_APPLY				= 4, 	//   : ()
		IxTREE					= 5, 	//   : ()
		IxFACTORY				= 6, 	//   : ()
		IxTEMPLATE_SEQ			= 7, 	//   : ()
		IxTEMPLATE_LEVEL		= 8, 	//   : ()
		IxTEMPLATE_TREE_CD		= 9, 	//   : ()
		IxTEMPLATE_TREE_NAME	= 10, 	//   : ()
		IxTEMPLATE_CD			= 11, 	//   : ()
		IxITEM_CD				= 12, 	// 상품코드 : ()
		IxITEM_NAME				= 13, 	//   : ()
		IxSPEC_CD				= 14, 	// Spec : ()
		IxSPEC_NAME				= 15, 	//   : ()
		IxCOLOR_CD				= 16, 	// Color : ()
		IxCOLOR_NAME			= 17, 	//   : ()
		IxUNIT					= 18, 	//   : ()
		IxPROD_YN				= 19, 	//   : ()
		IxSEMI_GOOD_CD			= 20, 	//   : ()
		IxCOMPONENT_CD			= 21, 	//   : ()
		IxUNIT_NM				= 22 	//   : ()
	}



    // Purchase : SBP_PURCHASE_MANAGER
    public enum TBSBP_PURCHASE_MANAGER_3 : int
    {
        IxMaxCt = 51,	// 인덱스 Count
        IxLEVEL = 1, 	// Level : ()
        IxSHIP_TYPE = 2, 	// Ship Type : VARCHAR2(10)
        IxCHECK = 3, 	// Chk : ()
        IxITEM_NAME = 4, 	// Item : ()
        IxSPEC_NAME = 5, 	// Specification : ()
        IxCOLOR_NAME = 6, 	// Color : ()
        IxMANAGER_SEQ = 7, 	// Manager Seq : VARCHAR2(20)
        IxREQ_QTY = 8, 	// Request : NUMBER(22)
        IxPUR_QTY = 9, 	// Purchase : NUMBER(22)
        IxUNIT = 10, 	// Unit : ()
        IxSTATUS = 11, 	// Status : VARCHAR2(10)
        IxPUR_PRICE = 12, 	// Price : NUMBER(22)
        IxPUR_CURRENCY = 13, 	// Currency : VARCHAR2(3)
        IxCBD_PRICE = 14, 	// Price : NUMBER(22)
        IxCBD_CURRENCY = 15, 	// Currency : VARCHAR2(3)
        IxSHIP_PRICE = 16, 	// Price : NUMBER(22)
        IxSHIP_CURRENCY = 17, 	// Currency : VARCHAR2(3)
        IxPUR_USER = 18, 	// Pur User : VARCHAR2(30)
        IxCUST_CD = 19, 	// Code : VARCHAR2(6)
        IxCUST_NAME = 20, 	// Name : ()
        IxPRICE_YN = 21, 	// Price : VARCHAR2(1)
        IxSHIP_YN = 22, 	// Ship : VARCHAR2(1)
        IxPURCHASE_YN = 23, 	// Purchase : VARCHAR2(1)
        IxOUTSIDE_YN = 24, 	// Outside : VARCHAR2(1)
        IxLONG_YN = 25, 	// Long : VARCHAR2(1)
        IxDELIVERY_DAYS = 26, 	// Delivery : NUMBER(22)
        IxSTYLE_ITEM_DIV = 27, 	// Style Item : VARCHAR2(10)
        IxTRANSPORT_TYPE = 28, 	// Transport : VARCHAR2(10)
        IxMODEL_NAME = 29, 	// Model : VARCHAR2(100)
        IxPACKING = 30, 	// String : VARCHAR2(5)
        IxPK_NO = 31, 	// No : VARCHAR2(6)
        IxPK_NO_FROM = 32, 	// From : VARCHAR2(6)
        IxPK_NO_TO = 33, 	// To : VARCHAR2(6)
        IxPK_UNIT_QTY = 34, 	// Qty : NUMBER(22)
        IxCT_QTY = 35, 	// C/T : NUMBER(22)
        IxMRP_SHIP_NO = 36, 	// No : VARCHAR2(20)
        IxSHIP_SEQ = 37, 	// Seq : NUMBER(22)
        IxSHIP_YMD = 38, 	// Date : VARCHAR2(8)
        IxREQ_NO = 39, 	// No : VARCHAR2(20)
        IxREQ_SEQ = 40, 	// Seq : VARCHAR2(4)
        IxREQ_REASON = 41, 	// Reason : VARCHAR2(10)
        IxREQ_YMD = 42, 	// Date : VARCHAR2(8)
        IxOBS_ID = 43, 	// ID : VARCHAR2(6)
        IxOBS_TYPE = 44, 	// Type : VARCHAR2(2)
        IxPO_NO = 45, 	// PO No : VARCHAR2(8)
        IxPUR_NO = 46, 	// Pur No : VARCHAR2(20)
        IxPUR_SEQ = 47, 	// Seq : VARCHAR2(20)
        IxREMARKS = 48, 	// Remarks : VARCHAR2(500)
        IxITEM_CD = 49, 	// Item : VARCHAR2(10)
        IxSPEC_CD = 50, 	// Specification : VARCHAR2(5)
        IxCOLOR_CD = 51 	// Color : VARCHAR2(5)
    }



    	public enum TBSBP_REQ_HEAD_LIST : int
	{
		IxMaxCt			= 17,	// 인덱스 Count
		IxFACTORY		= 1, 	//   : ()
		IxREQ_NO		= 2, 	// 요청번호 : ()
		IxREQ_YMD		= 3, 	// Date : ()
		IxREQ_USER		= 4, 	// 요청사용자 : ()
		IxREQ_DEPT		= 5, 	// Request Part : ()
		IxUSE_DEPT		= 6, 	// 사용부서 : ()
		IxREQ_REASON	= 7, 	// 청구이유(SBB01) : ()
		IxRTA_YMD		= 8, 	// RTA : ()
		IxEST_YMD		= 9, 	//   : ()
		IxREMARKS		= 10, 	// 비고 : ()
		IxSTATUS		= 11, 	// Status : ()
		IxOFFER_YN		= 12, 	//   : ()
		IxOFFER_NO		= 13, 	// 오퍼번호 : ()
		IxSEND_CHK		= 14, 	// Send : ()
		IxSEND_YMD		= 15, 	// Send Date : ()
		IxUPD_USER		= 16, 	// User : ()
		IxUPD_YMD		= 17 	// Date : ()
	}



	public enum TBSBP_PURCHASE_DP_SIZE : int
	{
		IxMaxCt = 3,	// 인덱스 Count
		IxKIND = 1, 	//   : ()
		IxTOTAL = 2, 	//   : ()
		IxCOL = 3 	//   : ()
	}



    // Purchase : SBC_YIELD_INFO
    public enum TBSBC_YIELD_INFO_POP : int
    {
        IxMaxCt = 18,	// 인덱스 Count
        IxLEVEL = 1, 	//   : ()
        IxKEY = 2, 	//   : ()
        IxTYPE_DIVISION = 3, 	//   : ()
        IxCHECK_APPLY = 4, 	//   : ()
        IxTREE = 5, 	//   : ()
        IxSPEC_NAME = 6, 	//   : ()
        IxCOLOR_NAME = 7, 	//   : ()
        IxUNIT = 8, 	//   : ()
        IxCHECK_YN = 9, 	//   : ()
        IxFACTORY = 10, 	//   : ()
        IxSTYLE_CD = 11, 	//   : ()
        IxSEMI_GOOD_CD = 12, 	//   : ()
        IxCOMPONENT_CD = 13, 	//   : ()
        IxTEMPLATE_SEQ = 14, 	//   : ()
        IxTEMPLATE_LEVEL = 15, 	//   : ()
        IxITEM_CD = 16, 	//   : ()
        IxSPEC_CD = 17, 	//   : ()
        IxCOLOR_CD = 18 	//   : ()
    }



	public enum TBSBP_PURCHAES_REQUEST : int
	{ 
		IxFACTORY               = 1,
		IxREQ_NO                = 2,
		IxREQ_SEQ				= 3,
		IxITEM_NM				= 4,
		IxSPEC_NM				= 5,
		IxCOLOR_NM				= 6,
		IxUNIT_NM				= 7,
		IxREQ_QTY				= 8,
		IxPK_QTY				= 9,
		IxST_REQUEST_QD			= 10,
		IxST_MRP_REQUEST_QD		= 11,
		IxST_MRP_REQUEST		= 12,
		IxST_PURCHASE_MANAGER	= 13,
		IxST_PURCHASE			= 14,
		IxST_IN					= 15,
		IxST_OUT				= 16, 
		IxSTYLE_CD				= 17,
		IxMODEL_NAME			= 18,
		IxOBS_ID				= 19,
		IxOBS_TYPE				= 20,
		IxREQ_REASON			= 21,
		IxREMARKS				= 22,
		IxPUR_NO                = 23,
		IxPUR_SEQ				= 24, 
		IxRTA_YMD				= 25,
		IxETS1_YMD				= 26,
		IxETS2_YMD				= 27,
		IxLOT_NO				= 28,
		IxLOT_SEQ				= 29, 
		IxOFFER_YN				= 30,
		IxSEMI_GOOD_CD			= 31,
		IxCOMPONENT_CD			= 32,
		IxCOMPONENT_NAME		= 33,  
		IxCUST_CD				= 34,
		IxCUST_NAME				= 35,
		IxPUR_USER				= 36,
		IxBAR_CODE_REP			= 37,
		IxPK_NO					= 38,
		IxSCAN_IN_YMD			= 39,
		IxIN_LOCATION			= 40,
		IxIN_CONT_NO			= 41,
		IxSCAN_OUT_YMD			= 42,
		IxOUT_LOCATION			= 43,
		IxOUT_CONT_NO			= 44,
		IxOUT_TRANSPORT			= 45, 
		IxITEM_CD				= 46,
		IxSPEC_CD				= 47,
		IxCOLOR_CD				= 48,
	 
	}

    public enum TBSBP_REQUEST_EXCEL_UPLOAD : int
    {
        IxMaxCt = 9,		// 인덱스 Count
        IxITEM_CD = 1, 		//   : ()
        IxITEM_NAME = 2, 	//   : ()
        IxSPEC_CD = 3, 		//   : ()
        IxSPEC_NAME = 4, 	//   : ()
        IxCOLOR_CD = 5, 	//   : ()
        IxCOLOR_NAME = 6, 	//   : ()
        IxUNIT = 7, 	    //   : ()
        IxPK_QTY = 8, 	    //   : ()
        IxREQ_QTY = 9 		//   : ()
    }

    public enum TBSBM_PURCHAES_REQUEST_MRP_REQ : int
	{ 
		IxFACTORY               = 0,
		IxREQ_NO                = 1,
		IxREQ_SEQ				= 2, 
		IxITEM_CD				= 3,
		IxSPEC_CD				= 4,
		IxCOLOR_CD				= 5,
		Ixconfirm_qty		    = 6, 
		IxSTATUS                = 7,
	 
	} 




	public enum TBSBM_PURCHAES_REQUEST_PUR_MANAGER : int
	{ 
		IxFACTORY               = 0,
		IxREQ_NO                = 1,
		IxREQ_SEQ				= 2, 
		IxITEM_CD				= 3,
		IxSPEC_CD				= 4,
		IxCOLOR_CD				= 5,
		IxREQ_QTY				= 6, 
		IxSTATUS                = 7,
		IxPUR_NO                = 8,
		IxPUR_SEQ               = 9,
		IxCUST_CD               = 10,
		IxCUST_NAME             = 11, 
		IxPUR_USER              = 12,  
	 
	} 



	public enum TBSBM_PURCHAES_REQUEST_PUR : int
	{ 
		IxFACTORY               = 0,
		IxREQ_NO                = 1,
		IxREQ_SEQ				= 2, 
		IxITEM_CD				= 3,
		IxSPEC_CD				= 4,
		IxCOLOR_CD				= 5,
		IxREQ_QTY				= 6, 
		IxSTATUS                = 7,
		IxCUST_CD               = 8,
		IxCUST_NAME             = 9, 
		IxETS_YMD1              = 10,  
		IxETS_YMD2              = 11, 
	 
	}  




	public enum TBSBM_PURCHAES_REQUEST_STATUS_IN : int
	{ 
		IxBAR_CODE_REP          = 0,
		IxPACKING               = 1,
		IxPK_NO_FROM			= 2, 
		IxPK_NO_TO				= 3,
		IxSCAN_IN_YMD			= 4,
		IxLOCATION				= 5,
		IxCONT_NO				= 6, 
		IxSCAN_IN_STATE         = 7, 
	 
	} 



	public enum TBSBM_PURCHAES_REQUEST_STATUS_OUT : int
	{ 
		IxBAR_CODE_REP          = 0,
		IxPACKING               = 1,
		IxPK_NO_FROM			= 2, 
		IxPK_NO_TO				= 3,
		IxSCAN_OUT_YMD			= 4,
		IxLOCATION				= 5,
		IxCONT_NO				= 6, 
		IxSCAN_OUT_STATE        = 7, 
		IxBAR_MOVE				= 8, 
	 
	}





    public enum TBSBP_REQUEST_TAIL : int
    {
        IxMaxCt = 31,	// 인덱스 Count
        IxSEQ = 1, 	// Seq : ()
        IxFACTORY = 2, 	// Factory : VARCHAR2(5)
        IxREQ_NO = 3, 	// No : VARCHAR2(20)
        IxREQ_SEQ = 4, 	// Seq : NUMBER(22)
        IxITEM_NM = 5, 	// Item : ()
        IxSPEC_NM = 6, 	// Specifition : ()
        IxCOLOR_NM = 7, 	// Color : ()
        IxUNIT_NM = 8, 	// Unit : ()
        IxREQ_QTY = 9, 	// Request Qty : NUMBER(22)
        IxPK_QTY = 10, 	// Pk Qty : ()
        IxRTA_YMD = 11, 	// RTA : VARCHAR2(8)
        IxETS1_YMD = 12, 	// ETS 1st : VARCHAR2(8)
        IxETS2_YMD = 13, 	// ETS 2nd : VARCHAR2(8)
        IxLOT_NO = 14, 	// No : VARCHAR2(9)
        IxLOT_SEQ = 15, 	// Seq : VARCHAR2(2)
        IxSTYLE_CD = 16, 	// Style Code : VARCHAR2(9)
        IxMODEL_NAME = 17, 	// Style Name : VARCHAR2(100)
        IxOBS_ID = 18, 	// Id : VARCHAR2(6)
        IxOBS_TYPE = 19, 	// Type : VARCHAR2(2)
        IxOFFER_YN = 20, 	// Offer Y/N : ()
        IxITEM_CD = 21, 	// Item Code : VARCHAR2(10)
        IxSPEC_CD = 22, 	// Spec Code : VARCHAR2(5)
        IxCOLOR_CD = 23, 	// Color Code : VARCHAR2(5)
        IxSEMI_GOOD_CD = 24, 	// Semi Good Cd : VARCHAR2(10)
        IxCOMPONENT_CD = 25, 	// Component Cd : VARCHAR2(20)
        IxCOMPONENT_NAME = 26, 	// Component Name : ()
        IxREQ_REASON = 27, 	// Reason : VARCHAR2(10)
        IxREMARKS = 28, 	// Remarks : VARCHAR2(500)
        IxSTATUS = 29, 	// Status : VARCHAR2(10)
        IxUPD_USER = 30, 	// Upd User : VARCHAR2(30)
        IxUPD_YMD = 31 	// Upd Ymd : DATE(7)
    }



    // PURCHASE : SBP_REQUEST_TAIL (Form_BP_Request_Tail)
    public enum TBSBP_REQUEST_TAIL_2 : int
    {
        IxMaxCt = 30,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : VARCHAR2(5)
        IxREQ_NO = 2, 	// No : VARCHAR2(20)
        IxREQ_SEQ = 3, 	// Seq : NUMBER(22)
        IxITEM_NM = 4, 	// Item : ()
        IxSPEC_NM = 5, 	// Specifition : ()
        IxCOLOR_NM = 6, 	// Color : ()
        IxUNIT_NM = 7, 	// Unit : ()
        IxREQ_QTY = 8, 	// Request Qty : NUMBER(22)
        IxUSE_DIVIDE = 9, 	// Use : VARCHAR2(1)
        IxREQ_REASON = 10, 	// Reason : VARCHAR2(10)
        IxTRANSPORT_TYPE = 11, 	// Transport : VARCHAR2(10)
        IxUSE_JOB_YN = 12, 	// Use : VARCHAR2(1)
        IxRTA_YMD = 13, 	// RTA : VARCHAR2(8)
        IxETS1_YMD = 14, 	// ETS 1st : VARCHAR2(8)
        IxETS2_YMD = 15, 	// ETS 2nd : VARCHAR2(8)
        IxLOT_NO = 16, 	// No : VARCHAR2(9)
        IxLOT_SEQ = 17, 	// Seq : VARCHAR2(2)
        IxSTYLE_CD = 18, 	// Style Code : VARCHAR2(9)
        IxMODEL_NAME = 19, 	// Model : VARCHAR2(100)
        IxOBS_ID = 20, 	// Id : VARCHAR2(6)
        IxOBS_TYPE = 21, 	// Type : VARCHAR2(2)
        IxOFFER_YN = 22, 	// Offer Y/N : ()
        IxSTATUS = 23, 	// Status : VARCHAR2(10)
        IxITEM_CD = 24, 	// Item Code : VARCHAR2(10)
        IxSPEC_CD = 25, 	// Spec Code : VARCHAR2(5)
        IxCOLOR_CD = 26, 	// Color Code : VARCHAR2(5)
        IxSEMI_GOOD_CD = 27, 	// Semi Good Cd : VARCHAR2(10)
        IxCOMPONENT_CD = 28, 	// Component Cd : VARCHAR2(15)
        IxUPD_USER = 29, 	// Upd User : VARCHAR2(30)
        IxUPD_YMD = 30 	// Upd Ymd : DATE(7)
    }




    #endregion

    #region 선적


    public enum TBSBC_CONTAINER : int
    {
        IxMaxCt = 8,		// 인덱스 Count
        IxCONT_NO = 1, 		// 컨테이너번호 : VARCHAR2(20)
        IxCONT_UNIT = 2, 	// 컨테이너유닛 : VARCHAR2(4)
        IxUSE_YN = 3, 		// 사용여부 : VARCHAR2(1)
        IxREMARKS = 4, 		// 비고 : VARCHAR2(500)
        IxSEND_CHK = 5, 	// 송신체크 : VARCHAR2(10)
        IxSEND_YMD = 6, 	// 송신일 : DATE(7)
        IxUPD_USER = 7, 	// 수정자 : VARCHAR2(30)
        IxUPD_YMD = 8 		// 수정일자 : DATE(7)
    }



    /// <summary> 
    /// SBC_CBD_MASTER 테이블 인덱스 Enum 
    /// </summary> 
    public enum TBSBC_CBD_MASTER : int
    {
        IxMaxCt = 30,	// 인덱스 Count
        IxFACTORY = 1,
        IxOBS_ID = 2,
        IxSTYLE_CD = 3,
        IxSTYLE_NAME = 4,
        IxGROUP_NAME = 5,
        IxITEM_CD = 6,
        IxITEM_NAME = 7,
        IxSPEC_CD = 8,
        IxSPEC_NAME = 9,
        IxCOLOR_CD = 10,
        IxCOLOR_NAME = 11,
        IxPUR_CURRENCY = 12,
        IxPUR_PRICE = 13,
        IxCBD_CURRENCY = 14,
        IxCBD_PRICE = 15,
        IxOUTSIDE_CURRENCY = 16,
        IxOUTSIDE_PRICE = 17,
        IxOUTSIDE_CBD_CURRENCY = 18,
        IxOUTSIDE_CBD_PRICE = 19,
        IxSHIP_CURRENCY = 20,
        IxSHIP_PRICE = 21,
        IxPUR_USER = 22,
        IxPK_UNIT_QTY = 23,
        IxUNIT = 24,
        IxIMPORT = 25,
        IxCBM = 26,
        IxWEIGHT = 27,
        IxCUST_CD = 28,
        IxCUST_NAME = 29,
        IxLAST_DATE = 30,
        IxREMARKS = 31,
        IxSEND_CHK = 32,
        IxSEND_YMD = 33,
        IxUPD_USER = 34,
        IxUPD_YMD = 35

    }




    public enum TBSBS_SHIPPING_HEAD : int
    {
        IxMaxCt = 19,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : VARCHAR2(5)
        IxSHIP_NO = 2, 	// Ship No : VARCHAR2(20)
        IxSTYLE_CD = 3, 	// Style : VARCHAR2(9)
        IxSTYLE_NAME = 4, 	// Style Name : ()
        IxLOT_NO = 5, 	// No : VARCHAR2(9)
        IxLOT_SEQ = 6, 	// Seq : VARCHAR2(2)
        IxOBS_TYPE = 7, 	// OBS Type : VARCHAR2(2)
        IxPLAN_QTY = 8, 	// Plan : NUMBER(22)
        IxSHIP_QTY = 9, 	// Ship : NUMBER(22)
        IxSHIP_YMD = 10, 	// Ship Date : VARCHAR2(8)
        IxSHIP_DIVISION = 11, 	// Div : VARCHAR2(10)
        IxSHIP_TYPE = 12, 	// Ship Type : VARCHAR2(10)
        IxSIZE_ITEM_YN = 13, 	// Size : VARCHAR2(10)
        IxPACKING = 14, 	// Packing : VARCHAR2(4)
        IxBARCODE_YN = 15, 	// Barcode Y/N : VARCHAR2(1)
        IxTRADE_YN = 16, 	// Trade Y/N : VARCHAR2(1)
        IxTRADE_SC = 17, 	// Trade SC : VARCHAR2(12)
        IxSTATUS = 18, 	// Status : VARCHAR2(1)
        IxREMARKS = 19 	// Remarks : VARCHAR2(500)
    } 




    // SHIPPING TAIL
    public enum TBSBS_SHIPPING_TAIL : int
    {
        IxMaxCt = 39,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : VARCHAR2(5)
        IxSHIP_NO = 2, 	// Ship No : VARCHAR2(20)
        IxSHIP_SEQ = 3, 	// Seq : VARCHAR2(4)
        IxINDEX = 4, 	//   : ()
        IxPK_NO = 5, 	// P/K No : ()
        IxCT_QTY = 6, 	// C/T : NUMBER(22)
        IxITEM = 7, 	// Item : ()
        IxSPEC = 8, 	// Spec : ()
        IxCOLOR = 9, 	// Color : ()
        IxPUR_QTY = 10, 	// Purchase : NUMBER(22)
        IxSHIP_QTY = 11, 	// Ship : NUMBER(22)
        IxUNIT = 12, 	// Unit : ()
        IxPK_UNIT_QTY = 13, 	// P/K Qty : NUMBER(22)
        IxPUR_PRICE = 14, 	// Price : NUMBER(22)
        IxPUR_CURRENCY = 15, 	// Currency : VARCHAR2(3)
        IxCBD_PRICE = 16, 	// Price : NUMBER(22)
        IxCBD_CURRENCY = 17, 	// Currency : VARCHAR2(3)
        IxSHIP_PRICE = 18, 	// Price : NUMBER(22)
        IxSHIP_CURRENCY = 19, 	// Currency : VARCHAR2(3)
        IxPRICE_YN = 20, 	// Price Y/N : VARCHAR2(1)
        IxPUR_USER = 21, 	// User : VARCHAR2(30)
        IxCUST_CD = 22, 	// Name : VARCHAR2(6)
        IxVENDOR = 23, 	// Code : ()
        IxLOCK_YN = 24, 	// Lock Y/N : VARCHAR2(1)
        IxIMPORT_YN = 25, 	// Import Y/N : VARCHAR2(1)
        IxSHIP_YN = 26, 	// Ship Y/N : VARCHAR2(1)
        IxOUTSIDE_YN = 27, 	// Outside Y/N : VARCHAR2(1)
        IxSTATUS = 28, 	// Status : VARCHAR2(1)
        IxREMARKS = 29, 	// Remarks : VARCHAR2(500)
        IxPK_NO_FROM = 30, 	//   : VARCHAR2(6)
        IxPK_NO_TO = 31, 	//   : VARCHAR2(6)
        IxITEM_CD = 32, 	//   : VARCHAR2(10)
        IxSPEC_CD = 33, 	//   : VARCHAR2(5)
        IxCOLOR_CD = 34, 	//   : VARCHAR2(5)
        IxSEND_CHK = 35, 	//   : VARCHAR2(10)
        IxSEND_YMD = 36, 	//   : DATE(7)
        IxUPD_USER = 37, 	//   : VARCHAR2(30)
        IxUPD_YMD = 38, 	//   : DATE(7)
        IxKEY1 = 39 	//   : ()
    }



    public enum TBSBS_BAR_1 : int
    {
        IxMaxCt = 32,	// 인덱스 Count
        IxLEV = 1, 	// LEV : ()
        IxCHK = 2, 	// C : ()
        IxPK_NO = 3, 	// P/K No : VARCHAR2(6)
        IxCT = 4, 	// C/T : ()
        IxSTYLE_CD = 5, 	// Style Code : VARCHAR2(9)
        IxITEM = 6, 	// Item : ()
        IxSPEC = 7, 	// Specification : ()
        IxCOLOR = 8, 	// Color : ()
        IxSHIP_QTY = 9, 	// Ship : NUMBER(22)
        IxSCAN_QTY = 10, 	// Scan : ()
        IxWEIGHT = 11, 	// Weight : ()
        IxUNIT = 12, 	// Unit : ()
        IxOBS_ID = 13, 	// Dpo : ()
        IxSHIP_YMD = 14, 	// Ship Date : VARCHAR2(8)
        IxSCAN_YMD = 15, 	// Scan Date : ()
        IxIN_STATE = 16, 	// In : ()
        IxOUT_STATE = 17, 	// Out : ()
        IxLOCATION = 18, 	// Location : ()
        IxCONTAINER = 19, 	// Container : ()
        IxVENDOR = 20, 	// Vendor : ()
        IxBAR_CODE = 21, 	// Barcode : VARCHAR2(24)
        IxBAR_SEQ = 22, 	// Seq : ()
        IxBAR_CODE_REP = 23, 	// Barcode Rep : VARCHAR2(24)
        IxTYPE = 24, 	// Type : ()
        IxSTYLE_NAME = 25, 	// Style Name : ()
        IxCUST_CD = 26, 	// Cust Code : VARCHAR2(10)
        IxTYPE_CD = 27, 	// Type Code : ()
        IxITEM_CD = 28, 	// Item Code : VARCHAR2(10)
        IxSPEC_CD = 29, 	// Spec Code : VARCHAR2(5)
        IxCOLOR_CD = 30, 	// Color Code : VARCHAR2(5)
        IxUPD_USER = 31, 	// User : VARCHAR2(30)
        IxUPD_YMD = 32 	// Outside : DATE(7)
    }



    // Shipping List for Invoice
    public enum TBSBS_BAR_2 : int
    {
        IxMaxCt = 33,	// 인덱스 Count
        IxPK_NO = 1, 	// PK No : VARCHAR2(6)
        IxCT_QTY = 2, 	// C/T : NUMBER(22)
        IxSTYLE_CD = 3, 	// Code : VARCHAR2(9)
        IxSTYLE_NAME = 4, 	// Name : ()
        IxPLAN_QTY = 5, 	// Plan : ()
        IxITEM_NAME = 6, 	// Item : ()
        IxSPEC_NAME = 7, 	// Specification : ()
        IxCOLOR_NAME = 8, 	// Color : ()
        IxPUR_QTY = 9, 	// Pur : NUMBER(22)
        IxSHIP_QTY = 10, 	// Shipping : NUMBER(22)
        IxUNIT = 11, 	// Unit : ()
        IxPK_UNIT_QTY = 12, 	// P/K : NUMBER(22)
        IxPUR_PRICE = 13, 	// Price : NUMBER(22)
        IxPUR_CURRENCY = 14, 	// Currency : VARCHAR2(3)
        IxCBD_PRICE = 15, 	// Price : NUMBER(22)
        IxCBD_CURRENCY = 16, 	// Currency : VARCHAR2(3)
        IxSHIP_PRICE = 17, 	// Price : NUMBER(22)
        IxSHIP_CURRENCY = 18, 	// Currency : VARCHAR2(3)
        IxWEIGHT = 19, 	// Weight : ()
        IxVENDER_CD = 20, 	// Code : ()
        IxVENDER_NAME = 21, 	// Name : ()
        IxPRICE_YN = 22, 	// Price : VARCHAR2(1)
        IxSHIP_NO = 23, 	// Ship No : VARCHAR2(20)
        IxPUR_DIV = 24, 	// Pur Div : ()
        IxBARCODE = 25, 	// Barcode : ()
        IxBAR_SEQ = 26, 	// Bar Seq : ()
        IxUSER = 27, 	// User : ()
        IxSTATUS = 28, 	// Status : VARCHAR2(1)
        IxITEM_CD = 29, 	// Item : VARCHAR2(10)
        IxSPEC_CD = 30, 	// Spec : VARCHAR2(5)
        IxCOLOR_CD = 31, 	// Color : VARCHAR2(5)
        IxUPD_USER = 32, 	// Upd User : VARCHAR2(30)
        IxUPD_YMD = 33 	// Outside : DATE(7)
    }




    public enum TBSBC_YIELD_INFO_SHIPPING : int
    {
        IxMaxCt = 35,	// 인덱스 Count
        IxLEVEL1 = 1, 	//   : ()
        IxKEY1 = 2, 	//   : ()
        IxTYPE_DIVISION = 3, 	//   : ()
        IxSHIP_YN = 4, 	//   : VARCHAR2(1)
        IxPUR_SHIP_YN = 5, 	//   : VARCHAR2(1)
        IxPROD_YN = 6, 	//   : VARCHAR2(1)
        IxCOMMON_YN = 7, 	//   : VARCHAR2(1)
        IxIMPORT_YN = 8, 	//   : ()
        IxLOCAL_YN = 9, 	//   : ()
        IxITEM = 10, 	//   : ()
        IxFACTORY = 11, 	//   : VARCHAR2(5)
        IxSTYLE_CD = 12, 	//   : VARCHAR2(9)
        IxSEMI_GOOD_CD = 13, 	//   : VARCHAR2(10)
        IxCOMPONENT_CD = 14, 	//   : VARCHAR2(20)
        IxCOMPONENT_NAME = 15, 	//   : ()
        IxTEMPLATE_SEQ = 16, 	//   : NUMBER(22)
        IxTEMPLATE_LEVEL = 17, 	//   : NUMBER(22)
        IxSPEC_CD = 18, 	//   : VARCHAR2(5)
        IxSPEC_NAME = 19, 	//   : ()
        IxCOLOR_CD = 20, 	//   : VARCHAR2(5)
        IxCOLOR_NAME = 21, 	//   : ()
        IxITEM_CD = 22, 	//   : VARCHAR2(10)
        IxUNIT = 23, 	//   : ()
        IxSTYLE_ITEM_DIV = 24, 	//   : VARCHAR2(10)
        IxPROD_SEMI_GOOD_CD = 25, 	//   : VARCHAR2(10)
        IxPROD_OP_CD = 26, 	//   : VARCHAR2(10)
        IxPROD_LOSS_RATE = 27, 	//   : NUMBER(22)
        IxSEND_CHK = 28, 	//   : VARCHAR2(10)
        IxSEND_DATE = 29, 	//   : ()
        IxUPD_USER = 30, 	//   : VARCHAR2(30)
        IxIMPORT_DIV = 31, 	//   : ()
        IxDELIVERY_YN = 32, 	//   : ()
        IxSIZE_YN = 33, 	//   : ()
        IxSIZE_GROUP_COUNT = 34, 	//   : ()
        IxUPD_YMD = 35 	//   : DATE(7)
    }



    public enum TBSBS_SHIP_CONTAINER : int
    {
        IxMaxCt = 14,		// 인덱스 Count
        IxSHIP_YMD = 1, 	// 선적일 : VARCHAR2(8)
        IxSHIP_FACT = 2, 	// 선적공장 : VARCHAR2(5)
        IxSHIP_SEQ = 3, 	// Seq : NUMBER(22)
        IxCONT_NO = 4, 		// 컨테이너번호 : VARCHAR2(20)
        IxCONT_UNIT = 5, 	// 컨테이너유닛 : VARCHAR2(4)
        IxSEAL_NO = 6, 		//   : VARCHAR2(10)
        IxCONT_DESC = 7, 	//   : VARCHAR2(60)
        IxREMARKS = 8, 		// 비고 : VARCHAR2(500)
        IxOUT_YMD = 9, 		// 출고일 : VARCHAR2(8)
        IxRTA_YMD = 10, 	// RTA : VARCHAR2(8)
        IxSEND_CHK = 11, 	// 송신체크 : VARCHAR2(10)
        IxSEND_YMD = 12, 	// 송신일 : DATE(7)
        IxUPD_USER = 13, 	// 수정자 : VARCHAR2(30)
        IxUPD_YMD = 14 		// 수정일자 : DATE(7)
    }



    public enum TBSBS_SHIPPING_HEAD_TRADE : int
    {
        IxCHECK_FLAG = 1,
        IxFACTORY = 2,
        IxSHIP_NO = 3,
        IxSTYLE_CD = 4,
        IxMODEL = 5,
        IxPACKING = 6,
        IxGENDER = 7,
        IxOBS_ID = 8,
        IxOBS_TYPE = 9,
        IxPLAN_QTY = 10,
        IxSHIP_QTY = 11,
        IxITEM_DIVISION = 12,
        IxSTATUS = 13,
        IxSHIP_TYPE = 14,
        IxREQ_REASON = 15,
    }



    public enum TBSB_REPORT_MRP_TO_SL : int
    {
        IxMaxCt = 23,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : ()
        IxSHIP_TYPE = 2, 	// Ship Type : ()
        IxMRP_SHIP_NO = 3, 	// MRP Ship No : ()
        IxOBS_TYPE = 4, 	// Order Type : ()
        IxLOT_NO = 5, 	// No : ()
        IxLOT_SEQ = 6, 	// Seq : ()
        IxSTYLE_CD = 7, 	// Code : ()
        IxSTYLE_NAME = 8, 	// Name : ()
        IxSHIPPING_SCHEDULE = 9, 	// Shipping Schedule : ()
        IxMRP_RUN = 10, 	// Run : ()
        IxMRP_MODIFY = 11, 	// Modify : ()
        IxMRP_SEND = 12, 	// Send : ()
        IxDS_SHIPPING_SCHEDULE = 13, 	// Shipping Schedule : ()
        IxDS_MRP_RECEIVE = 14, 	// MRP Receive : ()
        IxDS_MRP_MODIFY = 15, 	// MRP Modify : ()
        IxDS_PURCHASE_MANAGER = 16, 	// Manager Receive : ()
        IxDS_PURCHASE_ORDER_RECEIVE = 17, 	// Order Receive : ()
        IxDS_PURCHASE_ORDER_MODIFY = 18, 	// Order Modify : ()
        IxDS_SHIPPING_LIST_CREATE = 19, 	// Shipping List Create : ()
        IxDS_SHIPPING_LIST_MODIFY = 20, 	// Shipping List Modify : ()
        IxDS_BAR_CODE = 21, 	// Barcode Create : ()
        IxUPD_USER = 22, 	// Upd User : ()
        IxUPD_YMD = 23 	// Upd Ymd : ()
    }



	// SHIPPING EXPORT
	public enum TBSBS_SHIPPING_EXPORT : int
	{
		IxCHK        = 1, 	
		IxFACTORY    = 2, 	
		IxSHIP_NO    = 3, 	
		IxSHIP_YMD   = 4, 	
		IxDIVISION   = 5, 	
		IxPACKING    = 6, 	
		IxMRP_NO     = 7, 	
		IxREMARKS    = 8, 	
		IxUPD_USER   = 9 
	}



    public enum TBSBS_NO_SHIPPING : int
    {
        IxMaxCt = 31,	// 인덱스 Count
        IxLEV = 1, 	// LEV : ()
        IxPK_NO = 2, 	// PK No : VARCHAR2(6)
        IxCT = 3, 	// C/T : ()
        IxSTYLE_CD = 4, 	// Code : VARCHAR2(9)
        IxSTYLE_NAME = 5, 	// Name : ()
        IxITEM = 6, 	// Item : ()
        IxSPEC = 7, 	// Specification : ()
        IxCOLOR = 8, 	// Color : ()
        IxSHIP_QTY = 9, 	// Ship : NUMBER(22)
        IxSCAN_QTY = 10, 	// Scan : ()
        IxUNIT = 11, 	// Unit : ()
        IxSCAN_YMD = 12, 	// Scan Date : ()
        IxSTATE = 13, 	// State : ()
        IxLOCATION = 14, 	// Location : ()
        IxCONTAINER = 15, 	// Container : ()
        IxCUST_CD = 16, 	// Cust Code : VARCHAR2(6)
        IxVENDOR = 17, 	// Vendor : ()
        IxBAR_CODE = 18, 	// Barcode : VARCHAR2(24)
        IxBAR_SEQ = 19, 	// Seq : ()
        IxBAR_CODE_REP = 20, 	// Barcode Rep : VARCHAR2(24)
        IxTYPE = 21, 	// Type : ()
        IxTYPE_CD = 22, 	// Type Code : ()
        IxITEM_CD = 23, 	// Item Code : VARCHAR2(10)
        IxSPEC_CD = 24, 	// Spec Code : VARCHAR2(5)
        IxCOLOR_CD = 25, 	// Color Code : VARCHAR2(5)
        IxVIRGIN_YN = 26, 	// Virgin : VARCHAR2(1)
        IxVIRGIN_REASON = 27, 	// Reason : VARCHAR2(10)
        IxVIRGIN_REASON_CD = 28, 	// Reason Code : ()
        IxREMARKS = 29, 	// Remarks : VARCHAR2(500)
        IxUPD_USER = 30, 	// User : VARCHAR2(30)
        IxUPD_YMD = 31 	// Date : DATE(7)
    }



    public enum TBSBM_MRP_INFO_TEST : int
    {
        IxMaxCt = 20,	// 인덱스 Count 
        IxFACTORY = 1,
        IxSHIP_TYPE = 2,
        IxMRP_SHIP_NO = 3,
        IxSTYLE_CD = 4,
        IxSTYLE_NAME = 5,
        IxSTYLE_QTY = 6,
        IxLOT_QTY = 7,
        IxSHIP_YN = 8,
        IxYIELD_COUNT = 9,
        IxSHIPPING_COUNT_UPPER = 10,
        IxSHIPPING_COUNT_BUTTOM = 11,
        IxSHIPPING_COUNT_OTHER = 12,
        IxLOT_NO = 13,
        IxLOT_SEQ = 14,
        IxOBS_ID = 15,
        IxOBS_TYPE = 16,
        IxSTYLE_ITEM_DIV = 17,
        IxREQUEST_REASON = 18,
        IxMOVE_TYPE = 19,
        IxATTRIBUTE = 20,
        IxCBD_CHECK = 21
    }



    // Shipping Request
    public enum TBSBS_SHIPPING_REQUEST : int
    {
        IxMaxCt = 35,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : ()
        IxSHIP_NO = 2, 	// Ship No : ()
        IxSHIP_SEQ = 3, 	// Seq : ()
        IxINDEX = 4, 	// Seq : ()
        IxPK_NO = 5, 	// P/K No : ()
        IxCT_QTY = 6, 	// C/T : ()
        IxITEM = 7, 	// Item : ()
        IxSPEC = 8, 	// Specification : ()
        IxCOLOR = 9, 	// Color : ()
        IxSHIP_QTY = 10, 	// Q'ty : ()
        IxUNIT = 11, 	// Unit : ()
        IxMODEL = 12, 	// Model : ()
        IxSTYLE_CD = 13, 	// Code : ()
        IxSTYLE = 14, 	// Name : ()
        IxPK_UNIT_QTY = 15, 	// P/K Qty : ()
        IxPUR_PRICE = 16, 	// Price : ()
        IxPUR_CURRENCY = 17, 	// Currency : ()
        IxCBD_PRICE = 18, 	// Price : ()
        IxCBD_CURRENCY = 19, 	// Currency : ()
        IxPRICE_YN = 20, 	// Price Y/N : ()
        IxPUR_USER = 21, 	// User : ()
        IxCUST_CD = 22, 	// Code : ()
        IxVENDOR = 23, 	// Name : ()
        IxSHIP_YN = 24, 	// Ship Y/N : ()
        IxREQUEST_REASON = 25, 	// Reqeust Reason : ()
        IxSTATUS = 26, 	// Status : ()
        IxREMARKS = 27, 	// Remarks : ()
        IxPK_NO_FROM = 28, 	// p/k from : ()
        IxPK_NO_TO = 29, 	// p/k to : ()
        IxITEM_CD = 30, 	//   : ()
        IxSPEC_CD = 31, 	//   : ()
        IxCOLOR_CD = 32, 	//   : ()
        IxATTRIBUTE = 33, 	//   : ()
        IxUPD_USER = 34, 	//   : ()
        IxUPD_YMD = 35 	//   : ()
    }




    // Shipping Request Search
    public enum TBSBS_SHIPPING_REQUEST_SEARCH : int
    {


        IxFACTORY = 1,
        IxSHIP_YMD = 2,
        IxSHIP_NO = 3,
        IxSHIP_SEQ = 4,
        IxITEM_NAME = 5,
        IxSPEC_NAME = 6,
        IxCOLOR_NAME = 7,
        IxSHIP_QTY = 8,
        IxMNG_UNIT = 9,
        IxPACKING = 10,
        IxCT_QTY = 11,
        IxPK_UNIT_QTY = 12,
        IxPUR_PRICE = 13,
        IxPUR_CURRENCY = 14,
        IxCBD_PRICE = 15,
        IxCBD_CURRENCY = 16,
        IxSTYLE_CD = 17,
        IxSTYLE_NAME = 18,
        IxPRICE_YN = 19,
        IxSHIP_YN = 20,
        IxPUR_USER = 21,
        IxCUST_CD = 22,
        IxCUST_NAME = 23,
        IxREQUEST_REASON = 24,
        IxSTATUS = 25,
        IxREMARKS = 26,
        IxPK_NO_FROM = 27,
        IxPK_NO_TO = 28,
        IxATTRIBUTE = 29,
        IxITEM_CD = 30,
        IxSPEC_CD = 31,
        IxCOLOR_CD = 32,


    }  



    #endregion
    
    #region 재고


	public enum TBSBK_STOCK_CLOSE_INOUT : int
	{ 
 
		IxREAL_INOUT_YMD = 1,
		IxINOUT_YMD      = 2,
		IxINOUT_QTY      = 3,
		IxINOUT_STATUS   = 4,
		IxINOUT_NO       = 5,
		IxINOUT_SEQ		 = 6,
		IxITEM_CD		 = 7,
		IxSPEC_CD        = 8,
		IxCOLOR_CD       = 9,
		IxITEM_NAME      = 10,
		IxSPEC_NAME      = 11,
		IxCOLOR_NAME     = 12,


	}



    public enum TBSBK_REMAINDER : int
    {

        IxFACTORY = 1,
        IxWORK_YMD = 2,
        IxLINE_CD = 3,
        IxOP_CD = 4,
        IxITEM_NAME = 5,
        IxSPEC_NAME = 6,
        IxCOLOR_NAME = 7,
        IxINIT_QTY = 8,
        IxREMAINDER_QTY = 9,
        IxADJUST_QTY = 10,
        IxSTOCK_QTY = 11,
        IxMNG_UNIT = 12,
        IxADJUST_REASON = 13,
        IxSTATUS = 14,
        IxREMARKS = 15,
        IxITEM_CD = 16,
        IxSPEC_CD = 17,
        IxCOLOR_CD = 18,
        IxUPD_USER = 19,
        IxUPD_YMD = 20,
        IxOUT_STATUS = 21,

    }



    public enum TBSBK_OUTSIDE_STOCK_10 : int
    {
        IxFACTORY = 1,
        IxPACKING = 2,
        IxITEM_NAME = 3,
        IxSPEC_NAME = 4,
        IxCOLOR_NAME = 5,
        IxUNIT = 6,
        IxSTYLE_CD = 7,
        IxSTYLE_NAME = 8,
        IxCUST_CD = 9,
        IxCUST_NAME = 10,
        IxOUT_QTY = 11,
        IxOUT_YMD = 12,
        IxOUT_STATUS = 13,
        IxDEST_CUST_CD = 14,
        IxDEST_CUST_NAME = 15,
        IxIN_QTY = 16,
        IxIN_YMD = 17,
        IxIN_STATUS = 18,
        IxPUR_PRICE = 19,
        IxPUR_CURRENCY = 20,
        IxCBD_PRICE = 21,
        IxCBD_CURRENCY = 22,
        IxBAR_CODE_REP = 23,
        IxREMARKS = 24,
        IxITEM_CD = 25,
        IxSPEC_CD = 26,
        IxCOLOR_CD = 27,
        IxSTATUS = 28,
        IxUPD_USER = 29,
        IxUPD_YMD = 30
    }

    public enum TBSBK_OUTSIDE_STOCK_20 : int
    {
        IxFACTORY = 1,
        IxPACKING = 2,
        IxITEM_NAME = 3,
        IxSPEC_NAME = 4,
        IxCOLOR_NAME = 5,
        IxUNIT = 6,
        IxSTYLE_CD = 7,
        IxSTYLE_NAME = 8,
        IxCUST_CD = 9,
        IxCUST_NAME = 10,
        IxOUT_QTY = 11,
        IxOUT_YMD = 12,
        IxOUT_STATUS = 13,
        IxPUR_PRICE = 14,
        IxPUR_CURRENCY = 15,
        IxCBD_PRICE = 16,
        IxCBD_CURRENCY = 17,
        IxBAR_CODE_REP = 18,
        IxREMARKS = 19,
        IxITEM_CD = 20,
        IxSPEC_CD = 21,
        IxCOLOR_CD = 22,
        IxSTATUS = 23,
        IxUPD_USER = 24,
        IxUPD_YMD = 25
    }



    public enum TBSBK_OUTSIDE_STOCK_30 : int
    {
        IxFACTORY = 1,
        IxITEM_NAME = 2,
        IxSPEC_NAME = 3,
        IxCOLOR_NAME = 4,
        IxUNIT = 5,
        IxPACKING = 6,
        IxSTYLE_CD = 7,
        IxSTYLE_NAME = 8,
        IxSTOCK_YMD = 9,
        IxBASE_QTY = 10,
        IxIN_YMD = 11,
        IxIN_QTY = 12,
        IxOUT_YMD = 13,
        IxOUT_QTY = 14,
        IxSTOCK_QTY = 15,
        IxPUR_PRICE = 16,
        IxPUR_CURRENCY = 17,
        IxAMOUNT = 18,
        IxOUTSIDE_PRICE = 19,
        IxOUTSIDE_CURRENCY = 20,
        IxCBD_PRICE = 21,
        IxCBD_CURRENCY = 22,
        IxSHIP_PRICE = 23,
        IxSHIP_CURRENCY = 24,
        IxCUST_CD = 25,
        IxCUST_NAME = 26,
        IxSTOCK_STATUS = 27,
        IxREMARKS = 28,
        IxBAR_CODE_REP = 29,
        IxITEM_CD = 30,
        IxSPEC_CD = 31,
        IxCOLOR_CD = 32,
        IxUPD_USER = 33,
        IxUPD_YMD = 34
    }



    public enum TBSBC_RELATION : int
    {

        IxFACTORY = 1,
        IxDIVISION = 2,
        IxNEW_CODE = 3,
        IxNEW_NAME = 4,
        IxOLD_CODE = 5,
        IxOLD_NAME = 6,
        IxREMARKS = 7,
        IxUPD_USER = 8,
        IxUPD_YMD = 9,

    }



    public enum TBSBK_STOCK_MANAGEMENT : int
    {
        IxMaxCt = 26,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : ()
        IxWH_CD = 2, 	//   : ()
        IxSTOCK_YMD = 3, 	// 재고일 : ()
        IxITEM_CD = 4, 	// 상품코드 : ()
        IxITEM_NAME = 5, 	//   : ()
        IxSPEC_CD = 6, 	// Spec : ()
        IxSPEC_NAME = 7, 	//   : ()
        IxCOLOR_CD = 8, 	// Color : ()
        IxCOLOR_NAME = 9, 	//   : ()
        IxBASE_QTY = 10, 	// 이월수량 : ()
        IxIN_QTY = 11, 	//   : ()
        IxOUT_QTY = 12, 	// Outgoing : ()
        IxSTOCK_QTY = 13, 	// Stock : ()
        IxUNIT = 14, 	//   : ()
        IxPUR_CURRENCY = 15, 	// 구매화폐 : ()
        IxPUR_PRICE = 16, 	// 구매단가 : ()
        IxOUTSIDE_CURRENCY = 17, 	//   : ()
        IxOUTSIDE_PRICE = 18, 	//   : ()
        IxCBD_CURRENCY = 19, 	// CBD화폐 : ()
        IxCBD_PRICE = 20, 	// CBD단가 : ()
        IxSHIP_CURRENCY = 21, 	//   : ()
        IxSHIP_PRICE = 22, 	//   : ()
        IxSTOCK_STATUS = 23, 	// 재고상태 : ()
        IxREMARKS = 24, 	// 비고 : ()
        IxUPD_USER = 25, 	//   : ()
        IxUPD_YMD = 26 	// Upd Ymd : ()
    }



    public enum TBSBK_STOCK_BASE : int
    {


        IxFACTORY = 1,
        IxWH_CD = 2,
        IxWH_NAME = 3,
        IxSTOCK_YMD = 4,
        IxITEM_NAME = 5,
        IxSPEC_NAME = 6,
        IxCOLOR_NAME = 7,
        IxBAES_QTY = 8,
        IxMNG_UNIT = 9,
        IxPUR_CURRENCY = 10,
        IxPUR_PRICE = 11,
        IxOUTSIDE_CURRENCY = 12,
        IxOUTSIDE_PRICE = 13,
        IxCBD_CURRENCY = 14,
        IxCBD_PRICE = 15,
        IxSHIP_CURRENCY = 16,
        IxSHIP_PRICE = 17,
        IxSTOCK_STATUS = 18,
        IxREMARKS = 19,
        IxITEM_CD = 20,
        IxSPEC_CD = 21,
        IxCOLOR_CD = 22,
        IxUPD_USER = 23,
        IxUPD_YMD = 24,
        IxRELATION_EXIST_YN = 25,

    }



    public enum TBSBK_STOCK_DAILY : int
    {

        IxFACTORY = 1,
        IxWH_CD = 2,
        IxSTOCK_YMD = 3,
        IxITEM_NAME = 4,
        IxSPEC_NAME = 5,
        IxCOLOR_NAME = 6,
        IxSTOCK_DAY = 7,
        IxBASE_QTY = 8,
        IxIN_QTY = 9,
        IxOUT_QTY = 10,
        IxSTOCK_QTY = 11,
        IxMNG_UNIT = 12,
        IxPUR_CURRENCY = 13,
        IxPUR_PRICE = 14,
        IxOUTSIDE_CURRENCY = 15,
        IxOUTSIDE_PRICE = 16,
        IxCBD_CURRENCY = 17,
        IxCBD_PRICE = 18,
        IxSHIP_CURRENCY = 19,
        IxSHIP_PRICE = 20,
        IxSTOCK_STATUS = 21,
        IxREMARKS = 22,
        IxITEM_CD = 23,
        IxSPEC_CD = 24,
        IxCOLOR_CD = 25,
        IxUPD_USER = 26,
        IxUPD_YMD = 27,
        IxRELATION_EXIST_YN = 28,

    }



    public enum TBSBT_STOCK_ITEM : int
    {

        IxFACTORY = 0,
        IxWH_CD = 1,
        IxSTOCK_YMD = 2,
        IxITEM_CD = 3,
        IxITEM_NAME = 4,
        IxSPEC_CD = 5,
        IxSPEC_NAME = 6,
        IxCOLOR_CD = 7,
        IxCOLOR_NAME = 8,
        IxMNG_UNIT = 9,
        IxEXIST_YN = 10,

    }




    public enum TBSBK_STOCK_CLOSE : int
    {


        IxFACTORY = 1,
        IxWH_CD = 2,
        IxWH_NAME = 3,
        IxSTOCK_YMD = 4,
        IxITEM_NAME = 5,
        IxSPEC_NAME = 6,
        IxCOLOR_NAME = 7,
        IxBAES_QTY = 8,
        IxIN_QTY = 9,
        IxOUT_QTY = 10,
        IxADJUST_QTY = 11,
        IxSTOCK_QTY = 12,
        IxADJUST_REASON = 13,
        IxMNG_UNIT = 14,
        IxPUR_CURRENCY = 15,
        IxPUR_PRICE = 16,
        IxOUTSIDE_CURRENCY = 17,
        IxOUTSIDE_PRICE = 18,
        IxCBD_CURRENCY = 19,
        IxCBD_PRICE = 20,
        IxSHIP_CURRENCY = 21,
        IxSHIP_PRICE = 22,
        IxSTOCK_STATUS = 23,
        IxREMARKS = 24,
        IxITEM_CD = 25,
        IxSPEC_CD = 26,
        IxCOLOR_CD = 27,
        IxUPD_USER = 28,
        IxUPD_YMD = 29,
        IxRELATION_EXIST_YN = 30,
    }



    public enum TBSBK_STOCK_DAILY_VJ : int
    {

        IxFACTORY = 1,
        IxWH_CD = 2,
        IxSTOCK_YMD = 3,
        IxITEM_NAME = 4,
        IxSPEC_NAME = 5,
        IxCOLOR_NAME = 6,
        IxSTOCK_DAY = 7,
        IxBASE_QTY = 8,
        IxIN_QTY = 9,
        IxOUT_QTY = 10,
        IxSTOCK_QTY = 11,
        IxBASE_QTY_U = 12,
        IxIN_QTY_U = 13,
        IxOUT_QTY_U = 14,
        IxSTOCK_QTY_U = 15,
        IxMNG_UNIT = 16,
        IxPUR_CURRENCY = 17,
        IxPUR_PRICE = 18,
        IxOUTSIDE_CURRENCY = 19,
        IxOUTSIDE_PRICE = 20,
        IxCBD_CURRENCY = 21,
        IxCBD_PRICE = 22,
        IxSHIP_CURRENCY = 23,
        IxSHIP_PRICE = 24,
        IxSTOCK_STATUS = 25,
        IxREMARKS = 26,
        IxITEM_CD = 27,
        IxSPEC_CD = 28,
        IxCOLOR_CD = 29,
        IxUPD_USER = 30,
        IxUPD_YMD = 31,
        IxRELATION_EXIST_YN = 32,

    }




    #endregion

    #region 품질



    /// <summary> 
    /// SQC_LAB_SPEC 테이블 인덱스 Enum 
    /// </summary> 
    public enum TBSQC_LAB_SPEC : int
    {
        IxMaxCt = 15,		// 인덱스 Count 
        IxFACTORY = 1,			// 	:VARCHAR2(5) 
        IxLAB_COMP_CD = 3,			// 	:VARCHAR2(4) 
        IxMCS_NO = 4,			// 	:VARCHAR2(15) 
        IxMCS_YMD = 5,			// 	:VARCHAR2(8) 
        IxTEST_CD = 6,			// 	:VARCHAR2(4) 
        IxSPEC_DIV = 7,			// 	:VARCHAR2(1) 
        IxSPEC_MIN = 8,			// 	:VARCHAR2(10) 
        IxSPEC_MAX = 9,			// 	:VARCHAR2(10) 
        IxUNIT_CD = 10,			// 	:VARCHAR2(4) 
        IxMETHOD = 11,			// 	:VARCHAR2(20) 
        IxREMARKS = 12,			// 	:VARCHAR2(500) 
        IxSEND_CHK = 13,			// 	:VARCHAR2(10) 
        IxSEND_YMD = 14,			// 	:DATE(7) 
        IxUPD_USER = 15,			// 	:VARCHAR2(30) 
        IxUPD_YMD = 16,			// 	:DATE(7) 
    }



    /// <summary> 
    /// SQC_LAB_COMPONENT 테이블 인덱스 Enum 
    /// </summary> 
    public enum TBSQC_LAB_COMPONENT : int
    {
        IxMaxCt = 12,		// 인덱스 Count 
        IxFACTORY = 1,			// 	:VARCHAR2(5) 
        IxLAB_COMP_CD = 2,			// 	:VARCHAR2(4) 
        IxTEST_CD = 3,			// 	:VARCHAR2(4) 
        IxTEST_NAME1 = 4,			// 	:VARCHAR2(30) 
        IxTEST_NAME2 = 5,			// 	:VARCHAR2(60) 
        IxUNIT_CD = 6,			// 	:VARCHAR2(4) 
        IxMETHOD = 7,			// 	:VARCHAR2(20) 
        IxREMARKS = 8,			// 	:VARCHAR2(500) 
        IxSEND_CHK = 9,			// 	:VARCHAR2(10) 
        IxSEND_YMD = 10,			// 	:DATE(7) 
        IxUPD_USER = 11,			// 	:VARCHAR2(30) 
        IxUPD_YMD = 12,			// 	:DATE(7) 
    }  



    public enum TBSQL_LAB_TEST : int
    {
        IxMaxCt = 22,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : VARCHAR2(5)
        IxLAB_NO = 2, 	// No : VARCHAR2(20)
        IxLAB_SEQ = 3, 	// Seq : ()
        IxLAB_YMD = 4, 	// Date : VARCHAR2(8)
        IxMCS_NO = 5, 	// MCS No : VARCHAR2(15)
        IxLAB_COMP_CD = 6, 	// Component : VARCHAR2(4)
        IxTEST_CD = 7, 	// Test code : VARCHAR2(4)
        IxTEST_NAME = 8, 	// Test Name : ()
        IxUNIT = 9, 	// Unit : ()
        IxRESULT_VALUE = 10, 	// Value : VARCHAR2(10)
        IxRESULT_SALT = 11, 	// Salt : VARCHAR2(10)
        IxRESULT_WATER = 12, 	// Water : VARCHAR2(10)
        IxSEPC_MIN = 13, 	// Min : ()
        IxSPEC_MAX = 14, 	// Max : ()
        IxMETHOD = 15, 	// Method : ()
        IxREQ_NO = 16, 	// No : VARCHAR2(20)
        IxREQ_SEQ = 17, 	// Seq : ()
        IxRESULT = 18, 	// Request : ()
        IxREMARKS = 19, 	// Remarks : VARCHAR2(500)
        IxSTATUS = 20, 	// Status : VARCHAR2(1)
        IxUPD_USER = 21, 	// Upd User : VARCHAR2(30)
        IxUPD_YMD = 22 	// Upd Ymd : DATE(7)
    }



	public enum TBSQL_LAB_REQUEST : int
	{
		IxMaxCt        = 32,	// 인덱스 Count
		IxLEV          = 1, 	// Lev : ()
		IxFACTORY      = 2, 	// Factory : VARCHAR2(5)
		IxREQ_NO       = 3, 	// No : VARCHAR2(20)
		IxREQ_SEQ      = 4, 	// Seq : NUMBER(22)
		IxREQ_YMD      = 5, 	// Date : VARCHAR2(8)
		IxITEM_CD      = 6, 	// Item : VARCHAR2(10)
		IxITEM_NAME    = 7, 	// Item : ()
		IxSPEC_CD      = 8, 	// Specification : VARCHAR2(5)
		IxSPEC_NAME    = 9, 	// Specification : ()
		IxCOLOR_CD     = 10, 	// Color : VARCHAR2(5)
		IxCOLOR_NAME   = 11, 	// Color : ()
		IxUNIT         = 12, 	// Unit : ()
		IxREQ_QTY      = 13, 	// Req : NUMBER(22)
		IxCUST_DIR_QTY = 14, 	// Dir : ()
		IxDEF_QTY      = 15, 	// Qty : NUMBER(22)
		IxDEF_TYPE     = 16, 	// Type : VARCHAR2(10)
		IxRESULT       = 17, 	// R : ()
		IxSTYLE_NAME   = 18, 	// Name : ()
		IxSTYLE_CD     = 19, 	// Code : VARCHAR2(9)
		IxSHIP_YMD     = 20, 	// Date : VARCHAR2(8)
		IxSHIP_FACTORY = 21,
		IxCUST_CD      = 22, 	// Code : VARCHAR2(6)
		IxCUST_NAME    = 23, 	// Name : ()
		IxSHIP_NO      = 24, 	// No : VARCHAR2(20)
		IxSHIP_SEQ     = 25, 	// Seq : VARCHAR2(4)
		IxPUR_USER     = 26, 	// Purchase User : VARCHAR2(30)
		IxLOT_NO       = 27, 	// No : VARCHAR2(9)
		IxLOT_SEQ      = 28, 	// Seq : VARCHAR2(2)
		IxOBS_TYPE     = 29, 	// OBS Type : VARCHAR2(2)
		IxSTATUS       = 30, 	// Status : VARCHAR2(1)
		IxUPD_USER     = 31, 	// Upd User : VARCHAR2(30)
		IxUPD_YMD      = 32 	// Upd Ymd : DATE(7)
	}




    public enum TBSQL_LAB_REQ_SHIP : int
    {
        IxMaxCt = 31,	// 인덱스 Count
        IxCHK = 1, 	// C : ()
        IxSHIP_NO = 2, 	// No : ()
        IxSHIP_SEQ = 3, 	// Seq : ()
        IxITEM_CD = 4, 	// Item : ()
        IxITEM_NAME = 5, 	// Item : ()
        IxSPEC_CD = 6, 	// Specification : ()
        IxSPEC_NAME = 7, 	// Specification : ()
        IxCOLOR_CD = 8, 	// Color : ()
        IxCOLOR_NAME = 9, 	// Color : ()
        IxUNIT = 10, 	// Unit : ()
        IxREQ_QTY = 11, 	// Req : ()
        IxINSP_QTY = 12, 	// Insp : ()
        IxREMAIN_QTY = 13, 	// Remain : ()
        IxREQUEST_REP = 14, 	// Rep : ()
        IxSTYLE_NAME = 15, 	// Name : ()
        IxSTYLE_CD = 16, 	// Code : ()
        IxSHIP_YMD = 17, 	// Ship Date : ()
        IxFACTORY = 18, 	// Factory : ()
        IxCUST_CD = 19, 	// Code : ()
        IxCUST_NAME = 20, 	// Name : ()
        IxREQ_NO = 21, 	// No : ()
        IxREQ_SEQ = 22, 	// Seq : ()
        IxREQ_YMD = 23, 	// Ymd : ()
        IxPUR_USER = 24, 	// Purchase User : ()
        IxLOT_NO = 25, 	// No : ()
        IxLOT_SEQ = 26, 	// Seq : ()
        IxOBS_TYPE = 27, 	// OBS Type : ()
        IxSTATUS = 28, 	// Status : ()
        IxREMARKS = 29, 	// Remarks : ()
        IxUPD_USER = 30, 	// Upd User : ()
        IxUPD_YMD = 31 	// Upd Ymd : ()
    }




    public enum TBSQL_LAB_REQ_LIST : int
    {
        IxMaxCt = 31,	// 인덱스 Count
        IxFACTORY = 1, 	// Factory : ()
        IxREQ_YMD = 2, 	// Date : ()
        IxREQ_NO = 3, 	// No : ()
        IxREQ_SEQ = 4, 	// Seq : ()
        IxITEM_CD = 5, 	// Item : ()
        IxITEM_NAME = 6, 	// Item : ()
        IxSPEC_CD = 7, 	// Specification : ()
        IxSPEC_NAME = 8, 	// Specification : ()
        IxCOLOR_CD = 9, 	// Color : ()
        IxCOLOR_NAME = 10, 	// Color : ()
        IxUNIT = 11, 	// Unit : ()
        IxSTYLE_CD = 12, 	// Code : ()
        IxSTYLE_NAME = 13, 	// Name : ()
        IxREQ_QTY = 14, 	// Req Qty : ()
        IxDEF_QTY = 15, 	// Qty : ()
        IxDEF_TYPE = 16, 	// Type : ()
        IxRESULT = 17, 	// R : ()
        IxCUST_CD = 18, 	// Code : ()
        IxCUST_NAME = 19, 	// Name : ()
        IxSHIP_NO = 20, 	// No : ()
        IxSHIP_SEQ = 21, 	// Seq : ()
        IxSHIP_YMD = 22, 	// Date : ()
        IxPUR_USER = 23, 	// Purchase User : ()
        IxLOT_NO = 24, 	// No : ()
        IxLOT_SEQ = 25, 	// Seq : ()
        IxOBS_TYPE = 26, 	// OBS Type : ()
        IxSTATUS = 27, 	// Status : ()
        IxLAB_NO = 28, 	// No : ()
        IxLAB_SEQ = 29, 	// Seq : ()
        IxUPD_USER = 30, 	// Upd User : ()
        IxUPD_YMD = 31 	// Upd Ymd : ()
    }





    #endregion

    #region Analysis


	// DPO List
	public enum TBDPO_LIST : int
	{
		IxFACTORY    = 1,	
		IxOBS_ID     = 2,	
		IxOBS_TYPE   = 3, 
		IxSTYLE_CD	 = 4,
		IxSTYLE_NAME = 5,
		IxGEN		 = 6,
		IxPST_YN	 = 7,
		IxTOT_QTY	 = 8,
		IxREMARKS	 = 9,
		IxUPD_USER	 = 10,
		IxUPD_YMD    = 11
	}


    	/// <summary> 
	///SEM_OBS_ANALYSIS_D 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_ANALYSIS_D : int 
	{ 

		IxMaxCt = 13,


		lxFACTORY			=1,
		lxCATEGORY_CD		=2,
		lxCATEGORY_NAME		=3,
		lxOUT_SOLE			=4,
		lxMODEL_CD			=5,
		lxMODEL_NAME		=6,
		lxGENDER			=7,
		lxDEV_CD			=8,
		lxSTYLE_CD			=9,  //obsid 빼기
		lxOBSID             =10,
		lxTOT_QTY			=11,
		lxFOB			    =12,
		lxAMOUNT			=13,



	}  



    	public enum TBSBW_PEGASUS_GAC_UPLOAD_01 : int 
	{    
		IxFACTORY			=  1,
		IxFACTORY_NAME      =  2,
		IxLIAISON_OFFICE    =  3,
		IxOGAC				=  4, 			
		IxCGAC				=  5, 
		IxPO_ACCEPTANCE     =  6,
		IxORIGIN_RECEIPT    =  7,
		IxGAC14				=  8,  
		IxGAC30				=  9,  	
		IxGAC45				= 10,	
		IxOBS_NU			= 11,	
		IxOBS_SEQ_NU		= 12,			
		IxRGAC				= 13,
		IxOR_MINUS_DAY0     = 14,
		IxOR_MINUS_DAY14    = 15, 
		IxOR_MINUS_DAY30	= 16,
		IxOR_MINUS_DAY45	= 17,
		IxORDER_QTY			= 18,			
		IxOR_QTY			= 19,
		IxOR_PO_QTY         = 20,
		IxTOLERANCE_MARGIN  = 21,
		IxDAY0_QTY			= 22,			
		IxDAY0_ONTIME		= 23,			
		IxDAY0_RATE			= 24,			
		IxDAY14_QTY			= 25,			
		IxDAY14_ONTIME		= 26,			
		IxDAY14_RATE		= 27,			
		IxDAY30_QTY			= 28,			
		IxDAY30_ONTIME		= 29,			
		IxDAY30_RATE		= 30,			
		IxDAY45_QTY			= 31,			
		IxDAY45_ONTIME		= 32,			
		IxDAY45_RATE		= 33,			
		IxOGAC_QTY			= 34, 			
		IxOGAC_ONTIME		= 35,			
		IxOGAC_RATE			= 36, 

	}  


	public enum TBSBW_PEGASUS_GAC_UPLOAD_02 : int 
	{    
		
		IxPLAN_MONTH											=  1,
		IxFACTORY												=  2,
		IxFACTORY_NAME										=  3,
		IxCATEGORY												=  4,
		IxMATERIAL												=  5,
		IxMATERIAL_NAME										=  6,
		IxOUTSOLE_1_CD 										=  7,
		IxCGAC														=  8, 			
		IxORD														=  9, 
		IxOGAC														= 10,
		IxRGAC														= 11,
		IxOBS_NU													= 12,  
		IxOBS_SEQ_NU											= 13,
		IxPO_ACCEPTANCE_DATE							= 14,
		IxPO_QTY													= 15, 
		IxOR_QTY													= 16,
		IxTOLERANCE_MARGIN_EARLY_RGAC			= 17,	
		IxTOLERANCE_MARGIN_LATE_RGAC			= 18,		
		IxTOLERANCE_MARGIN_EARLY_OGAC			= 19,	
		IxTOLERANCE_MARGIN_LATE_OGAC			= 20,	 
		IxRGAC_ONTIME_QTY								= 21,
		IxRGAC_ONTIME_RATE								= 22,	
		IxRGAC_PROJECT_QTY								= 23,	
		IxRGAC_PROJECT_RATE								= 24,	
		IxRGAC_TOTAL_QTY									= 25,	
		IxRGAC_TOTAL_RATE									= 26,			
		IxRGAC_MARGIN_ONTIME_QTY					= 27,	
		IxRGAC_MARGIN_ONTIME_RATE					= 28,	
		IxRGAC_MARGIN_PROJECT_QTY					= 29,	
		IxRGAC_MARGIN_PROJECT_RATE				= 30,			
		IxRGAC_MARGIN_TOTAL_QTY						= 31,			
		IxRGAC_MARGIN_TOTAL_RATE					= 32,			
		IxOGAC_ONTIME_QTY								= 33,			
		IxOGAC_ONTIME_RATE								= 34, 		
		IxOGAC_PROJECT_QTY								= 35,			
		IxOGAC_PROJECT_RATE								= 36, 		
		IxOGAC_TOTAL_QTY									= 37,	
		IxOGAC_TOTAL_RATE								= 38,	
		IxOGAC_MARGIN_ONTIME_QTY					= 39,	
		IxOGAC_MARGIN_ONTIME_RATE					= 40,		
		IxOGAC_MARGIN_PROJECT_QTY					= 41,		
		IxOGAC_MARGIN_PROJECT_RATE				= 42,			
		IxOGAC_MARGIN_TOTAL_QTY						= 43,		
		IxOGAC_MARGIN_TOTAL_RATE					= 44,

	}  



    	/// <summary> 
	///SEM_OBS_ANALYSIS 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_ANALYSIS : int 
	{ 

		IxMaxCt = 22,

		IxFACTORY             = 1,	
		IxOBS_GROUP_TYPE	  = 2,
		IxOBS_ID			  = 3,		
		IxSTYLE_CD			  = 4,
		IxSTYLE_NAME		  = 5,
		IxGENDER			  = 6,
		IxFOB				  = 7,	
		lxGROUP_TOT_QTY       = 8,
		lxGROUP_SORT_QTY      = 9,
		lxAMOUNT              =	 10,
		IxOBS_TYPE_FT_QTY	  =	  11,
		IxOBS_TYPE_FT_RATE	  =	  12,
		IxOBS_QTY_ID		  =	  13,
		IxOBS_TYPE_ID_RATE	  =	  14,
		IxOBS_QTY_TS		  =	  15,
		IxOBS_TYPE_TS_RATE	  =	  16,
		IxOBS_QTY_PS		  =	  17,
		IxOBS_TYPE_PS_RATE	  =	  18,
		IxOBS_QTY_SS 		  =	  19,			
		IxOBS_TYPE_SS_RATE	  =	  20,
		IxCOLOR_FLAG	      =	  21,
		lxREMARKS             =   22,


	}  



	/// <summary> 
	///TBSEM_OBS_PROFIT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_PROFIT : int 
	{ 
		IxMaxCt = 19,		// 인덱스 Count 

		
		lxFACTORY                   = 1,
		lxTIME_LINE                 = 2,
		lxMONTHS                    = 3,
		lxFLAG                      = 4,
		lxOBS_TYPE                  = 5,
		lxOBS_ID                    = 6,
		lxSTYLE_CD                  = 7,
		lxSTYLE_NAME                = 8,
		lxPROD_QTY					= 9,
		lxPROD_PLAN_QTY             = 10,
		lxPROD_INVOICE_QTY          = 11,
		lxPROD_GAC_QTY              = 12,
		lxPROD_BALANCE_QTY          = 13,
		lxINVOCE_AMOUNT             = 14,
		lxFORECAST_AMOUNT           = 15,
		lxBUDGET_AMOUNT             = 16,
		lxBALNACE_AMOUNT            = 17,
		lxCOLOR_FLAG                = 18,
		lxREMARKS                   = 19,
	}  



    public enum TBSBW_ITEM_SEARCH : int 
	{    
		IxSHIP_YMD			=  1,
		IxSTYLE_CD			=  2,			
		IxSTYLE_NAME		=  3,			
		IxOBS_TYPE			=  4,
		IxITEM_NAME			=  5,			
		IxSPEC_NAME			=  6,			
		IxCOLOR_NAME		=  7,			
		IxITEM_UNIT			=  8,			
		IxITEM_CD			=  9,			
		IxSPEC_CD			= 10,			
		IxCOLOR_CD			= 11,			
		IxREQUEST_REASON	= 12,			
		IxREQ_QTY			= 13,			
		IxPUR_QTY			= 14,			
		IxOUT_QTY			= 15,			
		IxTRADE_QTY			= 16,			
		IxFOREIGN_IN_QTY	= 17,			
		IxFOREIGN_OUT_QTY	= 18,			
		IxFOREIGN_STOCK_QTY	= 19, 
	}   



    	public enum TBSBW_ORDER_SEARCH : int 
	{    
		IxFACTORY					=  1,
		IxOBS_ID					=  2,			
		IxOBS_TYPE					=  3,			
		IxMOD_CD					=  4,
		IxSTYLE_CD					=  5,	
		IxGEN						=  6, 	
		IxPST_YN					=  7, 	
		IxOBS_NU					=  8,			
		IxOBS_SEQ_NU				=  9,			
		IxCHG_NU					= 10,			
		IxDEST						= 11,			
		IxOA_NU						= 12,			
		IxOA_OBS_DIV				= 13,			
		IxOA_DIV					= 14,			
		IxOA_YMD					= 15,			
		IxPLAN_OAAPP_DIV			= 16,			
		IxPLAN_OAAPP_YMD			= 17,			
		IxORD_QTY					= 18,			
		IxREQ_NO					= 19,			
		IxREQ_ORD_QTY				= 20,			
		IxPRD_QTY					= 21,			
		IxLOSS_QTY					= 22,			
		IxPO_NO						= 23,			
		IxCLOSE_YN					= 24,			
		IxLOT_NO					= 25,			
		IxLOT_SEQ					= 26,			
		IxLOT_QTY					= 27,		
		IxLINE_QTY					= 28, 
		IxCGAC						= 29, 
		IxOGAC						= 30, 
		IxRGAC						= 31,  
		IxGAC14						= 32, 
		IxGAC30						= 33, 
		IxGAC45						= 34, 
		IxORDER_QTY					= 35, 
		IxOR_QTY					= 36, 
		IxDAY0_QTY					= 37, 
		IxDAY0_ONTIME				= 38, 
		IxDAY0_RATE					= 39, 
		IxDAY14_QTY					= 40, 
		IxDAY14_ONTIME				= 41, 
		IxDAY14_RATE				= 42, 
		IxDAY30_QTY					= 43,			
		IxDAY30_ONTIME				= 44,			
		IxDAY30_RATE				= 45,			
		IxDAY45_QTY					= 46,			
		IxDAY45_ONTIME				= 47,			
		IxDAY45_RATE				= 48,			
		IxOGAC_QTY					= 49,			
		IxOGAC_ONTIME				= 50,		
		IxOGAC_RATE			        = 51, 
		IxRGAC_ONTIME_QTY			= 52,
		IxRGAC_ONTIME_RATE			= 53,
		IxRGAC_PROJECT_QTY			= 54, 
		IxRGAC_PROJECT_RATE			= 55,
		IxRGAC_TOTAL_QTY			= 56,
		IxRGAC_TOTAL_RATE			= 57,			
		IxRGAC_MARGIN_ONTIME_QTY	= 58,
		IxRGAC_MARGIN_ONTIME_RATE	= 59,
		IxRGAC_MARGIN_PROJECT_QTY	= 60,
		IxRGAC_MARGIN_PROJECT_RATE	= 61,			
		IxRGAC_MARGIN_TOTAL_QTY		= 62,			
		IxRGAC_MARGIN_TOTAL_RATE	= 63,			
		IxOGAC_ONTIME_QTY			= 64,			
		IxOGAC_ONTIME_RATE			= 65,			
		IxOGAC_PROJECT_QTY			= 66,			
		IxOGAC_PROJECT_RATE			= 67,			
		IxOGAC_TOTAL_QTY			= 68,			
		IxOGAC_TOTAL_RATE			= 69,			
		IxOGAC_MARGIN_ONTIME_QTY	= 70,			
		IxOGAC_MARGIN_ONTIME_RATE	= 71,			
		IxOGAC_MARGIN_PROJECT_QTY	= 72,			
		IxOGAC_MARGIN_PROJECT_RATE	= 73, 			
		IxOGAC_MARGIN_TOTAL_QTY		= 74,			
		IxOGAC_MARGIN_TOTAL_RATE	= 75, 


	} 



    public enum TBSBW_STYLE_LIFECYCLE_COMMON : int 
	{    
		IxDIVISION		= 0, 			
		IxKEY1			= 1, 		
		IxKEY2			= 2, 	
		IxGROUP1_COUNT	= 3, 
		IxGROUP2_COUNT	= 4, 
		IxGROUP3_COUNT	= 5,

		IxDATA_START    = 6,
	} 




    /// <summary> 
	/// TBSEM_FOB 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_FOB : int 
	{ 
		IxMaxCt = 6,		// 인덱스 Count 

		lxFACTORY       =1,
		lxFOB_MONTH     =2,
		lxFOB           =3,
		lxFOB_CURRENCY  = 4,
		lxUPD_YMD		= 5,
		lxUPD_USER		= 6,

	}  




    public enum TBSBW_ORDER_SEARCH_LINE : int 
	{    
		IxFACTORY			=  1,
		IxLOT_NO			=  2,			
		IxLOT_SEQ			=  3,			
		IxLINE_QTY			=  4,

	}



	/// <summary> 
	/// TBSEM_BUDGET 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_BUDGET : int 
	{ 
		IxMaxCt = 8,		// 인덱스 Count 

		lxFACTORY         =1,
		lxBUDGET_MONTH    =2,
		lxBUDGET          = 3,
		lxBUDGET_CURRENCY = 4,
		lxTARGET_QUANTITY = 5,
		lxFOB             = 6,
		lxUPD_YMD		  = 7,
		lxUPD_USER		  = 8,

	}  



	public enum TBSBW_ORDER_SEARCH_SIZE : int 
	{    
		IxJOB_FLAG			=  1,
		IxDESC1			    =  2,			
		IxDESC2				=  3,
		IxTOTAL				=  4,	
		IxCS_SIZE_START		=  5,

		IxTBJOB_FLAG        =  0,
		IxTBDESC1			=  1,
		IxTBDESC2			=  2,
		IxTBCS_SIZE         =  3,
		IxTBQTY				=  4,


	}  



	public enum TBSBW_ORDER_SEARCH_GAC : int 
	{    

		IxFACTORY			=  1, 	
		IxOBS_ID			=  2, 
		IxOBS_TYPE			=  3, 	
		IxDEMAND			=  4,  
		IxORG_QTY			=  5,	
		IxORG_QTY_RATE		=  6, 	
		IxORG_ONTIME_QTY	=  7,  		
		IxORG_TOTAL_RATE	=  8, 
		IxIN_QTY			=  9, 			
		IxIN_ONTIME_QTY		= 10, 			
		IxIN_TOTAL_RATE		= 11,			
		IxPROJ_QTY			= 12, 			
		IxPROJ_ONTIME_QTY	= 13, 		
		IxPROJ_TOTAL_RATE	= 14, 		

		
	} 



	public enum TBSBW_ORDER_SEARCH_GAC_HEAD : int 
	{     
		IxFACTORY		= 0, 	
		IxOBS_ID		= 1, 
		IxOBS_TYPE		= 2, 	
		IxDEMAND	    = 3,	
		IxDATA_START    = 4, 
		
	} 




    #endregion



}
