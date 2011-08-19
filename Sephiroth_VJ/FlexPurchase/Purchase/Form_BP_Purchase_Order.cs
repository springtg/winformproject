using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;
using FlexPurchase.Incoming;
using C1.Win.C1FlexGrid;
using FlexPurchase.Shipping;

namespace FlexPurchase.Purchase
{
	public class Form_BP_Purchase_Order : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private COM.SSP spd_size;
		private FarPoint.Win.Spread.SheetView spd_size_Sheet1;
		private System.Windows.Forms.Panel pnl_low;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_Tree;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;		
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_purNo;
		private System.Windows.Forms.Label lbl_purYmd;
		private System.Windows.Forms.Label lbl_purUser;
		private System.Windows.Forms.Label lbl_rtaYmd;
		private System.Windows.Forms.Label lbl_purDiv;
		private System.Windows.Forms.Label lbl_etsYmd;
		private System.Windows.Forms.Label lbl_buyDiv;
		private System.Windows.Forms.Label lbl_purStatus;			
		private C1.Win.C1List.C1Combo cmb_factory;
		private C1.Win.C1List.C1Combo cmb_purNo;
		private System.Windows.Forms.DateTimePicker dpick_purYmd;
		private C1.Win.C1List.C1Combo cmb_purUser;
		private C1.Win.C1List.C1Combo cmb_buyDiv;
		private System.Windows.Forms.DateTimePicker dpick_rtaYmd;
		private System.Windows.Forms.DateTimePicker dpick_etsYmd;
		private System.Windows.Forms.TextBox txt_remarks;	
		private System.Windows.Forms.Label btn_searchPur;
		private System.Windows.Forms.Label btn_sizeItem;
		private System.Windows.Forms.Label btn_CtItem;
		private System.Windows.Forms.ContextMenu ctx_tail;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_Data;	
		private COM.FSP fgrid_main;
		private System.Windows.Forms.TextBox txt_mrpShipNo;
		private System.Windows.Forms.Label lbl_mrpShipNo;
		private System.Windows.Forms.TextBox txt_status;
		private C1.Win.C1List.C1Combo cmb_purDiv;
		private System.Windows.Forms.MenuItem mnu_tvo;
		private System.Windows.Forms.MenuItem mnu_header;
		private System.Windows.Forms.MenuItem mnu_detaile;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_cbd;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.Label btn_size;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem mnu_CBDPrice;
		private System.Windows.Forms.MenuItem mnu_Packing;
		private System.Windows.Forms.MenuItem mnu_CBM;
		private System.Windows.Forms.MenuItem mnu_Weight;
		private System.Windows.Forms.Label btn_CFM_Cancel;
		private System.Windows.Forms.MenuItem mnu_autoCalc;
		private System.Windows.Forms.MenuItem mnu_outside;
		private System.Windows.Forms.MenuItem mnu_exchange;
		private System.Windows.Forms.MenuItem mnu_painting;
		private System.Windows.Forms.MenuItem mnu_printing;
		private System.Windows.Forms.MenuItem mnu_hot_melt;
		private System.Windows.Forms.MenuItem mnu_rub_lam;
		private System.Windows.Forms.MenuItem mnu_lam;
		private System.Windows.Forms.MenuItem mnu_peea_eva;
		private System.Windows.Forms.MenuItem mnu_sub;
		private System.Windows.Forms.MenuItem mnu_sub_insole;
		private System.Windows.Forms.MenuItem mnu_sticker;

		private System.ComponentModel.IContainer components = null;

		#endregion		

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _sizeSheet = null;
		private System.EventHandler   _cmbPurNoEventHandler   = null;
		private bool _practicable  = true, _doSearch = true;
		private bool _firstLoad    = true;
		private int _purSeq = 0;
		private int _startCol = 4;
		private Hashtable _cellCombo = null;
		private const int _validate_context = 20;
		private const int _maxPrice = 50;
		private const string _CBDCurrency = "USD";
		private double _rate ;
		private int _controlLevel;
		private ArrayList _level1 = new ArrayList(20);

		private AxRDVIEWER40Lib.AxRdviewer40 myRD401;

		private int _factoryCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxFACTORY;		
		private int _purNoCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_NO;			
		private int _purSeqCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_SEQ;			
		private int _itemNameCol		= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxITEM_NAME;
		private int _specNameCol		= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxSPEC_NAME;			
		private int _colorNameCol		= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCOLOR_NAME;			
		private int _unitCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxUNIT;			
		private int _styleCdCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxITEM_NAME;
		private int _obsIdCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOBS_ID;
		private int _obsTypeCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOBS_TYPE;
		private int _itemCdCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxITEM_CD;			
		private int _specCdCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxSPEC_CD;			
		private int _colorCdCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCOLOR_CD;			
		private int _custCdCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCUST_CD;			
		private int _custNmCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCUST_NAME;
		private int _reqQtyCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxREQ_QTY;
		private int _purQtyCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_QTY;
		private int _purPriceCol		= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_PRICE;
		private int _outsidePriceCol	= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_PRICE;
		private int _cbdPriceCol		= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_PRICE;
		private int _purCurrencyCol		= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_CURRENCY;
		//private int _outsideCurrencyCol	= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_CURRENCY;
		private int _cbdCurrencyCol		= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_CURRENCY;
		private int _pkQtyCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPK_UNIT_QTY;
		private int _rtaYmdCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxRTA_YMD;			
		private int _etsYmd1Col			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxETS_YMD1;			
		private int _etsYmd2Col			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxETS_YMD2;			
		private int _etsYmd3Col			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxETS_YMD3;			
		private int _reqSeqCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxREQ_SEQ;			
		private int _purStatusCol		= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_STATUS;
		private int _cbmCol				= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBM;
		private int _weightCol			= (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxWEIGHT;

		private string _sizeStartColumnLabel = "";
		private string _sizeEndColumnLabel   = "";

		private string _obsType = "";
		private System.Windows.Forms.Label lbl_rate;
		private System.Windows.Forms.Label lbl_remarks;
		private System.Windows.Forms.TextBox txt_rate;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem10;

		private Pop_BP_Purchase_Wait _waitPop;
		
		public C1FlexGrid grid { get { return fgrid_main; } }

		#endregion

		#region 생성자 / 소멸자

		public Form_BP_Purchase_Order()
		{
			InitializeComponent();

			int[] vTemp = new int[]{ 
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPK_UNIT_QTY,
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_PRICE,		(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_CURRENCY,
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_PRICE,	(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_CURRENCY,	
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_PRICE,		(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_CURRENCY,
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxRTA_YMD,			(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxETS_YMD1,
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxETS_YMD2,			(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxETS_YMD3,
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBM,				(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxWEIGHT,
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOBS_YN
									};

			_level1.AddRange(vTemp);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BP_Purchase_Order));
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
            this.pnl_head = new System.Windows.Forms.Panel();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.lbl_remarks = new System.Windows.Forms.Label();
            this.btn_size = new System.Windows.Forms.Label();
            this.btn_CFM_Cancel = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_CtItem = new System.Windows.Forms.Label();
            this.btn_sizeItem = new System.Windows.Forms.Label();
            this.txt_mrpShipNo = new System.Windows.Forms.TextBox();
            this.cmb_purDiv = new C1.Win.C1List.C1Combo();
            this.cmb_purUser = new C1.Win.C1List.C1Combo();
            this.cmb_buyDiv = new C1.Win.C1List.C1Combo();
            this.dpick_etsYmd = new System.Windows.Forms.DateTimePicker();
            this.dpick_rtaYmd = new System.Windows.Forms.DateTimePicker();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.lbl_purStatus = new System.Windows.Forms.Label();
            this.lbl_mrpShipNo = new System.Windows.Forms.Label();
            this.lbl_buyDiv = new System.Windows.Forms.Label();
            this.lbl_etsYmd = new System.Windows.Forms.Label();
            this.lbl_purDiv = new System.Windows.Forms.Label();
            this.lbl_rtaYmd = new System.Windows.Forms.Label();
            this.dpick_purYmd = new System.Windows.Forms.DateTimePicker();
            this.btn_searchPur = new System.Windows.Forms.Label();
            this.cmb_purNo = new C1.Win.C1List.C1Combo();
            this.lbl_purNo = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.lbl_purUser = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_purYmd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pnl_low = new System.Windows.Forms.Panel();
            this.btn_Tree = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.spd_size = new COM.SSP();
            this.spd_size_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.fgrid_main = new COM.FSP();
            this.ctx_tail = new System.Windows.Forms.ContextMenu();
            this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
            this.mnu_Data = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_tvo = new System.Windows.Forms.MenuItem();
            this.mnu_header = new System.Windows.Forms.MenuItem();
            this.mnu_detaile = new System.Windows.Forms.MenuItem();
            this.mnu_cbd = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnu_autoCalc = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.mnu_outside = new System.Windows.Forms.MenuItem();
            this.mnu_painting = new System.Windows.Forms.MenuItem();
            this.mnu_printing = new System.Windows.Forms.MenuItem();
            this.mnu_sticker = new System.Windows.Forms.MenuItem();
            this.mnu_hot_melt = new System.Windows.Forms.MenuItem();
            this.mnu_rub_lam = new System.Windows.Forms.MenuItem();
            this.mnu_lam = new System.Windows.Forms.MenuItem();
            this.mnu_peea_eva = new System.Windows.Forms.MenuItem();
            this.mnu_sub = new System.Windows.Forms.MenuItem();
            this.mnu_sub_insole = new System.Windows.Forms.MenuItem();
            this.mnu_exchange = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.mnu_CBDPrice = new System.Windows.Forms.MenuItem();
            this.mnu_Packing = new System.Windows.Forms.MenuItem();
            this.mnu_CBM = new System.Windows.Forms.MenuItem();
            this.mnu_Weight = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            this.pnl_low.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_size_Sheet1)).BeginInit();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
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
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.pnl_low);
            this.c1Sizer1.Controls.Add(this.spd_size);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.GridDefinition = "27.9513888888889:False:True;10.4166666666667:False:True;54.6875:False:False;4.861" +
                "11111111111:False:True;\t0.393700787401575:False:True;98.4251968503937:False:Fals" +
                "e;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.txt_rate);
            this.pnl_head.Controls.Add(this.lbl_remarks);
            this.pnl_head.Controls.Add(this.btn_size);
            this.pnl_head.Controls.Add(this.btn_CFM_Cancel);
            this.pnl_head.Controls.Add(this.txt_status);
            this.pnl_head.Controls.Add(this.btn_CtItem);
            this.pnl_head.Controls.Add(this.btn_sizeItem);
            this.pnl_head.Controls.Add(this.txt_mrpShipNo);
            this.pnl_head.Controls.Add(this.cmb_purDiv);
            this.pnl_head.Controls.Add(this.cmb_purUser);
            this.pnl_head.Controls.Add(this.cmb_buyDiv);
            this.pnl_head.Controls.Add(this.dpick_etsYmd);
            this.pnl_head.Controls.Add(this.dpick_rtaYmd);
            this.pnl_head.Controls.Add(this.lbl_rate);
            this.pnl_head.Controls.Add(this.lbl_purStatus);
            this.pnl_head.Controls.Add(this.lbl_mrpShipNo);
            this.pnl_head.Controls.Add(this.lbl_buyDiv);
            this.pnl_head.Controls.Add(this.lbl_etsYmd);
            this.pnl_head.Controls.Add(this.lbl_purDiv);
            this.pnl_head.Controls.Add(this.lbl_rtaYmd);
            this.pnl_head.Controls.Add(this.dpick_purYmd);
            this.pnl_head.Controls.Add(this.btn_searchPur);
            this.pnl_head.Controls.Add(this.cmb_purNo);
            this.pnl_head.Controls.Add(this.lbl_purNo);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.txt_remarks);
            this.pnl_head.Controls.Add(this.lbl_purUser);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_purYmd);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 161);
            this.pnl_head.TabIndex = 4;
            // 
            // txt_rate
            // 
            this.txt_rate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rate.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_rate.Location = new System.Drawing.Point(438, 106);
            this.txt_rate.MaxLength = 500;
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.ReadOnly = true;
            this.txt_rate.Size = new System.Drawing.Size(220, 21);
            this.txt_rate.TabIndex = 541;
            this.txt_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_remarks
            // 
            this.lbl_remarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_remarks.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remarks.ImageIndex = 0;
            this.lbl_remarks.ImageList = this.img_Label;
            this.lbl_remarks.Location = new System.Drawing.Point(666, 106);
            this.lbl_remarks.Name = "lbl_remarks";
            this.lbl_remarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_remarks.TabIndex = 540;
            this.lbl_remarks.Text = "Remark";
            this.lbl_remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_size
            // 
            this.btn_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_size.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_size.ImageIndex = 0;
            this.btn_size.ImageList = this.img_Button;
            this.btn_size.Location = new System.Drawing.Point(746, 130);
            this.btn_size.Name = "btn_size";
            this.btn_size.Size = new System.Drawing.Size(80, 23);
            this.btn_size.TabIndex = 539;
            this.btn_size.Text = "Get Size Info";
            this.btn_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_size.Click += new System.EventHandler(this.btn_size_Click);
            // 
            // btn_CFM_Cancel
            // 
            this.btn_CFM_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_CFM_Cancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_CFM_Cancel.ImageIndex = 0;
            this.btn_CFM_Cancel.ImageList = this.img_Button;
            this.btn_CFM_Cancel.Location = new System.Drawing.Point(8, 130);
            this.btn_CFM_Cancel.Name = "btn_CFM_Cancel";
            this.btn_CFM_Cancel.Size = new System.Drawing.Size(80, 23);
            this.btn_CFM_Cancel.TabIndex = 539;
            this.btn_CFM_Cancel.Text = "CFM Cancel";
            this.btn_CFM_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CFM_Cancel.Click += new System.EventHandler(this.btn_CFM_Cancel_Click);
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_status.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_status.Location = new System.Drawing.Point(767, 40);
            this.txt_status.MaxLength = 500;
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(220, 21);
            this.txt_status.TabIndex = 538;
            // 
            // btn_CtItem
            // 
            this.btn_CtItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CtItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_CtItem.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_CtItem.ImageIndex = 0;
            this.btn_CtItem.ImageList = this.img_Button;
            this.btn_CtItem.Location = new System.Drawing.Point(908, 130);
            this.btn_CtItem.Name = "btn_CtItem";
            this.btn_CtItem.Size = new System.Drawing.Size(80, 23);
            this.btn_CtItem.TabIndex = 403;
            this.btn_CtItem.Text = "Carton";
            this.btn_CtItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CtItem.Click += new System.EventHandler(this.btn_CtItem_Click);
            this.btn_CtItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_CtItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_sizeItem
            // 
            this.btn_sizeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sizeItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_sizeItem.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_sizeItem.ImageIndex = 0;
            this.btn_sizeItem.ImageList = this.img_Button;
            this.btn_sizeItem.Location = new System.Drawing.Point(827, 130);
            this.btn_sizeItem.Name = "btn_sizeItem";
            this.btn_sizeItem.Size = new System.Drawing.Size(80, 23);
            this.btn_sizeItem.TabIndex = 402;
            this.btn_sizeItem.Text = "Size Item";
            this.btn_sizeItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sizeItem.Click += new System.EventHandler(this.btn_sizeItem_Click);
            this.btn_sizeItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_sizeItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // txt_mrpShipNo
            // 
            this.txt_mrpShipNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mrpShipNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mrpShipNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_mrpShipNo.Location = new System.Drawing.Point(109, 106);
            this.txt_mrpShipNo.MaxLength = 500;
            this.txt_mrpShipNo.Name = "txt_mrpShipNo";
            this.txt_mrpShipNo.ReadOnly = true;
            this.txt_mrpShipNo.Size = new System.Drawing.Size(220, 21);
            this.txt_mrpShipNo.TabIndex = 400;
            // 
            // cmb_purDiv
            // 
            this.cmb_purDiv.AddItemCols = 0;
            this.cmb_purDiv.AddItemSeparator = ';';
            this.cmb_purDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purDiv.Caption = "";
            this.cmb_purDiv.CaptionHeight = 17;
            this.cmb_purDiv.CaptionStyle = style1;
            this.cmb_purDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_purDiv.ColumnCaptionHeight = 18;
            this.cmb_purDiv.ColumnFooterHeight = 18;
            this.cmb_purDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_purDiv.ContentHeight = 16;
            this.cmb_purDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_purDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_purDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_purDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_purDiv.EditorHeight = 16;
            this.cmb_purDiv.EvenRowStyle = style2;
            this.cmb_purDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purDiv.FooterStyle = style3;
            this.cmb_purDiv.GapHeight = 2;
            this.cmb_purDiv.HeadingStyle = style4;
            this.cmb_purDiv.HighLightRowStyle = style5;
            this.cmb_purDiv.ItemHeight = 15;
            this.cmb_purDiv.Location = new System.Drawing.Point(438, 62);
            this.cmb_purDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_purDiv.MaxDropDownItems = ((short)(5));
            this.cmb_purDiv.MaxLength = 32767;
            this.cmb_purDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purDiv.Name = "cmb_purDiv";
            this.cmb_purDiv.OddRowStyle = style6;
            this.cmb_purDiv.PartialRightColumn = false;
            this.cmb_purDiv.PropBag = resources.GetString("cmb_purDiv.PropBag");
            this.cmb_purDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.SelectedStyle = style7;
            this.cmb_purDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_purDiv.Style = style8;
            this.cmb_purDiv.TabIndex = 397;
            // 
            // cmb_purUser
            // 
            this.cmb_purUser.AddItemCols = 0;
            this.cmb_purUser.AddItemSeparator = ';';
            this.cmb_purUser.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purUser.Caption = "";
            this.cmb_purUser.CaptionHeight = 17;
            this.cmb_purUser.CaptionStyle = style9;
            this.cmb_purUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_purUser.ColumnCaptionHeight = 18;
            this.cmb_purUser.ColumnFooterHeight = 18;
            this.cmb_purUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_purUser.ContentHeight = 16;
            this.cmb_purUser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_purUser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_purUser.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_purUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_purUser.EditorHeight = 16;
            this.cmb_purUser.EvenRowStyle = style10;
            this.cmb_purUser.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purUser.FooterStyle = style11;
            this.cmb_purUser.GapHeight = 2;
            this.cmb_purUser.HeadingStyle = style12;
            this.cmb_purUser.HighLightRowStyle = style13;
            this.cmb_purUser.ItemHeight = 15;
            this.cmb_purUser.Location = new System.Drawing.Point(109, 84);
            this.cmb_purUser.MatchEntryTimeout = ((long)(2000));
            this.cmb_purUser.MaxDropDownItems = ((short)(5));
            this.cmb_purUser.MaxLength = 32767;
            this.cmb_purUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purUser.Name = "cmb_purUser";
            this.cmb_purUser.OddRowStyle = style14;
            this.cmb_purUser.PartialRightColumn = false;
            this.cmb_purUser.PropBag = resources.GetString("cmb_purUser.PropBag");
            this.cmb_purUser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purUser.SelectedStyle = style15;
            this.cmb_purUser.Size = new System.Drawing.Size(220, 20);
            this.cmb_purUser.Style = style16;
            this.cmb_purUser.TabIndex = 395;
            this.cmb_purUser.SelectedValueChanged += new System.EventHandler(this.cmb_purUser_SelectedValueChanged);
            // 
            // cmb_buyDiv
            // 
            this.cmb_buyDiv.AddItemCols = 0;
            this.cmb_buyDiv.AddItemSeparator = ';';
            this.cmb_buyDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_buyDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_buyDiv.Caption = "";
            this.cmb_buyDiv.CaptionHeight = 17;
            this.cmb_buyDiv.CaptionStyle = style17;
            this.cmb_buyDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_buyDiv.ColumnCaptionHeight = 18;
            this.cmb_buyDiv.ColumnFooterHeight = 18;
            this.cmb_buyDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_buyDiv.ContentHeight = 16;
            this.cmb_buyDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_buyDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_buyDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_buyDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_buyDiv.EditorHeight = 16;
            this.cmb_buyDiv.EvenRowStyle = style18;
            this.cmb_buyDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_buyDiv.FooterStyle = style19;
            this.cmb_buyDiv.GapHeight = 2;
            this.cmb_buyDiv.HeadingStyle = style20;
            this.cmb_buyDiv.HighLightRowStyle = style21;
            this.cmb_buyDiv.ItemHeight = 15;
            this.cmb_buyDiv.Location = new System.Drawing.Point(767, 62);
            this.cmb_buyDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_buyDiv.MaxDropDownItems = ((short)(5));
            this.cmb_buyDiv.MaxLength = 32767;
            this.cmb_buyDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_buyDiv.Name = "cmb_buyDiv";
            this.cmb_buyDiv.OddRowStyle = style22;
            this.cmb_buyDiv.PartialRightColumn = false;
            this.cmb_buyDiv.PropBag = resources.GetString("cmb_buyDiv.PropBag");
            this.cmb_buyDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_buyDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.SelectedStyle = style23;
            this.cmb_buyDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_buyDiv.Style = style24;
            this.cmb_buyDiv.TabIndex = 394;
            // 
            // dpick_etsYmd
            // 
            this.dpick_etsYmd.CustomFormat = "";
            this.dpick_etsYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_etsYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_etsYmd.Location = new System.Drawing.Point(767, 84);
            this.dpick_etsYmd.Name = "dpick_etsYmd";
            this.dpick_etsYmd.Size = new System.Drawing.Size(222, 21);
            this.dpick_etsYmd.TabIndex = 389;
            // 
            // dpick_rtaYmd
            // 
            this.dpick_rtaYmd.CustomFormat = "";
            this.dpick_rtaYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_rtaYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_rtaYmd.Location = new System.Drawing.Point(438, 84);
            this.dpick_rtaYmd.Name = "dpick_rtaYmd";
            this.dpick_rtaYmd.Size = new System.Drawing.Size(222, 21);
            this.dpick_rtaYmd.TabIndex = 388;
            // 
            // lbl_rate
            // 
            this.lbl_rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_rate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rate.ImageIndex = 0;
            this.lbl_rate.ImageList = this.img_Label;
            this.lbl_rate.Location = new System.Drawing.Point(337, 106);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(100, 21);
            this.lbl_rate.TabIndex = 386;
            this.lbl_rate.Text = "Exchange Rate";
            this.lbl_rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_purStatus
            // 
            this.lbl_purStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purStatus.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purStatus.ImageIndex = 0;
            this.lbl_purStatus.ImageList = this.img_Label;
            this.lbl_purStatus.Location = new System.Drawing.Point(666, 40);
            this.lbl_purStatus.Name = "lbl_purStatus";
            this.lbl_purStatus.Size = new System.Drawing.Size(100, 21);
            this.lbl_purStatus.TabIndex = 382;
            this.lbl_purStatus.Text = "Status";
            this.lbl_purStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_mrpShipNo
            // 
            this.lbl_mrpShipNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_mrpShipNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mrpShipNo.ImageIndex = 0;
            this.lbl_mrpShipNo.ImageList = this.img_Label;
            this.lbl_mrpShipNo.Location = new System.Drawing.Point(8, 106);
            this.lbl_mrpShipNo.Name = "lbl_mrpShipNo";
            this.lbl_mrpShipNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_mrpShipNo.TabIndex = 381;
            this.lbl_mrpShipNo.Text = "MRP Ship No";
            this.lbl_mrpShipNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_buyDiv
            // 
            this.lbl_buyDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buyDiv.ImageIndex = 0;
            this.lbl_buyDiv.ImageList = this.img_Label;
            this.lbl_buyDiv.Location = new System.Drawing.Point(666, 62);
            this.lbl_buyDiv.Name = "lbl_buyDiv";
            this.lbl_buyDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_buyDiv.TabIndex = 378;
            this.lbl_buyDiv.Text = "Buy Division";
            this.lbl_buyDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_etsYmd
            // 
            this.lbl_etsYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_etsYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etsYmd.ImageIndex = 0;
            this.lbl_etsYmd.ImageList = this.img_Label;
            this.lbl_etsYmd.Location = new System.Drawing.Point(666, 84);
            this.lbl_etsYmd.Name = "lbl_etsYmd";
            this.lbl_etsYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_etsYmd.TabIndex = 377;
            this.lbl_etsYmd.Text = "Shipping Date";
            this.lbl_etsYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_purDiv
            // 
            this.lbl_purDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purDiv.ImageIndex = 0;
            this.lbl_purDiv.ImageList = this.img_Label;
            this.lbl_purDiv.Location = new System.Drawing.Point(337, 62);
            this.lbl_purDiv.Name = "lbl_purDiv";
            this.lbl_purDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_purDiv.TabIndex = 376;
            this.lbl_purDiv.Text = "Pur Division";
            this.lbl_purDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_rtaYmd
            // 
            this.lbl_rtaYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_rtaYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rtaYmd.ImageIndex = 0;
            this.lbl_rtaYmd.ImageList = this.img_Label;
            this.lbl_rtaYmd.Location = new System.Drawing.Point(337, 84);
            this.lbl_rtaYmd.Name = "lbl_rtaYmd";
            this.lbl_rtaYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_rtaYmd.TabIndex = 375;
            this.lbl_rtaYmd.Text = "RTA Date";
            this.lbl_rtaYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_purYmd
            // 
            this.dpick_purYmd.CustomFormat = "";
            this.dpick_purYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_purYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_purYmd.Location = new System.Drawing.Point(109, 62);
            this.dpick_purYmd.Name = "dpick_purYmd";
            this.dpick_purYmd.Size = new System.Drawing.Size(222, 21);
            this.dpick_purYmd.TabIndex = 5;
            this.dpick_purYmd.CloseUp += new System.EventHandler(this.dpick_purYmd_CloseUp);
            // 
            // btn_searchPur
            // 
            this.btn_searchPur.ImageIndex = 27;
            this.btn_searchPur.ImageList = this.img_SmallButton;
            this.btn_searchPur.Location = new System.Drawing.Point(636, 40);
            this.btn_searchPur.Name = "btn_searchPur";
            this.btn_searchPur.Size = new System.Drawing.Size(24, 21);
            this.btn_searchPur.TabIndex = 374;
            this.btn_searchPur.Tag = "Search";
            this.btn_searchPur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_searchPur.Click += new System.EventHandler(this.btn_searchPur_Click);
            this.btn_searchPur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_searchPur_MouseDown);
            this.btn_searchPur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_searchPur_MouseUp);
            // 
            // cmb_purNo
            // 
            this.cmb_purNo.AddItemCols = 0;
            this.cmb_purNo.AddItemSeparator = ';';
            this.cmb_purNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purNo.Caption = "";
            this.cmb_purNo.CaptionHeight = 17;
            this.cmb_purNo.CaptionStyle = style25;
            this.cmb_purNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_purNo.ColumnCaptionHeight = 18;
            this.cmb_purNo.ColumnFooterHeight = 18;
            this.cmb_purNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_purNo.ContentHeight = 16;
            this.cmb_purNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_purNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_purNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_purNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_purNo.EditorHeight = 16;
            this.cmb_purNo.EvenRowStyle = style26;
            this.cmb_purNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purNo.FooterStyle = style27;
            this.cmb_purNo.GapHeight = 2;
            this.cmb_purNo.HeadingStyle = style28;
            this.cmb_purNo.HighLightRowStyle = style29;
            this.cmb_purNo.ItemHeight = 15;
            this.cmb_purNo.Location = new System.Drawing.Point(438, 40);
            this.cmb_purNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_purNo.MaxDropDownItems = ((short)(5));
            this.cmb_purNo.MaxLength = 32767;
            this.cmb_purNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purNo.Name = "cmb_purNo";
            this.cmb_purNo.OddRowStyle = style30;
            this.cmb_purNo.PartialRightColumn = false;
            this.cmb_purNo.PropBag = resources.GetString("cmb_purNo.PropBag");
            this.cmb_purNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purNo.SelectedStyle = style31;
            this.cmb_purNo.Size = new System.Drawing.Size(198, 20);
            this.cmb_purNo.Style = style32;
            this.cmb_purNo.TabIndex = 7;
            // 
            // lbl_purNo
            // 
            this.lbl_purNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purNo.ImageIndex = 1;
            this.lbl_purNo.ImageList = this.img_Label;
            this.lbl_purNo.Location = new System.Drawing.Point(337, 40);
            this.lbl_purNo.Name = "lbl_purNo";
            this.lbl_purNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_purNo.TabIndex = 366;
            this.lbl_purNo.Text = "Purchase No";
            this.lbl_purNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style33;
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
            this.cmb_factory.EvenRowStyle = style34;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style35;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style36;
            this.cmb_factory.HighLightRowStyle = style37;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style38;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style39;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style40;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // txt_remarks
            // 
            this.txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remarks.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_remarks.Location = new System.Drawing.Point(767, 106);
            this.txt_remarks.MaxLength = 500;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(220, 21);
            this.txt_remarks.TabIndex = 11;
            // 
            // lbl_purUser
            // 
            this.lbl_purUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purUser.ImageIndex = 0;
            this.lbl_purUser.ImageList = this.img_Label;
            this.lbl_purUser.Location = new System.Drawing.Point(8, 84);
            this.lbl_purUser.Name = "lbl_purUser";
            this.lbl_purUser.Size = new System.Drawing.Size(100, 21);
            this.lbl_purUser.TabIndex = 365;
            this.lbl_purUser.Text = "Purchase User";
            this.lbl_purUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 145);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_purYmd
            // 
            this.lbl_purYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purYmd.ImageIndex = 1;
            this.lbl_purYmd.ImageList = this.img_Label;
            this.lbl_purYmd.Location = new System.Drawing.Point(8, 62);
            this.lbl_purYmd.Name = "lbl_purYmd";
            this.lbl_purYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_purYmd.TabIndex = 50;
            this.lbl_purYmd.Text = "Purchase Date";
            this.lbl_purYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 144);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
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
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 120);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(984, 0);
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
            this.label2.Text = "      Purchase Order";
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
            this.pic_head1.Size = new System.Drawing.Size(960, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 145);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 134);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pnl_low
            // 
            this.pnl_low.BackColor = System.Drawing.Color.Transparent;
            this.pnl_low.Controls.Add(this.btn_Tree);
            this.pnl_low.Controls.Add(this.btn_delete);
            this.pnl_low.Controls.Add(this.btn_recover);
            this.pnl_low.Controls.Add(this.btn_Insert);
            this.pnl_low.Location = new System.Drawing.Point(8, 548);
            this.pnl_low.Name = "pnl_low";
            this.pnl_low.Size = new System.Drawing.Size(1000, 28);
            this.pnl_low.TabIndex = 3;
            // 
            // btn_Tree
            // 
            this.btn_Tree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Tree.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tree.ImageIndex = 13;
            this.btn_Tree.ImageList = this.image_List;
            this.btn_Tree.Location = new System.Drawing.Point(674, 2);
            this.btn_Tree.Name = "btn_Tree";
            this.btn_Tree.Size = new System.Drawing.Size(80, 24);
            this.btn_Tree.TabIndex = 364;
            this.btn_Tree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Tree.Click += new System.EventHandler(this.btn_Tree_Click);
            this.btn_Tree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_tree_MouseDown);
            this.btn_Tree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_tree_MouseUp);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_delete.ImageIndex = 5;
            this.btn_delete.ImageList = this.image_List;
            this.btn_delete.Location = new System.Drawing.Point(838, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 24);
            this.btn_delete.TabIndex = 363;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            this.btn_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseDown);
            this.btn_delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseUp);
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(920, 2);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 24);
            this.btn_recover.TabIndex = 353;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseDown);
            this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(756, 2);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 24);
            this.btn_Insert.TabIndex = 352;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseDown);
            this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseUp);
            // 
            // spd_size
            // 
            this.spd_size.Location = new System.Drawing.Point(8, 165);
            this.spd_size.Name = "spd_size";
            this.spd_size.Sheets.Add(this.spd_size_Sheet1);
            this.spd_size.Size = new System.Drawing.Size(1000, 60);
            this.spd_size.TabIndex = 2;
            // 
            // spd_size_Sheet1
            // 
            this.spd_size_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.White;
            this.pnl_main.Controls.Add(this.fgrid_main);
            this.pnl_main.Location = new System.Drawing.Point(8, 229);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1000, 315);
            this.pnl_main.TabIndex = 1;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(0, 0);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(1000, 315);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 0;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            this.fgrid_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyUp);
            // 
            // ctx_tail
            // 
            this.ctx_tail.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_AllSelect,
            this.mnu_Data,
            this.menuItem1,
            this.mnu_tvo,
            this.mnu_cbd,
            this.menuItem2,
            this.mnu_autoCalc,
            this.mnu_outside,
            this.mnu_exchange,
            this.menuItem9,
            this.mnu_CBDPrice,
            this.mnu_Packing,
            this.mnu_CBM,
            this.mnu_Weight,
            this.menuItem3,
            this.menuItem10});
            // 
            // mnu_AllSelect
            // 
            this.mnu_AllSelect.Index = 0;
            this.mnu_AllSelect.Text = "All Select";
            this.mnu_AllSelect.Click += new System.EventHandler(this.mnu_AllSelect_Click);
            // 
            // mnu_Data
            // 
            this.mnu_Data.Index = 1;
            this.mnu_Data.Text = "Value Change";
            this.mnu_Data.Click += new System.EventHandler(this.mnu_Data_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // mnu_tvo
            // 
            this.mnu_tvo.Index = 3;
            this.mnu_tvo.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_header,
            this.mnu_detaile});
            this.mnu_tvo.Text = "Tree View Option";
            // 
            // mnu_header
            // 
            this.mnu_header.Index = 0;
            this.mnu_header.Text = "Header";
            this.mnu_header.Click += new System.EventHandler(this.mnu_header_Click);
            // 
            // mnu_detaile
            // 
            this.mnu_detaile.Index = 1;
            this.mnu_detaile.Text = "Detaile";
            this.mnu_detaile.Click += new System.EventHandler(this.mnu_detaile_Click);
            // 
            // mnu_cbd
            // 
            this.mnu_cbd.Index = 4;
            this.mnu_cbd.Text = "CBD Information";
            this.mnu_cbd.Click += new System.EventHandler(this.mnu_Cbd_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 5;
            this.menuItem2.Text = "-";
            // 
            // mnu_autoCalc
            // 
            this.mnu_autoCalc.Index = 6;
            this.mnu_autoCalc.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5,
            this.menuItem6,
            this.menuItem7,
            this.menuItem8});
            this.mnu_autoCalc.Text = "Auto Calculation";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Celling";
            this.menuItem4.Click += new System.EventHandler(this.mnu_ceiling_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "Rounding";
            this.menuItem5.Click += new System.EventHandler(this.mnu_roundUp_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "Truncate";
            this.menuItem6.Click += new System.EventHandler(this.mnu_truncate_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.Text = "-";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 4;
            this.menuItem8.Text = "PK Unit Qty";
            this.menuItem8.Click += new System.EventHandler(this.mnu_pk_Click);
            // 
            // mnu_outside
            // 
            this.mnu_outside.Index = 7;
            this.mnu_outside.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_painting,
            this.mnu_printing,
            this.mnu_sticker,
            this.mnu_hot_melt,
            this.mnu_rub_lam,
            this.mnu_lam,
            this.mnu_peea_eva,
            this.mnu_sub,
            this.mnu_sub_insole});
            this.mnu_outside.Text = "Outside Information";
            // 
            // mnu_painting
            // 
            this.mnu_painting.Index = 0;
            this.mnu_painting.Text = "PAINTING";
            this.mnu_painting.Click += new System.EventHandler(this.mnu_outside_Click);
            // 
            // mnu_printing
            // 
            this.mnu_printing.Index = 1;
            this.mnu_printing.Text = "PRINTING";
            this.mnu_printing.Click += new System.EventHandler(this.mnu_outside_Click);
            // 
            // mnu_sticker
            // 
            this.mnu_sticker.Index = 2;
            this.mnu_sticker.Text = "STICKER";
            this.mnu_sticker.Click += new System.EventHandler(this.mnu_outside_Click);
            // 
            // mnu_hot_melt
            // 
            this.mnu_hot_melt.Index = 3;
            this.mnu_hot_melt.Text = "HOT MELT";
            this.mnu_hot_melt.Click += new System.EventHandler(this.mnu_outside_Click);
            // 
            // mnu_rub_lam
            // 
            this.mnu_rub_lam.Index = 4;
            this.mnu_rub_lam.Text = "RUBBER LAMINATION";
            this.mnu_rub_lam.Click += new System.EventHandler(this.mnu_outside_Click);
            // 
            // mnu_lam
            // 
            this.mnu_lam.Index = 5;
            this.mnu_lam.Text = "LAMINATION";
            this.mnu_lam.Click += new System.EventHandler(this.mnu_outside_Click);
            // 
            // mnu_peea_eva
            // 
            this.mnu_peea_eva.Index = 6;
            this.mnu_peea_eva.Text = "PEEA EVA";
            this.mnu_peea_eva.Click += new System.EventHandler(this.mnu_outside_Click);
            // 
            // mnu_sub
            // 
            this.mnu_sub.Index = 7;
            this.mnu_sub.Text = "SUBLIMATION";
            this.mnu_sub.Click += new System.EventHandler(this.mnu_outside_Click);
            // 
            // mnu_sub_insole
            // 
            this.mnu_sub_insole.Index = 8;
            this.mnu_sub_insole.Text = "SUBLIMATION INSOLE";
            this.mnu_sub_insole.Click += new System.EventHandler(this.mnu_outside_Click);
            // 
            // mnu_exchange
            // 
            this.mnu_exchange.Index = 8;
            this.mnu_exchange.Text = "Check Exchange Rate";
            this.mnu_exchange.Click += new System.EventHandler(this.mnu_exchange_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 9;
            this.menuItem9.Text = "-";
            // 
            // mnu_CBDPrice
            // 
            this.mnu_CBDPrice.Index = 10;
            this.mnu_CBDPrice.Text = "CBD Price";
            this.mnu_CBDPrice.Click += new System.EventHandler(this.mnu_CBDPrice_Click);
            // 
            // mnu_Packing
            // 
            this.mnu_Packing.Index = 11;
            this.mnu_Packing.Text = "Packing";
            this.mnu_Packing.Click += new System.EventHandler(this.mnu_Packing_Click);
            // 
            // mnu_CBM
            // 
            this.mnu_CBM.Index = 12;
            this.mnu_CBM.Text = "CBM";
            this.mnu_CBM.Click += new System.EventHandler(this.mnu_CBM_Click);
            // 
            // mnu_Weight
            // 
            this.mnu_Weight.Index = 13;
            this.mnu_Weight.Text = "Weight";
            this.mnu_Weight.Click += new System.EventHandler(this.mnu_Weight_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 14;
            this.menuItem3.Text = "-";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 15;
            this.menuItem10.Text = "Deduction Rate";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // Form_BP_Purchase_Order
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BP_Purchase_Order";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BP_Purchase_Order_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            this.pnl_low.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_size_Sheet1)).EndInit();
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
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
			/*
			if (_level1.Contains(fgrid_main.Col) && fgrid_main.Rows[fgrid_main.Row].Node.Level == 2)
			{
				e.Cancel = true;
			}

			if (e.Col == _weightCol)
			{
				if (!(ClassLib.ComFunction.NullToBlank(fgrid_main[e.Row, e.Col]).Equals("") || 
					ClassLib.ComFunction.NullToBlank(fgrid_main[e.Row, e.Col]).Equals("0")))
				{
					e.Cancel = true;
				}
			}
			*/

			this.Grid_BeforeEditProcess();
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (Etc_ProvisoValidateCheck(_validate_context))
				{
					ctx_tail.Show(fgrid_main, new Point(e.X, e.Y));
				}
			}
		}

		private void fgrid_main_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
		}

		#endregion

		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
			LockProgram = false;
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
				this.Tbtn_SearchProcess(true);
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
					this.Tbtn_SaveProcess();
			}
		}	
		
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Delete))
			{
				if (ClassLib.ComFunction.User_Message("Do you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.Tbtn_DeleteProcess();
			}
		}

        Thread vConfirmThread = null;

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
			{
				if(ClassLib.ComFunction.User_Message("Do you want to confirm?","Confirm", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
				{
                    //Thread vConfirmThread = new Thread(new ThreadStart(Tbtn_ConfirmProcess)); 
                    //vConfirmThread.IsBackground = true; 
                    //vConfirmThread.Start(); 

                    //_waitPop = new Pop_BP_Purchase_Wait();
                    //_waitPop.Start();

                    _waitPop = new Pop_BP_Purchase_Wait();
                    //_waitPop.Start();

                    vConfirmThread = new Thread(new ThreadStart(_waitPop.Start));
                    vConfirmThread.IsBackground = true;
                    vConfirmThread.Start();

                    Tbtn_ConfirmProcess();
                    ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
			}
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			// 기본체크만 함.
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
			{

				DataTable temp_datatable= new DataTable("Combo List");  
				DataRow newrow; 

				string BeforeVendor = "";
				try 
				{
				
					temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
					temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

					for (int vRow = 4 ; vRow < fgrid_main.Rows.Count ; vRow++)
					{

						string NowVendor =fgrid_main.GetCellRange(vRow, _custCdCol).Data.ToString();

						int count = 0;
						for (int j = 0; j < temp_datatable.Rows.Count; j++)
						{
							BeforeVendor = temp_datatable.Rows[j].ItemArray[0].ToString();					
							if (NowVendor == BeforeVendor ) 
							{
									count++;
							}
						} 

						if (count == 0 ) 
						{   	
							newrow = temp_datatable.NewRow();
							newrow["Code"] = fgrid_main.GetCellRange(vRow, _custCdCol).Data.ToString();
							newrow["Name"] = fgrid_main.GetCellRange(vRow, _custNmCol).Data.ToString();
							temp_datatable.Rows.Add(newrow);   
						}

						//BeforeVendor = NowVendor;
					}
				}
				catch
				{
					//MessageBox.Show(ex.Message.ToString(),"Set_ComboList",MessageBoxButtons.OK,MessageBoxIcon.Error );
				}
				Pop_BP_Print_Type vPop = new Pop_BP_Print_Type(temp_datatable);
				vPop.ShowDialog();

				if (vPop.DialogResult == DialogResult.OK)
				{
					if (ClassLib.ComVar.Parameter_PopUp[0].Equals("1"))
					{
						Tbtn_Print_Vendor_old();
					}
					else if (ClassLib.ComVar.Parameter_PopUp[0].Equals("2"))
					{
						Tbtn_Print_Vendor_new();
					}
					else if (ClassLib.ComVar.Parameter_PopUp[0].Equals("3"))
					{
						Tbtn_Print_Vendor_total();
					}
					else if (ClassLib.ComVar.Parameter_PopUp[0].Equals("4"))
					{
						Tbtn_Print_Vendor_tail();
					}
                    else if (ClassLib.ComVar.Parameter_PopUp[0].Equals("5"))
                    {
                        Tbtn_Print_Vendor_JJ();
                    }
					 

				}

				/*
				if (MessageBox.Show(this, "Print By Purchase No?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					Tbtn_Print_Vendor_old();
				else
					Tbtn_Print_Vendor_new();
				*/
			}
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

		private void Form_BP_Purchase_Order_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				string vCheck = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip;
				if(vCheck.IndexOf("I") > 0 || vCheck.IndexOf("U") > 0 || vCheck.IndexOf("D") > 0)
				{
					if(MessageBox.Show(this, "Exist Modify Data, Do you want to close?","Close", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.No )
						e.Cancel = true;
				}
			}
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if( !_firstLoad )
				ClearNotPk();

			this.Cmb_PurNoSettingProcess();
		}

		private void cmb_purNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if( !_firstLoad )
			{
				this.Cmb_PurNoSelectedValueChangedProcess();
			}
		}

		private void cmb_purUser_SelectedValueChanged(object sender, System.EventArgs e)
		{
			//if( !_firstLoad )
			//	ClearNotPk();

			_doSearch = false;
			this.Cmb_PurNoSettingProcess();
			fgrid_main.ClearAll();
			_doSearch = true;
		}

		private void dpick_purYmd_CloseUp(object sender, System.EventArgs e)
		{
			if( !_firstLoad )
				ClearNotPk();

			this.Cmb_PurNoSettingProcess();
		}

		private void cmb_purDiv_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_PurNoSettingProcess();	
		}

		private void btn_searchPur_Click(object sender, System.EventArgs e)
		{
			this.Btn_SearchPurClickProcess();
		}

		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			this.fgrid_main.Recover_Row();
		}

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
			Show_Item_Popup();
		}

		private void btn_Tree_Click(object sender, System.EventArgs e)
		{
			Pop_BP_Purchase_Order_SearchType sPop = new Pop_BP_Purchase_Order_SearchType();
			if (sPop.ShowDialog() == DialogResult.OK)
			{
				if (COM.ComVar.Parameter_PopUp[0].Equals("01"))
				{
					if (Etc_ProvisoValidateCheck(10))
					{
						string vTemp = _sizeSheet.Cells[0, 2].Text.Equals("") ? "0" : _sizeSheet.Cells[0, 2].Text;

						if( Convert.ToInt32(vTemp.Replace(",", "")) <= 0 )
						{
							ClassLib.ComFunction.User_Message("Input Size Data", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
						else
						{
							Show_Tree_Popup();
						}
					}
				}
				else
				{
					Show_LLT_Item_Popup();
				}
			}
		}

		private void btn_size_Click(object sender, System.EventArgs e)
		{
			Pop_BP_Request_Size vPop = new Pop_BP_Request_Size();
			ClassLib.ComVar.Parameter_PopUp = new string[]{COM.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory)};

			if (vPop.ShowDialog() == DialogResult.OK)
			{
				int i = 0;

				for ( ; i < ClassLib.ComVar.Parameter_PopUp.Length - 4 ; i++)
				{
					_sizeSheet.Cells[0, i + _sizeSheet.FrozenColumnCount].Text = ClassLib.ComVar.Parameter_PopUp[i];
				}

				_obsType = ClassLib.ComVar.Parameter_PopUp[i];
			}
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			this.Btn_DeleteProcess();
		}
		

		private void btn_CFM_Cancel_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
			{
				if(ClassLib.ComFunction.User_Message("Do you want to confirm Cancel ?","Confirm", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
				{
					this.Tbtn_CancelProcess();
				}
			}
		}

		
		private void Tbtn_CancelProcess()
		{
			
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string _PurNo = ClassLib.ComFunction.Empty_Combo(cmb_purNo, "");

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




		#region 컨텍스트 메뉴

		private void mnu_AllSelect_Click(object sender, System.EventArgs e)
		{
			fgrid_main.SelectAll();
		}

		private void mnu_Data_Click(object sender, System.EventArgs e)
		{	
			_controlLevel = 0;
			this.Grid_CellClickProcess();
		}

		private void mnu_header_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(1);
		}

		private void mnu_detaile_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(2);
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

		private void mnu_outside_Click(object sender, System.EventArgs e)
		{
			try
			{
				int vRow = fgrid_main.Row;
				
				ClassLib.ComVar.Parameter_PopUp = new string[11];
				ClassLib.ComVar.Parameter_PopUp[0] = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
				ClassLib.ComVar.Parameter_PopUp[1] = ClassLib.ComFunction.Empty_Combo(cmb_purNo, "");
				if (fgrid_main.Rows[vRow].Node.Level == 1)
					ClassLib.ComVar.Parameter_PopUp[2] = "";
				else
					ClassLib.ComVar.Parameter_PopUp[2] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _styleCdCol]).Replace("-", "");
				ClassLib.ComVar.Parameter_PopUp[3] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _itemCdCol]);
				ClassLib.ComVar.Parameter_PopUp[4] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _specCdCol]);
				ClassLib.ComVar.Parameter_PopUp[5] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _colorCdCol]);

				Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.FirstChild);

				// 추가 파라미터
				ClassLib.ComVar.Parameter_PopUp[8] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _obsIdCol]);
				ClassLib.ComVar.Parameter_PopUp[9] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _purPriceCol]);
				ClassLib.ComVar.Parameter_PopUp[10] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _purCurrencyCol]);

				if (vNode == null)
				{
					vRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
				}

				ClassLib.ComVar.Parameter_PopUp[6] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _itemNameCol]);
				ClassLib.ComVar.Parameter_PopUp[7] = ((MenuItem)sender).Index.ToString();

				Pop_BP_Outside_Calc vPop = new Pop_BP_Outside_Calc(fgrid_main);
				vPop.ShowDialog(this);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		private void mnu_CBDPrice_Click(object sender, System.EventArgs e)
		{
			_controlLevel = 1;
			this.Grid_CellClickProcess();
		}
		private void mnu_Packing_Click(object sender, System.EventArgs e)
		{
			_controlLevel = 2;
			this.Grid_CellClickProcess();
		}

		private void mnu_CBM_Click(object sender, System.EventArgs e)
		{
			_controlLevel = 3;
			this.Grid_CellClickProcess();
		}

		private void mnu_Weight_Click(object sender, System.EventArgs e)
		{
			_controlLevel = 4;
			this.Grid_CellClickProcess();
		}

		private void mnu_exchange_Click(object sender, System.EventArgs e)
		{
            checkExchangeRate();
		}

		#endregion

		#region 입력이동

		private void cmb_factory_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
//			if (e.KeyChar == 13)
//				dpick_shipYmd.Focus();
		}

		private void dpick_shipYmd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_devision_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
//			if (e.KeyChar == 13)
//				cmb_size.Focus();
		}

		private void cmb_size_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				Tbtn_SearchProcess(true);
		}

		#region 입력이동

		private void Control_MoveNextByFocus(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
		}

		#endregion

		#endregion

		#region 버튼효과

		private void btn_searchPur_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_searchPur.ImageIndex = 26;
		}

		private void btn_searchPur_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_searchPur.ImageIndex = 27;
		}

		private void btn_insert_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 8;
		}

		private void btn_insert_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 9;
		}

		private void btn_delete_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 4;
		}

		private void btn_delete_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 5;
		}

		private void btn_cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		private void btn_cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_tree_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 12;
		}

		private void btn_tree_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 13;
		}
		#endregion

		#endregion

		#region 공통 메서드

		private void SetHeadInfo(DataTable arg_dt)
		{
			this.cmb_purNo.SelectedValueChanged -= _cmbPurNoEventHandler;

			txt_status.Text				= arg_dt.Rows[0][9].ToString();
			cmb_purUser.SelectedValue	= arg_dt.Rows[0][3];
			cmb_purDiv.SelectedValue	= arg_dt.Rows[0][6];
			cmb_buyDiv.SelectedValue	= arg_dt.Rows[0][7];
			dpick_rtaYmd.Value			= ClassLib.ComFunction.StringToDateTime(arg_dt.Rows[0].ItemArray[4].ToString());
			dpick_etsYmd.Value			= ClassLib.ComFunction.StringToDateTime(arg_dt.Rows[0].ItemArray[5].ToString());
			txt_mrpShipNo.Text			= arg_dt.Rows[0][8].ToString();
			txt_rate.Text				= arg_dt.Rows[0][11].ToString();
			txt_remarks.Text			= arg_dt.Rows[0].ItemArray[10].ToString();

			this.cmb_purNo.SelectedValueChanged += _cmbPurNoEventHandler;
		}

		private void ClearNotPkInfo()
		{
			this.cmb_purNo.SelectedValueChanged -= _cmbPurNoEventHandler;

			txt_status.Text					= "";
			cmb_purDiv.SelectedIndex		= 0;
			cmb_buyDiv.SelectedIndex		= 0;
			dpick_etsYmd.Value				= System.DateTime.Now;
			dpick_rtaYmd.Value				= System.DateTime.Now;
			txt_mrpShipNo.Text				= "";
			txt_rate.Text					= "";
			txt_remarks.Text				= "";

			this.cmb_purNo.SelectedValueChanged += _cmbPurNoEventHandler;
		}

		private void ClearHeadInfo()
		{
			this.cmb_purNo.SelectedValueChanged -= _cmbPurNoEventHandler;

			cmb_factory.SelectedValue		= COM.ComVar.This_Factory;
			cmb_purUser.SelectedValue		= COM.ComVar.This_User;
			dpick_purYmd.Value				= DateTime.Now;
			txt_status.Text					= "";
			cmb_purDiv.SelectedIndex		= 0;
			cmb_buyDiv.SelectedIndex		= 0;
			dpick_etsYmd.Value				= DateTime.Now;
			dpick_rtaYmd.Value				= DateTime.Now;
			txt_mrpShipNo.Text				= "";
			txt_remarks.Text				= "";

			cmb_purNo.SelectedIndex			= -1;

			this.cmb_purNo.SelectedValueChanged += _cmbPurNoEventHandler;
		}

		private void ClearSizeInfo()
		{
			spd_size.ClearAll();
			spd_size.ActiveSheet.RowCount = 1;
			_sizeSheet.Cells[0, 2].Formula = "SUM(" + _sizeStartColumnLabel + "1:" + _sizeEndColumnLabel + "1)";
			_sizeSheet.Cells[0, 1, 0, 2].BackColor = ClassLib.ComVar.RightYellow;
		}

		private void SearchHeadInfo()
		{
			string vFactory = cmb_factory.SelectedValue.ToString();
			string vPurNo	= cmb_purNo.SelectedValue.ToString();
			string vPurDiv  = vPurNo.Substring(2, 2);

			DataTable vDt = SELECT_SBP_PURCHASE_HEAD();

			_doSearch = false;

			if (vDt.Rows.Count > 0 && vDt.Rows.Count < 2)
				this.SetHeadInfo(vDt);
			else
				this.ClearNotPk(); //.ClearHeadInfo();

			vDt.Dispose();
			_doSearch = true;
		}

		private void SearchTailInfo()
		{ 
			// factory, pur_no
			DataTable vDt = SELECT_SBP_PURCHASE_TAIL();
			
			if (vDt.Rows.Count > 0)
			{
				ClassLib.ComFunction.Display_FlexGrid_Tree(fgrid_main, vDt, 0);
				fgrid_main.Tree.Column = _itemNameCol;
				fgrid_main.Tree.Show(1);
				Grid_SetColor();
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			else
			{
				fgrid_main.ClearAll();
			}

			vDt.Dispose();			
		}

		private void Grid_SetColor()
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				// design setting
				switch (fgrid_main.Rows[vRow].Node.Level)
				{
					case 1:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						Grid_CheckPrice(fgrid_main.Rows[vRow].Node);
						break;
					case 2:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
						break;
				}
			}
		}

		private void Grid_CheckPrice(Node arg_node)
		{
			string purPrice = ClassLib.ComFunction.NullToBlank(fgrid_main[arg_node.Row.Index, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_PRICE]);
			string outsidePrice = ClassLib.ComFunction.NullToBlank(fgrid_main[arg_node.Row.Index, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_PRICE]);
			string cbdPrice = ClassLib.ComFunction.NullToBlank(fgrid_main[arg_node.Row.Index, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_PRICE]);

			string purCurr = ClassLib.ComFunction.NullToBlank(fgrid_main[arg_node.Row.Index, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_CURRENCY]);
			string outsideCurr = ClassLib.ComFunction.NullToBlank(fgrid_main[arg_node.Row.Index, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_CURRENCY]);
			string cbdCurr = ClassLib.ComFunction.NullToBlank(fgrid_main[arg_node.Row.Index, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_CURRENCY]);

			Node cNode = arg_node.GetNode(NodeTypeEnum.FirstChild);
			
			do
			{
				string cPurPrice = ClassLib.ComFunction.NullToBlank(fgrid_main[cNode.Row.Index, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_PRICE]);
				string cOutsidePrice = ClassLib.ComFunction.NullToBlank(fgrid_main[cNode.Row.Index, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_PRICE]);
				string cCbdPrice = ClassLib.ComFunction.NullToBlank(fgrid_main[cNode.Row.Index, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_PRICE]);

				string cPurCurr = ClassLib.ComFunction.NullToBlank(fgrid_main[cNode.Row.Index, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_CURRENCY]);
				string cOutsideCurr = ClassLib.ComFunction.NullToBlank(fgrid_main[cNode.Row.Index, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_CURRENCY]);
				string cCbdCurr = ClassLib.ComFunction.NullToBlank(fgrid_main[cNode.Row.Index, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_CURRENCY]);

				if (!purPrice.Equals(cPurPrice) || !outsidePrice.Equals(cOutsidePrice) || !cbdPrice.Equals(cCbdPrice))
				{
					arg_node.Row.StyleNew.ForeColor = Color.Red;
				}
				else if (!purCurr.Equals(cPurCurr) || !outsideCurr.Equals(cOutsideCurr) || !cbdCurr.Equals(cCbdCurr))
				{
					arg_node.Row.StyleNew.ForeColor = Color.Blue;
				}
			} while ((cNode = cNode.GetNode(NodeTypeEnum.NextSibling)) != null);
		}

		private void SearchSizeInfo()
		{
			bool vExistData   = false;

			DataTable vDt = SELECT_SBP_PURCHASE_SIZE();

			if (vDt.Rows.Count > 0)
			{
				Display_Spread_CrossTabByHead(vDt, 0, 1, 2);
				vDt.Dispose();

				// view point move
				for (int col = _startCol ; col < _sizeSheet.Columns.Count ; col++)
				{
					for (int row = 0 ; row < _sizeSheet.Rows.Count ; row++)
						if (!_sizeSheet.Cells[row, col].Text.Equals(""))
							vExistData = true;
				
					if (vExistData)
					{
						spd_size.ShowColumn(0, col, FarPoint.Win.Spread.HorizontalPosition.Left);
						break;
					}
				}

				_sizeSheet.Cells[0, 2].Formula = "SUM(" + _sizeStartColumnLabel + "1:" + _sizeEndColumnLabel + "1)";
			}
		}

		// display size
		private void Display_Spread_CrossTabByHead(DataTable arg_dt, int arg_titleIndex, int arg_headIndex, int arg_dataIndex)
		{
			try
			{
				int vStartCol = _sizeSheet.FrozenColumnCount;
				int vEndCol = _sizeSheet.Columns.Count;
				int vRow = 0;
				int vCol = 0;
				string vHead = "";
				string vData = "";
				string vColumnData = "";

				spd_size.ClearAll();
				_sizeSheet.Rows.Count = 1;

				for (int i = vStartCol ; i < vEndCol ; i++)
				{
					if (i < 10)
						vColumnData += "0";

					vColumnData += i + "[" + _sizeSheet.ColumnHeader.Cells[0, i].Text + "]";
				}

				if (vColumnData.Equals(""))
					new Exception("Not Found Column Label Data");

				for (int vCount = 0 ; vCount < arg_dt.Rows.Count ; vCount++)
				{
					vHead = "[" + arg_dt.Rows[vCount].ItemArray[arg_headIndex].ToString() + "]";
					vData = arg_dt.Rows[vCount].ItemArray[arg_dataIndex].ToString();
					
					vCol = Convert.ToInt32(vColumnData.Substring(vColumnData.IndexOf(vHead) - 2, 2));
					_sizeSheet.Cells[vRow, vCol].Text = vData;

					_sizeSheet.Cells[vRow, 1].Text = arg_dt.Rows[vCount].ItemArray[arg_titleIndex].ToString();
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Diplay_CrossTabByHead");
			}
		}

		#region 자재 추가

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
					txt_status.Text = "SAVE";
					LockProgram = false;

					string vKey = ClassLib.ComVar.Parameter_PopUp[0] + "\t" + 
						ClassLib.ComVar.Parameter_PopUp[2] + "\t" + 
						ClassLib.ComVar.Parameter_PopUp[4];

					int vRow = GetItemRow(vKey);
					int vEnd = fgrid_main.Rows.Count;

					if (vRow == fgrid_main.Rows.Count)
					{
						// Level 1
						C1.Win.C1FlexGrid.Node vNewRow					= fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, 1);
						fgrid_main[vNewRow.Row.Index, _itemNameCol]		= ClassLib.ComVar.Parameter_PopUp[1];
						fgrid_main[vNewRow.Row.Index, _specNameCol]		= ClassLib.ComVar.Parameter_PopUp[3];
						fgrid_main[vNewRow.Row.Index, _colorNameCol]	= ClassLib.ComVar.Parameter_PopUp[5];
						fgrid_main[vNewRow.Row.Index, _itemCdCol]		= ClassLib.ComVar.Parameter_PopUp[0];
						fgrid_main[vNewRow.Row.Index, _specCdCol]		= ClassLib.ComVar.Parameter_PopUp[2];
						fgrid_main[vNewRow.Row.Index, _colorCdCol]		= ClassLib.ComVar.Parameter_PopUp[4];
						fgrid_main.Rows[vNewRow.Row.Index].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						fgrid_main.Rows[vNewRow.Row.Index].Node.EnsureVisible();
					}
					else	// 동일 스타일이 존재하는지 검사
					{
						Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.NextSibling);
                        vEnd = (vNode == null) ? fgrid_main.Rows.Count : vNode.Row.Index;

						for (int i = vRow + 1 ; i < vEnd ; i++)
						{
							if (fgrid_main[i, _styleCdCol].ToString().Equals("_________"))
							{
								fgrid_main.Select(vRow, 0, vRow, fgrid_main.Cols.Count - 1);
								ClassLib.ComFunction.User_Message("Exist Duplicate Item", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return;
							}
						}
					}

					// Level 2
					C1.Win.C1FlexGrid.Node vNewRow2					= fgrid_main.Rows.InsertNode(++vRow, 2);
					fgrid_main[vNewRow2.Row.Index, _factoryCol]		= cmb_factory.SelectedValue;
					fgrid_main[vNewRow2.Row.Index, _itemCdCol]		= ClassLib.ComVar.Parameter_PopUp[0];
					fgrid_main[vNewRow2.Row.Index, _itemNameCol]	= "_________";
					fgrid_main[vNewRow2.Row.Index, _specCdCol]		= ClassLib.ComVar.Parameter_PopUp[2];
					fgrid_main[vNewRow2.Row.Index, _specNameCol]	= "NONE";
					fgrid_main[vNewRow2.Row.Index, _colorCdCol]		= ClassLib.ComVar.Parameter_PopUp[4];
					fgrid_main[vNewRow2.Row.Index, _colorNameCol]	= "NONE-00";
					fgrid_main[vNewRow2.Row.Index, _unitCol]		= ClassLib.ComVar.Parameter_PopUp[6];
					fgrid_main[vNewRow2.Row.Index, _purQtyCol]		= 0;
					fgrid_main[vNewRow2.Row.Index, _purNoCol]		= COM.ComFunction.Empty_Combo(cmb_purNo, "");
					fgrid_main[vNewRow2.Row.Index, _purSeqCol]		= GetMaxSeq();
					fgrid_main[vNewRow2.Row.Index, _obsIdCol]		= "NONE";
					fgrid_main[vNewRow2.Row.Index, _obsIdCol + 1]	= "FT";
					fgrid_main[vNewRow2.Row.Index, _purStatusCol]	= "SAVE";
					fgrid_main[vNewRow2.Row.Index, 0]				= ClassLib.ComVar.Insert;
					fgrid_main.Rows[vNewRow2.Row.Index].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
					fgrid_main.Rows[vNewRow2.Row.Index].Node.EnsureVisible();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Show_Tree_Popup : 데이터 입력하는 팝업을 Tree로 실행
		/// </summary>
		private void Show_Tree_Popup()
		{
			try
			{
				int[] vChecks = new int[]{_styleCdCol, _itemCdCol, _specCdCol, _colorCdCol};
				ClassLib.ComVar.Parameter_PopUp = new string[]{COM.ComFunction.Empty_Combo(cmb_factory, COM.ComVar.This_Factory), "P"};
				Pop_BC_Yield_Info vPop = new Pop_BC_Yield_Info(fgrid_main, vChecks);
				vPop.ShowDialog();

				if ( ClassLib.ComVar.Parameter_PopUpTable.Rows.Count > 0 && vPop.DialogResult == DialogResult.OK)
					Etc_SizeCalculation();
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
				bool vBoolSize = SAVE_SBT_TEMP_SIZE();

				// pop_up 의 내용을 SBT_TEMP_ITEM 에 저장
				bool vBoolTemp = SAVE_SBT_TEMP_ITEM();

				if(vBoolSize && vBoolTemp)
				{
					if (MyOraDB.Exe_Modify_Procedure() != null)
					{
						// 소요량 조회하는 프로시져 호출
						DataTable vDt = SELECT_SBT_TEMP_ITEM(this.cmb_factory.SelectedValue.ToString(),  COM.ComVar.This_User);
						if (vDt.Rows.Count > 0)
						{
							txt_status.Text = "SAVE";
							LockProgram = false;

							// level1 데이터 축출
							Hashtable vList = new Hashtable();

							for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
							{
								if (fgrid_main.Rows[vRow].Node.Level == 2)
								{
									string vKey = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _itemCdCol]) +
										ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _specCdCol]) + 
										ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _colorCdCol]);

									if (!vList.ContainsKey(vKey))
										vList.Add(vKey, fgrid_main.Rows[vRow]);
								}
								
								_purSeq = Math.Max(_purSeq, Convert.ToInt32(fgrid_main[vRow, _purSeqCol]));
							}

							for(int vIdx = 0 ; vIdx < vDt.Rows.Count ; vIdx++)
							{
								string vTemp = vDt.Rows[vIdx][0].ToString() + vDt.Rows[vIdx][2].ToString() + vDt.Rows[vIdx][4].ToString();
								C1.Win.C1FlexGrid.Row vRow = (C1.Win.C1FlexGrid.Row)vList[vTemp];
								int vRowNum = 0;

								if (vRow != null)
								{
									Node vNode = vRow.Node.GetNode(NodeTypeEnum.LastChild);
									if (vNode == null)
										vRowNum = vRow.Node.Row.Index + 1;
									else
										vRowNum = vNode.Row.Index;
								}
								else
								{
									vRowNum = fgrid_main.Rows.Count;

									C1.Win.C1FlexGrid.Node vNewRow = fgrid_main.Rows.InsertNode(vRowNum, 1) ;
									fgrid_main[vNewRow.Row.Index, _factoryCol]		= cmb_factory.SelectedValue;
									fgrid_main[vNewRow.Row.Index, _reqSeqCol]		= 0;
									fgrid_main[vNewRow.Row.Index, _itemCdCol]		= vDt.Rows[vIdx][0];
									fgrid_main[vNewRow.Row.Index, _itemNameCol]		= vDt.Rows[vIdx][1];
									fgrid_main[vNewRow.Row.Index, _specCdCol]		= vDt.Rows[vIdx][2];
									fgrid_main[vNewRow.Row.Index, _specNameCol]		= vDt.Rows[vIdx][3];
									fgrid_main[vNewRow.Row.Index, _colorCdCol]		= vDt.Rows[vIdx][4];
									fgrid_main[vNewRow.Row.Index, _colorNameCol]	= vDt.Rows[vIdx][5];
									fgrid_main[vNewRow.Row.Index, _purQtyCol]		= vDt.Rows[vIdx][6];
									fgrid_main[vNewRow.Row.Index, _unitCol]			= vDt.Rows[vIdx][9];
									fgrid_main[vNewRow.Row.Index, _purSeqCol]		= 0;
									fgrid_main.Rows[vNewRow.Row.Index].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
									fgrid_main.Rows[vNewRow.Row.Index].Node.EnsureVisible();
									
									vRowNum++;
								}

								C1.Win.C1FlexGrid.Node vNewRow2 = fgrid_main.Rows.InsertNode(vRowNum, 2) ;
								fgrid_main[vNewRow2.Row.Index, _factoryCol]		= cmb_factory.SelectedValue;
								fgrid_main[vNewRow2.Row.Index, _reqSeqCol]		= 0;
								fgrid_main[vNewRow2.Row.Index, _itemCdCol]		= vDt.Rows[vIdx][0];
								fgrid_main[vNewRow2.Row.Index, _itemNameCol]	= "";
								fgrid_main[vNewRow2.Row.Index, _specCdCol]		= vDt.Rows[vIdx][2];
								fgrid_main[vNewRow2.Row.Index, _colorCdCol]		= vDt.Rows[vIdx][4];
								fgrid_main[vNewRow2.Row.Index, _colorNameCol]	= "NONE-00";
								fgrid_main[vNewRow2.Row.Index, _purQtyCol]		= vDt.Rows[vIdx][6];
								fgrid_main[vNewRow2.Row.Index, _styleCdCol]		= vDt.Rows[vIdx][7];
								fgrid_main[vNewRow2.Row.Index, _styleCdCol + 1]	= vDt.Rows[vIdx][10];
								fgrid_main[vNewRow2.Row.Index, _purNoCol]		= COM.ComFunction.Empty_Combo(cmb_purNo, "");
								fgrid_main[vNewRow2.Row.Index, _purSeqCol]		= ++_purSeq;
								fgrid_main[vNewRow2.Row.Index, _purStatusCol]	= "SAVE";
								fgrid_main[vNewRow2.Row.Index, 0]				= ClassLib.ComVar.Insert;
								fgrid_main.Rows[vNewRow2.Row.Index].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
								fgrid_main.Rows[vNewRow2.Row.Index].Node.EnsureVisible();
							}
						}
						else
							vDt.Dispose();
					}
				}

				_practicable = true;

				ClassLib.ComVar.Parameter_PopUpTable.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		/// <summary>
		/// Show_Item_Popup : Item 기타 데이터 입력하는 팝업 실행 : Item/ Specification/ Color
		/// </summary>
		private void Show_LLT_Item_Popup()
		{
			try
			{
				Pop_BP_Item_List iPop = new Pop_BP_Item_List();
				iPop.factory = this.cmb_factory.SelectedValue;
				
				if(iPop.ShowDialog() == DialogResult.OK)
				{
					DataTable vDt = iPop.SelectedData;

					if (vDt == null)	return;

					txt_status.Text = "SAVE";
					LockProgram = false;

					for (int idx = 0 ; idx < vDt.Rows.Count ; idx++)
					{
						string vKey = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxITEM_CD].ToString() + "\t" + 
							vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxSPEC_CD].ToString() + "\t" + 
							vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCOLOR_CD].ToString();

						int vRow = GetItemRow(vKey);
						int vEnd = fgrid_main.Rows.Count;

						if (vRow == fgrid_main.Rows.Count)
						{
							// Level 1
							C1.Win.C1FlexGrid.Node vNewRow					= fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, 1);
							fgrid_main[vNewRow.Row.Index, _itemNameCol]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxITEM_NAME].ToString();
							fgrid_main[vNewRow.Row.Index, _specNameCol]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxSPEC_NAME].ToString();
							fgrid_main[vNewRow.Row.Index, _colorNameCol]	= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCOLOR_NAME].ToString();
							fgrid_main[vNewRow.Row.Index, _itemCdCol]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxITEM_CD].ToString();
							fgrid_main[vNewRow.Row.Index, _specCdCol]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxSPEC_CD].ToString();
							fgrid_main[vNewRow.Row.Index, _colorCdCol]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCOLOR_CD].ToString();
							fgrid_main.Rows[vNewRow.Row.Index].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
							fgrid_main.Rows[vNewRow.Row.Index].Node.EnsureVisible();
						}
						else	// 동일 스타일이 존재하는지 검사
						{
							Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.NextSibling);
							vEnd = (vNode == null) ? fgrid_main.Rows.Count : vNode.Row.Index;

							for (int i = vRow + 1 ; i < vEnd ; i++)
							{
								if (fgrid_main[i, _styleCdCol].ToString().Equals("_________"))
								{
									fgrid_main.Select(vRow, 0, vRow, fgrid_main.Cols.Count - 1);
									ClassLib.ComFunction.User_Message("Exist Duplicate Item", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									return;
								}
							}
						}

						// Level 2
						C1.Win.C1FlexGrid.Node vNewRow2					= fgrid_main.Rows.InsertNode(++vRow, 2);
						fgrid_main[vNewRow2.Row.Index, _factoryCol]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxFACTORY].ToString();
						fgrid_main[vNewRow2.Row.Index, _itemCdCol]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxITEM_CD].ToString();
						fgrid_main[vNewRow2.Row.Index, _itemNameCol]	= "_________";
						fgrid_main[vNewRow2.Row.Index, _specCdCol]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxSPEC_CD].ToString();
						fgrid_main[vNewRow2.Row.Index, _specNameCol]	= "NONE";
						fgrid_main[vNewRow2.Row.Index, _colorCdCol]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCOLOR_CD].ToString();
						fgrid_main[vNewRow2.Row.Index, _colorNameCol]	= "NONE-00";
						fgrid_main[vNewRow2.Row.Index, _unitCol]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxUNIT].ToString();
						fgrid_main[vNewRow2.Row.Index, _purQtyCol]		= 0;

						// purchase
						fgrid_main[vNewRow2.Row.Index, _purPriceCol]			= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxPUR_PRICE].ToString();
						fgrid_main[vNewRow2.Row.Index, _purPriceCol + 1]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxPUR_CURRENCY].ToString();

						// outside
						fgrid_main[vNewRow2.Row.Index, _outsidePriceCol]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxOUTSIDE_PRICE].ToString();
						fgrid_main[vNewRow2.Row.Index, _outsidePriceCol + 1]	= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxOUTSIDE_CURRENCY].ToString();

						// cbd
						fgrid_main[vNewRow2.Row.Index, _cbdPriceCol]			= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCBD_PRICE].ToString();
						fgrid_main[vNewRow2.Row.Index, _cbdPriceCol + 1]		= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCBD_CURRENCY].ToString();

						// purchase
						fgrid_main[vNewRow2.Row.Index, _cbmCol]					= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCBM].ToString();
						fgrid_main[vNewRow2.Row.Index, _weightCol]				= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxWEIGHT].ToString();

						// vednor
						fgrid_main[vNewRow2.Row.Index, _custCdCol]				= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCUST_CD].ToString();
						fgrid_main[vNewRow2.Row.Index, _custNmCol]				= vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCUST_NAME].ToString();

						fgrid_main[vNewRow2.Row.Index, _purNoCol]		= COM.ComFunction.Empty_Combo(cmb_purNo, "");
						fgrid_main[vNewRow2.Row.Index, _purSeqCol]		= GetMaxSeq();
						fgrid_main[vNewRow2.Row.Index, _obsIdCol]		= "NONE";
						fgrid_main[vNewRow2.Row.Index, _obsIdCol + 1]	= "FT";
						fgrid_main[vNewRow2.Row.Index, _purStatusCol]	= "SAVE";
						fgrid_main[vNewRow2.Row.Index, 0]				= ClassLib.ComVar.Insert;
						fgrid_main.Rows[vNewRow2.Row.Index].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
						fgrid_main.Rows[vNewRow2.Row.Index].Node.EnsureVisible();
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private int GetItemRow(string arg_key)
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				if (fgrid_main.Rows[vRow].Node.Level == 1)
				{
					string vKey = fgrid_main.GetCellRange(vRow, _itemCdCol, vRow, _colorCdCol).Clip;

					if (vKey.Equals(arg_key))
					{
						fgrid_main.Select(vRow, 0, vRow, fgrid_main.Cols.Count - 1);
						return vRow;
					}
				}
			}

			return fgrid_main.Rows.Count;
		}

		private int GetMaxSeq()
		{
			int vSeq = 1;

			for (int i = fgrid_main.Rows.Fixed ; i < fgrid_main.Rows.Count ; i++)
			{
				int vTemp = Convert.ToInt32(ClassLib.ComFunction.NullCheck(fgrid_main[i, _purSeqCol], "0"));
                
				if (vTemp > vSeq)
					vSeq = vTemp;
			}

			return vSeq + 1;
		}



		#endregion

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form initialize
			ClassLib.ComFunction.Init_Form_Control(this);

            lbl_MainTitle.Text = "Purchase Order";
            this.Text = "Purchase Order";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_size.Set_Spread_Comm("SBP_PURCHASE_SIZE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			spd_size.Display_Size_ColHead(COM.ComVar.This_Factory, "", 40, _startCol);

			fgrid_main.Set_Grid("SBP_PURCHASE_TAIL", "2", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Rows[3].Visible = false;
			fgrid_main.AllowDragging = AllowDraggingEnum.None;

			//입력부 setup
			Init_Combo();
			
			// user define variable set
			_sizeSheet				= spd_size.ActiveSheet;
			_sizeSheet.Columns[0, _sizeSheet.Columns.Count - 1].AllowAutoSort = false;			
			_sizeStartColumnLabel	= _sizeSheet.Columns[_sizeSheet.FrozenColumnCount].Label;
			_sizeEndColumnLabel		= _sizeSheet.Columns[_sizeSheet.Columns.Count - 1].Label;
			ClearSizeInfo();

			_cmbPurNoEventHandler   = new System.EventHandler(this.cmb_purNo_SelectedValueChanged);
			cmb_purNo.SelectedValueChanged += _cmbPurNoEventHandler;
			
			// grid set
			_cellCombo = new Hashtable(fgrid_main.Cols.Count);


			// user define varible set
			fgrid_main.Cols[_rtaYmdCol].Format  = "yyyy-MM-dd";
			fgrid_main.Cols[_etsYmd1Col].Format = "yyyy-MM-dd";
			fgrid_main.Cols[_etsYmd2Col].Format = "yyyy-MM-dd";
			fgrid_main.Cols[_etsYmd3Col].Format = "yyyy-MM-dd";

			for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
			{
				if (fgrid_main.Cols[vCol].AllowEditing)
				{
					if (fgrid_main.Cols[vCol].DataMap != null)
					{
						_cellCombo.Add(vCol, fgrid_main.GetDataSourceWithCode(vCol));
					}
				}
			}

			_firstLoad = false;
		}

		private void Init_Combo()
		{
			try
			{
				DataTable vDt;
				
				// factory set
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;
				
				// cmb_buyDiv SBC01
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC01");
				COM.ComCtl.Set_ComboList(vDt, cmb_buyDiv, 1, 2, true, 56,0);
				cmb_buyDiv.SelectedIndex = 1;

				// cmb_purUser
				vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory,"");
				ClassLib.ComCtl.Set_ComboList(vDt,cmb_purUser, 1, 1, true, 0, 210);
				//cmb_purUser.ValueMember = "Name";
				cmb_purUser.SelectedValue = COM.ComVar.This_User;

				// cmb_purDiv SBM07
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBM07");
				COM.ComCtl.Set_ComboList(vDt, cmb_purDiv, 1, 2, true, 56,0);
				cmb_purDiv.SelectedIndex = 1;

				vDt.Dispose();

				tbtn_Create.Enabled = false;
				btn_sizeItem.Enabled = false;
				btn_CtItem.Enabled = false;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void ClearNotPk()
		{
			try
			{   
				ClearNotPkInfo();
				ClearSizeInfo();
				fgrid_main.ClearAll();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				ClearHeadInfo();
				ClearSizeInfo();
				fgrid_main.ClearAll();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Tbtn_SearchProcess(bool arg_bool)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (arg_bool)
				{
					_practicable = false;
					_doSearch = false;
				
					this.SearchHeadInfo();
					this.SearchTailInfo();
					this.SearchSizeInfo();
				}

				if (txt_status.Text.Equals(ClassLib.ComVar.Status_CONFIRM))
					LockProgram = true;
				else
					LockProgram = false;

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				_doSearch = true;
				_practicable = true;
				this.Cursor = Cursors.Default;
			}
		}

		private void Tbtn_SaveProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				string vPurNo			= "";
				string vSaveDivision	= "";
				bool vDataSetClear		= true;

				if (cmb_purNo.SelectedIndex == -1)
				{
					string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
					string vDocDivision = ClassLib.ComVar.PURCHASE;
					string vDocType = COM.ComFunction.Empty_Combo(cmb_purDiv, "");
					string vDate = dpick_purYmd.Text.Replace("-", "");
					string vUser = COM.ComVar.This_User;

					DataTable vDt = ClassLib.ComFunction.SELECT_DOCUMENT_NO(vFactory, vDocDivision, vDocType, vDate, vUser);

					vPurNo = vDt.Rows[0].ItemArray[0].ToString();
					vPurNo = vPurNo + "_" + COM.ComVar.This_Factory;
					vSaveDivision = ClassLib.ComVar.Insert;

					// SIZE 저장 - 신규일때만 한번 저장 ( 이후 수정 불가 )
					if (!SAVE_SBP_PURCHASE_SIZE(vSaveDivision, vPurNo, vDataSetClear))
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}
				}
				else
				{
					vPurNo = cmb_purNo.SelectedValue.ToString();
					vSaveDivision = ClassLib.ComVar.Update;
					vDataSetClear = false;
				}

				// HEAD 저장
				if (!SAVE_SBP_PURCHASE_HEAD(vSaveDivision, vPurNo, !vDataSetClear, false))
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}

				// TAIL 저장
				for (int i = fgrid_main.Rows.Fixed ; i < fgrid_main.Rows.Count ; i++)
				{
					if (fgrid_main.Rows[i].Node.Level != 1)
						fgrid_main[i, _purNoCol] = vPurNo;
				}
				
				if (!SAVE_SBP_PURCHASE_TAIL(false, false))
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}

                if (!RUN_SBP_CBD_UPDATE(false))
                {
                    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                    return;
                }
				
				// 저장 완료
				if (MyOraDB.Exe_Modify_Procedure() != null)
				{
					if (vSaveDivision == ClassLib.ComVar.Insert)
					{
						Cmb_PurNoSettingProcess();
						cmb_purNo.SelectedValue = vPurNo;
					}
					else
					{
						_practicable = false;
						cmb_purNo.SelectedValue = vPurNo;
						fgrid_main.Refresh_Division();
						_practicable = true;
					}
				
					LockProgram = false;

                    if (vConfirmThread != null && vConfirmThread.IsAlive)
                        vConfirmThread.Abort();

					ClassLib.ComFunction.User_Message("Save Complete", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
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

		private void Tbtn_ConfirmProcess()
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // confirm ready
                if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
                {
                    for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
                    {
                        //fgrid_main[i, 0] = ClassLib.ComVar.Update; 
                        fgrid_main.Update_Row(i);
                        fgrid_main[i, _purStatusCol] = "CONFIRM"; // 1:REQUEST, 2:PURCHASE
                    }
                }
                txt_status.Text = "CONFIRM";

                // save
                Tbtn_SaveProcess();
                LockProgram = true;
                this.Activate();
            }
            catch (Exception ex)
            {
                txt_status.Text = "REQUEST";
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                if (vConfirmThread != null && vConfirmThread.IsAlive)
                    vConfirmThread.Abort();

                this.Activate();
            }
		}        

		private void Tbtn_DeleteProcess()
		{
			try
			{
				if (SAVE_SBP_PURCHASE_HEAD(ClassLib.ComVar.Delete, cmb_purNo.SelectedValue.ToString(), true, true))
					this.Tbtn_NewProcess();

				ClassLib.ComFunction.User_Message("Delete Complete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
						
				this.ClearHeadInfo();
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

		private void Tbtn_Print_PurchaseNo()
		{
			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 

			string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BP_Purchase_Order_Sheet");

			string sPara  = " /rp ";
			sPara += "'" + COM.ComFunction.Param_Combo(cmb_factory, "%") +		"' ";
			sPara += "'" + COM.ComFunction.Param_Combo(cmb_purNo, "%") +	"' ";
			sPara += "'" + this.dpick_purYmd.Text.Replace("-","") + "' ";
			FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Form_BP_Purchase_Order_Sheet";
			MyReport.Show();			
		
		}

		public void Tbtn_Print_Vendor_old()
		{
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BP_Purchase_Order") ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 5;
			string [] aHead =  new string[iCnt];	
			

			aHead[0]    = COM.ComFunction.Empty_Combo(cmb_factory, "");
			aHead[1]    = COM.ComFunction.Param_Combo(cmb_purNo, "");
			aHead[2]    = cmb_purDiv.GetItemText(cmb_purDiv.SelectedIndex, 1);
			aHead[3]    = txt_status.Text;
			aHead[4]    = cmb_purDiv.GetItemText(cmb_buyDiv.SelectedIndex, 1);
			
			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();
		}

		public void Tbtn_Print_Vendor_new()
		{
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BP_Purchase_Order_Total") ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 11;
			string [] aHead =  new string[iCnt];	
			

			aHead[0]    = COM.ComFunction.Empty_Combo(cmb_factory, "");
			aHead[1]    = COM.ComFunction.Empty_Combo(cmb_purNo, "");
			aHead[2]    = txt_status.Text;
			aHead[3]    = dpick_purYmd.Value.ToString("yyyy-MM-dd");
			aHead[4]    = COM.ComFunction.Empty_Combo(cmb_purDiv, "");
			aHead[5]    = COM.ComFunction.Empty_Combo(cmb_buyDiv, "");
			aHead[6]    = COM.ComFunction.Param_Combo(cmb_purUser, "");
			aHead[7]    = dpick_rtaYmd.Value.ToString("yyyy-MM-dd");
			aHead[8]    = dpick_etsYmd.Value.ToString("yyyy-MM-dd");
			aHead[9]    = txt_mrpShipNo.Text;
			aHead[10]   = txt_remarks.Text;			
			
			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();			
		}

		public void Tbtn_Print_Vendor_total()
		{
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BP_Purchase_Order_Standend_Total") ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 3;
			string [] aHead =  new string[iCnt];	
			

			aHead[0]    = COM.ComFunction.Empty_Combo(cmb_factory, "");
			aHead[1]    = COM.ComFunction.Empty_Combo(cmb_purNo, "");
			aHead[2]    = ClassLib.ComVar.Parameter_PopUp[1].ToString();

			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();			
		}

		public void Tbtn_Print_Vendor_tail()
		{
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BP_Purchase_Order_Standend_Tail") ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 3;
			string [] aHead =  new string[iCnt];	
			

			aHead[0]    = COM.ComFunction.Empty_Combo(cmb_factory, "");
			aHead[1]    = COM.ComFunction.Empty_Combo(cmb_purNo, "");
			aHead[2]    = ClassLib.ComVar.Parameter_PopUp[1].ToString();	
			
			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();	

			



//			myRD401.FileOpen(@mrd_Filename, Para);
//			myRD401.SaveAsPdfFile("c:\\PURCHASE ORDER\\PO_Sheet.pdf");
		

		}








        public void Tbtn_Print_Vendor_JJ()
        {
            string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BP_Purchase_Order_JJ");
            string Para = " ";
           

            #region 출력조건

            int iCnt = 3;
            string[] aHead = new string[iCnt];


            aHead[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
            aHead[1] = COM.ComFunction.Empty_Combo(cmb_purNo, "");
            aHead[2] = ClassLib.ComVar.Parameter_PopUp[1].ToString();

            #endregion


            Para = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "[" + aHead[i - 1] + "] ";
            }

            FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer(mrd_Filename, Para);
            report.Show();



        }





		private void Cmb_PurNoSettingProcess()
		{
			try
			{
				if (_practicable)
				{
					cmb_purNo.SelectedValueChanged -= _cmbPurNoEventHandler;

					DataTable vDt = SELECT_SBP_PURCHASE_NO_LIST();
					COM.ComCtl.Set_ComboList(vDt, cmb_purNo, 0, 0, false, false);
					vDt.Dispose();

					cmb_purNo.SelectedValueChanged += _cmbPurNoEventHandler;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Cmb_PurNoSelectedValueChangedProcess()
		{
			try
			{
				if (_doSearch)
				{
					if (cmb_purNo.SelectedIndex < 0)
						Tbtn_SearchProcess(false);
					else
						Tbtn_SearchProcess(true);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Btn_SearchPurClickProcess()
		{
			Pop_BP_Purchase_Order_Pur  pop_bp_purchase     = new Pop_BP_Purchase_Order_Pur();
			
			COM.ComVar.Parameter_PopUp		= new string[1];
			COM.ComVar.Parameter_PopUp[0]	= cmb_factory.SelectedValue.ToString();


			if (pop_bp_purchase.ShowDialog() == DialogResult.OK)
			{
//				[0]factory       [1]vPurNo        [2]vPurYmd    [3]vPurUser    [4]vRtaYmd
//				[5]vEtsYmd       [6]vPurDiv       [7]vBuyDiv    [8]vPurStatus  [9]vShipNo
//				[10]vShipVersion [11]vShipFactory [12]vShipYmd  [13]vMrpNo     [14]vConfirmYn  [15]vRemarks

//				cmb_factory      cmb_purNo        dpick_purYmd   cmb_purUser   cmb_purDiv
//				cmb_purStatus    cmb_buyDiv       dpick_rtaYmd   dpick_etsYmd  txt_shipNo
//				txt_shipVersion  cmb_shipFactory  dpick_shipYmd  txt_mrpNo     cmb_mrpNo	cmb_confirmYn    txt_remarks

				_practicable = false;
				cmb_factory.SelectedValue		= COM.ComVar.Parameter_PopUp[0];
				dpick_purYmd.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[2]);
				_practicable = true;

				cmb_purUser.SelectedValue		= COM.ComVar.Parameter_PopUp[3];
				cmb_purDiv.SelectedValue		= COM.ComVar.Parameter_PopUp[6];
				cmb_buyDiv.SelectedValue		= COM.ComVar.Parameter_PopUp[7];
				dpick_rtaYmd.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[4]);
				dpick_etsYmd.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[5]);
				txt_remarks.Text				= COM.ComVar.Parameter_PopUp[15];
				
				Cmb_PurNoSettingProcess();

				cmb_purNo.SelectedValue		= COM.ComVar.Parameter_PopUp[1];

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}

			pop_bp_purchase.Dispose();
		}

		private void Btn_DeleteProcess()
		{
			int[] vSel = fgrid_main.Selections;
			int vRow = fgrid_main.Row;

			if (vSel.Length > 1)
			{
				foreach (int vTemp in vSel)
				{
					if (fgrid_main.Rows[vTemp].Node.Level == 1)
					{
						Node vNode = fgrid_main.Rows[vTemp].Node.GetNode(NodeTypeEnum.NextSibling);
						int vEndRow = (vNode == null) ? fgrid_main.Rows.Count : vNode.Row.Index;

						if (vEndRow - 1 <= vSel[vSel.Length - 1])
						{
							fgrid_main.Delete_Row(vTemp);
						}
					}
					
					if (fgrid_main.Rows[vTemp].Node.Level == 2)
						fgrid_main.Delete_Row(vTemp);
				}
			}
			else
			{
				if (fgrid_main.Rows[vRow].Node.Level == 1)
				{
					Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.NextSibling);
					int vEndRow = (vNode == null) ? fgrid_main.Rows.Count : vNode.Row.Index;

					for (int vTemp = vRow ; vTemp < vEndRow ; vTemp++)
					{
						fgrid_main.Delete_Row(vTemp);
					}
				}
				else
				{
					fgrid_main.Delete_Row();
				}
			}
		}

		private void checkExchangeRate()
		{
			Pop_BP_Exchange_Rate vPop = new Pop_BP_Exchange_Rate();

			if (vPop.ShowDialog() == DialogResult.OK)
			{
				double rate = vPop.getResultRate();

				C1.Win.C1FlexGrid.CellRange sr = fgrid_main.Selection;

				Node fn = fgrid_main.Rows[sr.r2].Node.GetNode(NodeTypeEnum.FirstChild);
				
				if (fn != null)
					sr.r2 = fn.GetNode(NodeTypeEnum.LastSibling).Row.Index;

				for (int vRow = sr.r1 ; vRow <= sr.r2 ; vRow++) 
				{
					if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _purCurrencyCol]).Equals("KRW"))
					{
						string curPrice = ClassLib.ComFunction.NullCheck(fgrid_main[vRow, _purPriceCol], "0.0");

						//fgrid_main[vRow, _cbdPriceCol] = System.Math.Round(Convert.ToDouble(curPrice) / rate + 0.00049, 3);
						fgrid_main[vRow, _cbdPriceCol] = System.Math.Ceiling(Convert.ToDouble(curPrice) / rate * 1000) / 1000;
						
						fgrid_main[vRow, _cbdCurrencyCol] = "USD";
						fgrid_main.Update_Row(vRow);   
					}
				}
			}

			vPop.Dispose();
		}

		#region 컨텍스트 메뉴

		private void mnu_Cbd_Click(object sender, System.EventArgs e)
		{
			/*************************************
			0 : FACTORY,	  	1 : PUR_USER,
			2 : CUST_CD,		3 :	PK_UNIT_QTY, 
			4 : PUR_PRICE,		5 :	PUR_CURRENCY, 		 
			6 : OUTSIDE_PRICE,	7 :	OUTSIDE_CURRENCY, 
			8 : CBD_PRICE, 		9 :	CBD_CURRENCY, 
			10 : SHIP_PRICE,	11 : SHIP_CURRENCY, 
			12 : CBM, 			13 : WEIGHT
			**************************************/
			// 검색 조건
			int[] keys = new int[]{   (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxFACTORY,
									  (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOBS_ID,
									  (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxITEM_NAME,
									  (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxITEM_CD,
									  (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxSPEC_CD,
									  (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCOLOR_CD };

			// 검색 결과
			// CBD 정보를 읽어오나 정확한 위치에 뿌려주지 못 하여 수정함 (2006.10.14, 조재성, 나중에 주석 부분 지우세요)
			int[] values = new int[]{ 
										-1,														-1,
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCUST_CD,			(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCUST_NAME,
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPK_UNIT_QTY,
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_PRICE,		(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_CURRENCY,
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_PRICE,	(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_CURRENCY,
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_PRICE,		(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_CURRENCY,
										-1,														-1,
										(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBM,				(int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxWEIGHT
									};

			Pop_BC_CBD_Information_3 vPop = new Pop_BC_CBD_Information_3(fgrid_main, keys, values);
			
			// 검색 조건
			vPop._level = 2;
			vPop._job = "Purchase";

			vPop.ShowDialog(this);
			
			/*
			if (vPop.ShowDialog(this) == DialogResult.OK)
			{
				int[] vSel = fgrid_main.Selections;

				foreach (int vRow in vSel)
				{
					if (fgrid_main.Rows[vRow].Node.Level == 1)
					{
						int vStart = vRow + 1;

						Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.NextSibling);
						int vEnd = (vNode == null) ? fgrid_main.Rows.Count - 1 : vNode.Row.Index - 1;
						
						
						while (vStart <= vEnd)
						{
							fgrid_main[vStart, _custCdCol] = fgrid_main[vRow, _custCdCol];
							fgrid_main[vStart, _custNmCol] = fgrid_main[vRow, _custNmCol];
							fgrid_main.Update_Row(vStart++);
						}
					}
				}
			}
			*/
		}

		private void Mnu_AutoCalculation(int arg_kind)
		{
			int[] vSel = fgrid_main.Selections;

			foreach (int vRow in vSel)
			{
				if ( fgrid_main.Rows[vRow].Node.Level == 1 )
				{
					int vQty = Get_ConvertedNumber(vRow, arg_kind);
					if (vQty != -1)
					{
						fgrid_main[vRow, _purQtyCol] = vQty;
						fgrid_main.Col = _purQtyCol;
						Grid_QtyCalculation_Tail(vRow);
					}
				}
			}
		}

		private int Get_ConvertedNumber(int arg_row, int arg_kind)
		{
			int vResult = -1;
			double vAdviceQty = Convert.ToDouble(fgrid_main[arg_row, _reqQtyCol]);

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
					int vPKQty = Convert.ToInt32(fgrid_main[arg_row, _pkQtyCol]);

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

		#region 프로그램 속성

		private bool LockProgram
		{
			set
			{
				tbtn_Save.Enabled		= !value;
				tbtn_Confirm.Enabled	= !value;

				btn_Tree.Enabled		= !value;
				btn_Insert.Enabled		= !value;
				btn_delete.Enabled		= !value;
				btn_recover.Enabled		= !value;

				mnu_CBDPrice.Enabled    = !value;
				mnu_exchange.Enabled    = !value;
				mnu_Packing.Enabled     = !value;
				mnu_CBM.Enabled         = !value;
				mnu_Weight.Enabled      = !value;
				mnu_outside.Enabled		= !value;

				if (txt_status.Text.ToUpper().Equals("SAVE"))
				{
					fgrid_main.AllowEditing = true;
				}
				else
				{
					fgrid_main.AllowEditing = false;
				}
			}
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

			if (cmb_purNo.SelectedIndex == -1 && (arg_type == ClassLib.ComVar.Validate_Search || arg_type == ClassLib.ComVar.Validate_Delete || arg_type == ClassLib.ComVar.Validate_Confirm))
			{
				ClassLib.ComFunction.User_Message("Select Purchase No", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_purNo.Focus();
				return false;
			}

			if (fgrid_main.Rows.Fixed >= fgrid_main.Rows.Count && (arg_type == ClassLib.ComVar.Validate_Save || arg_type == ClassLib.ComVar.Validate_Delete || arg_type == ClassLib.ComVar.Validate_Confirm))
			{
				ClassLib.ComFunction.User_Message("Empty Data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			// 부분별 체크 (Search, Save, Delete, Confirm..)
			switch (arg_type)
			{
				case ClassLib.ComVar.Validate_Search:

					break;
				case ClassLib.ComVar.Validate_Save:
					if (cmb_purUser.SelectedIndex == -1) 
					{
						ClassLib.ComFunction.User_Message("Select Purchase User", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						cmb_purUser.Focus();
						return false;
					}
					if (cmb_purDiv.SelectedIndex == -1) 
					{
						ClassLib.ComFunction.User_Message("Select Purchase Division", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						cmb_purDiv.Focus();
						return false;
					}

//					for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
//					{
//						if (fgrid_main.Rows[vRow].Node.Level == 1) // item 별
//						{
//							double vCBDPrice = Convert.ToDouble(ClassLib.ComFunction.NullCheck(fgrid_main[vRow, _cbdPriceCol], "0.0"));
//							string vCBDCurrency = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _cbdCurrencyCol]);
//							string vError = "";
//							int vErrorCol = 0;
//
//							//							if (vCBDPrice > _maxPrice)
//							//							{
//							//								vError = "Cehck CBD Price";
//							//								vErrorCol = _cbdPriceCol;
//							//							}
//							//							else if (!vCBDCurrency.Equals(_CBDCurrency) && !vCBDCurrency.Equals(""))
//							//							{
//							//								vError = "Cehck CBD Currency";
//							//								vErrorCol = _cbdCurrencyCol;
//							//							}
//
//
//
//							// item group master 에서 validation value 가지고 와서 비교
//							string item_cd = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _itemCdCol]);
//							DataTable dt_ret = Select_CBD_Validation_Data(item_cd);
//							// 0: validation_key_01, 1: validation_value_01 
//
//							if(dt_ret.Rows[0].ItemArray[1].ToString() == "" || dt_ret.Rows[0].ItemArray[1].ToString() == "0") continue;
//
//							if(vCBDCurrency.Equals(dt_ret.Rows[0].ItemArray[0].ToString() )
//								&& vCBDPrice > Convert.ToDouble(dt_ret.Rows[0].ItemArray[1].ToString() ) )
//							{
// 
//								vError = "Cehck CBD Price";
//								vErrorCol = _cbdPriceCol;
//
//							}
//							else if (!vCBDCurrency.Equals(_CBDCurrency) && !vCBDCurrency.Equals("") )
//							{
//
//								vError = "Cehck CBD Currency";
//								vErrorCol = _cbdCurrencyCol; 
//
//							} 
//
//
//
//							// 아이템 그룹별 
//							if (vError.Length > 0)
//							{
//								fgrid_main.Select(vRow, vErrorCol);
//								fgrid_main.LeftCol = vErrorCol - 2;
//
//								if (ClassLib.ComFunction.User_Message(vError + ". right?", "Invalidate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
//								{
//									continue;
//								}
//								else
//								{
//									return false;
//								}
//							}
//						}
//					}
					break;
				case ClassLib.ComVar.Validate_Delete:

					break;
				case ClassLib.ComVar.Validate_Confirm:

					for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
					{
						if (fgrid_main.Rows[vRow].Node.Level == 2) // item 별
						{
							double vPurPrice = Convert.ToDouble(ClassLib.ComFunction.NullCheck(fgrid_main[vRow, _purPriceCol], "0.0"));
							string vPurCurrency = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _purCurrencyCol]);
							double vCBDPrice = Convert.ToDouble(ClassLib.ComFunction.NullCheck(fgrid_main[vRow, _cbdPriceCol], "0.0"));
							string vCBDCurrency = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _cbdCurrencyCol]);
							double vPkQty = Convert.ToDouble(ClassLib.ComFunction.NullCheck(fgrid_main[vRow, _pkQtyCol], "0.0"));
							double vWeight = Convert.ToDouble(ClassLib.ComFunction.NullCheck(fgrid_main[vRow, _weightCol], "0.0"));
							double vPurQty = Convert.ToDouble(ClassLib.ComFunction.NullCheck(fgrid_main[vRow, _purQtyCol], "0.0"));
							double vRate = Convert.ToDouble(ClassLib.ComFunction.Empty_TextBox(txt_rate, "0"));
							string vGroup = ClassLib.ComFunction.NullCheck(fgrid_main[vRow, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxGROUP_CD], "");
							
							if (vPurQty <= 0)
							{
								ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "Purchase Qty", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, _purQtyCol);
								return false;
							}
							if (vPurPrice <= 0)
							{
								ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "Purchase Price", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, _purPriceCol);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _purPriceCol + 1]).Equals(""))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "Purchase Currency", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, _purPriceCol + 1);
								return false;
							}
							//if (!vPurCurrency.Equals(_CBDCurrency) && !vPurCurrency.Equals(""))
							if (vPurCurrency.Equals(""))
							{
								ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "Purchase Currency", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, _purCurrencyCol);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _cbdPriceCol + 1]).Equals(""))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "CBD Price", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, _cbdPriceCol + 1);
								return false;
							}
							if ((fgrid_main[3, _obsIdCol].ToString().Equals("S"))&&
								(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _obsIdCol]).Equals("")))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "OBS ID", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, _obsIdCol);
								return false;
							}
							if ((fgrid_main[3, _obsTypeCol].ToString().Equals("S"))&&
								(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _obsTypeCol]).Equals("")))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "OBS Type", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, _obsTypeCol);
								return false;
							}


							// Confirm 이전에 수정된 데이터가 있는지 검사
							/*
							string vCheck = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip;
							if(vCheck.IndexOf("I") >= 0 || vCheck.IndexOf("U") >= 0 || vCheck.IndexOf("D") >= 0)
							{
								MessageBox.Show(this, "Exist Modify Data","Confirm", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
								return false;
							}
							*/

							// DS 공장이 아닌면 컴폼시 체크 안 함
							if (COM.ComVar.This_Factory == COM.ComVar.DSFactory) 
							{
								if (vPurCurrency.Equals("KRW"))
								{
									if ((vPurPrice / vRate) > vCBDPrice)
									{
										fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Expanded = true;
										fgrid_main.Select(vRow, _purPriceCol);
										if (ClassLib.ComFunction.User_Message("Over price : " + "Purchase price", "Invalidate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
										{
											continue;
										}
										else
										{
											return false;
										}
									}
								}
								else if (vPurCurrency.Equals("USD") && (vGroup.Equals("01") || vGroup.Equals("02")))
								{
									if (vPurPrice > 20)
									{
										fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Expanded = true;
										fgrid_main.Select(vRow, _purPriceCol);
										if (ClassLib.ComFunction.User_Message("Over price : " + "Purchase price", "Invalidate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
										{
											continue;
										}
										else
										{
											return false;
										}
									}
								}

								if (vCBDPrice <= 0)
								{
									ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "CBD Price", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									fgrid_main.Select(vRow, _cbdPriceCol);
									return false;
								}

								//if (!vCBDCurrency.Equals(_CBDCurrency) && !vCBDCurrency.Equals(""))
								if (!vCBDCurrency.Equals(_CBDCurrency) || vCBDCurrency.Equals(""))
								{
									ClassLib.ComFunction.User_Message("Invalid Data or Empty Data : " + "CBD Currency", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									fgrid_main.Select(vRow, _cbdCurrencyCol);
									return false;
								}

								if (vPkQty <= 0)
								{
									ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "PK Unit Qty", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									fgrid_main.Select(vRow, _pkQtyCol);
									return false;
								}

								if (vWeight <= 0)
								{
									ClassLib.ComFunction.User_Message("Exist Zero or Empty Data : " + "Weight", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									fgrid_main.Select(vRow, _weightCol);
									return false;
								}
							 
								if (fgrid_main.Rows[vRow].Node.Level == 1) // item 별
								{
								 
									string vError = "";
									int vErrorCol = 0; 
							

									// item group master 에서 validation value 가지고 와서 비교
									string item_cd = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _itemCdCol]);
									DataTable dt_ret = Select_CBD_Validation_Data(item_cd);
									// 0: validation_key_01, 1: validation_value_01, 2: style_item_div

									if(dt_ret.Rows.Count == 0) continue;

									// cbd price 초과 검증 안하고자 할 때,
									//								if(dt_ret.Rows[0].ItemArray[1].ToString() != "0")
									//								{

									if(vCBDCurrency.Equals(dt_ret.Rows[0].ItemArray[0].ToString() )
										&& vCBDPrice > Convert.ToDouble(dt_ret.Rows[0].ItemArray[1].ToString() ) )
									{

										vError = "Cehck CBD Price";
										vErrorCol = _cbdPriceCol;

									} 

									//								}



									if (vError.Length > 0)
									{
										fgrid_main.Select(vRow, vErrorCol);
										fgrid_main.LeftCol = vErrorCol - 2;

										if (ClassLib.ComFunction.User_Message(vError + ". right?", "Invalidate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
										{
											continue;
										}
										else
										{
										 
											return false;
										}
									}
								 

									// style_item_div == '10' 일때, 2 kg 초과하면 메세지. 
									if(dt_ret.Rows[0].ItemArray[2].ToString() == "10")
									{
										if(vWeight > 2)
										{
											vError = "Over weight 2KG"; 
											if (ClassLib.ComFunction.User_Message(vError + ". right?", "Invalidate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
											{
												continue;
											}
											else
											{
												fgrid_main.Select(vRow, _weightCol);
												return false;
											}
										} // if(vWeight > 2)

									}



								} // if (fgrid_main.Rows[vRow].Node.Level == 1)
							 


							} // end if dsfactory

							
						}
						else // lot 별
						{
							if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _custCdCol]).Equals(""))
							{
								ClassLib.ComFunction.User_Message("Exist Empty Data : " + "Vendor Info", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, _custCdCol);
								return false;
							}
						}
					}
					break;

				case 10:	// 하단 Search 버튼
					if ( _sizeSheet.RowCount <= 0 )
					{
						ClassLib.ComFunction.User_Message("Empty Size Data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
				case _validate_context:
					if (fgrid_main.Rows.Fixed >= fgrid_main.Rows.Count)
					{
						mnu_AllSelect.Enabled = false;
						mnu_Data.Enabled = false;
						mnu_tvo.Enabled = false;
					}
					else
					{
						mnu_AllSelect.Enabled = true;
						mnu_tvo.Enabled = true;

						if (fgrid_main.Cols[fgrid_main.Col].AllowEditing)
							mnu_Data.Enabled = true;
						else
							mnu_Data.Enabled = false;
					}

					if (txt_status.Text.ToUpper().Equals("SAVE"))
					{
						mnu_Data.Enabled = true;
						mnu_cbd.Enabled = true;
						mnu_autoCalc.Enabled = true;
					}
					else
					{
						mnu_Data.Enabled = false;
						mnu_cbd.Enabled = false;
						mnu_autoCalc.Enabled = false;
					}

					string vItem = fgrid_main[fgrid_main.Row, _itemNameCol].ToString();
					if (fgrid_main.Rows[fgrid_main.Row].Node.Level == 2)
					{
						int vParentIdx = fgrid_main.Rows[fgrid_main.Row].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
						vItem = fgrid_main[vParentIdx, _itemNameCol].ToString();
					}

                    int vEnIdx = -1;
					for (int i = mnu_outside.MenuItems.Count - 1 ; i >= 0 ; i--)
					{
						string vMnuText = "<" + mnu_outside.MenuItems[i].Text + ">";
						if (vItem.IndexOf(vMnuText) >= 0 && vEnIdx == -1)
							vEnIdx = i;
						
						mnu_outside.MenuItems[i].Enabled = false;
					}

					if (vEnIdx > -1)
						mnu_outside.MenuItems[vEnIdx].Enabled = true;
					

					break;
			}

			return true;
		}

		#endregion
		
		#endregion

		#region 그리드 이벤트

		private void Grid_AfterEditProcess()
		{
			if (fgrid_main.Col == _purQtyCol)
			{
				if (fgrid_main.Rows[fgrid_main.Row].Node.Level == 1)
					Grid_QtyCalculation_Tail(fgrid_main.Row);
				else
					Grid_QtyCalculation_Head(fgrid_main.Row);
			}
			else
			{
				if(_level1.Contains(fgrid_main.Col)  && fgrid_main.Rows[fgrid_main.Row].Node.Level == 1)
				{
					int vRow = fgrid_main.Row;
					int vCol = fgrid_main.Col;
					int vStart = vRow;

					Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.NextSibling);
					int vEnd = (vNode == null) ? fgrid_main.Rows.Count - 1 : vNode.Row.Index - 1;

					// 수정 : 이재민 20080514 - 헤더에서 변경된 데이터를 하위 레벨에 복사
					object vHData = fgrid_main[vRow, vCol];
						
					while (vStart <= vEnd)
					{
						fgrid_main[vStart, vCol] = vHData;
						fgrid_main.Update_Row(vStart++);
					}
				}
				else
				{
					fgrid_main.Update_Row();
				}
			}

			if (fgrid_main.Rows[fgrid_main.Row].Node.Level == 1)
				Grid_CheckPrice(fgrid_main.Rows[fgrid_main.Row].Node);
			else
				Grid_CheckPrice(fgrid_main.Rows[fgrid_main.Row].Node.GetNode(NodeTypeEnum.Parent));
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
			{
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
				
			}
		}

		private void Grid_CellClickProcess()
		{
			int[] vSelectionRange = fgrid_main.Selections;
			int vCol = fgrid_main.Selection.c1;			

			if (vSelectionRange.Length == 0)	return;
			
			if(_controlLevel == 0)
			{
				COM.ComVar.Parameter_PopUp		= new string[1];
				COM.ComVar.Parameter_PopUp[0]	= fgrid_main[1, vCol].ToString();
	
				if (_cellCombo.ContainsKey(vCol))
					ClassLib.ComVar.Parameter_PopUp_Object = new object[]{_cellCombo[vCol]};

			
				Pop_BS_Shipping_List_Changer pop_changer = new Pop_BS_Shipping_List_Changer();
				pop_changer.ShowDialog();			

				if (COM.ComVar.Parameter_PopUp != null)
				{
					//if(_level1.Contains(vCol))
						SetData(1, vSelectionRange);
					//else
					//	SetData(2, vSelectionRange);
				}

				pop_changer.Dispose();
			}
			else
			{
				if(_controlLevel == 1)
				{
					string date           = DateTime.Now.ToShortDateString().Replace("-","");			
					DataTable dt_ret      = SELECT_YMD_RATE(date);
					//_rate                 = int.Parse( dt_ret.Rows[0].ItemArray[0].ToString() );	
					_rate                 = Convert.ToDouble(dt_ret.Rows[0].ItemArray[0].ToString() );	
				}
				SetData_second( vSelectionRange );
			}
		
		
		}

		// 우선순위 : 헤더, 테일
		private void SetData(int arg_level, int[] arg_sel)
		{
			// Vendor를 위한
			//if (COM.ComVar.Parameter_PopUp.Length > 1)
			//{
			//	arg_level = 1;
			//}		

			foreach (int i in arg_sel) 
			{
				//if (fgrid_main.Rows[i].Node.Level == arg_level)
				//{
					if (COM.ComVar.Parameter_PopUp.Length > 1)
					{
						fgrid_main[i, _custNmCol] = COM.ComVar.Parameter_PopUp[0];
						fgrid_main[i, _custCdCol] = COM.ComVar.Parameter_PopUp[1];	          
					}
					
					else
					{
						fgrid_main[i, fgrid_main.Col] = COM.ComVar.Parameter_PopUp[0];
					}

					fgrid_main.Update_Row(i);
				//}
			}	

			// Vendor를 위한
			//if (COM.ComVar.Parameter_PopUp.Length > 1)
			//{
				arg_level = fgrid_main.Rows[arg_sel[arg_sel.Length - 1]].Node.Level;
			//}
		
			//if (arg_level == 1)
			//{
				foreach (int vRow in arg_sel)
				{
					if (fgrid_main.Rows[vRow].Node.Level == 1)
					{
						// 발주 수량의 경우 자동 계산을 해야 함
						if (fgrid_main.Col == _purQtyCol)
						{
							Grid_QtyCalculation_Tail(vRow);
						}
						else 
						{
							int vStart = vRow + 1;

							Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.NextSibling);
							int vEnd = (vNode == null) ? fgrid_main.Rows.Count - 1 : vNode.Row.Index - 1;
						
							while (vStart <= vEnd)
							{
								if (COM.ComVar.Parameter_PopUp.Length > 1)
								{
									fgrid_main[vStart, _custNmCol] = COM.ComVar.Parameter_PopUp[0];
									fgrid_main[vStart, _custCdCol] = COM.ComVar.Parameter_PopUp[1];
								}
								else
								{
									fgrid_main[vStart, fgrid_main.Col] = COM.ComVar.Parameter_PopUp[0];
								}

								fgrid_main.Update_Row(vStart++);
							}
						}
					}
					else
					{
						if (fgrid_main.Col == _purQtyCol)
						{
							if (fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index < arg_sel[0])
							{
								Grid_QtyCalculation_Head(vRow);
							}
						}
					}
				}
			//}
			//else
			//{
			//	foreach (int vRow in arg_sel)
			//	{
			//		if (COM.ComVar.Parameter_PopUp.Length > 1 && fgrid_main.Rows[vRow].Node.Level == 2)
			//		{
			//			fgrid_main[vRow, _custNmCol] = COM.ComVar.Parameter_PopUp[0];
			//			fgrid_main[vRow, _custCdCol] = COM.ComVar.Parameter_PopUp[1];
			//				
			//			fgrid_main.Update_Row(vRow);
			//		}
			//	}
			//}
		}	

		private void SetData_second( int[] arg_sel )
		{
			foreach (int i in arg_sel)
			{
				switch(_controlLevel)
				{
					case 1 ://mnu_CBDPrice_Click
						if( fgrid_main[i, _purCurrencyCol] != null ) 
						{
//							if( fgrid_main[i, _purCurrencyCol].ToString()     == "KRW")								
//							{
//								double price
//									= Math.Round( double.Parse( fgrid_main[i, _purPriceCol].ToString() ) / _rate, 2 );
//								fgrid_main[i, _cbdPriceCol]    = price.ToString();
//								fgrid_main[i, _cbdCurrencyCol] = "USD";
//							}	
//							else if(fgrid_main[i, _purCurrencyCol].ToString() == "USD")
//							{
//								fgrid_main[i, _cbdPriceCol]    = fgrid_main[i, _purPriceCol].ToString();
//								fgrid_main[i, _cbdCurrencyCol] = "USD";
//								
//							}


							if(fgrid_main[i, _purCurrencyCol].ToString() == "USD")
							{
								fgrid_main[i, _cbdPriceCol]    = fgrid_main[i, _purPriceCol].ToString();
								fgrid_main[i, _cbdCurrencyCol] = "USD";
								
							}
							else 							
							{
								double price
									= Math.Round( double.Parse( fgrid_main[i, _purPriceCol].ToString() ) / _rate, 2 );
								fgrid_main[i, _cbdPriceCol]    = price.ToString();
								fgrid_main[i, _cbdCurrencyCol] = "USD";
							}	





						}		
						break;

					case 2 ://mnu_Packing_Click
						if( fgrid_main[i, _pkQtyCol] == null  || fgrid_main[i, _pkQtyCol].ToString() == "" )
						{ 
							fgrid_main[i, _pkQtyCol] = fgrid_main[i, _purQtyCol].ToString();
						} 
						break;

					case 3 ://mnu_CBM_Click
						if( fgrid_main[i, _cbmCol] == null )  
							fgrid_main[i, _cbmCol]    = "1";  
						break;

					case 4 ://mnu_Weight_Click 
						if( fgrid_main[i, _weightCol] == null)
						    fgrid_main[i, _weightCol] = "1";  
						break;
				}		
			}
		}
		// Advice qty calculation
		private void Grid_QtyCalculation_Tail(int arg_row)
		{
			try
			{
				if (fgrid_main.Col != _purQtyCol)
				{
					fgrid_main[fgrid_main.Row, fgrid_main.Col] = fgrid_main.Buffer_CellData;
					return;
				}

				int vStartRow	= arg_row + 1;
				Node vNode		= fgrid_main.Rows[arg_row].Node.GetNode(NodeTypeEnum.NextSibling);
				int vEndRow		= (vNode == null) ? fgrid_main.Rows.Count : vNode.Row.Index;

				double vOldQty	= Convert.ToDouble(fgrid_main.Buffer_CellData.Equals("") ? "0" : fgrid_main.Buffer_CellData);
				bool vZeroData = true;

				if (vOldQty == 0)
				{
					vZeroData = true;
					vOldQty	= Convert.ToInt32(fgrid_main[arg_row, _purQtyCol - 1]);
				}
				else
				{
					vZeroData = false;
				}

				vOldQty = (vOldQty == 0) ? 1 : vOldQty;
				int vNewQty	= Convert.ToInt32(fgrid_main[arg_row, _purQtyCol]);
				int vSumQty	= 0;
				int vTempQty = 0;

				for (int vRow = vStartRow ; vRow < vEndRow ; vRow++)
				{
					double vCurQty = Convert.ToDouble(fgrid_main[vRow, _purQtyCol]);

					if (vZeroData)
					{
						vCurQty = Convert.ToDouble(fgrid_main[vRow, _purQtyCol - 1]);
					}
					
					vTempQty = (int)Math.Round((vCurQty / vOldQty) * vNewQty);
					
					fgrid_main[vRow, _purQtyCol] = vTempQty;
					vSumQty += vTempQty;
					
					fgrid_main.Update_Row(vRow);
				}

				if ( vSumQty != vNewQty )
				{
					int vDiv = (vSumQty - vNewQty);

					for (int vRow2 = vEndRow - 1 ; vRow2 >= vStartRow ; vRow2--)
					{
						if (Convert.ToInt32(fgrid_main[vRow2, _purQtyCol]) > 0)
						{
							if (Convert.ToInt32(fgrid_main[vRow2, _purQtyCol]) >= vDiv)
							{
								fgrid_main[vRow2, _purQtyCol] = Convert.ToInt32(fgrid_main[vRow2, _purQtyCol]) - vDiv;
								break;
							}
							else
							{
								vDiv = vDiv - Convert.ToInt32(fgrid_main[vRow2, _purQtyCol]);
								fgrid_main[vRow2, _purQtyCol] = 0;
							}
						}
					}
				}

				fgrid_main.Update_Row(arg_row);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Grid_QtyCalculation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Grid_QtyCalculation_Head(int arg_row)
		{
			try
			{
				Node vNode = fgrid_main.Rows[arg_row].Node.GetNode(NodeTypeEnum.Parent);
				vNode.Row[_purQtyCol] = Convert.ToDouble(vNode.Row[_purQtyCol]) + (Convert.ToDouble(fgrid_main[arg_row, _purQtyCol]) - Convert.ToDouble(fgrid_main.Buffer_CellData.Equals("") ? "0" : fgrid_main.Buffer_CellData));
				fgrid_main.Update_Row(vNode.Row.Index);
				fgrid_main.Update_Row(arg_row);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Grid_QtyCalculation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		#endregion

		#region DB Connect


		/// <summary>
		/// PKG_SBP_PURCHASE_ORDER : PURCHASE NO 리스트 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_PURCHASE_NO_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_ORDER.SELECT_SBP_PURCHASE_NO_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_DATE";
			MyOraDB.Parameter_Name[2] = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = dpick_purYmd.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_purUser, "");
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBP_PURCHASE_ORDER : 2
		/// 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_PURCHASE_HEAD()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_ORDER.SELECT_SBP_PURCHASE_HEAD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_purNo.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBP_PURCHASE_TAIL : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_PURCHASE_TAIL()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_ORDER_EXTEND.SELECT_SBP_PURCHASE_TAIL";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_purNo.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBP_PURCHASE_SIZE : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_pur_no">청구번호</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_PURCHASE_SIZE()
		{
			// SELECT_SBS_SHIPPING_SIZE_LIST 참고
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_ORDER.SELECT_SBP_PURCHASE_SIZE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_PUR_NO";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_purNo.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
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

		public bool SAVE_SBT_TEMP_ITEM()
		{
			try
			{
				MyOraDB.ReDim_Parameter(8);

				//01.PROCEDURE명
				MyOraDB.Process_Name    = "PKG_SBT_TEMP_ITEM.SAVE_SBT_TEMP_ITEM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_ACTION_USER";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
				MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[5] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[6] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;

				MyOraDB.Parameter_Values   = new string[ClassLib.ComVar.Parameter_PopUpTable.Rows.Count * 8 ];

				ArrayList vList = new ArrayList();

				//04.DATA 정의
				vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[0][7].ToString());
				vList.Add(COM.ComVar.This_User);
				vList.Add(ClassLib.ComVar.Delete);
				vList.Add("");
				vList.Add("");
				vList.Add("");
				vList.Add("");
				vList.Add("");

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
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(false);
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message, "SAVE_SBT_TEMP_ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}

		/// <summary>
		/// PKG_SBT_TEMP_SIZE : size 정보 임시 테이블에 저장
		/// </summary>
		public bool SAVE_SBT_TEMP_SIZE()
		{
			try
			{
				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBT_TEMP_SIZE.SAVE_SBT_TEMP_SIZE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[2] = "ARG_CS_QTY";
				MyOraDB.Parameter_Name[3] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[4] = "ARG_ACTION_USER";
				MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

				//04.DATA 정의
				ArrayList vList = new ArrayList();

				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vUpdUser = COM.ComVar.This_User;
				string vStyleCode = ClassLib.ComVar.Parameter_PopUpTable.Rows[0][8].ToString();

				vList.Add(ClassLib.ComVar.Delete);
				vList.Add("");
				vList.Add("");
				vList.Add(vFactory);
				vList.Add(vUpdUser);
				vList.Add(vStyleCode);

				for (int vCol = _sizeSheet.FrozenColumnCount ; vCol < _sizeSheet.ColumnCount ; vCol++)
				{
					if (!_sizeSheet.Cells[0, vCol].Text.Equals(""))
					{
						vList.Add(ClassLib.ComVar.Insert);
						vList.Add(_sizeSheet.ColumnHeader.Cells[0, vCol].Text);
						vList.Add(_sizeSheet.Cells[0, vCol].Text.Replace(",", ""));
						vList.Add(vFactory);
						vList.Add(vUpdUser);
						vList.Add(vStyleCode);
					}															  
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show( ex.Message, "SAVE_SBT_TEMP_SIZE", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}

		/// <summary>
		/// PKG_SBP_PURCHASE_ORDER : 발주서 헤더 정보 저장
		/// </summary>
		public bool SAVE_SBP_PURCHASE_HEAD(string arg_division, string arg_pur_no, bool arg_clear, bool arg_execute)
		{
			try
			{
				MyOraDB.ReDim_Parameter(13);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_PURCHASE_ORDER.SAVE_SBP_PURCHASE_HEAD";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_PUR_NO";
				MyOraDB.Parameter_Name[3] = "ARG_PUR_YMD";
				MyOraDB.Parameter_Name[4] = "ARG_PUR_USER";
				MyOraDB.Parameter_Name[5] = "ARG_RTA_YMD";
				MyOraDB.Parameter_Name[6] = "ARG_ETS_YMD";
				MyOraDB.Parameter_Name[7] = "ARG_PUR_DIV";
				MyOraDB.Parameter_Name[8] = "ARG_BUY_DIV";
				MyOraDB.Parameter_Name[9] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[10] = "ARG_STATUS";
				MyOraDB.Parameter_Name[11] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";

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
			
				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_division;
				MyOraDB.Parameter_Values[1] = cmb_factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[2] = arg_pur_no;
				MyOraDB.Parameter_Values[3] = dpick_purYmd.Text.Replace("-", "");
				MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_purUser, "");
				MyOraDB.Parameter_Values[5] = dpick_rtaYmd.Text.Replace("-", "");
				MyOraDB.Parameter_Values[6] = dpick_etsYmd.Text.Replace("-", "");
				MyOraDB.Parameter_Values[7] = COM.ComFunction.Empty_Combo(cmb_purDiv, "");
				MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_Combo(cmb_buyDiv, "");
				MyOraDB.Parameter_Values[9] = txt_mrpShipNo.Text;
				MyOraDB.Parameter_Values[10] = COM.ComFunction.Empty_TextBox(this.txt_status, "") == "" ? "S" : txt_status.Text.Substring(0,1);
				MyOraDB.Parameter_Values[11] = txt_remarks.Text;
				MyOraDB.Parameter_Values[12] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(arg_clear);				
				
				if (arg_execute)
				{
					if (MyOraDB.Exe_Modify_Procedure() != null)
						return true;
					else
						return false;
				}

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "SAVE_SBP_PURCHASE_HEAD", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}


		/// <summary>
		/// PKG_SBP_PURCHASE_MANAGER : 그리드 저장 ( 3번째 헤더가 S로 지정된 것만 저장 )
		/// </summary>
		public bool SAVE_SBP_PURCHASE_TAIL(bool arg_clear, bool doExecute)
		{
			try
			{
				int vArrayLength = 0;

				for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
				{
					if (fgrid_main[3, vCol].ToString().Equals("S"))
						vArrayLength++;
				}

				MyOraDB.ReDim_Parameter(vArrayLength + 2);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_PURCHASE_ORDER.SAVE_SBP_PURCHASE_TAIL";

				//02.ARGURMENT / TYPE 설정
				int vTempIndex = 0;

				MyOraDB.Parameter_Name[vTempIndex] = "ARG_DIVISION";
				MyOraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				for (int i = 1 ; i < fgrid_main.Cols.Count ; i++)
				{
					if (fgrid_main[3, i].ToString().Equals("S"))
					{
						MyOraDB.Parameter_Name[vTempIndex] = "ARG_" + fgrid_main[0, i].ToString();
						MyOraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
						vTempIndex++;
					}
				}

				MyOraDB.Parameter_Name[vTempIndex] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Name[vTempIndex] = "ARG_UPD_USER";
				MyOraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;


				//03.DATA 설정 - 수정 : 이재민 20080514 - 하위 레벨 저장시 상위 데이터 참조를 제거
				//int vParent = fgrid_main.Rows.Fixed;

				ArrayList vValues = new ArrayList();
				string vFactory = cmb_factory.SelectedValue.ToString();
				string vUpdUser = COM.ComVar.This_User;

				for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					//if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]).Equals("") && fgrid_main.Rows[vRow].Node.Level == 1)
					//{
					//	vParent = vRow;
					//}
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]).Equals("") && fgrid_main.Rows[vRow].Node.Level == 2)
					{
						//vTempIndex = 0;

						// division 설정
						vValues.Add(fgrid_main[vRow, 0].ToString());
						//vTempIndex++;

						// data 설정
						for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
						{
							if (fgrid_main[3, vCol].ToString().Equals("S"))
							{
								//if (_level1.Contains(vCol))
								//{
								//	vValues.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vParent, vCol]));
								//}
								//else
								//{
									vValues.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, vCol]));
								//}

								vTempIndex++;
							}
						}

						// upd user 설정
						vValues.Add(vUpdUser);
						//vTempIndex++;
					}
				}

				MyOraDB.Parameter_Values = (string[])vValues.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(arg_clear);
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show( ex.Message, "SAVE_SBP_PURCHASE_TAIL", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}


		/// <summary>
		/// PKG_SBP_PURCHASE_MANAGER : 
		/// </summary>
		public bool RUN_SBP_CBD_UPDATE(bool arg_clear)
		{
			try
			{
				MyOraDB.ReDim_Parameter(20);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_PURCHASE_MANAGER.RUN_SBP_CBD_UPDATE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[4] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[5] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[6] = "ARG_PUR_USER";
				MyOraDB.Parameter_Name[7] = "ARG_PK_UNIT_QTY";
				MyOraDB.Parameter_Name[8] = "ARG_PUR_CURRENCY";
				MyOraDB.Parameter_Name[9] = "ARG_PUR_PRICE";
				MyOraDB.Parameter_Name[10] = "ARG_OUTSIDE_CURRENCY";
				MyOraDB.Parameter_Name[11] = "ARG_OUTSIDE_PRICE";
				MyOraDB.Parameter_Name[12] = "ARG_CBD_CURRENCY";
				MyOraDB.Parameter_Name[13] = "ARG_CBD_PRICE";
				MyOraDB.Parameter_Name[14] = "ARG_SHIP_CURRENCY";
				MyOraDB.Parameter_Name[15] = "ARG_SHIP_PRICE";
				MyOraDB.Parameter_Name[16] = "ARG_CBM";
				MyOraDB.Parameter_Name[17] = "ARG_WEIGHT";
				MyOraDB.Parameter_Name[18] = "ARG_CUST_CD";
				MyOraDB.Parameter_Name[19] = "ARG_UPD_USER";

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


				ArrayList vList = new ArrayList();
				string vFactory = cmb_factory.SelectedValue.ToString();
				string vPurUser = cmb_purUser.SelectedValue.ToString();
				string vUpdUser = COM.ComVar.This_User;

				//04.DATA 정의
				for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]).Equals("") && fgrid_main.Rows[vRow].Node.Level == 2)
					{
						int vParent = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

						// 수정 - 이재민 20080514 : 상위 레벨의 정보를 저장하던 방식을 하위 레벨 정보를 사용하도록 변경
						// 수정 - 이재민 20080514 : DPO 추가
						vList.Add(vFactory);
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _obsIdCol]));
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _styleCdCol]).Replace("-", ""));
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _itemCdCol]));
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _specCdCol]));
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _colorCdCol]));
						vList.Add(vPurUser);
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _pkQtyCol]));
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _purPriceCol + 1]));
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _purPriceCol]));
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _outsidePriceCol + 1]));
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _outsidePriceCol]));
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _cbdPriceCol + 1]));
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _cbdPriceCol]));
						vList.Add("");
						vList.Add("");
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _cbmCol]));
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _weightCol]));
						vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _custCdCol]));
                        vList.Add(vUpdUser);
					}
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));
				MyOraDB.Add_Modify_Parameter(arg_clear);

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "RUN_SBP_CBD_UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}



		/// <summary>
		/// PKG_SBP_PURCHASE_SIZE : SIZE 저장
		/// </summary>
		public bool SAVE_SBP_PURCHASE_SIZE(string arg_division, string arg_purNo, bool arg_clear)
		{
			try
			{
				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_PURCHASE_ORDER.SAVE_SBP_PURCHASE_SIZE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_PUR_NO";
				MyOraDB.Parameter_Name[3] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[4] = "ARG_CS_QTY";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

				//04.DATA 정의
				ArrayList vList = new ArrayList(_sizeSheet.ColumnCount);

				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vUpdUser = COM.ComVar.This_User;

				for (int vCol = _sizeSheet.FrozenColumnCount ; vCol < _sizeSheet.ColumnCount ; vCol++)
				{
					if (!_sizeSheet.Cells[0, vCol].Text.Equals(""))
					{
						vList.Add(arg_division);
						vList.Add(vFactory);
						vList.Add(arg_purNo);
						vList.Add(_sizeSheet.ColumnHeader.Cells[0, vCol].Text);
						vList.Add(_sizeSheet.Cells[0, vCol].Text.Replace(",", ""));
						vList.Add(vUpdUser);
					}
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));
				MyOraDB.Add_Modify_Parameter(arg_clear);

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "SAVE_SBP_PURCHASE_SIZE", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}


		/// <summary>
		/// PKG_SBP_PURCHASE_DP_DPO : 
		/// </summary>
		public void SAVE_SBP_PURCHASE_DP_DPO()
		{

			MyOraDB.ReDim_Parameter(13);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_DP_DPO.SAVE_SBP_PURCHASE_DP_DPO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[3]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[4]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5]  = "ARG_ORDER_TYPE";
			MyOraDB.Parameter_Name[6]  = "ARG_DP_QTY";
			MyOraDB.Parameter_Name[7]  = "ARG_DPO_QTY";
			MyOraDB.Parameter_Name[8]  = "ARG_USE_QTY";
			MyOraDB.Parameter_Name[9]  = "ARG_REMAINDER_QTY";
			MyOraDB.Parameter_Name[10] = "ARG_REMARKS";
			MyOraDB.Parameter_Name[11] = "ARG_STATUS";
			MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";

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

			//04.DATA 정의
			MyOraDB.Parameter_Values   = new string[13];

			// 0 HEAD, 1 DP, 2 DPO, 3 BEFORE, 4 PURCHASE
			
			//arg_division;	//arg_factory;  //arg_obs_id;      //  arg_obs_type;    //  arg_style_cd;    //  arg_cs_size;  
			//arg_dp_qty;   //arg_dpo_qty;	//arg_use_qty;     //arg_remainder_qty; //  arg_upd_user;

			int vDpQty        = 0;
			int vDpoQty		  = 0;
			int vBeforeQty    = 0;
			int vPurchaseQty  = 0;
		    
			for(int i = 0 ;  i < ClassLib.ComVar.Parameter_PopUpTable2.Columns.Count ; i++ )
			{
				vDpQty       += ClassLib.ComVar.Parameter_PopUpTable2.Rows[1].ItemArray[i].ToString() == "" ? 0 : int.Parse(ClassLib.ComVar.Parameter_PopUpTable2.Rows[1].ItemArray[i].ToString());
				vDpoQty      += ClassLib.ComVar.Parameter_PopUpTable2.Rows[2].ItemArray[i].ToString() == "" ? 0 : int.Parse(ClassLib.ComVar.Parameter_PopUpTable2.Rows[2].ItemArray[i].ToString());
				vBeforeQty   += ClassLib.ComVar.Parameter_PopUpTable2.Rows[3].ItemArray[i].ToString() == "" ? 0 : int.Parse(ClassLib.ComVar.Parameter_PopUpTable2.Rows[3].ItemArray[i].ToString());
				vPurchaseQty += ClassLib.ComVar.Parameter_PopUpTable2.Rows[4].ItemArray[i].ToString() == "" ? 0 : int.Parse(ClassLib.ComVar.Parameter_PopUpTable2.Rows[4].ItemArray[i].ToString());
			}

			int vRemainQty    = vDpoQty > 0 ? vDpoQty - vBeforeQty - vPurchaseQty : vDpQty - vBeforeQty - vPurchaseQty;

			MyOraDB.Parameter_Values[0]     = "A";
			MyOraDB.Parameter_Values[1]   = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[2]   = ClassLib.ComVar.Parameter_PopUpTable2.Rows[5].ItemArray[0].ToString();
			MyOraDB.Parameter_Values[3]   = ClassLib.ComVar.Parameter_PopUpTable2.Rows[5].ItemArray[1].ToString();
			MyOraDB.Parameter_Values[4]   = ClassLib.ComVar.Parameter_PopUpTable2.Rows[5].ItemArray[2].ToString().Replace("-","");
			MyOraDB.Parameter_Values[5]   = "";								// ORDER TYPE
			MyOraDB.Parameter_Values[6]   = vDpQty.ToString();				// DP
			MyOraDB.Parameter_Values[7]   = vDpoQty.ToString();				// DPO
			MyOraDB.Parameter_Values[8]   = vBeforeQty.ToString();			// USE
			MyOraDB.Parameter_Values[9]   = vRemainQty.ToString();			// REMAINDER
			MyOraDB.Parameter_Values[10]  = "SAVED FROM PURCHASE ORDER";    // REMARKS
			MyOraDB.Parameter_Values[11]  = "S";						    // STATUS
			MyOraDB.Parameter_Values[12]  = COM.ComVar.This_User;
					

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}

		/// <summary>
		/// PKG_SBP_PURCHASE_DP_DPO_SIZE : 
		/// </summary>
		public void SAVE_SBP_PURCHASE_DP_DPO_SIZE()
		{

			MyOraDB.ReDim_Parameter(11);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_DP_DPO_SIZE.SAVE_SBP_PURCHASE_DP_DPO_SIZE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[3]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[4]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5]  = "ARG_CS_SIZE";
			MyOraDB.Parameter_Name[6]  = "ARG_DP_QTY";
			MyOraDB.Parameter_Name[7]  = "ARG_DPO_QTY";
			MyOraDB.Parameter_Name[8]  = "ARG_USE_QTY";
			MyOraDB.Parameter_Name[9]  = "ARG_REMAINDER_QTY";
			MyOraDB.Parameter_Name[10] = "ARG_UPD_USER";

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

			//04.DATA 정의
			int saveCnt = 0;
			int saveRow = 0;

			// 저장 행 수 구하기
			
			for(int i= 0 ; i < ClassLib.ComVar.Parameter_PopUpTable2.Columns.Count; i++)
			{
				if( ClassLib.ComVar.Parameter_PopUpTable2.Rows[4].ItemArray[i].ToString() != "")
				{
					saveCnt += 1;						
				}
			}
			

			MyOraDB.Parameter_Values   = new string[11 * saveCnt];

			// 0 HEAD, 1 DP, 2 DPO, 3 BEFORE, 4 PURCHASE
			for(int i= 0 ; i < ClassLib.ComVar.Parameter_PopUpTable2.Columns.Count; i++)
			{
				if( ClassLib.ComVar.Parameter_PopUpTable2.Rows[4].ItemArray[i].ToString() != "")
				{
					//arg_division;	//arg_factory;  //arg_obs_id;      //  arg_obs_type;    //arg_style_cd;    //  arg_cs_size;  
					//arg_dp_qty;   //arg_dpo_qty;	//arg_use_qty;     //arg_remainder_qty; //  arg_upd_user;

					string vDpQty        = ClassLib.ComVar.Parameter_PopUpTable2.Rows[1].ItemArray[i].ToString() == "" ? "0"  : ClassLib.ComVar.Parameter_PopUpTable2.Rows[1].ItemArray[i].ToString();
					string vDpoQty       = ClassLib.ComVar.Parameter_PopUpTable2.Rows[2].ItemArray[i].ToString() == "" ? "0"  : ClassLib.ComVar.Parameter_PopUpTable2.Rows[2].ItemArray[i].ToString();
					string vBeforeQty    = ClassLib.ComVar.Parameter_PopUpTable2.Rows[3].ItemArray[i].ToString() == "" ? "0"  : ClassLib.ComVar.Parameter_PopUpTable2.Rows[3].ItemArray[i].ToString();
					string vPurchaseQty  = ClassLib.ComVar.Parameter_PopUpTable2.Rows[4].ItemArray[i].ToString() == "" ? "0"  : ClassLib.ComVar.Parameter_PopUpTable2.Rows[4].ItemArray[i].ToString();
					int    vRemainQty	 = int.Parse(vDpoQty) > 0 ? int.Parse(vDpoQty) - int.Parse(vBeforeQty) - int.Parse(vPurchaseQty) : int.Parse(vDpQty) - int.Parse(vBeforeQty) - int.Parse(vPurchaseQty);

					int temp = int.Parse(vPurchaseQty) + int.Parse(vBeforeQty);
					MyOraDB.Parameter_Values[saveRow*11]     = "A";
					MyOraDB.Parameter_Values[saveRow*11+1]   = COM.ComVar.This_Factory;
					MyOraDB.Parameter_Values[saveRow*11+2]   = ClassLib.ComVar.Parameter_PopUpTable2.Rows[5].ItemArray[0].ToString();
					MyOraDB.Parameter_Values[saveRow*11+3]   = ClassLib.ComVar.Parameter_PopUpTable2.Rows[5].ItemArray[1].ToString();
					MyOraDB.Parameter_Values[saveRow*11+4]   = ClassLib.ComVar.Parameter_PopUpTable2.Rows[5].ItemArray[2].ToString().Replace("-","");
					MyOraDB.Parameter_Values[saveRow*11+5]   = ClassLib.ComVar.Parameter_PopUpTable2.Rows[0].ItemArray[i].ToString();
					MyOraDB.Parameter_Values[saveRow*11+6]   = vDpQty;
					MyOraDB.Parameter_Values[saveRow*11+7]   = vDpoQty;
					MyOraDB.Parameter_Values[saveRow*11+8]   = temp.ToString(); //vBeforeQty;
					MyOraDB.Parameter_Values[saveRow*11+9]   = vRemainQty.ToString();
					MyOraDB.Parameter_Values[saveRow*11+10]  = COM.ComVar.This_User;
					saveRow++;
				}
			}

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}


		/// <summary>
		/// Select_Validation_Data : 
		/// </summary>
		/// <param name="arg_item_cd"></param>
		/// <returns></returns>		
		private DataTable Select_CBD_Validation_Data(string arg_item_cd)
		{
 
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_ORDER.SELECT_CBD_VALIDATION_DATA";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_ITEM_CD"; 
			MyOraDB.Parameter_Name[1]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.Cursor; 

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_item_cd; 
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];


		}

		
		/// <summary>
		///  PKG_SCM_EXCH_RATE : 환율 받아오기 (default 920)
		/// </summary>
		private DataTable SELECT_YMD_RATE(string arg_ymd)
		{
 
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SCM_EXCH_RATE.SELECT_YMD_RATE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_YMD"; 
			MyOraDB.Parameter_Name[1]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.Cursor; 

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_ymd; 
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];


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

		#endregion

		#region 버튼이벤트

		private void btn_sizeItem_Click(object sender, System.EventArgs e)
		{
			this.Btn_SizeItemProcess();

			bool vExistData  = false;
			// view point move
			for (int col = _startCol ; col < _sizeSheet.Columns.Count ; col++)
			{
				for (int row = 0 ; row < _sizeSheet.Rows.Count ; row++)
					if (!_sizeSheet.Cells[row, col].Text.Trim().Equals(""))
						vExistData = true;
				
				if (vExistData)
				{
					spd_size.ShowColumn(0, col, FarPoint.Win.Spread.HorizontalPosition.Left);
					break;
				}
			}			
		}

		private void Btn_SizeItemProcess()
		{
//			int	   vSeq			= 0;
//
//			Pop_BP_Purchase_Order_Size pop_orderSize = new Pop_BP_Purchase_Order_Size();
//
//			pop_orderSize.ShowDialog();
//
//			_practicable = false;
//
//			if (ClassLib.ComVar.Parameter_PopUpTable.Rows.Count > 0 && ClassLib.ComVar.Parameter_PopUpTable2.Rows.Count > 0)
//			{
//				// spd_size에 값을 찾아서 세팅
//				//loop -DATA column(마지막ROW는 제외)
//									
//				for(int i = _startCol ; i < _sizeSheet.Columns.Count ; i++)
//				{
//					for(int j = 0; j < ClassLib.ComVar.Parameter_PopUpTable2.Columns.Count; j++)
//					{
//						if( _sizeSheet.ColumnHeader.Cells[0, i].Text == ClassLib.ComVar.Parameter_PopUpTable2.Rows[0].ItemArray[j].ToString())
//							if(ClassLib.ComVar.Parameter_PopUpTable2.Rows[4].ItemArray[j].ToString() != "")
//							_sizeSheet.Cells[0,i].Value = int.Parse(ClassLib.ComVar.Parameter_PopUpTable2.Rows[4].ItemArray[j].ToString());
//					}
//				}
//				
//				string vStartColumnLabel = _sizeSheet.ColumnHeader.Columns[_startCol].Label;
//				string vEndColumnLabel   = _sizeSheet.ColumnHeader.Columns[_sizeSheet.Columns.Count - 1].Label;
//				_sizeSheet.Cells[0, 2].Formula = "SUM(" + vStartColumnLabel + "1:" + vEndColumnLabel + "1)";
//				
//				// ClassLib.ComVar.Parameter_PopUpTable 를 SBT_TEMP_SIZE에 저장
//				// bool vBoolSize  = SAVE_SBT_TEMP_SIZE();
//				bool vBoolSize  = MyOraDB.Save_Spread_CrossTab_Request2("PKG_SBT_TEMP_SIZE.SAVE_SBT_TEMP_SIZE", this.spd_size, _startCol, "ARG_CS_SIZE", "ARG_CS_QTY","ARG_FACTORY","ARG_ACTION_USER", "ARG_STYLE_CD", this.cmb_factory.SelectedValue.ToString(),  COM.ComVar.This_User, ClassLib.ComVar.Parameter_PopUp[3].ToString());
//
//
//				// pop_up   의 내용을 SBT_TEMP_ITEM 에 저장
//				bool vBoolTemp  = SAVE_SBT_TEMP_ITEM();
//
//				if(vBoolSize == true && vBoolTemp == true)
//				{
//					// 소요량 조회하는 프로시져 호출
//					DataTable vDt = SELECT_SBT_TEMP_ITEM(this.cmb_factory.SelectedValue.ToString(),  COM.ComVar.This_User);
//					if (vDt.Rows.Count > 0)
//					{
//						fgrid_main.Tree.Column	= _seqCol;
//
//						C1.Win.C1FlexGrid.Node newRow1				= fgrid_main.Rows.InsertNode(fgrid_main.Rows.Fixed, 1);
//						fgrid_main[newRow1.Row.Index, _levCol]	    = "1";
//						fgrid_main[newRow1.Row.Index, _factoryCol]   = cmb_factory.SelectedValue;
//						fgrid_main[newRow1.Row.Index, _reqSeqCol]	= 0;
//						fgrid_main[newRow1.Row.Index, _itemNameCol]	= vDt.Rows[0][1];
//						fgrid_main[newRow1.Row.Index, _styleNmCol]   = vDt.Rows[0][10];
//
//						for(int i = 0 ; i < vDt.Rows.Count ; i++)
//						{
//							C1.Win.C1FlexGrid.Node newRow			   = fgrid_main.Rows.InsertNode(fgrid_main.Rows.Fixed + i+1, 2);
//							fgrid_main[newRow.Row.Index, _levCol]	   = "2";
//							fgrid_main[newRow.Row.Index, _factoryCol]   = cmb_factory.SelectedValue;
//							fgrid_main[newRow.Row.Index, _reqSeqCol]	   = 0;
//							fgrid_main[newRow.Row.Index, _itemCdCol]	   = vDt.Rows[i][0];
//							fgrid_main[newRow.Row.Index, _itemNameCol]	   = vDt.Rows[i][1];
//							fgrid_main[newRow.Row.Index, _specCdCol]	   = vDt.Rows[i][2];
//							fgrid_main[newRow.Row.Index, _specNameCol]	   = vDt.Rows[i][3];
//							fgrid_main[newRow.Row.Index, _colorCdCol]   = vDt.Rows[i][4];
//							fgrid_main[newRow.Row.Index, _colorNameCol]   = vDt.Rows[i][5];
//							fgrid_main[newRow.Row.Index, _purQtyCol]    = vDt.Rows[i][6];
//							fgrid_main[newRow.Row.Index, _styleCdCol]   = vDt.Rows[i][7];
//							fgrid_main[newRow.Row.Index, _unitCol]    = vDt.Rows[i][9];
//							fgrid_main[newRow.Row.Index, _styleNmCol]   = vDt.Rows[i][10];
//							fgrid_main[newRow.Row.Index,0]			   = ClassLib.ComVar.Insert;
//						}
//					}
//					else
//						vDt.Dispose();
//
//					for ( int i = fgrid_main.Rows.Fixed ; i < fgrid_main.Rows.Count; i++ )
//					{
//						if(fgrid_main[i,_levCol].ToString() == "2")
//						{
//							fgrid_main[i, _seqCol] = vSeq+1;
//							vSeq += 1;
//						}
//					}
//				}
//			}
//			else
//			{
//				// Tbtn_NewProcess();
//				// ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
//			}
//
//			ClassLib.ComVar.Parameter_PopUpTable.Dispose();
//			
//			_practicable = true;
//
//			pop_orderSize.Dispose();
		}

		private void btn_CtItem_Click(object sender, System.EventArgs e)
		{
			/*
			int	   vSeq			= 0;

			Pop_BP_Purchase_Order_Ct pop_orderCt = new Pop_BP_Purchase_Order_Ct();

			pop_orderCt.ShowDialog();

			_practicable = false;

			if (ClassLib.ComVar.Parameter_PopUpTable.Rows.Count > 0)
			{
				fgrid_main.Tree.Column	= _seqCol;
				fgrid_main.Tree.Show(rad_head.Checked ? 1 : 2);

				C1.Win.C1FlexGrid.Node newRow1				= fgrid_main.Rows.InsertNode(fgrid_main.Rows.Fixed, 1);
				fgrid_main[newRow1.Row.Index, _levCol]	    = "1";
				fgrid_main[newRow1.Row.Index, _factoryCol]   = cmb_factory.SelectedValue;
				fgrid_main[newRow1.Row.Index, _reqSeqCol]	= 0;
				fgrid_main[newRow1.Row.Index, _itemNameCol]	= ClassLib.ComVar.Parameter_PopUpTable.Rows[0][2];
				fgrid_main[newRow1.Row.Index, _styleNmCol]   = "NO STYLE NAME";

				for(int i = 0 ; i < ClassLib.ComVar.Parameter_PopUpTable.Rows.Count ; i++)
				{
					C1.Win.C1FlexGrid.Node newRow			   = fgrid_main.Rows.InsertNode(fgrid_main.Rows.Fixed + i+1, 2);
					fgrid_main[newRow.Row.Index, _levCol]	   = "2";
					fgrid_main[newRow.Row.Index, _reqSeqCol]	   = 0;
					fgrid_main[newRow.Row.Index, _itemCdCol]	   = ClassLib.ComVar.Parameter_PopUpTable.Rows[i][0];
					fgrid_main[newRow.Row.Index, _itemNameCol]	   = ClassLib.ComVar.Parameter_PopUpTable.Rows[i][2];
					fgrid_main[newRow.Row.Index, _remarksCol]   = ClassLib.ComVar.Parameter_PopUpTable.Rows[i][3];
					fgrid_main[newRow.Row.Index, _purQtyCol]    = ClassLib.ComVar.Parameter_PopUpTable.Rows[i][4];
					fgrid_main[newRow.Row.Index, _specCdCol]    = "0000";
					fgrid_main[newRow.Row.Index, _specNameCol]    = "NOTHING";
					fgrid_main[newRow.Row.Index, _colorCdCol]   = "00000";
					fgrid_main[newRow.Row.Index, _colorNameCol]   = "NONE";
					fgrid_main[newRow.Row.Index, _styleCdCol]   = "NONE";
					fgrid_main[newRow.Row.Index, _unitCol]    = "";
					fgrid_main[newRow.Row.Index, _styleNmCol]   = "NO STYLE NAME";
					fgrid_main[newRow.Row.Index,0]			   = ClassLib.ComVar.Insert;
				}
//				spd_main.ShowColumn(0, _remarksCol, FarPoint.Win.Spread.HorizontalPosition.Left);

				cmb_itemDiv.SelectedIndex = 2;

				for ( int i = fgrid_main.Rows.Fixed ; i < fgrid_main.Rows.Count; i++ )
				{
					if(fgrid_main[i,_levCol].ToString() == "2")
					{
						fgrid_main[i, _seqCol] = vSeq+1;
						vSeq += 1;
					}
				}
			}

			ClassLib.ComVar.Parameter_PopUpTable.Dispose();
			
			_practicable = true;

			pop_orderCt.Dispose();
			*/
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

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			Mnu_Rate();
		}
		
		private void Mnu_Rate()
		{
			try
			{
				int vCol = fgrid_main.Col;

				ClassLib.ComVar.Parameter_PopUp = new string[]{"Value", "100"};
				//ClassLib.ComVar.Parameter_PopUp_Object = new object[]{fgrid_main.GetDataSourceWithCode(_confirmQtyCol)};
				FlexMRP.MRP.Pop_BM_Changer _pop = new FlexMRP.MRP.Pop_BM_Changer();
				_pop.ShowDialog();

				if (ClassLib.ComVar.Parameter_PopUp != null)
				{
					foreach (int vRow in fgrid_main.Selections)
					{
						if (fgrid_main.Rows[vRow].Node.Level == 1)
						{
							int    _ConfirmQty = Convert.ToInt32( fgrid_main[vRow, _purQtyCol] );
							double _Rate       = _ConfirmQty * ( Convert.ToDouble( ClassLib.ComVar.Parameter_PopUp[0] ) / 100 ) ;
							int    _Result     = (int)_Rate;
							//string _Temp       = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxREMARKS]);
							//string _Remarks    = _Temp + ", Rate : " + ClassLib.ComVar.Parameter_PopUp[0] + "%";

							fgrid_main[vRow, _purQtyCol] = _Result;
							//fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxREMARKS] = _Remarks;

							//fgrid_main[vRow, (int)TBSBM_MRP_ITEM_LOT.IxCONFIRM_QTY] = ClassLib.ComVar.Parameter_PopUp[0]
							fgrid_main.Update_Row(vRow);

							
							Grid_QtyCalculation_Tail(vRow);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Rate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}


	}
}


