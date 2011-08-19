using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;
using C1.Win.C1FlexGrid;
using System.Threading;

namespace FlexPurchase.Incoming
{
	public class Form_BI_Incoming : COM.PCHWinForm.Form_Top
	{
		#region 컨트롤정의 및 리소스 정의 
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.Label lbl_inYmd;
		private System.Windows.Forms.Label lbl_inNo;
		private C1.Win.C1List.C1Combo cmb_inNo;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_inType;
		private C1.Win.C1List.C1Combo cmb_inType;
		private System.Windows.Forms.Label lbl_buyDiv;
		private System.Windows.Forms.Label lbl_purDiv;
		private C1.Win.C1List.C1Combo cmb_buyDiv;
		private C1.Win.C1List.C1Combo cmb_purDiv;
		private System.Windows.Forms.Label btn_sizeSearch;
		private C1.Win.C1List.C1Combo cmb_inSize;
		private System.Windows.Forms.Label lbl_inSize;
		private System.Windows.Forms.Label lbl_invNo;
		private System.Windows.Forms.Label lbl_lcNo;
		private System.Windows.Forms.TextBox txt_lcNo;
		private System.Windows.Forms.TextBox txt_invNo;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.Label lbl_inStatus;
		private System.Windows.Forms.Label btn_barcode;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Label btn_purchase;
		private System.Windows.Forms.TextBox txt_remarks;
		private System.Windows.Forms.Label btn_invoice;
		private System.Windows.Forms.DateTimePicker dpick_inYmd;
		private System.Windows.Forms.DateTimePicker dpick_chgInYmd;
		private System.Windows.Forms.Label btn_change;
		private System.Windows.Forms.Label btn_noShipping;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_headInfo;
		private System.Windows.Forms.TextBox txt_inStatus;
		private System.Windows.Forms.Label lbl_chgInYmd;
		public COM.FSP fgrid_main;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.ContextMenu cmenu_main;
		private System.Windows.Forms.MenuItem menuItem_RateExchange; 
		private System.Windows.Forms.MenuItem menuItem_ValueChange;


		#endregion  

		#region 사용자 정의 변수

		private FarPoint.Win.Spread.SheetView _sizeSheet = null;
		private int _rowfixed = 0;

		private COM.OraDB MyOraDB   = new COM.OraDB();
		private bool _practicable	= false;
		private bool _vChgFalg		= false;
		private bool _vNewInNoSet	= false;
		private bool _initYn		= false;
		private Hashtable _cellCombo = null;
		private Hashtable _cellData  = null;
		private DataTable _vDT		 = null;

		private System.EventHandler _cmbInNoEventHandler		= null;

		string _vFactory			= "";
		string _vInNo			= "";
		string _vInYmd			= "";
		private string _vTempDate		= "";
		private string _vOldFactory		= "";
		private string _vOldInNo		= "";
		private string _vOldSizeYn		= "";
		private string _vSizeYN			= "";
		private string _vClosingYn		= "";
			
		private int _seqCol				= (int)ClassLib.TBSBI_IN_TAIL.IxSEQ;
		private int _factoryCol			= (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY;
		private int _inNoCol			= (int)ClassLib.TBSBI_IN_TAIL.IxIN_NO;
		private int _inSeqCol			= (int)ClassLib.TBSBI_IN_TAIL.IxIN_SEQ;
		//		private int _itemCol			= (int)ClassLib.TBSBI_IN_TAIL.IxITEM;
		private int _itemNameCol		= (int)ClassLib.TBSBI_IN_TAIL.IxITEM_NAME;
		private int _colorNameCol		= (int)ClassLib.TBSBI_IN_TAIL.IxCOLOR_NAME;
		private int _specNameCol		= (int)ClassLib.TBSBI_IN_TAIL.IxSPEC_NAME;
		private int _purNoCol			= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_NO;
		private int _unitCol			= (int)ClassLib.TBSBI_IN_TAIL.IxUNIT;
		private int _styleCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxSTYLE_CD;
		private int _itemCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxITEM_CD;
		private int _specCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxSPEC_CD;
		private int _colorCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxCOLOR_CD;
		private int _custCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxCUST_CD;
		private int _barCodeCol			= (int)ClassLib.TBSBI_IN_TAIL.IxBAR_CODE;
		private int _inQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxIN_QTY;
		private int _modQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxMOD_QTY;
		
		private int _whCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxWH_CD;

		//		private int _payCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxPAY_CD;
				private int _custNameCol		= (int)ClassLib.TBSBI_IN_TAIL.IxCUST_NAME;
		//		private int _lotNoCol			= (int)ClassLib.TBSBI_IN_TAIL.IxLOT_NO;
		//		private int _lotSeqCol			= (int)ClassLib.TBSBI_IN_TAIL.IxLOT_SEQ;
		//		private int _shipQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_QTY;
		//		private int _taxCdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxTAX_CD;
		//		private int _barKindCol			= (int)ClassLib.TBSBI_IN_TAIL.IxBAR_KIND;
		//		private int _contNoCol			= (int)ClassLib.TBSBI_IN_TAIL.IxCONT_NO;
		//		private int _shipYmdCol			= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_YMD;
		//		private int _shipNoCol			= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_NO;
		//		private int _shipSeqCol			= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_SEQ;
		//		private int _shipPriceCol		= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_PRICE;
		//		private int _whNameCol			= (int)ClassLib.TBSBI_IN_TAIL.IxWH_NAME;
		//		private int _pkUnitQtyCol		= (int)ClassLib.TBSBI_IN_TAIL.IxPK_UNIT_QTY;
		
		private int _purPriceCol		= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_PRICE;
		private int _purCurrencyCol		= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_CURRENCY;
		private int _outsideCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxOUTSIDE_CURRENCY;
		private int _outsidePriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxOUTSIDE_PRICE ;
		private int _cbdCurrencyCol		= (int)ClassLib.TBSBI_IN_TAIL.IxCBD_CURRENCY;
		private int _cbdPriceCol		= (int)ClassLib.TBSBI_IN_TAIL.IxCBD_PRICE;
		private int _shipCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_CURRENCY;
		private int _shipPriceCol       = (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_PRICE;
		private int _ledgerCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_CURRENCY;
		private System.Windows.Forms.Label btnOutside;
		private System.Windows.Forms.Label btn_Tree;
		private C1.Win.C1List.C1Combo cmb_outside;
		private System.Windows.Forms.Label lbl_outside;
		private System.Windows.Forms.TextBox txt_Count;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_Sum;
		private int _ledgerPriceCol     = (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_PRICE;
		
		//		private int _priceYnCol			= (int)ClassLib.TBSBI_IN_TAIL.IxPRICE_YN;
		//		private int _purSeqCol			= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_SEQ;
		//		private int _purUserCol			= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_USER;
		//		private int _purDeptCol			= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_DEPT;
		//		private int _inStatusCol		= (int)ClassLib.TBSBI_IN_TAIL.IxIN_STATUS;
		//		private int _remarksCol			= (int)ClassLib.TBSBI_IN_TAIL.IxREMARKS;
		//		private int _updUserCol			= (int)ClassLib.TBSBI_IN_TAIL.IxUPD_USER;
		


		#endregion

		#region 생성자 / 소멸자
		public Form_BI_Incoming()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BI_Incoming));
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
            this.fgrid_main = new COM.FSP();
            this.cmenu_main = new System.Windows.Forms.ContextMenu();
            this.menuItem_ValueChange = new System.Windows.Forms.MenuItem();
            this.menuItem_RateExchange = new System.Windows.Forms.MenuItem();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.txt_Sum = new System.Windows.Forms.TextBox();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_barcode = new System.Windows.Forms.Label();
            this.cmb_outside = new C1.Win.C1List.C1Combo();
            this.lbl_outside = new System.Windows.Forms.Label();
            this.txt_inStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_chgInYmd = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Label();
            this.dpick_chgInYmd = new System.Windows.Forms.DateTimePicker();
            this.btn_invoice = new System.Windows.Forms.Label();
            this.btn_noShipping = new System.Windows.Forms.Label();
            this.btn_purchase = new System.Windows.Forms.Label();
            this.dpick_inYmd = new System.Windows.Forms.DateTimePicker();
            this.lbl_inStatus = new System.Windows.Forms.Label();
            this.cmb_purDiv = new C1.Win.C1List.C1Combo();
            this.txt_invNo = new System.Windows.Forms.TextBox();
            this.txt_lcNo = new System.Windows.Forms.TextBox();
            this.lbl_invNo = new System.Windows.Forms.Label();
            this.lbl_lcNo = new System.Windows.Forms.Label();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.cmb_inSize = new C1.Win.C1List.C1Combo();
            this.lbl_inSize = new System.Windows.Forms.Label();
            this.btn_sizeSearch = new System.Windows.Forms.Label();
            this.cmb_buyDiv = new C1.Win.C1List.C1Combo();
            this.lbl_buyDiv = new System.Windows.Forms.Label();
            this.lbl_purDiv = new System.Windows.Forms.Label();
            this.cmb_inType = new C1.Win.C1List.C1Combo();
            this.lbl_inType = new System.Windows.Forms.Label();
            this.cmb_inNo = new C1.Win.C1List.C1Combo();
            this.lbl_inNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.btn_search = new System.Windows.Forms.Label();
            this.lbl_inYmd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_Tree = new System.Windows.Forms.Label();
            this.btnOutside = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            this.pnl_menu.SuspendLayout();
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
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.GridDefinition = "25:False:True;67.1232876712329:False:False;5.13698630136986:False:True;\t0.3937007" +
                "87401575:False:True;97.6377952755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 584);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ContextMenu = this.cmenu_main;
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(12, 154);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(992, 392);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 171;
            this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            this.fgrid_main.DoubleClick += new System.EventHandler(this.fgrid_main_DoubleClick);
            // 
            // cmenu_main
            // 
            this.cmenu_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_ValueChange,
            this.menuItem_RateExchange});
            // 
            // menuItem_ValueChange
            // 
            this.menuItem_ValueChange.Index = 0;
            this.menuItem_ValueChange.Text = "Value Change";
            this.menuItem_ValueChange.Click += new System.EventHandler(this.menuItem_ValueChange_Click);
            // 
            // menuItem_RateExchange
            // 
            this.menuItem_RateExchange.Index = 1;
            this.menuItem_RateExchange.Text = "Rate Exchange";
            this.menuItem_RateExchange.Click += new System.EventHandler(this.menuItem_RateExchange_Click);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.txt_Sum);
            this.pnl_head.Controls.Add(this.txt_Count);
            this.pnl_head.Controls.Add(this.label3);
            this.pnl_head.Controls.Add(this.btn_barcode);
            this.pnl_head.Controls.Add(this.cmb_outside);
            this.pnl_head.Controls.Add(this.lbl_outside);
            this.pnl_head.Controls.Add(this.txt_inStatus);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.lbl_chgInYmd);
            this.pnl_head.Controls.Add(this.btn_change);
            this.pnl_head.Controls.Add(this.dpick_chgInYmd);
            this.pnl_head.Controls.Add(this.btn_invoice);
            this.pnl_head.Controls.Add(this.btn_noShipping);
            this.pnl_head.Controls.Add(this.btn_purchase);
            this.pnl_head.Controls.Add(this.dpick_inYmd);
            this.pnl_head.Controls.Add(this.lbl_inStatus);
            this.pnl_head.Controls.Add(this.cmb_purDiv);
            this.pnl_head.Controls.Add(this.txt_invNo);
            this.pnl_head.Controls.Add(this.txt_lcNo);
            this.pnl_head.Controls.Add(this.lbl_invNo);
            this.pnl_head.Controls.Add(this.lbl_lcNo);
            this.pnl_head.Controls.Add(this.txt_remarks);
            this.pnl_head.Controls.Add(this.cmb_inSize);
            this.pnl_head.Controls.Add(this.lbl_inSize);
            this.pnl_head.Controls.Add(this.btn_sizeSearch);
            this.pnl_head.Controls.Add(this.cmb_buyDiv);
            this.pnl_head.Controls.Add(this.lbl_buyDiv);
            this.pnl_head.Controls.Add(this.lbl_purDiv);
            this.pnl_head.Controls.Add(this.cmb_inType);
            this.pnl_head.Controls.Add(this.lbl_inType);
            this.pnl_head.Controls.Add(this.cmb_inNo);
            this.pnl_head.Controls.Add(this.lbl_inNo);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.btn_search);
            this.pnl_head.Controls.Add(this.lbl_inYmd);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 146);
            this.pnl_head.TabIndex = 1;
            // 
            // txt_Sum
            // 
            this.txt_Sum.BackColor = System.Drawing.Color.White;
            this.txt_Sum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Sum.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Sum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Sum.Location = new System.Drawing.Point(537, 121);
            this.txt_Sum.Name = "txt_Sum";
            this.txt_Sum.Size = new System.Drawing.Size(120, 21);
            this.txt_Sum.TabIndex = 401;
            // 
            // txt_Count
            // 
            this.txt_Count.BackColor = System.Drawing.Color.White;
            this.txt_Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Count.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Count.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Count.Location = new System.Drawing.Point(437, 121);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(99, 21);
            this.txt_Count.TabIndex = 400;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(336, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 399;
            this.label3.Text = "Count /  In Sum";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_barcode
            // 
            this.btn_barcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_barcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_barcode.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_barcode.ImageIndex = 0;
            this.btn_barcode.ImageList = this.img_Button;
            this.btn_barcode.Location = new System.Drawing.Point(662, 119);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(80, 23);
            this.btn_barcode.TabIndex = 354;
            this.btn_barcode.Text = "BarCode";
            this.btn_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_barcode.Click += new System.EventHandler(this.btn_barcode_Click);
            // 
            // cmb_outside
            // 
            this.cmb_outside.AddItemCols = 0;
            this.cmb_outside.AddItemSeparator = ';';
            this.cmb_outside.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_outside.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outside.Caption = "";
            this.cmb_outside.CaptionHeight = 17;
            this.cmb_outside.CaptionStyle = style57;
            this.cmb_outside.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_outside.ColumnCaptionHeight = 18;
            this.cmb_outside.ColumnFooterHeight = 18;
            this.cmb_outside.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_outside.ContentHeight = 16;
            this.cmb_outside.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_outside.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_outside.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_outside.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_outside.EditorHeight = 16;
            this.cmb_outside.EvenRowStyle = style58;
            this.cmb_outside.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_outside.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outside.FooterStyle = style59;
            this.cmb_outside.GapHeight = 2;
            this.cmb_outside.HeadingStyle = style60;
            this.cmb_outside.HighLightRowStyle = style61;
            this.cmb_outside.ItemHeight = 15;
            this.cmb_outside.Location = new System.Drawing.Point(765, 99);
            this.cmb_outside.MatchEntryTimeout = ((long)(2000));
            this.cmb_outside.MaxDropDownItems = ((short)(5));
            this.cmb_outside.MaxLength = 32767;
            this.cmb_outside.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_outside.Name = "cmb_outside";
            this.cmb_outside.OddRowStyle = style62;
            this.cmb_outside.PartialRightColumn = false;
            this.cmb_outside.PropBag = resources.GetString("cmb_outside.PropBag");
            this.cmb_outside.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outside.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outside.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outside.SelectedStyle = style63;
            this.cmb_outside.Size = new System.Drawing.Size(220, 20);
            this.cmb_outside.Style = style64;
            this.cmb_outside.TabIndex = 398;
            // 
            // lbl_outside
            // 
            this.lbl_outside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outside.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outside.ImageIndex = 0;
            this.lbl_outside.ImageList = this.img_Label;
            this.lbl_outside.Location = new System.Drawing.Point(664, 99);
            this.lbl_outside.Name = "lbl_outside";
            this.lbl_outside.Size = new System.Drawing.Size(100, 21);
            this.lbl_outside.TabIndex = 397;
            this.lbl_outside.Text = "Item Type";
            this.lbl_outside.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_inStatus
            // 
            this.txt_inStatus.BackColor = System.Drawing.Color.White;
            this.txt_inStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_inStatus.Enabled = false;
            this.txt_inStatus.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_inStatus.Location = new System.Drawing.Point(109, 99);
            this.txt_inStatus.MaxLength = 20;
            this.txt_inStatus.Name = "txt_inStatus";
            this.txt_inStatus.Size = new System.Drawing.Size(220, 21);
            this.txt_inStatus.TabIndex = 395;
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
            this.label2.TabIndex = 393;
            this.label2.Text = "      Incoming Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_chgInYmd
            // 
            this.lbl_chgInYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_chgInYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chgInYmd.ImageIndex = 0;
            this.lbl_chgInYmd.ImageList = this.img_Label;
            this.lbl_chgInYmd.Location = new System.Drawing.Point(664, 77);
            this.lbl_chgInYmd.Name = "lbl_chgInYmd";
            this.lbl_chgInYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_chgInYmd.TabIndex = 387;
            this.lbl_chgInYmd.Text = "Change Ymd";
            this.lbl_chgInYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_change.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_change.ImageIndex = 0;
            this.btn_change.ImageList = this.img_Button;
            this.btn_change.Location = new System.Drawing.Point(905, 77);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(80, 23);
            this.btn_change.TabIndex = 386;
            this.btn_change.Text = "Change";
            this.btn_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // dpick_chgInYmd
            // 
            this.dpick_chgInYmd.CustomFormat = "";
            this.dpick_chgInYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_chgInYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_chgInYmd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_chgInYmd.Location = new System.Drawing.Point(765, 77);
            this.dpick_chgInYmd.Name = "dpick_chgInYmd";
            this.dpick_chgInYmd.Size = new System.Drawing.Size(140, 21);
            this.dpick_chgInYmd.TabIndex = 385;
            // 
            // btn_invoice
            // 
            this.btn_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_invoice.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_invoice.ImageIndex = 0;
            this.btn_invoice.ImageList = this.img_Button;
            this.btn_invoice.Location = new System.Drawing.Point(905, 119);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(80, 23);
            this.btn_invoice.TabIndex = 383;
            this.btn_invoice.Text = "Invoice";
            this.btn_invoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // btn_noShipping
            // 
            this.btn_noShipping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_noShipping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_noShipping.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_noShipping.ImageIndex = 0;
            this.btn_noShipping.ImageList = this.img_Button;
            this.btn_noShipping.Location = new System.Drawing.Point(824, 119);
            this.btn_noShipping.Name = "btn_noShipping";
            this.btn_noShipping.Size = new System.Drawing.Size(80, 23);
            this.btn_noShipping.TabIndex = 384;
            this.btn_noShipping.Text = "No Shipping";
            this.btn_noShipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_noShipping.Click += new System.EventHandler(this.btn_noShipping_Click);
            // 
            // btn_purchase
            // 
            this.btn_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_purchase.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_purchase.ImageIndex = 0;
            this.btn_purchase.ImageList = this.img_Button;
            this.btn_purchase.Location = new System.Drawing.Point(743, 119);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(80, 23);
            this.btn_purchase.TabIndex = 382;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // dpick_inYmd
            // 
            this.dpick_inYmd.CustomFormat = "";
            this.dpick_inYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_inYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_inYmd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_inYmd.Location = new System.Drawing.Point(109, 55);
            this.dpick_inYmd.Name = "dpick_inYmd";
            this.dpick_inYmd.Size = new System.Drawing.Size(220, 21);
            this.dpick_inYmd.TabIndex = 381;
            this.dpick_inYmd.CloseUp += new System.EventHandler(this.dpick_inYmd_CloseUp);
            // 
            // lbl_inStatus
            // 
            this.lbl_inStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inStatus.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inStatus.ImageIndex = 0;
            this.lbl_inStatus.ImageList = this.img_Label;
            this.lbl_inStatus.Location = new System.Drawing.Point(8, 99);
            this.lbl_inStatus.Name = "lbl_inStatus";
            this.lbl_inStatus.Size = new System.Drawing.Size(100, 21);
            this.lbl_inStatus.TabIndex = 379;
            this.lbl_inStatus.Text = "Incoming Status";
            this.lbl_inStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_purDiv
            // 
            this.cmb_purDiv.AddItemCols = 0;
            this.cmb_purDiv.AddItemSeparator = ';';
            this.cmb_purDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purDiv.Caption = "";
            this.cmb_purDiv.CaptionHeight = 17;
            this.cmb_purDiv.CaptionStyle = style65;
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
            this.cmb_purDiv.EvenRowStyle = style66;
            this.cmb_purDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purDiv.FooterStyle = style67;
            this.cmb_purDiv.GapHeight = 2;
            this.cmb_purDiv.HeadingStyle = style68;
            this.cmb_purDiv.HighLightRowStyle = style69;
            this.cmb_purDiv.ItemHeight = 15;
            this.cmb_purDiv.Location = new System.Drawing.Point(765, 33);
            this.cmb_purDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_purDiv.MaxDropDownItems = ((short)(5));
            this.cmb_purDiv.MaxLength = 32767;
            this.cmb_purDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purDiv.Name = "cmb_purDiv";
            this.cmb_purDiv.OddRowStyle = style70;
            this.cmb_purDiv.PartialRightColumn = false;
            this.cmb_purDiv.PropBag = resources.GetString("cmb_purDiv.PropBag");
            this.cmb_purDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.SelectedStyle = style71;
            this.cmb_purDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_purDiv.Style = style72;
            this.cmb_purDiv.TabIndex = 362;
            this.cmb_purDiv.SelectedValueChanged += new System.EventHandler(this.cmb_purDiv_SelectedValueChanged);
            // 
            // txt_invNo
            // 
            this.txt_invNo.BackColor = System.Drawing.Color.White;
            this.txt_invNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_invNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_invNo.Location = new System.Drawing.Point(437, 99);
            this.txt_invNo.MaxLength = 20;
            this.txt_invNo.Name = "txt_invNo";
            this.txt_invNo.Size = new System.Drawing.Size(220, 21);
            this.txt_invNo.TabIndex = 378;
            // 
            // txt_lcNo
            // 
            this.txt_lcNo.BackColor = System.Drawing.Color.White;
            this.txt_lcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lcNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_lcNo.Location = new System.Drawing.Point(437, 77);
            this.txt_lcNo.MaxLength = 20;
            this.txt_lcNo.Name = "txt_lcNo";
            this.txt_lcNo.Size = new System.Drawing.Size(220, 21);
            this.txt_lcNo.TabIndex = 377;
            // 
            // lbl_invNo
            // 
            this.lbl_invNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_invNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invNo.ImageIndex = 0;
            this.lbl_invNo.ImageList = this.img_Label;
            this.lbl_invNo.Location = new System.Drawing.Point(336, 99);
            this.lbl_invNo.Name = "lbl_invNo";
            this.lbl_invNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_invNo.TabIndex = 376;
            this.lbl_invNo.Text = "Invoice No";
            this.lbl_invNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_lcNo
            // 
            this.lbl_lcNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_lcNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lcNo.ImageIndex = 0;
            this.lbl_lcNo.ImageList = this.img_Label;
            this.lbl_lcNo.Location = new System.Drawing.Point(336, 77);
            this.lbl_lcNo.Name = "lbl_lcNo";
            this.lbl_lcNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_lcNo.TabIndex = 375;
            this.lbl_lcNo.Text = "LC No";
            this.lbl_lcNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_remarks
            // 
            this.txt_remarks.BackColor = System.Drawing.Color.White;
            this.txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remarks.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_remarks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_remarks.Location = new System.Drawing.Point(109, 121);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(220, 21);
            this.txt_remarks.TabIndex = 374;
            // 
            // cmb_inSize
            // 
            this.cmb_inSize.AddItemCols = 0;
            this.cmb_inSize.AddItemSeparator = ';';
            this.cmb_inSize.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_inSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inSize.Caption = "";
            this.cmb_inSize.CaptionHeight = 17;
            this.cmb_inSize.CaptionStyle = style73;
            this.cmb_inSize.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inSize.ColumnCaptionHeight = 18;
            this.cmb_inSize.ColumnFooterHeight = 18;
            this.cmb_inSize.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inSize.ContentHeight = 16;
            this.cmb_inSize.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inSize.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inSize.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_inSize.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inSize.EditorHeight = 16;
            this.cmb_inSize.EvenRowStyle = style74;
            this.cmb_inSize.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_inSize.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_inSize.FooterStyle = style75;
            this.cmb_inSize.GapHeight = 2;
            this.cmb_inSize.HeadingStyle = style76;
            this.cmb_inSize.HighLightRowStyle = style77;
            this.cmb_inSize.ItemHeight = 15;
            this.cmb_inSize.Location = new System.Drawing.Point(109, 77);
            this.cmb_inSize.MatchEntryTimeout = ((long)(2000));
            this.cmb_inSize.MaxDropDownItems = ((short)(5));
            this.cmb_inSize.MaxLength = 32767;
            this.cmb_inSize.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inSize.Name = "cmb_inSize";
            this.cmb_inSize.OddRowStyle = style78;
            this.cmb_inSize.PartialRightColumn = false;
            this.cmb_inSize.PropBag = resources.GetString("cmb_inSize.PropBag");
            this.cmb_inSize.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inSize.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inSize.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inSize.SelectedStyle = style79;
            this.cmb_inSize.Size = new System.Drawing.Size(200, 20);
            this.cmb_inSize.Style = style80;
            this.cmb_inSize.TabIndex = 363;
            this.cmb_inSize.SelectedValueChanged += new System.EventHandler(this.cmb_inSize_SelectedValueChanged);
            // 
            // lbl_inSize
            // 
            this.lbl_inSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inSize.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inSize.ImageIndex = 0;
            this.lbl_inSize.ImageList = this.img_Label;
            this.lbl_inSize.Location = new System.Drawing.Point(8, 77);
            this.lbl_inSize.Name = "lbl_inSize";
            this.lbl_inSize.Size = new System.Drawing.Size(100, 21);
            this.lbl_inSize.TabIndex = 364;
            this.lbl_inSize.Text = "Incoming Size";
            this.lbl_inSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_sizeSearch
            // 
            this.btn_sizeSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_sizeSearch.Enabled = false;
            this.btn_sizeSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sizeSearch.ImageIndex = 27;
            this.btn_sizeSearch.ImageList = this.img_SmallButton;
            this.btn_sizeSearch.Location = new System.Drawing.Point(305, 77);
            this.btn_sizeSearch.Name = "btn_sizeSearch";
            this.btn_sizeSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_sizeSearch.TabIndex = 365;
            this.btn_sizeSearch.Tag = "Search";
            this.btn_sizeSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sizeSearch.Click += new System.EventHandler(this.btn_sizeSearch_Click);
            // 
            // cmb_buyDiv
            // 
            this.cmb_buyDiv.AddItemCols = 0;
            this.cmb_buyDiv.AddItemSeparator = ';';
            this.cmb_buyDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_buyDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_buyDiv.Caption = "";
            this.cmb_buyDiv.CaptionHeight = 17;
            this.cmb_buyDiv.CaptionStyle = style81;
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
            this.cmb_buyDiv.EvenRowStyle = style82;
            this.cmb_buyDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_buyDiv.FooterStyle = style83;
            this.cmb_buyDiv.GapHeight = 2;
            this.cmb_buyDiv.HeadingStyle = style84;
            this.cmb_buyDiv.HighLightRowStyle = style85;
            this.cmb_buyDiv.ItemHeight = 15;
            this.cmb_buyDiv.Location = new System.Drawing.Point(765, 55);
            this.cmb_buyDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_buyDiv.MaxDropDownItems = ((short)(5));
            this.cmb_buyDiv.MaxLength = 32767;
            this.cmb_buyDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_buyDiv.Name = "cmb_buyDiv";
            this.cmb_buyDiv.OddRowStyle = style86;
            this.cmb_buyDiv.PartialRightColumn = false;
            this.cmb_buyDiv.PropBag = resources.GetString("cmb_buyDiv.PropBag");
            this.cmb_buyDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_buyDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.SelectedStyle = style87;
            this.cmb_buyDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_buyDiv.Style = style88;
            this.cmb_buyDiv.TabIndex = 361;
            this.cmb_buyDiv.SelectedValueChanged += new System.EventHandler(this.cmb_buyDiv_SelectedValueChanged);
            // 
            // lbl_buyDiv
            // 
            this.lbl_buyDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buyDiv.ImageIndex = 0;
            this.lbl_buyDiv.ImageList = this.img_Label;
            this.lbl_buyDiv.Location = new System.Drawing.Point(664, 55);
            this.lbl_buyDiv.Name = "lbl_buyDiv";
            this.lbl_buyDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_buyDiv.TabIndex = 360;
            this.lbl_buyDiv.Text = "Buy Division";
            this.lbl_buyDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_purDiv
            // 
            this.lbl_purDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purDiv.ImageIndex = 0;
            this.lbl_purDiv.ImageList = this.img_Label;
            this.lbl_purDiv.Location = new System.Drawing.Point(664, 33);
            this.lbl_purDiv.Name = "lbl_purDiv";
            this.lbl_purDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_purDiv.TabIndex = 359;
            this.lbl_purDiv.Text = "Pur  Division";
            this.lbl_purDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_inType
            // 
            this.cmb_inType.AddItemCols = 0;
            this.cmb_inType.AddItemSeparator = ';';
            this.cmb_inType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_inType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inType.Caption = "";
            this.cmb_inType.CaptionHeight = 17;
            this.cmb_inType.CaptionStyle = style89;
            this.cmb_inType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inType.ColumnCaptionHeight = 18;
            this.cmb_inType.ColumnFooterHeight = 18;
            this.cmb_inType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inType.ContentHeight = 16;
            this.cmb_inType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_inType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inType.EditorHeight = 16;
            this.cmb_inType.EvenRowStyle = style90;
            this.cmb_inType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_inType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_inType.FooterStyle = style91;
            this.cmb_inType.GapHeight = 2;
            this.cmb_inType.HeadingStyle = style92;
            this.cmb_inType.HighLightRowStyle = style93;
            this.cmb_inType.ItemHeight = 15;
            this.cmb_inType.Location = new System.Drawing.Point(437, 55);
            this.cmb_inType.MatchEntryTimeout = ((long)(2000));
            this.cmb_inType.MaxDropDownItems = ((short)(5));
            this.cmb_inType.MaxLength = 32767;
            this.cmb_inType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inType.Name = "cmb_inType";
            this.cmb_inType.OddRowStyle = style94;
            this.cmb_inType.PartialRightColumn = false;
            this.cmb_inType.PropBag = resources.GetString("cmb_inType.PropBag");
            this.cmb_inType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inType.SelectedStyle = style95;
            this.cmb_inType.Size = new System.Drawing.Size(220, 20);
            this.cmb_inType.Style = style96;
            this.cmb_inType.TabIndex = 358;
            // 
            // lbl_inType
            // 
            this.lbl_inType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inType.ImageIndex = 1;
            this.lbl_inType.ImageList = this.img_Label;
            this.lbl_inType.Location = new System.Drawing.Point(336, 55);
            this.lbl_inType.Name = "lbl_inType";
            this.lbl_inType.Size = new System.Drawing.Size(100, 21);
            this.lbl_inType.TabIndex = 357;
            this.lbl_inType.Text = "Incoming Type";
            this.lbl_inType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_inNo
            // 
            this.cmb_inNo.AddItemCols = 0;
            this.cmb_inNo.AddItemSeparator = ';';
            this.cmb_inNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_inNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inNo.Caption = "";
            this.cmb_inNo.CaptionHeight = 17;
            this.cmb_inNo.CaptionStyle = style97;
            this.cmb_inNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inNo.ColumnCaptionHeight = 18;
            this.cmb_inNo.ColumnFooterHeight = 18;
            this.cmb_inNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inNo.ContentHeight = 16;
            this.cmb_inNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_inNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inNo.EditorHeight = 16;
            this.cmb_inNo.EvenRowStyle = style98;
            this.cmb_inNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_inNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_inNo.FooterStyle = style99;
            this.cmb_inNo.GapHeight = 2;
            this.cmb_inNo.HeadingStyle = style100;
            this.cmb_inNo.HighLightRowStyle = style101;
            this.cmb_inNo.ItemHeight = 15;
            this.cmb_inNo.Location = new System.Drawing.Point(437, 33);
            this.cmb_inNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_inNo.MaxDropDownItems = ((short)(5));
            this.cmb_inNo.MaxLength = 32767;
            this.cmb_inNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inNo.Name = "cmb_inNo";
            this.cmb_inNo.OddRowStyle = style102;
            this.cmb_inNo.PartialRightColumn = false;
            this.cmb_inNo.PropBag = resources.GetString("cmb_inNo.PropBag");
            this.cmb_inNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inNo.SelectedStyle = style103;
            this.cmb_inNo.Size = new System.Drawing.Size(198, 20);
            this.cmb_inNo.Style = style104;
            this.cmb_inNo.TabIndex = 5;
            this.cmb_inNo.SelectedValueChanged += new System.EventHandler(this.cmb_inNo_SelectedValueChanged);
            // 
            // lbl_inNo
            // 
            this.lbl_inNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inNo.ImageIndex = 1;
            this.lbl_inNo.ImageList = this.img_Label;
            this.lbl_inNo.Location = new System.Drawing.Point(336, 33);
            this.lbl_inNo.Name = "lbl_inNo";
            this.lbl_inNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_inNo.TabIndex = 50;
            this.lbl_inNo.Text = "Incoming No";
            this.lbl_inNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 356;
            this.label1.Text = "Remark";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 130);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Window;
            this.btn_search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(633, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 21);
            this.btn_search.TabIndex = 54;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_inYmd
            // 
            this.lbl_inYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inYmd.ImageIndex = 1;
            this.lbl_inYmd.ImageList = this.img_Label;
            this.lbl_inYmd.Location = new System.Drawing.Point(8, 55);
            this.lbl_inYmd.Name = "lbl_inYmd";
            this.lbl_inYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_inYmd.TabIndex = 50;
            this.lbl_inYmd.Text = "Incoming Date";
            this.lbl_inYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 129);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style105;
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
            this.cmb_factory.EvenRowStyle = style106;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style107;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style108;
            this.cmb_factory.HighLightRowStyle = style109;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 33);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style110;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style111;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style112;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 33);
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
            this.pic_head7.Size = new System.Drawing.Size(101, 105);
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
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 130);
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
            this.pic_head6.Location = new System.Drawing.Point(0, 0);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 128);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(160, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(912, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_menu.Controls.Add(this.btn_Tree);
            this.pnl_menu.Controls.Add(this.btnOutside);
            this.pnl_menu.Controls.Add(this.btn_recover);
            this.pnl_menu.Controls.Add(this.btn_insert);
            this.pnl_menu.Controls.Add(this.btn_cancel);
            this.pnl_menu.Location = new System.Drawing.Point(12, 550);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(992, 30);
            this.pnl_menu.TabIndex = 170;
            // 
            // btn_Tree
            // 
            this.btn_Tree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Tree.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tree.ImageIndex = 13;
            this.btn_Tree.ImageList = this.image_List;
            this.btn_Tree.Location = new System.Drawing.Point(667, 4);
            this.btn_Tree.Name = "btn_Tree";
            this.btn_Tree.Size = new System.Drawing.Size(80, 24);
            this.btn_Tree.TabIndex = 385;
            this.btn_Tree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Tree.Click += new System.EventHandler(this.btn_Tree_Click);
            this.btn_Tree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Tree_MouseDown);
            this.btn_Tree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Tree_MouseUp);
            // 
            // btnOutside
            // 
            this.btnOutside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btnOutside.Font = new System.Drawing.Font("굴림", 9F);
            this.btnOutside.ImageIndex = 0;
            this.btnOutside.ImageList = this.img_Button;
            this.btnOutside.Location = new System.Drawing.Point(8, 4);
            this.btnOutside.Name = "btnOutside";
            this.btnOutside.Size = new System.Drawing.Size(80, 23);
            this.btnOutside.TabIndex = 384;
            this.btnOutside.Text = "Out-Scan";
            this.btnOutside.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOutside.Click += new System.EventHandler(this.btnOutside_Click);
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(907, 4);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 24);
            this.btn_recover.TabIndex = 367;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_recover_MouseDown);
            this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_recover_MouseUp);
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_insert.ImageIndex = 9;
            this.btn_insert.ImageList = this.image_List;
            this.btn_insert.Location = new System.Drawing.Point(747, 3);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(80, 26);
            this.btn_insert.TabIndex = 360;
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            this.btn_insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseDown);
            this.btn_insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseUp);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ImageIndex = 5;
            this.btn_cancel.ImageList = this.image_List;
            this.btn_cancel.Location = new System.Drawing.Point(827, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 23);
            this.btn_cancel.TabIndex = 359;
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseDown);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
            // 
            // lbl_headInfo
            // 
            this.lbl_headInfo.Location = new System.Drawing.Point(0, 0);
            this.lbl_headInfo.Name = "lbl_headInfo";
            this.lbl_headInfo.Size = new System.Drawing.Size(100, 23);
            this.lbl_headInfo.TabIndex = 0;
            // 
            // Form_BI_Incoming
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BI_Incoming";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BI_Incoming_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            this.pnl_menu.ResumeLayout(false);
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

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int[] vSelectionRange = fgrid_main.Selections;
			int vCol = fgrid_main.Selection.c1;		
			int vRow = fgrid_main.Selection.r1 - 2;
			int vCount = 0;
			decimal vInSum = 0;

			if (vSelectionRange.Length == 0)	return;

			foreach (int i in vSelectionRange) 
			{
				try 
				{ 
					vInSum  += decimal.Parse(fgrid_main[i, _inQtyCol].ToString());
				}
				catch (Exception ex)
				{
					vInSum  += 0;
				}
				vCount +=1 ; 
			}	
			txt_Count.Text    = vCount.ToString();
			txt_Sum.Text      = vInSum.ToString();
		}

		

		private void Grid_AfterEditProcess()
		{
			fgrid_main.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}
		
		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{ 
			this.Tbtn_SearchProcess(true);
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SaveProcess(true);
		}					

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_DeleteProcess();
		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_ConfirmProcess();
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
			Check_sizeYN();

			this.Dispose(true);
		}

		private void Form_BI_Incoming_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Grid에 수정된 내역이 있는 경우 close 여부를 확인한다.
			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			try
			{	
				// Item을 팝업에서 선택하면 입고내역을 한줄 추가한다. 
				FlexBase.MaterialBase.Pop_Item_List vPopup = new FlexBase.MaterialBase.Pop_Item_List();
				vPopup.ShowDialog(); 
			
				if (COM.ComVar.Parameter_PopUp[0] != "")
				{
					_practicable = false;

					int row = fgrid_main.Rows.Count;
					fgrid_main.Add_Row(row - 1);
					int vInSeq = 0;
					
					if (!row.Equals(fgrid_main.Rows.Fixed))
						vInSeq = int.Parse(fgrid_main[row -1, _inSeqCol].ToString());

					fgrid_main[row, (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY] = cmb_factory.SelectedValue;
					fgrid_main[row, _inSeqCol]		= vInSeq + 1 ;
					fgrid_main[row, _seqCol]		= row +1 - fgrid_main.Rows.Fixed ;
					fgrid_main[row, _itemCdCol]		= ClassLib.ComVar.Parameter_PopUp[0];
					fgrid_main[row, _itemNameCol]	= ClassLib.ComVar.Parameter_PopUp[1];
					fgrid_main[row, _specCdCol]		= ClassLib.ComVar.Parameter_PopUp[2];
					fgrid_main[row, _specNameCol]	= ClassLib.ComVar.Parameter_PopUp[3];
					fgrid_main[row, _colorCdCol]	= ClassLib.ComVar.Parameter_PopUp[4];
					fgrid_main[row, _colorNameCol]	= ClassLib.ComVar.Parameter_PopUp[5];
					fgrid_main[row, _unitCol]		= ClassLib.ComVar.Parameter_PopUp[6];
				
					_practicable = true;
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			//fgrid_main.Delete_Row();

			for(int i=_rowfixed; i<fgrid_main.Rows.Count; i++)
			{
				if(fgrid_main.Rows[i].Selected)
				{
					if(fgrid_main[i, 0] == null || fgrid_main[i, 0].ToString() != "I") fgrid_main[i,0] = "D";
				}
			}
		}

		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			this.Recovery();
		}
		
		private void btn_barcode_Click(object sender, System.EventArgs e)
		{
			this.Btn_barcodeClickProcess();		
		}

		private void btn_purchase_Click(object sender, System.EventArgs e)
		{
			this.Btn_purchaseClickProcess();		
		}
		
		private void btn_noShipping_Click(object sender, System.EventArgs e)
		{
			this.Btn_noShippingClickProcess();		
		}

		private void btn_invoice_Click(object sender, System.EventArgs e)
		{
			this.Btn_invoiceClickProcess();		
		}

		private void btnOutside_Click(object sender, System.EventArgs e)
		{
			this.Btn_OutsideScanProcess();	
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			this.Btn_SearchClickProcess();
		}

		private void btn_sizeSearch_Click(object sender, System.EventArgs e)
		{
			this.Btn_sizeSearchClickProcess();
		}

		private void btn_change_Click(object sender, System.EventArgs e)
		{
			this.Btn_changeClickProcess();
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			_vInNo	= ""; 
			this.Cmb_inNoSettingProcess(true);

			if (!_initYn)
				this.ClosingCheckProcess(true); 	
		

			fgrid_main.Rows.Count = _rowfixed;
		}

		private void dpick_inYmd_CloseUp(object sender, System.EventArgs e)
		{
			_vInNo	= ""; 
			this.Cmb_inNoSettingProcess(true);	

			if (!_initYn)
				this.ClosingCheckProcess(true); 			
		}

		private void cmb_inNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_inNoSelectedValueChangedProcess();
		}

		private void cmb_inSize_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (cmb_inSize.SelectedIndex > -1)
			{
				_vOldFactory	= this.cmb_factory.SelectedIndex > -1 ? this.cmb_factory.SelectedValue.ToString() : "";
				_vOldInNo		= this.cmb_inNo.SelectedIndex > -1 ? this.cmb_inNo.SelectedValue.ToString().Trim() : "";
				_vSizeYN		= this.cmb_inSize.SelectedIndex > -1 ? this.cmb_inSize.SelectedValue.ToString() : "";

				if (cmb_inNo.SelectedIndex > 0 )
					btn_sizeSearch.Enabled = cmb_inSize.SelectedValue.ToString() == "Y" ? true : false;
			}
		}

		/// <summary>
		/// Recovery : 복원
		/// </summary>		
		public void Recovery()
		{
			string s ;
			try 
			{					
				for(int i = fgrid_main.Rows.Count-1; i >= fgrid_main.Rows.Fixed ; i--)
				{	
					s = (fgrid_main[i, 0] == null) ? "" : fgrid_main[i, 0].ToString();
					
					if(s == "I")
					{
						fgrid_main.Rows.Remove(i); 
					}
				} 
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Recovery",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}			
		}
	
	
		#region 입력이동

		#endregion

		#region 버튼효과

		#endregion

		#region 롤오버 이미지 처리
		
		private void btn_Tree_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Tree.ImageIndex = 13;
		}

		private void btn_Tree_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Tree.ImageIndex = 12;
		}
		
		private void btn_insert_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_insert.ImageIndex = 9;
		}

		private void btn_insert_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_insert.ImageIndex = 8;
		}
 
		private void btn_cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_cancel.ImageIndex = 5;
		}

		private void btn_cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_cancel.ImageIndex = 4;
		}

		private void btn_recover_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		private void btn_recover_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}
		#endregion


		#endregion

		#region 버튼 이벤트 처리

		private void Btn_SearchClickProcess()
		{
			Pop_BI_Incoming_InNo vPopup = new Pop_BI_Incoming_InNo();
			COM.ComVar.Parameter_PopUp		= new string[1];
			COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");

			if (vPopup.ShowDialog() == DialogResult.OK)
			{
				_practicable = false;
				cmb_factory.SelectedValue		= COM.ComVar.Parameter_PopUp[0];
				dpick_inYmd.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
				_practicable = true;
				Cmb_inNoSettingProcess(true);
				cmb_inNo.SelectedValue			= COM.ComVar.Parameter_PopUp[2];
			}

			vPopup.Dispose();
		}

		private void Btn_sizeSearchClickProcess()
		{
			Pop_BI_Incoming_InSize vPopup = new Pop_BI_Incoming_InSize();
			COM.ComVar.Parameter_PopUp		= new string[3];
			COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			COM.ComVar.Parameter_PopUp[1]	= dpick_inYmd.Text.Replace("-","");
			COM.ComVar.Parameter_PopUp[2]	= ClassLib.ComFunction.Empty_Combo(cmb_inNo, "");

			vPopup.ShowDialog();
			vPopup.Dispose();
		}





		private void Btn_barcodeClickProcess()
		{
			COM.ComVar.Parameter_PopUp		= new string[3];
			COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			COM.ComVar.Parameter_PopUp[1]	= dpick_inYmd.Text.Replace("-","");
			COM.ComVar.Parameter_PopUp[2]	= ClassLib.ComFunction.Empty_Combo(cmb_outside, "");

			int[] vChecks = new int[]{_styleCdCol, _itemCdCol, _specCdCol, _colorCdCol, _barCodeCol};
			Pop_BI_Incoming_Barcode vPopup = new Pop_BI_Incoming_Barcode(fgrid_main, vChecks);

			vPopup.Show();

		}

		private void Btn_purchaseClickProcess()
		{
			COM.ComVar.Parameter_PopUp		= new string[2];
			COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			COM.ComVar.Parameter_PopUp[1]	= dpick_inYmd.Text.Replace("-","");

			int[] vChecks = new int[]{_styleCdCol, _itemCdCol, _specCdCol, _colorCdCol, _purNoCol};
			Pop_BI_Incoming_Purchase vPopup = new Pop_BI_Incoming_Purchase(fgrid_main, vChecks);

			vPopup.Show();
			
		
		}

		private void Btn_noShippingClickProcess()
		{
			COM.ComVar.Parameter_PopUp		= new string[2];
			COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			COM.ComVar.Parameter_PopUp[1]	= dpick_inYmd.Text.Replace("-","");

			int[] vChecks = new int[]{_styleCdCol, _itemCdCol, _specCdCol, _colorCdCol, _barCodeCol};
			Pop_BI_Incoming_NoShipping vPopup = new Pop_BI_Incoming_NoShipping(fgrid_main, vChecks);

			vPopup.Show();
			
		
		}

		private void Btn_invoiceClickProcess()
		{
			COM.ComVar.Parameter_PopUp		= new string[2];
			COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			COM.ComVar.Parameter_PopUp[1]	= dpick_inYmd.Text.Replace("-","");

			int[] vChecks = new int[]{_styleCdCol, _itemCdCol, _specCdCol, _colorCdCol};
			Pop_BI_Incoming_Invoice vPopup = new Pop_BI_Incoming_Invoice(fgrid_main, vChecks);

			vPopup.Show();
			
			
		}

		
		private void Btn_OutsideScanProcess()
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want Outside Scan?", "Run", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					
					if (!RUN_OUTSIDE_VENDOR())
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
						return;
					}

					DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

					if(ds_ret == null) // 저장 실패
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
						return;
					}
		
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);

				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}	
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		private void Btn_changeClickProcess()
		{
			try
			{ 

				this.Cursor = Cursors.WaitCursor;



				string vInNo	= COM.ComFunction.Empty_Combo(cmb_inNo, "");

				if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want Change Incoming Date?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					_vChgFalg	= true;			
					
					// SBI_IN_HEAD 저장 Parameter DataTable을 만들어 DataSet에 추가한다.
					if (!SAVE_SBI_IN_HEAD("", vInNo))
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}

					// 저장
					DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

					if(ds_ret == null) // 저장 실패
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}
 


					this.dpick_inYmd.Text    = this.dpick_chgInYmd.Text;
					this.Tbtn_SearchProcess(false);					
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					_vChgFalg	= false;			
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}	
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		#endregion

		#region 공통 메서드

		private void GridSetSelectCorrection(FarPoint.Win.Spread.Model.CellRange arg_range)
		{
			int vStartRow    = arg_range.Row;
			int vEndRow	     = arg_range.Row + arg_range.RowCount;

			if (fgrid_main[vStartRow, 0] == null)
			{
				fgrid_main.Update_Row(vStartRow);
			}
			else
			{
				fgrid_main[vStartRow,0] = "";
			}

			while (vStartRow < vEndRow)
			{
				vStartRow++;
			}
		}

		private string[] GetSearchProviso()
		{
			string[] vProviso = new string[2];
			vProviso[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			vProviso[1] = (_vChgFalg) ? dpick_chgInYmd.Text.Replace("-", "") : dpick_inYmd.Text.Replace("-", "");

			return vProviso;
		}


		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary> 
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
			_initYn	= true;

            lbl_MainTitle.Text = "Incoming";
            this.Text = lbl_MainTitle.Text;
            ClassLib.ComFunction.SetLangDic(this);

			_practicable = true;

			// Grid Setting
			fgrid_main.Set_Grid("SBI_IN_TAIL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;
			_rowfixed = fgrid_main.Rows.Count;
			
			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			if (ClassLib.ComVar.This_Factory == "VJ" || ClassLib.ComVar.This_Factory == "QD" || ClassLib.ComVar.This_Factory == "JJ") // 해외사용자
			{
				btn_invoice.Enabled		= true; 
				btn_barcode.Enabled		= false;
				btn_purchase.Enabled	= true;
				btn_noShipping.Enabled	= false;
			}
			else
			{
				btn_invoice.Enabled		= false;  
				btn_barcode.Enabled		= true;
				btn_purchase.Enabled	= true;
				btn_noShipping.Enabled	= true;
			}

			// size yn set    cmb_inSize
			_vDT = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SEM07");
			COM.ComCtl.Set_ComboList(_vDT, cmb_inSize, 1, 2, false, 56,0);
			cmb_inSize.SelectedIndex = -1;

			// pur_div set    cmb_purDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_purDiv, 1, 2, false, 56,0);
			cmb_purDiv.SelectedIndex = 0;

			// buy_div set    cmb_buyDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC01");
			COM.ComCtl.Set_ComboList(vDt, cmb_buyDiv, 1, 2, false, 56,0);
			cmb_buyDiv.SelectedIndex = -1;

			// in_type set    cmb_inType
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBI01");
			COM.ComCtl.Set_ComboList(vDt, cmb_inType, 1, 2, false, 56,0);
			cmb_inType.SelectedIndex = -1;

			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SEM35");
			COM.ComCtl.Set_ComboList(vDt, cmb_outside, 1, 2, true, 56,0);
			cmb_outside.SelectedIndex = 1;

			// user define variable set
			_cmbInNoEventHandler		= new System.EventHandler(this.cmb_inNo_SelectedValueChanged);
			
			_vTempDate = System.DateTime.Now.ToString();

			// Disabled tbutton
			tbtn_Confirm.Enabled	= false;
			tbtn_Create.Enabled		= false;

			// set grid cell type
			// cell type이 Combo인 경우 리스트의 Value를 HashTable에 관리한다. 
			// Value Change 팝업을 띄웠을때 팝업에 있는 Combo에 Value Paramater를 넘겨주기 위한 사전작업이다.
			_cellData  = new Hashtable(fgrid_main.Cols.Count);
			_cellCombo = new Hashtable(fgrid_main.Cols.Count);
			IDictionary vDic = null;
			IEnumerator vEnum  = null;
			IEnumerator vEnum2 = null;
			string[] vTemp = null;
			string[] vData = null;

			for (int vCol = 1, vCnt = 0 ; vCol < fgrid_main.Cols.Count ; vCol++)
			{
				if (fgrid_main.Cols[vCol].AllowEditing)
				{
					if (fgrid_main.Cols[vCol].DataMap != null)
					{
						vDic = fgrid_main.Cols[vCol].DataMap;
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
		
 

			for (int vCol = 1; vCol < fgrid_main.Cols.Count ; vCol++)
			{


				//				if(fgrid_main.Cols[vCol].DataType.Equals(typeof(double) ) )
				//				{
				// 
				//					fgrid_main.Cols[vCol].Format = "#,##0.0000";
				//
				//				} // end if


				
				 

				if(vCol == _purPriceCol 
					|| vCol == _outsidePriceCol 
					|| vCol == _cbdPriceCol 
					|| vCol == _shipPriceCol 
					|| vCol == _ledgerPriceCol)
				{

					
					if(ClassLib.ComVar.This_Factory == "QD" || ClassLib.ComVar.This_Factory == "VJ" || ClassLib.ComVar.This_Factory == "JJ")
					{
						fgrid_main.Cols[vCol].Format = "#,##0.0000";
					}
					//					else
					//					{
					//						fgrid_main.Cols[vCol].Format = "#,##0.00";
					//					}

					

				}
				


 
			} // end for vCol





			_initYn	= false; 

			// 자재 재고 마감 여부 체크
			this.ClosingCheckProcess(true); 


			//			//Test용
			//			if (ClassLib.ComVar.This_Factory  ==  "DS") 
			//				lbl_BarDate.Visible  = true;
			//			else
			//				lbl_BarDate.Visible  = false;

		}
		
		private void ValueExchangeProcessing(int vCol)
		{
			try
			{ 
				ClassLib.ComVar.Parameter_PopUp_Object  = null;
				ClassLib.ComVar.Parameter_PopUp_Object2 = null;
				ClassLib.ComVar.Parameter_PopUpTable	= null; 

				int[] vSelectionRange = fgrid_main.Selections;
				
				if (vSelectionRange != null)
				{
					// Value Change 팝업의 제목을 위해 선택한 컬럼의 head 명을 Parameter로 추가한다. 
					COM.ComVar.Parameter_PopUp		= new string[1];
					COM.ComVar.Parameter_PopUp[0]	= fgrid_main[1, vCol].ToString();
				
					// 그리드의 cell type이 Combo 인 경우 Paramater에 HashTable을 추가한다. 
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
							fgrid_main[i, vCol] = COM.ComVar.Parameter_PopUp[0];
							if( vCol.Equals(_custCdCol) )
							{
								fgrid_main[i, vCol +1]	= COM.ComVar.Parameter_PopUp[0];    // Set Vendor Name Text
							
								if (COM.ComVar.Parameter_PopUp.Length > 1)
									fgrid_main[i, vCol]		= COM.ComVar.Parameter_PopUp[1];// Set Vendor Code Value
							}
							else
							{
								fgrid_main[i, vCol]		= COM.ComVar.Parameter_PopUp[0];    // Set TextBox Text
							
								if (COM.ComVar.Parameter_PopUp.Length > 1)
									fgrid_main[i, vCol]		= COM.ComVar.Parameter_PopUp[1];	// Set SSPComboBox Value
							}

							fgrid_main.Update_Row(i);
						}

					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_ValueExchange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				_vOldInNo		= "";
				_vOldFactory	= "";
				_vOldSizeYn		= "";
				_vSizeYN		= "";

				fgrid_main.ClearAll();
				cmb_inType.SelectedIndex	= -1;
				//cmb_purDiv.SelectedIndex	= -1;				
				cmb_buyDiv.SelectedIndex	= -1;	
				cmb_inSize.SelectedIndex	= -1;	
				btn_sizeSearch.Enabled		= false;
				txt_inStatus.Text			= "";	
				txt_lcNo.Text				= "";	
				txt_invNo.Text				= "";
				txt_remarks.Text			= "";

				btn_insert.Enabled		= true;
				btn_cancel.Enabled		= true;
				btn_recover.Enabled		= true;
				tbtn_Save.Enabled		= true;
				tbtn_Delete.Enabled		= true;
				tbtn_Confirm.Enabled	= false;
				fgrid_main.AllowEditing	= true;

				if (ClassLib.ComVar.This_Factory == "VJ" || ClassLib.ComVar.This_Factory == "QD" || ClassLib.ComVar.This_Factory == "JJ") // 해외사용자
				{
					btn_invoice.Enabled		= true; 
					btn_barcode.Enabled		= false;
					btn_purchase.Enabled	= true;
					btn_noShipping.Enabled	= false;
				}
				else
				{
					btn_invoice.Enabled		= false; 
					btn_barcode.Enabled		= true;
					btn_purchase.Enabled	= true;
					btn_noShipping.Enabled	= true;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void Tbtn_SearchProcess(bool arg_bool)
		{
			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 

			// 조회시 필수조건을 체크한다. 
			if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
			{
				Check_sizeYN();

				_vFactory		= cmb_factory.SelectedValue.ToString();
				_vInYmd			= dpick_inYmd.Text.Replace("-", "");
				if (arg_bool)	_vInNo	= cmb_inNo.SelectedIndex > 0 ? cmb_inNo.SelectedValue.ToString().Trim() : "";

				this.Tbtn_NewProcess();
				this.SearchHeadInfo();
				this.SearchTailInfo();
			}
		}

		private void Tbtn_PrintProcess()
		{
			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
			System.Windows.Forms.TextBox[] txt_array = {}; 

			if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
			{
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming");

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_inNo, "") +		"' ";
				sPara += "'" + this.dpick_inYmd.Text.Replace("-","") +		"' ";
				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

				MyReport.Text = "Incoming sheet";
				MyReport.Show();	
			}			
		}

		private void Check_sizeYN()
		{
			try
			{  
				if (_vSizeYN != "" && _vOldSizeYn != "" && _vSizeYN != _vOldSizeYn)
				{
					if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you Save Size Infomation?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
					{
						SAVE_SBI_IN_HEAD_SIZE();
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}

		private void Tbtn_AfterSaveProcess(bool arg_bool)
		{
			try
			{				
				if (cmb_factory.SelectedIndex > -1)
				{
					_vFactory		= cmb_factory.SelectedValue.ToString();
					_vInYmd			= dpick_inYmd.Text.Replace("-", "");
					if (arg_bool)	_vInNo	= cmb_inNo.SelectedIndex > 0 ? cmb_inNo.SelectedValue.ToString().Trim() : "";

					this.SearchHeadInfo();
					
					// Save 이후 Research 하지 않고 삭제 플래그인 Row는 삭제하고 다른 플래그는 clear 한다.
					for(int i = fgrid_main.Rows.Count - 1; i >= fgrid_main.Rows.Fixed; i--)
					{
						if(fgrid_main[i,0] == null || fgrid_main[i, 0].ToString() == "") continue; 
							

						if( fgrid_main[i, 0].ToString() == "D" )
						{ 
							fgrid_main.Rows.Remove(i);
						}
						else
						{
							fgrid_main[i, 0] = "";
						}
					}

					for ( int vRow = fgrid_main.Rows.Fixed; vRow < fgrid_main.Rows.Count; vRow++ )
					{
						fgrid_main[vRow, _seqCol]	 = vRow +1 - fgrid_main.Rows.Fixed;
						fgrid_main[vRow, _modQtyCol] = fgrid_main[vRow, _inQtyCol];

						for (int vCol = 1 ; vCol < fgrid_main.Cols.Count; vCol++)
						{
							if ( fgrid_main.Cols[vCol].AllowEditing )
								fgrid_main.GetCellRange(vRow, vCol).StyleNew.ForeColor = COM.ComVar.ClrImportant;
						}
					}

					this.EnableControlCheckProcess(true);	// Control Enable Check
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

		private void Tbtn_SaveProcess(bool arg_bool)
		{
			try
			{ 
				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory, cmb_inType}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 



				if(cmb_purDiv.SelectedIndex == -1 && cmb_buyDiv.SelectedIndex == -1)
				{
					MessageBox.Show("Select Pur Divisoin Or Buy Division Value !!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
					if(cmb_purDiv.SelectedIndex == -1)
					{
						cmb_purDiv.Focus();
					}
					else if(cmb_buyDiv.SelectedIndex == -1)
					{
						cmb_buyDiv.Focus();
					}


					return;

				}

				// 조회조건의 필수입력 체크
				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					DialogResult result = new DialogResult(); 

					if (arg_bool) 
					{	
						result = ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					}
					if ((!arg_bool) || result.ToString() == "Yes")
					{
						// Grid의 커서를 옮겨 수정된 자료에 Flag를 강제로 붙일수 있게 한다.
						fgrid_main.Select(fgrid_main.Selection.r1, fgrid_main.Selection.c1); 
						int row  = fgrid_main.Rows.Count;

						// 입고 TYPE이 '3'(RETURN)인 경우 반품이므로 - 값으로 처리해야 한다.
						if ( this.cmb_inType.SelectedIndex > 0  && this.cmb_inType.SelectedValue.ToString() == "3")  // Return인 경우 -값 입력 체크
						{
							for (int j = fgrid_main.Rows.Fixed; j < row; j++)
							{
								if (decimal.Parse(fgrid_main[j, _inQtyCol].ToString()) > 0)
								{
									ClassLib.ComFunction.User_Message("If Select Input_Type[Return] Then You Input Data - Value!");
									return;
								}
							}
						}
						
						string vInNo = ""; 
						if (_vInNo == "")
						{
							// InNo Select- SBC_DOCUMENT 테이블에서 입고번호 SELECT 
							string vFactory		= COM.ComFunction.Empty_Combo(cmb_factory, "");
							string vDocDivision = ClassLib.ComVar.INCOMING;
							string vDocType		= COM.ComFunction.Empty_Combo(cmb_inType, "");
							string vDate		= dpick_inYmd.Text.Substring(0,10).Replace("-",""); //System.DateTime.Today.ToString().Substring(0,10).Replace("-",""); 
							string vUser		= COM.ComVar.This_User;
						 
							DataTable vDt = ClassLib.ComFunction.SELECT_DOCUMENT_NO(vFactory, vDocDivision, vDocType, vDate, vUser);

							vInNo = vDt.Rows[0].ItemArray[0].ToString().Trim();
						}
						else
							vInNo = _vInNo; 

						// SBI_IN_HEAD 저장 Parameter DataTable을 만들고 DataSet에 추가한다. 
						if (!SAVE_SBI_IN_HEAD("", vInNo))
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}

						if (this.cmb_inSize.SelectedIndex > -1)
							_vOldSizeYn = this.cmb_inSize.SelectedValue.ToString();

						if (row > fgrid_main.Rows.Fixed && ( vInNo != null && vInNo != "" ) )
						{
							for (int i = fgrid_main.Rows.Fixed; i < row; i++)
							{
								fgrid_main[i, _inNoCol]			= vInNo;
							}
						}
						 
						// SBI_IN_TAIL 저장 Parameter DataTable을 만들고 DataSet에 추가한다. 
						if (!MyOraDB.Save_FlexGird_Ready("PKG_SBI_IN_TAIL.SAVE_SBI_IN_TAIL", fgrid_main, false))
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}

						// 저장 완료
						if (MyOraDB.Exe_Modify_Procedure_all())
						{
							if (cmb_inNo.SelectedIndex < 1 ) 
							{
								_vInNo = vInNo;
								this.Cmb_inNoSettingProcess(false);
								Tbtn_AfterSaveProcess(false);
							}
							else
							{
								Tbtn_AfterSaveProcess(true);
							}
							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
						}
						else
							return;

						_vNewInNoSet = false;
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}

		private void Tbtn_ConfirmProcess()
		{
			try
			{ 
				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 
				
				// 조회조건의 필수입력 체크
				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					// 그리드의 필수입력 체크
					// int_array 에 정의된 컬럼 데이타를 체크하여 null인경우 해당 컬럼으로 커서를 이동한다. 
					int[] int_array = {_inQtyCol, _purCurrencyCol, _purPriceCol, _custCdCol, _whCdCol }; //, _payCdCol 
					if ( !ClassLib.ComFunction.EmptyCellCheck(fgrid_main, int_array))
					{
						string vInNo	= COM.ComFunction.Empty_Combo(cmb_inNo, "");

						if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
						{
							// Confirm 이전에 수정된 데이타가 있으면 저장 프로시져를 수행한다.
							for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
							{
								if (fgrid_main[vRow, 0] != null && fgrid_main[vRow, 0].ToString() != "")
								{
									Tbtn_SaveProcess(false); 
								}
							}		
							
							// SBI_IN_HEAD 저장 Parameter DataTable을 DataSet에 추가한다. 
							if (!SAVE_SBI_IN_HEAD("C", vInNo))
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
								return;
							}

							// 저장
							DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

							if(ds_ret == null) // 저장 실패
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
								return;
							}
  

							bool save_acc_flag = false;

							// 회계 연결 전표 위한 데이터 제공 
							if(ClassLib.ComVar.This_Factory == "QD")
							{

								this.Cursor = Cursors.WaitCursor;

								save_acc_flag = SAVE_SBI_ACCOUNT_INF(); 
							} 
							else
							{
								save_acc_flag = true;
							}// end if(ClassLib.ComVar.This_Factory == "QD")

					  
							if(! save_acc_flag)
							{
								ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
								return;
							}

							
							this.SearchHeadInfo();

							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
							ClassLib.ComFunction.User_Message("Completed Comfirm", "Confirm_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
							this.EnableControlCheckProcess(true);	// Control Enable Check
						}
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Tbtn_DeleteProcess()
		{
			try
			{ 
				string  vInNo = COM.ComFunction.Empty_Combo(cmb_inNo, "");
				if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Delete?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					// SBI_IN_HEAD 저장 Parameter DataTable을 DataSet에 추가한다. 
					if (!SAVE_SBI_IN_HEAD("D", vInNo))
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}

					// 저장 완료
					MyOraDB.Exe_Modify_Procedure();
					
					// 삭제 플래그('D')를 그리드의 모든 ROW에 추가한다.
					if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
					{
						fgrid_main.Select(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0);
					}
					fgrid_main.Delete_Row();

					// 그리드 저장 처리
					if (MyOraDB.Save_FlexGird("PKG_SBI_IN_TAIL.SAVE_SBI_IN_TAIL", fgrid_main))
					{
						_vInNo	= ""; 
						this.Cmb_inNoSettingProcess(true);				
					}
				}
			}

			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}
	
		private void SearchHeadInfo()
		{
			if (_vInNo != null && _vInNo != "")
			{
				DataTable vTemp = this.SELECT_SBI_IN_HEAD(_vFactory, _vInNo);
				if (vTemp.Rows.Count > 0 && vTemp.Rows.Count < 2)
				{
					this.ClearHeadInfo();
					this.SetHeadInfo(vTemp);
				}
				else
					this.ClearHeadInfo();
				vTemp.Dispose();
			}
		}

		private void SetHeadInfo(DataTable arg_dt)
		{
			cmb_inNo.SelectedValue		= arg_dt.Rows[0].ItemArray[1];
			cmb_inType.SelectedValue	= arg_dt.Rows[0].ItemArray[3];
			cmb_purDiv.SelectedValue	= arg_dt.Rows[0].ItemArray[4];
			cmb_buyDiv.SelectedValue	= arg_dt.Rows[0].ItemArray[5];
			cmb_inSize.SelectedValue	= arg_dt.Rows[0].ItemArray[6];
			txt_lcNo.Text				= arg_dt.Rows[0].ItemArray[7].ToString();
			txt_invNo.Text				= arg_dt.Rows[0].ItemArray[8].ToString();
			txt_inStatus.Text			= arg_dt.Rows[0].ItemArray[9].ToString();
			txt_remarks.Text			= arg_dt.Rows[0].ItemArray[10].ToString();
			_vOldSizeYn					= arg_dt.Rows[0].ItemArray[6].ToString();

			// btn_sizeSearch Enalbed setting
			btn_sizeSearch.Enabled = arg_dt.Rows[0].ItemArray[6].ToString() == "Y" ? true : false;
		}

		private void ClearHeadInfo()
		{
			cmb_inType.SelectedValue	= 0;
			cmb_purDiv.SelectedValue	= 0;
			cmb_buyDiv.SelectedValue	= 0;
			cmb_inSize.SelectedValue	= 0;
			txt_lcNo.Text				= "";
			txt_invNo.Text				= "";
			txt_inStatus.Text			= "";
			txt_remarks.Text			= "";
		}
	
		private void SearchTailInfo()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				if (_vInNo != null && _vInNo != "")
				{
					// 조회조건에 따라 입고데이타를 Select 하여 DataTable형태로 Return 한다.
					DataTable vTemp = this.SELECT_SBI_IN_TAIL_LIST(_vFactory, _vInNo, _vInYmd);
					//  Return 된 데이타를 Grid에 display 한다. 
					ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_main, vTemp);

					// Row의 수로 Seq 값을 보여준다. 
					if (fgrid_main.Rows.Count > 0 && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
					{
						for ( int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++ )
						{
							fgrid_main[i, _seqCol] = i + 1 - fgrid_main.Rows.Fixed;
						}
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
					}
					else
					{
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
					}

					this.EnableControlCheckProcess(true);	// Control Enable Check
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

		private void Cmb_inNoSettingProcess(bool arg_bool)
		{
			try
			{
				if (_practicable)
				{
					Check_sizeYN();
					cmb_inNo.SelectedValueChanged -= _cmbInNoEventHandler;

					if(arg_bool) this.Tbtn_NewProcess();
					string[] vProviso = GetSearchProviso();
					DataTable vDt = SELECT_SBI_IN_NO(vProviso[0], vProviso[1]);
					COM.ComCtl.Set_ComboList(vDt, cmb_inNo, 0, 1, true, false);
					cmb_inNo.SelectedIndex = 0;
					//					_vInNo	= ""; 
					vDt.Dispose();

					cmb_inNo.SelectedValueChanged += _cmbInNoEventHandler;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ClosingCheckProcess(bool arg_check)
		{
			try
			{
				if (arg_check)
				{
					// 재고마감 여부를 체크한다. 
					string[] vProviso = GetSearchProviso();
					DataTable vDt = FlexPurchase.ClassLib.ComFunction.Select_Close_Yn(vProviso[0], FlexPurchase.ClassLib.ComVar.Month, vProviso[1].Substring(0,6), FlexPurchase.ClassLib.ComVar.Stock);
				
					if (vDt.Rows.Count > 0)
						_vClosingYn = vDt.Rows[0][0].ToString(); 
					else
						_vClosingYn = "N";

					if (_vClosingYn == "Y")
					{
						ClassLib.ComFunction.User_Message("Already Closed Stock At This Month.", "Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}

					this.EnableControlCheckProcess(true);	// Control Enable Check
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void EnableControlCheckProcess(bool arg_bool)
		{
			try
			{
				if (arg_bool)
				{
					if(_vClosingYn == "Y")   // 재고마감이 된 경우 조회를 제외한 모든 작업은 불가하다. 
					{
						tbtn_Confirm.Enabled    = false;
						fgrid_main.AllowEditing	= false;
						tbtn_Save.Enabled		= false;
						tbtn_Delete.Enabled		= false;
						tbtn_Confirm.Enabled	= false;
						btn_insert.Enabled		= false;
						btn_cancel.Enabled		= false;
						btn_recover.Enabled		= false;

						btn_invoice.Enabled		= false; 
						btn_barcode.Enabled		= false;
						btn_purchase.Enabled	= false;
						btn_noShipping.Enabled	= false;
						btn_change.Enabled		= false;

					}
					else
					{
						if (fgrid_main.Rows.Count > 0 && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
							tbtn_Confirm.Enabled  = true;
						else
							tbtn_Confirm.Enabled  = false;

						//if (txt_inStatus.Text.Trim() == "Commit") // 확정된 상태
						if (txt_inStatus.Text.Trim() != "" && txt_inStatus.Text.Trim().Substring(0, 1) == "C") // 확정된 상태
						{										  // 해당 입고번호에 따른 입고내역에 대한 모든 작업은 불가하다. 
							fgrid_main.AllowEditing	= false;	  // 단, 신규로 입고번호를 부여하고 입고내역을 잡는 작업만 가능하다.
							tbtn_Save.Enabled		= false;
							tbtn_Delete.Enabled		= false;
							tbtn_Confirm.Enabled	= false;
							btn_insert.Enabled		= false;
							btn_cancel.Enabled		= false;
							btn_recover.Enabled		= false;

							btn_invoice.Enabled		= false; 
							btn_barcode.Enabled		= false;
							btn_purchase.Enabled	= false;
							btn_noShipping.Enabled	= false;
							btn_change.Enabled		= false;
						}
						else									// 저장된 상태
						{										// 모든 작업 가능하다.
							fgrid_main.AllowEditing	= true;
							tbtn_Save.Enabled		= true;
							tbtn_Delete.Enabled		= true;
							btn_insert.Enabled		= true;
							btn_cancel.Enabled		= true;
							btn_recover.Enabled		= true;

							if (ClassLib.ComVar.This_Factory == "VJ" || ClassLib.ComVar.This_Factory == "QD" || ClassLib.ComVar.This_Factory == "JJ") // 해외사용자
							{
								btn_invoice.Enabled		= true; 
								btn_barcode.Enabled		= false;
								btn_purchase.Enabled	= true;
								btn_noShipping.Enabled	= false;
							}
							else
							{
								btn_invoice.Enabled		= false; 
								btn_barcode.Enabled		= true;
								btn_purchase.Enabled	= true;
								btn_noShipping.Enabled	= true;
							}
							btn_change.Enabled		= true;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Cmb_inNoSelectedValueChangedProcess()
		{
			try
			{
				if (!_vNewInNoSet)
				{
					if (cmb_inNo.SelectedIndex < 0)
						Tbtn_SearchProcess(false);
					Tbtn_SearchProcess(true);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		//		/// <summary>
		//		/// Apply_Grid : 팝업에서 parameter로 넘겨받은 데이타를 그리드에 추가한다. 
		//		/// </summary>
		//		/// <param name="arg_dt"></param>
		//		/// <param name="arg_dt_tail"></param> 
		//		/// <param name="arg_row"></param>
		//		public  void Apply_Grid(DataTable arg_dt)
		//		{
		//			try
		//			{				
		//				this.Cursor = Cursors.WaitCursor;
		//
		//				// 그리드에 새로운 Row를 추가하고 parameter값을 insert 한다.
		//				fgrid_main.Display_Grid_Add(arg_dt, false); 
		//
		//				if (fgrid_main.Rows.Count > 0 && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
		//				{
		//					// head Setting
		//					_practicable	= false;				
		//					this.cmb_factory.SelectedValue	= fgrid_main[fgrid_main.Rows.Fixed, _factoryCol].ToString().Trim();
		//					_practicable	= true;				
		//			
		//					int vRow   = fgrid_main.Rows.Count - arg_dt.Rows.Count; 
		//					int vInSeq = 0;
		// 
		//					// SBI_IN_TAIL의 IN_SEQ 값을 부여한다. (보여지는 SEQ 값과는 별개의 값이다.)
		//					if (!vRow.Equals(fgrid_main.Rows.Fixed))
		//						vInSeq = int.Parse(fgrid_main[vRow -1, _inSeqCol].ToString().Trim());
		//
		//					// Insert Flag를 붙인다.
		//					for (int i = vRow; i < fgrid_main.Rows.Count; i++)
		//					{
		//						vInSeq = vInSeq +1;
		//						fgrid_main[i,0] =  ClassLib.ComVar.Insert;	
		//						fgrid_main[i,_inSeqCol] = vInSeq;
		//					}
		//
		//					for ( int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++ )
		//					{
		//						fgrid_main[row, _seqCol]	 = row +1 - fgrid_main.Rows.Fixed;
		//						fgrid_main[row, _modQtyCol]  = fgrid_main[row, _inQtyCol];
		//
		//						for (int vCol = 1 ; vCol < fgrid_main.Cols.Count; vCol++)
		//						{
		//							if ( fgrid_main.Cols[vCol].AllowEditing )
		//								fgrid_main.GetCellRange(vRow, vCol).StyleNew.ForeColor = COM.ComVar.ClrImportant;
		//						}
		//					}
		//
		//					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
		//				}
		//				else
		//					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
		//			}
		//			catch (Exception ex)
		//			{
		//				ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//			}
		//			finally
		//			{
		//				this.Cursor = Cursors.Default;
		//			}
		//		}


		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBI_IN_NO : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBI_IN_NO : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_IN_NO(string arg_factory, string arg_in_ymd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_NO.SELECT_SBI_IN_NO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_YMD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_in_ymd;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}
		
		/// <summary>
		/// PKG_SBI_IN_TAIL : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBI_IN_TAIL : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_IN_TAIL_LIST(string arg_factory, string arg_in_no, string arg_in_ymd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_TAIL.SELECT_SBI_IN_TAIL_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_NO";
			MyOraDB.Parameter_Name[2] = "ARG_IN_YMD";
			MyOraDB.Parameter_Name[3] = "ARG_LOC_FACTORY";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_in_no;
			MyOraDB.Parameter_Values[2] = arg_in_ymd;
			MyOraDB.Parameter_Values[3] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBI_IN_HEAD : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBI_IN_HEAD : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_IN_HEAD(string arg_factory, string arg_in_no)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_HEAD.SELECT_SBI_IN_HEAD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_in_no;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// SAVE_SBI_IN_HEAD : 헤더 정보 저장
		/// </summary>
		public bool SAVE_SBI_IN_HEAD(string arg_div, string arg_inNo)
		{
			try
			{
				if ( cmb_inNo.SelectedIndex > 0 )
					_vNewInNoSet = false;
				else
					_vNewInNoSet = true;

				MyOraDB.ReDim_Parameter(14);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBI_IN_HEAD.SAVE_SBI_IN_HEAD";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2]  = "ARG_IN_NO";
				MyOraDB.Parameter_Name[3]  = "ARG_IN_YMD";
				MyOraDB.Parameter_Name[4]  = "ARG_IN_TYPE";
				MyOraDB.Parameter_Name[5]  = "ARG_PUR_DIV";
				MyOraDB.Parameter_Name[6]  = "ARG_BUY_DIV";
				MyOraDB.Parameter_Name[7]  = "ARG_IN_SIZE";
				MyOraDB.Parameter_Name[8]  = "ARG_LC_NO";
				MyOraDB.Parameter_Name[9]  = "ARG_INV_NO";
				MyOraDB.Parameter_Name[10] = "ARG_IN_STATUS";
				MyOraDB.Parameter_Name[11] = "ARG_CONFIRM_YN";
				MyOraDB.Parameter_Name[12] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[13] = "ARG_UPD_USER";

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
				MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;

				//04.DATA 정의
				if (arg_div == "D")
				{
					MyOraDB.Parameter_Values[0]  = "D";
					MyOraDB.Parameter_Values[10] = "S";
					MyOraDB.Parameter_Values[11] = "N";
				}
				else if (arg_div == "C")
				{
					MyOraDB.Parameter_Values[0]  = "U";
					MyOraDB.Parameter_Values[10] = "C";
					MyOraDB.Parameter_Values[11] = "Y";
				}
				else
				{
					MyOraDB.Parameter_Values[0]  = cmb_inNo.SelectedIndex > 0 ? "U" : "I";
					MyOraDB.Parameter_Values[10] = "S";
					MyOraDB.Parameter_Values[11] = "N";
				}

				MyOraDB.Parameter_Values[1]  = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[2]  = arg_inNo;
				MyOraDB.Parameter_Values[3]  = (_vChgFalg) ? dpick_chgInYmd.Text.Replace("-", "") : dpick_inYmd.Text.Replace("-", "");
				MyOraDB.Parameter_Values[4]  = COM.ComFunction.Empty_Combo(cmb_inType, "");
				MyOraDB.Parameter_Values[5]  = COM.ComFunction.Empty_Combo(cmb_purDiv, "");
				MyOraDB.Parameter_Values[6]  = COM.ComFunction.Empty_Combo(cmb_buyDiv, "");
				MyOraDB.Parameter_Values[7]  = cmb_inSize.SelectedIndex > -1 ? COM.ComFunction.Empty_Combo(cmb_inSize, "") : "N";
				MyOraDB.Parameter_Values[8]  = COM.ComFunction.Empty_TextBox(txt_lcNo, "");
				MyOraDB.Parameter_Values[9]  = COM.ComFunction.Empty_TextBox(txt_invNo, "");
				MyOraDB.Parameter_Values[12] = COM.ComFunction.Empty_TextBox(txt_remarks, "");
				MyOraDB.Parameter_Values[13] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "SAVE_SBP_REQUEST_HEAD", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}

		/// <summary>
		/// SAVE_SBI_IN_HEAD_SIZE : SIZE 정보 저장
		/// </summary>
		public void SAVE_SBI_IN_HEAD_SIZE()
		{
			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_HEAD.SAVE_SBI_IN_HEAD_SIZE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_IN_NO";
			MyOraDB.Parameter_Name[2]  = "ARG_IN_SIZE";
			MyOraDB.Parameter_Name[3]  = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;

			//04.DATA 정의

			MyOraDB.Parameter_Values[0] = _vOldFactory;
			MyOraDB.Parameter_Values[1] = _vOldInNo;
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_inSize, "");
			MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}



		/// <summary>
		/// SAVE_SBI_ACCOUNT_INF : 회계 연결 전표 위한 데이터 제공
		/// </summary> 
		/// <returns></returns>
		private bool SAVE_SBI_ACCOUNT_INF()
		{

			try
			{

				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST_ACC.SAVE_SBI_ACCOUNT_INF";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1]  = "ARG_IN_NO"; 
				MyOraDB.Parameter_Name[2]  = "ARG_UPD_USER"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0]  = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1]  = COM.ComFunction.Empty_Combo(cmb_inNo, "");
				MyOraDB.Parameter_Values[2]  = COM.ComVar.This_User; 
		
				MyOraDB.Add_Modify_Parameter(true); 
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();			 
				
				if (ds_ret == null) return false; 
				return true;   		
				
			}
			catch 
			{  
				return false;
			}


		}
		

		/// <summary>
		/// RUN_OUTSIDE_VENDOR : SIZE 정보 저장
		/// </summary>
		public bool RUN_OUTSIDE_VENDOR()
		{

			try
			{

				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBS_BAR_IN_OUTSIDE.RUN_SBS_BAR_IN_SCAN";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1]  = "ARG_IN_NO"; 
				MyOraDB.Parameter_Name[2]  = "ARG_UPD_USER"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0]  = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1]  = COM.ComFunction.Empty_Combo(cmb_inNo, "");
				MyOraDB.Parameter_Values[2]  = COM.ComVar.This_User; 
		
				MyOraDB.Add_Modify_Parameter(true); 
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();			 
				
				if (ds_ret == null) return false; 
				return true;   		
				
			}
			catch 
			{  
				return false;
			}
		}



		#endregion

		private void cmb_buyDiv_SelectedValueChanged(object sender, System.EventArgs e)
		{
			//			if(cmb_buyDiv.SelectedIndex == -1) return;
			//
			//			for(int i=_rowfixed; i<fgrid_main.Rows.Count; i++)
			//			{
			//				if(fgrid_main[i, (int)ClassLib.TBSBI_IN_TAIL.IxBUY_DIV].ToString().Trim() == "")
			//				{
			//					if(fgrid_main[i, (int)ClassLib.TBSBI_IN_TAIL.IxDIVISION] == null)
			//					{
			//						fgrid_main[i, (int)ClassLib.TBSBI_IN_TAIL.IxDIVISION] = "U";
			//					}
			//
			//					fgrid_main[i, (int)ClassLib.TBSBI_IN_TAIL.IxBUY_DIV] = cmb_buyDiv.SelectedValue.ToString();
			//				}
			//			}
		}

		private void cmb_purDiv_SelectedValueChanged(object sender, System.EventArgs e)
		{
			//			if(cmb_purDiv.SelectedIndex == -1) return;
			//
			//			for(int i=_rowfixed; i<fgrid_main.Rows.Count; i++)
			//			{
			//				if(fgrid_main[i, (int)ClassLib.TBSBI_IN_TAIL.IxPUR_DIV].ToString().Trim() == "")
			//				{
			//					if(fgrid_main[i, (int)ClassLib.TBSBI_IN_TAIL.IxDIVISION] == null)
			//					{
			//						fgrid_main[i, (int)ClassLib.TBSBI_IN_TAIL.IxDIVISION] = "U";
			//					}
			//
			//					fgrid_main[i, (int)ClassLib.TBSBI_IN_TAIL.IxPUR_DIV] = cmb_purDiv.SelectedValue.ToString();
			//				}
			//			}
		}

		private void fgrid_main_DoubleClick(object sender, System.EventArgs e)
		{

			//	if (! fgrid_main.AllowEditing || ! fgrid_main.Cols[fgrid_main.Col].AllowEditing) return;

			int sct_row = fgrid_main.Selection.r1;
			int sct_col = fgrid_main.Selection.c1;


			if(fgrid_main.Rows.Count > _rowfixed)
			{
			
				string item_code = fgrid_main[sct_row, (int)ClassLib.TBSBI_IN_TAIL.IxITEM_CD].ToString();
				string item_name = fgrid_main[sct_row, (int)ClassLib.TBSBI_IN_TAIL.IxITEM_NAME].ToString();
			
				string spec_code = fgrid_main[sct_row, (int)ClassLib.TBSBI_IN_TAIL.IxSPEC_CD].ToString();
				string spec_name = fgrid_main[sct_row, (int)ClassLib.TBSBI_IN_TAIL.IxSPEC_NAME].ToString();
			
				string color_code = fgrid_main[sct_row, (int)ClassLib.TBSBI_IN_TAIL.IxCOLOR_CD].ToString();
				string color_name = fgrid_main[sct_row, (int)ClassLib.TBSBI_IN_TAIL.IxCOLOR_NAME].ToString();
			


				COM.ComVar.Parameter_PopUp2 = null;

				FlexBase.MaterialBase.Pop_Item_List vPopup = new FlexBase.MaterialBase.Pop_Item_List(true, item_code, item_name, spec_code, spec_name, color_code, color_name);
				vPopup.ShowDialog(); 
			
				if(ClassLib.ComVar.Parameter_PopUp2 != null)
				{
					fgrid_main.Update_Row(sct_row);

					fgrid_main[sct_row, (int)ClassLib.TBSBI_IN_TAIL.IxITEM_CD]   = COM.ComVar.Parameter_PopUp2[0];
					fgrid_main[sct_row, (int)ClassLib.TBSBI_IN_TAIL.IxITEM_NAME] = COM.ComVar.Parameter_PopUp2[1];

					fgrid_main[sct_row, (int)ClassLib.TBSBI_IN_TAIL.IxSPEC_CD]   = COM.ComVar.Parameter_PopUp2[2];
					fgrid_main[sct_row, (int)ClassLib.TBSBI_IN_TAIL.IxSPEC_NAME] = COM.ComVar.Parameter_PopUp2[3];

					fgrid_main[sct_row, (int)ClassLib.TBSBI_IN_TAIL.IxCOLOR_CD]   = COM.ComVar.Parameter_PopUp2[4];
					fgrid_main[sct_row, (int)ClassLib.TBSBI_IN_TAIL.IxCOLOR_NAME] = COM.ComVar.Parameter_PopUp2[5];
				}
			}
		}





		private void menuItem_ValueChange_Click(object sender, System.EventArgs e)
		{
			if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
			{
				int vCol = fgrid_main.Cols[fgrid_main.Col].Index; 
				if (fgrid_main.AllowEditing && fgrid_main.Cols[fgrid_main.Col].AllowEditing)
					ValueExchangeProcessing(vCol);
			}
		}

		private void menuItem_RateExchange_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				//				int vRow = fgrid_main.Rows[fgrid_main.Row].Index;  
				//				int vCol = fgrid_main.Cols[fgrid_main.Col].Index;
				//				string vCol_value = "";
				//
				//				if ( fgrid_main.Rows[vRow].AllowEditing )
				//					vCol_value = fgrid_main[vRow, vCol].ToString();
				//				else 
				//					vCol_value = fgrid_main[vRow-1, vCol].ToString();


				if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed) return;
				if (! fgrid_main.AllowEditing || ! fgrid_main.Cols[fgrid_main.Col].AllowEditing) return;

				int vRow = fgrid_main.Selection.r1;
				int vCol = fgrid_main.Selection.c1;

				if(vCol != (int)ClassLib.TBSBI_IN_TAIL.IxPUR_CURRENCY
					&& vCol != (int)ClassLib.TBSBI_IN_TAIL.IxOUTSIDE_CURRENCY
					&& vCol != (int)ClassLib.TBSBI_IN_TAIL.IxCBD_CURRENCY
					&& vCol != (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_CURRENCY
					&& vCol != (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_CURRENCY) return;
 

				int[] vSelectionRange = fgrid_main.Selections;

 
				Pop_BI_Incoming_Rate_Exchanger pop_changer = new Pop_BI_Incoming_Rate_Exchanger();

				COM.ComVar.Parameter_PopUp		= new string[1];
				COM.ComVar.Parameter_PopUp[0]	= fgrid_main[vRow, vCol].ToString();

				pop_changer.ShowDialog();

				if (COM.ComVar.Parameter_PopUp != null)
				{
					foreach (int i in vSelectionRange)
					{
						if ( fgrid_main.Rows[i].AllowEditing )
						{
							string vCurKind = COM.ComVar.Parameter_PopUp[0];

							decimal vRate, vPrice, vContPrice = 0; 

							switch (vCurKind)
							{
								case "00" :
									if (fgrid_main[i, _purCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _purPriceCol].ToString() == "" ? "0" : fgrid_main[i, _purPriceCol].ToString());
										//vContPrice	=	decimal.Round(vRate * vPrice, 2);
										vContPrice	=	vPrice / vRate;
										fgrid_main[i, _purPriceCol]		= vContPrice;
										fgrid_main[i, _purCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									if (fgrid_main[i, _outsideCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _outsidePriceCol].ToString() == "" ? "0" : fgrid_main[i, _outsidePriceCol].ToString());
										//vContPrice	=	decimal.Round(vRate * vPrice, 2);
										vContPrice	=	vPrice / vRate;
										fgrid_main[i, _outsidePriceCol]		= vContPrice;
										fgrid_main[i, _outsideCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									if (fgrid_main[i, _cbdCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _cbdPriceCol].ToString() == "" ? "0" : fgrid_main[i, _cbdPriceCol].ToString());
										//vContPrice	=	decimal.Round(vRate * vPrice, 2);
										vContPrice	=	vPrice / vRate;
										fgrid_main[i, _cbdPriceCol]		= vContPrice;
										fgrid_main[i, _cbdCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									if (fgrid_main[i, _shipCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _shipPriceCol].ToString() == "" ? "0" :fgrid_main[i, _shipPriceCol].ToString());
										//vContPrice	=	decimal.Round(vRate * vPrice, 2);
										vContPrice	=	vPrice / vRate;
										fgrid_main[i, _shipPriceCol]	= vContPrice;
										fgrid_main[i, _shipCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									if (fgrid_main[i, _ledgerCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _ledgerPriceCol].ToString() == "" ? "0" :fgrid_main[i, _ledgerPriceCol].ToString());
										//vContPrice	=	decimal.Round(vRate * vPrice, 2);
										vContPrice	=	vPrice / vRate;
										fgrid_main[i, _shipPriceCol]	= vContPrice;
										fgrid_main[i, _shipCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									break;

								case "10" :
									if (fgrid_main[i, _purCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _purPriceCol].ToString() == "" ? "0" : fgrid_main[i, _purPriceCol].ToString());
										//vContPrice	=	decimal.Round(vRate * vPrice, 2);
										vContPrice	=	vPrice / vRate;
										fgrid_main[i, _purPriceCol]		= vContPrice;
										fgrid_main[i, _purCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									break;

								case "20" :
									if (fgrid_main[i, _outsideCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _outsidePriceCol].ToString() == "" ? "0" : fgrid_main[i, _outsidePriceCol].ToString());
										//vContPrice	=	decimal.Round(vRate * vPrice, 2);
										vContPrice	=	vPrice / vRate;
										fgrid_main[i, _outsidePriceCol]		= vContPrice;
										fgrid_main[i, _outsideCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									break;

								case "30" :
									if (fgrid_main[i, _cbdCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _cbdPriceCol].ToString() == "" ? "0" : fgrid_main[i, _cbdPriceCol].ToString());
										//vContPrice	=	decimal.Round(vRate * vPrice, 2);
										vContPrice	=	vPrice / vRate;
										fgrid_main[i, _cbdPriceCol]		= vContPrice;
										fgrid_main[i, _cbdCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									break;

								case "40" :
									if (fgrid_main[i, _shipCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _shipPriceCol].ToString() == "" ? "0" :fgrid_main[i, _shipPriceCol].ToString());
										//vContPrice	=	decimal.Round(vRate * vPrice, 2);
										vContPrice	=	vPrice / vRate;
										fgrid_main[i, _shipPriceCol]	= vContPrice;
										fgrid_main[i, _shipCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									break;

								case "50":
									if (fgrid_main[i, _ledgerCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _ledgerPriceCol].ToString() == "" ? "0" :fgrid_main[i, _ledgerPriceCol].ToString());
										//vContPrice	=	decimal.Round(vRate * vPrice, 2);
										vContPrice	=	vPrice / vRate;
										fgrid_main[i, _ledgerPriceCol]	= vContPrice;
										fgrid_main[i, _ledgerCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									break;
							}
							fgrid_main.Update_Row(i);
						}
					}
				}
				pop_changer.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_RateExchange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btn_Tree_Click(object sender, System.EventArgs e)
		{
			FlexPurchase.Shipping.Pop_BP_Purchase_Order_SearchType  sPop = new FlexPurchase.Shipping.Pop_BP_Purchase_Order_SearchType();
			if (sPop.ShowDialog() == DialogResult.OK)
			{
				if (COM.ComVar.Parameter_PopUp[0].Equals("01"))
				{
					Show_Tree_Popup();
				}
				else
				{
					Show_LLT_Item_Popup();
				}
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
				FlexPurchase.Purchase.Pop_BC_Yield_Info  vPop = new FlexPurchase.Purchase.Pop_BC_Yield_Info(fgrid_main, vChecks);
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
				_practicable = false;

				int vRowCount = ClassLib.ComVar.Parameter_PopUpTable.Rows.Count;			
				for(int i = 0 ; i < vRowCount; i++)
				{	
					int row = fgrid_main.Rows.Count;
					fgrid_main.Add_Row(row - 1);
					int vInSeq = 0;
					
					if (!row.Equals(fgrid_main.Rows.Fixed))
						vInSeq = int.Parse(fgrid_main[row -1, _inSeqCol].ToString());

					fgrid_main[row, (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY] = cmb_factory.SelectedValue;
					fgrid_main[row, _inSeqCol]		= vInSeq + 1 ;
					fgrid_main[row, _seqCol]		= row +1 - fgrid_main.Rows.Fixed ;

					fgrid_main[row, _itemCdCol]		= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][0].ToString();
					fgrid_main[row, _itemNameCol]	= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][1].ToString();
					fgrid_main[row, _specCdCol]		= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][2].ToString();
					fgrid_main[row, _specNameCol]	= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][3].ToString();
					fgrid_main[row, _colorCdCol]	= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][4].ToString();
					fgrid_main[row, _colorNameCol]	= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][5].ToString();
					fgrid_main[row, _unitCol]		= ClassLib.ComVar.Parameter_PopUpTable.Rows[i][6].ToString();
 
					fgrid_main[row, (int)ClassLib.TBSBI_IN_TAIL.IxSTYLE_CD ]  = ClassLib.ComVar.Parameter_PopUpTable.Rows[i][8].ToString();
				
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
				FlexPurchase.Purchase.Pop_BP_Item_List iPop = new FlexPurchase.Purchase.Pop_BP_Item_List();
				iPop.factory = this.cmb_factory.SelectedValue;
				
				if(iPop.ShowDialog() == DialogResult.OK)
				{
					DataTable vDt = iPop.SelectedData;

					if (vDt == null)	return;


					for (int idx = 0 ; idx < vDt.Rows.Count ; idx++)
					{ 
						int row = fgrid_main.Rows.Count;
						fgrid_main.Add_Row(row - 1);
						int vInSeq = 0;
					
						if (!row.Equals(fgrid_main.Rows.Fixed))
							vInSeq = int.Parse(fgrid_main[row -1, _inSeqCol].ToString());

						fgrid_main[row, (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY] = cmb_factory.SelectedValue;
						fgrid_main[row, _inSeqCol]		 = vInSeq + 1 ;
						fgrid_main[row, _seqCol]		 = row +1 - fgrid_main.Rows.Fixed ;

						fgrid_main[row, _itemCdCol]		 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxITEM_CD].ToString();
						fgrid_main[row, _itemNameCol]	 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxITEM_NAME].ToString();
						fgrid_main[row, _specCdCol]		 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxSPEC_CD].ToString();
						fgrid_main[row, _specNameCol]	 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxSPEC_NAME].ToString();
						fgrid_main[row, _colorCdCol]	 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCOLOR_CD].ToString();
						fgrid_main[row, _colorNameCol]	 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCOLOR_NAME].ToString();
						fgrid_main[row, _unitCol]		 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxUNIT].ToString();

						fgrid_main[row, _custCdCol]		 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCUST_CD].ToString();
						fgrid_main[row, _custNameCol]	 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCUST_NAME].ToString();

						fgrid_main[row, _purPriceCol]	 = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxPUR_PRICE].ToString();
						fgrid_main[row, _purCurrencyCol] = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxPUR_CURRENCY].ToString();
						fgrid_main[row, _cbdPriceCol]    = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxCBD_PRICE].ToString();
						fgrid_main[row, _cbdCurrencyCol] = vDt.Rows[idx][(int)ClassLib.TBSBP_ITEM_LIST_POP.IxOUTSIDE_CURRENCY].ToString();

					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}






	}
}

