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

namespace FlexPurchase.Quality
{
	public class Form_QC_Shipping_List : COM.PCHWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenu cmenu_Barcode;
		private System.Windows.Forms.MenuItem menuitem_SelectAll;
		private System.Windows.Forms.MenuItem menuitem_DeSelectAll;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private System.Windows.Forms.Label btn_colorSearch;
		private System.Windows.Forms.Label btn_itemSearch;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label lbl_color;
		private System.Windows.Forms.Label lbl_shipDate;
		private System.Windows.Forms.TextBox txt_colorNm;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.TextBox txt_colorCd;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.TextBox txt_itemNm;
		private System.Windows.Forms.TextBox txt_itemCd;
		private COM.SSP spd_main;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet;
		private bool _isAccessible  = true;

		private int _lxChkCol			= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxCHK;
		private int _lxItemNameCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxITEM_NAME;
		private int _lxSpecCdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSPEC_CD;
		private int _lxSpecNameCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSPEC_NAME;
		private int _lxColorCdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxCOLOR_CD;
		private int _lxCustNameCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxCUST_NAME;
		private int _lxReqNoCol			= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxREQ_NO;
		private int _lxColorNameCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxCOLOR_NAME;
//		private int _lxUnitCol			= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxUNIT;
//		private int _lxReqQtyCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxREQ_QTY;
//		private int _lxStyleNameCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSTYLE_NAME;
//		private int _lxStyleCdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSTYLE_CD;
//		private int _lxLotNoCol			= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxLOT_NO;
//		private int _lxLotSeqCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxLOT_SEQ;
//		private int _lxCustCdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxCUST_CD;
//		private int _lxReqSeqCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxREQ_SEQ;
//		private int _lxPurUserCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxPUR_USER;
//		private int _lxFactoryCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxFACTORY;
//		private int _lxShipNoCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSHIP_NO;
//		private int _lxShipSeqCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSHIP_SEQ;
//		private int _lxShipYmdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSHIP_YMD;
//		private int _lxObsTypeCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxOBS_TYPE;
//		private int _lxItemCdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxITEM_CD;

		#endregion

		#region 생성자 / 소멸자

		public Form_QC_Shipping_List()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QC_Shipping_List));
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.spd_main = new COM.SSP();
            this.cmenu_Barcode = new System.Windows.Forms.ContextMenu();
            this.menuitem_SelectAll = new System.Windows.Forms.MenuItem();
            this.menuitem_DeSelectAll = new System.Windows.Forms.MenuItem();
            this._mainSheet = new FarPoint.Win.Spread.SheetView();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.btn_colorSearch = new System.Windows.Forms.Label();
            this.btn_itemSearch = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.txt_colorNm = new System.Windows.Forms.TextBox();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.txt_colorCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainSheet)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "14.2361111111111:False:True;83.6805555555556:False:False;\t0.393700787401575:False" +
                ":True;97.6377952755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 30;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.spd_main);
            this.pnl_main.Location = new System.Drawing.Point(12, 90);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(992, 482);
            this.pnl_main.TabIndex = 1;
            // 
            // spd_main
            // 
            this.spd_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.ContextMenu = this.cmenu_Barcode;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this._mainSheet);
            this.spd_main.Size = new System.Drawing.Size(992, 494);
            this.spd_main.TabIndex = 0;
            // 
            // cmenu_Barcode
            // 
            this.cmenu_Barcode.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuitem_SelectAll,
            this.menuitem_DeSelectAll});
            this.cmenu_Barcode.Popup += new System.EventHandler(this.cmenu_Barcode_Popup);
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
            // _mainSheet
            // 
            this._mainSheet.SheetName = "Sheet1";
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.lbl_vendor);
            this.pnl_head.Controls.Add(this.txt_vendorCode);
            this.pnl_head.Controls.Add(this.cmb_vendor);
            this.pnl_head.Controls.Add(this.btn_colorSearch);
            this.pnl_head.Controls.Add(this.btn_itemSearch);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.lbl_color);
            this.pnl_head.Controls.Add(this.lbl_shipDate);
            this.pnl_head.Controls.Add(this.txt_colorNm);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.txt_colorCd);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.txt_itemNm);
            this.pnl_head.Controls.Add(this.txt_itemCd);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 82);
            this.pnl_head.TabIndex = 0;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 1;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(8, 56);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 440;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(110, 56);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 438;
            this.txt_vendorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vendorCode_KeyPress);
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
            this.cmb_vendor.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
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
            this.cmb_vendor.Location = new System.Drawing.Point(190, 56);
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
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style16;
            this.cmb_vendor.TabIndex = 439;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            // 
            // btn_colorSearch
            // 
            this.btn_colorSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_colorSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_colorSearch.ImageIndex = 27;
            this.btn_colorSearch.ImageList = this.img_SmallButton;
            this.btn_colorSearch.Location = new System.Drawing.Point(676, 56);
            this.btn_colorSearch.Name = "btn_colorSearch";
            this.btn_colorSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_colorSearch.TabIndex = 448;
            this.btn_colorSearch.Tag = "Search";
            this.btn_colorSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_colorSearch.Click += new System.EventHandler(this.btn_colorSearch_Click);
            // 
            // btn_itemSearch
            // 
            this.btn_itemSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_itemSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemSearch.ImageIndex = 27;
            this.btn_itemSearch.ImageList = this.img_SmallButton;
            this.btn_itemSearch.Location = new System.Drawing.Point(676, 32);
            this.btn_itemSearch.Name = "btn_itemSearch";
            this.btn_itemSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_itemSearch.TabIndex = 441;
            this.btn_itemSearch.Tag = "Search";
            this.btn_itemSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_itemSearch.Click += new System.EventHandler(this.btn_itemSearch_Click);
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(230, 32);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 435;
            // 
            // lbl_color
            // 
            this.lbl_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_color.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.ImageIndex = 0;
            this.lbl_color.ImageList = this.img_Label;
            this.lbl_color.Location = new System.Drawing.Point(354, 56);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(100, 21);
            this.lbl_color.TabIndex = 445;
            this.lbl_color.Text = "Color";
            this.lbl_color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipDate
            // 
            this.lbl_shipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipDate.ImageIndex = 1;
            this.lbl_shipDate.ImageList = this.img_Label;
            this.lbl_shipDate.Location = new System.Drawing.Point(8, 32);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 436;
            this.lbl_shipDate.Text = "Ship Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_colorNm
            // 
            this.txt_colorNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_colorNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_colorNm.Location = new System.Drawing.Point(536, 56);
            this.txt_colorNm.MaxLength = 10;
            this.txt_colorNm.Name = "txt_colorNm";
            this.txt_colorNm.Size = new System.Drawing.Size(140, 21);
            this.txt_colorNm.TabIndex = 447;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(216, 32);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(8, 16);
            this.lblexcep_mark.TabIndex = 437;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_colorCd
            // 
            this.txt_colorCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_colorCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_colorCd.Location = new System.Drawing.Point(456, 56);
            this.txt_colorCd.MaxLength = 10;
            this.txt_colorCd.Name = "txt_colorCd";
            this.txt_colorCd.Size = new System.Drawing.Size(79, 21);
            this.txt_colorCd.TabIndex = 446;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(354, 32);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 442;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(110, 32);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 434;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(536, 32);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(140, 21);
            this.txt_itemNm.TabIndex = 444;
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(456, 32);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(79, 21);
            this.txt_itemCd.TabIndex = 443;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 66);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 65);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(891, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 41);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 66);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 55);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // Form_QC_Shipping_List
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_QC_Shipping_List";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_QC_Shipping_List_Closing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainSheet)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
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

		#endregion
		
		#region 컨텍스트(팝업) 메뉴 이벤트

		private void cmenu_Barcode_Popup(object sender, System.EventArgs e)
		{
			try
			{
				// 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
				Set_MenuItem_Visible();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Barcode_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

  		
		/// <summary>
		/// Set_MenuItem_Visible : 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
		/// </summary>
		private void Set_MenuItem_Visible()
		{
			this.menuitem_DeSelectAll.Visible		= true;
			this.menuitem_SelectAll.Visible			= true;
		}
 

		private void menuitem_SelectAll_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Select_All();
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
				DeSelect_All();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_DeSelectAll_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		/// <summary>
		/// Select_All : 모든 Row 선택
		/// </summary>
		private void Select_All()
		{ 
			for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
			{
				spd_main.ActiveSheet.Cells[i, _lxChkCol].Value = true;
			} 
		}

		/// <summary>
		/// DeSelect_All : 모든 Row 해제
		/// </summary>
		private void DeSelect_All()
		{ 
			for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
			{
				spd_main.ActiveSheet.Cells[i, _lxChkCol].Value = false;
			} 
		}

		/// <summary>
		/// Select_Selection : 선택한 Row 선택
		/// </summary>
		private void Select_Selection()
		{ 
			CellRange vSelectionRange = _mainSheet.GetSelection(0);

			if (vSelectionRange != null)
			{
				for (int i = vSelectionRange.Row ; i < vSelectionRange.Row + vSelectionRange.RowCount ; i++)
				{
					spd_main.ActiveSheet.Cells[i, _lxChkCol].Value = true;
				}
			} 
		}

		/// <summary>
		/// DeSelect_Selection : 선택한 Row 해제
		/// </summary>
		private void DeSelect_Selection()
		{ 
			CellRange vSelectionRange = _mainSheet.GetSelection(0);

			if (vSelectionRange != null)
			{
				for (int i = vSelectionRange.Row ; i < vSelectionRange.Row + vSelectionRange.RowCount ; i++)
				{
					spd_main.ActiveSheet.Cells[i, _lxChkCol].Value = false;
				}
			} 
		}

		#endregion
	
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();							
		}
	
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();							
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

		private void Form_QC_Shipping_List_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			for (int vRow = _mainSheet.RowCount - 1 ; vRow >= 0 ; vRow--)
			{
				if (_mainSheet.Cells[vRow, 0].Tag != null && _mainSheet.Cells[vRow, 0].Tag.ToString() != "")
				{
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;

					break;
				}
			}		
		}


		#region 버튼 이벤트

		#endregion

		#region 검색조건 변경에 따른 이벤트

		#endregion

		#region 입력이동

		#endregion

		#region 버튼효과

		private void btn_click_Effect_Up(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 27;
		}

		private void btn_click_Effect_Down(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 26;
		}

		private void btn_click_Effect_Plus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_click_Effect_Minus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		#endregion

		#endregion

		#region 공통 메서드

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
            //			ClassLib.ComFunction.Init_Form_Control(this);
            lbl_MainTitle.Text = "Search Shipping List";
            this.Text = "Search Shipping List";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SQL_LAB_REQ_SHIP", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			// user define variable setting
			_mainSheet					= spd_main.ActiveSheet;

			for (int vCol = 0 ; vCol < _mainSheet.ColumnCount ; vCol++)
			{
				if (_mainSheet.ColumnHeader.Cells[1, vCol].Text.Equals(_mainSheet.ColumnHeader.Cells[2, vCol].Text))
				{
					_mainSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
				}
				else
				{
					int    vCnt  = 0;
					for ( int j = vCol ; j < _mainSheet.ColumnCount ; j++)
					{
						if( vCnt > 0 &&  _mainSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != _mainSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
						{
							_mainSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
							break;
						}
						else if ( _mainSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == _mainSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
							vCnt++;
					}
					vCol = vCol + vCnt-1;
				}
			}

			dpick_from.Value	= System.DateTime.Today;
			dpick_to.Value		= dpick_from.Value.AddDays(6); 

			// Disabled tbutton
			tbtn_Save.Enabled		= false;
			tbtn_Delete.Enabled		= false;
			tbtn_Confirm.Enabled	= false;
			tbtn_Create.Enabled		= false;

		}

		#region 툴바 메뉴 이벤트

		private void Tbtn_NewProcess()
		{
			try
			{
				spd_main.ClearAll();
				this.txt_vendorCode.Text			= "";
				this.txt_itemCd.Text				= "";
				this.txt_itemNm.Text				= "";
				this.txt_colorCd.Text				= "";
				this.txt_colorNm.Text				= "";
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				if (cmb_vendor.SelectedIndex < 0 && txt_itemCd.Text == "")
				{
					ClassLib.ComFunction.User_Message("First of All, Input Data Vendor Or Item.", "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					this.Cursor = Cursors.WaitCursor;

					DataTable vTemp = SELECT_SQL_SHIP_LIST();
					if (vTemp.Rows.Count > 0)
					{
						spd_main.Display_Grid(vTemp);
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
						int    vCnt		= 0;

						for (int vCol =  _lxItemNameCol; vCol < _lxColorNameCol +1 ; vCol++)
						{
							for (int vRow = 0; vRow < _mainSheet.Rows.Count; vRow++)
							{
								vCnt		= 0;	
								for ( int i = vRow; i < _mainSheet.Rows.Count; i++)
								{
									if(vCol.Equals(_lxItemNameCol))
									{
										if( vCnt > 0 && (_mainSheet.Cells[vRow, vCol].Value.ToString().Trim() != _mainSheet.Cells[i, vCol].Value.ToString().Trim()) )
										{
											_mainSheet.Cells[vRow, vCol].RowSpan = vCnt;
											break;
										}
										else if ( _mainSheet.Cells[vRow, vCol].Value.ToString().Trim() == _mainSheet.Cells[i, vCol].Value.ToString().Trim() )	
										{
											vCnt++;
											if (i.Equals(_mainSheet.RowCount -1))
											{
												_mainSheet.Cells[vRow, vCol].RowSpan = vCnt;
												break;
											}
										}
									}
									else if(vCol.Equals(_lxSpecNameCol) || vCol.Equals(_lxSpecCdCol) )
									{
										if( vCnt > 0 && ((_mainSheet.Cells[vRow, _lxItemNameCol].Value.ToString().Trim() == _mainSheet.Cells[i, _lxItemNameCol].Value.ToString().Trim())
											&& (_mainSheet.Cells[vRow, vCol].Value.ToString().Trim() != _mainSheet.Cells[i, vCol].Value.ToString().Trim())))
										{
											_mainSheet.Cells[vRow, vCol].RowSpan = vCnt;
											break;
										}
										else if ((_mainSheet.Cells[vRow, _lxItemNameCol].Value.ToString().Trim() == _mainSheet.Cells[i, _lxItemNameCol].Value.ToString().Trim()) 
											&& (_mainSheet.Cells[vRow, vCol].Value.ToString().Trim() == _mainSheet.Cells[i, vCol].Value.ToString().Trim()))	
										{
											vCnt++;
											if (i.Equals(_mainSheet.RowCount -1))
											{
												_mainSheet.Cells[vRow, vCol].RowSpan = vCnt;
												break;
											}
										}
										else if(_mainSheet.Cells[vRow, _lxItemNameCol].Value.ToString().Trim() != _mainSheet.Cells[i, _lxItemNameCol].Value.ToString().Trim()) 
										{
											break;
										}
									}
									else if(vCol.Equals(_lxColorNameCol) || vCol.Equals(_lxColorCdCol) )
									{
										if( vCnt > 0 && ((_mainSheet.Cells[vRow, _lxItemNameCol].Value.ToString().Trim() == _mainSheet.Cells[i, _lxItemNameCol].Value.ToString().Trim())
											&& (_mainSheet.Cells[vRow, _lxSpecNameCol].Value.ToString().Trim() == _mainSheet.Cells[i, _lxSpecNameCol].Value.ToString().Trim())
											&& (_mainSheet.Cells[vRow, vCol].Value.ToString().Trim() != _mainSheet.Cells[i, vCol].Value.ToString().Trim())))
										{
											_mainSheet.Cells[vRow, vCol].RowSpan = vCnt;
											break;
										}
										else if ((_mainSheet.Cells[vRow, _lxItemNameCol].Value.ToString().Trim() == _mainSheet.Cells[i, _lxItemNameCol].Value.ToString().Trim()) 
											&& (_mainSheet.Cells[vRow, _lxSpecNameCol].Value.ToString().Trim() == _mainSheet.Cells[i, _lxSpecNameCol].Value.ToString().Trim()) 
											&& (_mainSheet.Cells[vRow, vCol].Value.ToString().Trim() == _mainSheet.Cells[i, vCol].Value.ToString().Trim()))	
										{
											vCnt++;
											if (i.Equals(_mainSheet.RowCount -1))
											{
												_mainSheet.Cells[vRow, vCol].RowSpan = vCnt;
												break;
											}
										}
										else if( vCnt > 0 && ((_mainSheet.Cells[vRow, _lxItemNameCol].Value.ToString().Trim() != _mainSheet.Cells[i, _lxItemNameCol].Value.ToString().Trim()) 
											|| (_mainSheet.Cells[vRow, _lxSpecNameCol].Value.ToString().Trim() != _mainSheet.Cells[i, _lxSpecNameCol].Value.ToString().Trim())))
										{
											_mainSheet.Cells[vRow, vCol].RowSpan = vCnt;
											break;
										}
									}
								}
								vRow		= vRow + vCnt-1; 
							}
						}

						for ( int i = 0; i < _mainSheet.Rows.Count; i++)
						{
							_mainSheet.Rows[i].BackColor = Color.White; 
							if (_mainSheet.Cells[i, _lxReqNoCol].Value.ToString() != "")
							{
								_mainSheet.Rows[i].BackColor = Color.Gold; 
							}
						}
					}
					else
					{
						spd_main.ClearAll();
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
					}	
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

		private void Tbtn_PrintProcess()
		{
			this.Cursor = Cursors.WaitCursor;

			if (cmb_vendor.SelectedIndex < 0 && txt_itemCd.Text == "")
			{
				ClassLib.ComFunction.User_Message("First of All, Input Data Vendor Or Item.", "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				string sDir		= "";
				string sPara	= "";
				
				sDir   = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_QC_Shipping_List");
				sPara  = " /rp ";
				sPara += "'" + ClassLib.ComVar.This_Factory +		"' ";
				sPara += "'" + this.dpick_from.Text.Replace("-","") +		"' ";
				sPara += "'" + this.dpick_to.Text.Replace("-","") +		"' ";
				sPara += "'" + COM.ComFunction.Param_Combo(cmb_vendor, "%") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, "%") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_colorCd, "%") +		"' ";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

				MyReport.Text = "Shipping List sheet";
				MyReport.Show();			
			}
		}

		#endregion

		#region 컨트롤 이벤트

		private void Txt_VendorCodeTextChangedProcess()
		{
			try
			{
				_isAccessible = false;
				DataTable vDt = new DataTable();
				vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_vendorCode.Text.Trim());
				COM.ComCtl.Set_ComboList(vDt, cmb_vendor, 0, 1, true, 79, 141);

				if (vDt.Rows.Count > 0 && vDt.Rows.Count < 2)
					cmb_vendor.SelectedIndex = 1; 
				else if (vDt == null || vDt.Rows.Count <= 0) 
					cmb_vendor.SelectedIndex = 0; 

				vDt.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				_isAccessible = true;
			}
		}

		private void Cmb_VendorSelectedValueChangedProcess()
		{
			try
			{
				if (_isAccessible)
				{
					txt_vendorCode.Text		 = cmb_vendor.SelectedValue.ToString();
					cmb_vendor.SelectedValue = txt_vendorCode.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cmb_vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_VendorSelectedValueChangedProcess();
		}
		
		private void txt_vendorCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
			{
				Txt_VendorCodeTextChangedProcess();		
				ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
			}
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			string vCurDate	= dpick_from.Text.Replace("-",""); 
			dpick_to.Value	= dpick_from.Value.AddDays(6); 
		}	

		private void btn_itemSearch_Click(object sender, System.EventArgs e)
		{
			try
			{	
				COM.ComVar.Parameter_PopUp		= new string[1];
				COM.ComVar.Parameter_PopUp[0]	= "Item";

				FlexBase.MaterialBase.Pop_Item_List vPopup = new FlexBase.MaterialBase.Pop_Item_List();
				vPopup.ShowDialog(); 
			
				if (COM.ComVar.Parameter_PopUp[0] != "")
				{
					txt_itemCd.Text		= ClassLib.ComVar.Parameter_PopUp[0];
					txt_itemNm.Text		= ClassLib.ComVar.Parameter_PopUp[1];
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void btn_colorSearch_Click(object sender, System.EventArgs e)
		{
			try
			{	
				COM.ComVar.Parameter_PopUp		= new string[1];
				COM.ComVar.Parameter_PopUp[0]	= "Color";

				FlexBase.MaterialBase.Pop_Item_List vPopup = new FlexBase.MaterialBase.Pop_Item_List();
				vPopup.ShowDialog(); 
			
				if (COM.ComVar.Parameter_PopUp[4] != "")
				{
					txt_colorCd.Text	= ClassLib.ComVar.Parameter_PopUp[4];
					txt_colorNm.Text	= ClassLib.ComVar.Parameter_PopUp[5];
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		#endregion

		#region 버튼 이벤트

		#endregion

		#region 그리드 이벤트

		#endregion

		#endregion

		#region DB Connect
 		
		
		/// <summary>
		/// PKG_SBO_OUT_TAIL : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBO_OUT_TAIL : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SQL_SHIP_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SQL_LAB_REQUEST.SELECT_SQL_SHIP_LIST";

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_TO";
			MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[5] = "ARG_COLOR_CD";
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
			MyOraDB.Parameter_Values[0] =  ClassLib.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = this.dpick_from.Text.Replace("-","");
			MyOraDB.Parameter_Values[2] = this.dpick_to.Text.Replace("-","");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_vendor, "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_TextBox(txt_itemCd, "");
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_TextBox(txt_colorCd, "");
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion	


	}
}

