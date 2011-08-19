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



namespace FlexPurchase.Purchase
{
	public class Pop_BP_Request_Size : COM.PCHWinForm.Pop_Medium
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private C1.Win.C1List.C1Combo cmb_factory;
        private System.Windows.Forms.Label lbl_factory;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label btn_search;
		private COM.SSP spd_size;
		private FarPoint.Win.Spread.SheetView spd_size_Sheet1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Label lbl_type;
		private System.Windows.Forms.TextBox txt_styleCd;
		private C1.Win.C1List.C1Combo cmb_style;
		private C1.Win.C1List.C1Combo cmb_type;
		private C1.Win.C1List.C1Combo cmb_id;
		private System.Windows.Forms.Label lbl_Id;
		private System.Windows.Forms.Label lbl_style;

		#region 사용자 정의 변수

		private FarPoint.Win.Spread.SheetView _sizeSheet = null;

        private string _obsId = "", _obsType = "", _stylecd ="",  _poId = "", _factory = "";
		private System.Windows.Forms.Label lbl_qty;
		private System.Windows.Forms.TextBox txt_qty;
		private System.Windows.Forms.TextBox txt_newQty;
        private C1.Win.C1List.C1Combo cmb_obsType;
        private Label lbl_obsType;

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion

		public Pop_BP_Request_Size()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

        public Pop_BP_Request_Size(string arg_factory, string arg_po_type, string arg_poid, string arg_stylecd)
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();
            _factory = arg_factory;
            _obsId  = arg_poid;
            _obsType = arg_po_type;
            _stylecd = arg_stylecd;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BP_Request_Size));
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
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.spd_size = new COM.SSP();
            this.spd_size_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.lbl_style = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Label();
            this.cmb_id = new C1.Win.C1List.C1Combo();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.cmb_type = new C1.Win.C1List.C1Combo();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_newQty = new System.Windows.Forms.TextBox();
            this.cmb_obsType = new C1.Win.C1List.C1Combo();
            this.lbl_obsType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_size_Sheet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).BeginInit();
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
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.spd_size);
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.GridDefinition = "44.2708333333333:False:True;31.7708333333333:False:True;15.625:False:False;2.0833" +
                "3333333333:False:True;\t0.576368876080692:False:True;97.6945244956772:False:False" +
                ";0.576368876080692:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 192);
            this.c1Sizer1.TabIndex = 26;
            this.c1Sizer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_apply);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Location = new System.Drawing.Point(8, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 30);
            this.panel1.TabIndex = 170;
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(536, 3);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 403;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseDown);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseUp);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(608, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 403;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseDown);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseUp);
            // 
            // spd_size
            // 
            this.spd_size.Location = new System.Drawing.Point(8, 89);
            this.spd_size.Name = "spd_size";
            this.spd_size.Sheets.Add(this.spd_size_Sheet1);
            this.spd_size.Size = new System.Drawing.Size(678, 61);
            this.spd_size.TabIndex = 169;
            // 
            // spd_size_Sheet1
            // 
            this.spd_size_Sheet1.SheetName = "Sheet1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(8, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 85);
            this.panel2.TabIndex = 168;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmb_obsType);
            this.groupBox1.Controls.Add(this.lbl_obsType);
            this.groupBox1.Controls.Add(this.lbl_qty);
            this.groupBox1.Controls.Add(this.txt_styleCd);
            this.groupBox1.Controls.Add(this.lbl_style);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.cmb_id);
            this.groupBox1.Controls.Add(this.lbl_Id);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.lbl_factory);
            this.groupBox1.Controls.Add(this.lbl_type);
            this.groupBox1.Controls.Add(this.cmb_type);
            this.groupBox1.Controls.Add(this.cmb_style);
            this.groupBox1.Controls.Add(this.txt_qty);
            this.groupBox1.Controls.Add(this.txt_newQty);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_qty
            // 
            this.lbl_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_qty.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.ImageIndex = 0;
            this.lbl_qty.ImageList = this.img_Label;
            this.lbl_qty.Location = new System.Drawing.Point(329, 58);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(100, 21);
            this.lbl_qty.TabIndex = 184;
            this.lbl_qty.Text = "Qty";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCd.Location = new System.Drawing.Point(107, 58);
            this.txt_styleCd.MaxLength = 10;
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCd.TabIndex = 190;
            this.txt_styleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCd_KeyUp);
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(6, 58);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 189;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.ImageIndex = 3;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(629, 58);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(21, 21);
            this.btn_search.TabIndex = 187;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseDown);
            this.btn_search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseUp);
            // 
            // cmb_id
            // 
            this.cmb_id.AddItemSeparator = ';';
            this.cmb_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_id.Caption = "";
            this.cmb_id.CaptionHeight = 17;
            this.cmb_id.CaptionStyle = style9;
            this.cmb_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_id.ColumnCaptionHeight = 18;
            this.cmb_id.ColumnFooterHeight = 18;
            this.cmb_id.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_id.ContentHeight = 16;
            this.cmb_id.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_id.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_id.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_id.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_id.EditorHeight = 16;
            this.cmb_id.EvenRowStyle = style10;
            this.cmb_id.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_id.FooterStyle = style11;
            this.cmb_id.HeadingStyle = style12;
            this.cmb_id.HighLightRowStyle = style13;
            this.cmb_id.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_id.Images"))));
            this.cmb_id.ItemHeight = 15;
            this.cmb_id.Location = new System.Drawing.Point(430, 37);
            this.cmb_id.MatchEntryTimeout = ((long)(2000));
            this.cmb_id.MaxDropDownItems = ((short)(5));
            this.cmb_id.MaxLength = 32767;
            this.cmb_id.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.OddRowStyle = style14;
            this.cmb_id.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_id.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_id.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_id.SelectedStyle = style15;
            this.cmb_id.Size = new System.Drawing.Size(220, 20);
            this.cmb_id.Style = style16;
            this.cmb_id.TabIndex = 185;
            this.cmb_id.SelectedValueChanged += new System.EventHandler(this.cmb_id_SelectedValueChanged);
            this.cmb_id.PropBag = resources.GetString("cmb_id.PropBag");
            // 
            // lbl_Id
            // 
            this.lbl_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Id.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ImageIndex = 0;
            this.lbl_Id.ImageList = this.img_Label;
            this.lbl_Id.Location = new System.Drawing.Point(329, 37);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(100, 21);
            this.lbl_Id.TabIndex = 186;
            this.lbl_Id.Text = "Order ID";
            this.lbl_Id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
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
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style19;
            this.cmb_factory.HeadingStyle = style20;
            this.cmb_factory.HighLightRowStyle = style21;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(107, 14);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style22;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style23;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style24;
            this.cmb_factory.TabIndex = 181;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
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
            // lbl_type
            // 
            this.lbl_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ImageIndex = 0;
            this.lbl_type.ImageList = this.img_Label;
            this.lbl_type.Location = new System.Drawing.Point(329, 14);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(100, 21);
            this.lbl_type.TabIndex = 184;
            this.lbl_type.Text = "Type";
            this.lbl_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_type
            // 
            this.cmb_type.AddItemSeparator = ';';
            this.cmb_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_type.Caption = "";
            this.cmb_type.CaptionHeight = 17;
            this.cmb_type.CaptionStyle = style25;
            this.cmb_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_type.ColumnCaptionHeight = 18;
            this.cmb_type.ColumnFooterHeight = 18;
            this.cmb_type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_type.ContentHeight = 16;
            this.cmb_type.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_type.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_type.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_type.EditorHeight = 16;
            this.cmb_type.EvenRowStyle = style26;
            this.cmb_type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_type.FooterStyle = style27;
            this.cmb_type.HeadingStyle = style28;
            this.cmb_type.HighLightRowStyle = style29;
            this.cmb_type.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_type.Images"))));
            this.cmb_type.ItemHeight = 15;
            this.cmb_type.Location = new System.Drawing.Point(430, 14);
            this.cmb_type.MatchEntryTimeout = ((long)(2000));
            this.cmb_type.MaxDropDownItems = ((short)(5));
            this.cmb_type.MaxLength = 32767;
            this.cmb_type.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.OddRowStyle = style30;
            this.cmb_type.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_type.SelectedStyle = style31;
            this.cmb_type.Size = new System.Drawing.Size(220, 20);
            this.cmb_type.Style = style32;
            this.cmb_type.TabIndex = 183;
            this.cmb_type.SelectedValueChanged += new System.EventHandler(this.cmb_type_SelectedValueChanged);
            this.cmb_type.PropBag = resources.GetString("cmb_type.PropBag");
            // 
            // cmb_style
            // 
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style33;
            this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_style.ColumnCaptionHeight = 18;
            this.cmb_style.ColumnFooterHeight = 18;
            this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_style.ContentHeight = 16;
            this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_style.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_style.EditorHeight = 16;
            this.cmb_style.EvenRowStyle = style34;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style35;
            this.cmb_style.HeadingStyle = style36;
            this.cmb_style.HighLightRowStyle = style37;
            this.cmb_style.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_style.Images"))));
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(187, 58);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style38;
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style39;
            this.cmb_style.Size = new System.Drawing.Size(140, 20);
            this.cmb_style.Style = style40;
            this.cmb_style.TabIndex = 185;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            // 
            // txt_qty
            // 
            this.txt_qty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_qty.Location = new System.Drawing.Point(430, 58);
            this.txt_qty.MaxLength = 10;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.ReadOnly = true;
            this.txt_qty.Size = new System.Drawing.Size(98, 21);
            this.txt_qty.TabIndex = 190;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_newQty
            // 
            this.txt_newQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newQty.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_newQty.Location = new System.Drawing.Point(529, 58);
            this.txt_newQty.MaxLength = 10;
            this.txt_newQty.Name = "txt_newQty";
            this.txt_newQty.Size = new System.Drawing.Size(99, 21);
            this.txt_newQty.TabIndex = 190;
            this.txt_newQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_newQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_newQty_KeyUp);
            // 
            // cmb_obsType
            // 
            this.cmb_obsType.AddItemSeparator = ';';
            this.cmb_obsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_obsType.Caption = "";
            this.cmb_obsType.CaptionHeight = 17;
            this.cmb_obsType.CaptionStyle = style1;
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
            this.cmb_obsType.EvenRowStyle = style2;
            this.cmb_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obsType.FooterStyle = style3;
            this.cmb_obsType.HeadingStyle = style4;
            this.cmb_obsType.HighLightRowStyle = style5;
            this.cmb_obsType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_obsType.Images"))));
            this.cmb_obsType.ItemHeight = 15;
            this.cmb_obsType.Location = new System.Drawing.Point(106, 36);
            this.cmb_obsType.MatchEntryTimeout = ((long)(2000));
            this.cmb_obsType.MaxDropDownItems = ((short)(5));
            this.cmb_obsType.MaxLength = 32767;
            this.cmb_obsType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_obsType.Name = "cmb_obsType";
            this.cmb_obsType.OddRowStyle = style6;
            this.cmb_obsType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_obsType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_obsType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_obsType.SelectedStyle = style7;
            this.cmb_obsType.Size = new System.Drawing.Size(220, 20);
            this.cmb_obsType.Style = style8;
            this.cmb_obsType.TabIndex = 191;
            this.cmb_obsType.TextChanged += new System.EventHandler(this.cmb_obsType_TextChanged);
            this.cmb_obsType.PropBag = resources.GetString("cmb_obsType.PropBag");
            // 
            // lbl_obsType
            // 
            this.lbl_obsType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obsType.ImageIndex = 0;
            this.lbl_obsType.ImageList = this.img_Label;
            this.lbl_obsType.Location = new System.Drawing.Point(5, 36);
            this.lbl_obsType.Name = "lbl_obsType";
            this.lbl_obsType.Size = new System.Drawing.Size(100, 21);
            this.lbl_obsType.TabIndex = 192;
            this.lbl_obsType.Text = "Order Type";
            this.lbl_obsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_BP_Request_Size
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 231);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BP_Request_Size";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_size_Sheet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

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

		private void txt_styleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				this.Txt_StyleCdKeyUpProcess();
		}

		private void cmb_style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_StyleSelectedValueChangedProcess();
			this.Btn_SearchClickProcess();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			try
			{
				string[] vList = new string[_sizeSheet.ColumnCount + 3];

				int i = 1;

				for ( ; i < _sizeSheet.ColumnCount ; i++)
				{
					vList[i - 1] = ClassLib.ComFunction.NullToBlank(_sizeSheet.Cells[0, i].Text);
				}

				int vEtcIndex = i - 1;

				vList[vEtcIndex] = _obsId;
				vList[vEtcIndex + 1] = _obsType;
				vList[vEtcIndex + 2] = COM.ComFunction.Empty_Combo(cmb_style, "");
				vList[vEtcIndex + 3] = _poId;

				ClassLib.ComVar.Parameter_PopUp = vList;

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
                ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Abort;
			this.Close();
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_IDSetting();
		}

		private void cmb_type_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_IDSetting();
		}

		private void cmb_id_SelectedValueChanged(object sender, System.EventArgs e)
		{

			spd_size.ClearAll();
			_sizeSheet.Rows.Count = 1;
 
			txt_styleCd.Text = "";
			cmb_style.SelectedIndex = -1;


			if(cmb_id.SelectedIndex == -1) return; 

			//---------------------------------------------------------------
			// STYLE_CD 할당
			//--------------------------------------------------------------- 
			Txt_StyleCdKeyUpProcess(); 
			//--------------------------------------------------------------- 

			this.Btn_SearchClickProcess();


		}

		private void txt_newQty_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				if (!txt_newQty.Text.Trim().Equals(""))
				{
					SizeAutoCalculation();
				}
			}
		}

		#region 입력이동

		#endregion

		#region 버튼효과

		private void btn_search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 2;
		}

		private void btn_search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 3;
		}

		private void btn_apply_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_apply_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
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
			try
			{
				// Form Setting
                ClassLib.ComFunction.Init_Form_Control(this);
				lbl_MainTitle.Text = "Size Information";
                this.Text = "Size Information";
                ClassLib.ComFunction.SetLangDic(this);

				// Grid Setting
				spd_size.Set_Spread_Comm("SBP_REQUEST_SIZE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);

				// user define variable setting
				_sizeSheet				= spd_size.ActiveSheet;
				_sizeSheet.Rows.Count	= 1;
				_sizeSheet.FrozenColumnCount = 1;

				// Factory
				DataTable vDt = null;
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
				cmb_factory.SelectedValue = ClassLib.ComVar.Parameter_PopUp[0];

                // OBS_Type
                vDt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxOBS_Type);
                ClassLib.ComCtl.Set_ComboList(vDt, cmb_obsType, 1, 2, false);
                cmb_obsType.SelectedValue = _obsType;

               

				// type
				vDt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, "SBP10");
				ClassLib.ComCtl.Set_ComboList(vDt, cmb_type, 1, 2, false);
				cmb_type.SelectedIndex = 0;

				if (ClassLib.ComVar.Parameter_PopUp.Length != 1 && !ClassLib.ComVar.Parameter_PopUp[1].Equals(""))
				{
                    txt_styleCd.Text = ClassLib.ComVar.Parameter_PopUp[1];
                    Txt_StyleCdKeyUpProcess();
                    cmb_style.SelectedValue = _stylecd;

                    
				}

                cmb_id.SelectedValue = _obsId;  //ClassLib.ComVar.Parameter_PopUp[3];


				spd_size.Display_Size_ColHead(COM.ComVar.This_Factory, "", 50, 1);

				vDt.Dispose();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Btn_SearchClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

                
 
				DataTable vDt = SELECT_SIZE_DATA();

				if (vDt != null && vDt.Rows.Count > 0)
				{
					int vCol = 0, vTotal = 0;;
					string vColumnData = "", vHead = "", vData = "";

					for (int i = 0 ; i < _sizeSheet.ColumnCount ; i++)
					{
						if (i < 10)
							vColumnData += "0";

						vColumnData += i + "[" + _sizeSheet.ColumnHeader.Cells[0, i].Text + "]";
					}

					if (vColumnData.Equals(""))
						new Exception("Not Found Size Label Data");

					for (int vCount = 0 ; vCount < vDt.Rows.Count ; vCount++)
					{
						vHead = "[" + vDt.Rows[vCount].ItemArray[0].ToString() + "]";
						vData = vDt.Rows[vCount].ItemArray[1].ToString();
					
						vCol = Convert.ToInt32(vColumnData.Substring(vColumnData.IndexOf(vHead) - 2, 2));
						_sizeSheet.Cells[0, vCol].Text = vData;
						_sizeSheet.Cells[0, vCol].Tag = NullToZero(vData);

						vTotal += Convert.ToInt32(ClassLib.ComFunction.NullCheck(vData,"0"));
					}

                    _obsId	 = vDt.Rows[0].ItemArray[2].ToString();
					_obsType = vDt.Rows[0].ItemArray[3].ToString();
					_poId	 = ClassLib.ComFunction.NullToBlank(vDt.Rows[0].ItemArray[4]);


					//---------------------------------------------------------------------------------
					bool vExistData  = false;
					// view point move 
					for (int col = 1 ; col < _sizeSheet.Columns.Count ; col++)
					{
						for (int row = 0 ; row < _sizeSheet.Rows.Count ; row++)
							if (!_sizeSheet.Cells[row, col].Text.Trim().Equals(""))
								vExistData = true;
				
						if (vExistData)
						{
							spd_size.ShowColumn(0, col, FarPoint.Win.Spread.HorizontalPosition.Left);
							break;
						}
					}		
					//---------------------------------------------------------------------------------

					txt_qty.Text = vTotal.ToString();
					txt_newQty.Text = "";

				}
				else
				{
					spd_size.ClearAll();
					_sizeSheet.Rows.Count = 1;
                    _obsId = cmb_id.SelectedValue.ToString();
                    _obsType = cmb_obsType.SelectedValue.ToString();
                    _poId =  cmb_id.SelectedValue.ToString();
					txt_qty.Text = "";
				}
				
				vDt.Dispose();
			}
            //catch (Exception ex)
            //{
            //    ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            catch 
            {
                //ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


        private void cmb_obsType_TextChanged(object sender, EventArgs e)
        {

            try
            {

                spd_size.ClearAll();
                _sizeSheet.Rows.Count = 1;

                txt_styleCd.Text = "";
                cmb_style.SelectedIndex = -1;


                Cmb_IDSetting();
                DataTable vDt = Select_Last_OBSID(cmb_factory.SelectedValue.ToString(), cmb_obsType.SelectedValue.ToString());
                cmb_id.SelectedValue = vDt.Rows[0].ItemArray[0].ToString();


            }
            catch
            {
                cmb_id.SelectedIndex = 1;
            }
        


        }



		private void Txt_StyleCdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				//vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCd, " ").Replace("-", ""));

                cmb_style.ClearItems();
				vDt = SELECT_STYLE_COMBO_DATA();

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(vDt, cmb_style, 0, 1, 2, 3, 4, true, 100, 221); 
				vDt.Dispose();
				
				if (txt_styleCd.Text.Length == 10)
				{
					string vCode = txt_styleCd.Text;
					vCode = vCode.Substring(0, 6) + "-" + vCode.Substring(6, 3);
					cmb_style.SelectedValue = vCode;
				}
			}
			catch //(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs_StyleCode", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}

		private void Cmb_StyleSelectedValueChangedProcess()
		{
			try
			{
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				txt_styleCd.Text	= cmb_style.SelectedValue.ToString();
			}
			catch //(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs_Style", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// MRP No, Order ID
		private void Cmb_IDSetting()
		{
			try
			{
				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vType = COM.ComFunction.Empty_Combo(cmb_type, "");

				DataTable vDt;
			
				vDt = SELECT_COMBO_DATA();

				if (cmb_type.SelectedIndex == 0 || cmb_type.SelectedIndex == 2 )
					lbl_Id.Text = "Order ID";
				else
					lbl_Id.Text = "MRP Ship No";

				if (vDt != null && vDt.Rows.Count > 0)
				{
					COM.ComCtl.Set_ComboList(vDt, cmb_id, 0, 0, false, false);
                  
                    
				}
				else
				{
					spd_size.ClearAll();
					_sizeSheet.Rows.Count = 1;

					cmb_id.SelectedIndex = -1;
					txt_styleCd.Text = "";
					cmb_style.SelectedIndex = -1;
				}

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ID Set", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void SizeAutoCalculation()
		{
			try
			{
				int vStartCol	= 0;
				int vEndCol		= _sizeSheet.ColumnCount;

				double vOldQty	= Convert.ToDouble(NullToZero(txt_qty.Text));

				if (vOldQty == 0)
					return;

				double vNewQty	= Convert.ToDouble(NullToZero(txt_newQty.Text));
				int vSumQty	= 0;
				int vTempQty = 0;

				for (int vCol = vStartCol ; vCol < vEndCol ; vCol++)
				{
					double vCurQty = Convert.ToDouble(NullToZero(_sizeSheet.Cells[0, vCol].Tag));

					vTempQty = Convert.ToInt32((vCurQty / vOldQty) * vNewQty);
					
					_sizeSheet.Cells[0, vCol].Value = (vTempQty == 0) ? "" : vTempQty.ToString();
					vSumQty += vTempQty;
				}

				if ( vSumQty != vNewQty )
				{
					double vDiv = (vSumQty - vNewQty);

					for (int vCol2 = vEndCol - 1 ; vCol2 >= vStartCol ; vCol2--)
					{
						if (NullToZero(_sizeSheet.Cells[0, vCol2].Value) > 0)
						{
							if (NullToZero(_sizeSheet.Cells[0, vCol2].Value) >= vDiv)
							{
								_sizeSheet.Cells[0, vCol2].Value = Convert.ToInt32(_sizeSheet.Cells[0, vCol2].Value) - vDiv;
								break;
							}
							else
							{
								vDiv = vDiv - Convert.ToInt32(_sizeSheet.Cells[0, vCol2]);
								_sizeSheet.Cells[0, vCol2].Value = "";
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Calculation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private double NullToZero(object arg_num)
		{
			try
			{
				double vResult = 0;

				if (arg_num != null)
				{
					if (!arg_num.ToString().Equals(""))
					{
						vResult = Convert.ToDouble(arg_num);
					}
				}

				return vResult;
			}
			catch 
			{
				return 0;
			}
		}

		#endregion

		#region DB Connect


        private static DataTable Select_Last_OBSID(string arg_factory, string arg_obs_type)
        {

            COM.OraDB MyOraDB = new COM.OraDB();

            DataSet ds_ret;

            MyOraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SEM_GPO.SELECT_LAST_OBSID";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_OBS_TYPE";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            //03.DATA TYPE
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04.DATA 정의  
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_obs_type;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);

            ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;

            return ds_ret.Tables[MyOraDB.Process_Name];

        }



		/// <summary>
		/// PKG_SBP_REQUEST_HEAD : Obs ID, MRP Ship No 리스트를 가져온다.
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_COMBO_DATA()
		{
			try
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_REQUEST_HEAD.SELECT_COMBO_DATA";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_type, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_factory, "");
                MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_obsType, "");
				MyOraDB.Parameter_Values[3] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();
				if(vds_ret == null) return null ;

				return vds_ret.Tables[MyOraDB.Process_Name];
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_COMBO_DATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
		}

		/// <summary>
		/// PKG_SBP_REQUEST_HEAD : Size 별 수량 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SIZE_DATA()
		{
			try
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_REQUEST_HEAD.SELECT_SIZE_DATA";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[3] = "ARG_ID";
				MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_type, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_obsType, "");
				MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_id, "");
				MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
				MyOraDB.Parameter_Values[5] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();
				if(vds_ret == null) return null ;

				return vds_ret.Tables[MyOraDB.Process_Name];
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_SIZE_DATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}		
		}






		/// <summary>
		/// SELECT_STYLE_COMBO_DATA : Obs ID, MRP Ship No 스타일 리스트를 가져온다.
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_STYLE_COMBO_DATA()
		{
			try
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_REQUEST_HEAD.SELECT_STYLE_COMBO_DATA"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_ID";
                MyOraDB.Parameter_Name[3] = "ARG_TYPE";
				MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_type, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_id, "");
                MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_obsType, "");
				//MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
                MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_String(txt_styleCd.Text, "").Replace("-", "");
				MyOraDB.Parameter_Values[5] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();
				if(vds_ret == null) return null ;

				return vds_ret.Tables[MyOraDB.Process_Name];
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_STYLE_COMBO_DATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
		}


		#endregion	

      


	}
}


