using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;

namespace FlexPurchase.Shipping
{
	public class Form_BS_Scan_Out : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.MenuItem mnu_rate;
		private System.Windows.Forms.MenuItem mnu_TradePacking;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenu ctx_bar;
		private COM.SSP spd_bar;
		private FarPoint.Win.Spread.SheetView spd_bar_Sheet1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_shipDate;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label lbl_ShipType;
		private C1.Win.C1List.C1Combo cmb_ShipType;
		private System.Windows.Forms.MenuItem mnu_data;
		private System.Windows.Forms.MenuItem menuItem3;

		#endregion

		#region 사용자 정의 변수

		private Hashtable _cellTypes = null;
		private COM.OraDB MyOraDB	= new COM.OraDB();
		private SheetView _barSheet	= null;
		private Pop_BS_Shipping_List_Wait _pop = null;

		private int _shipNoCol		= (int)ClassLib.TBSBS_BAR_2.IxSHIP_NO;
		private int _purUserCol		= (int)ClassLib.TBSBS_BAR_2.IxUSER;
		private int _pkUnitQtyCol	= (int)ClassLib.TBSBS_BAR_2.IxPK_UNIT_QTY;
		private int _purPriceCol	= (int)ClassLib.TBSBS_BAR_2.IxPUR_PRICE;
		private int _purCurCol		= (int)ClassLib.TBSBS_BAR_2.IxPUR_CURRENCY;
		private int _cbdPriceCol	= (int)ClassLib.TBSBS_BAR_2.IxCBD_PRICE;
		private int _cbdCurCol		= (int)ClassLib.TBSBS_BAR_2.IxCBD_CURRENCY;
		private int _shipPriceCol	= (int)ClassLib.TBSBS_BAR_2.IxSHIP_PRICE;
		private int _shipCurCol		= (int)ClassLib.TBSBS_BAR_2.IxSHIP_CURRENCY;
		private int _weightCol		= (int)ClassLib.TBSBS_BAR_2.IxWEIGHT;
		private int _statusCol		= (int)ClassLib.TBSBS_BAR_2.IxSTATUS;
		private int _custCodeCol	= (int)ClassLib.TBSBS_BAR_2.IxVENDER_CD;
		private System.Windows.Forms.Panel pnl_Search;
		private int _custNameCol	= (int)ClassLib.TBSBS_BAR_2.IxVENDER_NAME;

		#endregion

		#region 생성자 / 소멸자

		public Form_BS_Scan_Out()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BS_Scan_Out));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.lbl_ShipType = new System.Windows.Forms.Label();
			this.cmb_ShipType = new C1.Win.C1List.C1Combo();
			this.dpick_from = new System.Windows.Forms.DateTimePicker();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.lbl_shipDate = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.spd_bar = new COM.SSP();
			this.spd_bar_Sheet1 = new FarPoint.Win.Spread.SheetView();
			this.ctx_bar = new System.Windows.Forms.ContextMenu();
			this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnu_data = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.mnu_rate = new System.Windows.Forms.MenuItem();
			this.mnu_TradePacking = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_bar_Sheet1)).BeginInit();
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
			this.c1Sizer1.Controls.Add(this.pnl_Search);
			this.c1Sizer1.Controls.Add(this.spd_bar);
			this.c1Sizer1.GridDefinition = "12.1527777777778:False:True;85.7638888888889:False:False;\t0.393700787401575:False" +
				":True;97.6377952755905:False:False;0.393700787401575:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_Search
			// 
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.lbl_ShipType);
			this.pnl_Search.Controls.Add(this.cmb_ShipType);
			this.pnl_Search.Controls.Add(this.dpick_from);
			this.pnl_Search.Controls.Add(this.cmb_factory);
			this.pnl_Search.Controls.Add(this.lbl_factory);
			this.pnl_Search.Controls.Add(this.lbl_shipDate);
			this.pnl_Search.Controls.Add(this.pictureBox1);
			this.pnl_Search.Controls.Add(this.pictureBox2);
			this.pnl_Search.Controls.Add(this.pictureBox3);
			this.pnl_Search.Controls.Add(this.label1);
			this.pnl_Search.Controls.Add(this.pictureBox4);
			this.pnl_Search.Controls.Add(this.pictureBox5);
			this.pnl_Search.Controls.Add(this.pictureBox6);
			this.pnl_Search.Controls.Add(this.pictureBox7);
			this.pnl_Search.Controls.Add(this.pictureBox8);
			this.pnl_Search.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_Search.Location = new System.Drawing.Point(12, 4);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(992, 70);
			this.pnl_Search.TabIndex = 167;
			// 
			// lbl_ShipType
			// 
			this.lbl_ShipType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_ShipType.ImageIndex = 0;
			this.lbl_ShipType.ImageList = this.img_Label;
			this.lbl_ShipType.Location = new System.Drawing.Point(653, 40);
			this.lbl_ShipType.Name = "lbl_ShipType";
			this.lbl_ShipType.Size = new System.Drawing.Size(100, 21);
			this.lbl_ShipType.TabIndex = 52;
			this.lbl_ShipType.Text = "Scan Type";
			this.lbl_ShipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_ShipType
			// 
			this.cmb_ShipType.AddItemCols = 0;
			this.cmb_ShipType.AddItemSeparator = ';';
			this.cmb_ShipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_ShipType.AutoSize = false;
			this.cmb_ShipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_ShipType.Caption = "";
			this.cmb_ShipType.CaptionHeight = 17;
			this.cmb_ShipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_ShipType.ColumnCaptionHeight = 18;
			this.cmb_ShipType.ColumnFooterHeight = 18;
			this.cmb_ShipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_ShipType.ContentHeight = 17;
			this.cmb_ShipType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_ShipType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_ShipType.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_ShipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_ShipType.EditorHeight = 17;
			this.cmb_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ShipType.GapHeight = 2;
			this.cmb_ShipType.ItemHeight = 15;
			this.cmb_ShipType.Location = new System.Drawing.Point(754, 40);
			this.cmb_ShipType.MatchEntryTimeout = ((long)(2000));
			this.cmb_ShipType.MaxDropDownItems = ((short)(5));
			this.cmb_ShipType.MaxLength = 32767;
			this.cmb_ShipType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_ShipType.Name = "cmb_ShipType";
			this.cmb_ShipType.PartialRightColumn = false;
			this.cmb_ShipType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_ShipType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_ShipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_ShipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_ShipType.Size = new System.Drawing.Size(220, 21);
			this.cmb_ShipType.TabIndex = 51;
			// 
			// dpick_from
			// 
			this.dpick_from.CustomFormat = "";
			this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_from.Location = new System.Drawing.Point(432, 40);
			this.dpick_from.Name = "dpick_from";
			this.dpick_from.Size = new System.Drawing.Size(220, 21);
			this.dpick_from.TabIndex = 4;
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
			this.lbl_factory.ImageIndex = 1;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 180;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_shipDate
			// 
			this.lbl_shipDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_shipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_shipDate.ImageIndex = 1;
			this.lbl_shipDate.ImageList = this.img_Label;
			this.lbl_shipDate.Location = new System.Drawing.Point(331, 40);
			this.lbl_shipDate.Name = "lbl_shipDate";
			this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
			this.lbl_shipDate.TabIndex = 52;
			this.lbl_shipDate.Text = "Scan Date";
			this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(891, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(101, 32);
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
			this.label1.Text = "      Shipping Info";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(976, 55);
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
			this.pictureBox5.Location = new System.Drawing.Point(144, 54);
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
			this.pictureBox6.Location = new System.Drawing.Point(0, 55);
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
			this.pictureBox7.Size = new System.Drawing.Size(168, 37);
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
			this.pictureBox8.Size = new System.Drawing.Size(944, 30);
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			// 
			// spd_bar
			// 
			this.spd_bar.Location = new System.Drawing.Point(12, 78);
			this.spd_bar.Name = "spd_bar";
			this.spd_bar.Sheets.Add(this.spd_bar_Sheet1);
			this.spd_bar.Size = new System.Drawing.Size(992, 494);
			this.spd_bar.TabIndex = 2;
			this.spd_bar.EditModeOn += new System.EventHandler(this.spd_bar_EditModeOn);
			this.spd_bar.EditModeOff += new System.EventHandler(this.spd_bar_EditModeOff);
			this.spd_bar.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_bar_CellClick);
			this.spd_bar.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_bar_EditChange);
			// 
			// spd_bar_Sheet1
			// 
			this.spd_bar_Sheet1.SheetName = "Sheet1";
			// 
			// ctx_bar
			// 
			this.ctx_bar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnu_AllSelect,
																					this.menuItem1,
																					this.mnu_data,
																					this.menuItem3,
																					this.mnu_rate,
																					this.mnu_TradePacking});
			// 
			// mnu_AllSelect
			// 
			this.mnu_AllSelect.Index = 0;
			this.mnu_AllSelect.Text = "All Select";
			this.mnu_AllSelect.Click += new System.EventHandler(this.mnu_AllSelect_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.Text = "-";
			// 
			// mnu_data
			// 
			this.mnu_data.Index = 2;
			this.mnu_data.Text = "Value Change";
			this.mnu_data.Click += new System.EventHandler(this.mnu_data_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 3;
			this.menuItem3.Text = "-";
			// 
			// mnu_rate
			// 
			this.mnu_rate.Index = 4;
			this.mnu_rate.Text = "CBD Information";
			this.mnu_rate.Click += new System.EventHandler(this.mnu_rate_Click);
			// 
			// mnu_TradePacking
			// 
			this.mnu_TradePacking.Index = 5;
			this.mnu_TradePacking.Text = "Create Shipping And Transmit Invoice";
			this.mnu_TradePacking.Click += new System.EventHandler(this.mnu_TradePacking_Click);
			// 
			// Form_BS_Scan_Out
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_BS_Scan_Out";
			this.Load += new System.EventHandler(this.Form_Load);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_bar_Sheet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void spd_bar_EditModeOn(object sender, System.EventArgs e)
		{
			this.Grid_EditModeOnProcess(spd_bar) ;
		}

		private void spd_bar_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
			spd_bar.Update_Row(img_Action);
		}

		private void spd_bar_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (e.Button == MouseButtons.Right && !e.ColumnHeader)
			{
				if (spd_bar.Sheets[0].Columns[spd_bar.Sheets[0].ActiveColumnIndex].Locked)
					this.mnu_data.Enabled = false;
				else
					this.mnu_data.Enabled = true;

				ctx_bar.Show(spd_bar, new Point(e.X, e.Y));
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
				
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BS_Scan_Out");
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 6;
			string [] aHead =  new string[iCnt];	
			aHead[0] = COM.ComVar.This_Factory;
			aHead[1] = ClassLib.ComFunction.Empty_Combo(this.cmb_factory, "");
			aHead[2] = ClassLib.ComFunction.Empty_Combo(this.cmb_ShipType, "");
			aHead[3] = this.dpick_from.Text.Replace("-", "");
			aHead[4] = this.dpick_from.Text.Replace("-", "");
			aHead[5] = cmb_factory.GetItemText(cmb_factory.SelectedIndex, 1);
		
			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();	
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

		#region 컨텍스트 메뉴 이벤트

		private void mnu_TradePacking_Click(object sender, System.EventArgs e)
		{
			_pop = new Pop_BS_Shipping_List_Wait();

			Thread vCreate = new Thread(new ThreadStart(Mnu_TradePackingClickProcess));
			vCreate.Start();
			_pop.Start();
		}

		private void mnu_rate_Click(object sender, System.EventArgs e)
		{
            this.Mnu_RateClickProcess();		
		}

		private void mnu_AllSelect_Click(object sender, System.EventArgs e)
		{
			Mnu_AllSelectClickProcess();
		}

		private void mnu_data_Click(object sender, System.EventArgs e)
		{
			Mnu_ValueChangeProcess();
		}

		#endregion
		
		#region 입력이동

		#endregion

		#region 버튼효과

		#endregion

		#endregion

		#region 공통 메소드

		// make query
		private string[] Grid_MakeQuery(int arg_StartRow, int arg_EndRow)
		{
			int[] vColumns = new int[]{_shipNoCol};
			string[] vQuery = new string[]{""};
			string vTemp;
			
			for (int vRow = arg_StartRow ; vRow < arg_EndRow ; vRow++)
			{
				for (int vIdx = 0 ; vIdx < vColumns.Length ; vIdx++)
				{
					vTemp = (_barSheet.Cells[vRow, vColumns[vIdx]] == null) ? "" : _barSheet.Cells[vRow, vColumns[vIdx]].Text;
					if (vQuery[vIdx].IndexOf(vTemp) < 0 && !vTemp.Equals(""))
						vQuery[vIdx] += vTemp + "|";
				}
			}

			return ModifyQuery(vQuery);
		}

        // modify query
		private string[] ModifyQuery(string[] arg_proviso)
		{
			for (int vIdx = 0 ; vIdx < arg_proviso.Length ; vIdx++)
			{
				arg_proviso[vIdx] = arg_proviso[vIdx].TrimEnd('|');
				arg_proviso[vIdx] = arg_proviso[vIdx].Replace("|", "', '");
				arg_proviso[vIdx] = "'" + arg_proviso[vIdx] + "'";
			}

			return arg_proviso;
		}

		private void Grid_SetData(DataRow vDt, int arg_row)
		{
			/*****************************************
			 * 0. B.KEY1, 
			 * 1. A.PUR_USER,		2. A.PK_UNIT_QTY,
			 * 3. A.PUR_PRICE,		4. A.PUR_CURRENCY,
			 * 5. A.OUTSIDE_PRICE,	6. A.OUTSIDE_CURRENCY,
			 * 7. A.CBD_PRICE,		8. A.CBD_CURRENCY,
			 * 9. A.SHIP_PRICE,		10.A.SHIP_CURRENCY,
			 * 11.A.WEIGHT,			12.A.CUST_CD
			 *****************************************/
			
			_barSheet.Cells[arg_row, _purUserCol].Value			= vDt.ItemArray[1];
			_barSheet.Cells[arg_row, _pkUnitQtyCol].Value		= vDt.ItemArray[2];
			_barSheet.Cells[arg_row, _purPriceCol].Value		= vDt.ItemArray[3];
			_barSheet.Cells[arg_row, _purCurCol].Value			= vDt.ItemArray[4];
			_barSheet.Cells[arg_row, _cbdPriceCol].Value		= vDt.ItemArray[7];
			_barSheet.Cells[arg_row, _cbdCurCol].Value			= vDt.ItemArray[8];
			_barSheet.Cells[arg_row, _shipPriceCol].Value		= vDt.ItemArray[9];
			_barSheet.Cells[arg_row, _shipCurCol].Value			= vDt.ItemArray[10];
			_barSheet.Cells[arg_row, _weightCol].Value			= vDt.ItemArray[11];
			_barSheet.Cells[arg_row, _custCodeCol].Value		= vDt.ItemArray[12];
		}

		private void Grid_SetColor()
		{
			string vStatus = "";

			for (int i = 0 ; i < this._barSheet.RowCount ; i++)
			{
				vStatus = _barSheet.Cells[i, _statusCol].Text;

				if (vStatus.Equals("S"))
					_barSheet.Cells[i, 1, i, _barSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightPink2;
				else
					_barSheet.Cells[i, 1, i, _barSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightBlue;
			}
		}

		#endregion

		#region 이벤트 처리 메소드

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// 초기화
			// ClassLib.ComFunction.Init_Form_Control(this);
			this.Text = "Shipping List for Invoice";
			lbl_MainTitle.Text = "Shipping List for Invoice";
			ClassLib.ComFunction.SetLangDic(this);

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = COM.ComVar.This_Factory;
			vDt.Dispose();

			// Outgoing Type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxOutgoingType);
			COM.ComCtl.Set_ComboList(vDt, cmb_ShipType, 1, 2, false, 80, 140);
			((DataTable)cmb_ShipType.DataSource).Rows.RemoveAt(0);
			cmb_ShipType.SelectedIndex = 0;
			vDt.Dispose();

			this.tbtn_Delete.Enabled = false;
			this.tbtn_Confirm.Enabled = false;

			// 그리드 설정
			_cellTypes = new Hashtable();

			spd_bar.Set_Spread_Comm("SBS_BAR", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			_barSheet = spd_bar.ActiveSheet;
			for (int vCol = 0 ; vCol < _barSheet.ColumnCount ; vCol++)
			{
				if (_barSheet.ColumnHeader.Cells[1, vCol].Text.Equals(_barSheet.ColumnHeader.Cells[2, vCol].Text))
					_barSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
				else
				{
					_barSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = 2;
					vCol++;
				}
			}

			for (int vCount = 1 ; vCount < _barSheet.Columns.Count ; vCount++)
				if (_barSheet.Columns[vCount].CellType.ToString().Equals(ClassLib.ComVar.SSPComboBoxCell))
				{
					COM.SSPComboBoxCellType sspBox = (COM.SSPComboBoxCellType)_barSheet.Columns[vCount].CellType; 
					_cellTypes.Add(vCount, sspBox.DataSourceWithCode);
				}

		}	
		
		#region 툴바 메뉴 이벤트
		
		private void Tbtn_NewProcess()
		{
			try
			{
				spd_bar.ClearAll();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			DataTable vDt = null;

			try
			{
				this.Cursor = Cursors.WaitCursor;

				vDt = SELECT_SBS_BAR_OUT_LIST();

				if (vDt.Rows.Count > 0)
				{
					spd_bar.Display_Grid(vDt);
					this.Grid_SetColor();
					ClassLib.ComFunction.MergeCell(spd_bar, new int[]{1, 2, 3, 4});
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					spd_bar.ClearAll();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
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

				MyOraDB.Save_Spread("PKG_SBS_BAR_OUT.SAVE_SBS_BAR_OUT_LIST", spd_bar);
				spd_bar.Refresh_Division();
				
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
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

		#region 컨트롤 이벤트

		#endregion

		#region 컨텍스트 메뉴 이벤트

		private void Mnu_RateClickProcess()
		{
			try
			{
				/*****************************************
				0 : FACTORY,	  		1 : PUR_USER,
				2 : CUST_CD,			3 : CUST_NAME,
				4 :	PK_UNIT_QTY,		5 : PUR_PRICE,
				6 :	PUR_CURRENCY, 		7 : OUTSIDE_PRICE,
				8 :	OUTSIDE_CURRENCY, 	9 : CBD_PRICE,
				10 : CBD_CURRENCY,		11 : SHIP_PRICE,
				12 : SHIP_CURRENCY, 	13 : CBM,
				14 : WEIGHT
				*****************************************/
				int[] keys = new int[]{ -1,
										(int)ClassLib.TBSBS_BAR_2.IxSTYLE_CD,
										(int)ClassLib.TBSBS_BAR_2.IxITEM_CD,
										(int)ClassLib.TBSBS_BAR_2.IxSPEC_CD,
										(int)ClassLib.TBSBS_BAR_2.IxCOLOR_CD };

				int[] values = new int[]{ 
											-1,										(int)ClassLib.TBSBS_BAR_2.IxUSER,
											(int)ClassLib.TBSBS_BAR_2.IxVENDER_CD,	(int)ClassLib.TBSBS_BAR_2.IxVENDER_NAME,
											(int)ClassLib.TBSBS_BAR_2.IxPK_UNIT_QTY,
											(int)ClassLib.TBSBS_BAR_2.IxPUR_PRICE,	(int)ClassLib.TBSBS_BAR_2.IxPUR_CURRENCY,
											-1,											-1,
											(int)ClassLib.TBSBS_BAR_2.IxCBD_PRICE,	(int)ClassLib.TBSBS_BAR_2.IxCBD_CURRENCY,
											(int)ClassLib.TBSBS_BAR_2.IxSHIP_PRICE,	(int)ClassLib.TBSBS_BAR_2.IxSHIP_CURRENCY,
											-1,											-1
										};

				Pop_BC_CBD_Information vPop = new Pop_BC_CBD_Information(spd_bar, keys, values);
				vPop._factory = cmb_factory.SelectedValue.ToString();
				vPop.ShowDialog(this);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "mnu_rate_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			/*
			int vStartRow = _barSheet.GetSelection(0).Row;
			int vEndRow	  = vStartRow + _barSheet.GetSelection(0).RowCount;
			
			string[] vProviso = Grid_MakeQuery(vStartRow, vEndRow);
			DataTable vDt = SELECT_SBC_CBD_MASTER_LIST(vProviso[4]);
			if (vDt != null && vDt.Rows.Count > 0)
			{
				vDt.PrimaryKey = new DataColumn[]{vDt.Columns[0]};
				DataRow vDr = null;
				for (int vRow = vStartRow ; vRow < vEndRow ; vRow++)
				{
					vDr = vDt.Rows.Find(_barSheet.Cells[vRow, _keyCol].Text);
					if (vDr != null)
					{
						Grid_SetData(vDr, vRow);
					}
				}
			}
			*/
		}




		// create shipping list
		private void Mnu_TradePackingClickProcess()
		{
			try
			{
				// true(clear), false(누적), false(누적)
				this.Cursor = Cursors.WaitCursor;

				string vFactory		= COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vShipType	= (int)ClassLib.ComVar.ShipTypeEnum.Upper + "";
				string vShipYmd		= System.DateTime.Now.ToShortDateString().Replace("-", "");
				string vUpdUser		= COM.ComVar.This_User;



				if (!UPDATE_SBS_BAR_LIST(vFactory, vShipType, vShipYmd, vUpdUser))
				{
					ClassLib.ComFunction.User_Message("Status Update Fail", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}



				if (!CREATE_SHIPPING_LIST(vFactory, vShipType, vShipYmd, vUpdUser))
				{
					ClassLib.ComFunction.User_Message("Shipping List Create Fail", "Create", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (!INVOICE_TRANSMIT_ETC())
				{
					ClassLib.ComFunction.User_Message("Invoice Trade Fail", "Create", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				



				if (MyOraDB.Exe_Modify_Procedure() != null)
				{

					spd_bar.Refresh_Division();
					ClassLib.ComFunction.User_Message("Process Complete!!", "Create", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				else
				{
					ClassLib.ComFunction.User_Message("Process Fail!!", "Create", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}



				//				if (!INVOICE_TRANSMIT_ETC())
				//				{
				//					ClassLib.ComFunction.User_Message("Invoice Trade Fail", "Create", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				//					return;
				//				}
				//				else
				//				{
				//					spd_bar.Refresh_Division();
				//					ClassLib.ComFunction.User_Message("Process Complete!!", "Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//
				//				}
				//								
				//				


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Create Shipping And Trade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				//MyOraDB.Add_Modify_Parameter(true);				
				this.Cursor = Cursors.Default;
				_pop.Close();

				
			}
		}



		// create shipping list
//		private void Mnu_TradePackingClickProcess()
//		{
//			try
//			{
//				this.Cursor = Cursors.WaitCursor;
//
//				string vFactory		= COM.ComFunction.Empty_Combo(cmb_factory, "");
//				string vShipType	= (int)ClassLib.ComVar.ShipTypeEnum.Upper + "";
//				string vShipYmd		= System.DateTime.Now.ToShortDateString().Replace("-", "");
//				string vUpdUser		= COM.ComVar.This_User;
//
//				CellRange[] vAll = _barSheet.GetSelections();
//
//				for (int vRow = 0 ; vRow < _barSheet.RowCount ; vRow++)
//				{
//					if (!ClassLib.ComFunction.NullToBlank(_barSheet.Cells[vRow, _statusCol].Text).Equals("C"))
//					{
//						_barSheet.Cells[vRow, _statusCol].Text = "M";
//						spd_bar.Update_Row(vRow, img_Action);
//					}
//				}
//
//				if (!MyOraDB.Save_Spread_Ready("PKG_SBS_BAR_OUT.SAVE_SBS_BAR_OUT_LIST", spd_bar, true))
//				{
//					ClassLib.ComFunction.User_Message("Status Update Fail", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//					return;
//				}
//
//				if (!CREATE_SHIPPING_LIST(vFactory, vShipType, vShipYmd, vUpdUser))
//				{
//					ClassLib.ComFunction.User_Message("Shipping List Create Fail", "Create", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//					return;
//				}
//
//				if (!INVOICE_TRANSMIT_ETC())
//				{
//					ClassLib.ComFunction.User_Message("Invoice Trade Fail", "Create", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//					return;
//				}
//
//				if (MyOraDB.Exe_Modify_Procedure() != null)
//				{
//					spd_bar.Refresh_Division();
//					ClassLib.ComFunction.User_Message("Process Complete!!", "Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
//				}
//				else
//				{
//					ClassLib.ComFunction.User_Message("Process Fail!!", "Create", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//				}
//			}
//			catch (Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "Create Shipping And Trade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//			}
//			finally
//			{
//				this.Cursor = Cursors.Default;
//				_pop.Close();
//			}
//		}

		private void Mnu_AllSelectClickProcess()
		{
			_barSheet.AddSelection(0, 1, _barSheet.RowCount, _barSheet.ColumnCount);
		}

		private void Mnu_ValueChangeProcess()//FarPoint.Win.Spread.CellClickEventArgs e)
		{
			try
			{ 
				int vRow = spd_bar.Sheets[0].ActiveRowIndex ;
				int vCol = spd_bar.Sheets[0].ActiveColumnIndex ;

				CellRange vSelectionRange = _barSheet.GetSelection(0);

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp		= new string[2];
					COM.ComVar.Parameter_PopUp[0]	= _barSheet.GetCellType(vRow, vCol).ToString();
					COM.ComVar.Parameter_PopUp[1]	= _barSheet.ColumnHeader.Columns[vCol].Label;
					if (_barSheet.ColumnHeader.Cells[1, vCol].Text.Equals("Vendor"))
						COM.ComVar.Parameter_PopUp[1]	= "Vendor";
				
					if (_cellTypes.ContainsKey(vCol))
					{
						COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComVar.SSPComboBoxCell;

						ClassLib.ComVar.Parameter_PopUp_Object = new object[]{_cellTypes[vCol]};
					}
					FlexPurchase.Purchase.Pop_BP_Purchase_List_Changer pop_changer = new FlexPurchase.Purchase.Pop_BP_Purchase_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
						for (int i = vSelectionRange.Row ; i < vSelectionRange.Row + vSelectionRange.RowCount ; i++)
						{
							if ( _barSheet.GetCellType(vRow, vCol).ToString() == "DateTimeCellType")
								_barSheet.Cells[i, vCol].Value = DateTime.Parse(COM.ComVar.Parameter_PopUp[0]);
							else
							{
								_barSheet.Cells[i, vCol].Value = COM.ComVar.Parameter_PopUp[0];
								if (COM.ComVar.Parameter_PopUp.Length > 1)
								{
									_barSheet.Cells[i, _custCodeCol].Value = COM.ComVar.Parameter_PopUp[1];
									_barSheet.Cells[i, _custNameCol].Value = COM.ComVar.Parameter_PopUp[0];
								}
							}

							spd_bar.Update_Row(i, img_Action);
						}

					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_ValueExchange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		#endregion

		#region 그리드 이벤트

		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = arg_grid.Sheets[0].ActiveRowIndex ;
			int vCol = arg_grid.Sheets[0].ActiveColumnIndex ;
			
			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString() ;
			if ((vTemp == "CheckBoxCellType") || (vTemp == "SSPComboBoxCellType") )
			{
				arg_grid.Buffer_CellData = "000" ;
				arg_grid.Update_Row(img_Action) ;
			}



		}
		#endregion

		#region 정합성 체크

		private bool Etc_ProvisoValidateCheck(int arg_type)
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
					if (_barSheet.RowCount <= 0)
					{
						ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					break;
				case ClassLib.ComVar.Validate_Delete:

					break;
				case ClassLib.ComVar.Validate_Confirm:

					break;
			}

			return true;
		}

		#endregion

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBS_BAR_OUT : 출고 스캔한 데이터 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBS_BAR_OUT_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_BAR_OUT.SELECT_SBS_BAR_OUT_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_SCAN_OUT_YMD_FR";
			MyOraDB.Parameter_Name[4] = "ARG_SCAN_OUT_YMD_TO";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(this.cmb_factory, "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(this.cmb_ShipType, "");
			MyOraDB.Parameter_Values[3] = this.dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = this.dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBC_WAREHOUSE_LOC : 사용중인 warehouse list 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_WAREHOUSE_LIST_USING(string arg_factory)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_WAREHOUSE.SELECT_WAREHOUSE_LIST_USING";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}




		

		/// <summary>
		/// UPDATE_SBS_BAR_LIST: update barcode status
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_ship_type">선적구분</param>
		/// <param name="arg_ship_ymd">선적일</param>
		/// <param name="arg_upd_user">사용자</param>
		/// <param name="arg_ship_no_list">선적번호 리스트</param>
		public bool UPDATE_SBS_BAR_LIST(string arg_factory, string arg_ship_type, string arg_ship_ymd, string arg_upd_user)
		{
			try
			{

				//DataSet   ds_ret;

				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBS_BAR_OUT.SAVE_SBS_BAR_OUT_LIST_01";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_BAR_MOVE";
				MyOraDB.Parameter_Name[2] = "ARG_SCAN_OUT_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";


				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_ShipType, "");
				MyOraDB.Parameter_Values[2] = this.dpick_from.Text.Replace("-", "").Trim();
				MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);				
				return true;



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Create Shipping", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}


		/// <summary>
		/// PKG_SBS_SHIPPING_LIST_ETC : make shipping list
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_ship_type">선적구분</param>
		/// <param name="arg_ship_ymd">선적일</param>
		/// <param name="arg_upd_user">사용자</param>
		/// <param name="arg_ship_no_list">선적번호 리스트</param>
		public bool CREATE_SHIPPING_LIST(string arg_factory, string arg_ship_type, string arg_ship_ymd, string arg_upd_user)
		{
			try
			{

				//DataSet   ds_ret;


				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST_ETC.MAKE_SBS_SHIPPING_LIST";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_BAR_MOVE";
				MyOraDB.Parameter_Name[2] = "ARG_SCAN_OUT_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_ShipType, "");
				MyOraDB.Parameter_Values[2] = this.dpick_from.Text.Replace("-", "").Trim();
				MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(false);
				return true;

				
				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Create Shipping", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		/// <summary>
		/// PKG_SBS_SHIPPING_LIST_ETC : INVOICE TRADE
		/// </summary>
		public bool INVOICE_TRANSMIT_ETC()
		{
			try
			{
				//				DataSet   ds_ret;
				MyOraDB.ReDim_Parameter(2);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST_ETC.INVOICE_TRANSMIT_ETC";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(false);
				return true;

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Invoice Trade", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		#endregion								

		private void spd_bar_EditModeOff(object sender, System.EventArgs e)
		{
			spd_bar.Update_Row(img_Action);
		}

	}
}

