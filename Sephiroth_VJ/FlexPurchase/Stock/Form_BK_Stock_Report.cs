using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Stock
{
	public class Form_BK_Stock_Report : COM.PCHWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label label5;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.TextBox txt_styleCode;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private C1.Win.C1List.C1Combo cmb_purUser;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private System.Windows.Forms.Label lbl_shipType;
		private System.Windows.Forms.Label lbl_shipDate;
		private System.Windows.Forms.Label lbl_matType;
		private C1.Win.C1List.C1Combo cmb_matType;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.Label lbl_itemGroup;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_search;
		private C1.Win.C1List.C1Combo cmb_searchProv;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem mnu_exlSave;

		#region 멤버 변수

		private const string _startCol = "A1", _endCol = "AV";
		private const string ERROR = "error";
		private COM.OraDB MyOraDB = new COM.OraDB();
		private string _itemGroupCode;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmb_import;
		private Hashtable _qtyCols;

		#endregion


		#region 생성자 / 소멸자

		public Form_BK_Stock_Report()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BK_Stock_Report));
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
            C1.Win.C1List.Style style57 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style58 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style59 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style60 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style61 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style62 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style63 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style64 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style65 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style66 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style67 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style68 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style69 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style70 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style71 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style72 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.cmb_searchProv = new C1.Win.C1List.C1Combo();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_import = new C1.Win.C1List.C1Combo();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.cmb_purUser = new C1.Win.C1List.C1Combo();
            this.cmb_shipType = new C1.Win.C1List.C1Combo();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.lbl_matType = new System.Windows.Forms.Label();
            this.cmb_matType = new C1.Win.C1List.C1Combo();
            this.lbl_style = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.txt_styleCode = new System.Windows.Forms.TextBox();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.lbl_itemGroup = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.fgrid_main = new COM.FSP();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.mnu_exlSave = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_searchProv)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_import)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_matType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 29;
            this.c1Sizer1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.lbl_search);
            this.panel2.Controls.Add(this.cmb_searchProv);
            this.panel2.Location = new System.Drawing.Point(8, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 38);
            this.panel2.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_search.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ImageIndex = 0;
            this.btn_search.ImageList = this.img_Button;
            this.btn_search.Location = new System.Drawing.Point(911, 7);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(80, 24);
            this.btn_search.TabIndex = 548;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseDown);
            this.btn_search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseUp);
            // 
            // lbl_search
            // 
            this.lbl_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_search.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ImageIndex = 0;
            this.lbl_search.ImageList = this.img_Label;
            this.lbl_search.Location = new System.Drawing.Point(589, 8);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(100, 21);
            this.lbl_search.TabIndex = 547;
            this.lbl_search.Text = "Error Search";
            this.lbl_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_searchProv
            // 
            this.cmb_searchProv.AddItemCols = 0;
            this.cmb_searchProv.AddItemSeparator = ';';
            this.cmb_searchProv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_searchProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_searchProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_searchProv.Caption = "";
            this.cmb_searchProv.CaptionHeight = 17;
            this.cmb_searchProv.CaptionStyle = style1;
            this.cmb_searchProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_searchProv.ColumnCaptionHeight = 18;
            this.cmb_searchProv.ColumnFooterHeight = 18;
            this.cmb_searchProv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_searchProv.ContentHeight = 16;
            this.cmb_searchProv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_searchProv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_searchProv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_searchProv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_searchProv.EditorHeight = 16;
            this.cmb_searchProv.EvenRowStyle = style2;
            this.cmb_searchProv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_searchProv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_searchProv.FooterStyle = style3;
            this.cmb_searchProv.GapHeight = 2;
            this.cmb_searchProv.HeadingStyle = style4;
            this.cmb_searchProv.HighLightRowStyle = style5;
            this.cmb_searchProv.ItemHeight = 15;
            this.cmb_searchProv.Location = new System.Drawing.Point(690, 8);
            this.cmb_searchProv.MatchEntryTimeout = ((long)(2000));
            this.cmb_searchProv.MaxDropDownItems = ((short)(5));
            this.cmb_searchProv.MaxLength = 32767;
            this.cmb_searchProv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_searchProv.Name = "cmb_searchProv";
            this.cmb_searchProv.OddRowStyle = style6;
            this.cmb_searchProv.PartialRightColumn = false;
            this.cmb_searchProv.PropBag = resources.GetString("cmb_searchProv.PropBag");
            this.cmb_searchProv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_searchProv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_searchProv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_searchProv.SelectedStyle = style7;
            this.cmb_searchProv.Size = new System.Drawing.Size(220, 20);
            this.cmb_searchProv.Style = style8;
            this.cmb_searchProv.TabIndex = 546;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.cmb_import);
            this.pnl_head.Controls.Add(this.txt_vendorCode);
            this.pnl_head.Controls.Add(this.cmb_vendor);
            this.pnl_head.Controls.Add(this.lbl_vendor);
            this.pnl_head.Controls.Add(this.lbl_user);
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.cmb_purUser);
            this.pnl_head.Controls.Add(this.cmb_shipType);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.label5);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.lbl_shipDate);
            this.pnl_head.Controls.Add(this.lbl_matType);
            this.pnl_head.Controls.Add(this.cmb_matType);
            this.pnl_head.Controls.Add(this.lbl_style);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.txt_styleCode);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.lbl_itemGroup);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 114);
            this.pnl_head.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(666, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 555;
            this.label1.Text = "Import Division";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_import
            // 
            this.cmb_import.AddItemCols = 0;
            this.cmb_import.AddItemSeparator = ';';
            this.cmb_import.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_import.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_import.Caption = "";
            this.cmb_import.CaptionHeight = 17;
            this.cmb_import.CaptionStyle = style9;
            this.cmb_import.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_import.ColumnCaptionHeight = 18;
            this.cmb_import.ColumnFooterHeight = 18;
            this.cmb_import.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_import.ContentHeight = 16;
            this.cmb_import.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_import.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_import.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_import.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_import.EditorHeight = 16;
            this.cmb_import.EvenRowStyle = style10;
            this.cmb_import.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_import.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_import.FooterStyle = style11;
            this.cmb_import.GapHeight = 2;
            this.cmb_import.HeadingStyle = style12;
            this.cmb_import.HighLightRowStyle = style13;
            this.cmb_import.ItemHeight = 15;
            this.cmb_import.Location = new System.Drawing.Point(767, 84);
            this.cmb_import.MatchEntryTimeout = ((long)(2000));
            this.cmb_import.MaxDropDownItems = ((short)(5));
            this.cmb_import.MaxLength = 32767;
            this.cmb_import.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_import.Name = "cmb_import";
            this.cmb_import.OddRowStyle = style14;
            this.cmb_import.PartialRightColumn = false;
            this.cmb_import.PropBag = resources.GetString("cmb_import.PropBag");
            this.cmb_import.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_import.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_import.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_import.SelectedStyle = style15;
            this.cmb_import.Size = new System.Drawing.Size(220, 20);
            this.cmb_import.Style = style16;
            this.cmb_import.TabIndex = 554;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(438, 84);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(79, 21);
            this.txt_vendorCode.TabIndex = 552;
            this.txt_vendorCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_vendorCode_KeyUp);
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemCols = 0;
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style17;
            this.cmb_vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_vendor.ColumnCaptionHeight = 18;
            this.cmb_vendor.ColumnFooterHeight = 18;
            this.cmb_vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_vendor.ContentHeight = 16;
            this.cmb_vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_vendor.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_vendor.EditorHeight = 16;
            this.cmb_vendor.EvenRowStyle = style18;
            this.cmb_vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style19;
            this.cmb_vendor.GapHeight = 2;
            this.cmb_vendor.HeadingStyle = style20;
            this.cmb_vendor.HighLightRowStyle = style21;
            this.cmb_vendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(518, 84);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style22;
            this.cmb_vendor.PartialRightColumn = false;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style23;
            this.cmb_vendor.Size = new System.Drawing.Size(140, 20);
            this.cmb_vendor.Style = style24;
            this.cmb_vendor.TabIndex = 553;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(337, 84);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 551;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_user
            // 
            this.lbl_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ImageIndex = 0;
            this.lbl_user.ImageList = this.img_Label;
            this.lbl_user.Location = new System.Drawing.Point(337, 62);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_user.TabIndex = 545;
            this.lbl_user.Text = "User";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(892, 40);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(73, 21);
            this.txt_itemGroup.TabIndex = 544;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style25;
            this.cmb_itemGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_itemGroup.ColumnCaptionHeight = 18;
            this.cmb_itemGroup.ColumnFooterHeight = 18;
            this.cmb_itemGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_itemGroup.ContentHeight = 16;
            this.cmb_itemGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_itemGroup.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_itemGroup.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_itemGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_itemGroup.EditorHeight = 16;
            this.cmb_itemGroup.EvenRowStyle = style26;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style27;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style28;
            this.cmb_itemGroup.HighLightRowStyle = style29;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(767, 40);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style30;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style31;
            this.cmb_itemGroup.Size = new System.Drawing.Size(124, 20);
            this.cmb_itemGroup.Style = style32;
            this.cmb_itemGroup.TabIndex = 543;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(966, 40);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 542;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // cmb_purUser
            // 
            this.cmb_purUser.AddItemCols = 0;
            this.cmb_purUser.AddItemSeparator = ';';
            this.cmb_purUser.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purUser.Caption = "";
            this.cmb_purUser.CaptionHeight = 17;
            this.cmb_purUser.CaptionStyle = style33;
            this.cmb_purUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_purUser.ColumnCaptionHeight = 18;
            this.cmb_purUser.ColumnFooterHeight = 18;
            this.cmb_purUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_purUser.ContentHeight = 16;
            this.cmb_purUser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_purUser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_purUser.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_purUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_purUser.EditorHeight = 16;
            this.cmb_purUser.EvenRowStyle = style34;
            this.cmb_purUser.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purUser.FooterStyle = style35;
            this.cmb_purUser.GapHeight = 2;
            this.cmb_purUser.HeadingStyle = style36;
            this.cmb_purUser.HighLightRowStyle = style37;
            this.cmb_purUser.ItemHeight = 15;
            this.cmb_purUser.Location = new System.Drawing.Point(438, 62);
            this.cmb_purUser.MatchEntryTimeout = ((long)(2000));
            this.cmb_purUser.MaxDropDownItems = ((short)(5));
            this.cmb_purUser.MaxLength = 32767;
            this.cmb_purUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purUser.Name = "cmb_purUser";
            this.cmb_purUser.OddRowStyle = style38;
            this.cmb_purUser.PartialRightColumn = false;
            this.cmb_purUser.PropBag = resources.GetString("cmb_purUser.PropBag");
            this.cmb_purUser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purUser.SelectedStyle = style39;
            this.cmb_purUser.Size = new System.Drawing.Size(220, 20);
            this.cmb_purUser.Style = style40;
            this.cmb_purUser.TabIndex = 541;
            // 
            // cmb_shipType
            // 
            this.cmb_shipType.AddItemCols = 0;
            this.cmb_shipType.AddItemSeparator = ';';
            this.cmb_shipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipType.Caption = "";
            this.cmb_shipType.CaptionHeight = 17;
            this.cmb_shipType.CaptionStyle = style41;
            this.cmb_shipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipType.ColumnCaptionHeight = 18;
            this.cmb_shipType.ColumnFooterHeight = 18;
            this.cmb_shipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipType.ContentHeight = 16;
            this.cmb_shipType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipType.EditorHeight = 16;
            this.cmb_shipType.EvenRowStyle = style42;
            this.cmb_shipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipType.FooterStyle = style43;
            this.cmb_shipType.GapHeight = 2;
            this.cmb_shipType.HeadingStyle = style44;
            this.cmb_shipType.HighLightRowStyle = style45;
            this.cmb_shipType.ItemHeight = 15;
            this.cmb_shipType.Location = new System.Drawing.Point(109, 84);
            this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipType.MaxDropDownItems = ((short)(5));
            this.cmb_shipType.MaxLength = 32767;
            this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipType.Name = "cmb_shipType";
            this.cmb_shipType.OddRowStyle = style46;
            this.cmb_shipType.PartialRightColumn = false;
            this.cmb_shipType.PropBag = resources.GetString("cmb_shipType.PropBag");
            this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipType.SelectedStyle = style47;
            this.cmb_shipType.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipType.Style = style48;
            this.cmb_shipType.TabIndex = 394;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 62);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 389;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(230, 62);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 390;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(211, 62);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 391;
            this.label5.Text = "~";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_shipType
            // 
            this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipType.ImageIndex = 0;
            this.lbl_shipType.ImageList = this.img_Label;
            this.lbl_shipType.Location = new System.Drawing.Point(8, 84);
            this.lbl_shipType.Name = "lbl_shipType";
            this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipType.TabIndex = 388;
            this.lbl_shipType.Text = "Ship Type";
            this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipDate
            // 
            this.lbl_shipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipDate.ImageIndex = 1;
            this.lbl_shipDate.ImageList = this.img_Label;
            this.lbl_shipDate.Location = new System.Drawing.Point(8, 62);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 387;
            this.lbl_shipDate.Text = "Ship Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_matType
            // 
            this.lbl_matType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_matType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matType.ImageIndex = 0;
            this.lbl_matType.ImageList = this.img_Label;
            this.lbl_matType.Location = new System.Drawing.Point(666, 62);
            this.lbl_matType.Name = "lbl_matType";
            this.lbl_matType.Size = new System.Drawing.Size(100, 21);
            this.lbl_matType.TabIndex = 379;
            this.lbl_matType.Text = "Materal Type";
            this.lbl_matType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_matType
            // 
            this.cmb_matType.AddItemCols = 0;
            this.cmb_matType.AddItemSeparator = ';';
            this.cmb_matType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_matType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_matType.Caption = "";
            this.cmb_matType.CaptionHeight = 17;
            this.cmb_matType.CaptionStyle = style49;
            this.cmb_matType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_matType.ColumnCaptionHeight = 18;
            this.cmb_matType.ColumnFooterHeight = 18;
            this.cmb_matType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_matType.ContentHeight = 16;
            this.cmb_matType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_matType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_matType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_matType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_matType.EditorHeight = 16;
            this.cmb_matType.EvenRowStyle = style50;
            this.cmb_matType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_matType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_matType.FooterStyle = style51;
            this.cmb_matType.GapHeight = 2;
            this.cmb_matType.HeadingStyle = style52;
            this.cmb_matType.HighLightRowStyle = style53;
            this.cmb_matType.ItemHeight = 15;
            this.cmb_matType.Location = new System.Drawing.Point(767, 62);
            this.cmb_matType.MatchEntryTimeout = ((long)(2000));
            this.cmb_matType.MaxDropDownItems = ((short)(5));
            this.cmb_matType.MaxLength = 32767;
            this.cmb_matType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_matType.Name = "cmb_matType";
            this.cmb_matType.OddRowStyle = style54;
            this.cmb_matType.PartialRightColumn = false;
            this.cmb_matType.PropBag = resources.GetString("cmb_matType.PropBag");
            this.cmb_matType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_matType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_matType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_matType.SelectedStyle = style55;
            this.cmb_matType.Size = new System.Drawing.Size(220, 20);
            this.cmb_matType.Style = style56;
            this.cmb_matType.TabIndex = 13;
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(337, 40);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 366;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style57;
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
            this.cmb_factory.EvenRowStyle = style58;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style59;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style60;
            this.cmb_factory.HighLightRowStyle = style61;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style62;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style63;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style64;
            this.cmb_factory.TabIndex = 1;
            // 
            // txt_styleCode
            // 
            this.txt_styleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCode.Location = new System.Drawing.Point(438, 40);
            this.txt_styleCode.MaxLength = 10;
            this.txt_styleCode.Name = "txt_styleCode";
            this.txt_styleCode.Size = new System.Drawing.Size(79, 21);
            this.txt_styleCode.TabIndex = 11;
            this.txt_styleCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCode_KeyUp);
            // 
            // cmb_style
            // 
            this.cmb_style.AddItemCols = 0;
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style65;
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
            this.cmb_style.EvenRowStyle = style66;
            this.cmb_style.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style67;
            this.cmb_style.GapHeight = 2;
            this.cmb_style.HeadingStyle = style68;
            this.cmb_style.HighLightRowStyle = style69;
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(518, 40);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style70;
            this.cmb_style.PartialRightColumn = false;
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style71;
            this.cmb_style.Size = new System.Drawing.Size(140, 20);
            this.cmb_style.Style = style72;
            this.cmb_style.TabIndex = 12;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_SelectedValueChanged);
            // 
            // lbl_itemGroup
            // 
            this.lbl_itemGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemGroup.ImageIndex = 0;
            this.lbl_itemGroup.ImageList = this.img_Label;
            this.lbl_itemGroup.Location = new System.Drawing.Point(666, 40);
            this.lbl_itemGroup.Name = "lbl_itemGroup";
            this.lbl_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemGroup.TabIndex = 365;
            this.lbl_itemGroup.Text = "Item Group";
            this.lbl_itemGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 98);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 97);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 40);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 50;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 73);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(984, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "      Stock Report";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(208, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(960, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 98);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(168, 20);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // pic_head6
            // 
            this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 16);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 87);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ContextMenu = this.contextMenu1;
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(8, 118);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(1000, 408);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 0;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_exlSave});
            // 
            // mnu_exlSave
            // 
            this.mnu_exlSave.Index = 0;
            this.mnu_exlSave.Text = "Save as excel file";
            this.mnu_exlSave.Click += new System.EventHandler(this.mnu_exlSave_Click);
            // 
            // Form_BK_Stock_Report
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BK_Stock_Report";
            this.Load += new System.EventHandler(this.Form_BK_Stock_Report_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_searchProv)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_import)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_matType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion


		#region 그리드 이벤트

		private void mnu_exlSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
					saveExcel();
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

		#endregion


		#region 툴바 이벤트

		private void Form_BK_Stock_Report_Load(object sender, System.EventArgs e)
		{
			init_form();
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			clear();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			select();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            		
		}
		
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			COM.ComVar.Parameter_PopUp = new string[]{
														ClassLib.ComFunction.Empty_Combo(cmb_factory, ""),
														dpick_from.Text.Replace("-", ""), 
														dpick_to.Text.Replace("-", "") 
													 };

            Pop_BK_Stock_Report_Print print = new Pop_BK_Stock_Report_Print();
			print.ShowDialog();
		}
		
		#endregion


		#region 컨트롤 이벤트

		private void cmb_style_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				txt_styleCode.Text = cmb_style.SelectedValue.ToString().Trim();
			}
			catch {}
		}

		private void txt_styleCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && txt_styleCode.Text.Length > 3)
			{
				Txt_StyleCdKeyUpProcess();
			}
		}

		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if ( cmb_itemGroup.SelectedIndex >= 1 )
			{
				this.btn_groupSearch.Enabled = true;
			}
			else
			{
				txt_itemGroup.Text = "";
				_itemGroupCode = "";
				this.btn_groupSearch.Enabled = false;
			}
		}

		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
			string vTyep = this.cmb_itemGroup.SelectedValue.ToString();
			FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);

			vPopup.ShowDialog();
			
			_itemGroupCode			= COM.ComVar.Parameter_PopUp[3];
			this.txt_itemGroup.Text	= COM.ComVar.Parameter_PopUp[4];

			vPopup.Dispose();
		
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			search();
		}

		private void txt_vendorCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.searchVendor();;
			}
		}

		private void cmb_vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				selectVendor();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "vendor search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            btn_search.ImageIndex = 1;
		}

		private void btn_search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_search.ImageIndex = 0;
		}
		
		#endregion


		#region 이벤트 처리 메서드

		private void init_form() 
		{
			try
			{
                // form
                this.Text = "Stock Report";
                lbl_MainTitle.Text = "Stock Report";
                ClassLib.ComFunction.SetLangDic(this);

				// grid
				fgrid_main.Set_Grid("SBK_STOCK_REPORT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_main.Rows[1].AllowMerging = true;
				fgrid_main.Set_Action_Image(img_Action, true); 

				// factory
				DataTable vDt = null;
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
				vDt.Dispose() ;

				// ship type
				vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBS14");
				COM.ComCtl.Set_ComboList(vDt, cmb_shipType, 1, 2, true);
				cmb_shipType.SelectedIndex = 0;
				vDt.Dispose();

				// user
				vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory, "");
				COM.ComCtl.Set_ComboList(vDt, cmb_purUser, 1, 1, true, false);
				cmb_purUser.SelectedIndex = 0;
				vDt.Dispose();

				// item group
				vDt = FlexPurchase.ClassLib.ComFunction.Select_GroupTypeCode();
				COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, false, 45, 60);
				cmb_itemGroup.SelectedIndex = 0;
				vDt.Dispose();

				// amt type
				vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBS13");
				COM.ComCtl.Set_ComboList(vDt, cmb_matType, 1, 2, true);
				cmb_matType.SelectedIndex = 0;
				vDt.Dispose();

				// search prov
				vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBK05");
				COM.ComCtl.Set_ComboList(vDt, cmb_searchProv, 1, 2, true);
				cmb_searchProv.SelectedIndex = 0;
				vDt.Dispose();
                cmb_searchProv.SelectedIndex = 2;
                cmb_searchProv.ReadOnly = true;

				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxLocalLLTDivision); //"SBP13"
				ClassLib.ComCtl.Set_ComboList(vDt, cmb_import, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
				cmb_import.SelectedIndex = 0;
				vDt.Dispose();
				
				// qty col
				_qtyCols = getQtyCols();

				// toolbar button
				tbtn_Save.Enabled = false;
				tbtn_Delete.Enabled = false;
				tbtn_Confirm.Enabled = false;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private Hashtable getQtyCols() 
		{
			Hashtable ht = new Hashtable();

			for (int i = 0 ; i < fgrid_main.Cols.Count ; i++) 
			{
				if ("Quantity".Equals(fgrid_main[1, i]))
				{
                    ht.Add(fgrid_main[2, i], i);
				}
			}

			return ht;
		}

		private void clear()
		{
			try
			{
				cmb_factory.SelectedValue = COM.ComVar.This_Factory;
				cmb_shipType.SelectedIndex = 0;
				cmb_style.ClearItems();
				cmb_purUser.SelectedIndex = 0;
				cmb_vendor.ClearItems();
				cmb_matType.SelectedIndex = 0;
				cmb_itemGroup.SelectedIndex = 0;
				txt_itemGroup.Text = "";

				fgrid_main.ClearAll();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void select() 
		{
			try 
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = this.SELECT_SBK_STOCK_REPORT_LIST();

                if (vDt != null && vDt.Rows.Count > 0)
				{
                    fgrid_main.ClearAll();
                    for (int vRow = 0; vRow < vDt.Rows.Count; vRow++)
                    {
                        //******arg_grid.Rows.Fixed + vRow******/
                        fgrid_main.AddItem(vDt.Rows[vRow].ItemArray);
                    }
					// ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_main, vDt);

                    //for (int i = fgrid_main.Rows.Fixed ; i < fgrid_main.Rows.Count ; i++)
                    //{
                    //    if (vDt.Rows[i - fgrid_main.Rows.Fixed]["GRP"].ToString().Equals("02"))
                    //        fgrid_main.GetCellRange(i, fgrid_main.Cols.Frozen, i, fgrid_main.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.RightPink2;
                    //    else
                    //        fgrid_main.GetCellRange(i, fgrid_main.Cols.Frozen, i, fgrid_main.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.RightBlue;
                    //}

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else 
				{
					fgrid_main.ClearAll();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "select", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				cmb_searchProv.SelectedIndex = 0;
				this.Cursor = Cursors.Default;
			}
		}

		private void search() 
		{
			try 
			{
				if (ClassLib.ComFunction.Empty_Combo(cmb_searchProv, "").Equals(" ")) 
				{
					for (int i = fgrid_main.Rows.Fixed ; i < fgrid_main.Rows.Count ; i++)
					{
						fgrid_main.Rows[i].Visible = true;
					}
				}
				else
				{
					string selProv = cmb_searchProv.GetItemText(cmb_searchProv.SelectedIndex, 1);

					string[] schProv = selProv.Replace(" - ", "-").Split('-');

					int col1 = Convert.ToInt32(_qtyCols[schProv[0]]);
					int col2 = Convert.ToInt32(_qtyCols[schProv[1]]);

					for (int i = fgrid_main.Rows.Fixed ; i < fgrid_main.Rows.Count ; i++)
					{
						int value1 = Convert.ToInt32(fgrid_main[i, col1]);
						int value2 = Convert.ToInt32(fgrid_main[i, col2]);

						if (value1 != value2)
						{
							fgrid_main.Rows[i].Visible = true;
							fgrid_main[i, fgrid_main.Cols.Count - 1] = ERROR;
						}
						else
						{
							fgrid_main.Rows[i].Visible = false;
							fgrid_main[i, fgrid_main.Cols.Count - 1] = "";
						}
					}
				}
			} 
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "error search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void saveExcel()
		{
			Excel.Application oXL;
			Excel._Workbook oWB;
			Excel._Worksheet oSheet;

			try
			{
				this.Cursor = Cursors.WaitCursor;

				//Start Excel and get Application object.
				oXL = new Excel.Application();
				
				oXL.Visible = false;
				oXL.UserControl = false;

				//Get a new workbook.
				oWB = (Excel._Workbook)(oXL.Workbooks.Add(true));
				oSheet = (Excel._Worksheet)oWB.ActiveSheet;

				object[,] values = new object[fgrid_main.Rows.Count, fgrid_main.Cols.Count];

				for (int vRow = fgrid_main.Rows.Fixed - 2, rIdx = 0 ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					if (fgrid_main.Rows[vRow].Visible)
					{
						for (int vCol = 1, cIdx = 0 ; vCol < fgrid_main.Cols.Count ; vCol++)
						{
							if (fgrid_main.Cols[vCol].Visible)
							{
								values[rIdx, cIdx] = fgrid_main[vRow, vCol];
								cIdx++;
							}
						}
						
						rIdx++;
					}
				}

				oSheet.get_Range(_startCol, _endCol + fgrid_main.Rows.Count).NumberFormat = "@";
				oSheet.get_Range(_startCol, _endCol + fgrid_main.Rows.Count).Value2 = values;

				oXL.Visible = true;
				oXL.UserControl = true;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;

				oSheet = null;
				oWB = null;
				oXL = null;
				GC.Collect();
			}
		}

		private void searchVendor()
		{
			DataTable vDt;
			vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_vendorCode.Text);
			COM.ComCtl.Set_ComboList(vDt, cmb_vendor, 0, 1, true, 79, 141);
			vDt.Dispose();

			cmb_vendor.SelectedValue = txt_vendorCode.Text;
		}

		private void selectVendor()
		{
			if (cmb_vendor.SelectedIndex != -1)
				txt_vendorCode.Text		 = cmb_vendor.SelectedValue.ToString();
		}


		private void Txt_StyleCdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCode, " "));

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				COM.ComCtl.Set_ComboList(vDt, cmb_style, 0, 1, true, 80, 130); 
				string vStyle = txt_styleCode.Text.Replace("-", "");
				vStyle = vStyle.Substring(0, 6) + "-" + vStyle.Substring(6, 3);
				cmb_style.SelectedValue = vStyle.Trim();
			}
			catch {}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}

		#endregion


		#region DB Connect

		/// <summary>
		/// PKG_SBK_STOCK_REPORT : stock report list
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBK_STOCK_REPORT_LIST()
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(11);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBK_STOCK_REPORT.SELECT_SBK_STOCK_REPORT_LIST_2";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[4] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[5] = "ARG_GROUP_CD";
			MyOraDB.Parameter_Name[6] = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[7] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[8] = "ARG_MAT_TYPE";
			MyOraDB.Parameter_Name[9] = "ARG_IMPORT";
			MyOraDB.Parameter_Name[10] = "OUT_CURSOR";

			//03.DATA TYPE 정의
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
			MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[5] = _itemGroupCode;
			MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_Combo(cmb_purUser, "");
			MyOraDB.Parameter_Values[7] = ClassLib.ComFunction.Empty_Combo(cmb_vendor, "");
			MyOraDB.Parameter_Values[8] = ClassLib.ComFunction.Empty_Combo(cmb_matType, "");
			MyOraDB.Parameter_Values[9] = ClassLib.ComFunction.Empty_Combo(cmb_import, "");
			MyOraDB.Parameter_Values[10] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		#endregion

	}
}

