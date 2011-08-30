using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;

namespace FlexMRP.MRP
{
	struct LeadTime
	{
		public int		ship_time;
        public string	prod_start;
		public string	prod_end;
		public string	arrive;
		public string	arrive_days;
		public string	shipping;
		public string	ship_days;
		public string	remarks;
		public int		status;

		public bool validate
		{
			get
			{
				if (status == 1)
				{
					if (ship_time <= 0 || prod_start == null || prod_end == null || arrive == null || shipping == null || ship_days == null)
						return false;
					else
						return true;
				}
				else
				{
						return true;
				}
			}
		}
	}

	public class Form_BM_Shipping_LeadTime : COM.PCHWinForm.Pop_Medium
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_shipTime;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_shipType;
		private System.Windows.Forms.Label btn_search;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		private System.Windows.Forms.ContextMenu ctx_prod;
		private System.Windows.Forms.MenuItem mnu_createProd;
		private System.Windows.Forms.MenuItem mnu_cancelProd;
		private System.Windows.Forms.ContextMenu ctx_arrive;
		private System.Windows.Forms.ContextMenu ctx_shipping;
		private COM.OraDB MyOraDB = new COM.OraDB();
		private C1.Win.C1List.C1Combo cmb_shipType;
		private SheetView _mainSheet = null;
		private EventHandler mnu_etc = null;
		private EventHandler mnu_arrivedays = null;
		private EventHandler mnu_shipdays = null;

		private const int _maxCount = 6;
        //private ArrayList _leadTimeList = new ArrayList(_maxCount);
		LeadTime[] _leadTimeList = new LeadTime[6];

		//private int _prodCnt = 1;
		private int _curProd = 1;
		private System.Windows.Forms.Label btn_save;
		private System.Windows.Forms.Label btn_new;
		private C1.Win.C1List.C1Combo cmb_shipTime;

		private Color[] _colorList = new Color[]{
													Color.FromArgb(240, 247, 255),  // 하늘색
													Color.FromArgb(252, 240, 255),  // 분홍색
													Color.FromArgb(250, 251, 230),  // 노란색
													Color.FromArgb(240, 255, 240),  // 녹색
													Color.FromArgb(240, 235, 255),  // 보라색
													Color.FromArgb(247, 247, 244)   // 회색
												};

		#endregion

		#region 생성자 / 소멸자

		public Form_BM_Shipping_LeadTime()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BM_Shipping_LeadTime));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.spd_main = new COM.SSP();
			this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_new = new System.Windows.Forms.Label();
			this.btn_save = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.cmb_shipType = new C1.Win.C1List.C1Combo();
			this.cmb_shipTime = new C1.Win.C1List.C1Combo();
			this.lbl_shipTime = new System.Windows.Forms.Label();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.lbl_shipType = new System.Windows.Forms.Label();
			this.btn_search = new System.Windows.Forms.Label();
			this.ctx_prod = new System.Windows.Forms.ContextMenu();
			this.mnu_createProd = new System.Windows.Forms.MenuItem();
			this.mnu_cancelProd = new System.Windows.Forms.MenuItem();
			this.ctx_arrive = new System.Windows.Forms.ContextMenu();
			this.ctx_shipping = new System.Windows.Forms.ContextMenu();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_shipTime)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
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
			this.c1Sizer1.Controls.Add(this.spd_main);
			this.c1Sizer1.Controls.Add(this.groupBox1);
			this.c1Sizer1.GridDefinition = "16.1214953271028:False:False;79.2056074766355:False:False;0.934579439252336:False" +
				":True;\t0.576368876080692:False:True;96.5417867435159:False:False;0.5763688760806" +
				"92:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
			this.c1Sizer1.TabIndex = 26;
			this.c1Sizer1.TabStop = false;
			// 
			// spd_main
			// 
			this.spd_main.Location = new System.Drawing.Point(12, 77);
			this.spd_main.Name = "spd_main";
			this.spd_main.Sheets.Add(this.spd_main_Sheet1);
			this.spd_main.Size = new System.Drawing.Size(670, 339);
			this.spd_main.TabIndex = 30;
			this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
			// 
			// spd_main_Sheet1
			// 
			this.spd_main_Sheet1.SheetName = "Sheet1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_new);
			this.groupBox1.Controls.Add(this.btn_save);
			this.groupBox1.Controls.Add(this.cmb_factory);
			this.groupBox1.Controls.Add(this.cmb_shipType);
			this.groupBox1.Controls.Add(this.cmb_shipTime);
			this.groupBox1.Controls.Add(this.lbl_shipTime);
			this.groupBox1.Controls.Add(this.lbl_factory);
			this.groupBox1.Controls.Add(this.lbl_shipType);
			this.groupBox1.Controls.Add(this.btn_search);
			this.groupBox1.Location = new System.Drawing.Point(12, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(670, 69);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			// 
			// btn_new
			// 
			this.btn_new.ImageIndex = 15;
			this.btn_new.ImageList = this.img_SmallButton;
			this.btn_new.Location = new System.Drawing.Point(610, 38);
			this.btn_new.Name = "btn_new";
			this.btn_new.Size = new System.Drawing.Size(21, 21);
			this.btn_new.TabIndex = 186;
			this.btn_new.Tag = "Search";
			this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
			this.btn_new.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_new_MouseUp);
			this.btn_new.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_new_MouseDown);
			// 
			// btn_save
			// 
			this.btn_save.ImageIndex = 25;
			this.btn_save.ImageList = this.img_SmallButton;
			this.btn_save.Location = new System.Drawing.Point(632, 38);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(21, 21);
			this.btn_save.TabIndex = 185;
			this.btn_save.Tag = "Search";
			this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			this.btn_save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_save_MouseUp);
			this.btn_save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_save_MouseDown);
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
			this.cmb_factory.Location = new System.Drawing.Point(109, 16);
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
			this.cmb_factory.Size = new System.Drawing.Size(200, 21);
			this.cmb_factory.TabIndex = 1;
			this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
			// 
			// cmb_shipType
			// 
			this.cmb_shipType.AddItemCols = 0;
			this.cmb_shipType.AddItemSeparator = ';';
			this.cmb_shipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_shipType.AutoSize = false;
			this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_shipType.Caption = "";
			this.cmb_shipType.CaptionHeight = 17;
			this.cmb_shipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_shipType.ColumnCaptionHeight = 18;
			this.cmb_shipType.ColumnFooterHeight = 18;
			this.cmb_shipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_shipType.ContentHeight = 17;
			this.cmb_shipType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_shipType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_shipType.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_shipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_shipType.EditorHeight = 17;
			this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_shipType.GapHeight = 2;
			this.cmb_shipType.ItemHeight = 15;
			this.cmb_shipType.Location = new System.Drawing.Point(109, 38);
			this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
			this.cmb_shipType.MaxDropDownItems = ((short)(5));
			this.cmb_shipType.MaxLength = 32767;
			this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_shipType.Name = "cmb_shipType";
			this.cmb_shipType.PartialRightColumn = false;
			this.cmb_shipType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_shipType.Size = new System.Drawing.Size(200, 21);
			this.cmb_shipType.TabIndex = 51;
			this.cmb_shipType.SelectedValueChanged += new System.EventHandler(this.cmb_shipType_SelectedValueChanged);
			// 
			// cmb_shipTime
			// 
			this.cmb_shipTime.AddItemCols = 0;
			this.cmb_shipTime.AddItemSeparator = ';';
			this.cmb_shipTime.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_shipTime.AutoSize = false;
			this.cmb_shipTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_shipTime.Caption = "";
			this.cmb_shipTime.CaptionHeight = 17;
			this.cmb_shipTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_shipTime.ColumnCaptionHeight = 18;
			this.cmb_shipTime.ColumnFooterHeight = 18;
			this.cmb_shipTime.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_shipTime.ContentHeight = 17;
			this.cmb_shipTime.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_shipTime.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_shipTime.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_shipTime.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_shipTime.EditorHeight = 17;
			this.cmb_shipTime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_shipTime.GapHeight = 2;
			this.cmb_shipTime.ItemHeight = 15;
			this.cmb_shipTime.Location = new System.Drawing.Point(431, 16);
			this.cmb_shipTime.MatchEntryTimeout = ((long)(2000));
			this.cmb_shipTime.MaxDropDownItems = ((short)(5));
			this.cmb_shipTime.MaxLength = 32767;
			this.cmb_shipTime.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_shipTime.Name = "cmb_shipTime";
			this.cmb_shipTime.PartialRightColumn = false;
			this.cmb_shipTime.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_shipTime.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_shipTime.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_shipTime.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_shipTime.Size = new System.Drawing.Size(200, 21);
			this.cmb_shipTime.TabIndex = 3;
			// 
			// lbl_shipTime
			// 
			this.lbl_shipTime.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_shipTime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_shipTime.ImageIndex = 0;
			this.lbl_shipTime.ImageList = this.img_Label;
			this.lbl_shipTime.Location = new System.Drawing.Point(330, 16);
			this.lbl_shipTime.Name = "lbl_shipTime";
			this.lbl_shipTime.Size = new System.Drawing.Size(100, 21);
			this.lbl_shipTime.TabIndex = 183;
			this.lbl_shipTime.Text = "Ship Time";
			this.lbl_shipTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 1;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 16);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 180;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_shipType
			// 
			this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_shipType.ImageIndex = 1;
			this.lbl_shipType.ImageList = this.img_Label;
			this.lbl_shipType.Location = new System.Drawing.Point(8, 38);
			this.lbl_shipType.Name = "lbl_shipType";
			this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
			this.lbl_shipType.TabIndex = 52;
			this.lbl_shipType.Text = "Ship Type";
			this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_search
			// 
			this.btn_search.ImageIndex = 27;
			this.btn_search.ImageList = this.img_SmallButton;
			this.btn_search.Location = new System.Drawing.Point(632, 16);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(21, 21);
			this.btn_search.TabIndex = 184;
			this.btn_search.Tag = "Search";
			this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			this.btn_search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseUp);
			this.btn_search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseDown);
			// 
			// ctx_prod
			// 
			this.ctx_prod.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnu_createProd,
																					 this.mnu_cancelProd});
			// 
			// mnu_createProd
			// 
			this.mnu_createProd.Index = 0;
			this.mnu_createProd.Text = "Create Production";
			this.mnu_createProd.Click += new System.EventHandler(this.mnu_createProd_Click);
			// 
			// mnu_cancelProd
			// 
			this.mnu_cancelProd.Index = 1;
			this.mnu_cancelProd.Text = "Cancel Production";
			this.mnu_cancelProd.Click += new System.EventHandler(this.mnu_cancelProd_Click);
			// 
			// Form_BM_Shipping_LeadTime
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_BM_Shipping_LeadTime";
			this.Load += new System.EventHandler(this.Form_Load);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_shipTime)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			this.Btn_SearchProcess();
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (ValidateCheck())
					this.Btn_SaveProcess();
			}
		}

		private void btn_new_Click(object sender, System.EventArgs e)
		{
			_mainSheet.Cells[0, 1, 2, 1].BackColor = Color.WhiteSmoke;
			_mainSheet.Cells[0, 2, 2, _mainSheet.ColumnCount - 1].BackColor = Color.White;
			_mainSheet.Cells[0, 2, 2, _mainSheet.ColumnCount - 1].Text = "";
			_leadTimeList = new LeadTime[6];

			for ( int i = 2 ; i < _mainSheet.ColumnCount ; i++)
			{
				_mainSheet.AddSpanCell(0, i, 1, 1);
			}
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_ShipTimeSetting();
		}

		private void cmb_shipType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_ShipTimeSetting();
		}

		#region 컨텍스트 메뉴 이벤트

		private void mnu_createProd_Click(object sender, System.EventArgs e)
		{
			GetProdNum();

			CellRange vSel	= _mainSheet.GetSelection(0);
			for (int i = vSel.Column ; i < vSel.Column + vSel.ColumnCount ; i++)
			{
				if (_mainSheet.Cells[0, i].BackColor != Color.White)
				{
					ClassLib.ComFunction.User_Message("The selected block has already made production", "Create Production", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}

			MnuCreateProdProcess(true);
		}

		private void MnuCreateProdProcess(bool arg_new)
		{
			CellRange vSel	= _mainSheet.GetSelection(0);
			int vProdStart, vProdEnd;

			if (vSel.Row == 0 && vSel.RowCount == 1)
			{
				vProdStart		= vSel.Column;
				vProdEnd		= vProdStart + vSel.ColumnCount - 1;
				_mainSheet.Cells[0, vProdStart].Text = _curProd + "st production";
				_mainSheet.AddSpanCell(0, vProdStart, 1, (vProdEnd - vProdStart) + 1);
				_mainSheet.Cells[0, vProdStart, 0, vProdEnd].BackColor = _colorList[_curProd - 1];

				if (arg_new)
				{
					//LeadTime vTemp = new LeadTime();
					_leadTimeList[_curProd - 1].ship_time = _curProd;
					_leadTimeList[_curProd - 1].prod_start = _mainSheet.Columns[vProdStart].Label;
					_leadTimeList[_curProd - 1].prod_end = _mainSheet.Columns[vProdEnd].Label;
					_leadTimeList[_curProd - 1].status = 1;

					/*
					vTemp.ship_time = _curProd;
					vTemp.prod_start = _mainSheet.Columns[vProdStart].Label;
					vTemp.prod_end = _mainSheet.Columns[vProdEnd].Label;
					vTemp.status = 1;					
					_leadTimeList[_curProd - 1] = vTemp;
					*/
				}
			}
		}

		private void mnu_cancelProd_Click(object sender, System.EventArgs e)
		{
			int vRow = _mainSheet.ActiveRow.Index;
			int vCol = _mainSheet.ActiveColumn.Index;

			if (vRow == 0 && !_mainSheet.Cells[vRow, vCol].Text.Equals(""))
			{
				int vProdNum = Convert.ToInt32(_mainSheet.Cells[vRow, vCol].Text.Substring(0, 1));
				CellRange vCells = _mainSheet.GetSpanCell(vRow, vCol);

				for ( int i = vCol ; i < vCells.ColumnCount + vCol ; i++)
				{
					_mainSheet.AddSpanCell(vRow, i, 1, 1);
					_mainSheet.Cells[vRow, i].BackColor = Color.White;
					_mainSheet.Cells[vRow, i].Text = "";
				}

				if (_leadTimeList[vProdNum - 1].arrive != null && !_leadTimeList[vProdNum - 1].arrive.Equals(""))
				{
					int vTemp = Convert.ToInt32(_leadTimeList[vProdNum - 1].arrive);
					this.ClearCell(1, vTemp);
				}

				if (_leadTimeList[vProdNum - 1].shipping != null && !_leadTimeList[vProdNum - 1].shipping.Equals(""))
				{
					int vTemp = Convert.ToInt32(_leadTimeList[vProdNum - 1].shipping);
					this.ClearCell(2, vTemp);
				}

				this.ClearStruct(vProdNum - 1);
			}
		}

		private void mnu_Etc_Click(object sender, System.EventArgs e)
		{
			string vText = ((MenuItem)sender).Text;
			Mnu_EtcProcess(vText, true);
		}

		private void Mnu_EtcProcess(string arg_text, bool arg_new)
		{
			int vRow = _mainSheet.ActiveRow.Index;
			int vCol = _mainSheet.ActiveColumn.Index;
			int vProdNum = Convert.ToInt32(arg_text.Substring(0, 1));

			for (int i = 2 ; i < _mainSheet.ColumnCount ; i++)
			{
				if (_mainSheet.Cells[vRow, i].Text.StartsWith(arg_text))
				{
					_mainSheet.Cells[vRow, i].Text = "";
					_mainSheet.Cells[vRow, i].BackColor = Color.White;
				}
			}

			_mainSheet.Cells[vRow, vCol].BackColor = _colorList[vProdNum - 1];
			_mainSheet.Cells[vRow, vCol].Text = arg_text;

			if (vRow == 1 && _leadTimeList[vProdNum - 1].arrive_days != null)
				_mainSheet.Cells[vRow, vCol].Text += "\r\nLeadTime : " + _leadTimeList[vProdNum - 1].arrive_days;

			if (vRow == 2 && _leadTimeList[vProdNum - 1].ship_days != null)
				_mainSheet.Cells[vRow, vCol].Text += "\r\nLeadTime : " + _leadTimeList[vProdNum - 1].ship_days;

			if (arg_new)
			{
				if (vRow == 1)
					_leadTimeList[vProdNum - 1].arrive = _mainSheet.Columns[vCol].Label;
				else
				{
					int ship_days = 0;
					if (_leadTimeList[vProdNum - 1].arrive != null)
					{
						ship_days = Convert.ToInt32(_leadTimeList[vProdNum - 1].arrive);
					}

					_leadTimeList[vProdNum - 1].shipping = _mainSheet.Columns[vCol].Label;
				}
			}
		}

		private void mnu_InputShipDays(object sender, System.EventArgs e)
		{
			try
			{
				int vRow = _mainSheet.ActiveRow.Index;
				int vCol = _mainSheet.ActiveColumn.Index;
				int vProdNum = Convert.ToInt32(_mainSheet.Cells[vRow, vCol].Text.Substring(0, 1));
				
				try
				{
					COM.ComVar.Parameter_PopUp = new string[2];
					COM.ComVar.Parameter_PopUp[0] = _leadTimeList[vProdNum - 1].ship_days;
					COM.ComVar.Parameter_PopUp[1] = _leadTimeList[vProdNum - 1].remarks;
				}
				catch
				{
					COM.ComVar.Parameter_PopUp = new string[]{"", ""};
				}
				
				Pop_BM_Shipping_LeadTime vPop = new Pop_BM_Shipping_LeadTime();

				if (vPop.ShowDialog() == DialogResult.OK)
				{
					_leadTimeList[vProdNum - 1].ship_days = COM.ComVar.Parameter_PopUp[0];
					_leadTimeList[vProdNum - 1].remarks = COM.ComVar.Parameter_PopUp[1];
				
					string vShipDays = _mainSheet.Cells[vRow, vCol].Text;

					if (vShipDays.IndexOf("LeadTime") > 0)
						_mainSheet.Cells[vRow, vCol].Text = vShipDays.Substring(0, vShipDays.IndexOf("LeadTime")) + "LeadTime : " +  COM.ComVar.Parameter_PopUp[0];
					else
						_mainSheet.Cells[vRow, vCol].Text = vShipDays + "\r\nLeadTime : " +  COM.ComVar.Parameter_PopUp[0];
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "mnu_InputShipDays", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void mnu_InputArriveDays(object sender, System.EventArgs e)
		{
			try
			{
				int vRow = _mainSheet.ActiveRow.Index;
				int vCol = _mainSheet.ActiveColumn.Index;
				int vProdNum = Convert.ToInt32(_mainSheet.Cells[vRow, vCol].Text.Substring(0, 1));
				
				try
				{
					COM.ComVar.Parameter_PopUp = new string[2];
					COM.ComVar.Parameter_PopUp[0] = _leadTimeList[vProdNum - 1].arrive_days;
					COM.ComVar.Parameter_PopUp[1] = _leadTimeList[vProdNum - 1].remarks;
				}
				catch
				{
					COM.ComVar.Parameter_PopUp = new string[]{"", ""};
				}
				
				Pop_BM_Shipping_LeadTime vPop = new Pop_BM_Shipping_LeadTime();

				if (vPop.ShowDialog() == DialogResult.OK)
				{
					_leadTimeList[vProdNum - 1].arrive_days = COM.ComVar.Parameter_PopUp[0];
					_leadTimeList[vProdNum - 1].remarks = COM.ComVar.Parameter_PopUp[1];
				
					string vArriveDays = _mainSheet.Cells[vRow, vCol].Text;

					if (vArriveDays.IndexOf("LeadTime") > 0)
						_mainSheet.Cells[vRow, vCol].Text = vArriveDays.Substring(0, vArriveDays.IndexOf("LeadTime")) + "LeadTime : " +  COM.ComVar.Parameter_PopUp[0];
					else
						_mainSheet.Cells[vRow, vCol].Text = vArriveDays + "\r\nLeadTime : " +  COM.ComVar.Parameter_PopUp[0];
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "mnu_InputArriveDays", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region 버튼 클릭

		private void btn_search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_search.ImageIndex = 27;
		}

		private void btn_search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_search.ImageIndex = 26;
		}

		private void btn_save_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_save.ImageIndex = 25;
		}

		private void btn_save_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_save.ImageIndex = 24;		
		}

		private void btn_new_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_new.ImageIndex = 15;		
		}

		private void btn_new_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_new.ImageIndex = 14;
		}

		#endregion

		#endregion

		#region 이벤트 처리 메서드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form setting
			lbl_MainTitle.Text = "Shipping LeadTime";
			this.Text = "Shipping LeadTime";

			// grid setting
			spd_main.Set_Spread_Comm("SBM_SHIP_LEADTIME", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			// user define variable setting
			_mainSheet = spd_main.Sheets[0];

			// factory
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = COM.ComVar.This_Factory;
			vDt.Dispose();

			// ship type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM09");
			COM.ComCtl.Set_ComboList(vDt, cmb_shipType, 1, 2, false);
			cmb_shipType.SelectedIndex = 0;
			vDt.Dispose();

			// grid data setting
			_mainSheet.ColumnHeader.Rows[2].Visible = false;

			_mainSheet.Rows.Add(0, 3);
			_mainSheet.Cells[0, 1].Text = "Production";
			_mainSheet.Rows[0].Height = 100;
			_mainSheet.Cells[1, 1].Text = "Arrive";
			_mainSheet.Rows[1].Height = 100;
			_mainSheet.Cells[2, 1].Text = "Shipping";
			_mainSheet.Rows[2].Height = 100;

			_mainSheet.Cells[0, 1, 2, 1].BackColor = Color.WhiteSmoke;
			_mainSheet.Cells[0, 2, 2, _mainSheet.ColumnCount - 1].BackColor = Color.White;
			
			_mainSheet.SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Cell;
			mnu_etc = new EventHandler(mnu_Etc_Click);
			mnu_arrivedays = new EventHandler(this.mnu_InputArriveDays);
			mnu_shipdays = new EventHandler(this.mnu_InputShipDays);
		}

		#endregion

		#region 컨트롤 이벤트 처리

		private void Btn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vShipType = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				string vShipTime = COM.ComFunction.Empty_Combo(cmb_shipTime, "");;

                DataTable vDt = SELECT_SBM_SHIPPING_LEADTIME(vFactory, vShipType, vShipTime);

				/***********
				FACTORY
				SHIP_TYPE,
				SHIP_TIME,
				START_WEEK,
				END_WEEK,
				ARRIVAL_WEEK,
				ARRIVAL_DAYS,
				SHIP_WEEK,
				SHIP_DAYS,
				REMARKS,
				************/
				if (vDt.Rows.Count > 0)
				{
					btn_new_Click(null, null);

					for (int i = 0 ; i < vDt.Rows.Count ; i++)
					{
						_curProd = Convert.ToInt32(vDt.Rows[i].ItemArray[2]);

						_leadTimeList[_curProd - 1].ship_time	= _curProd;
						_leadTimeList[_curProd - 1].prod_start	= vDt.Rows[i].ItemArray[3].ToString();
						_leadTimeList[_curProd - 1].prod_end	= vDt.Rows[i].ItemArray[4].ToString();
						_leadTimeList[_curProd - 1].arrive		= vDt.Rows[i].ItemArray[5].ToString();
						_leadTimeList[_curProd - 1].arrive_days	= vDt.Rows[i].ItemArray[6].ToString();
						_leadTimeList[_curProd - 1].shipping	= vDt.Rows[i].ItemArray[7].ToString();
						_leadTimeList[_curProd - 1].ship_days	= vDt.Rows[i].ItemArray[8].ToString();
						_leadTimeList[_curProd - 1].remarks		= vDt.Rows[i].ItemArray[9].ToString();
						_leadTimeList[_curProd - 1].status		= 1;
						
						// production
						int vStart = Convert.ToInt32(_leadTimeList[_curProd - 1].prod_start);
						int vEnd = Convert.ToInt32(_leadTimeList[_curProd - 1].prod_end);
						_mainSheet.SetActiveCell(0, vStart);
						_mainSheet.AddSelection(0, vStart, 1, vEnd - vStart + 1);
						MnuCreateProdProcess(false);

						// arrive
						int vArrive = Convert.ToInt32(_leadTimeList[_curProd - 1].arrive);
						_mainSheet.SetActiveCell(1, vArrive);
						Mnu_EtcProcess(_curProd + "st arrive", false);

						// shipping
						int vShipping = Convert.ToInt32(_leadTimeList[_curProd - 1].shipping);
						_mainSheet.SetActiveCell(2, vShipping);
						Mnu_EtcProcess(_curProd + "st shipping", false);
					}
				}
				else
				{
					btn_new_Click(null, null);
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

		private void Btn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				this.SAVE_SBM_SHIPPING_LEADTIME();
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

		private void Cmb_ShipTimeSetting()
		{
			try
			{
				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vShipType = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			
				DataTable vDt = this.SELECT_SHIP_TIME_LIST(vFactory, vShipType);
				COM.ComCtl.Set_ComboList(vDt, cmb_shipTime, 0, 0, true, false);
			}
			catch
			{

			}
		}

		#endregion

		#region 그리드 이벤트 처리
		
		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			int vRow = _mainSheet.ActiveRow.Index;
			int vCol = _mainSheet.ActiveColumn.Index;

			if (!e.RowHeader && !e.ColumnHeader && e.Button == MouseButtons.Right && vCol > 1)
			{
				switch (vRow)
				{
					case 0:
						if (!COM.ComFunction.Empty_Combo(cmb_shipTime, "").Trim().Equals(""))
						{
							this.mnu_createProd.Enabled = false;
							this.mnu_cancelProd.Enabled = false;
						}
						else
						{
							this.mnu_createProd.Enabled = true;
							this.mnu_cancelProd.Enabled = true;
						}

						ctx_prod.Show(spd_main, new Point(e.X, e.Y));
						break;
					case 1:
						ctx_arrive.MenuItems.Clear();
						ctx_arrive.MenuItems.AddRange(GetProdList("arrive"));
						if (!_mainSheet.Cells[e.Row, e.Column].Text.Equals(""))
							ctx_arrive.MenuItems.Add("Input arrival days", mnu_arrivedays);
						ctx_arrive.Show(spd_main, new Point(e.X, e.Y));	
						break;
					case 2:
						ctx_shipping.MenuItems.Clear();
						ctx_shipping.MenuItems.AddRange(GetProdList("shipping"));
						if (!_mainSheet.Cells[e.Row, e.Column].Text.Equals(""))
							ctx_shipping.MenuItems.Add("Input ship days", mnu_shipdays);
						ctx_shipping.Show(spd_main, new Point(e.X, e.Y));
						break;
				}
			}
		}

		#endregion

		#region 이벤트 처리시 사용되는 기능 메서드

		private void GetProdNum()
		{
			for (int i = 0 ; i < _maxCount ; i++)
			{
				if (_leadTimeList[i].status == 0)
				{
					_curProd = i + 1;
					break;
				}
			}
		}


		private MenuItem[] GetProdList(string arg_kind)
		{
			int vCount = 0;

			for (int i = 0 ; i < _maxCount ; i++)
			{
				if (_leadTimeList[i].status != 0)
					vCount++;
			}

			MenuItem[] vMenuList = new MenuItem[vCount];
			vCount = 0;

			for (int i = 0 ; i < _maxCount ; i++)
			{
				if (_leadTimeList[i].status != 0)
					vMenuList[vCount++] = new MenuItem(_leadTimeList[i].ship_time + "st " + arg_kind, mnu_etc);
			}

			return vMenuList;
		}

		private void ClearCell(int arg_row, int arg_col)
		{
			_mainSheet.Cells[arg_row, arg_col].Text = "";
			_mainSheet.Cells[arg_row, arg_col].BackColor = Color.White;
		}

		private void ClearStruct(int arg_idx)
		{
			_leadTimeList[arg_idx].prod_start	= null;
			_leadTimeList[arg_idx].prod_end		= null;
			_leadTimeList[arg_idx].arrive		= null;
			_leadTimeList[arg_idx].arrive_days	= null;
			_leadTimeList[arg_idx].shipping		= null;
			_leadTimeList[arg_idx].ship_days	= null;
			_leadTimeList[arg_idx].remarks		= null;
			_leadTimeList[arg_idx].status		= 0;
		}

		#endregion

		#endregion

		#region DBConnect

		/// <summary>
		/// PKG_SBM_SHIPPING_LEADTIME : LEADTIME 정보 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBM_SHIPPING_LEADTIME(string arg_factory, string arg_ship_type, string arg_ship_time)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LEADTIME.SELECT_SBM_SHIPPING_LEADTIME";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_TIME";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_ship_type;
			MyOraDB.Parameter_Values[2] = arg_ship_time;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBM_SHIPPING_LEADTIME : SHIP_TIME 리스트 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SHIP_TIME_LIST(string arg_factory, string arg_ship_type)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LEADTIME.SELECT_SHIPPING_TIME";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_ship_type;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBM_SHIPPING_LEADTIME : LEADTIME 정보 저장
		/// </summary>
		public void SAVE_SBM_SHIPPING_LEADTIME()
		{
			MyOraDB.ReDim_Parameter(12);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LEADTIME.SAVE_SBM_SHIPPING_LEADTIME";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_TIME";
			MyOraDB.Parameter_Name[4] = "ARG_START_WEEK";
			MyOraDB.Parameter_Name[5] = "ARG_END_WEEK";
			MyOraDB.Parameter_Name[6] = "ARG_ARRIVAL_WEEK";
			MyOraDB.Parameter_Name[7] = "ARG_ARRIVAL_DAYS";
			MyOraDB.Parameter_Name[8] = "ARG_SHIP_WEEK";
			MyOraDB.Parameter_Name[9] = "ARG_SHIP_DAYS";
			MyOraDB.Parameter_Name[10] = "ARG_REMARKS";
			MyOraDB.Parameter_Name[11] = "ARG_UPD_USER";

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
			MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;

			//04.DATA 정의
			ArrayList vTemp = new ArrayList();

			for (int i = 0 ; i < _leadTimeList.Length ; i++)
			{
				if (_leadTimeList[i].ship_time != 0)
				{
					vTemp.Add(_leadTimeList[i].status == 0 ? "D" : "I");
					vTemp.Add(COM.ComFunction.Empty_Combo(cmb_factory, ""));
					vTemp.Add(COM.ComFunction.Empty_Combo(cmb_shipType, ""));
					vTemp.Add(_leadTimeList[i].ship_time.ToString());
					vTemp.Add(ClassLib.ComFunction.NullToBlank(_leadTimeList[i].prod_start));
					vTemp.Add(ClassLib.ComFunction.NullToBlank(_leadTimeList[i].prod_end));
					vTemp.Add(ClassLib.ComFunction.NullToBlank(_leadTimeList[i].arrive));
					vTemp.Add(ClassLib.ComFunction.NullToBlank(_leadTimeList[i].arrive_days));
					vTemp.Add(ClassLib.ComFunction.NullToBlank(_leadTimeList[i].shipping));
					vTemp.Add(ClassLib.ComFunction.NullToBlank(_leadTimeList[i].ship_days));
					vTemp.Add(ClassLib.ComFunction.NullToBlank(_leadTimeList[i].remarks));
					vTemp.Add(COM.ComVar.This_User);
				}
			}

			MyOraDB.Parameter_Values = (String[])vTemp.ToArray(System.Type.GetType("System.String"));

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}

		private bool ValidateCheck()
		{
			for (int i = 0 ; i < _leadTimeList.Length ; i++)
			{
				if (!_leadTimeList[i].validate)
				{
					ClassLib.ComFunction.User_Message((i + 1) + "st data empty", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
			}

			return true;
		}

		#endregion


	}
}

