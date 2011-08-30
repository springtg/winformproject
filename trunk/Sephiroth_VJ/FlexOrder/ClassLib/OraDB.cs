using System;
using C1.Win.C1FlexGrid;  
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;

namespace FlexOrder.ClassLib
{
	/// <summary>
	/// OraDB�� ���� ��� �����Դϴ�.
	/// </summary>
	public class OraDB : COM.OraDB
	{
		public OraDB()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}


		/// <summary>
		/// BP ���� Style List��ȸ �ϱ�
		/// </summary>
		/// <param name="arg_fact ">�����ڵ�</param>
		/// <param name="arg_obs_id_from">OBS ID - From </param>
		/// <param name="arg_obs_id_to">OBS ID - To </param>
		/// <returns> Data Table</returns>
		public DataTable Select_BP_Style(string arg_fact, string arg_obs_id_from ,
			string arg_obs_id_to )
		{
			string strRlt;
 
			DataSet ret;
			
			this.ReDim_Parameter(4); 
            
			strRlt  = "PKG_SEM_BP_BAL.SELECT_SEM_STYLE";
			Process_Name =strRlt;
			
			this.Parameter_Name[0] = "ARG_FACTORY";
			this.Parameter_Name[1] = "ARG_OBS_ID_FROM";
			this.Parameter_Name[2] = "ARG_OBS_ID_TO";
			this.Parameter_Name[3] = "OUT_CURSOR"; 
				
			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.VarChar;
			this.Parameter_Type[2] = (int)OracleType.VarChar;
			this.Parameter_Type[3] = (int)OracleType.Cursor;
	
			this.Parameter_Values[0] = arg_fact;
			this.Parameter_Values[1] = arg_obs_id_from;
			this.Parameter_Values[2] = arg_obs_id_to;
			this.Parameter_Values[3] = "";
				
			this.Add_Select_Parameter(true); 
			ret =  Exe_Select_Procedure();
			
			if(ret == null) 
			{
				return null;
			}
			else
			{
				return ret.Tables[strRlt];
			}
				
		}



		/// <summary>
		/// OA NU ����Ʈ ��ȸ
		/// </summary>
		/// <param name="arg_fact ">factory</param>
		/// <param name="arg_obs_id">obs id </param>
		/// <param name="arg_obs_type">obs type </param>
		/// <param name="arg_style">style </param>
		/// <returns> Data Table</returns>
		public DataTable Select_Create_OA_Nu(string arg_fact, string arg_obs_id,
			string arg_obs_type, string arg_style )
		{
			string strRlt;
 
			DataSet ret;
			
			int iCnt  = 5;
			this.ReDim_Parameter(iCnt); 
            
			strRlt  = "PKG_SEM_OA_CREATE.SELECT_SEM_OA_NU";
			Process_Name =strRlt;
			
			this.Parameter_Name[0] = "ARG_FACTORY";
			this.Parameter_Name[1] = "ARG_OBS_ID";
			this.Parameter_Name[2] = "ARG_OBS_TYPE";
			this.Parameter_Name[3] = "ARG_STYLE_CD";
			this.Parameter_Name[4] = "OUT_CURSOR"; 
				
			for (int i =0 ; i<iCnt-1; i++) 
				this.Parameter_Type[i] = (int)OracleType.VarChar;
			
			this.Parameter_Type[iCnt-1] = (int)OracleType.Cursor;
	
			this.Parameter_Values[0] = arg_fact;
			this.Parameter_Values[1] = arg_obs_id;
			this.Parameter_Values[2] = arg_obs_type;
			this.Parameter_Values[3] = arg_style;
			this.Parameter_Values[4] = "";
				
			this.Add_Select_Parameter(true); 
			
			ret =  Exe_Select_Procedure();
			
			if(ret == null) 
			{
				return null;
			}
			else
			{
				return ret.Tables[strRlt];
			}
				
		}






		/// <summary>
		/// OA NU ����Ʈ ��ȸ
		/// </summary>
		/// <param name="arg_fact ">factory</param>
		/// <param name="arg_obs_id">obs id </param>
		/// <param name="arg_obs_type">obs type </param>
		/// <param name="arg_style">style </param>
		/// <returns> Data Table</returns>
		public DataTable Select_OA_Nu(string arg_fact, string arg_obs_id,
			string arg_obs_type, string arg_style )
		{
			string strRlt;
 
			DataSet ret;
			
			int iCnt  = 5;
			this.ReDim_Parameter(iCnt); 
            
			strRlt  = "PKG_SEM_OA_CRT01.SELECT_SEM_OA_NU ";
			Process_Name =strRlt;
			
			this.Parameter_Name[0] = "ARG_FACTORY";
			this.Parameter_Name[1] = "ARG_OBS_ID";
			this.Parameter_Name[2] = "ARG_OBS_TYPE";
			this.Parameter_Name[3] = "ARG_STYLE_CD";
			this.Parameter_Name[4] = "OUT_CURSOR"; 
				
			for (int i =0 ; i<iCnt-1; i++) 
				this.Parameter_Type[i] = (int)OracleType.VarChar;
			
			this.Parameter_Type[iCnt-1] = (int)OracleType.Cursor;
	
			this.Parameter_Values[0] = arg_fact;
			this.Parameter_Values[1] = arg_obs_id;
			this.Parameter_Values[2] = arg_obs_type;
			this.Parameter_Values[3] = arg_style;
			this.Parameter_Values[4] = "";
				
			this.Add_Select_Parameter(true); 
			
			ret =  Exe_Select_Procedure();
			
			if(ret == null) 
			{
				return null;
			}
			else
			{
				return ret.Tables[strRlt];
			}
				
		}


		/// <summary>
		/// Style Master ��ȸ
		/// </summary>
		/// <param name="arg_fact ">�����ڵ�</param>
		/// <returns> Data Table</returns>
		public DataTable Select_Style_Master(string arg_style_cd)
		{
			string strRlt;
 
			DataSet ret;
			
			this.ReDim_Parameter(2); 
            
			strRlt  = "PKG_SEM_COMMON.SELECT_SEM_STYLE";
			Process_Name =strRlt;
			
			this.Parameter_Name[0] = "ARG_STYLE_CD";
			this.Parameter_Name[1] = "OUT_CURSOR"; 
			
			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.Cursor;
	
			this.Parameter_Values[0] = arg_style_cd;
			this.Parameter_Values[1] = "";
				
			this.Add_Select_Parameter(true); 
			ret =  Exe_Select_Procedure();
			
			if(ret == null) 
			{
				return null;
			}
			else
			{
				return ret.Tables[strRlt];
			}
				
		}


		/// <summary>
		/// Style OBS�� ��ȸ
		/// </summary>
		/// <param name="arg_fact ">�����ڵ�</param>
		/// <param name="arg_obs_id "> ����ID</param>
		/// <param name="arg_obs_type "> ����Ÿ��</param>
		/// <param name="arg_style_cd "> ��Ÿ���ڵ�</param>/// 
		/// <returns> Data Table</returns>
		public DataTable Select_OBS_Style(string arg_factory, string arg_obs_id,
			string arg_obs_type, string arg_style_cd)
		{
			string strRlt;
 
			DataSet ret;
			
			this.ReDim_Parameter(5); 
            
			strRlt  = "PKG_SEM_COMMON.SELECT_SEM_OBS_STYLE";
			Process_Name =strRlt;

			this.Parameter_Name[0] = "ARG_FACTORY";
			this.Parameter_Name[1] = "ARG_OBS_ID";
			this.Parameter_Name[2] = "ARG_OBS_TYPE";
			this.Parameter_Name[3] = "ARG_STYLE_CD";
			this.Parameter_Name[4] = "OUT_CURSOR"; 
			
			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.VarChar;
			this.Parameter_Type[2] = (int)OracleType.VarChar;
			this.Parameter_Type[3] = (int)OracleType.VarChar;
			this.Parameter_Type[4] = (int)OracleType.Cursor;
	
			this.Parameter_Values[0] = arg_factory;
			this.Parameter_Values[1] = arg_obs_id;
			this.Parameter_Values[2] = arg_obs_type;
			this.Parameter_Values[3] = arg_style_cd;
			this.Parameter_Values[4] = "";
				
			this.Add_Select_Parameter(true); 
			ret =  Exe_Select_Procedure();
			
			if(ret == null) 
			{
				return null;
			}
			else
			{
				return ret.Tables[strRlt];
			}
				
		}


		/// <summary>
		/// BP ���� Outsole List��ȸ �ϱ�
		/// </summary>
		/// <param name="arg_fact ">�����ڵ�</param>
		/// <param name="arg_obs_id_from">OBS ID - From </param>
		/// <param name="arg_obs_id_to">OBS ID - To </param>
		/// <returns> Data Table</returns>
		public DataTable Select_BP_OutSole(string arg_fact, string arg_obs_id_from ,
			string arg_obs_id_to )
		{
			string strRlt;
 
			DataSet ret;
			
			this.ReDim_Parameter(4); 
            
			strRlt  = "PKG_SEM_BP_BAL.SELECT_SEM_OUTSOLE";
			Process_Name =strRlt;
			
			this.Parameter_Name[0] = "ARG_FACTORY";
			this.Parameter_Name[1] = "ARG_OBS_ID_FROM";
			this.Parameter_Name[2] = "ARG_OBS_ID_TO";
			this.Parameter_Name[3] = "OUT_CURSOR"; 
				
			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.VarChar;
			this.Parameter_Type[2] = (int)OracleType.VarChar;
			this.Parameter_Type[3] = (int)OracleType.Cursor;
	
			this.Parameter_Values[0] = arg_fact;
			this.Parameter_Values[1] = arg_obs_id_from;
			this.Parameter_Values[2] = arg_obs_id_to;
			this.Parameter_Values[3] = "";
				
			this.Add_Select_Parameter(true); 
			ret =  Exe_Select_Procedure();
			
			if(ret == null) 
			{
				return null;
			}
			else
			{
				return ret.Tables[strRlt];
			}
				
		}



		/// <summary>
		/// Gender, Pst_Yn ��ȸ�ϱ�
		/// </summary>
		/// <param name="arg_style_cd">��Ÿ�� �ڵ�</param>
		/// <returns> ����</returns>
		public void Select_Gen_Pst(string arg_style_cd)
		{
			string strGenPst;
 
			DataSet ret;

			this.ReDim_Parameter(2); 
            
			strGenPst  = "PKG_SEM_COMMON.SELECT_SEM_GEN_PST";
			this.Process_Name =strGenPst;
			
			this.Parameter_Name[0] = "ARG_STYLE_CD";
			this.Parameter_Name[1] = "OUT_CURSOR"; 
				
			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.Cursor;
	
			this.Parameter_Values[0] = arg_style_cd;
			this.Parameter_Values[1] = "";
				
			this.Add_Select_Parameter(true); 
			ret = this.Exe_Select_Procedure();
			
			this.Add_Select_Parameter(true); 
			ret =  Exe_Select_Procedure();
			

			ClassLib.ComVar.DivGen= ret.Tables[strGenPst].Rows[0].ItemArray[0].ToString();
			ClassLib.ComVar.DivPst  = ret.Tables[strGenPst].Rows[0].ItemArray[1].ToString();
			ClassLib.ComVar.DivStyleNm  = ret.Tables[strGenPst].Rows[0].ItemArray[2].ToString();

		}


		
		/// <summary>
		/// Gender�� ������ ����Ʈ 
		/// </summary>
		/// <param name="arg_factory">���� �ڵ�</param>
		/// <param name="arg_gen">���� �ڵ�</param>
		/// <param name="arg_pst_yn">�������� ���� �ڵ�</param>
		/// <returns> ������ ����Ʈ</returns>
		public DataTable Select_Gen_Size(string arg_factory,  string arg_gen , string arg_pst_yn)
		{
			string strGen;
 
			DataSet ret;

			this.ReDim_Parameter(4); 
            
			strGen  = "PKG_SEM_COMMON.SELECT_SEM_GEN_SIZE";
			this.Process_Name = strGen;

			this.Parameter_Name[0] = "ARG_FACTORY";
			this.Parameter_Name[1] = "ARG_GEN"; 
			this.Parameter_Name[2] = "ARG_PST_YN"; 
			this.Parameter_Name[3] = "OUT_CURSOR"; 
				
			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.VarChar;
			this.Parameter_Type[2] = (int)OracleType.VarChar;
			this.Parameter_Type[3] = (int)OracleType.Cursor;
	
			this.Parameter_Values[0] = arg_factory;
			this.Parameter_Values[1] = arg_gen;
			this.Parameter_Values[2] = arg_pst_yn;
			this.Parameter_Values[3] = "";
				
			this.Add_Select_Parameter(true); 
			ret = this.Exe_Select_Procedure();
			

			if(ret == null) 
			{
				return null;
			}
			else
			{
				return ret.Tables[strGen];
			}
		}


		/// <summary>
		/// Select_Region  : Region Combo
		/// </summary>
		public DataTable Select_Region (string arg_factory )
		{
			string strRegion;
 
			DataSet ret;

			this.ReDim_Parameter(2); 
            
			strRegion  = "PKG_SEM_COMMON.SELECT_SEM_REGION";
			
			//01.PROCEDURE��
			this.Process_Name = strRegion;

			//02.ARGURMENT��
			this.Parameter_Name[0] = "ARG_FACTORY";
			this.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA ����  
			this.Parameter_Values[0] = arg_factory;
			this.Parameter_Values[1] = ""; 

			this.Add_Select_Parameter(true); 
			ret = this.Exe_Select_Procedure();
			

			if(ret == null) 
			{
				return null;
			}
			else
			{
				return ret.Tables[strRegion];
			}

		}



		/// <summary>
		/// Select_Dest : Destination Combo
		/// </summary>
		public DataTable Select_Dest (string arg_factory )
		{
			string strRegion;
 
			DataSet ret;

			this.ReDim_Parameter(2); 
            
			strRegion  = "PKG_SEM_COMMON.SELECT_SEM_DEST";
			
			//01.PROCEDURE��
			this.Process_Name = strRegion;

			//02.ARGURMENT��
			this.Parameter_Name[0] = "ARG_FACTORY";
			this.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA ����  
			this.Parameter_Values[0] = arg_factory;
			this.Parameter_Values[1] = ""; 

			this.Add_Select_Parameter(true); 
			ret = this.Exe_Select_Procedure();
			

			if(ret == null) 
			{
				return null;
			}
			else
			{
				return ret.Tables[strRegion];
			}

		}



		/// <summary>
		/// Select_Size_List : Size run Select
		/// </summary>
		public DataTable Select_Size_List()
		{
			//COM.OraDB this. = new COM.OraDB();     
			DataSet ds_ret;

			string process_name = "PKG_SEM_COMMON.SELECT_SEM_SIZE_RUN";

			this.ReDim_Parameter(2); 

			//01.PROCEDURE��
			this.Process_Name = process_name;
 
			//02.ARGURMENT��
			this.Parameter_Name[0] = "ARG_FACTORY";
			this.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA ����  
			this.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			this.Parameter_Values[1] = ""; 

			this.Add_Select_Parameter(true);
 
			ds_ret = this.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}
	
	}
}
	


