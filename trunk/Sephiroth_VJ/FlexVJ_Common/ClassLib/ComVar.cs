using System;
using System.Data;
using System.Drawing;
using System.Data.OracleClient;


namespace FlexVJ_Common.ClassLib
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

        // ������
        public const string Insert = "I";
        public const string Update = "U";
        public const string Delete = "D";
	}
}
