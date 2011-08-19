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
	public class Pop_BO_Outgoing_Cont : COM.PCHWinForm.Pop_Large
	{
		#region 컨트롤 정의 및 리소스 정의 
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_shipDate;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private System.Windows.Forms.Label lbl_vendor;
		private C1.Win.C1List.C1Combo cmb_user;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.Label lbl_itemGroup;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label btn_groupSearch;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.TextBox txt_itemCd;
		private System.Windows.Forms.TextBox txt_itemNm;
		private C1.Win.C1List.C1Combo cmb_barMove;
		private System.Windows.Forms.Label lbl_barMove;
		private System.Windows.Forms.Label lbl_contNo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnl_menu;
		private C1.Win.C1List.C1Combo cmb_container;
		#endregion 

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		
		private COM.FSP fgrid_main;
		private int[] _checkCols;
		private bool _isAccessible = true;

		//메인창으로 리턴될 데이터 테이블
		public DataTable _DT;  

 	   private int _lxChkCol		= (int)ClassLib.TBSBO_OUTGOING_CONT.IxCHK;
//		private int _lxFactoryCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxFACTORY;
//		private int _lxItemCdCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxITEM_CD;
//		private int _lxItemNameCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxITEM_NAME;
//		private int _lxSpecCdCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxSPEC_CD;
//		private int _lxSpecNameCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxSEPC_NAME;
//		private int _lxColorCdCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxCOLOR_CD;
//		private int _lxColorNameCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxCOLOR_NAME;
//		private int _lxScanQtyCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxSCAN_QYT;
//		private int _lxUnitCol		= (int)ClassLib.TBSBO_OUTGOING_CONT.IxUNIT;
//		private int _lxPkUnitQtyCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxPK_UNIT_QTY;
//		private int _lxPurCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxPUR_CURRENCY;
//		private int _lxPurPriceCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxPUR_PRICE;
//		private int _lxCbdCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxCBD_CURRENCY;
//		private int _lxCbdPriceCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxCBD_PRICE;
//		private int _lxShipCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxSHIP_CURRENCY;
//		private int _lxShipPriceCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxSHIP_PRICE;
//		private int _lxPriceYnCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxPRICE_YN;
//		private int _lxCustCdCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxCUST_CD;
//		private int _lxCustNameCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxCUST_NAME;
//		private int _lxBarCodeCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxBAR_CODE;
//		private int _lxBarMoveCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxBAR_MOVE;
//		private int _lxContNoCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxCONT_NO;
//		private int _lxShipYmdCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxSHIP_YMD;
//		private int _lxShipNoCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxSHIP_NO;
//		private int _lxShipSeqCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxSHIP_SEQ;
//		private int _lxLotNoCol		= (int)ClassLib.TBSBO_OUTGOING_CONT.IxLOT_NO;
//		private int _lxLotSeqCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxLOT_SEQ;
//		private int _lxStyleCdCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxSTYLE_CD;
//		private int _lxStyleNameCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxSTYLE_NAME;
//		private int _lxWhCdCol		= (int)ClassLib.TBSBO_OUTGOING_CONT.IxWH_CD;
//		private int _lxCheckPurCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxCHECK_PUR;
//		private int _lxCheckCbdCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxCHECK_CBD;
//		private int _lxCheckShipCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxCHECK_SHIP;
////		private int _lxWhNameCol	= (int)ClassLib.TBSBO_OUTGOING_CONT.IxWH_NAME;
//
//	
//		private int _ldFactoryCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxFACTORY -1;
//		private int _ldItemCdCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxITEM_CD -1;
//		private int _ldItemNameCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxITEM_NAME -1;
//		private int _ldSpecCdCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSPEC_CD -1;
//		private int _ldSpecNameCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSPEC_NAME -1;
//		private int _ldColorCdCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_CD -1;
//		private int _ldColorNameCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_NAME -1;
//		private int _ldOutQtyCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_QTY -1;
//		private int _ldUnitCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxUNIT -1;
//		private int _ldPkUnitQtyCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxPK_UNIT_QTY -1;
//		private int _ldPurCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxPUR_CURRENCY -1;
//		private int _ldPurPriceCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxPUR_PRICE -1;
//		private int _ldCbdCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCBD_CURRENCY -1;
//		private int _ldCbdPriceCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCBD_PRICE -1;
//		private int _ldShipCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSHIP_CURRENCY -1;
//		private int _ldShipPriceCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSHIP_PRICE -1;
//		private int _ldPriceYnCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxPRICE_YN -1;
//		private int _ldCustCdCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCUST_CD -1;
//		private int _ldCustNameCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCUST_NAME -1;
//		private int _ldBarCodeCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxBAR_CODE -1;
//		private int _ldBarMoveCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxBAR_MOVE -1;
//		private int _ldContNoCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCONT_NO -1;
//		private int _ldShipYmdCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSHIP_YMD -1;
//		private int _ldShipNoCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSHIP_NO -1;
//		private int _ldShipSeqCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSHIP_SEQ -1;
//		private int _ldLotNoCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxLOT_NO -1;
//		private int _ldLotSeqCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxLOT_SEQ -1;
//		private int _ldStyleCdCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSTYLE_CD -1;
//		private int _ldStyleNameCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSTYLE_NAME -1;
//		private int _ldTranDivCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxTRAN_DIV -1;
//		private int _ldWhCdCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxWH_CD -1;
////		private int _ldPayCdCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxPAY_CD -1;
////		private int _ldOutStatusCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_STATUS -1;
////		private int _ldRemarksCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxREMARKS -1;
////		private int _ldUpdUserCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxUPD_USER -1;
////		private int _ldOutNoCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_NO -1;
////		private int _ldOutSeqCol		= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_SEQ -1;
////		private int _ldShipQtyCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSHIP_QTY -1;
////		private int _ldOutsideCurrencyCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUTSIDE_CURRENCY -1;
////		private int _ldOutsidePriceCol	= (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUTSIDE_PRICE -1;

		#endregion
		
		#region 생성자 / 소멸자
		public Pop_BO_Outgoing_Cont(Control arg_grid, int[] arg_checks)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BO_Outgoing_Cont));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_contNo = new System.Windows.Forms.Label();
            this.txt_itemNm = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.txt_itemCd = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_itemGroup = new System.Windows.Forms.Label();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.cmb_barMove = new C1.Win.C1List.C1Combo();
            this.lbl_barMove = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_container = new C1.Win.C1List.C1Combo();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_barMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_container)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.GridDefinition = "21.2:False:True;0:False:True;\t0.505050505050505:False:True;96.969696969697:False:" +
                "False;0.505050505050505:False:True;";
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
            this.pnl_menu.Location = new System.Drawing.Point(12, 114);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(768, 0);
            this.pnl_menu.TabIndex = 174;
            this.pnl_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_menu_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_contNo);
            this.panel1.Controls.Add(this.txt_itemNm);
            this.panel1.Controls.Add(this.cmb_itemGroup);
            this.panel1.Controls.Add(this.btn_groupSearch);
            this.panel1.Controls.Add(this.txt_itemCd);
            this.panel1.Controls.Add(this.lbl_item);
            this.panel1.Controls.Add(this.lbl_itemGroup);
            this.panel1.Controls.Add(this.cmb_user);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.lbl_vendor);
            this.panel1.Controls.Add(this.txt_vendorCode);
            this.panel1.Controls.Add(this.cmb_vendor);
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
            this.panel1.Size = new System.Drawing.Size(768, 106);
            this.panel1.TabIndex = 169;
            // 
            // lbl_contNo
            // 
            this.lbl_contNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_contNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contNo.ImageIndex = 0;
            this.lbl_contNo.ImageList = this.img_Label;
            this.lbl_contNo.Location = new System.Drawing.Point(344, 79);
            this.lbl_contNo.Name = "lbl_contNo";
            this.lbl_contNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_contNo.TabIndex = 379;
            this.lbl_contNo.Text = "Container No";
            this.lbl_contNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemNm
            // 
            this.txt_itemNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemNm.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemNm.Location = new System.Drawing.Point(526, 57);
            this.txt_itemNm.MaxLength = 10;
            this.txt_itemNm.Name = "txt_itemNm";
            this.txt_itemNm.Size = new System.Drawing.Size(140, 21);
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
            this.cmb_itemGroup.Location = new System.Drawing.Point(446, 35);
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
            this.btn_groupSearch.Location = new System.Drawing.Point(644, 35);
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
            this.txt_itemCd.Location = new System.Drawing.Point(446, 57);
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
            this.cmb_user.Location = new System.Drawing.Point(110, 57);
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
            this.lbl_user.Location = new System.Drawing.Point(8, 57);
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
            this.lbl_vendor.Location = new System.Drawing.Point(8, 79);
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
            this.txt_vendorCode.Location = new System.Drawing.Point(110, 79);
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
            this.cmb_vendor.Location = new System.Drawing.Point(190, 79);
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
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            // 
            // cmb_barMove
            // 
            this.cmb_barMove.AddItemCols = 0;
            this.cmb_barMove.AddItemSeparator = ';';
            this.cmb_barMove.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_barMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_barMove.Caption = "";
            this.cmb_barMove.CaptionHeight = 17;
            this.cmb_barMove.CaptionStyle = style25;
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
            this.cmb_barMove.EvenRowStyle = style26;
            this.cmb_barMove.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_barMove.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_barMove.FooterStyle = style27;
            this.cmb_barMove.GapHeight = 2;
            this.cmb_barMove.HeadingStyle = style28;
            this.cmb_barMove.HighLightRowStyle = style29;
            this.cmb_barMove.ItemHeight = 15;
            this.cmb_barMove.Location = new System.Drawing.Point(446, 13);
            this.cmb_barMove.MatchEntryTimeout = ((long)(2000));
            this.cmb_barMove.MaxDropDownItems = ((short)(5));
            this.cmb_barMove.MaxLength = 32767;
            this.cmb_barMove.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_barMove.Name = "cmb_barMove";
            this.cmb_barMove.OddRowStyle = style30;
            this.cmb_barMove.PartialRightColumn = false;
            this.cmb_barMove.PropBag = resources.GetString("cmb_barMove.PropBag");
            this.cmb_barMove.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_barMove.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_barMove.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_barMove.SelectedStyle = style31;
            this.cmb_barMove.Size = new System.Drawing.Size(220, 20);
            this.cmb_barMove.Style = style32;
            this.cmb_barMove.TabIndex = 184;
            // 
            // lbl_barMove
            // 
            this.lbl_barMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_barMove.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barMove.ImageIndex = 0;
            this.lbl_barMove.ImageList = this.img_Label;
            this.lbl_barMove.Location = new System.Drawing.Point(344, 13);
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
            this.cmb_factory.Location = new System.Drawing.Point(110, 13);
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
            this.lbl_shipDate.Location = new System.Drawing.Point(8, 35);
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
            this.dpick_to.ValueChanged += new System.EventHandler(this.dpick_to_ValueChanged);
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(110, 35);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 4;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_container);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 106);
            this.groupBox1.TabIndex = 381;
            this.groupBox1.TabStop = false;
            // 
            // cmb_container
            // 
            this.cmb_container.AddItemCols = 0;
            this.cmb_container.AddItemSeparator = ';';
            this.cmb_container.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_container.Caption = "";
            this.cmb_container.CaptionHeight = 17;
            this.cmb_container.CaptionStyle = style41;
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
            this.cmb_container.EvenRowStyle = style42;
            this.cmb_container.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_container.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_container.FooterStyle = style43;
            this.cmb_container.GapHeight = 2;
            this.cmb_container.HeadingStyle = style44;
            this.cmb_container.HighLightRowStyle = style45;
            this.cmb_container.ItemHeight = 15;
            this.cmb_container.Location = new System.Drawing.Point(446, 79);
            this.cmb_container.MatchEntryTimeout = ((long)(2000));
            this.cmb_container.MaxDropDownItems = ((short)(5));
            this.cmb_container.MaxLength = 32767;
            this.cmb_container.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_container.Name = "cmb_container";
            this.cmb_container.OddRowStyle = style46;
            this.cmb_container.PartialRightColumn = false;
            this.cmb_container.PropBag = resources.GetString("cmb_container.PropBag");
            this.cmb_container.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_container.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_container.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_container.SelectedStyle = style47;
            this.cmb_container.Size = new System.Drawing.Size(220, 20);
            this.cmb_container.Style = style48;
            this.cmb_container.TabIndex = 382;
            // 
            // Pop_BO_Outgoing_Cont
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 176);
            this.Controls.Add(this.c1Sizer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pop_BO_Outgoing_Cont";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_barMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_container)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

//		private void spd_main_EditModeOn(object sender, System.EventArgs e)
//		{
//			this.Grid_EditModeOnProcess(spd_main) ;
//		}		
//
//		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
//		{			
//			this.spd_main.Update_Row(img_Action);
//		}

		#endregion

		#region 컨텍스트(팝업) 메뉴 이벤트
//
//		private void cmenu_Barcode_Popup(object sender, System.EventArgs e)
//		{
//			try
//			{
//				// 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
//				Set_MenuItem_Visible();
//			}
//			catch(Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Barcode_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			} 
//		}

//  		
//		/// <summary>
//		/// Set_MenuItem_Visible : 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
//		/// </summary>
//		private void Set_MenuItem_Visible()
//		{
//			this.menuitem_DeSelectAll.Visible		= true;
//			this.menuitem_SelectAll.Visible			= true;
//		}
// 

//		private void menuitem_SelectAll_Click(object sender, System.EventArgs e)
//		{
//			try
//			{ 
//				Select_All();
//			}
//			catch(Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_SelectAll_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			} 
//		}


//		private void menuitem_DeSelectAll_Click(object sender, System.EventArgs e)
//		{
//			try
//			{ 
//				DeSelect_All();
//			}
//			catch(Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_DeSelectAll_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			} 
//		}

		/// <summary>
		/// Select_All : 모든 Row 선택
		/// </summary>
//		private void Select_All()
//		{ 
//			for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
//			{
//				if (!_mainSheet.Rows[i].Locked)
//					spd_main.ActiveSheet.Cells[i, _lxChkCol].Value = true;
//			} 
//		}

		/// <summary>
		/// DeSelect_All : 모든 Row 해제
		/// </summary>
//		private void DeSelect_All()
//		{ 
//			for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
//			{
//				spd_main.ActiveSheet.Cells[i, _lxChkCol].Value = false;
//			} 
//		}

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
//					spd_main.ActiveSheet.Cells[i, _lxChkCol].Value = true;
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

//		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
//		{
//			this.Tbtn_NewProcess();		
//		}

//		private void btn_apply_Click(object sender, System.EventArgs e)
//		{
//			if (_mainSheet.Rows.Count > 0)
//				this.Return_Data();
//		}

//		private void btn_close_Click(object sender, System.EventArgs e)
//		{
//			_DT	= null;	
//			this.Close();
//		}

		private void pnl_menu_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
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

//		private void Txt_ItemCdTextChangedProcess()
//		{
//			try
//			{
//				_isAccessible = false;
//				DataTable vDt = new DataTable();
//				vDt = ClassLib.ComFunction.Select_Item_Name_List(txt_itemCd.Text);
//				COM.ComCtl.Set_ComboList(vDt, cmb_itemCd, 0, 1, true, 79, 141);
//				vDt.Dispose();
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show(ex.Message);
//			}
//			finally
//			{
//				_isAccessible = true;
//			}
//		}

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

//		private void Cmb_itemCdSelectedValueChangedProcess()
//		{
//			try
//			{
//				if (_isAccessible)
//				{
//					txt_itemCd.Text			 = cmb_itemCd.SelectedValue.ToString();
//					cmb_itemCd.SelectedValue = txt_itemCd.Text;
//				}
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show(ex.Message);
//			}
//		}

		private void cmb_vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_VendorSelectedValueChangedProcess();
		}

//		private void cmb_itemCd_SelectedValueChanged(object sender, System.EventArgs e)
//		{
//			Cmb_itemCdSelectedValueChangedProcess();
//		}
		
		private void txt_vendorCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
			{
				Txt_VendorCodeTextChangedProcess();		
				ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
			}
		}

//		private void txt_itemCd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
//		{
//			if ((int)e.KeyChar == 13)
//			{
//				Txt_ItemCdTextChangedProcess();		
//				ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
//			}
//		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			dpick_to.Value = dpick_from.Value; 
		}

		private void dpick_to_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				cmb_container.SelectedIndex = -1;
			
				DataTable vDt = null;

				// cmb_container
				string vFromDate = dpick_from.Text.Replace("-","");
				string vToDate	 = dpick_to.Text.Replace("-","");



				vDt = Select_Container();

				ClassLib.ComCtl.Set_ComboList(vDt, cmb_container, 0, 0, true);
				cmb_container.SelectedValue = COM.ComVar.This_User;
				vDt.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_to_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
//		private void btn_apply_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
//		{
//			this.btn_apply.ImageIndex = 1;
//		}
//
//		private void btn_apply_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
//		{
//			this.btn_apply.ImageIndex = 0;
//		}
//
//		private void btn_close_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
//		{
//			this.btn_close.ImageIndex = 1;
//		}
//
//		private void btn_close_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
//		{
//			this.btn_close.ImageIndex = 0;
//		}
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
			lbl_MainTitle.Text = "Outgoing Container";
            this.Text = "Outgoing Container";
            ClassLib.ComFunction.SetLangDic(this);

//			// Grid Setting
//			spd_main.Set_Spread_Comm("SBO_OUTGOING_CONT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
//
//			// user define variable setting
//			_mainSheet					= spd_main.ActiveSheet;
//
//			for (int vCol = 0 ; vCol < _mainSheet.ColumnCount ; vCol++)
//			{
//				if (_mainSheet.ColumnHeader.Cells[1, vCol].Text.Equals(_mainSheet.ColumnHeader.Cells[2, vCol].Text))
//				{
//					_mainSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
//				}
//				else
//				{
//					int    vCnt  = 0;
//					for ( int j = vCol ; j < _mainSheet.ColumnCount ; j++)
//					{
//						if( vCnt > 0 &&  _mainSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != _mainSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
//						{
//							_mainSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
//							break;
//						}
//						else if ( _mainSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == _mainSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
//							vCnt++;
//					}
//					vCol = vCol + vCnt-1;
//				}
//			}

			Create_DataTable();

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			cmb_factory.Enabled  = false;


			// Item Group Combobox Setting
			vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, true);
			vDt.Dispose();

			// Bar Move Combobox Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBS08");
			COM.ComCtl.Set_ComboList(vDt, cmb_barMove, 1, 2, true, 56,0);
			cmb_barMove.SelectedIndex = -1;
			vDt.Dispose();

			// cmb_user
			vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory);
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_user,1,2,(vDt.Rows.Count > 1) ? true : false);
			cmb_user.SelectedValue = COM.ComVar.This_User;
			vDt.Dispose();

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

		private void Btn_SearchClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = this.SELECT_SBS_BAR_OUT_LIST();


				for(int i = 0; i < vDt.Rows.Count; i++)
				{


					fgrid_main.AddItem(vDt.Rows[i].ItemArray, fgrid_main.Rows.Fixed + i, 0);

				} 

				this.Cursor = Cursors.Default ;
				this.Close();


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
				//spd_main.ClearAll();
				this.cmb_barMove.SelectedIndex		= -1;				
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

		
//		/// <summary>
//		/// Select Bacode Data Return
//		/// </summary>
//		private void Return_Data()
//		{
//			try
//			{
//				Make_DT(); 
//
//				this.Close();
//
//			}
//			catch(Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "Return_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			}
//		}


		/// <summary>
		/// Make_DT_Component : 
		/// </summary>
//		private void Make_DT()
//		{
//			try
//			{
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
//
//				DataRow datarow = null; 
//		 
//				int vFlag = 0;
//		 
//				for(int i = 0; i < this._mainSheet.RowCount; i++)
//				{ 
//					bool vBool	=	this._mainSheet.Cells[i, _lxChkCol].Value.ToString() == "True" ? true : false;
//					if (vBool)
//					{
//						vFlag = Etc_DataDuplicateCheck_FSP(i);
//
//						if (vFlag == 0)
//						{
//							datarow = _DT.NewRow();
//
//							datarow[_ldFactoryCol]		= spd_main.ActiveSheet.Cells[i, _lxFactoryCol].Value.ToString();
//							datarow[_ldItemCdCol]		= spd_main.ActiveSheet.Cells[i, _lxItemCdCol].Value.ToString();
//							datarow[_ldItemNameCol]		= spd_main.ActiveSheet.Cells[i, _lxItemNameCol].Value.ToString();
//							datarow[_ldSpecCdCol]		= spd_main.ActiveSheet.Cells[i, _lxSpecCdCol].Value.ToString();
//							datarow[_ldSpecNameCol]		= spd_main.ActiveSheet.Cells[i, _lxSpecNameCol].Value.ToString();
//							datarow[_ldColorCdCol]		= spd_main.ActiveSheet.Cells[i, _lxColorCdCol].Value.ToString();
//							datarow[_ldColorNameCol]	= spd_main.ActiveSheet.Cells[i, _lxColorNameCol].Value.ToString();
//							datarow[_ldOutQtyCol]		= spd_main.ActiveSheet.Cells[i, _lxScanQtyCol].Value.ToString();
//							datarow[_ldUnitCol]			= spd_main.ActiveSheet.Cells[i, _lxUnitCol].Value.ToString();
//							datarow[_ldPkUnitQtyCol]	= spd_main.ActiveSheet.Cells[i, _lxPkUnitQtyCol].Value.ToString();
//							datarow[_ldPurCurrencyCol]	= spd_main.ActiveSheet.Cells[i, _lxPurCurrencyCol].Value.ToString();
//							datarow[_ldPurPriceCol]		= spd_main.ActiveSheet.Cells[i, _lxPurPriceCol].Value.ToString();
//							datarow[_ldCbdCurrencyCol]	= spd_main.ActiveSheet.Cells[i, _lxCbdCurrencyCol].Value.ToString();
//							datarow[_ldCbdPriceCol]		= spd_main.ActiveSheet.Cells[i, _lxCbdPriceCol].Value.ToString();
//							datarow[_ldShipCurrencyCol] = spd_main.ActiveSheet.Cells[i, _lxShipCurrencyCol].Value.ToString();
//							datarow[_ldShipPriceCol]	= spd_main.ActiveSheet.Cells[i, _lxShipPriceCol].Value.ToString();
//							datarow[_ldPriceYnCol]		= spd_main.ActiveSheet.Cells[i, _lxPriceYnCol].Value.ToString();
//							datarow[_ldCustCdCol]		= spd_main.ActiveSheet.Cells[i, _lxCustCdCol].Value.ToString();
//							datarow[_ldCustNameCol]		= spd_main.ActiveSheet.Cells[i, _lxCustNameCol].Value.ToString();
//							datarow[_ldBarCodeCol]		= spd_main.ActiveSheet.Cells[i, _lxBarCodeCol].Value.ToString();
//							datarow[_ldBarMoveCol]		= spd_main.ActiveSheet.Cells[i, _lxBarMoveCol].Value.ToString();
//							datarow[_ldContNoCol]		= spd_main.ActiveSheet.Cells[i, _lxContNoCol].Value.ToString();
//							datarow[_ldShipYmdCol]		= spd_main.ActiveSheet.Cells[i, _lxShipYmdCol].Value.ToString();
//							datarow[_ldShipNoCol]		= spd_main.ActiveSheet.Cells[i, _lxShipNoCol].Value.ToString();
//							datarow[_ldShipSeqCol]		= spd_main.ActiveSheet.Cells[i, _lxShipSeqCol].Value.ToString();
//							datarow[_ldLotNoCol]		= spd_main.ActiveSheet.Cells[i, _lxLotNoCol].Value.ToString();
//							datarow[_ldLotSeqCol]		= spd_main.ActiveSheet.Cells[i, _lxLotSeqCol].Value.ToString();
//							datarow[_ldStyleCdCol]		= spd_main.ActiveSheet.Cells[i, _lxStyleCdCol].Value.ToString();
//							datarow[_ldStyleNameCol]	= spd_main.ActiveSheet.Cells[i, _lxStyleNameCol].Value.ToString();
//							datarow[_ldWhCdCol]			= spd_main.ActiveSheet.Cells[i, _lxWhCdCol].Value.ToString();
//							datarow[_ldTranDivCol]		= "C";
//										
//							_DT.Rows.Add(datarow); 
//						}
//						else if (vFlag == -1)
//						{
//							_DT = null;
//							_mainSheet.Cells[i, _lxChkCol].Value = true;
//							break;
//						}
//					}
//				}
//				if (vFlag != -1)
//				{
//					this.DialogResult = DialogResult.OK;
//					this.Close();
//				}
//			}
//			catch(Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "Return_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			} 	
//		}

//		private int Etc_DataDuplicateCheck_FSP(int arg_row)
//		{
//			int vReturn = 0;
//
//			for ( int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++ )
//			{
//				if( fgrid_main[vRow, _checkCols[0]].ToString().Replace("-", "").Equals(_mainSheet.Cells[arg_row, _lxStyleCdCol].Value.ToString()) &&
//					fgrid_main[vRow, _checkCols[1]].ToString().Equals(_mainSheet.Cells[arg_row, _lxItemCdCol].Value.ToString()) &&
//					fgrid_main[vRow, _checkCols[2]].ToString().Equals(_mainSheet.Cells[arg_row, _lxSpecCdCol].Value.ToString()) &&
//					fgrid_main[vRow, _checkCols[3]].ToString().Equals(_mainSheet.Cells[arg_row, _lxColorCdCol].Value.ToString()) &&
//					fgrid_main[vRow, _checkCols[4]].ToString().Equals(_mainSheet.Cells[arg_row, _lxBarCodeCol].Value.ToString())) 
//				{
//					string vMessage = "The selected item is already exists \r\n" +
//						"Choose process.. \r\n\r\n" +
//						"[Yes] : overwrite the existing data \r\n" +
//						"[No] : deselect current item \r\n" +
//						"[Cancel] : process abort \r\n\r\n" +
//						"Row Number : " + arg_row + 1 + "\r\n" + 
//						"Item : " + _mainSheet.Cells[arg_row, _lxItemNameCol].Value.ToString()  + 
//						"  Spec : " + _mainSheet.Cells[arg_row, _lxSpecNameCol].Value.ToString() +
//						"  Color : "+ _mainSheet.Cells[arg_row, _lxColorNameCol].Value.ToString() + "\t";
//
//					_mainSheet.Cells[arg_row, _lxChkCol].Value = true;
//					fgrid_main.Select(vRow, 1);
//
//					switch (MessageBox.Show(this, vMessage, "Duplicate Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
//					{
//						case DialogResult.Yes:
//							string vTag = (fgrid_main[vRow, 0] == null) ? "" : fgrid_main[vRow, 0].ToString();
//							if (vTag.Equals(ClassLib.ComVar.Insert))
//								fgrid_main.RemoveItem(vRow);
//							else
//								fgrid_main.Delete_Row(vRow);
//							vReturn = 0;
//							break;
//
//						case DialogResult.No:
//							_mainSheet.Cells[arg_row, _lxChkCol].Value = false;
//							vReturn = 1;
//							break;
//
//						case DialogResult.Cancel:
//							vReturn = -1;
//							break;
//					}
//
//					break;
//				}				
//			}
//
//			return vReturn;
//		}

		#endregion

		#region DB Connect
 		


		/// <summary>
		/// SELECT_SBS_BAR_OUT_CONTAINER : 출고 컨테이너 리스트(SCAN OUT 날짜 기준)
		/// </summary>
		/// <returns>DataTable</returns>
		public  DataTable Select_Container()
		{
			COM.OraDB oraDB = new COM.OraDB();

			string Proc_Name = "PKG_SBO_OUT_CONT.SELECT_SBS_BAR_OUT_CONTAINER";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_FROM";
			oraDB.Parameter_Name[2] = "ARG_TO";
			oraDB.Parameter_Name[3] = "ARG_BAR_MOVE";
			oraDB.Parameter_Name[4] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(this.cmb_factory," ");
			oraDB.Parameter_Values[1] = this.dpick_from.Text.Replace("-", "");
			oraDB.Parameter_Values[2] = this.dpick_to.Text.Replace("-", "");
			oraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(this.cmb_barMove, " ");
			oraDB.Parameter_Values[4] = "";

			oraDB.Add_Select_Parameter(false);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();


			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];			
		}



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
		public DataTable SELECT_SBS_BAR_OUT_LIST()
		{
			try
			{
				DataSet vDt;

				MyOraDB.ReDim_Parameter(11);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBO_OUT_CONT.SELECT_SBS_BAR_OUT_LIST";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROM";
				MyOraDB.Parameter_Name[2] = "ARG_TO";
				MyOraDB.Parameter_Name[3] = "ARG_BAR_MOVE";
				MyOraDB.Parameter_Name[4] = "ARG_USER";
				MyOraDB.Parameter_Name[5] = "ARG_VENDOR";
				MyOraDB.Parameter_Name[6] = "ARG_GROUP_CD";
				MyOraDB.Parameter_Name[7] = "ARG_ITEM_CD";			
				MyOraDB.Parameter_Name[8] = "ARG_CONT_NO";
				MyOraDB.Parameter_Name[9]= "ARG_UPD_USER";
				MyOraDB.Parameter_Name[10]= "OUT_CURSOR";

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
				MyOraDB.Parameter_Type[10]= (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(this.cmb_factory, " ");
				MyOraDB.Parameter_Values[1] = dpick_from.Text.Replace("-", "");
				MyOraDB.Parameter_Values[2] = dpick_to.Text.Replace("-", "");
				MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(this.cmb_barMove, " ");
				MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_Combo(this.cmb_user, " ");
				MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_TextBox(this.txt_vendorCode, " ");
				MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_TextBox(this.txt_itemCd, " ");
				MyOraDB.Parameter_Values[7] = ClassLib.ComFunction.Empty_Combo(this.cmb_itemGroup, " ");
				MyOraDB.Parameter_Values[8] = ClassLib.ComFunction.Empty_Combo(this.cmb_container, " ");		
				MyOraDB.Parameter_Values[9] = COM.ComVar.This_User;
				MyOraDB.Parameter_Values[10]= "";

				MyOraDB.Add_Select_Parameter(true);
				vDt = MyOraDB.Exe_Select_Procedure();
				if(vDt == null) 
					return null ;

				return vDt.Tables[MyOraDB.Process_Name];
			}
			catch (Exception ex)
			{
				
				this.Cursor = Cursors.Default ;
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_SBS_BAR_OUT_LIST", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}	
		
		}


		#endregion

	}
}

