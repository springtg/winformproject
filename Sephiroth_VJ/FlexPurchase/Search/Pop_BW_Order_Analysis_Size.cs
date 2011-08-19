using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing; 
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;

namespace FlexPurchase.Search
{
	public class Pop_BW_Order_Analysis_Size : COM.PCHWinForm.Form_Top
	{

		#region 디자이너에서 생성한 멤버

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView sheetView1; 

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 멤버
 
		private COM.OraDB MyOraDB = new COM.OraDB(); 

		#endregion

		#region 생성자 / 소멸자

		public Pop_BW_Order_Analysis_Size()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다. 
		}



		private string _Factory;
		private string _StyleCd;
		private string _LOTNo;
		private string _LOTSeq;


		public Pop_BW_Order_Analysis_Size(string arg_factory, string arg_style_cd, string arg_lot_no, string arg_lot_seq)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Factory = arg_factory;
			_StyleCd = arg_style_cd;
			_LOTNo = arg_lot_no;
			_LOTSeq = arg_lot_seq;

			Init_Form();
		}



		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BW_Order_Analysis_Size));
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.spd_main = new COM.SSP();
            this.sheetView1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Menu
            // 
            this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
            this.img_Menu.Images.SetKeyName(0, "");
            this.img_Menu.Images.SetKeyName(1, "");
            this.img_Menu.Images.SetKeyName(2, "");
            this.img_Menu.Images.SetKeyName(3, "");
            this.img_Menu.Images.SetKeyName(4, "");
            this.img_Menu.Images.SetKeyName(5, "");
            this.img_Menu.Images.SetKeyName(6, "");
            this.img_Menu.Images.SetKeyName(7, "");
            this.img_Menu.Images.SetKeyName(8, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink7});
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.tbtn_New);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Search);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Save);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Append);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Insert);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Delete);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Create);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Color);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Print);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Confirm);
            // 
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 401);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(952, 23);
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
            // 
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "0:False:True;97.5975975975976:False:False;0:False:True;\t0.393700787401575:False:T" +
                "rue;98.4251968503937:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 333);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spd_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.spd_main.Location = new System.Drawing.Point(8, 4);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.sheetView1);
            this.spd_main.Size = new System.Drawing.Size(1000, 325);
            this.spd_main.TabIndex = 174;
            // 
            // sheetView1
            // 
            this.sheetView1.SheetName = "Sheet1";
            // 
            // Pop_BW_Order_Analysis_Size
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 423);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BW_Order_Analysis_Size";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 툴바 메뉴 이벤트 처리
		
		 
 
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			try
			{ 
				Clear(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Search();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Print();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Print_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		#endregion

		#region 컨트롤 이벤트 처리 
		 

		#endregion 

		#region 이벤트 처리 메서드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
			this.Text = "Order Analysis - Display Size";
            lbl_MainTitle.Text = "Order Analysis - Display Size";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBW_ORDER_SEARCH_S", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 


			// 사이즈 문대 그리드 표시 ------------------------------------------------------------------------------------
			spd_main.Display_Size_ColHead(_Factory, _StyleCd, 50, (int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxCS_SIZE_START); 
  
			spd_main.ActiveSheet.ColumnHeader.Rows[0].Visible = false;
			spd_main.ActiveSheet.ColumnHeader.Rows[1].Visible = true; 


			FarPoint.Win.Spread.CellType.NumberCellType cell_num = new NumberCellType();
			cell_num.DecimalPlaces = 0 ;
			cell_num.Separator = "," ;
			cell_num.ShowSeparator = true; 

			for(int i = (int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxCS_SIZE_START; i < spd_main.ActiveSheet.ColumnCount; i++)
			{
				spd_main.ActiveSheet.ColumnHeader.Cells[1, i].Value = spd_main.ActiveSheet.ColumnHeader.Cells[0, i].Value.ToString();
 
				spd_main.ActiveSheet.Columns[i].CellType = cell_num;
				spd_main.ActiveSheet.Columns[i].Locked = true;
				spd_main.ActiveSheet.Columns[i].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right; 

			}
			// 사이즈 문대 그리드 표시 ------------------------------------------------------------------------------------

			 
			

			// 콘트롤 세팅
			Init_Control(); 


			// 조회
			Search();

			

		}


		 
 
		/// <summary>
		/// Init_Control : 콘트롤 세팅
		/// </summary>
		private void Init_Control()
		{
			 
			// toolbar button disable setting
			tbtn_New.Enabled = false;
			tbtn_Delete.Enabled = false; 
			tbtn_Confirm.Enabled = false; 
			tbtn_Save.Enabled = false;  
		}
 


		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		/// <summary>
		/// Clear : 화면 초기화
		/// </summary>
		private void Clear()
		{ 

		}



		/// <summary>
		/// Search : 조회
		/// </summary>
		private void Search()
		{ 

			try
			{
				this.Cursor = Cursors.WaitCursor;


				DataTable dt_ret = dt_ret = SELECT_MNT_POP_SIZE_QTY(_Factory, _LOTNo, _LOTSeq); 
			   

				spd_main.ClearAll(); 
 
				Display_Size(dt_ret);

				// column merge 
				ClassLib.ComFunction.MergeCell(spd_main, new int[]{ (int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxJOB_FLAG } );

			}
			catch
			{
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
 
	

		/// <summary>
		/// Display_Size : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Size(DataTable arg_dt)
		{

			string before_key = "";
			string now_key = ""; 
			string dt_cs_size = "";
			string now_cs_size = "";

			// default : max col
			int min_cs_size_col = spd_main.ActiveSheet.ColumnCount + 1;

			int row_sum = 0;



			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				// 행 추가 -----------------------------------------------------------------------------------------
				now_key = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxTBJOB_FLAG].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxTBDESC1].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxTBDESC2].ToString(); 
				
				if(before_key != now_key)
				{
					spd_main.ActiveSheet.Rows.Add(spd_main.ActiveSheet.RowCount, 1);
					before_key = now_key;
					row_sum = 0;
				}
				// 행 추가 ----------------------------------------------------------------------------------------- 

				// description 표시 --------------------------------------------------------------------------------
				string desc1 = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxTBDESC1].ToString();

				if(desc1.Substring(0, 2) == "LT")
				{
					spd_main.ActiveSheet.Rows[spd_main.ActiveSheet.RowCount - 1].BackColor = ClassLib.ComVar.ClrLevel_1st;
				}  

				spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxJOB_FLAG].Value 
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxTBJOB_FLAG].ToString();
				
				spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxDESC1].Value 
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxTBDESC1].ToString();
				
				spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxDESC2].Value 
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxTBDESC2].ToString();
				// description 표시 -------------------------------------------------------------------------------- 


				// 사이즈별 수량 표시-------------------------------------------------------------------------------
				dt_cs_size = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxTBCS_SIZE].ToString().Trim();

				for(int j = (int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxCS_SIZE_START; j < spd_main.ActiveSheet.ColumnCount; j++)
				{

					now_cs_size = spd_main.ActiveSheet.ColumnHeader.Cells[0, j].Value.ToString().Trim();

					if(dt_cs_size == now_cs_size)
					{
						spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, j].Value 
							= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxTBQTY].ToString().Trim();


						min_cs_size_col = (min_cs_size_col < j) ? min_cs_size_col : j;
						row_sum += Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxTBQTY].ToString() );

						break;
					}

				} // end for j
				// 사이즈별 수량 표시-------------------------------------------------------------------------------


				// total 표시
				spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_SIZE.IxTOTAL].Value = row_sum.ToString();
				
																							   
			} // end for i

			min_cs_size_col = (min_cs_size_col == 0) ? min_cs_size_col : min_cs_size_col - 1; 
			spd_main.ShowColumn(0, min_cs_size_col, FarPoint.Win.Spread.HorizontalPosition.Left);



		}


		/// <summary>
		/// Print : 프린트
		/// </summary>
		private void Print()
		{ 

		}



		#endregion  
		
		#endregion

		#region DB Connect

		 
		/// <summary>
		/// SELECT_MNT_POP_SIZE_QTY : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		private DataTable SELECT_MNT_POP_SIZE_QTY(string arg_factory, string arg_lot_no, string arg_lot_seq)
		{

			try 
			{


				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(4);   

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_MONITORING.SELECT_MNT_POP_SIZE_QTY";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_lot_no;
				MyOraDB.Parameter_Values[2] = arg_lot_seq; 
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_MNT_POP_SIZE_QTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}

 
		#endregion	 

	

		

 


	}
}

