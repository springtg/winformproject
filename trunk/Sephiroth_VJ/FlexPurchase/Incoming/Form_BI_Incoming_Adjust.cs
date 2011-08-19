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
using System.Threading;
using C1.Win.C1FlexGrid;
using System.Text;
using System.IO;
namespace FlexPurchase.Incoming
{
	public class Form_BI_Incoming_Adjust : COM.PCHWinForm.Form_Top
	{  
		# region 컨트롤정의외.
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private C1.Win.C1List.C1Combo cmb_purDiv;
		private C1.Win.C1List.C1Combo cmb_buyDiv;
		private System.Windows.Forms.Label lbl_buyDiv;
		private System.Windows.Forms.Label lbl_purDiv;
		private C1.Win.C1List.C1Combo cmb_inNo;
		private System.Windows.Forms.Label lbl_inNo;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Label lbl_inYmd;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label lbl_priceYN;
		private C1.Win.C1List.C1Combo cmb_user;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_priceYn;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private System.Windows.Forms.ContextMenu cmenu_Adjust;
		private System.Windows.Forms.MenuItem menuitem_RateExchange;
		private System.Windows.Forms.MenuItem menuitem_ValueExchange;
		private System.Windows.Forms.MenuItem menuitem_Header;
		private System.Windows.Forms.MenuItem menuitem_Detail;
		private int _rowFixed = 0;

		

		private COM.FSP fgrid_main;
		private COM.OraDB MyOraDB   = new COM.OraDB();
		private Hashtable _cellCombo = null;
		private Hashtable _cellData  = null;
		private System.EventHandler _cmbInNoEventHandler		= null;
		private System.Windows.Forms.Label lbl_headInfo;
		private System.Windows.Forms.CheckBox chk_confirmYn;

		private bool	_vConfirmYn		= false;
		private bool	_practicable	= false;
		private bool	_isAccessible	= false;
		private bool    _initYn			= false;

		private string  _vClosingYn		= "";
		private string	_vTempDate		= "";

		private int _vSaveCount		= 0;
		private int _vCommitCount	= 0;
		private int	_vActiveCol		= 0;
		private int	_vActiveRow		= 0;
		private int _itemCol				= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxITEM;
		private int _itemCdCol				= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxITEM_CD;
		private int _purPriceCol			= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxPUR_PRICE;
		private int _amountUsdCol			= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxAMOUNT_USD;
		private int _amountKrwCol			= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxAMOUNT_KRW;
		private int _outsideCurrencyCol		= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxOUTSIDE_CURRENCY;
		private int _outsidePriceCol		= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxOUTSIDE_PRICE;
		private int _cbdCurrencyCol			= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxCBD_CURRENCY;
		private int _cbdPriceCol			= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxCBD_PRICE;
		private int _shipCurrencyCol		= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxSHIP_CURRENCY;
		private int _shipPriceCol			= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxSHIP_PRICE;
		private int _custCdCol				= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxCUST_CD;
		private int _inStatusCol			= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_STATUS;
		private int _purCurrencyCol			= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxPUR_CURRENCY;
		private C1.Win.C1List.C1Combo cmb_inUser;
		private System.Windows.Forms.Label lbl_inUser;
		private System.Windows.Forms.ContextMenu cMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.Label btn_check;
		private System.Windows.Forms.Label lbl_total_qty;
		private System.Windows.Forms.Label lbl_amount;
		private System.Windows.Forms.TextBox txt_in_total_qty;
		private System.Windows.Forms.TextBox txt_total_usd_price;
		private System.Windows.Forms.TextBox txt_total_krw_proce;
		private System.Windows.Forms.CheckBox chk_not_ss;
		private System.Windows.Forms.MenuItem menuItem_RateExchange_Adjust;
		private C1.Win.C1List.C1Combo cmb_pur_factory;
		private System.Windows.Forms.Label lbl_SH_CDC;
		private C1.Win.C1List.C1Combo cmb_inType;
		private System.Windows.Forms.Label lbl_inType;
		private System.Windows.Forms.TextBox txt_itemNm;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_styleCd;
		private System.Windows.Forms.Label lbl_styleCd;
		private System.Windows.Forms.CheckBox chk_ship_date;
		private System.Windows.Forms.DateTimePicker dpick_Ship_Date;
		private System.Windows.Forms.Label lbl_Ship_Date;
        private C1.Win.C1List.C1Combo cmb_style;
		private int _inQtyCol				= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_QTY;
//		private int _factoryCol				= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxFACTORY;
//		private int _specCdCol				= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxSPEC_CD;
//		private int _colorCdCol				= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxCOLOR_CD;
//		private int _styleCdCol				= (int)ClassLib.TBSBI_INCOMING_ADJUST.IxSTYLE_CD;

		#endregion

		#region 생성자 / 소멸자
		public Form_BI_Incoming_Adjust()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BI_Incoming_Adjust));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_main = new COM.FSP();
            this.cMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem_RateExchange_Adjust = new System.Windows.Forms.MenuItem();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.chk_ship_date = new System.Windows.Forms.CheckBox();
            this.dpick_Ship_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Ship_Date = new System.Windows.Forms.Label();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.lbl_styleCd = new System.Windows.Forms.Label();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_inType = new C1.Win.C1List.C1Combo();
            this.lbl_inType = new System.Windows.Forms.Label();
            this.cmb_pur_factory = new C1.Win.C1List.C1Combo();
            this.lbl_SH_CDC = new System.Windows.Forms.Label();
            this.chk_not_ss = new System.Windows.Forms.CheckBox();
            this.txt_total_krw_proce = new System.Windows.Forms.TextBox();
            this.txt_total_usd_price = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_in_total_qty = new System.Windows.Forms.TextBox();
            this.lbl_total_qty = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Label();
            this.cmb_inUser = new C1.Win.C1List.C1Combo();
            this.lbl_inUser = new System.Windows.Forms.Label();
            this.chk_confirmYn = new System.Windows.Forms.CheckBox();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.cmb_purDiv = new C1.Win.C1List.C1Combo();
            this.cmb_buyDiv = new C1.Win.C1List.C1Combo();
            this.lbl_buyDiv = new System.Windows.Forms.Label();
            this.lbl_purDiv = new System.Windows.Forms.Label();
            this.cmb_priceYn = new C1.Win.C1List.C1Combo();
            this.lbl_priceYN = new System.Windows.Forms.Label();
            this.cmb_inNo = new C1.Win.C1List.C1Combo();
            this.lbl_inNo = new System.Windows.Forms.Label();
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
            this.cmenu_Adjust = new System.Windows.Forms.ContextMenu();
            this.menuitem_ValueExchange = new System.Windows.Forms.MenuItem();
            this.menuitem_RateExchange = new System.Windows.Forms.MenuItem();
            this.menuitem_Header = new System.Windows.Forms.MenuItem();
            this.menuitem_Detail = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_priceYn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
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
            this.c1ToolBar1.AccessibleName = "Tool Bar";
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink7});
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.tbtn_New);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Search);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Save);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Append);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Insert);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Delete);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Create);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Color);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Print);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Confirm);
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
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(952, 23);
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
            this.c1Sizer1.GridDefinition = "29.3103448275862:False:True;67.9310344827586:False:False;0:False:True;\t0.39370078" +
                "7401575:False:True;97.6377952755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 580);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ContextMenu = this.cMenu;
            this.fgrid_main.Location = new System.Drawing.Point(12, 178);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 19;
            this.fgrid_main.Size = new System.Drawing.Size(992, 394);
            this.fgrid_main.StyleInfo = resources.GetString("fgrid_main.StyleInfo");
            this.fgrid_main.TabIndex = 30;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // cMenu
            // 
            this.cMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem7,
            this.menuItem1,
            this.menuItem6,
            this.menuItem5,
            this.menuItem4,
            this.menuItem_RateExchange_Adjust});
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Confirm";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Confirm All";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.Text = "-";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 3;
            this.menuItem1.Text = "Disconfirm";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Text = "Disconfirm All";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 5;
            this.menuItem5.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 6;
            this.menuItem4.Text = "Value Exchange";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem_RateExchange_Adjust
            // 
            this.menuItem_RateExchange_Adjust.Index = 7;
            this.menuItem_RateExchange_Adjust.Text = "Rate Exchange";
            this.menuItem_RateExchange_Adjust.Visible = false;
            this.menuItem_RateExchange_Adjust.Click += new System.EventHandler(this.menuitem_RateExchange_Click);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.chk_ship_date);
            this.pnl_head.Controls.Add(this.dpick_Ship_Date);
            this.pnl_head.Controls.Add(this.lbl_Ship_Date);
            this.pnl_head.Controls.Add(this.txt_styleCd);
            this.pnl_head.Controls.Add(this.lbl_styleCd);
            this.pnl_head.Controls.Add(this.txt_itemNm);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.txt_itemCd);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.cmb_inType);
            this.pnl_head.Controls.Add(this.lbl_inType);
            this.pnl_head.Controls.Add(this.cmb_pur_factory);
            this.pnl_head.Controls.Add(this.lbl_SH_CDC);
            this.pnl_head.Controls.Add(this.chk_not_ss);
            this.pnl_head.Controls.Add(this.txt_total_krw_proce);
            this.pnl_head.Controls.Add(this.txt_total_usd_price);
            this.pnl_head.Controls.Add(this.lbl_amount);
            this.pnl_head.Controls.Add(this.txt_in_total_qty);
            this.pnl_head.Controls.Add(this.lbl_total_qty);
            this.pnl_head.Controls.Add(this.btn_check);
            this.pnl_head.Controls.Add(this.cmb_inUser);
            this.pnl_head.Controls.Add(this.lbl_inUser);
            this.pnl_head.Controls.Add(this.chk_confirmYn);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.cmb_user);
            this.pnl_head.Controls.Add(this.lbl_user);
            this.pnl_head.Controls.Add(this.lbl_vendor);
            this.pnl_head.Controls.Add(this.txt_vendorCode);
            this.pnl_head.Controls.Add(this.cmb_vendor);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.cmb_purDiv);
            this.pnl_head.Controls.Add(this.cmb_buyDiv);
            this.pnl_head.Controls.Add(this.lbl_buyDiv);
            this.pnl_head.Controls.Add(this.lbl_purDiv);
            this.pnl_head.Controls.Add(this.cmb_priceYn);
            this.pnl_head.Controls.Add(this.lbl_priceYN);
            this.pnl_head.Controls.Add(this.cmb_inNo);
            this.pnl_head.Controls.Add(this.lbl_inNo);
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
            this.pnl_head.Size = new System.Drawing.Size(992, 170);
            this.pnl_head.TabIndex = 29;
            // 
            // cmb_style
            // 
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style1;
            this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_style.ColumnCaptionHeight = 18;
            this.cmb_style.ColumnFooterHeight = 18;
            this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_style.ContentHeight = 16;
            this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_style.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_style.EditorHeight = 16;
            this.cmb_style.EvenRowStyle = style2;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style3;
            this.cmb_style.HeadingStyle = style4;
            this.cmb_style.HighLightRowStyle = style5;
            this.cmb_style.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_style.Images"))));
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(846, 77);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style6;
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style7;
            this.cmb_style.Size = new System.Drawing.Size(140, 20);
            this.cmb_style.Style = style8;
            this.cmb_style.TabIndex = 571;
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            // 
            // chk_ship_date
            // 
            this.chk_ship_date.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_ship_date.Location = new System.Drawing.Point(312, 147);
            this.chk_ship_date.Name = "chk_ship_date";
            this.chk_ship_date.Size = new System.Drawing.Size(18, 16);
            this.chk_ship_date.TabIndex = 570;
            this.chk_ship_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_Ship_Date
            // 
            this.dpick_Ship_Date.CustomFormat = "";
            this.dpick_Ship_Date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_Ship_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_Ship_Date.Location = new System.Drawing.Point(109, 144);
            this.dpick_Ship_Date.Name = "dpick_Ship_Date";
            this.dpick_Ship_Date.Size = new System.Drawing.Size(200, 21);
            this.dpick_Ship_Date.TabIndex = 569;
            // 
            // lbl_Ship_Date
            // 
            this.lbl_Ship_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Ship_Date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ship_Date.ImageIndex = 0;
            this.lbl_Ship_Date.ImageList = this.img_Label;
            this.lbl_Ship_Date.Location = new System.Drawing.Point(8, 144);
            this.lbl_Ship_Date.Name = "lbl_Ship_Date";
            this.lbl_Ship_Date.Size = new System.Drawing.Size(100, 21);
            this.lbl_Ship_Date.TabIndex = 568;
            this.lbl_Ship_Date.Text = "Ship Date";
            this.lbl_Ship_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCd.Location = new System.Drawing.Point(766, 77);
            this.txt_styleCd.MaxLength = 10;
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCd.TabIndex = 567;
            this.txt_styleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCd_KeyUp);
            // 
            // lbl_styleCd
            // 
            this.lbl_styleCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_styleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_styleCd.ImageIndex = 0;
            this.lbl_styleCd.ImageList = this.img_Label;
            this.lbl_styleCd.Location = new System.Drawing.Point(665, 77);
            this.lbl_styleCd.Name = "lbl_styleCd";
            this.lbl_styleCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_styleCd.TabIndex = 565;
            this.lbl_styleCd.Text = "Style";
            this.lbl_styleCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(846, 55);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(140, 21);
            this.txt_itemNm.TabIndex = 564;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style9;
            this.cmb_itemGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_itemGroup.ColumnCaptionHeight = 18;
            this.cmb_itemGroup.ColumnFooterHeight = 18;
            this.cmb_itemGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_itemGroup.ContentHeight = 16;
            this.cmb_itemGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_itemGroup.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_itemGroup.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_itemGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_itemGroup.EditorHeight = 16;
            this.cmb_itemGroup.EvenRowStyle = style10;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style11;
            this.cmb_itemGroup.HeadingStyle = style12;
            this.cmb_itemGroup.HighLightRowStyle = style13;
            this.cmb_itemGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_itemGroup.Images"))));
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(766, 33);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style14;
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style15;
            this.cmb_itemGroup.Size = new System.Drawing.Size(197, 20);
            this.cmb_itemGroup.Style = style16;
            this.cmb_itemGroup.TabIndex = 563;
            this.cmb_itemGroup.TextChanged += new System.EventHandler(this.cmb_itemGroup_TextChanged);
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(964, 33);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 562;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(766, 55);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(79, 21);
            this.txt_itemCd.TabIndex = 561;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(665, 55);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 560;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(665, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 559;
            this.label1.Text = "Item Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_inType
            // 
            this.cmb_inType.AddItemSeparator = ';';
            this.cmb_inType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inType.Caption = "";
            this.cmb_inType.CaptionHeight = 17;
            this.cmb_inType.CaptionStyle = style17;
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
            this.cmb_inType.EvenRowStyle = style18;
            this.cmb_inType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_inType.FooterStyle = style19;
            this.cmb_inType.HeadingStyle = style20;
            this.cmb_inType.HighLightRowStyle = style21;
            this.cmb_inType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_inType.Images"))));
            this.cmb_inType.ItemHeight = 15;
            this.cmb_inType.Location = new System.Drawing.Point(437, 121);
            this.cmb_inType.MatchEntryTimeout = ((long)(2000));
            this.cmb_inType.MaxDropDownItems = ((short)(5));
            this.cmb_inType.MaxLength = 32767;
            this.cmb_inType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inType.Name = "cmb_inType";
            this.cmb_inType.OddRowStyle = style22;
            this.cmb_inType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inType.SelectedStyle = style23;
            this.cmb_inType.Size = new System.Drawing.Size(220, 20);
            this.cmb_inType.Style = style24;
            this.cmb_inType.TabIndex = 558;
            this.cmb_inType.PropBag = resources.GetString("cmb_inType.PropBag");
            // 
            // lbl_inType
            // 
            this.lbl_inType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inType.ImageIndex = 0;
            this.lbl_inType.ImageList = this.img_Label;
            this.lbl_inType.Location = new System.Drawing.Point(336, 121);
            this.lbl_inType.Name = "lbl_inType";
            this.lbl_inType.Size = new System.Drawing.Size(100, 21);
            this.lbl_inType.TabIndex = 557;
            this.lbl_inType.Text = "Incoming Type";
            this.lbl_inType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_pur_factory
            // 
            this.cmb_pur_factory.AddItemSeparator = ';';
            this.cmb_pur_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_pur_factory.Caption = "";
            this.cmb_pur_factory.CaptionHeight = 17;
            this.cmb_pur_factory.CaptionStyle = style25;
            this.cmb_pur_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_pur_factory.ColumnCaptionHeight = 18;
            this.cmb_pur_factory.ColumnFooterHeight = 18;
            this.cmb_pur_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_pur_factory.ContentHeight = 16;
            this.cmb_pur_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_pur_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_pur_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_pur_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_pur_factory.EditorHeight = 16;
            this.cmb_pur_factory.EvenRowStyle = style26;
            this.cmb_pur_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pur_factory.FooterStyle = style27;
            this.cmb_pur_factory.HeadingStyle = style28;
            this.cmb_pur_factory.HighLightRowStyle = style29;
            this.cmb_pur_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_pur_factory.Images"))));
            this.cmb_pur_factory.ItemHeight = 15;
            this.cmb_pur_factory.Location = new System.Drawing.Point(109, 121);
            this.cmb_pur_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_pur_factory.MaxDropDownItems = ((short)(5));
            this.cmb_pur_factory.MaxLength = 32767;
            this.cmb_pur_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_pur_factory.Name = "cmb_pur_factory";
            this.cmb_pur_factory.OddRowStyle = style30;
            this.cmb_pur_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_pur_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_pur_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_pur_factory.SelectedStyle = style31;
            this.cmb_pur_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_pur_factory.Style = style32;
            this.cmb_pur_factory.TabIndex = 555;
            this.cmb_pur_factory.PropBag = resources.GetString("cmb_pur_factory.PropBag");
            // 
            // lbl_SH_CDC
            // 
            this.lbl_SH_CDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SH_CDC.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SH_CDC.ImageIndex = 0;
            this.lbl_SH_CDC.ImageList = this.img_Label;
            this.lbl_SH_CDC.Location = new System.Drawing.Point(8, 121);
            this.lbl_SH_CDC.Name = "lbl_SH_CDC";
            this.lbl_SH_CDC.Size = new System.Drawing.Size(100, 21);
            this.lbl_SH_CDC.TabIndex = 556;
            this.lbl_SH_CDC.Text = "Pur Factory";
            this.lbl_SH_CDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_not_ss
            // 
            this.chk_not_ss.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_not_ss.Location = new System.Drawing.Point(636, 76);
            this.chk_not_ss.Name = "chk_not_ss";
            this.chk_not_ss.Size = new System.Drawing.Size(24, 24);
            this.chk_not_ss.TabIndex = 554;
            this.chk_not_ss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_not_ss.CheckedChanged += new System.EventHandler(this.chk_not_ss_CheckedChanged);
            // 
            // txt_total_krw_proce
            // 
            this.txt_total_krw_proce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total_krw_proce.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_total_krw_proce.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_total_krw_proce.Location = new System.Drawing.Point(877, 121);
            this.txt_total_krw_proce.MaxLength = 10;
            this.txt_total_krw_proce.Name = "txt_total_krw_proce";
            this.txt_total_krw_proce.Size = new System.Drawing.Size(109, 21);
            this.txt_total_krw_proce.TabIndex = 553;
            // 
            // txt_total_usd_price
            // 
            this.txt_total_usd_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total_usd_price.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_total_usd_price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_total_usd_price.Location = new System.Drawing.Point(766, 121);
            this.txt_total_usd_price.MaxLength = 10;
            this.txt_total_usd_price.Name = "txt_total_usd_price";
            this.txt_total_usd_price.Size = new System.Drawing.Size(110, 21);
            this.txt_total_usd_price.TabIndex = 552;
            // 
            // lbl_amount
            // 
            this.lbl_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_amount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.ImageIndex = 0;
            this.lbl_amount.ImageList = this.img_Label;
            this.lbl_amount.Location = new System.Drawing.Point(665, 121);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(100, 21);
            this.lbl_amount.TabIndex = 551;
            this.lbl_amount.Text = "Amount";
            this.lbl_amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_in_total_qty
            // 
            this.txt_in_total_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_in_total_qty.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_in_total_qty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_in_total_qty.Location = new System.Drawing.Point(766, 99);
            this.txt_in_total_qty.MaxLength = 10;
            this.txt_in_total_qty.Name = "txt_in_total_qty";
            this.txt_in_total_qty.Size = new System.Drawing.Size(220, 21);
            this.txt_in_total_qty.TabIndex = 550;
            // 
            // lbl_total_qty
            // 
            this.lbl_total_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_total_qty.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_qty.ImageIndex = 0;
            this.lbl_total_qty.ImageList = this.img_Label;
            this.lbl_total_qty.Location = new System.Drawing.Point(665, 99);
            this.lbl_total_qty.Name = "lbl_total_qty";
            this.lbl_total_qty.Size = new System.Drawing.Size(100, 21);
            this.lbl_total_qty.TabIndex = 549;
            this.lbl_total_qty.Text = "In Total Qty";
            this.lbl_total_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_check
            // 
            this.btn_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_check.ImageIndex = 0;
            this.btn_check.ImageList = this.img_Button;
            this.btn_check.Location = new System.Drawing.Point(912, 144);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(80, 23);
            this.btn_check.TabIndex = 548;
            this.btn_check.Text = "Check";
            this.btn_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            this.btn_check.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_check_MouseDown);
            this.btn_check.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_check_MouseUp);
            // 
            // cmb_inUser
            // 
            this.cmb_inUser.AddItemSeparator = ';';
            this.cmb_inUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inUser.Caption = "";
            this.cmb_inUser.CaptionHeight = 17;
            this.cmb_inUser.CaptionStyle = style33;
            this.cmb_inUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inUser.ColumnCaptionHeight = 18;
            this.cmb_inUser.ColumnFooterHeight = 18;
            this.cmb_inUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inUser.ContentHeight = 16;
            this.cmb_inUser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inUser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inUser.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_inUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inUser.EditorHeight = 16;
            this.cmb_inUser.EvenRowStyle = style34;
            this.cmb_inUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_inUser.FooterStyle = style35;
            this.cmb_inUser.HeadingStyle = style36;
            this.cmb_inUser.HighLightRowStyle = style37;
            this.cmb_inUser.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_inUser.Images"))));
            this.cmb_inUser.ItemHeight = 15;
            this.cmb_inUser.Location = new System.Drawing.Point(109, 176);
            this.cmb_inUser.MatchEntryTimeout = ((long)(2000));
            this.cmb_inUser.MaxDropDownItems = ((short)(5));
            this.cmb_inUser.MaxLength = 32767;
            this.cmb_inUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inUser.Name = "cmb_inUser";
            this.cmb_inUser.OddRowStyle = style38;
            this.cmb_inUser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inUser.SelectedStyle = style39;
            this.cmb_inUser.Size = new System.Drawing.Size(220, 20);
            this.cmb_inUser.Style = style40;
            this.cmb_inUser.TabIndex = 414;
            this.cmb_inUser.Visible = false;
            this.cmb_inUser.PropBag = resources.GetString("cmb_inUser.PropBag");
            // 
            // lbl_inUser
            // 
            this.lbl_inUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inUser.ImageIndex = 0;
            this.lbl_inUser.ImageList = this.img_Label;
            this.lbl_inUser.Location = new System.Drawing.Point(9, 176);
            this.lbl_inUser.Name = "lbl_inUser";
            this.lbl_inUser.Size = new System.Drawing.Size(100, 21);
            this.lbl_inUser.TabIndex = 415;
            this.lbl_inUser.Text = "Incoming User";
            this.lbl_inUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_inUser.Visible = false;
            // 
            // chk_confirmYn
            // 
            this.chk_confirmYn.Location = new System.Drawing.Point(672, 144);
            this.chk_confirmYn.Name = "chk_confirmYn";
            this.chk_confirmYn.Size = new System.Drawing.Size(160, 16);
            this.chk_confirmYn.TabIndex = 413;
            this.chk_confirmYn.Text = "Include Confirm Data ";
            this.chk_confirmYn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_confirmYn.Visible = false;
            this.chk_confirmYn.CheckedChanged += new System.EventHandler(this.chk_confirmYn_CheckedChanged);
            // 
            // lbl_headInfo
            // 
            this.lbl_headInfo.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_headInfo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_headInfo.ForeColor = System.Drawing.Color.Navy;
            this.lbl_headInfo.Image = ((System.Drawing.Image)(resources.GetObject("lbl_headInfo.Image")));
            this.lbl_headInfo.Location = new System.Drawing.Point(0, 0);
            this.lbl_headInfo.Name = "lbl_headInfo";
            this.lbl_headInfo.Size = new System.Drawing.Size(231, 30);
            this.lbl_headInfo.TabIndex = 412;
            this.lbl_headInfo.Text = "       Incoming Adjust  Info";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_user
            // 
            this.cmb_user.AddItemSeparator = ';';
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
            this.cmb_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FooterStyle = style43;
            this.cmb_user.HeadingStyle = style44;
            this.cmb_user.HighLightRowStyle = style45;
            this.cmb_user.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_user.Images"))));
            this.cmb_user.ItemHeight = 15;
            this.cmb_user.Location = new System.Drawing.Point(109, 77);
            this.cmb_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_user.MaxDropDownItems = ((short)(5));
            this.cmb_user.MaxLength = 32767;
            this.cmb_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.OddRowStyle = style46;
            this.cmb_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_user.SelectedStyle = style47;
            this.cmb_user.Size = new System.Drawing.Size(220, 20);
            this.cmb_user.Style = style48;
            this.cmb_user.TabIndex = 390;
            this.cmb_user.PropBag = resources.GetString("cmb_user.PropBag");
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ImageIndex = 0;
            this.lbl_user.ImageList = this.img_Label;
            this.lbl_user.Location = new System.Drawing.Point(8, 77);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_user.TabIndex = 391;
            this.lbl_user.Text = "Purchase User";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(8, 99);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 389;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(109, 99);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 387;
            this.txt_vendorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vendorCode_KeyPress);
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style49;
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
            this.cmb_vendor.EvenRowStyle = style50;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style51;
            this.cmb_vendor.HeadingStyle = style52;
            this.cmb_vendor.HighLightRowStyle = style53;
            this.cmb_vendor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_vendor.Images"))));
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(189, 99);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style54;
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style55;
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style56;
            this.cmb_vendor.TabIndex = 388;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(212, 56);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(8, 16);
            this.lblexcep_mark.TabIndex = 386;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(230, 55);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(99, 21);
            this.dpick_to.TabIndex = 385;
            this.dpick_to.CloseUp += new System.EventHandler(this.dpick_to_CloseUp);
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 55);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(99, 21);
            this.dpick_from.TabIndex = 381;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // cmb_purDiv
            // 
            this.cmb_purDiv.AddItemSeparator = ';';
            this.cmb_purDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purDiv.Caption = "";
            this.cmb_purDiv.CaptionHeight = 17;
            this.cmb_purDiv.CaptionStyle = style57;
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
            this.cmb_purDiv.EvenRowStyle = style58;
            this.cmb_purDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purDiv.FooterStyle = style59;
            this.cmb_purDiv.HeadingStyle = style60;
            this.cmb_purDiv.HighLightRowStyle = style61;
            this.cmb_purDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_purDiv.Images"))));
            this.cmb_purDiv.ItemHeight = 15;
            this.cmb_purDiv.Location = new System.Drawing.Point(437, 77);
            this.cmb_purDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_purDiv.MaxDropDownItems = ((short)(5));
            this.cmb_purDiv.MaxLength = 32767;
            this.cmb_purDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purDiv.Name = "cmb_purDiv";
            this.cmb_purDiv.OddRowStyle = style62;
            this.cmb_purDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.SelectedStyle = style63;
            this.cmb_purDiv.Size = new System.Drawing.Size(200, 20);
            this.cmb_purDiv.Style = style64;
            this.cmb_purDiv.TabIndex = 362;
            this.cmb_purDiv.PropBag = resources.GetString("cmb_purDiv.PropBag");
            // 
            // cmb_buyDiv
            // 
            this.cmb_buyDiv.AddItemSeparator = ';';
            this.cmb_buyDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_buyDiv.Caption = "";
            this.cmb_buyDiv.CaptionHeight = 17;
            this.cmb_buyDiv.CaptionStyle = style65;
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
            this.cmb_buyDiv.EvenRowStyle = style66;
            this.cmb_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_buyDiv.FooterStyle = style67;
            this.cmb_buyDiv.HeadingStyle = style68;
            this.cmb_buyDiv.HighLightRowStyle = style69;
            this.cmb_buyDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_buyDiv.Images"))));
            this.cmb_buyDiv.ItemHeight = 15;
            this.cmb_buyDiv.Location = new System.Drawing.Point(437, 99);
            this.cmb_buyDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_buyDiv.MaxDropDownItems = ((short)(5));
            this.cmb_buyDiv.MaxLength = 32767;
            this.cmb_buyDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_buyDiv.Name = "cmb_buyDiv";
            this.cmb_buyDiv.OddRowStyle = style70;
            this.cmb_buyDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_buyDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.SelectedStyle = style71;
            this.cmb_buyDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_buyDiv.Style = style72;
            this.cmb_buyDiv.TabIndex = 361;
            this.cmb_buyDiv.PropBag = resources.GetString("cmb_buyDiv.PropBag");
            // 
            // lbl_buyDiv
            // 
            this.lbl_buyDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buyDiv.ImageIndex = 0;
            this.lbl_buyDiv.ImageList = this.img_Label;
            this.lbl_buyDiv.Location = new System.Drawing.Point(336, 99);
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
            this.lbl_purDiv.Location = new System.Drawing.Point(336, 77);
            this.lbl_purDiv.Name = "lbl_purDiv";
            this.lbl_purDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_purDiv.TabIndex = 359;
            this.lbl_purDiv.Text = "Pur  Division";
            this.lbl_purDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_priceYn
            // 
            this.cmb_priceYn.AddItemSeparator = ';';
            this.cmb_priceYn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_priceYn.Caption = "";
            this.cmb_priceYn.CaptionHeight = 17;
            this.cmb_priceYn.CaptionStyle = style73;
            this.cmb_priceYn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_priceYn.ColumnCaptionHeight = 18;
            this.cmb_priceYn.ColumnFooterHeight = 18;
            this.cmb_priceYn.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_priceYn.ContentHeight = 16;
            this.cmb_priceYn.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_priceYn.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_priceYn.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_priceYn.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_priceYn.EditorHeight = 16;
            this.cmb_priceYn.EvenRowStyle = style74;
            this.cmb_priceYn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_priceYn.FooterStyle = style75;
            this.cmb_priceYn.HeadingStyle = style76;
            this.cmb_priceYn.HighLightRowStyle = style77;
            this.cmb_priceYn.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_priceYn.Images"))));
            this.cmb_priceYn.ItemHeight = 15;
            this.cmb_priceYn.Location = new System.Drawing.Point(437, 55);
            this.cmb_priceYn.MatchEntryTimeout = ((long)(2000));
            this.cmb_priceYn.MaxDropDownItems = ((short)(5));
            this.cmb_priceYn.MaxLength = 32767;
            this.cmb_priceYn.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_priceYn.Name = "cmb_priceYn";
            this.cmb_priceYn.OddRowStyle = style78;
            this.cmb_priceYn.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_priceYn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_priceYn.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_priceYn.SelectedStyle = style79;
            this.cmb_priceYn.Size = new System.Drawing.Size(220, 20);
            this.cmb_priceYn.Style = style80;
            this.cmb_priceYn.TabIndex = 358;
            this.cmb_priceYn.PropBag = resources.GetString("cmb_priceYn.PropBag");
            // 
            // lbl_priceYN
            // 
            this.lbl_priceYN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_priceYN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priceYN.ImageIndex = 0;
            this.lbl_priceYN.ImageList = this.img_Label;
            this.lbl_priceYN.Location = new System.Drawing.Point(336, 55);
            this.lbl_priceYN.Name = "lbl_priceYN";
            this.lbl_priceYN.Size = new System.Drawing.Size(100, 21);
            this.lbl_priceYN.TabIndex = 357;
            this.lbl_priceYN.Text = "Price Y/N";
            this.lbl_priceYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_inNo
            // 
            this.cmb_inNo.AddItemSeparator = ';';
            this.cmb_inNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inNo.Caption = "";
            this.cmb_inNo.CaptionHeight = 17;
            this.cmb_inNo.CaptionStyle = style81;
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
            this.cmb_inNo.EvenRowStyle = style82;
            this.cmb_inNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_inNo.FooterStyle = style83;
            this.cmb_inNo.HeadingStyle = style84;
            this.cmb_inNo.HighLightRowStyle = style85;
            this.cmb_inNo.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_inNo.Images"))));
            this.cmb_inNo.ItemHeight = 15;
            this.cmb_inNo.Location = new System.Drawing.Point(437, 33);
            this.cmb_inNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_inNo.MaxDropDownItems = ((short)(5));
            this.cmb_inNo.MaxLength = 32767;
            this.cmb_inNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inNo.Name = "cmb_inNo";
            this.cmb_inNo.OddRowStyle = style86;
            this.cmb_inNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inNo.SelectedStyle = style87;
            this.cmb_inNo.Size = new System.Drawing.Size(200, 20);
            this.cmb_inNo.Style = style88;
            this.cmb_inNo.TabIndex = 5;
            this.cmb_inNo.SelectedValueChanged += new System.EventHandler(this.cmb_inNo_SelectedValueChanged);
            this.cmb_inNo.PropBag = resources.GetString("cmb_inNo.PropBag");
            // 
            // lbl_inNo
            // 
            this.lbl_inNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inNo.ImageIndex = 0;
            this.lbl_inNo.ImageList = this.img_Label;
            this.lbl_inNo.Location = new System.Drawing.Point(336, 33);
            this.lbl_inNo.Name = "lbl_inNo";
            this.lbl_inNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_inNo.TabIndex = 50;
            this.lbl_inNo.Text = "Incoming No";
            this.lbl_inNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 154);
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
            this.btn_search.Location = new System.Drawing.Point(636, 33);
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
            this.pic_head4.Location = new System.Drawing.Point(136, 153);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style89;
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
            this.cmb_factory.EvenRowStyle = style90;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style91;
            this.cmb_factory.HeadingStyle = style92;
            this.cmb_factory.HighLightRowStyle = style93;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 33);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style94;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style95;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style96;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
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
            this.pic_head7.Size = new System.Drawing.Size(101, 129);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 154);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 143);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(112, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(960, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // cmenu_Adjust
            // 
            this.cmenu_Adjust.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuitem_ValueExchange,
            this.menuitem_RateExchange,
            this.menuitem_Header,
            this.menuitem_Detail});
            this.cmenu_Adjust.Popup += new System.EventHandler(this.cmenu_Adjust_Popup);
            // 
            // menuitem_ValueExchange
            // 
            this.menuitem_ValueExchange.Index = 0;
            this.menuitem_ValueExchange.Text = "Value Exchange";
            this.menuitem_ValueExchange.Click += new System.EventHandler(this.menuitem_ValueExchange_Click);
            // 
            // menuitem_RateExchange
            // 
            this.menuitem_RateExchange.Index = 1;
            this.menuitem_RateExchange.Text = "Rate Exchange";
            this.menuitem_RateExchange.Click += new System.EventHandler(this.menuitem_RateExchange_Click);
            // 
            // menuitem_Header
            // 
            this.menuitem_Header.Index = 2;
            this.menuitem_Header.Text = "View Header";
            this.menuitem_Header.Click += new System.EventHandler(this.menuitem_Header_Click);
            // 
            // menuitem_Detail
            // 
            this.menuitem_Detail.Index = 3;
            this.menuitem_Detail.Text = "View Detail";
            this.menuitem_Detail.Click += new System.EventHandler(this.menuitem_Detail_Click);
            // 
            // Form_BI_Incoming_Adjust
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BI_Incoming_Adjust";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BI_Incoming_Adjust_Closing);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_priceYn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
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
			if (e.Button == MouseButtons.Right && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
			{
				_vActiveCol = fgrid_main.Cols[fgrid_main.Col].Index; 
				_vActiveRow = fgrid_main.Rows[fgrid_main.Row].Index; 
				Set_MenuItem_Visible();
				
				this.cmenu_Adjust.Show(fgrid_main, new Point(e.X, e.Y));

			}
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
			this.Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SaveProcess(true);
		}						

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(_vConfirmYn) 
				this.Tbtn_ConfirmCancelProcess();
			else
				this.Tbtn_ConfirmProcess();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}

		#endregion
	
		#region 컨트롤 이벤트 처리


		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}
	
		private void Form_BI_Incoming_Adjust_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}
		}

		private void chk_not_ss_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chk_not_ss.Checked) cmb_purDiv.Enabled = false;
			else cmb_purDiv.Enabled = true;
		}

	

		private void btn_check_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_check.ImageIndex = 1;
		}

		private void btn_check_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_check.ImageIndex = 0;
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			this.Btn_SearchClickProcess();
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_inNoSettingProcess();

			if (!_initYn)
				this.ClosingCheckProcess(true); 			
		}


		private void txt_styleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				cmb_style.SelectedIndex = -1;

				DataTable dt_ret;
				
				dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCd, " ") ); 
				 
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_style, 0, 1, 2, 3, 4, true, 80, 200); 

				//ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_style, 0, 1,  true, 79, 141);
				if (dt_ret.Rows.Count > 0 && dt_ret.Rows.Count < 2)
					cmb_style.SelectedIndex = 0;
				else if (dt_ret == null || dt_ret.Rows.Count <= 0) 
					cmb_vendor.SelectedIndex = -1; 

				dt_ret.Dispose();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_styleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			dpick_to.Value = dpick_from.Value; 
			this.Cmb_inNoSettingProcess();				

			if (!_initYn)
				this.ClosingCheckProcess(true); 			
		}

		private void dpick_to_CloseUp(object sender, System.EventArgs e)
		{
			this.Cmb_inNoSettingProcess();				
		}

		private void cmb_inNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_inNoSelectedValueChangedProcess();
		}

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

		private void chk_confirmYn_CheckedChanged(object sender, System.EventArgs e)
		{
			this.Chk_ConfirmYnProcess();
		}

		private void Chk_ConfirmYnProcess()
		{
			Tbtn_SearchProcess();
		}

		private void ClosingCheckProcess(bool arg_check)
		{
			try
			{
				// 재고마감 여부 체크
				if (arg_check)
				{
					string[] vProviso = GetSearchProviso();
					DataTable vDt = FlexPurchase.ClassLib.ComFunction.Select_Close_Yn(  vProviso[0], 
																						FlexPurchase.ClassLib.ComVar.Month, 
																						vProviso[1].Substring(0,6), 
																						FlexPurchase.ClassLib.ComVar.Stock);
				
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
					if (_vClosingYn == "Y")  // 재고마감시 모든 작업 불가하다. 
					{
						fgrid_main.AllowEditing = false;
						tbtn_Save.Enabled		= false;
						tbtn_Delete.Enabled		= false;
						tbtn_Confirm.Enabled	= false;
					}
					else
					{
						if (fgrid_main.Rows.Count > 0 && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
						{		
							_vSaveCount		= 0; 
							_vCommitCount	= 0;

							// Status 확인
							for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
							{
								if (fgrid_main.Rows[vRow][_itemCdCol] != null && fgrid_main.Rows[vRow][_itemCdCol].ToString() != "")
								{
									if (fgrid_main[vRow, _inStatusCol].ToString() == "C")
									{
										_vCommitCount = _vCommitCount + 1; 
										fgrid_main.Rows[vRow].AllowEditing = false;
									}
									else 
									{
										_vSaveCount   = _vSaveCount + 1;
										fgrid_main.Rows[vRow].AllowEditing = true;
									}
								}
							}

							if (_vSaveCount > 0 && _vCommitCount > 0)  // Confirm 자재와 Confrim 안된 자재가 함께 조회되었을때 
							{
								tbtn_Confirm.Enabled		= false;
								tbtn_Save.Enabled			= true;
								tbtn_Delete.Enabled			= true;
							}
							else 
							{
								tbtn_Confirm.Enabled		= true;
								if ( _vCommitCount > 0 )
								{
									_vConfirmYn				= true;
									fgrid_main.AllowEditing = false;
									tbtn_Save.Enabled		= false;
									tbtn_Delete.Enabled		= false;
								}
								else 
								{
									_vConfirmYn				= false;
									fgrid_main.AllowEditing = true;
									tbtn_Save.Enabled		= true;
									tbtn_Delete.Enabled		= true;
								}
							}
						}			
						else
						{
							fgrid_main.ClearAll();
							tbtn_Confirm.Enabled    = false;
							tbtn_Save.Enabled		= true;
							tbtn_Delete.Enabled		= true;
						}

					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		#region 입력이동

		#endregion

		#region 버튼효과

		#endregion

		#region 롤오버 이미지 처리
		#endregion


		#endregion

		#region 버튼 이벤트 처리
		private void btn_check_Click(object sender, System.EventArgs e)
		{
			if(txt_vendorCode.Text.Trim().Length > 0)
			{
				if(ClassLib.ComFunction.Check_Digit(txt_vendorCode.Text))
				{
					COM.ComFunction cfunction = new COM.ComFunction();
					int arg_factory_indx = cmb_factory.SelectedIndex;
					string arg_from_date = cfunction.ConvertDate2DbType(dpick_from.Text);
					string arg_to_date   = cfunction.ConvertDate2DbType(dpick_to.Text);
					string arg_cust_cd   = txt_vendorCode.Text;
					Pop_BI_Incomming_ChekcPrice checkPrice = new Pop_BI_Incomming_ChekcPrice(arg_factory_indx, arg_from_date, arg_to_date, arg_cust_cd);
					checkPrice.ShowDialog();
				}
				else
				{
					MessageBox.Show("Check Vendor Code!!");
					txt_vendorCode.Focus();
					return;
				}
				
			}
		}

	

		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
			string vTyep = this.cmb_itemGroup.SelectedValue.ToString();
			FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);

			vPopup.ShowDialog();
			
			string _group_cd	= COM.ComVar.Parameter_PopUp[3];				
			string _group_name	= COM.ComVar.Parameter_PopUp[4];
            _sel_group_cd = _group_cd;
			//txt_itemCd.Text		= _group_cd;
			//txt_itemNm.Text		= _group_name;
			
			vPopup.Dispose();		
		}

		private void Btn_SearchClickProcess()
		{
			Pop_BI_Incoming_InNo vPopup = new Pop_BI_Incoming_InNo();
			COM.ComVar.Parameter_PopUp		= new string[1];
			COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");

			if (vPopup.ShowDialog() == DialogResult.OK)
			{
				_practicable = false;
				cmb_factory.SelectedValue		= COM.ComVar.Parameter_PopUp[0];
				dpick_from.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
				dpick_to.Value					= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
				_practicable = true;
				Cmb_inNoSettingProcess();
				cmb_inNo.SelectedValue			= COM.ComVar.Parameter_PopUp[2];
			}

			vPopup.Dispose();
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
			string[] vProviso = new string[3];
			vProviso[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			vProviso[1] = dpick_from.Text.Replace("-", "");
			vProviso[2] = dpick_to.Text.Replace("-", "");

			return vProviso;
		}


		#endregion

		#region 컨텍스트(팝업) 메뉴 이벤트

		//Confirm 처리
		private void menuItem2_Click(object sender, System.EventArgs e)
		{

			try
			{

				for(int i=_rowFixed; i<fgrid_main.Rows.Count; i++)
				{
					if(fgrid_main.Rows[i].Selected && fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_STATUS] != null)
					{
						string arg_factory = fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxFACTORY].ToString();
						string arg_in_no    = fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_NO].ToString();
						string arg_in_seq   = fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_SEQ].ToString();
						string arg_value   = "C";

						// confirm 처리, stock trigger 발생
						bool save_flag = SAVE_SBI_IN_STATUS(arg_factory, arg_in_no, arg_in_seq, arg_value);

						fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_STATUS] = arg_value;

						
						//						bool save_acc_flag = false;
						//						
						//						if(save_flag)
						//						{
						//							// 회계 연결 전표 위한 데이터 제공
						//							if(ClassLib.ComVar.This_Factory == "QD")
						//							{
						//								this.Cursor = Cursors.WaitCursor;
						//
						//								save_acc_flag = SAVE_SBI_ACCOUNT_INF_ADJUST(); 
						//							} 
						//							else
						//							{
						//								save_acc_flag = true;
						//							}// end if(ClassLib.ComVar.This_Factory == "QD")
						//
						//						} 
						//						else
						//						{
						//							save_acc_flag = false;
						//						}

						//						if(save_acc_flag)
						//						{
						//							fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_STATUS] = arg_value;
						//						} // end if(save_acc_flag)


					}
				}

			}
			catch
			{
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}



		}

		//Disconfirm 처리
		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			for(int i=_rowFixed; i<fgrid_main.Rows.Count; i++)
			{
				if(fgrid_main.Rows[i].Selected && fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_STATUS] != null)
				{
					string arg_factory = fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxFACTORY].ToString();
					string arg_in_no    = fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_NO].ToString();
					string arg_in_seq   = fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_SEQ].ToString();
					string arg_value   = "S";

					// 회계 연결 전표 작성 여부 체크
					if(ClassLib.ComVar.This_Factory == "QD")
					{
						bool create_slip_flag = Check_CREATE_SLIP(); 
						if(create_slip_flag) return;  
					}

					SAVE_SBI_IN_STATUS(arg_factory, arg_in_no, arg_in_seq, arg_value);
					fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_STATUS] = arg_value;
				}
			}
		}


	
		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				int vCol = _vActiveCol; 
				ClassLib.ComVar.Parameter_PopUp_Object  = null;
				ClassLib.ComVar.Parameter_PopUp_Object2 = null;
				ClassLib.ComVar.Parameter_PopUpTable	= null; 

				int[] vSelectionRange = fgrid_main.Selections;

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp		= new string[1];
					COM.ComVar.Parameter_PopUp[0]	= fgrid_main[1, vCol].ToString();

				
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
							if ( fgrid_main.Rows[i].AllowEditing )
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
						}
					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_ValueExchange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{

			try
			{

				for(int i=_rowFixed; i<fgrid_main.Rows.Count; i++)
				{
					if(fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_STATUS] != null)
					{
						string arg_factory = fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxFACTORY].ToString();
						string arg_in_no    = fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_NO].ToString();
						string arg_in_seq   = fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_SEQ].ToString();
						string arg_value   = "C";

						// confirm 처리, stock trigger 발생
						bool save_flag = SAVE_SBI_IN_STATUS(arg_factory, arg_in_no, arg_in_seq, arg_value);

						fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_STATUS] = arg_value;

						//						bool save_acc_flag = false;
						//						
						//						if(save_flag)
						//						{
						//							// 회계 연결 전표 위한 데이터 제공
						//							if(ClassLib.ComVar.This_Factory == "QD")
						//							{
						//								this.Cursor = Cursors.WaitCursor;
						//
						//								save_acc_flag = SAVE_SBI_ACCOUNT_INF_ADJUST(); 
						//							} 
						//							else
						//							{
						//								save_acc_flag = true;
						//							}// end if(ClassLib.ComVar.This_Factory == "QD")
						//
						//						} 
						//						else
						//						{
						//							save_acc_flag = false;
						//						}
						//
						//						if(save_acc_flag)
						//						{
						//							fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_STATUS] = arg_value;
						//						} // end if(save_acc_flag)


					
					
					}
				}

			}
			catch
			{
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}



		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			for(int i=_rowFixed; i<fgrid_main.Rows.Count; i++)
			{
				if(fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_STATUS] != null)
				{
					string arg_factory = fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxFACTORY].ToString();
					string arg_in_no    = fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_NO].ToString();
					string arg_in_seq   = fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_SEQ].ToString();
					string arg_value   = "S";


					// 회계 연결 전표 작성 여부 체크
					if(ClassLib.ComVar.This_Factory == "QD")
					{
						bool create_slip_flag = Check_CREATE_SLIP(); 
						if(create_slip_flag) return;  
					}

					SAVE_SBI_IN_STATUS(arg_factory, arg_in_no, arg_in_seq, arg_value);
					fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxIN_STATUS] = arg_value;
				}
			}
		}



		private void cmenu_Adjust_Popup(object sender, System.EventArgs e)
		{
			try
			{
//				int vCol = _mainSheet.ActiveColumnIndex;
				// 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Adjust_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

  		
		/// <summary>
		/// Set_MenuItem_Visible : 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
		/// </summary>
		private void Set_MenuItem_Visible()
		{
			if (!fgrid_main.AllowEditing || !fgrid_main.Rows[_vActiveRow].AllowEditing || !fgrid_main.Cols[_vActiveCol].AllowEditing) 
			{
				this.menuitem_ValueExchange.Visible		= false;
				this.menuitem_RateExchange.Visible		= false;
			}
			else
			{
				this.menuitem_ValueExchange.Visible		= true;
				this.menuitem_RateExchange.Visible		= true;
			}
			this.menuitem_Header.Visible		= false;
			this.menuitem_Detail.Visible		= false;
		}
 
		private void menuitem_Header_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				fgrid_main.Tree.Show(1);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_Header_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void menuitem_Detail_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				fgrid_main.Tree.Show(2);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_Detail_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void menuitem_ValueExchange_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				int vCol = _vActiveCol; 
				ClassLib.ComVar.Parameter_PopUp_Object  = null;
				ClassLib.ComVar.Parameter_PopUp_Object2 = null;
				ClassLib.ComVar.Parameter_PopUpTable	= null; 

				int[] vSelectionRange = fgrid_main.Selections;

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp		= new string[1];
					COM.ComVar.Parameter_PopUp[0]	= fgrid_main[1, vCol].ToString();

				
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
							if ( fgrid_main.Rows[i].AllowEditing )
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
						}
					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_ValueExchange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void menuitem_RateExchange_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				int vRow = fgrid_main.Rows[fgrid_main.Row].Index;  
				int vCol = fgrid_main.Cols[fgrid_main.Col].Index;
				string vCol_value = "";

				if ( fgrid_main.Rows[vRow].AllowEditing )
					vCol_value = fgrid_main[vRow, vCol].ToString();
				else 
					vCol_value = fgrid_main[vRow-1, vCol].ToString();

				int[] vSelectionRange = fgrid_main.Selections;

//				for (int c = vSelectionRange.Row ; c < vSelectionRange.Row + vSelectionRange.RowCount ; c++)
//				{
//					if (fgrid_main[c, vCol].Text == "" ) 
//					{
//						ClassLib.ComFunction.User_Message("Source Currency Not Found", "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
//						return;
//					}
//					if (fgrid_main[c, vCol].Text != vCol_value)
//					{
//						ClassLib.ComFunction.User_Message("Not Same Currency", "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
//						return;
//					}
//
//					vCol_value = fgrid_main[c, vCol].Text;
//				}
				
				Pop_BI_Incoming_Rate_Exchanger pop_changer = new Pop_BI_Incoming_Rate_Exchanger();

				COM.ComVar.Parameter_PopUp		= new string[1];
				COM.ComVar.Parameter_PopUp[0]	= vCol_value;

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
										vContPrice	=	decimal.Round(vRate * vPrice, 2);
										fgrid_main[i, _purPriceCol]		= vContPrice;
										fgrid_main[i, _purCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									if (fgrid_main[i, _outsideCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _outsidePriceCol].ToString() == "" ? "0" : fgrid_main[i, _purPriceCol].ToString());
										vContPrice	=	decimal.Round(vRate * vPrice, 2);
										fgrid_main[i, _outsidePriceCol]		= vContPrice;
										fgrid_main[i, _outsideCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									if (fgrid_main[i, _cbdCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _cbdPriceCol].ToString() == "" ? "0" : fgrid_main[i, _purPriceCol].ToString());
										vContPrice	=	decimal.Round(vRate * vPrice, 2);
										fgrid_main[i, _cbdPriceCol]		= vContPrice;
										fgrid_main[i, _cbdCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									if (fgrid_main[i, _shipCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _shipPriceCol].ToString() == "" ? "0" :fgrid_main[i, _purPriceCol].ToString());
										vContPrice	=	decimal.Round(vRate * vPrice, 2);
										fgrid_main[i, _shipPriceCol]	= vContPrice;
										fgrid_main[i, _shipCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									break;

								case "10" :
									if (fgrid_main[i, _purCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _purPriceCol].ToString() == "" ? "0" : fgrid_main[i, _purPriceCol].ToString());
										vContPrice	=	decimal.Round(vRate * vPrice, 2);
										fgrid_main[i, _purPriceCol]		= vContPrice;
										fgrid_main[i, _purCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									break;

								case "20" :
									if (fgrid_main[i, _outsideCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _outsidePriceCol].ToString() == "" ? "0" : fgrid_main[i, _purPriceCol].ToString());
										vContPrice	=	decimal.Round(vRate * vPrice, 2);
										fgrid_main[i, _outsidePriceCol]		= vContPrice;
										fgrid_main[i, _outsideCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									break;

								case "30" :
									if (fgrid_main[i, _cbdCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _cbdPriceCol].ToString() == "" ? "0" : fgrid_main[i, _purPriceCol].ToString());
										vContPrice	=	decimal.Round(vRate * vPrice, 2);
										fgrid_main[i, _cbdPriceCol]		= vContPrice;
										fgrid_main[i, _cbdCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
									}
									break;

								case "40" :
									if (fgrid_main[i, _shipCurrencyCol].ToString() == COM.ComVar.Parameter_PopUp[1])
									{
										vRate		=	decimal.Parse(COM.ComVar.Parameter_PopUp[3]);
										vPrice		=	decimal.Parse(fgrid_main[i, _shipPriceCol].ToString() == "" ? "0" :fgrid_main[i, _purPriceCol].ToString());
										vContPrice	=	decimal.Round(vRate * vPrice, 2);
										fgrid_main[i, _shipPriceCol]	= vContPrice;
										fgrid_main[i, _shipCurrencyCol]	= COM.ComVar.Parameter_PopUp[2];
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

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary> 
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
//			ClassLib.ComFunction.Init_Form_Control(this);
			_initYn	= true;

            lbl_MainTitle.Text = "Adjust Incoming";
            this.Text = lbl_MainTitle.Text;
            ClassLib.ComFunction.SetLangDic(this);

			_practicable = true;

			// Grid Setting
			fgrid_main.Set_Grid("SBI_INCOMING_ADJUST", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;
			_rowFixed = fgrid_main.Rows.Count;

			// Factory Combobox Setting
			DataTable vDt = null;
			//vDt = FlexPurchase.ClassLib.ComFunction.Select_Data_List(ClassLib.ComVar.This_Factory , "SBI06");
            vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBI06");
            COM.ComCtl.Set_ComboList(vDt, cmb_factory, 1, 1, false, false);
            cmb_factory.SelectedIndex = 0;
			vDt.Dispose();
			
			

			// pur_div set    cmb_purDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_purDiv, 1, 2, true, 56,0);
			cmb_purDiv.SelectedIndex = -1;

			// buy_div set    cmb_buyDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC01");
			COM.ComCtl.Set_ComboList(vDt, cmb_buyDiv, 1, 2, true, 56,0);
			cmb_buyDiv.SelectedIndex = -1;

			
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBI01");
			COM.ComCtl.Set_ComboList(vDt, cmb_inType, 1, 2, true, 56,0);
			cmb_inType.SelectedIndex = 0;


            // Item Group Combobox Setting
            vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
            COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
            cmb_itemGroup.SelectedIndex = 0;
            vDt.Dispose();


			// cmb_user
			vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory);
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_user,1,2,(vDt.Rows.Count > 1) ? true : false);
			cmb_user.SelectedIndex = 0;
			vDt.Dispose();

			// cmb_inUser
			vDt = ClassLib.ComFunction.SELECT_WAREHOUSE_USER(COM.ComVar.This_Factory);
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_inUser,1,2,(vDt.Rows.Count > 1) ? true : false);
			cmb_inUser.SelectedValue = COM.ComVar.This_User;
			vDt.Dispose();

			// price yn set    cmb_priceYn
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SEM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_priceYn, 1, 2, true, 56,0);
			cmb_priceYn.SelectedIndex = 1;

			
			// Pur  Factory Combobox Setting		
			//vDt = ClassLib.ComFunction.Select_Data_List(ClassLib.ComVar.This_Factory, "SBI04");
            vDt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, "SBI04");
			COM.ComCtl.Set_ComboList(vDt, cmb_pur_factory , 1, 1, true,false);
            cmb_pur_factory.SelectedIndex = 0;
            vDt.Dispose();
			



			btn_groupSearch.Enabled = true;


			// user define variable set
			_cmbInNoEventHandler		= new System.EventHandler(this.cmb_inNo_SelectedValueChanged);

			// Disabled tbutton
			tbtn_Delete.Enabled  = false;

			// set grid cell type
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

			// set up styles
//			CellStyle s = fgrid_main.Styles[CellStyleEnum.Subtotal0];
//			s.BackColor = ClassLib.ComVar.ClrLevel_1st;
//			s.ForeColor = Color.Black;

			_initYn	= false; 


			// set up styles
			CellStyle s = fgrid_main.Styles[CellStyleEnum.Subtotal0];
			s.BackColor = ClassLib.ComVar.ClrLevel_1st;
			s.ForeColor = Color.Black;
			s.Font = new Font(fgrid_main.Font, FontStyle.Bold);
			s.ForeColor = Color.Red;
			
			s = fgrid_main.Styles[CellStyleEnum.Subtotal1];
			s.BackColor = ClassLib.ComVar.ClrLevel_2nd;
			s.ForeColor = Color.Blue;

			s = fgrid_main.Styles[CellStyleEnum.Subtotal2];
			s.BackColor = ClassLib.ComVar.ClrLevel_3rd;
			s.Font = new Font(fgrid_main.Font, FontStyle.Bold);
			s.ForeColor = Color.Violet;

			s = fgrid_main.Styles[CellStyleEnum.Subtotal3];
			s.BackColor = ClassLib.ComVar.ClrLightSel;
			s.Font = new Font(fgrid_main.Font, FontStyle.Bold);
			s.ForeColor = Color.Green;

			s = fgrid_main.Styles[CellStyleEnum.Subtotal4];
			s.BackColor = ClassLib.ComVar.ClrOA;
			s.ForeColor = Color.Black;


			tbtn_Confirm.Enabled = false;








			// 자재 마감 여부 체크
			this.ClosingCheckProcess(true); 
		}
		
		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = arg_grid.Sheets[0].ActiveRowIndex ;
			int vCol = arg_grid.Sheets[0].ActiveColumnIndex ;
			
			if (arg_grid.Sheets[0].Cells[vRow, vCol] == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].ToString();
			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString() ;
			if (vTemp == "CheckBoxCellType" || vTemp == "SSPComboBoxCellType" )
			{
				arg_grid.Buffer_CellData = "000" ;
				arg_grid.Update_Row(img_Action) ;
			}
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_main.ClearAll();
				this.cmb_purDiv.SelectedIndex		= -1;				
				this.cmb_buyDiv.SelectedIndex		= -1;	
				this.cmb_user.SelectedIndex			= -1;
				this.cmb_priceYn.SelectedIndex		= -1;
//				this.cmb_vendor.SelectedIndex		= -1;
				this.txt_vendorCode.Text			= "";
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					this.Cursor = Cursors.WaitCursor;

					DataTable vTemp = this.SELECT_SBI_IN_ADJUST_LIST();
					ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_main, vTemp);

					this.EnableControlCheckProcess(true);	// Control Enable Check
					SubTotalProcess();


					//sale sample 표시
					for(int i=_rowFixed; i<fgrid_main.Rows.Count; i++)
					{
						if(fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxPUR_DIV] != null && fgrid_main[i, (int)ClassLib.TBSBI_INCOMING_ADJUST.IxPUR_DIV].ToString() == "50")
						{
							fgrid_main.Rows[i].StyleNew.BackColor = Color.FromArgb(247, 255, 187);
						}

					}


					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);

					DataTable dt = SELECT_SBI_IN_ADJUST_TOTAL();
					txt_in_total_qty.Text = dt.Rows[0].ItemArray[0].ToString();
					txt_total_usd_price.Text = dt.Rows[0].ItemArray[1].ToString();
					txt_total_krw_proce.Text = dt.Rows[0].ItemArray[2].ToString();
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
            C1.Win.C1List.C1Combo[] cmb_array = { cmb_factory };
            System.Windows.Forms.TextBox[] txt_array = { };

            if (FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array))
            {
                string vConfYn = "";

                string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Adjust");

                string sPara = " /rp ";
                sPara += "'" + COM.ComFunction.Param_Combo(cmb_factory, "%") + "' ";
                sPara += "'" + COM.ComFunction.Param_Combo(cmb_inNo, "%") + "' ";
                sPara += "'" + this.dpick_from.Text.Replace("-", "") + "' ";
                sPara += "'" + this.dpick_to.Text.Replace("-", "") + "' ";
                sPara += "'" + COM.ComFunction.Param_Combo(cmb_purDiv, "%") + "' ";
                sPara += "'" + COM.ComFunction.Param_Combo(cmb_buyDiv, "%") + "' ";
                sPara += "'" + COM.ComFunction.Param_Combo(cmb_user, "%") + "' ";
                sPara += "'" + COM.ComFunction.Empty_TextBox(txt_vendorCode, "%") + "' ";
                sPara += "'" + COM.ComFunction.Param_Combo(cmb_priceYn, "%") + "' ";

                vConfYn = chk_confirmYn.Checked ? "%" : "N";

                sPara += "'" + vConfYn + "' ";
                sPara += "'" + COM.ComFunction.Param_Combo(cmb_inUser, "%") + "' ";
                sPara += "'" + ClassLib.ComVar.This_Factory + "' ";


                FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

                MyReport.Text = "Incoming Adjust sheet";
                MyReport.Show();
            }



		}

		private void SubTotalProcess()
		{
			// more setup
			fgrid_main.SubtotalPosition = SubtotalPositionEnum.AboveData;
			fgrid_main.AllowDragging	= AllowDraggingEnum.None;

			fgrid_main.Subtotal(AggregateEnum.Clear);
			
			fgrid_main.Subtotal(AggregateEnum.Sum, 1, -1,		_amountUsdCol, "Total");
			fgrid_main.Subtotal(AggregateEnum.Sum, 1, -1,		_amountKrwCol, "Total");
			fgrid_main.Subtotal(AggregateEnum.Sum, 1, -1,		_inQtyCol, "Total");	

			fgrid_main.Subtotal(AggregateEnum.Sum, 3, _itemCol, _inQtyCol, "{0}");
			fgrid_main.Subtotal(AggregateEnum.Sum, 3, _itemCol, _amountUsdCol, "{0}");
			fgrid_main.Subtotal(AggregateEnum.Sum, 3, _itemCol, _amountKrwCol, "{0}");
		}
		
		private void Tbtn_AfterSaveProcess()
		{
			try
			{									
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

				this.EnableControlCheckProcess(true);	// Control Enable Check

//				// Status 확인
//				for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
//				{
//					if (fgrid_main[vRow, _inStatusCol].ToString() == "C")
//					{
//						_vCommitCount = _vCommitCount + 1; 
//						fgrid_main.Rows[vRow].AllowEditing = false;
//					}
//					else 
//					{
//						_vSaveCount   = _vSaveCount + 1;
//						fgrid_main.Rows[vRow].AllowEditing = true;
//					}
//				}
//
//				if (_vSaveCount > 0 && _vCommitCount > 0)
//				{
//					tbtn_Confirm.Enabled		= false;
//					tbtn_Save.Enabled			= true;
//					tbtn_Delete.Enabled			= true;
//				}
//				else 
//				{
//					tbtn_Confirm.Enabled		= true;
//					if ( _vCommitCount > 0 )
//					{
//						_vConfirmYn				= true;
//						fgrid_main.AllowEditing = false;
//						tbtn_Save.Enabled		= false;
//						tbtn_Delete.Enabled		= false;
//					}
//					else 
//					{
//						_vConfirmYn				= false;
//						fgrid_main.AllowEditing = true;
//						tbtn_Save.Enabled		= true;
//						tbtn_Delete.Enabled		= true;
//					}
//				}
//
				SubTotalProcess();
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
				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					DialogResult result = new DialogResult(); 

					if (arg_bool) 
					{	
						result = ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					}
					if ((!arg_bool) || result.ToString() == "Yes")
					{
						fgrid_main.Select(fgrid_main.Selection.r1, fgrid_main.Selection.c1); 
						if (MyOraDB.Save_FlexGird("PKG_SBI_IN_ADJUST.SAVE_SBI_IN_ADJUST_NEW", fgrid_main))
						{
							Tbtn_AfterSaveProcess();
							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
						}
					}
				}

				SubTotalProcess();


				DataTable dt = SELECT_SBI_IN_ADJUST_TOTAL();
				txt_in_total_qty.Text = dt.Rows[0].ItemArray[0].ToString();
				txt_total_usd_price.Text = dt.Rows[0].ItemArray[1].ToString();
				txt_total_krw_proce.Text = dt.Rows[0].ItemArray[2].ToString();
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

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
					{
						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
						{
							if (fgrid_main[vRow, 0] != null && fgrid_main[vRow, 0].ToString() != "")
							{
								Tbtn_SaveProcess(false); 
							}
						}	
	
						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
						{
							fgrid_main[vRow, _inStatusCol]	= "C"; 
						}	

						// confirm 처리, stock trigger 발생
						bool save_flag = SAVE_SBI_IN_HEAD("C"); 

						bool save_acc_flag = false;
						
						if(save_flag)
						{
							// 회계 연결 전표 위한 데이터 제공
							if(ClassLib.ComVar.This_Factory == "QD")
							{
								this.Cursor = Cursors.WaitCursor;

								save_acc_flag = SAVE_SBI_ACCOUNT_INF_ADJUST(); 
							} 
							else
							{
								save_acc_flag = true;
							}// end if(ClassLib.ComVar.This_Factory == "QD")

						} 
						else
						{
							save_acc_flag = false;
						}
 


						if(save_acc_flag)
						{

							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
							ClassLib.ComFunction.User_Message("Completed Comfirm", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
							Tbtn_AfterSaveProcess();
						}
						else
						{
							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					
						} // end if(save_acc_flag)



					} // end confirm yes/no
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


		/// <summary>
		/// Check_CREATE_SLIP : 회계 연결 전표 작성 여부 체크
		/// </summary>
		/// <returns></returns>
		private bool Check_CREATE_SLIP()
		{

			try
			{
				DataTable dt_ret = SELECT_SBI_IN_CREATE_SLIP();

				if(dt_ret.Rows.Count > 0)
				{
					string message = "Already create relation slip, so you can't confirm cancel."
						+ "\r\n\r\n" + "Incoming Date : " + dt_ret.Rows[0].ItemArray[0].ToString()
						+ "\r\n" + "Incoming No : " + dt_ret.Rows[0].ItemArray[1].ToString();

					ClassLib.ComFunction.User_Message(message, "Confirm cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return true; 

				} // end if(dt_ret.Rows.Count > 0) : 연결 전표 작성되어 있는 입고 번호가 있는 경우 
				else
				{
					return false;
				}

			}
			catch
			{
				return false;
			}

		}

		private void Tbtn_ConfirmCancelProcess()
		{
			try
			{ 
				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{


					// 회계 연결 전표 작성 여부 체크
					if(ClassLib.ComVar.This_Factory == "QD")
					{
						bool create_slip_flag = Check_CREATE_SLIP(); 
						if(create_slip_flag) return;  
					}



//					if(ClassLib.ComVar.This_Factory == "QD")
//					{
//						DataTable dt_ret = SELECT_SBI_IN_CREATE_SLIP();
//
//						if(dt_ret.Rows.Count > 0)
//						{
//							string message = "Already create relation slip, so you can't confirm cancel."
//								+ "\r\n\r\n" + "Incoming Date : " + dt_ret.Rows[0].ItemArray[0].ToString()
//								+ "\r\n" + "Incoming No : " + dt_ret.Rows[0].ItemArray[1].ToString();
//
//							ClassLib.ComFunction.User_Message(message, "Confirm cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
//							return; 
//
//						} // end if(dt_ret.Rows.Count > 0) : 연결 전표 작성되어 있는 입고 번호가 있는 경우 
//					} // end if(ClassLib.ComVar.This_Factory == "QD")



					if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you Cancel to Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
					{	
						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
						{
							fgrid_main[vRow, _inStatusCol]	= "R"; 
						}	

						SAVE_SBI_IN_HEAD("R");

						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
						ClassLib.ComFunction.User_Message("Completed Comfirm Cancel", "Confirm_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
						{
							fgrid_main[vRow, _inStatusCol]	= "S"; 
						}	

						Tbtn_AfterSaveProcess();
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}

		private void Cmb_inNoSettingProcess()
		{
			try
			{
				if (_practicable)
				{
					//Tbtn_NewProcess();
					cmb_inNo.SelectedValueChanged -= _cmbInNoEventHandler;

					string[] vProviso = GetSearchProviso();
					DataTable vDt = SELECT_SBI_IN_NO(vProviso[0], vProviso[1], vProviso[2]);
					COM.ComCtl.Set_ComboList(vDt, cmb_inNo, 0, 1, true, false);
					cmb_inNo.SelectedIndex = 0;
					vDt.Dispose();

					cmb_inNo.SelectedValueChanged += _cmbInNoEventHandler;
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
				if(!_initYn)
					Tbtn_SearchProcess();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		#endregion

		#region DB Connect
		private bool SAVE_SBI_IN_STATUS(string arg_factory, string arg_in_no, string arg_in_seq, string arg_value)
		{

			try
			{

				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBI_IN_TAIL.SAVE_SBI_IN_STATUS";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1]  = "ARG_IN_NO";
				MyOraDB.Parameter_Name[2]  = "ARG_IN_SEQ";
				MyOraDB.Parameter_Name[3]  = "ARG_VALUE";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0]  = arg_factory;
				MyOraDB.Parameter_Values[1]  = arg_in_no;
				MyOraDB.Parameter_Values[2]  = arg_in_seq;
				MyOraDB.Parameter_Values[3]  = arg_value;
		
				MyOraDB.Add_Modify_Parameter(true);
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)  return false;
				return true;

			}
			catch
			{
				return false;
			}


		}

		/// <summary>
		/// PKG_SBI_IN_NO : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBI_IN_NO : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_IN_NO(string arg_factory, string arg_from, string arg_to)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST.SELECT_SBI_IN_NO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_TO";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_from;
			MyOraDB.Parameter_Values[2] = arg_to;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}
		

		/// <summary>
		/// PKG_SBI_IN_TAIL : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_IN_ADJUST_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(21);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST.SELECT_SBI_IN_ADJUST_LIST_NEW";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_IN_NO";
			MyOraDB.Parameter_Name[2]  = "ARG_FROM";
			MyOraDB.Parameter_Name[3]  = "ARG_TO";
			MyOraDB.Parameter_Name[4]  = "ARG_PUR_DIV";
			MyOraDB.Parameter_Name[5]  = "ARG_BUY_DIV";
			MyOraDB.Parameter_Name[6]  = "ARG_USER";
			MyOraDB.Parameter_Name[7]  = "ARG_VENDOR";
			MyOraDB.Parameter_Name[8]  = "ARG_PRICEYN";
			MyOraDB.Parameter_Name[9]  = "ARG_CONF_YN";
			MyOraDB.Parameter_Name[10] = "ARG_IN_USER";
			MyOraDB.Parameter_Name[11] = "ARG_LOC_FACTORY";
			MyOraDB.Parameter_Name[12] = "ARG_SS_NOT_IN";
            MyOraDB.Parameter_Name[13] = "ARG_PUR_FACTORY";
			MyOraDB.Parameter_Name[14] = "ARG_IN_TYPE";
			MyOraDB.Parameter_Name[15] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[16] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[17] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[18] = "ARG_ITEM_NM";
			MyOraDB.Parameter_Name[19] = "ARG_SHIP_YMD";
			MyOraDB.Parameter_Name[20] = "OUT_CURSOR";




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
			MyOraDB.Parameter_Type[14]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[20] = (int)OracleType.Cursor;
			
			//04.DATA 정의
			MyOraDB.Parameter_Values[0]  = COM.ComFunction.Empty_Combo(cmb_factory, " ");
			MyOraDB.Parameter_Values[1]  = COM.ComFunction.Empty_Combo(cmb_inNo, "");
			MyOraDB.Parameter_Values[2]  = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3]  = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4]  = COM.ComFunction.Empty_Combo(cmb_purDiv, " ");
			MyOraDB.Parameter_Values[5]  = COM.ComFunction.Empty_Combo(cmb_buyDiv, " ");
			MyOraDB.Parameter_Values[6]  = COM.ComFunction.Empty_Combo(cmb_user, " ");
			MyOraDB.Parameter_Values[7]  = this.cmb_vendor.SelectedIndex  > -1 ? this.cmb_vendor.SelectedValue.ToString()  : "";//ClassLib.ComFunction.Empty_TextBox(txt_vendorCode, "");
			MyOraDB.Parameter_Values[8]  = COM.ComFunction.Empty_Combo(cmb_priceYn, "");
			MyOraDB.Parameter_Values[9]  = chk_confirmYn.Checked ? "%" : "N";
			MyOraDB.Parameter_Values[10] = COM.ComFunction.Empty_Combo(cmb_inUser, " ");
			MyOraDB.Parameter_Values[11] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[12]= (chk_not_ss.Checked == true)?"T":"F";
			MyOraDB.Parameter_Values[13] = COM.ComFunction.Empty_Combo(cmb_pur_factory, " ");

	
			MyOraDB.Parameter_Values[14]  = COM.ComFunction.Empty_Combo(cmb_inType, "");
			MyOraDB.Parameter_Values[15]  = COM.ComFunction.Empty_TextBox(txt_styleCd, " ");
			//MyOraDB.Parameter_Values[16]  = COM.ComFunction.Empty_Combo(cmb_itemGroup, " ");
            MyOraDB.Parameter_Values[16] = _sel_group_cd;
			MyOraDB.Parameter_Values[17]  = COM.ComFunction.Empty_TextBox(txt_itemCd, " ");
			MyOraDB.Parameter_Values[18]  = COM.ComFunction.Empty_TextBox(txt_itemNm, " ");
			MyOraDB.Parameter_Values[19]  = (chk_ship_date.Checked == true)? dpick_Ship_Date.Text.Replace("-",""):" ";

			MyOraDB.Parameter_Values[20] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBI_IN_TAIL : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_IN_ADJUST_TOTAL()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(21);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST.SELECT_SBI_IN_ADJUST_TOTAL01";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_IN_NO";
			MyOraDB.Parameter_Name[2]  = "ARG_FROM";
			MyOraDB.Parameter_Name[3]  = "ARG_TO";
			MyOraDB.Parameter_Name[4]  = "ARG_PUR_DIV";
			MyOraDB.Parameter_Name[5]  = "ARG_BUY_DIV";
			MyOraDB.Parameter_Name[6]  = "ARG_USER";
			MyOraDB.Parameter_Name[7]  = "ARG_VENDOR";
			MyOraDB.Parameter_Name[8]  = "ARG_PRICEYN";
			MyOraDB.Parameter_Name[9]  = "ARG_CONF_YN";
			MyOraDB.Parameter_Name[10] = "ARG_IN_USER";
			MyOraDB.Parameter_Name[11] = "ARG_LOC_FACTORY";
			MyOraDB.Parameter_Name[12] = "ARG_SS_NOT_IN";
			MyOraDB.Parameter_Name[13] = "ARG_PUR_FACTORY";
			MyOraDB.Parameter_Name[14] = "ARG_IN_TYPE";
			MyOraDB.Parameter_Name[15] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[16] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[17] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[18] = "ARG_ITEM_NM";
			MyOraDB.Parameter_Name[19] = "ARG_SHIP_YMD";
			MyOraDB.Parameter_Name[20] = "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[14]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[20] = (int)OracleType.Cursor;
			
			//04.DATA 정의
			MyOraDB.Parameter_Values[0]  = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1]  = COM.ComFunction.Empty_Combo(cmb_inNo, "");
			MyOraDB.Parameter_Values[2]  = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3]  = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4]  = COM.ComFunction.Empty_Combo(cmb_purDiv, "");
			MyOraDB.Parameter_Values[5]  = COM.ComFunction.Empty_Combo(cmb_buyDiv, "");
			MyOraDB.Parameter_Values[6]  = COM.ComFunction.Empty_Combo(cmb_user, "");
			MyOraDB.Parameter_Values[7]  = this.cmb_vendor.SelectedIndex  > -1 ? this.cmb_vendor.SelectedValue.ToString()  : "";
			MyOraDB.Parameter_Values[8]  = COM.ComFunction.Empty_Combo(cmb_priceYn, "");
			MyOraDB.Parameter_Values[9]  = chk_confirmYn.Checked ? "%" : "N";
			MyOraDB.Parameter_Values[10] = COM.ComFunction.Empty_Combo(cmb_inUser, "");
			MyOraDB.Parameter_Values[11] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[12]= (chk_not_ss.Checked == true)?"T":"F";
			MyOraDB.Parameter_Values[13]=  COM.ComFunction.Empty_Combo(cmb_pur_factory, " ");
				
			MyOraDB.Parameter_Values[14]  = COM.ComFunction.Empty_Combo(cmb_inType, "");
			MyOraDB.Parameter_Values[15]  = COM.ComFunction.Empty_TextBox(txt_styleCd, " ");
			MyOraDB.Parameter_Values[16]  = COM.ComFunction.Empty_Combo(cmb_itemGroup, " ");
			MyOraDB.Parameter_Values[17]  = COM.ComFunction.Empty_TextBox(txt_itemCd, " ");
			MyOraDB.Parameter_Values[18]  = COM.ComFunction.Empty_TextBox(txt_itemNm, " ");
			MyOraDB.Parameter_Values[19]  = (chk_ship_date.Checked == true)? dpick_Ship_Date.Text.Replace("-",""):" ";

			MyOraDB.Parameter_Values[20] = "";


			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// SAVE_SBI_IN_HEAD : 헤더 정보 저장
		/// </summary>
		public bool SAVE_SBI_IN_HEAD(string arg_div)
		{

			try
			{

				MyOraDB.ReDim_Parameter(11);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST.SAVE_SBI_IN_HEAD";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2]  = "ARG_IN_NO";
				MyOraDB.Parameter_Name[3]  = "ARG_FROM";
				MyOraDB.Parameter_Name[4]  = "ARG_TO";
				MyOraDB.Parameter_Name[5]  = "ARG_PUR_DIV";
				MyOraDB.Parameter_Name[6]  = "ARG_BUY_DIV";
				MyOraDB.Parameter_Name[7]  = "ARG_USER";
				MyOraDB.Parameter_Name[8]  = "ARG_VENDOR";
				MyOraDB.Parameter_Name[9]  = "ARG_PRICEYN";
				MyOraDB.Parameter_Name[10] = "ARG_UPD_USER";

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

				//04.DATA 정의
				MyOraDB.Parameter_Values[0]  = arg_div;
				MyOraDB.Parameter_Values[1]  = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[2]  = COM.ComFunction.Empty_Combo(cmb_inNo, "");
				MyOraDB.Parameter_Values[3]  = dpick_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[4]  = dpick_to.Text.Replace("-", "");
				MyOraDB.Parameter_Values[5]  = COM.ComFunction.Empty_Combo(cmb_purDiv, "");
				MyOraDB.Parameter_Values[6]  = COM.ComFunction.Empty_Combo(cmb_buyDiv, "");
				MyOraDB.Parameter_Values[7]  = COM.ComFunction.Empty_Combo(cmb_user, "");
				MyOraDB.Parameter_Values[8]  = ClassLib.ComFunction.Empty_TextBox(txt_vendorCode, "");
				MyOraDB.Parameter_Values[9]  = COM.ComFunction.Empty_Combo(cmb_priceYn, "");
				MyOraDB.Parameter_Values[10] = COM.ComVar.This_User;
		
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
		/// SELECT_SBI_IN_CREATE_SLIP : 입고 연결 전표 작성 여부 체크
		/// </summary>
		/// <returns></returns>
		private DataTable SELECT_SBI_IN_CREATE_SLIP()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST_ACC.SELECT_SBI_IN_CREATE_SLIP";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_NO";
			MyOraDB.Parameter_Name[2] = "ARG_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_TO";
			MyOraDB.Parameter_Name[4] = "ARG_PUR_DIV";
			MyOraDB.Parameter_Name[5] = "ARG_BUY_DIV";
			MyOraDB.Parameter_Name[6] = "ARG_USER";
			MyOraDB.Parameter_Name[7] = "ARG_VENDOR";
			MyOraDB.Parameter_Name[8] = "ARG_PRICEYN"; 
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
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_inNo, "");
			MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_purDiv, "");
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_Combo(cmb_buyDiv, "");
			MyOraDB.Parameter_Values[6] = COM.ComFunction.Empty_Combo(cmb_user, "");
			MyOraDB.Parameter_Values[7] = this.cmb_vendor.SelectedIndex  > -1 ? this.cmb_vendor.SelectedValue.ToString()  : "";//ClassLib.ComFunction.Empty_TextBox(txt_vendorCode, "");
			MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_Combo(cmb_priceYn, ""); 
			MyOraDB.Parameter_Values[9] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// SAVE_SBI_ACCOUNT_INF_ADJUST : 회계 연결 전표 위한 데이터 제공 
		/// </summary>
		/// <returns></returns>
		private bool SAVE_SBI_ACCOUNT_INF_ADJUST()
		{

			try
			{

				MyOraDB.ReDim_Parameter(10);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST_ACC.SAVE_SBI_ACCOUNT_INF_ADJUST";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1]  = "ARG_IN_NO";
				MyOraDB.Parameter_Name[2]  = "ARG_FROM";
				MyOraDB.Parameter_Name[3]  = "ARG_TO";
				MyOraDB.Parameter_Name[4]  = "ARG_PUR_DIV";
				MyOraDB.Parameter_Name[5]  = "ARG_BUY_DIV";
				MyOraDB.Parameter_Name[6]  = "ARG_USER";
				MyOraDB.Parameter_Name[7]  = "ARG_VENDOR";
				MyOraDB.Parameter_Name[8]  = "ARG_PRICEYN";
				MyOraDB.Parameter_Name[9]  = "ARG_UPD_USER"; 

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

				//04.DATA 정의
				MyOraDB.Parameter_Values[0]  = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1]  = COM.ComFunction.Empty_Combo(cmb_inNo, "");
				MyOraDB.Parameter_Values[2]  = dpick_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[3]  = dpick_to.Text.Replace("-", "");
				MyOraDB.Parameter_Values[4]  = COM.ComFunction.Empty_Combo(cmb_purDiv, "");
				MyOraDB.Parameter_Values[5]  = COM.ComFunction.Empty_Combo(cmb_buyDiv, "");
				MyOraDB.Parameter_Values[6]  = COM.ComFunction.Empty_Combo(cmb_user, "");
				MyOraDB.Parameter_Values[7]  = ClassLib.ComFunction.Empty_TextBox(txt_vendorCode, "");
				MyOraDB.Parameter_Values[8]  = COM.ComFunction.Empty_Combo(cmb_priceYn, "");
				MyOraDB.Parameter_Values[9]  = COM.ComVar.This_User; 
		
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


		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

        string _sel_group_cd = "";
        private void cmb_itemGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_itemGroup.SelectedIndex >= 0)
                this.btn_groupSearch.Enabled = true;
            else
                this.btn_groupSearch.Enabled = false;

            _sel_group_cd = COM.ComFunction.Empty_Combo(cmb_itemGroup, "");
        }

        private void cmb_itemGroup_TextChanged(object sender, EventArgs e)
        {

        }
	}
}

