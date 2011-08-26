using System;
using System.Data;
using System.Drawing;
using System.Data.OracleClient;


namespace FlexVJ_Common.ClassLib
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

        // 공통사용
        public const string Insert = "I";
        public const string Update = "U";
        public const string Delete = "D";
	}
}
