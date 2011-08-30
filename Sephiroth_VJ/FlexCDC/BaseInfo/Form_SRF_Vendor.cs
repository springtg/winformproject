using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using System.Reflection;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;
using System.Threading;

namespace FlexCDC.BaseInfo
{
	public class Form_SRF_Vendor : COM.CDCWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정의

		public System.Windows.Forms.Panel pnl_Top;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_openfile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_title;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.TextBox txt_Vendor_Desc;
		private System.Windows.Forms.Label lbl_VenderDesc;
		private System.Windows.Forms.Label lbl_VendorSEQ;
		private System.Windows.Forms.TextBox txt_Vendor_SEQ;
        private System.Windows.Forms.ContextMenu ctm_menu;
		private C1.Win.C1List.C1Combo cmb_CSC_Vendor;
		private System.Windows.Forms.TextBox txt_CSC_Vendor;
		private System.Windows.Forms.Label lbl_CSCVendor;
        private System.Windows.Forms.MenuItem mnu_Vendor;
        private C1.Win.C1List.C1Combo cmb_Search;
        private Label lbl_Search;
        private CheckBox chk_Use;
        private MenuItem mnu_Web_Information;
		private System.ComponentModel.IContainer components = null;

		public Form_SRF_Vendor()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SRF_Vendor));
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.cmb_CSC_Vendor = new C1.Win.C1List.C1Combo();
            this.lbl_VendorSEQ = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.chk_Use = new System.Windows.Forms.CheckBox();
            this.cmb_Search = new C1.Win.C1List.C1Combo();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txt_CSC_Vendor = new System.Windows.Forms.TextBox();
            this.lbl_CSCVendor = new System.Windows.Forms.Label();
            this.txt_Vendor_SEQ = new System.Windows.Forms.TextBox();
            this.txt_Vendor_Desc = new System.Windows.Forms.TextBox();
            this.lbl_VenderDesc = new System.Windows.Forms.Label();
            this.btn_openfile = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.FSP();
            this.ctm_menu = new System.Windows.Forms.ContextMenu();
            this.mnu_Vendor = new System.Windows.Forms.MenuItem();
            this.mnu_Web_Information = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CSC_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
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
            this.tbtn_New.Text = "";
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Text = "";
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Text = "";
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // tbtn_Append
            // 
            this.tbtn_Append.Text = "";
            // 
            // tbtn_Insert
            // 
            this.tbtn_Insert.Text = "";
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Text = "";
            // 
            // c1CommandLink8
            // 
            this.c1CommandLink8.Text = "Confirm";
            // 
            // tbtn_Color
            // 
            this.tbtn_Color.Text = "";
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Text = "";
            // 
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.cmb_CSC_Vendor);
            this.pnl_Top.Controls.Add(this.lbl_VendorSEQ);
            this.pnl_Top.Controls.Add(this.cmb_Factory);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 64);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 96);
            this.pnl_Top.TabIndex = 137;
            // 
            // cmb_CSC_Vendor
            // 
            this.cmb_CSC_Vendor.AddItemCols = 0;
            this.cmb_CSC_Vendor.AddItemSeparator = ';';
            this.cmb_CSC_Vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_CSC_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_CSC_Vendor.Caption = "";
            this.cmb_CSC_Vendor.CaptionHeight = 17;
            this.cmb_CSC_Vendor.CaptionStyle = style25;
            this.cmb_CSC_Vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_CSC_Vendor.ColumnCaptionHeight = 18;
            this.cmb_CSC_Vendor.ColumnFooterHeight = 18;
            this.cmb_CSC_Vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_CSC_Vendor.ContentHeight = 16;
            this.cmb_CSC_Vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_CSC_Vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_CSC_Vendor.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CSC_Vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_CSC_Vendor.EditorHeight = 16;
            this.cmb_CSC_Vendor.EvenRowStyle = style26;
            this.cmb_CSC_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CSC_Vendor.FooterStyle = style27;
            this.cmb_CSC_Vendor.GapHeight = 2;
            this.cmb_CSC_Vendor.HeadingStyle = style28;
            this.cmb_CSC_Vendor.HighLightRowStyle = style29;
            this.cmb_CSC_Vendor.ItemHeight = 15;
            this.cmb_CSC_Vendor.Location = new System.Drawing.Point(853, 58);
            this.cmb_CSC_Vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_CSC_Vendor.MaxDropDownItems = ((short)(5));
            this.cmb_CSC_Vendor.MaxLength = 32767;
            this.cmb_CSC_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_CSC_Vendor.Name = "cmb_CSC_Vendor";
            this.cmb_CSC_Vendor.OddRowStyle = style30;
            this.cmb_CSC_Vendor.PartialRightColumn = false;
            this.cmb_CSC_Vendor.PropBag = resources.GetString("cmb_CSC_Vendor.PropBag");
            this.cmb_CSC_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_CSC_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_CSC_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_CSC_Vendor.SelectedStyle = style31;
            this.cmb_CSC_Vendor.Size = new System.Drawing.Size(150, 20);
            this.cmb_CSC_Vendor.Style = style32;
            this.cmb_CSC_Vendor.TabIndex = 345;
            this.cmb_CSC_Vendor.SelectedValueChanged += new System.EventHandler(this.cmb_CDC_Vendor_SelectedValueChanged);
            // 
            // lbl_VendorSEQ
            // 
            this.lbl_VendorSEQ.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_VendorSEQ.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VendorSEQ.ImageIndex = 0;
            this.lbl_VendorSEQ.ImageList = this.img_Label;
            this.lbl_VendorSEQ.Location = new System.Drawing.Point(16, 58);
            this.lbl_VendorSEQ.Name = "lbl_VendorSEQ";
            this.lbl_VendorSEQ.Size = new System.Drawing.Size(100, 21);
            this.lbl_VendorSEQ.TabIndex = 344;
            this.lbl_VendorSEQ.Tag = "1";
            this.lbl_VendorSEQ.Text = "Vendor Seq";
            this.lbl_VendorSEQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style33;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 16;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.EvenRowStyle = style34;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style35;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style36;
            this.cmb_Factory.HighLightRowStyle = style37;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(117, 35);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style38;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style39;
            this.cmb_Factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_Factory.Style = style40;
            this.cmb_Factory.TabIndex = 272;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 35);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 271;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.chk_Use);
            this.pnl_SearchImage.Controls.Add(this.cmb_Search);
            this.pnl_SearchImage.Controls.Add(this.lbl_Search);
            this.pnl_SearchImage.Controls.Add(this.txt_CSC_Vendor);
            this.pnl_SearchImage.Controls.Add(this.lbl_CSCVendor);
            this.pnl_SearchImage.Controls.Add(this.txt_Vendor_SEQ);
            this.pnl_SearchImage.Controls.Add(this.txt_Vendor_Desc);
            this.pnl_SearchImage.Controls.Add(this.lbl_VenderDesc);
            this.pnl_SearchImage.Controls.Add(this.btn_openfile);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox3);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 88);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // chk_Use
            // 
            this.chk_Use.AutoSize = true;
            this.chk_Use.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Use.Location = new System.Drawing.Point(343, 35);
            this.chk_Use.Name = "chk_Use";
            this.chk_Use.Size = new System.Drawing.Size(51, 18);
            this.chk_Use.TabIndex = 549;
            this.chk_Use.Text = "Use";
            this.chk_Use.UseVisualStyleBackColor = true;
            // 
            // cmb_Search
            // 
            this.cmb_Search.AddItemCols = 0;
            this.cmb_Search.AddItemSeparator = ';';
            this.cmb_Search.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Search.Caption = "";
            this.cmb_Search.CaptionHeight = 17;
            this.cmb_Search.CaptionStyle = style41;
            this.cmb_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Search.ColumnCaptionHeight = 18;
            this.cmb_Search.ColumnFooterHeight = 18;
            this.cmb_Search.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Search.ContentHeight = 16;
            this.cmb_Search.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Search.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Search.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Search.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Search.EditorHeight = 16;
            this.cmb_Search.EvenRowStyle = style42;
            this.cmb_Search.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Search.FooterStyle = style43;
            this.cmb_Search.GapHeight = 2;
            this.cmb_Search.HeadingStyle = style44;
            this.cmb_Search.HighLightRowStyle = style45;
            this.cmb_Search.ItemHeight = 15;
            this.cmb_Search.Location = new System.Drawing.Point(775, 35);
            this.cmb_Search.MatchEntryTimeout = ((long)(2000));
            this.cmb_Search.MaxDropDownItems = ((short)(5));
            this.cmb_Search.MaxLength = 32767;
            this.cmb_Search.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Search.Name = "cmb_Search";
            this.cmb_Search.OddRowStyle = style46;
            this.cmb_Search.PartialRightColumn = false;
            this.cmb_Search.PropBag = resources.GetString("cmb_Search.PropBag");
            this.cmb_Search.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Search.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Search.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Search.SelectedStyle = style47;
            this.cmb_Search.Size = new System.Drawing.Size(220, 20);
            this.cmb_Search.Style = style48;
            this.cmb_Search.TabIndex = 347;
            // 
            // lbl_Search
            // 
            this.lbl_Search.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.ImageIndex = 0;
            this.lbl_Search.ImageList = this.img_Label;
            this.lbl_Search.Location = new System.Drawing.Point(674, 35);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(100, 21);
            this.lbl_Search.TabIndex = 346;
            this.lbl_Search.Tag = "0";
            this.lbl_Search.Text = "Option";
            this.lbl_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_CSC_Vendor
            // 
            this.txt_CSC_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CSC_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CSC_Vendor.Location = new System.Drawing.Point(775, 58);
            this.txt_CSC_Vendor.Name = "txt_CSC_Vendor";
            this.txt_CSC_Vendor.Size = new System.Drawing.Size(69, 21);
            this.txt_CSC_Vendor.TabIndex = 548;
            this.txt_CSC_Vendor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_CDC_Vendor_KeyUp);
            // 
            // lbl_CSCVendor
            // 
            this.lbl_CSCVendor.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_CSCVendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CSCVendor.ImageIndex = 0;
            this.lbl_CSCVendor.ImageList = this.img_Label;
            this.lbl_CSCVendor.Location = new System.Drawing.Point(674, 58);
            this.lbl_CSCVendor.Name = "lbl_CSCVendor";
            this.lbl_CSCVendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_CSCVendor.TabIndex = 545;
            this.lbl_CSCVendor.Tag = "1";
            this.lbl_CSCVendor.Text = "Web Vendor";
            this.lbl_CSCVendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Vendor_SEQ
            // 
            this.txt_Vendor_SEQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Vendor_SEQ.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Vendor_SEQ.Location = new System.Drawing.Point(109, 58);
            this.txt_Vendor_SEQ.Name = "txt_Vendor_SEQ";
            this.txt_Vendor_SEQ.Size = new System.Drawing.Size(210, 21);
            this.txt_Vendor_SEQ.TabIndex = 544;
            // 
            // txt_Vendor_Desc
            // 
            this.txt_Vendor_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Vendor_Desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Vendor_Desc.Location = new System.Drawing.Point(441, 58);
            this.txt_Vendor_Desc.Name = "txt_Vendor_Desc";
            this.txt_Vendor_Desc.Size = new System.Drawing.Size(210, 21);
            this.txt_Vendor_Desc.TabIndex = 543;
            // 
            // lbl_VenderDesc
            // 
            this.lbl_VenderDesc.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_VenderDesc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VenderDesc.ImageIndex = 0;
            this.lbl_VenderDesc.ImageList = this.img_Label;
            this.lbl_VenderDesc.Location = new System.Drawing.Point(340, 58);
            this.lbl_VenderDesc.Name = "lbl_VenderDesc";
            this.lbl_VenderDesc.Size = new System.Drawing.Size(100, 21);
            this.lbl_VenderDesc.TabIndex = 542;
            this.lbl_VenderDesc.Tag = "1";
            this.lbl_VenderDesc.Text = "Vendor Desc";
            this.lbl_VenderDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.picb_MR.Size = new System.Drawing.Size(24, 45);
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
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(212, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1000, 40);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
            this.lbl_title.Location = new System.Drawing.Point(0, 5);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(231, 30);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Text = "         Search Vendor";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 73);
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
            this.pictureBox5.Location = new System.Drawing.Point(136, 72);
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
            this.pictureBox6.Location = new System.Drawing.Point(0, 73);
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
            this.pictureBox7.Size = new System.Drawing.Size(168, 55);
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
            this.pictureBox8.Location = new System.Drawing.Point(152, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1000, 48);
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
            this.pictureBox9.Size = new System.Drawing.Size(1000, 48);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Body.Controls.Add(this.fgrid_Main);
            this.pnl_Body.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Body.Location = new System.Drawing.Point(0, 160);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(1016, 483);
            this.pnl_Body.TabIndex = 138;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_Main.AutoResize = false;
            this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Main.ContextMenu = this.ctm_menu;
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.fgrid_Main.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.Fixed = 0;
            this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Main.Size = new System.Drawing.Size(1016, 483);
            this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Main.Styles"));
            this.fgrid_Main.TabIndex = 318;
            this.fgrid_Main.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Main_AfterSelChange);
            this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
            this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
            this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
            // 
            // ctm_menu
            // 
            this.ctm_menu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_Vendor,
            this.mnu_Web_Information});
            // 
            // mnu_Vendor
            // 
            this.mnu_Vendor.Index = 0;
            this.mnu_Vendor.Text = "Vendor";
            this.mnu_Vendor.Click += new System.EventHandler(this.mnu_Vendor_Click);
            // 
            // mnu_Web_Information
            // 
            this.mnu_Web_Information.Index = 1;
            this.mnu_Web_Information.Text = "Web Infomation";
            this.mnu_Web_Information.Click += new System.EventHandler(this.mnu_Web_Information_Click);
            // 
            // Form_SRF_Vendor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.ContextMenu = this.ctm_menu;
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Form_SRF_Vendor";
            this.Load += new System.EventHandler(this.Form_SRF_Vendor_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CSC_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수 

		private COM.OraDB MyOraDB    = new COM.OraDB();		
		private int _custCdCol		 = (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_CD;		

		#endregion

		#region 공통 메서드 

		private void Init_Form()
		{
			
			this.Text = "PCC_Vendor Master";
			this.lbl_MainTitle.Text = "PCC_Vendor Master";
			this.lbl_title.Text = "      Vendor Information";

			ClassLib.ComFunction.SetLangDic(this);

			#region Button Setting
			tbtn_Delete.Enabled = false;
			tbtn_Print.Enabled  = false;
			tbtn_Color.Enabled  = false;			
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			#endregion						

			#region ComboBox Setting				
			//CDC Vendor Setting 
			DataTable dt_ret = Select_Cust_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_CSC_Vendor, 0, 1, true, 0, 220);			
			cmb_CSC_Vendor.SelectedIndex = 0;

			dt_ret.Dispose();



            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), "SXB02");
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Search, 1, 2, false,0, 320);
            cmb_Search.SelectedIndex = 0;
            
            #endregion

			#region Grid Setting 
			fgrid_Main.Set_Grid_CDC("SXD_SRF_M_VENDOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Main.Set_Action_Image(img_Action);
			fgrid_Main.Font =new Font("Verdana", 8);			
			#endregion			

			#region TextBox Setting			
			txt_Vendor_SEQ.CharacterCasing  = CharacterCasing.Upper;
			txt_Vendor_Desc.CharacterCasing = CharacterCasing.Upper;
			txt_CSC_Vendor.CharacterCasing  = CharacterCasing.Upper;
			txt_Vendor_SEQ.Focus();
			#endregion


           

		}

		private void Display_Grid(DataTable arg_list, COM.FSP arg_fgrid)
		{		
			for(int i=0; i< arg_list.Rows.Count  ; i++)
			{				
				arg_fgrid.AddItem(arg_list.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);

                //cust cd 는 있고 cust name이 없을때
                if ((arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_CD].ToString().Length >= 1) &&
                                   (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_NAME].ToString().Length <= 1))
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 1, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Red;
			}
		}
	
		#endregion

		#region 이벤트 처리 
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(cmb_Factory.SelectedIndex == -1)
					return;

				COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();

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

		private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
			{
				if(fgrid_Main.Cols[fgrid_Main.Col].DataType == typeof(bool))
				{
					fgrid_Main.Buffer_CellData = "";
				}
				else
				{
					fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
				}
			}

		}

		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_Main.Update_Row();
		}

		private void fgrid_Main_AfterSelChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{

			ctm_menu.MenuItems[0].Visible  = false;   
		
			switch(fgrid_Main.Selection.c1)
			{

				case (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_CD : 	
				{
					ctm_menu.MenuItems[0].Text    = "Vendor";
					ctm_menu.MenuItems[0].Visible = true;
					break;
				}
				case (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_NAME : 	
				{
					ctm_menu.MenuItems[0].Text    = "Vendor";
					ctm_menu.MenuItems[0].Visible = true;
					break;
				}		
			
			}			
				
		}

		private void txt_CDC_Vendor_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			if(txt_CSC_Vendor.Text != null && e.KeyData == Keys.Enter)
			{
								
				DataTable dt_ret = ClassLib.ComFunction.Select_Cust_List(ClassLib.ComVar.This_Factory, txt_CSC_Vendor.Text);
				COM.ComCtl.Set_ComboList(dt_ret, cmb_CSC_Vendor, 0, 1, true, 0, 220);	
				cmb_CSC_Vendor.SelectedIndex =0;
				if(dt_ret != null)
					dt_ret.Dispose();									
			}		
		
		}

		private void cmb_CDC_Vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{

			if(cmb_CSC_Vendor.SelectedValue != null)
				txt_CSC_Vendor.Text = cmb_CSC_Vendor.SelectedValue.ToString().Trim();				
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Init_Form();
			txt_Vendor_SEQ.Clear();
			txt_Vendor_Desc.Clear();

			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
		}
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{			
				this.Cursor = Cursors.WaitCursor;
                string vExist_CSC_Vendor = "";

                string vOption = cmb_Search.SelectedValue.ToString();
				fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;				
				
				DataTable dt_ret;					 
				dt_ret = Select_Item(cmb_Factory.SelectedValue.ToString(), ClassLib.ComFunction.Empty_TextBox(txt_Vendor_SEQ, ""), ClassLib.ComFunction.Empty_TextBox(txt_Vendor_Desc,""),  ClassLib.ComFunction.Empty_TextBox( txt_CSC_Vendor, ""), vOption);

				Display_Grid(dt_ret, fgrid_Main); 				
				
				
				dt_ret.Dispose();					
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);               
			}
			catch
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this);
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

				//행 수정 상태 해제
				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count - 1, false);  
					
				for(int i = fgrid_Main.Rows.Fixed ; i < fgrid_Main.Rows.Count ;i++)
				{
					if(fgrid_Main[ i, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxDIVISION] != null && fgrid_Main[ i, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxDIVISION].ToString() != "")										
						Update_Item(i);					
				}

                tbtn_Search_Click(null, null);
			}
			catch
			{
				this.Cursor = Cursors.Default;				
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
			}		
					
		}


        private void fgrid_Main_Click(object sender, EventArgs e)
        {
            mnu_Vendor.Visible = false;
            mnu_Web_Information.Visible = false;


            if ((fgrid_Main.Selection.c1 >= (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_CD) &&
                (fgrid_Main.Selection.c1 <= (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_NAME))
            {
                mnu_Vendor.Visible = true;

            }


            if ((fgrid_Main.Selection.c1 >= (int)ClassLib.TBSXD_SRF_M_VENDOR.lxCUST_WEB_ID) &&
               (fgrid_Main.Selection.c1 <= (int)ClassLib.TBSXD_SRF_M_VENDOR.lxCUST_WEB_PASS))
            {

                if (ClassLib.ComVar.This_Factory == "DS") return;

                if ((fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_CD].ToString() == null) ||
               (fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_CD].ToString() == "")) return;

                mnu_Web_Information.Visible = true;

            }

        }



		private void mnu_Vendor_Click(object sender, System.EventArgs e)
		{
			FlexCDC.BaseInfo.Pop_Common_Combo_v pop_vendor = new Pop_Common_Combo_v(this);			
            pop_vendor.ShowDialog();		
		}



        private void mnu_Web_Information_Click(object sender, EventArgs e)
        {
            int sct_row = fgrid_Main.Selection.r1;
            int sct_col = fgrid_Main.Selection.c1;

            FlexCDC.BaseInfo.Pop_Vendor_Web pop_web = new Pop_Vendor_Web(this);
            COM.ComVar.Parameter_PopUp = new string[5];
            COM.ComVar.Parameter_PopUp[0] = cmb_Factory.SelectedValue.ToString();
            COM.ComVar.Parameter_PopUp[1] = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_CD].ToString();
            COM.ComVar.Parameter_PopUp[2] = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_NAME].ToString();
            COM.ComVar.Parameter_PopUp[3] = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSXD_SRF_M_VENDOR.lxCUST_WEB_ID].ToString();
            COM.ComVar.Parameter_PopUp[4] = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSXD_SRF_M_VENDOR.lxCUST_WEB_PASS].ToString();   
         
            pop_web.ShowDialog();

            if (!pop_web._save_flg)
                return;

            tbtn_Search_Click(null, null);
            fgrid_Main.Select(sct_row, sct_col);
        }	

		#endregion

		#region DB Connect
		private DataTable Select_Cust_List()
		{		
			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXC_COMMON.SELECT_SCM_CUST_LIKE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[1] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;		
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_CSC_Vendor, "");
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];
		}
		private DataTable Select_Item(string arg_factory,string arg_ven_seq, string arg_vendor_desc, string arg_cdc_vendor, string arg_option)
		{		

			
			DataSet ds_list;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_VENDOR";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_VEN_SEQ";
			MyOraDB.Parameter_Name[2] = "ARG_VENDOR_DESC";
			MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
            MyOraDB.Parameter_Name[4] = "ARG_USE_YN";
			MyOraDB.Parameter_Name[5] = "ARG_OPTION";
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
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_Vendor_SEQ, arg_ven_seq);
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_TextBox(txt_Vendor_Desc, arg_vendor_desc);
			MyOraDB.Parameter_Values[3] = arg_cdc_vendor;
            MyOraDB.Parameter_Values[4] = (chk_Use.Checked == true) ? "Y" : " ";
            MyOraDB.Parameter_Values[5] = arg_option;
			MyOraDB.Parameter_Values[6] = "";



			MyOraDB.Add_Select_Parameter(true);
			ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];

		}

		private void Update_Item(int row_cnt)
		{

			MyOraDB.ReDim_Parameter(12);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SAVE_SXD_SRF_M_VENDOR";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_VEN_SEQ";
			MyOraDB.Parameter_Name[3]  = "ARG_VENDOR_DESC";
			MyOraDB.Parameter_Name[4]  = "ARG_POPULA_NAME";
			MyOraDB.Parameter_Name[5]  = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[6]  = "ARG_CUST_NAME";
			MyOraDB.Parameter_Name[7]  = "ARG_EMAIL";
			MyOraDB.Parameter_Name[8]  = "ARG_NIKE_FLG";
            MyOraDB.Parameter_Name[9]  = "ARG_USE_YN";	
			MyOraDB.Parameter_Name[10]  = "ARG_STATUS";
			MyOraDB.Parameter_Name[11] = "ARG_UPD_USER";			

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11]  = (int)OracleType.VarChar;			

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxDIVISION].ToString();
			MyOraDB.Parameter_Values[1] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxFACTORY].ToString();
			MyOraDB.Parameter_Values[2] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxVEN_SEQ].ToString();
			MyOraDB.Parameter_Values[3] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxVENDOR_DESC].ToString();
			MyOraDB.Parameter_Values[4] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxPOPULA_NAME].ToString();
			MyOraDB.Parameter_Values[5] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_CD].ToString();
			MyOraDB.Parameter_Values[6] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxCUST_NAME].ToString();
			MyOraDB.Parameter_Values[7] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxEMAIL].ToString();
			MyOraDB.Parameter_Values[8] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxNIKE_FLG].ToString();
            MyOraDB.Parameter_Values[9] = fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_VENDOR.IxUSE_YN].ToString();
			MyOraDB.Parameter_Values[10] = "";
			MyOraDB.Parameter_Values[11] = ClassLib.ComVar.This_User;
			
			
			MyOraDB.Add_Modify_Parameter(true);
			DataSet ds_list = MyOraDB.Exe_Modify_Procedure();		

			
		}
		

		#endregion 

		private void Form_SRF_Vendor_Load(object sender, System.EventArgs e)    
		{
			try
			{
				//factory
				DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
				COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;                
			}
			catch
			{

			}
		}

      
       
	}
}

