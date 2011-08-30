using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Outgoing
{
	public class Form_Outgoing_mat_list : COM.PCHWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정의 
		public COM.FSP flg_mat_list;
		private System.ComponentModel.IContainer components = null;
		private COM.OraDB OraDB = new COM.OraDB();		
		public System.Windows.Forms.Panel panel2;
		private C1.Win.C1List.C1Combo cmb_sampletype;
		private System.Windows.Forms.Label lbl_sampletype;
		private C1.Win.C1List.C1Combo cmb_category;
		private System.Windows.Forms.Label lbl_category;
		private System.Windows.Forms.Label txt_sr_no01;
		private System.Windows.Forms.TextBox txt_sr_no;
		private C1.Win.C1List.C1Combo cmb_season;
		private C1.Win.C1List.C1Combo cmb_user;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.TextBox txt_bomid;
		private System.Windows.Forms.Label lbl_bomid;
		private System.Windows.Forms.TextBox txt_srfno;
        private System.Windows.Forms.Label lbl_sefno;
		private System.Windows.Forms.Label lbl_season;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		public System.Windows.Forms.PictureBox pictureBox17;
		private int show_lev = 1;
		private System.Windows.Forms.ContextMenu contextMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
        private Label lbl_data_type;
        public C1.Win.C1List.C1Combo cmb_status;
        private Label lbl_lot_5;
        private Label lbl_lot_7;
		private System.Windows.Forms.MenuItem menuItem4;       
        private Label lbl_ets_5;
        private Label lbl_ets_7;
        private MenuItem mnu_sep1;
        private MenuItem mnu_work_sheet;
        

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Outgoing_mat_list));
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
            this.flg_mat_list = new COM.FSP();
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnu_sep1 = new System.Windows.Forms.MenuItem();
            this.mnu_work_sheet = new System.Windows.Forms.MenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_ets_5 = new System.Windows.Forms.Label();
            this.lbl_ets_7 = new System.Windows.Forms.Label();
            this.cmb_status = new C1.Win.C1List.C1Combo();
            this.txt_sr_no = new System.Windows.Forms.TextBox();
            this.cmb_user = new C1.Win.C1List.C1Combo();
            this.cmb_sampletype = new C1.Win.C1List.C1Combo();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_sr_no01 = new System.Windows.Forms.Label();
            this.lbl_sampletype = new System.Windows.Forms.Label();
            this.lbl_data_type = new System.Windows.Forms.Label();
            this.lbl_season = new System.Windows.Forms.Label();
            this.cmb_category = new C1.Win.C1List.C1Combo();
            this.lbl_category = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bomid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_bomid = new System.Windows.Forms.Label();
            this.cmb_season = new C1.Win.C1List.C1Combo();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.txt_srfno = new System.Windows.Forms.TextBox();
            this.lbl_sefno = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.lbl_lot_7 = new System.Windows.Forms.Label();
            this.lbl_lot_5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flg_mat_list)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampletype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
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
            
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
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
            // flg_mat_list
            // 
            this.flg_mat_list.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.flg_mat_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flg_mat_list.AutoResize = false;
            this.flg_mat_list.BackColor = System.Drawing.SystemColors.Window;
            this.flg_mat_list.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flg_mat_list.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.flg_mat_list.ContextMenu = this.contextMenu;
            this.flg_mat_list.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flg_mat_list.ForeColor = System.Drawing.SystemColors.WindowText;
            this.flg_mat_list.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.flg_mat_list.Location = new System.Drawing.Point(6, 203);
            this.flg_mat_list.Name = "flg_mat_list";
            this.flg_mat_list.Rows.Fixed = 0;
            this.flg_mat_list.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.flg_mat_list.Size = new System.Drawing.Size(1008, 440);
            this.flg_mat_list.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("flg_mat_list.Styles"));
            this.flg_mat_list.TabIndex = 321;
            this.flg_mat_list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flg_mat_list_MouseClick);
            this.flg_mat_list.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.flg_mat_list_AfterEdit);
            // 
            // contextMenu
            // 
            this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.mnu_sep1,
            this.mnu_work_sheet});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Category";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Season";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "BOM";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "Material";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // mnu_sep1
            // 
            this.mnu_sep1.Index = 4;
            this.mnu_sep1.Text = "-";
            // 
            // mnu_work_sheet
            // 
            this.mnu_work_sheet.Index = 5;
            this.mnu_work_sheet.Text = "Worksheet for Developer";
            this.mnu_work_sheet.Click += new System.EventHandler(this.mnu_work_sheet_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.cmb_factory);
            this.panel2.Controls.Add(this.lbl_factory);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Font = new System.Drawing.Font("굴림", 9F);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.panel2.Size = new System.Drawing.Size(1016, 120);
            this.panel2.TabIndex = 322;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style1;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 17;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Control;
            this.cmb_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 17;
            this.cmb_factory.EvenRowStyle = style2;
            this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style3;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style4;
            this.cmb_factory.HighLightRowStyle = style5;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(117, 36);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style6;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style7;
            this.cmb_factory.Size = new System.Drawing.Size(120, 21);
            this.cmb_factory.Style = style8;
            this.cmb_factory.TabIndex = 331;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 36);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 330;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(768, 304);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 21);
            this.textBox1.TabIndex = 270;
            this.textBox1.Tag = "60";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(560, 304);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 21);
            this.textBox2.TabIndex = 268;
            this.textBox2.Tag = "60";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(384, 328);
            this.textBox3.MaxLength = 100;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(416, 21);
            this.textBox3.TabIndex = 267;
            this.textBox3.Tag = "60";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(376, 304);
            this.textBox5.MaxLength = 100;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 21);
            this.textBox5.TabIndex = 264;
            this.textBox5.Tag = "60";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(200, 304);
            this.textBox6.MaxLength = 100;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 21);
            this.textBox6.TabIndex = 263;
            this.textBox6.Tag = "60";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(24, 304);
            this.textBox7.MaxLength = 100;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 21);
            this.textBox7.TabIndex = 262;
            this.textBox7.Tag = "60";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.lbl_ets_5);
            this.panel3.Controls.Add(this.lbl_ets_7);
            this.panel3.Controls.Add(this.cmb_status);
            this.panel3.Controls.Add(this.txt_sr_no);
            this.panel3.Controls.Add(this.cmb_user);
            this.panel3.Controls.Add(this.cmb_sampletype);
            this.panel3.Controls.Add(this.lbl_user);
            this.panel3.Controls.Add(this.txt_sr_no01);
            this.panel3.Controls.Add(this.lbl_sampletype);
            this.panel3.Controls.Add(this.lbl_data_type);
            this.panel3.Controls.Add(this.lbl_season);
            this.panel3.Controls.Add(this.cmb_category);
            this.panel3.Controls.Add(this.lbl_category);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_bomid);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbl_bomid);
            this.panel3.Controls.Add(this.cmb_season);
            this.panel3.Controls.Add(this.pictureBox10);
            this.panel3.Controls.Add(this.pictureBox11);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox12);
            this.panel3.Controls.Add(this.txt_srfno);
            this.panel3.Controls.Add(this.lbl_sefno);
            this.panel3.Controls.Add(this.pictureBox13);
            this.panel3.Controls.Add(this.pictureBox14);
            this.panel3.Controls.Add(this.pictureBox15);
            this.panel3.Controls.Add(this.pictureBox16);
            this.panel3.Controls.Add(this.pictureBox17);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("굴림", 9F);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(8, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 112);
            this.panel3.TabIndex = 18;
            // 
            // lbl_ets_5
            // 
            this.lbl_ets_5.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ets_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ets_5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ets_5.ImageIndex = 0;
            this.lbl_ets_5.Location = new System.Drawing.Point(855, 80);
            this.lbl_ets_5.Name = "lbl_ets_5";
            this.lbl_ets_5.Size = new System.Drawing.Size(59, 21);
            this.lbl_ets_5.TabIndex = 356;
            this.lbl_ets_5.Tag = "1";
            this.lbl_ets_5.Text = "ETS - 5";
            this.lbl_ets_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ets_7
            // 
            this.lbl_ets_7.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ets_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ets_7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ets_7.ImageIndex = 0;
            this.lbl_ets_7.Location = new System.Drawing.Point(916, 80);
            this.lbl_ets_7.Name = "lbl_ets_7";
            this.lbl_ets_7.Size = new System.Drawing.Size(59, 21);
            this.lbl_ets_7.TabIndex = 357;
            this.lbl_ets_7.Tag = "1";
            this.lbl_ets_7.Text = "ETS - 7";
            this.lbl_ets_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_status
            // 
            this.cmb_status.AddItemCols = 0;
            this.cmb_status.AddItemSeparator = ';';
            this.cmb_status.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_status.Caption = "";
            this.cmb_status.CaptionHeight = 17;
            this.cmb_status.CaptionStyle = style9;
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
            this.cmb_status.EvenRowStyle = style10;
            this.cmb_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FooterStyle = style11;
            this.cmb_status.GapHeight = 2;
            this.cmb_status.HeadingStyle = style12;
            this.cmb_status.HighLightRowStyle = style13;
            this.cmb_status.ItemHeight = 15;
            this.cmb_status.Location = new System.Drawing.Point(109, 80);
            this.cmb_status.MatchEntryTimeout = ((long)(2000));
            this.cmb_status.MaxDropDownItems = ((short)(5));
            this.cmb_status.MaxLength = 32767;
            this.cmb_status.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.OddRowStyle = style14;
            this.cmb_status.PartialRightColumn = false;
            this.cmb_status.PropBag = resources.GetString("cmb_status.PropBag");
            this.cmb_status.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_status.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_status.SelectedStyle = style15;
            this.cmb_status.Size = new System.Drawing.Size(120, 21);
            this.cmb_status.Style = style16;
            this.cmb_status.TabIndex = 354;
            // 
            // txt_sr_no
            // 
            this.txt_sr_no.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_sr_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sr_no.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_sr_no.ForeColor = System.Drawing.Color.Black;
            this.txt_sr_no.Location = new System.Drawing.Point(855, 36);
            this.txt_sr_no.MaxLength = 100;
            this.txt_sr_no.Name = "txt_sr_no";
            this.txt_sr_no.Size = new System.Drawing.Size(120, 20);
            this.txt_sr_no.TabIndex = 344;
            // 
            // cmb_user
            // 
            this.cmb_user.AddItemCols = 0;
            this.cmb_user.AddItemSeparator = ';';
            this.cmb_user.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_user.Caption = "";
            this.cmb_user.CaptionHeight = 17;
            this.cmb_user.CaptionStyle = style17;
            this.cmb_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_user.ColumnCaptionHeight = 18;
            this.cmb_user.ColumnFooterHeight = 18;
            this.cmb_user.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_user.ContentHeight = 17;
            this.cmb_user.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_user.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_user.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_user.EditorHeight = 17;
            this.cmb_user.EvenRowStyle = style18;
            this.cmb_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_user.FooterStyle = style19;
            this.cmb_user.GapHeight = 2;
            this.cmb_user.HeadingStyle = style20;
            this.cmb_user.HighLightRowStyle = style21;
            this.cmb_user.ItemHeight = 15;
            this.cmb_user.Location = new System.Drawing.Point(855, 57);
            this.cmb_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_user.MaxDropDownItems = ((short)(5));
            this.cmb_user.MaxLength = 32767;
            this.cmb_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.OddRowStyle = style22;
            this.cmb_user.PartialRightColumn = false;
            this.cmb_user.PropBag = resources.GetString("cmb_user.PropBag");
            this.cmb_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_user.SelectedStyle = style23;
            this.cmb_user.Size = new System.Drawing.Size(120, 21);
            this.cmb_user.Style = style24;
            this.cmb_user.TabIndex = 341;
            // 
            // cmb_sampletype
            // 
            this.cmb_sampletype.AddItemCols = 0;
            this.cmb_sampletype.AddItemSeparator = ';';
            this.cmb_sampletype.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_sampletype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_sampletype.Caption = "";
            this.cmb_sampletype.CaptionHeight = 17;
            this.cmb_sampletype.CaptionStyle = style25;
            this.cmb_sampletype.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_sampletype.ColumnCaptionHeight = 18;
            this.cmb_sampletype.ColumnFooterHeight = 18;
            this.cmb_sampletype.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_sampletype.ContentHeight = 17;
            this.cmb_sampletype.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_sampletype.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_sampletype.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampletype.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_sampletype.EditorHeight = 17;
            this.cmb_sampletype.EvenRowStyle = style26;
            this.cmb_sampletype.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sampletype.FooterStyle = style27;
            this.cmb_sampletype.GapHeight = 2;
            this.cmb_sampletype.HeadingStyle = style28;
            this.cmb_sampletype.HighLightRowStyle = style29;
            this.cmb_sampletype.ItemHeight = 15;
            this.cmb_sampletype.Location = new System.Drawing.Point(616, 58);
            this.cmb_sampletype.MatchEntryTimeout = ((long)(2000));
            this.cmb_sampletype.MaxDropDownItems = ((short)(5));
            this.cmb_sampletype.MaxLength = 32767;
            this.cmb_sampletype.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sampletype.Name = "cmb_sampletype";
            this.cmb_sampletype.OddRowStyle = style30;
            this.cmb_sampletype.PartialRightColumn = false;
            this.cmb_sampletype.PropBag = resources.GetString("cmb_sampletype.PropBag");
            this.cmb_sampletype.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_sampletype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_sampletype.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_sampletype.SelectedStyle = style31;
            this.cmb_sampletype.Size = new System.Drawing.Size(120, 21);
            this.cmb_sampletype.Style = style32;
            this.cmb_sampletype.TabIndex = 353;
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ImageIndex = 0;
            this.lbl_user.ImageList = this.img_Label;
            this.lbl_user.Location = new System.Drawing.Point(754, 58);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_user.TabIndex = 340;
            this.lbl_user.Tag = "1";
            this.lbl_user.Text = "User";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sr_no01
            // 
            this.txt_sr_no01.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sr_no01.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sr_no01.ImageIndex = 0;
            this.txt_sr_no01.ImageList = this.img_Label;
            this.txt_sr_no01.Location = new System.Drawing.Point(754, 36);
            this.txt_sr_no01.Name = "txt_sr_no01";
            this.txt_sr_no01.Size = new System.Drawing.Size(100, 21);
            this.txt_sr_no01.TabIndex = 345;
            this.txt_sr_no01.Tag = "1";
            this.txt_sr_no01.Text = "SR No";
            this.txt_sr_no01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sampletype
            // 
            this.lbl_sampletype.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_sampletype.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sampletype.ImageIndex = 0;
            this.lbl_sampletype.ImageList = this.img_Label;
            this.lbl_sampletype.Location = new System.Drawing.Point(515, 58);
            this.lbl_sampletype.Name = "lbl_sampletype";
            this.lbl_sampletype.Size = new System.Drawing.Size(100, 21);
            this.lbl_sampletype.TabIndex = 352;
            this.lbl_sampletype.Tag = "1";
            this.lbl_sampletype.Text = "Sample Types";
            this.lbl_sampletype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_data_type
            // 
            this.lbl_data_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_type.ImageIndex = 0;
            this.lbl_data_type.ImageList = this.img_Label;
            this.lbl_data_type.Location = new System.Drawing.Point(8, 80);
            this.lbl_data_type.Name = "lbl_data_type";
            this.lbl_data_type.Size = new System.Drawing.Size(100, 21);
            this.lbl_data_type.TabIndex = 355;
            this.lbl_data_type.Text = "Status";
            this.lbl_data_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_season
            // 
            this.lbl_season.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_season.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_season.ImageIndex = 0;
            this.lbl_season.ImageList = this.img_Label;
            this.lbl_season.Location = new System.Drawing.Point(515, 36);
            this.lbl_season.Name = "lbl_season";
            this.lbl_season.Size = new System.Drawing.Size(100, 21);
            this.lbl_season.TabIndex = 332;
            this.lbl_season.Tag = "1";
            this.lbl_season.Text = "Season";
            this.lbl_season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_category
            // 
            this.cmb_category.AddItemCols = 0;
            this.cmb_category.AddItemSeparator = ';';
            this.cmb_category.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_category.Caption = "";
            this.cmb_category.CaptionHeight = 17;
            this.cmb_category.CaptionStyle = style33;
            this.cmb_category.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_category.ColumnCaptionHeight = 18;
            this.cmb_category.ColumnFooterHeight = 18;
            this.cmb_category.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_category.ContentHeight = 17;
            this.cmb_category.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_category.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_category.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_category.EditorHeight = 17;
            this.cmb_category.EvenRowStyle = style34;
            this.cmb_category.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.FooterStyle = style35;
            this.cmb_category.GapHeight = 2;
            this.cmb_category.HeadingStyle = style36;
            this.cmb_category.HighLightRowStyle = style37;
            this.cmb_category.ItemHeight = 15;
            this.cmb_category.Location = new System.Drawing.Point(346, 36);
            this.cmb_category.MatchEntryTimeout = ((long)(2000));
            this.cmb_category.MaxDropDownItems = ((short)(5));
            this.cmb_category.MaxLength = 32767;
            this.cmb_category.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.OddRowStyle = style38;
            this.cmb_category.PartialRightColumn = false;
            this.cmb_category.PropBag = resources.GetString("cmb_category.PropBag");
            this.cmb_category.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_category.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_category.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_category.SelectedStyle = style39;
            this.cmb_category.Size = new System.Drawing.Size(120, 21);
            this.cmb_category.Style = style40;
            this.cmb_category.TabIndex = 349;
            // 
            // lbl_category
            // 
            this.lbl_category.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_category.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ImageIndex = 0;
            this.lbl_category.ImageList = this.img_Label;
            this.lbl_category.Location = new System.Drawing.Point(245, 36);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(100, 21);
            this.lbl_category.TabIndex = 348;
            this.lbl_category.Tag = "1";
            this.lbl_category.Text = "Category";
            this.lbl_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 21);
            this.label2.TabIndex = 112;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_bomid
            // 
            this.txt_bomid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_bomid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bomid.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_bomid.ForeColor = System.Drawing.Color.Black;
            this.txt_bomid.Location = new System.Drawing.Point(346, 58);
            this.txt_bomid.MaxLength = 100;
            this.txt_bomid.Name = "txt_bomid";
            this.txt_bomid.Size = new System.Drawing.Size(120, 20);
            this.txt_bomid.TabIndex = 339;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(983, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 69);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_bomid
            // 
            this.lbl_bomid.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_bomid.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bomid.ImageIndex = 0;
            this.lbl_bomid.ImageList = this.img_Label;
            this.lbl_bomid.Location = new System.Drawing.Point(245, 56);
            this.lbl_bomid.Name = "lbl_bomid";
            this.lbl_bomid.Size = new System.Drawing.Size(100, 21);
            this.lbl_bomid.TabIndex = 338;
            this.lbl_bomid.Tag = "1";
            this.lbl_bomid.Text = "BOM Id";
            this.lbl_bomid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_season
            // 
            this.cmb_season.AddItemCols = 0;
            this.cmb_season.AddItemSeparator = ';';
            this.cmb_season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_season.Caption = "";
            this.cmb_season.CaptionHeight = 17;
            this.cmb_season.CaptionStyle = style41;
            this.cmb_season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_season.ColumnCaptionHeight = 18;
            this.cmb_season.ColumnFooterHeight = 18;
            this.cmb_season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_season.ContentHeight = 17;
            this.cmb_season.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_season.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_season.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_season.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_season.EditorHeight = 17;
            this.cmb_season.EvenRowStyle = style42;
            this.cmb_season.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_season.FooterStyle = style43;
            this.cmb_season.GapHeight = 2;
            this.cmb_season.HeadingStyle = style44;
            this.cmb_season.HighLightRowStyle = style45;
            this.cmb_season.ItemHeight = 15;
            this.cmb_season.Location = new System.Drawing.Point(616, 36);
            this.cmb_season.MatchEntryTimeout = ((long)(2000));
            this.cmb_season.MaxDropDownItems = ((short)(5));
            this.cmb_season.MaxLength = 32767;
            this.cmb_season.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_season.Name = "cmb_season";
            this.cmb_season.OddRowStyle = style46;
            this.cmb_season.PartialRightColumn = false;
            this.cmb_season.PropBag = resources.GetString("cmb_season.PropBag");
            this.cmb_season.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_season.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_season.SelectedStyle = style47;
            this.cmb_season.Size = new System.Drawing.Size(120, 21);
            this.cmb_season.Style = style48;
            this.cmb_season.TabIndex = 343;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(984, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(16, 32);
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(224, 0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(1000, 40);
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "      Project Information";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(984, 97);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(16, 16);
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            // 
            // txt_srfno
            // 
            this.txt_srfno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_srfno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_srfno.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_srfno.ForeColor = System.Drawing.Color.Black;
            this.txt_srfno.Location = new System.Drawing.Point(109, 58);
            this.txt_srfno.MaxLength = 100;
            this.txt_srfno.Name = "txt_srfno";
            this.txt_srfno.Size = new System.Drawing.Size(120, 20);
            this.txt_srfno.TabIndex = 337;
            // 
            // lbl_sefno
            // 
            this.lbl_sefno.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_sefno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sefno.ImageIndex = 0;
            this.lbl_sefno.ImageList = this.img_Label;
            this.lbl_sefno.Location = new System.Drawing.Point(8, 58);
            this.lbl_sefno.Name = "lbl_sefno";
            this.lbl_sefno.Size = new System.Drawing.Size(100, 21);
            this.lbl_sefno.TabIndex = 336;
            this.lbl_sefno.Tag = "1";
            this.lbl_sefno.Text = "SRF No";
            this.lbl_sefno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(144, 96);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox13.TabIndex = 24;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(0, 97);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(168, 20);
            this.pictureBox14.TabIndex = 22;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(0, 24);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(168, 79);
            this.pictureBox15.TabIndex = 25;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(152, 24);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(1000, 72);
            this.pictureBox16.TabIndex = 27;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox17.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(472, 72);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(1000, 72);
            this.pictureBox17.TabIndex = 27;
            this.pictureBox17.TabStop = false;
            // 
            // lbl_lot_7
            // 
            this.lbl_lot_7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lot_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_lot_7.Location = new System.Drawing.Point(950, 47);
            this.lbl_lot_7.Name = "lbl_lot_7";
            this.lbl_lot_7.Size = new System.Drawing.Size(60, 21);
            this.lbl_lot_7.TabIndex = 114;
            this.lbl_lot_7.Text = "ETS - 7";
            this.lbl_lot_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_lot_5
            // 
            this.lbl_lot_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lot_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_lot_5.Location = new System.Drawing.Point(884, 47);
            this.lbl_lot_5.Name = "lbl_lot_5";
            this.lbl_lot_5.Size = new System.Drawing.Size(60, 21);
            this.lbl_lot_5.TabIndex = 113;
            this.lbl_lot_5.Text = "ETS - 5";
            this.lbl_lot_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Outgoing_mat_list
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flg_mat_list);
            this.Name = "Form_Outgoing_mat_list";
            
            this.Load += new System.EventHandler(this.Form_Outgoing_mat_list_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.flg_mat_list, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flg_mat_list)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sampletype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수
		private int show_level = 1;
		private int w_level_1 = 5;
		private Color c_level_1 = Color.Red;
        private Color m_level_1 = Color.FromArgb(224, 142, 31);
		private int w_level_2 = 7;
		private Color c_level_2 = Color.Yellow;
        private Color m_level_2 = Color.FromArgb(187, 245, 10);
		private int w_level_3 = 12;
		private Color c_level_3 = Color.Gray; 
		private int _RowFixed;

        private string arg_factory = "";
        private string arg_sr_no = "";
        private string arg_srf_no = "";
        private string arg_bom_id = "";
        private string arg_bom_rev = "";
        private string arg_nf_cd = "";
        private string arg_upload_upd_user = "";
		#endregion

        #region 생성자
        public Form_Outgoing_mat_list()
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }

        public Form_Outgoing_mat_list(string _factory, string _sr_no, string _srf_no, string _bom_id, string _bom_rev, string _nf_cd, string _upload_upd_user)
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
            
            arg_factory = _factory;
            arg_sr_no = _sr_no;
            arg_srf_no = _srf_no;
            arg_bom_id = _bom_id;
            arg_bom_rev = _bom_rev;
            arg_nf_cd = _nf_cd;
            arg_upload_upd_user = _upload_upd_user;
        }
        #endregion

        #region Form Loading
        private void Form_Outgoing_mat_list_Load(object sender, System.EventArgs e)
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
            cmb_factory.Enabled = false;            
        }
        private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (cmb_factory.SelectedIndex == -1) return;
            COM.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
            Init_Form();
        }

        private void Init_Form()
        {
            this.Text = "PCC_Forecast Mat. Stock for Model";
            this.lbl_MainTitle.Text = "PCC_Forecast Mat. Stock for Model";
            ClassLib.ComFunction.SetLangDic(this);

            lbl_ets_5.BackColor = c_level_1;
            lbl_ets_7.BackColor = c_level_2;

            DataTable dt_ret = SELECT_SEASON();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_season, 0, 1, true, 0, 120);
            cmb_season.SelectedIndex = 0;

            dt_ret = dt_ret = ClassLib.ComFunction.Select_Category_List(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxCDC_Category);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 1, 2, true, 0, 120);
            cmb_category.SelectedIndex = 0;

            dt_ret = SELECT_ROUND();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampletype, 0, 1, true, 0, 120);
            cmb_sampletype.SelectedIndex = 0;

            #region Upload  User설정            
            dt_ret = SELECT_LOADUSER();
            cmb_user.Enabled = true;
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_user, 0, 0, true, 0, 150);
            cmb_user.SelectedIndex = 0;
            #endregion

            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), COM.ComVar.CxCDC_OutSch_status);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_status, 1, 2, true, 0, 120);
            cmb_status.SelectedIndex = 1;

            flg_mat_list.Set_Grid_CDC("SXO_OUT_MAT_LIST", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
            flg_mat_list.Set_Action_Image(img_Action);
            _RowFixed = flg_mat_list.Rows.Count;
            flg_mat_list.ExtendLastCol = false;
            flg_mat_list.Tree.Column = (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_1;
            flg_mat_list.GetCellRange(flg_mat_list.Rows.Fixed - 2, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_3, flg_mat_list.Rows.Fixed - 2, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_3).StyleNew.TextAlign = TextAlignEnum.LeftCenter;

            tbtn_Delete.Enabled = false;
            tbtn_Color.Enabled = false;
            tbtn_Confirm.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Append.Enabled = false;
            tbtn_New.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Insert.Enabled = false;

            lbl_lot_5.BackColor = c_level_1;
            lbl_lot_7.BackColor = c_level_2;
            
            if (!arg_factory.Equals(""))
            {
                cmb_factory.SelectedValue = arg_factory;
                txt_sr_no.Text = arg_sr_no;
                txt_srfno.Text = arg_srf_no;
                txt_bomid.Text = arg_bom_id;
                cmb_sampletype.SelectedValue = arg_nf_cd;
                cmb_user.SelectedValue = arg_upload_upd_user;

                cmb_status.SelectedIndex = 0;

                tbtn_Search_Click(null, null);
            }
        }

        private DataTable SELECT_SEASON()
        {
            string Proc_Name = "PKG_SXD_ORDER_01.SELECT_SEASON";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_ROUND()
        {
            string Proc_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXB_NF_DESC";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable SELECT_LOADUSER()
        {
            string Proc_Name = "PKG_SXD_SRF_01_SELECT.SELECT_SXD_SRF_LOADUSER";

            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion

        #region Search Data
        public void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                flg_mat_list.Rows.Count = _RowFixed;
                string status = cmb_status.SelectedValue.ToString().Trim();
                if (status == "N")
                    status = "01";
                if (status == "C")
                    status = "02";
                if (status == "R")
                    status = "03";
                if (status == "P")
                    status = "04";

                string[] arg_value = new string[9];

                arg_value[0] = cmb_factory.SelectedValue.ToString();
                arg_value[1] = txt_sr_no.Text.Trim();
                arg_value[2] = txt_srfno.Text.Trim();
                arg_value[3] = txt_bomid.Text.Trim();
                arg_value[4] = cmb_sampletype.SelectedValue.ToString();
                arg_value[5] = cmb_category.SelectedValue.ToString();
                arg_value[6] = cmb_season.SelectedValue.ToString();
                arg_value[7] = cmb_user.SelectedValue.ToString();
                arg_value[8] = status;               

                DataTable dt = SEARCH_DATA(arg_value);

                int dt_rows = dt.Rows.Count;
                int dt_cols = dt.Columns.Count;

                if (dt_cols > 0)
                {
                    for (int i = 0; i < dt_rows; i++)
                    {
                        int t_level = int.Parse(dt.Rows[i].ItemArray[(int)ClassLib.TBSXO_OUT_MAT_LIST.IxTREE_LEV].ToString());
                        flg_mat_list.Rows.InsertNode(flg_mat_list.Rows.Count, t_level);

                        for (int j = 0; j < flg_mat_list.Cols.Count; j++)
                        {
                            flg_mat_list[flg_mat_list.Rows.Count - 1, j] = dt.Rows[i].ItemArray[j].ToString();
                        }

                        flg_mat_list.Rows[flg_mat_list.Rows.Count - 1].StyleNew.BackColor = Color.White;
                        if (flg_mat_list[flg_mat_list.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxTREE_LEV].ToString().Equals("3"))
                        {

                            int lead_time = int.Parse(flg_mat_list[flg_mat_list.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_15].ToString());
                            if (lead_time < 7)
                                flg_mat_list.GetCellRange(flg_mat_list.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_9).StyleNew.BackColor = c_level_2;
                            if (lead_time < 5)
                                flg_mat_list.GetCellRange(flg_mat_list.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_9).StyleNew.BackColor = c_level_1;

                            flg_mat_list.Rows[flg_mat_list.Rows.Count - 1].AllowEditing = true;

                        }
                        if (flg_mat_list[flg_mat_list.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxTREE_LEV].ToString().Equals("4"))
                        {
                            flg_mat_list.Rows[flg_mat_list.Rows.Count - 1].StyleNew.BackColor = Color.WhiteSmoke;

                            int lead_time = int.Parse(flg_mat_list[flg_mat_list.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_15].ToString());
                            if (lead_time < 7)
                                flg_mat_list.GetCellRange(flg_mat_list.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_9).StyleNew.BackColor = c_level_2;
                            if (lead_time < 5)
                                flg_mat_list.GetCellRange(flg_mat_list.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_9).StyleNew.BackColor = c_level_1;

                            flg_mat_list.Rows[flg_mat_list.Rows.Count - 1].AllowEditing = false;

                        }
                        flg_mat_list.GetCellRange(flg_mat_list.Rows.Count - 1, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_9).StyleNew.ForeColor = Color.Black;
                    }
                }

                flg_mat_list.Tree.Show(3);
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

        private DataTable SEARCH_DATA(string [] arg_value)
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(10);

            //01.PROCEDURE명
            OraDB.Process_Name = "PKG_SXG_MPS_02_SELECT.SELECT_SRF_MAT_LIST";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_SR_NO";
            OraDB.Parameter_Name[2] = "ARG_SRF_NO";
            OraDB.Parameter_Name[3] = "ARG_BOM_ID";
            OraDB.Parameter_Name[4] = "ARG_NF_CD";
            OraDB.Parameter_Name[5] = "ARG_CATEGORY";
            OraDB.Parameter_Name[6] = "ARG_SEASON_CD";
            OraDB.Parameter_Name[7] = "ARG_LOAD_UPD_USER";
            OraDB.Parameter_Name[8] = "ARG_STATUS";
            OraDB.Parameter_Name[9] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[9] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = arg_value[0];
            OraDB.Parameter_Values[1] = arg_value[1];
            OraDB.Parameter_Values[2] = arg_value[2];
            OraDB.Parameter_Values[3] = arg_value[3];
            OraDB.Parameter_Values[4] = arg_value[4];
            OraDB.Parameter_Values[5] = arg_value[5];
            OraDB.Parameter_Values[6] = arg_value[6];
            OraDB.Parameter_Values[7] = arg_value[7];
            OraDB.Parameter_Values[8] = arg_value[8];
            OraDB.Parameter_Values[9] = "";

            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];
        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int sct_row = flg_mat_list.Selection.r1;
                int sct_col = flg_mat_list.Selection.c1;

                flg_mat_list.Select(flg_mat_list.Selection.r1, 0, flg_mat_list.Selection.r1, flg_mat_list.Cols.Count - 1, false);

                for (int i = _RowFixed; i < flg_mat_list.Rows.Count; i++)
                {
                    if (flg_mat_list[i, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxDIVISION].Equals("U"))
                    {
                        string factory = flg_mat_list[i, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxFACTORY].ToString();
                        string lot_no  = flg_mat_list[i, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxLOT_NO].ToString();
                        string lot_seq = flg_mat_list[i, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxLOT_SEQ].ToString();

                        string ets = flg_mat_list[i, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_9].ToString();

                        if (int.Parse(ets) < int.Parse(DateTime.Now.ToString("yyyyMMdd")))
                        {
                            MessageBox.Show("Input Date is earlier than now.");
                            return;
                        }

                        DataTable dt_list = SELECT_CUTTING_DATE();

                        if (dt_list.Rows.Count > 0)
                        {
                            string cutting = dt_list.Rows[0].ItemArray[0].ToString();

                            if (int.Parse(ets) < int.Parse(cutting))
                            {
                                MessageBox.Show("Input Date is earlier than Cutting Date");
                                return;
                            }
                        }

                        int etsYear = 0;
                        int etsMonth = 0;
                        int etsDay = 0;

                        try
                        {
                            etsYear = int.Parse(ets.Trim().Substring(0, 4));
                            etsMonth = int.Parse(ets.Trim().Substring(4, 2));
                            etsDay = int.Parse(ets.Trim().Substring(6, 2));
                        }
                        catch
                        {
                            MessageBox.Show("Input Error : Wrong Date");
                            flg_mat_list.TopRow = i;
                            flg_mat_list.Select(i, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_11);
                            return;
                        }

                        if (etsMonth == 0 || etsMonth > 12)
                        {
                            MessageBox.Show("Input Error : Wrong Date");
                            flg_mat_list.TopRow = i;
                            flg_mat_list.Select(i, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_11);
                            return;
                        }

                        if (etsDay > int.Parse(DateTime.DaysInMonth(etsYear, etsMonth).ToString()))
                        {
                            MessageBox.Show("Input Error : Wrong Date");
                            flg_mat_list.TopRow = i;
                            flg_mat_list.Select(i, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxCOL_11);
                            return;
                        }

                        SAVE_ETS(factory, lot_no, lot_seq, ets);
                    }
                }

                tbtn_Search_Click(null, null);
                flg_mat_list.Select(sct_row, sct_col);
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

        private DataTable SELECT_CUTTING_DATE()
        {
            OraDB.ReDim_Parameter(2);
            OraDB.Process_Name = "PKG_SXG_MPS_01_SELECT.SELECT_CUTTING_DATE";

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[OraDB.Process_Name];
        }
        private void SAVE_ETS(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_ets)
        {

            string Proc_Name = "PKG_SXG_MPS_02.SAVE_ETS";

            OraDB.ReDim_Parameter(5);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_LOT_NO";
            OraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[3] = "ARG_ETS";
            OraDB.Parameter_Name[4] = "ARG_UPD_USER";


            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_lot_no;
            OraDB.Parameter_Values[2] = arg_lot_seq;
            OraDB.Parameter_Values[3] = arg_ets;
            OraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }
        #endregion

        #region Grid Event
        private void flg_mat_list_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            int sct_row = flg_mat_list.Selection.r1;
            flg_mat_list.Update_Row(sct_row);
        }

        private void flg_mat_list_MouseClick(object sender, MouseEventArgs e)
        {
            if (flg_mat_list.Rows.Count == flg_mat_list.Rows.Fixed)
                return;

            int sct_row = flg_mat_list.Selection.r1;

            if (flg_mat_list.Rows[sct_row].Node.Level.Equals(1) || flg_mat_list.Rows[sct_row].Node.Level.Equals(2))
            {
                mnu_work_sheet.Enabled = false;
            }
            else
            {
                mnu_work_sheet.Enabled = true;
            }
        }

        #endregion

        #region ContextMenu Event
		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			show_lev = 1;
			flg_mat_list.Tree.Show(show_lev);
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			show_lev = 2;
			flg_mat_list.Tree.Show(show_lev);
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			show_lev = 3;
			flg_mat_list.Tree.Show(show_lev);
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			show_lev = 4;
			flg_mat_list.Tree.Show(show_lev);
        }
        
        private void mnu_work_sheet_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = flg_mat_list.Selection.r1;
                string arg_lot_no = flg_mat_list[sct_row, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxLOT_NO].ToString();
                string arg_lot_seq = flg_mat_list[sct_row, (int)ClassLib.TBSXO_OUT_MAT_LIST.IxLOT_SEQ].ToString();


                DataTable dt_ret = SELECT_WS_LOADING_INFO(arg_lot_no, arg_lot_seq);

                string arg_factory = dt_ret.Rows[0].ItemArray[0].ToString();
                string arg_category = dt_ret.Rows[0].ItemArray[1].ToString();
                string arg_season_cd = dt_ret.Rows[0].ItemArray[2].ToString();
                string arg_sr_no = dt_ret.Rows[0].ItemArray[3].ToString();
                string arg_srf_no = dt_ret.Rows[0].ItemArray[4].ToString();
                string arg_bom_id = dt_ret.Rows[0].ItemArray[5].ToString();
                string arg_nf_cd = dt_ret.Rows[0].ItemArray[6].ToString();
                string arg_load_upd_user = dt_ret.Rows[0].ItemArray[7].ToString();

                CDC_Bom.Form_Project_Manager ws = new FlexCDC.CDC_Bom.Form_Project_Manager("Y", arg_factory, arg_category, arg_season_cd, arg_sr_no, arg_srf_no, arg_bom_id, arg_nf_cd, arg_load_upd_user);

                ws.MdiParent = this.MdiParent;
                ws.WindowState = FormWindowState.Maximized;
                ws.Show();
            }
            catch
            {
            }
        }

        private DataTable SELECT_WS_LOADING_INFO(string arg_lot_no, string arg_lot_seq)
        {
            string Proc_Name = "pkg_sxg_mps_01_select.get_ws_loading_info";

            OraDB.ReDim_Parameter(4);
            OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_lot_no";
            OraDB.Parameter_Name[2] = "arg_lot_seq";
            OraDB.Parameter_Name[3] = "out_cursor";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = arg_lot_no;
            OraDB.Parameter_Values[2] = arg_lot_seq;
            OraDB.Parameter_Values[3] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion		            
    }
}

