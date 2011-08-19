using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Purchase
{
	public class Pop_BP_Request : COM.PCHWinForm.Pop_Medium
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_reqDate;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private int _shipNoCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSHIP_NO;
		private int _shippingYNCol = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSHIPPING_YN;
		private int _lotNoCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxLOT_NO;
		private int _styleCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSTYLE_NAME;
		private int _styleCdCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSTYLE_CD;
		private int _styleQtyCol   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxTOT_SHIP_QTY_STYLE;
		private System.Windows.Forms.GroupBox groupBox1;
		private C1.Win.C1List.C1Combo cmb_reqDept;
		private System.Windows.Forms.Label lbl_reqDept;
		private C1.Win.C1List.C1Combo cmb_reqReason;
		private System.Windows.Forms.Label lbl_reqReason;
		private int _shipType	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSHIP_TYPE;

		#endregion

		public Pop_BP_Request()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BP_Request));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_reqReason = new C1.Win.C1List.C1Combo();
            this.lbl_reqReason = new System.Windows.Forms.Label();
            this.cmb_reqDept = new C1.Win.C1List.C1Combo();
            this.lbl_reqDept = new System.Windows.Forms.Label();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Label();
            this.lbl_reqDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.GridDefinition = "16.588785046729:False:True;80.607476635514:False:False;0.934579439252336:False:Tr" +
                "ue;\t0.576368876080692:False:True;97.6945244956772:False:False;0.576368876080692:" +
                "False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
            this.c1Sizer1.TabIndex = 26;
            this.c1Sizer1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(8, 75);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(678, 345);
            this.spd_main.TabIndex = 170;
            this.spd_main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellDoubleClick);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 71);
            this.panel1.TabIndex = 166;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.cmb_reqReason);
            this.groupBox1.Controls.Add(this.lbl_reqReason);
            this.groupBox1.Controls.Add(this.cmb_reqDept);
            this.groupBox1.Controls.Add(this.lbl_reqDept);
            this.groupBox1.Controls.Add(this.dpick_from);
            this.groupBox1.Controls.Add(this.dpick_to);
            this.groupBox1.Controls.Add(this.lblexcep_mark);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.lbl_factory);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.lbl_reqDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 71);
            this.groupBox1.TabIndex = 185;
            this.groupBox1.TabStop = false;
            // 
            // cmb_reqReason
            // 
            this.cmb_reqReason.AddItemCols = 0;
            this.cmb_reqReason.AddItemSeparator = ';';
            this.cmb_reqReason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqReason.Caption = "";
            this.cmb_reqReason.CaptionHeight = 17;
            this.cmb_reqReason.CaptionStyle = style1;
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
            this.cmb_reqReason.EvenRowStyle = style2;
            this.cmb_reqReason.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqReason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqReason.FooterStyle = style3;
            this.cmb_reqReason.GapHeight = 2;
            this.cmb_reqReason.HeadingStyle = style4;
            this.cmb_reqReason.HighLightRowStyle = style5;
            this.cmb_reqReason.ItemHeight = 15;
            this.cmb_reqReason.Location = new System.Drawing.Point(435, 41);
            this.cmb_reqReason.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqReason.MaxDropDownItems = ((short)(5));
            this.cmb_reqReason.MaxLength = 32767;
            this.cmb_reqReason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqReason.Name = "cmb_reqReason";
            this.cmb_reqReason.OddRowStyle = style6;
            this.cmb_reqReason.PartialRightColumn = false;
            this.cmb_reqReason.PropBag = resources.GetString("cmb_reqReason.PropBag");
            this.cmb_reqReason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqReason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqReason.SelectedStyle = style7;
            this.cmb_reqReason.Size = new System.Drawing.Size(210, 20);
            this.cmb_reqReason.Style = style8;
            this.cmb_reqReason.TabIndex = 374;
            // 
            // lbl_reqReason
            // 
            this.lbl_reqReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqReason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqReason.ImageIndex = 0;
            this.lbl_reqReason.ImageList = this.img_Label;
            this.lbl_reqReason.Location = new System.Drawing.Point(334, 41);
            this.lbl_reqReason.Name = "lbl_reqReason";
            this.lbl_reqReason.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqReason.TabIndex = 373;
            this.lbl_reqReason.Text = "Request Reason";
            this.lbl_reqReason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_reqDept
            // 
            this.cmb_reqDept.AddItemCols = 0;
            this.cmb_reqDept.AddItemSeparator = ';';
            this.cmb_reqDept.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reqDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reqDept.Caption = "";
            this.cmb_reqDept.CaptionHeight = 17;
            this.cmb_reqDept.CaptionStyle = style9;
            this.cmb_reqDept.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reqDept.ColumnCaptionHeight = 18;
            this.cmb_reqDept.ColumnFooterHeight = 18;
            this.cmb_reqDept.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reqDept.ContentHeight = 16;
            this.cmb_reqDept.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reqDept.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_reqDept.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reqDept.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reqDept.EditorHeight = 16;
            this.cmb_reqDept.EvenRowStyle = style10;
            this.cmb_reqDept.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reqDept.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reqDept.FooterStyle = style11;
            this.cmb_reqDept.GapHeight = 2;
            this.cmb_reqDept.HeadingStyle = style12;
            this.cmb_reqDept.HighLightRowStyle = style13;
            this.cmb_reqDept.ItemHeight = 15;
            this.cmb_reqDept.Location = new System.Drawing.Point(109, 41);
            this.cmb_reqDept.MatchEntryTimeout = ((long)(2000));
            this.cmb_reqDept.MaxDropDownItems = ((short)(5));
            this.cmb_reqDept.MaxLength = 32767;
            this.cmb_reqDept.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reqDept.Name = "cmb_reqDept";
            this.cmb_reqDept.OddRowStyle = style14;
            this.cmb_reqDept.PartialRightColumn = false;
            this.cmb_reqDept.PropBag = resources.GetString("cmb_reqDept.PropBag");
            this.cmb_reqDept.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reqDept.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reqDept.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reqDept.SelectedStyle = style15;
            this.cmb_reqDept.Size = new System.Drawing.Size(210, 20);
            this.cmb_reqDept.Style = style16;
            this.cmb_reqDept.TabIndex = 368;
            // 
            // lbl_reqDept
            // 
            this.lbl_reqDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqDept.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqDept.ImageIndex = 0;
            this.lbl_reqDept.ImageList = this.img_Label;
            this.lbl_reqDept.Location = new System.Drawing.Point(8, 40);
            this.lbl_reqDept.Name = "lbl_reqDept";
            this.lbl_reqDept.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqDept.TabIndex = 367;
            this.lbl_reqDept.Text = "Request Dept";
            this.lbl_reqDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(435, 19);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(95, 21);
            this.dpick_from.TabIndex = 4;
            this.dpick_from.ValueChanged += new System.EventHandler(this.dpick_from_ValueChanged);
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(552, 19);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(95, 21);
            this.dpick_to.TabIndex = 5;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(532, 23);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(16, 16);
            this.lblexcep_mark.TabIndex = 178;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cmb_factory.Location = new System.Drawing.Point(109, 19);
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
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style24;
            this.cmb_factory.TabIndex = 1;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 19);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 180;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(647, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(21, 21);
            this.btn_search.TabIndex = 184;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseDown);
            this.btn_search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseUp);
            // 
            // lbl_reqDate
            // 
            this.lbl_reqDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqDate.ImageIndex = 0;
            this.lbl_reqDate.ImageList = this.img_Label;
            this.lbl_reqDate.Location = new System.Drawing.Point(334, 19);
            this.lbl_reqDate.Name = "lbl_reqDate";
            this.lbl_reqDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqDate.TabIndex = 52;
            this.lbl_reqDate.Text = "Request Date";
            this.lbl_reqDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_BP_Request
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 468);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BP_Request";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reqDept)).EndInit();
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

		private void spd_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader)
				this.Grid_DoubleClickProcess(e.Row);
		}

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
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

		private void dpick_from_ValueChanged(object sender, System.EventArgs e)
		{
			string vfrom = dpick_from.Text.Replace("-", "");	
			dpick_to.Value         = ClassLib.ComFunction.StringToDateTime(vfrom);
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

		private void GridSetSelectCorrection(FarPoint.Win.Spread.Model.CellRange arg_range)
		{
//			int vStartRow    = arg_range.Row;
//			int vEndRow	     = arg_range.Row + arg_range.RowCount;
//			bool vTemp		 = (_mainSheet.Cells[vStartRow, _shippingYNCol].Text.Equals("") ? false : (bool)_mainSheet.Cells[vStartRow, _shippingYNCol].Value);
//			string vShipType = cmb_materialType.SelectedValue.ToString();
//
//			if (_mainSheet.Cells[vStartRow, 0].Tag == null)
//			{
//				spd_main.Update_Row(vStartRow, img_Action);
//				_mainSheet.Cells[vStartRow, _shipType].Text = vShipType;
//			}
//			else
//			{
//				_mainSheet.ClearRange(vStartRow, 0, 1, 1, false);
//				_mainSheet.Cells[vStartRow, _shipType].Text = "";
//			}
//
//			while (vStartRow < vEndRow)
//			{
//				_mainSheet.Cells[vStartRow, _shippingYNCol].Value = !vTemp;
//				vStartRow++;
//			}
		}

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
            ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Request";
            this.Text = "Request";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SBP_REQ_HEAD_LIST", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();

			// req dept set cmb_reqDept
			vDt = ClassLib.ComFunction.SELECT_CM_DEPT(ClassLib.ComVar.This_Factory, "");
			COM.ComCtl.Set_ComboList(vDt, cmb_reqDept, 0, 1, true);
			cmb_reqDept.SelectedValue = COM.ComVar.This_Dept;

			// cmb_reqReason
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_reqReason, 1, 2, true);
			cmb_reqReason.SelectedIndex = 0;

			// default search proviso
			cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];

			// user define variable setting
			_mainSheet = spd_main.Sheets[0];
		}

		private void Btn_SearchClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = this.SELECT_SBP_REQUEST_HEAD_LIST();
				spd_main.Display_Grid(vDt);
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
			int vRow			= arg_row;
			int vReqYmd		    = (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxREQ_YMD;
			int vReqNo			= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxREQ_NO;
			int vReqUse			= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxREQ_USER;
			int vReqDept		= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxREQ_DEPT;
			int vUseDept		= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxUSE_DEPT;
			int vReqReason		= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxREQ_REASON;
			int vRtaYmd			= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxRTA_YMD;
			int vEstYmd			= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxEST_YMD;
			int vStatus			= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxSTATUS;
			int vOfferYn		= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxOFFER_YN;
			int vOfferNo		= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxOFFER_NO;

			COM.ComVar.Parameter_PopUp		= new string[12];

			COM.ComVar.Parameter_PopUp[0]	= cmb_factory.SelectedValue.ToString();
			COM.ComVar.Parameter_PopUp[1]	= _mainSheet.Cells[vRow, vReqNo].Text;
			COM.ComVar.Parameter_PopUp[2]	= _mainSheet.Cells[vRow, vReqYmd].Text;
			COM.ComVar.Parameter_PopUp[3]	= _mainSheet.Cells[vRow, vReqUse].Text;
			COM.ComVar.Parameter_PopUp[4]	= _mainSheet.Cells[vRow, vReqDept].Text;
			COM.ComVar.Parameter_PopUp[5]	= _mainSheet.Cells[vRow, vUseDept].Text;
			COM.ComVar.Parameter_PopUp[6]	= _mainSheet.Cells[vRow, vReqReason].Text;
			COM.ComVar.Parameter_PopUp[7]	= _mainSheet.Cells[vRow, vRtaYmd].Text;
			COM.ComVar.Parameter_PopUp[8]	= _mainSheet.Cells[vRow, vEstYmd].Text;
			COM.ComVar.Parameter_PopUp[9]	= _mainSheet.Cells[vRow, vStatus].Text;
			COM.ComVar.Parameter_PopUp[10]	= _mainSheet.Cells[vRow, vOfferYn].Text;
			COM.ComVar.Parameter_PopUp[11]	= _mainSheet.Cells[vRow, vOfferNo].Text;

			this.DialogResult = DialogResult.OK;
			this.Close();
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

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBM_SHIP_REQ_ITEM : 
		/// </summary>
		/// <param name="arg_factory">선적공장</param>
		/// <param name="arg_shipYmdFr">선적일(From)</param>
		/// <param name="arg_shipYmdTo">선적일(To)</param>
		/// <param name="arg_dIvision">구분</param>
		/// <param name="arg_size">사이즈구분</param>
		/// <param name="arg_obsType">자재구분</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_REQUEST_HEAD_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_REQUEST_HEAD.SELECT_SBP_REQUEST_HEAD_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_YMD_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_REQ_YMD_TO";
			MyOraDB.Parameter_Name[3] = "ARG_REQ_DEPT";
			MyOraDB.Parameter_Name[4] = "ARG_REQ_REASON";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_reqDept, "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_reqReason, "");
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion

		

	}
}

