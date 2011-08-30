using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;


namespace FlexCDC.Incomming
{

	
	public class Form_Barcode_Incomming_List : COM.PCHWinForm.Pop_Large_B
	{
		#region 컨트롤 정의 및 리소스 정의
		public System.Windows.Forms.Panel pnl_Top;
		private System.Windows.Forms.Label lbl_MaterialName;
		private System.Windows.Forms.DateTimePicker dtp_Fin_Ymd;
        private System.Windows.Forms.DateTimePicker dtp_Std_Ymd;
		private System.Windows.Forms.Label lbl_Vendor;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label lbl;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		public System.Windows.Forms.Label lbl_SubTitle;
		private System.Windows.Forms.Label lbl_Barcode;
		private System.Windows.Forms.Label lbl_ScanDate;		
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.TextBox txt_Barcode;
		private System.Windows.Forms.TextBox txt_MatName;
		private System.Windows.Forms.ContextMenu ctMnu01;
		private System.Windows.Forms.MenuItem mnu_Mat;
		private System.Windows.Forms.MenuItem mnu_Bom;
        private C1.Win.C1List.C1Combo cmb_Vendor;
        private C1.Win.C1List.C1Combo cmb_Factory;
		public Incomming.Form_Incomming_Manager arg_request = null;  


		public Form_Barcode_Incomming_List()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		public Form_Barcode_Incomming_List(Incomming.Form_Incomming_Manager arg_request1)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			  arg_request = arg_request1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Barcode_Incomming_List));
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.cmb_Vendor = new C1.Win.C1List.C1Combo();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.txt_MatName = new System.Windows.Forms.TextBox();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.lbl_MaterialName = new System.Windows.Forms.Label();
            this.lbl_Barcode = new System.Windows.Forms.Label();
            this.dtp_Fin_Ymd = new System.Windows.Forms.DateTimePicker();
            this.dtp_Std_Ymd = new System.Windows.Forms.DateTimePicker();
            this.lbl_ScanDate = new System.Windows.Forms.Label();
            this.lbl_Vendor = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.FSP();
            this.ctMnu01 = new System.Windows.Forms.ContextMenu();
            this.mnu_Mat = new System.Windows.Forms.MenuItem();
            this.mnu_Bom = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // c1ToolBar1
            // 
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink7});
            this.c1ToolBar1.Location = new System.Drawing.Point(605, 4);
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.tbtn_New);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Search);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Save);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Append);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Insert);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Delete);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Create);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Color);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Print);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Conform);
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
            // tbtn_Delete
            // 
            this.tbtn_Delete.Text = "";
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(828, 23);
            // 
            // tbtn_Create
            // 
            this.tbtn_Create.Text = "";
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Text = "";
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
            // tbtn_Conform
            // 
            this.tbtn_Conform.Text = "";
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
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.cmb_Vendor);
            this.pnl_Top.Controls.Add(this.cmb_Factory);
            this.pnl_Top.Controls.Add(this.txt_MatName);
            this.pnl_Top.Controls.Add(this.txt_Barcode);
            this.pnl_Top.Controls.Add(this.lbl_MaterialName);
            this.pnl_Top.Controls.Add(this.lbl_Barcode);
            this.pnl_Top.Controls.Add(this.dtp_Fin_Ymd);
            this.pnl_Top.Controls.Add(this.dtp_Std_Ymd);
            this.pnl_Top.Controls.Add(this.lbl_ScanDate);
            this.pnl_Top.Controls.Add(this.lbl_Vendor);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 64);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(892, 95);
            this.pnl_Top.TabIndex = 127;
            // 
            // cmb_Vendor
            // 
            this.cmb_Vendor.AddItemSeparator = ';';
            this.cmb_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Vendor.Caption = "";
            this.cmb_Vendor.CaptionHeight = 17;
            this.cmb_Vendor.CaptionStyle = style1;
            this.cmb_Vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Vendor.ColumnCaptionHeight = 18;
            this.cmb_Vendor.ColumnFooterHeight = 18;
            this.cmb_Vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Vendor.ContentHeight = 16;
            this.cmb_Vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Vendor.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Vendor.EditorHeight = 16;
            this.cmb_Vendor.EvenRowStyle = style2;
            this.cmb_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.FooterStyle = style3;
            this.cmb_Vendor.HeadingStyle = style4;
            this.cmb_Vendor.HighLightRowStyle = style5;
            this.cmb_Vendor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Vendor.Images"))));
            this.cmb_Vendor.ItemHeight = 15;
            this.cmb_Vendor.Location = new System.Drawing.Point(117, 58);
            this.cmb_Vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_Vendor.MaxDropDownItems = ((short)(5));
            this.cmb_Vendor.MaxLength = 32767;
            this.cmb_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Vendor.Name = "cmb_Vendor";
            this.cmb_Vendor.OddRowStyle = style6;
            this.cmb_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.SelectedStyle = style7;
            this.cmb_Vendor.Size = new System.Drawing.Size(160, 20);
            this.cmb_Vendor.Style = style8;
            this.cmb_Vendor.TabIndex = 284;
            this.cmb_Vendor.PropBag = resources.GetString("cmb_Vendor.PropBag");
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style9;
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
            this.cmb_Factory.EvenRowStyle = style10;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style11;
            this.cmb_Factory.HeadingStyle = style12;
            this.cmb_Factory.HighLightRowStyle = style13;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(117, 36);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style14;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style15;
            this.cmb_Factory.Size = new System.Drawing.Size(160, 20);
            this.cmb_Factory.Style = style16;
            this.cmb_Factory.TabIndex = 283;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // txt_MatName
            // 
            this.txt_MatName.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MatName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_MatName.Location = new System.Drawing.Point(386, 58);
            this.txt_MatName.MaxLength = 100;
            this.txt_MatName.Name = "txt_MatName";
            this.txt_MatName.Size = new System.Drawing.Size(198, 21);
            this.txt_MatName.TabIndex = 277;
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Barcode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Barcode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Barcode.Location = new System.Drawing.Point(692, 36);
            this.txt_Barcode.MaxLength = 100;
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(160, 21);
            this.txt_Barcode.TabIndex = 0;
            this.txt_Barcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Barcode_KeyUp);
            // 
            // lbl_MaterialName
            // 
            this.lbl_MaterialName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaterialName.ImageIndex = 0;
            this.lbl_MaterialName.ImageList = this.img_Label;
            this.lbl_MaterialName.Location = new System.Drawing.Point(285, 58);
            this.lbl_MaterialName.Name = "lbl_MaterialName";
            this.lbl_MaterialName.Size = new System.Drawing.Size(100, 21);
            this.lbl_MaterialName.TabIndex = 274;
            this.lbl_MaterialName.Tag = "1";
            this.lbl_MaterialName.Text = "Material";
            this.lbl_MaterialName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Barcode
            // 
            this.lbl_Barcode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Barcode.ImageIndex = 0;
            this.lbl_Barcode.ImageList = this.img_Label;
            this.lbl_Barcode.Location = new System.Drawing.Point(591, 36);
            this.lbl_Barcode.Name = "lbl_Barcode";
            this.lbl_Barcode.Size = new System.Drawing.Size(100, 21);
            this.lbl_Barcode.TabIndex = 272;
            this.lbl_Barcode.Tag = "1";
            this.lbl_Barcode.Text = "Barcode";
            this.lbl_Barcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_Fin_Ymd
            // 
            this.dtp_Fin_Ymd.CustomFormat = "yyyyMMdd";
            this.dtp_Fin_Ymd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fin_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Fin_Ymd.Location = new System.Drawing.Point(495, 36);
            this.dtp_Fin_Ymd.Name = "dtp_Fin_Ymd";
            this.dtp_Fin_Ymd.Size = new System.Drawing.Size(91, 21);
            this.dtp_Fin_Ymd.TabIndex = 271;
            this.dtp_Fin_Ymd.CloseUp += new System.EventHandler(this.dtp_Fin_Ymd_CloseUp);
            // 
            // dtp_Std_Ymd
            // 
            this.dtp_Std_Ymd.CustomFormat = "yyyyMMdd";
            this.dtp_Std_Ymd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Std_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Std_Ymd.Location = new System.Drawing.Point(386, 36);
            this.dtp_Std_Ymd.Name = "dtp_Std_Ymd";
            this.dtp_Std_Ymd.Size = new System.Drawing.Size(91, 21);
            this.dtp_Std_Ymd.TabIndex = 270;
            this.dtp_Std_Ymd.CloseUp += new System.EventHandler(this.dtp_Std_Ymd_CloseUp);
            // 
            // lbl_ScanDate
            // 
            this.lbl_ScanDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScanDate.ImageIndex = 0;
            this.lbl_ScanDate.ImageList = this.img_Label;
            this.lbl_ScanDate.Location = new System.Drawing.Point(285, 36);
            this.lbl_ScanDate.Name = "lbl_ScanDate";
            this.lbl_ScanDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_ScanDate.TabIndex = 267;
            this.lbl_ScanDate.Tag = "1";
            this.lbl_ScanDate.Text = "Date";
            this.lbl_ScanDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Vendor
            // 
            this.lbl_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vendor.ImageIndex = 0;
            this.lbl_Vendor.ImageList = this.img_Label;
            this.lbl_Vendor.Location = new System.Drawing.Point(16, 58);
            this.lbl_Vendor.Name = "lbl_Vendor";
            this.lbl_Vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_Vendor.TabIndex = 204;
            this.lbl_Vendor.Tag = "1";
            this.lbl_Vendor.Text = "Vendor";
            this.lbl_Vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 36);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 203;
            this.lbl_factory.Tag = "1";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.lbl);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox3);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Controls.Add(this.pictureBox10);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(876, 87);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(471, 36);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(16, 16);
            this.lbl.TabIndex = 29;
            this.lbl.Text = "~";
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(859, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 44);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(860, 0);
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
            this.pictureBox3.Location = new System.Drawing.Point(224, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(876, 40);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_SubTitle
            // 
            this.lbl_SubTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle.Image")));
            this.lbl_SubTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle.Name = "lbl_SubTitle";
            this.lbl_SubTitle.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle.TabIndex = 28;
            this.lbl_SubTitle.Text = "      Barcode Information";
            this.lbl_SubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(860, 72);
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
            this.pictureBox5.Location = new System.Drawing.Point(144, 71);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(876, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 72);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 20);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(168, 54);
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(152, 24);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(876, 47);
            this.pictureBox10.TabIndex = 31;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 50);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 50);
            this.pictureBox9.TabIndex = 0;
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
            this.pnl_Body.Location = new System.Drawing.Point(0, 159);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(892, 460);
            this.pnl_Body.TabIndex = 141;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_Main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgrid_Main.AutoResize = false;
            this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Main.ContextMenu = this.ctMnu01;
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.fgrid_Main.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.DefaultSize = 18;
            this.fgrid_Main.Rows.Fixed = 0;
            this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Main.Size = new System.Drawing.Size(892, 460);
            this.fgrid_Main.StyleInfo = resources.GetString("fgrid_Main.StyleInfo");
            this.fgrid_Main.TabIndex = 318;
            this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
            this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
            this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
            this.fgrid_Main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_Main_KeyUp);
            // 
            // ctMnu01
            // 
            this.ctMnu01.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_Mat,
            this.mnu_Bom});
            // 
            // mnu_Mat
            // 
            this.mnu_Mat.Index = 0;
            this.mnu_Mat.Text = "Material";
            this.mnu_Mat.Click += new System.EventHandler(this.mnu_Mat_Click);
            // 
            // mnu_Bom
            // 
            this.mnu_Bom.Index = 1;
            this.mnu_Bom.Text = "BOM";
            this.mnu_Bom.Click += new System.EventHandler(this.mnu_Bom_Click);
            // 
            // Form_Barcode_Incomming_List
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(892, 619);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Form_Barcode_Incomming_List";
            this.Text = "Form_Barcode_Incomming_List";
            this.Load += new System.EventHandler(this.Pop_Barcode_List_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region  사용자 정의 변수 

	    private COM.OraDB MyOraDB = new COM.OraDB();
		private bool _New_flag = true;
        private bool _first_flg = true;
		#endregion

		#region 공통메서드

        #region Display 관련
        private void Init_Form()
		{
			this.Text               = "PCC_Barcode Incomming List";
			this.lbl_MainTitle.Text = "PCC_Barcode Incomming List";
			ClassLib.ComFunction.SetLangDic(this); 

			#region Button Setting			
			tbtn_Delete.Enabled  = false;
			tbtn_Color.Enabled   = false;
			//tbtn_Print.Enabled   = false;	
			tbtn_Conform.Enabled = false;
			tbtn_Create.Enabled  = false;	
			#endregion				

			#region ComboBox Setting
			  
			dtp_Std_Ymd.Value = DateTime.Today;
			dtp_Fin_Ymd.Value = DateTime.Today;

			//Vendor Setting 
			DataTable dt_ret = Select_Sxs_Bar_Vendor(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, ClassLib.ComFunction.Empty_TextBox(txt_Barcode, "") );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, 0, 200);
			cmb_Vendor.SelectedIndex = 0;
			
			dt_ret.Dispose();
			#endregion

			#region Grid Setting 
			fgrid_Main.Set_Grid_CDC("SXI_IN_LIST_PUR", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Main.Set_Action_Image(img_Action);
			fgrid_Main.Font =new Font("Verdana", 8);
			fgrid_Main.Tree.Column =  (int)ClassLib.TBSXI_IN_LIST_BAR.IxITEM01;
			#endregion	

			#region TextBox Setting		
			txt_Barcode.CharacterCasing = CharacterCasing.Upper;
			txt_MatName.CharacterCasing = CharacterCasing.Upper;
			txt_Barcode.Focus();	
			#endregion

            _first_flg = false;

			Display_Grid();
		}
		private void Display_Grid()
		{
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;			
			
			DataTable dt_list = Select_SXI_In_List_Bar( cmb_Factory.SelectedValue.ToString(),  dtp_Std_Ymd.Text,  dtp_Fin_Ymd.Text, txt_Barcode.Text , cmb_Vendor.SelectedValue.ToString(), txt_MatName.Text );
			
			for(int i=0; i < dt_list.Rows.Count; i++)
			{			
				int tree_level = int.Parse(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXI_IN_LIST_BAR.IxLEVEL].ToString());
				fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, tree_level);	
		
				#region Level에 따른 Edit & BackColor 설정 
				if(tree_level == 1)
				{
					fgrid_Main.Rows[fgrid_Main.Rows.Count -1].AllowEditing = true;
					fgrid_Main.Rows[fgrid_Main.Rows.Count -1].StyleNew.BackColor = Color.White;
				}
				else if( tree_level == 2 )
				{
					fgrid_Main.Rows[fgrid_Main.Rows.Count -1].AllowEditing = false;
					fgrid_Main.Rows[fgrid_Main.Rows.Count -1].StyleNew.BackColor = Color.WhiteSmoke;
				}
				#endregion 

				for(int j=0; j < dt_list.Columns.Count; j++)
				{
					fgrid_Main[fgrid_Main.Rows.Count-1,j] = dt_list.Rows[i].ItemArray[j].ToString();
				}
                fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG] = "true";	
			}
			
			fgrid_Main.Tree.Show(1);


        }
        #endregion

        #region Save 관련
        private void Save_Data()
		{		
			arg_request.fgrid_Main.Tree.Show(2);				

			#region 중복체크 			
			int row_count = fgrid_Main.Rows.Count;
			for(int i = 0; i< row_count ; i++)
			{
				if(fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG].ToString() == "True")
				{
					if(Grid_Add_Check(i) == false )
					{
						if(fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxLEVEL].ToString() == "1")
                            ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDuplication, this);
						
						fgrid_Main.Rows.Remove(i);
						
						i--;
						row_count--;			
					}
				}
			}
			#endregion

			#region Purchase List Grid Data --> Incomming Manager Grid 

			row_count = fgrid_Main.Rows.Count;
			for(int i = 0; i < row_count; i++)
			{
				if(fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG].ToString() == "True")
				{
					if(arg_request != null)
					{
						arg_request.tbtn_Save.Enabled=true;
						
						Grid_List_Add(i);
						
						fgrid_Main.Rows.Remove(i);
													
						i--;
						row_count--;						
					}
				}
			}

			#endregion

			arg_request.fgrid_Main.Tree.Show(1);
	
		}
		private bool Grid_Add_Check(int arg_rowcount) //중복검사
		{									
			#region Grid Data--> 변수		
			string buf_LEVEL          = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxLEVEL].ToString();   	      
//			string buf_PUR_NO         = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPUR_NO].ToString();
//			string buf_PUR_SEQ        = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPUR_SEQ].ToString();	
			string buf_BAR_CODE       = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString();	
			#endregion
									
			#region 중복검사
			for(int i = 0; i < arg_request.fgrid_Main.Rows.Count- 1 ; i++)
			{
				if(arg_request.fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxLEVEL].ToString()     == buf_LEVEL   && 				
					arg_request.fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST.IxBAR_CODE].ToString() == buf_BAR_CODE) 
				{					
					return false;
				}
			}	
			#endregion

			return true;		
		}		
		private void Grid_List_Add(int arg_rowcount)
		{		
			if(fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxLEVEL].ToString() == "1")
			{ 					
				#region Grid Data --> 변수 
				//string buf_STATUS         = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxSTATUS].ToString();   	      
				string buf_Y_FLG		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG].ToString();   	      
				string buf_LEVEL		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxLEVEL].ToString();   	      
				string buf_PUR_NO		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPUR_NO].ToString(); 
				string buf_PUR_SEQ		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPUR_SEQ].ToString();
				string buf_PUR_DIV		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPUR_DIV].ToString();
				string buf_ITEM01		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxITEM01].ToString();   	      
				string buf_ITEM02		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxITEM02].ToString();   	      
				string buf_ITEM03		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxITEM03].ToString();   	      
				string buf_ITEM04		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxITEM04].ToString();			
				string buf_VALUE_PUR	  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxVALUE_PUR].ToString(); 
				string buf_VALUE_IN       = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxVALUE_IN].ToString();
				string buf_VALUE_ADV_IN   = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxVALUE_ADV_IN].ToString(); 
				string buf_PUR_CURRENCY   = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPUR_CURRENCY].ToString(); 
				string buf_PUR_PRICE      = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPUR_PRICE].ToString();
				string buf_CBD_CURRENCY   = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxCBD_PRICE].ToString();
				string buf_CBD_PRICE      = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxCBD_PRICE].ToString(); 
				string buf_BAR_CODE       = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString();
				string buf_MRP_REQ_FLG    = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxMRP_REQ_FLG].ToString();
				string buf_PRICE_YN		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPRICE_YN].ToString();
				string buf_TRANSPORT_TYPE = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxTRANSPORT_TYPE].ToString();				       
				string buf_VENDOR		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxVENDOR_DESC].ToString();			   		     
				string buf_REMARKS		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxREMARKS].ToString();   		   		     
				string buf_UPD_USER		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxUPD_USER].ToString();
				#endregion				

				arg_request.fgrid_Main.Rows.InsertNode(arg_request.fgrid_Main.Rows.Count, Convert.ToInt32(buf_LEVEL));
				int inst_row = arg_request.fgrid_Main.Rows.Count - 1;		
				arg_request._Update_Flag=false;  				

				#region 변수 --> Incomming Manager FlexGrid
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxDIVISION]       = "I";
				//arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxSTATUS]         = buf_STATUS ;        
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxY_FLG]          = buf_Y_FLG;          
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxLEVEL]          = buf_LEVEL;          
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_NO]          = "";
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_SEQ]         = ""; 
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_DIV]         = "02"; 
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_YMD]         = ""; 
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM01]         = buf_ITEM01;         
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM02]         = buf_ITEM02;         
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM03]         = buf_ITEM03;         
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM04]         = buf_ITEM04;				
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_PUR]      = buf_VALUE_PUR;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_PREV_IN]  = buf_VALUE_IN;     
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_IN]       = buf_VALUE_ADV_IN;     						
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxBL_NO]          = "";				
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxINV_NO]         = "";        
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxDEC_NO]         = "";        
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxDEC_YMD]        = "";  
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_CURRENCY]   = buf_PUR_CURRENCY;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_PRICE]      = buf_PUR_PRICE;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxCBD_CURRENCY]   = buf_CBD_CURRENCY;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxCBD_PRICE]      = buf_CBD_PRICE;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_NO]         = buf_PUR_NO; 
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_SEQ]        = buf_PUR_SEQ; 
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxBAR_CODE]	   = buf_BAR_CODE;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_DIV]        = buf_PUR_DIV;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxMRP_REQ_FLG]    = buf_MRP_REQ_FLG;
				//arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPRICE_YN]       = buf_PRICE_YN;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxTRANSPORT_TYPE] = buf_TRANSPORT_TYPE;				
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVENDOR]         = buf_VENDOR; 
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxREMARKS]        = buf_REMARKS; 
				#endregion
			}
			else
			{				
				#region Grid Data --> 변수 
				//string buf_STATUS         = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxSTATUS].ToString();   	      
				string buf_Y_FLG		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG].ToString();   	      
				string buf_LEVEL		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxLEVEL].ToString();   	      
				string buf_PUR_NO		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPUR_NO].ToString(); 
				string buf_PUR_SEQ		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPUR_SEQ].ToString();
				string buf_PUR_DIV		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPUR_DIV].ToString();
				string buf_ITEM01		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxITEM01].ToString();   	      
				string buf_ITEM02		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxITEM02].ToString();   	      
				string buf_ITEM03		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxITEM03].ToString();   	      
				string buf_ITEM04		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxITEM04].ToString();			
				string buf_VALUE_PUR	  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxVALUE_PUR].ToString(); 
				string buf_VALUE_IN       = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxVALUE_IN].ToString();
				string buf_VALUE_ADV_IN   = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxVALUE_ADV_IN].ToString(); 
				string buf_PUR_CURRENCY   = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPUR_CURRENCY].ToString(); 
				string buf_PUR_PRICE      = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPUR_PRICE].ToString(); 
				string buf_CBD_CURRENCY   = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxCBD_PRICE].ToString();
				string buf_CBD_PRICE      = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxCBD_PRICE].ToString(); 
				string buf_BAR_CODE       = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString();
				string buf_MRP_REQ_FLG    = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxMRP_REQ_FLG].ToString();
				string buf_PRICE_YN		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxPRICE_YN].ToString();
				string buf_TRANSPORT_TYPE = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxTRANSPORT_TYPE].ToString();				       
				string buf_VENDOR		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxVENDOR_DESC].ToString();			   		     
				string buf_REMARKS		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxREMARKS].ToString();   		   		     
				string buf_UPD_USER		  = fgrid_Main[arg_rowcount, (int)ClassLib.TBSXI_IN_LIST_BAR.IxUPD_USER].ToString();
				#endregion

				arg_request.fgrid_Main.Rows.InsertNode(arg_request.fgrid_Main.Rows.Count, Convert.ToInt32(buf_LEVEL));
				int inst_row = arg_request.fgrid_Main.Rows.Count-1;	
				arg_request._Update_Flag=false; 

				#region 변수 --> Incomming Manager FlexGrid
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxDIVISION]       = "I";
				//arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxSTATUS]         = buf_STATUS ;        
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxY_FLG]          = buf_Y_FLG;          
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxLEVEL]          = buf_LEVEL;          
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_NO]          = "";
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_SEQ]         = ""; 
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_DIV]         = "02"; 
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxIN_YMD]         = ""; 
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM01]         = buf_ITEM01;         
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM02]         = buf_ITEM02;         
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM03]         = buf_ITEM03;         
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxITEM04]         = buf_ITEM04;				
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_PUR]      = buf_VALUE_PUR;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_PREV_IN]  = buf_VALUE_IN;     
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVALUE_IN]       = buf_VALUE_ADV_IN;     						
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxBL_NO]          = "";				
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxINV_NO]         = "";        
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxDEC_NO]         = "";        
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxDEC_YMD]        = "";  
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_CURRENCY]   = buf_PUR_CURRENCY;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_PRICE]      = buf_PUR_PRICE;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxCBD_CURRENCY]   = buf_CBD_CURRENCY;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxCBD_PRICE]      = buf_CBD_PRICE;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_NO]         = buf_PUR_NO; 
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_SEQ]        = buf_PUR_SEQ; 
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxBAR_CODE]	   = buf_BAR_CODE;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPUR_DIV]        = buf_PUR_DIV;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxMRP_REQ_FLG]    = buf_MRP_REQ_FLG;
				//arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxPRICE_YN]       = buf_PRICE_YN;
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxTRANSPORT_TYPE] = buf_TRANSPORT_TYPE;				
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxVENDOR]         = buf_VENDOR; 
				arg_request.fgrid_Main[inst_row, (int)ClassLib.TBSXI_IN_LIST.IxREMARKS]        = buf_REMARKS;

                arg_request.fgrid_Main.Rows[inst_row].AllowEditing = false;
				#endregion						
			}
        }
        #endregion

        #endregion

        #region 이벤트 처리
       
        #region Grid Event 
        private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
            {
                if (fgrid_Main.Cols[fgrid_Main.Col].DataType == typeof(bool))
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
            try
            {
                
                if (fgrid_Main.Selection.r1 == 0) return;


                #region Flag CheckBox 설정
                int[] selectRow = fgrid_Main.Selections;

                for (int i = 0; i < fgrid_Main.Selections.Length; i++)
                {
                    for (int j = selectRow[i]; j < fgrid_Main.Rows.Count; j++)
                    {
                        if (fgrid_Main[selectRow[i], (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString() != fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString())
                            break;
                        if (fgrid_Main[selectRow[i], (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG].ToString() == "True")
                        {
                            fgrid_Main.Update_Row(j);
                            fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG] = "True";
                        }
                        else
                        {
                            fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG] = "False";
                            fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxDIVISION] = "";

                        }

                    }

                }
                
                //for (int i = fgrid_Main.Selection.r1; i <= fgrid_Main.Selection.r2; i++)
                //{
                //    if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG].ToString() == "True")
                //    {

                //        if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxLEVEL].ToString() == "1")
                //        {
                //            fgrid_Main.Update_Row(i);
                //            for (int j = i + 1; j < fgrid_Main.Rows.Count; j++)
                //            {
                //                if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString() != fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString())
                //                    break;

                //                fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG] = "True";
                //                fgrid_Main.Update_Row(j);
                //            }
                //        }
                //    }
                //    else
                //    {

                //        if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxLEVEL].ToString() == "1")
                //        {
                //            fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxDIVISION] = "";

                //            for (int j = i + 1; j < fgrid_Main.Rows.Count; j++)
                //            {
                //                if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString() != fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString())
                //                    break;

                //                fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG] = "False";
                //                fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxDIVISION] = "";
                //            }
                //        }

                //    }
                //}
                #endregion
            }
            catch
            {
                
            }
        }
        private void fgrid_Main_Click(object sender, System.EventArgs e)
        {

        }
        private void fgrid_Main_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Space)
                {
                    if (fgrid_Main.Selection.r1 == 0) return;

                    #region Flag CheckBox 설정
                    for (int i = fgrid_Main.Selection.r1; i <= fgrid_Main.Selection.r2; i++)
                    {
                        if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG].ToString() == "True")
                        {

                            if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxLEVEL].ToString() == "1")
                            {
                                fgrid_Main.Update_Row(i);
                                for (int j = i + 1; j < fgrid_Main.Rows.Count; j++)
                                {
                                    if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString() != fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString())
                                        break;

                                    fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG] = "True";
                                    fgrid_Main.Update_Row(j);
                                }
                            }
                        }
                        else
                        {

                            if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxLEVEL].ToString() == "1")
                            {
                                fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxDIVISION] = "";

                                for (int j = i + 1; j < fgrid_Main.Rows.Count; j++)
                                {
                                    if (fgrid_Main[i, (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString() != fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxBAR_CODE].ToString())
                                        break;

                                    fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxY_FLG] = "False";
                                    fgrid_Main[j, (int)ClassLib.TBSXI_IN_LIST_BAR.IxDIVISION] = "";
                                }
                            }

                        }
                    }
                    #endregion
                }
            }
            catch
            {
                
            }
        }
        #endregion

        #region ToolBar Button Event
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(_New_flag)
			{
				fgrid_Main.Tree.Show(2);
				_New_flag=false;
			}
			else
			{
				fgrid_Main.Tree.Show(1);
				_New_flag=true;
			}            		
		}
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;				
				Display_Grid();
			}
			catch
			{
				this.Cursor = Cursors.Default;
				COM.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this);
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
                if (fgrid_Main.Rows.Count == fgrid_Main.Rows.Fixed)
                    return;

				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count-1, false);
				Save_Data();
			}
			catch
			{
				this.Cursor = Cursors.Default;
				COM.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
			}
			finally
			{
				this.Cursor = Cursors.Default;			
			}

        }
        #endregion

        #region Control Event
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_Factory.SelectedIndex == -1)
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

        private void dtp_Std_Ymd_CloseUp(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

                if (_first_flg)
                    return;

                if (int.Parse(dtp_Std_Ymd.Text) > int.Parse(dtp_Fin_Ymd.Text))
                {
                    dtp_Fin_Ymd.Value = dtp_Std_Ymd.Value;
                }

				//Vendor ComboBox Setting 
				DataTable dt_ret = Select_Sxs_Bar_Vendor(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, ClassLib.ComFunction.Empty_TextBox(txt_Barcode, ""));
				COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
				cmb_Vendor.SelectedIndex = 0;
			
				dt_ret.Dispose();
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

		private void dtp_Fin_Ymd_CloseUp(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;


                if (_first_flg)
                    return;

                if (int.Parse(dtp_Std_Ymd.Text) > int.Parse(dtp_Fin_Ymd.Text))
                {
                    dtp_Std_Ymd.Value = dtp_Fin_Ymd.Value;
                }

				//Vendor ComboBox Setting 
				DataTable dt_ret = Select_Sxs_Bar_Vendor(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, ClassLib.ComFunction.Empty_TextBox(txt_Barcode, "") );
				COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
				cmb_Vendor.SelectedIndex = 0;
			
				dt_ret.Dispose();
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

		private void txt_Barcode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(e.KeyData == Keys.Enter)
				{	
					//Vendor Setting 
					DataTable dt_ret = Select_Sxs_Bar_Vendor(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, ClassLib.ComFunction.Empty_TextBox(txt_Barcode, "") );
					COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, COM.ComVar.ComboList_Visible.Name);
					cmb_Vendor.SelectedIndex = 0;
			
					dt_ret.Dispose();
				}
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
        #endregion

        #region ContextMenu Event
        private void mnu_Mat_Click(object sender, System.EventArgs e)
		{
			fgrid_Main.Tree.Show(1);		
		}
		private void mnu_Bom_Click(object sender, System.EventArgs e)
		{
			fgrid_Main.Tree.Show(2);
        }
        #endregion

        #endregion

        #region DB Connect
        private DataTable Select_Sxs_Bar_Vendor(string arg_factory, string arg_std_ymd, string arg_fin_ymd, string arg_bar_code)
		{
			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_SXS_BAR_VENDOR" ;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
			MyOraDB.Parameter_Name[3] = "ARG_BAR_CODE";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_std_ymd;
			MyOraDB.Parameter_Values[2] = arg_fin_ymd;
			MyOraDB.Parameter_Values[3] = arg_bar_code;
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[MyOraDB.Process_Name];
		}
		
		private DataTable Select_SXI_In_List_Bar(string arg_factory, string arg_std_ymd, string arg_fin_ymd, 
			                                     string arg_bar_code, string arg_vendor, string arg_mat_name )
		{			
			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXI_IN_01_SELECT.SELECT_SXI_IN_LIST_BAR" ;

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STD_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_FIN_YMD";
			MyOraDB.Parameter_Name[3] = "ARG_BAR_CODE";
			MyOraDB.Parameter_Name[4] = "ARG_VENDOR";
			MyOraDB.Parameter_Name[5] = "ARG_MAT_NAME";			
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
			MyOraDB.Parameter_Values[1] = arg_std_ymd;
			MyOraDB.Parameter_Values[2] = arg_fin_ymd;
			MyOraDB.Parameter_Values[3] = arg_bar_code;
			MyOraDB.Parameter_Values[4] = arg_vendor;
			MyOraDB.Parameter_Values[5] = arg_mat_name;			
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();
			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[MyOraDB.Process_Name];
		}
				
		#endregion

		private void Pop_Barcode_List_Load(object sender, System.EventArgs e)
		{
			try
			{
                this.Cursor = Cursors.WaitCursor;

				//factory 
				DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
				COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;	
		
				//Init_Form();
			}
			catch
			{
                this.Cursor = Cursors.Default;

			}
			finally
			{
				txt_Barcode.Focus();
                this.Cursor = Cursors.Default;
			}
		}

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                //행 수정 상태 해제
                //fgrid_order.Select(fgrid_order.Selection.r1, 0, fgrid_order.Selection.r1, fgrid_order.Cols.Count - 1, false);

                //if (cmb_pur_div.SelectedValue.ToString() == "11")
                    //return;

                string mrd_Filename = "";
                string sPara = "";

                string[] arg_value = new string[6];
                arg_value[0] = cmb_Factory.SelectedValue.ToString();
                arg_value[1] = dtp_Std_Ymd.Value.ToString("yyyyMMdd");
                arg_value[2] = dtp_Fin_Ymd.Value.ToString("yyyyMMdd");
                arg_value[3] = txt_Barcode.Text.ToString();
                arg_value[4] = cmb_Vendor.SelectedValue.ToString().Trim();
                arg_value[5] = txt_MatName.Text.ToString();

                sPara = " /rp " + "[" + arg_value[0] + "]"
                               + " [" + arg_value[1] + "]"
                               + " [" + arg_value[2] + "]"
                               + " [" + arg_value[3] + "]"
                               + " [" + arg_value[4] + "]"
                               + " [" + arg_value[5] + "]";

                //if (!chk_print_shc.Checked)
                //{
                    if (ClassLib.ComVar.This_Factory == "DS")
                    {
                        //if (cmb_pur_div.SelectedValue.ToString() == "12")
                        //    mrd_Filename = Application.StartupPath + @"\Order_sheet_list_new_02" + ".mrd";
                        //else if (cmb_pur_div.SelectedValue.ToString() == "21")
                        //    mrd_Filename = Application.StartupPath + @"\Order_sheet_list_import_new" + ".mrd";
                    }
                    else if (ClassLib.ComVar.This_Factory == "VJ")
                    {
                        //if (cmb_pur_div.SelectedValue.ToString() == "12")
                        //    mrd_Filename = Application.StartupPath + @"\Order_sheet_list_VJ_new" + ".mrd";
                        //else if (cmb_pur_div.SelectedValue.ToString() == "21")
                            mrd_Filename = Application.StartupPath + @"\Barcode_Incoming_List" + ".mrd";
                    }
                    else if (ClassLib.ComVar.This_Factory == "QD")
                    {
                        //if (cmb_pur_div.SelectedValue.ToString() == "12")
                        //    mrd_Filename = Application.StartupPath + @"\Order_sheet_list_QD_new" + ".mrd";
                        //else if (cmb_pur_div.SelectedValue.ToString() == "21")
                        //    mrd_Filename = Application.StartupPath + @"\Order_sheet_list_import_QD_new" + ".mrd";
                    }

                    FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                    report.ShowDialog();
                //}
                //else
                //{
                //    Pop_Pur_List_PrintOption pop = new Pop_Pur_List_PrintOption("PURCHASE_SHC", arg_value[0], arg_value[3], arg_value[5]);
                //    pop.ShowDialog();
                //}
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }		

	}
}

