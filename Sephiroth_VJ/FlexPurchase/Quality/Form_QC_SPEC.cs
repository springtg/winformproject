using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;



namespace FlexPurchase.Quality
{
	public class Form_QC_SPEC : COM.PCHWinForm.Pop_Large
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
		private System.Windows.Forms.StatusBar stbar;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label lbl_Spec;
		private System.Windows.Forms.Label lbl_Component;
		private C1.Win.C1List.C1Combo cmb_Component;
		private System.Windows.Forms.Label lbl_Date;
		private System.Windows.Forms.TextBox txt_Spec;
		private C1.Win.C1List.C1Combo cmb_Spec;
		private System.Windows.Forms.DateTimePicker dpick_Date;
		private COM.SSP fgrid_Spec;
		private System.Windows.Forms.Label btn_Insert;
		private FarPoint.Win.Spread.SheetView fgrid_Spec_Sheet1; 

		public Form_QC_SPEC()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QC_SPEC));
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_Spec = new COM.SSP();
            this.fgrid_Spec_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.stbar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.cmb_Spec = new C1.Win.C1List.C1Combo();
            this.txt_Spec = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dpick_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Component = new System.Windows.Forms.Label();
            this.cmb_Component = new C1.Win.C1List.C1Combo();
            this.lbl_Spec = new System.Windows.Forms.Label();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Spec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Spec_Sheet1)).BeginInit();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Spec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Component)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(433, 4);
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
            this.lbl_MainTitle.Size = new System.Drawing.Size(267, 22);
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
            this.c1Sizer1.Controls.Add(this.fgrid_Spec);
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.Controls.Add(this.stbar);
            this.c1Sizer1.Controls.Add(this.pnl_Search);
            this.c1Sizer1.GridDefinition = "21.3675213675214:False:True;67.5213675213675:False:False;6.41025641025641:False:T" +
                "rue;4.7008547008547:False:True;\t1.17820324005891:False:True;97.7908689248895:Fal" +
                "se:False;1.03092783505155:False:False;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(679, 468);
            this.c1Sizer1.SplitterWidth = 0;
            this.c1Sizer1.TabIndex = 25;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_Spec
            // 
            this.fgrid_Spec.Location = new System.Drawing.Point(8, 100);
            this.fgrid_Spec.Name = "fgrid_Spec";
            this.fgrid_Spec.Sheets.Add(this.fgrid_Spec_Sheet1);
            this.fgrid_Spec.Size = new System.Drawing.Size(664, 316);
            this.fgrid_Spec.TabIndex = 47;
            this.fgrid_Spec.Click += new System.EventHandler(this.fgrid_Spec_Click);
            this.fgrid_Spec.EditModeOn += new System.EventHandler(this.fgrid_Spec_EditModeOn);
            this.fgrid_Spec.EditModeOff += new System.EventHandler(this.fgrid_Spec_EditModeOff);
            this.fgrid_Spec.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.fgrid_Spec_EditChange);
            // 
            // fgrid_Spec_Sheet1
            // 
            this.fgrid_Spec_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_menu.Controls.Add(this.btn_delete);
            this.pnl_menu.Controls.Add(this.btn_recover);
            this.pnl_menu.Controls.Add(this.btn_Insert);
            this.pnl_menu.Location = new System.Drawing.Point(0, 416);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(679, 30);
            this.pnl_menu.TabIndex = 170;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_delete.ImageIndex = 5;
            this.btn_delete.ImageList = this.image_List;
            this.btn_delete.Location = new System.Drawing.Point(496, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 24);
            this.btn_delete.TabIndex = 365;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(584, 3);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(82, 24);
            this.btn_recover.TabIndex = 364;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(408, 3);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(82, 24);
            this.btn_Insert.TabIndex = 363;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 446);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(679, 22);
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
            this.pnl_Search.Size = new System.Drawing.Size(672, 100);
            this.pnl_Search.TabIndex = 43;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.cmb_Spec);
            this.pnl_SearchImage.Controls.Add(this.txt_Spec);
            this.pnl_SearchImage.Controls.Add(this.lbl_Date);
            this.pnl_SearchImage.Controls.Add(this.dpick_Date);
            this.pnl_SearchImage.Controls.Add(this.lbl_Component);
            this.pnl_SearchImage.Controls.Add(this.cmb_Component);
            this.pnl_SearchImage.Controls.Add(this.lbl_Spec);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.textBox1);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(7, 7);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(658, 86);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // cmb_Spec
            // 
            this.cmb_Spec.AddItemCols = 0;
            this.cmb_Spec.AddItemSeparator = ';';
            this.cmb_Spec.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Spec.Caption = "";
            this.cmb_Spec.CaptionHeight = 17;
            this.cmb_Spec.CaptionStyle = style25;
            this.cmb_Spec.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Spec.ColumnCaptionHeight = 18;
            this.cmb_Spec.ColumnFooterHeight = 18;
            this.cmb_Spec.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Spec.ContentHeight = 17;
            this.cmb_Spec.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Spec.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Spec.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Spec.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Spec.EditorHeight = 17;
            this.cmb_Spec.EvenRowStyle = style26;
            this.cmb_Spec.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Spec.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Spec.FooterStyle = style27;
            this.cmb_Spec.GapHeight = 2;
            this.cmb_Spec.HeadingStyle = style28;
            this.cmb_Spec.HighLightRowStyle = style29;
            this.cmb_Spec.ItemHeight = 15;
            this.cmb_Spec.Location = new System.Drawing.Point(169, 55);
            this.cmb_Spec.MatchEntryTimeout = ((long)(2000));
            this.cmb_Spec.MaxDropDownItems = ((short)(5));
            this.cmb_Spec.MaxLength = 32767;
            this.cmb_Spec.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Spec.Name = "cmb_Spec";
            this.cmb_Spec.OddRowStyle = style30;
            this.cmb_Spec.PartialRightColumn = false;
            this.cmb_Spec.PropBag = resources.GetString("cmb_Spec.PropBag");
            this.cmb_Spec.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Spec.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Spec.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Spec.SelectedStyle = style31;
            this.cmb_Spec.Size = new System.Drawing.Size(176, 21);
            this.cmb_Spec.Style = style32;
            this.cmb_Spec.TabIndex = 365;
            this.cmb_Spec.Tag = "PK";
            this.cmb_Spec.TextChanged += new System.EventHandler(this.cmb_Spec_TextChanged);
            // 
            // txt_Spec
            // 
            this.txt_Spec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Spec.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Spec.Location = new System.Drawing.Point(108, 55);
            this.txt_Spec.MaxLength = 10;
            this.txt_Spec.Name = "txt_Spec";
            this.txt_Spec.Size = new System.Drawing.Size(60, 21);
            this.txt_Spec.TabIndex = 364;
            this.txt_Spec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Spec_KeyPress);
            // 
            // lbl_Date
            // 
            this.lbl_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ImageIndex = 0;
            this.lbl_Date.ImageList = this.img_Label;
            this.lbl_Date.Location = new System.Drawing.Point(360, 55);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(100, 21);
            this.lbl_Date.TabIndex = 208;
            this.lbl_Date.Text = "Date";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_Date
            // 
            this.dpick_Date.CustomFormat = "";
            this.dpick_Date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_Date.Location = new System.Drawing.Point(461, 55);
            this.dpick_Date.Name = "dpick_Date";
            this.dpick_Date.Size = new System.Drawing.Size(192, 22);
            this.dpick_Date.TabIndex = 207;
            // 
            // lbl_Component
            // 
            this.lbl_Component.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Component.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Component.ImageIndex = 0;
            this.lbl_Component.ImageList = this.img_Label;
            this.lbl_Component.Location = new System.Drawing.Point(360, 32);
            this.lbl_Component.Name = "lbl_Component";
            this.lbl_Component.Size = new System.Drawing.Size(100, 21);
            this.lbl_Component.TabIndex = 159;
            this.lbl_Component.Text = "Component";
            this.lbl_Component.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Component
            // 
            this.cmb_Component.AddItemCols = 0;
            this.cmb_Component.AddItemSeparator = ';';
            this.cmb_Component.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Component.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Component.Caption = "";
            this.cmb_Component.CaptionHeight = 17;
            this.cmb_Component.CaptionStyle = style33;
            this.cmb_Component.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Component.ColumnCaptionHeight = 18;
            this.cmb_Component.ColumnFooterHeight = 18;
            this.cmb_Component.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Component.ContentHeight = 17;
            this.cmb_Component.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Component.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Component.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Component.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Component.EditorHeight = 17;
            this.cmb_Component.EvenRowStyle = style34;
            this.cmb_Component.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Component.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Component.FooterStyle = style35;
            this.cmb_Component.GapHeight = 2;
            this.cmb_Component.HeadingStyle = style36;
            this.cmb_Component.HighLightRowStyle = style37;
            this.cmb_Component.ItemHeight = 15;
            this.cmb_Component.Location = new System.Drawing.Point(461, 32);
            this.cmb_Component.MatchEntryTimeout = ((long)(2000));
            this.cmb_Component.MaxDropDownItems = ((short)(5));
            this.cmb_Component.MaxLength = 32767;
            this.cmb_Component.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Component.Name = "cmb_Component";
            this.cmb_Component.OddRowStyle = style38;
            this.cmb_Component.PartialRightColumn = false;
            this.cmb_Component.PropBag = resources.GetString("cmb_Component.PropBag");
            this.cmb_Component.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Component.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Component.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Component.SelectedStyle = style39;
            this.cmb_Component.Size = new System.Drawing.Size(192, 21);
            this.cmb_Component.Style = style40;
            this.cmb_Component.TabIndex = 158;
            this.cmb_Component.Tag = "PK";
            // 
            // lbl_Spec
            // 
            this.lbl_Spec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Spec.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Spec.ImageIndex = 0;
            this.lbl_Spec.ImageList = this.img_Label;
            this.lbl_Spec.Location = new System.Drawing.Point(8, 55);
            this.lbl_Spec.Name = "lbl_Spec";
            this.lbl_Spec.Size = new System.Drawing.Size(100, 21);
            this.lbl_Spec.TabIndex = 157;
            this.lbl_Spec.Text = "Specification";
            this.lbl_Spec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(7, 33);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 155;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style41;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style42;
            this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style43;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style44;
            this.cmb_Factory.HighLightRowStyle = style45;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(108, 33);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style46;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style47;
            this.cmb_Factory.Size = new System.Drawing.Size(237, 21);
            this.cmb_Factory.Style = style48;
            this.cmb_Factory.TabIndex = 156;
            this.cmb_Factory.Tag = "PK";
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(572, 28);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(86, 54);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(645, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(20, 75);
            this.picb_TR.TabIndex = 21;
            this.picb_TR.TabStop = false;
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(192, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(466, 30);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // lbl_SubTitle1
            // 
            this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
            this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle1.Name = "lbl_SubTitle1";
            this.lbl_SubTitle1.Size = new System.Drawing.Size(198, 28);
            this.lbl_SubTitle1.TabIndex = 28;
            this.lbl_SubTitle1.Text = "      Common Spec.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(645, 71);
            this.picb_BR.Name = "picb_BR";
            this.picb_BR.Size = new System.Drawing.Size(13, 15);
            this.picb_BR.TabIndex = 23;
            this.picb_BR.TabStop = false;
            // 
            // picb_BM
            // 
            this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
            this.picb_BM.Location = new System.Drawing.Point(123, 70);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(522, 17);
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
            this.pictureBox6.Size = new System.Drawing.Size(514, 48);
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
            // Form_QC_SPEC
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(678, 528);
            this.Controls.Add(this.c1Sizer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_QC_SPEC";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Spec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Spec_Sheet1)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Spec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Component)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
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
                this.Text = "Nike Spec.";
                lbl_MainTitle.Text = "Nike Spec."; 
                ClassLib.ComFunction.SetLangDic(this);

				// 그리드 설정
				fgrid_Spec.Set_Spread_Comm("SQC_LAB_SPEC", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 

				#region 버튼 권한

				try
				{
                    //COM.OraDB btn_control = new COM.OraDB();
                    //DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
                    //tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
                    //tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
                    //tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
                    //btn_control = null;

				
					//Button 활성화
					// 버튼 설정
					tbtn_Delete.Enabled = false;
					tbtn_Conform.Enabled = false;
					tbtn_Print.Enabled = false;

				}
				catch
				{
				}

				#endregion

				Set_Init();
		
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
		public void Set_Init()
		{ 
			try
			{
				DataTable dt_list;

				// 공장코드
				dt_list = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

				//Component 
				dt_list =  ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxLabComponent);
				COM.ComCtl.Set_ComboList(dt_list, cmb_Component , 1, 2, false);
				cmb_Component.SelectedIndex = -1;

				//MCS 
//				dt_list =  Select_Mcs();
				dt_list = ClassLib.ComFunction.SELECT_SBC_MCS_LIST(COM.ComVar.This_Factory, txt_Spec.Text.ToString().Trim());
				COM.ComCtl.Set_ComboList(dt_list, cmb_Spec , 0, 1, false, 79, 141);
				cmb_Spec.SelectedIndex = -1;

				dt_list.Dispose();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_Init", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}



		/// <summary>
		/// CheckSearch : CheckSearch 사전 Check
		/// </summary>
		private bool CheckSearch()
		{

			try
			{
				if (cmb_Factory.SelectedIndex  == -1) 
				{
					ClassLib.ComFunction.User_Message("Factory Shoulb be selected..");
					return false; 
				}
				

				if (cmb_Component.SelectedIndex  == -1) 
				{
					ClassLib.ComFunction.User_Message("Component Shoulb be selected..");
					return false; 				
				}


				if (cmb_Spec.SelectedIndex  == -1) 
				{
					ClassLib.ComFunction.User_Message("Specification Shoulb be selected..");
					return false; 
				}

				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "CheckSearch", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false; 
			}	

		}

		
		/// <summary>
		/// Search_Component : 
		/// </summary>
		public void Search_Component()
		{ 
			try
			{
				
				if  (!CheckSearch()) return;

				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

				DataTable dt_ret;
				dt_ret = Select_SQC_Component();
				Display_Component(dt_ret, fgrid_Spec);
				dt_ret.Dispose();

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch,this);
				
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
		/// Search_Component : 
		/// </summary>
		public void Search_Spec()
		{ 
			try
			{
				
				if  (!CheckSearch()) return;

				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

				DataTable dt_ret;
				dt_ret = Select_SQC_Spec();
				Display_Grid(dt_ret, fgrid_Spec);
				dt_ret.Dispose();

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch,this);
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Spec", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



		/// <summary>
		/// Display_Grid : 조회
		/// </summary>
		/// <param name="arg_row">추가하고자 하는 Row</param>
		public  void Display_Component(DataTable arg_dt,COM.SSP arg_fgrid)
		{
 									
			try 
			{					
				arg_fgrid.Sheets[0].ClearRange(0,0,arg_fgrid.Sheets[0].Rows.Count,arg_fgrid.Sheets[0].Columns.Count,true);						
				arg_fgrid.Sheets[0].ClearRange(0,0,arg_fgrid.Sheets[0].Rows.Count,1,false);						
				arg_fgrid.Sheets[0].RowCount = arg_dt.Rows.Count ;				
									
				//string[,] arr = new string[arg_dt.Rows.Count,arg_dt.Columns.Count];
				//object[,] arr = new object[arg_dt.Rows.Count,arg_dt.Columns.Count];

				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{	
					//fgrid_Spec.Add_Row(img_Action); 

					for(int j = 0; j < arg_dt.Columns.Count; j++)
					{											
						fgrid_Spec.Sheets[0].Cells[i,j+1].Value  = arg_dt.Rows[i].ItemArray[j];

						if (j == (int)ClassLib.TBSQC_LAB_SPEC.IxMCS_NO -1 ) 
								fgrid_Spec.Sheets[0].Cells[i,j+1].Value = cmb_Spec.SelectedValue.ToString();

						if (j == (int)ClassLib.TBSQC_LAB_SPEC.IxMCS_YMD-1 ) 
								fgrid_Spec.Sheets[0].Cells[i,j+1].Value = dpick_Date.Text.ToString().Replace("-","");

					}		

					fgrid_Spec.Sheets[0].Cells[i,0].Tag = "I" ;					

					Image img =img_Action.Images[0];								
					Bitmap b = new Bitmap(img);								
					FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
					FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
					imgType.BackgroundImage = pic ;
					fgrid_Spec.Sheets[0].Cells[i,0].CellType = imgType ;

				}
				
				
				arg_fgrid.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
				arg_fgrid.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
			}			
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_Component",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
 
		}



		/// <summary>
		/// Save_Component : 
		/// </summary>
		private void Save_Spec()
		{  
			try
			{
			
				
				if(MyOraDB.Save_Spread("PKG_SQC_LAB_SPEC.SAVE_SQC_LAB_SPEC", fgrid_Spec,1) )
				{
					Search_Spec();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);

				}

						
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Spec", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}
 


		private void Set_Delete(int arg_Row)
		{
			fgrid_Spec.Sheets[0].Cells[arg_Row,0].Tag = "D" ;	

			Image img = img_Action .Images[1];								
			Bitmap b = new Bitmap(img);								
			FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
			FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
			imgType.BackgroundImage = pic ;
			fgrid_Spec.Sheets[0].Cells[arg_Row,0].CellType = imgType ;	

		}


		private void Set_Recovery(int arg_Row)
		{
			fgrid_Spec.Sheets[0].Cells[arg_Row,0].Tag = " " ;	  //I로 원상 복귀

			Image img = img_Action.Images[0];								
			Bitmap b = new Bitmap(img);								
			FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
			FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
			imgType.BackgroundImage = pic ;
			fgrid_Spec.Sheets[0].Cells[arg_Row,0].CellType = null ;	

		}


		private void Set_Insert(int arg_Row)
		{
			fgrid_Spec.Sheets[0].Cells[arg_Row,0].Tag = "I" ;	  //I로 원상 복귀

			Image img = img_Action.Images[0];								
			Bitmap b = new Bitmap(img);								
			FarPoint.Win.Picture pic = new FarPoint.Win.Picture(Image.FromHbitmap(b.GetHbitmap())) ;				
			FarPoint.Win.Spread.CellType.TextCellType imgType = new FarPoint.Win.Spread.CellType.TextCellType(); 				
			imgType.BackgroundImage = pic ;
			fgrid_Spec.Sheets[0].Cells[arg_Row,0].CellType = imgType ;	

		}


		#endregion

		#region 이벤트 처리

		
		#region 툴바 메뉴 이벤트 처리			
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				Search_Component();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Search_Spec();
		}

		
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Save_Spec(); 			
		}



		#endregion		

		#region 컨트롤 이벤트 처리

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{ 
			FarPoint.Win.Spread.Model.CellRange cr ;
			cr = fgrid_Spec.Sheets[0].GetSelection(0) ;			
			
			if (cr == null) { return ; }
			int	start_row = cr.Row ;		
			int end_row = cr.Row + cr.RowCount - 1;						

			for(int i = start_row; i <= end_row; i++)
				Set_Insert(i);

		
		}

		

		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			FarPoint.Win.Spread.Model.CellRange cr ;
			cr = fgrid_Spec.Sheets[0].GetSelection(0) ;			
			
			if (cr == null) { return ; }
			int	start_row = cr.Row ;		
			int end_row = cr.Row + cr.RowCount - 1;						

			for(int i = start_row; i <= end_row; i++)
				Set_Recovery(i);

			
		}



		private void txt_Spec_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//ClassLib.ComFunction.KeyEnter_Tab(e);

			if(e.KeyChar == (char)13)
			{
				//MCS 
				cmb_Spec.ClearItems();

				DataTable dt_list;

//				dt_list =  Select_Mcs();
				dt_list = ClassLib.ComFunction.SELECT_SBC_MCS_LIST(COM.ComVar.This_Factory, txt_Spec.Text.ToString().Trim());
				COM.ComCtl.Set_ComboList(dt_list, cmb_Spec , 0, 1, false, 100, 237);
				cmb_Spec.SelectedIndex = -1;

				dt_list.Dispose();
			}
		}

		private void cmb_Spec_TextChanged(object sender, System.EventArgs e)
		{
			txt_Spec.Text  = cmb_Spec.SelectedValue.ToString();

			Search_Spec();
		}


		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			FarPoint.Win.Spread.Model.CellRange cr ;
			cr = fgrid_Spec.Sheets[0].GetSelection(0) ;			
			
			if (cr == null) { return ; }
			int	start_row = cr.Row ;		
			int end_row = cr.Row + cr.RowCount - 1;						

			for(int i = start_row; i <= end_row; i++)
				Set_Delete( i);
	
		}


		private void fgrid_Spec_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
			fgrid_Spec .Update_Row(img_Action); 
		}


		private void fgrid_Spec_EditModeOff(object sender, System.EventArgs e)
		{
			ClassLib.ComFunction.Cell_AfterEdit(fgrid_Spec, (int)FlexBase.ClassLib.TBSBC_COMPONENT.IxCOMPONENT_NM); 
		}


		private void fgrid_Spec_Click(object sender, System.EventArgs e)
		{
			fgrid_Spec.ActiveSheet.ActiveRowIndex = fgrid_Spec.ActiveSheet.RowCount-1; 

		}


		private void cmb_Component_TextChanged(object sender, System.EventArgs e)
		{
			Search_Spec();
		}


		private void fgrid_Spec_EditModeOn(object sender, System.EventArgs e)
		{
			try
			{
				int ir = fgrid_Spec.ActiveSheet.ActiveRowIndex ;
				int ic = fgrid_Spec.ActiveSheet.ActiveColumnIndex ;

				fgrid_Spec.Buffer_CellData = (fgrid_Spec.ActiveSheet.Cells[ir,ic].Value == null) ? "" : fgrid_Spec.ActiveSheet.Cells[ir,ic].Value.ToString() ;
				
				string s = fgrid_Spec.ActiveSheet.Columns[ic].CellType.ToString();
				if(s == "CheckBoxCellType" || s == "SSPComboBoxCellType")
				{
					fgrid_Spec.Buffer_CellData  = "000";
					fgrid_Spec.Update_Row(img_Action);
				} 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Spec_EditModeOn", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		#endregion 


		#endregion 

		#region DB Connect

		/// <summary>
		/// Select_SQC_Spec : Spec 조회
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SQC_Component()
		{ 
			DataSet ds_ret;
  
			int iCnt  = 3;
			MyOraDB.ReDim_Parameter(iCnt); 
 
			MyOraDB.Process_Name = "PKG_SQC_LAB_SPEC.SELECT_SQC_LAB_COMPONENT";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LAB_COMP_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
		
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_Component.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = " ";

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}

		/// <summary>
		/// Select_SQC_Componet : Componet 조회
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SQC_Spec()
		{ 
		 	DataSet ds_ret;
  
			int iCnt  = 5;
			MyOraDB.ReDim_Parameter(iCnt); 
 
			MyOraDB.Process_Name = "PKG_SQC_LAB_SPEC.SELECT_SQC_LAB_SPEC";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LAB_COMP_CD";
			MyOraDB.Parameter_Name[2] = "ARG_MCS_NO";
			MyOraDB.Parameter_Name[3] = "ARG_MCS_YMD";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			 
		
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_Component.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = cmb_Spec.SelectedValue.ToString(); 
			MyOraDB.Parameter_Values[3] = dpick_Date.Text.ToString().Replace("-","");
			MyOraDB.Parameter_Values[4] = " ";

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}
 

		
//		/// <summary>
//		/// Select_Mcs : Mcs 조회
//		/// </summary>
//		/// <returns></returns>
//		private DataTable Select_Mcs()
//		{ 
//			DataSet ds_ret;
//  
//			int iCnt  = 3;
//			MyOraDB.ReDim_Parameter(iCnt); 
// 
//			MyOraDB.Process_Name = "PKG_SQC_LAB_SPEC.SELECT_MCS_CODE";
//  
//			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
//			MyOraDB.Parameter_Name[1] = "ARG_MCS_NAME";;
//			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
//
//			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
//			 
//		
//			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
//			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_Spec, " ");
//			MyOraDB.Parameter_Values[2] = " ";
//
//		
//			MyOraDB.Add_Select_Parameter(true); 
//			ds_ret = MyOraDB.Exe_Select_Procedure();
//
//			if(ds_ret == null) return null; 
//			return ds_ret.Tables[MyOraDB.Process_Name]; 
//		} 		
		#endregion																								



	}
}

