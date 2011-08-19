using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexPurchase.Purchase
{
	public class Form_BP_Order : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.Label lbl_head;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Panel pnl_low;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.TextBox txt_styleCode;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.Label lbl_season;
		private System.Windows.Forms.Label lbl_size;
		private System.Windows.Forms.Label lbl_order;
		private C1.Win.C1List.C1Combo cmb_season;
		private C1.Win.C1List.C1Combo cmb_size;
		private C1.Win.C1List.C1Combo cmb_order;

		#endregion

		#region 사용자 정의 변수

		private Hashtable _cellCombo = null;
		private COM.OraDB MyOraDB = new COM.OraDB();
		
		private int _factoryCol = (int)ClassLib.TBSBP_ORDER.IxFACTORY;
		private int _seasonCol = (int)ClassLib.TBSBP_ORDER.IxSEASON;
		private int _styleCol = (int)ClassLib.TBSBP_ORDER.IxSTYLE_CD;
		private System.Windows.Forms.Panel pnl_Search;
		private int _sizeCol = (int)ClassLib.TBSBP_ORDER.IxCS_SIZE;


		#endregion

		#region 생성자 / 소멸자

		public Form_BP_Order()
		{
			InitializeComponent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BP_Order));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_low = new System.Windows.Forms.Panel();
			this.btn_delete = new System.Windows.Forms.Label();
			this.btn_recover = new System.Windows.Forms.Label();
			this.btn_Insert = new System.Windows.Forms.Label();
			this.fgrid_main = new COM.FSP();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.cmb_order = new C1.Win.C1List.C1Combo();
			this.lbl_order = new System.Windows.Forms.Label();
			this.cmb_size = new C1.Win.C1List.C1Combo();
			this.lbl_size = new System.Windows.Forms.Label();
			this.cmb_season = new C1.Win.C1List.C1Combo();
			this.lbl_season = new System.Windows.Forms.Label();
			this.txt_styleCode = new System.Windows.Forms.TextBox();
			this.cmb_style = new C1.Win.C1List.C1Combo();
			this.lbl_style = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_head = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_low.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_order)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_size)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_season)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Menu
			// 
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Name = "c1ToolBar1";
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
			this.c1Sizer1.Controls.Add(this.pnl_low);
			this.c1Sizer1.Controls.Add(this.fgrid_main);
			this.c1Sizer1.Controls.Add(this.pnl_Search);
			this.c1Sizer1.GridDefinition = "16.1458333333333:False:True;76.3888888888889:False:False;4.6875:False:False;\t0.39" +
				"3700787401575:False:True;97.6377952755905:False:False;0.393700787401575:False:Tr" +
				"ue;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_low
			// 
			this.pnl_low.BackColor = System.Drawing.Color.Transparent;
			this.pnl_low.Controls.Add(this.btn_delete);
			this.pnl_low.Controls.Add(this.btn_recover);
			this.pnl_low.Controls.Add(this.btn_Insert);
			this.pnl_low.Location = new System.Drawing.Point(12, 545);
			this.pnl_low.Name = "pnl_low";
			this.pnl_low.Size = new System.Drawing.Size(992, 27);
			this.pnl_low.TabIndex = 169;
			// 
			// btn_delete
			// 
			this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_delete.ImageIndex = 5;
			this.btn_delete.ImageList = this.image_List;
			this.btn_delete.Location = new System.Drawing.Point(830, 2);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 24);
			this.btn_delete.TabIndex = 363;
			this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			this.btn_delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseUp);
			this.btn_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_delete_MouseDown);
			// 
			// btn_recover
			// 
			this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_recover.ImageIndex = 1;
			this.btn_recover.ImageList = this.image_List;
			this.btn_recover.Location = new System.Drawing.Point(912, 2);
			this.btn_recover.Name = "btn_recover";
			this.btn_recover.Size = new System.Drawing.Size(80, 24);
			this.btn_recover.TabIndex = 353;
			this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
			this.btn_recover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseUp);
			this.btn_recover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cancel_MouseDown);
			// 
			// btn_Insert
			// 
			this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Insert.ImageIndex = 9;
			this.btn_Insert.ImageList = this.image_List;
			this.btn_Insert.Location = new System.Drawing.Point(748, 2);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(80, 24);
			this.btn_Insert.TabIndex = 352;
			this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
			this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseUp);
			this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseDown);
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(12, 101);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(992, 440);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 168;
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			this.fgrid_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyUp);
			// 
			// pnl_Search
			// 
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.cmb_order);
			this.pnl_Search.Controls.Add(this.lbl_order);
			this.pnl_Search.Controls.Add(this.cmb_size);
			this.pnl_Search.Controls.Add(this.lbl_size);
			this.pnl_Search.Controls.Add(this.cmb_season);
			this.pnl_Search.Controls.Add(this.lbl_season);
			this.pnl_Search.Controls.Add(this.txt_styleCode);
			this.pnl_Search.Controls.Add(this.cmb_style);
			this.pnl_Search.Controls.Add(this.lbl_style);
			this.pnl_Search.Controls.Add(this.cmb_factory);
			this.pnl_Search.Controls.Add(this.lbl_factory);
			this.pnl_Search.Controls.Add(this.pictureBox1);
			this.pnl_Search.Controls.Add(this.pictureBox2);
			this.pnl_Search.Controls.Add(this.pictureBox3);
			this.pnl_Search.Controls.Add(this.lbl_head);
			this.pnl_Search.Controls.Add(this.pictureBox4);
			this.pnl_Search.Controls.Add(this.pictureBox5);
			this.pnl_Search.Controls.Add(this.pictureBox6);
			this.pnl_Search.Controls.Add(this.pictureBox7);
			this.pnl_Search.Controls.Add(this.pictureBox8);
			this.pnl_Search.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_Search.Location = new System.Drawing.Point(12, 4);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(992, 93);
			this.pnl_Search.TabIndex = 167;
			// 
			// cmb_order
			// 
			this.cmb_order.AddItemCols = 0;
			this.cmb_order.AddItemSeparator = ';';
			this.cmb_order.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_order.AutoSize = false;
			this.cmb_order.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_order.Caption = "";
			this.cmb_order.CaptionHeight = 17;
			this.cmb_order.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_order.ColumnCaptionHeight = 18;
			this.cmb_order.ColumnFooterHeight = 18;
			this.cmb_order.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_order.ContentHeight = 17;
			this.cmb_order.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_order.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_order.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_order.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_order.EditorHeight = 17;
			this.cmb_order.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_order.GapHeight = 2;
			this.cmb_order.ItemHeight = 15;
			this.cmb_order.Location = new System.Drawing.Point(755, 40);
			this.cmb_order.MatchEntryTimeout = ((long)(2000));
			this.cmb_order.MaxDropDownItems = ((short)(5));
			this.cmb_order.MaxLength = 32767;
			this.cmb_order.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_order.Name = "cmb_order";
			this.cmb_order.PartialRightColumn = false;
			this.cmb_order.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_order.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_order.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_order.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_order.Size = new System.Drawing.Size(220, 21);
			this.cmb_order.TabIndex = 1;
			// 
			// lbl_order
			// 
			this.lbl_order.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_order.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_order.ImageIndex = 0;
			this.lbl_order.ImageList = this.img_Label;
			this.lbl_order.Location = new System.Drawing.Point(654, 40);
			this.lbl_order.Name = "lbl_order";
			this.lbl_order.Size = new System.Drawing.Size(100, 21);
			this.lbl_order.TabIndex = 180;
			this.lbl_order.Text = "Order Type";
			this.lbl_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_size
			// 
			this.cmb_size.AddItemCols = 0;
			this.cmb_size.AddItemSeparator = ';';
			this.cmb_size.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_size.AutoSize = false;
			this.cmb_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_size.Caption = "";
			this.cmb_size.CaptionHeight = 17;
			this.cmb_size.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_size.ColumnCaptionHeight = 18;
			this.cmb_size.ColumnFooterHeight = 18;
			this.cmb_size.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_size.ContentHeight = 17;
			this.cmb_size.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_size.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_size.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_size.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_size.EditorHeight = 17;
			this.cmb_size.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_size.GapHeight = 2;
			this.cmb_size.ItemHeight = 15;
			this.cmb_size.Location = new System.Drawing.Point(432, 62);
			this.cmb_size.MatchEntryTimeout = ((long)(2000));
			this.cmb_size.MaxDropDownItems = ((short)(5));
			this.cmb_size.MaxLength = 32767;
			this.cmb_size.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_size.Name = "cmb_size";
			this.cmb_size.PartialRightColumn = false;
			this.cmb_size.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_size.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_size.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_size.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_size.Size = new System.Drawing.Size(220, 21);
			this.cmb_size.TabIndex = 1;
			// 
			// lbl_size
			// 
			this.lbl_size.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_size.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_size.ImageIndex = 0;
			this.lbl_size.ImageList = this.img_Label;
			this.lbl_size.Location = new System.Drawing.Point(331, 62);
			this.lbl_size.Name = "lbl_size";
			this.lbl_size.Size = new System.Drawing.Size(100, 21);
			this.lbl_size.TabIndex = 180;
			this.lbl_size.Text = "Size";
			this.lbl_size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_season
			// 
			this.cmb_season.AddItemCols = 0;
			this.cmb_season.AddItemSeparator = ';';
			this.cmb_season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_season.AutoSize = false;
			this.cmb_season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_season.Caption = "";
			this.cmb_season.CaptionHeight = 17;
			this.cmb_season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_season.ColumnCaptionHeight = 18;
			this.cmb_season.ColumnFooterHeight = 18;
			this.cmb_season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_season.ContentHeight = 17;
			this.cmb_season.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_season.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_season.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_season.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_season.EditorHeight = 17;
			this.cmb_season.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_season.GapHeight = 2;
			this.cmb_season.ItemHeight = 15;
			this.cmb_season.Location = new System.Drawing.Point(109, 62);
			this.cmb_season.MatchEntryTimeout = ((long)(2000));
			this.cmb_season.MaxDropDownItems = ((short)(5));
			this.cmb_season.MaxLength = 32767;
			this.cmb_season.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_season.Name = "cmb_season";
			this.cmb_season.PartialRightColumn = false;
			this.cmb_season.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_season.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_season.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_season.Size = new System.Drawing.Size(220, 21);
			this.cmb_season.TabIndex = 1;
			// 
			// lbl_season
			// 
			this.lbl_season.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_season.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_season.ImageIndex = 0;
			this.lbl_season.ImageList = this.img_Label;
			this.lbl_season.Location = new System.Drawing.Point(8, 62);
			this.lbl_season.Name = "lbl_season";
			this.lbl_season.Size = new System.Drawing.Size(100, 21);
			this.lbl_season.TabIndex = 180;
			this.lbl_season.Text = "Season";
			this.lbl_season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_styleCode
			// 
			this.txt_styleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_styleCode.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_styleCode.Location = new System.Drawing.Point(432, 40);
			this.txt_styleCode.MaxLength = 10;
			this.txt_styleCode.Name = "txt_styleCode";
			this.txt_styleCode.Size = new System.Drawing.Size(79, 21);
			this.txt_styleCode.TabIndex = 366;
			this.txt_styleCode.Text = "";
			this.txt_styleCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_styleCd_KeyUp);
			// 
			// cmb_style
			// 
			this.cmb_style.AddItemCols = 0;
			this.cmb_style.AddItemSeparator = ';';
			this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_style.AutoSize = false;
			this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_style.Caption = "";
			this.cmb_style.CaptionHeight = 17;
			this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_style.ColumnCaptionHeight = 18;
			this.cmb_style.ColumnFooterHeight = 18;
			this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_style.ContentHeight = 17;
			this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_style.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_style.EditorHeight = 17;
			this.cmb_style.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_style.GapHeight = 2;
			this.cmb_style.ItemHeight = 15;
			this.cmb_style.Location = new System.Drawing.Point(512, 40);
			this.cmb_style.MatchEntryTimeout = ((long)(2000));
			this.cmb_style.MaxDropDownItems = ((short)(5));
			this.cmb_style.MaxLength = 32767;
			this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_style.Name = "cmb_style";
			this.cmb_style.PartialRightColumn = false;
			this.cmb_style.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_style.Size = new System.Drawing.Size(140, 21);
			this.cmb_style.TabIndex = 367;
			this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_TextChanged);
			// 
			// lbl_style
			// 
			this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_style.ImageIndex = 0;
			this.lbl_style.ImageList = this.img_Label;
			this.lbl_style.Location = new System.Drawing.Point(331, 40);
			this.lbl_style.Name = "lbl_style";
			this.lbl_style.Size = new System.Drawing.Size(100, 21);
			this.lbl_style.TabIndex = 368;
			this.lbl_style.Text = "Style";
			this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_factory.AutoSize = false;
			this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_factory.Caption = "";
			this.cmb_factory.CaptionHeight = 17;
			this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_factory.ColumnCaptionHeight = 18;
			this.cmb_factory.ColumnFooterHeight = 18;
			this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_factory.ContentHeight = 17;
			this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(109, 40);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(220, 21);
			this.cmb_factory.TabIndex = 1;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 180;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(891, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(101, 55);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(976, 0);
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
			this.pictureBox3.Size = new System.Drawing.Size(944, 32);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_head
			// 
			this.lbl_head.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_head.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_head.ForeColor = System.Drawing.Color.Navy;
			this.lbl_head.Image = ((System.Drawing.Image)(resources.GetObject("lbl_head.Image")));
			this.lbl_head.Location = new System.Drawing.Point(0, 0);
			this.lbl_head.Name = "lbl_head";
			this.lbl_head.Size = new System.Drawing.Size(231, 30);
			this.lbl_head.TabIndex = 28;
			this.lbl_head.Text = "      Order Info.";
			this.lbl_head.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(976, 78);
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
			this.pictureBox5.Location = new System.Drawing.Point(144, 77);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(944, 18);
			this.pictureBox5.TabIndex = 24;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 78);
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
			this.pictureBox7.Size = new System.Drawing.Size(168, 60);
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
			this.pictureBox8.Location = new System.Drawing.Point(160, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(944, 53);
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			// 
			// Form_BP_Order
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_BP_Order";
			this.Load += new System.EventHandler(this.Form_Load);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_low.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_order)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_size)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_season)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((e.Col == _factoryCol || e.Col == _seasonCol || e.Col == _styleCol || e.Col == _sizeCol) && 
				!ClassLib.ComFunction.NullToBlank(fgrid_main[e.Row, 0]).Equals(ClassLib.ComVar.Insert))
				e.Cancel = true;

			this.Grid_BeforeEditProcess();
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				this.MultiChange();
			}
		}

		private void fgrid_main_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if (e.KeyData == Keys.E && e.Modifiers == Keys.Control && fgrid_main.Col != 0)
				{
					this.MultiChange();
				}
//				else if (e.KeyData == Keys.Delete && fgrid_main.Col != 0)
//				{
//					int[] vSels = fgrid_main.Selections;
//
//					foreach (int vRow in vSels)
//					{
//						fgrid_main[vRow, fgrid_main.Col] = "";
//					}
//				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Key Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (this.Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
			{
				this.Tbtn_SearchProcess();
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (this.Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.Tbtn_SaveProcess();
			}
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
				
		}
	
		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		private void txt_styleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				this.Txt_StyleCdKeyUpProcess();
		}

		private void cmb_style_TextChanged(object sender, System.EventArgs e)
		{
			txt_styleCode.Text = cmb_style.SelectedValue.ToString();
		}

		private void Txt_StyleCdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCode, " "));
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(vDt, cmb_style, 0, 1, 2, 3, 4, true, 100, 221); 
				vDt.Dispose();
				
				if (txt_styleCode.Text.Length == 9)
				{
					string vCode = txt_styleCode.Text;
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

		#region 컨텍스트 메뉴 이벤트


		#endregion

		#region 버튼 이벤트 - Insert, Delete, Cancel

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
			Row vNewRow = fgrid_main.Rows.Add();

			int vRow = vNewRow.Index;
			int vCol = 1;

//			// 그리드 세팅. 처음 입력한 경우 default 세팅, 바로 앞 열과 동일하게 세팅.
			if (fgrid_main.Rows.Fixed + 1 == fgrid_main.Rows.Count)
			{
				vCol = (int)ClassLib.TBSBP_ORDER.IxBOM_ISSUE;
				int vEndCol = (int)ClassLib.TBSBP_ORDER.IxREMARKS;

				while (vCol < vEndCol)
				{
					//fgrid_main[vRow, vCol] = DateTime.Now;
					vCol++;
				}
			}
			else
			{
				int vEndCol = (int)ClassLib.TBSBP_ORDER.IxSTYLE_NAME;

				while (vCol < vEndCol)
				{
					fgrid_main[vRow, vCol] = fgrid_main[vRow - 1, vCol];
					vCol++;
				}
			}

			vNewRow[0] = ClassLib.ComVar.Insert;
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Delete_Row();
		}

		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Recover_Row();
		}

		#endregion
		
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

		#region 이벤트 처리 메소드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
			try
			{
				Init_Grid();
				Init_Combo();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Init_Grid()
		{
			// 초기화
			this.Text = "Sales Order";
            lbl_MainTitle.Text = "Sales Order";
			ClassLib.ComFunction.SetLangDic(this);

			// 그리드 설정
			fgrid_main.Set_Grid("SBP_ORDER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);

			// set grid cell type
			_cellCombo = new Hashtable(fgrid_main.Cols.Count);

			for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
			{
				if (fgrid_main.Cols[vCol].AllowEditing)
				{
					if (fgrid_main.Cols[vCol].DataMap != null)
					{
						_cellCombo.Add(vCol, fgrid_main.GetDataSourceWithCode(vCol));
					}
				}
			}
		}
		
		private void Init_Combo()
		{
			DataTable vDt = null;

			// factory
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, true);
			cmb_factory.SelectedValue = COM.ComVar.This_Factory;
			vDt.Dispose();

			// season
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SEM15");
			COM.ComCtl.Set_ComboList(vDt, cmb_season, 1, 2, true, 80, 140);
			cmb_season.SelectedIndex = 0;
			vDt.Dispose();

			// order bype
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SEM10");
			COM.ComCtl.Set_ComboList(vDt, cmb_order, 1, 2, true, 80, 140);
			cmb_order.SelectedIndex = 0;
			vDt.Dispose();
		
			// size
			vDt = SELECT_SIZE_COLHEAD_REQ();
			COM.ComCtl.Set_ComboList(vDt, cmb_size, 0, 0, true, 0, 220);
			cmb_size.SelectedIndex = 0;
			vDt.Dispose();
		}

		#endregion
		
		#region 툴바 메뉴 이벤트
		
		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_main.ClearAll();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			DataTable vDt = null;

			try
			{
				this.Cursor = Cursors.WaitCursor;

				vDt = this.SELECT_SBP_ORDER();

				if (vDt.Rows.Count > 0)
				{
					ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_main, vDt);
				}
				else
				{
					fgrid_main.ClearAll();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				if (vDt != null)	vDt.Dispose();
			}
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SBP_ORDER())
				{
					ClassLib.ComFunction.User_Message("Save Complete!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					fgrid_main.Refresh_Division();
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		#endregion

		#region 컨트롤 이벤트

		#endregion

		#region 컨텍스트 메뉴 이벤트

		private void MultiChange()
		{
			try
			{
				int[] vSelectionRange = fgrid_main.Selections;
				int vCol = fgrid_main.Selection.c1;

				if (vSelectionRange.Length == 0)	return;

				COM.ComVar.Parameter_PopUp		= new string[2];
				COM.ComVar.Parameter_PopUp[0]	= fgrid_main[1, vCol].ToString();
	
				if (_cellCombo.ContainsKey(vCol))
					ClassLib.ComVar.Parameter_PopUp_Object = new object[]{_cellCombo[vCol]};

				if (fgrid_main.Cols[vCol].Style.DataType.Equals(typeof(System.DateTime)))
				{
					COM.ComVar.Parameter_PopUp[0]	= "Date";
					COM.ComVar.Parameter_PopUp[1]	= fgrid_main[1, vCol].ToString();
				}

				FlexPurchase.Shipping.Pop_BS_Shipping_List_Changer pop_changer = new FlexPurchase.Shipping.Pop_BS_Shipping_List_Changer();
				pop_changer.ShowDialog();

				if (COM.ComVar.Parameter_PopUp != null)
				{
					if ((vCol == _factoryCol || vCol == _seasonCol || vCol == _styleCol || vCol == _sizeCol))
					{
						// 신규 등록만 수정
							foreach (int i in vSelectionRange)
							{
								if (ClassLib.ComFunction.NullToBlank(fgrid_main[i, 0]).Equals(ClassLib.ComVar.Insert))
								{
									fgrid_main[i, vCol] = COM.ComVar.Parameter_PopUp[0];
									if (COM.ComVar.Parameter_PopUp.Length > 1)
									{
										fgrid_main[i, (int)ClassLib.TBSBP_ORDER.IxSTYLE_NAME] = COM.ComVar.Parameter_PopUp[0];
										fgrid_main[i, (int)ClassLib.TBSBP_ORDER.IxSTYLE_CD] = COM.ComVar.Parameter_PopUp[1];
									}
									else
									{
										fgrid_main[i, vCol] = COM.ComVar.Parameter_PopUp[0];
									}

									fgrid_main.Update_Row(i);
								}
						}
					}
					else
					{
						// 모두 수정 가능
						foreach (int i in vSelectionRange)
						{
							fgrid_main[i, vCol] = COM.ComVar.Parameter_PopUp[0];
							if (COM.ComVar.Parameter_PopUp.Length > 1)
							{
								fgrid_main[i, (int)ClassLib.TBSBP_ORDER.IxSTYLE_NAME] = COM.ComVar.Parameter_PopUp[0];
								fgrid_main[i, (int)ClassLib.TBSBP_ORDER.IxSTYLE_CD] = COM.ComVar.Parameter_PopUp[1];
							}
							else
							{
								fgrid_main[i, vCol] = COM.ComVar.Parameter_PopUp[0];
							}

							fgrid_main.Update_Row(i);
						}
					}
				}

				pop_changer.Dispose();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Multi Change", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		#endregion

		#region 그리드 이벤트

		private void Grid_AfterEditProcess()
		{
			fgrid_main.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		#endregion

		#region 정합성 체크

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			try
			{
				// 공통 체크
				if (cmb_factory.SelectedIndex == -1)
				{
					ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					cmb_factory.Focus();
					return false;
				}

				// 부분별 체크 (Search, Save, Delete, Confirm..)
				switch (arg_type)
				{
					case ClassLib.ComVar.Validate_Search:

						break;
					case ClassLib.ComVar.Validate_Save:
						for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
						{
							if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBP_ORDER.IxFACTORY]).Equals(""))
							{
								ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, (int)ClassLib.TBSBP_ORDER.IxFACTORY);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBP_ORDER.IxSEASON]).Equals(""))
							{
								ClassLib.ComFunction.User_Message("Select Season", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, (int)ClassLib.TBSBP_ORDER.IxSEASON);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBP_ORDER.IxSTYLE_CD]).Equals(""))
							{
								ClassLib.ComFunction.User_Message("Select Style", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, (int)ClassLib.TBSBP_ORDER.IxSTYLE_CD);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBP_ORDER.IxCS_SIZE]).Equals(""))
							{
								ClassLib.ComFunction.User_Message("Select Size", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, (int)ClassLib.TBSBP_ORDER.IxCS_SIZE);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBP_ORDER.IxORDER_QTY]).Equals(""))
							{
								ClassLib.ComFunction.User_Message("Input Order Qty", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, (int)ClassLib.TBSBP_ORDER.IxORDER_QTY);
								return false;
							}
							if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBP_ORDER.IxORDER_QTY]).Equals("0"))
							{
								ClassLib.ComFunction.User_Message("Input Order Qty", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								fgrid_main.Select(vRow, (int)ClassLib.TBSBP_ORDER.IxORDER_QTY);
								return false;
							}
						}					
						break;
					case ClassLib.ComVar.Validate_Delete:

						break;
					case ClassLib.ComVar.Validate_Confirm:

						break;
				}

				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
		}

		#endregion

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBP_ORDER : 오더 정보 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_ORDER()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_ORDER.SELECT_SBP_ORDER";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SEASON";
			MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[3] = "ARG_CS_SIZE";
			MyOraDB.Parameter_Name[4] = "ARG_ORDER_TYPE";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_season, "");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_size, "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_order, "");
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBC_COMMON : 사이즈 전체 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SIZE_COLHEAD_REQ()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SIZE_COLHEAD_REQ";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}



		/// <summary>
		/// PKG_SBP_ORDER : 오더 정보 저장하기
		/// </summary>
		public bool SAVE_SBP_ORDER()
		{
			try
			{
				int vCount = (int)ClassLib.TBSBP_ORDER.IxMaxCt;

				MyOraDB.ReDim_Parameter(vCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_ORDER.SAVE_SBP_ORDER";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;

				for (int vCol = 1 ; vCol < fgrid_main.Cols.Count - 1 ; vCol++)
				{
					MyOraDB.Parameter_Name[vCol] = "ARG_" + fgrid_main[0, vCol].ToString();
					MyOraDB.Parameter_Type[vCol] = (int)OracleType.VarChar;
				}

				ArrayList vList = new ArrayList();

				for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]).Equals(""))
						continue;

					vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]));

					for (int vCol = 1 ; vCol < fgrid_main.Cols.Count - 1 ; vCol++)
					{
						if (fgrid_main[0, vCol].ToString().Equals("UPD_USER"))
						{
							vList.Add(COM.ComVar.This_User);
						}
						else
						{
							if (fgrid_main.Cols[vCol].Style.DataType.Equals(typeof(System.DateTime)))
							{
								if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, vCol]).Equals(""))
								{
									DateTime vTime = (DateTime)fgrid_main[vRow, vCol];
									vList.Add(vTime.ToString("yyyyMMdd"));
								}
								else
								{
									vList.Add("");
								}
							}
							else
							{
								vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, vCol]));
							}
						}
					}
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;

				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Procedure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
		}


		#endregion

	}
}

