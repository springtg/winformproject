using System;
using System.Data;
using System.Drawing;
using System.Data.OracleClient;


namespace FlexCDC.ClassLib
{
	/// <summary>
	/// ComVar에 대한 요약 설명입니다.
	/// </summary>
	public class ComVar : COM.ComVar
	{
        /// <summary>
        /// BOMLinkType : BOM 링크 타입
        /// </summary>
        public const string BOMLinkType = "BOM_F";

        /// <summary>
        /// MenuClick_Flag : 메인메뉴에서 호출했는지 여부
        /// </summary>
        public static bool MenuClick_Flag;


        /// <summary>
        /// Rout_Type : default 라우팅 타입 
        /// </summary> 
        public const string Rout_Type = "MAIN";

        /// <summary>
        /// FormClick_Flag : 다른폼을 열때, 파라미터로 넘겨서 값을 세팅하고자 할때
        /// </summary>
        public static bool FormClick_Flag;

        /// <summary>
        /// RoutLinkType : 라우팅 링크 타입
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
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}


	}
}
