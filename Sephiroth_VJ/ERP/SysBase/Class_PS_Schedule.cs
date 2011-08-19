using System;
using System.Data;
using System.Data.OracleClient;
//using System.Diagnostics;
using System.Drawing;


namespace ERP.SysBase
{
	/// <summary>
	/// Class_PC_Schedule에 대한 요약 설명입니다.
	/// </summary>
	public class Class_PS_Schedule
	{
		public Class_PS_Schedule()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		/// <summary>
		/// Set_Calendar_Head : 달력 헤더부 설정
		/// </summary>
		/// <param name="arg_fgrid"></param>
		public void Set_Calendar_Head(C1.Win.C1FlexGrid.C1FlexGrid arg_fgrid)
		{
			int width;
			int i ; 



			arg_fgrid.Cols.Fixed = 0; 
			arg_fgrid.Rows[0].Height = 20;

			arg_fgrid.Cols[0].AllowSorting = false;
			arg_fgrid.Cols[1].AllowSorting = false;
			arg_fgrid.Cols[2].AllowSorting = false;
			arg_fgrid.Cols[3].AllowSorting = false;
			arg_fgrid.Cols[4].AllowSorting = false;
			arg_fgrid.Cols[5].AllowSorting = false;
			arg_fgrid.Cols[6].AllowSorting = false;

			arg_fgrid.Cols.Count = 7;
			arg_fgrid.Rows.Count = 13;
			arg_fgrid.Rows[0].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;

			arg_fgrid.Rows.Frozen = 0;
			
			
			string[] week_day = new string[] {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
			//Font cellfont = new System.Drawing.Font("Verdana", 7, FontStyle.Regular);

			//날짜 표시 Cell 속성
			C1.Win.C1FlexGrid.CellStyle datecell;
			datecell = arg_fgrid.Styles.Add("DateCell");
			datecell.Font = new System.Drawing.Font("Verdana", 6, FontStyle.Bold);
			datecell.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightTop;


			//일정 표시 Cell 속성
			C1.Win.C1FlexGrid.CellStyle schedulecell;
			schedulecell = arg_fgrid.Styles.Add("ScheduleCell");
			schedulecell.Font = new System.Drawing.Font("굴림",9,FontStyle.Regular);
			schedulecell.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftTop;
			schedulecell.WordWrap = true;


			C1.Win.C1FlexGrid.Row cellrow;

			

			int CellHeight = (arg_fgrid.Height - arg_fgrid.Rows[0].Height)/5;

			width = (arg_fgrid.Width) / 7;

			for(i = 0; i < arg_fgrid.Cols.Count; i++)
			{
				arg_fgrid.Cols[i].Width = width;
			} 


			for(i = 1; i < arg_fgrid.Rows.Count; i = i + 2)
			{
				cellrow = arg_fgrid.Rows[i];
				cellrow.Style = arg_fgrid.Styles["DateCell"];


				arg_fgrid.Rows[i].Height = 14;
				arg_fgrid.Rows[i].AllowEditing = false;
			}

			for(i = 2; i < arg_fgrid.Rows.Count; i = i + 2)
			{
				cellrow = arg_fgrid.Rows[i];
				cellrow.Style = arg_fgrid.Styles["ScheduleCell"];

				arg_fgrid.Rows[i].Height = CellHeight - 14;
				arg_fgrid.Rows[i].AllowEditing = false;
			}
 
			//달력 일명
			for(i = 0; i < week_day.Length; i++)
			{
				arg_fgrid[0, i] = week_day[i];
			}
		}

		/// <summary>
		/// Set_Calendar_Number : 달력 날짜 설정
		/// </summary>
		/// <param name="arg_fgrid"></param>
		public void Set_Calendar_Number(C1.Win.C1FlexGrid.C1FlexGrid arg_fgrid, string arg_caldate)
		{
			int row, shift_row, col, day;
			int i, j;
			string arg_date;
			DataTable dt_list;

			//"PKG_NP_WORKCAL.SELECT_CAL_LIST" index
			int thedate_ix = 0;
			int week_ix = 1;
			int holiyn_ix = 2;

			row = 1;
			shift_row = 2;

			dt_list = Select_Cal_List(arg_caldate);

			/////////////////////////////////////////////////////////////
			//달력 초기화
			for(i = 1; i < arg_fgrid.Rows.Count; i++)
			{
				for(j = 0; j < arg_fgrid.Cols.Count; j++)
				{
					arg_fgrid.GetCellRange(i, j).StyleNew.Clear(C1.Win.C1FlexGrid.StyleElementFlags.All);
					arg_fgrid[i, j] = "";
				}
			} 

			//일요일, 토요일 글자색 
			for(i = 1; i < arg_fgrid.Rows.Count; i=i+2)
			{
				arg_fgrid.GetCellRange(i, 0).StyleNew.ForeColor = Color.Red;
				arg_fgrid.GetCellRange(i, 6).StyleNew.ForeColor = Color.Blue;
			}


			/////////////////////////////////////////////////////////////
			for(i = 0; i < dt_list.Rows.Count; i++)
			{


				//달력 그리드에 요일에 맞는 날짜 적용
				col = Convert.ToInt32(dt_list.Rows[i].ItemArray[week_ix].ToString()) - 1;
				arg_date = dt_list.Rows[i].ItemArray[thedate_ix].ToString();
				day = int.Parse(arg_date.Substring(6, 2));
						
				arg_fgrid[row, col] = day.ToString();
				arg_fgrid[row+1,col] = Date_Schedule(arg_date);
					

				//공휴일 색깔 지정
				if(dt_list.Rows[i].ItemArray[holiyn_ix].ToString() == "Y" && col != 0)
				{
					arg_fgrid.GetCellRange(row, col).StyleNew.ForeColor = Color.Yellow;
				}


				if(dt_list.Rows[i].ItemArray[thedate_ix].ToString() == NowDate())
				{
					arg_fgrid.GetCellRange(row+1, col).StyleNew.BackColor = Color.Wheat;
				}

				//토요일일때 다음 줄 일요일로 이동
				if(col == 6)
				{
					row = row + 2;
					shift_row = shift_row + 2;
				}
			} 

		}

		public string NowDate()
		{
			string yyyy = DateTime.Now.Year.ToString();
			string MM = Add_Zero(DateTime.Now.Month.ToString());
			string dd = Add_Zero(DateTime.Now.Day.ToString());

			return yyyy+MM+dd;
		}

		public string NowDate(double arg_days)
		{
			string yyyy = DateTime.Now.Year.ToString();
			string MM = Add_Zero(DateTime.Now.Month.ToString());
			string dd = Add_Zero(DateTime.Now.AddDays(arg_days).Day.ToString());

			return yyyy+MM+dd;
		}

		public string Add_Zero(string arg_day)
		{
			if(arg_day.Length == 1)
				return "0" + arg_day;
			else
				return arg_day;
		}

		public string Date_Schedule(string arg_date)
		{
			COM.OraDB oraDB = new COM.OraDB();
			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_SCHD_DATE";

		
			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "ARG_USER_DATE";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[2] = arg_date;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret.Tables[Proc_Name].Rows.Count == 0) return "" ;
			return  DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString();
		}


		public void Delete_SPS_Schd_Date(string arg_date)
		{
			COM.OraDB oraDB = new COM.OraDB();

			string Proc_Name = "PKG_SPS_HOME.DELETE_SPS_SCHD_DATE";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "ARG_USER_DATE";
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[2] = arg_date;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}


		public DataTable Select_SPS_Month(string arg_factory)
		{
			COM.OraDB oraDB = new COM.OraDB();

			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_MONTH";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "OUT_CURSOR";
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		

		/// <summary>
		/// Select_Cal_List : 달력 날짜 리스트 찾기
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Cal_List(string arg_caldate)
		{

            COM.OraDB oraDB = new COM.OraDB();

            string Proc_Name = "PKG_SPB_WORKCAL.SELECT_CAL_LIST";

            oraDB.ReDim_Parameter(5);
            oraDB.Process_Name = Proc_Name;

            oraDB.Parameter_Name[0] = "ARG_FACTORY";
            oraDB.Parameter_Name[1] = "ARG_CAL_TYPE";
            oraDB.Parameter_Name[2] = "ARG_SHIFT_TYPE";
            oraDB.Parameter_Name[3] = "ARG_THEDATE";
            oraDB.Parameter_Name[4] = "OUT_CURSOR";

            oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
            oraDB.Parameter_Values[1] = ClassLib.ComVar.ComCalType;    //"COMMON"; //
            oraDB.Parameter_Values[2] = ClassLib.ComVar.ComShiftType;  //"1SHIFT"; //
            oraDB.Parameter_Values[3] = arg_caldate; //
            oraDB.Parameter_Values[4] = "";

            oraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = oraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];

		}
	}
}
