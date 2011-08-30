using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Purchase
{
	public class Form_Pur_Order : COM.PCHWinForm.Form_Top
	{
		#region 컨트롤정의 및 리소스 정의
		public System.Windows.Forms.Panel pnl_Top;
		private System.Windows.Forms.TextBox txt_mat_name;
		private C1.Win.C1List.C1Combo cmb_status;
		private C1.Win.C1List.C1Combo cmb_pur_user;
		private System.Windows.Forms.DateTimePicker dpk_get_from;
		private System.Windows.Forms.Label lbl_pur_user;
		private System.Windows.Forms.Label lbl_data_type;
		public C1.Win.C1List.C1Combo cmb_pur_div;
		private System.Windows.Forms.Label lbl_pur_div;
		public C1.Win.C1List.C1Combo cmb_data_type;
		private System.Windows.Forms.Label lbl_hp;
		private System.Windows.Forms.DateTimePicker dpk_get_to;
		private System.Windows.Forms.Label lbl_get_date;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Label btn_openfile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		public COM.FSP flg_pur_order;
		private System.Windows.Forms.Label lbl_srf_no;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_pur_no;
		private System.Windows.Forms.Label lbl_pur_no;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.TextBox txt_srf_no;
		private System.Windows.Forms.ContextMenu contextMenu;
		private COM.OraDB MyOraDB = new COM.OraDB();
		private System.Windows.Forms.TextBox txt_style_name;
		private System.Windows.Forms.Label lbl_material;
		private System.Windows.Forms.MenuItem cmt_Material;
        private System.Windows.Forms.MenuItem cmt_Bom;
		private System.Windows.Forms.MenuItem ctm_Bar1;
		private System.Windows.Forms.MenuItem ctm_Value;
        private MenuItem ctm_Vendor;
        private Label btn_check;
		private System.Windows.Forms.Label lbl_style_name;
		
		public Form_Pur_Order()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pur_Order));
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
            C1.Win.C1List.Style style49 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style50 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style51 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style52 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style53 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style54 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style55 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style56 = new C1.Win.C1List.Style();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.cmb_pur_no = new C1.Win.C1List.C1Combo();
            this.lbl_pur_no = new System.Windows.Forms.Label();
            this.txt_srf_no = new System.Windows.Forms.TextBox();
            this.lbl_srf_no = new System.Windows.Forms.Label();
            this.txt_mat_name = new System.Windows.Forms.TextBox();
            this.txt_style_name = new System.Windows.Forms.TextBox();
            this.cmb_status = new C1.Win.C1List.C1Combo();
            this.cmb_pur_user = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_material = new System.Windows.Forms.Label();
            this.lbl_style_name = new System.Windows.Forms.Label();
            this.dpk_get_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_pur_user = new System.Windows.Forms.Label();
            this.lbl_data_type = new System.Windows.Forms.Label();
            this.cmb_pur_div = new C1.Win.C1List.C1Combo();
            this.lbl_pur_div = new System.Windows.Forms.Label();
            this.cmb_data_type = new C1.Win.C1List.C1Combo();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.dpk_get_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_get_date = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.btn_check = new System.Windows.Forms.Label();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_openfile = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.flg_pur_order = new COM.FSP();
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.cmt_Material = new System.Windows.Forms.MenuItem();
            this.cmt_Bom = new System.Windows.Forms.MenuItem();
            this.ctm_Bar1 = new System.Windows.Forms.MenuItem();
            this.ctm_Value = new System.Windows.Forms.MenuItem();
            this.ctm_Vendor = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_data_type)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flg_pur_order)).BeginInit();
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
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
            // 
            // tbtn_Create
            // 
            this.tbtn_Create.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Create_Click);
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
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
            // tbtn_Confirm
            // 
            this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.cmb_vendor);
            this.pnl_Top.Controls.Add(this.lbl_vendor);
            this.pnl_Top.Controls.Add(this.cmb_pur_no);
            this.pnl_Top.Controls.Add(this.lbl_pur_no);
            this.pnl_Top.Controls.Add(this.txt_srf_no);
            this.pnl_Top.Controls.Add(this.lbl_srf_no);
            this.pnl_Top.Controls.Add(this.txt_mat_name);
            this.pnl_Top.Controls.Add(this.txt_style_name);
            this.pnl_Top.Controls.Add(this.cmb_status);
            this.pnl_Top.Controls.Add(this.cmb_pur_user);
            this.pnl_Top.Controls.Add(this.cmb_factory);
            this.pnl_Top.Controls.Add(this.lbl_material);
            this.pnl_Top.Controls.Add(this.lbl_style_name);
            this.pnl_Top.Controls.Add(this.dpk_get_from);
            this.pnl_Top.Controls.Add(this.lbl_pur_user);
            this.pnl_Top.Controls.Add(this.lbl_data_type);
            this.pnl_Top.Controls.Add(this.cmb_pur_div);
            this.pnl_Top.Controls.Add(this.lbl_pur_div);
            this.pnl_Top.Controls.Add(this.cmb_data_type);
            this.pnl_Top.Controls.Add(this.lbl_hp);
            this.pnl_Top.Controls.Add(this.dpk_get_to);
            this.pnl_Top.Controls.Add(this.lbl_get_date);
            this.pnl_Top.Controls.Add(this.lbl_status);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 80);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 136);
            this.pnl_Top.TabIndex = 137;
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemCols = 0;
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style1;
            this.cmb_vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_vendor.ColumnCaptionHeight = 18;
            this.cmb_vendor.ColumnFooterHeight = 18;
            this.cmb_vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_vendor.ContentHeight = 17;
            this.cmb_vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_vendor.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_vendor.EditorHeight = 17;
            this.cmb_vendor.EvenRowStyle = style2;
            this.cmb_vendor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style3;
            this.cmb_vendor.GapHeight = 2;
            this.cmb_vendor.HeadingStyle = style4;
            this.cmb_vendor.HighLightRowStyle = style5;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(445, 80);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style6;
            this.cmb_vendor.PartialRightColumn = false;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style7;
            this.cmb_vendor.Size = new System.Drawing.Size(211, 21);
            this.cmb_vendor.Style = style8;
            this.cmb_vendor.TabIndex = 361;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(344, 80);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 360;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_pur_no
            // 
            this.cmb_pur_no.AddItemCols = 0;
            this.cmb_pur_no.AddItemSeparator = ';';
            this.cmb_pur_no.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_pur_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_pur_no.Caption = "";
            this.cmb_pur_no.CaptionHeight = 17;
            this.cmb_pur_no.CaptionStyle = style9;
            this.cmb_pur_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_pur_no.ColumnCaptionHeight = 18;
            this.cmb_pur_no.ColumnFooterHeight = 18;
            this.cmb_pur_no.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_pur_no.ContentHeight = 17;
            this.cmb_pur_no.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_pur_no.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_pur_no.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pur_no.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_pur_no.EditorHeight = 17;
            this.cmb_pur_no.EvenRowStyle = style10;
            this.cmb_pur_no.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pur_no.FooterStyle = style11;
            this.cmb_pur_no.GapHeight = 2;
            this.cmb_pur_no.HeadingStyle = style12;
            this.cmb_pur_no.HighLightRowStyle = style13;
            this.cmb_pur_no.ItemHeight = 15;
            this.cmb_pur_no.Location = new System.Drawing.Point(117, 80);
            this.cmb_pur_no.MatchEntryTimeout = ((long)(2000));
            this.cmb_pur_no.MaxDropDownItems = ((short)(5));
            this.cmb_pur_no.MaxLength = 32767;
            this.cmb_pur_no.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_pur_no.Name = "cmb_pur_no";
            this.cmb_pur_no.OddRowStyle = style14;
            this.cmb_pur_no.PartialRightColumn = false;
            this.cmb_pur_no.PropBag = resources.GetString("cmb_pur_no.PropBag");
            this.cmb_pur_no.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_pur_no.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_pur_no.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_pur_no.SelectedStyle = style15;
            this.cmb_pur_no.Size = new System.Drawing.Size(211, 21);
            this.cmb_pur_no.Style = style16;
            this.cmb_pur_no.TabIndex = 359;
            this.cmb_pur_no.SelectedValueChanged += new System.EventHandler(this.cmb_pur_no_SelectedValueChanged);
            // 
            // lbl_pur_no
            // 
            this.lbl_pur_no.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pur_no.ImageIndex = 0;
            this.lbl_pur_no.ImageList = this.img_Label;
            this.lbl_pur_no.Location = new System.Drawing.Point(16, 80);
            this.lbl_pur_no.Name = "lbl_pur_no";
            this.lbl_pur_no.Size = new System.Drawing.Size(100, 21);
            this.lbl_pur_no.TabIndex = 358;
            this.lbl_pur_no.Text = "Pur. Number";
            this.lbl_pur_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_srf_no
            // 
            this.txt_srf_no.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_srf_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_srf_no.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_srf_no.ForeColor = System.Drawing.Color.Black;
            this.txt_srf_no.Location = new System.Drawing.Point(117, 102);
            this.txt_srf_no.MaxLength = 100;
            this.txt_srf_no.Name = "txt_srf_no";
            this.txt_srf_no.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_srf_no.Size = new System.Drawing.Size(211, 20);
            this.txt_srf_no.TabIndex = 357;
            // 
            // lbl_srf_no
            // 
            this.lbl_srf_no.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srf_no.ImageIndex = 0;
            this.lbl_srf_no.ImageList = this.img_Label;
            this.lbl_srf_no.Location = new System.Drawing.Point(16, 102);
            this.lbl_srf_no.Name = "lbl_srf_no";
            this.lbl_srf_no.Size = new System.Drawing.Size(100, 21);
            this.lbl_srf_no.TabIndex = 356;
            this.lbl_srf_no.Text = "SRF No.";
            this.lbl_srf_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_mat_name
            // 
            this.txt_mat_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mat_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mat_name.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_mat_name.ForeColor = System.Drawing.Color.Black;
            this.txt_mat_name.Location = new System.Drawing.Point(445, 102);
            this.txt_mat_name.MaxLength = 100;
            this.txt_mat_name.Name = "txt_mat_name";
            this.txt_mat_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_mat_name.Size = new System.Drawing.Size(211, 20);
            this.txt_mat_name.TabIndex = 354;
            // 
            // txt_style_name
            // 
            this.txt_style_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_style_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_style_name.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_style_name.ForeColor = System.Drawing.Color.Black;
            this.txt_style_name.Location = new System.Drawing.Point(773, 80);
            this.txt_style_name.MaxLength = 100;
            this.txt_style_name.Name = "txt_style_name";
            this.txt_style_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_style_name.Size = new System.Drawing.Size(211, 20);
            this.txt_style_name.TabIndex = 353;
            // 
            // cmb_status
            // 
            this.cmb_status.AddItemCols = 0;
            this.cmb_status.AddItemSeparator = ';';
            this.cmb_status.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_status.Caption = "";
            this.cmb_status.CaptionHeight = 17;
            this.cmb_status.CaptionStyle = style17;
            this.cmb_status.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_status.ColumnCaptionHeight = 18;
            this.cmb_status.ColumnFooterHeight = 18;
            this.cmb_status.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_status.ContentHeight = 17;
            this.cmb_status.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_status.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_status.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_status.EditorHeight = 17;
            this.cmb_status.EvenRowStyle = style18;
            this.cmb_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FooterStyle = style19;
            this.cmb_status.GapHeight = 2;
            this.cmb_status.HeadingStyle = style20;
            this.cmb_status.HighLightRowStyle = style21;
            this.cmb_status.ItemHeight = 15;
            this.cmb_status.Location = new System.Drawing.Point(117, 58);
            this.cmb_status.MatchEntryTimeout = ((long)(2000));
            this.cmb_status.MaxDropDownItems = ((short)(5));
            this.cmb_status.MaxLength = 32767;
            this.cmb_status.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.OddRowStyle = style22;
            this.cmb_status.PartialRightColumn = false;
            this.cmb_status.PropBag = resources.GetString("cmb_status.PropBag");
            this.cmb_status.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_status.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_status.SelectedStyle = style23;
            this.cmb_status.Size = new System.Drawing.Size(211, 21);
            this.cmb_status.Style = style24;
            this.cmb_status.TabIndex = 352;
            this.cmb_status.SelectedValueChanged += new System.EventHandler(this.cmb_status_SelectedValueChanged);
            // 
            // cmb_pur_user
            // 
            this.cmb_pur_user.AddItemCols = 0;
            this.cmb_pur_user.AddItemSeparator = ';';
            this.cmb_pur_user.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_pur_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_pur_user.Caption = "";
            this.cmb_pur_user.CaptionHeight = 17;
            this.cmb_pur_user.CaptionStyle = style25;
            this.cmb_pur_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_pur_user.ColumnCaptionHeight = 18;
            this.cmb_pur_user.ColumnFooterHeight = 18;
            this.cmb_pur_user.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_pur_user.ContentHeight = 17;
            this.cmb_pur_user.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_pur_user.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_pur_user.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pur_user.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_pur_user.EditorHeight = 17;
            this.cmb_pur_user.EvenRowStyle = style26;
            this.cmb_pur_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pur_user.FooterStyle = style27;
            this.cmb_pur_user.GapHeight = 2;
            this.cmb_pur_user.HeadingStyle = style28;
            this.cmb_pur_user.HighLightRowStyle = style29;
            this.cmb_pur_user.ItemHeight = 15;
            this.cmb_pur_user.Location = new System.Drawing.Point(773, 36);
            this.cmb_pur_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_pur_user.MaxDropDownItems = ((short)(5));
            this.cmb_pur_user.MaxLength = 32767;
            this.cmb_pur_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_pur_user.Name = "cmb_pur_user";
            this.cmb_pur_user.OddRowStyle = style30;
            this.cmb_pur_user.PartialRightColumn = false;
            this.cmb_pur_user.PropBag = resources.GetString("cmb_pur_user.PropBag");
            this.cmb_pur_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_pur_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_pur_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_pur_user.SelectedStyle = style31;
            this.cmb_pur_user.Size = new System.Drawing.Size(211, 21);
            this.cmb_pur_user.Style = style32;
            this.cmb_pur_user.TabIndex = 351;
            this.cmb_pur_user.SelectedValueChanged += new System.EventHandler(this.cmb_pur_user_SelectedValueChanged);
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
            this.cmb_factory.ContentHeight = 17;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 17;
            this.cmb_factory.EvenRowStyle = style34;
            this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style35;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style36;
            this.cmb_factory.HighLightRowStyle = style37;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(117, 36);
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
            this.cmb_factory.Size = new System.Drawing.Size(211, 21);
            this.cmb_factory.Style = style40;
            this.cmb_factory.TabIndex = 350;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // lbl_material
            // 
            this.lbl_material.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_material.ImageIndex = 0;
            this.lbl_material.ImageList = this.img_Label;
            this.lbl_material.Location = new System.Drawing.Point(344, 102);
            this.lbl_material.Name = "lbl_material";
            this.lbl_material.Size = new System.Drawing.Size(100, 21);
            this.lbl_material.TabIndex = 327;
            this.lbl_material.Text = "Material";
            this.lbl_material.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_style_name
            // 
            this.lbl_style_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style_name.ImageIndex = 0;
            this.lbl_style_name.ImageList = this.img_Label;
            this.lbl_style_name.Location = new System.Drawing.Point(672, 80);
            this.lbl_style_name.Name = "lbl_style_name";
            this.lbl_style_name.Size = new System.Drawing.Size(100, 21);
            this.lbl_style_name.TabIndex = 325;
            this.lbl_style_name.Text = "Style Name";
            this.lbl_style_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpk_get_from
            // 
            this.dpk_get_from.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_get_from.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_get_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_get_from.Location = new System.Drawing.Point(445, 35);
            this.dpk_get_from.Name = "dpk_get_from";
            this.dpk_get_from.Size = new System.Drawing.Size(100, 22);
            this.dpk_get_from.TabIndex = 324;
            this.dpk_get_from.Value = new System.DateTime(2007, 11, 19, 14, 18, 56, 968);
            this.dpk_get_from.CloseUp += new System.EventHandler(this.dpk_get_from_CloseUp);
            // 
            // lbl_pur_user
            // 
            this.lbl_pur_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pur_user.ImageIndex = 0;
            this.lbl_pur_user.ImageList = this.img_Label;
            this.lbl_pur_user.Location = new System.Drawing.Point(672, 36);
            this.lbl_pur_user.Name = "lbl_pur_user";
            this.lbl_pur_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_pur_user.TabIndex = 322;
            this.lbl_pur_user.Text = "Pur. User";
            this.lbl_pur_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_data_type
            // 
            this.lbl_data_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_type.ImageIndex = 0;
            this.lbl_data_type.ImageList = this.img_Label;
            this.lbl_data_type.Location = new System.Drawing.Point(344, 58);
            this.lbl_data_type.Name = "lbl_data_type";
            this.lbl_data_type.Size = new System.Drawing.Size(100, 21);
            this.lbl_data_type.TabIndex = 321;
            this.lbl_data_type.Text = "Data Type";
            this.lbl_data_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_pur_div
            // 
            this.cmb_pur_div.AddItemCols = 0;
            this.cmb_pur_div.AddItemSeparator = ';';
            this.cmb_pur_div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_pur_div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_pur_div.Caption = "";
            this.cmb_pur_div.CaptionHeight = 17;
            this.cmb_pur_div.CaptionStyle = style41;
            this.cmb_pur_div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_pur_div.ColumnCaptionHeight = 18;
            this.cmb_pur_div.ColumnFooterHeight = 18;
            this.cmb_pur_div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_pur_div.ContentHeight = 17;
            this.cmb_pur_div.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_pur_div.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_pur_div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pur_div.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_pur_div.EditorHeight = 17;
            this.cmb_pur_div.EvenRowStyle = style42;
            this.cmb_pur_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pur_div.FooterStyle = style43;
            this.cmb_pur_div.GapHeight = 2;
            this.cmb_pur_div.HeadingStyle = style44;
            this.cmb_pur_div.HighLightRowStyle = style45;
            this.cmb_pur_div.ItemHeight = 15;
            this.cmb_pur_div.Location = new System.Drawing.Point(773, 58);
            this.cmb_pur_div.MatchEntryTimeout = ((long)(2000));
            this.cmb_pur_div.MaxDropDownItems = ((short)(5));
            this.cmb_pur_div.MaxLength = 32767;
            this.cmb_pur_div.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_pur_div.Name = "cmb_pur_div";
            this.cmb_pur_div.OddRowStyle = style46;
            this.cmb_pur_div.PartialRightColumn = false;
            this.cmb_pur_div.PropBag = resources.GetString("cmb_pur_div.PropBag");
            this.cmb_pur_div.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_pur_div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_pur_div.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_pur_div.SelectedStyle = style47;
            this.cmb_pur_div.Size = new System.Drawing.Size(211, 21);
            this.cmb_pur_div.Style = style48;
            this.cmb_pur_div.TabIndex = 320;
            this.cmb_pur_div.SelectedValueChanged += new System.EventHandler(this.cmb_pur_div_SelectedValueChanged);
            // 
            // lbl_pur_div
            // 
            this.lbl_pur_div.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pur_div.ImageIndex = 0;
            this.lbl_pur_div.ImageList = this.img_Label;
            this.lbl_pur_div.Location = new System.Drawing.Point(672, 58);
            this.lbl_pur_div.Name = "lbl_pur_div";
            this.lbl_pur_div.Size = new System.Drawing.Size(100, 21);
            this.lbl_pur_div.TabIndex = 319;
            this.lbl_pur_div.Text = "Pur. Division";
            this.lbl_pur_div.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_data_type
            // 
            this.cmb_data_type.AddItemCols = 0;
            this.cmb_data_type.AddItemSeparator = ';';
            this.cmb_data_type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_data_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_data_type.Caption = "";
            this.cmb_data_type.CaptionHeight = 17;
            this.cmb_data_type.CaptionStyle = style49;
            this.cmb_data_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_data_type.ColumnCaptionHeight = 18;
            this.cmb_data_type.ColumnFooterHeight = 18;
            this.cmb_data_type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_data_type.ContentHeight = 17;
            this.cmb_data_type.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_data_type.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_data_type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_data_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_data_type.EditorHeight = 17;
            this.cmb_data_type.EvenRowStyle = style50;
            this.cmb_data_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_data_type.FooterStyle = style51;
            this.cmb_data_type.GapHeight = 2;
            this.cmb_data_type.HeadingStyle = style52;
            this.cmb_data_type.HighLightRowStyle = style53;
            this.cmb_data_type.ItemHeight = 15;
            this.cmb_data_type.Location = new System.Drawing.Point(445, 58);
            this.cmb_data_type.MatchEntryTimeout = ((long)(2000));
            this.cmb_data_type.MaxDropDownItems = ((short)(5));
            this.cmb_data_type.MaxLength = 32767;
            this.cmb_data_type.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_data_type.Name = "cmb_data_type";
            this.cmb_data_type.OddRowStyle = style54;
            this.cmb_data_type.PartialRightColumn = false;
            this.cmb_data_type.PropBag = resources.GetString("cmb_data_type.PropBag");
            this.cmb_data_type.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_data_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_data_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_data_type.SelectedStyle = style55;
            this.cmb_data_type.Size = new System.Drawing.Size(211, 21);
            this.cmb_data_type.Style = style56;
            this.cmb_data_type.TabIndex = 318;
            this.cmb_data_type.SelectedValueChanged += new System.EventHandler(this.cmb_data_type_SelectedValueChanged);
            // 
            // lbl_hp
            // 
            this.lbl_hp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hp.Location = new System.Drawing.Point(547, 36);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(10, 21);
            this.lbl_hp.TabIndex = 315;
            this.lbl_hp.Text = "~";
            this.lbl_hp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpk_get_to
            // 
            this.dpk_get_to.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_get_to.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_get_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_get_to.Location = new System.Drawing.Point(557, 35);
            this.dpk_get_to.Name = "dpk_get_to";
            this.dpk_get_to.Size = new System.Drawing.Size(100, 22);
            this.dpk_get_to.TabIndex = 314;
            this.dpk_get_to.CloseUp += new System.EventHandler(this.dpk_get_from_CloseUp);
            // 
            // lbl_get_date
            // 
            this.lbl_get_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_get_date.ImageIndex = 0;
            this.lbl_get_date.ImageList = this.img_Label;
            this.lbl_get_date.Location = new System.Drawing.Point(344, 36);
            this.lbl_get_date.Name = "lbl_get_date";
            this.lbl_get_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_get_date.TabIndex = 313;
            this.lbl_get_date.Text = "Get Date";
            this.lbl_get_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ImageIndex = 0;
            this.lbl_status.ImageList = this.img_Label;
            this.lbl_status.Location = new System.Drawing.Point(16, 58);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 21);
            this.lbl_status.TabIndex = 309;
            this.lbl_status.Text = "Status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 36);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 271;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.btn_check);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.btn_openfile);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 128);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // btn_check
            // 
            this.btn_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_check.Font = new System.Drawing.Font("굴림", 8F);
            this.btn_check.ImageIndex = 0;
            this.btn_check.ImageList = this.img_Button;
            this.btn_check.Location = new System.Drawing.Point(896, 102);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(80, 23);
            this.btn_check.TabIndex = 355;
            this.btn_check.Text = "Print List";
            this.btn_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(219, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(776, 32);
            this.picb_TM.TabIndex = 113;
            this.picb_TM.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(231, 30);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Text = "      Purchase Infomation";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_openfile
            // 
            this.btn_openfile.BackColor = System.Drawing.SystemColors.Window;
            this.btn_openfile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openfile.Location = new System.Drawing.Point(426, 36);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(21, 21);
            this.btn_openfile.TabIndex = 112;
            this.btn_openfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(983, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 85);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(984, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 32);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 113);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(144, 112);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 113);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 20);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 95);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(150, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1000, 88);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(472, 72);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1000, 88);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // flg_pur_order
            // 
            this.flg_pur_order.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.flg_pur_order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flg_pur_order.AutoResize = false;
            this.flg_pur_order.BackColor = System.Drawing.SystemColors.Window;
            this.flg_pur_order.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flg_pur_order.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.flg_pur_order.ContextMenu = this.contextMenu;
            this.flg_pur_order.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flg_pur_order.ForeColor = System.Drawing.SystemColors.WindowText;
            this.flg_pur_order.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.flg_pur_order.Location = new System.Drawing.Point(4, 216);
            this.flg_pur_order.Name = "flg_pur_order";
            this.flg_pur_order.Rows.Fixed = 0;
            this.flg_pur_order.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.flg_pur_order.Size = new System.Drawing.Size(1008, 424);
            this.flg_pur_order.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("flg_pur_order.Styles"));
            this.flg_pur_order.TabIndex = 321;
            this.flg_pur_order.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.flg_pur_order_KeyPress);
            this.flg_pur_order.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flg_pur_order_MouseMove);
            this.flg_pur_order.KeyUp += new System.Windows.Forms.KeyEventHandler(this.flg_pur_order_KeyUp);
            this.flg_pur_order.DoubleClick += new System.EventHandler(this.flg_pur_order_DoubleClick);
            this.flg_pur_order.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.flg_pur_order_AfterEdit);
            this.flg_pur_order.KeyDown += new System.Windows.Forms.KeyEventHandler(this.flg_pur_order_KeyDown);
            this.flg_pur_order.Click += new System.EventHandler(this.flg_pur_order_Click);
            this.flg_pur_order.EnterCell += new System.EventHandler(this.flg_pur_order_EnterCell);
            // 
            // contextMenu
            // 
            this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cmt_Material,
            this.cmt_Bom,
            this.ctm_Bar1,
            this.ctm_Value,
            this.ctm_Vendor});
            // 
            // cmt_Material
            // 
            this.cmt_Material.Index = 0;
            this.cmt_Material.Text = "Material";
            this.cmt_Material.Click += new System.EventHandler(this.cmt_Material_Click);
            // 
            // cmt_Bom
            // 
            this.cmt_Bom.Index = 1;
            this.cmt_Bom.Text = "BOM";
            this.cmt_Bom.Click += new System.EventHandler(this.cmt_Bom_Click);
            // 
            // ctm_Bar1
            // 
            this.ctm_Bar1.Index = 2;
            this.ctm_Bar1.Text = "-";
            // 
            // ctm_Value
            // 
            this.ctm_Value.Index = 3;
            this.ctm_Value.Text = "Change Value";
            this.ctm_Value.Click += new System.EventHandler(this.ctm_Value_Click);
            // 
            // ctm_Vendor
            // 
            this.ctm_Vendor.Index = 4;
            this.ctm_Vendor.Text = "Change Vendor";
            this.ctm_Vendor.Click += new System.EventHandler(this.ctm_Vendor_Click);
            // 
            // Form_Pur_Order
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.flg_pur_order);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Form_Pur_Order";
            this.Load += new System.EventHandler(this.Form_Pur_Order_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.flg_pur_order, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_pur_div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_data_type)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flg_pur_order)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

		private int _RowFixed;
		private int show_lev = 1;
        private string _mat_cd = "";

		#endregion 

		#region 공통메쏘드		
		private void Init_Form()
		{
			this.Text               = "PCC_Purchase Order";
			this.lbl_MainTitle.Text = "PCC_Purchase Order";
			ClassLib.ComFunction.SetLangDic(this); 
            
            tbtn_Create.ToolTipText = "Create";

            #region ComboBox Setting
            dpk_get_from.Value = DateTime.Now.AddDays(-7);
			dpk_get_to.Value = DateTime.Now;
	
			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_MatDiv);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_div, 1, 2, true, false);
			cmb_pur_div.SelectedIndex = 0;

			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurManaget_DataType);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_data_type, 1, 2, true, false);
			cmb_data_type.SelectedIndex = 0;			

			#region Upload  User설정

            DataTable dt_list = Select_sxp_pur_user();

            cmb_pur_user.Enabled = true;

           
            ClassLib.ComCtl.Set_ComboList(dt_list, cmb_pur_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_pur_user.SelectedIndex = 0;


            cmb_pur_user.Enabled = false;


            if (ClassLib.ComVar.This_CDCPower_Level.Substring(0, 1) == "P" || ClassLib.ComVar.This_CDCPower_Level == "S00")
            {

                cmb_pur_user.Enabled = true;
                ClassLib.ComCtl.Set_ComboList(dt_list, cmb_pur_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
                //cmb_pur_user.SelectedIndex = 0;

                cmb_pur_user.Enabled = false;

                DataTable user_datatable = new DataTable("UserList");
                DataRow newrow;

                user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                newrow = user_datatable.NewRow();
                newrow["Code"] = ClassLib.ComVar.This_User;
                newrow["Name"] = ClassLib.ComVar.This_User;

                user_datatable.Rows.Add(newrow);

                ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_pur_user, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
                cmb_pur_user.SelectedValue = ClassLib.ComVar.This_User;


            }

			#endregion  
						
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_PurOrder_Status);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2, true, false);
			cmb_status.SelectedIndex = 0;

			try
			{
				Set_po_no();
			}
			catch
			{
            }
            #endregion

            #region Grid Setting
            flg_pur_order.Set_Grid_CDC("SXP_PUR_ORDER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			flg_pur_order.Set_Action_Image(img_Action);
			_RowFixed = flg_pur_order.Rows.Count;
			flg_pur_order.ExtendLastCol = false;
			flg_pur_order.Tree.Column = (int)ClassLib.TBSXP_PUR_ORDER.IxMAT_NAME;
            #endregion

            button_control();
		}
		private void Set_po_no()
		{
            try
            {
                DataTable dt_ret = get_pur_no();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_no, 0, 0, true, false);
                cmb_pur_no.SelectedIndex = 0;
            }
            catch
            {
 
            }
		}
        private void Set_po_no(string arg_pur_no)
        {
            try
            {
                DataTable dt_ret = get_pur_no();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_pur_no, 0, 0, true, false);

                try
                {
                    cmb_pur_no.SelectedValue = arg_pur_no;

                    if (cmb_pur_no.SelectedIndex == -1)
                    {
                        cmb_pur_no.SelectedIndex = 0;
                    }
                }
                catch
                {
                    cmb_pur_no.SelectedIndex = 0;

                }
            }
            catch
            {
 
            }
        }
		private void button_control()
		{
			try
			{
                if (cmb_status.SelectedIndex.Equals(0) )//status : ALL
				{
                    if (cmb_pur_no.SelectedIndex > 0)
                    {
                        tbtn_Confirm.Enabled = true;
                        tbtn_Save.Enabled = true;
                        tbtn_Create.Enabled = false;
                        tbtn_Print.Enabled = false;
                        tbtn_Delete.Enabled = true;
                        btn_check.Enabled = true;

                        if ( (cmb_pur_div.SelectedValue.ToString() == "12" || cmb_pur_div.SelectedValue.ToString() == "21") && cmb_vendor.SelectedIndex > 0)//Local 또는 Import 일때
                            tbtn_Print.Enabled = true;
                    }
                    if(cmb_pur_no.SelectedIndex == 0)
                    {
                        tbtn_Confirm.Enabled = false;
                        tbtn_Save.Enabled = false;
                        tbtn_Create.Enabled = true;
                        tbtn_Print.Enabled = false;
                        tbtn_Delete.Enabled = false;
                        btn_check.Enabled = false;
                    }
				}
                else if (cmb_status.SelectedIndex.Equals(1) && (cmb_pur_no.SelectedIndex > 0))//status : Ready
				{
					tbtn_Confirm.Enabled = false;
					tbtn_Save.Enabled = true;
					tbtn_Create.Enabled = true;
					tbtn_Print.Enabled = false;
					tbtn_Delete.Enabled = true;
                    btn_check.Enabled = true;
				}
                else if (cmb_status.SelectedIndex.Equals(2) && (cmb_pur_no.SelectedIndex > 0))//status : Save
				{
					tbtn_Confirm.Enabled = true;
					tbtn_Save.Enabled = true;
					tbtn_Create.Enabled = false;
					tbtn_Print.Enabled = false;
					tbtn_Delete.Enabled = true;
					//발주no: no data이면 confirm 불가처리

                    btn_check.Enabled = true;
					if (cmb_pur_no.SelectedIndex.Equals(0) ) tbtn_Confirm.Enabled  = false;
					else tbtn_Confirm.Enabled = true;

				}
                else if (cmb_status.SelectedIndex.Equals(3) && (cmb_pur_no.SelectedIndex > 0))//status : comfirm
                {                    
                    tbtn_Confirm.Enabled = false;
                    tbtn_Save.Enabled = false;
                    tbtn_Create.Enabled = false;
                    tbtn_Print.Enabled = false;
                    tbtn_Delete.Enabled = false;

                    btn_check.Enabled = true;
                    if ( (cmb_pur_div.SelectedValue.ToString() == "12" || cmb_pur_div.SelectedValue.ToString() == "21") && cmb_vendor.SelectedIndex > 0 )//Local 또는 Import 일때
                        tbtn_Print.Enabled = true;
                }
                else
                {
                    tbtn_Confirm.Enabled = false;
                    tbtn_Save.Enabled = false;
                    tbtn_Create.Enabled = false;
                    tbtn_Print.Enabled = false;
                    tbtn_Delete.Enabled = false;
                    cmb_pur_no.SelectedIndex = 0;
                    btn_check.Enabled = false;
                }

				tbtn_New.Enabled = false;
			}
			catch
			{

			}
		}
		#endregion 

		#region 이벤트처리

		#region 버튼이벤트
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //행 수정 상태 해제
                flg_pur_order.Select(flg_pur_order.Selection.r1, 0, flg_pur_order.Selection.r1, flg_pur_order.Cols.Count - 1, false);

                if (cmb_pur_div.SelectedValue.ToString() == "11")
                    return;

                string mrd_Filename = "";
                string sPara = "";

                if (ClassLib.ComVar.This_Factory == "DS")
                {
                    if (cmb_pur_div.SelectedValue.ToString() == "12")
                    {
                        mrd_Filename = Application.StartupPath + @"\Order_sheet_list" + ".mrd";
                        sPara = " /rp " + "[" + cmb_factory.SelectedValue.ToString() + "]" + " [" + dpk_get_from.Text.Replace("-", "") + "]" + " [" + dpk_get_to.Text.Replace("-", "") + "]" + " [" + cmb_pur_no.SelectedValue.ToString() + "]" + " [" + cmb_vendor.SelectedValue.ToString() + "]";
                    }

                    if (cmb_pur_div.SelectedValue.ToString() == "21")
                    {
                        mrd_Filename = Application.StartupPath + @"\Order_sheet_list_import" + ".mrd";
                        sPara = " /rp " + "[" + cmb_factory.SelectedValue.ToString() + "]" + " [" + dpk_get_from.Text.Replace("-", "") + "]" + " [" + dpk_get_to.Text.Replace("-", "") + "]" + " [" + cmb_pur_no.SelectedValue.ToString() + "]" + " [" + cmb_vendor.SelectedValue.ToString() + "]";
                    }
                }




                if (ClassLib.ComVar.This_Factory == "VJ")
                {

                    if (cmb_pur_div.SelectedValue.ToString() == "12")
                    {
                        mrd_Filename = Application.StartupPath + @"\Order_sheet_list_VJ" + ".mrd";
                        sPara = " /rp " + "[" + cmb_factory.SelectedValue.ToString() + "]" + " [" + dpk_get_from.Text.Replace("-", "") + "]" + " [" + dpk_get_to.Text.Replace("-", "") + "]" + " [" + cmb_pur_no.SelectedValue.ToString() + "]" + " [" + cmb_vendor.SelectedValue.ToString() + "]";
                    }

                    if (cmb_pur_div.SelectedValue.ToString() == "21")
                    {
                        mrd_Filename = Application.StartupPath + @"\Order_sheet_list_import_VJ" + ".mrd";
                        sPara = " /rp " + "[" + cmb_factory.SelectedValue.ToString() + "]" + " [" + dpk_get_from.Text.Replace("-", "") + "]" + " [" + dpk_get_to.Text.Replace("-", "") + "]" + " [" + cmb_pur_no.SelectedValue.ToString() + "]" + " [" + cmb_vendor.SelectedValue.ToString() + "]";
                    }
                }



                if (ClassLib.ComVar.This_Factory == "QD")
                {

                    if (cmb_pur_div.SelectedValue.ToString() == "12")
                    {
                        mrd_Filename = Application.StartupPath + @"\Order_sheet_list_QD" + ".mrd";
                        sPara = " /rp " + "[" + cmb_factory.SelectedValue.ToString() + "]" + " [" + dpk_get_from.Text.Replace("-", "") + "]" + " [" + dpk_get_to.Text.Replace("-", "") + "]" + " [" + cmb_pur_no.SelectedValue.ToString() + "]" + " [" + cmb_vendor.SelectedValue.ToString() + "]";
                    }

                    if (cmb_pur_div.SelectedValue.ToString() == "21")
                    {
                        mrd_Filename = Application.StartupPath + @"\Order_sheet_list_import_QD" + ".mrd";
                        sPara = " /rp " + "[" + cmb_factory.SelectedValue.ToString() + "]" + " [" + dpk_get_from.Text.Replace("-", "") + "]" + " [" + dpk_get_to.Text.Replace("-", "") + "]" + " [" + cmb_pur_no.SelectedValue.ToString() + "]" + " [" + cmb_vendor.SelectedValue.ToString() + "]";
                    }
                }


                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}
        
		private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //행 수정 상태 해제
                flg_pur_order.Select(flg_pur_order.Selection.r1, 0, flg_pur_order.Selection.r1, flg_pur_order.Cols.Count - 1, false);


                string arg_pur_no = create_pur_no(cmb_factory.SelectedValue.ToString()).Rows[0].ItemArray[0].ToString();
                Get_pur_order(cmb_factory.SelectedValue.ToString(), arg_pur_no, cmb_pur_user.SelectedValue.ToString());

                Set_po_no(arg_pur_no);

                tbtn_Search_Click(null, null);
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsNotPrint, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}
        
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //행 수정 상태 해제
                flg_pur_order.Select(flg_pur_order.Selection.r1, 0, flg_pur_order.Selection.r1, flg_pur_order.Cols.Count - 1, false);

                flg_pur_order.Rows.Count = _RowFixed;
                DataTable dt = Search_pur_order(cmb_factory.SelectedValue.ToString(),
                    cmb_pur_user.SelectedValue.ToString(),
                    dpk_get_from.Value.ToString("yyyyMMdd"),
                    dpk_get_to.Value.ToString("yyyyMMdd"),
                    cmb_status.SelectedValue.ToString(),
                    cmb_pur_no.SelectedValue.ToString(),
                    cmb_data_type.SelectedValue.ToString(),
                    cmb_pur_div.SelectedValue.ToString(),
                    cmb_vendor.SelectedValue.ToString(),
                    txt_style_name.Text.Trim().ToUpper(),
                    txt_mat_name.Text.Trim().ToUpper(),
                    txt_srf_no.Text.Trim().ToUpper());


                int dt_rows = dt.Rows.Count;
                int dt_cols = dt.Columns.Count;

                if (dt_rows > 0)
                {



                    for (int i = 0; i < dt_rows; i++)
                    {
                        //					flg_pur_order.AddItem(dt.Rows[i].ItemArray);
                        int t_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSXP_PUR_ORDER.IxT_LEVEL].ToString());
                        flg_pur_order.Rows.InsertNode(flg_pur_order.Rows.Count, t_level);

                        for (int j = 0; j < dt_cols; j++)
                        {
                            flg_pur_order[flg_pur_order.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();

                            if (j == (int)ClassLib.TBSXP_PUR_ORDER.IxT_LEVEL)
                            {
                                if (dt.Rows[i].ItemArray[j].Equals("1"))
                                {
                                    flg_pur_order.Rows[flg_pur_order.Rows.Count - 1].AllowEditing = true;

                                    //flg_pur_order.Rows[flg_pur_order.Rows.Count-1].StyleNew.BackColor =  Color.Bisque;
                                }
                                else
                                {
                                    flg_pur_order.Rows[flg_pur_order.Rows.Count - 1].AllowEditing = false;
                                    flg_pur_order.Rows[flg_pur_order.Rows.Count - 1].StyleNew.BackColor = Color.Bisque;
                                }
                            }
                        }

                    }
                    for (int i = flg_pur_order.Rows.Fixed; i < flg_pur_order.Rows.Count; i++)
                    {
                        if (flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER.IxSTATUS].ToString().Trim() == "Confirm")
                            flg_pur_order.Rows[i].AllowEditing = false;
                    }
                }

                flg_pur_order.Tree.Show(show_lev);

                button_control();

                 
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}
        
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            try
            {
                
                this.Cursor = Cursors.WaitCursor;
                int x_point = flg_pur_order.ScrollPosition.X;
                int y_point = flg_pur_order.ScrollPosition.Y;

                //행 수정 상태 해제
                flg_pur_order.Select(flg_pur_order.Selection.r1, 0, flg_pur_order.Selection.r1, flg_pur_order.Cols.Count - 1, false);

                //for (int i = flg_pur_order.Rows.Fixed; i < flg_pur_order.Rows.Count; i++)
                //{
                //    flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER.IxVEN_NAME] = flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER.IxVEN_NAME].ToString().Trim().Replace(".", "..");
                //}

                MyOraDB.Save_FlexGird("PKG_SXP_PUR_02.SAVE_SXP_PUR_ORDER", flg_pur_order);
                tbtn_Search_Click(null, null);

                flg_pur_order.ScrollPosition = new Point(x_point, y_point);
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}
        
		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

            try
            {
                this.Cursor = Cursors.WaitCursor;
                int x_point = flg_pur_order.ScrollPosition.X;
                int y_point = flg_pur_order.ScrollPosition.Y;

                //행 수정 상태 해제
                flg_pur_order.Select(flg_pur_order.Selection.r1, 0, flg_pur_order.Selection.r1, flg_pur_order.Cols.Count - 1, false);

                for (int i = _RowFixed; i < flg_pur_order.Rows.Count; i++)
                {
                    if (flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER.IxVEN_NAME].ToString().Trim().Length.Equals(0))
                    {
                        ClassLib.ComFunction.User_Message("Input Error : Vendor", "Confirm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                DataTable dt = check_pur_status(cmb_factory.SelectedValue.ToString(), cmb_pur_no.SelectedValue.ToString());

                if (dt.Rows[0].ItemArray[0].ToString() != "0")
                {
                    ClassLib.ComFunction.User_Message("Ready Data is existed", "Confirm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;

                }



                comfirm_pur_no(cmb_factory.SelectedValue.ToString(), cmb_pur_user.SelectedValue.ToString(), dpk_get_from.Value.ToString("yyyyMMdd"), dpk_get_to.Value.ToString("yyyyMMdd"),
                    cmb_pur_no.SelectedValue.ToString(), cmb_data_type.SelectedValue.ToString(), cmb_pur_div.SelectedValue.ToString());
                tbtn_Search_Click(null, null);

                flg_pur_order.ScrollPosition = new Point(x_point, y_point);

            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun, this);

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

		}
        
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            int[] sct_rows = flg_pur_order.Selections;

            for (int i = 0; i < flg_pur_order.Selections.Length; i++)
            {
                if(flg_pur_order[sct_rows[i], (int)ClassLib.TBSXP_PUR_ORDER.IxSTATUS].ToString().Trim() != "Confirm")
                    flg_pur_order.Delete_Row(sct_rows[i]);
            }
		}        
        #endregion

        #region 그리드 이벤트
        private void flg_pur_order_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_pur_order.Selection.r1;

                if (!flg_pur_order.Rows[sct_row].AllowEditing)
                {
                    ctm_Value.Enabled = false;
                    ctm_Vendor.Enabled = false;
                }
                else
                {
                    ctm_Value.Enabled = true;
                    ctm_Vendor.Enabled = true;
                }

            }
            catch
            {

            }  
        }

		private void flg_pur_order_EnterCell(object sender, System.EventArgs e)
		{
            try
            {
                int sct_col = flg_pur_order.Selection.c1;

                ctm_Bar1.Visible = false;
                ctm_Vendor.Visible = false;
                ctm_Value.Visible = false;

                if (sct_col == (int)ClassLib.TBSXP_PUR_ORDER.IxVEN_NAME)
                {
                    ctm_Bar1.Visible = true;
                    ctm_Vendor.Visible = true;
                    return;
                }

                if ((sct_col == (int)ClassLib.TBSXP_PUR_ORDER.IxPUR_PRICE) || (sct_col == (int)ClassLib.TBSXP_PUR_ORDER.IxCBD_PRICE) ||
                    (sct_col == (int)ClassLib.TBSXP_PUR_ORDER.IxVALUE_PUR) || (sct_col == (int)ClassLib.TBSXP_PUR_ORDER.IxRTA_YMD) ||
                    (sct_col == (int)ClassLib.TBSXP_PUR_ORDER.IxETC_YMD))
                {
                    ctm_Bar1.Visible = true;
                    ctm_Value.Visible = true;
                }
            }
            catch
            {
 
            }
		}

		private void flg_pur_order_DoubleClick(object sender, System.EventArgs e)
		{           
		
		}

		private void flg_pur_order_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
            try
            {
                int sct_row1 = flg_pur_order.Selection.r1;
                int sct_row2 = flg_pur_order.Selection.r2;
                int sct_col = flg_pur_order.Selection.c1;

                for (int i = _RowFixed; i < flg_pur_order.Rows.Count; i++)
                {
                    if (flg_pur_order.Rows[i].Selected)
                    {
                        if (flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER.IxT_LEVEL].ToString() == "1")
                        {
                            flg_pur_order[i, sct_col] = flg_pur_order[sct_row1, sct_col].ToString();
                            flg_pur_order.Update_Row(i);
                        }
                    }
                }
                int level = (int)ClassLib.TBSXP_PUR_ORDER.IxT_LEVEL;

                if (sct_col == (int)ClassLib.TBSXP_PUR_ORDER.IxVALUE_PUR)
                {
                    ClassLib.ComFunction.NextRow_Focus_FlexGrid(flg_pur_order, sct_row1, sct_col, true, level, "1");
                }
            }
            catch
            {
 
            }
		}

        private void flg_pur_order_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                int sct_row = flg_pur_order.MouseRow;
                int sct_col = flg_pur_order.MouseCol;

                if (sct_row >= _RowFixed)
                {
                    if (!flg_pur_order[sct_row, (int)ClassLib.TBSXP_PUR_ORDER.IxSTATUS].ToString().Equals("C") && sct_col == (int)ClassLib.TBSXP_PUR_ORDER.IxVEN_NAME)
                    {
                        string vMatcd = flg_pur_order[flg_pur_order.Selection.r1, (int)ClassLib.TBSXP_PUR_ORDER.IxMAT_CD].ToString();
                        string vPurno = flg_pur_order[flg_pur_order.Selection.r1, (int)ClassLib.TBSXP_PUR_ORDER.IxPUR_NO].ToString();

                        if (vMatcd == "") return;
                        if (vPurno == "") return;

                        DataTable dt = Select_sxd_m_vendor(vPurno, vMatcd);



                        string vendor_item = "";

                        if (dt == null) { flg_pur_order.Cols[sct_col].ComboList = vendor_item; return; }

                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                if (i > 0) vendor_item += "|" + dt.Rows[i].ItemArray[0].ToString();
                                else vendor_item = dt.Rows[i].ItemArray[0].ToString();
                            }
                        }
                        else
                        {
                            vendor_item = "";
                        }

                        flg_pur_order.Cols[sct_col].ComboList = vendor_item;
                    }
                }
            }
            catch
            {

            }
          
        }
		
		#endregion 

		#region 콘텍스트메뉴
		private void cmt_Material_Click(object sender, System.EventArgs e)
		{
			show_lev = 1;
			flg_pur_order.Tree.Show(show_lev);
		}

		private void cmt_Bom_Click(object sender, System.EventArgs e)
		{
			show_lev = 2;
			flg_pur_order.Tree.Show(show_lev);
		}
        
		private void ctm_Value_Click(object sender, System.EventArgs e)
		{
			try
			{
				int  sct_col = flg_pur_order.Selection.c1;		

				FlexCDC.BaseInfo.Pop_Common_Text vEditor = new FlexCDC.BaseInfo.Pop_Common_Text( " ");
				vEditor.ShowDialog();				

				for (int i = flg_pur_order.Selection.r1; i<=flg_pur_order.Selection.r2; i++)
				{
                    if (flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER.IxT_LEVEL].ToString() != "1") continue;


					flg_pur_order[i,sct_col]  = COM.ComVar.This_Return;
					flg_pur_order.Update_Row(i);
				}	
			}
			catch
			{

			}
		
		}

        private void ctm_Vendor_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_col = flg_pur_order.Selection.c1;
                int sct_row1 = flg_pur_order.Selection.r1;
                int sct_row2 = flg_pur_order.Selection.r2;

                COM.ComVar.Parameter_PopUp = new string[1]; 
                COM.ComVar.Parameter_PopUp[0] = ClassLib.ComVar.ConsCDC_M_Vendor;

                string vmat_cd = flg_pur_order[sct_row1, (int)ClassLib.TBSXP_PUR_ORDER.IxMAT_CD].ToString();
                string vven_name = flg_pur_order[sct_row1, (int)ClassLib.TBSXP_PUR_ORDER.IxVEN_NAME].ToString();

                FlexCDC.Purchase.Pop_Pur_Vendor vEditor = new FlexCDC.Purchase.Pop_Pur_Vendor(this, cmb_factory.SelectedValue.ToString()
                    , sct_row1, sct_row2, vmat_cd, vven_name);
                vEditor.ShowDialog();



                for (int i = flg_pur_order.Selection.r1; i <= flg_pur_order.Selection.r2; i++)
                {
                    if (flg_pur_order[i, (int)ClassLib.TBSXP_PUR_ORDER.IxT_LEVEL].ToString() == "1")
                    {
                        flg_pur_order[i, sct_col - 1] = COM.ComVar.Parameter_PopUp[1];
                        flg_pur_order[i, sct_col] = COM.ComVar.Parameter_PopUp[0];
                        flg_pur_order.Update_Row(i);
                    }
                }
            }
            catch
            {

            }

        }		
       
		#endregion 

		#region 기타 이벤트

		private void cmb_pur_user_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_pur_user.SelectedIndex == -1) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                Set_po_no();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}
        
		private void dpk_get_from_CloseUp(object sender, System.EventArgs e)
		{

            try
            {
                this.Cursor = Cursors.WaitCursor;
                Set_po_no();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}
        
		private void cmb_status_SelectedValueChanged(object sender, System.EventArgs e)
		{
            try
            {
                if (cmb_status.SelectedIndex < 0) return;
                Set_po_no();
                button_control();
            }
            catch
            {
                
            }

		}
        
		private void cmb_data_type_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_data_type.SelectedIndex == -1) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                Set_po_no();
                //select_pur_vendor();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}
        
		private void cmb_pur_div_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_pur_div.SelectedIndex == -1) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                Set_po_no();
                //select_pur_vendor();
                button_control();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}

		private void cmb_pur_no_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_pur_no.SelectedIndex == -1) return;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                select_pur_vendor();
                button_control();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		
        }

        private void cmb_vendor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_vendor.SelectedIndex == -1) return;
            button_control();
        }

		#endregion 

		#endregion 

		#region DB컨넥트
        private void Get_pur_order(string arg_factory, string arg_pur_no, string arg_pur_user)
        {
            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_PUR_02.NEW_CREATE_SXP_PUR";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_PUR_NO";
            MyOraDB.Parameter_Name[2] = "ARG_PUR_USER";
            MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_pur_no;
            MyOraDB.Parameter_Values[2] = arg_pur_user;
            MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;
                        
            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

        }

        private DataTable Select_sxd_m_vendor(string arg_pur_no, string arg_mat)
        {
            string Proc_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXD_VENDOR_LIKE";

            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_pur_no";
            MyOraDB.Parameter_Name[2] = "arg_mat_cd";
            MyOraDB.Parameter_Name[3] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = ClassLib.ComVar.This_CDC_Factory;
            MyOraDB.Parameter_Values[1] = arg_pur_no;
            MyOraDB.Parameter_Values[2] = arg_mat;
            MyOraDB.Parameter_Values[3] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }

		private DataTable Select_sxp_pur_user()
		{
			string Proc_Name = "PKG_SXP_PUR_01_SELECT.SELECT_SXP_PURUSER";

			MyOraDB.ReDim_Parameter(2);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "arg_factory";
			MyOraDB.Parameter_Name[1] = "out_cursor";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private DataTable get_pur_no()
		{
			string Proc_Name = "PKG_SXP_PUR_02_SELECT.GET_SXP_PUR_NO";

			MyOraDB.ReDim_Parameter(6);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "arg_factory";
			MyOraDB.Parameter_Name[1] = "arg_pur_user";
			MyOraDB.Parameter_Name[2] = "arg_get_from";
			MyOraDB.Parameter_Name[3] = "arg_get_to";
			MyOraDB.Parameter_Name[4] = "arg_status";
			MyOraDB.Parameter_Name[5] = "out_cursor";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_pur_user.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = dpk_get_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3] = dpk_get_to.Value.ToString("yyyyMMdd");


            
			try
			{
				MyOraDB.Parameter_Values[4] = cmb_status.SelectedValue.ToString();
			}
			catch
			{
				MyOraDB.Parameter_Values[4] = " ";
			}
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private DataTable Search_pur_order(string arg_factory, string arg_pur_user, string arg_get_from, string arg_get_to,
			string arg_status, string arg_pur_no, string arg_data_type, string  arg_pur_div, string arg_ven_seq,
			string arg_style_name, string arg_mat_name, string arg_srf_no)
		{

			DataSet ds_Search ; 

			MyOraDB.ReDim_Parameter(13);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXP_PUR_ORDER" ; 

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[2] = "ARG_GET_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_GET_TO";
			MyOraDB.Parameter_Name[4] = "ARG_STATUS";
			MyOraDB.Parameter_Name[5] = "ARG_PUR_NO";
			MyOraDB.Parameter_Name[6] = "ARG_mrp_req_flg";
			MyOraDB.Parameter_Name[7] = "ARG_PUR_DIV";
			MyOraDB.Parameter_Name[8] = "ARG_VEN_SEQ";
			MyOraDB.Parameter_Name[9] = "ARG_STYLE_NAME";
			MyOraDB.Parameter_Name[10] = "ARG_MAT_NAME";
			MyOraDB.Parameter_Name[11] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[12] = "OUT_CURSOR";

			//03. DATA TYPE 정의
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
			MyOraDB.Parameter_Type[12] = (int)OracleType.Cursor; 

			//04. DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_pur_user;
			MyOraDB.Parameter_Values[2] = arg_get_from;
			MyOraDB.Parameter_Values[3] = arg_get_to;
			MyOraDB.Parameter_Values[4] = arg_status;
			MyOraDB.Parameter_Values[5] = arg_pur_no;
			MyOraDB.Parameter_Values[6] = arg_data_type;
			MyOraDB.Parameter_Values[7] = arg_pur_div;
			MyOraDB.Parameter_Values[8] = arg_ven_seq;
			MyOraDB.Parameter_Values[9] = arg_style_name;
			MyOraDB.Parameter_Values[10] = arg_mat_name;
			MyOraDB.Parameter_Values[11] = arg_srf_no;
			MyOraDB.Parameter_Values[12] = "";




			MyOraDB.Add_Select_Parameter(true);
			ds_Search = MyOraDB.Exe_Select_Procedure();	

			return ds_Search.Tables[MyOraDB.Process_Name];

		}

		private DataTable create_pur_no(string arg_factory)
		{

			DataSet ds_Search ; 

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.CREATE_SXP_PUR_NO" ; 

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03. DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

			//04. DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = "";




			MyOraDB.Add_Select_Parameter(true);
			ds_Search = MyOraDB.Exe_Select_Procedure();	

			return ds_Search.Tables[MyOraDB.Process_Name];

		}
		
		private DataTable check_pur_status(string arg_factory, string arg_pur_no)
		{

			MyOraDB.ReDim_Parameter(3);

			string Proc_Name = "PKG_SXP_PUR_02.CHECK_SXP_PUR_STATUS" ; 

			//01.PROCEDURE명
			MyOraDB.Process_Name = Proc_Name;

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_NO";	
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03. DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04. DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_pur_no;
			MyOraDB.Parameter_Values[2] = "";


			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
		
			return DS_Ret.Tables[Proc_Name];




		}

		private void comfirm_pur_no(string arg_factory, string arg_pur_user, string arg_get_from, string arg_get_to, string arg_pur_no, string arg_mrp_req_no, string arg_pur_div)
		{

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXP_PUR_02.COMFIRM_SXP_PUR_ORDER" ; 

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[2] = "ARG_GET_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_GET_TO";
			MyOraDB.Parameter_Name[4] = "ARG_PUR_NO";
			MyOraDB.Parameter_Name[5] = "ARG_MRP_REQ_FLG";
			MyOraDB.Parameter_Name[6] = "ARG_PUR_DIV";
			MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

			//03. DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;

			//04. DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_pur_user;
			MyOraDB.Parameter_Values[2] = arg_get_from;
			MyOraDB.Parameter_Values[3] = arg_get_to;
			MyOraDB.Parameter_Values[4] = arg_pur_no;
			MyOraDB.Parameter_Values[5] = arg_mrp_req_no;
			MyOraDB.Parameter_Values[6] = arg_pur_div;
			MyOraDB.Parameter_Values[7] = COM.ComVar.This_User;




			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();

		}

		private void select_pur_vendor()
		{

			DataSet ds_Search ; 

			MyOraDB.ReDim_Parameter(9);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXP_PUR_02_SELECT.SELECT_SXP_PUR_VENDOR" ; 

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[2] = "ARG_GET_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_GET_TO";
			MyOraDB.Parameter_Name[4] = "ARG_STATUS";
			MyOraDB.Parameter_Name[5] = "ARG_PUR_NO";
			MyOraDB.Parameter_Name[6] = "ARG_MRP_REQ_FLG";
			MyOraDB.Parameter_Name[7] = "ARG_PUR_DIV";
			MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

			//03. DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor; 

			//04. DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_pur_user.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = dpk_get_from.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3] = dpk_get_to.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[4] = cmb_status.SelectedValue.ToString();
			MyOraDB.Parameter_Values[5] = cmb_pur_no.SelectedValue.ToString();
			MyOraDB.Parameter_Values[6] = cmb_data_type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[7] = cmb_pur_div.SelectedValue.ToString();
			MyOraDB.Parameter_Values[8] = "";

			MyOraDB.Add_Select_Parameter(true);
			ds_Search = MyOraDB.Exe_Select_Procedure();	

			DataTable dt = ds_Search.Tables[MyOraDB.Process_Name];

            try
            {
                ClassLib.ComCtl.Set_ComboList_AddItem(dt, cmb_vendor, true, 0, 1, 0, 211);
                cmb_vendor.SelectedIndex = 0;
            }
            catch
            {
 
            }

		}
		#endregion 

		private void Form_Pur_Order_Load(object sender, System.EventArgs e)
		{
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
			ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
			//Init_Form();
		}	

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_factory.SelectedIndex == -1) return;
                COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
                Init_Form();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}

        private void btn_check_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //행 수정 상태 해제
                flg_pur_order.Select(flg_pur_order.Selection.r1, 0, flg_pur_order.Selection.r1, flg_pur_order.Cols.Count - 1, false);
                

                string mrd_Filename = "";
                string sPara = "";
           
                mrd_Filename = Application.StartupPath + @"\Purchase_List_Check" + ".mrd";
                sPara = " /rp " + "[" + cmb_factory.SelectedValue.ToString() + "]" + " [" + dpk_get_from.Text.Replace("-", "") + "]" + " [" + dpk_get_to.Text.Replace("-", "") + "]" + " [" + cmb_pur_no.SelectedValue.ToString() + "]" + " [" + cmb_vendor.SelectedValue.ToString() + "]";
               

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void flg_pur_order_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void flg_pur_order_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void flg_pur_order_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

       
        
	}
}

