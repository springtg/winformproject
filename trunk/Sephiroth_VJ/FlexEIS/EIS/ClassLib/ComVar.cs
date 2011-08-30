using System;

namespace FlexEIS.ClassLib
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
        /// subtotal 레벨 추가
        /// </summary>
        public static System.Drawing.Color ClrSubTotal4 = System.Drawing.Color.FromArgb(249, 249, 251);


        /// <summary>
        /// CxEISMatCostOutType : PRODUCTION, OTHERS
        /// </summary>
        public const string CxEISMatCostOutType = "EIS_MAT_14";




	}
}
