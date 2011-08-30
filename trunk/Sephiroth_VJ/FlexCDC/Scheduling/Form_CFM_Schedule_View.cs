using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.OracleClient;


namespace FlexCDC.Scheduling
{
	public class Form_CFM_Schedule_View : COM.APSWinForm.Form_Top
	{
		#region 컨트롤정의 및 리소스 정의 
		public System.Windows.Forms.Panel pnl_Top;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		private int _RowFixed;
		private COM.OraDB OraDB = new COM.OraDB();
		private System.Windows.Forms.Label lblFactory;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Label lblDPO;
		public COM.FSP grdCFM;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblSeason;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblDeveloper;
		private System.Windows.Forms.Label lblStyle;
		public System.Windows.Forms.Label lblSubTitle;
		private C1.Win.C1List.C1Combo cmbCategory;
		private C1.Win.C1List.C1Combo cmbFactory;
		private C1.Win.C1List.C1Combo cmbDPO;
		private C1.Win.C1List.C1Combo cmbDeveloper;
		private C1.Win.C1List.C1Combo cmbSeason;
		public System.Windows.Forms.PictureBox pictureBox18;
		public System.Windows.Forms.PictureBox pictureBox19;
		public System.Windows.Forms.PictureBox pictureBox20;
		public System.Windows.Forms.PictureBox pictureBox21;
		public System.Windows.Forms.PictureBox pictureBox22;
		public System.Windows.Forms.PictureBox pictureBox23;
		public System.Windows.Forms.PictureBox pictureBox24;
		public System.Windows.Forms.PictureBox pictureBox25;
		public System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.TextBox txtStyle;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ContextMenu ctmMenu;
		private System.Windows.Forms.MenuItem mntCFMHistory;
		private System.Windows.Forms.CheckBox chkComp;
		private System.Windows.Forms.CheckBox chkShip;
		private System.Windows.Forms.Label lblColor1;
		private System.Windows.Forms.Label lblColor3;
		private System.Windows.Forms.Label lblColor2;
		private System.Windows.Forms.Label lblColor4;
		private System.Windows.Forms.Label lblColor5;
		private System.ComponentModel.IContainer components = null;

		public Form_CFM_Schedule_View()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CFM_Schedule_View));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
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
            this.grdCFM = new COM.FSP();
            this.ctmMenu = new System.Windows.Forms.ContextMenu();
            this.mntCFMHistory = new System.Windows.Forms.MenuItem();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lblDPO = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblFactory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.lblSeason = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkComp = new System.Windows.Forms.CheckBox();
            this.chkShip = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.cmbSeason = new C1.Win.C1List.C1Combo();
            this.cmbDeveloper = new C1.Win.C1List.C1Combo();
            this.cmbDPO = new C1.Win.C1List.C1Combo();
            this.cmbFactory = new C1.Win.C1List.C1Combo();
            this.cmbCategory = new C1.Win.C1List.C1Combo();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.lblColor3 = new System.Windows.Forms.Label();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.lblColor4 = new System.Windows.Forms.Label();
            this.lblColor5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCFM)).BeginInit();
            this.pnl_Top.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSeason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDeveloper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            this.img_Action.Images.SetKeyName(3, "");
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
            this.c1ToolBar1.Location = new System.Drawing.Point(702, 3);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // stbar
            // 
            this.stbar.Size = new System.Drawing.Size(1028, 22);
            // 
            // c1CommandLink7
            // 
            this.c1CommandLink7.Text = "Excel";
            this.c1CommandLink7.ToolTipText = "Excel";
            // 
            // grdCFM
            // 
            this.grdCFM.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.grdCFM.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.grdCFM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCFM.AutoResize = false;
            this.grdCFM.BackColor = System.Drawing.SystemColors.Window;
            this.grdCFM.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdCFM.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.grdCFM.ContextMenu = this.ctmMenu;
            this.grdCFM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grdCFM.Location = new System.Drawing.Point(8, 184);
            this.grdCFM.Name = "grdCFM";
            this.grdCFM.Rows.Fixed = 0;
            this.grdCFM.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.grdCFM.Size = new System.Drawing.Size(1012, 456);
            this.grdCFM.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("grdCFM.Styles"));
            this.grdCFM.TabIndex = 131;
            // 
            // ctmMenu
            // 
            this.ctmMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mntCFMHistory});
            // 
            // mntCFMHistory
            // 
            this.mntCFMHistory.Index = 0;
            this.mntCFMHistory.Text = "CFM History";
            this.mntCFMHistory.Click += new System.EventHandler(this.mntCFMHistory_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.lblDPO);
            this.pnl_Top.Controls.Add(this.lblCategory);
            this.pnl_Top.Controls.Add(this.lblFactory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 80);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1028, 104);
            this.pnl_Top.TabIndex = 132;
            // 
            // lblDPO
            // 
            this.lblDPO.ImageIndex = 0;
            this.lblDPO.ImageList = this.img_Label;
            this.lblDPO.Location = new System.Drawing.Point(224, 36);
            this.lblDPO.Name = "lblDPO";
            this.lblDPO.Size = new System.Drawing.Size(100, 21);
            this.lblDPO.TabIndex = 350;
            this.lblDPO.Text = "DPO ID";
            this.lblDPO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategory
            // 
            this.lblCategory.ImageIndex = 0;
            this.lblCategory.ImageList = this.img_Label;
            this.lblCategory.Location = new System.Drawing.Point(16, 64);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 21);
            this.lblCategory.TabIndex = 348;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFactory
            // 
            this.lblFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactory.ImageIndex = 1;
            this.lblFactory.ImageList = this.img_Label;
            this.lblFactory.Location = new System.Drawing.Point(16, 36);
            this.lblFactory.Name = "lblFactory";
            this.lblFactory.Size = new System.Drawing.Size(100, 21);
            this.lblFactory.TabIndex = 271;
            this.lblFactory.Tag = "0";
            this.lblFactory.Text = "Factory";
            this.lblFactory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.lblSeason);
            this.pnl_SearchImage.Controls.Add(this.panel1);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1012, 96);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // lblSeason
            // 
            this.lblSeason.BackColor = System.Drawing.SystemColors.Window;
            this.lblSeason.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeason.ImageIndex = 0;
            this.lblSeason.ImageList = this.img_Label;
            this.lblSeason.Location = new System.Drawing.Point(424, 36);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(100, 21);
            this.lblSeason.TabIndex = 350;
            this.lblSeason.Tag = "1";
            this.lblSeason.Text = "Season";
            this.lblSeason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pictureBox12);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 96);
            this.panel1.TabIndex = 349;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(989, 80);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(16, 16);
            this.pictureBox12.TabIndex = 351;
            this.pictureBox12.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 96);
            this.panel2.TabIndex = 350;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.chkComp);
            this.panel3.Controls.Add(this.chkShip);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtStyle);
            this.panel3.Controls.Add(this.cmbSeason);
            this.panel3.Controls.Add(this.cmbDeveloper);
            this.panel3.Controls.Add(this.cmbDPO);
            this.panel3.Controls.Add(this.cmbFactory);
            this.panel3.Controls.Add(this.cmbCategory);
            this.panel3.Controls.Add(this.lblStyle);
            this.panel3.Controls.Add(this.lblDeveloper);
            this.panel3.Controls.Add(this.pictureBox18);
            this.panel3.Controls.Add(this.pictureBox19);
            this.panel3.Controls.Add(this.pictureBox20);
            this.panel3.Controls.Add(this.lblSubTitle);
            this.panel3.Controls.Add(this.pictureBox21);
            this.panel3.Controls.Add(this.pictureBox22);
            this.panel3.Controls.Add(this.pictureBox23);
            this.panel3.Controls.Add(this.pictureBox24);
            this.panel3.Controls.Add(this.pictureBox25);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1012, 96);
            this.panel3.TabIndex = 349;
            // 
            // chkComp
            // 
            this.chkComp.Location = new System.Drawing.Point(784, 37);
            this.chkComp.Name = "chkComp";
            this.chkComp.Size = new System.Drawing.Size(128, 16);
            this.chkComp.TabIndex = 369;
            this.chkComp.Text = "Show CFM Shoe";
            // 
            // chkShip
            // 
            this.chkShip.Checked = true;
            this.chkShip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShip.Location = new System.Drawing.Point(600, 38);
            this.chkShip.Name = "chkShip";
            this.chkShip.Size = new System.Drawing.Size(184, 16);
            this.chkShip.TabIndex = 368;
            this.chkShip.Text = "Show list after Ship Date";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(908, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 24);
            this.btnClose.TabIndex = 366;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(820, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 24);
            this.btnSearch.TabIndex = 365;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStyle
            // 
            this.txtStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStyle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStyle.Location = new System.Drawing.Point(528, 64);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(208, 22);
            this.txtStyle.TabIndex = 361;
            // 
            // cmbSeason
            // 
            this.cmbSeason.AddItemCols = 0;
            this.cmbSeason.AddItemSeparator = ';';
            this.cmbSeason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmbSeason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbSeason.Caption = "";
            this.cmbSeason.CaptionHeight = 17;
            this.cmbSeason.CaptionStyle = style1;
            this.cmbSeason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbSeason.ColumnCaptionHeight = 18;
            this.cmbSeason.ColumnFooterHeight = 18;
            this.cmbSeason.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmbSeason.ContentHeight = 17;
            this.cmbSeason.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbSeason.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbSeason.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeason.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbSeason.EditorHeight = 17;
            this.cmbSeason.EvenRowStyle = style2;
            this.cmbSeason.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeason.FooterStyle = style3;
            this.cmbSeason.GapHeight = 2;
            this.cmbSeason.HeadingStyle = style4;
            this.cmbSeason.HighLightRowStyle = style5;
            this.cmbSeason.ItemHeight = 15;
            this.cmbSeason.Location = new System.Drawing.Point(528, 36);
            this.cmbSeason.MatchEntryTimeout = ((long)(2000));
            this.cmbSeason.MaxDropDownItems = ((short)(5));
            this.cmbSeason.MaxLength = 32767;
            this.cmbSeason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbSeason.Name = "cmbSeason";
            this.cmbSeason.OddRowStyle = style6;
            this.cmbSeason.PartialRightColumn = false;
            this.cmbSeason.PropBag = resources.GetString("cmbSeason.PropBag");
            this.cmbSeason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbSeason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbSeason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbSeason.SelectedStyle = style7;
            this.cmbSeason.Size = new System.Drawing.Size(64, 21);
            this.cmbSeason.Style = style8;
            this.cmbSeason.TabIndex = 357;
            // 
            // cmbDeveloper
            // 
            this.cmbDeveloper.AddItemCols = 0;
            this.cmbDeveloper.AddItemSeparator = ';';
            this.cmbDeveloper.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmbDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbDeveloper.Caption = "";
            this.cmbDeveloper.CaptionHeight = 17;
            this.cmbDeveloper.CaptionStyle = style9;
            this.cmbDeveloper.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbDeveloper.ColumnCaptionHeight = 18;
            this.cmbDeveloper.ColumnFooterHeight = 18;
            this.cmbDeveloper.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmbDeveloper.ContentHeight = 17;
            this.cmbDeveloper.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbDeveloper.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbDeveloper.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeveloper.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDeveloper.EditorHeight = 17;
            this.cmbDeveloper.EvenRowStyle = style10;
            this.cmbDeveloper.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeveloper.FooterStyle = style11;
            this.cmbDeveloper.GapHeight = 2;
            this.cmbDeveloper.HeadingStyle = style12;
            this.cmbDeveloper.HighLightRowStyle = style13;
            this.cmbDeveloper.ItemHeight = 15;
            this.cmbDeveloper.Location = new System.Drawing.Point(320, 64);
            this.cmbDeveloper.MatchEntryTimeout = ((long)(2000));
            this.cmbDeveloper.MaxDropDownItems = ((short)(5));
            this.cmbDeveloper.MaxLength = 32767;
            this.cmbDeveloper.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbDeveloper.Name = "cmbDeveloper";
            this.cmbDeveloper.OddRowStyle = style14;
            this.cmbDeveloper.PartialRightColumn = false;
            this.cmbDeveloper.PropBag = resources.GetString("cmbDeveloper.PropBag");
            this.cmbDeveloper.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbDeveloper.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbDeveloper.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbDeveloper.SelectedStyle = style15;
            this.cmbDeveloper.Size = new System.Drawing.Size(100, 21);
            this.cmbDeveloper.Style = style16;
            this.cmbDeveloper.TabIndex = 356;
            // 
            // cmbDPO
            // 
            this.cmbDPO.AddItemCols = 0;
            this.cmbDPO.AddItemSeparator = ';';
            this.cmbDPO.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmbDPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbDPO.Caption = "";
            this.cmbDPO.CaptionHeight = 17;
            this.cmbDPO.CaptionStyle = style17;
            this.cmbDPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbDPO.ColumnCaptionHeight = 18;
            this.cmbDPO.ColumnFooterHeight = 18;
            this.cmbDPO.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmbDPO.ContentHeight = 17;
            this.cmbDPO.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbDPO.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbDPO.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDPO.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDPO.EditorHeight = 17;
            this.cmbDPO.EvenRowStyle = style18;
            this.cmbDPO.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDPO.FooterStyle = style19;
            this.cmbDPO.GapHeight = 2;
            this.cmbDPO.HeadingStyle = style20;
            this.cmbDPO.HighLightRowStyle = style21;
            this.cmbDPO.ItemHeight = 15;
            this.cmbDPO.Location = new System.Drawing.Point(320, 36);
            this.cmbDPO.MatchEntryTimeout = ((long)(2000));
            this.cmbDPO.MaxDropDownItems = ((short)(5));
            this.cmbDPO.MaxLength = 32767;
            this.cmbDPO.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbDPO.Name = "cmbDPO";
            this.cmbDPO.OddRowStyle = style22;
            this.cmbDPO.PartialRightColumn = false;
            this.cmbDPO.PropBag = resources.GetString("cmbDPO.PropBag");
            this.cmbDPO.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbDPO.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbDPO.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbDPO.SelectedStyle = style23;
            this.cmbDPO.Size = new System.Drawing.Size(100, 21);
            this.cmbDPO.Style = style24;
            this.cmbDPO.TabIndex = 355;
            // 
            // cmbFactory
            // 
            this.cmbFactory.AddItemCols = 0;
            this.cmbFactory.AddItemSeparator = ';';
            this.cmbFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmbFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbFactory.Caption = "";
            this.cmbFactory.CaptionHeight = 17;
            this.cmbFactory.CaptionStyle = style25;
            this.cmbFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbFactory.ColumnCaptionHeight = 18;
            this.cmbFactory.ColumnFooterHeight = 18;
            this.cmbFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmbFactory.ContentHeight = 17;
            this.cmbFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbFactory.EditorHeight = 17;
            this.cmbFactory.EvenRowStyle = style26;
            this.cmbFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFactory.FooterStyle = style27;
            this.cmbFactory.GapHeight = 2;
            this.cmbFactory.HeadingStyle = style28;
            this.cmbFactory.HighLightRowStyle = style29;
            this.cmbFactory.ItemHeight = 15;
            this.cmbFactory.Location = new System.Drawing.Point(112, 36);
            this.cmbFactory.MatchEntryTimeout = ((long)(2000));
            this.cmbFactory.MaxDropDownItems = ((short)(5));
            this.cmbFactory.MaxLength = 32767;
            this.cmbFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbFactory.Name = "cmbFactory";
            this.cmbFactory.OddRowStyle = style30;
            this.cmbFactory.PartialRightColumn = false;
            this.cmbFactory.PropBag = resources.GetString("cmbFactory.PropBag");
            this.cmbFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbFactory.SelectedStyle = style31;
            this.cmbFactory.Size = new System.Drawing.Size(100, 21);
            this.cmbFactory.Style = style32;
            this.cmbFactory.TabIndex = 354;
            // 
            // cmbCategory
            // 
            this.cmbCategory.AddItemCols = 0;
            this.cmbCategory.AddItemSeparator = ';';
            this.cmbCategory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbCategory.Caption = "";
            this.cmbCategory.CaptionHeight = 17;
            this.cmbCategory.CaptionStyle = style33;
            this.cmbCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbCategory.ColumnCaptionHeight = 18;
            this.cmbCategory.ColumnFooterHeight = 18;
            this.cmbCategory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmbCategory.ContentHeight = 17;
            this.cmbCategory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbCategory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbCategory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCategory.EditorHeight = 17;
            this.cmbCategory.EvenRowStyle = style34;
            this.cmbCategory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FooterStyle = style35;
            this.cmbCategory.GapHeight = 2;
            this.cmbCategory.HeadingStyle = style36;
            this.cmbCategory.HighLightRowStyle = style37;
            this.cmbCategory.ItemHeight = 15;
            this.cmbCategory.Location = new System.Drawing.Point(112, 64);
            this.cmbCategory.MatchEntryTimeout = ((long)(2000));
            this.cmbCategory.MaxDropDownItems = ((short)(5));
            this.cmbCategory.MaxLength = 32767;
            this.cmbCategory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.OddRowStyle = style38;
            this.cmbCategory.PartialRightColumn = false;
            this.cmbCategory.PropBag = resources.GetString("cmbCategory.PropBag");
            this.cmbCategory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbCategory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbCategory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbCategory.SelectedStyle = style39;
            this.cmbCategory.Size = new System.Drawing.Size(100, 21);
            this.cmbCategory.Style = style40;
            this.cmbCategory.TabIndex = 353;
            // 
            // lblStyle
            // 
            this.lblStyle.ImageIndex = 0;
            this.lblStyle.ImageList = this.img_Label;
            this.lblStyle.Location = new System.Drawing.Point(424, 64);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(100, 21);
            this.lblStyle.TabIndex = 350;
            this.lblStyle.Text = "Style";
            this.lblStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.ImageIndex = 0;
            this.lblDeveloper.ImageList = this.img_Label;
            this.lblDeveloper.Location = new System.Drawing.Point(216, 64);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(100, 21);
            this.lblDeveloper.TabIndex = 304;
            this.lblDeveloper.Text = "CDC Dev";
            this.lblDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox18.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(988, 24);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(24, 623);
            this.pictureBox18.TabIndex = 26;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox19.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox19.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(988, 0);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(16, 32);
            this.pictureBox19.TabIndex = 21;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox20.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox20.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(232, 0);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(764, 24);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lblSubTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblSubTitle.Image = ((System.Drawing.Image)(resources.GetObject("lblSubTitle.Image")));
            this.lblSubTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(231, 30);
            this.lblSubTitle.TabIndex = 28;
            this.lblSubTitle.Text = "      CFM Schedule Information";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox21.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(1012, 651);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(16, 16);
            this.pictureBox21.TabIndex = 23;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox22.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox22.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(144, 79);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(1028, 18);
            this.pictureBox22.TabIndex = 24;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox23.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox23.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(0, 80);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(168, 20);
            this.pictureBox23.TabIndex = 22;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox24.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox24.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(0, 24);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(168, 633);
            this.pictureBox24.TabIndex = 25;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox25.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox25.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
            this.pictureBox25.Location = new System.Drawing.Point(152, 24);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(1028, 626);
            this.pictureBox25.TabIndex = 27;
            this.pictureBox25.TabStop = false;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(995, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 53);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // lblColor1
            // 
            this.lblColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor1.AutoSize = true;
            this.lblColor1.BackColor = System.Drawing.Color.LightBlue;
            this.lblColor1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor1.Location = new System.Drawing.Point(252, 48);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(85, 14);
            this.lblColor1.TabIndex = 379;
            this.lblColor1.Text = "New Style Color";
            // 
            // lblColor3
            // 
            this.lblColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor3.AutoSize = true;
            this.lblColor3.BackColor = System.Drawing.Color.Gray;
            this.lblColor3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor3.Location = new System.Drawing.Point(428, 48);
            this.lblColor3.Name = "lblColor3";
            this.lblColor3.Size = new System.Drawing.Size(85, 14);
            this.lblColor3.TabIndex = 378;
            this.lblColor3.Text = "Drop Style Color";
            // 
            // lblColor2
            // 
            this.lblColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor2.AutoSize = true;
            this.lblColor2.BackColor = System.Drawing.Color.LightGreen;
            this.lblColor2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor2.Location = new System.Drawing.Point(340, 48);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(83, 14);
            this.lblColor2.TabIndex = 377;
            this.lblColor2.Text = "CFM Style Color";
            // 
            // lblColor4
            // 
            this.lblColor4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor4.AutoSize = true;
            this.lblColor4.BackColor = System.Drawing.Color.Yellow;
            this.lblColor4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor4.Location = new System.Drawing.Point(516, 48);
            this.lblColor4.Name = "lblColor4";
            this.lblColor4.Size = new System.Drawing.Size(122, 14);
            this.lblColor4.TabIndex = 376;
            this.lblColor4.Text = "Change Ship/Assy Date";
            // 
            // lblColor5
            // 
            this.lblColor5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor5.AutoSize = true;
            this.lblColor5.BackColor = System.Drawing.Color.Red;
            this.lblColor5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor5.Location = new System.Drawing.Point(644, 48);
            this.lblColor5.Name = "lblColor5";
            this.lblColor5.Size = new System.Drawing.Size(59, 14);
            this.lblColor5.TabIndex = 375;
            this.lblColor5.Text = "Delay Date";
            // 
            // Form_CFM_Schedule_View
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1028, 666);
            this.Controls.Add(this.lblColor1);
            this.Controls.Add(this.lblColor3);
            this.Controls.Add(this.lblColor2);
            this.Controls.Add(this.lblColor4);
            this.Controls.Add(this.lblColor5);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.grdCFM);
            this.Name = "Form_CFM_Schedule_View";
            this.Text = "CFM Shoe Schedule Management";
            this.Load += new System.EventHandler(this.Form_CFM_Schedule_View_Load);
            this.Controls.SetChildIndex(this.grdCFM, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lblColor5, 0);
            this.Controls.SetChildIndex(this.lblColor4, 0);
            this.Controls.SetChildIndex(this.lblColor2, 0);
            this.Controls.SetChildIndex(this.lblColor3, 0);
            this.Controls.SetChildIndex(this.lblColor1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCFM)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSeason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDeveloper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region 공통메쏘드

		private void Init_Form()
		{
			this.Text = "CFM Shoe Schedule List";
			this.lbl_MainTitle.Text = "CFM Shoe Schedule List";
			ClassLib.ComFunction.SetLangDic(this); 

			tbtn_New.Enabled     = false;
			tbtn_Search.Enabled  = false;
			tbtn_Save.Enabled    = false;
			tbtn_Append.Enabled  = false;
			tbtn_Insert.Enabled  = false;
			tbtn_Delete.Enabled  = false;
			tbtn_Color.Enabled   = false;
			tbtn_Print.Enabled   = false;
			//tbtn_Confirm.Enabled = false;
			tbtn_Create.Enabled  = false;

			//Factory Code ComboBox Link - Common Code Table
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_Factory_List(dt_ret, cmbFactory, 0, 1, true, COM.ComVar.ComboList_Visible.Code);
			cmbFactory.SelectedValue = 0;
			
			//CDC DPO ComboBox List
			dt_ret = Select_Sdc_CFM_Dpo();
			COM.ComCtl.Set_ComboList(dt_ret, cmbDPO, 0, 0,  true, COM.ComVar.ComboList_Visible.Name);
			cmbDPO.SelectedIndex = 0;

			//Season Code ComboBox List
			dt_ret = Select_Sdc_CFM_Season();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmbSeason, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
			cmbSeason.SelectedIndex = 0;

			//Category Code ComboBox Link - Common Code Table(COM_Code = 'MD02')
			dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SXB03");
			COM.ComCtl.Set_ComboList(dt_ret, cmbCategory, 1, 2,  true, COM.ComVar.ComboList_Visible.Code_Name);
			cmbCategory.SelectedIndex = 0;

			//CDC Developer ComboBox List
			dt_ret = Select_Sdc_CFM_Dev();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmbDeveloper, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
			cmbDeveloper.SelectedIndex = 0;
			
			//Set Grid grdCFM Head Information
			grdCFM.Set_Grid("SDC_CFM_SCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			grdCFM.Set_Action_Image(img_Action);
			_RowFixed = grdCFM.Rows.Fixed;
			grdCFM.AutoSizeCols();
		}

		#endregion

		#region DB컨넥트

		/// <summary>
		/// SDC_PJ_TAIL : FACTORY = 'DS' -> SEASON
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Sdc_CFM_Season()
		{
			string Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_SEASON";

			OraDB.ReDim_Parameter(1);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		/// <summary>
		/// SDC_PJ_TAIL : CDC Developer ComboBox
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Sdc_CFM_Dev()
		{
			string Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_DEV";

			OraDB.ReDim_Parameter(1);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		/// <summary>
		/// SDC_PJ_TAIL : CDC DPO ID ComboBox
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Sdc_CFM_Dpo()
		{
			string Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_DPO";

			OraDB.ReDim_Parameter(1);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private DataTable Select_Sdc_CFM_SCH()
		{
			string Proc_Name = null;

			Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_SCH";

			OraDB.ReDim_Parameter(9);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_DPO_ID";
			OraDB.Parameter_Name[2] = "ARG_SEASON";
			OraDB.Parameter_Name[3] = "ARG_CATEGORY";
			OraDB.Parameter_Name[4] = "ARG_DEVELOPER";
			OraDB.Parameter_Name[5] = "ARG_STYLE";
			OraDB.Parameter_Name[6] = "ARG_SHIP_CHK";
			OraDB.Parameter_Name[7] = "ARG_COMP_CHK";
			OraDB.Parameter_Name[8] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[8] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cmbFactory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = cmbDPO.SelectedValue.ToString();
			OraDB.Parameter_Values[2] = cmbSeason.SelectedValue.ToString();
			OraDB.Parameter_Values[3] = cmbCategory.SelectedValue.ToString();
			OraDB.Parameter_Values[4] = cmbDeveloper.SelectedValue.ToString();
			OraDB.Parameter_Values[5] = txtStyle.Text.ToString().Trim();
			OraDB.Parameter_Values[6] = (chkShip.Checked == false) ? DateTime.Now.ToString("yyyyMMdd") : " ";
			OraDB.Parameter_Values[7] = chkComp.Checked.ToString();
			OraDB.Parameter_Values[8] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure(); 

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}
		
		#endregion 

		#region 이벤트처리

		#region 버튼 이벤트

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Show_grdCFM_Data();
		}


        #endregion 

		#region 기타 이벤트


		private void Show_grdCFM_Data()
		{
			this.Cursor = Cursors.WaitCursor;

			grdCFM.Rows.Count = _RowFixed;
			
			DataTable vDT = null;
			try
			{
				vDT = Select_Sdc_CFM_SCH();

				int dt_rows = vDT.Rows.Count;
				int dt_cols = vDT.Columns.Count;

				DateTime vSBDate;
				DateTime vSBDDD;
				string   vOldShip;
				string   vOldAssy;
				int iRow;

				for(int i = 0; i < dt_rows; i++)
				{
					grdCFM.AddItem(vDT.Rows[i].ItemArray, grdCFM.Rows.Count, 1);
					grdCFM[i+grdCFM.Rows.Fixed, 0] = "";

					//Setting SpecDate  BackColor (Spec Date)  > (CFM DDD)   = Red <- (Assy Date Before -17 day : Green, After -17 : Red)
					//Setting SBookDate BackColor (SBook Date) > (SBook DDD) = Red <- (Ship Date Before -14 day : Green, After -14 : Red)
					//                                                                (Assy Date Defore -31 day : Green, After -31 : Red)
					//Setting CFMDate   BackColor (CFM Date)   > (CFM DDD)   = Red <- (Assy Date Before -17 day : Green, After -17 : Red)
					//(11):Spec Date, (13):SBook DDD, (14):SBook Date, (16):CFMShoe DDD, (17):CFMShoe Date, (19):Assy Date1

					iRow = i + _RowFixed;   //Current Row

					//Setting SBook Color
					if (grdCFM[iRow,13] != null && grdCFM[iRow, 14] != null)
					{
						vSBDate = Convert.ToDateTime(grdCFM[iRow,14].ToString());
						vSBDDD  = Convert.ToDateTime(grdCFM[iRow,13].ToString());

						if (vSBDate >= vSBDDD)
						{
							CellRange cr1 = grdCFM.GetCellRange(iRow, 13, iRow, 15);
							cr1.StyleNew.BackColor = Color.Red;
						}
					}

					//Ship_Date 날짜 다를 경우 Color: 
					if (grdCFM[iRow, 2] != null && vDT.Rows[i].ItemArray[24].ToString() != "null")
					{
						vOldShip = grdCFM[iRow, 2].ToString().Substring(0,4) + grdCFM[iRow, 2].ToString().Substring(5,2) + grdCFM[iRow, 2].ToString().Substring(8,2);

						if (vOldShip != vDT.Rows[i].ItemArray[24].ToString())
						{
							CellRange cr1 = grdCFM.GetCellRange(iRow, 2);
							cr1.StyleNew.BackColor = Color.Yellow;
						}
					}

					//Assy_Date 날짜 다를 경우 Color
					if (grdCFM[iRow, 19] != null && vDT.Rows[i].ItemArray[25].ToString() != "null")
					{
						vOldAssy = grdCFM[iRow, 19].ToString().Substring(0,4) + grdCFM[iRow, 19].ToString().Substring(5,2) + grdCFM[iRow, 19].ToString().Substring(8,2);

						if (vOldAssy != vDT.Rows[i].ItemArray[25].ToString())
						{
							CellRange cr1 = grdCFM.GetCellRange(iRow, 19);
							cr1.StyleNew.BackColor = Color.Yellow;
						}
					}

					//Set Row Color
					if (grdCFM[iRow, 23].ToString() == "New")
					{
						//오늘 날짜 - 7일에 vDT.Rows[i].ItemArray[24].ToString()의 날짜보다 크면 "new" Color변경.
						CellRange cr1 = grdCFM.GetCellRange(iRow, 1, iRow, 23);
						cr1.StyleNew.BackColor = Color.LightSkyBlue;
					}
					if (grdCFM[iRow, 23].ToString() == "Finish")
					{
						CellRange cr1 = grdCFM.GetCellRange(iRow, 1, iRow, 23);
						cr1.StyleNew.BackColor = Color.LightGreen;
					}
					if (grdCFM[iRow, 23].ToString() == "Drop")
					{
						CellRange cr1 = grdCFM.GetCellRange(iRow, 1, iRow, 23);
						cr1.StyleNew.BackColor = Color.Gray;
					}
				}

				for (int i = 1; i < dt_cols; i++)
				{
					grdCFM.Cols[i].AllowEditing  = false;
				}
				grdCFM.AutoSizeCols();
			}
			finally
			{
				if (vDT != null)
					vDT.Dispose();
			}

			this.Cursor = Cursors.Default;
		}


		#endregion 

		#endregion 

		private void Form_CFM_Schedule_View_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void grdCFM_Click(object sender, System.EventArgs e)
		{
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			Show_grdCFM_Data();
		}

		private void mntCFMHistory_Click(object sender, System.EventArgs e)
		{
			// grdCFM DATA정의CFM History ShowDialog Column
			// (2) :Ship Date,  (8) :Category CD,   (10):Developer,     (11):Spec Date,
			// (12):Spec CFM,   (14):SBook Date,    (15):SBook CFM,     (17):CFMShoe Date,
			// (18):CFMShoe CFM,(19):Assembly Date1,(20):Assembly Date2,(21):CFM Remark,   (22):Factory CFM Remark
			if (grdCFM.Selection.c1 == 2  || grdCFM.Selection.c1 == 8  || grdCFM.Selection.c1 == 10 || grdCFM.Selection.c1 == 11 || 
				grdCFM.Selection.c1 == 12 || grdCFM.Selection.c1 == 14 || grdCFM.Selection.c1 == 15 || grdCFM.Selection.c1 == 17 || 
				grdCFM.Selection.c1 == 18 || grdCFM.Selection.c1 == 19 || grdCFM.Selection.c1 == 20 || grdCFM.Selection.c1 == 21 || 
				grdCFM.Selection.c1 == 22 )
			{
				//Factory, DPO, StyleNo, Model, Gender, Category, Qty, Developer, Item
				string vFactory = grdCFM[grdCFM.Row,1].ToString();
				string vDPO     = grdCFM[grdCFM.Row,4].ToString();
				string vStyleNo = grdCFM[grdCFM.Row,5].ToString();
				string vModel   = grdCFM[grdCFM.Row,6].ToString();
				string vGender  = grdCFM[grdCFM.Row,7].ToString();
				string vCate    = grdCFM[grdCFM.Row,8].ToString();
				string vQty     = grdCFM[grdCFM.Row,9].ToString();
				string vDev     = grdCFM[grdCFM.Row,10].ToString();
				string vItem    = grdCFM.Selection.c1.ToString();

                Scheduling.Pop_CFM_History CFM_History = new FlexCDC.Scheduling.Pop_CFM_History(vFactory, vDPO, vStyleNo, vModel, vGender, vCate, vQty, vDev, vItem);
				CFM_History.ShowDialog();
				return;
			}
			else
			{
				MessageBox.Show("This column is not history.","Message");
				return;
			}

		}

	}
}

