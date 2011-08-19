using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexPurchase.Shipping
{
	public class Form_BS_No_Shipping : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 변수
		
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label lbl_shipYmd;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dpick_shipYmdFr;
		private System.Windows.Forms.DateTimePicker dpick_shipYmdTo;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnl_Btn;
		private System.Windows.Forms.Label btn_Virgin;
		private COM.FSP fgrid_NoShipping;
		private System.Windows.Forms.ContextMenu ctx_virgin;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private System.Windows.Forms.Label lbl_shipType;
		private C1.Win.C1List.C1Combo cmb_virgin;
		private System.Windows.Forms.Label lbl_virgin;
		private System.Windows.Forms.MenuItem mnu_virgin;
		private System.Windows.Forms.MenuItem mnu_virginY;
		private System.Windows.Forms.MenuItem mnu_virginN;
		private System.Windows.Forms.MenuItem mnu_allSelect;
		private System.Windows.Forms.Label btn_create;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();

		private int _virginYNCol = (int)ClassLib.TBSBS_NO_SHIPPING.IxVIRGIN_YN;
		private int _reasonCodeCol = (int)ClassLib.TBSBS_NO_SHIPPING.IxVIRGIN_REASON_CD;
		private int _reasonCol = (int)ClassLib.TBSBS_NO_SHIPPING.IxVIRGIN_REASON;
		private int _remarksCol = (int)ClassLib.TBSBS_NO_SHIPPING.IxREMARKS;
		private int _shipYmdCol = (int)ClassLib.TBSBS_NO_SHIPPING.IxSCAN_YMD;
		private const int _btnCreate = 10, _btnVirgin = 20;

		private Pop_BS_Shipping_List_Wait _waitPop = null;

		#endregion

		#region 생성자 / 소멸자

		public Form_BS_No_Shipping()
		{
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BS_No_Shipping));
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
            this.pnl_Btn = new System.Windows.Forms.Panel();
            this.btn_Virgin = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Label();
            this.fgrid_NoShipping = new COM.FSP();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_virgin = new C1.Win.C1List.C1Combo();
            this.lbl_virgin = new System.Windows.Forms.Label();
            this.cmb_shipType = new C1.Win.C1List.C1Combo();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.dpick_shipYmdFr = new System.Windows.Forms.DateTimePicker();
            this.dpick_shipYmdTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_shipYmd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.ctx_virgin = new System.Windows.Forms.ContextMenu();
            this.mnu_allSelect = new System.Windows.Forms.MenuItem();
            this.mnu_virgin = new System.Windows.Forms.MenuItem();
            this.mnu_virginY = new System.Windows.Forms.MenuItem();
            this.mnu_virginN = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_Btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_NoShipping)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_virgin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.pnl_Btn);
            this.c1Sizer1.Controls.Add(this.fgrid_NoShipping);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "16.1458333333333:False:True;75.8680555555556:False:False;5.20833333333333:False:T" +
                "rue;\t0.393700787401575:False:True;97.6377952755905:False:False;0.393700787401575" +
                ":False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_Btn
            // 
            this.pnl_Btn.Controls.Add(this.btn_Virgin);
            this.pnl_Btn.Controls.Add(this.btn_create);
            this.pnl_Btn.Location = new System.Drawing.Point(12, 542);
            this.pnl_Btn.Name = "pnl_Btn";
            this.pnl_Btn.Size = new System.Drawing.Size(992, 30);
            this.pnl_Btn.TabIndex = 3;
            // 
            // btn_Virgin
            // 
            this.btn_Virgin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Virgin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Virgin.ImageIndex = 0;
            this.btn_Virgin.ImageList = this.img_Button;
            this.btn_Virgin.Location = new System.Drawing.Point(904, 3);
            this.btn_Virgin.Name = "btn_Virgin";
            this.btn_Virgin.Size = new System.Drawing.Size(80, 24);
            this.btn_Virgin.TabIndex = 237;
            this.btn_Virgin.Text = "Virgin";
            this.btn_Virgin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Virgin.Click += new System.EventHandler(this.btn_Virgin_Click);
            this.btn_Virgin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_shipping_MouseDown);
            this.btn_Virgin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_shipping_MouseUp);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_create.ImageIndex = 0;
            this.btn_create.ImageList = this.img_Button;
            this.btn_create.Location = new System.Drawing.Point(823, 3);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(80, 24);
            this.btn_create.TabIndex = 237;
            this.btn_create.Text = "Create";
            this.btn_create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            this.btn_create.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_shipping_MouseDown);
            this.btn_create.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_shipping_MouseUp);
            // 
            // fgrid_NoShipping
            // 
            this.fgrid_NoShipping.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_NoShipping.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_NoShipping.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_NoShipping.Location = new System.Drawing.Point(12, 101);
            this.fgrid_NoShipping.Name = "fgrid_NoShipping";
            this.fgrid_NoShipping.Size = new System.Drawing.Size(992, 437);
            this.fgrid_NoShipping.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_NoShipping.Styles"));
            this.fgrid_NoShipping.TabIndex = 2;
            this.fgrid_NoShipping.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_NoShipping_AfterEdit);
            this.fgrid_NoShipping.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_NoShipping_MouseUp);
            this.fgrid_NoShipping.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_NoShipping_BeforeEdit);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_virgin);
            this.pnl_head.Controls.Add(this.lbl_virgin);
            this.pnl_head.Controls.Add(this.cmb_shipType);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.dpick_shipYmdFr);
            this.pnl_head.Controls.Add(this.dpick_shipYmdTo);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_shipYmd);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 93);
            this.pnl_head.TabIndex = 1;
            // 
            // cmb_virgin
            // 
            this.cmb_virgin.AddItemCols = 0;
            this.cmb_virgin.AddItemSeparator = ';';
            this.cmb_virgin.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_virgin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_virgin.Caption = "";
            this.cmb_virgin.CaptionHeight = 17;
            this.cmb_virgin.CaptionStyle = style1;
            this.cmb_virgin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_virgin.ColumnCaptionHeight = 18;
            this.cmb_virgin.ColumnFooterHeight = 18;
            this.cmb_virgin.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_virgin.ContentHeight = 16;
            this.cmb_virgin.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_virgin.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_virgin.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_virgin.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_virgin.EditorHeight = 16;
            this.cmb_virgin.EvenRowStyle = style2;
            this.cmb_virgin.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_virgin.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_virgin.FooterStyle = style3;
            this.cmb_virgin.GapHeight = 2;
            this.cmb_virgin.HeadingStyle = style4;
            this.cmb_virgin.HighLightRowStyle = style5;
            this.cmb_virgin.ItemHeight = 15;
            this.cmb_virgin.Location = new System.Drawing.Point(432, 62);
            this.cmb_virgin.MatchEntryTimeout = ((long)(2000));
            this.cmb_virgin.MaxDropDownItems = ((short)(5));
            this.cmb_virgin.MaxLength = 32767;
            this.cmb_virgin.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_virgin.Name = "cmb_virgin";
            this.cmb_virgin.OddRowStyle = style6;
            this.cmb_virgin.PartialRightColumn = false;
            this.cmb_virgin.PropBag = resources.GetString("cmb_virgin.PropBag");
            this.cmb_virgin.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_virgin.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_virgin.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_virgin.SelectedStyle = style7;
            this.cmb_virgin.Size = new System.Drawing.Size(220, 20);
            this.cmb_virgin.Style = style8;
            this.cmb_virgin.TabIndex = 208;
            // 
            // lbl_virgin
            // 
            this.lbl_virgin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_virgin.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_virgin.ImageIndex = 0;
            this.lbl_virgin.ImageList = this.img_Label;
            this.lbl_virgin.Location = new System.Drawing.Point(331, 62);
            this.lbl_virgin.Name = "lbl_virgin";
            this.lbl_virgin.Size = new System.Drawing.Size(100, 21);
            this.lbl_virgin.TabIndex = 209;
            this.lbl_virgin.Text = "Virgin";
            this.lbl_virgin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shipType
            // 
            this.cmb_shipType.AddItemCols = 0;
            this.cmb_shipType.AddItemSeparator = ';';
            this.cmb_shipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipType.Caption = "";
            this.cmb_shipType.CaptionHeight = 17;
            this.cmb_shipType.CaptionStyle = style9;
            this.cmb_shipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipType.ColumnCaptionHeight = 18;
            this.cmb_shipType.ColumnFooterHeight = 18;
            this.cmb_shipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipType.ContentHeight = 16;
            this.cmb_shipType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipType.EditorHeight = 16;
            this.cmb_shipType.EvenRowStyle = style10;
            this.cmb_shipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipType.FooterStyle = style11;
            this.cmb_shipType.GapHeight = 2;
            this.cmb_shipType.HeadingStyle = style12;
            this.cmb_shipType.HighLightRowStyle = style13;
            this.cmb_shipType.ItemHeight = 15;
            this.cmb_shipType.Location = new System.Drawing.Point(432, 40);
            this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipType.MaxDropDownItems = ((short)(5));
            this.cmb_shipType.MaxLength = 32767;
            this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipType.Name = "cmb_shipType";
            this.cmb_shipType.OddRowStyle = style14;
            this.cmb_shipType.PartialRightColumn = false;
            this.cmb_shipType.PropBag = resources.GetString("cmb_shipType.PropBag");
            this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipType.SelectedStyle = style15;
            this.cmb_shipType.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipType.Style = style16;
            this.cmb_shipType.TabIndex = 208;
            // 
            // lbl_shipType
            // 
            this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipType.ImageIndex = 0;
            this.lbl_shipType.ImageList = this.img_Label;
            this.lbl_shipType.Location = new System.Drawing.Point(331, 40);
            this.lbl_shipType.Name = "lbl_shipType";
            this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipType.TabIndex = 209;
            this.lbl_shipType.Text = "Ship Type";
            this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmb_factory.EvenRowStyle = style18;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style19;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style20;
            this.cmb_factory.HighLightRowStyle = style21;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
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
            // dpick_shipYmdFr
            // 
            this.dpick_shipYmdFr.CustomFormat = "";
            this.dpick_shipYmdFr.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_shipYmdFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_shipYmdFr.Location = new System.Drawing.Point(109, 62);
            this.dpick_shipYmdFr.Name = "dpick_shipYmdFr";
            this.dpick_shipYmdFr.Size = new System.Drawing.Size(100, 21);
            this.dpick_shipYmdFr.TabIndex = 205;
            this.dpick_shipYmdFr.CloseUp += new System.EventHandler(this.dpick_shipYmdFr_CloseUp);
            // 
            // dpick_shipYmdTo
            // 
            this.dpick_shipYmdTo.CustomFormat = "";
            this.dpick_shipYmdTo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_shipYmdTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_shipYmdTo.Location = new System.Drawing.Point(230, 62);
            this.dpick_shipYmdTo.Name = "dpick_shipYmdTo";
            this.dpick_shipYmdTo.Size = new System.Drawing.Size(100, 21);
            this.dpick_shipYmdTo.TabIndex = 206;
            this.dpick_shipYmdTo.CloseUp += new System.EventHandler(this.dpick_shipYmdTo_CloseUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(211, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 207;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 77);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_shipYmd
            // 
            this.lbl_shipYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipYmd.ImageIndex = 1;
            this.lbl_shipYmd.ImageList = this.img_Label;
            this.lbl_shipYmd.Location = new System.Drawing.Point(8, 62);
            this.lbl_shipYmd.Name = "lbl_shipYmd";
            this.lbl_shipYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipYmd.TabIndex = 50;
            this.lbl_shipYmd.Text = "Date";
            this.lbl_shipYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 76);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 40);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 50;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(891, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 52);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(976, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "      Shipping Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(208, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(952, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 77);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(168, 20);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // pic_head6
            // 
            this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 16);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 66);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // ctx_virgin
            // 
            this.ctx_virgin.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_allSelect,
            this.mnu_virgin});
            // 
            // mnu_allSelect
            // 
            this.mnu_allSelect.Index = 0;
            this.mnu_allSelect.Text = "All Select";
            this.mnu_allSelect.Click += new System.EventHandler(this.mnu_allSelect_Click);
            // 
            // mnu_virgin
            // 
            this.mnu_virgin.Index = 1;
            this.mnu_virgin.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_virginY,
            this.mnu_virginN});
            this.mnu_virgin.Text = "Virgin";
            // 
            // mnu_virginY
            // 
            this.mnu_virginY.Index = 0;
            this.mnu_virginY.Text = "Yes";
            this.mnu_virginY.Click += new System.EventHandler(this.mnu_virginY_Click);
            // 
            // mnu_virginN
            // 
            this.mnu_virginN.Index = 1;
            this.mnu_virginN.Text = "No";
            this.mnu_virginN.Click += new System.EventHandler(this.mnu_virginN_Click);
            // 
            // Form_BS_No_Shipping
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BS_No_Shipping";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BS_No_Shipping_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_Btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_NoShipping)).EndInit();
            this.pnl_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_virgin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void fgrid_NoShipping_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void fgrid_NoShipping_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void fgrid_NoShipping_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
				ctx_virgin.Show(this, new Point(e.X, MousePosition.Y - 30));
		}

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
			{
				this.Tbtn_SearchProcess();
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.Tbtn_SaveProcess();
				}
			}
		}	
		
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
				
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_No_Shipping");
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 6;
			string [] aHead =  new string[iCnt];	
			
			string vFactory   = ClassLib.ComFunction.Empty_Combo(cmb_factory, " ");
			string vShipYmdFr = dpick_shipYmdFr.Text.Replace("-", "");
			string vShipYmdTo = dpick_shipYmdTo.Text.Replace("-", "");
			string vShipType  = ClassLib.ComFunction.Empty_Combo(cmb_shipType, " ");
			string vVirgin	  = ClassLib.ComFunction.Empty_Combo(cmb_virgin, " ");
			
			aHead[0] = COM.ComVar.This_Factory;
			aHead[1] = vFactory;
			aHead[2] = vShipYmdFr;
			aHead[3] = vShipYmdTo;
			aHead[4] = vShipType;
			aHead[5] = vVirgin;			
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
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		private void Form_BS_No_Shipping_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_NoShipping.Rows.Fixed < fgrid_NoShipping.Rows.Count)
			{
				string vTemp = fgrid_NoShipping.GetCellRange(fgrid_NoShipping.Rows.Fixed, 0, fgrid_NoShipping.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}
		}

		private void dpick_shipYmdFr_CloseUp(object sender, System.EventArgs e)
		{
			dpick_shipYmdTo.Value = dpick_shipYmdFr.Value;
		}

		private void btn_Virgin_Click(object sender, System.EventArgs e)
		{
			if (this.Etc_ProvisoValidateCheck(_btnCreate))
			{
				this.Btn_VirginYClickProcess();
			}
		}

		private void dpick_shipYmdTo_CloseUp(object sender, System.EventArgs e)
		{
			ClearAll();
		}

		private void mnu_virginY_Click(object sender, System.EventArgs e)
		{
			this.Btn_VirginYClickProcess();
		}

		private void mnu_virginN_Click(object sender, System.EventArgs e)
		{
            this.Btn_VirginNClickProcess();
		}

		private void mnu_allSelect_Click(object sender, System.EventArgs e)
		{
			fgrid_NoShipping.SelectAll();
		}

		private void btn_create_Click(object sender, System.EventArgs e)
		{
			if (this.Etc_ProvisoValidateCheck(_btnCreate))
			{
				if (MessageBox.Show(this, "Do you want to make no shipping list?", "Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Thread vCreate = new Thread(new ThreadStart(CreateNoShippingList));
					vCreate.Start();

					_waitPop = new Pop_BS_Shipping_List_Wait();
					_waitPop.Start();
				}
			}
		}
	
		#region 입력이동

		#endregion

		#region 버튼효과

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

		#region 공통 메소드

		private void GridSetCellColor()
		{
			string vVirgin = "";
			CellRange vRange;

			for (int i = fgrid_NoShipping.Rows.Fixed ; i < fgrid_NoShipping.Rows.Count ; i++)
			{
				vVirgin	= fgrid_NoShipping[i, _virginYNCol].ToString().Substring(0, 1);
				DateTime vDt = ClassLib.ComFunction.ObjectToDateTime(fgrid_NoShipping[i, _shipYmdCol]);
				vRange = fgrid_NoShipping.GetCellRange(i, fgrid_NoShipping.Cols.Frozen, i, fgrid_NoShipping.Cols.Count - 1);

				if (vVirgin.Equals(ClassLib.ComVar.No.Substring(0, 1)))
					vRange.StyleNew.BackColor = ClassLib.ComVar.RightBlue;
				else
					vRange.StyleNew.BackColor = ClassLib.ComVar.RightPink2;

				if (DateTime.Now.AddMonths(-1) > vDt)
					vRange.StyleNew.ForeColor = Color.Red;
			}
		}

		public void ClearAll()
		{
			if (fgrid_NoShipping.Rows.Fixed < fgrid_NoShipping.Rows.Fixed)
                fgrid_NoShipping.ClearAll();
		}

		#endregion

		#region 이벤트 처리 메소드

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// 초기화
            // ClassLib.ComFunction.Init_Form_Control(this);
            this.Text = "No Shipping";
            lbl_MainTitle.Text = "No Shipping";
            ClassLib.ComFunction.SetLangDic(this);
			// ClassLib.ComFunction.Init_MenuRole(this,lbl_MainTitle, tbtn_Search ,tbtn_Save, tbtn_Print) ;

			// Factory Combobox Add Items
			DataTable vDt;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose() ;

			// ship type
			ClassLib.ComFunction.SetComboData(cmb_shipType, ClassLib.ComVar.CxShipType, true, 0);
			
			// ship type
			ClassLib.ComFunction.SetComboData(cmb_virgin, ClassLib.ComVar.CxUseYN, true, 0);

			// 그리드 설정
			fgrid_NoShipping.Set_Grid("SBS_NO_SHIPPING", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_NoShipping.Rows[1].AllowMerging = true;
			fgrid_NoShipping.Set_Action_Image(img_Action);
			fgrid_NoShipping.Cols[_shipYmdCol].Format = "yyyy-MM-dd";

			fgrid_NoShipping.Cols[(int)ClassLib.TBSBS_NO_SHIPPING.IxSHIP_QTY].Format = "#,##0.00";
			fgrid_NoShipping.Cols[(int)ClassLib.TBSBS_NO_SHIPPING.IxSCAN_QTY].Format = "#,##0.00";

			tbtn_Delete.Enabled		= false;
			tbtn_Confirm.Enabled	= false;
			tbtn_Create.Enabled		= false;
		}
		
		#region 툴바 메뉴 이벤트
		
		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_NoShipping.ClearAll();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
			
				string vFactory   = ClassLib.ComFunction.Empty_Combo(cmb_factory, " ");
				string vShipYmdFr = dpick_shipYmdFr.Text.Replace("-", "");
				string vShipYmdTo = dpick_shipYmdTo.Text.Replace("-", "");
				string vShipType  = ClassLib.ComFunction.Empty_Combo(cmb_shipType, " ");
				string vVirgin	  = ClassLib.ComFunction.Empty_Combo(cmb_virgin, " ");

				DataTable vDt = SELECT_SBS_NO_SHIPPING_LIST(vFactory, vShipYmdFr, vShipYmdTo, vShipType, vVirgin);
				
				if (vDt.Rows.Count > 0)
				{
					ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_NoShipping, vDt);
					GridSetCellColor();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					fgrid_NoShipping.ClearAll();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Tbtn_SaveProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;
				
				if (MyOraDB.Save_FlexGird("PKG_SBS_NO_SHIPPING.SAVE_SBS_NO_SHIPPING", fgrid_NoShipping))
				{
					GridSetCellColor();
					fgrid_NoShipping.ClearFlags();
					ClassLib.ComFunction.User_Message("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
			if (cmb_factory.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_factory.Focus();
				return false;
			}

			// 부분별 체크 (Search, Save, Delete, Confirm..)
			switch (arg_type)
			{
				case ClassLib.ComVar.Validate_Search:

					break;
				case ClassLib.ComVar.Validate_Save:
					if (fgrid_NoShipping.Rows.Count <= fgrid_NoShipping.Rows.Fixed)
					{
						ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
				case ClassLib.ComVar.Validate_Delete:

					break;
				case ClassLib.ComVar.Validate_Confirm:

					break;
				case _btnCreate:

					break;
				case _btnVirgin:
					if (fgrid_NoShipping.Selections.Length <= 0)
					{
						ClassLib.ComFunction.User_Message("Selected data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
			}

			return true;
		}

		#endregion

		#region 컨트롤 이벤트

		private void CreateNoShippingList()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				MAKE_NO_SHIPPING_LIST(ClassLib.ComVar.This_User);
				ClassLib.ComFunction.User_Message("Create No Shipping List Complete", "Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Tbtn_SearchProcess();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Create", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				_waitPop.Close();
			}
		}

		private void Btn_VirginYClickProcess()
		{
			int[] vSelection = fgrid_NoShipping.Selections;

			Form pop = new Pop_BS_No_Shipping_Virgin();
			
			COM.ComVar.Parameter_PopUp = new string[]{cmb_factory.SelectedValue.ToString()};
			if (pop.ShowDialog() == DialogResult.OK)
			{
				foreach (int vRow in vSelection)
				{
					fgrid_NoShipping[vRow, _virginYNCol] = ClassLib.ComVar.Yes;
					fgrid_NoShipping[vRow, _reasonCodeCol] = COM.ComVar.Parameter_PopUp[0];
					fgrid_NoShipping[vRow, _reasonCol] = COM.ComVar.Parameter_PopUp[1];
					fgrid_NoShipping[vRow, _remarksCol] = COM.ComVar.Parameter_PopUp[2];
					fgrid_NoShipping[vRow, 0] = ClassLib.ComVar.Update;
				}

				pop.Dispose();
			}
		}

		private void Btn_VirginNClickProcess()
		{
			int[] vSelection = fgrid_NoShipping.Selections;

			foreach (int vRow in vSelection)
			{
				if (fgrid_NoShipping[vRow, _virginYNCol].ToString().StartsWith(ClassLib.ComVar.Yes))
				{
					fgrid_NoShipping[vRow, _virginYNCol] = ClassLib.ComVar.No;
					fgrid_NoShipping[vRow, _reasonCodeCol] = "";
					fgrid_NoShipping[vRow, _reasonCol] = "";
					fgrid_NoShipping[vRow, 0] = ClassLib.ComVar.Update;
				}
			}
		}

		#endregion

		#region 그리드 이벤트

		private void Grid_AfterEditProcess()
		{
			fgrid_NoShipping.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_NoShipping.Rows.Fixed > 0) && (fgrid_NoShipping.Row >= fgrid_NoShipping.Rows.Fixed))
				fgrid_NoShipping.Buffer_CellData = (fgrid_NoShipping[fgrid_NoShipping.Row, fgrid_NoShipping.Col] == null) ? "" : fgrid_NoShipping[fgrid_NoShipping.Row, fgrid_NoShipping.Col].ToString();
		}

		#endregion

		#endregion

		#region DB Connect

		/// <summary>
		/// PKG_SBS_NO_SHIPPING : no shipping 리스트 생성
		/// </summary>
		/// <param name="arg_upd_user">user</param>
		public void MAKE_NO_SHIPPING_LIST(string arg_upd_user)
		{

			MyOraDB.ReDim_Parameter(1);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_NO_SHIPPING.MAKE_NO_SHIPPING_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_upd_user;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}

 		
		/// <summary>
		/// PKG_SBS_NO_SHIPPING : NO SHIPPING LIST
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_ship_ymd_from">선적일 From</param>
		/// <param name="arg_ship_ymd_to">선적일 To</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_NO_SHIPPING_LIST(string arg_factory, string arg_ship_ymd_from, string arg_ship_ymd_to, string arg_ship_type, string arg_virgin)
		{
			DataSet vDs;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_NO_SHIPPING.SELECT_SBS_NO_SHIPPING_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[5] = "ARG_VIRGIN";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = arg_factory;
			MyOraDB.Parameter_Values[2] = arg_ship_ymd_from;
			MyOraDB.Parameter_Values[3] = arg_ship_ymd_to;
			MyOraDB.Parameter_Values[4] = arg_ship_type;
			MyOraDB.Parameter_Values[5] = arg_virgin;
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDs = MyOraDB.Exe_Select_Procedure();
			if(vDs == null) return null ;

			return vDs.Tables[MyOraDB.Process_Name];
		}

		#endregion								

	}
}

