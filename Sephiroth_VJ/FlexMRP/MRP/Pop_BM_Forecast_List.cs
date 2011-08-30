using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FarPoint.Win.Spread.Model;

namespace FlexMRP.MRP
{
	public class Pop_BM_Forecast_List : COM.PCHWinForm.Pop_Medium
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Panel pnl_main;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ContextMenu ctx_grid;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_allDeselect;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.TextBox txt_styleCode;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label btn_calculation;
		private System.Windows.Forms.Label lbl_cancel;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private Pop_BM_Shipping_Wait _pop;
		private string _pkg = null;

		#endregion

		#region 생성자 / 소멸자

		public Pop_BM_Forecast_List()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		} 


		

		private string _Factory = "";
		private string _ShipType = "";
		private string _MRPShipNo = "";

		public Pop_BM_Forecast_List(string arg_factory, string arg_ship_type, string arg_mrp_ship_no)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_Factory = arg_factory;
			_ShipType = arg_ship_type;
			_MRPShipNo = arg_mrp_ship_no;


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_BM_Forecast_List));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btn_calculation = new System.Windows.Forms.Label();
			this.lbl_cancel = new System.Windows.Forms.Label();
			this.pnl_main = new System.Windows.Forms.Panel();
			this.spd_main = new COM.SSP();
			this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_styleCode = new System.Windows.Forms.TextBox();
			this.cmb_style = new C1.Win.C1List.C1Combo();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_style = new System.Windows.Forms.Label();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.btn_search = new System.Windows.Forms.Label();
			this.ctx_grid = new System.Windows.Forms.ContextMenu();
			this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
			this.mnu_allDeselect = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.pnl_main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
			this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
			this.c1Sizer1.BorderWidth = 0;
			this.c1Sizer1.Controls.Add(this.panel3);
			this.c1Sizer1.Controls.Add(this.pnl_main);
			this.c1Sizer1.Controls.Add(this.groupBox1);
			this.c1Sizer1.GridDefinition = "10.7476635514019:False:True;78.7383177570093:False:False;6.77570093457944:False:T" +
				"rue;0.934579439252336:False:True;\t0.576368876080692:False:True;97.6945244956772:" +
				"False:False;0.576368876080692:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
			this.c1Sizer1.TabIndex = 27;
			this.c1Sizer1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btn_calculation);
			this.panel3.Controls.Add(this.lbl_cancel);
			this.panel3.Location = new System.Drawing.Point(8, 391);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(678, 29);
			this.panel3.TabIndex = 168;
			// 
			// btn_calculation
			// 
			this.btn_calculation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_calculation.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_calculation.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_calculation.ImageIndex = 0;
			this.btn_calculation.ImageList = this.img_Button;
			this.btn_calculation.Location = new System.Drawing.Point(536, 3);
			this.btn_calculation.Name = "btn_calculation";
			this.btn_calculation.Size = new System.Drawing.Size(71, 23);
			this.btn_calculation.TabIndex = 353;
			this.btn_calculation.Text = "Apply";
			this.btn_calculation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_calculation.Click += new System.EventHandler(this.btn_calculation_Click);
			this.btn_calculation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Basic_MouseUp);
			this.btn_calculation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Basic_MouseDown);
			// 
			// lbl_cancel
			// 
			this.lbl_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_cancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_cancel.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_cancel.ImageIndex = 0;
			this.lbl_cancel.ImageList = this.img_Button;
			this.lbl_cancel.Location = new System.Drawing.Point(608, 3);
			this.lbl_cancel.Name = "lbl_cancel";
			this.lbl_cancel.Size = new System.Drawing.Size(71, 23);
			this.lbl_cancel.TabIndex = 353;
			this.lbl_cancel.Text = "Cancel";
			this.lbl_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_cancel.Click += new System.EventHandler(this.lbl_cancel_Click);
			this.lbl_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Basic_MouseUp);
			this.lbl_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Basic_MouseDown);
			// 
			// pnl_main
			// 
			this.pnl_main.Controls.Add(this.spd_main);
			this.pnl_main.Location = new System.Drawing.Point(8, 50);
			this.pnl_main.Name = "pnl_main";
			this.pnl_main.Size = new System.Drawing.Size(678, 337);
			this.pnl_main.TabIndex = 166;
			// 
			// spd_main
			// 
			this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spd_main.Location = new System.Drawing.Point(0, 0);
			this.spd_main.Name = "spd_main";
			this.spd_main.Sheets.Add(this.spd_main_Sheet1);
			this.spd_main.Size = new System.Drawing.Size(678, 337);
			this.spd_main.TabIndex = 0;
			this.spd_main.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_ButtonClicked);
			this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
			// 
			// spd_main_Sheet1
			// 
			this.spd_main_Sheet1.SheetName = "Sheet1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_styleCode);
			this.groupBox1.Controls.Add(this.cmb_style);
			this.groupBox1.Controls.Add(this.cmb_factory);
			this.groupBox1.Controls.Add(this.lbl_style);
			this.groupBox1.Controls.Add(this.lbl_factory);
			this.groupBox1.Controls.Add(this.btn_search);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(678, 46);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			// 
			// txt_styleCode
			// 
			this.txt_styleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_styleCode.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_styleCode.Location = new System.Drawing.Point(431, 16);
			this.txt_styleCode.MaxLength = 10;
			this.txt_styleCode.Name = "txt_styleCode";
			this.txt_styleCode.Size = new System.Drawing.Size(79, 21);
			this.txt_styleCode.TabIndex = 368;
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
			this.cmb_style.Location = new System.Drawing.Point(511, 16);
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
				"aultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_style.Size = new System.Drawing.Size(120, 21);
			this.cmb_style.TabIndex = 369;
			this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_style_TextChanged);
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
				"aultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(200, 21);
			this.cmb_factory.TabIndex = 1;
			// 
			// lbl_style
			// 
			this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_style.ImageIndex = 0;
			this.lbl_style.ImageList = this.img_Label;
			this.lbl_style.Location = new System.Drawing.Point(330, 16);
			this.lbl_style.Name = "lbl_style";
			this.lbl_style.Size = new System.Drawing.Size(100, 21);
			this.lbl_style.TabIndex = 183;
			this.lbl_style.Text = "Style";
			this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 16);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 180;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_search
			// 
			this.btn_search.ImageIndex = 27;
			this.btn_search.ImageList = this.img_SmallButton;
			this.btn_search.Location = new System.Drawing.Point(631, 16);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(24, 21);
			this.btn_search.TabIndex = 184;
			this.btn_search.Tag = "Search";
			this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			this.btn_search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseUp);
			this.btn_search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseDown);
			// 
			// ctx_grid
			// 
			this.ctx_grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnu_AllSelect,
																					 this.mnu_allDeselect});
			// 
			// mnu_AllSelect
			// 
			this.mnu_AllSelect.Index = 0;
			this.mnu_AllSelect.Text = "All Select";
			// 
			// mnu_allDeselect
			// 
			this.mnu_allDeselect.Index = 1;
			this.mnu_allDeselect.Text = "All Deselect";
			// 
			// Pop_BM_Forecast_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 471);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Pop_BM_Forecast_List";
			this.Load += new System.EventHandler(this.Form_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.pnl_main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
		
			int vRow = spd_main.Sheets[0].ActiveRowIndex; 

			string lot_no = spd_main.Sheets[0].Cells[vRow, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxLOT_NO].Text.ToString();
			string lot_seq = spd_main.Sheets[0].Cells[vRow, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxLOT_SEQ].Text.ToString();

			string now_lot_no = "";
			string now_lot_seq = "";


			for(int i = vRow - 1; i >= 0; i--)
			{
				
				now_lot_no = spd_main.Sheets[0].Cells[i, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxLOT_NO].Text.ToString();
				now_lot_seq = spd_main.Sheets[0].Cells[i, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxLOT_SEQ].Text.ToString();


				if(now_lot_no != lot_no || now_lot_seq != lot_seq) break;

				spd_main.Sheets[0].Cells[i, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxCHECK_FLAG].Value 
					= spd_main.Sheets[0].Cells[vRow, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxCHECK_FLAG].Value;
 
			}


			for(int i = vRow + 1; i < spd_main.Sheets[0].RowCount; i++)
			{
				
				now_lot_no = spd_main.Sheets[0].Cells[i, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxLOT_NO].Text.ToString();
				now_lot_seq = spd_main.Sheets[0].Cells[i, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxLOT_SEQ].Text.ToString();


				if(now_lot_no != lot_no || now_lot_seq != lot_seq) break;

				spd_main.Sheets[0].Cells[i, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxCHECK_FLAG].Value 
					= spd_main.Sheets[0].Cells[vRow, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxCHECK_FLAG].Value;
 
			}





		}


		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
//			if (!e.ColumnHeader && e.Button == MouseButtons.Right)
//				ctx_grid.Show(spd_main, new Point(e.X, e.Y));
		}
		
		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{
//			int vRow = spd_main.Sheets[0].ActiveRowIndex;
//			int vCol = spd_main.Sheets[0].ActiveColumnIndex;
//			
//			if (spd_main.Sheets[0].Cells[vRow, vCol].Value == null || spd_main.Sheets[0].Columns[vCol].CellType == null)
//				return;
//			
//			spd_main.Buffer_CellData = spd_main.Sheets[0].Cells[vRow, vCol].Value.ToString();
//			string vTemp = spd_main.Sheets[0].Columns[vCol].CellType.ToString();
//			if (vTemp == "CheckBoxCellType" || vTemp == "SSPComboBoxCellType")
//			{
//				spd_main.Buffer_CellData = "000";
//				spd_main.Update_Row(img_Action);
//			}		
		}

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

		private void btn_calculation_Click(object sender, System.EventArgs e)
		{
			_pop = new Pop_BM_Shipping_Wait();
			Thread vCalcThread = new Thread(new ThreadStart(this.UsageAutoCalcultion));
			vCalcThread.Start();
            _pop.ShowDialog();
		}

		private void lbl_cancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
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
				//ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs_StyleCode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}

	 
		#region 버튼효과

		private void btn_search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 26;
		}

		private void btn_search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 27;
		}

		private void btn_Basic_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_Basic_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		#endregion

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
			// Form Setting
			lbl_MainTitle.Text = "Forecast List";
			this.Text = "Forecast List";

			// Grid Setting
			spd_main.Set_Spread_Comm("SBP_FORECAST_LIST", "51", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			// Farpoint Spread Header Merge
			Mearge_GridHead();


			// user define variable setting
			_mainSheet = spd_main.Sheets[0];
			 

			// factory
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = _Factory;
			cmb_factory.Enabled = false;
			vDt.Dispose();
 
		}


		/// <summary>
		/// Mearge_GridHead : Farpoint Spread Header Merge
		/// </summary>
		private void Mearge_GridHead()
		{
			
			try
			{

				for (int vCol = 0 ; vCol < spd_main.ActiveSheet.ColumnCount ; vCol++)
				{
					
					if (spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim().Equals(spd_main.ActiveSheet.ColumnHeader.Cells[2, vCol].Text.ToString().Trim()))
					{
						spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
					}
					else
					{
						int vCnt  = 0;
						
						for ( int j = vCol ; j < spd_main.ActiveSheet.ColumnCount ; j++)
						{
							if( vCnt > 0 &&  spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
							{
								spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
								break;
							}
							else if ( spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
							{
								vCnt++;
							}
						}

						vCol = vCol + vCnt-1;
					}
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Mearge_GridHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}


		private void Btn_SearchClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;


				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_style}; 
				System.Windows.Forms.TextBox[] txt_array = {};  
				bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array); 
				if(! essential_check) return;
 


				string factory = cmb_factory.SelectedValue.ToString();
				string style_cd = cmb_style.SelectedValue.ToString().Replace("-", "");


				DataTable vDt = SELECT_SBP_FORECAST_LIST(factory, style_cd, _ShipType, _MRPShipNo);

				if (vDt.Rows.Count > 0)
				{
					spd_main.Display_Grid(vDt);


					// merge
					ClassLib.ComFunction.MergeCell(spd_main, new int[]{ (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxLOT_NO, 
																		    (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxLOT_SEQ,
																			(int)ClassLib.TBSBP_FORECAST_LIST_POP.IxOBS_ID,
																			(int)ClassLib.TBSBP_FORECAST_LIST_POP.IxOBS_TYPE,
																			(int)ClassLib.TBSBP_FORECAST_LIST_POP.IxPO_NO,
																			(int)ClassLib.TBSBP_FORECAST_LIST_POP.IxRGAC });


					
					// forecast 완료된 LOT 표시
					for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
					{
						
						if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxALREADY_USAGE_YN].Text == "N") continue;
 
						spd_main.ActiveSheet.Rows[i].ForeColor = ClassLib.ComVar.ClrImportant;
						spd_main.ActiveSheet.Rows[i].Locked = true;

					}



					// 선택 mrp_ship_no 에 이미 있는 LOT은 적용 하지 못함을 표시
					for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
					{
						
						if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxEXIST_YN].Text == "N") continue;
 
						spd_main.ActiveSheet.Rows[i].ForeColor = ClassLib.ComVar.ClrWarning;
						spd_main.ActiveSheet.Rows[i].Locked = true;

					}








					vDt.Dispose();
				}
				else
				{
					spd_main.ClearAll();
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
 

		private void UsageAutoCalcultion()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (! Update_SPO_LOT_SIZE_FORECAST() )
				{
					throw new Exception("Size Info Save Failed!!");
				}


				if (! RUN_SBM_USAGE(_Factory, _ShipType, _MRPShipNo) )
				{
					throw new Exception("Usage Calculation Failed!!");
				}

				if (MyOraDB.Exe_Modify_Procedure() != null)
				{
					ClassLib.ComFunction.User_Message("Usage Calculation Complete!!", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Usage Calculation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				_pop.Close();
				this.Close();
			}
		}

		#endregion

		#region DB Connect

		/// <summary>
		/// SELECT_SBP_FORECAST_LIST : forecast 대상 리스트 찾기
		/// </summary>
		/// <returns>DataTable</returns>
		private DataTable SELECT_SBP_FORECAST_LIST(string arg_factory, 
			string arg_style_cd, 
			string arg_ship_type, 
			string arg_mrp_ship_no)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_FORECAST.SELECT_SBP_FORECAST_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_style_cd; 
			MyOraDB.Parameter_Values[2] = arg_ship_type;
			MyOraDB.Parameter_Values[3] = arg_mrp_ship_no; 
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// Update_SPO_LOT_SIZE_FORECAST : 선택한 LOT 표시
		/// </summary>
		private bool Update_SPO_LOT_SIZE_FORECAST()
		{
			try
			{

				  
				MyOraDB.ReDim_Parameter(5);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_FORECAST.UPDATE_SPO_LOT_SIZE_FORECAST";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[3] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 

				//04.DATA 정의
				ArrayList vList = new ArrayList();
 
				string before_item = "";
				string now_item = "";

				for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
				{


					if (Convert.ToBoolean(ClassLib.ComFunction.NullCheck(_mainSheet.Cells[vRow, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxCHECK_FLAG].Value, "false")))
					{

						now_item = _mainSheet.Cells[vRow, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxFACTORY].Text
							+ _mainSheet.Cells[vRow, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxLOT_NO].Text
							+ _mainSheet.Cells[vRow, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxLOT_SEQ].Text;
						

						if(before_item != now_item)
						{

							vList.Add(_mainSheet.Cells[vRow, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxFACTORY].Text);
							vList.Add(_mainSheet.Cells[vRow, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxLOT_NO].Text);
							vList.Add(_mainSheet.Cells[vRow, (int)ClassLib.TBSBP_FORECAST_LIST_POP.IxLOT_SEQ].Text);
							vList.Add("Y");
							vList.Add(COM.ComVar.This_User); 

						}

						before_item = now_item;

					}


				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Size Data Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
		}

		/// <summary>
		/// PKG_SBM_MRP_REQUEST : 소요량 계산
		/// </summary>
		private bool RUN_SBM_USAGE(string arg_factory, string arg_ship_type, string arg_mrp_ship_no)
		{
			try
			{
				MyOraDB.ReDim_Parameter(4);

 
				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SBP_FORECAST.RUN_SBM_USAGE"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";
				
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_ship_type;
				MyOraDB.Parameter_Values[2] = arg_mrp_ship_no;
				MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(false);
				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Usage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
		}


		#endregion

		

	}
}

