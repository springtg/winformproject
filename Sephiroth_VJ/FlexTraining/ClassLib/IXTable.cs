using System;

namespace FlexTraining.ClassLib
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

	public enum TBSCM_CODE : int 
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

	public enum TBSCM_TABLE : int 
	{ 
		IxMaxCt = 31,		// �ε��� Count 
		IxPG_ID =0,			// ���α׷� ���̵�	:VARCHAR2(20) 
		IxPG_SEQ =1,			// ���α׷� SEQ	:NUMBER(22) 
		IxCOL_NAME =2,			// �÷��� (����ʵ��)	:VARCHAR2(20) 
		IxCOL_ORDER =3,			// �÷� ���� (ǥ�ü���)	:NUMBER(22) 
		IxTABLE_NAME =4,			// ���̺��	:VARCHAR2(20) 
		IxHEAD_DESC1 =5,			// �����(1)	:VARCHAR2(100) 
		IxHEAD_DESC2 =6,			// �����(2)	:VARCHAR2(100) 
		IxHEAD_DESC3 =7,			// �����(3)	:VARCHAR2(100) 
		IxHEAD_DESC4 =8,			// �����(4)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC1 =9,			// ��� �����(1)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC2 =10,			// ��� �����(2)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC3 =11,			// ��� �����(3)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC4 =12,			// ��� �����(4)	:VARCHAR2(100) 
		IxWIDTH =13,			// �÷� �ʺ�	:NUMBER(22) 
		IxLOCK_YN =14,			// ����Ʈ ���� ����	:VARCHAR2(1) 
		IxVISIBLE_YN =15,			// VISIBLE ����	:VARCHAR2(1) 
		IxAUTOSORT_YN =16,			// �ڵ���Ʈ ����	:VARCHAR2(1) 
		IxHALIGN =17,			// ���� ����	:VARCHAR2(10) 
		IxVALIGN =18,			// ���� ����	:VARCHAR2(10) 
		IxMAXROW =19,			// �ִ� �� �� : ó�� ǥ�õ� �� �������� ��� ����	:NUMBER(22) 
		IxFROZENCOL =20,			// FROZEN COLUMN	:NUMBER(22) 
		IxFROZENROW =21,			// FROZEN ROW	:NUMBER(22) 
		IxBACKCOLOR =22,			// ����	:VARCHAR2(10) 
		IxFORECOLOR =23,			// ���ڻ�	:VARCHAR2(10) 
		IxCELLTYPE =24,			// ��Ÿ��	:VARCHAR2(10) 
		IxDATA_LIST_TYPE =25,			// ��Ÿ���� �޺��ڽ��϶� �����ڵ� �Ǵ� ���� �̿� ���� ���� (�����ڵ� : 0, ���� : 1)	:VARCHAR2(1) 
		IxDATA_LIST_CD =26,			// DATA_LIST_TYPE = 0 �϶� �����ڵ� ����	:VARCHAR2(10) 
		IxDATA_LIST_QUERY =27,			// DATA_LIST_TYPE = 1 �϶� ���� ����	:VARCHAR2(500) 
		//������ �߰�
		IxESSENTIAL_YN = 28,
		IxCHAR_CASE = 29,
		IxMAX_NUMBER = 30,
		IxMIN_NUMBER = 31,
		IxMAX_WIDTH = 32,
		IxREMARKS =33,			// ���	:VARCHAR2(100) 
		IxUPD_USER =34,			// �ۼ���	:VARCHAR2(10) 
		IxUPD_YMD =35,			// �ۼ�����	:DATE(7) 
	}   
	public enum TBSIV_TCM_REGISTER  : int 

	{ 

		IxMaxCt               = 43,
		IxT_LEVEL             = 1,
		IxFACTORY             = 2,
		IxACC_MONTH           = 3,
		IxORD_CD              = 4,
		IxORD_NM              = 5,
		IxACC_CD              = 6,
		IxACC_NM              = 7,
		IxSUB_FACTORY         = 8,
		IxSUB_FACTORY_NAME    = 9,
		IxORDER_SEQ           = 10,
		IxVALUE_DIV           = 11,
		IxTOTAL               = 12,      
		IxDAY_01              = 13,      
		IxDAY_02              = 14,
		IxDAY_03              = 15,
		IxDAY_04              = 16,
		IxDAY_05              = 17,
		IxDAY_06              = 18,
		IxDAY_07              = 19,
		IxDAY_08              = 20,
		IxDAY_09              = 21,
		IxDAY_10              = 22,
		IxDAY_11              = 23,
		IxDAY_12              = 24,
		IxDAY_13              = 25,
		IxDAY_14              = 26,
		IxDAY_15              = 27,
		IxDAY_16              = 28,
		IxDAY_17              = 29,
		IxDAY_18              = 30,
		IxDAY_19              = 31,
		IxDAY_20              = 32,
		IxDAY_21              = 33,
		IxDAY_22              = 34,
		IxDAY_23              = 35,
		IxDAY_24              = 36,
		IxDAY_25              = 37,
		IxDAY_26              = 38,
		IxDAY_27              = 39,
		IxDAY_28              = 40,
		IxDAY_29              = 41,
		IxDAY_30              = 42,
		IxDAY_31              = 43,
 
	}



	public enum TBSIM_EVALUATION  : int 
	{ 
		IxMaxCt = 20,
		IxT_LEVEL    	     	=1,
		IxFACTORY    	     	=2,
		IxT_CODE	    		=3,
		IxT_NAME	    		=4,
		IxSEQ	    		    =5,
		IxEMP_NO	        	=6,
		IxEMP_NO2	        	=7,
		IxNAME    		        =8,
		IxDEP_CODE 		        =9,
		IxDEP_NAME	    		=10,
		IxDEP_NAME2     		=11,
		IxPOSITION		        =12,
		IxGOAL_VALUE			=13,
		IxGOAL_DESC			    =14,
		IxFULL_ATTEND  	        =15,
		IxPLAN			        =16,
		IxATTEND			    =17,
		IxMEASURE		        =18,
		IxRESULT_VALUE		    =19,
		IxREASON		        =20,
		IxREMARK		        =21,
	}

	public enum TBSIM_EVALUATION_TAIL  : int 
	{ 
		IxMaxCt = 11,
		IxCHECK    	     	=1,
		IxEXIST    	     	=2,
		IxFACTORY	  		=3,
		IxT_CODE	   		=4,
		IxSEQ	    	    =5,
		IxEMP_NO	       	=6,
		IxSKILL_CODE       	=7,
		IxSKILL_NAME        =8,
		IxVALUE	    	    =9,
		IxEVALUATOR		    =10,
		IxREMARK	        =11,
	}

	public enum TBSIM_TRAINING_MASTER : int 
	{ 
		IxMaxCt = 8,
		IxFACTORY				=1, 
		IxT_CODE  		        =2, 
		IxT_NAME  		        =3, 
		IxT_GRP_CODE            =4, 
		IxMEASURE_CODE  	    =5, 
		IxGOAL_VALUE  		    =6, 
		IxGOAL_DESC  		    =7, 
		IxREMARK  		        =8, 
	}  

	public enum TBSIM_TRAINER : int 
	{ 
		IxMaxCt = 7,
		IxFACTORY				=1, 
		IxTRAINER_ID  		    =2, 
		IxTRAINER_NAME  		=3, 
		IxMAJOR  	            =4, 
		IxCOME_FROM  		    =5, 
		IxCOMMEN  		        =6, 
		IxREMARK  		        =7, 
	}  


	public enum TBSIM_TRAINING_MGNT  : int 
	{ 
		IxMaxCt = 14,
		IxFACTORY    	     	=1,
		IxT_CODE	    		=2,
		IxT_NAME	    		=3,
		IxSEQ	        		=4,
		IxGRP_CODE    		    =5,
		IxWAVE	    		    =6,
		IxLOCATION_DIV		    =7,
		IxLANG_DIV			    =8,
		IxTRAINER_ID			=9,
		IxTRAINER_NAME			=10,
		IxTARGET    			=11,
		IxGOAL_VALUE			=12,
		IxGOAL_DESC			    =13,
		IxREMARK		        =14,

		//		FACTORY, T_CODE, SEQ, GRP_CODE, WAVE, LOCATION_DIV, 
		//		LANG_DIV, TRAINER_ID, GOAL_VALUE, GOAL_DESC, 
		//		REMARK, FIX_TF, UPDATE_DATE, UPDATE_USER
		  
	}  

	public enum TBSIM_PGM_SCHEDULE  : int 
	{ 
		IxMaxCt = 8,
		IxFACTORY		=1,
		IxT_CODE		=2,
		IxSEQ			=3,
		IxTRAINED_DATE	=4,
		IxPGM_DESC		=5,
		IxSCHEDULE_YN	=6,
		IxREASON		=7,
		IxREMARK		=8,

	}

	public enum TBSIM_SKILL_MANAGEMENT  : int 
	{ 
		IxMaxCt = 10,
		IxEMP_NO	        =2,
		IxDEP_CODE	        =4,
		IxWORK_SKILL_LEVEL	=10,

	}  

	public enum TBSIM_TRAINEE_TARGET: int 
	{ 
		IxMonth=3,
		IxTarget=5,
		IxRemark=6,
	}  
	public enum TBSIV_NMI_TRACKING: int 
	{ 
		IxMaxCt = 27,
		IxFACTORY =1,
		IxOBS_ID =2,
		IxSTYLE_CD=3,
		IxSTYLE_NM=4,
		IxLINE_CD=5,
		IxLINE_NM=6,
		IxCHECK_ITEM=7,
		IxCHECK_DATE_VALUE=8 ,
		IxCHECK_DATE_VALUE_DSC=9,
		IxCHECK_ITEM_NM=10,
		IxCHECK_ITEM_VNM=11,
		IxSEASON=12,
		IxTD_CODE=13,
		IxFSR_DATE=14,
		IxD_DATE=15,
		IxFINISH_DATE=16,
		IxACTUAL_DATE=17,
		IxMAIN_DEPT=18,
		IxPIC1=19,
		IxPIC2=20,
		IxPIC3=21,
		IxPIC4=22,
		IxREMARK=23,
		IxADMIN_USER=24,
		IxBALANCE=25,
		IxVSM=26,
		IxCHECK_USER=27,
	}

	public enum TBSIM_TRAINING_GRP  : int 
	{ 
		IxMaxCt = 4,
		IxFACTORY		=1,
		IxT_GRP_CODE	=2,
		IxT_GRP_NAME	=3,
		IxREMARK		=4,

	}

	public enum TBSIM_TRAINING_REQUIRED  : int 
	{ 
		IxMaxCt = 6,
		IxFACTORY		=1,
		IxPOSITION   	=2,
		IxT_GRP_CODE	=3,
		IxT_CODE		=4,
		IxT_NAME		=5,
		IxREMARK		=6,

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
		IxADJ_QTY = 13,
		IxOUT_QTY = 14,  
		IxREMAINDER_QTY = 15, 
		IxUNIT = 16, 	
		IxOUT_STATUS = 17, 	
		IxITEM_CD = 18,  
		IxSPEC_CD = 19, 	
		IxCOLOR_CD = 20, 	
		IxITEM_NAME = 21, 	 
		IxSPEC_NAME = 22, 	 
		IxCOLOR_NAME = 23,
		IxORG_REMAINDER_QTY = 24,
	 
	}

}
