using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Shipping_List_Trade : COM.PCHWinForm.Pop_Medium
	{

		#region 컨트롤 및 리소스 정리


		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox1;
		private C1.Win.C1List.C1Combo cmb_materialType;
		private System.Windows.Forms.DateTimePicker dpick_shipYmd;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label btn_Search;
		private System.Windows.Forms.ContextMenu cmenu_Grid;
		private System.Windows.Forms.MenuItem menuitem_SelectAll;
		private System.Windows.Forms.MenuItem menuitem_DeSelectAll;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem_SelectCR;
		private System.Windows.Forms.MenuItem menuItem_DeselectCR;
		private System.Windows.Forms.Label btn_Apply;


		

		public Pop_BS_Shipping_List_Trade()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



	    public string _Factory = "";
		public string _ShipYmd = "";
		public string _ShipType = "";


		public Pop_BS_Shipping_List_Trade(string arg_factory, string arg_ship_ymd, string arg_ship_type)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_Factory = arg_factory;
			_ShipYmd = arg_ship_ymd;
			_ShipType = arg_ship_type;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Shipping_List_Trade));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Apply = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.spd_main = new COM.SSP();
            this.cmenu_Grid = new System.Windows.Forms.ContextMenu();
            this.menuitem_SelectAll = new System.Windows.Forms.MenuItem();
            this.menuitem_DeSelectAll = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem_SelectCR = new System.Windows.Forms.MenuItem();
            this.menuItem_DeselectCR = new System.Windows.Forms.MenuItem();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Label();
            this.cmb_materialType = new C1.Win.C1List.C1Combo();
            this.dpick_shipYmd = new System.Windows.Forms.DateTimePicker();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_materialType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
            this.c1Sizer1.TabIndex = 27;
            this.c1Sizer1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Apply);
            this.panel3.Location = new System.Drawing.Point(8, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 29);
            this.panel3.TabIndex = 168;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Apply.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.ImageList = this.img_Button;
            this.btn_Apply.Location = new System.Drawing.Point(605, 3);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(71, 23);
            this.btn_Apply.TabIndex = 353;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseDown);
            this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseUp);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.spd_main);
            this.pnl_main.Location = new System.Drawing.Point(8, 95);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(678, 292);
            this.pnl_main.TabIndex = 166;
            // 
            // spd_main
            // 
            this.spd_main.ContextMenu = this.cmenu_Grid;
            this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(678, 292);
            this.spd_main.TabIndex = 0;
            // 
            // cmenu_Grid
            // 
            this.cmenu_Grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuitem_SelectAll,
            this.menuitem_DeSelectAll,
            this.menuItem3,
            this.menuItem_SelectCR,
            this.menuItem_DeselectCR});
            // 
            // menuitem_SelectAll
            // 
            this.menuitem_SelectAll.Index = 0;
            this.menuitem_SelectAll.Text = "Select All";
            this.menuitem_SelectAll.Click += new System.EventHandler(this.menuitem_SelectAll_Click);
            // 
            // menuitem_DeSelectAll
            // 
            this.menuitem_DeSelectAll.Index = 1;
            this.menuitem_DeSelectAll.Text = "DeSelect All";
            this.menuitem_DeSelectAll.Click += new System.EventHandler(this.menuitem_DeSelectAll_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // menuItem_SelectCR
            // 
            this.menuItem_SelectCR.Index = 3;
            this.menuItem_SelectCR.Text = "Select Selection Range";
            this.menuItem_SelectCR.Click += new System.EventHandler(this.menuItem_SelectCR_Click);
            // 
            // menuItem_DeselectCR
            // 
            this.menuItem_DeselectCR.Index = 4;
            this.menuItem_DeselectCR.Text = "Deselect Selection Range";
            this.menuItem_DeselectCR.Click += new System.EventHandler(this.menuItem_DeselectCR_Click);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.cmb_materialType);
            this.groupBox1.Controls.Add(this.dpick_shipYmd);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 91);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ImageIndex = 27;
            this.btn_Search.ImageList = this.img_SmallButton;
            this.btn_Search.Location = new System.Drawing.Point(329, 59);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(24, 21);
            this.btn_Search.TabIndex = 439;
            this.btn_Search.Tag = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Search_MouseDown);
            this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Search_MouseUp);
            // 
            // cmb_materialType
            // 
            this.cmb_materialType.AddItemCols = 0;
            this.cmb_materialType.AddItemSeparator = ';';
            this.cmb_materialType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_materialType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_materialType.Caption = "";
            this.cmb_materialType.CaptionHeight = 17;
            this.cmb_materialType.CaptionStyle = style1;
            this.cmb_materialType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_materialType.ColumnCaptionHeight = 18;
            this.cmb_materialType.ColumnFooterHeight = 18;
            this.cmb_materialType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_materialType.ContentHeight = 16;
            this.cmb_materialType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_materialType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_materialType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_materialType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_materialType.EditorHeight = 16;
            this.cmb_materialType.EvenRowStyle = style2;
            this.cmb_materialType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_materialType.FooterStyle = style3;
            this.cmb_materialType.GapHeight = 2;
            this.cmb_materialType.HeadingStyle = style4;
            this.cmb_materialType.HighLightRowStyle = style5;
            this.cmb_materialType.ItemHeight = 15;
            this.cmb_materialType.Location = new System.Drawing.Point(109, 59);
            this.cmb_materialType.MatchEntryTimeout = ((long)(2000));
            this.cmb_materialType.MaxDropDownItems = ((short)(5));
            this.cmb_materialType.MaxLength = 32767;
            this.cmb_materialType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_materialType.Name = "cmb_materialType";
            this.cmb_materialType.OddRowStyle = style6;
            this.cmb_materialType.PartialRightColumn = false;
            this.cmb_materialType.PropBag = resources.GetString("cmb_materialType.PropBag");
            this.cmb_materialType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_materialType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_materialType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_materialType.SelectedStyle = style7;
            this.cmb_materialType.Size = new System.Drawing.Size(220, 20);
            this.cmb_materialType.Style = style8;
            this.cmb_materialType.TabIndex = 185;
            // 
            // dpick_shipYmd
            // 
            this.dpick_shipYmd.Checked = false;
            this.dpick_shipYmd.CustomFormat = "";
            this.dpick_shipYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_shipYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_shipYmd.Location = new System.Drawing.Point(109, 38);
            this.dpick_shipYmd.Name = "dpick_shipYmd";
            this.dpick_shipYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_shipYmd.Size = new System.Drawing.Size(222, 21);
            this.dpick_shipYmd.TabIndex = 182;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style9;
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
            this.cmb_factory.EvenRowStyle = style10;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style11;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style12;
            this.cmb_factory.HighLightRowStyle = style13;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 16);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style14;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style15;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style16;
            this.cmb_factory.TabIndex = 181;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 183;
            this.label1.Text = "Factory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 184;
            this.label2.Text = "Ship Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 186;
            this.label3.Text = "Ship Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_BS_Shipping_List_Trade
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(698, 471);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BS_Shipping_List_Trade";
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_materialType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();  

		#endregion

		#region 그리드 이벤트 처리

		

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
			
	
		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		 

		#region 입력이동

		#endregion

		#region 버튼효과


		private void btn_Search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex--;
		}

		private void btn_Search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex++;
		}

		
		private void btn_Apply_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex++;
		}

		private void btn_Apply_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex--;
		}


		#endregion

		#endregion

		#region 공통 메서드

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
            // ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Shipping List";
            this.Text = "Shipping List";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SBM_SHIP_REQ_ITEM", "4", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			// Farpoint Spread Header Merge
			Mearge_GridHead();


			// factory set
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = _Factory;
			vDt.Dispose();


			// ship type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
			COM.ComCtl.Set_ComboList(vDt, cmb_materialType, 1, 2, false, 80, 140);
			cmb_materialType.SelectedValue = _ShipType;
			vDt.Dispose();


			// ship date
			dpick_shipYmd.Text = _ShipYmd;


			Search();


		}


		/// <summary>
		/// Mearge_GridHead : Farpoint Spread Header Merge
		/// </summary>
		private void Mearge_GridHead()
		{
			
			try
			{

				for (int vCol = 0 ; vCol < spd_main.ActiveSheet.ColumnCount ; vCol++)
				{
					
					if (spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim().Equals(spd_main.ActiveSheet.ColumnHeader.Cells[2, vCol].Text.ToString().Trim()))
					{
						spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
					}
					else
					{
						int vCnt  = 0;
						
						for ( int j = vCol ; j < spd_main.ActiveSheet.ColumnCount ; j++)
						{
							if( vCnt > 0 &&  spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
							{
								spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
								break;
							}
							else if ( spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
							{
								vCnt++;
							}
						}

						vCol = vCol + vCnt-1;
					}
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Mearge_GridHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}


		#endregion

		#region 이벤트 처리 메서드 
 
		 
		private void btn_Search_Click(object sender, System.EventArgs e)
		{
		
			Search();



		}
 


		private void Search()
		{

			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_materialType};   
			bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

			if(! essential_check) return;


			string factory = cmb_factory.SelectedValue.ToString();
			string ship_ymd = dpick_shipYmd.Text.Replace("-", "");
			string ship_type = cmb_materialType.SelectedValue.ToString();

			DataTable dt_ret = SELECT_SBS_SHIPPING_SHIP_NO(factory, ship_ymd, ship_type);
			spd_main.Display_Grid(dt_ret);


//			for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
//			{
//				if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBS_SHIPPING_HEAD_TRADE.IxSTATUS].Value.ToString() == "I")
//				{
//					spd_main.ActiveSheet.Rows[i].ForeColor = ClassLib.ComVar.ClrImportant; 
//					spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBS_SHIPPING_HEAD_TRADE.IxCHECK_FLAG].Locked = true;
//				}
//				else
//				{
//					spd_main.ActiveSheet.Rows[i].ForeColor = Color.Black;
//					spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBS_SHIPPING_HEAD_TRADE.IxCHECK_FLAG].Locked = false;
//				}
//			}


		}



		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			if(spd_main.ActiveSheet.RowCount <= 0) return;

			Return_Data();

		}


		


		public DataTable dt_ret = new DataTable();  

		private void Return_Data()
		{


			try
			{
				 
 
				dt_ret.Columns.Add(new DataColumn("FACTORY", typeof(string)));
				dt_ret.Columns.Add(new DataColumn("SHIP_NO", typeof(string)));

 
				DataRow datarow = null; 
		  
		 
				for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
				{ 
					bool vBool = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBS_SHIPPING_HEAD_TRADE.IxCHECK_FLAG].Value.ToString() == "True" ? true : false;
					
					if (! vBool) continue; 
						  

					datarow = dt_ret.NewRow();
			
					datarow[0] = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBS_SHIPPING_HEAD_TRADE.IxFACTORY].Value.ToString();
					datarow[1] = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBS_SHIPPING_HEAD_TRADE.IxSHIP_NO].Value.ToString(); 

					dt_ret.Rows.Add(datarow);  
						 
						 
				 
				}
				

				this.Close(); 

				 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Return_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}
		 


		private void menuitem_SelectAll_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Select_SelectionAll(true);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_SelectAll_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void menuitem_DeSelectAll_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Select_SelectionAll(false);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_DeSelectAll_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

 

		private void menuItem_SelectCR_Click(object sender, System.EventArgs e)
		{
			
			try
			{ 
				Select_SelectionRange(true);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_SelectionRange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuItem_DeselectCR_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Select_SelectionRange(false);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_SelectionRange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		private void Select_SelectionAll(bool arg_select)
		{ 
			for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
			{
				//if(spd_main.ActiveSheet.Rows[i].Locked) continue;
				if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBS_SHIPPING_HEAD_TRADE.IxCHECK_FLAG].Locked) continue;
				spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBS_SHIPPING_HEAD_TRADE.IxCHECK_FLAG].Value = arg_select;
			} 
		}


		private void Select_SelectionRange(bool arg_select)
		{

			CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

			for (int i = 0 ; i < vSelectionRange.Length; i++)
			{
				int start_row = vSelectionRange[i].Row;
				int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

				for (int j = start_row ; j < end_row; j++)
				{ 
					//if(spd_main.ActiveSheet.Rows[j].Locked) continue;
					if(spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBS_SHIPPING_HEAD_TRADE.IxCHECK_FLAG].Locked) continue;
					spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBS_SHIPPING_HEAD_TRADE.IxCHECK_FLAG].Value = arg_select;
				}
			}

		} 



		#endregion

		#region DB Connect
 		 

		/// <summary>
		/// SELECT_SBS_SHIPPING_SHIP_NO : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_ship_ymd"></param>
		/// <param name="arg_ship_type"></param>
		/// <returns></returns>
		private DataTable SELECT_SBS_SHIPPING_SHIP_NO(string arg_factory, string arg_ship_ymd, string arg_ship_type)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_HEAD.SELECT_SHIPPING_NUMBER_TRADE";


			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_ship_ymd;
			MyOraDB.Parameter_Values[2] = arg_ship_type;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion

		

		

		

		


	}
}

