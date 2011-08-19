using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexPurchase.Incoming
{
	public class Pop_BI_Incoming_Rate_Exchanger : COM.PCHWinForm.Pop_Small
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_rate;
		private System.Windows.Forms.Label lbl_rate;
		private C1.Win.C1List.C1Combo cmb_target;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_source;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_inYmd;
		private System.Windows.Forms.DateTimePicker dpick_Ymd;
		private C1.Win.C1List.C1Combo cmb_curKind;
		private System.Windows.Forms.Label lbl_currency;
		private System.Windows.Forms.GroupBox groupBox1;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB   = new COM.OraDB();

		#endregion

		#region 생성자 / 소멸자
		public Pop_BI_Incoming_Rate_Exchanger()
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

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		#endregion
		
		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BI_Incoming_Rate_Exchanger));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.lbl_rate = new System.Windows.Forms.Label();
            this.cmb_target = new C1.Win.C1List.C1Combo();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_source = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_inYmd = new System.Windows.Forms.Label();
            this.dpick_Ymd = new System.Windows.Forms.DateTimePicker();
            this.cmb_curKind = new C1.Win.C1List.C1Combo();
            this.lbl_currency = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_target)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_curKind)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
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
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.GridDefinition = "71.551724137931:False:True;23.2758620689655:False:True;\t1.01010101010101:False:Tr" +
                "ue;93.9393939393939:False:False;1.01010101010101:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(396, 232);
            this.c1Sizer1.TabIndex = 27;
            this.c1Sizer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_rate);
            this.panel1.Controls.Add(this.lbl_rate);
            this.panel1.Controls.Add(this.cmb_target);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_source);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_inYmd);
            this.panel1.Controls.Add(this.dpick_Ymd);
            this.panel1.Controls.Add(this.cmb_curKind);
            this.panel1.Controls.Add(this.lbl_currency);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 166);
            this.panel1.TabIndex = 184;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Window;
            this.btn_search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(334, 104);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 21);
            this.btn_search.TabIndex = 392;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(223, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 24);
            this.label5.TabIndex = 402;
            this.label5.Text = "=>";
            // 
            // txt_rate
            // 
            this.txt_rate.Location = new System.Drawing.Point(118, 128);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(240, 21);
            this.txt_rate.TabIndex = 401;
            // 
            // lbl_rate
            // 
            this.lbl_rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_rate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rate.ImageIndex = 0;
            this.lbl_rate.ImageList = this.img_Label;
            this.lbl_rate.Location = new System.Drawing.Point(14, 128);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(100, 21);
            this.lbl_rate.TabIndex = 400;
            this.lbl_rate.Text = "Rate";
            this.lbl_rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_target
            // 
            this.cmb_target.AddItemCols = 0;
            this.cmb_target.AddItemSeparator = ';';
            this.cmb_target.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_target.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_target.Caption = "";
            this.cmb_target.CaptionHeight = 17;
            this.cmb_target.CaptionStyle = style25;
            this.cmb_target.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_target.ColumnCaptionHeight = 18;
            this.cmb_target.ColumnFooterHeight = 18;
            this.cmb_target.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_target.ContentHeight = 16;
            this.cmb_target.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_target.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_target.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_target.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_target.EditorHeight = 16;
            this.cmb_target.EvenRowStyle = style26;
            this.cmb_target.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_target.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_target.FooterStyle = style27;
            this.cmb_target.GapHeight = 2;
            this.cmb_target.HeadingStyle = style28;
            this.cmb_target.HighLightRowStyle = style29;
            this.cmb_target.ItemHeight = 15;
            this.cmb_target.Location = new System.Drawing.Point(262, 72);
            this.cmb_target.MatchEntryTimeout = ((long)(2000));
            this.cmb_target.MaxDropDownItems = ((short)(5));
            this.cmb_target.MaxLength = 32767;
            this.cmb_target.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_target.Name = "cmb_target";
            this.cmb_target.OddRowStyle = style30;
            this.cmb_target.PartialRightColumn = false;
            this.cmb_target.PropBag = resources.GetString("cmb_target.PropBag");
            this.cmb_target.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_target.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_target.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_target.SelectedStyle = style31;
            this.cmb_target.Size = new System.Drawing.Size(96, 20);
            this.cmb_target.Style = style32;
            this.cmb_target.TabIndex = 398;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(262, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 399;
            this.label2.Text = "Target";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_source
            // 
            this.cmb_source.AddItemCols = 0;
            this.cmb_source.AddItemSeparator = ';';
            this.cmb_source.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_source.Caption = "";
            this.cmb_source.CaptionHeight = 17;
            this.cmb_source.CaptionStyle = style33;
            this.cmb_source.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_source.ColumnCaptionHeight = 18;
            this.cmb_source.ColumnFooterHeight = 18;
            this.cmb_source.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_source.ContentHeight = 16;
            this.cmb_source.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_source.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_source.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_source.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_source.EditorHeight = 16;
            this.cmb_source.EvenRowStyle = style34;
            this.cmb_source.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_source.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_source.FooterStyle = style35;
            this.cmb_source.GapHeight = 2;
            this.cmb_source.HeadingStyle = style36;
            this.cmb_source.HighLightRowStyle = style37;
            this.cmb_source.ItemHeight = 15;
            this.cmb_source.Location = new System.Drawing.Point(118, 72);
            this.cmb_source.MatchEntryTimeout = ((long)(2000));
            this.cmb_source.MaxDropDownItems = ((short)(5));
            this.cmb_source.MaxLength = 32767;
            this.cmb_source.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_source.Name = "cmb_source";
            this.cmb_source.OddRowStyle = style38;
            this.cmb_source.PartialRightColumn = false;
            this.cmb_source.PropBag = resources.GetString("cmb_source.PropBag");
            this.cmb_source.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_source.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_source.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_source.SelectedStyle = style39;
            this.cmb_source.Size = new System.Drawing.Size(96, 20);
            this.cmb_source.Style = style40;
            this.cmb_source.TabIndex = 396;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(118, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 397;
            this.label1.Text = "Source";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_inYmd
            // 
            this.lbl_inYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inYmd.ImageIndex = 0;
            this.lbl_inYmd.ImageList = this.img_Label;
            this.lbl_inYmd.Location = new System.Drawing.Point(14, 104);
            this.lbl_inYmd.Name = "lbl_inYmd";
            this.lbl_inYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_inYmd.TabIndex = 394;
            this.lbl_inYmd.Text = "Date";
            this.lbl_inYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_Ymd
            // 
            this.dpick_Ymd.CustomFormat = "";
            this.dpick_Ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_Ymd.Location = new System.Drawing.Point(118, 104);
            this.dpick_Ymd.Name = "dpick_Ymd";
            this.dpick_Ymd.Size = new System.Drawing.Size(219, 21);
            this.dpick_Ymd.TabIndex = 395;
            // 
            // cmb_curKind
            // 
            this.cmb_curKind.AddItemCols = 0;
            this.cmb_curKind.AddItemSeparator = ';';
            this.cmb_curKind.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_curKind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_curKind.Caption = "";
            this.cmb_curKind.CaptionHeight = 17;
            this.cmb_curKind.CaptionStyle = style41;
            this.cmb_curKind.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_curKind.ColumnCaptionHeight = 18;
            this.cmb_curKind.ColumnFooterHeight = 18;
            this.cmb_curKind.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_curKind.ContentHeight = 16;
            this.cmb_curKind.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_curKind.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_curKind.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_curKind.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_curKind.EditorHeight = 16;
            this.cmb_curKind.EvenRowStyle = style42;
            this.cmb_curKind.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_curKind.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_curKind.FooterStyle = style43;
            this.cmb_curKind.GapHeight = 2;
            this.cmb_curKind.HeadingStyle = style44;
            this.cmb_curKind.HighLightRowStyle = style45;
            this.cmb_curKind.ItemHeight = 15;
            this.cmb_curKind.Location = new System.Drawing.Point(118, 16);
            this.cmb_curKind.MatchEntryTimeout = ((long)(2000));
            this.cmb_curKind.MaxDropDownItems = ((short)(5));
            this.cmb_curKind.MaxLength = 32767;
            this.cmb_curKind.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_curKind.Name = "cmb_curKind";
            this.cmb_curKind.OddRowStyle = style46;
            this.cmb_curKind.PartialRightColumn = false;
            this.cmb_curKind.PropBag = resources.GetString("cmb_curKind.PropBag");
            this.cmb_curKind.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_curKind.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_curKind.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_curKind.SelectedStyle = style47;
            this.cmb_curKind.Size = new System.Drawing.Size(240, 20);
            this.cmb_curKind.Style = style48;
            this.cmb_curKind.TabIndex = 391;
            // 
            // lbl_currency
            // 
            this.lbl_currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_currency.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currency.ImageIndex = 0;
            this.lbl_currency.ImageList = this.img_Label;
            this.lbl_currency.Location = new System.Drawing.Point(14, 16);
            this.lbl_currency.Name = "lbl_currency";
            this.lbl_currency.Size = new System.Drawing.Size(100, 21);
            this.lbl_currency.TabIndex = 393;
            this.lbl_currency.Text = "Currency Kind";
            this.lbl_currency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 166);
            this.groupBox1.TabIndex = 403;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_apply);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 54);
            this.panel2.TabIndex = 181;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageIndex = 1;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(272, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 238;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseDown);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseUp);
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 1;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(200, 6);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 24);
            this.btn_apply.TabIndex = 237;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseDown);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseUp);
            // 
            // Pop_BI_Incoming_Rate_Exchanger
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 268);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BI_Incoming_Rate_Exchanger";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_target)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_curKind)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트 처리

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp		= new string[4];
			COM.ComVar.Parameter_PopUp[0]	= COM.ComFunction.Empty_Combo(cmb_curKind, "") == " " ? "00" : COM.ComFunction.Empty_Combo(cmb_curKind, "");
			COM.ComVar.Parameter_PopUp[1]	= COM.ComFunction.Empty_Combo(cmb_source, "");
			COM.ComVar.Parameter_PopUp[2]	= COM.ComFunction.Empty_Combo(cmb_target, "");
			COM.ComVar.Parameter_PopUp[3]	= COM.ComFunction.Empty_TextBox(txt_rate, "") == "" ? "0" : COM.ComFunction.Empty_TextBox(txt_rate, "");
			this.Dispose();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			string vYmd		= this.dpick_Ymd.Text.Replace("-","");
			string vSource	= this.cmb_source.SelectedValue.ToString();
			string vTarget	= this.cmb_target.SelectedValue.ToString();
			string vSourceRate = ""; 
			string vTargetRate = ""; 

			if (vYmd == "" || vSource == "" || vTarget == "")
			{
				MessageBox.Show( "Select Condition!","Search Check",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return;
			}

			DataTable vTemp = this.SELECT_ACC_CMM014(vYmd, vSource, vTarget);
			if (vTemp.Rows.Count > 0 && vTemp.Rows.Count < 2)
			{
				vSourceRate = vTemp.Rows[0].ItemArray[0].ToString(); 
				vTargetRate = vTemp.Rows[0].ItemArray[1].ToString(); 

				//if (vSourceRate.Equals("0") || vTargetRate.Equals("0"))
				if (vTargetRate.Equals("0"))
				{
					txt_rate.Text		= "";
					ClassLib.ComFunction.User_Message("Not Found Rate At This Date!");
				}
				else
				{
					txt_rate.Text		= vTemp.Rows[0].ItemArray[2].ToString();
				}
			}
			else
			{
				txt_rate.Text		= "";
			}
			vTemp.Dispose();		
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
			this.btn_cancel.ImageIndex = 1;
		}

		private void btn_close_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_cancel.ImageIndex = 0;
		}
		#endregion


		#region 이벤트 처리 메서드

		private void Init_Form()
		{
			// Form Setting
//			ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Rate Exchange";
            this.Text = "Rate Exchange";
            ClassLib.ComFunction.SetLangDic(this);

			// Currency Kind Combobox Setting
			DataTable vDt = null;
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC12");
			COM.ComCtl.Set_ComboList(vDt, cmb_curKind, 1, 2, true, 56,0);
			cmb_curKind.SelectedIndex = 0;
			vDt.Dispose();

			// Exchange Source, Target Currency Combobox Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC06");
			COM.ComCtl.Set_ComboList(vDt, cmb_source, 1, 2, false, 56,0);
			COM.ComCtl.Set_ComboList(vDt, cmb_target, 1, 2, false, 56,0);
			cmb_source.SelectedIndex = -1;
			cmb_target.SelectedIndex = -1;
			vDt.Dispose();
			cmb_source.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBI_IN_HEAD : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBI_IN_HEAD : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_ACC_CMM014(string arg_ymd, string arg_source, string arg_target)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_ADJUST.SELECT_ACC_CMM014";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_YMD";
			MyOraDB.Parameter_Name[1] = "ARG_SOURCE";
			MyOraDB.Parameter_Name[2] = "ARG_TARGET";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_ymd;
			MyOraDB.Parameter_Values[1] = arg_source;
			MyOraDB.Parameter_Values[2] = arg_target;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion

	}
}

