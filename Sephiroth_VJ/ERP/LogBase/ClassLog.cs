using System;
using System.Windows.Forms;
using System.Reflection;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;

namespace ERP.LogBase
{
	/// <summary>
	/// ClassLog에 대한 요약 설명입니다.
	/// </summary>
	public class ClassLog
	{
		public ClassLog()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}


		public static bool Login_Check(string arg_userid)
		{ 
		 	 
			DataTable dt_ret;
			

			// 1. user info
			dt_ret = Select_User_Data_Info(arg_userid);

            if (dt_ret.Rows.Count == 0)
            {
                ClassLib.ComFunction.User_Message("Have not correct User ID!");
                return false;
            }
            else if (dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxUSE_YN].ToString() == "R")
            {
                ClassLib.ComFunction.User_Message("This User ID is not grant permission!");
                return false;
            }
            else if (dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxUSE_YN].ToString() == "N")
            {
                ClassLib.ComFunction.User_Message("This User ID is not use this program!");
                return false;
            }
			else
			{  
				//User Data 세팅
				ClassLib.ComVar.This_Factory  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxFACTORY].ToString();
				ClassLib.ComVar.This_CDC_Factory  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxFACTORY].ToString();
				
				//ClassLib.ComVar.This_User	  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxUSER_ID].ToString();
				//ClassLib.ComVar.This_User = arg_userid; 
				string user_id = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxUSER_ID].ToString();
				string[] token = user_id.Split('@');
				ClassLib.ComVar.This_User = token[0];
                

				ClassLib.ComVar.This_Lang	  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxLANG_CD].ToString();
				ClassLib.ComVar.This_Admin_YN = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxADMIN_YN].ToString();
				ClassLib.ComVar.This_JobCdoe  = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxJOB_CD].ToString();
				ClassLib.ComVar.This_Line     = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxLINE_CD].ToString();
				ClassLib.ComVar.This_PowerUser_YN = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxPOWERUSER_YN].ToString(); 
				ClassLib.ComVar.This_CDCPower_Level= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxCDC_POWERLEVEL].ToString(); 
				ClassLib.ComVar.This_CDCGroup_Code= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxCDC_CDCGROUP_CD].ToString(); 
				ClassLib.ComVar.This_Dept = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxDEPT_CD].ToString();
				ClassLib.ComVar.This_InsaCd = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxINSA_CD].ToString();


				if(ClassLib.ComVar.This_Lang == "KO")
				{
					ClassLib.ComVar.This_Name = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxUSER_NAME1].ToString();
				}
				else
				{
					ClassLib.ComVar.This_Name = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPS_USER.IxUSER_NAME2].ToString();
				} 

				//2. 업무 코드에 따른 그리드 색깔, 현재 폼 설정
				Select_Depart();


                //3. 기타 파라미터 info
                //dt_ret = null; 
                //dt_ret = Select_Spc_Data_From(ClassLib.ComVar.This_Factory);

                //ClassLib.ComVar.This_SetedDateType = dt_ret.Rows[0].ItemArray[0].ToString();
                //ClassLib.ComVar.This_SetedDateSign = dt_ret.Rows[0].ItemArray[1].ToString(); 

                ClassLib.ComVar.This_SetedDateType = "yyyy-MM-dd";
                ClassLib.ComVar.This_SetedDateSign = "-"; 


				ClassLib.ComVar.This_Date     = DateTime.Now.ToString("yyyyMMdd");
				ClassLib.ComVar.This_FormDate = DateTime.Now.ToString("yyyyMMdd");
				ClassLib.ComVar.This_ToDate   = DateTime.Now.AddDays(7).ToString("yyyyMMdd"); 

				return true;
			}

		}


		/// <summary>
		/// Select_Depart : 업무 코드에 따른 그리드 색깔, 현재 폼 설정
		/// </summary>
		public static void Select_Depart()
		{
			//업무 코드에 작업 Form 이름
			if(ClassLib.ComVar.This_JobCdoe == "P")
			{
				ClassLib.ComVar.This_Form = "FlexAPS.MainWnd";

				//그리드 색깔 지정
				ClassLib.ComVar.GridAlternate_Color  = Color.FromArgb(240, 244, 250);     //상호 반복 컬러
				ClassLib.ComVar.GridDarkFixed_Color  = Color.FromArgb(122, 160, 200);     //Modify용 그리드 헤더 컬러
				ClassLib.ComVar.GridLightFixed_Color = Color.FromArgb(135, 179, 234);    //Search용 그리드 헤더 컬러
				ClassLib.ComVar.GridHigh_Color = Color.FromArgb(193, 221, 253);          //선택시 로우 컬러
				ClassLib.ComVar.GridCol0_Color = Color.FromArgb(193, 221, 253);          //컬럼 0 컬러
				ClassLib.ComVar.GridForeColor  = Color.White;                             //글자색
				ClassLib.ComVar.GridEmptyColor = Color.White;
			}
			else if(ClassLib.ComVar.This_JobCdoe == "E")
			{
				ClassLib.ComVar.This_Form = "FlexOrder.MainWnd"; 

				//그리드 색깔 지정
				ClassLib.ComVar.GridAlternate_Color  = Color.FromArgb(245, 248, 232);     //상호 반복 컬러
				ClassLib.ComVar.GridDarkFixed_Color  = Color.FromArgb(255,255,157);   //Modify용 그리드 헤더 컬러
				ClassLib.ComVar.GridLightFixed_Color = Color.FromArgb(255,255,157);    //Search용 그리드 헤더 컬러
				ClassLib.ComVar.GridHigh_Color = Color.FromArgb(236, 247, 187);          //선택시 로우 컬러
				ClassLib.ComVar.GridCol0_Color = Color.FromArgb(236, 247, 187);          //컬럼 0 컬러
				ClassLib.ComVar.GridForeColor  = Color.Black;                             //글자색
				ClassLib.ComVar.GridEmptyColor = Color.White; 

			}
			else if(ClassLib.ComVar.This_JobCdoe == "B")
			{
				ClassLib.ComVar.This_Form = "FlexPurchase.MainWnd";

				//그리드 색깔 지정
				ClassLib.ComVar.GridAlternate_Color  = Color.FromArgb(240, 244, 250);     //상호 반복 컬러
				ClassLib.ComVar.GridDarkFixed_Color  = Color.FromArgb(122, 160, 200);     //Modify용 그리드 헤더 컬러
				ClassLib.ComVar.GridLightFixed_Color = Color.FromArgb(135, 179, 234);    //Search용 그리드 헤더 컬러
				ClassLib.ComVar.GridHigh_Color = Color.FromArgb(193, 221, 253);          //선택시 로우 컬러
				ClassLib.ComVar.GridCol0_Color = Color.FromArgb(193, 221, 253);          //컬럼 0 컬러
				ClassLib.ComVar.GridForeColor  = Color.White;                             //글자색
				ClassLib.ComVar.GridEmptyColor = Color.White;

			}
			else if(ClassLib.ComVar.This_JobCdoe == "A")
			{
				ClassLib.ComVar.This_Form = "FlexEIS.MainWnd";

				//그리드 색깔 지정
				ClassLib.ComVar.GridAlternate_Color  = Color.FromArgb(250, 248, 240);     //상호 반복 컬러
				ClassLib.ComVar.GridDarkFixed_Color  = Color.FromArgb(233, 227, 154);     //Modify용 그리드 헤더 컬러
				ClassLib.ComVar.GridLightFixed_Color = Color.FromArgb(244, 240, 184);    //Search용 그리드 헤더 컬러
				ClassLib.ComVar.GridHigh_Color = Color.FromArgb(234, 227, 158);          //선택시 로우 컬러
				ClassLib.ComVar.GridCol0_Color = Color.FromArgb(233, 227, 154);          //컬럼 0 컬러
				ClassLib.ComVar.GridForeColor  = Color.Black;                             //글자색
				ClassLib.ComVar.GridEmptyColor = Color.White;

			}
			else
			{
				ClassLib.ComVar.This_Form = "ERP.MainWnd";

				//그리드 색깔 지정
				ClassLib.ComVar.GridAlternate_Color  = Color.FromArgb(240, 244, 250);     //상호 반복 컬러
				ClassLib.ComVar.GridDarkFixed_Color  = Color.FromArgb(122, 160, 200);     //Modify용 그리드 헤더 컬러
				ClassLib.ComVar.GridLightFixed_Color = Color.FromArgb(135, 179, 234);    //Search용 그리드 헤더 컬러
				ClassLib.ComVar.GridHigh_Color = Color.FromArgb(193, 221, 253);          //선택시 로우 컬러
				ClassLib.ComVar.GridCol0_Color = Color.FromArgb(193, 221, 253);          //컬럼 0 컬러
				ClassLib.ComVar.GridForeColor  = Color.White;                             //글자색
				ClassLib.ComVar.GridEmptyColor = Color.White;

			}
		}


		/// <summary>
		/// Select_Para : 시스템 파라미터
		/// </summary>
		/// <returns></returns>
		private static DataTable Select_Para()
		{
			COM.OraDB oraDB = new COM.OraDB();

			string Proc_Name = "PKG_SPS_USER.SELECT_SPC_PARA";

			//// DB에서 언어 Dictionary 추출
			oraDB.ReDim_Parameter(1);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "OUT_CURSOR"; 

			oraDB.Parameter_Type[0] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = "";

			oraDB.Add_Select_Parameter(false);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Select_User_Data_Info : 사용자 제어 정보 가져오기
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_user_id">사용자 ID</param>
		/// <returns>DataTable</returns>
		private static DataTable Select_User_Data_Info(string arg_user_id)
		{


			COM.OraDB oraDB = new COM.OraDB();

			string Proc_Name = "PKG_SPS_USER.SELECT_SPS_USER_INFO_NEW";

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

			return DS_Ret.Tables[Proc_Name];
		}

		/// <summary>
		/// Select_Spc_Data_From : Date Type 설정 가져 오기
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <returns>DataTable</returns>
		private static DataTable Select_Spc_Data_From(string arg_factory)
		{

			COM.OraDB oraDB = new COM.OraDB();
			string Proc_Name = "PKG_SPC_DATETYPE.SELECT_SPC_DATE_FROM";

			//// DB에서 언어 Dictionary 추출
			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "OUT_CURSOR"; 

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = "";

			oraDB.Add_Select_Parameter(false);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;

			return DS_Ret.Tables[Proc_Name];
		}
	}
}

