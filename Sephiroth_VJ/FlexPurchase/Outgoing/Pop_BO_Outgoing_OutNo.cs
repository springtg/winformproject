using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexPurchase.Outgoing
{
	public class Pop_BO_Outgoing_OutNo : COM.PCHWinForm.Pop_Large
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.ComponentModel.IContainer components = null;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_outDate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_contNo;
		private C1.Win.C1List.C1Combo cmb_contNo;
		private C1.Win.C1List.C1Combo cmb_Process;
		private System.Windows.Forms.Label lbl_Proc;
		private C1.Win.C1List.C1Combo cmb_User;
		private System.Windows.Forms.Label lbl_User;
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private System.Windows.Forms.Label lbl_division;
		private C1.Win.C1List.C1Combo cmb_division;


		

		//		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		//		private int _OutNoCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxOUT_NO;
		//		private int _shippingYNCol = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSHIPPING_YN;
		//		private int _lotNoCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxLOT_NO;
		//		private int _styleCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSTYLE_NAME;
		//		private int _styleCdCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSTYLE_CD;
		//		private int _styleQtyCol   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxTOT_SHIP_QTY_STYLE;
		//		private System.Windows.Forms.Label lbl_obsType;
		//		private C1.Win.C1List.C1Combo cmb_obsType;
		//		private int _shipType	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSHIP_TYPE;

		#endregion

		#region 생성자 / 소멸자
		public Pop_BO_Outgoing_OutNo()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BO_Outgoing_OutNo));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_contNo = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_division = new System.Windows.Forms.Label();
            this.cmb_division = new C1.Win.C1List.C1Combo();
            this.cmb_User = new C1.Win.C1List.C1Combo();
            this.lbl_User = new System.Windows.Forms.Label();
            this.cmb_Process = new C1.Win.C1List.C1Combo();
            this.lbl_Proc = new System.Windows.Forms.Label();
            this.lbl_contNo = new System.Windows.Forms.Label();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_outDate = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_contNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_division)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
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
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "20:False:True;77.6:False:False;\t0.505050505050505:False:True;96.4646464646465:Fal" +
                "se:False;1.01010101010101:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(792, 500);
            this.c1Sizer1.TabIndex = 25;
            this.c1Sizer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmb_contNo);
            this.panel1.Controls.Add(this.cmb_factory);
            this.panel1.Controls.Add(this.lbl_factory);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 100);
            this.panel1.TabIndex = 168;
            // 
            // cmb_contNo
            // 
            this.cmb_contNo.AddItemCols = 0;
            this.cmb_contNo.AddItemSeparator = ';';
            this.cmb_contNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_contNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_contNo.Caption = "";
            this.cmb_contNo.CaptionHeight = 17;
            this.cmb_contNo.CaptionStyle = style1;
            this.cmb_contNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_contNo.ColumnCaptionHeight = 18;
            this.cmb_contNo.ColumnFooterHeight = 18;
            this.cmb_contNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_contNo.ContentHeight = 16;
            this.cmb_contNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_contNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_contNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_contNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_contNo.EditorHeight = 16;
            this.cmb_contNo.EvenRowStyle = style2;
            this.cmb_contNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_contNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_contNo.FooterStyle = style3;
            this.cmb_contNo.GapHeight = 2;
            this.cmb_contNo.HeadingStyle = style4;
            this.cmb_contNo.HighLightRowStyle = style5;
            this.cmb_contNo.ItemHeight = 15;
            this.cmb_contNo.Location = new System.Drawing.Point(445, 13);
            this.cmb_contNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_contNo.MaxDropDownItems = ((short)(5));
            this.cmb_contNo.MaxLength = 32767;
            this.cmb_contNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_contNo.Name = "cmb_contNo";
            this.cmb_contNo.OddRowStyle = style6;
            this.cmb_contNo.PartialRightColumn = false;
            this.cmb_contNo.PropBag = resources.GetString("cmb_contNo.PropBag");
            this.cmb_contNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_contNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_contNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_contNo.SelectedStyle = style7;
            this.cmb_contNo.Size = new System.Drawing.Size(219, 20);
            this.cmb_contNo.Style = style8;
            this.cmb_contNo.TabIndex = 182;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style9;
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
            this.cmb_factory.EvenRowStyle = style10;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style11;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style12;
            this.cmb_factory.HighLightRowStyle = style13;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 13);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style14;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style15;
            this.cmb_factory.Size = new System.Drawing.Size(211, 20);
            this.cmb_factory.Style = style16;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_division);
            this.groupBox1.Controls.Add(this.cmb_division);
            this.groupBox1.Controls.Add(this.cmb_User);
            this.groupBox1.Controls.Add(this.lbl_User);
            this.groupBox1.Controls.Add(this.cmb_Process);
            this.groupBox1.Controls.Add(this.lbl_Proc);
            this.groupBox1.Controls.Add(this.lbl_contNo);
            this.groupBox1.Controls.Add(this.dpick_from);
            this.groupBox1.Controls.Add(this.dpick_to);
            this.groupBox1.Controls.Add(this.lbl_outDate);
            this.groupBox1.Controls.Add(this.lblexcep_mark);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 88);
            this.groupBox1.TabIndex = 181;
            this.groupBox1.TabStop = false;
            // 
            // lbl_division
            // 
            this.lbl_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_division.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_division.ImageIndex = 1;
            this.lbl_division.ImageList = this.img_Label;
            this.lbl_division.Location = new System.Drawing.Point(344, 35);
            this.lbl_division.Name = "lbl_division";
            this.lbl_division.Size = new System.Drawing.Size(100, 21);
            this.lbl_division.TabIndex = 189;
            this.lbl_division.Text = "Outgoing Div";
            this.lbl_division.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_division
            // 
            this.cmb_division.AddItemCols = 0;
            this.cmb_division.AddItemSeparator = ';';
            this.cmb_division.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_division.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_division.Caption = "";
            this.cmb_division.CaptionHeight = 17;
            this.cmb_division.CaptionStyle = style17;
            this.cmb_division.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_division.ColumnCaptionHeight = 18;
            this.cmb_division.ColumnFooterHeight = 18;
            this.cmb_division.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_division.ContentHeight = 16;
            this.cmb_division.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_division.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_division.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_division.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_division.EditorHeight = 16;
            this.cmb_division.EvenRowStyle = style18;
            this.cmb_division.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_division.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_division.FooterStyle = style19;
            this.cmb_division.GapHeight = 2;
            this.cmb_division.HeadingStyle = style20;
            this.cmb_division.HighLightRowStyle = style21;
            this.cmb_division.ItemHeight = 15;
            this.cmb_division.Location = new System.Drawing.Point(445, 35);
            this.cmb_division.MatchEntryTimeout = ((long)(2000));
            this.cmb_division.MaxDropDownItems = ((short)(5));
            this.cmb_division.MaxLength = 32767;
            this.cmb_division.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_division.Name = "cmb_division";
            this.cmb_division.OddRowStyle = style22;
            this.cmb_division.PartialRightColumn = false;
            this.cmb_division.PropBag = resources.GetString("cmb_division.PropBag");
            this.cmb_division.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_division.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_division.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_division.SelectedStyle = style23;
            this.cmb_division.Size = new System.Drawing.Size(219, 20);
            this.cmb_division.Style = style24;
            this.cmb_division.TabIndex = 190;
            // 
            // cmb_User
            // 
            this.cmb_User.AddItemCols = 0;
            this.cmb_User.AddItemSeparator = ';';
            this.cmb_User.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_User.Caption = "";
            this.cmb_User.CaptionHeight = 17;
            this.cmb_User.CaptionStyle = style25;
            this.cmb_User.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_User.ColumnCaptionHeight = 18;
            this.cmb_User.ColumnFooterHeight = 18;
            this.cmb_User.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_User.ContentHeight = 16;
            this.cmb_User.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_User.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_User.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_User.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_User.EditorHeight = 16;
            this.cmb_User.EvenRowStyle = style26;
            this.cmb_User.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_User.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_User.FooterStyle = style27;
            this.cmb_User.GapHeight = 2;
            this.cmb_User.HeadingStyle = style28;
            this.cmb_User.HighLightRowStyle = style29;
            this.cmb_User.ItemHeight = 15;
            this.cmb_User.Location = new System.Drawing.Point(109, 57);
            this.cmb_User.MatchEntryTimeout = ((long)(2000));
            this.cmb_User.MaxDropDownItems = ((short)(5));
            this.cmb_User.MaxLength = 32767;
            this.cmb_User.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_User.Name = "cmb_User";
            this.cmb_User.OddRowStyle = style30;
            this.cmb_User.PartialRightColumn = false;
            this.cmb_User.PropBag = resources.GetString("cmb_User.PropBag");
            this.cmb_User.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_User.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_User.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_User.SelectedStyle = style31;
            this.cmb_User.Size = new System.Drawing.Size(211, 20);
            this.cmb_User.Style = style32;
            this.cmb_User.TabIndex = 187;
            // 
            // lbl_User
            // 
            this.lbl_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_User.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ImageIndex = 1;
            this.lbl_User.ImageList = this.img_Label;
            this.lbl_User.Location = new System.Drawing.Point(8, 57);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(100, 21);
            this.lbl_User.TabIndex = 188;
            this.lbl_User.Text = "User";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Process
            // 
            this.cmb_Process.AddItemCols = 0;
            this.cmb_Process.AddItemSeparator = ';';
            this.cmb_Process.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Process.Caption = "";
            this.cmb_Process.CaptionHeight = 17;
            this.cmb_Process.CaptionStyle = style33;
            this.cmb_Process.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Process.ColumnCaptionHeight = 18;
            this.cmb_Process.ColumnFooterHeight = 18;
            this.cmb_Process.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Process.ContentHeight = 16;
            this.cmb_Process.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Process.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Process.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Process.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Process.EditorHeight = 16;
            this.cmb_Process.EvenRowStyle = style34;
            this.cmb_Process.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Process.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Process.FooterStyle = style35;
            this.cmb_Process.GapHeight = 2;
            this.cmb_Process.HeadingStyle = style36;
            this.cmb_Process.HighLightRowStyle = style37;
            this.cmb_Process.ItemHeight = 15;
            this.cmb_Process.Location = new System.Drawing.Point(445, 57);
            this.cmb_Process.MatchEntryTimeout = ((long)(2000));
            this.cmb_Process.MaxDropDownItems = ((short)(5));
            this.cmb_Process.MaxLength = 32767;
            this.cmb_Process.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Process.Name = "cmb_Process";
            this.cmb_Process.OddRowStyle = style38;
            this.cmb_Process.PartialRightColumn = false;
            this.cmb_Process.PropBag = resources.GetString("cmb_Process.PropBag");
            this.cmb_Process.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Process.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Process.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Process.SelectedStyle = style39;
            this.cmb_Process.Size = new System.Drawing.Size(219, 20);
            this.cmb_Process.Style = style40;
            this.cmb_Process.TabIndex = 186;
            // 
            // lbl_Proc
            // 
            this.lbl_Proc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Proc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Proc.ImageIndex = 1;
            this.lbl_Proc.ImageList = this.img_Label;
            this.lbl_Proc.Location = new System.Drawing.Point(344, 57);
            this.lbl_Proc.Name = "lbl_Proc";
            this.lbl_Proc.Size = new System.Drawing.Size(100, 21);
            this.lbl_Proc.TabIndex = 185;
            this.lbl_Proc.Text = "Process";
            this.lbl_Proc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_contNo
            // 
            this.lbl_contNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_contNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contNo.ImageIndex = 1;
            this.lbl_contNo.ImageList = this.img_Label;
            this.lbl_contNo.Location = new System.Drawing.Point(344, 13);
            this.lbl_contNo.Name = "lbl_contNo";
            this.lbl_contNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_contNo.TabIndex = 179;
            this.lbl_contNo.Text = "Container No";
            this.lbl_contNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(222, 35);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 5;
            this.dpick_to.ValueChanged += new System.EventHandler(this.dpick_to_ValueChanged);
            // 
            // lbl_outDate
            // 
            this.lbl_outDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outDate.ImageIndex = 1;
            this.lbl_outDate.ImageList = this.img_Label;
            this.lbl_outDate.Location = new System.Drawing.Point(8, 35);
            this.lbl_outDate.Name = "lbl_outDate";
            this.lbl_outDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_outDate.TabIndex = 52;
            this.lbl_outDate.Text = "Outgoing Date";
            this.lbl_outDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(207, 40);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(16, 16);
            this.lblexcep_mark.TabIndex = 178;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(12, 108);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(764, 388);
            this.spd_main.TabIndex = 167;
            this.spd_main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellDoubleClick);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // Pop_BO_Outgoing_OutNo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.c1Sizer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pop_BO_Outgoing_OutNo";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_contNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_division)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
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
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Btn_SearchClickProcess();							
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			dpick_to.Value = dpick_from.Value; 
		}

		private void dpick_to_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{		
				DataTable vDt = null;

				// cmb_container
				string vFromDate = dpick_from.Text.Replace("-","");
				string vToDate	 = dpick_to.Text.Replace("-","");

				vDt = ClassLib.ComFunction.Select_Container(COM.ComVar.This_Factory, vFromDate, vToDate);

				ClassLib.ComCtl.Set_ComboList(vDt, cmb_contNo, 1, 2, true, 56, 0 );
				if (vDt != null && vDt.Rows.Count > 0)
				{
					cmb_contNo.SelectedIndex	= 1; 
				}
				else if(vDt != null)
				{
					cmb_contNo.SelectedIndex	= 0; 
				}
				else
				{
					cmb_contNo.SelectedIndex	= -1; 
				}

				vDt.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_styleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			lbl_MainTitle.Text = "Outgoing No";
            this.Text = "Outgoing No";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SBO_OUT_HEAD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;


			//	cmb_outProcess
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Process_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_Process, 0, 1, true);
			cmb_Process.SelectedIndex = -1;

			// cmb_OutUser
			// cmb_purUser
			vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory,"");
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_User , 1, 1, true, 0, 210);
			cmb_User.SelectedIndex   = -1;
			cmb_User.Enabled  = false;
			//cmb_purUser.ValueMember = "Name";
			//cmb_User.SelectedValue = COM.ComVar.This_User;


			// default search proviso
			if (COM.ComVar.Parameter_PopUp[0].ToString() != "")
				cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];

			// user define variable setting
			_mainSheet = spd_main.Sheets[0];


			// out_div set    cmb_outDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBO02");
			COM.ComCtl.Set_ComboList(vDt, cmb_division, 1, 2, false, 56,0);
			cmb_division.SelectedIndex = -1;



			// Disabled tbutton
			tbtn_Save.Enabled		= false;
			tbtn_Delete.Enabled		= false;
			tbtn_Conform.Enabled	= false;
			tbtn_Print.Enabled		= false;
			tbtn_Create.Enabled		= false;

		}

		private void Btn_SearchClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string vFactory			= ClassLib.ComFunction.Empty_Combo(this.cmb_factory, "");
				string vOutYmdFr		= dpick_from.Text.Replace("-", "");
				string vOutYmdTo		= dpick_to.Text.Replace("-", "");
				string vContNo			= ClassLib.ComFunction.Empty_Combo(this.cmb_contNo , " ");
				string vUser			= ClassLib.ComFunction.Empty_Combo(this.cmb_User, " ");
				string vProcess			= ClassLib.ComFunction.Empty_Combo(this.cmb_Process , " ");
				string vDivision		= ClassLib.ComFunction.Empty_Combo(this.cmb_division , " ");

				DataTable vDt = this.SELECT_SBO_OUT_NO_LIST(vFactory,  vOutYmdFr, 
					                                        vOutYmdTo, vContNo,
															vUser,     vProcess,
															vDivision);
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
			int vFactory		= (int)ClassLib.TBSBO_OUT_HEAD.IxFACTORY;
			int vOutYmd			= (int)ClassLib.TBSBO_OUT_HEAD.IxOUT_YMD;
			int vOutNo		    = (int)ClassLib.TBSBO_OUT_HEAD.IxOUT_NO;

			COM.ComVar.Parameter_PopUp		= new string[3];
			COM.ComVar.Parameter_PopUp[0]	= _mainSheet.Cells[arg_row, vFactory].Text;
			COM.ComVar.Parameter_PopUp[1]	= _mainSheet.Cells[arg_row, vOutYmd].Text;
			COM.ComVar.Parameter_PopUp[2]	= _mainSheet.Cells[arg_row, vOutNo].Text;

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
		/// PKG_SBS_SHIPPING_HEAD : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_ship_ymd_from">선적일(From)</param>
		/// <param name="arg_ship_ymd_to">선적일(To)</param>
		/// <param name="arg_size">Size Item</param>
		/// <param name="arg_ship_type">선적구분</param>
		/// <param name="arg_obs_type">OBS Type</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBO_OUT_NO_LIST(string arg_factory,    string arg_out_ymd_from, 
												string arg_out_ymd_to, string arg_cont_no,
												string arg_user,	   string arg_process,
			                                    string arg_division)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUT_NO.SELECT_SBO_OUT_NO_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_YMD_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD_TO";
			MyOraDB.Parameter_Name[3] = "ARG_CONT_NO";
			MyOraDB.Parameter_Name[4] = "ARG_OUT_USER";
			MyOraDB.Parameter_Name[5] = "ARG_OUT_PROCESS";
			MyOraDB.Parameter_Name[6] = "ARG_OUT_DIVISION";
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
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_out_ymd_from;
			MyOraDB.Parameter_Values[2] = arg_out_ymd_to;
			MyOraDB.Parameter_Values[3] = arg_cont_no;
			MyOraDB.Parameter_Values[4] = arg_user;
			MyOraDB.Parameter_Values[5] = arg_process;
			MyOraDB.Parameter_Values[6] = arg_division;
			MyOraDB.Parameter_Values[7] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		#endregion

	}
}

