using System;
using System.Data;
using System.Drawing;
using System.Data.OracleClient;


namespace FlexCDC.ClassLib
{
	/// <summary>
	/// ComVar�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ComVar : COM.ComVar
	{
        /// <summary>
        /// BOMLinkType : BOM ��ũ Ÿ��
        /// </summary>
        public const string BOMLinkType = "BOM_F";

        /// <summary>
        /// MenuClick_Flag : ���θ޴����� ȣ���ߴ��� ����
        /// </summary>
        public static bool MenuClick_Flag;


        /// <summary>
        /// Rout_Type : default ����� Ÿ�� 
        /// </summary> 
        public const string Rout_Type = "MAIN";

        /// <summary>
        /// FormClick_Flag : �ٸ����� ����, �Ķ���ͷ� �Ѱܼ� ���� �����ϰ��� �Ҷ�
        /// </summary>
        public static bool FormClick_Flag;

        /// <summary>
        /// RoutLinkType : ����� ��ũ Ÿ��
        /// </summary>
        public const string RoutLinkType = "ROUT";
        
        public static float addf_size_X = 1;
        public static float addf_size_Y = 1;

        #region EIS Check FOB
        public const string CxEISMatFOBStatus = "EIS_MAT_12";
        #endregion

        public ComVar()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}


	}
}
