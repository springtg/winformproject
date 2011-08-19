using System;

namespace ERP.ClassLib
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
		/// 
		/// </summary>
		public static ERP.MainWnd arg_form;

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


		//간단한 날짜 저장(로그인 직후 바로 선언)
		//		public static string setedDate="yy-MM-dd";
		//		public static string setedSign = "-";
		//		public static string userID = "admin";
		public static string inandup = "U";
		public static string remark;


		/// <summary>
		/// CxSearchHome : 시스템 관련 Search 코드
		/// </summary>
		public const string CxSearchHome = "PS12";




//		#region 메시지 박스 코드
//
//		/// <summary>
//		/// CxEndSearch : 정상적으로 조회 하였습니다.
//		/// </summary>
//		public const string MgsEndSearch = "11";
//
//
//		/// <summary>
//		/// CxEndSave : 정상적으로 저장 하였습니다.
//		/// </summary>
//		public const string MgsEndSave = "12";
//
//
//		/// <summary>
//		/// CxEndDelete : 정상적으로 삭제 하였습니다.
//		/// </summary>
//		public const string MgsEndDelete = "13";
//
//
//		/// <summary>
//		/// CxEndRun : 정상적으로 실행 하였습니다.
//		/// </summary>
//		public const string MgsEndRun = "14";
//
//
//		/// <summary>
//		/// CxEndOK : 정상적으로 확정 하였습니다.
//		/// </summary>
//		public const string MgsEndOK = "15";
//
//
//		/// <summary>
//		/// CxEndSend : 정상적으로 전송 하였습니다.
//		/// </summary>
//		public const string MgsEndSend = "16";
//
//
//
//
//
//		/// <summary>
//		/// CxChooseSearch : 조회 하시겠습니까?
//		/// </summary>
//		public const string MgsChooseSearch = "31";
//
//
//		/// <summary>
//		/// CxChooseSave : 저장 하시겠습니까?
//		/// </summary>
//		public const string MgsChooseSave = "32";
//
//
//		/// <summary>
//		/// ChooseDelete : 삭제 하시겠습니까?
//		/// </summary>
//		public const string MgsChooseDelete = "33";
//
//
//		/// <summary>
//		/// ChooseRun : 실행 하시겠습니까?
//		/// </summary>
//		public const string MgsChooseRun = "34";
//
//
//		/// <summary>
//		/// ChooseOK : 확정 하시겠습니까?
//		/// </summary>
//		public const string MgsChooseOK = "35";
//
//
//		/// <summary>
//		/// ChooseExit : 종료 하시겠습니까?
//		/// </summary>
//		public const string MgsChooseExit = "36";
//
//
//
//		/// <summary>
//		/// CxDoNotSearch : 조회 할 수 없습니다.
//		/// </summary>
//		public const string MgsDoNotSearch = "41";
//
//
//		/// <summary>
//		/// CxDoNotSave : 저장 할 수 없습니다.
//		/// </summary>
//		public const string MgsDoNotSave = "42";
//
//
//		/// <summary>
//		/// CxDoNotDelete : 삭제 할 수 없습니다.
//		/// </summary>
//		public const string MgsDoNotDelete = "43";
//
//
//		/// <summary>
//		/// CxDoNotRun : 실행 할 수 없습니다.
//		/// </summary>
//		public const string MgsDoNotRun = "44";
//
//
//		/// <summary>
//		/// CxDoNotSelect : 선택 할 수 없습니다.
//		/// </summary>
//		//public const string CxDoNotSelect = "45";
//
//
//		/// <summary>
//		/// CxDoNotSend : 전송 할 수 없습니다.
//		/// </summary>
//		//public const string CxDoNotSend = "46";
//
//
//
//		/// <summary>
//		/// CxChooseSelect : 선택 하시겠습니까?
//		/// </summary>
//		public const string MgsChooseSelect = "51";
//
//
//
//		/// <summary>
//		/// CxWrongInput : 잘못 입력 하였습니다.
//		/// </summary>
//		public const string MgsWrongInput = "91";
//
//
//
//		/// <summary>
//		/// CxNotnoHaveData : 원하시는 데이터가 없습니다.
//		/// </summary>
//		public const string MgsNotnoHaveData = "92";
//
//
//		#endregion
	}
}
