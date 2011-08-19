using System;
using System.Windows.Forms;
using System.Reflection;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;

namespace ERP.LogBase
{
	/// <summary>
	/// ClassLog�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ClassLog
	{
		public ClassLog()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
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
				//User Data ����
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

				//2. ���� �ڵ忡 ���� �׸��� ����, ���� �� ����
				Select_Depart();


                //3. ��Ÿ �Ķ���� info
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
		/// Select_Depart : ���� �ڵ忡 ���� �׸��� ����, ���� �� ����
		/// </summary>
		public static void Select_Depart()
		{
			//���� �ڵ忡 �۾� Form �̸�
			if(ClassLib.ComVar.This_JobCdoe == "P")
			{
				ClassLib.ComVar.This_Form = "FlexAPS.MainWnd";

				//�׸��� ���� ����
				ClassLib.ComVar.GridAlternate_Color  = Color.FromArgb(240, 244, 250);     //��ȣ �ݺ� �÷�
				ClassLib.ComVar.GridDarkFixed_Color  = Color.FromArgb(122, 160, 200);     //Modify�� �׸��� ��� �÷�
				ClassLib.ComVar.GridLightFixed_Color = Color.FromArgb(135, 179, 234);    //Search�� �׸��� ��� �÷�
				ClassLib.ComVar.GridHigh_Color = Color.FromArgb(193, 221, 253);          //���ý� �ο� �÷�
				ClassLib.ComVar.GridCol0_Color = Color.FromArgb(193, 221, 253);          //�÷� 0 �÷�
				ClassLib.ComVar.GridForeColor  = Color.White;                             //���ڻ�
				ClassLib.ComVar.GridEmptyColor = Color.White;
			}
			else if(ClassLib.ComVar.This_JobCdoe == "E")
			{
				ClassLib.ComVar.This_Form = "FlexOrder.MainWnd"; 

				//�׸��� ���� ����
				ClassLib.ComVar.GridAlternate_Color  = Color.FromArgb(245, 248, 232);     //��ȣ �ݺ� �÷�
				ClassLib.ComVar.GridDarkFixed_Color  = Color.FromArgb(255,255,157);   //Modify�� �׸��� ��� �÷�
				ClassLib.ComVar.GridLightFixed_Color = Color.FromArgb(255,255,157);    //Search�� �׸��� ��� �÷�
				ClassLib.ComVar.GridHigh_Color = Color.FromArgb(236, 247, 187);          //���ý� �ο� �÷�
				ClassLib.ComVar.GridCol0_Color = Color.FromArgb(236, 247, 187);          //�÷� 0 �÷�
				ClassLib.ComVar.GridForeColor  = Color.Black;                             //���ڻ�
				ClassLib.ComVar.GridEmptyColor = Color.White; 

			}
			else if(ClassLib.ComVar.This_JobCdoe == "B")
			{
				ClassLib.ComVar.This_Form = "FlexPurchase.MainWnd";

				//�׸��� ���� ����
				ClassLib.ComVar.GridAlternate_Color  = Color.FromArgb(240, 244, 250);     //��ȣ �ݺ� �÷�
				ClassLib.ComVar.GridDarkFixed_Color  = Color.FromArgb(122, 160, 200);     //Modify�� �׸��� ��� �÷�
				ClassLib.ComVar.GridLightFixed_Color = Color.FromArgb(135, 179, 234);    //Search�� �׸��� ��� �÷�
				ClassLib.ComVar.GridHigh_Color = Color.FromArgb(193, 221, 253);          //���ý� �ο� �÷�
				ClassLib.ComVar.GridCol0_Color = Color.FromArgb(193, 221, 253);          //�÷� 0 �÷�
				ClassLib.ComVar.GridForeColor  = Color.White;                             //���ڻ�
				ClassLib.ComVar.GridEmptyColor = Color.White;

			}
			else if(ClassLib.ComVar.This_JobCdoe == "A")
			{
				ClassLib.ComVar.This_Form = "FlexEIS.MainWnd";

				//�׸��� ���� ����
				ClassLib.ComVar.GridAlternate_Color  = Color.FromArgb(250, 248, 240);     //��ȣ �ݺ� �÷�
				ClassLib.ComVar.GridDarkFixed_Color  = Color.FromArgb(233, 227, 154);     //Modify�� �׸��� ��� �÷�
				ClassLib.ComVar.GridLightFixed_Color = Color.FromArgb(244, 240, 184);    //Search�� �׸��� ��� �÷�
				ClassLib.ComVar.GridHigh_Color = Color.FromArgb(234, 227, 158);          //���ý� �ο� �÷�
				ClassLib.ComVar.GridCol0_Color = Color.FromArgb(233, 227, 154);          //�÷� 0 �÷�
				ClassLib.ComVar.GridForeColor  = Color.Black;                             //���ڻ�
				ClassLib.ComVar.GridEmptyColor = Color.White;

			}
			else
			{
				ClassLib.ComVar.This_Form = "ERP.MainWnd";

				//�׸��� ���� ����
				ClassLib.ComVar.GridAlternate_Color  = Color.FromArgb(240, 244, 250);     //��ȣ �ݺ� �÷�
				ClassLib.ComVar.GridDarkFixed_Color  = Color.FromArgb(122, 160, 200);     //Modify�� �׸��� ��� �÷�
				ClassLib.ComVar.GridLightFixed_Color = Color.FromArgb(135, 179, 234);    //Search�� �׸��� ��� �÷�
				ClassLib.ComVar.GridHigh_Color = Color.FromArgb(193, 221, 253);          //���ý� �ο� �÷�
				ClassLib.ComVar.GridCol0_Color = Color.FromArgb(193, 221, 253);          //�÷� 0 �÷�
				ClassLib.ComVar.GridForeColor  = Color.White;                             //���ڻ�
				ClassLib.ComVar.GridEmptyColor = Color.White;

			}
		}


		/// <summary>
		/// Select_Para : �ý��� �Ķ����
		/// </summary>
		/// <returns></returns>
		private static DataTable Select_Para()
		{
			COM.OraDB oraDB = new COM.OraDB();

			string Proc_Name = "PKG_SPS_USER.SELECT_SPC_PARA";

			//// DB���� ��� Dictionary ����
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
		/// Select_User_Data_Info : ����� ���� ���� ��������
		/// </summary>
		/// <param name="arg_factory">�����ڵ�</param>
		/// <param name="arg_user_id">����� ID</param>
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
		/// Select_Spc_Data_From : Date Type ���� ���� ����
		/// </summary>
		/// <param name="arg_factory">�����ڵ�</param>
		/// <returns>DataTable</returns>
		private static DataTable Select_Spc_Data_From(string arg_factory)
		{

			COM.OraDB oraDB = new COM.OraDB();
			string Proc_Name = "PKG_SPC_DATETYPE.SELECT_SPC_DATE_FROM";

			//// DB���� ��� Dictionary ����
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

