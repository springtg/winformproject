using System;
using System.Drawing;

namespace FlexOrder.ClassLib
{
	/// <summary>
	/// ComVar�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ComVar : COM.ComVar
	{
		public ComVar()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}

		/// <summary>
		/// FormClick_Flag : �ٸ����� ����, �Ķ���ͷ� �Ѱܼ� ���� �����ϰ��� �Ҷ�
		/// </summary>
		public static bool FormClick_Flag;

		/// <summary>
		/// MenuClick_Flag : ���θ޴����� ȣ���ߴ��� ����
		/// </summary>
		public static bool MenuClick_Flag;
		
		/// <summary>
		/// Division_flag : insert, update ���� flag
		/// </summary>
		public const string Divflag_NEW = "I"; //�ű�
		public const string Divflag_CHG = "U"; //����
		public const string Divflag_ADD = "A"; //�߰�
		public const string Divflag_ERR = "E"; //ERROR

		public const string Divflag_IH = "I1"; //Head, Insert
		public const string Divflag_ID = "I2"; //Detail, Insert
		public const string Divflag_UH = "U1"; //Head, Update
		public const string Divflag_UD = "U2"; //Detail, Update

		/// <summary>
		/// Sub row ���� flag
		/// </summary>
		public const string FlagPlus  = "P"; //[+] flag
		public const string FlagMinus = "M"; //[-] flag

		/// <summary>
		/// Gender , Presto ����
		/// </summary>
		public static string DivGen = ""; //Gen Division
		public static string DivPst = ""; //Presto Division
		public static string DivStyleNm = ""; //Style��

		/// <summary>
		///  OBS OA ����/���� �ڷ� ����
		/// </summary>
		public static string DivBef = "B"; //Gen Division
		public static string DivAft = "A"; //Gen Division

	}
}
