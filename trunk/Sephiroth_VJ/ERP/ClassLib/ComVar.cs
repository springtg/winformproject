using System;

namespace ERP.ClassLib
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
		/// 
		/// </summary>
		public static ERP.MainWnd arg_form;

		/// <summary>
		/// FormClick_Flag : �ٸ����� ����, �Ķ���ͷ� �Ѱܼ� ���� �����ϰ��� �Ҷ�
		/// </summary>
		public static bool FormClick_Flag;


		/// <summary>
		/// MenuClick_Flag : ���θ޴����� ȣ���ߴ��� ����
		/// </summary>
		public static bool MenuClick_Flag;


		/// <summary>
		/// RoutLinkType : ����� ��ũ Ÿ��
		/// </summary>
		public const string RoutLinkType = "ROUT";


		//������ ��¥ ����(�α��� ���� �ٷ� ����)
		//		public static string setedDate="yy-MM-dd";
		//		public static string setedSign = "-";
		//		public static string userID = "admin";
		public static string inandup = "U";
		public static string remark;


		/// <summary>
		/// CxSearchHome : �ý��� ���� Search �ڵ�
		/// </summary>
		public const string CxSearchHome = "PS12";




//		#region �޽��� �ڽ� �ڵ�
//
//		/// <summary>
//		/// CxEndSearch : ���������� ��ȸ �Ͽ����ϴ�.
//		/// </summary>
//		public const string MgsEndSearch = "11";
//
//
//		/// <summary>
//		/// CxEndSave : ���������� ���� �Ͽ����ϴ�.
//		/// </summary>
//		public const string MgsEndSave = "12";
//
//
//		/// <summary>
//		/// CxEndDelete : ���������� ���� �Ͽ����ϴ�.
//		/// </summary>
//		public const string MgsEndDelete = "13";
//
//
//		/// <summary>
//		/// CxEndRun : ���������� ���� �Ͽ����ϴ�.
//		/// </summary>
//		public const string MgsEndRun = "14";
//
//
//		/// <summary>
//		/// CxEndOK : ���������� Ȯ�� �Ͽ����ϴ�.
//		/// </summary>
//		public const string MgsEndOK = "15";
//
//
//		/// <summary>
//		/// CxEndSend : ���������� ���� �Ͽ����ϴ�.
//		/// </summary>
//		public const string MgsEndSend = "16";
//
//
//
//
//
//		/// <summary>
//		/// CxChooseSearch : ��ȸ �Ͻðڽ��ϱ�?
//		/// </summary>
//		public const string MgsChooseSearch = "31";
//
//
//		/// <summary>
//		/// CxChooseSave : ���� �Ͻðڽ��ϱ�?
//		/// </summary>
//		public const string MgsChooseSave = "32";
//
//
//		/// <summary>
//		/// ChooseDelete : ���� �Ͻðڽ��ϱ�?
//		/// </summary>
//		public const string MgsChooseDelete = "33";
//
//
//		/// <summary>
//		/// ChooseRun : ���� �Ͻðڽ��ϱ�?
//		/// </summary>
//		public const string MgsChooseRun = "34";
//
//
//		/// <summary>
//		/// ChooseOK : Ȯ�� �Ͻðڽ��ϱ�?
//		/// </summary>
//		public const string MgsChooseOK = "35";
//
//
//		/// <summary>
//		/// ChooseExit : ���� �Ͻðڽ��ϱ�?
//		/// </summary>
//		public const string MgsChooseExit = "36";
//
//
//
//		/// <summary>
//		/// CxDoNotSearch : ��ȸ �� �� �����ϴ�.
//		/// </summary>
//		public const string MgsDoNotSearch = "41";
//
//
//		/// <summary>
//		/// CxDoNotSave : ���� �� �� �����ϴ�.
//		/// </summary>
//		public const string MgsDoNotSave = "42";
//
//
//		/// <summary>
//		/// CxDoNotDelete : ���� �� �� �����ϴ�.
//		/// </summary>
//		public const string MgsDoNotDelete = "43";
//
//
//		/// <summary>
//		/// CxDoNotRun : ���� �� �� �����ϴ�.
//		/// </summary>
//		public const string MgsDoNotRun = "44";
//
//
//		/// <summary>
//		/// CxDoNotSelect : ���� �� �� �����ϴ�.
//		/// </summary>
//		//public const string CxDoNotSelect = "45";
//
//
//		/// <summary>
//		/// CxDoNotSend : ���� �� �� �����ϴ�.
//		/// </summary>
//		//public const string CxDoNotSend = "46";
//
//
//
//		/// <summary>
//		/// CxChooseSelect : ���� �Ͻðڽ��ϱ�?
//		/// </summary>
//		public const string MgsChooseSelect = "51";
//
//
//
//		/// <summary>
//		/// CxWrongInput : �߸� �Է� �Ͽ����ϴ�.
//		/// </summary>
//		public const string MgsWrongInput = "91";
//
//
//
//		/// <summary>
//		/// CxNotnoHaveData : ���Ͻô� �����Ͱ� �����ϴ�.
//		/// </summary>
//		public const string MgsNotnoHaveData = "92";
//
//
//		#endregion
	}
}
