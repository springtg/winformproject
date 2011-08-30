using System;

namespace FlexMold.ClassLib
{
	/// <summary>
	/// IXTable에 대한 요약 설명입니다.
	/// </summary>
	/// <summary> 
	/// SPS_TABLE 테이블 인덱스 Class 
	/// </summary> 
	public class TBSPS_TABLE
	{ 
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
	/// SPB_CAL_TYPE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_CAL_TYPE : int 
	{ 
		IxMaxCt = 7,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxCAL_TYPE =2,			// 카렌더 타입	:VARCHAR2(10) 
		IxCAL_NAME =3,			// 카렌더 타입 설명	:VARCHAR2(20) 
		IxAREA_CD =4,			// 대표 작업장 코드	:VARCHAR2(10) 
		IxREMARKS =5,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =6,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =7,			// 작성일자	:DATE(7) 
	}  


	/// <summary> 
	/// SPB_SHIFT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_SHIFT : int 
	{ 
		IxMaxCt = 16,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxSHIFT_TYPE =2,			// 교대타입 OR 단위작업시간	:VARCHAR2(20) 
		IxWEEKDAY =3,			// 요일코드	:VARCHAR2(10) 
		IxSHIFT_NO =4,			// 작업순번	:NUMBER(22) 
		IxSHIFT_DESC =5,			// 교대타입 OR 단위작업시간 설명	:VARCHAR2(100) 
		IxST_WEEKDAY =6,			// 작업 시작 요일코드	:VARCHAR2(10) 
		IxTM_START_WK =7,			// 작업 시작 시각	:VARCHAR2(5) 
		IxEND_WEEKDAY =8,			// 작업 종료 요일코드	:VARCHAR2(10) 
		IxTM_END_WK =9,			// 작업 종료 시각	:VARCHAR2(5) 
		IxUSE_YN =10,			// 사용여부	:VARCHAR2(1) 
		IxSHIFT_YN =11,			// 작업자 교대 여부	:VARCHAR2(1) 
		IxOVERTIME_YN =12,			// 잔업 가능 여부	:VARCHAR2(1) 
		IxOVERTIME =13,			// 잔업 가용 시간 (00D00H00M)	:VARCHAR2(10) 
		IxREMARKS =14,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =15,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =16,			// 작성일자	:DATE(7) 
	}  



	/// <summary> 
	/// SPB_HOLIDAY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_HOLIDAY : int 
	{ 
		IxMaxCt = 13,		// 인덱스 Count 
	    IxH_HOLI_CD =1,   
		IxFACTORY =2,			// 공장	:VARCHAR2(5) 
		IxCAL_TYPE =3,			// 카렌더 타입	:VARCHAR2(10) 
		IxHOLI_CD =4,			// 휴일 코드	:VARCHAR2(10) 
		IxCAL_NAME =5,			// 카렌더 타입 설명	:VARCHAR2(20) 
		IxAREA_CD =6,			// 작업장 코드	:VARCHAR2(10) 
		IxHOLI_YN =7,			// 휴일 여부	:VARCHAR2(1) 
		IxHOLI_DESC =8,			// 휴일 설명	:VARCHAR2(10) 
		IxTM_START_HOLI =9,			// 휴일 근무 시작 시간	:VARCHAR2(10) 
		IxTM_END_HOLI =10,			// 휴일 근무 종료 시간	:VARCHAR2(10) 
		IxREMARKS =11,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =12,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =13,			// 작성일자	:DATE(7) 
	}  




	/// <summary> 
	/// SPB_WORK_CAL 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_WORK_CAL : int 
	{ 
//		IxMaxCt = 18,		// 인덱스 Count 
//		IxH_SHIFT_NO =1,
//		IxFACTORY =2,			// 공장	:VARCHAR2(5) 
//		IxCAL_TYPE =3,			// 카렌더 타입	:VARCHAR2(10) 
//		IxSHIFT_TYPE =4,			// 교대타입 (OR 작업시간단위)	:VARCHAR2(20) 
//		IxTHEDATE =5,			// 일자	:VARCHAR2(10) 
//		IxSHIFT_NO =6,			// 작업순번	:NUMBER(22) 
//		IxWEEK_IX =7,			// 요일코드	:NUMBER(22) 
//		IxWEEKDAY =8,			// 요일명(영문)	:VARCHAR2(10) 
//		IxHOLI_YN =9,			// 휴일여부	:VARCHAR2(1) 
//		IxHOLI_DESC =10,			// 휴일설명	:VARCHAR2(10) 
//		IxSHIFT_YN =11,			// 작업자 교대 여부	:VARCHAR2(1) 
//		IxTM_START_WK =12,			// 작업 시작 시각	:VARCHAR2(5) 
//		IxTM_END_WK =13,			// 작업 종료 시각	:VARCHAR2(5) 
//		IxOVERTIME_YN =14,			// 잔업 가능 여부	:VARCHAR2(1) 
//		IxOVERTIME =15,			// 잔업 가용 시간 (00D00H00M)	:VARCHAR2(10) 
//		IxREMARKS =16,			// 비고	:VARCHAR2(100) 
//		IxUPD_USER =17,			// 작성자	:VARCHAR2(10) 
//		IxUPD_YMD =18,			// 작성일자	:DATE(7) 

		IxMaxCt = 17,		// 인덱스 Count  
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxCAL_TYPE =2,			// 카렌더 타입	:VARCHAR2(10) 
		IxSHIFT_TYPE =3,			// 교대타입 (OR 작업시간단위)	:VARCHAR2(20) 
		IxTHEDATE =4,			// 일자	:VARCHAR2(10) 
		IxSHIFT_NO =5,			// 작업순번	:NUMBER(22) 
		IxWEEK_IX =6,			// 요일코드	:NUMBER(22) 
		IxWEEKDAY =7,			// 요일명(영문)	:VARCHAR2(10) 
		IxHOLI_YN =8,			// 휴일여부	:VARCHAR2(1) 
		IxHOLI_DESC =9,			// 휴일설명	:VARCHAR2(10) 
		IxSHIFT_YN =10,			// 작업자 교대 여부	:VARCHAR2(1) 
		IxTM_START_WK =11,			// 작업 시작 시각	:VARCHAR2(5) 
		IxTM_END_WK =12,			// 작업 종료 시각	:VARCHAR2(5) 
		IxOVERTIME_YN =13,			// 잔업 가능 여부	:VARCHAR2(1) 
		IxOVERTIME =14,			// 잔업 가용 시간 (00D00H00M)	:VARCHAR2(10) 
		IxREMARKS =15,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =16,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =17,			// 작성일자	:DATE(7) 


	}  





	/// <summary> 
	/// SPB_CMP 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_CMP : int 
	{ 
		IxMaxCt = 9,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxCMP_CD =2,			// 품목 코드	:VARCHAR2(10) 
		IxCMP_NAME =3,			// 품목명	:VARCHAR2(60) 
		IxCMP_UNIT =4,			// 품목 단위	:VARCHAR2(5) 
		IxCMP_DIV =5,			// 품목 계정 (예 : 완제, 반제, COMPONENT 등)	:VARCHAR2(20) 
		IxAVAIL_YMD =6,			// 유효기간	:VARCHAR2(8) 
		IxREMARKS =7,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =8,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =9,			// 작성일자	:DATE(7) 
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
	/// SPB_NODE_OPDEF 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_NODE_OPDEF : int 
	{ 
		IxMaxCt = 24,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxOP_TYPE =2,			// 공정 분류 (예 : 가상공정, 조립공정, 외주공정, COMPONENT 공정 등)	:VARCHAR2(10) 
		IxOP_TYPE_NAME =3,			// 공정 분류명	:VARCHAR2(50) 
		IxPHANTOM_YN =4,			// 가상타입 여부	:VARCHAR2(1) 
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
		IxREMARKS =22,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =23,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =24,			// 작성일자	:DATE(7) 
	}  


	/// <summary> 
	/// SPB_OPCD 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_OPCD : int 
	{ 
		IxFACTORY =0,			// 공장	:VARCHAR2(5) 
		IxSG_CMP_CD =1,			// 공정의 상위 그룹 품목 코드	:VARCHAR2(10) 
		IxOP_CD =2,			// 공정 코드	:VARCHAR2(10) 
		IxAREA_CD =3,			// 표준 작업장 코드	:VARCHAR2(10) 
		IxOP_NAME =4,			// 공정명	:VARCHAR2(50) 
		IxOP_TYPE =5,			// 공정 분류 코드	:VARCHAR2(10) 
		IxDEPT_CD =6,			// 공정 부서 코드	:VARCHAR2(6) 
		IxOP_COLOR =7,			// 공정 색깔	:VARCHAR2(10) 
		IxREAL_YN =8,			// 실공정 여부	:VARCHAR2(1) 
		IxCAPA_YN =9,			// CAPACITY 분석 공정 여부	:VARCHAR2(1) 
		IxMOLD_YN =10,			// 몰드 공정 여부	:VARCHAR2(1) 
		IxOUT_YN =11,			// 외주 여부	:VARCHAR2(1) 
		IxJOB_YN =12,			// 작업지시 여부	:VARCHAR2(1) 
		IxPCARD_YN =13,			// 패스카드 여부	:VARCHAR2(1) 
		IxRST_YN =14,			// 실적 여부	:VARCHAR2(1) 
		IxMAT_AREA_YN =15,			// JIT 여부	:VARCHAR2(1) 
		IxIN_DETAIL_YN =16,
		IxMOLD_TYPE =17,			// 몰드 타입 : MOLE_YN = Y 인 경우에 선택	:VARCHAR2(2)
		IxDIR_MARGIN =18,
		IxREMARKS =19,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =20,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =21,			// 작성일자	:DATE(7) 
		IxOP_LEVEL =22,
		IxDETAIL_OPCD =23,
		IxH_OP_CD =24,
	}  



	/// <summary> 
	/// SPB_OPCD 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_OPCD_INDETAIL : int 
	{ 
		IxFACTORY =0,	
		IxPARENT_CMP =1,	
		IxPARENT_OPCD =2,		
		IxOP_CD =3,		
		IxAREA_CD =4,		
		IxOP_NAME =5,		
		IxOP_TYPE =6,		
		IxDEPT_CD =7,		
		IxOP_COLOR =8,		
		IxREAL_YN =9,		
		IxCAPA_YN =10,		
		IxMOLD_YN =11,		
		IxOUT_YN =12,		
		IxJOB_YN =13,		
		IxPCARD_YN =14,		
		IxRST_YN =15,		
		IxJIT_YN =16,		
		IxIN_DETAIL_YN =17,
		IxMOLD_TYPE =18,	
		IxDIR_MARGIN =19,
		IxREMARKS =20,		
		IxUPD_USER =21,		
		IxUPD_YMD =22,		
		IxOP_LEVEL =23,
		IxDETAIL_OPCD =24,
		IxH_OP_CD =25,
	}  


	/// <summary> 
	/// SPB_OPCD 그리드 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_OPCD_GRID : int 
	{ 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxSG_CMP_CD =2,			// 공정의 상위 그룹 품목 코드	:VARCHAR2(10) 
		IxOP_CD =3,			// 공정 코드	:VARCHAR2(10)  
		IxAREA_CD =4,			// 표준 작업장 코드	:VARCHAR2(10) 
		IxOP_NAME =5,			// 공정명	:VARCHAR2(50) 
		IxOP_TYPE =6,			// 공정 분류 코드	:VARCHAR2(10) 
		IxDEPT_CD =7,			// 공정 부서 코드	:VARCHAR2(6) 
		IxOP_COLOR =8,			// 공정 색깔	:VARCHAR2(10) 
		IxREAL_YN =9,			// 실공정 여부	:VARCHAR2(1) 
		IxCAPA_YN =10,			// CAPACITY 분석 공정 여부	:VARCHAR2(1) 
		IxMOLD_YN =11,			// 몰드 공정 여부	:VARCHAR2(1) 
		IxOUT_YN =12,			// 외주 여부	:VARCHAR2(1) 
		IxJOB_YN =13,			// 작업지시 여부	:VARCHAR2(1) 
		IxPCARD_YN =14,			// 패스카드 여부	:VARCHAR2(1) 
		IxRST_YN =15,			// 실적 여부	:VARCHAR2(1) 
		IxMAT_AREA_YN =16,			// JIT 여부	:VARCHAR2(1) 
		IxIN_DETAIL_YN =17,
		IxMOLD_TYPE =18,			// 몰드 타입 : MOLE_YN = Y 인 경우에 선택	:VARCHAR2(2)
		IxDIR_MARGIN =19,
		IxREMARKS =20,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =21,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =22,			// 작성일자	:DATE(7)  
		IxOP_LEVEL =23,
		IxDETAIL_OPCD =24,
		IxH_OP_CD =25,
	}  
	
	
	

	/// <summary> 
	///   
	/// </summary> 
	public enum TBSPB_OPCD_MOLDTYPES : int 
	{ 	
		IxCMP_CD =1,
		IxCHECK_FLAG =2,
		IxMOLD_PART_CD =3,
		IxMOLD_PART_NAME =4,
		IxDIVISION =5, 
	}  
	
	/// <summary> 
	/// SPB_OP_CAL 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_OP_CAL : int 
	{ 
		IxMaxCt = 7,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxOP_CD =2,			// 공정코드	:VARCHAR2(10) 
		IxCAL_TYPE =3,			// 카렌더타입	:VARCHAR2(10) 
		IxSHIFT_TYPE =4,			// 교대타입	:VARCHAR2(10) 
		IxREMARKS =5,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =6,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =7,			// 작성일자	:DATE(7) 
	}  



	/// <summary> 
	/// SPB_LINE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_LINE : int 
	{ 
		IxMaxCt = 14,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxLINE_CD =2,			// 라인 코드	:VARCHAR2(3) 
		IxLINE_NAME =3,			// 라인명	:VARCHAR2(60) 
		IxLINE_MANAGER =4,			// 라인 담당자	:VARCHAR2(12) 
		IxMAX_CAPA =5,			// 최대 생산 능력 (수량)	:NUMBER(22) 
		IxSTD_CAPA =6,			// 평균 생산 능력 (수량)	:NUMBER(22) 
		IxMIN_CAPA =7,			// 최소 생산 능력 (수량)	:NUMBER(22) 
		IxPROD_UNIT =8,			// 생산단위	:VARCHAR2(5) 
		IxLINE_GROUP =9,			// 라인타입	:VARCHAR2(5) 
		IxROUT_TYPE =10,
		IxMLINE_YN =11,			// 세부라인 표시 여부	:VARCHAR2(1) 
		IxLINE_COLOR =12,
		IxREMARKS =13,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =14,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =15,			// 작성일자	:DATE(7) 
	}  



	/// <summary> 
	/// SPB_LINEOP 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_LINEOP : int 
	{ 
		IxMaxCt = 13,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxLINE_CD =2,			// 라인 코드	:VARCHAR2(3) 
		IxOP_CD =3,			// 공정 코드	:VARCHAR2(10) 
		IxCAL_TYPE =4,			// 카렌더타입	:VARCHAR2(10) 
		IxSHIFT_TYPE =5,			// 교대타입	:VARCHAR2(10) 
		IxMLINE_QTY =6,			// 세부 라인 수	:NUMBER(22) 
		IxMAX_CAPA =7,			// 최대 생산 능력 (수량)	:NUMBER(22) 
		IxSTD_CAPA =8,			// 평균 생산 능력 (수량)	:NUMBER(22) 
		IxMIN_CAPA =9,			// 최소 생산 능력 (수량)	:NUMBER(22) 
		IxPROC_UNIT =10,			// 생산단위	:VARCHAR2(5) 
		IxREMARKS =11,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =12,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =13,			// 작성일자	:DATE(7) 
	}  



	/// <summary> 
	/// SPB_LINEOP_MINI_RSC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_LINEOP_MINI : int 
	{ 
		IxMaxCt =19, 	 
		IxLINE_CD =0,			 
		IxLINE_NAME =1, 	
		IxOP_CD =2,	
		IxOP_NAME =3,
		IxOP_LINE =4,	
		IxOP_LINE_NAME =5, 
		IxLEVEL =6,
		IxFACTORY =7,
		IxGROUP_ID =8,
		IxREAL_LINE_CD =9,
		IxAREA_CD =10,
		IxOUT_YN =11,
		IxMAX_CAPA =12,
		IxSTD_CAPA =13,
		IxMIN_CAPA =14,
		IxPROC_UNIT =15,
		IxWORK_TIME =16, 
		IxREMARKS =17,
		IxEXIST_YN =18,
		IxMLINE_QTY =19,
 
		 
	}  

 
	/// <summary> 
	/// SPO_LOT_DAILY_MINI 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_MINI_HEAD : int 
	{   
		IxLINE_CD =1,		 
		IxLOT =2, 
		IxREQ_NO =3,	
		IxMODEL_NAME =4,
		IxSTYLE_CD =5,			
		IxGEN =6,		 		
		IxOBS_ID =7,
		IxOBS_TYPE =8,
		IxDAY_SEQ =9,		
		IxLOT_QTY =10,	
		IxTOT_DAY_SEQ =11,
	}  

 
	/// <summary> 
	/// SPO_LOT_DAILY_MINI 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_MINI_STEP1 : int 
	{  
		IxLOT =1,
		IxREQ_NO =2,
		IxMODEL_NAME =3,
		IxSTYLE_CD =4,
		IxGEN =5,
		IxMLINE_START =6,

	}  

	/// <summary> 
	/// SPO_LOT_DAILY_MINI 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_MINI_STEP2 : int 
	{  
		IxLOT =0,
		IxREQ_NO =1,
		IxMODEL_NAME =2,
		IxSTYLE_CD =3,
		IxGEN =4,
		IxDAY_SEQ =5,
		IxMLINE_CD =6,
		IxSIZE_QTY =7, 
	}  


	/// <summary> 
	/// SPO_LOT_DAILY_MINI 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_MINI_STEP3 : int 
	{  
		IxLOT =0,
		IxREQ_NO =1,
		IxMODEL_NAME =2,
		IxSTYLE_CD =3,
		IxGEN =4,
		IxDAY_SEQ =5,
		IxMLINE_CD =6,
		IxSIZE_QTY =7,

	}  


	 
	/// <summary> 
	/// SPB_LINEOP_MINI 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_MINI_SIZE_H : int 
	{ 
		IxLEVEL =0, 
		IxSAVE_FLAG = 1,
		IxPLAN_STATUS =2,
		IxTS_FINISH_YN = 3, 	 
		IxDAY_SEQ =4, 
		IxPLAN_YMD =5,
		IxMLINE_CD =6,
		IxMLINE_NAME =7,
		IxSIZE_QTY =8,   
	}  


	/// <summary> 
	/// SPB_LINEOP_MINI 사이즈 추출 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_MINI_SIZE_D : int 
	{  			 
		IxDIVISION =0,
		IxDAY_SEQ =1, 
		IxMLINE_CD =2, 
		IxCS_SIZE =3, 
		IxSIZE_QTY =4,
	}  
  
	/// <summary> 
	/// SPB_LINEOP_MINI 그리드 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_MINI_SIZE_GRID: int 
	{  
		IxMaxCt = 11, 
		IxLEVEL =1, 
		IxSAVE_FLAG = 2,
		IxPLAN_STATUS =3,
		IxTS_FINISH_YN = 4,
		IxCODE =5,			 
		IxNAME =6, 			 
		IxDAY_SEQ =7,  
		IxMLINE_CD =8,  
		IxTOT_QTY =9,
		IxSUM_QTY =10, 
 
		IxGEN =11,
		IxCS_SIZE_START =12, 
  
	}  

	/// <summary> 
	/// SPB_LINEOP_MINI 사이즈 추출 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_OPCD_LINE_MLINE : int 
	{    
		IxTBMLINE_CD =0, 
		IxTBMLINE_NAME =1, 
		IxTBSEL_YN =2,
		IxTBLINE_COLOR =3,
	}  
 




	/// <summary> 
	/// SPO_LOT_LAST_INVENTORY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_LAST_INVENTORY : int 
	{  
		
		IxDESC_LEVEL	=1,	
		IxDESC1			=2, 
		IxFACTORY		=3,
		IxLOT_NO		=4,
		IxLOT_SEQ		=5,
		IxDAY_SEQ		=6,
		IxTOT_QTY		=7,	 
		IxGEN			=8,
		IxCS_SIZE		=9,
		IxSIZE_QTY		=10,
		IxDAY_SEQ_SORT  =11,
		IxCS_SIZE_SORT  =12,

		IxCS_SIZE_START =9, 
  
 
	}



	/// <summary> 
	/// SPO_RECV_LOT_PRIORITY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_RECV_LOT_PRIORITY : int 
	{  
		
		IxREQ_NO_PRIORITY	=1,	
		IxFACTORY			=2, 
		IxMODEL_NAME		=3,
		IxSTYLE				=4,
		IxGEN				=5,
		IxOBS_ID			=6,
		IxOBS_TYPE			=7,	 
		IxREQ_NO			=8,
		IxOBS_NU			=9,
		IxOBS_SEQ_NU		=10,
		IxDEST				=11,
		IxRGAC				=12, 
		IxOGAC				=13,
		IxMSR_DIV			=14,
		IxORDER_QTY			=15,
  
 
	}
 
	

	/// <summary> 
	/// SPO_LOT_DAYILY_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_SIZE_HEAD : int 
	{  
		
		IxLINE_CD		=1,	
		IxLINE_NAME		=2, 
		IxMODEL_NAME	=3,
		IxSTYLE_CD		=4,
		IxOBS_ID		=5,
		IxOBS_TYPE		=6,
		IxLOT			=7,	 
		IxTOT_DAY_SEQ	=8,		
		IxPLN_STRYMD    =9,		 
		IxTOT_LOT_QTY   =10,			
		IxTOT_LOSS_QTY  =11,		 
		IxTOT_QTY		=12, 	
		IxGEN			=13,
		IxCS_SIZE		=14,
		IxSIZE_QTY		=15,
		IxLOSS_QTY		=16,
		IxSUM_QTY		=17,  
 
		IxCS_SIZE_START =14, 




		IxTBLINE_CD =0,	
		IxTBLINE_NAME =1, 
		IxTBLOT =2,	
		IxTBREQ_NO =3,
		IxTBMODEL_NAME =4, 	
		IxTBSTYLE_CD =5,
		IxTBOBS_ID =6,
		IxTBOBS_TYPE =7,
		IxTBTOT_DAY_SEQ =8,		
		IxTBPLN_STRYMD =9,		 
		IxTBTOT_LOT_QTY =10,			
		IxTBTOT_LOSS_QTY =11,		 
		IxTBTOT_QTY =12, 	
		IxTBGEN =13,
		IxTBCS_SIZE =14,
		IxTBSIZE_QTY =15,
		IxTBLOSS_QTY =16,
		IxTBSUM_QTY =17, 



	}

	/// <summary> 
	/// SPO_LOT_DAYILY_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_SIZE : int 
	{  
		IxTBPLAN_STATUS =0,
		IxTBTS_FINISH_YN =1,
		IxTBDAY_SEQ =2, 
		IxTBPLAN_YMD =3,
		IxTBTOT_ALO_QTY =4,
		IxTBTOT_LOSS_QTY =5,
		IxTBCS_SIZE =6,			
		IxTBSIZE_QTY =7,			
		IxTBLOSS_QTY =8, 
		IxTBNECK_QTY =9,
		IxTBSHORT_YN =10,
		IxTBSHORT_QTY =11,
  
		IxFLAG =1,
		IxPLAN_STATUS =2,
		IxTS_FINISH_YN =3,
		IxDAY_SEQ =4,  
		IxTOTAL =5,
		IxSUM =6,
		IxDESC_COL =7, 
		IxGEN =8, 
		IxCS_SIZE_START =9, 
 
	} 



	/// <summary> 
	/// SPO_LOT_DAYILY_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_SIZE_BSC : int 
	{  
		
		IxPLAN_STATUS   = 0,
		IxTS_FINISH_YN  = 1,
		IxTREE_LEVEL	= 2,
		IxTREE_DESC1	= 3,
		IxOBS_NU        = 4,
		IxOBS_SEQ_NU    = 5,
		IxTREE_DESC2	= 6, 
		IxTREE_DESC3	= 7,  
		IxTREE_DESC4	= 8,
		IxFINISH_DATE	= 9,
		IxLOT_NO		=10,
		IxLOT_SEQ		=11,
		IxREQ_NO		=12,
		IxDAY_SEQ		=13,
		IxTOT_QTY		=14,
		IxSUM_QTY		=15,
		IxCS_SIZE		=16,
		IxSIZE_QTY		=17,
		IxCS_SIZE_SORT	=18,
		IxREQ_NO_SORT	=19,

		IxGEN			=17, 
		IxCS_SIZE_START =18, 
		

		  

	} 




	/// <summary> 
	/// SPO_LOT_DAYILY_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_SIZE_DAILY_BSC : int 
	{  
		
		IxPLAN_STATUS   = 0,
		IxTS_FINISH_YN  = 1, 
		IxDESC1		=2,
		IxLOT_NO		=3,
		IxLOT_SEQ		=4,
		IxDAY_SEQ		=5,
		IxPLAN_YMD		=6,
		IxTOT_QTY		=7, 
		IxCS_SIZE		=8,
		IxSIZE_QTY		=9,
		IxCS_SIZE_SORT	=10, 
		IxTREE_LEVEL = 11,

		IxGEN			=9, 
		IxCS_SIZE_START =10,   
		  

	} 






	/// <summary> 
	/// SPO_LOT_DAYILY_MINI_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_MINI_HEAD_BSC : int 
	{  

 

		IxPLAN_YMD      =1,	
		IxLINE_CD		=2, 
		IxLINE_NAME		=3,
		IxMODEL_NAME	=4,
		IxSTYLE_CD		=5,
		IxOBS_ID		=6,
		IxOBS_TYPE		=7,	
		IxLOT			=8,	 
		IxDAY_SEQ		=9,
		IxOBS_NU		=10,
		IxOBS_SEQ_NU    =11,
		IxREQ_NO        =12,  	 
		IxTOT_QTY		=13, 	
		IxGEN			=14,
		IxCS_SIZE		=15,
		IxSIZE_QTY		=16,
 
		IxCS_SIZE_START =15, 
		  

	} 


	/// <summary> 
	/// SPO_LOT_DAYILY_MINI_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_MINI_SIZE_BSC : int 
	{  
 
		IxPLAN_STATUS		= 0,
		IxTS_FINISH_YN		= 1,
		IxTREE_LEVEL		= 2,
		IxTREE_DESC1		= 3,
		IxOBS_NU			= 4,
		IxOBS_SEQ_NU		= 5,
		IxTREE_DESC2		= 6, 
		IxTREE_DESC3		= 7,  
		IxTREE_DESC4		= 8,
		IxFINISH_DATE		= 9,
		IxLOT_NO			=10,
		IxLOT_SEQ			=11,
		IxREQ_NO			=12,
		IxDAY_SEQ			=13,
		IxMLINE_CD			=14,
		IxMLINE_STD_CAPA	=15, 
		IxTOT_QTY			=16,
		IxSUM_QTY			=17,
		IxCS_SIZE			=18,
		IxSIZE_QTY			=19,
		IxCS_SIZE_SORT		=20,
		IxREQ_NO_SORT		=21,

		IxGEN				=19, 
		IxCS_SIZE_START		=20, 
		  

	} 





	/// <summary> 
	/// SPO_LOT_DAYILY_MINI_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_LOT_DAILY_MINI_TS_HEAD_BSC : int 
	{  

 

		IxPLAN_YMD      =1,	
		IxLINE_CD		=2, 
		IxLINE_NAME		=3,
		IxMODEL_NAME	=4,
		IxSTYLE_CD		=5,
		IxOBS_ID		=6,
		IxOBS_TYPE		=7,	
		IxLOT			=8,	 
		IxDAY_SEQ		=9, 
		IxTS_FINISH_YN  =10,
		IxREQ_NO        =11,
		IxOBS_NU		=12,
		IxOBS_SEQ_NU    =13,
		IxMLINE_CD      =14,  
		IxMLINE_NAME    =15,  
		IxTOT_QTY		=16, 	
		IxGEN			=17,
		IxCS_SIZE		=18,
		IxSIZE_QTY		=19,
 
		IxCS_SIZE_START =18, 
		  

	} 



	/// <summary> 
	/// TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_LOT_DAILY_MINI_TS_SIZE_BSC : int 
	{  
 
		IxPLAN_STATUS		= 0,
		IxTS_FINISH_YN		= 1,
		IxTREE_LEVEL		= 2,
		IxTREE_DESC1		= 3,
		IxOBS_NU			= 4,
		IxOBS_SEQ_NU		= 5,
		IxTREE_DESC2		= 6, 
		IxTREE_DESC3		= 7,  
		IxTREE_DESC4		= 8,
		IxFINISH_DATE		= 9,
		IxLOT_NO			=10,
		IxLOT_SEQ			=11,
		IxREQ_NO			=12,
		IxDAY_SEQ			=13,
		IxMLINE_CD			=14,
		IxINPUT_PRIO		=15,
		IxTOT_QTY			=16,
		IxSUM_QTY			=17,
		IxCS_SIZE			=18,
		IxSIZE_QTY			=19,
		IxCS_SIZE_SORT		=20,
		IxINPUT_PRIO_SORT	=21,
		IxREQ_NO_SORT		=22,

		IxGEN				=19, 
		IxCS_SIZE_START		=20, 
		  

	} 





	/// <summary> 
	/// SPO_LOT_DAYILY_MINI_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_LOT_DAILY_MINI_TS_CHECK_BSC : int 
	{  
 

		IxPLAN_YMD      =1,	
		IxLINE_CD		=2, 
		IxLINE_NAME		=3,
		IxINPUT_PRIO    =4,
		IxMODEL_NAME	=5,
		IxSTYLE_CD		=6,
		IxOBS_ID		=7,
		IxOBS_TYPE		=8,	
		IxLOT			=9,	 
		IxDAY_SEQ		=10, 
		IxTS_FINISH_YN  =11,  
		IxTOT_QTY		=12, 	
		IxGEN			=13,
		IxCS_SIZE		=14,
		IxSIZE_QTY		=15,
 
		IxCS_SIZE_START =14, 
		  

	} 




	 

	/// <summary> 
	/// SPB_LINEOP_MINI 그리드 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_LINEOP_MINI_GRID: int 
	{ 
		IxMaxCt = 24, 
		IxCODE =1,			 
		IxNAME =2,
		IxLINE_CD =3,
		IxLINE_NAME =4,
		IxOP_CD =5, 
		IxOP_NAME =6, 
		IxOP_LINE =7, 
		IxOP_LINE_NAME =8,
		IxLEVEL =9,
		IxFACTORY =10,
		IxGROUP_ID =11,
		IxREAL_LINE_CD =12,
		IxAREA_CD =13,
		IxOUT_YN =14,
		IxMAX_CAPA =15,
		IxSTD_CAPA =16,
		IxMIN_CAPA =17,
		IxPROC_UNIT =18,
		IxWORK_TIME =19, 
		IxREMARKS =20,
		IxUPD_USER =21,			 
		IxUPD_YMD =22,
		IxEXIST_YN =23,
		IxMLINE_QTY =24,
 
	} 

 


	/// <summary> 
	/// TBSPB_LINEOP_MINI_GRID에서 Arr_TBSPB_LINEOP_MINI 추출값
	/// </summary> 
	public class Arr_TBSPB_LINEOP_MINI
	{
		public int[] lx= {(int)TBSPB_LINEOP_MINI_GRID.IxFACTORY
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxLINE_CD
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxOP_CD
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxOP_LINE
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxOP_LINE_NAME
                             ,(int)TBSPB_LINEOP_MINI_GRID.IxGROUP_ID
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxREAL_LINE_CD
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxAREA_CD
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxOUT_YN
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxMAX_CAPA
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxSTD_CAPA
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxMIN_CAPA
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxPROC_UNIT
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxWORK_TIME
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxREMARKS 
							 ,(int)TBSPB_LINEOP_MINI_GRID.IxUPD_USER} ; 

		public Arr_TBSPB_LINEOP_MINI()
		{
		}
 

	} 



	/// <summary> 
	/// TBSPB_OPCD_LINE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_OPCD_LINE_POPUP : int 
	{  
		IxCHECK_FLAG =1, 	
		IxOP_LINE =2,		
		IxOP_LINE_NAME =3,
		IxLINE_CD =4,
		IxAREA_CD =5,		
		IxOUT_YN =6,		
		IxSTD_CAPA =7,		
		IxPROD_UNIT =8,		
		IxPROD_TIME =9,		
		IxREMARKS =10, 
		IxSEL_YN =11,
	}  


	/// <summary> 
	/// 공정도 그리기 위한 RoutBom 리스트 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_ROUT_BOM_LEADTIME : int 
	{ 
		IxCMP_CD =0,
		IxUP_CMP_CD =1,		
		IxCMP_LEVEL =2,		
		IxROUT_SEQ =3,			
		IxOP_CD =4,   
		IxOP_NAME =5,		 
		IxSTD_OPCD =6,
		IxLEAD_TIME =7,
		IxSETUP_TIME =8,	
		IxPROCESS_TIME =9,	
		IxWAITTING_TIME =10,	
		IxOVERLAP_TIME =11,			
		IxOTU =12,
		IxOP_COLOR =13, 	
	}  

 

	/// <summary> 
	/// 공정도 그리기 위한 리스트 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_LEADTIME_DIAGRAM : int 
	{ 
		IxCMP_CD =0, 		
		IxOP_CD =1,   
		IxOP_NAME =2,	
		IxSTD_CMP =3,
		IxSTD_OPCD =4,
		IxLEAD_TIME =5, 
		IxPROCESS_TIME =6, 
		IxOP_COLOR =7, 
		IxMAX_LT_TIME =8,
		IxH_DAY =9,

		IxGRCMP_CD =1,
		IxGROP_CD =2, 
		IxGRLT_START =3,

	}    
   



	/// <summary> 
	/// SPB_LINEOP_MINI_RSC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_LINEOP_MINI_RSC : int 
	{ 
		IxMaxCt =17, 	 
		IxLINE_CD =0,			 
		IxLINE_NAME =1, 	
		IxOP_CD =2,	
		IxOP_NAME =3,
		IxOP_LINE =4,	
		IxOP_LINE_NAME =5,	
		IxRSC_TYPE =6,
		IxRSC_CD =7,
		IxRSC_NAME =8,
		IxLEVEL =9,
		IxFACTORY =10,
		IxSTD_CAPA =11,
		IxREAL_CAPA =12,
		IxPROD_UNIT =13,
		IxPROD_TIME =14,
		IxRSC_QTY =15,
		IxTOT_DAY_CAPA =16, 
		IxHIDDEN_RES_CD =17,
 
		 
	}  



	/// <summary> 
	/// SPB_LINEOP_MINI_RSC 그리드 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_LINEOP_MINI_RSC_GRID : int 
	{ 
		IxMaxCt = 23, 
		IxCODE =1,			 
		IxNAME =2,
		IxLINE_CD =3,
		IxLINE_NAME =4,
		IxOP_CD =5, 
		IxOP_NAME =6, 
		IxOP_LINE =7, 
		IxOP_LINE_NAME =8,
		IxRSC_TYPE =9,	
		IxRSC_CD =10, 
		IxRSC_NAME =11,
		IxLEVEL =12,
		IxFACTORY =13,
		IxSTD_CAPA =14,
		IxREAL_CAPA =15,
		IxPROD_UNIT =16,
		IxPROD_TIME =17,
		IxRSC_QTY =18,
		IxTOT_DAY_CAPA =19,
		IxREMARKS =20,			  
		IxUPD_USER =21,			 
		IxUPD_YMD =22,
		IxHIDDEN_RES_CD =23, 			 
		 
	}  



	/// <summary> 
	/// TBSPB_LINEOP_MINI_RSC_GRID에서 Arr_TBSPB_LINEOP_MINI_RSC 추출값
	/// </summary> 
	public class Arr_TBSPB_LINEOP_MINI_RSC
	{
		public int[] lx= {(int)TBSPB_LINEOP_MINI_RSC_GRID.IxFACTORY
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxLINE_CD
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxOP_CD
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxOP_LINE
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxRSC_CD
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxLINE_NAME
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxOP_NAME
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxOP_LINE_NAME
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxRSC_TYPE
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxRSC_NAME
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxSTD_CAPA
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxREAL_CAPA
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxPROD_UNIT 
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxPROD_TIME
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxRSC_QTY
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxTOT_DAY_CAPA
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxREMARKS
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxUPD_USER
							 ,(int)TBSPB_LINEOP_MINI_RSC_GRID.IxHIDDEN_RES_CD} ; 

		public Arr_TBSPB_LINEOP_MINI_RSC()
		{
		}
 

	} 




	/// <summary>
	/// DT_TOOL 테이블 인덱스 Enum (NEOMICS.DT_TOOL에서 추출한 데이터)
	/// </summary>
	public enum TBDT_TOOL : int
	{
		IxMaxCt = 4,

		IxTOOL_CD = 1,     //몰드코드
		IxTOOL_NM = 2,     //몰드명
		IxSPEC_CD = 3,     //스펙코드
		IxGEN = 4,         //젠더

	}


	/// <summary> 
	/// SPB_MODEL 테이블 인덱스 Enum (DA_MOD에서 추출한 데이터)
	/// </summary> 
	public enum TBSPB_MODEL_HEAD : int 
	{ 
 	 
		IxMaxCt = 4,		    // 인덱스 Count  
		IxMODEL_CD =1,			// 모델코드	:VARCHAR2(6) 
		IxMODEL_NAME =2,		// 모델명	:VARCHAR2(60) 
		IxCATEGORY =3,			// 카테고리 : 모델에 대한 유형	:VARCHAR2(4)
		IxREMARKS =4,			// 비고	:VARCHAR2(100) 


	}  
 
	


	/// <summary> 
	/// SPB_MODEL 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_MODEL : int 
	{ 
 
		IxMaxCt = 8,		    // 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxMODEL_CD =2,			// 모델코드	:VARCHAR2(6) 
		IxMODEL_NAME =3,		// 모델명	:VARCHAR2(60) 
		IxCATEGORY =4,			// 카테고리 : 모델에 대한 유형	:VARCHAR2(4) 
		IxBOM_CD =5,            // BOM Code
		IxLINE_QTY =6,			// 사전 할당 제조라인 수	:NUMBER(22) 
		IxREMARKS =7,			// 비고	:VARCHAR2(100) 
		IxBOM_CD_OLD =8,		// BOM Code Old
		IxUPD_USER =9,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =10,			// 작성일자	:DATE(7) 

	}  



	/// <summary> 
	/// SPB_MODEL_OPCD 그리드 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_MODEL_OPCD_GRID : int 
	{ 
		IxMaxCt = 17,		  
		IxCODE =1,			 
		IxNAME =2,			 
		IxBOM_CD =3,			 
		IxBOM_NAME =4, 	
		IxMOLD_YN =5,		
		IxMOLD_TYPE =6,	
		IxTYPE_NAME =7,	
		IxLEVEL =8,
		IxMODEL_CD =9,
		IxCMP_CD =10,
		IxOP_CD =11,
		IxMOLD_CD =12,
		IxMOLD_ORD =13,
		IxMOLD_CYCLE =14,
		IxREMARKS =15,
		IxFACTORY =16,
		IxGEN =17, 
 
		 
	}  


	/// <summary> 
	/// TBSPB_MODEL_OPCD에서 Arr_TBSPB_MODEL_OPMOLD추출값
	/// </summary> 
	public class Arr_TBSPB_MODEL_OPMOLD
	{
		public int[] lx= {(int)TBSPB_MODEL_OPCD_GRID.IxFACTORY
							 ,(int)TBSPB_MODEL_OPCD_GRID.IxMODEL_CD
							 ,(int)TBSPB_MODEL_OPCD_GRID.IxGEN
							 ,(int)TBSPB_MODEL_OPCD_GRID.IxCMP_CD
							 ,(int)TBSPB_MODEL_OPCD_GRID.IxOP_CD
							 ,(int)TBSPB_MODEL_OPCD_GRID.IxMOLD_TYPE
							 ,(int)TBSPB_MODEL_OPCD_GRID.IxMOLD_CD
							 ,(int)TBSPB_MODEL_OPCD_GRID.IxMOLD_ORD
							 ,(int)TBSPB_MODEL_OPCD_GRID.IxMOLD_CYCLE
							 ,(int)TBSPB_MODEL_OPCD_GRID.IxREMARKS}; 
		//,(int)TBSPB_MODEL_OPCD_GRID.IxUPD_USER}; 

		public Arr_TBSPB_MODEL_OPMOLD()
		{
		}



	}



	/// <summary> 
	/// SPB_MODEL_OPCD 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_MODEL_OPCD : int 
	{ 
		IxMODEL_CD =0,			 
		IxMODEL_NAME =1,			 
		IxBOM_CD =2,			 
		IxBOM_NAME =3, 	
		IxCMP_CD =4,			 
		IxCMP_NAME =5, 	
		IxOP_CD =6,			 
		IxOP_NAME =7, 	
		IxMOLD_YN =8,		
		IxMOLD_TYPE =9,	
		IxTYPE_NAME = 10,
		IxLEVEL = 11,
		IxFACTORY = 12,
		IxMOLD_CD = 13,
		IxMOLD_ORD = 14,
		IxMOLD_CYCLE = 15,
		IxREMARKS = 16, 
		IxGEN =17,  
		 
	}  
 
 

	/// <summary> 
	/// SPB_MODEL_LINE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_MODEL_LINE : int 
	{ 
		IxMaxCt = 9,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxMODEL_CD =2,			// 모델코드	:VARCHAR2(6) 
		IxGEN =3,			// 모델코드	:VARCHAR2(6) 
		IxLINE_SEQ =4,			// 라인 우선순위	:VARCHAR2(10) 
		IxLINE_CD =5,			// 라인코드	:VARCHAR2(3) 
		IxALO_RATE =6,			// 생산 능력 할당 비율	:NUMBER(22) 
		IxREMARKS =7,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =8,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =9,			// 작성일자	:DATE(7) 
	}  



	/// <summary> 
	/// SPB_STYLE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_STYLE_HEAD_BEFORE : int 
	{ 
		IxMaxCt = 17,		// 인덱스 Count 
		 
		IxSTYLE_CD =1,			// 스타일코드	:VARCHAR2(9) 
		IxSTYLE_NAME =2,			// 스타일명
		IxGEN =3,			// 성별	:VARCHAR2(3) 
		IxREMARKS =4,			// 비고	:VARCHAR2(100) 
		IxASSIGN_TYPE =5,			// 할당방식 (균등할당, 일괄할당)	:VARCHAR2(2) 
		IxCATEGORY =6,			// 카테고리	:VARCHAR2(4) 
		IxPH_YN =7,			// PH 여부	:VARCHAR2(1) 
		IxPH_SPU_YN =8,			// PH with SPU 여부	:VARCHAR2(1) 
		IxPU_YN =9,			// PU 여부	:VARCHAR2(1) 
		IxPU_SPU_YN =10,			// PU with SPU 여부	:VARCHAR2(1) 
		IxSPU_YN =11,			// SPU 여부	:VARCHAR2(1) 
		IxHIGH_FREQ_YN =12,			// 고주파 여부	:VARCHAR2(1) 
		IxEMB_YN =13,			// 자수 여부	:VARCHAR2(1) 
		IxDYING_YN =14,			// 나염 여부	:VARCHAR2(1) 
		IxEFF_RATE =15,			// 생산효율	:NUMBER(22) 
		IxSTD_ASY_CAPA =16,			// 표준 제조라인 생산 능력	:NUMBER(22) 
		IxLINE_QTY =17,			// 사전 할당 제조라인 수	:NUMBER(22) 
		 
	}  



	/// <summary> 
	/// SPB_STYLE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_STYLE_HEAD : int 
	{ 
		IxMaxCt = 7, 
		IxSTYLE_CD =1,			
		IxSTYLE_NAME =2,		
		IxGEN =3,		
		IxCATEGORY =4,	
		IxBOM_CD =5,
		IxLINE_QTY =6,		
		IxREMARK =7,	
		 
	}  


	/// <summary> 
	/// SPB_STYLE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_STYLE_BEFORE : int 
	{ 
		IxMaxCt = 20,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxMODEL_CD =2,			// 모델코드	:VARCHAR2(6) 
		IxSTYLE_CD =3,			// 스타일코드	:VARCHAR2(9) 
		IxGEN =4,			// 성별	:VARCHAR2(3) 
		IxASSIGN_TYPE =5,			// 할당방식 (균등할당, 일괄할당)	:VARCHAR2(2) 
		IxCATEGORY =6,			// 카테고리	:VARCHAR2(4) 
		IxPH_YN =7,			// PH 여부	:VARCHAR2(1) 
		IxPH_SPU_YN =8,			// PH with SPU 여부	:VARCHAR2(1) 
		IxPU_YN =9,			// PU 여부	:VARCHAR2(1) 
		IxPU_SPU_YN =10,			// PU with SPU 여부	:VARCHAR2(1) 
		IxSPU_YN =11,			// SPU 여부	:VARCHAR2(1) 
		IxHIGH_FREQ_YN =12,			// 고주파 여부	:VARCHAR2(1) 
		IxEMB_YN =13,			// 자수 여부	:VARCHAR2(1) 
		IxDYING_YN =14,			// 나염 여부	:VARCHAR2(1) 
		IxEFF_RATE =15,			// 생산효율	:NUMBER(22) 
		IxSTD_ASY_CAPA =16,			// 표준 제조라인 생산 능력	:NUMBER(22) 
		IxLINE_QTY =17,			// 사전 할당 제조라인 수	:NUMBER(22) 
		IxREMARKS =18,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =19,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =20,			// 작성일자	:DATE(7) 
	}  

	/// <summary> 
	/// SPB_STYLE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_STYLE : int 
	{ 
		IxMaxCt = 10,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxMODEL_CD =2,			// 모델코드	:VARCHAR2(6) 
		IxSTYLE_CD =3,			// 스타일코드	:VARCHAR2(9) 
		IxGEN =4,			// 성별	:VARCHAR2(3) 
		IxCATEGORY =5,			// 카테고리	:VARCHAR2(4) 
		IxBOM_CD =6,
		IxLINE_QTY =7,			// 사전 할당 제조라인 수	:NUMBER(22) 
		IxREMARKS =8,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =9,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =10,			// 작성일자	:DATE(7) 
	}  



	/// <summary> 
	/// SPB_STYLE_MOLD 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_STYLE_MOLD : int 
	{ 
		IxMaxCt = 10,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxMODEL_CD =2,			// 모델코드	:VARCHAR2(6) 
		IxSTYLE_CD =3,			// 스타일 코드	:VARCHAR2(9) 
		IxCMP_CD =4,			// 품목 (반제) 코드	:VARCHAR2(10) 
		IxMOLD_TYPE =5,			// 몰드유형	:VARCHAR2(2) 
		IxMOLD_CD =6,			// 몰드코드	:VARCHAR2(5) 
		IxPG_SEQ =7,			// 표시순번	:NUMBER(22) 
		IxREMARKS =8,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =9,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =10,			// 작성일자	:DATE(7) 
	}  



	/// <summary> 
	/// SPB_STYLE_LINE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_STYLE_LINE : int 
	{ 
		IxMaxCt = 9,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxMODEL_CD =2,			// 모델코드	:VARCHAR2(6) 
		IxSTYLE_CD =3,			// 스타일코드	:VARCHAR2(9) 
		IxLINE_SEQ =4,			// 라인 우선순위	:VARCHAR2(10) 
		IxLINE_CD =5,			// 라인코드	:VARCHAR2(3) 
		IxALO_RATE =6,			// 생산 능력 할당 비율	:NUMBER(22) 
		IxREMARKS =7,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =8,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =9,			// 작성일자	:DATE(7) 
	}  



	

	/// <summary>
	/// SPB_STYLE_OPCD 테이블 인덱스 Enum 
	/// </summary>
	public enum TBSPB_STYLE_OPCD : int
	{
		 
		IxMODEL_CD =0,			 
		IxMODEL_NAME =1,
		IxSTYLE_CD =2,			 
		IxSTYLEL_NAME =3,
		IxGEN =4, 
		IxBOM_CD =5,			 
		IxBOM_NAME =6, 
		IxCMP_CD =7,			 
		IxCMP_NAME =8, 
		IxOP_CD =9,			 
		IxOP_NAME =10, 
		IxMOLD_YN =11,		
		IxMOLD_TYPE =12,	
		IxTYPE_NAME = 13, 
		IxMOLD_CD = 14,
		IxMOLD_ORD = 15,
		IxMOLD_CYCLE = 16,
		IxREMARKS = 17,  
		IxLEVEL = 18,
		IxFACTORY = 19, 
		IxUPD_USER =20,
		IxUPD_YMD =21,
  
	}

 	

	/// <summary> 
	/// SPB_STYLE_OPCD 그리드 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_STYLE_OPCD_GRID : int 
	{ 
		IxMaxCt = 20,		  
		IxCODE =1,			 
		IxNAME =2,	
		IxGEN =3,  
		IxBOM_CD =4,			 
		IxBOM_NAME =5, 	
		IxMOLD_YN =6,		
		IxMOLD_TYPE =7,	
		IxTYPE_NAME =8,	
		IxLEVEL =9,
		IxMODEL_CD =10,
		IxSTYLE_CD =11,	
		IxCMP_CD =12,
		IxOP_CD =13,
		IxMOLD_CD =14,
		IxMOLD_ORD =15,
		IxMOLD_CYCLE =16,
		IxREMARKS =17,
		IxFACTORY =18,
		IxUPD_USER =19,
		IxUPD_YMD =20, 
		 
	}  


	/// <summary> 
	/// TBSPB_STYLE_OPCD_GRID에서 Arr_TBSPB_STYLE_OPMOLD추출값
	/// </summary> 
	public class Arr_TBSPB_STYLE_OPMOLD
	{
		public int[] lx= {(int)TBSPB_STYLE_OPCD_GRID.IxFACTORY
							 ,(int)TBSPB_STYLE_OPCD_GRID.IxMODEL_CD
							 ,(int)TBSPB_STYLE_OPCD_GRID.IxSTYLE_CD
							 ,(int)TBSPB_STYLE_OPCD_GRID.IxCMP_CD
							 ,(int)TBSPB_STYLE_OPCD_GRID.IxOP_CD
							 ,(int)TBSPB_STYLE_OPCD_GRID.IxMOLD_TYPE
							 ,(int)TBSPB_STYLE_OPCD_GRID.IxMOLD_CD
							 ,(int)TBSPB_STYLE_OPCD_GRID.IxBOM_CD
							 ,(int)TBSPB_STYLE_OPCD_GRID.IxMOLD_ORD
							 ,(int)TBSPB_STYLE_OPCD_GRID.IxMOLD_CYCLE
							 ,(int)TBSPB_STYLE_OPCD_GRID.IxREMARKS 
							 ,(int)TBSPB_STYLE_OPCD_GRID.IxUPD_USER} ; 

		public Arr_TBSPB_STYLE_OPMOLD()
		{
		}



	}


	/// <summary> 
	/// SPB_BOM_CD 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_BOM_CD : int 
	{ 
		IxMaxCt = 13,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxBOM_CD =2,			// BOM 코드	:VARCHAR2(10) 
		IxBOM_DESC =3,			// BOM 코드 설명	:VARCHAR2(60) 
		IxJOB_CD =4,			// 업무코드	:VARCHAR2(10) 
		IxMODEL_CD =5,			// 모델코드	:VARCHAR2(6) 
		IxSTYLE_CD =6,			// 스타일 코드	:VARCHAR2(9) 
		IxLINE_CD =7,			// 라인 코드	:VARCHAR2(3) 
		IxLINK_TYPE =8,			// 링크 타입 : 라우팅 속성 정의 (AddFlow 에서 Link 속성 정의) 에서 BOM 연결 타입 선택	:VARCHAR2(10) 
		IxDEFAULT_YN =9,			// 공장의 DEFAULT BOM 여부	:VARCHAR2(1)
		IxORD =10,
		IxREMARKS =11,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =12,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =13,			// 작성일자	:DATE(7) 
	}  


	/// <summary> 
	/// SPB_NODE_DEF 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_NODE_DEF : int 
	{ 
		IxMaxCt = 24,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxCMP_TYPE =2,			// BOM CMP 분류코드 : SG(SemiGood), TP(Type), GP(Group), BM(Base Mat.)	:VARCHAR2(10) 
		IxTYPE_NAME =3,			// BOM CMP 분류 코드명	:VARCHAR2(60) 
		IxPHANTOM_YN =4,			// 가상타입 여부	:VARCHAR2(1) 
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
		IxREMARKS =22,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =23,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =24,			// 작성일자	:DATE(7) 
	}  







	/// <summary> 
	/// SPB_BOM 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_BOM : int 
	{ 
		IxMaxCt = 10,		// 인덱스 Count  
		IxCMP_TYPE =1,			// 품목 (반제) 타입	:VARCHAR2(5) 
		IxCMP_CD =2,			// 품목 (반제) 코드	:VARCHAR2(10) 
		IxUP_CMP_CD =3,			// 상위 품목 (반제) 코드	:VARCHAR2(10) 
		IxCMP_NAME =4,			// 품목 (반제) 명	:VARCHAR2(60) 
		IxCMP_LEVEL =5,			// 품목 (반제) 레벨	:VARCHAR2(5) 
		IxCMP_ORD =6,			// 품목 (반제) 순서 : 동등레벨에서의 순서	:VARCHAR2(5) 
		IxLEAFCMP_LEVEL =7,		// 최하위 품목 레벨 : 동일품목에 한하여 최하위 품목 레벨을 설정한다   (자동등록)	:VARCHAR2(5) 
		IxAVAIL_YMD =8,			// 유효기간	:VARCHAR2(8) 
 		IxREMARKS =9,			// 비고	:VARCHAR2(100) 
		IxROUT_YN =10,
	}  



	/// <summary> 
	/// SPB_NODE_BOM 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_NODE_BOM : int 
	{ 
		IxMaxCt = 23,		// 인덱스 Count 
//		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
//		IxBOM_CD =2,			// BOM 코드	:VARCHAR2(10) 
		IxCMP_CD =1,			// 품목 (반제) 코드	:VARCHAR2(10) 
		IxNODE_CD =2,			// 노드코드 : 공장코드 + BOM 코드 + Seq(4)	:VARCHAR2(20) 
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
	/// SPB_LINK_BOM 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_LINK_BOM : int 
	{ 
		IxMaxCt = 19,		// 인덱스 Count 
//		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
//		IxBOM_CD =2,			// BOM 코드	:VARCHAR2(10) 
//		IxLINK_SEQ =3,			// 링크 순번	:VARCHAR2(10) 
		IxORG_NODE =1,			// 링크할 ORIGIN NODE	:VARCHAR2(10) 
		IxDST_NODE =2,			// 링크할 DESTINATION NODE	:VARCHAR2(10) 
//		IxPOINT =3,			// 링크 좌표점	:VARCHAR2(60) 
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
		IxUPD_USER =17,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =18,			// 작성일자	:DATE(7) 
	}  




	/// <summary> 
	/// SPB_ROUT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_ROUT : int 
	{ 
		IxMaxCt = 30,  //29,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxCMP_CD =2,			// 품목 (반제) 코드	:VARCHAR2(10) 
		IxROUT_TYPE =3,			// 라우팅 타입 (예 : 대형라인 라우팅, NOS라우팅, NIC 라우팅 등)	:VARCHAR2(5) 
		IxROUT_SEQ =4,			// 공정 순번	:VARCHAR2(3) 
		IxROUT_NAME =5,			// 라우팅명	:VARCHAR2(50) 
		IxOP_CD =6,			// 공정코드	:VARCHAR2(10) 
		IxOP_TYPE =7,			// 공정 타입 : 라우팅 연결을 위한 필드	:VARCHAR2(10) 
		IxOP_GROUP =8,			// 공정 그룹 : 라우팅 연결을 위한 필드	:VARCHAR2(10) 
		IxBEFORE_OPCD =9,			// 선공정	:VARCHAR2(100) 
		IxNEXT_OPCD =10,			// 후공정	:VARCHAR2(100) 
		IxOP_LEVEL =11,			// 공정 레벨 : 시작은 1, 순차적으로 1레벨씩 증가한다. 공정 seq와 10의 배수의 관계에 있다	:VARCHAR2(5) 
		IxOP_FIRST_YN =12,			// 품목 첫공정 여부	:VARCHAR2(1) 
		IxOP_LAST_YN =13,			// 품목 끝공정 여부	:VARCHAR2(1) 
		IxMULTI_IN_YN =14,			// 멀티 IN 여부	:VARCHAR2(1) 
		IxMULTI_OUT_YN =15,			// 멀티 OUT 여부	:VARCHAR2(1) 
		IxFB_YN =16,			// 피드백 여부	:VARCHAR2(1) 
		IxFB_IN_YN =17,			// 피드백 IN 여부	:VARCHAR2(1) 
		IxFB_OUT_IN =18,			// 피드백 OUT 여부	:VARCHAR2(1) 
		IxFB_MULTI_IN_YN =19,			// 피드백 멀티 IN 여부	:VARCHAR2(1) 
		IxFB_MULTI_OUT_YN =20,			// 피드백 멀티 OUT 여부	:VARCHAR2(1) 
		IxFB_BEFORE_OPCD =21,			// 피드백 선공정	:VARCHAR2(100) 
		IxFB_NEXT_OPCD =22,			// 피드백 후공정	:VARCHAR2(100) 
		IxCOMPONENT_YN =23,			// 일부생산 여부	:VARCHAR2(1) 
		IxSETUP_TIME =24,			// 준비시간	:VARCHAR2(9) 
		IxOVER_TYPE =25,			// 오버랩 타입 (예 : SSEE, SESE)	:VARCHAR2(4) 
		IxOVER_TIME =26,			// 오버랩 리드타임	:VARCHAR2(9) 
		IxREMARKS =27,			// 비고	:VARCHAR2(100)
		IxH_ROUT_SEQ = 28,      // 키가 되는 순번
		IxUPD_USER =29,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =30,			// 작성일자	:DATE(7) 
			
		IxNODE_NO = 31,         // 그려지는 노드 순번 
		IxOP_NAME = 32,
	}  
 

 


	/// <summary> 
	/// SPB_LINK_DEF 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_LINK_DEF : int 
	{ 
		IxMaxCt = 19,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxLINK_TYPE =2,			// 링크 속성 코드 : BOM, ROUTING 등의 구분 코드	:VARCHAR2(10) 
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
		IxREMARKS =17,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =18,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =19,			// 작성일자	:DATE(7) 
	}  



	/// <summary> 
	/// SPB_NODE_ROUT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_NODE_ROUT : int 
	{ 
		IxMaxCt = 23,  //26,		// 인덱스 Count 
//		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
//		IxCMP_CD =2,			// 품목 (반제) 코드	:VARCHAR2(10) 
//		IxROUT_TYPE =3,			// 라우팅 타입 (예 : 대형라인 라우팅, NOS라우팅, NIC 라우팅 등)	:VARCHAR2(5) 
		IxROUT_SEQ =1,			// 공정순번	:VARCHAR2(3) 
		IxNODE_CD =2,			// 노드코드 : 공장코드 + BOM 코드 + Seq(4)	:VARCHAR2(30) 
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
		IxTAG = 17,			// 태그 속성	:VARCHAR2(60) 
		IxTEXT = 18,			// 텍스트	:VARCHAR2(60) 
		IxTEXTCOLOR =19,			// 텍스트 표시 색깔	:VARCHAR2(10) 
		IxTOOLTIP =20,			// 툴팁	:VARCHAR2(60) 
		IxWIDTH =21,			// 노드 너비	:VARCHAR2(10) 
		IxUPD_USER =22,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =23,			// 작성일자	:DATE(7) 
	}  



	/// <summary> 
	/// SPB_LINK_ROUT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_LINK_ROUT : int 
	{ 
		IxMaxCt = 18, //23,		// 인덱스 Count 
//		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
//		IxCMP_CD =2,			// 품목 (반제) 코드	:VARCHAR2(10) 
//		IxROUT_TYPE =3,			// 라우팅 타입	:VARCHAR2(5) 
//		IxLINK_SEQ =4,			// 링크순번	:VARCHAR2(5) 
		IxORG_NODE =1,			// 링크할 ORIGIN NODE	:VARCHAR2(10) 
		IxDST_NODE =2,			// 링크할 DESTINATION NODE	:VARCHAR2(10) 
//		IxPOINT =3,			// 링크 좌표점	:VARCHAR2(60) 
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
		IxUPD_USER =17,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =18,			// 작성일자	:DATE(7) 
	}  

	/// <summary> 
	/// SPB_ROUT_BOM 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_ROUT_BOM : int 
	{ 
		IxMaxCt = 17,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxBOM_CD =2,			// BOM 코드	:VARCHAR2(10) 
		IxCMP_CD =3,			// 품목 (반제) 코드	:VARCHAR2(10) 
		IxROUT_TYPE =4,			// 라우팅 타입 (예 : 대형라인 라우팅, NOS라우팅, NIC 라우팅 등)	:VARCHAR2(5) 
		IxROUT_SEQ =5,			// 공정순번	:VARCHAR2(3) 
		IxCMP_NAME =6,			// 품목 (반제) 명	:VARCHAR2(50) 
		IxUP_CMP_CD =7,			// 상위 품목 (반제) 코드	:VARCHAR2(10) 
		IxCMP_TYPE =8,			// 품목 (반제)  타입	:VARCHAR2(5) 
		IxCMP_LEVEL =9,			// 품목 (반제) 레벨	:VARCHAR2(5) 
		IxCMP_ORD =10,			// 품목 (반제) 순서	:VARCHAR2(5) 
		IxOP_CD =11,			// 공정코드	:VARCHAR2(10) 
		IxOP_TYPE =12,			// 공정 타입 : 라우팅 연결을 위한 필드	:VARCHAR2(10) 
		IxOP_GROUP =13,			// 공정 그룹 : 라우팅 연결을 위한 필드	:VARCHAR2(10) 
		IxOP_LEVEL =14,			// 공정 레벨 : 시작은 1, 순차적으로 1레벨씩 증가한다.	:VARCHAR2(5) 
		IxREMARKS =15,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =16,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =17,			// 작성일자	:DATE(7)
 
		IxH_ROUT_SEQ =18,
		IxNODE_NO = 19,          // 그려지는 노드 순번
		IxOP_NAME = 20,
 
	}  


	/// <summary> 
	/// SEM_REQ 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_REQ : int 
	{ 
		IxMaxCt = 37,		// 인덱스 Count 
		IxCHECK_FLAG =1, 
		IxMODEL_NAME =2,
		IxSTYLE_CD =3,			// 스타일 코드	:VARCHAR2(9) 
		IxGEN =4,			// 성별	:VARCHAR2(2)  
		IxDEST =5,			// 행선지	:VARCHAR2(7)
		IxTOT_SUM_QTY =6,
		IxTOT_QTY =7,			// 총오더수량	:NUMBER(22) 
		IxTOT_LOSS_QTY =8, 
		IxSUM_QTY =9,
		IxFACTORY =10,			// 공장구분	:VARCHAR2(5) 
		IxOBS_ID =11,
		IxREQ_NO =12,			// 생산의뢰 순번	:VARCHAR2(10) 
		IxRGAC =13,
		IxOGAC =14, 
		IxOBS_TYPE =15,			// OBS 타입	:VARCHAR2(2) 
		IxDEST_PRITY =16,			// 행선지 우선순위	:VARCHAR2(3) 
		IxREAL_OBS_DIV =17,			// 실OBS/가OBS구분-Y/N	:VARCHAR2(1) 
		IxOBS_NU =18,			// OBS 번호	:VARCHAR2(10) 
		IxOBS_SEQ_NU =19,			// OBS순번	:VARCHAR2(10) 
		IxCHG_NU =20,			// OBS변경순번	:VARCHAR2(5) 
		IxOBS_DIV =21,			// GPO/DPO 구분	:VARCHAR2(1)  
		IxPST_YN =22,			// 프레스토 구분	:VARCHAR2(1)  
		IxCSETS_YMD =23,			// CSETS_DATE/GAC_DATE : 공장단 선적 예정일	:VARCHAR2(8) 
		IxCSETS_RSN =24,			// GAC REASON : ETC 사유	:VARCHAR2(30) 
		IxREQ_YMD =25,			// 생산의뢰 요청일[BU용]	:VARCHAR2(8) 
		IxOA_NU =26,			// OA NUMBER	:VARCHAR2(15) 
		IxOA_OBS_DIV =27,			// OA DPO (실/가/실==>가)	:VARCHAR2(15) 
		IxOA_DIV =28,			// OA 종류	:VARCHAR2(1) 
		IxOA_YMD =29,			// OA 일자	:VARCHAR2(8) 
		IxOA_CFM =30,			// OA 확정유무	:VARCHAR2(1) 
		IxOA_FLAG =31,			// OA FLAG(I/U/D)	:VARCHAR2(1) 
		IxORD_STATUS =32,			// 오더 마감 구분	:VARCHAR2(1)  
		IxPLAN_OAAPP_DIV =33, 
		IxPLAN_OAAPP_YMD =34, 
		IxREMARKS =35,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =36,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =37,			// 작성일자	:DATE(7) 
	}  
 
	/// <summary> 
	/// SPO_RECV 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_RECV : int 
	{  
		IxMaxCt = 38,		// 인덱스 Count 
		IxMODEL_NAME =1,
		IxSTYLE_CD =2,			// 스타일 코드	:VARCHAR2(9) 
		IxGEN =3,			// 성별	:VARCHAR2(2)  
		IxDEST =4,			// 행선지	:VARCHAR2(7)
		IxTOT_SUM_QTY =5,
		IxTOT_QTY =6,			// 총오더수량	:NUMBER(22) 
		IxTOT_LOSS_QTY =7, 
		IxSUM_QTY =8,
		IxFACTORY =9,			// 공장구분	:VARCHAR2(5) 
		IxOBS_ID =10,
		IxREQ_NO =11,			// 생산의뢰 순번	:VARCHAR2(10) 
		IxRGAC =12,
		IxOGAC =13, 
		IxOBS_TYPE =14,			// OBS 타입	:VARCHAR2(2) 
		IxDEST_PRITY =15,			// 행선지 우선순위	:VARCHAR2(3) 
		IxREAL_OBS_DIV =16,			// 실OBS/가OBS구분-Y/N	:VARCHAR2(1) 
		IxOBS_NU =17,			// OBS 번호	:VARCHAR2(10) 
		IxOBS_SEQ_NU =18,			// OBS순번	:VARCHAR2(10) 
		IxCHG_NU =19,			// OBS변경순번	:VARCHAR2(5) 
		IxOBS_DIV =20,			// GPO/DPO 구분	:VARCHAR2(1)  
		IxPST_YN =21,			// 프레스토 구분	:VARCHAR2(1)  
		IxCSETS_YMD =22,			// CSETS_DATE/GAC_DATE : 공장단 선적 예정일	:VARCHAR2(8) 
		IxCSETS_RSN =23,			// GAC REASON : ETC 사유	:VARCHAR2(30) 
		IxREQ_YMD =24,			// 생산의뢰 요청일[BU용]	:VARCHAR2(8) 
		IxOA_NU =25,			// OA NUMBER	:VARCHAR2(15) 
		IxOA_OBS_DIV =26,			// OA DPO (실/가/실==>가)	:VARCHAR2(15) 
		IxOA_DIV =27,			// OA 종류	:VARCHAR2(1) 
		IxOA_YMD =28,			// OA 일자	:VARCHAR2(8) 
		IxOA_CFM =29,			// OA 확정유무	:VARCHAR2(1) 
		IxOA_FLAG =30,			// OA FLAG(I/U/D)	:VARCHAR2(1) 
		IxORD_STATUS =31,			// 오더 마감 구분	:VARCHAR2(1)  
		IxPLAN_OAAPP_DIV =32, 
		IxPLAN_OAAPP_YMD =33,
		IxLOT_DIV =34,			// LOT 분할 여부 (YN)	:VARCHAR2(1) 
		IxLOT_REMAINQTY =35,			// LOT 분할 후 남은 수량 (TOT_QTY - LOT_QTY)	:NUMBER(22) 
		IxLOT_LOSS_REMAINQTY =36,
		IxREMARKS =37,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =38,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =39,			// 작성일자	:DATE(7) 


	}  
 
	/// <summary> 
	/// TBSPO_RECV_CHECK 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_RECV_CHECK : int 
	{  
		IxCHECK_FLAG		=  1, 
		IxFACTORY			=  2,	
		IxMODEL_NAME		=  3,
		IxSTYLE_CD			=  4,			// 스타일 코드	:VARCHAR2(9) 
		IxGEN				=  5,			// 성별	:VARCHAR2(2)
		IxOBS_ID			=  6,
		IxOBS_TYPE			=  7,	
		IxREQ_NO			=  8,
		IxDEST				=  9,  
		IxRGAC				= 10,
		IxOGAC				= 11,	
		IxMSR_YN			= 12,
		IxTOT_QTY			= 13,			// 총오더수량	:NUMBER(22) 
		IxTOT_LOSS_QTY		= 14, 
		IxSUM_QTY			= 15, 
		IxDEST_PRITY		= 16,			// 행선지 우선순위	:VARCHAR2(3) 
		IxREAL_OBS_DIV		= 17,			// 실OBS/가OBS구분-Y/N	:VARCHAR2(1) 
		IxOBS_NU			= 18,			// OBS 번호	:VARCHAR2(10) 
		IxOBS_SEQ_NU		= 19,			// OBS순번	:VARCHAR2(10) 
		IxCHG_NU			= 20,			// OBS변경순번	:VARCHAR2(5) 
		IxOBS_DIV			= 21,			// GPO/DPO 구분	:VARCHAR2(1)  
		IxPST_YN			= 22,			// 프레스토 구분	:VARCHAR2(1)  
		IxCSETS_YMD			= 23,			// CSETS_DATE/GAC_DATE : 공장단 선적 예정일	:VARCHAR2(8) 
		IxCSETS_RSN			= 24,			// GAC REASON : ETC 사유	:VARCHAR2(30) 
		IxREQ_YMD			= 25,			// 생산의뢰 요청일[BU용]	:VARCHAR2(8) 
		IxOA_NU				= 26,			// OA NUMBER	:VARCHAR2(15) 
		IxOA_OBS_DIV		= 27,			// OA DPO (실/가/실==>가)	:VARCHAR2(15) 
		IxOA_DIV			= 28,			// OA 종류	:VARCHAR2(1) 
		IxOA_YMD			= 29,			// OA 일자	:VARCHAR2(8) 
		IxOA_CFM			= 30,			// OA 확정유무	:VARCHAR2(1) 
		IxOA_FLAG			= 31,			// OA FLAG(I/U/D)	:VARCHAR2(1) 
		IxORD_STATUS		= 32,
		IxLOT_DIV			= 33,			// LOT 분할 여부 (YN)	:VARCHAR2(1) 
		IxLOT_REMAINQTY     = 34,			// LOT 분할 후 남은 수량 (TOT_QTY - LOT_QTY)	:NUMBER(22) 
		IxLOT_LOSS_REMAINQTY= 35,
		IxBOM_CD			= 36,
		IxPLAN_OAAPP_DIV	= 37, 

	}    

	/// <summary> 
	/// SPO_LOT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT : int 
	{ 
		IxMaxCt = 13,		// 인덱스 Count 
		IxROW_NO =1,
		IxFACTORY =2,			// 공장	:VARCHAR2(5) 
		IxLOT_NO =3,			// LOT 번호 (LT || YYMM000)	:VARCHAR2(9) 
		IxLOT_SEQ =4,			// LOT 순번 (00)	:VARCHAR2(2) 
		IxOBS_ID =5,
		IxOBS_TYPE =6,			// OBS 타입	:VARCHAR2(2)
		IxRTS_YMD =7,
		IxPO_NO =8,			// PO번호	:VARCHAR2(8) 
		IxSTYLE_CD =9,			// 스타일 코드	:VARCHAR2(9) 
		IxBOM_CD =10,
		IxROUT_TYPE =11,
		IxLEADTIME_CD =12, 
		IxLOT_QTY =13,			// LOT당 수량	:NUMBER(22) 
		IxLOSS_QTY =14,
		IxREAL_LOTYN =15,
		IxPLAN_OAAPP_DIV =16,
		IxLINE_CD =17,
		IxPLAN_STATUS =18,
		IxREMARKS =19,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =20,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =21,			// 작성일자	:DATE(7)
		
		
	}  
 


	
	/// <summary> 
	/// SPD_LOT_DAILY_OPSIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_CHANGE : int 
	{ 
		IxFACTORY =1,
		IxCHECK_FLAG =2,
		IxLOT =3,
		IxSTATUS =4,  
	} 





	/// <summary> 
	/// SPO_LOT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DETAIL : int 
	{ 
		IxMaxCt = 37,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxLOT_NO =2,			// LOT 번호 (LT(VL) || YYMM000)	:VARCHAR2(9) 
		IxLOT_SEQ =3,			// LOT 순번 (00)	:VARCHAR2(2) 
		IxOBS_TYPE =4,			// OBS 타입	:VARCHAR2(2) 
		IxPO_NO =5,			// PO번호	:VARCHAR2(8) 
		IxMODEL_CD =6,			// 모델 코드	:VARCHAR2(6) 
		IxSTYLE_CD =7,			// 스타일 코드	:VARCHAR2(9) 
		IxGEN =8,			// 젠더	:VARCHAR2(3) 
		IxLOT_QTY =9,			// LOT당 수량	:NUMBER(22) 
		IxREAL_LOTYN =10,			// 실, 가 LOT 여부	:VARCHAR2(1) 
		IxLINE_CD =11,			// 라인코드	:VARCHAR2(3) 
		IxTOT_DAY_SEQ =12,			// 총 DAY_SEQ	:NUMBER(22) 
		IxRTS_YMD =13,			// RTS일자	:VARCHAR2(8) 
		IxPLN_STRYMD =14,			// 계획시작일 : LOT 전체에 대한 시작일	:VARCHAR2(8) 
		IxPLN_ENDYMD =15,			// 계획종료일 : LOT 전체에 대한 종료일	:VARCHAR2(8) 
		IxPLN_STATUS =16,			// 계획 상태 (P(Plan) -> F(Fix : 확정) -> R(작업지시)  -> C(완료, 실적) -> S(Shipping))	:VARCHAR2(1) 
		IxPLN_STATUSYMD =17,			// PLN_STATUS 변경 날짜	:VARCHAR2(8) 
		IxHOLD_YN =18,			// 중단상태 여부	:VARCHAR2(1) 
		IxNEW_LOTYN =19,			// 신규 LOT 여부	:VARCHAR2(1) 
		IxTOT_LOSS_QTY =20,			// 총 로스수량 = SUM(사이즈별 로스수량)	:NUMBER(22) 
		IxDAY_SEQ_DIV =21,			// DAY SEQ 산정 방법	:VARCHAR2(1) 
		IxDAY_STD_CAPA =22,			// 라인 Capacity	:NUMBER(22) 
		IxMULTILINE_DIV =23,			// 한 LOT에 대한 라인 분할 방법	:VARCHAR2(1) 
		IxSPLIT_LIMITQTY =24,			// 라인의 분할 한계 수량	:NUMBER(22) 
		IxLINE_ASSIGN_DIV =25,			// 수량 배치 방법 - 선행 배치된 수량이 있을경우	:VARCHAR2(1) 
		IxEND_DAY_SEQ_DIV =26,			// 마지막 DAY_SEQ 가 LINE MAX_CAPA를 초과하지 않는 경우	:VARCHAR2(1) 
		IxNEW_MODEL_YN =27,			// NEW MODEL 적용 여부	:VARCHAR2(1) 
		IxINIT_RATE =28,			// 초기 라인 배당 비율	:NUMBER(22) 
		IxINC_RATE =29,			// 증가비율	:NUMBER(22) 
		IxCAPA_ASSIGN_DIV =30,			// 라인 CAPACITY 적용 방법	:VARCHAR2(1) 
		IxCAPA_DIV =31,			// LINE CAPACITY 구분 (MAX, STANDARD, MIN)	:VARCHAR2(1) 
		IxASSIGN_WAY =32,			// 배치 일자 적용 기준	:VARCHAR2(1) 
		IxASSIGN_MARGIN =33,			// 배치 일자 적용 기준 여유치	:NUMBER(22) 
		IxOP_WORKCAL =34,			// 월력 적용 기준  - 라인에 대한 대표공정 선택	:VARCHAR2(10) 
		IxREMARKS =35,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =36,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =37,			// 작성일자	:DATE(7) 
	}  




	/// <summary> 
	/// SPO_RECV_LOT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_RECV_LOT : int 
	{ 
		IxMaxCt = 16,		// 인덱스 Count 
		IxCHECK_FLAG =1,
		IxROW_NO =2,
		IxLOT_YN =3,
		IxFACTORY =4,			// 공장	:VARCHAR2(5) 
		IxREQ_NO =5,			// 생산의뢰순번	:VARCHAR2(10) 
		IxLOT_NO =6,			// LOT 번호	:VARCHAR2(9) 
		IxLOT_SEQ =7,			// LOT 순번	:VARCHAR2(2)
		IxOBS_ID =8,
		IxOBS_TYPE =9,			// OBS 타입	:VARCHAR2(2) 
		IxPO_NO =10,			// PO 번호	:VARCHAR2(8) 
		IxSTYLE_CD =11,			// 스타일 코드	:VARCHAR2(9) 
		IxTOT_QTY =12,			// 총오더수량 (REQ_NO 에 대한)	:NUMBER(22) 
		IxLOT_QTY =13,			// LOT당 수량	:NUMBER(22) 
		IxTOT_LOSS_QTY =14,
		IxLOT_LOSS_QTY =15,
		IxREAL_LOTYN =16,			 
		IxREMARKS =17,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =18,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =19,			// 작성일자	:DATE(7) 
	}  



	/// <summary> 
	/// ADDFLOW_REQ 
	/// </summary> 
	public enum TBSPO_ADDFLOW_REQ : int 
	{ 
		IxMaxCt = 11,		// 인덱스 Count 
		IxREQ_NO =0,			// 생산의뢰순번	:VARCHAR2(10) 
		IxLOT_NO_SEQ =1,			// LOT 번호	:VARCHAR2(9)  
		IxOBS_TYPE =2,			// OBS 타입	:VARCHAR2(2) 
		IxPO_NO =3,			// PO 번호	:VARCHAR2(8) 
		IxSTYLE_CD =4,			// 스타일 코드	:VARCHAR2(9) 
		IxTOT_QTY =5,			// 총오더수량 (REQ_NO 에 대한)	:NUMBER(22) 
		IxSUM_LOTQTY =6,
		IxREMAIN_LOTQTY =7, 
		IxLOT_QTY =8,			// LOT당 수량	:NUMBER(22) 
		IxLOT_COUNT =9,
		IxTOT_REQ_COUNT =10, 
 
	}  


	/// <summary> 
	/// ADDFLOW_LOT - addflow 그리기 
	/// </summary> 
	public enum TBSPO_ADDFLOW_LOT : int 
	{ 
		IxMaxCt = 10,		// 인덱스 Count  
		IxLOT_NO_SEQ =0,			// LOT 번호	:VARCHAR2(9) 
		IxOBS_TYPE =1,			// LOT당 수량	:NUMBER(22)  
		IxPO_NO =2,
		IxMODEL_CD =3,
		IxSTYLE_CD =4,
		IxGEN =5,
		IxLOT_QTY =6,
		IxLINE_CD =7, 
		IxLINE_NAME =8, 
		IxSTD_CAPA =9, 
 
	}  


	/// <summary> 
	/// ADDFLOW_LOT - addflow 그리기 
	/// </summary> 
	public enum TBSPO_ADDFLOW_LINE : int 
	{ 
		IxMaxCt = 12,		// 인덱스 Count  
		IxLOT_NO_SEQ =0,			// LOT 번호	:VARCHAR2(9) 
		IxOBS_TYPE =1,			// LOT당 수량	:NUMBER(22)  
		IxPO_NO =2, 
		IxSTYLE_CD =3,
		IxGEN =4, 
		IxLINE_CD =5, 
		IxLINE_NAME =6, 
		IxSTD_CAPA =7, 
		IxDAY_SEQ =8, 
		IxPLAN_YMD =9, 
		IxDAY_COUNT =10, 
		IxALO_QTY = 11,
 
	}  
 

	/// <summary> 
	/// Mold Capacity Plan 
	/// </summary> 
	public enum TBSPO_STYLE_SIZE : int 
	{   
		IxCHECK_FLAG =0,
		IxREQ_NO = 2, 		 
		IxSTYLE_CD =3,			 
		IxGEN =4,
		IxCS_SIZE =5,
		IxORD_QTY =6,
 
	} 

	/// <summary> 
	/// Mold Capacity Plan 
	/// </summary> 
	public enum TBSPO_MOLD_SIZE : int 
	{   
		IxMOLD_CAPA = 1,	// TYPE NAME	 		 
		IxDATA      = 3,	// MOLD CODE			 
		IxGEN       = 4,    // GEN
		IxCS_SIZE   = 6,	// CS_SIZE
		IxPRS       = 10,   // PRS
		IxORD_QTY   = 11,   // QTY
		IxMSIZE		= 8,		// MSIZE_YN
		IXFSTSIZE   = 7,    //FST_SUZE





		IxSTY_MOLD_TYPE     = 0,
		IxSTY_MOLD_CD       = 1,
		IxSTY_MOLD_GEN      = 2,
		IxSTY_MOLD_SIZE     = 3,
		IxSTY_HALF_DIV      = 4,
		IxSTY_MSIZE_YN      = 5,
		IxSTY_MUSE_YN       = 6,
		IxSTY_MOLD_CYCLE    = 7,
		IxSTY_MOLD_QTY      = 8,
		IxSTY_PAIRS         = 9,
		IxSTY_AVAIL_ONPRESS = 10,
		IxSTY_DAY_CAPA      = 11,
		IxSTY_ORD_QTY       = 12,
		IxSTY_FST_SIZE      = 13,
		IxSTY_FST_QTY       = 14,
		IxSTY_SPEC_CD       = 15,


		IxGR_DIVISION  = 0,
		IxGR_MODEL_CD  = 1,
		IxGR_STYLE_CD  = 2,
		IxGR_TOTAL     = 3,
		IxGR_STYLE_GEN = 4,
		

	}    


	



	/// <summary> 
	/// SPB_RSC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_RSC : int 
	{ 
		IxMaxCt = 12,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxRSC_TYPE =2,			// 리소스 타입	:VARCHAR2(10) 
		IxRSC_CD =3,			// 리소스 코드	:VARCHAR2(10) 
		IxRSC_NAME =4,			// 리소스명	:VARCHAR2(10) 
		IxSTD_CAPA =5,			// 표준 생산 능력	:NUMBER(22) 
		IxPROD_UNIT =6,			// 생산단위	:VARCHAR2(5) 
		IxPROD_TIME =7,			// 생산시간	:VARCHAR2(9) 
		IxINV_QTY =8,			// 보유수량	:NUMBER(22) 
		IxRSC_UNIT =9,			// 리소스단위	:VARCHAR2(5) 
		IxREMARKS =10,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =11,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =12,			// 작성일자	:DATE(7) 
	}  


	/// <summary> 
	/// SPB_OPCD 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_OPCD_LINE_HEAD : int 
	{ 
		IxMaxCt = 5,		// 인덱스 Count 
		IxOP_CD =1,			// 공정 코드	:VARCHAR2(10) 
		IxAREA_CD =2,			// 표준 작업장 코드	:VARCHAR2(10) 
		IxOP_NAME =3,			// 공정명	:VARCHAR2(50) 
		IxREMARKS =4,			// 비고	:VARCHAR2(100) 
		IxCOUNT =5, 
		IxDIV =6,              // 1: spb_opcd, 2 : spb_opcd_indetail
		IxPARENT_OPCD =7,

	}  


	/// <summary> 
	/// SPB_OPCD 의 LINE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_OPCD_LINE_LINE : int 
	{  		 
		IxLINE_CD =1,		
		IxLINE_NAME =2,		
		IxMAX_CAPA =3,		
		IxSTD_CAPA =4,		
		IxMIN_CAPA =5, 
		IxCOUNT =6,         

	}

	/// <summary> 
	/// SPB_OPCD_LINE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_OPCD_LINE : int 
	{ 
		IxMaxCt = 19,	 
		IxFACTORY =1,	
		IxOP_CD =2,		
		IxMLINE_CD =3,	
		IxMLINE_NAME =4,
		IxLINE_CD =5,	
		IxAREA_CD =6,	
		IxMAT_AREA =7,	 
		IxREAL_YN =8,	
		IxOUT_YN =9,	
		IxMIN_CAPA =10,	
		IxSTD_CAPA =11,	
		IxMAX_CAPA =12,	
		IxPROD_UNIT =13,
		IxPROD_TIME =14,
		IxHORULY_MAX_CAPA=15,
		IxREMARKS =16,	
		IxH_LINE_CD =17,		
		IxUPD_USER =18,	
		IxUPD_YMD =19,	
			 
	}  



	/// <summary> 
	/// SPB_OPCD_LINE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_OPCD_LINE_AREA : int 
	{ 
		IxFACTORY =1,	
		IxOP_CD =2,		
		IxMLINE_CD =3,	
		IxMLINE_NAME =4,
		IxLINE_CD =5,	
		IxAREA_CD =6,	
		IxMAT_AREA =7,	 
		IxREAL_YN =8,	
		IxOUT_YN =9,	
		IxMIN_CAPA =10,	
		IxSTD_CAPA =11,	
		IxMAX_CAPA =12,	
		IxPROD_UNIT =13,
		IxPROD_TIME =14,
		IxRELEASE_AREA_CD =15,
		IxHORULY_MAX_CAPA=16,
		IxREMARKS =17,	
		IxH_LINE_CD =18,		
		IxUPD_USER =19,	
		IxUPD_YMD =20,	
			 
	}  



	/// <summary> 
	/// SPB_OPCD_LINE_RSC 그리드 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_OPCD_LINE_RSC_GRID : int 
	{ 
		IxMaxCt = 18,		  
		IxCODE =1,			 
		IxNAME =2,			 
		IxOP_CD =3, 	
		IxOP_LINE =4, 
		IxRSC_TYPE =5,	
		IxRSC_CD =6, 
		IxRSC_NAME =7,
		IxLEVEL =8,
		IxFACTORY =9,
		IxSTD_CAPA =10,
		IxREAL_CAPA =11,
		IxPROD_UNIT =12,
		IxPROD_TIME =13,
		IxRSC_QTY =14,
		IxTOT_DAY_CAPA =15,
		IxREMARKS =16,			  
		IxUPD_USER =17,			 
		IxUPD_YMD =18,			 
		 
	}  


	/// <summary> 
	/// SPB_OPCD_LINE_RSC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_OPCD_LINE_RSC : int 
	{ 
		IxMaxCt = 14, 	 
		IxOP_CD =0,			 
		IxOP_NAME =1, 	
		IxOP_LINE =2,		
		IxOP_LINE_NAME =3,	
		IxRSC_TYPE =4,	
		IxRSC_CD =5,
		IxRSC_NAME =6,
		IxLEVEL =7,
		IxFACTORY =8,
		IxSTD_CAPA =9,
		IxREAL_CAPA =10,
		IxPROD_UNIT =11,
		IxPROD_TIME =12,
		IxRSC_QTY =13,
		IxTOT_DAY_CAPA =14,
		 
	}  


	/// <summary> 
	/// TBSPB_OPCD_LINE_RSC_GRID에서 Arr_TBSPB_OPCD_LINE_RSC 추출값
	/// </summary> 
	public class Arr_TBSPB_OPCD_LINE_RSC
	{
		public int[] lx= {(int)TBSPB_OPCD_LINE_RSC_GRID.IxFACTORY
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxOP_CD
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxOP_LINE
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxRSC_CD
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxRSC_TYPE
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxRSC_NAME
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxSTD_CAPA
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxREAL_CAPA
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxPROD_UNIT
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxPROD_TIME
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxRSC_QTY
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxTOT_DAY_CAPA
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxREMARKS 
							 ,(int)TBSPB_OPCD_LINE_RSC_GRID.IxUPD_USER} ; 

		public Arr_TBSPB_OPCD_LINE_RSC()
		{
		}
 

	}




	/// <summary> 
	/// SPB_LINEOP_LEADTIME 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_LINEOP_LEADTIME : int 
	{  	    
		IxFACTORY =1,			
		IxLINE_CD =2,			
		IxLEADTIME_CD =3,		 
		IxAPPLY_YMD =4,	
		IxCMP_CD =5,
		IxOP_CD =6,			    
		IxOP_NAME =7,
		IxLEADTIME_DESC =8,		
		IxDEFAULT_YN =9,
		IxSTD_CMP =10,	
		IxSTD_OPCD =11,		
		IxOTU =12,	
		IxH_DAY =13,  				 
		IxLEAD_TIME =14,		
		IxSETUP_TIME =15,		
		IxPROCESS_TIME =16,		
		IxWAITTING_TIME =17,	
		IxOVERLAP_TIME =18,	
		IxREMARKS =19,			
		IxUPD_USER =20,			
		IxUPD_YMD =21,			
		IxEXIST_YN =22,
		IxLEAD_TIME_SV =23, 
		IxSETUP_TIME_SV =24,	
		IxPROCESS_TIME_SV =25,	
		IxWAITTING_TIME_SV =26,	
		IxOVERLAP_TIME_SV =27,	
		IxOP_COLOR =28, 
	}
 

	/// <summary> 
	/// TBSPB_LINEOP_LEADTIME에서 Arr_TBSPB_LINEOP_LEADTIME 추출값
	/// </summary> 
	public class Arr_TBSPB_LINEOP_LEADTIME
	{
		public int[] lx= { (int)TBSPB_LINEOP_LEADTIME.IxAPPLY_YMD
							 ,(int)TBSPB_LINEOP_LEADTIME.IxFACTORY
							 ,(int)TBSPB_LINEOP_LEADTIME.IxLINE_CD
							 ,(int)TBSPB_LINEOP_LEADTIME.IxLEADTIME_CD
							 ,(int)TBSPB_LINEOP_LEADTIME.IxCMP_CD
							 ,(int)TBSPB_LINEOP_LEADTIME.IxOP_CD
							 ,(int)TBSPB_LINEOP_LEADTIME.IxLEADTIME_DESC
							 ,(int)TBSPB_LINEOP_LEADTIME.IxDEFAULT_YN
							 ,(int)TBSPB_LINEOP_LEADTIME.IxSTD_CMP
							 ,(int)TBSPB_LINEOP_LEADTIME.IxSTD_OPCD
							 ,(int)TBSPB_LINEOP_LEADTIME.IxOTU 
							 ,(int)TBSPB_LINEOP_LEADTIME.IxH_DAY
							 ,(int)TBSPB_LINEOP_LEADTIME.IxLEAD_TIME_SV
							 ,(int)TBSPB_LINEOP_LEADTIME.IxSETUP_TIME_SV
							 ,(int)TBSPB_LINEOP_LEADTIME.IxPROCESS_TIME_SV
							 ,(int)TBSPB_LINEOP_LEADTIME.IxWAITTING_TIME_SV
							 ,(int)TBSPB_LINEOP_LEADTIME.IxOVERLAP_TIME_SV
							 ,(int)TBSPB_LINEOP_LEADTIME.IxREMARKS
							 ,(int)TBSPB_LINEOP_LEADTIME.IxUPD_USER } ; 

		public Arr_TBSPB_LINEOP_LEADTIME()
		{
		}
 

	} 






	/// <summary> 
	/// SPO_LOT_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_SIZE : int 
	{ 
		IxMaxCt = 15,		// 인덱스 Count 
		IxFACTORY =1,			// 공장	:VARCHAR2(5) 
		IxLOT_NO =2,			// LOT 번호	:VARCHAR2(9) 
		IxLOT_SEQ =3,			// LOT 순번	:VARCHAR2(2) 
		IxCS_SIZE =4,			// 창신 사이즈	:VARCHAR2(7) 
		IxOBS_TYPE =5,			// OBS 타입	:VARCHAR2(2) 
		IxPO_NO =6,			// PO NO	:VARCHAR2(8) 
		IxMODEL_CD =7,			// 모델 코드	:VARCHAR2(6) 
		IxSTYLE_CD =8,			// 스타일 코드	:VARCHAR2(9) 
		IxGEN =9,			// 젠더	:VARCHAR2(3) 
		IxSIZE_QTY =10,			// 사이즈별 할당 수량	:NUMBER(22) 
		IxLOSS_QTY =11,			// 사이즈별 로스 수량	:NUMBER(22) 
		IxREAL_LOTYN =12,			// 실, 가 LOT 여부	:VARCHAR2(1) 
		IxREMARKS =13,			// 비고	:VARCHAR2(100) 
		IxUPD_USER =14,			// 작성자	:VARCHAR2(10) 
		IxUPD_YMD =15,			// 작성일자	:DATE(7) 
	}  




	/// <summary> 
	/// SPO_LOT_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_CSSIZE : int 
	{  
		IxGEN =0,
		IxCS_SIZE =1, 
	}  





	/// <summary> 
	/// SPO_LOT_SIZE 그리드 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_SIZE_GRID : int 
	{ 
		IxREQ_NO =1,
		IxLOT =2,
		IxMODEL_NAME =3,
		IxSTYLE_CD =4,
		IxOBS_ID =5,
		IxOBS_TYPE =6,
		IxPO_NO =7,
		IxTOT_QTY =8,
		IxSUM_QTY =9,
		IxCS_SIZE_START =10,


		IxDTFACTORY =0,			  
		IxDTREQ_NO =1,			 
		IxDTLOT_NO =2,			
		IxDTLOT_SEQ =3,			
		IxDTOBS_ID =4,
		IxDTOBS_TYPE =5,		 
		IxDTPO_NO =6,			
		IxDTSTYLE_CD =7,		 
		IxDTTOT_QTY =8,			 
		IxDTLOT_QTY =9,			
		IxDTTOT_LOSS_QTY =10,
		IxDTLOT_LOSS_QTY =11,
		
	}  


	/// <summary> 
	/// SPO_LOT_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_REQ_SIZE : int 
	{   
		IxDIV =0,
		IxREQ_NO =1,
		IxLOT =2,
		IxMODEL_NAME =3,
		IxSTYLE_CD =4,
		IxOBS_ID =5,
		IxOBS_TYPE =6,
		IxGEN =7,
		IxCS_SIZE =8,
		IxORD_QTY = 9,
		IxLOSS_QTY =10,

	}  



	/// <summary> 
	/// SPO_LOT_DAYILY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY : int 
	{  
		IxLINE_CD =0,		
		IxLINE_NAME =1, 
		IxLOT =2,		
		IxMODEL_NAME =3,	
		IxSTYLE_CD =4,		
		IxGEN =5,	
		IxOBS_ID =6,
		IxOBS_TYPE =7,
		IxRGAC =8,
		IxOGAC =9,	
		IxLOT_QTY =10,
		IxLOSS_QTY =11,
		IxSUM_QTY =12,
		IxPO_NO =13, 
		IxTOT_DAY_SEQ =14, 
		IxLOT_PLANYN =15,
		IxDAY_SEQ =16,
		IxPLAN_YMD =17,
		IxDAILY_SIZEQTY =18,
		IxDAILY_PLANSTATUS =19,
		IxDAILY_SIZEYN =20,
		IxFLAG =21, 
		IxREAL_LOTYN =22,
		IxDAILY_FNISH_YN =23,
	 
	}  



	/// <summary> 
	/// SPO_LOT_DAYILY 간트차트 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_vcGANTT : int 
	{ 
		IxID =0,
		IxLINE_CD =1,		
		IxLINE_NAME =2, 
		IxLOT =3,		
		IxMODEL_NAME =4,	
		IxSTYLE_CD =5,		
		IxGEN =6,	
		IxOBS_ID =7,
		IxOBS_TYPE =8,
		IxRGAC =9,
		IxVIEW_RGAC =10,
		IxOGAC =11,	
		IxLOT_QTY =12,
		IxLOSS_QTY =13,
		IxSUM_QTY =14,
		IxPO_NO =15, 
		IxTOT_DAY_SEQ =16, 
		IxLOT_PLANYN =17,
		IxDAY_SEQ =18, 
		IxPLAN_YMD_S =19,	 			 
		IxPLAN_YMD_E =20,			 
		IxDURATION =21,	
		IxDAILY_SIZEQTY =22,
		IxDAILY_PLANSTATUS =23,
		IxDAILY_SIZEYN =24,
		IxFLAG =25, 
		IxREAL_LOTYN =26,
		IxCHECK_DIV =27, 
		IxDAILY_FNISH_YN =28,
		IxLINE_MANAGER = 29,
		IxMSR_YN =30,
		IxVIEW_OGAC = 31,
	
	}  




	/// <summary> 
	/// SPO_LOT_DAYILY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_1 : int 
	{  
		IxLINE_CD =0,		
		IxLINE_NAME =1, 
		IxLOT =2, 
		IxDAY_SEQ =3,
		IxPLAN_YMD =4,
		IxDAILY_SIZEQTY =5,
		IxDAILY_PLANSTATUS =6,
		IxDAILY_SIZEYN =7,
		IxFLAG =8, 
		IxREAL_LOTYN =9,
		IxDAILY_FNISH_YN =10,
		IxLINE_MANAGER =11,
	 
	}  


	/// <summary> 
	/// SPO_LOT_DAYILY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_2 : int 
	{  
		IxLINE_CD =0,		
		IxLINE_NAME =1, 
		IxLOT =2,		
		IxMODEL_NAME =3,	
		IxSTYLE_CD =4,		
		IxGEN =5,	
		IxOBS_ID =6,
		IxOBS_TYPE =7,
		IxRGAC =8,
		IxOGAC =9,	
		IxLOT_QTY =10,
		IxLOSS_QTY =11,
		IxSUM_QTY =12,
		IxPO_NO =13, 
		IxTOT_DAY_SEQ =14, 
		IxLOT_PLANYN =15, 

	}  

 

	/// <summary> 
	/// SPO_LOT_DAYILY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_HEAD : int 
	{  
		IxLINE_CD =0,		
		IxLINE_NAME =1, 
		IxLOT =2, 
		IxDAY_SEQ =3,
		IxPLAN_YMD =4,
		IxDAILY_SIZEQTY =5,
		IxDAILY_PLANSTATUS =6,
		IxDAILY_SIZEYN =7,
		IxFLAG =8, 
		IxREAL_LOTYN =9,
		IxDAILY_FNISH_YN =10,
		IxLINE_MANAGER =11,
	 
	}  


	/// <summary> 
	/// SPO_LOT_DAYILY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_DETAIL : int 
	{  
		IxLINE_CD =0,		
		IxLINE_NAME =1, 
		IxLOT =2,		
		IxMODEL_NAME =3,	
		IxSTYLE_CD =4,		
		IxGEN =5,	
		IxOBS_ID =6,
		IxOBS_TYPE =7,
		IxRGAC =8,
		IxOGAC =9,	
		IxLOT_QTY =10,
		IxLOSS_QTY =11,
		IxSUM_QTY =12,
		IxPO_NO =13, 
		IxTOT_DAY_SEQ =14, 
		IxLOT_PLANYN =15,
		IxMSR_YN = 16,
	}  




	/// <summary> 
	/// SPO_LOT_DAYILY_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAYILY_SIZE_HEAD : int 
	{  
		IxMaxCt = 14,		 
		IxFACTORY =1,			 
		IxLINE_CD =2,			 
		IxLOT =3,	
		IxREQ_NO =4,    
		IxPO_NO =5,			    
		IxOBS_TYPE =6,			
		IxSTYLE_CD =7,			
		IxSTYLE_NAME =8,		
		IxTOT_DAY_SEQ =9,		
		IxPLN_STRYMD =10,		 
		IxLOT_QTY =11,			
		IxTOT_LOSS_QTY =12,		 
		IxREAL_LOTYN =13,		
		IxGEN =14,		 
		IxCS_SIZE_START =15,
  

	}  


	/// <summary> 
	/// SPO_LOT_DAYILY_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAYILY_SIZE_HEAD_TABLE : int 
	{   		 
		IxFACTORY =0,			 
		IxLINE_CD =1,			 
		IxLOT =2,
		IxREQ_NO =3,    	    
		IxPO_NO =4,			    
		IxOBS_TYPE =5,			
		IxSTYLE_CD =6,			
		IxSTYLE_NAME =7,		
		IxTOT_DAY_SEQ =8,		
		IxPLN_STRYMD =9,		 
		IxLOT_QTY =10,			
		IxTOT_LOSS_QTY =11,		 
		IxREAL_LOTYN =12,		
		IxGEN =13,		 
		IxCS_SIZE =14,
		IxSIZE_QTY =15,
		IxLOSS_QTY =16, 
  

	}  


	/// <summary> 
	/// SPO_LOT_DAYILY_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAYILY_SIZE : int 
	{   		  	 
		IxPLAN_STATUS =1,
		IxDAY_SEQ =2,  
		IxTOTAL =3,
		IxSUM =4,
		IxCS_SIZE_START =5,
  

	}  

  
	/// <summary> 
	/// SPO_LOT_DAYILY_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAYILY_SIZE_TABLE : int 
	{    
		IxPLAN_STATUS =0,
		IxDAY_SEQ =1, 
		IxTOT_ALO_QTY =2,
	    IxTOT_LOSS_QTY =3,
		IxCS_SIZE =4,			
		IxSIZE_QTY =5,			
		IxLOSS_QTY =6, 
  

	}  


	/// <summary> 
	/// SPO_LOT_PROPERTY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_PROPERTY : int 
	{ 
		IxMaxCt           =20,		// 인덱스 Count 

		IxFACTORY         =0,			// 공장	:VARCHAR2(5) 
		IxDAY_SEQ_DIV     =1,			// DAY SEQ 산정 방법	:VARCHAR2(1) 
		IxDAY_STD_CAPA    =2,			// 라인 Capacity	:NUMBER(22)
		IxCAPA_DIV        =3,			// 라인 Capacity	:NUMBER(22) 
		IxALO_RATE_YN     =4,
		IxMULTILINE_DIV   =5,			// 한 LOT에 대한 라인 분할 방법	:VARCHAR2(1) 


		IxSPLIT_LIMITQTY  =6,			// 라인의 분할 한계 수량	:NUMBER(22) 
		IxPAST_LINE_YN    =7,			// 라인의 분할 한계 수량	:NUMBER(22) 
		IxLINE_ASSIGN_DIV =8,			// 수량 배치 방법 - 선행 배치된 수량이 있을경우	:VARCHAR2(1) 
		IxEND_DAY_SEQ_DIV =9,			// 마지막 DAY_SEQ 가 LINE MAX_CAPA를 초과하지 않는 경우	:VARCHAR2(1) 
		IxLAST_LIMITQTY   =10,			// NEW MODEL 적용 여부	:VARCHAR2(1) 


		IxNEW_MODEL_YN    =11,			// NEW MODEL 적용 여부	:VARCHAR2(1) 
		IxINIT_RATE       =12,			// 초기 라인 배당 비율	:NUMBER(22) 
		IxINC_RATE        =13,			// LINE CAPACITY 구분 (MAX, STANDARD, MIN)	:VARCHAR2(1) 
		IxASSIGN_WAY      =14,			// 배치 일자 적용 기준	:VARCHAR2(1)
		IxASSIGN_ITEM     =15,			// 배치 일자 적용 기준	:VARCHAR2(1) 

		IxASSIGN_MARGIN   =16,			// 배치 일자 적용 기준 여유치	:NUMBER(22) 
		IxWORKCAL         =17,			// 월력 적용 기준  - 라인에 대한 대표공정 선택	:VARCHAR2(10) 
		IxBEEN_SIZE       =18,			// 월력 적용 기준  - 라인에 대한 대표공정 선택	:VARCHAR2(10) 
		IxSEQ_LOT_SIZE    =19,			// 월력 적용 기준  - 라인에 대한 대표공정 선택	:VARCHAR2(10) 

		IxOP_CD			  =20,          // 공정 코드
		IxFROM_DATE	      =21,          // 시작 날짜
		IxTO_DATE	      =22,          // 끝   날짜

		IxSHIFT_TYPE	  =23,
		IxASSIGN_SIZE	  =24,
		IxHOW_ASSIGN_SIZE =25,
		IxFIRST_INNER_QTY =26,
	}  



	/// <summary> 
	/// SPO_TMP_LOT_MOLD 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPO_TMP_LOT_MOLD : int 
	{    
		//DB기준
		IxFACTORY  = 0,
		IxPLAN_YMD = 1,
		IxMOLDE_CD = 2,
		IxSTYLE_CD = 3,
		IxGEN      = 4,
		IxCS_SIZE  = 5, 
		IxSIZE_QTY = 6,


		//GRID기준
		IxGR_PLAN_YMD  = 1,
		IxGR_MODEL_CD  = 2,
		IxGR_STYLE_CD  = 3,
		IxGR_GEN	   = 4,
	} 


	/// <summary> 
	/// SPO_TMP_LOT_MOLD_INFO 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPO_TMP_LOT_MOLD_INFO : int 
	{    
		//DB기준
		IxFACTORY   = 0,
		IxPLAN_YMD  = 1,
		IxMUSE_YN   = 2,
		IxMOLD_NAME = 3,
		IxMOLD_TYPE = 4, 

		IxMOLD_CD   = 5,
		IxCS_SIZE   = 6,
		IxSUM_QTY   = 7,
		IxPAIRS     = 8,
		IxAVAIL_PAIRS = 9,

		IxCYCLE     = 10,
		IxDAY_CAPA  = 11,
		IxMOLD_GEN  = 12,
		IxFST_SIZE  = 13,
		IxSTYLE_QTY = 14,

		IxREQUEST   = 15,
		IxNECK_CAPA = 16,
		IxREQ_MOLD  = 17,




		//GRID기준
		IxGR_DIVISION  = 0,
		IxGR_PLAN_YMD  = 1,
		IxGR_MODEL_CD  = 2,
		IxGR_STYLE_CD  = 3,
		IxGR_GEN	   = 4,
	}




	/// <summary> 
	/// TBSPO_PO_LOT 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPO_PO_LOT : int 
	{
		//DB기준
		IxDB_FACTORY         =  0,
		IxDB_LOT_NO          =  1,
		IxDB_LOT_SEQ         =  2,
		IxDB_LOT             =  3,
		IxDB_MODEL           =  4,
		IxDB_MODEL_CD        =  5,
		IxDB_STYLE_CD        =  6,
		IxDB_GEN             =  7,

		IxDB_OBS_ID          =  8,
		IxDB_OBS_TYPE        =  9,
		IxDB_LOT_QTY         = 10,
		IxDB_REAL_LOTYN      = 11,
		IxDB_LOSS_QTY        = 12,

		IxDB_TOT_DAY_SEQ     = 13,
		IxDB_RTS_YMD         = 14,
		IxDB_PLN_STRYMD      = 15,
		IxDB_PLN_ENDYMD      = 16,
		IxDB_PLN_STATUS      = 17,

		IxDB_PLN_STATUSYMD   = 18,
		IxDB_PO_NO           = 19,
		IxDB_LINE_CD         = 20,
		IxDB_HOLD_YN         = 21,
		IxDB_DAY_SEQ_DIV     = 22,

		IxDB_DAY_STD_CAPA    = 23,
		IxDB_CAPA_DIV        = 24,
		IxDB_ARO_RATE	     = 25,
		IxDB_MULTILINE_DIV   = 26,
		IxDB_SPLIT_LIMITQTY  = 27,

		IxDB_LINE_TYPE_DIV   = 28,
		IxDB_PAST_LINE_YN    = 29,
		IxDB_LINE_ASSIGN_DIV = 30,
		IxDB_END_DAY_SEQ_DIV = 31,
		IxDB_LAST_LIMITQTY   = 32,

		IxDB_NEW_MOLDE_YN    = 33,
		IxDB_INIT_RATE       = 34,
		IxDB_INC_RATE        = 35,
		IxDB_ASSIGN_WAY      = 36,
		IxDB_ASSIGN_ITEM     = 37,

		IxDB_ASSIGN_MARGIN   = 38,
		IxDB_ASSIGN_PRIO     = 39,
		IxDB_CAL_TYPE        = 40,
		IxDB_SHIFT_TYPE      = 41,
		IxDB_BEAN_SIZE       = 42,

		IxDB_SEQ_LOT_SIZE    = 43,
		IxDB_REMARKS         = 44,
		IxDB_UPD_USER        = 45,
		IxDB_UPD_YMD         = 46,



		//GR기준
		IxGR_DIVISION  =  0,

		IxGR_FACTORY   =  1,
		IxGR_LOT_NO    =  2,
		IxGR_LOT_SEQ   =  3,
		IxGR_LOT       =  4,
		IxGR_MODEL     =  5,
		IxGR_MODEL_CD  =  6,
		IxGR_STYLE_CD  =  7,
		IxGR_GEN       =  8,

		IxGR_OBS_ID       = 9,
		IxGR_OBS_TYPE     = 10,
		IxGR_LOT_QTY      = 11,
		IxGR_REAL_LOTYN   = 12,
		IxGR_TOT_LOSS_QTY = 13,

		IxGR_TOT_DAY_SEQ = 14,
		IxGR_RTS_YMD     = 15,
		IxGR_PLN_STRYMD  = 16,
		IxGR_PLN_ENDYMD  = 17,
		IxGR_PLN_STATUS  = 18,
		
		IxGR_PLN_STATUSYMD = 19,
		IxGR_PO_NO         = 20,
		IxGR_LINE_CD       = 21,
		IxGR_HOLD_YN       = 22,
		IxGR_DAY_SEQ_DIV   = 23,
		
		IxGR_DAY_STD_CAPA   = 24,
		IxGR_CAPA_DIV       = 25,
		IxGR_RATE			= 26,
		IxGR_MULTILINE_DIV  = 27,
		IxGR_SPLIT_LIMITQTY = 28,

		IxGR_LINE_TYPE_DIV   = 29,
		IxGR_PAST_LINE_YN    = 30,
		IxGR_LINE_ASSIGN_DIV = 31,
		IxGR_END_DAY_SEQ_DIV = 32,
		IxGR_LAST_LIMITQTY   = 33,


		IxGR_NEW_MOLDE_YN    = 34,
		IxGR_INIT_RATE       = 35,
		IxGR_INC_RATE        = 36,
		IxGR_ASSIGN_WAY      = 37,
		IxGR_ASSIGN_ITEM     = 38,


		IxGR_ASSIGN_MARGIN   = 39,
		IxGR_ASSIGN_PRIO     = 40,
		IxGR_CAL_TYPE        = 41,
		IxGR_SHIFT_TYPE      = 42,
		IxGR_BEAN_SIZE       = 43,

		IxGR_SEQ_LOT_SIZE    = 44,
		IxGR_REMARKS         = 45,
		IxGR_UPD_USER        = 46,
		IxGR_UPD_YMD         = 47,
	}
 

	/// <summary> 
	/// TBSPB_MOLD 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPB_MOLD : int 
	{    
		//GRID기준
		IxGR_DIVISION    = 0,

		IxGR_FACTORY     = 1,
		IxGR_MOLD_CD     = 2,
		IxGR_SPEC_CD     = 3,
		IxGR_MOLD_STATUS = 4,
		IxGR_STATUS_CD   = 5,
		IxGR_MOLD_TYPE   = 6,
		IxGR_HALF        = 7,
		IxGR_MSIZE_YN    = 8,
		IxGR_MUSE_YN     = 9,
		IxGR_SUM_QTY     = 10,
		IxGR_GEN         = 11,
		IxGR_CS_SIZE     = 12,
		



		//DB기준
		IxDB_FACTORY     = 0,
		IxDB_MOLD_CD     = 1,
		IxDB_SPEC_CD     = 2,
		IxDB_MOLD_STATUS = 3,
		IxDB_MTYPE       = 4,
		IxDB_MOLD_TYPE   = 5,
		IxDB_HALF        = 6,
		IxDB_MSIZE_YN    = 7,
		IxDB_MUSE_YN     = 8,
		IxDB_SUM_QTY     = 9,
		IxDB_GEN         = 10,
		IxDB_CS_SIZE     = 11,
		IxDB_HALF_II     = 12,
		IxDB_SYSTEM_YN   = 13,
	} 


	


	/// <summary> 
	/// SPB_MOLD_STATUS 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_MOLD_STATUS : int 
	{ 
		IxMaxCt = 7,
		IxDIVISION   = 0,    
		IxFACTORY    = 1,
		IxCOM_VALUE2 = 2,
		IxCOM_SEQ    = 3,
		IxSYSDATE    = 4,
		IxCOM_VALUE1 = 5,
		IxCOM_DESC1  = 6,
		IxREMARKS    = 7,
		IxTEMP       = 8,


		IxDBFACTORY    = 0,
		IxDBCOM_VALUE2 = 1,
		IxDBCOM_SEQ    = 2,
		IxDBCOM_SYSDATE= 3,
		IxDBCOM_VALUE1 = 4,
		IxDBCOM_DESC1  = 5,
		IxDBREMARKS    = 6,
	} 




	/// <summary> 
	/// SPO_LOT_STYLE_MOLD 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPO_LOT_STYLE_MOLD : int 
	{    
		//DB기준
		IxMODEL_CD  = 0,
		IxSTYLE_CD  = 1,
		IxSTYLE_GEN = 2,
		IxCS_SIZE   = 3,
		IxMOLD_CAPA = 4,



		IxMOLD_TYPE = 0,
		IxMOLD_CD   = 1,
		IxMOLD_GEN  = 2,
		IxMOLD_SIZE = 3,
		IxNECK_YN   = 4,
		IxMMOLD_CAPA= 5,



		


		//GRID기준
		IxGR_MODEL_CD  = 2,
		IxGR_STYLE_CD  = 3,
		IxGR_GEN	   = 4,

	} 




	/// <summary> 
	/// SPO_LOT_SIZE OA 그리드 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_SIZE_OA_GRID: int 
	{  
		IxDIV =1,
		IxOA_FLAG =2,
		IxLOT =3,
		IxREQ_NO =4,
		IxCHECK_FLAG =5,
		IxOA_NU =6, 	
		IxTOT_QTY =7, 
		IxOLD_REQ_NO =8, 
		IxGEN =9,
		IxCS_SIZE_START =10,
  
	}  



	/// <summary> 
	/// SPO_LOT_SIZE OA 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_SIZE_OA: int 
	{  
		IxDIV =0,
		IxOA_FLAG =1,
		IxLOT =2,
		IxREQ_NO =3,
		IxCHECK_FLAG =4,
		IxOA_NU =5,	
		IxCS_SIZE =6,  
		IxSIZE_QTY =7,  
		IxOLD_REQ_NO =8,
  
	} 
 

	/// <summary> 
	/// SPO_LOT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DETAIL_MPS : int 
	{ 
		IxFACTORY =0,		
		IxLOT =1,			
		IxOBS_TYPE =2,		
		IxPO_NO =3,			
		IxMODEL_CD =4,		
		IxSTYLE_CD =5,		
		IxSTYLE_NAME =6,
		IxGEN =7,			
		IxBOM_CD =8,
		IxLOT_QTY =9,		
		IxTOT_LOSS_QTY =10,	
		IxREAL_LOTYN =11,		
		IxHOLD_YN =12,			
		IxPLAN_OAAPP_DIV =13,
		IxLINE_CD =14,			
		IxRTS_YMD =15,			
		IxTOT_DAY_SEQ =16,		
		IxPLN_STRYMD =17,		
		IxPLN_ENDYMD =18,		
		IxPLN_STATUS =19,		
		IxPLN_STATUSYMD =20,	
		IxLEADTIME_CD =21,		
		IxAPPLY_YMD =22,	
		IxROUT_TYPE =23,
		IxOBS_ID = 24,
	}  


	/// <summary> 
	/// SPO_LOT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DETAIL_MPS_ACTION : int 
	{  
	
		IxCHECK_FLAG	=1,			
		IxFACTORY		=2,		
		IxMODEL_NAME	=3,		
		IxSTYLE_CD		=4,		
		IxGEN			=5,
		IxOBS_ID		=6,			
		IxOBS_TYPE		=7, 
		IxREQ_NO		=8,	
		IxOBS_NU		=9,
		IxOBS_SEQ_NU	=10,
		IxDEST			=11,		
		IxRGAC			=12,	
		IxOGAC			=13,		
		IxMSR_YN		=14,			
		IxTOT_QTY		=15,
		IxRELEASE_FLAG  =16,

	}  

 
	
	
	

	/// <summary> 
	/// SPO_LOT_reqno list 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_MOVE : int 
	{ 
		IxCHECK_FIELD =1,		
		IxREQ_NO =2,			 
	}  

 

	/// <summary> 
	/// SPO_LOT_SIZE OA Refresh 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_SIZE_OA_REFRESH: int 
	{  
		IxCS_SIZE =0,  
		IxSIZE_QTY =1, 
		IxLOSS_QTY =2, 
  
	} 




	/// <summary> 
	/// SPO_RECV OA 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_RECV_OA : int 
	{ 
		IxOA_NU =1,			// OA NUMBER	:VARCHAR2(15) 
		IxOA_OBS_DIV =2,			// OA DPO (실/가/실==>가)	:VARCHAR2(15) 
		IxOA_DIV =3,			// OA 종류	:VARCHAR2(1) 
		IxOA_YMD =4,			// OA 일자	:VARCHAR2(8) 
		IxOA_CFM =5,			// OA 확정유무	:VARCHAR2(1) 
		IxOA_FLAG =6,			// OA FLAG(I/U/D)	:VARCHAR2(1)
		IxREQ_NO =7,			// 생산의뢰 순번	:VARCHAR2(10) 
		IxOBS_NU =8,			// OBS 번호	:VARCHAR2(10) 
		IxOBS_SEQ_NU =9,			// OBS순번	:VARCHAR2(10) 
		IxCHG_NU =10,			// OBS변경순번	:VARCHAR2(5) 
		IxOBS_DIV =11,			// GPO/DPO 구분	:VARCHAR2(1) 
		IxOBS_ID =12,			// OBS ID	:VARCHAR2(6) 
		IxOBS_TYPE =13,			// OBS 타입	:VARCHAR2(2) 
		IxSTYLE_CD =14,			// 스타일 코드	:VARCHAR2(9) 
		IxGEN =15,			// 성별	:VARCHAR2(2) 
		IxDEST_PRITY =16,			// 행선지 우선순위	:VARCHAR2(3) 
		IxDEST =17,			// 행선지	:VARCHAR2(7) 
		IxTOT_QTY =18,			// 총오더수량	:NUMBER(22) 
		IxRTS_YMD =19,			// RTS DATE/OGAC_DATE : 나이키 지정 선적일	:VARCHAR2(8) 
		IxCSETS_YMD =20,			// CSETS_DATE/GAC_DATE : 공장단 선적 예정일	:VARCHAR2(8) 
		IxCSETS_RSN =21,			// GAC REASON : ETC 사유	:VARCHAR2(30) 

	}  
 


	/// <summary> 
	/// SPO_LOT_DAILY_MINI 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_MINI_OPOUT : int 
	{  
		IxFACTORY =1,		
		IxLINE_CD =2,		
		IxLOT =3,			
		IxDAY_SEQ =4,		
		IxREQ_NO =5,		
		IxOP_CD =6,	
		IxMLINE_CD =7,
		IxTOT_QTY =8,
		IxOUT_YN =9,
		IxOUT_QTY =10,		
		IxOUT_MLINE_CD =11,
		IxSIZE_QTY =12,		
		IxLOSS_QTY =13,
		IxSTYLE_CD =14,
		IxGEN =15,
		IxPLAN_YMD =16,
		IxOP_COLOR =17,
	}  



	/// <summary> 
	/// SPO_LOT_DAILY_MINI_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_MINI_SIZE_OPOUT : int 
	{   	
		IxOUT_YN =1,		
		IxCS_SIZE =2,			
		IxSIZE_QTY =3,		
		IxLOSS_QTY =4,
		IxENABLE_YN =5,
 	     
	}  



	/// <summary> 
	/// TBSPO_LOT_DAILY_OUT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_DAILY_OUT : int 
	{ 	 	
		IxTBLOT =0,
		IxTBSTYLE_CD =1, 
		IxTBGEN =2,
		IxTBDAY_SEQ =3, 
		IxTBREQ_NO =4,
		IxTBMLINE_CD =5, 
		IxTBOUT_MLINE_CD =6, 
		IxTBCS_SIZE =7,
		IxTBOUT_QTY =8, 
		//IxTBSUM_OUT_QTY =9, 


		IxLOT =1,  
		IxSTYLE_CD =2,
		IxDAY_SEQ =3, 
		IxREQ_NO =4, 
		IxMLINE_CD =5, 
		IxOUT_MLINE_CD =6, 
		IxTOT_QTY =7,
		IxGEN =8,  
		IxCS_SIZE_START =9,
	}  





	/// <summary> 
	/// SPB_LINEOP_MINI 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_LOT_DAILY_MINI_SIZE : int 
	{ 	 	
		IxTBLOT =0,
		IxTBREQ_NO =1,
		IxTBSTYLE_CD =2,
		IxTBGEN =3,
		IxTBDAY_SEQ =4, 
		IxTBCS_SIZE =5,
		IxTBSIZE_QTY =6,
		IxTBLOSS_QTY =7,
		IxTBNG_QTY =8,
		IxTBSUM_SIZE =9,
		IxTBSUM_LOSS =10,
		IxTBSUM_NG =11,


		IxLOT =1, 
		IxREQ_NO =2, 
		IxSTYLE_CD =3,
		IxDAY_SEQ =4, 
		IxTOT_QTY =5,
		IxGEN =6,  
		IxCS_SIZE_START =7,
	}  

	/// <summary> 
	/// TBSPD_LOT_DAILY_OP_LEADTIME 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_LOT_DAILY_OP_LEADTIME : int 
	{  
		IxTBDAY_SEQ =0,
		IxTBOP_CD =1,
		IxTBSUM_SIZE =2,
		IxTBROUT_SEQ =3,
		IxTBCMP_CD =4,
		IxTBCMP_LEVEL =5,
		IxTBOP_STR_YMD =6,
		IxTBOP_END_YMD =7,
		IxTBOP_COLOR =8,
		IxTBPLAN_STATUS =9,

		IxTBYMD_THEDAY =0,
		IxTBYMD_WEEKDAY =1,
		IxTBYMD_HOLI_YN =2,

		IxCMP_CD =1,
		IxOP_CD =2,
		IxROUT_SEQ =3,
		IxOP_COLOR =4,
		IxCMP_LEVEL =5,
		IxYMD_START =6,
	} 
 

	/// <summary> 
	/// SPO_LOT_DAILY_MINI_SIZE 테이블 인덱스 Enum (TimeSeq 용)
	/// </summary> 
	public enum TBSPD_LOT_DAILY_MINI_SIZE_TS : int 
	{   
		IxTBH_SAVE_FLAG = 0,
		IxTBH_TS_FINISH_YN =1,
		IxTBH_LOT =2,
		IxTBH_MODEL_NAME =3,
		IxTBH_STYLE_CD =4,
		IxTBH_OBS_ID =5,
		IxTBH_OBS_TYPE =6,
		IxTBH_DAY_SEQ =7, 
		IxTBH_MLINE_CD =8,
		IxTBH_MLINE_NAME =9,
		IxTBH_INPUT_PRIO =10,

		IxTBD_SAVE_FLAG = 0,
		IxTBD_TS_FINISH_YN =1,
		IxTBD_LOT =2,
		IxTBD_MLINE_CD =3,
		IxTBD_MLINE_NAME =4,
		IxTBD_INPUT_PRIO =5,
		IxTBD_MODEL_NAME =6,
		IxTBD_STYLE_CD =7,
		IxTBD_OBS_ID =8,
		IxTBD_OBS_TYPE =9,
		IxTBD_DAY_SEQ =10,
		
		IxTBTOT_QTY =11,
		IxTBGEN =12,
		IxTBCS_SIZE =13,
		IxTBSIZE_QTY =14,


		IxH_SAVE_FLAG = 1,
		IxH_TS_FINISH_YN =2,
		IxH_LOT =3,
		IxH_MODEL_NAME =4,
		IxH_STYLE_CD =5,
		IxH_OBS_ID =6,
		IxH_OBS_TYPE =7,
		IxH_DAY_SEQ =8,
		IxH_MLINE_CD =9,
		IxH_MLINE_NAME =10,
		IxH_INPUT_PRIO =11, 

		IxD_SAVE_FLAG = 1,
		IxD_TS_FINISH_YN =2,
		IxD_LOT =3,
		IxD_MLINE_CD =4,
		IxD_MLINE_NAME =5,
		IxD_INPUT_PRIO =6,
		IxD_MODEL_NAME =7,
		IxD_STYLE_CD =8,
		IxD_OBS_ID =9,
		IxD_OBS_TYPE =10,
		IxD_DAY_SEQ =11, 

		IxTOT_QTY =12, 
		IxGEN =13, 
		IxCS_SIZE_START =14,
	}  


	/// <summary> 
	/// SPO_LOT_DAILY_MINI_SIZE 테이블 인덱스 Enum (TimeSeq 출력용)
	/// </summary> 
	public enum TBSPD_LOT_DMINI_SIZE_TS_SEARCH : int 
	{   
		IxTBLINE_CD = 0,
		IxTBLINE_NAME =1,
		IxTBMLINE_CD =2,
		IxTBMLINE_NAME =3,
		IxTBLOT =4,
		IxTBMODEL_NAME =5,
		IxTBPO_NO =6,
		IxTBSTYLE_CD =7,
		IxTBOBS_ID =8,
		IxTBOBS_TYPE =9,
		IxTBDAY_SEQ =10, 
		IxTBINPUT_PRIO =11,
		IxTBTOT_QTY =12,
		IxTBGEN =13,
		IxTBCS_SIZE =14,
		IxTBINPUT_QTY =15,
 

		IxLINE_CD = 1,
		IxLINE_NAME =2,
		IxMLINE_CD =3,
		IxMLINE_NAME =4,
		IxLOT =5,
		IxMODEL_NAME =6,
		IxPO_NO =7,
		IxSTYLE_CD =8,
		IxOBS_ID =9,
		IxOBS_TYPE =10,
		IxDAY_SEQ =11, 
		IxINPUT_PRIO =12,
		IxTOT_QTY =13,
		IxGEN =14,
		IxCS_SIZE_START =15,

 
	}  

 
	/// <summary> 
	/// SPO_LOT_DAILY_MINI_SIZE 테이블 인덱스 Enum (메인라인별 input prio 데이터 조회 )
	/// </summary> 
	public enum TBSPD_LOT_DMINI_SIZE_TS_CHECK : int 
	{   
		IxTBLINE_CD = 0,
		IxTBLINE_NAME =1, 
		IxTBINPUT_PRIO =2,
		IxTBLOT =3,
		IxTBMODEL_NAME =4,
		IxTBPO_NO =5,
		IxTBSTYLE_CD =6,
		IxTBOBS_ID =7,
		IxTBOBS_TYPE =8,
		IxTBDAY_SEQ =9,  
		IxTBTOT_QTY =10,
		IxTBGEN =11,
		IxTBCS_SIZE =12,
		IxTBINPUT_QTY =13,
 

		IxLINE_CD = 1,
		IxLINE_NAME =2, 
		IxINPUT_PRIO =3,
		IxLOT =4,
		IxMODEL_NAME =5,
		IxPO_NO =6,
		IxSTYLE_CD =7,
		IxOBS_ID =8,
		IxOBS_TYPE =9,
		IxDAY_SEQ =10, 
		IxTOT_QTY =11,
		IxGEN =12,
		IxCS_SIZE_START =13,

 
	}  



	/// <summary> 
	/// TBSPO_SHORTAGE_MOLD 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPO_SHORTAGE_MOLD : int 
	{    
		//DB기준
		IxFACTORY   = 0,
		IxPLAN_YMD  = 1,
		IxLINE_CD   = 2,
		IxMOLD_TYPE = 3, 
		IxMOLD_CD   = 4,
		IxMOLD_GEN  = 5,
		IxCS_SIZE   = 6,
		IxREQ_CAPA  = 7,
		IxREQ_MOLD  = 8,


		IxSTY_FACTORY  = 0,
		IxSTY_PLAN_YMD = 1,
		IxSTY_LINE_CD  = 2,
		IxSTY_STYLE_CD = 3,
		IxSTY_GEN      = 4,
		IxSTY_CS_SIZE  = 5,
		IxSTY_SIZE_QTY = 6,



		//GRID기준
		IxGR_DIVISION  = 0,
		IxGR_PLAN_YMD  = 1,
		IxGR_LINE_CD  = 2,
		IxGR_MOLD_TYPE = 3,
		IxGR_MOLD_CD   = 4,
		IxGR_MOLD_GEN  = 5,
	}


	
 
	/// <summary> 
	/// SPD_DAILY_WORKSHEET 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPD_DAILY_WORKSHEET_SEARCH : int 
	{  
		IxTBLINE_CD =0,
		IxTBDIV =1,
		IxTBLINE_NAME =2,
		IxTBOP_CD = 3,
		IxTBLOT =4,  
		IxTBOBS_TYPE =5,
		IxTBMODEL_CD =6,
		IxTBPO_NO =7,
		IxTBSTYLE_CD =8, 
		IxTBRTS_YMD =9,
		IxTBOGAC =10,  
		IxTBDIV_DESC =11,
		IxTBCMP_CD =12,
		IxTBPLAN_YMD =13,
		IxTBDAY_SEQ =14,
		IxTBGEN =15,  
		IxTBCS_SIZE =16,
		IxTBDIR_QTY =17,  
		IxTBMAT_AREA =18,


		IxLINE_CD =1,
		IxDIV =2,
		IxLINE_NAME =3,
		IxMAT_AREA =4,
		IxOP_CD =5,
		IxLOT =6,   
		IxMODEL_CD =7, 
		IxPO_NO =8,
		IxSTYLE_CD =9, 
		IxRTS_YMD =10,
		IxOGAC =11, 
		IxCMP_CD =12,
		IxDIV_DESC =13,
		IxPLAN_YMD =14,
		IxTOTAL_QTY =15,
		IxGEN =16,  
		IxCS_SIZE_START =17, 
 
 
	} 

	/// <summary> 
	/// SPD_DAILY_WORKSHEET_TS 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPD_DAILY_WORKSHEET_TS_SEARCH : int 
	{  
		IxTBLINE_CD =0,
		IxTBMLINE_CD =1,
		IxTBDIV =2,
		IxTBLINE_NAME =3,
		IxTBOP_CD =4,
		IxTBMLINE_NAME =5,
		IxTBLOT =6,  
		IxTBOBS_TYPE =7,
		IxTBMODEL_CD =8,
		IxTBPO_NO =9,
		IxTBSTYLE_CD =10,
		IxTBRTS_YMD =11,
		IxTBOGAC =12,
		IxTBDIV_DESC =13,
		IxTBCMP_CD =14,
		IxTBPLAN_YMD =15,
		IxTBDAY_SEQ =16,
		IxTBINPUT_PRIO =17, 
		IxTBST_PLAN_YMD =18,
		IxTBST_PLAN_STR_TIME =19,
		IxTBST_PLAN_END_TIME =20,
		IxTBST_STR_YMD =21,
		IxTBST_STR_TIME =22,
		IxTBST_END_YMD =23,
		IxTBST_END_TIME =24,
		IxTBGEN =25,  
		IxTBCS_SIZE =26,
		IxTBDIR_QTY =27, 
		IxTBMAT_AREA =28,
 

		IxLINE_CD =1,
		IxMLINE_CD =2,
		IxDIV =3,
		IxLINE_NAME =4,
		IxMAT_AREA =5,
		IxOP_CD =6,
		IxMLINE_NAME =7,
		IxLOT =8,  
		IxMODEL_CD =9,
		IxPO_NO =10,
		IxSTYLE_CD =11,
		IxRTS_YMD =12,
		IxOGAC =13,
		IxCMP_CD =14,
		IxDIV_DESC =15,
		IxPLAN_YMD =16,
		IxINPUT_PRIO =17,
		IxST_PLAN_YMD =18,
		IxST_STR_YMD =19, 
		IxTOTAL_QTY =20,
		IxGEN =21,  
		IxCS_SIZE_START =22, 
	}  


	/// <summary> 
	/// SPD_DAILY_WORKSHEET_TS 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPD_DAILY_WORKSHEET_TS_SUM_SEARCH : int 
	{  
 
		IxTBLINE_CD =0, 
		IxTBDIV =1,
		IxTBLINE_NAME =2,
		IxTBOP_CD =3, 
		IxTBLOT =4,  
		IxTBOBS_TYPE =5,
		IxTBMODEL_CD =6,
		IxTBPO_NO =7,
		IxTBSTYLE_CD =8,
		IxTBRTS_YMD =9,
		IxTBOGAC =10,
		IxTBDIV_DESC =11,
		IxTBCMP_CD =12,
		IxTBPLAN_YMD =13,
		IxTBDAY_SEQ =14,
		IxTBINPUT_PRIO =15,  
		IxTBGEN =16,  
		IxTBCS_SIZE =17,
		IxTBDIR_QTY =18, 
 

		IxLINE_CD =1, 
		IxDIV =2,
		IxLINE_NAME =3,
		IxOP_CD =4, 
		IxLOT =5,  
		IxMODEL_CD =6,
		IxPO_NO =7,
		IxSTYLE_CD =8,
		IxRTS_YMD =9,
		IxOGAC =10,
		IxCMP_CD =11,
		IxDIV_DESC =12,
		IxPLAN_YMD =13,
		IxINPUT_PRIO =14, 
		IxTOTAL_QTY =15,
		IxGEN =16,  
		IxCS_SIZE_START =17, 
	}  



	/// <summary> 
	/// SPD_LOT_DAILY_OPSIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_LOT_DAILY_OPSIZE : int 
	{  
		IxTBLINE_CD =0,	
		IxTBLINE_NAME =1,
		IxTBLOT =2, 
		IxTBMODEL_NAME =3,
		IxTBPO_NO =4,
		IxTBSTYLE_CD =5,
		IxTBOBS_ID =6,
		IxTBOBS_TYPE =7,
		IxTBDAY_SEQ =8,
		IxTBPLAN_YMD =9,
		IxTBPLAN_STATUS =10,
		IxTBPLAN_STATUS_DESC =11,
		IxTBGEN =12,		
		IxTBCS_SIZE =13,	
		IxTBSIZE_QTY =14, 
		IxTBTS_FINISH_YN =15,
 

		IxLINE_CD =1,	
		IxLINE_NAME =2,
		IxLOT =3,  
		IxMODEL_NAME =4,
		IxPO_NO =5,
		IxSTYLE_CD =6,
		IxOBS_ID =7,
		IxOBS_TYPE =8,
		IxDAY_SEQ =9,
		IxPLAN_YMD =10, 
		IxPLAN_STATUS_DESC =11,
		IxTOT_QTY =12,
		IxTS_FINISH_YN =13,
		IxGEN =14,		
		IxCS_SIZE_START =15,	 

	}  


	/// <summary> 
	/// SPD_LOT_DAILY_OPSIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_RELEASE_DEF : int 
	{  
		IxTBLINE_CD =0,	
		IxTBLINE_NAME =1,	
		IxTBMLINE_NAME =2,
		IxTBMLINE_CD =3,
		IxTBLOT =4, 
		IxTBMODEL_NAME =5,
		IxTBSTYLE_CD =6,
		IxTBOBS_ID =7,
		IxTBOBS_TYPE =8,
		IxTBJIT_REQ_TYPE =9,
		IxTBOP_STR_YMD =10,
		IxTBDIR_REQ_YMD =11,
		IxTBPLAN_STATUS_DESC =12,
		IxTBCMP_CD =13,
		IxTBSTR_OP_CD =14,
		IxTBEND_OP_CD =15,		
		IxTBTOT_QTY =16,	
		IxTBGEN =17, 
		IxTBCS_SIZE =18,
		IxTBSIZE_QTY =19,
  
 
		IxLINE_CD =1,	
		IxLINE_NAME =2,
		IxMLINE_NAME =3,
		IxMLINE_CD =4,
		IxLOT =5, 
		IxMODEL_NAME =6,
		IxSTYLE_CD =7,
		IxOBS_ID =8,
		IxOBS_TYPE =9,
		IxJIT_REQ_TYPE =10,
		IxOP_STR_YMD =11,
		IxDIR_REQ_YMD =12,
		IxPLAN_STATUS_DESC =13,
		IxCMP_CD =14,
		IxSTR_OP_CD =15,
		IxEND_OP_CD =16,		
		IxTOT_QTY =17,	
		IxGEN =18, 
		IxCS_SIZE_START =19,

	}  



	/// <summary> 
	/// SPD_LOT_DAILY_OPSIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_LOT_DAILY_OPSIZE_OUT_H : int 
	{  
		IxTBLINE_CD =0,		
		IxTBLOT =1, 
		IxTBMODEL_NAME =2,
		IxTBSTYLE_CD =3,
		IxTBGEN =4,		
		IxTBOBS_ID =5,
		IxTBOBS_TYPE =6,
		IxTBDAY_SEQ =7,
		IxTBPLAN_YMD =8, 
		IxTBSIZE_QTY =9,  

		IxLINE_CD =1,		
		IxLOT =2,  
		IxMODEL_NAME =3,
		IxSTYLE_CD =4,
		IxGEN =5,		
		IxOBS_ID =6,
		IxOBS_TYPE =7,
		IxDAY_SEQ =8,
		IxPLAN_YMD =9,  
		IxSIZE_QTY =10, 	 

	}  


	/// <summary> 
	/// SPD_LOT_DAILY_OPSIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_JIT_REQ_OUT_H : int 
	{ 
		IxTBLINE_CD =0,	
		IxTBMLINE_NAME =1,
		IxTBLOT =2, 
		IxTBMODEL_NAME =3,
		IxTBSTYLE_CD =4,
		IxTBGEN =5,		
		IxTBOBS_ID =6,
		IxTBOBS_TYPE =7,
		IxTBOP_STR_YMD =8,
		IxTBCMP_CD =9, 
		IxTBSTR_OP_CD =10,  
		IxTBEND_OP_CD =11,  
		IxTBSIZE_QTY =12,  

		IxLINE_CD =1,	
		IxMLINE_NAME =2,
		IxLOT =3, 
		IxMODEL_NAME =4,
		IxSTYLE_CD =5,
		IxGEN =6,		
		IxOBS_ID =7,
		IxOBS_TYPE =8,
		IxOP_STR_YMD =9,
		IxCMP_CD =10, 
		IxSTR_OP_CD =11,  
		IxEND_OP_CD =12,  
		IxSIZE_QTY =13, 	 

	}  

	/// <summary> 
	/// SPD_LOT_DAILY_OPSIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_LOT_DAILY_OPSIZE_OUT_D : int 
	{  
		IxTBMAT_AREA =0,		
		IxTBCS_SIZE =1,  
		IxTBSIZE_QTY =2,  

		IxMAT_AREA =1,		
		IxCS_SIZE =2,  
		IxSIZE_QTY =3,
		IxAREA_START =4, 

	}  


	/// <summary> 
	/// SPD_LOT_DAILY_OPSIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_LOT_DAILY_ADAPT_LT : int 
	{ 
		IxCHECK_FLAG =1,		
		IxDAY_SEQ =2,  
		IxPLAN_YMD =3,
		IxING_STATUS =4,
		IxPLAN_STATUS =5, 
	}  


	/// <summary> 
	/// 사이즈 배분 일괄 처리 SPO_LOT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_DAILY_DEPLOYSIZE : int 
	{ 
		IxCHECK_FLAG =1,		
		IxLINE_CD =2,
		IxLOT =3,  
		IxSTYLE_CD =4,
		IxING_STATUS =5,  
	}  


	
	/// <summary> 
	/// OpSize 전개 일괄 처리 SPO_LOT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_DAILY_ADAPT_LT : int 
	{ 
		IxCHECK_FLAG =1, 
		IxLOT =2,  
		IxSTYLE_CD =3,  
		IxLEADTIME_CD =4, 
		IxLT_APPLY_YMD =5, 
		IxING_STATUS =6,  
	}



	public enum TBSPO_RECV_LOSS : int
	{
		IxTBRGAC =0,
		IxTBOGAC =1,
		IxTBOBS_ID =2,
		IxTBOBS_TYPE =3,
		IxTBDEST =4,
		IxTBMODEL_NAME =5,
		IxTBSTYLE_CD =6,
		IxTBGEN =7,

		IxTBCS_SIZE =0,
		IxTBORD_QTY =1,
		IxTBLOSS_QTY =2,
 
		IxDESC =1,
		IxSUM =2,
		IxCS_SIZE_START =3,

	}

	/// <summary> 
	/// TBSPB_STYLE_MOLD 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_STYLE_MOLD1 : int 
	{ 	
		IxDB_FACTORY    = 0,
		IxDB_PLAN_YMD   = 1,
		IxDB_MOLD_CD    = 2,
		IxDB_LINE_CD    = 3,
		IxDB_MODEL_CD   = 4,
		IxDB_MODEL_NAME = 5,
		IxDB_STYLE_CD   = 6,
		IxDB_LOT_NO     = 7,
		IxDB_LOT_SEQ    = 8,  
		IxDB_DAY_SEQ    = 9,
		IxDB_GEN        = 10,
		IxDB_CS_SIZE    = 11,
		IxDB_SUMQTY     = 12, 




		IxGR_DIVISION   = 0,
		IxGR_SEQ        = 1,
		IxGR_FACTORY    = 2,
		IxGR_PLAN_YMD   = 3,
		IxGR_MOLD_CD    = 4,
		IxGR_LINE_CD    = 5,
		IxGR_MODEL_CD   = 6,
		IxGR_MODEL_NAME = 7,
		IxGR_STYLE_CD   = 8,
		IxGR_LOT_NO     = 9,
		IxGR_LOT_SEQ    = 10,  
		IxGR_DAY_SEQ    = 11,
		IxGR_TOTAL      = 12,
		IxGR_GEN        = 13,
		IxGR_SIZE       = 14, 



		IxDBMOLD_FACTORY   = 0,
		IxDBMOLD_MOLD_TYPE = 1,
		IxDBMOLD_MOLD_CD   = 2,
		IxDBMOLD_SPEC_CD   = 3,
		IxDBMOLD_GEN       = 4,
		IxDBMOLD_MSIZE     = 5,
		IxDBMOLD_CS_SIZE   = 6,
		IxDBMOLD_SUM_QTY   = 7,
		IxDBMOLD_PAIRS     = 8,
		IxDBMOLD_CYCLE     = 9,

 
	} 



	/// <summary> 
	/// TBSPB_MODEL_MOLD 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_MODEL_MOLD1 : int 
	{ 
		IxDB_FACTORY    = 0,		
		IxDB_MODEL_CD   = 1,  
		IxDB_MODEL_NAME = 2,
		IxDB_MOLD_TYPE  = 3,
		IxDB_MOLD_CD    = 4,
		IxDB_SPEC_CD    = 5,
		IxDB_MSIZE_YN   = 6,
		IxDB_GEN        = 7,
		IxDB_CS_SIZE    = 8,
		IxDB_FST_SIZE   = 9,
		IxDB_SUM_QTY    = 10,
		IxDB_PAIRS      = 11,



		IxGR_DIVISION   = 0,	
		IxGR_FACTORY    = 1,		
		IxGR_MODEL_CD   = 2,  
		IxGR_MODEL_NAME = 3,
		IxGR_MOLDTYPE   = 4, 
		IxGR_MOLD_CD    = 5,
		IxGR_SPEC_CD    = 6,
		IxGR_MSIZE_YN   = 7,
		IxGR_MOLD_TOT   = 8,
		IxGR_GEN        = 9,
 
	} 



	/// <summary> 
	/// TBSPB_MOLD_HISTORY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_MOLD_HISTORY : int 
	{ 
		IxDB_FACTORY    = 0,		
		IxDB_MODEL_CD   = 1,  
		IxDB_MODEL_NAME = 2,
		IxDB_MOLD_CD    = 3,
		IxDB_SPEC_CD    = 4,
		IxDB_CMP_CD     = 5,
		IxDB_MOLD_TYPE  = 6,
		IxDB_MOLD_GEN   = 7,
		IxDB_CS_SIZE    = 8,
		IxDB_QTY        = 9,
		IxDB_DCODE      = 10,
		IxDB_CD_NAME    = 11,
		IxDB_YMD        = 12,



		IxGR_DIVISION   = 0,	
		IxGR_FACTORY    = 1,		
		IxGR_MODEL_CD   = 2,  
		IxGR_MODEL_NAME = 3,
		IxGR_DATE       = 4,
		IxGR_HISTORY    = 5,
		IxGR_MOLD_CD    = 6,
		IxGR_SPEC_CD    = 7,
		IxGR_CMP_CD     = 8,
		IxGR_MOLD_TYPE  = 9,
		IxGR_TOTAL      = 10,
		IxGR_MOLD_GEN   = 11,
		IxGR_SIZE_START = 12,
 
	}



	/// <summary> 
	/// TBSPD_JIT_REQ 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_JIT_REQ_VJ : int 
	{ 
		IxDB_LOT_FACTORY     = 0,
		IxDB_LOT_LOT_NO      = 1,
		IxDB_LOT_LOT_SEQ     = 2,
		IxDB_LOT_LOT         = 3,
		IxDB_LOT_PO_NO       = 4,
		IxDB_LOT_MODEL_CD    = 5,
		IxDB_LOT_MODEL_NAME  = 6,
		IxDB_LOT_STYLE_CD    = 7,
		IxDB_LOT_GEN         = 8,
		IxDB_LOT_OBS_ID      = 9,
		IxDB_LOT_PLAN_STRYMD = 10,
		IxDB_LOT_PLAN_ENDYMD = 11,
		IxDB_LOT_RTS_YMD     = 12,
		IxDB_LOT_BOM_CD      = 13,
		IxDB_LOT_ROUT_TYPE   = 14,
		IxDB_LOT_LEADTIME_CD = 15,
		IxDB_LOT_LOT_QTY     = 16,
		IxDB_LOT_SHORT_QTY   = 17,
		IxDB_LOT_PRINT_QTY   = 18,


		IxGR_LOT_DIVISION    = 0,
		IxGR_LOT_FACTORY     = 1,
		IxGR_LOT_LOT_NO      = 2,
		IxGR_LOT_LOT_SEQ     = 3,
		IxGR_LOT_LOT         = 4,
		IxGR_LOT_PO_NO       = 5,
		IxGR_LOT_MODEL_CD    = 6,
		IxGR_LOT_MODEL_NAME  = 7,
		IxGR_LOT_STYLE_CD    = 8,
		IxGR_LOT_GEN         = 9,
		IxGR_LOT_OBS_ID      = 10,
		IxGR_LOT_PLAN_STRYMD = 11,
		IxGR_LOT_PLAN_ENDYMD = 12,
		IxGR_LOT_RTS_YMD     = 13,
		IxGR_LOT_BOM_CD      = 14,
		IxGR_LOT_ROUT_TYPE   = 15,
		IxGR_LOT_LEADTIME_CD = 16,
		IxGR_LOT_LOT_QTY     = 17,
		IxGR_LOT_SHORT_QTY   = 18,
		IxGR_LOT_PRITN_YMD   = 19,



		IxDB_REQ_FACTORY   = 0,
		IxDB_REQ_CMP_TYPE  = 1,
		IxDB_REQ_FROM_OP_CD= 2,
		IxDB_REQ_TO_OP_CD  = 3,


		IxGR_REQ_DIVISION  = 0,
		IxGR_REQ_FACTORY   = 1,
		IxGR_REQ_SEQ       = 2,
		IxGR_REQ_CMP       = 3,
		IxGR_REQ_DIV       = 4,
		IxGR_REQ_FROM_OP   = 5,
		IxGR_REQ_TO_OP     = 6,
		IxGR_REQ_PLAN_STATUS= 7,
		IxGR_REQ_TOTAL     = 8, 
		IxGR_REQ_GEN       = 9, 
	}

	/// <summary> 
	/// TBSPD_JIT_REQ 테이블 인덱스 Enum ***QD 테이블 인덱스***
	/// </summary> 
	public enum TBSPD_JIT_REQ : int 
	{ 
		IxDB_LOT_FACTORY     = 0,
		IxDB_LOT_LOT_NO      = 1,
		IxDB_LOT_LOT_SEQ     = 2,
		IxDB_LOT_LOT         = 3,
		IxDB_LOT_PO_NO       = 4,
		IxDB_LOT_MODEL_CD    = 5,
		IxDB_LOT_MODEL_NAME  = 6,
		IxDB_LOT_STYLE_CD    = 7,
		IxDB_LOT_GEN         = 8,
		IxDB_LOT_OBS_ID      = 9,
		IxDB_LOT_PLAN_STRYMD = 10,
		IxDB_LOT_PLAN_ENDYMD = 11,
		IxDB_LOT_RTS_YMD     = 12,
		IxDB_LOT_BOM_CD      = 13,
		IxDB_LOT_ROUT_TYPE   = 14,
		IxDB_LOT_LEADTIME_CD = 15,
		IxDB_LOT_LOT_QTY     = 16,
		IxDB_LOT_SHORT_QTY   = 17,
		IxDB_LOT_PRINT_QTY   = 18,


		IxGR_LOT_DIVISION    = 0,
		IxGR_LOT_FACTORY     = 1,
		IxGR_LOT_LOT_NO      = 2,
		IxGR_LOT_LOT_SEQ     = 3,
		IxGR_LOT_LOT         = 4,
		IxGR_LOT_PO_NO       = 5,
		IxGR_LOT_MODEL_CD    = 6,
		IxGR_LOT_MODEL_NAME  = 7,
		IxGR_LOT_STYLE_CD    = 8,
		IxGR_LOT_GEN         = 9,
		IxGR_LOT_OBS_ID      = 10,
		IxGR_LOT_PLAN_STRYMD = 11,
		IxGR_LOT_PLAN_ENDYMD = 12,
		IxGR_LOT_RTS_YMD     = 13,
		IxGR_LOT_BOM_CD      = 14,
		IxGR_LOT_ROUT_TYPE   = 15,
		IxGR_LOT_LEADTIME_CD = 16,
		IxGR_LOT_LOT_QTY     = 17,
		IxGR_LOT_SHORT_QTY   = 18,
		IxGR_LOT_PRITN_YMD   = 19,



		IxDB_REQ_FACTORY   = 0,
		IxDB_REQ_CMP_TYPE  = 1,
		IxDB_REQ_FROM_OP_CD= 2,
		IxDB_REQ_TO_OP_CD  = 3,


		IxGR_REQ_DIVISION  = 0,
		IxGR_REQ_FACTORY   = 1,
		IxGR_REQ_SEQ       = 2,
		IxGR_REQ_CMP       = 3,
		IxGR_REQ_DIV       = 4,
		IxGR_REQ_FROM_OP   = 5,
		IxGR_REQ_TO_OP     = 6,
		IxGR_REQ_PLAN_STATUS= 7,
		IxGR_REQ_OP_TYPE   = 8,
		IxGR_REQ_TOTAL     = 9, 
		IxGR_REQ_GEN       = 10, 
	}



	/// <summary> 
	/// MPS By OP 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_WORKSHEET_MPS : int 
	{  		  
		IxLINE_CD =1,			 
		IxLINE_NAME =2,
		IxLOT =3, 
		IxMODEL_NAME =4,
		IxPO_NO =5,
		IxSTYLE_CD =6,		
		IxGEN =7,
		IxOBS_ID =8,
		IxOBS_TYPE =9,	
		IxRTS_YMD =10,  
		IxOGAC =11,  
		IxORD_QTY =12,
		IxLOSS_QTY =13,
		IxSUM_QTY =14, 
		IxPLAN_STATUS =15, 
		IxREAL_LOTYN =16,  
		IxYMD_START =17,
 
		IxTBYMD_THEDAY =0,
		IxTBYMD_WEEKDAY =1, 
		IxTBYMD_HOLI_YN = 2,
	 

		IxTBH_LINE_CD =0,			 
		IxTBH_LINE_NAME =1,
		IxTBH_LOT =2, 
		IxTBH_MODEL_NAME =3,
		IxTBH_PO_NO =4,
		IxTBH_STYLE_CD =5,		
		IxTBH_GEN =6,	
		IxTBH_OBS_ID =7,
		IxTBH_OBS_TYPE =8,	
		IxTBH_RTS_YMD =9,  	
		IxTBH_OGAC =10,  	
		IxTBH_ORD_QTY =11,
		IxTBH_LOSS_QTY =12,
		IxTBH_SUM_QTY =13, 		
		IxTBH_PLAN_STATUS =14, 
		IxTBH_REAL_LOTYN =15,  

		
		IxTBD_LOT =0,
		IxTBD_PLAN_STATUS =1,
		IxTBD_REAL_LOTYN =2,
		IxTBD_OP_STR_YMD =3,
		IxTBD_SIZE_QTY =4,
		IxTBD_DEADLINE_YN =5,


	}  



 

	/// <summary> 
	/// TBSPD_WORKSHEET_MPS_CHECK_MPS
	/// </summary> 
	public enum TBSPD_WORKSHEET_MPS_CHECK_MPS : int 
	{  		  
		 
		IxPLAN_DATE_F =0,
		IxPLAN_DATE_T =1,
		IxBACK_COLOR =2,
		IxAREA_CD =3,  

	}  
  


	/// <summary> 
	/// TBSPD_JIT_REQ 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_JIT_REQ_LIST : int 
	{ 
		IxDB_LINE_CD          = 0,
		IxDB_MLINE_NAME       = 1,
		IxDB_MLINE_CD         = 2,
		IxDB_LOT              = 3,
		IxDB_MODEL_NAME       = 4,
		IxDB_STYLE_CD         = 5,
		IxDB_OBS_ID           = 6,
		IxDB_OBS_TYPE         = 7,
		IxDB_JIT_REQ_TYPE     = 8,
		IxDB_OP_STR_YMD       = 9,
		IxDB_DIR_REQ_YMD      = 10,
		IxDB_PLAN_STATUS_DESC = 11,
		IxDB_CMP_CD           = 12,
		IxDB_STR_OP_CD        = 13,
		IxDB_END_OP_CD        = 14,
		IxDB_TOT_QTY          = 15,
		IxDB_GEN              = 16,
		IxDB_CS_SIZE          = 17,
		IxDB_SIZE_QTY         = 18,


		IxGR_DIVISION         = 0,
		IxGR_LINE_CD          = 1,
		IxGR_LINE_NAME        = 2,
		IxGR_MLINE_NAME       = 3,
		IxGR_MLINE_CD         = 4,
		IxGR_LOT              = 5,
		IxGR_MODEL_NAME       = 6,
		IxGR_STYLE_CD         = 7,
		IxGR_OBS_ID           = 8,
		IxGR_OBS_TYPE         = 9,
		IxGR_JIT_REQ_TYPE     = 10,
		IxGR_OP_STR_YMD       = 11,
		IxGR_DIR_REQ_YMD      = 12,
		IxGR_PLAN_STATUS_DESC = 13,
		IxGR_CMP_CD           = 14,
		IxGR_STR_OP_CD        = 15,
		IxGR_END_OP_CD        = 16,
		IxGR_TOT_QTY          = 17,
		IxGR_GEN              = 18,
		IxGR_SIZE_STR         = 19,
	}


	/// <summary> 
	/// TBSPB_MODEL_USING 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPB_MODEL_USING : int 
	{ 
		IxDB_FACTORY    = 0,
		IxDB_MODEL_CD   = 1,
		IxDB_MODEL_NAME = 2,
		IxDB_MODEL_GEN  = 3,
		IxDB_MOLD_GROUP = 4,
		IxDB_MOLD_TYPE  = 5,
		IxDB_MOLD_CD    = 6,
		IxDB_SPEC_CD    = 7,
		IxDB_MSIZE_YN   = 8,
		IxDB_MOLD_GEN   = 9,
		IxDB_MOLD_TOT   = 10,


		IxGR_DIVISION   = 0,
		IxGR_FACTORY    = 1,
		IxGR_MODEL_CD   = 2,
		IxGR_MODEL_NAME = 3,
		IxGR_MODEL_GEN  = 4,
		IxGR_MOLD_GROUP = 5,
		IxGR_MOLD_TYPE  = 6,
		IxGR_MOLD_CD    = 7,
		IxGR_SPEC_CD    = 8,
		IxGR_MSIZE_YN   = 9,
		IxGR_MOLD_GEN   = 10,
		IxGR_MOLDE_TOT  = 11,
		IxGR_REMARKS    = 12,
	}


	/// <summary> 
	/// SPO_LOT_SIZE 그리드 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_ADDLOSS_H : int 
	{  
		//display LOT info DB index
		IxLI_MODEL_NAME = 0, 
		IxLI_STYLE_CD =1,
		IxLI_GEN =2,
		IxLI_PO_NO =3, 
		IxLI_OBS_ID =4,
		IxLI_OBS_TYPE =5, 
  
		//size data DB index  
		IxTBREQ_NO =0, 
		IxTBOBS_NU =1, 
		IxTBOBS_SEQ_NU =2, 
		IxTBDEST =3, 
		IxTBRGAC =4, 
		IxTBOGAC =5,
		IxTBCS_SIZE =6, 
		IxTBSIZE_QTY =7,
		IxTBLOSS_QTY =8,  


		//size data Grid index  
		IxSAVE_FLAG =1, 
		IxREQ_NO =2, 
		IxOBS_NU =3, 
		IxOBS_SEQ_NU =4, 
		IxDEST =5, 
		IxRGAC =6, 
		IxOGAC =7,
		IxTOT_QTY =8,
		IxSUM_QTY =9, 
		IxCS_SIZE_START =10, 


	}  


	/// <summary> 
	/// SPO_LOT_SIZE 그리드 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_ADDLOSS_D : int 
	{  
		//size data DB index   
		IxTBLOT = 0,  
		IxTBREQ_NO = 1, 
		IxTBOBS_NU = 2, 
		IxTBOBS_SEQ_NU = 3, 
		IxTBDEST = 4, 
		IxTBRGAC = 5, 
		IxTBOGAC = 6, 
		IxTBCS_SIZE = 7, 
		IxTBSIZE_QTY = 8,
		IxTBLOSS_QTY = 9,  


		//size data Grid index 
		IxSAVE_FLAG =1, 
		IxLOT = 2, 
		IxREQ_NO =3, 
		IxOBS_NU = 4, 
		IxOBS_SEQ_NU = 5, 
		IxDEST = 6, 
		IxRGAC = 7, 
		IxOGAC = 8, 
		IxTOT_QTY =9,
		IxSUM_QTY =10, 
		IxCS_SIZE_START =11, 


	}     
	


	/// <summary> 
	/// SPO_LOT_SIZE 그리드 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_LINE_PRIO : int 
	{  
		//display LOT info DB index
		IxTBMODEL_NAME = 0, 
		IxTBSTYLE_CD =1,
		IxTBGEN =2,
		IxTBPO_NO =3, 
		IxTBOBS_ID =4,
		IxTBOBS_TYPE =5, 
		IxTBRGAC =6, 
		IxTBIPW =7, 
		IxTBLOT_QTY =8, 
		IxTBLOSS_QTY =9, 

		//display LOT Line Prio DB index
		IxLP_LINE_SEQ =0,
		IxLP_LINE_CD =1,
 
	}

	/// <summary> 
	/// SPO_LOT_DAYILY_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_DIVIDE_LOT_DAILY_SIZE : int 
	{  
		IxTBPLAN_STATUS =0, 
		IxTBDAY_SEQ =1, 
		IxTBPLAN_YMD =2, 
		IxTBCS_SIZE =3,			
		IxTBSIZE_QTY =4, 
   
		IxCHECK_FLAG =1,
		IxPLAN_STATUS =2, 
		IxPLAN_YMD =3, 
		IxTOTAL =4, 
		IxCS_SIZE_START =5, 

	} 

	/// <summary> 
	/// SPO_LOT_DAYILY_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_DIVIDE_LOT_SIZE : int 
	{ 
		IxTBREQ_NO =0, 
		IxTBDEST =1, 
		IxTBRGAC =2, 
		IxTBCS_SIZE =3,			
		IxTBSIZE_QTY =4, 
		IxTBLOSS_QTY =5, 
   
		IxSAVE_FLAG =1,
		IxROW_FLAG =2,
		IxREQ_NO =3,
		IxDEST =4, 
		IxRGAC =5, 
		IxTOTAL =6, 
		IxSUM =7,
		IxCS_SIZE_START =8, 

	} 



	/// <summary> 
	/// TBSPO_NOLOT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_NOLOT : int 
	{  
		IxDBFACTORY            =0,
		IxDBMODEL_NAME         =1,
		IxDBSTYLE_CD           =2,		
		IxDBGEN                =3,
		IxDBOBS_ID             =4,
		IxDBOBS_TYPE           =5,
		IxDBLOT_NO             =6, 
		IxDBLOT_SEQ            =7,
		IxDBREQ_NO             =8, 
		IxDBRTS_YMD            =9,
		IxDBPO_NO              =10, 
		IxDBREGION             =11,
		IxDBDEST               =12, 
		IxDBDEST_PRITY         =13,
		IxDBBOM_CD             =14,
		IxDBTOT_QTY            =15,
		IxDBTOT_LOSS_QTY       =16, 
		IxDBLOT_REMAINQTY      =17,
		IxDBLOT_LOSS_REMAINQTY =18, 
		IxDBUPD_USER           =19,
		IxDBUPD_YMD            =20, 

   
		IxGRDIVISION           =0, 
		IxGRFACTORY            =1,
		IxGRMODEL_NAME         =2,
		IxGRSTYLE_CD           =3,		
		IxGRGEN                =4,
		IxGROBS_ID             =5,
		IxGROBS_TYPE           =6,
		IxGRLOT_NO             =7, 
		IxGRLOT_SEQ            =8,
		IxGRREQ_NO             =9, 
		IxGRRTS_YMD            =10,
		IxGRPO_NO              =11, 
		IxGRREGION             =12,
		IxGRDEST               =13, 
		IxGRDEST_PRITY         =14,
		IxGRBOM_CD             =15,
		IxGRTOT_QTY            =16,
		IxGRTOT_LOSS_QTY       =17, 
		IxGRLOT_REMAINQTY      =18,
		IxGRLOT_LOSS_REMAINQTY =19, 
		IxGRUPD_USER           =20,
		IxGRUPD_YMD            =21, 

	} 


	/// <summary> 
	/// 
	/// </summary> 
	public enum TBSPO_MODIFY_LOT_DAILY : int 
	{ 
		//YMD Field  
		IxTBHTHEDATE =0, 
		IxTBHWEEKDAY =1,			
		IxTBHHOLI_YN =2, 
 
		//Size Data Field
		IxTBDDAY_SEQ =0,
		IxTBDPLAN_YMD =1,
		IxTBDPLAN_STATUS =2,
		IxTBDTS_FINISH_YN =3,
		IxTBDSIZE_QTY =4, 

	}


	/// <summary> 
	/// TBSPO_NOLOT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_AND_REQ : int 
	{  
 
		IxFACTORY			 = 1,
		IxOBS_ID			 = 2,
		IxOBS_TYPE			 = 3,
		IxLINE_CD			 = 4,
		IxLINE_NAME			 = 5, 
		IxMODEL_CD			 = 6,
		IxMODEL_NAME		 = 7,
		IxSTYLE_CD			 = 8,
		IxGEN			 	 = 9,
		IxLOT				 = 10, 
		IxRGAC_LOT			 = 11,
		IxOGAC_LOT			 = 12,
		IxPLAN_STRYMD		 = 13,
		IxPLAN_ENDYMD		 = 14,
		IxTOT_DAY_SEQ		 = 15, 
		IxBOM_CD			 = 16,
		IxPLAN_STATUS		 = 17,
		IxREAL_LOTYN		 = 18,
		IxREQ_NO			 = 19,
		IxDEST				 = 20, 
		IxRGAC_REQ			 = 21,
		IxOGAC_REQ			 = 22,
		IxMSR_YN			 = 23,
		IxOBS_DIV			 = 24,
		IxDEST_PRITY		 = 25, 
		IxLOT_QTY			 = 26,
		IxLOSS_QTY			 = 27,
		IxTOT_QTY			 = 28,
		IxTOT_LOSS_QTY		 = 29,
		IxLOT_REMAINQTY      = 30, 
		IxLOT_LOSS_REMAINQTY = 31,




		IxDBFACTORY     = 0,

		IxDBOBS_ID      = 1,
		IxDBOBS_TYPE    = 2,
		IxDBLINE_CD     = 3,
		IxDBMODEL_NAME  = 4,
		IxDBMODEL_CD    = 5,

		IxDBSTYLE_CD    = 6,
		IxDBGEN         = 7,
		IxDBLOT_NO      = 8,
		IxDBLOT_SEQ     = 9,
		IxDBBOM_CD      = 10,

		IxDBRTS_YMD     = 11,
		IxDBPO_NO       = 12,
		IxDBPLAN_STRYMD = 13,
		IxDBPLAN_ENDYMD = 14,
		IxDBPLAN_STATUS = 15,

		IxDBTOT_DAY_SEQ = 16,
		IxDBREAL_LOTYN  = 17,
		IxDBREQ_NO      = 18,
		IxDBREQRTS_YMD  = 19,
		IxDBREGION      = 20,

		IxDBDEST        = 21,
		IxDBDEST_PRITY  = 22,
		IxDBLOT_QTY     = 23,
		IxDBMRG1        = 24,
		IxDBREQ_TOT_QTY = 25,
		
		IxDBMRG2        = 26,
		IxDBLOSS_QTY    = 27,
		IxDBMRG3        = 28,
		IxDBREQ_TOT_LOSS_QTY = 29,
		IxDBMRG4        = 30,
		
		IxDBREMAIN_QTY  = 31,
		IxDBMRG5        = 32,
		IxDBLOSS_REMAIN_QTY = 33,

   
		IxGRDIVISION    = 0, 

		IxGRFACTORY     = 1,
		IxGROBS_ID      = 2,
		IxGROBS_TYPE    = 3,
		IxGRLINE_CD     = 4,
		IxGRMODEL_NAME  = 5,

		IxGRMODEL_CD    = 6,
		IxGRSTYLE_CD    = 7,
		IxGRGEN         = 8,
		IxGRLOT_NO      = 9,
		IxGRLOT_SEQ     = 10,

		IxGRBOM_CD      = 11,
		IxGRRTS_YMD     = 12,
		IxGRPO_NO       = 13,
		IxGRPLAN_STRYMD = 14,
		IxGRPLAN_ENDYMD = 15,

		IxGRPLAN_STATUS = 16,
		IxGRTOT_DAY_SEQ = 17,
		IxGRREAL_LOTYN  = 18,
		IxGRREQ_NO      = 19,
		IxGRREQRTS_YMD  = 20,

		IxGRREGION      = 21,
		IxGRDEST        = 22,
		IxGRDEST_PRITY  = 23,
		IxGRLOT_QTY     = 24,
		IxGRMRG1        = 25,

		IxGRREQ_TOT_QTY = 26,
		IxGRMRG2        = 27,
		IxGRLOSS_QTY    = 28,
		IxGRMRG3        = 29,
		IxGRREQ_TOT_LOSS_QTY = 30,

		IxGRMRG4        = 31,
		IxGRREMAIN_QTY  = 32,
		IxGRMRG5        = 33,
		IxGRLOSS_REMAIN_QTY = 34,
	}



	/// <summary> 
	/// TBSPO_LOT_AND_REQ : 테이블 인덱스
	/// </summary> 
	public enum TBSPO_LOT_AND_REQ1 : int 
	{ 
 
		
		IxFACTORY		= 1,
		IxOBS_ID		= 2,
		IxOBS_TYPE		= 3,
		IxMODEL_NAME	= 4, 
		IxSTYLE_CD		= 5,
		IxDIVISION		= 6,
		IxLOT			= 7,
		IxREQ_NO		= 8,
		IxRGAC_LOT		= 9, 
		IxOGAC_LOT		= 10,
		IxDEST			= 11,
		IxMSR_DIV       = 12,
		IxTOT_QTY		= 13, 
		IxGEN			= 14,
		IxCS_SIZE		= 15,
		IxSIZE_QTY		= 16, 
		IxORDERBY_SIZE  = 17, 

		IxCS_SIZE_START = 15,
 

		IxDB_FACTORY   = 0,
		IxDB_DPO       = 1,
		IxDB_LOT_NO    = 2,
		IxDB_LOT_SEQ   = 3,
		IxDB_REQ_NO    = 4,
		IxDB_MODELCD   = 5,
		IxDB_MODELNAME = 6,
		IxDB_STYLCD    = 7,
		IxDB_TYPE      = 8,
		IxDB_RGAC      = 9,
		IxDB_OGAC      = 10,
		IxDB_PO_NO     = 11,
		IxDB_TOTAL     = 12,
		IxDB_GEN       = 13,
		IxDB_SIZE      = 14,
		IxDB_QTY       = 15,

 
		IxGR_DIVISION  = 0,
		IxGR_FACTORY   = 1,
		IxGR_DPO       = 2,
		IxGR_LOT_NO    = 3,
		IxGR_LOT_SEQ   = 4,
		IxGR_REQ_NO    = 5,
		IxGR_MODELCD   = 6,
		IxGR_MODELNAME = 7,
		IxGR_STYLCD    = 8,
		IxGR_TYPE      = 9,
		IxGR_RGAC      = 10,
		IxGR_OGAC      = 11,
		IxGR_PO_NO     = 12,
		IxGR_TOTAL     = 13,
		IxGR_GEN       = 14,

	}



	/// <summary> 
	/// TBSPB_MODEL_BOM : 테이블 인덱스
	/// </summary> 
	public enum TBSPB_MODEL_BOM : int 
	{ 
		
		IxDB_FACTORY   = 0,
		IxDB_DPO       = 1,
		IxDB_MODELCD   = 2,
		IxDB_MODELNAME = 3,
		IxDB_STYLENAME = 4,
		IxDB_STYLCD    = 5,
		IxDB_PO_NO     = 6,
		IxDB_STRYMD    = 7,
		IxDB_ENDYMD    = 8,
		IxDB_BOMCD     = 9,
		IxDB_CMPCD     = 10,
 
		IxGR_DIVISION  = 0,
		IxGR_FACTORY   = 1,
		IxGR_DPO       = 2,
		IxGR_MODELCD   = 3,
		IxGR_MODELNAME = 4,
		IxGR_STYLENAME = 5,
		IxGR_STYLCD    = 6,
		IxGR_PO_NO     = 7,
		IxGR_STRYMD    = 8,
		IxGR_ENDYMD    = 9,
		IxGR_BOMCD     = 10,
		IxGR_CMPCD     = 11,

	}


	


	/// <summary>
	/// TBSPO_LOT_DAILY_SIZE_AUTO : 
	/// </summary>
	public enum TBSPO_LOT_DAILY_SIZE_AUTO : int
	{
		IxCHECK_FLAG   = 1,
		IxLINE_CD      = 2,
		IxMODEL_NAME   = 3,
		IxSTYLE_CD     = 4,
		IxGEN          = 5,
		IxOBS_ID       = 6,
		IxOBS_TYPE     = 7,
		IxRGAC         = 8,
		IxPO_NO		   = 9,
		IxLOT          = 10,
		IxING_STATUS   = 11,
		IxOK_FLAG      = 12,

	}
	 



	/// <summary>
	/// TBSPO_LOT_DAILY_SIZE_AUTO : 
	/// </summary>
	public enum TBSPB_STYLE_UP : int
	{
		IxSTYLE_CD     = 1,
		IxSTYLE_NAME   = 2,
		IxUPE_YN       = 3,
		IxUPF_YN	   = 4,
		IxUPH_YN       = 5,
		IxUPP_YN       = 6,
		IxREMARKS      = 7,
		IxEXIST_YN     = 8,
		IxUPD_USER     = 9,
		IxUPD_YMD      = 10, 

	}








	/// <summary>
	/// TBSPB_MOLD_LAST : 
	/// </summary>
	public enum TBSPB_MOLD_LAST : int
	{
		IxFACTORY		= 1,
		IxLAST_CD		= 2,
		IxLAST_NAME		= 3,
		IxLINE_CD		= 4,
		IxMODEL_CD		= 5,
		IxMODEL_NAME	= 6,
		IxPART_CD		= 7,
		IxSPEC_CD		= 8,
		IxGEN			= 9,
		IxMNT_CHK		= 10,
		IxGUAGE			= 11,
		IxUNIT			= 12,
		IxCUST_CD		= 13,
		IxMOLD_MAT		= 14,
		IxMOLD_PART		= 15,
		IxMOLD_SHOP		= 16,
		IxDEV_CD		= 17,
		IxPRS			= 18,
		IxSTART_PO		= 19,
		IxSTATUS		= 20,
		IxDSTY_DT		= 21,
		IxPK_QTY		= 22,
		IxVR_LINE		= 23,
		IxCOINAGE		= 24,
		IxCOST			= 25,
		IxUS_COST		= 26,
		IxCYCLE			= 27, 
		IxUSE_YN		= 28,
		IxREMARKS		= 29,
		IxSEND_CHK		= 30,
		IxSEND_YMD		= 31,
		IxUPD_USER		= 32,
		IxUPD_YMD 		= 33,

	}


	/// <summary>
	/// TBSPB_MOLD_LAST : 
	/// </summary>
	public enum TBSPB_MOLD_LAST_INVENTORY : int
	{

		IxFACTORY			= 1,
		IxLAST_CD			= 2, 
		IxLINE_CD			= 3,
		IxMODEL_CD			= 4, 
		IxLAST_SEQ			= 5,
		IxDESCRIPTION		= 6,
		IxTOT_QTY			= 7,
		IxGEN				= 8,
		IxCS_SIZE_START		= 9, 


		IxTBFACTORY			= 0,
		IxTBLAST_CD			= 1, 
		IxTBLINE_CD			= 2,
		IxTBMODEL_CD		= 3, 
		IxTBLAST_SEQ		= 4,
		IxTBDESCRIPTION     = 5,
		IxTBTOT_QTY			= 6,
		IxTBGEN				= 7,
		IxTBCS_SIZE			= 8, 
		IxTBINV_QTY			= 9,
		IxTBCYCLE_HOURLY	=10,
 

	}




	/// <summary>
	/// TBSPD_JIT_REQ_BSC : 
	/// </summary>
	public enum TBSPD_JIT_REQ_BSC : int
	{

		IxFACTORY		= 1,
		IxMODEL_CD		= 2, 
		IxMODEL_NAME	= 3,
		IxOBS_ID		= 4, 
		IxOBS_TYPE		= 5,
		IxSTYLE_CD		= 6,
		IxGEN			= 7,
		IxLOT_NO		= 8,
		IxLOT_SEQ		= 9, 
		IxREQ_NO		= 10,
		IxRGAC			= 11, 
		IxOGAC			= 12,
		IxPLAN_STRYMD	= 13, 
		IxPLAN_ENDYMD	= 14,
		IxBOM_CD		= 15,
		IxROUT_TYPE		= 16,
		IxLEADTIME_CD	= 17,
		IxLOT_QTY		= 18, 
		IxPRS_QTY		= 19,
		IxDIR_REQ_YMD	= 20,
		IxEXIST_YN      = 21,
		IxUPD_YMD		= 22,

	}

 

	/// <summary>
	/// TBSPD_JIT_REQ_SIZE_BSC : 
	/// </summary>
	public enum TBSPD_JIT_REQ_SIZE_BSC : int
	{

		IxJIT_REQ_TYPE	= 1,
		IxJIT_REQ_SEQ	= 2, 
		IxCMP_CD		= 3,
		IxSTR_OP_CD		= 4, 
		IxEND_OP_CD		= 5,
		IxPLAN_STATUS	= 6,
		IxOP_DIVISION	= 7,
		IxOP_TYPE		= 8,
		IxTOTAL_QTY		= 9,
		IxGEN			= 10, 
		IxCS_SIZE_START	= 11,

		IxCS_SIZE		= 10, 
		IxPRS_QTY		= 11, 


	}

	
	 
	/// <summary> 
	/// SEM_REQ 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSEM_REQ_BSC : int 
	{  	
		IxCHECK_FLAG		= 1,
		IxFACTORY			= 2,
		IxMODEL_NAME		= 3,
		IxSTYLE_CD			= 4,
		IxGEN				= 5,
		IxOBS_ID			= 6,
		IxOBS_TYPE			= 7,
		IxREQ_NO			= 8,
		IxDEST				= 9,
		IxRGAC				= 10,
		IxOGAC				= 11,
		IxMSR_DIV			= 12,
		IxTOT_SUM_QTY		= 13,
		IxTOT_QTY			= 14,
		IxTOT_SUM_LOSS_QTY	= 15,
		IxSUM_QTY			= 16,
		IxDEST_PRITY		= 17,
		IxREAL_OBS_DIV		= 18,
		IxOBS_NU			= 19,
		IxOBS_SEQ_NU		= 20,
		IxCHG_NU			= 21,
		IxOBS_DIV			= 22,
		IxPST_YN			= 23,
		IxCSETS_YMD			= 24,
		IxCSETS_RSN			= 25,
		IxREQ_YMD			= 26,
		IxOA_NU				= 27, 
		IxOA_OBS_DIV		= 28,
		IxOA_DIV			= 29,
		IxOA_YMD			= 30,
		IxOA_CFM			= 31,
		IxOA_FLAG			= 32,
		IxORD_STATUS		= 33,
		IxPLAN_OAAPP_DIV	= 34,
		IxPLAN_OAAPP_YMD	= 35, 
		IxREMARKS			= 36,
		IxUPD_USER			= 37, 
		IxUPD_YMD			= 38,


	}   

   

	/// <summary> 
	/// SPO_RECV 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_RECV_BSC : int 
	{  
		 
		IxDEL_YN				= 1,
		IxFACTORY				= 2,
		IxMODEL_NAME			= 3,
		IxSTYLE_CD				= 4,
		IxGEN					= 5,
		IxOBS_ID				= 6,
		IxOBS_TYPE				= 7,
		IxREQ_NO				= 8,
		IxDEST					= 9,
		IxRGAC					= 10,
		IxOGAC					= 11,
		IxMSR_DIV				= 12,
		IxTOT_SUM_QTY			= 13,
		IxTOT_QTY				= 14,
		IxTOT_SUM_LOSS_QTY		= 15,
		IxSUM_QTY				= 16,
		IxDEST_PRITY			= 17,
		IxREAL_OBS_DIV			= 18,
		IxOBS_NU				= 19,
		IxOBS_SEQ_NU			= 20,
		IxCHG_NU				= 21,
		IxOBS_DIV				= 22,
		IxPST_YN				= 23,
		IxCSETS_YMD				= 24,
		IxCSETS_RSN				= 25,
		IxREQ_YMD				= 26,
		IxOA_NU					= 27, 
		IxOA_OBS_DIV			= 28,
		IxOA_DIV				= 29,
		IxOA_YMD				= 30,
		IxOA_CFM				= 31,
		IxOA_FLAG				= 32,
		IxORD_STATUS			= 33,
		IxPLAN_OAAPP_DIV		= 34,
		IxPLAN_OAAPP_YMD		= 35, 
		IxLOT_DIV				= 36,
		IxLOT_REMAINQTY			= 37,
		IxLOT_LOSS_REMAINQTY	= 38,
		IxREMARKS				= 39,
		IxUPD_USER				= 40, 
		IxUPD_YMD				= 41,


	}  
 
 
	/// <summary> 
	/// SPO_LOT_OA_HEAD 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_OA_HEAD : int 
	{  
		 
		IxREQ_NO_B		= 1,
		IxOBS_ID_B		= 2,
		IxOBS_TYPE_B	= 3,
		IxDEST_B		= 4,
		IxRGAC_B		= 5,
		IxOGAC_B		= 6,
		IxMSR_DIV_B		= 7,
		IxOA_NU_B		= 8,
		IxOA_FLAG_B		= 9,
		IxTOT_QTY_B		=10, 
		IxREQ_NO_A		=11,
		IxOBS_ID_A		=12,
		IxOBS_TYPE_A	=13,
		IxDEST_A		=14,
		IxRGAC_A		=15,
		IxOGAC_A		=16, 
		IxMSR_DIV_A		=17,
		IxOA_NU_A		=18,
		IxOA_FLAG_A		=19,
		IxTOT_QTY_A		=20, 

	}  
 
	

	/// <summary> 
	/// SPO_LOT_OA_DETAIL 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT_OA_DETAIL : int 
	{  
		  
		IxOA_NU			= 1,
		IxLOT			= 2,
		IxLOT_OLD		= 3,
		IxREQ_NO		= 4,
		IxREQ_SEQ_NU    = 5,
		IxOA_FLAG		= 6, 
		IxVIEW_LEVEL	= 7,
		IxDESCRIPTION	= 8,
		IxORDER_QTY		= 9,
		IxGEN			=10,
		IxCS_SIZE		=11,
		IxSIZE_QTY		=12,

		IxCS_SIZE_START =11, 

	}  
 





	/// <summary> 
	/// SPD_RELEASE_BSC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_RELEASE_BSC : int 
	{  
		 
		IxFACTORY		= 1,
		IxLINE_CD		= 2,
		IxLINE_NAME		= 3,
		IxMLINE_CD		= 4,
		IxMLINE_NAME	= 5,
		IxMODEL_NAME	= 6,
		IxSTYLE_CD		= 7,
		IxOBS_ID		= 8,
		IxOBS_TYPE		= 9, 
		IxLOT			=10,
		IxREQ_NO		=11,
		IxOBS_NU        =12,
		IxOBS_SEQ_NU    =13,
		IxDEST          =14,
		IxMSR_DIV       =15,
		IxRGAC          =16,
		IxOGAC			=17,  
		IxDESC1			=18,
		IxDESC2			=19,
		IxDESC3			=20, 
		IxDESC4			=21,
		IxDESC5			=22,
		IxDESC6			=23, 
		IxDESC7			=24,
		IxTS_FINISH_YN	=25,
		IxTOT_QTY		=26,
		IxGEN			=27,
		IxCS_SIZE		=28,
		IxSIZE_QTY		=29,

		IxCS_SIZE_START =28, 


	}   
	
	
	 
	/// <summary> 
	/// SPD_RELEASE_OUT_BSC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_RELEASE_OUT_BSC : int 
	{  
		 
		IxFACTORY		= 1,
		IxLINE_CD		= 2,
		IxLINE_NAME		= 3,
		IxMLINE_CD		= 4,
		IxMLINE_NAME	= 5,
		IxLOT			= 6,
		IxREQ_NO		= 7,
		IxOBS_NU        = 8,
		IxOBS_SEQ_NU    = 9,
		IxMODEL_NAME	=10, 
		IxSTYLE_CD		=11,
		IxGEN			=12,
		IxOBS_ID		=13,
		IxOBS_TYPE		=14,
		IxDESC1			=15,
		IxDESC2			=16,
		IxDESC3			=17, 
		IxDESC4			=18, 
		IxSIZE_QTY		=19, 


	}  

	/// <summary> 
	/// SPD_LOT_DAILY_OPSIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_RELEASE_OUT_SIZE_BSC : int 
	{  
		 
		IxMAT_AREA =1,		
		IxCS_SIZE =2,  
		IxSIZE_QTY =3,
		IxAREA_START =4, 

	}  



	/// <summary> 
	/// SPD_LOT_DAILY_OPSIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPD_RELEASE_OUT_SIZE_AREA_BSC : int 
	{  
		 
		IxMLINE_CD = 1,
		IxMLINE_NAME =2,
		IxMAT_AREA =3,		
		IxCS_SIZE =4,  
		IxSIZE_QTY =5,
		IxAREA_START =6, 

	}  


	/// <summary> 
	/// MPS By OP 테이블 인덱스 Enum 
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
		IxTBD_TS_FINISH_YN = 6,


	}  


	/// <summary> 
	/// TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC
	/// </summary> 
	public enum TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC : int 
	{  		  
		 
		IxPLAN_DATE_F =0,
		IxPLAN_DATE_T =1,
		IxBACK_COLOR =2,
		IxAREA_CD =3,  

	}  




	/// <summary> 
	/// SPD_DAILY_WORKSHEET 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPD_DAILY_WORKSHEET_SEARCH_BSC : int 
	{  

		IxLINE_CD		= 1,			 
		IxLINE_NAME		= 2,
		IxMODEL_NAME	= 3,
		IxSTYLE_CD		= 4,		
		IxOBS_ID		= 5,
		IxOBS_TYPE		= 6,
		IxLOT			= 7,  
		IxREQ_NO		= 8,  
		IxOBS_NU		= 9, 
		IxOBS_SEQ_NU	=10, 
		IxDEST			=11, 
		IxMSR_DIV		=12,
		IxRGAC			=13,  
		IxOGAC			=14, 
		IxOP_CD			=15,  
		IxCMP_CD		=16,
		IxDIV			=17,
		IxDIV_DESC		=18, 
		IxMAT_AREA_NAME	=19, 
		IxDAY_SEQ		=20,  
		IxPLAN_YMD		=21,
		IxTOT_QTY		=22,
		IxGEN			=23,
		IxCS_SIZE		=24,
		IxDIR_QTY		=25,

		IxCS_SIZE_START =24,

 
	} 


 
	/// <summary> 
	/// SPD_DAILY_WORKSHEET 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPD_DAILY_WORKSHEET_TS_SEARCH_BSC : int 
	{  

		IxLINE_CD		= 1,			 
		IxLINE_NAME		= 2,
		IxMLINE_CD		= 3,			 
		IxMLINE_NAME	= 4,
		IxMODEL_NAME	= 5,
		IxSTYLE_CD		= 6,		
		IxOBS_ID		= 7,
		IxOBS_TYPE		= 8,
		IxLOT			= 9,  
		IxREQ_NO		=10,  
		IxOBS_NU		=11, 
		IxOBS_SEQ_NU	=12, 
		IxDEST			=13,  
		IxMSR_DIV		=14,
		IxRGAC			=15,  
		IxOGAC			=16, 
		IxOP_CD			=17,  
		IxCMP_CD		=18,
		IxDIV			=19,
		IxDIV_DESC		=20, 
		IxMAT_AREA_NAME	=21, 
		IxDAY_SEQ		=22,  
		IxPLAN_YMD		=23,
		IxINPUT_PRIO	=24,
		IxTOT_QTY		=25,
		IxGEN			=26,
		IxCS_SIZE		=27,
		IxDIR_QTY		=28,

		IxCS_SIZE_START =27,

 
	} 
   

	/// <summary> 
	/// SPD_DAILY_WORKSHEET_TS 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPD_DAILY_WORKSHEET_TS_SUM_SEARCH_BSC : int 
	{  
 
		IxLINE_CD		= 1,			 
		IxLINE_NAME		= 2, 
		IxMODEL_NAME	= 3,
		IxSTYLE_CD		= 4,		
		IxOBS_ID		= 5,
		IxOBS_TYPE		= 6,
		IxLOT			= 7,  
		IxREQ_NO		= 8,
		IxOBS_NU		= 9, 
		IxOBS_SEQ_NU	=10, 
		IxDEST			=11, 
		IxMSR_DIV		=12,
		IxRGAC			=13,  
		IxOGAC			=14, 
		IxOP_CD			=15,  
		IxCMP_CD		=16,
		IxDIV			=17,
		IxDIV_DESC		=18, 
		IxMAT_AREA_NAME	=19, 
		IxDAY_SEQ		=20,  
		IxPLAN_YMD		=21,
		IxINPUT_PRIO	=22,
		IxTOT_QTY		=23,
		IxGEN			=24,
		IxCS_SIZE		=25,
		IxDIR_QTY		=26,

		IxCS_SIZE_START =25,

 

	}  


	/// <summary> 
	/// SPD_DAILY_WORKSHEET_TS 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPD_JIT_REQ_LIST_SEARCH_BSC : int 
	{  
 
		IxLINE_CD			= 1,
		IxLINE_NAME			= 2,
		IxMLINE_CD			= 3,
		IxMLINE_NAME		= 4,
		IxMODEL_NAME		= 5,
		IxSTYLE_CD			= 6,
		IxOBS_ID			= 7,
		IxOBS_TYPE			= 8,
		IxLOT				= 9,
		IxREQ_NO			=10, 
		IxOBS_NU			=11,  
		IxOBS_SEQ_NU		=12,  
		IxDEST				=13,  
		IxMSR_DIV		=14,
		IxRGAC				=15,  
		IxOGAC				=16,  
		IxJIT_REQ_TYPE		=17,
		IxOP_STR_YMD		=18,
		IxDIR_REQ_YMD		=19, 
		IxPLAN_STATUS_DESC  =20,
		IxCMP_CD			=21,
		IxSTR_OP_CD			=22, 
		IxEND_OP_CD			=23,
		IxTS_FINISH_YN		=24,
		IxTOT_QTY			=25,
		IxGEN				=26,
		IxCS_SIZE			=27,
		IxSIZE_QTY			=28,

		IxCS_SIZE_START		=27, 


	}  

  
	

	/// <summary> 
	/// SPO_MPS_HISTORY 테이블 인덱스 Enum
	/// </summary> 
	public enum TBSPO_MPS_HISTORY_BSC : int 
	{  
 
		IxTREE_LEVEL		= 1,
		IxTREE_DESC			= 2,
		IxFACTORY			= 3,
		IxLOT_NO			= 4,
		IxLOT_SEQ			= 5,
		IxLOT				= 6,
		IxDAY_SEQ			= 7,
		IxVERSION			= 8,
		IxACTION_FLAG		= 9,
		IxACTION_FLAG_1		=10,  
		IxACTION_DESC		=11,
		IxLINE_CD			=12,
		IxLINE_NAME			=13, 
		IxFIRST_YMD			=14,
		IxPLAN_YMD			=15,
		IxSIZE_QTY			=16, 
		IxLOSS_QTY			=17,
		IxDIR_QTY			=18,
		IxPLAN_STATUS		=19,
		IxPLAN_STATUS_DESC	=20,
		IxSHORT_YN			=21,
		IxTS_FINISH_YN		=22,
		IxREMARKS			=23,
		IxUPD_YMD			=24,
		IxUPD_USER          =25,
		IxDAY_SEQ_SORT		=26, 
		IxVERSION_SORT		=27, 



	}  
  

	/// <summary> 
	/// SVM_SM_PURCHASE_ORDER 테이블 인덱스 Enum
	/// </summary> 
	public enum TBVM_SM_PURCHASE_ORDER : int 
	{  
 
		IxT_LEVEL			= 1,
		IxFACTORY			= 2,
		IxPUR_NO			= 3,
		IxPUR_SEQ			= 4,
		IxPUR_YMD			= 5,
		IxMODEL_CD			= 6,
		IxMODEL_NM			= 7,
		IxSEASON			= 8,
		IxSEASON_YEAR		= 9,
		IxCOMPONENT_M_NM	=10,  
		IxCOMPONENT_S_NM	=11,
		IxITEM_NM			=12,
		IxSIZE_DESC			=13, 
		IxSPEC				=14,
		IxUNIT				=15,
		IxRE_QTY			=16, 
		IxPUR_QTY			=17,
		IxCURRENCY			=18,
		IxUNIT_PRICE		=19,
		IxAMOUNT			=20,
		IxPUR_POSE			=21,
		IxETA				=22,
		IxCBD_YN			=23,
		IxCBD_AMOUNT		=24,
		IxMODEL_DESC		=25,
		IxLINE_CD			=26,
		IxREMARKS			=27,

	}  

	/// <summary> 
	/// SVM_SM_PURCHASE_SEARCH 테이블 인덱스 Enum
	/// </summary> 
	public enum TBVM_SM_PURCHASE_SEARCH : int 
	{  
 
		IxT_LEVEL			= 1,
		IxCHK				= 2,
		IxFACTORY			= 3,
		IxMODEL_CD			= 4,
		IxMODEL_NM			= 5,
		IxSEASON			= 6,
		IxSEASON_YEAR		= 7,
		IxCOMPONENT_M_NM	= 8,  
		IxCOMPONENT_S_NM	= 9,
		IxITEM_NM			=10,
		IxSIZE_DESC			=11, 
		IxSPEC				=12,
		IxUNIT				=13,
		IxRE_QTY			=14, 
		IxPUR_QTY			=15,
		IxCURRENCY			=16,
		IxUNIT_PRICE		=17,
		IxAMOUNT			=18,
		IxCBD_YN			=19,
		IxCBD_AMOUNT		=20,		
		IxPUR_POSE			=21,
		IxREMARKS			=22,

	}  

}
