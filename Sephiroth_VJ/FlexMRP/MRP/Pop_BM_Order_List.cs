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
	public class Pop_BM_Order_List : COM.PCHWinForm.Pop_Medium
	{
		#region �����̳ʿ��� ������ ����

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Panel pnl_main;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lbl_obsType;
		private C1.Win.C1List.C1Combo cmb_obsType;
		private System.Windows.Forms.ContextMenu ctx_grid;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_allDeselect;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_style;
		private C1.Win.C1List.C1Combo cmb_season;
		private System.Windows.Forms.Label lbl_season;
		private System.Windows.Forms.TextBox txt_styleCode;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label btn_calculation;
		private System.Windows.Forms.Label lbl_cancel;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region ����� ���� ����

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private Pop_BM_Shipping_Wait _pop;
		private string _pkg = null;

		#endregion

		#region ������ / �Ҹ���

		public Pop_BM_Order_List()
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.
		}

		public Pop_BM_Order_List(string arg_pkg)
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			_pkg = arg_pkg;

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

		#region �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_BM_Order_List));
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
			this.cmb_obsType = new C1.Win.C1List.C1Combo();
			this.lbl_style = new System.Windows.Forms.Label();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.btn_search = new System.Windows.Forms.Label();
			this.lbl_obsType = new System.Windows.Forms.Label();
			this.cmb_season = new C1.Win.C1List.C1Combo();
			this.lbl_season = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_season)).BeginInit();
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
			this.c1Sizer1.GridDefinition = "15.8878504672897:False:True;73.5981308411215:False:False;6.77570093457944:False:T" +
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
			this.btn_calculation.Font = new System.Drawing.Font("����", 9F);
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
			this.lbl_cancel.Font = new System.Drawing.Font("����", 9F);
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
			this.pnl_main.Location = new System.Drawing.Point(8, 72);
			this.pnl_main.Name = "pnl_main";
			this.pnl_main.Size = new System.Drawing.Size(678, 315);
			this.pnl_main.TabIndex = 166;
			// 
			// spd_main
			// 
			this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spd_main.Location = new System.Drawing.Point(0, 0);
			this.spd_main.Name = "spd_main";
			this.spd_main.Sheets.Add(this.spd_main_Sheet1);
			this.spd_main.Size = new System.Drawing.Size(678, 315);
			this.spd_main.TabIndex = 0;
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
			this.groupBox1.Controls.Add(this.cmb_obsType);
			this.groupBox1.Controls.Add(this.lbl_style);
			this.groupBox1.Controls.Add(this.lbl_factory);
			this.groupBox1.Controls.Add(this.btn_search);
			this.groupBox1.Controls.Add(this.lbl_obsType);
			this.groupBox1.Controls.Add(this.cmb_season);
			this.groupBox1.Controls.Add(this.lbl_season);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(678, 68);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			// 
			// txt_styleCode
			// 
			this.txt_styleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_styleCode.Font = new System.Drawing.Font("����", 9F);
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
			this.cmb_style.EditorFont = new System.Drawing.Font("����", 9F);
			this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_style.EditorHeight = 17;
			this.cmb_style.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_style.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:����, 9pt;B" +
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
			this.cmb_factory.EditorFont = new System.Drawing.Font("����", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:����, 9pt;B" +
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
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(200, 21);
			this.cmb_factory.TabIndex = 1;
			// 
			// cmb_obsType
			// 
			this.cmb_obsType.AddItemCols = 0;
			this.cmb_obsType.AddItemSeparator = ';';
			this.cmb_obsType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_obsType.AutoSize = false;
			this.cmb_obsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_obsType.Caption = "";
			this.cmb_obsType.CaptionHeight = 17;
			this.cmb_obsType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_obsType.ColumnCaptionHeight = 18;
			this.cmb_obsType.ColumnFooterHeight = 18;
			this.cmb_obsType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_obsType.ContentHeight = 17;
			this.cmb_obsType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_obsType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_obsType.EditorFont = new System.Drawing.Font("����", 9F);
			this.cmb_obsType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_obsType.EditorHeight = 17;
			this.cmb_obsType.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_obsType.GapHeight = 2;
			this.cmb_obsType.ItemHeight = 15;
			this.cmb_obsType.Location = new System.Drawing.Point(431, 38);
			this.cmb_obsType.MatchEntryTimeout = ((long)(2000));
			this.cmb_obsType.MaxDropDownItems = ((short)(5));
			this.cmb_obsType.MaxLength = 32767;
			this.cmb_obsType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_obsType.Name = "cmb_obsType";
			this.cmb_obsType.PartialRightColumn = false;
			this.cmb_obsType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:����, 9pt;B" +
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
			this.cmb_obsType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_obsType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_obsType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_obsType.Size = new System.Drawing.Size(200, 21);
			this.cmb_obsType.TabIndex = 185;
			// 
			// lbl_style
			// 
			this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_style.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.lbl_factory.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			// lbl_obsType
			// 
			this.lbl_obsType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_obsType.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_obsType.ImageIndex = 0;
			this.lbl_obsType.ImageList = this.img_Label;
			this.lbl_obsType.Location = new System.Drawing.Point(330, 38);
			this.lbl_obsType.Name = "lbl_obsType";
			this.lbl_obsType.Size = new System.Drawing.Size(100, 21);
			this.lbl_obsType.TabIndex = 186;
			this.lbl_obsType.Text = "Order Type";
			this.lbl_obsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_season.EditorFont = new System.Drawing.Font("����", 9F);
			this.cmb_season.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_season.EditorHeight = 17;
			this.cmb_season.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_season.GapHeight = 2;
			this.cmb_season.ItemHeight = 15;
			this.cmb_season.Location = new System.Drawing.Point(109, 38);
			this.cmb_season.MatchEntryTimeout = ((long)(2000));
			this.cmb_season.MaxDropDownItems = ((short)(5));
			this.cmb_season.MaxLength = 32767;
			this.cmb_season.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_season.Name = "cmb_season";
			this.cmb_season.PartialRightColumn = false;
			this.cmb_season.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:����, 9pt;B" +
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
			this.cmb_season.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_season.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_season.Size = new System.Drawing.Size(200, 21);
			this.cmb_season.TabIndex = 28;
			// 
			// lbl_season
			// 
			this.lbl_season.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_season.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_season.ImageIndex = 0;
			this.lbl_season.ImageList = this.img_Label;
			this.lbl_season.Location = new System.Drawing.Point(8, 38);
			this.lbl_season.Name = "lbl_season";
			this.lbl_season.Size = new System.Drawing.Size(100, 21);
			this.lbl_season.TabIndex = 177;
			this.lbl_season.Text = "Season";
			this.lbl_season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// Pop_BM_Order_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 471);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Pop_BM_Order_List";
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
			((System.ComponentModel.ISupportInitialize)(this.cmb_obsType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_season)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region �׸��� �̺�Ʈ ó��

		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader && e.Button == MouseButtons.Right)
				ctx_grid.Show(spd_main, new Point(e.X, e.Y));
		}
		
		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{
			int vRow = spd_main.Sheets[0].ActiveRowIndex;
			int vCol = spd_main.Sheets[0].ActiveColumnIndex;
			
			if (spd_main.Sheets[0].Cells[vRow, vCol].Value == null || spd_main.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			spd_main.Buffer_CellData = spd_main.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = spd_main.Sheets[0].Columns[vCol].CellType.ToString();
			if (vTemp == "CheckBoxCellType" || vTemp == "SSPComboBoxCellType")
			{
				spd_main.Buffer_CellData = "000";
				spd_main.Update_Row(img_Action);
			}		
		}

		#endregion

		#region ��Ʈ�� �̺�Ʈ ó��

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

		#region �Է��̵�

		#endregion

		#region ��ưȿ��

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

		#region �̺�Ʈ ó�� �޼���
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
			// Form Setting
			lbl_MainTitle.Text = "Order List";
			this.Text = "Order List";

			// Grid Setting
			spd_main.Set_Spread_Comm("SBP_ORDER_LIST_POP", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			// user define variable setting
			_mainSheet = spd_main.Sheets[0];
			_mainSheet.Columns[0].CellType = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
			_mainSheet.Columns[0].Locked = false;

			// factory
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = COM.ComVar.This_Factory;
			vDt.Dispose();

			// season
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SEM15");
			COM.ComCtl.Set_ComboList(vDt, cmb_season, 1, 2, true, 80, 140);
			cmb_season.SelectedIndex = 0;
			vDt.Dispose();

			// order type
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SEM10");
			COM.ComCtl.Set_ComboList(vDt, cmb_obsType, 1, 2, false, 80, 140);
			cmb_obsType.SelectedValue = "SS";
			vDt.Dispose();
		}

		private void Btn_SearchClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = this.SELECT_SBP_ORDER_LIST_POP();

				if (vDt.Rows.Count > 0)
				{
					spd_main.Display_Grid(vDt);
					Grid_SetColor();
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

		private void Grid_SetColor()
		{
			// �׸��� ������ ����
		}

		private void UsageAutoCalcultion()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (!this.SAVE_SBT_TEMP_SIZE())
				{
					throw new Exception("Size Info Save Failed!!");
				}

				if (!this.RUN_SBM_USAGE())
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
			}
		}

		#endregion

		#region DB Connect

		/// <summary>
		/// PKG_SBP_ORDER : Order ���� ��������
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_ORDER_LIST_POP()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE��
			MyOraDB.Process_Name = "PKG_SBP_ORDER.SELECT_SBP_ORDER_LIST_POP";

			//02.ARGURMENT ��
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SEASON";
			MyOraDB.Parameter_Name[3] = "ARG_ORDER_TYPE";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE ����
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA ����
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_style, "");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_season, "");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_obsType, "");
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBT_TEMP_SIZE : ������ ���� �ӽ� ���̺��� ����
		/// </summary>
		public bool SAVE_SBT_TEMP_SIZE()
		{
			try
			{

				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE��
				MyOraDB.Process_Name = "PKG_SBT_TEMP_SIZE.SAVE_SBT_TEMP_SIZE";

				//02.ARGURMENT ��
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[2] = "ARG_CS_QTY";
				MyOraDB.Parameter_Name[3] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[4] = "ARG_ACTION_USER";
				MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";

				//03.DATA TYPE ����
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

				//04.DATA ����
				ArrayList vList = new ArrayList();

				vList.Add(ClassLib.ComVar.Delete);
				vList.Add("");
				vList.Add("");
				vList.Add(COM.ComFunction.Empty_Combo(cmb_factory, ""));
				vList.Add(COM.ComVar.This_User);
				vList.Add("");

				for (int vRow = 0 ; vRow < _mainSheet.RowCount ; vRow++)
				{
					if (Convert.ToBoolean(ClassLib.ComFunction.NullCheck(_mainSheet.Cells[vRow, 0].Value, "false")))
					{
						vList.Add(ClassLib.ComVar.Update);
						vList.Add(_mainSheet.Cells[vRow, (int)ClassLib.TBSBP_ORDER_LIST_POP.IxCS_SIZE].Value.ToString());
						vList.Add(_mainSheet.Cells[vRow, (int)ClassLib.TBSBP_ORDER_LIST_POP.IxORDER_QTY].Value.ToString());
						vList.Add(_mainSheet.Cells[vRow, (int)ClassLib.TBSBP_ORDER_LIST_POP.IxFACTORY].Value.ToString());
						vList.Add(COM.ComVar.This_User);
						vList.Add(_mainSheet.Cells[vRow, (int)ClassLib.TBSBP_ORDER_LIST_POP.IxSTYLE_CD].Value.ToString().Replace("-", ""));
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
		/// PKG_SBM_MRP_REQUEST : �ҿ䷮ ���
		/// </summary>
		public bool RUN_SBM_USAGE()
		{
			try
			{
				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE��
				if (_pkg == null)
					MyOraDB.Process_Name = "PKG_SBM_MRP_REQUEST.RUN_SBM_USAGE";
				else
					MyOraDB.Process_Name = _pkg;

				//02.ARGURMENT ��
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";
				
				//03.DATA TYPE ����
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

				//04.DATA ����
				MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = DateTime.Now.ToString("yyyyMMdd");
				MyOraDB.Parameter_Values[2] = cmb_obsType.SelectedValue.ToString();
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
