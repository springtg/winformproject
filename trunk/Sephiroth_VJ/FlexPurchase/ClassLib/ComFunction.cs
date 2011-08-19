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

using System.Data.OleDb;
using Microsoft.Office.Core;


namespace FlexPurchase.ClassLib
{
	/// <summary>
	/// Common_Function에 대한 요약 설명입니다.
	/// </summary>
	public class ComFunction : FlexBase.ClassLib.ComFunction
	{
		public ComFunction()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}



		#region 멀티 콤보 리스트 구현

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

		#region 공통 코드 리스트
			
		/// <summary>
		/// Select_Data_List : 
		/// </summary>
		public  static DataTable Select_Data_List(string arg_factory, string arg_code)
		{
			DataSet ds_ret;
			COM.OraDB oraDB = new COM.OraDB();

			string process_name = "PKG_SCM_CODE.SELECT_CODE_LIST";

			oraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			oraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_COM_CD";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			oraDB.Parameter_Values[0] = COM.ComFunction.Empty_String (arg_factory, " ");
			oraDB.Parameter_Values[1] = COM.ComFunction.Empty_String(arg_code, " ");
			oraDB.Parameter_Values[2] = ""; 

			oraDB.Add_Select_Parameter(true);
 
			ds_ret = oraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
  

		}


		#endregion

		#region 생산의뢰일자, DPO 리스트 찾기


		/// <summary>
		/// Select_ReqNo_Date : 생산의뢰일자 리스트 찾기
		/// </summary>
		/// <param name="arg_div">SEM_REQ or SPO_RECV or SPO_RECV_LOT 구분자 (E or P or L)</param>
		/// <returns></returns>
		public static DataTable Select_ReqNo_Date(string arg_factory, string arg_div)
		{ 
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SPO_ORDER.SELECT_REQNO_DATE";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_DIVISION"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_div; 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}
 
			
		}


		/// <summary>
		/// Select_DPO : DPO 리스트 찾기
		/// </summary>
		/// <param name="arg_div">SEM_REQ or SPO_RECV or SPO_RECV_LOT 구분자 (E or P or L)</param>
		/// <returns></returns>
		public static DataTable Select_DPO(string arg_factory, string arg_div)
		{  
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SPO_ORDER.SELECT_DPO";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_DIVISION"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_div; 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}
 
			
		}

		#endregion

		#region 수출 factory list


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


		#endregion

        #region 수출 OBS ID list
        /// <summary>
        /// Set_OBSID_CmbList : OBS TYPE별 OBS ID 생성 및 콤보리스트에 추가
        /// </summary>
        /// <param name="arg_type">선택된 OBS Type</param>
        /// <param name="arg_cmb">적용 대상 콤보 박스명</param>
        public static void Set_OBSID_CmbList(string arg_type, C1.Win.C1List.C1Combo arg_cmb, bool arg_emptyrow)
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




            switch (arg_type)
            {
                case "OR":
                    for (i = -1; i <= 1; i++)
                        //arg_cmb.AddItem( CurDate.AddYears(i).Year.ToString("yyyy-MM-dd").Substring(2,2) + "0605");
                        arg_cmb.AddItem(CurDate.AddYears(i).ToString("yyyy-MM-dd").Substring(2, 2) + "0605");

                    arg_cmb.SelectedIndex = 1;
                    break;

                case "SS":
                case "PS":
                    for (i = -1; i <= 1; i++)
                        //arg_cmb.AddItem( CurDate.AddYears(i).Year.ToString("yyyy-MM-dd").Substring(2,2) + "0112");
                        arg_cmb.AddItem(CurDate.AddYears(i).ToString("yyyy-MM-dd").Substring(2, 2) + "0112");

                    arg_cmb.SelectedIndex = 1;
                    break;

                case "TS":
                case "TP":


                case "QQ":

                    for (i = -3; i <= 3; i++)
                    {
                        sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");
                        sDate2 = CurDate.AddMonths(i + 1).ToString("yyyy-MM-dd");

                        sDate1 = sDate1.Substring(2, 2) + sDate1.Substring(5, 2) + sDate2.Substring(5, 2); ;

                        arg_cmb.AddItem(sDate1);
                    }

                    arg_cmb.SelectedIndex = 3;
                    break;

                default:
                    for (i = -7; i <= 10; i++)
                    {
                        sDate1 = CurDate.AddMonths(i).ToString("yyyy-MM-dd");
                        sDate2 = CurDate.AddMonths(i + 2).ToString("yyyy-MM-dd");

                        sDate1 = sDate1.Substring(2, 2) + sDate1.Substring(5, 2) + sDate2.Substring(5, 2);

                        arg_cmb.AddItem(sDate1);
                    }


                    arg_cmb.SelectedIndex = 5;
                    break;
            }

            arg_cmb.MaxDropDownItems = Convert.ToInt16(arg_cmb.ListCount);
        }

        #endregion 

	}
}