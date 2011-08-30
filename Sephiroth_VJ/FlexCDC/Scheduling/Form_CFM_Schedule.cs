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
	public class Form_CFM_Schedule : COM.APSWinForm.Form_Top
	{
		#region 컨트롤정의 및 리소스 정의 
		public System.Windows.Forms.Panel pnl_Top;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		private System.Windows.Forms.Label lblFactory;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Label lblDPO;
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
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnSelStyle;
		private System.Windows.Forms.Button btn_NewCFM;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenu ctmMenu;
		private System.Windows.Forms.MenuItem mntCFMHistory;
		private System.Windows.Forms.CheckBox chkShip;
		private System.Windows.Forms.CheckBox chkComp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAssyD1;
		private System.Windows.Forms.TextBox txtAssyD2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblColor5;
		private System.Windows.Forms.Label lblColor4;
		private System.Windows.Forms.Label lblColor2;
		private System.Windows.Forms.Label lblColor3;
		private System.Windows.Forms.Label lblColor1;

		private COM.OraDB OraDB = new COM.OraDB();
		public COM.FSP grdCFM;
		private int    _RowFixed;
		private string vBeforeVal = "";
		private bool   vQueryOK   = false;   //Click yes or no the Search Button -> Refresh the grid after New Style or Select Style.

		public Form_CFM_Schedule()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CFM_Schedule));
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAssyD2 = new System.Windows.Forms.TextBox();
            this.txtAssyD1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkComp = new System.Windows.Forms.CheckBox();
            this.chkShip = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.btnSelStyle = new System.Windows.Forms.Button();
            this.btn_NewCFM = new System.Windows.Forms.Button();
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
            this.lblColor5 = new System.Windows.Forms.Label();
            this.lblColor4 = new System.Windows.Forms.Label();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.lblColor3 = new System.Windows.Forms.Label();
            this.lblColor1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(672, 3);
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Text = "Clear";
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.OwnerDraw = true;
            this.c1CommandLink4.Text = "Drop Style";
            // 
            // tbtn_Append
            // 
            this.tbtn_Append.Text = "Drop Style";
            this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Text = "Restore Style";
            this.c1CommandLink5.ToolTipText = "Restore Style";
            // 
            // tbtn_Insert
            // 
            this.tbtn_Insert.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Insert_Click);
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
            // 
            // c1CommandLink7
            // 
            this.c1CommandLink7.Text = "Print";
            this.c1CommandLink7.ToolTipText = "Print";
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
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
            this.grdCFM.Size = new System.Drawing.Size(1000, 456);
            this.grdCFM.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("grdCFM.Styles"));
            this.grdCFM.TabIndex = 131;
            this.grdCFM.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.grdCFM_AfterEdit);
            this.grdCFM.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.grdCFM_BeforeEdit);
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
            this.pnl_Top.Size = new System.Drawing.Size(1016, 104);
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
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 96);
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
            this.lblSeason.Click += new System.EventHandler(this.lblSeason_Click);
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
            this.panel1.Size = new System.Drawing.Size(1000, 96);
            this.panel1.TabIndex = 349;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(977, 80);
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
            this.panel2.Size = new System.Drawing.Size(1000, 96);
            this.panel2.TabIndex = 350;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtAssyD2);
            this.panel3.Controls.Add(this.txtAssyD1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.chkComp);
            this.panel3.Controls.Add(this.chkShip);
            this.panel3.Controls.Add(this.btnSave);
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
            this.panel3.Controls.Add(this.lblSubTitle);
            this.panel3.Controls.Add(this.pictureBox21);
            this.panel3.Controls.Add(this.pictureBox22);
            this.panel3.Controls.Add(this.pictureBox23);
            this.panel3.Controls.Add(this.pictureBox24);
            this.panel3.Controls.Add(this.pictureBox25);
            this.panel3.Controls.Add(this.pictureBox20);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 96);
            this.panel3.TabIndex = 349;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1032, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 373;
            this.label3.Text = "(YYYYMMDD)";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(936, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 371;
            this.label2.Text = "~";
            // 
            // txtAssyD2
            // 
            this.txtAssyD2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssyD2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssyD2.Location = new System.Drawing.Point(952, 64);
            this.txtAssyD2.Name = "txtAssyD2";
            this.txtAssyD2.Size = new System.Drawing.Size(80, 22);
            this.txtAssyD2.TabIndex = 370;
            // 
            // txtAssyD1
            // 
            this.txtAssyD1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssyD1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssyD1.Location = new System.Drawing.Point(856, 64);
            this.txtAssyD1.Name = "txtAssyD1";
            this.txtAssyD1.Size = new System.Drawing.Size(80, 22);
            this.txtAssyD1.TabIndex = 369;
            // 
            // label1
            // 
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(752, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 368;
            this.label1.Text = "Ass\'y Term";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkComp
            // 
            this.chkComp.Location = new System.Drawing.Point(792, 37);
            this.chkComp.Name = "chkComp";
            this.chkComp.Size = new System.Drawing.Size(128, 16);
            this.chkComp.TabIndex = 367;
            this.chkComp.Text = "Show CFM Shoe";
            // 
            // chkShip
            // 
            this.chkShip.Checked = true;
            this.chkShip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShip.Location = new System.Drawing.Point(613, 38);
            this.chkShip.Name = "chkShip";
            this.chkShip.Size = new System.Drawing.Size(179, 16);
            this.chkShip.TabIndex = 366;
            this.chkShip.Text = "Show list after Ship Date";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(896, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 24);
            this.btnSave.TabIndex = 365;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(808, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 24);
            this.btnSearch.TabIndex = 364;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStyle
            // 
            this.txtStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStyle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStyle.Location = new System.Drawing.Point(529, 64);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(208, 22);
            this.txtStyle.TabIndex = 361;
            this.txtStyle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStyle_KeyPress);
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
            this.cmbSeason.Location = new System.Drawing.Point(529, 36);
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
            this.pictureBox18.Location = new System.Drawing.Point(976, 24);
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
            this.pictureBox19.Location = new System.Drawing.Point(976, 0);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(16, 32);
            this.pictureBox19.TabIndex = 21;
            this.pictureBox19.TabStop = false;
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
            this.pictureBox21.Location = new System.Drawing.Point(1000, 651);
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
            this.pictureBox22.Size = new System.Drawing.Size(1016, 18);
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
            this.pictureBox25.Size = new System.Drawing.Size(1016, 626);
            this.pictureBox25.TabIndex = 27;
            this.pictureBox25.TabStop = false;
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
            this.pictureBox20.Size = new System.Drawing.Size(752, 24);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(983, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 53);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // btnSelStyle
            // 
            this.btnSelStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelStyle.Location = new System.Drawing.Point(832, 72);
            this.btnSelStyle.Name = "btnSelStyle";
            this.btnSelStyle.Size = new System.Drawing.Size(152, 23);
            this.btnSelStyle.TabIndex = 369;
            this.btnSelStyle.Text = "Search Style";
            this.btnSelStyle.UseVisualStyleBackColor = false;
            this.btnSelStyle.Click += new System.EventHandler(this.btnSelStyle_Click);
            // 
            // btn_NewCFM
            // 
            this.btn_NewCFM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NewCFM.BackColor = System.Drawing.Color.Yellow;
            this.btn_NewCFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewCFM.Location = new System.Drawing.Point(672, 72);
            this.btn_NewCFM.Name = "btn_NewCFM";
            this.btn_NewCFM.Size = new System.Drawing.Size(152, 23);
            this.btn_NewCFM.TabIndex = 368;
            this.btn_NewCFM.Text = "New CFM Style";
            this.btn_NewCFM.UseVisualStyleBackColor = false;
            this.btn_NewCFM.Click += new System.EventHandler(this.btn_NewCFM_Click);
            // 
            // img_MiniButton
            // 
            this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
            this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_MiniButton.Images.SetKeyName(0, "");
            this.img_MiniButton.Images.SetKeyName(1, "");
            // 
            // img_LongButton
            // 
            this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
            this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LongButton.Images.SetKeyName(0, "");
            this.img_LongButton.Images.SetKeyName(1, "");
            // 
            // lblColor5
            // 
            this.lblColor5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor5.AutoSize = true;
            this.lblColor5.BackColor = System.Drawing.Color.Red;
            this.lblColor5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor5.Location = new System.Drawing.Point(608, 48);
            this.lblColor5.Name = "lblColor5";
            this.lblColor5.Size = new System.Drawing.Size(59, 14);
            this.lblColor5.TabIndex = 370;
            this.lblColor5.Text = "Delay Date";
            // 
            // lblColor4
            // 
            this.lblColor4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor4.AutoSize = true;
            this.lblColor4.BackColor = System.Drawing.Color.Yellow;
            this.lblColor4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor4.Location = new System.Drawing.Point(480, 48);
            this.lblColor4.Name = "lblColor4";
            this.lblColor4.Size = new System.Drawing.Size(122, 14);
            this.lblColor4.TabIndex = 371;
            this.lblColor4.Text = "Change Ship/Assy Date";
            // 
            // lblColor2
            // 
            this.lblColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor2.AutoSize = true;
            this.lblColor2.BackColor = System.Drawing.Color.LightGreen;
            this.lblColor2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor2.Location = new System.Drawing.Point(304, 48);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(83, 14);
            this.lblColor2.TabIndex = 372;
            this.lblColor2.Text = "CFM Style Color";
            // 
            // lblColor3
            // 
            this.lblColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor3.AutoSize = true;
            this.lblColor3.BackColor = System.Drawing.Color.Gray;
            this.lblColor3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor3.Location = new System.Drawing.Point(392, 48);
            this.lblColor3.Name = "lblColor3";
            this.lblColor3.Size = new System.Drawing.Size(85, 14);
            this.lblColor3.TabIndex = 373;
            this.lblColor3.Text = "Drop Style Color";
            // 
            // lblColor1
            // 
            this.lblColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor1.AutoSize = true;
            this.lblColor1.BackColor = System.Drawing.Color.LightBlue;
            this.lblColor1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor1.Location = new System.Drawing.Point(216, 48);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(85, 14);
            this.lblColor1.TabIndex = 374;
            this.lblColor1.Text = "New Style Color";
            // 
            // Form_CFM_Schedule
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.lblColor1);
            this.Controls.Add(this.lblColor3);
            this.Controls.Add(this.lblColor2);
            this.Controls.Add(this.lblColor4);
            this.Controls.Add(this.lblColor5);
            this.Controls.Add(this.btnSelStyle);
            this.Controls.Add(this.btn_NewCFM);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.grdCFM);
            this.Name = "Form_CFM_Schedule";
            this.Text = "CFM Shoe Schedule Management";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_CFM_Schedule_Closing);
            this.Load += new System.EventHandler(this.Form_CFM_Schedule_Load);
            this.Controls.SetChildIndex(this.grdCFM, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.btn_NewCFM, 0);
            this.Controls.SetChildIndex(this.btnSelStyle, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region 공통메쏘드

		private void Init_Form()
		{
			this.Text = "CFM Shoe Schedule Management";
			this.lbl_MainTitle.Text = "CFM Shoe Schedule Management";

			ClassLib.ComFunction.SetLangDic(this); 

			// Default 
			tbtn_New.Enabled     = false;
			tbtn_Search.Enabled  = false;
			tbtn_Save.Enabled    = false;
			tbtn_Append.Enabled  = false;  //Drop Style Function    <- Changed Button
			tbtn_Insert.Enabled  = false;  //Restore Style Function <- Changed Button
			tbtn_Delete.Enabled  = false;
			tbtn_Create.Enabled  = false;
			tbtn_Color.Enabled   = false;
			tbtn_Print.Enabled   = false;

			btnSave.Enabled      = false; 
			btnSearch.Enabled    = false;
			btn_NewCFM.Visible   = false;
			btnSelStyle.Visible  = false;

			if (ClassLib.ComVar.This_Factory.ToString() == "DS")
			{
				tbtn_Search.Enabled = true;
				tbtn_Save.Enabled   = true;
				btnSave.Enabled     = true;
				btnSearch.Enabled   = true;
				tbtn_Print.Enabled  = true;
			}
			else if (ClassLib.ComVar.This_Factory == "VJ" || ClassLib.ComVar.This_Factory == "QD")
			{
				tbtn_Search.Enabled = true;
				tbtn_Save.Enabled   = true;
				btnSave.Enabled     = true; 
				btnSearch.Enabled   = true;
				tbtn_Print.Enabled  = true;
			}
			else
			{
				tbtn_Search.Enabled = true;
				btnSearch.Enabled   = true;
				tbtn_Print.Enabled  = true;
			}

            if (ClassLib.ComVar.This_User.ToString() == "daniel.jeong@dskorea.com" || ClassLib.ComVar.This_User.ToString() == "hanseok.kim" || ClassLib.ComVar.This_User.ToString() == "yunhyun.chung" 
                || ClassLib.ComVar.This_User.ToString() == "joey.jung"
                || ClassLib.ComVar.This_User.ToString() == "hyunah.jung@dskorea.com" 
                || ClassLib.ComVar.This_User.ToString() == "hyesung.yoon")
			{
				tbtn_Search.Enabled = true;
				tbtn_Save.Enabled   = true;
				tbtn_Append.Enabled = true;  //Drop Style Function    <- Changed Button
				tbtn_Insert.Enabled = true;  //Restore Style Function <- Changed Button
				tbtn_Delete.Enabled = true;
				tbtn_Print.Enabled  = true;

				btnSave.Enabled     = true; 
				btnSearch.Enabled   = true;
				btn_NewCFM.Visible  = true;
				btnSelStyle.Visible = true;
			}

			DataTable vDT = null;

			try
			{
				//Factory Code ComboBox Link - Common Code Table
				vDT = ClassLib.ComFunction.Select_Factory_List();
				ClassLib.ComCtl.Set_Factory_List(vDT, cmbFactory, 0, 1, true, COM.ComVar.ComboList_Visible.Code);
				if (ClassLib.ComVar.This_Factory == "VJ" || ClassLib.ComVar.This_Factory == "QD")
				{
					cmbFactory.SelectedValue = ClassLib.ComVar.This_Factory;
				}
				else
				{
					cmbFactory.SelectedIndex = 0;
				}
			
				//CDC DPO ComboBox List
				vDT = Select_Sdc_CFM_Dpo();
				COM.ComCtl.Set_ComboList(vDT, cmbDPO, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
				cmbDPO.SelectedIndex = 0;

				//Season Code ComboBox List
				vDT = Select_Sdc_CFM_Season();
				ClassLib.ComCtl.Set_ComboList(vDT, cmbSeason, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
				cmbSeason.SelectedIndex = 0;

				//Category Code ComboBox Link - Common Code Table(COM_Code = 'MD02')
				vDT = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SXB03");
				COM.ComCtl.Set_ComboList(vDT, cmbCategory, 1, 2,  true, COM.ComVar.ComboList_Visible.Name);
				cmbCategory.SelectedIndex = 0;

				//CDC Developer ComboBox List
				vDT = Select_Sdc_CFM_Dev();
				ClassLib.ComCtl.Set_ComboList(vDT, cmbDeveloper, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
				bool vSelect = false;
				for (int i = 1; i <= cmbDeveloper.ListCount; i++)
				{
					if (cmbDeveloper.GetItemText(i,1).ToString() == ClassLib.ComVar.This_User)
					{
						cmbDeveloper.SelectedIndex = i;
						vSelect = true;
						break;
					}
				}
				if (vSelect == false)
				{
					cmbDeveloper.SelectedIndex = 0;
				}				
			}
			finally
			{
				if (vDT != null)
					vDT.Dispose();
			}
			
			//Set Grid grdCFM Head Title
			grdCFM.Set_Grid("SDC_CFM_SCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);
			//Show the image of Insert, Delete, Update
			//grdCFM.Set_Action_Image(img_Action);
			this.Set_Action_CFM_Image(img_Action);
			//grdCFM.Mark_Grid_Menu();
			//grdCFM.AllowSorting = AllowSortingEnum.None;
			_RowFixed = grdCFM.Rows.Fixed;
			grdCFM.AutoSizeCols();
		}

	
		public void Show_grdCFM_Data()
		{
			//
			//각 공장별 Edit Column 구별, 해외 -> Ship Date and Assy Date : DS -> Category, Developer, Spec/SBook/CFM Date, Remark
			//
			this.Cursor = Cursors.WaitCursor;

			grdCFM.Rows.Count = _RowFixed;	
			DataTable vDT = null;

			try
			{
				vDT = Select_Sdc_CFM_SCH();

				int dt_rows = vDT.Rows.Count;
				int dt_cols = vDT.Columns.Count;

				DateTime vSPDate;
				DateTime vSBDate;
				DateTime vCFDate;
				DateTime vSBDDD;
				DateTime vCFDDD;
				
				int iCreatDT;
				int iTodayDT;
				int iRow;

				for(int i = 0; i < dt_rows; i++)
				{
					grdCFM.AddItem(vDT.Rows[i].ItemArray, grdCFM.Rows.Count, 1);
					grdCFM[i+grdCFM.Rows.Fixed, 0] = "";

					//Setting SpecDate  BackColor (Spec Date)  > (CFM DDD)   = Red <- (Assy Date Before -17 day : Green, After -17 : Red)
					//Setting SBookDate BackColor (SBook Date) > (SBook DDD) = Red <- (Ship Date Before -14 day : Green, After -14 : Red)
					//                                                                (Assy Date Defore -31 day : Green, After -31 : Red)
					//Setting CFMDate   BackColor (CFM Date)   > (CFM DDD)   = Red <- (Assy Date Before -17 day : Green, After -17 : Red)
					//(12):Spec Date, (14):SBook DDD, (15):SBook Date, (17):CFMShoe DDD, (18):CFMShoe Date, (20):Assy Date1

					iRow = i + _RowFixed;   //Current Row

					//Set Row Color
					iCreatDT = Convert.ToInt32(Convert.ToDateTime(vDT.Rows[i].ItemArray[24]).ToString("yyyyMMdd"));
					iTodayDT = Convert.ToInt32(DateTime.Now.AddDays(-7).ToString("yyyyMMdd"));
					if ((iCreatDT > iTodayDT) || grdCFM[iRow, 24].ToString() == "New")
					{
						//Change Color "New" style then vDT.Rows[i].ItemArray[24]:Creation Date > Today -7.
						CellRange cr1 = grdCFM.GetCellRange(iRow, 1);
						CellRange cr2 = grdCFM.GetCellRange(iRow, 3, iRow, 11); 
						cr1.StyleNew.BackColor = Color.LightSkyBlue;
						cr2.StyleNew.BackColor = Color.LightSkyBlue;
					}
					if (grdCFM[iRow, 24].ToString() == "Finish")
					{
						CellRange cr1 = grdCFM.GetCellRange(iRow, 1); 
						CellRange cr2 = grdCFM.GetCellRange(iRow, 3, iRow, 11); 
						cr1.StyleNew.BackColor = Color.LightGreen;
						cr2.StyleNew.BackColor = Color.LightGreen;
					}
					if (grdCFM[iRow, 24].ToString() == "Drop")
					{
						CellRange cr1 = grdCFM.GetCellRange(iRow, 1);
						CellRange cr2 = grdCFM.GetCellRange(iRow, 3, iRow, 11);
						cr1.StyleNew.BackColor = Color.Gray;
						cr2.StyleNew.BackColor = Color.Gray;
					}

					//Setting Color on case Status Column(24) is not New, Finish, Drop
					if (grdCFM[iRow, 24].ToString().Trim() == "" || grdCFM[iRow, 24].ToString().Trim() == "New")
					{
						//Setting Spec Color
						if (grdCFM[iRow, 12] != null && grdCFM[iRow, 17] != null)
						{
							vSPDate = Convert.ToDateTime(grdCFM[iRow,12].ToString());
							vCFDDD  = Convert.ToDateTime(grdCFM[iRow,17].ToString());

							if (vSPDate >= vCFDDD && grdCFM[iRow,13].ToString() != "OK")
							{
								CellRange cr1 = grdCFM.GetCellRange(iRow, 12, iRow, 13);
								cr1.StyleNew.BackColor = Color.Red;
							}
						}
					
						//Setting SBook Color
						if (grdCFM[iRow,14] != null && grdCFM[iRow, 15] != null)
						{
							vSBDate = Convert.ToDateTime(grdCFM[iRow,15].ToString());
							vSBDDD  = Convert.ToDateTime(grdCFM[iRow,14].ToString());

							if (vSBDate >= vSBDDD && grdCFM[iRow,16].ToString() != "OK")
							{
								CellRange cr1 = grdCFM.GetCellRange(iRow, 14, iRow, 16);
								cr1.StyleNew.BackColor = Color.Red;
							}
						}

						//Setting CFM Color
						if (grdCFM[iRow,17] != null && grdCFM[iRow, 18] != null)
						{
							vCFDate = Convert.ToDateTime(grdCFM[iRow,18].ToString());
							vCFDDD  = Convert.ToDateTime(grdCFM[iRow,17].ToString());

							if (vCFDate >= vCFDDD && grdCFM[iRow,19].ToString() != "OK")
							{
								CellRange cr1 = grdCFM.GetCellRange(iRow, 17, iRow, 19);
								cr1.StyleNew.BackColor = Color.Red;
							}
						}
					}

					//Campare current ship Creation date(vDT(27) with iTodayDT(Today-7) to change Color. 
					if (grdCFM[iRow, 2] != null && vDT.Rows[i].ItemArray[27].ToString().Trim() != "null") 
					{
						if (Convert.ToInt32(vDT.Rows[i].ItemArray[27].ToString()) >= iTodayDT)
						{
							CellRange cr1 = grdCFM.GetCellRange(iRow, 2);
							cr1.StyleNew.BackColor = Color.Yellow;
						}
					} 

					//Campare current assy Creation date(vDT(28) with iTodayDT(Today-7) to change Color. 
					if (grdCFM[iRow, 20] != null && vDT.Rows[i].ItemArray[28].ToString().Trim() != "null")
					{
						if (Convert.ToInt32(vDT.Rows[i].ItemArray[28].ToString()) >= iTodayDT)
						{
							CellRange cr1 = grdCFM.GetCellRange(iRow, 20); 
							cr1.StyleNew.BackColor = Color.Yellow;
						}
					}
				}

				//(02):Ship Date, (05):TD Code,      (09):Category CD, (11):Developer,   (12):Spec Date,   (13):Spec CFM,    (15):SBook Date,
				//(16):SBook CFM, (18):CFMShoe Date, (19):CFMShoe CFM, (20): Ass'y Date, (21):Ass'y Date2, (22)CDC Remark,  (23)Factory Remark
				if (ClassLib.ComVar.This_Factory.ToString() == "DS")
				{
					//Assembly Date(20,21), VJ/QD Factory Remark(23) can control in VJ, QD. 
					grdCFM.Cols[2].AllowEditing  = false;
					grdCFM.Cols[5].AllowEditing  = false;
					grdCFM.Cols[20].AllowEditing = false;
					grdCFM.Cols[21].AllowEditing = false;
					grdCFM.Cols[23].AllowEditing = false;
				}
				else if (ClassLib.ComVar.This_Factory.ToString() == "VJ" || ClassLib.ComVar.This_Factory.ToString() == "QD")
				{
					grdCFM.Cols[2].AllowEditing  = false;
					grdCFM.Cols[5].AllowEditing  = false;
					grdCFM.Cols[9].AllowEditing  = false;
					grdCFM.Cols[11].AllowEditing = false;
					grdCFM.Cols[12].AllowEditing = false;
					grdCFM.Cols[13].AllowEditing = false;
					grdCFM.Cols[15].AllowEditing = false;
					grdCFM.Cols[16].AllowEditing = false;
					grdCFM.Cols[18].AllowEditing = false;
					grdCFM.Cols[19].AllowEditing = false;
					grdCFM.Cols[21].AllowEditing = false;
					grdCFM.Cols[22].AllowEditing = false;
				}
				else
				{
					//DS, VJ, QD other user.
					grdCFM.Cols[2].AllowEditing  = false;
					grdCFM.Cols[5].AllowEditing  = false;
					grdCFM.Cols[9].AllowEditing  = false;
					grdCFM.Cols[11].AllowEditing = false;
					grdCFM.Cols[12].AllowEditing = false;
					grdCFM.Cols[13].AllowEditing = false;
					grdCFM.Cols[15].AllowEditing = false;
					grdCFM.Cols[16].AllowEditing = false;
					grdCFM.Cols[18].AllowEditing = false;
					grdCFM.Cols[19].AllowEditing = false;
					grdCFM.Cols[20].AllowEditing = false;
					grdCFM.Cols[21].AllowEditing = false;
					grdCFM.Cols[22].AllowEditing = false;
					grdCFM.Cols[23].AllowEditing = false;
				}

				//Hard coding all edit authority to BU and COMMO user accounts. 
				if (ClassLib.ComVar.This_User.ToString() == "hanseok.kim" || ClassLib.ComVar.This_User.ToString() == "yunhyun.chung" 
                    || ClassLib.ComVar.This_User.ToString() == "joey.jung" || ClassLib.ComVar.This_User.ToString() == "hyunah.jung@dskorea.com"
                    ||ClassLib.ComVar.This_User.ToString() == "hyesung.yoon")
				{
					grdCFM.Cols[2].AllowEditing  = false;
					grdCFM.Cols[5].AllowEditing  = true;
					grdCFM.Cols[9].AllowEditing  = true;
					grdCFM.Cols[11].AllowEditing = true;
					grdCFM.Cols[12].AllowEditing = true;
					grdCFM.Cols[13].AllowEditing = true;
					grdCFM.Cols[15].AllowEditing = true;
					grdCFM.Cols[16].AllowEditing = true;
					grdCFM.Cols[18].AllowEditing = true;
					grdCFM.Cols[19].AllowEditing = true;
					grdCFM.Cols[20].AllowEditing = true;
					grdCFM.Cols[21].AllowEditing = false;
					grdCFM.Cols[22].AllowEditing = true;
					grdCFM.Cols[23].AllowEditing = true;
				}

				vQueryOK = true;
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

			Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_SCHEDULE";

			OraDB.ReDim_Parameter(11);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_DPO_ID";
			OraDB.Parameter_Name[2]  = "ARG_SEASON";
			OraDB.Parameter_Name[3]  = "ARG_CATEGORY";
			OraDB.Parameter_Name[4]  = "ARG_DEVELOPER";
			OraDB.Parameter_Name[5]  = "ARG_STYLE";
			OraDB.Parameter_Name[6]  = "ARG_ASSY1";
			OraDB.Parameter_Name[7]  = "ARG_ASSY2";
			OraDB.Parameter_Name[8]  = "ARG_SHIP_CHK";
			OraDB.Parameter_Name[9]  = "ARG_COMP_CHK";
			OraDB.Parameter_Name[10] = "out_cursor";

			OraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[10] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0]  = cmbFactory.SelectedValue.ToString();
			OraDB.Parameter_Values[1]  = cmbDPO.SelectedValue.ToString();
			OraDB.Parameter_Values[2]  = cmbSeason.SelectedValue.ToString();
			OraDB.Parameter_Values[3]  = cmbCategory.SelectedValue.ToString();
			OraDB.Parameter_Values[4]  = cmbDeveloper.SelectedValue.ToString();
			OraDB.Parameter_Values[5]  = txtStyle.Text.ToString().Trim();
			OraDB.Parameter_Values[6]  = txtAssyD1.Text.ToString().Trim();
			OraDB.Parameter_Values[7]  = txtAssyD2.Text.ToString().Trim();
			OraDB.Parameter_Values[8]  = (chkShip.Checked == false) ? DateTime.Now.ToString("yyyyMMdd") : " ";
			OraDB.Parameter_Values[9]  = chkComp.Checked.ToString();
			OraDB.Parameter_Values[10] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure(); 

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}
	

		/// <summary>
		/// Save SDC_CFM_SCH & SDC_CFM_SCH_HIS
		/// </summary>
		private void SAVE_CFM_SCH(int iRow)
		{
			OraDB.ReDim_Parameter(29);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDC_CFM.UPDATE_CFM_SCH";
			
			//02.ARGURMENT 명
			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_DPO_ID";
			OraDB.Parameter_Name[2]  = "ARG_TD_CD";
			OraDB.Parameter_Name[3]  = "ARG_STYLE_CD";
			OraDB.Parameter_Name[4]  = "ARG_STYLE_NAME";
			OraDB.Parameter_Name[5]  = "ARG_SEASON_CD";
			OraDB.Parameter_Name[6]  = "ARG_SHIP_DATE";
			OraDB.Parameter_Name[7]  = "ARG_PJ_SEQ";
			OraDB.Parameter_Name[8]  = "ARG_SRF_NO";
			OraDB.Parameter_Name[9]  = "ARG_BOM_ID";
			OraDB.Parameter_Name[10] = "ARG_BOM_REV";
			OraDB.Parameter_Name[11] = "ARG_MODEL_CD";
			OraDB.Parameter_Name[12] = "ARG_MODEL_NAME";
			OraDB.Parameter_Name[13] = "ARG_CAT_CD";
			OraDB.Parameter_Name[14] = "ARG_CDC_DEV";
			OraDB.Parameter_Name[15] = "ARG_SPEC_DATE";
			OraDB.Parameter_Name[16] = "ARG_SPEC_CFM";
			OraDB.Parameter_Name[17] = "ARG_SBOOK_DATE";
			OraDB.Parameter_Name[18] = "ARG_SBOOK_CFM";
			OraDB.Parameter_Name[19] = "ARG_CFMSHOE_DATE";
			OraDB.Parameter_Name[20] = "ARG_CFMSHOE_CFM";
			OraDB.Parameter_Name[21] = "ARG_ASSY_DATE1";
			OraDB.Parameter_Name[22] = "ARG_ASSY_DATE2";
			OraDB.Parameter_Name[23] = "ARG_CFM_REMARK";
			OraDB.Parameter_Name[24] = "ARG_CFM_REMARK_F";
			OraDB.Parameter_Name[25] = "ARG_UPD_USER";
			OraDB.Parameter_Name[26] = "ARG_UPD_USER_F";
			OraDB.Parameter_Name[27] = "ARG_UPD_FACTORY";
			OraDB.Parameter_Name[28] = "ARG_DIV";          //(U):Update, (D):Delete, (C):Cancel, Drop 구분자

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
			OraDB.Parameter_Type[10] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[11] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[12] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[13] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[14] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[15] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[16] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[17] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[18] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[19] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[20] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[21] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[22] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[23] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[24] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[25] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[26] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[27] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[28] = (int)OracleType.VarChar;

			//04.grdCFM DATA정의(Col):Value = (0):U/D,(1):Factory,(2):Ship Date,(3):Season,(4):DPO,(5):TD_CD,(6):StyleNo,(7):StyleName,
			//                                (8):Gender,(9):Category CD,(10):Qty,(11):Developer,(12):Spec Date,(13):Spec CFM,
			//                                (14):SBook DDD,(15):SBook Date,(16):SBook CFM,(17):CFMShoe DDD,(18):CFMShoe Date,
			//                                (19):CFMShoe CFM,(20):Assembly Date1,(21):Assembly Date2,(22):CDC Remark,(23):Factory Remark 
			OraDB.Parameter_Values[0]  = grdCFM[iRow, 1].ToString();                   //ARG_FACTORY:     (1)Factory
			OraDB.Parameter_Values[1]  = grdCFM[iRow, 4].ToString();                   //ARG_DPO_ID:      (4):DPO
			OraDB.Parameter_Values[2]  = grdCFM[iRow, 5].ToString();                   //ARG_TD_CD:       (5):DPO
			OraDB.Parameter_Values[3]  = grdCFM[iRow, 6].ToString();                   //ARG_STYLE_CD:    (6):StyleNo
			OraDB.Parameter_Values[4]  = grdCFM[iRow, 7].ToString();                   //ARG_STYLE_NAME   (7):StyleName
			OraDB.Parameter_Values[5]  = grdCFM[iRow, 3].ToString();                   //ARG_SEASON_CD    (3):Season
			OraDB.Parameter_Values[6]  = (grdCFM[iRow, 2] == null) ? "" : Convert.ToDateTime(grdCFM[iRow, 2]).ToString("yyyyMMdd"); //Ship_Date
			OraDB.Parameter_Values[7]  = "";                                           //ARG_PJ_SEQ 
			OraDB.Parameter_Values[8]  = "";                                           //ARG_SRF_NO 
			OraDB.Parameter_Values[9]  = "";                                           //ARG_BOM_ID
			OraDB.Parameter_Values[10] = "";                                           //ARG_BOM_REV
			OraDB.Parameter_Values[11] = "";                                           //ARG_MODEL_CD
			OraDB.Parameter_Values[12] = "";                                           //ARG_MODEL_NAME
			OraDB.Parameter_Values[13] = grdCFM[iRow, 9].ToString();                   //ARG_CAT_CD       (9):Category CD
			OraDB.Parameter_Values[14] = grdCFM[iRow, 11].ToString();                  //ARG_CDC_DEV      (11):Developer
			OraDB.Parameter_Values[15] = (grdCFM[iRow, 12] == null) ? "" : Convert.ToDateTime(grdCFM[iRow, 12]).ToString("yyyyMMdd");   //ARG_SPEC_DATE    (12):Spec Date
			OraDB.Parameter_Values[16] = (grdCFM[iRow, 13].ToString().Trim() == "OK") ? "Y" : "N";										//ARG_SPEC_CFM     (13):Spec CFM
			OraDB.Parameter_Values[17] = (grdCFM[iRow, 15] == null) ? "" : Convert.ToDateTime(grdCFM[iRow, 15]).ToString("yyyyMMdd");   //ARG_SBOOK_DATE   (15):SBook Date
			OraDB.Parameter_Values[18] = (grdCFM[iRow, 16].ToString().Trim() == "OK") ? "Y" : "N";										//ARG_SBOOK_CFM    (16):SBook CFM
			OraDB.Parameter_Values[19] = (grdCFM[iRow, 18] == null) ? "" : Convert.ToDateTime(grdCFM[iRow, 18]).ToString("yyyyMMdd");   //ARG_CFMSHOE_DATE (18):CFMShoe Date
			OraDB.Parameter_Values[20] = (grdCFM[iRow, 19].ToString().Trim() == "OK") ? "Y" : "N";										//ARG_CFMSHOE_CFM  (19):CFMShoe CFM
			OraDB.Parameter_Values[21] = (grdCFM[iRow, 20] == null) ? "" : Convert.ToDateTime(grdCFM[iRow, 20]).ToString("yyyyMMdd");   //ARG_ASSY_DATE1   (20):Assembly Date1
			OraDB.Parameter_Values[22] = (grdCFM[iRow, 21] == null) ? "" : Convert.ToDateTime(grdCFM[iRow, 21]).ToString("yyyyMMdd");   //ARG_ASSY_DATE2   (21):Assembly Date2
			OraDB.Parameter_Values[23] = grdCFM[iRow, 22].ToString();																	//ARG_CFM_REMARK   (22):CDC Remark
			OraDB.Parameter_Values[24] = grdCFM[iRow, 23].ToString();																	//ARG_CFM_REMARK_F (23):Factory Remark
			OraDB.Parameter_Values[25] = (ClassLib.ComVar.This_Factory == "DS") ? ClassLib.ComVar.This_User.ToString() : "";   //UPD_USER
			OraDB.Parameter_Values[26] = (ClassLib.ComVar.This_Factory != "DS") ? ClassLib.ComVar.This_User.ToString() : "";   //UPD_USER_F
			OraDB.Parameter_Values[27] = ClassLib.ComVar.This_Factory.ToString();											   //UPD_UPD_FACTORY
			OraDB.Parameter_Values[28] = grdCFM[iRow, 0].ToString();														   //ARG_DIV          (0)U/D = (U):Update,(D):Delete,(C):Drop(Cancel) 구분자

			OraDB.Add_Modify_Parameter(true);
			OraDB.Exe_Modify_Procedure();
		}

		#endregion 

		#region 이벤트처리

		#region 버튼 이벤트

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Show_grdCFM_Data();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
//			Report.Form_SD_Report_Viewer viewer = null;
//			string report_file_name = null;
//
//			if(cmb_vendor.SelectedIndex == 0)
//			{
//				MessageBox.Show("Vendor를 선택 하셔야 합니다.");
//				return;
//			}
//
//			//if(grdCFM.row
//
//			
//				
//			if(cmb_impyn.SelectedIndex == 2) report_file_name = @"\report\Order_sheet_import_list.mrd";
//			else report_file_name = @"\report\Order_sheet_list.mrd";
//
//
//			string conform_flg = "";
//			string arg_cancel_flg = "";
//			if(cmb_purflg.SelectedValue.ToString() == "C")
//			{
//				conform_flg = "C";
//				arg_cancel_flg = "";
//			}
//			else
//			{
//				conform_flg = "";
//				arg_cancel_flg = "D";
//			}
//
//
//			viewer = new FlexDevelop.Report.Form_SD_Report_Viewer(Application.StartupPath + report_file_name, "/rp [" + ClassLib.ComVar.This_Factory +"] [" + cmbDeveloper.SelectedValue.ToString() + "] [" + pick_purdate.Text + "] [" + pick_purdate2.Text + "] [" + cmb_purno.SelectedValue.ToString() + "] [" + cmb_impyn.SelectedValue.ToString() + "] [ ] [ ] ["+cmb_vendor.SelectedValue.ToString() + "] [" + conform_flg + "] [" + arg_cancel_flg + "] /rv V_STATUS[" + cmb_purflg.GetItemText(cmb_purflg.SelectedIndex, 1) + "]");
//			viewer.ShowDialog();

//			string report_file_name = @"\report\Order_list_000.mrd";
//
//			string factory           = ClassLib.ComVar.This_Factory;
//			string arg_load_upd_user = cmbDeveloper.SelectedValue.ToString();
//			string arg_std_ymd       = pick_purdate.Text;
//			string arg_fin_ymd       = pick_purdate2.Text;
//			string arg_pur_no        = cmb_purno.SelectedValue.ToString();
//			string arg_import_yn     = cmb_impyn.SelectedValue.ToString();
//			string arg_dev_name      = cmb_model.SelectedValue.ToString();
//			string arg_srf_no        = cmb_srfno.SelectedValue.ToString();
//			string arg_vendor        = cmb_vendor.SelectedValue.ToString();
//			string arg_pur_flg  = cmb_purflg.SelectedValue.ToString();
//			string arg_nf_cd    = cmb_sampletype.SelectedValue.ToString();
//
//			Report.Form_SD_Report_Viewer viewer = null;
//
//			viewer = new FlexDevelop.Report.Form_SD_Report_Viewer(Application.StartupPath + report_file_name, "/rp [" + factory +"] [" + arg_load_upd_user + "] [" + arg_std_ymd + "] [" +arg_fin_ymd + "] [" + arg_pur_no + "] [" +  arg_import_yn + "] [" + arg_dev_name + "] [" + arg_srf_no + "] [" + arg_vendor + "] [" + arg_pur_flg + "] [" + arg_nf_cd + "] /rv V_STATUS[" + cmb_purflg.GetItemText(cmb_purflg.SelectedIndex, 1) + "]");
//			viewer.ShowDialog();

            string mrd_Filename = Application.StartupPath + @"\rd_CFM_Schedule.mrd";

			

			string ARG_FACTORY   = cmbFactory.SelectedValue.ToString();
			string ARG_DPO_ID    = cmbDPO.SelectedValue.ToString();
			string ARG_SEASON    = cmbSeason.SelectedValue.ToString();
			string ARG_CATEGORY  = cmbCategory.SelectedValue.ToString();
			string ARG_DEVELOPER = cmbDeveloper.SelectedValue.ToString();
			string ARG_STYLE     = txtStyle.Text.ToString().Trim();
			string ARG_ASSY1     = txtAssyD1.Text.ToString().Trim();
			string ARG_ASSY2     = txtAssyD2.Text.ToString().Trim();
			string ARG_SHIP_CHK  = (chkShip.Checked == false) ? DateTime.Now.ToString("yyyyMMdd") : " ";
			string ARG_COMP_CHK  = chkComp.Checked.ToString();

            string sPara = " /rp " + "[" + ARG_FACTORY + "]" + " [" + ARG_DPO_ID + "]" + " [" + ARG_SEASON + "]" + " [" + ARG_CATEGORY + "]"
                                      + " [" + ARG_DEVELOPER + "]" + " [" + ARG_STYLE + "]" + " [" + ARG_ASSY1 + "]" + " [" + ARG_ASSY2 + "]" + " [" + ARG_SHIP_CHK + "]"
                                      + " [" + ARG_COMP_CHK + "]";

              


            // FlexCDC.Report.Form_RdViewer 
            Report.Form_RdViewer viewer = null;


            FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
            report.ShowDialog();


            //viewer = new FlexCDC.Report.Form_RdViewer(mrd_Filename + "/rp [" + ARG_FACTORY + "] [" + ARG_DPO_ID + "] [" + ARG_SEASON + "] [" + ARG_CATEGORY + "] [" + ARG_DEVELOPER + "] [" + ARG_STYLE + "] [" + ARG_ASSY1 + "] [" + ARG_ASSY2 + "] [" + ARG_SHIP_CHK + "] [" + ARG_COMP_CHK + "]");
            //viewer.ShowDialog();
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (grdCFM.Rows.Count <= _RowFixed)
			{
                MessageBox.Show("No save a data!");
				return;
			}

			DialogResult vOK = MessageBox.Show("Save OK?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			if (vOK == DialogResult.OK)
			{
				this.Cursor = Cursors.WaitCursor;

				int t = 0;

				for (int i = _RowFixed; i < grdCFM.Rows.Count; i++)
				{
					if (grdCFM[i,0].ToString() != "")     //Update or Delete Check : Update
					{
						t = t + 1;
						try
						{
							SAVE_CFM_SCH(i);   //Save SDC_CFM_SCH & HISTORY
							grdCFM[i,0] = "";  //Clear Update/Delete Icon
						}
						catch (Exception Error)
						{
							MessageBox.Show(Error.Message);
							return;
						}
					}
				}

				if (t == 0)
				{
					MessageBox.Show("No save a data!!");
				}
				else
				{
					Show_grdCFM_Data();
					MessageBox.Show("Save completed [" + t.ToString() + "] Record !!");
				}

				this.Cursor = Cursors.Default;
			}
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			grdCFM.Delete_Row();
		}
		
		#endregion 

		#region 기타 이벤트

		/// <summary>
		/// Set_Action_Image : FlexGrid에 Set Action Image (I, D, U, C)
		/// COM >> FSP.cs에서 배열 추가로 인한 타 프로그램 문제로 여기서만 추가.
		/// </summary>
		/// <param name="arg_imglist">이미지 리스트</param>
		private void Set_Action_CFM_Image(ImageList arg_imglist)
		{
			Hashtable Imgmap = new Hashtable();
			try
			{
				Imgmap.Clear();

				Imgmap.Add("I", arg_imglist.Images[0]); 
				Imgmap.Add("D", arg_imglist.Images[1]);
				Imgmap.Add("U", arg_imglist.Images[2]);
				Imgmap.Add("C", arg_imglist.Images[3]);

				grdCFM.Cols[0].ImageMap     = Imgmap;
				grdCFM.Cols[0].ImageAndText = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Set_Action_Image",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}


		#endregion 

		#endregion 

		private void Form_CFM_Schedule_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btn_NewCFM_Click(object sender, System.EventArgs e)
		{
			Scheduling.Pop_CFM_Add CFMAddForm = new FlexCDC.Scheduling.Pop_CFM_Add(vQueryOK);
			CFMAddForm.ShowDialog();
		}

		private void btnSelStyle_Click(object sender, System.EventArgs e)
		{
			string vFactory = cmbFactory.SelectedValue.ToString();
			string vDPO_ID  = cmbDPO.SelectedValue.ToString();
			string vSeason  = cmbSeason.SelectedValue.ToString();
			string vStyleCD = txtStyle.Text.ToString();

            Scheduling.Pop_CFM_Select_Style CFMSelectForm = new FlexCDC.Scheduling.Pop_CFM_Select_Style(this, vQueryOK, vFactory, vDPO_ID, vSeason, vStyleCD);
			CFMSelectForm.ShowDialog();		
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			Show_grdCFM_Data();
		}

		private void Form_CFM_Schedule_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//Checking before close form, it is modified or nor by rows
			for (int i = _RowFixed; i < grdCFM.Rows.Count; i++)
			{
				if (grdCFM[i,0].ToString() != "")
				{
					DialogResult vOK = MessageBox.Show("EXIT OK? Do not save the data?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
					if (vOK == DialogResult.OK)
					{
						return;
					}
					else
					{
						break;
					}
				}
			}
		}

		private void grdCFM_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			//각 수정할 Row별 항목별(Ship Data, Category, Developer, Spec(Date:CFM), SBook(Date:CFM), CFMShoe(Date:CFM), Assembly Date, Remark)
			//Before 값 설정
			if (grdCFM.Cols[e.Col].Style != null)
			{
				if ((grdCFM.Rows.Fixed > 0) && (grdCFM.Row >= grdCFM.Rows.Fixed))
				{
					vBeforeVal = (grdCFM[e.Row, e.Col] == null) ? "" : grdCFM[e.Row, e.Col].ToString();
				}
			}
		}

		private void grdCFM_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
//			for (int i = grdCFM.Selection.r1; i <= grdCFM.Selection.r2; i++)
//			{
//				grdCFM[i, e.Col] = vBeforeVal;
//				grdCFM.Update_Row(i);
//				grdCFM.AutoSizeCols(i);
//			}
			grdCFM.Update_Row();
			grdCFM.AutoSizeCols();
		}

		private void mntCFMHistory_Click(object sender, System.EventArgs e)
		{
			// grdCFM DATA정의CFM History ShowDialog Column
			// (2) :Ship Date,  (5) TD Code         (9) :Category CD,   (11):Developer,    (12):Spec Date,
			// (13):Spec CFM,   (15):SBook Date,    (16):SBook CFM,     (18):CFMShoe Date,
			// (19):CFMShoe CFM,(20):Assembly Date1,(21):Assembly Date2,(22):CFM Remark,   (23):Factory CFM Remark
			if (grdCFM.Selection.c1 == 2  || grdCFM.Selection.c1 == 9  || grdCFM.Selection.c1 == 11 || grdCFM.Selection.c1 == 12 || 
				grdCFM.Selection.c1 == 13 || grdCFM.Selection.c1 == 15 || grdCFM.Selection.c1 == 16 || grdCFM.Selection.c1 == 18 || 
				grdCFM.Selection.c1 == 19 || grdCFM.Selection.c1 == 20 || grdCFM.Selection.c1 == 21 || grdCFM.Selection.c1 == 22 || 
				grdCFM.Selection.c1 == 23 )
			{
				//Factory, DPO, StyleNo, Model, Gender, Category, Qty, Developer, Item
				string vFactory = grdCFM[grdCFM.Row,1].ToString();
				string vDPO     = grdCFM[grdCFM.Row,4].ToString();
				string vStyleNo = grdCFM[grdCFM.Row,6].ToString();
				string vModel   = grdCFM[grdCFM.Row,7].ToString();
				string vGender  = grdCFM[grdCFM.Row,8].ToString();
				string vCate    = grdCFM[grdCFM.Row,9].ToString();
				string vQty     = grdCFM[grdCFM.Row,10].ToString();
				string vDev     = grdCFM[grdCFM.Row,11].ToString();
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

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.btnSave_Click(sender, e);
		}

		//Drop Style
		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			int sel_r1 = grdCFM.Selection.r1;
			int sel_r2 = grdCFM.Selection.r2;
			
			int start_row, end_row;

			try
			{
				start_row = (sel_r1 < sel_r2) ? sel_r1 : sel_r2;
				end_row   = (sel_r1 < sel_r2) ? sel_r2 : sel_r1;

				for(int i = start_row; i <= end_row; i++)
				{
					if (grdCFM[i, 24].ToString() == "Drop")
					{
						MessageBox.Show("Row ["+i.ToString()+"] : Already droped style.");
					}
					else
					{
						if (grdCFM[i, 0].ToString() != "I")
						{
							grdCFM[i, 0] = "C";
						}
					}
				} 
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Drop(Cancel)_Row",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			int sel_r1 = grdCFM.Selection.r1;
			int sel_r2 = grdCFM.Selection.r2;
			
			int start_row, end_row;

			try
			{
				start_row = (sel_r1 < sel_r2) ? sel_r1 : sel_r2;
				end_row   = (sel_r1 < sel_r2) ? sel_r2 : sel_r1;

				for(int i = start_row; i <= end_row; i++)
				{
					if (grdCFM[i,24].ToString() != "Drop")
					{
						MessageBox.Show("Row ["+i.ToString()+"] : is not a drop style. It's restored only a droped style.");
					}
					else
					{
						grdCFM[i, 0] = "I";
					}
				} 
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Drop(Cancel)_Row",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void lblSeason_Click(object sender, System.EventArgs e)
		{
		
		}

		private void txtStyle_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13)
			{
				if (txtStyle.Text.ToString().Trim() != "")
				{
					Show_grdCFM_Data(); 
				}
			}
		}

	}
}

