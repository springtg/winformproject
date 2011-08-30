using System;

namespace FlexMRP.ClassLib
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

	#region 조남숙 추가

	/// <summary> 
	/// SCM_CUST 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSCM_CUST : int 
	{ 
		IxMaxCt				= 40,	// 인덱스 Count 
		IxFACTORY			=1,		// 공장코드			:VARCHAR2(5) 
		IxCUST_CD			=2,		// 거래처코드		:VARCHAR2(10) 
		IxENTPREGNO			=3,		// 사업자등록번호	:VARCHAR2(13) 
		IxUPCUST_CD			=4,		// 상위거래처코드	:VARCHAR2(10) 
		IxCUST_NAME			=5,		// 거래처명			:VARCHAR2(100) 
		IxCUST_OMITNM		=6,		// 생략명			:VARCHAR2(100) 
		IxLAWREGNO			=7,		// 법인등록번호		:VARCHAR2(13) 
		IxREPNM				=8,		// 대표자성명		:VARCHAR2(100) 
		IxREPJUMIN			=9,		// 대표자주민번호	:VARCHAR2(13) 
		IxUPTNM				=10,	// 업태명			:VARCHAR2(30) 
		IxITEMNM			=11,	// 종목명			:VARCHAR2(30) 
		IxAGTTYPE			=12,	// 거래처유형		:VARCHAR2(20) 
		IxCASHMOVEBANKNO	=13,	// 현금계좌이체은행	:VARCHAR2(10) 
		IxCASHACCOUNTNO		=14,	// 현금계좌번호		:VARCHAR2(20) 
		IxCASHACCOUNTNM		=15,	// 현금계좌명		:VARCHAR2(10) 
		IxBILLMOVEBANKNO	=16,	// 어음계좌이체은행	:VARCHAR2(10) 
		IxBILLACCOUNTNO		=17,	// 어음계좌번호		:VARCHAR2(20) 
		IxBILLACCOUNTNM		=18,	// 어음계좌명		:VARCHAR2(10) 
		IxADDR				=19,	// 주소				:VARCHAR2(200) 
		IxTELNO				=20,	// 전화번호			:VARCHAR2(20) 
		IxFAXNO				=21,	// 팩스번호			:VARCHAR2(20) 
		IxZIPNO1			=22,	// 우편번호1		:VARCHAR2(13) 
		IxZIPNO2			=23,	// 우편번호2		:VARCHAR2(13) 
		IxPAYTYPE			=24,	// 지불방법			:VARCHAR2(30) 
		IxPAYTIME			=25,	// 지불시기			:VARCHAR2(10) 
		IxWEB_CUST_CD		=26,	// WEB거래처코드	:VARCHAR2(10) 
		IxWEB_PASS			=27,	// WEB비밀번호		:VARCHAR2(20) 
		IxEMAIL				=28,	// 이메일			:VARCHAR2(30) 
		IxBAR_YN			=29,	// 바코드사용유무	:VARCHAR2(1) 
		IxRETURN_YN			=30,	// 환급유무			:VARCHAR2(1) 
		IxCUST_PUR_TYPE		=31,	// 구매분류			:VARCHAR2(5) 
		IxREMARKS			=32,	// 비고				:VARCHAR2(100) 
		IxTRADE_CUST		=33,	// 무역거래처		:VARCHAR2(30) 
		IxMAN_CUST			=34,	// 업체담당자		:VARCHAR2(30) 
		IxMAN_CHARGE		=35,	// 담당사원			:VARCHAR2(30) 
		IxUSE_YN			=36,	// 사용여부			:VARCHAR2(1) 
		IxSEND_CHK			=37,	// 송신체크			:VARCHAR2(1) 
		IxSEND_YMD			=38,	// 송신일			:DATE(7) 
		IxUPD_USER			=39,	// 수정자			:VARCHAR2(10) 
		IxUPD_YMD			=40,	// 수정일			:DATE(7) 
	}  

	/// <summary> 
	/// SCM_COLUMN 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSCM_COLUMN : int 
	{ 
		IxMaxCt				= 17,	// 인덱스 Count 
		IxFACTORY			=1,		// 공장				:VARCHAR2(5) 
		IxDB_USER			=2,		// DB유저			:VARCHAR2(25) 
		IxTABLE_NAME		=3,		// 테이블명			:VARCHAR2(50) 
		IxCOL_NAME			=4,		// 컬럼명			:VARCHAR2(50) 
		IxCOL_ORDER			=5,		// 컬럼 순번		:NUMBER(22) 
		IxENG_NAME			=6,		// 영문명			:VARCHAR2(100) 
		IxLOCAL_NAME		=7,		// 자국어명			:VARCHAR2(100) 
		IxWIDTH				=8,		// 컬럼 너비		:NUMBER(22) 
		IxLOCK_YN			=9,		// 에디트 가능 여부	:VARCHAR2(1) 
		IxVISIBLE_YN		=10,	// VISIBLE 여부		:VARCHAR2(1) 
		IxNULL_YN			=11,	// 필수입력 여부	:VARCHAR2(1) 
		IxCELLTYPE			=12,	// 셀타입			:VARCHAR2(10) 
		IxDATA_LIST_TYPE	=13,	// 셀타입이 콤보박스일때 공통코드 또는 쿼리 이용 여부 설정 (공통코드 : 0, 쿼리 : 1)	:VARCHAR2(1) 
		IxDATA_LIST_CD		=14,	// DATA_LIST_TYPE = 0 일때 공통코드 기재	:VARCHAR2(10) 
		IxREMARKS			=15,	// 비고				:VARCHAR2(100) 
		IxUPD_USER			=16,	// 작성자			:VARCHAR2(10) 
		IxUPD_YMD			=17,	// 작성일자			:DATE(7) 
	}  

	

	/// <summary> 
	/// SCM_MENU_SOS 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSCM_MENU_SOS : int 
	{ 
		IxMaxCt				= 15,	// 인덱스 Count 
		IxFACTORY			=1,		// 공장코드		:VARCHAR2(5) 
		IxMENU_PG			=2,		// 프로그램ID	:VARCHAR2(10) 
		IxSEQ				=3,		// 순번			:NUMBER(22) 
		IxREQ_YMD			=4,		// 요청일자		:DATE(7) 
		IxREQ_USER			=5,		// 요청사용자	:VARCHAR2(10) 
		IxREQ_TYPE			=6,		// 요청구분		:VARCHAR2(10) 
		IxREQ_CONTENTS		=7,		// 요청내용		:VARCHAR2(500) 
		IxDEV_USER			=8,		// 개발담당		:VARCHAR2(10) 
		IxMAINT_USER		=9,		// 유지보수담당	:VARCHAR2(10) 
		IxSOLVE_YMD			=10,	// 해결일자		:DATE(7) 
		IxSOLVE_USER		=11,	// 해결담당자	:VARCHAR2(10) 
		IxSOLVE_CONTENTS	=12,	// 해결내용		:VARCHAR2(500) 
		IxSTATUS			=13,	// 상태			:VARCHAR2(1) 
		IxUPD_YMD			=14,	// 수정일		:DATE(7) 
		IxUPD_USER			=15,	// 수정자		:VARCHAR2(10) 
	}  



	public enum TBSBC_ITEM_GROUP : int 
	{ 
		IxMaxCt				= 15,	// 인덱스 Count 
		IxDIVISION			= 0,	// SAVE 코드
		IxGROUP_NAME		=1,		// 분류명		:VARCHAR2(50) 
		IxGROUP_CD			=2,		// 분류코드		:VARCHAR2(10) 
		IxGROUP_LEVEL		=3,		// 분류레벨		:NUMBER(22) 
		IxGROUP_TYPE		=4,		// 분류구분		:VARCHAR2(2) 
		IxGROUP_L			=5,		// 대분류		:VARCHAR2(2) 
		IxGROUP_M			=6,		// 중분류		:VARCHAR2(2) 
		IxGROUP_S			=7,		// 소분류		:VARCHAR2(2) 
		IxATTRIBUTE_MODEL	=8,		
		IxATTRIBUTE_STYLE	=9,	
		IxATTRIBUTE_CMP		=10,	
		IxATTRIBUTE_GENDER  =11,	
		IxATTRIBUTE			=12,	
		IxUSE_YN			=13,	// 사용여부		:VARCHAR2(1) 
		IxMAN_CHARGE_DS		=14,	// 담당자-DS	:VARCHAR2(10) 
		IxMAN_CHARGE_QD		=15,	// 담당자-QD	:VARCHAR2(10) 
		IxMAN_CHARGE_VJ		=16,	// 담당자-VJ	:VARCHAR2(10) 
		IxSEND_CHK			=17,	// 송신체크		:VARCHAR2(1) 
		IxSEND_YMD			=18,	// 송신일		:DATE(7) 
		IxUPD_USER			=19,	// 수정자		:VARCHAR2(10) 
		IxUPD_YMD			=20,	// 수정일		:DATE(7) 
	}  



	public enum TBSBC_ITEM_GROUP_SEARCH : int 
	{ 
		 
		IxDIVISION			=0,	    // SAVE 코드
		IxGROUP_NAME		=1,		// 분류명		:VARCHAR2(50) 
		IxGROUP_CD			=2,		// 분류코드		:VARCHAR2(10) 
		IxGROUP_LEVEL		=3,		// 분류레벨		:NUMBER(22) 
		IxGROUP_TYPE		=4,		// 분류구분		:VARCHAR2(2) 
		IxGROUP_L			=5,		// 대분류		:VARCHAR2(2) 
		IxGROUP_M			=6,		// 중분류		:VARCHAR2(2) 
		IxGROUP_S			=7,		// 소분류		:VARCHAR2(2)  
		IxMAN_CHARGE_DS		=8,	    // 담당자-DS	:VARCHAR2(10) 
		IxMAN_CHARGE_QD		=9,	    // 담당자-QD	:VARCHAR2(10) 
		IxMAN_CHARGE_VJ		=10,	// 담당자-VJ	:VARCHAR2(10)  

	}


	/// <summary> 
	/// SBC_ITEM 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_ITEM : int 
	{ 
		IxMaxCt					=  68,		// 인덱스 Count 
		IxDIVISION				=   0,		// SAVE 코드
		IxITEM_CD				=   1,		// 품목코드			:VARCHAR2(10) 
		IxGROUP_CD				=   2,		// 그룹코드			:VARCHAR2(10) 
		IxITEM_NAME1			=   3,		// 품목명1			:VARCHAR2(100) 
		IxITEM_NAME2			=   4,		// 품목명2			:VARCHAR2(100) 
		IxITEM_NAME3			=   5,		// 품목명3			:VARCHAR2(100) 
		IxITEM_NAME4			=   6,		// 품목명4			:VARCHAR2(100) 
		IxITEM_NAME5			=   7,		// 품목명5			:VARCHAR2(100) 
		IxSIZE_YN				=   8,		// 사이즈자재여부	:VARCHAR2(1) 
		IxUSE_YN				=   9,		// USE_YN 			:VARCHAR2(1) 
		IxREP_ITEM_CD			=  10,		// 대표품목코드		:VARCHAR2(10) 
		IxCOPY_FROM				=  11,		// 복사출처 		:VARCHAR2(10) 
		IxREMARK				=  12,		// 비고				:VARCHAR2(500) 
		IxMNG_UNIT				=  13,		// 관리단위			:VARCHAR2(10) 
		IxPK_QTY				=  14,		// PK수량			:NUMBER(22) 
		IxSPEC_TYPE				=  15,		// Spec 단위		:VARCHAR2(70) 
		IxSTYLE_ITEM_DIV		=  16,		// 스타일자재분류	:VARCHAR2(10) 
		IxBUY_DIV				=  17,		// 구매분류			:VARCHAR2(10) 
		IxSTOCK_UNIT			=  18,		// 재고단위			:VARCHAR2(10) 
		IxITEM_CONV				=  19,		// 환산계수			:NUMBER(22) 
		IxABC_DIV				=  20,		// ABC분류			:VARCHAR2(10) 
		IxINSP_YN				=  21,		// 검사여부			:VARCHAR2(1) 
		IxPUR_PRICE				=  22,		// 구매단가			:NUMBER(22) 
		IxPUR_CURRENCY			=  23,		// 구매화폐			:VARCHAR2(10) 
		IxCBD_PRICE				=  24,		// CBD단가			:NUMBER(22) 
		IxCBD_CURRENCY			=  25,		// CBD화폐			:VARCHAR2(10) 
		IxPROCESSING_YN			=  26,		// 임가공여부		:VARCHAR2(1) 
		IxPROCESSING_PRICE		=  27,		// 임가공비용		:NUMBER(22) 
		IxPROCESSING_CURRENCY	=  28,		// 임가공 화폐단위	:VARCHAR2(10) 
		IxCUS_CD_DS				=  29,		// 주거래처코드-DS	:VARCHAR2(10) 
		IxCUS_CD_QD				=  30,		// 주거래처코드-QD	:VARCHAR2(10) 
		IxCUS_CD_VJ				=  31,		// 주거래처코드-VJ	:VARCHAR2(10) 
		IxMAN_CHARGE_DS			=  32,		// 담당자-DS		:VARCHAR2(10) 
		IxMAN_CHARGE_QD			=  33,		// 담당자-QD		:VARCHAR2(10) 
		IxMAN_CHARGE_VJ			=  34,		// 담당자-VJ		:VARCHAR2(10) 
		IxIMPORT_DS				=  35,		// 수입자재여부-DS	:VARCHAR2(1) 
		IxIMPORT_QD				=  36,		// 수입자재여부-QD	:VARCHAR2(1) 
		IxIMPORT_VJ				=  37,		// 수입자재여부-VJ	:VARCHAR2(1) 
		IxCOST_YN				=  38,		// 원가관리여부		:VARCHAR2(1) 
		IxACC_DIV_YN			=  39,		// 회계분류사용여부	:VARCHAR2(1) 
		IxACC_DIV_DS			=  40,		// 회계분류-DS		:VARCHAR2(10) 
		IxACC_DIV_QD			=  41,		// 회계분류-QD		:VARCHAR2(10) 
		IxACC_DIV_VJ			=  42,		// 회계분류-VJ		:VARCHAR2(10) 
		IxLONE_YN				=  43,		// 장/단기자재 구분	:VARCHAR2(1) 
		IxDL_DAYS_DS			=  44,		// 납기소요일-DS	:NUMBER(22) 
		IxDL_DAYS_QD			=  45,		// 납기소요일-QD	:NUMBER(22) 
		IxDL_DAYS_VJ			=  46,		// 납기소요일-VJ	:NUMBER(22) 
		IxSAFE_AMT_DS			=  47,		// 안전재고량-DS	:NUMBER(22) 
		IxSAFE_AMT_QD			=  48,		// 안전재고량-QD	:NUMBER(22) 
		IxSAFE_AMT_VJ			=  49,		// 안전재고량-VJ	:NUMBER(22) 
		IxLIFE_YN				=  50,		// 악성재고 유무	:VARCHAR2(1) 
		IxLIFE_DAY				=  51,		// 악성재고 일수	:NUMBER(22) 
		IxIN_WH_CD				=  52,		// 입고창고			:VARCHAR2(10) 
		IxOUT_WH_CD				=  53,		// 출고창고			:VARCHAR2(10) 
		IxPUR_LOSS_RATE			=  54,		// PUR_LOSS_RATE 	:NUMBER(22) 
		IxOUT_LOSS_RATE			=  55,		// 출고 Loss		:NUMBER(22) 
		IxSHIP_LOSS_RATE		=  56,		// 선적 Loss		:NUMBER(22) 
		IxPUR_LOT_AMT			=  57,		// 발주LOT			:NUMBER(22) 
		IxPROD_IN_LOT			=  58,		// 생산불출LOT		:NUMBER(22) 
		IxMCS_NO				=  59,		// MCS 번호			:VARCHAR2(20) 
		IxHS_NO					=  60,		// HS_NO			:VARCHAR2(20) 
		IxCBM					=  61,		// CBM				:NUMBER(22) 
		IxGROSS_WEIGHT			=  62,		// 중량(Gross)		:VARCHAR2(100) 
		IxNET_WEIGHT			=  63,		// 중량(Net)		:VARCHAR2(100) 
		IxVOLUME				=  64,		// 부피				:VARCHAR2(100) 
		IxLENGTH				=  65,		// 길이				:VARCHAR2(100) 
		IxWIDTH					=  66,		// 폭				:VARCHAR2(100) 
		IxHEIGHT				=  67,		// 높이				:VARCHAR2(100) 
		IxUPD_USER				=  68,		// 수정일			:DATE(7) 
		IxUPD_YMD				=  69 		// 수정자			:VARCHAR2(10) 
	}								  




	/// <summary> 
	/// SBC_ITEM 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_ITEM_WITH_CUSTNAME : int 
	{ 
		IxMaxCt					=  68,		// 인덱스 Count 
		IxDIVISION				=   0,		// SAVE 코드
		IxITEM_CD				=   1,		// 품목코드			:VARCHAR2(10) 
		IxGROUP_CD				=   2,		// 그룹코드			:VARCHAR2(10) 
		IxITEM_NAME1			=   3,		// 품목명1			:VARCHAR2(100) 
		IxITEM_NAME2			=   4,		// 품목명2			:VARCHAR2(100) 
		IxITEM_NAME3			=   5,		// 품목명3			:VARCHAR2(100) 
		IxITEM_NAME4			=   6,		// 품목명4			:VARCHAR2(100) 
		IxITEM_NAME5			=   7,		// 품목명5			:VARCHAR2(100) 
		IxSIZE_YN				=   8,		// 사이즈자재여부	:VARCHAR2(1) 
		IxUSE_YN				=   9,		// USE_YN 			:VARCHAR2(1) 
		IxREP_ITEM_CD			=  10,		// 대표품목코드		:VARCHAR2(10) 
		IxCOPY_FROM				=  11,		// 복사출처 		:VARCHAR2(10) 
		IxREMARK				=  12,		// 비고				:VARCHAR2(500) 
		IxMNG_UNIT				=  13,		// 관리단위			:VARCHAR2(10) 
		IxPK_QTY				=  14,		// PK수량			:NUMBER(22) 
		IxSPEC_TYPE				=  15,		// Spec 단위		:VARCHAR2(70) 
		IxSTYLE_ITEM_DIV		=  16,		// 스타일자재분류	:VARCHAR2(10) 
		IxBUY_DIV				=  17,		// 구매분류			:VARCHAR2(10) 
		IxSTOCK_UNIT			=  18,		// 재고단위			:VARCHAR2(10) 
		IxITEM_CONV				=  19,		// 환산계수			:NUMBER(22) 
		IxABC_DIV				=  20,		// ABC분류			:VARCHAR2(10) 
		IxINSP_YN				=  21,		// 검사여부			:VARCHAR2(1) 
		IxPUR_PRICE				=  22,		// 구매단가			:NUMBER(22) 
		IxPUR_CURRENCY			=  23,		// 구매화폐			:VARCHAR2(10) 
		IxCBD_PRICE				=  24,		// CBD단가			:NUMBER(22) 
		IxCBD_CURRENCY			=  25,		// CBD화폐			:VARCHAR2(10) 
		IxPROCESSING_YN			=  26,		// 임가공여부		:VARCHAR2(1) 
		IxPROCESSING_PRICE		=  27,		// 임가공비용		:NUMBER(22) 
		IxPROCESSING_CURRENCY	=  28,		// 임가공 화폐단위	:VARCHAR2(10) 
		IxCUS_CD_DS				=  29,		// 주거래처코드-DS	:VARCHAR2(10) 
		IxCUS_CD_QD				=  30,		// 주거래처코드-QD	:VARCHAR2(10) 
		IxCUS_CD_VJ				=  31,		// 주거래처코드-VJ	:VARCHAR2(10) 
		
		IxCUS_NAME_DS			=  32,		// 주거래처코드-DS	:VARCHAR2(10) 
		IxCUS_NAME_QD			=  33,		// 주거래처코드-QD	:VARCHAR2(10) 
		IxCUS_NAME_VJ			=  34,		// 주거래처코드-VJ	:VARCHAR2(10) 
		
		IxMAN_CHARGE_DS			=  35,		// 담당자-DS		:VARCHAR2(10) 
		IxMAN_CHARGE_QD			=  36,		// 담당자-QD		:VARCHAR2(10) 
		IxMAN_CHARGE_VJ			=  37,		// 담당자-VJ		:VARCHAR2(10) 
		IxIMPORT_DS				=  38,		// 수입자재여부-DS	:VARCHAR2(1) 
		IxIMPORT_QD				=  39,		// 수입자재여부-QD	:VARCHAR2(1) 
		IxIMPORT_VJ				=  40,		// 수입자재여부-VJ	:VARCHAR2(1) 
		IxCOST_YN				=  41,		// 원가관리여부		:VARCHAR2(1) 
		IxACC_DIV_YN			=  42,		// 회계분류사용여부	:VARCHAR2(1) 
		IxACC_DIV_DS			=  43,		// 회계분류-DS		:VARCHAR2(10) 
		IxACC_DIV_QD			=  44,		// 회계분류-QD		:VARCHAR2(10) 
		IxACC_DIV_VJ			=  45,		// 회계분류-VJ		:VARCHAR2(10) 
		IxLONE_YN				=  46,		// 장/단기자재 구분	:VARCHAR2(1) 
		IxDL_DAYS_DS			=  47,		// 납기소요일-DS	:NUMBER(22) 
		IxDL_DAYS_QD			=  48,		// 납기소요일-QD	:NUMBER(22) 
		IxDL_DAYS_VJ			=  49,		// 납기소요일-VJ	:NUMBER(22) 
		IxSAFE_AMT_DS			=  50,		// 안전재고량-DS	:NUMBER(22) 
		IxSAFE_AMT_QD			=  51,		// 안전재고량-QD	:NUMBER(22) 
		IxSAFE_AMT_VJ			=  52,		// 안전재고량-VJ	:NUMBER(22) 
		IxLIFE_YN				=  53,		// 악성재고 유무	:VARCHAR2(1) 
		IxLIFE_DAY				=  54,		// 악성재고 일수	:NUMBER(22) 
		IxIN_WH_CD				=  55,		// 입고창고			:VARCHAR2(10) 
		IxOUT_WH_CD				=  56,		// 출고창고			:VARCHAR2(10) 
		IxPUR_LOSS_RATE			=  57,		// PUR_LOSS_RATE 	:NUMBER(22) 
		IxOUT_LOSS_RATE			=  58,		// 출고 Loss		:NUMBER(22) 
		IxSHIP_LOSS_RATE		=  59,		// 선적 Loss		:NUMBER(22) 
		IxPUR_LOT_AMT			=  60,		// 발주LOT			:NUMBER(22) 
		IxPROD_IN_LOT			=  61,		// 생산불출LOT		:NUMBER(22) 
		IxMCS_NO				=  62,		// MCS 번호			:VARCHAR2(20) 
		IxHS_NO					=  63,		// HS_NO			:VARCHAR2(20) 
		IxCBM					=  64,		// CBM				:NUMBER(22) 
		IxGROSS_WEIGHT			=  65,		// 중량(Gross)		:VARCHAR2(100) 
		IxNET_WEIGHT			=  66,		// 중량(Net)		:VARCHAR2(100) 
		IxVOLUME				=  67,		// 부피				:VARCHAR2(100) 
		IxLENGTH				=  68,		// 길이				:VARCHAR2(100) 
		IxWIDTH					=  69,		// 폭				:VARCHAR2(100) 
		IxHEIGHT				=  70,		// 높이				:VARCHAR2(100) 
		IxUPD_USER				=  71,		// 수정일			:DATE(7) 
		IxUPD_YMD				=  72, 		// 수정자			:VARCHAR2(10) 
	}					




	/// <summary> 
	/// SBC_ITEM 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_ITEM_POP : int 
	{ 
		IxMaxCt					=  68,		// 인덱스 Count 
		IxITEM_CD				=   1,		// 품목코드			:VARCHAR2(10) 
		IxGROUP_CD				=   2,		// 그룹코드			:VARCHAR2(10) 
		IxITEM_NAME1			=   3,		// 품목명1			:VARCHAR2(100) 
		IxITEM_NAME2			=   4,		// 품목명2			:VARCHAR2(100) 
		IxITEM_NAME3			=   5,		// 품목명3			:VARCHAR2(100) 
		IxITEM_NAME4			=   6,		// 품목명4			:VARCHAR2(100) 
		IxITEM_NAME5			=   7,		// 품목명5			:VARCHAR2(100) 
		IxSIZE_YN				=   8,		// 사이즈자재여부	:VARCHAR2(1) 
		IxMNG_UNIT				=   9,		// 관리단위			:VARCHAR2(10) 
		IxSTYLE_ITEM_DIV		=  10,		// 스타일자재분류	:VARCHAR2(10) 
		IxPUR_LOSS_RATE			=  11,		// PUR_LOSS_RATE 	:NUMBER(22) 
		IxOUT_LOSS_RATE			=  12,		// 출고 Loss		:NUMBER(22) 
		IxSHIP_LOSS_RATE		=  13,		// 선적 Loss		:NUMBER(22) 
	}								  


	/// <summary> 
	/// SBC_BOM_TEMPLATE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_BOM_TEMPLATE : int 
	{ 
		 
		IxDIVISION				= 0,		// SAVE 코드
		IxTEMPLATE_TREE_CD		= 1,		// 템플릿구조코드	:VARCHAR2(5) 
		IxTEMPLATE_LEVEL		= 2,		// 템플릿레벨		:NUMBER(22) 
		IxTEMPLATE_STAGE		= 3,		// 템플릿레벨단계	:NUMBER(22) 
		IxTEMPLATE_TREE_NAME	= 4,		// 템플릿구조명칭	:VARCHAR2(100) 
		IxTEMPLATE_CD			= 5,		// 템플릿코드		:VARCHAR2(10) 
		IxTEMPLATE_NAME			= 6,		// 템플릿이름		:VARCHAR2(30) 
		IxPROPERTY1				= 7,		// 속성1			:VARCHAR2(1) 
		IxPROPERTY2				= 8,		// 속성2			:VARCHAR2(1) 
		IxPROPERTY3				= 9,		// 속성3			:VARCHAR2(1) 
		IxPROPERTY4				= 10,		// 속성4			:VARCHAR2(1) 
		IxPROPERTY5				= 11,		// 속성5			:VARCHAR2(10) 
		IxTEMPLATE_KEY		    = 12,		
		IxREMARK				= 13,		// 설명				:VARCHAR2(100) 
		IxSEND_CHK				= 14,		// 송신체크			:VARCHAR2(10) 
		IxSEND_DATE				= 15,		// 송신일			:DATE(7) 
		IxUPD_USER				= 16,		// 수정자			:VARCHAR2(10) 
		IxUPD_YMD				= 17,		// 수정일			:DATE(7)

		IxSIZE_YN               = 18,
		IxMNG_UNIT              = 19,
		IxCS_SIZE_START         = 20,
	}  





	/// <summary> 
	/// SBC_BOM_TEMPLATE_TAIL 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_BOM_TEMPLATE_TAIL : int 
	{ 
		 
		IxTEMPLATE_TREE_CD  = 0,		 
		IxTEMPLATE_LEVEL	= 1,		
		IxCS_SIZE_FROM	    = 2,		
		IxCS_SIZE_TO		= 3,		
		IxSIZE_YN			= 4,		
		IxMNG_UNIT			= 5,		
		IxREMARKS			= 6,		
		IxSEND_CHK			= 7,		
		IxSEND_YMD			= 8,		
		IxUPD_YMD			= 9,		
		IxUPD_USER			= 10,		
		 
	}  


 
	/// <summary> 
	/// SBC_YIELD_INFO 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_YIELD_INFO : int 
	{ 
		IxMaxCt					= 23,		
		IxDIVISION				=  0,		
		IxLEVEL1				=  1,		
		IxKEY1					=  2,		
		IxTYPE_DIVISION         =  3,
		IxTREE					=  4,		
		IxFACTORY				=  5,		
		IxSTYLE_CD				=  6,		
		IxSEMI_GOOD_CD			=  7,		
		IxCOMPONENT_CD			=  8,		
		IxCOMPONENT_NAME		=  9,		
		IxTEMPLATE_SEQ			= 10,		
		IxTEMPLATE_LEVEL		= 11,		
		IxTEMPLATE_TREE_CD		= 12,		
		IxTEMPLATE_TREE_NAME	= 13,		
		IxTEMPLATE_CD			= 14,		
		IxITEM_CD				= 15,		
		IxITEM_NAME				= 16,		
		IxSPEC_CD				= 17,		
		IxSPEC_NAME			    = 18,		
		IxCOLOR_CD				= 19,		
		IxCOLOR_NAME			= 20,		
		IxUNIT					= 21,		
		IxSIZE_YN				= 22,		

		IxSRF_NO				= 23,
		IxBOM_ID				= 24,
		IxSRF_SEQ_MAX			= 25,
		IxSRF_CDC_DEV			= 26, 
		 
		IxCS_SIZE_START         = 27, 




		// table index
		IxCOL_NUM               = 26,	
		IxCS_SIZE               = 27,
		IxYIELD_VALUE			= 28, 

		


	} 
	 
 

	/// <summary> 
	/// SBC_YIELD_HISTORY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_YIELD_HISTORY : int 
	{   
		IxLEVEL1				= 1,		
		IxKEY1					= 2,		
		IxKEY2                  = 3,
		IxTYPE_DIVISION         = 4,
		IxTREE					= 5,		
		IxSPEC_NAME			    = 6,		
		IxCOLOR_NAME			= 7,		
		IxUNIT					= 8,		
		IxSIZE_YN				= 9,		
		IxCS_SIZE_START         = 10, 

		// table index
		IxCOL_NUM               = 9,	
		IxCS_SIZE               = 10,
		IxYIELD_VALUE			= 11, 
		


	} 


 
	public enum TBSBC_YIELD_INFO_SHIPPING : int
	{
		IxMaxCt = 29,	// 인덱스 Count
		IxLEVEL1 = 1, 	//   : ()
		IxKEY1 = 2, 	//   : ()
		IxTYPE_DIVISION = 3, 	//   : ()
		IxSHIP_YN = 4, 	//   : VARCHAR2(1)
		IxPUR_SHIP_YN = 5, 	//   : VARCHAR2(1)
		IxPROD_YN = 6, 	//   : VARCHAR2(1)
		IxCOMMON_YN = 7, 	//   : VARCHAR2(1)
		IxITEM = 8, 	//   : ()
		IxFACTORY = 9, 	//   : VARCHAR2(5)
		IxSTYLE_CD = 10, 	//   : VARCHAR2(9)
		IxSEMI_GOOD_CD = 11, 	//   : VARCHAR2(10)
		IxCOMPONENT_CD = 12, 	//   : VARCHAR2(20)
		IxCOMPONENT_NAME = 13, 	//   : ()
		IxTEMPLATE_SEQ = 14, 	//   : NUMBER(22)
		IxTEMPLATE_LEVEL = 15, 	//   : NUMBER(22)
		IxSPEC_CD = 16, 	//   : VARCHAR2(5)
		IxSPEC_NAME = 17, 	//   : ()
		IxCOLOR_CD = 18, 	//   : VARCHAR2(5)
		IxCOLOR_NAME = 19, 	//   : ()
		IxITEM_CD = 20, 	//   : VARCHAR2(10)
		IxUNIT = 21, 	//   : ()
		IxSTYLE_ITEM_DIV = 22, 	//   : VARCHAR2(10)
		IxPROD_SEMI_GOOD_CD = 23, 	//   : VARCHAR2(10)
		IxPROD_OP_CD = 24, 	//   : VARCHAR2(10)
		IxPROD_LOSS_RATE = 25, 	//   : NUMBER(22)
		IxSEND_CHK = 26, 	//   : VARCHAR2(10)
		IxSEND_DATE = 27, 	//   : ()
		IxUPD_USER = 28, 	//   : VARCHAR2(30)
		IxUPD_YMD = 29 	//   : DATE(7)
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


	
	/// <summary> 
	/// SBC_YIELD_VALUE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_YIELD_VALUE : int 
	{ 
		/* 
		IxMaxCt				= 16,		// 인덱스 Count 
		IxDIVISION			= 0,		// SAVE 코드
		IxFACTORY			= 1,		// 공장코드		:VARCHAR2(5) 
		IxSTYLE_CD			= 2,		// 스타일코드	:VARCHAR2(9) 
		IxSEMI_GOOD_CD		= 3,		// 반제코드		:VARCHAR2(10) 
		IxCOMPONENT_CD		= 4,		// 컴포넌트코드	:VARCHAR2(20) 
		IxTEMPLATE_SEQ		= 5,		// 템플릿위치	:NUMBER(22) 
		IxTEMPLATE_LEVEL	= 6,		// 템플릿레벨	:NUMBER(22) 
		IxCS_SIZE_FROM		= 7,		// 사이즈From	:VARCHAR2(10) 
		IxCS_SIZE_TO		= 8,		// 사이즈To		:VARCHAR2(10) 
		IxVALUE_TYPE		= 8,		// 사이즈To		:VARCHAR2(10) 
		IxSPEC_CD			= 9,		// 스펙코드		:VARCHAR2(10) 
		IxYIELD_E			= 10,		// E채산소요량	:NUMBER(22) 
		IxYIELD_M			= 11,		// M채산소요량	:NUMBER(22) 
		IxSEND_CHK			= 12,		// 송신체크		:VARCHAR2(10) 
		IxSEND_DATE			= 13,		// 송신일		:DATE(7) 
		IxUPD_FACTORY		= 14,		// 수정공장		:VARCHAR2(5) 
		IxUPD_YMD			= 15,		// 수정일		:DATE(7) 
		IxUPD_USER			= 16,		// 수정자		:VARCHAR2(10)  
		*/ 


		IxTEMPLATE_LEVEL    = 0,
		IxITEM_CD           = 1,
		IxCS_SIZE           = 2,
		IxYIELD_VALUE       = 3,
		IxSPEC_CD           = 4,
		IxSPEC_NAME         = 5,
		IxCOL_NUM           = 6,
		IxDIVISION          = 7,


	}  
 

	/// <summary> 
	/// 
	/// </summary> 
	public enum TBSBC_YIELD_VALUE_TREE : int 
	{   

		IxDIVISION			= 0,	// SAVE 코드
		IxFACTORY			= 1,	// 공장코드			:VARCHAR2(5)
		IxSTYLE_CD			= 2,	// 스타일코드		:VARCHAR2(9)
		IxSEMI_GOOD_CD		= 3,	// 반제코드			:VARCHAR2(10) 
		IxCOMPONENT_CD		= 4,	// 컴포넌트코드		:VARCHAR2(20) 
		IxTEMPLATE_SEQ		= 5,	// 템플릿구조코드	:VARCHAR2(10) 
		IxTEMPLATE_LEVEL	= 6,	// 템플릿레벨		:NUMBER(22) 
		IxTEMPLATE_TREE_CD	= 7,	// 템플릿구조명칭	:VARCHAR2(100) 
		IxTEMPLATE_CD		= 8,	// 템플릿코드		:VARCHAR2(10) 
		IxTEMPLATE_NAME		= 9,	// 템플릿이름		:VARCHAR2(30) 
		IxITEM_CD			= 10,	// 품목코드			:VARCHAR2(10) 
		IxITEM_NAME1	    = 11,	// 품목이름			
		IxSPEC_CD			= 12,	// 스펙코드			
		IxSPEC_NAME			= 13,	// 스펙코드			
		IxCOLOR_CD			= 14,	// 칼라코드			
		IxCOLOR_NAME		= 15,	// 칼라코드			
		IxUNIT				= 16,	// 관리단위
		IxSIZE_YN			= 17,	// 사이즈여부

		IxATTRIBUTE         = 18,
		IxPROPERTY5         = 19,
		IxITEM_NAME         = 20,
		IxTEMPLATE_KEY      = 21,

	} 




	/// <summary> 
	/// TBSBC_YIELD_VALUE_POPUP : 채산 입력 팝업창 그리드 인덱스
	/// </summary> 
	public enum TBSBC_YIELD_VALUE_POPUP : int 
	{   
		IxDESCRIPTION      = 1,	 
		IxCS_SIZE_START    = 2, 
	} 



	/// <summary> 
	/// TBSBC_YIELD_VALUE_POPUP : 채산 입력 팝업창 그리드 인덱스
	/// </summary> 
	public enum TBSBC_YIELD_VALUE_SIZE_GROUP : int 
	{   

		IxCS_SIZE_FROM     = 0,	 
		IxCS_SIZE_TO       = 1, 
		IxSPEC_CD          = 2,	 
		IxSPEC_NAME        = 3, 

	}

 



	/// <summary> 
	/// TBSBC_YIELD_VALUE_POPUP : 채산 입력 팝업창 그리드 인덱스
	/// </summary> 
	public enum TBSBC_YIELD_VALUE_TREE_PROCNAME : int 
	{   
		IxITEM_CD          = 0,	 
		IxITEM_NAME1	   = 1, 
		IxITEM_NAME	       = 2,
	} 



	/// <summary> 
	/// SPB_NODE_BOM 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_NODE_TEMPLATE : int 
	{  
  
		IxTEMPLATE_CD 		= 0,		
		IxNODE_CD			= 1,		
		IxLEFT				= 2,		
		IxTOP				= 3,		
		IxALIGNMENT			= 4,		
		IxDASHSTYLE			= 5,		
		IxDRAWCOLOR			= 6,		
		IxDRAWWIDTH			= 7,		
		IxFILLCOLOR			= 8,		
		IxFONT				= 9,	
		IxGRADI_YN			= 10,	
		IxGRADICOLOR		= 11,	
		IxGRADIMODE			= 12,	
		IxHEIGHT			= 13,	
		IxSHADOW			= 14,	
		IxSHAPE				= 15,	
		IxTAG				= 16,	
		IxTEXT				= 17,	
		IxTEXTCOLOR			= 18,	
		IxTOOLTIP			= 19,	
		IxWIDTH				= 20,	 
 
	}  


	/// <summary> 
	/// SPB_LINK_BOM 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_LINK_TEMPLATE : int 
	{ 
		 
		IxORG_NODE			= 0,	
		IxDST_NODE			= 1,	
		IxARROW_DST			= 2,	
		IxARROW_MID			= 3,	
		IxARROW_ORG			= 4,	
		IxDASHSTYLE			= 5,	
		IxDRAWCOLOR			= 6,	
		IxDRAWWIDTH			= 7,	
		IxFONT				= 8,	
		IxJUMP				= 9,
		IxLINE_STYLE		= 10,
		IxLINE_ROUND		= 11,
		IxTAG				= 12,
		IxTEXT				= 13,
		IxTEXTCOLOR			= 14,
		IxTOOLTIP			= 15,  

	}  


	/// <summary> 
	/// SBC_YIELD_TEMPLATE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_YIELD_TEMPLATE : int 
	{ 
		IxDIVISION		 	    = 0,		// SAVE 코드
		IxYIELD_TEMP_CD		    = 1,		// 채산 템플릿구조코드	:VARCHAR2(10) 
		IxTEMPLATE_TREE_CD	    = 2,		// 템플릿구조코드		:VARCHAR2(10) 
		IxTEMPLATE_TREE_NAME	= 3,		 
		IxTEMPLATE_CD			= 4,		// 템플릿코드			:VARCHAR2(50) 
		IxTEMPLATE_LEVEL		= 5,		// 템플릿레벨			:NUMBER(22) 
		IxTEMPLATE_STAGE		= 6,		// 템플릿레벨단계		:NUMBER(22) 
		IxITEM_CD				= 7,		// 품목코드				:VARCHAR2(10) 
		IxITEM_NAME2			= 8,		// 품목이름				:VARCHAR2(100)
		 
	}  



	/// <summary> 
	/// TBSBC_YIELD_VALUE_SRF :  
	/// </summary> 
	public enum TBSBC_YIELD_VALUE_SRF : int 
	{   
	
		IxTBSRF_LEVEL          = 0,
		IxTBPART_NO            = 1, 
		IxTBPART_DESC 		   = 2,
		IxTBITEM_CD 		   = 3,
		IxTBITEM_NAME1 		   = 4,
		IxTBLAMINATION_YN 	   = 5,
		IxTBCOLOR_CD           = 6,
		IxTBCOLOR_DESC         = 7,
		IxTBCOMPONENT_CD       = 8,
		IxTBYIELD_VALUE        = 9,
		IxTBLOAD_UPD_USER      = 10,
		IxTBSRF_SEQ_MAX        = 11,
		IxTBGROUP_DIVIDE_YN    = 12,
		IxTBEXIST_YN           = 13,



		IxTREE_DESC            = 1,
		IxSRF_LEVEL            = 2,
		IxPART_NO			   = 3,
		IxPART_DESC 		   = 4,
		IxITEM_CD 			   = 5,
		IxITEM_NAME1 		   = 6,
		IxLAMINATION_YN		   = 7,
		IxCOLOR_CD             = 8,
		IxCOLOR_DESC           = 9, 
		IxCOMPONENT_CD         = 10,
		IxYIELD_VALUE          = 11,
		IxLOAD_UPD_USER        = 12,
		IxSRF_SEQ_MAX          = 13,
		IxGROUP_DIVIDE_YN      = 14,
		IxEXIST_YN             = 15,




		

	}



	/// <summary> 
	/// TBSBC_YIELD_VALUE_SRF_BATCH :  
	/// </summary> 
	public enum TBSBC_YIELD_VALUE_SRF_BATCH : int 
	{  
  
		IxPART_NO              = 0,
		IxPART_DESC            = 1,
		IxCOMPONENT_CD		   = 2,
		IxITEM_CD 		       = 3,
		IxITEM_NAME1 		   = 4, 
		IxCOLOR_CD             = 5,
		IxCOLOR_DESC           = 6, 

	}



 
	/// <summary> 
	/// TBSBC_YIELD_WARNING :  
	/// </summary> 
	public enum TBSBC_YIELD_WARNING : int 
	{   
	  
		
		IxTBSTYLE_CD           = 0,
		IxTBSTYLE_NAME         = 1,
		IxTBBOM_TREE	       = 2,
		IxTBYIELD_STATUS	   = 3,
		IxTBEXIST_YIELD_YN	   = 4, 
		IxTBCMP_CD	           = 5,
		IxTBEXIST_COUNT	       = 6, 
 


		IxSTYLE_CD             = 1,
		IxSTYLE_NAME           = 2,
		IxBOM_TREE	           = 3,
		IxYIELD_STATUS	       = 4,
		IxEXIST_YIELD_YN	   = 5,
		IxCMP_CD_START         = 6,


	}
 



	/// <summary> 
	/// TBSBC_YIELD_EXCEL_UPLOAD :  
	/// </summary> 
	public enum TBSBC_YIELD_EXCEL_UPLOAD : int 
	{   
	   
		IxEX_COMPONENT          = 0,
		IxEX_MATERIAL           = 1,
		IxEX_SPEC_UNIT	        = 2,
		IxEX_COLOR	            = 3,
		IxEX_COMMON_YIELD_VALUE	= 4,



		IxCOMPONENT             = 1,
		IxMATERIAL              = 2,
		IxSPEC_UNIT	            = 3,
		IxCOLOR	                = 4,
		IxCOMMON_YIELD_VALUE	= 5,
		IxCS_SIZE_START         = 6,


	}
 




	#endregion

	#region 우효동 추가


	/// <summary> 
	/// SBC_COLOR 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_COLOR : int 
	{ 
		IxMaxCt = 9,		// 인덱스 Count 
		IxCOLOR_CD =1,			// Color코드	:VARCHAR2(10) 
		IxCOLOR_NAME =2,			// Color명	:VARCHAR2(120) 
		IxNIKE_CD_YN =3,			// 나이키코드여부	:VARCHAR2(10) 
		IxREMARKS =4,			// 설명	:VARCHAR2(120) 
		IxUSE_YN =5,			// 사용여부	:VARCHAR2(10) 
		IxSEND_CHK =6,			// 송신체크	:VARCHAR2(10) 
		IxSEND_YMD =7,			// 송신일	:DATE(7) 
		IxUPD_USER =8,			// 수정자	:VARCHAR2(10) 
		IxUPD_YMD =9,			// 수정일	:DATE(7) 
	}  

 
	/// <summary> 
	/// SBC_SPEC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_SPEC : int 
	{ 
		IxMaxCt = 7,		// 인덱스 Count 
		IxSPEC_DIV =1,			// 스펙구분
		IxSPEC_CD =2,			// 스펙코드	:VARCHAR2(10) 
		IxSPEC_NAME =3,			// 스펙명	:VARCHAR2(50) 
		IxUSE_YN =4,			// 사용여부	:VARCHAR2(1) 
		IxSEND_CHK =5,			// 송신체크	:VARCHAR2(1) 
		IxSEND_YMD =6,			// 송신일	:DATE(7) 
		IxUPD_USER =7,			// 수정자	:VARCHAR2(10) 
		IxUPD_YMD =8,			// 수정일	:DATE(7) 
	}  


	/// <summary> 
	/// SBC_MCS 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_MCS : int 
	{ 
		IxMaxCt = 9,		// 인덱스 Count 
		IxMCS_CD =1,			// MCS코드	:VARCHAR2(10) 
		IxMCS_NAME =2,			// MCS명	:VARCHAR2(50) 
		IxCMP_CD =3,			// 반제코드	:VARCHAR2(10) 
		IxOP_CD =4,			// 공정코드	:VARCHAR2(10) 
		IxUSE_YN =5,			// 사용여부	:VARCHAR2(1) 
		IxSEND_CHK =6,			// 송신체크	:VARCHAR2(1) 
		IxSEND_YMD =7,			// 송신일	:DATE(7) 
		IxUPD_USER =8,			// 수정자	:VARCHAR2(10) 
		IxUPD_YMD =9,			// 수정일	:DATE(7) 
	}  


	/// <summary> 
	/// SBC_COMPONENT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_COMPONENT : int 
	{ 
		IxMaxCt = 7,		// 인덱스 Count 
		IxCOMPONENT =1,			// 컴포넌트코드	:VARCHAR2(10) 
		IxCOMPONENT_NM =2,			// 컴포넌트명	:VARCHAR2(50) 
		IxUSE_YN =3,			// 사용여부	:VARCHAR2(1) 
		IxSEND_CHK =4,			// 송신체크	:VARCHAR2(1) 
		IxSEND_YMD =5,			// 송신일	:DATE(7) 
		IxUPD_USER =6,			// 수정자	:VARCHAR2(10) 
		IxUPD_YMD =7,			// 수정일	:DATE(7) 
	}  

 

	/// <summary> 
	/// SBC_WAREHOUSE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_WAREHOUSE : int 
	{ 
		IxMaxCt = 9,		// 인덱스 Count 
		IxFACTORY =1,			// 공장코드	:VARCHAR2(5) 
		IxWH_CD =2,			// 창고코드	:VARCHAR2(10) 
		IxWH_NAME =3,			// 창고명	:VARCHAR2(50) 
		IxIN_WH_LOC_CD =4,			// 입고기본위치	:VARCHAR2(10) 
		IxOUT_WH_LOC_CD =5,			// 출고기본위치	:VARCHAR2(10) 
		IxREMARKS =6,			// 설명	:VARCHAR2(100) 
		IxUSE_YN =7,			// 사용여부	:VARCHAR2(1) 
		IxUPD_USER =8,			// 수정자	:VARCHAR2(10) 
		IxUPD_YMD =9,			// 수정일	:DATE(7) 
	}  

	/// <summary> 
	/// SBC_WAREHOUSE_LOC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_WAREHOUSE_LOC : int 
	{ 
		IxMaxCt = 8,		// 인덱스 Count 
		IxFACTORY =1,			// 공장코드	:VARCHAR2(5) 
		IxWH_CD =2,			// 창고코드	:VARCHAR2(10) 
		IxWH_LOC_CD =3,			// 위치코드	:VARCHAR2(10) 
		IxWH_LOC_NAME =4,			// 위치명	:VARCHAR2(50) 
		IxREMARKS =5,			// 설명	:VARCHAR2(100) 
		IxUSE_YN =6,			// 사용여부	:VARCHAR2(1) 
		IxUPD_USER =7,			// 수정자	:VARCHAR2(10) 
		IxUPD_YMD =8,			// 수정일	:DATE(7) 
	}  



	/// <summary> 
	/// SCM_CODE 테이블 인덱스 Enum 
	/// </summary> 
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

	/// <summary> 
	/// SBC_FORMULA 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_FORMULA_HEAD : int 
	{ 
		IxMaxCt = 7,	// 인덱스 Count
		IxFACTORY = 1, 	// 공장코드 : VARCHAR2(10)
		IxFORMULA_YEAR = 2, 	// 연도 : VARCHAR2(4)
		IxSEASON_CD = 3, 	// 시젼코드 : VARCHAR2(2)
		IxSTYLE_CD = 4, 	// Style Cd : VARCHAR2(9)
		IxSTYLE_NM = 5, 	// Style Name : ()
		IxGEN = 6, 	// Gen : ()
		IxSTYLE_CD2 = 7 	// Style2 : ()
	}  

	/// <summary> 
	/// SBC_FORMULA 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_FORMULA_APPLY : int 
	{ 
		IxMaxCt = 6,	// 인덱스 Count
		IxFACTORY = 1, 	// 공장코드 : VARCHAR2(10)
		IxFORMULA_YEAR = 2, 	// 연도 : VARCHAR2(4)
		IxSEASON_CD = 3, 	// 시젼코드 : VARCHAR2(2)
		IxSTYLE_CD = 4, 	// Style Cd : VARCHAR2(9)
		IxSTYLE_NM = 5, 	// Style Name : ()
		IxSEQ = 6, 			// Seq  : ()
	}  

	/// <summary> 
	/// SBC_FORMULA 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_FORMULA : int
	{
		IxMaxCt = 27,	// 인덱스 Count
		IxLEVEL1 = 1, 	// 순위 : ()
		IxKEY1 = 2, 	// 속성키 : ()
		IxKEY2 = 3, 	// 속성키 : ()
		IxFACTORY = 4, 	// 공장코드 : VARCHAR2(10)
		IxSEQ = 5, 	// Seq : NUMBER(22)
		IxFORMULA_YEAR = 6, 	// 연도 : VARCHAR2(4)
		IxSEASON_CD = 7, 	// 시젼코드 : VARCHAR2(2)
		IxSTYLE_CD = 8, 	// Style Cd : VARCHAR2(9)
		IxMCS_NM = 9, 	//   : ()
		IxMCS_COLOR_NM = 10, 	//   : ()
		IxITEM_NM = 11, 	//   : ()
		IxSPEC_NM = 12, 	//   : ()
		IxCOLOR_NM = 13, 	//   : ()
		IxFORMULA_DIV = 14, 	// FORMULA 구분 : VARCHAR2(1)
		IxMCS_CD = 15, 	// MCS코드 : VARCHAR2(5)
		IxMCS_COLOR_CD = 16, 	// MCS Color코드 : VARCHAR2(5)
		IxITEM_CD = 17, 	// 상품코드 : VARCHAR2(10)
		IxSPEC_CD = 18, 	// Code : VARCHAR2(5)
		IxCOLOR_CD = 19, 	// ITEM Color코드 : VARCHAR2(5)
		IxUNIT = 20, 	// 단위 : ()
		IxFORMULA = 21, 	// Formula : NUMBER(22)
		IxMIX = 22, 	// Mix : NUMBER(22)
		IxREMARK = 23, 	// 비고 : ()
		IxSEND_CHK = 24, 	// 송신체크 : VARCHAR2(10)
		IxSEND_DATE = 25, 	// 송신일 : DATE(7)
		IxUPD_USER = 26, 	// 수정자 : VARCHAR2(10)
		IxUPD_YMD = 27 	// 수정일자 : DATE(7)
	}


	/// <summary> 
	/// SBC_FORMULA_WEIGHT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_FORMULA_WEIGHT : int 
	{ 
		IxMaxCt = 8,	// 인덱스 Count
		IxFACTORY = 1, 	// 공장코드 : VARCHAR2(5)
		IxFORMULA_YEAR = 2, 	// 연도 : ()
		IxSEASON_CD = 3, 	// 시즌코드 : VARCHAR2(2)
		IxSTYLE_CD = 4, 	// Style Cd : VARCHAR2(9)
		IxMCS_CD = 5, 	// MCS코드 : VARCHAR2(5)
		IxMCS_COLOR_CD = 6, 	// MCS Color코드 : VARCHAR2(5)
		IxUPD_USER = 7, 	// 수정자 : VARCHAR2(10)
		IxWEIGHT_TYPE = 8 	// 중량구분 : ()

	}


	/// <summary> 
	/// SBC_TEMPLATE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_TEMPLATE : int 
	{ 
		IxMaxCt = 12,			// 인덱스 Count 
		IxTEMPLATE_CD =1,		// 템플릿코드	:VARCHAR2(10) 
		IxTEMPLATE_NAME =2,		// 템플릿명	:VARCHAR2(50) 
		IxREMARK =3,			// 설명	:VARCHAR2(100) 
		IxPROPERTY1 =4,			// 속성1	:VARCHAR2(10) 
		IxPROPERTY2 =5,			// 속성2	:VARCHAR2(10) 
		IxPROPERTY3 =6,			// 속성3	:VARCHAR2(10) 
		IxPROPERTY4 =7,			// 속성4	:VARCHAR2(10) 
		IxPROPERTY5 =8,			// 속성5	:VARCHAR2(10) 
		IxSEND_CHK =9,			// 송신체크	:VARCHAR2(10) 
		IxSEND_DATE =10,		// 송신일	:DATE(7) 
		IxUPD_USER =11,			// 수정자	:VARCHAR2(10)
		IxUPD_YMD =12,			// 수정일	:DATE(7) 
	}  


	/// <summary> 
	/// SBC_TEMPLATE_TREE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_TEMPLATE_TREE : int 
	{ 
		IxMaxCt = 14,				// 인덱스 Count 
		IxTEMPLATE_TREE_CD =1,		// 템플릿구조코드	:VARCHAR2(10) 
		IxTEMPLATE_LEVEL =2,		// 템플릿레벨	:NUMBER(22) 
		IxTEMPLATE_TREE_NAME =3,	// 템플릿구조명칭	:VARCHAR2(100) 
		IxTEMPLATE_CD =4,			// 템플릿코드	:VARCHAR2(10) 
		IxPROPERTY1 =5,				// 속성1	:VARCHAR2(10) 
		IxPROPERTY2 =6,				// 속성2	:VARCHAR2(10) 
		IxPROPERTY3 =7,				// 속성3	:VARCHAR2(10) 
		IxPROPERTY4 =8,				// 속성4	:VARCHAR2(10) 
		IxPROPERTY5 =9,				// 속성5	:VARCHAR2(10) 
		IxREMARK =10,				// 설명	:VARCHAR2(100) 
		IxSEND_CHK =11,				// 송신체크	:VARCHAR2(10) 
		IxSEND_DATE =12,			// 송신일	:DATE(7) 
		IxUPD_USER =13,				// 수정자	:VARCHAR2(10) 
		IxUPD_YMD =14,				// 수정일	:DATE(7) 
	}  


	/// <summary> 
	/// SBB_ASK_HEAD 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBB_ASK_HEAD : int
	{
		IxMaxCt = 16,	// 인덱스 Count
		IxSTATUS = 1, 	// 상태 : VARCHAR2(10)
		IxASK_NO = 2, 	// 청구NO : VARCHAR2(20)
		IxASK_YMD = 3, 	// 청구일자 : DATE(7)
		IxASK_REASON = 4, 	// 청구이유(SBB01) : VARCHAR2(10)
		IxASK_USER = 5, 	// 청구자 : VARCHAR2(10)
		IxASK_DEPT = 6, 	// 청구부서 : VARCHAR2(10)
		IxASK_DEPT_NAME = 7, 	//   : ()
		IxUSE_DEPT = 8, 	// 요청부서 : VARCHAR2(10)
		IxUSE_DEPT_NAME = 9, 	//   : ()
		IxNEED_YMD = 10, 	// 대표소요일 : VARCHAR2(8)
		IxREMARKS = 11, 	// 설명 : VARCHAR2(500)
		IxFACTORY = 12, 	// 공장코드 : VARCHAR2(5)
		IxSEND_CHK = 13, 	// 송신체크 : VARCHAR2(10)
		IxSEND_YMD = 14, 	// 송신일 : DATE(7)
		IxUPD_USER = 15, 	// 수정자 : VARCHAR2(10)
		IxUPD_YMD = 16 	// 수정일 : DATE(7)
	}



	public enum TBSBB_ASK_TAIL : int
	{
		IxMaxCt = 31,	// 인덱스 Count
		IxFACTORY = 1, 	//   : VARCHAR2(5)
		IxASK_NO = 2, 	// 청구NO : VARCHAR2(20)
		IxSEQ = 3, 	// 일련번호 : NUMBER(22)
		IxSTATUS = 4, 	// 상태 : VARCHAR2(10)
		IxITEM_NM = 5, 	//   : ()
		IxSPEC_NM = 6, 	//   : ()
		IxCOLOR_NM = 7, 	//   : ()
		IxASK_UNIT = 8, 	// 청구단위 : VARCHAR2(10)
		IxSEMI_GOOD_CD = 9, 	//   : VARCHAR2(10)
		IxASK_QTY = 10, 	// 청구량 : NUMBER(22)
		IxCOMPONENT_CD = 11, 	//   : VARCHAR2(20)
		IxNEED_YMD = 12, 	// 대표소요일 : VARCHAR2(8)
		IxLOT_NO = 13, 	// Lot No : VARCHAR2(9)
		IxLOT_SEQ = 14, 	// Lot Seq : VARCHAR2(2)
		IxSTYLE_CD = 15, 	//   : VARCHAR2(9)
		IxWORK_DIV = 16, 	// 작업구분 : VARCHAR2(10)
		IxORD_NO = 17, 	// 발주NO : ()
		IxORD_QTY = 18, 	// Order Qty : ()
		IxPROD_IN_YMD = 19, 	// 불출일자 : ()
		IxPROD_IN_QTY = 20, 	// 불출수량 : ()
		IxITEM_CD = 21, 	// Item : VARCHAR2(10)
		IxCOLOR_CD = 22, 	// Color : VARCHAR2(10)
		IxSPEC_CD = 23, 	// Spec : VARCHAR2(10)
		IxETS1 = 24, 	//   : ()
		IxETS2 = 25, 	//   : ()
		IxETS3 = 26, 	//   : ()
		IxETS4 = 27, 	//   : ()
		IxSEND_CHK = 28, 	// 송신체크 : VARCHAR2(10)
		IxSEND_YMD = 29, 	// 송신일 : DATE(7)
		IxUPD_USER = 30, 	// 수정자 : VARCHAR2(10)
		IxUPD_YMD = 31 	// 수정일 : DATE(7)
	}



	/// <summary> 
	/// SBB_ASK_TAIL_STYLE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBB_ASK_TAIL_STYLE : int
	{
		IxMaxCt = 8,	// 인덱스 Count
		IxFACTORY = 1, 	// 공장 : VARCHAR2(5)
		IxASK_NO = 2, 	// 청구NO : VARCHAR2(20)
		IxLOT_NO = 3, 	// Lot No : VARCHAR2(9)
		IxLOT_SEQ = 4, 	// Lot Seq : VARCHAR2(2)
		IxSTYLE_CD = 5, 	// Style Cd : VARCHAR2(9)
		IxCS_SIZE = 6, 	// Cs Size : VARCHAR2(10)
		IxUPD_USER = 7, 	// 수정자 : VARCHAR2(10)
		IxASK_QTY = 8 	// 청구량 : NUMBER(22)
	}

	/// <summary> 
	/// SBC_YIELD 테이블 인덱스 Enum 
	/// </summary> 
	
	public enum TBSBC_YIELD_REQUEST : int
	{
		IxMaxCt = 29,	// 인덱스 Count
		IxLEVEL1 = 1, 	// Level : ()
		IxKEY1 = 2, 	// Key1 : ()
		IxCHOICE = 3, 	//   : ()
		IxTREE = 4, 	// Yield : ()
		IxFACTORY = 5, 	// 공장 : ()
		IxSTYLE_CD = 6, 	// 스타일 코드 : ()
		IxSEMI_GOOD_CD = 7, 	// 반제코드 : ()
		IxCOMPONENT_CD = 8, 	// 컴포넌트코드 : ()
		IxCOMPONENT_NAME = 9, 	// Component Name : ()
		IxTEMPLATE_SEQ = 10, 	// 템플릿위치 : ()
		IxTEMPLATE_LEVEL = 11, 	// 템플릿레벨 : ()
		IxTEMPLATE_TREE_CD = 12, 	// 템플릿구조코드 : ()
		IxTEMPLATE_TREE_NAME = 13, 	// 템플릿구조이름 : ()
		IxTEMPLATE_CD = 14, 	// 템플릿코드 : ()
		IxITEM_CD = 15, 	// 상품코드 : ()
		IxITEM_NAME = 16, 	// 상품이름 : ()
		IxSPEC_CD = 17, 	// Spec 코드 : ()
		IxSPEC_NAME = 18, 	// Spec  이름 : ()
		IxCOLOR_CD = 19, 	// Color코드 : ()
		IxCOLOR_NAME = 20, 	// Color Name : ()
		IxPROD_YN = 21, 	// PROD_YN : ()
		IxPROD_NAME = 22, 	//   : ()
		IxSEQ = 23, 	//   : ()
		IxSTOCK_UNIT = 24, 	// 재고단위 : ()
		IxSEND_CHK = 25, 	// 송신체크 : ()
		IxSEND_DATE = 26, 	// 송신일 : ()
		IxUPD_FACTORY = 27, 	// 수정공장 : ()
		IxUPD_YMD = 28, 	// 작성일자 : ()
		IxUPD_USER = 29 	// 작성자 : ()
	}


	/// <summary> 
	/// SPO_LOT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSPO_LOT : int
	{
		IxMaxCt = 11,	// 인덱스 Count
		IxFACTORY = 1, 	// 공장코드 : VARCHAR2(5)
		IxLOT_NO = 2, 	// Lot No : VARCHAR2(9)
		IxLOT_SEQ = 3, 	// Lot Seq : VARCHAR2(2)
		IxOBS_ID = 4, 	// OBS ID  : VARCHAR2(6)
		IxOBS_TYPE = 5, 	// OBS TYPE : VARCHAR2(2)
		IxPO_NO = 6, 	// PO No : VARCHAR2(8)
		IxMODEL_CD = 7, 	//   : VARCHAR2(6)
		IxSTYLE_CD = 8, 	// 스타일 코드 : VARCHAR2(9)
		IxGEN = 9, 	// Gender : VARCHAR2(2)
		IxBOM_CD = 10, 	// BOM CODE : VARCHAR2(10)
		IxROW_NUM = 11 	//   : ()
	}

  
	/// <summary> 
	/// SBB_PUR_HEAD 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBB_PUR_HEAD : int
	{
		IxMaxCt = 27,	// 인덱스 Count
		IxFACTORY = 1, 	// 공장 : VARCHAR2(5)
		IxSTATUS = 2, 	// 상태 : VARCHAR2(10)
		IxPUR_NO = 3, 	// 구매 번호 : VARCHAR2(20)
		IxPUR_YMD = 4, 	// 발주일자 : VARCHAR2(8)
		IxPUR_USER = 5, 	// 발주담당자 : VARCHAR2(10)
		IxPUR_DEPT = 6, 	// 발주부서 : VARCHAR2(10)
		IxPUR_DEPT_NAME = 7, 	//   : ()
		IxPUR_REASON = 8, 	// 발주이유(SBB01) : VARCHAR2(10)
		IxCUST_CD = 9, 	// 거래처코드 : VARCHAR2(10)
		IxTAX_CD = 10, 	// TAX구분 : VARCHAR2(10)
		IxDELIVERY_YMD = 11, 	// 납기일 : VARCHAR2(8)
		IxIMPORT_YN = 12, 	// 수입여부 : VARCHAR2(1)
		IxSHIP_YMD = 13, 	// 선적일자 : VARCHAR2(8)
		IxPUR_DIV = 14, 	//   : VARCHAR2(10)
		IxTRANS_CD = 15, 	// 운송수단 : VARCHAR2(10)
		IxPAY_CD = 16, 	// 결재수단 : VARCHAR2(10)
		IxCURRENCY_CD = 17, 	// 화펴단위 : VARCHAR2(10)
		IxLC_NO = 18, 	// LC번호 : VARCHAR2(20)
		IxMRP_NO = 19, 	// MRP NO : VARCHAR2(20)
		IxASK_NO = 20, 	// 청구NO : VARCHAR2(20)
		IxREQ_NO = 21, 	// 발주요청번호 : VARCHAR2(20)
		IxUP_PUR_NO = 22, 	// 상위PUR NO : VARCHAR2(20)
		IxREMARKS = 23, 	// 설명 : VARCHAR2(500)
		IxSEND_CHK = 24, 	// 송신체크 : VARCHAR2(10)
		IxSEND_YMD = 25, 	// 송신일 : DATE(7)
		IxUPD_USER = 26, 	// 수정자 : VARCHAR2(10)
		IxUPD_YMD = 27 	// 수정일 : DATE(7)
	}


	/// <summary> 
	/// TBSBB_PUR_TAIL 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBB_PUR_TAIL : int
	{
		IxMaxCt = 37,	// 인덱스 Count
		IxFACTORY = 1, 	//   : VARCHAR2(5)
		IxPUR_NO = 2, 	// 발주번호 : VARCHAR2(20)
		IxSEQ = 3, 	// 일련번호 : NUMBER(22)
		IxSTATUS = 4, 	// 상태 : VARCHAR2(10)
		IxLOT_NO = 5, 	// Lot No : VARCHAR2(9)
		IxLOT_SEQ = 6, 	// Lot Seq : VARCHAR2(2)
		IxSTYLE_CD = 7, 	//   : VARCHAR2(9)
		IxITEM_NM = 8, 	//   : ()
		IxSPEC_NM = 9, 	//   : ()
		IxCOLOR_NM = 10, 	//   : ()
		IxPUR_UNIT = 11, 	// 발주단위 : VARCHAR2(10)
		IxPUR_QTY = 12, 	// 발주수량 : NUMBER(22)
		IxPK_UNIT = 13, 	//   : VARCHAR2(10)
		IxPK_UNIT_QTY = 14, 	// 패킹단위당 수량 : NUMBER(22)
		IxPUR_CURRENCY = 15, 	// 구매화폐 : VARCHAR2(10)
		IxUNIT_PRICE = 16, 	// 구매단가 : NUMBER(22)
		IxPUR_PRICE = 17, 	// 구매단가 : NUMBER(22)
		IxPROCESS_PRICE = 18, 	// 임가공금액 : NUMBER(22)
		IxTOT_PRICE = 19, 	// 총금액 : NUMBER(22)
		IxCBD_CURRENCY = 20, 	// CBD화폐 : VARCHAR2(10)
		IxUNIT_CBD = 21, 	// 단위CBD : NUMBER(22)
		IxTOT_CBD = 22, 	// 총CBD : NUMBER(22)
		IxDELIVERY_YMD = 23, 	// 납기일 : VARCHAR2(8)
		IxSHIP_YMD = 24, 	// 선적일자 : VARCHAR2(8)
		IxASK_NO = 25, 	// 청구NO : VARCHAR2(20)
		IxASK_SEQ = 26, 	// 청구순번 : NUMBER(22)
		IxREQ_NO = 27, 	// 발주요청번호 : VARCHAR2(20)
		IxREQ_SEQ = 28, 	// 발주의뢰순번 : NUMBER(22)
		IxUP_PUR_NO = 29, 	// 상위PUR NO : VARCHAR2(20)
		IxUP_PUR_SEQ = 30, 	// 상위발주순번 : NUMBER(22)
		IxITEM_CD = 31, 	// Item : VARCHAR2(10)
		IxCOLOR_CD = 32, 	// Color : VARCHAR2(10)
		IxSPEC_CD = 33, 	// Spec : VARCHAR2(10)
		IxSEND_CHK = 34, 	// 송신체크 : VARCHAR2(10)
		IxSEND_YMD = 35, 	// 송신일 : DATE(7)
		IxUPD_USER = 36, 	// 수정자 : VARCHAR2(10)
		IxUPD_YMD = 37 	// 수정일 : DATE(7)
	}


	public enum TBSBM_MRP_MST : int
	{
		IxMaxCt = 14,	// 인덱스 Count
		IxFACTORY = 1, 	//   : VARCHAR2(5)
		IxMRP_NO = 2, 	// MRP NO : VARCHAR2(20)
		IxWORK_YMD = 3, 	// 작업일 : VARCHAR2(8)
		IxWORK_DIV = 4, 	// 작업구분 : VARCHAR2(10)
		IxNEED_START_YMD = 5, 	// 소요시작일 : VARCHAR2(8)
		IxNEED_END_YMD = 6, 	// 소요종료일 : VARCHAR2(8)
		IxSHIP_START_YMD = 7, 	// 선적시작일 : VARCHAR2(8)
		IxSHIP_END_YMD = 8, 	// 선적종료일 : VARCHAR2(8)
		IxREMARKS = 9, 	// 설명 : VARCHAR2(500)
		IxSTATUS = 10, 	// 상태 : VARCHAR2(10)
		IxSEND_CHK = 11, 	// 송신체크 : VARCHAR2(10)
		IxSEND_YMD = 12, 	// 송신일 : DATE(7)
		IxUPD_USER = 13, 	// 작성자 : VARCHAR2(10)
		IxUPD_YMD = 14 	// 작성일자 : DATE(7)
	}



	#endregion 

	#region 이정한 추가
	
	/// <summary> 
	/// SBM_SHIP 가상테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBM_SHIP : int
	{
		IxMaxCt = 14,	// 인덱스 Count
		IxLEVEL = 1, 	//   : ()
		IxKEY = 2, 	// Key : ()
		IxKIND = 3, 	// Kind : ()
		IxFACTORY = 4, 	// Factory : ()
		IxLOT_NO = 5, 	// Lot No : ()
		IxLOT_SEQ = 6, 	// Seq : ()
		IxPO_NO = 7, 	// PO : ()
		IxOBS_TYPE = 8, 	// Type : ()
		IxSTYLE_CD = 9, 	// Style : ()
		IxSTYLE_NAME = 10, 	// Name : ()
		IxLINE_CD = 11, 	// Line : ()
		IxSIZE_ITEM_YN = 12, 	// Size Item : ()
		IxDIFF_STATUS = 13, 	// Status : ()
		IxQTY = 14 	// Ship : ()
	}
	
	/// <summary> 
	/// SBM_SHIP_REQ 가상테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBM_SHIP_REQ : int
	{
		IxMaxCt = 12,	// 인덱스 Count
		IxLEVEL = 1, 	//   : ()
		IxKEY = 2, 	// Key : ()
		IxKIND = 3, 	// Kind : ()
		IxFACTORY = 4, 	// Factory : ()
		IxLOT_NO = 5, 	// Lot No : ()
		IxPO_NO = 6, 	// PO : ()
		IxOBS_TYPE = 7, 	// Type : ()
		IxSTYLE_CD = 8, 	// Style : ()
		IxSTYLE_NAME = 9, 	// Name : ()
		IxSIZE_ITEM_YN = 10, 	// Size Item : ()
		IxDIFF_STATUS = 11, 	// Status : ()
		IxQTY = 12 	// Ship : ()
	}


	/// <summary> 
	/// SBM_SHIP_LOT_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBM_SHIP_LOT_SIZE : int
	{
		IxMaxCt = 11,	// 인덱스 Count
		IxLEVEL = 1, 	// Level : ()
		IxFACTORY = 2, 	// Factory : VARCHAR2(5)
		IxSHIP_NO = 3, 	// Ship No. : VARCHAR2(20)
		IxSIZE_ITEM_YN = 4, 	// Size Item : VARCHAR2(1)
		IxLOT_NO = 5, 	// Lot No : VARCHAR2(9)
		IxLOT_SEQ = 6, 	// Lot Seq : VARCHAR2(2)
		IxKIND = 7, 	// Kind : ()
		IxSHIP_DATE = 8, 	// Ship Date : ()
		IxARR_DATE = 9, 	// Arr Date : ()
		IxSTATUS = 10, 	// Status : ()
		IxTOTAL = 11 	//   : ()
	}

	/// <summary> 
	/// SBM_SHIP_REQ_LOT_SIZE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBM_SHIP_REQ_LOT_SIZE : int
	{
		IxMaxCt = 9,	// 인덱스 Count
		IxLEVEL = 1, 	// Level : ()
		IxFACTORY = 2, 	// Factory : VARCHAR2(5)
		IxSHIP_NO = 3, 	// Ship No. : VARCHAR2(20)
		IxSIZE_ITEM_YN = 4, 	// Size Item : VARCHAR2(1)
		IxLOT_NO = 5, 	// Lot No : VARCHAR2(9)
		IxKIND = 6, 	// Kind : ()
		IxSHIP_DATE = 7, 	// Ship : ()
		IxSTATUS = 8, 	// Status : ()
		IxTOTAL = 9 	// Total : ()
	}



	/// <summary> 
	/// SBM_SHIP_MST 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBM_SHIP_MST : int
	{
		IxMaxCt = 19,	// 인덱스 Count
		IxFACTORY = 1, 	// 공장 : ()
		IxSHIP_NO = 2, 	// 선적NO : ()
		IxSHIP_TRANS = 3, 	// 선적수단(SBM02) : ()
		IxSHIP_DIV = 4, 	// 선적구분(SBM01) : ()
		IxPROD_START_YMD = 5, 	// 생산시작일 : ()
		IxPROD_END_YMD = 6, 	// 생산종료일 : ()
		IxEST_IN_YMD = 7, 	// 입고예상일 : ()
		IxEST_SHIP_YMD = 8, 	// DS선적예상일 : ()
		IxEST_DS_IN_YMD = 9, 	// DS입고예상일 : ()
		IxEST_PUR_YMD = 10, 	// 발주예상일 : ()
		IxCONF_PUR_YMD = 11, 	// 발주확정일 : ()
		IxCONF_IN_YMD = 12, 	// 입고일 : ()
		IxCONF_SHIP_YMD = 13, 	// 선적일 : ()
		IxCONF_DS_IN_YMD = 14, 	// DS입고일 : ()
		IxSTATUS = 15, 	// 상태 : ()
		IxSEND_CHK = 16, 	// 송신체크 : ()
		IxSEND_YMD = 17, 	// 송신일 : ()
		IxUPD_USER = 18, 	// 작성자 : ()
		IxUPD_YMD = 19 	// 작성일자 : ()
	}

	public enum TBSBM_MRP_ERROR_RESULT : int
	{
		IxMaxCt = 12,	// 인덱스 Count
		IxFACTORY = 1, 	//   : VARCHAR2(5)
		IxSP_NAME = 2, 	// 오류발생 SP : VARCHAR2(20)
		IxLOT_NO = 3, 	// Lot No : VARCHAR2(9)
		IxLOT_SEQ = 4, 	// Lot Seq : VARCHAR2(2)
		IxSIZE_ITEM_YN = 5, 	// 사이즈구분 : VARCHAR2(1)
		IxSTYLE_CD = 6, 	// 스타일코드 : ()
		IxSTYLE_NAME = 7, 	// 스타일명 : ()
		IxPUR_DIV = 8, 	// 구매형태 : VARCHAR2(10)
		IxPUR_FACTORY = 9, 	// 구매공장 : VARCHAR2(5)
		IxERR_SEQ = 10, 	// 순번 : NUMBER(22)
		IxERR_DISPLAY = 11, 	// 에러표시명 : VARCHAR2(50)
		IxUPD_USER = 12 	//   : VARCHAR2(30)
	}

	public enum TBSBM_MRP_NEEDS_ITEM : int
	{
		IxMaxCt = 22,	// 인덱스 Count
		IxLEVEL = 1, 	// Level : ()
		IxFACTORY = 2, 	// Factory : VARCHAR2(5)
		IxMRP_NO = 3, 	// MRP No : VARCHAR2(20)
		IxSIZE_ITEM_YN = 4, 	// Size : VARCHAR2(1)
		IxITEM_CD = 5, 	// 상품코드 : VARCHAR2(10)
		IxCOLOR_CD = 6, 	//   : VARCHAR2(5)
		IxSPEC_CD = 7, 	// Spec Cd : VARCHAR2(5)
		IxLOT_NO = 8, 	// Lot No : ()
		IxLOT_SEQ = 9, 	// Lot Seq : ()
		IxITEM_CD_1 = 10, 	// Lot No : ()
		IxSPEC_CD_1 = 11, 	// Name : ()
		IxCOLOR_CD_1 = 12, 	// Style : ()		
		IxUNIT = 13, 	// Unit : ()
		IxSAFE_QTY = 14, 	// Safety : NUMBER(22)
		IxPUR_LOT_QTY = 15, 	// Pur Unit : NUMBER(22)
		IxEST_PUR_QTY = 16, 	// Purchase : NUMBER(22)
		IxREAL_NEED_QTY = 17, 	// Real : NUMBER(22)
		IxTOT_NEED_QTY = 18, 	// Total : NUMBER(22)
		IxEST_IN_QTY = 19, 	// Income : NUMBER(22)
		IxEST_OUT_QTY = 20, 	// Prod : NUMBER(22)
		IxINIT_STOCK_QTY = 21, 	// Initial : NUMBER(22)
		IxEST_STOCK_QTY = 22 	// Last : NUMBER(22)
	}

	
	public enum TBSBM_MRP_NEEDS_ITEM_DETAIL1 : int
	{
		IxMaxCt = 19,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxMRP_NO = 2, 	// MRP No : ()
		IxSIZE_ITEM_YN = 3, 	// Size : ()
		IxITEM_CD = 4, 	// 상품코드 : ()
		IxCOLOR_CD = 5, 	//   : ()
		IxSPEC_CD = 6, 	//   : ()
		IxLOT_INFO = 7, 	// Lot No : ()
		IxLOT_NO = 8, 	//  : ()
		IxLOT_SEQ = 9, 	//  : ()
		IxSTYLE_CD = 10, 	// Style : ()
		IxSTYLE_NAME = 11, 	// Name : ()
		IxUNIT = 12, 	// Unit : ()
		IxCMP_CD = 13, 	// Cmp Cd : ()
		IxOP_CD = 14, 	// Op Cd : ()
		IxTOT_NEED_QTY = 15, 	// Tot Needs : ()
		IxYIELD = 16, 	// Avg Yield : ()
		IxSTYLE_QTY = 17, 	// Prod Qty : ()
		IxITEM_CONV = 18, 	// Item Conv : ()
		IxLOSS_RATE = 19 	// Loss Rate : ()
	}


	public enum TBSBM_MRP_NEEDS_ITEM_DETAIL2 : int
	{
		IxMaxCt = 21,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxMRP_NO = 2, 	// MRP No : ()
		IxSIZE_ITEM_YN = 3, 	// Size : ()
		IxITEM_CD = 4, 	// 상품코드 : ()
		IxCOLOR_CD = 5, 	//   : ()
		IxSPEC_CD = 6, 	//   : ()
		IxLOT_INFO = 7, 	// Lot No : ()
		IxLOT_NO = 8, 	//  : ()
		IxLOT_SEQ = 9, 	//  : ()
		IxSTYLE_CD = 10, 	// Style : ()
		IxSTYLE_NAME = 11, 	// Name : ()
		IxCMP_CD = 12, 	// Cmp Cd : ()
		IxOP_CD = 13, 	// Op Cd : ()
		IxDAY_SEQ_FR = 14, 	// Day Fr : ()
		IxDAY_SEQ_TO = 15, 	// Day To : ()
		IxUNIT = 16, 	// Unit : ()
		IxTOT_NEED_QTY = 17, 	// Item Prod : ()
		IxYIELD = 18, 	// Avg Yield : ()
		IxSTYLE_QTY = 19, 	// Prod Qty : ()
		IxITEM_CONV = 20, 	// Item Conv : ()
		IxLOSS_RATE = 21 	// Loss Rate : ()
	}

	public enum TBSBM_SHIP_REQ_ITEM_2 : int
	{
		IxMaxCt = 14,	// 인덱스 Count
		IxLEVEL = 1, 	// Level : ()
		IxFACTORY = 2, 	// Factory : VARCHAR2(5)
		IxMRP_NO = 3, 	// MRP No : VARCHAR2(20)
		IxSIZE_ITEM_YN = 4, 	// Size : VARCHAR2(1)
		IxITEM_CD = 5, 	// 상품코드 : VARCHAR2(10)
		IxCOLOR_CD = 6, 	//   : VARCHAR2(5)
		IxSPEC_CD = 7, 	// Spec Cd : VARCHAR2(5)
		IxLOT_NO = 8, 	// Lot No : VARCHAR2(9)
		IxLOT_SEQ = 9, 	// Lot Seq : VARCHAR2(2)
		IxITEM_CD_1 = 10, 	// Lot No : ()
		IxSPEC_CD_1 = 11, 	// Style : ()
		IxCOLOR_CD_1 = 12, 	// Name : ()
		IxUNIT = 13, 	// Unit : ()
		IxEST_PUR_QTY = 14 	// Purchase : ()
	}

	public enum TBV_SPO_LOT : int
	{
		IxMaxCt = 9,	// 인덱스 Count
		IxFACTORY = 1, 	//   : VARCHAR2(5)
		IxLOT_NO = 2, 	// Lot No : VARCHAR2(9)
		IxLOT_SEQ = 3, 	// Lot Seq : VARCHAR2(2)
		IxSTYLE_CD = 4, 	//   : ()
		IxSTYLE_NAME = 5, 	//   : ()
		IxDAY_SEQ = 6, 	//   : ()
		IxFIRST_YMD = 7, 	// 첫공정계획일 : ()
		IxDAY_SEQ1 = 8, 	//  : ()
		IxFIRST_YMD1 = 9 	//  : ()
	}


	public enum TBSBC_SYS_ENV : int
	{
		IxMaxCt = 11,	// 인덱스 Count
		IxFACTORY = 1, 	//   : VARCHAR2(5)
		IxENV_CD = 2, 	// 시스템환경코드 : VARCHAR2(10)
		IxENV_DIV1 = 3, 	// 시스템환경구분1 : VARCHAR2(10)
		IxENV_DIV2 = 4, 	// 시스템환경구분2 : VARCHAR2(10)
		IxCOM_CD = 5, 	// 공통 코드 : VARCHAR2(10)
		IxCOM_VALUE = 6, 	// 코드값 : VARCHAR2(70)
		IxCOM_CD_NAME = 7, 	//   : ()
		IxCOM_VALUE_NAME = 8, 	//   : ()
		IxREMARKS = 9, 	// 비고 : VARCHAR2(500)
		IxUPD_USER = 10, 	//   : VARCHAR2(30)
		IxUPD_YMD = 11 	//   : DATE(7)
	}
		
	
	/// <summary> 
	/// SBM_MRP_LEADTIME 테이블 인덱스 Enum DS
	/// </summary> 
	public enum TBSBM_MRP_LEADTIME_1 : int
	{
		IxMaxCt = 20,	// 인덱스 Count
		IxFACTORY = 1, 	// 공장 : VARCHAR2(5)
		IxPUR_DIV = 2, 	// 구매형태 : VARCHAR2(10)
		IxPUR_FACTORY = 3, 	// 구매공장 : VARCHAR2(5)
		IxDS_SHIP_DAY = 4, 	// DS선적요일(SH01) : VARCHAR2(10)
		IxSHIP_TRANS = 5, 	// 선적수단(SBM02) : VARCHAR2(10)
		IxPROD_FR_WEEK = 6, 	// 생산(FROM)주차(SBM03) : VARCHAR2(10)
		IxPROD_FR_DAY = 7, 	// 생산(FROM)요일(SH01) : VARCHAR2(10)
		IxPROD_TO_WEEK = 8, 	// 생산(TO)주차(SBM03) : VARCHAR2(10)
		IxPROD_TO_DAY = 9, 	// 생산(TO)요일(SH01) : VARCHAR2(10)
		IxFOREIGN_IN_WEEK = 10, 	// 해외도착주차(SBM03) : VARCHAR2(10)
		IxFOREIGN_IN_DAY = 11, 	// 해외도착요일(SH01) : VARCHAR2(10)
		IxDS_IN_WEEK = 12, 	// DS입고주차(SBM03) : VARCHAR2(10)
		IxDS_IN_DAY = 13, 	// DS입고요일(SH01) : VARCHAR2(10)
		IxFOREIGN_PUR_WEEK = 14, 	// 해외발주요청주차(SBM03) : VARCHAR2(10)
		IxFOREIGN_PUR_DAY = 15, 	// 해외발주요청요일(SH01) : VARCHAR2(10)
		IxUSE_YN = 16, 	// 사용여부 : VARCHAR2(1)
		IxSEND_CHK = 17, 	// 송신체크 : VARCHAR2(10)
		IxSEND_DATE = 18, 	// 송신일 : ()
		IxUPD_USER = 19, 	// 수정자 : VARCHAR2(30)
		IxUPD_YMD = 20 	// 수정일자 : DATE(7)
	}

	/// <summary> 
	/// SBM_MRP_LEADTIME 테이블 인덱스 Enum LOCAL
	/// </summary>
	public enum TBSBM_MRP_LEADTIME_2 : int
	{
		IxMaxCt = 16,	// 인덱스 Count
		IxFACTORY = 1, 	// 공장 : VARCHAR2(5)
		IxPUR_DIV = 2, 	// 구매형태 : VARCHAR2(10)
		IxPUR_FACTORY = 3, 	// 구매공장 : VARCHAR2(5)
		IxFOREIGN_PUR_DAY = 4, 	// 해외발주요청요일(SH01) : VARCHAR2(10)
		IxSHIP_TRANS = 5, 	// 선적수단(SBM02) : VARCHAR2(10)
		IxPROD_FR_WEEK = 6, 	// 생산(FROM)주차(SBM03) : VARCHAR2(10)
		IxPROD_FR_DAY = 7, 	// 생산(FROM)요일(SH01) : VARCHAR2(10)
		IxPROD_TO_WEEK = 8, 	// 생산(TO)주차(SBM03) : VARCHAR2(10)
		IxPROD_TO_DAY = 9, 	// 생산(TO)요일(SH01) : VARCHAR2(10)
		IxFOREIGN_IN_WEEK = 10, 	// 해외도착주차(SBM03) : VARCHAR2(10)
		IxFOREIGN_IN_DAY = 11, 	// 해외도착요일(SH01) : VARCHAR2(10)
		IxUSE_YN = 12, 	// 사용여부 : VARCHAR2(1)
		IxSEND_CHK = 13, 	// 송신체크 : VARCHAR2(10)
		IxSEND_DATE = 14, 	// 송신일 : ()
		IxUPD_USER = 15, 	// 수정자 : VARCHAR2(30)
		IxUPD_YMD = 16 	// 수정일자 : DATE(7)
	}
	


	public enum TBSBM_MRP_SIMULATION_RESULT : int
	{
		IxMaxCt = 12,	// 인덱스 Count
		IxLEV = 1, 	// Level : ()
		IxFACTORY = 2, 	// Factory : VARCHAR2(5)
		IxUPD_USER = 3, 	// User : VARCHAR2(30)
		IxITEM_CD = 4, 	// Item : VARCHAR2(10)
		IxSPEC_CD = 5, 	// Spec Cd : VARCHAR2(5)
		IxCOLOR_CD = 6, 	// Color Cd : VARCHAR2(5)
		IxITEM_CD_1 = 7, 	// Item : ()
		IxSPEC_CD_1 = 8, 	// Spec : ()
		IxCOLOR_CD_1 = 9, 	// Color : ()
		IxUNIT = 10, 	// Unit : ()
		IxINIT_STOCK_QTY = 11, 	// Init.Stock : NUMBER(22)
		IxDIV = 12 	// Ship : ()
	}


	
	#endregion  

	#region 이재민 추가

	public enum TBSBB_IMPOFFER_HEAD : int
	{
		IxMaxCt = 27,	// 인덱스 Count
		IxSTATUS = 1, 	// 상태 : VARCHAR2(10)
		IxFACTORY = 2, 	//   : VARCHAR2(5)
		IxOFFER_NO = 3, 	// 오퍼번호 : VARCHAR2(20)
		IxDEPT_CD = 4, 	// 공정 부서 코드 : VARCHAR2(6)
		IxDEPT_NAME = 5, 	// 요청부서명 : VARCHAR2(14)
		IxOFFER_YMD = 6, 	// 요청일자 : VARCHAR2(8)
		IxREG_USER = 7, 	// 요청자 : VARCHAR2(10)
		IxCATEGORY = 8, 	// 카테고리 : 모델에 대한 유형 : VARCHAR2(30)
		IxMODEL = 9, 	//   : VARCHAR2(30)
		IxDEV_CODE = 10, 	// 디벨로프코드 : VARCHAR2(30)
		IxSEASON = 11, 	// 시즌 : VARCHAR2(10)
		IxREASON = 12, 	// 이유 : VARCHAR2(30)
		IxLC_NO = 13, 	// LC번호 : VARCHAR2(20)
		IxCUST_CD = 14, 	// 거래처코드 : VARCHAR2(10)
		IxIMP_COUNTRY = 15, 	// 수입국가 : VARCHAR2(20)
		IxPROD_CODE = 16, 	// PROD_CODE : VARCHAR2(20)
		IxNIKE_DEV_NAME = 17, 	// 나이키디벨로퍼명 : VARCHAR2(20)
		IxFACTORY_DEV_NAME = 18, 	// 공장디벨로퍼명 : VARCHAR2(20)
		IxPO = 19, 	// PO : VARCHAR2(20)
		IxTRANS_CD = 20, 	// 운송수단 : VARCHAR2(10)
		IxPAY_CD = 21, 	// 결재수단 : VARCHAR2(10)
		IxCURRENCY_CD = 22, 	// 화펴단위 : VARCHAR2(10)
		IxREMARKS = 23, 	// 설명 : VARCHAR2(10)
		IxSEND_CHK = 24, 	// 송신체크 : VARCHAR2(10)
		IxSEND_YMD = 25, 	// 송신일 : DATE(7)
		IxUPD_YMD = 26, 	// 수정일 : DATE(7)
		IxUPD_USER = 27 	// 수정자 : VARCHAR2(10)
	}

	public enum TBSBB_IMPOFFER_TAIL : int
	{
		IxMaxCt = 30,	// 인덱스 Count
		IxFACTORY = 1, 	// 공장 : VARCHAR2(5)
		IxOFFER_NO = 2, 	// 오퍼번호 : VARCHAR2(20)
		IxSEQ = 3, 	// 일련번호 : NUMBER(22)
		IxSTATUS = 4, 	// 상태 : VARCHAR2(10)
		IxITEM_CD = 5, 	// Item : VARCHAR2(10)
		IxITEM_NAME = 6, 	// Item Name : VARCHAR2(100)
		IxCOLOR_CD = 7, 	// Color : VARCHAR2(5)
		IxCOLOR_NAME = 8, 	// Color Name : VARCHAR2(100)
		IxCOMP = 9, 	// COMP : VARCHAR2(30)
		IxADDPROC = 10, 	// ADDPROC : VARCHAR2(30)
		IxMTL = 11, 	// MTL : VARCHAR2(30)
		IxUNIT = 12, 	// Unit : VARCHAR2(10)
		IxOFFER_QTY = 13, 	// 요청수량 : NUMBER(22)
		IxPUR_QTY = 14, 	// 발주수량 : NUMBER(22)
		IxPRICE = 15, 	// 소매가 : NUMBER(22)
		IxITEM_CLASS = 16, 	// 분류 : VARCHAR2(50)
		IxRTA_YMD = 17, 	// RTA : VARCHAR2(8)
		IxPI_YMD = 18, 	// PI : VARCHAR2(8)
		IxETS1_YMD = 19, 	// ETS1 : VARCHAR2(8)
		IxETS2_YMD = 20, 	// ETS2 : VARCHAR2(8)
		IxSHIP_YMD = 21, 	// 선적일자 : VARCHAR2(8)
		IxARR_YMD = 22, 	// 도착일 : VARCHAR2(8)
		IxLEADTIME = 23, 	// 소요일 : VARCHAR2(20)
		IxSEND_CHK = 24, 	// 송신체크 : VARCHAR2(10)
		IxSEND_YMD = 25, 	// 송신일 : DATE(7)
		IxUPD_USER = 26, 	// 수정자 : VARCHAR2(10)
		IxUPD_YMD = 27, 	// 수정일 : DATE(7)
		IxPASS_QTY = 28, 	// 통관수량 : ()
		IxIN_QTY = 29, 	//   : ()
		IxBL = 30 	// BL : ()
	}

	public enum TBSBB_IMP_BL : int
	{
		IxMaxCt = 28,	// 인덱스 Count
		IxFACTORY = 1, 	// 공장 : VARCHAR2(5)
		IxBL_NO = 2, 	// BL NO : VARCHAR2(20)
		IxOFFER_NO = 3, 	// 오퍼번호 : VARCHAR2(20)
		IxSEQ = 4, 	// 일련번호 : NUMBER(22)
		IxCUST_CD = 5, 	// 거래처코드 : VARCHAR2(10)
		IxSHIP_YMD = 6, 	// 선적일자 : VARCHAR2(8)
		IxARR_YMD = 7, 	// 도착일 : VARCHAR2(8)
		IxVESSEL_NAME = 8, 	// VESSEL명 : VARCHAR2(100)
		IxTRANS_CD = 9, 	// 운송수단 : VARCHAR2(10)
		IxDECLARE_YMD = 10, 	// 신고일자 : VARCHAR2(8)
		IxLICENSE_NO = 11, 	// 승인번호 : VARCHAR2(20)
		IxPAY_CD = 12, 	// 결재수단 : VARCHAR2(10)
		IxCURRENCY_CD = 13, 	// 화펴단위 : VARCHAR2(10)
		IxPAY_YMD = 14, 	// 결재일 : VARCHAR2(8)
		IxLC_NO = 15, 	// LC번호 : VARCHAR2(20)
		IxPASS_YMD = 16, 	// 통관일자 : VARCHAR2(8)
		IxINV_NO = 17, 	// I/V NO : VARCHAR2(20)
		IxPASS_QTY = 18, 	// 통관수량 : NUMBER(22)
		IxM_BL_NO = 19, 	// BL NO : VARCHAR2(20)
		IxREMARKS = 20, 	// 설명 : VARCHAR2(200)
		IxSTATUS = 21, 	// 상태 : VARCHAR2(10)
		IxSEND_CHK = 22, 	// 송신체크 : VARCHAR2(10)
		IxSEND_YMD = 23, 	// 송신일 : DATE(7)
		IxUPD_USER = 24, 	// 수정자 : VARCHAR2(10)
		IxUPD_YMD = 25, 	// 수정일 : DATE(7)
		IxPUR_QTY = 26, 	// 발주수량 : ()
		IxTOTAL_QTY = 27, 	// 총통관수량 : ()
		IxDIV_QTY = 28		// 잔여수량 : ()
	}

	public enum TBSBB_IMP_COST : int
	{
		IxMaxCt = 14,	// 인덱스 Count
		IxFACTORY = 1, 	//   : VARCHAR2(5)
		IxBL_NO = 2, 	// BL NO : VARCHAR2(20)
		IxSEQ = 3, 	// Seq : NUMBER(22)
		IxCOST_CD = 4, 	// 비용코드 : VARCHAR2(10)
		IxTAX_CD = 5, 	// TAX구분 : VARCHAR2(10)
		IxCOST_YMD = 6, 	// 발생일자 : VARCHAR2(8)
		IxCURRENCY_CD = 7, 	// 화펴단위 : VARCHAR2(10)
		IxPRICE = 8, 	// 소매가 : NUMBER(22)
		IxADD_PRICE = 9, 	// 추가비용 : NUMBER(22)
		IxREMARKS = 10, 	// 설명 : VARCHAR2(200)
		IxSEND_CHK = 11, 	// 송신체크 : VARCHAR2(10)
		IxSEND_YMD = 12, 	// 송신일 : DATE(7)
		IxUPD_USER = 13, 	// User : VARCHAR2(10)
		IxUPD_YMD = 14 	// 수정일 : DATE(7)
	}

	public enum TBSBB_IMP_PAY : int
	{
		IxMaxCt = 12,	// 인덱스 Count
		IxFACTORY = 1, 	//   : VARCHAR2(5)
		IxBL_NO = 2, 	// BL NO : VARCHAR2(20)
		IxSEQ = 3, 	// Seq : NUMBER(22)
		IxPAY_YMD = 4, 	// 결재일 : VARCHAR2(8)
		IxPAY_CD = 5, 	// 결재수단 : VARCHAR2(10)
		IxCURRENCY_CD = 6, 	// 화펴단위 : VARCHAR2(10)
		IxPAY_PRICE = 7, 	// 결재금액 : NUMBER(22)
		IxREMARKS = 8, 	// 설명 : VARCHAR2(200)
		IxSEND_CHK = 9, 	// 송신체크 : VARCHAR2(10)
		IxSEND_YMD = 10, 	// 송신일 : DATE(7)
		IxUPD_USER = 11, 	// User : VARCHAR2(10)
		IxUPD_YMD = 12	 	// 수정일 : DATE(7)
	}


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


	public enum TBSBS_SHIPPING_REQUEST : int
	{
		IxMaxCt = 42,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxMERGE_TYPE = 2, 	//   : ()
		IxSHIP_NO = 3, 	// Ship No. : ()
		IxSHIP_SEQ = 4, 	// Seq : ()
		IxINDEX = 5, 	//   : ()
		IxPK_NO = 6, 	// P/N No : ()
		IxCT_QTY = 7, 	// C/T : ()
		IxMODEL = 8, 	// Model : ()
		IxSTYLE_CD = 9, 	// Code : ()
		IxSTYLE = 10, 	// Name : ()
		IxITEM = 11, 	// Item : ()
		IxSPEC = 12, 	// Spec : ()
		IxCOLOR = 13, 	// Color : ()
		IxPUR_QTY = 14, 	// Purchase : ()
		IxSHIP_QTY = 15, 	// Ship : ()
		IxUNIT = 16, 	// Unit : ()
		IxPK_UNIT_QTY = 17, 	// P/K Qty : ()
		IxPUR_PRICE = 18, 	// Price : ()
		IxPUR_CURRENCY = 19, 	// Currency : ()
		IxCBD_PRICE = 20, 	// Price : ()
		IxCBD_CURRENCY = 21, 	// Currency : ()
		IxSHIP_PRICE = 22, 	// Price : ()
		IxSHIP_CURRENCY = 23, 	// Currency : ()
		IxPRICE_YN = 24, 	// Price : ()
		IxPUR_USER = 25, 	// User : ()
		IxCUST_CD = 26, 	// Code : ()
		IxVENDOR = 27, 	// Name : ()
		IxLOCK_YN = 28, 	// Lock : ()
		IxIMPORT_YN = 29, 	// Import : ()
		IxSHIP_YN = 30, 	// Ship : ()
		IxOUTSIDE_YN = 31, 	// Outside : ()
		IxSTATUS = 32, 	// Status : ()
		IxREMARKS = 33, 	// Remark : ()
		IxPK_NO_FROM = 34, 	//   : ()
		IxPK_NO_TO = 35, 	//   : ()
		IxITEM_CD = 36, 	//   : ()
		IxSPEC_CD = 37, 	//   : ()
		IxCOLOR_CD = 38, 	//   : ()
		IxSEND_CHK = 39, 	//   : ()
		IxSEND_YMD = 40, 	// 송신일 : ()
		IxUPD_USER = 41, 	//   : ()
		IxUPD_YMD = 42 	//   : ()
	}



	public enum TBSBS_SHIPPING : int
	{
		IxMaxCt = 37,			// 인덱스 Count
		IxFACTORY = 1, 			// Factory : ()
		IxSHIP_NO = 2, 			// Ship No. : ()
		IxSHIP_SEQ = 3, 		// Seq : ()
		IxPK_NO = 4, 			// 패킹번호 : ()
		IxCT_QTY = 5, 			// 카톤수량 : ()
		IxITEM = 6, 			//   : ()
		IxSPEC = 7, 			//   : ()
		IxCOLOR = 8, 			//   : ()
		IxPUR_QTY = 9, 			// 발주수량 : ()
		IxSHIP_QTY = 10,		// Q'ty : ()
		IxUNIT = 11, 			//   : ()
		IxPK_UNIT_QTY = 12, 	// PK수량 : ()
		IxPUR_CURRENCY = 13, 	// 구매화폐 : ()
		IxPUR_PRICE = 14, 		// 구매단가 : ()
		IxCBD_CURRENCY = 15, 	// CBD화폐 : ()
		IxCBD_PRICE = 16, 		// CBD단가 : ()
		IxSHIP_CURRENCY = 17, 	//   : ()
		IxSHIP_PRICE = 18,		//   : ()
		IxPRICE_YN = 19, 		// 유무상 구분   : ()
		IxPUR_USER = 20, 		// 발주담당자 : ()
		IxVENDOR = 21,			//   : ()
		IxLOCK_YN = 22, 		// 에디트 가능 여부 : ()
		IxIMPORT_YN = 23,		//   : ()
		IxSHIP_YN = 24, 		//   : ()
		IxOUTSIDE_YN = 25,		//   : ()
		IxSTATUS = 26,			// Status : ()
		IxREMARKS = 27, 		// 비고 : ()
		IxPK_NO_FROM = 28,		//   : ()
		IxPK_NO_TO = 29, 		//   : ()
		IxITEM_CD = 30, 		//   : ()
		IxSPEC_CD = 31, 		//   : ()
		IxCOLOR_CD = 32, 		//   : ()
		IxCUST_CD = 33, 		// 거래처코드 : ()
		IxSEND_CHK = 34, 		//   : ()
		IxSEND_YMD = 35, 		// 송신일 : ()
		IxUPD_USER = 36, 		//   : ()
		IxUPD_YMD = 37 			//   : ()
	}

	public enum TBSBS_SHIPPING_HEAD : int
	{
		IxMaxCt = 22,			// 인덱스 Count
		IxFACTORY = 1, 			//   : VARCHAR2(5)
		IxSHIP_NO = 2, 			// Ship No. : VARCHAR2(20)
		IxSTYLE_CD = 3, 		// 스타일코드 : VARCHAR2(9)
		IxLOT_NO = 4, 			// Lot No : VARCHAR2(9)
		IxLOT_SEQ = 5, 			// Lot Seq : VARCHAR2(2)
		IxOBS_TYPE = 6, 		//   : VARCHAR2(2)
		IxPLAN_QTY = 7, 		//   : NUMBER(22)
		IxSHIP_QTY = 8, 		// Q'ty : NUMBER(22)
		IxSHIP_YMD = 9, 		// 선적일 : VARCHAR2(8)
		IxSHIP_DIVISION = 10, 	// 선적구분 : VARCHAR2(10)
		IxSHIP_TYPE = 11, 		// Ship Type : VARCHAR2(10)
		IxSIZE_ITEM_YN = 12, 	// 사이즈구분 : VARCHAR2(10)
		IxPACKING = 13, 		//   : VARCHAR2(4)
		IxBARCODE_YN = 14, 		//   : VARCHAR2(1)
		IxTRADE_YN = 15, 		//   : VARCHAR2(1)
		IxTRADE_SC = 16, 		//   : VARCHAR2(12)
		IxSTATUS = 17,			// Status : VARCHAR2(1)
		IxREMARKS = 18, 		// 비고 : VARCHAR2(500)
		IxSEND_CHK = 19, 		//   : VARCHAR2(10)
		IxSEND_YMD = 20, 		// 송신일 : DATE(7)
		IxUPD_USER = 21, 		//   : VARCHAR2(30)
		IxUPD_YMD = 22 			//   : DATE(7)
	}

 

	public enum TBSBS_BAR : int
	{
		IxMaxCt = 28,			// 인덱스 Count
		IxLEV = 1, 				// LEV : ()
		IxCHK = 2,				// C : ()
		IxPK_NO = 3, 			// PK No : VARCHAR2(6)
		IxCT = 4, 				// CT : ()
		IxSTYLE_CD = 5, 		// Style Code : VARCHAR2(9)
		IxITEM = 6, 			// Item : ()
		IxSPEC = 7, 			// Spec : ()
		IxCOLOR = 8, 			// Color : ()
		IxSHIP_QTY = 9, 		// Ship : NUMBER(22)
		IxSCAN_QTY = 10,		// Scan : ()
		IxUNIT = 11, 			// Unit : ()
		IxSCAN_YMD = 12, 		// Scan Date : ()
		IxSTATE = 13,			// State : ()
		IxLOCATION = 14, 		// Location : ()
		IxCONTAINER = 15, 		// Container : ()
		IxVENDOR = 16,			// Vendor : ()
		IxBAR_CODE = 17, 		// Barcode : VARCHAR2(24)
		IxBAR_SEQ = 18, 		// Seq : ()
		IxBAR_CODE_REP = 19, 	// Barcode Rep : VARCHAR2(24)
		IxTYPE = 20, 			// Type : ()
		IxSTYLE_NAME = 21,		// Style Name : ()
		IxCUST_CD = 22, 		// Cust Code : VARCHAR2(6)
		IxTYPE_CD = 23, 		// Type Code : ()
		IxITEM_CD = 24,			// Item Code : VARCHAR2(10)
		IxSPEC_CD = 25, 		// Spec Code : VARCHAR2(5)
		IxCOLOR_CD = 26, 		// Color Code : VARCHAR2(5)
		IxUPD_USER = 27, 		// User : VARCHAR2(30)
		IxUPD_YMD = 28			// Date : DATE(7)
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



	public enum TBSBS_SHIPPING_SIZE : int
	{
		IxMaxCt = 3,	// 인덱스 Count
		IxKIND = 1, 	//   : ()
		IxTOTAL = 2, 	//   : ()
		IxCOL = 3 		//   : ()
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

	public enum TBSBS_BAR_2 : int
	{
		IxMaxCt = 32,	// 인덱스 Count
		IxPK_NO = 1, 	// PK No : VARCHAR2(6)
		IxCT_QTY = 2, 	// C/T : NUMBER(22)
		IxSTYLE_CD = 3, 	// Code : VARCHAR2(9)
		IxSTYLE_NAME = 4, 	// Name : ()
		IxITEM_NAME = 5, 	// Item : ()
		IxSPEC_NAME = 6, 	// Specification : ()
		IxCOLOR_NAME = 7, 	// Color : ()
		IxPUR_QTY = 8, 	// Pur : NUMBER(22)
		IxSHIP_QTY = 9, 	// Ship : NUMBER(22)
		IxUNIT = 10, 	// Unit : ()
		IxPK_UNIT_QTY = 11, 	// P/K : NUMBER(22)
		IxPUR_PRICE = 12, 	// Price : NUMBER(22)
		IxPUR_CURRENCY = 13, 	// Currency : VARCHAR2(3)
		IxCBD_PRICE = 14, 	// Price : NUMBER(22)
		IxCBD_CURRENCY = 15, 	// Currency : VARCHAR2(3)
		IxSHIP_PRICE = 16, 	// Price : NUMBER(22)
		IxSHIP_CURRENCY = 17, 	// Currency : VARCHAR2(3)
		IxWEIGHT = 18, 	// Weight : ()
		IxVENDER_CD = 19, 	// Code : ()
		IxVENDER_NAME = 20, 	// Name : ()
		IxPRICE_YN = 21, 	// Price : VARCHAR2(1)
		IxSHIP_NO = 22, 	// Ship No : VARCHAR2(20)
		IxPUR_DIV = 23, 	// Pur Div : ()
		IxBARCODE = 24, 	// Barcode : ()
		IxBAR_SEQ = 25, 	// Bar Seq : ()
		IxUSER = 26, 	// User : ()
		IxSTATUS = 27, 	// Status : VARCHAR2(1)
		IxITEM_CD = 28, 	// Item : VARCHAR2(10)
		IxSPEC_CD = 29, 	// Spec : VARCHAR2(5)
		IxCOLOR_CD = 30, 	// Color : VARCHAR2(5)
		IxUPD_USER = 31, 	// Upd User : VARCHAR2(30)
		IxUPD_YMD = 32 	//   : DATE(7)
	}

	public enum TBSBS_REQUEST : int
	{
		IxMaxCt = 44,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : VARCHAR2(5)
		IxSHIP_NO = 2, 	//   : ()
		IxREQ_SEQ = 3, 	// 요청순번 : VARCHAR2(13)
		IxLOT_NO = 4, 	//   : VARCHAR2(9)
		IxLOT_SEQ = 5, 	//   : VARCHAR2(2)
		IxSTYLE_CD = 6, 	// 스타일코드 : VARCHAR2(9)
		IxSTYLE_NAME = 7, 	//   : ()
		IxOBS_TYPE = 8, 	// Type : VARCHAR2(2)
		IxSHIP_DIVISION = 9, 	// 선적구분 : VARCHAR2(10)
		IxSHIP_TYPE = 10, 	// Ship Type : VARCHAR2(10)
		IxPACKING = 11, 	//   : VARCHAR2(4)
		IxITEM = 12, 	//   : ()
		IxSPEC = 13, 	//   : ()
		IxCOLOR = 14, 	//   : ()
		IxREQ_QTY = 15, 	// 발주의뢰수량 : NUMBER(22)
		IxSHIP_QTY = 16, 	//   : NUMBER(22)
		IxUNIT = 17, 	//   : ()
		IxPK_NO_FROM = 18, 	//   : VARCHAR2(6)
		IxPK_NO_TO = 19, 	//   : VARCHAR2(6)
		IxPK_UNIT_QTY = 20, 	// PK수량 : NUMBER(22)
		IxCT_QTY = 21, 	// C/T : NUMBER(22)
		IxCUST_CD = 22, 	//   : VARCHAR2(6)
		IxCUST_NAME = 23, 	//   : ()
		IxPUR_USER = 24, 	//   : VARCHAR2(30)
		IxPUR_PRICE = 25, 	// 구매단가 : NUMBER(22)
		IxPUR_CURRENCY = 26, 	// 구매화폐 : VARCHAR2(3)
		IxCBD_PRICE = 27, 	// CBD단가 : NUMBER(22)
		IxCBD_CURRENCY = 28, 	// CBD화폐 : VARCHAR2(3)
		IxSHIP_PRICE = 29, 	// Price : NUMBER(22)
		IxSHIP_CURRENCY = 30, 	// Currency : VARCHAR2(3)
		IxPRICE_YN = 31, 	// Price : VARCHAR2(1)
		IxLOCK_YN = 32, 	// 에디트 가능 여부 : VARCHAR2(1)
		IxIMPORT_YN = 33, 	//   : VARCHAR2(1)
		IxSHIP_YN = 34, 	//   : VARCHAR2(1)
		IxOUTSIDE_YN = 35, 	//   : VARCHAR2(1)
		IxREMARKS = 36, 	// Remarks : VARCHAR2(500)
		IxSTATUS = 37, 	// Status : VARCHAR2(1)
		IxITEM_CD = 38, 	// 상품코드 : VARCHAR2(10)
		IxSPEC_CD = 39, 	// Spec : VARCHAR2(5)
		IxCOLOR_CD = 40, 	//   : VARCHAR2(5)
		IxSEND_CHK = 41, 	//   : VARCHAR2(10)
		IxSEND_YMD = 42, 	// 송신일 : DATE(7)
		IxUPD_USER = 43, 	// Upd User : VARCHAR2(30)
		IxUPD_YMD = 44 	// Upd Ymd : DATE(7)
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


	// MRP : SBM_BUSINESS_AREA (Form_BM_Business_Area)
	public enum TBSBM_BUSINESS_AREA : int
	{
		IxMaxCt = 11,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : VARCHAR2(5)
		IxAREA_CD = 2, 	// Code : VARCHAR2(10)
		IxAREA_NAME = 3, 	// Name : VARCHAR2(30)
		IxFORE_COLOR = 4, 	// Fore : VARCHAR2(10)
		IxBACK_COLOR = 5, 	// Background : VARCHAR2(10)
		IxATTRIBUTE = 6, 	// Attribute : VARCHAR2(10)
		IxREMARKS = 7, 	// Remarks : VARCHAR2(500)
		IxFORE_CODE = 8, 	// ForeCode : ()
		IxBACK_CODE = 9, 	// BackCode : ()
		IxUPD_USER = 10, 	// Update User : VARCHAR2(30)
		IxUPD_YMD = 11 	// Update Date : DATE(7)
	}

	// MRP : SBM_SHIPPING_PARAMETER (Form_BM_Shipping_Parameter)
	public enum TBSBM_SHIP_PARAMETER : int
	{
		IxMaxCt = 11,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxPARA_CD = 2, 	// 전달코드 : ()
		IxPARA_NAME = 3, 	// 전달명 : ()
		IxPARA_VALUE1 = 4, 	// 전달명 1 : ()
		IxPARA_VALUE2 = 5, 	// 전달명 2 : ()
		IxPARA_VALUE3 = 6, 	// 전달명 3 : ()
		IxPARA_VALUE4 = 7, 	// 전달명 4 : ()
		IxPARA_VALUE5 = 8, 	// 전달명 5 : ()
		IxREMARKS = 9, 	// Remarks : ()
		IxUPD_USER = 10, 	// Update User : ()
		IxUPD_YMD = 11 	// Update Date : ()
	}

	// MRP : SBM_SHIPPING_MASTER, SBM_CURRENT_MPS, SBM_CURRENT_SHIPPING.. (Form_BM_Shipping_Schedule)
	public enum TBSBM_SHIP_ADJUST : int
	{
		IxMaxCt = 14,	// 인덱스 Count
		IxTREE = 1, 	// Kind : ()
		IxLINE_CD = 2, 	// Line : ()
		IxLOT_NO = 3, 	// Lot No : ()
		IxLOT_SEQ = 4, 	// Seq : ()
		IxSTYLE_CD = 5, 	// Style : ()
		IxSTYLE_NAME = 6, 	// Style Name : ()
		IxGENDER = 7, 	// Gen : ()
		IxOBS_ID = 8, 	// OBS ID : ()
		IxOBS_TYPE = 9, 	// Type : ()
		IxPO_ID = 10, 	// PO : ()
		IxLOT_QTY = 11, 	// Lot : ()
		IxLOSS_QTY = 12, 	// Loss : ()
		IxPLAN_DATE = 13, 	// Assemble : ()
		IxTOTAL_QTY = 14 	// Total : ()
	}

	// MRP : SBM_SHIPPING_MASTER, SBM_CURRENT_MPS, SBM_CURRENT_SHIPPING.. (Form_BM_Shipping_Schedule)
	public enum TBSBM_SHIP_CONFIRM : int
	{
		IxMaxCt = 13,	// 인덱스 Count
		IxTREE = 1, 	// Kind : ()
		IxLOT_NO = 2, 	// Lot No : ()
		IxLOT_SEQ = 3, 	// Seq : ()
		IxSTYLE_CD = 4, 	// Style : ()
		IxSTYLE_NAME = 5, 	// Style Name : ()
		IxGENDER = 6, 	// Gen : ()
		IxOBS_ID = 7, 	// OBS ID : ()
		IxOBS_TYPE = 8, 	// Type : ()
		IxPO_ID = 9, 	// PO : ()
		IxLOT_QTY = 10, 	// Lot : ()
		IxLOSS_QTY = 11, 	// Loss : ()
		IxPLAN_DATE = 12, 	// Assemble : ()
		IxTOTAL_QTY = 13 	// Total : ()
	}


	// MRP : SBM_SHIPPING_MASTER_SIZE, SBM_CURRENT_MPS_SIZE, SBM_CURRENT_SHIPPING_SIZE.. (Form_BM_Shipping_Schedule)
	public enum TBSBM_SHIP_SIZE_INFO : int
	{
		IxMaxCt = 8,		// 인덱스 Count
		IxLEVEL = 1, 		//   : ()
		IxKEY = 2, 			//   : ()
		IxKIND = 3, 		//   : ()
		IxSHIP_DATE = 4, 	//   : ()
		IxARRIVAL_DATE = 5, //   : ()
		IxFORE_COLOR = 6, 	//   : ()
		IxBACK_COLOR = 7, 	//   : ()
		IxTOTAL_QTY = 8 	//   : ()
	}

	// MRP : SBM_MRP_ITEM
	public enum TBSBM_MRP_ADJUST : int
	{
		IxMaxCt = 29,			// 인덱스 Count
		IxLEVEL = 1, 			// Level : ()
		IxMRP_SHIP_NO = 2, 		// MRP Ship No : ()
		IxITEM_NAME = 3, 		// Lot No : ()
		IxSPEC_NAME = 4, 		// Style Code : ()
		IxCOLOR_NAME = 5, 		// Style Name : ()
		IxUNIT = 6, 			// Unit : ()
		IxCONFIRM_QTY = 7, 		// Confirm : ()
		IxADVICE_QTY = 8, 		// Advice : ()
		IxUSAGE_QTY = 9, 		// Usage : ()
		IxREQUEST_QTY = 10, 	// Request : ()
		IxSHIPPING_QTY = 11, 	// Shipping : ()
		IxWAREHOUSE_QTY = 12, 	// WareHouse : ()
		IxPRODUCTION_QTY = 13, 	// Production : ()
		IxSAFE_QTY = 14, 		// Safe : ()
		IxPK_QTY = 15, 			// P/K : ()
		IxSHIP_YN = 16, 		// Shipping : ()
		IxOUT_SIDE_YN = 17, 	// Out Side : ()
		IxSTYLE_ITEM_DIV = 18, 	// Style Item Division : ()
		IxOBS_ID = 19, 			// DPO : ()
		IxOBS_TYPE = 20, 		// OBS Type : ()
		IxREMARKS = 21, 		// Remarks : ()
		IxATTRIBUTE = 22, 		// Attribute : ()
		IxITEM_CD = 23, 		// Item Code : ()
		IxSPEC_CD = 24, 		// Spec Code : ()
		IxCOLOR_CD = 25, 		// Color Code : ()
		IxSTATUS = 26, 			// Status : ()
		IxUPD_USER = 27, 		// User : ()
		IxUPD_YMD = 28 			// Date : ()
	}


	// MRP : SBM_MRP_ITEM
	public enum TBSBM_MRP_ADJUST_MULTI : int
	{
		IxMaxCt = 23,	// 인덱스 Count
		IxLEVEL				= 1, 	// Level : ()
		IxMRP_SHIP_NO		= 2, 	// MRP Ship No : ()
		IxITEM_NAME			= 3, 	// Lot No : ()
		IxSPEC_NAME			= 4, 	// Style Code : ()
		IxCOLOR_NAME		= 5, 	// Style Name : ()
		IxUNIT				= 6, 	// Unit : ()
		IxPLAN_QTY			= 7, 	// Confirm : ()
		IxSHIP_QTY			= 8, 	// Confirm : ()
		IxCONFIRM_QTY		= 9, 	// Confirm : ()
		IxADVICE_QTY		= 10, 	// Advice : ()
		IxUSAGE_QTY			= 11, 	// Usage : ()
		IxREQUEST_QTY		= 12, 	// Request : ()
		IxSHIPPING_QTY		= 13, 	// Shipping : ()
		IxWAREHOUSE_QTY		= 14, 	// WareHouse : ()
		IxPRODUCTION_QTY	= 15, 	// Production : ()
		IxSAFE_QTY			= 16, 	// Safe : ()
		IxPK_QTY			= 17, 	// P/K : ()
		IxSHIP_YN			= 18, 	// Ship : ()
		IxOUT_SIDE_YN		= 19, 	// Out Side : ()
		IxSTYLE_ITEM_DIV	= 20, 	// Style Item Division : ()
		IxREMARKS			= 21, 	// Remarks : ()
		IxITEM_CD			= 22, 	// Item Code : ()
		IxSPEC_CD			= 23, 	// Spec Code : ()
		IxCOLOR_CD			= 24, 	// Color Code : ()
		IxSTATUS			= 25, 	// Status : ()
		IxUSER				= 26, 	// 
		IxOBS_ID			= 27, 	// 
		IxOBS_TYPE			= 28, 	// 
		IxPO_NO				= 29 	// 
	};



	
	// MRP : TBSBM_MRP_ADJUST_MULTI_ITEM
	public enum TBSBM_MRP_ADJUST_MULTI_ITEM : int
	{
		IxMaxCt = 26,	// 인덱스 Count
		lxLEVEL       = 1,
		lxMRP_SHIP_NO = 2,
		lxITEM_NAME   = 3,
		lxSPEC_NAME   = 4,
		lxCOLOR_NAME  = 5,
		lxUNIT        = 6,
		lxPLAN_QTY    = 7,
		lxSHIP_QTY    = 8,
		lxADVICE_QTY  = 9,
		lxCONFIRM_QTY = 10,
		lxUSAGE_QTY   = 11,
		lxREQUEST_QTY = 12,
		lxSHIPPING_QTY   = 13,
		lxWAREHOUSE_QTY  = 14,
		lxPRODUCTION_QTY = 15,
		lxSAFE_QTY       = 16,
		lxPK_QTY         = 17,
		lxSHIP_YN        = 18,
		lxOUT_SIDE_YN    = 19,
		lxSTYLE_ITEM_DIV = 20,
		lxREMARKS        = 21,
		lxITEM_CD        = 22,
		lxSPEC_CD        = 23,
		lxCOLOR_CD       = 24,
		lxSTATUS         = 25,
		lxUSER           = 26,

	};



	// MRP : SEM_REQ, SPO_RECV, SPO_RECV_LOT
	public enum TBSBM_READY_MPS : int
	{
		IxMaxCt = 22,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : VARCHAR2(5)
		IxREQ_NO = 2, 	// Req No : ()
		IxOBS_ID = 3, 	// ID : ()
		IxOBS_TYPE = 4, 	// Type : ()
		IxSTYLE_CD = 5, 	// Code : ()
		IxSTYLE_NAME = 6, 	// Name : ()
		IxGENDER = 7, 	// Gen : ()
		IxPST_YN = 8, 	// Presto : ()
		IxREQ_QTY = 9, 	// Req Qty : ()
		IxPLAN_YMD = 10, 	// Plan : ()
		IxOA_FLAG = 11, 	// OA : ()
		IxPLAN_OAAPP_DIV = 12, 	// OA App : ()
		IxRECV_QTY = 13, 	// Lot : ()
		IxRECV_LOSS_QTY = 14, 	// Loss : ()
		IxLOT_DIV = 15, 	// Division : ()
		IxLOT_NO = 16, 	// No : ()
		IxLOT_SEQ = 17, 	// Seq : ()
		IxLINE_CD = 18, 	// Line : ()
		IxPLAN_STRYMD = 19, 	// Start : ()
		IxPLAN_ENDYMD = 20, 	// End : ()
		IxLOT_QTY = 21, 	// Lot : ()
		IxLOSS_QTY = 22 	// Loss : ()
	}

	
	// MRP : SEM_OBS, SEM_REQ
	public enum TBSBM_READY_ORDER : int
	{
		IxMaxCt = 17,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxOBS_ID = 2, 	// ID : ()
		IxOBS_TYPE = 3, 	// Type : ()
		IxSTYLE_CD = 4, 	// Code : ()
		IxSTYLE_NAME = 5, 	// Name : ()
		IxGENDER = 6, 	// Gender : ()
		IxPRESTO = 7, 	// Presto : ()
		IxREQ_YN = 8, 	// Req Y/N : ()
		IxORD_QTY = 9, 	// Ord Qty : ()
		IxDESTINATION = 10, 	// Dest : ()
		IxOGAC_YMD = 11, 	// OGAC : ()
		IxRTS_YMD = 12, 	// RTS : ()
		IxREQ_NO = 13, 	// No : ()
		IxREQ_YMD = 14, 	// Date : ()
		IxREAL_OBS_DIV = 15, 	// Read OBS : ()
		IxREQ_QTY = 16, 	// Req Qty : ()
		IxPLAN_YMD = 17 	// Plan : ()
	}


	// MRP : SBM_SHIPPING_SCHEDULE, SBC_YIELD_INFO
	public enum TBSBM_READY_YIELD : int
	{
		IxMaxCt = 7,	// 인덱스 Count
		IxSTYLE_CD = 1, 	// Code : ()
		IxSTYLE_NAME = 2, 	// Name : ()
		IxBOM_TREE = 3, 	// BOM Tree : ()
		IxYIELD_STATUS = 4, 	// Status : ()
		IxEXIST_YIELD_YN = 5, 	// Exist : ()
		IxCMP_CD = 6, 	// Component : ()
		IxEXIST_COUNT = 7 	// Count : ()
	}


	// MRP : SBM_SHIPPING_MASTER, SBM_BUSINESS_AREA, SBM_READY
	public enum TBSBM_SHIP_MASTER : int
	{
		IxMaxCt = 18,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxSHIP_TYPE = 2, 	// Ship Type : ()
		IxMRP_SHIP_NO = 3, 	// MRP Ship No : ()
		IxSHIP_DATE = 4, 	// Ship : ()
		IxARRIVAL_DATE = 5, 	// Arrival : ()
		IxPLAN_DATE = 6, 	// Plan : ()
		IxAREA_CD = 7, 	// Code : ()
		IxAREA_NAME = 8, 	// Name : ()
		IxFORE_COLOR = 9, 	// Fore : ()
		IxBACK_COLOR = 10, 	// Back : ()
		IxREMARKS = 11, 	// Remarks : ()
		IxORDER_YN = 12, 	// Order : ()
		IxMPS_YN = 13, 	// MPS : ()
		IxYIELD_YN = 14, 	// Yield : ()
		IxSHIPPING_ADJUST = 15, 	// Adjust : ()
		IxSHIPPING_CONFIRM = 16, 	// Confirm : ()
		IxMRP_YN = 17, 	// MRP : ()
		IxSEND_YN = 18 	// Send : ()
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

	// Purchase : SBP_PURCHASE_MANAGER
	public enum TBSBP_PURCHASE_MANAGER_3 : int
	{
		IxMaxCt = 51,	// 인덱스 Count
		IxLEVEL = 1, 	// Level : ()
		IxSHIP_TYPE = 2, 	// Ship Type : VARCHAR2(10)
		IxSTATUS = 3, 	// Status : VARCHAR2(10)
		IxCHECK = 4, 	// Chk : ()
		IxMANAGER_SEQ = 5, 	// Manager Seq : VARCHAR2(20)
		IxITEM_NAME = 6, 	// Item : ()
		IxSPEC_NAME = 7, 	// Specification : ()
		IxCOLOR_NAME = 8, 	// Color : ()
		IxREQ_QTY = 9, 	// Request : NUMBER(22)
		IxPUR_QTY = 10, 	// Purchase : NUMBER(22)
		IxUNIT = 11, 	// Unit : ()
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


	// Purchase : SBP_PURCHASE_TAIL
	public enum TBSBP_PURCHASE_TAIL_2 : int
	{
		IxMaxCt = 46,	// 인덱스 Count
		IxLEVEL = 1, 	// Level : ()
		IxITEM_NAME = 2, 	// Item : ()
		IxSPEC_NAME = 3, 	// Specification : ()
		IxCOLOR_NAME = 4, 	// Color : ()
		IxUNIT = 5, 	// Unit : ()
		IxREQ_QTY = 6, 	// Request : NUMBER(22)
		IxNEED_QTY = 7, 	// Nees : NUMBER(22)
		IxPUR_QTY = 8, 	// Purchase : NUMBER(22)
		IxIN_QTY = 9, 	// Incoming : NUMBER(22)
		IxPUR_PRICE = 10, 	// Price : NUMBER(22)
		IxPUR_CURRENCY = 11, 	// Currency : VARCHAR2(10)
		IxOUTSIDE_PRICE = 12, 	// Price : NUMBER(22)
		IxOUTSIDE_CURRENCY = 13, 	// Currency : VARCHAR2(10)
		IxCBD_PRICE = 14, 	// Price : NUMBER(22)
		IxCBD_CURRENCY = 15, 	// Currency : VARCHAR2(10)
		IxCUST_CD = 16, 	// Code : VARCHAR2(10)
		IxCUST_NAME = 17, 	// Name : ()
		IxPK_UNIT_QTY = 18, 	// P/K Qty : NUMBER(22)
		IxCBM = 19, 	// CBM : NUMBER(22)
		IxWEIGHT = 20, 	// Weight : NUMBER(22)
		IxRTA_YMD = 21, 	// RTA : VARCHAR2(8)
		IxETS_YMD1 = 22, 	// Date1 : VARCHAR2(8)
		IxETS_YMD2 = 23, 	// Date2 : VARCHAR2(8)
		IxETS_YMD3 = 24, 	// Date3 : VARCHAR2(8)
		IxREQ_NO = 25, 	// No : VARCHAR2(20)
		IxREQ_SEQ = 26, 	// Seq : NUMBER(22)
		IxOBS_ID = 27, 	// ID : VARCHAR2(6)
		IxOBS_TYPE = 28, 	// Type : VARCHAR2(2)
		IxOBS_YN = 29, 	// Y/N : VARCHAR2(1)
		IxPO_NO = 30, 	// PO No : VARCHAR2(8)
		IxLC_NO = 31, 	// L/C No : VARCHAR2(20)
		IxTAX_CD = 32, 	// Tax : VARCHAR2(10)
		IxPAY_CD = 33, 	// Pay : VARCHAR2(10)
		IxREQ_DEPT = 34, 	// Request Dept : VARCHAR2(10)
		IxPUR_DEPT = 35, 	// Purchase Dept : VARCHAR2(10)
		IxOFFER_NO = 36, 	// Offer No : VARCHAR2(20)
		IxYIELD_STATUS = 37, 	// Yield : VARCHAR2(1)
		IxPUR_STATUS = 38, 	// Purchase : VARCHAR2(1)
		IxLOT_NO = 39, 	// No : VARCHAR2(9)
		IxREMARKS = 40, 	// Remarks : VARCHAR2(500)
		IxFACTORY = 41, 	// Factory : VARCHAR2(5)
		IxPUR_NO = 42, 	// Pur No : VARCHAR2(20)
		IxPUR_SEQ = 43, 	// Seq : NUMBER(22)
		IxITEM_CD = 44, 	// Item : VARCHAR2(10)
		IxSPEC_CD = 45, 	// Specification : VARCHAR2(5)
		IxCOLOR_CD = 46 	// Color : VARCHAR2(5)
	}

	public enum TBSBM_MRP_VALID_CHECK : int
	{
		IxMaxCt = 12,	// 인덱스 Count
		IxCOMPONENT_NAME = 1, 	//   : ()
		IxITEM_NAME = 2, 	//   : ()
		IxSPEC_NAME = 3, 	//   : ()
		IxCOLOR_NAME = 4, 	//   : ()
		IxITEM_CD = 5, 	//   : ()
		IxSPEC_CD = 6, 	//   : ()
		IxCOLOR_CD = 7, 	//   : ()
		IxCS_SIZE = 8, 	//   : ()
		IxSIZE_QTY = 9, 	//   : ()
		IxYIELD_M = 10, 	//   : ()
		IxUSAGE_QTY = 11, 	//   : ()
		IxCONFIRM_QTY = 12 	//   : ()
	}

	public enum TBSBM_CURRENT_ADJUST : int
	{
		IxMaxCt = 22,	// 인덱스 Count
		IxSHIP_CHECK = 1, 	//   : ()
		IxFACTORY = 2, 	// Factory : VARCHAR2(5)
		IxLINE_CD = 3, 	// Line : VARCHAR2(3)
		IxLOT_NO = 4, 	// No : VARCHAR2(9)
		IxLOT_SEQ = 5, 	// Seq : VARCHAR2(2)
		IxOBS_ID = 6, 	// Id : VARCHAR2(6)
		IxOBS_TYPE = 7, 	// Type : VARCHAR2(2)
		IxSTYLE_CD = 8, 	// Code : VARCHAR2(9)
		IxSTYLE_NAME = 9, 	// Name : ()
		IxGEN = 10, 	// Gen : VARCHAR2(2)
		IxPLAN_STRYMD = 11, 	// Start : VARCHAR2(8)
		IxPLAN_ENDYMD = 12, 	// End : VARCHAR2(8)
		IxFIRST_SHIP_DATE = 13, 	// First Ship : VARCHAR2(8)
		IxLOT_QTY = 14, 	// Lot : NUMBER(22)
		IxLOSS_QTY = 15, 	// Loss : NUMBER(22)
		IxBEFORE_QTY = 16, 	// Before : NUMBER(22)
		IxSHIP_QTY = 17, 	// Shipping : NUMBER(22)
		IxMRP_SHIP_NO = 18, 	// MRP Ship No : VARCHAR2(20)
		IxREASON = 19, 	// Reason : ()
		IxREMARKS = 20, 	// Remarks : VARCHAR2(500)
		IxAREA_NAME = 21, 	// Area : ()
		IxPO_NO = 22 	// PO : VARCHAR2(8)
	}



	public enum TBSBM_MRP_SHIP_NO_LIST : int
	{
		IxMaxCt = 8,	// 인덱스 Count
		IxMRP_SHIP_NO_MASTER = 1, 	//   : ()
		IxSHIP_DATE = 2, 	//   : ()
		IxARRIVE_DATE = 3, 	//   : ()
		IxPLAN_DATE = 4, 	//   : ()
		IxMRP_SHIP_NO_SCHEDULE = 5, 	//   : ()
		IxAREA_CD = 6, 	//   : ()
		IxAREA_NAME = 7, 	//   : ()
		IxBACK_COLOR = 8 	//   : ()
	}

	// MRP REQUEST (LOT 별)
	public enum TBSBM_MRP_REQUEST_LOT : int
	{
		IxMaxCt = 29,	// 인덱스 Count
		IxLEVEL = 1, 	// Level : ()
		IxMRP_SHIP_NO = 2, 	// MRP Ship No : ()
		IxITEM_NAME = 3, 	// Item : ()
		IxSPEC_NAME = 4, 	// Spec : ()
		IxCOLOR_NAME = 5, 	// Color : ()
		IxUNIT = 6, 	// Unit : ()
		IxPLAN_QTY = 7, 	// Plan : ()
		IxSHIP_QTY = 8, 	// Shipping : ()
		IxCONFIRM_QTY = 9, 	// Confirm : ()
		IxADVICE_QTY = 10, 	// Advice : ()
		IxUSAGE_QTY = 11, 	// Usage : ()
		IxPK_QTY = 12, 	// P/K : ()
		IxSHIP_YN = 13, 	// Shipping : ()
		IxPURCHASE_YN = 14, 	// Purchase : ()
		IxOUT_SIDE_YN = 15, 	// Out Side : ()
		IxSTYLE_ITEM_DIV = 16, 	// Item Div. : ()
		IxATTRIBUTE = 17, 	// Attribute : ()
		IxSEND_CHK = 18, 	// Trnasform : ()
		IxSEND_YMD = 19, 	// Ship Date : ()
		IxREMARKS = 20, 	// Remarks : ()
		IxITEM_CD = 21, 	// Item Code : ()
		IxSPEC_CD = 22, 	// Spec Code : ()
		IxCOLOR_CD = 23, 	// Color Code : ()
		IxSTATUS = 24, 	// MRP : ()
		IxPUR_STATUS = 25, 	// Purchase : ()
		IxUSER = 26, 	// User : ()
		IxOBS_ID = 27, 	// ID : ()
		IxOBS_TYPE = 28, 	// Type : ()
		IxPO_NO = 29, 	// Po No : () 

	}

 
 

	public enum TBSBM_MRP_ITEM_LOT : int
	{
		IxMaxCt = 29,	// 인덱스 Count
		IxLEVEL = 1, 	// Level : ()
		IxMRP_SHIP_NO = 2, 	// MRP Ship No : ()
		IxITEM_NAME = 3, 	// Item : ()
		IxSPEC_NAME = 4, 	// Spec : ()
		IxCOLOR_NAME = 5, 	// Color : ()
		IxUNIT = 6, 	// Unit : ()
		IxPLAN_QTY = 7, 	// Plan : ()
		IxSHIP_QTY = 8, 	// Shipping : ()
		IxCONFIRM_QTY = 9, 	// Confirm : ()
		IxADVICE_QTY = 10, 	// Advice : ()
		IxUSAGE_QTY = 11, 	// Usage : ()
		IxPK_QTY = 12, 	// P/K : ()
		IxSHIP_YN = 13, 	// Shipping : ()
		IxPURCHASE_YN = 14, 	// Purchase : ()
		IxOUT_SIDE_YN = 15, 	// Out Side : ()
		IxSTYLE_ITEM_DIV = 16, 	// Item Div. : ()
		IxATTRIBUTE = 17, 	// Attribute : ()
		IxSEND_CHK = 18, 	// Trnasform : ()
		IxSEND_YMD = 19, 	// Ship Date : ()
		IxREMARKS = 20, 	// Remarks : ()
		IxITEM_CD = 21, 	// Item Code : ()
		IxSPEC_CD = 22, 	// Spec Code : ()
		IxCOLOR_CD = 23, 	// Color Code : ()
		IxSTATUS = 24, 	// MRP : ()
		IxPUR_STATUS = 25, 	// Purchase : ()
		IxUSER = 26, 	// User : ()
		IxOBS_ID = 27, 	// ID : ()
		IxOBS_TYPE = 28, 	// Type : ()
		IxPO_NO = 29 	// Po No : ()
	}

	// Order List (Pop)
	public enum TBSBP_ORDER_LIST_POP : int
	{
		IxMaxCt = 15,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxSEASON = 2, 	// Season : ()
		IxSTYLE_CD = 3, 	// Style Code : ()
		IxSTYLE_NAME = 4, 	// Model Name : ()
		IxCS_SIZE = 5, 	// Size : ()
		IxORDER_QTY = 6, 	// Order Qty : ()
		IxADD_QTY = 7, 	// Add Qty : ()
		IxSRF_NO = 8, 	// SRF No : ()
		IxORDER_TYPE = 9, 	// Order Type : ()
		IxCATEGORY = 10, 	// Category : ()
		IxDEVELOPER = 11, 	// Developer : ()
		IxREMARKS = 12, 	// Remarks : ()
		IxSTATUS = 13, 	// Status : ()
		IxUPD_USER = 14, 	// Upd User : ()
		IxUPD_YMD = 15 	// Upd Ymd : ()
	}

    
	// MRP Monitoring ( Style 별 )
	public enum TBSBM_MRP_MONITORING_STYLE : int
	{
		IxMaxCt = 29,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxSHIP_TYPE = 2, 	// Ship Type : ()
		IxMRP_SHIP_NO = 3, 	// MRP Ship No : ()
		IxOBS_TYPE = 4, 	// Order Type : ()
		IxLOT_NO = 5, 	// No : ()
		IxLOT_SEQ = 6, 	// Seq : ()
		IxSTYLE_CD = 7, 	// Code : ()
		IxSTYLE_NAME = 8, 	// Name : ()
		IxLOT_QTY = 9, 	// Qty : ()
		IxLOSS_QTY = 10, 	// Loss : ()
		IxSHIP_QTY = 11, 	// Ship : ()
		IxSIZE_FROM = 12, 	// From : ()
		IxSIZE_TO = 13, 	// To : ()
		IxSIZE_QTY = 14, 	// Qty : ()
		IxSHIPPING_SCHEDULE = 15, 	// Shipping Schedule : ()
		IxMRP_RUN = 16, 	// Run : ()
		IxMRP_MODIFY = 17, 	// Modify : ()
		IxMRP_SEND = 18, 	// Send : ()
		IxDS_SHIPPING_SCHEDULE = 19, 	// Shipping Schedule : ()
		IxDS_MRP_RECEIVE = 20, 	// MRP Receive : ()
		IxDS_MRP_MODIFY = 21, 	// MRP Modify : ()
		IxDS_PURCHASE_MANAGER = 22, 	// Manager Receive : ()
		IxDS_PURCHASE_ORDER_RECEIVE = 23, 	// Order Receive : ()
		IxDS_PURCHASE_ORDER_MODIFY = 24, 	// Order Modify : ()
		IxDS_SHIPPING_LIST_CREATE = 25, 	// Shipping List Create : ()
		IxDS_SHIPPING_LIST_MODIFY = 26, 	// Shipping List Modify : ()
		IxDS_BAR_CODE = 27, 	// Barcode Create : ()
		IxUPD_USER = 28, 	// Upd User : ()
		IxUPD_YMD = 29 	// Upd Ymd : ()
	}


	// MRP Monitoring ( Item 별 )
	public enum TBSBM_MRP_MONITORING : int
	{
		IxMaxCt = 50,	// 인덱스 Count
		IxIDX = 1, 	// Idx : ()
		IxFACTORY = 2, 	// Factory : ()
		IxSHIP_TYPE = 3, 	// Ship Type : ()
		IxMRP_SHIP_NO = 4, 	// MRP Ship No : ()
		IxLOT_NO = 5, 	// Lot No : ()
		IxLOT_SEQ = 6, 	// Lot Seq : ()
		IxSTYLE_CODE = 7, 	// Style Code : ()
		IxITEM_CD = 8, 	// Item Code : ()
		IxSPEC_CD = 9, 	// Spec Code : ()
		IxCOLOR_CD = 10, 	// Color Code : ()
		IxITEM_NAME = 11, 	// Item : ()
		IxSPEC_NAME = 12, 	// Specifition : ()
		IxCOLOR_NAME = 13, 	// Color : ()
		IxCONFIRM_QTY = 14, 	// Confirm Qty : ()
		IxUSAGE_QTY = 15, 	// Usage Qty : ()
		IxCONFIRM_QTY_DS = 16, 	// Confimr Qty (DS) : ()
		IxUNIT = 17, 	// Unit : ()
		IxSHIP_YN = 18, 	// Shipping : ()
		IxPURCHASE_YN = 19, 	// Purchase : ()
		IxOUTSIDE_YN = 20, 	// Outside : ()
		IxSTYLE_ITEM_DIV = 21, 	// Style Item Div : ()
		IxST_MRP_REQUEST_FOREIGN = 22, 	// MRP : ()
		IxST_MRP_REQUEST_DS = 23, 	// DS MRP : ()
		IxST_PURCHASE_MANAGER = 24, 	// PM : ()
		IxST_PURCHASE = 25, 	// PO : ()
		IxST_SHIPPING_LIST = 26, 	// SL : ()
		IxST_IN = 27, 	// IN : ()
		IxST_OUT = 28, 	// OUT : ()
		IxOBS_ID = 29, 	// Id : ()
		IxOBS_TYPE = 30, 	// Type : ()
		IxCUST_CD = 31, 	// Code : ()
		IxCUST_NAME = 32, 	// Name : ()
		IxPUR_USER = 33, 	// Pur User : ()
		IxPUR_NO = 34, 	// No : ()
		IxPUR_SEQ = 35, 	// Seq : ()
		IxPUR_QTY = 36, 	// Qty : ()
		IxSHIP_NO = 37, 	// Ship No : ()
		IxSHIP_SEQ = 38, 	// Ship Seq : ()
		IxPK_NO = 39, 	// PK No : ()
		IxSHIP_QTY = 40, 	// Qty : ()
		IxBAR_CODE_REP = 41, 	// Barcode Rep# : ()
		IxSCAN_IN_YMD = 42, 	// Scan Date : ()
		IxIN_LOCATION = 43, 	// Location : ()
		IxIN_CONT_NO = 44, 	// Container No : ()
		IxIN_SCAN_QTY = 45, 	// Scan Qty : ()
		IxSCAN_OUT_YMD = 46, 	// Scan Date : ()
		IxOUT_LOCATION = 47, 	// Location : ()
		IxOUT_CONT_NO = 48, 	// Container No : ()
		IxOUT_TRANSPORT = 49, 	// Transport : ()
		IxOUT_SCAN_QTY = 50 	// Scan Qty : ()
	}

	// Local/ LLT Monitoring By Style (DP)
	public enum TBM_READY_YIELD_LOCAL_DP : int
	{
		IxDEL_MONTH = 1,
		IxOBS_TYPE = 2, 	
		IxSTYLE_CD = 3, 	
		IxSTYLE_NAME = 4,  
		IxITEM_NAME = 5, 
		IxSPEC_NAME = 6,  
		IxCOLOR_NAME = 7, 	 
		IxYIELD_COUNT = 8,  
		IxORDER_QTY = 9,
		IxYIELD_M = 10,
		IxUSAGE = 11,
		IxDIVISION = 12,
		IxMNG_UNIT = 13,
		IxSIZE_YN = 14,
		IxSTYLE_ITEM_DIV = 15,
		IxGEN = 16,
		IxDEV_CD = 17,
		IxSEASON = 18,
		IxSEASON_YEAR = 19,
		IxVENDOR_CD = 20, 
		IxVENDOR_NAME = 21, 
		IxITEM_CD = 22, 	 
		IxSPEC_CD = 23,
		IxCOLOR_CD = 24,
		IxGROUP_CD = 25, 
	}



	// Local/ LLT Monitoring By Style (DPO)
	public enum TBM_READY_YIELD_LOCAL_DPO : int
	{
		IxOBS_ID = 1,
		IxOBS_TYPE = 2, 	
		IxSTYLE_CD = 3, 	
		IxSTYLE_NAME = 4,  
		IxITEM_NAME = 5, 
		IxSPEC_NAME = 6,  
		IxCOLOR_NAME = 7, 	 
		IxYIELD_COUNT = 8,  
		IxORDER_QTY = 9,
		IxYIELD_M = 10,
		IxUSAGE = 11,
		IxDIVISION = 12,
		IxMNG_UNIT = 13,
		IxSIZE_YN = 14,
		IxSTYLE_ITEM_DIV = 15,
		IxGEN = 16,
		IxPST_YN = 17,
		IxSEASON = 18,
		IxSEASON_YEAR = 19,
		IxVENDOR_CD = 20, 
		IxVENDOR_NAME = 21, 
		IxITEM_CD = 22, 	 
		IxSPEC_CD = 23,
		IxCOLOR_CD = 24,
		IxGROUP_CD = 25, 
	}

	public enum TBM_MRP_USAGE_LOCAL :int
	{
		IxCHK			= 1,
		IxFACTORY		= 2,
		IxOBS_ID		= 3,
		IxOBS_TYPE		= 4,
		IxSTYLE_CD		= 5,
		IxSTYLE_NAME	= 6,
		IxYIELD_STATUS	= 7,
		IxLOT_TOT		= 8,
		IxSTATUS		= 9,
		IxCHANGE_QTY	= 10,
		IxCHANGE_DATE	= 11,
		IxYIELD_COUNT	= 12,
		IxIMPORT_COUNT	= 13,
		IxUPPER_COUNT	= 14,
		IxBOTTOM_COUNT	= 15,
		IxPLAN_YMD		= 16,
		IxCHANGE_CODE	= 17,
		IxCHANGE_INFO	= 18,
		IxREMARKS		= 19,
		IxUPD_USER		= 20,
		IxUPD_YMD		= 21
	}

	public enum TBSBM_MRP_MONITORING_LOCAL : int
	{
		IxLEV = 1, 
		IxSTYLE_CODE = 2, 
		IxSTYLE_NAME = 3, 
		IxCOLOR_NAME = 4, 
		IxUNIT = 5, 
		IxYIELD_M = 6, 
		IxTOT_QTY = 7, 
		IxFACTORY = 8, 
		IxSTYLE_CD = 9, 
		IxITEM_CD = 10, 
		IxSPEC_CD = 11, 
		IxCOLOR_CD = 12,
		IxCOL = 13,
		IxDAT = 14
	}

	#endregion 

	#region 안상민 추가

	/// <summary> 
	/// SDC_MODEL 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSDC_MODEL : int
	{
		IxMaxCt			= 14,	// 인덱스 Count
		IxMODEL_CD		= 1, 	//   : VARCHAR2(6)
		IxMODEL_NAME	= 2, 	// 모델명 : VARCHAR2(60)
		IxCATEGORY		= 3, 	// 카테고리 : 모델에 대한 유형 : VARCHAR2(4)
		IxPATTERN		= 4, 	// 패턴 : VARCHAR2(5)
		IxTOOL_CD		= 5, 	// Out Sole몰드코드 : VARCHAR2(5)
		IxSET_PH		= 6, 	// Phylon유무 : VARCHAR2(1)
		IxSET_PH_SPU	= 7, 	// Phylon With Soft Pu : VARCHAR2(1)
		IxPH_TYPE		= 8, 	// Phylon Type(EVA,CMP,INJECTION) : VARCHAR2(2)
		IxSET_HPU		= 9, 	// PU 유무 : VARCHAR2(1)
		IxSET_HPU_SPU	= 10, 	// Pu With Soft Pu : VARCHAR2(1)
		IxSET_SPU		= 11, 	// Soft Pu 유무 : VARCHAR2(1)
		IxREMARKS		= 12, 	// 비고 : VARCHAR2(200)
		IxUPD_YMD		= 13, 	//   : DATE(7)
		IxUPD_USR		= 14 	// 작성자 : VARCHAR2(30)
	}

	/// <summary> 
	/// SDC_STYLE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSDC_STYLE : int
	{
		IxMaxCt			= 22,	// 인덱스 Count
		IxSTYLE_CD		= 1, 	// 스타일코드 : VARCHAR2(9)
		IxMODEL_CD		= 2, 	//   : VARCHAR2(6)
		IxSTYLE_NAME	= 3, 	// 스타일명 : VARCHAR2(60)
		IxSTYLE_YEAR	= 4, 	// 년도 : VARCHAR2(4)
		IxSEASON		= 5, 	// 시즌 : VARCHAR2(2)
		IxDEV_FACT		= 6, 	//   : VARCHAR2(2)
		IxDEV_CD		= 7, 	// 생산코드 : VARCHAR2(6)
		IxCFM_CHK		= 8, 	// Confirm Shoe 유무 : VARCHAR2(1)
		IxTEST_CHK		= 9, 	// 시화구분 : VARCHAR2(1)
		IxUPPER_CHK		= 10, 	// Upper 채산 유무 : VARCHAR2(1)
		IxBOTTOM_CHK	= 11, 	//   : VARCHAR2(1)
		IxGENDER		= 12, 	//   : VARCHAR2(2)
		IxLAST_CD		= 13, 	// LAST CODE : VARCHAR2(5)
		IxSILUET		= 14, 	// 실루엣 : VARCHAR2(4)
		IxCURRENCY		= 15, 	//   : VARCHAR2(4)
		IxCOST			= 16, 	//  : NUMBER(22)
		IxB_COST		= 17, 	//  : NUMBER(22)
		IxPRESTO_YN		= 18, 	//   : VARCHAR2(1)
		IxWIDTH_DIV		= 19, 	// Width_YN 구분 : VARCHAR2(1)
		IxREMARKS		= 20, 	// 비고 : VARCHAR2(500)
		IxUPD_YMD		= 21, 	//   : DATE(7)
		IxUPD_USER		= 22 	//   : VARCHAR2(30)
	}

	/// <summary> 
	/// SBP_REQUEST_TAIL 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBP_REQUEST_TAIL : int
	{
		IxMaxCt = 30,	// 인덱스 Count
		IxSEQ = 1, 	// Seq : ()
		IxFACTORY = 2, 	// Factory : VARCHAR2(5)
		IxREQ_NO = 3, 	// No : VARCHAR2(20)
		IxREQ_SEQ = 4, 	// Seq : NUMBER(22)
		IxITEM_NM = 5, 	// Item : ()
		IxSPEC_NM = 6, 	// Specifition : ()
		IxCOLOR_NM = 7, 	// Color : ()
		IxUNIT_NM = 8, 	// Unit : ()
		IxREQ_QTY = 9, 	// Request Qty : NUMBER(22)
		IxRTA_YMD = 10, 	// RTA : VARCHAR2(8)
		IxETS1_YMD = 11, 	// ETS 1st : VARCHAR2(8)
		IxETS2_YMD = 12, 	// ETS 2nd : VARCHAR2(8)
		IxLOT_NO = 13, 	// No : VARCHAR2(9)
		IxLOT_SEQ = 14, 	// Seq : VARCHAR2(2)
		IxSTYLE_CD = 15, 	// Style Code : VARCHAR2(9)
		IxMODEL_NAME = 16, 	// Model : VARCHAR2(100)
		IxOBS_ID = 17, 	// Id : VARCHAR2(6)
		IxOBS_TYPE = 18, 	// Type : VARCHAR2(2)
		IxOFFER_YN = 19, 	// Offer Y/N : ()
		IxITEM_CD = 20, 	// Item Code : VARCHAR2(10)
		IxSPEC_CD = 21, 	// Spec Code : VARCHAR2(5)
		IxCOLOR_CD = 22, 	// Color Code : VARCHAR2(5)
		IxSEMI_GOOD_CD = 23, 	// Semi Good Cd : VARCHAR2(10)
		IxCOMPONENT_CD = 24, 	// Component Cd : VARCHAR2(15)
		IxWORK_DIV = 25, 	// Work Div : VARCHAR2(10)
		IxSTATUS = 26, 	// Status : VARCHAR2(10)
		IxSEND_CHK = 27, 	// Send Chk : VARCHAR2(10)
		IxSEND_YMD = 28, 	// Send Date : DATE(7)
		IxUPD_USER = 29, 	// Upd User : VARCHAR2(30)
		IxUPD_YMD = 30 	// Upd Ymd : DATE(7)
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

	public enum TBSBP_PURCHASE_MANAGER : int
	{
		IxMaxCt = 54,	// 인덱스 Count
		IxLEV = 1, 	// LEV : ()
		IxCHK = 2, 	// C : ()
		IxDATA_FROM = 3, 	// From : ()
		IxFACTORY = 4, 	// Factory : VARCHAR2(10)
		IxMANAGER_SEQ = 5, 	// Manager Seq : VARCHAR2(13)
		IxSTYLE_CD = 6, 	// Style : VARCHAR2(9)
		IxITEM_NAME = 7, 	// Item : ()
		IxSPEC_NAME = 8, 	// Specification : ()
		IxCOLOR_NAME = 9, 	// Color : ()
		IxUNIT_NM = 10, 	// Unit : ()
		IxSTYLE_NAME = 11, 	// Style : ()
		IxSTATUS_NAME = 12, 	// Status : ()
		IxREQ_QTY = 13, 	// Request : NUMBER(22)
		IxPUR_QTY = 14, 	// Purchase : NUMBER(22)
		IxPUR_CURRENCY = 15, 	// Currency : VARCHAR2(3)
		IxPUR_PRICE = 16, 	// Price : NUMBER(22)
		IxCBD_CURRENCY = 17, 	// Curency : VARCHAR2(3)
		IxCBD_PRICE = 18, 	// Price : NUMBER(22)
		IxSHIP_CURRENCY = 19, 	// Currency : VARCHAR2(3)
		IxSHIP_PRICE = 20, 	// Price : NUMBER(22)
		IxPACKING = 21, 	// Packing : VARCHAR2(5)
		IxPK_NO = 22, 	// PK No : VARCHAR2(6)
		IxPK_NO_FROM = 23, 	// Pk No From : VARCHAR2(6)
		IxPK_NO_TO = 24, 	// Pk No To : VARCHAR2(6)
		IxPK_UNIT_QTY = 25, 	// P/K Qty : NUMBER(22)
		IxCT_QTY = 26, 	// C/T : NUMBER(22)
		IxCUST_CD = 27, 	// Code : VARCHAR2(6)
		IxCUST_NAME = 28, 	// Name : ()
		IxPUR_USER = 29, 	// Purchase User : VARCHAR2(30)
		IxSHIP_YMD = 30, 	// Date : VARCHAR2(8)
		IxSHIP_NO = 31, 	// No : VARCHAR2(20)
		IxSHIP_SEQ = 32, 	// Seq : VARCHAR2(4)
		IxSHIP_TYPE = 33, 	// Type : VARCHAR2(10)
		IxREQ_YMD = 34, 	// Date : VARCHAR2(8)
		IxREQ_NO = 35, 	// No : VARCHAR2(20)
		IxREQ_SEQ = 36, 	// Seq : VARCHAR2(4)
		IxREQ_REASON = 37, 	// Reason : VARCHAR2(10)
		IxLOT_NO = 38, 	// No : VARCHAR2(9)
		IxLOT_SEQ = 39, 	// Seq : VARCHAR2(2)
		IxOBS_TYPE = 40, 	// Type : VARCHAR2(2)
		IxITEM_CD = 41, 	// Item : VARCHAR2(10)
		IxSPEC_CD = 42, 	// Spec Cd : VARCHAR2(5)
		IxCOLOR_CD = 43, 	// Color Cd : VARCHAR2(5)
		IxPRICE_YN = 44, 	// Price Y/N  : VARCHAR2(1)
		IxPUR_NO = 45, 	// Purhcase No : VARCHAR2(20)
		IxPUR_SEQ = 46, 	// Pur Seq : VARCHAR2(20)
		IxREMARKS = 47, 	// Remarks : VARCHAR2(500)
		IxSTATUS = 48, 	// Status : VARCHAR2(10)
		IxSIZE_ITEM_YN = 49, 	// Size YN : ()
		IxSAVE_STATE = 50, 	// SAVE_STATE : ()
		IxSAVE_STATE_CBD = 51, 	// SAVE_STATE_CBD : ()
		IxSHIP_SIZE_YN = 52, 	// Ship Size : VARCHAR2(1)
		IxUPD_USER = 53, 	//   : VARCHAR2(30)
		IxUPD_YMD = 54 	//   : DATE(7)
	}



	public enum TBSBP_PURCHASE_HEAD : int
	{
		IxMaxCt			= 16,	// 인덱스 Count
		IxFACTORY		= 1, 	//   : VARCHAR2(5)
		IxPUR_NO		= 2, 	// 발주번호 : VARCHAR2(20)
		IxPUR_YMD		= 3, 	//   : VARCHAR2(8)
		IxPUR_USER		= 4, 	//   : VARCHAR2(30)
		IxRTA_YMD		= 5, 	// RTA : VARCHAR2(8)
		IxETS_YMD		= 6, 	// 납기일 : VARCHAR2(8)
		IxPUR_DIV		= 7, 	// 구매형태 : VARCHAR2(10)
		IxBUY_DIV		= 8, 	//   : VARCHAR2(10)
		IxPUR_STATUS	= 9, 	// 발주상태 : VARCHAR2(10)
		IxSHIP_NO		= 10, 	//   : VARCHAR2(20)
		IxSHIP_VERSION	= 11, 	// 선적NO버젼 : NUMBER(22)
		IxSHIP_FACTORY	= 12, 	// 선적공장 : VARCHAR2(5)
		IxSHIP_YMD		= 13, 	//   : VARCHAR2(8)
		IxMRP_NO		= 14, 	// MRP No : VARCHAR2(20)
		IxCONFIRM_YN	= 15, 	//   : VARCHAR2(1)
		IxREMARKS		= 16 	// 비고 : VARCHAR2(500)
	}

	public enum TBSBP_PUR_HEAD_LIST : int
	{
		IxMaxCt = 19,	// 인덱스 Count
		IxFACTORY = 1, 	//   : ()
		IxPUR_NO = 2, 	// 발주번호 : ()
		IxPUR_YMD = 3, 	//   : ()
		IxPUR_USER = 4, 	//   : ()
		IxRTA_YMD = 5, 	// RTA : ()
		IxETS_YMD = 6, 	// 납기일 : ()
		IxPUR_DIV = 7, 	// 구매형태 : ()
		IxPUR_DIV_NM = 8, 	//   : ()
		IxBUY_DIV = 9, 	//   : ()
		IxBUY_DIV_NM = 10, 	//   : ()
		IxPUR_STATUS = 11, 	// 발주상태 : ()
		IxPUR_STATUS_NM = 12, 	//   : ()
		IxSHIP_NO = 13, 	//   : ()
		IxSHIP_VERSION = 14, 	// 선적NO버젼 : ()
		IxSHIP_FACTORY = 15, 	// 선적공장 : ()
		IxSHIP_YMD = 16, 	//   : ()
		IxMRP_NO = 17, 	// MRP No : ()
		IxCONFIRM_YN = 18, 	//   : ()
		IxREMARKS = 19 	// 비고 : ()
	}

	public enum TBSBP_PURCHASE_TAIL : int
	{
		IxMaxCt = 51,	// 인덱스 Count
		IxLEV = 1, 	//   : ()
		IxSEQ = 2, 	// Seq : ()
		IxFACTORY = 3, 	// Factory : VARCHAR2(5)
		IxPUR_NO = 4, 	// Pur No : VARCHAR2(20)
		IxPUR_SEQ = 5, 	// Seq : NUMBER(22)
		IxLOT_NO = 6, 	// Lot No : VARCHAR2(9)
		IxLOT_SEQ = 7, 	// Lot Seq : VARCHAR2(2)
		IxSTYLE_NM = 8, 	// Style Name : ()
		IxITEM_NM = 9, 	// Item : ()
		IxSPEC_NM = 10, 	// Specification : ()
		IxCOLOR_NM = 11, 	// Color : ()
		IxUNIT_NM = 12, 	// Unit : ()
		IxSTYLE_CD = 13, 	// Style Code : VARCHAR2(9)
		IxEST_PUR_QTY = 14, 	// Req : NUMBER(22)
		IxNEED_QTY = 15, 	// Need : NUMBER(22)
		IxPUR_QTY = 16, 	// Purch : NUMBER(22)
		IxIN_QTY = 17, 	// Income : NUMBER(22)
		IxPK_UNIT_QTY = 18, 	// P/K : NUMBER(22)
		IxPUR_CURRENCY = 19, 	// Currency : VARCHAR2(10)
		IxPUR_PRICE = 20, 	// Price : NUMBER(22)
		IxOUTSIDE_CURRENCY = 21, 	// Currency : VARCHAR2(10)
		IxOUTSIDE_PRICE = 22, 	// Price : NUMBER(22)
		IxCBD_CURRENCY = 23, 	// Currency : VARCHAR2(10)
		IxCBD_PRICE = 24, 	// Price : NUMBER(22)
		IxCUST_CD = 25, 	// Code : VARCHAR2(10)
		IxCUST_NM = 26, 	// Name : ()
		IxCBM = 27, 	// CBM : NUMBER(22)
		IxWEIGHT = 28, 	// Weight : NUMBER(22)
		IxRTA_YMD = 29, 	// RTA : VARCHAR2(8)
		IxETS_YMD1 = 30, 	// ETS 1st : VARCHAR2(8)
		IxETS_YMD2 = 31, 	// ETS 2nd : VARCHAR2(8)
		IxETS_YMD3 = 32, 	// ETS 3rd : VARCHAR2(8)
		IxPUR_DEPT = 33, 	// Purchase : VARCHAR2(10)
		IxREQ_DEPT = 34, 	// Request : VARCHAR2(10)
		IxLOT_QTY = 35, 	// Lot Qty : NUMBER(22)
		IxSHIP_QTY = 36, 	// Ship Qty : NUMBER(22)
		IxITEM_CD = 37, 	// Item : VARCHAR2(10)
		IxSPEC_CD = 38, 	// Spec : VARCHAR2(5)
		IxCOLOR_CD = 39, 	// Color : VARCHAR2(5)
		IxTAX_CD = 40, 	// TAX Code : VARCHAR2(10)
		IxPAY_CD = 41, 	// Pay Code : VARCHAR2(10)
		IxLC_NO = 42, 	// L/C No : VARCHAR2(20)
		IxREQ_NO = 43, 	// No : VARCHAR2(20)
		IxREQ_SEQ = 44, 	// Seq : NUMBER(22)
		IxYIELD_STATUS = 45, 	// Yield Status : VARCHAR2(1)
		IxPUR_STATUS = 46, 	// Status : VARCHAR2(1)
		IxREMARKS = 47, 	// Remarks : VARCHAR2(500)
		IxOFFER_NO = 48, 	// Offer No : VARCHAR2(20)
		IxPUR_DEPT_CD = 49, 	//   : ()
		IxREQ_DEPT_CD = 50, 	//   : ()
		IxUPD_USER = 51 	//   : VARCHAR2(30)
	}






	public enum TBSBP_PURCHASE_DP_SIZE : int
	{
		IxMaxCt = 3,	// 인덱스 Count
		IxKIND = 1, 	//   : ()
		IxTOTAL = 2, 	//   : ()
		IxCOL = 3 	//   : ()
	}




	#endregion  

	#region 정환정 추가



	// Forecast List (Pop)
	public enum TBSBP_FORECAST_LIST_POP : int
	{
		
		IxCHECK_FLAG = 1,
		IxFACTORY = 2, 	
		IxLOT_NO = 3, 	
		IxLOT_SEQ = 4,  
		IxOBS_ID = 5,
		IxOBS_TYPE = 6,
		IxPO_NO = 7,
		IxRGAC = 8,
		IxCS_SIZE = 9,  
		IxLOSS_QTY = 10, 
		IxUSE_QTY = 11,  
		IxNOW_QTY = 12, 	 
		IxSTYLE_CD = 13,
		IxEXIST_YN = 14,
		IxALREADY_USAGE_YN = 15,
 
	}





	// Forecast List
	public enum TBSBP_FORECAST_LIST : int
	{
		   
		IxFACTORY = 1, 
		IxSTYLE_CD = 2, 
		IxLOT_NO = 3, 	
		IxLOT_SEQ = 4,  
		IxOBS_ID = 5,
		IxOBS_TYPE = 6,
		IxPO_NO = 7,
		IxRGAC = 8,
		IxLINE_CD = 9,
		IxPLAN_STRYMD = 10,
		IxPLAN_ENDYMD = 11,
		IxLOT_QTY = 12,
		IxLOSS_QTY = 13,
		IxFORECAST_QTY_SUM = 14,
		IxNOW_REMAIN_DIV = 15, 
		IxEMPTY1 = 16,
		IxEMPTY2 = 17,
		IxCS_SIZE_START = 18,

		// table index
		IxCOL_ORDER = 15,
		IxCS_SIZE = 16,
		IxFORECAST_QTY = 17,
   
 
	}


	
	// SBM_SILHOUETTE
	public enum TBSBM_SILHOUETTE : int
	{
		   
		IxFACTORY = 1,	
		IxLOT_NO = 2,	
		IxLOT_SEQ = 3,	
		IxSTYLE_CD = 4,	
		IxSTYLE_NAME = 5,
		IxSHIPPING_DATE = 6,	
		IxSILHOUETTE_DATE = 7,	
		IxGAP = 8,	
		IxSILHOUETTE_AREA = 9,	
		IxYIELD_STATUS = 10,	
		IxREMARKS = 11,	
		IxUPD_USER = 12,	
		IxUPD_YMD = 13	

	}



	/// <summary> 
	/// SBW_PROCESS 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBM_MRP_LOCAL : int 
	{  
  
		IxFLAG         =  1,
		IxFACTORY      =  2,			
		IxLINE_CD      =  3,			
		IxLOT_NO       =  4,
		IxLOT_SEQ      =  5,			
		IxSTYLE_CD     =  6,			
		IxSTYLE_NAME   =  7,	
		IxYIELD_STATUS =  8,
		IxYIELD_COUNT  =  9,
		IxIMPORT_COUNT = 10,
		IxLOT_QTY      = 11,			
		IxLOSS_QTY     = 12,			
		IxTOTAL_QTY    = 13,			
		IxUSE_QTY      = 14,			
		IxNOW_QTY      = 15,			
		IxOBS_ID       = 16,			
		IxOBS_TYPE     = 17,			
		IxPO_NO        = 18,			
		IxPLAN_STRYMD  = 19,			
		IxPLAN_ENDYMD  = 20,			
		IxTOT_DAY_SEQ  = 21,		
		IxMRP_SHIP_NO  = 22, 

 

	}    



	// Local/ LLT Monitoring By Style (DP)
	public enum TBM_SHIPPING_LOCAL_DP : int
	{
		 
		IxDEL_MONTH = 1,
		IxOBS_TYPE = 2, 	
		IxSTYLE_CD = 3, 	
		IxSTYLE_NAME = 4,  
		IxGEN = 5,
		IxDEV_CD = 6,
		IxSEASON = 7,
		IxSEASON_YEAR = 8,
		IxYIELD_COUNT = 9,  
		IxITEM_NAME = 10, 
		IxSPEC_NAME = 11,  
		IxCOLOR_NAME = 12, 	 
		IxDIVISION = 13,
		IxMNG_UNIT = 14,
		IxSIZE_YN = 15,
		IxSTYLE_ITEM_DIV = 16,  
		IxITEM_CD = 17, 	 
		IxSPEC_CD = 18,
		IxCOLOR_CD = 19,
		IxGROUP_CD = 20, 
 

	}



	// Local/ LLT Monitoring By Style (DPO)
	public enum TBM_SHIPPING_LOCAL_DPO : int
	{
		 
		IxOBS_ID = 1,
		IxOBS_TYPE = 2, 	
		IxSTYLE_CD = 3, 	
		IxSTYLE_NAME = 4,  
		IxGEN = 5,
		IxPST_YN = 6,
		IxSEASON = 7,
		IxSEASON_YEAR = 8,
		IxYIELD_COUNT = 9,  
		IxITEM_NAME = 10, 
		IxSPEC_NAME = 11,  
		IxCOLOR_NAME = 12, 	 
		IxDIVISION = 13,
		IxMNG_UNIT = 14,
		IxSIZE_YN = 15,
		IxSTYLE_ITEM_DIV = 16,  
		IxITEM_CD = 17, 	 
		IxSPEC_CD = 18,
		IxCOLOR_CD = 19,
		IxGROUP_CD = 20, 
 

	}



	// Local/ LLT Material List By SRF
	public enum TBM_MRP_LOCAL_MAT_BY_SRF_SRF : int
	{
		 
		IxTREE_LEVEL = 1,
		IxTREE_KEY = 2, 	
		IxTREE_DESC = 3, 	
		IxSTYLE_CD = 4,  
		IxSTYLE_NAME = 5,
		IxMAT_CD = 6,
		IxMAT_NAME = 7,  
		IxYIELD_VALUE = 8, 
		IxVEN_SEQ = 9, 
		IxVENDOR = 10,  
		IxFACTORY = 11,  
		IxIMPORT_YN = 12, 
		IxSR_NO = 13,  
		IxSRF_NO = 14, 	 
		IxBOM_ID = 15,
		IxBOM_REV = 16,
		IxSAMPLE_TYPES = 17, 
		IxPART_TYPE = 18,  
 

	} 


	// Local/ LLT Material List By SRF
	public enum TBM_MRP_LOCAL_MAT_BY_SRF_YIELD : int
	{
		 
		IxTREE_LEVEL = 1,
		IxTREE_KEY = 2, 	
		IxTREE_DESC = 3, 	
		IxSTYLE_CD = 4,  
		IxSTYLE_NAME = 5,
		IxITEM_CD = 6,
		IxITEM_NAME = 7, 
		IxYIELD_VALUE = 8, 
		IxCUST_CD = 9, 
		IxCUST_NAME = 10, 
		IxFACTORY = 11,  
		IxIMPORT_DIV = 12, 
		IxDELIVERY = 13,  
		IxMNG_UNIT = 14, 	 
		IxSIZE_YN = 15,
		IxSTYLE_ITEM_DIV = 16, 
 

	} 
   

	#endregion    
	
	#region 박지수 추가

	/// <summary> 
	/// SBI_IN_TAIL 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBI_IN_TAIL : int
	{
		IxMaxCt = 50,	// 인덱스 Count
		IxSEQ = 1, 	// Seq : ()
		IxFACTORY = 2, 	// Factory : VARCHAR2(5)
		IxIN_NO = 3, 	// In No : VARCHAR2(20)
		IxIN_SEQ = 4, 	// Seq : NUMBER(22)
		IxITEM = 5, 	// Material : ()
		IxITEM_CD = 6, 	// Item : VARCHAR2(10)
		IxITEM_NAME = 7, 	// Item : ()
		IxSPEC_CD = 8, 	// Specification : VARCHAR2(5)
		IxSPEC_NAME = 9, 	// Specification : ()
		IxCOLOR_CD = 10, 	// Color : VARCHAR2(5)
		IxCOLOR_NAME = 11, 	// Color : ()
		IxIN_QTY = 12, 	// In Qty : NUMBER(22)
		IxUNIT = 13, 	// Unit : ()
		IxPK_UNIT_QTY = 14, 	// P/K Qty : NUMBER(22)
		IxPUR_CURRENCY = 15, 	// Currency : VARCHAR2(10)
		IxPUR_PRICE = 16, 	// Price : NUMBER(22)
		IxOUTSIDE_CURRENCY = 17, 	// Currency : VARCHAR2(10)
		IxOUTSIDE_PRICE = 18, 	// Price : NUMBER(22)
		IxCBD_CURRENCY = 19, 	// Currency : VARCHAR2(10)
		IxCBD_PRICE = 20, 	// Price : NUMBER(22)
		IxSHIP_CURRENCY = 21, 	// Currency : VARCHAR2(10)
		IxSHIP_PRICE = 22, 	// Price : NUMBER(22)
		IxPRICE_YN = 23, 	// Price Y/N : VARCHAR2(1)
		IxCUST_CD = 24, 	// Code : VARCHAR2(10)
		IxCUST_NAME = 25, 	// Name : ()
		IxTAX_CD = 26, 	// Tax : VARCHAR2(10)
		IxBAR_CODE = 27, 	// BAR CODE : VARCHAR2(24)
		IxBAR_KIND = 28, 	// Barcode Kind : VARCHAR2(4)
		IxCONT_NO = 29, 	// Container No : VARCHAR2(20)
		IxSHIP_YMD = 30, 	// Date : VARCHAR2(8)
		IxSHIP_NO = 31, 	// No : VARCHAR2(20)
		IxSHIP_SEQ = 32, 	// Seq : VARCHAR2(4)
		IxSHIP_QTY = 33, 	// Qty : NUMBER(22)
		IxLOT_NO = 34, 	// No : VARCHAR2(12)
		IxLOT_SEQ = 35, 	// Seq : VARCHAR2(2)
		IxSTYLE_CD = 36, 	// Code : VARCHAR2(9)
		IxSTYLE_NAME = 37, 	// Name : ()
		IxWH_CD = 38, 	// WareHouse : VARCHAR2(10)
		IxWH_NAME = 39, 	// WareHouse : ()
		IxPAY_CD = 40, 	// Pay Code : VARCHAR2(10)
		IxPUR_NO = 41, 	// No : VARCHAR2(20)
		IxPUR_SEQ = 42, 	// Seq : NUMBER(22)
		IxPUR_USER = 43, 	// User : VARCHAR2(30)
		IxPUR_DEPT = 44, 	// Dept : VARCHAR2(10)
		IxIN_STATUS = 45, 	// In Status : VARCHAR2(10)
		IxREMARKS = 46, 	// Remarks : VARCHAR2(500)
		IxMOD_QTY = 47, 	//   : NUMBER(22)
		IxTRAN_DIV = 48, 	//   : VARCHAR2(1)
		IxUPD_USER = 49, 	//   : VARCHAR2(30)
		IxUPD_YMD = 50 	//   : DATE(7)
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

	public enum TBSBI_INCOMING_BARCODE : int
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
		IxSCAN_QYT = 10, 	// Scan Qty : ()
		IxIN_QTY = 11, 	// In Qty : ()
		IxUNIT = 12, 	// Unit : ()
		IxSHIP_YMD = 13, 	// Date : ()
		IxSHIP_NO = 14, 	// No : ()
		IxSHIP_SEQ = 15, 	// Seq : ()
		IxLOT_NO = 16, 	// No : ()
		IxLOT_SEQ = 17, 	// Seq : ()
		IxSTYLE_CD = 18, 	// Code : ()
		IxSTYLE_NAME = 19, 	// Name : ()
		IxPK_UNIT_QTY = 20, 	// P/K Qty : ()
		IxCUST_CD = 21, 	// Code : ()
		IxCUST_NAME = 22, 	// Name : ()
		IxWH_CD = 23, 	// WareHouse : ()
		IxWH_NAME = 24, 	// WareHouse : ()
		IxBAR_KIND = 25, 	// Barcode Kind : ()
		IxCONT_NO = 26, 	// Container No : ()
		IxPUR_CURRENCY = 27, 	// Currency : ()
		IxCBD_PUR_CURRENCY = 28, 	// CBD : ()
		IxCHECK_PUR = 29, 	// Check : ()
		IxPUR_PRICE = 30, 	// Price : ()
		IxCBD_CURRENCY = 31, 	// Currency : ()
		IxCBD_CBD_CURRENCY = 32, 	// CBD : ()
		IxCHECK_CBD = 33, 	// Check : ()
		IxCBD_PRICE = 34, 	// Price : ()
		IxSHIP_CURRENCY = 35, 	// Currency : ()
		IxCBD_SHIP_CURRENCY = 36, 	// CBD : ()
		IxCHECK_SHIP = 37, 	// Check : ()
		IxSHIP_PRICE = 38, 	// Ship Price : ()
		IxPRICE_YN = 39, 	// Price Y/N : ()
		IxUPD_USER = 40, 	// User : ()
		IxUPD_YMD = 41 	//   : ()
	}

	public enum TBSBI_INCOMING_PUR : int
	{
		IxMaxCt = 47,	// 인덱스 Count
		IxCHK = 1, 	// C : ()
		IxFACTORY = 2, 	// Factory : ()
		IxPUR_NO = 3, 	// No : ()
		IxPUR_SEQ = 4, 	// Seq : ()
		IxPUR_YMD = 5, 	// Date : ()
		IxPUR_USER = 6, 	// User : ()
		IxITEM_CD = 7, 	// Item : ()
		IxITEM_NAME = 8, 	// Item : ()
		IxSPEC_CD = 9, 	// Specification : ()
		IxSPEC_NAME = 10, 	// Specification : ()
		IxCOLOR_CD = 11, 	// Color : ()
		IxCOLOR_NAME = 12, 	// Color : ()
		IxPUR_QTY = 13, 	// Pur Qty : ()
		IxIN_QTY = 14, 	// In Qty : ()
		IxUNIT = 15, 	// Unit : ()
		IxPK_UNIT_QTY = 16, 	// P/K Qty : ()
		IxPUR_DEPT = 17, 	// Dept : ()
		IxDEPT_NAME = 18, 	// Dept : ()
		IxPUR_CURRENCY = 19, 	// Currency : ()
		IxCBD_PUR_CURRENCY = 20, 	//   : ()
		IxCHECK_PUR = 21, 	//   : ()
		IxPUR_PRICE = 22, 	// Price : ()
		IxOUTSIDE_CURRENCY = 23, 	// Currency : ()
		IxCBD_OUTSIDE_CURRENCY = 24, 	//   : ()
		IxCHECK_OUTSIDE = 25, 	//   : ()
		IxOUTSIDE_PRICE = 26, 	// Price : ()
		IxCBD_CURRENCY = 27, 	// Currency : ()
		IxCBD_CBD_CURRENCY = 28, 	//   : ()
		IxCHECK_CBD = 29, 	//   : ()
		IxCBD_PRICE = 30, 	// Price : ()
		IxCUST_CD = 31, 	// Code : ()
		IxCUST_NAME = 32, 	// Name : ()
		IxTAX_CD = 33, 	// TAX : ()
		IxPAY_CD = 34, 	// Pay : ()
		IxOFFER_NO = 35, 	// Offer No : ()
		IxLC_NO = 36, 	// LC No : ()
		IxINV_NO = 37, 	// Inv No : ()
		IxLOT_NO = 38, 	// No : ()
		IxLOT_SEQ = 39, 	// Seq : ()
		IxLOT_QTY = 40, 	// Qty : ()
		IxSTYLE_CD = 41, 	// Code : ()
		IxSTYLE_NAME = 42, 	// Name : ()
		IxSHIP_QTY = 43, 	// Qty : ()
		IxSHIP_NO = 44, 	// No : ()
		IxSHIP_YMD = 45, 	// Date : ()
		IxUPD_USER = 46, 	//   : ()
		IxUPD_YMD = 47 	//   : ()
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
	
	public enum TBSBI_IN_ITEM_INSPECT_M : int
	{
		IxMaxCt = 36,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
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
		IxPUR_PRICE = 14, 	// Price : ()
		IxAMOUNT_USD = 15, 	// Amount($) : ()
		IxAMOUNT_KRW = 16, 	// Amount(W) : ()
		IxPUR_CURRENCY = 17, 	// Currency : ()
		IxPUR_NO = 18, 	// No : ()
		IxPUR_SEQ = 19, 	// Seq : ()
		IxLOT_NO = 20, 	// No : ()
		IxLOT_SEQ = 21, 	// Seq : ()
		IxSTYLE_CD = 22, 	// Code : ()
		IxSTYLE_NAME = 23, 	// Name : ()
		IxREMARKS = 24, 	// Remarks : ()
		IxITEM = 25, 	// Item : ()
		IxGROUP_T_CD = 26, 	//   : ()
		IxGROUP_L_CD = 27, 	//   : ()
		IxGROUP_M_CD = 28, 	//   : ()
		IxCLASS_TYPE = 29, 	//   : ()
		IxFIRST_CLASS = 30, 	//   : ()
		IxSECOND_CLASS = 31, 	//   : ()
		IxGROUP_CD = 32, 	//   : ()
		IxYMD_VENDOR = 33, 	//   : ()
		IxYMD_ITEM = 34, 	//   : ()
		IxVENDOR_ITEM = 35, 	//   : ()
		IxUPD_YMD = 36 	//   : ()
	}

	public enum TBSBI_IN_ITEM_INSPECT_V : int
	{
		IxMaxCt = 36,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
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
		IxPUR_PRICE = 14, 	// Price : ()
		IxAMOUNT_USD = 15, 	// Amount($) : ()
		IxAMOUNT_KRW = 16, 	// Amount(W) : ()
		IxPUR_CURRENCY = 17, 	// Currency : ()
		IxPUR_NO = 18, 	// No : ()
		IxPUR_SEQ = 19, 	// Seq : ()
		IxLOT_NO = 20, 	// No : ()
		IxLOT_SEQ = 21, 	// Seq : ()
		IxSTYLE_CD = 22, 	// Code : ()
		IxSTYLE_NAME = 23, 	// Name : ()
		IxREMARKS = 24, 	// Remarks : ()
		IxITEM = 25, 	//   : ()
		IxGROUP_T_CD = 26, 	//   : ()
		IxGROUP_L_CD = 27, 	//   : ()
		IxGROUP_M_CD = 28, 	//   : ()
		IxCLASS_TYPE = 29, 	//   : ()
		IxFIRST_CLASS = 30, 	//   : ()
		IxSECOND_CLASS = 31, 	//   : ()
		IxGROUP_CD = 32, 	//   : ()
		IxYMD_VENDOR = 33, 	//   : ()
		IxYMD_ITEM = 34, 	//   : ()
		IxVENDOR_ITEM = 35, 	//   : ()
		IxUPD_YMD = 36 	//   : ()
	}

	public enum TBSBI_IN_ITEM_INSPECT_C : int
	{
		IxMaxCt = 36,	// 인덱스 Count
		IxFACTORY = 1, 	//   : ()
		IxCLASS_TYPE = 2, 	//   : ()
		IxFIRST_CLASS = 3, 	// First : ()
		IxSECOND_CLASS = 4, 	// Second : ()
		IxGROUP_T_CD = 5, 	//   : ()
		IxGROUP_L_CD = 6, 	//   : ()
		IxGROUP_M_CD = 7, 	//   : ()
		IxCUST_CD = 8, 	// Vendor : ()
		IxCUST_NAME = 9, 	// Vendor : ()
		IxPUR_USER = 10, 	// User : ()
		IxITEM_CD = 11, 	// Item : ()
		IxITEM_NAME = 12, 	// Item : ()
		IxSPEC_CD = 13, 	// Specification : ()
		IxSPEC_NAME = 14, 	// Specification : ()
		IxCOLOR_CD = 15, 	// Color : ()
		IxCOLOR_NAME = 16, 	// Color : ()
		IxIN_QTY = 17, 	// In Qty : ()
		IxUNIT = 18, 	// Unit : ()
		IxIN_YMD = 19, 	// In Date : ()
		IxPUR_PRICE = 20, 	// Price : ()
		IxAMOUNT_USD = 21, 	// Amount($) : ()
		IxAMOUNT_KRW = 22, 	// Amount(W) : ()
		IxPUR_CURRENCY = 23, 	// Currency : ()
		IxPUR_NO = 24, 	// No : ()
		IxPUR_SEQ = 25, 	// Seq : ()
		IxLOT_NO = 26, 	// No : ()
		IxLOT_SEQ = 27, 	// Seq : ()
		IxSTYLE_CD = 28, 	// Code : ()
		IxSTYLE_NAME = 29, 	// Name : ()
		IxREMARKS = 30, 	// Remarks : ()
		IxITEM = 31, 	//   : ()
		IxGROUP_CD = 32, 	//   : ()
		IxUPD_YMD = 33, 	//   : ()
		IxYMD_VENDOR = 34, 	//   : ()
		IxYMD_ITEM = 35, 	//   : ()
		IxVENDOR_ITEM = 36 	//   : ()
	}

	public enum TBSBI_IN_ITEM_INSPECT_D : int
	{
		IxMaxCt = 36,	// 인덱스 Count
		IxFACTORY = 1, 	//   : ()
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
		IxPUR_PRICE = 14, 	// Price : ()
		IxAMOUNT_USD = 15, 	// Amount($) : ()
		IxAMOUNT_KRW = 16, 	// Amount(W) : ()
		IxPUR_CURRENCY = 17, 	// Currency : ()
		IxPUR_NO = 18, 	// No : ()
		IxPUR_SEQ = 19, 	// Seq : ()
		IxLOT_NO = 20, 	// No : ()
		IxLOT_SEQ = 21, 	// Seq : ()
		IxSTYLE_CD = 22, 	// Code : ()
		IxSTYLE_NAME = 23, 	// Name : ()
		IxREMARKS = 24, 	// Remarks : ()
		IxITEM = 25, 	//   : ()
		IxGROUP_T_CD = 26, 	//   : ()
		IxGROUP_L_CD = 27, 	//   : ()
		IxGROUP_M_CD = 28, 	//   : ()
		IxCLASS_TYPE = 29, 	//   : ()
		IxFIRST_CLASS = 30, 	//   : ()
		IxSECOND_CLASS = 31, 	//   : ()
		IxGROUP_CD = 32, 	//   : ()
		IxYMD_VENDOR = 33, 	//   : ()
		IxYMD_ITEM = 34, 	//   : ()
		IxVENDOR_ITEM = 35, 	//   : ()
		IxUPD_YMD = 36 	//   : ()
	}

	public enum TBSBI_IN_ITEM_INSPECT_H : int
	{
		IxMaxCt = 36,	// 인덱스 Count
		IxFACTORY = 1, 	//   : ()
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
		IxPUR_PRICE = 14, 	// Price : ()
		IxAMOUNT_USD = 15, 	// Amount($) : ()
		IxAMOUNT_KRW = 16, 	// Amount(W) : ()
		IxPUR_CURRENCY = 17, 	// Currency : ()
		IxPUR_NO = 18, 	// No : ()
		IxPUR_SEQ = 19, 	// Seq : ()
		IxLOT_NO = 20, 	// No : ()
		IxLOT_SEQ = 21, 	// Seq : ()
		IxSTYLE_CD = 22, 	// Code : ()
		IxSTYLE_NAME = 23, 	// Name : ()
		IxREMARKS = 24, 	// Remarks : ()
		IxITEM = 25, 	//   : ()
		IxGROUP_T_CD = 26, 	//   : ()
		IxGROUP_L_CD = 27, 	//   : ()
		IxGROUP_M_CD = 28, 	//   : ()
		IxCLASS_TYPE = 29, 	//   : ()
		IxFISRT_CLASS = 30, 	//   : ()
		IxSECOND_CLASS = 31, 	//   : ()
		IxGROUP_CD = 32, 	//   : ()
		IxYMD_VENDOR = 33, 	//   : ()
		IxYMD_ITEM = 34, 	//   : ()
		IxVENDOR_ITEM = 35, 	//   : ()
		IxUPD_YMD = 36 	//   : ()
	}

	public enum TBSBI_IN_ITEM_INSPECT_A : int
	{
		IxMaxCt = 36,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
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
		IxPUR_PRICE = 14, 	// Price : ()
		IxAMOUNT_USD = 15, 	// Amount($) : ()
		IxAMOUNT_KRW = 16, 	// Amount(W) : ()
		IxPUR_CURRENCY = 17, 	// Currency : ()
		IxPUR_NO = 18, 	// No : ()
		IxPUR_SEQ = 19, 	// Seq : ()
		IxLOT_NO = 20, 	// No : ()
		IxLOT_SEQ = 21, 	// Seq : ()
		IxSTYLE_CD = 22, 	// Code : ()
		IxSTYLE_NAME = 23, 	// Name : ()
		IxREMARKS = 24, 	// Remarks : ()
		IxITEM = 25, 	// User : ()
		IxGROUP_T_CD = 26, 	//   : ()
		IxGROUP_L_CD = 27, 	//   : ()
		IxGROUP_M_CD = 28, 	//   : ()
		IxCLASS_TYPE = 29, 	//   : ()
		IxFIRST_CLASS = 30, 	//   : ()
		IxSECOND_CLASS = 31, 	//   : ()
		IxGROUP_CD = 32, 	//   : ()
		IxYMD_ITEM = 33, 	//   : ()
		IxYMD_VENDOR = 34, 	//   : ()
		IxVENDOR_ITEM = 35, 	//   : ()
		IxUPD_YMD = 36 	//   : ()
	}

	public enum TBSBI_IN_ADJUST_VENDOR : int
	{
		IxMaxCt = 23,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxCUST_CD = 2, 	// 거래처코드 : ()
		IxCUST_NAME = 3, 	//   : ()
		IxITEM_CD = 4, 	// Item : ()
		IxITEM_NAME = 5, 	//   : ()
		IxIN_QTY = 6, 	//   : ()
		IxUSD_PRICE = 7, 	//   : ()
		IxCUR_PRICE = 8, 	//   : ()
		IxBUY_DIV = 9, 	//   : ()
		IxPOS = 10, 	//   : ()
		IxAMOUNT_USD = 11, 	//   : ()
		IxAMOUNT_KRW = 12, 	//   : ()
		IxADJUST_USD = 13, 	//   : ()
		IxADJUST_KRW = 14, 	//   : ()
		IxVAT_KRW = 15, 	//   : ()
		IxADJUST_DESC = 16, 	//   : ()
		IxPUR_USER = 17, 	//   : ()
		IxFACT_LOC = 18, 	//   : ()
		IxCUST_YM = 19, 	//   : ()
		IxACCOUNT_STATUS = 20, 	//   : ()
		IxACCOUNT_CONF = 21, 	//   : ()
		IxUPD_USER = 22, 	//   : ()
		IxUPD_YMD = 23 	//   : ()
	}

	public enum TBSBI_INCOMING_ADJUST : int
	{
		IxMaxCt = 35,	// 인덱스 Count
		IxITEM = 1, 	// Material : ()
		IxITEM_CD = 2, 	// Item : ()
		IxITEM_NAME = 3, 	// Item : ()
		IxSPEC_CD = 4, 	// Specification : ()
		IxSPEC_NAME = 5, 	// Specification : ()
		IxCOLOR_CD = 6, 	// Color : ()
		IxCOLOR_NAME = 7, 	// Color : ()
		IxIN_QTY = 8, 	// In Qty : ()
		IxUNIT = 9, 	// Unit : ()
		IxPK_UNIT_QTY = 10, 	// P/K Qty : ()
		IxPUR_CURRENCY = 11, 	// Currency : ()
		IxPUR_PRICE = 12, 	// Price : ()
		IxOUTSIDE_CURRENCY = 13, 	// Currency : ()
		IxOUTSIDE_PRICE = 14, 	// Price : ()
		IxCBD_CURRENCY = 15, 	// Currency : ()
		IxCBD_PRICE = 16, 	// Price : ()
		IxSHIP_CURRENCY = 17, 	// Currency : ()
		IxSHIP_PRICE = 18, 	// Price : ()
		IxPRICE_YN = 19, 	// Price Y/N : ()
		IxWH_CD = 20, 	// WareHouse : ()
		IxCUST_CD = 21, 	// Code : ()
		IxCUST_NAME = 22, 	// Name : ()
		IxSTYLE_CD = 23, 	// Code : ()
		IxSTYLE_NAME = 24, 	// Name : ()
		IxFACTORY = 25, 	// Factory : ()
		IxIN_NO = 26, 	// No : ()
		IxIN_SEQ = 27, 	// Seq : ()
		IxIN_YMD = 28, 	// Date : ()
		IxBUY_DIV = 29, 	// Buy Division : ()
		IxPUR_DIV = 30, 	// Purchase Division : ()
		IxLC_NO = 31, 	// L/C No : ()
		IxINV_NO = 32, 	// INV No : ()
		IxIN_STATUS = 33, 	// Status : ()
		IxUPD_USER = 34, 	// User : ()
		IxUPD_YMD = 35 	// Upd Date : ()
	}

	public enum TBSBI_INCOMING_INVOICE : int
	{
		IxMaxCt = 29,	// 인덱스 Count
		IxCHK = 1, 	// C : ()
		IxFACTORY = 2, 	//   : ()
		IxSHIP_YMD = 3, 	// Date : ()
		IxSHIP_NO = 4, 	// No : ()
		IxSHIP_SEQ = 5, 	// Seq : ()
		IxINV_NO = 6, 	// INV No : ()
		IxLC_NO = 7, 	// L/C No : ()
		IxPK_NO = 8, 	// PK No : ()
		IxITEM_CD = 9, 	//   : ()
		IxITEM_NAME = 10, 	// Item : ()
		IxSPEC_CD = 11, 	//   : ()
		IxSPEC_NAME = 12, 	// Specification : ()
		IxCOLOR_CD = 13, 	//   : ()
		IxCOLOR_NAME = 14, 	// Color : ()
		IxSHIP_QTY = 15, 	// Ship Qty : ()
		IxIN_QTY = 16, 	// In Qty : ()
		IxUNIT = 17, 	// Unit : ()
		IxSHIP_PRICE = 18, 	// Ship Price : ()
		IxCBD_PRICE = 19, 	// CBD Price : ()
		IxLEDG_PRICE = 20, 	// Ledg Price : ()
		IxLOT_NO = 21, 	// Lot No : ()
		IxCONT_NO = 22, 	// Container No : ()
		IxCUST_CD = 23, 	// Code : ()
		IxCUST_NAME = 24, 	// Name : ()
		IxSTYLE_CD = 25, 	// Code : ()
		IxSTYLE_NAME = 26, 	// Name : ()
		IxBAR_MOVE = 27, 	// Barcode Move : ()
		IxUPD_USER = 28, 	//   : ()
		IxUPD_YMD = 29 	// Date : ()
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

	public enum TBSBO_OUT_TAIL : int
	{
		IxMaxCt = 45,	// 인덱스 Count
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
		IxOUT_STATUS = 40, 	// Status : VARCHAR2(10)
		IxREMARKS = 41, 	// Remarks : VARCHAR2(500)
		IxMOD_QTY = 42, 	// Send : ()
		IxTRAN_DIV = 43, 	// Tran Div : ()
		IxUPD_USER = 44, 	//   : VARCHAR2(30)
		IxUPD_YMD = 45 	//   : DATE(7)
	}

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

	public enum TBSBO_OUT_SIZE : int
	{
		IxMaxCt = 7,	// 인덱스 Count
		IxKIND = 1, 	//   : ()
		IxTOTAL = 2, 	//   : ()
		IxCOL = 3, 	//   : ()
		IxFACTORY = 4, 	//   : VARCHAR2(5)
		IxOUT_NO = 5, 	//   : ()
		IxUPD_USER = 6, 	//   : VARCHAR2(30)
		IxUPD_YMD = 7 	//   : DATE(7)
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

	public enum TBSBO_OUTGOING_NORMAL : int
	{
		IxMaxCt = 22,	// 인덱스 Count
		IxLEV = 1, 	// Lev : ()
		IxFACTORY = 2, 	// Factory : ()
		IxOUT_PROCESS = 3, 	// Process : ()
		IxOUT_LINE = 4, 	// Line : ()
		IxOUT_NO = 5, 	// Out No : ()
		IxOUT_SEQ = 6, 	// Seq : ()
		IxSTYLE_CD = 7, 	// Style : ()
		IxITEM_CD = 8, 	// 상품코드 : ()
		IxITEM_NAME = 9, 	// Style : ()
		IxSPEC_CD = 10, 	// Spec : ()
		IxSPEC_NAME = 11, 	// Lot No : ()
		IxCOLOR_CD = 12, 	// Color : ()
		IxCOLOR_NAME = 13, 	// Lot Seq : ()
		IxDIR_QTY = 14, 	// Consumption : ()
		IxOUT_QTY = 15, 	// Outgoing : ()
		IxREMAIN_QTY = 16, 	// Remainder : ()
		IxSTOCK_QTY = 17, 	// Stock : ()
		IxTEMP_QTY = 18, 	// Temp : ()
		IxUNIT = 19, 	// Unit : ()
		IxOUT_STATUS = 20, 	// Out Status : ()
		IxUPD_USER = 21, 	// Upd User : ()
		IxUPD_YMD = 22 	// Upd Ymd : ()
	}

	public enum TBSBK_STOCK_BASE : int
	{
		IxMaxCt = 22,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxWH_CD = 2, 	//   : ()
		IxSTOCK_YMD = 3, 	// 재고일 : ()
		IxITEM_CD = 4, 	//   : ()
		IxITEM_NAME = 5, 	//   : ()
		IxSPEC_CD = 6, 	// Spec : ()
		IxSPEC_NAME = 7, 	//   : ()
		IxCOLOR_CD = 8, 	// Color : ()
		IxCOLOR_NAME = 9, 	//   : ()
		IxBASE_QTY = 10, 	// 이월수량 : ()
		IxUNIT = 11, 	//   : ()
		IxPUR_CURRENCY = 12, 	// 구매화폐 : ()
		IxPUR_PRICE = 13, 	// 구매단가 : ()
		IxOUTSIDE_CURRENCY = 14, 	//   : ()
		IxOUTSIDE_PRICE = 15, 	//   : ()
		IxCBD_CURRENCY = 16, 	// CBD화폐 : ()
		IxCBD_PRICE = 17, 	// CBD단가 : ()
		IxSHIP_CURRENCY = 18, 	//   : ()
		IxSHIP_PRICE = 19, 	//   : ()
		IxSTOCK_STATUS = 20, 	// 재고상태 : ()
		IxUPD_USER = 21, 	// User : ()
		IxUPD_YMD = 22 	// Upd Ymd : ()
	}

	public enum TBSBK_STOCK_CLOSE : int
	{
		IxMaxCt = 30,	// 인덱스 Count
		IxLEV = 1, 	// Lev : ()
		IxFACTORY = 2, 	// Factory : VARCHAR2(5)
		IxWH_CD = 3, 	// WareHouse : VARCHAR2(10)
		IxSTOCK_YMD = 4, 	// Date : VARCHAR2(6)
		IxITEM_CD = 5, 	// Item : VARCHAR2(10)
		IxITEM_NAME = 6, 	// Item : ()
		IxSPEC_CD = 7, 	// Specification : VARCHAR2(5)
		IxSPEC_NAME = 8, 	// Specification : ()
		IxCOLOR_CD = 9, 	// Color : VARCHAR2(5)
		IxCOLOR_NAME = 10, 	// Color : ()
		IxBASE_QTY = 11, 	// Base : NUMBER(22)
		IxIN_QTY = 12, 	// Incoming : NUMBER(22)
		IxOUT_QTY = 13, 	// Outgoing : NUMBER(22)
		IxSTOCK_QTY = 14, 	// Stock : NUMBER(22)
		IxADJUST_QTY = 15, 	// Qty : NUMBER(22)
		IxADJUST_REASON = 16, 	// Reason : VARCHAR2(10)
		IxUNIT = 17, 	// Unit : ()
		IxPUR_CURRENCY = 18, 	// Currency : VARCHAR2(10)
		IxPUR_PRICE = 19, 	// Price : NUMBER(22)
		IxOUTSIDE_CURRENCY = 20, 	// Currency : VARCHAR2(10)
		IxOUTSIDE_PRICE = 21, 	// Price : NUMBER(22)
		IxCBD_CURRENCY = 22, 	// Currency : VARCHAR2(10)
		IxCBD_PRICE = 23, 	// Price : NUMBER(22)
		IxSHIP_CURRENCY = 24, 	// Currency : VARCHAR2(10)
		IxSHIP_PRICE = 25, 	// Price : NUMBER(22)
		IxSTOCK_STATUS = 26, 	// Status : VARCHAR2(10)
		IxSTOCK_CNT = 27, 	// Stock Cnt : ()
		IxCBD_CNT = 28, 	// CBD Cnt : ()
		IxUPD_USER = 29, 	// User : VARCHAR2(30)
		IxUPD_YMD = 30 	// Upd Ymd : DATE(7)
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

	public enum TBSBK_STOCK_DAILY : int
	{
		IxMaxCt = 27,	// 인덱스 Count
		IxLEV = 1, 	//   : ()
		IxFACTORY = 2, 	// Factory : ()
		IxWH_CD = 3, 	//   : ()
		IxSTOCK_YMD = 4, 	// 재고일 : ()
		IxITEM_CD = 5, 	// 상품코드 : ()
		IxITEM_NAME = 6, 	//   : ()
		IxSPEC_CD = 7, 	// Spec : ()
		IxSPEC_NAME = 8, 	//   : ()
		IxCOLOR_CD = 9, 	// Color : ()
		IxCOLOR_NAME = 10, 	//   : ()
		IxSTOCK_DD = 11, 	//   : ()
		IxBASE_QTY = 12, 	// 이월수량 : ()
		IxIN_QTY = 13, 	//   : ()
		IxOUT_QTY = 14, 	// Outgoing : ()
		IxSTOCK_QTY = 15, 	// Stock : ()
		IxUNIT = 16, 	//   : ()
		IxPUR_CURRENCY = 17, 	// 구매화폐 : ()
		IxPUR_PRICE = 18, 	// 구매단가 : ()
		IxOUTSIDE_CURRENCY = 19, 	//   : ()
		IxOUTSIDE_PRICE = 20, 	//   : ()
		IxCBD_CURRENCY = 21, 	// CBD화폐 : ()
		IxCBD_PRICE = 22, 	// CBD단가 : ()
		IxSHIP_CURRENCY = 23, 	//   : ()
		IxSHIP_PRICE = 24, 	//   : ()
		IxSTOCK_STATUS = 25, 	// 재고상태 : ()
		IxUPD_USER = 26, 	//   : ()
		IxUPD_YMD = 27 	// Upd Ymd : ()
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

	public enum TBSBP_COMMON_GENERAL : int
	{
		IxMaxCt = 18,	// 인덱스 Count
		IxLEV = 1, 	//   : ()
		IxITEM_CD = 2, 	// Item : ()
		IxITEM_NAME = 3, 	// Item : ()
		IxSPEC_CD = 4, 	// Specification : ()
		IxSPEC_NAME = 5, 	// Specification : ()
		IxCOLOR_CD = 6, 	// Color : ()
		IxCOLOR_NAME = 7, 	// Color : ()
		IxUNIT = 8, 	// Unit : ()
		IxSAFE_QTY = 9, 	// Safe : ()
		IxSTOCK_QTY = 10, 	// Stock : ()
		IxBASE_QTY = 11, 	// Base : ()
		IxIN_QTY = 12, 	// In : ()
		IxOUT_QTY = 13, 	// Out : ()
		IxPUR_QTY = 14, 	// Pur : ()
		IxBALANCE_QTY = 15, 	// Balance : ()
		IxRATE = 16, 	// Rate : ()
		IxERR_DEC = 17, 	//   : ()
		IxERR_COLOR = 18 	//   : ()
	}

	public enum TBSBC_ITEM_OTHER : int
	{
		IxMaxCt = 73,	// 인덱스 Count
		IxITEM_CD = 1, 	// Item : ()
		IxGROUP_CD = 2, 	// Group : ()
		IxITEM_NAME1 = 3, 	// Name 1 : ()
		IxABC_DIV = 4, 	// ABC Div : ()
		IxSIZE_YN = 5, 	// Size YN : ()
		IxUSE_YN = 6, 	// Use YN : ()
		IxLONE_YN = 7, 	// LLT YN : ()
		IxSAFE_AMT_DS = 8, 	// DS : ()
		IxSAFE_AMT_QD = 9, 	// QD : ()
		IxSAFE_AMT_VJ = 10, 	// VJ : ()
		IxCUS_CD_DS = 11, 	// DS : ()
		IxCUS_NAME_DS = 12, 	// DS : ()
		IxCUS_CD_QD = 13, 	// QD : ()
		IxCUS_NAME_QD = 14, 	// QD : ()
		IxCUS_CD_VJ = 15, 	// VJ : ()
		IxCUS_NAME_VJ = 16, 	// VJ : ()
		IxITEM_NAME2 = 17, 	// Name 2 : ()
		IxITEM_NAME3 = 18, 	// Name 3 : ()
		IxITEM_NAME4 = 19, 	// Name 4 : ()
		IxITEM_NAME5 = 20, 	// Name 5 : ()
		IxREP_ITEM_CD = 21, 	// Rep Item : ()
		IxCOPY_FROM = 22, 	// Copy From : ()
		IxREMARK = 23, 	// Remark : ()
		IxMNG_UNIT = 24, 	// Unit : ()
		IxPK_QTY = 25, 	// PK Qty : ()
		IxSPEC_TYPE = 26, 	// Spec Type : ()
		IxSTYLE_ITEM_DIV = 27, 	// Style Item Div : ()
		IxBUY_DIV = 28, 	// Buy Division : ()
		IxSTOCK_UNIT = 29, 	// Stock Unit : ()
		IxITEM_CONV = 30, 	// Item Conv : ()
		IxINSP_YN = 31, 	// Inspection YN : ()
		IxPUR_PRICE = 32, 	// Price : ()
		IxPUR_CURRENCY = 33, 	// Currency : ()
		IxCBD_PRICE = 34, 	// Price : ()
		IxCBD_CURRENCY = 35, 	// Currency : ()
		IxPROCESSING_YN = 36, 	// YN : ()
		IxPROCESSING_PRICE = 37, 	// Price : ()
		IxPROCESSING_CURRENCY = 38, 	// Currency : ()
		IxMAN_CHARGE_DS = 39, 	// DS : ()
		IxMAN_CHARGE_QD = 40, 	// QD : ()
		IxMAN_CHARGE_VJ = 41, 	// VJ : ()
		IxIMPORT_DS = 42, 	// DS : ()
		IxIMPORT_QD = 43, 	// QD : ()
		IxIMPORT_VJ = 44, 	// VJ : ()
		IxCOST_YN = 45, 	// Cost YN : ()
		IxACC_DIV_YN = 46, 	// YN : ()
		IxACC_DIV_DS = 47, 	// DS : ()
		IxACC_DIV_QD = 48, 	// QD : ()
		IxACC_DIV_VJ = 49, 	// VJ : ()
		IxDL_DAYS_DS = 50, 	// DS : ()
		IxDL_DAYS_QD = 51, 	// QD : ()
		IxDL_DAYS_VJ = 52, 	// VJ : ()
		IxLIFE_YN = 53, 	// YN : ()
		IxLIFE_DAY = 54, 	// Day : ()
		IxIN_WH_CD = 55, 	// In : ()
		IxOUT_WH_CD = 56, 	// Out : ()
		IxPUR_LOSS_RATE = 57, 	// Purchase : ()
		IxOUT_LOSS_RATE = 58, 	// Outgoing : ()
		IxSHIP_LOSS_RATE = 59, 	// Shipping : ()
		IxPUR_LOT_AMT = 60, 	// Purchase : ()
		IxPROD_IN_LOT = 61, 	// Production : ()
		IxMCS_NO = 62, 	// MCS No : ()
		IxHS_NO = 63, 	// HS No : ()
		IxCBM = 64, 	// CBM : ()
		IxGROSS_WEIGHT = 65, 	// Gross : ()
		IxNET_WEIGHT = 66, 	// Net : ()
		IxVOLUME = 67, 	// Volume : ()
		IxLENGTH = 68, 	// Length : ()
		IxWIDTH = 69, 	// Width : ()
		IxHEIGHT = 70, 	// Height : ()
		IxGUBUN = 71, 	// Gubun : ()
		IxUPD_USER = 72, 	// Upd User : ()
		IxUPD_YMD = 73 	// Update Ymd : ()
	}

	public enum TBSBC_DTYPE_ITEM_SEARCH : int
	{
		IxMaxCt = 70,	// 인덱스 Count
		IxCHK = 1, 	//   : ()
		IxITEM_CD = 2, 	// Item : ()
		IxGROUP_CD = 3, 	// Group : ()
		IxITEM_NAME1 = 4, 	// Name 1 : ()
		IxITEM_NAME2 = 5, 	// Name 2 : ()
		IxITEM_NAME3 = 6, 	// Name 3 : ()
		IxITEM_NAME4 = 7, 	// Name 4 : ()
		IxITEM_NAME5 = 8, 	// Name 5 : ()
		IxSIZE_YN = 9, 	// Size YN : ()
		IxUSE_YN = 10, 	// Use YN : ()
		IxREP_ITEM_CD = 11, 	// Rep Item : ()
		IxCOPY_FROM = 12, 	// Copy From : ()
		IxREMARK = 13, 	// Remark : ()
		IxMNG_UNIT = 14, 	// Unit : ()
		IxPK_QTY = 15, 	// PK Qty : ()
		IxSPEC_TYPE = 16, 	// Spec Type : ()
		IxSTYLE_ITEM_DIV = 17, 	// Style Item Div : ()
		IxBUY_DIV = 18, 	// Buy Division : ()
		IxSTOCK_UNIT = 19, 	// Stock Unit : ()
		IxITEM_CONV = 20, 	// Item Conv : ()
		IxABC_DIV = 21, 	// ABC Div : ()
		IxINSP_YN = 22, 	// Inspection YN : ()
		IxPUR_PRICE = 23, 	// Price : ()
		IxPUR_CURRENCY = 24, 	// Currency : ()
		IxCBD_PRICE = 25, 	// Price : ()
		IxCBD_CURRENCY = 26, 	// Currency : ()
		IxPROCESSING_YN = 27, 	// YN : ()
		IxPROCESSING_PRICE = 28, 	// Price : ()
		IxPROCESSING_CURRENCY = 29, 	// Currency : ()
		IxCUS_CD_DS = 30, 	// DS : ()
		IxCUS_CD_QD = 31, 	// QD : ()
		IxCUS_CD_VJ = 32, 	// VJ : ()
		IxMAN_CHARGE_DS = 33, 	// DS : ()
		IxMAN_CHARGE_QD = 34, 	// QD : ()
		IxMAN_CHARGE_VJ = 35, 	// VJ : ()
		IxIMPORT_DS = 36, 	// DS : ()
		IxIMPORT_QD = 37, 	// QD : ()
		IxIMPORT_VJ = 38, 	// VJ : ()
		IxCOST_YN = 39, 	// Cost YN : ()
		IxACC_DIV_YN = 40, 	// YN : ()
		IxACC_DIV_DS = 41, 	// DS : ()
		IxACC_DIV_QD = 42, 	// QD : ()
		IxACC_DIV_VJ = 43, 	// VJ : ()
		IxLONE_YN = 44, 	// LLT YN : ()
		IxDL_DAYS_DS = 45, 	// DS : ()
		IxDL_DAYS_QD = 46, 	// QD : ()
		IxDL_DAYS_VJ = 47, 	// VJ : ()
		IxSAFE_AMT_DS = 48, 	// DS : ()
		IxSAFE_AMT_QD = 49, 	// QD : ()
		IxSAFE_AMT_VJ = 50, 	// VJ : ()
		IxLIFE_YN = 51, 	// YN : ()
		IxLIFE_DAY = 52, 	// Day : ()
		IxIN_WH_CD = 53, 	// In : ()
		IxOUT_WH_CD = 54, 	// Out : ()
		IxPUR_LOSS_RATE = 55, 	// Purchase : ()
		IxOUT_LOSS_RATE = 56, 	// Outgoing : ()
		IxSHIP_LOSS_RATE = 57, 	// Shipping : ()
		IxPUR_LOT_AMT = 58, 	// Purchase : ()
		IxPROD_IN_LOT = 59, 	// Production : ()
		IxMCS_NO = 60, 	// MCS No : ()
		IxHS_NO = 61, 	// HS No : ()
		IxCBM = 62, 	// CBM : ()
		IxGROSS_WEIGHT = 63, 	// Gross : ()
		IxNET_WEIGHT = 64, 	// Net : ()
		IxVOLUME = 65, 	// Volume : ()
		IxLENGTH = 66, 	// Length : ()
		IxWIDTH = 67, 	// Width : ()
		IxHEIGHT = 68, 	// Height : ()
		IxUPD_USER = 69, 	// Upd User : ()
		IxUPD_YMD = 70 	// Update Ymd : ()
	}

	public enum TBSBP_LLT : int
	{
		IxMaxCt = 30,	// 인덱스 Count
		IxLEV = 1, 	// Lev : ()
		IxTEMP_YMD = 2, 	// Ymd : ()
		IxFACTORY = 3, 	// Factory : ()
		IxITEM_CD = 4, 	// Item : ()
		IxITEM_NAME = 5, 	// Item : ()
		IxSPEC_CD = 6, 	// Specification : ()
		IxSPEC_NAME = 7, 	// Specification : ()
		IxCOLOR_CD = 8, 	// Color : ()
		IxCOLOR_NAME = 9, 	// Color : ()
		IxSTYLE_CD = 10, 	// Style : ()
		IxSTYLE_NAME = 11, 	// Style : ()
		IxOBS_ID = 12, 	// OBS Id : ()
		IxUNIT = 13, 	// Unit : ()
		IxDL_DAYS = 14, 	// D/T : ()
		IxDEL_MONTH = 15, 	// Month : ()
		IxIPD = 16, 	// IPD : ()
		IxDPO_YN = 17, 	// Yn : ()
		IxYIELD_YN = 18, 	// Yn : ()
		IxORDER_QTY = 19, 	// Order Qty : ()
		IxYIELD_QTY = 20, 	// Yield Qty : ()
		IxPUR_TYPE = 21, 	// Type : ()
		IxPUR_YMD = 22, 	// Ymd : ()
		IxPUR_QTY = 23, 	// Purchase : ()
		IxIN_QTY = 24, 	// Incoming : ()
		IxSTOCK_QTY = 25, 	// Stock : ()
		IxBALANCE_QTY = 26, 	// Balance : ()
		IxERR_COLOR = 27, 	// Err Color : ()
		IxREMARKS = 28, 	// Remarks : ()
		IxUPD_USER = 29, 	// Update User : ()
		IxUPD_YMD = 30 	// Update Date : ()
	}

	public enum TBSBP_SS_ID : int
	{
		IxMaxCt = 32,	// 인덱스 Count
		IxLEV = 1, 	// Lev : ()
		IxFACTORY = 2, 	// Factory : ()
		IxTEMP_YMD = 3, 	// Ymd : ()
		IxTEMP_OBS = 4, 	// Temp Obs : ()
		IxOBS_TYPE = 5, 	// Obs Type : ()
		IxITEM_CD = 6, 	// Item : ()
		IxITEM_NAME = 7, 	// Item : ()
		IxSPEC_CD = 8, 	// Specification : ()
		IxSPEC_NAME = 9, 	// Specification : ()
		IxCOLOR_CD = 10, 	// Color : ()
		IxCOLOR_NAME = 11, 	// Color : ()
		IxSTYLE_CD = 12, 	// Style : ()
		IxSTYLE_NAME = 13, 	// Style : ()
		IxOBS_ID = 14, 	// OBS Id : ()
		IxUNIT = 15, 	// Unit : ()
		IxYIELD_YN = 16, 	// Yn : ()
		IxORDER_QTY = 17, 	// Order : ()
		IxYIELD_QTY = 18, 	// Yield : ()
		IxREQ_QTY = 19, 	// Req : ()
		IxPUR_YMD = 20, 	// Ymd : ()
		IxPUR_QTY = 21, 	// Purchase : ()
		IxIN_QTY = 22, 	// Incoming : ()
		IxSTOCK_QTY = 23, 	// Stock : ()
		IxBALANCE_QTY = 24, 	// Balance : ()
		IxCHK = 25, 	// C : ()
		IxREQ_NO = 26, 	// ReqNo : ()
		IxREQ_SEQ = 27, 	// ReqSeq : ()
		IxREQ_YN = 28, 	// ReqYn : ()
		IxERR_COLOR = 29, 	// Err Color : ()
		IxREMARKS = 30, 	// Remarks : ()
		IxUPD_USER = 31, 	// Update User : ()
		IxUPD_YMD = 32 	// Update Date : ()
	}

	public enum TBSBP_SS_ID_ORDER : int
	{
		IxMaxCt = 14,	// 인덱스 Count
		IxCHK = 1, 	// C : ()
		IxFACTORY = 2, 	// Factory : ()
		IxTEMP_YMD = 3, 	// Ymd : ()
		IxTEMP_OBS = 4, 	// Temp Obs : ()
		IxOBS_TYPE = 5, 	// Type : ()
		IxOBS_ID = 6, 	// ID : ()
		IxSTYLE_CD = 7, 	// 스타일코드 : ()
		IxSTYLE_NAME = 8, 	//   : ()
		IxYIELD_YN = 9, 	//   : ()
		IxPUR_YN = 10, 	//   : ()
		IxTOT_QTY = 11, 	// 총오더수량 : ()
		IxREMARKS = 12, 	// Remarks : ()
		IxUPD_USER = 13, 	// Upd User : ()
		IxUPD_YMD = 14 	// Upd Ymd : ()
	}

	public enum TBSQC_REQUEST : int
	{
		IxMaxCt = 23,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxREQ_YMD = 2, 	// Ymd : ()
		IxREQ_SEQ = 3, 	// Seq : ()
		IxLAB_NO = 4, 	// Lab No : ()
		IxITEM_CD = 5, 	// Item : ()
		IxITEM_NAME = 6, 	// Item : ()
		IxSPEC_CD = 7, 	// Specification : ()
		IxSPEC_NAME = 8, 	// Specification : ()
		IxCOLOR_CD = 9, 	// Color : ()
		IxCOLOR_NAME = 10, 	// Color : ()
		IxUNIT = 11, 	// Unit : ()
		IxCUST_CD = 12, 	// Supplier : ()
		IxCUST_NAME = 13, 	// Supplier : ()
		IxINSP_YMD = 14, 	// Insp Ymd : ()
		IxINSP_SEQ = 15, 	// Insp Seq : ()
		IxINSP_QTY = 16, 	// Insp Qty : ()
		IxDEF_TYPE = 17, 	// Def Type : ()
		IxDEF_QTY = 18, 	// Def Type : ()
		IxRESULT = 19, 	// R : ()
		IxLOT_QTY = 20, 	// Lot Qty : ()
		IxSTATUS = 21, 	// Status : ()
		IxUPD_USER = 22, 	//   : ()
		IxUPD_YMD = 23 	//   : ()
	}

	public enum TBSQC_REQUEST_SHIP : int
	{
		IxMaxCt = 24,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxSHIP_NO = 2, 	// Ship No : ()
		IxSHIP = 3, 	// Ship No : ()
		IxSHIP_SEQ = 4, 	// Seq : ()
		IxTANG_SEQ = 5, 	// Tang Seq : ()
		IxSHIP_YMD = 6, 	// Ymd : ()
		IxSHIP_FACT = 7, 	// Factory : ()
		IxLOT_NO = 8, 	// Lot No : ()
		IxPO_TYPE = 9, 	// PO 타입 : ()
		IxSTYLE_CD = 10, 	// Style : ()
		IxITEM_CD = 11, 	// Item : ()
		IxITEM_NAME = 12, 	// Item : ()
		IxSPEC_CD = 13, 	// Specification : ()
		IxSPEC_NAME = 14, 	// Specification : ()
		IxCOLOR_CD = 15, 	// Color : ()
		IxCOLOR_NAME = 16, 	// Color : ()
		IxUNIT = 17, 	// Unit : ()
		IxMAT_QTY = 18, 	// Qty : ()
		IxCUST_CD = 19, 	// Supplier : ()
		IxCUST_NAME = 20, 	// Supplier : ()
		IxINSP_YMD = 21, 	// Insp Ymd : ()
		IxINSP_SEQ = 22, 	// Insp Seq : ()
		IxUPD_USER = 23, 	//   : ()
		IxUPD_YMD = 24 	//   : ()
	}

	public enum TBSQC_RESULT_LIST : int
	{
		IxMaxCt = 29,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : ()
		IxTEST_YMD = 2, 	//   : ()
		IxSHIP_YMD = 3, 	//   : ()
		IxTEST_SEQ = 4, 	//   : ()
		IxITEM_CD = 5, 	// Item : ()
		IxITEM_NAME = 6, 	//   : ()
		IxSPEC_CD = 7, 	// Specification : ()
		IxSPEC_NAME = 8, 	//   : ()
		IxCOLOR_CD = 9, 	// Color : ()
		IxCOLOR_NAME = 10, 	//   : ()
		IxUNIT = 11, 	//   : ()
		IxCUST_CD = 12, 	// Supplier : ()
		IxCUST_NAME = 13, 	//   : ()
		IxINSP_YMD = 14, 	// Insp Ymd : ()
		IxINSP_SEQ = 15, 	// Insp Seq : ()
		IxREQ_YMD = 16, 	// Ymd : ()
		IxREQ_SEQ = 17, 	// Seq : ()
		IxCOMPONENT = 18, 	//   : ()
		IxMCS_NO = 19, 	// MCS No : ()
		IxMCS_YMD = 20, 	//   : ()
		IxLOT_QTY = 21, 	// Lot Qty : ()
		IxMAT_QTY = 22, 	//   : ()
		IxRESULT = 23, 	// R : ()
		IxMODEL = 24, 	//   : ()
		IxSTYLE_CD = 25, 	//   : ()
		IxLOT_NO = 26, 	//   : ()
		IxREMARKS = 27, 	// Remarks : ()
		IxUPD_USER = 28, 	//   : ()
		IxUPD_YMD = 29 	//   : ()
	}

	public enum TBSQC_SHIPPING_LIST : int
	{
		IxMaxCt = 25,	// 인덱스 Count
		IxCHK = 1, 	//   : ()
		IxFACTORY = 2, 	// Factory : ()
		IxSHIP_NO = 3, 	// Ship No : ()
		IxSHIP_SEQ = 4, 	// Seq : ()
		IxTANG_SEQ = 5, 	// Tang Seq : ()
		IxSHIP_YMD = 6, 	// Ymd : ()
		IxSHIP_FACT = 7, 	// Factory : ()
		IxOBS_TYPE = 8, 	// Type : ()
		IxITEM_CD = 9, 	// Item : ()
		IxITEM_NAME = 10, 	//   : ()
		IxSPEC_CD = 11, 	// Specification : ()
		IxSPEC_NAME = 12, 	//   : ()
		IxCOLOR_CD = 13, 	// Color : ()
		IxCOLOR_NAME = 14, 	//   : ()
		IxUNIT = 15, 	//   : ()
		IxMAT_QTY = 16, 	// Qty : ()
		IxMODEL = 17, 	// Model : ()
		IxSTYLE_CD = 18, 	// 스타일코드 : ()
		IxLOT_NO = 19, 	//   : ()
		IxCUST_CD = 20, 	// Supplier : ()
		IxCUST_NAME = 21, 	// Supplier : ()
		IxINSP_YMD = 22, 	// Insp Ymd : ()
		IxINSP_SEQ = 23, 	// Insp Seq : ()
		IxUPD_USER = 24, 	//   : ()
		IxUPD_YMD = 25 	//   : ()
	}

	public enum TBSQL_LAB_REQUEST : int
	{
		IxMaxCt = 30,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : VARCHAR2(5)
		IxREQ_NO = 2, 	// No : VARCHAR2(20)
		IxREQ_SEQ = 3, 	// Seq : NUMBER(22)
		IxREQ_YMD = 4, 	// Date : VARCHAR2(8)
		IxLAB_NO = 5, 	// Lab No : ()
		IxITEM_CD = 6, 	// Item : VARCHAR2(10)
		IxITEM_NAME = 7, 	// Item : ()
		IxSPEC_CD = 8, 	// Specification : VARCHAR2(5)
		IxSPEC_NAME = 9, 	// Specification : ()
		IxCOLOR_CD = 10, 	// Color : VARCHAR2(5)
		IxCOLOR_NAME = 11, 	// Color : ()
		IxUNIT = 12, 	// Unit : ()
		IxSTYLE_CD = 13, 	// Code : VARCHAR2(9)
		IxSTYLE_NAME = 14, 	// Name : ()
		IxREQ_QTY = 15, 	// Req Qty : NUMBER(22)
		IxDEF_QTY = 16, 	// Qty : NUMBER(22)
		IxDEF_TYPE = 17, 	// Type : VARCHAR2(10)
		IxRESULT = 18, 	// R : ()
		IxCUST_CD = 19, 	// Code : VARCHAR2(6)
		IxCUST_NAME = 20, 	// Name : ()
		IxSHIP_NO = 21, 	// No : VARCHAR2(20)
		IxSHIP_SEQ = 22, 	// Seq : VARCHAR2(4)
		IxSHIP_YMD = 23, 	// Date : VARCHAR2(8)
		IxPUR_USER = 24, 	// Purchase User : VARCHAR2(30)
		IxLOT_NO = 25, 	// No : VARCHAR2(9)
		IxLOT_SEQ = 26, 	// Seq : VARCHAR2(2)
		IxOBS_TYPE = 27, 	// OBS Type : VARCHAR2(2)
		IxSTATUS = 28, 	// Status : VARCHAR2(1)
		IxUPD_USER = 29, 	// Upd User : VARCHAR2(30)
		IxUPD_YMD = 30 	// Upd Ymd : DATE(7)
	}

	public enum TBSQL_LAB_REQ_SHIP : int
	{
		IxMaxCt = 23,	// 인덱스 Count
		IxCHK = 1, 	// C : ()
		IxFACTORY = 2, 	// Factory : ()
		IxSHIP_NO = 3, 	// No : ()
		IxSHIP_SEQ = 4, 	// Seq : ()
		IxSHIP_YMD = 5, 	// Date : ()
		IxITEM_CD = 6, 	// Item : ()
		IxITEM_NAME = 7, 	// Item : ()
		IxSPEC_CD = 8, 	// Specification : ()
		IxSPEC_NAME = 9, 	// Specification : ()
		IxCOLOR_CD = 10, 	// Color : ()
		IxCOLOR_NAME = 11, 	// Color : ()
		IxUNIT = 12, 	// Unit : ()
		IxREQ_QTY = 13, 	// Req Qty : ()
		IxSTYLE_CD = 14, 	// Code : ()
		IxSTYLE_NAME = 15, 	// Name : ()
		IxCUST_CD = 16, 	// Code : ()
		IxCUST_NAME = 17, 	// Name : ()
		IxREQ_NO = 18, 	// No : ()
		IxREQ_SEQ = 19, 	// Seq : ()
		IxPUR_USER = 20, 	// Purchase User : ()
		IxLOT_NO = 21, 	// No : ()
		IxLOT_SEQ = 22, 	// Seq : ()
		IxOBS_TYPE = 23 	// OBS Type : ()
	}
	
	public enum TBSQL_LAB_TEST : int
	{
		IxMaxCt = 21,	// 인덱스 Count
		IxFACTORY = 1, 	// Factory : VARCHAR2(5)
		IxLAB_NO = 2, 	// No : VARCHAR2(20)
		IxLAB_SEQ = 3, 	// Seq : NUMBER(22)
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
		IxREQ_SEQ = 17, 	// Seq : NUMBER(22)
		IxREMARKS = 18, 	// Remarks : VARCHAR2(500)
		IxSTATUS = 19, 	// Status : VARCHAR2(1)
		IxUPD_USER = 20, 	// Upd User : VARCHAR2(30)
		IxUPD_YMD = 21 	// Upd Ymd : DATE(7)
	}

	#endregion    

	#region 김미영 추가

	/// <summary> 
	/// TBSBC_FORMULAN_YIELD  테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_FORMULAN_YIELD : int
	{

		lxMAXCT		= 28,	// 인덱스 COUNT

		lxLEVEL             = 1, 
		lxKEY				= 2, 
		lxTYPE_DIVISION		= 3, 
		lxTREE 		        = 4, 
		lxTEMPLATE_LEVEL	= 5,  //Formula Div
		lxFACTORY			= 6, 
		lxSTYLE_CD			= 7, 
		lxSEMI_GOOD_CD		= 8, 
		lxCOMPONENT_CD		= 9, 
		lxCOMPONENT_NAME	= 10,
		lxFORMULA_SEQ		= 11,    //Formula SEq
		lxMCS_CD			= 12,
		lxMCS_NAME			= 13,
		lxMCS_COLOR			= 14,
		lxMCS_COLOR_NAME	= 15,
		lxITEM_CD			= 16,
		lxITEM_NAME			= 17,
		lxSPEC_CD			= 18,
		lxSPEC_NAME			= 19,
		lxCOLOR_CD			= 20,
		lxCOLOR_NAME		= 21,
		lxUNIT				= 22,
		lxFORMULA           = 23,
		lxMIX               = 24,
		lxPST_YN            = 25,
		lxGENDER            = 26,		
		lxYIELD_M           = 27,
		lxCOL_ORDER         = 28   

	}				


	/// <summary> 
	/// SBC_FORMULAN_COPY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_FORMULAN_COPY : int
	{
		lxMAXCT		       = 21,	// 인덱스 COUNT
		lxLEVEL            = 1, 
		lxMCSINFO_KEY	   = 2, 
		lxTYPE_DIVISION	   = 3, 
		lxJOB_FLAG		   = 4, 
		lxFORMULA_DIV	   = 5, 
		lxITEM_NAME		   = 6, 
		lxSPEC_NAME		   = 7, 
		lxCOLOR_NAME	   = 8, 
		lxUNIT			   = 9, 
		lxITEM_CD		   = 10,
		lxSPEC_CD		   = 11,
		lxCOLOR_CD		   = 12,
		lxFORMULA		   = 13,
		lxMIX			   = 14,
		lxFACTORY		   = 15,
		lxSEQ			   = 16,
		lxFORMULA_YEAR	   = 17,
		lxSEASON_CD		   = 18,
		lxSTYLE_CD		   = 19,
		lxMCS_CD		   = 20,
		lxMCS_COLOR_CD     = 21

	}				


	/// <summary> 
	/// TBSBC_FORMULAN_R 테이블 인덱스 Enum 
	/// </summary> 
	//	public enum TBSBC_FORMULAN_R : int
	//	{
	//		lxMAXCT		      = 13,	// 인덱스 COUNT
	//		lxFACTORY         = 1, 
	//		lxSEQ			  = 2, 
	//		lxFORMULA_DIV	  = 3, 
	//		lxITEM_CD		  = 4, 
	//		lxCOLOR_CD		  = 5, 
	//		lxSPEC_CD		  = 6, 
	//		lxFORMULA_YEAR	  = 7, 
	//		lxSEASON_CD		  = 8, 
	//		lxSTYLE_CD		  = 9, 
	//		lxMCS_CD		  = 10,
	//		lxMCS_COLOR_CD	  = 11,
	//		lxFORMULA		  = 12,
	//		lxMIX			  = 13
	//	}					  



	

	/// <summary> 
	/// TBSBC_STYLE_MCS 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_STYLE_MCS : int
	{
		lxMAXCT		       = 4,	// 인덱스 COUNT
		lxMCS_CD           = 1, 
		lxMCS_NAME		   = 2, 
		lxMCS_COLOR_CD	   = 3, 
		lxMCS_COLOR_NAME   = 4, 
	
	}					  






	
	/// <summary> 
	/// SQC_LAB_COMPONENT 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSQC_LAB_COMPONENT : int 
	{ 
		IxMaxCt = 12,		// 인덱스 Count 
		IxFACTORY =1,			// 	:VARCHAR2(5) 
		IxLAB_COMP_CD =2,			// 	:VARCHAR2(4) 
		IxTEST_CD =3,			// 	:VARCHAR2(4) 
		IxTEST_NAME1 =4,			// 	:VARCHAR2(30) 
		IxTEST_NAME2 =5,			// 	:VARCHAR2(60) 
		IxUNIT_CD =6,			// 	:VARCHAR2(4) 
		IxMETHOD =7,			// 	:VARCHAR2(20) 
		IxREMARKS =8,			// 	:VARCHAR2(500) 
		IxSEND_CHK =9,			// 	:VARCHAR2(10) 
		IxSEND_YMD =10,			// 	:DATE(7) 
		IxUPD_USER =11,			// 	:VARCHAR2(30) 
		IxUPD_YMD =12,			// 	:DATE(7) 
	}  



	/// <summary> 
	/// SQC_LAB_SPEC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSQC_LAB_SPEC : int 
	{ 
		IxMaxCt = 15,		// 인덱스 Count 
		IxFACTORY =1,			// 	:VARCHAR2(5) 
		IxLAB_COMP_CD =3,			// 	:VARCHAR2(4) 
		IxMCS_NO =4,			// 	:VARCHAR2(15) 
		IxMCS_YMD =5,			// 	:VARCHAR2(8) 
		IxTEST_CD =6,			// 	:VARCHAR2(4) 
		IxSPEC_DIV =7,			// 	:VARCHAR2(1) 
		IxSPEC_MIN =8,			// 	:VARCHAR2(10) 
		IxSPEC_MAX =9,			// 	:VARCHAR2(10) 
		IxUNIT_CD =10,			// 	:VARCHAR2(4) 
		IxMETHOD =11,			// 	:VARCHAR2(20) 
		IxREMARKS =12,			// 	:VARCHAR2(500) 
		IxSEND_CHK =13,			// 	:VARCHAR2(10) 
		IxSEND_YMD =14,			// 	:DATE(7) 
		IxUPD_USER =15,			// 	:VARCHAR2(30) 
		IxUPD_YMD =16,			// 	:DATE(7) 
	}  



	/// <summary> 
	/// SQC_LAB_SPEC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_FOMULAN_MUTI : int
	{ 
		IxMaxCt   = 10,
		IxFLAG =  1,
		IxFACTORY =  2,
		IxSEQ     =  3,
		IxFORMULA_YEAR =  4,
		IxSEASON_CD =  5,
		IxMODEL_CD =  6,
		IxSTYLE_CD =  7,
		IxMCS_CD =  8,
		IxMCS_COLOR_CD =  9,
		IxMCS_NAME =  10,
		IxMCS_COLORNAME =  11,
		
	}  

	



	#endregion

	#region 조재성 추가
	/// <summary> 
	/// SBT_ITEM_GROUP_RELATION 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBT_ITEM_GROUP_RELATION : int 
	{ 
		IxMaxCt = 17,				// 인덱스 Count 
		IxCLASS_CD =1,				// 	:VARCHAR2(6) 
		IxGROUP_TYPE =2,			// 	:VARCHAR2(2) 
		IxGROUP_L =3,				// 	:VARCHAR2(1) 
		IxGROUP_M =4,				// 	:VARCHAR2(2) 
		IxGROUP_S =5,				// 	:VARCHAR2(3) 
		IxGROUP_CD =6,				// 	:VARCHAR2(8) 
		IxGROUP_NAME =7,			// 	:VARCHAR2(500) 
		IxGROUP_LEVEL =8,			// 	:NUMBER(22) 
		IxITEM_CD =9,				// 	:VARCHAR2(10) 
		IxMAN_CHARGE_DS =10,		// 	:VARCHAR2(30) 
		IxMAN_CHARGE_QD =11,		// 	:VARCHAR2(30) 
		IxMAN_CHARGE_VJ =12,		// 	:VARCHAR2(30) 
		IxATTRIBUTE =13,			// 	:VARCHAR2(4) 
		IxUSE_YN =14,				// 	:VARCHAR2(1) 
		IxDEFAULT_UNIT =15,			// 	:VARCHAR2(10) 
		IxUPD_USER =16,				// 	:VARCHAR2(30) 
		IxUPD_YMD =17,				// 	:DATE(7) 
	}  


	/// <summary> 
	/// SBM_MRP_LLT_TRACKING 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBM_MRP_LLT_TRACKING : int 
	{ 
		IxMaxCt				= 44,		// 인덱스 Count 
		IxFACTORY			= 1,			// 	:VARCHAR2(5) 
		IxITEM_CD			= 2,			// 	:VARCHAR2(10) 
		IxSPEC_CD			= 3,			// 	:VARCHAR2(5) 
		IxCOLOR_CD			= 4,			// 	:VARCHAR2(5) 
		IxDEL_MONTH			= 5,			// 	:VARCHAR2(8) 
		IxOBS_TYPE			= 6,			// 	:VARCHAR2(2) 
		IxNEW				= 7,    
		IxSTYLE_CD			= 8,			// 	:VARCHAR2(9) 
		IxSTYLE_NAME		= 9,			// 	:VARCHAR2(200) 
		IxGENDOR			= 10,			// 	:VARCHAR2(10) 
		IxPST_YN			= 11,			// 	:VARCHAR2(10) 
		IxSEASON			= 12,			// 	:VARCHAR2(10) 
		IxSEASON_YEAR		= 13,			// 	:VARCHAR2(10) 
		IxYIELD_STATUS		= 14,			// 	:VARCHAR2(100) 
		IxORDER_QTY			= 15,			// 	:NUMBER(22) 
		IxITEM_NAME			= 16,			// 	:VARCHAR2(500) 
		IxSPEC_NAME			= 17,			// 	:VARCHAR2(500) 
		IxCOLOR_NAME		= 18,			// 	:VARCHAR2(500) 
		IxYIELD_M			= 19,			// 	:NUMBER(22) 
		IxUSAGE				= 20,			// 	:NUMBER(22) 
		IxDIVISION2			= 21,			// 	:VARCHAR2(10) 
		IxMNG_UNIT			= 22,			// 	:VARCHAR2(10) 
		IxSIZE_YN			= 23,			// 	:VARCHAR2(10) 
		IxSTYLE_ITEM_DIV	= 24,			// 	:VARCHAR2(10) 
		IxCUST_CD			= 25,			// 	:VARCHAR2(10) 
		IxCUST_NAME			= 26,			// 	:VARCHAR2(200) 
		IxPURCHASE_1ST_QTY	= 27,			// 	:NUMBER(22) 
		IxPURCHASE_1ST_DATE = 28,			// 	:VARCHAR2(8) 
		IxDPO_ORDER			= 29,			// 	:NUMBER(22) 
		IxDPO_USAGE			= 30,			// 	:NUMBER(22) 
		IxBALANCE_DPO_ORDER = 31,			// 	:NUMBER(22) 
		IxBALANCE_DPO_USAGE = 32,			// 	:NUMBER(22) 
		IxPURCHASE_2ND_QTY	= 33,			// 	:NUMBER(22) 
		IxPURCHASE_2ND_DATE = 34,			// 	:VARCHAR2(8) 
		IxPURCHASE_STATUS	= 35,			// 	:VARCHAR2(20) 
		IxPURCHASE_RTA		= 36,			// 	:VARCHAR2(8) 
		IxPURCHASE_ETA		= 37,
		IxPURCHASE_SBOOK	= 38,
		IxMPS_PLAN_DATE		= 39,			// 	:VARCHAR2(8) 
		IxBALANCE_MPS		= 40,			// 	:NUMBER(22) 
		IxINCONING_DATE		= 41,			// 	:VARCHAR2(8) 
		IxINCOMING_QTY		= 42,			// 	:NUMBER(22) 
		IxBALANCE_INCOMING	= 43,			// 	:NUMBER(22) 
		IxGROUP_CD			= 44,			// 	:VARCHAR2(4) 
		IxREMARKS			= 45,			// 	:VARCHAR2(100) 
		IxUPD_USER			= 46,			// 	:VARCHAR2(30) 
		IxUPD_YMD			= 47,			// 	:DATE(7) 
	}  



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

	#endregion

	#region 박경은 추가
	/// <summary> 
	/// SBM_MRP_LLT_PLAN_TRACKING 테이블 인덱스 Enum 
	/// </summary> 
	public enum TSBM_MRP_LLT_PLAN_TRACKING : int 
	{ 
		IxMaxCt                    = 53, 
		IxFACTORY                  = 1, 
		IxOBS_ID                   = 2, 
		IxVER                      = 3,  
		IxMODEL_CD                 = 4, 
		IxMODEL_NAME               = 5,
		IxSTYLE_CD                 = 6, 
		IxMODEL_INF                = 7, 
		IxLINE_NAME                = 8, 
		IxORDER_QTY                = 9, 
		IxRGAC_YMD                 = 10,  
		IxPLAN_YMD_1               = 11, 
		IxPLAN_YMD_2               = 12, 
		IxREASON_DIV      = 13,
		IxLOCATION_CD              = 14, 
		IxLLT_YN       = 15,
		IxTARGET_MBOM              = 16,
		IxACTUAL_MBOM              = 17,
		IxWARNING_MBOM      = 18,
		IxTARGET_MUL               = 19, 
		IxACTUAL_MUL               = 20, 
		IxWARNING_MUL      = 21,
		IxTARGET_CFM_SAMPLE_MAT    = 22,
		IxACTUAL_CFM_SAMPLE_MAT    = 23,
		IxWARNING_CFM_SAMPLE_MAT   = 24,  
		IxTARGET_REF_PFC           = 25,           
		IxACTUAL_REF_PFC           = 26, 
		IxWARNING_REF_PFC          = 27,
		IxTARGET_CFM_SAMPLE        = 28,
		IxACTUAL_CFM_SAMPLE        = 29,
		IxWARNING_CFM_SAMPLE       = 30,
		IxVENDOR_LEAD_TIME         = 31,
		IxACTUAL_COLOR_SWATCH_RECV = 32,
		IxTARGET_COLOR_SWATCH      = 33,      
		IxACTUAL_COLOR_SWATCH      = 34,
		IxWARNING_COLOR_SWATCH     = 35,  
		IxTARGET_PURCHASING        = 36,        
		IxACTUAL_PURCHASING        = 37,
		IxWARNING_PURCHASING       = 38,
		IxTARGET_ETD               = 39,
		IxACTUAL_ETD               = 40,
		IxWARNING_ETD              = 41,
		IxTARGET_ETA_PORT          = 42,
		IxACTUAL_ETA_PORT          = 43,
		IxWARNING_ETA_PORT         = 44,
		IxACTUAL_ETA_VJ            = 45, 
		IxWARNING_ETA_VJ           = 46,
		IxD_HOW_MANY_DAYS          = 47,
		IxSTATUS       = 48,
		IxUPD_USER       = 49,
		IxUPD_YMD       = 50,
		IxAGREE_DATE      = 51,
		IxTHEME        = 52,
		IxREASON       = 53,

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
   

	# endregion


}