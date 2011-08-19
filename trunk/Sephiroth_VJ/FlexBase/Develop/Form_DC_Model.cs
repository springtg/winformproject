using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;


namespace FlexBase.Develop
{
	public class Form_DC_Model : COM.PCHWinForm.Pop_Large
	{   
		#region 컨트롤정의 및 리소스 정의 
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_Menu;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.Label lbl_Name;
		private System.Windows.Forms.Label lbl_Code;
		private System.Windows.Forms.Label lbl_year;
		private System.Windows.Forms.Label lbl_sc;
		private C1.Win.C1List.C1Combo cmb_seasonCode;
		private C1.Win.C1List.C1Combo cmb_year;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.TextBox txt_modelCd;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txt_modelName;
		private FarPoint.Win.Spread.CellType.ComboBoxCellType vComboType = null;
		private FarPoint.Win.Spread.CellType.TextCellType vTextType		 = null;
		//private int _contNoCol   = (int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_NO;
		//private System.Windows.Forms.ContextMenu ctx_contNo;
		//private System.Windows.Forms.Menu.MenuItemCollection _contNo;
		//private System.Windows.Forms.ListBox _shipFactList;
		private System.Windows.Forms.Label btn_delete;
		public System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel info_bar;
		private System.Windows.Forms.StatusBarPanel formname_bar;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		//private System.Windows.Forms.ListBox _contUnitList;

	

		public Form_DC_Model()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DC_Model));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_modelName = new System.Windows.Forms.TextBox();
            this.cmb_seasonCode = new C1.Win.C1List.C1Combo();
            this.lbl_sc = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.cmb_year = new C1.Win.C1List.C1Combo();
            this.txt_modelCd = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.stbar = new System.Windows.Forms.StatusBar();
            this.info_bar = new System.Windows.Forms.StatusBarPanel();
            this.formname_bar = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_seasonCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.info_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formname_bar)).BeginInit();
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
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Controls.Add(this.pnl_Menu);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(790, 484);
            this.c1Sizer1.TabIndex = 26;
            this.c1Sizer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.txt_modelName);
            this.panel1.Controls.Add(this.cmb_seasonCode);
            this.panel1.Controls.Add(this.lbl_sc);
            this.panel1.Controls.Add(this.lbl_year);
            this.panel1.Controls.Add(this.cmb_year);
            this.panel1.Controls.Add(this.txt_modelCd);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.lbl_Code);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 89);
            this.panel1.TabIndex = 167;
            // 
            // txt_modelName
            // 
            this.txt_modelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_modelName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modelName.Location = new System.Drawing.Point(109, 60);
            this.txt_modelName.MaxLength = 50;
            this.txt_modelName.Name = "txt_modelName";
            this.txt_modelName.Size = new System.Drawing.Size(578, 21);
            this.txt_modelName.TabIndex = 147;
            // 
            // cmb_seasonCode
            // 
            this.cmb_seasonCode.AddItemCols = 0;
            this.cmb_seasonCode.AddItemSeparator = ';';
            this.cmb_seasonCode.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_seasonCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_seasonCode.Caption = "";
            this.cmb_seasonCode.CaptionHeight = 17;
            this.cmb_seasonCode.CaptionStyle = style17;
            this.cmb_seasonCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_seasonCode.ColumnCaptionHeight = 18;
            this.cmb_seasonCode.ColumnFooterHeight = 18;
            this.cmb_seasonCode.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_seasonCode.ContentHeight = 17;
            this.cmb_seasonCode.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_seasonCode.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_seasonCode.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seasonCode.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_seasonCode.EditorHeight = 17;
            this.cmb_seasonCode.EvenRowStyle = style18;
            this.cmb_seasonCode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_seasonCode.FooterStyle = style19;
            this.cmb_seasonCode.GapHeight = 2;
            this.cmb_seasonCode.HeadingStyle = style20;
            this.cmb_seasonCode.HighLightRowStyle = style21;
            this.cmb_seasonCode.ItemHeight = 15;
            this.cmb_seasonCode.Location = new System.Drawing.Point(573, 38);
            this.cmb_seasonCode.MatchEntryTimeout = ((long)(2000));
            this.cmb_seasonCode.MaxDropDownItems = ((short)(5));
            this.cmb_seasonCode.MaxLength = 32767;
            this.cmb_seasonCode.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_seasonCode.Name = "cmb_seasonCode";
            this.cmb_seasonCode.OddRowStyle = style22;
            this.cmb_seasonCode.PartialRightColumn = false;
            this.cmb_seasonCode.PropBag = resources.GetString("cmb_seasonCode.PropBag");
            this.cmb_seasonCode.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_seasonCode.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_seasonCode.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_seasonCode.SelectedStyle = style23;
            this.cmb_seasonCode.Size = new System.Drawing.Size(114, 21);
            this.cmb_seasonCode.Style = style24;
            this.cmb_seasonCode.TabIndex = 153;
            this.cmb_seasonCode.Tag = "PK";
            // 
            // lbl_sc
            // 
            this.lbl_sc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_sc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sc.ImageIndex = 0;
            this.lbl_sc.ImageList = this.img_Label;
            this.lbl_sc.Location = new System.Drawing.Point(472, 38);
            this.lbl_sc.Name = "lbl_sc";
            this.lbl_sc.Size = new System.Drawing.Size(100, 21);
            this.lbl_sc.TabIndex = 152;
            this.lbl_sc.Text = "Season";
            this.lbl_sc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_year
            // 
            this.lbl_year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_year.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.ImageIndex = 0;
            this.lbl_year.ImageList = this.img_Label;
            this.lbl_year.Location = new System.Drawing.Point(240, 38);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(100, 21);
            this.lbl_year.TabIndex = 150;
            this.lbl_year.Text = "Year";
            this.lbl_year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_year
            // 
            this.cmb_year.AddItemCols = 0;
            this.cmb_year.AddItemSeparator = ';';
            this.cmb_year.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_year.Caption = "";
            this.cmb_year.CaptionHeight = 17;
            this.cmb_year.CaptionStyle = style25;
            this.cmb_year.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_year.ColumnCaptionHeight = 18;
            this.cmb_year.ColumnFooterHeight = 18;
            this.cmb_year.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_year.ContentHeight = 17;
            this.cmb_year.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_year.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_year.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_year.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_year.EditorHeight = 17;
            this.cmb_year.EvenRowStyle = style26;
            this.cmb_year.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_year.FooterStyle = style27;
            this.cmb_year.GapHeight = 2;
            this.cmb_year.HeadingStyle = style28;
            this.cmb_year.HighLightRowStyle = style29;
            this.cmb_year.ItemHeight = 15;
            this.cmb_year.Location = new System.Drawing.Point(341, 38);
            this.cmb_year.MatchEntryTimeout = ((long)(2000));
            this.cmb_year.MaxDropDownItems = ((short)(5));
            this.cmb_year.MaxLength = 32767;
            this.cmb_year.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.OddRowStyle = style30;
            this.cmb_year.PartialRightColumn = false;
            this.cmb_year.PropBag = resources.GetString("cmb_year.PropBag");
            this.cmb_year.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_year.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_year.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_year.SelectedStyle = style31;
            this.cmb_year.Size = new System.Drawing.Size(114, 21);
            this.cmb_year.Style = style32;
            this.cmb_year.TabIndex = 151;
            this.cmb_year.Tag = "PK";
            // 
            // txt_modelCd
            // 
            this.txt_modelCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_modelCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modelCd.Location = new System.Drawing.Point(109, 38);
            this.txt_modelCd.MaxLength = 15;
            this.txt_modelCd.Name = "txt_modelCd";
            this.txt_modelCd.Size = new System.Drawing.Size(115, 21);
            this.txt_modelCd.TabIndex = 146;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_Name.ImageIndex = 0;
            this.lbl_Name.ImageList = this.img_Label;
            this.lbl_Name.Location = new System.Drawing.Point(8, 60);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(100, 21);
            this.lbl_Name.TabIndex = 34;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Code
            // 
            this.lbl_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Code.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Code.ImageIndex = 0;
            this.lbl_Code.ImageList = this.img_Label;
            this.lbl_Code.Location = new System.Drawing.Point(8, 38);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(100, 21);
            this.lbl_Code.TabIndex = 36;
            this.lbl_Code.Text = "Code";
            this.lbl_Code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(673, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 51);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(758, 0);
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
            this.pictureBox3.Size = new System.Drawing.Size(726, 32);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "      Model Master Info.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(758, 74);
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
            this.pictureBox5.Location = new System.Drawing.Point(144, 73);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(726, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 74);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 20);
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(168, 56);
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(160, 24);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(726, 49);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(8, 93);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(774, 329);
            this.spd_main.TabIndex = 51;
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            this.spd_main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellDoubleClick);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Menu.Controls.Add(this.btn_delete);
            this.pnl_Menu.Controls.Add(this.btn_recover);
            this.pnl_Menu.Controls.Add(this.btn_Insert);
            this.pnl_Menu.Location = new System.Drawing.Point(8, 426);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(774, 50);
            this.pnl_Menu.TabIndex = 46;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_delete.ImageIndex = 5;
            this.btn_delete.ImageList = this.image_List;
            this.btn_delete.Location = new System.Drawing.Point(606, 13);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 24);
            this.btn_delete.TabIndex = 362;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            this.btn_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseDown);
            this.btn_delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseUp);
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(688, 13);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(82, 24);
            this.btn_recover.TabIndex = 349;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseDown);
            this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(524, 13);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(82, 24);
            this.btn_Insert.TabIndex = 344;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_insert_Click);
            this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseDown);
            this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseUp);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 544);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.info_bar,
            this.formname_bar});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(792, 22);
            this.stbar.TabIndex = 27;
            // 
            // info_bar
            // 
            this.info_bar.Name = "info_bar";
            this.info_bar.Width = 150;
            // 
            // formname_bar
            // 
            this.formname_bar.Name = "formname_bar";
            this.formname_bar.Width = 300;
            // 
            // Form_DC_Model
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.stbar);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_DC_Model";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_seasonCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.info_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formname_bar)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자정의변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet				 = null;
		

		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{						
			this.Grid_EditModeOnProcess(spd_main) ;
		}		

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			spd_main.Update_Row(img_Action);
		}

		private void spd_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader)
				Grid_CellDoubleClickProcess(e.Row);
		}

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SaveProcess();
		}	
		
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			SetPrintYield();
		}			
	
		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			this.Btn_InsertProcess();
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			this.Btn_DeleteProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Btn_CancelProcess();
		}
	
		#region 입력이동

		#endregion

		#region 버튼효과

		private void btn_insert_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 8;
		}

		private void btn_insert_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 9;
		}

		private void btn_delete_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 4;
		}

		private void btn_delete_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 5;
		}

		private void btn_cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		private void btn_cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		#endregion

		#endregion

		#region 공통 메서드

		// GridSet : Fore color setting
		private void GridSetInitGrid()
		{
			int vRowCount = spd_main.Sheets[0].Rows.Count;

			for (int i = vRowCount - 1 ; i >= 0 ; i--)
			{
				string vDiv = (spd_main.Sheets[0].Cells[i, 0].Tag == null) ? "" : spd_main.Sheets[0].Cells[i, 0].Tag.ToString();
				if (vDiv.Equals(ClassLib.ComVar.Delete))
				{
					spd_main.Sheets[0].Rows[i].Remove();
					vRowCount--;
				}
			}

			spd_main.Sheets[0].ClearRange(0, 0, vRowCount, 1, false);
		}

		// GridSet : Combo cell change
		private void GridSetComboCell(bool arg_isCombo, ListBox arg_list, int arg_row, int arg_col)
		{
			FarPoint.Win.Spread.CellType.ICellType vNewCellType = null;
			object vOldValue = _mainSheet.Cells[arg_row, arg_col].Value;

			if (arg_isCombo)
			{
				vComboType.ListControl = arg_list;
				vComboType.ListAlignment = FarPoint.Win.ListAlignment.Left;
				vNewCellType = vComboType;
			}
			else
				vNewCellType = vTextType;
			
			_mainSheet.Cells[arg_row, arg_col].CellType = vNewCellType;
			_mainSheet.Cells[arg_row, arg_col].Value = vOldValue;
		}

		private void GridSetData(int arg_row)
		{
			try
				
			{
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxMODEL_CD].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxMODEL_CD];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxMODEL_NAME].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxMODEL_NAME];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxCATEGORY].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxCATEGORY];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxPATTERN].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxPATTERN];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxTOOL_CD].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxTOOL_CD];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxSET_PH].Value			= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_PH];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxSET_PH_SPU].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_PH_SPU];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxPH_TYPE].Text			= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxPH_TYPE];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxSET_HPU].Text			= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_HPU];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxSET_HPU_SPU].Value	= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_HPU_SPU];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxSET_SPU].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_SPU];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxREMARKS].Value		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxREMARKS];
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxUPD_YMD].Value		= "";
				_mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxUPD_USR].Value		= COM.ComVar.This_User;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void GridGetData(int arg_row)
		{
			try
			{
				COM.ComVar.Parameter_PopUp[0]										= ClassLib.ComVar.Insert;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxMODEL_CD]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxMODEL_CD].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxMODEL_NAME]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxMODEL_NAME].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxCATEGORY]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxCATEGORY].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxPATTERN]		= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxPATTERN].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxTOOL_CD]		= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxTOOL_CD].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_PH]		= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxSET_PH].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_PH_SPU]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxSET_PH_SPU].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxPH_TYPE]		= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxPH_TYPE].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_HPU]		= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxSET_HPU].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_HPU_SPU]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxSET_HPU_SPU].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_SPU]		= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxSET_SPU].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxREMARKS]		= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxREMARKS].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxUPD_YMD]		= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxUPD_YMD].Text;
				COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxUPD_USR]		= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxUPD_USR].Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{					
	
			//Title
            this.Text = "Model Master";
            lbl_MainTitle.Text = "Model Master"; 
            ClassLib.ComFunction.SetLangDic(this);

			// Form Setting  
			ClassLib.ComFunction.Init_Form_Control(this);
			ClassLib.ComFunction.Init_MenuRole(this,lbl_MainTitle,tbtn_Search ,tbtn_Save,tbtn_Print) ;




			DataTable vDt = null;

			// year combo set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxYear);
			COM.ComCtl.Set_ComboList(vDt, cmb_year, 1, 2, true);
			cmb_year.SelectedIndex = 0;
			vDt.Dispose();

			// seqsonCode combo set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxSeason);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_seasonCode, 1, 2, true);
			cmb_seasonCode.SelectedIndex = 0;
			vDt.Dispose();
			

			// Grid Setting
			spd_main.Set_Spread_Comm("SDC_MODEL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			
			_mainSheet = spd_main.Sheets[0];
			//_mainSheet = spd_main.ActiveSheet;

			// Disabled tbutton
			tbtn_Delete.Enabled  = false;
			tbtn_Conform.Enabled = false;


		}		

		private void Tbtn_NewProcess()
		{
			try
			{
				this.txt_modelCd.Text = "";
				this.cmb_year.SelectedIndex = 0;
				this.cmb_seasonCode.SelectedIndex = 0;
				this.txt_modelName.Text = "";
				
				spd_main.ClearAll();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
			
				string vModelCd    = txt_modelCd.Text;
				string vModelName  = this.txt_modelName.Text;
				string vYear       = this.cmb_year.SelectedValue.ToString();
				string vSeasonCode = this.cmb_seasonCode.SelectedValue.ToString();

				DataTable vDt = SELECT_SDC_MODEL(vModelCd, vModelName, vYear, vSeasonCode);
				spd_main.Display_Grid(vDt); 
				vDt.Dispose();

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Tbtn_SaveProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				//Webservice Change - DS 
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory); 

				MyOraDB.Save_Spread("PKG_SDC_MODEL.SAVE_SDC_MODEL", spd_main);


				GridSetInitGrid();

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				this.Tbtn_SearchProcess();
			}
			catch (Exception ex)
			{			
				MessageBox.Show(ex.Message);
			}
			finally
			{
				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);
				this.Cursor = Cursors.Default;
			}
		}

		private void Btn_InsertProcess()
		{
			COM.ComVar.Parameter_PopUp		= null;

			Pop_DC_Model popup = new Pop_DC_Model();
			popup.ShowDialog();
			if (popup.DialogResult == DialogResult.OK)
			{
//				int vModelCdCol  = (int)ClassLib.TBSDC_MODEL.IxMODEL_CD;
//				int vShipFactCol = (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_FACT;

				int vRow = spd_main.Add_Row(img_Action);
				GridSetData(vRow);

//				_mainSheet.Cells[vRow, vModelCdCol].Locked = false;
//				_mainSheet.Cells[vRow, vShipFactCol].Locked = false;
			}
			popup.Dispose();

 
			//top row 기능
			spd_main.Set_CellPosition(_mainSheet.RowCount - 1, (int)ClassLib.TBSDC_MODEL.IxMODEL_CD); 

		}

		private void Btn_DeleteProcess()
		{
			spd_main.Delete_Row(img_Action);
		}

		private void Btn_CancelProcess()
		{
			spd_main.Recovery();
		}

		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = arg_grid.Sheets[0].ActiveRowIndex ;
			int vCol = arg_grid.Sheets[0].ActiveColumnIndex ;
			
			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString() ;
			if (vTemp == "CheckBoxCellType" || vTemp == "SSPComboBoxCellType")
			{
				arg_grid.Buffer_CellData = "000" ;
				arg_grid.Update_Row(img_Action) ;
			}
		}

		private void Grid_CellDoubleClickProcess(int arg_row)
		{
			try
			{



				string vDiv = (spd_main.Sheets[0].Cells[arg_row, 0].Tag == null) ? "" : spd_main.Sheets[0].Cells[arg_row, 0].Tag.ToString();

				if (vDiv.Equals(ClassLib.ComVar.Insert))
				{
					COM.ComVar.Parameter_PopUp = new string[(int)ClassLib.TBSDC_MODEL.IxMaxCt + 1];
					this.GridGetData(arg_row);
				}
				else
				{

					COM.ComVar.Parameter_PopUp = new string[2];

					COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComVar.Update;
					COM.ComVar.Parameter_PopUp[1]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxMODEL_CD].Text;
//					COM.ComVar.Parameter_PopUp[2]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxMODEL_NAME].Text;
//					COM.ComVar.Parameter_PopUp[3]	= _mainSheet.Cells[arg_row, (int)ClassLib.TBSDC_MODEL.IxCATEGORY].Text;
				}

				Pop_DC_Model popup = null;

				if (!vDiv.Equals(ClassLib.ComVar.Insert))
				{
					if(_mainSheet.ActiveColumnIndex == (int)ClassLib.TBSDC_MODEL.IxMODEL_CD)
					{
						popup = new Pop_DC_Model();
						popup.ShowDialog();

					}
				}
				else
				{

					popup = new Pop_DC_Model();
					popup.ShowDialog();

				}




//				Pop_DC_Model popup = new Pop_DC_Model();
//				popup.ShowDialog();

				if(popup == null) return;

				if (popup.DialogResult == DialogResult.OK)
				{
					GridSetData(arg_row);
					if (!vDiv.Equals(ClassLib.ComVar.Insert))
						spd_main.Update_Row(arg_row, img_Action) ;
				}
				popup.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void  SetPrintYield()
		{
			try
			{   
	
						 
				string mrd_Filename = "Report/Material/Form_DC_Model_Master.mrd" ;
				string Para         = " ";

				#region 출력조건

				int  iCnt  = 4;
				string [] aHead =  new string[iCnt];	

				string vModelCd    = txt_modelCd.Text;
				string vModelName  = this.txt_modelName.Text;
				string vYear       = this.cmb_year.SelectedValue.ToString();
				string vSeasonCode = this.cmb_seasonCode.SelectedValue.ToString();

				aHead[0]    = vModelCd;
				aHead[1]    = vModelName;
				aHead[2]    = vYear;
				aHead[3]    = vSeasonCode;
		
			
				#endregion
	
				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{				
					Para = Para + "[" + aHead[i-1] + "] ";
				}
	
				FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer ( mrd_Filename, Para);
				report.Show();	

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetPrintYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SDC_MODEL : 
		/// </summary>
		/// <param name="arg_model_cd">model cd</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SDC_MODEL(string arg_modelCd,string  arg_modelName,string  arg_year,string  arg_seasonCode)
		{
			try
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(5);

				//Webservice Change - DS 
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);



				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SDC_MODEL.SELECT_SDC_MODEL";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[1] = "ARG_MODEL_NAME";
				MyOraDB.Parameter_Name[2] = "ARG_YEAR";
				MyOraDB.Parameter_Name[3] = "ARG_SEASON_CODE";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_modelCd;
				MyOraDB.Parameter_Values[1] = arg_modelName;
				MyOraDB.Parameter_Values[2] = arg_year;
				MyOraDB.Parameter_Values[3] = arg_seasonCode;
				MyOraDB.Parameter_Values[4] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();

				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);

				if(vds_ret == null) return null ;

				return vds_ret.Tables[MyOraDB.Process_Name];
			}
			catch
			{
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory); 
				return null;
			}


		}


		

		#endregion																									 
		 
		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
	}
}

