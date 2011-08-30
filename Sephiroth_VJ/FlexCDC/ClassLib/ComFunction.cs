using System;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 
using FarPoint.Win.Spread;
using Lassalle.Flow;
using System.IO;
using System.Data.OleDb;
using Microsoft.Office.Core;




namespace FlexCDC.ClassLib
{
	/// <summary>
	/// Common_Function¿¡ ´ëÇÑ ¿ä¾à ¼³¸íÀÔ´Ï´Ù.
	/// </summary>
	public class ComFunction : COM.ComFunction
	{
		public ComFunction()
		{
			//
			// TODO: ¿©±â¿¡ »ý¼ºÀÚ ³í¸®¸¦ Ãß°¡ÇÕ´Ï´Ù.
			//
		}

		#region ¸ÖÆ¼ ÄÞº¸ ¸®½ºÆ® ±¸Çö

		/// <summary>
		/// Set_ComboList_Multi : ¿©·¯°³ ÄÞº¸¸®½ºÆ®
		/// </summary> 
		public static void Set_ComboList_Multi(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int[] arg_pos, bool arg_emptyrow)
		{ 
			DataSet temp_dataset = new System.Data.DataSet();
			DataTable temp_datatable;
			DataRow newrow; 

			temp_datatable = temp_dataset.Tables.Add("Combo List");

			for (int i = 0 ; i < arg_pos.Length ; i++)
			{
				temp_datatable.Columns.Add(new DataColumn("Item" + i, Type.GetType("System.String")));
			}
			 
			for(int i = 0 ; i < dtcmb_list.Rows.Count; i++)
			{
				newrow = temp_datatable.NewRow();
				for (int j = 0 ; j < arg_pos.Length ; j++)
				{
					newrow[j] = dtcmb_list.Rows[i].ItemArray[arg_pos[j]];
				}
				temp_datatable.Rows.Add(newrow);
			}
  
			  

			arg_cmb.DataSource = temp_datatable;
			
			arg_cmb.ValueMember = "Item0";
			arg_cmb.DisplayMember = "Item0";

			arg_cmb.SelectedIndex = -1;  
			arg_cmb.MaxDropDownItems = 10;

			int dropdownwidth = arg_pos.Length * 60;
			if(arg_cmb.Width > dropdownwidth) dropdownwidth = arg_cmb.Width; 
			arg_cmb.DropDownWidth = dropdownwidth;

			arg_cmb.ExtendRightColumn = true; 
			arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored; 
		}


		#endregion

		#region DB°ü·Ã
		

		
		public static DataSet Read_Excel(string arg_dtsrc, string arg_sql)
		{  
			try
			{
				OleDbConnection AdoConn = null;
				OleDbDataAdapter oraDA = null;
				DataSet oraDS = new DataSet("OraDataSet");
 
				string ExcelCon=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+arg_dtsrc+";Excel 8.0;Imex=1;HDR=YES";


				AdoConn = new OleDbConnection(ExcelCon);
				AdoConn.Close();
				AdoConn.Open();


				string AdoSQL = arg_sql; 
				OleDbCommand Cmd = new OleDbCommand(AdoSQL, AdoConn);  
				oraDA = new OleDbDataAdapter(Cmd); 
				oraDA.Fill(oraDS);

				return oraDS;  
			}
			catch
			{
				return null;
			}
		}




		public static string Set_Size_Value(string arg_gencode)
		{
			switch(arg_gencode)
			{

				case  ClassLib.ComVar.ConsCDC_WO:
					return "7";
				case  ClassLib.ComVar.ConsCDC_GS:
					return "3.5Y";
				case   ClassLib.ComVar.ConsCDC_PS:
					return "12C";
				case   ClassLib.ComVar.ConsCDC_IN:
					return "5C";

				default :
				{
					return "9";
				}
				
			}

		}

		

		public static DataTable  Select_Grid_Head(string arg_pgid, string arg_pgseq)
		{

			COM.OraDB OraDB = new COM.OraDB();


			DataSet DS_Ret;

			string Proc_Name = "PKG_SCM_TABLE.SELECT_COL_LIST";

			////// DB¿¡¼­ ±×¸®µå Head ÃßÃâ 
			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_PG_ID";
			OraDB.Parameter_Name[1] = "ARG_PG_SEQ"; 
			OraDB.Parameter_Name[2] = "OUT_CURSOR"; 
			
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = arg_pgid;
			OraDB.Parameter_Values[1] = arg_pgseq;
			OraDB.Parameter_Values[2] = "";


			OraDB.Add_Select_Parameter(true); 
			DS_Ret =  OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];

		}

		public static DataTable Select_Category_List(string arg_factory, string arg_com_code)
		{

			
			COM.OraDB OraDB = new COM.OraDB();

			string Proc_Name = "PKG_SCM_CODE.SELECT_COM_CODE";

			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_COM_CD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_factory," ");
			OraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_com_code," ");
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}


		public static DataTable Select_Com_List(string arg_factory, string arg_com_code)
		{

			
			COM.OraDB OraDB = new COM.OraDB();

			string Proc_Name = "PKG_SCM_CODE.SELECT_COM_CODE";

			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_COM_CD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_factory," ");
			OraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_com_code," ");
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}




		public static DataTable  Select_Sample_Type(string arg_factory)
		{

			COM.OraDB OraDB = new COM.OraDB();


			string Proc_Name = "PKG_SXC_COMMON.SELECT_SAMPLE_TYPE";

			OraDB.ReDim_Parameter(2);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] =  "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_factory," ");
			OraDB.Parameter_Values[1] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}




		
		public static DataTable  Select_Season_Type(string arg_factory)
		{

			COM.OraDB OraDB = new COM.OraDB();


			string Proc_Name = "PKG_SXC_COMMON.SELECT_SEASON_TYPE";

			OraDB.ReDim_Parameter(2);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] =  "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_factory," ");
			OraDB.Parameter_Values[1] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}




		
		public static  DataTable Select_Load_User(string arg_factory)
		{

			COM.OraDB OraDB = new COM.OraDB();


			string Proc_Name = "PKG_SXC_COMMON.SELECT_LOAD_USER";

			OraDB.ReDim_Parameter(2);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] =  ClassLib.ComFunction.Empty_String(arg_factory," ");
			OraDB.Parameter_Values[1] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}



			
		public static  DataTable Select_Type_Matrix(string arg_pg_id,string  arg_pg_seq)
		{

			COM.OraDB OraDB = new COM.OraDB();


			string Proc_Name = "PKG_SXC_COMMON.SELECT_TYPE_MATRIX";

			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_PG_ID";
			OraDB.Parameter_Name[1] = "ARG_SEQ";
			OraDB.Parameter_Name[2] = "out_cursor";


			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] =  arg_pg_id;
			OraDB.Parameter_Values[1] =  arg_pg_seq;		
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}






		public static string  Select_Code_List_ComSeq( string arg_factory, string arg_com_cd, string arg_com_vlaue )
		{

			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE¸í
			MyOraDB.Process_Name = "PKG_SCM_CODE.SELECT_CODE_LIST3";

			//02.ARGURMENT ¸í
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_COM_CD";
			MyOraDB.Parameter_Name[2] = "ARG_COM_VALUE";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE Á¤ÀÇ
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA Á¤ÀÇ

			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_com_cd;
			MyOraDB.Parameter_Values[2] = arg_com_vlaue;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();				 
					
			return vds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[2].ToString();
			

		}



		public static DataTable Select_Cust_List( string arg_factory )
		{		

			COM.OraDB MyOraDB    = new COM.OraDB();
			
			DataSet ds_list;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE¸í
			MyOraDB.Process_Name = "PKG_SXC_COMMON.SELECT_SCM_CUST";

			//02.ARGURMENT ¸í
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";			
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE Á¤ÀÇ
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA Á¤ÀÇ
			MyOraDB.Parameter_Values[0] = arg_factory;			
			MyOraDB.Parameter_Values[1] = "";



			MyOraDB.Add_Select_Parameter(true);
			ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];

		}


		
		public static DataTable Select_CDC_Cust_List( string arg_factory, string arg_cust_name )
		{		

			COM.OraDB MyOraDB    = new COM.OraDB();
			
			DataSet ds_list;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE¸í
			MyOraDB.Process_Name = "PKG_SXC_COMMON.SELECT_SCM_CDC_CUST";

			//02.ARGURMENT ¸í
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[1] = "ARG_CUST_CD";	
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE Á¤ÀÇ
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA Á¤ÀÇ
			MyOraDB.Parameter_Values[0] = arg_factory;	
			MyOraDB.Parameter_Values[1] = arg_cust_name;	
			MyOraDB.Parameter_Values[2] = "";



			MyOraDB.Add_Select_Parameter(true);
			ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];

		}



		public static DataTable Select_TransPort( string arg_factory , string arg_transtype)
		{		

			COM.OraDB MyOraDB    = new COM.OraDB();
			
			DataSet ds_list;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE¸í
			MyOraDB.Process_Name = "PKG_SXC_COMMON.SELECT_SCM_TRANSPORT_LIKE";

			//02.ARGURMENT ¸í
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";		
			MyOraDB.Parameter_Name[1] = "ARG_TRANS_TYPE";			
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE Á¤ÀÇ
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA Á¤ÀÇ
			MyOraDB.Parameter_Values[0] = arg_factory;			
			MyOraDB.Parameter_Values[1] = arg_transtype;			
			MyOraDB.Parameter_Values[2] = "";



			MyOraDB.Add_Select_Parameter(true);
			ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];

		}



		public static DataTable Select_Season( string arg_factory , string arg_season_cd)
		{		

			COM.OraDB MyOraDB    = new COM.OraDB();
			
			DataSet ds_list;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE¸í
			MyOraDB.Process_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

			//02.ARGURMENT ¸í
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";					
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE Á¤ÀÇ
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA Á¤ÀÇ
			MyOraDB.Parameter_Values[0] = arg_factory;			
			MyOraDB.Parameter_Values[1] = "";



			MyOraDB.Add_Select_Parameter(true);
			ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];

		}



		
		public static DataTable Select_User( string arg_factory , string arg_pur_user)
		{		

			COM.OraDB MyOraDB    = new COM.OraDB();
			
			DataSet ds_list;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE¸í
			MyOraDB.Process_Name = "PKG_SXC_COMMON.SELECT_SCM_PURCHASE_USER";

			//02.ARGURMENT ¸í
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";		
			MyOraDB.Parameter_Name[1] = "ARG_PUR_USER";			
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE Á¤ÀÇ
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA Á¤ÀÇ
			MyOraDB.Parameter_Values[0] = arg_factory;			
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_pur_user," ");			
			MyOraDB.Parameter_Values[2] = "";



			MyOraDB.Add_Select_Parameter(true);
			ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];

		}



		
		public static DataTable Select_Cust_List( string arg_factory, string cust_code )
		{		

			COM.OraDB MyOraDB    = new COM.OraDB();
			
			DataSet ds_list;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE¸í
			MyOraDB.Process_Name = "PKG_SXC_COMMON.SELECT_SCM_CUST_LIKE";

			//02.ARGURMENT ¸í
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";			
			MyOraDB.Parameter_Name[1] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE Á¤ÀÇ
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA Á¤ÀÇ
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = cust_code;
			MyOraDB.Parameter_Values[2] = "";



			MyOraDB.Add_Select_Parameter(true);
			ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];

		}


		

		

		
		public static DataTable  Select_MRP_No(string arg_factory,string arg_mat_div )
		{

			COM.OraDB MyOraDB    = new COM.OraDB();


			
			string Proc_Name = "PKG_SXM_MRP_01_SELECT.SELECT_SXM_MRP_MAST_MRP_NO";

			int vCount = 3;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[1] = "ARG_MAT_DIV";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[0] = arg_factory;	
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_mat_div," ");	
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}



			
		public static DataTable  Select_MRP_Prod_Date(string arg_factory, string arg_mrp_no )
		{

			COM.OraDB MyOraDB    = new COM.OraDB();


	
			string Proc_Name = "PKG_SXM_MRP_01_SELECT.SELECT_SXM_MRP_MAST_GET_DATE";

			int vCount = 3;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[1] = "ARG_MRP_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[0] = arg_factory;				
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_mrp_no," ");	
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}


		


		public static DataTable  Select_Stock_Location(string arg_factory)
		{

			COM.OraDB MyOraDB    = new COM.OraDB();


			string Proc_Name = "PKG_SXK_STOCK_01_SELECT.SELECT_SXK_STOCK_RANK_LOCATION";

			int vCount = 2;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";					
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
		
		

			MyOraDB.Parameter_Values[0] = arg_factory;				
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
		
			return DS_Ret.Tables[Proc_Name];
		}

        public static DataTable Select_Stock_Shelf_Location(string arg_factory,string arg_rank)
        {

            COM.OraDB MyOraDB = new COM.OraDB();


            string Proc_Name = "PKG_SXK_STOCK_01_SELECT.SELECT_SXK_STOCK_SH_LOCATION";

            int vCount = 3;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_RANK";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


            for (int i = 0; i < vCount - 1; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Type[vCount - 1] = (int)OracleType.Cursor;



            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_rank;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
		
		public static DataTable  Select_Inout_Vendor_List(string arg_factory ,string arg_inout_ymd)
		{

			COM.OraDB MyOraDB    = new COM.OraDB();


			string Proc_Name = "PKG_SXK_STOCK_01_SELECT.SELECT_SXI_IN_VENDOR_LIST";

			int vCount = 3;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";		
            MyOraDB.Parameter_Name[1] = "ARG_INOUT_YMD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
		
		

			MyOraDB.Parameter_Values[0] = arg_factory;	
			MyOraDB.Parameter_Values[1] = arg_inout_ymd;	
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
		
			return DS_Ret.Tables[Proc_Name];
		}

//
//
//		
//		public static DataTable  Select_Inout_Vendor_List(string arg_factory,string arg_inout_ymd)
//		{
//
//			COM.OraDB MyOraDB    = new COM.OraDB();
//
//
//			string Proc_Name = "PKG_SXK_STOCK_01_SELECT.SELECT_SXI_IN_VENDOR_LIST";
//
//			int vCount = 3;
//			MyOraDB.ReDim_Parameter(vCount);
//			MyOraDB.Process_Name = Proc_Name ;
//
//			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
//			MyOraDB.Parameter_Name[1] = "ARG_INOUT_YMD";
//			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
//
//
//			for (int i =0 ; i< vCount-1 ; i++)
//				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  
//
//			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
//		
//		
//
//			MyOraDB.Parameter_Values[0] = arg_factory;	
//			MyOraDB.Parameter_Values[1] = arg_inout_ymd;	
//			MyOraDB.Parameter_Values[2] = "";
//
//			MyOraDB.Add_Select_Parameter(true);
//			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();
//
//			if(DS_Ret == null) return null ;
//		
//			return DS_Ret.Tables[Proc_Name];
//		}
//




		public static DataTable  Select_Close_YM(string arg_factory, string arg_location )
		{

			COM.OraDB MyOraDB    = new COM.OraDB();

			string Proc_Name = "PKG_SXK_STOCK_01_SELECT.SELECT_SXK_STOCK_NO";

			int vCount = 5;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";		
			MyOraDB.Parameter_Name[1] = "ARG_LOCATION";
			MyOraDB.Parameter_Name[2] = "ARG_STOCK_YMD_F";
			MyOraDB.Parameter_Name[3] = "ARG_STOCK_YMD_T";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;



			MyOraDB.Parameter_Values[0] = arg_factory;		
			MyOraDB.Parameter_Values[1] = arg_location;	
			MyOraDB.Parameter_Values[2] = " ";
			MyOraDB.Parameter_Values[3] = " ";
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;

			return DS_Ret.Tables[Proc_Name];
		}




		

		public static DataTable  Select_Stock_Vendor(string arg_factory, string arg_stock_ymd )
		{

			COM.OraDB MyOraDB    = new COM.OraDB();

			string Proc_Name = "PKG_SXK_STOCK_01_SELECT.SELECT_SXI_IN_VENDOR_DESC";

			int vCount = 3;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";		
			MyOraDB.Parameter_Name[1] = "ARG_STOCK_YMD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;



			MyOraDB.Parameter_Values[0] = arg_factory;		
			MyOraDB.Parameter_Values[1] = arg_stock_ymd;	
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;

			return DS_Ret.Tables[Proc_Name];
		}



		

		
		public static DataTable  Select_MRP_Item_NoList(string arg_factory)
		{

			COM.OraDB MyOraDB    = new COM.OraDB();


			string Proc_Name = "PKG_SXM_MRP_01_SELECT.SELECT_SXM_MRP_ITEM_MRP_NOLIST";

			int vCount = 2;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";		
			//MyOraDB.Parameter_Name[1] = "ARG_MRP_DATE";	
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;



			MyOraDB.Parameter_Values[0] = arg_factory;	
			//MyOraDB.Parameter_Values[1] = arg_mrp_date;	
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;

			return DS_Ret.Tables[Proc_Name];
		}







		public static DataTable  Select_MRP_NoList(string arg_factory)
		{

			COM.OraDB MyOraDB    = new COM.OraDB();


			string Proc_Name = "PKG_SXM_MRP_01_SELECT.SELECT_SXM_MRP_ITEM_MRP_NOLIST";

			int vCount = 2;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";		
			//MyOraDB.Parameter_Name[1] = "ARG_MRP_DATE";	
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
		
		

			MyOraDB.Parameter_Values[0] = arg_factory;	
			//MyOraDB.Parameter_Values[1] = arg_mrp_date;	
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
		
			return DS_Ret.Tables[Proc_Name];
		}




		


		public static DataTable  Select_MRP_Mast_NoList(string arg_factory)
		{

			COM.OraDB MyOraDB    = new COM.OraDB();


			string Proc_Name = "PKG_SXM_MRP_01_SELECT.SELECT_SXM_MRP_MAST_NOLIST";

			int vCount = 2;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";		
			//MyOraDB.Parameter_Name[1] = "ARG_MRP_DATE";	
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
		
		

			MyOraDB.Parameter_Values[0] = arg_factory;	
			//MyOraDB.Parameter_Values[1] = arg_mrp_date;	
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
		
			return DS_Ret.Tables[Proc_Name];
		}







		public static DataTable  Select_Pur_Div(string arg_factory )
		{

			COM.OraDB MyOraDB    = new COM.OraDB();


			string Proc_Name = "PKG_SXM_MRP_01_SELECT.SELECT_SXM_MRP_PARA_PUR_DIV";

			int vCount = 2;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";		
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[0] = arg_factory;	
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}





		public static DataTable  Select_Mast_Pur_Div(string arg_factory, string arg_mrp_no )
		{

			COM.OraDB MyOraDB    = new COM.OraDB();


			string Proc_Name = "PKG_SXM_MRP_01_SELECT.SELECT_SXM_MRP_MAST_MRP_NO";

			int vCount = 3;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";		
			MyOraDB.Parameter_Name[1] = "ARG_MRP_NO";	
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[0] = arg_factory;	
			MyOraDB.Parameter_Values[1] = arg_mrp_no;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}


		
		public static DataTable  Select_MRP_Date(string arg_factory)
		{

			COM.OraDB MyOraDB    = new COM.OraDB();


			
			string Proc_Name = "PKG_SXM_MRP_01_SELECT.SELECT_SXM_MRP_MAST_MRP_DATE";

			int vCount = 2;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_factory," ");
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}




	

		#endregion

		#region ÄÜÆ®·Ñ°ü·Ã
		
		/// <summary>
		/// Get_Index : ½ÇÁ¦ ³ëµå ÀÎµ¦½º ¹øÈ£·Î ±×·ÁÁú¶§ ÀÎµ¦½º °¡Á®¿À±â
		/// ±×·ÁÁú¶§´Â ½ÇÁ¦ ³ëµå ÀÎµ¦½º »ç¿ë ¸øÇÔ (Áß°£¿¡ »èÁ¦µÈ°Í ÀÖÀ» ¼ö ÀÖÀ¸¹Ç·Î)
		/// </summary>
		/// <param name="arg_fgrid">ÇØ´ç µ¥ÀÌÅÍ ±×¸®µå</param>
		/// <param name="arg_nodeix">org, dst ³ëµå ¹øÈ£</param>
		/// <param name="arg_index">±×¸®µå¿¡¼­ ³ëµå ÀÎµ¦½º ¹øÈ£</param>
		/// <returns></returns>
		public static int Get_Index(C1FlexGrid arg_fgrid, string arg_nodeix, int arg_index, int arg_rowfixed)
		{
			int i;
			int temp_row = 0;
			int temp_nodecd = 0; 
			string node_cd = "";
			int node_cd_length = 0;


			for(i = arg_rowfixed; i < arg_fgrid.Rows.Count; i++)
			{
				node_cd = arg_fgrid[i, arg_index].ToString();
				node_cd_length = arg_fgrid[i, arg_index].ToString().Length;

				temp_nodecd = Convert.ToInt32(node_cd.Substring(node_cd_length - 4, 4));

				if(temp_nodecd == Convert.ToInt32(arg_nodeix))
				{
					temp_row = i - arg_rowfixed;
					break;
				} 

			}  //end for i
  
			return temp_row; 

		}


		

		/// <summary>
		/// Clear_AddFlow : AddFlow ÃÊ±âÈ­
		/// </summary>
		public static void Clear_AddFlow(Lassalle.Flow.AddFlow arg_addflow)
		{
			arg_addflow.Items.Clear();
			arg_addflow.ResetDefNodeProp();
			arg_addflow.ResetDefLinkProp();
			arg_addflow.ResetGrid();
			arg_addflow.ResetText();
			ComFunction.Set_DefNodeProp(arg_addflow);
 
			arg_addflow.BackColor = Color.White;
			arg_addflow.Grid.Draw = true;
			arg_addflow.Grid.Snap = false;
			arg_addflow.Grid.Style = GridStyle.DottedLines;
			arg_addflow.Grid.Color = Color.Silver;
			arg_addflow.Grid.Size = new Size(10, 10);
 

		}


		
		/// <summary>
		/// default node ¼Ó¼º Á¤ÀÇ
		/// </summary>
		/// <param name="sType"></param> 
		public static void Set_DefNodeProp(Lassalle.Flow.AddFlow arg_addflow)
		{ 
			 
			arg_addflow.DefNodeProp.Alignment = Alignment.CenterMIDDLE;
			arg_addflow.DefNodeProp.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			arg_addflow.DefNodeProp.DrawColor = Color.Black;
			arg_addflow.DefNodeProp.DrawWidth = 1;
			arg_addflow.DefNodeProp.FillColor = Color.White; 
			arg_addflow.DefNodeProp.Font = ComFunction.ToFont(""); 
			arg_addflow.DefNodeProp.Gradient = false; 
			arg_addflow.DefNodeProp.Shape.Style = ShapeStyle.Rectangle; 
			arg_addflow.DefNodeProp.TextColor = Color.Black; 
			
		}




		
		/// <summary>
		/// Font string ºÐ¸®ÇØ¼­ Font ½ºÅ¸ÀÏ ¸¸µé±â
		/// </summary>
		/// <param name="sfont"></param>
		/// <returns></returns>
		public static Font ToFont(string arg_font)
		{     
			string familyName = "";
			float size = 0;
			FontStyle style = FontStyle.Regular;

			if(arg_font != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_font.Split(delimiter); 
  
				familyName = token[0].ToString();
				size = Convert.ToSingle(token[1]);
				
				if (Convert.ToBoolean(token[2]))
				{
					style = style | FontStyle.Bold;
				}

				if (Convert.ToBoolean(token[3]))
				{
					style = style | FontStyle.Italic;
				}

				if (Convert.ToBoolean(token[4]))
				{
					style = style | FontStyle.Strikeout;
				}

				if (Convert.ToBoolean(token[5]))
				{
					style = style | FontStyle.Underline;
				}

				return new Font(familyName, size, style);  
			}
			else
			{
				return new Font("Verdana", 6);
			} 
			
		}





		
		/// <summary>
		///Set_LinkProp : link ¼Ó¼º Á¤ÀÇ
		/// </summary>
		public static void Set_LinkProp(C1FlexGrid arg_fgrid, Lassalle.Flow.Link arg_link, int arg_index)
		{
			 
		
			//ALLOW_DST 
			if(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxARROW_DST].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxARROW_DST].ToString().Split(delimiter); 

				////allow_Dst -> style(head)
				foreach (Lassalle.Flow.ArrowStyle v in Enum.GetValues(typeof(Lassalle.Flow.ArrowStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_link.ArrowDst.Style = v;
						break;
					}
				}

				////allow_Dst -> size
				foreach (Lassalle.Flow.ArrowSize v in Enum.GetValues(typeof(Lassalle.Flow.ArrowSize)))
				{
					if(token[1] == v.GetHashCode().ToString())
					{
						arg_link.ArrowDst.Size = v;
						break;
					}
				}  

				////allow_Dst -> Angle
				foreach (Lassalle.Flow.ArrowAngle v in Enum.GetValues(typeof(Lassalle.Flow.ArrowAngle)))
				{
					if(token[2] == v.GetHashCode().ToString())
					{
						arg_link.ArrowDst.Angle = v;
						break;
					}
				}

				////allow_Dst -> Filled 
				arg_link.ArrowDst.Filled = Convert.ToBoolean(token[3]);

			}


			//ALLOW_MID 
			if(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxARROW_MID].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxARROW_MID].ToString().Split(delimiter); 

				////allow_Mid -> style(head)
				foreach (Lassalle.Flow.ArrowStyle v in Enum.GetValues(typeof(Lassalle.Flow.ArrowStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_link.ArrowMid.Style = v;
						break;
					}
				}

				////allow_Mid -> size
				foreach (Lassalle.Flow.ArrowSize v in Enum.GetValues(typeof(Lassalle.Flow.ArrowSize)))
				{
					if(token[1] == v.GetHashCode().ToString())
					{
						arg_link.ArrowMid.Size = v;
						break;
					}
				}  

				////allow_Mid -> Angle
				foreach (Lassalle.Flow.ArrowAngle v in Enum.GetValues(typeof(Lassalle.Flow.ArrowAngle)))
				{
					if(token[2] == v.GetHashCode().ToString())
					{
						arg_link.ArrowMid.Angle = v;
						break;
					}
				}

				////allow_Mid -> Filled 
				arg_link.ArrowMid.Filled = Convert.ToBoolean(token[3]);

			}


			//ALLOW_ORG
			if(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxARROW_ORG].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxARROW_ORG].ToString().Split(delimiter); 

				////allow_Org -> style(head)
				foreach (Lassalle.Flow.ArrowStyle v in Enum.GetValues(typeof(Lassalle.Flow.ArrowStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_link.ArrowOrg.Style = v;
						break;
					}
				}

				////allow_Org -> size
				foreach (Lassalle.Flow.ArrowSize v in Enum.GetValues(typeof(Lassalle.Flow.ArrowSize)))
				{
					if(token[1] == v.GetHashCode().ToString())
					{
						arg_link.ArrowOrg.Size = v;
						break;
					}
				}  

				////allow_Org -> Angle
				foreach (Lassalle.Flow.ArrowAngle v in Enum.GetValues(typeof(Lassalle.Flow.ArrowAngle)))
				{
					if(token[2] == v.GetHashCode().ToString())
					{
						arg_link.ArrowOrg.Angle = v;
						break;
					}
				}

				////allow_Org -> Filled 
				arg_link.ArrowOrg.Filled = Convert.ToBoolean(token[3]);

			}

	
			//DashStyle
			foreach (System.Drawing.Drawing2D.DashStyle v in Enum.GetValues(typeof(System.Drawing.Drawing2D.DashStyle)))
			{
				if(arg_fgrid[arg_index,(int)ClassLib.LINK_DEF.IxDASHSTYLE].ToString() == v.GetHashCode().ToString())
				{
					arg_link.DashStyle = v;
					break;
				}
			}

			arg_link.DrawColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxDRAWCOLOR].ToString()));
			arg_link.DrawWidth = Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxDRAWWIDTH].ToString()); 

			//Font ¼Ó¼º
			arg_link.Font = ClassLib.ComFunction.ToFont(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxFONT].ToString()); 
 
	 
			//Jump ¼Ó¼º
			foreach (Jump v in Enum.GetValues(typeof(Jump)))
			{
				if(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxJUMP].ToString().ToString() == v.GetHashCode().ToString())
				{
					arg_link.Jump = v; 
					break;
				}
			}

			//Line -> Style
			foreach (LineStyle v in Enum.GetValues(typeof(LineStyle)))
			{
				if(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxLINE_STYLE].ToString() == v.GetHashCode().ToString())
				{
					arg_link.Line.Style = v; 
					break;
				}
			}

			//Line -> RoundCorner
			arg_link.Line.RoundedCorner = Convert.ToBoolean(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxLINE_ROUND].ToString());

			//			//Tag
			//			arg_link.Tag = arg_fgrid[arg_index, _BLTag_ix].ToString();

			//Text

			//TextColor
			if (arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxTEXTCOLOR].ToString() != "")
			{
				arg_link.TextColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxTEXTCOLOR].ToString()));
			}
			

			//ToolTip
 

		}



		
		/// <summary>
		/// ³ëµå Á¤º¸ °¡Á®¿À±â
		/// </summary>
		public static void Set_NodeProp(C1FlexGrid arg_fgrid, Lassalle.Flow.Node arg_node, int arg_index)
		{ 
			   
			double width = 0, height = 0;

			//Alignment
			foreach (Alignment v in Enum.GetValues(typeof(Alignment)))
			{
				if(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxALIGNMENT].ToString() == v.GetHashCode().ToString())
				{
					arg_node.Alignment = v; 
					break;
				}
			}

			//DashStyle
			foreach (System.Drawing.Drawing2D.DashStyle v in Enum.GetValues(typeof(System.Drawing.Drawing2D.DashStyle)))
			{
				if(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxDASHSTYLE].ToString() == v.GetHashCode().ToString())
				{
					arg_node.DashStyle = v;
					break;
				}
			}

			arg_node.DrawColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxDRAWCOLOR].ToString()));
			arg_node.DrawWidth = Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxDRAWWIDTH].ToString());
			arg_node.FillColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxFILLCOLOR].ToString()));

			//Font ¼Ó¼º
			arg_node.Font = ClassLib.ComFunction.ToFont(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxFONT].ToString());

			//Gradient ¼Ó¼º
			arg_node.Gradient = (arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxGRADI_YN].ToString() == "Y" ? true : false);

			if (arg_node.Gradient)
			{
				arg_node.GradientColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxGRADICOLOR].ToString()));
				
				foreach (System.Drawing.Drawing2D.LinearGradientMode v in Enum.GetValues(typeof(System.Drawing.Drawing2D.LinearGradientMode)))
				{
					if(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxGRADIMODE].ToString() == v.GetHashCode().ToString())
					{
						arg_node.GradientMode = v;
						break;
					}
				}
			}   //end if
    
			//Shaow 
			if(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxSHADOW].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxSHADOW].ToString().Split(delimiter); 

				/////shadow -> style
				foreach (ShadowStyle v in Enum.GetValues(typeof(ShadowStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_node.Shadow.Style = v;
						break;
					}
				}
              
				/////shadow -> color, width, height
				arg_node.Shadow.Color = Color.FromArgb(Convert.ToInt32(token[1]));
				arg_node.Shadow.Size = new Size(Convert.ToInt32(token[2]), Convert.ToInt32(token[3]));

			}

			//Shape
			if(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxSHAPE].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxSHAPE].ToString().Split(delimiter); 

				////shape -> style
				foreach (ShapeStyle v in Enum.GetValues(typeof(ShapeStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_node.Shape.Style = v;
						break;
					}
				}  
		 
				////shape -> orientation
				foreach (ShapeOrientation v in Enum.GetValues(typeof(ShapeOrientation)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_node.Shape.Orientation = v;
						break;
					}
				}  
			} 

			//Node Size
			if(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxWIDTH].ToString() != "" && arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxHEIGHT].ToString() != "")
			{
				width = Convert.ToDouble(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxWIDTH].ToString());
				height = Convert.ToDouble(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxHEIGHT].ToString());

				arg_node.Size = new Size((int)width, (int)height);
 
			}
  
			//TextColor
			arg_node.TextColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxTEXTCOLOR].ToString()));
 
		}


		public static bool Essentiality_check(C1.Win.C1List.C1Combo[] arg_cmb, System.Windows.Forms.TextBox[] arg_txt)
		{
			if (arg_cmb != null)
			{
				for (int i =0; i < arg_cmb.Length; i++)
				{
					if (arg_cmb[i].SelectedIndex < 0)
					{
						ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						arg_cmb[i].Focus(); 
						return false;
					}
				}
			}
			if (arg_txt != null)
			{
				for (int i =0; i < arg_txt.Length; i++)
				{
					if (arg_txt[i].Text == "")
					{
						ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						arg_txt[i].Focus(); 
						return false;
					}
				}
			}
			return true;		
		}


		public static bool Essentiality_check(C1.Win.C1List.C1Combo[] arg_cmb, System.Windows.Forms.TextBox[] arg_txt, bool arg_blank_check)
		{
			if (arg_cmb != null)
			{
				for (int i =0; i < arg_cmb.Length; i++)
				{
					if (arg_cmb[i].SelectedIndex < 0 || arg_cmb[i].SelectedValue.ToString().Trim() == "")
					{
						ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						arg_cmb[i].Focus(); 
						return false;
					}
				}
			}
			if (arg_txt != null)
			{
				for (int i =0; i < arg_txt.Length; i++)
				{
					if (arg_txt[i].Text == "")
					{
						ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						arg_txt[i].Focus(); 
						return false;
					}
				}
			}
			return true;		
		}





		/// <returns>Á¤»ó : true , ¿À·ù : false </returns>
		public static bool Check_Flag_FlexGird( COM.FSP arg_fgrid)
		{

			for (int i  = arg_fgrid.Rows.Fixed;  i< arg_fgrid.Rows.Count ; i++)
			{

				if ((arg_fgrid[0,i]== null) || (arg_fgrid[0,i].ToString() == "")) continue;
				else 
					return false;


			
					

			}

			return true;


		}


        /// <summary>
        ///Grid Focus Next : ÀÔ·ÂÈÄ ´ÙÀ½ ÇàÀ¸·Î Æ÷Ä¿½º ÀÌµ¿
        /// </summary>
        public static void NextRow_Focus_FlexGrid(COM.FSP arg_frgid, int arg_selectrow, int arg_selectcol, bool arg_level,int arg_levelindex, string arg_levelvalue)
        {
            try
            {

                for (int i = arg_selectrow; i < arg_frgid.Rows.Count; i++)
                {
                    if (arg_level)//Tree ±¸Á¶ÀÏ¶§
                    {
                        if (arg_frgid[i + 1, arg_levelindex].ToString() == arg_levelvalue)
                        {
                            arg_frgid.Select(i + 1, arg_selectcol);
                            return;
                        }
                    }
                    else//Tree ±¸Á¶°¡ ¾Æ´Ò¶§
                    {
                        arg_frgid.Select(i + 1, arg_selectcol);
                        return;
                    }
                    
                }
                
            }
            catch
            {
            }
        }

		#endregion 
			
		#region CDCPower Level

		/// <summary>
		/// SetPowerMRPAdjust : Form_MRP_Adjust - ±ÇÇÑº° BUTTON¼Ó¼º ¼³Á¤ÇÏ±â  	
		/// </summary>
		/// <param name="arg_form">ÇØ´ç Æû</param>
		/// <param name="arg_powerlevel">CDCPowerLevel</param>		
		/// <returns></returns>/// 
		/// 
		public  static void  SetPowerMRPAdjust(FlexCDC.MRP.Form_MRP_Adjust  arg_form, string arg_powerlevel)
		{



			switch(arg_powerlevel)
			{
//						tbtn_Delete.ToolTipText ="Confirm Cancel";	
//							tbtn_Confirm.ToolTipText ="Sub Confirm";
//							tbtn_Create.ToolTipText ="Confirm";


				case "S01" :
				{
					
					arg_form.tbtn_Delete.Enabled  = true;  //Confirm Cancel
					arg_form.tbtn_Create.Enabled = true;   //Confirm 

					break;
				}
                case "S00":
                {

                    arg_form.tbtn_Delete.Enabled = true;  //Confirm Cancel
                    arg_form.tbtn_Create.Enabled = true;   //Confirm 

                    break;
                }	
				case "P00" :    //·ù½ÂÈÆ°úÀå
				{
				

					arg_form.tbtn_Delete.Enabled  = true;  //Confirm Cancel					
					arg_form.tbtn_Create.Enabled = true;

					break;
				}		
				case "P01" :   //º¯¿ë±Ù¾¾ 
				{
				

					arg_form.tbtn_Delete.Enabled  = true;  //Confirm Cancel					
					arg_form.tbtn_Create.Enabled = true;

					break;
				}						
				
				
				default:
				{
					break;

				}
			}


		}

		#endregion 

        #region EIS Common Code
        /// <summary>
        /// °øÅë ÄÚµå ÀÚ·á¸¦ Á¶È¸ÇÕ´Ï´Ù.
        /// </summary>
        /// <param name="arg_factory">°øÀå</param>
        /// <param name="arg_rate_ym">°øÅë ÄÚµå</param>
        /// <returns>Exchange rate</returns>
        public static void Set_ComboList_Width(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_ix, int arg_name_ix, bool arg_emptyrow, int arg_codewidth, int arg_namewidth)
        {
            DataTable temp_datatable = new DataTable("Combo List");
            DataRow newrow;
            int dropdownwidth = arg_codewidth + arg_namewidth;
            if (arg_cmb.Width > dropdownwidth)
            {
                dropdownwidth = arg_cmb.Width;
            }
            try
            {
                temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
                if (arg_emptyrow == true)
                {
                    newrow = temp_datatable.NewRow();
                    newrow["Code"] = " ";
                    newrow["Name"] = "ALL";
                    temp_datatable.Rows.Add(newrow);
                }
                for (int i = 0; i < dtcmb_list.Rows.Count; i++)
                {
                    newrow = temp_datatable.NewRow();
                    newrow["Code"] = dtcmb_list.Rows[i].ItemArray[arg_cd_ix];
                    newrow["Name"] = dtcmb_list.Rows[i].ItemArray[arg_name_ix];
                    temp_datatable.Rows.Add(newrow);
                }
                arg_cmb.DataSource = null;
                arg_cmb.DataSource = temp_datatable;
                arg_cmb.ValueMember = "Code";
                arg_cmb.DisplayMember = "Name";
                arg_cmb.SelectedIndex = -1;
                arg_cmb.MaxDropDownItems = 10;
                arg_cmb.DropDownWidth = dropdownwidth;
                arg_cmb.Splits[0].DisplayColumns["Code"].Width = arg_codewidth;
                arg_cmb.Splits[0].DisplayColumns["Name"].Width = arg_namewidth - 25;//½ºÅ©·Ñ ¹æÁö
                arg_cmb.ExtendRightColumn = true;
                arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Set_ComboList", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static DataTable SELECT_EIS_COMMON_CODE(string arg_factory, string arg_rate_ym)
        {
            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(3);

            MyOraDB.Process_Name = "PKG_ECM_COMMON.SELECT_COMMON_CODE";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_COM_CD";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_rate_ym;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        public static string Set_Default_Factory()
        {


            string webservice_url = COM.ComVar._WebSvc.Url;
            string return_factory = COM.ComVar.DSFactory;


            if (webservice_url == COM.ComVar.DS_WebSvc_Url)
            {
                return_factory = "VJ";
            }
            else if (webservice_url == COM.ComVar.QD_WebSvc_Url)
            {
                return_factory = "QD";
            }
            else if (webservice_url == COM.ComVar.VJ_WebSvc_Url)
            {
                return_factory = "VJ";
            }


            return return_factory;





        }

        public static void Set_ComboList_5(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb,
            int arg_1_pos, int arg_2_pos, int arg_3_pos, int arg_4_pos, int arg_5_pos,
            bool arg_emptyrow, int arg_1_width, int arg_2_width)
        {
            DataSet temp_dataset = new System.Data.DataSet();
            DataTable temp_datatable;
            DataRow newrow;

            temp_datatable = temp_dataset.Tables.Add("Combo List");
            temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
            temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
            temp_datatable.Columns.Add(new DataColumn("Gender", Type.GetType("System.String")));
            temp_datatable.Columns.Add(new DataColumn("Presto", Type.GetType("System.String")));
            temp_datatable.Columns.Add(new DataColumn("ModelName", Type.GetType("System.String")));


            if (arg_emptyrow)
            {
                newrow = temp_datatable.NewRow();
                newrow[0] = " ";
                newrow[1] = " ";
                newrow[2] = " ";
                newrow[3] = " ";
                newrow[4] = " ";
                temp_datatable.Rows.Add(newrow);
            }


            for (int i = 0; i < dtcmb_list.Rows.Count; i++)
            {
                newrow = temp_datatable.NewRow();
                newrow[0] = dtcmb_list.Rows[i].ItemArray[arg_1_pos];
                newrow[1] = dtcmb_list.Rows[i].ItemArray[arg_2_pos];
                newrow[2] = dtcmb_list.Rows[i].ItemArray[arg_3_pos];
                newrow[3] = dtcmb_list.Rows[i].ItemArray[arg_4_pos];
                newrow[4] = dtcmb_list.Rows[i].ItemArray[arg_5_pos];
                temp_datatable.Rows.Add(newrow);
            }



            arg_cmb.DataSource = temp_datatable;

            arg_cmb.ValueMember = "Code";
            arg_cmb.DisplayMember = "Name";

            arg_cmb.SelectedIndex = -1;

            arg_cmb.MaxDropDownItems = 10;

            int dropdownwidth = arg_1_width + arg_2_width;
            if (arg_cmb.Width > dropdownwidth) dropdownwidth = arg_cmb.Width;
            arg_cmb.DropDownWidth = dropdownwidth;

            arg_cmb.Splits[0].DisplayColumns["Code"].Width = arg_1_width;
            arg_cmb.Splits[0].DisplayColumns["Name"].Width = arg_2_width - 25;
            arg_cmb.Splits[0].DisplayColumns[2].Visible = false;
            arg_cmb.Splits[0].DisplayColumns[3].Visible = false;
            arg_cmb.Splits[0].DisplayColumns[4].Visible = false;

            arg_cmb.ExtendRightColumn = true;
            arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;

        }

        public static DataTable SELECT_COMMON_CODE_LIST(string arg_factory, string arg_com_cd)
        {

            try
            {

                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE¸í
                MyOraDB.Process_Name = "PKG_ECM_COMMON.SELECT_COMMON_CODE";

                //02.ARGURMENT ¸í
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_COM_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE Á¤ÀÇ
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA Á¤ÀÇ
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_com_cd;
                MyOraDB.Parameter_Values[2] = "";





                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public static DataTable SELECT_MODEL_LIST(string arg_factory)
        {

            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE¸í
                MyOraDB.Process_Name = "PKG_ECM_COMMON.SELECT_SDC_MODEL";

                //02.ARGURMENT ¸í
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE Á¤ÀÇ
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA Á¤ÀÇ
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Set_OBSID_CmbList : OBS TYPEº° OBS ID »ý¼º ¹× ÄÞº¸¸®½ºÆ®¿¡ Ãß°¡
        /// </summary>
        /// <param name="arg_type">¼±ÅÃµÈ OBS Type</param>
        /// <param name="arg_cmb">Àû¿ë ´ë»ó ÄÞº¸ ¹Ú½º¸í</param>
        public static void Set_OBSID_CmbList(string arg_type, bool arg_empty, C1.Win.C1List.C1Combo arg_cmb)
        {
            int i = 0;
            string sDate1, sDate2;

            COM.ComFunction MyComFunction = new COM.ComFunction();
            DateTime CurDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));


            arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            arg_cmb.ClearItems();
            arg_cmb.ExtendRightColumn = true;
            arg_cmb.ColumnHeaders = false;
            arg_cmb.SelectedIndex = -1;



            arg_cmb.AddItem("ALL");



            switch (arg_type)
            {
                case "OR":
                    for (i = -1; i <= 1; i++)
                        //arg_cmb.AddItem( CurDate.AddYears(i).Year.ToString("yyyy-MM-dd").Substring(2,2) + "0605");
                        arg_cmb.AddItem(CurDate.AddYears(i).ToString("yyyy-MM-dd").Substring(2, 2) + "0605");


                    break;

                case "SS":
                case "PS":
                    for (i = -1; i <= 1; i++)
                        //arg_cmb.AddItem( CurDate.AddYears(i).Year.ToString("yyyy-MM-dd").Substring(2,2) + "0112");
                        arg_cmb.AddItem(CurDate.AddYears(i).ToString("yyyy-MM-dd").Substring(2, 2) + "0112");

                    // arg_cmb.SelectedIndex = 1;
                    break;

                case "TS":
                case "TP":
                //				case "ID" :
                //					for(i = -7; i <= 3; i++)					
                //					{					
                //						sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");						
                //						sDate1 = sDate1.Substring(2,2) + sDate1.Substring(5,2) + "01";
                //
                //						arg_cmb.AddItem(sDate1);
                //					}
                //
                //					arg_cmb.SelectedIndex = 3;													
                //					break;		

                case "QQ":

                    for (i = -3; i <= 3; i++)
                    {
                        sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");
                        sDate2 = CurDate.AddMonths(i + 1).ToString("yyyy-MM-dd");

                        sDate1 = sDate1.Substring(2, 2) + sDate1.Substring(5, 2) + sDate2.Substring(5, 2); ;

                        arg_cmb.AddItem(sDate1);
                    }

                    //arg_cmb.SelectedIndex = 3;
                    break;

                default:
                    for (i = -7; i <= 3; i++)
                    {
                        sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");
                        sDate2 = CurDate.AddMonths(i + 2).ToString("yyyy-MM-dd");

                        sDate1 = sDate1.Substring(2, 2) + sDate1.Substring(5, 2) + sDate2.Substring(5, 2);

                        arg_cmb.AddItem(sDate1);
                    }


                    //arg_cmb.SelectedIndex = 5;
                    break;
            }

            arg_cmb.MaxDropDownItems = Convert.ToInt16(arg_cmb.ListCount);
            arg_cmb.SelectedIndex = 0;
        }

        /// <summary>
        /// SELECT_MATPRICE_COMBO_FACTORY : 
        /// </summary>
        /// <returns></returns>
        public static DataTable SELECT_MATPRICE_COMBO_FACTORY()
        {
            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();


                MyOraDB.ReDim_Parameter(1);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EFI_BEP_SIMULATION.SELECT_FACTORY_LIST";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = "";


                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];


            }
            catch
            {
                return null;
            }

        }

        /// <summary>
        /// SELECT_MATPRICE_COMBO_YEAR : 
        /// </summary>
        /// <param name="arg_factory"></param>
        /// <param name="arg_poweruser_yn"></param>
        /// <returns></returns>
        public static DataTable SELECT_MATPRICE_COMBO_YEAR(string arg_factory, string arg_poweruser_yn)
        {
            try
            {


                COM.OraDB MyOraDB = new COM.OraDB();


                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EMM_PRICE_SEARCH.SELECT_COMBO_YEAR";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_POWERUSER_YN";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_poweruser_yn;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];


            }
            catch
            {
                return null;
            }

        }

        #endregion
    }



}