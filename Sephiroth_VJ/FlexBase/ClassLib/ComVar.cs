using System;
using System.Data;
using System.Drawing;
using System.Data.OracleClient;


namespace FlexBase.ClassLib
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
 


		#region 이재민 추가

		// 공통사용
		public const string Insert = "I";
		public const string Update = "U";
		public const string Delete = "D";

		
		// SHIPPING MATERIAL
		public const string Shipping	= "Shipping";
		public const string Production	= "Production";
		public const string Import		= "Import";
		public const string Local		= "Local";

		// SHIPPING LIST
		public const string Normal	= "1";
		public const string Upper	= "1";
		public const string Bottom	= "2";
		public const string Sole	= "2";
		public const string Yes		= "Y";
		public const string No		= "N"; 

		
		// SHIPPING LIST - cell type
		public const string TextCell	    = "TextCellType";
		public const string ComboBoxCell    = "ComboBoxCellType";
		public const string SSPComboBoxCell = "SSPComboBoxCellType";
 

		// SHIPPING LIST - cell title
		public const string Vendor		 = "Vendor";
		public const string User		 = "User";

		// SHIPPING LIST - status
		public const string Save		 = "Save";
		public const string Packing		 = "Packing";
		public const string Barcode		 = "Barcode";

		// INCOMING / OUTGOING SCAN 
		public const string Incoming = "1";
		public const string Outgoing = "2";
		public const string NotScan = "Not Scan";
		public const string PreScan = "Pre Scan";
		public const string Scan	= "Scan";

		// 오라클 금칙 문자 정의
		public static string[] SpecialCharacter = new string[]{"\"", "'","|"};
 

		// Object type parameter popup
		public static object[] Parameter_PopUp_Object  = null;
		public static object[] Parameter_PopUp_Object2 = null;





		// color set - level
		public static Color DarkBlue	= Color.FromArgb(229, 228, 242);
		public static Color DarkBlue2	= Color.FromArgb(164, 190, 217);
		public static Color RightBlue	= Color.FromArgb(240, 247, 255);
		public static Color RightYellow	= Color.FromArgb(250, 251, 230);
		public static Color Default		= Color.FromArgb(255, 255, 255); 
		public static Color RightPink1	= Color.FromArgb(248, 224, 255);
		public static Color RightPink2	= Color.FromArgb(252, 240, 255);
		public static Color RightRed	= Color.FromArgb(253, 38, 146);

		// color set - forecolor
		public static Color Clr_Proc1 = Color.FromArgb(64, 128, 128);
		public static Color Clr_Proc2 = Color.FromArgb(202, 101, 0);
		public static Color Clr_Complete = Color.FromArgb(158, 158, 158);
        	
		// user message
		public static string complete = "process complete!!";


		public enum ShipTypeEnum : int
		{
			Upper				= 0,
			Sole				= 1,
			Normal				= 1,
			Shortage			= 2,
			MachineSparePart	= 3,
			Request				= 4
		};


		// SHIPPING REQUEST - merge, partial
		public const string Merge = "M";
		public const string Partial = "P";




		// SCAN MANAGER
		public enum OutScanTypeEnum : int
		{
			Vessel					= 10,
			ContainerDoorToDoor		= 20,
			AirFlight				= 30,
			HandCarry				= 40,
			DoorToDoor				= 50,
			Warehouse				= 60,
			Vendor					= 70
		};

		public const string REQUEST		= "REQUEST";
		public const string PURCHASE	= "PURCHASE";
		public const string INCOMING	= "INCOMING";
		public const string SHIPPING	= "SHIPPING";
		public const string OUTGOING	= "OUTGOING";
		public const string TRADE		= "TRADE"; 
		public const string QC_REQUEST	= "QC_REQ_NEW";	
		public const string QC_TEST		= "QC_TEST";	


		public const int Validate_Search	= 1;
		public const int Validate_Save		= 2;
		public const int Validate_Delete	= 3;
		public const int Validate_Confirm	= 4;
		public const int Validate_Print		= 5;


		public enum MRPProcessNum : int
		{
			ShippingSectionCreate = 0,
			Master			= 1,
			OrderCheck		= 2,
			MPSCheck		= 3,
			MPSSizeCheck	= 4,
			ShippingAdjust	= 5,
			ShippingConfirm = 6,
			YieldCheck		= 7,
			MRPAdjust		= 8
		};

		public enum MRPButtonEnum : int
		{
			Tbtn_Save = 0,
			Tbtn_Confirm = 1
		};

		public const int status_default = 20, status_check = 10, status_select = 0; 

		public const string Status_CONFIRM = "CONFIRM";
		public const string Status_SAVE = "SAVE";


		#endregion  

		#region 안상민 추가

		/// <summary>
		/// yearCode : Year Code
		/// </summary>
		public const string yearCode = "SBC11";

		/// <summary>
		/// seasonCode : Season Code
		/// </summary>
		public const string seasonCode = "SEM15";

		/// <summary>
		/// categoryCode : category Code
		/// </summary>
		public const string categoryCode = "MD02";
	
		/// <summary>
		/// ynCode : Y/N Code
		/// </summary>			
		public const string ynCode = "SBC00";

		/// <summary>
		/// phTypeCode : phType Code 
		/// </summary>
		public const string phTypeCode = "MD04";

		/// <summary>
		/// genderCode : Gender Code 
		/// </summary>
		public const string genderCode = "SEM01";



		public const string Dept		 = "Dept";

		// PURCHASE ORDER - cell title
		public const string Date		 = "Date";



		#endregion

		#region 김미영 추가

		/// <summary>
		/// Gender , Presto 구분
		/// </summary>
		public static string DivGen = ""; //Gen Division
		public static string DivPst = ""; //Presto Division
		public static string DivStyleNm = ""; //Style명


		/// <summary>
		/// FirstRow  : F/O
		/// </summary>
		public const string ConsFirstRow= "F";
		public const string ConsOtherRow= "O";
		public const string ConsTrue  = "Y";
		public const string ConsFalse= "N";
		public const string ConsBaseStyle= "000000000";
		public const string ConsBaseYear = "2006";
		public const string ConsBaseFormula = "B";
		


		#endregion

		#region 정환정 추가

		
		/// <summary>
		/// Yield_CurrentDIV : Yield 팝업창 띄울때 현재 선택 상태 구분자
		/// </summary>
		public enum Yield_CurrentDIV : int
		{	
			AddCmp = 0,		   // add component
			AddTemplate = 1,   // add template
			Modify = 2,        // modify
			AddExcel = 3,      // excel 로부터 신규로 생성

		}

 


		#endregion

		#region 박지수 추가

		// Process Closing LIST
		public const string Stock		= "1";
		public const string Account	    = "2";
		public const string Remainder	= "3";

		// Closing Term LIST
		public const string Month		= "1";
		public const string Day			= "2";


		




		#endregion

	}
}
