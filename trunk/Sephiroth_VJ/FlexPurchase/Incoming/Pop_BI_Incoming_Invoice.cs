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
	public class Pop_BI_Incoming_Invoice : COM.PCHWinForm.Pop_Large
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
		private System.Windows.Forms.Label lbl_itemGroup;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txt_styleCd;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label lbl_styleCd;
		private C1.Win.C1List.C1Combo cmb_barMove;
		private System.Windows.Forms.Label lbl_barMove;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.ContextMenu cmenu_Grid;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem_SelectCR;
		private System.Windows.Forms.MenuItem menuItem_DeselectCR;
		private System.Windows.Forms.MenuItem menuitem_SelectAll;
		private System.Windows.Forms.MenuItem menuitem_DeSelectAll;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction();

		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private string _lcNo  = "";
		private string _invNo = "";
		private string _vWhCd = "";
		
		private COM.FSP fgrid_main;
		private int[] _checkCols;
		private string _Division = "";

		
		//메인창으로 리턴될 데이터 테이블
		public DataTable _DT;  

		private int _lxChkCol           = (int)ClassLib.TBSBI_INCOMING_INVOICE.IxCHK;
		private int _lxItemCdCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxITEM_CD;
		private int _lxItemNameCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxITEM_NAME; 
		private int _lxSpecCdCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxSPEC_CD; 
		private int _lxSpecNameCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxSPEC_NAME; 
		private int _lxColorCdCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxCOLOR_CD;
		private int _lxColorNameCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxCOLOR_NAME;
		private int _lxInQtyCol			= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxIN_QTY;
		private int _lxLcNoCol			= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxLC_NO;
		private int _lxInvNoCol			= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxINV_NO;
		private int _lxFactoryCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxFACTORY;
		private int _lxShipYmdCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxSHIP_YMD;
		private int _lxShipNoCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxSHIP_NO; 
		private int _lxShipSeqCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxSHIP_SEQ; 
		private int _lxShipQtyCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxSHIP_QTY; 
		private int _lxUnitCol			= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxUNIT; 
		private int _lxLotNoCol			= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxLOT_NO;
		private int _lxContNoCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxCONT_NO; 
		private int _lxCustCdCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxCUST_CD;
		private int _lxCustNameCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxCUST_NAME;
		private int _lxStyleCdCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxSTYLE_CD;
		private int _lxStyleNameCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxSTYLE_NAME;  
		private int _lxPkUnitCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxPK_QTY; 
		private int _lxTradePriceCol	= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxTRADE_PRICE; 
		private int _lxCBDPriceCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxCBD_PRICE; 
		private int _lxSellPriceCol		= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxSELL_PRICE; 
		private int _lxLedgerPriceCol	= (int)ClassLib.TBSBI_INCOMING_INVOICE.IxLEDGER_PRICE; 
		  
	
		private int _ldFactoryCol	= (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY -1;
		private int _ldItemCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxITEM_CD -1;
		private int _ldItemNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxITEM_NAME -1;
		private int _ldSpecCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSPEC_CD -1;
		private int _ldSpecNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSPEC_NAME -1;
		private int _ldColorCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCOLOR_CD -1;
		private int _ldColorNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCOLOR_NAME -1;
		private int _ldInQtyCol		= (int)ClassLib.TBSBI_IN_TAIL.IxIN_QTY -1;
		private int _ldUnitCol		= (int)ClassLib.TBSBI_IN_TAIL.IxUNIT -1;
		private int _IdPurCurrencyCol = (int)ClassLib.TBSBI_IN_TAIL.IxPUR_CURRENCY - 1;
		private int _IdPurPriceCol = (int)ClassLib.TBSBI_IN_TAIL.IxPUR_PRICE - 1;
		private int _ldCustCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCUST_CD -1;
		private int _ldCustNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCUST_NAME -1;
		private int _ldCbdCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCBD_CURRENCY -1; 
		private int _ldCbdPriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCBD_PRICE -1; 
		private int _ldShipCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_CURRENCY -1;
		private int _ldShipPriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_PRICE -1;
		private int _ldLedgerCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_CURRENCY -1;
		private int _ldLedgerPriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_PRICE -1;
		private int _ldPriceYNCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPRICE_YN -1;
		private int _ldContNoCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCONT_NO -1;
		private int _ldShipYmdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_YMD -1;
		private int _ldShipNoCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_NO -1;
		private int _ldShipSeqCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_SEQ -1;
		private int _ldShipQtyCol   = (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_QTY -1;
		private int _ldLOTNoCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLOT_NO -1;
		private int _ldLOTSeqCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLOT_SEQ -1;
		private int _ldStyleCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSTYLE_CD -1;
		private int _ldStyleNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSTYLE_NAME -1;
		private int _ldTranDivCol	= (int)ClassLib.TBSBI_IN_TAIL.IxTRAN_DIV -1; 
		private int _ldWhCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxWH_CD -1;   
		private int _ldPurDivCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_DIV -1;
		private int _ldBuyDivCol	= (int)ClassLib.TBSBI_IN_TAIL.IxBUY_DIV -1;
		private int _ldPKUnitCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPK_UNIT_QTY -1;
  
  
		//Incoming에 뿌리기 위한 int
		private int _factoryCol     = (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY;
		private int _inSeqCol       = (int)ClassLib.TBSBI_IN_TAIL.IxIN_SEQ;
		private int _modQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxMOD_QTY;
		private int _seqCol				= (int)ClassLib.TBSBI_IN_TAIL.IxSEQ;
		private int _inQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxIN_QTY;
		private System.Windows.Forms.TextBox txt_Invoice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_total;
		private System.Windows.Forms.Label label2;
		private bool _practicable	= false;


		



		#endregion
		
		#region 생성자 / 소멸자
		
		
		public Pop_BI_Incoming_Invoice(Control arg_grid, int[] arg_checks)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			fgrid_main = (COM.FSP)arg_grid;

			_checkCols = arg_checks;
		}



		public Pop_BI_Incoming_Invoice(string arg_division, Control arg_grid, int[] arg_checks)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			fgrid_main = (COM.FSP)arg_grid;

			_checkCols = arg_checks;


			// return datatable 만들 때, 해외용 따로 구성하기 위함
			_Division = arg_division;




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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BI_Incoming_Invoice));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.lbl_styleCd = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_itemGroup = new System.Windows.Forms.Label();
            this.cmb_barMove = new C1.Win.C1List.C1Combo();
            this.lbl_barMove = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Invoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.spd_main = new COM.SSP();
            this.cmenu_Grid = new System.Windows.Forms.ContextMenu();
            this.menuitem_SelectAll = new System.Windows.Forms.MenuItem();
            this.menuitem_DeSelectAll = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem_SelectCR = new System.Windows.Forms.MenuItem();
            this.menuItem_DeselectCR = new System.Windows.Forms.MenuItem();
            this._mainSheet = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_barMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
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
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "24.2:False:True;66.6:False:False;6:False:True;\t0.505050505050505:False:True;96.96" +
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
            this.pnl_menu.TabIndex = 171;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(684, 3);
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
            this.btn_apply.Location = new System.Drawing.Point(603, 3);
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
            this.panel1.Controls.Add(this.txt_styleCd);
            this.panel1.Controls.Add(this.cmb_style);
            this.panel1.Controls.Add(this.lbl_styleCd);
            this.panel1.Controls.Add(this.lbl_item);
            this.panel1.Controls.Add(this.lbl_itemGroup);
            this.panel1.Controls.Add(this.cmb_barMove);
            this.panel1.Controls.Add(this.lbl_barMove);
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
            this.panel1.Size = new System.Drawing.Size(768, 121);
            this.panel1.TabIndex = 169;
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCd.Location = new System.Drawing.Point(110, 58);
            this.txt_styleCd.MaxLength = 10;
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCd.TabIndex = 420;
            this.txt_styleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCd_KeyUp);
            // 
            // cmb_style
            // 
            this.cmb_style.AddItemCols = 0;
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style1;
            this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_style.ColumnCaptionHeight = 18;
            this.cmb_style.ColumnFooterHeight = 18;
            this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_style.ContentHeight = 16;
            this.cmb_style.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_style.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_style.EditorHeight = 16;
            this.cmb_style.EvenRowStyle = style2;
            this.cmb_style.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style3;
            this.cmb_style.GapHeight = 2;
            this.cmb_style.HeadingStyle = style4;
            this.cmb_style.HighLightRowStyle = style5;
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(190, 58);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style6;
            this.cmb_style.PartialRightColumn = false;
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style7;
            this.cmb_style.Size = new System.Drawing.Size(140, 20);
            this.cmb_style.Style = style8;
            this.cmb_style.TabIndex = 417;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            // 
            // lbl_styleCd
            // 
            this.lbl_styleCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_styleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_styleCd.ImageIndex = 0;
            this.lbl_styleCd.ImageList = this.img_Label;
            this.lbl_styleCd.Location = new System.Drawing.Point(8, 58);
            this.lbl_styleCd.Name = "lbl_styleCd";
            this.lbl_styleCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_styleCd.TabIndex = 416;
            this.lbl_styleCd.Text = "Style";
            this.lbl_styleCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(344, 58);
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
            this.lbl_itemGroup.Location = new System.Drawing.Point(344, 36);
            this.lbl_itemGroup.Name = "lbl_itemGroup";
            this.lbl_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemGroup.TabIndex = 371;
            this.lbl_itemGroup.Text = "Item Group";
            this.lbl_itemGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_barMove
            // 
            this.cmb_barMove.AddItemCols = 0;
            this.cmb_barMove.AddItemSeparator = ';';
            this.cmb_barMove.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_barMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_barMove.Caption = "";
            this.cmb_barMove.CaptionHeight = 17;
            this.cmb_barMove.CaptionStyle = style9;
            this.cmb_barMove.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_barMove.ColumnCaptionHeight = 18;
            this.cmb_barMove.ColumnFooterHeight = 18;
            this.cmb_barMove.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_barMove.ContentHeight = 16;
            this.cmb_barMove.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_barMove.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_barMove.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_barMove.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_barMove.EditorHeight = 16;
            this.cmb_barMove.EvenRowStyle = style10;
            this.cmb_barMove.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_barMove.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barMove.FooterStyle = style11;
            this.cmb_barMove.GapHeight = 2;
            this.cmb_barMove.HeadingStyle = style12;
            this.cmb_barMove.HighLightRowStyle = style13;
            this.cmb_barMove.ItemHeight = 15;
            this.cmb_barMove.Location = new System.Drawing.Point(446, 14);
            this.cmb_barMove.MatchEntryTimeout = ((long)(2000));
            this.cmb_barMove.MaxDropDownItems = ((short)(5));
            this.cmb_barMove.MaxLength = 32767;
            this.cmb_barMove.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_barMove.Name = "cmb_barMove";
            this.cmb_barMove.OddRowStyle = style14;
            this.cmb_barMove.PartialRightColumn = false;
            this.cmb_barMove.PropBag = resources.GetString("cmb_barMove.PropBag");
            this.cmb_barMove.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_barMove.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_barMove.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_barMove.SelectedStyle = style15;
            this.cmb_barMove.Size = new System.Drawing.Size(223, 20);
            this.cmb_barMove.Style = style16;
            this.cmb_barMove.TabIndex = 184;
            // 
            // lbl_barMove
            // 
            this.lbl_barMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_barMove.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barMove.ImageIndex = 0;
            this.lbl_barMove.ImageList = this.img_Label;
            this.lbl_barMove.Location = new System.Drawing.Point(344, 14);
            this.lbl_barMove.Name = "lbl_barMove";
            this.lbl_barMove.Size = new System.Drawing.Size(100, 21);
            this.lbl_barMove.TabIndex = 182;
            this.lbl_barMove.Text = "Barcode Move";
            this.lbl_barMove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style19;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style20;
            this.cmb_factory.HighLightRowStyle = style21;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(110, 14);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style22;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style23;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style24;
            this.cmb_factory.TabIndex = 1;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 14);
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
            this.lbl_shipDate.Location = new System.Drawing.Point(8, 36);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 52;
            this.lbl_shipDate.Text = "Invoice Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(216, 41);
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
            this.dpick_to.Location = new System.Drawing.Point(231, 36);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 5;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(110, 36);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 4;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Invoice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_itemGroup);
            this.groupBox1.Controls.Add(this.cmb_itemGroup);
            this.groupBox1.Controls.Add(this.txt_itemName);
            this.groupBox1.Controls.Add(this.txt_itemCode);
            this.groupBox1.Controls.Add(this.btn_groupSearch);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 112);
            this.groupBox1.TabIndex = 421;
            this.groupBox1.TabStop = false;
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_total.Location = new System.Drawing.Point(446, 80);
            this.txt_total.MaxLength = 10;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(223, 21);
            this.txt_total.TabIndex = 445;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(344, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 444;
            this.label2.Text = "Q\'ty / Amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Invoice
            // 
            this.txt_Invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Invoice.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Invoice.Location = new System.Drawing.Point(110, 80);
            this.txt_Invoice.MaxLength = 30;
            this.txt_Invoice.Name = "txt_Invoice";
            this.txt_Invoice.Size = new System.Drawing.Size(220, 21);
            this.txt_Invoice.TabIndex = 443;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 442;
            this.label1.Text = "Invoice No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(547, 36);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.txt_itemGroup.TabIndex = 440;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style25;
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
            this.cmb_itemGroup.EvenRowStyle = style26;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style27;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style28;
            this.cmb_itemGroup.HighLightRowStyle = style29;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(446, 36);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style30;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style31;
            this.cmb_itemGroup.Size = new System.Drawing.Size(100, 20);
            this.cmb_itemGroup.Style = style32;
            this.cmb_itemGroup.TabIndex = 439;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(506, 58);
            this.txt_itemName.MaxLength = 50;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(163, 21);
            this.txt_itemName.TabIndex = 441;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(446, 58);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCode.TabIndex = 437;
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(647, 36);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 438;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spd_main
            // 
            this.spd_main.ContextMenu = this.cmenu_Grid;
            this.spd_main.Location = new System.Drawing.Point(12, 129);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this._mainSheet);
            this.spd_main.Size = new System.Drawing.Size(768, 333);
            this.spd_main.TabIndex = 0;
            // 
            // cmenu_Grid
            // 
            this.cmenu_Grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuitem_SelectAll,
            this.menuitem_DeSelectAll,
            this.menuItem3,
            this.menuItem_SelectCR,
            this.menuItem_DeselectCR});
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
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
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
            // Pop_BI_Incoming_Invoice
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 558);
            this.Controls.Add(this.c1Sizer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pop_BI_Incoming_Invoice";
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_barMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
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
			//this.spd_main.Update_Row(img_Action);
		}

		#endregion

		#region 컨텍스트(팝업) 메뉴 이벤트

		private void cmenu_Invoice_Popup(object sender, System.EventArgs e)
		{
			try
			{
				// 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
				Set_MenuItem_Visible();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Invoice_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

  		
		/// <summary>
		/// Set_MenuItem_Visible : 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
		/// </summary>
		private void Set_MenuItem_Visible()
		{
			this.menuitem_DeSelectAll.Visible			= true;
			this.menuitem_SelectAll.Visible			= true;
		}
 

		private void menuitem_SelectAll_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Select_SelectionAll(true);
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
				Select_SelectionAll(false);
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



		private void Select_SelectionAll(bool arg_select)
		{ 
			for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
			{
				if(spd_main.ActiveSheet.Rows[i].Locked) continue;
				spd_main.ActiveSheet.Cells[i, _lxChkCol].Value = arg_select;
			} 
		}


		private void Select_SelectionRange(bool arg_select)
		{

			CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

			for (int i = 0 ; i < vSelectionRange.Length; i++)
			{
				int start_row = vSelectionRange[i].Row;
				int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

				for (int j = start_row ; j < end_row; j++)
				{ 
					if(spd_main.ActiveSheet.Rows[j].Locked) continue;
					spd_main.ActiveSheet.Cells[j, _lxChkCol].Value = arg_select;
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

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();	
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

		

		/// <summary>
		/// 스타일 콤보박스 세팅
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txt_styleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				cmb_style.SelectedIndex = -1;

				DataTable dt_ret;
				
				dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCd, " ") ); 
				 
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_style, 0, 1, 2, 3, 4, false, 80, 200); 
				if (dt_ret.Rows.Count > 0 && dt_ret.Rows.Count < 2)
					cmb_style.SelectedIndex = 0;
				else if (dt_ret == null || dt_ret.Rows.Count <= 0) 
					cmb_style.SelectedIndex = -1; 

				dt_ret.Dispose();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_styleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmb_style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_factory.SelectedIndex == -1 || cmb_style.SelectedIndex == -1) return;

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name

				txt_styleCd.Text = cmb_style.SelectedValue.ToString();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_style_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		

		private string _itemGroupCode = " "; 

		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try 
			{
				if ( cmb_itemGroup.SelectedIndex != -1 )
				{
					btn_groupSearch.Enabled = true;
					txt_itemGroup.Text = "";
					_itemGroupCode = cmb_itemGroup.SelectedValue.ToString();

				}
				else
				{
					
					btn_groupSearch.Enabled = false;
					txt_itemGroup.Text = "";
					_itemGroupCode = " ";
				}

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_itemGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
			try
			{

				string vTyep = cmb_itemGroup.SelectedValue.ToString();
				FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);
				
				vPopup.ShowDialog();
			
				_itemGroupCode = COM.ComVar.Parameter_PopUp[3];
				txt_itemGroup.Text	= COM.ComVar.Parameter_PopUp[4];

				vPopup.Dispose(); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}
		 


		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			dpick_to.Value = dpick_from.Value; 
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

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
//			ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Incoming Invoice";
            this.Text = "Incoming Invoice";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SBI_INCOMING_INVOICE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

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

			//그룹타입 콤보쿼리 
			vDt = ClassLib.ComFunction.Select_GroupTypeCode();  
			ClassLib.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true,  0, 130);  
			vDt.Dispose();


			// BarKind Combobox Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBS08");
			COM.ComCtl.Set_ComboList(vDt, cmb_barMove, 1, 2, true, 56,0);
			cmb_barMove.SelectedIndex = -1;
			vDt.Dispose();

			// default search proviso
			if (COM.ComVar.Parameter_PopUp[0].ToString() != "")
				cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
			dpick_from.Value			= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
			dpick_to.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
			
			// Disabled tbutton
			tbtn_Save.Enabled		= false;
			tbtn_Delete.Enabled		= false;
			tbtn_Conform.Enabled	= false; 
			tbtn_Create.Enabled		= false;

		}

		/// <summary>
		/// Set_Return_DataTable : 메인창으로 리턴될 데이터 테이블 Setting
		/// </summary>
		private void Create_DataTable()
		{
			_DT = null;
			_DT = new DataTable("BarCode");

			// 메인 데이터 
			for(int i = 0; i <= (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_PRICE; i++)
			{
				_DT.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			}
		}




		private void Create_DataTable_OVERSEAS()
		{

			_DT = null;
			_DT = new DataTable("Purchase");

			for(int i = 0 ; i < fgrid_main.Cols.Count; i++)
			{
				_DT.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			}


		}




		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return; 

				string factory = cmb_factory.SelectedValue.ToString();
				string ship_ymd_from = MyComFunction.ConvertDate2DbType(dpick_from.Text);
				string ship_ymd_to = MyComFunction.ConvertDate2DbType(dpick_to.Text);
				string style_cd = ClassLib.ComFunction.Empty_Combo(cmb_style, " ").Replace("-", "");
				string bar_move = ClassLib.ComFunction.Empty_Combo(cmb_barMove, " "); 
				string item_group = _itemGroupCode;
				string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
				string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");  
				string invoice_no = ClassLib.ComFunction.Empty_TextBox(txt_Invoice, " ");  

				
				decimal total_qty = 0;
				decimal total_amount = 0;
				

				DataTable vDt = SELECT_SBS_INVOICE_LIST(factory, ship_ymd_from, ship_ymd_to, style_cd, bar_move, item_group, item_cd, item_name, invoice_no);
				spd_main.Display_Grid(vDt);


				// ship_qty == in_qty 이면 선택불가능 처리, 중복 입고 방지
				for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
				{
					total_qty = total_qty + (decimal)spd_main.ActiveSheet.Cells[i, _lxShipQtyCol].Value;
					total_amount = total_amount + ( (decimal)spd_main.ActiveSheet.Cells[i, _lxShipQtyCol].Value * (decimal)spd_main.ActiveSheet.Cells[i, _lxTradePriceCol].Value ); 

					

					if(spd_main.ActiveSheet.Cells[i, _lxShipQtyCol].Value.ToString() == spd_main.ActiveSheet.Cells[i, _lxInQtyCol].Value.ToString() )
					{
						spd_main.ActiveSheet.Rows[i].Locked = true;
						spd_main.ActiveSheet.Rows[i].ForeColor = ClassLib.ComVar.ClrImportant;
					}

				} 

				txt_total.Text = total_qty.ToString() + " / " + total_amount.ToString(); 


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
//			int vRow = arg_grid.Sheets[0].ActiveRowIndex ;
//			int vCol = arg_grid.Sheets[0].ActiveColumnIndex ;
//			
//			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
//				return;
//			
//			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
//			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString() ;
//			if (vTemp == "CheckBoxCellType" )
//			{
//				arg_grid.Buffer_CellData = "000" ;
//				arg_grid.Update_Row(img_Action) ;
//			}
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				spd_main.ClearAll();

				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

				//date 초기화  
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd");
				dpick_from.Text = MyComFunction.ConvertDate2Type(nowymd);
				dpick_to.Text = MyComFunction.ConvertDate2Type(nowymd); 

				txt_styleCd.Text = "";
				cmb_style.SelectedIndex = -1; 
				cmb_barMove.SelectedIndex = -1;				
				
				
				cmb_itemGroup.SelectedIndex = -1;
				txt_itemGroup.Text = "";
				txt_itemCode.Text = "";
				txt_itemName.Text = "";

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}
		

		private void Tbtn_PrintProcess()
		{

			try
			{


//				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory, cmb_outDiv, cmb_workProcess, cmb_workLine}; 
//				System.Windows.Forms.TextBox[] txt_array = {}; 
//
//				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
//				{
 
 
					string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incoming_Invoice");


					string sPara  = " /rp ";
					sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
					sPara += "'" + dpick_from.Text.Replace("-","") +		"' ";
					sPara += "'" + dpick_to.Text.Replace("-", "") +		"' ";
					sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_barMove, "") +	"' ";
					sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txt_itemGroup, "") +	"' ";
					sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txt_itemCode, "") +	"' ";
					sPara += "'" + ClassLib.ComFunction.Empty_TextBox(txt_itemName, "") +	"' ";

					FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);

					MyReport.Text = "Outgoing Process Normal sheet";
					MyReport.Show();	
			
 
//				}

					

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		#endregion

		#region Return DataTable 관련 메서드

		
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


				// Insert Flag를 붙인다.
				for (int i = fgrid_main.Rows.Count - arg_dt.Rows.Count; i < fgrid_main.Rows.Count; i++)
				{
					fgrid_main[i,0] =  ClassLib.ComVar.Insert;	 

					if(! _Division.Trim().Equals("") )
					{
						fgrid_main.Rows[i].IsNode = true;
						fgrid_main.Rows[i].Node.Level = 1;
					}


				}





				if(_Division.Trim().Equals("") )
				{


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


				} // if(_Division.Trim().Equals("") )





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
				
				COM.ComVar.Parameter_PopUp[1]	= "Select Incoming WareHouse";
				COM.ComVar.Parameter_PopUp[0]	= "WareHouse";

				ClassLib.ComVar.Parameter_PopUpTable = vDt;
				vDt.Dispose();

				Pop_BI_Incoming_List_Changer pop_changer = new Pop_BI_Incoming_List_Changer();
				pop_changer.ShowDialog();

				if (COM.ComVar.Parameter_PopUp != null)
				{
					_vWhCd = COM.ComVar.Parameter_PopUp[0];

					pop_changer.Dispose();

					if(_Division.Trim().Equals("") )
					{
						Make_DT(); 
					}
					else if(_Division.Trim().Equals("OVERSEAS") )
					{
						Make_DT_OVERSEAS(); 
					}





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


//				CellRange[] vSelectionRange = _mainSheet.GetSelections(); 
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

				Create_DataTable();
				DataRow datarow = null; 
		 
				int vFlag = 0;
				decimal ship_qty = 0;
				decimal in_qty = 0;
		 
				for(int i = 0; i < this._mainSheet.RowCount; i++)
				{ 
					bool vBool	=	this._mainSheet.Cells[i, _lxChkCol].Value.ToString() == "True" ? true : false;
					if (vBool)
					{
						//vFlag = Etc_DataDuplicateCheck_FSP(i);

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


							ship_qty = decimal.Parse(spd_main.ActiveSheet.Cells[i, _lxShipQtyCol].Value.ToString() );
							in_qty = decimal.Parse(spd_main.ActiveSheet.Cells[i, _lxInQtyCol].Value.ToString() );  
							datarow[_ldInQtyCol]		= Convert.ToString(ship_qty - in_qty);

							datarow[_ldUnitCol]			= spd_main.ActiveSheet.Cells[i, _lxUnitCol].Value.ToString();  
							datarow[_ldCustCdCol]		= spd_main.ActiveSheet.Cells[i, _lxCustCdCol].Value.ToString();
							datarow[_ldCustNameCol]		= spd_main.ActiveSheet.Cells[i, _lxCustNameCol].Value.ToString();  
							datarow[_IdPurPriceCol]		= spd_main.ActiveSheet.Cells[i, _lxTradePriceCol].Value.ToString();
							datarow[_ldCbdPriceCol]		= spd_main.ActiveSheet.Cells[i, _lxCBDPriceCol].Value.ToString();  
							datarow[_ldShipPriceCol]	= spd_main.ActiveSheet.Cells[i, _lxSellPriceCol].Value.ToString(); 
							datarow[_ldLedgerPriceCol]	= spd_main.ActiveSheet.Cells[i, _lxLedgerPriceCol].Value.ToString(); 
							datarow[_ldContNoCol]		= spd_main.ActiveSheet.Cells[i, _lxContNoCol].Value.ToString();
							datarow[_ldShipYmdCol]		= spd_main.ActiveSheet.Cells[i, _lxShipYmdCol].Value.ToString();
							datarow[_ldShipNoCol]		= spd_main.ActiveSheet.Cells[i, _lxShipNoCol].Value.ToString();
							datarow[_ldShipSeqCol]		= spd_main.ActiveSheet.Cells[i, _lxShipSeqCol].Value.ToString(); 
							datarow[_ldShipQtyCol]		= spd_main.ActiveSheet.Cells[i, _lxShipQtyCol].Value.ToString();

							string[] token = spd_main.ActiveSheet.Cells[i, _lxLotNoCol].Value.ToString().Split('-');
							datarow[_ldLOTNoCol]		= token[0];
							datarow[_ldLOTSeqCol]		= token[1];

							datarow[_ldStyleCdCol]		= spd_main.ActiveSheet.Cells[i, _lxStyleCdCol].Value.ToString();
							datarow[_ldStyleNameCol]	= spd_main.ActiveSheet.Cells[i, _lxStyleNameCol].Value.ToString();
							datarow[_ldPKUnitCol]		= spd_main.ActiveSheet.Cells[i, _lxPkUnitCol].Value.ToString();  
							datarow[_ldWhCdCol]			= _vWhCd;


							
							datarow[_ldPriceYNCol]		= "Y"; 
							datarow[_IdPurCurrencyCol]	= "USD";
							datarow[_ldCbdCurrencyCol]	= "USD";
							datarow[_ldShipCurrencyCol]	= "USD";
							datarow[_ldLedgerCurrencyCol]= "USD"; 
							datarow[_ldTranDivCol]		= "I"; 
							datarow[_ldPurDivCol]		= "00";    //normal
							datarow[_ldBuyDivCol]		= "3";     //import  
 


												
							_DT.Rows.Add(datarow); 
							Apply_Grid(_DT); 
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
		/// Make_DT_OVERSEAS : 
		/// </summary>
		private void Make_DT_OVERSEAS()
		{
			try
			{

 
				Create_DataTable_OVERSEAS();
				DataRow datarow = null; 
		 
				int vFlag = 0;
				decimal ship_qty = 0;
				decimal in_qty = 0;
		 
				for(int i = 0; i < this._mainSheet.RowCount; i++)
				{ 
					bool vBool	=	this._mainSheet.Cells[i, _lxChkCol].Value.ToString() == "True" ? true : false;
					if (vBool)
					{
						//vFlag = Etc_DataDuplicateCheck_FSP(i);

						if (vFlag == 0)
						{
							if ( _lcNo == "" && _invNo == "" )
							{
								_lcNo = spd_main.ActiveSheet.Cells[i, _lxLcNoCol].Value.ToString();
								_invNo = spd_main.ActiveSheet.Cells[i, _lxInvNoCol].Value.ToString();
							}

							datarow = _DT.NewRow();
					

							for(int aa = 0; aa < _DT.Columns.Count; aa++)
							{
								datarow[aa] = "";
							}



							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxTREE_LEVEL - 1]	= "1";
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxDESC1 - 1] = spd_main.ActiveSheet.Cells[i, _lxItemNameCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxDESC2 - 1] = spd_main.ActiveSheet.Cells[i, _lxSpecNameCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxDESC3 - 1 ]= spd_main.ActiveSheet.Cells[i, _lxColorNameCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxITEM_NAME - 1] = spd_main.ActiveSheet.Cells[i, _lxItemNameCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSPEC_NAME - 1] = spd_main.ActiveSheet.Cells[i, _lxSpecNameCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCOLOR_NAME - 1] = spd_main.ActiveSheet.Cells[i, _lxColorNameCol].Value.ToString();

							ship_qty = decimal.Parse(spd_main.ActiveSheet.Cells[i, _lxShipQtyCol].Value.ToString() );
							in_qty = decimal.Parse(spd_main.ActiveSheet.Cells[i, _lxInQtyCol].Value.ToString() );   
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxIN_QTY - 1] = Convert.ToString(ship_qty - in_qty);


							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxUNIT - 1] = spd_main.ActiveSheet.Cells[i, _lxUnitCol].Value.ToString();  
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPUR_CURRENCY - 1] = "USD"; 
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPUR_PRICE - 1] = spd_main.ActiveSheet.Cells[i, _lxTradePriceCol].Value.ToString(); 
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCUST_CD - 1] = spd_main.ActiveSheet.Cells[i, _lxCustCdCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCUST_NAME - 1] = spd_main.ActiveSheet.Cells[i, _lxCustNameCol].Value.ToString(); 
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCBD_CURRENCY - 1] = "USD";
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCBD_PRICE - 1] = spd_main.ActiveSheet.Cells[i, _lxCBDPriceCol].Value.ToString();  
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSHIP_CURRENCY - 1] = "USD";
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSHIP_PRICE - 1] = spd_main.ActiveSheet.Cells[i, _lxSellPriceCol].Value.ToString(); 
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxLEDGER_CURRENCY - 1] = "USD";
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxLEDGER_PRICE - 1] = spd_main.ActiveSheet.Cells[i, _lxLedgerPriceCol].Value.ToString(); 
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCONT_NO - 1] = spd_main.ActiveSheet.Cells[i, _lxContNoCol].Value.ToString();


							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPK_UNIT_QTY - 1] =  spd_main.ActiveSheet.Cells[i, _lxPkUnitCol].Value.ToString();  
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPRICE_YN - 1] = "Y";   
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSHIP_YMD - 1] = spd_main.ActiveSheet.Cells[i, _lxShipYmdCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSHIP_NO - 1] = spd_main.ActiveSheet.Cells[i, _lxShipNoCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSHIP_SEQ - 1] = spd_main.ActiveSheet.Cells[i, _lxShipSeqCol].Value.ToString(); 
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSHIP_QTY - 1] = spd_main.ActiveSheet.Cells[i, _lxShipQtyCol].Value.ToString();

							string[] token = spd_main.ActiveSheet.Cells[i, _lxLotNoCol].Value.ToString().Split('-');
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxLOT_NO - 1] = token[0];
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxLOT_SEQ - 1] = token[1];

							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSTYLE_CD - 1] = spd_main.ActiveSheet.Cells[i, _lxStyleCdCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSTYLE_NAME - 1] = spd_main.ActiveSheet.Cells[i, _lxStyleNameCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxWH_CD - 1] = _vWhCd;
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxTRAN_DIV - 1] = "I";  
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxPUR_DIV_D - 1] = "00";    //normal
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxBUY_DIV_D - 1] = "3";     //import   
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxITEM_CD - 1] = spd_main.ActiveSheet.Cells[i, _lxItemCdCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxSPEC_CD - 1] = spd_main.ActiveSheet.Cells[i, _lxSpecCdCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxCOLOR_CD - 1] = spd_main.ActiveSheet.Cells[i, _lxColorCdCol].Value.ToString();
							datarow[(int)ClassLib.TBSBI_IN_OVERSEAS.IxMOD_QTY - 1] = Convert.ToString(ship_qty - in_qty);
						 
      

												
							_DT.Rows.Add(datarow); 
							Apply_Grid(_DT); 
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





		private int Etc_DataDuplicateCheck_FSP(int arg_row)
		{
			int vReturn = 0;

			for ( int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++ )
			{
				if( fgrid_main[vRow, _checkCols[0]].ToString().Replace("-", "").Equals(_mainSheet.Cells[arg_row, _lxStyleCdCol].Value.ToString()) &&
					fgrid_main[vRow, _checkCols[1]].ToString().Equals(_mainSheet.Cells[arg_row, _lxItemCdCol].Value.ToString()) &&
					fgrid_main[vRow, _checkCols[2]].ToString().Equals(_mainSheet.Cells[arg_row, _lxSpecCdCol].Value.ToString()) &&
					fgrid_main[vRow, _checkCols[3]].ToString().Equals(_mainSheet.Cells[arg_row, _lxColorCdCol].Value.ToString())) 
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
		public DataTable SELECT_SBS_INVOICE_LIST(string arg_factory, 
			string arg_ship_ymd_from, 
			string arg_ship_ymd_to, 
			string arg_style_cd, 
			string arg_bar_move, 
			string arg_item_group, 
			string arg_item_cd, 
			string arg_item_name,
			string arg_invoice)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_INVOICE.SELECT_SBS_INVOICE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4] = "ARG_BAR_MOVE";
			MyOraDB.Parameter_Name[5] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[7] = "ARG_ITEM_NAME";
			MyOraDB.Parameter_Name[8] = "ARG_INVOICE";
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
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_ship_ymd_from;
			MyOraDB.Parameter_Values[2] = arg_ship_ymd_to;
			MyOraDB.Parameter_Values[3] = arg_style_cd;
			MyOraDB.Parameter_Values[4] = arg_bar_move;
			MyOraDB.Parameter_Values[5] = arg_item_group;
			MyOraDB.Parameter_Values[6] = arg_item_cd;
			MyOraDB.Parameter_Values[7] = arg_item_name;
			MyOraDB.Parameter_Values[8] = arg_invoice;
			MyOraDB.Parameter_Values[9] = "";
			
			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		
		}



		#endregion



	}
}

