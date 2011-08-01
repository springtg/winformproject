using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Drawing2D;
using FarPoint.Win.Spread;
using FarPoint.Win;
using FarPoint.Win.Spread.CellType;

namespace COM
{	
	/// <summary>
	/// SSP에 대한 요약 설명입니다.
	/// </summary>
	public class SSP : FarPoint.Win.Spread.FpSpread
	{
		
		#region 변수 정의

		OraDB MyOraDB = new OraDB();

		/// <summary>
		/// Buffer_CellData : 그리드의 특정셀의 이전값 보존
		/// </summary>
		public string   Buffer_CellData = "";	
		public string[] arr_essential ;

		#endregion

		public SSP()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}


		#region 사용자 메소드 정의

		/// <summary>
		/// Display_Grid : 조회
		/// </summary>
		/// <param name="arg_row">추가하고자 하는 Row</param>
		public  void Display_Grid(DataTable arg_dt)
		{
 									
			try 
			{					
				this.Sheets[0].ClearRange(0,0,this.Sheets[0].Rows.Count,this.Sheets[0].Columns.Count,true);						
				this.Sheets[0].ClearRange(0,0,this.Sheets[0].Rows.Count,1,false);						
				this.Sheets[0].RowCount = arg_dt.Rows.Count ;				
									
				//string[,] arr = new string[arg_dt.Rows.Count,arg_dt.Columns.Count];
				object[,] arr = new object[arg_dt.Rows.Count,arg_dt.Columns.Count];
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{				
					for(int j = 0; j < arg_dt.Columns.Count; j++)
					{											
						switch(Convert.ToString(this.Sheets[0].GetCellType(i,j+1)))				// Cell Type
						{
							case "CheckBoxCellType":
								if(arg_dt.Rows[i].ItemArray[j].ToString()  == "" || arg_dt.Rows[i].ItemArray[j] == null )
								{
									arr[i,j] = "";
								}
								else
								{
									arr[i,j] = Convert.ToBoolean(arg_dt.Rows[i].ItemArray[j]);
								}								
								break;
							case "DateTimeCellType":
								if(arg_dt.Rows[i].ItemArray[j].ToString()  == "" || arg_dt.Rows[i].ItemArray[j] == null )
								{
									arr[i,j] = "";
								}
								else
								{
									arr[i,j] = Convert.ToDateTime(arg_dt.Rows[i].ItemArray[j]);
								}																
								break;
							default:
								arr[i,j] = arg_dt.Rows[i].ItemArray[j];
								break;
						}
				
						//arr[i,j] = arg_dt.Rows[i].ItemArray[j];
					}					
				}
				
				this.Sheets[0].SetArray(0,1,arr) ;

				this.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
				this.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
			}			
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_Grid",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
 
		}



		/// <summary>
		/// Display_Grid : 조회
		/// </summary>
		/// <param name="arg_row">추가하고자 하는 Row</param>
		public  void Display_Grid_Add(DataTable arg_dt)
		{
 									
			try 
			{					
				//				this.Sheets[0].ClearRange(0,0,this.Sheets[0].Rows.Count,this.Sheets[0].Columns.Count,true);						
				//				this.Sheets[0].ClearRange(0,0,this.Sheets[0].Rows.Count,1,false);
				int rowcnt = this.Sheets[0].Rows.Count;
				int row	   = arg_dt.Rows.Count;
				this.Sheets[0].RowCount = arg_dt.Rows.Count + rowcnt;				
									
				//string[,] arr = new string[arg_dt.Rows.Count,arg_dt.Columns.Count];
				object[,] arr = new object[arg_dt.Rows.Count+rowcnt,arg_dt.Columns.Count];


				for(int i = 0; i < rowcnt; i++)
				{						 
					for(int j = 0; j < arg_dt.Columns.Count-1; j++)
					{											
						switch(Convert.ToString(this.Sheets[0].GetCellType(i,j+1)))				// Cell Type
						{
							case "CheckBoxCellType":
								if(this.Sheets[0].Cells[i,j+1].Value.ToString()  == "" || this.Sheets[0].Cells[i,j+1].Value == null )
								{
									arr[i,j] = "";
								}
								else
								{
									arr[i,j] = Convert.ToBoolean(this.Sheets[0].Cells[i,j+1].Value);
								}								
								break;
							case "DateTimeCellType":
								if(this.Sheets[0].Cells[i,j+1].Value.ToString()  == "" || this.Sheets[0].Cells[i,j+1].Value == null)
								{
									arr[i,j] = "";
								}
								else
								{
									arr[i,j] = Convert.ToDateTime(this.Sheets[0].Cells[i,j+1].Value);
								}																
								break;
							default:
								arr[i,j] = this.Sheets[0].Cells[i,j+1].Value;
								break;
						}
				
						//arr[i,j] = arg_dt.Rows[i].ItemArray[j];
					}					
				}
				

				for(int i = rowcnt; i < arg_dt.Rows.Count+rowcnt; i++)
				{	
					int vRow = i - rowcnt;
 
					for(int j = 0; j < arg_dt.Columns.Count; j++)
					{											
						switch(Convert.ToString(this.Sheets[0].GetCellType(i,j+1)))				// Cell Type
						{
							case "CheckBoxCellType":
								if(arg_dt.Rows[vRow].ItemArray[j].ToString()  == "" || arg_dt.Rows[vRow].ItemArray[j] == null )
								{
									arr[i,j] = "";
								}
								else
								{
									arr[i,j] = Convert.ToBoolean(arg_dt.Rows[vRow].ItemArray[j]);
								}								
								break;
							case "DateTimeCellType":
								if(arg_dt.Rows[vRow].ItemArray[j].ToString()  == "" || arg_dt.Rows[vRow].ItemArray[j] == null )
								{
									arr[i,j] = "";
								}
								else
								{
									arr[i,j] = Convert.ToDateTime(arg_dt.Rows[vRow].ItemArray[j]);
								}																
								break;
							default:
								arr[i,j] = arg_dt.Rows[vRow].ItemArray[j];
								break;
						}
				
						//arr[i,j] = arg_dt.Rows[i].ItemArray[j];
					}					
				}
				
				this.Sheets[0].SetArray(0,1,arr) ;

				this.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
				this.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
			}			
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_Grid",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
 
		}




		/// <summary>
		/// Set_Color_Row : ROW글자색깔변경
		/// </summary>
		/// <param name="arg_row">추가하고자 하는 Row</param>
		public  void Set_FontColor_Row(int col_num,string col_val,System.Drawing.Color color)
		{
 									
			try 
			{					
				for(int i = 0; i < this.Sheets[0].RowCount; i++)
				{
					if(this.Sheets[0].Cells[i,col_num].Value.ToString() == col_val)
					{
						this.Sheets[0].Cells[i,1,i,this.Sheets[0].ColumnCount-1].ForeColor = color ;
					}
				}
			}			
			
			catch 
			{

			}
 
		}

		/// <summary>
		/// ClearAll : 초기화
		/// </summary>		
		public void ClearAll()
		{
			try
			{
				this.Sheets[0].ClearRange(0,0,this.Sheets[0].Rows.Count,this.Sheets[0].Columns.Count,true);						
				this.Sheets[0].ClearRange(0,0,this.Sheets[0].Rows.Count,1,false);						
				this.Sheets[0].RowCount = 0 ;
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Clear",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}			
		}


		/// <summary>
		/// Recovery : 복원
		/// </summary>		
		public void Recovery()
		{
			string s ;
			try 
			{					
				for(int i = this.Sheets[0].RowCount-1; i >= 0 ; i--)
				{	
					s = (this.Sheets[0].Cells[i,0].Tag == null) ? "" : this.Sheets[0].Cells[i,0].Tag.ToString();
					
					if(s == "I")
					{
						this.Sheets[0].RemoveRows(i,1) ;						
					}
				} 

				this.Sheets[0].ClearRange(0,0,this.Sheets[0].Rows.Count,1,false);
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Recovery",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}			
		}



		/// <summary>
		/// Add_Row : 행 추가
		/// </summary> 
		/// <param name="arg_imglist"></param>
		/// <param name="arg_show_image_flag"></param>
		public int Add_Row(ImageList arg_imglist, bool arg_show_idu_flag)
		{
			int ret = 0 ;
			try 
			{	 
				 
				//마지막row에 행삽입				
				bool chk = false ;
				//마지막 행 입력 체크
				if(this.Sheets[0].RowCount > 0)
				{
					for(int i = 0; i < this.Sheets[0].ColumnCount; i++)
					{
						if(this.Sheets[0].Cells[this.Sheets[0].RowCount-1,i].Value != null) { chk = true ;}
					}
				}
				else
				{
					chk = true ;
				}

				if(chk)
				{
					this.Sheets[0].RowCount = this.Sheets[0].RowCount + 1;

					if(arg_show_idu_flag)
					{
						this.Sheets[0].Cells[this.Sheets[0].RowCount-1,0].Tag = "I" ;					

						Image img = arg_imglist.Images[0];								
						Bitmap b = new Bitmap(img);								
						FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
						FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
						imgType.BackgroundImage = pic ;
						this.Sheets[0].Cells[this.Sheets[0].RowCount-1,0].CellType = imgType ;			
					}
 
				}
								
				ret = this.Sheets[0].RowCount-1;

			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Add_Row",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return ret;		


		}



		/// <summary>
		/// Add_Row : 행 추가
		/// </summary>
		/// <param name="arg_row">추가하고자 하는 Row</param>
		public int Add_Row(ImageList arg_imglist)
		{
			int ret = 0 ;
			try 
			{	 
				 
				//마지막row에 행삽입				
				bool chk = false ;
				//마지막 행 입력 체크
				if(this.Sheets[0].RowCount > 0)
				{
					for(int i = 0; i < this.Sheets[0].ColumnCount; i++)
					{
						if(this.Sheets[0].Cells[this.Sheets[0].RowCount-1,i].Value != null) { chk = true ;}
					}
				}
				else
				{
					chk = true ;
				}

				if(chk)
				{
					this.Sheets[0].RowCount = this.Sheets[0].RowCount + 1;
					this.Sheets[0].Cells[this.Sheets[0].RowCount-1,0].Tag = "I" ;					

					Image img = arg_imglist.Images[0];								
					Bitmap b = new Bitmap(img);								
					FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
					FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
					imgType.BackgroundImage = pic ;
					this.Sheets[0].Cells[this.Sheets[0].RowCount-1,0].CellType = imgType ;
				}
								
				ret = this.Sheets[0].RowCount-1;

			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Add_Row",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return ret;						
		}


		/// <summary>
		/// Delete_Row : 행 삭제 표시
		/// </summary>
		/// <param name="arg_row">삭제하고자 하는 Row</param>
		public  void Delete_Row(int arg_row,ImageList arg_imglist)
		{
			try
			{	
				string s = (this.Sheets[0].Cells[arg_row,0].Tag == null) ? "" : this.Sheets[0].Cells[arg_row,0].Tag.ToString();
				if ( s != "I")
				{					
					this.Sheets[0].Cells[arg_row,0].Tag = "D" ;						

					Image img = arg_imglist.Images[1];								
					Bitmap b = new Bitmap(img);								
					FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
					FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
					imgType.BackgroundImage = pic ;
					this.Sheets[0].Cells[arg_row,0].CellType = imgType ;	
				}
				else
				{ 
					this.Sheets[0].RemoveRows(arg_row,1) ; 
				}

			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Delete_Row",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}

		/// <summary>
		/// Delete_Row : 행 삭제 표시(그리드 선택된 범위내)
		/// </summary> 
		public  void Delete_Row(ImageList arg_imglist)
		{	
			FarPoint.Win.Spread.Model.CellRange cr ;
			cr = this.Sheets[0].GetSelection(0) ;			
			
			if (cr == null) { return ; }
			int	start_row = cr.Row ;		
			int end_row = cr.Row + cr.RowCount - 1;						

			try
			{				
				for(int i = start_row; i <= end_row; i++)
				{					
					string s = (this.Sheets[0].Cells[i,0].Tag == null) ? "" : this.Sheets[0].Cells[i,0].Tag.ToString();
					if ( s != "I")
					{						
						this.Sheets[0].Cells[i,0].Tag = "D" ;	

						Image img = arg_imglist.Images[1];								
						Bitmap b = new Bitmap(img);								
						FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
						FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
						imgType.BackgroundImage = pic ;
						this.Sheets[0].Cells[i,0].CellType = imgType ;						
					}
					else
					{ 
						this.Sheets[0].RemoveRows(i,1) ; 
					}

				} 
 
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Delete_Row",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}

		/// <summary>
		/// Update_Row : 행 수정 표시
		/// </summary>
		/// <param name="arg_row">삭제하고자 하는 Row</param>
		public  void Update_Row(int arg_row,ImageList arg_imglist)
		{	
			try
			{				
				string s = (this.Sheets[0].Cells[arg_row,0].Tag == null) ? "" : this.Sheets[0].Cells[arg_row,0].Tag.ToString();

				if (s != "I")
				{
					this.Sheets[0].Cells[arg_row,0].Tag = "U" ;						

					Image img = arg_imglist.Images[2];								
					Bitmap b = new Bitmap(img);								
					FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
					FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
					imgType.BackgroundImage = pic ;
					this.Sheets[0].Cells[arg_row,0].CellType = imgType ;					
				}
 
			}

			catch (Exception ex)
			{
				MessageBox.Show( ex.Message.ToString(),"Update_Row",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}

		/// <summary>
		/// Update_Row : 행 수정 표시(그리드 선택된 행)
		/// </summary> 
		public  void Update_Row(ImageList arg_imglist)
		{
			int sel_row = this.Sheets[0].ActiveRowIndex ;			
			int sel_col = this.Sheets[0].ActiveColumnIndex ;

			string sel_val = (this.Sheets[0].Cells[sel_row,sel_col].Value == null) ? "" : this.Sheets[0].Cells[sel_row,sel_col].Value.ToString() ;						
			string s = (this.Sheets[0].Cells[sel_row,0].Tag == null) ? "" : this.Sheets[0].Cells[sel_row,0].Tag.ToString();

			try
			{		
				if(s.ToString() == "I") return;

				
				if (sel_val != Buffer_CellData)  
				{					
					this.Sheets[0].Cells[sel_row,0].Tag = "U" ;						
					Buffer_CellData = "";

					Image img = arg_imglist.Images[2];								
					Bitmap b = new Bitmap(img);								
					FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
					FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
					imgType.BackgroundImage = pic ;
					this.Sheets[0].Cells[sel_row,0].CellType = imgType ;					
				}				
 
			}

			catch (Exception ex)
			{
				MessageBox.Show( ex.Message.ToString(),"Update_Row",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}

		/// <summary>
		/// Update_ActiveRow : 행 수정 표시(그리드 선택된 행)
		/// </summary> 
		public  void Update_ActiveRow(ImageList arg_imglist)
		{
			int sel_row = this.Sheets[0].ActiveRowIndex ;			
			int sel_col = this.Sheets[0].ActiveColumnIndex ;
			
			string s = (this.Sheets[0].Cells[sel_row,0].Tag == null) ? "" : this.Sheets[0].Cells[sel_row,0].Tag.ToString();

			try
			{		
				if(s.ToString() == "I") return;
								
				this.Sheets[0].Cells[sel_row,0].Tag = "U" ;						
				Buffer_CellData = "";

				Image img = arg_imglist.Images[2];								
				Bitmap b = new Bitmap(img);								
				FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
				FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
				imgType.BackgroundImage = pic ;
				this.Sheets[0].Cells[sel_row,0].CellType = imgType ;					
 
			}

			catch (Exception ex)
			{
				MessageBox.Show( ex.Message.ToString(),"Update_Row",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}


		/// <summary>
		/// Update_Row : size Cup Insert 표시
		/// </summary>
		/// <param name="arg_row">수정화면이나 입력작업 처리 Row</param>
		public  void Add_Row_Size(ImageList arg_imglist, int arg_img)
		{	
			try
			{				
				string s = (this.Sheets[0].Cells[0,0].Tag == null) ? "" : this.Sheets[0].Cells[0,0].Tag.ToString();

				if (s != "I")
				{
					this.Sheets[0].Cells[0,0].Tag = "I" ;						

					Image img = arg_imglist.Images[arg_img];								
					Bitmap b = new Bitmap(img);								
					FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
					FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
					imgType.BackgroundImage = pic ;
					this.Sheets[0].Cells[0,0].CellType = imgType ;					
				}
 
			}

			catch (Exception ex)
			{
				MessageBox.Show( ex.Message.ToString(),"Add_Row",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}

 

		#endregion

		/// <summary>
		/// Make_CmbDataTable : 콤보 리스트 데이터 테이블로 반환
		/// </summary>
		/// <param name="arg_div"></param>
		/// <param name="arg_dt"></param>
		/// <returns></returns>
		public DataTable Make_CmbDataTable(ComVar.ComboList_Type arg_div, DataTable arg_dt) 
		{

			int sel_code = 0;
			int sel_name = 0;

			
			try
			{
				switch(arg_div)
				{
					case ComVar.ComboList_Type.ComCode :   //공통코드에서 

						sel_code = (int)TBSCM_CODE.IxCOM_VALUE1;
						sel_name = (int)TBSCM_CODE.IxCOM_VALUE1;

						break;

					case ComVar.ComboList_Type.Query  :   //쿼리문장에서

						sel_code = 0;

						if(arg_dt.Columns.Count > 1)
						{
							sel_name = 1;
						}
						else
						{
							sel_name = 0;
						}

						break; 

					case ComVar.ComboList_Type.ComCode_Name : //공통코드에서 코드 : 코드명 

						sel_code = (int)TBSCM_CODE.IxCOM_VALUE1;
						sel_name = (int)TBSCM_CODE.IxCOM_DESC1;

						break;


				}




				
				DataTable rtn_dt = new DataTable();
				DataRow dr;


				rtn_dt.Columns.Add("CODE", typeof(string) );
				rtn_dt.Columns.Add("NAME", typeof(string) ); 

				dr = rtn_dt.NewRow();
				dr["CODE"] = "";
				dr["NAME"] = "";
				rtn_dt.Rows.Add(dr);

				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					dr = rtn_dt.NewRow();
					dr["CODE"] = arg_dt.Rows[i].ItemArray[sel_code].ToString();
					dr["NAME"] = arg_dt.Rows[i].ItemArray[sel_name].ToString();
					rtn_dt.Rows.Add(dr);

				}

				return rtn_dt;
			}

			catch (Exception ex)
			{
				MessageBox.Show( ex.Message.ToString(),"Make_CmbDataTable",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return null;
			}



		}




		/// <summary>
		/// Make_Query : string으로 받은 쿼리문장에서 @값 추출해서 실제 값 적용 -> 쿼리 실행해서 DataTable 로 반환
		/// </summary>
		/// <param name="arg_query">받은 쿼리문장</param>
		/// <returns>DataTable</returns>
		public DataTable Make_Query(string arg_query)
		{
			DataSet DS_Ret ;

			int index = 0; 

			string strDelimiter = " ";
			char[] delimiter = strDelimiter.ToCharArray();
 
			try
			{
				string[] tokenArray = arg_query.Split(delimiter); 
				string[] query_data = new string[tokenArray.Length]; 

				string real_query = "";
				DataTable return_dt;

				//--------------------------------------------------------------------------------
				//1. 공백으로 먼저 자르기
				//-------------------------------------------------------------------------------- 

				foreach( string token in tokenArray )
				{
					if ( !token.Equals("") || !token.Equals(null) ) 
					{
						query_data[index] = token;
						index++;
					} 
				}


				//--------------------------------------------------------------------------------
				//2. @ 들어있는 query_data 추출
				//-------------------------------------------------------------------------------- 

				for(int i = 0; i < query_data.Length; i++)
				{
					if(query_data[i] == null || query_data[i] == "") continue;

					if("@" == query_data[i].Substring(0, 1))
					{
						query_data[i] = Change_RealValue(query_data[i]);
					}
				}


				//--------------------------------------------------------------------------------
				//3. 실 데이터 값 넣어서 쿼리 만들기 -> 실행
				//-------------------------------------------------------------------------------- 

				for(int i = 0; i < query_data.Length; i++)
				{
					if(query_data[i] == null || query_data[i] == "") continue;

					real_query = real_query + query_data[i] + " ";
				}


				DS_Ret = this.MyOraDB.Exe_Select_Query(real_query);
				if(DS_Ret == null) return null;

				return return_dt = DS_Ret.Tables[0];
			}
			catch (Exception ex)
			{
				MessageBox.Show( ex.Message.ToString(),"Make_Query",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return null;
			}

		}



		/// <summary>
		/// Change_RealValue : 구분자 들어있는 데이터를 실 데이터 값으로 치환
		/// </summary>
		/// <param name="arg_data">@포함 문자열</param>
		/// <returns></returns>
		public string Change_RealValue(string arg_data)
		{
			string return_value = "";

			switch(arg_data)
			{
				case "@factory":

					return_value = "'" + ComVar.This_Factory + "'";

					break;
 
			}

			return return_value;
		}

 

		public void	Spread_Clear(FarPoint.Win.Spread.SheetView arg_shread)
		{
			arg_shread.ClearRange(0, 0, arg_shread.RowCount, arg_shread.ColumnCount, true);
		} 


		#region Custom Skin Spread Setting 
		/// <summary>
		/// Set_Spread : 공통 그리드 설정 
		/// </summary>
		/// <param name="arg_pgid">적용시킬 프로그램 아이디</param>
		/// <param name="arg_pgseq">적용시킬 프로그램 순번</param>
		/// <param name="arg_hcount">그리드 헤더 수</param>
		/// <param name="arg_lang">언어코드</param> 
		/// <param name="arg_type">그리드 타입 (Search, Modify)</param> 
		/// <param name="arg_autosize">자동 컬럼 너비 맞추기 여부</param>
		public void Set_Spread_Comm( string arg_pgid, string arg_pgseq, int arg_hcount, string arg_lang, ComVar.Grid_Type arg_type, bool arg_autosize)
		{
			try
			{

				DataTable dt_list = null, dt_cmblist = null, dt_make_cmblist = null; 			
				FarPoint.Win.Spread.ColumnHeader ch;
				FarPoint.Win.Spread.StyleInfo style = new FarPoint.Win.Spread.StyleInfo();
				string s ;

				COM.ComVar.ComboList_Type data_list_type = COM.ComVar.ComboList_Type.ComCode;
 

				#region CellType 정의


				this.Sheets[0].DataAutoCellTypes = false;
 

				FarPoint.Win.Spread.CellType.TextCellType     cell_text = null;
				FarPoint.Win.Spread.CellType.CheckBoxCellType cell_chk  = null; 
				FarPoint.Win.Spread.CellType.ButtonCellType   cell_pop  = null;
				FarPoint.Win.Spread.CellType.CurrencyCellType cell_curr = null;
				FarPoint.Win.Spread.CellType.DateTimeCellType cell_date = null;
				FarPoint.Win.Spread.CellType.NumberCellType   cell_num  = null;
				FarPoint.Win.Spread.CellType.MaskCellType     cell_mask = null;			


				
				 
				#endregion 

				#region 선택 영역 세팅

				//selection setting			  			
				this.Sheets[0].SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors;
				this.Sheets[0].SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.MultiRange;
				this.Sheets[0].SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row; 

				this.Sheets[0].OperationMode = OperationMode.Normal;
 
				
				#endregion

				#region Font

				//font
				this.Sheets[0].DefaultStyle.Font =  new System.Drawing.Font("Verdana", 9F) ;						

				ch = this.Sheets[0].ColumnHeader;
				
				this.Sheets[0].Rows.Default.Height = 18;
				

				#endregion

			
				////// DB에서 그리드 정보 추출 
				dt_list =this.MyOraDB.Select_GridHead(arg_pgid,arg_pgseq);
				if (dt_list== null || dt_list.Rows.Count == 0) return ;  
 
				#region 초기화

				this.Sheets[0].ClearRange(0, 0, this.Sheets[0].RowCount, this.Sheets[0].ColumnCount, true);															
				this.Sheets[0].ColumnCount = dt_list.Rows.Count + 1;
				this.Sheets[0].RowCount = 0;
				this.Sheets[0].ColumnHeaderRowCount = arg_hcount + 1;
				ch.Cells[arg_hcount,0].Text = "" ; //1st column header
				ch.Rows[0].Visible = false;	 

				this.BorderStyle = BorderStyle.FixedSingle; 

				#endregion
					
				#region 디자인 세팅

				this.Sheets[0].Columns[0].BackColor = COM.ComVar.GridCol0_Color; 
				this.Sheets[0].Columns[0].Locked = true;

				this.Sheets[0].GrayAreaBackColor = COM.ComVar.GridEmptyColor;
				this.Sheets[0].AlternatingRows[0].BackColor = COM.ComVar.GridAlternate_Color; 
				
				
				this.Sheets[0].SelectionBackColor = COM.ComVar.GridHigh_Color;
				this.Sheets[0].SelectionForeColor = COM.ComVar.GridHighFore_Color;  


				
				style.Font = new System.Drawing.Font("Verdana", 9F);
				style.ForeColor = COM.ComVar.GridForeColor; 

				switch(arg_type)
				{
					case COM.ComVar.Grid_Type.ForModify:
						style.BackColor = COM.ComVar.GridDarkFixed_Color; 
						break;

					case COM.ComVar.Grid_Type.ForSearch:
						style.BackColor = COM.ComVar.GridLightFixed_Color; 											
						break;
				}

				
				ch.DefaultStyle = style; 

				

				#endregion

				#region 헤더 정렬 속성

				ch.Rows[1].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;					

				if (arg_hcount==2)		// 2번째 Header
				{
					ch.Rows[2].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
				}

				if (arg_hcount==3)		// 3번째 Header
				{
					ch.Rows[2].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
					ch.Rows[3].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
				}

				if (arg_hcount==4)		// 4번째 Header
				{
					ch.Rows[2].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
					ch.Rows[3].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
					ch.Rows[4].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
				}

				#endregion  
					
				#region 전체 속성 지정

				this.Sheets[0].RowHeaderColumnCount = ComVar.GridCol_Fixed ; 					
				this.Sheets[0].Columns[0].Width = ComVar.GridCol0_Width-2 ;							
					
				this.Sheets[0].FrozenColumnCount = Convert.ToInt32(dt_list.Rows[0].ItemArray[(int)TBSCM_TABLE.IxFROZENCOL].ToString());	// 칼럼 Frozen
				this.Sheets[0].FrozenRowCount    = Convert.ToInt32(dt_list.Rows[0].ItemArray[(int)TBSCM_TABLE.IxFROZENROW].ToString());	// 행 Frozen																								
										
				arr_essential = new string[dt_list.Rows.Count+1] ;

				for(int i = 1; i < dt_list.Rows.Count + 1; i++)
				{
						
					arr_essential[i] = (dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxESSENTIAL_YN] == null) ? "" : dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxESSENTIAL_YN].ToString() ;
						

					#region cell type

					switch(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxCELLTYPE].ToString())				// Cell Type
					{
						case "TEXT":

							cell_text = new TextCellType();

							s = (dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxMAX_WIDTH] == null) ? "" : dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxMAX_WIDTH].ToString() ;
							if(s != "")																
								try
								{
									cell_text.MaxLength = int.Parse(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxMAX_WIDTH].ToString()) ;
								}
								catch{}

								
							s = (dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxCHAR_CASE] == null) ? "UPPER" : dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxCHAR_CASE].ToString() ;
							if(s == "UPPER") // || s == "")
							{
								cell_text.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper ;
							}
							this.Sheets[0].Columns[i].CellType = cell_text ;																
							break;

						case "DATE":

							cell_date = new DateTimeCellType();

							cell_date.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.ShortDate ;
							this.Sheets[0].Columns[i].CellType = cell_date ;									
							
							break;

						case "CHECKBOX":

							cell_chk = new CheckBoxCellType();

							this.Sheets[0].Columns[i].CellType = cell_chk ;									
							break;
							
							//추가
						case "POPUP":
	
							cell_pop = new ButtonCellType();
								
							this.Sheets[0].Columns[i].CellType = cell_pop ;	
							this.Sheets[0].SetRowHeight(0, 30);
							break;

							//추가
						case "CURRENCY":

							cell_curr = new CurrencyCellType();

							this.Sheets[0].Columns[i].CellType = cell_curr ;
							break;

							//추가
						case "MASKEDIT":	
								
							cell_mask = new MaskCellType();

							cell_mask.Mask = dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString() ;
							cell_mask.MaskChar = Convert.ToChar("#");
							this.Sheets[0].Columns[i].CellType = cell_mask ;																
							break;

							//추가
						case "NUMBER":

							cell_num = new NumberCellType();

							if(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString().Trim() == "")
							{
								cell_num.DecimalPlaces = 0 ;
							}
							else
							{	
								cell_num.DecimalPlaces = Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString()) ;									
							}
																
							cell_num.Separator = "," ;
							cell_num.ShowSeparator = true ;
								
							//max value
							s = (dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxMAX_NUMBER] == null) ? "" : dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxMAX_NUMBER].ToString() ;
							if(s == "")								
							{
								cell_num.MaximumValue = 999999999999 ;
							}
							else
							{
								cell_num.MaximumValue = double.Parse(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxMAX_NUMBER].ToString()) ;
							}
								
							//min value
							s = (dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxMIN_NUMBER] == null) ? "" : dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxMIN_NUMBER].ToString() ;
							if(s == "")
							{
								cell_num.MinimumValue = -999999999999 ;
							}
							else
							{
								cell_num.MinimumValue = double.Parse(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxMIN_NUMBER].ToString()) ;
							}
								
							this.Sheets[0].Columns[i].CellType = cell_num ;								
							break;							

						case "COMBOBOX":
							 
						switch(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_TYPE].ToString()))	// data_list_type
						{																
							case (int)ComVar.ComboList_Type.ComCode :      //공통코드에서 ComboList 추출
										
								dt_cmblist = this.MyOraDB.Select_ComCode(ComVar.This_Factory, dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString());										
								data_list_type = ComVar.ComboList_Type.ComCode;

								break;

							case (int)ComVar.ComboList_Type.Query :      //쿼리에서 ComboList 추출 

								dt_cmblist = Make_Query(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_QUERY].ToString().Trim());
								data_list_type = ComVar.ComboList_Type.Query;

								break; 

							case (int)ComVar.ComboList_Type.ComCode_Name :
											
								dt_cmblist = this.MyOraDB.Select_ComCode(ComVar.This_Factory, dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString());										
								data_list_type = ComVar.ComboList_Type.ComCode_Name;
											
								break;
						}

							dt_make_cmblist = this.Make_CmbDataTable(data_list_type, dt_cmblist);
								
							COM.SSPComboBoxCellType cell_combo = new COM.SSPComboBoxCellType(dt_make_cmblist, "NAME", "CODE", false);  
							this.ActiveSheet.Columns[i].CellType = cell_combo;


							/*
							switch(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_TYPE].ToString()))	// data_list_type
							{																
								case (int)ComVar.ComboList_Type.ComCode :      //공통코드에서 ComboList 추출
										
									if(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString() != "")					// Data_LIst_Cd
									{
										//combo_list
										dt_cmblist = this.MyOraDB.Select_ComCode(ComVar.This_Factory, dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString());										
										cell_combo.Items = this.Make_CmbDataList(ComVar.ComboList_Type.ComCode, dt_cmblist);										
										this.Sheets[0].Columns[i].CellType = cell_combo ; 
									} 
   
									break;

								case (int)ComVar.ComboList_Type.Query :      //쿼리에서 ComboList 추출	
										
									if(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_QUERY].ToString() != "")				//Data_List_Query
									{
										//									//combo_list
											
										dt_cmblist = Make_Query(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_QUERY].ToString().Trim());
										cell_combo.Items = this.Make_CmbDataList(ComVar.ComboList_Type.Query, dt_cmblist);										
										this.Sheets[0].Columns[i].CellType = cell_combo ;
									}

									break;

								case (int)ComVar.ComboList_Type.ComCode_Name :
										
									if(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString() != "")					// Data_LIst_Cd
									{
										//combo_list
										dt_cmblist = this.MyOraDB.Select_ComCode(ComVar.This_Factory, dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString());
										cell_combo.Items = this.Make_CmbDataList(ComVar.ComboList_Type.ComCode_Name, dt_cmblist);										
										this.Sheets[0].Columns[i].CellType = cell_combo ;
									}

									break;

							}
							
								*/

 
							break;

						default:
							break;
					} //end switch
					
					#endregion

					#region 기타 속성 - Width, Lock, Visible, Autosort, TextAlign, ...
																							 						 
					this.Sheets[0].Columns[i].Width = Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxWIDTH].ToString());						
						
					//this.Sheets[0].Columns[i].Locked = (Convert.ToBoolean(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxLOCK_YN]) == false)?true:false;  // 칼럼 에디터 가능 여부
 
 
					if(Convert.ToBoolean(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxLOCK_YN]) )
					{
						// 컬럼 수정 가능
						this.Sheets[0].Columns[i].Locked = false;

						// 컬럼 전체 색깔 처리 - 글자색 : 파란색
						//this.Sheets[0].Columns[i].BackColor = COM.ComVar.ClrImportant;

						this.Sheets[0].Columns[i].ForeColor = COM.ComVar.ClrImportant;

					}
					else
					{
						// 컬럼 수정 불가
						this.Sheets[0].Columns[i].Locked = true;
					}
						


					this.Sheets[0].Columns[i].Visible = Convert.ToBoolean(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxVISIBLE_YN]);			// 칼럼 visible 

						
					this.Sheets[0].Columns[i].AllowAutoSort = true ; //Convert.ToBoolean(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxAUTOSORT_YN]);	// 칼럼 별자동 sort						
						
					switch(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxHALIGN].ToString())									// 칼럼정렬
					{
						case "LEFT":
							this.Sheets[0].Columns[i].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left ; 								
							break;

						case "CENTER":
							this.Sheets[0].Columns[i].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center ; 																
							break;

						case "RIGHT":
							this.Sheets[0].Columns[i].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right ; 								
							break;

						default:
							break;
					}



					//콤보박스 셀 속성
						
					//this.ButtonDrawMode = ButtonDrawModes.CurrentCell; 

					 
					#endregion 

					#region 헤더 데이터

					ch.Cells[0,i].Text = dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxCOL_NAME].ToString() ;  // 테이블 칼럼명						
 	
					ch.Cells[1,i].Text = dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC1].ToString() ; // 상단

					if(arg_hcount == 2)	
					{
						ch.Cells[2,i].Text = dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC2].ToString(); // 하단
					}

					if(arg_hcount == 3)	
					{
						ch.Cells[2,i].Text = dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC2].ToString();	
						ch.Cells[3,i].Text = dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC3].ToString(); // 하단
					}

					if(arg_hcount == 4)	
					{
						ch.Cells[2,i].Text = dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC2].ToString();	
						ch.Cells[3,i].Text = dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC3].ToString();
						ch.Cells[4,i].Text = dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC4].ToString(); // 하단
					}

					#endregion 

					#region 헤더 글자색, 배경색 지정

					//등록된 Title Header에 backcolor,forecolor 설정
					if(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxBACKCOLOR].ToString() != "")							// 배경색
					{							
						ch.Cells[1,i].BackColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxBACKCOLOR].ToString()));							

						if(arg_hcount == 2)
						{
							ch.Cells[1,i, 2, i].BackColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxBACKCOLOR].ToString()));								
						}

						if(arg_hcount == 3)
						{
							ch.Cells[1,i,3,i].BackColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxBACKCOLOR].ToString()));								
						}

						if(arg_hcount == 4)
						{
							ch.Cells[1,i,4,i].BackColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxBACKCOLOR].ToString()));								
						}

					}

					if(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxFORECOLOR].ToString() != "")							// 글자색
					{
						ch.Cells[1,i].ForeColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxFORECOLOR].ToString()));							
						ch.Cells[1,i].ForeColor = Color.Beige ;

						if(arg_hcount == 2)
						{
							ch.Cells[1,i, 2, i].ForeColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxFORECOLOR].ToString()));															
						}

						if(arg_hcount == 3)
						{
							ch.Cells[1, i, 3, i].ForeColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxFORECOLOR].ToString()));															
						}

						if(arg_hcount == 4)
						{
							ch.Cells[1, i, 4, i].ForeColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - 1].ItemArray[(int)TBSCM_TABLE.IxFORECOLOR].ToString()));															
						}						 

					}


					#endregion 


				} //end for
 
					
				#region scroll 범위

				this.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
				this.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded; 
					
				#endregion

				/*
					// tooltip 속성
					this.TextTipPolicy = TextTipPolicy.FloatingFocusOnly; 
					*/

				#endregion


				
				 
				 
			}	
			catch (Exception ex)
			{
				MessageBox.Show( ex.Message.ToString(),"Set_Grid",MessageBoxButtons.OK,MessageBoxIcon.Error);
				
			}
		}




		/// <summary>
		/// Set_Spread : 공통 그리드 설정 
		/// </summary>
		/// <param name="arg_pgid">적용시킬 프로그램 아이디</param>
		/// <param name="arg_pgseq">적용시킬 프로그램 순번</param>
		/// <param name="arg_hcount">그리드 헤더 수</param>
		/// <param name="arg_lang">언어코드</param> 
		/// <param name="arg_type">그리드 타입 (Search, Modify)</param> 
		/// <param name="arg_autosize">자동 컬럼 너비 맞추기 여부</param>
		public void Set_Spread_Comm( string arg_pgid, string arg_pgseq, int arg_hcount, string arg_lang, ComVar.Grid_Type arg_type, bool arg_autosize, bool arg_old_clear)
		{
			try
			{

				DataTable dt_list = null, dt_cmblist = null, dt_make_cmblist = null; 			
				FarPoint.Win.Spread.ColumnHeader ch = this.Sheets[0].ColumnHeader; 
				FarPoint.Win.Spread.StyleInfo style = new FarPoint.Win.Spread.StyleInfo();
				string s ;

				COM.ComVar.ComboList_Type data_list_type = COM.ComVar.ComboList_Type.ComCode;
 

				#region CellType 정의
 

				FarPoint.Win.Spread.CellType.TextCellType     cell_text = null;
				FarPoint.Win.Spread.CellType.CheckBoxCellType cell_chk  = null; 
				FarPoint.Win.Spread.CellType.ButtonCellType   cell_pop  = null;
				FarPoint.Win.Spread.CellType.CurrencyCellType cell_curr = null;
				FarPoint.Win.Spread.CellType.DateTimeCellType cell_date = null;
				FarPoint.Win.Spread.CellType.NumberCellType   cell_num  = null;
				FarPoint.Win.Spread.CellType.MaskCellType     cell_mask = null;			


				
				 
				#endregion  
 
			
				////// DB에서 그리드 정보 추출 
				dt_list =this.MyOraDB.Select_GridHead(arg_pgid,arg_pgseq);
				if (dt_list== null || dt_list.Rows.Count == 0) return ;  
 
				#region 초기화
 

				this.Sheets[0].ColumnCount = this.Sheets[0].ColumnCount + dt_list.Rows.Count;

				#endregion
				
				#region 전체 속성 지정

				 
				int start_col = this.Sheets[0].ColumnCount - dt_list.Rows.Count;

				for(int i = start_col; i < this.Sheets[0].ColumnCount; i++)
				{
					 
					#region cell type

					switch(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxCELLTYPE].ToString())				// Cell Type
					{
						case "TEXT":

							cell_text = new TextCellType();

							s = (dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxMAX_WIDTH] == null) ? "" : dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxMAX_WIDTH].ToString() ;
							if(s != "")																
								try
								{
									cell_text.MaxLength = int.Parse(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxMAX_WIDTH].ToString()) ;
								}
								catch{}

								
							s = (dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxCHAR_CASE] == null) ? "UPPER" : dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxCHAR_CASE].ToString() ;
							if(s == "UPPER") // || s == "")
							{
								cell_text.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper ;
							}
							this.Sheets[0].Columns[i].CellType = cell_text ;																
							break;

						case "DATE":

							cell_date = new DateTimeCellType();

							cell_date.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.ShortDate ;
							this.Sheets[0].Columns[i].CellType = cell_date ;									
							
							break;

						case "CHECKBOX":

							cell_chk = new CheckBoxCellType();

							this.Sheets[0].Columns[i].CellType = cell_chk ;									
							break;
							
							//추가
						case "POPUP":
	
							cell_pop = new ButtonCellType();
								
							this.Sheets[0].Columns[i].CellType = cell_pop ;	
							this.Sheets[0].SetRowHeight(0, 30);
							break;

							//추가
						case "CURRENCY":

							cell_curr = new CurrencyCellType();

							this.Sheets[0].Columns[i].CellType = cell_curr ;
							break;

							//추가
						case "MASKEDIT":	
								
							cell_mask = new MaskCellType();

							cell_mask.Mask = dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString() ;
							cell_mask.MaskChar = Convert.ToChar("#");
							this.Sheets[0].Columns[i].CellType = cell_mask ;																
							break;

							//추가
						case "NUMBER":

							cell_num = new NumberCellType();

							if(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString() == "")
							{
								cell_num.DecimalPlaces = 0 ;
							}
							else
							{	
								cell_num.DecimalPlaces = Convert.ToInt32(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString()) ;									
							}
																
							cell_num.Separator = "," ;
							cell_num.ShowSeparator = true ;
								
							//max value
							s = (dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxMAX_NUMBER] == null) ? "" : dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxMAX_NUMBER].ToString() ;
							if(s == "")								
							{
								cell_num.MaximumValue = 999999999999 ;
							}
							else
							{
								cell_num.MaximumValue = double.Parse(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxMAX_NUMBER].ToString()) ;
							}
								
							//min value
							s = (dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxMIN_NUMBER] == null) ? "" : dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxMIN_NUMBER].ToString() ;
							if(s == "")
							{
								cell_num.MinimumValue = -999999999999 ;
							}
							else
							{
								cell_num.MinimumValue = double.Parse(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxMIN_NUMBER].ToString()) ;
							}
								
							this.Sheets[0].Columns[i].CellType = cell_num ;								
							break;							

						case "COMBOBOX":
							 
						switch(Convert.ToInt32(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_TYPE].ToString()))	// data_list_type
						{																
							case (int)ComVar.ComboList_Type.ComCode :      //공통코드에서 ComboList 추출
										
								dt_cmblist = this.MyOraDB.Select_ComCode(ComVar.This_Factory, dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString());										
								data_list_type = ComVar.ComboList_Type.ComCode;

								break;

							case (int)ComVar.ComboList_Type.Query :      //쿼리에서 ComboList 추출 

								dt_cmblist = Make_Query(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_QUERY].ToString().Trim());
								data_list_type = ComVar.ComboList_Type.Query;

								break; 

							case (int)ComVar.ComboList_Type.ComCode_Name :
											
								dt_cmblist = this.MyOraDB.Select_ComCode(ComVar.This_Factory, dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxDATA_LIST_CD].ToString());										
								data_list_type = ComVar.ComboList_Type.ComCode_Name;
											
								break;
						}

							dt_make_cmblist = this.Make_CmbDataTable(data_list_type, dt_cmblist);
								
							COM.SSPComboBoxCellType cell_combo = new COM.SSPComboBoxCellType(dt_make_cmblist, "NAME", "CODE", false);  
							this.ActiveSheet.Columns[i].CellType = cell_combo;

 

 
							break;

						default:
							break;
					} //end switch
					
					#endregion

					#region 기타 속성 - Width, Lock, Visible, Autosort, TextAlign, ...
																							 						 
					this.Sheets[0].Columns[i].Width = Convert.ToInt32(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxWIDTH].ToString());						
						
					//this.Sheets[0].Columns[i].Locked = (Convert.ToBoolean(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxLOCK_YN]) == false)?true:false;  // 칼럼 에디터 가능 여부
 
 
					if(Convert.ToBoolean(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxLOCK_YN]) )
					{
						// 컬럼 수정 가능
						this.Sheets[0].Columns[i].Locked = false;

						// 컬럼 전체 색깔 처리 - 글자색 : 파란색
						//this.Sheets[0].Columns[i].BackColor = COM.ComVar.ClrImportant;

						this.Sheets[0].Columns[i].ForeColor = COM.ComVar.ClrImportant;

					}
					else
					{
						// 컬럼 수정 불가
						this.Sheets[0].Columns[i].Locked = true;
					}
						


					this.Sheets[0].Columns[i].Visible = Convert.ToBoolean(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxVISIBLE_YN]);			// 칼럼 visible 

						
					this.Sheets[0].Columns[i].AllowAutoSort = true ; //Convert.ToBoolean(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxAUTOSORT_YN]);	// 칼럼 별자동 sort						
						
					switch(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxHALIGN].ToString())									// 칼럼정렬
					{
						case "LEFT":
							this.Sheets[0].Columns[i].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left ; 								
							break;

						case "CENTER":
							this.Sheets[0].Columns[i].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center ; 																
							break;

						case "RIGHT":
							this.Sheets[0].Columns[i].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right ; 								
							break;

						default:
							break;
					}
 

					 
					#endregion 

					#region 헤더 데이터

					ch.Cells[0,i].Text = dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxCOL_NAME].ToString() ;  // 테이블 칼럼명						
 	
					ch.Cells[1,i].Text = dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC1].ToString() ; // 상단

					if(arg_hcount == 2)	
					{
						ch.Cells[2,i].Text = dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC2].ToString(); // 하단
					}

					if(arg_hcount == 3)	
					{
						ch.Cells[2,i].Text = dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC2].ToString();	
						ch.Cells[3,i].Text = dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC3].ToString(); // 하단
					}

					if(arg_hcount == 4)	
					{
						ch.Cells[2,i].Text = dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC2].ToString();	
						ch.Cells[3,i].Text = dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC3].ToString();
						ch.Cells[4,i].Text = dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxHEAD_DESC4].ToString(); // 하단
					}

					#endregion 

					#region 헤더 글자색, 배경색 지정

					//등록된 Title Header에 backcolor,forecolor 설정
					if(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxBACKCOLOR].ToString() != "")							// 배경색
					{							
						ch.Cells[1,i].BackColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxBACKCOLOR].ToString()));							

						if(arg_hcount == 2)
						{
							ch.Cells[1,i, 2, i].BackColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxBACKCOLOR].ToString()));								
						}

						if(arg_hcount == 3)
						{
							ch.Cells[1,i,3,i].BackColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxBACKCOLOR].ToString()));								
						}

						if(arg_hcount == 4)
						{
							ch.Cells[1,i,4,i].BackColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxBACKCOLOR].ToString()));								
						}

					}

					if(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxFORECOLOR].ToString() != "")							// 글자색
					{
						ch.Cells[1,i].ForeColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxFORECOLOR].ToString()));							
						ch.Cells[1,i].ForeColor = Color.Beige ;

						if(arg_hcount == 2)
						{
							ch.Cells[1,i, 2, i].ForeColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxFORECOLOR].ToString()));															
						}

						if(arg_hcount == 3)
						{
							ch.Cells[1, i, 3, i].ForeColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxFORECOLOR].ToString()));															
						}

						if(arg_hcount == 4)
						{
							ch.Cells[1, i, 4, i].ForeColor = Color.FromArgb(Convert.ToInt32(dt_list.Rows[i - start_col].ItemArray[(int)TBSCM_TABLE.IxFORECOLOR].ToString()));															
						}						 

					}


					#endregion 


				} //end for
 
					
				#region scroll 범위

				this.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
				this.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded; 
					
				#endregion
 

				#endregion


				
				 
				 
			}	
			catch (Exception ex)
			{
				MessageBox.Show( ex.Message.ToString(),"Set_Grid",MessageBoxButtons.OK,MessageBoxIcon.Error);
				
			}
		}

		#endregion
    
   

		/// <summary>
		/// Display_Sum_Bottom : 하단에 합계
		/// </summary>		
		/// <param name="arg_width">column width</param>		
		/// <param name="arg_startcol">시작 column no</param>
		public  void Display_Sum_Bottom(int arg_col)
		{
 									
			try 
			{													
				
				int irow = this.Sheets[0].RowCount-1 ;
				string irowstr = irow.ToString() ;
				
				this.ActiveSheet.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1; 
				
				string istr = (arg_col+1).ToString() ;					
				this.Sheets[0].Cells[irow,arg_col].Formula = "SUM(R1C" + istr + ":R" + irowstr + "C" + istr + ")" ;

			}			
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_Sum_Bottom",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}						
		}

		/// <summary>
		/// Display_CrossTab_Head : 크로스탭 헤드 조회
		/// </summary>		
		/// <param name="arg_width">column width</param>		
		/// <param name="arg_startcol">시작 column no</param>
		public  void Display_CrossTab_Head(DataTable dt_col,int arg_width,int arg_startcol)
		{
 									
			try 
			{									
				this.Sheets[0].Columns.Count =  arg_startcol ;
				this.Sheets[0].Columns.Count =  this.Sheets[0].Columns.Count + dt_col.Rows.Count ;				

				for(int i = 0; i < dt_col.Rows.Count; i++)
				{														
					this.Sheets[0].ColumnHeader.Cells[this.Sheets[0].ColumnHeader.RowCount-1,arg_startcol+i].Text = dt_col.Rows[i].ItemArray[0].ToString() ;
					this.Sheets[0].Columns[arg_startcol+i].Width = arg_width ;
					//this[this.Cols.Fixed+1,arg_startcol+i] = dt_col.Rows[i].ItemArray[0];					
					//this.Cols[arg_startcol+i].Width = arg_width ;
				}								
			}			
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_CrossTab_Head",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}						
		}

		/// <summary>
		/// Display_CrossTab : CrossTab조회
		/// </summary>
		/// <param name="arg_dt">data table</param>
		/// <param name="arg_key_fr">key field from 칼럼번호</param>		
		/// <param name="arg_key_to">key field to 칼럼번호</param>
		/// <param name="arg_colhead">column head 칼럼번호</param>		
		/// <param name="arg_display">display 칼럼번호</param>							
		public  void Display_CrossTab(DataTable arg_dt,int arg_key_fr,int arg_key_to,int arg_colhead,int arg_display,bool arg_tree)
		{
 									
			string str_newkey = "" ;
			string str_oldkey = "" ;
			
			try 
			{					
				//ROW 초기화
				this.Sheets[0].ClearRange(0,0,this.Sheets[0].Rows.Count,this.Sheets[0].Columns.Count,true);						
				this.Sheets[0].ClearRange(0,0,this.Sheets[0].Rows.Count,1,false);										
				this.Sheets[0].RowCount = 0 ;					

				//loop - DATA row
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{		
					str_newkey = "" ;
					
					//key field 생성
					for(int k = arg_key_fr; k <= arg_key_to; k++)
					{
						str_newkey = str_newkey + arg_dt.Rows[i].ItemArray[k].ToString() ;
					}					
															
					//loop -DATA column(마지막ROW는 제외)
					for(int j = 0; j < arg_dt.Columns.Count; j++)
					{							
						if(j <= arg_colhead)
						{
							//key field가 변경시 새로운 row 생성
							if(str_newkey != str_oldkey && j == 0)
							{
																
								if(arg_tree)
								{	
									this.Sheets[0].RowCount = this.Sheets[0].RowCount + 1  ;
								}
								else
								{
									this.Sheets[0].RowCount = this.Sheets[0].RowCount + 1  ; 
								}
							}
							 

							//칼럼이 크로스탭 항목일때:사이즈
							if(j == arg_colhead)
							{
								//칼럼헤드와 비교하여 동일하면 데이타 디스플레이
								//for(int m = arg_colhead; m < this.Cols.Count-1; m++)
								//{
								//	if(arg_dt.Rows[i].ItemArray[j].ToString() == this[this.Rows.Fixed-1,m+1].ToString() )
								//	{
								//		this[this.Rows.Count-1,m+1] = arg_dt.Rows[i].ItemArray[arg_display] ;
								//	}
								//}
								
								//칼럼헤드의 위치를 조회하여 데이타 디스플레이
								try
								{
									if(int.Parse(arg_dt.Rows[i].ItemArray[arg_colhead].ToString()) > 0)
									{
										this.Sheets[0].Cells[this.Sheets[0].RowCount-1,arg_display + int.Parse(arg_dt.Rows[i].ItemArray[j].ToString())].Value = arg_dt.Rows[i].ItemArray[arg_display];										
									}
								}
								catch
								{
								}								
									
							}
							else
							{
								switch(Convert.ToString(this.Sheets[0].GetCellType(i,j+1)))	 // Cell Type
								{
									case "CheckBoxCellType":
										if(arg_dt.Rows[i].ItemArray[j].ToString()  == "" || arg_dt.Rows[i].ItemArray[j] == null )
										{
											this.Sheets[0].Cells[this.Sheets[0].RowCount-1,j+1].Value = false;
										}
										else
										{
											this.Sheets[0].Cells[this.Sheets[0].RowCount-1,j+1].Value = Convert.ToBoolean(arg_dt.Rows[i].ItemArray[j]);
										}								
										break;
									case "DateTimeCellType":
										if(arg_dt.Rows[i].ItemArray[j].ToString()  == "" || arg_dt.Rows[i].ItemArray[j] == null )
										{
											this.Sheets[0].Cells[this.Sheets[0].RowCount-1,j+1].Value = "";
										}
										else
										{
											this.Sheets[0].Cells[this.Sheets[0].RowCount-1,j+1].Value = Convert.ToDateTime(arg_dt.Rows[i].ItemArray[j]);
										}																
										break;
									default:
										this.Sheets[0].Cells[this.Sheets[0].RowCount-1,j+1].Value = arg_dt.Rows[i].ItemArray[j];
										break;
								}

								//this[this.Rows.Count-1,j+1] = arg_dt.Rows[i].ItemArray[j] ;
							}
							//return ;					
						}
					}

					str_oldkey = str_newkey;										
				}
			
				this.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
				this.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
					
			}			
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_CrossTab",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
 
		}
 
		
		/// <summary>
		/// Display_Size_ColHead : size조회
		/// </summary>
		/// <param name="arg_style">style code</param>		
		/// <param name="arg_width">column width</param>		
		/// <param name="arg_startcol">start column</param>		
		public  void Display_Size_ColHead(string arg_factory,string arg_style,int arg_width,int arg_startcol)
		{
 									
			try 
			{
				DataSet    ds_size;
				DataTable  dt_size;	

				MyOraDB.ReDim_Parameter(3); 

				//01.PROCEDURE명
				if (arg_style.Equals(""))
					MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SIZE_COLHEAD_ALL";
				else
					MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SIZE_COLHEAD";
 
				//02.ARGURMENT명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE";									
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				//03.DATA TYPE
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;									
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
				//04.DATA 정의  			
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_style; 				
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true);
 
				ds_size = MyOraDB.Exe_Select_Procedure();

				if(ds_size == null) return ;			
				dt_size =  ds_size.Tables[MyOraDB.Process_Name]; 
				
				this.ActiveSheet.Columns.Count = arg_startcol + dt_size.Rows.Count ;

				for(int i = 0; i < dt_size.Rows.Count; i++)
				{
					this.ActiveSheet.ColumnHeader.Cells[0, arg_startcol+i].Text = dt_size.Rows[i].ItemArray[0].ToString();
					this.ActiveSheet.Columns[arg_startcol+i].Width = arg_width;
				}

				this.ActiveSheet.ColumnHeader.Rows[0].Visible = true;
				this.ActiveSheet.ColumnHeader.Rows[1].Visible = false;
			}
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_Size",MessageBoxButtons.OK,MessageBoxIcon.Error);
			} 
		} 		
		



		/// <summary>
		/// Display_Size_ColHead : size조회
		/// </summary>
		/// <param name="arg_style">style code</param>		
		/// <param name="arg_width">column width</param>		
		/// <param name="arg_startcol">start column</param>		
		public  void Display_Size_ColHead_Dpo(string arg_factory,string arg_style,int arg_width,int arg_startcol)
		{
 									
			try 
			{
				DataSet    ds_size;
				DataTable  dt_size;	

				MyOraDB.ReDim_Parameter(3); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SIZE_COLHEAD_DPO";
 
				//02.ARGURMENT명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE";									
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				//03.DATA TYPE
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;									
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
				//04.DATA 정의  			
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_style; 				
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true);
 
				ds_size = MyOraDB.Exe_Select_Procedure();

				if(ds_size == null) return ;			
				dt_size =  ds_size.Tables[MyOraDB.Process_Name]; 
				
				this.ActiveSheet.Columns.Count = arg_startcol + dt_size.Rows.Count ;

				for(int i = 0; i < dt_size.Rows.Count; i++)
				{
					this.ActiveSheet.ColumnHeader.Cells[0, arg_startcol+i].Text = dt_size.Rows[i].ItemArray[0].ToString();
					this.ActiveSheet.Columns[arg_startcol+i].Width = arg_width;
				}

				this.ActiveSheet.ColumnHeader.Rows[0].Visible = true;
				this.ActiveSheet.ColumnHeader.Rows[1].Visible = false;
			}
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_Size",MessageBoxButtons.OK,MessageBoxIcon.Error);
			} 
		} 
		



		/// <summary>
		/// Display_Size_ColHead_Req : size조회
		/// </summary>
		/// <param name="arg_width">column width</param>		
		/// <param name="arg_startcol">start column</param>		
		public  void Display_Size_ColHead_Req(string arg_factory, int arg_width,int arg_startcol)
		{
 								
			try 
			{
				DataSet    ds_size;
				DataTable  dt_size;	

				MyOraDB.ReDim_Parameter(2); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SIZE_COLHEAD_REQ";

				//02.ARGURMENT명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				//03.DATA TYPE
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			
				//04.DATA 정의  			
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true);

				ds_size = MyOraDB.Exe_Select_Procedure();

				if(ds_size == null) return ;			
				dt_size =  ds_size.Tables[MyOraDB.Process_Name]; 
			
				this.ActiveSheet.Columns.Count = arg_startcol + dt_size.Rows.Count ;

				for(int i = 0; i < dt_size.Rows.Count; i++)
				{
					this.ActiveSheet.ColumnHeader.Cells[0, arg_startcol+i].Text = dt_size.Rows[i].ItemArray[0].ToString();
					this.ActiveSheet.Columns[arg_startcol+i].Width = arg_width;
				}

				this.ActiveSheet.ColumnHeader.Rows[0].Visible = true;
				this.ActiveSheet.ColumnHeader.Rows[1].Visible = false;
			}
		
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_Size",MessageBoxButtons.OK,MessageBoxIcon.Error);
			} 
		} 	


 

		#region Set_CellPosition : 특정 행, 열로 포커스 이동


		/// <summary>
		/// Set_CellPosition : 특정 행, 열로 포커스 이동
		/// </summary>
		/// <param name="arg_grid"></param>
		/// <param name="arg_row"></param>
		/// <param name="arg_col"></param>
		public void Set_CellPosition(int arg_row, int arg_col)
		{
			try
			{
				this.EditMode = false;
				this.ActiveSheet.SetActiveCell(arg_row, arg_col);
				this.EditMode = true;
			}
			catch(Exception ex)
			{
				COM.ComFunction.User_Message(ex.Message, "Set_CellPosition", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		#endregion

		#region Refresh_Division : 전체 재 조회 하지 않고, division "" 로 세팅


		/// <summary>
		/// Refresh_Division : 전체 재 조회 하지 않고, division "" 로 세팅
		/// insert, update = "" 로 처리
		/// delete = row 삭제로 처리 
		/// </summary>
		public void Refresh_Division()
		{
			try
			{
				for(int i = this.ActiveSheet.Rows.Count - 1; i >= 0; i--)
				{
					if(this.ActiveSheet.Cells[i, 0].Tag == null || this.ActiveSheet.Cells[i, 0].Tag.ToString() == "") continue;

					if(this.ActiveSheet.Cells[i, 0].Tag.ToString() == "D")
					{
						this.ActiveSheet.Rows.Remove(i, 1);
					} 


				} // end for i

				this.Sheets[0].ClearRange(0, 0, this.ActiveSheet.Rows.Count, 1, false); 

 
			}
			catch(Exception ex)
			{
				ComFunction.User_Message(ex.Message, "Refresh_Division", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			} 

		}

		#endregion

		/// <summary>
		/// insert_Row : 행 추가
		/// </summary>
		/// <param name="arg_row">추가하고자 하는 Row</param>
		public int insert_Row(int row, ImageList arg_imglist)
		{
			int ret = 0 ;
			try 
			{	 
				 
				//row의 아래에 행삽입				
				bool chk = false ;
				//마지막 행 입력 체크
				if(this.Sheets[0].RowCount > 0)
				{
					for(int i = 0; i < this.Sheets[0].ColumnCount; i++)
					{
						if(this.Sheets[0].Cells[row, i].Value != null) { chk = true ;}
					}
				}
				else
				{
					chk = true ;
				}

				if(chk)
				{
					this.Sheets[0].AddRows(row+1, 1); 
					this.Sheets[0].Cells[row+1, 0].Tag = "I" ;					

					Image img = arg_imglist.Images[0];								
					Bitmap b = new Bitmap(img);								
					FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
					FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
					imgType.BackgroundImage = pic ;
					this.Sheets[0].Cells[row+1, 0].CellType = imgType ;
				}
								
				ret = row +1;

			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Add_Row",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return ret;						
		}



	}
}
