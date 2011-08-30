using System;
using System.Drawing;

namespace FlexOrder.ClassLib
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
		/// Division_flag : insert, update 관련 flag
		/// </summary>
		public const string Divflag_NEW = "I"; //신규
		public const string Divflag_CHG = "U"; //변경
		public const string Divflag_ADD = "A"; //추가
		public const string Divflag_ERR = "E"; //ERROR

		public const string Divflag_IH = "I1"; //Head, Insert
		public const string Divflag_ID = "I2"; //Detail, Insert
		public const string Divflag_UH = "U1"; //Head, Update
		public const string Divflag_UD = "U2"; //Detail, Update

		/// <summary>
		/// Sub row 유무 flag
		/// </summary>
		public const string FlagPlus  = "P"; //[+] flag
		public const string FlagMinus = "M"; //[-] flag

		/// <summary>
		/// Gender , Presto 구분
		/// </summary>
		public static string DivGen = ""; //Gen Division
		public static string DivPst = ""; //Presto Division
		public static string DivStyleNm = ""; //Style명

		/// <summary>
		///  OBS OA 이전/이후 자료 구분
		/// </summary>
		public static string DivBef = "B"; //Gen Division
		public static string DivAft = "A"; //Gen Division

	}
}
