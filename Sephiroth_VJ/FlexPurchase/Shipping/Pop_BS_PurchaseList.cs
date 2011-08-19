using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;



namespace FlexPurchase.Shipping
{
	public class Pop_BS_PurchaseList : COM.PCHWinForm.Pop_Normal
	{
		#region 시스템에서 정의한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_shipDate;
		private System.Windows.Forms.Label lbl_materialType;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private C1.Win.C1List.C1Combo cmb_materialType;
		private C1.Win.C1List.C1Combo cmb_ShipType;
		private System.ComponentModel.IContainer components = null;
		private COM.FSP fgrid_tail;

		#endregion
		private System.Windows.Forms.ContextMenu ctx_tail;
		private System.Windows.Forms.MenuItem mnu_PurchaseCancel;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion

		public Pop_BS_PurchaseList()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_PurchaseList));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_ShipType = new C1.Win.C1List.C1Combo();
            this.lbl_materialType = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.btn_search = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.fgrid_tail = new COM.FSP();
            this.ctx_tail = new System.Windows.Forms.ContextMenu();
            this.mnu_PurchaseCancel = new System.Windows.Forms.MenuItem();
            this.cmb_materialType = new C1.Win.C1List.C1Combo();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_tail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_materialType)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(660, 23);
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
            this.c1Sizer1.Controls.Add(this.groupBox1);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.GridDefinition = "15.4205607476636:False:True;80.8411214953271:False:False;0:False:True;0.934579439" +
                "252336:False:True;\t0.576368876080692:False:True;97.6945244956772:False:False;0.5" +
                "76368876080692:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_ShipType);
            this.groupBox1.Controls.Add(this.lbl_materialType);
            this.groupBox1.Controls.Add(this.lbl_factory);
            this.groupBox1.Controls.Add(this.lbl_shipDate);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.lblexcep_mark);
            this.groupBox1.Controls.Add(this.dpick_to);
            this.groupBox1.Controls.Add(this.dpick_from);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 66);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // cmb_ShipType
            // 
            this.cmb_ShipType.AddItemCols = 0;
            this.cmb_ShipType.AddItemSeparator = ';';
            this.cmb_ShipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_ShipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ShipType.Caption = "";
            this.cmb_ShipType.CaptionHeight = 17;
            this.cmb_ShipType.CaptionStyle = style1;
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
            this.cmb_ShipType.EvenRowStyle = style2;
            this.cmb_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ShipType.FooterStyle = style3;
            this.cmb_ShipType.GapHeight = 2;
            this.cmb_ShipType.HeadingStyle = style4;
            this.cmb_ShipType.HighLightRowStyle = style5;
            this.cmb_ShipType.ItemHeight = 15;
            this.cmb_ShipType.Location = new System.Drawing.Point(109, 38);
            this.cmb_ShipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_ShipType.MaxDropDownItems = ((short)(5));
            this.cmb_ShipType.MaxLength = 32767;
            this.cmb_ShipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ShipType.Name = "cmb_ShipType";
            this.cmb_ShipType.OddRowStyle = style6;
            this.cmb_ShipType.PartialRightColumn = false;
            this.cmb_ShipType.PropBag = resources.GetString("cmb_ShipType.PropBag");
            this.cmb_ShipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ShipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ShipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ShipType.SelectedStyle = style7;
            this.cmb_ShipType.Size = new System.Drawing.Size(200, 20);
            this.cmb_ShipType.Style = style8;
            this.cmb_ShipType.TabIndex = 185;
            // 
            // lbl_materialType
            // 
            this.lbl_materialType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_materialType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_materialType.ImageIndex = 0;
            this.lbl_materialType.ImageList = this.img_Label;
            this.lbl_materialType.Location = new System.Drawing.Point(8, 38);
            this.lbl_materialType.Name = "lbl_materialType";
            this.lbl_materialType.Size = new System.Drawing.Size(100, 21);
            this.lbl_materialType.TabIndex = 52;
            this.lbl_materialType.Text = "Ship Type";
            this.lbl_materialType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 16);
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
            this.lbl_shipDate.ImageIndex = 0;
            this.lbl_shipDate.ImageList = this.img_Label;
            this.lbl_shipDate.Location = new System.Drawing.Point(331, 16);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 52;
            this.lbl_shipDate.Text = "Ship/Pur Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmb_factory.Size = new System.Drawing.Size(200, 20);
            this.cmb_factory.Style = style16;
            this.cmb_factory.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(632, 15);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 21);
            this.btn_search.TabIndex = 184;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(523, 19);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(16, 16);
            this.lblexcep_mark.TabIndex = 178;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(544, 16);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(90, 21);
            this.dpick_to.TabIndex = 5;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(432, 16);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(90, 21);
            this.dpick_from.TabIndex = 4;
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.fgrid_tail);
            this.pnl_main.Location = new System.Drawing.Point(8, 70);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(678, 346);
            this.pnl_main.TabIndex = 166;
            // 
            // fgrid_tail
            // 
            this.fgrid_tail.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_tail.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_tail.ContextMenu = this.ctx_tail;
            this.fgrid_tail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_tail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_tail.Location = new System.Drawing.Point(0, 0);
            this.fgrid_tail.Name = "fgrid_tail";
            this.fgrid_tail.Size = new System.Drawing.Size(678, 346);
            this.fgrid_tail.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_tail.Styles"));
            this.fgrid_tail.TabIndex = 1;
            // 
            // ctx_tail
            // 
            this.ctx_tail.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_PurchaseCancel});
            // 
            // mnu_PurchaseCancel
            // 
            this.mnu_PurchaseCancel.Index = 0;
            this.mnu_PurchaseCancel.Text = "Purchase Cancel";
            this.mnu_PurchaseCancel.Click += new System.EventHandler(this.mnu_PurchaseCancel_Click);
            // 
            // cmb_materialType
            // 
            this.cmb_materialType.AddItemCols = 0;
            this.cmb_materialType.AddItemSeparator = ';';
            this.cmb_materialType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_materialType.Caption = "";
            this.cmb_materialType.CaptionHeight = 17;
            this.cmb_materialType.CaptionStyle = style17;
            this.cmb_materialType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_materialType.ColumnCaptionHeight = 18;
            this.cmb_materialType.ColumnFooterHeight = 18;
            this.cmb_materialType.ContentHeight = 16;
            this.cmb_materialType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_materialType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_materialType.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_materialType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_materialType.EditorHeight = 16;
            this.cmb_materialType.EvenRowStyle = style18;
            this.cmb_materialType.FooterStyle = style19;
            this.cmb_materialType.GapHeight = 2;
            this.cmb_materialType.HeadingStyle = style20;
            this.cmb_materialType.HighLightRowStyle = style21;
            this.cmb_materialType.ItemHeight = 15;
            this.cmb_materialType.Location = new System.Drawing.Point(0, 0);
            this.cmb_materialType.MatchEntryTimeout = ((long)(2000));
            this.cmb_materialType.MaxDropDownItems = ((short)(5));
            this.cmb_materialType.MaxLength = 32767;
            this.cmb_materialType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_materialType.Name = "cmb_materialType";
            this.cmb_materialType.OddRowStyle = style22;
            this.cmb_materialType.PartialRightColumn = false;
            this.cmb_materialType.PropBag = resources.GetString("cmb_materialType.PropBag");
            this.cmb_materialType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_materialType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_materialType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_materialType.SelectedStyle = style23;
            this.cmb_materialType.Size = new System.Drawing.Size(121, 22);
            this.cmb_materialType.Style = style24;
            this.cmb_materialType.TabIndex = 0;
            // 
            // Pop_BS_PurchaseList
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(698, 471);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BS_PurchaseList";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_tail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_materialType)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 이벤트 처리 메서드
		
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
			fgrid_tail.Set_Grid("SBS_PURCHASE_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_tail.Set_Action_Image(img_Action);
			fgrid_tail.Rows[1].AllowMerging = true;


			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();


			// material type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
			COM.ComCtl.Set_ComboList(vDt, cmb_ShipType, 1, 2, false, 80, 140);
			vDt.Dispose();


			// default search proviso
			cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
			cmb_ShipType.SelectedValue	= COM.ComVar.Parameter_PopUp[1];
			dpick_from.Value			= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[2]);
			dpick_to.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[2]);

			
		}



	#endregion

	#region 공통 메서드


		private void Grid_SetColor()
		{
			for (int vRow = fgrid_tail.Rows.Fixed ; vRow < fgrid_tail.Rows.Count ; vRow++)
			{
				// design setting
				switch (fgrid_tail.Rows[vRow].Node.Level)
				{
					case 1:
						//fgrid_tail.GetCellRange(vRow, fgrid_tail.Cols.Frozen, vRow, fgrid_tail.Cols.Count - 1).Clear(ClearFlags.Content);
						fgrid_tail.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						//fgrid_tail.Rows[vRow].StyleNew.ForeColor = ClassLib.ComVar.ClrBlack;
						//fgrid_tail.Rows[vRow].AllowEditing = false;
						break;
					case 2:
						//fgrid_tail.GetCellRange(vRow, _purPriceCol, vRow, fgrid_tail.Cols.Count - 1).Clear(ClearFlags.Content);
						fgrid_tail.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
						//fgrid_tail.Rows[vRow].AllowEditing = false;
						break;
					case 3:
//						fgrid_tail.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
//						if (fgrid_tail[vRow, _statusCol].ToString().StartsWith("P"))
//						{
//							fgrid_tail.Rows[vRow].StyleNew.ForeColor = ClassLib.ComVar.Clr_Proc1;
//							fgrid_tail.Rows[vRow].AllowEditing = false;
//						}
//						else if (fgrid_tail[vRow, _statusCol].ToString().StartsWith("F"))
//						{
//							fgrid_tail.Rows[vRow].StyleNew.ForeColor = ClassLib.ComVar.Clr_Complete;
//							fgrid_tail.Rows[vRow].AllowEditing = false;
//						}
						break;
				}
			}
		}

	#endregion

	#region 버튼 이벤트

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void mnu_PurchaseCancel_Click(object sender, System.EventArgs e)
		{
			this.Tbtn_CancelProcess();
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				if (cmb_factory.SelectedValue == null )	return;

				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = SELECT_PURCHASE_LIST();


				if (vDt.Rows.Count > 0)
				{
					fgrid_tail.ClearAll();
					fgrid_tail.Tree.Column = 2;
					ClassLib.ComFunction.Display_FlexGrid_Tree(fgrid_tail, vDt, 0);
					
					fgrid_tail.Tree.Show(1);
					Grid_SetColor();

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					fgrid_tail.ClearAll();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}

				vDt.Dispose();

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


		private void Tbtn_CancelProcess()
		{
			
			try
			{
				this.Cursor = Cursors.WaitCursor;

				
				int sel_row = fgrid_tail.Selection.r1;
				string _PurNo		= ClassLib.ComFunction.NullToBlank(fgrid_tail[sel_row, 3]);

				if (this.PURCHASE_CANCEL(_PurNo))
				{
					ClassLib.ComFunction.User_Message("Complete Purchase Cancel", "Purchase Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		/// <summary>
		/// PKG_SBS_SHIPPING_TAIL : 
		/// </summary>
		public bool PURCHASE_CANCEL(string _PurNo)
		{
			try
			{
				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.RUN_PURCHASE_CANCEL";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_PURCHASE_NO";
				MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = _PurNo;
				MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);

				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "MAKE_BARCODE", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		/// <summary>
		/// SELECT_PURCHASE_LIST : 자재별(리스트) 찾기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_ship_no">선적번호</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_PURCHASE_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.SELECT_PURCHASE_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_DATE_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_DATE_TO";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");;
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_ShipType, "");
			MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion


	}
}

