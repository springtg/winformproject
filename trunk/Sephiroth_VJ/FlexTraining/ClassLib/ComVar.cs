using System;
using System.Data;
using System.Drawing;
using System.Data.OracleClient;


namespace FlexTraining.ClassLib
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


		// ȯ���� ��� �ӽ÷� �߰��մϴ�.
		public static Color AirColor		= Color.Aqua;
		public static Color SilhouetteColor = Color.Magenta;
		public static Color JitColor		= Color.Brown;
		public static Color NewStyleColor	= Color.Violet;
	}
}
