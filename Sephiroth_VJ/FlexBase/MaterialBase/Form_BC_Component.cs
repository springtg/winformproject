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
	public class Form_BC_Component : COM.PCHWinForm.Pop_Large
	{

		#region 컨트롤 정의 및 리소스 정리

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.TextBox txt_Search_Name;
		private System.Windows.Forms.TextBox txt_Search_Code;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.Panel pnl_Menu;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.Label btn_recover;
		private COM.SSP fgrid_Componet;
		private FarPoint.Win.Spread.SheetView fgrid_Componet_Sheet1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2; 
		private System.Windows.Forms.Label lbl_Name;
		public System.Windows.Forms.PictureBox picb_MR;
		private System.Windows.Forms.Label lbl_Code; 

		public Form_BC_Component()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();

		}



		private bool _ReturnYN = false;

		public Form_BC_Component(bool arg_returnyn)
		{ 


			InitializeComponent(); 

			_ReturnYN = arg_returnyn; 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BC_Component));
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_Componet = new COM.SSP();
            this.fgrid_Componet_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.stbar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txt_Search_Name = new System.Windows.Forms.TextBox();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.txt_Search_Code = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Componet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Componet_Sheet1)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(505, 5);
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
            this.lbl_MainTitle.Size = new System.Drawing.Size(449, 22);
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
            this.c1Sizer1.Controls.Add(this.fgrid_Componet);
            this.c1Sizer1.Controls.Add(this.pnl_Menu);
            this.c1Sizer1.Controls.Add(this.stbar);
            this.c1Sizer1.Controls.Add(this.pnl_Search);
            this.c1Sizer1.GridDefinition = "19.7628458498024:False:True;66.798418972332:False:False;9.09090909090909:False:Tr" +
                "ue;4.34782608695652:False:True;\t1.00882723833544:False:True;97.9823455233291:Fal" +
                "se:False;1.00882723833544:False:False;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(793, 506);
            this.c1Sizer1.SplitterWidth = 0;
            this.c1Sizer1.TabIndex = 25;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_Componet
            // 
            this.fgrid_Componet.Location = new System.Drawing.Point(8, 100);
            this.fgrid_Componet.Name = "fgrid_Componet";
            this.fgrid_Componet.Sheets.Add(this.fgrid_Componet_Sheet1);
            this.fgrid_Componet.Size = new System.Drawing.Size(777, 338);
            this.fgrid_Componet.TabIndex = 47;
            this.fgrid_Componet.EditModeOn += new System.EventHandler(this.fgrid_Componet_EditModeOn);
            this.fgrid_Componet.EditModeOff += new System.EventHandler(this.fgrid_Componet_EditModeOff);
            this.fgrid_Componet.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.fgrid_Componet_EditChange);
            this.fgrid_Componet.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fgrid_Componet_CellDoubleClick);
            // 
            // fgrid_Componet_Sheet1
            // 
            this.fgrid_Componet_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Menu.Controls.Add(this.btn_recover);
            this.pnl_Menu.Controls.Add(this.btn_Insert);
            this.pnl_Menu.Location = new System.Drawing.Point(8, 438);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(785, 46);
            this.pnl_Menu.TabIndex = 46;
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(695, 8);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 23);
            this.btn_recover.TabIndex = 349;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_recover_MouseDown);
            this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_recover_MouseUp);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(614, 8);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 23);
            this.btn_Insert.TabIndex = 344;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Insert_MouseDown);
            this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Insert_MouseUp);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 484);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(793, 22);
            this.stbar.TabIndex = 45;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            // 
            // pnl_Search
            // 
            this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Location = new System.Drawing.Point(0, 0);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(7);
            this.pnl_Search.Size = new System.Drawing.Size(793, 100);
            this.pnl_Search.TabIndex = 43;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.txt_Search_Name);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.txt_Search_Code);
            this.pnl_SearchImage.Controls.Add(this.lbl_Name);
            this.pnl_SearchImage.Controls.Add(this.lbl_Code);
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
            this.txt_Search_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search_Name.Location = new System.Drawing.Point(110, 56);
            this.txt_Search_Name.MaxLength = 50;
            this.txt_Search_Name.Name = "txt_Search_Name";
            this.txt_Search_Name.Size = new System.Drawing.Size(659, 21);
            this.txt_Search_Name.TabIndex = 147;
            this.txt_Search_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_Name_KeyPress);
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(678, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 48);
            this.picb_MR.TabIndex = 148;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(763, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(20, 32);
            this.picb_TR.TabIndex = 21;
            this.picb_TR.TabStop = false;
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(224, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(542, 30);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(763, 71);
            this.picb_BR.Name = "picb_BR";
            this.picb_BR.Size = new System.Drawing.Size(13, 15);
            this.picb_BR.TabIndex = 23;
            this.picb_BR.TabStop = false;
            // 
            // lbl_SubTitle1
            // 
            this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
            this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle1.Name = "lbl_SubTitle1";
            this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle1.TabIndex = 28;
            this.lbl_SubTitle1.Text = "      Common Component Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Search_Code
            // 
            this.txt_Search_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search_Code.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search_Code.Location = new System.Drawing.Point(110, 34);
            this.txt_Search_Code.MaxLength = 15;
            this.txt_Search_Code.Name = "txt_Search_Code";
            this.txt_Search_Code.Size = new System.Drawing.Size(210, 21);
            this.txt_Search_Code.TabIndex = 146;
            this.txt_Search_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_Code_KeyPress);
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_Name.ImageIndex = 0;
            this.lbl_Name.ImageList = this.img_Label;
            this.lbl_Name.Location = new System.Drawing.Point(9, 56);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(100, 21);
            this.lbl_Name.TabIndex = 34;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Code
            // 
            this.lbl_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Code.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Code.ImageIndex = 0;
            this.lbl_Code.ImageList = this.img_Label;
            this.lbl_Code.Location = new System.Drawing.Point(9, 34);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(100, 21);
            this.lbl_Code.TabIndex = 36;
            this.lbl_Code.Text = "Code";
            this.lbl_Code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pictureBox6.Size = new System.Drawing.Size(635, 48);
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 21);
            this.textBox1.TabIndex = 145;
            // 
            // Form_BC_Component
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.c1Sizer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_BC_Component";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Componet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Componet_Sheet1)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 변수
 
		private static COM.OraDB MyOraDB = new COM.OraDB(); 

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
                this.Text = "Component Master";
                lbl_MainTitle.Text = "Component Master";
				ClassLib.ComFunction.SetLangDic(this);
 
				// 그리드 설정
				fgrid_Componet.Set_Spread_Comm("SBC_COMPONENT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 

				// 버튼 설정
				tbtn_Delete.Enabled = false;
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
		/// Search_Component : 
		/// </summary>
		public void Search_Component()
		{ 
			try
			{
				DataTable dt_ret;
				string vcode = "";
				string vname = "";

				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

				vcode = COM.ComFunction.Empty_TextBox(txt_Search_Code, " ");
				vname = COM.ComFunction.Empty_TextBox(txt_Search_Name, " ");

				dt_ret = Select_SBC_Componet(vcode, vname);
				Display_Grid(dt_ret, fgrid_Componet);
				dt_ret.Dispose();
 
				fgrid_Componet.Set_FontColor_Row((int)ClassLib.TBSBC_COMPONENT.IxUSE_YN, "False", System.Drawing.Color.Red);
				fgrid_Componet.Set_FontColor_Row((int)ClassLib.TBSBC_COMPONENT.IxUSE_YN, "True", System.Drawing.Color.Empty);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Component", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			arg_fgrid.Display_Grid(arg_dt);
		}

		private void  SetPrintYield()
		{
			try
			{   
	
						 
				string mrd_Filename = "Report/Material/Form_BC_Component_Master.mrd" ;
				string Para         = " ";

				#region 출력조건

				int  iCnt  = 2;
				string [] aHead =  new string[iCnt];	

				string vcode = ClassLib.ComFunction.Empty_TextBox(txt_Search_Code, " ");
				string vname = ClassLib.ComFunction.Empty_TextBox(txt_Search_Name, " ");
				aHead[0]    = vcode;
				aHead[1]    = vname;
		
			
				#endregion
	
				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{				
					Para = Para + "[" + aHead[i-1] + "] ";
				}
	
				FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer ( mrd_Filename, Para);
				report.Show();	

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetPrintYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}

		#endregion

		#region 이벤트 처리
 

		#region 그리드 이벤트 처리



		private void fgrid_Componet_EditModeOff(object sender, System.EventArgs e)
		{
			ClassLib.ComFunction.Cell_AfterEdit(fgrid_Componet, (int)ClassLib.TBSBC_COMPONENT.IxCOMPONENT_NM); 
		}



		private void fgrid_Componet_EditModeOn(object sender, System.EventArgs e)
		{
			try
			{
				int ir = fgrid_Componet.ActiveSheet.ActiveRowIndex ;
				int ic = fgrid_Componet.ActiveSheet.ActiveColumnIndex ;

				fgrid_Componet.Buffer_CellData = (fgrid_Componet.ActiveSheet.Cells[ir,ic].Value == null) ? "" : fgrid_Componet.ActiveSheet.Cells[ir,ic].Value.ToString() ;
				
				string s = fgrid_Componet.ActiveSheet.Columns[ic].CellType.ToString();
				if(s == "CheckBoxCellType" || s == "SSPComboBoxCellType")
				{
					fgrid_Componet.Buffer_CellData  = "000";
					fgrid_Componet.Update_Row(img_Action);
				} 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Componet_EditModeOn", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			
		}
 


		private void fgrid_Componet_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
			fgrid_Componet.Update_Row(img_Action); 
		}

 


		private void fgrid_Componet_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
		
			try
			{
				 
				if(fgrid_Componet.ActiveSheet.RowCount == 0) return;

				int sel_row = fgrid_Componet.ActiveSheet.ActiveRowIndex; 


				if(_ReturnYN)
				{

					ClassLib.ComVar.Parameter_PopUp  = new string[] { fgrid_Componet.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_COMPONENT.IxCOMPONENT].Text.ToString(), 
																		fgrid_Componet.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_COMPONENT.IxCOMPONENT_NM].Text.ToString() };

					this.Close();

				} 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Componet_CellDoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}




		#endregion
		
		#region 툴바 메뉴 이벤트 처리
				
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				fgrid_Componet.ClearAll();
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
			Search_Component();
		}

		
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Save_Component(); 
		}
		

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (txt_Search_Code.Text.Trim().Length == 0 && txt_Search_Name.Text.Trim().Length == 0)
			{
				ClassLib.ComFunction.User_Message("Input Search Proviso", "Print", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			SetPrintYield();
		}


		/// <summary>
		/// Save_Component : 
		/// </summary>
		private void Save_Component()
		{  
			try
			{
				DataTable dt_ret;
 
				dt_ret = Check_Duplicate_DB(fgrid_Componet);

				// 중복 아님, 저장 가능
				if(Convert.IsDBNull(dt_ret.Rows[0].ItemArray[0]) )  
				{
					if(MyOraDB.Save_Spread("PKG_SBC_COMPONENT.SAVE_SBC_COMPONENT", fgrid_Componet) )
					{
						//Search_Component();
						//new color code display
						DataTable dt_ret1 = null;
						string component_cd = "", component_name = "";

						for(int i = fgrid_Componet.ActiveSheet.RowCount - 1; i >= 0; i--)
						{

							if(fgrid_Componet.ActiveSheet.Cells[i, 0].Tag == null || fgrid_Componet.ActiveSheet.Cells[i, 0].Tag.ToString() != "I") continue;

							component_cd = " ";
							component_name = fgrid_Componet.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_COMPONENT.IxCOMPONENT_NM].Text.ToString().Trim();
							 
							dt_ret1 = Select_SBC_Componet(component_cd, component_name);
							component_cd = dt_ret1.Rows[0].ItemArray[0].ToString(); 

							fgrid_Componet.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_COMPONENT.IxCOMPONENT].Text = component_cd; 
					
						}


						dt_ret.Dispose();


						//action flag clear
						fgrid_Componet.Refresh_Division(); 



						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					}

				} // end if
				else
				{
					ClassLib.ComFunction.User_Message("Duplicate Component Name : [" 
						                              + dt_ret.Rows[0].ItemArray[0].ToString().Trim() + "]", 
						                              "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				dt_ret.Dispose(); 
			
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Component", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
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
				string cmp_name = "";

				MyOraDB.ReDim_Parameter(2);
				MyOraDB.Process_Name = "PKG_SBC_COMPONENT.CHECK_COMPONENT_EXIST"; 
				
				MyOraDB.Parameter_Name[0] = "ARG_COMPONENT_NAME"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 
 
				for(int row = 0; row < arg_grid.ActiveSheet.Rows.Count; row++)
				{
					if(arg_grid.ActiveSheet.Cells[row, 0].Tag == null
						|| arg_grid.ActiveSheet.Cells[row, 0].Tag.ToString().Trim() != "I") continue; 
					 
					if(cmp_name.Equals("") )
					{
						cmp_name = @"'" + arg_grid.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_COMPONENT.IxCOMPONENT_NM].Value.ToString().Trim() + @"'";
					}
					else
					{
						cmp_name += @", '" + arg_grid.ActiveSheet.Cells[row, (int)ClassLib.TBSBC_COMPONENT.IxCOMPONENT_NM].Value.ToString().Trim() + @"'";
					}
				}

				MyOraDB.Parameter_Values[0] = cmp_name;
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
				
				fgrid_Componet.EditMode = false; 

				bool check = false;
				int addrow = -1; 
				
				//이전 행 데이터 필수 입력 체크
				check = ClassLib.ComFunction.Check_Essential_Col(fgrid_Componet); 
				if(!check) return;  
			 
				addrow = fgrid_Componet.Add_Row(img_Action) ;
				fgrid_Componet.ActiveSheet.Cells[addrow, (int)ClassLib.TBSBC_COMPONENT.IxUSE_YN].Value = true;

				//top row 기능
				fgrid_Componet.Set_CellPosition(addrow, (int)ClassLib.TBSBC_COMPONENT.IxCOMPONENT_NM);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Insert_Row", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}
 
 


		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			fgrid_Componet.Recovery(); 
		}

		private void txt_Search_Code_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);

			if(e.KeyChar == (char)13) Search_Component(); 
		}

		private void txt_Search_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13) Search_Component(); 
		}

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

		#region DB Connect
		/// <summary>
		/// Select_SBC_Componet : Componet 조회
		/// </summary>
		/// <returns></returns>
		public static DataTable Select_SBC_Componet(string arg_value1, string arg_value2)
		{ 
		 	DataSet ds_ret;
  
			MyOraDB.ReDim_Parameter(3); 
 
			MyOraDB.Process_Name = "PKG_SBC_COMPONENT.SELECT_SBC_COMPONENT";
  
			MyOraDB.Parameter_Name[0] = "ARG_VALUE1";
			MyOraDB.Parameter_Name[1] = "ARG_VALUE2";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = arg_value1; 
			MyOraDB.Parameter_Values[1] = arg_value2; 
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}
 

		#endregion																								

		


	}
}

