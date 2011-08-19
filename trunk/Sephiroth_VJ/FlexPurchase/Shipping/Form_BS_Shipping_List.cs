using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;

namespace FlexPurchase.Shipping
{
	public class Form_BS_Shipping_List : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.Label lbl_shipYmd;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Label lbl_packing;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.Label lbl_qty;
		private System.Windows.Forms.Label lbl_remarks;
		private System.Windows.Forms.TextBox txt_remarks;
		private System.Windows.Forms.DateTimePicker dpick_shipYmd;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_shipNo;
		private C1.Win.C1List.C1Combo cmb_shipNo;
		private C1.Win.C1List.C1Combo cmb_size;
		private System.Windows.Forms.Label lbl_size;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.TextBox txt_shipQty;
		private System.Windows.Forms.TextBox txt_styleName;
		private System.Windows.Forms.TextBox txt_styleCode;
		private System.Windows.Forms.TextBox txt_purQty;
		private System.Windows.Forms.Label lbl_materialType;
		private C1.Win.C1List.C1Combo cmb_materialType;
		private System.Windows.Forms.Label lbl_gender;
		private System.Windows.Forms.TextBox txt_gender;
		private System.Windows.Forms.TextBox txt_presto;
		private System.Windows.Forms.Label lbl_obsType;
		private C1.Win.C1List.C1Combo cmb_obsType;
		private System.Windows.Forms.TextBox txt_packing;
		private System.Windows.Forms.Label btn_headSearch;
		private COM.FSP fgrid_tail;
		private System.Windows.Forms.Panel pnl_btn;
		private System.Windows.Forms.ContextMenu ctx_tail;
		private System.Windows.Forms.Label btn_Trade;
		private System.Windows.Forms.Label btn_ShipCreate;
		private System.Windows.Forms.MenuItem mnu_Data;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_rate;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Label btn_packing;
		private System.Windows.Forms.Label btn_barcode;
		private C1.Win.C1List.C1Combo cmb_reason;
		private System.Windows.Forms.Label lbl_reason;
		private System.Windows.Forms.MenuItem mnu_shipping;
		private System.Windows.Forms.MenuItem mnu_ship;
		private System.Windows.Forms.MenuItem mnu_notShip;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmb_shipYN;

		#endregion 

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private System.EventHandler _cmbShipNoEventHandler = null;
		private bool _practicable	= false;
		private double _orignalQty	= 0.0;
		private int _count			= 1;
		private const int _maxPrice = 50;
		private const string _CBDCurrency = "USD";

		private Hashtable _cellCombo = null;

		// 그리드 수정 가능 조건
		private string _save = "S", _packing = "P", _barcode = "B", _invoice = "I", _trade = "T";
		private const int _validate_createPK = 10, _validate_createBC = 20, _validate_createSC = 30, _validate_trade = 40;
		private const int _validate_cancelPK = 50, _validate_cancelBC = 60, _validate_cancelSC = 70;

		private int _shipYNCol			= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_YN;
		private int _outsideYNCol		= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxOUTSIDE_YN;
		private int _shipQtyCol			= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_QTY;
		private int _packingUnitQtyCol  = (int)ClassLib.TBSBS_SHIPPING_TAIL.IxPK_UNIT_QTY;
		private int _CTCol				= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCT_QTY;
		private int _packingNoCol		= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxPK_NO;
		private int _packingNoFromCol	= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxPK_NO_FROM;
		private int _packingNoToCol		= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxPK_NO_TO;
		private int _custCdCol			= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCUST_CD;
		private int _custNameCol		= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxVENDOR;
        private int _statusCol			= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSTATUS;
		private int _purPriceCol		= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxPUR_PRICE;
		private int _cbdPriceCol		= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCBD_PRICE;
		private int _shipPriceCol		= (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_PRICE;

		private string[] _shipNoTitles;
		private int[] _shipNoWidth;
		private bool[] _shipNoVisible;

		private double vPriceRate;
		private System.Windows.Forms.Label btn_search;

		private Pop_BS_Shipping_List_Schedule_2 pop_shippingList;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.MenuItem mnu_usage;
		private System.Windows.Forms.MenuItem mnu_autoCalc;
		private System.Windows.Forms.MenuItem mnu_ceiling;
		private System.Windows.Forms.MenuItem mnu_truncate;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem mnu_pkUnitQty;
		private System.Windows.Forms.MenuItem mnu_rounding;
		private System.Windows.Forms.Label btn_allTrade;
		private System.Windows.Forms.Label btn_history;
		private System.Windows.Forms.MenuItem mnu_VendorChange;
		private System.Windows.Forms.Label btn_Purchase;
		private System.Windows.Forms.Label btn_Change;
		private System.Windows.Forms.TextBox txt_obsId;
		private System.Windows.Forms.TextBox txt_mrpShipNo;
		private System.Windows.Forms.Label btn_Export;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnu_Outside;
		private System.Windows.Forms.MenuItem mnu_NotOutside;
		private C1.Win.C1List.C1Combo cmb_reason_s;
		private Pop_BS_Shipping_List_Wait vWaitPop = null;

		#endregion

		#region 생성자 / 소멸자

		public Form_BS_Shipping_List()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BS_Shipping_List));
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
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style49 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style50 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style51 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style52 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style53 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style54 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style55 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style56 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style57 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style58 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style59 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style60 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style61 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style62 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style63 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style64 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.fgrid_tail = new COM.FSP();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_reason_s = new C1.Win.C1List.C1Combo();
            this.btn_Export = new System.Windows.Forms.Label();
            this.txt_mrpShipNo = new System.Windows.Forms.TextBox();
            this.txt_obsId = new System.Windows.Forms.TextBox();
            this.btn_allTrade = new System.Windows.Forms.Label();
            this.btn_Purchase = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Label();
            this.btn_history = new System.Windows.Forms.Label();
            this.btn_Trade = new System.Windows.Forms.Label();
            this.btn_barcode = new System.Windows.Forms.Label();
            this.btn_packing = new System.Windows.Forms.Label();
            this.cmb_shipYN = new C1.Win.C1List.C1Combo();
            this.cmb_reason = new C1.Win.C1List.C1Combo();
            this.lbl_reason = new System.Windows.Forms.Label();
            this.cmb_size = new C1.Win.C1List.C1Combo();
            this.lbl_size = new System.Windows.Forms.Label();
            this.btn_ShipCreate = new System.Windows.Forms.Label();
            this.txt_packing = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.txt_shipQty = new System.Windows.Forms.TextBox();
            this.txt_presto = new System.Windows.Forms.TextBox();
            this.lbl_obsType = new System.Windows.Forms.Label();
            this.cmb_obsType = new C1.Win.C1List.C1Combo();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.txt_purQty = new System.Windows.Forms.TextBox();
            this.lbl_materialType = new System.Windows.Forms.Label();
            this.cmb_materialType = new C1.Win.C1List.C1Combo();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_packing = new System.Windows.Forms.Label();
            this.lbl_style = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_headSearch = new System.Windows.Forms.Label();
            this.dpick_shipYmd = new System.Windows.Forms.DateTimePicker();
            this.lbl_remarks = new System.Windows.Forms.Label();
            this.txt_styleName = new System.Windows.Forms.TextBox();
            this.lbl_shipYmd = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.lbl_shipNo = new System.Windows.Forms.Label();
            this.cmb_shipNo = new C1.Win.C1List.C1Combo();
            this.txt_styleCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.ctx_tail = new System.Windows.Forms.ContextMenu();
            this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
            this.mnu_usage = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_Data = new System.Windows.Forms.MenuItem();
            this.mnu_rate = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnu_shipping = new System.Windows.Forms.MenuItem();
            this.mnu_ship = new System.Windows.Forms.MenuItem();
            this.mnu_notShip = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnu_Outside = new System.Windows.Forms.MenuItem();
            this.mnu_NotOutside = new System.Windows.Forms.MenuItem();
            this.mnu_autoCalc = new System.Windows.Forms.MenuItem();
            this.mnu_ceiling = new System.Windows.Forms.MenuItem();
            this.mnu_rounding = new System.Windows.Forms.MenuItem();
            this.mnu_truncate = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.mnu_pkUnitQty = new System.Windows.Forms.MenuItem();
            this.mnu_VendorChange = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_btn.SuspendLayout();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_tail)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reason_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipYN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_materialType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
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
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
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
            // tbtn_Confirm
            // 
            this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.pnl_btn);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "31.7708333333333:False:True;60.0694444444444:False:False;5.38194444444444:False:T" +
                "rue;\t0.393700787401575:False:True;97.6377952755905:False:False;0.393700787401575" +
                ":False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 30;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_btn
            // 
            this.pnl_btn.Controls.Add(this.btn_delete);
            this.pnl_btn.Controls.Add(this.btn_recover);
            this.pnl_btn.Controls.Add(this.btn_Insert);
            this.pnl_btn.Controls.Add(this.btn_search);
            this.pnl_btn.Location = new System.Drawing.Point(12, 541);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(992, 31);
            this.pnl_btn.TabIndex = 3;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_delete.ImageIndex = 5;
            this.btn_delete.ImageList = this.image_List;
            this.btn_delete.Location = new System.Drawing.Point(830, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 24);
            this.btn_delete.TabIndex = 366;
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
            this.btn_recover.Location = new System.Drawing.Point(911, 4);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 24);
            this.btn_recover.TabIndex = 365;
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
            this.btn_Insert.Location = new System.Drawing.Point(749, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 24);
            this.btn_Insert.TabIndex = 364;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_search.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_search.ImageIndex = 13;
            this.btn_search.ImageList = this.image_List;
            this.btn_search.Location = new System.Drawing.Point(668, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(80, 23);
            this.btn_search.TabIndex = 359;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.fgrid_tail);
            this.pnl_main.Location = new System.Drawing.Point(12, 191);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(992, 346);
            this.pnl_main.TabIndex = 1;
            // 
            // fgrid_tail
            // 
            this.fgrid_tail.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_tail.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_tail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_tail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_tail.Location = new System.Drawing.Point(0, 0);
            this.fgrid_tail.Name = "fgrid_tail";
            this.fgrid_tail.Size = new System.Drawing.Size(992, 346);
            this.fgrid_tail.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_tail.Styles"));
            this.fgrid_tail.TabIndex = 0;
            this.fgrid_tail.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_tail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_tail_MouseUp);
            this.fgrid_tail.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            this.fgrid_tail.DoubleClick += new System.EventHandler(this.fgrid_tail_DoubleClick);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_reason_s);
            this.pnl_head.Controls.Add(this.btn_Export);
            this.pnl_head.Controls.Add(this.txt_mrpShipNo);
            this.pnl_head.Controls.Add(this.txt_obsId);
            this.pnl_head.Controls.Add(this.btn_allTrade);
            this.pnl_head.Controls.Add(this.btn_Purchase);
            this.pnl_head.Controls.Add(this.btn_Change);
            this.pnl_head.Controls.Add(this.btn_history);
            this.pnl_head.Controls.Add(this.btn_Trade);
            this.pnl_head.Controls.Add(this.btn_barcode);
            this.pnl_head.Controls.Add(this.btn_packing);
            this.pnl_head.Controls.Add(this.cmb_shipYN);
            this.pnl_head.Controls.Add(this.cmb_reason);
            this.pnl_head.Controls.Add(this.lbl_reason);
            this.pnl_head.Controls.Add(this.cmb_size);
            this.pnl_head.Controls.Add(this.lbl_size);
            this.pnl_head.Controls.Add(this.btn_ShipCreate);
            this.pnl_head.Controls.Add(this.txt_packing);
            this.pnl_head.Controls.Add(this.lbl_gender);
            this.pnl_head.Controls.Add(this.lbl_qty);
            this.pnl_head.Controls.Add(this.txt_shipQty);
            this.pnl_head.Controls.Add(this.txt_presto);
            this.pnl_head.Controls.Add(this.lbl_obsType);
            this.pnl_head.Controls.Add(this.cmb_obsType);
            this.pnl_head.Controls.Add(this.txt_gender);
            this.pnl_head.Controls.Add(this.txt_purQty);
            this.pnl_head.Controls.Add(this.lbl_materialType);
            this.pnl_head.Controls.Add(this.cmb_materialType);
            this.pnl_head.Controls.Add(this.txt_remarks);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_status);
            this.pnl_head.Controls.Add(this.lbl_packing);
            this.pnl_head.Controls.Add(this.lbl_style);
            this.pnl_head.Controls.Add(this.txt_status);
            this.pnl_head.Controls.Add(this.btn_headSearch);
            this.pnl_head.Controls.Add(this.dpick_shipYmd);
            this.pnl_head.Controls.Add(this.lbl_remarks);
            this.pnl_head.Controls.Add(this.txt_styleName);
            this.pnl_head.Controls.Add(this.lbl_shipYmd);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.lbl_shipNo);
            this.pnl_head.Controls.Add(this.cmb_shipNo);
            this.pnl_head.Controls.Add(this.txt_styleCode);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 183);
            this.pnl_head.TabIndex = 0;
            // 
            // cmb_reason_s
            // 
            this.cmb_reason_s.AddItemCols = 0;
            this.cmb_reason_s.AddItemSeparator = ';';
            this.cmb_reason_s.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reason_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reason_s.Caption = "";
            this.cmb_reason_s.CaptionHeight = 17;
            this.cmb_reason_s.CaptionStyle = style1;
            this.cmb_reason_s.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reason_s.ColumnCaptionHeight = 18;
            this.cmb_reason_s.ColumnFooterHeight = 18;
            this.cmb_reason_s.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reason_s.ContentHeight = 16;
            this.cmb_reason_s.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reason_s.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_reason_s.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reason_s.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reason_s.EditorHeight = 16;
            this.cmb_reason_s.EvenRowStyle = style2;
            this.cmb_reason_s.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reason_s.FooterStyle = style3;
            this.cmb_reason_s.GapHeight = 2;
            this.cmb_reason_s.HeadingStyle = style4;
            this.cmb_reason_s.HighLightRowStyle = style5;
            this.cmb_reason_s.ItemHeight = 15;
            this.cmb_reason_s.Location = new System.Drawing.Point(220, 84);
            this.cmb_reason_s.MatchEntryTimeout = ((long)(2000));
            this.cmb_reason_s.MaxDropDownItems = ((short)(5));
            this.cmb_reason_s.MaxLength = 32767;
            this.cmb_reason_s.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reason_s.Name = "cmb_reason_s";
            this.cmb_reason_s.OddRowStyle = style6;
            this.cmb_reason_s.PartialRightColumn = false;
            this.cmb_reason_s.PropBag = resources.GetString("cmb_reason_s.PropBag");
            this.cmb_reason_s.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reason_s.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reason_s.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reason_s.SelectedStyle = style7;
            this.cmb_reason_s.Size = new System.Drawing.Size(110, 20);
            this.cmb_reason_s.Style = style8;
            this.cmb_reason_s.TabIndex = 366;
            this.cmb_reason_s.SelectedValueChanged += new System.EventHandler(this.cmb_reason_s_SelectedValueChanged);
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Export.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Export.ImageIndex = 0;
            this.btn_Export.ImageList = this.img_Button;
            this.btn_Export.Location = new System.Drawing.Point(653, 152);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(80, 23);
            this.btn_Export.TabIndex = 365;
            this.btn_Export.Text = "Export";
            this.btn_Export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            this.btn_Export.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_Export.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // txt_mrpShipNo
            // 
            this.txt_mrpShipNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mrpShipNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mrpShipNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_mrpShipNo.Location = new System.Drawing.Point(432, 152);
            this.txt_mrpShipNo.Name = "txt_mrpShipNo";
            this.txt_mrpShipNo.ReadOnly = true;
            this.txt_mrpShipNo.Size = new System.Drawing.Size(192, 21);
            this.txt_mrpShipNo.TabIndex = 364;
            this.txt_mrpShipNo.Visible = false;
            // 
            // txt_obsId
            // 
            this.txt_obsId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_obsId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_obsId.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_obsId.Location = new System.Drawing.Point(109, 106);
            this.txt_obsId.Name = "txt_obsId";
            this.txt_obsId.ReadOnly = true;
            this.txt_obsId.Size = new System.Drawing.Size(110, 21);
            this.txt_obsId.TabIndex = 363;
            // 
            // btn_allTrade
            // 
            this.btn_allTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_allTrade.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_allTrade.ImageIndex = 0;
            this.btn_allTrade.ImageList = this.img_Button;
            this.btn_allTrade.Location = new System.Drawing.Point(332, 152);
            this.btn_allTrade.Name = "btn_allTrade";
            this.btn_allTrade.Size = new System.Drawing.Size(80, 23);
            this.btn_allTrade.TabIndex = 360;
            this.btn_allTrade.Text = "All Trade";
            this.btn_allTrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_allTrade.Click += new System.EventHandler(this.btn_allTrade_Click);
            this.btn_allTrade.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_allTrade.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_Purchase
            // 
            this.btn_Purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Purchase.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Purchase.ImageIndex = 0;
            this.btn_Purchase.ImageList = this.img_Button;
            this.btn_Purchase.Location = new System.Drawing.Point(815, 152);
            this.btn_Purchase.Name = "btn_Purchase";
            this.btn_Purchase.Size = new System.Drawing.Size(80, 23);
            this.btn_Purchase.TabIndex = 362;
            this.btn_Purchase.Text = "Purchase";
            this.btn_Purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Purchase.Click += new System.EventHandler(this.btn_Purchase_Click);
            this.btn_Purchase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_Purchase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Change.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Change.ImageIndex = 0;
            this.btn_Change.ImageList = this.img_Button;
            this.btn_Change.Location = new System.Drawing.Point(734, 152);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(80, 23);
            this.btn_Change.TabIndex = 362;
            this.btn_Change.Text = "Ship Change";
            this.btn_Change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            this.btn_Change.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_Change.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_history.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_history.ImageIndex = 0;
            this.btn_history.ImageList = this.img_Button;
            this.btn_history.Location = new System.Drawing.Point(896, 152);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(80, 23);
            this.btn_history.TabIndex = 361;
            this.btn_history.Text = "History";
            this.btn_history.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            this.btn_history.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_history.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_Trade
            // 
            this.btn_Trade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Trade.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Trade.ImageIndex = 0;
            this.btn_Trade.ImageList = this.img_Button;
            this.btn_Trade.Location = new System.Drawing.Point(251, 152);
            this.btn_Trade.Name = "btn_Trade";
            this.btn_Trade.Size = new System.Drawing.Size(80, 23);
            this.btn_Trade.TabIndex = 360;
            this.btn_Trade.Text = "Trade";
            this.btn_Trade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Trade.Click += new System.EventHandler(this.btn_trade_Click);
            this.btn_Trade.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_Trade.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_barcode
            // 
            this.btn_barcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_barcode.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_barcode.ImageIndex = 0;
            this.btn_barcode.ImageList = this.img_Button;
            this.btn_barcode.Location = new System.Drawing.Point(170, 152);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(80, 23);
            this.btn_barcode.TabIndex = 360;
            this.btn_barcode.Text = "Barcode";
            this.btn_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_barcode.Click += new System.EventHandler(this.btn_barcode_Click);
            // 
            // btn_packing
            // 
            this.btn_packing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_packing.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_packing.ImageIndex = 0;
            this.btn_packing.ImageList = this.img_Button;
            this.btn_packing.Location = new System.Drawing.Point(89, 152);
            this.btn_packing.Name = "btn_packing";
            this.btn_packing.Size = new System.Drawing.Size(80, 23);
            this.btn_packing.TabIndex = 360;
            this.btn_packing.Text = "Packing";
            this.btn_packing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_packing.Click += new System.EventHandler(this.btn_packing_Click);
            // 
            // cmb_shipYN
            // 
            this.cmb_shipYN.AddItemCols = 0;
            this.cmb_shipYN.AddItemSeparator = ';';
            this.cmb_shipYN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipYN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipYN.Caption = "";
            this.cmb_shipYN.CaptionHeight = 17;
            this.cmb_shipYN.CaptionStyle = style9;
            this.cmb_shipYN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipYN.ColumnCaptionHeight = 18;
            this.cmb_shipYN.ColumnFooterHeight = 18;
            this.cmb_shipYN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipYN.ContentHeight = 16;
            this.cmb_shipYN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipYN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipYN.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipYN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipYN.EditorHeight = 16;
            this.cmb_shipYN.EvenRowStyle = style10;
            this.cmb_shipYN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipYN.FooterStyle = style11;
            this.cmb_shipYN.GapHeight = 2;
            this.cmb_shipYN.HeadingStyle = style12;
            this.cmb_shipYN.HighLightRowStyle = style13;
            this.cmb_shipYN.ItemHeight = 15;
            this.cmb_shipYN.Location = new System.Drawing.Point(755, 128);
            this.cmb_shipYN.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipYN.MaxDropDownItems = ((short)(5));
            this.cmb_shipYN.MaxLength = 32767;
            this.cmb_shipYN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipYN.Name = "cmb_shipYN";
            this.cmb_shipYN.OddRowStyle = style14;
            this.cmb_shipYN.PartialRightColumn = false;
            this.cmb_shipYN.PropBag = resources.GetString("cmb_shipYN.PropBag");
            this.cmb_shipYN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipYN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipYN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipYN.SelectedStyle = style15;
            this.cmb_shipYN.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipYN.Style = style16;
            this.cmb_shipYN.TabIndex = 4;
            // 
            // cmb_reason
            // 
            this.cmb_reason.AddItemCols = 0;
            this.cmb_reason.AddItemSeparator = ';';
            this.cmb_reason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reason.Caption = "";
            this.cmb_reason.CaptionHeight = 17;
            this.cmb_reason.CaptionStyle = style17;
            this.cmb_reason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reason.ColumnCaptionHeight = 18;
            this.cmb_reason.ColumnFooterHeight = 18;
            this.cmb_reason.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reason.ContentHeight = 16;
            this.cmb_reason.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reason.EditorBackColor = System.Drawing.SystemColors.Control;
            this.cmb_reason.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reason.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reason.EditorHeight = 16;
            this.cmb_reason.Enabled = false;
            this.cmb_reason.EvenRowStyle = style18;
            this.cmb_reason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reason.FooterStyle = style19;
            this.cmb_reason.GapHeight = 2;
            this.cmb_reason.HeadingStyle = style20;
            this.cmb_reason.HighLightRowStyle = style21;
            this.cmb_reason.ItemHeight = 15;
            this.cmb_reason.Location = new System.Drawing.Point(755, 84);
            this.cmb_reason.MatchEntryTimeout = ((long)(2000));
            this.cmb_reason.MaxDropDownItems = ((short)(5));
            this.cmb_reason.MaxLength = 32767;
            this.cmb_reason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reason.Name = "cmb_reason";
            this.cmb_reason.OddRowStyle = style22;
            this.cmb_reason.PartialRightColumn = false;
            this.cmb_reason.PropBag = resources.GetString("cmb_reason.PropBag");
            this.cmb_reason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reason.SelectedStyle = style23;
            this.cmb_reason.Size = new System.Drawing.Size(220, 20);
            this.cmb_reason.Style = style24;
            this.cmb_reason.TabIndex = 4;
            // 
            // lbl_reason
            // 
            this.lbl_reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reason.ImageIndex = 0;
            this.lbl_reason.ImageList = this.img_Label;
            this.lbl_reason.Location = new System.Drawing.Point(654, 84);
            this.lbl_reason.Name = "lbl_reason";
            this.lbl_reason.Size = new System.Drawing.Size(100, 21);
            this.lbl_reason.TabIndex = 50;
            this.lbl_reason.Text = "Request Reason";
            this.lbl_reason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_size
            // 
            this.cmb_size.AddItemCols = 0;
            this.cmb_size.AddItemSeparator = ';';
            this.cmb_size.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_size.Caption = "";
            this.cmb_size.CaptionHeight = 17;
            this.cmb_size.CaptionStyle = style25;
            this.cmb_size.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_size.ColumnCaptionHeight = 18;
            this.cmb_size.ColumnFooterHeight = 18;
            this.cmb_size.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_size.ContentHeight = 16;
            this.cmb_size.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_size.EditorBackColor = System.Drawing.SystemColors.Control;
            this.cmb_size.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_size.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_size.EditorHeight = 16;
            this.cmb_size.Enabled = false;
            this.cmb_size.EvenRowStyle = style26;
            this.cmb_size.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_size.FooterStyle = style27;
            this.cmb_size.GapHeight = 2;
            this.cmb_size.HeadingStyle = style28;
            this.cmb_size.HighLightRowStyle = style29;
            this.cmb_size.ItemHeight = 15;
            this.cmb_size.Location = new System.Drawing.Point(755, 106);
            this.cmb_size.MatchEntryTimeout = ((long)(2000));
            this.cmb_size.MaxDropDownItems = ((short)(5));
            this.cmb_size.MaxLength = 32767;
            this.cmb_size.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.OddRowStyle = style30;
            this.cmb_size.PartialRightColumn = false;
            this.cmb_size.PropBag = resources.GetString("cmb_size.PropBag");
            this.cmb_size.ReadOnly = true;
            this.cmb_size.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_size.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_size.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_size.SelectedStyle = style31;
            this.cmb_size.Size = new System.Drawing.Size(220, 20);
            this.cmb_size.Style = style32;
            this.cmb_size.TabIndex = 4;
            this.cmb_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_size_KeyPress);
            // 
            // lbl_size
            // 
            this.lbl_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_size.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.ImageIndex = 0;
            this.lbl_size.ImageList = this.img_Label;
            this.lbl_size.Location = new System.Drawing.Point(654, 106);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(100, 21);
            this.lbl_size.TabIndex = 50;
            this.lbl_size.Text = "Item Division";
            this.lbl_size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ShipCreate
            // 
            this.btn_ShipCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_ShipCreate.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_ShipCreate.ImageIndex = 0;
            this.btn_ShipCreate.ImageList = this.img_Button;
            this.btn_ShipCreate.Location = new System.Drawing.Point(8, 152);
            this.btn_ShipCreate.Name = "btn_ShipCreate";
            this.btn_ShipCreate.Size = new System.Drawing.Size(80, 23);
            this.btn_ShipCreate.TabIndex = 355;
            this.btn_ShipCreate.Text = " Ship Create";
            this.btn_ShipCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ShipCreate.Click += new System.EventHandler(this.btn_shipCreate_Click);
            this.btn_ShipCreate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_ShipCreate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // txt_packing
            // 
            this.txt_packing.BackColor = System.Drawing.SystemColors.Window;
            this.txt_packing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_packing.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_packing.Location = new System.Drawing.Point(109, 128);
            this.txt_packing.MaxLength = 4;
            this.txt_packing.Name = "txt_packing";
            this.txt_packing.Size = new System.Drawing.Size(220, 21);
            this.txt_packing.TabIndex = 359;
            // 
            // lbl_gender
            // 
            this.lbl_gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ImageIndex = 0;
            this.lbl_gender.ImageList = this.img_Label;
            this.lbl_gender.Location = new System.Drawing.Point(331, 84);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_gender.TabIndex = 50;
            this.lbl_gender.Text = "Gender / Presto";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_qty
            // 
            this.lbl_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_qty.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.ImageIndex = 0;
            this.lbl_qty.ImageList = this.img_Label;
            this.lbl_qty.Location = new System.Drawing.Point(331, 106);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(100, 21);
            this.lbl_qty.TabIndex = 50;
            this.lbl_qty.Text = "Plan / Shipping";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_shipQty
            // 
            this.txt_shipQty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_shipQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_shipQty.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_shipQty.Location = new System.Drawing.Point(542, 106);
            this.txt_shipQty.MaxLength = 10;
            this.txt_shipQty.Name = "txt_shipQty";
            this.txt_shipQty.ReadOnly = true;
            this.txt_shipQty.Size = new System.Drawing.Size(110, 21);
            this.txt_shipQty.TabIndex = 9;
            this.txt_shipQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_shipQty.Enter += new System.EventHandler(this.txt_shipQty_Enter);
            // 
            // txt_presto
            // 
            this.txt_presto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_presto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_presto.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_presto.Location = new System.Drawing.Point(542, 84);
            this.txt_presto.MaxLength = 10;
            this.txt_presto.Name = "txt_presto";
            this.txt_presto.ReadOnly = true;
            this.txt_presto.Size = new System.Drawing.Size(110, 21);
            this.txt_presto.TabIndex = 9;
            // 
            // lbl_obsType
            // 
            this.lbl_obsType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obsType.ImageIndex = 0;
            this.lbl_obsType.ImageList = this.img_Label;
            this.lbl_obsType.Location = new System.Drawing.Point(8, 106);
            this.lbl_obsType.Name = "lbl_obsType";
            this.lbl_obsType.Size = new System.Drawing.Size(100, 21);
            this.lbl_obsType.TabIndex = 356;
            this.lbl_obsType.Text = "OBS ID / Type";
            this.lbl_obsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_obsType
            // 
            this.cmb_obsType.AddItemCols = 0;
            this.cmb_obsType.AddItemSeparator = ';';
            this.cmb_obsType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_obsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_obsType.Caption = "";
            this.cmb_obsType.CaptionHeight = 17;
            this.cmb_obsType.CaptionStyle = style33;
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
            this.cmb_obsType.Enabled = false;
            this.cmb_obsType.EvenRowStyle = style34;
            this.cmb_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obsType.FooterStyle = style35;
            this.cmb_obsType.GapHeight = 2;
            this.cmb_obsType.HeadingStyle = style36;
            this.cmb_obsType.HighLightRowStyle = style37;
            this.cmb_obsType.ItemHeight = 15;
            this.cmb_obsType.Location = new System.Drawing.Point(220, 106);
            this.cmb_obsType.MatchEntryTimeout = ((long)(2000));
            this.cmb_obsType.MaxDropDownItems = ((short)(5));
            this.cmb_obsType.MaxLength = 32767;
            this.cmb_obsType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_obsType.Name = "cmb_obsType";
            this.cmb_obsType.OddRowStyle = style38;
            this.cmb_obsType.PartialRightColumn = false;
            this.cmb_obsType.PropBag = resources.GetString("cmb_obsType.PropBag");
            this.cmb_obsType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_obsType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_obsType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_obsType.SelectedStyle = style39;
            this.cmb_obsType.Size = new System.Drawing.Size(109, 20);
            this.cmb_obsType.Style = style40;
            this.cmb_obsType.TabIndex = 355;
            // 
            // txt_gender
            // 
            this.txt_gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gender.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_gender.Location = new System.Drawing.Point(432, 84);
            this.txt_gender.MaxLength = 10;
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.ReadOnly = true;
            this.txt_gender.Size = new System.Drawing.Size(109, 21);
            this.txt_gender.TabIndex = 9;
            // 
            // txt_purQty
            // 
            this.txt_purQty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_purQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_purQty.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_purQty.Location = new System.Drawing.Point(432, 106);
            this.txt_purQty.MaxLength = 10;
            this.txt_purQty.Name = "txt_purQty";
            this.txt_purQty.ReadOnly = true;
            this.txt_purQty.Size = new System.Drawing.Size(109, 21);
            this.txt_purQty.TabIndex = 10;
            this.txt_purQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_materialType
            // 
            this.lbl_materialType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_materialType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_materialType.ImageIndex = 1;
            this.lbl_materialType.ImageList = this.img_Label;
            this.lbl_materialType.Location = new System.Drawing.Point(8, 84);
            this.lbl_materialType.Name = "lbl_materialType";
            this.lbl_materialType.Size = new System.Drawing.Size(100, 21);
            this.lbl_materialType.TabIndex = 56;
            this.lbl_materialType.Text = "Ship Type";
            this.lbl_materialType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_materialType
            // 
            this.cmb_materialType.AddItemCols = 0;
            this.cmb_materialType.AddItemSeparator = ';';
            this.cmb_materialType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_materialType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_materialType.Caption = "";
            this.cmb_materialType.CaptionHeight = 17;
            this.cmb_materialType.CaptionStyle = style41;
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
            this.cmb_materialType.EvenRowStyle = style42;
            this.cmb_materialType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_materialType.FooterStyle = style43;
            this.cmb_materialType.GapHeight = 2;
            this.cmb_materialType.HeadingStyle = style44;
            this.cmb_materialType.HighLightRowStyle = style45;
            this.cmb_materialType.ItemHeight = 15;
            this.cmb_materialType.Location = new System.Drawing.Point(109, 84);
            this.cmb_materialType.MatchEntryTimeout = ((long)(2000));
            this.cmb_materialType.MaxDropDownItems = ((short)(5));
            this.cmb_materialType.MaxLength = 32767;
            this.cmb_materialType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_materialType.Name = "cmb_materialType";
            this.cmb_materialType.OddRowStyle = style46;
            this.cmb_materialType.PartialRightColumn = false;
            this.cmb_materialType.PropBag = resources.GetString("cmb_materialType.PropBag");
            this.cmb_materialType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_materialType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_materialType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_materialType.SelectedStyle = style47;
            this.cmb_materialType.Size = new System.Drawing.Size(110, 20);
            this.cmb_materialType.Style = style48;
            this.cmb_materialType.TabIndex = 55;
            this.cmb_materialType.SelectedValueChanged += new System.EventHandler(this.cmb_materialType_SelectedValueChanged);
            // 
            // txt_remarks
            // 
            this.txt_remarks.BackColor = System.Drawing.Color.White;
            this.txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remarks.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_remarks.Location = new System.Drawing.Point(432, 128);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(220, 21);
            this.txt_remarks.TabIndex = 12;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 167);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ImageIndex = 0;
            this.lbl_status.ImageList = this.img_Label;
            this.lbl_status.Location = new System.Drawing.Point(654, 40);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 21);
            this.lbl_status.TabIndex = 50;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_packing
            // 
            this.lbl_packing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_packing.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_packing.ImageIndex = 0;
            this.lbl_packing.ImageList = this.img_Label;
            this.lbl_packing.Location = new System.Drawing.Point(8, 128);
            this.lbl_packing.Name = "lbl_packing";
            this.lbl_packing.Size = new System.Drawing.Size(100, 21);
            this.lbl_packing.TabIndex = 50;
            this.lbl_packing.Text = "Packing";
            this.lbl_packing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(331, 62);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 50;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_status.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_status.Location = new System.Drawing.Point(755, 40);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(220, 21);
            this.txt_status.TabIndex = 6;
            // 
            // btn_headSearch
            // 
            this.btn_headSearch.ImageIndex = 27;
            this.btn_headSearch.ImageList = this.img_SmallButton;
            this.btn_headSearch.Location = new System.Drawing.Point(629, 40);
            this.btn_headSearch.Name = "btn_headSearch";
            this.btn_headSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_headSearch.TabIndex = 54;
            this.btn_headSearch.Tag = "HeadSearch";
            this.btn_headSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_headSearch.Click += new System.EventHandler(this.btn_headSearch_Click);
            this.btn_headSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Up);
            this.btn_headSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Down);
            // 
            // dpick_shipYmd
            // 
            this.dpick_shipYmd.Checked = false;
            this.dpick_shipYmd.CustomFormat = "";
            this.dpick_shipYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_shipYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_shipYmd.Location = new System.Drawing.Point(109, 62);
            this.dpick_shipYmd.Name = "dpick_shipYmd";
            this.dpick_shipYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_shipYmd.Size = new System.Drawing.Size(222, 21);
            this.dpick_shipYmd.TabIndex = 2;
            this.dpick_shipYmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dpick_shipYmd_KeyPress);
            this.dpick_shipYmd.CloseUp += new System.EventHandler(this.dpick_shipYmd_CloseUp);
            // 
            // lbl_remarks
            // 
            this.lbl_remarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_remarks.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remarks.ImageIndex = 0;
            this.lbl_remarks.ImageList = this.img_Label;
            this.lbl_remarks.Location = new System.Drawing.Point(331, 128);
            this.lbl_remarks.Name = "lbl_remarks";
            this.lbl_remarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_remarks.TabIndex = 50;
            this.lbl_remarks.Text = "Remarks";
            this.lbl_remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleName
            // 
            this.txt_styleName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_styleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleName.Location = new System.Drawing.Point(542, 62);
            this.txt_styleName.Name = "txt_styleName";
            this.txt_styleName.ReadOnly = true;
            this.txt_styleName.Size = new System.Drawing.Size(433, 21);
            this.txt_styleName.TabIndex = 8;
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
            this.lbl_shipYmd.Text = "Ship Date";
            this.lbl_shipYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style49;
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
            this.cmb_factory.EvenRowStyle = style50;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style51;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style52;
            this.cmb_factory.HighLightRowStyle = style53;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style54;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style55;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style56;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_factory_KeyPress);
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
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
            this.pic_head7.Size = new System.Drawing.Size(101, 142);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 167);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 156);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // lbl_shipNo
            // 
            this.lbl_shipNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipNo.ImageIndex = 1;
            this.lbl_shipNo.ImageList = this.img_Label;
            this.lbl_shipNo.Location = new System.Drawing.Point(331, 40);
            this.lbl_shipNo.Name = "lbl_shipNo";
            this.lbl_shipNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipNo.TabIndex = 50;
            this.lbl_shipNo.Text = "Ship No";
            this.lbl_shipNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shipNo
            // 
            this.cmb_shipNo.AddItemCols = 0;
            this.cmb_shipNo.AddItemSeparator = ';';
            this.cmb_shipNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipNo.Caption = "";
            this.cmb_shipNo.CaptionHeight = 17;
            this.cmb_shipNo.CaptionStyle = style57;
            this.cmb_shipNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipNo.ColumnCaptionHeight = 18;
            this.cmb_shipNo.ColumnFooterHeight = 18;
            this.cmb_shipNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipNo.ContentHeight = 16;
            this.cmb_shipNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipNo.EditorHeight = 16;
            this.cmb_shipNo.EvenRowStyle = style58;
            this.cmb_shipNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipNo.FooterStyle = style59;
            this.cmb_shipNo.GapHeight = 2;
            this.cmb_shipNo.HeadingStyle = style60;
            this.cmb_shipNo.HighLightRowStyle = style61;
            this.cmb_shipNo.ItemHeight = 15;
            this.cmb_shipNo.Location = new System.Drawing.Point(432, 40);
            this.cmb_shipNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipNo.MaxDropDownItems = ((short)(5));
            this.cmb_shipNo.MaxLength = 32767;
            this.cmb_shipNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipNo.Name = "cmb_shipNo";
            this.cmb_shipNo.OddRowStyle = style62;
            this.cmb_shipNo.PartialRightColumn = false;
            this.cmb_shipNo.PropBag = resources.GetString("cmb_shipNo.PropBag");
            this.cmb_shipNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipNo.SelectedStyle = style63;
            this.cmb_shipNo.Size = new System.Drawing.Size(197, 20);
            this.cmb_shipNo.Style = style64;
            this.cmb_shipNo.TabIndex = 5;
            // 
            // txt_styleCode
            // 
            this.txt_styleCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_styleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCode.Location = new System.Drawing.Point(432, 62);
            this.txt_styleCode.MaxLength = 10;
            this.txt_styleCode.Name = "txt_styleCode";
            this.txt_styleCode.ReadOnly = true;
            this.txt_styleCode.Size = new System.Drawing.Size(109, 21);
            this.txt_styleCode.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(654, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ship Y/N";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(144, 168);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // ctx_tail
            // 
            this.ctx_tail.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_AllSelect,
            this.mnu_usage,
            this.menuItem1,
            this.mnu_Data,
            this.mnu_rate,
            this.menuItem5,
            this.mnu_shipping,
            this.menuItem3,
            this.mnu_autoCalc,
            this.mnu_VendorChange,
            this.menuItem2});
            // 
            // mnu_AllSelect
            // 
            this.mnu_AllSelect.Index = 0;
            this.mnu_AllSelect.Text = "All Select";
            this.mnu_AllSelect.Click += new System.EventHandler(this.mnu_AllSelect_Click);
            // 
            // mnu_usage
            // 
            this.mnu_usage.Index = 1;
            this.mnu_usage.Text = "Usage Information";
            this.mnu_usage.Click += new System.EventHandler(this.mnu_usageCheck_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // mnu_Data
            // 
            this.mnu_Data.Index = 3;
            this.mnu_Data.Text = "Value Change";
            this.mnu_Data.Click += new System.EventHandler(this.mnu_DataChange);
            // 
            // mnu_rate
            // 
            this.mnu_rate.Index = 4;
            this.mnu_rate.Text = "CBD Information";
            this.mnu_rate.Click += new System.EventHandler(this.mnu_rate_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 5;
            this.menuItem5.Text = "-";
            // 
            // mnu_shipping
            // 
            this.mnu_shipping.Index = 6;
            this.mnu_shipping.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_ship,
            this.mnu_notShip});
            this.mnu_shipping.Text = "Shipping";
            // 
            // mnu_ship
            // 
            this.mnu_ship.Index = 0;
            this.mnu_ship.Text = "Yes";
            this.mnu_ship.Click += new System.EventHandler(this.mnu_ship_Click);
            // 
            // mnu_notShip
            // 
            this.mnu_notShip.Index = 1;
            this.mnu_notShip.Text = "No";
            this.mnu_notShip.Click += new System.EventHandler(this.mnu_notShip_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 7;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_Outside,
            this.mnu_NotOutside});
            this.menuItem3.Text = "Outside";
            // 
            // mnu_Outside
            // 
            this.mnu_Outside.Index = 0;
            this.mnu_Outside.Text = "Yes";
            this.mnu_Outside.Click += new System.EventHandler(this.mnu_Outside_Click);
            // 
            // mnu_NotOutside
            // 
            this.mnu_NotOutside.Index = 1;
            this.mnu_NotOutside.Text = "No";
            this.mnu_NotOutside.Click += new System.EventHandler(this.mnu_NotOutside_Click);
            // 
            // mnu_autoCalc
            // 
            this.mnu_autoCalc.Index = 8;
            this.mnu_autoCalc.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_ceiling,
            this.mnu_rounding,
            this.mnu_truncate,
            this.menuItem7,
            this.mnu_pkUnitQty});
            this.mnu_autoCalc.Text = "Auto Calculation";
            // 
            // mnu_ceiling
            // 
            this.mnu_ceiling.Index = 0;
            this.mnu_ceiling.Text = "Ceiling";
            this.mnu_ceiling.Click += new System.EventHandler(this.mnu_ceiling_Click);
            // 
            // mnu_rounding
            // 
            this.mnu_rounding.Index = 1;
            this.mnu_rounding.Text = "Rounding";
            this.mnu_rounding.Click += new System.EventHandler(this.mnu_roundUp_Click);
            // 
            // mnu_truncate
            // 
            this.mnu_truncate.Index = 2;
            this.mnu_truncate.Text = "Truncate";
            this.mnu_truncate.Click += new System.EventHandler(this.mnu_truncate_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.Text = "-";
            // 
            // mnu_pkUnitQty
            // 
            this.mnu_pkUnitQty.Index = 4;
            this.mnu_pkUnitQty.Text = "PK Unit Qty";
            this.mnu_pkUnitQty.Click += new System.EventHandler(this.mnu_pk_Click);
            // 
            // mnu_VendorChange
            // 
            this.mnu_VendorChange.Index = 9;
            this.mnu_VendorChange.Text = "Vendor Change";
            this.mnu_VendorChange.Click += new System.EventHandler(this.mnu_VendorChange_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 10;
            this.menuItem2.Text = "-";
            // 
            // Form_BS_Shipping_List
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BS_Shipping_List";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BS_Shipping_List_Closing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_btn.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_tail)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reason_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipYN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_materialType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void fgrid_tail_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && fgrid_tail.Rows.Count > fgrid_tail.Rows.Fixed)
			{
				if (fgrid_tail.AllowEditing)
				{
					//mnu_rate.Enabled = true;
					mnu_shipping.Enabled = true;
				}
				else
				{
					//mnu_rate.Enabled = false;
					mnu_shipping.Enabled = false;
				}

				if (fgrid_tail.Cols[fgrid_tail.Col].AllowEditing && fgrid_tail.AllowEditing)
				{
					mnu_Data.Enabled = true;					
				}
				else
				{
					mnu_Data.Enabled = false;
				}

				this.ctx_tail.Show(fgrid_tail, new Point(e.X, e.Y));
			}
//			else if (e.Button == MouseButtons.Left && fgrid_tail.Rows.Fixed > fgrid_tail.MouseRow)
//			{
//				//fgrid_tail.Cols[fgrid_tail.MouseCol].AllowEditing = true;
//				//fgrid_tail.Cols[fgrid_tail.MouseCol].Sort = SortFlags.Ascending;
//				//fgrid_tail.Sort(SortFlags.Ascending, fgrid_tail.MouseCol);
//			}
		}

		private void mnu_AllSelect_Click(object sender, System.EventArgs e)
		{
			fgrid_tail.SelectAll();
		}

		private void mnu_DataChange(object sender, System.EventArgs e)
		{
			this.Grid_CellClickProcess();
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

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (this.Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.Tbtn_SaveProcess();
			}
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				if (this.Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
				{
					if (MessageBox.Show(this, "Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						txt_status.Text = "Delete";

						if (SAVE_SBS_SHIPPING_HEAD())
						{
							if (MyOraDB.Exe_Modify_Procedure() != null)
							{
								Init_Form();
								Cmb_ShipNoSettingProcess();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (!this.Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
				return;	
		
			string ship_no = "";
		
			ship_no = COM.ComFunction.Empty_Combo(cmb_shipNo, "").Substring(0, 12);

			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_Shipping_list_WH");
			string Para         = " ";
			
			#region 출력조건

			string[] vProviso  = GetSearchProviso();

			int  iCnt  = 5;
			string [] aHead =  new string[iCnt];
			
			aHead[0] = ClassLib.ComVar.This_Factory; //작업공장 코드
			aHead[1] = ClassLib.ComFunction.Empty_Combo( cmb_factory," "); //Factory
			aHead[2] = dpick_shipYmd.Text.ToString().Replace("-",""); //날짜
			aHead[3] = ClassLib.ComFunction.Empty_Combo( cmb_materialType," "); //ShipType
			aHead[4] = ClassLib.ComFunction.Empty_Combo( cmb_shipYN," "); //ShipType
			
			
			
			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();

		}


		
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (!this.Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
				return;	
		
			string ship_no = "";

			DialogResult vSelect = MessageBox.Show("All Print?", "Print", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

			if (vSelect == DialogResult.Yes)
				ship_no = COM.ComFunction.Empty_Combo(cmb_shipNo, "").Substring(0, 12);
			else if (vSelect == DialogResult.No)
				ship_no = COM.ComFunction.Empty_Combo(cmb_shipNo, "");
			else
				return;

			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_Shipping_list");
			string Para         = " ";

			#region 출력조건

			string[] vProviso  = GetSearchProviso();

			int  iCnt  = 15;
			string [] aHead =  new string[iCnt];
			
			aHead[0] = vProviso[0];
			aHead[1] = vProviso[1];
			aHead[2] = vProviso[3];
			aHead[3] = vProviso[4];
			aHead[4] = vProviso[5];
			aHead[5] = vProviso[6];
			aHead[6] = ClassLib.ComFunction.Empty_TextBox(txt_styleCode, "").Replace("-", "").Replace("NONE", "");
			aHead[7] = ClassLib.ComFunction.Empty_TextBox(txt_gender, "");
			aHead[8] = ClassLib.ComFunction.Empty_TextBox(txt_presto, "");
			aHead[9] = cmb_materialType.GetItemText(cmb_materialType.SelectedIndex, 1);
			aHead[10] = cmb_size.GetItemText(cmb_size.SelectedIndex, 1);
			aHead[11] = "";//cmb_devision.GetItemText(cmb_devision.SelectedIndex, 1);
			aHead[12] = cmb_obsType.GetItemText(cmb_obsType.SelectedIndex, 1);
			aHead[13] = ClassLib.ComFunction.Empty_Combo(cmb_shipYN, "");
			aHead[14] = ship_no;
			
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

		private void Form_BS_Shipping_List_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_tail.Rows.Fixed < fgrid_tail.Rows.Count)
			{
				string vTemp = fgrid_tail.GetCellRange(fgrid_tail.Rows.Fixed, 0, fgrid_tail.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}
		}

		private void cmb_shipNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_ShipNoSelectedValueChangedProcess();
		}

		private void txt_shipQty_Enter(object sender, System.EventArgs e)
		{
			this.Txt_ShipQtyEnterProcess();
		}

		#region 버튼 이벤트

		private void btn_shipCreate_Click(object sender, System.EventArgs e)
		{
			this.Btn_ShipCreateProcess();
		}

		private void btn_packing_Click(object sender, System.EventArgs e)
		{
			if (txt_status.Text.Equals(ClassLib.ComVar.Save))
			{
				if (Etc_ProvisoValidateCheck(_validate_createPK))
					if (MessageBox.Show(this, "Do you want packing create?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						Btn_PackingCreateProcess();
			}
			else if (txt_status.Text.Equals(ClassLib.ComVar.Packing))
			{
				if (Etc_ProvisoValidateCheck(_validate_cancelPK))
					if (MessageBox.Show(this, "Do you want to packing cancel?", "Packing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						Btn_PackingCancelProcess();
			}
		}

		private void btn_barcode_Click(object sender, System.EventArgs e)
		{
			if (txt_status.Text.Equals(ClassLib.ComVar.Packing))
			{
				if (Etc_ProvisoValidateCheck(_validate_createBC))
					if (MessageBox.Show(this, "Do you want to make barcode?", "Barcode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						Btn_BarcodeCreateProcess();
			}
			else if (txt_status.Text.Equals(ClassLib.ComVar.Barcode))
			{
				if (Etc_ProvisoValidateCheck(_validate_cancelBC))
					if (MessageBox.Show(this, "Do you want to remove barcode?", "Barcode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						Btn_BarcodeCancelProcess();
			}
		}
		
		private void btn_packingCreate_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_createPK))
			{
				if (MessageBox.Show(this, "Do you want packing create?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.Btn_PackingCreateProcess();
				}
			}
		}

		private void btn_packingClear_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_cancelPK))
			{
				if (MessageBox.Show(this, "Do you want to packing cancel?", "Packing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.Btn_PackingCancelProcess();
				}
			}
		}

		private void btn_barCode_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (Etc_ProvisoValidateCheck(_validate_createBC))
				{
					if (MessageBox.Show(this, "Do you want to make barcode?", "Barcode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						Btn_BarcodeCreateProcess();
					}
				}
			}
			catch
			{

			}
		}

		private void btn_BCCancel_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (Etc_ProvisoValidateCheck(_validate_cancelBC))
				{
					if (MessageBox.Show(this, "Do you want to remove barcode?", "Barcode", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						Btn_BarcodeCancelProcess();
					}
				}
			}
			catch
			{

			}
		}

		// scan manager로 이동
		private void MoveToScanManager()
		{
			DialogResult vResult = MessageBox.Show(this, "Do you want move to scan manager?", "Move to scan manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (vResult == DialogResult.Yes)
			{
				Form_BS_Scan_InOut vScan = new Form_BS_Scan_InOut();
				vScan.MdiParent = this.MdiParent;
				vScan.RunProcess(dpick_shipYmd.Value, cmb_materialType.SelectedValue, cmb_shipNo.SelectedValue);
				this.Close();
			}
		}

		private void btn_headSearch_Click(object sender, System.EventArgs e)
		{
			this.Btn_HeadSearchClickProcess();
		}

		private void btn_SC_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_createSC))
			{
				if (MessageBox.Show(this, "Do you want to make sales contract?", "Sales Contrate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					SALESCONTRACT_PROCESS("PKG_SBS_SHIPPING_LIST.TRANSMIT_SALESCONTRACT", cmb_factory.SelectedValue.ToString(), cmb_shipNo.SelectedValue.ToString());
					this.SearchHeadInfo();
					ClassLib.ComFunction.User_Message("Complete Transmit Sales Contract");
				}
			}
		}

		private void btn_SCCencel_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_cancelSC))
			{
				if (MessageBox.Show(this, "Do you want to cancel sales contract?", "Sales Contrate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					SALESCONTRACT_PROCESS("PKG_SBS_SHIPPING_LIST.CANCEL_SALESCONTRACT", cmb_factory.SelectedValue.ToString(), cmb_shipNo.SelectedValue.ToString());
					this.SearchHeadInfo();
					ClassLib.ComFunction.User_Message("Complete cancel sales contract");
				}
			}
		}

		private void btn_trade_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_trade))
			{
				if (MessageBox.Show(this, "Do you want to trade sc?", "Trade", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{				
					SALESCONTRACT_PROCESS("PKG_SBS_SHIPPING_LIST.INVOICE_TRANSMIT", cmb_factory.SelectedValue.ToString(), cmb_shipNo.SelectedValue.ToString());
					this.SearchHeadInfo();
					ClassLib.ComFunction.User_Message("Complete Invoice Transmit");
					CheckStatus();
				}
			}
		}

		private void btn_allTrade_Click(object sender, System.EventArgs e)
		{
//			if (Etc_ProvisoValidateCheck(_validate_trade))
//			{
//				if (MessageBox.Show(this, "Do you want to trade sc?", "Trade", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//				{
//					string vShipNo = COM.ComFunction.Empty_Combo(cmb_factory, "") + COM.ComFunction.Empty_Combo(cmb_materialType, "") + dpick_shipYmd.Value.ToString("yyyyMMdd");
//					SALESCONTRACT_PROCESS("PKG_SBS_SHIPPING_LIST.INVOICE_TRANSMIT_ALL", cmb_factory.SelectedValue.ToString(), vShipNo);
//					this.SearchHeadInfo();
//					ClassLib.ComFunction.User_Message("Complete Invoice Transmit");
//					CheckStatus();
//				}
//			}


			try
			{

				if (!Etc_ProvisoValidateCheck(_validate_trade)) return;
			
//				if (MessageBox.Show(this, "Do you want to trade sc?", "Trade", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
//				{
//					return;
//				}
				

				string factory = cmb_factory.SelectedValue.ToString();
				//string ship_ymd = dpick_shipYmd.Text.Replace("-", "");
				string ship_ymd = dpick_shipYmd.Text;
				string ship_type = cmb_materialType.SelectedValue.ToString();

				Pop_BS_Shipping_List_Trade pop_form = new Pop_BS_Shipping_List_Trade(factory, ship_ymd, ship_type);
				pop_form.ShowDialog();


				DataTable dt_ret = pop_form.dt_ret;
 
				if (dt_ret != null && dt_ret.Rows.Count > 0)
				{
				 
	  
					for(int i = 0; i < dt_ret.Rows.Count; i++)
					{ 

						SALESCONTRACT_PROCESS("PKG_SBS_SHIPPING_LIST.INVOICE_TRANSMIT", dt_ret.Rows[i].ItemArray[0].ToString(), dt_ret.Rows[i].ItemArray[1].ToString() ); 
					 
					} // end for i

					this.SearchHeadInfo();
					ClassLib.ComFunction.User_Message("Complete Invoice Transmit");
					CheckStatus();


				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_allTrade_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void btn_history_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp = new string[3];
			COM.ComVar.Parameter_PopUp[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			COM.ComVar.Parameter_PopUp[1] = COM.ComFunction.Empty_Combo(cmb_obsType, "");
			COM.ComVar.Parameter_PopUp[2] = txt_styleCode.Text;

            Pop_BS_Shipping_History_Print vPop = new Pop_BS_Shipping_History_Print();
			vPop.ShowDialog();
		}

		
		private void btn_Purchase_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp = new string[3];
			COM.ComVar.Parameter_PopUp[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			COM.ComVar.Parameter_PopUp[1] = COM.ComFunction.Empty_Combo(cmb_materialType, "");
			COM.ComVar.Parameter_PopUp[2] = dpick_shipYmd.Text.Replace("-", "");

			
			Pop_BS_PurchaseList vPop = new Pop_BS_PurchaseList();
			vPop.ShowDialog();
		}

		private void btn_Change_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_createBC))
			{
				COM.ComVar.Parameter_PopUp = new string[4];
				COM.ComVar.Parameter_PopUp[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				COM.ComVar.Parameter_PopUp[1] = COM.ComFunction.Empty_Combo(cmb_shipNo, "");
				COM.ComVar.Parameter_PopUp[2] = COM.ComFunction.Empty_Combo(cmb_materialType, "");
				COM.ComVar.Parameter_PopUp[3] = dpick_shipYmd.Text.Replace("-", "");

				Pop_BS_Shipping_Change vPop = new Pop_BS_Shipping_Change();
				vPop.ShowDialog();
			}
		}

		
		private void btn_Export_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_trade))
			{
				COM.ComVar.Parameter_PopUp = new string[3];
				COM.ComVar.Parameter_PopUp[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				//COM.ComVar.Parameter_PopUp[1] = dpick_shipYmd.Text.Replace("-", "");
				COM.ComVar.Parameter_PopUp[1] = dpick_shipYmd.Text.ToString();
				COM.ComVar.Parameter_PopUp[2] = COM.ComFunction.Empty_Combo(cmb_materialType, "");

				Pop_BS_Shipping_Export vPop = new Pop_BS_Shipping_Export();
				vPop.ShowDialog();
			}		
		}



		#endregion

		#region 검색조건 변경에 따른 이벤트

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			ClearAll();
			this.Cmb_ShipNoSettingProcess();


            DataTable vDt = null;
            vDt = SELECT_SHIPPING_RATE(ClassLib.ComVar.This_Factory, "SBS12", cmb_factory.SelectedValue.ToString());

             vPriceRate =   Convert.ToDouble(vDt.Rows[0][0]);
            
           



		}

		private void dpick_shipYmd_CloseUp(object sender, System.EventArgs e)
		{
			ClearAll();
			this.Cmb_ShipNoSettingProcess();
		}

		#endregion

		#region 입력이동

		private void cmb_factory_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				dpick_shipYmd.Focus();
		}

		private void dpick_shipYmd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_devision_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				cmb_size.Focus();
		}

		private void cmb_size_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				Tbtn_SearchProcess();
		}

		private void cmb_materialType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			//ClearAll();
			this.Cmb_ShipNoSettingProcess();
		}

		
		private void cmb_reason_s_SelectedValueChanged(object sender, System.EventArgs e)
		{
			//ClearAll();
			this.Cmb_ShipNoSettingProcess();
		}


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

		private void ClearAll()
		{
			ClearHeadInfo();
			if (fgrid_tail.Rows.Fixed < fgrid_tail.Rows.Count)
				fgrid_tail.ClearAll();
		}

		private string[] GetSearchProviso()
		{
			string[] vProviso = new string[8];
			vProviso[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			vProviso[1] = dpick_shipYmd.Text.Replace("-", "");
			vProviso[3] = COM.ComFunction.Empty_Combo(cmb_size, "");
			vProviso[4] = COM.ComFunction.Empty_Combo(cmb_materialType, "");
			vProviso[5] = COM.ComFunction.Empty_Combo(cmb_obsType, "");
			vProviso[6] = COM.ComFunction.Empty_Combo(cmb_shipNo, "");
			vProviso[7] = COM.ComFunction.Empty_Combo(cmb_reason_s, "");

			return vProviso;
		}

		private void SetHeadInfo(DataTable arg_dt)
		{
			cmb_shipNo.SelectedValueChanged -= _cmbShipNoEventHandler;
			cmb_shipNo.SelectedValue = arg_dt.Rows[0].ItemArray[0];
			cmb_materialType.SelectedValue	= arg_dt.Rows[0].ItemArray[1].ToString();
			cmb_size.SelectedValue			= arg_dt.Rows[0].ItemArray[2].ToString();
			cmb_obsType.SelectedValue		= arg_dt.Rows[0].ItemArray[3].ToString();
			txt_status.Text					= arg_dt.Rows[0].ItemArray[4].ToString();
			txt_styleCode.Text				= arg_dt.Rows[0].ItemArray[5].ToString();
			txt_styleName.Text				= arg_dt.Rows[0].ItemArray[6].ToString();
			txt_gender.Text					= arg_dt.Rows[0].ItemArray[7].ToString();
			txt_presto.Text					= arg_dt.Rows[0].ItemArray[8].ToString();
			txt_purQty.Text					= arg_dt.Rows[0].ItemArray[9].ToString();
			txt_shipQty.Text				= arg_dt.Rows[0].ItemArray[10].ToString();
			txt_packing.Text				= arg_dt.Rows[0].ItemArray[11].ToString();
			txt_remarks.Text				= arg_dt.Rows[0].ItemArray[12].ToString();
			cmb_reason.SelectedValue		= arg_dt.Rows[0].ItemArray[13].ToString();
			txt_obsId.Text					= arg_dt.Rows[0].ItemArray[14].ToString();
			txt_mrpShipNo.Text				= arg_dt.Rows[0].ItemArray[15].ToString();
			cmb_shipNo.SelectedValueChanged += _cmbShipNoEventHandler;
		}

		private void ClearHeadInfo()
		{
			cmb_shipNo.SelectedValueChanged -= _cmbShipNoEventHandler;
			cmb_size.SelectedIndex			= -1;
			//cmb_materialType.SelectedIndex	= -1;
			cmb_obsType.SelectedIndex		= -1;			
			txt_status.Text					= "";
			txt_styleCode.Text				= "";
			txt_styleName.Text				= "";
			txt_gender.Text					= "";
			txt_presto.Text					= "";
			txt_shipQty.Text				= "";
			txt_purQty.Text					= "";
			txt_packing.Text				= "";
			txt_remarks.Text				= "";
			cmb_reason.SelectedIndex		= -1;
			txt_obsId.Text					= "";
			txt_mrpShipNo.Text				= "";
			cmb_shipNo.SelectedValueChanged += _cmbShipNoEventHandler;
		}

		private void SearchHeadInfo()
		{
			string vFactory = cmb_factory.SelectedValue.ToString();
			string vShipNo  = cmb_shipNo.SelectedValue.ToString();

			DataTable vDt = SELECT_SBS_SHIPPING_HEAD(vFactory, vShipNo);
			if (vDt.Rows.Count > 0 && vDt.Rows.Count < 2)
				this.SetHeadInfo(vDt);
			else
				this.ClearHeadInfo();
			vDt.Dispose();
		}

		private void SearchTailInfo()
		{
			string[] vProviso = GetSearchProviso();

			DataTable vDt = SELECT_SBS_SHIPPING_TAIL_LIST(vProviso[0], vProviso[6]);

			ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_tail, vDt);

			for (int vRow = fgrid_tail.Rows.Fixed ; vRow < fgrid_tail.Rows.Count ; vRow++)
			{
				// 패킹 수량 변경을 위해 초기 값을 가진다.
				C1.Win.C1FlexGrid.CellRange vRange = fgrid_tail.GetCellRange(vRow, _CTCol, vRow, _CTCol);
				vRange.UserData = fgrid_tail[vRow, _CTCol];
			}

			vDt.Dispose();

			GridSetCellColor();
		}

		private void GridSetCellColor()
		{
			for (int i = fgrid_tail.Rows.Fixed ; i < fgrid_tail.Rows.Count ; i++)
			{
				GridSetColor(i);

				fgrid_tail[i, 0] = "";
				fgrid_tail[i, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxINDEX] = (i + 1) - fgrid_tail.Rows.Fixed;
			}
		}

		private void GridSetColor(int arg_row)
		{
			string vShipYN	  = null, vOutsideYN = null;
			string vPackingString = txt_packing.Text;

			vShipYN		= fgrid_tail[arg_row, _shipYNCol].ToString();
			vOutsideYN  = fgrid_tail[arg_row, _outsideYNCol].ToString();

			if (vOutsideYN.StartsWith(ClassLib.ComVar.Yes))
				fgrid_tail.Rows[arg_row].StyleNew.BackColor = ClassLib.ComVar.RightYellow;
			else if (vShipYN.StartsWith(ClassLib.ComVar.Yes))
				fgrid_tail.Rows[arg_row].StyleNew.BackColor = ClassLib.ComVar.RightBlue;
			else if (vShipYN.StartsWith(ClassLib.ComVar.No))
				fgrid_tail.Rows[arg_row].StyleNew.BackColor = ClassLib.ComVar.RightPink2;
			else
				fgrid_tail.Rows[arg_row].StyleNew.BackColor = ClassLib.ComVar.Default;

			if (fgrid_tail[arg_row, _CTCol] != null && ( vShipYN.StartsWith(ClassLib.ComVar.Yes) || vOutsideYN.StartsWith(ClassLib.ComVar.Yes) ))
				if (fgrid_tail[arg_row, _CTCol].ToString().Equals("1"))
					fgrid_tail[arg_row, _packingNoCol] = vPackingString + fgrid_tail[arg_row, _packingNoFromCol].ToString();
				else if (!fgrid_tail[arg_row, _CTCol].ToString().Equals(""))
					fgrid_tail[arg_row, _packingNoCol] = vPackingString + fgrid_tail[arg_row, _packingNoFromCol].ToString() + " ~ " + vPackingString + fgrid_tail[arg_row, _packingNoToCol].ToString();
		}

		public ArrayList EmptyProvisoCheck(string arg_proviso, ref int arg_Row, ref int arg_Col)
		{
			ArrayList vColumns	  = new ArrayList();

			try
			{
				string vPackingString = txt_packing.Text;
				string vPackingNo	  = "";
				int vCount = 1;

				// packing string check
				if (vPackingString.Equals(""))
					return null;

				// empty cell check
				for (int i = fgrid_tail.Rows.Fixed ; i < fgrid_tail.Rows.Count ; i++)
				{
					if ((ClassLib.ComFunction.NullToBlank(fgrid_tail[i, _shipYNCol]).StartsWith(arg_proviso) ||
						ClassLib.ComFunction.NullToBlank(fgrid_tail[i, _outsideYNCol]).StartsWith(arg_proviso)) && 
						ClassLib.ComFunction.NullToBlank(fgrid_tail[i, _packingNoCol]).Equals(""))
					{
						if (ClassLib.ComFunction.NullCheck(fgrid_tail[i, _shipQtyCol], "").Equals(""))
						{
							arg_Row = i;
							arg_Col = _shipQtyCol;
							break;
						}
						if (ClassLib.ComFunction.NullCheck(fgrid_tail[i, _packingUnitQtyCol], "").Equals(""))
						{
							arg_Row = i;
							arg_Col = _packingUnitQtyCol;
							break;
						}
						vColumns.Add((object)i);
					}

					// get last count
					if (!fgrid_tail[i, _packingNoCol].ToString().Equals(""))
					{
						vPackingNo = fgrid_tail[i, _packingNoToCol].ToString();
						vCount = Convert.ToInt32(vPackingNo.Equals("") ? "1" : vPackingNo);
						_count = (vCount > _count) ? vCount : _count;
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "EmptyProvisoCheck", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return vColumns;
		}

        // 선적 취소시 호출
		private bool ShippingCancel(int arg_row, int arg_col)
		{
			try
			{
				string vStatus = txt_status.Text;

				if (vStatus.Equals(ClassLib.ComVar.Packing))
				{
					if (arg_col == _shipYNCol || arg_col == _outsideYNCol)
					{
						if (fgrid_tail[arg_row, arg_col].ToString().Equals("N"))
						{
							fgrid_tail[arg_row, _packingNoCol] = "";
							fgrid_tail[arg_row, _CTCol] = null;
							fgrid_tail[arg_row, _packingNoFromCol] = "";
							fgrid_tail[arg_row, _packingNoToCol] = "";
							fgrid_tail[arg_row, _statusCol] = "Save";
						}
						else
						{
							if (ClassLib.ComFunction.NullToBlank(fgrid_tail[arg_row, _packingUnitQtyCol]).Equals("0") || 
								ClassLib.ComFunction.NullToBlank(fgrid_tail[arg_row, _shipQtyCol]).Equals("0"))
							{
								ClassLib.ComFunction.User_Message("Can not divide by zero", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail[arg_row, arg_col] = ClassLib.ComVar.No;
								fgrid_tail[arg_row, _packingNoCol] = "";
								fgrid_tail[arg_row, _CTCol] = null;
								fgrid_tail[arg_row, _packingNoFromCol] = "";
								fgrid_tail[arg_row, _packingNoToCol] = "";
								fgrid_tail[arg_row, _statusCol] = "Save";
								fgrid_tail.Select(arg_row, _packingUnitQtyCol);
								return false;
							}
							else
							{
								Mnu_PackingCreate();
							}
						}
					}
					else if (arg_col == _shipQtyCol || arg_col == _packingUnitQtyCol)
					{
						if (ClassLib.ComFunction.NullToBlank(fgrid_tail[arg_row, _packingUnitQtyCol]).Equals("0") || 
							ClassLib.ComFunction.NullToBlank(fgrid_tail[arg_row, _shipQtyCol]).Equals("0"))
						{
							fgrid_tail[arg_row, _packingNoCol] = "";
							fgrid_tail[arg_row, _CTCol] = null;
							fgrid_tail[arg_row, _packingNoFromCol] = "";
							fgrid_tail[arg_row, _packingNoToCol] = "";
							fgrid_tail[arg_row, _statusCol] = "Save";
						}
						else
						{
							if (ClassLib.ComFunction.NullToBlank(fgrid_tail[arg_row, _shipYNCol]).StartsWith("Y") || 
								ClassLib.ComFunction.NullToBlank(fgrid_tail[arg_row, _outsideYNCol]).StartsWith("Y"))
							{
								fgrid_tail[arg_row, _packingNoCol] = "";
								fgrid_tail[arg_row, _CTCol] = null;
								fgrid_tail[arg_row, _packingNoFromCol] = "";
								fgrid_tail[arg_row, _packingNoToCol] = "";

								Mnu_PackingCreate();
							}
						}
					}
				}

				fgrid_tail.Update_Row(arg_row);
				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ShippingCancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}


		// Outside 취소시 호출
		private bool OutsideCancel(int arg_row, int arg_col, int arg_flag)
		{
			try
			{
				string vStatus = txt_status.Text;

				if (vStatus.Equals(ClassLib.ComVar.Barcode))
				{
					if (arg_flag == 1)
					{
							fgrid_tail[arg_row, _shipYNCol] = "N";
							fgrid_tail[arg_row, _outsideYNCol] = "Y";
					}
					else
					{
							fgrid_tail[arg_row, _shipYNCol] = "Y";
							fgrid_tail[arg_row, _outsideYNCol] = "N";
					}

				}

				fgrid_tail.Update_Row(arg_row);
				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Outside Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}


		private void Outside_Save()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;


				// 디테일 저장
				if (!MyOraDB.Save_FlexGird_Ready("PKG_SBS_SHIPPING_TAIL.SAVE_SBS_SHIPPING_TAIL", fgrid_tail, true))
					return;

				if (MyOraDB.Exe_Modify_Procedure() != null)
				{
					//Point vCurScroll = fgrid_tail.ScrollPosition;
					//SearchTailInfo();
					//fgrid_tail.ScrollPosition = vCurScroll;
					//GridSetCellColor();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					ClassLib.ComFunction.User_Message("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		// modify query
		private string[] ModifyQuery(string[] arg_proviso)
		{
			for (int vIdx = 0 ; vIdx < arg_proviso.Length ; vIdx++)
			{
				arg_proviso[vIdx] = arg_proviso[vIdx].TrimEnd('|');
				arg_proviso[vIdx] = arg_proviso[vIdx].Replace("|", "', '");
				arg_proviso[vIdx] = "'" + arg_proviso[vIdx] + "'";
			}

			return arg_proviso;
		}

		// 외부 접근용 함수
		public void RunProcess(DateTime arg_date, object arg_shipNo)
		{
			this.Show();
			this.dpick_shipYmd.Value = arg_date;
			this.cmb_shipNo.SelectedValue = arg_shipNo;
		}
		
		private double NullToZero(object arg_num)
		{
			try
			{
				double vResult = 0;

				if (arg_num != null)
				{
					if (!arg_num.ToString().Equals(""))
					{
						vResult = Convert.ToDouble(arg_num);
					}
				}

				return vResult;
			}
			catch 
			{
				return 0;
			}
		}

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
            // form initialize
			this.Text = "Shipping List";
            lbl_MainTitle.Text = "Shipping List";
            ClassLib.ComFunction.SetLangDic(this);
			// ClassLib.ComFunction.Init_MenuRole(this,lbl_MainTitle, tbtn_Search, tbtn_Save, tbtn_Print) ;

			// grid set
			fgrid_tail.Set_Grid("SBS_SHIPPING_TAIL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_tail.Set_Action_Image(img_Action);
			fgrid_tail.Rows[1].AllowMerging = true;
			//fgrid_tail.AllowSorting = AllowSortingEnum.SingleColumn;

			// factory set
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar. This_Factory;
			vDt.Dispose();

			// cmb_status (Y/N)
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPItemDivision);
			COM.ComCtl.Set_ComboList(vDt, cmb_size, 1, 2, false, false);
			vDt.Dispose();

			// request reason
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_reason, 1, 2, false, 80, 140);
			vDt.Dispose();

			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_reason_s, 1, 2, true, 80, 140);
			cmb_reason_s.SelectedIndex = 0;
			vDt.Dispose();


			// material type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
			COM.ComCtl.Set_ComboList(vDt, cmb_materialType, 1, 2, false, 80, 140);
			cmb_materialType.SelectedIndex = 0;
			vDt.Dispose();

			// obs type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxOBSType);
			COM.ComCtl.Set_ComboList(vDt, cmb_obsType, 1, 2, false, 80, 140);
			vDt.Dispose();

			// cmb_shipYN ( print용 )
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxYesNo);
			COM.ComCtl.Set_ComboList(vDt, cmb_shipYN, 1, 2, true, 80, 140);
			cmb_shipYN.SelectedIndex = 1;
			vDt.Dispose();

			
            // user define variable set
            vDt = SELECT_SHIPPING_RATE(ClassLib.ComVar.This_Factory, "SBS12", cmb_factory.SelectedValue.ToString());
            vPriceRate = Convert.ToDouble(vDt.Rows[0][0]);
            vDt.Dispose();
           

			
			_shipNoTitles			= new string[]{"Shipping No", "Style", "Model", "Packing", "Gender", "Qty", "Status", "Ship Type", "Req Reason", "Item Division", "OBS ID", "OBS Type"};
			_shipNoWidth			= new int[]{	125,			80,		130,	40,			35,		70,		60,		60,				60,			60,				60,			70};
			_shipNoVisible			= new bool[]{true, true, true, true, true, true, true, true, true, true, true, true};

			_cmbShipNoEventHandler  = new System.EventHandler(this.cmb_shipNo_SelectedValueChanged);

			_practicable = true;
			Cmb_ShipNoSettingProcess();
			CheckStatus();

			// Disabled tbutton
			tbtn_Confirm.Enabled = true;
			tbtn_Confirm.ToolTipText  ="Excel";

			// grid set
			fgrid_tail.Cols[(int)ClassLib.TBSBS_SHIPPING_TAIL.IxPUR_QTY].Format = "#,##0.00";
			fgrid_tail.Cols[(int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_QTY].Format = "#,##0.00";
			
			// set grid cell type
			_cellCombo = new Hashtable(fgrid_tail.Cols.Count);

			for (int vCol = 1 ; vCol < fgrid_tail.Cols.Count ; vCol++)
			{
				if (fgrid_tail.Cols[vCol].AllowEditing)
				{
					if (fgrid_tail.Cols[vCol].DataMap != null)
					{
						_cellCombo.Add(vCol, fgrid_tail.GetDataSourceWithCode(vCol));
					}
				}
			}
		}

		#region 컨텍스트 메뉴

		private void Mnu_AutoCalculation(int arg_kind)
		{
			int[] vSel = fgrid_tail.Selections;

			foreach (int vRow in vSel)
			{
				if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _shipQtyCol - 1]).Equals("") || ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _shipQtyCol - 1]).Equals("0"))
				{
					fgrid_tail.Select(vRow, _shipQtyCol - 1);
					DialogResult vDR = ClassLib.ComFunction.User_Message("Empty Purchase Qty. Do you want to continue?", "Invalidate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					
					if (vDR == DialogResult.Yes)
						continue;
					else
						break;
				}

				if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _packingUnitQtyCol]).Equals("") || ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _packingUnitQtyCol]).Equals("0"))
				{
					fgrid_tail.Select(vRow, _packingUnitQtyCol);
					DialogResult vDR = ClassLib.ComFunction.User_Message("Empty Packing Unit Qty. Do you want to continue?", "Invalidate", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
					
					if (vDR == DialogResult.Yes)
						continue;
					else
						break;
				}					
				
				int vQty = Get_ConvertedNumber(vRow, arg_kind);

				if (vQty > 0)
				{
					fgrid_tail[vRow, _shipQtyCol] = vQty;
					fgrid_tail.Update_Row(vRow);
				}
			}
		}

		private int Get_ConvertedNumber(int arg_row, int arg_kind)
		{
			int vResult = -1;
			double vAdviceQty = Convert.ToDouble(fgrid_tail[arg_row, _shipQtyCol - 1]);

			switch (arg_kind)
			{
				case 1:
					vResult = (int)Math.Ceiling(vAdviceQty);
					break;
				case 2:
					vResult = (int)Math.Round(vAdviceQty);
					break;
				case 3:
					vResult = (int)vAdviceQty;
					break;
				case 4:
					vResult = (int)Math.Floor(vAdviceQty);
					break;
				case 5:
					int vPKQty = Convert.ToInt32(fgrid_tail[arg_row, _packingUnitQtyCol]);

					if ( vPKQty == 0 )	return -1;

					double vTemp = ((int)(vAdviceQty / vPKQty)) * vPKQty;

					vResult = (int)vTemp;

					if ( vTemp < vAdviceQty )
						vResult = (int)(vTemp + vPKQty);
					break;
			}

			return vResult;
		}

		#endregion

		#region 툴바 메뉴 이벤트

		private void Tbtn_NewProcess()
		{
			try
			{
				ClearHeadInfo();
				fgrid_tail.ClearAll();
				CheckStatus();
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
				if (cmb_factory.SelectedValue == null || cmb_shipNo.SelectedValue == null)	return;

				this.Cursor = Cursors.WaitCursor;

				if (!cmb_shipNo.SelectedValue.ToString().Equals(" "))
				{
					this.SearchHeadInfo();
					this.SearchTailInfo();
					
					string vStatus = (txt_status.Text.Length <= 0) ? "" : txt_status.Text.Substring(0, 1);

					if (vStatus.Equals(_barcode) || vStatus.Equals(_invoice) || vStatus.Equals(_trade))
						fgrid_tail.AllowEditing = false;
					else
						fgrid_tail.AllowEditing = true;

					CheckStatus();
				}

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
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

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				// 헤더 저장
				if (!SAVE_SBS_SHIPPING_HEAD())
					return;

				// 디테일 저장
				if (!MyOraDB.Save_FlexGird_Ready("PKG_SBS_SHIPPING_TAIL.SAVE_SBS_SHIPPING_TAIL", fgrid_tail, false))
					return;

				if (MyOraDB.Exe_Modify_Procedure() != null)
				{
					Point vCurScroll = fgrid_tail.ScrollPosition;
					SearchTailInfo();
					fgrid_tail.ScrollPosition = vCurScroll;
					GridSetCellColor();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					ClassLib.ComFunction.User_Message("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		#endregion

		#region 컨트롤 이벤트

		private void Cmb_ShipNoSettingProcess()
		{
			try
			{
				if (_practicable)
				{
					cmb_shipNo.SelectedValueChanged -= _cmbShipNoEventHandler;

					string[] vProviso = GetSearchProviso();
					DataTable vDt = SELECT_SBS_SHIPPING_HEAD_SNO(vProviso[0], vProviso[1]);
					ClassLib.ComFunction.Set_ComboList_Multi(vDt, cmb_shipNo, new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}, false);
					ClassLib.ComFunction.SetComboStyle(cmb_shipNo, _shipNoTitles, _shipNoWidth, _shipNoVisible, "Shipping No");
					vDt.Dispose();

					cmb_shipNo.SelectedValueChanged += _cmbShipNoEventHandler;
					cmb_shipNo.DropDownWidth = 600;
				}
			}
			catch (Exception ex)
			{
                ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Cmb_ShipNoSelectedValueChangedProcess()
		{
			try
			{
				Tbtn_SearchProcess();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void  Txt_ShipQtyEnterProcess()
		{
			_orignalQty = double.Parse((txt_shipQty.Text.Equals("") ? "0" : txt_shipQty.Text));
		}

		#region 컨텍스트 메뉴

		private void mnu_rate_Click(object sender, System.EventArgs e)
		{
			try
			{
				/*****************************************
				0 : FACTORY,	  		1 : PUR_USER,
				2 : CUST_CD,			3 : CUST_NAME,
				4 :	PK_UNIT_QTY,		5 : PUR_PRICE,
				6 :	PUR_CURRENCY, 		7 : OUTSIDE_PRICE,
				8 :	OUTSIDE_CURRENCY, 	9 : CBD_PRICE,
				10 : CBD_CURRENCY,		11 : SHIP_PRICE,
				12 : SHIP_CURRENCY, 	13 : CBM,
				14 : WEIGHT
				*****************************************/
				int[] keys = new int[]{ (int)ClassLib.TBSBS_SHIPPING_TAIL.IxFACTORY,
										  -1, 
										  -1,
										  (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM_CD,
										  (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC_CD,
										  (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR_CD };

				int[] values = new int[]{ 
											-1,												(int)ClassLib.TBSBS_SHIPPING_TAIL.IxPUR_USER,
											(int)ClassLib.TBSBS_SHIPPING_TAIL.IxCUST_CD,	(int)ClassLib.TBSBS_SHIPPING_TAIL.IxVENDOR,
											(int)ClassLib.TBSBS_SHIPPING_TAIL.IxPK_UNIT_QTY,
											(int)ClassLib.TBSBS_SHIPPING_TAIL.IxPUR_PRICE,	(int)ClassLib.TBSBS_SHIPPING_TAIL.IxPUR_CURRENCY,
											-1,												-1,
											(int)ClassLib.TBSBS_SHIPPING_TAIL.IxCBD_PRICE,	(int)ClassLib.TBSBS_SHIPPING_TAIL.IxCBD_CURRENCY,
											(int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_PRICE,	(int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_CURRENCY,
											-1,												-1
										};

				// Todo : 팝업 명칭 변경, OBS ID 보내주기
				//Pop_BC_CBD_Information vPop = new Pop_BC_CBD_Information(fgrid_tail, keys, values);
				Pop_BC_CBD_Information_3 vPop = new Pop_BC_CBD_Information_3(fgrid_tail, keys, values);

				vPop._factory = COM.ComVar.This_Factory;
				vPop._style = txt_styleCode.Text.Replace("-", "");
				vPop._obsId = txt_obsId.Text;

				// 발주 수량 가져오기
				vPop._mrpShipNo = txt_mrpShipNo.Text;
				vPop._purQty = (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_QTY;

				int[] sels = fgrid_tail.Selections;

				vPop.ShowDialog(this);

				foreach (int i in sels)
				{
					string vCbdInfo = ClassLib.ComFunction.NullCheck(fgrid_tail[i, _cbdPriceCol], "0");
					double vCbdPrice = Convert.ToDouble(vCbdInfo.Equals("") ? "0" : vCbdInfo);
					fgrid_tail[i, _shipPriceCol] = Math.Round(vCbdPrice * vPriceRate, 2);
					fgrid_tail[i, _shipPriceCol + 1] = fgrid_tail[i, _cbdPriceCol + 1];

					if (txt_status.Text.StartsWith(_packing) && 
						(ClassLib.ComFunction.NullToBlank(fgrid_tail[i, _shipYNCol]).StartsWith("Y") ||
						ClassLib.ComFunction.NullToBlank(fgrid_tail[i, _outsideYNCol]).StartsWith("Y")))
					{
						string vShipQty = ClassLib.ComFunction.NullCheck(fgrid_tail[i, _shipQtyCol], "0");
						string vPkQty = ClassLib.ComFunction.NullCheck(fgrid_tail[i, _packingUnitQtyCol], "0");

						if (vShipQty.Equals("0") || vPkQty.Equals("0"))
						{
							fgrid_tail[i, _statusCol] = "Save";
							this.ShippingCancel(i, _packingUnitQtyCol);
						}
						else
						{
							int vCurCT = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(vShipQty) / Convert.ToDouble(vPkQty)));
							int vOldCT = Convert.ToInt32(ClassLib.ComFunction.NullCheck(fgrid_tail[i, _CTCol], "0"));

							if (vCurCT != vOldCT)
								this.ShippingCancel(i, _packingUnitQtyCol);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "mnu_rate_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void mnu_ship_Click(object sender, System.EventArgs e)
		{
			foreach (int i in fgrid_tail.Selections)
			{
				fgrid_tail[i, _shipYNCol] = ClassLib.ComVar.Yes;
				
				if (!ShippingCancel(i, _shipYNCol))
				{
					break;
				}
				GridSetColor(i);
			}
		}

		private void mnu_notShip_Click(object sender, System.EventArgs e)
		{
			foreach (int i in fgrid_tail.Selections)
			{
				fgrid_tail[i, _shipYNCol] = ClassLib.ComVar.No;
			
				if (!ShippingCancel(i, _shipYNCol))
				{
					break;
				}
				GridSetColor(i);
			}
		}

		private void mnu_Outside_Click(object sender, System.EventArgs e)
		{
			foreach (int i in fgrid_tail.Selections)
			{
				fgrid_tail[i, _outsideYNCol] = ClassLib.ComVar.Yes;
				
				if (!OutsideCancel(i, _outsideYNCol, 1))
				{
					break;
				}
				GridSetColor(i);
				Outside_Save();
			}	
		}

		private void mnu_NotOutside_Click(object sender, System.EventArgs e)
		{
			foreach (int i in fgrid_tail.Selections)
			{
				fgrid_tail[i, _outsideYNCol] = ClassLib.ComVar.No;
			
				if (!OutsideCancel(i, _outsideYNCol, 0))
				{
					break;
				}
				GridSetColor(i);
				Outside_Save();
			}
		}


		private void mnu_ceiling_Click(object sender, System.EventArgs e)
		{
			Mnu_AutoCalculation(1);
		}

		private void mnu_roundUp_Click(object sender, System.EventArgs e)
		{
			Mnu_AutoCalculation(2);		
		}

		private void mnu_truncate_Click(object sender, System.EventArgs e)
		{
			Mnu_AutoCalculation(3);
		}

		private void mnu_pk_Click(object sender, System.EventArgs e)
		{
			Mnu_AutoCalculation(5);
		}


		#endregion

		#region 패킹 관련 함수들

		private void Mnu_PackingCreate()
		{
			int[] vSel = fgrid_tail.Selections;
			int vFrom = 1, vTo = 1, vCt = 1;

			foreach (int vRow in vSel)
			{
				if (!ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _CTCol]).Equals(""))
					continue;

				vCt = (int)Math.Ceiling(StringToDouble(fgrid_tail[vRow, _shipQtyCol]) / StringToDouble(fgrid_tail[vRow, _packingUnitQtyCol]));
				vFrom = GetLastPkNumber();
				vTo = (vFrom + vCt) - 1;

				SetPackingInfo(vRow, vFrom, vTo, vCt);
			}
		}

		private void SetPackingInfo(int arg_row, int arg_from, int arg_to, int arg_ct)
		{
			string vResultPackingNo = "";

			fgrid_tail[arg_row, _CTCol] = arg_ct;
			fgrid_tail[arg_row, _packingNoFromCol] = arg_from;
			fgrid_tail[arg_row, _packingNoToCol] = arg_to;

			if (arg_from == arg_to)
				vResultPackingNo = txt_packing.Text + arg_from.ToString();
			else
				vResultPackingNo = txt_packing.Text + arg_from + " ~ " + txt_packing.Text + arg_to;

			fgrid_tail[arg_row, _packingNoCol] = vResultPackingNo;
			fgrid_tail[arg_row, _statusCol] = ClassLib.ComVar.Packing;
			fgrid_tail.Update_Row(arg_row);
		}

		private void Mnu_PackingCancel()
		{
			int[] vSel = fgrid_tail.Selections;

			if (txt_status.Text.Equals(ClassLib.ComVar.Packing))
			{
				foreach (int vRow in vSel)
				{
					fgrid_tail[vRow, _packingNoCol]			= "";
					fgrid_tail[vRow, _CTCol]				= null;
					fgrid_tail[vRow, _packingNoFromCol]		= "";
					fgrid_tail[vRow, _packingNoToCol]		= "";
					fgrid_tail[vRow, _statusCol]			= ClassLib.ComVar.Save;
					fgrid_tail.Update_Row(_count);
				}
			}
		}

		private int GetLastPkNumber()
		{
			int vResult = 1;

			for (int vRow = fgrid_tail.Rows.Fixed ; vRow < fgrid_tail.Rows.Count ; vRow++)
			{
				int vTo = StringToInteger(fgrid_tail[vRow, _packingNoToCol]);
				
				if (vTo > vResult)
				{
					vResult = vTo;
				}
			}

			return vResult + 1;
		}

		private int StringToInteger(object obj)
		{
			if (obj == null)	return 0;
			if (obj.ToString().Trim().Equals(""))	return 0;
			
			return Convert.ToInt32(obj.ToString());
		}

		private double StringToDouble(object obj)
		{
			if (obj == null)	return 0;
            if (obj.ToString().Trim().Equals("")) return 0;
			
			return Convert.ToDouble(obj.ToString());
		}


		#endregion

		#endregion

		#region 버튼 이벤트

		private void Btn_ShipCreateProcess()
		{
			pop_shippingList = new Pop_BS_Shipping_List_Schedule_2();
			COM.ComVar.Parameter_PopUp		= new string[6];
			COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			COM.ComVar.Parameter_PopUp[2]	= ClassLib.ComFunction.Empty_Combo(cmb_size, "");
			COM.ComVar.Parameter_PopUp[3]	= ClassLib.ComFunction.Empty_Combo(cmb_materialType, "");
			COM.ComVar.Parameter_PopUp[4]	= ClassLib.ComFunction.Empty_Combo(cmb_obsType, "");
			COM.ComVar.Parameter_PopUp[5]	= dpick_shipYmd.Text.Replace("-", "");

			pop_shippingList.Owner = this;
			pop_shippingList.Show();
			pop_shippingList.Disposed += new EventHandler(Pop_ShippingListProcess);
		}

		private void Pop_ShippingListProcess(object sender, System.EventArgs args)
		{
			if (pop_shippingList.DialogResult == DialogResult.OK)
				Cmb_ShipNoSettingProcess();
		}

		private void Btn_PackingCreateProcess()
		{
			int vRow = -1, vCol = -1, vTemp = 0;
			double vShipQty = 0, vPackingUnitQty = 0;
			string vResultPackingNo = "";
			string vPackingString = txt_packing.Text;

			// empty cell check
			ArrayList vColumns = EmptyProvisoCheck("Y", ref vRow, ref vCol);
			if (vRow != -1)
			{
				ClassLib.ComFunction.User_Message(fgrid_tail[1, vCol].ToString() + " is missing", "Empty Cell", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				fgrid_tail.Select(vRow, vCol, true);
				return;
			}

			// packing no set
			IEnumerator vEnum = vColumns.GetEnumerator();
			while (vEnum.MoveNext())
			{
				vRow			= (int)vEnum.Current;
				vPackingUnitQty = Convert.ToDouble(fgrid_tail[vRow, _packingUnitQtyCol].ToString());
				vShipQty		= Convert.ToDouble(fgrid_tail[vRow, _shipQtyCol].ToString());

				fgrid_tail[vRow, _CTCol] = vTemp = (int)Math.Ceiling(vShipQty / vPackingUnitQty);

				// 패킹 수량 변경을 위해 초기 값을 가진다.
				C1.Win.C1FlexGrid.CellRange vRange = fgrid_tail.GetCellRange(vRow, _CTCol, vRow, _CTCol);
				vRange.UserData = vTemp;

				fgrid_tail[vRow, _statusCol] = ClassLib.ComVar.Packing;

				if (vTemp == 1)
				{
					fgrid_tail[vRow, _packingNoFromCol] = _count;
					fgrid_tail[vRow, _packingNoToCol] = _count++;
					vResultPackingNo = vPackingString + fgrid_tail[vRow, _packingNoFromCol].ToString();
				}
				else
				{
					fgrid_tail[vRow, _packingNoFromCol] = _count;
					fgrid_tail[vRow, _packingNoToCol] = (_count = _count + vTemp) - 1;
					vResultPackingNo = vPackingString + fgrid_tail[vRow, _packingNoFromCol].ToString() + " ~ " + vPackingString + fgrid_tail[vRow, _packingNoToCol].ToString();
				}
				fgrid_tail[vRow, _packingNoCol] = vResultPackingNo;
				fgrid_tail.Update_Row((int)vEnum.Current);
			}

			if (vColumns.Count > 0)
			{
				txt_status.Text = ClassLib.ComVar.Packing;
				ClassLib.ComFunction.User_Message("Complete create packing", "Packing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_count = 1;
				Tbtn_SaveProcess();
				CheckStatus();
				Set_StatusCombo(txt_status.Text);
			}
		}

		private void Btn_PackingCancelProcess()
		{
			_count = fgrid_tail.Rows.Fixed;

			while (_count < fgrid_tail.Rows.Count)
			{
				if (!fgrid_tail[_count, _statusCol].ToString().Equals(ClassLib.ComVar.Barcode))
				{
					fgrid_tail[_count, _packingNoCol]		= "";
					fgrid_tail[_count, _CTCol]				= null;
					fgrid_tail[_count, _packingNoFromCol]	= "";
					fgrid_tail[_count, _packingNoToCol]		= "";
					fgrid_tail[_count, _statusCol]			= ClassLib.ComVar.Save;
					fgrid_tail.Update_Row(_count);
				}
				_count++;
			}

			txt_status.Text = ClassLib.ComVar.Save;
			_count = 1;
			ClassLib.ComFunction.User_Message("Complete cancel packing", "Packing", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Tbtn_SaveProcess();
			CheckStatus();
			Set_StatusCombo(txt_status.Text);
		}

		private void Btn_BarcodeCreateProcess()
		{
			if (this.MAKE_BARCODE())
			{
				txt_status.Text = ClassLib.ComVar.Barcode;
				CheckStatus();
				ClassLib.ComFunction.User_Message("Complete create barcode", "Barcode Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
				fgrid_tail.AllowEditing = false;
				Set_StatusCombo(txt_status.Text);
			}

			this.SearchTailInfo();
		}




		private void Btn_BarcodeCancelProcess()
		{
			DataTable vDt = this.CANCEL_BARCODE();

			if (vDt.Rows[0].ItemArray[0].ToString().StartsWith(_packing))
			{
				txt_status.Text = vDt.Rows[0].ItemArray[0].ToString();
				this.SearchTailInfo();
				CheckStatus();
				ClassLib.ComFunction.User_Message("Complete cancel barcode : " + vDt.Rows[0].ItemArray[1].ToString(), "Barcode Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
				fgrid_tail.AllowEditing = true;
				Set_StatusCombo(txt_status.Text);
			}
			else
			{
				ClassLib.ComFunction.User_Message("Already incomed data : " + vDt.Rows[0].ItemArray[1].ToString());
			}
		}

		private void Set_StatusCombo(string arg_status)
		{
			try
			{
				int vIdx = cmb_shipNo.SelectedIndex;

				if (vIdx > -1)
				{
					((DataTable)cmb_shipNo.DataSource).Rows[vIdx].ItemArray[6] = arg_status;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Combo Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Btn_HeadSearchClickProcess()
		{
			Pop_BS_Shipping_List_Head vPopup = new Pop_BS_Shipping_List_Head();
			ClassLib.ComVar.Parameter_PopUp_Object		= new object[3];
			ClassLib.ComVar.Parameter_PopUp_Object[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			ClassLib.ComVar.Parameter_PopUp_Object[1]	= "11";
			ClassLib.ComVar.Parameter_PopUp_Object[2]	= dpick_shipYmd.Value;


			if (vPopup.ShowDialog() == DialogResult.OK)
			{
				_practicable = false;
				cmb_factory.SelectedValue		= COM.ComVar.Parameter_PopUp[0];
				dpick_shipYmd.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
				cmb_size.SelectedValue			= COM.ComVar.Parameter_PopUp[3];
				cmb_materialType.SelectedValue	= COM.ComVar.Parameter_PopUp[4];
				cmb_obsType.SelectedValue		= COM.ComVar.Parameter_PopUp[5];
				_practicable = true;
				Cmb_ShipNoSettingProcess();
				cmb_shipNo.SelectedValue		= COM.ComVar.Parameter_PopUp[6];
			}

			vPopup.Dispose();
		}

		#endregion

		#region 그리드 이벤트

		private void Grid_CellClickProcess()
		{
			int[] vSelectionRange = fgrid_tail.Selections;
			int vCol = fgrid_tail.Selection.c1;
			string vStatus = txt_status.Text;

			if (vSelectionRange.Length == 0)	return;

			COM.ComVar.Parameter_PopUp		= new string[1];
			COM.ComVar.Parameter_PopUp[0]	= fgrid_tail[1, vCol].ToString();
	
			if (_cellCombo.ContainsKey(vCol))
				ClassLib.ComVar.Parameter_PopUp_Object = new object[]{_cellCombo[vCol]};

			Pop_BS_Shipping_List_Changer pop_changer = new Pop_BS_Shipping_List_Changer();
			pop_changer.ShowDialog();

			if (COM.ComVar.Parameter_PopUp != null)
				foreach (int i in vSelectionRange)
				{
					fgrid_tail[i, vCol] = COM.ComVar.Parameter_PopUp[0];
					if (COM.ComVar.Parameter_PopUp.Length > 1)
					{
						fgrid_tail[i, _custNameCol] = COM.ComVar.Parameter_PopUp[0];
						fgrid_tail[i, _custCdCol] = COM.ComVar.Parameter_PopUp[1];
					}
					if (vStatus.Equals(ClassLib.ComVar.Packing) && (fgrid_tail.Col == _shipYNCol || fgrid_tail.Col == _outsideYNCol || fgrid_tail.Col == _packingUnitQtyCol || fgrid_tail.Col == _shipQtyCol))
					{
						if (!ShippingCancel(i, fgrid_tail.Col))
						{
							break;
						}
						GridSetColor(i);
					}

					if (fgrid_tail.Col == _cbdPriceCol || fgrid_tail.Col == _cbdPriceCol + 1)
						CBDInfoChange(i);

					fgrid_tail.Update_Row(i);
				}

			pop_changer.Dispose();
		}

		private void Grid_AfterEditProcess()
		{
			string vStatus = txt_status.Text;

			if (vStatus.Equals(ClassLib.ComVar.Packing) && (fgrid_tail.Col == _shipYNCol || fgrid_tail.Col == _outsideYNCol || fgrid_tail.Col == _packingUnitQtyCol || fgrid_tail.Col == _shipQtyCol))
				ShippingCancel(fgrid_tail.Row, fgrid_tail.Col);
			else if (fgrid_tail.Col == _cbdPriceCol || fgrid_tail.Col == _cbdPriceCol + 1)
				CBDInfoChange(fgrid_tail.Row);
			else
				fgrid_tail.Update_Row();

			GridSetColor(fgrid_tail.Row);
		}

		private void CBDInfoChange(int arg_row)
		{
			try
			{
				// CBD 정보 변경시
				if (fgrid_tail.Col == _cbdPriceCol)
				{
					double vCbdPrice = Convert.ToDouble(ClassLib.ComFunction.NullCheck(fgrid_tail[arg_row, _cbdPriceCol], "0"));
					fgrid_tail[arg_row, _shipPriceCol] = vCbdPrice * vPriceRate;
					fgrid_tail.Update_Row();
				}
				if (fgrid_tail.Col == _cbdPriceCol + 1)
				{
					fgrid_tail[arg_row, _shipPriceCol + 1] = fgrid_tail[arg_row, _cbdPriceCol + 1];
					fgrid_tail.Update_Row();
				}
			}
			catch
			{
				fgrid_tail[arg_row, _cbdPriceCol] = 0;
			}
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_tail.Rows.Fixed > 0) && (fgrid_tail.Row >= fgrid_tail.Rows.Fixed))
				fgrid_tail.Buffer_CellData = (fgrid_tail[fgrid_tail.Row, fgrid_tail.Col] == null) ? "" : fgrid_tail[fgrid_tail.Row, fgrid_tail.Col].ToString();
		}

		#endregion

		#region Validate Check

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
			if (cmb_factory.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_factory.Focus();
				return false;
			}

			if (cmb_shipNo.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Shipping No", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_factory.Focus();
				return false;
			}

			if (fgrid_tail.Rows.Count <= fgrid_tail.Rows.Fixed 
				&& (arg_type == ClassLib.ComVar.Validate_Save ||
					arg_type == ClassLib.ComVar.Validate_Delete ||
					arg_type == _validate_createPK || 
					arg_type == _validate_cancelPK || 
					arg_type == _validate_createBC ||
					arg_type == _validate_cancelBC ))
			{
				ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
																																	 

			// 부분별 체크 (Search, Save, Delete, Confirm..)
			switch (arg_type)
			{
				case ClassLib.ComVar.Validate_Search:

					break;
				case ClassLib.ComVar.Validate_Save:
					if (fgrid_tail.Rows.Fixed >= fgrid_tail.Rows.Count)
					{
						ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}

					for (int vRow = fgrid_tail.Rows.Fixed ; vRow < fgrid_tail.Rows.Count ; vRow++)
					{
						if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _shipYNCol]).StartsWith("Y") || 
							ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _outsideYNCol]).StartsWith("Y"))
						{
							double vCBDPrice = Convert.ToDouble(NullToZero(fgrid_tail[vRow, _cbdPriceCol]));

							if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _shipYNCol]).StartsWith("Y") && 
								ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _outsideYNCol]).StartsWith("Y"))
							{
								ClassLib.ComFunction.User_Message("Invalidate Data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _outsideYNCol);
								return false;
							}
							if (vCBDPrice > _maxPrice)
							{
								fgrid_tail.Select(vRow, _cbdPriceCol);

								if (ClassLib.ComFunction.User_Message("Check CBD price, right?", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
								{
									continue;
								}
								else
								{
									return false;
								}
							}
							if (!ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _cbdPriceCol + 1]).Equals("USD"))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "CBD Currency", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _cbdPriceCol + 1);
								return false;
							}
						}
					}
					break;
				case ClassLib.ComVar.Validate_Delete:

					break;
				case ClassLib.ComVar.Validate_Confirm:
					if (!txt_status.Text.StartsWith(_save))
					{
						ClassLib.ComFunction.User_Message("Already create Barcode", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
				case _validate_createPK:	// Btn_PackingCreateClickProcess() 에 세부 사항 체크 로직 있음
					if (!txt_status.Text.StartsWith(_save))
					{
						ClassLib.ComFunction.User_Message("Current status is not Save", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					if (fgrid_tail.Rows.Fixed >= fgrid_tail.Rows.Count)
					{
						ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}

					string vPackingString = txt_packing.Text;
					string vCharacter = ClassLib.ComFunction.ValidateCheck(vPackingString, ClassLib.ComVar.SpecialCharacter);
					if (vPackingString.Trim().Equals(""))
					{
						ClassLib.ComFunction.User_Message("Packing string is missing", "Empty Packing String", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						txt_packing.Focus();
						return false;
					}
					if (vCharacter != null)
					{
						ClassLib.ComFunction.User_Message(vCharacter + " is unfit for use character", "Packing Character Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						txt_packing.Focus();
						return false;
					}
					for (int vRow = fgrid_tail.Rows.Fixed ; vRow < fgrid_tail.Rows.Count ; vRow++)
					{
						if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _shipYNCol]).StartsWith("Y") || 
							ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _outsideYNCol]).StartsWith("Y"))
						{
							double vCBDPrice = Convert.ToDouble(NullToZero(fgrid_tail[vRow, _cbdPriceCol]));

							if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _shipYNCol]).StartsWith("Y") && 
								ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _outsideYNCol]).StartsWith("Y"))
							{
								ClassLib.ComFunction.User_Message("Invalidate Data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _outsideYNCol);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _shipQtyCol]).Equals("") || ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _shipQtyCol]).Equals("0"))
							{
								ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : Shipping Qty", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _shipQtyCol);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _packingUnitQtyCol]).Equals("") || ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _packingUnitQtyCol]).Equals("0"))
							{
								ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : Packing Unit Qty", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _packingUnitQtyCol);
								return false;
							}
							if (vCBDPrice > _maxPrice)
							{
								fgrid_tail.Select(vRow, _cbdPriceCol);

								if (ClassLib.ComFunction.User_Message("Check CBD price, right?", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
								{
									continue;
								}
								else
								{
									return false;
								}
							}
							if (!ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _cbdPriceCol + 1]).Equals("USD"))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "CBD Currency", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _cbdPriceCol + 1);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _custCdCol]).Trim().Equals(""))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : Vendor info", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _custCdCol);
								return false;
							}
						}
					}
					break;
				case _validate_createBC:
					if (!txt_status.Text.StartsWith(_packing))
					{
						ClassLib.ComFunction.User_Message("Current status is not Packing", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					for (int vRow = fgrid_tail.Rows.Fixed ; vRow < fgrid_tail.Rows.Count ; vRow++)
					{
						if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _shipYNCol]).StartsWith("Y") || 
							ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _outsideYNCol]).StartsWith("Y"))
						{
							double vShipQty = Convert.ToDouble(NullToZero(fgrid_tail[vRow, _shipQtyCol]));
							double vPurPrice = Convert.ToDouble(NullToZero(fgrid_tail[vRow, _purPriceCol]));
							double vCBDPrice = Convert.ToDouble(NullToZero(fgrid_tail[vRow, _cbdPriceCol]));
							double vShipPrice = Convert.ToDouble(NullToZero(fgrid_tail[vRow, _shipPriceCol]));
							double vPkQty = Convert.ToDouble(NullToZero(fgrid_tail[vRow, _packingUnitQtyCol]));

							if (vShipQty <= 0)
							{
								ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "Shipping Qty", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _shipQtyCol);
								return false;
							}
							if (vPurPrice <= 0)
							{
								ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "Purchase Price", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _purPriceCol);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _purPriceCol + 1]).Equals(""))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "Purchase Currency", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _purPriceCol + 1);
								return false;
							}
							if (vCBDPrice <= 0)
							{
								ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "CBD Price", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _cbdPriceCol);
								return false;
							}
							if (vCBDPrice > _maxPrice)
							{
								fgrid_tail.Select(vRow, _cbdPriceCol);

								if (ClassLib.ComFunction.User_Message("Check CBD price, continue?", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
								{
                                    continue;
								}
								else
								{
									return false;
								}
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _cbdPriceCol + 1]).Equals(""))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "CBD Currency", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _cbdPriceCol + 1);
								return false;
							}
							if (!ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _cbdPriceCol + 1]).Equals("USD"))
							{
								ClassLib.ComFunction.User_Message("Check CBD Currency", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _cbdPriceCol + 1);
								return false;
							}
							if (vShipPrice <= 0)
							{
								ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "CBD Price", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _shipPriceCol);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _shipPriceCol + 1]).Equals(""))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "Shipping Currency", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _shipPriceCol + 1);
								return false;
							}
							if (vPkQty <= 0)
							{
								ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "PK Unit Qty", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _packingUnitQtyCol);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxPUR_USER]).Trim().Equals(""))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "Purchase User", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxPUR_USER);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, _custCdCol]).Trim().Equals(""))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "Vendor Info", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_tail.Select(vRow, _custCdCol);
								return false;
							}
						}
					}

					if (fgrid_tail.Rows.Fixed < fgrid_tail.Rows.Count)
					{
						string vTemp = fgrid_tail.GetCellRange(fgrid_tail.Rows.Fixed, 0, fgrid_tail.Rows.Count - 1, 0).Clip.Replace("\r", "");

						if (vTemp.Length > 0)
						{
							MessageBox.Show(this, "Exist modify data. Please save first", "Create Barcode", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return false;
						}
					}
					break;
				case _validate_createSC:
					if (!txt_status.Text.StartsWith(_barcode))
					{
						ClassLib.ComFunction.User_Message("Current status is not Barcode", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					if (cmb_shipNo.SelectedIndex == -1)
					{
						ClassLib.ComFunction.User_Message("Select ship no", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					if (ClassLib.ComFunction.EmptyCellCheck(fgrid_tail, 1, this._statusCol, _CTCol))
					{
						return false;
					}
					break;
				case _validate_trade:
					if (!(txt_status.Text.StartsWith(_invoice) || txt_status.Text.StartsWith(_barcode)))
					{
						ClassLib.ComFunction.User_Message("Current status is not Invoice", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
				case _validate_cancelPK:
					if (!txt_status.Text.StartsWith(_packing))
					{
						ClassLib.ComFunction.User_Message("Current status is not Packing", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
				case _validate_cancelBC:
					if (!txt_status.Text.StartsWith(_barcode))
					{
						ClassLib.ComFunction.User_Message("Current status is not Barcode", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
				case _validate_cancelSC:
					if (!txt_status.Text.StartsWith(_invoice))
					{
						ClassLib.ComFunction.User_Message("Current status is not Invoice", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
			}

			return true;
		}

		#endregion

		#region 프로그램 속성

		private void CheckStatus()
		{
			bool vEnabled;

			if (txt_status.Text.Equals(ClassLib.ComVar.Save) || txt_status.Text.Equals(ClassLib.ComVar.Packing) || txt_status.Text.Equals(""))
				vEnabled = true;
			else
				vEnabled = false;

			tbtn_Save.Enabled		= vEnabled;

			btn_search.Enabled = vEnabled;
			btn_Insert.Enabled = vEnabled;
			btn_delete.Enabled = vEnabled;
			btn_recover.Enabled = vEnabled;
			mnu_autoCalc.Enabled = vEnabled;


			switch (txt_status.Text)
			{
				case ClassLib.ComVar.Save:
					btn_packing.Text = "P/K Create";
					btn_barcode.Text = "B/C Create";
					btn_packing.Enabled = true;
					btn_barcode.Enabled = false;
					btn_Trade.Enabled = false;
					btn_allTrade.Enabled = false;
					break;
				case ClassLib.ComVar.Packing:
					btn_packing.Text = "P/K Cancel";
					btn_barcode.Text = "B/C Create";
					btn_packing.Enabled = true;
					btn_barcode.Enabled = true;
					btn_Trade.Enabled = false;
					btn_allTrade.Enabled = false;
					break;
				case ClassLib.ComVar.Barcode:
					btn_packing.Text = "P/K Create";
					btn_barcode.Text = "B/C Cancel";
					btn_barcode.Enabled = true;
					btn_packing.Enabled = false;
					btn_Trade.Enabled = true;
					btn_allTrade.Enabled = true;
					break;
				case "Invoice Transmit":
					btn_packing.Text = "P/K Create";
					btn_barcode.Text = "B/C Cancel";
					btn_barcode.Enabled = false;
					btn_packing.Enabled = false;
					btn_Trade.Enabled = true;
					btn_allTrade.Enabled = true;
					break;
				case "":
					btn_packing.Text = "P/K Create";
					btn_barcode.Text = "B/C Create";
					btn_packing.Enabled = false;
					btn_barcode.Enabled = false;
					btn_Trade.Enabled = false;
					btn_allTrade.Enabled = false;
					break;
				default:
					btn_packing.Text = "P/K Cancel";
					btn_barcode.Text = "B/C Cancel";
					btn_packing.Enabled = false;
					btn_barcode.Enabled = false;
					btn_Trade.Enabled = false;
					btn_allTrade.Enabled = false;
					break;
			}
		}

		#endregion

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBS_SHIPPING_HEAD : 선적 번호 리스트 찾기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_ship_ymd">선적일</param>
		/// <param name="arg_devision">구분</param>
		/// <param name="arg_size">사이즈구분</param>
		/// <param name="arg_material_type">자재구분</param>
		/// <param name="arg_obs_type">OBS Type</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_SHIPPING_HEAD_SNO(string arg_factory, string arg_ship_ymd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_HEAD.SELECT_SHIPPING_NUMBER_2";


			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_REASON";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_ship_ymd;
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_materialType, "");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_reason_s, "");
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


        
        public DataTable SELECT_SHIPPING_RATE(string arg_this_factory, string  arg_com_cd, string  arg_factory )
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.SELECT_SHIP_RATE";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_COM_CD";
            MyOraDB.Parameter_Name[2] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = arg_this_factory;
            MyOraDB.Parameter_Values[1] = arg_com_cd;
            MyOraDB.Parameter_Values[2] = arg_factory;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }


		/// <summary>
		/// PKG_SBS_SHIPPING_HEAD : 헤더 정보 찾기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_ship_no">선적번호</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_SHIPPING_HEAD(string arg_factory, string arg_ship_no)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_HEAD.SELECT_SBS_SHIPPING_HEAD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_ship_no;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBS_SHIPPING_TAIL : 자재별(리스트) 찾기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_ship_no">선적번호</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_SHIPPING_TAIL_LIST(string arg_factory, string arg_ship_no)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_TAIL.SELECT_SBS_SHIPPING_TAIL_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_NO";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = arg_factory;
			MyOraDB.Parameter_Values[2] = arg_ship_no;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBS_SHIPPING_SIZE : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_SHIPPING_SIZE_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_SIZE.SELECT_SBS_SHIPPING_SIZE_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_SIZE";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[5] = "ARG_SHIP_NO";
			MyOraDB.Parameter_Name[6] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[7] = "ARG_GENDER";
			MyOraDB.Parameter_Name[8] = "ARG_PRESTO";
			MyOraDB.Parameter_Name[9] = "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = dpick_shipYmd.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(cmb_size, "");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_materialType, "");
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(cmb_obsType, "");
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_Combo(cmb_shipNo, "");
			MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_TextBox(txt_styleCode, "").Replace("-", "").Replace("NONE", "");
			MyOraDB.Parameter_Values[7] = ClassLib.ComFunction.Empty_TextBox(txt_gender, "");
			MyOraDB.Parameter_Values[8] = ClassLib.ComFunction.Empty_TextBox(txt_presto, "");
			MyOraDB.Parameter_Values[9] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// SAVE_SBS_SHIPPING_HEAD : 헤더 정보 저장
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_ship_no">선적번호</param>
		/// <param name="arg_ship_qty">선적수량</param>
		/// <param name="arg_packing">패킹문자열</param>
		/// <param name="arg_remarks">비고</param>
		/// <param name="arg_status">상태</param>
		/// <param name="arg_upd_user">사용자</param>
		public bool SAVE_SBS_SHIPPING_HEAD()
		{
			try
			{
				MyOraDB.ReDim_Parameter(7);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBS_SHIPPING_HEAD.SAVE_SBS_SHIPPING_HEAD";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_QTY";
				MyOraDB.Parameter_Name[3] = "ARG_PACKING";
				MyOraDB.Parameter_Name[4] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[5] = "ARG_STATUS";
				MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipNo, "");
				MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_TextBox(txt_shipQty, "");
				MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_TextBox(txt_packing, "");
				MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_TextBox(txt_remarks, "");
				MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_TextBox(txt_status, "S");
				MyOraDB.Parameter_Values[6] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);
				//MyOraDB.Exe_Modify_Procedure();

				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBS_SHIPPING_HEAD", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		/// <summary>
		/// PKG_SBS_SHIPPING_TAIL : 
		/// </summary>
		public bool MAKE_BARCODE()
		{
			try
			{
				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.MAKE_BARCODE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
				MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipNo, "");
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
		/// PKG_SBS_SHIPPING_LIST : 
		/// </summary>
		public DataTable CANCEL_BARCODE()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.CANCEL_BARCODE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
			MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipNo, "");
			MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBS_SHIPPING_LIST : 
		/// </summary>
		public void SALESCONTRACT_PROCESS(string arg_processName, string arg_factory, string arg_ship_no)
		{
			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = arg_processName;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
			MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_ship_no;
			MyOraDB.Parameter_Values[2] = COM.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}

		#endregion	

		#region 소요량 계산

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
			{
				Show_Tree_Popup();
			}
		}

		private void Show_Tree_Popup()
		{
			try
			{
				int[] vChecks = new int[]{(int)ClassLib.TBSBS_SHIPPING_TAIL.IxSEND_CHK, 
											 (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM_CD, 
											 (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC_CD, 
											 (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR_CD};
				ClassLib.ComVar.Parameter_PopUp = new string[]{COM.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory), "S"};
				FlexPurchase.Purchase.Pop_BC_Yield_Info vPop = new FlexPurchase.Purchase.Pop_BC_Yield_Info(fgrid_tail, vChecks);
				vPop._style = txt_styleCode.Text.Trim().Replace("_", "");
				
				
				vPop.ShowDialog();

				if ( ClassLib.ComVar.Parameter_PopUpTable.Rows.Count > 0 && vPop.DialogResult == DialogResult.OK)
				{
					vWaitPop = new Pop_BS_Shipping_List_Wait();
					Thread vCalcThread = new Thread(new ThreadStart(vWaitPop.Start));
					vCalcThread.Start();
					Etc_SizeCalculation();					
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Etc_SizeCalculation()
		{
			try
			{
				// spd_size 의 내용을 SBT_TEMP_SIZE 에 저장
				// bool vBoolSize = SAVE_SBT_TEMP_SIZE();

				// pop_up   의 내용을 SBT_TEMP_ITEM 에 저장
				bool vBoolTemp = SAVE_SBT_TEMP_ITEM();

				if(vBoolTemp == true)
				{
					if (MyOraDB.Exe_Modify_Procedure() != null)
					{
						// 소요량 조회하는 프로시져 호출
						DataTable vDt = SELECT_SBT_TEMP_ITEM(cmb_factory.SelectedValue.ToString(),  COM.ComVar.This_User);
						if (vDt.Rows.Count > 0)
						{
							for(int i = 0 ; i < vDt.Rows.Count ; i++)
							{
								InsertItem(vDt.Rows[i]);
							}
						}
						else
							vDt.Dispose();
					}
				}

				_practicable = true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				ClassLib.ComVar.Parameter_PopUpTable.Dispose();
				vWaitPop.Close();
			}
		}

		private void InsertItem(DataRow arg_row)
		{
			try
			{
				int row = fgrid_tail.Rows.Count;
				fgrid_tail.Add_Row(row - 1);

				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxFACTORY]		= cmb_factory.SelectedValue;
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_NO]		= cmb_shipNo.SelectedValue;
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM_CD]		= arg_row[0];
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM]			= arg_row[1];
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC_CD]		= arg_row[2];
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC]			= arg_row[3];
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR_CD]		= arg_row[4];
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR]			= arg_row[5];
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxPUR_QTY]		= arg_row[6];
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_QTY]		= arg_row[6];
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxUNIT]			= arg_row[9];
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxPK_UNIT_QTY]	= ClassLib.ComFunction.NullCheck(arg_row[11], "0");
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxINDEX]			= (fgrid_tail.Rows.Count - fgrid_tail.Rows.Fixed) + 1;
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSEND_CHK]		= ClassLib.ComVar.Parameter_PopUpTable.Rows[0][8].ToString();
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxOUTSIDE_YN]		= ClassLib.ComVar.No;
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSTATUS]			= txt_status.Text;
				fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxREMARKS]		= "Insert : " + DateTime.Now.ToString("yyyyMMdd-") + DateTime.Now.ToString("hh:mm:ss");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_FlexGrid_Tree_Add",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}
		}

		public bool SAVE_SBT_TEMP_ITEM()
		{
			try
			{
				MyOraDB.ReDim_Parameter(9);

				//01.PROCEDURE명
				MyOraDB.Process_Name    = "PKG_SBS_SHIPPING_LIST.SAVE_SBT_TEMP";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_ACTION_USER";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
				MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[5] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[6] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[8] = "ARG_SHIP_NO";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;

				//04.DATA 정의
				ArrayList vList = new ArrayList();
				vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[0][7].ToString());
				vList.Add(COM.ComVar.This_User);
				vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[0][8].ToString());
				vList.Add("");
				vList.Add(ClassLib.ComVar.Delete);
				vList.Add("");
				vList.Add("");
				vList.Add(COM.ComVar.This_User);
				vList.Add(COM.ComFunction.Empty_Combo(cmb_shipNo, ""));

				for(int i = 0; i < ClassLib.ComVar.Parameter_PopUpTable.Rows.Count ; i++)
				{
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][7].ToString());
					vList.Add(COM.ComVar.This_User);
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][8].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][9].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][0].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][2].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][4].ToString());
					vList.Add(COM.ComVar.This_User);
					vList.Add(COM.ComFunction.Empty_Combo(cmb_shipNo, ""));
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message, "SAVE_SBT_TEMP_ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}

		/// <summary>
		/// PKG_SBT_TEMP_ITEM :  SELECT_SBT_TEMP_ITEM
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_req_no">청구번호</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBT_TEMP_ITEM(string arg_factory, string arg_action_user)
		{
			// SELECT_SBS_SHIPPING_SIZE_LIST 참고
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBT_TEMP_ITEM.SELECT_SBT_TEMP_ITEM_ORDER";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_ACTION_USER";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_action_user;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion

		#region 추가기능 (Insert, Delete, Update, 채산팝업등 )

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
			{
				Show_Item_Popup();
			}
		}

		/// <summary>
		/// Show_Item_Popup : Item 기타 데이터 입력하는 팝업 실행 : Item/ Specification/ Color
		/// </summary>
		private void Show_Item_Popup()
		{
			try
			{
				FlexBase.MaterialBase.Pop_Item_List vPopup = new FlexBase.MaterialBase.Pop_Item_List();
				vPopup.ShowDialog(); 

				if(ClassLib.ComVar.Parameter_PopUp[0].Trim() != "")
				{
					if (Etc_DataDuplicateCheck())
					{
						int row = fgrid_tail.Rows.Count;
						fgrid_tail.Add_Row(row - 1);

						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxFACTORY]		= cmb_factory.SelectedValue;
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_NO]		= cmb_shipNo.SelectedValue;
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM_CD]		= ClassLib.ComVar.Parameter_PopUp[0];
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM]			= ClassLib.ComVar.Parameter_PopUp[1];
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC_CD]		= ClassLib.ComVar.Parameter_PopUp[2];
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC]			= ClassLib.ComVar.Parameter_PopUp[3];
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR_CD]		= ClassLib.ComVar.Parameter_PopUp[4];
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR]			= ClassLib.ComVar.Parameter_PopUp[5];
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxPUR_QTY]		= 0;
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_QTY]		= 0;
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxUNIT]			= ClassLib.ComVar.Parameter_PopUp[6];
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxPK_UNIT_QTY]	= 0;
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxINDEX]			= (fgrid_tail.Rows.Count - fgrid_tail.Rows.Fixed) + 1;
						if (!txt_styleCode.Text.Equals("_________"))
							fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSEND_CHK]	= txt_styleCode.Text.Replace("-", "");
						else
							fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSEND_CHK]	= "NONE";

						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxOUTSIDE_YN]		= ClassLib.ComVar.No;
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSTATUS]			= txt_status.Text;
						fgrid_tail[row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxREMARKS]		= "Insert : " + DateTime.Now.ToString("yyyyMMdd-") + DateTime.Now.ToString("hh:mm:ss");
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

			private bool Etc_DataDuplicateCheck()
		{
			for ( int vRow = fgrid_tail.Rows.Fixed ; vRow < fgrid_tail.Rows.Count ; vRow++ )
			{
				if( fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM_CD].ToString().Equals(ClassLib.ComVar.Parameter_PopUp[0]) &&
					fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC_CD].ToString().Equals(ClassLib.ComVar.Parameter_PopUp[2]) &&
					fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR_CD].ToString().Equals(ClassLib.ComVar.Parameter_PopUp[4])) 
				{
					ClassLib.ComFunction.User_Message("The selected item is already exists.", "DataDuplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					fgrid_tail.Select(vRow, 1);
					return true;
				}
			}

			return true;
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
			{
				fgrid_tail.Delete_Row();
			}
		}

		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			fgrid_tail.Recover_Row();
		}

		private void mnu_usageCheck_Click(object sender, System.EventArgs e)
		{
			try
			{
				int vRow = fgrid_tail.Row;

				COM.ComVar.Parameter_PopUp		= new string[17];
				COM.ComVar.Parameter_PopUp[0]	= COM.ComFunction.Empty_Combo(cmb_factory, "");
				COM.ComVar.Parameter_PopUp[1]	= cmb_shipNo.GetItemText(cmb_shipNo.SelectedIndex, 1).Replace("_", "");
				COM.ComVar.Parameter_PopUp[2]	= cmb_shipNo.GetItemText(cmb_shipNo.SelectedIndex, 2);
				COM.ComVar.Parameter_PopUp[3]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM]);
				COM.ComVar.Parameter_PopUp[4]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC]);
				COM.ComVar.Parameter_PopUp[5]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR]);
				COM.ComVar.Parameter_PopUp[6]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxPUR_QTY]);

				COM.ComVar.Parameter_PopUp[7]	= COM.ComFunction.Empty_Combo(cmb_materialType, "");
				COM.ComVar.Parameter_PopUp[8]	= COM.ComFunction.Empty_Combo(cmb_shipNo, "");
				COM.ComVar.Parameter_PopUp[9]	= "";
				COM.ComVar.Parameter_PopUp[10]	= "";
				COM.ComVar.Parameter_PopUp[11]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM_CD]);
				COM.ComVar.Parameter_PopUp[12]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC_CD]);
				COM.ComVar.Parameter_PopUp[13]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR_CD]);
				COM.ComVar.Parameter_PopUp[14]	= COM.ComFunction.Empty_Combo(cmb_obsType, "");
				COM.ComVar.Parameter_PopUp[15]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxOUTSIDE_YN]);
                COM.ComVar.Parameter_PopUp[16] = ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_SEQ]);

				Pop_BS_Usage_Check vPop = new Pop_BS_Usage_Check();
				vPop.ShowDialog();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Usage Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void mnu_VendorChange_Click(object sender, System.EventArgs e)
		{
			try
			{
				int vRow = fgrid_tail.Row;

				COM.ComVar.Parameter_PopUp		= new string[5];
				COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxFACTORY]);
				COM.ComVar.Parameter_PopUp[1]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_NO]);
				COM.ComVar.Parameter_PopUp[2]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSHIP_SEQ]);
				COM.ComVar.Parameter_PopUp[3]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCUST_CD]);
				COM.ComVar.Parameter_PopUp[4]	= ClassLib.ComFunction.NullToBlank(fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxVENDOR]);

				Pop_BS_Vendor_Change vPop = new Pop_BS_Vendor_Change();
				vPop.ShowDialog(this);

				if (ClassLib.ComVar.Parameter_PopUp.Length == 2)
				{
					fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCUST_CD] = ClassLib.ComVar.Parameter_PopUp[0];
					fgrid_tail[vRow, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxVENDOR] = ClassLib.ComVar.Parameter_PopUp[1];
				}


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "mnu_VendorChange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void fgrid_tail_DoubleClick(object sender, System.EventArgs e)
		{
			try
			{
				//Show_Item_Popup_Modify();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}		
		
		private void Show_Item_Popup_Modify()
		{
			try
			{
				int sel_row = fgrid_tail.Selection.r1;

				if(sel_row < fgrid_tail.Rows.Fixed) return;

				string item_cd		= ClassLib.ComFunction.NullToBlank(fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM_CD]);
				string item_name	= ClassLib.ComFunction.NullToBlank(fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM]);
				string spec_cd		= ClassLib.ComFunction.NullToBlank(fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC_CD]);
				string spec_name	= ClassLib.ComFunction.NullToBlank(fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC]);
				string color_cd		= ClassLib.ComFunction.NullToBlank(fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR_CD]);
				string color_name	= ClassLib.ComFunction.NullToBlank(fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR]);
				string unit			= ClassLib.ComFunction.NullToBlank(fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxUNIT]);
				string size_yn		= "";

				FlexBase.MaterialBase.Pop_Item_List pop_form = new FlexBase.MaterialBase.Pop_Item_List(item_cd, item_name, spec_cd, spec_name, color_cd, color_name, unit, size_yn, true);
				pop_form.ShowDialog();
				pop_form.Dispose();

				fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM_CD] = ClassLib.ComVar.Parameter_PopUp[0];
				fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxITEM] = ClassLib.ComVar.Parameter_PopUp[1];
				fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC_CD] = ClassLib.ComVar.Parameter_PopUp[2];
				fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSPEC] = ClassLib.ComVar.Parameter_PopUp[3];
				fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR_CD] = ClassLib.ComVar.Parameter_PopUp[4];
				fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxCOLOR] = ClassLib.ComVar.Parameter_PopUp[5];
				fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxUNIT] = ClassLib.ComVar.Parameter_PopUp[6];
				//fgrid_tail[sel_row, (int)ClassLib.TBSBS_SHIPPING_TAIL.IxSIZE_YN] = Convert.ToBoolean(ClassLib.ComVar.Parameter_PopUp[7] );

				fgrid_tail.Update_Row();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion









	}
}

