using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexPurchase.Incoming
{
	public class Pop_BI_Incoming_InSize : COM.PCHWinForm.Pop_Medium
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.ComponentModel.IContainer components = null;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private C1.Win.C1List.C1Combo cmb_inNo;
		private System.Windows.Forms.Label lbl_inNo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dpick_inYmd;
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private bool _practicable	= false;
		private int _startCol		= 8;
		private int _displayCol		= 7;
		private bool   _vExistData	 = false;
		private System.EventHandler _cmbInNoEventHandler		= null;


		private int _factoryCol			= (int)ClassLib.TBSBI_IN_SIZE.IxFACTORY;
		private int _inNoCol			= (int)ClassLib.TBSBI_IN_SIZE.IxIN_NO;
		private int _updYmdCol			= (int)ClassLib.TBSBI_IN_SIZE.IxUPD_YMD;

		private DataSet DS_Select = new DataSet("Parameter DataSet");
		private DataSet DS_Modify = new DataSet("Modify DataSet");
		private DataSet DS_Run = new DataSet("Run DataSet");

		private DataSet DS_Ret = new DataSet("Return DataSet");


		//------- 프로시저 전달용 변수선언
		/// <summary>
		/// SP 프로세스명
		/// </summary>
		public  string Process_Name;
		/// <summary>
		/// SP 파라메터 배열
		/// </summary>
		public  string[] Parameter_Name;
		/// <summary>
		/// SP 파라메터 유형 배열
		/// </summary>
		public  int[] Parameter_Type;
		/// <summary>
		/// SP 파라메터 값 배열
		/// </summary>
		public  string[] Parameter_Values;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_factory;
		private System.Windows.Forms.TextBox txt_inNo;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;
		/// <summary>
		/// SP 파라메터 매트릭스 배열
		/// </summary>
		public  string[] Parameter_Matrix;


		#endregion

		#region 생성자 / 소멸자
		public Pop_BI_Incoming_InSize()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BI_Incoming_InSize));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_inNo = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_inNo = new System.Windows.Forms.TextBox();
            this.txt_factory = new System.Windows.Forms.TextBox();
            this.cmb_inNo = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.dpick_inYmd = new System.Windows.Forms.DateTimePicker();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "25:False:True;37.5:False:True;18.75:False:True;\t0.568181818181818:False:True;96.0" +
                "227272727273:False:False;1.13636363636364:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(704, 160);
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
            this.pnl_menu.Location = new System.Drawing.Point(12, 112);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(688, 30);
            this.pnl_menu.TabIndex = 175;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(600, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(70, 24);
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
            this.btn_apply.Location = new System.Drawing.Point(528, 3);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 24);
            this.btn_apply.TabIndex = 546;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseDown);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lbl_inNo);
            this.panel1.Controls.Add(this.lbl_factory);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 40);
            this.panel1.TabIndex = 169;
            // 
            // lbl_inNo
            // 
            this.lbl_inNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inNo.ImageIndex = 1;
            this.lbl_inNo.ImageList = this.img_Label;
            this.lbl_inNo.Location = new System.Drawing.Point(320, 13);
            this.lbl_inNo.Name = "lbl_inNo";
            this.lbl_inNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_inNo.TabIndex = 52;
            this.lbl_inNo.Text = "Incoming No";
            this.lbl_inNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(7, 13);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 180;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_inNo);
            this.groupBox1.Controls.Add(this.txt_factory);
            this.groupBox1.Controls.Add(this.cmb_inNo);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.dpick_inYmd);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 40);
            this.groupBox1.TabIndex = 181;
            this.groupBox1.TabStop = false;
            // 
            // txt_inNo
            // 
            this.txt_inNo.Enabled = false;
            this.txt_inNo.Location = new System.Drawing.Point(421, 13);
            this.txt_inNo.Name = "txt_inNo";
            this.txt_inNo.Size = new System.Drawing.Size(200, 21);
            this.txt_inNo.TabIndex = 53;
            // 
            // txt_factory
            // 
            this.txt_factory.Enabled = false;
            this.txt_factory.Location = new System.Drawing.Point(108, 13);
            this.txt_factory.Name = "txt_factory";
            this.txt_factory.Size = new System.Drawing.Size(200, 21);
            this.txt_factory.TabIndex = 52;
            // 
            // cmb_inNo
            // 
            this.cmb_inNo.AddItemCols = 0;
            this.cmb_inNo.AddItemSeparator = ';';
            this.cmb_inNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_inNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inNo.Caption = "";
            this.cmb_inNo.CaptionHeight = 17;
            this.cmb_inNo.CaptionStyle = style1;
            this.cmb_inNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inNo.ColumnCaptionHeight = 18;
            this.cmb_inNo.ColumnFooterHeight = 18;
            this.cmb_inNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inNo.ContentHeight = 16;
            this.cmb_inNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_inNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inNo.EditorHeight = 16;
            this.cmb_inNo.Enabled = false;
            this.cmb_inNo.EvenRowStyle = style2;
            this.cmb_inNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_inNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_inNo.FooterStyle = style3;
            this.cmb_inNo.GapHeight = 2;
            this.cmb_inNo.HeadingStyle = style4;
            this.cmb_inNo.HighLightRowStyle = style5;
            this.cmb_inNo.ItemHeight = 15;
            this.cmb_inNo.Location = new System.Drawing.Point(664, 16);
            this.cmb_inNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_inNo.MaxDropDownItems = ((short)(5));
            this.cmb_inNo.MaxLength = 32767;
            this.cmb_inNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inNo.Name = "cmb_inNo";
            this.cmb_inNo.OddRowStyle = style6;
            this.cmb_inNo.PartialRightColumn = false;
            this.cmb_inNo.PropBag = resources.GetString("cmb_inNo.PropBag");
            this.cmb_inNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inNo.SelectedStyle = style7;
            this.cmb_inNo.Size = new System.Drawing.Size(24, 20);
            this.cmb_inNo.Style = style8;
            this.cmb_inNo.TabIndex = 51;
            this.cmb_inNo.Visible = false;
            this.cmb_inNo.SelectedValueChanged += new System.EventHandler(this.cmb_inNo_SelectedValueChanged);
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
            this.cmb_factory.Enabled = false;
            this.cmb_factory.EvenRowStyle = style10;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style11;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style12;
            this.cmb_factory.HighLightRowStyle = style13;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(712, 16);
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
            this.cmb_factory.Size = new System.Drawing.Size(16, 20);
            this.cmb_factory.Style = style16;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.Visible = false;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // dpick_inYmd
            // 
            this.dpick_inYmd.CustomFormat = "";
            this.dpick_inYmd.Enabled = false;
            this.dpick_inYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_inYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_inYmd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_inYmd.Location = new System.Drawing.Point(688, 16);
            this.dpick_inYmd.Name = "dpick_inYmd";
            this.dpick_inYmd.Size = new System.Drawing.Size(24, 21);
            this.dpick_inYmd.TabIndex = 4;
            this.dpick_inYmd.Value = new System.DateTime(2006, 3, 29, 19, 52, 34, 414);
            this.dpick_inYmd.Visible = false;
            this.dpick_inYmd.ValueChanged += new System.EventHandler(this.dpick_inYmd_ValueChanged);
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(12, 48);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(676, 60);
            this.spd_main.TabIndex = 167;
            this.spd_main.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never;
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // Pop_BI_Incoming_InSize
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(698, 188);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BI_Incoming_InSize";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
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
			if(_vExistData)
			{
				spd_main.Buffer_CellData = "000" ;
				this.spd_main.Update_Row(img_Action);
			}
		}

		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}		

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.Tbtn_SaveProcess();
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

//		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
//		{
//			this.Tbtn_NewProcess();		
//		}
//				
//		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
//		{ 
//			this.Tbtn_SearchProcess();
//		}
//
//		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
//		{
//			this.Tbtn_SaveProcess();
//		}						
//
//		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
//		{
//			spd_main.Delete_Row(img_Action);
//		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Tbtn_NewProcess();
			this.Cmb_inNoSettingProcess();
		}

		private void dpick_inYmd_ValueChanged(object sender, System.EventArgs e)
		{
			Tbtn_NewProcess();
			this.Cmb_inNoSettingProcess();
		}

		private void cmb_inNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_inNoSelectedValueChangedProcess();
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

		//		/// <summary>
		//		/// Display_Size_ColHead : size조회
		//		/// </summary>
		//		/// <param name="arg_style">style code</param>		
		//		/// <param name="arg_width">column width</param>		
		//		/// <param name="arg_startcol">start column</param>		
		//		public  void Display_In_Size_ColHead(string arg_factory,int arg_width,int arg_startcol)
		//		{
		//			try 
		//			{
		//				DataSet    ds_size;
		//				DataTable  dt_size;	
		//
		//				MyOraDB.ReDim_Parameter(2); 
		//
		//				//01.PROCEDURE명
		//				MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SIZE_COLHEAD_REQ";
		// 
		//				//02.ARGURMENT명
		//				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
		//				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
		//
		//				//03.DATA TYPE
		//				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
		//				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
		//			 
		//				//04.DATA 정의  			
		//				MyOraDB.Parameter_Values[0] = arg_factory; 
		//				MyOraDB.Parameter_Values[1] = ""; 
		//
		//				MyOraDB.Add_Select_Parameter(true);
		// 
		//				ds_size = MyOraDB.Exe_Select_Procedure();
		//
		//				if(ds_size == null) return ;			
		//				dt_size =  ds_size.Tables[MyOraDB.Process_Name]; 
		//				
		//				_mainSheet.Columns.Count = arg_startcol + dt_size.Rows.Count ;
		//
		//				for(int i = 0; i < dt_size.Rows.Count; i++)
		//				{
		//					_mainSheet.ColumnHeader.Cells[0, arg_startcol+i].Text = dt_size.Rows[i].ItemArray[0].ToString();
		//					_mainSheet.Columns[arg_startcol+i].Width = arg_width;
		//				}
		//
		//				_mainSheet.ColumnHeader.Rows[0].Visible = true;
		//				_mainSheet.ColumnHeader.Rows[1].Visible = false;
		//			}
		//			
		//			catch (Exception ex)
		//			{
		//				MessageBox.Show(ex.Message.ToString(),"Display_Size",MessageBoxButtons.OK,MessageBoxIcon.Error);
		//			} 
		//		} 		
		

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
            //			ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Incoming In Size List";
            this.Text = "Incoming In Size List";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SBI_IN_SIZE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);

			// user define variable setting
			_mainSheet					= spd_main.ActiveSheet;
			_cmbInNoEventHandler		= new System.EventHandler(this.cmb_inNo_SelectedValueChanged);

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();

			// default search proviso
			_practicable = false;
			cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
			dpick_inYmd.Value			= ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]);
			_practicable = true;
			Cmb_inNoSettingProcess();
			cmb_inNo.SelectedValue		= COM.ComVar.Parameter_PopUp[2];

			txt_factory.Text	= cmb_factory.Text; 
			txt_inNo.Text		= cmb_inNo.Text; 

//			// Disabled tbutton
//			tbtn_Conform.Enabled	= false;
//			tbtn_Print.Enabled		= false;
//			tbtn_Create.Enabled		= false;

			this.Tbtn_SearchProcess();
		}

		private string[] GetSearchProviso()
		{
			string[] vProviso = new string[2];
			vProviso[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			vProviso[1] = dpick_inYmd.Value.ToString().Substring(0,10).Replace("-","");
			return vProviso;
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

		private void Tbtn_SearchProcess()
		{
			string vFactory		= cmb_factory.SelectedValue.ToString();
			string vInNo		= cmb_inNo.SelectedValue.ToString();
			string vStartColumnLabel = null, vEndColumnLabel = null;
			_vExistData		= false;
			
			spd_main.Display_Size_ColHead_Req(COM.ComVar.This_Factory, 40, _startCol);

			DataTable vDt = this.SELECT_SBI_IN_SIZE_LIST(vFactory, vInNo);

			if (vDt.Rows.Count > 0)
			{
				spd_main.Display_CrossTab(vDt, 0, 0, 6, _displayCol, false);

				// view point move
				for (int col = _startCol ; col < _mainSheet.Columns.Count ; col++)
				{
					for (int row = 0 ; row < _mainSheet.Rows.Count ; row++)
						if (!_mainSheet.Cells[row, col].Text.Equals(""))
						{
							_vExistData = true;
						}
					
					if (_vExistData)
					{
						spd_main.ShowColumn(0, col, FarPoint.Win.Spread.HorizontalPosition.Left);
						break;
					}
				}

				vStartColumnLabel = _mainSheet.ColumnHeader.Columns[_startCol].Label;
				vEndColumnLabel   = _mainSheet.ColumnHeader.Columns[_mainSheet.Columns.Count - 1].Label;

				_mainSheet.Cells[0, 2].Formula = "SUM(" + vStartColumnLabel + "1:" + vEndColumnLabel + "1)";

				vDt.Dispose();
				
				_mainSheet.Cells[0, _factoryCol].Value	= cmb_factory.SelectedValue.ToString();
				_mainSheet.Cells[0, _inNoCol].Value		= cmb_inNo.SelectedValue.ToString();
				_mainSheet.Cells[0, _updYmdCol].Value	= System.DateTime.Today.ToString().Replace("-","").Substring(0,8);

				if (!_vExistData)
					spd_main.Add_Row_Size(img_Action,0) ;
			}		
		}

		private void Tbtn_SaveProcess()
		{

			try
			{
				//행 수정 상태 해제 
				//				if(MyOraDB.Save_Spread("PKG_SBI_IN_SIZE.SAVE_SBI_IN_SIZE", spd_main))

				if (MyOraDB.Save_Spread_CrossTab("PKG_SBI_IN_SIZE.SAVE_SBI_IN_SIZE", spd_main, _startCol, "ARG_CS_SIZE" , "ARG_CS_QTY"))
				{
					this.Tbtn_SearchProcess();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}


		/// <summary>
		/// ReDim_Parameter : 프로시저 기동용 변수 재정의
		/// </summary>
		/// <param name="arg_count">변수 Count</param>
		public void ReDim_Parameter(int arg_count)
		{
			this.Parameter_Name = new string[arg_count]; 
			this.Parameter_Type = new int[arg_count]; 
			this.Parameter_Values = new string[arg_count] ;
		}

		private void Cmb_inNoSettingProcess()
		{
			try
			{
				if (_practicable)
				{
					cmb_inNo.SelectedValueChanged -= _cmbInNoEventHandler;

					string[] vProviso = GetSearchProviso();
					DataTable vDt = SELECT_SBI_IN_NO(vProviso[0], vProviso[1]);
					COM.ComCtl.Set_ComboList(vDt, cmb_inNo, 0, 1, true, false);
					cmb_inNo.SelectedIndex = 0;
					vDt.Dispose();

					cmb_inNo.SelectedValueChanged += _cmbInNoEventHandler;
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void Cmb_inNoSelectedValueChangedProcess()
		{
			try
			{
				Tbtn_SearchProcess();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			if (_vExistData)
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
		public DataTable SELECT_SBI_IN_SIZE_LIST(string arg_factory, string arg_in_no)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_SIZE.SELECT_SBI_IN_SIZE_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_in_no;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBI_IN_NO : 
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <returns>DataTable</returns>
		/// <summary>
		/// PKG_SBI_IN_NO : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_IN_NO(string arg_factory, string arg_in_ymd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_NO.SELECT_SBI_IN_NO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_YMD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_in_ymd;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion


	}
}
