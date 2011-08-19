using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Shipping_List_Head : COM.PCHWinForm.Pop_Medium
	{

		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private int _shipNoCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSHIP_NO;
		//private int _shippingYNCol = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSHIPPING_YN;
		//private int _lotNoCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxLOT_NO;
		private int _styleCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSTYLE_NAME;
		private int _styleCdCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSTYLE_CD;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private C1.Win.C1List.C1Combo cmb_factory;
		private C1.Win.C1List.C1Combo cmb_ShipType;
		private C1.Win.C1List.C1Combo cmb_obsType;
		private C1.Win.C1List.C1Combo cmb_StyleItemDiv;
		private System.Windows.Forms.Label lbl_ShipType;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.Label lbl_StyleItemDiv;
		private System.Windows.Forms.Label lbl_shipDate;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Label lbl_obsType;
		private int _styleQtyCol   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxTOT_SHIP_QTY_STYLE;
		//private int _shipType	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSHIP_TYPE;

		#endregion

		#region 생성자 / 소멸자

		public Pop_BS_Shipping_List_Head()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Shipping_List_Head));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.cmb_ShipType = new C1.Win.C1List.C1Combo();
            this.cmb_obsType = new C1.Win.C1List.C1Combo();
            this.cmb_StyleItemDiv = new C1.Win.C1List.C1Combo();
            this.lbl_ShipType = new System.Windows.Forms.Label();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.lbl_StyleItemDiv = new System.Windows.Forms.Label();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Label();
            this.lbl_obsType = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleItemDiv)).BeginInit();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.groupBox1);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c1Sizer1.GridDefinition = "21.4953271028037:False:True;75.7009345794392:False:False;0.934579439252336:False:" +
                "True;\t0.576368876080692:False:True;97.6945244956772:False:False;0.57636887608069" +
                "2:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
            this.c1Sizer1.TabIndex = 27;
            this.c1Sizer1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpick_to);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.cmb_ShipType);
            this.groupBox1.Controls.Add(this.cmb_obsType);
            this.groupBox1.Controls.Add(this.cmb_StyleItemDiv);
            this.groupBox1.Controls.Add(this.lbl_ShipType);
            this.groupBox1.Controls.Add(this.dpick_from);
            this.groupBox1.Controls.Add(this.lbl_factory);
            this.groupBox1.Controls.Add(this.lblexcep_mark);
            this.groupBox1.Controls.Add(this.lbl_StyleItemDiv);
            this.groupBox1.Controls.Add(this.lbl_shipDate);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.lbl_obsType);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 92);
            this.groupBox1.TabIndex = 167;
            this.groupBox1.TabStop = false;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(220, 38);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(90, 21);
            this.dpick_to.TabIndex = 5;
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
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style3;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style4;
            this.cmb_factory.HighLightRowStyle = style5;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 16);
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
            this.cmb_factory.Size = new System.Drawing.Size(200, 20);
            this.cmb_factory.Style = style8;
            this.cmb_factory.TabIndex = 1;
            // 
            // cmb_ShipType
            // 
            this.cmb_ShipType.AddItemCols = 0;
            this.cmb_ShipType.AddItemSeparator = ';';
            this.cmb_ShipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_ShipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ShipType.Caption = "";
            this.cmb_ShipType.CaptionHeight = 17;
            this.cmb_ShipType.CaptionStyle = style9;
            this.cmb_ShipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ShipType.ColumnCaptionHeight = 18;
            this.cmb_ShipType.ColumnFooterHeight = 18;
            this.cmb_ShipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ShipType.ContentHeight = 16;
            this.cmb_ShipType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ShipType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ShipType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_ShipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ShipType.EditorHeight = 16;
            this.cmb_ShipType.EvenRowStyle = style10;
            this.cmb_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ShipType.FooterStyle = style11;
            this.cmb_ShipType.GapHeight = 2;
            this.cmb_ShipType.HeadingStyle = style12;
            this.cmb_ShipType.HighLightRowStyle = style13;
            this.cmb_ShipType.ItemHeight = 15;
            this.cmb_ShipType.Location = new System.Drawing.Point(431, 16);
            this.cmb_ShipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_ShipType.MaxDropDownItems = ((short)(5));
            this.cmb_ShipType.MaxLength = 32767;
            this.cmb_ShipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ShipType.Name = "cmb_ShipType";
            this.cmb_ShipType.OddRowStyle = style14;
            this.cmb_ShipType.PartialRightColumn = false;
            this.cmb_ShipType.PropBag = resources.GetString("cmb_ShipType.PropBag");
            this.cmb_ShipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ShipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ShipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ShipType.SelectedStyle = style15;
            this.cmb_ShipType.Size = new System.Drawing.Size(200, 20);
            this.cmb_ShipType.Style = style16;
            this.cmb_ShipType.TabIndex = 3;
            // 
            // cmb_obsType
            // 
            this.cmb_obsType.AddItemCols = 0;
            this.cmb_obsType.AddItemSeparator = ';';
            this.cmb_obsType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_obsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_obsType.Caption = "";
            this.cmb_obsType.CaptionHeight = 17;
            this.cmb_obsType.CaptionStyle = style17;
            this.cmb_obsType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_obsType.ColumnCaptionHeight = 18;
            this.cmb_obsType.ColumnFooterHeight = 18;
            this.cmb_obsType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_obsType.ContentHeight = 16;
            this.cmb_obsType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_obsType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_obsType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_obsType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_obsType.EditorHeight = 16;
            this.cmb_obsType.EvenRowStyle = style18;
            this.cmb_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obsType.FooterStyle = style19;
            this.cmb_obsType.GapHeight = 2;
            this.cmb_obsType.HeadingStyle = style20;
            this.cmb_obsType.HighLightRowStyle = style21;
            this.cmb_obsType.ItemHeight = 15;
            this.cmb_obsType.Location = new System.Drawing.Point(109, 60);
            this.cmb_obsType.MatchEntryTimeout = ((long)(2000));
            this.cmb_obsType.MaxDropDownItems = ((short)(5));
            this.cmb_obsType.MaxLength = 32767;
            this.cmb_obsType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_obsType.Name = "cmb_obsType";
            this.cmb_obsType.OddRowStyle = style22;
            this.cmb_obsType.PartialRightColumn = false;
            this.cmb_obsType.PropBag = resources.GetString("cmb_obsType.PropBag");
            this.cmb_obsType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_obsType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_obsType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_obsType.SelectedStyle = style23;
            this.cmb_obsType.Size = new System.Drawing.Size(200, 20);
            this.cmb_obsType.Style = style24;
            this.cmb_obsType.TabIndex = 185;
            // 
            // cmb_StyleItemDiv
            // 
            this.cmb_StyleItemDiv.AddItemCols = 0;
            this.cmb_StyleItemDiv.AddItemSeparator = ';';
            this.cmb_StyleItemDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_StyleItemDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleItemDiv.Caption = "";
            this.cmb_StyleItemDiv.CaptionHeight = 17;
            this.cmb_StyleItemDiv.CaptionStyle = style25;
            this.cmb_StyleItemDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_StyleItemDiv.ColumnCaptionHeight = 18;
            this.cmb_StyleItemDiv.ColumnFooterHeight = 18;
            this.cmb_StyleItemDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_StyleItemDiv.ContentHeight = 16;
            this.cmb_StyleItemDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_StyleItemDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_StyleItemDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_StyleItemDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_StyleItemDiv.EditorHeight = 16;
            this.cmb_StyleItemDiv.EvenRowStyle = style26;
            this.cmb_StyleItemDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StyleItemDiv.FooterStyle = style27;
            this.cmb_StyleItemDiv.GapHeight = 2;
            this.cmb_StyleItemDiv.HeadingStyle = style28;
            this.cmb_StyleItemDiv.HighLightRowStyle = style29;
            this.cmb_StyleItemDiv.ItemHeight = 15;
            this.cmb_StyleItemDiv.Location = new System.Drawing.Point(431, 38);
            this.cmb_StyleItemDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleItemDiv.MaxDropDownItems = ((short)(5));
            this.cmb_StyleItemDiv.MaxLength = 32767;
            this.cmb_StyleItemDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleItemDiv.Name = "cmb_StyleItemDiv";
            this.cmb_StyleItemDiv.OddRowStyle = style30;
            this.cmb_StyleItemDiv.PartialRightColumn = false;
            this.cmb_StyleItemDiv.PropBag = resources.GetString("cmb_StyleItemDiv.PropBag");
            this.cmb_StyleItemDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleItemDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleItemDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleItemDiv.SelectedStyle = style31;
            this.cmb_StyleItemDiv.Size = new System.Drawing.Size(200, 20);
            this.cmb_StyleItemDiv.Style = style32;
            this.cmb_StyleItemDiv.TabIndex = 28;
            // 
            // lbl_ShipType
            // 
            this.lbl_ShipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShipType.ImageIndex = 1;
            this.lbl_ShipType.ImageList = this.img_Label;
            this.lbl_ShipType.Location = new System.Drawing.Point(330, 16);
            this.lbl_ShipType.Name = "lbl_ShipType";
            this.lbl_ShipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_ShipType.TabIndex = 183;
            this.lbl_ShipType.Text = "Ship Type";
            this.lbl_ShipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 38);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(90, 21);
            this.dpick_from.TabIndex = 4;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 16);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 180;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(201, 41);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(16, 16);
            this.lblexcep_mark.TabIndex = 178;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_StyleItemDiv
            // 
            this.lbl_StyleItemDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_StyleItemDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StyleItemDiv.ImageIndex = 0;
            this.lbl_StyleItemDiv.ImageList = this.img_Label;
            this.lbl_StyleItemDiv.Location = new System.Drawing.Point(330, 38);
            this.lbl_StyleItemDiv.Name = "lbl_StyleItemDiv";
            this.lbl_StyleItemDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_StyleItemDiv.TabIndex = 177;
            this.lbl_StyleItemDiv.Text = "Item Division";
            this.lbl_StyleItemDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipDate
            // 
            this.lbl_shipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipDate.ImageIndex = 1;
            this.lbl_shipDate.ImageList = this.img_Label;
            this.lbl_shipDate.Location = new System.Drawing.Point(8, 38);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 52;
            this.lbl_shipDate.Text = "Ship Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(631, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 21);
            this.btn_search.TabIndex = 184;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_obsType
            // 
            this.lbl_obsType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obsType.ImageIndex = 0;
            this.lbl_obsType.ImageList = this.img_Label;
            this.lbl_obsType.Location = new System.Drawing.Point(8, 60);
            this.lbl_obsType.Name = "lbl_obsType";
            this.lbl_obsType.Size = new System.Drawing.Size(100, 21);
            this.lbl_obsType.TabIndex = 186;
            this.lbl_obsType.Text = "Order Type";
            this.lbl_obsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.spd_main);
            this.pnl_main.Location = new System.Drawing.Point(8, 96);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(678, 324);
            this.pnl_main.TabIndex = 166;
            // 
            // spd_main
            // 
            this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(678, 324);
            this.spd_main.TabIndex = 0;
            this.spd_main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellDoubleClick);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // Pop_BS_Shipping_List_Head
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 468);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BS_Shipping_List_Head";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleItemDiv)).EndInit();
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader)
				this.Grid_DoubleClickProcess(e.Row);
		}

		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		private void btn_search_Click(object sender, System.EventArgs e)
		{
            this.Btn_SearchClickProcess();		
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

		private void btn_shipping_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex++;
		}

		private void btn_shipping_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex--;
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
			spd_main.Set_Spread_Comm("SBS_SHIPPING_HEAD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.Parameter_PopUp_Object[0];
			vDt.Dispose();

			// ship type 
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
			COM.ComCtl.Set_ComboList(vDt, cmb_ShipType, 1, 2, false);
			cmb_ShipType.SelectedValue = ClassLib.ComVar.Parameter_PopUp_Object[1];
			if (cmb_ShipType.SelectedValue.ToString().Equals("99"))
				cmb_ShipType.ReadOnly = true;
			vDt.Dispose();

			// cmb_styleitemdiv (Upper, Buttom)
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPItemDivision);
			COM.ComCtl.Set_ComboList(vDt, cmb_StyleItemDiv, 1, 2, false);
			cmb_StyleItemDiv.SelectedIndex = 0;
			vDt.Dispose();

			// obs type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SEM10");
			COM.ComCtl.Set_ComboList(vDt, cmb_obsType, 1, 2, true);
			cmb_obsType.SelectedIndex = 0;
			if (cmb_ShipType.SelectedValue.ToString().Equals("99"))
				cmb_obsType.ReadOnly = true;
			vDt.Dispose();

			dpick_from.Value = Convert.ToDateTime(ClassLib.ComVar.Parameter_PopUp_Object[2]);
			dpick_to.Value = Convert.ToDateTime(ClassLib.ComVar.Parameter_PopUp_Object[2]);

			// user define variable setting
			_mainSheet = spd_main.Sheets[0];
		}

		private void Btn_SearchClickProcess()
		{
			try
			{
				DataTable vDt = SELECT_SBS_SHIPPING_HEAD_LIST();

				if (vDt.Rows.Count > 0)
					spd_main.Display_Grid(vDt);
				else
					spd_main.ClearAll();

				this.Cursor = Cursors.WaitCursor;
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

		private void Grid_DoubleClickProcess(int arg_row)
		{
			int vFactory		= (int)ClassLib.TBSBS_SHIPPING_HEAD.IxFACTORY;
			int vShipYmd		= (int)ClassLib.TBSBS_SHIPPING_HEAD.IxSHIP_YMD;
			int vDivision		= (int)ClassLib.TBSBS_SHIPPING_HEAD.IxSHIP_DIVISION;
			int vSize			= (int)ClassLib.TBSBS_SHIPPING_HEAD.IxSIZE_ITEM_YN;
			int vShipType		= (int)ClassLib.TBSBS_SHIPPING_HEAD.IxSHIP_TYPE;
			int vObsType		= (int)ClassLib.TBSBS_SHIPPING_HEAD.IxOBS_TYPE;
			int vShipNo			= (int)ClassLib.TBSBS_SHIPPING_HEAD.IxSHIP_NO;

			COM.ComVar.Parameter_PopUp		= new string[7];
			COM.ComVar.Parameter_PopUp[0]	= _mainSheet.Cells[arg_row, vFactory].Text;
			COM.ComVar.Parameter_PopUp[1]	= _mainSheet.Cells[arg_row, vShipYmd].Text;
			COM.ComVar.Parameter_PopUp[2]	= _mainSheet.Cells[arg_row, vDivision].Text;
			COM.ComVar.Parameter_PopUp[3]	= _mainSheet.Cells[arg_row, vSize].Text;
			COM.ComVar.Parameter_PopUp[4]	= _mainSheet.Cells[arg_row, vShipType].Text;
			COM.ComVar.Parameter_PopUp[5]	= _mainSheet.Cells[arg_row, vObsType].Text;
			COM.ComVar.Parameter_PopUp[6]	= _mainSheet.Cells[arg_row, vShipNo].Text;

			this.DialogResult = DialogResult.OK;
			this.Close();
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
		public DataTable SELECT_SBS_SHIPPING_HEAD_LIST()
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_HEAD.SELECT_SBS_SHIPPING_HEAD_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_DIVISION";
			MyOraDB.Parameter_Name[4] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[5] = "ARG_OBS_TYPE";
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
			MyOraDB.Parameter_Values[1] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_StyleItemDiv, "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_ShipType, "");
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_Combo(cmb_obsType, "");;
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		#endregion

	}
}

