using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.Threading;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;

namespace FlexPurchase.Quality
{
	public class Pop_QC_Shipping_List : COM.PCHWinForm.Pop_Large
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuItem menuitem_SelectAll;
		private System.Windows.Forms.MenuItem menuitem_DeSelectAll;
		private System.Windows.Forms.ContextMenu cmenu_Barcode;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label lbl_shipDate;
		private System.Windows.Forms.Label lbl_vendor;
        private System.Windows.Forms.TextBox txt_vendorCode;
		private System.Windows.Forms.Label btn_colorSearch;
		private System.Windows.Forms.Label btn_itemSearch;
		private System.Windows.Forms.Label lbl_color;
		private System.Windows.Forms.TextBox txt_colorNm;
		private System.Windows.Forms.TextBox txt_colorCd;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.TextBox txt_itemNm;
		private System.Windows.Forms.TextBox txt_itemCd;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView _mainSheet;
		private System.Windows.Forms.Label lbl_inspQty;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txt_defQty;
		private System.Windows.Forms.TextBox txt_inspQty;
		private System.Windows.Forms.Label btn_batch;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_sum;
		private System.Windows.Forms.TextBox txt_sum;
		private Form_QC_Request qc_request = null;
		private string vendor_code = null;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private bool _isAccessible = true;
		private FlexPurchase.Search.Pop_BW_QE_Wait _waitPop	= new FlexPurchase.Search.Pop_BW_QE_Wait();

		//메인창으로 리턴될 데이터 테이블
		public DataTable _DT;  

		private int _ldLev				= (int)ClassLib.TBSQL_LAB_REQUEST.IxLEV -1; 
		private int _ldFactoryCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxFACTORY -1; 
		private int _ldItemCdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxITEM_CD -1; 
		private int _ldItemNameCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxITEM_NAME -1;
		private int _ldSpecCdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSPEC_CD -1;
		private int _ldSpecNameCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSPEC_NAME -1;
		private int _ldColorCdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxCOLOR_CD -1; 
		private int _ldColorNameCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxCOLOR_NAME -1; 
		private int _ldUnitCol			= (int)ClassLib.TBSQL_LAB_REQUEST.IxUNIT -1;
		private int _ldCustCdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxCUST_CD -1;
		private int _ldCustNameCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxCUST_NAME -1;
		private int _ldStyleCdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSTYLE_CD -1;
		private int _ldStyleNameCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSTYLE_NAME -1;
		private int _ldReqQtyCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxREQ_QTY -1;
		private int _ldDefQtyCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxDEF_QTY -1;
		private int _ldDefTypeCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxDEF_TYPE -1;
		private int _ldShipNoCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSHIP_NO -1;
		private int _ldShipSeqCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSHIP_SEQ -1;
		private int _ldShipYmdCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxSHIP_YMD -1;
		private int _ldPurUserCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxPUR_USER -1;
		private int _ldLotNoCol			= (int)ClassLib.TBSQL_LAB_REQUEST.IxLOT_NO -1;
		private int _ldLotSeqCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxLOT_SEQ -1;
		private int _ldObsTypeCol		= (int)ClassLib.TBSQL_LAB_REQUEST.IxOBS_TYPE -1;

		private int _lxChkCol			= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxCHK;
		private int _lxShipNoCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSHIP_NO;
		private int _lxShipSeqCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSHIP_SEQ;
		private int _lxShipYmdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSHIP_YMD;
		private int _lxObsTypeCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxOBS_TYPE;
		private int _lxItemCdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxITEM_CD;
		private int _lxItemNameCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxITEM_NAME;
		private int _lxSpecCdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSPEC_CD;
		private int _lxSpecNameCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSPEC_NAME;
		private int _lxColorCdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxCOLOR_CD;
		private int _lxColorNameCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxCOLOR_NAME;
		private int _lxUnitCol			= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxUNIT;
		private int _lxReqQtyCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxREQ_QTY;
		private int _lxRemainQtyCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxREMAIN_QTY;
		private int _lxRequestRepCol	= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxREQUEST_REP;
		private int _lxStyleNameCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSTYLE_NAME;
		private int _lxStyleCdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSTYLE_CD;
		private int _lxLotNoCol			= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxLOT_NO;
		private int _lxLotSeqCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxLOT_SEQ;
		private int _lxCustCdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxCUST_CD;
		private int _lxCustNameCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxCUST_NAME;
		private int _lxPurUserCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxPUR_USER;
		private int _lxReqNoCol			= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxREQ_NO;
		private int _lxReqSeqCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxREQ_SEQ;
		private int _lxReqYmdCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxREQ_YMD;
		private int _lxStatusCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxSTATUS;
		private int _lxUpdUserCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxUPD_USER;
		private int _lxAttributeCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxUPD_USER;
		private int _lxRequestReasonCol	= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxUPD_YMD;
        private int _lxRemarksCol = (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxREMARKS;
        private C1.Win.C1List.C1Combo cmb_defType;
        private C1.Win.C1List.C1Combo cmb_vendor;
		private int _lxInspQtyCol		= (int)ClassLib.TBSQL_LAB_REQ_SHIP.IxINSP_QTY;
		
		#endregion
		
		#region 생성자 / 소멸자
		public Pop_QC_Shipping_List()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		public Pop_QC_Shipping_List(Form_QC_Request arg_from, string arg_vendor_code)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			qc_request = arg_from;
			vendor_code = arg_vendor_code;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_QC_Shipping_List));
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
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
            this.spd_main = new COM.SSP();
            this.cmenu_Barcode = new System.Windows.Forms.ContextMenu();
            this.menuitem_SelectAll = new System.Windows.Forms.MenuItem();
            this.menuitem_DeSelectAll = new System.Windows.Forms.MenuItem();
            this._mainSheet = new FarPoint.Win.Spread.SheetView();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_inspQty = new System.Windows.Forms.Label();
            this.txt_defQty = new System.Windows.Forms.TextBox();
            this.txt_inspQty = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_colorSearch = new System.Windows.Forms.Label();
            this.txt_colorNm = new System.Windows.Forms.TextBox();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.btn_batch = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.btn_itemSearch = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.txt_colorCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.cmb_defType = new C1.Win.C1List.C1Combo();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainSheet)).BeginInit();
            this.pnl_menu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_defType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
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
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink7});
            this.c1ToolBar1.Location = new System.Drawing.Point(665, 4);
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
            this.c1CommandHolder1.Commands.Add(this.tbtn_Conform);
            // 
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Location = new System.Drawing.Point(64, 24);
            this.lbl_MainTitle.Size = new System.Drawing.Size(888, 23);
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
            // tbtn_Conform
            // 
            this.tbtn_Conform.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Conform_Click);
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
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.GridDefinition = "17.7165354330709:False:True;70.2755905511811:False:False;8.85826771653543:False:T" +
                "rue;\t0.421052631578947:False:True;97.4736842105263:False:False;0.421052631578947" +
                ":False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(950, 508);
            this.c1Sizer1.TabIndex = 25;
            this.c1Sizer1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.ContextMenu = this.cmenu_Barcode;
            this.spd_main.Font = new System.Drawing.Font("굴림", 9F);
            this.spd_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.spd_main.Location = new System.Drawing.Point(12, 98);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this._mainSheet);
            this.spd_main.Size = new System.Drawing.Size(926, 357);
            this.spd_main.TabIndex = 0;
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.Change += new FarPoint.Win.Spread.ChangeEventHandler(this.spd_main_Change);
            this.spd_main.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_ButtonClicked);
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
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_menu.Controls.Add(this.label2);
            this.pnl_menu.Controls.Add(this.label1);
            this.pnl_menu.Controls.Add(this.lbl_inspQty);
            this.pnl_menu.Controls.Add(this.txt_defQty);
            this.pnl_menu.Controls.Add(this.txt_inspQty);
            this.pnl_menu.Controls.Add(this.btn_close);
            this.pnl_menu.Controls.Add(this.btn_apply);
            this.pnl_menu.Controls.Add(this.groupBox2);
            this.pnl_menu.Location = new System.Drawing.Point(12, 459);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(934, 45);
            this.pnl_menu.TabIndex = 174;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(168, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 552;
            this.label2.Text = "Deffective Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(424, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 551;
            this.label1.Text = "Deffective Qty";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_inspQty
            // 
            this.lbl_inspQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inspQty.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inspQty.ImageIndex = 0;
            this.lbl_inspQty.ImageList = this.img_Label;
            this.lbl_inspQty.Location = new System.Drawing.Point(8, 14);
            this.lbl_inspQty.Name = "lbl_inspQty";
            this.lbl_inspQty.Size = new System.Drawing.Size(100, 21);
            this.lbl_inspQty.TabIndex = 548;
            this.lbl_inspQty.Text = "Inspection Qty";
            this.lbl_inspQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_defQty
            // 
            this.txt_defQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_defQty.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_defQty.Location = new System.Drawing.Point(526, 14);
            this.txt_defQty.MaxLength = 10;
            this.txt_defQty.Name = "txt_defQty";
            this.txt_defQty.Size = new System.Drawing.Size(51, 21);
            this.txt_defQty.TabIndex = 550;
            // 
            // txt_inspQty
            // 
            this.txt_inspQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_inspQty.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_inspQty.Location = new System.Drawing.Point(109, 14);
            this.txt_inspQty.MaxLength = 10;
            this.txt_inspQty.Name = "txt_inspQty";
            this.txt_inspQty.Size = new System.Drawing.Size(51, 21);
            this.txt_inspQty.TabIndex = 549;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(846, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(80, 23);
            this.btn_close.TabIndex = 547;
            this.btn_close.Text = "Cancel";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseDown);
            this.btn_close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseUp);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(765, 12);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(80, 23);
            this.btn_apply.TabIndex = 546;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseDown);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_defType);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 42);
            this.groupBox2.TabIndex = 175;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_shipDate);
            this.panel1.Controls.Add(this.lblexcep_mark);
            this.panel1.Controls.Add(this.dpick_to);
            this.panel1.Controls.Add(this.dpick_from);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 90);
            this.panel1.TabIndex = 169;
            // 
            // lbl_shipDate
            // 
            this.lbl_shipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipDate.ImageIndex = 1;
            this.lbl_shipDate.ImageList = this.img_Label;
            this.lbl_shipDate.Location = new System.Drawing.Point(6, 35);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 52;
            this.lbl_shipDate.Text = "Ship Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(213, 38);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(8, 16);
            this.lblexcep_mark.TabIndex = 178;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(228, 35);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 5;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(107, 35);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 4;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmb_vendor);
            this.groupBox1.Controls.Add(this.btn_colorSearch);
            this.groupBox1.Controls.Add(this.txt_colorNm);
            this.groupBox1.Controls.Add(this.lbl_sum);
            this.groupBox1.Controls.Add(this.txt_sum);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.lbl_factory);
            this.groupBox1.Controls.Add(this.btn_batch);
            this.groupBox1.Controls.Add(this.lbl_vendor);
            this.groupBox1.Controls.Add(this.txt_vendorCode);
            this.groupBox1.Controls.Add(this.btn_itemSearch);
            this.groupBox1.Controls.Add(this.lbl_color);
            this.groupBox1.Controls.Add(this.txt_colorCd);
            this.groupBox1.Controls.Add(this.lbl_item);
            this.groupBox1.Controls.Add(this.txt_itemNm);
            this.groupBox1.Controls.Add(this.txt_itemCd);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 84);
            this.groupBox1.TabIndex = 381;
            this.groupBox1.TabStop = false;
            // 
            // btn_colorSearch
            // 
            this.btn_colorSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_colorSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_colorSearch.ImageIndex = 27;
            this.btn_colorSearch.ImageList = this.img_SmallButton;
            this.btn_colorSearch.Location = new System.Drawing.Point(659, 34);
            this.btn_colorSearch.Name = "btn_colorSearch";
            this.btn_colorSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_colorSearch.TabIndex = 433;
            this.btn_colorSearch.Tag = "Search";
            this.btn_colorSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_colorSearch.Click += new System.EventHandler(this.btn_colorSearch_Click);
            // 
            // txt_colorNm
            // 
            this.txt_colorNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_colorNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_colorNm.Location = new System.Drawing.Point(518, 35);
            this.txt_colorNm.MaxLength = 10;
            this.txt_colorNm.Name = "txt_colorNm";
            this.txt_colorNm.Size = new System.Drawing.Size(140, 21);
            this.txt_colorNm.TabIndex = 432;
            // 
            // lbl_sum
            // 
            this.lbl_sum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_sum.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sum.ImageIndex = 0;
            this.lbl_sum.ImageList = this.img_Label;
            this.lbl_sum.Location = new System.Drawing.Point(336, 57);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(100, 21);
            this.lbl_sum.TabIndex = 437;
            this.lbl_sum.Text = "Summary";
            this.lbl_sum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sum
            // 
            this.txt_sum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sum.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_sum.Location = new System.Drawing.Point(438, 57);
            this.txt_sum.MaxLength = 10;
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(79, 21);
            this.txt_sum.TabIndex = 438;
            this.txt_sum.Text = "0";
            this.txt_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
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
            this.cmb_factory.HeadingStyle = style20;
            this.cmb_factory.HighLightRowStyle = style21;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(107, 12);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style22;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style23;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style24;
            this.cmb_factory.TabIndex = 436;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(6, 12);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 435;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_batch
            // 
            this.btn_batch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_batch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_batch.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_batch.ImageIndex = 0;
            this.btn_batch.ImageList = this.img_Button;
            this.btn_batch.Location = new System.Drawing.Point(832, 55);
            this.btn_batch.Name = "btn_batch";
            this.btn_batch.Size = new System.Drawing.Size(80, 23);
            this.btn_batch.TabIndex = 434;
            this.btn_batch.Text = "Copy";
            this.btn_batch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_batch.Click += new System.EventHandler(this.btn_batch_Click);
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 1;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(6, 57);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 425;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(107, 57);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 423;
            this.txt_vendorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vendorCode_KeyPress);
            // 
            // btn_itemSearch
            // 
            this.btn_itemSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_itemSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemSearch.ImageIndex = 27;
            this.btn_itemSearch.ImageList = this.img_SmallButton;
            this.btn_itemSearch.Location = new System.Drawing.Point(659, 11);
            this.btn_itemSearch.Name = "btn_itemSearch";
            this.btn_itemSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_itemSearch.TabIndex = 426;
            this.btn_itemSearch.Tag = "Search";
            this.btn_itemSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_itemSearch.Click += new System.EventHandler(this.btn_itemSearch_Click);
            // 
            // lbl_color
            // 
            this.lbl_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_color.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.ImageIndex = 0;
            this.lbl_color.ImageList = this.img_Label;
            this.lbl_color.Location = new System.Drawing.Point(336, 35);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(100, 21);
            this.lbl_color.TabIndex = 430;
            this.lbl_color.Text = "Color";
            this.lbl_color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_colorCd
            // 
            this.txt_colorCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_colorCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_colorCd.Location = new System.Drawing.Point(438, 35);
            this.txt_colorCd.MaxLength = 10;
            this.txt_colorCd.Name = "txt_colorCd";
            this.txt_colorCd.Size = new System.Drawing.Size(79, 21);
            this.txt_colorCd.TabIndex = 431;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(336, 12);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 427;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(518, 12);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(140, 21);
            this.txt_itemNm.TabIndex = 429;
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(438, 12);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(79, 21);
            this.txt_itemCd.TabIndex = 428;
            // 
            // cmb_defType
            // 
            this.cmb_defType.AddItemSeparator = ';';
            this.cmb_defType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_defType.Caption = "";
            this.cmb_defType.CaptionHeight = 17;
            this.cmb_defType.CaptionStyle = style1;
            this.cmb_defType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_defType.ColumnCaptionHeight = 18;
            this.cmb_defType.ColumnFooterHeight = 18;
            this.cmb_defType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_defType.ContentHeight = 16;
            this.cmb_defType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_defType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_defType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_defType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_defType.EditorHeight = 16;
            this.cmb_defType.EvenRowStyle = style2;
            this.cmb_defType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_defType.FooterStyle = style3;
            this.cmb_defType.HeadingStyle = style4;
            this.cmb_defType.HighLightRowStyle = style5;
            this.cmb_defType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_defType.Images"))));
            this.cmb_defType.ItemHeight = 15;
            this.cmb_defType.Location = new System.Drawing.Point(269, 15);
            this.cmb_defType.MatchEntryTimeout = ((long)(2000));
            this.cmb_defType.MaxDropDownItems = ((short)(5));
            this.cmb_defType.MaxLength = 32767;
            this.cmb_defType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_defType.Name = "cmb_defType";
            this.cmb_defType.OddRowStyle = style6;
            this.cmb_defType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_defType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_defType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_defType.SelectedStyle = style7;
            this.cmb_defType.Size = new System.Drawing.Size(140, 20);
            this.cmb_defType.Style = style8;
            this.cmb_defType.TabIndex = 437;
            this.cmb_defType.PropBag = resources.GetString("cmb_defType.PropBag");
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style9;
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
            this.cmb_vendor.EvenRowStyle = style10;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style11;
            this.cmb_vendor.HeadingStyle = style12;
            this.cmb_vendor.HighLightRowStyle = style13;
            this.cmb_vendor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_vendor.Images"))));
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(187, 58);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style14;
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style15;
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style16;
            this.cmb_vendor.TabIndex = 439;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            // 
            // Pop_QC_Shipping_List
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(952, 566);
            this.Controls.Add(this.c1Sizer1);
            this.MaximizeBox = true;
            this.Name = "Pop_QC_Shipping_List";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainSheet)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_defType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{
			this.Grid_EditModeOnProcess(spd_main) ;
//			SummaryProcessing(); 
		}		

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			this.spd_main.Update_Row(img_Action);
		}

		private void spd_main_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
			int vRow = _mainSheet.ActiveRowIndex ;
			int vCol = _mainSheet.ActiveColumnIndex ;

			if(vCol == _lxChkCol)  
			{ 
				decimal vSum	= decimal.Parse(txt_sum.Text); 

				if((bool)_mainSheet.Cells[vRow, vCol].Value)
				{
					vSum	= vSum + decimal.Parse(_mainSheet.Cells[vRow, _lxReqQtyCol].Value.ToString()); 
				}
				else
				{
					vSum	= vSum - decimal.Parse(_mainSheet.Cells[vRow, _lxReqQtyCol].Value.ToString()); 
				}

				txt_sum.Text	= vSum.ToString(); 
			}
		}

		private void spd_main_Change(object sender, FarPoint.Win.Spread.ChangeEventArgs e)
		{
		
		}

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
			txt_sum.Text = "0";
			decimal vSum = 0; 
			for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
			{
				spd_main.ActiveSheet.Cells[i, _lxChkCol].Value = true;
				vSum = vSum + decimal.Parse(_mainSheet.Cells[i, _lxReqQtyCol].Value.ToString()); 
			}

			txt_sum.Text = vSum.ToString();
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

			txt_sum.Text = "0";
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
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();							
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}

		private void tbtn_Conform_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			printExcel();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			if (_mainSheet.Rows.Count > 0)
			{
				this.Create_DataTable();
				this.Return_Data();
			}
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			_DT	= null;	
			this.Close();
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

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			//string vCurDate	= dpick_from.Text.Replace("-","");
			//DataTable dt = Select_get_date(vCurDate);

			//dpick_from.Value = ClassLib.ComFunction.StringToDateTime(dt.Rows[0].ItemArray[0].ToString());
			//dpick_to.Value	= dpick_from.Value.AddDays(6);
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

		private void btn_batch_Click(object sender, System.EventArgs e)
		{
			Tbtn_batchClickProcess();
		}

		private void Tbtn_batchClickProcess()
		{
			try
			{
				// LAB Test Date Select PopUp Show
				FlexPurchase.Outgoing.Pop_BO_Outgoing_RealYmd_Exchanger vPopup = new FlexPurchase.Outgoing.Pop_BO_Outgoing_RealYmd_Exchanger();
			
				COM.ComVar.Parameter_PopUp		= new string[2];

				COM.ComVar.Parameter_PopUp[0]	= "Select LAB Test Date";
				COM.ComVar.Parameter_PopUp[1]	= "Lab Test Ymd";

				vPopup.ShowDialog();

				if(COM.ComVar.Parameter_PopUp[0] == null || COM.ComVar.Parameter_PopUp[0].ToString() == "") return;
				
				string vLabYmd	= COM.ComVar.Parameter_PopUp[0].ToString();

				vPopup.Dispose();
				
				string vRequestRep_pre	=  ""; 
				string vRequestRep_cur	=  ""; 
				string vReqNo			= "";
				int	   vReqSeq			= 0;

				string vFactory		= ClassLib.ComVar.This_Factory;
				string vDocDivision = ClassLib.ComVar.QC_REQUEST;
				string vDocType		= "00";
				string vDate		= System.DateTime.Today.ToString().Substring(0,10).Replace("-","");
				string vUser		= COM.ComVar.This_User;


				for ( int i = 0; i < _mainSheet.Rows.Count; i++)
				{
					if ((_mainSheet.Cells[i, _lxReqNoCol] == null || _mainSheet.Cells[i, _lxReqNoCol].Value.ToString() == "")
						&& (_mainSheet.Cells[i, _lxRemainQtyCol] != null 
						&& _mainSheet.Cells[i, _lxRemainQtyCol].Value.ToString() != ""
						&& decimal.Parse(_mainSheet.Cells[i, _lxRemainQtyCol].Value.ToString()) > 0))
					{
						vRequestRep_cur		= _mainSheet.Cells[i, _lxRequestRepCol].Value.ToString(); 

						if (vReqNo == "" || vRequestRep_cur	!= vRequestRep_pre)
						{
							// ReqNo Select 
							DataTable vDt = ClassLib.ComFunction.SELECT_DOCUMENT_NO(vFactory, vDocDivision, vDocType, vDate, vUser);

							vReqNo = vDt.Rows[0].ItemArray[0].ToString();
							vReqSeq	= 0; 
						}

						_mainSheet.Cells[i, 0].Tag = ClassLib.ComVar.Insert; 
						_mainSheet.Cells[i, _lxReqNoCol].Value		= vReqNo; 
						_mainSheet.Cells[i, _lxReqSeqCol].Value		= vReqSeq +1; 
						_mainSheet.Cells[i, _lxReqYmdCol].Value		= vLabYmd; 
						_mainSheet.Cells[i, _lxRemarksCol].Value	= "Batch Input"; 
						_mainSheet.Cells[i, _lxStatusCol].Value		= "C"; 
						_mainSheet.Cells[i, _lxUpdUserCol].Value	= COM.ComVar.This_User; 

						vRequestRep_pre		= _mainSheet.Cells[i, _lxRequestRepCol].Value.ToString(); 
						vReqSeq	+= 1; 

						_mainSheet.Rows[i].BackColor = Color.Gold; 
					}
				}
										 
				if (MyOraDB.Save_Spread("PKG_SQL_LAB_REQUEST.SAVE_SQL_LAB_REQUEST_BATCH", spd_main))
				{
					Tbtn_AfterSaveProcess();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Tbtn_AfterSaveProcess()
		{
			try
			{				
				for(int i = _mainSheet.Rows.Count - 1; i >= 0; i--)
				{
					if(_mainSheet.Cells[i,0].Tag == null || _mainSheet.Cells[i, 0].Tag.ToString() == "") continue; 
							
					if(_mainSheet.Cells[i, 0].Tag.ToString() == "D")
					{ 
						_mainSheet.Rows.Remove(i,1);
					}
					else
					{
						_mainSheet.ClearRange(i, 0, 1, 1, false);
					}
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


		private void SummaryProcessing()
		{
			try
			{
				int vRow = _mainSheet.ActiveRowIndex ;

				decimal vSum	= decimal.Parse(txt_sum.Text); 
				if (_mainSheet.Cells[vRow, _lxChkCol].Value.ToString() == "False")
				{
					vSum	= vSum + decimal.Parse(_mainSheet.Cells[vRow, _lxReqQtyCol].Value.ToString()); 
				}
				else if (_mainSheet.Cells[vRow, _lxChkCol].Value.ToString() == "True")
				{
					vSum	= vSum - decimal.Parse(_mainSheet.Cells[vRow, _lxReqQtyCol].Value.ToString()); 
				}

				txt_sum.Text	= vSum.ToString(); 
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

		#region 입력이동

		#endregion

		#region 버튼효과

		#endregion

		#region 롤오버 이미지 처리
		private void btn_apply_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_apply.ImageIndex = 1;
		}

		private void btn_apply_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_apply.ImageIndex = 0;
		}

		private void btn_close_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_close.ImageIndex = 1;
		}

		private void btn_close_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_close.ImageIndex = 0;
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
            // ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Shipping List";
            this.Text = "Shipping List";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SQL_LAB_REQ_SHIP", "4", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

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

			string vCurDate	= dpick_from.Text.Replace("-","");
			DataTable dt = Select_get_date(vCurDate);

			dpick_from.Value = ClassLib.ComFunction.StringToDateTime(dt.Rows[0].ItemArray[0].ToString());
			dpick_to.Value	= dpick_from.Value.AddDays(6);
			
			// Deffetive Type set    cmb_defType
			DataTable vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SQC02");
			COM.ComCtl.Set_ComboList(vDt, cmb_defType, 1, 2, true, 56,0);
			cmb_defType.SelectedIndex = -1;
			vDt.Dispose(); 
			
			// Factory Combobox Setting
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			// cmb_factory.SelectedIndex = 0;
			cmb_factory.SelectedValue = "DS";//(Factiry 고정)ClassLib.ComVar.This_Factory;
			cmb_factory.Enabled = false;
		 


			// Disabled tbutton
			tbtn_Save.Enabled		= false;
			tbtn_Delete.Enabled		= false;
			tbtn_Conform.Enabled	= false;
			tbtn_Create.Enabled		= false;
			
			txt_vendorCode.Text  = COM.ComVar.Parameter_PopUp[1].ToString();			 
			if (txt_vendorCode.Text != "")
			{
				Txt_VendorCodeTextChangedProcess();
				this.Tbtn_SearchProcess();
			}

		}

		/// <summary>
		/// Set_Return_DataTable : 메인창으로 리턴될 데이터 테이블 Setting
		/// </summary>
		private void Create_DataTable()
		{
			// LEV	FACTORY	REQ_NO	REQ_SEQ	REQ_YMD	ITEM_CD	ITEM_NAME	SPEC_CD	SPEC_NAME	COLOR_CD	COLOR_NAME	
			// UNIT	REQ_QTY	CUST_DIR_QTY	DEF_QTY	DEF_TYPE	RESULT	STYLE_CD	STYLE_NAME	CUST_CD	CUST_NAME	
			// SHIP_NO	SHIP_SEQ	SHIP_YMD	PUR_USER	LOT_NO	LOT_SEQ	OBS_TYPE	STATUS	UPD_USER	UPD_YMD

			DataColumn[] cols = new DataColumn[]{
													new DataColumn("LEV"),
													new DataColumn("FACTORY"),
													new DataColumn("REQ_NO"),
													new DataColumn("REQ_SEQ", Type.GetType("System.Decimal")),
													new DataColumn("REQ_YMD"),
													new DataColumn("ITEM_CD"),
													new DataColumn("ITEM_NAME"),
													new DataColumn("SPEC_CD"),
													new DataColumn("SPEC_NAME"),
													new DataColumn("COLOR_CD"),
													new DataColumn("COLOR_NAME"),
													new DataColumn("UNIT"),
													new DataColumn("REQ_QTY", Type.GetType("System.Decimal")),
													new DataColumn("CUST_DIR_QTY", Type.GetType("System.Decimal")),
													new DataColumn("DEF_QTY", Type.GetType("System.Decimal")),
													new DataColumn("DEF_TYPE"),
													new DataColumn("RESULT"),
													new DataColumn("STYLE_CD"),
													new DataColumn("STYLE_NAME"),
													new DataColumn("CUST_CD"),
													new DataColumn("CUST_NAME"),
													new DataColumn("SHIP_NO"),
													new DataColumn("SHIP_SEQ"),
													new DataColumn("SHIP_YMD"),
													new DataColumn("PUR_USER"),
													new DataColumn("LOT_NO"),
													new DataColumn("LOT_SEQ"),
													new DataColumn("OBS_TYPE"),
													new DataColumn("STATUS"),
													new DataColumn("UPD_USER"),
													new DataColumn("UPD_YMD", Type.GetType("System.DateTime"))
			};

			_DT = new DataTable("TEMP");
			_DT.Columns.AddRange(cols);
			
			//_DT  = SELECT_SQL_LAB_REQUEST_LIST();
			//_DT.Clear(); 
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

						// 같은 item 끼리 Merge
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

						string	vItemCd		= ""; 
						string	vSpecCd		= "";
						string	vColorCd	= "";
						decimal vRemainQty	= 0;

						string	vItemCd_1		= ""; 
						string	vSpecCd_1		= "";
						string	vColorCd_1		= "";
						decimal vRemainQty_1	= 0;
						decimal vReqQty_1		= 0;


						for ( int i = 0; i < _mainSheet.Rows.Count; i++)
						{
							// 실루엣, SS 구분 표시
							if (_mainSheet.Cells[i, _lxStatusCol].Text.Equals("S"))
							{
								_mainSheet.Cells[i, _lxUnitCol, i, _mainSheet.ColumnCount - 1].ForeColor = Color.Violet;
							}
							else if (_mainSheet.Cells[i, _lxAttributeCol].Text.Equals("S"))
							{
								_mainSheet.Cells[i, _lxUnitCol, i, _mainSheet.ColumnCount - 1].ForeColor = Color.DeepPink;
							}
							else if (_mainSheet.Cells[i, _lxAttributeCol].Text.Equals("R"))
							{
								_mainSheet.Cells[i, _lxUnitCol, i, _mainSheet.ColumnCount - 1].ForeColor = Color.DeepSkyBlue;
							}
							else if (_mainSheet.Cells[i, _lxRequestReasonCol].Text.Equals("50"))
							{
								_mainSheet.Cells[i, _lxUnitCol, i, _mainSheet.ColumnCount - 1].ForeColor = Color.LimeGreen;
							}
							else
							{
								_mainSheet.Cells[i, _lxUnitCol, i, _mainSheet.ColumnCount - 1].ForeColor = Color.Black;
							}

							_mainSheet.Rows[i].BackColor = Color.White; 
							if (_mainSheet.Cells[i, _lxReqNoCol].Value.ToString() != "")
							{
								_mainSheet.Rows[i].BackColor = Color.Gold; 
							}
							else
							{
								if (_mainSheet.Cells[i, _lxRemainQtyCol] != null && _mainSheet.Cells[i, _lxRemainQtyCol].Value.ToString() != ""
									&& decimal.Parse(_mainSheet.Cells[i, _lxRemainQtyCol].Value.ToString()) > 0)
								{
									vItemCd_1		= _mainSheet.Cells[i, _lxItemCdCol].Value.ToString(); 
									vSpecCd_1		= _mainSheet.Cells[i, _lxSpecCdCol].Value.ToString(); 
									vColorCd_1		= _mainSheet.Cells[i, _lxColorCdCol].Value.ToString(); 
									vRemainQty_1	= decimal.Parse(_mainSheet.Cells[i, _lxRemainQtyCol].Value.ToString()); 
									vReqQty_1		= decimal.Parse(_mainSheet.Cells[i, _lxReqQtyCol].Value.ToString()); 

									if (vItemCd == "" && vSpecCd == "" && vColorCd == "")
									{
										if (vRemainQty_1 >= vReqQty_1)	// Remain 수량이 요구수량보다 작으면 Remain 수량만큼만 검사의뢰
											_mainSheet.Cells[i, _lxInspQtyCol].Value	= vReqQty_1; 
										else
											_mainSheet.Cells[i, _lxInspQtyCol].Value	= vRemainQty_1;  

										vItemCd		= _mainSheet.Cells[i, _lxItemCdCol].Value.ToString(); 
										vSpecCd		= _mainSheet.Cells[i, _lxSpecCdCol].Value.ToString(); 
										vColorCd	= _mainSheet.Cells[i, _lxColorCdCol].Value.ToString(); 
										vRemainQty	= vRemainQty_1 - vReqQty_1; 
									}
									else if (vItemCd == vItemCd_1 && vSpecCd == vSpecCd_1 && vColorCd == vColorCd_1)
									{
										_mainSheet.Cells[i, _lxRemainQtyCol].Value	= vRemainQty.ToString(); 

										if (vRemainQty >= vReqQty_1)	// Remain 수량이 요구수량보다 작으면 Remain 수량만큼만 검사의뢰
											_mainSheet.Cells[i, _lxInspQtyCol].Value	= vReqQty_1; 
										else
											_mainSheet.Cells[i, _lxInspQtyCol].Value	= vRemainQty;  

										vItemCd		= _mainSheet.Cells[i, _lxItemCdCol].Value.ToString(); 
										vSpecCd		= _mainSheet.Cells[i, _lxSpecCdCol].Value.ToString(); 
										vColorCd	= _mainSheet.Cells[i, _lxColorCdCol].Value.ToString(); 
										vRemainQty	= vRemainQty - vReqQty_1; 
									}
									else
									{
										vItemCd		= ""; 
										vSpecCd		= ""; 
										vColorCd	= ""; 
										vRemainQty	= 0; 
									}
								}
								else
								{
									vItemCd		= ""; 
									vSpecCd		= ""; 
									vColorCd	= ""; 
									vRemainQty	= 0; 
								}
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

		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = arg_grid.Sheets[0].ActiveRowIndex ;
			int vCol = arg_grid.Sheets[0].ActiveColumnIndex ;
			
			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString() ;
			if (vTemp == "CheckBoxCellType" )
			{
				arg_grid.Buffer_CellData = "000" ;
			}
		}

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
		
		#endregion

		#region Return DataTable 관련 메서드

		
		/// <summary>
		/// Select Bacode Data Return
		/// </summary>
		private void Return_Data()
		{
			try
			{
				Make_DT(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Return_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Make_DT_Component : 
		/// </summary>
		private void Make_DT()
		{
			try
			{
				CellRange[] vSelectionRange = _mainSheet.GetSelections(); 

//				for (int i = 0 ; i < vSelectionRange.Length; i++)
//				{
//					int start_row = vSelectionRange[i].Row;
//					int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;
//
//					for (int j = start_row ; j < end_row; j++)
//					{
//						spd_main.ActiveSheet.Cells[j, _lxChkCol].Value = true;
//					}
//				}		  

				DataRow datarow = null; 
				int vFlag = 0;
		 
				for(int i = 0; i < this.spd_main.ActiveSheet.RowCount; i++)
				{ 
					bool vBool	=	this.spd_main.ActiveSheet.Cells[i, _lxChkCol].Value.ToString() == "True" ? true : false;
					if (vBool)
					{					
						vFlag = 0; //(첵크 안함!!)Etc_DataDuplicateCheck(i);

						if (vFlag == 0)
						{
							datarow = _DT.NewRow();

							datarow[_ldLev]				= "2";
							datarow[_ldFactoryCol]		= COM.ComFunction.Empty_Combo(cmb_factory, "ALL") == " " ? "ALL" : COM.ComFunction.Empty_Combo(cmb_factory, "ALL");
							datarow[_ldItemCdCol]		= spd_main.ActiveSheet.Cells[i, _lxItemCdCol].Value.ToString();
							datarow[_ldItemNameCol]		= spd_main.ActiveSheet.Cells[i, _lxItemNameCol].Value.ToString();
							datarow[_ldSpecCdCol]		= spd_main.ActiveSheet.Cells[i, _lxSpecCdCol].Value.ToString();
							datarow[_ldSpecNameCol]		= spd_main.ActiveSheet.Cells[i, _lxSpecNameCol].Value.ToString();
							datarow[_ldColorCdCol]		= spd_main.ActiveSheet.Cells[i, _lxColorCdCol].Value.ToString();
							datarow[_ldColorNameCol]	= spd_main.ActiveSheet.Cells[i, _lxColorNameCol].Value.ToString();
							datarow[_ldUnitCol]			= spd_main.ActiveSheet.Cells[i, _lxUnitCol].Value.ToString();
							datarow[_ldCustCdCol]		= spd_main.ActiveSheet.Cells[i, _lxCustCdCol].Value.ToString();
							datarow[_ldCustNameCol]		= spd_main.ActiveSheet.Cells[i, _lxCustNameCol].Value.ToString();
							datarow[_ldStyleCdCol]		= spd_main.ActiveSheet.Cells[i, _lxStyleCdCol].Value.ToString();
							datarow[_ldStyleNameCol]	= spd_main.ActiveSheet.Cells[i, _lxStyleNameCol].Value.ToString();
							datarow[_ldShipNoCol]		= spd_main.ActiveSheet.Cells[i, _lxShipNoCol].Value.ToString();
							datarow[_ldShipSeqCol]		= spd_main.ActiveSheet.Cells[i, _lxShipSeqCol].Value.ToString();
							datarow[_ldShipYmdCol]		= spd_main.ActiveSheet.Cells[i, _lxShipYmdCol].Value.ToString();
							datarow[_ldPurUserCol]		= spd_main.ActiveSheet.Cells[i, _lxPurUserCol].Value.ToString();
							datarow[_ldLotNoCol]		= spd_main.ActiveSheet.Cells[i, _lxLotNoCol].Value.ToString();
							datarow[_ldLotSeqCol]		= spd_main.ActiveSheet.Cells[i, _lxLotSeqCol].Value.ToString();
							datarow[_ldObsTypeCol]		= spd_main.ActiveSheet.Cells[i, _lxObsTypeCol].Value.ToString();
							datarow[_ldReqQtyCol]		= spd_main.ActiveSheet.Cells[i, _lxReqQtyCol].Value;


							if (txt_inspQty.Text != "")
							{
								if(qc_request != null)
								{
									qc_request.inspQty = COM.ComFunction.Empty_TextBox(txt_inspQty, "");
								}
							}

							datarow[_ldDefTypeCol]			= COM.ComFunction.Empty_Combo(cmb_defType, ""); 

							if (txt_defQty.Text != "")
								datarow[_ldDefQtyCol]			= decimal.Parse(COM.ComFunction.Empty_TextBox(txt_defQty, ""));
										
							_DT.Rows.Add(datarow); 
						}
						else if (vFlag == -1)
						{
							_DT = null;
							_mainSheet.Cells[i, _lxChkCol].Value = true;
							break;
						}
					}
				}


				if (_DT != null && _DT.Rows.Count > 0 )
				{	
					datarow = _DT.NewRow();
		
					datarow[_ldLev]				= "1";
					datarow[_ldFactoryCol]		= COM.ComFunction.Empty_Combo(cmb_factory, "ALL") == " " ? "ALL" : COM.ComFunction.Empty_Combo(cmb_factory, "ALL");
					datarow[_ldItemCdCol]		= _DT.Rows[0].ItemArray[_ldItemCdCol];
					datarow[_ldItemNameCol]		= _DT.Rows[0].ItemArray[_ldItemNameCol];
					datarow[_ldSpecCdCol]		= _DT.Rows[0].ItemArray[_ldSpecCdCol];
					datarow[_ldSpecNameCol]		= _DT.Rows[0].ItemArray[_ldSpecNameCol];
					datarow[_ldColorCdCol]		= _DT.Rows[0].ItemArray[_ldColorCdCol];
					datarow[_ldColorNameCol]	= _DT.Rows[0].ItemArray[_ldColorNameCol];
					datarow[_ldUnitCol]			= _DT.Rows[0].ItemArray[_ldUnitCol];
					datarow[_ldCustCdCol]		= _DT.Rows[0].ItemArray[_ldCustCdCol];
					datarow[_ldCustNameCol]		= _DT.Rows[0].ItemArray[_ldCustNameCol];
					datarow[_ldStyleCdCol]		= _DT.Rows[0].ItemArray[_ldStyleCdCol];
					datarow[_ldStyleNameCol]	= _DT.Rows[0].ItemArray[_ldStyleNameCol];
					datarow[_ldShipNoCol]		= _DT.Rows[0].ItemArray[_ldShipNoCol];
					datarow[_ldShipSeqCol]		= _DT.Rows[0].ItemArray[_ldShipSeqCol];
					datarow[_ldShipYmdCol]		= _DT.Rows[0].ItemArray[_ldShipYmdCol];
					datarow[_ldPurUserCol]		= _DT.Rows[0].ItemArray[_ldPurUserCol];
					datarow[_ldLotNoCol]		= _DT.Rows[0].ItemArray[_ldLotNoCol];
					datarow[_ldLotSeqCol]		= _DT.Rows[0].ItemArray[_ldLotSeqCol];
					datarow[_ldObsTypeCol]		= _DT.Rows[0].ItemArray[_ldObsTypeCol];
					datarow[_ldDefTypeCol]		= _DT.Rows[0].ItemArray[_ldDefTypeCol];
					datarow[_ldReqQtyCol]		= _DT.Compute("SUM(REQ_QTY)", "");
					datarow[_ldDefQtyCol]		= _DT.Compute("SUM(DEF_QTY)", "");

					_DT.Rows.Add(datarow); 
				}
				if (vFlag != -1)
				{
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Return_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 				
		
		}

		private int Etc_DataDuplicateCheck(int arg_row)
		{
			int vReturn = 0;
			
			if (_DT.Rows.Count > 0)
			{
				if (( _DT.Rows[0].ItemArray[_ldItemCdCol].ToString().Trim()  != spd_main.ActiveSheet.Cells[arg_row, _lxItemCdCol].Value.ToString().Trim() )
					/*|| ( _DT.Rows[0].ItemArray[_ldSpecCdCol].ToString().Trim()  != spd_main.ActiveSheet.Cells[arg_row, _lxSpecCdCol].Value.ToString().Trim() )
					|| ( _DT.Rows[0].ItemArray[_ldColorCdCol].ToString().Trim() != spd_main.ActiveSheet.Cells[arg_row, _lxColorCdCol].Value.ToString().Trim() )*/)
				{
					int vRow = arg_row + 1; 
					string vMessage = "The selected item is different Material. \r\n" +
						"Select at the Same Material, Please. \r\n\r\n" +
						"Choose process.. \r\n\r\n" +
						"[OK] : deselect current item \r\n" +
						"[Cancel] : process abort \r\n\r\n" +
						"Row Number : " + vRow + "\r\n" + 
						"Item : " + _DT.Rows[0].ItemArray[_ldItemNameCol].ToString() + "\t";
						//"  Spec : " + _DT.Rows[0].ItemArray[_ldSpecNameCol].ToString() +
						//"  Color : "+ _DT.Rows[0].ItemArray[_ldColorNameCol].ToString() + "\t";

					_mainSheet.Cells[arg_row, _lxChkCol].Value = true;
					switch (MessageBox.Show(this, vMessage, "Different Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
					{
						case DialogResult.OK:
							_mainSheet.Cells[arg_row, _lxChkCol].Value = false;
							vReturn = 1;
							break;

						case DialogResult.Cancel:
							vReturn = -1;
							break;
					}
				}
				else
				{
					vReturn = 0;
				}
			}
			return vReturn;
		}

		private void printExcel()
		{
			this.Cursor = Cursors.WaitCursor;

			Excel.Application oXL;
			Excel._Workbook oWB;
			Excel._Worksheet oSheet;
			
			try
			{
				Thread thread = new Thread(new ThreadStart(_waitPop.Start));
				thread.Start();
				
				//Start Excel and get Application object.
				oXL = new Excel.Application();
				
				oXL.Visible = false;
				oXL.UserControl = false;

				//Get a new workbook.
				oWB = (Excel._Workbook)(oXL.Workbooks.Add(true));
				oSheet = (Excel._Worksheet)oWB.ActiveSheet;

				object[,] values = new object[spd_main.ActiveSheet.Rows.Count + 2, spd_main.ActiveSheet.Columns.Count];

				// head
				for (int vRow = 0, rIdx = 0 ; vRow < spd_main.ActiveSheet.ColumnHeader.Rows.Count ; vRow++)
				{
					for (int vCol = 2, cIdx = 0 ; vCol < spd_main.ActiveSheet.Columns.Count ; vCol++)
					{
						if (spd_main.ActiveSheet.Columns[vCol].Visible)
						{
							values[rIdx, cIdx] = spd_main.ActiveSheet.ColumnHeader.Cells[vRow, vCol];
							cIdx++;
						}
					}
					
					rIdx++;
				}

				// data
				for (int vRow = 0, rIdx = 1 ; vRow < spd_main.ActiveSheet.Rows.Count ; vRow++)
				{
					for (int vCol = 2, cIdx = 0 ; vCol < spd_main.ActiveSheet.Columns.Count ; vCol++)
					{
						if (spd_main.ActiveSheet.Columns[vCol].Visible)
						{
							values[rIdx, cIdx] = spd_main.ActiveSheet.Cells[vRow, vCol];
							cIdx++;
						}
					}
					
					rIdx++;
				}

				int rowCount = spd_main.ActiveSheet.RowCount + spd_main.ActiveSheet.ColumnHeader.RowCount;
				int colCount = spd_main.ActiveSheet.ColumnCount + 1;

				oSheet.get_Range(oSheet.Cells[1, 1], oSheet.Cells[rowCount + 1, colCount + 1]).NumberFormat = "@";
				oSheet.get_Range(oSheet.Cells[1, 1], oSheet.Cells[rowCount + 1, colCount + 1]).Value2 = values;

				oXL.Visible = true;
				oXL.UserControl = true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				oSheet = null;
				oWB = null;
				oXL = null;
				GC.Collect();
				_waitPop.Hide();
			}
		}
		
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
			MyOraDB.Process_Name = "PKG_SQL_LAB_REQUEST_TEMP.SELECT_SQL_SHIP_LIST_NEW";

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
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
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

		/// <summary>
		/// PKG_SBO_OUT_TAIL : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBO_OUT_TAIL : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SQL_LAB_REQUEST_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SQL_LAB_REQUEST.SELECT_SQL_LAB_REQUEST_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[4] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = this.dpick_from.Text.Replace("-","");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_vendor, "");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_TextBox(txt_itemCd, "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_TextBox(txt_colorCd, "");
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}




		public DataTable Select_get_date(string arg_date)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SQL_LAB_REQUEST.SELECT_GET_DATE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_DATE";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_date;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion

	}
}

