using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexPurchase.Incoming
{
	public class Pop_BI_Incomming_ChekcPrice : COM.PCHWinForm.Pop_Large
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_vendor;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_shipDate;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		public COM.FSP fgrid_Main;
		private System.ComponentModel.IContainer components = null;
		private int _RowFixed = 0;
		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction cfunction = null;
		private int factory_indx = 0;
		private string from_date = null;
		private string to_date = null;
		private System.Windows.Forms.Label lbl_chkdiv;
		private C1.Win.C1List.C1Combo cmb_chkdiv;
		private string cust_cd = null;
		private System.Windows.Forms.ContextMenu cMenu;
		private System.Windows.Forms.MenuItem menuItem4;
		private bool auto_search = false;
		private int	_vActiveCol		= 0;
		private int	_vActiveRow		= 0;
		private Hashtable _cellCombo = null;
		private Hashtable _cellData  = null;


		private int _custCdCol				= (int)ClassLib.TBSBI_IN_PURPRICE.IxCUST_CD;

		public Pop_BI_Incomming_ChekcPrice()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


		public Pop_BI_Incomming_ChekcPrice(int arg_factory_indx, string arg_from_date, string arg_to_date, string arg_cust_cd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			factory_indx = arg_factory_indx;
			from_date = arg_from_date;
			to_date = arg_to_date;
			cust_cd = arg_cust_cd;

			auto_search = true;

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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BI_Incomming_ChekcPrice));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_Main = new COM.FSP();
            this.cMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_chkdiv = new System.Windows.Forms.Label();
            this.cmb_chkdiv = new C1.Win.C1List.C1Combo();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_chkdiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(689, 4);
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
            this.lbl_MainTitle.Size = new System.Drawing.Size(912, 23);
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
            this.c1Sizer1.Controls.Add(this.fgrid_Main);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.GridDefinition = "13.5185185185185:False:True;82.5925925925926:False:False;0.925925925925926:False:" +
                "True;\t0.409836065573771:False:True;97.5409836065574:False:False;0.40983606557377" +
                "1:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(976, 540);
            this.c1Sizer1.TabIndex = 26;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Main.ContextMenu = this.cMenu;
            this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgrid_Main.Location = new System.Drawing.Point(12, 81);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Main.Size = new System.Drawing.Size(952, 446);
            this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Main.Styles"));
            this.fgrid_Main.TabIndex = 173;
            this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
            this.fgrid_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_Main_MouseUp);
            // 
            // cMenu
            // 
            this.cMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4});
            this.cMenu.Popup += new System.EventHandler(this.cMenu_Popup);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Value Exchange";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_chkdiv);
            this.panel1.Controls.Add(this.cmb_chkdiv);
            this.panel1.Controls.Add(this.lbl_vendor);
            this.panel1.Controls.Add(this.cmb_vendor);
            this.panel1.Controls.Add(this.cmb_factory);
            this.panel1.Controls.Add(this.lbl_factory);
            this.panel1.Controls.Add(this.lbl_shipDate);
            this.panel1.Controls.Add(this.lblexcep_mark);
            this.panel1.Controls.Add(this.dpick_to);
            this.panel1.Controls.Add(this.dpick_from);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 73);
            this.panel1.TabIndex = 170;
            // 
            // lbl_chkdiv
            // 
            this.lbl_chkdiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_chkdiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chkdiv.ImageIndex = 0;
            this.lbl_chkdiv.ImageList = this.img_Label;
            this.lbl_chkdiv.Location = new System.Drawing.Point(346, 37);
            this.lbl_chkdiv.Name = "lbl_chkdiv";
            this.lbl_chkdiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_chkdiv.TabIndex = 370;
            this.lbl_chkdiv.Text = "Check Div";
            this.lbl_chkdiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_chkdiv
            // 
            this.cmb_chkdiv.AddItemCols = 0;
            this.cmb_chkdiv.AddItemSeparator = ';';
            this.cmb_chkdiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_chkdiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_chkdiv.Caption = "";
            this.cmb_chkdiv.CaptionHeight = 17;
            this.cmb_chkdiv.CaptionStyle = style1;
            this.cmb_chkdiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_chkdiv.ColumnCaptionHeight = 18;
            this.cmb_chkdiv.ColumnFooterHeight = 18;
            this.cmb_chkdiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_chkdiv.ContentHeight = 16;
            this.cmb_chkdiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_chkdiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_chkdiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_chkdiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_chkdiv.EditorHeight = 16;
            this.cmb_chkdiv.EvenRowStyle = style2;
            this.cmb_chkdiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_chkdiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_chkdiv.FooterStyle = style3;
            this.cmb_chkdiv.GapHeight = 2;
            this.cmb_chkdiv.HeadingStyle = style4;
            this.cmb_chkdiv.HighLightRowStyle = style5;
            this.cmb_chkdiv.ItemHeight = 15;
            this.cmb_chkdiv.Location = new System.Drawing.Point(448, 37);
            this.cmb_chkdiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_chkdiv.MaxDropDownItems = ((short)(5));
            this.cmb_chkdiv.MaxLength = 32767;
            this.cmb_chkdiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_chkdiv.Name = "cmb_chkdiv";
            this.cmb_chkdiv.OddRowStyle = style6;
            this.cmb_chkdiv.PartialRightColumn = false;
            this.cmb_chkdiv.PropBag = resources.GetString("cmb_chkdiv.PropBag");
            this.cmb_chkdiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_chkdiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_chkdiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_chkdiv.SelectedStyle = style7;
            this.cmb_chkdiv.Size = new System.Drawing.Size(216, 20);
            this.cmb_chkdiv.Style = style8;
            this.cmb_chkdiv.TabIndex = 369;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(346, 15);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 368;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemCols = 0;
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style9;
            this.cmb_vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_vendor.ColumnCaptionHeight = 18;
            this.cmb_vendor.ColumnFooterHeight = 18;
            this.cmb_vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_vendor.ContentHeight = 16;
            this.cmb_vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_vendor.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_vendor.EditorHeight = 16;
            this.cmb_vendor.EvenRowStyle = style10;
            this.cmb_vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style11;
            this.cmb_vendor.GapHeight = 2;
            this.cmb_vendor.HeadingStyle = style12;
            this.cmb_vendor.HighLightRowStyle = style13;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(448, 15);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style14;
            this.cmb_vendor.PartialRightColumn = false;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style15;
            this.cmb_vendor.Size = new System.Drawing.Size(216, 20);
            this.cmb_vendor.Style = style16;
            this.cmb_vendor.TabIndex = 367;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style17;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 16;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 16;
            this.cmb_factory.Enabled = false;
            this.cmb_factory.EvenRowStyle = style18;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style19;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style20;
            this.cmb_factory.HighLightRowStyle = style21;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(110, 15);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style22;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style23;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style24;
            this.cmb_factory.TabIndex = 1;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 15);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 180;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipDate
            // 
            this.lbl_shipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipDate.ImageIndex = 1;
            this.lbl_shipDate.ImageList = this.img_Label;
            this.lbl_shipDate.Location = new System.Drawing.Point(8, 37);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 52;
            this.lbl_shipDate.Text = "Incoming Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(216, 37);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(8, 16);
            this.lblexcep_mark.TabIndex = 178;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Enabled = false;
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(230, 37);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 5;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Enabled = false;
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(110, 37);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 4;
            // 
            // Pop_BI_Incomming_ChekcPrice
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(976, 606);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BI_Incomming_ChekcPrice";
            this.Load += new System.EventHandler(this.Pop_BI_Incomming_ChekcPrice_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_chkdiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Pop_BI_Incomming_ChekcPrice_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		private void Init_Form()
		{
			cfunction = new COM.ComFunction();
			lbl_MainTitle.Text = "Purchase Price Check";
            this.Text = "Purchase Price Check";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			fgrid_Main.Set_Grid("SBI_IN_PURPRICE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Main.Set_Action_Image(img_Action);
			fgrid_Main.ExtendLastCol = false;
			_RowFixed = fgrid_Main.Rows.Count;

			// Factory Combobox Setting
//			DataTable vDt = null;
//			vDt = COM.ComFunction.Select_Factory_List();
//			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, true);
//			vDt.Dispose();
//			cmb_factory.SelectedIndex = factory_indx;


		

            //vDt = FlexPurchase.ClassLib.ComFunction.Select_Data_List(ClassLib.ComVar.This_Factory , "SBI06");
            DataTable vDt = null;
            vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBI06");
            COM.ComCtl.Set_ComboList(vDt, cmb_factory, 1, 1, false, false);
            cmb_factory.SelectedIndex = factory_indx;
          
			




			dpick_from.Text = cfunction.ConvertDate2Type(from_date);
			dpick_to.Text = cfunction.ConvertDate2Type(to_date);


			Set_Vendor(cust_cd);


			vDt = new DataTable("Combo List"); 
			DataRow newrow; 

			vDt.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
			vDt.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
				
			

			newrow = vDt.NewRow();
			newrow["Code"] = "O";
			newrow["Name"] = "Another Month Check";
			vDt.Rows.Add(newrow);
			
			newrow = vDt.NewRow();
			newrow["Code"] = "N";
			newrow["Name"] = "Same Month Check";
			vDt.Rows.Add(newrow);

			COM.ComCtl.Set_ComboList(vDt, cmb_chkdiv, 0, 1, false);
			cmb_chkdiv.SelectedIndex = 0;


			_cellData  = new Hashtable(fgrid_Main.Cols.Count);
			_cellCombo = new Hashtable(fgrid_Main.Cols.Count);
			IDictionary vDic = null;
			IEnumerator vEnum  = null;
			IEnumerator vEnum2 = null;
			string[] vTemp = null;
			string[] vData = null;

			for (int vCol = 1, vCnt = 0 ; vCol < fgrid_Main.Cols.Count ; vCol++)
			{
				if (fgrid_Main.Cols[vCol].AllowEditing)
				{
					if (fgrid_Main.Cols[vCol].DataMap != null)
					{
						vDic = fgrid_Main.Cols[vCol].DataMap;
						vTemp = new string[vDic.Count];
						vData = new string[vDic.Count];
						vEnum  = vDic.Values.GetEnumerator();
						vEnum2 = vDic.Keys.GetEnumerator();
						while (vEnum.MoveNext())
							vTemp[vCnt++] = vEnum.Current.ToString();

						vCnt = 0;
						_cellCombo.Add(vCol, vTemp);

						while (vEnum2.MoveNext())
							vData[vCnt++] = vEnum2.Current.ToString();

						vCnt = 0;
						_cellData.Add(vCol, vData);
					}
				}
			}


			if(auto_search)
			{
				Seach_Data();
			}
			
		}

		private DataTable Select_Sbi_In_Vendor()
		{
			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST.SELECT_SBI_IN_VENDOR";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_FROM";
			MyOraDB.Parameter_Name[2]  = "ARG_TO";
			MyOraDB.Parameter_Name[3]  = "ARG_LOC_FACTORY";
			MyOraDB.Parameter_Name[4]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]  = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = cfunction.ConvertDate2DbType(dpick_from.Text);
			MyOraDB.Parameter_Values[2]  = cfunction.ConvertDate2DbType(dpick_to.Text);
			MyOraDB.Parameter_Values[3]  = ClassLib.ComVar.This_Factory;
			MyOraDB.Parameter_Values[4]  = "";
		
			MyOraDB.Add_Select_Parameter(true);
			DataSet vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		private DataTable Select_Sbi_In_CheckData()
		{
			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST.SELECT_SBI_IN_CHECKDATA";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_FROM";
			MyOraDB.Parameter_Name[2]  = "ARG_TO";
			MyOraDB.Parameter_Name[3]  = "ARG_VENDOR";
			MyOraDB.Parameter_Name[4]  = "ARG_DIV";
			MyOraDB.Parameter_Name[5]  = "ARG_LOC_FACTORY";
			MyOraDB.Parameter_Name[6]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]  = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1]  = cfunction.ConvertDate2DbType(dpick_from.Text);
			MyOraDB.Parameter_Values[2]  = cfunction.ConvertDate2DbType(dpick_to.Text);
			MyOraDB.Parameter_Values[3]  = cmb_vendor.SelectedValue.ToString();
			MyOraDB.Parameter_Values[4]  = cmb_chkdiv.SelectedValue.ToString();
			MyOraDB.Parameter_Values[5]  = ClassLib.ComVar.This_Factory;
			MyOraDB.Parameter_Values[6]  = "";
		
			MyOraDB.Add_Select_Parameter(true);
			DataSet vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		private void Seach_Data()
		{
			this.Cursor = Cursors.WaitCursor;
			if(cmb_vendor.SelectedIndex == -1)  return;
			fgrid_Main.Rows.Count = _RowFixed;
			DataTable dt = Select_Sbi_In_CheckData();

			int dt_rows = dt.Rows.Count;
			int dt_cols = dt.Columns.Count;

			for(int i=0; i<dt_rows; i++)
			{
				fgrid_Main.AddItem(dt.Rows[i].ItemArray, _RowFixed, 0);
			}
			this.Cursor = Cursors.Default;
		}

		private void Set_Vendor(string arg_vencd)
		{
			DataTable vDt = Select_Sbi_In_Vendor();
			COM.ComCtl.Set_ComboList(vDt, cmb_vendor, 0, 1, true);
			vDt.Dispose();
			if(vDt.Rows.Count > 0)
			{
				if(arg_vencd.Trim().Length > 0)
				{
					cmb_vendor.SelectedValue = arg_vencd;
				}
				else
				{
					cmb_vendor.SelectedIndex = 0;
				}
			}
			else
			{
				cmb_vendor.SelectedIndex = -1;
			}
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Seach_Data();
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Init_Form();
		}

		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			int sct_row = fgrid_Main.Selection.r1;
			fgrid_Main.Update_Row(sct_row);
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Save_Grid();
		}

		private void Save_Grid()
		{
			for(int i=_RowFixed; i<fgrid_Main.Rows.Count; i++)
			{
				if(fgrid_Main[i, (int)ClassLib.TBSBI_IN_PURPRICE.IxDIVISION].ToString() == "U")
				{
					string arg_factory = fgrid_Main[i, (int)ClassLib.TBSBI_IN_PURPRICE.IxFACTORY].ToString();
					string arg_in_no   = fgrid_Main[i, (int)ClassLib.TBSBI_IN_PURPRICE.IxIN_NO].ToString();
					string arg_in_seq  = fgrid_Main[i, (int)ClassLib.TBSBI_IN_PURPRICE.IxIN_SEQ].ToString();
					string arg_price   = fgrid_Main[i, (int)ClassLib.TBSBI_IN_PURPRICE.IxNEW_PUR_PRICE].ToString();

					Save_Sbi_In_Price(arg_factory, arg_in_no, arg_in_seq, arg_price);

				}
			}

			Seach_Data();
		}


		/// <summary>
		/// SAVE_SBI_IN_HEAD_SIZE : SIZE 정보 저장
		/// </summary>
		private void Save_Sbi_In_Price(string arg_factory, string arg_in_no, string arg_in_seq, string arg_pur_price)
		{
			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST.SAVE_SBI_IN_PRICE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_IN_NO";
			MyOraDB.Parameter_Name[2]  = "ARG_IN_SEQ";
			MyOraDB.Parameter_Name[3]  = "ARG_PUR_PRICE";
			MyOraDB.Parameter_Name[4]  = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;

			//04.DATA 정의

			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_in_no;
			MyOraDB.Parameter_Values[2] = arg_in_seq;
			MyOraDB.Parameter_Values[3] = arg_pur_price;
			MyOraDB.Parameter_Values[4] = COM.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				int vCol = _vActiveCol; 
				ClassLib.ComVar.Parameter_PopUp_Object  = null;
				ClassLib.ComVar.Parameter_PopUp_Object2 = null;
				ClassLib.ComVar.Parameter_PopUpTable	= null; 

				int[] vSelectionRange = fgrid_Main.Selections;

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp		= new string[1];
					COM.ComVar.Parameter_PopUp[0]	= fgrid_Main[1, vCol].ToString();

				
					if (_cellCombo.ContainsKey(vCol))
					{
						ClassLib.ComVar.Parameter_PopUp_Object  = new object[]{_cellData[vCol]};
						ClassLib.ComVar.Parameter_PopUp_Object2 = new object[]{_cellCombo[vCol]};
					}
					Pop_BI_Incoming_List_Changer pop_changer = new Pop_BI_Incoming_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
						foreach (int i in vSelectionRange)
						{
							if ( fgrid_Main.Rows[i].AllowEditing )
							{
								fgrid_Main[i, vCol] = COM.ComVar.Parameter_PopUp[0];
								if( vCol.Equals(_custCdCol) )
								{
									fgrid_Main[i, vCol +1]	= COM.ComVar.Parameter_PopUp[0];    // Set Vendor Name Text
							
									if (COM.ComVar.Parameter_PopUp.Length > 1)
										fgrid_Main[i, vCol]		= COM.ComVar.Parameter_PopUp[1];// Set Vendor Code Value
								}
								else
								{
									fgrid_Main[i, vCol]		= COM.ComVar.Parameter_PopUp[0];    // Set TextBox Text
							
									if (COM.ComVar.Parameter_PopUp.Length > 1)
										fgrid_Main[i, vCol]		= COM.ComVar.Parameter_PopUp[1];	// Set SSPComboBox Value
								}

								fgrid_Main.Update_Row(i);
							}
						}
					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_ValueExchange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void fgrid_Main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed)
			{
				_vActiveCol = fgrid_Main.Cols[fgrid_Main.Col].Index; 
				_vActiveRow = fgrid_Main.Rows[fgrid_Main.Row].Index; 
				//Set_MenuItem_Visible();
				
				//this.cmenu_Adjust.Show(fgrid_main, new Point(e.X, e.Y));

			}
		}

		private void cMenu_Popup(object sender, System.EventArgs e)
		{
		
		}
	}
}

