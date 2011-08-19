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
	public class Pop_BI_Incoming_NoShipping : COM.PCHWinForm.Pop_Large
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.SSP spd_main;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_ymd;
		private System.Windows.Forms.DateTimePicker dpick_ymd;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenu cmenu_NoShipping;
		private System.Windows.Forms.MenuItem menuitem_SelectAll;
		private System.Windows.Forms.MenuItem menuitem_DeSelectAll;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet	= null;
		private string _vWhCd = "";
		
		private COM.FSP fgrid_main;
		private int[] _checkCols;

		//메인창으로 리턴될 데이터 테이블
		public DataTable _DT;  

		private int _lxChkCol			= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxCHK;
		private int _lxItemCdCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxITEM_CD;
		private int _lxItemNameCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxITEM_NAME;
		private int _lxSpecCdCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxSPEC_CD;
		private int _lxSpecNameCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxSPEC_NAME;
		private int _lxColorCdCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxCOLOR_CD;
		private int _lxColorNameCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxCOLOR_NAME;
		private int _lxUnitCol			= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxUNIT;
		private int _lxShipQtyCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxSHIP_QTY;
		private int _lxPurPriceCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxPUR_PRICE;
		private int _lxPurCurrencyCol	= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxPUR_CURRENCY;
		private int _lxCbdPriceCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxCBD_PRICE;
		private int _lxCbdCurrencyCol	= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxCBD_CURRENCY;
		private int _lxShipPriceCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxSHIP_PRICE;
		private int _lxShipCurrencyCol	= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxSHIP_CURRENCY;
		private int _lxBarCodeRepCol	= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxBAR_CODE_REP;
		private int _lxFactoryCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxFACTORY;
		private int _lxShipYmdCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxSHIP_YMD;
		private int _lxShipNoCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxSHIP_NO;
		private int _lxShipSeqCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxSHIP_SEQ;
		private int _lxLotNoCol			= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxLOT_NO;
		private int _lxLotSeqCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxLOT_SEQ;
		private int _lxStyleCdCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxSTYLE_CD;
		private int _lxStyleNameCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxSTYLE_NAME;
		private int _lxPkUnitQtyCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxPK_UNIT_QTY;
		private int _lxCustCdCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxCUST_CD;
		private int _lxCustNameCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxCUST_NAME;
		private int _lxPurUserCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxPUR_USER;
		private int _lxPriceYnCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxPRICE_YN;
		private int _lxRemarksCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxREMARKS;
		private int _lxCheckPurCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxCHECK_PUR;
		private int _lxCheckCbdCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxCHECK_CBD;
		private int _lxCheckShipCol		= (int)ClassLib.TBSBI_INCOMING_NOSHIP.IxCHECK_SHIP;
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
		private int _ldBarCodeCol	= (int)ClassLib.TBSBI_IN_TAIL.IxBAR_CODE -1;
		private int _ldCustNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxCUST_NAME -1;
		private int _ldShipYmdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_YMD -1;
		private int _ldShipNoCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_NO -1;
		private int _ldShipSeqCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_SEQ -1;
		private int _ldShipQtyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSHIP_QTY -1;
		private int _ldLotNoCol		= (int)ClassLib.TBSBI_IN_TAIL.IxLOT_NO -1;
		private int _ldLotSeqCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLOT_SEQ -1;
		private int _ldStyleCdCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSTYLE_CD -1;
		private int _ldStyleNameCol	= (int)ClassLib.TBSBI_IN_TAIL.IxSTYLE_NAME -1;
		private int _ldWhCdCol		= (int)ClassLib.TBSBI_IN_TAIL.IxWH_CD -1;
		private int _ldPurUserCol	= (int)ClassLib.TBSBI_IN_TAIL.IxPUR_USER -1;
		private int _ldRemarksCol	= (int)ClassLib.TBSBI_IN_TAIL.IxREMARKS -1;
		private int _ldTranDivCol	= (int)ClassLib.TBSBI_IN_TAIL.IxTRAN_DIV-1;
		private int _ldLedgerPriceCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_PRICE -1;
		private int _ldLedgerCurrencyCol	= (int)ClassLib.TBSBI_IN_TAIL.IxLEDGER_CURRENCY -1;

		/*메인화면 Return용 */
		private int _factoryCol     = (int)ClassLib.TBSBI_IN_TAIL.IxFACTORY;
		private int _inSeqCol       = (int)ClassLib.TBSBI_IN_TAIL.IxIN_SEQ;
		private int _modQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxMOD_QTY;
		private int _seqCol				= (int)ClassLib.TBSBI_IN_TAIL.IxSEQ;
		private int _inQtyCol			= (int)ClassLib.TBSBI_IN_TAIL.IxIN_QTY;
		private bool _practicable	= false;



		#endregion

		#region 생성자 / 소멸자
		public Pop_BI_Incoming_NoShipping(Control arg_grid, int[] arg_checks)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BI_Incoming_NoShipping));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.spd_main = new COM.SSP();
            this.cmenu_NoShipping = new System.Windows.Forms.ContextMenu();
            this.menuitem_SelectAll = new System.Windows.Forms.MenuItem();
            this.menuitem_DeSelectAll = new System.Windows.Forms.MenuItem();
            this._mainSheet = new FarPoint.Win.Spread.SheetView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpick_ymd = new System.Windows.Forms.DateTimePicker();
            this.lbl_ymd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainSheet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.GridDefinition = "9:False:True;81.8:False:False;6:False:True;\t0.505050505050505:False:True;96.96969" +
                "6969697:False:False;0.505050505050505:False:True;";
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
            this.pnl_menu.TabIndex = 173;
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
            this.spd_main.ContextMenu = this.cmenu_NoShipping;
            this.spd_main.Location = new System.Drawing.Point(12, 53);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this._mainSheet);
            this.spd_main.Size = new System.Drawing.Size(768, 409);
            this.spd_main.TabIndex = 172;
            // 
            // cmenu_NoShipping
            // 
            this.cmenu_NoShipping.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuitem_SelectAll,
            this.menuitem_DeSelectAll});
            this.cmenu_NoShipping.Popup += new System.EventHandler(this.cmenu_NoShipping_Popup);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmb_factory);
            this.panel1.Controls.Add(this.lbl_factory);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 45);
            this.panel1.TabIndex = 171;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style1;
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
            this.cmb_factory.EvenRowStyle = style2;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style3;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style4;
            this.cmb_factory.HighLightRowStyle = style5;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(110, 14);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style6;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style7;
            this.cmb_factory.Size = new System.Drawing.Size(226, 20);
            this.cmb_factory.Style = style8;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpick_ymd);
            this.groupBox1.Controls.Add(this.lbl_ymd);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 44);
            this.groupBox1.TabIndex = 376;
            this.groupBox1.TabStop = false;
            // 
            // dpick_ymd
            // 
            this.dpick_ymd.CustomFormat = "";
            this.dpick_ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ymd.Location = new System.Drawing.Point(453, 14);
            this.dpick_ymd.Name = "dpick_ymd";
            this.dpick_ymd.Size = new System.Drawing.Size(184, 21);
            this.dpick_ymd.TabIndex = 4;
            // 
            // lbl_ymd
            // 
            this.lbl_ymd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ymd.ImageIndex = 1;
            this.lbl_ymd.ImageList = this.img_Label;
            this.lbl_ymd.Location = new System.Drawing.Point(352, 14);
            this.lbl_ymd.Name = "lbl_ymd";
            this.lbl_ymd.Size = new System.Drawing.Size(100, 21);
            this.lbl_ymd.TabIndex = 52;
            this.lbl_ymd.Text = "Ship Date";
            this.lbl_ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_BI_Incoming_NoShipping
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 558);
            this.Controls.Add(this.c1Sizer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pop_BI_Incoming_NoShipping";
            this.Load += new System.EventHandler(this.Form_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.groupBox1.ResumeLayout(false);
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

		private void cmenu_NoShipping_Popup(object sender, System.EventArgs e)
		{
			try
			{
				// 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
				Set_MenuItem_Visible();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_NoShpping_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			lbl_MainTitle.Text = "Incoming No Shipping";
            this.Text = "Incoming No Shipping";
            ClassLib.ComFunction.SetLangDic(this);


			// Grid Setting
			spd_main.Set_Spread_Comm("SBI_INCOMING_NOSHIP", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

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

			// default search proviso
			if (COM.ComVar.Parameter_PopUp[0].ToString() != "")
				cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
			dpick_ymd.Value			= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
			
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
			_DT = new DataTable("NoShipping");

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

				DataTable vDt = this.SELECT_SBI_NO_SHIPPING_LIST();

				if (vDt.Rows.Count > 0)
				{
					spd_main.Display_Grid(vDt);

					for ( int i = 0; i < _mainSheet.Rows.Count; i++)
					{
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

						if (_mainSheet.Cells[i, _lxCheckShipCol].Value.ToString() == "R")
						{
							_mainSheet.Cells[i, _lxShipCurrencyCol].ForeColor = COM.ComVar.ClrError; 
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

				Pop_BI_Incoming_List_Changer pop_changer = new Pop_BI_Incoming_List_Changer();
				pop_changer.ShowDialog();

				if (COM.ComVar.Parameter_PopUp != null)
				{
					_vWhCd = COM.ComVar.Parameter_PopUp[0];

					pop_changer.Dispose();

					Make_DT(); 

//					bool vBool = Make_DT(); 
//
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
				for (int i = 0 ; i < vSelectionRange.Length; i++)
				{
					int start_row = vSelectionRange[i].Row;
					int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

					for (int j = start_row ; j < end_row; j++)
					{
						if (!_mainSheet.Rows[j].Locked)
							spd_main.ActiveSheet.Cells[j, _lxChkCol].Value = true;
					}
				}		  

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
							datarow = _DT.NewRow();

							datarow[_ldFactoryCol]		= spd_main.ActiveSheet.Cells[i, _lxFactoryCol].Value.ToString();
							datarow[_ldItemCdCol]		= spd_main.ActiveSheet.Cells[i, _lxItemCdCol].Value.ToString();
							datarow[_ldItemNameCol]		= spd_main.ActiveSheet.Cells[i, _lxItemNameCol].Value.ToString();
							datarow[_ldSpecCdCol]		= spd_main.ActiveSheet.Cells[i, _lxSpecCdCol].Value.ToString();
							datarow[_ldSpecNameCol]		= spd_main.ActiveSheet.Cells[i, _lxSpecNameCol].Value.ToString();
							datarow[_ldColorCdCol]		= spd_main.ActiveSheet.Cells[i, _lxColorCdCol].Value.ToString();
							datarow[_ldColorNameCol]	= spd_main.ActiveSheet.Cells[i, _lxColorNameCol].Value.ToString();
							datarow[_ldInQtyCol]		= spd_main.ActiveSheet.Cells[i, _lxShipQtyCol].Value.ToString();
							datarow[_ldUnitCol]			= spd_main.ActiveSheet.Cells[i, _lxUnitCol].Value.ToString();
							datarow[_ldPurCurrencyCol]	= spd_main.ActiveSheet.Cells[i, _lxPurCurrencyCol].Value.ToString();
							datarow[_ldPurPriceCol]		= spd_main.ActiveSheet.Cells[i, _lxPurPriceCol].Value.ToString();
							datarow[_ldCbdCurrencyCol]	= spd_main.ActiveSheet.Cells[i, _lxCbdCurrencyCol].Value.ToString();
							datarow[_ldCbdPriceCol]		= spd_main.ActiveSheet.Cells[i, _lxCbdPriceCol].Value.ToString();
							datarow[_ldCustCdCol]		= spd_main.ActiveSheet.Cells[i, _lxCustCdCol].Value.ToString();
							datarow[_ldCustNameCol]		= spd_main.ActiveSheet.Cells[i, _lxCustNameCol].Value.ToString();
							datarow[_ldShipQtyCol]		= spd_main.ActiveSheet.Cells[i, _lxShipQtyCol].Value.ToString();
							datarow[_ldShipNoCol]		= spd_main.ActiveSheet.Cells[i, _lxShipNoCol].Value.ToString();
							datarow[_ldShipYmdCol]		= spd_main.ActiveSheet.Cells[i, _lxShipYmdCol].Value.ToString();
							datarow[_ldStyleCdCol]		= spd_main.ActiveSheet.Cells[i, _lxStyleCdCol].Value.ToString();
							datarow[_ldStyleNameCol]	= spd_main.ActiveSheet.Cells[i, _lxStyleNameCol].Value.ToString();
							datarow[_ldPurUserCol]		= spd_main.ActiveSheet.Cells[i, _lxPurUserCol].Value.ToString();
							datarow[_ldShipPriceCol]	= spd_main.ActiveSheet.Cells[i, _lxShipPriceCol].Value.ToString();
							datarow[_ldShipCurrencyCol]	= spd_main.ActiveSheet.Cells[i, _lxShipCurrencyCol].Value.ToString();
							datarow[_ldBarCodeCol]		= spd_main.ActiveSheet.Cells[i, _lxBarCodeRepCol].Value.ToString();
							datarow[_ldShipSeqCol]		= spd_main.ActiveSheet.Cells[i, _lxShipSeqCol].Value.ToString();
							datarow[_ldLotNoCol]		= spd_main.ActiveSheet.Cells[i, _lxLotNoCol].Value.ToString();
							datarow[_ldLotSeqCol]		= spd_main.ActiveSheet.Cells[i, _lxLotSeqCol].Value.ToString();
							datarow[_ldPkUnitQtyCol]	= spd_main.ActiveSheet.Cells[i, _lxPkUnitQtyCol].Value.ToString();
							datarow[_ldPriceYnCol]		= spd_main.ActiveSheet.Cells[i, _lxPriceYnCol].Value.ToString();
							datarow[_ldRemarksCol]		= spd_main.ActiveSheet.Cells[i, _lxRemarksCol].Value.ToString();
							datarow[_ldWhCdCol]			= _vWhCd;
							datarow[_ldTranDivCol]		= "N";


							// 정환정 추가
							datarow[_ldLedgerPriceCol]		= "0";
							datarow[_ldLedgerCurrencyCol]		= "";


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
					fgrid_main[vRow, _checkCols[4]].ToString().Equals(_mainSheet.Cells[arg_row, _lxBarCodeRepCol].Value.ToString())) 
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
		public DataTable SELECT_SBI_NO_SHIPPING_LIST()
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_NO_SHIPPING.SELECT_SBI_IN_NO_SHIPPING_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(this.cmb_factory, "");
			MyOraDB.Parameter_Values[1] = dpick_ymd.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}	

		#endregion

	}
}

