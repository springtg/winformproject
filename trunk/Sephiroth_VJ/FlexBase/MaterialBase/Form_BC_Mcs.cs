using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using FarPoint.Win.Spread;

namespace FlexBase.MaterialBase
{
	public class Form_BC_Mcs : COM.PCHWinForm.Pop_Large
	{

		#region 컨트롤 정의 및 리소스 정리

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel pnl_Menu;
		private System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.TextBox txt_Search_Name;
		private System.Windows.Forms.TextBox txt_Search_Code;
		private System.Windows.Forms.Label lbl_SCode;
		private System.Windows.Forms.Label lbl_SFactory;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Insert;
		private COM.SSP fgrid_Mcs;
		private FarPoint.Win.Spread.SheetView fgrid_Mcs_Sheet1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		

		public Form_BC_Mcs()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BC_Mcs));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.fgrid_Mcs = new COM.SSP();
			this.fgrid_Mcs_Sheet1 = new FarPoint.Win.Spread.SheetView();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_Search_Name = new System.Windows.Forms.TextBox();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.txt_Search_Code = new System.Windows.Forms.TextBox();
			this.lbl_SCode = new System.Windows.Forms.Label();
			this.lbl_SFactory = new System.Windows.Forms.Label();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pnl_Menu = new System.Windows.Forms.Panel();
			this.btn_recover = new System.Windows.Forms.Label();
			this.btn_Insert = new System.Windows.Forms.Label();
			this.stbar = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mcs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mcs_Sheet1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			this.pnl_Menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
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
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Location = new System.Drawing.Point(505, 5);
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
			// 
			// tbtn_New
			// 
			this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
			// 
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Location = new System.Drawing.Point(55, 24);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(449, 22);
			this.lbl_MainTitle.Text = "MCS Master";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
			this.c1Sizer1.BorderWidth = 0;
			this.c1Sizer1.Controls.Add(this.fgrid_Mcs);
			this.c1Sizer1.Controls.Add(this.pnl_Search);
			this.c1Sizer1.Controls.Add(this.pnl_Menu);
			this.c1Sizer1.Controls.Add(this.stbar);
			this.c1Sizer1.GridDefinition = "19.7628458498024:False:True;66.600790513834:False:False;9.28853754940712:False:Tr" +
				"ue;4.34782608695652:False:True;\t1.00882723833544:False:True;97.9823455233291:Fal" +
				"se:False;1.00882723833544:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(793, 506);
			this.c1Sizer1.SplitterWidth = 0;
			this.c1Sizer1.TabIndex = 26;
			this.c1Sizer1.TabStop = false;
			// 
			// fgrid_Mcs
			// 
			this.fgrid_Mcs.Location = new System.Drawing.Point(8, 100);
			this.fgrid_Mcs.Name = "fgrid_Mcs";
			this.fgrid_Mcs.Sheets.Add(this.fgrid_Mcs_Sheet1);
			this.fgrid_Mcs.Size = new System.Drawing.Size(777, 337);
			this.fgrid_Mcs.TabIndex = 46;
			this.fgrid_Mcs.EditModeOn += new System.EventHandler(this.fgrid_Mcs_EditModeOn);
			this.fgrid_Mcs.EditModeOff += new System.EventHandler(this.fgrid_Mcs_EditModeOff);
			this.fgrid_Mcs.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.fgrid_Mcs_EditChange);
			// 
			// fgrid_Mcs_Sheet1
			// 
			this.fgrid_Mcs_Sheet1.SheetName = "Sheet1";
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.All = 7;
			this.pnl_Search.Location = new System.Drawing.Point(0, 0);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(793, 100);
			this.pnl_Search.TabIndex = 45;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_Search_Name);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.txt_Search_Code);
			this.pnl_SearchImage.Controls.Add(this.lbl_SCode);
			this.pnl_SearchImage.Controls.Add(this.lbl_SFactory);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.pictureBox6);
			this.pnl_SearchImage.Controls.Add(this.textBox1);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(7, 7);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(779, 86);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// txt_Search_Name
			// 
			this.txt_Search_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Search_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Search_Name.Location = new System.Drawing.Point(110, 56);
			this.txt_Search_Name.MaxLength = 50;
			this.txt_Search_Name.Name = "txt_Search_Name";
			this.txt_Search_Name.Size = new System.Drawing.Size(659, 21);
			this.txt_Search_Name.TabIndex = 151;
			this.txt_Search_Name.Text = "";
			this.txt_Search_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_Name_KeyPress);
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(678, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 48);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(765, 71);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(13, 15);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(224, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(544, 28);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "      Common MCS Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Search_Code
			// 
			this.txt_Search_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Search_Code.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Search_Code.Location = new System.Drawing.Point(110, 34);
			this.txt_Search_Code.MaxLength = 5;
			this.txt_Search_Code.Name = "txt_Search_Code";
			this.txt_Search_Code.Size = new System.Drawing.Size(210, 21);
			this.txt_Search_Code.TabIndex = 150;
			this.txt_Search_Code.Text = "";
			this.txt_Search_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_Code_KeyPress);
			// 
			// lbl_SCode
			// 
			this.lbl_SCode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SCode.ImageIndex = 0;
			this.lbl_SCode.ImageList = this.img_Label;
			this.lbl_SCode.Location = new System.Drawing.Point(9, 56);
			this.lbl_SCode.Name = "lbl_SCode";
			this.lbl_SCode.Size = new System.Drawing.Size(100, 21);
			this.lbl_SCode.TabIndex = 148;
			this.lbl_SCode.Text = "Name";
			this.lbl_SCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_SFactory
			// 
			this.lbl_SFactory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_SFactory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SFactory.ImageIndex = 0;
			this.lbl_SFactory.ImageList = this.img_Label;
			this.lbl_SFactory.Location = new System.Drawing.Point(9, 34);
			this.lbl_SFactory.Name = "lbl_SFactory";
			this.lbl_SFactory.Size = new System.Drawing.Size(100, 21);
			this.lbl_SFactory.TabIndex = 149;
			this.lbl_SFactory.Text = "Code";
			this.lbl_SFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(763, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(24, 67);
			this.picb_TR.TabIndex = 21;
			this.picb_TR.TabStop = false;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(123, 70);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(643, 17);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 71);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(144, 19);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 22);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(144, 55);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(137, 22);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(677, 48);
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(137, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(86, 21);
			this.textBox1.TabIndex = 145;
			this.textBox1.Text = "";
			// 
			// pnl_Menu
			// 
			this.pnl_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Menu.Controls.Add(this.btn_recover);
			this.pnl_Menu.Controls.Add(this.btn_Insert);
			this.pnl_Menu.Location = new System.Drawing.Point(8, 437);
			this.pnl_Menu.Name = "pnl_Menu";
			this.pnl_Menu.Size = new System.Drawing.Size(785, 47);
			this.pnl_Menu.TabIndex = 44;
			// 
			// btn_recover
			// 
			this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_recover.ImageIndex = 1;
			this.btn_recover.ImageList = this.image_List;
			this.btn_recover.Location = new System.Drawing.Point(695, 8);
			this.btn_recover.Name = "btn_recover";
			this.btn_recover.Size = new System.Drawing.Size(80, 23);
			this.btn_recover.TabIndex = 351;
			this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
			this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_recover_MouseUp);
			this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_recover_MouseDown);
			// 
			// btn_Insert
			// 
			this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Insert.ImageIndex = 9;
			this.btn_Insert.ImageList = this.image_List;
			this.btn_Insert.Location = new System.Drawing.Point(614, 8);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(80, 23);
			this.btn_Insert.TabIndex = 350;
			this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
			this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Insert_MouseUp);
			this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Insert_MouseDown);
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 484);
			this.stbar.Name = "stbar";
			this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																					 this.statusBarPanel1,
																					 this.statusBarPanel2});
			this.stbar.Size = new System.Drawing.Size(793, 22);
			this.stbar.TabIndex = 43;
			// 
			// Form_BC_Mcs
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.c1Sizer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form_BC_Mcs";
			this.Text = "MCS Master";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mcs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mcs_Sheet1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.pnl_Menu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
 
		#region 사용자 변수
		
		private COM.OraDB MyOraDB = new COM.OraDB();

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
				this.Text = "MCS Master";
				lbl_MainTitle.Text = "MCS Master";
				ClassLib.ComFunction.SetLangDic(this);
 
				// 그리드 설정
				fgrid_Mcs.Set_Spread_Comm("SBC_MCS", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
		  

				// 버튼 설정
				tbtn_Delete.Enabled = false;
				tbtn_Print.Enabled = false;
				tbtn_Conform.Enabled = false;

				ClassLib.ComFunction.Init_Form_Control(this);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		

		/// <summary>
		/// Search_Mcs : 
		/// </summary>
		private void Search_Mcs()
		{
			try
			{
				
				DataTable dt_ret;
				string vcode = "";
				string vname = "";

				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

				vcode = COM.ComFunction.Empty_TextBox(txt_Search_Code, " ");
				vname = COM.ComFunction.Empty_TextBox(txt_Search_Name, " ");

				dt_ret = Select_SBC_Mcs(vcode, vname);
				Display_Grid(dt_ret, fgrid_Mcs);
				dt_ret.Dispose();

				fgrid_Mcs.Set_FontColor_Row((int)ClassLib.TBSBC_MCS.IxUSE_YN, "False", System.Drawing.Color.Red); 
				fgrid_Mcs.Set_FontColor_Row((int)ClassLib.TBSBC_MCS.IxUSE_YN, "True", System.Drawing.Color.Empty); 
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}


		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, COM.SSP arg_fgrid)
		{
			arg_fgrid.Display_Grid(arg_dt) ;
		}



		#endregion

		#region 이벤트 처리


		#region 그리드 이벤트 처리	
		
		
		private void fgrid_Mcs_EditModeOff(object sender, System.EventArgs e)
		{
			ClassLib.ComFunction.Cell_AfterEdit(fgrid_Mcs, (int)ClassLib.TBSBC_MCS.IxMCS_NAME); 
		}
 


		private void fgrid_Mcs_EditModeOn(object sender, System.EventArgs e)
		{
			try
			{
				int ir = fgrid_Mcs.Sheets[0].ActiveRowIndex ;
				int ic = fgrid_Mcs.Sheets[0].ActiveColumnIndex ;

				fgrid_Mcs.Buffer_CellData = (fgrid_Mcs.Sheets[0].Cells[ir,ic].Value == null) ? "" : fgrid_Mcs.Sheets[0].Cells[ir,ic].Value.ToString() ;
			
				string s = fgrid_Mcs.Sheets[0].Columns[ic].CellType.ToString();
				if(s == "CheckBoxCellType" || s == "SSPComboBoxCellType")
				{
					fgrid_Mcs.Buffer_CellData  = "000";
					fgrid_Mcs.Update_Row(img_Action);
				} 

			
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Mcs_EditModeOn", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void fgrid_Mcs_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
			fgrid_Mcs.Update_Row(img_Action);
		}


		#endregion
		
		#region 툴바 메뉴 이벤트 처리

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{ 
			try
			{
				fgrid_Mcs.ClearAll();
				txt_Search_Code.Text = "";
				txt_Search_Name.Text = ""; 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Search_Mcs();
		} 

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Save_Mcs();
		}


		
		private void Save_Mcs()
		{ 

			try
			{

				DataTable dt_ret;
 
				dt_ret = Check_Duplicate_DB(fgrid_Mcs);

				// 중복 아님, 저장 가능
				if(Convert.IsDBNull(dt_ret.Rows[0].ItemArray[0]) )  
				{
					if(MyOraDB.Save_Spread("PKG_SBC_MCS.SAVE_SBC_MCS", fgrid_Mcs) )
					{
						Search_Mcs();
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					}

				} // end if
				else
				{
					ClassLib.ComFunction.User_Message("Duplicate MCS Name : [" 
						+ dt_ret.Rows[0].ItemArray[0].ToString().Trim() + "]", 
						"Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				dt_ret.Dispose(); 
			
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			
		}


		#endregion		

		#region 컨트롤 이벤트 처리
		 

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
			Insert_Row(); 
		}


		/// <summary>
		/// Insert_Row : 
		/// </summary>
		private void Insert_Row()
		{
			try
			{
				bool check = false;
				int addrow = -1; 
				
				//이전 행 데이터 필수 입력 체크
				check = ClassLib.ComFunction.Check_Essential_Col(fgrid_Mcs); 
				if(!check) return; 

				//행 수정상태 해제
				//fgrid_Mcs.ActiveSheet.ActiveRowIndex = fgrid_Mcs.ActiveSheet.RowCount - 1; 

				addrow = fgrid_Mcs.Add_Row(img_Action);
				fgrid_Mcs.ActiveSheet.Cells[addrow, (int)ClassLib.TBSBC_MCS.IxUSE_YN].Value = true;

				//top row 기능
				fgrid_Mcs.Set_CellPosition(addrow, (int)ClassLib.TBSBC_MCS.IxMCS_NAME); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Insert_Row", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}
 


		


		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			fgrid_Mcs.Recovery();
		}

		private void txt_Search_Code_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);

			if(e.KeyChar == (char)13) Search_Mcs(); 
		}

		private void txt_Search_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13) Search_Mcs();
		}


		#region 롤오버 처리

		private void btn_Insert_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Insert.ImageIndex = 9;
		}

		private void btn_Insert_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Insert.ImageIndex = 8;
		}

		private void btn_recover_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_recover.ImageIndex = 1;
		}

		private void btn_recover_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_recover.ImageIndex = 0;
		}
		#endregion
		#endregion



		#endregion

		#region DB Connect
 		
		/// <summary>
		/// Select_SBC_Mcs : Mcs 조회
		/// </summary>
		/// <returns></returns>
		public static DataTable Select_SBC_Mcs(string arg_value1, string arg_value2)
		{
 
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_MCS.SELECT_SBC_MCS";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_VALUE1";
			MyOraDB.Parameter_Name[1] = "ARG_VALUE2";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_value1; 
			MyOraDB.Parameter_Values[1] = arg_value2; 
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}
		


		/// <summary>
		/// Check_Duplicate_DB : 
		/// </summary>
		/// <param name="arg_grid"></param>
		/// <returns></returns>
		private DataTable Check_Duplicate_DB(COM.SSP arg_grid)
		{  
			try
			{
				DataSet ds_ret; 
				string mcs_name = "";

				MyOraDB.ReDim_Parameter(2);
				MyOraDB.Process_Name = "PKG_SBC_MCS.CHECK_MCS_EXIST"; 
				
				MyOraDB.Parameter_Name[0] = "ARG_MCS_NAME"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 
 
				for(int row = 0; row < arg_grid.ActiveSheet.Rows.Count; row++)
				{
					if(arg_grid.ActiveSheet.Cells[row, 0].Tag == null
						|| arg_grid.ActiveSheet.Cells[row, 0].Tag.ToString().Trim() != "I") continue; 
					 
					if(mcs_name.Equals("") )
					{
						mcs_name = @"'" + arg_grid.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_MCS.IxMCS_NAME].Value.ToString().Trim() + @"'";
					}
					else
					{
						mcs_name += @", '" + arg_grid.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_MCS.IxMCS_NAME].Value.ToString().Trim() + @"'";
					}
				}

				MyOraDB.Parameter_Values[0] = mcs_name;
				MyOraDB.Parameter_Values[1] = ""; 
				 
				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
				  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Check_Duplicate_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			} 
		}



		#endregion																								

		 


	}
}

