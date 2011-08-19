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

namespace FlexPurchase.Incoming
{
	public class Pop_BI_Incoming_Purchase : COM.PCHWinForm.Pop_Large
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.SSP spd_main;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_user;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_shipDate;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.Label lbl_purNo;
		private C1.Win.C1List.C1Combo cmb_purNo;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenu cmenu_Purchase;
		private System.Windows.Forms.MenuItem menuitem_SelectAll;
		private System.Windows.Forms.MenuItem menuitem_DeSelectAll;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet	= null;
		private bool _practicable	= false;
		private bool _isAccessible  = true;
		private System.EventHandler _cmbPurNoEventHandler	= null;
		private string _lcNo  = "";
		private string _invNo = "";
		private string _vWhCd = "";
		
		private COM.FSP fgrid_main;
		private int[] _checkCols;

		//메인창으로 리턴될 데이터 테이블
		public DataTable _DT;  

		private int _lxChkCol			= (int)ClassLib.TBSBI_INCOMING_PUR.IxCHK;
		private int _lxInChkCol			= (int)ClassLib.TBSBI_INCOMING_PUR.IxIN_CHK;		
		private int _lxFactoryCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxFACTORY;
		private int _lxPurNoCol			= (int)ClassLib.TBSBI_INCOMING_PUR.IxPUR_NO;
		private int _lxPurSeqCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxPUR_SEQ;
		private int _lxPurUserCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxPUR_USER;
		private int _lxItemCdCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxITEM_CD;
		private int _lxItemNameCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxITEM_NAME;
		private int _lxSpecCdCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxSPEC_CD;
		private int _lxSpecNameCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxSPEC_NAME;
		private int _lxColorCdCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxCOLOR_CD;
		private int _lxColorNameCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxCOLOR_NAME;
		private int _lxCustCdCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxCUST_CD;
		private int _lxCustNameCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxCUST_NAME;
		private int _lxUnitCol			= (int)ClassLib.TBSBI_INCOMING_PUR.IxUNIT;
		private int _lxPurDeptCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxPUR_DEPT;
		private int _lxPurQtyCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxPUR_QTY;
		private int _lxInQtyCol			= (int)ClassLib.TBSBI_INCOMING_PUR.IxIN_QTY;
		private int _lxPurCurrencyCol	= (int)ClassLib.TBSBI_INCOMING_PUR.IxPUR_CURRENCY;
		private int _lxPurPriceCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxPUR_PRICE;
		private int _lxOutsideCurrencyCol	= (int)ClassLib.TBSBI_INCOMING_PUR.IxOUTSIDE_CURRENCY;
		private int _lxOutsidePriceCol	= (int)ClassLib.TBSBI_INCOMING_PUR.IxOUTSIDE_PRICE;
		private int _lxCbdCurrencyCol	= (int)ClassLib.TBSBI_INCOMING_PUR.IxCBD_CURRENCY;
		private int _lxCbdPriceCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxCBD_PRICE;
		private int _lxTaxCdCol			= (int)ClassLib.TBSBI_INCOMING_PUR.IxTAX_CD;
		private int _lxPayCdCol			= (int)ClassLib.TBSBI_INCOMING_PUR.IxPAY_CD;
		private int _lxLcNoCol			= (int)ClassLib.TBSBI_INCOMING_PUR.IxLC_NO;
		private int _lxInvNoCol			= (int)ClassLib.TBSBI_INCOMING_PUR.IxINV_NO;
		private int _lxStyleCdCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxSTYLE_CD;
		private int _lxStyleNameCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxSTYLE_NAME;
		private int _lxShipQtyCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxSHIP_QTY;
		private int _lxShipNoCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxSHIP_NO;
		private int _lxShipYmdCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxSHIP_YMD;
		private int _lxCheckPurCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxCHECK_PUR;
		private int _lxCheckOutsideCol	= (int)ClassLib.TBSBI_INCOMING_PUR.IxCHECK_OUTSIDE;
		private int _lxCheckCbdCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxCHECK_CBD;
		private int _lxLotNoCol			= (int)ClassLib.TBSBI_INCOMING_PUR.IxLOT_NO;
		private int _lxLotSeqCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxLOT_SEQ;
		private int _lxPriceYNCol		= (int)ClassLib.TBSBI_INCOMING_PUR.IxPRICE_YN;
	
		private int _ldFactoryCol	= (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY -1;
		private int _ldItemCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxITEM_CD -1;
		private int _ldItemNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxITEM_NAME -1;
		private int _ldSpecCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSPEC_CD -1;
		private int _ldSpecNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSPEC_NAME -1;
		private int _ldColorCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCOLOR_CD -1;
		private int _ldColorNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCOLOR_NAME -1;
		private int _ldInQtyCol		= (int)ClassLib.TBSBI_IN_TAIL.IxIN_QTY -1;
		private int _ldUnitCol		= (int)ClassLib.TBSBI_IN_TAIL.IxUNIT -1;
		private int _ldPkUnitQtyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPK_UNIT_QTY -1;
		private int _ldPurCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_CURRENCY -1;
		private int _ldPurPriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_PRICE -1;
		private int _ldOutsideCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxOUTSIDE_CURRENCY -1;
		private int _ldOutsidePriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxOUTSIDE_PRICE -1;
		private int _ldCbdCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCBD_CURRENCY -1;
		private int _ldCbdPriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCBD_PRICE -1;
		private int _ldCustCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCUST_CD -1;
		private int _ldCustNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCUST_NAME -1;
		private int _ldTaxCdCol		= (int)ClassLib.TBSBI_IN_TAIL.IxTAX_CD -1;
		private int _ldShipYmdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_YMD -1;
		private int _ldShipQtyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_QTY -1;
		private int _ldShipNoCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_NO -1;
		private int _ldStyleCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSTYLE_CD -1;
		private int _ldStyleNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSTYLE_NAME -1;
		private int _ldWhCdCol		= (int)ClassLib.TBSBI_IN_TAIL.IxWH_CD -1;
		private int _ldPayCdCol		= (int)ClassLib.TBSBI_IN_TAIL.IxPAY_CD -1;
		private int _ldPurNoCol		= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_NO -1;
		private int _ldPurSeqCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_SEQ -1;
		private int _ldPurUserCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_USER -1;
		private int _ldTranDivCol	= (int)ClassLib.TBSBI_IN_TAIL.IxTRAN_DIV -1;
		private int _ldPurDeptCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_DEPT -1;
		private int _ldPriceYnCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPRICE_YN -1;
		private int _ldLotNoCol		= (int)ClassLib.TBSBI_IN_TAIL.IxLOT_NO -1;
		private int _ldLotSeqCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLOT_SEQ -1;


       /*메인화면 Return용 */
		private int _factoryCol     = (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY;
		private int _inSeqCol       = (int)ClassLib.TBSBI_IN_TAIL.IxIN_SEQ;
		private int _modQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxMOD_QTY;
		private int _seqCol				= (int)ClassLib.TBSBI_IN_TAIL.IxSEQ;
		private int _inQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxIN_QTY;




		private int _ldLedgerPriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_PRICE -1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuitem_SelectCheck;
		private System.Windows.Forms.MenuItem menuitem_DeSelectCheck;
		private int _ldLedgerCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_CURRENCY -1;



		#endregion
		
		#region 생성자 / 소멸자
		public Pop_BI_Incoming_Purchase(Control arg_grid, int[] arg_checks)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BI_Incoming_Purchase));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.spd_main = new COM.SSP();
            this.cmenu_Purchase = new System.Windows.Forms.ContextMenu();
            this.menuitem_SelectAll = new System.Windows.Forms.MenuItem();
            this.menuitem_SelectCheck = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuitem_DeSelectAll = new System.Windows.Forms.MenuItem();
            this.menuitem_DeSelectCheck = new System.Windows.Forms.MenuItem();
            this._mainSheet = new FarPoint.Win.Spread.SheetView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_purNo = new C1.Win.C1List.C1Combo();
            this.lbl_purNo = new System.Windows.Forms.Label();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainSheet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.GridDefinition = "17.4:False:True;73.4:False:False;6:False:True;\t0.505050505050505:False:True;96.96" +
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
            this.pnl_menu.TabIndex = 172;
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
            // spd_main
            // 
            this.spd_main.ContextMenu = this.cmenu_Purchase;
            this.spd_main.Location = new System.Drawing.Point(12, 95);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this._mainSheet);
            this.spd_main.Size = new System.Drawing.Size(768, 367);
            this.spd_main.TabIndex = 171;
            // 
            // cmenu_Purchase
            // 
            this.cmenu_Purchase.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuitem_SelectAll,
            this.menuitem_SelectCheck,
            this.menuItem1,
            this.menuitem_DeSelectAll,
            this.menuitem_DeSelectCheck});
            this.cmenu_Purchase.Popup += new System.EventHandler(this.cmenu_Purchase_Popup);
            // 
            // menuitem_SelectAll
            // 
            this.menuitem_SelectAll.Index = 0;
            this.menuitem_SelectAll.Text = "Select All";
            this.menuitem_SelectAll.Click += new System.EventHandler(this.menuitem_SelectAll_Click);
            // 
            // menuitem_SelectCheck
            // 
            this.menuitem_SelectCheck.Index = 1;
            this.menuitem_SelectCheck.Text = "Select Check";
            this.menuitem_SelectCheck.Click += new System.EventHandler(this.menuitem_SelectCheck_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // menuitem_DeSelectAll
            // 
            this.menuitem_DeSelectAll.Index = 3;
            this.menuitem_DeSelectAll.Text = "Deselect All";
            this.menuitem_DeSelectAll.Click += new System.EventHandler(this.menuitem_DeSelectAll_Click);
            // 
            // menuitem_DeSelectCheck
            // 
            this.menuitem_DeSelectCheck.Index = 4;
            this.menuitem_DeSelectCheck.Text = "Deselect Check";
            this.menuitem_DeSelectCheck.Click += new System.EventHandler(this.menuitem_DeSelectCheck_Click);
            // 
            // _mainSheet
            // 
            this._mainSheet.SheetName = "Sheet1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmb_purNo);
            this.panel1.Controls.Add(this.lbl_purNo);
            this.panel1.Controls.Add(this.cmb_user);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.lbl_vendor);
            this.panel1.Controls.Add(this.txt_vendorCode);
            this.panel1.Controls.Add(this.cmb_vendor);
            this.panel1.Controls.Add(this.cmb_factory);
            this.panel1.Controls.Add(this.lbl_factory);
            this.panel1.Controls.Add(this.lbl_shipDate);
            this.panel1.Controls.Add(this.lblexcep_mark);
            this.panel1.Controls.Add(this.dpick_to);
            this.panel1.Controls.Add(this.dpick_from);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 87);
            this.panel1.TabIndex = 170;
            // 
            // cmb_purNo
            // 
            this.cmb_purNo.AddItemCols = 0;
            this.cmb_purNo.AddItemSeparator = ';';
            this.cmb_purNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purNo.Caption = "";
            this.cmb_purNo.CaptionHeight = 17;
            this.cmb_purNo.CaptionStyle = style1;
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
            this.cmb_purNo.EvenRowStyle = style2;
            this.cmb_purNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purNo.FooterStyle = style3;
            this.cmb_purNo.GapHeight = 2;
            this.cmb_purNo.HeadingStyle = style4;
            this.cmb_purNo.HighLightRowStyle = style5;
            this.cmb_purNo.ItemHeight = 15;
            this.cmb_purNo.Location = new System.Drawing.Point(448, 15);
            this.cmb_purNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_purNo.MaxDropDownItems = ((short)(5));
            this.cmb_purNo.MaxLength = 32767;
            this.cmb_purNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purNo.Name = "cmb_purNo";
            this.cmb_purNo.OddRowStyle = style6;
            this.cmb_purNo.PartialRightColumn = false;
            this.cmb_purNo.PropBag = resources.GetString("cmb_purNo.PropBag");
            this.cmb_purNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purNo.SelectedStyle = style7;
            this.cmb_purNo.Size = new System.Drawing.Size(220, 20);
            this.cmb_purNo.Style = style8;
            this.cmb_purNo.TabIndex = 379;
            this.cmb_purNo.SelectedValueChanged += new System.EventHandler(this.cmb_purNo_SelectedValueChanged);
            // 
            // lbl_purNo
            // 
            this.lbl_purNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purNo.ImageIndex = 0;
            this.lbl_purNo.ImageList = this.img_Label;
            this.lbl_purNo.Location = new System.Drawing.Point(346, 15);
            this.lbl_purNo.Name = "lbl_purNo";
            this.lbl_purNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_purNo.TabIndex = 378;
            this.lbl_purNo.Text = "Purchase No";
            this.lbl_purNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmb_user.Location = new System.Drawing.Point(110, 59);
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
            this.lbl_user.Location = new System.Drawing.Point(8, 59);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_user.TabIndex = 370;
            this.lbl_user.Text = "User";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(346, 37);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 368;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(448, 37);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 366;
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
            this.cmb_vendor.Location = new System.Drawing.Point(528, 37);
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
            this.cmb_vendor.TabIndex = 367;
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
            this.cmb_factory.Location = new System.Drawing.Point(110, 15);
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
            this.lbl_factory.Location = new System.Drawing.Point(8, 15);
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
            this.lbl_shipDate.Location = new System.Drawing.Point(8, 37);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 52;
            this.lbl_shipDate.Text = "Incoming Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(216, 37);
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
            this.dpick_to.Location = new System.Drawing.Point(230, 37);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 5;
            this.dpick_to.ValueChanged += new System.EventHandler(this.dpick_to_ValueChanged);
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(110, 37);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 4;
            this.dpick_from.ValueChanged += new System.EventHandler(this.dpick_from_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 87);
            this.groupBox1.TabIndex = 380;
            this.groupBox1.TabStop = false;
            // 
            // Pop_BI_Incoming_Purchase
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 558);
            this.Controls.Add(this.c1Sizer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pop_BI_Incoming_Purchase";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainSheet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
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

		private void cmenu_Purchase_Popup(object sender, System.EventArgs e)
		{
			try
			{
				// 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
				Set_MenuItem_Visible();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Purchase_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

  		
		/// <summary>
		/// Set_MenuItem_Visible : 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
		/// </summary>
		private void Set_MenuItem_Visible()
		{
			this.menuitem_DeSelectAll.Visible		= true;
			this.menuitem_SelectAll.Visible		= true;
		}


		private void menuitem_SelectCheck_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Select_Check();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_SelectCheck_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuitem_DeSelectCheck_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				DeSelect_All();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_DeSelectCheck_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

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
		/// Select_Check : 입고될 수량이 있는 Row
		/// </summary>
		private void Select_Check()
		{ 
			
			for(int i = 0; i < _mainSheet.RowCount; i++)
			{
				if (_mainSheet.Cells[i, _lxInQtyCol].Value.ToString()  != _mainSheet.Cells[i, _lxPurQtyCol].Value.ToString())
				{
					_mainSheet.Cells[i, _lxChkCol].Value = true;
					_mainSheet.AddSelection(i, 0, i, _mainSheet.ColumnCount);
				}

			} 
		}



		/// <summary>
		/// DeSelect_Check :입고될 수량이 있는 Row 풀기 
		/// </summary>
		private void DeSelect_Check()
		{ 
			for(int i = 0; i < _mainSheet.RowCount; i++)
			{
				if (_mainSheet.Cells[i, _lxInQtyCol].Value.ToString()  != _mainSheet.Cells[i, _lxPurQtyCol].Value.ToString())
				{
					_mainSheet.Cells[i, _lxChkCol].Value = true;
					_mainSheet.RemoveSelection(i, 0, i, _mainSheet.ColumnCount);
				}

			} 
		}


		/// <summary>
		/// Select_All : 모든 Row 선택
		/// </summary>
		private void Select_All()
		{ 
			_mainSheet.AddSelection(0, 1, _mainSheet.RowCount, _mainSheet.ColumnCount);
			for(int i = 0; i < _mainSheet.RowCount; i++)
			{
				if (!_mainSheet.Rows[i].Locked)
					_mainSheet.Cells[i, _lxChkCol].Value = true;
			} 
		}

		/// <summary>
		/// DeSelect_All : 모든 Row 해제
		/// </summary>
		private void DeSelect_All()
		{ 
			_mainSheet.RemoveSelection(0, 1, _mainSheet.RowCount, _mainSheet.ColumnCount);
			for(int i = 0; i < _mainSheet.RowCount; i++)
			{
				_mainSheet.Cells[i, _lxChkCol].Value = false;
			} 
		}

//		/// <summary>
//		/// Select_Selection : 선택한 Row 선택
//		/// </summary>
//		private void Select_Selection()
//		{ 
//			CellRange vSelectionRange = _mainSheet.GetSelection(0);
//
//			if (vSelectionRange != null)
//			{
//				for (int i = vSelectionRange.Row ; i < vSelectionRange.Row + vSelectionRange.RowCount ; i++)
//				{
//					_mainSheet.Cells[i, _lxChkCol].Value = true;
//				}
//			} 
//		}
//
//		/// <summary>
//		/// DeSelect_Selection : 선택한 Row 해제
//		/// </summary>
//		private void DeSelect_Selection()
//		{ 
//			CellRange vSelectionRange = _mainSheet.GetSelection(0);
//
//			if (vSelectionRange != null)
//			{
//				for (int i = vSelectionRange.Row ; i < vSelectionRange.Row + vSelectionRange.RowCount ; i++)
//				{
//					spd_main.ActiveSheet.Cells[i, _lxChkCol].Value = false;
//				}
//			} 
//		}

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
				this.Return_Data();
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
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

		private void Cmb_purNoSettingProcess()
		{
			try
			{
				if (_practicable)
				{
					cmb_purNo.SelectedValueChanged -= _cmbPurNoEventHandler;

					spd_main.ClearAll();
					string[] vProviso = GetSearchProviso();
					DataTable vDt = SELECT_SBI_PUR_NO(vProviso[0], vProviso[1], vProviso[2]);
			        //COM.ComCtl.Set_ComboList(vDt, cmb_purNo, 0, 1, true, false);
					COM.ComCtl.Set_ComboList_AddItem(vDt, cmb_purNo, 0, 1, true, cmb_purNo.Width - 10, 0);
					cmb_purNo.SelectedIndex = 0;
					vDt.Dispose();

					cmb_purNo.SelectedValueChanged += _cmbPurNoEventHandler;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void cmb_purNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_purNoSelectedValueChangedProcess();	
		}

		private void txt_vendorCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
			{
				Txt_VendorCodeTextChangedProcess();		
				ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
			}
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_purNoSettingProcess();		
		}

		private void dpick_from_ValueChanged(object sender, System.EventArgs e)
		{
			dpick_to.Value = dpick_from.Value; 
			this.Cmb_purNoSettingProcess();								
		}

		private void dpick_to_ValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_purNoSettingProcess();						
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

	

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
//			ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Incoming Purchase";
            this.Text = "Incoming Purchase";
            ClassLib.ComFunction.SetLangDic(this);

			_practicable = true;

			// Grid Setting
			spd_main.Set_Spread_Comm("SBI_INCOMING_PUR", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

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

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// cmb_user
			vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory);
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_user,1,2,(vDt.Rows.Count > 1) ? true : false);
			cmb_user.SelectedIndex = 0;
			vDt.Dispose();

			// default search proviso
			_practicable = false;
			if (COM.ComVar.Parameter_PopUp[0].ToString() != "")
			cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
			dpick_from.Value			= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
			dpick_to.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
			COM.ComVar.Parameter_PopUp.Initialize(); 
			_practicable = true;
			this.Cmb_purNoSettingProcess();						
			
			// user define variable setting
			_cmbPurNoEventHandler		= new System.EventHandler(this.cmb_purNo_SelectedValueChanged);

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
			_DT = null;
			_DT = new DataTable("Purchase");

			// 메인 데이터 
			for(int i = 0; i <= (int)ClassLib.TBSBI_IN_TAIL.IxUPD_YMD; i++)
			{
				_DT.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			}
		}

		private void Btn_SearchClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = this.SELECT_SBI_PURCHASE_LIST();

				if (vDt.Rows.Count > 0)
				{
					spd_main.Display_Grid(vDt);

					for ( int i = 0; i < _mainSheet.Rows.Count; i++)
					{

						
						if (Convert.ToInt32(_mainSheet.Cells[i, _lxInQtyCol].Value) >0 )
						{
							_mainSheet.Cells[i, _lxInChkCol].Value = true;
						}



												

						if (_mainSheet.Cells[i, _lxCheckPurCol].Value.ToString() == "R")
						{
							_mainSheet.Cells[i, _lxPurCurrencyCol].ForeColor = COM.ComVar.ClrError; 
							_mainSheet.Rows[i].Locked	= true;
						}

						if (_mainSheet.Cells[i, _lxCheckCbdCol].Value.ToString() == "R")
						{
							_mainSheet.Cells[i, _lxCbdCurrencyCol].ForeColor = COM.ComVar.ClrError; 
							_mainSheet.Rows[i].Locked	= true;
						}

						if (_mainSheet.Cells[i, _lxCheckOutsideCol].Value.ToString() == "R")
						{
							_mainSheet.Cells[i, _lxOutsideCurrencyCol].ForeColor = COM.ComVar.ClrError; 
							_mainSheet.Rows[i].Locked	= true;
						}
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
				arg_grid.Update_Row(img_Action) ;
			}
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				spd_main.ClearAll();
				this.cmb_user.SelectedIndex			= -1;
//				this.cmb_vendor.SelectedIndex		= -1;
				this.txt_vendorCode.Text			= "";
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}
		
		private void Cmb_purNoSelectedValueChangedProcess()
		{
			try
			{
				if (cmb_purNo.SelectedIndex > 0)
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

				vDt = FlexPurchase.ClassLib.ComFunction.SELECT_WAREHOUSE_LIST_USING(ClassLib.ComVar.This_Factory);
				
				COM.ComVar.Parameter_PopUp[1]	= "Select INcoming WareHouse";
				COM.ComVar.Parameter_PopUp[0]	= "WareHouse";

				ClassLib.ComVar.Parameter_PopUpTable = vDt;
				vDt.Dispose();

				Pop_BI_Incoming_List_Changer pop_changer = new Pop_BI_Incoming_List_Changer();
				pop_changer.ShowDialog();

				if (COM.ComVar.Parameter_PopUp != null)
				{
					_vWhCd = COM.ComVar.Parameter_PopUp[0];

					pop_changer.Dispose();

					Make_DT(); 
//					bool vBool = Make_DT(); 

//					ClassLib.ComVar.Parameter_PopUp = new string[] {_invNo, _lcNo};

//					if (vBool) this.Close();
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
				CellRange[] vSelectionRange = _mainSheet.GetSelections(); 

				Create_DataTable();
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
							if ( _lcNo == "" && _invNo == "" )
							{
								_lcNo = spd_main.ActiveSheet.Cells[i, _lxLcNoCol].Value.ToString();
								_invNo = spd_main.ActiveSheet.Cells[i, _lxInvNoCol].Value.ToString();
							}

							datarow = _DT.NewRow();

							datarow[_ldFactoryCol]		= spd_main.ActiveSheet.Cells[i, _lxFactoryCol].Value.ToString();
							datarow[_ldItemCdCol]		= spd_main.ActiveSheet.Cells[i, _lxItemCdCol].Value.ToString();
							datarow[_ldItemNameCol]		= spd_main.ActiveSheet.Cells[i, _lxItemNameCol].Value.ToString();
							datarow[_ldSpecCdCol]		= spd_main.ActiveSheet.Cells[i, _lxSpecCdCol].Value.ToString();
							datarow[_ldSpecNameCol]		= spd_main.ActiveSheet.Cells[i, _lxSpecNameCol].Value.ToString();
							datarow[_ldColorCdCol]		= spd_main.ActiveSheet.Cells[i, _lxColorCdCol].Value.ToString();
							datarow[_ldColorNameCol]	= spd_main.ActiveSheet.Cells[i, _lxColorNameCol].Value.ToString();
							datarow[_ldInQtyCol]		= spd_main.ActiveSheet.Cells[i, _lxPurQtyCol].Value.ToString();
							datarow[_ldUnitCol]			= spd_main.ActiveSheet.Cells[i, _lxUnitCol].Value.ToString();
							datarow[_ldOutsideCurrencyCol]	= spd_main.ActiveSheet.Cells[i, _lxOutsideCurrencyCol].Value.ToString();
							datarow[_ldPkUnitQtyCol]	= spd_main.ActiveSheet.Cells[i, _lxOutsidePriceCol].Value.ToString();
							datarow[_ldPurCurrencyCol]	= spd_main.ActiveSheet.Cells[i, _lxPurCurrencyCol].Value.ToString();
							datarow[_ldPurPriceCol]		= spd_main.ActiveSheet.Cells[i, _lxPurPriceCol].Value.ToString();
							datarow[_ldOutsidePriceCol]	= spd_main.ActiveSheet.Cells[i, _lxOutsidePriceCol].Value.ToString();
							datarow[_ldCbdCurrencyCol]	= spd_main.ActiveSheet.Cells[i, _lxCbdCurrencyCol].Value.ToString();
							datarow[_ldCbdPriceCol]		= spd_main.ActiveSheet.Cells[i, _lxCbdPriceCol].Value.ToString();
							datarow[_ldCustCdCol]		= spd_main.ActiveSheet.Cells[i, _lxCustCdCol].Value.ToString();
							datarow[_ldCustNameCol]		= spd_main.ActiveSheet.Cells[i, _lxCustNameCol].Value.ToString();
							datarow[_ldTaxCdCol]		= spd_main.ActiveSheet.Cells[i, _lxTaxCdCol].Value.ToString();
							datarow[_ldShipQtyCol]		= spd_main.ActiveSheet.Cells[i, _lxShipQtyCol].Value.ToString();
							datarow[_ldShipNoCol]		= spd_main.ActiveSheet.Cells[i, _lxShipNoCol].Value.ToString();
							datarow[_ldShipYmdCol]		= spd_main.ActiveSheet.Cells[i, _lxShipYmdCol].Value.ToString();
							datarow[_ldStyleCdCol]		= spd_main.ActiveSheet.Cells[i, _lxStyleCdCol].Value.ToString();
							datarow[_ldStyleNameCol]	= spd_main.ActiveSheet.Cells[i, _lxStyleNameCol].Value.ToString();
							datarow[_ldPayCdCol]		= spd_main.ActiveSheet.Cells[i, _lxPayCdCol].Value.ToString();
							datarow[_ldPurNoCol]		= spd_main.ActiveSheet.Cells[i, _lxPurNoCol].Value.ToString();
							datarow[_ldPurSeqCol]		= spd_main.ActiveSheet.Cells[i, _lxPurSeqCol].Value.ToString();
							datarow[_ldPurUserCol]		= spd_main.ActiveSheet.Cells[i, _lxPurUserCol].Value.ToString();
							datarow[_ldPurDeptCol]		= spd_main.ActiveSheet.Cells[i, _lxPurDeptCol].Value.ToString();
							datarow[_ldPriceYnCol]		= spd_main.ActiveSheet.Cells[i, _lxPriceYNCol].Value.ToString();
							datarow[_ldWhCdCol]			= _vWhCd;
							datarow[_ldTranDivCol]		= "P";


							// 정환정 추가
							datarow[_ldLedgerPriceCol]		= "0";
							datarow[_ldLedgerCurrencyCol]		= "";


							//추가
							//datarow[_ldLotNoCol]        = spd_main.ActiveSheet.Cells[i, _lxLotNoCol].Value.ToString();
							//datarow[_ldLotSCol]         = spd_main.ActiveSheet.Cells[i, _lxLotSeqCol].Value.ToString();
					
							_DT.Rows.Add(datarow); 								
							Apply_Grid(_DT); 

							COM.ComVar.Parameter_PopUp = new string [2];

							COM.ComVar.Parameter_PopUp[0] = _invNo;				
							COM.ComVar.Parameter_PopUp[1] = _lcNo;
	
							_DT.Rows.Clear();
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
					ClassLib.ComVar.Parameter_PopUp = new string[] {_invNo, _lcNo};
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Return_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 				
		}




		/// <summary>
		/// Apply_Grid : 팝업에서 parameter로 넘겨받은 데이타를 그리드에 추가한다. 
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_dt_tail"></param> 
		/// <param name="arg_row"></param>
		private void Apply_Grid(DataTable arg_dt )
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				// 그리드에 새로운 Row를 추가하고 parameter값을 insert 한다.
				fgrid_main.Display_Grid_Add(arg_dt, false); 

				if (fgrid_main.Rows.Count > 0 && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
				{
					// head Setting
					_practicable	= false;				
					this.cmb_factory.SelectedValue	= fgrid_main[fgrid_main.Rows.Fixed, _factoryCol].ToString().Trim();
					_practicable	= true;				
			
					int vRow   = fgrid_main.Rows.Count - arg_dt.Rows.Count; 
					int vInSeq = 0;
 
					// SBI_IN_TAIL의 IN_SEQ 값을 부여한다. (보여지는 SEQ 값과는 별개의 값이다.)
					if (!vRow.Equals(fgrid_main.Rows.Fixed))
						vInSeq = int.Parse(fgrid_main[vRow -1, _inSeqCol].ToString().Trim());

					// Insert Flag를 붙인다.
					for (int i = vRow; i < fgrid_main.Rows.Count; i++)
					{
						vInSeq = vInSeq +1;
						fgrid_main[i,0] =  ClassLib.ComVar.Insert;	
						fgrid_main[i,_inSeqCol] = vInSeq;
					}

					for ( int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++ )
					{
						fgrid_main[row, _seqCol]	 = row +1 - fgrid_main.Rows.Fixed;
						fgrid_main[row, _modQtyCol]  = fgrid_main[row, _inQtyCol];

						for (int vCol = 1 ; vCol < fgrid_main.Cols.Count; vCol++)
						{
							if ( fgrid_main.Cols[vCol].AllowEditing )
								fgrid_main.GetCellRange(vRow, vCol).StyleNew.ForeColor = COM.ComVar.ClrImportant;
						}
					}

					//ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				//else
					//ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
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



	
		private int Etc_DataDuplicateCheck_FSP(int arg_row)
		{
			int vReturn = 0;

			for ( int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++ )
			{
				if( fgrid_main[vRow, _checkCols[0]].ToString().Replace("-", "").Equals(_mainSheet.Cells[arg_row, _lxStyleCdCol].Value.ToString()) &&
					fgrid_main[vRow, _checkCols[1]].ToString().Equals(_mainSheet.Cells[arg_row, _lxItemCdCol].Value.ToString()) &&
					fgrid_main[vRow, _checkCols[2]].ToString().Equals(_mainSheet.Cells[arg_row, _lxSpecCdCol].Value.ToString()) &&
					fgrid_main[vRow, _checkCols[3]].ToString().Equals(_mainSheet.Cells[arg_row, _lxColorCdCol].Value.ToString()) &&
					fgrid_main[vRow, _checkCols[4]].ToString().Equals(_mainSheet.Cells[arg_row, _lxPurNoCol].Value.ToString())) 
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
		/// PKG_SBS_SHIPPING_HEAD : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_ship_ymd_from">선적일(From)</param>
		/// <param name="arg_ship_ymd_to">선적일(To)</param>
		/// <param name="arg_size">Size Item</param>
		/// <param name="arg_ship_type">선적구분</param>
		/// <param name="arg_obs_type">OBS Type</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_PURCHASE_LIST()
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_PURCHASE.SELECT_SBS_PUR_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_TO";
			MyOraDB.Parameter_Name[3] = "ARG_PUR_NO";
			MyOraDB.Parameter_Name[4] = "ARG_USER";
			MyOraDB.Parameter_Name[5] = "ARG_VENDOR";
			MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(this.cmb_factory, "");
			MyOraDB.Parameter_Values[1] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(this.cmb_purNo, "");
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(this.cmb_user, "");
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_Combo(this.cmb_vendor, "");
			MyOraDB.Parameter_Values[6] = COM.ComVar.This_User;
			MyOraDB.Parameter_Values[7] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}	
			/// <summary>
			/// PKG_SBI_IN_PURCHASE : 
			/// </summary>
			/// <param name="arg_factory">공장</param>
			/// <returns>DataTable</returns>
			/// <summary>
			/// PKG_SBI_IN_PURCHASE : 
			/// </summary>
			/// <returns>DataTable</returns>
			public DataTable SELECT_SBI_PUR_NO(string arg_factory, string arg_from, string arg_to)
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBI_IN_PURCHASE.SELECT_SBI_PUR_NO";

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

