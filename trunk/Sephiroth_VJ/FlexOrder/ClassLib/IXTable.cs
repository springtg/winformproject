using System;
using System.Drawing;

namespace FlexOrder.ClassLib
{


	/// <summary>
	/// IXTable에 대한 요약 설명입니다.
	/// </summary>
	/// <summary> 
	/// SPS_TABLE 테이블 인덱스 Class 
	/// </summary> 
	public class TBSPS_TABLE
	{ 

		/// <summary>
		/// Grid의 칼럼0 의 width
		/// </summary>
		public static int GridCol0_Width = 20;			
		/// <summary>
		/// Grid의 칼럼0 의 color
		/// </summary>
		public static Color GridCol0_Color = Color.FromArgb(236, 247, 187);	


		public static int IxPG_ID =1;			// 프로그램 아이디	:VARCHAR2(20) 
		public static int IxPG_SEQ =2;			// 프로그램 SEQ	:NUMBER(22) 
		public static int IxCOL_ORDER =3;			// 컬럼 순번 (표시순번)	:NUMBER(22) 
		public static int IxTABLE_NAME =4;			// 테이블명	:VARCHAR2(20) 
		public static int IxCOL_NAME =5;			// 컬럼명 (디비필드명)	:VARCHAR2(20) 
		public static int IxHEAD_DESC1 =6;			// 상단 헤더명	:VARCHAR2(100) 
		public static int IxHEAD_DESC2 =7;			// 하단 헤더명	:VARCHAR2(100) 
		public static int IxWIDTH =8;			// 컬럼 너비	:NUMBER(22) 
		public static int IxLOCK_YN =9;			// 에디트 가능 여부	:VARCHAR2(1) 
		public static int IxVISIBLE_YN =10;			// VISIBLE 여부	:VARCHAR2(1) 
		public static int IxAUTOSORT_YN =11;			// 자동소트 여부	:VARCHAR2(1) 
		public static int IxHALIGN =12;			// 수평 정렬	:VARCHAR2(10) 
		public static int IxVALIGN =13;			// 수직 정렬	:VARCHAR2(10) 
		public static int IxMAXROW =14;			// 최대 행 수 : 처음 표시될 때 보여지는 행수 지정	:NUMBER(22) 
		public static int IxFROZENCOL =15;			// FROZEN COLUMN	:NUMBER(22) 
		public static int IxFROZENROW =16;			// FROZEN ROW	:NUMBER(22) 
		public static int IxBACKCOLOR =17;			// 배경색	:VARCHAR2(10) 
		public static int IxFORECOLOR =18;			// 글자색	:VARCHAR2(10) 
		public static int IxCELLTYPE =19;			// 셀타입	:VARCHAR2(10) 
		public static int IxDATA_LIST_TYPE =20;			// 셀타입이 콤보박스일때 공통코드 또는 쿼리 이용 여부 설정 (공통코드 : 0, 쿼리 : 1)	:VARCHAR2(1) 
		public static int IxDATA_LIST_CD =21;			// DATA_LIST_TYPE = 0 일때 공통코드 기재	:VARCHAR2(10) 
		public static int IxDATA_LIST_QUERY =22;			// DATA_LIST_TYPE = 1 일때 쿼리 기재	:VARCHAR2(500) 
		public static int IxREMARKS =23;			// 비고	:VARCHAR2(100) 
		public static int IxUPD_USER =24;			// 작성자	:VARCHAR2(10) 
		
		
		public TBSPS_TABLE() 
		{ 
		} 

	}



	/// <summary> 
	/// TBSEM_BP_DIFF 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_OA_CREATE01 : int 
	{ 
		IxMaxCt = 16,		// 인덱스 Count 

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
	/// TBSEM_BP_DIFF 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_OA_CREATE02 : int 
	{ 
		IxMaxCt = 10,		// 인덱스 Count 
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
	/// TBSEM_OBS_OA_CREATE03 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_OA_CREATE03 : int 
	{ 

		IxMaxCt = 20,		// 인덱스 Count 

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
	/// TBSEM_OBS_OA_CREATE03 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_OA_CREATE04 : int 
	{ 

		IxMaxCt = 8,		// 인덱스 Count 

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
	/// TBSEM_BP_DIFF 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_OA_INFORMATION : int 
	{ 
		IxMaxCt = 12,		// 인덱스 Count 

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



 
	/// <summary> 
	/// TBSEM_BP_DIFF 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_BP_DIFF : int 
	{ 
		IxMaxCt = 9,		// 인덱스 Count 

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
	///SEM_OBS_ANALYSIS 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_ANALYSIS : int 
	{ 
//		IxMaxCt = 20,		// 인덱스 Count 
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
	///TBSEM_OBS_PROFIT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_PROFIT : int 
	{ 
		IxMaxCt = 13,		// 인덱스 Count 

		
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
	/// SCM_TABLE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSCM_TABLE : int 
	{ 
		IxMaxCt = 31,		// 인덱스 Count 
		IxPG_ID =1,			// 프로그램 아이디	:VARCHAR2(20) 
		IxPG_SEQ =2,			// 프로그램 SEQ	:NUMBER(22) 
		IxCOL_NAME =3,			// 컬럼명 (디비필드명)	:VARCHAR2(20) 
		IxCOL_ORDER =4,			// 컬럼 순번 (표시순번)	:NUMBER(22) 
		IxTABLE_NAME =5,			// 테이블명	:VARCHAR2(20) 
		IxHEAD_DESC1 =6,			// 헤더명(1)	:VARCHAR2(100) 
		IxHEAD_DESC2 =7,			// 헤더명(2)	:VARCHAR2(100) 
		IxHEAD_DESC3 =8,			// 헤더명(3)	:VARCHAR2(100) 
		IxHEAD_DESC4 =9,			// 헤더명(4)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC1 =10,			// 언어 헤더명(1)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC2 =11,			// 언어 헤더명(2)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC3 =12,			// 언어 헤더명(3)	:VARCHAR2(100) 
		IxLAN_HEAD_DESC4 =13,			// 언어 헤더명(4)	:VARCHAR2(100) 
		IxWIDTH =14,			// 컬럼 너비	:NUMBER(22) 
		IxLOCK_YN =15,			// 에디트 가능 여부	:VARCHAR2(1) 
		IxVISIBLE_YN =16,			// VISIBLE 여부	:VARCHAR2(1) 
		IxAUTOSORT_YN =17,			// 자동소트 여부	:VARCHAR2(1) 
		IxHALIGN =18,			// 수평 정렬	:VARCHAR2(10) 
		IxVALIGN =19,			// 수직 정렬	:VARCHAR2(10) 
		IxMAXROW =20,			// 최대 행 수 : 처음 표시될 때 보여지는 행수 지정	:NUMBER(22) 
		IxFROZENCOL =21,			// FROZEN COLUMN	:NUMBER(22) 
		IxFROZENROW =22,			// FROZEN ROW	:NUMBER(22) 
		IxBACKCOLOR =23,			// 배경색	:VARCHAR2(10) 
		IxFORECOLOR =24,			// 글자색	:VARCHAR2(10) 
		IxCELLTYPE =25,			// 셀타입	:VARCHAR2(10) 
		IxDATA_LIST_TYPE =26,			// 셀타입이 콤보박스일때 공통코드 또는 쿼리 이용 여부 설정 (공통코드 : 0, 쿼리 : 1)	:VARCHAR2(1) 
		IxDATA_LIST_CD =27,			// DATA_LIST_TYPE = 0 일때 공통코드 기재	:VARCHAR2(10) 
		IxDATA_LIST_QUERY =28,			// DATA_LIST_TYPE = 1 일때 쿼리 기재	:VARCHAR2(500) 
		IxREMARKS =29,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =30,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =31,			// 작성일자	:DATE(7) 
	}  

//
//
//
//	/// <summary> 
//	/// SCM_TABLE 테이블 인덱스 Enum 
//	/// </summary> 
//	public enum TBSCM_TABLE : int 
//	{ 
//		IxMaxCt = 31,		// 인덱스 Count 
//		IxPG_ID =1,			// 프로그램 아이디	:VARCHAR2(20) 
//		IxPG_SEQ =2,			// 프로그램 SEQ	:NUMBER(22) 
//		IxCOL_NAME =3,			// 컬럼명 (디비필드명)	:VARCHAR2(20) 
//		IxCOL_ORDER =4,			// 컬럼 순번 (표시순번)	:NUMBER(22) 
//		IxTABLE_NAME =5,			// 테이블명	:VARCHAR2(20) 
//		IxHEAD_DESC1 =6,			// 헤더명(1)	:VARCHAR2(100) 
//		IxHEAD_DESC2 =7,			// 헤더명(2)	:VARCHAR2(100) 
//		IxHEAD_DESC3 =8,			// 헤더명(3)	:VARCHAR2(100) 
//		IxHEAD_DESC4 =9,			// 헤더명(4)	:VARCHAR2(100) 
//		IxLAN_HEAD_DESC1 =10,			// 언어 헤더명(1)	:VARCHAR2(100) 
//		IxLAN_HEAD_DESC2 =11,			// 언어 헤더명(2)	:VARCHAR2(100) 
//		IxLAN_HEAD_DESC3 =12,			// 언어 헤더명(3)	:VARCHAR2(100) 
//		IxLAN_HEAD_DESC4 =13,			// 언어 헤더명(4)	:VARCHAR2(100) 
//		IxWIDTH =14,			// 컬럼 너비	:NUMBER(22) 
//		IxLOCK_YN =15,			// 에디트 가능 여부	:VARCHAR2(1) 
//		IxVISIBLE_YN =16,			// VISIBLE 여부	:VARCHAR2(1) 
//		IxAUTOSORT_YN =17,			// 자동소트 여부	:VARCHAR2(1) 
//		IxHALIGN =18,			// 수평 정렬	:VARCHAR2(10) 
//		IxVALIGN =19,			// 수직 정렬	:VARCHAR2(10) 
//		IxMAXROW =20,			// 최대 행 수 : 처음 표시될 때 보여지는 행수 지정	:NUMBER(22) 
//		IxFROZENCOL =21,			// FROZEN COLUMN	:NUMBER(22) 
//		IxFROZENROW =22,			// FROZEN ROW	:NUMBER(22) 
//		IxBACKCOLOR =23,			// 배경색	:VARCHAR2(10) 
//		IxFORECOLOR =24,			// 글자색	:VARCHAR2(10) 
//		IxCELLTYPE =25,			// 셀타입	:VARCHAR2(10) 
//		IxDATA_LIST_TYPE =26,			// 셀타입이 콤보박스일때 공통코드 또는 쿼리 이용 여부 설정 (공통코드 : 0, 쿼리 : 1)	:VARCHAR2(1) 
//		IxDATA_LIST_CD =27,			// DATA_LIST_TYPE = 0 일때 공통코드 기재	:VARCHAR2(10) 
//		IxDATA_LIST_QUERY =28,			// DATA_LIST_TYPE = 1 일때 쿼리 기재	:VARCHAR2(500) 
//		IxREMARKS =29,			// 비고	:VARCHAR2(100) 
//		IxUPD_USER =30,			// 작성자	:VARCHAR2(10) 
//		IxUPD_YMD =31,			// 작성일자	:DATE(7) 
//	}  
//


	/// <summary> 
	/// SPC_CODE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPC_CODE : int 
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



	/// <summary> 
	/// SPB_FACTORY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_FACTORY : int 
	{ 
		IxMaxCt = 7,		// 인덱스 Count 
		IxFACTORY =1,			// 공장코드	:VARCHAR2(5) 
		IxFACTORY_NAME =2,			// 공장명	:VARCHAR2(20) 
		IxADDRESS =3,			// 주소지	:VARCHAR2(60) 
		IxCAL_TYPE =4,			// 대표 카렌더 타입	:VARCHAR2(10) 
		IxREMARKS =5,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =6,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =7,			// 작성일자	:DATE(7) 
	}  


	/// <summary> 
	/// SPB_AREA 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_AREA : int 
	{ 
		IxMaxCt = 9,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxAREA_CD =2,			// 작업장 코드	:VARCHAR2(10) 
		IxAREA_NAME =3,			// 작업장 명	:VARCHAR2(60) 
		IxCAL_TYPE =4,			// 대표 카렌더 타입	:VARCHAR2(10) 
		IxAREA_DIV =5,			// 작업장 구분 (내주, 외주)	:VARCHAR2(10) 
		IxWORK_CHARGE =6,			// 작업 담당자	:VARCHAR2(12) 
		IxREMARKS =7,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =8,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =9,			// 작성일자	:DATE(7) 
	}  


	/// <summary> 
	/// SPB_NODE_AREA 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_NODE_AREA : int 
	{ 
		IxMaxCt = 23,		// 인덱스 Count 
		//		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxAREA_CD =1,			// 작업장 코드	:VARCHAR2(10) 
		IxAREA_NAME =2,			// 작업장명
		IxLEFT =3,			// 노드 왼쪽 좌표	:VARCHAR2(10) 
		IxTOP =4,			// 노드 위 좌표	:VARCHAR2(10) 
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
		IxUPD_USER =22,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =23,			// 작성일자	:DATE(7) 
	}  




	/// <summary> 
	/// SEM_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_SIZE : int 
	{  
		IxMaxCt    = 12,		// 인덱스 Count 
		lxFACTORY  =  1,        // 공장 구분            :VARCHAR2(5) 
		IxGEN      =  2,		// 창신 성별			:VARCHAR2(2) 
		IxPST_YN   =  3,		// PRESTO SIZE구분		:VARCHAR2(1) 
		IxCS_SIZE  =  4,		// CHANG SHIN SIZE		:VARCHAR2(10) 
		IxUS_SIZE  =  5,		// AMERICA SIZE			:VARCHAR2(10) 
		IxUK_SIZE  =  6,		// UNITED KINGDOM SIZE	:VARCHAR2(10) 
		IxEU_SIZE  =  7,		// EUROPE SIZE			:VARCHAR2(10) 
		IxCM_SIZE  =  8,		// CENTIMETER SIZE		:NUMBER(22) 
		IxGEN_DESC =  9,		// GENDER DESCRIPTION	:VARCHAR2(20) 
		IxREMARKS  = 10,		// 주석					:VARCHAR2(50) 
		IxUPD_USER = 11,		// 등록일자				:VARCHAR2(10) 
		IxUPD_YMD  = 12,		// 등록일				:DATE(7) 
	}  



	/// <summary> 
	/// SEM_REGION 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_REGION : int 
	{ 
		IxMaxCt        = 9,		// 인덱스 Count 
		IxFACTORY      = 1,		// 공장구분   	:VARCHAR2(5) 
		IxREGION_CD    = 2,		// 지역       	:VARCHAR2(7) 
		IxREGION       = 3,		// 지역       	:VARCHAR2(7) 
		IxREGION_NAME  = 4,		// 지역명     	:VARCHAR2(15) 
		IxREGION_PRITY = 5,		// 행선지     	:NUMBER(22) 
		IxTYPE         = 6,		// TYPE       	:VARCHAR2(30) 
		IxREMARKS      = 7,		// 주석       	:VARCHAR2(50) 
		IxUPD_USER     = 8,		// 등록자     	:VARCHAR2(10) 
		IxUPD_YMD      = 9,		// 등록일자   	:DATE(7) 
	}  


	/// <summary> 
	/// POI DBF 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_POI : int 
	{ 
		IxMaxCt      = 24,		 // 인덱스 Count 
		lxFlag       = 0,        // [+], [-] check
		lxDiv        = 1,        // Division 
		lxStyle      = 2,        // 스타일체크
		lxModel      = 3,        // 모델체크
		lxGender     = 4,        // 젠더체크
		lxPresto     = 5,        // 프레스토체크
		lxGSSC       = 6,        // GSSC체크
		lxDest       = 7,        // Dest체크
		lxFACTORY    = 8,        // FACTORY
		lxPO_NU      = 9,        // PO No.
		lxITM_SEQ_NU = 10,        // Seq No.
		lxCHG_NU     = 11,        // CHANGE No.
		IxSTYLE      = 19,		 // 스타일		
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
	/// SEM_POI 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_POIS : int 
	{ 
		IxMaxCt      =  6,	// 인덱스 Count 
		IxGPC_NU     =  8,	// GPC_NU        
		IxOBS_NU     =  9,	// DPO번호       
		IxOBS_SEQ_NU = 10,	// DPO순번   
		lxSIZE_SCL   = 77,       // SIZE_SCL
		lxTOT_QTY    = 52,       // TOTAL QTY
		lxORD_QTY    = 91,       // SIZE QTY    
	}  

	/// <summary> 
	/// SEM_TMP_POI 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_TMP_POI : int 
	{ 
		IxMaxCt      =  7,	// 인덱스 Count 
		IxFACTORY    =  0,	// FACTORY
		IxOBS_NU     =  1,	// DPO번호       
		IxOBS_SEQ_NU =  2,	// DPO순번   
		lxSIZE_SCL   =  3,  // SIZE_SCL
		lxTOT_QTY    =  4,  // TOTAL QTY
		lxORD_QTY    =  5,  // SIZE QTY    
		lxCHG_NU     =  6,  // SEQUENCE NUMBER
	}  

	/// <summary> 
	/// SEM_STY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_STY : int 
	{ 
		IxMaxCt = 11,		// 인덱스 Count 
		IxFACTORY =1,		// 공장구분	:VARCHAR2(2) 
		IxSTYLE_CD =2,		// 스타일 코드 	:VARCHAR2(9) 
		IxGPC_NU =3,		// 공장코드	:VARCHAR2(2) 
		IxDIM =4,			// 치수	:VARCHAR2(2) 
		IxSTYLE_LN =5,		// 스타일 - SHORT NAME	:VARCHAR2(30) 
		IxSTYLE_SN =6,		// 스타일 - LONG NAME	:VARCHAR2(15) 
		IxCOLOR_LN =7,		// 칼라 - LONG NAME	:VARCHAR2(30) 
		IxCOLOR_SN =8,		// 칼라 - SHORT NAME	:VARCHAR2(15) 
		IxREMARKS =9,		// 주석	:VARCHAR2(50) 
		IxUPD_USER =10,		// 등록자	:VARCHAR2(10) 
		IxUPD_YMD =11,		// 등록일자	:DATE(7) 
	}  



	/// <summary> 
	/// SEM_EKKO_N 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_EKKO : int 
	{ 
		IxMaxCt = 26,		// 인덱스 Count 
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


	
	/// SEM_EKPO 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_EKPO : int 
	{ 
		IxMaxCt = 70,		// 인덱스 Count 

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
	/// SEM_UPC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_UPC : int 
	{ 
		IxMaxCt			= 12,		// 인덱스 Count 
	 
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
	/// SEM_OBS_GAC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_GAC : int 
	{ 
		IxMaxCt = 12,		// 인덱스 Count 

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
	/// SEM_EKET 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_EKET : int 
	{ 
		IxMaxCt = 23,		// 인덱스 Count 
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
	/// SEM_MARA 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_MARA : int 
	{ 
		IxMaxCt = 26,		// 인덱스 Count 
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
	/// SEM_CRTN 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_CRTN : int 
	{ 
		IxMaxCt = 13,		// 인덱스 Count 
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
	/// SEM_CRTNH 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_CRTNH : int 
	{ 
		IxMaxCt = 6,		// 인덱스 Count 
		IxFACTORY =1,			// 	:VARCHAR2(5) 
		IxUCC_NU =2,			// 	:VARCHAR2(5)  
		IxEBELN =3,			// 	:VARCHAR2(9) 
		IxEBELP =4,			// 	:DATE(7) 
		lxUPD_USER =5,
		lxUPD_YMD =6,
	}  


	/// <summary> 
	/// SEM_CRTNI 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_CRTNI : int 
	{ 
		IxMaxCt = 8,		// 인덱스 Count 
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
	/// SEM_REQ 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_REQ : int 
	{ 
		IxMaxCt      = 6,	// 인덱스 Count 
		lxFLAG       = 1,	// 작업
		IxFACTORY    = 2,	// 공장구분             		:VARCHAR2(5) 
		IxREQ_NO     = 3,	// 생산의뢰 순번      			:VARCHAR2(11) 
		IxOBS_NU     = 4,	// OBS 번호           			:VARCHAR2(10) 
		IxOBS_SEQ_NU = 5,	// OBS 순번            			:VARCHAR2(10) 
		lxCHG_NU     = 6,	// OBS 변경순번        			:VARCHAR2(10) 
		lxPLAN_DIV   =28,	//오더 계획 반영구분        	:VARCHAR2(1) 
	}  

	/// <summary> 
	/// SEM_CAL_INFO 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_CAL_INFO : int 
	{ 
		IxMaxCt = 16,		// 인덱스 Count 
		IxFACTORY =1,		// FACTORY
		IxSEASON_CD  =2,		// SEASON           	:VARCHAR2(6) 
		IxTCMMT_YMD =3,		// TIMME COMMIT WEEK	:VARCHAR2(8) 
		IxECMMT_YMD =4,		// EVENT COMMIT WEEK	:VARCHAR2(8) 
		IxLLTMAT_DATE =5,	// LLT 자재 요청일  	:VARCHAR2(8) 
		IxOBS_ID =6,		// OBS 구분         	:VARCHAR2(6) 
		IxBP_NO =7,			// BP NO            	:VARCHAR2(8) 
		lxECMMT_OBS_ID = 8, // Event Commit OBS ID
		IxGAC_YMD =9,		// 	:VARCHAR2(8) 
		IxPO_CUTOFF =10,		// PO CUT OFF
		IxLATE_USA =11,		// PO CUT OFF (USA) 	:VARCHAR2(8) 
		IxLATE_NEON =12,	// NEON  PO CUT OFF 	:VARCHAR2(8) 
		IxDEL_MONTH =13,	// 완제품 운송 기간 	:VARCHAR2(8) 
		IxSALES_MONTH =14,	// 완제품 판매 기간 	:VARCHAR2(8) 
		IxOBS_RCPT_YMD =15,	// OBS 수령일       	:VARCHAR2(8) 
		IxSET_COLOR =16,	// 칼라설정         	:VARCHAR2(11) 
	}

	/// <summary> 
	/// SEM_BP 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_BP : int 
	{ 
		IxMaxCt = 38,			// 인덱스 Count 
		lxStyle      = 1,        // 스타일체크
		lxModel      = 2,        // 모델체크
		lxGender     = 3,        // 젠더체크
		lxPresto     = 4,        // 프레스토체크
		lxGSSC       = 5,        // GSSC체크
		lxRegion     = 6,        // Dest체크
		IxFACTORY	 = 7,			// 공장구분    					:VARCHAR2(2) 
		IxSTYLE_CD =8,			// 스타일 코드 					:VARCHAR2(9) 
		IxSTYLE_NAME =9,		// STYLE 명                   	:VARCHAR2(60) 
		IxDEL_MONTH =10,			// 운송월						:VARCHAR2(8) 
		IxREGION =11,			// REGION      					:VARCHAR2(7) 
		IxBP_NO =12,				// LASTING WEEK					:VARCHAR2(8) 
		IxPRD_QTY =13,			// 오더수량    					:NUMBER(22) 
		IxBTO_DT =14,			// 								:VARCHAR2(8) 		
		IxFACTORY_GRP =15,		// 첫번째 OUTSOLE             	:VARCHAR2(3) 
		IxOUT_SOLE_01 =16,		// 첫번째 MIDSOLE             	:VARCHAR2(10) 
		IxMID_SOLE_01 =17,		// 개발코드                   	:VARCHAR2(10) 
		IxDEV_CD =18,			// 생산코드                   	:VARCHAR2(6) 
		IxPROD_ID =19,			// 공장 GROUP                 	:VARCHAR2(13) 
		IxFACTORY_CTRY_CD =20,	// 공장 국가 CODE             	:VARCHAR2(4) 
		IxPG_DEV_FCTY =21,		// 개발 공장 CODE             	:VARCHAR2(2) 
		IxIPW =22,				// 최초 제조 투입일           	:VARCHAR2(8) 
		IxAIRBAG_01 =23,		// 첫번째 AIRBAG              	:VARCHAR2(10) 
		IxAIRBAG_02 =24,		// 두번째 AIRBAG              	:VARCHAR2(10) 
		IxAIRBAG_03 =25,		// 세번째 AIRBAG              	:VARCHAR2(10) 
		IxPROD_LINE_CD =26,		// 생산라인 CODE              	:VARCHAR2(10) 
		IxPROD_LINE_DESC =27,	// 생산라인 설명서            	:VARCHAR2(2) 
		IxPROD_CAT_CD =28,		// 생산품 CATEGORY CODE       	:VARCHAR2(30) 
		IxPROD_CAT_DESC =29,	// 생산품 CATEGORY 설명서     	:VARCHAR2(2) 
		IxNIKE_GEN_DESC =30,	// 성별 설명서                	:VARCHAR2(30) 
		IxTYPE_GROUP_NAME =31,	// 개발 유형                  	:VARCHAR2(20) 
		IxLAST_CD =32,			// LAST CODE                  	:VARCHAR2(8) 
		IxTOOL_WK_CAP =33,		// 주별 TOOLING CAPACITY      	:NUMBER(22) 
		IxREMARKS =34,			// 주   석						:VARCHAR2(50) 
		IxDOWN_YMD =35,			//
		IxERROR_YN =36,			// 
		IxUPD_USER =37,			//
		IxUPD_YMD =38,			// 
	}  


	/// <summary> 
	/// SEM_BP 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_BP : int 
	{ 
		IxMaxCt = 16,		// 인덱스 Count 
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
	/// SEM_OBS_CS 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_CS : int 
	{ 
		IxMaxCt = 28,		// 인덱스 Count 
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
	/// TBSEM_OBS_CS_MUTI 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_CS_MUTI : int 
	{ 
		IxMaxCt = 30,		// 인덱스 Count 

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
	/// SEM_OBS_POP 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_POP : int 
	{ 
		IxMaxCt = 35,		// 인덱스 Count 
		IxFACTORY =1,			// 공장코드	:VARCHAR2(5) 
		IxOBS_NU =2,			// OBS번호	:VARCHAR2(10) 
		IxOBS_SEQ_NU =3,			// OBS순번	:VARCHAR2(10) 
		IxCHG_NU =4,			// 변경순번	:VARCHAR2(5) 
		IxSYMD =5,			// 시작일	:VARCHAR2(8) 
		IxEYMD =6,			// 끝일	:VARCHAR2(8) 
		IxOBS_DIV =7,			// GPO/DPO구분	:VARCHAR2(1) 
		IxDOC_YMD =8,			// ISSUEDATE	:VARCHAR2(8) 
		IxOBS_ID =9,			// OBSID	:VARCHAR2(6) 
		IxOBS_TYPE =10,			// OBS타입	:VARCHAR2(2) 
		IxSTYLE_CD =11,			// 스타일코드	:VARCHAR2(9) 
		IxGEN =12,			// 젠더	:VARCHAR2(2) 
		IxPST_YN =13,			// 프레스토구분	:VARCHAR2(1) 
		IxREQ_YN =14,			// 생산의뢰구분	:VARCHAR2(1) 
		IxOA_NU_BEF =15,			// 이전OA번호	:VARCHAR2(10) 
		IxOA_NU_AFT =16,			// 이후OA번호	:VARCHAR2(10) 
		IxDEST_PRITY =17,			// 행선지우선순위	:VARCHAR2(3) 
		IxDEST =18,			// 행선지	:VARCHAR2(7) 
		IxCUST_XREF =19,			// 고객요청지	:VARCHAR2(7) 
		IxWH =20,			// 창고	:VARCHAR2(7) 
		IxISEG =21,			// ISEG	:VARCHAR2(3) 
		IxTOT_QTY =22,			// 총오더수량	:NUMBER(22) 
		IxOGAC_YMD =23,			// OGAC_DATE	:VARCHAR2(8) 
		IxRTS_YMD =24,			// RTS일	:VARCHAR2(8) 
		IxCSETS_YMD =25,			// CSETS_DATE	:VARCHAR2(8) 
		IxCSETS_RSN =26,			// CSETS_REASON	:VARCHAR2(30) 
		IxCUS_REQ_YMD =27,			// CUSTOMERREQUESTDATE	:VARCHAR2(8) 
		IxDELIV_YMD =28,			// DELIVERY_DATE	:VARCHAR2(8) 
		IxSTA_DELIV_YMD =29,			// STATIC_DELIVERY_DATE	:VARCHAR2(8) 
		IxMSR_DIV =30,			// MUSICALPACKING구분	:VARCHAR2(1) 
		IxCRTN_QTY =31,			// CARTON수량	:NUMBER(22) 
		IxTOTCRTN_QTY =32,			// 총CARTON수량	:NUMBER(22) 
		IxREMARKS =33,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =34,			// 작성자	:VARCHAR2(30) 
		IxUPD_YMD =35,			// 작성일	:DATE(7) 

	}


	
	/// <summary> 
	/// SEM_OBS_POP 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_CSOBS_POP : int 
	{ 
		IxMaxCt = 26,		// 인덱스 Count 
		IxFACTORY =1,			// 공장코드	:VARCHAR2(5) 
		IxOBS_NU =2,			// OBS번호	:VARCHAR2(10) 
		IxOBS_SEQ_NU =3,			// OBS순번	:VARCHAR2(10) 
		IxCHG_NU =4,			// 변경순번	:VARCHAR2(5) 
		IxSYMD =5,			// 시작일	:VARCHAR2(8) 
		IxEYMD =6,			// 끝일	:VARCHAR2(8) 
		IxOBS_DIV =7,			// GPO/DPO구분	:VARCHAR2(1) 
		IxJOB_DIV =8,			// 작업구분	:VARCHAR2(2) 
		IxBP_NO =9,			// BP번호(원시)	:VARCHAR2(8) 
		IxREGION =10,			// 지역구분	:VARCHAR2(7) 
		IxOBS_ID =11,			// OBSID	:VARCHAR2(6) 
		IxOBS_TYPE =12,			// OBS타입	:VARCHAR2(2) 
		IxSTYLE_CD =13,			// 스타일코드	:VARCHAR2(9) 
		IxGEN =14,			// 젠더	:VARCHAR2(2) 
		IxPST_YN =15,			// 프레스토구분	:VARCHAR2(1) 
		IxREQ_YN =16,			// 생산의뢰구분	:VARCHAR2(1) 
		IxOA_NU_BEF =17,			// 이전OA번호	:VARCHAR2(10) 
		IxOA_NU_AFT =18,			// 이후OA번호	:VARCHAR2(10) 
		IxTOT_QTY =19,			// 총오더수량	:NUMBER(22) 
		IxOGAC_YMD =20,			// OGAC_DATE	:VARCHAR2(8) 
		IxRTS_YMD =21,			// RTS일	:VARCHAR2(8) 
		IxCSETS_YMD =22,			// CSETS_DATE	:VARCHAR2(8) 
		IxCSETS_RSN =23,			// CSETS_REASON	:VARCHAR2(30) 
		IxREMARKS =24,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =25,			// 작성자	:VARCHAR2(30) 
		IxUPD_YMD =26,			// 작성일	:DATE(7) 

	}







	/// <summary> 
	/// SEM_OBS_CS_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_CS_SIZE : int
	{
		IxMaxCt = 27,		// 인덱스 Count 
		IxFACTORY = 1,		// 공장구분           	:VARCHAR2(5) 
		IxSTYLE_CD = 2,		// 스타일코드         	:VARCHAR2(9) 
		IxSTYLE_NM = 3,		// 스타일코드         	:VARCHAR2(9) 
		lxFLAG = 4,
		lxREQ_NO = 5,
		lxREQ_SEQ_NU = 6,
		IxOBS_NU = 7,		// OBS 번호           	:VARCHAR2(10) 
		IxOBS_SEQ_NU = 8,	// OBS 순번           	:VARCHAR2(10) 
		IxCHG_NU = 9,		// 변경순번           	:VARCHAR2(5) 
		lxJOB_ID = 10,
		lxPLAN_DIV = 11,      //오더 계획 반영구분    :VARCHAR2(1) 
		IxOBS_DIV = 12,
		lxCS_REQ = 13,
		IxOBS_ID = 14,		// OBS ID             	:VARCHAR2(6) 
		IxOBS_TYPE = 15,		// OBS TYPE           	:VARCHAR2(2) 
		IxPST_YN = 16,		// 프레스토구분       	:VARCHAR2(1) 
		IxREQ_YN = 17,		// 프레스토구분       	:VARCHAR2(1) 
		IxOA_NU_BEF = 18,		// 프레스토구분       	:VARCHAR2(1) 
		IxOA_NU_AFT = 19,		// 프레스토구분       	:VARCHAR2(1) 
		IxREGION = 20,		// 지역               	:VARCHAR2(7) 
		IxRTS_YMD = 21,		// RTS DATE/OGAC_DATE 	:VARCHAR2(8) 
		IxCSETS_YMD = 22,	// CSETS_DATE/GAC_DATE	:VARCHAR2(8) 
		IxCSETS_RSN = 23,	// GAC REASON         	:VARCHAR2(30) 
		lxREQ_YMD = 24,
		lxOLD_REQ_NO = 25,
		IxTOT_QTY = 26,		// 총오더수량         	:NUMBER(22) 
		IxGEN = 27,			// GAC REASON         	:VARCHAR2(30) 



	}



	/// <summary> 
	/// TBSEM_STYLE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_STYLE : int 
	{ 
		IxMaxCt = 62,		    // 인덱스 Count 
		IxFACTORY =1,			// 공장구분                   	:VARCHAR2(5) 
		IxSTYLE_CD =2,			// STYLE 구분                 	:VARCHAR2(9) 
		IxSTYLE_NAME =3,		// STYLE 명                   	:VARCHAR2(60) 
		IxFACTORY_GRP =4,		// 첫번째 OUTSOLE             	:VARCHAR2(3) 
		IxOUT_SOLE_01 =5,		// 첫번째 MIDSOLE             	:VARCHAR2(10) 
		IxMID_SOLE_01 =6,		// 개발코드                   	:VARCHAR2(10) 
		IxDEV_CD =7,			// 생산코드                   	:VARCHAR2(6) 
		IxPROD_ID =8,			// 공장 GROUP                 	:VARCHAR2(13) 
		IxFACTORY_CTRY_CD =9,	// 공장 국가 CODE             	:VARCHAR2(4) 
		IxPG_DEV_FCTY =10,		// 개발 공장 CODE             	:VARCHAR2(2) 
		IxIPW =11,			    // 최초 제조 투입일           	:VARCHAR2(8) 
		IxAIRBAG_01 =12,		// 첫번째 AIRBAG              	:VARCHAR2(10) 
		IxAIRBAG_02 =13,		// 두번째 AIRBAG              	:VARCHAR2(10) 
		IxAIRBAG_03 =14,		// 세번째 AIRBAG              	:VARCHAR2(10) 
		IxPROD_LINE_CD =15,		// 생산라인 CODE              	:VARCHAR2(2) 
		IxPROD_LINE_DESC =16,	// 생산라인 설명서            	:VARCHAR2(10) 
		IxPROD_CAT_CD =17,		// 생산품 CATEGORY CODE       	:VARCHAR2(2) 
		IxPROD_CAT_DESC =18,	// 생산품 CATEGORY 설명서     	:VARCHAR2(30) 
		IxNIKE_GEN_DESC =19,	// 성별 설명서                	:VARCHAR2(30) 
		IxTYPE_GROUP_NAME =20,	// 개발 유형                  	:VARCHAR2(20) 
		IxLAST_CD =21,			// LAST CODE                  	:VARCHAR2(8) 
		IxTOOL_WK_CAP =22,		// 주별 TOOLING CAPACITY      	:NUMBER(22) 
		IxSEASON_CD =23,			// SEASON                     	:VARCHAR2(2) 
		IxYEAR =24,			    // 개발 년도                  	:VARCHAR2(4) 
		IxTD_CD =25,			// 	:VARCHAR2(2) 
		IxFIRM_IPW =26,			// 확정 IPW                   	:VARCHAR2(8) 
		IxCURR_IPW =27,			// 현재 IPW                   	:VARCHAR2(8) 
		IxIPM =28,			    // 	:VARCHAR2(10) 
		IxOUT_SOLE_02 =29,		// 두번째 OUTSOLE             	:VARCHAR2(10) 
		IxMID_SOLE_02 =30,		// 두번째 MIDSOLE             	:VARCHAR2(10) 
		IxOUT_SOLEMAT_01 =31,	// 첫번째 OUTSOLE 자재        	:VARCHAR2(2) 
		IxMID_SOLEMAT_01 =32,	// 첫번째 MIDSOLE 자재        	:VARCHAR2(2) 
		IxOUT_SOLEMAT_02 =33,	// 두번째 OUTSOLE자재         	:VARCHAR2(2) 
		IxMID_SOLEMAT_02 =34,	// 두번째 MIDSOLE 자재        	:VARCHAR2(2) 
		IxPRICE =35,			// 소매가                     	:NUMBER(22) 
		IxCONSMR_NAME =36,		// 소비자명                   	:VARCHAR2(30) 
		IxRFC_DATE =37,			// 개발 확정 일자             	:VARCHAR2(8) 
		IxCLT =38,			    // 	:VARCHAR2(20) 
		IxERST_SPEC_STATUS =39,	// 최초  SPEC상태             	:VARCHAR2(1) 
		IxERST_SPEC_CREATE =40,	// 최초 SPEC 생성일           	:VARCHAR2(8) 
		IxBVTN_DEV =41,			// BIVELTON 개발자            	:VARCHAR2(20) 
		IxASIA_DEV =42,			// ASIA 개발자                	:VARCHAR2(20) 
		IxSPRT_ACT_CD =43,		// SPORT CATEGORY CODE        	:VARCHAR2(30) 
		IxSPRT_ACT =44,			// SPORT CATEGORY             	:VARCHAR2(20) 
		IxKEY_MODEL =45,		// 	:VARCHAR2(10) 
		IxMFG_CHAR_01 =46,		// 	:VARCHAR2(10) 
		IxMFG_CHAR_02 =47,		// 	:VARCHAR2(10) 
		IxSILHOUETTE =48,		// 실루엣                     	:VARCHAR2(30) 
		IxCOLOR_DESC =49,		// COLOR 설명                 	:VARCHAR2(30) 
		IxCONST_CD =50,			// 	:VARCHAR2(2) 
		IxSTYLE_GRP =51,		// COLOR GROUP                	:VARCHAR2(6) 
		IxPRD_TYPE =52,			// 생산품 TYPE                	:VARCHAR2(10) 
		IxPRD_TYPE_GRP =53,		// 생산품 TYPE GROUP          	:VARCHAR2(30) 
		IxWHLSL_PRICE =54,		// 	:NUMBER(22) 
		IxSIZE_RANGE =55,		// SIZE 범위                  	:VARCHAR2(20) 
		IxCOLOR_VAR =56,		// 	:VARCHAR2(10) 
		IxLIFE_CYCLE =57,		// LIFE CYCLE                 	:VARCHAR2(10) 
		IxDUTY_RT_CD =58,		// 	:VARCHAR2(10) 
		IxBP_DATE =59,			// BP 수령일                  	:VARCHAR2(8) 
		IxREMARKS =60,			// 주석                       	:VARCHAR2(50) 
		IxUPD_USER =61,			// 등록자                     	:VARCHAR2(10) 
		IxUPD_YMD =62,			// 등록일자                   	:DATE(7) 
	}  

	/// <summary> 
	/// SEM_BP 테이블 인덱스 Enum 
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
     
//		IxMaxCt = 21,		// 인덱스 Count 
//		IxFACTORY_GRP =1,	// 공장구분    	:VARCHAR2(2) 
//		IxFACTORY =2,		// 공장구분    	:VARCHAR2(2) 
//		lxOUT_SOLE_01 =3,   // OS1
//		lxDEV_CD =4,        // 개발코드 
//		IxSTYLE_CD =5,		// 스타일 코드 	:VARCHAR2(9) 
//		lxPROD_ID=6,        // PROD_ID
//		IxSTYLE_NAME =7,	// 스타일 명 	:VARCHAR2(9) 
//		IxREGION =8,		// REGION      	:VARCHAR2(7) 
//		IxBTO_DT =9,		// 	:VARCHAR2(8) 
//		IxDEL_MONTH =10,	// 운송월      	:VARCHAR2(8) 
//		IxBP_NO =11,		// LASTING WEEK	:VARCHAR2(8) 
//		IxPRD_QTY =12,		// 오더수량    	:NUMBER(22) 
//		IxBP_NU =13,		// BP번호      	:VARCHAR2(10) 
//		IxBP_SEQ_NU =14,	// BP순번      	:VARCHAR2(10) 
//		IxCHG_NU =15,		// 변경순번    	:VARCHAR2(5) 
//		IxSYMD =16,			// 시작일자    	:VARCHAR2(8) 
//		IxEYMD =17,			// 끝일자      	:VARCHAR2(8) 
//		IxDOWN_YMD =18,		// 파일다운일자	:VARCHAR2(8) 
//		IxREMARKS =19,		// 주   석     	:VARCHAR2(50) 
//		IxUPD_USER =20,		// 작성자      	:VARCHAR2(10) 
//		IxUPD_YMD =21,		// 작성일자    	:DATE(7) 

	}  

	/// <summary> 
	/// SEM_OBS 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_Search : int 
	{ 
		IxMaxCt = 20,		// 인덱스 Count 
		IxSTYLE_CD =1,		// 스타일구분	:VARCHAR2(9) 
		IxSTYLE_NAME =2,		// 스타일구분	:VARCHAR2(9) 
		IxOBS_ID =3,		// OBS ID	:VARCHAR2(6) 
		IxOBS_TYPE =4,		// 오더 타입	:VARCHAR2(2) 
		IxOBS_NU =5,		// OBS 번호	:VARCHAR2(10) 
		IxOBS_SEQ_NU =6,	// OBS 순번	:VARCHAR2(10) 
		IxCHG_NU =7,		// 변경순번	:VARCHAR2(5) 
		IxOBS_DIV =8,		// GPO/DPO 구분	:VARCHAR2(1) 
		IxPST_YN =9,		// PRESTO구분	:VARCHAR2(1) 
		IxREQ_YN =10,		// REQ구분	:VARCHAR2(1) 
		IxOA_NU_BEF =11,	// OA NU - BEFORE	:VARCHAR2(10) 
		IxOA_NU_AFT =12,	// OA NU - AFTER	:VARCHAR2(10) 
		lxREGION = 13,      //REGION
		IxOGAC_YMD =14,		// RTS DATE/OGAC_DATE	:VARCHAR2(8) 
		IxRTS_YMD =15,		// RTS DATE/OGAC_DATE	:VARCHAR2(8) 
		IxCSETS_YMD =16,	// CSETS_DATE/GAC_DATE	:VARCHAR2(8) 
		IxCSETS_RSN =17,	// GAC REASON	:VARCHAR2(30) 
		IxMSR_DIV =18,		// 총오더수량	:NUMBER(22) 
		IxTOT_QTY =19,		// 총오더수량	:NUMBER(22) 
		IxGEN =20,			// 성별	:VARCHAR2(2) 
	}  



	

	/// <summary> 
	/// SEM_GSSC_SIMULATION 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_GSSC_SIMULATION: int 
	{ 

		IxMaxCt = 9,		// 인덱스 Count 
		IxFACTORY =1,		// 스타일구분	:VARCHAR2(9) 
		IxCATEGORY_CD =2,		// 스타일구분	:VARCHAR2(9) 
		IxCATEGORY_NAME =3,		// OBS ID	:VARCHAR2(6) 
		IxMODEL_CD =4,		// 오더 타입	:VARCHAR2(2) 
		IxMODEL_NAME =5,
		IxREGON_CD =6,		// OBS 번호	:VARCHAR2(10) 
		IxGENDER =7,	// OBS 순번	:VARCHAR2(10) 
		IxCS_SIZE =8,		// 변경순번	:VARCHAR2(5) 
		IxSIZE_QTY =9,		// GPO/DPO 구분	:VARCHAR2(1) 
		
	}  


	/// <summary> 
	/// SEM_GSSC_SIMULATION_TAIL 테이블 인덱스 Enum 
	/// </summary> 
	public enum SEM_GSSC_SIMULATION_TAIL: int 
	{ 

		IxMaxCt = 10,		// 인덱스 Count 
		IxFACTORY =1,		// 스타일구분	:VARCHAR2(9) 
		IxREGION =2,		// 스타일구분	:VARCHAR2(9) 
		IxSTYLE_CD =3,		// OBS ID	:VARCHAR2(6) 
		IxSTYLE_NAME =4,		// 오더 타입	:VARCHAR2(2) 
		IxOBS_NU =5,		// OBS 번호	:VARCHAR2(10) 
		IxOBS_SEQ_NU =6,	// OBS 순번	:VARCHAR2(10) 
		IxDEST =7,		// 변경순번	:VARCHAR2(5) 
		IxGENDER =8,		// GPO/DPO 구분	:VARCHAR2(1) 
		IxCS_SIZE =9,		// GPO/DPO 구분	:VARCHAR2(1) 
		IxSIZE_QTY =10,		// GPO/DPO 구분	:VARCHAR2(1) 

	

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
		IxMaxCt         =58, //arguemt 개수
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
	/// SEM_OBS_CS_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_OBS_REQ : int
	{
		IxMaxCt = 27,		// 인덱스 Count 
		IxFACTORY = 1,		// 공장구분           	:VARCHAR2(5) 
		IxSTYLE_CD = 2,		// 스타일코드         	:VARCHAR2(9) 
		IxSTYLE_NM = 3,		// 스타일코드         	:VARCHAR2(9) 
		lxFLAG = 4,
		lxREQ_NO = 5,
		lxREQ_SESQ_NU = 6,
		IxOBS_NU = 7,		// OBS 번호           	:VARCHAR2(10) 
		IxOBS_SEQ_NU = 8,	// OBS 순번           	:VARCHAR2(10) 
		IxCHG_NU = 9,		// 변경순번           	:VARCHAR2(5) 
		IxJOB_ID = 10,
		lxPLAN_DIV = 11,      //오더 계획 반영구분    :VARCHAR2(1) 
		IxOBS_DIV = 12,
		IxCS_REQ = 13,
		IxOBS_ID = 14,		// OBS ID             	:VARCHAR2(6) 
		IxOBS_TYPE = 15,		// OBS TYPE           	:VARCHAR2(2) 
		IxPST_YN = 16,		// 프레스토구분       	:VARCHAR2(1) 
		IxREQ_YN = 17,		// 요청구분        	    :VARCHAR2(1) 
		lxOA_NU_BEF = 18,
		lsOA_NU_AFT = 19,
		IxDEST = 20,			// 지역               	:VARCHAR2(7) 
		IxRTS_YMD = 21,		// RTS DATE/OGAC_DATE 	:VARCHAR2(8) 
		IxCSETS_YMD = 22,	// CSETS_DATE/GAC_DATE	:VARCHAR2(8) 
		IxCSETS_RSN = 23,	// GAC REASON         	:VARCHAR2(30) 
		lxREQ_YMD = 24,     // 요청 일자
		lxOLD_REQ_NO = 25,  // 구 요청번호
		IxTOT_QTY = 26,		// 총오더수량         	:NUMBER(22) 
		IxGEN = 27,			// GENDER
	} 

	/// <summary> 
	/// SEM_BP_OA 테이블 인덱스 Enum //Head용
	/// </summary> 
	public enum TBSEM_BP_OA_H : int 
	{ 
		IxMaxCt = 4,		// 인덱스 Count 
		IxFACTORY =1,		// 공장구분           	:VARCHAR2(5) 
		lxSTYLE_CD =2,      // 스타일코드         	:VARCHAR2(9) 
		lxBEF_QTY =3,      // 파일 수령일
		lxAFT_QTY =4,       // PRD_QTY
	}  

	/// <summary> 
	/// SEM_BP_OA 테이블 인덱스 Enum //Detail용
	/// </summary> 
	public enum TBSEM_BP_OA_D : int 
	{ 
		IxMaxCt = 7,		// 인덱스 Count 
		IxFACTORY =1,		// 공장구분           	:VARCHAR2(5) 
		lxFlag     =2, 
		IxOA_POSITON =3,	// Before/After 구분
		lxSTYLE_CD =4,      // 스타일코드       
		lxBP_NO = 5,
		lxPRD_QTY = 6,
		lxUPLOAD_YMD = 7,
	}  

	/// <summary> 
	/// SEM_BP_OA 테이블 인덱스 Enum  //Result용
	/// </summary> 
	public enum TBSEM_BP_OA : int 
	{ 
		IxMaxCt = 7,		// 인덱스 Count 
		IxOA_POSITION =1,	// 이전/이후 위치	:VARCHAR2(2) 
		IxFACTORY =2,		// 공장구분      	:VARCHAR2(5) 
		IxOA_SEQ_NU =3,		// HISTORY 순번  	:VARCHAR2(5) 
		IxSTYLE_CD =4,		// 스타일구분    	:VARCHAR2(9) 
		IxBP_NO =5,			// Lasting Week
		IxPRD_QTY =6,		// 수량    	:NUMBER(22) 
		IxUPLOAD_YMD =7,	// 생성일        	:VARCHAR2(8) 
	}  

	/// <summary> 
	/// TBSEM_BP_OA_AddFlow 테이블 인덱스 Enum  //Result용
	/// </summary> 
	public enum TBSEM_BP_OA_AddFlow : int 
	{ 
		IxMaxCt = 4,		// 인덱스 Count 
		IxOA_NU =0,			// 이전/이후 위치	:VARCHAR2(2) 
		IxSTYLE_CD =1,		// 스타일구분    	:VARCHAR2(9) 
		IxBP_NO =2,			// Lasting Week
		IxPRD_QTY =3,		// 수량    	:NUMBER(22) 

	}  
	
	/// <summary> 
	/// SEM_JOB_OPTION 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_JOB_OPTION : int 
	{ 
		IxMaxCt = 17,		// 인덱스 Count 
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
	/// SEM_BP 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_BP_HISTORY : int 
	{ 
		IxMaxCt = 18,		// 인덱스 Count 
		IxDEL_MONTH =1,		// 운송월      	:VARCHAR2(8) 
		IxOBS_ID =2,		// OBS_ID
		IxSTYLE_CD =3,		// 스타일 코드 	:VARCHAR2(9) 
		IxREGION =4,		// REGION      	:VARCHAR2(7) 
		IxBP_NO =5,			// 	:VARCHAR2(8) 
		IxSYMD =6,			// 시작일자    	:VARCHAR2(8) 
		IxEYMD =7,			// 끝일자      	:VARCHAR2(8) 
		IxPRD_QTY =8,		// 오더수량    	:NUMBER(22) 
		IxBTO_DT =9,		// 	:VARCHAR2(8) 
		IxBP_NU =10,		// BP번호      	:VARCHAR2(10) 
		IxBP_SEQ_NU =11,	// BP순번      	:VARCHAR2(10) 
		IxCHG_NU =12,		// 변경순번    	:VARCHAR2(5) 
		IxOA_NU_BEF =13,	// 이전 OA NO  	:VARCHAR2(10) 
		IxOA_NU_AFT =14,	// 이후 OA NO  	:VARCHAR2(10) 
		IxDOWN_YMD =15,		// 파일다운일자	:VARCHAR2(8) 
		IxREMARKS =16,		// 주   석     	:VARCHAR2(50) 
		IxUPD_USER =17,		// 작성자      	:VARCHAR2(10) 
		IxUPD_YMD =18,		// 작성일자    	:DATE(7) 
	}  

	/// <summary> 
	/// SEM_DEST 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_DEST : int 
	{ 
		IxMaxCt		 = 11,		// 인덱스 Count 
		IxFACTORY	 =  1,		// 공장구분      	:VARCHAR2(5) 
		IxDEST_CD    =  2,		// 행선지코드     	:VARCHAR2(7) 
		IxDEST		 =  3,		// 행선지        	:VARCHAR2(7) 
		IxDEST_NAME  =  4,		// NAME :CUSTOMER	:VARCHAR2(40) 
		IxDEST_PRITY =  5,		// 우선순위      	:NUMBER(22) 
		IxREGION	 =  6,		// 지역          	:VARCHAR2(5) 
		IxLOCATION	 =  7,		// 국가명        	:VARCHAR2(30) 
		IxAF_TERM	 =  8,		// 항송 운송 기간	:NUMBER(22) 
		IxVL_TERM	 =  9,		// 선박 운송기간 	:NUMBER(22) 
		IxREMARKS	 =  10,		// 주석          	:VARCHAR2(50) 
		IxUPD_USER	 = 11,		// 등록자        	:VARCHAR2(10) 
		IxUPD_YMD	 = 12,		// 등록일자      	:DATE(7) 
	}  





//	/// <summary> 
//	/// SEM_GSSC_TEMP[GRID SETTING]
//	/// </summary>
//	public enum TBSEM_GSSC_TEMP : int 
//	{
//		IxMaxCt = 13,		    // 인덱스 Count 
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
//		IxMaxCt = 23,		    // 인덱스 Count 
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
	//	/// SEM_GSSC_LOAD에서 SEM_GSSC추출값
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
	/// SEM_OBS 테이블 인덱스 Enum  -SEQ :2(OA CREATE에서 사용)
	/// </summary> 
	public enum TBSEM_OBS2 : int 
	{ 
		IxMaxCt      = 17,		// 인덱스 Count 
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
	//	/// SEM_GSSC_LOAD에서 SEM_GSSC_SIZE추출값
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
	//	/// SEM_GSSC_LOAD에서 SEM_USER_ERROR추출값
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
	/// SEM_GSSC 테이블 인덱스 Enum 
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
	/// SEM_GSSC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_GSSC : int 
	{ 
		IxMaxCt = 13,		   // 인덱스 Count 
		IxFACTORY =1,		   // 공장구분      	:VARCHAR2(5) 
		IxSTYLE_CD =2,		   // 스타일구분    	:VARCHAR2(9) 
		IxGEN =3,			   // 젠더         	    :VARCHAR2(2) 
		IxPST_YN =4,		   // 프레스토구분	    :VARCHAR2(1) 
		IxSTYLE_NAME =5,	   // 스타일구분    	:VARCHAR2(9) 
		IxDEV_CD =6,		   // 개발 CODE     	:VARCHAR2(6) 
		IxOUT_SOLE_01 =7,	   // 개발 CODE     	:VARCHAR2(10) 
		IxDIM =8,			   // 치수          	:VARCHAR2(2) 
		IxCATEGORY_CD =9,	   // 카테고리 코드 	:VARCHAR2(5) 
		IxLOGIC =10,		   // 로직          	:VARCHAR2(5) 
		IxREMARKS =11,		   // 주석          	:VARCHAR2(50) 
		IxUPD_USER =12,		   // 등록일        	:VARCHAR2(10) 
		IxUPD_YMD =13,		   // 등록일자      	:DATE(7) 
	}  


	/// <summary> 
	/// SEM_GSSC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_GSSC02 : int 
	{ 
		IxMaxCt = 15,		   // 인덱스 Count 
		IxFACTORY =1,		   // 공장구분      	:VARCHAR2(5) 
		IxSTYLE_CD =2,		   // 스타일구분    	:VARCHAR2(9) 
		IxGEN =3,			   // 젠더         	    :VARCHAR2(2) 
		IxPST_YN =4,		   // 프레스토구분	    :VARCHAR2(1) 
		IxSTYLE_NAME =5,	   // 스타일구분    	:VARCHAR2(9) 
		IxDEV_CD =6,		   // 개발 CODE     	:VARCHAR2(6) 
		IxOUT_SOLE_01 =7,	   // 개발 CODE     	:VARCHAR2(10) 
		IxDIM =8,			   // 치수          	:VARCHAR2(2) 
		IxCATEGORY_CD =9,	   // 카테고리 코드 	:VARCHAR2(5) 
		IxLOGIC =10,		   // 로직          	:VARCHAR2(5) 
		IxREMARKS =11,		   // 주석          	:VARCHAR2(50) 
		IxCS_SIZE =12,		   // 주석          	:VARCHAR2(50) 
		IxSIZE_RATE =13,		// 주석          	:VARCHAR2(50) 
		IxUPD_USER =14,		   // 등록일        	:VARCHAR2(10) 
		IxUPD_YMD =15,		   // 등록일자      	:DATE(7) 
	}  


	

	/// <summary> 
	/// SEM_OBSVSBP1
	/// </summary> 
	public enum TBSEM_OBSVSBP : int 
	{ 
		IxMaxCt			=   33,		    // 인덱스 Count 
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
	/// SEM_OA 테이블 인덱스 Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_OA01 : int 
	{ 
		IxMaxCt = 7,		// 인덱스 Count 
		IxFACTORY =1,
		IxSTATUS  =2,
		IxOBS_NU =3,
		IxOBS_SEQ_NU =4,
		IxCHG_NU=5,
		IxCS_SIZE =6,
		IxQTY =7,
	}  


	/// <summary> 
	/// SEM_OA 테이블 인덱스 Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_OA02 : int 
	{ 
		IxMaxCt = 8,		// 인덱스 Count 
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
	/// SEM_OA 테이블 인덱스 Enum  --SEQ:04
	/// </summary> 
	public enum TBSEM_OA04 : int 
	{ 
		IxMaxCt        =8,		// 인덱스 Count 
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
	/// SEM_OA 테이블 인덱스 Enum  --SEQ:05
	/// </summary> 
	public enum TBSEM_OA05 : int 
	{ 
		IxMaxCt          = 18,		// 인덱스 Count 
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
	/// SEM_OA 테이블 인덱스 Enum  --SEQ:06
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
	/// SEM_OA 테이블 인덱스 Enum  --SEQ:07
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
	/// SEM_OA 테이블 인덱스 Enum  --SEQ:08
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
	/// SEM_OA_REQ 테이블 인덱스 Enum  --SEQ:1
	/// </summary> 
	public enum TBSEM_OA_REQ01 : int 
	{ 
		IxMaxCt = 10,		// 인덱스 Count 
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
	///  SEM_OA_REQ 테이블 인덱스 Enum  --SEQ:2
	/// </summary> 
	public enum TBSEM_OA_REQ02 : int 
	{ 
		IxMaxCt =11,		// 인덱스 Count 
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
	///  SEM_OA_REQ 테이블 인덱스 Enum  --SEQ:3
	/// </summary> 
	public enum TBSEM_OA_REQ03 : int 
	{ 
		IxMaxCt =9,		// 인덱스 Count 
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
	/// SEM_OBS_OA 테이블 인덱스 Enum  --SEQ:03
	/// </summary> 
	public enum TBSEM_OBS_OA : int 
	{ 
		IxMaxCt = 22,		// 인덱스 Count 
		IxFACTORY =1,			// 공장구분     	:VARCHAR2(2) 
		IxOA_NU =2,			// HISTORY 번호 	:VARCHAR2(10) 
		IxOBS_DIV =3,			// GPO/DPO 구분 	:VARCHAR2(1) 
		IxOA_OBS_DIV =4,			// 실->실,가->가, 가->실 구분	:VARCHAR2(2) 
		IxOBS_ID =5,			// OBS ID       	:VARCHAR2(6) 
		IxOBS_TYPE =6,			// 오더 타입    	:VARCHAR2(2) 
		IxSTYLE_CD =7,			// 스타일구분   	:VARCHAR2(9) 
		IxOA_DIV =8,			//  OA종류      	:VARCHAR2(1) 
		IxOA_YMD =9,			// 생성일       	:VARCHAR2(8) 
		IxOA_CFM =10,			// OA_CONFIRM구분	:VARCHAR2(1) 
		IxCHG_YMD =11,			// 변경일       	:VARCHAR2(8) 
		IxPUR_NO =12,			// 구매 번호    	:VARCHAR2(10) 
		IxOUR_REF_NO =13,			// 참조 번호    	:VARCHAR2(10) 
		IxPUR_GRP =14,			// 구매 GROUP   	:VARCHAR2(3) 
		IxYOUR_REF =15,			// 참조자료     	:VARCHAR2(10) 
		IxORDER_RSN =16,			// ORDER변경 사유	:VARCHAR2(20) 
		IxQUAL_ISEQ =17,			// QUAL_ISEG    	:VARCHAR2(8) 
		IxSEASON_CD =18,			// 시젼코드     	:VARCHAR2(2) 
		IxSEASON_YEAR =19,			// 시젼년도     	:VARCHAR2(4) 
		IxREMARKS =20,			// 주   석      	:VARCHAR2(50) 
		IxUPD_USER =21,			// 등록자       	:VARCHAR2(10) 
		IxUPD_YMD =22,			// 등록일자     	:DATE(7) 
	}  



	/// <summary> 
	/// SEM_OBS_OA 테이블 인덱스 Enum  --SEQ:04
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
	/// SEM_OBS_OA 테이블 인덱스 Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_OBS_OA01 : int 
	{ 
		IxMaxCt = 7,		// 인덱스 Count 
		IxFACTORY =1,			// 공장구분     	:VARCHAR2(2) 
		IxOBS_NU =2,			
		IxOBS_SEQ_NU =3,		
		IxCS_SIZE =4,			
		IxBEF_QTY=5,			
		IxADJ_QTY =6,			
		IxAFT_QTY =7,			
	}  

	/// <summary> 
	/// SEM_OBS_OA 테이블 인덱스 Enum  --SEQ:02
	/// </summary> 
	public enum TBSEM_OBS_OA02 : int 
	{ 
		IxMaxCt = 4,		    // 인덱스 Count 
		IxOBS_NU =1,	
		IxOBS_SEQ_NU =2,
		IxCHG_NU =3,	
		IxTOT_QTY =4,	
	}



	/// <summary> 
	/// SEM_BALANCE 테이블 인덱스 Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_BP_BAL  : int 
	{ 
		IxMaxCt = 5,		    // 인덱스 Count 
		IxFACTORY =1,	
		IxOUT_SOLE_01 =2,
		IxDEV_CD =3,	
		IxSTYLE_CD =4,	
		IxSTYLE_NAME =5,	
		
	}





	
	/// <summary> 
	/// SEM_OBS_HIST 테이블 인덱스 Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_OBS_HIST : int 
	{ 
		IxMaxCt      = 15,		    // 인덱스 Count 
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
	/// SEM_OBS_BAL 테이블 인덱스 Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_OBS_BAL01 : int 
	{ 
		IxMaxCt      = 8,		    // 인덱스 Count 
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
	/// SEM_OBS_BAL 테이블 인덱스 Enum  --SEQ:01
	/// </summary> 
	public enum TBSEM_OBS_BAL02 : int 
	{ 
		IxMaxCt      = 11,		    // 인덱스 Count 		
		IxFACTORY    = 1,
		IxJOB_DIV    = 2,
		IxJOB_NAME   = 3,
		IxSTYLE_CD   = 4,  
		IxOBS_NU     = 5, 
		IxOBS_SEQ_NU = 6, 
		IxBP_NO      = 7, 
		IxTOT_QTY    = 8, 
		IxGEN        = 9,        // BP_NO는 OBS_NU+ OBS_SEQ_NU에 같이 Display
		IxCS_SIZE    = 10, 
		IxQTY        = 11,
		
	}





	
	/// <summary> 
	/// SEM_PA 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_PA : int 
	{ 
		IxMaxCt = 21,		// 인덱스 Count 
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
	/// SEM_PA_UPLOAD 테이블 인덱스 Class 
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
	/// SEM_PA 테이블 인덱스 Enum 
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
