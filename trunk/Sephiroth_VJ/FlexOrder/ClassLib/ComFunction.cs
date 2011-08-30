//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
//using System.Data;
//using C1.Win.C1FlexGrid;  
//using System.Data.OleDb;
//using Microsoft.Office.Core;
//using Lassalle.Flow;
//using System.IO;

using System;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 
//using FarPoint.Win.Spread;
using Lassalle.Flow; 
using System.Data.OleDb;
using Microsoft.Office.Core; 
using System.IO;



namespace FlexOrder.ClassLib
{
	/// <summary>
	/// Common_Function에 대한 요약 설명입니다.
	/// </summary>
	public class ComFunction : COM.ComFunction
	{
		public ComFunction()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		//		/// <summary>
		//		/// Select_Factory_List : Factory 조회
		//		/// </summary>
		//		/// <returns></returns>
		//		public static DataTable Select_Factory_List()
		//		{
		//			DataTable dt_list; 
		//
		//			COM.ComVar.ReDim_Parameter(1);
		//
		//			COM.ComVar.Process_Name = "PKG_SPB_RSC.SELECT_FACTORY_LIST";
		// 
		//			COM.ComVar.Parameter_Name[1] = "OUT_CURSOR"; 
		//			COM.ComVar.Parameter_Type[1] = 9; 
		//			COM.ComVar.Parameter_Values[1] = "";
		//
		//			dt_list = COM.ComVar.WebService.Oracle_Select_Procedure(COM.ComVar.Process_Name, COM.ComVar.Parameter_Name, COM.ComVar.Parameter_Type, COM.ComVar.Parameter_Values).Tables[0];
		//
		//			return dt_list;
		//
		//		}


 
 
		/// <summary>
		/// Save_List : 리스트 저장
		/// </summary>
		/// <param name="arg_para_count">파라미터 개수</param>
		/// <param name="arg_proc_name">프로세스 이름</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		//		public static void Save_List(int arg_para_count, string arg_proc_name, C1FlexGrid arg_fgrid, int arg_rowfixed)
		//		{
		//			int i, j, k = 0;
		//			int row_count = 0;
		//
		//			ClassLib.ComVar.ReDim_Parameter(arg_para_count);
		//
		//			ClassLib.ComVar.Process_Name = arg_proc_name;
		//
		//			ClassLib.ComVar.Parameter_Name[1] = "ARG_DIVISION";
		// 
		//			for(i = 2; i <= arg_fgrid.Cols.Count; i++)
		//			{
		//				ClassLib.ComVar.Parameter_Name[i] = "ARG_" + arg_fgrid[0, i - 1].ToString(); 
		//			}
		//
		//			/////////////////////////////////////////////////////////////////////////
		//			for(i = 1; i <= arg_para_count; i++)
		//			{
		//				ClassLib.ComVar.Parameter_Type[i] = 1; 
		//			}						  
		//
		//			/////////////////////////////////////////////////////////////////////////
		//			for(i = arg_rowfixed; i < arg_fgrid.Rows.Count; i++)
		//			{
		//				if(arg_fgrid[i, 0].ToString() != "")
		//				{
		//					row_count += 1;
		//				}
		//			}
		//
		//
		//			ClassLib.ComVar.Parameter_Matrix = new string[arg_para_count * row_count + 1];
		//
		//			for(i = arg_rowfixed; i < arg_fgrid.Rows.Count; i++)
		//			{
		//				if(arg_fgrid[i, 0].ToString() != "")
		//				{ 
		//					for(j = 0; j < arg_fgrid.Cols.Count - 1; j++)
		//					{
		//						ClassLib.ComVar.Parameter_Matrix[j + 1 + k] = (arg_fgrid[i, j] == null) ? "" : arg_fgrid[i, j].ToString();
		//
		//						//------------------------------------------------------------------
		//						//저장 데이터값 수정
		//						if(arg_fgrid.Cols[j].DataType == Type.GetType("System.Boolean"))
		//						{
		//							if(arg_fgrid[i, j] == null) arg_fgrid[i, j] = "False";
		//
		//							ClassLib.ComVar.Parameter_Matrix[j + 1 + k] = (arg_fgrid[i, j].ToString() == "True") ? "Y" : "N"; 
		//						}
		//					
		//						//------------------------------------------------------------------
		//						
		//					} 
		//					ClassLib.ComVar.Parameter_Matrix[j + k]     = ClassLib.ComVar.This_User; 
		//					ClassLib.ComVar.Parameter_Matrix[j + 1 + k] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		//
		//					k += arg_para_count; 
		//				}
		//				
		//
		//			}
		//  
		//			ClassLib.ComVar.Result = ClassLib.ComVar.WebService.Oracle_Run_Matrix_Procedure(ClassLib.ComVar.Process_Name, ClassLib.ComVar.Parameter_Name, ClassLib.ComVar.Parameter_Type, ClassLib.ComVar.Parameter_Matrix);
		//
		//			if(Convert.ToString(ClassLib.ComVar.Result) == "1")
		//			{
		//				MessageBox.Show("저장했습니다");
		//			}
		// 
		// 
		//		}

		////////////// 공백 처리 함수들 ////////////////
		
		/// <summary>
		/// Combo 선택된 항목이 없는경우 리턴값
		/// </summary>
		/// <param name="sCombo">해당 ComboList</param>
		/// <param name="sReturn">공백일때 리턴값</param>
		/// <returns>리턴값</returns>
		//		public static string Empty_Combo(C1.Win.C1List.C1Combo arg_Cmb,string arg_Ret)
		//		{
		//			if (arg_Cmb.SelectedIndex == -1 )
		//			{
		//				return arg_Ret;
		//			}
		//			else
		//			{
		//				return arg_Cmb.SelectedValue.ToString();
		//			}
		//		}

		/// <summary>
		/// TextBox가 공백일때 변환 값
		/// </summary>
		/// <param name="arg_Txt">해당 TextBox</param>
		/// <param name="arg_Ret">공백일때 리턴값</param>
		/// <returns>리턴값</returns>
		//		public static string Empty_TextBox(TextBox arg_Txt,string arg_Ret)
		//		{
		//			if (arg_Txt.Text.Trim() == "" )
		//			{
		//				return arg_Ret;
		//			}
		//			else
		//			{
		//				return arg_Txt.Text.Trim();
		//			}
		//		}


		/// <summary>
		/// 문자열이 공백이면 변환 값
		/// </summary>
		/// <param name="arg_Str">해당 문자열 변수</param>
		/// <param name="arg_Ret">공백일때 리턴값</param>
		/// <returns>리턴값</returns>
		//		public static string Empty_String(string arg_Str,string arg_Ret)
		//		{
		//			if (arg_Str.Trim() == "" )
		//			{
		//				return arg_Ret;
		//			}
		//			else
		//			{
		//				return arg_Str.Trim();
		//			}
		//		}

		/// <summary>
		/// 숫자값이 공백이면 변환 값
		/// </summary>
		/// <param name="arg_Num">해당 숫자변수</param>
		/// <param name="arg_Ret">공백일때 리턴값</param>
		/// <returns></returns>
		//		public static int Empty_Number(string arg_Num,string arg_Ret)
		//		{
		//			if (arg_Num.Trim() == "" )
		//			{
		//				return Convert.ToInt32(arg_Ret);
		//			}
		//			else
		//			{
		//				return Convert.ToInt32(arg_Num.Trim());
		//			}
		//		}


		////////////// 텍스트 박스 숫자만 처리 ////////////////
		
		/// <summary>
		/// TextBox에 숫자만 허용됨
		/// </summary>
		/// <param name="arg_Text">대상 TextBox</param>
		/// <param name="arg_limit">숫자 허용 자리수</param>
		//		public static void Set_NumberTextBox(TextBox arg_Text,int arg_limit)
		//		{
		//			
		//			if (arg_Text.Text.Trim() == "")			//공백이면 0
		//			{
		//				arg_Text.Text = "0";
		//			}
		//			else 
		//			{
		//				for (int i=0;i < arg_Text.Text.Length ;i++)
		//				{
		//					if (Char.IsNumber(arg_Text.Text,i) == false)
		//					{
		//						MessageBox.Show("Only number data is allowed !!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
		//						arg_Text.Text = arg_Text.Text.Substring(0,i);
		//						arg_Text.Focus();
		//						return;
		//					}
		//				}
		//			}
		//			
		//			if(arg_Text.Text.Length > arg_limit)
		//			{
		//				MessageBox.Show("Too many number( " +arg_limit.ToString() + " digit is allowed) !!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning) ;
		//				arg_Text.Text = arg_Text.Text.Substring(0,arg_limit);
		//				return;
		//			}
		//
		//		}

		/// <summary>
		/// Set_OBSID_CmbList : OBS TYPE별 OBS ID 생성 및 콤보리스트에 추가
		/// </summary>
		/// <param name="arg_type">선택된 OBS Type</param>
		/// <param name="arg_cmb">적용 대상 콤보 박스명</param>
		public static void Set_OBSID_CmbList(string arg_type , C1.Win.C1List.C1Combo arg_cmb)
		{ 
			int i=0; 
			string sDate1, sDate2;

			COM.ComFunction MyComFunction    = new COM.ComFunction();
			DateTime CurDate  =  Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));


			arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			arg_cmb.ClearItems();
			arg_cmb.ExtendRightColumn = true;
			arg_cmb.ColumnHeaders = false;
			arg_cmb.SelectedIndex = -1;
			
			switch(arg_type)       
			{         
				case "OR" :
					for(i = -1; i <= 1; i++)
						//arg_cmb.AddItem( CurDate.AddYears(i).Year.ToString("yyyy-MM-dd").Substring(2,2) + "0605");
						arg_cmb.AddItem( CurDate.AddYears(i).ToString("yyyy-MM-dd").Substring(2,2) + "0605");
							
					arg_cmb.SelectedIndex = 1;					
					break;					
						
				case "SS" : 
				case "PS" :
					for(i = -1; i <= 1; i++)
						//arg_cmb.AddItem( CurDate.AddYears(i).Year.ToString("yyyy-MM-dd").Substring(2,2) + "0112");
						arg_cmb.AddItem( CurDate.AddYears(i).ToString("yyyy-MM-dd").Substring(2,2) + "0112");

					arg_cmb.SelectedIndex = 1;																					
					break;
				
				case "TS" :
				case "TP" :
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

				case "QQ" :            

					for(i = -3; i <= 3; i++)					
					{					
						sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");						
						sDate2 = CurDate.AddMonths(i+1).ToString("yyyy-MM-dd");
					
						sDate1 = sDate1.Substring(2,2) + sDate1.Substring(5,2) + sDate2.Substring(5,2);;

						arg_cmb.AddItem(sDate1);
					}

					arg_cmb.SelectedIndex = 3;													
					break;					

				default:            
					for(i = -7; i <= 6; i++)										
					{
						sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");						
						sDate2 = CurDate.AddMonths(i+2).ToString("yyyy-MM-dd");
						
						sDate1 = sDate1.Substring(2,2) + sDate1.Substring(5,2) + sDate2.Substring(5,2);						

						arg_cmb.AddItem(sDate1);
					}
						
						
					arg_cmb.SelectedIndex = 5;																
					break;
			}

			arg_cmb.MaxDropDownItems = Convert.ToInt16(arg_cmb.ListCount);		 	 
		}


		/// <summary>
		/// Read DBF file
		/// </summary>
		/// <param name="arg_dtsrc">data source</param>
		/// <param name="arg_sql">sql string</param>
		public static OleDbDataReader Read_DBF(string arg_dtsrc, string arg_sql)
		{
			OleDbConnection AdoConn = null;		
			OleDbDataReader reader  = null;

			string strConn =@"Provider=VFPOLEDB.1;Data Source="+arg_dtsrc+";"; 
			AdoConn = new OleDbConnection(strConn);
			AdoConn.Close();
			AdoConn.Open();
				
			string AdoSQL= arg_sql; 
			
			OleDbCommand Cmd = new OleDbCommand(AdoSQL, AdoConn);               
			reader= Cmd.ExecuteReader();

			return reader; 			
		}


		/// <summary>
		/// Read MS-SQL Server
		/// </summary>
		/// <param name="arg_dtsrc">data source</param>
		/// <param name="arg_sql">sql string</param>
		public static OleDbDataReader Read_MSSQL(string arg_sql, string arg_dtsrc, string arg_id, string arg_pw)
		{
			OleDbConnection AdoConn = null;		
			OleDbDataReader reader  = null;

			string MSSQLCon;

			if (arg_pw.Length == 0)
				MSSQLCon=@"Provider=SQLOLEDB.1;Data Source="+arg_dtsrc+";User ID="+arg_id+";Persist Security Info=False;Initial Catalog=MercuryFFSdb";
			else
				MSSQLCon=@"Provider=SQLOLEDB.1;Data Source="+arg_dtsrc+";User ID="+arg_id+";Password="+arg_pw+";Persist Security Info=False;Initial Catalog=MercuryFFSdb";
		
			AdoConn = new OleDbConnection(MSSQLCon);
			AdoConn.Close();
			AdoConn.Open();

			string AdoSQL= arg_sql; 

			OleDbCommand Cmd = new OleDbCommand(AdoSQL, AdoConn);               
			reader= Cmd.ExecuteReader();

			return reader; 			
		}



		/// <summary>
		/// Read Excel file
		/// </summary>
		/// <param name="arg_dtsrc">data source</param>
		/// <param name="arg_sql">sql string</param>
		public static OleDbDataReader Read_Excel(string arg_dtsrc, string arg_sql)
		{
			OleDbConnection AdoConn = null;		
			OleDbDataReader reader  = null;

			string ExcelCon=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+arg_dtsrc+";Excel 8.0;Imex=1;HDR=YES";
			//string ExcelCon=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+arg_dtsrc+";Excel 8.0;HDR=YES";

			AdoConn = new OleDbConnection(ExcelCon);
			AdoConn.Close();
			AdoConn.Open();

			string AdoSQL= arg_sql; 

			OleDbCommand Cmd = new OleDbCommand(AdoSQL, AdoConn);               
			reader= Cmd.ExecuteReader();

			return reader; 			
		}

		/// <summary>
		/// Data Type 체크
		/// </summary>
		/// <param name="arg_type">Field Type</param>
		/// <param name="arg_data">Data</param>
		/// <returns>string</returns>
		public static string Convert_dtType(string arg_type, string arg_data)
		{
			switch(arg_type)       
			{         
				case "DateTime" :
					return arg_data.Substring(0, 4) + arg_data.Substring(5, 2) + arg_data.Substring(8, 2);
						
				case "Boolean" :
					return arg_data.Substring(0, 1);		
				
				default:            
					return arg_data.Trim();
			}
		}

		/// <summary>
		/// Row_Tag : 해당row의 서브 레코드 유무
		/// </summary>
		/// <param name="arg_row">이벤트 발생 Row</param>
		/// <param name="arg_col">이벤트 발생 Col</param>
		public static void Tag_Row(C1FlexGrid arg_fgrid, int arg_row)
		{					
			try
			{
				arg_fgrid[arg_row, (int)ClassLib.TBSEM_POI.lxFlag] = 
					(arg_fgrid[arg_row, (int)ClassLib.TBSEM_POI.lxFlag] == null) ? "" : arg_fgrid[arg_row, 0].ToString();

				arg_fgrid[arg_row, (int)ClassLib.TBSEM_POI.lxFlag] = 
					(arg_fgrid[arg_row, (int)ClassLib.TBSEM_POI.lxFlag].ToString() == ClassLib.ComVar.FlagPlus) ? ClassLib.ComVar.FlagMinus : 
					ClassLib.ComVar.FlagPlus;
			}
			catch (Exception eMessage)
			{
				MessageBox.Show("Exception caught : " + eMessage);
			}
		}

		/// <summary>
		/// Set_Tag_Image : FlexGrid에 Set Action Image (P, M)
		/// </summary>
		/// <param name="arg_imglist">이미지 리스트</param>
		public static void Set_Tag_Image(C1FlexGrid arg_fgrid, ImageList arg_imglist)
		{
			Hashtable Imgmap = new Hashtable();
			Imgmap.Clear();

			Imgmap.Add(ClassLib.ComVar.FlagPlus,  arg_imglist.Images[0]); 
			Imgmap.Add(ClassLib.ComVar.FlagMinus, arg_imglist.Images[1]);

			arg_fgrid.Cols[0].ImageMap = Imgmap;
		}

		/// <summary>
		/// Convert_ToDate
		/// </summary>
		/// <param name="arg_type">Field Type</param>
		/// <param name="arg_data">Data</param>
		/// <returns>string</returns>
		public static DateTime Convert_ToDate(string arg_date)
		{
			return Convert.ToDateTime(arg_date.Substring(0,4)+"-"+arg_date.Substring(4,2)+"-"+arg_date.Substring(6,2));		
		}


		/// <summary>
		/// Excel 자료 Grid에 뿌리기 
		/// </summary>
		/// <param name="arg_Source">Data Source</param>
		/// <param name="arg_SQL"> Query Statement</param>
		/// <returns> Data Table</returns>
		public static bool Set_ExcelToGrid(string arg_Source, string arg_SQL,  C1FlexGrid arg_fgrid )
		{

			string ExcelCon=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+arg_Source+";Excel 8.0;HDR=YES" ;
			//		string ExcelCon=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=arg_Source;Extended Properties=""Excel 8.0;HDR=YES""" ;
			OleDbConnection ExcelConn=new OleDbConnection(ExcelCon);

			try
			{
				DataTable dt_list; 
				ExcelConn.Open();
				OleDbCommand ExcelCom;          
				string ExcelSQL = arg_SQL;
				ExcelCom=new OleDbCommand(ExcelSQL,ExcelConn);   
				OleDbDataReader read  = ExcelCom.ExecuteReader();

				dt_list = read.GetSchemaTable();
				
				arg_fgrid.DataSource = null;
				int row = 1;
				arg_fgrid.Redraw = false;

				//set data in grid
				while (read.Read())
				{
					arg_fgrid.Rows.Add();
					for (int i = 0; i < read.FieldCount; i++)
						arg_fgrid[row+1, i+1] = read.GetValue(i).ToString();
					arg_fgrid[row+1, 0] = "I";
					row++;
				}

				read.Close();
				arg_fgrid.Redraw = true;
				arg_fgrid.AutoSizeCols();
				return true;
				
			}
			catch(Exception Ex)
			{
				MessageBox.Show(Ex.ToString());
				return false;
				
			}
			finally
			{
				ExcelConn.Close();
				
			}
		}



	
		/// <summary>
		/// Sizerun 자료 Grid에 가로로 뿌리기
		/// </summary>
		/// <param name="arg_fix_row">시작row</param>
		/// <param name="arg_fix_col">시작col</param>
		/// <param name="arg_list"> 사이즈런 리스트 (한개 Gender)</param>
		/// <param name="arg_fgrid"> 대상 그리드</param>
		/// <returns> Data Table</returns>
		//		public static void Set_SizeToGrid(int arg_fix_row, int arg_fix_col,  DataTable arg_list, C1FlexGrid arg_fgrid )
		//		{
		//			arg_fgrid.Cols.Count = arg_list.Rows.Count + arg_fix_col; 
		//		
		//			for(int i=0; i < arg_list.Rows.Count; i++)
		//			{   
		//				arg_fgrid[arg_fix_row,i+arg_fix_col] = arg_list.Rows[i].ItemArray[0].ToString();
		//				arg_fgrid.Cols[i+arg_fix_col].Width=40;
		//			} 
		//
		//		}


		/// <summary>
		/// Sizerun Head 가로로 뿌리기
		/// </summary>
		/// <param name="arg_fix_row">시작row</param>
		/// <param name="arg_fix_col">시작col</param>
		/// <param name="arg_list"> 사이즈런 리스트 (한개 Gender)</param>
		/// <param name="arg_fgrid"> 대상 그리드</param>
		/// <returns> Data Table</returns>
		public static void Set_SizeHeadToGrid(int arg_fix_row, int arg_fix_col,  DataTable arg_list, C1FlexGrid arg_fgrid )
		{
			arg_fgrid.Cols.Count = arg_list.Rows.Count + arg_fix_col; 
		
			for(int i=0; i < arg_list.Rows.Count; i++)
			{   
				arg_fgrid[arg_fix_row,i+arg_fix_col] = arg_list.Rows[i].ItemArray[0].ToString();
				arg_fgrid.Cols[i+arg_fix_col].Width=40;
			} 

		}

		/// <summary>
		/// SizerunData Grid 가로로 뿌리기
		/// </summary>
		/// <param name="arg_row">사이즈런 뿌릴 Row</param>
		/// <param name="arg_fix_row">사이즈런 헤드 시작 Row</param>
		/// <param name="arg_fix_col">사이즈런 헤드 시작 Col</param>
		/// <param name="arg_list"> 조회데이타 사이즈</param>
		/// <param name="arg_fgrid"> 조회데이타 수량</param>
		/// <returns> Data Table</returns>
		public static void Set_SizeDataToGrid(int arg_row, int arg_fix_row, int arg_fix_col, 
			string arg_size, string arg_size_qty, C1FlexGrid arg_fgrid )
		{
			for (int i=arg_fix_col ; i < arg_fgrid.Cols.Count  ;i++)
			{ 
				if (arg_fgrid[arg_fix_row,i].ToString() == arg_size)  //Size 위치
				{
					arg_fgrid[arg_row,i] = arg_size_qty; 
				}
			}
		}



		/// <summary>
		/// 년도 Setting
		/// </summary>
		/// <param name="arg_cmb">대상 콤보</param>
		/// <returns> 없음</returns>
		public static void Set_Year(C1.Win.C1List.C1Combo arg_cmb)
		{
			DateTime CurDate  = DateTime.Now;

			arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			arg_cmb.ClearItems();
			arg_cmb.ExtendRightColumn = true;
			arg_cmb.ColumnHeaders = false;
			for(int  i = -2; i <= 2; i++)
				arg_cmb.AddItem( CurDate.AddYears(i).Year.ToString());
			arg_cmb.SelectedIndex = 2;
			arg_cmb.MaxDropDownItems = Convert.ToInt16(arg_cmb.ListCount);

			arg_cmb.SelectedIndex = -1;

		}


		
		/// <summary>
		/// Set_ComboList : DataTable의 내용을 콤보리스트에 추가
		/// </summary>
		/// <param name="dtcmb_list">콤보 박스에 추가될 리스트</param>
		/// <param name="arg_cmb">적용 대상 콤보 박스명</param>
		/// <param name="arg_cd_ix">코드로 사용될 필드 인덱스</param>
		/// <param name="arg_name_ix">코드명으로 사용될 필드 인덱스</param>
		/// <param name="arg_emptyrow">상단에 공백 넣을지 여부</param> 
		/// <param name="arg_visible">보여줄 컬럼 선택</param>
		public static void Set_Factory_List(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_ix, int arg_name_ix, bool arg_emptyrow, COM.ComVar.ComboList_Visible arg_visible)
		{ 

			DataTable temp_datatable= new DataTable("Combo List"); 
			DataRow newrow; 
  
 
			try 
			{
				
				temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
				temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
 
				if(arg_emptyrow)
				{
					newrow = temp_datatable.NewRow();
					newrow["Code"] = " ";
					newrow["Name"] = "ALL";
					temp_datatable.Rows.Add(newrow);
				}

				for(int i = 0 ; i < dtcmb_list.Rows.Count; i++)
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
				arg_cmb.Splits[0].DisplayColumns["Code"].Width = 50;
				arg_cmb.Splits[0].DisplayColumns["Name"].Width = 150;
				arg_cmb.ExtendRightColumn = true; 
				arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
 
				switch(arg_visible)
				{
					case COM.ComVar.ComboList_Visible.Code:
						arg_cmb.Splits[0].DisplayColumns["Name"].Visible = false;
						arg_cmb.DisplayMember = "Code";
						break;

					case COM.ComVar.ComboList_Visible.Name:
						arg_cmb.Splits[0].DisplayColumns["Code"].Visible = false;
						break;

						//case COM.ComVar.ComboList_Visible.Code_Name:
						//break;
				}

				if (ClassLib.ComVar.This_Factory !="DS") 
				{ arg_cmb.ReadOnly = true; arg_cmb.Enabled = false;}

			}
			catch
			{
				//MessageBox.Show(ex.Message.ToString(),"Set_ComboList",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}


 
		}


		/// <summary>
		/// Subtotla 만들기
		/// </summary>
		/// <param name="arg_tree_col">Tree Col</param>
		/// <param name="arg_position">SubtotalPosition</param>
		/// <returns> 없음</returns>
		public static void Set_GrandTotal_Env(Color arg_color, int arg_tree_col, 
			int arg_postion, C1FlexGrid arg_fgrid )
		{
			CellStyle cStyle = arg_fgrid.Styles[CellStyleEnum.Subtotal0];
			cStyle.BackColor = arg_color;
			cStyle.Font = new Font(arg_fgrid.Font, FontStyle.Regular);
			arg_fgrid.Tree.Column = arg_tree_col;
 
			if (arg_postion == 1 )
			{
				arg_fgrid.SubtotalPosition =SubtotalPositionEnum.BelowData;
			}
			else
			{
				arg_fgrid.SubtotalPosition =SubtotalPositionEnum.AboveData;
			}

			arg_fgrid.Subtotal(AggregateEnum.Clear);
			
		}



		/// <summary>
		/// Set_Size_Grid : Gender별 Size run을 헤드에 Display
		/// </summary>
		/// <param name="dtcmb_list">작업 그리드</param>
		/// <param name="arg_cmb">Head row count</param>		
		public static void Set_Size_Grid(C1FlexGrid arg_fgrid, int arg_fixrow, int arg_lxGEN)
		{ 		
            
			ClassLib.OraDB  MyOraDB = new ClassLib.OraDB();

			DataTable dt_list;

			arg_fgrid.Rows.Count = arg_fixrow;

			for (int i=1; i<arg_fgrid.Cols.Count-1; i++)
				for (int j=arg_fgrid.Rows.Fixed; j<=arg_fixrow-1; j++)
					arg_fgrid[j, i] = arg_fgrid[arg_fgrid.Rows.Fixed-1, i].ToString();

			arg_fgrid.Rows.Fixed = arg_fixrow;

			//Gender별 Size정보를 읽어온다(SEM_SIZE)
			dt_list = MyOraDB.Select_Size_List();

			// Set List
			int iRow = 0;
			int iCol = 0;
			for(int i=0; i<dt_list.Rows.Count; i++)
			{
				int    dt_Row  = Convert.ToInt32(dt_list.Rows[i].ItemArray[2].ToString());
				string dt_Gen  = dt_list.Rows[i].ItemArray[0].ToString();
				string dt_Size = dt_list.Rows[i].ItemArray[1].ToString();

				if (iRow != dt_Row) 
				{
					iRow = dt_Row;
					iCol = arg_lxGEN;
					arg_fgrid[iRow, iCol] = dt_Gen;
					arg_fgrid.Cols[iCol].Width = 40;
					arg_fgrid.Rows[iRow].TextAlign = TextAlignEnum.CenterCenter;
				}
				iCol++;



				if (arg_fgrid.Cols.Count-1 < iCol)
					arg_fgrid.Cols.Count++;

				arg_fgrid[iRow, iCol] = dt_Size;
				arg_fgrid.Cols[iCol].Width = 40;
				arg_fgrid.Cols[iCol].TextAlign = TextAlignEnum.GeneralCenter;
			}		
	
			//merge
			arg_fgrid.AllowMerging = AllowMergingEnum.Free;
			for (int j=(int)arg_lxGEN  ; j<=arg_fgrid.Cols.Count -1;j++)
				arg_fgrid.Cols[j].AllowMerging = false;

			
		}


		

		/// <summary>
		/// Set_BPNO_CmbList : Lasting Week 생성 및 콤보박스 추가
		/// </summary>
		/// <param name="dtcmb_list">작업 그리드</param>
		/// <param name="arg_cmb">Head row count</param>		
		public static void Set_BPNO_CmbList(C1.Win.C1List.C1Combo arg_cmb)
		{ 						
			DateTime CurDate = DateTime.Now;
			DateTime sSunday;

			arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			arg_cmb.ClearItems();
			arg_cmb.ExtendRightColumn = true;
			arg_cmb.ColumnHeaders = false;

			for(int i=-6; i<=0; i++)
				if ((int)CurDate.AddDays(i).DayOfWeek == 0)
				{	
					sSunday = CurDate.AddDays(i);
					arg_cmb.AddItem(sSunday.ToString("yyyyMMdd"));
					for(int j=1; j<=10; j++)
					{
						arg_cmb.AddItem(sSunday.AddDays(-7).ToString("yyyyMMdd"));
						sSunday = sSunday.AddDays(-7);
					}
					break;
				}				
			

			arg_cmb.MaxDropDownItems = Convert.ToInt16(arg_cmb.ListCount);			
			arg_cmb.AllowSort = true;

		}


		public static void Clear_AddFlow(Lassalle.Flow.AddFlow arg_addflow)
		{
			arg_addflow.Items.Clear();
			arg_addflow.ResetDefNodeProp();
			arg_addflow.ResetDefLinkProp();
			arg_addflow.ResetGrid();
			arg_addflow.ResetText();
			//			ComFunction.Set_DefNodeProp(arg_addflow);

			arg_addflow.Grid.Draw = true;
			arg_addflow.Grid.Snap = true;
			arg_addflow.Grid.Style = GridStyle.DottedLines;
			arg_addflow.Grid.Color = Color.Silver;

		}

		/// <summary>
		/// Font string 분리해서 Font 스타일 만들기
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
				return new Font("Verdana", 9);
			} 
			
		}




		/// <summary>
		/// Print용 Text File만들기
		/// </summary>
		/// <param name="arg_filenam">Text File명</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		/// <param name="arg_rowfixed">추출 시작 로우</param>/// 
		/// <param name="arg_filtercol">추출  검증 필터 칼럼</param>
		/// <param name="arg_datalen">추출비교 기준</param>
		public static void PrintBaseFile(string arg_filename,  C1FlexGrid arg_fgrid, 
			int arg_rowfixed, int arg_filtercol, int arg_datalen)
		{  		
			FileInfo file = new FileInfo( Application.StartupPath + @"\"+ arg_filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}
			file = null;

			FileStream sDatalist = new FileStream(arg_filename , FileMode.Create, FileAccess.Write);
			StreamWriter sw = new StreamWriter(sDatalist);
            
			
			for (int i  = arg_rowfixed ; i<arg_fgrid.Rows.Count ; i++)
			{
				string sData = " ";

				if (arg_fgrid[i,arg_filtercol] == null)  continue;

				if (arg_fgrid[i,arg_filtercol].ToString().Length < arg_datalen)  continue;

				for(int j = 0 ; j<arg_fgrid.Cols.Count ;j++)
				{
					if (arg_fgrid[i,j]==null) 
						sData  = sData + "@" ;
					else
						sData  = sData + arg_fgrid[i,j].ToString() + "@";
				}
				sw.WriteLine(sData);
				//sw.Flush();
			}
	
			//sw.Write(sData);
			sw.Flush();
			sw.Close();
			sDatalist.Close();
			//------------------- ------------------------------------------------------------
		}



		/// Print용 Text File만들기
		/// </summary>
		/// <param name="arg_filenam">Text File명</param>
		/// <param name="arg_Data">Data Array </param>
		/// arg_data[i] ==> data1@data2@data  ==>textFile의 Row단위
		public static void PrintFile(string arg_filename,  string[] arg_Data)
		{  		
			FileInfo file = new FileInfo( Application.StartupPath + @"\"+ arg_filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}
			file = null;

			FileStream sDatalist = new FileStream(arg_filename , FileMode.Create, FileAccess.Write);
			StreamWriter sw = new StreamWriter(sDatalist);
            		
			for (int i  = 0 ; i<arg_Data.Length ; i++)
			{
				string sData =arg_Data[i];
				sw.WriteLine(sData);
			}
	
			sw.Flush();
			sw.Close();
			sDatalist.Close();
		}

	
		/// Grid Head 글꼴
		/// </summary>
		/// <param name="arg_flag">구분자</param>
		/// <param name="arg_fgrid">그리드명</param>
		/// <param name="arg_rowfixed">고정 Row위치</param>				
		/// <param name="arg_gen_col">Gender Col</param>
		public static void Set_Head_Bold(string  arg_flag, C1FlexGrid arg_fgrid, int arg_rowfixed, int arg_gen_col)
		{  		

			CellStyle cStyle = arg_fgrid.Styles[CellStyleEnum.Search];
			cStyle.Font = new Font(arg_fgrid.Font , FontStyle.Bold);
			
			arg_fgrid.GetCellRange(0,0, arg_rowfixed-1,arg_gen_col-1).StyleNew.Font 
				=  cStyle.Font;

			//자동 ME Setting
			arg_fgrid.GetCellRange(1,arg_gen_col+1,1,arg_fgrid.Cols.Count -1).StyleNew.BackColor  
				=  ClassLib.ComVar.Clr_Head_Crimson;

			arg_fgrid.GetCellRange(1,arg_gen_col, arg_rowfixed-1,arg_gen_col).StyleNew.BackColor 
				=  ClassLib.ComVar.Clr_Head_Crimson;			



		}

		/// Gender별 Head 색상변경
		/// </summary>
		/// <param name="arg_flag">구분자</param>
		/// <param name="arg_fgrid">그리드명</param>
		/// <param name="arg_rowfixed">고정 Row위치</param>				
		/// <param name="arg_sel_row">선택된 Row위치</param>
		/// <param name="arg_gen_col">Gender Col</param>
		public static void Set_Gen_Color(string  arg_flag, C1FlexGrid arg_fgrid, int arg_rowfixed, int arg_sel_row,  int arg_gen_col)
		{  		
			int iRow = arg_sel_row;

			if(arg_fgrid[iRow ,arg_gen_col] == null) return;

			for (int i =0; i<arg_rowfixed; i++)
			{
				arg_fgrid.GetCellRange(i,arg_gen_col+1,i,arg_fgrid.Cols.Count -1).StyleNew.BackColor  
					=  ClassLib.ComVar.Clr_Grid_Base;

			}

			arg_fgrid.GetCellRange(1,arg_gen_col,arg_rowfixed-1,arg_gen_col).StyleNew.BackColor 
				=  ClassLib.ComVar.Clr_Head_Crimson;
			
								
			if(arg_fgrid[iRow ,arg_gen_col].ToString() ==ClassLib.ComVar.ConsME)
				arg_fgrid.GetCellRange(ClassLib.ComVar.ConsPosME,arg_gen_col+1,ClassLib.ComVar.ConsPosME ,arg_fgrid.Cols.Count -1).StyleNew.BackColor 
					=  ClassLib.ComVar.Clr_Head_Crimson;

			if(arg_fgrid[iRow ,arg_gen_col].ToString() ==ClassLib.ComVar.ConsWO)
				arg_fgrid.GetCellRange(ClassLib.ComVar.ConsPosWO,arg_gen_col+1,ClassLib.ComVar.ConsPosWO,arg_fgrid.Cols.Count -1).StyleNew.BackColor 
					=  ClassLib.ComVar.Clr_Head_Crimson;

			if(arg_fgrid[iRow ,arg_gen_col].ToString() ==ClassLib.ComVar.ConsGS)
				arg_fgrid.GetCellRange(ClassLib.ComVar.ConsPosGS,arg_gen_col+1,ClassLib.ComVar.ConsPosGS,arg_fgrid.Cols.Count -1).StyleNew.BackColor 
					=  ClassLib.ComVar.Clr_Head_Crimson;

			if(arg_fgrid[iRow ,arg_gen_col].ToString() ==ClassLib.ComVar.ConsPS)
				arg_fgrid.GetCellRange(ClassLib.ComVar.ConsPosPS,arg_gen_col+1,ClassLib.ComVar.ConsPosPS,arg_fgrid.Cols.Count -1).StyleNew.BackColor 
					=  ClassLib.ComVar.Clr_Head_Crimson;

			if(arg_fgrid[iRow ,arg_gen_col].ToString() ==ClassLib.ComVar.ConsIN)
				arg_fgrid.GetCellRange(ClassLib.ComVar.ConsPosIN,arg_gen_col+1,ClassLib.ComVar.ConsPosIN,arg_fgrid.Cols.Count -1).StyleNew.BackColor 
					=  ClassLib.ComVar.Clr_Head_Crimson;

		}


		///OBS Information 
		/// </summary>
		/// <param name="arg_real_obs">실OBS 구분</param>
		/// <param name="arg_factroy">공장구분</param>
		/// <param name="arg_obs_type">OBS Type</param>				
		/// <param name="arg_obs_id">OBS ID</param>
		/// <param name="arg_style_cd">Style Code</param>
		/// <param name="arg_obs_nu">OBS Nu</param>				
		/// <param name="arg_obs_seq_nu">OBS Seq Nu</param>
		/// <param name="arg_chg_nu">Chnage Nu</param>/// 
		public static void Sb_Pop_OBS_Info(
			string  arg_real_obs,
			string  arg_factroy,
			string  arg_obs_type,
			string  arg_obs_id,
			string  arg_style_cd,
			string  arg_obs_nu,
			string  arg_obs_seq_nu,
			string  arg_chg_nu)
		{  		
			
			FlexOrder.ExpOBS.POP_EO_INFO  pop_form = new ExpOBS.POP_EO_INFO();

			COM.ComVar.Parameter_PopUp = new string[] 
				{
					arg_real_obs,
					arg_factroy,
					arg_obs_type,
					arg_obs_id,
					arg_style_cd,
					arg_obs_nu,
					arg_obs_seq_nu,
					arg_chg_nu,
			};
			 
			pop_form.ShowDialog();

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


	}

}




