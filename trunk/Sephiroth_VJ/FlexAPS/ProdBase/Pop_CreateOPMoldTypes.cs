using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdBase
{
	public class Pop_CreateOPMoldTypes : COM.APSWinForm.Pop_Large
	{

		#region 컨트롤 정의 및 리소스 정리  

		private System.Windows.Forms.Label btn_Commit;
		private System.Windows.Forms.Label btn_Cancel;
		public System.Windows.Forms.Panel pnl_BBRT;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.Label lbl_SubTitle3;
		public COM.FSP fgrid_Upper;
		public COM.FSP fgrid_Bottom;
		public COM.FSP fgrid_Etc;
		private System.Windows.Forms.Label btn_Refresh;
		private System.ComponentModel.IContainer components = null;

		public Pop_CreateOPMoldTypes()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_CreateOPMoldTypes));
			this.btn_Commit = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.fgrid_Upper = new COM.FSP();
			this.pnl_BBRT = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.fgrid_Bottom = new COM.FSP();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle3 = new System.Windows.Forms.Label();
			this.fgrid_Etc = new COM.FSP();
			this.btn_Refresh = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Upper)).BeginInit();
			this.pnl_BBRT.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Bottom)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Etc)).BeginInit();
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
			this.lbl_MainTitle.Text = "Mold Type";
			// 
			// btn_Commit
			// 
			this.btn_Commit.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Commit.ImageIndex = 0;
			this.btn_Commit.ImageList = this.img_Button;
			this.btn_Commit.Location = new System.Drawing.Point(542, 405);
			this.btn_Commit.Name = "btn_Commit";
			this.btn_Commit.Size = new System.Drawing.Size(70, 23);
			this.btn_Commit.TabIndex = 67;
			this.btn_Commit.Text = "Apply";
			this.btn_Commit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
			this.btn_Commit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Commit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(613, 405);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 66;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// fgrid_Upper
			// 
			this.fgrid_Upper.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Upper.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Upper.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Upper.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Upper.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Upper.Location = new System.Drawing.Point(8, 78);
			this.fgrid_Upper.Name = "fgrid_Upper";
			this.fgrid_Upper.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Upper.Size = new System.Drawing.Size(332, 316);
			this.fgrid_Upper.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Upper.TabIndex = 68;
			// 
			// pnl_BBRT
			// 
			this.pnl_BBRT.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_BBRT.Controls.Add(this.pictureBox2);
			this.pnl_BBRT.Controls.Add(this.pictureBox3);
			this.pnl_BBRT.Controls.Add(this.lbl_SubTitle1);
			this.pnl_BBRT.DockPadding.Bottom = 5;
			this.pnl_BBRT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_BBRT.Location = new System.Drawing.Point(8, 46);
			this.pnl_BBRT.Name = "pnl_BBRT";
			this.pnl_BBRT.Size = new System.Drawing.Size(328, 32);
			this.pnl_BBRT.TabIndex = 69;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(312, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 32);
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(224, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(104, 32);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, -1);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 32);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "      Upper";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.lbl_SubTitle2);
			this.panel1.DockPadding.Bottom = 5;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(344, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(336, 32);
			this.panel1.TabIndex = 71;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(320, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 32);
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(224, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(112, 32);
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, -1);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 32);
			this.lbl_SubTitle2.TabIndex = 28;
			this.lbl_SubTitle2.Text = "      Bottom";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fgrid_Bottom
			// 
			this.fgrid_Bottom.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Bottom.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Bottom.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Bottom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Bottom.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Bottom.Location = new System.Drawing.Point(344, 72);
			this.fgrid_Bottom.Name = "fgrid_Bottom";
			this.fgrid_Bottom.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Bottom.Size = new System.Drawing.Size(340, 172);
			this.fgrid_Bottom.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Bottom.TabIndex = 70;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.pictureBox5);
			this.panel2.Controls.Add(this.pictureBox6);
			this.panel2.Controls.Add(this.lbl_SubTitle3);
			this.panel2.DockPadding.Bottom = 5;
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(344, 247);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(336, 32);
			this.panel2.TabIndex = 73;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(320, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(16, 32);
			this.pictureBox5.TabIndex = 21;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(224, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(112, 32);
			this.pictureBox6.TabIndex = 0;
			this.pictureBox6.TabStop = false;
			// 
			// lbl_SubTitle3
			// 
			this.lbl_SubTitle3.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle3.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle3.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle3.Image")));
			this.lbl_SubTitle3.Location = new System.Drawing.Point(0, -1);
			this.lbl_SubTitle3.Name = "lbl_SubTitle3";
			this.lbl_SubTitle3.Size = new System.Drawing.Size(231, 32);
			this.lbl_SubTitle3.TabIndex = 28;
			this.lbl_SubTitle3.Text = "      Etc.";
			this.lbl_SubTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fgrid_Etc
			// 
			this.fgrid_Etc.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Etc.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Etc.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Etc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Etc.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Etc.Location = new System.Drawing.Point(344, 278);
			this.fgrid_Etc.Name = "fgrid_Etc";
			this.fgrid_Etc.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Etc.Size = new System.Drawing.Size(340, 116);
			this.fgrid_Etc.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Etc.TabIndex = 72;
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Refresh.ImageIndex = 0;
			this.btn_Refresh.ImageList = this.img_Button;
			this.btn_Refresh.Location = new System.Drawing.Point(471, 405);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(70, 23);
			this.btn_Refresh.TabIndex = 74;
			this.btn_Refresh.Text = "Refresh";
			this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			this.btn_Refresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Refresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// Pop_CreateOPMoldTypes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(690, 440);
			this.Controls.Add(this.btn_Refresh);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.fgrid_Etc);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.fgrid_Bottom);
			this.Controls.Add(this.pnl_BBRT);
			this.Controls.Add(this.fgrid_Upper);
			this.Controls.Add(this.btn_Commit);
			this.Controls.Add(this.btn_Cancel);
			this.Name = "Pop_CreateOPMoldTypes";
			this.Text = "Mold Type";
			this.Load += new System.EventHandler(this.Pop_CreateOPMoldTypes_Load);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Commit, 0);
			this.Controls.SetChildIndex(this.fgrid_Upper, 0);
			this.Controls.SetChildIndex(this.pnl_BBRT, 0);
			this.Controls.SetChildIndex(this.fgrid_Bottom, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.fgrid_Etc, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.btn_Refresh, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Upper)).EndInit();
			this.pnl_BBRT.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Bottom)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Etc)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
 

		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();
		private string _Factory, _MoldPart;

		//폼 닫힐때 일어난 이벤트 (save : true, cancel : false)
		public bool _CloseSave = false;


		#endregion 

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			DataTable dt_ret; 
 
			string sel_condition = "";
			DataRow[] display_row = null;
 
			//Title
			this.Text = "Mold Type";
			this.lbl_MainTitle.Text = "Mold Type";

			ClassLib.ComFunction.SetLangDic(this);

			


			//dt_ret = MyOraDB.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMoldPart); 

			_Factory = ClassLib.ComVar.Parameter_PopUp[0];
			_MoldPart = ClassLib.ComVar.Parameter_PopUp[1];

			//return 될 파라미터 값 초기화
			ClassLib.ComVar.Parameter_PopUp = new string[] {""};

			fgrid_Upper.Set_Grid("SPB_OPCD_MOLDTYPES", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			fgrid_Bottom.Set_Grid("SPB_OPCD_MOLDTYPES", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			fgrid_Etc.Set_Grid("SPB_OPCD_MOLDTYPES", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 


			dt_ret = Select_SPB_OPCD_MOLDTYPE(); 
						
			sel_condition = "COM_VALUE3 = 'U'";
			display_row = dt_ret.Select(sel_condition);
			Display_Grid(display_row, fgrid_Upper);

			sel_condition = "COM_VALUE3 = 'B'";
			display_row = dt_ret.Select(sel_condition);
			Display_Grid(display_row, fgrid_Bottom);

			sel_condition = "COM_VALUE3 = 'E'";
			display_row = dt_ret.Select(sel_condition);
			Display_Grid(display_row, fgrid_Etc); 
			  

		}


		private void Display_Grid(DataRow[] arg_dr, COM.FSP arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			int findrow = 0;

			try
			{
				for(int i = 0; i < arg_dr.Length; i++)
				{
					arg_fgrid.AddItem(arg_dr[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 
				} 
 
				arg_fgrid.AutoSizeCols();
				
				arg_fgrid.AllowMerging = AllowMergingEnum.Free;
				for(int i = 1; i < arg_fgrid.Cols.Count; i++) arg_fgrid.Cols[i].AllowMerging = false;
				arg_fgrid.Cols[(int)ClassLib.TBSPB_OPCD_MOLDTYPES.IxCMP_CD].AllowMerging = true;

				string[] token = _MoldPart.Split("/".ToCharArray());
			
				for(int j = 0; j < token.Length; j++)
				{
					if(token[j] == "") continue;

					findrow = arg_fgrid.FindRow(token[j], arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_OPCD_MOLDTYPES.IxMOLD_PART_CD, false, true, false);
					if(findrow == -1) continue;
					arg_fgrid[findrow, (int)ClassLib.TBSPB_OPCD_MOLDTYPES.IxCHECK_FLAG] = "TRUE";
				}

			}
			catch
			{
			}
		}



		#endregion 

		#region 이벤트 처리

		private void btn_Commit_Click(object sender, System.EventArgs e)
		{
			string moldtype = "";

			try
			{
				for(int i = fgrid_Upper.Rows.Fixed; i < fgrid_Upper.Rows.Count; i++)
				{
					if(!Convert.ToBoolean(fgrid_Upper[i, (int)ClassLib.TBSPB_OPCD_MOLDTYPES.IxCHECK_FLAG].ToString())) continue;
					if(moldtype == "")
						moldtype = fgrid_Upper[i, (int)ClassLib.TBSPB_OPCD_MOLDTYPES.IxMOLD_PART_CD].ToString();
					else
						moldtype += "/" + fgrid_Upper[i, (int)ClassLib.TBSPB_OPCD_MOLDTYPES.IxMOLD_PART_CD].ToString();

				}

				for(int i = fgrid_Bottom.Rows.Fixed; i < fgrid_Bottom.Rows.Count; i++)
				{
					if(!Convert.ToBoolean(fgrid_Bottom[i, (int)ClassLib.TBSPB_OPCD_MOLDTYPES.IxCHECK_FLAG].ToString())) continue;
					if(moldtype == "")
						moldtype = fgrid_Bottom[i, (int)ClassLib.TBSPB_OPCD_MOLDTYPES.IxMOLD_PART_CD].ToString();
					else
						moldtype += "/" +  fgrid_Bottom[i, (int)ClassLib.TBSPB_OPCD_MOLDTYPES.IxMOLD_PART_CD].ToString();

				}

				for(int i = fgrid_Etc.Rows.Fixed; i < fgrid_Etc.Rows.Count; i++)
				{
					if(!Convert.ToBoolean(fgrid_Etc[i, (int)ClassLib.TBSPB_OPCD_MOLDTYPES.IxCHECK_FLAG].ToString())) continue;
					if(moldtype == "")
						moldtype = fgrid_Etc[i, (int)ClassLib.TBSPB_OPCD_MOLDTYPES.IxMOLD_PART_CD].ToString();
					else
						moldtype +=  "/" + fgrid_Etc[i, (int)ClassLib.TBSPB_OPCD_MOLDTYPES.IxMOLD_PART_CD].ToString();

				}

				ClassLib.ComVar.Parameter_PopUp = new string[] {moldtype}; 
				_CloseSave = true;
				this.Close(); 
			}
			catch
			{
			}
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			ClassLib.ComVar.Parameter_PopUp = new string[] {""};
			_CloseSave = false;
			this.Close();
		}

		private void btn_Refresh_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;
			string sel_condition = "";
			DataRow[] display_row = null;
 
			try
			{
				dt_ret = Select_SPB_OPCD_MOLDTYPE(); 
						
				sel_condition = "COM_VALUE3 = 'U'";
				display_row = dt_ret.Select(sel_condition);
				Display_Grid(display_row, fgrid_Upper);

				sel_condition = "COM_VALUE3 = 'B'";
				display_row = dt_ret.Select(sel_condition);
				Display_Grid(display_row, fgrid_Bottom);

				sel_condition = "COM_VALUE3 = 'E'";
				display_row = dt_ret.Select(sel_condition);
				Display_Grid(display_row, fgrid_Etc); 
			}
			catch
			{
			}
		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 1;
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 0;
		}
 

		#endregion
 
		#region DB Connect
 

		/// <summary>
		/// Select_SPB_OPCD_MOLDTYPE : 
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPB_OPCD_MOLDTYPE()
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_OPCD.SELECT_SPB_OPCD_MOLDTYPE";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_COM_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = ClassLib.ComVar.CxMoldPart;   
				MyOraDB.Parameter_Values[2] = "";  

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 

			}
			catch
			{ 
				return null; 
			}  
		}
 
 
		#endregion


		private void Pop_CreateOPMoldTypes_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

	 

		
 
		
	}
}

