using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;

using System.Data.SqlClient; 
using System.Data.OleDb;



namespace FlexPurchase.Purchase
{
	public class Pop_BP_Purchase_Order_Ct : COM.PCHWinForm.Pop_Medium
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cmb_obsType;
		private System.Windows.Forms.Label lbl_obsType;
		private C1.Win.C1List.C1Combo cmb_obsId;
		private System.Windows.Forms.Label lbl_obsId;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label btn_search;
		private C1.Win.C1List.C1Combo cmb_styleCd;
		private System.Windows.Forms.Label lbl_styleCd;
		private System.Windows.Forms.TextBox txt_styleCode;

		#region 사용자 정의 변수

		private FarPoint.Win.Spread.SheetView _sizeSheet = null;
		private int _startCol		= 4;
		private int _count			= 1;
		private int _displayCol		= 3;

		private int _kindCol			= (int)ClassLib.TBSBP_PURCHASE_DP_SIZE.IxKIND;
		private int _totalCol			= (int)ClassLib.TBSBP_PURCHASE_DP_SIZE.IxTOTAL;
		private OleDbDataReader reader_VEPO;


		#endregion

		private System.Windows.Forms.Panel panel1;
		private COM.FSP fgrid_VEPO;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Return;
		private System.Windows.Forms.Label btn_delete;



		private COM.OraDB MyOraDB = new COM.OraDB();

		public Pop_BP_Purchase_Order_Ct()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BP_Purchase_Order_Ct));
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
            this.fgrid_VEPO = new COM.FSP();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_styleCode = new System.Windows.Forms.TextBox();
            this.cmb_styleCd = new C1.Win.C1List.C1Combo();
            this.lbl_styleCd = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Label();
            this.cmb_obsId = new C1.Win.C1List.C1Combo();
            this.lbl_obsId = new System.Windows.Forms.Label();
            this.cmb_obsType = new C1.Win.C1List.C1Combo();
            this.lbl_obsType = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_VEPO)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_styleCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.fgrid_VEPO);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 328);
            this.c1Sizer1.TabIndex = 26;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_VEPO
            // 
            this.fgrid_VEPO.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_VEPO.ColumnInfo = "10,1,0,0,0,75,Columns:";
            this.fgrid_VEPO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_VEPO.Location = new System.Drawing.Point(8, 69);
            this.fgrid_VEPO.Name = "fgrid_VEPO";
            this.fgrid_VEPO.Size = new System.Drawing.Size(678, 212);
            this.fgrid_VEPO.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_VEPO.Styles"));
            this.fgrid_VEPO.TabIndex = 171;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_Return);
            this.panel1.Location = new System.Drawing.Point(8, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 35);
            this.panel1.TabIndex = 170;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_delete.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_delete.ImageIndex = 0;
            this.btn_delete.ImageList = this.img_Button;
            this.btn_delete.Location = new System.Drawing.Point(528, 6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(72, 24);
            this.btn_delete.TabIndex = 406;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(600, 6);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(72, 24);
            this.btn_Cancel.TabIndex = 405;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Return.ImageIndex = 0;
            this.btn_Return.ImageList = this.img_Button;
            this.btn_Return.Location = new System.Drawing.Point(456, 6);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(72, 24);
            this.btn_Return.TabIndex = 404;
            this.btn_Return.Text = "Apply";
            this.btn_Return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(8, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 65);
            this.panel2.TabIndex = 168;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_styleCode);
            this.groupBox1.Controls.Add(this.cmb_styleCd);
            this.groupBox1.Controls.Add(this.lbl_styleCd);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.cmb_obsId);
            this.groupBox1.Controls.Add(this.lbl_obsId);
            this.groupBox1.Controls.Add(this.cmb_obsType);
            this.groupBox1.Controls.Add(this.lbl_obsType);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.lbl_factory);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_styleCode
            // 
            this.txt_styleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCode.Location = new System.Drawing.Point(433, 36);
            this.txt_styleCode.MaxLength = 10;
            this.txt_styleCode.Name = "txt_styleCode";
            this.txt_styleCode.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCode.TabIndex = 190;
            this.txt_styleCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCode_KeyUp);
            // 
            // cmb_styleCd
            // 
            this.cmb_styleCd.AddItemCols = 0;
            this.cmb_styleCd.AddItemSeparator = ';';
            this.cmb_styleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_styleCd.Caption = "";
            this.cmb_styleCd.CaptionHeight = 17;
            this.cmb_styleCd.CaptionStyle = style1;
            this.cmb_styleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_styleCd.ColumnCaptionHeight = 18;
            this.cmb_styleCd.ColumnFooterHeight = 18;
            this.cmb_styleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_styleCd.ContentHeight = 16;
            this.cmb_styleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_styleCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_styleCd.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_styleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_styleCd.EditorHeight = 16;
            this.cmb_styleCd.EvenRowStyle = style2;
            this.cmb_styleCd.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_styleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_styleCd.FooterStyle = style3;
            this.cmb_styleCd.GapHeight = 2;
            this.cmb_styleCd.HeadingStyle = style4;
            this.cmb_styleCd.HighLightRowStyle = style5;
            this.cmb_styleCd.ItemHeight = 15;
            this.cmb_styleCd.Location = new System.Drawing.Point(513, 36);
            this.cmb_styleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_styleCd.MaxDropDownItems = ((short)(5));
            this.cmb_styleCd.MaxLength = 32767;
            this.cmb_styleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_styleCd.Name = "cmb_styleCd";
            this.cmb_styleCd.OddRowStyle = style6;
            this.cmb_styleCd.PartialRightColumn = false;
            this.cmb_styleCd.PropBag = resources.GetString("cmb_styleCd.PropBag");
            this.cmb_styleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_styleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_styleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_styleCd.SelectedStyle = style7;
            this.cmb_styleCd.Size = new System.Drawing.Size(140, 20);
            this.cmb_styleCd.Style = style8;
            this.cmb_styleCd.TabIndex = 188;
            this.cmb_styleCd.SelectedValueChanged += new System.EventHandler(this.cmb_styleCd_SelectedValueChanged);
            // 
            // lbl_styleCd
            // 
            this.lbl_styleCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_styleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_styleCd.ImageIndex = 0;
            this.lbl_styleCd.ImageList = this.img_Label;
            this.lbl_styleCd.Location = new System.Drawing.Point(332, 36);
            this.lbl_styleCd.Name = "lbl_styleCd";
            this.lbl_styleCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_styleCd.TabIndex = 189;
            this.lbl_styleCd.Text = "Style Cd";
            this.lbl_styleCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(653, 36);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 21);
            this.btn_search.TabIndex = 187;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cmb_obsId
            // 
            this.cmb_obsId.AddItemCols = 0;
            this.cmb_obsId.AddItemSeparator = ';';
            this.cmb_obsId.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_obsId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_obsId.Caption = "";
            this.cmb_obsId.CaptionHeight = 17;
            this.cmb_obsId.CaptionStyle = style9;
            this.cmb_obsId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_obsId.ColumnCaptionHeight = 18;
            this.cmb_obsId.ColumnFooterHeight = 18;
            this.cmb_obsId.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_obsId.ContentHeight = 16;
            this.cmb_obsId.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_obsId.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_obsId.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_obsId.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_obsId.EditorHeight = 16;
            this.cmb_obsId.EvenRowStyle = style10;
            this.cmb_obsId.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_obsId.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obsId.FooterStyle = style11;
            this.cmb_obsId.GapHeight = 2;
            this.cmb_obsId.HeadingStyle = style12;
            this.cmb_obsId.HighLightRowStyle = style13;
            this.cmb_obsId.ItemHeight = 15;
            this.cmb_obsId.Location = new System.Drawing.Point(107, 36);
            this.cmb_obsId.MatchEntryTimeout = ((long)(2000));
            this.cmb_obsId.MaxDropDownItems = ((short)(5));
            this.cmb_obsId.MaxLength = 32767;
            this.cmb_obsId.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_obsId.Name = "cmb_obsId";
            this.cmb_obsId.OddRowStyle = style14;
            this.cmb_obsId.PartialRightColumn = false;
            this.cmb_obsId.PropBag = resources.GetString("cmb_obsId.PropBag");
            this.cmb_obsId.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_obsId.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_obsId.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_obsId.SelectedStyle = style15;
            this.cmb_obsId.Size = new System.Drawing.Size(220, 20);
            this.cmb_obsId.Style = style16;
            this.cmb_obsId.TabIndex = 185;
            // 
            // lbl_obsId
            // 
            this.lbl_obsId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_obsId.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obsId.ImageIndex = 0;
            this.lbl_obsId.ImageList = this.img_Label;
            this.lbl_obsId.Location = new System.Drawing.Point(6, 36);
            this.lbl_obsId.Name = "lbl_obsId";
            this.lbl_obsId.Size = new System.Drawing.Size(100, 21);
            this.lbl_obsId.TabIndex = 186;
            this.lbl_obsId.Text = "OBS ID";
            this.lbl_obsId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmb_obsType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obsType.FooterStyle = style19;
            this.cmb_obsType.GapHeight = 2;
            this.cmb_obsType.HeadingStyle = style20;
            this.cmb_obsType.HighLightRowStyle = style21;
            this.cmb_obsType.ItemHeight = 15;
            this.cmb_obsType.Location = new System.Drawing.Point(433, 14);
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
            this.cmb_obsType.Size = new System.Drawing.Size(220, 20);
            this.cmb_obsType.Style = style24;
            this.cmb_obsType.TabIndex = 183;
            this.cmb_obsType.SelectedValueChanged += new System.EventHandler(this.cmb_obsType_SelectedValueChanged);
            // 
            // lbl_obsType
            // 
            this.lbl_obsType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obsType.ImageIndex = 0;
            this.lbl_obsType.ImageList = this.img_Label;
            this.lbl_obsType.Location = new System.Drawing.Point(332, 14);
            this.lbl_obsType.Name = "lbl_obsType";
            this.lbl_obsType.Size = new System.Drawing.Size(100, 21);
            this.lbl_obsType.TabIndex = 184;
            this.lbl_obsType.Text = "OBS Type";
            this.lbl_obsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
            this.cmb_factory.EvenRowStyle = style26;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style27;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style28;
            this.cmb_factory.HighLightRowStyle = style29;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(107, 14);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style30;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style31;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style32;
            this.cmb_factory.TabIndex = 181;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(6, 14);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 182;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_BP_Purchase_Order_Ct
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 368);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BP_Purchase_Order_Ct";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_VEPO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_styleCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{
//			this.Grid_EditModeOnProcess(spd_main) ;
		}		

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
//			this.spd_main.Update_Row(img_Action);
		}

		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
//			if (!e.ColumnHeader)
//				this.Grid_CellClickProcess(e.Row, e.Column);
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

		private void txt_styleCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				this.Txt_StyleCdKeyUpProcess();
		}

		private void btn_nextStep_Click(object sender, System.EventArgs e)
		{
			this.Btn_NextStepProcess();
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

		private void btn_click_Effect_Plus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_click_Effect_Minus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;		
		}

		#endregion

		#endregion

		#region 공통 메서드

		private void Btn_NextStepProcess()
		{
			if( _sizeSheet.Cells[3, 2].Text == "")
				return;

			Pop_BP_Purchase_Order_Tree pop_bp_order_tree     = new Pop_BP_Purchase_Order_Tree();
			
			COM.ComVar.Parameter_PopUp		= new string[4];

			COM.ComVar.Parameter_PopUp[0]	= cmb_factory.SelectedValue.ToString();
			COM.ComVar.Parameter_PopUp[1]	= cmb_obsType.SelectedValue.ToString();
			COM.ComVar.Parameter_PopUp[2]	= cmb_obsId.Text.ToString();
			COM.ComVar.Parameter_PopUp[3]	= cmb_styleCd.SelectedValue.ToString().Replace("-","");


			ClassLib.ComVar.Parameter_PopUpTable2.Reset();

			DataColumn[] dc= new DataColumn[_sizeSheet.Columns.Count];

			for(int i = _startCol ; i < _sizeSheet.Columns.Count ; i++)
			{
				dc[i - _startCol] = new DataColumn("",Type.GetType("System.String"));
			}
				
			ClassLib.ComVar.Parameter_PopUpTable2.Columns.AddRange(dc);
            			
			DataRow newRow   =  ClassLib.ComVar.Parameter_PopUpTable2.NewRow();
			DataRow newRow2  =  ClassLib.ComVar.Parameter_PopUpTable2.NewRow();
			for( int i = _startCol ; i < _sizeSheet.Columns.Count ; i++)
			{
				newRow[i-_startCol ]  = _sizeSheet.ColumnHeader.Cells[0, i].Text;
				newRow2[i-_startCol ] = _sizeSheet.Cells[3, i].Text.ToString();
			}
			ClassLib.ComVar.Parameter_PopUpTable2.Rows.Add(newRow);
			ClassLib.ComVar.Parameter_PopUpTable2.Rows.Add(newRow2);
			

			pop_bp_order_tree.ShowDialog();
			
			if(ClassLib.ComVar.Parameter_PopUpTable2.Rows.Count > 0 )
				this.Close();
			

			pop_bp_order_tree.Dispose();
		}

		private void SearchSizeInfo()
		{
			string[] vData   = new string[4];
			
			vData[0] = cmb_factory.SelectedValue.ToString();
			vData[1] = cmb_obsType.SelectedValue.ToString();
			vData[2] = cmb_obsId.Text.ToString();
			vData[3] = "";

			DataTable vDt = SELECT_SEM_OBS_MERCURY(vData);

			if (vDt.Rows.Count > 0)
			{
				string vMinDoc = vDt.Rows[0][0].ToString();
				string vMaxDoc = vDt.Rows[0][1].ToString();
				string vStyleCd = this.cmb_styleCd.SelectedValue.ToString();

//				string strSql_VEPO = " SELECT VEKP.FFS_CRTN_TYP TYP, COUNT(VEKP.FFS_CRTN_TYP) QTY" + 
//					"       FROM  VEPO, VEKP" +
//					"      WHERE EBELN  IN" +
//					"			(SELECT DISTINCT EBELN" +
//					"			   FROM EKKO" +
//					"			  WHERE BEDAT  BETWEEN '" + vMinDoc + "' AND '" + vMaxDoc + "')"+
//					"		 AND VEPO.VENUM = VEKP.VENUM"+
//					"	   GROUP BY VEKP.FFS_CRTN_TYP"+
//					"	   ORDER BY VEKP.FFS_CRTN_TYP";

				string strSql_VEPO = 	"SELECT A.EBELN, A.EBELP, B.STYLE_CD, B.ORDER_QTY, A.CRTN_TYPE, A.CRTN_QTY				"+
					"  FROM																										"+
					"  (SELECT VEPO.EBELN, VEPO.EBELP, VEKP.FFS_CRTN_TYP AS CRTN_TYPE , COUNT(VEKP.FFS_CRTN_TYP) AS CRTN_QTY    "+
					"   FROM VEPO, VEKP																							"+
					"   WHERE VEPO.VENUM = VEKP.VENUM																			"+
					"   AND EBELN  IN																							"+
					"   			(SELECT DISTINCT EKKO.EBELN																	"+
					"   				FROM EKKO																				"+
					"   				WHERE EKKO.BEDAT  BETWEEN '" + vMinDoc + "' AND '" + vMaxDoc + "'						"+
					"   				AND BUY_GRP_CD  ='01'																	"+
					"   				)																						"+
					"   GROUP BY VEPO.EBELN, VEPO.EBELP, VEKP.FFS_CRTN_TYP) A,													"+
					"   (SELECT EKPO.EBELN, EKPO.EBELP, EKPO.MATNR AS STYLE_CD, EKPO.MENGE AS ORDER_QTY							"+
					"   FROM EKKO , EKPO																						"+
					"   WHERE EKKO.BEDAT  BETWEEN '" + vMinDoc + "' AND '" + vMaxDoc + "'										"+
					"   AND EKPO.MATNR = '" + vStyleCd	+ "'																	"+
					"   AND EKKO.BUY_GRP_CD  ='01'																				"+
					"   AND EKKO.EBELN  = EKPO.EBELN) B																			"+
					"   WHERE A.EBELN  = B.EBELN																				"+
					"     AND A.EBELP  = B.EBELP																				";

				DataTable dt_list = ClassLib.ComVar.Select_ComCode("QD", ClassLib.ComVar.CxSQL);

				reader_VEPO = ClassLib.ComFunction.Read_MSSQL(strSql_VEPO, 
					dt_list.Rows[0].ItemArray[1].ToString(), 
					dt_list.Rows[0].ItemArray[3].ToString(), 
					dt_list.Rows[0].ItemArray[5].ToString());

//					"119.119.119.13","qdsystem","changshin");



				string[] str_d = new string[reader_VEPO.FieldCount];			
				while (reader_VEPO.Read())
				{
					for(int i=0; i<reader_VEPO.FieldCount; i++)				
						str_d[i] = ClassLib.ComFunction.Convert_dtType(reader_VEPO[i].GetType().Name.ToString(), reader_VEPO[i].ToString());

					fgrid_VEPO.AddItem(str_d, fgrid_VEPO.Rows.Count, 1);
					str_d.Initialize();							
				}
//				fgrid_VEPO.AutoSizeCols();
				fgrid_VEPO.Cols[0].Width = 20;
				fgrid_VEPO.Cols[1].Width = 50;
				fgrid_VEPO.Cols[2].Width = 100;
			}		
		}

		/// <summary>
		/// Return_Item_Data : Return Data
		/// </summary>
		private void Return_Item_Data()
		{
			try
			{
				if(fgrid_VEPO.Rows.Count <= 0 ) return;

				DataTable vDt =  SELECT_SBC_ITEM_CT();

				if (vDt.Rows.Count > 0 )
				{
					ClassLib.ComVar.Parameter_PopUpTable.Reset();
					ClassLib.ComVar.Parameter_PopUpTable.Columns.Clear();

					DataColumn[] dc= new DataColumn[5];

					dc[0] = new DataColumn("item_cd",Type.GetType("System.String"));
					dc[1] = new DataColumn("group_cd",Type.GetType("System.String"));
					dc[2] = new DataColumn("item_name1",Type.GetType("System.String"));
					dc[3] = new DataColumn("remark",Type.GetType("System.String"));
					dc[4] = new DataColumn("qty",Type.GetType("System.String"));

					ClassLib.ComVar.Parameter_PopUpTable.Columns.AddRange(dc);
					// 세팅하기
					for(int i = 2 ; i < fgrid_VEPO.Rows.Count ; i++)
					{
						string vType = fgrid_VEPO.Rows[i][1].ToString();

						for( int j = 0 ; j < vDt.Rows.Count ; j++)
						{
//							if("CORPORATE-"+vType == vDt.Rows[j][2].ToString())
							if(vDt.Rows[j][2].ToString().IndexOf(vType,0) > 0)
							{
								// 값 넣기
								DataRow newRow =  ClassLib.ComVar.Parameter_PopUpTable.NewRow();

								newRow[0] = vDt.Rows[j][0].ToString();	// item_cd
								newRow[1] = vDt.Rows[j][1].ToString();	// group_cd
								newRow[2] = vDt.Rows[j][2].ToString();	// item_nm1
								newRow[3] = vType;    // mercury's box name
								newRow[4] = fgrid_VEPO.Rows[i][2].ToString(); // qty
								
								ClassLib.ComVar.Parameter_PopUpTable.Rows.Add(newRow);
								break;
							}
							
							if(j == vDt.Rows.Count -1)
							{
								DataRow newRow =  ClassLib.ComVar.Parameter_PopUpTable.NewRow();

								newRow[0] = "";	// item_cd
								newRow[1] = "";	// group_cd
								newRow[2] = "";	// item_nm1
								newRow[3] = vType;    // mercury's box name
								newRow[4] = fgrid_VEPO.Rows[i][2].ToString(); // qty
								
								ClassLib.ComVar.Parameter_PopUpTable.Rows.Add(newRow);
								break;
							}
						}
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Pop_Purchase_Order_Ct", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		
			
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
            lbl_MainTitle.Text = "Carton Infomation";
            this.Text = "Carton Infomation";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			fgrid_VEPO.Set_Grid( "SEM_VEPO", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);  

			///Factory
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			///OBS_Type
			vDt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxOBS_Type);
			ClassLib.ComCtl.Set_ComboList(vDt, cmb_obsType, 1, 2, false);  			
			cmb_obsType.SelectedIndex = 0;

			Txt_StyleCdKeyUpProcess();

			vDt.Dispose();



			// default search proviso

			// user define variable setting
//			_sizeSheet				= spd_size.ActiveSheet;
//			_mainSheet = spd_main.Sheets[0];
		}

		private void Btn_SearchClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string vFactory		= cmb_factory.SelectedValue.ToString();
				string vObsType		= cmb_obsType.SelectedValue.ToString();
				string vObsId		= cmb_obsId.Text.ToString();

				if (cmb_factory.SelectedValue == null)	return;

				this.Cursor = Cursors.WaitCursor;

				if (!cmb_factory.SelectedValue.ToString().Equals(" "))
				{
					this.SearchSizeInfo();
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

		
		private void Grid_DoubleClickProcess(int arg_row)
		{
//			int vRow			= arg_row;
//			int vReqYmd		    = (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxREQ_YMD;
//			int vReqNo			= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxREQ_NO;
//			int vReqUse			= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxREQ_USER;
//			int vReqDept		= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxREQ_DEPT;
//			int vUseDept		= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxUSE_DEPT;
//			int vReqReason		= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxREQ_REASON;
//			int vRtaYmd			= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxRTA_YMD;
//			int vEstYmd			= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxEST_YMD;
//			int vStatus			= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxSTATUS;
//			int vOfferYn		= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxOFFER_YN;
//			int vOfferNo		= (int)ClassLib.TBSBP_REQ_HEAD_LIST.IxOFFER_NO;
//
//			COM.ComVar.Parameter_PopUp		= new string[12];
//
//			COM.ComVar.Parameter_PopUp[0]	= cmb_factory.SelectedValue.ToString();
//			COM.ComVar.Parameter_PopUp[1]	= _mainSheet.Cells[vRow, vReqNo].Text;
//			COM.ComVar.Parameter_PopUp[2]	= _mainSheet.Cells[vRow, vReqYmd].Text;
//			COM.ComVar.Parameter_PopUp[3]	= _mainSheet.Cells[vRow, vReqUse].Text;
//			COM.ComVar.Parameter_PopUp[4]	= _mainSheet.Cells[vRow, vReqDept].Text;
//			COM.ComVar.Parameter_PopUp[5]	= _mainSheet.Cells[vRow, vUseDept].Text;
//			COM.ComVar.Parameter_PopUp[6]	= _mainSheet.Cells[vRow, vReqReason].Text;
//			COM.ComVar.Parameter_PopUp[7]	= _mainSheet.Cells[vRow, vRtaYmd].Text;
//			COM.ComVar.Parameter_PopUp[8]	= _mainSheet.Cells[vRow, vEstYmd].Text;
//			COM.ComVar.Parameter_PopUp[9]	= _mainSheet.Cells[vRow, vStatus].Text;
//			COM.ComVar.Parameter_PopUp[10]	= _mainSheet.Cells[vRow, vOfferYn].Text;
//			COM.ComVar.Parameter_PopUp[11]	= _mainSheet.Cells[vRow, vOfferNo].Text;
//
//			this.DialogResult = DialogResult.OK;
//			this.Close();
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

		private void cmb_obsType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			cmb_obsId.ClearItems();

			ClassLib.ComFunction.Set_OBSID_CmbList(cmb_obsType.SelectedValue.ToString(), cmb_obsId);
		}

			

		private void Txt_StyleCdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCode, " "));
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(vDt, cmb_styleCd, 0, 1, 2, 3, 4, false, 100, 221); 

				if(vDt.Rows.Count == 1 )
					cmb_styleCd.SelectedIndex = 0;
				else if( vDt.Rows.Count == 0)
				{
					fgrid_VEPO.Set_Grid( "SEM_VEPO", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);
					fgrid_VEPO.Set_Action_Image(img_Action,true);
				}

				vDt.Dispose();
			}
			catch (Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs_StyleCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}

		

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBS_SHIPPING_SIZE : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_obs_type">선적번호(실제)</param>
		/// <param name="arg_obs_id">스타일코드</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SEM_OBS_MERCURY(string[] arg_data)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SEM_OBS.SELECT_SEM_OBS_MERCURY";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			for (int i = 0 ; i < arg_data.Length ; i++)
				MyOraDB.Parameter_Values[i] = arg_data[i];

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

//		PKG_SEM_BP.SELECT_SEM_DP_SIZE
		/// <summary>
		/// PKG_SEM_BP : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_style_cd">스타일코드</param>
		/// <param name="arg_qty">요청수량</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SEM_DP_SIZE(string[] arg_data)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SEM_BP.SELECT_SEM_DP_SIZE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			for (int i = 0 ; i < arg_data.Length ; i++)
				MyOraDB.Parameter_Values[i] = arg_data[i];

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBT_TEMP_ITEM :  SELECT_SBT_TEMP_ITEM
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_req_no">청구번호</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBC_ITEM_CT()
		{
			// SELECT_SBS_SHIPPING_SIZE_LIST 참고
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(1);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_ITEM.SELECT_SBC_ITEM_CT";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion	

		private void btn_Return_Click(object sender, System.EventArgs e)
		{
			Return_Item_Data();
			this.Close();
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			ClassLib.ComVar.Parameter_PopUpTable.Reset();
			ClassLib.ComVar.Parameter_PopUpTable.Dispose();
			this.Close();
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			//spd_main.Sheets[0].Rows[spd_main.ActiveSheet.GetSelection(0).Row].Remove();
			fgrid_VEPO.RemoveItem(fgrid_VEPO.Selection.r2);
//			fgrid_VEPO.Rows[fgrid_VEPO.Rows.Selected.Remove()]
		}

		private void cmb_styleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			txt_styleCode.Text = cmb_styleCd.SelectedValue.ToString();
			Btn_SearchClickProcess();
		}

		

				
	}
}

