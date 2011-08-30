using System;
using System.Drawing;

namespace FlexMold.ClassLib
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
		/// RoutLinkType : ����� ��ũ Ÿ��
		/// </summary>
		public const string RoutLinkType = "ROUT";

		/// <summary>
		/// BOMLinkType : BOM ��ũ Ÿ��
		/// </summary>
		public const string BOMLinkType = "BOM_F";


		/// <summary>
		/// Rout_Type : default ����� Ÿ�� 
		/// </summary> 
		public const string Rout_Type = "MAIN";
		 
		/// <summary>
		/// LeadTimeCode : ����Ÿ�� �ڵ�
		/// </summary>
		public const string LeadTimeCode = "COMMON";

		/// <summary>
		/// Form_PO_Lot_Size �㶧 �θ� �� 
		/// </summary>
		public enum FormLoadDIV : int
		{	
			Insert =0,				// �ʱ� �Է��Ҷ�
			Modify= 1,				// ���� �����Ҷ�
		} 

		/// <summary>
		/// CalType : ����ī���� Ÿ��
		/// </summary>
		public const string CalType = "COMMON";


		/// <summary>
		/// ShiftType : ���뱳�� Ÿ�� : 1���� ����
		/// </summary>
		public const string ShiftType = "COMMON";
 
 
		/// <summary>
		/// FormLoadDIV_LOT : ȣ��Ǵ� �θ� �� ����
		/// </summary>
		public enum FormLoadDIV_LOT : int
		{	
			FromLOT =0,				// LOT ���� ������ MPS�� �ٷ� �ѱ涧 ȣ��
			FromMPS= 1,				// MPS �󿡼� ���� �̵��Ҷ� ȣ��
			FromMPSMove =2,          // MPS �󿡼�DaySeq �̵��Ҷ� ȣ��
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
		/// FactoryBomCd : ���� BOM Code
		/// </summary>
		public const string FactoryBomCd = "BUFPEPU001";
 
		/// <summary>
		/// StdOpCd : ���ذ���
		/// </summary>
		public const string StdOpCd = "UPS";

		public static string This_Partcode ="";		

//		public static string This_Dept = "";

		/// <summary>
		/// FormLoadDIV_OA : ȣ��Ǵ� �θ� �� ����
		/// </summary>
		public enum FormLoadDIV_OA : int
		{	
			FromLOT =0,				// LOT ���� ������ OA â ȣ��
			FromDirect =1,			// �޴����� �ٷ� OA â ȣ��
		}




		/// <summary>
		/// StdFontSize : ���� �׸��� ���� ũ��
		/// </summary>
		public const string StdFontSize = "9";


		//mps�� ���ؼ� ���������� ������ ����
		//�ߺ� ���ſ� �ϰ� close�� ���ؼ� ���������� ����
//		public static FlexAPS.ProdPlan.Form_PO_LOTDailySize FormDailySize = null;
//		public static FlexAPS.ProdPlan.Form_PO_LOTDailyMini FormDailyMini = null;
//		public static FlexAPS.ProdSheet.Form_PD_LOTDaily_MiniSize_TS FormDailyTS = null;
 

//		public static FlexAPS.ProdPlan.Z_Form_PO_LOTDailySize Z_FormDailySize = null; 
//		public static FlexAPS.ProdPlan.Z_Form_PO_LOTDailyMini Z_FormDailyMini = null;
//		public static FlexAPS.ProdSheet.Z_Form_PD_LOTDaily_MiniSize_TS Z_FormDailyTS = null;
 

		/// <summary>
		/// FormLoadDIV_OA : MPS ���� LOT action ������
		/// </summary>
		public enum MPS_LOT_Action : int
		{	
			Divide =0,			// Divide
			Merge =1,			// Merge
		}


        #region ���� ���� ���� from ��Ʈ��


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
