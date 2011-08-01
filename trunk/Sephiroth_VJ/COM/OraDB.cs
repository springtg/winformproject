using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 


namespace COM
{
	/// <summary>
	/// OraDB�� ���� ��� �����Դϴ�.
	/// </summary>
	public class OraDB
	{

		#region ��������

		private DataSet DS_Select = new DataSet("Parameter DataSet");
		private DataSet DS_Modify = new DataSet("Modify DataSet");
		private DataSet DS_Run = new DataSet("Run DataSet");

		private DataSet DS_Ret = new DataSet("Return DataSet");


		//------- ���ν��� ���޿� ��������
		/// <summary>
		/// SP ���μ�����
		/// </summary>
		public  string Process_Name;
		/// <summary>
		/// SP �Ķ���� �迭
		/// </summary>
		public  string[] Parameter_Name;
		/// <summary>
		/// SP �Ķ���� ���� �迭
		/// </summary>
		public  int[] Parameter_Type;
		/// <summary>
		/// SP �Ķ���� �� �迭
		/// </summary>
		public  string[] Parameter_Values;
		/// <summary>
		/// SP �Ķ���� ��Ʈ���� �迭
		/// </summary>
		public  string[] Parameter_Matrix;

		#endregion



		public OraDB()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}

		/// <summary>
		/// ReDim_Parameter : ���ν��� �⵿�� ���� ������
		/// </summary>
		/// <param name="arg_count">���� Count</param>
		public void ReDim_Parameter(int arg_count)
		{
			this.Parameter_Name = new string[arg_count]; 
			this.Parameter_Type = new int[arg_count]; 
			this.Parameter_Values = new string[arg_count] ;
		}


		/// <summary>
		/// Clear_Select_DataSet
		/// </summary>
		private void Clear_Select_DataSet()
		{
			DS_Select.Reset();
		}


		/// <summary>
		/// Clear_Run_DataSet
		/// </summary>
		private void Clear_Run_DataSet()
		{
			DS_Run.Reset();
		}


		/// <summary>
		/// Clear_Modify_DataSet
		/// </summary>
		public void Clear_Modify_DataSet()
		{
			DS_Modify.Reset();
		}


		/// <summary>
		/// Add_Select_Parameter :  ��ȸ�� ���� �̸� Setting �Ǿ��� Parameter������ DataSet�� �߰�
		/// </summary>
		/// <param name="AfterClear">������ DataSet�� Clear�ϰ� �߰�(Cleaer���� ���� ���� ������ �߰���</param>
		/// <returns>���� : true ,���� : false</returns>
		public bool Add_Select_Parameter (bool AfterClear) //string Process_Name, string[]  Parameter_Name, int[] Parameter_Type, string[] Parameter_Values)
		{
			DataTable DT_Select = new DataTable(Process_Name);
			DataColumn[] dc= new DataColumn[3];
 
			try
			{
				dc[0] = new DataColumn("Parameter_Name",Type.GetType("System.String"));
				dc[1] = new DataColumn("Parameter_Type",Type.GetType("System.Int32"));
				dc[2] = new DataColumn("Parameter_Value",Type.GetType("System.String"));
				DT_Select.Columns.AddRange(dc);

				for(int i=0; i< Parameter_Name.Length ;i++)
				{
					DataRow newRow = DT_Select.NewRow() ;
				
					newRow["Parameter_Name"] = Parameter_Name[i]; 
					newRow["Parameter_Type"] = (int)Parameter_Type[i];
					newRow["Parameter_Value"] = (Parameter_Values[i]==null) ? "": Parameter_Values[i]  ;
					DT_Select.Rows.Add(newRow);

				}
				if (AfterClear) this.Clear_Select_DataSet();
				DS_Select.Tables.Add(DT_Select);
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error: " + Process_Name + " at Add_Select_Parameter !!"+ "\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}


		}


		/// <summary>
		/// Add_Run_Parameter : Procedure ������ ���� �̸� Setting �Ǿ��� Parameter������ DataSet�� �߰�
		/// </summary>
		/// <param name="AfterClear">������ DataSet�� Clear�ϰ� �߰�(Cleaer���� ���� ���� ������ �߰���)</param>
		/// <returns>���� : true ,���� : false</returns>
		public bool Add_Run_Parameter (bool AfterClear) //string Process_Name, string[]  Parameter_Name, int[] Parameter_Type, string[] Parameter_Values)
		{
			DataTable DT_Run = new DataTable(Process_Name);
			DataColumn[] dc= new DataColumn[3];

			try
			{
				dc[0] = new DataColumn("Parameter_Name",Type.GetType("System.String"));
				dc[1] = new DataColumn("Parameter_Type",Type.GetType("System.Int32"));
				dc[2] = new DataColumn("Parameter_Value",Type.GetType("System.String"));
				DT_Run.Columns.AddRange(dc);

				for(int i=0; i< Parameter_Name.Length ;i++)
				{
					DataRow newRow = DT_Run.NewRow() ;
				
					newRow["Parameter_Name"] = Parameter_Name[i]; 
					newRow["Parameter_Type"] = (int)Parameter_Type[i];
					newRow["Parameter_Value"] = (Parameter_Values[i]==null) ? "" : Parameter_Values[i] ;
					DT_Run.Rows.Add(newRow);

				}
				if (AfterClear) this.Clear_Run_DataSet();
				DS_Run.Tables.Add(DT_Run);
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error: " + Process_Name + " at Add_Run_Parameter !!" + "\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}


		}


		/// <summary>
		/// Add_Modify_Parameter : Data ������ ���� �̸� Setting �Ǿ��� Parameter������ DataSet�� �߰�
		/// </summary>
		/// <param name="AfterClear">������ DataSet�� Clear�ϰ� �߰�(Cleaer���� ���� ���� ������ �߰���)</param>
		/// <returns>���� : true ,���� : false</returns>
		public bool Add_Modify_Parameter (bool AfterClear) 
		{
			DataTable DT_Modify = new DataTable(Process_Name);
			DataColumn[] dc= new DataColumn[Parameter_Name.Length];

			int row,col ;

			try
			{
				// DataTable�� Column ����
				for(int i=0 ;i< Parameter_Name.Length;i++)
				{
					dc[i] = new DataColumn (Parameter_Name[i],Type.GetType("System.String"));
				}
				DT_Modify.Columns.AddRange(dc);

				col=0;
				DataRow newRow = DT_Modify.NewRow() ;

				for(row=0 ;row< Parameter_Values.Length ;row++)
				{
					
					newRow[col] =(Parameter_Values[row]==null) ? "" : Parameter_Values[row].ToString() ;
					col = col +1;
					if(col == Parameter_Name.Length)
					{
						DT_Modify.Rows.Add(newRow);
						col=0;
						
						if (row < (Parameter_Values.Length -1)) newRow = DT_Modify.NewRow() ;
					}
				
				}
				if (AfterClear) this.Clear_Modify_DataSet();
				this.DS_Modify.Tables.Add(DT_Modify);
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error: " + Process_Name + " at Add_Modify_Parameter !!" + "\n" + ex.Message ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}


		}


 


		/// <summary>
		/// Exe_Select_Procedure : �������� DataTable �Ķ���͸� �̿��Ͽ� ��ȸ
		/// </summary>
		/// <returns>���� : DataSet ,���� : null</returns>
		public DataSet Exe_Select_Procedure()
		{
			//DataSet DS_Ret = new DataSet();
			string[] RunUser;

			try
			{
				RunUser =ComFunction.Set_UserInfo(ComVar.Log_Type.Write_File_DB);
				DS_Ret=  ComVar._WebSvc.Ora_Select_Procedure(RunUser,this.DS_Select);

				// --------------- DataSet Format----------------
				// DataSet ���� �������� DataTable�� �̿��Ͽ� ȣ�� �� �� ������ Return�� ��������
				// < ȣ��� ���� �� >
				// 1. RunUser : Set_UserInfo���� �����Ͽ� �迭�� ����
				// 2. DS_Select : Select ������ �ִ� DataSet(�������� Procedure�� ȣ���Ҽ� �ֽ�)
				//		1) DT_Select.TableName : ȣ���ϰ��� �ϴ� Oracle Package �� Procedure ��
				//		2) DT_Select.Column[0] : Į���� -> "Parameter_Name",������ Type -> Type.GetType("System.String") , ���ν��� ��������
				//		3) DT_Select.Column[1] : Į���� -> "Parameter_Type",������ Type -> Type.GetType("System.Int32") , OracleType���� Enum��
				//		4) DT_Select.Column[2] : Į���� -> "Parameter_Value",������ Type -> Type.GetType("System.String") , ���ν��� ���ް�
				// 
				// < ���Ͻ� ���� �� >
				// 1. ���� Return ��
				//		1) DataSet.DT.TableName : ȣ���� Oracle Package �� Procedure ��
				//		2) DataSet.DT.Columns	: ������� ������ �ʵ�
				//		3) DataSet.DT.Rows		: ������� ���ڵ�
				// 2. ������ Return ��
				//		1) DataSet.DataSetName  : "ERROR"
				//		1) DataSet.DT.TableName : ȣ���� Oracle Package �� Procedure ��
				//		2) DataSet.DT.Columns	: ���������� ������ �ʵ� Column[0].ColumnName = "Method", Column[1].ColumnName = "Error" , Column[2].ColumnName = "Date"
				//		3) DataSet.DT.Rows		: ������ ����

				//Return �� ó��
				if(DS_Ret.DataSetName =="ERROR")		// ������ Return
				{
					string err_msg = "";
					for(int i=0 ; i< DS_Ret.Tables.Count ;i++)
					{
						DataRow dr = DS_Ret.Tables[i].Rows[0];
						err_msg = err_msg + "Exec. Procedur :" + DS_Ret.Tables[i].TableName + " ,Method :" + dr["Method"].ToString() + "\n" ;
						err_msg = err_msg + "Error Message :" + dr["Error"].ToString() + "\n"  ;    
					}
					MessageBox.Show( err_msg,"Oracle DataBase Process",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
					return null;
					
				}
				else
				{
					return DS_Ret;
				}

			}
			catch(System.Threading.ThreadAbortException)
			{
				return null;
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Exe_Select_Procedure",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return null;
			}

		}


		/// <summary>
		/// Exe_Run_Procedure : �������� DataTable�� �Ķ���͸� �̿��Ͽ� ���ν����� ����
		/// </summary>
		/// <returns>���� : DataSet ,���� : null</returns>
		public DataSet Exe_Run_Procedure()
		{
			//DataSet DS_Ret = new DataSet();
			string[] RunUser;

			try
			{
				RunUser =ComFunction.Set_UserInfo(ComVar.Log_Type.Write_File_DB);
				DS_Ret=  ComVar._WebSvc.Ora_Run_Procedure(RunUser,this.DS_Run );

				// --------------- DataSet Format----------------
				// DataSet ���� �������� DataTable�� �̿��Ͽ� ȣ�� �� �� ������ Return�� ��������
				// < ȣ��� ���� �� >
				// 1. RunUser : Set_UserInfo���� �����Ͽ� �迭�� ����
				// 2. DS_Run : Procedure ������ ���� DataSet(�������� Procedure�� ȣ���Ҽ� �ֽ�)
				//		1) DT_Run.TableName : ȣ���ϰ��� �ϴ� Oracle Package �� Procedure ��
				//		2) DT_Run.Column[0] : Į���� -> "Parameter_Name",������ Type -> Type.GetType("System.String") , ���ν��� ��������
				//		3) DT_Run.Column[1] : Į���� -> "Parameter_Type",������ Type -> Type.GetType("System.Int32") , OracleType���� Enum��
				//		4) DT_Run.Column[2] : Į���� -> "Parameter_Value",������ Type -> Type.GetType("System.String") , ���ν��� ���ް�
				// 
				// < ���Ͻ� ���� �� >
				// 1. ���� Return ��
				//		1) DataSet.DT.TableName : ȣ���� Oracle Package �� Procedure ��
				//		2) DataSet.DT.Columns	: ������� ������ �ʵ� Column[0].ColumnName = "Result"
				//		3) DataSet.DT.Rows[0]	: ������� ���ڵ�  Row[0]= ó�������
				// 2. ������ Return ��
				//		1) DataSet.DataSetName  : "ERROR"
				//		1) DataSet.DT.TableName : ȣ���� Oracle Package �� Procedure ��
				//		2) DataSet.DT.Columns	: ���������� ������ �ʵ� Column[0].ColumnName = "Method", Column[1].ColumnName = "Error" , Column[2].ColumnName = "Date"
				//		3) DataSet.DT.Rows		: ������ ����

				//Return �� ó��
				if(DS_Ret.DataSetName =="ERROR")		// ������ Return
				{
					string err_msg="" ;
					for(int i=0 ; i< DS_Ret.Tables.Count ;i++)
					{
						DataRow dr = DS_Ret.Tables[i].Rows[0];
						err_msg = err_msg + "Exec. Procedur :" + DS_Ret.Tables[i].TableName + " ,Method :" + dr["Method"].ToString() + "\n" ;
						err_msg = err_msg + "Error Message :" + dr["Error"].ToString() + "\n"  ;  
					}
					MessageBox.Show( err_msg,"Oracle DataBase Process",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
					return null;
						
				}
				else
				{

					return DS_Ret;
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Exe_Select_Procedure",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return null;
			}

		}




 




		/// <summary>
		/// Exe_Modify_Procedure : �������� DataTable�� �̿��Ͽ� ���� �����͸� ����
		/// </summary>
		/// <returns>���� : DataSet ,���� : null</returns>
		public DataSet Exe_Modify_Procedure()
		{
			//DataSet DS_Ret = new DataSet();
			string[] RunUser;

			try
			{
				RunUser =ComFunction.Set_UserInfo(ComVar.Log_Type.Write_File_DB);
				DS_Ret=  ComVar._WebSvc.Ora_Modify_Procedure (RunUser,this.DS_Modify);

				// --------------- DataSet Format----------------
				// DataSet ���� �������� DataTable�� �̿��Ͽ� ȣ�� �� �� ������ Return�� ��������
				// < ȣ��� ���� �� >
				// 1. RunUser : Set_UserInfo���� �����Ͽ� �迭�� ����
				// 2. DS_Modify : �迭������ �����͸� �����ϱ� ���� DataSet(�������� Procedure�� ȣ���Ҽ� �ֽ�)
				//		1) DT_Modify.TableName : ȣ���ϰ��� �ϴ� Oracle Package �� Procedure ��
				//		2) DT_Modify.Column[0...] : Į���� -> �� �ʵ��� ���ڰ�[0...],������ Type -> Type.GetType("System.String") , ���ν��� ��������
				//		3) DT_Modify.Row[0...] : ���� �ִ� ���ڵ�
				// 
				// < ���Ͻ� ���� �� >
				// 1. ���� Return ��
				//		1) DataSet.DT.TableName : ȣ���� Oracle Package �� Procedure ��
				//		2) DataSet.DT.Columns	: ������� ������ �ʵ� Column[0].ColumnName = "Result"
				//		3) DataSet.DT.Rows		: ������� ���ڵ�  Row[0]= ó�������
				// 2. ������ Return ��
				//		1) DataSet.DataSetName  : "ERROR"
				//		1) DataSet.DT.TableName : ȣ���� Oracle Package �� Procedure ��
				//		2) DataSet.DT.Columns	: ���������� ������ �ʵ� Column[0].ColumnName = "Method", Column[1].ColumnName = "Error" , Column[2].ColumnName = "Date"
				//		3) DataSet.DT.Rows		: ������ ����

				//Return �� ó��
				if(DS_Ret.DataSetName =="ERROR")		// ������ Return
				{
					string err_msg="";
					for(int i=0 ; i< DS_Ret.Tables.Count ;i++)
					{
						DataRow dr = DS_Ret.Tables[i].Rows[0];
						err_msg = err_msg + "Exec. Procedur :" + DS_Ret.Tables[i].TableName + " ,Method :" + dr["Method"].ToString() + "\n" ;
						err_msg = err_msg + "Error Message :" + dr["Error"].ToString() + "\n"  ;  
					}
					MessageBox.Show( err_msg,"Oracle DataBase Process",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
					return null;
					
				}
				else
				{
					return DS_Ret;
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Exe_Modify_Procedure",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return null;
			}
		}



		/// <summary>
		/// Exe_Modify_Procedure : �������� DataTable�� �̿��Ͽ� ���� �����͸� ����
		/// </summary>
		/// <returns>���� : DataSet ,���� : null</returns>
		public bool Exe_Modify_Procedure_all()
		{
			string[] RunUser;
			
			try
			{
				RunUser =ComFunction.Set_UserInfo(ComVar.Log_Type.Write_File_DB);
				DS_Ret=  ComVar._WebSvc.Ora_Modify_Procedure (RunUser,this.DS_Modify);

				// --------------- DataSet Format----------------
				// DataSet ���� �������� DataTable�� �̿��Ͽ� ȣ�� �� �� ������ Return�� ��������
				// < ȣ��� ���� �� >
				// 1. RunUser : Set_UserInfo���� �����Ͽ� �迭�� ����
				// 2. DS_Modify : �迭������ �����͸� �����ϱ� ���� DataSet(�������� Procedure�� ȣ���Ҽ� �ֽ�)
				//		1) DT_Modify.TableName : ȣ���ϰ��� �ϴ� Oracle Package �� Procedure ��
				//		2) DT_Modify.Column[0...] : Į���� -> �� �ʵ��� ���ڰ�[0...],������ Type -> Type.GetType("System.String") , ���ν��� ��������
				//		3) DT_Modify.Row[0...] : ���� �ִ� ���ڵ�
				// 
				// < ���Ͻ� ���� �� >
				// 1. ���� Return ��
				//		1) DataSet.DT.TableName : ȣ���� Oracle Package �� Procedure ��
				//		2) DataSet.DT.Columns	: ������� ������ �ʵ� Column[0].ColumnName = "Result"
				//		3) DataSet.DT.Rows		: ������� ���ڵ�  Row[0]= ó�������
				// 2. ������ Return ��
				//		1) DataSet.DataSetName  : "ERROR"
				//		1) DataSet.DT.TableName : ȣ���� Oracle Package �� Procedure ��
				//		2) DataSet.DT.Columns	: ���������� ������ �ʵ� Column[0].ColumnName = "Method", Column[1].ColumnName = "Error" , Column[2].ColumnName = "Date"
				//		3) DataSet.DT.Rows		: ������ ����

				//Return �� ó��
				if(DS_Ret.DataSetName =="ERROR")		// ������ Return
				{
					string err_msg="";
					for(int i=0 ; i< DS_Ret.Tables.Count ;i++)
					{
						DataRow dr = DS_Ret.Tables[i].Rows[0];
						err_msg = err_msg + "Exec. Procedur :" + DS_Ret.Tables[i].TableName + " ,Method :" + dr["Method"].ToString() + "\n" ;
						err_msg = err_msg + "Error Message :" + dr["Error"].ToString() + "\n"  ;  
					}
					MessageBox.Show( err_msg,"Oracle DataBase Process",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
					return false;
					
				}
				else
				{
					if (DS_Ret == null) return false;
					else return true;
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Exe_Modify_Procedure",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}


 
		// 2006 03 13 �߰�

		/// <summary>
		/// Exe_Modify_Procedure_Blob : Blob �����͸� ����
		/// </summary>
		/// <returns>���� : DataSet ,���� : null</returns>
		public bool Exe_Modify_Procedure_Blob(byte[] BlobData)
		{ 

			try
			{ 
				bool ret =  ComVar._WebSvc.Ora_Run_Procedure_Blob (Process_Name, Parameter_Name, Parameter_Type, Parameter_Values, BlobData);

				 
				// < ���Ͻ� ���� �� >
				// 1. ���� Return ��
				//		true
				// 2. ������ Return ��
				//		false

				return ret;


				/*
				//Return �� ó��
				if(DS_Ret.DataSetName =="ERROR")		// ������ Return
				{
					string err_msg="";
					for(int i=0 ; i< DS_Ret.Tables.Count ;i++)
					{
						DataRow dr = DS_Ret.Tables[i].Rows[0];
						err_msg = err_msg + "Exec. Procedur :" + DS_Ret.Tables[i].TableName + " ,Method :" + dr["Method"].ToString() + "\n" ;
						err_msg = err_msg + "Error Message :" + dr["Error"].ToString() + "\n"  ;  
					}
					MessageBox.Show( err_msg,"Oracle DataBase Process",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
					return null;
					
				}
				else
				{
					return DS_Ret;
				}
				*/


			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Exe_Modify_Procedure_Blob",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}



		/// <summary>
		/// Exe_Select_Query : 1���� Query �������� ȣ��
		/// </summary>
		/// <param name="SqlTxt"> Query ����</param>
		/// <returns>���� : DataSet ,���� : null</returns>
		public DataSet Exe_Select_Query(string SqlTxt)
		{
			//DataSet DS_Ret = new DataSet();
			string[] RunUser;

			try
			{
				RunUser =ComFunction.Set_UserInfo(ComVar.Log_Type.Write_File_DB);
				DS_Ret=  ComVar._WebSvc.Ora_Select(RunUser,SqlTxt);

				// --------------- DataSet Format----------------
				// ���� Sql Query ������ �����Ͽ� DataSet�� ����� Return
				// < ȣ��� ���� �� >
				// 1. RunUser : Set_UserInfo���� �����Ͽ� �迭�� ����
				// 2. SqlTxt : �Ѱ��� Select Sql����
				// 
				// < ���Ͻ� ���� �� >
				// 1. ���� Return ��
				//		1) DataSet.DT.TableName : ȣ���� Oracle Package �� Procedure ��
				//		2) DataSet.DT.Columns	: ������� ������ �ʵ� Column[0].ColumnName = "Result"
				//		3) DataSet.DT.Rows		: ������� ���ڵ�  Row[0]= ó�������
				// 2. ������ Return ��
				//		1) DataSet.DataSetName  : "ERROR"
				//		1) DataSet.DT.TableName : ȣ���� Oracle Package �� Procedure ��
				//		2) DataSet.DT.Columns	: ���������� ������ �ʵ� Column[0].ColumnName = "Method", Column[1].ColumnName = "Error" , Column[2].ColumnName = "Date"
				//		3) DataSet.DT.Rows		: ������ ����

				//Return �� ó��
				if(DS_Ret.DataSetName =="ERROR")		// ������ Return
				{
					string err_msg="";
					for(int i=0 ; i< DS_Ret.Tables.Count ;i++)
					{
						DataRow dr = DS_Ret.Tables[i].Rows[0];
						err_msg = err_msg + "Exec. Procedur :" + DS_Ret.Tables[i].TableName + " ,Method :" + dr["Method"].ToString() + "\n" ;
						err_msg = err_msg + "Error Message :" + dr["Error"].ToString() + "\n"  ;  
					}
					MessageBox.Show( err_msg,"Oracle DataBase Process",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
					return null;
					
				}
				else
				{
					return DS_Ret;
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Exe_Modify_Procedure",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return null;
			}


		}


		/// <summary>
		/// Save_FlexGird : �׸��忡 �ִ� ������ ����
		/// </summary>
		/// <param name="arg_proc_name">���μ��� �̸�</param>
		/// <param name="arg_fgrid">��� �׸���</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_FlexGird(string arg_proc_name, COM.FSP arg_fgrid)
		{
			int col_ct = arg_fgrid.Cols.Count-1;		// Į���� ��
			int row_fixed = arg_fgrid.Rows.Fixed;		// �׸��� ������ ��
			int save_ct =0 ;							// ���� �� ��

			int i;
			int para_ct =0;								// �Ķ���� ���� ���� �迭�� ��
			int row,col;

			try
			{
				this.ReDim_Parameter(col_ct);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < col_ct; i++)
				{
					this.Parameter_Name[i] = "ARG_" + arg_fgrid[0, i].ToString(); 
				}

				// �Ķ������ ������ Type
				for(i = 0; i < col_ct ; i++)
				{
					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	
				// ���� �� �� ���ϱ�
				for(i = row_fixed ; i < arg_fgrid.Rows.Count; i++)
				{
					if(arg_fgrid[i, 0] == null) continue;

					if(arg_fgrid[i, 0].ToString() != "")
					{
						save_ct += 1;
					}
				}
			
				// �Ķ���� ���� ������ �迭
				this.Parameter_Values  = new string[col_ct * save_ct ];


				// �� ���� ���氪 Setting
				for(row = row_fixed; row < arg_fgrid.Rows.Count ; row++)
				{
					if(arg_fgrid[row, 0] == null) continue;

					if(arg_fgrid[row, 0].ToString() != "")
					{ 
						for(col = 0; col < col_ct ; col++)	// �� ���� �� Setting
						{  

							//������ üũ
							if(arg_fgrid.arr_essential[col] == "TRUE" && (arg_fgrid[row,col] == null || arg_fgrid[row,col].ToString() == "") )
								//******************  							
							{
								COM.ComFunction.User_Message("Essential Input - " + arg_fgrid[arg_fgrid.Rows.Fixed,col].ToString() );
								arg_fgrid.LeftCol = col;
								return false ;
							}


							// �����Ͱ� ���� 
							if(arg_fgrid.Cols[col].Style.DataType != null
								&& arg_fgrid.Cols[col].DataType.Equals(typeof(bool)) )
							{ 
								arg_fgrid[row, col] = (arg_fgrid[row, col] == null) ? "False" : arg_fgrid[row, col].ToString();
								this.Parameter_Values[para_ct] = (arg_fgrid[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							}
								//�޺�����Ʈ ó�� �߰�
							
							else if(arg_fgrid.Cols[col].ComboList.Length != 0)
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 

								token = arg_fgrid[row,col].ToString().Split(delimiter); 
								this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
 
								para_ct ++;
							}
								//�߰�(����ھ�����Ʈ���ؼ�)
							else if(arg_fgrid[0, (col == 0) ? 1 : col].ToString() == "UPD_USER")
							{
								this.Parameter_Values[para_ct] = ComVar.This_User ;
								para_ct ++;
							}
							else
							{ 
								this.Parameter_Values[para_ct] = (arg_fgrid[row, col] == null) ? "" : arg_fgrid[row,col].ToString();
								para_ct ++;
							}			
						} 
					}
				}

				//****************** ������ ������  							
				this.Add_Modify_Parameter(true);						// �Ķ���� �����͸� DataSet�� �߰�
				DataSet ds_Set = this.Exe_Modify_Procedure();			// Modify Procedure ����
				
				if (ds_Set == null) return false;
				else return true;
				//******************   						
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_FlexGird",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}

		/// <summary>
		/// Save_FlexGird : �׸��忡 �ִ� ������ ����
		/// </summary>
		/// <param name="arg_proc_name">���μ��� �̸�</param>
		/// <param name="arg_fgrid">��� �׸���</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_FlexGird(string arg_div , string arg_proc_name, COM.FSP arg_fgrid)
		{
			int col_ct = arg_fgrid.Cols.Count;		// Į���� ��
			int row_fixed = arg_fgrid.Rows.Fixed;		// �׸��� ������ ��
			int save_ct =0 ;							// ���� �� ��

			int i;
			int para_ct =0;								// �Ķ���� ���� ���� �迭�� ��
			int row,col;

			try
			{
				this.ReDim_Parameter(col_ct);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < col_ct; i++)
				{
					this.Parameter_Name[i] = "ARG_" + arg_fgrid[0, i].ToString(); 
				}

				// �Ķ������ ������ Type
				for(i = 0; i < col_ct ; i++)
				{
					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	
				// ���� �� �� ���ϱ�
				for(i = row_fixed ; i < arg_fgrid.Rows.Count; i++)
				{
					if(arg_fgrid[i, 0] == null) continue;

					if(arg_fgrid[i, 0].ToString() != "")
					{
						save_ct += 1;
					}
				}
			
				// �Ķ���� ���� ������ �迭
				this.Parameter_Values  = new string[col_ct * save_ct ];


				// �� ���� ���氪 Setting
				for(row = row_fixed; row < arg_fgrid.Rows.Count ; row++)
				{
					if(arg_fgrid[row, 0] == null) continue;

					if(arg_fgrid[row, 0].ToString() != "")
					{ 
						for(col = 0; col < col_ct ; col++)	// �� ���� �� Setting
						{

							//������ üũ
							if(arg_fgrid.arr_essential[col] == "TRUE" && (arg_fgrid[row,col] == null || arg_fgrid[row,col].ToString() == "") )
								//******************  							
							{
								COM.ComFunction.User_Message("Essential Input - " + arg_fgrid[arg_fgrid.Rows.Fixed,col].ToString() );
								arg_fgrid.LeftCol = col;
								return false ;
							}

						
							// �����Ͱ� ����
							//if(arg_fgrid.Cols[col].Style.Name == "CHECKBOX")
							if(arg_fgrid.Cols[col].Style.DataType != null
								&& arg_fgrid.Cols[col].DataType.Equals(typeof(bool)) )
							{
								//if(arg_fgrid[row,col] == null) arg_fgrid[row,col] = false ;
								arg_fgrid[row, col] = (arg_fgrid[row, col] == null) ? "False" : arg_fgrid[row, col].ToString();
								this.Parameter_Values[para_ct] = (arg_fgrid[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							}
								//�޺�����Ʈ ó�� �߰�
							else if(arg_fgrid.Cols[col].ComboList.Length != 0)
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 

								arg_fgrid[row,col] = (arg_fgrid[row,col] == null) ? "" : arg_fgrid[row,col].ToString();
								token = arg_fgrid[row,col].ToString().Split(delimiter); 
								this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
								//this.Parameter_Values[para_ct] = ComFunction.Empty_String(arg_fgrid[row, col].ToString()," ");
 
								para_ct ++;
							}
							else
							{   
								//�����/����� 
								if (col  == col_ct -2) 
								{
									this.Parameter_Values[para_ct] = ComVar.This_User; 
								}
								else if (col  == col_ct -1) 
								{
									this.Parameter_Values[para_ct] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
								}
								else
								{
									this.Parameter_Values[para_ct] = (arg_fgrid[row, col] == null) ? "" : arg_fgrid[row,col].ToString().ToUpper();
									//this.Parameter_Values[para_ct] = ComFunction.Empty_String(arg_fgrid[row, col].ToString()," ");
								}

								para_ct ++;

							}
							
							
 

						} //end for



					}
				}

				this.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
				this.Exe_Modify_Procedure();			// Modify Procedure ����
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_FlexGird",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}



		/// <summary>
		/// Save_FlexGird : �׸��忡 �ִ� ������ ���� (2005.11.30 ��ȿ���߰�)
		/// </summary>
		/// <param name="arg_proc_name">���μ��� �̸�</param>
		/// <param name="arg_fgrid">��� �׸���</param>
		/// <param name="arg_fgrid">���� Į����</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_FlexGird(string arg_proc_name, COM.FSP arg_fgrid,int save_col)
		{
			int col_ct = save_col;//arg_fgrid.Cols.Count-1;		// Į���� ��
			int row_fixed = arg_fgrid.Rows.Fixed;		// �׸��� ������ ��
			int save_ct =0 ;							// ���� �� ��

			int i;
			int para_ct =0;								// �Ķ���� ���� ���� �迭�� ��
			int row,col;

			try
			{
				this.ReDim_Parameter(col_ct);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < col_ct; i++)
				{
					this.Parameter_Name[i] = "ARG_" + arg_fgrid[0, i].ToString(); 
				}

				// �Ķ������ ������ Type
				for(i = 0; i < col_ct ; i++)
				{
					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	
				// ���� �� �� ���ϱ�
				for(i = row_fixed ; i < arg_fgrid.Rows.Count; i++)
				{
					if(arg_fgrid[i, 0] == null) continue;

					if(arg_fgrid[i, 0].ToString() != "")
					{
						save_ct += 1;
					}
				}
			
				// �Ķ���� ���� ������ �迭
				this.Parameter_Values  = new string[col_ct * save_ct ];


				// �� ���� ���氪 Setting
				for(row = row_fixed; row < arg_fgrid.Rows.Count ; row++)
				{
					if(arg_fgrid[row, 0] == null) continue;

					if(arg_fgrid[row, 0].ToString() != "")
					{ 
						for(col = 0; col < col_ct ; col++)	// �� ���� �� Setting
						{  

							//������ üũ
							if(arg_fgrid.arr_essential[col] == "TRUE" && (arg_fgrid[row,col] == null || arg_fgrid[row,col].ToString() == "") )
								//******************  							
							{
								COM.ComFunction.User_Message("Essential Input - " + arg_fgrid[arg_fgrid.Rows.Fixed,col].ToString() );
								arg_fgrid.LeftCol = col;
								return false ;
							}


							// �����Ͱ� ����														
							if(arg_fgrid.Cols[col].Style.DataType != null
								&& arg_fgrid.Cols[col].DataType.Equals(typeof(bool)) )
							{
								//if(arg_fgrid[row,col] == null) arg_fgrid[row,col] = false ;
								arg_fgrid[row, col] = (arg_fgrid[row, col] == null) ? "False" : arg_fgrid[row, col].ToString();
								this.Parameter_Values[para_ct] = (arg_fgrid[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							}

								//�޺�����Ʈ ó�� �߰�
							else if(arg_fgrid.Cols[col].ComboList.Length != 0)
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 

								token = arg_fgrid[row,col].ToString().Split(delimiter); 
								this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
 
								para_ct ++;
							}
								//�߰�(����ھ�����Ʈ���ؼ�)
							else if(arg_fgrid[0, (col==0)?1:col].ToString() == "UPD_USER")
							{
								this.Parameter_Values[para_ct] = ComVar.This_User ;
								para_ct ++;
							}

							else
							{
								this.Parameter_Values[para_ct] = (arg_fgrid[row, col] == null) ? "" : arg_fgrid[row,col].ToString();
								para_ct ++;
							}			
						} 
					}
				}

				this.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
				this.Exe_Modify_Procedure();			// Modify Procedure ����
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_FlexGird",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}


		/// <summary>
		/// Save_FlexGird : �׸��忡 �ִ� ������ ����
		/// </summary>
		/// <param name="arg_proc_name">���μ��� �̸�</param>
		/// <param name="arg_fgrid">��� �׸���</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_FlexGird_Ready(string arg_proc_name, COM.FSP arg_fgrid, bool arg_clear)
		{
			int col_ct = arg_fgrid.Cols.Count-1;		// Į���� ��
			int row_fixed = arg_fgrid.Rows.Fixed;		// �׸��� ������ ��
			int save_ct =0 ;							// ���� �� ��

			int i;
			int para_ct =0;								// �Ķ���� ���� ���� �迭�� ��
			int row,col;

			try
			{
				this.ReDim_Parameter(col_ct);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < col_ct; i++)
				{
					this.Parameter_Name[i] = "ARG_" + arg_fgrid[0, i].ToString(); 
				}

				// �Ķ������ ������ Type
				for(i = 0; i < col_ct ; i++)
				{
					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	
				// ���� �� �� ���ϱ�
				for(i = row_fixed ; i < arg_fgrid.Rows.Count; i++)
				{
					if(arg_fgrid[i, 0] == null) continue;

					if(arg_fgrid[i, 0].ToString() != "")
					{
						save_ct += 1;
					}
				}
			
				// �Ķ���� ���� ������ �迭
				this.Parameter_Values  = new string[col_ct * save_ct ];


				// �� ���� ���氪 Setting
				for(row = row_fixed; row < arg_fgrid.Rows.Count ; row++)
				{
					if(arg_fgrid[row, 0] == null) continue;

					if(arg_fgrid[row, 0].ToString() != "")
					{ 
						for(col = 0; col < col_ct ; col++)	// �� ���� �� Setting
						{  

							//������ üũ
							if(arg_fgrid.arr_essential[col] == "TRUE" && (arg_fgrid[row,col] == null || arg_fgrid[row,col].ToString() == "") )
								//******************  							
							{
								COM.ComFunction.User_Message("Essential Input - " + arg_fgrid[arg_fgrid.Rows.Fixed,col].ToString() );
								return false ;
							}


							// �����Ͱ� ���� 
							if(arg_fgrid.Cols[col].Style.DataType != null
								&& arg_fgrid.Cols[col].DataType.Equals(typeof(bool)) )
							{ 
								arg_fgrid[row, col] = (arg_fgrid[row, col] == null) ? "False" : arg_fgrid[row, col].ToString();
								this.Parameter_Values[para_ct] = (arg_fgrid[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							}
								//�޺�����Ʈ ó�� �߰�
							
							else if(arg_fgrid.Cols[col].ComboList.Length != 0)
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 

								token = arg_fgrid[row,col].ToString().Split(delimiter); 
								this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
 
								para_ct ++;
							}
								//�߰�(����ھ�����Ʈ���ؼ�)
							else if(arg_fgrid[0, (col == 0) ? 1 : col].ToString() == "UPD_USER")
							{
								this.Parameter_Values[para_ct] = ComVar.This_User ;
								para_ct ++;
							}
							else
							{ 
								this.Parameter_Values[para_ct] = (arg_fgrid[row, col] == null) ? "" : arg_fgrid[row,col].ToString();
								para_ct ++;
							}			
						} 
					}
				}

				this.Add_Modify_Parameter(arg_clear);						// �Ķ���� �����͸� DataSet�� �߰�
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_FlexGird",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}  
		}



		/// <summary>
		/// Save_FlexGird_CrossTab : ũ�ν��� �׸��忡 �ִ� ������ ����
		/// </summary>
		/// <param name="arg_proc_name">���μ��� �̸�</param>
		/// <param name="arg_fgrid">��� �׸���</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_FlexGird_CrossTab(string arg_proc_name, C1FlexGrid arg_fgrid, int arg_crs_start, string arg_col_nm1,string arg_col_nm2)
		{
			int col_ct = arg_fgrid.Cols.Count;		// Į���� ��
			int row_fixed = arg_fgrid.Rows.Fixed;		// �׸��� ������ ��
			int save_ct =0 ;							// ���� �� ��

			int i;
			int para_ct =0;								// �Ķ���� ���� ���� �迭�� ��
			int row,col,crs;

			try
			{
				this.ReDim_Parameter(arg_crs_start+2);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < arg_crs_start; i++)
				{
					this.Parameter_Name[i] = "ARG_" + arg_fgrid[0, i].ToString(); 
				}
				this.Parameter_Name[arg_crs_start]   = arg_col_nm1; 
				this.Parameter_Name[arg_crs_start+1] = arg_col_nm2; 

				// �Ķ������ ������ Type
				for(i = 0; i < arg_crs_start ; i++)
				{
					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
				this.Parameter_Type[arg_crs_start]   = (int)OracleType.VarChar  ;
				this.Parameter_Type[arg_crs_start+1] = (int)OracleType.VarChar  ;

	
				// ���� �� �� ���ϱ�
				for(i = row_fixed ; i < arg_fgrid.Rows.Count; i++)
				{
					if(arg_fgrid[i, 0] == null) continue;

					if(arg_fgrid[i, 0].ToString() != "")
					{
						save_ct += 1;
					}
				}
			
				// �Ķ���� ���� ������ �迭
				this.Parameter_Values  = new string[(arg_crs_start+2) * save_ct * (col_ct - arg_crs_start) ];


				// �� ���� ���氪 Setting
				for(row = row_fixed; row < arg_fgrid.Rows.Count ; row++)
				{
					if(arg_fgrid[i, 0] == null) continue;

					if(arg_fgrid[row, 0].ToString() != "")
					{ 
						for(crs = arg_crs_start; crs < arg_fgrid.Cols.Count; crs++)
						{
							for(col = 0; col < arg_crs_start ; col++)	// �� ���� �� Setting
							{  
								// �����Ͱ� ����														
								if(arg_fgrid.Cols[col].Style.DataType != null
									&& arg_fgrid.Cols[col].DataType.Equals(typeof(bool)) )
								{
									//if(arg_fgrid[row,col] == null) arg_fgrid[row,col] = false ;
									arg_fgrid[row, col] = (arg_fgrid[row, col] == null) ? "False" : arg_fgrid[row, col].ToString();
									this.Parameter_Values[para_ct] = (arg_fgrid[row,col].ToString() == "True") ? "Y" : "N"; 

									para_ct ++;
								}

									//�޺�����Ʈ ó�� �߰�
								else if(arg_fgrid.Cols[col].ComboList.Length != 0)
								{
									char[] delimiter = ":".ToCharArray();
									string[] token = null; 

									token = arg_fgrid[row,col].ToString().Split(delimiter); 
									this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
	 
									para_ct ++;
								}
									//�߰�(����ھ�����Ʈ���ؼ�)
								else if(arg_fgrid[0, (col==0)?1:col].ToString() == "UPD_USER")
								{
									this.Parameter_Values[para_ct] = ComVar.This_User ;
									para_ct ++;
								}

								else
								{
									this.Parameter_Values[para_ct] = (arg_fgrid[row, col] == null) ? "" : arg_fgrid[row,col].ToString();
									para_ct ++;
								}			
							}
							
							this.Parameter_Values[para_ct] = arg_fgrid[1, crs].ToString() ;
							para_ct ++;

							this.Parameter_Values[para_ct] = (arg_fgrid[row, crs] == null) ? "" : arg_fgrid[row,crs].ToString(); ;
							para_ct ++;
						}
					}
				}

				this.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
				this.Exe_Modify_Procedure();			// Modify Procedure ����
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_FlexGird",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}


		/// <summary>
		/// Save_FlexGird_CrossTab_Last : ũ�ν��� �׸����� ROW�� ������ Į���̸� ARG_DIV ����
		/// </summary>
		/// <param name="arg_proc_name">���μ��� �̸�</param>
		/// <param name="arg_fgrid">��� �׸���</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_FlexGird_CrossTab_Last(string arg_proc_name, C1FlexGrid arg_fgrid, int arg_crs_start, string arg_col_nm1,string arg_col_nm2)
		{
			int col_ct = arg_fgrid.Cols.Count;		// Į���� ��
			int row_fixed = arg_fgrid.Rows.Fixed;		// �׸��� ������ ��
			int save_ct =0 ;							// ���� �� ��

			int i;
			int para_ct =0;								// �Ķ���� ���� ���� �迭�� ��
			int row,col,crs;

			try
			{
				this.ReDim_Parameter(arg_crs_start+2);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < arg_crs_start; i++)
				{
					this.Parameter_Name[i] = "ARG_" + arg_fgrid[0, i].ToString(); 
				}
				this.Parameter_Name[arg_crs_start]   = arg_col_nm1; 
				this.Parameter_Name[arg_crs_start+1] = arg_col_nm2; 

				// �Ķ������ ������ Type
				for(i = 0; i < arg_crs_start ; i++)
				{
					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
				this.Parameter_Type[arg_crs_start]   = (int)OracleType.VarChar  ;
				this.Parameter_Type[arg_crs_start+1] = (int)OracleType.VarChar  ;

	
				// ���� �� �� ���ϱ�
				for(i = row_fixed ; i < arg_fgrid.Rows.Count; i++)
				{
					if(arg_fgrid[i, 0] == null) 
						arg_fgrid[i, 0] = "";
					if(arg_fgrid[i, 0].ToString() != "")
						save_ct += 1;
				}
			
				// �Ķ���� ���� ������ �迭
				this.Parameter_Values  = new string[(arg_crs_start+2) * save_ct * (col_ct - arg_crs_start) ];


				// �� ���� ���氪 Setting
				for(row = row_fixed; row < arg_fgrid.Rows.Count ; row++)
				{
					if(arg_fgrid[row, 0].ToString() != "")
					{ 
						for(crs = arg_crs_start; crs < arg_fgrid.Cols.Count; crs++)
						{
							for(col = 0; col < arg_crs_start ; col++)	// �� ���� �� Setting
							{  
								// �����Ͱ� ����														
								if(arg_fgrid.Cols[col].Style.DataType != null
									&& arg_fgrid.Cols[col].DataType.Equals(typeof(bool)) )
								{
									//if(arg_fgrid[row,col] == null) arg_fgrid[row,col] = false ;
									arg_fgrid[row, col] = (arg_fgrid[row, col] == null) ? "False" : arg_fgrid[row, col].ToString();
									this.Parameter_Values[para_ct] = (arg_fgrid[row,col].ToString() == "True") ? "Y" : "N"; 

									para_ct ++;
								}

									//�޺�����Ʈ ó�� �߰�
								else if(arg_fgrid.Cols[col].ComboList.Length != 0)
								{
									char[] delimiter = ":".ToCharArray();
									string[] token = null; 

									token = arg_fgrid[row,col].ToString().Split(delimiter); 
									this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
	 
									para_ct ++;
								}
									//�߰�(����ھ�����Ʈ���ؼ�)
								else if(arg_fgrid[0, (col==0)?1:col].ToString() == "UPD_USER")
								{
									this.Parameter_Values[para_ct] = ComVar.This_User ;
									para_ct ++;
								}

								else
								{
									if(col == 0 && crs == arg_fgrid.Cols.Count-1) //ROW�� ������ ����
									{
										this.Parameter_Values[para_ct] = (arg_fgrid[row, col] == null) ? "X" : arg_fgrid[row,col].ToString()+"X" ;
										para_ct ++;
									}
									else
									{
										this.Parameter_Values[para_ct] = (arg_fgrid[row, col] == null) ? "" : arg_fgrid[row,col].ToString();
										para_ct ++;
									}

								}			
							}
							
							this.Parameter_Values[para_ct] = arg_fgrid[1,crs].ToString() ;
							para_ct ++;

							this.Parameter_Values[para_ct] = (arg_fgrid[row, crs] == null) ? "" : arg_fgrid[row,crs].ToString(); ;
							para_ct ++;
						}
					}
				}

				this.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
				this.Exe_Modify_Procedure();			// Modify Procedure ����
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_FlexGird",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}




		/// <summary>
		/// Save_FlexGird : �׸��忡 �ִ� ������ ����	//������//hemos
		/// </summary>
		/// <param name="arg_proc_name">���μ��� �̸�</param>
		/// <param name="arg_fgrid">��� �׸���</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_FlexGird_Tree(string arg_proc_name, C1FlexGrid arg_fgrid)
		{
			int col_ct = arg_fgrid.Cols.Count-1;		// Į���� ��
			int row_fixed = arg_fgrid.Rows.Fixed+1;		// �׸��� ������ ��
			int save_ct =0 ;							// ���� �� ��
			string s ;

			int i;
			int para_ct =0;								// �Ķ���� ���� ���� �迭�� ��
			int row,col;

			try
			{
				this.ReDim_Parameter(col_ct);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < col_ct; i++)
				{
					this.Parameter_Name[i] = "ARG_" + arg_fgrid[0, i].ToString(); 
				}

				// �Ķ������ ������ Type
				for(i = 0; i < col_ct ; i++)
				{
					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	
				// ���� �� �� ���ϱ�
				for(i = row_fixed ; i < arg_fgrid.Rows.Count; i++)
				{
					if(arg_fgrid[i, 0] == null) continue;

					if((string)arg_fgrid[i, 0] != "")  //������ ����
					{
						save_ct += 1;
					}
				}
			
				// �Ķ���� ���� ������ �迭
				this.Parameter_Values  = new string[col_ct * save_ct ];


				// �� ���� ���氪 Setting
				for(row = row_fixed; row < arg_fgrid.Rows.Count ; row++)
				{
					if(arg_fgrid[i, 0] == null) continue;

					if((string)arg_fgrid[row, 0] != "")    //������ ����
					{ 
						for(col = 0; col < col_ct ; col++)	// �� ���� �� Setting
						{  
							// �����Ͱ� ����														
							if(arg_fgrid.Cols[col].Style.DataType != null
								&& arg_fgrid.Cols[col].DataType.Equals(typeof(bool)) )
							{
								//if(arg_fgrid[row,col] == null) arg_fgrid[row,col] = false ;
								arg_fgrid[row, col] = (arg_fgrid[row, col] == null) ? "False" : arg_fgrid[row, col].ToString();
								this.Parameter_Values[para_ct] = (arg_fgrid[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							}

								//�޺�����Ʈ ó�� �߰�
							else if(arg_fgrid.Cols[col].ComboList.Length != 0)
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 
								
								//������ ����
								s = (arg_fgrid[row, col] == null) ? "" : arg_fgrid[row,col].ToString();
								token = s.Split(delimiter); 
								this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
 
								para_ct ++;
							}
								//�߰�(����ھ�����Ʈ���ؼ�)
							else if(arg_fgrid[0, (col==0)?1:col].ToString() == "UPD_USER")
							{
								this.Parameter_Values[para_ct] = ComVar.This_User ;
								para_ct ++;
							}

							else
							{
								this.Parameter_Values[para_ct] = (arg_fgrid[row, col] == null) ? "" : arg_fgrid[row,col].ToString();
								para_ct ++;
							}			
						} 
					}
				}

				this.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
				this.Exe_Modify_Procedure();			// Modify Procedure ����
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_FlexGird",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}





//		/// <summary>
//		/// Save_Spread : �������忡 �ִ� ������ ����
//		/// </summary>
//		/// <param name="arg_proc_name">���μ��� �̸�</param>
//		/// <param name="arg_fgrid">��� ��������</param>
//		/// <returns>���� : true , ���� : false </returns>
//		public bool Save_Spread(string arg_proc_name, COM.SSP arg_fgrid)
//		{
//			int col_ct = arg_fgrid.Sheets[0].ColumnCount-1;	           // Į���� ��
//			int row_fixed = arg_fgrid.Sheets[0].RowHeader.Rows.Count ; // �׸��� ������ ��
//			int save_ct =0 ;							               // ���� �� ��
//
//			int i;
//			int para_ct =0;								               // �Ķ���� ���� ���� �迭�� ��
//			int row,col;
//			string s;
//
//			try
//			{
//				this.ReDim_Parameter(col_ct);
//				this.Process_Name = arg_proc_name;
//
//				// �Ķ���� �̸� ����
//				this.Parameter_Name[0] = "ARG_DIVISION";
//				for(i = 1; i < col_ct; i++)
//				{
//					this.Parameter_Name[i] = "ARG_" + arg_fgrid.Sheets[0].ColumnHeader.Cells[0,i].Value.ToString(); 
//				}
//
//				// �Ķ������ ������ Type
//				for(i = 1; i < col_ct ; i++)
//				{
//					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
//				}
//	
//				// ���� �� �� ���ϱ�
//				for(i = 0 ; i < arg_fgrid.Sheets[0].Rows.Count; i++)
//				{
//					s = (arg_fgrid.Sheets[0].Cells[i,0].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[i,0].Tag.ToString();
//					if( s != "")
//					{
//						save_ct += 1;						
//					}
//				}
//			
//				// �Ķ���� ���� ������ �迭
//				this.Parameter_Values  = new string[col_ct * save_ct ];
//
//
//				// �� ���� ���氪 Setting
//				for(row = 0; row < arg_fgrid.Sheets[0].Rows.Count ; row++)
//				{
//					s = (arg_fgrid.Sheets[0].Cells[row,0].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[row,0].Tag.ToString();
//					if(s != "")
//					{ 
//						for(col = 0; col < col_ct ; col++)	// �� ���� �� Setting
//						{  							
//							
//							//������ üũ
//							if(arg_fgrid.arr_essential[col] == "TRUE" && arg_fgrid.Sheets[0].Cells[row,col].Value == null)
//							{
//								COM.ComFunction.User_Message("Essential Input - " +arg_fgrid.Sheets[0].ColumnHeader.Cells[arg_fgrid.Sheets[0].ColumnHeader.Rows.Count-1,col].Text) ;
//								return false ;
//							}
//							
//							// �����Ͱ� ����																				
//							if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "CheckBoxCellType")
//							{
//								if(arg_fgrid.Sheets[0].Cells[row,col].Value == null)
//								{
//									this.Parameter_Values[para_ct] = "N"; 
//								}
//								else
//								{
//									this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Value.ToString() == "True") ? "Y" : "N"; 
//								}								
//
//								para_ct ++;
//							}
//
//								//IUD ���
//							else if(col == 0)
//							{
//								this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Tag.ToString();
//								para_ct ++;
//							}
//
//
//								//�޺�����Ʈ ó�� �߰�
//							else if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "ComboBoxCellType") 
//							{
//								char[] delimiter = ":".ToCharArray();
//								string[] token = null; 
//								string token_str = "";
//
//								token_str = (arg_fgrid.Sheets[0].Cells[row,col].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Value.ToString();
//								token = token_str.Split(delimiter); 
//								this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
// 
//								para_ct ++;
//							}
//								//�߰�(����ھ�����Ʈ���ؼ�)
//							else if(arg_fgrid.Sheets[0].ColumnHeader.Cells[0,col].Text == "UPD_USER")
//							{
//								this.Parameter_Values[para_ct] = ComVar.This_User ;
//								para_ct ++;
//							}
//							
//							else
//							{
//								this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Value.ToString();
//								para_ct ++;
//							}			
//						} 
//					}
//				}
//
//				this.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
//				this.Exe_Modify_Procedure();			// Modify Procedure ����
//				
//				return true;
//
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show( ex.Message,"Save_Spread",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
//				return false;
//			}
//  
//		}
//
//
//
//
//		/// <summary>
//		/// Save_Spread : �������忡 �ִ� ������ ����
//		/// </summary>
//		/// <param name="arg_proc_name">���μ��� �̸�</param>
//		/// <param name="arg_fgrid">��� ��������</param>
//		/// <param name="arg_flag">Į������</param>
//		/// <returns>���� : true , ���� : false </returns>
//		public bool Save_Spread(string arg_proc_name, COM.SSP arg_fgrid, int arg_flag)
//		{
//			int col_ct = arg_fgrid.Sheets[0].ColumnCount;	           // Į���� ��
//			int row_fixed = arg_fgrid.Sheets[0].RowHeader.Rows.Count ; // �׸��� ������ ��
//			int save_ct =0 ;							               // ���� �� ��
//
//			int i;
//			int para_ct =0;								               // �Ķ���� ���� ���� �迭�� ��
//			int row,col;
//			string s;
//
//			try
//			{
//				this.ReDim_Parameter(col_ct);
//				this.Process_Name = arg_proc_name;
//
//				// �Ķ���� �̸� ����
//				this.Parameter_Name[0] = "ARG_DIVISION";
//				for(i = 1; i < col_ct; i++)
//				{
//					this.Parameter_Name[i] = "ARG_" + arg_fgrid.Sheets[0].ColumnHeader.Cells[0,i].Value.ToString(); 
//				}
//
//				// �Ķ������ ������ Type
//				for(i = 1; i < col_ct ; i++)
//				{
//					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
//				}
//	
//				// ���� �� �� ���ϱ�
//				for(i = 0 ; i < arg_fgrid.Sheets[0].Rows.Count; i++)
//				{
//					s = (arg_fgrid.Sheets[0].Cells[i,0].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[i,0].Tag.ToString();
//					if( s != "")
//					{
//						save_ct += 1;						
//					}
//				}
//			
//				// �Ķ���� ���� ������ �迭
//				this.Parameter_Values  = new string[col_ct * save_ct ];
//
//
//				// �� ���� ���氪 Setting
//				for(row = 0; row < arg_fgrid.Sheets[0].Rows.Count ; row++)
//				{
//					s = (arg_fgrid.Sheets[0].Cells[row,0].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[row,0].Tag.ToString();
//					if(s != "")
//					{ 
//						for(col = 0; col < col_ct ; col++)	// �� ���� �� Setting
//						{  							
//							
//							//������ üũ
//							if(arg_fgrid.arr_essential[col] == "TRUE" && arg_fgrid.Sheets[0].Cells[row,col].Value == null)
//							{
//								COM.ComFunction.User_Message("Essential Input - " +arg_fgrid.Sheets[0].ColumnHeader.Cells[arg_fgrid.Sheets[0].ColumnHeader.Rows.Count-1,col].Text) ;
//								return false ;
//							}
//							
//							// �����Ͱ� ����																				
//							if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "CheckBoxCellType")
//							{
//								if(arg_fgrid.Sheets[0].Cells[row,col].Value == null)
//								{
//									this.Parameter_Values[para_ct] = "N"; 
//								}
//								else
//								{
//									this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Value.ToString() == "True") ? "Y" : "N"; 
//								}								
//
//								para_ct ++;
//							}
//
//								//IUD ���
//							else if(col == 0)
//							{
//								this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Tag.ToString();
//								para_ct ++;
//							}
//
//
//								//�޺�����Ʈ ó�� �߰�
//							else if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "ComboBoxCellType")
//							{
//								char[] delimiter = ":".ToCharArray();
//								string[] token = null; 
//								string token_str = "";
//
//								token_str = (arg_fgrid.Sheets[0].Cells[row,col].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Value.ToString();
//								token = token_str.Split(delimiter); 
//								this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
// 
//								para_ct ++;
//							}
//								//�߰�(����ھ�����Ʈ���ؼ�)
//							else if(arg_fgrid.Sheets[0].ColumnHeader.Cells[0,col].Text == "UPD_USER")
//							{
//								this.Parameter_Values[para_ct] = ComVar.This_User ;
//								para_ct ++;
//							}
//
//							else if(arg_fgrid.Sheets[0].ColumnHeader.Cells[0,col].Text == "UPD_YMD")
//							{
//								this.Parameter_Values[para_ct] =System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
//								para_ct ++;
//							}
//							
//							
//							else
//							{
//								this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Value.ToString();
//								para_ct ++;
//							}			
//						} 
//					}
//				}
//
//				this.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
//				this.Exe_Modify_Procedure();			// Modify Procedure ����
//				
//				return true;
//
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show( ex.Message,"Save_Spread",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
//				return false;
//			}
//  
//		}





		/// <summary>
		/// Save_Spread : �������忡 �ִ� ������ ����
		/// </summary>
		/// <param name="arg_proc_name">���μ��� �̸�</param>
		/// <param name="arg_fgrid">��� ��������</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_Spread(string arg_proc_name, COM.SSP arg_fgrid)
		{
			int col_ct = arg_fgrid.Sheets[0].ColumnCount-1;	           // Į���� ��
			int row_fixed = arg_fgrid.Sheets[0].RowHeader.Rows.Count ; // �׸��� ������ ��
			int save_ct =0 ;							               // ���� �� ��

			int i;
			int para_ct =0;								               // �Ķ���� ���� ���� �迭�� ��
			int row,col;
			string s;

			try
			{
				this.ReDim_Parameter(col_ct);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < col_ct; i++)
				{
					this.Parameter_Name[i] = "ARG_" + arg_fgrid.Sheets[0].ColumnHeader.Cells[0,i].Value.ToString(); 
				}

				// �Ķ������ ������ Type
				for(i = 1; i < col_ct ; i++)
				{
					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	
				// ���� �� �� ���ϱ�
				for(i = 0 ; i < arg_fgrid.Sheets[0].Rows.Count; i++)
				{
					s = (arg_fgrid.Sheets[0].Cells[i,0].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[i,0].Tag.ToString();
					if( s != "")
					{
						save_ct += 1;						
					}
				}
			
				// �Ķ���� ���� ������ �迭
				this.Parameter_Values  = new string[col_ct * save_ct ];


				// �� ���� ���氪 Setting
				for(row = 0; row < arg_fgrid.Sheets[0].Rows.Count ; row++)
				{
					s = (arg_fgrid.Sheets[0].Cells[row,0].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[row,0].Tag.ToString();
					if(s != "")
					{ 
						for(col = 0; col < col_ct ; col++)	// �� ���� �� Setting
						{  							
							//****************** ������ ������  							
							//������ üũ
							if(arg_fgrid.arr_essential[col] == "TRUE" && (arg_fgrid.Sheets[0].Cells[row,col].Value == null || arg_fgrid.Sheets[0].Cells[row,col].Value.ToString() == "") )
								//******************  							
							{
								COM.ComFunction.User_Message("Essential Input - " +arg_fgrid.Sheets[0].ColumnHeader.Cells[arg_fgrid.Sheets[0].ColumnHeader.Rows.Count-1,col].Text) ;
								return false ;
							}
							
							// �����Ͱ� ����																				
							if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "CheckBoxCellType")
							{
								if(arg_fgrid.Sheets[0].Cells[row,col].Value == null)
								{
									this.Parameter_Values[para_ct] = "N"; 
								}
								else
								{
									this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Value.ToString() == "True") ? "Y" : "N"; 
								}								

								para_ct ++;
							}

								//IUD ���
							else if(col == 0)
							{
								this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Tag.ToString();
								para_ct ++;
							}


								//�޺�����Ʈ ó�� �߰�
							else if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "ComboBoxCellType") 
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 
								string token_str = "";

								token_str = (arg_fgrid.Sheets[0].Cells[row,col].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Value.ToString();
								token = token_str.Split(delimiter); 
								this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
 
								para_ct ++;
							}
								//�߰�(����ھ�����Ʈ���ؼ�)
							else if(arg_fgrid.Sheets[0].ColumnHeader.Cells[0,col].Text == "UPD_USER")
							{
								this.Parameter_Values[para_ct] = ComVar.This_User ;
								para_ct ++;
							}
							
							else
							{
								this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Value.ToString();
								para_ct ++;
							}			
						} 
					}
				}

				//****************** ������ ������  							
				this.Add_Modify_Parameter(true);						// �Ķ���� �����͸� DataSet�� �߰�
				DataSet ds_Set = this.Exe_Modify_Procedure();			// Modify Procedure ����
				
				if (ds_Set == null) return false;
				else return true;
				//******************  							
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_Spread",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}




		/// <summary>
		/// Save_Spread : �������忡 �ִ� ������ ����
		/// </summary>
		/// <param name="arg_proc_name">���μ��� �̸�</param>
		/// <param name="arg_fgrid">��� ��������</param>
		/// <param name="arg_flag">Į������</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_Spread(string arg_proc_name, COM.SSP arg_fgrid, int arg_flag)
		{
			int col_ct = arg_fgrid.Sheets[0].ColumnCount;	           // Į���� ��
			int row_fixed = arg_fgrid.Sheets[0].RowHeader.Rows.Count ; // �׸��� ������ ��
			int save_ct =0 ;							               // ���� �� ��

			int i;
			int para_ct =0;								               // �Ķ���� ���� ���� �迭�� ��
			int row,col;
			string s;

			try
			{
				this.ReDim_Parameter(col_ct);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < col_ct; i++)
				{
					this.Parameter_Name[i] = "ARG_" + arg_fgrid.Sheets[0].ColumnHeader.Cells[0,i].Value.ToString(); 
				}

				// �Ķ������ ������ Type
				for(i = 1; i < col_ct ; i++)
				{
					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	
				// ���� �� �� ���ϱ�
				for(i = 0 ; i < arg_fgrid.Sheets[0].Rows.Count; i++)
				{
					s = (arg_fgrid.Sheets[0].Cells[i,0].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[i,0].Tag.ToString();
					if( s != "")
					{
						save_ct += 1;						
					}
				}
			
				// �Ķ���� ���� ������ �迭
				this.Parameter_Values  = new string[col_ct * save_ct ];


				// �� ���� ���氪 Setting
				for(row = 0; row < arg_fgrid.Sheets[0].Rows.Count ; row++)
				{
					s = (arg_fgrid.Sheets[0].Cells[row,0].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[row,0].Tag.ToString();
					if(s != "")
					{ 
						for(col = 0; col < col_ct ; col++)	// �� ���� �� Setting
						{  							
							
							//������ üũ
							//****************** ������ ������  							
							if(arg_fgrid.arr_essential[col] == "TRUE" && (arg_fgrid.Sheets[0].Cells[row,col].Value == null || arg_fgrid.Sheets[0].Cells[row,col].Value.ToString() == "") )
								//******************  							
							{
								COM.ComFunction.User_Message("Essential Input - " +arg_fgrid.Sheets[0].ColumnHeader.Cells[arg_fgrid.Sheets[0].ColumnHeader.Rows.Count-1,col].Text) ;
								return false ;
							}
							
							// �����Ͱ� ����																				
							if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "CheckBoxCellType")
							{
								if(arg_fgrid.Sheets[0].Cells[row,col].Value == null)
								{
									this.Parameter_Values[para_ct] = "N"; 
								}
								else
								{
									this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Value.ToString() == "True") ? "Y" : "N"; 
								}								

								para_ct ++;
							}

								//IUD ���
							else if(col == 0)
							{
								this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Tag.ToString();
								para_ct ++;
							}


								//�޺�����Ʈ ó�� �߰�
							else if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "ComboBoxCellType")
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 
								string token_str = "";

								token_str = (arg_fgrid.Sheets[0].Cells[row,col].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Value.ToString();
								token = token_str.Split(delimiter); 
								this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
 
								para_ct ++;
							}
								//�߰�(����ھ�����Ʈ���ؼ�)
							else if(arg_fgrid.Sheets[0].ColumnHeader.Cells[0,col].Text == "UPD_USER")
							{
								this.Parameter_Values[para_ct] = ComVar.This_User ;
								para_ct ++;
							}

							else if(arg_fgrid.Sheets[0].ColumnHeader.Cells[0,col].Text == "UPD_YMD")
							{
								this.Parameter_Values[para_ct] =System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
								para_ct ++;
							}
							
							
							else
							{
								this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Value.ToString();
								para_ct ++;
							}			
						} 
					}
				}

				//****************** ������ ������  							
				this.Add_Modify_Parameter(true);						// �Ķ���� �����͸� DataSet�� �߰�
				DataSet ds_Set = this.Exe_Modify_Procedure();			// Modify Procedure ����
				
				if (ds_Set == null) return false;
				else return true;
				//******************   							
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_Spread",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}



		/// <summary>
		/// Save_Spread : �������忡 �ִ� ������ ����
		/// </summary>
		/// <param name="arg_proc_name">���ν��� �̸�</param>
		/// <param name="arg_fgrid">��� ��������</param>
		/// <param name="arg_flag">�����ͼ� Ŭ���� ����</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_Spread_Ready(string arg_proc_name, COM.SSP arg_fgrid, bool arg_clear)
		{
			int col_ct = arg_fgrid.Sheets[0].ColumnCount - 1;	           // Į���� ��
			int row_fixed = arg_fgrid.Sheets[0].RowHeader.Rows.Count ; // �׸��� ������ ��
			int save_ct =0 ;							               // ���� �� ��

			int i;
			int para_ct =0;								               // �Ķ���� ���� ���� �迭�� ��
			int row,col;
			string s;

			try
			{
				this.ReDim_Parameter(col_ct);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < col_ct; i++)
				{
					this.Parameter_Name[i] = "ARG_" + arg_fgrid.Sheets[0].ColumnHeader.Cells[0,i].Value.ToString(); 
				}

				// �Ķ������ ������ Type
				for(i = 1; i < col_ct ; i++)
				{
					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	
				// ���� �� �� ���ϱ�
				for(i = 0 ; i < arg_fgrid.Sheets[0].Rows.Count; i++)
				{
					s = (arg_fgrid.Sheets[0].Cells[i,0].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[i,0].Tag.ToString();
					if( s != "")
					{
						save_ct += 1;						
					}
				}
			
				// �Ķ���� ���� ������ �迭
				this.Parameter_Values  = new string[col_ct * save_ct ];


				// �� ���� ���氪 Setting
				for(row = 0; row < arg_fgrid.Sheets[0].Rows.Count ; row++)
				{
					s = (arg_fgrid.Sheets[0].Cells[row,0].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[row,0].Tag.ToString();
					if(s != "")
					{ 
						for(col = 0; col < col_ct ; col++)	// �� ���� �� Setting
						{  							
							
							//������ üũ
							//****************** ������ ������  							
							if(arg_fgrid.arr_essential[col] == "TRUE" && (arg_fgrid.Sheets[0].Cells[row,col].Value == null || arg_fgrid.Sheets[0].Cells[row,col].Value.ToString() == "") )
								//******************  							
							{
								COM.ComFunction.User_Message("Essential Input - " +arg_fgrid.Sheets[0].ColumnHeader.Cells[arg_fgrid.Sheets[0].ColumnHeader.Rows.Count-1,col].Text) ;
								return false ;
							}
							
							// �����Ͱ� ����																				
							if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "CheckBoxCellType")
							{
								if(arg_fgrid.Sheets[0].Cells[row,col].Value == null)
								{
									this.Parameter_Values[para_ct] = "N"; 
								}
								else
								{
									this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Value.ToString() == "True") ? "Y" : "N"; 
								}								

								para_ct ++;
							}

								//IUD ���
							else if(col == 0)
							{
								this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Tag.ToString();
								para_ct ++;
							}


								//�޺�����Ʈ ó�� �߰�
							else if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "ComboBoxCellType")
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 
								string token_str = "";

								token_str = (arg_fgrid.Sheets[0].Cells[row,col].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Value.ToString();
								token = token_str.Split(delimiter); 
								this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
 
								para_ct ++;
							}
								// datetime �÷� ó��
							else if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "DateTimeCellType")
							{
								if(arg_fgrid.Sheets[0].Cells[row,col].Value == null || arg_fgrid.Sheets[0].Cells[row,col].Value.Equals("") )
								{
									this.Parameter_Values[para_ct] = "";
								}
								else
								{
									this.Parameter_Values[para_ct] = DateTime.Parse(arg_fgrid.Sheets[0].Cells[row,col].Value.ToString() ).ToString("yyyy-MM-dd");
								}

								para_ct ++;

							}
								//�߰�(����ھ�����Ʈ���ؼ�)
							else if(arg_fgrid.Sheets[0].ColumnHeader.Cells[0,col].Text == "UPD_USER")
							{
								this.Parameter_Values[para_ct] = ComVar.This_User ;
								para_ct ++;
							}

							else if(arg_fgrid.Sheets[0].ColumnHeader.Cells[0,col].Text == "UPD_YMD")
							{
								this.Parameter_Values[para_ct] =System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
								para_ct ++;
							}
							
							
							else
							{
								this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Value.ToString();
								para_ct ++;
							}			
						} 
					}
				}

				this.Add_Modify_Parameter(arg_clear);						// �Ķ���� �����͸� DataSet�� �߰�
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_Spread",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}



		/// <summary>
		/// Save_Spread_CrossTab : �������忡 �ִ� ������ ����
		/// </summary>
		/// <param name="arg_proc_name">���μ��� �̸�</param>
		/// <param name="arg_fgrid">��� ��������</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_Spread_CrossTab(string arg_proc_name, COM.SSP arg_fgrid, int arg_crs_start, string arg_col_nm1,string arg_col_nm2)
		{
			int col_ct = arg_fgrid.Sheets[0].ColumnCount;	           // Į���� ��
			int row_fixed = arg_fgrid.Sheets[0].RowHeader.Rows.Count ; // �׸��� ������ ��
							
			int save_ct =0 ;							               // ���� �� ��

			int i;
			int para_ct =0;								               // �Ķ���� ���� ���� �迭�� ��
			int row,col,crs;
			string s;

			try
			{
				this.ReDim_Parameter(arg_crs_start+2);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < arg_crs_start; i++)
				{
					this.Parameter_Name[i] = "ARG_" + arg_fgrid.Sheets[0].ColumnHeader.Cells[0,i].Value.ToString(); 
				}
				this.Parameter_Name[arg_crs_start]   = arg_col_nm1; 
				this.Parameter_Name[arg_crs_start+1] = arg_col_nm2; 

				// �Ķ������ ������ Type
				for(i = 0; i < arg_crs_start ; i++)
				{
					this.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
				this.Parameter_Type[arg_crs_start]   = (int)OracleType.VarChar  ;
				this.Parameter_Type[arg_crs_start+1] = (int)OracleType.VarChar  ;
	
				// ���� �� �� ���ϱ�
				for(i = 0 ; i < arg_fgrid.Sheets[0].Rows.Count; i++)
				{
					s = (arg_fgrid.Sheets[0].Cells[i,0].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[i,0].Tag.ToString();
					if( s != "")
					{
						save_ct += 1;						
					}
				}
			
				// �Ķ���� ���� ������ �迭
				this.Parameter_Values  = new string[(arg_crs_start+2) * save_ct * (col_ct - arg_crs_start) ];


				// �� ���� ���氪 Setting
				for(row = 0; row < arg_fgrid.Sheets[0].Rows.Count ; row++)
				{
					s = (arg_fgrid.Sheets[0].Cells[row,0].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[row,0].Tag.ToString();
					if(s != "")
					{ 
						for(crs = arg_crs_start; crs < col_ct; crs++)
						{
							for(col = 0; col < arg_crs_start ; col++)	// �� ���� �� Setting
							{    																					
							
								// �����Ͱ� ����																				
								if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "CheckBoxCellType")
								{
									if(arg_fgrid.Sheets[0].Cells[row,col].Value == null)
									{
										this.Parameter_Values[para_ct] = "N"; 
									}
									else
									{
										this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Value.ToString() == "True") ? "Y" : "N"; 
									}								

									para_ct ++;
								}

									//IUD ���
								else if(col == 0)
								{
									this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Tag == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Tag.ToString();
									para_ct ++;
								}


									//�޺�����Ʈ ó�� �߰�
								else if(arg_fgrid.Sheets[0].GetCellType(0,col).ToString() == "ComboBoxCellType")
								{
									char[] delimiter = ":".ToCharArray();
									string[] token = null; 
									string token_str = "";

									token_str = (arg_fgrid.Sheets[0].Cells[row,col].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Value.ToString();
									token = token_str.Split(delimiter); 
									this.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
	 
									para_ct ++;
								}
									//�߰�(����ھ�����Ʈ���ؼ�)
								else if(arg_fgrid.Sheets[0].ColumnHeader.Cells[0,col].Text == "UPD_USER")
								{
									this.Parameter_Values[para_ct] = ComVar.This_User ;
									para_ct ++;
								}
								
								else
								{
									this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,col].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,col].Value.ToString();
									para_ct ++;
								}			
							}
							this.Parameter_Values[para_ct] = arg_fgrid.Sheets[0].ColumnHeader.Cells[row_fixed-1,crs].Text ;
							para_ct ++;

							this.Parameter_Values[para_ct] = (arg_fgrid.Sheets[0].Cells[row,crs].Value == null) ? "" : arg_fgrid.Sheets[0].Cells[row,crs].Value.ToString() ;
							para_ct ++;
						} 
					}
				}

				this.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
				this.Exe_Modify_Procedure();			// Modify Procedure ����
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_Spread",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}


		/// <summary>
		/// Save_Spread_CrossTab_Request : �������忡 �ִ� ������ ����
		/// </summary>
		/// <param name="arg_proc_name">���μ��� �̸�</param>
		/// <param name="arg_fgrid">��� ��������</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_Spread_CrossTab_Request(string arg_proc_name, COM.SSP arg_fgrid, int arg_crs_start, string arg_col_nm1,string arg_col_nm2, string arg_pk_nm1, string arg_pk_nm2, string arg_pk_val1, string arg_pk_val2)
		{
			int col_ct = arg_fgrid.Sheets[0].ColumnCount;	           // Į���� ��
			int row_fixed = arg_fgrid.Sheets[0].RowHeader.Rows.Count ; // �׸��� ������ ��
			
			try
			{
				this.ReDim_Parameter(arg_crs_start+2-1);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				this.Parameter_Name[1] = arg_col_nm1; 
				this.Parameter_Name[2] = arg_col_nm2; 
				this.Parameter_Name[3] = arg_pk_nm1;
				this.Parameter_Name[4] = arg_pk_nm2;

				// �Ķ������ ������ Type
				this.Parameter_Type[0] = (int)OracleType.VarChar  ; 
				this.Parameter_Type[1] = (int)OracleType.VarChar  ;
				this.Parameter_Type[2] = (int)OracleType.VarChar  ;
				this.Parameter_Type[3] = (int)OracleType.VarChar  ;
				this.Parameter_Type[4] = (int)OracleType.VarChar  ;
	
				//04.DATA ����  			

				// �Ķ���� ���� ������ �迭
				this.Parameter_Values = new string [(arg_fgrid.Sheets[0].Columns.Count-arg_crs_start)*5];
				
				
				for(int i = 0 ; i < arg_fgrid.Sheets[0].Columns.Count-arg_crs_start ; i++)
				{
					if(arg_fgrid.Sheets[0].Cells[0,i+4].Text != "0")
					{
						this.Parameter_Values[i*5]   = "A"; 
						this.Parameter_Values[i*5+1] = arg_fgrid.ActiveSheet.ColumnHeader.Cells[0,i+4].Text;  //���  cs_size 
						this.Parameter_Values[i*5+2] = arg_fgrid.Sheets[0].Cells[0,i+4].Text;                 //��    cs_qty  
						this.Parameter_Values[i*5+3] = arg_pk_val1;
						this.Parameter_Values[i*5+4] = arg_pk_val2;
					}
				}

				this.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
				this.Exe_Modify_Procedure();			// Modify Procedure ����
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_Spread",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}




		/// <summary>
		/// Save_Spread_CrossTab_Request : �������忡 �ִ� ������ ����
		/// </summary>
		/// <param name="arg_proc_name">���μ��� �̸�</param>
		/// <param name="arg_fgrid">��� ��������</param>
		/// <returns>���� : true , ���� : false </returns>
		public bool Save_Spread_CrossTab_Request2(string arg_proc_name, COM.SSP arg_fgrid, int arg_crs_start, string arg_col_nm1,string arg_col_nm2, string arg_pk_nm1, string arg_pk_nm2, string arg_pk_nm3, string arg_pk_val1, string arg_pk_val2, string arg_pk_val3)
		{
			int col_ct = arg_fgrid.Sheets[0].ColumnCount;	           // Į���� ��
			int row_fixed = arg_fgrid.Sheets[0].RowHeader.Rows.Count ; // �׸��� ������ ��
			
			try
			{
				this.ReDim_Parameter(arg_crs_start+3-1);
				this.Process_Name = arg_proc_name;

				// �Ķ���� �̸� ����
				this.Parameter_Name[0] = "ARG_DIVISION";
				this.Parameter_Name[1] = arg_col_nm1; 
				this.Parameter_Name[2] = arg_col_nm2; 
				this.Parameter_Name[3] = arg_pk_nm1;
				this.Parameter_Name[4] = arg_pk_nm2;
				this.Parameter_Name[5] = arg_pk_nm3;

				// �Ķ������ ������ Type
				this.Parameter_Type[0] = (int)OracleType.VarChar; 
				this.Parameter_Type[1] = (int)OracleType.VarChar;
				this.Parameter_Type[2] = (int)OracleType.VarChar;
				this.Parameter_Type[3] = (int)OracleType.VarChar;
				this.Parameter_Type[4] = (int)OracleType.VarChar;
				this.Parameter_Type[5] = (int)OracleType.VarChar;
	
				//04.DATA ����  			

				// �Ķ���� ���� ������ �迭
				this.Parameter_Values = new string [(arg_fgrid.Sheets[0].Columns.Count-arg_crs_start)*6];
				
				
				for(int i = 0 ; i < arg_fgrid.Sheets[0].Columns.Count-arg_crs_start ; i++)
				{
					if(arg_fgrid.Sheets[0].Cells[0,i+4].Text != "0")
					{
						this.Parameter_Values[i*6]   = "A"; 
						this.Parameter_Values[i*6+1] = arg_fgrid.ActiveSheet.ColumnHeader.Cells[0,i+4].Text;  //���  cs_size 
						this.Parameter_Values[i*6+2] = arg_fgrid.Sheets[0].Cells[0,i+4].Text;                 //��    cs_qty  
						this.Parameter_Values[i*6+3] = arg_pk_val1;
						this.Parameter_Values[i*6+4] = arg_pk_val2;
						this.Parameter_Values[i*6+5] = arg_pk_val3;											  //��    style_cd  
					}
				}

				this.Add_Modify_Parameter(true);		// �Ķ���� �����͸� DataSet�� �߰�
				this.Exe_Modify_Procedure();			// Modify Procedure ����
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_Spread",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}






		/// <summary>
		/// Select_ComCode : �����ڵ� ����Ʈ ��ȸ
		/// </summary>
		/// <param name="arg_factory">����</param>
		/// <param name="arg_code">�ش� �ڵ�</param>
		/// <returns>���� : DataTable , ���� : null </returns>
		public DataTable Select_ComCode(string arg_factory, string arg_code)
		{

			string Proc_Name = "PKG_SCM_CODE.SELECT_COM_CODE";

			this.ReDim_Parameter(3); 
			this.Process_Name = Proc_Name;

			this.Parameter_Name[0] = "ARG_FACTORY";
			this.Parameter_Name[1] = "ARG_COM_CD";
			this.Parameter_Name[2] = "OUT_CURSOR";

			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.VarChar;
			this.Parameter_Type[2] = (int)OracleType.Cursor;

			this.Parameter_Values[0] = arg_factory;
			this.Parameter_Values[1] = arg_code;
			this.Parameter_Values[2] = "";

			this.Add_Select_Parameter(true); 
			DS_Ret = Exe_Select_Procedure();

			if(DS_Ret == null) return null ;

			return  DS_Ret.Tables[Proc_Name];
				 
		}


		/// <summary>
		/// Select_GridHead : �׸��� ��� ���� ��ȸ
		/// </summary>
		/// <param name="arg_pgid">�׸����� ���α׷� ID</param>
		/// <param name="arg_pgseq">�׸��� Seq</param>
		/// <returns>���� : DataTable , ���� : null </returns>
		public DataTable Select_GridHead(string arg_pgid, string arg_pgseq)
		{

			string Proc_Name = "PKG_SCM_TABLE.SELECT_COL_LIST";

			////// DB���� �׸��� Head ���� 
			this.ReDim_Parameter(3);
			this.Process_Name = Proc_Name;

			this.Parameter_Name[0] = "ARG_PG_ID";
			this.Parameter_Name[1] = "ARG_PG_SEQ"; 
			this.Parameter_Name[2] = "OUT_CURSOR"; 
			
			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.VarChar;
			this.Parameter_Type[2] = (int)OracleType.Cursor;

			this.Parameter_Values[0] = arg_pgid;
			this.Parameter_Values[1] = arg_pgseq;
			this.Parameter_Values[2] = "";


			this.Add_Select_Parameter(true); 
			DS_Ret = Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];

		}

		/// <summary>
		/// Select_Lang : SPC_DATA_DIC���̺��� �����͸� ���� �ɴϴ�.
		/// </summary>
		/// <param name="arg_factory">���� �ڵ�</param>
        /// <param name="arg_lang_cd">����ڵ�</param>
		/// <param name="arg_pg_id">���̸�</param>
		/// <returns></returns>
		public DataTable Select_LangDic(string arg_factory, string arg_lang_cd, string arg_pg_id)
		{

            string Proc_Name = "PKG_SPC_DATA_DIC.SELECT_SPC_DATA_DIC_REQ";

			//// DB���� ��� Dictionary ����
			this.ReDim_Parameter(4);
			this.Process_Name = Proc_Name ;


			this.Parameter_Name[0] = "ARG_FACTORY";
			this.Parameter_Name[1] = "ARG_LANG_CD";
            this.Parameter_Name[2] = "ARG_PG_ID";
            this.Parameter_Name[3] = "OUT_CURSOR";

			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.VarChar;
            this.Parameter_Type[2] = (int)OracleType.VarChar;
			this.Parameter_Type[3] = (int)OracleType.Cursor;

			this.Parameter_Values[0] = arg_factory;
			this.Parameter_Values[1] = arg_lang_cd;
            this.Parameter_Values[2] = arg_pg_id;
            this.Parameter_Values[3] = "";

			this.Add_Select_Parameter(true);
			DS_Ret = Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}







        ///// <summary>
        ///// Select_Button : ��ư ���� ��������
        ///// </summary>
        ///// <param name="arg_factory"></param>
        ///// <param name="arg_menu_pg"></param>
        ///// <returns></returns>
        //public DataTable Select_Button(string arg_factory, string arg_user_id, string arg_menu_pg)
        //{

        //    string Proc_Name = "PKG_SPS_MENU.SELECT_FORM_BTN";

        //    //// DB���� ��� Dictionary ����
        //    this.ReDim_Parameter(4);
        //    this.Process_Name = Proc_Name ;


        //    this.Parameter_Name[0] = "ARG_FACTORY";
        //    this.Parameter_Name[1] = "ARG_USER_ID";
        //    this.Parameter_Name[2] = "ARG_MENU_PG";
        //    this.Parameter_Name[3] = "OUT_CURSOR";

        //    this.Parameter_Type[0] = (int)OracleType.VarChar;
        //    this.Parameter_Type[1] = (int)OracleType.VarChar;
        //    this.Parameter_Type[2] = (int)OracleType.VarChar;
        //    this.Parameter_Type[3] = (int)OracleType.Cursor;

        //    this.Parameter_Values[0] = arg_factory;
        //    this.Parameter_Values[1] = COM.ComVar.This_User_AD;  //arg_user_id;
        //    this.Parameter_Values[2] = arg_menu_pg;
        //    this.Parameter_Values[3] = "";

        //    this.Add_Select_Parameter(true);
        //    DS_Ret = Exe_Select_Procedure();

        //    if(DS_Ret == null) return null ;
			
        //    return  DS_Ret.Tables[Proc_Name];
        //}







		/// <summary>
		/// Select_Proc_Error_Check : ���ν��� ERROR�� ýũ �մϴ�.
		/// </summary>
		/// <param name="arg_division">���� ����</param>
		/// <param name="arg_err_div">���� Ÿ��</param>
		/// <returns></returns>
		public bool Select_Proc_Error_Check(string arg_division, string arg_sp_name, string arg_err_div)
		{
			string Year = DateTime.Now.Year.ToString();
			string Month = DateTime.Now.Month.ToString();
			if(Month.Length == 1)
			{
				Month = "0" + Month; 
			}

			string Day = DateTime.Now.Day.ToString();
			if(Day.Length == 1)
			{
				Day = "0" + Day;
			}

			string upd_date  = Year + Month + Day;

			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_PROC_ERR";

			//// DB���� ��� Dictionary ����
			this.ReDim_Parameter(6);
			this.Process_Name = Proc_Name ;


			this.Parameter_Name[0] = "ARG_DIVISION";
			this.Parameter_Name[1] = "ARG_FACTORY";
			this.Parameter_Name[2] = "ARG_SP_NAME";
			this.Parameter_Name[3] = "ARG_UPD_USER";
			this.Parameter_Name[4] = "ARG_ERR_DIV";
			this.Parameter_Name[5] = "OUT_CURSOR";

			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.VarChar;
			this.Parameter_Type[2] = (int)OracleType.VarChar;
			this.Parameter_Type[3] = (int)OracleType.VarChar;
			this.Parameter_Type[4] = (int)OracleType.VarChar;
			this.Parameter_Type[5] = (int)OracleType.Cursor;

			this.Parameter_Values[0] = arg_division;
			this.Parameter_Values[1] = COM.ComVar.This_Factory;
			this.Parameter_Values[2] = arg_sp_name;
			this.Parameter_Values[3] = COM.ComVar.This_User;
			this.Parameter_Values[4] = arg_err_div;
			this.Parameter_Values[5] = "";



			this.Add_Select_Parameter(true);
			DS_Ret = Exe_Select_Procedure();
			
			if(DS_Ret.Tables[Proc_Name].Rows.Count > 0)
				return true;
			else
				return false;
		}

		/// <summary>
		/// Select_Rpm_Error_Check : ���ν��� ERROR�� ýũ �մϴ�.
		/// </summary>
		/// <param name="arg_division">���� ����</param>
		/// <param name="arg_err_div">���� Ÿ��</param>
		/// <returns></returns>
		public bool Select_Rpm_Error_Check(string arg_division, string arg_sp_name, string arg_err_div)
		{
			string Year = DateTime.Now.Year.ToString();
			string Month = DateTime.Now.Month.ToString();
			
			if(Month.Length == 1)
			{
				Month = "0" + Month; 
			}

			string Day = DateTime.Now.Day.ToString();
			if(Day.Length == 1)
			{
				Day = "0" + Day;
			}

			string upd_date  = Year + Month + Day;

			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_RPM_ERR";

			//// DB���� ��� Dictionary ����
			this.ReDim_Parameter(6);
			this.Process_Name = Proc_Name ;


			this.Parameter_Name[0] = "ARG_DIVISION";
			this.Parameter_Name[1] = "ARG_FACTORY";
			this.Parameter_Name[2] = "ARG_SP_NAME";
			this.Parameter_Name[3] = "ARG_UPD_USER";
			this.Parameter_Name[4] = "ARG_ERR_DIV";
			this.Parameter_Name[5] = "OUT_CURSOR";

			this.Parameter_Type[0] = (int)OracleType.VarChar;
			this.Parameter_Type[1] = (int)OracleType.VarChar;
			this.Parameter_Type[2] = (int)OracleType.VarChar;
			this.Parameter_Type[3] = (int)OracleType.VarChar;
			this.Parameter_Type[4] = (int)OracleType.VarChar;
			this.Parameter_Type[5] = (int)OracleType.Cursor;

			this.Parameter_Values[0] = arg_division;
			this.Parameter_Values[1] = COM.ComVar.This_Factory;
			this.Parameter_Values[2] = arg_sp_name;
			this.Parameter_Values[3] = COM.ComVar.This_User;
			this.Parameter_Values[4] = arg_err_div;
			this.Parameter_Values[5] = "";



			this.Add_Select_Parameter(true);
			DS_Ret = Exe_Select_Procedure();
			
			if(DS_Ret.Tables[Proc_Name].Rows.Count > 0)
				return true;
			else
				return false;
		}
	}
}
