using System;
using System.Drawing;

namespace FlexOrder.ClassLib
{


	/// <summary>
	/// IXTable�� ���� ��� �����Դϴ�.
	/// </summary>
	/// <summary> 
	/// SPS_TABLE ���̺� �ε��� Class 
	/// </summary> 
	public class TBSPS_TABLE
	{ 

		/// <summary>
		/// Grid�� Į��0 �� width
		/// </summary>
		public static int GridCol0_Width = 20;			
		/// <summary>
		/// Grid�� Į��0 �� color
		/// </summary>
		public static Color GridCol0_Color = Color.FromArgb(236, 247, 187);	


		public static int IxPG_ID =1;			// ���α׷� ���̵�	:VARCHAR2(20) 
		public static int IxPG_SEQ =2;			// ���α׷� SEQ	:NUMBER(22) 
		public static int IxCOL_ORDER =3;			// �÷� ���� (ǥ�ü���)	:NUMBER(22) 
		public static int IxTABLE_NAME =4;			// ���̺��	:VARCHAR2(20) 
		public static int IxCOL_NAME =5;			// �÷��� (����ʵ��)	:VARCHAR2(20) 
		public static int IxHEAD_DESC1 =6;			// ��� �����	:VARCHAR2(100) 
		public static int IxHEAD_DESC2 =7;			// �ϴ� �����	:VARCHAR2(100) 
		public static int IxWIDTH =8;			// �÷� �ʺ�	:NUMBER(22) 
		public static int IxLOCK_YN =9;			// ����Ʈ ���� ����	:VARCHAR2(1) 
		public static int IxVISIBLE_YN =10;			// VISIBLE ����	:VARCHAR2(1) 
		public static int IxAUTOSORT_YN =11;			// �ڵ���Ʈ ����	:VARCHAR2(1) 
		public static int IxHALIGN =12;			// ���� ����	:VARCHAR2(10) 
		public static int IxVALIGN =13;			// ���� ����	:VARCHAR2(10) 
		public static int IxMAXROW =14;			// �ִ� �� �� : ó�� ǥ�õ� �� �������� ��� ����	:NUMBER(22) 
		public static int IxFROZENCOL =15;			// FROZEN COLUMN	:NUMBER(22) 
		public static int IxFROZENROW =16;			// FROZEN ROW	:NUMBER(22) 
		public static int IxBACKCOLOR =17;			// ����	:VARCHAR2(10) 
		public static int IxFORECOLOR =18;			// ���ڻ�	:VARCHAR2(10) 
		public static int IxCELLTYPE =19;			// ��Ÿ��	:VARCHAR2(10) 
		public static int IxDATA_LIST_TYPE =20;			// ��Ÿ���� �޺��ڽ��϶� �����ڵ� �Ǵ� ���� �̿� ���� ���� (�����ڵ� : 0, ���� : 1)	:VARCHAR2(1) 
		public static int IxDATA_LIST_CD =21;			// DATA_LIST_TYPE = 0 �϶� �����ڵ� ����	:VARCHAR2(10) 
		public static int IxDATA_LIST_QUERY =22;			// DATA_LIST_TYPE = 1 �϶� ���� ����	:VARCHAR2(500) 
		public static int IxREMARKS =23;			// ���	:VARCHAR2(100) 
		public static int IxUPD_USER =24;			// �ۼ���	:VARCHAR2(10) 
		
		
		public TBSPS_TABLE() 
		{ 
		} 

	}



	/// <summary> 
	/// TBSEM_BP_DIFF ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_OA_CREATE01 : int 
	{ 
		IxMaxCt = 16,		// �ε��� Count 

		lxFACTORY =1,	       
		lxOBS_NU  =2,	       
		lxOBS_SEQ_NU  =3,	   
		lxCHG_NU	  =4,  
		lxSYMD	      =5,     
		lxEYMD	      =6,      
		lxSTYLE_CD	  =7,     
		lxOBS_ID	  =8,       
		lxOBS_TYPE	  =9,     
		lxREAL_OBS_DIV =10,	 
		lxOGAC_YMD	   =11,  
		lxRTS_YMD	   =12,    
		lxTOT_QTY	   =13,    
		lxOA_NU_BEF	   =14,  
		lxOA_NU_AFT	   =15,  
		lxREQ_YN       = 16,
		lxREQ_NU       = 17,

	}


	
	
	/// <summary> 
	/// TBSEM_BP_DIFF ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_OA_CREATE02 : int 
	{ 
		IxMaxCt = 10,		// �ε��� Count 
		lxOA_REL_FLAG =1,  	
		lxFACTORY =2,				       
		lxOBS_NU  =3,	       
		lxOBS_SEQ_NU  =4,	   
		lxCHG_NU	  =5,  
		lxOA_FLAG     =6,  		
		lxCOL_SORT    =7,  
		IxCS_SIZE     =8,
		lxORDER_QTY   =9,


	}


	/// <summary> 
	/// TBSEM_OBS_OA_CREATE03 ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_OA_CREATE03 : int 
	{ 

		IxMaxCt = 20,		// �ε��� Count 

		IxFACTORY                  =1, 
		IxOA_NU					   =2, 
		IxOA_NODE				   =3, 
		IxOA_NODE_SEQ			   =4, 
		lxOA_FLAG                  =5,
		IxOA_LINK_SEQ			   =6, 
		IxORG_NODE				   =7,  
		IxDST_NODE				   =8, 
		IxARROW_DST				   =9, 
		IxARROW_MID				   =10, 
		IxARROW_ORG				   =11, 
		IxNODE_TOP				   =12, 
		IxNODE_LEFT				   =13, 
		IxNODE_WIDTH			   =14, 
		IxNODE_HEIGHT			   =15, 
		IxTAG					   =16, 
		IxTEXT					   =17, 
		IxTOOLTIP				   =18, 
		IxUPD_USER				   =19, 
		IxUPD_YMD				   =20, 
		
	}							 



	
	/// <summary> 
	/// TBSEM_OBS_OA_CREATE03 ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_OA_CREATE04 : int 
	{ 

		IxMaxCt = 8,		// �ε��� Count 

		IxFACTORY          =1, 
		lxREQ_NO           =2, 
		IxTOT_QTY		   =3,		   
		IxDEST			   =4, 
		IxOGAC_YMD		   =5, 
		lxOBS_NU           =6,
		IxOBS_SEQ_NU	   =7, 
		IxCHG_NU		   =8,  

		
	}		



	
	/// <summary> 
	/// TBSEM_BP_DIFF ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_OA_INFORMATION : int 
	{ 
		IxMaxCt = 12,		// �ε��� Count 

		IxFACTORY		=1, 
		lxOA_NU			=2, 
		lxOBS_DIV		=3, 
		lxOA_OBS_DIV	=4, 
		lxOBS_ID		=5,  
		lxOBS_TYPE		=6, 
		lxSTYLE_CD		=7, 
		lxOA_DIV		=8, 
		IxOA_YMD		=9, 
		lxOA_CFM		=10, 
		IxCHG_YMD		=11, 
		lxPUR_NO		=12, 
		lxOUR_REF_NO	=13, 
		lxPUR_GRP		=14, 
		lxYOUR_REF		=15, 
		lxORDER_RSN		=16, 
		lxQUAL_ISEQ		=17, 
		lxSEASON_CD		=18, 
		IxSEASON_YEAR	=19, 
		lxREMARKS		=10, 
		lxUPD_USER		=11, 
		lxUPD_YMD		=12, 





	}




 
	/// <summary> 
	/// TBSEM_FOB ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_FOB : int 
	{ 
		IxMaxCt = 6,		// �ε��� Count 

		lxFACTORY       =1,
		lxFOB_MONTH     =2,
		lxFOB           =3,
		lxFOB_CURRENCY  = 4,
		lxUPD_YMD		= 5,
		lxUPD_USER		= 6,

	}  



 
	/// <summary> 
	/// TBSEM_BP_DIFF ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_BP_DIFF : int 
	{ 
		IxMaxCt = 9,		// �ε��� Count 

		lxFACTORY = 1,
		lxOS1_CD= 2,
		lxDEV_CD= 3,
		lxSTYLE_CD= 4,
		lxSTYLE_NAME= 5,
		lxDEL_MONTH= 6,
		lxBEF_PROD_QTY= 7,
		lxAFT_PROD_QTY= 8,
		lxDIFF= 9,
	}  


	
 
	/// <summary> 
	///SEM_OBS_ANALYSIS ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_ANALYSIS : int 
	{ 
//		IxMaxCt = 20,		// �ε��� Count 
//
//		lxFACTORY                = 1,		
//		lxOBS_ID                 = 2,
//		lxSTYLE_CD               = 3,
//		lxSTYLE_NAME             = 4,
//		lxGEN                    = 5,
//		lxFOB                    = 6,
//		lxSUM_TOT_QTY            = 7,		
//		lxAMOUNT                 = 8,
//		lxOBS_TYPE               = 9,
//		lxFT_QTY                 =	 10,
//		lxFT_RATE                =	 11,
//		lxPS_QTY                 =	 12,
//		lxPS_RATE                =	 13,
//		lxSS_QTY                 =	 14,
//		lxSS_RATE                =	 15,
//		lxTS_QTY                 =	 16,
//		lxTS_RATE                =	 17,
//		lxETC_QTY                =	 18,
//		lxETC_RATE               =	 19,
//		lxREMAKS1                =  20,

		IxMaxCt = 21,

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
	    lxREMARKS             =   21,


	}  



	
	/// <summary> 
	///TBSEM_OBS_PROFIT ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_PROFIT : int 
	{ 
		IxMaxCt = 13,		// �ε��� Count 

		
		lxFACTORY                   = 1,
		lxPLAN_MONTH                = 2,
		lxOBS_TYPE                  = 3,
		lxSTYLE_CD                  = 4,
		lxSTYLE_NAME                = 5,
		lxPROD_RESULT               = 6,
		lxINGAC_RESULT              = 7,
		lxBALANCE                   = 8,
		lxFOB                       = 9,
		lxPROFIT_FORECAST           = 10,
		lxBUDGET                    = 11,
		lxPROFIT                    = 12,
		lxREMARKS                   = 13,
	}  






	/// <summary> 
	/// SCM_TABLE ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSCM_TABLE : int 
	{ 
		IxMaxCt = 31,		// �ε��� Count 
		IxPG_ID =1,			// ���α׷� ���̵�	:VARCHAR2(20) 
		IxPG_SEQ =2,			// ���α׷� SEQ	:NUMBER(22) 
		IxCOL_NAME =3,			// �÷��� (����ʵ��)	:VARCHAR2(20) 
		IxCOL_ORDER =4,			// �÷� ���� (ǥ�ü���)	:NUMBER(22) 
		IxTABLE_NAME =5,			// ���̺��	:VARCHAR2(20) 
		IxHEAD_DESC1 =6,			// �����(1)	:VARCHAR2(100) 
		IxHEAD_DESC2 =7,			// �����(2)	:VARCHAR2(100) 
		IxHEAD_DESC3 =8,			// �����(3)	:VARCHAR2(100) 
		IxHEAD_DESC4 =9,			// �����(4)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC1 =10,			// ��� �����(1)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC2 =11,			// ��� �����(2)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC3 =12,			// ��� �����(3)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC4 =13,			// ��� �����(4)	:VARCHAR2(100) 
		IxWIDTH =14,			// �÷� �ʺ�	:NUMBER(22) 
		IxLOCK_YN =15,			// ����Ʈ ���� ����	:VARCHAR2(1) 
		IxVISIBLE_YN =16,			// VISIBLE ����	:VARCHAR2(1) 
		IxAUTOSORT_YN =17,			// �ڵ���Ʈ ����	:VARCHAR2(1) 
		IxHALIGN =18,			// ���� ����	:VARCHAR2(10) 
		IxVALIGN =19,			// ���� ����	:VARCHAR2(10) 
		IxMAXROW =20,			// �ִ� �� �� : ó�� ǥ�õ� �� �������� ��� ����	:NUMBER(22) 
		IxFROZENCOL =21,			// FROZEN COLUMN	:NUMBER(22) 
		IxFROZENROW =22,			// FROZEN ROW	:NUMBER(22) 
		IxBACKCOLOR =23,			// ����	:VARCHAR2(10) 
		IxFORECOLOR =24,			// ���ڻ�	:VARCHAR2(10) 
		IxCELLTYPE =25,			// ��Ÿ��	:VARCHAR2(10) 
		IxDATA_LIST_TYPE =26,			// ��Ÿ���� �޺��ڽ��϶� �����ڵ� �Ǵ� ���� �̿� ���� ���� (�����ڵ� : 0, ���� : 1)	:VARCHAR2(1) 
		IxDATA_LIST_CD =27,			// DATA_LIST_TYPE = 0 �϶� �����ڵ� ����	:VARCHAR2(10) 
		IxDATA_LIST_QUERY =28,			// DATA_LIST_TYPE = 1 �϶� ���� ����	:VARCHAR2(500) 
		IxREMARKS =29,			// ���	:VARCHAR2(100) 
		IxUPD_USER =30,			// �ۼ���	:VARCHAR2(10) 
		IxUPD_YMD =31,			// �ۼ�����	:DATE(7) 
	}  

//
//
//
//	/// <summary> 
//	/// SCM_TABLE ���̺� �ε��� Enum 
//	/// </summary> 
//	public enum TBSCM_TABLE : int 
//	{ 
//		IxMaxCt = 31,		// �ε��� Count 
//		IxPG_ID =1,			// ���α׷� ���̵�	:VARCHAR2(20) 
//		IxPG_SEQ =2,			// ���α׷� SEQ	:NUMBER(22) 
//		IxCOL_NAME =3,			// �÷��� (����ʵ��)	:VARCHAR2(20) 
//		IxCOL_ORDER =4,			// �÷� ���� (ǥ�ü���)	:NUMBER(22) 
//		IxTABLE_NAME =5,			// ���̺��	:VARCHAR2(20) 
//		IxHEAD_DESC1 =6,			// �����(1)	:VARCHAR2(100) 
//		IxHEAD_DESC2 =7,			// �����(2)	:VARCHAR2(100) 
//		IxHEAD_DESC3 =8,			// �����(3)	:VARCHAR2(100) 
//		IxHEAD_DESC4 =9,			// �����(4)	:VARCHAR2(100) 
//		IxLAN_HEAD_DESC1 =10,			// ��� �����(1)	:VARCHAR2(100) 
//		IxLAN_HEAD_DESC2 =11,			// ��� �����(2)	:VARCHAR2(100) 
//		IxLAN_HEAD_DESC3 =12,			// ��� �����(3)	:VARCHAR2(100) 
//		IxLAN_HEAD_DESC4 =13,			// ��� �����(4)	:VARCHAR2(100) 
//		IxWIDTH =14,			// �÷� �ʺ�	:NUMBER(22) 
//		IxLOCK_YN =15,			// ����Ʈ ���� ����	:VARCHAR2(1) 
//		IxVISIBLE_YN =16,			// VISIBLE ����	:VARCHAR2(1) 
//		IxAUTOSORT_YN =17,			// �ڵ���Ʈ ����	:VARCHAR2(1) 
//		IxHALIGN =18,			// ���� ����	:VARCHAR2(10) 
//		IxVALIGN =19,			// ���� ����	:VARCHAR2(10) 
//		IxMAXROW =20,			// �ִ� �� �� : ó�� ǥ�õ� �� �������� ��� ����	:NUMBER(22) 
//		IxFROZENCOL =21,			// FROZEN COLUMN	:NUMBER(22) 
//		IxFROZENROW =22,			// FROZEN ROW	:NUMBER(22) 
//		IxBACKCOLOR =23,			// ����	:VARCHAR2(10) 
//		IxFORECOLOR =24,			// ���ڻ�	:VARCHAR2(10) 
//		IxCELLTYPE =25,			// ��Ÿ��	:VARCHAR2(10) 
//		IxDATA_LIST_TYPE =26,			// ��Ÿ���� �޺��ڽ��϶� �����ڵ� �Ǵ� ���� �̿� ���� ���� (�����ڵ� : 0, ���� : 1)	:VARCHAR2(1) 
//		IxDATA_LIST_CD =27,			// DATA_LIST_TYPE = 0 �϶� �����ڵ� ����	:VARCHAR2(10) 
//		IxDATA_LIST_QUERY =28,			// DATA_LIST_TYPE = 1 �϶� ���� ����	:VARCHAR2(500) 
//		IxREMARKS =29,			// ���	:VARCHAR2(100) 
//		IxUPD_USER =30,			// �ۼ���	:VARCHAR2(10) 
//		IxUPD_YMD =31,			// �ۼ�����	:DATE(7) 
//	}  
//


	/// <summary> 
	/// SPC_CODE ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSPC_CODE : int 
	{ 
		IxMaxCt = 16,		// �ε��� Count 
		IxFACTORY =1,			// ����	:VARCHAR2(5) 
		IxCOM_CD =2,			// ���� �ڵ�	:VARCHAR2(10) 
		IxCOM_SEQ =3,			// �ڵ� �Ϸù�ȣ	:NUMBER(22) 
		IxCOM_NAME =4,			// �ڵ��	:VARCHAR2(60) 
		IxSYSTEM_YN =5,			// �ý��� �ڵ� ����	:VARCHAR2(1) 
		IxCOM_VALUE1 =6,			// �ڵ尪 1	:VARCHAR2(20) 
		IxCOM_DESC1 =7,			// �ڵ� ���� 1	:VARCHAR2(50) 
		IxCOM_VALUE2 =8,			// �ڵ尪 2	:VARCHAR2(20) 
		IxCOM_DESC2 =9,			// �ڵ� ���� 2	:VARCHAR2(50) 
		IxCOM_VALUE3 =10,			// �ڵ尪 3	:VARCHAR2(20) 
		IxCOM_DESC3 =11,			// �ڵ� ���� 3	:VARCHAR2(50) 
		IxCOM_VALUE4 =12,			// �ڵ尪 4	:VARCHAR2(20) 
		IxCOM_DESC4 =13,			// �ڵ� ���� 4	:VARCHAR2(50) 
		IxREMARKS =14,			// ���	:VARCHAR2(100) 
		IxUPD_USER =15,			// �ۼ���	:VARCHAR2(10) 
		IxUPD_YMD =16,			// �ۼ�����	:DATE(7) 
	}  



	/// <summary> 
	/// SPB_FACTORY ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSPB_FACTORY : int 
	{ 
		IxMaxCt = 7,		// �ε��� Count 
		IxFACTORY =1,			// �����ڵ�	:VARCHAR2(5) 
		IxFACTORY_NAME =2,			// �����	:VARCHAR2(20) 
		IxADDRESS =3,			// �ּ���	:VARCHAR2(60) 
		IxCAL_TYPE =4,			// ��ǥ ī���� Ÿ��	:VARCHAR2(10) 
		IxREMARKS =5,			// ���	:VARCHAR2(100) 
		IxUPD_USER =6,			// �ۼ���	:VARCHAR2(10) 
		IxUPD_YMD =7,			// �ۼ�����	:DATE(7) 
	}  


	/// <summary> 
	/// SPB_AREA ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSPB_AREA : int 
	{ 
		IxMaxCt = 9,		// �ε��� Count 
		IxFACTORY =1,			// ����	:VARCHAR2(5) 
		IxAREA_CD =2,			// �۾��� �ڵ�	:VARCHAR2(10) 
		IxAREA_NAME =3,			// �۾��� ��	:VARCHAR2(60) 
		IxCAL_TYPE =4,			// ��ǥ ī���� Ÿ��	:VARCHAR2(10) 
		IxAREA_DIV =5,			// �۾��� ���� (����, ����)	:VARCHAR2(10) 
		IxWORK_CHARGE =6,			// �۾� �����	:VARCHAR2(12) 
		IxREMARKS =7,			// ���	:VARCHAR2(100) 
		IxUPD_USER =8,			// �ۼ���	:VARCHAR2(10) 
		IxUPD_YMD =9,			// �ۼ�����	:DATE(7) 
	}  


	/// <summary> 
	/// SPB_NODE_AREA ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSPB_NODE_AREA : int 
	{ 
		IxMaxCt = 23,		// �ε��� Count 
		//		IxFACTORY =1,			// ����	:VARCHAR2(5) 
		IxAREA_CD =1,			// �۾��� �ڵ�	:VARCHAR2(10) 
		IxAREA_NAME =2,			// �۾����
		IxLEFT =3,			// ��� ���� ��ǥ	:VARCHAR2(10) 
		IxTOP =4,			// ��� �� ��ǥ	:VARCHAR2(10) 
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
		IxUPD_USER =22,			// �ۼ���	:VARCHAR2(10) 
		IxUPD_YMD =23,			// �ۼ�����	:DATE(7) 
	}  




	/// <summary> 
	/// SEM_SIZE ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_SIZE : int 
	{  
		IxMaxCt    = 12,		// �ε��� Count 
		lxFACTORY  =  1,        // ���� ����            :VARCHAR2(5) 
		IxGEN      =  2,		// â�� ����			:VARCHAR2(2) 
		IxPST_YN   =  3,		// PRESTO SIZE����		:VARCHAR2(1) 
		IxCS_SIZE  =  4,		// CHANG SHIN SIZE		:VARCHAR2(10) 
		IxUS_SIZE  =  5,		// AMERICA SIZE			:VARCHAR2(10) 
		IxUK_SIZE  =  6,		// UNITED KINGDOM SIZE	:VARCHAR2(10) 
		IxEU_SIZE  =  7,		// EUROPE SIZE			:VARCHAR2(10) 
		IxCM_SIZE  =  8,		// CENTIMETER SIZE		:NUMBER(22) 
		IxGEN_DESC =  9,		// GENDER DESCRIPTION	:VARCHAR2(20) 
		IxREMARKS  = 10,		// �ּ�					:VARCHAR2(50) 
		IxUPD_USER = 11,		// �������				:VARCHAR2(10) 
		IxUPD_YMD  = 12,		// �����				:DATE(7) 
	}  



	/// <summary> 
	/// SEM_REGION ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_REGION : int 
	{ 
		IxMaxCt        = 9,		// �ε��� Count 
		IxFACTORY      = 1,		// ���屸��   	:VARCHAR2(5) 
		IxREGION_CD    = 2,		// ����       	:VARCHAR2(7) 
		IxREGION       = 3,		// ����       	:VARCHAR2(7) 
		IxREGION_NAME  = 4,		// ������     	:VARCHAR2(15) 
		IxREGION_PRITY = 5,		// �༱��     	:NUMBER(22) 
		IxTYPE         = 6,		// TYPE       	:VARCHAR2(30) 
		IxREMARKS      = 7,		// �ּ�       	:VARCHAR2(50) 
		IxUPD_USER     = 8,		// �����     	:VARCHAR2(10) 
		IxUPD_YMD      = 9,		// �������   	:DATE(7) 
	}  


	/// <summary> 
	/// POI DBF ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_POI : int 
	{ 
		IxMaxCt      = 24,		 // �ε��� Count 
		lxFlag       = 0,        // [+], [-] check
		lxDiv        = 1,        // Division 
		lxStyle      = 2,        // ��Ÿ��üũ
		lxModel      = 3,        // ��üũ
		lxGender     = 4,        // ����üũ
		lxPresto     = 5,        // ��������üũ
		lxGSSC       = 6,        // GSSCüũ
		lxDest       = 7,        // Destüũ
		lxFACTORY    = 8,        // FACTORY
		lxPO_NU      = 9,        // PO No.
		lxITM_SEQ_NU = 10,        // Seq No.
		lxCHG_NU     = 11,        // CHANGE No.
		IxSTYLE      = 19,		 // ��Ÿ��		
		IxGEN        = 20,		 // GENDER
		IxPST_YN     = 21,		 // PRESTO
		IxDEST_PRITY = 23,		 // DEST PRITY
		IxDEST       = 24,		 // DEST		
		IxCUST_XREF  = 25,		 // DEST1
		IxWH         = 26,		 // DEST2
		lxSIZE_SCL   = 83,       // SIZE_SCL
		lxCS_SIZE    = 82,       // CS SIZE
		lxUS_SIZE    = 84,       // US SIZE
		lxTOT_QTY    = 57,       // TOTAL QTY
		lxORD_QTY    = 97,       // SIZE QTY
	}  

	/// <summary> 
	/// SEM_POI ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_POIS : int 
	{ 
		IxMaxCt      =  6,	// �ε��� Count 
		IxGPC_NU     =  8,	// GPC_NU        
		IxOBS_NU     =  9,	// DPO��ȣ       
		IxOBS_SEQ_NU = 10,	// DPO����   
		lxSIZE_SCL   = 77,       // SIZE_SCL
		lxTOT_QTY    = 52,       // TOTAL QTY
		lxORD_QTY    = 91,       // SIZE QTY    
	}  

	/// <summary> 
	/// SEM_TMP_POI ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_TMP_POI : int 
	{ 
		IxMaxCt      =  7,	// �ε��� Count 
		IxFACTORY    =  0,	// FACTORY
		IxOBS_NU     =  1,	// DPO��ȣ       
		IxOBS_SEQ_NU =  2,	// DPO����   
		lxSIZE_SCL   =  3,  // SIZE_SCL
		lxTOT_QTY    =  4,  // TOTAL QTY
		lxORD_QTY    =  5,  // SIZE QTY    
		lxCHG_NU     =  6,  // SEQUENCE NUMBER
	}  

	/// <summary> 
	/// SEM_STY ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_STY : int 
	{ 
		IxMaxCt = 11,		// �ε��� Count 
		IxFACTORY =1,		// ���屸��	:VARCHAR2(2) 
		IxSTYLE_CD =2,		// ��Ÿ�� �ڵ� 	:VARCHAR2(9) 
		IxGPC_NU =3,		// �����ڵ�	:VARCHAR2(2) 
		IxDIM =4,			// ġ��	:VARCHAR2(2) 
		IxSTYLE_LN =5,		// ��Ÿ�� - SHORT NAME	:VARCHAR2(30) 
		IxSTYLE_SN =6,		// ��Ÿ�� - LONG NAME	:VARCHAR2(15) 
		IxCOLOR_LN =7,		// Į�� - LONG NAME	:VARCHAR2(30) 
		IxCOLOR_SN =8,		// Į�� - SHORT NAME	:VARCHAR2(15) 
		IxREMARKS =9,		// �ּ�	:VARCHAR2(50) 
		IxUPD_USER =10,		// �����	:VARCHAR2(10) 
		IxUPD_YMD =11,		// �������	:DATE(7) 
	}  



	/// <summary> 
	/// SEM_EKKO_N ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_EKKO : int 
	{ 
		IxMaxCt = 26,		// �ε��� Count 
		IxFACTORY =1,			// 	:VARCHAR2(5) 
		IxOBS_NU =2,			// 	:VARCHAR2(10) 
		IxPO_ID =3,			// 	:VARCHAR2(8) 
		lxEBELN =4,
		IxBEDAT =5,			// 	:VARCHAR2(8) 
		IxBUKRS =6,			// 	:VARCHAR2(4) 
		IxEKORG =7,			// 	:VARCHAR2(4) 
		IxEKGRP =8,			// 	:VARCHAR2(3) 
		IxLIFN2 =9,			// 	:VARCHAR2(10) 
		IxBSART =10,			// 	:VARCHAR2(4) 
		IxWAERS =11,			// 	:VARCHAR2(5) 
		IxWKURS =12,			// 	:NUMBER(22) 
		IxINCO1 =13,			// 	:VARCHAR2(3) 
		IxINCO2 =14,			// 	:VARCHAR2(28) 
		IxAEDAT =15,			// 	:VARCHAR2(8) 
		IxERNAM =16,			// 	:VARCHAR2(12) 
		IxFFS_CHNG_DTTM =17,			// 	:VARCHAR2(8) 
		IxSNDPRN =18,			// 	:VARCHAR2(10) 
		IxZTERM =19,			// 	:VARCHAR2(4) 
		IxZZSESN_CD =20,			// 	:VARCHAR2(2) 
		IxZZSESN_YR =21,			// 	:VARCHAR2(4) 
		IxBUY_GRP_CD =22,			// 	:VARCHAR2(2) 
		IxLIFNR =23,			// 	:VARCHAR2(10) 
		IxFFS_VNDR_LOC_CD =24,			// 	:VARCHAR2(3) 
		lxUPD_USER =25,
		IxUPD_YMD =26,			// 	:DATE(7) 
	}  


	
	/// SEM_EKPO ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_EKPO : int 
	{ 
		IxMaxCt = 70,		// �ε��� Count 

		lxDiv =1,
		lxchkStyle =2,
		lxchkModel =3,
		lxchkGen   =4,
		lxchkPresto=5,
		lxchkGSSC  =6,
		lxchkDest  =7,
		lxchkEket  =8,
		IxFACTORY =9,			// 	:VARCHAR2(5) 
		IxOBS_NU =10,			// 	:VARCHAR2(10) 
		IxOBS_SEQ_NU =11,			// 	:VARCHAR2(10) 
		IxOBS_ID =12,			// 	:VARCHAR2(6) 
		IxDOC_YMD =13,			// 	:VARCHAR2(6) 
		IxMSR_DIV =14,			// 	:VARCHAR2(1) 
		IxLCH_DIV =15,			// 	:VARCHAR2(1) 
		IxEBELN =16,			// 	:VARCHAR2(10) 
		IxEBELP =17,			// 	:VARCHAR2(10) 
		IxMATNR =18,			// 	:VARCHAR2(18) 
		IxTXZ01 =19,			// 	:VARCHAR2(40) 
		IxBUKRS =20,			// 	:VARCHAR2(4) 
		IxWERKS =21,			// 	:VARCHAR2(4) 
		IxSPART =22,			// 	:VARCHAR2(2) 
		IxMENGE =23,			// 	:NUMBER(22) 
		IxMEINS =24,			// 	:VARCHAR2(3) 
		IxNETPR =25,			// 	:NUMBER(22) 
		IxNTGEW =26,			// 	:NUMBER(22) 
		IxEVERS =27,			// 	:VARCHAR2(2) 
		IxEVTXT =28,			// 	:VARCHAR2(30) 
		IxPSTYP =29,			// 	:VARCHAR2(1) 
		IxKNTTP =30,			// 	:VARCHAR2(1) 
		IxJ_3AEXFCP =31,			// 	:VARCHAR2(8) 
		IxZZ_GAC_DT =32,			// 	:VARCHAR2(8) 
		IxZZ_GAC_RSN_CD =33,			// 	:VARCHAR2(3) 
		IxFFS_GAC_DT_RQST =34,			// 	:VARCHAR2(8) 
		IxFFS_GAC_RSN_CD_RQST =35,			// 	:VARCHAR2(2) 
		IxFFS_GAC_SND_RQST_FL =36,			// 	:VARCHAR2(1) 
		IxBSTNK =37,			// 	:VARCHAR2(20) 
		IxVDATU =38,			// 	:VARCHAR2(8) 
		IxFKDAT =39,			// 	:VARCHAR2(8) 
		IxEINDT =40,			// 	:VARCHAR2(8) 
		IxSLFDT =41,			// 	:VARCHAR2(8) 
		IxMVGR2 =42,			// 	:VARCHAR2(3) 
		IxBSGRU =43,			// 	:VARCHAR2(3) 
		IxBISMT =44,			// 	:VARCHAR2(18) 
		IxZZ_SILH_CD =45,			// 	:VARCHAR2(4)  
		IxZZ_GNDRAGE =46,			// 	:VARCHAR2(4) 
		IxSOVBELN =47,			// 	:VARCHAR2(10) 
		IxSOVBELP =48,			// 	:NUMBER(22) 
		lxJ_4KSCAT =49,
		IxSO_CUST_DEPT =50,			// 	:VARCHAR2(10) 
		IxSO_CUST_DEPT_DESC =51,			// 	:NUMBER(22) 
		lxFFS_STENCIL_SHIP_TO =52,
		lxFFS_STENCIL_DEST  =53,
		lxFFS_STENCIL_ORIGIN =54,
		IxKUNNR =55,			// 	:VARCHAR2(10) 
		IxFFS_SHP_TO_ACCT =56,			// 	:VARCHAR2(10) 
		IxWAERS =57,			// 	:VARCHAR2(3) 
		IxPO_ITEM_STATUS =58,			// 	:VARCHAR2(2) 
		lxCOLORCOMBNAME  =59,    
		lxCOLORCOMBSHORTNAME  =60, 
		IxRGAC_YMD =61,			// 	:VARCHAR2(2) 
		IxOBS_DIV  =62,			// 	:VARCHAR2(2) 
		IxUPD_USER =63,			// 	:VARCHAR2(2) 
		IxUPD_YMD =64,			// 	:VARCHAR2(2) 
		lxTRADE_CO_PO_NU =65,			// 	:VARCHAR2(2) 
		lxTRADE_CO_PLANT =66,			// 	:VARCHAR2(2) 
		lxTRADE_CO_PLANT_DESC =67,			// 	:VARCHAR2(2) 
		lxUOM =68,			// 	:VARCHAR2(2) 
		lxTTMI =69,			// 	:VARCHAR2(2) 
		lxOBS_NU_REF =70,			// 	:VARCHAR2(2) 
		
			 

	}

	/// <summary> 
	/// SEM_UPC ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_UPC : int 
	{ 
		IxMaxCt			= 12,		// �ε��� Count 
	 
		IxFACTORY       = 1,
		IxOBS_ID		= 2,
		IxOBS_TYPE		= 3,
		IxDOC_YMD		= 4,
		IxSTYLE_CD		= 5,
		IxSTYLE_NAME	= 6,
		IxGEN	        = 7,
		IxPST_YN		= 8,
		IxOBS_NU		= 9,
		IxOBS_SEQ_NU	= 10,
		IxJOB_FLAG	    = 11,
	}  



	

	/// <summary> 
	/// SEM_OBS_GAC ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_GAC : int 
	{ 
		IxMaxCt = 12,		// �ε��� Count 

		lxOBS_NU     = 1,
		lxOBS_SEQ_NU = 2,
		lxDOC_YMD    = 3,
		lxSTYLE_CD   = 4,
		lxSTYLE_NAME = 5,
		lxDEV_CD     = 6,
		lxTOT_QTY    = 7,
		lxUOM        = 8,
		lxSHIP_TO    = 9,
		lxOGAC_YMD   = 10,
		lxRTS_YMD    = 11,
		lxJOB_DIV    = 12,


	}

	/// <summary> 
	/// SEM_EKET ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_EKET : int 
	{ 
		IxMaxCt = 23,		// �ε��� Count 
		IxFACTORY =1,			// 	:VARCHAR2(5) 
		IxOBS_NU =2,			// 	:VARCHAR2(10) 
		IxOBS_SEQ_NU =3,			// 	:VARCHAR2(10) 
		IxCS_SIZE =4,			// 	:VARCHAR2(10) 
		IxEBELN =5,			// 	:VARCHAR2(10) 
		IxEBELP =6,			// 	:VARCHAR2(10) 
		IxETENR =7,			// 	:VARCHAR2(5) 
		IxJ_3ASIZE =8,			// 	:VARCHAR2(8) 
		IxMENGE =9,			// 	:NUMBER(22) 
		IxMEINS =10,			// 	:VARCHAR2(3) 
		IxJ_3ANETP =11,			// 	:NUMBER(22) 
		IxKEBTR =12,			// 	:NUMBER(22) 
		IxEAN11 =13,			// 	:VARCHAR2(18) 
		IxJ_4KSCAT =14,			// 	:VARCHAR2(16) 
		IxEINDT =15,			// 	:VARCHAR2(8) 
		IxSLFDT =16,			// 	:VARCHAR2(8) 
		IxFFS_CHNG_DTTM =17,			// 	:VARCHAR2(8) 
		IxBAR_CODE =18,			// 	:VARCHAR2(9) 
		IxCHECK_DIGIT =19,			// 	:NUMBER(22) 
		lxFIRST_DIV  =20,
		lxOBS_DIV  =21,
		IxUPD_USER =22,			// 	:NUMBER(22) 
		IxUPD_YMD  =23,			// 	:NUMBER(22) 
	}  



	/// <summary> 
	/// SEM_MARA ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_MARA : int 
	{ 
		IxMaxCt = 26,		// �ε��� Count 
		IxFACTORY =1,			// 	:VARCHAR2(5) 
		IxSTYLE_CD =2,			// 	:VARCHAR2(9) 
		IxMATNR =3,			// 	:VARCHAR2(18) 
		IxMATERIALNAME =4,			// 	:VARCHAR2(45) 
		IxMATERIALSHORTNAME =5,			// 	:VARCHAR2(45) 
		IxCOLORCOMBNAME =6,			// 	:VARCHAR2(100) 
		IxCOLORCOMBSHORTNAME =7,			// 	:VARCHAR2(45) 
		IxDIVISION =8,			// 	:VARCHAR2(10) 
		IxCATEGORY =9,			// 	:VARCHAR2(10) 
		IxCATEGORYNAME =10,			// 	:VARCHAR2(45) 
		IxSUBCATEGORY =11,			// 	:VARCHAR2(10) 
		IxSUBCATEGORYNAME =12,			// 	:VARCHAR2(45) 
		IxGENDERAGE =13,			// 	:VARCHAR2(10) 
		IxGENDERAGENAME =14,			// 	:VARCHAR2(45) 
		IxFIRSTPRODUCTOFFER_DTTM =15,			// 	:VARCHAR2(8) 
		IxENDFUTUREOFFER_DTTM =16,			// 	:VARCHAR2(8) 
		IxENDPRODUCTOFFER_DTTM =17,			// 	:VARCHAR2(8) 
		IxWIDTH =18,			// 	:VARCHAR2(1) 
		IxMATERIALCONTENT =19,			// 	:VARCHAR2(140) 
		IxOUTSOLE =20,			// 	:VARCHAR2(45) 
		IxFFS_TEXTILE_CAT =21,			// 	:VARCHAR2(10) 
		IxFFS_CRTN_TYP =22,			// 	:VARCHAR2(4) 
		IxFFS_PACK_FACTOR =23,			// 	:NUMBER(22) 
		IxFFS_CHNG_DTTM =24,			// 	:VARCHAR2(8) 
        lxUPD_USER =25,
		IxUPD_YMD =26,			// 	:DATE(7) 
	}  



	/// <summary> 
	/// SEM_CRTN ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_CRTN : int 
	{ 
		IxMaxCt = 13,		// �ε��� Count 
		IxVENUM = 1,
		IxEXIDV = 2,
		IxFFS_CRTN_TYP = 3,
		IxFFS_CRTN_PRTD_FL= 4,
		IxLIFNR= 5,
		IxFFS_CHNG_DTTM= 6,
		IxVEPOS = 7,
		IxFFS_CRTN_QTY= 8,
		IxEBELN= 9,
		IxEBELP= 10,
		IxETENR= 11,
		lxUPD_USER =12,
		lxUPD_YMD =13,
	}  


	/// <summary> 
	/// SEM_CRTNH ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_CRTNH : int 
	{ 
		IxMaxCt = 6,		// �ε��� Count 
		IxFACTORY =1,			// 	:VARCHAR2(5) 
		IxUCC_NU =2,			// 	:VARCHAR2(5)  
		IxEBELN =3,			// 	:VARCHAR2(9) 
		IxEBELP =4,			// 	:DATE(7) 
		lxUPD_USER =5,
		lxUPD_YMD =6,
	}  


	/// <summary> 
	/// SEM_CRTNI ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_CRTNI : int 
	{ 
		IxMaxCt = 8,		// �ε��� Count 
		IxFACTORY =1,			// 	:VARCHAR2(5) 
		IxUCC_NU =2,			// 	:VARCHAR2(5)  
		IxCRTN_QTY =3,			// 	:VARCHAR2(10) 
		IxEBELN =4,			// 	:VARCHAR2(9) 
		IxEBELP =5,			// 	:DATE(7) 
		IxETENR =6,			// 	:DATE(7) 
		lxUPD_USER =7,
		lxUPD_YMD =8,
	}  



	/// <summary> 
	/// SEM_REQ ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_REQ : int 
	{ 
		IxMaxCt      = 6,	// �ε��� Count 
		lxFLAG       = 1,	// �۾�
		IxFACTORY    = 2,	// ���屸��             		:VARCHAR2(5) 
		IxREQ_NO     = 3,	// �����Ƿ� ����      			:VARCHAR2(11) 
		IxOBS_NU     = 4,	// OBS ��ȣ           			:VARCHAR2(10) 
		IxOBS_SEQ_NU = 5,	// OBS ����            			:VARCHAR2(10) 
		lxCHG_NU     = 6,	// OBS �������        			:VARCHAR2(10) 
		lxPLAN_DIV   =28,	//���� ��ȹ �ݿ�����        	:VARCHAR2(1) 
	}  

	/// <summary> 
	/// SEM_CAL_INFO ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_CAL_INFO : int 
	{ 
		IxMaxCt = 16,		// �ε��� Count 
		IxFACTORY =1,		// FACTORY
		IxSEASON_CD  =2,		// SEASON           	:VARCHAR2(6) 
		IxTCMMT_YMD =3,		// TIMME COMMIT WEEK	:VARCHAR2(8) 
		IxECMMT_YMD =4,		// EVENT COMMIT WEEK	:VARCHAR2(8) 
		IxLLTMAT_DATE =5,	// LLT ���� ��û��  	:VARCHAR2(8) 
		IxOBS_ID =6,		// OBS ����         	:VARCHAR2(6) 
		IxBP_NO =7,			// BP NO            	:VARCHAR2(8) 
		lxECMMT_OBS_ID = 8, // Event Commit OBS ID
		IxGAC_YMD =9,		// 	:VARCHAR2(8) 
		IxPO_CUTOFF =10,		// PO CUT OFF
		IxLATE_USA =11,		// PO CUT OFF (USA) 	:VARCHAR2(8) 
		IxLATE_NEON =12,	// NEON  PO CUT OFF 	:VARCHAR2(8) 
		IxDEL_MONTH =13,	// ����ǰ ��� �Ⱓ 	:VARCHAR2(8) 
		IxSALES_MONTH =14,	// ����ǰ �Ǹ� �Ⱓ 	:VARCHAR2(8) 
		IxOBS_RCPT_YMD =15,	// OBS ������       	:VARCHAR2(8) 
		IxSET_COLOR =16,	// Į����         	:VARCHAR2(11) 
	}

	/// <summary> 
	/// SEM_BP ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_BP : int 
	{ 
		IxMaxCt = 38,			// �ε��� Count 
		lxStyle      = 1,        // ��Ÿ��üũ
		lxModel      = 2,        // ��üũ
		lxGender     = 3,        // ����üũ
		lxPresto     = 4,        // ��������üũ
		lxGSSC       = 5,        // GSSCüũ
		lxRegion     = 6,        // Destüũ
		IxFACTORY	 = 7,			// ���屸��    					:VARCHAR2(2) 
		IxSTYLE_CD =8,			// ��Ÿ�� �ڵ� 					:VARCHAR2(9) 
		IxSTYLE_NAME =9,		// STYLE ��                   	:VARCHAR2(60) 
		IxDEL_MONTH =10,			// ��ۿ�						:VARCHAR2(8) 
		IxREGION =11,			// REGION      					:VARCHAR2(7) 
		IxBP_NO =12,				// LASTING WEEK					:VARCHAR2(8) 
		IxPRD_QTY =13,			// ��������    					:NUMBER(22) 
		IxBTO_DT =14,			// 								:VARCHAR2(8) 		
		IxFACTORY_GRP =15,		// ù��° OUTSOLE             	:VARCHAR2(3) 
		IxOUT_SOLE_01 =16,		// ù��° MIDSOLE             	:VARCHAR2(10) 
		IxMID_SOLE_01 =17,		// �����ڵ�                   	:VARCHAR2(10) 
		IxDEV_CD =18,			// �����ڵ�                   	:VARCHAR2(6) 
		IxPROD_ID =19,			// ���� GROUP                 	:VARCHAR2(13) 
		IxFACTORY_CTRY_CD =20,	// ���� ���� CODE             	:VARCHAR2(4) 
		IxPG_DEV_FCTY =21,		// ���� ���� CODE             	:VARCHAR2(2) 
		IxIPW =22,				// ���� ���� ������           	:VARCHAR2(8) 
		IxAIRBAG_01 =23,		// ù��° AIRBAG              	:VARCHAR2(10) 
		IxAIRBAG_02 =24,		// �ι�° AIRBAG              	:VARCHAR2(10) 
		IxAIRBAG_03 =25,		// ����° AIRBAG              	:VARCHAR2(10) 
		IxPROD_LINE_CD =26,		// ������� CODE              	:VARCHAR2(10) 
		IxPROD_LINE_DESC =27,	// ������� ����            	:VARCHAR2(2) 
		IxPROD_CAT_CD =28,		// ����ǰ CATEGORY CODE       	:VARCHAR2(30) 
		IxPROD_CAT_DESC =29,	// ����ǰ CATEGORY ����     	:VARCHAR2(2) 
		IxNIKE_GEN_DESC =30,	// ���� ����                	:VARCHAR2(30) 
		IxTYPE_GROUP_NAME =31,	// ���� ����                  	:VARCHAR2(20) 
		IxLAST_CD =32,			// LAST CODE                  	:VARCHAR2(8) 
		IxTOOL_WK_CAP =33,		// �ֺ� TOOLING CAPACITY      	:NUMBER(22) 
		IxREMARKS =34,			// ��   ��						:VARCHAR2(50) 
		IxDOWN_YMD =35,			//
		IxERROR_YN =36,			// 
		IxUPD_USER =37,			//
		IxUPD_YMD =38,			// 
	}  


	/// <summary> 
	/// SEM_BP ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_BP : int 
	{ 
		IxMaxCt = 16,		// �ε��� Count 
		IxFACTORY =1,		// FACTORY
		IxDEL_MONTH  =2,	// DEL_MONTH
		IxSTYLE_CD =3,		// STYLE_CD
		IxREGION =4,		// REGION
		IxBP_NO =5,			// BP_NO
		IxPRD_QTY =6,		// PRD_QTY
		IxTOT_QTY =7,		// TOT_QTY
		IxCS_QTY =8,		// CS_QTY
		IxSTYLE_YN =9,		// STYLE_YN
		IxGEN_YN =10,		// GEN_YN
		IxPST_YN =11,		// PST_YN
		IxREGION_NM =12,	// REGION_NAME
		IxJOB_DIV =13,	    // JOB_DIV
		IxSTYLE_NAME =14,	// STYLE_NAME
		IxGEN =15,	   	    // GENDER
		IxPRESTO =16,		// PST_YN
	}

	/// <summary> 
	/// SEM_OBS_CS ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_CS : int 
	{ 
		IxMaxCt = 28,		// �ε��� Count 
		IxFACTORY =1,		// FACTORY
		IxOBS_ID  =2,	    // DEL_MONTH
		IxREQ_YN =3,	    // REQUEST Y/N
		IxSTYLE_CD =4,		// STYLE_CD
		IxREGION =5,		// REGION
		IxDEST =6,		// REGION
		IxBP_NO =7,			// BP_NO
		IxCS_QTY =8,		// CS QTY
		lxBP_QTY = 9,       // BP_QTY
		lxCS_TOT_QTY = 10,   // TOTAL(CS_QTY)
		IxOBS_NU =11,		// TOT_QTY
		IxOBS_SEQ_NU =12,	// CS_QTY
		IxCHG_NU =13,		// STYLE_YN
		IxJOB_DIV =14,		// GEN_YN
		IxOBS_TYPE =15,		// PST_YN
		IxGEN =16,	        // REGION_NAME
		IxPST_YN =17,	    // JOB_DIV
		IxOA_NU_BEF =18,	    // OGAC_YMD
		IxOA_NU_AFT =19,	    // OGAC_YMD
		IxOGAC_YMD =20,	    // OGAC_YMD
		IxRTS_YMD =21,	    // 
		IxCSETS_YMD =22,	// GENDER
		IxCSETS_RSN =23,	// GENDER
		IxSEASON =24,	// PST_YN
		IxYEAR =25,	// PST_YN		
		IxREGION_NM =26,	// REGION_NAME
		IxDEST_NM =27,	// REGION_NAME
		IxSTYLE_NM =28,	    // STYLE_NAME
		IxSYMD =29,	    // REQUEST Y/N
		IxUB_DIV =30,	   
	}



	


	/// <summary> 
	/// TBSEM_OBS_CS_MUTI ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_CS_MUTI : int 
	{ 
		IxMaxCt = 30,		// �ε��� Count 

		lxCHECK       =1,
		lxFACTORY    =2,
		lxDEL_MONTH  =3,
		lxSTYLE_CD   =4,
		lxREGION     =5,
		lxBP_NO      =6,
		lxCS_QTY     =7,
		lxPRD_QTY    =8,
		lxTOT_QTY    =9,
		lxSTYLE_YN   =10,
		lxGEN_YN     =11,
		lxPST_YN     =12,
		lxGSSC       =13,
		lxREGION_NM  =14,
		lxJOB_DIV    =15,
		lxRESULT     =16,


	}

	/// <summary> 
	/// SEM_OBS_POP ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_POP : int 
	{ 
		IxMaxCt = 35,		// �ε��� Count 
		IxFACTORY =1,			// �����ڵ�	:VARCHAR2(5) 
		IxOBS_NU =2,			// OBS��ȣ	:VARCHAR2(10) 
		IxOBS_SEQ_NU =3,			// OBS����	:VARCHAR2(10) 
		IxCHG_NU =4,			// �������	:VARCHAR2(5) 
		IxSYMD =5,			// ������	:VARCHAR2(8) 
		IxEYMD =6,			// ����	:VARCHAR2(8) 
		IxOBS_DIV =7,			// GPO/DPO����	:VARCHAR2(1) 
		IxDOC_YMD =8,			// ISSUEDATE	:VARCHAR2(8) 
		IxOBS_ID =9,			// OBSID	:VARCHAR2(6) 
		IxOBS_TYPE =10,			// OBSŸ��	:VARCHAR2(2) 
		IxSTYLE_CD =11,			// ��Ÿ���ڵ�	:VARCHAR2(9) 
		IxGEN =12,			// ����	:VARCHAR2(2) 
		IxPST_YN =13,			// �������䱸��	:VARCHAR2(1) 
		IxREQ_YN =14,			// �����Ƿڱ���	:VARCHAR2(1) 
		IxOA_NU_BEF =15,			// ����OA��ȣ	:VARCHAR2(10) 
		IxOA_NU_AFT =16,			// ����OA��ȣ	:VARCHAR2(10) 
		IxDEST_PRITY =17,			// �༱���켱����	:VARCHAR2(3) 
		IxDEST =18,			// �༱��	:VARCHAR2(7) 
		IxCUST_XREF =19,			// ����û��	:VARCHAR2(7) 
		IxWH =20,			// â��	:VARCHAR2(7) 
		IxISEG =21,			// ISEG	:VARCHAR2(3) 
		IxTOT_QTY =22,			// �ѿ�������	:NUMBER(22) 
		IxOGAC_YMD =23,			// OGAC_DATE	:VARCHAR2(8) 
		IxRTS_YMD =24,			// RTS��	:VARCHAR2(8) 
		IxCSETS_YMD =25,			// CSETS_DATE	:VARCHAR2(8) 
		IxCSETS_RSN =26,			// CSETS_REASON	:VARCHAR2(30) 
		IxCUS_REQ_YMD =27,			// CUSTOMERREQUESTDATE	:VARCHAR2(8) 
		IxDELIV_YMD =28,			// DELIVERY_DATE	:VARCHAR2(8) 
		IxSTA_DELIV_YMD =29,			// STATIC_DELIVERY_DATE	:VARCHAR2(8) 
		IxMSR_DIV =30,			// MUSICALPACKING����	:VARCHAR2(1) 
		IxCRTN_QTY =31,			// CARTON����	:NUMBER(22) 
		IxTOTCRTN_QTY =32,			// ��CARTON����	:NUMBER(22) 
		IxREMARKS =33,			// ���	:VARCHAR2(100) 
		IxUPD_USER =34,			// �ۼ���	:VARCHAR2(30) 
		IxUPD_YMD =35,			// �ۼ���	:DATE(7) 

	}


	
	/// <summary> 
	/// SEM_OBS_POP ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_CSOBS_POP : int 
	{ 
		IxMaxCt = 26,		// �ε��� Count 
		IxFACTORY =1,			// �����ڵ�	:VARCHAR2(5) 
		IxOBS_NU =2,			// OBS��ȣ	:VARCHAR2(10) 
		IxOBS_SEQ_NU =3,			// OBS����	:VARCHAR2(10) 
		IxCHG_NU =4,			// �������	:VARCHAR2(5) 
		IxSYMD =5,			// ������	:VARCHAR2(8) 
		IxEYMD =6,			// ����	:VARCHAR2(8) 
		IxOBS_DIV =7,			// GPO/DPO����	:VARCHAR2(1) 
		IxJOB_DIV =8,			// �۾�����	:VARCHAR2(2) 
		IxBP_NO =9,			// BP��ȣ(����)	:VARCHAR2(8) 
		IxREGION =10,			// ��������	:VARCHAR2(7) 
		IxOBS_ID =11,			// OBSID	:VARCHAR2(6) 
		IxOBS_TYPE =12,			// OBSŸ��	:VARCHAR2(2) 
		IxSTYLE_CD =13,			// ��Ÿ���ڵ�	:VARCHAR2(9) 
		IxGEN =14,			// ����	:VARCHAR2(2) 
		IxPST_YN =15,			// �������䱸��	:VARCHAR2(1) 
		IxREQ_YN =16,			// �����Ƿڱ���	:VARCHAR2(1) 
		IxOA_NU_BEF =17,			// ����OA��ȣ	:VARCHAR2(10) 
		IxOA_NU_AFT =18,			// ����OA��ȣ	:VARCHAR2(10) 
		IxTOT_QTY =19,			// �ѿ�������	:NUMBER(22) 
		IxOGAC_YMD =20,			// OGAC_DATE	:VARCHAR2(8) 
		IxRTS_YMD =21,			// RTS��	:VARCHAR2(8) 
		IxCSETS_YMD =22,			// CSETS_DATE	:VARCHAR2(8) 
		IxCSETS_RSN =23,			// CSETS_REASON	:VARCHAR2(30) 
		IxREMARKS =24,			// ���	:VARCHAR2(100) 
		IxUPD_USER =25,			// �ۼ���	:VARCHAR2(30) 
		IxUPD_YMD =26,			// �ۼ���	:DATE(7) 

	}







	/// <summary> 
	/// SEM_OBS_CS_SIZE ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_CS_SIZE : int
	{
		IxMaxCt = 27,		// �ε��� Count 
		IxFACTORY = 1,		// ���屸��           	:VARCHAR2(5) 
		IxSTYLE_CD = 2,		// ��Ÿ���ڵ�         	:VARCHAR2(9) 
		IxSTYLE_NM = 3,		// ��Ÿ���ڵ�         	:VARCHAR2(9) 
		lxFLAG = 4,
		lxREQ_NO = 5,
		lxREQ_SEQ_NU = 6,
		IxOBS_NU = 7,		// OBS ��ȣ           	:VARCHAR2(10) 
		IxOBS_SEQ_NU = 8,	// OBS ����           	:VARCHAR2(10) 
		IxCHG_NU = 9,		// �������           	:VARCHAR2(5) 
		lxJOB_ID = 10,
		lxPLAN_DIV = 11,      //���� ��ȹ �ݿ�����    :VARCHAR2(1) 
		IxOBS_DIV = 12,
		lxCS_REQ = 13,
		IxOBS_ID = 14,		// OBS ID             	:VARCHAR2(6) 
		IxOBS_TYPE = 15,		// OBS TYPE           	:VARCHAR2(2) 
		IxPST_YN = 16,		// �������䱸��       	:VARCHAR2(1) 
		IxREQ_YN = 17,		// �������䱸��       	:VARCHAR2(1) 
		IxOA_NU_BEF = 18,		// �������䱸��       	:VARCHAR2(1) 
		IxOA_NU_AFT = 19,		// �������䱸��       	:VARCHAR2(1) 
		IxREGION = 20,		// ����               	:VARCHAR2(7) 
		IxRTS_YMD = 21,		// RTS DATE/OGAC_DATE 	:VARCHAR2(8) 
		IxCSETS_YMD = 22,	// CSETS_DATE/GAC_DATE	:VARCHAR2(8) 
		IxCSETS_RSN = 23,	// GAC REASON         	:VARCHAR2(30) 
		lxREQ_YMD = 24,
		lxOLD_REQ_NO = 25,
		IxTOT_QTY = 26,		// �ѿ�������         	:NUMBER(22) 
		IxGEN = 27,			// GAC REASON         	:VARCHAR2(30) 



	}



	/// <summary> 
	/// TBSEM_STYLE ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_STYLE : int 
	{ 
		IxMaxCt = 62,		    // �ε��� Count 
		IxFACTORY =1,			// ���屸��                   	:VARCHAR2(5) 
		IxSTYLE_CD =2,			// STYLE ����                 	:VARCHAR2(9) 
		IxSTYLE_NAME =3,		// STYLE ��                   	:VARCHAR2(60) 
		IxFACTORY_GRP =4,		// ù��° OUTSOLE             	:VARCHAR2(3) 
		IxOUT_SOLE_01 =5,		// ù��° MIDSOLE             	:VARCHAR2(10) 
		IxMID_SOLE_01 =6,		// �����ڵ�                   	:VARCHAR2(10) 
		IxDEV_CD =7,			// �����ڵ�                   	:VARCHAR2(6) 
		IxPROD_ID =8,			// ���� GROUP                 	:VARCHAR2(13) 
		IxFACTORY_CTRY_CD =9,	// ���� ���� CODE             	:VARCHAR2(4) 
		IxPG_DEV_FCTY =10,		// ���� ���� CODE             	:VARCHAR2(2) 
		IxIPW =11,			    // ���� ���� ������           	:VARCHAR2(8) 
		IxAIRBAG_01 =12,		// ù��° AIRBAG              	:VARCHAR2(10) 
		IxAIRBAG_02 =13,		// �ι�° AIRBAG              	:VARCHAR2(10) 
		IxAIRBAG_03 =14,		// ����° AIRBAG              	:VARCHAR2(10) 
		IxPROD_LINE_CD =15,		// ������� CODE              	:VARCHAR2(2) 
		IxPROD_LINE_DESC =16,	// ������� ����            	:VARCHAR2(10) 
		IxPROD_CAT_CD =17,		// ����ǰ CATEGORY CODE       	:VARCHAR2(2) 
		IxPROD_CAT_DESC =18,	// ����ǰ CATEGORY ����     	:VARCHAR2(30) 
		IxNIKE_GEN_DESC =19,	// ���� ����                	:VARCHAR2(30) 
		IxTYPE_GROUP_NAME =20,	// ���� ����                  	:VARCHAR2(20) 
		IxLAST_CD =21,			// LAST CODE                  	:VARCHAR2(8) 
		IxTOOL_WK_CAP =22,		// �ֺ� TOOLING CAPACITY      	:NUMBER(22) 
		IxSEASON_CD =23,			// SEASON                     	:VARCHAR2(2) 
		IxYEAR =24,			    // ���� �⵵                  	:VARCHAR2(4) 
		IxTD_CD =25,			// 	:VARCHAR2(2) 
		IxFIRM_IPW =26,			// Ȯ�� IPW                   	:VARCHAR2(8) 
		IxCURR_IPW =27,			// ���� IPW                   	:VARCHAR2(8) 
		IxIPM =28,			    // 	:VARCHAR2(10) 
		IxOUT_SOLE_02 =29,		// �ι�° OUTSOLE             	:VARCHAR2(10) 
		IxMID_SOLE_02 =30,		// �ι�° MIDSOLE             	:VARCHAR2(10) 
		IxOUT_SOLEMAT_01 =31,	// ù��° OUTSOLE ����        	:VARCHAR2(2) 
		IxMID_SOLEMAT_01 =32,	// ù��° MIDSOLE ����        	:VARCHAR2(2) 
		IxOUT_SOLEMAT_02 =33,	// �ι�° OUTSOLE����         	:VARCHAR2(2) 
		IxMID_SOLEMAT_02 =34,	// �ι�° MIDSOLE ����        	:VARCHAR2(2) 
		IxPRICE =35,			// �ҸŰ�                     	:NUMBER(22) 
		IxCONSMR_NAME =36,		// �Һ��ڸ�                   	:VARCHAR2(30) 
		IxRFC_DATE =37,			// ���� Ȯ�� ����             	:VARCHAR2(8) 
		IxCLT =38,			    // 	:VARCHAR2(20) 
		IxERST_SPEC_STATUS =39,	// ����  SPEC����             	:VARCHAR2(1) 
		IxERST_SPEC_CREATE =40,	// ���� SPEC ������           	:VARCHAR2(8) 
		IxBVTN_DEV =41,			// BIVELTON ������            	:VARCHAR2(20) 
		IxASIA_DEV =42,			// ASIA ������                	:VARCHAR2(20) 
		IxSPRT_ACT_CD =43,		// SPORT CATEGORY CODE        	:VARCHAR2(30) 
		IxSPRT_ACT =44,			// SPORT CATEGORY             	:VARCHAR2(20) 
		IxKEY_MODEL =45,		// 	:VARCHAR2(10) 
		IxMFG_CHAR_01 =46,		// 	:VARCHAR2(10) 
		IxMFG_CHAR_02 =47,		// 	:VARCHAR2(10) 
		IxSILHOUETTE =48,		// �Ƿ翧                     	:VARCHAR2(30) 
		IxCOLOR_DESC =49,		// COLOR ����                 	:VARCHAR2(30) 
		IxCONST_CD =50,			// 	:VARCHAR2(2) 
		IxSTYLE_GRP =51,		// COLOR GROUP                	:VARCHAR2(6) 
		IxPRD_TYPE =52,			// ����ǰ TYPE                	:VARCHAR2(10) 
		IxPRD_TYPE_GRP =53,		// ����ǰ TYPE GROUP          	:VARCHAR2(30) 
		IxWHLSL_PRICE =54,		// 	:NUMBER(22) 
		IxSIZE_RANGE =55,		// SIZE ����                  	:VARCHAR2(20) 
		IxCOLOR_VAR =56,		// 	:VARCHAR2(10) 
		IxLIFE_CYCLE =57,		// LIFE CYCLE                 	:VARCHAR2(10) 
		IxDUTY_RT_CD =58,		// 	:VARCHAR2(10) 
		IxBP_DATE =59,			// BP ������                  	:VARCHAR2(8) 
		IxREMARKS =60,			// �ּ�                       	:VARCHAR2(50) 
		IxUPD_USER =61,			// �����                     	:VARCHAR2(10) 
		IxUPD_YMD =62,			// �������                   	:DATE(7) 
	}  

	/// <summary> 
	/// SEM_BP ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_BP_SEARCH : int 
	{   
        IxMaxCt      = 8,
		lxDEV_CD     = 1,      
		lxSTYLE_CD   = 2,    
		lxSTYLE_NAME = 3,  
		lxFACTORY    = 4,   
	    lxOUT_SOLE_01= 5, 
	    lxTOT_QTY    = 6, 
		lxBP_NO      = 7,   	  
		lxPRD_QTY    = 8,
     
//		IxMaxCt = 21,		// �ε��� Count 
//		IxFACTORY_GRP =1,	// ���屸��    	:VARCHAR2(2) 
//		IxFACTORY =2,		// ���屸��    	:VARCHAR2(2) 
//		lxOUT_SOLE_01 =3,   // OS1
//		lxDEV_CD =4,        // �����ڵ� 
//		IxSTYLE_CD =5,		// ��Ÿ�� �ڵ� 	:VARCHAR2(9) 
//		lxPROD_ID=6,        // PROD_ID
//		IxSTYLE_NAME =7,	// ��Ÿ�� �� 	:VARCHAR2(9) 
//		IxREGION =8,		// REGION      	:VARCHAR2(7) 
//		IxBTO_DT =9,		// 	:VARCHAR2(8) 
//		IxDEL_MONTH =10,	// ��ۿ�      	:VARCHAR2(8) 
//		IxBP_NO =11,		// LASTING WEEK	:VARCHAR2(8) 
//		IxPRD_QTY =12,		// ��������    	:NUMBER(22) 
//		IxBP_NU =13,		// BP��ȣ      	:VARCHAR2(10) 
//		IxBP_SEQ_NU =14,	// BP����      	:VARCHAR2(10) 
//		IxCHG_NU =15,		// �������    	:VARCHAR2(5) 
//		IxSYMD =16,			// ��������    	:VARCHAR2(8) 
//		IxEYMD =17,			// ������      	:VARCHAR2(8) 
//		IxDOWN_YMD =18,		// ���ϴٿ�����	:VARCHAR2(8) 
//		IxREMARKS =19,		// ��   ��     	:VARCHAR2(50) 
//		IxUPD_USER =20,		// �ۼ���      	:VARCHAR2(10) 
//		IxUPD_YMD =21,		// �ۼ�����    	:DATE(7) 

	}  

	/// <summary> 
	/// SEM_OBS ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_Search : int 
	{ 
		IxMaxCt = 20,		// �ε��� Count 
		IxSTYLE_CD =1,		// ��Ÿ�ϱ���	:VARCHAR2(9) 
		IxSTYLE_NAME =2,		// ��Ÿ�ϱ���	:VARCHAR2(9) 
		IxOBS_ID =3,		// OBS ID	:VARCHAR2(6) 
		IxOBS_TYPE =4,		// ���� Ÿ��	:VARCHAR2(2) 
		IxOBS_NU =5,		// OBS ��ȣ	:VARCHAR2(10) 
		IxOBS_SEQ_NU =6,	// OBS ����	:VARCHAR2(10) 
		IxCHG_NU =7,		// �������	:VARCHAR2(5) 
		IxOBS_DIV =8,		// GPO/DPO ����	:VARCHAR2(1) 
		IxPST_YN =9,		// PRESTO����	:VARCHAR2(1) 
		IxREQ_YN =10,		// REQ����	:VARCHAR2(1) 
		IxOA_NU_BEF =11,	// OA NU - BEFORE	:VARCHAR2(10) 
		IxOA_NU_AFT =12,	// OA NU - AFTER	:VARCHAR2(10) 
		lxREGION = 13,      //REGION
		IxOGAC_YMD =14,		// RTS DATE/OGAC_DATE	:VARCHAR2(8) 
		IxRTS_YMD =15,		// RTS DATE/OGAC_DATE	:VARCHAR2(8) 
		IxCSETS_YMD =16,	// CSETS_DATE/GAC_DATE	:VARCHAR2(8) 
		IxCSETS_RSN =17,	// GAC REASON	:VARCHAR2(30) 
		IxMSR_DIV =18,		// �ѿ�������	:NUMBER(22) 
		IxTOT_QTY =19,		// �ѿ�������	:NUMBER(22) 
		IxGEN =20,			// ����	:VARCHAR2(2) 
	}  



	

	/// <summary> 
	/// SEM_GSSC_SIMULATION ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_GSSC_SIMULATION: int 
	{ 

		IxMaxCt = 9,		// �ε��� Count 
		IxFACTORY =1,		// ��Ÿ�ϱ���	:VARCHAR2(9) 
		IxCATEGORY_CD =2,		// ��Ÿ�ϱ���	:VARCHAR2(9) 
		IxCATEGORY_NAME =3,		// OBS ID	:VARCHAR2(6) 
		IxMODEL_CD =4,		// ���� Ÿ��	:VARCHAR2(2) 
		IxMODEL_NAME =5,
		IxREGON_CD =6,		// OBS ��ȣ	:VARCHAR2(10) 
		IxGENDER =7,	// OBS ����	:VARCHAR2(10) 
		IxCS_SIZE =8,		// �������	:VARCHAR2(5) 
		IxSIZE_QTY =9,		// GPO/DPO ����	:VARCHAR2(1) 
		
	}  


	/// <summary> 
	/// SEM_GSSC_SIMULATION_TAIL ���̺� �ε��� Enum 
	/// </summary> 
	public enum SEM_GSSC_SIMULATION_TAIL: int 
	{ 

		IxMaxCt = 10,		// �ε��� Count 
		IxFACTORY =1,		// ��Ÿ�ϱ���	:VARCHAR2(9) 
		IxREGION =2,		// ��Ÿ�ϱ���	:VARCHAR2(9) 
		IxSTYLE_CD =3,		// OBS ID	:VARCHAR2(6) 
		IxSTYLE_NAME =4,		// ���� Ÿ��	:VARCHAR2(2) 
		IxOBS_NU =5,		// OBS ��ȣ	:VARCHAR2(10) 
		IxOBS_SEQ_NU =6,	// OBS ����	:VARCHAR2(10) 
		IxDEST =7,		// �������	:VARCHAR2(5) 
		IxGENDER =8,		// GPO/DPO ����	:VARCHAR2(1) 
		IxCS_SIZE =9,		// GPO/DPO ����	:VARCHAR2(1) 
		IxSIZE_QTY =10,		// GPO/DPO ����	:VARCHAR2(1) 

	

	} 


	




	/// <summary> 
	/// Weekly Order
	/// </summary> 
	public enum TBSEM_BP_WEEK : int 
	{ 
		IxMaxCt     =9,
		lxFACTORY   =1 ,
		lxBP_NO		=2 ,
		lxDPO_ID	=3 ,
		lxSTYLE_CD	=4 ,
		lxSTYLE_NAME=5 ,
		lxMPS_QTY	=6 ,
		lxGEN		=7,
		lxCS_SIZE	=8,
		lxORD_QTY	=9,
	} 


	
	/// <summary> 
	/// Lasting Week vs OBS
	/// </summary> 
	public enum TBSEM_WEEK_OBS : int 
	{ 
		IxMaxCt     =11,
		lxSTYLE_CD     =1 ,
		lxJOB_DIV	   =2 ,
		lxOBS_ID	   =3 ,
		lxDEST		   =4 ,
		lxOBS_NU	   =5 ,
		lxOBS_SEQ_NU   =6 ,
		lxREMARK	   =7,
		lxTOT_QTY	   =8,
		lxGEN          =9,
		lxCS_SIZE	   =10,
		lxORD_QTY      =11,

	
	} 



	/// <summary> 
	/// Order Monitoring 
	/// </summary> 
	public enum TBSEM_MNT : int 
	{ 
		IxMaxCt       =23,
		IxFACTORY     =1 ,
		IxOBS_ID      =2 ,
		IxOBS_TYPE    =3 ,
		IxMOD_CD      =4 ,
		IxSTYLE_CD    =5 ,
		IxOBS_NU      =6 ,			
		IxOBS_SEQ_NU  =7,		
		IxCHG_NU      =8,		
        IxDEST        =9,		
        IxRTS_YMD     =10,		
		IxORD_QTY     =11,		
		lxREQ_NO      =12,	
		lxPRD_QTY     =13,	
		lxREQ_ORD_QTY =14,		
		lxLOSS_QTY    =15,	
		lxPO_NO       =16,	
		IxCLOSE_YN    =17,		
		IxLOT_NO      =18,		
		IxLOT_SEQ     =19,	  
		IxLOT_QTY     =20,		
		lxLINE_CD     =21,   
		IxLINE_QTY    =22,	
		IxLINE_PRO_QTY=23,	

	} 


	/// <summary> 
	/// Order Closing
	/// </summary> 
	public enum TBSEM_POP_CLS : int 
	{ 
		IxMaxCt       =4,
		IxLOT_NO      =1 ,
		IxLOT_SEQ     =2 ,
		IxSTYLE_CD    =3 ,
		IxCLOSING     =4 ,

	} 

	


	/// <summary> 
	/// RPM Simulation 
	/// </summary> 
	public enum TBSEM_RPM : int 
	{ 
		IxMaxCt         =22,
		IxVENDER	    =1,
		IxOUT_SOLE	    =2,
		IxPO_NUMBER	    =3,
		IxPO_LINE_ITEM	=4,
		IxREGION	    =5,
		IxCOUNTRY	    =6,
		IxCUST_NU	    =7,
		IxCUST_NM 	    =8,
		IxMATERIAL	    =9,
		IxMATERIAL_DESC	=10,
		IxOGAC	        =11,
		IxRGAC	        =12,
		IxTOT_LINE_QTY	=13,
		IxDIFFERENCE	=14,
		IxFACTORY_CMT01	=15,
		IxFACTORY_CMT02	=16,
		IxFACTORY	    =17,
		IxOBS_NU	    =18,
		IxOBS_SEQ_NU	=19,
		IxCHG_NU	    =20,

	} 


	
	
	/// <summary> 
	/// RPM Load 
	/// </summary> 
	public enum TBSEM_RPM_L : int 
	{   
		IxMaxCt         =58, //arguemt ����
		lxCK_STYLE		 = 1,
		lxCK_MODLE	     = 2,
		lxCK_GEN         = 3,
		lxCK_PRESTO		 = 4,
		lxCK_GSSC	     = 5,

		lxCK_DEST        = 6,
		lxCK_QTYBAL      = 7,
		lxFACTORY		 = 8,
		lxVENDER_NAME	 = 9,
		lxLIAISON_OFFICE = 10,

		lxMCO			 = 11,
		lxOBS_NU	     = 12,
		lxTRADE_PO_NU	     = 13, //addd
		lxOBS_SEQ_NU     = 14,
		lxCRT_DATE	     = 15,

		lxDOC_DATE		 = 16,
		lxCATEGORY		 = 17,
		lxSUB_CATEGORY	 = 18,
		lxAFS_STOCK		 = 19,
		lxSTYLE_CD		 = 20,
		
		lxSTYLE_NAME     = 21,
		lxGEN			 = 22,
		lxSILHOUETTE	 = 23,
		lxSOURCE_TYPE	 = 24,
		lxDIVISION		 = 25,

		lxDIVISION_DESC	 = 26,
		lxCOLOR_DESC	= 27,
		lxDEV_CD		= 28,
		lxSEASON		= 29,
		lxYEAR			= 30,

		lxPUR_ORG		= 31,
		lxPUR_ORG_DESC	= 32,
		lxPUR_GRP	    = 33,
		lxPUR_GRP_DESC	= 34,
		lxPLANT			= 35,

		lxPLANT_DESC	= 36,
		lxTRADE_CD_PLANT		= 37, //add
		lxTRADE_CD_PLANT_DESC		= 38, //add
		lxMRP_CD		= 39,
		lxCUSTOMER		= 40,

		lxCUST_DESC	    = 41,
		lxCUST_NAME		= 42,
		lxCUST_CNTRY	= 43,	
		lxCUST_PO		= 44,
		lxOGAC_DATE		= 45,

		lxRGAC_DATE		= 46,
		lxBUY_GRP	    = 47,
		lxBUY_GRP_DESC	= 48,
		lxEVENT_CD		= 49,
		lxMODE			= 50,

		lxUOM		= 51, //add
		lxTTMI		= 52, //add
		lxCS_SIZE		= 53,



		lxCK_FLAG	    = 123    //108
	

	}		
	
		
	/// <summary> 
	/// SEM_OBS_CS_SIZE ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_OBS_REQ : int
	{
		IxMaxCt = 27,		// �ε��� Count 
		IxFACTORY = 1,		// ���屸��           	:VARCHAR2(5) 
		IxSTYLE_CD = 2,		// ��Ÿ���ڵ�         	:VARCHAR2(9) 
		IxSTYLE_NM = 3,		// ��Ÿ���ڵ�         	:VARCHAR2(9) 
		lxFLAG = 4,
		lxREQ_NO = 5,
		lxREQ_SESQ_NU = 6,
		IxOBS_NU = 7,		// OBS ��ȣ           	:VARCHAR2(10) 
		IxOBS_SEQ_NU = 8,	// OBS ����           	:VARCHAR2(10) 
		IxCHG_NU = 9,		// �������           	:VARCHAR2(5) 
		IxJOB_ID = 10,
		lxPLAN_DIV = 11,      //���� ��ȹ �ݿ�����    :VARCHAR2(1) 
		IxOBS_DIV = 12,
		IxCS_REQ = 13,
		IxOBS_ID = 14,		// OBS ID             	:VARCHAR2(6) 
		IxOBS_TYPE = 15,		// OBS TYPE           	:VARCHAR2(2) 
		IxPST_YN = 16,		// �������䱸��       	:VARCHAR2(1) 
		IxREQ_YN = 17,		// ��û����        	    :VARCHAR2(1) 
		lxOA_NU_BEF = 18,
		lsOA_NU_AFT = 19,
		IxDEST = 20,			// ����               	:VARCHAR2(7) 
		IxRTS_YMD = 21,		// RTS DATE/OGAC_DATE 	:VARCHAR2(8) 
		IxCSETS_YMD = 22,	// CSETS_DATE/GAC_DATE	:VARCHAR2(8) 
		IxCSETS_RSN = 23,	// GAC REASON         	:VARCHAR2(30) 
		lxREQ_YMD = 24,     // ��û ����
		lxOLD_REQ_NO = 25,  // �� ��û��ȣ
		IxTOT_QTY = 26,		// �ѿ�������         	:NUMBER(22) 
		IxGEN = 27,			// GENDER
	} 

	/// <summary> 
	/// SEM_BP_OA ���̺� �ε��� Enum //Head��
	/// </summary> 
	public enum TBSEM_BP_OA_H : int 
	{ 
		IxMaxCt = 4,		// �ε��� Count 
		IxFACTORY =1,		// ���屸��           	:VARCHAR2(5) 
		lxSTYLE_CD =2,      // ��Ÿ���ڵ�         	:VARCHAR2(9) 
		lxBEF_QTY =3,      // ���� ������
		lxAFT_QTY =4,       // PRD_QTY
	}  

	/// <summary> 
	/// SEM_BP_OA ���̺� �ε��� Enum //Detail��
	/// </summary> 
	public enum TBSEM_BP_OA_D : int 
	{ 
		IxMaxCt = 7,		// �ε��� Count 
		IxFACTORY =1,		// ���屸��           	:VARCHAR2(5) 
		lxFlag     =2, 
		IxOA_POSITON =3,	// Before/After ����
		lxSTYLE_CD =4,      // ��Ÿ���ڵ�       
		lxBP_NO = 5,
		lxPRD_QTY = 6,
		lxUPLOAD_YMD = 7,
	}  

	/// <summary> 
	/// SEM_BP_OA ���̺� �ε��� Enum  //Result��
	/// </summary> 
	public enum TBSEM_BP_OA : int 
	{ 
		IxMaxCt = 7,		// �ε��� Count 
		IxOA_POSITION =1,	// ����/���� ��ġ	:VARCHAR2(2) 
		IxFACTORY =2,		// ���屸��      	:VARCHAR2(5) 
		IxOA_SEQ_NU =3,		// HISTORY ����  	:VARCHAR2(5) 
		IxSTYLE_CD =4,		// ��Ÿ�ϱ���    	:VARCHAR2(9) 
		IxBP_NO =5,			// Lasting Week
		IxPRD_QTY =6,		// ����    	:NUMBER(22) 
		IxUPLOAD_YMD =7,	// ������        	:VARCHAR2(8) 
	}  

	/// <summary> 
	/// TBSEM_BP_OA_AddFlow ���̺� �ε��� Enum  //Result��
	/// </summary> 
	public enum TBSEM_BP_OA_AddFlow : int 
	{ 
		IxMaxCt = 4,		// �ε��� Count 
		IxOA_NU =0,			// ����/���� ��ġ	:VARCHAR2(2) 
		IxSTYLE_CD =1,		// ��Ÿ�ϱ���    	:VARCHAR2(9) 
		IxBP_NO =2,			// Lasting Week
		IxPRD_QTY =3,		// ����    	:NUMBER(22) 

	}  
	
	/// <summary> 
	/// SEM_JOB_OPTION ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_JOB_OPTION : int 
	{ 
		IxMaxCt = 17,		// �ε��� Count 
		IxFACTORY =1,		// 	:VARCHAR2(5) 
		IxJOB_CODE =2,		// 	:VARCHAR2(10) 
		IxCOM_CODE =3,		// 	:VARCHAR2(10) 
		IxOPT_CODE =4,		// 	:VARCHAR2(10) 
		IxOPT_VALUE1 =5,	// 	:VARCHAR2(50) 
		IxOPT_DESC1 =6,		// 	:VARCHAR2(20) 
		IxOPT_VALUE2 =7,	// 	:VARCHAR2(50) 
		IxOPT_DESC2 =8,		// 	:VARCHAR2(20) 
		IxOPT_VALUE3 =9,	// 	:VARCHAR2(50) 
		IxOPT_DESC3 =10,	// 	:VARCHAR2(20) 
		IxOPT_VALUE4 =11,	// 	:VARCHAR2(50) 
		IxOPT_DESC4 =12,	// 	:VARCHAR2(20) 
		IxOPT_VALUE5 =13,	// 	:VARCHAR2(50) 
		IxOPT_DESC5 =14,	// 	:VARCHAR2(20) 
		IxREMARKS =15,		// 	:VARCHAR2(50) 
		IxUPD_USER =16,		// 	:VARCHAR2(10) 
		IxUPD_YMD =17,		// 	:DATE(7) 
	}  

	/// <summary> 
	/// SEM_BP ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_BP_HISTORY : int 
	{ 
		IxMaxCt = 18,		// �ε��� Count 
		IxDEL_MONTH =1,		// ��ۿ�      	:VARCHAR2(8) 
		IxOBS_ID =2,		// OBS_ID
		IxSTYLE_CD =3,		// ��Ÿ�� �ڵ� 	:VARCHAR2(9) 
		IxREGION =4,		// REGION      	:VARCHAR2(7) 
		IxBP_NO =5,			// 	:VARCHAR2(8) 
		IxSYMD =6,			// ��������    	:VARCHAR2(8) 
		IxEYMD =7,			// ������      	:VARCHAR2(8) 
		IxPRD_QTY =8,		// ��������    	:NUMBER(22) 
		IxBTO_DT =9,		// 	:VARCHAR2(8) 
		IxBP_NU =10,		// BP��ȣ      	:VARCHAR2(10) 
		IxBP_SEQ_NU =11,	// BP����      	:VARCHAR2(10) 
		IxCHG_NU =12,		// �������    	:VARCHAR2(5) 
		IxOA_NU_BEF =13,	// ���� OA NO  	:VARCHAR2(10) 
		IxOA_NU_AFT =14,	// ���� OA NO  	:VARCHAR2(10) 
		IxDOWN_YMD =15,		// ���ϴٿ�����	:VARCHAR2(8) 
		IxREMARKS =16,		// ��   ��     	:VARCHAR2(50) 
		IxUPD_USER =17,		// �ۼ���      	:VARCHAR2(10) 
		IxUPD_YMD =18,		// �ۼ�����    	:DATE(7) 
	}  

	/// <summary> 
	/// SEM_DEST ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_DEST : int 
	{ 
		IxMaxCt		 = 11,		// �ε��� Count 
		IxFACTORY	 =  1,		// ���屸��      	:VARCHAR2(5) 
		IxDEST_CD    =  2,		// �༱���ڵ�     	:VARCHAR2(7) 
		IxDEST		 =  3,		// �༱��        	:VARCHAR2(7) 
		IxDEST_NAME  =  4,		// NAME :CUSTOMER	:VARCHAR2(40) 
		IxDEST_PRITY =  5,		// �켱����      	:NUMBER(22) 
		IxREGION	 =  6,		// ����          	:VARCHAR2(5) 
		IxLOCATION	 =  7,		// ������        	:VARCHAR2(30) 
		IxAF_TERM	 =  8,		// �׼� ��� �Ⱓ	:NUMBER(22) 
		IxVL_TERM	 =  9,		// ���� ��۱Ⱓ 	:NUMBER(22) 
		IxREMARKS	 =  10,		// �ּ�          	:VARCHAR2(50) 
		IxUPD_USER	 = 11,		// �����        	:VARCHAR2(10) 
		IxUPD_YMD	 = 12,		// �������      	:DATE(7) 
	}  





//	/// <summary> 
//	/// SEM_GSSC_TEMP[GRID SETTING]
//	/// </summary>
//	public enum TBSEM_GSSC_TEMP : int 
//	{
//		IxMaxCt = 13,		    // �ε��� Count 
//		IxFACTORY	     = 1,
//		IxSY_STY_NBR	 = 2,
//		IxSY_COLR_CD_ID	 = 3,
//		IxSTY_SZ_ID_DESC = 4,	
//		IxXDM_DIM_CD	 = 5,
//		IxXPC_PROD_CAT_CD= 6,	
//		IxPCT	         = 7,
//		IxSZ_QTY	     = 8,
//		IxSTYLE_QTY	     = 9,
//		IxLOGIC          = 10,
//		lxREMARKS		=  11,
//		lxUPD_USER		=  12,
//		lxUPD_YMD		=  13,
//	}


//	/// <summary> 
//	/// SEM_GSSC_LOAD[GRID SETTING]
//	/// </summary>
//	public enum TBSEM_GSSC_LOAD : int 
//	{
//		IxMaxCt = 23,		    // �ε��� Count 
//		lxMERGE			=   1,
//		lxGEN_XO		=	2,
//		lxPST_YN_XO		=	3,
//		lxSTYLE_CD_XO	=	4,
//		lxFACTORY		=	5,
//		lxSTYLE_CD		=	6,
//		lxCS_SIZE		=	7,
//		lxSIZE_RATE		=	8,
//		lxSIZE_QTY		=	9,
//		lxSTYLE_QTY		=	10,
//		lxGEN			=   11,
//		lxPST_YN		=	12,
//		lxSTYLE_NAME	=	13,
//		lxDEV_CD		=	14,
//		lxOUT_SOLE_01	=	15,
//		lxDIM			=   16,
//		lxCATEGORY_CD	=	17,
//		lxLOGIC			=   18,
//		lxREMARKS		=	19,
//		lxJOB_GSSC		=	20,
//		lxJOB_GSSC_SIZE	=	21,
//		lxUPD_USER		=	22,
//		lxUPD_YMD		=	23,
//		
//	}
//

	//
	//	/// <summary> 
	//	/// SEM_GSSC_LOAD���� SEM_GSSC���Ⱚ
	//	/// </summary> 
	//	public class Arr_TBSEM_GSSC
	//	{
	//		public int[] lx= {(int)ClassLib.TBSEM_GSSC_LOAD.lxFACTORY
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxSTYLE_CD
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxGEN
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxPST_YN
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxSTYLE_NAME
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxDEV_CD
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxOUT_SOLE_01
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxDIM
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxCATEGORY_CD
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxLOGIC
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxREMARKS
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxUPD_USER
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxUPD_YMD} ;
	//
	//		public Arr_TBSEM_GSSC()
	//		{
	//		}
	//
	//	}
	//

	/// <summary> 
	/// SEM_OBS ���̺� �ε��� Enum  -SEQ :2(OA CREATE���� ���)
	/// </summary> 
	public enum TBSEM_OBS2 : int 
	{ 
		IxMaxCt      = 17,		// �ε��� Count 
		lxCHECK_DIV  = 1,
		lxJOB_FLAG   = 2,
		IxFACTORY    = 3,		
		IxOBS_NU     = 4,		
		IxOBS_SEQ_NU = 5,		
		IxCHG_NU     = 6,		
		lxOBS_DIV    = 7, 
		lxSTYLE_CD   = 8,
		lxGEN        = 9,
		lxPST_YN     = 10,
		lxTOT_QTY    =11,
		lxREQ_YN     =12,
		lxOA_NU_BEF = 13,
		lxOA_NU_AFT = 14,
		lxREAL_OBS_DIV = 15,
		lxUPD_USER    = 16,
		lxUPD_YMD     = 17,
	}



	//	/// <summary> 
	//	/// SEM_GSSC_LOAD���� SEM_GSSC_SIZE���Ⱚ
	//	/// </summary> 
	//	public class Arr_TBSEM_GSSC_SIZE
	//	{
	//		public int[] lx= {(int)ClassLib.TBSEM_GSSC_LOAD.lxFACTORY
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxSTYLE_CD 
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxCS_SIZE 
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxSIZE_RATE
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxSIZE_QTY
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxSTYLE_QTY
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxREMARKS
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxUPD_USER
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxUPD_YMD} ;    
	//
	//		public Arr_TBSEM_GSSC_SIZE()
	//		{
	//		}
	//
	//	}
	//
	//
	//
	//
	//	
	//	/// <summary> 
	//	/// SEM_GSSC_LOAD���� SEM_USER_ERROR���Ⱚ
	//	/// </summary> 
	//	public class Arr_TBSEM_GSSC_ERR
	//	{
	//		public int[] lx= {(int)ClassLib.TBSEM_GSSC_LOAD.lxFACTORY
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxSTYLE_CD 
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxGEN_XO
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxPST_YN_XO
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxSTYLE_CD_XO
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxUPD_USER
	//							 ,(int)ClassLib.TBSEM_GSSC_LOAD.lxUPD_YMD} ;    
	//
	//		public Arr_TBSEM_GSSC_ERR()
	//		{
	//		}
	//
	//	}




	/// <summary> 
	/// SEM_GSSC ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_GSSC01 : int 
	{ 
		IxMaxCt			= 19,	
		IxCK_STYLE		=1,
		IxCK_MODEL		=2,
		IxCK_GENDER		=3,
		IxCK_PRESTO		=4,
		IxFACTORY		=5,
		IxSY_STY_NBR	=6,
		IxSY_COLR_CD_ID	=7,
		IxXDM_DIM_CD	=8,
		IxSTY_SZ_ID_DESC  =9,
		IxXPC_PROD_CAT_CD =10,
		IxPCT			  =11,
		IxSZ_QTY		  =12,
		IxSTYLE_QTY		  =13,
		IxLOGIC			  =14,
		IxREMARKS		  =15,
		IxUPD_USER		  =16,
		IxUPD_YMD		  =17,
		IxJOB_DIV		 =18,
		IxJOB_HT		 =19,

	}  




	/// <summary> 
	/// SEM_GSSC ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_GSSC : int 
	{ 
		IxMaxCt = 13,		   // �ε��� Count 
		IxFACTORY =1,		   // ���屸��      	:VARCHAR2(5) 
		IxSTYLE_CD =2,		   // ��Ÿ�ϱ���    	:VARCHAR2(9) 
		IxGEN =3,			   // ����         	    :VARCHAR2(2) 
		IxPST_YN =4,		   // �������䱸��	    :VARCHAR2(1) 
		IxSTYLE_NAME =5,	   // ��Ÿ�ϱ���    	:VARCHAR2(9) 
		IxDEV_CD =6,		   // ���� CODE     	:VARCHAR2(6) 
		IxOUT_SOLE_01 =7,	   // ���� CODE     	:VARCHAR2(10) 
		IxDIM =8,			   // ġ��          	:VARCHAR2(2) 
		IxCATEGORY_CD =9,	   // ī�װ� �ڵ� 	:VARCHAR2(5) 
		IxLOGIC =10,		   // ����          	:VARCHAR2(5) 
		IxREMARKS =11,		   // �ּ�          	:VARCHAR2(50) 
		IxUPD_USER =12,		   // �����        	:VARCHAR2(10) 
		IxUPD_YMD =13,		   // �������      	:DATE(7) 
	}  


	/// <summary> 
	/// SEM_GSSC ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_GSSC02 : int 
	{ 
		IxMaxCt = 15,		   // �ε��� Count 
		IxFACTORY =1,		   // ���屸��      	:VARCHAR2(5) 
		IxSTYLE_CD =2,		   // ��Ÿ�ϱ���    	:VARCHAR2(9) 
		IxGEN =3,			   // ����         	    :VARCHAR2(2) 
		IxPST_YN =4,		   // �������䱸��	    :VARCHAR2(1) 
		IxSTYLE_NAME =5,	   // ��Ÿ�ϱ���    	:VARCHAR2(9) 
		IxDEV_CD =6,		   // ���� CODE     	:VARCHAR2(6) 
		IxOUT_SOLE_01 =7,	   // ���� CODE     	:VARCHAR2(10) 
		IxDIM =8,			   // ġ��          	:VARCHAR2(2) 
		IxCATEGORY_CD =9,	   // ī�װ� �ڵ� 	:VARCHAR2(5) 
		IxLOGIC =10,		   // ����          	:VARCHAR2(5) 
		IxREMARKS =11,		   // �ּ�          	:VARCHAR2(50) 
		IxCS_SIZE =12,		   // �ּ�          	:VARCHAR2(50) 
		IxSIZE_RATE =13,		// �ּ�          	:VARCHAR2(50) 
		IxUPD_USER =14,		   // �����        	:VARCHAR2(10) 
		IxUPD_YMD =15,		   // �������      	:DATE(7) 
	}  


	

	/// <summary> 
	/// SEM_OBSVSBP1
	/// </summary> 
	public enum TBSEM_OBSVSBP : int 
	{ 
		IxMaxCt			=   33,		    // �ε��� Count 
		lxSTYLE_CD		=	1,
		lxFACTORY		=	2,
		lxOBS_NU		=	3,
		lxOBS_SEQ_NU	=	4,
		lxCHG_NU		=	5,
		lxSYMD			=	6,
		lxEYMD			=	7,
		lxOBS_DIV		=	8,
		lxOBS_ID		=	9,
		lxOBS_TYPE		=	10,
		lxGEN			=	11,
		lxPST_YN		=	12,
		lxREQ_YN		=	13,
		lxOA_NU_BEF		=	14,
		lxOA_NU_AFT		=	15,
		lxDEST_PRITY	=	16,
		lxDEST			=	17,
		lxCUST_XREF		=	18,
		lxWH			=	19,
		lxISEG			=	20,
		lxTOT_QTY		=	21,
		lxRTS_YMD		=	22,
		lxCSETS_YMD		=	23,
		lxCSETS_RSN		=	24,
		lxCUS_REQ_YMD	=	25,
		lxDELIV_YMD		=	26,
		lxSTA_DELIV_YMD =	27,
		lxMSR_DIV		=	28,
		lxCRTN_QTY		=	29,
		lxTOTCRTN_QTY	=	30,
		lxTOTDIV_QTY	=	31,
		lxREMARKS		=	32,
		lxUPD_USER		=	33,
		lxUPD_YMD		=	34,
	}


	/// <summary> 
	/// SEM_OA ���̺� �ε��� Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_OA01 : int 
	{ 
		IxMaxCt = 7,		// �ε��� Count 
		IxFACTORY =1,
		IxSTATUS  =2,
		IxOBS_NU =3,
		IxOBS_SEQ_NU =4,
		IxCHG_NU=5,
		IxCS_SIZE =6,
		IxQTY =7,
	}  


	/// <summary> 
	/// SEM_OA ���̺� �ε��� Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_OA02 : int 
	{ 
		IxMaxCt = 8,		// �ε��� Count 
		IxFACTORY =1,
		IxSTATUS  =2,
		IxOBS_NU =3,
		IxOBS_SEQ_NU =4,
		IxCHG_NU     =5,
		IxOA_FLAG    =6,
		IxCS_SIZE =7,
		IxQTY =8,
	}  



	/// <summary> 
	/// SEM_OA ���̺� �ε��� Enum  --SEQ:04
	/// </summary> 
	public enum TBSEM_OA04 : int 
	{ 
		IxMaxCt        =8,		// �ε��� Count 
		IxFACTORY      =1,
		IxOBS_ID       =2,
		IxOBS_TYPE	   =3,
		IxSTYLE_CD     =4,
		IxOA_COUNT     =5,
		IxGEN          =6,
		IxPST_YN       =7,
		IxTOT_QTY      =8,
	}  


	/// <summary> 
	/// SEM_OA ���̺� �ε��� Enum  --SEQ:05
	/// </summary> 
	public enum TBSEM_OA05 : int 
	{ 
		IxMaxCt          = 18,		// �ε��� Count 
		IxFACTORY	     =  1 ,
		IxSTYLE_CD	     =  2 ,
		IxOBS_ID         =  3 ,
	    IxOBS_TYPE       =  4 ,   
		lxREAL_OBS_DIV 	 =  5 ,
		IxOBS_DIV_TOTQTY =	6  ,
		IxRTS_YMD		 =	7  ,
		IxOGAC_YMD		 =	8  ,
		IxJOB_DIV		 =	9  ,
		IxOBS_NU		 =	10  ,
		IxOBS_SEQ_NU	 =	11  ,
		IxCHG_NU		 =	12  ,
		IxOA_NU_BEF		 =	13  ,
		IxOA_NU_AFT		 =	14  ,
		IxGEN			 =	15  ,
		IxTOT_QTY		 =	16  ,
		IxCS_SIZE		 =	17  ,
		IxORD_QTY		 =	18  ,
	}						   


	
	/// <summary> 
	/// SEM_OA ���̺� �ε��� Enum  --SEQ:06
	/// </summary> 
	public enum TBSEM_OA06 : int 
	{ 
		IxMaxCt     = 9 ,	
		lxFACTORY	=	1	,
		lxJOB		=	2	,
		lxOBS_NU	=	3	,
		lxOBS_SEQ_NU=	4	,
		lxCHG_NU	=	5	,
		lxGEN		=	6	,
		lxTOT_QTY	=	7	,
		lxCS_SIZE	=	8	,
		lxORD_QTY	=	9	,
	}



		
	/// <summary> 
	/// SEM_OA ���̺� �ε��� Enum  --SEQ:07
	/// </summary> 
	public enum TBSEM_OA07 : int 
	{ 
		IxMaxCt     = 13,	
		lxJOB		= 1,
		lxOA_CFM	= 2,
		lxREQ_NO	= 3,
		IxDEST	    = 4,
		lxOBS_NU	= 5,
		lxOBS_SEQ_NU= 6,
		lxCHG_NU	= 7,
		lxRTS_YMD	= 8,
		lxOAC_YMD	= 9,
		lxGEN		= 10,
		lxTOT_QTY	= 11,
		lxCS_SIZE	= 12,
		lxORD_QTY	= 13,

	}



	/// <summary> 
	/// SEM_OA ���̺� �ε��� Enum  --SEQ:08
	/// </summary> 
	public enum TBSEM_OA08 : int 
	{ 
		IxMaxCt     =   9,	
		lxTOT_QTY	=	1,
		IxREQ_NU	=	2,
		lxOBS_NU	=	3,
		lxOBS_SEQ_NU=	4,
		lxCHG_NU	=	5,
		lxGEN		=	6,
		lxREQ_QTY	=	7,
		lxCS_SIZE	=	8,
		lxORD_QTY	=	9,
	}



	/// <summary> 
	/// SEM_OA_REQ ���̺� �ε��� Enum  --SEQ:1
	/// </summary> 
	public enum TBSEM_OA_REQ01 : int 
	{ 
		IxMaxCt = 10,		// �ε��� Count 
		lxOA_POSITION = 1,
		lxOBS_NU	= 2,
		lxOBS_SEQ_NU= 3,
		lxCHG_NU	= 4,
		lxOA_CFM	= 5,
		lxGEN		= 6,
		lxPST_YN	= 7,
		lxSTYLE_CD	= 8,
		lxSTYLE_NAME= 9,
		lxOA_NU	= 10,
	}  


	/// <summary> 
	///  SEM_OA_REQ ���̺� �ε��� Enum  --SEQ:2
	/// </summary> 
	public enum TBSEM_OA_REQ02 : int 
	{ 
		IxMaxCt =11,		// �ε��� Count 
		IxOA_POSITION	=1,
		IxJOB_FLAG		=2,
		IxREQ_NO		=3,
		IxREAL_OBS_DIV	=4,
		IxOBS_NU		=5,
		IxOBS_SEQ_NU	=6,
		IxCHG_NU		=7,
		IxDEST			=8,
		IxTOT_QTY		=9,
		IxCS_SIZE		=10,
		IxORD_QTY		=11,
		

	}  



	/// <summary> 
	///  SEM_OA_REQ ���̺� �ε��� Enum  --SEQ:3
	/// </summary> 
	public enum TBSEM_OA_REQ03 : int 
	{ 
		IxMaxCt =9,		// �ε��� Count 
		IxREQ_NO	    =1,
		IxREAL_OBS_DIV	=2,
		IxOBS_NU		=3,
		IxOBS_SEQ_NU	=4,
		IxCHG_NU		=5,
		IxDEST			=6,
		IxTOT_QTY		=7,
		IxCS_SIZE		=8,
		IxORD_QTY		=9,

	}

	/// <summary> 
	/// SEM_OBS_OA ���̺� �ε��� Enum  --SEQ:03
	/// </summary> 
	public enum TBSEM_OBS_OA : int 
	{ 
		IxMaxCt = 22,		// �ε��� Count 
		IxFACTORY =1,			// ���屸��     	:VARCHAR2(2) 
		IxOA_NU =2,			// HISTORY ��ȣ 	:VARCHAR2(10) 
		IxOBS_DIV =3,			// GPO/DPO ���� 	:VARCHAR2(1) 
		IxOA_OBS_DIV =4,			// ��->��,��->��, ��->�� ����	:VARCHAR2(2) 
		IxOBS_ID =5,			// OBS ID       	:VARCHAR2(6) 
		IxOBS_TYPE =6,			// ���� Ÿ��    	:VARCHAR2(2) 
		IxSTYLE_CD =7,			// ��Ÿ�ϱ���   	:VARCHAR2(9) 
		IxOA_DIV =8,			//  OA����      	:VARCHAR2(1) 
		IxOA_YMD =9,			// ������       	:VARCHAR2(8) 
		IxOA_CFM =10,			// OA_CONFIRM����	:VARCHAR2(1) 
		IxCHG_YMD =11,			// ������       	:VARCHAR2(8) 
		IxPUR_NO =12,			// ���� ��ȣ    	:VARCHAR2(10) 
		IxOUR_REF_NO =13,			// ���� ��ȣ    	:VARCHAR2(10) 
		IxPUR_GRP =14,			// ���� GROUP   	:VARCHAR2(3) 
		IxYOUR_REF =15,			// �����ڷ�     	:VARCHAR2(10) 
		IxORDER_RSN =16,			// ORDER���� ����	:VARCHAR2(20) 
		IxQUAL_ISEQ =17,			// QUAL_ISEG    	:VARCHAR2(8) 
		IxSEASON_CD =18,			// �����ڵ�     	:VARCHAR2(2) 
		IxSEASON_YEAR =19,			// �����⵵     	:VARCHAR2(4) 
		IxREMARKS =20,			// ��   ��      	:VARCHAR2(50) 
		IxUPD_USER =21,			// �����       	:VARCHAR2(10) 
		IxUPD_YMD =22,			// �������     	:DATE(7) 
	}  



	/// <summary> 
	/// SEM_OBS_OA ���̺� �ε��� Enum  --SEQ:04
	/// </summary> 
	public enum TBSEM_OBS_OA04 : int 
	{   
		lxMax =16,
	    lxFACTORY= 1,
	    lxOA_NU= 2,
		lxOA_SEQ_NU= 3,
		lxSTYLE_CD= 4,
		lxSTYLE_NAME= 5,
		lxOA_POSITION= 6,
		lxOBS_ID= 7,
		lxOBS_TYPE= 8,		
		lxOBS_DIV= 9,
		lxOA_OBS_DIV= 10,
		lxOBS_NU= 11,
		lxOBS_SEQ_NU= 12,
		lxCHG_NU= 13,
		lxGENDER= 14,
		lxCS_SIZE= 15,
		lxORD_QTY= 16,

	}  




	/// <summary> 
	/// SEM_OBS_OA ���̺� �ε��� Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_OBS_OA01 : int 
	{ 
		IxMaxCt = 7,		// �ε��� Count 
		IxFACTORY =1,			// ���屸��     	:VARCHAR2(2) 
		IxOBS_NU =2,			
		IxOBS_SEQ_NU =3,		
		IxCS_SIZE =4,			
		IxBEF_QTY=5,			
		IxADJ_QTY =6,			
		IxAFT_QTY =7,			
	}  

	/// <summary> 
	/// SEM_OBS_OA ���̺� �ε��� Enum  --SEQ:02
	/// </summary> 
	public enum TBSEM_OBS_OA02 : int 
	{ 
		IxMaxCt = 4,		    // �ε��� Count 
		IxOBS_NU =1,	
		IxOBS_SEQ_NU =2,
		IxCHG_NU =3,	
		IxTOT_QTY =4,	
	}



	/// <summary> 
	/// SEM_BALANCE ���̺� �ε��� Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_BP_BAL  : int 
	{ 
		IxMaxCt = 5,		    // �ε��� Count 
		IxFACTORY =1,	
		IxOUT_SOLE_01 =2,
		IxDEV_CD =3,	
		IxSTYLE_CD =4,	
		IxSTYLE_NAME =5,	
		
	}





	
	/// <summary> 
	/// SEM_OBS_HIST ���̺� �ε��� Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_OBS_HIST : int 
	{ 
		IxMaxCt      = 15,		    // �ε��� Count 
		IxFACTORY    =1,   
		IxSTYLE_CD   =2,  
		IxOBS_NU     =3,     
		IxOBS_SEQ_NU =4, 
		IxCHG_NU     =5, 
		IxSYMD       =6, 
		IxEYMD       =7, 			      
		IxOA_NU_BEF  =8, 
		IxOA_NU_AFT  =9, 
		IxDEST_PRITY =10, 
		IxDEST       =11,      
		IxRTS_YMD    =12, 
		IxTOT_QTY    =13,
		lxGEN        =14,
		IxCS_SIZE    =15, 
		IxORD_QTY    =16,
	}



		
	/// <summary> 
	/// SEM_OBS_BAL ���̺� �ε��� Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_OBS_BAL01 : int 
	{ 
		IxMaxCt      = 8,		    // �ε��� Count 
		IxFACTORY    = 1, 
		IxSTYLE_CD   = 2, 
		IxSTYLE_NAME = 3, 
		IxGEN        = 4, 
		IxOBS_QTY    = 5, 
		IxBP_QTY     = 6, 
		IxNIKE_BAL_QTY  = 7,  
		IxJOB_BAL_QTY   = 8,  
	}


	/// <summary> 
	/// SEM_OBS_BAL ���̺� �ε��� Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_OBS_BAL02 : int 
	{ 
		IxMaxCt      = 11,		    // �ε��� Count 		
		IxFACTORY    = 1,
		IxJOB_DIV    = 2,
		IxJOB_NAME   = 3,
		IxSTYLE_CD   = 4,  
		IxOBS_NU     = 5, 
		IxOBS_SEQ_NU = 6, 
		IxBP_NO      = 7, 
		IxTOT_QTY    = 8, 
		IxGEN        = 9,        // BP_NO�� OBS_NU+ OBS_SEQ_NU�� ���� Display
		IxCS_SIZE    = 10, 
		IxQTY        = 11,
		
	}





	
	/// <summary> 
	/// SEM_PA ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_PA : int 
	{ 
		IxMaxCt = 21,		// �ε��� Count 
		IxFACTORY =1,			// 	:VARCHAR2(5) 
		IxSEASON_CD =2,			// 	:VARCHAR2(6) 
		IxUPLOAD_YMD =3,			// 	:VARCHAR2(8) 
		IxMODEL_OFFERING =4,			// 	:VARCHAR2(50) 
		IxDEV_CODE =5,			// 	:VARCHAR2(50) 
		IxSTYLE_CD =6,			// 	:VARCHAR2(9) 
		IxDEV_NAME =7,			// 	:VARCHAR2(50) 
		IxPRO_CATEGORY =8,			// 	:VARCHAR2(50) 
		IxOS_CODE =9,			// 	:VARCHAR2(50) 
		IxOBS_ID_1 =10,			// 	:VARCHAR2(6) 
		IxOBS_QTY_1 =11,			// 	:NUMBER(22) 
		IxOBS_ID_2 =12,			// 	:VARCHAR2(6) 
		IxOBS_QTY_2 =13,			// 	:NUMBER(22) 
		IxOBS_ID_3 =14,			// 	:VARCHAR2(6) 
		IxOBS_QTY_3 =15,			// 	:NUMBER(22) 
		IxCHANGE_R_FLG_01 =16,			// 	:VARCHAR2(1) 
		IxCHANGE_R_FLG_02 =17,			// 	:VARCHAR2(1) 
		IxAUTO_FLG =18,			// 	:VARCHAR2(1) 
		IxREMARKS =19,			// 	:VARCHAR2(500) 
		IxSTATUS =20,			// 	:VARCHAR2(1) 
		IxUPD_USER =21,			// 	:VARCHAR2(30) 
		IxUPD_YMD =22,			// 	:DATE(7) 
	}  



	/// <summary> 
	/// SEM_PA_UPLOAD ���̺� �ε��� Class 
	/// </summary> 
	public class TBSEM_PA_UPLOAD
	{ 
		public static int IxPRO_CATEGORY =1;			// 	:VARCHAR2(50) 
		public static int IxOS_CODE =2;			// 	:VARCHAR2(50) 
		public static int IxMODEL_OFFERING =3;			// 	:VARCHAR2(50) 
		public static int IxDEV_CODE =4;			// 	:VARCHAR2(50) 
		public static int IxSTYLE_CD =5;			// 	:VARCHAR2(6) 
		public static int IxSTYLE_CLR =6;			// 	:VARCHAR2(3) 
		public static int IxDEV_NAME =7;			// 	:VARCHAR2(50) 
		public static int IxOBS_QTY_1 =8;			// 	:NUMBER(22) 
		public static int IxOBS_QTY_2 =9;			// 	:NUMBER(22) 
		public static int IxOBS_QTY_3 =10;			// 	:NUMBER(22) 


	}  




	
	/// <summary> 
	/// SEM_PA ���̺� �ε��� Enum 
	/// </summary> 
	public enum TBSEM_ID_ORDER: int 
	{ 
		Ixchk   =1,
		IxWorkOrderID   =2,
		IxShipGroupID   =3,
		IxOrderID       =4,
		IxPackingInfoTotal   =5,
		IxPriority           =6,
		IxFactoryReceiveDate =7,
		IxFactoryAcceptDate  =8,
		IxInitailEstimatedShipDate =8,
		IxRequiredShipDate   =10,
		IxExotic             =11,
		IxRemake             =12,
		IxShipToRegion       =13,
		IxShipper            =14,
		IxBillToRegion       =15,
	
	}  






}
