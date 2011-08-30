using System;
using System.Drawing;

namespace FlexMold.ClassLib
{
	/// <summary>
	/// ComVar에 대한 요약 설명입니다.
	/// </summary>
	public class ComVar : COM.ComVar
	{
		public ComVar()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		/// <summary>
		/// FormClick_Flag : 다른폼을 열때, 파라미터로 넘겨서 값을 세팅하고자 할때
		/// </summary>
		public static bool FormClick_Flag;


		/// <summary>
		/// MenuClick_Flag : 메인메뉴에서 호출했는지 여부
		/// </summary>
		public static bool MenuClick_Flag;


		
		/// <summary>
		/// RoutLinkType : 라우팅 링크 타입
		/// </summary>
		public const string RoutLinkType = "ROUT";

		/// <summary>
		/// BOMLinkType : BOM 링크 타입
		/// </summary>
		public const string BOMLinkType = "BOM_F";


		/// <summary>
		/// Rout_Type : default 라우팅 타입 
		/// </summary> 
		public const string Rout_Type = "MAIN";
		 
		/// <summary>
		/// LeadTimeCode : 리드타임 코드
		/// </summary>
		public const string LeadTimeCode = "COMMON";

		/// <summary>
		/// Form_PO_Lot_Size 뜰때 부모 폼 
		/// </summary>
		public enum FormLoadDIV : int
		{	
			Insert =0,				// 초기 입력할때
			Modify= 1,				// 이후 수정할때
		} 

		/// <summary>
		/// CalType : 공통카렌터 타입
		/// </summary>
		public const string CalType = "COMMON";


		/// <summary>
		/// ShiftType : 공통교대 타입 : 1교대 기준
		/// </summary>
		public const string ShiftType = "COMMON";
 
 
		/// <summary>
		/// FormLoadDIV_LOT : 호출되는 부모 폼 구분
		/// </summary>
		public enum FormLoadDIV_LOT : int
		{	
			FromLOT =0,				// LOT 생성 폼에서 MPS로 바로 넘길때 호출
			FromMPS= 1,				// MPS 상에서 라인 이동할때 호출
			FromMPSMove =2,          // MPS 상에서DaySeq 이동할때 호출
		}

 
		/// <summary>
		/// BeanSize : LOT BeanSize
		/// </summary>
		public const string BeanSize = "12";

 
//		/// <summary>
//		/// CxMoldType : Mold Type Code
//		/// </summary>
//		public const string CxMoldType = "MD03";
 

		/// <summary>
		/// CxMoldCondition : Mold Search Condition
		/// </summary>
		public const string CxMoldCondition = "MD04";

		/// <summary>
		/// FactoryBomCd : 공장 BOM Code
		/// </summary>
		public const string FactoryBomCd = "BUFPEPU001";
 
		/// <summary>
		/// StdOpCd : 기준공정
		/// </summary>
		public const string StdOpCd = "UPS";

		public static string This_Partcode ="";		

//		public static string This_Dept = "";

		/// <summary>
		/// FormLoadDIV_OA : 호출되는 부모 폼 구분
		/// </summary>
		public enum FormLoadDIV_OA : int
		{	
			FromLOT =0,				// LOT 생성 폼에서 OA 창 호출
			FromDirect =1,			// 메뉴에서 바로 OA 창 호출
		}




		/// <summary>
		/// StdFontSize : 보통 그리드 글자 크기
		/// </summary>
		public const string StdFontSize = "9";


		//mps에 의해서 순차적으로 열리는 폼들
		//중복 제거와 일괄 close를 위해서 전역변수로 선언
//		public static FlexAPS.ProdPlan.Form_PO_LOTDailySize FormDailySize = null;
//		public static FlexAPS.ProdPlan.Form_PO_LOTDailyMini FormDailyMini = null;
//		public static FlexAPS.ProdSheet.Form_PD_LOTDaily_MiniSize_TS FormDailyTS = null;
 

//		public static FlexAPS.ProdPlan.Z_Form_PO_LOTDailySize Z_FormDailySize = null; 
//		public static FlexAPS.ProdPlan.Z_Form_PO_LOTDailyMini Z_FormDailyMini = null;
//		public static FlexAPS.ProdSheet.Z_Form_PD_LOTDaily_MiniSize_TS Z_FormDailyTS = null;
 

		/// <summary>
		/// FormLoadDIV_OA : MPS 에서 LOT action 구분자
		/// </summary>
		public enum MPS_LOT_Action : int
		{	
			Divide =0,			// Divide
			Merge =1,			// Merge
		}


        #region 몰드 관련 변수 from 베트남


		public static int _startmouse=0;
		public static int _endmouse=0;
		public static string [] _mold_code; 
		public static string _mold_cd ="";
		
		public static string _mold="";
		public static string _qty;

		public static string This_Computer = "" ;
		public static string This_Action ;
		public static string This_Win_ID ;
		public static string This_PGM = "MOLD" ;
		public static string This_Packages;
		public static string This_REF1 = "";
		public static string This_REF2 = "";
		public static string This_REF3 = "";
		public static string This_User = "admin";

		public static string This_Err = "";

		public static string div = "";

		public static string pgm = "";

		public static string act = "";

		public static string Click_date = "";

		public static string Click_use = "";

		#endregion


		public const string Vendor = "Vendor";


	}
}
