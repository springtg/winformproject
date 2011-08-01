using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;


namespace FlexAPS.ProdPlan
{
	public class Pop_MPSDeploySize : COM.APSWinForm.Pop_Large
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Label btn_Close;
		private COM.FSP fgrid_Main;
		private System.Windows.Forms.Label btn_Apply;
		public System.Windows.Forms.DateTimePicker dpick_ToYMD;
		public System.Windows.Forms.DateTimePicker dpick_FromYMD;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label btn_Search;
		private System.ComponentModel.IContainer components = null;

		public Pop_MPSDeploySize()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}





		private string _Factory, _From_Plan_Ymd, _To_Plan_Ymd;

		public Pop_MPSDeploySize(string arg_factory, string arg_from_plan_ymd, string arg_to_plan_ymd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.



			_Factory = arg_factory;
			_From_Plan_Ymd = arg_from_plan_ymd;
			_To_Plan_Ymd = arg_to_plan_ymd;

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_MPSDeploySize));
			this.btn_Close = new System.Windows.Forms.Label();
			this.fgrid_Main = new COM.FSP();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.dpick_ToYMD = new System.Windows.Forms.DateTimePicker();
			this.dpick_FromYMD = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_Search = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Text = "Deploy Size";
			// 
			// btn_Close
			// 
			this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Close.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Close.ImageIndex = 0;
			this.btn_Close.ImageList = this.img_Button;
			this.btn_Close.Location = new System.Drawing.Point(614, 424);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(70, 23);
			this.btn_Close.TabIndex = 290;
			this.btn_Close.Text = "Close";
			this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			this.btn_Close.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Close.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 72);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.Size = new System.Drawing.Size(676, 344);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Fixed{BackColor:137, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:217, 250, 216;ForeColor:Black;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 289;
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(543, 424);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(70, 23);
			this.btn_Apply.TabIndex = 291;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// dpick_ToYMD
			// 
			this.dpick_ToYMD.CustomFormat = "yyyy-MM-dd";
			this.dpick_ToYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_ToYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ToYMD.Location = new System.Drawing.Point(224, 45);
			this.dpick_ToYMD.Name = "dpick_ToYMD";
			this.dpick_ToYMD.Size = new System.Drawing.Size(100, 22);
			this.dpick_ToYMD.TabIndex = 295;
			this.dpick_ToYMD.ValueChanged += new System.EventHandler(this.dpick_ValueChanged);
			// 
			// dpick_FromYMD
			// 
			this.dpick_FromYMD.CustomFormat = "yyyy-MM-dd";
			this.dpick_FromYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_FromYMD.Location = new System.Drawing.Point(109, 45);
			this.dpick_FromYMD.Name = "dpick_FromYMD";
			this.dpick_FromYMD.Size = new System.Drawing.Size(100, 22);
			this.dpick_FromYMD.TabIndex = 294;
			this.dpick_FromYMD.ValueChanged += new System.EventHandler(this.dpick_ValueChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(209, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 16);
			this.label1.TabIndex = 293;
			this.label1.Text = "~";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.ImageIndex = 0;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(8, 46);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 292;
			this.lbl_PlanYMD.Text = "Assy. Date";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_Search
			// 
			this.btn_Search.ImageIndex = 0;
			this.btn_Search.ImageList = this.img_MiniButton;
			this.btn_Search.Location = new System.Drawing.Point(325, 45);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(21, 21);
			this.btn_Search.TabIndex = 296;
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			this.btn_Search.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Search.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// Pop_MPSDeploySize
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 455);
			this.Controls.Add(this.dpick_ToYMD);
			this.Controls.Add(this.dpick_FromYMD);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_PlanYMD);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.btn_Search);
			this.Controls.Add(this.fgrid_Main);
			this.Name = "Pop_MPSDeploySize";
			this.Text = "Deploy Size";
			this.Controls.SetChildIndex(this.fgrid_Main, 0);
			this.Controls.SetChildIndex(this.btn_Search, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_Close, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.Controls.SetChildIndex(this.lbl_PlanYMD, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.dpick_FromYMD, 0);
			this.Controls.SetChildIndex(this.dpick_ToYMD, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();  
		private COM.ComFunction MyComFunction = new COM.ComFunction(); 

		#endregion 

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			try
			{
 
				//Title 
				this.Text = "Deploy Size";
				lbl_MainTitle.Text = "Deploy Size"; 

 
				fgrid_Main.Set_Grid("SPO_LOT_DAILY_SIZE_A", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, true);
   
 

				dpick_FromYMD.Text = _From_Plan_Ymd;
				dpick_ToYMD.Text = _To_Plan_Ymd; 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}



		/// <summary>
		/// SELECT_MPS_DEPLOY_SIZE : 일자별 사이즈 일괄 전개 리스트 조회 
		/// </summary>
		private void SELECT_MPS_DEPLOY_SIZE()
		{

			string from_plan_ymd = MyComFunction.ConvertDate2DbType(dpick_FromYMD.Text);
			string to_plan_ymd = MyComFunction.ConvertDate2DbType(dpick_ToYMD.Text);

			if(from_plan_ymd.Trim().Equals("")) from_plan_ymd = _From_Plan_Ymd;
			if(to_plan_ymd.Trim().Equals("")) to_plan_ymd = _To_Plan_Ymd;

			DataTable dt_ret = SELECT_MPS_DEPLOY_SIZE(_Factory, from_plan_ymd, to_plan_ymd);
			Display_Grid(dt_ret, fgrid_Main);
			dt_ret.Dispose();
		

		}

	
		/// <summary>
		/// Display_Grid : 
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			 
			if(arg_dt == null) return;



			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;

			//All Select Row
			arg_fgrid.Rows.Add(); 
			arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrDarkSel;
			arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_AUTO.IxOK_FLAG] = "Y"; 


			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[i + arg_fgrid.Rows.Fixed + 1, 0] = ""; 

				// sum(lot_size_qty) != sum(lot_daily_size_qty) 인 경우 Warning 표시
				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_DAILY_SIZE_AUTO.IxOK_FLAG - 1].ToString() == "N")
				{
					arg_fgrid.Rows[i + arg_fgrid.Rows.Fixed + 1].StyleNew.BackColor = ClassLib.ComVar.ClrWarning_Back;
					arg_fgrid.Rows[i + arg_fgrid.Rows.Fixed + 1].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; 
				}

			}  
				
 
			arg_fgrid.AutoSizeCols((int)ClassLib.TBSPO_LOT_DAILY_SIZE_AUTO.IxCHECK_FLAG + 1, arg_fgrid.Cols.Count - 1, 2);

 
		}


		
		/// <summary>
		/// Deploy_Size : 
		/// </summary>
		private void Deploy_Size()
		{ 
			bool run_flag = false;

			try
			{
				for(int i = fgrid_Main.Rows.Fixed + 1; i < fgrid_Main.Rows.Count; i++)
				{
					if(fgrid_Main[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_AUTO.IxCHECK_FLAG] == null) continue;

					if(!Convert.ToBoolean(fgrid_Main[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_AUTO.IxCHECK_FLAG].ToString()) ) continue;
 
					this.Cursor = Cursors.WaitCursor;

					//PKG_SPD_DAILY.RESET_SPO_LOT_DAILY_SIZE(FACTORY, LOT_NO, LOT_SEQ, 'AUTO');

					string factory = _Factory;
					
					string[] token = fgrid_Main[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_AUTO.IxLOT].ToString().Split('-');
					string lot_no = token[0];
					string lot_seq = token[1];

					run_flag = Run_RESET_SPO_LOT_DAILY_SIZE(factory, lot_no, lot_seq);

					this.Cursor = Cursors.Default;

					if(run_flag)
					{
						fgrid_Main[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_AUTO.IxING_STATUS] = "Completed";
					} 

					fgrid_Main.TopRow = i;
					System.Windows.Forms.Application.DoEvents();

				}

			}
			catch //(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.ToString(), "Deploy Size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}



		#endregion 

		#region 이벤트 처리
		

		#region 그리드 이벤트

		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				if(e.Col != (int)ClassLib.TBSPO_LOT_DAILY_SIZE_AUTO.IxCHECK_FLAG) return;
 
				if(fgrid_Main[e.Row, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_AUTO.IxOK_FLAG].ToString() == "N") 
				{

					fgrid_Main.SetCellCheck(e.Row, e.Col, C1.Win.C1FlexGrid.CheckEnum.Unchecked);
					return;
				}

				if(e.Row != fgrid_Main.Rows.Fixed) return;
 
				

				for(int i = e.Row + 1; i < fgrid_Main.Rows.Count; i++) 
				{ 

					// sum(lot_size_qty) != sum(lot_daily_size_qty) 인 경우 선택하지 않음
					if(fgrid_Main[i, (int)ClassLib.TBSPO_LOT_DAILY_SIZE_AUTO.IxOK_FLAG].ToString() == "N") continue;

					fgrid_Main[i, e.Col] = fgrid_Main[e.Row, e.Col].ToString();
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}


		#endregion

		#region 버튼 및 기타 이벤트

		#region 버튼 이미지 이벤트

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			

		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{

			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  

		}

		#endregion 


		
		private void dpick_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "dpick_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}


		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			try
			{
				SELECT_MPS_DEPLOY_SIZE();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "SELECT_MPS_DEPLOY_SIZE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				if(fgrid_Main.Rows.Count <= fgrid_Main.Rows.Fixed) return;

				Deploy_Size();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "Deploy_Size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Close();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "Deploy Size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		 
		#endregion 


		#endregion

		#region DB Connect


		/// <summary>
		/// SELECT_MPS_DEPLOY_SIZE : 일자별 사이즈 일괄 전개 리스트 조회 
		/// </summary>
		/// <param name="arg_linecd"></param>
		/// <returns></returns>
		private DataTable SELECT_MPS_DEPLOY_SIZE(string arg_factory, string arg_from_plan_ymd, string arg_to_plan_ymd)
		{ 

			try
			{
				DataSet ds_ret;

				string process_name = "PKG_SPD_DAILY_BSC.SELECT_MPS_DEPLOY_SIZE";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_FROM_PLAN_YMD"; 
				MyOraDB.Parameter_Name[2] = "ARG_TO_PLAN_YMD";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_from_plan_ymd;
				MyOraDB.Parameter_Values[2] = arg_to_plan_ymd;
				MyOraDB.Parameter_Values[3] = "";   

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
		/// Run_RESET_SPO_LOT_DAILY_SIZE : LOT 의 공정 사이즈 생성
		/// </summary>
		/// <param name="arg_dayseq"></param>
		/// <returns></returns>
		private bool Run_RESET_SPO_LOT_DAILY_SIZE(string arg_factory, string arg_lot_no, string arg_lot_seq) 
		{  
			DataSet ds_ret;

			try
			{


				MyOraDB.ReDim_Parameter(4);  

				//SP_SPO_Assign_Daily_Size(ARG_FACTORY, ARG_LOT_NO, ARG_LOT_SEQ, ARG_UPD_USER);
				//MyOraDB.Process_Name = "PKG_SPD_DAILY_BSC.RESET_SPO_LOT_DAILY_SIZE";  
					MyOraDB.Process_Name = "PKG_SPD_DAILY_BSC.RESET_SPO_LOT_DAILY_SIZE_ALL";  
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";  
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";  
  
				for (int i = 0; i < 4; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}	 
				
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_lot_no; 
				MyOraDB.Parameter_Values[2] = arg_lot_seq;  
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User; 

				// MyOraDB.Add_Run_Parameter(true);  
				// ds_ret = MyOraDB.Exe_Run_Procedure();	 

				MyOraDB.Add_Modify_Parameter(true);  
				ds_ret = MyOraDB.Exe_Modify_Procedure();		
			 
				if(ds_ret == null)  
					return false; 
				else
					return true;

 

			}
			catch//(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message,"Run_RESET_SPO_LOT_DAILY_SIZE", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			} 
		}


		#endregion 


		

	}
}

