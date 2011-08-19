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
	public class Form_BC_Color : COM.PCHWinForm.Pop_Large
	{

		#region 컨트롤 정의 및 리소스 정리

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.TextBox txt_Search_Name;
		private System.Windows.Forms.TextBox txt_Search_Code;
		private System.Windows.Forms.Label lbl_SCode;
		private System.Windows.Forms.Label lbl_SFactory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.StatusBar stbar;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnl_Menu;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Insert;
		private COM.SSP fgrid_Color;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
        private FarPoint.Win.Spread.SheetView fgrid_Color_Sheet1;
		private COM.OraDB MyOraDB = new COM.OraDB();

		public Form_BC_Color()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();


		}



		private bool _ReturnYN = false;

		public Form_BC_Color(bool arg_returnyn)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BC_Color));
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_Color = new COM.SSP();
            this.fgrid_Color_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.stbar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txt_Search_Name = new System.Windows.Forms.TextBox();
            this.txt_Search_Code = new System.Windows.Forms.TextBox();
            this.lbl_SCode = new System.Windows.Forms.Label();
            this.lbl_SFactory = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Color_Sheet1)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
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
            this.c1CommandHolder1.Commands.Add(this.tbtn_Conform);
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
            this.c1Sizer1.Controls.Add(this.fgrid_Color);
            this.c1Sizer1.Controls.Add(this.pnl_Menu);
            this.c1Sizer1.Controls.Add(this.stbar);
            this.c1Sizer1.Controls.Add(this.pnl_Search);
            this.c1Sizer1.GridDefinition = "19.9203187250996:False:True;67.9282868525896:False:False;7.76892430278884:False:T" +
                "rue;4.38247011952191:False:True;\t1.01010101010101:False:True;97.979797979798:Fal" +
                "se:False;1.01010101010101:False:False;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(792, 502);
            this.c1Sizer1.SplitterWidth = 0;
            this.c1Sizer1.TabIndex = 25;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_Color
            // 
            this.fgrid_Color.BackColor = System.Drawing.Color.Transparent;
            this.fgrid_Color.Location = new System.Drawing.Point(8, 100);
            this.fgrid_Color.Name = "fgrid_Color";
            this.fgrid_Color.Sheets.Add(this.fgrid_Color_Sheet1);
            this.fgrid_Color.Size = new System.Drawing.Size(776, 341);
            this.fgrid_Color.TabIndex = 44;
            this.fgrid_Color.EditModeOn += new System.EventHandler(this.fgrid_Color_EditModeOn);
            this.fgrid_Color.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.fgrid_Color_EditChange);
            this.fgrid_Color.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fgrid_Color_CellDoubleClick);
            // 
            // fgrid_Color_Sheet1
            // 
            this.fgrid_Color_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Menu.Controls.Add(this.btn_recover);
            this.pnl_Menu.Controls.Add(this.btn_Insert);
            this.pnl_Menu.Location = new System.Drawing.Point(8, 441);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(776, 39);
            this.pnl_Menu.TabIndex = 43;
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(695, 8);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 23);
            this.btn_recover.TabIndex = 342;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_recover_MouseDown);
            this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_recover_MouseUp);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(614, 8);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 23);
            this.btn_Insert.TabIndex = 341;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Insert_MouseDown);
            this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Insert_MouseUp);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 480);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(792, 22);
            this.stbar.TabIndex = 42;
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
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(792, 100);
            this.pnl_Search.TabIndex = 41;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.txt_Search_Name);
            this.pnl_SearchImage.Controls.Add(this.txt_Search_Code);
            this.pnl_SearchImage.Controls.Add(this.lbl_SCode);
            this.pnl_SearchImage.Controls.Add(this.lbl_SFactory);
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
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(776, 84);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // txt_Search_Name
            // 
            this.txt_Search_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search_Name.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Search_Name.Location = new System.Drawing.Point(109, 54);
            this.txt_Search_Name.MaxLength = 120;
            this.txt_Search_Name.Name = "txt_Search_Name";
            this.txt_Search_Name.Size = new System.Drawing.Size(659, 21);
            this.txt_Search_Name.TabIndex = 38;
            this.txt_Search_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_Name_KeyPress);
            // 
            // txt_Search_Code
            // 
            this.txt_Search_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search_Code.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Search_Code.Location = new System.Drawing.Point(109, 32);
            this.txt_Search_Code.MaxLength = 10;
            this.txt_Search_Code.Name = "txt_Search_Code";
            this.txt_Search_Code.Size = new System.Drawing.Size(210, 21);
            this.txt_Search_Code.TabIndex = 37;
            this.txt_Search_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_Code_KeyPress);
            // 
            // lbl_SCode
            // 
            this.lbl_SCode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SCode.ImageIndex = 0;
            this.lbl_SCode.ImageList = this.img_Label;
            this.lbl_SCode.Location = new System.Drawing.Point(8, 54);
            this.lbl_SCode.Name = "lbl_SCode";
            this.lbl_SCode.Size = new System.Drawing.Size(100, 21);
            this.lbl_SCode.TabIndex = 34;
            this.lbl_SCode.Text = "Name";
            this.lbl_SCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SFactory
            // 
            this.lbl_SFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SFactory.ImageIndex = 0;
            this.lbl_SFactory.ImageList = this.img_Label;
            this.lbl_SFactory.Location = new System.Drawing.Point(8, 32);
            this.lbl_SFactory.Name = "lbl_SFactory";
            this.lbl_SFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_SFactory.TabIndex = 36;
            this.lbl_SFactory.Text = "Code";
            this.lbl_SFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(675, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 48);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(760, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(24, 72);
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
            this.picb_TM.Size = new System.Drawing.Size(552, 32);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // lbl_SubTitle1
            // 
            this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
            this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle1.Name = "lbl_SubTitle1";
            this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle1.TabIndex = 28;
            this.lbl_SubTitle1.Text = "      Common Color Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(760, 69);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 68);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(616, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 69);
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
            this.picb_ML.Location = new System.Drawing.Point(0, 24);
            this.picb_ML.Name = "picb_ML";
            this.picb_ML.Size = new System.Drawing.Size(168, 51);
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
            this.picb_MM.Size = new System.Drawing.Size(608, 44);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // Form_BC_Color
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.c1Sizer1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_BC_Color";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Color_Sheet1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            this.ResumeLayout(false);

		}
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
				this.Text = "Color Master";
				lbl_MainTitle.Text = "Color Master";
				ClassLib.ComFunction.SetLangDic(this);
				
				// 그리드 설정
				fgrid_Color.Set_Spread_Comm("SBC_COLOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 

				// 버튼 설정
				tbtn_Delete.Enabled = false; 
				tbtn_Conform.Enabled = false;
				
				
				ClassLib.ComFunction.Init_Form_Control(this); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}
 

		/// <summary>
		/// Search_Color : 데이터 조회
		/// </summary>
		public void Search_Color()
		{ 
			try
			{
                DataTable dt_ret;
				string vcode = "";
				string vname = "";
				
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

				vcode = ClassLib.ComFunction.Empty_TextBox(txt_Search_Code, " ");
				vname = ClassLib.ComFunction.Empty_TextBox(txt_Search_Name, " ");
				

				// 그리드 설정
				fgrid_Color.Set_Spread_Comm("SBC_COLOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 


				dt_ret = Select_SBC_COLOR(vcode, vname);
				Display_Grid(dt_ret, fgrid_Color);
				dt_ret.Dispose();


				fgrid_Color.Set_FontColor_Row((int)ClassLib.TBSBC_COLOR.IxUSE_YN, "False", System.Drawing.Color.Red);
				fgrid_Color.Set_FontColor_Row((int)ClassLib.TBSBC_COLOR.IxUSE_YN, "True", System.Drawing.Color.Empty);
 
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Color", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

 

		/// <summary>
		/// Insert_Color : 새로운 컬러 코드 생성
		/// </summary>
		private void Insert_Color()
		{
			try
			{ 
				string vresult = ""; 
				int add_row = 0;
				 
				Pop_Color popup = new Pop_Color(); 
				popup.ShowDialog();

				vresult = popup._ColorName;
				popup.Dispose(); 


				if(vresult.Trim().Equals("") ) return;

				add_row = fgrid_Color.Add_Row(img_Action);
				fgrid_Color.ActiveSheet.Cells[add_row, (int)ClassLib.TBSBC_COLOR.IxCOLOR_NAME].Value = vresult;
				fgrid_Color.ActiveSheet.Cells[add_row, (int)ClassLib.TBSBC_COLOR.IxUSE_YN].Value = true; 
				
				//top row 기능
				fgrid_Color.Set_CellPosition(add_row, (int)ClassLib.TBSBC_COLOR.IxCOLOR_NAME); 

				fgrid_Color.ActiveSheet.Rows[add_row].Locked = false;



			
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Insert_Color", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}
		 
		private void  SetPrintYield()
		{
			try
			{   
	
						 
				string mrd_Filename = "Report/Material/Form_BC_Color_Master.mrd" ;
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


		private void fgrid_Color_EditModeOn(object sender, System.EventArgs e)
		{
			try
			{
				int ir = fgrid_Color.Sheets[0].ActiveRowIndex ;
				int ic = fgrid_Color.Sheets[0].ActiveColumnIndex ;

				fgrid_Color.Buffer_CellData = (fgrid_Color.Sheets[0].Cells[ir,ic].Value == null) ? "" : fgrid_Color.Sheets[0].Cells[ir,ic].Value.ToString() ;
				
				string s = fgrid_Color.Sheets[0].Columns[ic].CellType.ToString();
				if(s == "CheckBoxCellType" || s == "SSPComboBoxCellType")
				{
					fgrid_Color.Buffer_CellData = "000";
					fgrid_Color.Update_Row(img_Action);
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Color_EditModeOn", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		private void fgrid_Color_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
			try
			{
				fgrid_Color.Update_Row(img_Action);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Color_EditChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}
 



		
		private void fgrid_Color_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{


			try
			{
				if(fgrid_Color.ActiveSheet.RowCount == 0) return;

				int sel_row = fgrid_Color.ActiveSheet.ActiveRowIndex; 


				if(_ReturnYN)
				{

					ClassLib.ComVar.Parameter_PopUp  = new string[] { fgrid_Color.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_COLOR.IxCOLOR_CD].Text.ToString(), 
																		fgrid_Color.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_COLOR.IxCOLOR_NAME].Text.ToString() };

					this.Close();

				} 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Color_CellDoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}




		#endregion
		
		#region 툴바 메뉴 이벤트 처리
				
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Color.ClearAll();

			txt_Search_Code.Text = "";
			txt_Search_Name.Text = "";
		}
		

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Search_Color();
		}


		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
  
			fgrid_Color.EditMode = false; 


			if(MyOraDB.Save_Spread("PKG_SBC_COLOR.SAVE_SBC_COLOR", fgrid_Color) )
			{ 
				//Search_Color(); 

				//new color code display
				DataTable dt_ret = null;
				string color_cd = "", color_name = "", use_yn = "";

				for(int i = fgrid_Color.ActiveSheet.RowCount - 1; i >= 0; i--)
				{

					if(fgrid_Color.ActiveSheet.Cells[i, 0].Tag == null || fgrid_Color.ActiveSheet.Cells[i, 0].Tag.ToString() != "I") continue;

					color_cd = " ";
					color_name = fgrid_Color.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_COLOR.IxCOLOR_NAME].Text.ToString().Trim();
					use_yn = ( Convert.ToBoolean(fgrid_Color.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_COLOR.IxUSE_YN].Value.ToString() ) == true) ? "Y" : "N";

					dt_ret = FlexBase.MaterialBase.Pop_Item_List.Select_SBC_COLOR_COMMON(color_cd, color_name, use_yn);
					color_cd = dt_ret.Rows[0].ItemArray[0].ToString(); 

					fgrid_Color.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_COLOR.IxCOLOR_CD].Text = color_cd; 

					

					dt_ret.Dispose();
					
				}


				//action flag clear
				fgrid_Color.Refresh_Division(); 
				 


				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);


				//top row 기능
				fgrid_Color.Set_CellPosition(fgrid_Color.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_COLOR.IxCOLOR_NAME); 


			}
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

		#endregion		

		#region 컨트롤 이벤트 처리 

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
			Insert_Color();
		}

		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			if ((fgrid_Color.ActiveSheet.RowCount > 0))
			{
				fgrid_Color.Recovery();
			}
		}



		private void txt_Search_Code_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//ClassLib.ComFunction.numeric_Type(e);
			ClassLib.ComFunction.KeyEnter_Tab(e);

			if(e.KeyChar == (char)13) Search_Color();  
		}

		
		private void txt_Search_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13) Search_Color(); 
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
		/// Select_SBC_COLOR : Color 조회
		/// </summary>
		/// <returns></returns>
		public static DataTable Select_SBC_COLOR(string arg_code,string arg_name)
		{ 
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_COLOR.SELECT_SBC_COLOR";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[1] = "ARG_COLOR_NAME";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
			
			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_code;
			MyOraDB.Parameter_Values[1] = arg_name;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}
		
		#endregion																								





	}
}

