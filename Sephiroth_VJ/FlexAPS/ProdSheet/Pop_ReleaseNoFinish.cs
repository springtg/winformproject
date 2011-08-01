using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdSheet
{
	public class Pop_ReleaseNoFinish : COM.APSWinForm.Pop_Large
	{

		#region 컨트롤 정의 및 리소스 정리


		private System.Windows.Forms.Label btn_Close;
		private COM.FSP fgrid_Main;
		private System.ComponentModel.IContainer components = null;

		
		#endregion

		#region 생성자, 소멸자


		public Pop_ReleaseNoFinish()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



		private string _Factory;
		private string _ConfirmYmd;


		public Pop_ReleaseNoFinish(string arg_factory, string arg_confirm_ymd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_Factory = arg_factory;
			_ConfirmYmd = arg_confirm_ymd;


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_ReleaseNoFinish));
			this.btn_Close = new System.Windows.Forms.Label();
			this.fgrid_Main = new COM.FSP();
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
			this.lbl_MainTitle.Size = new System.Drawing.Size(208, 23);
			this.lbl_MainTitle.Text = "No Finish List";
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
			this.fgrid_Main.Location = new System.Drawing.Point(8, 55);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.Size = new System.Drawing.Size(676, 361);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Fixed{BackColor:137, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:217, 250, 216;ForeColor:Black;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 289;
			// 
			// Pop_ReleaseNoFinish
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 455);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.fgrid_Main);
			this.Name = "Pop_ReleaseNoFinish";
			this.Text = "No Finish List";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_Main, 0);
			this.Controls.SetChildIndex(this.btn_Close, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		 
		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction(); 


		#endregion 

		#region 멤버 메서드


		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			
			try
			{ 
  
				//Title
				this.Text = "No Finish List";
				lbl_MainTitle.Text = "No Finish List"; 
  
  
				fgrid_Main.Set_Grid("SPO_DAILY_NOFINISH_BSC", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_Main.ExtendLastCol = false; 
				fgrid_Main.Font = new Font("Verdana", 7);



				DataTable dt_ret = Select_No_Finish_List(_Factory, _ConfirmYmd);
				fgrid_Main.Display_Grid(dt_ret, false);
				dt_ret.Dispose();
				 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

  
		}

 

		#endregion
		  
		#region 조회
 

		#endregion

		#region 툴바 이벤트 메서드
 

		#endregion

		#region 그리드 이벤트 메서드
 
		#endregion

		#region 버튼 및 기타 이벤트 메서드 


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
  

		#endregion

		#region 컨텍스트 메뉴 이벤트 메서드

 

		#endregion
 

		#endregion   
		
		#region 이벤트 처리

		#region 툴바 이벤트


		 

		#endregion 

		#region 그리드 이벤트
  

		#endregion

		#region 버튼 및 기타 이벤트 


		private void btn_Close_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				this.Close();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Close_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}
 

		#endregion

		#region 컨텍스트 메뉴 이벤트

  

		#endregion


		#endregion
		 
		#region 디비 연결
 

		/// <summary>
		/// Select_No_Finish_List : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_confirm_ymd"></param>
		/// <returns></returns>
		private DataTable Select_No_Finish_List(string arg_factory, string arg_confirm_ymd) 
		{  

			try
			{

				DataSet ds_ret; 


				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_BSC.SELECT_SPD_LOT_DAILY_NOFINISH";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_DIR_REQ_YMD";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_confirm_ymd;  
				MyOraDB.Parameter_Values[2] = "";

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
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

