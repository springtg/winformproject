using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexPurchase.Purchase
{
	public class Pop_BP_Outside_Calc : COM.PCHWinForm.Pop_Medium
	{
		#region 디자이너에서 생성한 변수

		private COM.FSP fgrid_main;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_curType;
		private System.Windows.Forms.Label lbl_curType;
		private System.Windows.Forms.TextBox txt_rate;
		private System.Windows.Forms.Label btn_rate;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private C1.Win.C1List.C1Combo cmb_season;
		private System.Windows.Forms.DateTimePicker dpick_ymd;
		private System.Windows.Forms.TextBox txt_totCBD;
		private System.Windows.Forms.TextBox txt_totPur;
		private System.Windows.Forms.CheckBox chk_allchanges;
		private System.Windows.Forms.CheckBox chk_allprice;
		private System.Windows.Forms.CheckBox chk_autoTotCalc;
		private System.Windows.Forms.CheckBox chk_autoCBDCalc;
		private System.Windows.Forms.GroupBox grp_option;
		private System.Windows.Forms.GroupBox grp_result;
		private System.Windows.Forms.Label lbl_purTot;
		private System.Windows.Forms.Label lbl_cbdTot;
		private System.Windows.Forms.ContextMenu ctx_menu1;
		private System.Windows.Forms.MenuItem mnu_CBDPrice;
		private System.Windows.Forms.TextBox txt_outside;
		private System.Windows.Forms.Label lbl_outside;
		private System.Windows.Forms.MenuItem mnu_getPurPrice;
		private System.Windows.Forms.MenuItem mnu_searchCBD;
		private System.Windows.Forms.TextBox txt_outsideCurrency;
		private System.Windows.Forms.TextBox txt_CBDCurrency;
		private System.Windows.Forms.TextBox txt_purCurrency;

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion


		#region 사용자 정의 변수

		private const string KRW = "KRW";
		private const string USD = "USD";
		private const int _roundNum = 2;

		private string _itemName;
		private Point _cmbOP, _cmbNP;
		private Point _lblOP, _lblNP;

		private C1FlexGrid _mainGrid;
		private int _orgPt;

		private ArrayList _slist = new ArrayList();

		private int _yieldCol = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxYIELD_M;
		private int _itemCol = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxITEM;
		private int _totPurCol = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxTEMP1;
		private int _totCBDCol = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxTEMP2;
		private int _purCol = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxPUR_PRICE;
		private int _purCurrencyCol = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxPUR_CURRENCY;
		private int _CBDCol = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxCBD_PRICE;
		private int _pairPurCol = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxSUBTOTAL_PUR;
		private int _pairCBDCol = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxSUBTOTAL_CBD;
		private int _matTypeCol = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxITEM_DIVISION;
		private int _styleCol = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxSTYLE_CD;
		private int _purYN = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxCHK;
		private int _obsIdCol = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxOBS_ID;

		#endregion

		#region 생성자 / 소멸자

		public Pop_BP_Outside_Calc()
		{
			InitializeComponent();
			Init_Form();
		}

		public Pop_BP_Outside_Calc(C1FlexGrid arg_grid)
		{
			InitializeComponent();
			_mainGrid = arg_grid;
			Init_Form();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BP_Outside_Calc));
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
            this.fgrid_main = new COM.FSP();
            this.ctx_menu1 = new System.Windows.Forms.ContextMenu();
            this.mnu_CBDPrice = new System.Windows.Forms.MenuItem();
            this.mnu_getPurPrice = new System.Windows.Forms.MenuItem();
            this.mnu_searchCBD = new System.Windows.Forms.MenuItem();
            this.cmb_curType = new C1.Win.C1List.C1Combo();
            this.lbl_curType = new System.Windows.Forms.Label();
            this.btn_rate = new System.Windows.Forms.Label();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.txt_totCBD = new System.Windows.Forms.TextBox();
            this.cmb_season = new C1.Win.C1List.C1Combo();
            this.dpick_ymd = new System.Windows.Forms.DateTimePicker();
            this.txt_totPur = new System.Windows.Forms.TextBox();
            this.chk_allchanges = new System.Windows.Forms.CheckBox();
            this.chk_allprice = new System.Windows.Forms.CheckBox();
            this.chk_autoTotCalc = new System.Windows.Forms.CheckBox();
            this.chk_autoCBDCalc = new System.Windows.Forms.CheckBox();
            this.grp_option = new System.Windows.Forms.GroupBox();
            this.grp_result = new System.Windows.Forms.GroupBox();
            this.txt_outsideCurrency = new System.Windows.Forms.TextBox();
            this.txt_CBDCurrency = new System.Windows.Forms.TextBox();
            this.txt_purCurrency = new System.Windows.Forms.TextBox();
            this.lbl_outside = new System.Windows.Forms.Label();
            this.txt_outside = new System.Windows.Forms.TextBox();
            this.lbl_purTot = new System.Windows.Forms.Label();
            this.lbl_cbdTot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_curType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season)).BeginInit();
            this.grp_option.SuspendLayout();
            this.grp_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(660, 23);
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
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
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
            // fgrid_main
            // 
            this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,75,Columns:";
            this.fgrid_main.ContextMenu = this.ctx_menu1;
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(8, 80);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(684, 248);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 27;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseDown);
            this.fgrid_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyUp);
            // 
            // ctx_menu1
            // 
            this.ctx_menu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_CBDPrice,
            this.mnu_getPurPrice,
            this.mnu_searchCBD});
            // 
            // mnu_CBDPrice
            // 
            this.mnu_CBDPrice.Index = 0;
            this.mnu_CBDPrice.Text = "CBD price calculation";
            this.mnu_CBDPrice.Click += new System.EventHandler(this.mnu_cbdPrice_Click);
            // 
            // mnu_getPurPrice
            // 
            this.mnu_getPurPrice.Index = 1;
            this.mnu_getPurPrice.Text = "Get purchase price from purchase order";
            this.mnu_getPurPrice.Click += new System.EventHandler(this.mnu_getPurPrice_Click);
            // 
            // mnu_searchCBD
            // 
            this.mnu_searchCBD.Index = 2;
            this.mnu_searchCBD.Text = "Get price from CBD Master";
            this.mnu_searchCBD.Click += new System.EventHandler(this.mnu_searchCBD_Click);
            // 
            // cmb_curType
            // 
            this.cmb_curType.AddItemCols = 0;
            this.cmb_curType.AddItemSeparator = ';';
            this.cmb_curType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_curType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_curType.Caption = "";
            this.cmb_curType.CaptionHeight = 17;
            this.cmb_curType.CaptionStyle = style1;
            this.cmb_curType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_curType.ColumnCaptionHeight = 18;
            this.cmb_curType.ColumnFooterHeight = 18;
            this.cmb_curType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_curType.ContentHeight = 16;
            this.cmb_curType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_curType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_curType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_curType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_curType.EditorHeight = 16;
            this.cmb_curType.EvenRowStyle = style2;
            this.cmb_curType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_curType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_curType.FooterStyle = style3;
            this.cmb_curType.GapHeight = 2;
            this.cmb_curType.HeadingStyle = style4;
            this.cmb_curType.HighLightRowStyle = style5;
            this.cmb_curType.ItemHeight = 15;
            this.cmb_curType.Location = new System.Drawing.Point(109, 56);
            this.cmb_curType.MatchEntryTimeout = ((long)(2000));
            this.cmb_curType.MaxDropDownItems = ((short)(5));
            this.cmb_curType.MaxLength = 32767;
            this.cmb_curType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_curType.Name = "cmb_curType";
            this.cmb_curType.OddRowStyle = style6;
            this.cmb_curType.PartialRightColumn = false;
            this.cmb_curType.PropBag = resources.GetString("cmb_curType.PropBag");
            this.cmb_curType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_curType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_curType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_curType.SelectedStyle = style7;
            this.cmb_curType.Size = new System.Drawing.Size(200, 20);
            this.cmb_curType.Style = style8;
            this.cmb_curType.TabIndex = 51;
            this.cmb_curType.SelectedValueChanged += new System.EventHandler(this.cmb_curType_SelectedValueChanged);
            // 
            // lbl_curType
            // 
            this.lbl_curType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_curType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curType.ImageIndex = 0;
            this.lbl_curType.ImageList = this.img_Label;
            this.lbl_curType.Location = new System.Drawing.Point(8, 56);
            this.lbl_curType.Name = "lbl_curType";
            this.lbl_curType.Size = new System.Drawing.Size(100, 21);
            this.lbl_curType.TabIndex = 52;
            this.lbl_curType.Text = "Exchange Rate";
            this.lbl_curType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_rate
            // 
            this.btn_rate.ImageIndex = 3;
            this.btn_rate.ImageList = this.img_SmallButton;
            this.btn_rate.Location = new System.Drawing.Point(592, 56);
            this.btn_rate.Name = "btn_rate";
            this.btn_rate.Size = new System.Drawing.Size(21, 21);
            this.btn_rate.TabIndex = 375;
            this.btn_rate.Tag = "Search";
            this.btn_rate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_rate.Click += new System.EventHandler(this.btn_rate_Click);
            this.btn_rate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_rate_Effect_Down);
            this.btn_rate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_rate_Effect_Up);
            // 
            // txt_rate
            // 
            this.txt_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rate.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_rate.Location = new System.Drawing.Point(511, 56);
            this.txt_rate.MaxLength = 10;
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(80, 21);
            this.txt_rate.TabIndex = 376;
            this.txt_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_rate.TextChanged += new System.EventHandler(this.txt_rate_TextChanged);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(144, 104);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 377;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Down);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Up);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(216, 104);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 377;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Down);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Up);
            // 
            // txt_totCBD
            // 
            this.txt_totCBD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totCBD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_totCBD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totCBD.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_totCBD.Location = new System.Drawing.Point(125, 46);
            this.txt_totCBD.MaxLength = 10;
            this.txt_totCBD.Name = "txt_totCBD";
            this.txt_totCBD.ReadOnly = true;
            this.txt_totCBD.Size = new System.Drawing.Size(100, 21);
            this.txt_totCBD.TabIndex = 378;
            this.txt_totCBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmb_season
            // 
            this.cmb_season.AddItemCols = 0;
            this.cmb_season.AddItemSeparator = ';';
            this.cmb_season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_season.Caption = "";
            this.cmb_season.CaptionHeight = 17;
            this.cmb_season.CaptionStyle = style9;
            this.cmb_season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_season.ColumnCaptionHeight = 18;
            this.cmb_season.ColumnFooterHeight = 18;
            this.cmb_season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_season.ContentHeight = 16;
            this.cmb_season.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_season.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_season.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_season.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_season.EditorHeight = 16;
            this.cmb_season.EvenRowStyle = style10;
            this.cmb_season.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_season.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_season.FooterStyle = style11;
            this.cmb_season.GapHeight = 2;
            this.cmb_season.HeadingStyle = style12;
            this.cmb_season.HighLightRowStyle = style13;
            this.cmb_season.ItemHeight = 15;
            this.cmb_season.Location = new System.Drawing.Point(310, 56);
            this.cmb_season.MatchEntryTimeout = ((long)(2000));
            this.cmb_season.MaxDropDownItems = ((short)(5));
            this.cmb_season.MaxLength = 32767;
            this.cmb_season.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_season.Name = "cmb_season";
            this.cmb_season.OddRowStyle = style14;
            this.cmb_season.PartialRightColumn = false;
            this.cmb_season.PropBag = resources.GetString("cmb_season.PropBag");
            this.cmb_season.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_season.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_season.SelectedStyle = style15;
            this.cmb_season.Size = new System.Drawing.Size(200, 20);
            this.cmb_season.Style = style16;
            this.cmb_season.TabIndex = 379;
            this.cmb_season.SelectedValueChanged += new System.EventHandler(this.cmb_season_SelectedValueChanged);
            // 
            // dpick_ymd
            // 
            this.dpick_ymd.CustomFormat = "";
            this.dpick_ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ymd.Location = new System.Drawing.Point(310, 56);
            this.dpick_ymd.Name = "dpick_ymd";
            this.dpick_ymd.Size = new System.Drawing.Size(201, 21);
            this.dpick_ymd.TabIndex = 389;
            this.dpick_ymd.CloseUp += new System.EventHandler(this.dpick_ymd_CloseUp);
            // 
            // txt_totPur
            // 
            this.txt_totPur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totPur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_totPur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totPur.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_totPur.Location = new System.Drawing.Point(125, 24);
            this.txt_totPur.MaxLength = 10;
            this.txt_totPur.Name = "txt_totPur";
            this.txt_totPur.ReadOnly = true;
            this.txt_totPur.Size = new System.Drawing.Size(100, 21);
            this.txt_totPur.TabIndex = 378;
            this.txt_totPur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chk_allchanges
            // 
            this.chk_allchanges.Checked = true;
            this.chk_allchanges.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_allchanges.Location = new System.Drawing.Point(24, 72);
            this.chk_allchanges.Name = "chk_allchanges";
            this.chk_allchanges.Size = new System.Drawing.Size(288, 24);
            this.chk_allchanges.TabIndex = 390;
            this.chk_allchanges.Text = "all style applying the changes";
            // 
            // chk_allprice
            // 
            this.chk_allprice.Checked = true;
            this.chk_allprice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_allprice.Location = new System.Drawing.Point(24, 96);
            this.chk_allprice.Name = "chk_allprice";
            this.chk_allprice.Size = new System.Drawing.Size(288, 24);
            this.chk_allprice.TabIndex = 390;
            this.chk_allprice.Text = "all style applying the result price";
            // 
            // chk_autoTotCalc
            // 
            this.chk_autoTotCalc.Location = new System.Drawing.Point(24, 48);
            this.chk_autoTotCalc.Name = "chk_autoTotCalc";
            this.chk_autoTotCalc.Size = new System.Drawing.Size(288, 24);
            this.chk_autoTotCalc.TabIndex = 390;
            this.chk_autoTotCalc.Text = "total price calculate as it may exchange rate";
            // 
            // chk_autoCBDCalc
            // 
            this.chk_autoCBDCalc.Location = new System.Drawing.Point(24, 24);
            this.chk_autoCBDCalc.Name = "chk_autoCBDCalc";
            this.chk_autoCBDCalc.Size = new System.Drawing.Size(288, 24);
            this.chk_autoCBDCalc.TabIndex = 390;
            this.chk_autoCBDCalc.Text = "CBD price calculate as it may exchange rate";
            // 
            // grp_option
            // 
            this.grp_option.Controls.Add(this.chk_allprice);
            this.grp_option.Controls.Add(this.chk_autoTotCalc);
            this.grp_option.Controls.Add(this.chk_autoCBDCalc);
            this.grp_option.Controls.Add(this.chk_allchanges);
            this.grp_option.Location = new System.Drawing.Point(8, 344);
            this.grp_option.Name = "grp_option";
            this.grp_option.Size = new System.Drawing.Size(376, 136);
            this.grp_option.TabIndex = 391;
            this.grp_option.TabStop = false;
            this.grp_option.Text = " Option ";
            // 
            // grp_result
            // 
            this.grp_result.Controls.Add(this.txt_outsideCurrency);
            this.grp_result.Controls.Add(this.txt_CBDCurrency);
            this.grp_result.Controls.Add(this.txt_purCurrency);
            this.grp_result.Controls.Add(this.lbl_outside);
            this.grp_result.Controls.Add(this.txt_outside);
            this.grp_result.Controls.Add(this.lbl_purTot);
            this.grp_result.Controls.Add(this.btn_apply);
            this.grp_result.Controls.Add(this.btn_cancel);
            this.grp_result.Controls.Add(this.txt_totCBD);
            this.grp_result.Controls.Add(this.txt_totPur);
            this.grp_result.Controls.Add(this.lbl_cbdTot);
            this.grp_result.Location = new System.Drawing.Point(396, 344);
            this.grp_result.Name = "grp_result";
            this.grp_result.Size = new System.Drawing.Size(296, 136);
            this.grp_result.TabIndex = 392;
            this.grp_result.TabStop = false;
            this.grp_result.Text = " Result ";
            // 
            // txt_outsideCurrency
            // 
            this.txt_outsideCurrency.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_outsideCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_outsideCurrency.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_outsideCurrency.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_outsideCurrency.Location = new System.Drawing.Point(226, 68);
            this.txt_outsideCurrency.MaxLength = 10;
            this.txt_outsideCurrency.Name = "txt_outsideCurrency";
            this.txt_outsideCurrency.ReadOnly = true;
            this.txt_outsideCurrency.Size = new System.Drawing.Size(50, 21);
            this.txt_outsideCurrency.TabIndex = 544;
            this.txt_outsideCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_CBDCurrency
            // 
            this.txt_CBDCurrency.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_CBDCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CBDCurrency.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_CBDCurrency.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_CBDCurrency.Location = new System.Drawing.Point(226, 46);
            this.txt_CBDCurrency.MaxLength = 10;
            this.txt_CBDCurrency.Name = "txt_CBDCurrency";
            this.txt_CBDCurrency.ReadOnly = true;
            this.txt_CBDCurrency.Size = new System.Drawing.Size(50, 21);
            this.txt_CBDCurrency.TabIndex = 543;
            this.txt_CBDCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_purCurrency
            // 
            this.txt_purCurrency.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_purCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_purCurrency.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_purCurrency.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_purCurrency.Location = new System.Drawing.Point(226, 24);
            this.txt_purCurrency.MaxLength = 10;
            this.txt_purCurrency.Name = "txt_purCurrency";
            this.txt_purCurrency.ReadOnly = true;
            this.txt_purCurrency.Size = new System.Drawing.Size(50, 21);
            this.txt_purCurrency.TabIndex = 542;
            this.txt_purCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_outside
            // 
            this.lbl_outside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outside.ImageIndex = 0;
            this.lbl_outside.ImageList = this.img_Label;
            this.lbl_outside.Location = new System.Drawing.Point(24, 68);
            this.lbl_outside.Name = "lbl_outside";
            this.lbl_outside.Size = new System.Drawing.Size(100, 21);
            this.lbl_outside.TabIndex = 381;
            this.lbl_outside.Text = "Outside CBD";
            this.lbl_outside.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_outside
            // 
            this.txt_outside.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_outside.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_outside.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_outside.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_outside.Location = new System.Drawing.Point(125, 68);
            this.txt_outside.MaxLength = 10;
            this.txt_outside.Name = "txt_outside";
            this.txt_outside.ReadOnly = true;
            this.txt_outside.Size = new System.Drawing.Size(100, 21);
            this.txt_outside.TabIndex = 380;
            this.txt_outside.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_purTot
            // 
            this.lbl_purTot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_purTot.ImageIndex = 0;
            this.lbl_purTot.ImageList = this.img_Label;
            this.lbl_purTot.Location = new System.Drawing.Point(24, 24);
            this.lbl_purTot.Name = "lbl_purTot";
            this.lbl_purTot.Size = new System.Drawing.Size(100, 21);
            this.lbl_purTot.TabIndex = 379;
            this.lbl_purTot.Text = "Total Purchase";
            this.lbl_purTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_cbdTot
            // 
            this.lbl_cbdTot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_cbdTot.ImageIndex = 0;
            this.lbl_cbdTot.ImageList = this.img_Label;
            this.lbl_cbdTot.Location = new System.Drawing.Point(24, 46);
            this.lbl_cbdTot.Name = "lbl_cbdTot";
            this.lbl_cbdTot.Size = new System.Drawing.Size(100, 21);
            this.lbl_cbdTot.TabIndex = 379;
            this.lbl_cbdTot.Text = "Total CBD";
            this.lbl_cbdTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_BP_Outside_Calc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(698, 487);
            this.Controls.Add(this.grp_result);
            this.Controls.Add(this.grp_option);
            this.Controls.Add(this.dpick_ymd);
            this.Controls.Add(this.cmb_season);
            this.Controls.Add(this.txt_rate);
            this.Controls.Add(this.btn_rate);
            this.Controls.Add(this.cmb_curType);
            this.Controls.Add(this.lbl_curType);
            this.Controls.Add(this.fgrid_main);
            this.Name = "Pop_BP_Outside_Calc";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_BP_Outside_Calc_Closing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.fgrid_main, 0);
            this.Controls.SetChildIndex(this.lbl_curType, 0);
            this.Controls.SetChildIndex(this.cmb_curType, 0);
            this.Controls.SetChildIndex(this.btn_rate, 0);
            this.Controls.SetChildIndex(this.txt_rate, 0);
            this.Controls.SetChildIndex(this.cmb_season, 0);
            this.Controls.SetChildIndex(this.dpick_ymd, 0);
            this.Controls.SetChildIndex(this.grp_option, 0);
            this.Controls.SetChildIndex(this.grp_result, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_curType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season)).EndInit();
            this.grp_option.ResumeLayout(false);
            this.grp_result.ResumeLayout(false);
            this.grp_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region 그리드 이벤트 처리

		private void fgrid_main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (fgrid_main.Col != _CBDCol)
				{
					mnu_CBDPrice.Visible = false;
				}
				else
				{
					mnu_CBDPrice.Visible = true;
				}
			}
		}

		private void fgrid_main_SelChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if (fgrid_main.Row >= fgrid_main.Rows.Fixed)
				viewTotal();
		}

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if (chk_allchanges.Checked)
			{
				// 수정시 전체 스타일에 동시적용
				object obj = fgrid_main[e.Row, e.Col];
				string item = fgrid_main[e.Row, _itemCol].ToString();

				for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					if (item.Equals(fgrid_main[vRow, _itemCol].ToString()))
					{
						fgrid_main[vRow, e.Col] = obj;
					}
				}
			}

			priceCalculation();
			viewTotal();
		}

		private void fgrid_main_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				if (fgrid_main.Col == _CBDCol)
				{
					CBDPriceCalculation();
					priceCalculation();
				}
			}
		}
		
		#endregion

		#region 컨트롤 이벤트 처리

		private void btn_rate_Click(object sender, System.EventArgs e)
		{
			if (chk_autoCBDCalc.Checked)
			{
				CBDPriceCalculation();
			}

			rateCalculation();
		}

		private void cmb_curType_SelectedValueChanged(object sender, System.EventArgs e)
		{			
			curTypeChanged();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			if (chk_allprice.Checked)
			{
				if (txt_totPur.Text.Equals("") || txt_totCBD.Text.Equals("") || txt_outside.Text.Equals("") || txt_outsideCurrency.Text.Equals(""))
				{
					ClassLib.ComFunction.User_Message("Input price or currency", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}

			mainGridApply();
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void dpick_ymd_CloseUp(object sender, System.EventArgs e)
		{
			string vDate = dpick_ymd.Value.ToString("yyyyMMdd");
			string vRate = getRate(vDate);
			txt_rate.Text = vRate;
		}

		private void cmb_season_SelectedValueChanged(object sender, System.EventArgs e)
		{
			txt_rate.Text = cmb_season.GetItemText(cmb_season.SelectedIndex, 1);
		}

		private void txt_rate_TextChanged(object sender, System.EventArgs e)
		{
			if (chk_autoCBDCalc.Checked)
			{
				CBDPriceCalculation();
			}

			if (chk_autoTotCalc.Checked)
			{
				priceCalculation();
			}
		}

		private void mnu_cbdPrice_Click(object sender, System.EventArgs e)
		{
			if (fgrid_main.Col == _CBDCol)
			{
				CBDPriceCalculation();
				priceCalculation();
			}
		}

		private void mnu_getPurPrice_Click(object sender, System.EventArgs e)
		{
			getPurPrice();
			priceCalculation();
		}

		private void mnu_searchCBD_Click(object sender, System.EventArgs e)
		{
			searchCBD();
			priceCalculation();
		}

		private void Pop_BP_Outside_Calc_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			_mainGrid.Rows[_mainGrid.Row].Node.Expanded = false;
			_mainGrid.TopRow = _orgPt;
		}


		#region 버튼 효과

		private void btn_click_Effect_Up(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		private void btn_click_Effect_Down(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_rate_Effect_Up(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 3;
		}

		private void btn_rate_Effect_Down(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 2;
		}

		#endregion

		#endregion

		#region 이벤트 처리 메서드

		private void Init_Form()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;


				this.Text = "Outside Price";
                lbl_MainTitle.Text = "Outside Price";
                ClassLib.ComFunction.SetLangDic(this);

				fgrid_main.Set_Grid("SBP_OUTSIDE_INFO", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_main.Rows[1].AllowMerging = true;

				_cmbOP = txt_rate.Location;
				_lblOP = btn_rate.Location;
				_cmbNP = new Point(_cmbOP.X - 200, _cmbOP.Y);
				_lblNP = new Point(_lblOP.X - 200, _lblOP.Y);

				DataTable vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBP08");
				COM.ComCtl.Set_ComboList(vDt, cmb_curType, 1, 2, false);
				cmb_curType.SelectedIndex = 1;
				vDt.Dispose();

				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBP14");
				COM.ComCtl.Set_ComboList(vDt, cmb_season, 1, 2, false);
				vDt.Dispose();


				int vRow = _mainGrid.Row;

				_orgPt = _mainGrid.TopRow;
				if (_mainGrid.Rows[vRow].Node.Level == 2)
					vRow = _mainGrid.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

				_mainGrid.TopRow = vRow;
				_mainGrid.Rows[vRow].Node.Expanded = true;

				_itemName = ClassLib.ComVar.Parameter_PopUp[6];

				vDt = SELECT_OUTSIDE_INFO();

				if (vDt.Rows.Count > 0)
				{
					ClassLib.ComFunction.Display_FlexGrid_Tree(fgrid_main, vDt, 0);
					fgrid_main.Tree.Column = (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxITEM;
					GridSetColor();
					fgrid_main.Select(fgrid_main.Rows.Fixed, 0);
				}
				else
				{
					fgrid_main.ClearAll();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				fgrid_main.AfterSelChange += new RangeEventHandler(fgrid_main_SelChange);
			}
		}

		private void GridSetColor()
		{
			try
			{
				for (int vRow = fgrid_main.Rows.Count - 1 ; vRow >= fgrid_main.Rows.Fixed ; vRow--)
				{
					switch (fgrid_main.Rows[vRow].Node.Level)
					{
						case 1:
							fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
							fgrid_main.GetCellRange(vRow, 6, vRow, fgrid_main.Cols.Count - 2).Clear(C1.Win.C1FlexGrid.ClearFlags.Content);
							fgrid_main.Rows[vRow].AllowEditing = false;
							break;
						case 2:
							fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
							fgrid_main.GetCellRange(vRow, 6, vRow, fgrid_main.Cols.Count - 2).Clear(C1.Win.C1FlexGrid.ClearFlags.Content);
							fgrid_main.Rows[vRow].AllowEditing = false;
							break;
						default :
							fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
							break;
					}

					if (_itemName.Equals(fgrid_main[vRow, _itemCol].ToString()))
					{
						fgrid_main.GetCellRange(vRow, _totPurCol, vRow, _totCBDCol).StyleNew.BackColor = Color.LightPink;
					}
				}
                
				priceCalculation();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void rateCalculation() 
		{
			priceCalculation();
		}

		private void curTypeChanged()
		{
			string vRate = "";
			bool vSeason = false;
			bool vYmd = false;

			switch (cmb_curType.SelectedIndex)
			{
				case 0:	// 현재 환률
					dpick_ymd.Value = DateTime.Now;
					string vCurDate = DateTime.Now.ToString("yyyyMMdd");
					vRate = getRate(vCurDate);
					txt_rate.ReadOnly = true;
					txt_rate.BackColor = Color.WhiteSmoke;
					vSeason = false;
					vYmd = true;
					break;
				case 1: // 지난달 환률
					DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(-1);
					dpick_ymd.Value = dt;
					string vLastMonth = dt.ToString("yyyyMMdd");
					vRate = getRate(vLastMonth);
					txt_rate.ReadOnly = true;
					txt_rate.BackColor = Color.WhiteSmoke;
					vSeason = false;
					vYmd = true;
					break;
				case 2: // 시즌
					txt_rate.ReadOnly = true;
					txt_rate.BackColor = Color.WhiteSmoke;
					vRate = cmb_season.SelectedValue == null ? "1" : cmb_season.GetItemText(cmb_season.SelectedIndex, 1);
					vSeason = true;
					vYmd = false;
					break;
				case 3: // 사용자 정의
					txt_rate.ReadOnly = false;
					txt_rate.BackColor = Color.White;
					vRate = "1";
					break;
			}

			if (!vSeason && !vYmd)
			{
				btn_rate.Location = _lblNP;
				txt_rate.Location = _cmbNP;
			} 
			else
			{
				btn_rate.Location = _lblOP;
				txt_rate.Location = _cmbOP;
			}

			cmb_season.Enabled = vSeason;
			cmb_season.Visible = vSeason;
			dpick_ymd.Enabled = vYmd;
			dpick_ymd.Visible = vYmd;

			txt_rate.Text = vRate;
		}

		// 환률 적용 CBD 단가 계산
		private void CBDPriceCalculation()
		{
			double vRate = Convert.ToDouble(txt_rate.Text);;
			double vCurPrice = 0.0, vResultPrice = 0.0;

			if (chk_allchanges.Checked)
			{
				for (int vRow = 0 ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _purCurrencyCol]).Equals(KRW))
					{
						vCurPrice = Convert.ToDouble(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _purCol]));
						vResultPrice = Math.Round((vCurPrice / vRate), _roundNum);
						fgrid_main[vRow, _CBDCol] = vResultPrice;
						fgrid_main[vRow, _CBDCol + 1] = USD;
					}
					else if (ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, _purCurrencyCol]).Equals(USD))
					{
						fgrid_main[fgrid_main.Row, _CBDCol] = fgrid_main[fgrid_main.Row, _purCol];;
						fgrid_main[fgrid_main.Row, _CBDCol + 1] = fgrid_main[fgrid_main.Row, _purCol + 1];
					}
				}
			}
			else
			{
				if (ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, _purCurrencyCol]).Equals(KRW))
				{
					vCurPrice = Convert.ToDouble(ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, _purCol]));
					vResultPrice = Math.Round((vCurPrice / vRate), _roundNum);
					fgrid_main[fgrid_main.Row, _CBDCol] = vResultPrice;
					fgrid_main[fgrid_main.Row, _CBDCol + 1] = USD;
				}
				else if (ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, _purCurrencyCol]).Equals(USD))
				{
					fgrid_main[fgrid_main.Row, _CBDCol] = fgrid_main[fgrid_main.Row, _purCol];;
					fgrid_main[fgrid_main.Row, _CBDCol + 1] = fgrid_main[fgrid_main.Row, _purCol + 1];
				}
			}
		}

		// 메인 그리드의 박주단가 가져오기
		private void getPurPrice()
		{
			Node node = _mainGrid.Rows[_mainGrid.Row].Node.GetNode(NodeTypeEnum.LastChild);

			int vMainStartRow = fgrid_main.Row;
			int vMainEndRow = fgrid_main.Row;

			if (node != null)
			{
				vMainStartRow = fgrid_main.Row;
				vMainEndRow = node.Row.Index;
			}

			for (int i = fgrid_main.Rows.Fixed ; i < fgrid_main.Rows.Count ; i++)
			{
				if (fgrid_main.Rows[i].Node.Level < 3 || !_itemName.Equals(fgrid_main[i, _itemCol].ToString()))
					continue;

				string vStyle = fgrid_main[i, _styleCol].ToString();
				string vOBSId = fgrid_main[i, _obsIdCol].ToString().Replace("NONE", "");
				
				for (int vRow = vMainStartRow ; vRow <= vMainEndRow ; vRow++)
				{
					string vMainStyle = _mainGrid[vRow, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxITEM_NAME].ToString().Replace("-", "");
					string vMainOBSId = _mainGrid[vRow, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOBS_ID].ToString().Replace("NONE", "");
					if (!vMainStyle.Equals(vStyle) && vMainOBSId.Equals(vOBSId))
						continue;
					
					fgrid_main[i, _purCol] = _mainGrid[vRow, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_PRICE];
					fgrid_main[i, _purCurrencyCol] = _mainGrid[vRow, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxPUR_CURRENCY];
					//fgrid_main[i, 0] = "U";
				}
			}
		}

		// CBD Master 검색
		private void searchCBD()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string div = "111111";

				for (int i = fgrid_main.Rows.Fixed ; i < fgrid_main.Rows.Count ; i++)
				{
					if (fgrid_main.Rows[i].Node.Level < 3)
						continue;

					DataTable vDt = SELECT_CBD_INFORMATION (div, 
						fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxFACTORY].ToString(), 
						fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxOBS_ID].ToString(), 
						fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxSTYLE_CD].ToString(), 
						fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxITEM_CD].ToString(), 
						fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxSPEC_CD].ToString(), 
						fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxCOLOR_CD].ToString());

					if (vDt.Rows.Count > 0)
					{
						fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxPUR_PRICE] = vDt.Rows[0]["PUR_PRICE"].ToString();
						fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxPUR_CURRENCY] = vDt.Rows[0]["PUR_CURRENCY"].ToString();

						if (fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxITEM_DIVISION].ToString().Equals("J"))
						{
							fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxCBD_PRICE] = vDt.Rows[0]["OUTSIDE_PRICE"].ToString();
							fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxCBD_CURRENCY] = vDt.Rows[0]["OUTSIDE_CURRENCY"].ToString();
						}
						else
						{
							fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxCBD_PRICE] = vDt.Rows[0]["CBD_PRICE"].ToString();
							fgrid_main[i, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxCBD_CURRENCY] = vDt.Rows[0]["CBD_CURRENCY"].ToString();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				MessageBox.Show("Process Complete!!");
			}
		}

		// 임가공 단가 계산
		private void priceCalculation()
		{
			int vCalcType = Convert.ToInt32(COM.ComVar.Parameter_PopUp[7]);

			switch (vCalcType)
			{
                case 0:		opTypeB();		break;
				case 1:		opTypeB();		break;
				case 2:		opTypeB();		break;
				case 3:		opTypeB();		break;
				case 4:		opTypeB();		break;
				case 5:		opTypeB();		break;
				case 6:		opTypeC();		break;
				case 7:		opTypeD();		break;
				case 8:		opTypeC();		break;
				case 9:		opTypeD();		break;
			}

			txt_totPur.Text = ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxTEMP1]);
			txt_totCBD.Text = ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxTEMP2]);
			txt_outside.Text = ClassLib.ComFunction.NullToBlank(fgrid_main[fgrid_main.Row, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxCBD_PRICE]);
		}

		private void opTypeA() 
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				string vMatType = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _matTypeCol]);
				if (!vMatType.Equals("J"))
					continue;

				double vPurPrice = 0.0;
				double vCBDPrice = 0.0;

				Node vLastNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.LastChild);
				Node vTempNode = vLastNode;

				if (vTempNode != null)
				{
					vPurPrice += getPriceSum_AB(vTempNode, _purCol, _totPurCol, false);
					vCBDPrice += getPriceSum_AB(vTempNode, _CBDCol, _totCBDCol, false);
				}

				vPurPrice += exchange(vRow, _purCol, true);
				vCBDPrice += exchange(vRow, _CBDCol, true);
				
				fgrid_main[vRow, _totPurCol] = Math.Round((vPurPrice), _roundNum);
				fgrid_main[vRow, _totCBDCol] = Math.Round((vCBDPrice), _roundNum);
			}
		}

		private void opTypeB() 
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				string vMatType = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, _matTypeCol]);
				if (!vMatType.Equals("J"))
					continue;

				double vPurPrice = 0.0;
				double vCBDPrice = 0.0;

				Node vLastNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.LastChild);
				Node vTempNode = vLastNode;

				if (vTempNode != null)
				{
					vPurPrice += getPriceSum_AB(vTempNode, _purCol, _totPurCol, true);
					vCBDPrice += getPriceSum_AB(vTempNode, _CBDCol, _totCBDCol, true);
				}

				if ((bool)fgrid_main[vRow, _purYN])
				{
					vPurPrice += exchange(vRow, _purCol, true);					
					vCBDPrice += exchange(vRow, _CBDCol, true);
				}
				
				fgrid_main[vRow, _totPurCol] = Math.Round((vPurPrice), _roundNum);
				fgrid_main[vRow, _totCBDCol] = Math.Round((vCBDPrice), _roundNum);
			}
		}

		private void opTypeC() 
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				if (fgrid_main.Rows[vRow].Node.Level < 3)
					continue;

				double vPurPrice = 0.0;
				double vCBDPrice = 0.0;

				Node vPNode = fgrid_main.Rows[vRow].Node;
                Node vCNode = vPNode.GetNode(NodeTypeEnum.LastChild);
				Node vFCNode = vCNode.GetNode(NodeTypeEnum.FirstChild);
				Node vLCNode = vCNode.GetNode(NodeTypeEnum.LastChild);

				vPurPrice = getPriceSum_CD(vCNode, _purCol, _pairPurCol, _totPurCol, true);
				vCBDPrice = getPriceSum_CD(vCNode, _CBDCol, _pairCBDCol, _totCBDCol, true);

				// Root Node
				if ((bool)fgrid_main[vPNode.Row.Index, _purYN])
				{
					vPurPrice += exchange(vPNode.Row.Index, _purCol, true) / 2;
					vCBDPrice += exchange(vPNode.Row.Index, _CBDCol, true) / 2;
					fgrid_main[vPNode.Row.Index, _pairPurCol] = Math.Round((exchange(vPNode.Row.Index, _purCol, true) / 2), _roundNum);
					fgrid_main[vPNode.Row.Index, _pairCBDCol] = Math.Round((exchange(vPNode.Row.Index, _CBDCol, true) / 2), _roundNum);
				}
				
				fgrid_main[vPNode.Row.Index, _totPurCol] = Math.Round(vPurPrice, _roundNum) * 2;
				fgrid_main[vPNode.Row.Index, _totCBDCol] = Math.Round(vCBDPrice, _roundNum) * 2;

				vRow = vLCNode.Row.Index;
			}
		}

		private void opTypeD() 
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				string vCurItem = fgrid_main[vRow, _itemCol].ToString();

				if (!_itemName.Equals(vCurItem))
					continue;

				double vPurPrice = 0.0;
				double vCBDPrice = 0.0;

				Node vPNode = fgrid_main.Rows[vRow].Node;
				Node vCNode = vPNode.GetNode(NodeTypeEnum.LastChild);

				vPurPrice = getPriceSum_C(vCNode, _purCol, _pairPurCol, _totPurCol, true);
				vCBDPrice = getPriceSum_C(vCNode, _CBDCol, _pairCBDCol, _totCBDCol, true);

				// Root Node
				if ((bool)fgrid_main[vPNode.Row.Index, _purYN])
				{
					vPurPrice += exchange(vPNode.Row.Index, _purCol, true);
					vCBDPrice += exchange(vPNode.Row.Index, _CBDCol, true);
					fgrid_main[vPNode.Row.Index, _pairPurCol] = Math.Round((exchange(vPNode.Row.Index, _purCol, true)), _roundNum);
					fgrid_main[vPNode.Row.Index, _pairCBDCol] = Math.Round((exchange(vPNode.Row.Index, _CBDCol, true)), _roundNum);
				}
				
				fgrid_main[vPNode.Row.Index, _totPurCol] = Math.Round(vPurPrice, _roundNum);
				fgrid_main[vPNode.Row.Index, _totCBDCol] = Math.Round(vCBDPrice, _roundNum);

				vRow = vCNode.Row.Index;
			}
		}

		private void mainGridApply()
		{
			Node vMainCurNode = _mainGrid.Rows[_mainGrid.Row].Node;

			int vRow = 0;
			int vMainStartRow = _mainGrid.Row;
			int vMainEndRow = _mainGrid.Row;

			if (vMainCurNode.Level == 1)
			{
				vMainStartRow = _mainGrid.Row;
				vMainEndRow = vMainCurNode.GetNode(NodeTypeEnum.LastChild).Row.Index;
			}

			if (chk_allprice.Checked)
			{
				string vTotCBDPrice = txt_totCBD.Text;
				string vCBDCurrency = txt_CBDCurrency.Text;
				string vOutsidePrice = txt_outside.Text;
				string vOutsideCurrency = txt_outsideCurrency.Text;

				for (vRow = vMainStartRow ; vRow <= vMainEndRow ; vRow++)
				{
					mainGridSetData(vRow, vOutsidePrice, vOutsideCurrency, vTotCBDPrice, vCBDCurrency);
				}
			}
			else
			{
				for (int i = fgrid_main.Rows.Fixed ; i < fgrid_main.Rows.Count ; i++)
				{
					if (!_itemName.Equals(fgrid_main[i, _itemCol].ToString()))
						continue;

					string vStyle = fgrid_main[i, _styleCol].ToString();
					string vOBSId = fgrid_main[i, _obsIdCol].ToString();
					
					object vTotCBDPrice = fgrid_main[i, _totCBDCol];
					object vCBDCurrency = USD;
					object vOutsidePrice = fgrid_main[i, _CBDCol];
					object vOutsideCurrency = fgrid_main[i, _CBDCol + 1];

					mainGridSetData(vMainStartRow, vOutsidePrice, vOutsideCurrency, vTotCBDPrice, vCBDCurrency);

					for (vRow = vMainStartRow ; vRow <= vMainEndRow ; vRow++)
					{
						string vMainStyle = _mainGrid[vRow, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxITEM_NAME].ToString().Replace("-", "");
						string vMainOBSId = _mainGrid[vRow, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOBS_ID].ToString();
						if (!vMainStyle.Equals(vStyle) || !vMainOBSId.Equals(vOBSId))
							continue;

						mainGridSetData(vRow, vOutsidePrice, vOutsideCurrency, vTotCBDPrice, vCBDCurrency);
					}
				}
			}

			if (_slist.Count > 0)	RUN_SBP_CBD_UPDATE();
		}

		private void viewTotal()
		{
			Node curNode = fgrid_main.Rows[fgrid_main.Row].Node;
            Node tmpNode = curNode;
			int vRow = -1, vStartRow = curNode.Row.Index;
			
			// 상위 검색
			do
			{
				if (_itemName.Equals(fgrid_main[tmpNode.Row.Index, _itemCol].ToString()))
				{
					tmpNode.Row[(int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxTEMP1].ToString();
					vRow = tmpNode.Row.Index;
				}

				vStartRow = tmpNode.Row.Index;
			} while ((tmpNode = tmpNode.GetNode(NodeTypeEnum.Parent)) != null);

			// 하위 검색
			if (vRow == -1)
			{
				int vEndRow = fgrid_main.Rows.Count - 1;
				Node vNextNode = fgrid_main.Rows[vStartRow].Node.GetNode(NodeTypeEnum.NextSibling);
				if (vNextNode != null)
					vEndRow = vNextNode.Row.Index;

				for (int i = vStartRow ; i <= vEndRow ; i++)
				{
					if (_itemName.Equals(fgrid_main[i, _itemCol].ToString()))
					{
						vRow = i;
						break;
					}
				}
			}

			// 데이터 보여주기
			if (vRow != -1)
			{
				txt_totPur.Text = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxTEMP1]);
				txt_totCBD.Text = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxTEMP2]);
				txt_outside.Text = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxCBD_PRICE]);

				txt_purCurrency.Text = USD;
				txt_CBDCurrency.Text = USD;
				txt_outsideCurrency.Text = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBP_OUTSIDE_INFO_2.IxCBD_CURRENCY]);
			}
		}

		#region Utility

		private double getPriceSum_AB(Node arg_node, int arg_col, int arg_totCol, bool arg_useChk)
		{
			double vPrice = 0.0;
			Node vTempNode = arg_node;

			do
			{
				if (vTempNode.GetNode(NodeTypeEnum.LastChild) != null)
					vPrice += getPriceSum_AB(vTempNode.GetNode(NodeTypeEnum.LastChild), arg_col, arg_totCol, arg_useChk);

				if ((bool)fgrid_main[vTempNode.Row.Index, _purYN] || !arg_useChk)
				{
					vPrice += exchange(vTempNode.Row.Index, arg_col, true);
					//vTempNode.Row[arg_totCol] = Math.Round(vPrice, _roundNum);
				}
				else
				{
					vTempNode.Row[arg_totCol] = null;
				}
			} while ((vTempNode = vTempNode.GetNode(NodeTypeEnum.PreviousSibling)) != null);

			return vPrice;
		}

		private double getPriceSum_C(Node arg_node, int arg_col, int arg_pairCol, int arg_totCol, bool arg_useChk)
		{
			double vPrice = 0.0;
			Node vTempNode = arg_node;

			do
			{
				if (vTempNode.GetNode(NodeTypeEnum.LastChild) != null)
					vPrice += getPriceSum_C(vTempNode.GetNode(NodeTypeEnum.LastChild), arg_col, arg_pairCol, arg_totCol, arg_useChk);
				
				if ((bool)fgrid_main[vTempNode.Row.Index, _purYN] || !arg_useChk)
				{
					double yield = Convert.ToDouble(vTempNode.Row[_yieldCol].ToString());

					vPrice += exchange(vTempNode.Row.Index, arg_col, true) / (1 / yield);
					vTempNode.Row[arg_pairCol] = Math.Round(exchange(vTempNode.Row.Index, arg_col, true) / (1 / yield), _roundNum);
					//vTempNode.Row[arg_totCol] = Math.Round(vPrice, _roundNum);
				}
				else
				{
					vTempNode.Row[arg_pairCol] = 0;
					//vTempNode.Row[arg_totCol] = 0;
				}
			} while ((vTempNode = vTempNode.GetNode(NodeTypeEnum.PreviousSibling)) != null);

			return vPrice;
		}

		private double getPriceSum_CD(Node arg_node, int arg_col, int arg_pairCol, int arg_totCol, bool arg_useChk)
		{
			double vPrice = 0.0;
			Node vTempNode = arg_node;

			do
			{
				if (vTempNode.GetNode(NodeTypeEnum.LastChild) != null)
					vPrice += getPriceSum_CD(vTempNode.GetNode(NodeTypeEnum.LastChild), arg_col, arg_pairCol, arg_totCol, arg_useChk);
				
				if ((bool)fgrid_main[vTempNode.Row.Index, _purYN] || !arg_useChk)
				{
					double yield = Convert.ToDouble(vTempNode.Row[_yieldCol].ToString());

					vPrice += yield * exchange(vTempNode.Row.Index, arg_col, true);
					vTempNode.Row[arg_pairCol] = Math.Round(yield * exchange(vTempNode.Row.Index, arg_col, true), _roundNum);
					//vTempNode.Row[arg_totCol] = Math.Round(vPrice, _roundNum);
				}
				else
				{
					vTempNode.Row[arg_pairCol] = 0;
					//vTempNode.Row[arg_totCol] = 0;
				}
			} while ((vTempNode = vTempNode.GetNode(NodeTypeEnum.PreviousSibling)) != null);

			return vPrice;
		}

		private double exchange(int arg_row, int arg_col, bool arg_currencyCheck)
		{
			double vResult = 0;

			double vRate = 0;

			try
			{
				vRate = Convert.ToDouble(txt_rate.Text);
			}
			catch
			{
				vRate = 1;
			}

			if (fgrid_main[arg_row, arg_col] != null)
			{
				if (!fgrid_main[arg_row, arg_col].ToString().Equals(""))
				{					
					vResult = Convert.ToDouble(fgrid_main[arg_row, arg_col]);

					// Currency 가 KRW인 경우
					if (ClassLib.ComFunction.NullToBlank(fgrid_main[arg_row, arg_col + 1]).Equals("KRW") && arg_currencyCheck)
					{
						vResult = vResult / vRate;
					}
				}
			}

			return vResult;
		}

		private string getRate(string arg_date)
		{
			string vLastMonth = arg_date;
			DataTable vDt = ClassLib.ComFunction.Select_Ymd_Rate(vLastMonth);
			string vRate = vDt.Rows[0][0].ToString();
			return vRate;
		}

		private Node getParent(Node arg_node)
		{
			if (arg_node.GetNode(NodeTypeEnum.Parent) == null)
				return arg_node;
			else
				return getParent(arg_node.GetNode(NodeTypeEnum.Parent));
		}

		private void mainGridSetData(int arg_row, object arg_outside, object arg_outsideCur, object arg_totCBD, object arg_cbdCur)
		{
			_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_PRICE] = arg_outside;
			_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_CURRENCY] = arg_outsideCur;
			_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_PRICE] = arg_totCBD;
			_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_CURRENCY] = arg_cbdCur;
			_mainGrid[arg_row, 0] = ClassLib.ComVar.Update;
			
			if (_mainGrid.Rows[arg_row].Node.Level == 2)
			{
				_slist.Add(_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxFACTORY].ToString());
				_slist.Add(_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOBS_ID].ToString());
				_slist.Add(_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxITEM_NAME].ToString());
				_slist.Add(_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxITEM_CD].ToString());
				_slist.Add(_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxSPEC_CD].ToString());
				_slist.Add(_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCOLOR_CD].ToString());
				_slist.Add(txt_purCurrency.Text);
				_slist.Add(txt_totPur.Text);
				_slist.Add(_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_CURRENCY].ToString());
				_slist.Add(_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxOUTSIDE_PRICE].ToString());
				_slist.Add(_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_CURRENCY].ToString());
				_slist.Add(_mainGrid[arg_row, (int)ClassLib.TBSBP_PURCHASE_TAIL_2.IxCBD_PRICE].ToString());
				_slist.Add(COM.ComVar.This_User);
			}
		}

		#endregion

		#endregion

		#region DBConnect

		/// <summary>
		/// PKG_SBP_PURCHASE_ORDER : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_OUTSIDE_INFO()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_ORDER_EXTEND.SELECT_OUTSIDE_INFO_2";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_NO";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[5] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[6] = "ARG_COLOR_CD";
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
			MyOraDB.Parameter_Values[0] = ClassLib.ComVar.Parameter_PopUp[0];
			MyOraDB.Parameter_Values[1] = ClassLib.ComVar.Parameter_PopUp[1];
			MyOraDB.Parameter_Values[2] = ClassLib.ComVar.Parameter_PopUp[8];
			MyOraDB.Parameter_Values[3] = ClassLib.ComVar.Parameter_PopUp[2];
			MyOraDB.Parameter_Values[4] = ClassLib.ComVar.Parameter_PopUp[3];
			MyOraDB.Parameter_Values[5] = ClassLib.ComVar.Parameter_PopUp[4];
			MyOraDB.Parameter_Values[6] = ClassLib.ComVar.Parameter_PopUp[5];
			MyOraDB.Parameter_Values[7] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// SELECT_CBD_INFORMATION
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_CBD_INFORMATION (
			string arg_division, 
			string arg_factory, 
			string arg_obs_id, 
			string arg_style_cd, 
			string arg_item_cd, 
			string arg_spec_cd, 
			string arg_color_cd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			//MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.SELECT_CBD_INFORMATION";
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.SELECT_CBD_INFO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[5] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[6] = "ARG_COLOR_CD";
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
			MyOraDB.Parameter_Values[0] = arg_division;
			MyOraDB.Parameter_Values[1] = arg_factory;
			MyOraDB.Parameter_Values[2] = arg_obs_id;
			MyOraDB.Parameter_Values[3] = arg_style_cd;
			MyOraDB.Parameter_Values[4] = arg_item_cd;
			MyOraDB.Parameter_Values[5] = arg_spec_cd;
			MyOraDB.Parameter_Values[6] = arg_color_cd;
			MyOraDB.Parameter_Values[7] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBP_PURCHASE_MANAGER : 
		/// </summary>
		public bool RUN_SBP_CBD_UPDATE()
		{
			try
			{
				MyOraDB.ReDim_Parameter(13);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_PURCHASE_ORDER_EXTEND.RUN_SBP_CBD_UPDATE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[4] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[5] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[6] = "ARG_OUTSIDE_PUR_CURRENCY";
				MyOraDB.Parameter_Name[7] = "ARG_OUTSIDE_PUR_PRICE";
				MyOraDB.Parameter_Name[8] = "ARG_OUTSIDE_CURRENCY";
				MyOraDB.Parameter_Name[9] = "ARG_OUTSIDE_PRICE";
				MyOraDB.Parameter_Name[10] = "ARG_CBD_CURRENCY";
				MyOraDB.Parameter_Name[11] = "ARG_CBD_PRICE";
				MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";

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
				MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;

				MyOraDB.Parameter_Values = (string[])_slist.ToArray(Type.GetType("System.String"));
				MyOraDB.Add_Modify_Parameter(true);
				MyOraDB.Exe_Modify_Procedure();

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "RUN_SBP_CBD_UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return false;
			}
		}

		#endregion
	}
}

