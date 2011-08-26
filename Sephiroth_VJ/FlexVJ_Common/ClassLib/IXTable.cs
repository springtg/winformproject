using System;

namespace FlexVJ_Common.ClassLib
{
	 
	#region ����
	/// <summary> 
	/// LINK_DEF : ��ũ �Ӽ� ������ �ֱ� ���� �ε���
	/// </summary> 
	public enum LINK_DEF : int 
	{ 
		 
		IxARROW_DST =3,			// ��ũ �� ��Ÿ��	:VARCHAR2(60) 
		IxARROW_MID =4,			// ��ũ ������ ��Ÿ��	:VARCHAR2(60) 
		IxARROW_ORG =5,			// ��ũ ù ��Ÿ��	:VARCHAR2(60) 
		IxDASHSTYLE =6,			// ��ũ �� ��Ÿ��	:VARCHAR2(10) 
		IxDRAWCOLOR =7,			// ��ũ �� ����	:VARCHAR2(10) 
		IxDRAWWIDTH =8,			// ��ũ �� �β�	:VARCHAR2(10) 
		IxFONT =9,			// ��ũ �� �ؽ�Ʈ ��Ʈ �Ӽ�	:VARCHAR2(60) 
		IxJUMP =10,			// JUMP �Ӽ�	:VARCHAR2(10) 
		IxLINE_STYLE =11,			// ���� ��Ÿ�� (�� : �, ���� ��)	:VARCHAR2(10) 
		IxLINE_ROUND =12,			// ���� ���� �Ӽ� : ��ũ ������ �κ� ���� ó�� ����	:VARCHAR2(10) 
		IxTAG =13,			// �±� �Ӽ�	:VARCHAR2(60) 
		IxTEXT =14,			// �ؽ�Ʈ	:VARCHAR2(60) 
		IxTEXTCOLOR =15,			// �ؽ�Ʈ ����	:VARCHAR2(10) 
		IxTOOLTIP =16,			// ����	:VARCHAR2(60) 
		 
	}  

	/// <summary> 
	/// NODE_DEF : ��� �Ӽ� ������ �ֱ� ���� �ε���
	/// </summary> 
	public enum NODE_DEF : int 
	{   
		IxALIGNMENT =5,			// �ؽ�Ʈ ���� ���	:VARCHAR2(10) 
		IxDASHSTYLE =6,			// ��� �׵θ� ��Ÿ��	:VARCHAR2(10) 
		IxDRAWCOLOR =7,			// ��� �׵θ� ����	:VARCHAR2(10) 
		IxDRAWWIDTH =8,			// ��� �׵θ� �� �β�	:VARCHAR2(10) 
		IxFILLCOLOR =9,			// ��� ä��� ����	:VARCHAR2(10) 
		IxFONT =10,			// �ؽ�Ʈ ��Ʈ �Ӽ�	:VARCHAR2(60) 
		IxGRADI_YN =11,			// GRADIANT ����	:VARCHAR2(1) 
		IxGRADICOLOR =12,			// GRADIANT ����	:VARCHAR2(10) 
		IxGRADIMODE =13,			// GRADIANT ��� (��Ÿ��)	:VARCHAR2(10) 
		IxHEIGHT =14,			// ��� ����	:VARCHAR2(10) 
		IxSHADOW =15,			// ��� �׸��� ǥ�� �Ӽ�	:VARCHAR2(60) 
		IxSHAPE =16,			// ��� �׵θ� ��� �Ӽ�	:VARCHAR2(60) 
		IxTAG =17,			// �±� �Ӽ�	:VARCHAR2(60) 
		IxTEXT =18,			// �ؽ�Ʈ	:VARCHAR2(60) 
		IxTEXTCOLOR =19,			// �ؽ�Ʈ ǥ�� ����	:VARCHAR2(10) 
		IxTOOLTIP =20,			// ����	:VARCHAR2(60) 
		IxWIDTH =21,			// ��� �ʺ�	:VARCHAR2(10) 
		 
	}  






	/// <summary> 
	/// NODE_DEF : ��� �Ӽ� ������ �ֱ� ���� �ε���
	/// </summary> 
	public enum DEFAULT_NODE_DEF: int 
	{   
		IxALIGNMENT = 0,			// �ؽ�Ʈ ���� ���	:VARCHAR2(10) 
		IxDASHSTYLE = 1,			// ��� �׵θ� ��Ÿ��	:VARCHAR2(10) 
		IxDRAWCOLOR = 2,			// ��� �׵θ� ����	:VARCHAR2(10) 
		IxDRAWWIDTH = 3,			// ��� �׵θ� �� �β�	:VARCHAR2(10) 
		IxFILLCOLOR = 4,			// ��� ä��� ����	:VARCHAR2(10) 
		IxFONT = 5,			// �ؽ�Ʈ ��Ʈ �Ӽ�	:VARCHAR2(60) 
		IxGRADI_YN = 6,			// GRADIANT ����	:VARCHAR2(1) 
		IxGRADICOLOR = 7,			// GRADIANT ����	:VARCHAR2(10) 
		IxGRADIMODE = 8,			// GRADIANT ��� (��Ÿ��)	:VARCHAR2(10) 
		IxHEIGHT = 9,			// ��� ����	:VARCHAR2(10) 
		IxSHADOW = 10,			// ��� �׸��� ǥ�� �Ӽ�	:VARCHAR2(60) 
		IxSHAPE = 11,			// ��� �׵θ� ��� �Ӽ�	:VARCHAR2(60) 
		IxTAG = 12,			// �±� �Ӽ�	:VARCHAR2(60) 
		IxTEXT = 13,			// �ؽ�Ʈ	:VARCHAR2(60) 
		IxTEXTCOLOR = 14,			// �ؽ�Ʈ ǥ�� ����	:VARCHAR2(10) 
		IxTOOLTIP = 15,			// ����	:VARCHAR2(60) 
		IxWIDTH = 16,			// ��� �ʺ�	:VARCHAR2(10) 
		 
	}  





	#endregion

	/// <summary> 
	/// SBM_MRP_LLT_PLAN_TRACKING ���̺� �ε��� Enum 
	/// </summary> 
	public enum TSBM_MRP_LLT_PLAN_TRACKING : int 
	{ 
		IxMaxCt                     = 65,	
		IxFACTORY                   = 1,	
		IxOBS_ID                    = 2,	
		IxVER                       = 3,		
		IxMODEL_CD                  = 4,	
		IxMODEL_NAME                = 5,
		IxSTYLE_CD                  = 6,	
		IxCATEGORY                  = 7,	
		IxMODEL_INF                 = 8,	
		IxLINE_NAME                 = 9,	
		IxORDER_QTY                 = 10,	
		IxRGAC_YMD                  = 11,		
		IxPLAN_YMD_1                = 12,	
		IxPLAN_YMD_2                = 13,	
		IxREASON_DIV			    = 14,
		IxLOCATION_CD               = 15,	
		IxLLT_YN				    = 16,

		IxTARGET_SILHOUETTE_MAT     = 17,
		IxACTUAL_SILHOUETTE_MAT     = 18,
		IxWARNING_SILHOUETTE_MAT    = 19,
		IxTARGET_SILHOUETTE_WS      = 20,
		IxACTUAL_SILHOUETTE_WS      = 21,
		IxWARNING_SILHOUETTE_WS     = 22,

		IxTARGET_MBOM               = 23,
		IxACTUAL_MBOM               = 24,
		IxWARNING_MBOM			    = 25,
		IxTARGET_MUL                = 26, 
		IxACTUAL_MUL                = 27, 
		IxWARNING_MUL			    = 28,
		IxTARGET_CFM_SAMPLE_MAT     = 29,
		IxACTUAL_CFM_SAMPLE_MAT     = 30,
		IxWARNING_CFM_SAMPLE_MAT    = 31,		
		IxTARGET_REF_PFC            = 32,           
		IxACTUAL_REF_PFC            = 33, 
		IxWARNING_REF_PFC           = 34,
		IxTARGET_CFM_SAMPLE         = 35,
		IxETC_CFM_SAMPLE            = 36,
		IxWARNING_ETC_CFM_SAMPLE    = 37,
		IxACTUAL_CFM_SAMPLE         = 38,
		IxWARNING_CFM_SAMPLE        = 39,
		IxTARGET_COLOR_SWATCH       = 40,      
		IxACTUAL_COLOR_SWATCH       = 41,
		IxWARNING_COLOR_SWATCH      = 42,		
		IxVENDOR_LEAD_TIME          = 43,
		IxTARGET_COLOR_SWATCH_RECV  = 44,
		IxACTUAL_COLOR_SWATCH_RECV  = 45,
		IxWARNING_COLOR_SWATCH_RECV = 46,
		IxTARGET_PURCHASING         = 47,        
		IxACTUAL_PURCHASING         = 48,
		IxWARNING_PURCHASING        = 49,
		IxTARGET_ETD                = 50,
		IxACTUAL_ETD                = 51,
		IxWARNING_ETD               = 52,
		IxTARGET_ETA_PORT           = 53,
		IxACTUAL_ETA_PORT           = 54,
		IxWARNING_ETA_PORT          = 55,
		IxACTUAL_ETA_VJ             = 56, 
		IxWARNING_ETA_VJ            = 57,
		IxD_HOW_MANY_DAYS           = 58,
		IxSTATUS				    = 59,
		IxUPD_USER				    = 60,
		IxUPD_YMD				    = 61,
		IxAGREE_DATE			    = 62,
		IxTHEME					    = 63,
		IxREASON				    = 64,
		IxSTYLE_DIV				    = 65,
								    
	}							    
								    

	public enum TSBM_MATERIAL_TRACKING : int 
	{ 
		IxMaxCt                    = 39,	
		IxLEVEL					   = 1,						
		IxKEY					   = 2,	
		IxFACTORY				   = 3,	
		IxOBS_ID				   = 4,	
		IxDIV					   = 5,	
		IxPLAN_YMD				   = 6,
		IxMODEL_CD				   = 7,	
		IxMODEL_NAME			   = 8,	
		IxSTYLE_CD                 = 9,	                                        
		IxLINE_NAME			       = 10,
		IxORDER_QTY			       = 11,			
		IxIMPORT_DIV	           = 12,                 
		IxITEM_CD				   = 13,
		IxITEM_NAME			       = 14,
		IxSPEC_CD				   = 15,
		IxSPEC_NAME			       = 16,
		IxCOLOR_CD				   = 17,
		IxCOLOR_NAME			   = 18,
		IxUNIT                     = 19,         	                            
		IxPUR_NO				   = 20,
		IxPUR_YMD				   = 21,
		IxPUR_QTY				   = 22,
		IxPUR_CURRENCY			   = 23,
		IxPUR_PRICE			       = 24,
		IxPUR_USER	               = 25,             
		IxPUR_DIV				   = 26,
		IxPUR_DIV_NM			   = 27,
		IxCUST_CD				   = 28,
		IxCUST_NM	               = 29,   
		IxSWATCH				   = 30,  
		IxETD					   = 31,
		IxETA					   = 32,
		IxIN_NO				       = 33,	
		IxIN_YMD				   = 34,
		IxIN_QTY				   = 35,
		IxIN_CURRENCY			   = 36,
		IxIN_PRICE                 = 37,                         
		IxYIELD_VALUE			   = 38,
		IxSTYLE_ITEM_DIV		   = 39,

	}  

	public enum TBSBS_SHIPPING_SIZE : int
	{
		IxMaxCt = 3,	// �ε��� Count
		IxKIND = 1, 	//   : ()
		IxTOTAL = 2, 	//   : ()
		IxCOL = 3 		//   : ()
	}

	public enum TBSVM_BOTTOM_EFF : int
	{
		IxMaxCt = 11,	// �ε��� Count
		IxT_LEVEL     =1, 
		IXORDER_SEQ   =2,
		IxFACTORY     =3,
		IxOBS_ID      =4,
		IxLINE_CD     =5,
		IxLINE_NAME   =6,
		IxSTYLE_CD    =7,
		IxMODEL_NAME  =8,
		IxOS_CODE     =9,
		IxOS_CYCLE    =10,
		IxDATE        =11,

	}


	public enum TBSVM_STOCK_UPLOAD : int
	{
		IxMaxCt			= 29,	// �ε��� Count
		IxFACTORY		=1, 
		IXOUT_YMD		=2,
		IxOBS_ID		=3,
		IxSTYLE_CD      =4,
		IxSTYLE_NAME    =5,
		IxPROD_QTY		=6,
		IxOUT_PROCESS   =7,
		IxLINE_NAME		=8,
		IxITEM_GROUP    =9,
		IxITEM_NAME		=10,
		IxSPEC_NAME     =11,
		IxCOLOR_NAME    =12,
		IxUNIT			=13,
		IxYIELD			=14,
		IxUSAGE_QTY     =15,
		IxSYS_BASE_QTY  =16,
		IxSYS_IN_QTY    =17,
		IxSYS_OUT_QTY   =18,
		IxSYS_STOCK_QTY =19,
		IxACT_BASE_QTY  =20,
		IxACT_IN_QTY    =21,
		IxACT_OUT_QTY   =22,
		IxACT_STOCK_QTY =23,
		IxLOT_NO        =24,
		IxLOT_SEQ		=25,
		IxOUT_LINE      =26,
		IxITEM_CD       =27,
		IxSPEC_CD       =28,
		IxCOLOR_CD      =29,

	}



    // Purchase : SBC_YIELD_INFO
    public enum TBSBC_YIELD_INFO_POP : int
    {
        IxMaxCt = 23,	// �ε��� Count
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
        IxCOLOR_CD = 18, 	//   : ()
        IxGROUP_CD = 19,
        IxGROUP_NAME = 20,
        IxGROUP_NAME2 = 21,
        IxSTYLE_NAME  = 22,
        IxCOMP_NAME    = 23
    }


}
