using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 

namespace ERP.ClassLib
{
	/// <summary>
	/// ComFuntion에 대한 요약 설명입니다.
	/// </summary>
	public class ComFunction : COM.ComFunction
	{
		public ComFunction()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}



		
		/// <summary>
		/// Select_SPS_USER_ALL : User List  -  전체 리스트에서 검색
		/// </summary>
		/// <param name="arg_user_id"></param>
		/// <returns>DataTable</returns>
		public static DataTable Select_SPS_USER_ALL(string arg_user_id)
		{
			COM.OraDB oraDB = new COM.OraDB();

			string Proc_Name = "PKG_SBC_COMMON.SELECT_SPS_USER_ALL";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_USER_ID";
			oraDB.Parameter_Name[1] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_user_id;
			oraDB.Parameter_Values[1] = "";

			oraDB.Add_Select_Parameter(false);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}



	}
}
