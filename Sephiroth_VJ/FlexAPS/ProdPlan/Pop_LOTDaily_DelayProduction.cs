using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdPlan
{
	public class Pop_LOTDaily_DelayProduction : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_Display;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Panel pnl_Body;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.Label btn_Commit;
		public System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Refresh;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.Label lbl_LOT;
		private System.Windows.Forms.TextBox txt_LOT;
		private System.Windows.Forms.TextBox txt_Model;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_Model;
		private System.Windows.Forms.TextBox txt_LineName;
		private System.Windows.Forms.Label lbl_LineCd1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown_YMD;
		public System.Windows.Forms.DateTimePicker dpick_YMD;
		private System.Windows.Forms.Label lbl_DelayDay;
		private System.Windows.Forms.Label lbl_StartDay;
		private System.Windows.Forms.TextBox txt_DaySeq;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label btn_Apply;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자

		public Pop_LOTDaily_DelayProduction()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


 
		private string _Factory;
		private string _LineCd;
		private string _LineName;
		private string _Model;
		private string _StyleCd;
		private string _Gen;
		private string _LOT;

		public Pop_LOTDaily_DelayProduction(string arg_factory, 
			string arg_line_cd, 
			string arg_line_name, 
			string arg_model, 
			string arg_style_cd, 
			string arg_gen, 
			string arg_lot)
		{

			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();


			_Factory = arg_factory;
			_LineCd = arg_line_cd;
			_LineName = arg_line_name;
			_Model = arg_model;
			_StyleCd = arg_style_cd;
			_Gen = arg_gen;
			_LOT = arg_lot;

			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_LOTDaily_DelayProduction));
			this.pnl_Display = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_DaySeq = new System.Windows.Forms.TextBox();
			this.numericUpDown_YMD = new System.Windows.Forms.NumericUpDown();
			this.lbl_DelayDay = new System.Windows.Forms.Label();
			this.dpick_YMD = new System.Windows.Forms.DateTimePicker();
			this.lbl_StartDay = new System.Windows.Forms.Label();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.lbl_LOT = new System.Windows.Forms.Label();
			this.txt_LOT = new System.Windows.Forms.TextBox();
			this.txt_Model = new System.Windows.Forms.TextBox();
			this.txt_LineName = new System.Windows.Forms.TextBox();
			this.lbl_LineCd1 = new System.Windows.Forms.Label();
			this.txt_Gen = new System.Windows.Forms.TextBox();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.lbl_Model = new System.Windows.Forms.Label();
			this.btn_Refresh = new System.Windows.Forms.Label();
			this.btn_Commit = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Display.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_YMD)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Menu
			// 
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageSize = new System.Drawing.Size(60, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Location = new System.Drawing.Point(676, 3);
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 183);
			this.stbar.Name = "stbar";
			this.stbar.Size = new System.Drawing.Size(1002, 0);
			this.stbar.Visible = false;
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Text = "MPS - Modify Size Quantity";
			// 
			// pnl_Display
			// 
			this.pnl_Display.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Display.Controls.Add(this.pnl_SearchImage);
			this.pnl_Display.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Display.DockPadding.Bottom = 5;
			this.pnl_Display.DockPadding.Left = 8;
			this.pnl_Display.DockPadding.Right = 8;
			this.pnl_Display.DockPadding.Top = 5;
			this.pnl_Display.Location = new System.Drawing.Point(0, 0);
			this.pnl_Display.Name = "pnl_Display";
			this.pnl_Display.Size = new System.Drawing.Size(1002, 90);
			this.pnl_Display.TabIndex = 193;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.groupBox1);
			this.pnl_SearchImage.Controls.Add(this.lbl_LOT);
			this.pnl_SearchImage.Controls.Add(this.txt_LOT);
			this.pnl_SearchImage.Controls.Add(this.txt_Model);
			this.pnl_SearchImage.Controls.Add(this.txt_LineName);
			this.pnl_SearchImage.Controls.Add(this.lbl_LineCd1);
			this.pnl_SearchImage.Controls.Add(this.txt_Gen);
			this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_Model);
			this.pnl_SearchImage.Controls.Add(this.btn_Refresh);
			this.pnl_SearchImage.Controls.Add(this.btn_Commit);
			this.pnl_SearchImage.Controls.Add(this.btn_Cancel);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 5);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(986, 80);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_DaySeq);
			this.groupBox1.Controls.Add(this.numericUpDown_YMD);
			this.groupBox1.Controls.Add(this.lbl_DelayDay);
			this.groupBox1.Controls.Add(this.dpick_YMD);
			this.groupBox1.Controls.Add(this.lbl_StartDay);
			this.groupBox1.Controls.Add(this.btn_Apply);
			this.groupBox1.Location = new System.Drawing.Point(368, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 68);
			this.groupBox1.TabIndex = 297;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Modify";
			// 
			// txt_DaySeq
			// 
			this.txt_DaySeq.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_DaySeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_DaySeq.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_DaySeq.Location = new System.Drawing.Point(209, 18);
			this.txt_DaySeq.MaxLength = 60;
			this.txt_DaySeq.Name = "txt_DaySeq";
			this.txt_DaySeq.ReadOnly = true;
			this.txt_DaySeq.Size = new System.Drawing.Size(21, 21);
			this.txt_DaySeq.TabIndex = 297;
			this.txt_DaySeq.Text = "";
			// 
			// numericUpDown_YMD
			// 
			this.numericUpDown_YMD.Location = new System.Drawing.Point(109, 40);
			this.numericUpDown_YMD.Name = "numericUpDown_YMD";
			this.numericUpDown_YMD.Size = new System.Drawing.Size(100, 22);
			this.numericUpDown_YMD.TabIndex = 296;
			// 
			// lbl_DelayDay
			// 
			this.lbl_DelayDay.ImageIndex = 0;
			this.lbl_DelayDay.ImageList = this.img_Label;
			this.lbl_DelayDay.Location = new System.Drawing.Point(8, 40);
			this.lbl_DelayDay.Name = "lbl_DelayDay";
			this.lbl_DelayDay.Size = new System.Drawing.Size(100, 21);
			this.lbl_DelayDay.TabIndex = 295;
			this.lbl_DelayDay.Text = "Delay Day";
			this.lbl_DelayDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_YMD
			// 
			this.dpick_YMD.CustomFormat = "yyyyMMdd";
			this.dpick_YMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_YMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_YMD.Location = new System.Drawing.Point(109, 18);
			this.dpick_YMD.Name = "dpick_YMD";
			this.dpick_YMD.Size = new System.Drawing.Size(100, 22);
			this.dpick_YMD.TabIndex = 294;
			this.dpick_YMD.CloseUp += new System.EventHandler(this.dpick_YMD_CloseUp);
			// 
			// lbl_StartDay
			// 
			this.lbl_StartDay.ImageIndex = 0;
			this.lbl_StartDay.ImageList = this.img_Label;
			this.lbl_StartDay.Location = new System.Drawing.Point(8, 18);
			this.lbl_StartDay.Name = "lbl_StartDay";
			this.lbl_StartDay.Size = new System.Drawing.Size(100, 21);
			this.lbl_StartDay.TabIndex = 293;
			this.lbl_StartDay.Text = "Start Day/Seq.";
			this.lbl_StartDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Apply
			// 
			this.btn_Apply.ImageIndex = 4;
			this.btn_Apply.ImageList = this.img_MiniButton;
			this.btn_Apply.Location = new System.Drawing.Point(209, 40);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(21, 21);
			this.btn_Apply.TabIndex = 195;
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_LOT
			// 
			this.lbl_LOT.ImageIndex = 0;
			this.lbl_LOT.ImageList = this.img_Label;
			this.lbl_LOT.Location = new System.Drawing.Point(10, 30);
			this.lbl_LOT.Name = "lbl_LOT";
			this.lbl_LOT.Size = new System.Drawing.Size(100, 21);
			this.lbl_LOT.TabIndex = 288;
			this.lbl_LOT.Text = "LOT";
			this.lbl_LOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_LOT
			// 
			this.txt_LOT.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LOT.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LOT.Location = new System.Drawing.Point(111, 30);
			this.txt_LOT.MaxLength = 60;
			this.txt_LOT.Name = "txt_LOT";
			this.txt_LOT.ReadOnly = true;
			this.txt_LOT.TabIndex = 289;
			this.txt_LOT.Text = "";
			// 
			// txt_Model
			// 
			this.txt_Model.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Model.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Model.Location = new System.Drawing.Point(111, 8);
			this.txt_Model.MaxLength = 60;
			this.txt_Model.Name = "txt_Model";
			this.txt_Model.ReadOnly = true;
			this.txt_Model.TabIndex = 292;
			this.txt_Model.Text = "";
			// 
			// txt_LineName
			// 
			this.txt_LineName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineName.Location = new System.Drawing.Point(111, 52);
			this.txt_LineName.MaxLength = 60;
			this.txt_LineName.Name = "txt_LineName";
			this.txt_LineName.ReadOnly = true;
			this.txt_LineName.TabIndex = 291;
			this.txt_LineName.Text = "";
			// 
			// lbl_LineCd1
			// 
			this.lbl_LineCd1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_LineCd1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_LineCd1.ImageIndex = 0;
			this.lbl_LineCd1.ImageList = this.img_Label;
			this.lbl_LineCd1.Location = new System.Drawing.Point(10, 52);
			this.lbl_LineCd1.Name = "lbl_LineCd1";
			this.lbl_LineCd1.Size = new System.Drawing.Size(100, 21);
			this.lbl_LineCd1.TabIndex = 290;
			this.lbl_LineCd1.Text = "Line";
			this.lbl_LineCd1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Gen
			// 
			this.txt_Gen.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Gen.Location = new System.Drawing.Point(293, 8);
			this.txt_Gen.MaxLength = 60;
			this.txt_Gen.Name = "txt_Gen";
			this.txt_Gen.ReadOnly = true;
			this.txt_Gen.Size = new System.Drawing.Size(36, 21);
			this.txt_Gen.TabIndex = 287;
			this.txt_Gen.Text = "";
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(212, 8);
			this.txt_StyleCd.MaxLength = 60;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.ReadOnly = true;
			this.txt_StyleCd.Size = new System.Drawing.Size(80, 21);
			this.txt_StyleCd.TabIndex = 286;
			this.txt_StyleCd.Text = "";
			// 
			// lbl_Model
			// 
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_Label;
			this.lbl_Model.Location = new System.Drawing.Point(10, 8);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(100, 21);
			this.lbl_Model.TabIndex = 285;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Refresh.ImageIndex = 0;
			this.btn_Refresh.ImageList = this.img_Button;
			this.btn_Refresh.Location = new System.Drawing.Point(792, 6);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(60, 23);
			this.btn_Refresh.TabIndex = 284;
			this.btn_Refresh.Text = "Refresh";
			this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			this.btn_Refresh.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Refresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Refresh.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Refresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Commit
			// 
			this.btn_Commit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Commit.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Commit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Commit.ImageIndex = 0;
			this.btn_Commit.ImageList = this.img_Button;
			this.btn_Commit.Location = new System.Drawing.Point(853, 6);
			this.btn_Commit.Name = "btn_Commit";
			this.btn_Commit.Size = new System.Drawing.Size(60, 23);
			this.btn_Commit.TabIndex = 283;
			this.btn_Commit.Text = "Apply";
			this.btn_Commit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
			this.btn_Commit.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Commit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Commit.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Commit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(914, 6);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(60, 23);
			this.btn_Cancel.TabIndex = 282;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(969, 8);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(17, 69);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(970, -5);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(16, 13);
			this.picb_TR.TabIndex = 21;
			this.picb_TR.TabStop = false;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(16, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(970, 32);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, -2);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(16, 8);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(970, 65);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(16, 16);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(144, 64);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(826, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 65);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(168, 20);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 0);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 72);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// picb_MM
			// 
			this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
			this.picb_MM.Location = new System.Drawing.Point(160, 24);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.Size = new System.Drawing.Size(818, 47);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Bottom = 8;
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 90);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1002, 93);
			this.pnl_Body.TabIndex = 194;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Column;
			this.fgrid_Main.Size = new System.Drawing.Size(986, 85);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:White;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 48;
			// 
			// Pop_LOTDaily_DelayProduction
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1002, 183);
			this.Controls.Add(this.pnl_Display);
			this.Controls.Add(this.pnl_Body);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Pop_LOTDaily_DelayProduction";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MPS - Delay Production";
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Load += new System.EventHandler(this.Pop_LOTDaily_DelayProduction_Load);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Display, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Display.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_YMD)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction(); 

		private string _LOTNo, _LOTSeq; 

		private int _TBDate_Row, _YMDRow, _DaySeqRow, _SizeRow; 
		private int _StatusRow, _FinishRow, _SaveFlagRow;
		private int _HoliYN_Row;

		private string _YMDDesc = "Date";
		private string _DaySeqDesc = "Day Seq.";
		private string _SizeDesc = "Size Qty."; 



		// 현재 LOT에 할당되어져 있는 PlanYMD
		private string _MinPlanYMD, _MaxPlanYMD; 
		private string _DefaultYMD; // 작업지시 이후 처음 시작되는 일자
		private string _DefaultDaySeq;
		private int _DefaultCol = 0;



		public bool _Save_Flag = false;



		//----------------------------------------------
		// 선적 구간 표시
		//---------------------------------------------- 
		public string _ShipDateF_20;  // 선적중
		public string _ShipDateT_20;
		public string _ShipDateF_30;  // 선적준비중
		public string _ShipDateT_30;
		public string _ShipDateF_40;  // 다음 선적 진행중
		public string _ShipDateT_40; 
		public string _ShipDateF_50; 

		public Color _ClrShipDate_20;
		public Color _ClrShipDate_30;
		public Color _ClrShipDate_40;   
		//----------------------------------------------



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
				this.Text = "MPS - Delay Production";
				lbl_MainTitle.Text = "MPS - Delay Production";
	   
//				ClassLib.ComFunction.SetLangDic(this); 
				

				fgrid_Main.Set_Grid("SPO_LOT_DAILY_MODIFY", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_Main.Set_Action_Image(img_Action);
				fgrid_Main.Font = new Font("Verdana", 7);
				fgrid_Main.ExtendLastCol = false;
				fgrid_Main.AllowSorting = AllowSortingEnum.None;
				fgrid_Main.AllowDragging = AllowDraggingEnum.None;
				fgrid_Main.AllowEditing = false;
				fgrid_Main.SelectionMode = SelectionModeEnum.CellRange; 
			

				fgrid_Main.Rows[1].Visible = false;
				fgrid_Main.Cols[0].Visible = false;
				fgrid_Main.Cols.Fixed = 2;

				
				
				Init_Control();



				


				// 계획일자 세팅, 사이즈 수량 표시 작업
				Display_Default_HeadDate();
				Display_Data();





			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}



		private void Init_Control()
		{

	
			tbtn_New.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled = false;  
			tbtn_Print.Enabled = false; 


			string[] token = _LOT.Split('-'); 
			_LOTNo = token[0];
			_LOTSeq = token[1]; 

		
			txt_LineName.Text = _LineName;
			txt_Model.Text = _Model;
			txt_StyleCd.Text = _StyleCd;
			txt_Gen.Text = _Gen;
			txt_LOT.Text = _LOT; 



		}



		#endregion

		#region 조회


		/// <summary>
		/// Display_Default_HeadDate : 
		/// </summary>
		private void Display_Default_HeadDate()
		{


			DataTable dt_ret = Select_LOT_DAILY_YMD_BOUND(_Factory, _LOTNo, _LOTSeq);

			string min_planymd = dt_ret.Rows[0].ItemArray[0].ToString();
			string max_planymd = dt_ret.Rows[0].ItemArray[1].ToString(); 

			
			_MinPlanYMD = min_planymd;
			_MaxPlanYMD = max_planymd;


			// Description, 날짜 세팅 
			_HoliYN_Row = fgrid_Main.Rows.Fixed - 2;
			_TBDate_Row = fgrid_Main.Rows.Fixed - 1;
			_YMDRow = fgrid_Main.Rows.Fixed;
			_DaySeqRow = fgrid_Main.Rows.Fixed + 1; 
			_SizeRow = fgrid_Main.Rows.Fixed + 2; 
			_StatusRow = fgrid_Main.Rows.Fixed + 3; 
			_FinishRow = fgrid_Main.Rows.Fixed + 4;
			_SaveFlagRow = fgrid_Main.Rows.Fixed + 5; 
			
			fgrid_Main.Rows.Count = _SaveFlagRow + 1;
			fgrid_Main.Cols.Count = fgrid_Main.Cols.Fixed;

			fgrid_Main.Rows[_StatusRow].Visible = false;
			fgrid_Main.Rows[_FinishRow].Visible = false; 
			fgrid_Main.Rows[_SaveFlagRow].Visible = false;
			
			fgrid_Main[_DaySeqRow, fgrid_Main.Cols.Fixed - 1] = _DaySeqDesc;
			fgrid_Main[_YMDRow, fgrid_Main.Cols.Fixed - 1] = _YMDDesc;
			fgrid_Main[_SizeRow, fgrid_Main.Cols.Fixed - 1] = _SizeDesc;

			fgrid_Main.AutoSizeCol(fgrid_Main.Cols.Fixed - 1);


			 
		}




		/// <summary>
		/// Display_Data : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Data()
		{ 


			string factory = _Factory;
			string from_plan_ymd = _MinPlanYMD;
			string to_plan_ymd = Convert.ToDateTime( MyComFunction.ConvertDate2Type(_MaxPlanYMD) ).AddMonths(3).ToString("yyyyMMdd");
			string lot_no = _LOTNo;
			string lot_seq = _LOTSeq;



			DataSet ds_ret = Select_LOT_DAILY_DATA(factory, from_plan_ymd, to_plan_ymd, lot_no, lot_seq); 
			DataTable ymd_dt = ds_ret.Tables[0];
			DataTable size_dt = ds_ret.Tables[1]; 

			Display_YMD(ymd_dt);
			Display_Size(size_dt);


		}



		

		#region Display_Data 관련


		/// <summary>
		/// Display_YMD : 날짜 세팅
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_YMD(DataTable arg_dt)
		{

			fgrid_Main.Cols.Count = fgrid_Main.Cols.Fixed + arg_dt.Rows.Count;

			if(arg_dt.Rows.Count == 0) return;


			fgrid_Main.Rows.Fixed = _SizeRow;



			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_Main.Cols[i + fgrid_Main.Cols.Fixed].Width = 50;
				fgrid_Main.Cols[i + fgrid_Main.Cols.Fixed].TextAlign = TextAlignEnum.RightCenter;

				//실제 날짜 표시
				fgrid_Main[_TBDate_Row, i + fgrid_Main.Cols.Fixed] 
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString();
 					
				fgrid_Main[_YMDRow, i + fgrid_Main.Cols.Fixed] 
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString().Substring(4, 2)
					+ ClassLib.ComVar.This_SetedDateSign
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString().Substring(6, 2);
    

				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHHOLI_YN].ToString() == "N")
				{
					//fgrid_Main[_DaySeqRow, i + fgrid_Main.Cols.Fixed] = dayseq.ToString();
					//dayseq++;
					
					fgrid_Main[_HoliYN_Row, i + fgrid_Main.Cols.Fixed] = "N";

				}
				else
				{
					//휴일 색깔 처리 
					fgrid_Main.Cols[i + fgrid_Main.Cols.Fixed].StyleNew.BackColor = ClassLib.ComVar.ClrDisableHead;
					fgrid_Main.Cols[i + fgrid_Main.Cols.Fixed].AllowEditing = false;

					fgrid_Main[_HoliYN_Row, i + fgrid_Main.Cols.Fixed] = "Y";
				} 

				//------------------------------------------------------------------------------------------------------ 
				string date = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBHTHEDATE].ToString();


				if(! _ShipDateF_20.Trim().Equals("") && ! _ShipDateF_30.Trim().Equals("")
					&& Convert.ToInt32(date) >= Convert.ToInt32(_ShipDateF_20)
					&& Convert.ToInt32(date) < Convert.ToInt32(_ShipDateF_30) )
				{
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.BackColor = _ClrShipDate_20;
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.ForeColor = ClassLib.ComVar.Clr_Text_Blue; 

				} 

				if(! _ShipDateF_30.Trim().Equals("") && ! _ShipDateF_40.Trim().Equals("")
					&& Convert.ToInt32(date) >= Convert.ToInt32(_ShipDateF_30)
					&& Convert.ToInt32(date) < Convert.ToInt32(_ShipDateF_40) )
				{
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.BackColor = _ClrShipDate_30;
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.ForeColor = ClassLib.ComVar.Clr_Text_Blue; 

				} 

				if(! _ShipDateF_40.Trim().Equals("") && ! _ShipDateF_50.Trim().Equals("")
					&& Convert.ToInt32(date) >= Convert.ToInt32(_ShipDateF_40)
					&& Convert.ToInt32(date) < Convert.ToInt32(_ShipDateF_50) )
				{
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.BackColor = _ClrShipDate_40;
					fgrid_Main.GetCellRange(_YMDRow, i + fgrid_Main.Cols.Fixed).StyleNew.ForeColor = ClassLib.ComVar.Clr_Text_Blue; 

				} 

				//------------------------------------------------------------------------------------------------------ 


			}

			 
		}


		/// <summary>
		/// Display_Size : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Size(DataTable arg_dt)
		{

			_DefaultYMD = "";
			_DefaultDaySeq = "";
			string default_date = "";
			string default_dayseq = "";

 
			if(arg_dt.Rows.Count == 0) return;

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				for(int j = fgrid_Main.Cols.Fixed; j < fgrid_Main.Cols.Count; j++)
				{
					if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDPLAN_YMD].ToString()
						== fgrid_Main[_TBDate_Row, j].ToString())
					{
						fgrid_Main[_DaySeqRow, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDDAY_SEQ].ToString();
						fgrid_Main[_SizeRow, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDSIZE_QTY].ToString();

						if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDPLAN_STATUS].ToString() == "D")
						{
							fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed, j, fgrid_Main.Rows.Count - 1, j).StyleNew.BackColor = ClassLib.ComVar.ClrRelease;

							_DefaultCol = j;

						}
						else
						{
							if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDTS_FINISH_YN].ToString() == "Y")
							{
								fgrid_Main.GetCellRange(fgrid_Main.Rows.Fixed, j, fgrid_Main.Rows.Count - 1, j).StyleNew.BackColor = ClassLib.ComVar.ClrFinishY;

								_DefaultCol = j;

							}
							else
							{

								if(default_date.Equals("") )
								{
									default_date = fgrid_Main[_TBDate_Row, j].ToString();
									default_dayseq = fgrid_Main[_DaySeqRow, j].ToString();

									dpick_YMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
									dpick_YMD.Text = MyComFunction.ConvertDate2Type(default_date);
									txt_DaySeq.Text = default_dayseq;

									_DefaultYMD = default_date;
									_DefaultDaySeq = default_dayseq;
								}


							}



						}


						
						

						fgrid_Main[_StatusRow, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDPLAN_STATUS].ToString();
						fgrid_Main[_FinishRow, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_MODIFY_LOT_DAILY.IxTBDTS_FINISH_YN].ToString();


						break;
					}
				} // end for j
			} // end for i


			fgrid_Main.LeftCol = _DefaultCol;
			
		}

		
 


		#endregion 



		#endregion 

		#region 그리드 이벤트 관련


		#endregion

		#region 버튼 및 기타 이벤트


		/// <summary>
		/// Event_Click_Refresh : 
		/// </summary>
		private void Event_Click_Refresh()
		{


			fgrid_Main.Set_Grid("SPO_LOT_DAILY_MODIFY", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Main.Set_Action_Image(img_Action);
			fgrid_Main.Font = new Font("Verdana", 7);
			fgrid_Main.ExtendLastCol = false;
			fgrid_Main.AllowSorting = AllowSortingEnum.None;
			fgrid_Main.AllowDragging = AllowDraggingEnum.None;
			fgrid_Main.AllowEditing = false;
			fgrid_Main.SelectionMode = SelectionModeEnum.CellRange; 
			

			fgrid_Main.Rows[1].Visible = false;
			fgrid_Main.Cols[0].Visible = false;
			fgrid_Main.Cols.Fixed = 2;




			// 계획일자 세팅, 사이즈 수량 표시 작업
			Display_Default_HeadDate();
			Display_Data();

		}

		/// <summary>
		/// Event_Click_Commit : 
		/// </summary>
		private void Event_Click_Commit()
		{


			bool save_flag = RUN_DELAY_PRODUCTION();

			if(!save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return;

			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);

				for(int i = fgrid_Main.Cols.Fixed; i < fgrid_Main.Cols.Count; i++) 
				{
					fgrid_Main[_SaveFlagRow, i] = "";
				}

				_Save_Flag = true;
				this.Close();


			}



		}




		/// <summary>
		/// Event_Click_Cancel : 
		/// </summary>
		private void Event_Click_Cancel()
		{

			if(!_Save_Flag) 
			{
				_Save_Flag = false;
			}

			this.Close();

		}




		/// <summary>
		/// Event_dpick_YMD_CloseUp : 
		/// </summary>
		private void Event_dpick_YMD_CloseUp()
		{


			// 시작 날 이전은 적용 대상 안됨
			if(Convert.ToInt32(dpick_YMD.Value.ToString("yyyyMMdd") ) < Convert.ToInt32(_MinPlanYMD) )
			{
				string message = "Production Start Day : " + MyComFunction.ConvertDate2Type(_MinPlanYMD);
				ClassLib.ComFunction.User_Message(message, "Select Start Day", MessageBoxButtons.OK, MessageBoxIcon.Information);

				dpick_YMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
				dpick_YMD.Text = MyComFunction.ConvertDate2Type(_DefaultYMD);
			}


			
			// 마지막 날 이후는 적용 대상 안됨
			if(Convert.ToInt32(dpick_YMD.Value.ToString("yyyyMMdd") ) > Convert.ToInt32(_MaxPlanYMD) )
			{
				string message = "Production Finish Day : " + MyComFunction.ConvertDate2Type(_MaxPlanYMD);
				ClassLib.ComFunction.User_Message(message, "Select Start Day", MessageBoxButtons.OK, MessageBoxIcon.Information);

				dpick_YMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
				dpick_YMD.Text = MyComFunction.ConvertDate2Type(_MaxPlanYMD);
			}


		




			for(int j = fgrid_Main.Cols.Fixed; j < fgrid_Main.Cols.Count; j++)
			{
				if(fgrid_Main[_TBDate_Row, j].ToString() == dpick_YMD.Value.ToString("yyyyMMdd") )
				{
				
	
					
					// 휴일 제외
					if( fgrid_Main[_HoliYN_Row, j].ToString() == "Y")
					{
						string message = "Holyday : " + dpick_YMD.Value.ToString("yyyy-MM-dd");
						ClassLib.ComFunction.User_Message(message, "Select Start Day", MessageBoxButtons.OK, MessageBoxIcon.Information);

						dpick_YMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
						dpick_YMD.Text = MyComFunction.ConvertDate2Type(_DefaultYMD);
						txt_DaySeq.Text = _DefaultDaySeq;

						break;
					}



					// finish 된 일자 제외
					if( fgrid_Main[_FinishRow, j].ToString() == "Y")
					{
						string message = "Already Finished Day : " + dpick_YMD.Value.ToString("yyyy-MM-dd");
						ClassLib.ComFunction.User_Message(message, "Select Start Day", MessageBoxButtons.OK, MessageBoxIcon.Information);

						dpick_YMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
						dpick_YMD.Text = MyComFunction.ConvertDate2Type(_DefaultYMD);
						txt_DaySeq.Text = _DefaultDaySeq;

						break;
					}



					txt_DaySeq.Text = fgrid_Main[_DaySeqRow, j].ToString();
					



				} // end if

			} // end for
			



		}

		


		/// <summary>
		/// Event_btn_Apply_Click : 
		/// </summary>
		private void Event_btn_Apply_Click()
		{

			if(numericUpDown_YMD.Value == 0) return;


			int index_next_day = 0;
			int index_start_day = 0;
		    int delay_day = Convert.ToInt32(numericUpDown_YMD.Value);


			for(int j = fgrid_Main.Cols.Fixed; j < fgrid_Main.Cols.Count; j++)
			{
				if(fgrid_Main[_TBDate_Row, j].ToString() == _MaxPlanYMD)
				{
					index_next_day = j + 1;
					break;
				}

			} // end for j



			for(int j = fgrid_Main.Cols.Fixed; j < fgrid_Main.Cols.Count; j++)
			{
				if(fgrid_Main[_TBDate_Row, j].ToString() == dpick_YMD.Value.ToString("yyyyMMdd") )
				{
					index_start_day = j;
					break;
				}

			} // end for j

			


			//---------------------------------------------------------------------------
			// temp
			//---------------------------------------------------------------------------
			string size_value = "";
			string size_dayseq = "";

			int new_col = index_start_day + delay_day - 1;


			for(int j = index_start_day; j < index_next_day; j++)
			{
				
				if(fgrid_Main[_HoliYN_Row, j].ToString() == "Y") 
				{
					continue;
				}


				size_value = fgrid_Main[_SizeRow, j].ToString();
				size_dayseq = fgrid_Main[_DaySeqRow, j].ToString();




				while(true)
				{


					new_col++;


					if(fgrid_Main[_HoliYN_Row, new_col].ToString() != "Y") 
					{
						break;
					}



				}
 


				fgrid_Main[_SaveFlagRow, new_col] = size_value;

				CellRange cr = fgrid_Main.GetCellRange(_SaveFlagRow, new_col);
				cr.UserData = size_dayseq;
					



			} // end for j
			//---------------------------------------------------------------------------



			//---------------------------------------------------------------------------
			// new setting
			//---------------------------------------------------------------------------
			new_col = index_start_day + delay_day - 1;


			for(int j = index_start_day; j < index_next_day; j++)
			{
				
				if(fgrid_Main[_HoliYN_Row, j].ToString() == "Y") 
				{
					continue;
				}


				fgrid_Main[_SizeRow, j] = "";
                fgrid_Main[_DaySeqRow, j] = "";


			} // end for j
			//---------------------------------------------------------------------------



			//---------------------------------------------------------------------------
			// new setting
			//---------------------------------------------------------------------------
			new_col = index_start_day + delay_day - 1;


			for(int j = index_start_day; j < index_next_day; j++)
			{
				
				if(fgrid_Main[_HoliYN_Row, j].ToString() == "Y") 
				{
					continue;
				}



				while(true)
				{


					new_col++;


					if(fgrid_Main[_HoliYN_Row, new_col].ToString() != "Y") 
					{
						break;
					}



				}
 


				fgrid_Main[_SizeRow, new_col] = fgrid_Main[_SaveFlagRow, new_col].ToString();
				fgrid_Main[_SaveFlagRow, new_col] = "U";

				CellRange cr = fgrid_Main.GetCellRange(_SaveFlagRow, new_col);
				fgrid_Main[_DaySeqRow, new_col] = cr.UserData;

				
				
				_MaxPlanYMD = fgrid_Main[_TBDate_Row, new_col].ToString();



			} // end for j
			//---------------------------------------------------------------------------






		}







		#endregion


		#endregion

		#region 이벤트 처리

		#region 그리드 이벤트


		#endregion

		#region 버튼 및 기타 이벤트


		
		private void Pop_LOTDaily_DelayProduction_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}





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


		private void btn_Refresh_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_Refresh();	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_Refresh", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		
		private void btn_Commit_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Click_Commit();	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_Commit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_Click_Cancel();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			
		}




		private void dpick_YMD_CloseUp(object sender, System.EventArgs e)
		{
			try
			{
				Event_dpick_YMD_CloseUp();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_YMD_CloseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			try
			{
				Event_btn_Apply_Click();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		


		#endregion  

		#endregion
 
		#region 디비 연결
 

		#region 조회 관련


		/// <summary>
		/// Select_LOT_DAILY_YMD_BOUND : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns>
		private DataTable Select_LOT_DAILY_YMD_BOUND(string arg_factory, string arg_lot_no, string arg_lot_seq)
		{  
			DataSet ds_ret;

			try
			{  
				string process_name = "PKG_SPO_MPS_BSC.SELECT_LOT_DAILY_YMD_BOUND";

				MyOraDB.ReDim_Parameter(4);  
				MyOraDB.Process_Name = process_name;
	 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";  
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
					
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_lot_no; 
				MyOraDB.Parameter_Values[2] = arg_lot_seq; 
				MyOraDB.Parameter_Values[3] = ""; 

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


		
		
		/// <summary>
		/// Select_LOT_DAILY_DATA : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_from_plan_ymd"></param>
		/// <param name="arg_to_plan_ymd"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns>
		private DataSet Select_LOT_DAILY_DATA(string arg_factory, string arg_from_plan_ymd, string arg_to_plan_ymd, string arg_lot_no, string arg_lot_seq)
		{  
			
			try
			{ 
				DataSet ds_ret;


				// ymd 추출
				string process_name = "PKG_SPO_MPS_BSC.SELECT_LOT_DAILY_YMD";

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


				


				// data 추출
				process_name = "PKG_SPO_MPS_BSC.SELECT_LOT_DAILY_SIZEQTY";

				MyOraDB.ReDim_Parameter(4);  
				MyOraDB.Process_Name = process_name;
	 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";  
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";  
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
					
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_lot_no; 
				MyOraDB.Parameter_Values[2] = arg_lot_seq;  
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(false);  

				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret; 
			}
			catch
			{
				return null;
			}
		}

 

		#endregion

		#region 저장 관련

		/// <summary>
		/// RUN_DELAY_PRODUCTION : 
		/// </summary>
		/// <returns></returns>
		private bool RUN_DELAY_PRODUCTION()
		{ 
			
			try
			{ 
				int col_ct = 7; 



				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPO_MPS_BSC.RUN_DELAY_PRODUCTION";
 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[4] = "ARG_DAY_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_PLAN_YMD";
				MyOraDB.Parameter_Name[6] = "ARG_UPD_USER"; 
 

				for(int i = 0; i < col_ct ; i++) 
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  
				} 
				  
				

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 


 
				//-------------------------------------------------  
				for(int i = fgrid_Main.Cols.Fixed; i < fgrid_Main.Cols.Count; i++)
				{
					if(fgrid_Main[_SaveFlagRow, i] == null) continue;
					if(fgrid_Main[_SaveFlagRow, i].ToString() == "") continue;  
					if(fgrid_Main[_DaySeqRow, i].ToString() == "") continue;
					 

					vList.Add("U"); 
					vList.Add(_Factory); 
					vList.Add(_LOTNo); 
					vList.Add(_LOTSeq);  
					vList.Add(fgrid_Main[_DaySeqRow, i].ToString());
					vList.Add(fgrid_Main[_TBDate_Row, i].ToString());
					vList.Add(ClassLib.ComVar.This_User); 

					 
				} // end for  
 

				vList.Add("L"); 
				vList.Add(_Factory); 
				vList.Add(_LOTNo); 
				vList.Add(_LOTSeq);  
				vList.Add("");
				vList.Add("");
				vList.Add(ClassLib.ComVar.This_User); 



				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}
				

			}
			catch
			{ 
				return false;
			}

		}



		
		#endregion

		
		

		#endregion

		

		

		

 
		

	}
}

