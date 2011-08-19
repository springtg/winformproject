using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FarPoint.Win.Spread.Model;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Shipping_List_Schedule_2 : COM.PCHWinForm.Pop_Medium
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Label lbl_shipDate;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label btn_shipping;
		private System.Windows.Forms.Label lbl_obsType;
		private C1.Win.C1List.C1Combo cmb_obsType;
		private System.Windows.Forms.ContextMenu ctx_grid;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_allDeselect;
		private System.Windows.Forms.GroupBox groupBox1;
		private C1.Win.C1List.C1Combo cmb_ShipType;
		private System.Windows.Forms.Label lbl_ShipType;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private int _shipNoCol		= (int)ClassLib.TBSBM_MRP_INFO_TEST.IxMRP_SHIP_NO;
		private int _shippingYNCol	= (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSHIP_YN;
		private int _styleCol		= (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSTYLE_NAME;
		private int _styleCdCol		= (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSTYLE_CD;
		private int _styleQtyCol	= (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSTYLE_QTY;
		private int _yieldCol		= (int)ClassLib.TBSBM_MRP_INFO_TEST.IxYIELD_COUNT;

		private Thread _createThread;
		Pop_BS_Shipping_List_Wait _pop;

		private string pkg_upper	= "PKG_SBS_SHIPPING_LIST_UPPER_2.MAKE_SHIPPING_LIST_UPPER";
		private C1.Win.C1List.C1Combo cmb_reason;
		private System.Windows.Forms.Label lbl_reason;
		private C1.Win.C1List.C1Combo cmb_StyleItemDiv;
		private System.Windows.Forms.Label lbl_StyleItemDiv;
        private System.Windows.Forms.Label btn_PurchaseList;
		private string pkg_sole		= "PKG_SBS_SHIPPING_LIST_SOLE.MAKE_SHIPPING_LIST_SOLE";

		#endregion

		#region 생성자 / 소멸자

		public Pop_BS_Shipping_List_Schedule_2()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Shipping_List_Schedule_2));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_shipping = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_PurchaseList = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.cmb_ShipType = new C1.Win.C1List.C1Combo();
            this.cmb_obsType = new C1.Win.C1List.C1Combo();
            this.cmb_reason = new C1.Win.C1List.C1Combo();
            this.lbl_ShipType = new System.Windows.Forms.Label();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.lbl_reason = new System.Windows.Forms.Label();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Label();
            this.lbl_obsType = new System.Windows.Forms.Label();
            this.cmb_StyleItemDiv = new C1.Win.C1List.C1Combo();
            this.lbl_StyleItemDiv = new System.Windows.Forms.Label();
            this.ctx_grid = new System.Windows.Forms.ContextMenu();
            this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
            this.mnu_allDeselect = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleItemDiv)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
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
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
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
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.panel3);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.Controls.Add(this.groupBox1);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
            this.c1Sizer1.TabIndex = 27;
            this.c1Sizer1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_shipping);
            this.panel3.Location = new System.Drawing.Point(8, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 29);
            this.panel3.TabIndex = 168;
            // 
            // btn_shipping
            // 
            this.btn_shipping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shipping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_shipping.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_shipping.ImageIndex = 0;
            this.btn_shipping.ImageList = this.img_Button;
            this.btn_shipping.Location = new System.Drawing.Point(607, 3);
            this.btn_shipping.Name = "btn_shipping";
            this.btn_shipping.Size = new System.Drawing.Size(71, 23);
            this.btn_shipping.TabIndex = 353;
            this.btn_shipping.Text = "Create";
            this.btn_shipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_shipping.Click += new System.EventHandler(this.btn_shipping_Click);
            this.btn_shipping.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_shipping_MouseDown);
            this.btn_shipping.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_shipping_MouseUp);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.spd_main);
            this.pnl_main.Location = new System.Drawing.Point(8, 97);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(678, 290);
            this.pnl_main.TabIndex = 166;
            // 
            // spd_main
            // 
            this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(678, 290);
            this.spd_main.TabIndex = 0;
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_PurchaseList);
            this.groupBox1.Controls.Add(this.dpick_to);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.cmb_ShipType);
            this.groupBox1.Controls.Add(this.cmb_obsType);
            this.groupBox1.Controls.Add(this.cmb_reason);
            this.groupBox1.Controls.Add(this.lbl_ShipType);
            this.groupBox1.Controls.Add(this.dpick_from);
            this.groupBox1.Controls.Add(this.lbl_factory);
            this.groupBox1.Controls.Add(this.lblexcep_mark);
            this.groupBox1.Controls.Add(this.lbl_reason);
            this.groupBox1.Controls.Add(this.lbl_shipDate);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.lbl_obsType);
            this.groupBox1.Controls.Add(this.cmb_StyleItemDiv);
            this.groupBox1.Controls.Add(this.lbl_StyleItemDiv);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 93);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // btn_PurchaseList
            // 
            this.btn_PurchaseList.ImageIndex = 27;
            this.btn_PurchaseList.ImageList = this.img_SmallButton;
            this.btn_PurchaseList.Location = new System.Drawing.Point(308, 38);
            this.btn_PurchaseList.Name = "btn_PurchaseList";
            this.btn_PurchaseList.Size = new System.Drawing.Size(24, 21);
            this.btn_PurchaseList.TabIndex = 187;
            this.btn_PurchaseList.Tag = "Search";
            this.btn_PurchaseList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PurchaseList.Click += new System.EventHandler(this.btn_PurchaseList_Click);
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(220, 38);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(90, 21);
            this.dpick_to.TabIndex = 5;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style1;
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
            this.cmb_factory.EvenRowStyle = style2;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style3;
            this.cmb_factory.HeadingStyle = style4;
            this.cmb_factory.HighLightRowStyle = style5;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 16);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style6;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style7;
            this.cmb_factory.Size = new System.Drawing.Size(200, 20);
            this.cmb_factory.Style = style8;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // cmb_ShipType
            // 
            this.cmb_ShipType.AddItemSeparator = ';';
            this.cmb_ShipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ShipType.Caption = "";
            this.cmb_ShipType.CaptionHeight = 17;
            this.cmb_ShipType.CaptionStyle = style9;
            this.cmb_ShipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ShipType.ColumnCaptionHeight = 18;
            this.cmb_ShipType.ColumnFooterHeight = 18;
            this.cmb_ShipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ShipType.ContentHeight = 16;
            this.cmb_ShipType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ShipType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ShipType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_ShipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ShipType.EditorHeight = 16;
            this.cmb_ShipType.EvenRowStyle = style10;
            this.cmb_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ShipType.FooterStyle = style11;
            this.cmb_ShipType.HeadingStyle = style12;
            this.cmb_ShipType.HighLightRowStyle = style13;
            this.cmb_ShipType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_ShipType.Images"))));
            this.cmb_ShipType.ItemHeight = 15;
            this.cmb_ShipType.Location = new System.Drawing.Point(440, 16);
            this.cmb_ShipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_ShipType.MaxDropDownItems = ((short)(5));
            this.cmb_ShipType.MaxLength = 32767;
            this.cmb_ShipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ShipType.Name = "cmb_ShipType";
            this.cmb_ShipType.OddRowStyle = style14;
            this.cmb_ShipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ShipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ShipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ShipType.SelectedStyle = style15;
            this.cmb_ShipType.Size = new System.Drawing.Size(200, 20);
            this.cmb_ShipType.Style = style16;
            this.cmb_ShipType.TabIndex = 3;
            this.cmb_ShipType.PropBag = resources.GetString("cmb_ShipType.PropBag");
            // 
            // cmb_obsType
            // 
            this.cmb_obsType.AddItemSeparator = ';';
            this.cmb_obsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_obsType.Caption = "";
            this.cmb_obsType.CaptionHeight = 17;
            this.cmb_obsType.CaptionStyle = style17;
            this.cmb_obsType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_obsType.ColumnCaptionHeight = 18;
            this.cmb_obsType.ColumnFooterHeight = 18;
            this.cmb_obsType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_obsType.ContentHeight = 16;
            this.cmb_obsType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_obsType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_obsType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_obsType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_obsType.EditorHeight = 16;
            this.cmb_obsType.EvenRowStyle = style18;
            this.cmb_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obsType.FooterStyle = style19;
            this.cmb_obsType.HeadingStyle = style20;
            this.cmb_obsType.HighLightRowStyle = style21;
            this.cmb_obsType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_obsType.Images"))));
            this.cmb_obsType.ItemHeight = 15;
            this.cmb_obsType.Location = new System.Drawing.Point(109, 60);
            this.cmb_obsType.MatchEntryTimeout = ((long)(2000));
            this.cmb_obsType.MaxDropDownItems = ((short)(5));
            this.cmb_obsType.MaxLength = 32767;
            this.cmb_obsType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_obsType.Name = "cmb_obsType";
            this.cmb_obsType.OddRowStyle = style22;
            this.cmb_obsType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_obsType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_obsType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_obsType.SelectedStyle = style23;
            this.cmb_obsType.Size = new System.Drawing.Size(200, 20);
            this.cmb_obsType.Style = style24;
            this.cmb_obsType.TabIndex = 185;
            this.cmb_obsType.PropBag = resources.GetString("cmb_obsType.PropBag");
            // 
            // cmb_reason
            // 
            this.cmb_reason.AddItemSeparator = ';';
            this.cmb_reason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reason.Caption = "";
            this.cmb_reason.CaptionHeight = 17;
            this.cmb_reason.CaptionStyle = style25;
            this.cmb_reason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reason.ColumnCaptionHeight = 18;
            this.cmb_reason.ColumnFooterHeight = 18;
            this.cmb_reason.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reason.ContentHeight = 16;
            this.cmb_reason.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reason.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_reason.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reason.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reason.EditorHeight = 16;
            this.cmb_reason.EvenRowStyle = style26;
            this.cmb_reason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reason.FooterStyle = style27;
            this.cmb_reason.HeadingStyle = style28;
            this.cmb_reason.HighLightRowStyle = style29;
            this.cmb_reason.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_reason.Images"))));
            this.cmb_reason.ItemHeight = 15;
            this.cmb_reason.Location = new System.Drawing.Point(440, 38);
            this.cmb_reason.MatchEntryTimeout = ((long)(2000));
            this.cmb_reason.MaxDropDownItems = ((short)(5));
            this.cmb_reason.MaxLength = 32767;
            this.cmb_reason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reason.Name = "cmb_reason";
            this.cmb_reason.OddRowStyle = style30;
            this.cmb_reason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reason.SelectedStyle = style31;
            this.cmb_reason.Size = new System.Drawing.Size(200, 20);
            this.cmb_reason.Style = style32;
            this.cmb_reason.TabIndex = 28;
            this.cmb_reason.SelectedValueChanged += new System.EventHandler(this.cmb_reason_SelectedValueChanged);
            this.cmb_reason.PropBag = resources.GetString("cmb_reason.PropBag");
            // 
            // lbl_ShipType
            // 
            this.lbl_ShipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShipType.ImageIndex = 1;
            this.lbl_ShipType.ImageList = this.img_Label;
            this.lbl_ShipType.Location = new System.Drawing.Point(340, 16);
            this.lbl_ShipType.Name = "lbl_ShipType";
            this.lbl_ShipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_ShipType.TabIndex = 183;
            this.lbl_ShipType.Text = "Ship Type";
            this.lbl_ShipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 38);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(90, 21);
            this.dpick_from.TabIndex = 4;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 16);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 180;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(201, 40);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(16, 16);
            this.lblexcep_mark.TabIndex = 178;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_reason
            // 
            this.lbl_reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reason.ImageIndex = 0;
            this.lbl_reason.ImageList = this.img_Label;
            this.lbl_reason.Location = new System.Drawing.Point(340, 38);
            this.lbl_reason.Name = "lbl_reason";
            this.lbl_reason.Size = new System.Drawing.Size(100, 21);
            this.lbl_reason.TabIndex = 177;
            this.lbl_reason.Text = "Request Reason";
            this.lbl_reason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipDate
            // 
            this.lbl_shipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipDate.ImageIndex = 1;
            this.lbl_shipDate.ImageList = this.img_Label;
            this.lbl_shipDate.Location = new System.Drawing.Point(8, 38);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 52;
            this.lbl_shipDate.Text = "Ship Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(640, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 21);
            this.btn_search.TabIndex = 184;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseDown);
            this.btn_search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseUp);
            // 
            // lbl_obsType
            // 
            this.lbl_obsType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obsType.ImageIndex = 0;
            this.lbl_obsType.ImageList = this.img_Label;
            this.lbl_obsType.Location = new System.Drawing.Point(8, 60);
            this.lbl_obsType.Name = "lbl_obsType";
            this.lbl_obsType.Size = new System.Drawing.Size(100, 21);
            this.lbl_obsType.TabIndex = 186;
            this.lbl_obsType.Text = "Order Type";
            this.lbl_obsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_StyleItemDiv
            // 
            this.cmb_StyleItemDiv.AddItemSeparator = ';';
            this.cmb_StyleItemDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleItemDiv.Caption = "";
            this.cmb_StyleItemDiv.CaptionHeight = 17;
            this.cmb_StyleItemDiv.CaptionStyle = style33;
            this.cmb_StyleItemDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_StyleItemDiv.ColumnCaptionHeight = 18;
            this.cmb_StyleItemDiv.ColumnFooterHeight = 18;
            this.cmb_StyleItemDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_StyleItemDiv.ContentHeight = 16;
            this.cmb_StyleItemDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_StyleItemDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_StyleItemDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_StyleItemDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_StyleItemDiv.EditorHeight = 16;
            this.cmb_StyleItemDiv.EvenRowStyle = style34;
            this.cmb_StyleItemDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StyleItemDiv.FooterStyle = style35;
            this.cmb_StyleItemDiv.HeadingStyle = style36;
            this.cmb_StyleItemDiv.HighLightRowStyle = style37;
            this.cmb_StyleItemDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_StyleItemDiv.Images"))));
            this.cmb_StyleItemDiv.ItemHeight = 15;
            this.cmb_StyleItemDiv.Location = new System.Drawing.Point(440, 60);
            this.cmb_StyleItemDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleItemDiv.MaxDropDownItems = ((short)(5));
            this.cmb_StyleItemDiv.MaxLength = 32767;
            this.cmb_StyleItemDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleItemDiv.Name = "cmb_StyleItemDiv";
            this.cmb_StyleItemDiv.OddRowStyle = style38;
            this.cmb_StyleItemDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleItemDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleItemDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleItemDiv.SelectedStyle = style39;
            this.cmb_StyleItemDiv.Size = new System.Drawing.Size(200, 20);
            this.cmb_StyleItemDiv.Style = style40;
            this.cmb_StyleItemDiv.TabIndex = 28;
            this.cmb_StyleItemDiv.SelectedValueChanged += new System.EventHandler(this.cmb_StyleItemDiv_SelectedValueChanged);
            this.cmb_StyleItemDiv.PropBag = resources.GetString("cmb_StyleItemDiv.PropBag");
            // 
            // lbl_StyleItemDiv
            // 
            this.lbl_StyleItemDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_StyleItemDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StyleItemDiv.ImageIndex = 0;
            this.lbl_StyleItemDiv.ImageList = this.img_Label;
            this.lbl_StyleItemDiv.Location = new System.Drawing.Point(340, 60);
            this.lbl_StyleItemDiv.Name = "lbl_StyleItemDiv";
            this.lbl_StyleItemDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_StyleItemDiv.TabIndex = 177;
            this.lbl_StyleItemDiv.Text = "Item Division";
            this.lbl_StyleItemDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctx_grid
            // 
            this.ctx_grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_AllSelect,
            this.mnu_allDeselect});
            // 
            // mnu_AllSelect
            // 
            this.mnu_AllSelect.Index = 0;
            this.mnu_AllSelect.Text = "All Select";
            this.mnu_AllSelect.Click += new System.EventHandler(this.mnu_AllSelect_Click);
            // 
            // mnu_allDeselect
            // 
            this.mnu_allDeselect.Index = 1;
            this.mnu_allDeselect.Text = "All Deselect";
            this.mnu_allDeselect.Click += new System.EventHandler(this.mnu_allDeselect_Click);
            // 
            // Pop_BS_Shipping_List_Schedule_2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 471);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BS_Shipping_List_Schedule_2";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleItemDiv)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader && e.Button == MouseButtons.Right)
				ctx_grid.Show(spd_main, new Point(e.X, e.Y));
		}
		
		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{
			int vRow = spd_main.Sheets[0].ActiveRowIndex;
			int vCol = spd_main.Sheets[0].ActiveColumnIndex;
			
			if (spd_main.Sheets[0].Cells[vRow, vCol].Value == null || spd_main.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			spd_main.Buffer_CellData = spd_main.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = spd_main.Sheets[0].Columns[vCol].CellType.ToString();
			if (vTemp == "CheckBoxCellType" || vTemp == "SSPComboBoxCellType")
			{
				spd_main.Buffer_CellData = "000";
				spd_main.Update_Row(img_Action);
			}		
		}

		#endregion

		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
            this.Btn_SearchClickProcess();		
		}

		private void btn_PurchaseList_Click(object sender, System.EventArgs e)
		{
			this.Btn_PurchaseReport();
		}

		private void btn_shipping_Click(object sender, System.EventArgs e)
		{
			_pop = new Pop_BS_Shipping_List_Wait();
			_createThread = new Thread(new ThreadStart(this.Btn_ShippingClickProcess));
			_createThread.Start();
			_pop.Closed += new EventHandler(Pop_WaitClosing);
            _pop.ShowDialog();			
		}

		private void Pop_WaitClosing(object sender, System.EventArgs e)
		{
			if (this.DialogResult == DialogResult.OK)
			{
				ClassLib.ComFunction.User_Message("Shipping List Create Complete", "Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Owner.Activate();
				this.Close();
			}
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			this.dpick_to.Value = this.dpick_from.Value;
		}

		private void cmb_reason_SelectedValueChanged(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
		}

		private void cmb_StyleItemDiv_SelectedValueChanged(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
		}

		private void mnu_allDeselect_Click(object sender, System.EventArgs e)
		{
			int vEnd = _mainSheet.RowCount;

			for (int vRow = 0 ; vRow < vEnd ; vRow++)
			{
				if (!_mainSheet.Rows[vRow].Locked)
				{
					_mainSheet.Cells[vRow, _shippingYNCol].Value = false;
				}
			}

			spd_main.Refresh_Division();
		}

		private void mnu_AllSelect_Click(object sender, System.EventArgs e)
		{
			int vEnd = _mainSheet.RowCount;

			for (int vRow = 0 ; vRow < vEnd ; vRow++)
			{
				if (!_mainSheet.Rows[vRow].Locked)
				{
					_mainSheet.Cells[vRow, _shippingYNCol].Value = true;
					spd_main.Update_Row(vRow, img_Action);
				}
			}
		}

		#region 입력이동

		#endregion

		#region 버튼효과

		private void btn_search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 26;
		}

		private void btn_search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 27;
		}

		private void btn_shipping_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_shipping_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		#endregion

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
            // ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Shipping Schedule";
            this.Text = "Shipping Schedule";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SBM_MRP_INFO_TEST", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			// user define variable setting
			_mainSheet = spd_main.Sheets[0];

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();

			// ship type 
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
			COM.ComCtl.Set_ComboList(vDt, cmb_ShipType, 1, 2, false);
			cmb_ShipType.SelectedIndex = 0;
			vDt.Dispose();

			// Request Reason
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_reason, 1, 2, false);
			cmb_reason.SelectedIndex = 0;
			vDt.Dispose();

			// cmb_styleitemdiv (Upper, Buttom)
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPItemDivision);
			COM.ComCtl.Set_ComboList(vDt, cmb_StyleItemDiv, 1, 2, false);
			cmb_StyleItemDiv.SelectedIndex = 0;
			vDt.Dispose();

			// obs type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SEM10");
			COM.ComCtl.Set_ComboList(vDt, cmb_obsType, 1, 2, true, 80, 140);
			cmb_obsType.SelectedIndex = 0;
			vDt.Dispose();

			// default search proviso
			cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
			this.dpick_from.Value = ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[5]);
			this.dpick_to.Value = ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[5]);
		}

		private void Btn_SearchClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = this.SELECT_MRP_INFORMATION();
				spd_main.Display_Grid(vDt);
				for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
				{
					if ((bool)_mainSheet.Cells[vRow, _shippingYNCol].Value)
					{
						_mainSheet.Rows[vRow].Locked = true;
					}
					else
					{
						_mainSheet.Rows[vRow].Locked = false;
					}
				}

				if (vDt.Rows.Count > 0)
				{
					Grid_SetColor();
					ClassLib.ComFunction.MergeCell(spd_main, new int[]{_shipNoCol, _styleCdCol, _styleCol, _styleQtyCol});
					vDt.Dispose();
				}				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Grid_SetColor()
		{
			_mainSheet.Cells[0, 1, _mainSheet.RowCount - 1, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSHIP_YN].BackColor = Color.FromArgb(245, 245, 220);

			for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
			{
                string vTemp = ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, _yieldCol].Value);
				
				if (vTemp.Equals("0"))
				{
					_mainSheet.Rows[vRow].ForeColor = Color.Red;
					//_mainSheet.Cells[vRow, 1, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightPink2;
				}
				else
				{
					bool vLocked = Convert.ToBoolean(ClassLib.ComFunction.NullCheck(_mainSheet.Cells[vRow, _shippingYNCol].Value, "false"));

					if (!ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxATTRIBUTE].Value).Equals("S"))
					{
						_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSHIP_YN, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightBlue;
					}
					else
					{
						_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSHIP_YN, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightPink2;
					}

					if (vLocked)
					{
						_mainSheet.Cells[vRow, 2, vRow, _mainSheet.ColumnCount - 1].ForeColor = Color.Gray;
					}
					else
					{
						_mainSheet.Cells[vRow, 2, vRow, _mainSheet.ColumnCount - 1].ForeColor = Color.Black;
					}
				}
			}
		}

		private void Btn_ShippingClickProcess()
		{
			try
			{
				string vPkg = null;

				this.Cursor = Cursors.WaitCursor;
				_pop.Processing();

				if (!SAVE_SHIPPING_SCHEDULE_TEMP())
				{
					this.DialogResult = DialogResult.Abort;
					return;
				}

				// 임시
				// MyOraDB.Exe_Modify_Procedure();

				if (cmb_StyleItemDiv.SelectedValue.ToString().Equals("10") || cmb_StyleItemDiv.SelectedValue.ToString().Equals("30"))
					vPkg = pkg_upper;
				else
					vPkg = pkg_sole;
				
				if (!MAKE_SHIPPING_LIST(vPkg))
				{
					this.DialogResult = DialogResult.Abort;
					return;
				}
				
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_ShippingClickProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				_pop.Close();
			}
		}

		private void Btn_PurchaseReport()
		{
				
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_Purchase_Information");
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 5;
			string [] aHead =  new string[iCnt];	
			aHead[0] = COM.ComVar.This_Factory;
			aHead[1] = ClassLib.ComFunction.Empty_Combo(this.cmb_factory, "");
			aHead[2] = ClassLib.ComFunction.Empty_Combo(this.cmb_ShipType, "");
			aHead[3] = this.dpick_from.Text.Replace("-", "");
			aHead[4] = this.dpick_from.Text.Replace("-", "");
		
			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();	

		}

		#endregion

		#region DB Connect

		/// <summary>
		/// PKG_SBS_SHIPPING_LIST : MRP 데이터 검색
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_MRP_INFORMATION()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(9);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.SELECT_MRP_INFORMATION_TEST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_REQUEST_REASON";
			MyOraDB.Parameter_Name[5] = "ARG_STYLE_ITEM_DIV";
			MyOraDB.Parameter_Name[6] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[7] = "ARG_TRANSFER_TYPE";
			MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_ShipType, "");
			MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_reason, "");
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_Combo(cmb_StyleItemDiv, "");
			MyOraDB.Parameter_Values[6] = COM.ComFunction.Empty_Combo(cmb_obsType, "");
			MyOraDB.Parameter_Values[7] = "";
			MyOraDB.Parameter_Values[8] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBS_SHIPPING_LIST : 선적 대상 임시 테이블에 저장
		/// </summary>
		public bool SAVE_SHIPPING_SCHEDULE_TEMP()
		{
			try
			{
				MyOraDB.ReDim_Parameter(23);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.SAVE_SHIPPING_SCHEDULE_TEST";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[3] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[5] = "ARG_STYLE_NAME";
				MyOraDB.Parameter_Name[6] = "ARG_STYLE_QTY";
				MyOraDB.Parameter_Name[7] = "ARG_LOT_QTY";
				MyOraDB.Parameter_Name[8] = "ARG_SHIP_YN";
				MyOraDB.Parameter_Name[9] = "ARG_YIELD_COUNT";
				MyOraDB.Parameter_Name[10] = "ARG_SHIPPING_COUNT_UPPER";
				MyOraDB.Parameter_Name[11] = "ARG_SHIPPING_COUNT_BUTTOM";
				MyOraDB.Parameter_Name[12] = "ARG_SHIPPING_COUNT_OTHER";
				MyOraDB.Parameter_Name[13] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[14] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[15] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[16] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[17] = "ARG_STYLE_ITEM_DIV";
				MyOraDB.Parameter_Name[18] = "ARG_REQUEST_REASON";
				MyOraDB.Parameter_Name[19] = "ARG_MOVE_TYPE";
				MyOraDB.Parameter_Name[20] = "ARG_ATTRIBUTE";
				MyOraDB.Parameter_Name[21] = "ARG_CBD_CHECK";
				MyOraDB.Parameter_Name[22] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[20] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[21] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[22] = (int)OracleType.VarChar;

				//04.DATA 정의

				ArrayList vList = new ArrayList();

				string vFactory = cmb_factory.SelectedValue.ToString();
				string vShipType = cmb_ShipType.SelectedValue.ToString();
				string vItemDiv = cmb_StyleItemDiv.SelectedValue.ToString();
				string vObsType = cmb_obsType.SelectedValue.ToString();

				// 테이블 초기화
				vList.Add(ClassLib.ComVar.Delete);
				vList.Add("");		vList.Add("");		vList.Add("");		vList.Add("");
				vList.Add("");		vList.Add("");		vList.Add("");		vList.Add("");
				vList.Add("");		vList.Add("");		vList.Add("");		vList.Add("");
				vList.Add("");		vList.Add("");		vList.Add("");		vList.Add("");
				vList.Add("");		vList.Add("");		vList.Add("");		vList.Add("");		vList.Add("");
				vList.Add(COM.ComVar.This_User);

				for ( int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
				{
					if ((bool)_mainSheet.Cells[vRow, _shippingYNCol].Value && !_mainSheet.Rows[vRow].Locked)
					{
						vList.Add(ClassLib.ComVar.Insert);
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxFACTORY].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSHIP_TYPE].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxMRP_SHIP_NO].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSTYLE_CD].Text).Replace("-", ""));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSTYLE_NAME].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxLOT_QTY].Value));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSTYLE_QTY].Value));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSHIP_YN].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxYIELD_COUNT].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSHIPPING_COUNT_UPPER].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSHIPPING_COUNT_BUTTOM].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSHIPPING_COUNT_OTHER].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxLOT_NO].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxLOT_SEQ].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxOBS_ID].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxOBS_TYPE].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxSTYLE_ITEM_DIV].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxREQUEST_REASON].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxMOVE_TYPE].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxATTRIBUTE].Text));
						vList.Add(ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[vRow, (int)ClassLib.TBSBM_MRP_INFO_TEST.IxCBD_CHECK].Text));
						vList.Add(COM.ComVar.This_User);
					}
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SHIPPING_SCHEDULE_TEMP", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		/// <summary>
		/// PKG_SBS_SHIPPING_LIST_UPPER : Make Shipping List - Upper
		/// </summary>
		public bool MAKE_SHIPPING_LIST(string arg_pkg)
		{
			try
			{
				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = arg_pkg;

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_REQUEST_REASON";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = cmb_reason.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = COM.ComVar.Parameter_PopUp[5];
				MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(false);

				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SHIPPING_SCHEDULE_TEMP", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}




		/// <summary>
		/// PKG_SBS_SHIPPING_LIST_ETC : 
		/// </summary>
		/// <remarks>파라미터 내부 세팅</remarks>
		public void RUN_AUTO_REQUEST()
		{

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST_ETC.RUN_AUTO_REQUEST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = "";
			MyOraDB.Parameter_Values[1] = COM.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}

		#endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Btn_ShippingClickProcess();
        }



	}
}

