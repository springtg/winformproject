using System;

namespace FlexTraining.ClassLib
{
	 
	#region 공통
	/// <summary> 
	/// LINK_DEF : 링크 속성 지정해 주기 위한 인덱스
	/// </summary> 
	public enum LINK_DEF : int 
	{ 
		 
		IxARROW_DST =3,			// 링크 끝 스타일	:VARCHAR2(60) 
		IxARROW_MID =4,			// 링크 꺾인점 스타일	:VARCHAR2(60) 
		IxARROW_ORG =5,			// 링크 첫 스타일	:VARCHAR2(60) 
		IxDASHSTYLE =6,			// 링크 선 스타일	:VARCHAR2(10) 
		IxDRAWCOLOR =7,			// 링크 선 색깔	:VARCHAR2(10) 
		IxDRAWWIDTH =8,			// 링크 선 두께	:VARCHAR2(10) 
		IxFONT =9,			// 링크 위 텍스트 폰트 속성	:VARCHAR2(60) 
		IxJUMP =10,			// JUMP 속성	:VARCHAR2(10) 
		IxLINE_STYLE =11,			// 라인 스타일 (예 : 곡선, 직선 등)	:VARCHAR2(10) 
		IxLINE_ROUND =12,			// 라인 라운드 속성 : 링크 꺾인점 부분 라운드 처리 여부	:VARCHAR2(10) 
		IxTAG =13,			// 태그 속성	:VARCHAR2(60) 
		IxTEXT =14,			// 텍스트	:VARCHAR2(60) 
		IxTEXTCOLOR =15,			// 텍스트 색깔	:VARCHAR2(10) 
		IxTOOLTIP =16,			// 툴팁	:VARCHAR2(60) 
		 
	}  

	/// <summary> 
	/// NODE_DEF : 노드 속성 지정해 주기 위한 인덱스
	/// </summary> 
	public enum NODE_DEF : int 
	{   
		IxALIGNMENT =5,			// 텍스트 정렬 방식	:VARCHAR2(10) 
		IxDASHSTYLE =6,			// 노드 테두리 스타일	:VARCHAR2(10) 
		IxDRAWCOLOR =7,			// 노드 테두리 색깔	:VARCHAR2(10) 
		IxDRAWWIDTH =8,			// 노드 테두리 선 두께	:VARCHAR2(10) 
		IxFILLCOLOR =9,			// 노드 채우기 색깔	:VARCHAR2(10) 
		IxFONT =10,			// 텍스트 폰트 속성	:VARCHAR2(60) 
		IxGRADI_YN =11,			// GRADIANT 여부	:VARCHAR2(1) 
		IxGRADICOLOR =12,			// GRADIANT 색깔	:VARCHAR2(10) 
		IxGRADIMODE =13,			// GRADIANT 모드 (스타일)	:VARCHAR2(10) 
		IxHEIGHT =14,			// 노드 높이	:VARCHAR2(10) 
		IxSHADOW =15,			// 노드 그림자 표시 속성	:VARCHAR2(60) 
		IxSHAPE =16,			// 노드 테두리 모양 속성	:VARCHAR2(60) 
		IxTAG =17,			// 태그 속성	:VARCHAR2(60) 
		IxTEXT =18,			// 텍스트	:VARCHAR2(60) 
		IxTEXTCOLOR =19,			// 텍스트 표시 색깔	:VARCHAR2(10) 
		IxTOOLTIP =20,			// 툴팁	:VARCHAR2(60) 
		IxWIDTH =21,			// 노드 너비	:VARCHAR2(10) 
		 
	}  






	/// <summary> 
	/// NODE_DEF : 노드 속성 지정해 주기 위한 인덱스
	/// </summary> 
	public enum DEFAULT_NODE_DEF: int 
	{   
		IxALIGNMENT = 0,			// 텍스트 정렬 방식	:VARCHAR2(10) 
		IxDASHSTYLE = 1,			// 노드 테두리 스타일	:VARCHAR2(10) 
		IxDRAWCOLOR = 2,			// 노드 테두리 색깔	:VARCHAR2(10) 
		IxDRAWWIDTH = 3,			// 노드 테두리 선 두께	:VARCHAR2(10) 
		IxFILLCOLOR = 4,			// 노드 채우기 색깔	:VARCHAR2(10) 
		IxFONT = 5,			// 텍스트 폰트 속성	:VARCHAR2(60) 
		IxGRADI_YN = 6,			// GRADIANT 여부	:VARCHAR2(1) 
		IxGRADICOLOR = 7,			// GRADIANT 색깔	:VARCHAR2(10) 
		IxGRADIMODE = 8,			// GRADIANT 모드 (스타일)	:VARCHAR2(10) 
		IxHEIGHT = 9,			// 노드 높이	:VARCHAR2(10) 
		IxSHADOW = 10,			// 노드 그림자 표시 속성	:VARCHAR2(60) 
		IxSHAPE = 11,			// 노드 테두리 모양 속성	:VARCHAR2(60) 
		IxTAG = 12,			// 태그 속성	:VARCHAR2(60) 
		IxTEXT = 13,			// 텍스트	:VARCHAR2(60) 
		IxTEXTCOLOR = 14,			// 텍스트 표시 색깔	:VARCHAR2(10) 
		IxTOOLTIP = 15,			// 툴팁	:VARCHAR2(60) 
		IxWIDTH = 16,			// 노드 너비	:VARCHAR2(10) 
		 
	}  





	#endregion

	public enum TBSCM_CODE : int 
	{ 
		IxMaxCt = 16,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxCOM_CD =2,			// 공통 코드	:VARCHAR2(10) 
		IxCOM_SEQ =3,			// 코드 일련번호	:NUMBER(22) 
		IxCOM_NAME =4,			// 코드명	:VARCHAR2(60) 
		IxSYSTEM_YN =5,			// 시스템 코드 여부	:VARCHAR2(1) 
		IxCOM_VALUE1 =6,			// 코드값 1	:VARCHAR2(20) 
		IxCOM_DESC1 =7,			// 코드 설명 1	:VARCHAR2(50) 
		IxCOM_VALUE2 =8,			// 코드값 2	:VARCHAR2(20) 
		IxCOM_DESC2 =9,			// 코드 설명 2	:VARCHAR2(50) 
		IxCOM_VALUE3 =10,			// 코드값 3	:VARCHAR2(20) 
		IxCOM_DESC3 =11,			// 코드 설명 3	:VARCHAR2(50) 
		IxCOM_VALUE4 =12,			// 코드값 4	:VARCHAR2(20) 
		IxCOM_DESC4 =13,			// 코드 설명 4	:VARCHAR2(50) 
		IxREMARKS =14,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =15,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =16,			// 작성일자	:DATE(7) 
	}  

	public enum TBSCM_TABLE : int 
	{ 
		IxMaxCt = 31,		// 인덱스 Count 
		IxPG_ID =0,			// 프로그램 아이디	:VARCHAR2(20) 
		IxPG_SEQ =1,			// 프로그램 SEQ	:NUMBER(22) 
		IxCOL_NAME =2,			// 컬럼명 (디비필드명)	:VARCHAR2(20) 
		IxCOL_ORDER =3,			// 컬럼 순번 (표시순번)	:NUMBER(22) 
		IxTABLE_NAME =4,			// 테이블명	:VARCHAR2(20) 
		IxHEAD_DESC1 =5,			// 헤더명(1)	:VARCHAR2(100) 
		IxHEAD_DESC2 =6,			// 헤더명(2)	:VARCHAR2(100) 
		IxHEAD_DESC3 =7,			// 헤더명(3)	:VARCHAR2(100) 
		IxHEAD_DESC4 =8,			// 헤더명(4)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC1 =9,			// 언어 헤더명(1)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC2 =10,			// 언어 헤더명(2)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC3 =11,			// 언어 헤더명(3)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC4 =12,			// 언어 헤더명(4)	:VARCHAR2(100) 
		IxWIDTH =13,			// 컬럼 너비	:NUMBER(22) 
		IxLOCK_YN =14,			// 에디트 가능 여부	:VARCHAR2(1) 
		IxVISIBLE_YN =15,			// VISIBLE 여부	:VARCHAR2(1) 
		IxAUTOSORT_YN =16,			// 자동소트 여부	:VARCHAR2(1) 
		IxHALIGN =17,			// 수평 정렬	:VARCHAR2(10) 
		IxVALIGN =18,			// 수직 정렬	:VARCHAR2(10) 
		IxMAXROW =19,			// 최대 행 수 : 처음 표시될 때 보여지는 행수 지정	:NUMBER(22) 
		IxFROZENCOL =20,			// FROZEN COLUMN	:NUMBER(22) 
		IxFROZENROW =21,			// FROZEN ROW	:NUMBER(22) 
		IxBACKCOLOR =22,			// 배경색	:VARCHAR2(10) 
		IxFORECOLOR =23,			// 글자색	:VARCHAR2(10) 
		IxCELLTYPE =24,			// 셀타입	:VARCHAR2(10) 
		IxDATA_LIST_TYPE =25,			// 셀타입이 콤보박스일때 공통코드 또는 쿼리 이용 여부 설정 (공통코드 : 0, 쿼리 : 1)	:VARCHAR2(1) 
		IxDATA_LIST_CD =26,			// DATA_LIST_TYPE = 0 일때 공통코드 기재	:VARCHAR2(10) 
		IxDATA_LIST_QUERY =27,			// DATA_LIST_TYPE = 1 일때 쿼리 기재	:VARCHAR2(500) 
		//이정한 추가
		IxESSENTIAL_YN = 28,
		IxCHAR_CASE = 29,
		IxMAX_NUMBER = 30,
		IxMIN_NUMBER = 31,
		IxMAX_WIDTH = 32,
		IxREMARKS =33,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =34,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =35,			// 작성일자	:DATE(7) 
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
