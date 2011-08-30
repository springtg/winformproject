using System;

namespace FlexTrade.ClassLib
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
	/// STM_INVOICE ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSTM_INVOICE : int 
	{ 
		IxMaxCt = 56,				// �ε��� Count 
		IxT_LEVEL				=1,
		IxCHK					=2,
		IxFACTORY				=3, 
		IxPO_NO_K				=4, 
		IxPO_ITEM_K				=5, 
		IxINVOICE_KEY           =6, 
		IxPO_NO					=7,
		IxPO_ITEM				=8,
		IxPO_ID					=9,
		IxDOC_DATE				=10,
		IxSEASON                =11,
		IxSTYLE_CD				=12,		
		IxSTYLE_NM				=13,
		IxGEN_CD				=14,
		IxGEN_NM				=15,
		IxSIZE_DIV				=16,
		IxSIZE_FROM				=17,
		IxSIZE_TO				=18,
		IxINVOICE_CT_QTY		=19,
		IxORDER_SHOE_QTY		=20,
		IxINVOICE_SHOE_QTY		=21,
		IxLOT_DIV				=22,
		IxLOT					=23,
		IxCURRENCY              =24,
		IxORDER_CS_FOB			=25,
		IxFOB_DIV				=26,
		IxTRADE_CS_FOB			=27,
		IxTRADE_FACTORY_FOB		=28,
		IxAMOUNT				=29,
		IxFSP					=30,
		IxLC_NO					=31,
		IxBUYER_CD				=32,
		IxBUYER_NM				=33,
		IxBUKRS					=34,
		IxFFS_SOLDTO_CD			=35,
		IxFFS_NAME2				=36,		
		IxWERKS					=37,
		IxFFS_SHP_TO_ACCT		=38,
		IxCUST_XREF				=39,
		IxOUTPUT_PROFILE_ID		=40,
		IxFFS_STENCIL_DEST		=41,
		IxFFS_STENCIL_SHIPTO	=42,
		IxFFS_STENCIL_ORIGIN    =43,
		IxM_BL_NO				=44,
		IxPL_NO					=45,
		IxAFS_CATEGORY			=46,
		IxCUST_PO_NO			=47,
		IxPO_TYPE				=48,
		IxPO_TYPE_NM			=49,
		IxTRANS_CD				=50,
		IxTRANS_NM				=51,
		IxAIR_CHARGES			=52,
		IxINCO1					=53,
		IxCONTRACT_NO			=54,
		IxSUB_CATEGORY_NAME	    =55,
		IxLINE_REMARK			=56,

	}  


	/// <summary> 
	/// STM_INVOICE_IRREGULAR ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSTM_INVOICE_IRREGULAR : int 
	{ 
		IxMaxCt = 56,				// �ε��� Count 
		IxT_LEVEL				=1,
		IxCHK					=2,
		IxFACTORY				=3, 
		IxPO_NO_K				=4, 
		IxPO_ITEM_K				=5, 
		IxINVOICE_NO_K          =6, 
		IxINVOICE_KEY_K         =7, 
		IxSTYLE_CD				=8,
		IxSTYLE_NM				=9,
		IxPO_NO					=10,
		IxPO_ITEM				=11,
		IxPO_ID					=12,
		IxDOC_DATE				=13,
		IxSEASON                =14,
		IxGEN_CD				=15,
		IxGEN_NM				=16,
		IxSIZE_DIV				=17,
		IxSIZE_FROM				=18,
		IxSIZE_TO				=19,
		IxINVOICE_CT_QTY		=20,
		IxORDER_SHOE_QTY		=21,
		IxINVOICE_SHOE_QTY		=22,
		IxLOT_DIV				=23,
		IxLOT					=24,
		IxCURRENCY              =25,
		IxORDER_CS_FOB			=26,
		IxFOB_DIV				=27,
		IxTRADE_CS_FOB			=28,
		IxTRADE_FACTORY_FOB		=29,
		IxAMOUNT				=30,
		IxFSP					=31,
		IxLC_NO					=32,
		IxBUYER_CD	  			=33,
		IxBUYER_NM				=34,
		IxBUKRS					=35,
		IxFFS_SOLDTO_CD			=36,
		IxFFS_NAME2				=37,
		IxFFS_NAME2_1			=38,
		IxWERKS					=39,
		IxFFS_SHP_TO_ACCT		=40,
		IxCUST_XREF				=41,
		IxOUTPUT_PROFILE_ID		=42,
		IxFFS_STENCIL_DEST		=43,
		IxFFS_STENCIL_SHIPTO	=44,
		IxFFS_STENCIL_ORIGIN    =45,
		IxM_BL_NO				=46,
		IxPL_NO					=47,
		IxAFS_CATEGORY			=48,
		IxCUST_PO_NO			=49,
		IxPO_TYPE				=50,
		IxPO_TYPE_NM			=51,
		IxTRANS_CD				=52,
		IxTRANS_NM				=53,
		IxAIR_CHARGES			=54,
		IxINCO1					=55,
		IxCONTRACT_NO			=56,
		IxSUB_CATEGORY_NAME	    =57,
		IxLINE_REMARK			=58,

	}  


	/// <summary> 
	/// TBSTM_INVOICE_STUFF ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSTM_INVOICE_STUFF : int 
	{ 
		IxMaxCt = 63,				// �ε��� Count 
		IxT_LEVEL				=1,
		IxCHK					=2,
		IxFACTORY				=3, 
		IxPO_NO_K				=4, 
		IxPO_ITEM_K				=5, 
		IxINVOICE_KEY           =6, 
		IxPO_NO					=7,
		IxPO_ITEM				=8,
		IxPO_ID					=9,
		IxDOC_DATE				=10,
		IxSEASON                =11,
		IxSTYLE_CD				=12,		
		IxSTYLE_NM				=13,
		IxGEN_CD				=14,
		IxGEN_NM				=15,
		IxTRANS_CD				=16,
		IxTRANS_NM				=17,
		IxSIZE_DIV				=18,
		IxSIZE_FROM				=19,
		IxSIZE_TO				=20,
		IxINVOICE_CT_QTY		=21,
		IxORDER_SHOE_QTY		=22,
		IxINVOICE_SHOE_QTY		=23,
		IxCI_WEIGHT				=24,
		IxCI_NO					=25,
		IxCCIB				    =26,
		IxCBM					=27,
		IxGROSS_WEIGHT			=28,
		IxNET_WEIGHT			=29,
		IxORD_DATE				=30,
		IxWERKS					=31,
		IxFFS_SHP_TO_ACCT		=32,
		IxCUST_XREF				=33,
		IxFFS_STENCIL_DEST		=34,
		IxFFS_STENCIL_SHIPTO	=35,
		IxFFS_STENCIL_ORIGIN    =36,
		IxBOOKING_NO			=37,
		IxBOOKING_DATE			=38,
		IxDELIVERY_DATE			=39,
		IxBUKRS					=40,
		IxFFS_SOLDTO_CD			=41,
		IxFFS_NAME2				=42,
		IxNOTIFY_KEY			=43,
		IxNOTIFY_NAME1			=44,
		IxAIR_CHARGES			=45,
		IxRGAC_DATE				=46,
		IxOGAC_DATE				=47,
		IxCGAC_DATE				=48,
		IxCURRENCY              =49,
		IxORDER_CS_FOB			=50,
		IxTRADE_CS_FOB			=51,
		IxTRADE_FACTORY_FOB		=52,
		IxAMOUNT				=53,
		IxPO_TYPE				=54,
		IxPO_TYPE_NM			=55,
		IxLC_NO					=56,
		IxM_BL_NO				=57,
		IxPL_NO					=58,
		IxAFS_CATEGORY			=59,
		IxCUST_PO_NO			=60,
		IxINCO1					=61,
		IxINCO2					=62,
		IxREMARKS				=63,

	}  

	/// <summary> 
	/// TBSTM_INVOICE_BOOKING_1 ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSTM_INVOICE_BOOKING_1 : int 
	{ 
		IxMaxCt = 72,				// �ε��� Count 
		IxT_LEVEL				=1,
		IxCHK					=2,
		IxFACTORY				=3, 
		IxPO_NO_K				=4, 
		IxPO_ITEM_K				=5, 
		IxINVOICE_KEY           =6, 
		IxPO_NO					=7,
		IxPO_ITEM				=8,
		IxPO_ID					=9,
		IxDOC_DATE				=10,
		IxSEASON                =11,
		IxSTYLE_CD				=12,		
		IxSTYLE_NM				=13,
		IxGEN_CD				=14,
		IxGEN_NM				=15,
		IxTRANS_CD				=16,
		IxTRANS_NM				=17,
		IxSIZE_DIV				=18,
		IxSIZE_FROM				=19,
		IxSIZE_TO				=20,
		IxINVOICE_CT_QTY		=21,
		IxORDER_SHOE_QTY		=22,
		IxINVOICE_SHOE_QTY		=23,
		IxCI_WEIGHT				=24,
		IxCI_NO					=25,
		IxCCIB				    =26,
		IxCBM					=27,
		IxGROSS_WEIGHT			=28,
		IxNET_WEIGHT			=29,
		IxORD_DATE				=30,
		IxWERKS					=31,
		IxFFS_SHP_TO_ACCT		=32,
		IxCUST_XREF				=33,
		IxFFS_STENCIL_DEST		=34,
		IxFFS_STENCIL_SHIPTO	=35,
		IxFFS_STENCIL_ORIGIN    =36,
		IxBOOKING_NO			=37,
		IxBOOKING_DATE			=38,
		IxBOOKING_REVISE_DATE	=39,
		IxDELIVERY_DATE			=40,
		IxBUKRS					=41,
		IxFFS_SOLDTO_CD			=42,
		IxFFS_NAME2				=43,
		IxNOTIFY_KEY			=44,
		IxNOTIFY_NAME1			=45,
		IxFORWARDER_TO			=46,
		IxFORWARDER_FR			=47,
		IxFORWARDER_AF_NO		=48,
		IxFORWARDER_REMARK_1	=49,
		IxFORWARDER_REMARK_2	=50,
		IxFORWARDER_REMARK_3	=51,
		IxAIR_DISCHARGE			=52,
		IxAIR_CHARGES			=53,
		IxRGAC_DATE				=54,
		IxOGAC_DATE				=55,
		IxCGAC_DATE				=56,
		IxBGAC_DATE				=57,
		IxCURRENCY              =58,
		IxORDER_CS_FOB			=59,
		IxTRADE_CS_FOB			=60,
		IxTRADE_FACTORY_FOB		=61,
		IxAMOUNT				=62,
		IxPO_TYPE				=63,
		IxPO_TYPE_NM			=64,
		IxLC_NO					=65,
		IxM_BL_NO				=66,
		IxPL_NO					=67,
		IxAFS_CATEGORY			=68,
		IxCUST_PO_NO			=69,
		IxINCO1					=70,
		IxINCO2					=71,
		IxREMARKS				=72,

	}  


	/// <summary> 
	/// TBSTM_INVOICE_STUFF ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSTM_INVOICE_STUFF_NEW : int 
	{ 
		IxMaxCt = 64,				// �ε��� Count 
		IxT_LEVEL				=1,
		IxCHK					=2,
		IxFACTORY				=3, 
		IxPO_NO_K				=4, 
		IxPO_ITEM_K				=5, 
		IxINVOICE_NO            =6, 
		IxSTYLE_CD				=7,		
		IxSTYLE_NM				=8,
		IxPO_NO					=9,
		IxPO_ITEM				=10,
		IxPO_ID					=11,
		IxDOC_DATE				=12,
		IxSEASON                =13,
		IxGEN_CD				=14,
		IxGEN_NM				=15,
		IxTRANS_CD				=16,
		IxTRANS_NM				=17,
		IxSIZE_DIV				=18,
		IxSIZE_FROM				=19,
		IxSIZE_TO				=20,
		IxINVOICE_CT_QTY		=21,
		IxORDER_SHOE_QTY		=22,
		IxINVOICE_SHOE_QTY		=23,
		IxCI_WEIGHT				=24,
		IxCI_NO					=25,
		IxCCIB				    =26,
		IxCBM					=27,
		IxGROSS_WEIGHT			=28,
		IxNET_WEIGHT			=29,
		IxORD_DATE				=30,
		IxWERKS					=31,
		IxFFS_SHP_TO_ACCT		=32,
		IxCUST_XREF				=33,
		IxFFS_STENCIL_DEST		=34,
		IxFFS_STENCIL_SHIPTO	=35,
		IxFFS_STENCIL_ORIGIN    =36,
		IxBOOKING_NO			=37,
		IxBOOKING_DATE			=38,
		IxDELIVERY_DATE			=39,
		IxBUKRS					=40,
		IxFFS_SOLDTO_CD			=41,
		IxFFS_NAME2				=42,
		IxFFS_NAME2_1			=43,
		IxNOTIFY_KEY			=44,
		IxNOTIFY_NAME1			=45,
		IxAIR_CHARGES			=46,
		IxRGAC_DATE				=47,
		IxOGAC_DATE				=48,
		IxCGAC_DATE				=49,
		IxCURRENCY              =50,
		IxORDER_CS_FOB			=51,
		IxTRADE_CS_FOB			=52,
		IxTRADE_FACTORY_FOB		=53,
		IxAMOUNT				=54,
		IxPO_TYPE				=55,
		IxPO_TYPE_NM			=56,
		IxLC_NO					=57,
		IxM_BL_NO				=58,
		IxPL_NO					=59,
		IxAFS_CATEGORY			=60,
		IxCUST_PO_NO			=61,
		IxINCO1					=62,
		IxINCO2					=63,
		IxREMARK				=64,

	}  


	/// <summary> 
	/// TBSTM_INVOICE_BOOKING_2 ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSTM_INVOICE_BOOKING_2 : int 
	{ 
		IxMaxCt = 66,				// �ε��� Count 
		IxT_LEVEL				=1,
		IxCHK					=2,
		IxFACTORY				=3, 
		IxPO_NO_K				=4, 
		IxPO_ITEM_K				=5, 
		IxINVOICE_NO            =6, 
		IxSTYLE_CD				=7,		
		IxSTYLE_NM				=8,
		IxPO_NO					=9,
		IxPO_ITEM				=10,
		IxPO_ID					=11,
		IxDOC_DATE				=12,
		IxSEASON                =13,
		IxGEN_CD				=14,
		IxGEN_NM				=15,
		IxTRANS_CD				=16,
		IxTRANS_NM				=17,
		IxSIZE_DIV				=18,
		IxSIZE_FROM				=19,
		IxSIZE_TO				=20,
		IxINVOICE_CT_QTY		=21,
		IxORDER_SHOE_QTY		=22,
		IxINVOICE_SHOE_QTY		=23,
		IxCI_WEIGHT				=24,
		IxCI_NO					=25,
		IxCCIB				    =26,
		IxCBM					=27,
		IxGROSS_WEIGHT			=28,
		IxNET_WEIGHT			=29,
		IxORD_DATE				=30,
		IxWERKS					=31,
		IxFFS_SHP_TO_ACCT		=32,
		IxCUST_XREF				=33,
		IxFFS_STENCIL_DEST		=34,
		IxFFS_STENCIL_SHIPTO	=35,
		IxFFS_STENCIL_ORIGIN    =36,
		IxBOOKING_NO			=37,
		IxBOOKING_DATE			=38,
		IxBOOKING_REVISE_DATE	=39,
		IxDELIVERY_DATE			=40,
		IxBUKRS					=41,
		IxFFS_SOLDTO_CD			=42,
		IxFFS_NAME2				=43,
		IxFFS_NAME2_1			=44,
		IxNOTIFY_KEY			=45,
		IxNOTIFY_NAME1			=46,
		IxAIR_CHARGES			=47,
		IxRGAC_DATE				=48,
		IxOGAC_DATE				=49,
		IxCGAC_DATE				=50,
		IxBGAC_DATE				=51,
		IxCURRENCY              =52,
		IxORDER_CS_FOB			=53,
		IxTRADE_CS_FOB			=54,
		IxTRADE_FACTORY_FOB		=55,
		IxAMOUNT				=56,
		IxPO_TYPE				=57,
		IxPO_TYPE_NM			=58,
		IxLC_NO					=59,
		IxM_BL_NO				=60,
		IxPL_NO					=61,
		IxAFS_CATEGORY			=62,
		IxCUST_PO_NO			=63,
		IxINCO1					=64,
		IxINCO2					=65,
		IxREMARK				=66,

	}  

	/// <summary> 
	/// TBSTM_INVOICE_CS ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSTM_INVOICE_CS : int 
	{ 
		IxMaxCt = 69,			// �ε��� Count 
		IxT_LEVEL				=1,
		IxCHK					=2,
		IxFACTORY				=3, 
		IxPO_NO_K				=4, 
		IxPO_ITEM_K				=5, 
		IxINVOICE_KEY           =6, 
		IxPO_NO					=7,
		IxPO_ITEM				=8,
		IxPO_ID					=9,
		IxDOC_DATE				=10,
		IxSEASON                =11,
		IxSTYLE_CD				=12,		
		IxSTYLE_NM				=13,
		IxGEN_CD				=14,
		IxGEN_NM				=15,
		IxSIZE_FROM				=16,
		IxSIZE_TO				=17,
		IxTRANS_CD				=18,
		IxTRANS_NM				=19,
		IxINVOICE_CT_QTY		=20,
		IxORDER_SHOE_QTY		=21,
		IxINVOICE_SHOE_QTY		=22,
		IxCURRENCY              =23,
		IxORDER_CS_FOB			=24,
		IxTRADE_CS_FOB			=25,
		IxTRADE_FACTORY_FOB		=26,
		IxAMOUNT				=27,
		IxMERCURY_CT_QTY		=28,
		IxMERCURY_SHOE_QTY		=29,
		IxMERCURY_FOB			=30,
		IxMERCURY_AMOUNT		=31,
		IxMERCURY_CBM			=32,
		IxMERCURY_NET_WEIGHT	=33,
		IxMERCURY_GROSS_WEIGHT	=34,
		IxMERCURY_LC_NO			=35,
		IxMERCURY_SHIP_DATE		=36,
		IxCUSTOM_NO				=37,
		IxCUSTOM_DATE			=38,
		IxHXD					=39,
		IxWERKS					=40,
		IxFFS_SHP_TO_ACCT		=41,
		IxCUST_XREF				=42,
		IxFFS_STENCIL_DEST		=43,
		IxLOT_DIV				=44,
		IxLOT					=45,
		IxCI_WEIGHT				=46,
		IxCI_NO					=47,
		IxCCIB				    =48,
		IxCBM					=49,
		IxNET_WEIGHT			=50,
		IxGROSS_WEIGHT			=51,
		IxRGAC_DATE				=52,
		IxOGAC_DATE				=53,
		IxCGAC_DATE				=54,
		IxORD_DATE				=55,
		IxFFS_STENCIL_SHIPTO	=56,
		IxFFS_STENCIL_ORIGIN    =57,
		IxBOOKING_NO			=58,
		IxBOOKING_DATE			=59,
		IxDELIVERY_DATE			=60,
		IxBUKRS					=61,
		IxFFS_SOLDTO_CD			=62,
		IxFFS_NAME2				=63,
		IxNOTIFY_KEY			=64,
		IxNOTIFY_NAME1			=65,
		IxPO_TYPE				=66,
		IxPO_TYPE_NM			=67,
		IxINCO1					=68,
		IxINCO2					=69,

	}  

	/// <summary> 
	/// TBSTM_CONSIGNEE_MASTER ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSTM_CONSIGNEE_MASTER : int 
	{ 
		IxMaxCt = 10,				// �ε��� Count 
		IxFACTORY				=1, 
		IxFFS_SOLDTO_CD			=2, 
		IxBUKRS					=3, 
		IxFFS_NAME1				=4, 
		IxFFS_NAME2				=5,
		IxFFS_STREET1			=6, 
		IxFFS_STREET2			=7, 
		IxFFS_STREET3			=8, 
		IxFFS_STREET4			=9, 
		IxFFS_STREET5			=10,

	}  


	/// <summary> 
	/// TBSTM_NOTIFY_MASTER ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSTM_NOTIFY_MASTER : int 
	{ 
		IxMaxCt = 9,			// �ε��� Count 
		IxFACTORY				=1, 
		IxNOTIFY_KEY			=2,
		IxSHIP_TO				=3, 
		IxWERKS					=4,
		IxNOTIFY_NAME1			=5, 
		IxNOTIFY_NAME2			=6, 
		IxNOTIFY_NAME3			=7, 
		IxNOTIFY_NAME4			=8, 
		IxNOTIFY_NAME5			=9,

	}  

	public enum TBSTM_BANK_MASTER : int 
	{ 
		IxMaxCt = 6,		// �ε��� Count 
		IxFACTORY			=1, 
		IxBANK_CD			=2,
		IxBANK_NAME1		=3, 
		IxBANK_NAME2		=4, 
		IxBANK_NAME3		=5, 
		IxBANK_NAME4		=6, 
	}  


	/// <summary> 
	/// TBSTM_OUTGOING �ε��� Enum 
	/// </summary> 
	public enum TBSTM_OUTGOING : int 
	{ 
		IxMaxCt = 14,			// �ε��� Count 
		IxFACTORY				=1,
		IxSHIP_DATE				=2,
		IxLC_NO				    =3, 
		IxINVOICE_NO			=4, 
		IxSHOE_QTY				=5, 
		IxCURRENCY				=6, 
		IxCS_AMOUNT				=7,
		IxFACTORY_AMOUNT        =8,
		IxPO_ID					=9,
		IxFFS_SHP_TO_ACCT		=10,
		IxWERKS					=11,
		IxSTYLE_CD				=12,
		IxBOOKING_NO            =13,
		IxMARGIN_RATE			=14,		

	}  


	/// <summary> 
	/// TBSTM_NEGO �ε��� Enum 
	/// </summary> 
	public enum TBSTM_NEGO : int 
	{ 
		IxMaxCt = 20,			// �ε��� Count 
		IxCHECK		        =1,
		IxFACTORY			=2,
		IxPO_NO				=3,
		IxPO_ITEM			=4,
		IxINVOICE_KEY		=5, 
		IxSTYLE_CD			=6, 
		IxSHIP_DATE			=7, 
		IxCGAC_DATE			=8, 
		IxINVOICE_NO		=9,
		IxINVOICE_SHOE_QTY	=10,
		IxFACTORY_AMOUNT    =11,
		IxNEGO_AMOUNT		=12,
		IxLC_NO				=13,
		IxNEGO_DATE			=14,
		IxNEGO_SEQ			=15,
		IxBANK_CD			=16,
		IxBANK_NM           =17,
		IxEXPIRY_DATE       =18,
		IxEXPIRY_DESC       =19,
		IxBOOKING_NO        =20,

	}  


	/// <summary> 
	/// TBSTM_NEGO �ε��� Enum 
	/// </summary> 
	public enum TBSTM_NEGO_STATUS : int 
	{ 
		IxMaxCt = 14,			// �ε��� Count 
		IxT_LEVEL			=1,
		IxCHK				=2,
		IxFACTORY			=3,
		IxNEGO_DATE_K		=4,
		IxNEGO_SEQ_K		=5,
		IxNEGO_DATE			=6,
		IxNEGO_SEQ			=7,
		IxLC_NO				=8, 
		IxNEGO_AMOUNT		=9, 
		IxBANK_CD			=10, 
		IxBANK_NM			=11, 
		IxEXPIRY			=12,
		IxPO_NO				=13,
		IxBOOKING_NO		=14,
	}  



	/// <summary> 
	/// TBSTM_NEGO �ε��� Enum 
	/// </summary> 
	public enum TBSTM_NEGO_UNIT_STATUS : int 
	{ 
		IxMaxCt = 14,			// �ε��� Count 
		IxFACTORY			=1,
		IxNEGO_DATE		    =2,
		IxINVOICE_NO		=3,
		IxSTYLE_CD			=4,
		IxINVOICE_QTY		=5,
		IxFACTORY_AMOUNT	=6, 
		IxRATE_AA			=7, 
		IxRATE_AB			=8, 
		IxBALANCE_A			=9,
		IxRATE_BA			=10,
		IxRATE_BB			=11,
		IxBALANCE_B			=12,
		IxBALANCE_A_AMOUNT	=13,
		IxBALANCE_B_AMOUNT	=14,
	}  








}
