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
	public class Form_BS_Scan_InOut : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		public System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label lbl_shipYmd;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.Label lbl_shipNo;
		private C1.Win.C1List.C1Combo cmb_shipFactory;
		private System.Windows.Forms.Label lbl_shipFactory;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private System.Windows.Forms.Label lbl_vendor;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.TextBox txt_styleCode;
		private System.Windows.Forms.Label lbl_shipType;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private System.Windows.Forms.Label lbl_location;
		private C1.Win.C1List.C1Combo cmb_location;
		private System.Windows.Forms.Label btn_scan;
		private System.Windows.Forms.Label lbl_InOutType;
		private C1.Win.C1List.C1Combo cmb_inOutType;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_shipNo;
		private System.Windows.Forms.Label lbl_barcodeState;
		private System.Windows.Forms.Label btn_change;
		private System.Windows.Forms.Label btn_cancel;
		private C1.Win.C1List.C1Combo cmb_barcodeState;
		private System.Windows.Forms.Panel pnl_btn;
		private System.Windows.Forms.Label lbl_user;
		private C1.Win.C1List.C1Combo cmb_user;
		private System.Windows.Forms.Label lbl_qty;
		private System.Windows.Forms.Label lbl_excep_mark;
		private System.Windows.Forms.TextBox txt_qty;
		private System.Windows.Forms.ContextMenu ctx_bar;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.Label lbl_ScanType;
		private C1.Win.C1List.C1Combo cmb_ScanType;
		private System.Windows.Forms.MenuItem mnu_Outgoing;
		private System.Windows.Forms.MenuItem mnu_VesselOut;
		private System.Windows.Forms.MenuItem mnu_AFOut;
		private System.Windows.Forms.MenuItem mnu_HCOut;
		private System.Windows.Forms.MenuItem mnu_ContainerDoDoOut;
		private System.Windows.Forms.MenuItem mnu_DoDoOut;
		private System.Windows.Forms.MenuItem mnu_AllDeselect;
		private COM.FSP fgrid_bar;
		private System.Windows.Forms.ImageList img_Type;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.MenuItem mnu_bar2;
		private C1.Win.C1List.C1Combo cmb_container;
		private System.Windows.Forms.Label lbl_Container;
		private System.Windows.Forms.MenuItem mnu_repChange;

		#endregion
		
		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private ArrayList _selectionRows = null;
		CellRange _checkColRange;

		private int _checkCol		= (int)ClassLib.TBSBS_BAR_1.IxCHK;
		private int _levelCol		= (int)ClassLib.TBSBS_BAR_1.IxLEV;
		private int _shipQtyCol		= (int)ClassLib.TBSBS_BAR_1.IxSHIP_QTY;
		private int _scanQtyCol		= (int)ClassLib.TBSBS_BAR_1.IxSCAN_QTY;
		private int _weightCol		= (int)ClassLib.TBSBS_BAR_1.IxWEIGHT;
		private int _inStateCol		= (int)ClassLib.TBSBS_BAR_1.IxIN_STATE;
		private int _outStateCol	= (int)ClassLib.TBSBS_BAR_1.IxOUT_STATE;
		private int _scanYmdCol		= (int)ClassLib.TBSBS_BAR_1.IxSCAN_YMD;
		private int _locationCol	= (int)ClassLib.TBSBS_BAR_1.IxLOCATION;
		private int _typeCol		= (int)ClassLib.TBSBS_BAR_1.IxTYPE_CD;
		private int _containerCol	= (int)ClassLib.TBSBS_BAR_1.IxCONTAINER;
		private int _seqCol			= (int)ClassLib.TBSBS_BAR_1.IxBAR_SEQ;
		private int _barcodeRepCol	= (int)ClassLib.TBSBS_BAR_1.IxBAR_CODE_REP;
		private int _stateCol;
		private int _notScanCount, _preScanCount, _scanCount;
		private const int _validate_scan = 10, _validate_change = 20, _validate_cancel = 30, _validate_context = 40, _validate_repChange = 50;
		private System.Windows.Forms.Label lbl_RepBarcode;
		private C1.Win.C1List.C1Combo cmb_RepBarcode;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnu_rep;
		private System.Windows.Forms.MenuItem mnu_detaile;
		private C1.Win.C1List.C1Combo cmb_matType;
		private System.Windows.Forms.Label lbl_matType;
		private System.Windows.Forms.MenuItem mnu_Outside;
		private C1.Win.C1List.C1Combo cmb_reqReason;
		private bool _doSearch = false;

		#endregion

		#region 생성자 / 소멸자

		public Form_BS_Scan_InOut()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BS_Scan_InOut));
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
            C1.Win.C1List.Style style65 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style66 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style67 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style68 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style69 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style70 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style71 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style72 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style73 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style74 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style75 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style76 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style77 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style78 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style79 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style80 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style81 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style82 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style83 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style84 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style85 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style86 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style87 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style88 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style89 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style90 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style91 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style92 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style93 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style94 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style95 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style96 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style97 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style98 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style99 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style100 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style101 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style102 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style103 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style104 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style105 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style106 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style107 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style108 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style109 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style110 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style111 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style112 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_bar = new COM.FSP();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.btn_scan = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_reqReason = new C1.Win.C1List.C1Combo();
            this.cmb_matType = new C1.Win.C1List.C1Combo();
            this.lbl_matType = new System.Windows.Forms.Label();
            this.cmb_RepBarcode = new C1.Win.C1List.C1Combo();
            this.lbl_RepBarcode = new System.Windows.Forms.Label();
            this.cmb_container = new C1.Win.C1List.C1Combo();
            this.lbl_Container = new System.Windows.Forms.Label();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.lbl_user = new System.Windows.Forms.Label();
            this.cmb_ScanType = new C1.Win.C1List.C1Combo();
            this.lbl_ScanType = new System.Windows.Forms.Label();
            this.cmb_shipFactory = new C1.Win.C1List.C1Combo();
            this.cmb_inOutType = new C1.Win.C1List.C1Combo();
            this.cmb_barcodeState = new C1.Win.C1List.C1Combo();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.cmb_location = new C1.Win.C1List.C1Combo();
            this.cmb_shipNo = new C1.Win.C1List.C1Combo();
            this.cmb_shipType = new C1.Win.C1List.C1Combo();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_InOutType = new System.Windows.Forms.Label();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_style = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.lbl_excep_mark = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_barcodeState = new System.Windows.Forms.Label();
            this.lbl_shipNo = new System.Windows.Forms.Label();
            this.lbl_shipYmd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_shipFactory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.txt_styleCode = new System.Windows.Forms.TextBox();
            this.ctx_bar = new System.Windows.Forms.ContextMenu();
            this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
            this.mnu_AllDeselect = new System.Windows.Forms.MenuItem();
            this.mnu_bar2 = new System.Windows.Forms.MenuItem();
            this.mnu_Outgoing = new System.Windows.Forms.MenuItem();
            this.mnu_VesselOut = new System.Windows.Forms.MenuItem();
            this.mnu_ContainerDoDoOut = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.mnu_AFOut = new System.Windows.Forms.MenuItem();
            this.mnu_HCOut = new System.Windows.Forms.MenuItem();
            this.mnu_DoDoOut = new System.Windows.Forms.MenuItem();
            this.mnu_repChange = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnu_rep = new System.Windows.Forms.MenuItem();
            this.mnu_detaile = new System.Windows.Forms.MenuItem();
            this.mnu_Outside = new System.Windows.Forms.MenuItem();
            this.img_Type = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_bar)).BeginInit();
            this.pnl_main.SuspendLayout();
            this.pnl_btn.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_matType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_RepBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_container)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ScanType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inOutType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_barcodeState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.fgrid_bar);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "27.6041666666667:False:True;64.4097222222222:False:False;5.20833333333333:False:T" +
                "rue;\t0.393700787401575:False:True;97.6377952755905:False:False;0.393700787401575" +
                ":False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 31;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_bar
            // 
            this.fgrid_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(186)))));
            this.fgrid_bar.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_bar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_bar.Location = new System.Drawing.Point(12, 167);
            this.fgrid_bar.Name = "fgrid_bar";
            this.fgrid_bar.Size = new System.Drawing.Size(992, 371);
            this.fgrid_bar.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_bar.Styles"));
            this.fgrid_bar.TabIndex = 2;
            this.fgrid_bar.BeforeMouseDown += new C1.Win.C1FlexGrid.BeforeMouseDownEventHandler(this.fgrid_bar_BeforeMouseDown);
            this.fgrid_bar.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_bar_AfterEdit);
            this.fgrid_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_bar_MouseUp);
            this.fgrid_bar.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_bar_BeforeEdit);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.pnl_btn);
            this.pnl_main.Location = new System.Drawing.Point(12, 542);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(992, 30);
            this.pnl_main.TabIndex = 1;
            // 
            // pnl_btn
            // 
            this.pnl_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_btn.Controls.Add(this.btn_scan);
            this.pnl_btn.Controls.Add(this.btn_change);
            this.pnl_btn.Controls.Add(this.btn_cancel);
            this.pnl_btn.Location = new System.Drawing.Point(0, 0);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(992, 30);
            this.pnl_btn.TabIndex = 47;
            // 
            // btn_scan
            // 
            this.btn_scan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_scan.ImageIndex = 0;
            this.btn_scan.ImageList = this.img_Button;
            this.btn_scan.Location = new System.Drawing.Point(749, 3);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(80, 24);
            this.btn_scan.TabIndex = 236;
            this.btn_scan.Text = "Scan";
            this.btn_scan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            this.btn_scan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_scan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_change
            // 
            this.btn_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_change.ImageIndex = 0;
            this.btn_change.ImageList = this.img_Button;
            this.btn_change.Location = new System.Drawing.Point(830, 3);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(80, 24);
            this.btn_change.TabIndex = 236;
            this.btn_change.Text = "Change";
            this.btn_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            this.btn_change.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_change.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(911, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 24);
            this.btn_cancel.TabIndex = 236;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_reqReason);
            this.pnl_head.Controls.Add(this.cmb_matType);
            this.pnl_head.Controls.Add(this.lbl_matType);
            this.pnl_head.Controls.Add(this.cmb_RepBarcode);
            this.pnl_head.Controls.Add(this.lbl_RepBarcode);
            this.pnl_head.Controls.Add(this.cmb_container);
            this.pnl_head.Controls.Add(this.lbl_Container);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.cmb_user);
            this.pnl_head.Controls.Add(this.lbl_user);
            this.pnl_head.Controls.Add(this.cmb_ScanType);
            this.pnl_head.Controls.Add(this.lbl_ScanType);
            this.pnl_head.Controls.Add(this.cmb_shipFactory);
            this.pnl_head.Controls.Add(this.cmb_inOutType);
            this.pnl_head.Controls.Add(this.cmb_barcodeState);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.txt_vendorCode);
            this.pnl_head.Controls.Add(this.cmb_vendor);
            this.pnl_head.Controls.Add(this.cmb_location);
            this.pnl_head.Controls.Add(this.cmb_shipNo);
            this.pnl_head.Controls.Add(this.cmb_shipType);
            this.pnl_head.Controls.Add(this.txt_qty);
            this.pnl_head.Controls.Add(this.lbl_qty);
            this.pnl_head.Controls.Add(this.lbl_InOutType);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.lbl_location);
            this.pnl_head.Controls.Add(this.lbl_style);
            this.pnl_head.Controls.Add(this.lbl_vendor);
            this.pnl_head.Controls.Add(this.lbl_excep_mark);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_barcodeState);
            this.pnl_head.Controls.Add(this.lbl_shipNo);
            this.pnl_head.Controls.Add(this.lbl_shipYmd);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_shipFactory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.txt_styleCode);
            this.pnl_head.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 159);
            this.pnl_head.TabIndex = 0;
            // 
            // cmb_reqReason
            // 
            this.cmb_reqReason.AddItemCols = 0;
            this.cmb_reqReason.AddItemSeparator = ';';
            this.cmb_reqReason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqReason.Caption = "";
            this.cmb_reqReason.CaptionHeight = 17;
            this.cmb_reqReason.CaptionStyle = style1;
            this.cmb_reqReason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reqReason.ColumnCaptionHeight = 18;
            this.cmb_reqReason.ColumnFooterHeight = 18;
            this.cmb_reqReason.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reqReason.ContentHeight = 16;
            this.cmb_reqReason.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reqReason.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_reqReason.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reqReason.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reqReason.EditorHeight = 16;
            this.cmb_reqReason.EvenRowStyle = style2;
            this.cmb_reqReason.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqReason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqReason.FooterStyle = style3;
            this.cmb_reqReason.GapHeight = 2;
            this.cmb_reqReason.HeadingStyle = style4;
            this.cmb_reqReason.HighLightRowStyle = style5;
            this.cmb_reqReason.ItemHeight = 15;
            this.cmb_reqReason.Location = new System.Drawing.Point(537, 62);
            this.cmb_reqReason.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqReason.MaxDropDownItems = ((short)(5));
            this.cmb_reqReason.MaxLength = 32767;
            this.cmb_reqReason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqReason.Name = "cmb_reqReason";
            this.cmb_reqReason.OddRowStyle = style6;
            this.cmb_reqReason.PartialRightColumn = false;
            this.cmb_reqReason.PropBag = resources.GetString("cmb_reqReason.PropBag");
            this.cmb_reqReason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqReason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.SelectedStyle = style7;
            this.cmb_reqReason.Size = new System.Drawing.Size(115, 20);
            this.cmb_reqReason.Style = style8;
            this.cmb_reqReason.TabIndex = 536;
            // 
            // cmb_matType
            // 
            this.cmb_matType.AddItemCols = 0;
            this.cmb_matType.AddItemSeparator = ';';
            this.cmb_matType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_matType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_matType.Caption = "";
            this.cmb_matType.CaptionHeight = 17;
            this.cmb_matType.CaptionStyle = style9;
            this.cmb_matType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_matType.ColumnCaptionHeight = 18;
            this.cmb_matType.ColumnFooterHeight = 18;
            this.cmb_matType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_matType.ContentHeight = 16;
            this.cmb_matType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_matType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_matType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_matType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_matType.EditorHeight = 16;
            this.cmb_matType.EvenRowStyle = style10;
            this.cmb_matType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_matType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_matType.FooterStyle = style11;
            this.cmb_matType.GapHeight = 2;
            this.cmb_matType.HeadingStyle = style12;
            this.cmb_matType.HighLightRowStyle = style13;
            this.cmb_matType.ItemHeight = 15;
            this.cmb_matType.Location = new System.Drawing.Point(755, 128);
            this.cmb_matType.MatchEntryTimeout = ((long)(2000));
            this.cmb_matType.MaxDropDownItems = ((short)(5));
            this.cmb_matType.MaxLength = 32767;
            this.cmb_matType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_matType.Name = "cmb_matType";
            this.cmb_matType.OddRowStyle = style14;
            this.cmb_matType.PartialRightColumn = false;
            this.cmb_matType.PropBag = resources.GetString("cmb_matType.PropBag");
            this.cmb_matType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_matType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_matType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_matType.SelectedStyle = style15;
            this.cmb_matType.Size = new System.Drawing.Size(220, 20);
            this.cmb_matType.Style = style16;
            this.cmb_matType.TabIndex = 534;
            // 
            // lbl_matType
            // 
            this.lbl_matType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_matType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matType.ImageIndex = 0;
            this.lbl_matType.ImageList = this.img_Label;
            this.lbl_matType.Location = new System.Drawing.Point(654, 128);
            this.lbl_matType.Name = "lbl_matType";
            this.lbl_matType.Size = new System.Drawing.Size(100, 21);
            this.lbl_matType.TabIndex = 535;
            this.lbl_matType.Text = "Material Type";
            this.lbl_matType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_RepBarcode
            // 
            this.cmb_RepBarcode.AddItemCols = 0;
            this.cmb_RepBarcode.AddItemSeparator = ';';
            this.cmb_RepBarcode.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_RepBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_RepBarcode.Caption = "";
            this.cmb_RepBarcode.CaptionHeight = 17;
            this.cmb_RepBarcode.CaptionStyle = style17;
            this.cmb_RepBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_RepBarcode.ColumnCaptionHeight = 18;
            this.cmb_RepBarcode.ColumnFooterHeight = 18;
            this.cmb_RepBarcode.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_RepBarcode.ContentHeight = 16;
            this.cmb_RepBarcode.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_RepBarcode.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_RepBarcode.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_RepBarcode.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_RepBarcode.EditorHeight = 16;
            this.cmb_RepBarcode.EvenRowStyle = style18;
            this.cmb_RepBarcode.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_RepBarcode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_RepBarcode.FooterStyle = style19;
            this.cmb_RepBarcode.GapHeight = 2;
            this.cmb_RepBarcode.HeadingStyle = style20;
            this.cmb_RepBarcode.HighLightRowStyle = style21;
            this.cmb_RepBarcode.ItemHeight = 15;
            this.cmb_RepBarcode.Location = new System.Drawing.Point(755, 106);
            this.cmb_RepBarcode.MatchEntryTimeout = ((long)(2000));
            this.cmb_RepBarcode.MaxDropDownItems = ((short)(5));
            this.cmb_RepBarcode.MaxLength = 32767;
            this.cmb_RepBarcode.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_RepBarcode.Name = "cmb_RepBarcode";
            this.cmb_RepBarcode.OddRowStyle = style22;
            this.cmb_RepBarcode.PartialRightColumn = false;
            this.cmb_RepBarcode.PropBag = resources.GetString("cmb_RepBarcode.PropBag");
            this.cmb_RepBarcode.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_RepBarcode.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_RepBarcode.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_RepBarcode.SelectedStyle = style23;
            this.cmb_RepBarcode.Size = new System.Drawing.Size(220, 20);
            this.cmb_RepBarcode.Style = style24;
            this.cmb_RepBarcode.TabIndex = 534;
            // 
            // lbl_RepBarcode
            // 
            this.lbl_RepBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_RepBarcode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RepBarcode.ImageIndex = 0;
            this.lbl_RepBarcode.ImageList = this.img_Label;
            this.lbl_RepBarcode.Location = new System.Drawing.Point(654, 106);
            this.lbl_RepBarcode.Name = "lbl_RepBarcode";
            this.lbl_RepBarcode.Size = new System.Drawing.Size(100, 21);
            this.lbl_RepBarcode.TabIndex = 535;
            this.lbl_RepBarcode.Text = "RepBarcode";
            this.lbl_RepBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_container
            // 
            this.cmb_container.AddItemCols = 0;
            this.cmb_container.AddItemSeparator = ';';
            this.cmb_container.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_container.Caption = "";
            this.cmb_container.CaptionHeight = 17;
            this.cmb_container.CaptionStyle = style25;
            this.cmb_container.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_container.ColumnCaptionHeight = 18;
            this.cmb_container.ColumnFooterHeight = 18;
            this.cmb_container.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_container.ContentHeight = 16;
            this.cmb_container.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_container.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_container.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_container.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_container.EditorHeight = 16;
            this.cmb_container.EvenRowStyle = style26;
            this.cmb_container.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_container.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_container.FooterStyle = style27;
            this.cmb_container.GapHeight = 2;
            this.cmb_container.HeadingStyle = style28;
            this.cmb_container.HighLightRowStyle = style29;
            this.cmb_container.ItemHeight = 15;
            this.cmb_container.Location = new System.Drawing.Point(109, 128);
            this.cmb_container.MatchEntryTimeout = ((long)(2000));
            this.cmb_container.MaxDropDownItems = ((short)(5));
            this.cmb_container.MaxLength = 32767;
            this.cmb_container.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_container.Name = "cmb_container";
            this.cmb_container.OddRowStyle = style30;
            this.cmb_container.PartialRightColumn = false;
            this.cmb_container.PropBag = resources.GetString("cmb_container.PropBag");
            this.cmb_container.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_container.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_container.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_container.SelectedStyle = style31;
            this.cmb_container.Size = new System.Drawing.Size(220, 20);
            this.cmb_container.Style = style32;
            this.cmb_container.TabIndex = 9;
            // 
            // lbl_Container
            // 
            this.lbl_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Container.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Container.ImageIndex = 0;
            this.lbl_Container.ImageList = this.img_Label;
            this.lbl_Container.Location = new System.Drawing.Point(8, 128);
            this.lbl_Container.Name = "lbl_Container";
            this.lbl_Container.Size = new System.Drawing.Size(100, 21);
            this.lbl_Container.TabIndex = 50;
            this.lbl_Container.Text = "Container";
            this.lbl_Container.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_style
            // 
            this.cmb_style.AccessibleDescription = "";
            this.cmb_style.AccessibleName = "";
            this.cmb_style.AddItemCols = 0;
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style33;
            this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_style.ColumnCaptionHeight = 18;
            this.cmb_style.ColumnFooterHeight = 18;
            this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_style.ContentHeight = 17;
            this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_style.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_style.EditorHeight = 17;
            this.cmb_style.EvenRowStyle = style34;
            this.cmb_style.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style35;
            this.cmb_style.GapHeight = 2;
            this.cmb_style.HeadingStyle = style36;
            this.cmb_style.HighLightRowStyle = style37;
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(512, 106);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style38;
            this.cmb_style.PartialRightColumn = false;
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style39;
            this.cmb_style.Size = new System.Drawing.Size(140, 21);
            this.cmb_style.Style = style40;
            this.cmb_style.TabIndex = 533;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            // 
            // cmb_user
            // 
            this.cmb_user.AddItemCols = 0;
            this.cmb_user.AddItemSeparator = ';';
            this.cmb_user.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_user.Caption = "";
            this.cmb_user.CaptionHeight = 17;
            this.cmb_user.CaptionStyle = style41;
            this.cmb_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_user.ColumnCaptionHeight = 18;
            this.cmb_user.ColumnFooterHeight = 18;
            this.cmb_user.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_user.ContentHeight = 16;
            this.cmb_user.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_user.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_user.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_user.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_user.EditorHeight = 16;
            this.cmb_user.EvenRowStyle = style42;
            this.cmb_user.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FooterStyle = style43;
            this.cmb_user.GapHeight = 2;
            this.cmb_user.HeadingStyle = style44;
            this.cmb_user.HighLightRowStyle = style45;
            this.cmb_user.ItemHeight = 15;
            this.cmb_user.Location = new System.Drawing.Point(432, 62);
            this.cmb_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_user.MaxDropDownItems = ((short)(5));
            this.cmb_user.MaxLength = 32767;
            this.cmb_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.OddRowStyle = style46;
            this.cmb_user.PartialRightColumn = false;
            this.cmb_user.PropBag = resources.GetString("cmb_user.PropBag");
            this.cmb_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_user.SelectedStyle = style47;
            this.cmb_user.Size = new System.Drawing.Size(104, 20);
            this.cmb_user.Style = style48;
            this.cmb_user.TabIndex = 13;
            this.cmb_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_user_KeyPress);
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ImageIndex = 0;
            this.lbl_user.ImageList = this.img_Label;
            this.lbl_user.Location = new System.Drawing.Point(331, 62);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_user.TabIndex = 50;
            this.lbl_user.Text = "User / Reason";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ScanType
            // 
            this.cmb_ScanType.AddItemCols = 0;
            this.cmb_ScanType.AddItemSeparator = ';';
            this.cmb_ScanType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_ScanType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ScanType.Caption = "";
            this.cmb_ScanType.CaptionHeight = 17;
            this.cmb_ScanType.CaptionStyle = style49;
            this.cmb_ScanType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ScanType.ColumnCaptionHeight = 18;
            this.cmb_ScanType.ColumnFooterHeight = 18;
            this.cmb_ScanType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ScanType.ContentHeight = 16;
            this.cmb_ScanType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ScanType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ScanType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_ScanType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ScanType.EditorHeight = 16;
            this.cmb_ScanType.EvenRowStyle = style50;
            this.cmb_ScanType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_ScanType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ScanType.FooterStyle = style51;
            this.cmb_ScanType.GapHeight = 2;
            this.cmb_ScanType.HeadingStyle = style52;
            this.cmb_ScanType.HighLightRowStyle = style53;
            this.cmb_ScanType.ItemHeight = 15;
            this.cmb_ScanType.Location = new System.Drawing.Point(755, 84);
            this.cmb_ScanType.MatchEntryTimeout = ((long)(2000));
            this.cmb_ScanType.MaxDropDownItems = ((short)(5));
            this.cmb_ScanType.MaxLength = 32767;
            this.cmb_ScanType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ScanType.Name = "cmb_ScanType";
            this.cmb_ScanType.OddRowStyle = style54;
            this.cmb_ScanType.PartialRightColumn = false;
            this.cmb_ScanType.PropBag = resources.GetString("cmb_ScanType.PropBag");
            this.cmb_ScanType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ScanType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ScanType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ScanType.SelectedStyle = style55;
            this.cmb_ScanType.Size = new System.Drawing.Size(220, 20);
            this.cmb_ScanType.Style = style56;
            this.cmb_ScanType.TabIndex = 12;
            // 
            // lbl_ScanType
            // 
            this.lbl_ScanType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ScanType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScanType.ImageIndex = 0;
            this.lbl_ScanType.ImageList = this.img_Label;
            this.lbl_ScanType.Location = new System.Drawing.Point(654, 84);
            this.lbl_ScanType.Name = "lbl_ScanType";
            this.lbl_ScanType.Size = new System.Drawing.Size(100, 21);
            this.lbl_ScanType.TabIndex = 56;
            this.lbl_ScanType.Text = "Incoming Type";
            this.lbl_ScanType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shipFactory
            // 
            this.cmb_shipFactory.AddItemCols = 0;
            this.cmb_shipFactory.AddItemSeparator = ';';
            this.cmb_shipFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipFactory.Caption = "";
            this.cmb_shipFactory.CaptionHeight = 17;
            this.cmb_shipFactory.CaptionStyle = style57;
            this.cmb_shipFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipFactory.ColumnCaptionHeight = 18;
            this.cmb_shipFactory.ColumnFooterHeight = 18;
            this.cmb_shipFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipFactory.ContentHeight = 16;
            this.cmb_shipFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipFactory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipFactory.EditorHeight = 16;
            this.cmb_shipFactory.EvenRowStyle = style58;
            this.cmb_shipFactory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipFactory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipFactory.FooterStyle = style59;
            this.cmb_shipFactory.GapHeight = 2;
            this.cmb_shipFactory.HeadingStyle = style60;
            this.cmb_shipFactory.HighLightRowStyle = style61;
            this.cmb_shipFactory.ItemHeight = 15;
            this.cmb_shipFactory.Location = new System.Drawing.Point(109, 40);
            this.cmb_shipFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipFactory.MaxDropDownItems = ((short)(5));
            this.cmb_shipFactory.MaxLength = 32767;
            this.cmb_shipFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipFactory.Name = "cmb_shipFactory";
            this.cmb_shipFactory.OddRowStyle = style62;
            this.cmb_shipFactory.PartialRightColumn = false;
            this.cmb_shipFactory.PropBag = resources.GetString("cmb_shipFactory.PropBag");
            this.cmb_shipFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipFactory.SelectedStyle = style63;
            this.cmb_shipFactory.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipFactory.Style = style64;
            this.cmb_shipFactory.TabIndex = 1;
            this.cmb_shipFactory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_MoveNextByFocus);
            this.cmb_shipFactory.TextChanged += new System.EventHandler(this.cmb_shipFactory_TextChanged);
            this.cmb_shipFactory.SelectedValueChanged += new System.EventHandler(this.cmb_shipFactory_SelectedValueChanged);
            // 
            // cmb_inOutType
            // 
            this.cmb_inOutType.AddItemCols = 0;
            this.cmb_inOutType.AddItemSeparator = ';';
            this.cmb_inOutType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_inOutType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inOutType.Caption = "";
            this.cmb_inOutType.CaptionHeight = 17;
            this.cmb_inOutType.CaptionStyle = style65;
            this.cmb_inOutType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inOutType.ColumnCaptionHeight = 18;
            this.cmb_inOutType.ColumnFooterHeight = 18;
            this.cmb_inOutType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inOutType.ContentHeight = 16;
            this.cmb_inOutType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inOutType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inOutType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_inOutType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inOutType.EditorHeight = 16;
            this.cmb_inOutType.EvenRowStyle = style66;
            this.cmb_inOutType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_inOutType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_inOutType.FooterStyle = style67;
            this.cmb_inOutType.GapHeight = 2;
            this.cmb_inOutType.HeadingStyle = style68;
            this.cmb_inOutType.HighLightRowStyle = style69;
            this.cmb_inOutType.ItemHeight = 15;
            this.cmb_inOutType.Location = new System.Drawing.Point(432, 40);
            this.cmb_inOutType.MatchEntryTimeout = ((long)(2000));
            this.cmb_inOutType.MaxDropDownItems = ((short)(5));
            this.cmb_inOutType.MaxLength = 32767;
            this.cmb_inOutType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inOutType.Name = "cmb_inOutType";
            this.cmb_inOutType.OddRowStyle = style70;
            this.cmb_inOutType.PartialRightColumn = false;
            this.cmb_inOutType.PropBag = resources.GetString("cmb_inOutType.PropBag");
            this.cmb_inOutType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inOutType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inOutType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inOutType.SelectedStyle = style71;
            this.cmb_inOutType.Size = new System.Drawing.Size(220, 20);
            this.cmb_inOutType.Style = style72;
            this.cmb_inOutType.TabIndex = 2;
            this.cmb_inOutType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_MoveNextByFocus);
            // 
            // cmb_barcodeState
            // 
            this.cmb_barcodeState.AddItemCols = 0;
            this.cmb_barcodeState.AddItemSeparator = ';';
            this.cmb_barcodeState.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_barcodeState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_barcodeState.Caption = "";
            this.cmb_barcodeState.CaptionHeight = 17;
            this.cmb_barcodeState.CaptionStyle = style73;
            this.cmb_barcodeState.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_barcodeState.ColumnCaptionHeight = 18;
            this.cmb_barcodeState.ColumnFooterHeight = 18;
            this.cmb_barcodeState.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_barcodeState.ContentHeight = 16;
            this.cmb_barcodeState.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_barcodeState.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_barcodeState.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_barcodeState.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_barcodeState.EditorHeight = 16;
            this.cmb_barcodeState.EvenRowStyle = style74;
            this.cmb_barcodeState.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_barcodeState.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barcodeState.FooterStyle = style75;
            this.cmb_barcodeState.GapHeight = 2;
            this.cmb_barcodeState.HeadingStyle = style76;
            this.cmb_barcodeState.HighLightRowStyle = style77;
            this.cmb_barcodeState.ItemHeight = 15;
            this.cmb_barcodeState.Location = new System.Drawing.Point(755, 40);
            this.cmb_barcodeState.MatchEntryTimeout = ((long)(2000));
            this.cmb_barcodeState.MaxDropDownItems = ((short)(5));
            this.cmb_barcodeState.MaxLength = 32767;
            this.cmb_barcodeState.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_barcodeState.Name = "cmb_barcodeState";
            this.cmb_barcodeState.OddRowStyle = style78;
            this.cmb_barcodeState.PartialRightColumn = false;
            this.cmb_barcodeState.PropBag = resources.GetString("cmb_barcodeState.PropBag");
            this.cmb_barcodeState.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_barcodeState.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_barcodeState.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_barcodeState.SelectedStyle = style79;
            this.cmb_barcodeState.Size = new System.Drawing.Size(220, 20);
            this.cmb_barcodeState.Style = style80;
            this.cmb_barcodeState.TabIndex = 3;
            this.cmb_barcodeState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_MoveNextByFocus);
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 62);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 4;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(231, 62);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 5;
            this.dpick_to.CloseUp += new System.EventHandler(this.dpick_to_CloseUp);
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(432, 84);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 6;
            this.txt_vendorCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_vendorCode_KeyUp);
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemCols = 0;
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style81;
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
            this.cmb_vendor.EvenRowStyle = style82;
            this.cmb_vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style83;
            this.cmb_vendor.GapHeight = 2;
            this.cmb_vendor.HeadingStyle = style84;
            this.cmb_vendor.HighLightRowStyle = style85;
            this.cmb_vendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(512, 84);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style86;
            this.cmb_vendor.PartialRightColumn = false;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style87;
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style88;
            this.cmb_vendor.TabIndex = 7;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            // 
            // cmb_location
            // 
            this.cmb_location.AddItemCols = 0;
            this.cmb_location.AddItemSeparator = ';';
            this.cmb_location.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_location.Caption = "";
            this.cmb_location.CaptionHeight = 17;
            this.cmb_location.CaptionStyle = style89;
            this.cmb_location.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_location.ColumnCaptionHeight = 18;
            this.cmb_location.ColumnFooterHeight = 18;
            this.cmb_location.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_location.ContentHeight = 16;
            this.cmb_location.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_location.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_location.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_location.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_location.EditorHeight = 16;
            this.cmb_location.EvenRowStyle = style90;
            this.cmb_location.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_location.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_location.FooterStyle = style91;
            this.cmb_location.GapHeight = 2;
            this.cmb_location.HeadingStyle = style92;
            this.cmb_location.HighLightRowStyle = style93;
            this.cmb_location.ItemHeight = 15;
            this.cmb_location.Location = new System.Drawing.Point(755, 62);
            this.cmb_location.MatchEntryTimeout = ((long)(2000));
            this.cmb_location.MaxDropDownItems = ((short)(5));
            this.cmb_location.MaxLength = 32767;
            this.cmb_location.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_location.Name = "cmb_location";
            this.cmb_location.OddRowStyle = style94;
            this.cmb_location.PartialRightColumn = false;
            this.cmb_location.PropBag = resources.GetString("cmb_location.PropBag");
            this.cmb_location.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_location.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_location.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_location.SelectedStyle = style95;
            this.cmb_location.Size = new System.Drawing.Size(220, 20);
            this.cmb_location.Style = style96;
            this.cmb_location.TabIndex = 8;
            this.cmb_location.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_MoveNextByFocus);
            // 
            // cmb_shipNo
            // 
            this.cmb_shipNo.AddItemCols = 0;
            this.cmb_shipNo.AddItemSeparator = ';';
            this.cmb_shipNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipNo.Caption = "";
            this.cmb_shipNo.CaptionHeight = 17;
            this.cmb_shipNo.CaptionStyle = style97;
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
            this.cmb_shipNo.EvenRowStyle = style98;
            this.cmb_shipNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipNo.FooterStyle = style99;
            this.cmb_shipNo.GapHeight = 2;
            this.cmb_shipNo.HeadingStyle = style100;
            this.cmb_shipNo.HighLightRowStyle = style101;
            this.cmb_shipNo.ItemHeight = 15;
            this.cmb_shipNo.Location = new System.Drawing.Point(109, 106);
            this.cmb_shipNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipNo.MaxDropDownItems = ((short)(5));
            this.cmb_shipNo.MaxLength = 32767;
            this.cmb_shipNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipNo.Name = "cmb_shipNo";
            this.cmb_shipNo.OddRowStyle = style102;
            this.cmb_shipNo.PartialRightColumn = false;
            this.cmb_shipNo.PropBag = resources.GetString("cmb_shipNo.PropBag");
            this.cmb_shipNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipNo.SelectedStyle = style103;
            this.cmb_shipNo.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipNo.Style = style104;
            this.cmb_shipNo.TabIndex = 9;
            this.cmb_shipNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_MoveNextByFocus);
            // 
            // cmb_shipType
            // 
            this.cmb_shipType.AddItemCols = 0;
            this.cmb_shipType.AddItemSeparator = ';';
            this.cmb_shipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipType.Caption = "";
            this.cmb_shipType.CaptionHeight = 17;
            this.cmb_shipType.CaptionStyle = style105;
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
            this.cmb_shipType.EvenRowStyle = style106;
            this.cmb_shipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipType.FooterStyle = style107;
            this.cmb_shipType.GapHeight = 2;
            this.cmb_shipType.HeadingStyle = style108;
            this.cmb_shipType.HighLightRowStyle = style109;
            this.cmb_shipType.ItemHeight = 15;
            this.cmb_shipType.Location = new System.Drawing.Point(109, 84);
            this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipType.MaxDropDownItems = ((short)(5));
            this.cmb_shipType.MaxLength = 32767;
            this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipType.Name = "cmb_shipType";
            this.cmb_shipType.OddRowStyle = style110;
            this.cmb_shipType.PartialRightColumn = false;
            this.cmb_shipType.PropBag = resources.GetString("cmb_shipType.PropBag");
            this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipType.SelectedStyle = style111;
            this.cmb_shipType.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipType.Style = style112;
            this.cmb_shipType.TabIndex = 12;
            this.cmb_shipType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_MoveNextByFocus);
            this.cmb_shipType.SelectedValueChanged += new System.EventHandler(this.cmb_shipType_SelectedValueChanged);
            // 
            // txt_qty
            // 
            this.txt_qty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_qty.Location = new System.Drawing.Point(432, 128);
            this.txt_qty.MaxLength = 10;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.ReadOnly = true;
            this.txt_qty.Size = new System.Drawing.Size(220, 21);
            this.txt_qty.TabIndex = 363;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_qty
            // 
            this.lbl_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_qty.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.ImageIndex = 0;
            this.lbl_qty.ImageList = this.img_Label;
            this.lbl_qty.Location = new System.Drawing.Point(331, 128);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(100, 21);
            this.lbl_qty.TabIndex = 365;
            this.lbl_qty.Text = "N / * / S";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_InOutType
            // 
            this.lbl_InOutType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_InOutType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InOutType.ImageIndex = 1;
            this.lbl_InOutType.ImageList = this.img_Label;
            this.lbl_InOutType.Location = new System.Drawing.Point(331, 40);
            this.lbl_InOutType.Name = "lbl_InOutType";
            this.lbl_InOutType.Size = new System.Drawing.Size(100, 21);
            this.lbl_InOutType.TabIndex = 50;
            this.lbl_InOutType.Text = "In / Out Scan";
            this.lbl_InOutType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipType
            // 
            this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipType.ImageIndex = 0;
            this.lbl_shipType.ImageList = this.img_Label;
            this.lbl_shipType.Location = new System.Drawing.Point(8, 84);
            this.lbl_shipType.Name = "lbl_shipType";
            this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipType.TabIndex = 56;
            this.lbl_shipType.Text = "Ship Type";
            this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_location
            // 
            this.lbl_location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_location.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location.ImageIndex = 0;
            this.lbl_location.ImageList = this.img_Label;
            this.lbl_location.Location = new System.Drawing.Point(654, 62);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(100, 21);
            this.lbl_location.TabIndex = 56;
            this.lbl_location.Text = "Location";
            this.lbl_location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(331, 106);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 365;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(331, 84);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 365;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_excep_mark
            // 
            this.lbl_excep_mark.Location = new System.Drawing.Point(211, 62);
            this.lbl_excep_mark.Name = "lbl_excep_mark";
            this.lbl_excep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_excep_mark.Size = new System.Drawing.Size(16, 16);
            this.lbl_excep_mark.TabIndex = 362;
            this.lbl_excep_mark.Text = "~";
            this.lbl_excep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 143);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_barcodeState
            // 
            this.lbl_barcodeState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_barcodeState.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barcodeState.ImageIndex = 0;
            this.lbl_barcodeState.ImageList = this.img_Label;
            this.lbl_barcodeState.Location = new System.Drawing.Point(654, 40);
            this.lbl_barcodeState.Name = "lbl_barcodeState";
            this.lbl_barcodeState.Size = new System.Drawing.Size(100, 21);
            this.lbl_barcodeState.TabIndex = 50;
            this.lbl_barcodeState.Text = "Barcode State";
            this.lbl_barcodeState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipNo
            // 
            this.lbl_shipNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipNo.ImageIndex = 0;
            this.lbl_shipNo.ImageList = this.img_Label;
            this.lbl_shipNo.Location = new System.Drawing.Point(8, 106);
            this.lbl_shipNo.Name = "lbl_shipNo";
            this.lbl_shipNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipNo.TabIndex = 50;
            this.lbl_shipNo.Text = "Ship No";
            this.lbl_shipNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 142);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // lbl_shipFactory
            // 
            this.lbl_shipFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipFactory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipFactory.ImageIndex = 1;
            this.lbl_shipFactory.ImageList = this.img_Label;
            this.lbl_shipFactory.Location = new System.Drawing.Point(8, 40);
            this.lbl_shipFactory.Name = "lbl_shipFactory";
            this.lbl_shipFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipFactory.TabIndex = 50;
            this.lbl_shipFactory.Text = "Ship Factory";
            this.lbl_shipFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(891, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 118);
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
            this.label2.Text = "      Barcode Info";
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
            this.pic_head5.Location = new System.Drawing.Point(0, 143);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 132);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // txt_styleCode
            // 
            this.txt_styleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCode.Location = new System.Drawing.Point(432, 106);
            this.txt_styleCode.MaxLength = 10;
            this.txt_styleCode.Name = "txt_styleCode";
            this.txt_styleCode.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCode.TabIndex = 10;
            this.txt_styleCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCode_KeyUp);
            // 
            // ctx_bar
            // 
            this.ctx_bar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_AllSelect,
            this.mnu_AllDeselect,
            this.mnu_bar2,
            this.mnu_Outgoing,
            this.mnu_repChange,
            this.menuItem1,
            this.menuItem2,
            this.mnu_Outside});
            // 
            // mnu_AllSelect
            // 
            this.mnu_AllSelect.Index = 0;
            this.mnu_AllSelect.Text = "All Select";
            this.mnu_AllSelect.Click += new System.EventHandler(this.mnu_AllSelect_Click);
            // 
            // mnu_AllDeselect
            // 
            this.mnu_AllDeselect.Index = 1;
            this.mnu_AllDeselect.Text = "Deselect";
            this.mnu_AllDeselect.Click += new System.EventHandler(this.mnu_AllDeselect_Click);
            // 
            // mnu_bar2
            // 
            this.mnu_bar2.Index = 2;
            this.mnu_bar2.Text = "-";
            // 
            // mnu_Outgoing
            // 
            this.mnu_Outgoing.Index = 3;
            this.mnu_Outgoing.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_VesselOut,
            this.mnu_ContainerDoDoOut,
            this.menuItem8,
            this.mnu_AFOut,
            this.mnu_HCOut,
            this.mnu_DoDoOut});
            this.mnu_Outgoing.Text = "Outgoing";
            // 
            // mnu_VesselOut
            // 
            this.mnu_VesselOut.Index = 0;
            this.mnu_VesselOut.Text = "10 - Vessel";
            this.mnu_VesselOut.Click += new System.EventHandler(this.mnu_VesselOut_Click);
            // 
            // mnu_ContainerDoDoOut
            // 
            this.mnu_ContainerDoDoOut.Index = 1;
            this.mnu_ContainerDoDoOut.Text = "20 - Container Door To Door";
            this.mnu_ContainerDoDoOut.Click += new System.EventHandler(this.mnu_ContainerDoDoOut_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "-";
            // 
            // mnu_AFOut
            // 
            this.mnu_AFOut.Index = 3;
            this.mnu_AFOut.Text = "30 - Air Flight";
            this.mnu_AFOut.Click += new System.EventHandler(this.mnu_AFOut_Click);
            // 
            // mnu_HCOut
            // 
            this.mnu_HCOut.Index = 4;
            this.mnu_HCOut.Text = "40 - Hand Carry";
            this.mnu_HCOut.Click += new System.EventHandler(this.mnu_HCOut_Click);
            // 
            // mnu_DoDoOut
            // 
            this.mnu_DoDoOut.Index = 5;
            this.mnu_DoDoOut.Text = "50 - Door To Door";
            this.mnu_DoDoOut.Click += new System.EventHandler(this.mnu_DoDoOut_Click);
            // 
            // mnu_repChange
            // 
            this.mnu_repChange.Index = 4;
            this.mnu_repChange.Text = "Represent Barcode Change";
            this.mnu_repChange.Click += new System.EventHandler(this.mnu_repChange_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 5;
            this.menuItem1.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 6;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_rep,
            this.mnu_detaile});
            this.menuItem2.Text = "Tree View Option";
            // 
            // mnu_rep
            // 
            this.mnu_rep.Index = 0;
            this.mnu_rep.Text = "Represent Barcode";
            this.mnu_rep.Click += new System.EventHandler(this.mnu_rep_Click);
            // 
            // mnu_detaile
            // 
            this.mnu_detaile.Index = 1;
            this.mnu_detaile.Text = "Barcode Detaile";
            this.mnu_detaile.Click += new System.EventHandler(this.mnu_detaile_Click);
            // 
            // mnu_Outside
            // 
            this.mnu_Outside.Index = 7;
            this.mnu_Outside.Text = "Outside Information";
            this.mnu_Outside.Click += new System.EventHandler(this.mnu_Outside_Click);
            // 
            // img_Type
            // 
            this.img_Type.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Type.ImageStream")));
            this.img_Type.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Type.Images.SetKeyName(0, "");
            this.img_Type.Images.SetKeyName(1, "");
            this.img_Type.Images.SetKeyName(2, "");
            this.img_Type.Images.SetKeyName(3, "");
            this.img_Type.Images.SetKeyName(4, "");
            this.img_Type.Images.SetKeyName(5, "");
            // 
            // Form_BS_Scan_InOut
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BS_Scan_InOut";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BS_Scan_InOut_Closing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_bar)).EndInit();
            this.pnl_main.ResumeLayout(false);
            this.pnl_btn.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_matType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_RepBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_container)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ScanType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inOutType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_barcodeState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
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

		private void fgrid_bar_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess(e);
		}

		private void fgrid_bar_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess(e);
		}
		
		private void fgrid_bar_BeforeMouseDown(object sender, C1.Win.C1FlexGrid.BeforeMouseDownEventArgs e)
		{
			if (fgrid_bar.MouseCol == _checkCol)
				fgrid_bar.Rows[fgrid_bar.MouseRow].AllowEditing = true;
		}

		private void fgrid_bar_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (this.Etc_ProvisoValidateCheck(_validate_context))
				this.Grid_BarClickProcess(e);
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
				this.Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.UPDATE_SBS_BAR_CODE_REP();
			}
			/*
			if (GetSelectedRows() > 0)
					this.Tbtn_SaveProcess(false);
			*/
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

		private void Form_BS_Scan_InOut_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_bar.Rows.Fixed < fgrid_bar.Rows.Count)
			{
				string vTemp = fgrid_bar.GetCellRange(fgrid_bar.Rows.Fixed, 0, fgrid_bar.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}
		}

		private void txt_vendorCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.Txt_VendorCodeKeyUpProcess();
				ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyValue);
			}
		}

		private void txt_styleCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.Txt_StyleCodeKeyUpProcess();
			}
		}

		private void cmb_inOutType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (_doSearch)
			{
				this.Cmb_InOutTypeSelectProcess();
				this.Tbtn_SearchProcess();
			}
		}

		private void cmb_shipNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		#region 버튼이벤트

		private void btn_scan_Click(object sender, System.EventArgs e)
		{
			if (this.Etc_ProvisoValidateCheck(_validate_scan))
				this.Btn_ScanClickProcess(null);
		}

		private void btn_change_Click(object sender, System.EventArgs e)
		{
			if (this.Etc_ProvisoValidateCheck(_validate_change))
				this.Btn_ChangeClick();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			string vScanType = cmb_inOutType.GetItemText(cmb_inOutType.SelectedIndex, 1);

			if (this.Etc_ProvisoValidateCheck(_validate_cancel))
				if (ClassLib.ComFunction.User_Message("Do you want to cancel " + vScanType + "?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.Btn_CancelClickProcess();
		}

		private void rad_header_CheckedChanged(object sender, System.EventArgs e)
		{
			fgrid_bar.Tree.Show(1);
		}

		private void rag_detaile_CheckedChanged(object sender, System.EventArgs e)
		{
			fgrid_bar.Tree.Show(2);
		}

		private void rad_all_CheckedChanged(object sender, System.EventArgs e)
		{
			fgrid_bar.Tree.Show(3);		
		}

		#endregion

		#region 컨텍스트 메뉴

		private void mnu_SelectRange_Click(object sender, System.EventArgs e)
		{
			Mnu_SelectRangeProcess(true);
		}
		
		private void mnu_Deselect_Click(object sender, System.EventArgs e)
		{
			Mnu_SelectRangeProcess(false);
		}

		private void mnu_AllSelect_Click(object sender, System.EventArgs e)
		{
			string vScanType = cmb_inOutType.SelectedValue.ToString();
			
			if (vScanType.Equals(ClassLib.ComVar.Incoming))
			{
				Chk_AllCheckedProcess(true, null, null);
			}
			else
			{
				string vContainer = ( fgrid_bar[fgrid_bar.Row, _typeCol] == null ) ? null : fgrid_bar[fgrid_bar.Row, _containerCol].ToString();

				if (vContainer.Equals(""))
				{
					vContainer = "";
				}
				else
				{
					vContainer = ( fgrid_bar[fgrid_bar.Row, _typeCol] == null ) ? null : fgrid_bar[fgrid_bar.Row, _containerCol].ToString();
				}

				Chk_AllCheckedProcess(true, null, vContainer);
			}

		}

		private void mnu_AllDeselect_Click(object sender, System.EventArgs e)
		{
			for (int vRow = fgrid_bar.Rows.Fixed ; vRow < fgrid_bar.Rows.Count ; vRow++)
			{
				fgrid_bar[vRow, _checkCol] = false;
			}
			//Chk_AllCheckedProcess(false, null, null);
		}

		private void mnu_VesselOut_Click(object sender, System.EventArgs e)
		{
			Mnu_Outgoing_ContainerProcess(sender);
		}

		private void mnu_ContainerDoDoOut_Click(object sender, System.EventArgs e)
		{
			Mnu_Outgoing_ContainerProcess(sender);
		}
		
		private void mnu_DoDoOut_Click(object sender, System.EventArgs e)
		{
			Mnu_Outgoing_EtcProcess(sender);
		}

		private void mnu_AFOut_Click(object sender, System.EventArgs e)
		{
			Mnu_Outgoing_EtcProcess(sender);
		}

		private void mnu_HCOut_Click(object sender, System.EventArgs e)
		{
			Mnu_Outgoing_EtcProcess(sender);
		}

		private void mnu_repChange_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_repChange))
				Mnu_RepChangeProcess();
		}

		private void mnu_rep_Click(object sender, System.EventArgs e)
		{
			fgrid_bar.Tree.Show(1);
		}

		private void mnu_detaile_Click(object sender, System.EventArgs e)
		{
			fgrid_bar.Tree.Show(3);		
		}

		
		private void mnu_Outside_Click(object sender, System.EventArgs e)
		{
			Mnu_OutsideInformation();
		}

		#endregion

		#region 검색조건

		private void cmb_shipFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			ClearAll();
			Cmb_SetShipNo();
		}

		private void cmb_shipType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			_doSearch = false;
			Cmb_SetShipNo();
			_doSearch = true;
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			try
			{
				dpick_to.Value = dpick_from.Value;
				ClearAll();
				Cmb_SetShipNo();
				Cmb_SetContainer();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_from_CloseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dpick_to_CloseUp(object sender, System.EventArgs e)
		{
			Cmb_SetShipNo();
		}

		private void cmb_vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_VendorSelectedValueChangedProcess();
		}

		private void cmb_style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_StyleSelectedValueChangedProcess();
		}

		#endregion
	
		#region 입력이동

		private void Control_MoveNextByFocus(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
		}

		private void cmb_user_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
			{
				Tbtn_SearchProcess();
				cmb_shipFactory.Focus();
			}
		}

		#endregion

		#region 버튼효과

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

		// 전체 클리어
		private void ClearAll()
		{
			txt_qty.Text = "";
			if (fgrid_bar.Rows.Fixed < fgrid_bar.Rows.Count)
				fgrid_bar.ClearAll();
		}

		// 선적 번호 설정
		private void Cmb_SetShipNo()
		{
			try
			{
				_doSearch = false;

				DataTable vDt = SELECT_SBS_BAR_SHIPNO();
				COM.ComCtl.Set_ComboList(vDt, cmb_shipNo, 0, 0, true, false);
				vDt.Dispose();
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
			finally
			{
				_doSearch = true;
			}
		}

		// 컨테이너 세팅
		private void Cmb_SetContainer()
		{
			try
			{
				DataTable vDt = ClassLib.ComFunction.SELECT_SBS_SHIP_CONT_NO_LIST(cmb_shipFactory.SelectedValue.ToString(), dpick_from.Text.Replace("-", ""));
				COM.ComCtl.Set_ComboList(vDt, cmb_container, 2, 1, true, false);
				cmb_container.SelectedIndex = 0;
				vDt.Dispose();
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}

        // set grid color
		private void GridSetColor()
		{
			try
			{
				string vType = cmb_inOutType.SelectedValue.ToString();
				string vLevel = "";
				CellRange vRange;
				Color vColor;

				for (int vRow = fgrid_bar.Rows.Fixed ; vRow < fgrid_bar.Rows.Count ; vRow++)
				{
					vLevel = fgrid_bar[vRow, _levelCol].ToString();
					if (vLevel.Equals("1"))
					{
						vRange = fgrid_bar.GetCellRange(vRow, 1, vRow, fgrid_bar.Cols.Count - 1);
						vRange.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						vRange.StyleNew.Border.Style = BorderStyleEnum.Raised;

						string vStatus = ClassLib.ComFunction.NullToBlank(fgrid_bar[vRow, _stateCol]);
						
						if (vStatus.Equals("Not Scan"))
							vRange.StyleNew.ForeColor = Color.Red;
						else if (vStatus.Equals("Pre Scan"))
							vRange.StyleNew.ForeColor = Color.YellowGreen;

                        int vOutsideString = ClassLib.ComFunction.NullToBlank(fgrid_bar[vRow, (int)ClassLib.TBSBS_BAR_1.IxITEM]).ToString().IndexOf("<", 0);
						if (vOutsideString > 0)
							vRange.StyleNew.BackColor = Color.FromArgb(214, 250, 186); 

						string vOutside = ClassLib.ComFunction.NullToBlank(fgrid_bar[vRow, (int)ClassLib.TBSBS_BAR_1.IxPK_NO]).ToString().Substring(0, 1);
						if (vOutside.Equals("&"))
							vRange.StyleNew.BackColor = Color.PaleGoldenrod; 

						fgrid_bar.Rows[vRow].AllowEditing = false;
					}
					else if (vLevel.Equals("2"))
					{
						vRange = fgrid_bar.GetCellRange(vRow, (int)ClassLib.TBSBS_BAR_1.IxITEM + 1, vRow, fgrid_bar.Cols.Count - 1);
						if (fgrid_bar[vRow, _stateCol].ToString().Equals(ClassLib.ComVar.Scan))
						{
							vRange.StyleNew.BackColor = ClassLib.ComVar.RightBlue;
							fgrid_bar.Rows[vRow].AllowEditing = false;
							vColor = GetForeColor(vRow);
							if (vColor != Color.Empty)
								vRange.StyleNew.ForeColor = vColor;
							_scanCount++;
						}
						else if (fgrid_bar[vRow, _stateCol].ToString().Equals(ClassLib.ComVar.PreScan))
						{
							vRange.StyleNew.BackColor = Color.FromArgb(248, 247, 255);
							vColor = GetForeColor(vRow);
							if (vColor != Color.Empty)
								vRange.StyleNew.ForeColor = vColor;
							_preScanCount++;
						}
						else
						{
							vRange.StyleNew.BackColor = ClassLib.ComVar.Default;
							if (fgrid_bar[vRow, _seqCol] != null && fgrid_bar.Rows[vRow].Node.Level > 2)
							{
								vRange.StyleNew.ForeColor = Color.Red;
							}
							_notScanCount++;
						}
					}
					else if (vLevel.Equals("3"))
					{
						Node vNode = fgrid_bar.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent);
						if (!vNode.Row[_stateCol].ToString().Equals(ClassLib.ComVar.Scan))
							fgrid_bar.Rows[vRow].AllowEditing = false;
					}
				}
				txt_qty.Text = _notScanCount + " / " + _preScanCount + " / " + _scanCount;
				_notScanCount = _preScanCount = _scanCount = 0;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "GridSetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}

		private Color GetForeColor(int arg_row)
		{
			Color vColor = Color.Empty;

			if (fgrid_bar[arg_row, _typeCol].ToString().Equals("1"))
				vColor = Color.FromArgb(225, 113, 0);
			else if (fgrid_bar[arg_row, _typeCol].ToString().Equals("2"))
				vColor = Color.FromArgb(128, 0, 128);
			else if (fgrid_bar[arg_row, _typeCol].ToString().Equals("3"))
				vColor = Color.FromArgb(0, 128, 0);

			return vColor;
		}
        
		private void GridSetData_Incoming(int arg_UpDownFlag)
		{
			// UpDownFlag : 0 = Up, 1 = Down
			IEnumerator vEnum = _selectionRows.GetEnumerator();
			

			while (vEnum.MoveNext())
			{
				if (arg_UpDownFlag == 0)
				{
					fgrid_bar[(int)vEnum.Current, 0] = GetCUDFlag((int)vEnum.Current);
					fgrid_bar[(int)vEnum.Current, _scanYmdCol]	 = ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[0]);
					fgrid_bar[(int)vEnum.Current, _typeCol]		 = COM.ComVar.Parameter_PopUp[1];
					fgrid_bar[(int)vEnum.Current, _containerCol] = COM.ComVar.Parameter_PopUp[2];
					fgrid_bar[(int)vEnum.Current, _locationCol]	 = COM.ComVar.Parameter_PopUp[4];
					fgrid_bar[(int)vEnum.Current, _inStateCol] = (arg_UpDownFlag == 0) ? GetUpState(fgrid_bar[(int)vEnum.Current, _inStateCol].ToString()) : ClassLib.ComVar.NotScan;
				}
				else
				{
					if (fgrid_bar[(int)vEnum.Current, _outStateCol].ToString().Equals(ClassLib.ComVar.NotScan))
					{
						if (fgrid_bar.Rows[(int)vEnum.Current].Node.GetNode(NodeTypeEnum.FirstChild) == null)
						{
							fgrid_bar[(int)vEnum.Current, 0] = ClassLib.ComVar.Delete;
						}
						else
						{
							fgrid_bar[(int)vEnum.Current, _scanQtyCol] = 0;
							fgrid_bar[(int)vEnum.Current, 0] = ClassLib.ComVar.Update;
						}

						fgrid_bar[(int)vEnum.Current, _inStateCol] = (arg_UpDownFlag == 0) ? GetUpState(fgrid_bar[(int)vEnum.Current, _inStateCol].ToString()) : ClassLib.ComVar.NotScan;
					}
					else
					{
						ClassLib.ComFunction.User_Message("The selected block includes out scanned data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						break;
					}
				}
			}
		}

		private void GridSetData_Outgoing(int arg_UpDownFlag)
		{
			// UpDownFlag : 0 = Up, 1 = Down
			IEnumerator vEnum = _selectionRows.GetEnumerator();

			while (vEnum.MoveNext())
			{
				if (arg_UpDownFlag == 0)
				{
					fgrid_bar[(int)vEnum.Current, 0] = GetCUDFlag((int)vEnum.Current);
					fgrid_bar[(int)vEnum.Current, _scanYmdCol]	 = ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[0]);
					fgrid_bar[(int)vEnum.Current, _typeCol]		 = COM.ComVar.Parameter_PopUp[1];
					fgrid_bar[(int)vEnum.Current, _containerCol] = COM.ComVar.Parameter_PopUp[2];
					//fgrid_bar[(int)vEnum.Current, _weightCol]	 = COM.ComVar.Parameter_PopUp[3];
				}
				else
				{
					if (!fgrid_bar[(int)vEnum.Current, _outStateCol].ToString().Equals(ClassLib.ComVar.NotScan))
					{
						if (fgrid_bar.Rows[(int)vEnum.Current].Node.GetNode(NodeTypeEnum.FirstChild) == null)
							fgrid_bar[(int)vEnum.Current, 0] = ClassLib.ComVar.Delete;
						else
						{
							fgrid_bar[(int)vEnum.Current, _scanQtyCol] = 0;
							fgrid_bar[(int)vEnum.Current, 0] = ClassLib.ComVar.Update;
						}
					}
				}
				fgrid_bar[(int)vEnum.Current, _outStateCol] = (arg_UpDownFlag == 0) ? GetUpState(fgrid_bar[(int)vEnum.Current, _outStateCol].ToString()) : ClassLib.ComVar.NotScan;
			}
		}

		// get c/u/d flag from scan status
		private string GetCUDFlag(int arg_row)
		{
			string vResult = "";

			if (fgrid_bar[arg_row, _stateCol].ToString().Equals(ClassLib.ComVar.NotScan))
				vResult = ClassLib.ComVar.Insert;
			else if (fgrid_bar[arg_row, _stateCol].ToString().Equals(ClassLib.ComVar.PreScan))
				vResult = ClassLib.ComVar.Update;

			return vResult;
		}
        
		// get next status from scan status
		private string GetUpState(string arg_state)
		{
			string vState = arg_state;
			if (arg_state.Equals(ClassLib.ComVar.NotScan))
				vState = ClassLib.ComVar.PreScan;
			else if (arg_state.Equals(ClassLib.ComVar.PreScan))
				vState = ClassLib.ComVar.Scan;

			return vState;
		}
		
		// check box set child node
		private void SelectionChilds(int arg_row)
		{
			Node vParent  = fgrid_bar.Rows[arg_row].Node;

			if (vParent.GetNode(NodeTypeEnum.FirstChild) == null)	
			{
				fgrid_bar[arg_row, _checkCol] = false;
				return;
			}

			Row vStartRow = vParent.GetNode(NodeTypeEnum.FirstChild).Row;
			Node vEndNode = vParent.GetNode(NodeTypeEnum.NextSibling);
			int vEndIndex = (vEndNode == null) ? fgrid_bar.Rows.Count - 1 : vEndNode.Row.Index - 1;

			//string vFlag = "false";

			for (int i = vStartRow.Index ; i <= vEndIndex ; i++)
				//if (fgrid_bar.Rows[i].AllowEditing)
				{
					fgrid_bar[i, _checkCol] = fgrid_bar[arg_row, _checkCol];
					//vFlag = ClassLib.ComFunction.NullToBlank(fgrid_bar[arg_row, _checkCol]);
				}

			//fgrid_bar[arg_row, _checkCol] = vFlag;
		}

		private void CheckFlag()
		{
			for (int vRow = fgrid_bar.Rows.Fixed ; vRow < fgrid_bar.Rows.Count ; vRow++)
				if ((bool)(fgrid_bar[vRow, _checkCol]))
					fgrid_bar[vRow, 0] = GetCUDFlag(vRow);
		}

		// 체크된 열번호 검색
		private int GetSelectedRows()
		{
			if (fgrid_bar.Rows.Count <= fgrid_bar.Rows.Fixed)	return 0;

			_selectionRows.Clear();
//			string vFlags = fgrid_bar.GetCellRange(fgrid_bar.Rows.Fixed, _checkCol - 1, fgrid_bar.Rows.Count - 1, _checkCol).Clip;
//			
//			int vIndex = 0;
//			vFlags = vFlags.Replace("\r", "");
//			vFlags = vFlags.Replace("\t", "");
//			vFlags = vFlags.Replace("1False", "0");
//			vFlags = vFlags.Replace("1True", "0");
//			vFlags = vFlags.Replace("2False", "0");
//			vFlags = vFlags.Replace("2True", "1");
//			vFlags = vFlags.Replace("3False", "0");
//			vFlags = vFlags.Replace("3True", "1");
//
//			while ((vIndex = vFlags.IndexOf("1", vIndex)) != -1)
//				this._selectionRows.Add(fgrid_bar.Rows.Fixed + vIndex++);
//
			int vRow = fgrid_bar.Rows.Fixed;

			while (vRow < fgrid_bar.Rows.Count)
			{
				if (fgrid_bar.Rows[vRow].Node.Level != 1 && Convert.ToBoolean(fgrid_bar[vRow, _checkCol]))
					_selectionRows.Add(vRow);
				vRow++;
			}

			return _selectionRows.Count;
		}

		// 외부 접근용 함수
		public void RunProcess(DateTime arg_date, object arg_shipType, object arg_shipNo)
		{
			this.Show();
			this.dpick_from.Value = arg_date;
			this.dpick_to.Value = arg_date;
			this.cmb_shipType.SelectedValue = arg_shipType;
			this.cmb_shipNo.SelectedValue = arg_shipNo;
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
            this.Text = "Scan Manager";
            lbl_MainTitle.Text = "Scan Manager";
            ClassLib.ComFunction.SetLangDic(this);
			// ClassLib.ComFunction.Init_MenuRole(this,lbl_MainTitle,tbtn_Search ,tbtn_Save,tbtn_Print) ;

			// Grid Setting
			fgrid_bar.Set_Grid("SBS_BAR", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_bar.Rows[1].AllowMerging = true;
			fgrid_bar.Set_Action_Image(img_Action, true); 

			// user define varible set
			_stateCol = _inStateCol;
			_selectionRows = new ArrayList();
			fgrid_bar.Cols[_scanYmdCol].Format = "yyyy-MM-dd";
			fgrid_bar.Cols[_shipQtyCol].Format = "#,##0.00";
			fgrid_bar.Cols[_scanQtyCol].Format = "#,##0.00";

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_shipFactory, 0, 1, false);
			cmb_shipFactory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose() ;

			// ship type
			vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBS14");
			COM.ComCtl.Set_ComboList(vDt, cmb_shipType, 1, 2, true);
			cmb_shipType.SelectedIndex = 1;
			vDt.Dispose();

			_doSearch = false;

			// barcode state
			vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxBarcodeState);
			COM.ComCtl.Set_ComboList(vDt, cmb_barcodeState, 1, 2, true);
			cmb_barcodeState.SelectedIndex = 0;
			vDt.Dispose();
			
			// in / out
			vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxInOutType);
			cmb_inOutType.SelectedIndex = -1;
			COM.ComCtl.Set_ComboList(vDt, cmb_inOutType, 1, 2, false, true);
			cmb_inOutType.SelectedIndex = 0;
			vDt.Dispose();

			// location
			vDt = this.SELECT_WAREHOUSE_LIST_USING(COM.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_location, 1, 2, true);
			cmb_location.SelectedIndex = 0;
			vDt.Dispose();

			// user
			vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory, "");
			COM.ComCtl.Set_ComboList(vDt, cmb_user, 1, 1, true, false);
			cmb_user.SelectedIndex	= 0;
			vDt.Dispose();

			// scan type
			vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxIncomingType);
			COM.ComCtl.Set_ComboList(vDt, cmb_ScanType, 1, 2, true);
			cmb_ScanType.SelectedIndex = 0;
			vDt.Dispose();

			// rep barcode print
			vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxUseYN);
			COM.ComCtl.Set_ComboList(vDt, cmb_RepBarcode, 1, 2, false);
			cmb_RepBarcode.SelectedIndex = 1;
			vDt.Dispose();

			// material type
			vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBS13");
			COM.ComCtl.Set_ComboList(vDt, cmb_matType, 1, 2, true);
			cmb_matType.SelectedIndex = 0;
			vDt.Dispose();

			// cmb_reqReason
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBP11");
			COM.ComCtl.Set_ComboList(vDt, cmb_reqReason, 1, 2, true);
			cmb_reqReason.SelectedIndex = 0;
			vDt.Dispose();

			Cmb_SetContainer();

			_doSearch = true;

			tbtn_Delete.Enabled		= false;
			tbtn_Confirm.Enabled	= false;
			tbtn_Create.Enabled		= false;
		}
	
		#region 툴바 메뉴 이벤트 처리

		private void Tbtn_NewProcess()
		{
			try
			{
				txt_qty.Text = "";
				fgrid_bar.ClearAll();
				_selectionRows.Clear();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			if (!_doSearch) return;

			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				DataTable vDt = SELECT_SBS_BAR_LIST();
				if (vDt.Rows.Count > 0)
				{
					_selectionRows.Clear();
					txt_qty.Text = "";

					fgrid_bar.Tree.Column = _checkCol;
					//fgrid_bar.Cols[_pkNoCol].ImageAndText = true; 
					//fgrid_bar.Cols[_pkNoCol].ImageMap = _Imgmap;

					ClassLib.ComFunction.Display_FlexGrid_Tree(fgrid_bar, vDt, _levelCol - 1);

					if (cmb_inOutType.SelectedValue.ToString().Equals(ClassLib.ComVar.Incoming))
					{
						_stateCol = _inStateCol;
						fgrid_bar.Cols[_weightCol].Visible = false;
					}
					else
					{
						_stateCol = _outStateCol;
						fgrid_bar.Cols[_weightCol].Visible = true;
					}

					fgrid_bar.Tree.Show(1);						
					GridSetColor();
					_checkColRange = fgrid_bar.GetCellRange(fgrid_bar.Rows.Fixed, _checkCol, fgrid_bar.Rows.Count - 1, _checkCol);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					Tbtn_NewProcess();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SearchProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		private void Tbtn_SaveProcess(bool arg_refresh)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string vType		= cmb_inOutType.SelectedValue.ToString();
				string vProcedure	= null;

				if (vType.Equals(ClassLib.ComVar.Incoming))
					vProcedure = "PKG_SBS_BAR_IN.SAVE_SBS_BAR_IN";
				else
					vProcedure = "PKG_SBS_BAR_OUT.SAVE_SBS_BAR_OUT";

				if (MyOraDB.Save_FlexGird(vProcedure, fgrid_bar))
				{
					if (arg_refresh)
						Tbtn_SearchProcess();
					else
					{
						fgrid_bar.Cols[0].Clear(ClearFlags.Content);
						GridSetColor();
					}
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
				else
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SaveProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		#endregion

		#region 컨트롤 이벤트 처리

		private void Txt_VendorCodeKeyUpProcess()
		{
			try
			{
				DataTable vDt;
				vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_vendorCode.Text);
				COM.ComCtl.Set_ComboList(vDt, cmb_vendor, 0, 1, true, 79, 141);
				vDt.Dispose();

				cmb_vendor.SelectedValue = txt_vendorCode.Text;
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}

		private void Cmb_VendorSelectedValueChangedProcess()
		{
			try
			{
				if (cmb_vendor.SelectedIndex != -1)
					txt_vendorCode.Text		 = cmb_vendor.SelectedValue.ToString();
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}

		private void Txt_StyleCodeKeyUpProcess()
		{
			try
			{
				DataTable vDt;
				vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCode, " "));
				COM.ComCtl.Set_ComboList(vDt, cmb_style, 0, 1, true, 79, 141);
				vDt.Dispose();
				
				if (txt_styleCode.Text.Length == 9)
				{
					string vCode = txt_styleCode.Text;
					vCode = vCode.Substring(0, 6) + "-" + vCode.Substring(6, 3);
					cmb_style.SelectedValue = vCode;
				}
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}

		private void Cmb_StyleSelectedValueChangedProcess()
		{
			try
			{
				if (cmb_style.SelectedIndex != -1)
					txt_styleCode.Text		= cmb_style.SelectedValue.ToString();
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}

		private void Btn_ScanClickProcess(string arg_TypeCode)
		{
			if (GetSelectedRows() <= 0)	return;

			try
			{
				this.Cursor = Cursors.WaitCursor;

				CellRange vRange  = fgrid_bar.Selection;
				string vType	  = cmb_inOutType.SelectedValue.ToString();
				Form vPopup		  = null;
				
				ClassLib.ComVar.Parameter_PopUp_Object = new object[9];
				ClassLib.ComVar.Parameter_PopUp_Object[0] = cmb_shipFactory.SelectedValue;
				ClassLib.ComVar.Parameter_PopUp_Object[1] = fgrid_bar[(int)_selectionRows[0], _scanYmdCol] == null ? dpick_from.Text.Replace("-", "") : fgrid_bar[(int)_selectionRows[0], _scanYmdCol];
				ClassLib.ComVar.Parameter_PopUp_Object[2] = fgrid_bar[(int)_selectionRows[0], _typeCol];
				ClassLib.ComVar.Parameter_PopUp_Object[3] = fgrid_bar[(int)_selectionRows[0], _containerCol];
				ClassLib.ComVar.Parameter_PopUp_Object[4] = fgrid_bar[(int)_selectionRows[0], _locationCol];
				ClassLib.ComVar.Parameter_PopUp_Object[5] = arg_TypeCode;
				ClassLib.ComVar.Parameter_PopUp_Object[6] = fgrid_bar[(int)_selectionRows[0], fgrid_bar.Cols.Count - 1];
				ClassLib.ComVar.Parameter_PopUp_Object[7] = fgrid_bar[(int)_selectionRows[0], _weightCol];
				ClassLib.ComVar.Parameter_PopUp_Object[8] = dpick_from.Value.ToString("yyyyMMdd");

				if (vType.Equals(ClassLib.ComVar.Incoming))
				{
					vPopup = new Pop_BS_Scan_In();
				}
				else
				{
					if (arg_TypeCode == null)
					{
						if (ClassLib.ComFunction.NullToBlank(fgrid_bar[(int)_selectionRows[0], _containerCol]).Equals(""))
						{
							ClassLib.ComVar.Parameter_PopUp_Object[2] = "30";
							ClassLib.ComVar.Parameter_PopUp_Object[3] = "";
						}
						else
						{
							if (ClassLib.ComFunction.NullToBlank(fgrid_bar[(int)_selectionRows[0], _typeCol]).Equals(""))
								ClassLib.ComVar.Parameter_PopUp_Object[2] = "10";
							ClassLib.ComVar.Parameter_PopUp_Object[3] = fgrid_bar[(int)_selectionRows[0], _containerCol];
						}
						vPopup = new Pop_BS_Scan_Out_Btn();
					}
					else
					{
						vPopup = new Pop_BS_Scan_Out_Ctx();
					}
				}

				if (vPopup.ShowDialog() == DialogResult.OK)
				{
					if (vType.Equals(ClassLib.ComVar.Incoming))
						this.GridSetData_Incoming(0);
					else
						this.GridSetData_Outgoing(0);
					
					this.Tbtn_SaveProcess(false);

					string vMode = cmb_inOutType.GetItemText(cmb_inOutType.SelectedIndex, 1);
					ClassLib.ComFunction.User_Message("Complete the " + vMode + " Scan", "Scan", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
//				else
//					ClassLib.ComFunction.SetData_FSP(fgrid_bar, _checkColRange, "false");
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_ScanClickProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Btn_CancelClickProcess()
		{
			if (GetSelectedRows() <= 0)	return;

			COM.ComVar.Parameter_PopUp = new string[]{"", "", "", "", ""};
			if (cmb_inOutType.SelectedValue.ToString().Equals(ClassLib.ComVar.Incoming))
				this.GridSetData_Incoming(1);
			else
				this.GridSetData_Outgoing(1);
			this.Tbtn_SaveProcess(false);

			ClassLib.ComFunction.User_Message("Complete the Cancel Scan", "Scan", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void Btn_ChangeClick()
		{
			try
			{
				if (GetSelectedRows() <= 0)	return;

				//ClassLib.ComVar.Parameter_PopUp_Object = new object[]{fgrid_bar, _selectionRows};
				ClassLib.ComVar.Parameter_PopUp_Object = new object[5];
				ClassLib.ComVar.Parameter_PopUp_Object[0] = fgrid_bar;
				ClassLib.ComVar.Parameter_PopUp_Object[1] = _selectionRows;
				ClassLib.ComVar.Parameter_PopUp_Object[2] = cmb_shipFactory.SelectedValue;
				ClassLib.ComVar.Parameter_PopUp_Object[3] = fgrid_bar[(int)_selectionRows[0], _scanYmdCol];
				ClassLib.ComVar.Parameter_PopUp_Object[4] = fgrid_bar[(int)_selectionRows[0], _containerCol];
				Pop_BS_Scan_Changer pop_changer = new Pop_BS_Scan_Changer();
				//pop_changer.Disposed += new EventHandler(Pop_ChangeComplete);
				pop_changer.Show();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_ChangeClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Cmb_InOutTypeSelectProcess()
		{
			try
			{
				_stateCol = (cmb_inOutType.SelectedValue.ToString().Equals(ClassLib.ComVar.Incoming)) ? _inStateCol : _outStateCol;

				if (cmb_inOutType.SelectedValue.ToString().Equals(ClassLib.ComVar.Incoming))
				{
					ClassLib.ComFunction.SetComboData(cmb_ScanType, ClassLib.ComVar.CxIncomingType, true, 0);
					lbl_ScanType.Text = "Incoming Type";
				}
				else
				{
					ClassLib.ComFunction.SetComboData(cmb_ScanType, ClassLib.ComVar.CxOutgoingType, true, 0);
					lbl_ScanType.Text = "Outgoing Type";
				}
			}
			catch
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Btn_ChangeClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#region 컨텍스트메뉴 이벤트 처리

		private void Mnu_Outgoing_ContainerProcess(object sender)
		{
			ClassLib.ComFunction.SetData_FSP(fgrid_bar, _checkColRange, "false");
			_selectionRows.Clear();
			MenuItem vMenu = (MenuItem)sender;

			string vScanType = ( fgrid_bar[fgrid_bar.Row, _typeCol] == null ) ? null : vMenu.Text.Substring(0, 2);
			string vContainer = ( fgrid_bar[fgrid_bar.Row, _typeCol] == null ) ? null : fgrid_bar[fgrid_bar.Row, _containerCol].ToString();
			Chk_AllCheckedProcess(true, null, vContainer);
			Btn_ScanClickProcess(vMenu.Text.Substring(0, 2));
		}

		private void Mnu_Outgoing_EtcProcess(object sender)
		{
			/*
			MenuItem vMenu = (MenuItem)sender;
			Mnu_SelectRangeProcess(true);
			Btn_ScanClickProcess(vMenu.Text.Substring(0, 2));
			*/
			ClassLib.ComFunction.SetData_FSP(fgrid_bar, _checkColRange, "false");
			_selectionRows.Clear();
			MenuItem vMenu = (MenuItem)sender;

			string vScanType = ( fgrid_bar[fgrid_bar.Row, _typeCol] == null ) ? null : vMenu.Text.Substring(0, 2);
			string vContainer = "";
			Chk_AllCheckedProcess(true, null, vContainer);
			Btn_ScanClickProcess(vMenu.Text.Substring(0, 2));
		}

		private void Mnu_SelectRangeProcess(bool arg_bool)
		{
			for (int vRow = fgrid_bar.Selection.r1 ; vRow <= fgrid_bar.Selection.r2 ; vRow++)
			{
				fgrid_bar[vRow, _checkCol] = arg_bool;
			}
		}

		// checkbox check or uncheck for out scan type
		private void Chk_AllCheckedProcess(bool arg_checked, string arg_ScanType, string arg_Container)
		{
			for (int vRow = fgrid_bar.Rows.Fixed ; vRow < fgrid_bar.Rows.Count ; vRow++)
			{
				Node vNode = fgrid_bar.Rows[vRow].Node;
				string vScanType = (vNode.Row[_typeCol] == null) ? "" : vNode.Row[_typeCol].ToString();
				string vContainer = (vNode.Row[_containerCol] == null) ? "" : vNode.Row[_containerCol].ToString();
				
				if ((fgrid_bar[vRow, _typeCol].ToString().Equals(arg_ScanType) || arg_ScanType == null) && 
					(vContainer.Equals(arg_Container) || arg_Container == null))
				{
					if (vNode.Level == 3)
					{
						vNode = vNode.GetNode(NodeTypeEnum.Parent);
						if (vNode != null)
							if (!vNode.Row[_inStateCol].ToString().Equals(ClassLib.ComVar.Scan))
								continue;
					}

					fgrid_bar[vRow, _checkCol] = arg_checked;
				}
			}
		}

		private void Mnu_RepChangeProcess()
		{
			try
			{
				// 데이터 생성
				int[] vSelection = fgrid_bar.Selections;
				string vContainer = "";
				string vTemp = "";

				foreach (int vRow in vSelection)
				{
					vTemp = ClassLib.ComFunction.NullCheck(fgrid_bar[vRow, (int)ClassLib.TBSBS_BAR_1.IxBAR_CODE_REP], "");

					if (vContainer.IndexOf(vTemp) < 0)
					{
						vContainer += vTemp + " ";
					}
				}

				vContainer = vContainer.Remove(vContainer.Length - 1, 1);
				ClassLib.ComVar.Parameter_PopUp_Object = new object[]{vContainer.Split(' ')};
				ClassLib.ComVar.Parameter_PopUp = new string[]{"Barcode Rep"};

				// 팝업
				Pop_BS_Shipping_List_Changer vPop = new Pop_BS_Shipping_List_Changer();
				vPop.ShowDialog();
				if(ClassLib.ComVar.Parameter_PopUp != null)
				{
					foreach (int vRow in vSelection)
					{
						if (fgrid_bar.Rows[vRow].Node.Level != 1)
						{
							fgrid_bar[vRow, (int)ClassLib.TBSBS_BAR_1.IxBAR_CODE_REP] = ClassLib.ComVar.Parameter_PopUp[0];
							this.fgrid_bar.Update_Row(vRow);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Mnu_RepChangeProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Mnu_OutsideInformation()
		{
			int vRow = fgrid_bar.Selection.r1;

			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_shipFactory}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 

			string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BS_Scan_OutsideInformation");

			string sPara  = " /rp ";
			sPara += "'" + COM.ComFunction.Param_Combo(cmb_shipFactory, "%") +	"' ";
			sPara += "'" + fgrid_bar[vRow, (int)ClassLib.TBSBS_BAR_1.IxSTYLE_CD].ToString().Replace("-", "") +	"' ";
			sPara += "'" + fgrid_bar[vRow, (int)ClassLib.TBSBS_BAR_1.IxBAR_CODE].ToString().Substring(0, 15)  +	"' ";
			sPara += "'" + fgrid_bar[vRow+1, (int)ClassLib.TBSBS_BAR_1.IxITEM_CD].ToString()  +	"' ";
			
			FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = "Incoming Item Inspection sheet";
			MyReport.Show();	
		}

		#endregion

		#endregion

		#region 그리드 이벤트 처리

		private void Grid_AfterEditProcess(C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			int vRow = e.Row;
			int vCol = e.Col;
	
			try
			{
				if (vCol == _checkCol)
				{
					if (fgrid_bar[vRow, _levelCol].ToString().Equals("1"))
						SelectionChilds(vRow);
					else if (fgrid_bar[vRow, _levelCol].ToString().Equals("2"))
						fgrid_bar.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row[_checkCol] = false;
				}
				//				else
				//				{
				//					if (fgrid_bar.Rows[vRow].Style != null && fgrid_bar.Rows[vRow].Style.ForeColor == Color.Red)
				//					{
				//						if (((int)fgrid_bar[vRow, vCol]) > int.Parse(fgrid_bar.Buffer_CellData)) 
				//							fgrid_bar[vRow, vCol] = fgrid_bar.Buffer_CellData;
				//					}
				//					else if (fgrid_bar[vRow, _stateCol].ToString().Equals(ClassLib.ComVar.PreScan))
				//					{
				//						if (Convert.ToInt32(fgrid_bar[vRow, _shipQtyCol]) < Convert.ToInt32(fgrid_bar[vRow, _scanQtyCol])) 
				//							fgrid_bar[vRow, vCol] = fgrid_bar.Buffer_CellData;
				//						else
				//							fgrid_bar[vRow, 0] = ClassLib.ComVar.Update;
				//					}
				//
				//					fgrid_bar[vRow, _checkCol] = true;
				//				}
			}
			catch (Exception ex)
			{
				fgrid_bar[vRow, vCol] = fgrid_bar.Buffer_CellData;
				ClassLib.ComFunction.User_Message(ex.Message, "AfterEditProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (fgrid_bar.MouseCol == _checkCol)
					fgrid_bar.Rows[fgrid_bar.MouseRow].AllowEditing = false;
			}
		}

		private void Grid_BeforeEditProcess(C1.Win.C1FlexGrid.RowColEventArgs e)
		{
//			int vRow = e.Row;
//			int vCol = e.Col;
//
//			Node vNode = fgrid_bar.Rows[vRow].Node;
//			
//			if (vNode.Level == 3)
//			{
//				vNode = vNode.GetNode(NodeTypeEnum.Parent);
//				if (!vNode.Row[_stateCol].ToString().Equals(ClassLib.ComVar.Scan))
//					e.Cancel = true;
//			}
//			
//			if ((fgrid_bar[vRow, _levelCol].ToString().Equals("1") && vCol == _scanQtyCol) || 
//				(fgrid_bar[vRow, _stateCol].ToString().Equals(ClassLib.ComVar.Scan) && vCol == _scanQtyCol))
//				e.Cancel = true;

			if ((fgrid_bar.Rows.Fixed > 0) && (fgrid_bar.Row >= fgrid_bar.Rows.Fixed))
				fgrid_bar.Buffer_CellData = (fgrid_bar[fgrid_bar.Row, fgrid_bar.Col] == null) ? "" : fgrid_bar[fgrid_bar.Row, fgrid_bar.Col].ToString();
		}

		private void Grid_BarClickProcess(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				ctx_bar.Show(fgrid_bar, new Point(e.X, e.Y));
			}
		}

		#endregion

		#region 정합성 검사

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			try
			{
				// 공통 체크
				if (cmb_shipFactory.SelectedIndex == -1)
				{
					ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					cmb_shipFactory.Focus();
					return false;
				}

				if (fgrid_bar.Rows.Fixed >= fgrid_bar.Rows.Count && (arg_type == ClassLib.ComVar.Validate_Save || arg_type == _validate_scan || arg_type == _validate_change || arg_type == _validate_cancel))
				{
					ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}

				if (this.GetSelectedRows() <= 0 && (arg_type == _validate_scan || arg_type == _validate_change || arg_type == _validate_cancel))
				{
					ClassLib.ComFunction.User_Message("Selected data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return false;
				}

				// 부분별 체크 (Search, Save, Delete, Confirm..)
				switch (arg_type)
				{
					case ClassLib.ComVar.Validate_Search:

						break;
					case ClassLib.ComVar.Validate_Save:

						break;
					case ClassLib.ComVar.Validate_Delete:

						break;
					case ClassLib.ComVar.Validate_Confirm:

						break;
					case _validate_scan:	// 하단 Scan 버튼

						break;
					case _validate_change:	// 하단 Change 버튼

						break;
					case _validate_cancel:	// 하단 Cancel 버튼

						break;
					case _validate_context:	// Context Menu
						if (cmb_inOutType.SelectedValue.Equals(ClassLib.ComVar.Outgoing))
						{
							mnu_bar2.Visible		= true;
							mnu_Outgoing.Visible	= true;
							mnu_repChange.Visible	= true;
							mnu_repChange.Enabled	= false;
						
							int[] vSelections = fgrid_bar.Selections;
							string vRepBarcode = "";
						
							foreach (int vRow in vSelections)
							{
								if (fgrid_bar.Rows[vRow].Node.Level > 1)
								{
									if (vRepBarcode.IndexOf(fgrid_bar[vRow, _barcodeRepCol].ToString()) < 0)
										vRepBarcode += fgrid_bar[vRow, _barcodeRepCol].ToString();

									if (vRepBarcode.Length > 30)
									{
										mnu_repChange.Enabled	= true;
										break;
									}
								}
							}
						}
						else
						{
							mnu_bar2.Visible		= false;
							mnu_Outgoing.Visible	= false;
							mnu_repChange.Visible	= false;
						}

						break;
					case _validate_repChange:
						int[] vSel = fgrid_bar.Selections;
						
						foreach (int vRow in vSel)
						{
							if (fgrid_bar.Rows[vRow].Node.Level > 1 && !ClassLib.ComFunction.NullToBlank(fgrid_bar[vRow, _typeCol]).Equals(ClassLib.ComVar.OutScanTypeEnum.Vessel))
							{
								fgrid_bar.Select(vRow, _typeCol);
								ClassLib.ComFunction.User_Message("Included not vassel outgoing", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return false;
							}
						}

						break;
				}

				return true;
			}
			catch //(Exception ex)
			{
				return false;
			}
		}

		#endregion

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBS_BAR : Barcode list
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_BAR_LIST()
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(16);

			//01.PROCEDURE명
			string vType = cmb_inOutType.SelectedValue.ToString();

			if (vType.Equals(ClassLib.ComVar.Incoming))
				MyOraDB.Process_Name = "PKG_SBS_BAR_IN.SELECT_SBS_BAR_LIST";
			else
				MyOraDB.Process_Name = "PKG_SBS_BAR_OUT.SELECT_SBS_BAR_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_DATE_FROM";
			MyOraDB.Parameter_Name[4] = "ARG_SHIP_DATA_TO";
			MyOraDB.Parameter_Name[5] = "ARG_VENDOR";
			MyOraDB.Parameter_Name[6] = "ARG_STYLE";
			MyOraDB.Parameter_Name[7] = "ARG_SHIP_NO";
			MyOraDB.Parameter_Name[8] = "ARG_BARCODE_STATE";
			MyOraDB.Parameter_Name[9] = "ARG_LOCATION";
			MyOraDB.Parameter_Name[10] = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[11] = "ARG_SCAN_TYPE";
			MyOraDB.Parameter_Name[12] = "ARG_CONTAINER";
			MyOraDB.Parameter_Name[13] = "ARG_MAT_TYPE";
			MyOraDB.Parameter_Name[14] = "ARG_REASON";
			MyOraDB.Parameter_Name[15] = "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[15] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(cmb_shipFactory, "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[3] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_Combo(cmb_vendor, "");
			MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
			MyOraDB.Parameter_Values[7] = ClassLib.ComFunction.Empty_Combo(cmb_shipNo, "");
			MyOraDB.Parameter_Values[8] = ClassLib.ComFunction.Empty_Combo(cmb_barcodeState, "");
			MyOraDB.Parameter_Values[9] = ClassLib.ComFunction.Empty_Combo(cmb_location, "");
			MyOraDB.Parameter_Values[10] = ClassLib.ComFunction.Empty_Combo(cmb_user, "");
			MyOraDB.Parameter_Values[11] = ClassLib.ComFunction.Empty_Combo(cmb_ScanType, "");
			MyOraDB.Parameter_Values[12] = ClassLib.ComFunction.Empty_Combo(cmb_container, "");
			MyOraDB.Parameter_Values[13] = ClassLib.ComFunction.Empty_Combo(cmb_matType, "");
			MyOraDB.Parameter_Values[14] = ClassLib.ComFunction.Empty_Combo(cmb_reqReason, "");
			MyOraDB.Parameter_Values[15] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBS_BAR : Shipping List
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_BAR_SHIPNO()
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_BAR.SELECT_SBS_BAR_SHIPNO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_SHIP_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_DATE_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_DATE_TO";
			MyOraDB.Parameter_Name[4] = "ARG_VENDOR";
			MyOraDB.Parameter_Name[5] = "ARG_STYLE";
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
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_shipFactory, "");
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = "";
			MyOraDB.Parameter_Values[5] = "";
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBC_WAREHOUSE_LOC : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_WAREHOUSE_LIST_USING(string arg_factory)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_WAREHOUSE.SELECT_WAREHOUSE_LIST_USING";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// UPDATE_SBS_BAR_CODE_REP : 대표 바코드 수정 프로세서
		/// </summary>
		public void UPDATE_SBS_BAR_CODE_REP()
		{
			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_BAR.UPDATE_SBS_BAR_CODE_REP";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_BAR_CODE";
			MyOraDB.Parameter_Name[2] = "ARG_BAR_CODE_REP";
			MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

			ArrayList vBarcode = new ArrayList();
			ArrayList vBarcodeRep = new ArrayList();

			//04.DATA 정의
			for ( int vRow = fgrid_bar.Rows.Fixed ; vRow < fgrid_bar.Rows.Count ; vRow++ )
			{
				if ( fgrid_bar[vRow, 0] != null && fgrid_bar.Rows[vRow].Node.Level > 1 )
				{
					if ( fgrid_bar[vRow, 0].ToString().Equals(ClassLib.ComVar.Update) )
					{
						vBarcode.Add(ClassLib.ComVar.Update);
						vBarcode.Add(fgrid_bar[vRow, (int)ClassLib.TBSBS_BAR_1.IxBAR_CODE].ToString());
						vBarcode.Add(fgrid_bar[vRow, (int)ClassLib.TBSBS_BAR_1.IxBAR_CODE_REP].ToString());
						vBarcode.Add(COM.ComVar.This_User);

						Node vParent = fgrid_bar.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent);
						if (!vBarcodeRep.Contains(vParent.Row[(int)ClassLib.TBSBS_BAR_1.IxBAR_CODE].ToString()))
						{
							vBarcodeRep.Add(ClassLib.ComVar.Insert);
							vBarcodeRep.Add(fgrid_bar[vRow, (int)ClassLib.TBSBS_BAR_1.IxBAR_CODE].ToString());
							vBarcodeRep.Add(vParent.Row[(int)ClassLib.TBSBS_BAR_1.IxBAR_CODE].ToString());
							vBarcodeRep.Add(COM.ComVar.This_User);
						}
					}
				}
			}

            vBarcode.AddRange(vBarcodeRep);

			MyOraDB.Parameter_Values = (string[])vBarcode.ToArray(Type.GetType("System.String"));

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}


		#endregion

		#region 프린트

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename;
			string Para         = " ";

			int  iCnt  = 24;
			string [] aHead =  new string[iCnt];

			Pop_BS_Print_Type vPop = new Pop_BS_Print_Type("SBS15");

			if (vPop.ShowDialog() == DialogResult.OK)
			{
				string vPrintType = COM.ComVar.Parameter_PopUp[0];

				switch (vPrintType)
				{
					case "10":
						iCnt  = 16;
						mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_Scan_InOut_Temp") ;

						aHead[0] = COM.ComVar.This_Factory;
						aHead[1] = ClassLib.ComFunction.Empty_Combo(cmb_shipFactory, "");
						aHead[2] = ClassLib.ComFunction.Empty_Combo(cmb_shipType, "");
						aHead[3] = dpick_from.Text.Replace("-", "");
						aHead[4] = dpick_to.Text.Replace("-", "");
						aHead[5] = ClassLib.ComFunction.Empty_Combo(cmb_vendor, "");
						aHead[6] = ClassLib.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
						aHead[7] = ClassLib.ComFunction.Empty_Combo(cmb_shipNo, "");
						aHead[8] = ClassLib.ComFunction.Empty_Combo(cmb_barcodeState, "");
						aHead[9] = ClassLib.ComFunction.Empty_Combo(cmb_location, "");
						aHead[10] = ClassLib.ComFunction.Empty_Combo(cmb_user, "");
						aHead[11] = ClassLib.ComFunction.Empty_Combo(cmb_ScanType, "");
						aHead[12] = ClassLib.ComFunction.Empty_Combo(cmb_container, "");
						aHead[13] = ClassLib.ComFunction.Empty_Combo(cmb_matType, "");
						aHead[14] = ClassLib.ComFunction.Empty_Combo(cmb_RepBarcode," ");
						aHead[15] = ClassLib.ComFunction.Empty_Combo(cmb_reqReason," ");

						break;
					case "20":
						iCnt  = 24;

						string vType = cmb_inOutType.SelectedValue.ToString();

						if (vType.Equals(ClassLib.ComVar.Incoming))
						{
							mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_Scan_InOut_In") ;
						}
						else
						{
							mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_Scan_InOut_Out") ;
						}

						aHead[0] = COM.ComVar.This_Factory;
						aHead[1] = ClassLib.ComFunction.Empty_Combo(cmb_shipFactory, "");
						aHead[2] = ClassLib.ComFunction.Empty_Combo(cmb_shipType, "");
						aHead[3] = dpick_from.Text.Replace("-", "");
						aHead[4] = dpick_to.Text.Replace("-", "");
						aHead[5] = ClassLib.ComFunction.Empty_Combo(cmb_vendor, "");
						aHead[6] = ClassLib.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
						aHead[7] = ClassLib.ComFunction.Empty_Combo(cmb_shipNo, "");
						aHead[8] = ClassLib.ComFunction.Empty_Combo(cmb_barcodeState, "");
						aHead[9] = ClassLib.ComFunction.Empty_Combo(cmb_location, "");
						aHead[10] = ClassLib.ComFunction.Empty_Combo(cmb_user, "");
						aHead[11] = ClassLib.ComFunction.Empty_Combo(cmb_ScanType, "");
						aHead[12] = ClassLib.ComFunction.Empty_Combo(cmb_container, "");
						aHead[13] = ClassLib.ComFunction.Empty_Combo(cmb_matType, "");
						aHead[14] = cmb_shipType.GetItemText(cmb_shipType.SelectedIndex, 1);
						aHead[15] = cmb_inOutType.GetItemText(cmb_inOutType.SelectedIndex, 1);
						if(cmb_vendor.SelectedIndex!= -1)
							aHead[16] = cmb_vendor.GetItemText(cmb_vendor.SelectedIndex, 1);
						else
							aHead[16] ="";

						if(cmb_style.SelectedIndex!= -1)
							aHead[17] = cmb_style.GetItemText(cmb_style.SelectedIndex, 1);
						else
							aHead[17] ="";
						aHead[18] = txt_qty.Text;
						aHead[19] = cmb_barcodeState.GetItemText(cmb_barcodeState.SelectedIndex, 1);
						aHead[20] = cmb_location.GetItemText(cmb_location.SelectedIndex, 1);
						aHead[21] = cmb_ScanType.GetItemText(cmb_ScanType.SelectedIndex, 1);
						aHead[22] = cmb_RepBarcode.GetItemText(cmb_RepBarcode.SelectedIndex, 1);
						aHead[23] = ClassLib.ComFunction.Empty_Combo(cmb_reqReason," ");

						break;
					case "30":
						iCnt  = 24;

				
						mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_Scan_InOut3") ;

						aHead[0] = COM.ComVar.This_Factory;
						aHead[1] = ClassLib.ComFunction.Empty_Combo(cmb_shipFactory, "");
						aHead[2] = ClassLib.ComFunction.Empty_Combo(cmb_shipType, "");
						aHead[3] = dpick_from.Text.Replace("-", "");
						aHead[4] = dpick_to.Text.Replace("-", "");
						aHead[5] = ClassLib.ComFunction.Empty_Combo(cmb_vendor, "");
						aHead[6] = ClassLib.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
						aHead[7] = ClassLib.ComFunction.Empty_Combo(cmb_shipNo, "");
						aHead[8] = ClassLib.ComFunction.Empty_Combo(cmb_barcodeState, "");
						aHead[9] = ClassLib.ComFunction.Empty_Combo(cmb_location, "");
						aHead[10] = ClassLib.ComFunction.Empty_Combo(cmb_user, "");
						aHead[11] = ClassLib.ComFunction.Empty_Combo(cmb_ScanType, "");
						aHead[12] = ClassLib.ComFunction.Empty_Combo(cmb_container, "");
						aHead[13] = ClassLib.ComFunction.Empty_Combo(cmb_matType, "");
						aHead[14] = cmb_shipType.GetItemText(cmb_shipType.SelectedIndex, 1);
						aHead[15] = cmb_inOutType.GetItemText(cmb_inOutType.SelectedIndex, 1);
						if(cmb_vendor.SelectedIndex!= -1)
							aHead[16] = cmb_vendor.GetItemText(cmb_vendor.SelectedIndex, 1);
						else
							aHead[16] ="";

						if(cmb_style.SelectedIndex!= -1)
							aHead[17] = cmb_style.GetItemText(cmb_style.SelectedIndex, 1);
						else
							aHead[17] ="";
						aHead[18] = txt_qty.Text;
						aHead[19] = cmb_barcodeState.GetItemText(cmb_barcodeState.SelectedIndex, 1);
						aHead[20] = cmb_location.GetItemText(cmb_location.SelectedIndex, 1);
						aHead[21] = cmb_ScanType.GetItemText(cmb_ScanType.SelectedIndex, 1);
						aHead[22] = cmb_RepBarcode.GetItemText(cmb_RepBarcode.SelectedIndex, 1);
						aHead[23] = ClassLib.ComFunction.Empty_Combo(cmb_reqReason," ");

						break;

					case "40":
						iCnt  = 24;

				
						mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_Scan_NotScan") ;

						aHead[0] = COM.ComVar.This_Factory;
						aHead[1] = ClassLib.ComFunction.Empty_Combo(cmb_shipFactory, "");
						aHead[2] = ClassLib.ComFunction.Empty_Combo(cmb_shipType, "");
						aHead[3] = dpick_from.Text.Replace("-", "");
						aHead[4] = dpick_to.Text.Replace("-", "");
						aHead[5] = ClassLib.ComFunction.Empty_Combo(cmb_vendor, "");
						aHead[6] = ClassLib.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
						aHead[7] = ClassLib.ComFunction.Empty_Combo(cmb_shipNo, "");
						aHead[8] = ClassLib.ComFunction.Empty_Combo(cmb_barcodeState, "");
						aHead[9] = ClassLib.ComFunction.Empty_Combo(cmb_location, "");
						aHead[10] = ClassLib.ComFunction.Empty_Combo(cmb_user, "");
						aHead[11] = ClassLib.ComFunction.Empty_Combo(cmb_ScanType, "");
						aHead[12] = ClassLib.ComFunction.Empty_Combo(cmb_container, "");
						aHead[13] = ClassLib.ComFunction.Empty_Combo(cmb_matType, "");
						aHead[14] = cmb_shipType.GetItemText(cmb_shipType.SelectedIndex, 1);
						aHead[15] = cmb_inOutType.GetItemText(cmb_inOutType.SelectedIndex, 1);
						if(cmb_vendor.SelectedIndex!= -1)
							aHead[16] = cmb_vendor.GetItemText(cmb_vendor.SelectedIndex, 1);
						else
							aHead[16] ="";

						if(cmb_style.SelectedIndex!= -1)
							aHead[17] = cmb_style.GetItemText(cmb_style.SelectedIndex, 1);
						else
							aHead[17] ="";
						aHead[18] = txt_qty.Text;
						aHead[19] = cmb_barcodeState.GetItemText(cmb_barcodeState.SelectedIndex, 1);
						aHead[20] = cmb_location.GetItemText(cmb_location.SelectedIndex, 1);
						aHead[21] = cmb_ScanType.GetItemText(cmb_ScanType.SelectedIndex, 1);
						aHead[22] = cmb_RepBarcode.GetItemText(cmb_RepBarcode.SelectedIndex, 1);
						aHead[23] = ClassLib.ComFunction.Empty_Combo(cmb_reqReason," ");

						break;

					default:
						return;
				}

				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{				
					Para = Para + "[" + aHead[i-1] + "] ";
				}
							
				FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer ( mrd_Filename, Para);
				report.Show();
			}
		}

		#endregion

		private void cmb_shipFactory_TextChanged(object sender, System.EventArgs e)
		{
		
		}

	}
}
