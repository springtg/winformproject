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
	public class Pop_BI_Incoming_Barcode : COM.PCHWinForm.Pop_Large
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.SSP spd_main;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label lbl_barKind;
		private C1.Win.C1List.C1Combo cmb_barKind;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private System.Windows.Forms.Label lbl_vendor;
		private C1.Win.C1List.C1Combo cmb_user;
		private System.Windows.Forms.Label lbl_user;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuItem menuitem_SelectAll;
		private System.Windows.Forms.MenuItem menuitem_DeSelectAll;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.ContextMenu cmenu_Barcode;
		private System.Windows.Forms.TextBox txt_itemNm;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_specification;
		private System.Windows.Forms.TextBox txt_specification;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;
		private int _RowFixed = 0;
		private string v_factory   = null;
		private string v_ship_ymd  = null;
		private string v_pur_user  = null;
		private string v_vendor_cd = null;
		private string v_ship_type = null;
		private string v_page_cnt  = null;
		private string v_outside   = null;
		private string search_type = "Btn";

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction    = new COM.ComFunction();

		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private bool _isAccessible = true;

		private COM.FSP fgrid_main;
		private int[] _checkCols;


		public DataTable _DT;  

		#region 메인창으로 리턴될 데이터 테이블 -Manual
	
		

		private int _lxChkCol		= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxCHK;
		private int _lxQtyChkCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxQTY_CHK;
		private int _lxColCtn		= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxROW_CNT;
		private int _lxFactoryCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxFACTORY;
		private int _lxItemCdCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxITEM_CD;
		private int _lxItemNameCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxITEM_NAME;
		private int _lxSpecCdCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxSPEC_CD;
		private int _lxSpecNameCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxSEPC_NAME;
		private int _lxColorCdCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxCOLOR_CD;
		private int _lxColorNameCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxCOLOR_NAME;
		private int _lxScanQtyCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxSCAN_QTY;
		private int _lxScanDateCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.lxSCAN_DATE; 
		private int _lxUnitCol		= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxUNIT;
		private int _lxPackingCol		= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxPACKING;
		private int _lxPkUnitQtyCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxPK_UNIT_QTY;
		private int _lxPurCurrencyCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxPUR_CURRENCY;
		private int _lxPurPriceCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxPUR_PRICE;
		private int _lxCbdCurrencyCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxCBD_CURRENCY;
		private int _lxCbdPriceCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxCBD_PRICE;
        private int _lxShipCurrencyCol = (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxSHIP_CURRENCY;
		private int _lxShipPriceCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxSHIP_PRICE;
		private int _lxPriceYnCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxPRICE_YN;
		private int _lxCustCdCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxCUST_CD;
		private int _lxCustNameCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxCUST_NAME;
		private int _lxBarCodeCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxBAR_CODE;
		private int _lxBarKindCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxBAR_KIND;
		private int _lxContNoCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxCONT_NO;
		private int _lxShipYmdCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxSHIP_YMD;
		private int _lxShipNoCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxSHIP_NO;
		private int _lxShipSeqCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxSHIP_SEQ;
		private int _lxLotNoCol		= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxLOT_NO;
		private int _lxLotSeqCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxLOT_SEQ;
		private int _lxStyleCdCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxSTYLE_CD;
		private int _lxStyleNameCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxSTYLE_NAME;
		private int _lxWhCdCol		= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxWH_CD;
		private int _lxWhNameCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxWH_NAME;
		private int _lxPurDivCdCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxSHIP_DIV_CODE;
		private int _lxPurUserCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxPUR_USER;
		private int _lxInOkCol	    = (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxIN_OK;
		private int _lxInQtyCol	    = (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxIN_QTY;
		private int _lxAttributeCol	= (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxATTRIBUTE;




		#endregion 


		#region 메인창으로 리턴될 데이터 테이블 -Auto 

		private int _lxChkCol_Auto		= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxCHK;
		private int _lxQtyChkCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxQTY_CHK;
		private int _lxColCtn_Auto		= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxROW_CNT;
		private int _lxFactoryCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxFACTORY;
		private int _lxItemCdCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxITEM_CD;
		private int _lxItemNameCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxITEM_NAME;
		private int _lxSpecCdCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxSPEC_CD;
		private int _lxSpecNameCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxSEPC_NAME;
		private int _lxColorCdCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxCOLOR_CD;
		private int _lxColorNameCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxCOLOR_NAME;
		private int _lxVenderScanQtyCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxVENDER_SCAN_QTY;
		private int _lxUnitCol_Auto		= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxUNIT;
		private int _lxPackingCol_Auto		= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxPACKING;
		private int _lxPkUnitQtyCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxPK_UNIT_QTY;
		private int _lxPurCurrencyCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxPUR_CURRENCY;
		private int _lxPurPriceCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxPUR_PRICE;
		private int _lxCbdCurrencyCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxCBD_CURRENCY;
		private int _lxCbdPriceCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxCBD_PRICE;
		private int _lxShipCurrencyCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxSHIP_CURRENCY;
		private int _lxShipPriceCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxSHIP_PRICE;
		private int _lxPriceYnCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxPRICE_YN;
		private int _lxCustCdCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxCUST_CD;
		private int _lxCustNameCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxCUST_NAME;
		private int _lxBarCodeCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxBAR_CODE;
		private int _lxBarKindCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxBAR_KIND;
		private int _lxContNoCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxCONT_NO;
		private int _lxShipYmdCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxSHIP_YMD;
		private int _lxShipNoCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxSHIP_NO;
		private int _lxShipSeqCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxSHIP_SEQ;
		private int _lxLotNoCol_Auto		= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxLOT_NO;
		private int _lxLotSeqCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxLOT_SEQ;
		private int _lxStyleCdCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxSTYLE_CD;
		private int _lxStyleNameCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxSTYLE_NAME;
		private int _lxWhCdCol_Auto		= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxWH_CD;
		private int _lxWhNameCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxWH_NAME;
		private int _lxPurDivCdCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxSHIP_DIV_CODE;
		private int _lxPurUserCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxPUR_USER;
		private int _lxInOkCol_Auto	    = (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxIN_OK;
		private int _lxInQtyCol_Auto	    = (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxIN_QTY;
		private int _lxAttributeCol_Auto	= (int)ClassLib.TBSBI_INCOMING_AUTO_BARCODE.IxATTRIBUTE;

		
		#endregion 




	
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
		private int _ldCbdCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCBD_CURRENCY -1;
		private int _ldCbdPriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCBD_PRICE -1;
		private int _ldShipCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_CURRENCY -1;
		private int _ldShipPriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_PRICE -1;
		private int _ldPriceYnCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPRICE_YN -1;
		private int _ldCustCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCUST_CD -1;
		private int _ldCustNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCUST_NAME -1;
		private int _ldBarCodeCol	= (int)ClassLib.TBSBI_IN_TAIL.IxBAR_CODE -1;
		private int _ldBarKindCol	= (int)ClassLib.TBSBI_IN_TAIL.IxBAR_KIND -1;
		private int _ldContNoCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCONT_NO -1;
		private int _ldShipYmdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_YMD -1;
		private int _ldShipNoCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_NO -1;
		private int _ldShipSeqCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_SEQ -1;
		private int _ldLotNoCol		= (int)ClassLib.TBSBI_IN_TAIL.IxLOT_NO -1;
		private int _ldLotSeqCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLOT_SEQ -1;
		private int _ldStyleCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSTYLE_CD -1;
		private int _ldStyleNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSTYLE_NAME -1;
		private int _ldWhCdCol		= (int)ClassLib.TBSBI_IN_TAIL.IxWH_CD -1;
		private int _ldWhNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxWH_NAME -1;
		private int _ldTranDivCol	= (int)ClassLib.TBSBI_IN_TAIL.IxTRAN_DIV -1;
		private int _ldPurUserCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_USER -1;

       //Incoming에 뿌리기 위한 int
		private int _factoryCol     = (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY;
		private int _inSeqCol       = (int)ClassLib.TBSBI_IN_TAIL.IxIN_SEQ;
		private int _modQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxMOD_QTY;
		private int _seqCol				= (int)ClassLib.TBSBI_IN_TAIL.IxSEQ;
		private int _inQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxIN_QTY;
		private bool _practicable	= false;


		private System.Windows.Forms.Label lbl_bar_cd;
		private System.Windows.Forms.TextBox txt_bar_cd;
		private C1.Win.C1List.C1Combo cmb_shiptype;
		private System.Windows.Forms.Label lbl_shiptype;
		private C1.Win.C1List.C1Combo cmb_incheck;
		private System.Windows.Forms.Label lbl_incheck;
		private C1.Win.C1List.C1Combo cmb_outside;
		private System.Windows.Forms.Label lbl_outside;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private string print_seq = "000";
		private System.Windows.Forms.Label lbl_sstype;
		private C1.Win.C1List.C1Combo cmb_sstype;
		private int _ldPurDivCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_DIV -1;

		private int _ldLedgerPriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_PRICE -1;
		private System.Windows.Forms.Label lbl_SH_CDC;
		private C1.Win.C1List.C1Combo cmb_pur_factory;
		private System.Windows.Forms.CheckBox chk_auto;
		private System.Windows.Forms.Label lbl_shipDate;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_scan_date;
		private System.Windows.Forms.Label lbl_scan_date;
		private int _ldLedgerCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_CURRENCY -1;

		#endregion
		
		#region 생성자 / 소멸자
		public Pop_BI_Incoming_Barcode(Control arg_grid, int[] arg_checks)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BI_Incoming_Barcode));
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
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.cmb_barKind = new C1.Win.C1List.C1Combo();
            this.lbl_barKind = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_auto = new System.Windows.Forms.CheckBox();
            this.cmb_pur_factory = new C1.Win.C1List.C1Combo();
            this.lbl_SH_CDC = new System.Windows.Forms.Label();
            this.cmb_sstype = new C1.Win.C1List.C1Combo();
            this.lbl_sstype = new System.Windows.Forms.Label();
            this.cmb_outside = new C1.Win.C1List.C1Combo();
            this.lbl_outside = new System.Windows.Forms.Label();
            this.cmb_incheck = new C1.Win.C1List.C1Combo();
            this.lbl_incheck = new System.Windows.Forms.Label();
            this.cmb_shiptype = new C1.Win.C1List.C1Combo();
            this.lbl_shiptype = new System.Windows.Forms.Label();
            this.lbl_bar_cd = new System.Windows.Forms.Label();
            this.txt_bar_cd = new System.Windows.Forms.TextBox();
            this.lbl_specification = new System.Windows.Forms.Label();
            this.txt_specification = new System.Windows.Forms.TextBox();
            this.lbl_scan_date = new System.Windows.Forms.Label();
            this.dpick_scan_date = new System.Windows.Forms.DateTimePicker();
            this.spd_main = new COM.SSP();
            this.cmenu_Barcode = new System.Windows.Forms.ContextMenu();
            this.menuitem_SelectAll = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuitem_DeSelectAll = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this._mainSheet = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_barKind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sstype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_incheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shiptype)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(729, 4);
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
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(656, 23);
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
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "22.4913494809689:False:True;69.5501730103806:False:False;5.19031141868512:False:T" +
                "rue;\t0.410677618069815:False:True;97.5359342915811:False:False;0.410677618069815" +
                ":False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(974, 578);
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
            this.pnl_menu.Location = new System.Drawing.Point(12, 544);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(958, 30);
            this.pnl_menu.TabIndex = 173;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(870, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(80, 23);
            this.btn_close.TabIndex = 547;
            this.btn_close.Text = "Cancel";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(789, 3);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(80, 23);
            this.btn_apply.TabIndex = 546;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txt_itemNm);
            this.panel1.Controls.Add(this.txt_itemCd);
            this.panel1.Controls.Add(this.lbl_item);
            this.panel1.Controls.Add(this.cmb_user);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.lbl_vendor);
            this.panel1.Controls.Add(this.txt_vendorCode);
            this.panel1.Controls.Add(this.cmb_vendor);
            this.panel1.Controls.Add(this.cmb_barKind);
            this.panel1.Controls.Add(this.lbl_barKind);
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
            this.panel1.Size = new System.Drawing.Size(950, 130);
            this.panel1.TabIndex = 169;
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(526, 37);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(140, 21);
            this.txt_itemNm.TabIndex = 378;
            // 
            // txt_itemCd
            // 
            this.txt_itemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCd.Location = new System.Drawing.Point(446, 37);
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
            this.lbl_item.Location = new System.Drawing.Point(344, 37);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 373;
            this.lbl_item.Text = "Item ";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_user
            // 
            this.cmb_user.AddItemSeparator = ';';
            this.cmb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_user.Caption = "";
            this.cmb_user.CaptionHeight = 17;
            this.cmb_user.CaptionStyle = style1;
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
            this.cmb_user.EvenRowStyle = style2;
            this.cmb_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FooterStyle = style3;
            this.cmb_user.HeadingStyle = style4;
            this.cmb_user.HighLightRowStyle = style5;
            this.cmb_user.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_user.Images"))));
            this.cmb_user.ItemHeight = 15;
            this.cmb_user.Location = new System.Drawing.Point(110, 59);
            this.cmb_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_user.MaxDropDownItems = ((short)(5));
            this.cmb_user.MaxLength = 32767;
            this.cmb_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.OddRowStyle = style6;
            this.cmb_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_user.SelectedStyle = style7;
            this.cmb_user.Size = new System.Drawing.Size(220, 20);
            this.cmb_user.Style = style8;
            this.cmb_user.TabIndex = 369;
            this.cmb_user.PropBag = resources.GetString("cmb_user.PropBag");
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
            this.lbl_vendor.Location = new System.Drawing.Point(8, 81);
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
            this.txt_vendorCode.Location = new System.Drawing.Point(110, 81);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 366;
            this.txt_vendorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vendorCode_KeyPress);
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
            this.cmb_vendor.Location = new System.Drawing.Point(190, 81);
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
            this.cmb_vendor.TabIndex = 367;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            // 
            // cmb_barKind
            // 
            this.cmb_barKind.AddItemSeparator = ';';
            this.cmb_barKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_barKind.Caption = "";
            this.cmb_barKind.CaptionHeight = 17;
            this.cmb_barKind.CaptionStyle = style17;
            this.cmb_barKind.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_barKind.ColumnCaptionHeight = 18;
            this.cmb_barKind.ColumnFooterHeight = 18;
            this.cmb_barKind.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_barKind.ContentHeight = 16;
            this.cmb_barKind.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_barKind.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_barKind.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_barKind.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_barKind.EditorHeight = 16;
            this.cmb_barKind.EvenRowStyle = style18;
            this.cmb_barKind.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barKind.FooterStyle = style19;
            this.cmb_barKind.HeadingStyle = style20;
            this.cmb_barKind.HighLightRowStyle = style21;
            this.cmb_barKind.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_barKind.Images"))));
            this.cmb_barKind.ItemHeight = 15;
            this.cmb_barKind.Location = new System.Drawing.Point(446, 15);
            this.cmb_barKind.MatchEntryTimeout = ((long)(2000));
            this.cmb_barKind.MaxDropDownItems = ((short)(5));
            this.cmb_barKind.MaxLength = 32767;
            this.cmb_barKind.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_barKind.Name = "cmb_barKind";
            this.cmb_barKind.OddRowStyle = style22;
            this.cmb_barKind.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_barKind.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_barKind.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_barKind.SelectedStyle = style23;
            this.cmb_barKind.Size = new System.Drawing.Size(220, 20);
            this.cmb_barKind.Style = style24;
            this.cmb_barKind.TabIndex = 184;
            this.cmb_barKind.PropBag = resources.GetString("cmb_barKind.PropBag");
            // 
            // lbl_barKind
            // 
            this.lbl_barKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_barKind.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barKind.ImageIndex = 0;
            this.lbl_barKind.ImageList = this.img_Label;
            this.lbl_barKind.Location = new System.Drawing.Point(344, 15);
            this.lbl_barKind.Name = "lbl_barKind";
            this.lbl_barKind.Size = new System.Drawing.Size(100, 21);
            this.lbl_barKind.TabIndex = 182;
            this.lbl_barKind.Text = "Barcode Kind";
            this.lbl_barKind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
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
            this.cmb_factory.Enabled = false;
            this.cmb_factory.EvenRowStyle = style26;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style27;
            this.cmb_factory.HeadingStyle = style28;
            this.cmb_factory.HighLightRowStyle = style29;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(110, 15);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style30;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style31;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style32;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
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
            this.lbl_shipDate.Text = "Shipping Date";
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
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_from.Location = new System.Drawing.Point(110, 37);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 4;
            this.dpick_from.Value = new System.DateTime(2007, 6, 4, 15, 12, 42, 265);
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chk_auto);
            this.groupBox1.Controls.Add(this.cmb_pur_factory);
            this.groupBox1.Controls.Add(this.lbl_SH_CDC);
            this.groupBox1.Controls.Add(this.cmb_sstype);
            this.groupBox1.Controls.Add(this.lbl_sstype);
            this.groupBox1.Controls.Add(this.cmb_outside);
            this.groupBox1.Controls.Add(this.lbl_outside);
            this.groupBox1.Controls.Add(this.cmb_incheck);
            this.groupBox1.Controls.Add(this.lbl_incheck);
            this.groupBox1.Controls.Add(this.cmb_shiptype);
            this.groupBox1.Controls.Add(this.lbl_shiptype);
            this.groupBox1.Controls.Add(this.lbl_bar_cd);
            this.groupBox1.Controls.Add(this.txt_bar_cd);
            this.groupBox1.Controls.Add(this.lbl_specification);
            this.groupBox1.Controls.Add(this.txt_specification);
            this.groupBox1.Controls.Add(this.lbl_scan_date);
            this.groupBox1.Controls.Add(this.dpick_scan_date);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 130);
            this.groupBox1.TabIndex = 379;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chk_auto
            // 
            this.chk_auto.Location = new System.Drawing.Point(562, 104);
            this.chk_auto.Name = "chk_auto";
            this.chk_auto.Size = new System.Drawing.Size(102, 24);
            this.chk_auto.TabIndex = 391;
            this.chk_auto.Text = "By Auto";
            this.chk_auto.CheckedChanged += new System.EventHandler(this.chk_auto_CheckedChanged);
            // 
            // cmb_pur_factory
            // 
            this.cmb_pur_factory.AddItemSeparator = ';';
            this.cmb_pur_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_pur_factory.Caption = "";
            this.cmb_pur_factory.CaptionHeight = 17;
            this.cmb_pur_factory.CaptionStyle = style33;
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
            this.cmb_pur_factory.EvenRowStyle = style34;
            this.cmb_pur_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pur_factory.FooterStyle = style35;
            this.cmb_pur_factory.HeadingStyle = style36;
            this.cmb_pur_factory.HighLightRowStyle = style37;
            this.cmb_pur_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_pur_factory.Images"))));
            this.cmb_pur_factory.ItemHeight = 15;
            this.cmb_pur_factory.Location = new System.Drawing.Point(110, 103);
            this.cmb_pur_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_pur_factory.MaxDropDownItems = ((short)(5));
            this.cmb_pur_factory.MaxLength = 32767;
            this.cmb_pur_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_pur_factory.Name = "cmb_pur_factory";
            this.cmb_pur_factory.OddRowStyle = style38;
            this.cmb_pur_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_pur_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_pur_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_pur_factory.SelectedStyle = style39;
            this.cmb_pur_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_pur_factory.Style = style40;
            this.cmb_pur_factory.TabIndex = 380;
            this.cmb_pur_factory.PropBag = resources.GetString("cmb_pur_factory.PropBag");
            // 
            // lbl_SH_CDC
            // 
            this.lbl_SH_CDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SH_CDC.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SH_CDC.ImageIndex = 0;
            this.lbl_SH_CDC.ImageList = this.img_Label;
            this.lbl_SH_CDC.Location = new System.Drawing.Point(8, 103);
            this.lbl_SH_CDC.Name = "lbl_SH_CDC";
            this.lbl_SH_CDC.Size = new System.Drawing.Size(100, 21);
            this.lbl_SH_CDC.TabIndex = 381;
            this.lbl_SH_CDC.Text = "Pur Factory";
            this.lbl_SH_CDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_sstype
            // 
            this.cmb_sstype.AddItemSeparator = ';';
            this.cmb_sstype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_sstype.Caption = "";
            this.cmb_sstype.CaptionHeight = 17;
            this.cmb_sstype.CaptionStyle = style41;
            this.cmb_sstype.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_sstype.ColumnCaptionHeight = 18;
            this.cmb_sstype.ColumnFooterHeight = 18;
            this.cmb_sstype.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_sstype.ContentHeight = 16;
            this.cmb_sstype.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_sstype.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_sstype.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_sstype.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_sstype.EditorHeight = 16;
            this.cmb_sstype.EvenRowStyle = style42;
            this.cmb_sstype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sstype.FooterStyle = style43;
            this.cmb_sstype.HeadingStyle = style44;
            this.cmb_sstype.HighLightRowStyle = style45;
            this.cmb_sstype.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_sstype.Images"))));
            this.cmb_sstype.ItemHeight = 15;
            this.cmb_sstype.Location = new System.Drawing.Point(784, 37);
            this.cmb_sstype.MatchEntryTimeout = ((long)(2000));
            this.cmb_sstype.MaxDropDownItems = ((short)(5));
            this.cmb_sstype.MaxLength = 32767;
            this.cmb_sstype.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sstype.Name = "cmb_sstype";
            this.cmb_sstype.OddRowStyle = style46;
            this.cmb_sstype.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sstype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sstype.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sstype.SelectedStyle = style47;
            this.cmb_sstype.Size = new System.Drawing.Size(160, 20);
            this.cmb_sstype.Style = style48;
            this.cmb_sstype.TabIndex = 390;
            this.cmb_sstype.SelectedValueChanged += new System.EventHandler(this.cmb_sstype_SelectedValueChanged);
            this.cmb_sstype.PropBag = resources.GetString("cmb_sstype.PropBag");
            // 
            // lbl_sstype
            // 
            this.lbl_sstype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_sstype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sstype.ImageIndex = 0;
            this.lbl_sstype.ImageList = this.img_Label;
            this.lbl_sstype.Location = new System.Drawing.Point(680, 37);
            this.lbl_sstype.Name = "lbl_sstype";
            this.lbl_sstype.Size = new System.Drawing.Size(100, 21);
            this.lbl_sstype.TabIndex = 389;
            this.lbl_sstype.Text = "SS Item";
            this.lbl_sstype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_outside
            // 
            this.cmb_outside.AddItemSeparator = ';';
            this.cmb_outside.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outside.Caption = "";
            this.cmb_outside.CaptionHeight = 17;
            this.cmb_outside.CaptionStyle = style49;
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
            this.cmb_outside.EvenRowStyle = style50;
            this.cmb_outside.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outside.FooterStyle = style51;
            this.cmb_outside.HeadingStyle = style52;
            this.cmb_outside.HighLightRowStyle = style53;
            this.cmb_outside.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_outside.Images"))));
            this.cmb_outside.ItemHeight = 15;
            this.cmb_outside.Location = new System.Drawing.Point(784, 15);
            this.cmb_outside.MatchEntryTimeout = ((long)(2000));
            this.cmb_outside.MaxDropDownItems = ((short)(5));
            this.cmb_outside.MaxLength = 32767;
            this.cmb_outside.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_outside.Name = "cmb_outside";
            this.cmb_outside.OddRowStyle = style54;
            this.cmb_outside.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outside.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outside.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outside.SelectedStyle = style55;
            this.cmb_outside.Size = new System.Drawing.Size(160, 20);
            this.cmb_outside.Style = style56;
            this.cmb_outside.TabIndex = 388;
            this.cmb_outside.PropBag = resources.GetString("cmb_outside.PropBag");
            // 
            // lbl_outside
            // 
            this.lbl_outside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outside.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outside.ImageIndex = 0;
            this.lbl_outside.ImageList = this.img_Label;
            this.lbl_outside.Location = new System.Drawing.Point(680, 15);
            this.lbl_outside.Name = "lbl_outside";
            this.lbl_outside.Size = new System.Drawing.Size(100, 21);
            this.lbl_outside.TabIndex = 387;
            this.lbl_outside.Text = "Item Type";
            this.lbl_outside.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_incheck
            // 
            this.cmb_incheck.AddItemSeparator = ';';
            this.cmb_incheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_incheck.Caption = "";
            this.cmb_incheck.CaptionHeight = 17;
            this.cmb_incheck.CaptionStyle = style57;
            this.cmb_incheck.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_incheck.ColumnCaptionHeight = 18;
            this.cmb_incheck.ColumnFooterHeight = 18;
            this.cmb_incheck.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_incheck.ContentHeight = 16;
            this.cmb_incheck.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_incheck.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_incheck.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_incheck.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_incheck.EditorHeight = 16;
            this.cmb_incheck.EvenRowStyle = style58;
            this.cmb_incheck.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_incheck.FooterStyle = style59;
            this.cmb_incheck.HeadingStyle = style60;
            this.cmb_incheck.HighLightRowStyle = style61;
            this.cmb_incheck.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_incheck.Images"))));
            this.cmb_incheck.ItemHeight = 15;
            this.cmb_incheck.Location = new System.Drawing.Point(446, 81);
            this.cmb_incheck.MatchEntryTimeout = ((long)(2000));
            this.cmb_incheck.MaxDropDownItems = ((short)(5));
            this.cmb_incheck.MaxLength = 32767;
            this.cmb_incheck.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_incheck.Name = "cmb_incheck";
            this.cmb_incheck.OddRowStyle = style62;
            this.cmb_incheck.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_incheck.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_incheck.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_incheck.SelectedStyle = style63;
            this.cmb_incheck.Size = new System.Drawing.Size(220, 20);
            this.cmb_incheck.Style = style64;
            this.cmb_incheck.TabIndex = 386;
            this.cmb_incheck.PropBag = resources.GetString("cmb_incheck.PropBag");
            // 
            // lbl_incheck
            // 
            this.lbl_incheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_incheck.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incheck.ImageIndex = 0;
            this.lbl_incheck.ImageList = this.img_Label;
            this.lbl_incheck.Location = new System.Drawing.Point(344, 81);
            this.lbl_incheck.Name = "lbl_incheck";
            this.lbl_incheck.Size = new System.Drawing.Size(100, 21);
            this.lbl_incheck.TabIndex = 385;
            this.lbl_incheck.Text = "Incomming All";
            this.lbl_incheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shiptype
            // 
            this.cmb_shiptype.AddItemSeparator = ';';
            this.cmb_shiptype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shiptype.Caption = "";
            this.cmb_shiptype.CaptionHeight = 17;
            this.cmb_shiptype.CaptionStyle = style65;
            this.cmb_shiptype.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shiptype.ColumnCaptionHeight = 18;
            this.cmb_shiptype.ColumnFooterHeight = 18;
            this.cmb_shiptype.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shiptype.ContentHeight = 16;
            this.cmb_shiptype.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shiptype.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shiptype.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shiptype.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shiptype.EditorHeight = 16;
            this.cmb_shiptype.EvenRowStyle = style66;
            this.cmb_shiptype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shiptype.FooterStyle = style67;
            this.cmb_shiptype.HeadingStyle = style68;
            this.cmb_shiptype.HighLightRowStyle = style69;
            this.cmb_shiptype.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_shiptype.Images"))));
            this.cmb_shiptype.ItemHeight = 15;
            this.cmb_shiptype.Location = new System.Drawing.Point(446, 59);
            this.cmb_shiptype.MatchEntryTimeout = ((long)(2000));
            this.cmb_shiptype.MaxDropDownItems = ((short)(5));
            this.cmb_shiptype.MaxLength = 32767;
            this.cmb_shiptype.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shiptype.Name = "cmb_shiptype";
            this.cmb_shiptype.OddRowStyle = style70;
            this.cmb_shiptype.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shiptype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shiptype.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shiptype.SelectedStyle = style71;
            this.cmb_shiptype.Size = new System.Drawing.Size(220, 20);
            this.cmb_shiptype.Style = style72;
            this.cmb_shiptype.TabIndex = 384;
            this.cmb_shiptype.PropBag = resources.GetString("cmb_shiptype.PropBag");
            // 
            // lbl_shiptype
            // 
            this.lbl_shiptype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shiptype.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shiptype.ImageIndex = 0;
            this.lbl_shiptype.ImageList = this.img_Label;
            this.lbl_shiptype.Location = new System.Drawing.Point(344, 59);
            this.lbl_shiptype.Name = "lbl_shiptype";
            this.lbl_shiptype.Size = new System.Drawing.Size(100, 21);
            this.lbl_shiptype.TabIndex = 383;
            this.lbl_shiptype.Text = "Ship Type";
            this.lbl_shiptype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_shiptype.Click += new System.EventHandler(this.lbl_shiptype_Click);
            // 
            // lbl_bar_cd
            // 
            this.lbl_bar_cd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_bar_cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bar_cd.ImageIndex = 0;
            this.lbl_bar_cd.ImageList = this.img_Label;
            this.lbl_bar_cd.Location = new System.Drawing.Point(680, 81);
            this.lbl_bar_cd.Name = "lbl_bar_cd";
            this.lbl_bar_cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_bar_cd.TabIndex = 381;
            this.lbl_bar_cd.Text = "Bar Code";
            this.lbl_bar_cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_bar_cd
            // 
            this.txt_bar_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bar_cd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_bar_cd.Location = new System.Drawing.Point(784, 81);
            this.txt_bar_cd.MaxLength = 25;
            this.txt_bar_cd.Name = "txt_bar_cd";
            this.txt_bar_cd.Size = new System.Drawing.Size(160, 21);
            this.txt_bar_cd.TabIndex = 382;
            this.txt_bar_cd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_bar_cd_KeyDown);
            // 
            // lbl_specification
            // 
            this.lbl_specification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_specification.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_specification.ImageIndex = 0;
            this.lbl_specification.ImageList = this.img_Label;
            this.lbl_specification.Location = new System.Drawing.Point(680, 59);
            this.lbl_specification.Name = "lbl_specification";
            this.lbl_specification.Size = new System.Drawing.Size(100, 21);
            this.lbl_specification.TabIndex = 374;
            this.lbl_specification.Text = "Invoice No.";
            this.lbl_specification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_specification
            // 
            this.txt_specification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_specification.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_specification.Location = new System.Drawing.Point(784, 59);
            this.txt_specification.MaxLength = 25;
            this.txt_specification.Name = "txt_specification";
            this.txt_specification.Size = new System.Drawing.Size(160, 21);
            this.txt_specification.TabIndex = 380;
            this.txt_specification.TextChanged += new System.EventHandler(this.txt_specification_TextChanged);
            // 
            // lbl_scan_date
            // 
            this.lbl_scan_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_scan_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scan_date.ImageIndex = 1;
            this.lbl_scan_date.ImageList = this.img_Label;
            this.lbl_scan_date.Location = new System.Drawing.Point(344, 103);
            this.lbl_scan_date.Name = "lbl_scan_date";
            this.lbl_scan_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_scan_date.TabIndex = 381;
            this.lbl_scan_date.Text = "Scan Date";
            this.lbl_scan_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_scan_date
            // 
            this.dpick_scan_date.CustomFormat = "";
            this.dpick_scan_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_scan_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_scan_date.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_scan_date.Location = new System.Drawing.Point(446, 103);
            this.dpick_scan_date.Name = "dpick_scan_date";
            this.dpick_scan_date.Size = new System.Drawing.Size(100, 21);
            this.dpick_scan_date.TabIndex = 380;
            this.dpick_scan_date.Value = new System.DateTime(2007, 6, 4, 15, 12, 42, 265);
            this.dpick_scan_date.ValueChanged += new System.EventHandler(this.dpick_scan_date_ValueChanged);
            // 
            // spd_main
            // 
            this.spd_main.ContextMenu = this.cmenu_Barcode;
            this.spd_main.Location = new System.Drawing.Point(12, 138);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this._mainSheet);
            this.spd_main.Size = new System.Drawing.Size(950, 402);
            this.spd_main.TabIndex = 0;
            // 
            // cmenu_Barcode
            // 
            this.cmenu_Barcode.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuitem_SelectAll,
            this.menuItem1,
            this.menuItem2,
            this.menuitem_DeSelectAll,
            this.menuItem3});
            this.cmenu_Barcode.Popup += new System.EventHandler(this.cmenu_Barcode_Popup);
            // 
            // menuitem_SelectAll
            // 
            this.menuitem_SelectAll.Index = 0;
            this.menuitem_SelectAll.Text = "Select All";
            this.menuitem_SelectAll.Click += new System.EventHandler(this.menuitem_SelectAll_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "Select Check";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "-";
            // 
            // menuitem_DeSelectAll
            // 
            this.menuitem_DeSelectAll.Index = 3;
            this.menuitem_DeSelectAll.Text = "DeSelect All";
            this.menuitem_DeSelectAll.Click += new System.EventHandler(this.menuitem_DeSelectAll_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            this.menuItem3.Text = "DeSelect Chekc";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // _mainSheet
            // 
            this._mainSheet.SheetName = "Sheet1";
            // 
            // Pop_BI_Incoming_Barcode
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(968, 638);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BI_Incoming_Barcode";
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_barKind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sstype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_incheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shiptype)).EndInit();
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
			this.menuitem_SelectAll.Visible		= true;
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

		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
            txt_bar_cd.Select();
		}
		
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			search_type = "Btn";
			txt_bar_cd.Text = "";
			this.Btn_SearchClickProcess();							
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{			

			if (_mainSheet.Rows.Count <=0) return;

			if (chk_auto.Checked == true)
			    this.Return_Auto_Data();
			else 
				this.Return_Data();
				
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

//		private void btn_groupSearch_Click(object sender, System.EventArgs e)
//		{
//			string vTyep = this.cmb_itemGroup.SelectedValue.ToString();
//			FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);
//
//			vPopup.ShowDialog();
//			
//			string _group_cd	= COM.ComVar.Parameter_PopUp[3];				
//			string _group_name	= COM.ComVar.Parameter_PopUp[4];				
//			txt_itemCd.Text		= _group_cd;
//			txt_itemNm.Text		= _group_name;
//			
//			vPopup.Dispose();		
//		}

//		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
//		{
//			if (cmb_itemGroup.SelectedIndex >= 0 )
//				this.btn_groupSearch.Enabled = true;
//			else
//				this.btn_groupSearch.Enabled = false;
//		}

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
			lbl_MainTitle.Text = "Incoming Barcode";
            this.Text = "Incoming Barcode";
            ClassLib.ComFunction.SetLangDic(this);

		

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// Item Group Combobox Setting
//			vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
//			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
//			vDt.Dispose();

			// BarKind Combobox Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBS05");
			COM.ComCtl.Set_ComboList(vDt, cmb_barKind, 1, 2, true, 56,0);
			cmb_barKind.SelectedIndex = -1;
			vDt.Dispose();

			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBM09");
			COM.ComCtl.Set_ComboList(vDt, cmb_shiptype, 1, 2, false, 56,0);
			cmb_shiptype.SelectedIndex = 0;
			vDt.Dispose();

//			// cmb_user
//			vDt =  ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory);
//			ClassLib.ComCtl.Set_ComboList(vDt,cmb_user,1, 2,(vDt.Rows.Count > 1) ? true : false);
//			//ClassLib.ComCtl.Set_ComboList(vDt,cmb_user,4, 2, false);
//			//cmb_user.SelectedValue = COM.ComVar.This_User;
//			cmb_user.SelectedIndex = 0;
//			vDt.Dispose();


			// cmb_user
			vDt =  Select_Man_Charge(COM.ComVar.This_Factory);
			//ClassLib.ComCtl.Set_ComboList(vDt,cmb_user,1, 2,(vDt.Rows.Count > 1) ? true : false);
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_user,4, 2, false);
			//cmb_user.SelectedValue = COM.ComVar.This_User;
			cmb_user.SelectedIndex = 0;
			vDt.Dispose();


			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SEM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_incheck, 1, 2, false, 56,0);
			cmb_incheck.SelectedIndex = 1;


			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SEM35");
			COM.ComCtl.Set_ComboList(vDt, cmb_outside, 1, 2, true, 56,0);
			//cmb_outside.SelectedIndex = 1;
			cmb_outside.SelectedValue = COM.ComVar.Parameter_PopUp[2];


			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBI03");
			COM.ComCtl.Set_ComboList(vDt, cmb_sstype, 1, 2, false, 56,0);
			cmb_sstype.SelectedIndex = 0;


			// Pur  Factory Combobox Setting		
			vDt = ClassLib.ComFunction.Select_Data_List(ClassLib.ComVar.This_Factory, "SBI04");
			COM.ComCtl.Set_ComboList(vDt, cmb_pur_factory , 5, 6, true,false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;


			// default search proviso
			if (COM.ComVar.Parameter_PopUp[0].ToString() != "")
				cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
			dpick_from.Value			= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
			dpick_to.Value				= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);


			//Auto Check 
			chk_auto.Enabled  = false;
			chk_auto.Checked  = false;
			dpick_scan_date.Enabled  =false;



			//scan date
			///날짜
			dpick_scan_date.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			string now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_scan_date.Text = MyComFunction.ConvertDate2Type(now);


			// user define variable setting
			_mainSheet = spd_main.Sheets[0];


			#region 그리드 설정
				
			spd_main.Set_Spread_Comm("SBI_INCOMING_BARCODE", "6", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

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

			_RowFixed = spd_main.ActiveSheet.Rows.Count;

            #endregion


			// Disabled tbutton
			tbtn_Save.Enabled		= false;
			tbtn_Delete.Enabled		= false;
			tbtn_Conform.Enabled	= false;
			tbtn_Print.Enabled		= true;
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
			for(int i = 0; i <= (int)ClassLib.TBSBI_IN_TAIL.IxUPD_YMD; i++)
			{
				_DT.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			}
		}




		private void Set_Color()
		{

			if (chk_auto.Checked   == false)  //by Manual
			{
				for ( int i = 0; i < _mainSheet.Rows.Count; i++)
				{
					if(bool.Parse(spd_main.ActiveSheet.Cells[i, _lxQtyChkCol].Value.ToString()))
					{
						spd_main.ActiveSheet.Rows[i].Locked	= true;
					}

					if(spd_main.ActiveSheet.Cells[i, _lxInOkCol].Value.ToString() == "N") spd_main.ActiveSheet.Rows[i].BackColor = Color.FromArgb(245, 173, 173);
						
						
					if(spd_main.ActiveSheet.Cells[i, _lxAttributeCol].Value.ToString() == "S" || spd_main.ActiveSheet.Cells[i, _lxPackingCol].Value.ToString().Substring(0,1) == "*")
					{
						spd_main.ActiveSheet.Rows[i].BackColor = Color.FromArgb(200, 254, 173);
					}
				}
			}
			else       //by Auto
			{

				for ( int i = 0; i < _mainSheet.Rows.Count; i++)
				{
					if(bool.Parse(spd_main.ActiveSheet.Cells[i, _lxQtyChkCol_Auto].Value.ToString()))
					{
						spd_main.ActiveSheet.Rows[i].Locked	= true;
					}

					if(spd_main.ActiveSheet.Cells[i, _lxInOkCol_Auto].Value.ToString() == "N") spd_main.ActiveSheet.Rows[i].BackColor = Color.FromArgb(245, 173, 173);
						
						
					if(spd_main.ActiveSheet.Cells[i, _lxAttributeCol_Auto].Value.ToString() == "S" || spd_main.ActiveSheet.Cells[i, _lxPackingCol].Value.ToString().Substring(0,1) == "*")
					{
						spd_main.ActiveSheet.Rows[i].BackColor = Color.FromArgb(200, 254, 173);
					}
				}
			}

		}







		private void Btn_SearchClickProcess()
		{
			try
			{

					if(search_type == "Btn")
					{
						string vsedor_cd = null;

						if(cmb_vendor.SelectedValue.ToString().Length == 6)
						{
							vsedor_cd = cmb_vendor.SelectedValue.ToString();
						}
						else
						{
							vsedor_cd = "000000";
						}

						 
						string user_cd   = cmb_user.SelectedValue.ToString();
						string ship_type = cmb_shiptype.SelectedValue.ToString();

						txt_specification.Text = cmb_factory.SelectedValue.ToString() + dpick_from.Text.Replace("-","") + user_cd + vsedor_cd + ship_type + cmb_outside.SelectedIndex.ToString() + print_seq;
					}
					else if(search_type == "NoScan")
					{
						if(txt_specification.Text.Length != 25)
						{
							MessageBox.Show("Check BarCode!!");
							return;
						}
					}
					else
					{
						if(txt_specification.Text.Length != 25)
						{
							MessageBox.Show("Check BarCode!!");
							return;
						}
					}



				this.Cursor = Cursors.WaitCursor;
				spd_main.ActiveSheet.Rows.Count = _RowFixed;


				DataTable vDt = null;
				

			    
				if( chk_auto.Checked == true)
				{
					vDt = this.SELECT_SBI_BARCODE_AUTOSCAN_LIST(cmb_sstype.SelectedValue.ToString()); //스캐너를 이용한  방식
				
				}
				else
				{ 
					vDt = this.SELECT_SBI_BARCODE_MANUALSCANLIST(cmb_sstype.SelectedValue.ToString()); //수작업 방식

				}


				if (vDt.Rows.Count > 0)
				{
					spd_main.Display_Grid(vDt);

					Set_Color();
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
				this.cmb_barKind.SelectedIndex		= -1;				
				this.cmb_user.SelectedIndex			= -1;
//				this.cmb_vendor.SelectedIndex		= -1;
//				this.cmb_itemCd.SelectedIndex		= -1;
				this.txt_vendorCode.Text			= "";
				this.txt_itemCd.Text				= "";
				this.txt_itemNm.Text				= "";
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}
		
		#endregion

		#region Return DataTable 관련 메서드


			
		/// <summary>
		/// Select Bacode Data Return
		/// </summary>
		private void Return_Auto_Data()
		{
			try
			{
				Make_Auto_DT(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Return_Auto_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
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
		/// Make_Auto_DT_Component : 
		/// </summary>
		private void Make_Auto_DT()
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
						//vFlag = Etc_DataDuplicateCheck_FSP(i);      /*현업요구로 막음: 20070827 */


						if (vFlag == 0)
						{
							datarow = _DT.NewRow();

							//mat관련
							datarow[_ldFactoryCol]		= _mainSheet.Cells[i, _lxFactoryCol_Auto].Value.ToString();
							datarow[_ldItemCdCol]		= _mainSheet.Cells[i, _lxItemCdCol_Auto].Value.ToString();
							datarow[_ldItemNameCol]		= _mainSheet.Cells[i, _lxItemNameCol_Auto].Value.ToString();
							datarow[_ldSpecCdCol]		= _mainSheet.Cells[i, _lxSpecCdCol_Auto].Value.ToString();
							datarow[_ldSpecNameCol]		= _mainSheet.Cells[i, _lxSpecNameCol_Auto].Value.ToString();
							datarow[_ldColorCdCol]		= _mainSheet.Cells[i, _lxColorCdCol_Auto].Value.ToString();
							datarow[_ldColorNameCol]	= _mainSheet.Cells[i, _lxColorNameCol_Auto].Value.ToString();
							datarow[_ldUnitCol]			= _mainSheet.Cells[i, _lxUnitCol_Auto].Value.ToString();


							//scan관련
							datarow[_ldInQtyCol]		= _mainSheet.Cells[i, _lxVenderScanQtyCol_Auto].Value.ToString();

							
							datarow[_ldPkUnitQtyCol]	= _mainSheet.Cells[i, _lxPkUnitQtyCol_Auto].Value.ToString();

							//금액관련
							datarow[_ldPurCurrencyCol]	= _mainSheet.Cells[i, _lxPurCurrencyCol_Auto].Value.ToString();
							datarow[_ldPurPriceCol]		= _mainSheet.Cells[i, _lxPurPriceCol_Auto].Value.ToString();

							datarow[_ldCbdCurrencyCol]	= _mainSheet.Cells[i, _lxCbdCurrencyCol_Auto].Value.ToString();
							datarow[_ldCbdPriceCol]		= _mainSheet.Cells[i, _lxCbdPriceCol_Auto].Value.ToString();
							
							datarow[_ldShipCurrencyCol] = _mainSheet.Cells[i, _lxShipCurrencyCol_Auto].Value.ToString();
							datarow[_ldShipPriceCol]	= _mainSheet.Cells[i, _lxShipPriceCol_Auto].Value.ToString();
							
							datarow[_ldPriceYnCol]		= _mainSheet.Cells[i, _lxPriceYnCol_Auto].Value.ToString();





							datarow[_ldCustCdCol]		= _mainSheet.Cells[i, _lxCustCdCol_Auto].Value.ToString();
							datarow[_ldCustNameCol]		= _mainSheet.Cells[i, _lxCustNameCol_Auto].Value.ToString();

							datarow[_ldBarCodeCol]		= _mainSheet.Cells[i, _lxBarCodeCol_Auto].Value.ToString();
							datarow[_ldBarKindCol]		= _mainSheet.Cells[i, _lxBarKindCol_Auto].Value.ToString();
							datarow[_ldContNoCol]		= _mainSheet.Cells[i, _lxContNoCol_Auto].Value.ToString();

							datarow[_ldShipYmdCol]		= _mainSheet.Cells[i, _lxShipYmdCol_Auto].Value.ToString();
							datarow[_ldShipNoCol]		= _mainSheet.Cells[i, _lxShipNoCol_Auto].Value.ToString();
							datarow[_ldShipSeqCol]		= _mainSheet.Cells[i, _lxShipSeqCol_Auto].Value.ToString();

							datarow[_ldLotNoCol]		= _mainSheet.Cells[i, _lxLotNoCol_Auto].Value.ToString();
							datarow[_ldLotSeqCol]		= _mainSheet.Cells[i, _lxLotSeqCol_Auto].Value.ToString();
							
							datarow[_ldStyleCdCol]		= _mainSheet.Cells[i, _lxStyleCdCol_Auto].Value.ToString();
							datarow[_ldStyleNameCol]	= _mainSheet.Cells[i, _lxStyleNameCol_Auto].Value.ToString();
							
							datarow[_ldWhCdCol]			= _mainSheet.Cells[i, _lxWhCdCol_Auto].Value.ToString();
							datarow[_ldWhNameCol]		= _mainSheet.Cells[i, _lxWhNameCol_Auto].Value.ToString();

							datarow[_ldPurDivCol]		= _mainSheet.Cells[i, _lxPurDivCdCol_Auto].Value.ToString();
							datarow[_ldPurUserCol]		= _mainSheet.Cells[i, _lxPurUserCol_Auto].Value.ToString();

							datarow[_ldTranDivCol]		= "B";


							// 정환정 추가
							datarow[_ldLedgerPriceCol]		= "0";
							datarow[_ldLedgerCurrencyCol]		= "";

							//							datarow[_ldPurNoCol]        = "aaaa";
							//							datarow[_ldPurSeqCol]       = "1111";
							//							datarow[_ldPurUserCol]      = "CCCC";
							//							datarow[_ldPurDeptCol]      = "DDDD";


										
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
					this.Close();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Return_Auto_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
						//vFlag = Etc_DataDuplicateCheck_FSP(i);   /*현업요구로 막음: 20070827 */

						if (vFlag == 0)
						{
							datarow = _DT.NewRow();

							//mat관련
							datarow[_ldFactoryCol]		= _mainSheet.Cells[i, _lxFactoryCol].Value.ToString();
							datarow[_ldItemCdCol]		= _mainSheet.Cells[i, _lxItemCdCol].Value.ToString();
							datarow[_ldItemNameCol]		= _mainSheet.Cells[i, _lxItemNameCol].Value.ToString();
							datarow[_ldSpecCdCol]		= _mainSheet.Cells[i, _lxSpecCdCol].Value.ToString();
							datarow[_ldSpecNameCol]		= _mainSheet.Cells[i, _lxSpecNameCol].Value.ToString();
							datarow[_ldColorCdCol]		= _mainSheet.Cells[i, _lxColorCdCol].Value.ToString();
							datarow[_ldColorNameCol]	= _mainSheet.Cells[i, _lxColorNameCol].Value.ToString();
							datarow[_ldUnitCol]			= _mainSheet.Cells[i, _lxUnitCol].Value.ToString();


							//scan관련
							datarow[_ldInQtyCol]		= (double.Parse(_mainSheet.Cells[i, _lxScanQtyCol].Value.ToString())-double.Parse(_mainSheet.Cells[i, _lxInQtyCol].Value.ToString())).ToString();

							
							datarow[_ldPkUnitQtyCol]	= _mainSheet.Cells[i, _lxPkUnitQtyCol].Value.ToString();

							//금액관련
							datarow[_ldPurCurrencyCol]	= _mainSheet.Cells[i, _lxPurCurrencyCol].Value.ToString();
							datarow[_ldPurPriceCol]		= _mainSheet.Cells[i, _lxPurPriceCol].Value.ToString();

							datarow[_ldCbdCurrencyCol]	= _mainSheet.Cells[i, _lxCbdCurrencyCol].Value.ToString();
							datarow[_ldCbdPriceCol]		= _mainSheet.Cells[i, _lxCbdPriceCol].Value.ToString();
							
							datarow[_ldShipCurrencyCol] = _mainSheet.Cells[i, _lxShipCurrencyCol].Value.ToString();
							datarow[_ldShipPriceCol]	= _mainSheet.Cells[i, _lxShipPriceCol].Value.ToString();
							
							datarow[_ldPriceYnCol]		= _mainSheet.Cells[i, _lxPriceYnCol].Value.ToString();





							datarow[_ldCustCdCol]		= _mainSheet.Cells[i, _lxCustCdCol].Value.ToString();
							datarow[_ldCustNameCol]		= _mainSheet.Cells[i, _lxCustNameCol].Value.ToString();

							datarow[_ldBarCodeCol]		= _mainSheet.Cells[i, _lxBarCodeCol].Value.ToString();
							datarow[_ldBarKindCol]		= _mainSheet.Cells[i, _lxBarKindCol].Value.ToString();
							datarow[_ldContNoCol]		= _mainSheet.Cells[i, _lxContNoCol].Value.ToString();

							datarow[_ldShipYmdCol]		= _mainSheet.Cells[i, _lxShipYmdCol].Value.ToString();
							datarow[_ldShipNoCol]		= _mainSheet.Cells[i, _lxShipNoCol].Value.ToString();
							datarow[_ldShipSeqCol]		= _mainSheet.Cells[i, _lxShipSeqCol].Value.ToString();

							datarow[_ldLotNoCol]		= _mainSheet.Cells[i, _lxLotNoCol].Value.ToString();
							datarow[_ldLotSeqCol]		= _mainSheet.Cells[i, _lxLotSeqCol].Value.ToString();
							
							datarow[_ldStyleCdCol]		= _mainSheet.Cells[i, _lxStyleCdCol].Value.ToString();
							datarow[_ldStyleNameCol]	= _mainSheet.Cells[i, _lxStyleNameCol].Value.ToString();
							
							datarow[_ldWhCdCol]			= _mainSheet.Cells[i, _lxWhCdCol].Value.ToString();
							datarow[_ldWhNameCol]		= _mainSheet.Cells[i, _lxWhNameCol].Value.ToString();

							datarow[_ldPurDivCol]		= _mainSheet.Cells[i, _lxPurDivCdCol].Value.ToString();
							datarow[_ldPurUserCol]		= _mainSheet.Cells[i, _lxPurUserCol].Value.ToString();

							datarow[_ldTranDivCol]		= "B";


							// 정환정 추가
							datarow[_ldLedgerPriceCol]		= "0";
							datarow[_ldLedgerCurrencyCol]		= "";

//							datarow[_ldPurNoCol]        = "aaaa";
//							datarow[_ldPurSeqCol]       = "1111";
//							datarow[_ldPurUserCol]      = "CCCC";
//							datarow[_ldPurDeptCol]      = "DDDD";


										
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


		


//					DataTable dt_barcode = vPopup._DT;
//					if (dt_barcode != null && dt_barcode.Rows.Count > 0 && vPopup.DialogResult == DialogResult.OK)
//					{
//						// 그리드에 BarCode 정보 추가
//						Apply_Grid(dt_barcode); 
//					}		



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



		private int Etc_DataDuplicateCheck_FSP(int arg_row, bool arg_auto)
		{
			int vReturn = 0;

			if (arg_auto  == true)
			{
				for ( int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++ )
				{
					if( fgrid_main[vRow, _checkCols[0]].ToString().Replace("-", "").Equals(_mainSheet.Cells[arg_row, _lxStyleCdCol_Auto].Value.ToString()) &&
						fgrid_main[vRow, _checkCols[1]].ToString().Equals(_mainSheet.Cells[arg_row, _lxItemCdCol_Auto].Value.ToString()) &&
						fgrid_main[vRow, _checkCols[2]].ToString().Equals(_mainSheet.Cells[arg_row, _lxSpecCdCol_Auto].Value.ToString()) &&
						fgrid_main[vRow, _checkCols[3]].ToString().Equals(_mainSheet.Cells[arg_row, _lxColorCdCol_Auto].Value.ToString()) &&
						fgrid_main[vRow, _checkCols[4]].ToString().Equals(_mainSheet.Cells[arg_row, _lxBarCodeCol_Auto].Value.ToString())) 
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
			else   //manual
			{

				for ( int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++ )
				{
					if( fgrid_main[vRow, _checkCols[0]].ToString().Replace("-", "").Equals(_mainSheet.Cells[arg_row, _lxStyleCdCol].Value.ToString()) &&
						fgrid_main[vRow, _checkCols[1]].ToString().Equals(_mainSheet.Cells[arg_row, _lxItemCdCol].Value.ToString()) &&
						fgrid_main[vRow, _checkCols[2]].ToString().Equals(_mainSheet.Cells[arg_row, _lxSpecCdCol].Value.ToString()) &&
						fgrid_main[vRow, _checkCols[3]].ToString().Equals(_mainSheet.Cells[arg_row, _lxColorCdCol].Value.ToString()) &&
						fgrid_main[vRow, _checkCols[4]].ToString().Equals(_mainSheet.Cells[arg_row, _lxBarCodeCol].Value.ToString())&&
						fgrid_main[vRow, _checkCols[3]].ToString().Equals(_mainSheet.Cells[arg_row, _lxScanDateCol].Value.ToString())) 
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
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		////// SELECT_SBI_BARCODE_LIST(윤은숙 수작업 입고)
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_ship_ymd_from">선적일(From)</param>
		/// <param name="arg_ship_ymd_to">선적일(To)</param>
		/// <param name="arg_size">Size Item</param>
		/// <param name="arg_ship_type">선적구분</param>
		/// <param name="arg_obs_type">OBS Type</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_BARCODE_MANUALSCANLIST(string arg_sstype)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명

			if(arg_sstype == "N")
			{
				MyOraDB.Process_Name = "PKG_SBI_IN_BARCODE.SELECT_SBS_MANUALBAR_LIST_N";
			}
			else
			{
				MyOraDB.Process_Name = "PKG_SBI_IN_BARCODE.SELECT_SBS_MANUALBAR_LIST_S";
			}

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_INVOICE_NO";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TO";
			MyOraDB.Parameter_Name[2] = "ARG_BAR_KIND";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[4] = "ARG_INCHECK_YN";
			MyOraDB.Parameter_Name[5] = "ARG_LOC_FACTORY";
			MyOraDB.Parameter_Name[6] = "ARG_PUR_FACTORY";
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]= (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_TextBox(this.txt_specification, " ");
			MyOraDB.Parameter_Values[1] = dpick_to.Text.Trim().Replace("-","");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(this.cmb_barKind, " ");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_TextBox(this.txt_itemCd, " ");
			MyOraDB.Parameter_Values[4] = cmb_incheck.SelectedValue.ToString();
			MyOraDB.Parameter_Values[5] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_Combo(this.cmb_pur_factory, " ");
			MyOraDB.Parameter_Values[7] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		
		}



		/// <summary>
		/// SELECT_SBI_BARCODE_AUTOSCAN_LIST(윤은숙 스캐너 이용한 입고) : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_ship_ymd_from">선적일(From)</param>
		/// <param name="arg_ship_ymd_to">선적일(To)</param>
		/// <param name="arg_size">Size Item</param>
		/// <param name="arg_ship_type">선적구분</param>
		/// <param name="arg_obs_type">OBS Type</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_BARCODE_AUTOSCAN_LIST(string arg_sstype)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(9);

			//01.PROCEDURE명

			if(arg_sstype == "N")
			{
				MyOraDB.Process_Name = "PKG_SBI_IN_BARCODE.SELECT_SBS_AUTOBAR_LIST_N";
			}
			else
			{
				MyOraDB.Process_Name = "PKG_SBI_IN_BARCODE.SELECT_SBS_AUTOBAR_LIST_S";
			}

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_INVOICE_NO";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TO";
			MyOraDB.Parameter_Name[2] = "ARG_BAR_KIND";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[4] = "ARG_INCHECK_YN";
			MyOraDB.Parameter_Name[5] = "ARG_LOC_FACTORY";
			MyOraDB.Parameter_Name[6] = "ARG_PUR_FACTORY";
			MyOraDB.Parameter_Name[7] = "ARG_SCAN_DATE";
			MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8]=  (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_TextBox(this.txt_specification, " ");
			MyOraDB.Parameter_Values[1] = dpick_to.Text.Trim().Replace("-","");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(this.cmb_barKind, " ");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_TextBox(this.txt_itemCd, " ");
			MyOraDB.Parameter_Values[4] = cmb_incheck.SelectedValue.ToString();
			MyOraDB.Parameter_Values[5] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_Combo(this.cmb_pur_factory, " ");
			MyOraDB.Parameter_Values[7] =  dpick_scan_date.Value.ToString("yyyyMMdd").Replace("-","");
			MyOraDB.Parameter_Values[8] = "";

			//dpick_scan_date.Text  = dpick_scan_date.Value.ToString("yyyyMMdd");

		
			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		
		}

        /// <summary>
        /// PKG_SVX_IN_01.SELECT_VAN_SBS_BAR_LIST_R : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_VAN_SBS_BAR_LIST_R(string arg_invoice_no)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(2);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SVX_IN_01.SELECT_VAN_SBS_BAR_LIST_R";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_INVOICE_NO";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_invoice_no;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



		#endregion

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}

		private void txt_bar_cd_TextChanged(object sender, System.EventArgs e)
		{
			if(txt_bar_cd.Text.Length == 2)
			{
				v_factory = txt_bar_cd.Text.Substring(0,2);
				if(cmb_factory.SelectedValue.ToString() != v_factory)
				{
					MessageBox.Show("Check Factory Code");
					txt_bar_cd.Text  = "";
					txt_bar_cd.Focus();
					return;
				}
			}
			else if(txt_bar_cd.Text.Length == 10)
			{
				if(ClassLib.ComFunction.Check_Digit(txt_bar_cd.Text.Substring(2,8)))
				{
					v_ship_ymd = txt_bar_cd.Text.Substring(2,8);

					try
					{
						dpick_from.Value = ClassLib.ComFunction.StringToDateTime(v_ship_ymd);
						dpick_to.Value = ClassLib.ComFunction.StringToDateTime(v_ship_ymd);
					}
					catch
					{
						MessageBox.Show("Check Shipping Date");
						txt_bar_cd.Text  = "";
						txt_bar_cd.Focus();
						return;
					}
					
				}
				else
				{
					MessageBox.Show("Check Shipping Date");
					txt_bar_cd.Text  = "";
					txt_bar_cd.Focus();
					return;
				}
			}
			else if(txt_bar_cd.Text.Length == 13)
			{
				v_pur_user = txt_bar_cd.Text.Substring(10,3);
				cmb_user.SelectedValue = v_pur_user;
			}
			else if(txt_bar_cd.Text.Length == 19)
			{
				if(ClassLib.ComFunction.Check_Digit(txt_bar_cd.Text.Substring(13,6)))
				{
					v_vendor_cd = txt_bar_cd.Text.Substring(13,6);
					txt_vendorCode.Text = v_vendor_cd;
					Txt_VendorCodeTextChangedProcess();
				}
				else
				{
					MessageBox.Show("Check Vendor Code");
					txt_bar_cd.Text  = "";
					txt_bar_cd.Focus();
					return;
				}
			}
			else if(txt_bar_cd.Text.Length == 21)
			{
				if(ClassLib.ComFunction.Check_Digit(txt_bar_cd.Text.Substring(19,2)))
				{
					v_ship_type = txt_bar_cd.Text.Substring(19, 2);

					try
					{
						cmb_shiptype.SelectedValue = v_ship_type;
					}
					catch
					{
						MessageBox.Show("Check Shep Type");
						txt_bar_cd.Text  = "";
						txt_bar_cd.Focus();
						return;
					}
				}
				else
				{
					MessageBox.Show("Check Shep Type");
					txt_bar_cd.Text  = "";
					txt_bar_cd.Focus();
					return;
				}
			}
			else if(txt_bar_cd.Text.Length == 22)
			{
				if(ClassLib.ComFunction.Check_Digit(txt_bar_cd.Text.Substring(21,1)))
				{
					v_outside = txt_bar_cd.Text.Substring(21, 1);

					if(v_outside == "0") cmb_outside.SelectedIndex = 0;
					else if(v_outside == "2") cmb_outside.SelectedIndex = 2;
					else cmb_outside.SelectedIndex = 1;
				}
				else
				{
					MessageBox.Show("Check OutSide Division");
					txt_bar_cd.Text  = "";
					txt_bar_cd.Focus();
					return;
				}
			}
			else if(txt_bar_cd.Text.Length == 25)
			{
				if(ClassLib.ComFunction.Check_Digit(txt_bar_cd.Text.Substring(22,3)))
				{
					v_page_cnt = txt_bar_cd.Text.Substring(22,3);
					//txt_vendorCode.Text = v_vendor_cd;
				}
				else
				{
					MessageBox.Show("Check Page Count");
					txt_bar_cd.Text  = "";
					txt_bar_cd.Focus();
					return;
				}



				
			
				txt_specification.Text = v_factory + v_ship_ymd + v_pur_user + v_vendor_cd + v_ship_type + v_outside + v_page_cnt;
				txt_bar_cd.Text = "";

				cmb_incheck.SelectedValue = "Y";
				
				v_factory   = null;
				v_ship_ymd  = null;
				v_vendor_cd = null;
				v_ship_type = null;
				v_page_cnt  = null;
				
				search_type = "Bar";
				this.Btn_SearchClickProcess();

                MatAutoCheck();
			}
		}

        private bool SetSearchCondsion()
        {
            if (txt_bar_cd.Text.Length == 25)
            {
                string sFactory = txt_bar_cd.Text.Substring(0, 2);
                string sShipYmd = txt_bar_cd.Text.Substring(2, 8);
                string sUser = txt_bar_cd.Text.Substring(10, 3);
                string sVendorCode = txt_bar_cd.Text.Substring(13, 6);
                string sShipType = txt_bar_cd.Text.Substring(19, 2);
                string sOutside = txt_bar_cd.Text.Substring(21, 1);
                string sPageCount = txt_bar_cd.Text.Substring(22, 3);

                // check factory 
                if (!cmb_factory.SelectedValue.ToString().Equals(sFactory))
                {
                    MessageBox.Show("Check Factory Code");
                    return false;
                }


                // check ship date 
                try
                {
                    dpick_from.Value = ClassLib.ComFunction.StringToDateTime(sShipYmd);
                    dpick_to.Value = ClassLib.ComFunction.StringToDateTime(sShipYmd);
                }
                catch
                {
                    MessageBox.Show("Check Shipping Date");
                    return false;
                }

                // user 
                cmb_user.SelectedValue = sUser;
                if (cmb_user.SelectedIndex < 0)
                {
                    MessageBox.Show("Check Purchase User");
                    return false;
                }

                // vendor 
                txt_vendorCode.Text = sVendorCode;
                Txt_VendorCodeTextChangedProcess();
                if (cmb_vendor.SelectedIndex < 0)
                {
                    MessageBox.Show("Check Vendor Code");
                    return false;
                }

                // ship type
                cmb_shiptype.SelectedValue = sShipType;
                if (cmb_shiptype.SelectedIndex < 0)
                {
                    MessageBox.Show("Check Shep Type");
                    return false;
                }

                // outside 
                if (sOutside.Equals("0"))
                    cmb_outside.SelectedIndex = 0;
                else if (sOutside.Equals("2"))
                    cmb_outside.SelectedIndex = 2;
                else
                    cmb_outside.SelectedIndex = 1;
                if (cmb_outside.SelectedIndex < 0)
                {
                    MessageBox.Show("Check OutSide Division");
                    return false;
                }

                // check page count
                if (!ClassLib.ComFunction.Check_Digit(sPageCount))
                {
                    MessageBox.Show("Check Page Count");
                    return false;
                }

                txt_specification.Text = sFactory + sShipYmd + sUser + sVendorCode + sShipType + sOutside + sPageCount;
                txt_bar_cd.Text = "";
                cmb_incheck.SelectedValue = "Y";

                search_type = "Bar";

                this.Btn_SearchClickProcess();
                MatAutoCheck();
                return true;
            }

            return false;
        }

        private void MatAutoCheck()
        {
            try
            {
                if (_mainSheet.Rows.Count > 0)
                {
                    DataTable vDT = SELECT_VAN_SBS_BAR_LIST_R(txt_specification.Text);

                    if (vDT != null && vDT.Rows.Count > 0)
                    {
                        for (int iIdx = 0; iIdx < vDT.Rows.Count; iIdx++)
                        {
                            string sBarCodeRep = vDT.Rows[iIdx]["bar_code_rep"].ToString();

                            for (int iRow = 0; iRow < _mainSheet.Rows.Count; iRow++)
                            {
                                string sTargetBarCode = _mainSheet.Cells[iRow, (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxBAR_CODE].Value.ToString();

                                if (sBarCodeRep.Equals(sTargetBarCode))
                                {
                                    if (!(bool)_mainSheet.Cells[iRow, (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxQTY_CHK].Value)
                                    {
                                        _mainSheet.Cells[iRow, (int)ClassLib.TBSBI_INCOMING_MANUAL_BARCODE.IxCHK].Value = true;
                                        spd_main.Update_Row(iRow, img_Action);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Auto check error" + ex.Message);
            }
        }

		private void txt_bar_cd_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
            if (e.Control)
            {
                MessageBox.Show("Can not Press Contro Key");
                return;
            }
            else if (e.KeyData == Keys.Enter)
            {
                if (!SetSearchCondsion())
                {
                    txt_bar_cd.Text = "";
                    txt_bar_cd.Focus();
                }
            }
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_PrintProcess();
		}

		private void Tbtn_PrintProcess()
		{
			string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BI_Incomming");
			string sPara = "/rp ["  + txt_specification.Text.Trim().Substring(0,16) + "000]";
			FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
			MyReport.Text = "Incomming Borcode";
			MyReport.Show();			
		}

		private void txt_specification_TextChanged(object sender, System.EventArgs e)
		{
			if(txt_specification.Text.Length == 25)
			{
				search_type = "Bar";
				this.Btn_SearchClickProcess();
				tbtn_Print.Enabled = true;
			}
			else
			{
				tbtn_Print.Enabled = false;
			}
		}

		private void lbl_shiptype_Click(object sender, System.EventArgs e)
		{
		
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			Setting_division(true);
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			Setting_division(false);
		}

		private void Setting_division(bool arg_bool)
		{
			CellRange[] vSelectionRange = _mainSheet.GetSelections(); 
			
			for (int i = 0 ; i < vSelectionRange.Length; i++)
			{
				int start_row = vSelectionRange[i].Row;
				int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

				for (int j = start_row ; j < end_row; j++)
				{
					if (!_mainSheet.Rows[j].Locked)
						_mainSheet.Cells[j, _lxChkCol].Value = arg_bool;
				}
			}
		}

		/// <summary>
		/// Select_Man_Charge : 담당자리스트
		/// </summary>
		/// <param name="arg_factory">공장코드e</param>
		/// <returns>DataTable</returns>
		private DataTable Select_Man_Charge(string arg_factory)
		{

			string Proc_Name = "PKG_SBI_IN_BARCODE.SELECT_SCM_MAN_CHARGE";

			MyOraDB.ReDim_Parameter(2);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(false);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		private void tbtn_Conform_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}

		private void cmb_sstype_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_sstype.SelectedValue.ToString() == "N")
			{
				lbl_shipDate.Text = "Shipping Date";
				cmb_shiptype.Enabled = true;
			}
			else
			{
				lbl_shipDate.Text = "Scan Date";
				cmb_shiptype.SelectedValue = "99";
				cmb_shiptype.Enabled = false;
			}
		}

		private void chk_auto_CheckedChanged(object sender, System.EventArgs e)
		{
			
			

			if (chk_auto.Checked  == true)  //By Auto
			{
				dpick_scan_date.Enabled  =true;

				spd_main.Set_Spread_Comm("SBI_INCOMING_BARCODE", "5", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			}
			else  //By Manaul
			{  

				dpick_scan_date.Enabled  =false;
				
				spd_main.Set_Spread_Comm("SBI_INCOMING_BARCODE", "6", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			}
    
			
			#region  user define variable setting
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

			_RowFixed = spd_main.ActiveSheet.Rows.Count;

			#endregion 

		}

		private void dpick_scan_date_ValueChanged(object sender, System.EventArgs e)
		{
			//dpick_scan_date.Text  = dpick_scan_date.Value.ToString("yyyyMMdd");
		}


	}
}

