using System;

namespace FlexBase.ClassLib
{


    #region 기준정보




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
		IxUPD_USR		= 13, 	// 작성자 : VARCHAR2(30)
		IxUPD_YMD		= 14, 	//   : DATE(7)
	}




	/// <summary> 
	/// SDC_STYLE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSDC_STYLE : int
	{
		IxMaxCt			= 24,	// 인덱스 Count
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
		IxBOM_ID		= 21, 	// 비고 : VARCHAR2(500) 
		IxBOM_REV		= 22, 	// 비고 : VARCHAR2(500) 
		IxUPD_USER		= 23,	//   : VARCHAR2(30)
		IxUPD_YMD		= 24, 	//   : DATE(7)
	}




	public enum TBSBC_ITEM_GROUP : int 
	{ 

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
        IxMAN_CHARGE_JJ     =17,	// 담당자-JJ	:VARCHAR2(10) 
		IxVALIDATION_KEY_01 =18,	 
		IxVALIDATION_VALUE_01 =19, 
		IxSEND_CHK			=20,	// 송신체크		:VARCHAR2(1) 
		IxSEND_YMD			=21,	// 송신일		:DATE(7) 
		IxUPD_USER			=22,	// 수정자		:VARCHAR2(10) 
		IxUPD_YMD			=23,	// 수정일		:DATE(7) 
	}



	/// <summary> 
	/// SBC_ITEM 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_ITEM_WITH_CUSTNAME : int 
	{ 

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
        IxCUS_CD_JJ             =  32,		// 주거래처코드-JJ	:VARCHAR2(10) 
		IxCUS_NAME_DS			=  33,		// 주거래처코드-DS	:VARCHAR2(10) 
		IxCUS_NAME_QD			=  34,		// 주거래처코드-QD	:VARCHAR2(10) 
		IxCUS_NAME_VJ			=  35,		// 주거래처코드-VJ	:VARCHAR2(10) 
        IxCUS_NAME_JJ           =  36,		// 주거래처코드-JJ	:VARCHAR2(10) 
		IxMAN_CHARGE_DS			=  37,		// 담당자-DS		:VARCHAR2(10) 
		IxMAN_CHARGE_QD			=  38,		// 담당자-QD		:VARCHAR2(10) 
		IxMAN_CHARGE_VJ			=  39,		// 담당자-VJ		:VARCHAR2(10) 
        IxMAN_CHARGE_JJ         =  40,		// 담당자-JJ		:VARCHAR2(10) 
		IxIMPORT_DS				=  41,		// 수입자재여부-DS	:VARCHAR2(1) 
		IxIMPORT_QD				=  42,		// 수입자재여부-QD	:VARCHAR2(1) 
		IxIMPORT_VJ				=  43,		// 수입자재여부-VJ	:VARCHAR2(1) 
        IxIMPORT_JJ             =  44,		// 수입자재여부-JJ	:VARCHAR2(1) 
		IxCOST_YN				=  45,		// 원가관리여부		:VARCHAR2(1) 
		IxACC_DIV_YN			=  46,		// 회계분류사용여부	:VARCHAR2(1) 
		IxACC_DIV_DS			=  47,		// 회계분류-DS		:VARCHAR2(10) 
		IxACC_DIV_QD			=  48,		// 회계분류-QD		:VARCHAR2(10) 
		IxACC_DIV_VJ			=  49,		// 회계분류-VJ		:VARCHAR2(10) 
        IxACC_DIV_JJ            =  50,		// 회계분류-JJ		:VARCHAR2(10) 
		IxLONE_YN				=  51,		// 장/단기자재 구분	:VARCHAR2(1) 
		IxDL_DAYS_DS			=  52,		// 납기소요일-DS	:NUMBER(22) 
		IxDL_DAYS_QD			=  53,		// 납기소요일-QD	:NUMBER(22) 
		IxDL_DAYS_VJ			=  54,		// 납기소요일-VJ	:NUMBER(22) 
        IxDL_DAYS_JJ            =  55,		// 납기소요일-JJ	:NUMBER(22) 
		IxSAFE_AMT_DS			=  56,		// 안전재고량-DS	:NUMBER(22) 
		IxSAFE_AMT_QD			=  57,		// 안전재고량-QD	:NUMBER(22) 
		IxSAFE_AMT_VJ			=  58,		// 안전재고량-VJ	:NUMBER(22) 
        IxSAFE_AMT_JJ           =  59,		// 안전재고량-JJ	:NUMBER(22) 
		IxLIFE_YN				=  60,		// 악성재고 유무	:VARCHAR2(1) 
		IxLIFE_DAY				=  61,		// 악성재고 일수	:NUMBER(22) 
		IxIN_WH_CD				=  62,		// 입고창고			:VARCHAR2(10) 
		IxOUT_WH_CD				=  63,		// 출고창고			:VARCHAR2(10) 
		IxPUR_LOSS_RATE			=  64,		// PUR_LOSS_RATE 	:NUMBER(22) 
		IxOUT_LOSS_RATE			=  65,		// 출고 Loss		:NUMBER(22) 
		IxSHIP_LOSS_RATE		=  66,		// 선적 Loss		:NUMBER(22) 
		IxPUR_LOT_AMT			=  67,		// 발주LOT			:NUMBER(22) 
		IxPROD_IN_LOT			=  68,		// 생산불출LOT		:NUMBER(22) 
		IxMCS_NO				=  69,		// MCS 번호			:VARCHAR2(20) 
		IxHS_NO					=  70,		// HS_NO			:VARCHAR2(20) 
		IxCBM					=  71,		// CBM				:NUMBER(22) 
		IxGROSS_WEIGHT			=  72,		// 중량(Gross)		:VARCHAR2(100) 
		IxNET_WEIGHT			=  73,		// 중량(Net)		:VARCHAR2(100) 
		IxVOLUME				=  74,		// 부피				:VARCHAR2(100) 
		IxLENGTH				=  75,		// 길이				:VARCHAR2(100) 
		IxWIDTH					=  76,		// 폭				:VARCHAR2(100) 
		IxHEIGHT				=  77,		// 높이				:VARCHAR2(100) 
		IxUPD_USER				=  78,		// 수정일			:DATE(7) 
		IxUPD_YMD				=  79, 		// 수정자			:VARCHAR2(10) 
	}					





	/// <summary> 
	/// SBC_ITEM 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_ITEM_POP_SHOW : int 
	{ 

		IxITEM_CD				=   0, 	// 품목코드			:VARCHAR2(10) 
		IxGROUP_CD				=   1, 	// 그룹코드			:VARCHAR2(10) 
		IxITEM_NAME1			=   2, 	// 품목명1			:VARCHAR2(100) 
		IxITEM_NAME2			=   3, 	// 품목명2			:VARCHAR2(100) 
		IxITEM_NAME3			=   4, 	// 품목명3			:VARCHAR2(100) 
		IxITEM_NAME4			=   5, 	// 품목명4			:VARCHAR2(100) 
		IxITEM_NAME5			=   6, 	// 품목명5			:VARCHAR2(100) 
		IxSIZE_YN				=   7, 	// 사이즈자재여부	:VARCHAR2(1) 
		IxUSE_YN				=   8, 	// USE_YN 			:VARCHAR2(1) 
		IxREP_ITEM_CD			=   9, 	// 대표품목코드		:VARCHAR2(10) 
		IxCOPY_FROM				=  10, 	// 복사출처 		:VARCHAR2(10) 
		IxREMARK				=  11, 	// 비고				:VARCHAR2(500) 
        IxREG_YMD               =  12, 
		IxMNG_UNIT				=  13, 	// 관리단위			:VARCHAR2(10) 
		IxPK_QTY				=  14, 	// PK수량			:NUMBER(22) 
		IxSPEC_TYPE				=  15, 	// Spec 단위		:VARCHAR2(70) 
		IxSTYLE_ITEM_DIV		=  16, 	// 스타일자재분류	:VARCHAR2(10) 
		IxBUY_DIV				=  17, 	// 구매분류			:VARCHAR2(10) 
		IxSTOCK_UNIT			=  18, 	// 재고단위			:VARCHAR2(10) 
		IxITEM_CONV				=  19, 	// 환산계수			:NUMBER(22) 
		IxABC_DIV				=  20, 	// ABC분류			:VARCHAR2(10) 
		IxINSP_YN				=  21, 	// 검사여부			:VARCHAR2(1) 
		IxPUR_PRICE				=  22, 	// 구매단가			:NUMBER(22) 
		IxPUR_CURRENCY			=  23, 	// 구매화폐			:VARCHAR2(10) 
		IxCBD_PRICE				=  24, 	// CBD단가			:NUMBER(22) 
		IxCBD_CURRENCY			=  25, 	// CBD화폐			:VARCHAR2(10) 
		IxPROCESSING_YN			=  26, 	// 임가공여부		:VARCHAR2(1) 
		IxPROCESSING_PRICE		=  27, 	// 임가공비용		:NUMBER(22) 
		IxPROCESSING_CURRENCY	=  28, 	// 임가공 화폐단위	:VARCHAR2(10) 
		IxCUS_CD_DS				=  29, 	// 주거래처코드-DS	:VARCHAR2(10) 
		IxCUS_CD_QD				=  30, 	// 주거래처코드-QD	:VARCHAR2(10) 
		IxCUS_CD_VJ				=  31, 	// 주거래처코드-VJ	:VARCHAR2(10) 
        IxCUS_CD_JJ             =  32, 	// 주거래처코드-JJ	:VARCHAR2(10)
		IxMAN_CHARGE_DS			=  33, 	// 담당자-DS		:VARCHAR2(10) 
		IxMAN_CHARGE_QD			=  34, 	// 담당자-QD		:VARCHAR2(10) 
		IxMAN_CHARGE_VJ			=  35, 	// 담당자-VJ		:VARCHAR2(10) 
        IxMAN_CHARGE_JJ         =  36, 	// 담당자-JJ		:VARCHAR2(10) 
		IxIMPORT_DS				=  37, 	// 수입자재여부-DS	:VARCHAR2(1) 
		IxIMPORT_QD				=  38, 	// 수입자재여부-QD	:VARCHAR2(1) 
		IxIMPORT_VJ				=  39, 	// 수입자재여부-VJ	:VARCHAR2(1) 
        IxIMPORT_JJ             =  40, 	// 수입자재여부-JJ	:VARCHAR2(1) 
		IxCOST_YN				=  41, 	// 원가관리여부		:VARCHAR2(1) 
		IxACC_DIV_YN			=  42, 	// 회계분류사용여부	:VARCHAR2(1) 
		IxACC_DIV_DS			=  43, 	// 회계분류-DS		:VARCHAR2(10) 
		IxACC_DIV_QD			=  44, 	// 회계분류-QD		:VARCHAR2(10) 
		IxACC_DIV_VJ			=  45, 	// 회계분류-VJ		:VARCHAR2(10) 
        IxACC_DIV_JJ            =  46, 	// 회계분류-JJ		:VARCHAR2(10) 
		IxLONE_YN				=  47, 	// 장/단기자재 구분	:VARCHAR2(1) 
		IxDL_DAYS_DS			=  48, 	// 납기소요일-DS	:NUMBER(22)   
		IxDL_DAYS_QD			=  49, 	// 납기소요일-QD	:NUMBER(22) 
		IxDL_DAYS_VJ			=  50, 	// 납기소요일-VJ	:NUMBER(22) 
        IxDL_DAYS_JJ            =  51, 	// 납기소요일-JJ	:NUMBER(22) 
		IxSAFE_AMT_DS			=  52, 	// 안전재고량-DS	:NUMBER(22) 
		IxSAFE_AMT_QD			=  53, 	// 안전재고량-QD	:NUMBER(22) 
		IxSAFE_AMT_VJ			=  54, 	// 안전재고량-VJ	:NUMBER(22) 
        IxSAFE_AMT_JJ           =  55, 	// 안전재고량-JJ	:NUMBER(22) 
		IxLIFE_YN				=  56, 	// 악성재고 유무	:VARCHAR2(1) 
		IxLIFE_DAY				=  57, 	// 악성재고 일수	:NUMBER(22) 
		IxIN_WH_CD				=  58, 	// 입고창고			:VARCHAR2(10) 
		IxOUT_WH_CD				=  59, 	// 출고창고			:VARCHAR2(10) 
		IxPUR_LOSS_RATE			=  60, 	// PUR_LOSS_RATE 	:NUMBER(22) 
		IxOUT_LOSS_RATE			=  61, 	// 출고 Loss		:NUMBER(22) 
		IxSHIP_LOSS_RATE		=  62, 	// 선적 Loss		:NUMBER(22) 
		IxPUR_LOT_AMT			=  63, 	// 발주LOT			:NUMBER(22) 
		IxPROD_IN_LOT			=  64, 	// 생산불출LOT		:NUMBER(22) 
		IxMCS_NO				=  65, 	// MCS 번호			:VARCHAR2(20) 
		IxHS_NO					=  66, 	// HS_NO			:VARCHAR2(20) 
		IxCBM					=  67, 	// CBM				:NUMBER(22) 
		IxGROSS_WEIGHT			=  68, 	// 중량(Gross)		:VARCHAR2(100) 
		IxNET_WEIGHT			=  69, 	// 중량(Net)		:VARCHAR2(100) 
		IxVOLUME				=  70, 	// 부피				:VARCHAR2(100) 
		IxLENGTH				=  71, 	// 길이				:VARCHAR2(100) 
		IxWIDTH					=  72, 	// 폭				:VARCHAR2(100) 
		IxHEIGHT				=  73,	// 높이				:VARCHAR2(100) 
        IxCHILD_ITEM_CD         =  74,	// 수정일			:DATE(7) 
	}



    /// <summary>
    /// Item e-Catalog
    /// </summary>
    public enum TBSBC_ITEM_IMAGE : int
    {
        IxITEM_CD = 1,
        IxSEQ = 2,
        IxIMAGE_NAME = 3,
        IxIMAGE = 4,
        IxDELETE_YN = 5,
    } 





    /// <summary> 
    /// SBC_SPEC 테이블 인덱스 Enum 
    /// </summary> 
    public enum TBSBC_SPEC : int
    {
        IxMaxCt = 7,		// 인덱스 Count 
        IxSPEC_DIV = 1,			// 스펙구분
        IxSPEC_CD = 2,			// 스펙코드	:VARCHAR2(10) 
        IxSPEC_NAME = 3,			// 스펙명	:VARCHAR2(50) 
        IxUSE_YN = 4,			// 사용여부	:VARCHAR2(1) 
        IxCONVERSION = 5,
        IxSEND_CHK = 6,			// 송신체크	:VARCHAR2(1) 
        IxSEND_YMD = 7,			// 송신일	:DATE(7) 
        IxUPD_USER = 8,			// 수정자	:VARCHAR2(10) 
        IxUPD_YMD = 9,			// 수정일	:DATE(7) 
    }



    /// <summary> 
    /// SBC_COLOR 테이블 인덱스 Enum 
    /// </summary> 
    public enum TBSBC_COLOR : int
    {
        IxMaxCt = 9,		// 인덱스 Count 
        IxCOLOR_CD = 1,			// Color코드	:VARCHAR2(10) 
        IxCOLOR_NAME = 2,			// Color명	:VARCHAR2(120) 
        IxNIKE_CD_YN = 3,			// 나이키코드여부	:VARCHAR2(10) 
        IxREMARKS = 4,			// 설명	:VARCHAR2(120) 
        IxUSE_YN = 5,			// 사용여부	:VARCHAR2(10) 
        IxSEND_CHK = 6,			// 송신체크	:VARCHAR2(10) 
        IxSEND_YMD = 7,			// 송신일	:DATE(7) 
        IxUPD_USER = 8,			// 수정자	:VARCHAR2(10) 
        IxUPD_YMD = 9,			// 수정일	:DATE(7) 
    }  



    /// <summary> 
    /// SBC_COMPONENT 테이블 인덱스 Enum 
    /// </summary> 
    public enum TBSBC_COMPONENT : int
    {
        IxMaxCt = 7,		// 인덱스 Count 
        IxCOMPONENT = 1,			// 컴포넌트코드	:VARCHAR2(10) 
        IxCOMPONENT_NM = 2,			// 컴포넌트명	:VARCHAR2(50) 
        IxUSE_YN = 3,			// 사용여부	:VARCHAR2(1) 
        IxSEND_CHK = 4,			// 송신체크	:VARCHAR2(1) 
        IxSEND_YMD = 5,			// 송신일	:DATE(7) 
        IxUPD_USER = 6,			// 수정자	:VARCHAR2(10) 
        IxUPD_YMD = 7,			// 수정일	:DATE(7) 
    }



    /// <summary> 
    /// SBC_MCS 테이블 인덱스 Enum 
    /// </summary> 
    public enum TBSBC_MCS : int
    {
        IxMaxCt = 9,		// 인덱스 Count 
        IxMCS_CD = 1,			// MCS코드	:VARCHAR2(10) 
        IxMCS_NAME = 2,			// MCS명	:VARCHAR2(50) 
        IxCMP_CD = 3,			// 반제코드	:VARCHAR2(10) 
        IxOP_CD = 4,			// 공정코드	:VARCHAR2(10) 
        IxUSE_YN = 5,			// 사용여부	:VARCHAR2(1) 
        IxSEND_CHK = 6,			// 송신체크	:VARCHAR2(1) 
        IxSEND_YMD = 7,			// 송신일	:DATE(7) 
        IxUPD_USER = 8,			// 수정자	:VARCHAR2(10) 
        IxUPD_YMD = 9,			// 수정일	:DATE(7) 
    }



    /// <summary> 
    /// SBC_COLOR 테이블 인덱스 Enum 
    /// </summary> 
    public enum TBSBC_MCS_COLOR : int
    {
        IxMaxCt = 10,		// 인덱스 Count 
        lxFACTORY = 1,
        IxCOLOR_CD = 2,			// Color코드	:VARCHAR2(10) 
        IxCOLOR_NAME = 3,			// Color명	:VARCHAR2(120) 
        IxNIKE_CD_YN = 4,			// 나이키코드여부	:VARCHAR2(10) 
        IxREMARKS = 5,			// 설명	:VARCHAR2(120) 
        IxUSE_YN = 6,			// 사용여부	:VARCHAR2(10) 
        IxSEND_CHK = 7,			// 송신체크	:VARCHAR2(10) 
        IxSEND_YMD = 8,			// 송신일	:DATE(7) 
        IxUPD_USER = 9,			// 수정자	:VARCHAR2(10) 
        IxUPD_YMD = 10,			// 수정일	:DATE(7) 
    }  



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
    /// SBC_WAREHOUSE 테이블 인덱스 Enum 
    /// </summary> 
    public enum TBSBC_WAREHOUSE : int
    {
        IxMaxCt = 9,		// 인덱스 Count 
        IxFACTORY = 1,			// 공장코드	:VARCHAR2(5) 
        IxWH_CD = 2,			// 창고코드	:VARCHAR2(10) 
        IxWH_NAME = 3,			// 창고명	:VARCHAR2(50) 
        IxIN_WH_LOC_CD = 4,			// 입고기본위치	:VARCHAR2(10) 
        IxOUT_WH_LOC_CD = 5,			// 출고기본위치	:VARCHAR2(10) 
        IxREMARKS = 6,			// 설명	:VARCHAR2(100) 
        IxUSE_YN = 7,			// 사용여부	:VARCHAR2(1) 
        IxUPD_USER = 8,			// 수정자	:VARCHAR2(10) 
        IxUPD_YMD = 9,			// 수정일	:DATE(7) 
    }




    /// <summary>
    /// 환율 조회
    /// </summary>
    public enum TBSCM_EXCH_RATE : int
    {
        IxTB_TREE_LEVEL = 0,
        IxTB_YMD = 1,
        IxTB_CURRCD = 2,
        IxTB_STDEXCH = 3,

        IxYMD_CURRCD = 1,
        IxSTDEXCH = 2,
    } 




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
    /// 공통 popup - Item 
    /// </summary>
    public enum TBSBC_ITEM_COMMON : int
    {
        IxITEM_CD = 1,
        IxGROUP_CD = 2,
        IxITEM_NAME1 = 3,
        IxMNG_UNIT = 4,
        IxSIZE_YN = 5,
        IxUSE_YN = 6,
    }


    /// <summary>
    /// 공통 popup - Sepcification
    /// </summary>
    public enum TBSBC_SPEC_COMMON : int
    {
        IxSPEC_CD = 1,
        IxSPEC_NAME = 2,
        IxUSE_YN = 3,
    }



    /// <summary>
    /// 공통 popup - Color
    /// </summary>
    public enum TBSBC_COLOR_COMMON : int
    {
        IxCOLOR_CD = 1,
        IxCOLOR_NAME = 2,
        IxNIKE_CD_YN = 3,
        IxUSE_YN = 4,

    }



    /// <summary>
    /// TBSBC_ITEM_GROUP_SEARCH : 
    /// </summary>
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
        IxMAN_CHARGE_JJ     =11,	// 담당자-JJ	:VARCHAR2(10)  

	}




    /// <summary> 
    /// NODE_DEF : 노드 속성 지정해 주기 위한 인덱스
    /// </summary> 
    public enum DEFAULT_NODE_DEF : int
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



    /// <summary> 
    /// NODE_DEF : 노드 속성 지정해 주기 위한 인덱스
    /// </summary> 
    public enum NODE_DEF : int
    {
        IxALIGNMENT = 5,			// 텍스트 정렬 방식	:VARCHAR2(10) 
        IxDASHSTYLE = 6,			// 노드 테두리 스타일	:VARCHAR2(10) 
        IxDRAWCOLOR = 7,			// 노드 테두리 색깔	:VARCHAR2(10) 
        IxDRAWWIDTH = 8,			// 노드 테두리 선 두께	:VARCHAR2(10) 
        IxFILLCOLOR = 9,			// 노드 채우기 색깔	:VARCHAR2(10) 
        IxFONT = 10,			// 텍스트 폰트 속성	:VARCHAR2(60) 
        IxGRADI_YN = 11,			// GRADIANT 여부	:VARCHAR2(1) 
        IxGRADICOLOR = 12,			// GRADIANT 색깔	:VARCHAR2(10) 
        IxGRADIMODE = 13,			// GRADIANT 모드 (스타일)	:VARCHAR2(10) 
        IxHEIGHT = 14,			// 노드 높이	:VARCHAR2(10) 
        IxSHADOW = 15,			// 노드 그림자 표시 속성	:VARCHAR2(60) 
        IxSHAPE = 16,			// 노드 테두리 모양 속성	:VARCHAR2(60) 
        IxTAG = 17,			// 태그 속성	:VARCHAR2(60) 
        IxTEXT = 18,			// 텍스트	:VARCHAR2(60) 
        IxTEXTCOLOR = 19,			// 텍스트 표시 색깔	:VARCHAR2(10) 
        IxTOOLTIP = 20,			// 툴팁	:VARCHAR2(60) 
        IxWIDTH = 21,			// 노드 너비	:VARCHAR2(10) 

    }



    /// <summary> 
    /// LINK_DEF : 링크 속성 지정해 주기 위한 인덱스
    /// </summary> 
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




    #endregion

    #region 채산


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
		IxFAVORITE_YN			= 14,		// 수정일			:DATE(7)
		IxSEND_CHK				= 15,		// 송신체크			:VARCHAR2(10) 
		IxSEND_DATE				= 16,		// 송신일			:DATE(7) 
		IxUPD_USER				= 17,		// 수정자			:VARCHAR2(10) 
		IxUPD_YMD				= 18,		// 수정일			:DATE(7)

		IxSIZE_YN               = 19,
		IxMNG_UNIT              = 20,
		IxCS_SIZE_START         = 21,
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



     #region 채산 New


    /// <summary> 
    /// TBSBC_YIELD_NEW 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_YIELD_NEW : int 
	{ 
	
		IxDIVISION					=  0,		
		IxDISPLAY_LEVEL             =  1,		
		IxDISPLAY_DESC              =  2,		
		IxFACTORY                   =  3,       
		IxSTYLE_CD                  =  4,		
		IxSEMI_GOOD_CD              =  5,		
		IxCOMPONENT_CD              =  6,		
		IxCOMPONENT_NAME            =  7,		
		IxTEMPLATE_SEQ              =  8,		
		IxTEMPLATE_LEVEL            =  9,       
		IxTEMPLATE_TREE_CD          = 10,		
		IxTEMPLATE_NAME             = 11,		
		IxTEMPLATE_CD               = 12,		
		IxROW_TYPE                  = 13,		
		IxITEM_CD                   = 14,		
		IxITEM_NAME1                = 15,			
		IxITEM_NAME2                = 16,	
		IxSPEC_CD_HEAD              = 17,		
		IxSPEC_NAME_HEAD            = 18,	
		IxCOLOR_CD                  = 19,		
		IxCOLOR_NAME                = 20,		
		IxMNG_UNIT                  = 21,
		IxSIZE_YN                   = 22,
		IxSTYLE_ITEM_DIV            = 23, 
		IxCOMMON_YN                 = 24, 
		IxSHIP_YN                   = 25, 
		IxPUR_SHIP_YN               = 26, 
		IxPUR_IMPORT_YN             = 27, 
		IxPUR_LOCAL_YN              = 28, 
		IxPROD_YN                   = 29, 
		IxPROD_OP_CD                = 30, 
		IxPROD_SEMI_GOOD_CD         = 31, 
		IxOUISIDE_IN_YN             = 32, 
		IxOUTSIDE_OUT_YN            = 33, 
		IxSHIP_LOSS_RATE            = 34, 
		IxPUR_LOSS_RATE             = 35, 
		IxPROD_LOSS_RATE            = 36,
		IxCOMPONENT_SEQ             = 37,  
		IxYIELD_STATUS              = 38,
		IxTEMPLATE_PROPERTY         = 39,
		IxEXCEL_COMPONENT_ORDER     = 40,
		IxCS_SIZE_START             = 41,

        IxDB_SPEC_CD                = 40,
        IxDB_SPEC_NAME              = 41,
        IxDB_CS_SIZE_FROM           = 42,
        IxDB_CS_SIZE_TO             = 43,
        IxDB_SIZE_ORDER_FROM        = 44,
        IxDB_SIZE_ORDER_TO          = 45,
        IxDB_YIELD_M                = 46,
        IxDB_TEMPLATE_LEVEL_ORDER   = 47,


	}



    /// <summary>
    /// TBSBC_YIELD_JOINT_TEMPLATE_HEAD_NEW : 
    /// </summary>
    public enum TBSBC_YIELD_JOINT_TEMPLATE_HEAD_NEW : int 
	{ 
	
		IxTEMPLATE_TREE_CD           =  1,	
		IxTEMPLATE_TREE_NAME         =  2,	
		IxTEMPLATE_ORDER             =  3,	

	}



    /// <summary> 
    /// TBSBC_YIELD_JOINT_TEMPLATE_NEW 테이블 인덱스 Enum 
	/// </summary> 
    public enum TBSBC_YIELD_JOINT_TEMPLATE_NEW : int 
	{ 
	
		IxTEMPLATE_TREE_CD           =  0,	
		IxTEMPLATE_LEVEL             =  1,	
		IxTEMPLATE_CD                =  2,	
		IxTEMPLATE_NAME              =  3,  
		IxPROPERTY_MODEL             =  4,	
		IxPROPERTY_STYLE             =  5,	
		IxPROPERTY_COMPONENT	     =  6,	
		IxPROPERTY_GENDER            =  7,	
		IxPROPERTY_PREFIX            =  8,	
		IxTEMPLATE_KEY               =  9,  
		IxROW_TYPE                   = 10,  
		IxSIZE_YN                    = 11,  
		IxMNG_UNIT                   = 12,  

	}




    /// <summary> 
    /// TBSBC_YIELD_EXCEL_LOADING_NEW :  
	/// </summary> 
    public enum TBSBC_YIELD_EXCEL_LOADING_NEW : int 
	{   
	   

        IxEX_COMPONENT              =  0,
        IxEX_ITEM_CD                =  1,
        IxEX_MNG_UNIT               =  2,
        IxEX_SIZE_YN                =  3,
        IxEX_SPEC_CD                =  4,
        IxEX_COLOR_CD               =  5,
		IxEX_MATERIAL_USE           =  6,
		IxEX_MATERIAL               =  7,
		IxEX_SPEC_UNIT	            =  8,
		IxEX_COLOR	                =  9,
		IxEX_DESCRIPTION            = 10,
		IxEX_COMMON_YIELD_VALUE     = 11,


		IxCOMPONENT                 =  1,
        IxITEM_CD                   =  2,
        IxMNG_UNIT                  =  3,
        IxSIZE_YN                   =  4,
        IxSPEC_CD                   =  5,
        IxCOLOR_CD                  =  6,
		IxMATERIAL_USE              =  7,
		IxMATERIAL                  =  8,
		IxSPEC_UNIT	                =  9,
		IxCOLOR	                    = 10,
		IxDESCRIPTION               = 11,
		IxCOMMON_YIELD_VALUE        = 12,
        IxCS_SIZE_START             = 13,


	}



    /// <summary>
    /// TBSBC_YIELD_VALUE_NEW : 
    /// </summary>
    public enum TBSBC_YIELD_VALUE_NEW : int
    {
        IxDESCRIPTION                = 1,
        IxCS_SIZE_START              = 2,
    } 



    /// <summary> 
    /// TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_YIELD_ITEM_GROUP_IN_YIELD_NEW : int 
	{ 
			
		IxFACTORY                   =  0,		
		IxSTYLE_CD                  =  1,	
		IxCS_SIZE_FROM              =  2,		
		IxCS_SIZE_TO                =  3,
		IxCS_SIZE                   =  4,
		IxITEM_CD                   =  5,	
		IxSPEC_CD                   =  6,
		IxSPEC_NAME                 =  7,
		IxYIELD_M                   =  8,  

	}



    /// <summary>
    /// TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW : 
    /// </summary>
    public enum TBSBC_YIELD_CHANGE_MAT_INSERT_STYLE_NEW : int
    {

        IxFACTORY                   =  1,
        IxSTYLE_CD                  =  2,
        IxSTYLE_NAME                =  3,
        IxGENDER                    =  4,
        IxPRESTO_YN                 =  5,
        IxYIELD_STATUS              =  6,
        IxMODEL_CD                  =  7,
        IxMODEL_NAME                =  8,
        IxSTATUS                    =  9,
                                     
                                     
    }                                
                                     
           
    
    /// <summary>
    /// TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW : 
    /// </summary>
    public enum TBSBC_YIELD_CHANGE_MAT_UPDATE_STYLE_NEW : int
    {

        IxFACTORY                   =  1,
        IxSTYLE_CD                  =  2,
        IxSTYLE_NAME                =  3,
        IxGENDER                    =  4,
        IxPRESTO_YN                 =  5,
        IxYIELD_STATUS              =  6,
        IxMODEL_CD                  =  7,
        IxMODEL_NAME                =  8,
        IxSEMI_GOOD_CD              =  9,
        IxCOMPONENT_CD              = 10,
        IxCOMPONENT_NAME            = 11,
        IxTEMPLATE_SEQ              = 12,
        IxTEMPLATE_LEVEL            = 13,
        IxITEM_CD                   = 14,
        IxITEM_NAME                 = 15,
        IxSPEC_CD                   = 16,
        IxSPEC_NAME                 = 17,
        IxCOLOR_CD                  = 18,
        IxCOLOR_NAME                = 19,
        IxSTATUS                    = 20,
       
    
    }                 
                                     
    /// <summary>                    
    /// TBSBC_YIELD_CHANGE_MAT_VALUE_NEW : 
    /// </summary>                   
    public enum TBSBC_YIELD_CHANGE_MAT_VALUE_NEW : int
    {

        IxDESCRIPTION               =  1,
        IxCS_SIZE_START             =  2,


        IxDB_SPEC_CD                =  0,
        IxDB_SPEC_NAME              =  1,
        IxDB_CS_SIZE_FROM           =  2,
        IxDB_CS_SIZE_TO             =  3,
        IxDB_SIZE_ORDER_FROM        =  4,
        IxDB_SIZE_ORDER_TO          =  5,
        IxDB_YIELD_M                =  6,


    }  



    /// <summary> 
    /// TBSBC_YIELD_COPY_NEW 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_YIELD_COPY_NEW : int 
	{ 
			
		IxDISPLAY_LEVEL             =  1,		
		IxDISPLAY_DESC              =  2,		
		IxFACTORY                   =  3,       
		IxSTYLE_CD                  =  4,		
		IxSEMI_GOOD_CD              =  5,		
		IxCOMPONENT_CD              =  6,		
		IxCOMPONENT_NAME            =  7,	
		IxTEMPLATE_SEQ              =  8,
		IxTEMPLATE_LEVEL            =  9,  
		IxROW_TYPE                  = 10, 
		IxITEM_CD                   = 11, 
		IxITEM_NAME1                = 12, 
		IxITEM_NAME2                = 13, 
		IxSPEC_CD_HEAD              = 14, 
		IxSPEC_NAME_HEAD            = 15, 
		IxCOLOR_CD                  = 16, 
		IxCOLOR_NAME                = 17, 
		IxMNG_UNIT                  = 18, 
		IxSIZE_YN                   = 19, 
		IxCOMPONENT_SEQ             = 20, 
		IxTEMPLATE_LEVEL_ORDER      = 21, 
                                     
	}                                
                                     
                                     


    /// <summary>
    /// TBSBC_YIELD_ITEM_GROUP_NEW : 
    /// </summary>
    public enum TBSBC_YIELD_ITEM_GROUP_NEW : int
    {

        IxDIVISION                  =  0,
        IxROW_DIVISION              =  1,
        IxFACTORY                   =  2,
        IxSTYLE_CD                  =  3,
        IxITEM_CD                   =  4,
        IxITEM_NAME                 =  5,
        IxMNG_UNIT                  =  6,
        IxSIZE_YN                   =  7,
        IxDESCRIPTION               =  8,
        IxCS_SIZE_START             =  9,



        IxDB_FACTORY                =  0,
        IxDB_STYLE_CD               =  1,
        IxDB_ITEM_CD                =  2,
        IxDB_ITEM_NAME              =  3,
        IxDB_MNG_UNIT               =  4,
        IxDB_SIZE_YN                =  5,
        IxDB_CS_SIZE_FROM           =  6,
        IxDB_CS_SIZE_TO             =  7,
        IxDB_SPEC_CD                =  8,
        IxDB_SPEC_NAME              =  9,
        IxDB_YIELD_M                = 10,


    } 



    /// <summary>
    /// TBSBC_YIELD_STATUS_NEW : 
    /// </summary>
    public enum TBSBC_YIELD_STATUS_NEW : int 
	{ 
	
		IxSTYLE_CD                  =  1,
		IxSTYLE_NAME                =  2,	
		IxGENDER                    =  3,	
		IxPRESTO_YN                 =  4,  
		IxFACTORY                   =  5,	
		IxYIELD_STATUS_KEY          =  6,	
		IxYIELD_STATUS              =  7,	
		IxYIELD_SEASON              =  8,	
		IxCONFIRM_YMD               =  9,
        IxUPD_YMD                   = 10,  
		IxUPD_USER                  = 11, 
		IxREMARKS                   = 12, 

	}





    #endregion





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

		IxSTYLE_ITEM_DIV        = 23,
		IxCOMMON_YN             = 24, 
		IxSHIP_YN               = 25, 
		IxPUR_SHIP_YN           = 26, 
		IxPUR_IMPORT_YN         = 27, 
		IxPUR_LOCAL_YN          = 28, 
		IxPROD_YN               = 29, 
		IxPROD_OP_CD            = 30, 
		IxPROD_SEMI_GOOD_CD     = 31, 
		IxOUISIDE_IN_YN         = 32, 
		IxOUTSIDE_OUT_YN        = 33, 
		IxSHIP_LOSS_RATE        = 34, 
		IxPUR_LOSS_RATE         = 35, 
		IxPROD_LOSS_RATE        = 36, 

		IxSRF_NO				= 37,
		IxBOM_ID				= 38,
		IxSRF_SEQ_MAX			= 39,
		IxSRF_CDC_DEV			= 40, 
		 
		IxSPEC_CD_INFO			= 41, 
		IxSPEC_NAME_INFO		= 42,
		IxCS_SIZE_START         = 43,  


		// table index
		IxCOL_NUM               = 42,	
		IxCS_SIZE               = 43,   
		IxYIELD_VALUE			= 44, 

		


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



	/// <summary> 
	/// TBSBC_YIELD_NEOMICS :  
	/// </summary> 
	public enum TBSBC_YIELD_NEOMICS : int 
	{   
	   
		IxLEVEL1                = 0,
		IxKEY1                  = 1, 
		IxMAT_NAME				= 2,
		IxSPEC_CD	            = 3,
		IxCLR_NAME				= 4, 
		IxCOL_ORDER				= 5,
		IxCS_SIZE				= 6,
		IxYIELD_M				= 7, 
		IxREP_CD				= 8,
		 


		IxLEVEL                 = 1,
		IxKEY					= 2,
		IxTREE					= 3,
		IxSPEC	                = 4,
		IxCOLOR                 = 5,
		IxCS_SIZE_START         = 6,


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
	public enum TBSBC_YIELD_VALUE_TREE_PROCNAME : int 
	{   
		IxITEM_CD          = 0,	 
		IxITEM_NAME1	   = 1, 
		IxITEM_NAME	       = 2,

		IxTEMPLATE_LEVEL   = 3,

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
	/// SBC_YIELD_SIZE_GROUP 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_YIELD_SIZE_GROUP_IN_YIELD : int 
	{  
   
		IxFACTORY				= 0,		
		IxITEM_CD				= 1,		
		IxCS_SIZE				= 2,	 		
		IxSPEC_CD				= 3,		 
		IxSPEC_NAME			    = 4,

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
		IxTBSIZE_YN            = 14,
		IxTBMNG_UNIT           = 15,



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
		IxSIZE_YN              = 16,
		IxMNG_UNIT             = 17,



    }



	/// <summary>
	/// TBSBC_YIELD_ADD_ITEM_TAIL : 
	/// </summary>
	public enum TBSBC_YIELD_ADD_ITEM_TAIL : int
	{

		IxCHECK_FLAG            = 0,
		IxFACTORY               = 1, 
		IxSTYLE_CD              = 2,
		IxSTYLE_NAME            = 3, 
		IxSTATUS			    = 4, 
	}





	/// <summary>
	/// TBSBC_YIELD_REPLACE_ITEM_HEAD : 
	/// </summary>
	public enum TBSBC_YIELD_REPLACE_ITEM_HEAD : int
	{

		IxSTYLE_CD         = 0,
		IxSTYLE_NAME       = 1, 
		IxGENDER           = 2, 
		IxPRESTO_YN        = 3, 
		IxMODEL_CD         = 4,
		IxMODEL_NAME       = 5, 
		IxSEMI_GOOD_CD     = 6,
		IxCOMPONENT_CD     = 7, 
		IxCOMPONENT_NAME   = 8, 
		IxITEM_NAME1       = 9, 
		IxGROUP_CD         = 10, 

	}



	/// <summary>
	/// TBSBC_YIELD_REPLACE_ITEM_TAIL : 
	/// </summary>
	public enum TBSBC_YIELD_REPLACE_ITEM_TAIL : int
	{

		IxCHECK_FLAG            = 0,
		IxFACTORY               = 1, 
		IxSTYLE_CD              = 2,
		IxSTYLE_NAME            = 3,
		IxSEMI_GOOD_CD          = 4, 
		IxCOMPONENT_CD          = 5,
		IxTEMPLATE_SEQ          = 6,
		IxTEMPLATE_LEVEL        = 7, 
		IxITEM_CD               = 8, 
		IxITEM_NAME1            = 9, 
		IxSPEC_CD		        = 10,
		IxSPEC_NAME             = 11, 
		IxCOLOR_CD              = 12, 
		IxCOLOR_NAME            = 13,

		IxSTYLE_ITEM_DIV        = 14,
		IxCOMMON_YN             = 15, 
		IxSHIP_YN               = 16, 
		IxPUR_SHIP_YN           = 17, 
		IxPUR_IMPORT_YN         = 18, 
		IxPUR_LOCAL_YN          = 19, 
		IxPROD_YN               = 20, 
		IxPROD_OP_CD            = 21, 
		IxPROD_SEMI_GOOD_CD     = 22, 
		IxOUISIDE_IN_YN         = 23, 
		IxOUTSIDE_OUT_YN        = 24, 
		IxSHIP_LOSS_RATE        = 25, 
		IxPUR_LOSS_RATE         = 26, 
		IxPROD_LOSS_RATE        = 27, 

		IxCOMPONENT_SEQ         = 28,
		IxSRF_NO				= 29,
		IxBOM_ID				= 30,
		IxSRF_SEQ_MAX			= 31,
		IxSRF_CDC_DEV			= 32,

		IxSTATUS			    = 33, 
		IxCS_SIZE_START         = 34,

 


	}




	/// <summary>
	/// TBSBC_YIELD_DELETE_ITEM_HEAD : 
	/// </summary>
	public enum TBSBC_YIELD_DELETE_ITEM_HEAD : int
	{

		IxSTYLE_CD         = 0,
		IxSTYLE_NAME       = 1, 
		IxGENDER           = 2, 
		IxPRESTO_YN        = 3, 
		IxMODEL_CD         = 4,
		IxMODEL_NAME       = 5,  
		IxITEM_CD          = 6, 
		IxITEM_NAME1       = 7, 
		IxMNG_UNIT         = 8, 
		IxSIZE_YN          = 9, 
		IxSPEC_CD          = 10, 
		IxSPEC_NAME        = 11, 
		IxCOLOR_CD         = 12, 
		IxCOLOR_NAME       = 13,  


	}




	/// <summary> 
	/// SBC_YIELD_VALUE 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_YIELD_VALUE : int 
	{ 
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
	/// TBSBC_YIELD_STATUS :  
	/// </summary> 
	public enum TBSBC_YIELD_STATUS : int 
	{   
		 
 
		IxFACTORY               = 1, 
		IxSTYLE_CD				= 2,
		IxSTYLE_NAME	        = 3,
		IxYIELD_STATUS			= 4, 
		IxHIDDEN_KEY			= 5,
		IxYIELD_SEASON			= 6,
		IxCONFIRM_YMD			= 7, 
		IxJOB_DATE				= 8, 
		IxREMARKS               = 9,
		IxUPD_USER				= 10,
		IxUPD_YMD				= 11, 


	}



	/// <summary>
	/// TBSBC_YIELD_STATUS_CHECK : 
	/// </summary>
	public enum TBSBC_YIELD_STATUS_CHECK : int
	{

		IxFACTORY                    = 0,
		IxSTYLE_CD                   = 1, 
		IxSTYLE_NAME			     = 2, 
		IxYIELD_STATUS             = 3, 
		IxSTATUS_JOB_DATE	   	= 4,
		IxSAVE_DATE			     = 5, 
		IxSAVE_DATE_MIN          = 6, 
		IxSAVE_DATE_MAX        = 7,


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
		IxUPD_YMD				= 10,
		IxUPD_USER				= 11,
		IxCS_SIZE_START         = 12, 

		// table index
		IxCOL_NUM               = 11,	
		IxCS_SIZE               = 12,
		IxYIELD_VALUE			= 13, 
		


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
	/// SBC_YIELD_SIZE_GROUP 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_YIELD_SIZE_GROUP : int 
	{  
  
		IxDIVISION				= 0,		
		IxFACTORY				= 1,		
		IxITEM_CD				= 2,		
		IxITEM_NAME				= 3,			
		IxSPEC_CD				= 4,		
		IxCS_SIZE_FROM   	=  5,		
		IxCS_SIZE_TO		    =  6,		
		IxREMARKS				= 7,		
		IxCBD_CURRENCY		= 8,		
		IxCBD_PRICE			= 9,		
		IxWEIGHT					= 10,	
		IxCT_BOX_QTY			= 11,	
		IxSEASON					= 12,	
		IxCUST_CD				= 13,	
		IxCUST_NAME			= 14,	
		IxFACTORY_KEY			= 15, 
		IxITEM_CD_KEY			= 16,
 
		IxCS_SIZE_START		= 17,

	}  




	/// <summary> 
	/// TBSBC_FORMULAN_YIELD  테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_FORMULAN_YIELD : int
	{

		
		lxMAXCT		= 43,	// 인덱스 COUNT

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
		lxSTYLE_ITEM_DIV    = 25,	
		lxCOMMON_YN		    = 26,	
		lxSHIP_YN			= 27,		
		lxPUR_SHIP_YN	    = 28,	
		lxPUR_IMPORT_YN		= 29,		
		lxPUR_LOCAL_YN	    = 30,	
		lxPROD_YN			= 31,	
		lxPROD_OP_CD		= 32,	
		lxPROD_SEMI_GOOD_CD = 33,	
		lxOUISIDE_IN_YN		= 34,	
		lxOUTSIDE_OUT_YN	= 35,
		lxSHIP_LOSS_RATE	= 36,
		lxPUR_LOSS_RATE  	= 37,
		lxPROD_LOSS_RATE	= 38,
		lxCOMPONENT_SEQ       = 39,
		lxPST_YN            = 40,
		lxGENDER            = 41,	
		lxYIELD_M           = 42,
		lxCOL_ORDER         = 43   


	}			



    /// <summary> 
	/// SQC_LAB_SPEC 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_FOMULAN_MUTI : int
	{ 
		IxMaxCt   = 12,
		IxFLAG =  1,
		IxFACTORY =  2,
		IxSEQ     =  3,
		IxFORMULA_YEAR =  4,
		IxSEASON_CD =  5,
		IxMODEL_CD =  6,
		IxSTYLE_CD =  7,
		lxSTYLE_NAME = 8, 
		IxMCS_CD =  9,
		IxMCS_COLOR_CD =  10,
		IxMCS_NAME =  11,
		IxMCS_COLORNAME =  12,
		IxJOB_YN =  13,

    }



	/// <summary> 
	/// SBC_FORMULAN_COPY 테이블 인덱스 Enum 
	/// </summary> 
	public enum TBSBC_FORMULAN_COPY : int
	{
		lxMAXCT		       = 35,	// 인덱스 COUNT
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
		lxMCS_COLOR_CD     = 21,
		lxSTYLE_ITEM_DIV       = 22,  
		lxCOMMON_YN		       = 23, 
		lxSHIP_Y 		       = 24,
		lxPUR_SHIP_YN	       = 25,
		lxPUR_IMPORT_YN	       = 26,
		lxPUR_LOCAL_YN	       = 27,
		lxPROD_YN		       = 28,
		lxPROD_OP_CD		   = 29,
		lxPROD_SEMI_GOOD_CD    = 30,
		lxOUISIDE_IN_YN	       = 31,
		lxOUTSIDE_OUT_YN	   = 32, 
		lxSHIP_LOSS_RATE	   = 33,
		lxPUR_LOSS_RATE	       = 34,
		lxPROD_LOSS_RATE	   = 35,

	}






    #endregion

    #region 공통


    public enum TBSBS_SHIPPING_SIZE : int
    {
        IxMaxCt = 3,	// 인덱스 Count
        IxKIND = 1, 	//   : ()
        IxTOTAL = 2, 	//   : ()
        IxCOL = 3 		//   : ()
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





    #endregion


}
