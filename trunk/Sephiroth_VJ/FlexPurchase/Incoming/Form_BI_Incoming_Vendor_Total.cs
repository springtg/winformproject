using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexPurchase.Incoming
{
	public class Form_BI_Incoming_Vendor_Total : COM.PCHWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private C1.Win.C1List.C1Combo cmb_user;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private C1.Win.C1List.C1Combo cmb_purDiv;
		private C1.Win.C1List.C1Combo cmb_buyDiv;
		private System.Windows.Forms.Label lbl_buyDiv;
		private System.Windows.Forms.Label lbl_purDiv;
		private C1.Win.C1List.C1Combo cmb_priceYn;
		private System.Windows.Forms.Label lbl_priceYN;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label lbl_inYmd;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Label btn_sum;
		private System.Windows.Forms.ContextMenu cmenu_Adjust;
		private System.Windows.Forms.MenuItem menuitem_RateExchange;
		private System.Windows.Forms.MenuItem menuitem_DCExchange;
		private System.ComponentModel.IContainer components = null;
		public COM.FSP fgrid_main;
		private int tree_level = 1;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB	= new COM.OraDB();
		private int  _fixedRow		= 0;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmb_printType;
		private System.Windows.Forms.Label lbl_printType;

		private bool	_isAccessible	= false;
		private bool	_bPopChk		= false;
		private bool	_vConfirmYn		= false;
		private bool    _initYn			= false;



		private string  _vClosingYn		= "";
		private string  _vCSC	= "CSC";

		private int     _vSaveCount		= 0;
		private int     _vCommitCount	= 0;
		private int     _vConfCount		= 0;

		private int _lxItemCdCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxITEM_CD;
		private int _lxUsdPriceCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxUSD_PRICE;
		private int _lxCurPriceCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxCUR_PRICE;
		private int _lxAmountUsdCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxAMOUNT_USD;
		private int _lxAmountKrwCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxAMOUNT_KRW;
		private int _lxAdjustUsdCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_USD;
		private int _lxAdjustKrwCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_KRW;
		private int _lxVatKrwCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxVAT_KRW;
		private int _lxAdjustDescCol	= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_DESC;
		private int _lxPurUserCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxPUR_USER;
		private int _lxCustYmCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxCUST_YM;
		private int _lxCustCdCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxCUST_CD;
		private int _lxCustNameCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxCUST_NAME;
		private int _lxBuyDivCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxBUY_DIV;
		private int _lxFactLocCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxFACT_LOC;
		private int _lxPosCol			= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxPOS;
		private int _lxAccountConfCol	= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxACCOUNT_CONF;
		private int _lxAccountStatusCol	= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxACCOUNT_STATUS;
//		private int _lxUpdUserCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxUPD_USER;
//		private int _lxFactoryCol		= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxFACTORY;
//		private int _lxInQtyCol			= (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxIN_QTY;
		
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txt_itemNm;
		private System.Windows.Forms.Label lbl_headInfo;
		private System.Windows.Forms.TextBox txt_rate;
		private COM.FSP fgrid_tail;
		public System.Windows.Forms.TextBox txt_dc;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem1;
		private C1.Win.C1List.C1Combo cmb_pur_factory;
		private System.Windows.Forms.Label lbl_SH_CDC;
		private int _RowFixed = 0;
		#endregion

		#region 생성자 / 소멸자
		public Form_BI_Incoming_Vendor_Total()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BI_Incoming_Vendor_Total));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_pur_factory = new C1.Win.C1List.C1Combo();
            this.lbl_SH_CDC = new System.Windows.Forms.Label();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.cmb_printType = new C1.Win.C1List.C1Combo();
            this.lbl_printType = new System.Windows.Forms.Label();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.btn_sum = new System.Windows.Forms.Label();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.cmb_purDiv = new C1.Win.C1List.C1Combo();
            this.cmb_buyDiv = new C1.Win.C1List.C1Combo();
            this.lbl_buyDiv = new System.Windows.Forms.Label();
            this.lbl_purDiv = new System.Windows.Forms.Label();
            this.cmb_priceYn = new C1.Win.C1List.C1Combo();
            this.lbl_priceYN = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_inYmd = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.fgrid_main = new COM.FSP();
            this.cmenu_Adjust = new System.Windows.Forms.ContextMenu();
            this.menuitem_DCExchange = new System.Windows.Forms.MenuItem();
            this.menuitem_RateExchange = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.fgrid_tail = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_printType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_priceYn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_tail)).BeginInit();
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
            // tbtn_Create
            // 
            this.tbtn_Create.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Create_Click);
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
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.fgrid_tail);
            this.c1Sizer1.GridDefinition = "17.687074829932:False:True;79.421768707483:False:False;0.170068027210884:False:Tr" +
                "ue;\t0.393700787401575:False:True;97.6377952755905:False:False;0.393700787401575:" +
                "False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 588);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_pur_factory);
            this.pnl_head.Controls.Add(this.lbl_SH_CDC);
            this.pnl_head.Controls.Add(this.txt_rate);
            this.pnl_head.Controls.Add(this.cmb_printType);
            this.pnl_head.Controls.Add(this.lbl_printType);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.lbl_vendor);
            this.pnl_head.Controls.Add(this.cmb_vendor);
            this.pnl_head.Controls.Add(this.txt_vendorCode);
            this.pnl_head.Controls.Add(this.btn_sum);
            this.pnl_head.Controls.Add(this.txt_dc);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.txt_itemNm);
            this.pnl_head.Controls.Add(this.cmb_user);
            this.pnl_head.Controls.Add(this.pictureBox1);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.txt_itemCd);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.lbl_user);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.cmb_purDiv);
            this.pnl_head.Controls.Add(this.cmb_buyDiv);
            this.pnl_head.Controls.Add(this.lbl_buyDiv);
            this.pnl_head.Controls.Add(this.lbl_purDiv);
            this.pnl_head.Controls.Add(this.cmb_priceYn);
            this.pnl_head.Controls.Add(this.lbl_priceYN);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_inYmd);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 104);
            this.pnl_head.TabIndex = 32;
            // 
            // cmb_pur_factory
            // 
            this.cmb_pur_factory.AddItemCols = 0;
            this.cmb_pur_factory.AddItemSeparator = ';';
            this.cmb_pur_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_pur_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_pur_factory.Caption = "";
            this.cmb_pur_factory.CaptionHeight = 17;
            this.cmb_pur_factory.CaptionStyle = style1;
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
            this.cmb_pur_factory.EvenRowStyle = style2;
            this.cmb_pur_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_pur_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pur_factory.FooterStyle = style3;
            this.cmb_pur_factory.GapHeight = 2;
            this.cmb_pur_factory.HeadingStyle = style4;
            this.cmb_pur_factory.HighLightRowStyle = style5;
            this.cmb_pur_factory.ItemHeight = 15;
            this.cmb_pur_factory.Location = new System.Drawing.Point(109, 78);
            this.cmb_pur_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_pur_factory.MaxDropDownItems = ((short)(5));
            this.cmb_pur_factory.MaxLength = 32767;
            this.cmb_pur_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_pur_factory.Name = "cmb_pur_factory";
            this.cmb_pur_factory.OddRowStyle = style6;
            this.cmb_pur_factory.PartialRightColumn = false;
            this.cmb_pur_factory.PropBag = resources.GetString("cmb_pur_factory.PropBag");
            this.cmb_pur_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_pur_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_pur_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_pur_factory.SelectedStyle = style7;
            this.cmb_pur_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_pur_factory.Style = style8;
            this.cmb_pur_factory.TabIndex = 559;
            // 
            // lbl_SH_CDC
            // 
            this.lbl_SH_CDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SH_CDC.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SH_CDC.ImageIndex = 0;
            this.lbl_SH_CDC.ImageList = this.img_Label;
            this.lbl_SH_CDC.Location = new System.Drawing.Point(8, 78);
            this.lbl_SH_CDC.Name = "lbl_SH_CDC";
            this.lbl_SH_CDC.Size = new System.Drawing.Size(100, 21);
            this.lbl_SH_CDC.TabIndex = 560;
            this.lbl_SH_CDC.Text = "Pur Factory";
            this.lbl_SH_CDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_rate
            // 
            this.txt_rate.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_rate.Location = new System.Drawing.Point(352, 80);
            this.txt_rate.MaxLength = 10;
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(48, 21);
            this.txt_rate.TabIndex = 418;
            this.txt_rate.Visible = false;
            // 
            // cmb_printType
            // 
            this.cmb_printType.AddItemCols = 0;
            this.cmb_printType.AddItemSeparator = ';';
            this.cmb_printType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_printType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_printType.Caption = "";
            this.cmb_printType.CaptionHeight = 17;
            this.cmb_printType.CaptionStyle = style9;
            this.cmb_printType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_printType.ColumnCaptionHeight = 18;
            this.cmb_printType.ColumnFooterHeight = 18;
            this.cmb_printType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_printType.ContentHeight = 16;
            this.cmb_printType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_printType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_printType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_printType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_printType.EditorHeight = 16;
            this.cmb_printType.EvenRowStyle = style10;
            this.cmb_printType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_printType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_printType.FooterStyle = style11;
            this.cmb_printType.GapHeight = 2;
            this.cmb_printType.HeadingStyle = style12;
            this.cmb_printType.HighLightRowStyle = style13;
            this.cmb_printType.ItemHeight = 15;
            this.cmb_printType.Location = new System.Drawing.Point(772, 55);
            this.cmb_printType.MatchEntryTimeout = ((long)(2000));
            this.cmb_printType.MaxDropDownItems = ((short)(5));
            this.cmb_printType.MaxLength = 32767;
            this.cmb_printType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_printType.Name = "cmb_printType";
            this.cmb_printType.OddRowStyle = style14;
            this.cmb_printType.PartialRightColumn = false;
            this.cmb_printType.PropBag = resources.GetString("cmb_printType.PropBag");
            this.cmb_printType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_printType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_printType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_printType.SelectedStyle = style15;
            this.cmb_printType.Size = new System.Drawing.Size(132, 20);
            this.cmb_printType.Style = style16;
            this.cmb_printType.TabIndex = 395;
            // 
            // lbl_printType
            // 
            this.lbl_printType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_printType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_printType.ImageIndex = 0;
            this.lbl_printType.ImageList = this.img_Label;
            this.lbl_printType.Location = new System.Drawing.Point(672, 55);
            this.lbl_printType.Name = "lbl_printType";
            this.lbl_printType.Size = new System.Drawing.Size(100, 21);
            this.lbl_printType.TabIndex = 394;
            this.lbl_printType.Text = "Print Type";
            this.lbl_printType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(230, 55);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(99, 21);
            this.dpick_to.TabIndex = 385;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(339, 55);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 389;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemCols = 0;
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style17;
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
            this.cmb_vendor.EvenRowStyle = style18;
            this.cmb_vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style19;
            this.cmb_vendor.GapHeight = 2;
            this.cmb_vendor.HeadingStyle = style20;
            this.cmb_vendor.HighLightRowStyle = style21;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(520, 55);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style22;
            this.cmb_vendor.PartialRightColumn = false;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style23;
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style24;
            this.cmb_vendor.TabIndex = 388;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(440, 55);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 387;
            this.txt_vendorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vendorCode_KeyPress);
            // 
            // btn_sum
            // 
            this.btn_sum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_sum.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_sum.ImageIndex = 0;
            this.btn_sum.ImageList = this.img_Button;
            this.btn_sum.Location = new System.Drawing.Point(912, 54);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(80, 23);
            this.btn_sum.TabIndex = 399;
            this.btn_sum.Text = "Account";
            this.btn_sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // txt_dc
            // 
            this.txt_dc.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_dc.Location = new System.Drawing.Point(408, 80);
            this.txt_dc.MaxLength = 10;
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(64, 21);
            this.txt_dc.TabIndex = 419;
            this.txt_dc.Visible = false;
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
            this.lbl_headInfo.TabIndex = 417;
            this.lbl_headInfo.Text = "       Incoming Vendor Total  Info";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(852, 99);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(140, 21);
            this.txt_itemNm.TabIndex = 408;
            this.txt_itemNm.Visible = false;
            // 
            // cmb_user
            // 
            this.cmb_user.AddItemCols = 0;
            this.cmb_user.AddItemSeparator = ';';
            this.cmb_user.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_user.Caption = "";
            this.cmb_user.CaptionHeight = 17;
            this.cmb_user.CaptionStyle = style25;
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
            this.cmb_user.EvenRowStyle = style26;
            this.cmb_user.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FooterStyle = style27;
            this.cmb_user.GapHeight = 2;
            this.cmb_user.HeadingStyle = style28;
            this.cmb_user.HighLightRowStyle = style29;
            this.cmb_user.ItemHeight = 15;
            this.cmb_user.Location = new System.Drawing.Point(772, 33);
            this.cmb_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_user.MaxDropDownItems = ((short)(5));
            this.cmb_user.MaxLength = 32767;
            this.cmb_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.OddRowStyle = style30;
            this.cmb_user.PartialRightColumn = false;
            this.cmb_user.PropBag = resources.GetString("cmb_user.PropBag");
            this.cmb_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_user.SelectedStyle = style31;
            this.cmb_user.Size = new System.Drawing.Size(220, 20);
            this.cmb_user.Style = style32;
            this.cmb_user.TabIndex = 390;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 18);
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style33;
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
            this.cmb_itemGroup.EvenRowStyle = style34;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style35;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style36;
            this.cmb_itemGroup.HighLightRowStyle = style37;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(772, 99);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style38;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style39;
            this.cmb_itemGroup.Size = new System.Drawing.Size(197, 20);
            this.cmb_itemGroup.Style = style40;
            this.cmb_itemGroup.TabIndex = 404;
            this.cmb_itemGroup.Visible = false;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(968, 55);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 403;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Visible = false;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(772, 99);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(79, 21);
            this.txt_itemCd.TabIndex = 402;
            this.txt_itemCd.Visible = false;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(672, 99);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 401;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_item.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(671, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 400;
            this.label1.Text = "Item Group";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ImageIndex = 0;
            this.lbl_user.ImageList = this.img_Label;
            this.lbl_user.Location = new System.Drawing.Point(672, 33);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_user.TabIndex = 391;
            this.lbl_user.Text = "User";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // cmb_purDiv
            // 
            this.cmb_purDiv.AddItemCols = 0;
            this.cmb_purDiv.AddItemSeparator = ';';
            this.cmb_purDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purDiv.Caption = "";
            this.cmb_purDiv.CaptionHeight = 17;
            this.cmb_purDiv.CaptionStyle = style41;
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
            this.cmb_purDiv.EvenRowStyle = style42;
            this.cmb_purDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purDiv.FooterStyle = style43;
            this.cmb_purDiv.GapHeight = 2;
            this.cmb_purDiv.HeadingStyle = style44;
            this.cmb_purDiv.HighLightRowStyle = style45;
            this.cmb_purDiv.ItemHeight = 15;
            this.cmb_purDiv.Location = new System.Drawing.Point(440, 99);
            this.cmb_purDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_purDiv.MaxDropDownItems = ((short)(5));
            this.cmb_purDiv.MaxLength = 32767;
            this.cmb_purDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purDiv.Name = "cmb_purDiv";
            this.cmb_purDiv.OddRowStyle = style46;
            this.cmb_purDiv.PartialRightColumn = false;
            this.cmb_purDiv.PropBag = resources.GetString("cmb_purDiv.PropBag");
            this.cmb_purDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purDiv.SelectedStyle = style47;
            this.cmb_purDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_purDiv.Style = style48;
            this.cmb_purDiv.TabIndex = 362;
            this.cmb_purDiv.Visible = false;
            // 
            // cmb_buyDiv
            // 
            this.cmb_buyDiv.AddItemCols = 0;
            this.cmb_buyDiv.AddItemSeparator = ';';
            this.cmb_buyDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_buyDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_buyDiv.Caption = "";
            this.cmb_buyDiv.CaptionHeight = 17;
            this.cmb_buyDiv.CaptionStyle = style49;
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
            this.cmb_buyDiv.EvenRowStyle = style50;
            this.cmb_buyDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_buyDiv.FooterStyle = style51;
            this.cmb_buyDiv.GapHeight = 2;
            this.cmb_buyDiv.HeadingStyle = style52;
            this.cmb_buyDiv.HighLightRowStyle = style53;
            this.cmb_buyDiv.ItemHeight = 15;
            this.cmb_buyDiv.Location = new System.Drawing.Point(440, 33);
            this.cmb_buyDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_buyDiv.MaxDropDownItems = ((short)(5));
            this.cmb_buyDiv.MaxLength = 32767;
            this.cmb_buyDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_buyDiv.Name = "cmb_buyDiv";
            this.cmb_buyDiv.OddRowStyle = style54;
            this.cmb_buyDiv.PartialRightColumn = false;
            this.cmb_buyDiv.PropBag = resources.GetString("cmb_buyDiv.PropBag");
            this.cmb_buyDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_buyDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_buyDiv.SelectedStyle = style55;
            this.cmb_buyDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_buyDiv.Style = style56;
            this.cmb_buyDiv.TabIndex = 361;
            // 
            // lbl_buyDiv
            // 
            this.lbl_buyDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_buyDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buyDiv.ImageIndex = 0;
            this.lbl_buyDiv.ImageList = this.img_Label;
            this.lbl_buyDiv.Location = new System.Drawing.Point(339, 33);
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
            this.lbl_purDiv.Location = new System.Drawing.Point(339, 99);
            this.lbl_purDiv.Name = "lbl_purDiv";
            this.lbl_purDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_purDiv.TabIndex = 359;
            this.lbl_purDiv.Text = "Pur  Division";
            this.lbl_purDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_purDiv.Visible = false;
            // 
            // cmb_priceYn
            // 
            this.cmb_priceYn.AddItemCols = 0;
            this.cmb_priceYn.AddItemSeparator = ';';
            this.cmb_priceYn.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_priceYn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_priceYn.Caption = "";
            this.cmb_priceYn.CaptionHeight = 17;
            this.cmb_priceYn.CaptionStyle = style57;
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
            this.cmb_priceYn.EvenRowStyle = style58;
            this.cmb_priceYn.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_priceYn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_priceYn.FooterStyle = style59;
            this.cmb_priceYn.GapHeight = 2;
            this.cmb_priceYn.HeadingStyle = style60;
            this.cmb_priceYn.HighLightRowStyle = style61;
            this.cmb_priceYn.ItemHeight = 15;
            this.cmb_priceYn.Location = new System.Drawing.Point(440, 99);
            this.cmb_priceYn.MatchEntryTimeout = ((long)(2000));
            this.cmb_priceYn.MaxDropDownItems = ((short)(5));
            this.cmb_priceYn.MaxLength = 32767;
            this.cmb_priceYn.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_priceYn.Name = "cmb_priceYn";
            this.cmb_priceYn.OddRowStyle = style62;
            this.cmb_priceYn.PartialRightColumn = false;
            this.cmb_priceYn.PropBag = resources.GetString("cmb_priceYn.PropBag");
            this.cmb_priceYn.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_priceYn.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_priceYn.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_priceYn.SelectedStyle = style63;
            this.cmb_priceYn.Size = new System.Drawing.Size(220, 20);
            this.cmb_priceYn.Style = style64;
            this.cmb_priceYn.TabIndex = 358;
            this.cmb_priceYn.Visible = false;
            // 
            // lbl_priceYN
            // 
            this.lbl_priceYN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_priceYN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priceYN.ImageIndex = 0;
            this.lbl_priceYN.ImageList = this.img_Label;
            this.lbl_priceYN.Location = new System.Drawing.Point(339, 99);
            this.lbl_priceYN.Name = "lbl_priceYN";
            this.lbl_priceYN.Size = new System.Drawing.Size(100, 21);
            this.lbl_priceYN.TabIndex = 357;
            this.lbl_priceYN.Text = "Price Y/N";
            this.lbl_priceYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_priceYN.Visible = false;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 88);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
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
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style65;
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
            this.cmb_factory.EvenRowStyle = style66;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style67;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style68;
            this.cmb_factory.HighLightRowStyle = style69;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 33);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style70;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style71;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style72;
            this.cmb_factory.TabIndex = 1;
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
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 63);
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
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 88);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 77);
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
            this.pic_head1.Size = new System.Drawing.Size(968, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ContextMenu = this.cmenu_Adjust;
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(12, 112);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(992, 472);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 31;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            this.fgrid_main.DoubleClick += new System.EventHandler(this.fgrid_main_DoubleClick);
            // 
            // cmenu_Adjust
            // 
            this.cmenu_Adjust.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuitem_DCExchange,
            this.menuitem_RateExchange,
            this.menuItem2,
            this.menuItem3,
            this.menuItem1});
            this.cmenu_Adjust.Popup += new System.EventHandler(this.cmenu_Adjust_Popup);
            // 
            // menuitem_DCExchange
            // 
            this.menuitem_DCExchange.Index = 0;
            this.menuitem_DCExchange.Text = "Discount Exchange";
            this.menuitem_DCExchange.Click += new System.EventHandler(this.menuitem_DCExchange_Click);
            // 
            // menuitem_RateExchange
            // 
            this.menuitem_RateExchange.Index = 1;
            this.menuitem_RateExchange.Text = "Rate Exchange";
            this.menuitem_RateExchange.Click += new System.EventHandler(this.menuitem_RateExchange_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "Factory DS";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "Factory Order";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 4;
            this.menuItem1.Text = "Account";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // fgrid_tail
            // 
            this.fgrid_tail.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_tail.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_tail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_tail.Location = new System.Drawing.Point(12, 583);
            this.fgrid_tail.Name = "fgrid_tail";
            this.fgrid_tail.Size = new System.Drawing.Size(992, 1);
            this.fgrid_tail.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_tail.Styles"));
            this.fgrid_tail.TabIndex = 420;
            // 
            // Form_BI_Incoming_Vendor_Total
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BI_Incoming_Vendor_Total";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BI_Incoming_Vendor_Total_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_printType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_priceYn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_tail)).EndInit();
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

		private void fgrid_main_DoubleClick(object sender, System.EventArgs e)
		{
			this.Grid_DoubleClickProcess();
		}

		



		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Right && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
				{
					//				if (fgrid_main.AllowEditing  &&  fgrid_main.Cols[fgrid_main.Col].AllowEditing)
					//				{
					//					menuitem_RateExchange.Visible = true;
					//					menuitem_DCExchange.Visible	  = true;
					//				}
					//				else
					//				{
					//					menuitem_RateExchange.Visible = false;
					//					menuitem_DCExchange.Visible	  = false;
					//				}

					C1.Win.C1FlexGrid.CellRange vSelectionRange = fgrid_main.Selection;

					int sct_rows = fgrid_main.Selection.r1;
					int sct_rows1 = fgrid_main.Selection.r2;
					int sct_cols = fgrid_main.Selection.c1;

					if(fgrid_main[sct_rows, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString() == "1")
					{
						if(vSelectionRange.c1 == (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_KRW || vSelectionRange.c1 == (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_USD)
						{
							menuitem_RateExchange.Visible = true;
							menuitem_DCExchange.Visible	  = true;
							this.cmenu_Adjust.Show(fgrid_main, new Point(e.X, e.Y));
						}
						else
						{
							menuitem_RateExchange.Visible = false;
							menuitem_DCExchange.Visible	  = false;
						}
					}


					if(fgrid_main[sct_rows, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxACCOUNT_STATUS].ToString() == "N" || fgrid_main[sct_rows, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxACCOUNT_STATUS].ToString() == "S")
					{
						menuItem1.Visible = true;
					}
					else
					{
						menuItem1.Visible = false;
					}
						
				}

				//하단 레벨이 선택되지 않는것 막기 
				if ((e.Button == MouseButtons.Left) &&
					fgrid_main[fgrid_main.Selection.r2,(int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString() =="1")
				{
	                
					for (int  i =fgrid_main.Selection.r2; i < fgrid_main.Rows.Count; i++)
					{
						if (fgrid_main[fgrid_main.Selection.r2,(int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxCUST_CD].ToString() ==
							fgrid_main[i,(int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxCUST_CD].ToString())
							fgrid_main.Rows[i].Selected  = true;
						else
							break;
					}
				}
			}
			catch
			{

			}

		
		}
		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}

		private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		  this.Tbtn_CancelAccountProcess();
		}

				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SaveProcess(true);
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

		private void Form_BI_Incoming_Vendor_Total_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
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

		private void btn_sum_Click(object sender, System.EventArgs e)
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
			{
				if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want Account Sum?", "Convert", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					Btn_SumClickedProcessing();
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
			txt_itemCd.Text		= _group_cd;
			txt_itemNm.Text		= _group_name;
			
			vPopup.Dispose();		
		}

		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (cmb_itemGroup.SelectedIndex >= 0 )
				this.btn_groupSearch.Enabled = true;
			else
				this.btn_groupSearch.Enabled = false;
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			DataTable vDt  = FlexPurchase.ClassLib.ComFunction.Select_Last_Date(dpick_from.Text.Replace("-",""));
			dpick_to.Value = ClassLib.ComFunction.StringToDateTime(vDt.Rows[0].ItemArray[0].ToString());

			// txt_rate insert Value
			vDt = ClassLib.ComFunction.Select_Cur_Rate(dpick_from.Text.Replace("-",""));
			txt_rate.Text		= vDt.Rows[0].ItemArray[0].ToString();

			vDt.Dispose();		

			if (!_initYn)
				this.ClosingCheckProcess(true); 			
		}

		private void ClosingCheckProcess(bool arg_check)
		{
			try
			{
				if (arg_check)
				{
					DataTable vDt = FlexPurchase.ClassLib.ComFunction.Select_Close_Yn(cmb_factory.SelectedValue.ToString(), 
																					  FlexPurchase.ClassLib.ComVar.Month, 
																					  dpick_from.Text.Replace("-","").Substring(0,6), 
																					  FlexPurchase.ClassLib.ComVar.Account);
				
					if ((vDt == null ) || (vDt.Rows.Count > 0))
						_vClosingYn = vDt.Rows[0][0].ToString(); 
					else
						_vClosingYn = "N";

					if (_vClosingYn == "Y")
					{
						ClassLib.ComFunction.User_Message("Already Closed Account At This Month.", "Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
					if (_vClosingYn == "Y")
					{
						btn_sum.Enabled				= false;
						fgrid_main.AllowEditing		= false;
						tbtn_Save.Enabled			= false;
						tbtn_Confirm.Enabled		= false;
					}
					else
					{
						_vSaveCount		= 0;
						_vCommitCount	= 0;
						_vConfCount		= 0;
				
						// Status 확인
						for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
						{
							if (fgrid_main[vRow, _lxAccountStatusCol] != null && fgrid_main[vRow, _lxAccountStatusCol].ToString() == "C")
							{
								_vCommitCount = _vCommitCount + 1; 
								fgrid_main.Rows[vRow].AllowEditing = false;

								if (fgrid_main[vRow, _lxAccountConfCol] != null && fgrid_main[vRow, _lxAccountConfCol].ToString() == "Y")
									_vConfCount = _vConfCount + 1; 
							}
							else 
							{
								_vSaveCount   = _vSaveCount + 1;
								fgrid_main.Rows[vRow].AllowEditing = true;
							}
						}

						if (_vConfCount > 0)
						{
							tbtn_Confirm.Enabled		= false;
							btn_sum.Enabled				= false;
							tbtn_Save.Enabled			= false;
							fgrid_main.AllowEditing		= false;
							_vConfirmYn					= true;
						}
						else
						{
							if (_vSaveCount > 0 && _vCommitCount > 0)
							{
								tbtn_Confirm.Enabled		= false;
								btn_sum.Enabled				= false;
								tbtn_Save.Enabled			= true;
							}
							else 
							{
								tbtn_Confirm.Enabled		= true;
								if ( _vCommitCount > 0 )
								{
									_vConfirmYn				= true;
									btn_sum.Enabled			= false;
									fgrid_main.AllowEditing = false;
									tbtn_Save.Enabled		= false;
								}
								else 
								{
									_vConfirmYn				= false;
									btn_sum.Enabled			= true;
									fgrid_main.AllowEditing = true;
									tbtn_Save.Enabled		= true;
								}
							}
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

		#endregion

		#region 공통 메서드

		#endregion

		#region 컨텍스트(팝업) 메뉴 이벤트

		private void cmenu_Adjust_Popup(object sender, System.EventArgs e)
		{
			try
			{
				// 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
				Set_MenuItem_Visible();
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
			int vRow = fgrid_main.Selection.r1;
			int vCol = fgrid_main.Selection.c1;
			
			if (fgrid_main.Cols[vCol].AllowEditing)
			{
				this.menuitem_DCExchange.Visible		= true;
				this.menuitem_RateExchange.Visible		= true;
			}
			else
			{
				this.menuitem_DCExchange.Visible		= false;
				this.menuitem_RateExchange.Visible		= false;
			}
		}
 

		private void menuitem_DCExchange_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				txt_dc.Text = "0";
				Pop_BI_Incoming_DCExchanger pop_changer = new Pop_BI_Incoming_DCExchanger(this);
				pop_changer.ShowDialog();
				
				if(decimal.Parse(txt_dc.Text) > 0)
				{
					Btn_DcChangeClickedProcessing();
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
				txt_rate.Text = "";
				Pop_BI_Incoming_Search_Rate pop_changer = new Pop_BI_Incoming_Search_Rate();

				pop_changer.ShowDialog();

				if (COM.ComVar.Parameter_PopUp != null)
				{
					txt_rate.Text	= COM.ComVar.Parameter_PopUp[0];

					if(decimal.Parse(txt_rate.Text) > 0)
					{

						Btn_RateChangeClickedProcessing();
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
			// Form init
			_initYn	= true;

            lbl_MainTitle.Text = "Incoming Closing";
            this.Text = lbl_MainTitle.Text;
            ClassLib.ComFunction.SetLangDic(this);

			// Grid setting
			fgrid_main.Set_Grid("SBI_IN_ADJUST_VENDOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
            _RowFixed = fgrid_main.Rows.Count;
			fgrid_main.Tree.Column = (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxFACTORY;


		

            
            DataTable vDt = null;
            //vDt = FlexPurchase.ClassLib.ComFunction.Select_Data_List(ClassLib.ComVar.This_Factory , "SBI06");
            vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBI06");
            COM.ComCtl.Set_ComboList(vDt, cmb_factory, 1, 1, false, false);
            cmb_factory.SelectedIndex = 0;
            vDt.Dispose();
           
			


			// pur_div set    cmb_purDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_purDiv, 1, 2, true, 56,0);
			cmb_purDiv.SelectedIndex = 0;

			// buy_div set    cmb_buyDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC01");
			COM.ComCtl.Set_ComboList(vDt, cmb_buyDiv, 1, 2, true, 56,0);
            cmb_buyDiv.SelectedIndex = 0;

			// cmb_user
			vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory);
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_user,1,2,(vDt.Rows.Count > 1) ? true : false);
			cmb_user.SelectedIndex = 0;
			vDt.Dispose();

			// Item Group Combobox Setting
			vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
			vDt.Dispose();

			// price yn set    cmb_priceYn
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SEM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_priceYn, 1, 2, true, 56,0);
			cmb_priceYn.SelectedIndex	= -1;

			// print type set    cmb_priceYn
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SEM34");
			COM.ComCtl.Set_ComboList(vDt, cmb_printType, 1, 2, false, 56,0);
			cmb_printType.SelectedIndex = 0;

			// txt_rate insert Value
			vDt = ClassLib.ComFunction.Select_Cur_Rate(dpick_to.Text.Replace("-",""));
			txt_rate.Text		= vDt.Rows[0].ItemArray[0].ToString();




			dpick_from.Value = ClassLib.ComFunction.StringToDateTime(dpick_from.Text.Replace("-","").Substring(0,6) + "01");

			vDt  = FlexPurchase.ClassLib.ComFunction.Select_Last_Date(dpick_from.Text.Replace("-",""));
			dpick_to.Value = ClassLib.ComFunction.StringToDateTime(vDt.Rows[0].ItemArray[0].ToString());

			// txt_rate insert Value
			vDt = ClassLib.ComFunction.Select_Cur_Rate(dpick_from.Text.Replace("-",""));
			txt_rate.Text		= vDt.Rows[0].ItemArray[0].ToString();
			vDt.Dispose();		

			// User define variable setting
			_fixedRow							= fgrid_main.Rows.Fixed;

			// Disabled tbutton
			tbtn_Delete.Enabled  = true;
			tbtn_Confirm.Enabled = false;
			tbtn_Create.Enabled  = false;
			btn_sum.Enabled		 = true; 

			// set up styles
			CellStyle s = fgrid_main.Styles[CellStyleEnum.Subtotal0];
			s.BackColor = ClassLib.ComVar.ClrLevel_1st;
			s.ForeColor = Color.Black;

			s = fgrid_main.Styles[CellStyleEnum.Subtotal1];
			s.BackColor = ClassLib.ComVar.ClrLevel_2nd;
			s.ForeColor = Color.Black;


            // Pur  Factory Combobox Setting		
            //vDt = ClassLib.ComFunction.Select_Data_List(ClassLib.ComVar.This_Factory, "SBI04");
            vDt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, "SBI04");
            COM.ComCtl.Set_ComboList(vDt, cmb_pur_factory, 1, 1, true, false);
            cmb_pur_factory.SelectedValue = _vCSC;
            vDt.Dispose();
			





	
			_initYn	= false; 

			// 자재 마감 여부 체크
			this.ClosingCheckProcess(true); 
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_main.ClearAll();
				this.cmb_buyDiv.SelectedIndex		= -1;
				this.cmb_factory.SelectedIndex		= -1;
				this.cmb_itemGroup.SelectedIndex	= -1;
				this.cmb_priceYn.SelectedIndex		= -1;
				this.cmb_printType.SelectedIndex	= -1;
				this.cmb_purDiv.SelectedIndex		= -1;
				this.cmb_user.SelectedIndex			= -1;
//				this.cmb_vendor.SelectedIndex		= -1;
				this.txt_vendorCode.Text			= "";	
				this.txt_itemCd.Text				= "";
				this.txt_itemNm.Text				= "";
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}


		private void  Tbtn_CancelAccountProcess()
	    {
			try
			{				
				
                string vMonth =dpick_from.Text.ToString();
				string vCustCd  = fgrid_main[fgrid_main.Selection.r1,(int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxCUST_CD].ToString();


                 //stest

				//Pop_BI_Incoming_CacnelAccout  vCacelAccount  = new Pop_BI_Incoming_CacnelAccout(vMonth,vCustCd);
				//vCacelAccount.ShowDialog();

				



				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Cancle Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}	


		private void Tbtn_SearchProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				fgrid_main.Select(fgrid_main.Selection.r1, fgrid_main.Selection.c1);

				string vInFrom  = this.dpick_from.Text.Replace("-","");
				string vInTo	= this.dpick_to.Text.Replace("-","");
				string vFactory	= this.cmb_factory.SelectedIndex > -1 ? this.cmb_factory.SelectedValue.ToString() : "";
				string vCustCd	= this.cmb_vendor.SelectedIndex  > -1 ? this.cmb_vendor.SelectedValue.ToString()  : "";
				string vUser	= this.cmb_user.SelectedIndex    > -1 ? this.cmb_user.SelectedValue.ToString()    : "";
				string vBuyDiv	= this.cmb_buyDiv.SelectedIndex  > -1 ? this.cmb_buyDiv.SelectedValue.ToString()  : "";
				string vPurDiv	= this.cmb_purDiv.SelectedIndex  > -1 ? this.cmb_purDiv.SelectedValue.ToString()  : "";
				string vPriceYn	= this.cmb_priceYn.SelectedIndex > -1 ? this.cmb_priceYn.SelectedValue.ToString() : "";
				string vGroupCd	= this.cmb_itemGroup.SelectedIndex > -1 ? this.cmb_itemGroup.SelectedValue.ToString() : "";
				string vItemCd	= this.txt_itemCd.Text;
				string vItemNm	= this.txt_itemNm.Text;

				DataTable vTemp = this.SELECT_SBI_IN_ADJUST_LIST(vFactory, vInFrom, vInTo,   vCustCd, vUser, vGroupCd, 
																 vItemCd,  vItemNm, vBuyDiv, vPurDiv, vPriceYn);

				fgrid_main.Rows.Count = _RowFixed;
				for(int i=0; i<vTemp.Rows.Count; i++)
				{
					int tree_level01 = int.Parse(vTemp.Rows[i].ItemArray[(int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString());
					fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, tree_level01);

					if(tree_level01 != 1)
					{
//						fgrid_main.Rows[fgrid_main.Rows.Count-1].StyleNew.BackColor = ClassLib.ComVar.ClrLightSel;
//						//fgrid_main.Rows[fgrid_main.Rows.Count-1].StyleNew.Font = new Font(fgrid_main.Font, FontStyle.Bold);
//						fgrid_main.Rows[fgrid_main.Rows.Count-1].StyleNew.ForeColor = Color.MediumSeaGreen;

						fgrid_main.Rows[fgrid_main.Rows.Count-1].StyleNew.BackColor = Color.FromArgb(247, 255, 187);
					}


					string account_status = vTemp.Rows[i].ItemArray[(int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxACCOUNT_STATUS].ToString();
					
					if(account_status == "C" || account_status == "A")
					{
						fgrid_main.Rows[fgrid_main.Rows.Count-1].StyleNew.BackColor = Color.FromArgb(245, 173, 173);
					}


					for(int j=0; j<vTemp.Columns.Count-1; j++)
					{
						fgrid_main[fgrid_main.Rows.Count-1, j] = vTemp.Rows[i].ItemArray[j].ToString();
					}
				}

				fgrid_main.Tree.Show(tree_level);

				fgrid_main.AutoSizeRows();
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

		private void Tbtn_PrintProcess()
		{
//			C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
//			System.Windows.Forms.TextBox[] txt_array = {}; 
//
//			if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
//			{
//				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Vendor_Total");
//
//				string sPara  = " /rp ";
//				sPara += "'" + COM.ComFunction.Param_Combo(cmb_factory, "%") +		"' ";
//				sPara += "'" + this.dpick_from.Text.Replace("-","") +		"' ";
//				sPara += "'" + this.dpick_to.Text.Replace("-","") +		"' ";
//				sPara += "'" + COM.ComFunction.Param_Combo(cmb_vendor, "%") +	"' ";
//				sPara += "'" + COM.ComFunction.Param_Combo(cmb_user, "%") +	"' ";
//				sPara += "'" + COM.ComFunction.Param_Combo(cmb_itemGroup, "%") +	"' ";
//				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemCd, "%") +	"' ";
//				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_itemNm, "%") +	"' ";
//				sPara += "'" + COM.ComFunction.Param_Combo(cmb_buyDiv, "%") +	"' ";
//				sPara += "'" + COM.ComFunction.Param_Combo(cmb_purDiv, "%") +	"' ";
//				sPara += "'" + COM.ComFunction.Param_Combo(cmb_priceYn, "%") +	"' ";
//				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
//
//				MyReport.Text = "Incoming Vendor Total sheet";
//				MyReport.Show();			
//			}


			COM.ComFunction comfunc = new COM.ComFunction();



			string sPara = "";
			string sDir  = "";




			string arg_factory = cmb_factory.SelectedValue.ToString();
			string arg_buydiv  = this.cmb_buyDiv.SelectedIndex  > -1 ? this.cmb_buyDiv.SelectedValue.ToString()  : "";
			string arg_cust_cd = txt_vendorCode.Text.Trim();
			string arg_puruser = cmb_user.SelectedValue.ToString();
			string arg_in_from = comfunc.ConvertDate2DbType(dpick_from.Text);
			string arg_in_to   = comfunc.ConvertDate2DbType(dpick_to.Text);
			string arg_loc_factory = ClassLib.ComVar.This_Factory;
			string arg_pur_factory = ClassLib.ComFunction.Empty_Combo(cmb_pur_factory," ");
			string arg_rate    = "";
			string arg_vendor_name = this.cmb_vendor.SelectedIndex  > -1 ? cmb_vendor.GetItemText(cmb_vendor.SelectedIndex, 1) : "ALL";
			string arg_username =  this.cmb_user.SelectedIndex    > -1 ? cmb_user.GetItemText(cmb_user.SelectedIndex, 1) : "ALL";

			sPara = "/rp [" + arg_factory + "] ";
			sPara += "[" + arg_buydiv + "]";
			sPara += "[" + arg_cust_cd + "]";
			sPara += "[" + arg_puruser + "]";
			sPara += "[" + arg_in_from + "]";
			sPara += "[" + arg_in_to + "]";
			sPara += "[" + arg_loc_factory + "]";
			sPara += "[" + arg_pur_factory + "]";
			sPara += "[" + arg_rate + "]";
			sPara += "[" + arg_vendor_name + "]";
			sPara += "[" + arg_username + "]";





			if(cmb_printType.SelectedIndex == 0)
			{
				sDir  = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Vendor_Total_AOS");




				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

				MyReport.Text = "Incoming Vendor Total sheet";
				MyReport.Show();
			}
			else if(cmb_printType.SelectedIndex == 1)
			{
				sDir  = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Vendor_Total_AOP");
				//sPara = "/rp [][][][][20061101][20061130][DS][][2006.][11]";

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

				MyReport.Text = "Incoming Vendor Total sheet";
				MyReport.Show();
			}
		}

		private void SubTotalProcess()
		{
			// more setup
			fgrid_main.SubtotalPosition = SubtotalPositionEnum.AboveData;								
			fgrid_main.AllowDragging	= AllowDraggingEnum.None;
			fgrid_main.Tree.Column		= 3;

			fgrid_main.Subtotal(AggregateEnum.Clear);
			for (int c = 6; c < fgrid_main.Cols.Count; c++)
			{
				if ( fgrid_main.Cols[c].Style.Name.ToString().StartsWith("NUMBER"))
				{
					fgrid_main.Subtotal(AggregateEnum.Sum, 0, -1, c, "Total");
//					fgrid_main.Subtotal(AggregateEnum.Sum, 1, _lxFactoryCol, c, "{0}");
				}
			}
		}

		private void Tbtn_SaveProcess(bool arg_bool)
		{
			try
			{				
				//item_name check하기
				for(int i = fgrid_main.Rows.Fixed ;  i<fgrid_main.Rows.Count     ; i++)
				{

					if ( (fgrid_main[i,(int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString() != "1")) 
						continue;
					else
					{
////						if  ((fgrid_main[i,(int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxITEM_NAME] == null)||
////							(fgrid_main[i,(int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxITEM_NAME].ToString().Length < 1))
////						{
////							ClassLib.ComFunction.User_Message("Material Name is not existed...Please check..", "Tbtn_SaveProcess",
////								MessageBoxButtons.OK, MessageBoxIcon.Error);
////							return;
////						}
////																								   

					}

				}


				if( fgrid_main.Rows.Count > 0 && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed ) 
				{
					DialogResult result = new DialogResult(); 

					if (arg_bool) 
					{	
						result = ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					}
					if ((!arg_bool) || result.ToString() == "Yes")
					{
						fgrid_main.Select(fgrid_main.Selection.r1, fgrid_main.Selection.c1); 
						this.Cursor = Cursors.WaitCursor;

						if (!MyOraDB.Save_FlexGird_Ready("PKG_SBI_IN_ADJUST_VENDOR.SAVE_SBI_ACCOUNT_HEAD", fgrid_main, true))
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}

						
						// 저장 완료
						if (MyOraDB.Exe_Modify_Procedure_all())
						{
							fgrid_main.Cols[0].Clear(C1.Win.C1FlexGrid.ClearFlags.Content);
							fgrid_tail.Cols[0].Clear(C1.Win.C1FlexGrid.ClearFlags.Content);
							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);

							this.Tbtn_SearchProcess();
						}
						else
							return;
					}
				}


				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);


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

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(_vConfirmYn) 
				this.Tbtn_ConfirmCancelProcess();
			else
				this.Tbtn_ConfirmProcess();
		}

		private void Tbtn_ConfirmProcess()
		{
			try
			{ 

				for(int i=_fixedRow; i<fgrid_main.Rows.Count; i++)
				{
					if(fgrid_main[i,  (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString() == "1"
						&& fgrid_main[i,  (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxACCOUNT_STATUS].ToString() == "S")
					{
						decimal head_krw_amount = decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_KRW].ToString());
						decimal head_krw_vat    = decimal.Parse(fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxVAT_KRW].ToString());
						decimal head_krw_sum = head_krw_amount + head_krw_vat;
						decimal tail_krw_sum = 0;

						if(head_krw_sum > 0)
						{
							decimal tail_krw_amount = 0;
							decimal tail_krw_vat    = 0;
							for(int j=i+1; j<fgrid_main.Rows.Count; j++)
							{
								if(fgrid_main[j,  (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString() == "1")
								{
									break;
								}

								tail_krw_amount += decimal.Parse(fgrid_main[j, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_KRW].ToString());
								tail_krw_vat += decimal.Parse(fgrid_main[j, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxVAT_KRW].ToString());
							}
							tail_krw_sum = tail_krw_amount + tail_krw_vat;

							if(head_krw_sum == tail_krw_sum)
							{
								fgrid_main[i, 0]		= "C"; 		
							}
						} 
					}
				}

				Tbtn_SaveProcess(false);





			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}


	

		private void Tbtn_ConfirmCancelProcess()
		{
			try
			{ 
				if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you Cancel to Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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
						if (fgrid_main[vRow, _lxItemCdCol] != null && fgrid_main[vRow, _lxItemCdCol].ToString() != "")
						{
							fgrid_main[vRow, _lxAccountStatusCol]	= "S"; 
							fgrid_main[vRow, 0]		= "C"; 	
						}
					}	

					Tbtn_SaveProcess(false); 
					this.EnableControlCheckProcess(true);	// Control Enable Check

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					ClassLib.ComFunction.User_Message("Completed Comfirm", "MgsEndSave", MessageBoxButtons.OK, MessageBoxIcon.Information);
					

				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}

		// DESC 수정 창 OPEN
		private void Grid_DoubleClickProcess()
		{
			int vRow = fgrid_main.Selection.r1;
			int vCol = fgrid_main.Selection.c1;

			if (vCol == _lxAdjustDescCol )
			{
				try
				{
					string vFactLoc		= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lxFactLocCol]);
					string vCustYm		= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lxCustYmCol]);
					string vCustCd		= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lxCustCdCol]);
					string vCustName	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lxCustNameCol]);
					string vBuyDiv		= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lxBuyDivCol]);
					string vBuyName		= ClassLib.ComFunction.NullToBlank(fgrid_main.GetDataDisplay(vRow, _lxBuyDivCol));
					string vAdjustUsd	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lxAdjustUsdCol]);
					string vAdjustKrw	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lxAdjustKrwCol]);
					string vVatKrw		= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lxVatKrwCol]);
					string vPurUser		= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lxPurUserCol]);
					string vAdjustDesc	= ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _lxAdjustDescCol]);
					
					
					COM.ComVar.Parameter_PopUp		= new string[11];
					COM.ComVar.Parameter_PopUp[0]	= vFactLoc;
					COM.ComVar.Parameter_PopUp[1]	= vCustYm;
					COM.ComVar.Parameter_PopUp[2]	= vCustCd;
					COM.ComVar.Parameter_PopUp[3]	= vCustName;
					COM.ComVar.Parameter_PopUp[4]	= vBuyDiv;
					COM.ComVar.Parameter_PopUp[5]	= vBuyName;
					COM.ComVar.Parameter_PopUp[6]	= vAdjustUsd;
					COM.ComVar.Parameter_PopUp[7]	= vAdjustKrw;
					COM.ComVar.Parameter_PopUp[8]	= vVatKrw;
					COM.ComVar.Parameter_PopUp[9]	= vPurUser;
					COM.ComVar.Parameter_PopUp[10]	= vAdjustDesc;
					//fgrid_main.Selection.Clear(C1.Win.C1FlexGrid.ClearFlags.All);

					Pop_BI_Incoming_Adjust_Desc pop_desc = new Pop_BI_Incoming_Adjust_Desc(this, vRow);
					pop_desc.ShowDialog();

					fgrid_main.AutoSizeRows();

//					DataTable vTemp = this.SELECT_SBI_ACCOUNT_DESC(	COM.ComVar.Parameter_PopUp[0],
//																	COM.ComVar.Parameter_PopUp[2],
//																	COM.ComVar.Parameter_PopUp[1],
//																	COM.ComVar.Parameter_PopUp[4], 
//																	COM.ComVar.Parameter_PopUp[9]);
//					if (vTemp.Rows.Count > 0)
//					{
//						fgrid_main[vRow, _lxAdjustDescCol]		= vTemp.Rows[0].ItemArray[0].ToString();
//						fgrid_main[vRow, _lxAdjustUsdCol]		= vTemp.Rows[0].ItemArray[1].ToString();
//						fgrid_main[vRow, _lxAdjustKrwCol]		= vTemp.Rows[0].ItemArray[2].ToString();
//					}
					
					//pop_desc.Dispose();
					//fgrid_main.Selection.Clear(C1.Win.C1FlexGrid.ClearFlags.All);
					_bPopChk = true;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void Grid_AfterEditProcess()
		{
			if(!_bPopChk)
			{
				if (fgrid_main.Buffer_CellData != fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString())
					fgrid_main[fgrid_main.Row, 0]  =  ClassLib.ComVar.Update;
			}
			_bPopChk = false;
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
			{
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
			}
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

		// 자재 데이타를 기본으로 회계데이타를 생성한다.
		// Material USD -> Amount USD, Adjust USD
		// Material KRW -> Amoutn KRW, Adjust KRW
		// Material KRW * 0.1 -> Tax 
		private void Btn_SumClickedProcessing()
		{
			try
			{
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

				for (int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++ )
				{
					//if(fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxACCOUNT_STATUS].ToString() != "N")
					if(fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxACCOUNT_STATUS].ToString() != "C")  //Confirm이 아니면 재계산가능하게 처리 
					{
						fgrid_main[i, 0]  =  ClassLib.ComVar.Insert;
						decimal vCurPrice =  decimal.Parse(ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxCurPriceCol])) ;
						decimal vRate	  =  decimal.Parse("0.1");
						decimal vTax	  =  decimal.Multiply(vCurPrice, vRate);
						fgrid_main[i, _lxAdjustUsdCol]	= ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxUsdPriceCol]);
						fgrid_main[i, _lxAdjustKrwCol]	= ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxCurPriceCol]);
						fgrid_main[i, _lxAmountUsdCol]	= ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxUsdPriceCol]);
						fgrid_main[i, _lxAmountKrwCol]	= ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxCurPriceCol]);
						 
						fgrid_main[i, _lxAdjustDescCol] = "";
						if(fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxBUY_DIV].ToString() == "1")
						fgrid_main[i, _lxVatKrwCol]		= Math.Floor((double)(vTax));	  
					}
				}

//				for (int j = fgrid_tail.Rows.Fixed; j < fgrid_tail.Rows.Count; j++)
//				{
//					fgrid_tail[j, 0]	= ClassLib.ComVar.Insert;
//				}

//				this.Tbtn_SaveProcess(true);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}

		// USD 금액을 입력받은 환율로 곱하여 현지화폐(KRW)금액에 합해준다.
		// USD 금액은 그대로 보여준다.
		private void Btn_RateChangeClickedProcessing()
		{
			try
			{
				decimal vTotalKRW  = 0, vCnt  = 0;
                int vChildCnt = 0;

				C1.Win.C1FlexGrid.CellRange vSelectionRange = fgrid_main.Selection;
				int sRow = vSelectionRange.r1;
				int sRow2 = vSelectionRange.r2;


				if(sRow == sRow2)
				{
					int old_level = int.Parse(fgrid_main[sRow, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString());
					int new_level = 0;
					for(int k=sRow+1; k<fgrid_main.Rows.Count; k++)
					{
						new_level = int.Parse(fgrid_main[k, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString());

						if(old_level == new_level)
						{
							sRow2 = k-1;
							break;
						}
					}
				}

				for (int i = _RowFixed ; i < fgrid_main.Rows.Count ; i++)
				{
					if(fgrid_main.Rows[i].Selected)
					{
						if(fgrid_main[i, 0].ToString() != "I")
						{
							fgrid_main[i, 0]	 =  ClassLib.ComVar.Update;
						}
						decimal vCurPrice	 =  decimal.Parse(ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxAdjustKrwCol])) ;
						decimal vUsdPrice	 =  decimal.Parse(ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxAdjustUsdCol])) ;
						decimal vRate		 =  decimal.Parse(txt_rate.Text);
						decimal vRateAmt	 =  vCurPrice + decimal.Multiply(vUsdPrice, vRate);

						vRateAmt             = decimal.Parse(vRateAmt.ToString().Split(".".ToCharArray())[0]);

                        decimal vNewCurPrice =  decimal.Truncate(vCurPrice + vRateAmt);
						string  vDesc		 = ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxAdjustDescCol]).Trim();
						string remarks       = fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxBUY_DIV].ToString();

                        vDesc = (vDesc.Trim().Length > 0) ? vDesc + "\r\n" : vDesc;						


						string V_vur_price = ""; 
						if(vCurPrice > 0)
							V_vur_price = vCurPrice + " + ";
                        vDesc = vDesc + V_vur_price + "($" + string.Format("{0:###,###,###.00}", vUsdPrice) + "* @" + vRate.ToString("###,###") + ") = " + string.Format("{0:###,###,###}", Math.Ceiling((decimal)((vUsdPrice * vRate) + vCurPrice)));
                        

                        

                       
						fgrid_main[i, _lxAdjustUsdCol]		= vUsdPrice.ToString();
                        fgrid_main[i, _lxAdjustKrwCol] =    decimal.Truncate((vUsdPrice*vRate) + vCurPrice); //Math.Ceiling((decimal)((vUsdPrice * vRate) + vCurPrice)); 
                        
				    
						
						#region  공장별 단가 맞추기 
						if (fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString()  == "1")
						{
							vTotalKRW  =  0; vCnt  =  0;
                            vTotalKRW = decimal.Truncate((vUsdPrice * vRate) + vCurPrice);  //Math.Ceiling((decimal)((vUsdPrice * vRate) + vCurPrice));
                            vChildCnt = fgrid_main.Rows[i].Node.Children;
						}
						else
						{
                            
                            if  (vCnt  == vChildCnt)
                                fgrid_main[i, _lxAdjustKrwCol] = vTotalKRW;
                            else
                            {
                                fgrid_main[i, _lxAdjustKrwCol] = decimal.Truncate((vUsdPrice * vRate) + vCurPrice); //Math.Ceiling((double)((vUsdPrice * vRate) + vCurPrice)); 
                                vTotalKRW -= decimal.Truncate((vUsdPrice * vRate) + vCurPrice);  //Math.Ceiling((decimal)((vUsdPrice * vRate) + vCurPrice)); 
                            }
                          
						}
							 

                    

						#endregion

						// 부가세 계산
						if(remarks == "1")
						{					
							if (vNewCurPrice>0)     
							{
								decimal vRateVat  =  decimal.Parse("0.1");
								decimal vTax	  =  decimal.Multiply(vNewCurPrice, vRateVat);								
								fgrid_main[i, _lxVatKrwCol]		=decimal.Truncate(vTax);
							}

							fgrid_main[i, _lxAdjustDescCol]		= vDesc.Trim();
						
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// 입력한 DC값을 USD, KRW에 반영한다.
		// Adjust_USD = Amount_USD - (Amount_USD * DC/100)
		// Adjust_KRW = Amount_KRW - (Amount_KRW * DC/100)
		// 내역을  DESC 반영
		private void Btn_DcChangeClickedProcessing()
		{
			try
			{
				//
				C1.Win.C1FlexGrid.CellRange vSelectionRange = fgrid_main.Selection;
				int sRow = vSelectionRange.r1;
				int sRow2 = vSelectionRange.r2;

				if(sRow == sRow2)
				{
					int old_level = int.Parse(fgrid_main[sRow, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString());
					int new_level = 0;
					for(int k=sRow+1; k<fgrid_main.Rows.Count; k++)
					{
						new_level = int.Parse(fgrid_main[k, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString());

						if(old_level == new_level)
						{
							sRow2 = k-1;
							break;
						}
					}
				}



				for (int i = _RowFixed ; i < fgrid_main.Rows.Count ; i++)
				{
					if(fgrid_main.Rows[i].Selected)
					{
						//MessageBox.Show(fgrid_main[i, vSelectionRange.c1].ToString());
						if(fgrid_main[i, 0].ToString() != "I")
						{
							fgrid_main[i, 0]	 =  ClassLib.ComVar.Update;
						}
						decimal vCurPrice		=  decimal.Parse(ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxAdjustKrwCol])) ;
						decimal vUsdPrice		=  decimal.Parse(ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxAdjustUsdCol])) ;
						decimal vRate			=  decimal.Parse(txt_dc.Text);
						decimal vCurDcAmt		=  decimal.Divide(decimal.Multiply(vCurPrice, vRate),100);
						decimal vUsdDcAmt		=  decimal.Divide(decimal.Multiply(vUsdPrice, vRate),100);
						decimal vNewCurPrice	=  decimal.Round(vCurPrice - vCurDcAmt,0);
						decimal vNewUsdPrice	=  decimal.Round(vUsdPrice - vUsdDcAmt,2);
						string  vDesc			=  ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxAdjustDescCol]).Trim();




                        vDesc = (vDesc.Trim().Length > 0) ? vDesc + "\r\n" : vDesc;

						if(vSelectionRange.c1 == (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_USD)
						{
                            vDesc += "$" + string.Format("{0:###,###,###.00}", vUsdPrice) + " * " + vRate + "% = $" + string.Format("{0:###,###,###.00}", vUsdDcAmt) + "(" + vRate + "% DC)";
							vDesc += "\r\n";
                            vDesc += "$" + string.Format("{0:###,###,###.00}", vUsdPrice) + " - $" + string.Format("{0:###,###,###.00}", vUsdDcAmt) + " = $" + string.Format("{0:###,###,###.00}", Math.Round(vUsdPrice - vUsdDcAmt, 2));
							fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_USD] = Math.Round(vUsdPrice - vUsdDcAmt,2).ToString();
						}
						else if(vSelectionRange.c1 == (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_KRW)
						{
                            vDesc += "W" + string.Format("{0:###,###,###}", vCurPrice) + " * " + vRate + "% = " + string.Format("{0:###,###,###}", vCurDcAmt) + "(" + vRate + "% DC)";
							vDesc += "\r\n";
                            vDesc += "W" + string.Format("{0:###,###,###}", vCurPrice) + " - " + string.Format("{0:###,###,###}", vCurDcAmt) + " = " + string.Format("{0:###,###,###}", Math.Round(vCurPrice - vCurDcAmt, 0));
							fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_KRW] = Math.Round(vCurPrice - vCurDcAmt,0).ToString();
						
						}

                       // vDesc = vDesc + V_vur_price + "($" + string.Format("{0:###,###,###.00}", vUsdPrice) + "* @" + vRate.ToString("###,###") + ") = " + string.Format("{0:###,###,###}", Math.Ceiling((double)((vUsdPrice * vRate) + vCurPrice)));

						fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxADJUST_DESC] = vDesc;


						if ( vNewCurPrice > 0) 
						{
							decimal vRateVat  =  decimal.Parse("0.1");
							decimal vTax	  =  decimal.Multiply(vNewCurPrice, vRateVat);
							fgrid_main[i, _lxVatKrwCol]		= Math.Floor((double)(vTax));	
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBI_IN_ADJUST_VENDOR : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_style_cd">스타일코드</param>
		/// <param name="arg_gender">젠더</param>
		/// <param name="arg_dev">Dev</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_IN_ADJUST_LIST(string arg_Factory, string arg_InFrom,  string arg_InTo, 
												   string arg_CustCd,  string arg_User,    string arg_GroupCd,
												   string arg_ItemCd,  string arg_ItemNm,  string arg_BuyDiv,  
												   string arg_PurDiv,  string arg_PriceYn)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(14);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST_VENDOR.SELECT_SBI_VENDOR_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_IN_TO";
			MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[4] = "ARG_USER";
			MyOraDB.Parameter_Name[5] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[7] = "ARG_ITEM_NM";
			MyOraDB.Parameter_Name[8] = "ARG_BUY_DIV";
			MyOraDB.Parameter_Name[9] = "ARG_PUR_DIV";
			MyOraDB.Parameter_Name[10]= "ARG_PRICE_YN";
			MyOraDB.Parameter_Name[11]= "ARG_LOC_FACTORY";
			MyOraDB.Parameter_Name[12]= "ARG_PUR_FACTORY";
			MyOraDB.Parameter_Name[13]= "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[10]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[12]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[13]= (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_Factory;
			MyOraDB.Parameter_Values[1] = arg_InFrom;
			MyOraDB.Parameter_Values[2] = arg_InTo;
			MyOraDB.Parameter_Values[3] = arg_CustCd;
			MyOraDB.Parameter_Values[4] = arg_User;
			MyOraDB.Parameter_Values[5] = arg_GroupCd;
			MyOraDB.Parameter_Values[6] = arg_ItemCd;
			MyOraDB.Parameter_Values[7] = arg_ItemNm;
			MyOraDB.Parameter_Values[8] = arg_BuyDiv;
			MyOraDB.Parameter_Values[9] = arg_PurDiv;
			MyOraDB.Parameter_Values[10]= arg_PriceYn;
			MyOraDB.Parameter_Values[11]= ClassLib.ComVar.This_Factory;
			MyOraDB.Parameter_Values[12]= ClassLib.ComFunction.Empty_Combo(cmb_pur_factory," ");
			MyOraDB.Parameter_Values[13]= "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBI_IN_ADJUST_VENDOR : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_style_cd">스타일코드</param>
		/// <param name="arg_gender">젠더</param>
		/// <param name="arg_dev">Dev</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_ACCOUNT_TAIL(string arg_Factory, string arg_InFrom,  string arg_InTo, 
												 string arg_CustCd,  string arg_User,    string arg_GroupCd,
												 string arg_ItemCd,  string arg_ItemNm,  string arg_BuyDiv,  
												 string arg_PurDiv,  string arg_PriceYn)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(12);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_ACCOUNT_TAIL.SELECT_SBI_ACCOUNT_TAIL";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_IN_TO";
			MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[4] = "ARG_USER";
			MyOraDB.Parameter_Name[5] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[7] = "ARG_ITEM_NM";
			MyOraDB.Parameter_Name[8] = "ARG_BUY_DIV";
			MyOraDB.Parameter_Name[9] = "ARG_PUR_DIV";
			MyOraDB.Parameter_Name[10]= "ARG_PRICE_YN";
			MyOraDB.Parameter_Name[11]= "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[10]= (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11]= (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_Factory;
			MyOraDB.Parameter_Values[1] = arg_InFrom;
			MyOraDB.Parameter_Values[2] = arg_InTo;
			MyOraDB.Parameter_Values[3] = arg_CustCd;
			MyOraDB.Parameter_Values[4] = arg_User;
			MyOraDB.Parameter_Values[5] = arg_GroupCd;
			MyOraDB.Parameter_Values[6] = arg_ItemCd;
			MyOraDB.Parameter_Values[7] = arg_ItemNm;
			MyOraDB.Parameter_Values[8] = arg_BuyDiv;
			MyOraDB.Parameter_Values[9] = arg_PurDiv;
			MyOraDB.Parameter_Values[10]= arg_PriceYn;
			MyOraDB.Parameter_Values[11]= "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBI_IN_ADJUST_VENDOR : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_style_cd">스타일코드</param>
		/// <param name="arg_gender">젠더</param>
		/// <param name="arg_dev">Dev</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_ACCOUNT_DESC(string arg_factLoc, string arg_custCd, string arg_custYm, string arg_buyDiv, string arg_purUser)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST_VENDOR.SELECT_SBI_ACCOUNT_DESC";
															 
			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACT_LOC";
			MyOraDB.Parameter_Name[1] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[2] = "ARG_CUST_YM";
			MyOraDB.Parameter_Name[3] = "ARG_BUY_DIV";
			MyOraDB.Parameter_Name[4] = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factLoc;
			MyOraDB.Parameter_Values[1] = arg_custCd;
			MyOraDB.Parameter_Values[2] = arg_custYm;
			MyOraDB.Parameter_Values[3] = arg_buyDiv;
			MyOraDB.Parameter_Values[4] = arg_purUser;
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion																								

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			tree_level = 1;
			fgrid_main.Tree.Show(tree_level);
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			tree_level = 2;
			fgrid_main.Tree.Show(tree_level);
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			int sct_rows = fgrid_main.Selection.r1;
			int sct_rows2 = fgrid_main.Selection.r1+1;
			int sct_cols = fgrid_main.Selection.c1;



			if(fgrid_main[sct_rows, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString() == "1")
			{
				for(int i=sct_rows+1; i<fgrid_main.Rows.Count; i++)
				{
					sct_rows2 = i;
					if(fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxTREE_LEVEL].ToString() == "1")
					{
						break;
					}
				}
			}

			for (int i = _RowFixed ; i < fgrid_main.Rows.Count ; i++)
			{
				if(fgrid_main.Rows[i].Selected)
				{
					string edit_mode = fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxACCOUNT_STATUS].ToString();
					if(edit_mode == "N" || edit_mode == "S")
					{

						if(edit_mode == "S")fgrid_main[i, 0]  =  ClassLib.ComVar.Update;
						fgrid_main[i, 0]  =  ClassLib.ComVar.Insert;

						decimal vCurPrice =  decimal.Parse(ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxCurPriceCol])) ;
						decimal vRate	  =  decimal.Parse("0.1");
						decimal vTax	  =  decimal.Multiply(vCurPrice, vRate);
						fgrid_main[i, _lxAdjustUsdCol]	= ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxUsdPriceCol]);
						fgrid_main[i, _lxAdjustKrwCol]	= ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxCurPriceCol]);
						fgrid_main[i, _lxAmountUsdCol]	= ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxUsdPriceCol]);
						fgrid_main[i, _lxAmountKrwCol]	= ClassLib.ComFunction.NullToBlank(fgrid_main[i, _lxCurPriceCol]);	   
						fgrid_main[i, _lxAdjustDescCol] = "";

						if(fgrid_main[i, (int)ClassLib.TBSBI_IN_ADJUST_VENDOR.IxBUY_DIV].ToString() == "1")
							fgrid_main[i, _lxVatKrwCol]		= Math.Floor((double)(vTax));	 
					}
				}
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			for(int i=_RowFixed; i<fgrid_main.Rows.Count; i++)
			{
				fgrid_main[i, _lxAdjustDescCol] = "aaaaa";
			}
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			for(int i=_RowFixed; i<fgrid_main.Rows.Count; i++)
			{
				if(fgrid_main.Rows[i].Selected)
				{
					fgrid_main.Delete_Row(i);
				}
			}
		}

		

	}
}

