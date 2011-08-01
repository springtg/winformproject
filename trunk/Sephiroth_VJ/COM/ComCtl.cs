using System;
using System.Data;
using System.Windows.Forms;

namespace COM
{
	/// <summary>
	/// ComCtl에 대한 요약 설명입니다.
	/// </summary>
	public class ComCtl
	{
		public ComCtl()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}


		/// <summary>
		/// Set_ComboList : DataTable의 내용을 콤보리스트에 추가
		/// </summary>
		/// <param name="dtcmb_list">콤보 박스에 추가될 리스트</param>
		/// <param name="arg_cmb">적용 대상 콤보 박스명</param>
		/// <param name="arg_cd_ix">코드로 사용될 필드 인덱스</param>
		/// <param name="arg_name_ix">코드명으로 사용될 필드 인덱스</param>
		public static void Set_ComboList(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_ix, int arg_name_ix)
		{ 
			 Set_ComboList(dtcmb_list, arg_cmb,arg_cd_ix,arg_name_ix,false);
		}


		/// <summary>
		/// Set_ComboList : DataTable의 내용을 콤보리스트에 추가
		/// </summary>
		/// <param name="dtcmb_list">콤보 박스에 추가될 리스트</param>
		/// <param name="arg_cmb">적용 대상 콤보 박스명</param>
		/// <param name="arg_cd_ix">코드로 사용될 필드 인덱스</param>
		/// <param name="arg_name_ix">코드명으로 사용될 필드 인덱스</param>
		/// <param name="arg_emptyrow">상단에 공백 넣을지 여부</param>
		public static void Set_ComboList(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_ix, int arg_name_ix, bool arg_emptyrow)
		{ 

			DataTable temp_datatable= new DataTable("Combo List"); 
			DataRow newrow; 
  
 
			try 
			{
				
				temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
				temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
 
				if(arg_emptyrow == true )
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

 
			}
			catch
			{
				//MessageBox.Show(ex.Message.ToString(),"Set_ComboList",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}

 
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
		public static void Set_ComboList(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_ix, int arg_name_ix, bool arg_emptyrow, COM.ComVar.ComboList_Visible arg_visible)
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

 
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Set_ComboList",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}

 
		}


		/// <summary>
		/// Set_ComboList : DataTable의 내용을 콤보리스트에 추가
		/// </summary>
		/// <param name="dtcmb_list">콤보 박스에 추가될 리스트</param>
		/// <param name="arg_cmb">적용 대상 콤보 박스명</param>
		/// <param name="arg_cd_ix">코드로 사용될 필드 인덱스</param>
		/// <param name="arg_name_ix">코드명으로 사용될 필드 인덱스</param>
		/// <param name="arg_emptyrow">상단에 공백 넣을지 여부</param>
		/// <param name="arg_visible_code">코드 컬럼 보일지 여부</param>
		public static void Set_ComboList(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_ix, int arg_name_ix, bool arg_emptyrow, bool arg_visible_code)
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

				if(!arg_visible_code) arg_cmb.Splits[0].DisplayColumns["Code"].Visible = false;

 
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Set_ComboList",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}

 
		}




		/// <summary>
		/// Set_ComboList : DataTable의 내용을 콤보리스트에 추가
		/// </summary>
		/// <param name="dtcmb_list">콤보 박스에 추가될 리스트</param>
		/// <param name="arg_cmb">적용 대상 콤보 박스명</param>
		/// <param name="arg_cd_ix">코드로 사용될 필드 인덱스</param>
		/// <param name="arg_name_ix">코드명으로 사용될 필드 인덱스</param>
		/// <param name="arg_emptyrow">상단에 공백 넣을지 여부</param>
		/// <param name="arg_codewidth">Code Width 값</param>
		/// <param name="arg_namewidth">Name Width 값</param>
		public static void Set_ComboList(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_ix, int arg_name_ix, bool arg_emptyrow,
			int arg_codewidth, int arg_namewidth)
		{ 

			DataTable temp_datatable= new DataTable("Combo List"); 
			DataRow newrow; 
			int dropdownwidth = arg_codewidth + arg_namewidth;
			if(arg_cmb.Width > dropdownwidth)
			{
				dropdownwidth = arg_cmb.Width;
			}
 
			try 
			{
				
				temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
				temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
 
				if(arg_emptyrow == true )
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
			
				arg_cmb.ValueMember		= "Code";
				arg_cmb.DisplayMember	= "Name"; 

				arg_cmb.SelectedIndex		= -1;
				arg_cmb.MaxDropDownItems	= 10;
				arg_cmb.DropDownWidth		= dropdownwidth;
				arg_cmb.Splits[0].DisplayColumns["Code"].Width = arg_codewidth;
				arg_cmb.Splits[0].DisplayColumns["Name"].Width = arg_namewidth-25;//스크롤 방지
				arg_cmb.ExtendRightColumn = true; 
				arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;

 
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Set_ComboList",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}

 
		}




		/// <summary>
		/// Set_ComboList : DataTable의 내용을 콤보리스트에 추가
		/// </summary>
		/// <param name="dtcmb_list">콤보 박스에 추가될 리스트</param>
		/// <param name="arg_cmb">적용 대상 콤보 박스명</param>
		/// <param name="arg_cd_ix">코드로 사용될 필드 인덱스</param>
		/// <param name="arg_name_ix">코드명으로 사용될 필드 인덱스</param>
		/// <param name="arg_emptyrow">상단에 공백 넣을지 여부</param>
		public static void Set_ComboList(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_ix, int arg_name_ix, string arg_name1, string arg_name2, bool arg_emptyrow)
		{ 

			DataTable temp_datatable= new DataTable("Combo List"); 
			DataRow newrow; 
  
 
			try 
			{
				
				temp_datatable.Columns.Add(new DataColumn(arg_name1, Type.GetType("System.String")));
				temp_datatable.Columns.Add(new DataColumn(arg_name2, Type.GetType("System.String")));
 
				if(arg_emptyrow == true )
				{
					newrow = temp_datatable.NewRow();
					newrow[arg_name1] = " ";
					newrow[arg_name2] = "ALL";
					temp_datatable.Rows.Add(newrow);
				}

				for(int i = 0 ; i < dtcmb_list.Rows.Count; i++)
				{

					newrow = temp_datatable.NewRow();
					newrow[arg_name1] = dtcmb_list.Rows[i].ItemArray[arg_cd_ix];
					newrow[arg_name2] = dtcmb_list.Rows[i].ItemArray[arg_name_ix];
					temp_datatable.Rows.Add(newrow);  
 
				}  
 

				arg_cmb.DataSource = null; 
				arg_cmb.DataSource = temp_datatable;
			
				arg_cmb.ValueMember = arg_name1;
				arg_cmb.DisplayMember = arg_name2; 

				arg_cmb.SelectedIndex = -1;
				arg_cmb.MaxDropDownItems = 10;
				arg_cmb.Splits[0].DisplayColumns[arg_name1].Width = 50;
				arg_cmb.Splits[0].DisplayColumns[arg_name2].Width = 150;
				arg_cmb.ExtendRightColumn = true; 
				arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;

 
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Set_ComboList",MessageBoxButtons.OK,MessageBoxIcon.Error );
			} 
		}


		/// <summary>
		/// Set_ComboList_3 : 컬럼 3개짜리 콤보리스트
		/// </summary>
		/// <param name="dtcmb_list"></param>
		/// <param name="arg_cmb"></param>
		/// <param name="arg_1_pos"></param>
		/// <param name="arg_2_pos"></param>
		/// <param name="arg_3_pos"></param>
		public static void Set_ComboList_3(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_1_pos, int arg_2_pos, int arg_3_pos)
		{ 
			DataSet temp_dataset = new System.Data.DataSet();
			DataTable temp_datatable;
			DataRow newrow;
			int i; 

			temp_datatable = temp_dataset.Tables.Add("Combo List");
			temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
			temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
			temp_datatable.Columns.Add(new DataColumn("Desc", Type.GetType("System.String")));

			 
			for(i = 0 ; i < dtcmb_list.Rows.Count; i++)
			{
				newrow = temp_datatable.NewRow();
				newrow[0] = dtcmb_list.Rows[i].ItemArray[arg_1_pos];
				newrow[1] = dtcmb_list.Rows[i].ItemArray[arg_2_pos];
				newrow[2] = dtcmb_list.Rows[i].ItemArray[arg_3_pos];
				temp_datatable.Rows.Add(newrow);
			}
  
			 

//			arg_cmb.ClearItems();  

// 			arg_cmb.DataSource = null; 

			arg_cmb.DataSource = temp_datatable;
			
			arg_cmb.ValueMember = "Code";
			arg_cmb.DisplayMember = "Name";

			arg_cmb.SelectedIndex = -1;  

			arg_cmb.MaxDropDownItems = 10;
			arg_cmb.Splits[0].DisplayColumns[0].Width = 50;
			arg_cmb.Splits[0].DisplayColumns[1].Width = 150;
			arg_cmb.Splits[0].DisplayColumns[2].Width = 150;
			arg_cmb.ExtendRightColumn = true; 
			arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
			 
		}
 

		/// <summary>
		/// Set_ComboList_AddItem : 콤보박스 수정 (AddItem) 위해서 AddItem으로 리스트 한건씩 추가
		/// </summary>
		/// <param name="dtcmb_list">콤보 박스에 추가될 리스트</param>
		/// <param name="arg_cmb">적용 대상 콤보 박스명</param>
		/// <param name="arg_cd_ix">코드로 사용될 필드 인덱스</param>
		/// <param name="arg_name_ix">코드명으로 사용될 필드 인덱스</param>
		/// <param name="arg_emptyrow">상단에 공백 넣을지 여부</param>
		/// <param name="arg_codewidth">Code Width 값</param>
		/// <param name="arg_namewidth">Name Width 값</param>
		public static void Set_ComboList_AddItem(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_ix, int arg_name_ix, bool arg_emptyrow,
			int arg_codewidth, int arg_namewidth)
		{ 

			DataTable temp_datatable= new DataTable("Combo List"); 
			DataRow newrow; 

			int dropdownwidth = arg_codewidth + arg_namewidth;
			if(arg_cmb.Width > dropdownwidth)
			{
				dropdownwidth = arg_cmb.Width;
			}
 
			try 
			{
				
				temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
				temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
 
				if(arg_emptyrow == true )
				{
					newrow = temp_datatable.NewRow();
					newrow["Code"] = " ";
					newrow["Name"] = "ALL";
					temp_datatable.Rows.Add(newrow);
				}

				for(int i = 0 ; i < dtcmb_list.Rows.Count; i++)
				{

					newrow = temp_datatable.NewRow();
					newrow["Code"] = (dtcmb_list.Rows[i].ItemArray[arg_cd_ix] == null)? " ":dtcmb_list.Rows[i].ItemArray[arg_cd_ix];
					newrow["Name"] = (dtcmb_list.Rows[i].ItemArray[arg_name_ix] == null)? " " :dtcmb_list.Rows[i].ItemArray[arg_name_ix];
					temp_datatable.Rows.Add(newrow);  
 
				}  
 

				newrow = temp_datatable.NewRow();
				newrow["Code"] = "";
				newrow["Name"] = "";
				temp_datatable.Rows.Add(newrow); 


				arg_cmb.DataSource = null; 
				arg_cmb.DataSource = temp_datatable;
			
				arg_cmb.ValueMember		= "Code";
				arg_cmb.DisplayMember	= "Name"; 

				arg_cmb.SelectedIndex		= 0;
				arg_cmb.MaxDropDownItems	= 10;
				arg_cmb.DropDownWidth		= dropdownwidth;
				arg_cmb.Splits[0].DisplayColumns["Code"].Width = arg_codewidth;
				arg_cmb.Splits[0].DisplayColumns["Name"].Width = arg_namewidth-25;//스크롤 방지
				arg_cmb.ExtendRightColumn = true; 
				arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;

 
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Set_ComboList_AddItem",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}

 
		}



		/// <summary>
		/// Set_ComboList_AddItem : 콤보박스 수정 (AddItem) 위해서 AddItem으로 리스트 한건씩 추가
		/// </summary>
		/// <param name="arg_dt">콤보 박스에 추가될 리스트</param>
		/// <param name="arg_cmb">적용 대상 콤보 박스명</param>
		/// <param name="arg_cd_pos">코드로 사용될 필드 인덱스</param>
		/// <param name="arg_name_pos">코드명으로 사용될 필드 인덱스</param>
		public static void Set_ComboList_AddItem(DataTable arg_dt, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_pos, int arg_name_pos)
		{
			int i; 
			
			try
			{
				arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem; 
				arg_cmb.ClearItems(); 

				arg_cmb.AddItemTitles("Code;Name"); 
			
				arg_cmb.ValueMember = "Code";
				arg_cmb.DisplayMember = "Name"; 
			
				//////////////////////////////////////////////////////
				for(i = 0; i < arg_dt.Rows.Count; i++) 
				{ 
					arg_cmb.AddItem(arg_dt.Rows[i].ItemArray[arg_cd_pos].ToString() + ";" + arg_dt.Rows[i].ItemArray[arg_name_pos].ToString());
				}  
		

				arg_cmb.SelectedIndex = -1;  

				arg_cmb.MaxDropDownItems = 10;
				arg_cmb.Splits[0].DisplayColumns[0].Width = 50;
				arg_cmb.Splits[0].DisplayColumns[1].Width = 150;

				arg_cmb.ExtendRightColumn = true; 
				arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Set_ComboList_AddItem",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}


		}


		/// <summary>
		/// Set_ComboList_AddItem : 콤보박스 수정 (AddItem) 위해서 AddItem으로 리스트 한건씩 추가
		/// </summary>
		/// <param name="arg_dt">콤보 박스에 추가될 리스트</param>
		/// <param name="arg_cmb">적용 대상 콤보 박스명</param>
		/// <param name="arg_1_pos"></param>
		/// <param name="arg_2_pos"></param>
		/// <param name="arg_3_pos"></param>
		public static void Set_ComboList_AddItem(DataTable arg_dt, C1.Win.C1List.C1Combo arg_cmb, int arg_1_pos, int arg_2_pos, int arg_3_pos)
		{
			int i; 
			
			try
			{
				arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem; 
				arg_cmb.ClearItems(); 

				arg_cmb.AddItemTitles("Code;Name;Desc"); 
			
				arg_cmb.ValueMember = "Code";
				arg_cmb.DisplayMember = "Name";
			
				//////////////////////////////////////////////////////
				for(i = 0; i < arg_dt.Rows.Count; i++) 
				{ 
					arg_cmb.AddItem(arg_dt.Rows[i].ItemArray[arg_1_pos].ToString() + ";" 
						+ arg_dt.Rows[i].ItemArray[arg_2_pos].ToString() + ";"
						+ arg_dt.Rows[i].ItemArray[arg_3_pos].ToString());
				}  
		

				arg_cmb.SelectedIndex = -1;  

				arg_cmb.MaxDropDownItems = 10;
				arg_cmb.Splits[0].DisplayColumns[0].Width = 50;
				arg_cmb.Splits[0].DisplayColumns[1].Width = 150;
				//arg_cmb.Splits[0].DisplayColumns[2].Width = 50;

				arg_cmb.ExtendRightColumn = true;
				arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Set_ComboList_AddItem",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}


		}


		/// <summary>
		/// Set_ComboList : DataTable의 내용을 콤보리스트에 추가
		/// </summary>
		/// <param name="dtcmb_list">콤보 박스에 추가될 리스트</param>
		/// <param name="arg_cmb">적용 대상 콤보 박스명</param>
		/// <param name="arg_cd_ix">코드로 사용될 필드 인덱스</param>
		/// <param name="arg_name_ix">코드명으로 사용될 필드 인덱스</param>
		/// <param name="arg_emptyrow">상단에 공백 넣을지 여부</param>
		/// <param name="arg_visible_code">코드 컬럼 보일지 여부</param>
		public static void Set_ComboList(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_ix, int arg_name_ix, bool arg_emptyrow, bool arg_visible_code, bool arg_distinct)
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

				newrow = temp_datatable.NewRow();
				newrow["Code"] = "";
				newrow["Name"] = "";
				temp_datatable.Rows.Add(newrow); 

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

				if(!arg_visible_code) arg_cmb.Splits[0].DisplayColumns["Code"].Visible = false;

 
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Set_ComboList",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}

 
		}


        #region 생산계획 factory setting


        /// <summary>
        /// Set_Factory_List : Factory List를 콤보리스트에 추가
        /// 'DS' 이면 arg_cmb.enable = true; 처리
        /// </summary>
        /// <param name="dtcmb_list">콤보 박스에 추가될 리스트</param>
        /// <param name="arg_cmb">적용 대상 콤보 박스명</param>
        /// <param name="arg_cd_ix">코드로 사용될 필드 인덱스</param>
        /// <param name="arg_name_ix">코드명으로 사용될 필드 인덱스</param>
        /// <param name="arg_emptyrow">상단에 공백 넣을지 여부</param> 
        /// <param name="arg_visible">보여줄 컬럼 선택</param>
        public static void Set_Factory_List(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int arg_cd_ix, int arg_name_ix, bool arg_emptyrow, COM.ComVar.ComboList_Visible arg_visible)
        {

            DataTable temp_datatable = new DataTable("Combo List");
            DataRow newrow;


            try
            {

                temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                if (arg_emptyrow)
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
                arg_cmb.Splits[0].DisplayColumns["Code"].Width = 50;
                arg_cmb.Splits[0].DisplayColumns["Name"].Width = 150;
                arg_cmb.ExtendRightColumn = true;
                arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;

                switch (arg_visible)
                {
                    case COM.ComVar.ComboList_Visible.Code:
                        arg_cmb.Splits[0].DisplayColumns["Name"].Visible = false;
                        arg_cmb.DisplayMember = "Code";
                        break;

                    case COM.ComVar.ComboList_Visible.Name:
                        arg_cmb.Splits[0].DisplayColumns["Code"].Visible = false;
                        break;
                }

                if (COM.ComVar.This_Factory != COM.ComVar.DSFactory)
                {
                    arg_cmb.ReadOnly = true;
                    arg_cmb.Enabled = false;
                }

            }
            catch
            {
                //MessageBox.Show(ex.Message.ToString(),"Set_Factory_List",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }



        }


        #endregion

		#region Set Combolist (Multi)


		/// <summary>
		/// Set_ComboList_Multi : 여러개 콤보리스트
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
			 

			if(arg_emptyrow)
			{
				newrow = temp_datatable.NewRow();
				for (int j = 0 ; j < arg_pos.Length ; j++)
				{
					newrow[j] = "";
				}
				temp_datatable.Rows.Add(newrow);

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


        public static void Set_ComboList_AddItem(DataTable arg_dt, C1.Win.C1List.C1Combo arg_cmb, bool arg_empty, int arg_cd_pos, int arg_name_pos, int arg_value_width, int arg_name_width)
        {
            int i;

            try
            {
                arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
                arg_cmb.ClearItems();

                arg_cmb.AddItemTitles("Code;Name");

                arg_cmb.ValueMember = "Code";
                arg_cmb.DisplayMember = "Name";

                if (arg_empty)
                {
                    arg_cmb.AddItem(" " + ";" + "ALL");
                }
                //////////////////////////////////////////////////////
                for (i = 0; i < arg_dt.Rows.Count; i++)
                {
                    arg_cmb.AddItem(arg_dt.Rows[i].ItemArray[arg_cd_pos].ToString() + ";" + arg_dt.Rows[i].ItemArray[arg_name_pos].ToString());
                }


                arg_cmb.SelectedIndex = -1;

                arg_cmb.MaxDropDownItems = 10;
                arg_cmb.Splits[0].DisplayColumns[0].Width = arg_value_width;
                arg_cmb.Splits[0].DisplayColumns[1].Width = arg_name_width;

                arg_cmb.ExtendRightColumn = true;
                arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
                arg_cmb.HScrollBar.Height = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Set_ComboList_AddItem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


		/// <summary>
		/// 
		/// </summary>
		/// <param name="dtcmb_list"></param>
		/// <param name="arg_cmb"></param>
		/// <param name="arg_pos"></param>
		/// <param name="arg_emptyrow"></param>
		public static void Set_ComboList_AddItem_Multi(DataTable dtcmb_list, C1.Win.C1List.C1Combo arg_cmb, int[] arg_pos, bool arg_emptyrow)
		{ 
			 

			arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem; 
			arg_cmb.ClearItems(); 

			string combo_desc = "";

			for (int j = 0 ; j < arg_pos.Length; j++)
			{
				if(j == 0)
				{
					combo_desc += "Item" + j.ToString();
				}
				else
				{
					combo_desc += ";" + "Item" + j.ToString();
				}

			}


			arg_cmb.AddItemTitles(combo_desc); 
			 

			string combo_list = ""; 

			if(arg_emptyrow)
			{
				for (int j = 0 ; j < arg_pos.Length; j++)
				{
						
					if(j == 0)
					{
						combo_list += "";
					}
					else
					{
						combo_list += ";" + "";
					}

				}

				
				arg_cmb.AddItem(combo_list); 


			}

			
			//////////////////////////////////////////////////////
			for(int i = 0; i < dtcmb_list.Rows.Count; i++) 
			{ 

				combo_list = ""; 


				for (int j = 0 ; j < arg_pos.Length; j++)
				{

					if(j == 0)
					{
						combo_list += dtcmb_list.Rows[i].ItemArray[arg_pos[j]].ToString();
					}
					else
					{
						combo_list += ";" + dtcmb_list.Rows[i].ItemArray[arg_pos[j]].ToString();
					}

					 
				}



				arg_cmb.AddItem(combo_list); 

			}  


		

			arg_cmb.SelectedIndex = -1;  

			arg_cmb.ValueMember = "Item0";
			arg_cmb.DisplayMember = "Item0";

			arg_cmb.SelectedIndex = -1;  
			arg_cmb.MaxDropDownItems = 10;

			int dropdownwidth = arg_pos.Length * 60;
			if(arg_cmb.Width > dropdownwidth) dropdownwidth = arg_cmb.Width; 
			arg_cmb.DropDownWidth = dropdownwidth + 25;

			arg_cmb.ExtendRightColumn = true; 
			arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored; 



		}




		// combo style change (title, width, visible)
		public static void SetComboStyle(C1.Win.C1List.C1Combo arg_combo, string[] arg_title, int[] arg_width, bool[] arg_visible)
		{
			if (arg_title.Length == arg_width.Length && arg_width.Length == arg_visible.Length)
				for (int i = 0 ; i < arg_title.Length ; i++)
				{
					arg_combo.Columns[i].Caption = arg_title[i];
					arg_combo.Splits[0].DisplayColumns[i].Width = arg_width[i];
					arg_combo.Splits[0].DisplayColumns[i].Visible = arg_visible[i];					 
				}
			else
				return;
		}

		// combo style change (title, width, visible)
		public static void SetComboStyle(C1.Win.C1List.C1Combo arg_combo, string[] arg_title, int[] arg_width, bool[] arg_visible, string arg_display)
		{
			if (arg_title.Length == arg_width.Length && arg_width.Length == arg_visible.Length)
			{
				for (int i = 0 ; i < arg_title.Length ; i++)
				{
					arg_combo.Columns[i].Caption = arg_title[i];
					arg_combo.Splits[0].DisplayColumns[i].Width = arg_width[i];
					arg_combo.Splits[0].DisplayColumns[i].Visible = arg_visible[i];	 
				}

				arg_combo.DisplayMember = arg_display;
			}
			else
				return;
		}



		#endregion
 



	}
}
