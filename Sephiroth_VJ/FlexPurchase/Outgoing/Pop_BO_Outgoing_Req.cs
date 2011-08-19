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

namespace FlexPurchase.Outgoing
{
	public class Pop_BO_Outgoing_Req : COM.PCHWinForm.Pop_Large
	{
		
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.SSP spd_main;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_shipDate;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.Label lbl_item;
		private C1.Win.C1List.C1Combo cmb_user;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.Label lbl_itemGroup;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuItem menuitem_SelectAll;
		private System.Windows.Forms.MenuItem menuitem_DeSelectAll;
		private System.Windows.Forms.Label btn_groupSearch;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.ContextMenu cmenu_Barcode;
		private System.Windows.Forms.TextBox txt_itemNm;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label lbl_requestNo;
		private C1.Win.C1List.C1Combo cmb_reqNo;
		private C1.Win.C1List.C1Combo cmb_reqReason;
		private System.Windows.Forms.Label lbl_reqReason;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		
		private COM.FSP fgrid_main;
		private int[] _checkCols;
		private bool _isAccessible = true;
		private string _vWhCd = "";

		//메인창으로 리턴될 데이터 테이블
		public DataTable _DT;  

		private int _lxChkCol			= (int)ClassLib.TBSBO_OUTGOING_REQ.IxCHK;
		private int _lxReqNoCol			= (int)ClassLib.TBSBO_OUTGOING_REQ.IxREQ_NO;
		private int _lxReqSeqCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxREQ_SEQ;
		private int _lxFactoryCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxFACTORY;
		private int _lxItemCdCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxITEM_CD;
		private int _lxItemNameCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxITEM_NAME;
		private int _lxSpecCdCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxSPEC_CD;
		private int _lxSpecNameCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxSEPC_NAME;
		private int _lxColorCdCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxCOLOR_CD;
		private int _lxColorNameCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxCOLOR_NAME;
		private int _lxReqQtyCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxREQ_QTY;
		private int _lxUnitCol			= (int)ClassLib.TBSBO_OUTGOING_REQ.IxUNIT;
		private int _lxPurCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_REQ.IxPUR_CURRENCY;
		private int _lxPurPriceCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxPUR_PRICE;
		private int _lxCbdCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_REQ.IxCBD_CURRENCY;
		private int _lxCbdPriceCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxCBD_PRICE;
		private int _lxShipCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_REQ.IxSHIP_CURRENCY;
		private int _lxShipPriceCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxSHIP_PRICE;
		private int _lxStyleCdCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxSTYLE_CD;
		private int _lxStyleNameCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxSTYLE_NAME;
		private int _lxReqUserCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxREQ_USER;
		private int _lxReqDeptCol		= (int)ClassLib.TBSBO_OUTGOING_REQ.IxREQ_DEPT;
	
		private int _ldFactoryCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxFACTORY -1;
		private int _ldItemCdCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxITEM_CD -1;
		private int _ldItemNameCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxITEM_NAME -1;
		private int _ldSpecCdCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSPEC_CD -1;
		private int _ldSpecNameCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSPEC_NAME -1;
		private int _ldColorCdCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_CD -1;
		private int _ldColorNameCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_NAME -1;
		private int _ldOutQtyCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_QTY -1;
		private int _ldUnitCol			= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxUNIT -1; 
		private int _ldPurCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxPUR_CURRENCY -1;
		private int _ldPurPriceCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxPUR_PRICE -1;
		private int _ldCbdCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCBD_CURRENCY -1;
		private int _ldCbdPriceCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCBD_PRICE -1;
		private int _ldShipCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSHIP_CURRENCY -1;
		private int _ldShipPriceCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSHIP_PRICE -1; 
		private int _ldStyleCdCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSTYLE_CD -1;
		private int _ldStyleNameCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSTYLE_NAME -1;
		private int _ldTranDivCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxTRAN_DIV -1;
		private int _ldReqNoCol			= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxREQ_NO -1;
		private int _ldReqSeqCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxREQ_SEQ -1;
		private int _ldReqUserCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxREQ_USER -1;
		private int _ldReqDeptCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxREQ_DEPT -1;
		private C1.Win.C1List.C1Combo cmb_outProcess;
		private System.Windows.Forms.Label lbl_cont;
		private C1.Win.C1List.C1Combo cmb_workLine;
		private System.Windows.Forms.Label lbl_workLine;
		private System.Windows.Forms.CheckBox chk_detail;
		private int _ldWhCdCol			= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxWH_CD -1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem_SelectCR;
		private System.Windows.Forms.MenuItem menuItem_DeselectCR; 
		private int _IdDirQtyCol        = (int)ClassLib.TBSBO_OUTGOING_OTHER.IxDIR_QTY - 1;

		#endregion
		
		#region 생성자 / 소멸자
		public Pop_BO_Outgoing_Req(Control arg_grid, int[] arg_checks)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			fgrid_main = (COM.FSP)arg_grid;

			_checkCols = arg_checks;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BO_Outgoing_Req));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_itemGroup = new System.Windows.Forms.Label();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.lbl_user = new System.Windows.Forms.Label();
            this.cmb_reqNo = new C1.Win.C1List.C1Combo();
            this.lbl_requestNo = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_detail = new System.Windows.Forms.CheckBox();
            this.cmb_workLine = new C1.Win.C1List.C1Combo();
            this.lbl_workLine = new System.Windows.Forms.Label();
            this.cmb_outProcess = new C1.Win.C1List.C1Combo();
            this.lbl_cont = new System.Windows.Forms.Label();
            this.cmb_reqReason = new C1.Win.C1List.C1Combo();
            this.lbl_reqReason = new System.Windows.Forms.Label();
            this.spd_main = new COM.SSP();
            this.cmenu_Barcode = new System.Windows.Forms.ContextMenu();
            this.menuitem_SelectAll = new System.Windows.Forms.MenuItem();
            this.menuitem_DeSelectAll = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem_SelectCR = new System.Windows.Forms.MenuItem();
            this.menuItem_DeselectCR = new System.Windows.Forms.MenuItem();
            this._mainSheet = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainSheet)).BeginInit();
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
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "25.2:False:True;65.6:False:False;6:False:True;\t0.505050505050505:False:True;96.96" +
                "9696969697:False:False;0.505050505050505:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(792, 500);
            this.c1Sizer1.TabIndex = 25;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_menu.Controls.Add(this.btn_close);
            this.pnl_menu.Controls.Add(this.btn_apply);
            this.pnl_menu.Location = new System.Drawing.Point(12, 466);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(768, 30);
            this.pnl_menu.TabIndex = 174;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(680, 3);
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
            this.btn_apply.Location = new System.Drawing.Point(599, 3);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(80, 23);
            this.btn_apply.TabIndex = 546;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseDown);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txt_itemNm);
            this.panel1.Controls.Add(this.cmb_itemGroup);
            this.panel1.Controls.Add(this.btn_groupSearch);
            this.panel1.Controls.Add(this.txt_itemCd);
            this.panel1.Controls.Add(this.lbl_item);
            this.panel1.Controls.Add(this.lbl_itemGroup);
            this.panel1.Controls.Add(this.cmb_user);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.cmb_reqNo);
            this.panel1.Controls.Add(this.lbl_requestNo);
            this.panel1.Controls.Add(this.cmb_factory);
            this.panel1.Controls.Add(this.lbl_factory);
            this.panel1.Controls.Add(this.lbl_shipDate);
            this.panel1.Controls.Add(this.lblexcep_mark);
            this.panel1.Controls.Add(this.dpick_to);
            this.panel1.Controls.Add(this.dpick_from);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 126);
            this.panel1.TabIndex = 169;
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(525, 57);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(141, 21);
            this.txt_itemNm.TabIndex = 378;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style1;
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
            this.cmb_itemGroup.EvenRowStyle = style2;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style3;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style4;
            this.cmb_itemGroup.HighLightRowStyle = style5;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(445, 35);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style6;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style7;
            this.cmb_itemGroup.Size = new System.Drawing.Size(200, 20);
            this.cmb_itemGroup.Style = style8;
            this.cmb_itemGroup.TabIndex = 377;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(645, 35);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 376;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(445, 57);
            this.txt_itemCd.MaxLength = 10;
            this.txt_itemCd.Name = "txt_itemCd";
            this.txt_itemCd.Size = new System.Drawing.Size(79, 21);
            this.txt_itemCd.TabIndex = 374;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(344, 57);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 373;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_itemGroup
            // 
            this.lbl_itemGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemGroup.ImageIndex = 0;
            this.lbl_itemGroup.ImageList = this.img_Label;
            this.lbl_itemGroup.Location = new System.Drawing.Point(344, 35);
            this.lbl_itemGroup.Name = "lbl_itemGroup";
            this.lbl_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemGroup.TabIndex = 371;
            this.lbl_itemGroup.Text = "Item Group";
            this.lbl_itemGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_user
            // 
            this.cmb_user.AddItemCols = 0;
            this.cmb_user.AddItemSeparator = ';';
            this.cmb_user.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_user.Caption = "";
            this.cmb_user.CaptionHeight = 17;
            this.cmb_user.CaptionStyle = style9;
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
            this.cmb_user.EvenRowStyle = style10;
            this.cmb_user.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FooterStyle = style11;
            this.cmb_user.GapHeight = 2;
            this.cmb_user.HeadingStyle = style12;
            this.cmb_user.HighLightRowStyle = style13;
            this.cmb_user.ItemHeight = 15;
            this.cmb_user.Location = new System.Drawing.Point(445, 79);
            this.cmb_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_user.MaxDropDownItems = ((short)(5));
            this.cmb_user.MaxLength = 32767;
            this.cmb_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.OddRowStyle = style14;
            this.cmb_user.PartialRightColumn = false;
            this.cmb_user.PropBag = resources.GetString("cmb_user.PropBag");
            this.cmb_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_user.SelectedStyle = style15;
            this.cmb_user.Size = new System.Drawing.Size(220, 20);
            this.cmb_user.Style = style16;
            this.cmb_user.TabIndex = 369;
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ImageIndex = 0;
            this.lbl_user.ImageList = this.img_Label;
            this.lbl_user.Location = new System.Drawing.Point(344, 79);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_user.TabIndex = 370;
            this.lbl_user.Text = "User";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_reqNo
            // 
            this.cmb_reqNo.AddItemCols = 0;
            this.cmb_reqNo.AddItemSeparator = ';';
            this.cmb_reqNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqNo.Caption = "";
            this.cmb_reqNo.CaptionHeight = 17;
            this.cmb_reqNo.CaptionStyle = style17;
            this.cmb_reqNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reqNo.ColumnCaptionHeight = 18;
            this.cmb_reqNo.ColumnFooterHeight = 18;
            this.cmb_reqNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reqNo.ContentHeight = 16;
            this.cmb_reqNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reqNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_reqNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reqNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reqNo.EditorHeight = 16;
            this.cmb_reqNo.EvenRowStyle = style18;
            this.cmb_reqNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqNo.FooterStyle = style19;
            this.cmb_reqNo.GapHeight = 2;
            this.cmb_reqNo.HeadingStyle = style20;
            this.cmb_reqNo.HighLightRowStyle = style21;
            this.cmb_reqNo.ItemHeight = 15;
            this.cmb_reqNo.Location = new System.Drawing.Point(445, 13);
            this.cmb_reqNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqNo.MaxDropDownItems = ((short)(5));
            this.cmb_reqNo.MaxLength = 32767;
            this.cmb_reqNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqNo.Name = "cmb_reqNo";
            this.cmb_reqNo.OddRowStyle = style22;
            this.cmb_reqNo.PartialRightColumn = false;
            this.cmb_reqNo.PropBag = resources.GetString("cmb_reqNo.PropBag");
            this.cmb_reqNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqNo.SelectedStyle = style23;
            this.cmb_reqNo.Size = new System.Drawing.Size(220, 20);
            this.cmb_reqNo.Style = style24;
            this.cmb_reqNo.TabIndex = 184;
            this.cmb_reqNo.SelectedValueChanged += new System.EventHandler(this.cmb_reqNo_SelectedValueChanged);
            // 
            // lbl_requestNo
            // 
            this.lbl_requestNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_requestNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_requestNo.ImageIndex = 1;
            this.lbl_requestNo.ImageList = this.img_Label;
            this.lbl_requestNo.Location = new System.Drawing.Point(344, 13);
            this.lbl_requestNo.Name = "lbl_requestNo";
            this.lbl_requestNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_requestNo.TabIndex = 182;
            this.lbl_requestNo.Text = "Request No";
            this.lbl_requestNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style25;
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
            this.cmb_factory.EvenRowStyle = style26;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style27;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style28;
            this.cmb_factory.HighLightRowStyle = style29;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 13);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style30;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style31;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style32;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 13);
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
            this.lbl_shipDate.ImageIndex = 1;
            this.lbl_shipDate.ImageList = this.img_Label;
            this.lbl_shipDate.Location = new System.Drawing.Point(8, 34);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 52;
            this.lbl_shipDate.Text = "Outgoing Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(216, 35);
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
            this.dpick_to.Location = new System.Drawing.Point(230, 35);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 5;
            this.dpick_to.CloseUp += new System.EventHandler(this.dpick_to_CloseUp);
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 35);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 4;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_detail);
            this.groupBox1.Controls.Add(this.cmb_workLine);
            this.groupBox1.Controls.Add(this.lbl_workLine);
            this.groupBox1.Controls.Add(this.cmb_outProcess);
            this.groupBox1.Controls.Add(this.lbl_cont);
            this.groupBox1.Controls.Add(this.cmb_reqReason);
            this.groupBox1.Controls.Add(this.lbl_reqReason);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 168);
            this.groupBox1.TabIndex = 381;
            this.groupBox1.TabStop = false;
            // 
            // chk_detail
            // 
            this.chk_detail.Location = new System.Drawing.Point(346, 101);
            this.chk_detail.Name = "chk_detail";
            this.chk_detail.Size = new System.Drawing.Size(120, 24);
            this.chk_detail.TabIndex = 404;
            this.chk_detail.Text = "Detail";
            this.chk_detail.CheckedChanged += new System.EventHandler(this.chk_detail_CheckedChanged);
            // 
            // cmb_workLine
            // 
            this.cmb_workLine.AddItemCols = 0;
            this.cmb_workLine.AddItemSeparator = ';';
            this.cmb_workLine.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_workLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_workLine.Caption = "";
            this.cmb_workLine.CaptionHeight = 17;
            this.cmb_workLine.CaptionStyle = style33;
            this.cmb_workLine.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_workLine.ColumnCaptionHeight = 18;
            this.cmb_workLine.ColumnFooterHeight = 18;
            this.cmb_workLine.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_workLine.ContentHeight = 16;
            this.cmb_workLine.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_workLine.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_workLine.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_workLine.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_workLine.EditorHeight = 16;
            this.cmb_workLine.EvenRowStyle = style34;
            this.cmb_workLine.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_workLine.FooterStyle = style35;
            this.cmb_workLine.GapHeight = 2;
            this.cmb_workLine.HeadingStyle = style36;
            this.cmb_workLine.HighLightRowStyle = style37;
            this.cmb_workLine.ItemHeight = 15;
            this.cmb_workLine.Location = new System.Drawing.Point(109, 101);
            this.cmb_workLine.MatchEntryTimeout = ((long)(2000));
            this.cmb_workLine.MaxDropDownItems = ((short)(5));
            this.cmb_workLine.MaxLength = 32767;
            this.cmb_workLine.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_workLine.Name = "cmb_workLine";
            this.cmb_workLine.OddRowStyle = style38;
            this.cmb_workLine.PartialRightColumn = false;
            this.cmb_workLine.PropBag = resources.GetString("cmb_workLine.PropBag");
            this.cmb_workLine.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_workLine.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_workLine.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_workLine.SelectedStyle = style39;
            this.cmb_workLine.Size = new System.Drawing.Size(220, 20);
            this.cmb_workLine.Style = style40;
            this.cmb_workLine.TabIndex = 402;
            // 
            // lbl_workLine
            // 
            this.lbl_workLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workLine.ImageIndex = 0;
            this.lbl_workLine.ImageList = this.img_Label;
            this.lbl_workLine.Location = new System.Drawing.Point(8, 101);
            this.lbl_workLine.Name = "lbl_workLine";
            this.lbl_workLine.Size = new System.Drawing.Size(100, 21);
            this.lbl_workLine.TabIndex = 403;
            this.lbl_workLine.Text = "Work Line";
            this.lbl_workLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_outProcess
            // 
            this.cmb_outProcess.AddItemCols = 0;
            this.cmb_outProcess.AddItemSeparator = ';';
            this.cmb_outProcess.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_outProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outProcess.Caption = "";
            this.cmb_outProcess.CaptionHeight = 17;
            this.cmb_outProcess.CaptionStyle = style41;
            this.cmb_outProcess.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_outProcess.ColumnCaptionHeight = 18;
            this.cmb_outProcess.ColumnFooterHeight = 18;
            this.cmb_outProcess.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_outProcess.ContentHeight = 16;
            this.cmb_outProcess.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_outProcess.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_outProcess.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_outProcess.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_outProcess.EditorHeight = 16;
            this.cmb_outProcess.EvenRowStyle = style42;
            this.cmb_outProcess.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_outProcess.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outProcess.FooterStyle = style43;
            this.cmb_outProcess.GapHeight = 2;
            this.cmb_outProcess.HeadingStyle = style44;
            this.cmb_outProcess.HighLightRowStyle = style45;
            this.cmb_outProcess.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_outProcess.ItemHeight = 15;
            this.cmb_outProcess.Location = new System.Drawing.Point(109, 79);
            this.cmb_outProcess.MatchEntryTimeout = ((long)(2000));
            this.cmb_outProcess.MaxDropDownItems = ((short)(5));
            this.cmb_outProcess.MaxLength = 32767;
            this.cmb_outProcess.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_outProcess.Name = "cmb_outProcess";
            this.cmb_outProcess.OddRowStyle = style46;
            this.cmb_outProcess.PartialRightColumn = false;
            this.cmb_outProcess.PropBag = resources.GetString("cmb_outProcess.PropBag");
            this.cmb_outProcess.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outProcess.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outProcess.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outProcess.SelectedStyle = style47;
            this.cmb_outProcess.Size = new System.Drawing.Size(220, 20);
            this.cmb_outProcess.Style = style48;
            this.cmb_outProcess.TabIndex = 399;
            // 
            // lbl_cont
            // 
            this.lbl_cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_cont.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cont.ImageIndex = 0;
            this.lbl_cont.ImageList = this.img_Label;
            this.lbl_cont.Location = new System.Drawing.Point(8, 79);
            this.lbl_cont.Name = "lbl_cont";
            this.lbl_cont.Size = new System.Drawing.Size(100, 21);
            this.lbl_cont.TabIndex = 398;
            this.lbl_cont.Text = "Out Process";
            this.lbl_cont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_reqReason
            // 
            this.cmb_reqReason.AddItemCols = 0;
            this.cmb_reqReason.AddItemSeparator = ';';
            this.cmb_reqReason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqReason.Caption = "";
            this.cmb_reqReason.CaptionHeight = 17;
            this.cmb_reqReason.CaptionStyle = style49;
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
            this.cmb_reqReason.EvenRowStyle = style50;
            this.cmb_reqReason.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqReason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqReason.FooterStyle = style51;
            this.cmb_reqReason.GapHeight = 2;
            this.cmb_reqReason.HeadingStyle = style52;
            this.cmb_reqReason.HighLightRowStyle = style53;
            this.cmb_reqReason.ItemHeight = 15;
            this.cmb_reqReason.Location = new System.Drawing.Point(109, 57);
            this.cmb_reqReason.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqReason.MaxDropDownItems = ((short)(5));
            this.cmb_reqReason.MaxLength = 32767;
            this.cmb_reqReason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqReason.Name = "cmb_reqReason";
            this.cmb_reqReason.OddRowStyle = style54;
            this.cmb_reqReason.PartialRightColumn = false;
            this.cmb_reqReason.PropBag = resources.GetString("cmb_reqReason.PropBag");
            this.cmb_reqReason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqReason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.SelectedStyle = style55;
            this.cmb_reqReason.Size = new System.Drawing.Size(220, 20);
            this.cmb_reqReason.Style = style56;
            this.cmb_reqReason.TabIndex = 383;
            // 
            // lbl_reqReason
            // 
            this.lbl_reqReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqReason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqReason.ImageIndex = 1;
            this.lbl_reqReason.ImageList = this.img_Label;
            this.lbl_reqReason.Location = new System.Drawing.Point(8, 57);
            this.lbl_reqReason.Name = "lbl_reqReason";
            this.lbl_reqReason.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqReason.TabIndex = 382;
            this.lbl_reqReason.Text = "Request Reason";
            this.lbl_reqReason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spd_main
            // 
            this.spd_main.ContextMenu = this.cmenu_Barcode;
            this.spd_main.Location = new System.Drawing.Point(12, 134);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this._mainSheet);
            this.spd_main.Size = new System.Drawing.Size(768, 328);
            this.spd_main.TabIndex = 0;
            // 
            // cmenu_Barcode
            // 
            this.cmenu_Barcode.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuitem_SelectAll,
            this.menuitem_DeSelectAll,
            this.menuItem1,
            this.menuItem_SelectCR,
            this.menuItem_DeselectCR});
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
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // menuItem_SelectCR
            // 
            this.menuItem_SelectCR.Index = 3;
            this.menuItem_SelectCR.Text = "Select Selection Range";
            this.menuItem_SelectCR.Click += new System.EventHandler(this.menuItem_SelectCR_Click);
            // 
            // menuItem_DeselectCR
            // 
            this.menuItem_DeselectCR.Index = 4;
            this.menuItem_DeselectCR.Text = "Deselect Selection Range";
            this.menuItem_DeselectCR.Click += new System.EventHandler(this.menuItem_DeselectCR_Click);
            // 
            // _mainSheet
            // 
            this._mainSheet.SheetName = "Sheet1";
            // 
            // Pop_BO_Outgoing_Req
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 558);
            this.Controls.Add(this.c1Sizer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pop_BO_Outgoing_Req";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainSheet)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{
			this.Grid_EditModeOnProcess(spd_main) ;
		}		

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			this.spd_main.Update_Row(img_Action);
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

 

		private void menuItem_SelectCR_Click(object sender, System.EventArgs e)
		{
			
			try
			{ 
				Select_SelectionRange(true);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_SelectionRange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuItem_DeselectCR_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Select_SelectionRange(false);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_SelectionRange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void Select_SelectionRange(bool arg_select)
		{

			CellRange[] vSelectionRange = _mainSheet.GetSelections(); 
			for (int i = 0 ; i < vSelectionRange.Length; i++)
			{
				int start_row = vSelectionRange[i].Row;
				int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

				for (int j = start_row ; j < end_row; j++)
				{ 
					spd_main.ActiveSheet.Cells[j, _lxChkCol].Value = arg_select;
				}
			}

		}




		/// <summary>
		/// Select_All : 모든 Row 선택
		/// </summary>
		private void Select_All()
		{ 
			for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
			{
				if (!_mainSheet.Rows[i].Locked)
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
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Btn_SearchClickProcess();							
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			if (_mainSheet.Rows.Count > 0)
			{
				if (chk_detail.Checked  == true) 
				{
					ClassLib.ComVar.Job_Process  = cmb_outProcess.SelectedValue.ToString();
					ClassLib.ComVar.Job_Line     = cmb_workLine.SelectedValue.ToString();
				}
				else
				{
					ClassLib.ComVar.Job_Process  = "";
					ClassLib.ComVar.Job_Line     = "";

				}

				this.Return_Data();

			}
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			_DT	= null;	
			this.Close();
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

		private void Cmb_outNoSettingProcess()
		{
			try
			{
				spd_main.ClearAll();
				string[] vProviso = GetSearchProviso();
				DataTable vDt = SELECT_SBP_REQ_NO(vProviso[0], vProviso[1], vProviso[2]);
				COM.ComCtl.Set_ComboList(vDt, cmb_reqNo, 0, 1, true, false);
				cmb_reqNo.SelectedIndex = 0;
				vDt.Dispose();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			dpick_to.Value = dpick_from.Value; 
			this.Cmb_outNoSettingProcess();
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_outNoSettingProcess();
		}

		private void dpick_to_CloseUp(object sender, System.EventArgs e)
		{
			this.Cmb_outNoSettingProcess();		
		}

		private void cmb_reqNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_reqNoSelectedValueChangedProcess();	
		}

		#region 입력이동

		#endregion

		#region 버튼효과

		private void btn_search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex--;
		}

		private void btn_search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex++;
		}

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

		private string[] GetSearchProviso()
		{
			string[] vProviso = new string[3];
			vProviso[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			vProviso[1] = dpick_from.Text.Replace("-", "");
			vProviso[2] = dpick_to.Text.Replace("-", "");

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
            //			ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Outgoing Request";
            this.Text = "Outgoing Request";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SBO_OUTGOING_REQ", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

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

			Create_DataTable();

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// Item Group Combobox Setting
			vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
			vDt.Dispose();

			// Request Reason Combobox Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_reqReason, 1, 2, true, 56,0);
			cmb_reqReason.SelectedIndex = -1;
			vDt.Dispose();

			// cmb_user
			vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory);
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_user,1,2,(vDt.Rows.Count > 1) ? true : false);
			//cmb_user.SelectedValue = COM.ComVar.This_User;
			vDt.Dispose();



			//	cmb_outProcess
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Process_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_outProcess, 0, 1, true);
			cmb_outProcess.SelectedIndex = -1;
			vDt.Dispose() ;


			// cmb_workLine
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, true);
			cmb_outProcess.SelectedIndex = -1;
			vDt.Dispose() ;






			// default search proviso
			if (COM.ComVar.Parameter_PopUp[0].ToString() != "")
				cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
			dpick_from.Value			= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
			dpick_to.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
			
			// Item Group Combobox Setting
//			this.cmb_itemGroup

			// Disabled tbutton
			tbtn_Save.Enabled		= false;
			tbtn_Delete.Enabled		= false;
			tbtn_Conform.Enabled	= false;
			tbtn_Print.Enabled		= false;
			tbtn_Create.Enabled		= false;

		}

		/// <summary>
		/// Set_Return_DataTable : 메인창으로 리턴될 데이터 테이블 Setting
		/// </summary>
		private void Create_DataTable()
		{
			_DT = new DataTable("BarCode");

			// 메인 데이터 
			for(int i = 0; i <= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_CD; i++)
			{
				_DT.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			}
		}


		/// <summary>
		/// Check_Search : Search전 check
		/// </summary>
		private bool Check_Search()
		{
			if (cmb_outProcess.SelectedIndex  == -1 )
			{
				ClassLib.ComFunction.User_Message("No Process","Error");
				return false;
			}

			if (cmb_workLine.SelectedIndex   ==  -1)
			{
				ClassLib.ComFunction.User_Message("No Line","Error");
				return false;
			}

			return true;

		}



		private void chk_detail_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chk_detail.Checked  == false)
			{

				cmb_outProcess.SelectedIndex   = -1;
			    cmb_workLine.SelectedIndex     = -1;
		    }
		}

		
		private void Btn_SearchClickProcess()
		{
			try
			{
				if (chk_detail.Checked  == true)
					if(  Check_Search() != true) 
					{
						return;
					}
				


				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = this.SELECT_SBP_REQUEST_LIST();
				if (vDt.Rows.Count > 0)
				{
					spd_main.Display_Grid(vDt);
				}
				else
				{
					spd_main.ClearAll(); 
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
				arg_grid.Update_Row(img_Action) ;
			}
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				spd_main.ClearAll();
				this.cmb_reqReason.SelectedIndex	= -1;				
				this.cmb_user.SelectedIndex			= -1;
				this.cmb_outProcess.SelectedIndex   = -1;
				this.cmb_workLine.SelectedIndex     = -1;
				this.txt_itemCd.Text				= "";
				this.txt_itemNm.Text				= "";
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}
		
		private void Cmb_reqNoSelectedValueChangedProcess()
		{
			try
			{
				if (cmb_reqNo.SelectedIndex > 0)
					Btn_SearchClickProcess();		
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				// PopUp -- Incoming WareHouse Select
				DataTable vDt = null;
				COM.ComVar.Parameter_PopUp		= new string[2];

				vDt = FlexPurchase.ClassLib.ComFunction.SELECT_WAREHOUSE_LIST_USING(cmb_factory.SelectedValue.ToString());
				
				COM.ComVar.Parameter_PopUp[1]	= "Select INcoming WareHouse";
				COM.ComVar.Parameter_PopUp[0]	= "WareHouse";

				ClassLib.ComVar.Parameter_PopUpTable = vDt;
				vDt.Dispose();

				FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer pop_changer = new FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer();
				pop_changer.ShowDialog();

				if (COM.ComVar.Parameter_PopUp != null)
				{
					_vWhCd = COM.ComVar.Parameter_PopUp[0];

					pop_changer.Dispose();
					Make_DT(); 
				}
				else
				{
					_DT = null;
					pop_changer.Dispose();
					return;
				}
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

//				CellRange[] vSelectionRange = _mainSheet.GetSelections(); 
//				for (int i = 0 ; i < vSelectionRange.Length; i++)
//				{
//					int start_row = vSelectionRange[i].Row;
//					int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;
//
//					for (int j = start_row ; j < end_row; j++)
//					{
//						if (!_mainSheet.Rows[j].Locked)
//							spd_main.ActiveSheet.Cells[j, _lxChkCol].Value = true;
//					}
//				}	
	  
				 

				DataRow datarow = null; 
		 
				int vFlag = 0;
		 
				for(int i = 0; i < this._mainSheet.RowCount; i++)
				{ 
					bool vBool	=	this._mainSheet.Cells[i, _lxChkCol].Value.ToString() == "True" ? true : false;
					if (vBool)
					{
						vFlag = Etc_DataDuplicateCheck_FSP(i);

						if (vFlag == 0)
						{
							datarow = _DT.NewRow();

							datarow[_ldFactoryCol]		= spd_main.ActiveSheet.Cells[i, _lxFactoryCol].Value.ToString();
							datarow[_ldItemCdCol]		= spd_main.ActiveSheet.Cells[i, _lxItemCdCol].Value.ToString();
							datarow[_ldItemNameCol]		= spd_main.ActiveSheet.Cells[i, _lxItemNameCol].Value.ToString();
							datarow[_ldSpecCdCol]		= spd_main.ActiveSheet.Cells[i, _lxSpecCdCol].Value.ToString();
							datarow[_ldSpecNameCol]		= spd_main.ActiveSheet.Cells[i, _lxSpecNameCol].Value.ToString();
							datarow[_ldColorCdCol]		= spd_main.ActiveSheet.Cells[i, _lxColorCdCol].Value.ToString();
							datarow[_ldColorNameCol]	= spd_main.ActiveSheet.Cells[i, _lxColorNameCol].Value.ToString();
							datarow[_ldOutQtyCol]		= spd_main.ActiveSheet.Cells[i, _lxReqQtyCol].Value.ToString();
							datarow[_ldUnitCol]			= spd_main.ActiveSheet.Cells[i, _lxUnitCol].Value.ToString();
							datarow[_ldPurCurrencyCol]	= spd_main.ActiveSheet.Cells[i, _lxPurCurrencyCol].Value.ToString();
							datarow[_ldPurPriceCol]		= spd_main.ActiveSheet.Cells[i, _lxPurPriceCol].Value.ToString();
							datarow[_ldCbdCurrencyCol]	= spd_main.ActiveSheet.Cells[i, _lxCbdCurrencyCol].Value.ToString();
							datarow[_ldCbdPriceCol]		= spd_main.ActiveSheet.Cells[i, _lxCbdPriceCol].Value.ToString();
							datarow[_ldShipCurrencyCol] = spd_main.ActiveSheet.Cells[i, _lxShipCurrencyCol].Value.ToString();
							datarow[_ldShipPriceCol]	= spd_main.ActiveSheet.Cells[i, _lxShipPriceCol].Value.ToString();
							datarow[_ldStyleCdCol]		= spd_main.ActiveSheet.Cells[i, _lxStyleCdCol].Value.ToString();
							datarow[_ldStyleNameCol]	= spd_main.ActiveSheet.Cells[i, _lxStyleNameCol].Value.ToString();
							datarow[_ldReqNoCol]		= spd_main.ActiveSheet.Cells[i, _lxReqNoCol].Value.ToString();
							datarow[_ldReqSeqCol]		= spd_main.ActiveSheet.Cells[i, _lxReqSeqCol].Value.ToString();
							datarow[_ldReqUserCol]		= spd_main.ActiveSheet.Cells[i, _lxReqUserCol].Value.ToString();
							datarow[_ldReqDeptCol]		= spd_main.ActiveSheet.Cells[i, _lxReqDeptCol].Value.ToString();
							datarow[_ldWhCdCol]			= _vWhCd;
							datarow[_IdDirQtyCol]       = spd_main.ActiveSheet.Cells[i, _lxReqQtyCol].Value.ToString();
							datarow[_ldTranDivCol]		= "R"; 
										
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


				if (vFlag != -1)
				{
					this.DialogResult = DialogResult.OK;

					COM.ComVar.Parameter_PopUp		= new string[2];
					COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_outProcess, "");
					COM.ComVar.Parameter_PopUp[1]	= ClassLib.ComFunction.Empty_Combo(cmb_workLine, "");

					this.Close();
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Return_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 	
		}

		private int Etc_DataDuplicateCheck_FSP(int arg_row)
		{
			int vReturn = 0;

			for ( int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++ )
			{
				if( fgrid_main[vRow, _checkCols[0]].ToString().Replace("-", "").Equals(_mainSheet.Cells[arg_row, _lxStyleCdCol].Value.ToString()) &&
					fgrid_main[vRow, _checkCols[1]].ToString().Equals(_mainSheet.Cells[arg_row, _lxItemCdCol].Value.ToString()) &&
					fgrid_main[vRow, _checkCols[2]].ToString().Equals(_mainSheet.Cells[arg_row, _lxSpecCdCol].Value.ToString()) &&
					fgrid_main[vRow, _checkCols[3]].ToString().Equals(_mainSheet.Cells[arg_row, _lxColorCdCol].Value.ToString()) &&
					fgrid_main[vRow, _checkCols[4]].ToString().Equals(_mainSheet.Cells[arg_row, _lxReqNoCol].Value.ToString())) 
				{
					string vMessage = "The selected item is already exists \r\n" +
						"Choose process.. \r\n\r\n" +
						"[Yes] : overwrite the existing data \r\n" +
						"[No] : deselect current item \r\n" +
						"[Cancel] : process abort \r\n\r\n" +
						"Row Number : " + arg_row + 1 + "\r\n" + 
						"Item : " + _mainSheet.Cells[arg_row, _lxItemNameCol].Value.ToString()  + 
						"  Spec : " + _mainSheet.Cells[arg_row, _lxSpecNameCol].Value.ToString() +
						"  Color : "+ _mainSheet.Cells[arg_row, _lxColorNameCol].Value.ToString() + "\t";

					_mainSheet.Cells[arg_row, _lxChkCol].Value = true;
					fgrid_main.Select(vRow, 1);

					switch (MessageBox.Show(this, vMessage, "Duplicate Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
					{
						case DialogResult.Yes:
							string vTag = (fgrid_main[vRow, 0] == null) ? "" : fgrid_main[vRow, 0].ToString();
							if (vTag.Equals(ClassLib.ComVar.Insert))
								fgrid_main.RemoveItem(vRow);
							else
								fgrid_main.Delete_Row(vRow);
							vReturn = 0;
							break;

						case DialogResult.No:
							_mainSheet.Cells[arg_row, _lxChkCol].Value = false;
							vReturn = 1;
							break;

						case DialogResult.Cancel:
							vReturn = -1;
							break;
					}

					break;
				}				
			}

			return vReturn;
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBO_OUT_CONT : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_ship_ymd_from">선적일(From)</param>
		/// <param name="arg_ship_ymd_to">선적일(To)</param>
		/// <param name="arg_size">Size Item</param>
		/// <param name="arg_ship_type">선적구분</param>
		/// <param name="arg_obs_type">OBS Type</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_REQUEST_LIST()
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(13);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUT_REQUEST.SELECT_SBP_REQUEST_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_TO";
			MyOraDB.Parameter_Name[3] = "ARG_REQ_NO";
			MyOraDB.Parameter_Name[4] = "ARG_USER";
			MyOraDB.Parameter_Name[5] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[7] = "ARG_ITEM_NM";
			MyOraDB.Parameter_Name[8] = "ARG_REQ_REASON";
			MyOraDB.Parameter_Name[9] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[10]= "ARG_REQ_DEPT";
			MyOraDB.Parameter_Name[11]= "ARG_USE_DEPT";
			MyOraDB.Parameter_Name[12]= "OUT_CURSOR"; 

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
			MyOraDB.Parameter_Type[12]= (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(this.cmb_factory, " ");
			MyOraDB.Parameter_Values[1] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(this.cmb_reqNo, " ");
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(this.cmb_user, " ");
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_TextBox(this.txt_itemCd, " ");
			MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_Combo(this.cmb_itemGroup, " ");
			MyOraDB.Parameter_Values[7] = ClassLib.ComFunction.Empty_TextBox(this.txt_itemNm, " ");
			MyOraDB.Parameter_Values[8] = ClassLib.ComFunction.Empty_Combo(this.cmb_reqReason, " ");		
			MyOraDB.Parameter_Values[9] = COM.ComVar.This_User;
			MyOraDB.Parameter_Values[10]= ClassLib.ComFunction.Empty_Combo(this.cmb_outProcess, " ");	
			MyOraDB.Parameter_Values[11]= ClassLib.ComFunction.Empty_Combo(this.cmb_workLine, " ");		
			MyOraDB.Parameter_Values[12]= "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		
		}

		/// <summary>
		/// PKG_SBO_OUT_NO : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBO_OUT_NO : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_REQ_NO(string arg_factory, string arg_from, string arg_to )
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUT_REQUEST.SELECT_SBP_REQ_NO";

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

		#endregion


		

		 

	}
}

