using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data;
using C1.Win.C1FlexGrid;
using System.IO;
using C1.Win.C1Chart;


namespace FlexMold.Management
{
	public class Form_Sys_PGM_Mon : COM.MoldWinForm.Form_Top
	{
		public COM.FSP fgrid_main;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dtpdate_to;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl15;
		private System.Windows.Forms.Label lbl_repairarea;
		private System.Windows.Forms.DateTimePicker cmb_workday;
		private System.Windows.Forms.Label lbl_work_ymd;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cboUser;
		private C1.Win.C1List.C1Combo cbo_PGM;
		private C1.Win.C1List.C1Combo cboPGM;
		private System.ComponentModel.IContainer components = null;

		private COM.OraDB OraDB = new COM.OraDB();
		public COM.FSP fgrid_main1;
		public COM.FSP fgrid_main2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private C1.Win.C1Chart.C1Chart Chart;
		private System.Data.DataTable dt_list;
		private C1.Win.C1Chart.ChartDataSeries series0 = null;
		private C1.Win.C1Chart.C1Chart Chart1;
		private C1.Win.C1Chart.C1Chart Chart3;
		private C1.Win.C1Chart.ChartDataSeries series1 = null;

		public Form_Sys_PGM_Mon()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Sys_PGM_Mon));
			this.fgrid_main = new COM.FSP();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cboPGM = new C1.Win.C1List.C1Combo();
			this.dtpdate_to = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.cboUser = new C1.Win.C1List.C1Combo();
			this.lbl15 = new System.Windows.Forms.Label();
			this.lbl_repairarea = new System.Windows.Forms.Label();
			this.cmb_workday = new System.Windows.Forms.DateTimePicker();
			this.lbl_work_ymd = new System.Windows.Forms.Label();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.cbo_PGM = new C1.Win.C1List.C1Combo();
			this.fgrid_main1 = new COM.FSP();
			this.fgrid_main2 = new COM.FSP();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Chart = new C1.Win.C1Chart.C1Chart();
			this.Chart1 = new C1.Win.C1Chart.C1Chart();
			this.Chart3 = new C1.Win.C1Chart.C1Chart();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cboPGM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cboUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_PGM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart3)).BeginInit();
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
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Location = new System.Drawing.Point(64, 25);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// fgrid_main
			// 
			this.fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main.ColumnInfo = "5,1,0,0,0,95,Columns:0{Width:29;}\t";
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 96);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 2;
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_main.Size = new System.Drawing.Size(488, 168);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	NewRow{TextAlign:LeftCenter;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{Font:Verdana, 9pt, style=Bold;BackColor:128, 255, 128;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 52;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.cboPGM);
			this.panel1.Controls.Add(this.dtpdate_to);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cboUser);
			this.panel1.Controls.Add(this.lbl15);
			this.panel1.Controls.Add(this.lbl_repairarea);
			this.panel1.Controls.Add(this.cmb_workday);
			this.panel1.Controls.Add(this.lbl_work_ymd);
			this.panel1.Controls.Add(this.cbo_factory);
			this.panel1.Controls.Add(this.lbl_factory);
			this.panel1.Location = new System.Drawing.Point(0, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 40);
			this.panel1.TabIndex = 54;
			// 
			// cboPGM
			// 
			this.cboPGM.AddItemCols = 0;
			this.cboPGM.AddItemSeparator = ';';
			this.cboPGM.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cboPGM.Caption = "";
			this.cboPGM.CaptionHeight = 17;
			this.cboPGM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cboPGM.ColumnCaptionHeight = 17;
			this.cboPGM.ColumnFooterHeight = 17;
			this.cboPGM.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cboPGM.ContentHeight = 18;
			this.cboPGM.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cboPGM.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cboPGM.EditorFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboPGM.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cboPGM.EditorHeight = 18;
			this.cboPGM.GapHeight = 2;
			this.cboPGM.ItemHeight = 15;
			this.cboPGM.Location = new System.Drawing.Point(584, 8);
			this.cboPGM.MatchEntryTimeout = ((long)(2000));
			this.cboPGM.MaxDropDownItems = ((short)(5));
			this.cboPGM.MaxLength = 32767;
			this.cboPGM.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cboPGM.Name = "cboPGM";
			this.cboPGM.PartialRightColumn = false;
			this.cboPGM.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFoote" +
				"rHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" +
				"ght>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\" />" +
				"<GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"Sty" +
				"le2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle par" +
				"ent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><RecordS" +
				"electorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Selec" +
				"ted\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListBoxV" +
				"iew></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" " +
				"me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=" +
				"\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"S" +
				"elected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=" +
				"\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Rec" +
				"ordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1<" +
				"/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" +
				"th>17</DefaultRecSelWidth></Blob>";
			this.cboPGM.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cboPGM.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cboPGM.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cboPGM.Size = new System.Drawing.Size(192, 24);
			this.cboPGM.TabIndex = 33;
			this.cboPGM.Visible = false;
			this.cboPGM.SelectedValueChanged += new System.EventHandler(this.cboPGM_SelectedValueChanged);
			// 
			// dtpdate_to
			// 
			this.dtpdate_to.CustomFormat = "yyyy/MM/dd";
			this.dtpdate_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpdate_to.Location = new System.Drawing.Point(432, 8);
			this.dtpdate_to.Name = "dtpdate_to";
			this.dtpdate_to.Size = new System.Drawing.Size(104, 22);
			this.dtpdate_to.TabIndex = 32;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(408, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 31;
			this.label1.Text = "To";
			// 
			// cboUser
			// 
			this.cboUser.AddItemCols = 0;
			this.cboUser.AddItemSeparator = ';';
			this.cboUser.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cboUser.Caption = "";
			this.cboUser.CaptionHeight = 17;
			this.cboUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cboUser.ColumnCaptionHeight = 17;
			this.cboUser.ColumnFooterHeight = 17;
			this.cboUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cboUser.ContentHeight = 18;
			this.cboUser.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cboUser.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cboUser.EditorFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cboUser.EditorHeight = 18;
			this.cboUser.GapHeight = 2;
			this.cboUser.ItemHeight = 15;
			this.cboUser.Location = new System.Drawing.Point(821, 8);
			this.cboUser.MatchEntryTimeout = ((long)(2000));
			this.cboUser.MaxDropDownItems = ((short)(5));
			this.cboUser.MaxLength = 32767;
			this.cboUser.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cboUser.Name = "cboUser";
			this.cboUser.PartialRightColumn = false;
			this.cboUser.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFoote" +
				"rHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" +
				"ght>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\" />" +
				"<GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"Sty" +
				"le2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle par" +
				"ent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><RecordS" +
				"electorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Selec" +
				"ted\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListBoxV" +
				"iew></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" " +
				"me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=" +
				"\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"S" +
				"elected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=" +
				"\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Rec" +
				"ordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1<" +
				"/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" +
				"th>17</DefaultRecSelWidth></Blob>";
			this.cboUser.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cboUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cboUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cboUser.Size = new System.Drawing.Size(192, 24);
			this.cboUser.TabIndex = 30;
			this.cboUser.Visible = false;
			// 
			// lbl15
			// 
			this.lbl15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl15.ForeColor = System.Drawing.Color.Blue;
			this.lbl15.Location = new System.Drawing.Point(784, 12);
			this.lbl15.Name = "lbl15";
			this.lbl15.Size = new System.Drawing.Size(40, 16);
			this.lbl15.TabIndex = 29;
			this.lbl15.Text = "User";
			this.lbl15.Visible = false;
			// 
			// lbl_repairarea
			// 
			this.lbl_repairarea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_repairarea.ForeColor = System.Drawing.Color.Blue;
			this.lbl_repairarea.Location = new System.Drawing.Point(544, 12);
			this.lbl_repairarea.Name = "lbl_repairarea";
			this.lbl_repairarea.Size = new System.Drawing.Size(40, 16);
			this.lbl_repairarea.TabIndex = 25;
			this.lbl_repairarea.Text = "PGM";
			this.lbl_repairarea.Visible = false;
			// 
			// cmb_workday
			// 
			this.cmb_workday.CustomFormat = "yyyy/MM/dd";
			this.cmb_workday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.cmb_workday.Location = new System.Drawing.Point(296, 8);
			this.cmb_workday.Name = "cmb_workday";
			this.cmb_workday.Size = new System.Drawing.Size(104, 22);
			this.cmb_workday.TabIndex = 23;
			// 
			// lbl_work_ymd
			// 
			this.lbl_work_ymd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_work_ymd.ForeColor = System.Drawing.Color.Blue;
			this.lbl_work_ymd.Location = new System.Drawing.Point(248, 11);
			this.lbl_work_ymd.Name = "lbl_work_ymd";
			this.lbl_work_ymd.Size = new System.Drawing.Size(49, 16);
			this.lbl_work_ymd.TabIndex = 22;
			this.lbl_work_ymd.Text = "From";
			// 
			// cbo_factory
			// 
			this.cbo_factory.AddItemCols = 0;
			this.cbo_factory.AddItemSeparator = ';';
			this.cbo_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_factory.Caption = "";
			this.cbo_factory.CaptionHeight = 17;
			this.cbo_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_factory.ColumnCaptionHeight = 17;
			this.cbo_factory.ColumnFooterHeight = 17;
			this.cbo_factory.ContentHeight = 17;
			this.cbo_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_factory.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cbo_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_factory.EditorHeight = 17;
			this.cbo_factory.Enabled = false;
			this.cbo_factory.GapHeight = 2;
			this.cbo_factory.ItemHeight = 15;
			this.cbo_factory.Location = new System.Drawing.Point(72, 10);
			this.cbo_factory.MatchEntryTimeout = ((long)(2000));
			this.cbo_factory.MaxDropDownItems = ((short)(5));
			this.cbo_factory.MaxLength = 32767;
			this.cbo_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_factory.Name = "cbo_factory";
			this.cbo_factory.PartialRightColumn = false;
			this.cbo_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFoote" +
				"rHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" +
				"ght>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\" />" +
				"<GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"Sty" +
				"le2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle par" +
				"ent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><RecordS" +
				"electorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Selec" +
				"ted\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListBoxV" +
				"iew></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" " +
				"me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=" +
				"\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"S" +
				"elected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=" +
				"\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Rec" +
				"ordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1<" +
				"/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" +
				"th>17</DefaultRecSelWidth></Blob>";
			this.cbo_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_factory.Size = new System.Drawing.Size(160, 23);
			this.cbo_factory.TabIndex = 21;
			// 
			// lbl_factory
			// 
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ForeColor = System.Drawing.Color.Blue;
			this.lbl_factory.Location = new System.Drawing.Point(8, 14);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(56, 16);
			this.lbl_factory.TabIndex = 20;
			this.lbl_factory.Text = "Factory";
			// 
			// cbo_PGM
			// 
			this.cbo_PGM.AddItemCols = 0;
			this.cbo_PGM.AddItemSeparator = ';';
			this.cbo_PGM.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_PGM.Caption = "";
			this.cbo_PGM.CaptionHeight = 17;
			this.cbo_PGM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_PGM.ColumnCaptionHeight = 17;
			this.cbo_PGM.ColumnFooterHeight = 17;
			this.cbo_PGM.ContentHeight = 15;
			this.cbo_PGM.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_PGM.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_PGM.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_PGM.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_PGM.EditorHeight = 15;
			this.cbo_PGM.GapHeight = 2;
			this.cbo_PGM.ItemHeight = 15;
			this.cbo_PGM.Location = new System.Drawing.Point(0, 0);
			this.cbo_PGM.MatchEntryTimeout = ((long)(2000));
			this.cbo_PGM.MaxDropDownItems = ((short)(5));
			this.cbo_PGM.MaxLength = 32767;
			this.cbo_PGM.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_PGM.Name = "cbo_PGM";
			this.cbo_PGM.PartialRightColumn = false;
			this.cbo_PGM.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFoote" +
				"rHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" +
				"ght>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\" />" +
				"<GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"Sty" +
				"le2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle par" +
				"ent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><RecordS" +
				"electorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Selec" +
				"ted\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListBoxV" +
				"iew></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" " +
				"me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=" +
				"\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"S" +
				"elected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=" +
				"\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Rec" +
				"ordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1<" +
				"/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" +
				"th>17</DefaultRecSelWidth></Blob>";
			this.cbo_PGM.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_PGM.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_PGM.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_PGM.TabIndex = 0;
			// 
			// fgrid_main1
			// 
			this.fgrid_main1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_main1.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main1.ColumnInfo = "5,1,0,0,0,95,Columns:0{Width:29;}\t";
			this.fgrid_main1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main1.Location = new System.Drawing.Point(0, 272);
			this.fgrid_main1.Name = "fgrid_main1";
			this.fgrid_main1.Rows.Count = 2;
			this.fgrid_main1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_main1.Size = new System.Drawing.Size(488, 192);
			this.fgrid_main1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	NewRow{TextAlign:LeftCenter;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{Font:Verdana, 9pt, style=Bold;BackColor:128, 255, 128;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main1.TabIndex = 55;
			this.fgrid_main1.Click += new System.EventHandler(this.fgrid_main1_Click);
			// 
			// fgrid_main2
			// 
			this.fgrid_main2.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_main2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.fgrid_main2.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main2.ColumnInfo = "5,1,0,0,0,95,Columns:0{Width:29;}\t";
			this.fgrid_main2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main2.Location = new System.Drawing.Point(0, 472);
			this.fgrid_main2.Name = "fgrid_main2";
			this.fgrid_main2.Rows.Count = 2;
			this.fgrid_main2.Size = new System.Drawing.Size(488, 168);
			this.fgrid_main2.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	NewRow{TextAlign:LeftCenter;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{Font:Verdana, 9pt, style=Bold;BackColor:128, 255, 128;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main2.TabIndex = 57;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.panel2.Location = new System.Drawing.Point(488, 96);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(8, 544);
			this.panel2.TabIndex = 59;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.Aqua;
			this.panel3.Location = new System.Drawing.Point(0, 264);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1016, 8);
			this.panel3.TabIndex = 60;
			// 
			// Chart
			// 
			this.Chart.DataSource = null;
			this.Chart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Chart.Location = new System.Drawing.Point(496, 96);
			this.Chart.Name = "Chart";
			this.Chart.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Nam" +
				"e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Black,1;</S" +
				"tyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default<" +
				"/ParentName><StyleData /></NamedStyle><NamedStyle><Name>Footer</Name><ParentName" +
				">Control</ParentName><StyleData>Border=None,Black,1;</StyleData></NamedStyle><Na" +
				"medStyle><Name>Area</Name><ParentName>Area.default</ParentName><StyleData /></Na" +
				"medStyle><NamedStyle><Name>Control</Name><ParentName>Control.default</ParentName" +
				"><StyleData>Font=Verdana, 9pt;</StyleData></NamedStyle><NamedStyle><Name>AxisX</" +
				"Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate0;Border=None,Transp" +
				"arent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;AlignVert=Bottom;</S" +
				"tyleData></NamedStyle><NamedStyle><Name>AxisY</Name><ParentName>Area</ParentName" +
				"><StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;BackColo" +
				"r=Transparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><NamedStyle" +
				"><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault.default</ParentName" +
				"><StyleData /></NamedStyle><NamedStyle><Name>Legend.default</Name><ParentName>Co" +
				"ntrol</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</Styl" +
				"eData></NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Name><ParentName" +
				">Control</ParentName><StyleData>Border=None,Black,1;BackColor=Transparent;</Styl" +
				"eData></NamedStyle><NamedStyle><Name>Header</Name><ParentName>Control</ParentNam" +
				"e><StyleData>Border=None,Black,1;</StyleData></NamedStyle><NamedStyle><Name>Cont" +
				"rol.default</Name><ParentName /><StyleData>ForeColor=ControlText;Border=None,Bla" +
				"ck,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle><Name>AxisY2</Name><" +
				"ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=None,Transparent" +
				",1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData></NamedStyle" +
				"><NamedStyle><Name>Area.default</Name><ParentName>Control</ParentName><StyleData" +
				">Border=None,Black,1;AlignVert=Top;</StyleData></NamedStyle></StyleCollection><C" +
				"hartGroupsCollection><ChartGroup><DataSerializer Hole=\"3.4028234663852886E+38\" D" +
				"efaultSet=\"True\"><DataSeriesCollection><DataSeriesSerializer><LineStyle Thicknes" +
				"s=\"1\" Color=\"DarkGoldenrod\" Pattern=\"Solid\" /><SymbolStyle Color=\"Coral\" Outline" +
				"Color=\"\" Shape=\"Box\" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5;6;7;8;9;1" +
				"0;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234" +
				"663852886E+38;3.4028234663852886E+38</X><Y>20;22;19;24;25;26;27;30;35;36;3.40282" +
				"34663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886" +
				"E+38;3.4028234663852886E+38</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Double;Double" +
				";Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerial" +
				"izer></DataSeriesCollection></DataSerializer><Name>Group1</Name><Stacked>False</" +
				"Stacked><ChartType>Bar</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOv" +
				"erlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent=True,Ful" +
				"lWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diame" +
				"ter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=" +
				"True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Use3D>False" +
				"</Use3D><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGroup><Char" +
				"tGroup><DataSerializer Hole=\"3.4028234663852886E+38\" /><Name>Group2</Name><Stack" +
				"ed>False</Stacked><ChartType>Bar</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar" +
				">ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparen" +
				"t=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMe" +
				"thod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAn" +
				"notations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><V" +
				"isible>True</Visible><ShowOutline>True</ShowOutline></ChartGroup></ChartGroupsCo" +
				"llection><Header Compass=\"North\"><Text /></Header><Footer Compass=\"South\"><Text " +
				"/></Footer><Legend Compass=\"East\" Visible=\"False\"><Text /></Legend><ChartArea />" +
				"<Axes><Axis Max=\"10.375\" Min=\"0.625\" AnnoFormat=\"NumericManual\" UnitMajor=\"1\" Un" +
				"itMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _o" +
				"nTop=\"0\" Compass=\"South\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color" +
				"=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"L" +
				"ightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"40\" Min=\"15\" UnitMajor=\"5\" UnitMino" +
				"r=\"2.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"" +
				"0\" Compass=\"West\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"Light" +
				"Gray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGra" +
				"y\" Pattern=\"Dash\" /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" Aut" +
				"oMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=" +
				"\"East\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Patte" +
				"rn=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=" +
				"\"Dash\" /></Axis></Axes></Chart2DPropBag>";
			this.Chart.Size = new System.Drawing.Size(512, 168);
			this.Chart.TabIndex = 61;
			// 
			// Chart1
			// 
			this.Chart1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.Chart1.DataSource = null;
			this.Chart1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Chart1.Location = new System.Drawing.Point(500, 272);
			this.Chart1.Name = "Chart1";
			this.Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Nam" +
				"e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Black,1;</S" +
				"tyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default<" +
				"/ParentName><StyleData>AlignHorz=General;AlignVert=Top;</StyleData></NamedStyle>" +
				"<NamedStyle><Name>Footer</Name><ParentName>Control</ParentName><StyleData>Border" +
				"=None,Black,1;</StyleData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>" +
				"Area.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Control</Na" +
				"me><ParentName>Control.default</ParentName><StyleData /></NamedStyle><NamedStyle" +
				"><Name>AxisX</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate0;Bord" +
				"er=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;AlignV" +
				"ert=Bottom;</StyleData></NamedStyle><NamedStyle><Name>AxisY</Name><ParentName>Ar" +
				"ea</ParentName><StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz" +
				"=Near;BackColor=Transparent;Opaque=False;AlignVert=Center;</StyleData></NamedSty" +
				"le><NamedStyle><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault.defau" +
				"lt</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Legend.default</Name>" +
				"<ParentName>Control</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignV" +
				"ert=Top;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Na" +
				"me><ParentName>Control</ParentName><StyleData>Border=None,Black,1;BackColor=Tran" +
				"sparent;</StyleData></NamedStyle><NamedStyle><Name>Header</Name><ParentName>Cont" +
				"rol</ParentName><StyleData>Border=None,Black,1;</StyleData></NamedStyle><NamedSt" +
				"yle><Name>Control.default</Name><ParentName /><StyleData>ForeColor=ControlText;B" +
				"order=None,Black,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle><Name>" +
				"AxisY2</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=No" +
				"ne,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleDat" +
				"a></NamedStyle><NamedStyle><Name>Area.default</Name><ParentName>Control</ParentN" +
				"ame><StyleData>Border=None,Black,1;AlignVert=Top;</StyleData></NamedStyle></Styl" +
				"eCollection><ChartGroupsCollection><ChartGroup><DataSerializer Hole=\"3.402823466" +
				"3852886E+38\" DefaultSet=\"True\"><DataSeriesCollection><DataSeriesSerializer><Line" +
				"Style Thickness=\"1\" Color=\"Blue\" Pattern=\"Solid\" /><SymbolStyle Color=\"Coral\" Ou" +
				"tlineColor=\"\" Shape=\"Box\" /><SeriesLabel>Delete</SeriesLabel><X>1;2;3;4;5;6;7;8;" +
				"9</X><Y>20;22;19;24;25;26;27;29;30</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single" +
				";Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSerie" +
				"sSerializer><DataSeriesSerializer><LineStyle Thickness=\"1\" Color=\"Magenta\" Patte" +
				"rn=\"Solid\" /><SymbolStyle Color=\"CornflowerBlue\" OutlineColor=\"\" Shape=\"Dot\" /><" +
				"SeriesLabel>Insert</SeriesLabel><X>1;2;3;4;5;6;7;8;9</X><Y>8;12;10;12;15;16;17;1" +
				"9;21</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</DataTyp" +
				"es><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeriesSeriali" +
				"zer><LineStyle Thickness=\"1\" Color=\"Yellow\" Pattern=\"Solid\" /><SymbolStyle Color" +
				"=\"Cornsilk\" OutlineColor=\"\" Shape=\"Tri\" /><SeriesLabel>Search</SeriesLabel><X>1;" +
				"2;3;4;5;6;7;8;9</X><Y>10;16;17;15;23;24;25;26;27</Y><Y1 /><Y2 /><Y3 /><DataTypes" +
				">Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag" +
				" /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickness=\"1\" Color=\"" +
				"Lime\" Pattern=\"Solid\" /><SymbolStyle Color=\"Crimson\" OutlineColor=\"\" Shape=\"Diam" +
				"ond\" /><SeriesLabel>Update</SeriesLabel><X>1;2;3;4;5;6;7;8;9</X><Y>16;19;15;22;1" +
				"8;19;20;21;23</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double" +
				"</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer></DataSer" +
				"iesCollection></DataSerializer><Name>Group1</Name><Stacked>False</Stacked><Chart" +
				"Type>Bar</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,Cluste" +
				"rWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,S" +
				"howClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSiz" +
				"e=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</" +
				"Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Use3D>False</Use3D><Visib" +
				"le>True</Visible><ShowOutline>True</ShowOutline></ChartGroup><ChartGroup><DataSe" +
				"rializer Hole=\"3.4028234663852886E+38\" /><Name>Group2</Name><Stacked>False</Stac" +
				"ked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOve" +
				"rlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent=True,Full" +
				"Width=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diamet" +
				"er,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=T" +
				"rue,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Visible>True" +
				"</Visible><ShowOutline>True</ShowOutline></ChartGroup></ChartGroupsCollection><H" +
				"eader Compass=\"North\"><Text /></Header><Footer Compass=\"South\"><Text /></Footer>" +
				"<Legend Compass=\"East\" Visible=\"True\"><Text /></Legend><ChartArea /><Axes><Axis " +
				"Max=\"9.5\" Min=\"0.5\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"Tr" +
				"ue\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"South\"><Text /><GridMajor " +
				"AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor Aut" +
				"oSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=" +
				"\"30\" Min=\"5\" UnitMajor=\"5\" UnitMinor=\"2.5\" AutoMajor=\"True\" AutoMinor=\"True\" Aut" +
				"oMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"West\"><Text /><GridMajor AutoSpac" +
				"e=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"" +
				"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"0\" Min=" +
				"\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\"" +
				" AutoMin=\"True\" _onTop=\"0\" Compass=\"East\"><Text /><GridMajor AutoSpace=\"True\" Th" +
				"ickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thick" +
				"ness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis></Axes></Chart2DPropBag>";
			this.Chart1.Size = new System.Drawing.Size(508, 192);
			this.Chart1.TabIndex = 64;
			// 
			// Chart3
			// 
			this.Chart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Chart3.DataSource = null;
			this.Chart3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Chart3.Location = new System.Drawing.Point(500, 472);
			this.Chart3.Name = "Chart3";
			this.Chart3.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Nam" +
				"e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Black,1;</S" +
				"tyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default<" +
				"/ParentName><StyleData>AlignHorz=General;AlignVert=Top;</StyleData></NamedStyle>" +
				"<NamedStyle><Name>Footer</Name><ParentName>Control</ParentName><StyleData>Border" +
				"=None,Black,1;</StyleData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>" +
				"Area.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Control</Na" +
				"me><ParentName>Control.default</ParentName><StyleData>Font=Verdana, 9pt;</StyleD" +
				"ata></NamedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</ParentName><Sty" +
				"leData>Font=Verdana, 7pt, style=Italic;AlignVert=Bottom;AlignHorz=Center;Rotatio" +
				"n=Rotate0;Border=None,Transparent,1;Opaque=False;BackColor=Transparent;</StyleDa" +
				"ta></NamedStyle><NamedStyle><Name>AxisY</Name><ParentName>Area</ParentName><Styl" +
				"eData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;BackColor=Tran" +
				"sparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name" +
				">LabelStyleDefault</Name><ParentName>LabelStyleDefault.default</ParentName><Styl" +
				"eData /></NamedStyle><NamedStyle><Name>Legend.default</Name><ParentName>Control<" +
				"/ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData>" +
				"</NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Name><ParentName>Contr" +
				"ol</ParentName><StyleData>Border=None,Black,1;BackColor=Transparent;</StyleData>" +
				"</NamedStyle><NamedStyle><Name>Header</Name><ParentName>Control</ParentName><Sty" +
				"leData>Rotation=Rotate0;Border=None,Black,1;AlignHorz=General;Opaque=True;AlignV" +
				"ert=Top;</StyleData></NamedStyle><NamedStyle><Name>Control.default</Name><Parent" +
				"Name /><StyleData>ForeColor=ControlText;Border=None,Black,1;BackColor=Control;</" +
				"StyleData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentNa" +
				"me><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColo" +
				"r=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>Area.d" +
				"efault</Name><ParentName>Control</ParentName><StyleData>Border=None,Black,1;Alig" +
				"nVert=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection><Cha" +
				"rtGroup><DataSerializer Hole=\"3.4028234663852886E+38\" DefaultSet=\"True\"><DataSer" +
				"iesCollection><DataSeriesSerializer><LineStyle Thickness=\"1\" Color=\"DarkGoldenro" +
				"d\" Pattern=\"Solid\" /><SymbolStyle Color=\"Coral\" OutlineColor=\"\" Shape=\"Dot\" /><S" +
				"eriesLabel>series 0</SeriesLabel><X>1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;3.402823" +
				"4663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E" +
				"+38;3.4028234663852886E+38</X><Y>20;22;19;24;25;27;29;31;33;35;37;39;41;43;45;3." +
				"4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.40282346638" +
				"52886E+38;3.4028234663852886E+38</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;D" +
				"ouble;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesS" +
				"erializer></DataSeriesCollection></DataSerializer><Name>Group1</Name><Stacked>Tr" +
				"ue</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>Cl" +
				"usterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent=T" +
				"rue,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMetho" +
				"d=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnot" +
				"ations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Use3" +
				"D>False</Use3D><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGrou" +
				"p><ChartGroup><DataSerializer Hole=\"3.4028234663852886E+38\" /><Name>Group2</Name" +
				"><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0,Start=0" +
				"</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,Fill" +
				"Transparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>" +
				"EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True" +
				",PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0" +
				"</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGroup></Cha" +
				"rtGroupsCollection><Header Compass=\"North\"><Text /></Header><Footer Compass=\"Sou" +
				"th\"><Text /></Footer><Legend Compass=\"East\" Visible=\"False\"><Text /></Legend><Ch" +
				"artArea /><Axes><Axis Max=\"15\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"" +
				"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"South\">" +
				"<Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Das" +
				"h\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" " +
				"/></Axis><Axis Max=\"50\" Min=\"10\" UnitMajor=\"10\" UnitMinor=\"5\" AutoMajor=\"True\" A" +
				"utoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"West\"><Text />" +
				"<GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><Gr" +
				"idMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis" +
				"><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"T" +
				"rue\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"East\"><Text /><GridMajor " +
				"AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor Aut" +
				"oSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis></Axes></C" +
				"hart2DPropBag>";
			this.Chart3.Size = new System.Drawing.Size(508, 168);
			this.Chart3.TabIndex = 63;
			// 
			// Form_Sys_PGM_Mon
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.Chart1);
			this.Controls.Add(this.Chart3);
			this.Controls.Add(this.Chart);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.fgrid_main2);
			this.Controls.Add(this.fgrid_main1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.fgrid_main);
			this.Name = "Form_Sys_PGM_Mon";
			this.Load += new System.EventHandler(this.Form_Sys_PGM_Mon_Load);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.fgrid_main1, 0);
			this.Controls.SetChildIndex(this.fgrid_main2, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.panel3, 0);
			this.Controls.SetChildIndex(this.Chart, 0);
			this.Controls.SetChildIndex(this.Chart3, 0);
			this.Controls.SetChildIndex(this.Chart1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cboPGM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cboUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_PGM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart3)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		private void Form_Sys_PGM_Mon_Load(object sender, System.EventArgs e)
		{	
			Init_Form();
			fgrid_main1.Visible = false ;
			Chart1.Visible = false;
			fgrid_main2.Visible = false;
			Chart3.Visible = false;
		}
		private void Init_Form()
		{
			this.Text = "System PGM ";
			cbo_factory.Text = "Chanhshin Viet Nam";
			this.lbl_MainTitle.Text = "System PGM Monitoring";
			ClassLib.ComFunction.SetLangDic(this);
		
			fgrid_main.Set_Grid("SYS_PGM_MANAGER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			//_RowFixed_desc = fgrip_main.Rows.Fixed;
//			fgrid_main.ExtendLastCol = false;
//			fgrid_main.AutoSizeCols();
 
			DataTable dt_ret = Select_com_filter_code_List("SPGM01");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cboPGM, 0, 1, false, false);

		}
		private DataTable Select_com_filter_code_List(string com_cd)
		{
			string Proc_Name = "pkg_scm_code.select_com_filter_code_list";

			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_COM_CD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = com_cd;
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_main1.Clear();
			fgrid_main1.Set_Grid("SYS_PGM_MANAGER1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main2.Clear();
			fgrid_main2.Set_Grid("SYS_PGM_MANAGER2", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			FlexMold.ClassLib.ComVar.div = "1";
			fgrid_main1.Visible = false ;
			Chart1.Visible = false;
			fgrid_main2.Visible = false;
			Chart3.Visible = false;
			Search_PGM();
			Chart_PGM();
		}
		private void Search_PGM()
		{
			System.Data.DataTable vDt1 = null;
			if(FlexMold.ClassLib.ComVar.div == "1")
			{
				fgrid_main.Clear();
				fgrid_main.Set_Grid("SYS_PGM_MANAGER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			}
			else if(FlexMold.ClassLib.ComVar.div == "2")
			{
				fgrid_main1.Clear();
				fgrid_main1.Set_Grid("SYS_PGM_MANAGER1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			}
			else
			{
				fgrid_main2.Clear();
				fgrid_main2.Set_Grid("SYS_PGM_MANAGER2", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			}
			try
			{
				vDt1 = SELECT_SYS_PGM();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						if(FlexMold.ClassLib.ComVar.div == "1")
						{
							fgrid_main.AddItem( vDt1.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);
						}
						else if(FlexMold.ClassLib.ComVar.div == "2")
						{
							fgrid_main1.AddItem( vDt1.Rows[i].ItemArray, fgrid_main1.Rows.Count, 1);
							fgrid_main1.Cols[1].AllowMerging = true ;
						}
						else
						{
							fgrid_main2.AddItem( vDt1.Rows[i].ItemArray, fgrid_main2.Rows.Count, 1);
						}
						
					}
					fgrid_main.AutoSizeCols();
//					SubTotalGrid();
				}
				else
				{
					MessageBox.Show("No Data !!");
					return;
				}
			}
			catch
			{

			}
		}

		private System.Data.DataTable SELECT_SYS_PGM()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SYS_PGM_MON.SEARCH_PGM";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_YMD_FROM";
			OraDB.Parameter_Name[2] = "ARG_YMD_TO";
			OraDB.Parameter_Name[3] = "ARG_DIV";
			OraDB.Parameter_Name[4] = "ARG_PGM";
			OraDB.Parameter_Name[5] = "ARG_ACTION";
			OraDB.Parameter_Name[6] = "ARG_USER";
			OraDB.Parameter_Name[7] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			
			OraDB.Parameter_Type[7] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = "VJ" ;
			OraDB.Parameter_Values[1] = cmb_workday.Value.ToString("yyyyMMdd");
			OraDB.Parameter_Values[2] = dtpdate_to.Value.ToString("yyyyMMdd");
			if(FlexMold.ClassLib.ComVar.div == "1")
			{
				OraDB.Parameter_Values[3] = "1";
				OraDB.Parameter_Values[4] = "";
				OraDB.Parameter_Values[5] = "";
				OraDB.Parameter_Values[6] = "";
			}
			else if(FlexMold.ClassLib.ComVar.div == "2")
			{
				OraDB.Parameter_Values[3] = "2";
				OraDB.Parameter_Values[4] = fgrid_main[fgrid_main.RowSel,1].ToString();
				OraDB.Parameter_Values[5] = "";
				OraDB.Parameter_Values[6] = "";

			}
			else 
			{
				OraDB.Parameter_Values[3] = "3";
				OraDB.Parameter_Values[4] = fgrid_main1[0,fgrid_main1.ColSel].ToString();
				OraDB.Parameter_Values[5] = fgrid_main1[fgrid_main1.RowSel,1].ToString().Substring(0,1);
				OraDB.Parameter_Values[6] = "";

			}
			
			OraDB.Parameter_Values[7] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}

		private void cboPGM_SelectedValueChanged(object sender, System.EventArgs e)
		{
			dt_list = Select_User();
			COM.ComCtl.Set_ComboList(dt_list, cboUser, 0, 1, true);  			
			cboUser.SelectedIndex = 0;
		}

		private System.Data.DataTable Select_User()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SYS_PGM_MON.SELECT_PGM_USER";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_YMD_FROM";
			OraDB.Parameter_Name[2] = "ARG_YMD_TO";
			OraDB.Parameter_Name[3] = "ARG_PGM";
			OraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = "VJ" ;
			OraDB.Parameter_Values[1] = cmb_workday.Value.ToString("yyyyMMdd");
			OraDB.Parameter_Values[2] = dtpdate_to.Value.ToString("yyyyMMdd");
			OraDB.Parameter_Values[3] = cboPGM.SelectedValue.ToString();
			
			OraDB.Parameter_Values[4] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}
		private void Chart_PGM()
		{
			setupChart();
			setupData();
		 }
		void setupData()
		{
			// Setup the Axis X
			C1.Win.C1Chart.Axis ax = Chart.ChartArea.AxisX;
			ax.Font = new Font("Arial", 8);
			ax.Thickness = 2;
			ax.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels; 
			ax.GridMajor.Color = Color.DarkGray;
			ax.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			ax.GridMajor.Thickness = 2;
			ax.GridMajor.Visible = true;

			ax.ValueLabels.Clear();
			for( int j = 2 ; j <= fgrid_main.Rows.Count-1 ; j++) 
			{
				string temp = fgrid_main[j,1].ToString();
				C1.Win.C1Chart.ValueLabel vlbl = ax.ValueLabels.AddNewLabel();
				vlbl.NumericValue = j-1;
				vlbl.Text = temp ;
			}

			ArrayList arrQty	= new ArrayList();

			for ( int i = 2 ; i<fgrid_main.Rows.Count; i++)
				arrQty.Add(double.Parse(Convert.ToString(fgrid_main[(short)i,3])));


			Chart.ChartGroups[0].ChartData[0].Y.CopyDataIn((double[])arrQty.ToArray(typeof(double)));

			// setup group1 data
			C1.Win.C1Chart.ChartDataSeries ds1 = new C1.Win.C1Chart.ChartDataSeries();
			
			// setup appearance
			ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
			ds1.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Box;
			ds1.SymbolStyle.Color = Color.Black;

			//add the data series
			Chart.ChartGroups[1].ChartData.SeriesList.Add( ds1);
		}
		void setupChart()
		{
			
			//setup the chart style
			Chart.Style.BackColor = Color.LightBlue;

			//setup the chart header
			Chart.Header.Text="PGM";
			Chart.Header.Style.Border.BorderStyle=C1.Win.C1Chart.BorderStyleEnum.Raised;
			Chart.Header.Style.Font = new Font( "Arial", 12);

			//setup the chart area
			Chart.ChartArea.Style.BackColor = Color.LightYellow;
			Chart.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			Chart.ChartArea.Style.Border.Thickness = 4;

			//setup axes
			Chart.ChartArea.AxisX.ForeColor = Color.Red;
			Chart.ChartArea.AxisX.Min = 0;
			Chart.ChartArea.AxisX.Max = fgrid_main.Rows.Count-1;

			Chart.ChartArea.AxisY.ForeColor = Color.Blue;

		}
		private void Chart_PGM1()
		{
			setupChart1();
			setupData1();
		}

		void setupChart1()
		{	
			//setup the chart style
			Chart1.Style.BackColor = Color.LightBlue;

			//setup the chart header
			Chart1.Header.Text="PGM Detail";
			Chart1.Header.Style.Border.BorderStyle=C1.Win.C1Chart.BorderStyleEnum.Raised;
			Chart1.Header.Style.Font = new Font( "Arial", 12);

			//setup the chart area
			Chart1.ChartArea.Style.BackColor = Color.LightYellow;
			Chart1.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			Chart1.ChartArea.Style.Border.Thickness = 4;

		}

		void setupData1()
		{
			// clear data
//			Chart1.ChartGroups[0].ChartData.SeriesList.Clear();

			// remove all previous data and add one new data series			
//			series0 = Chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
			int a = Chart1.ChartGroups.ChartGroupsCollection[0].ChartData.SeriesList.Count;
			if (a  < 4)
				series0 = Chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
			
//			if (series0 == null)
//				return;

			// Setup the Axis X
			C1.Win.C1Chart.Axis ax = Chart1.ChartArea.AxisX;
			ax.Font = new Font("Arial", 8);
			ax.Thickness = 2;
			ax.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels; 
			ax.GridMajor.Color = Color.DarkGray;
			ax.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			ax.GridMajor.Thickness = 2;
			ax.GridMajor.Visible = true;

			ax.ValueLabels.Clear();
			for( int j = 2 ; j <= fgrid_main1.Cols.Count-1 ; j++) 
			{								
				C1.Win.C1Chart.ValueLabel vlbl = ax.ValueLabels.AddNewLabel();
				vlbl.NumericValue = j-1;
				vlbl.Text = fgrid_main1[0,j].ToString();;
			}
			
			ArrayList arrPgm	= new ArrayList();
			ArrayList arrDelete	= new ArrayList();
			ArrayList arrInsert	= new ArrayList();
			ArrayList arrSearch	= new ArrayList();
			ArrayList arrUpdate	= new ArrayList();

			for(int k = 2 ; k < fgrid_main1.Cols.Count; k++)
			{
				arrPgm.Add(fgrid_main1[1,(short)k]);
				arrDelete.Add(double.Parse(Convert.ToString(fgrid_main1[2,(short)k])));
				arrInsert.Add(double.Parse(Convert.ToString(fgrid_main1[3,(short)k])));
				arrSearch.Add(double.Parse(Convert.ToString(fgrid_main1[4,(short)k])));
				arrUpdate.Add(double.Parse(Convert.ToString(fgrid_main1[5,(short)k])));
			}

			// setup group0 data
			Chart1.ChartGroups[0].ChartData[0].Y.CopyDataIn((double[])arrDelete.ToArray(typeof(double)));
			Chart1.ChartGroups[0].ChartData[1].Y.CopyDataIn((double[])arrInsert.ToArray(typeof(double)));
			Chart1.ChartGroups[0].ChartData[2].Y.CopyDataIn((double[])arrSearch.ToArray(typeof(double)));
			Chart1.ChartGroups[0].ChartData[3].Y.CopyDataIn((double[])arrUpdate.ToArray(typeof(double)));

//			Chart1.ChartGroups.Group0.ChartData.SeriesList[0].Y.CopyDataIn((double[])arrDelete.ToArray(typeof(double)));
//			Chart1.ChartGroups.Group0.ChartData.SeriesList[1].Y.CopyDataIn((double[])arrInsert.ToArray(typeof(double)));
//			Chart1.ChartGroups.Group0.ChartData.SeriesList[2].Y.CopyDataIn((double[])arrSearch.ToArray(typeof(double)));
//			Chart1.ChartGroups.Group0.ChartData.SeriesList[3].Y.CopyDataIn((double[])arrUpdate.ToArray(typeof(double)));

//			series0.Y.CopyDataIn((double[])arrUpdate.ToArray(typeof(double)));
//			series0.Y.CopyDataIn((double[])arrDelete.ToArray(typeof(double)));
//			series0.Y.CopyDataIn((double[])arrInsert.ToArray(typeof(double)));
//			series0.Y.CopyDataIn((double[])arrSearch.ToArray(typeof(double)));

		}
		

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			FlexMold.ClassLib.ComVar.div = "2";
			fgrid_main1.Visible = true ;
			Chart1.Visible = true;
			fgrid_main2.Visible = false;
			Chart3.Visible = false;
			Search_PGM();
			Chart_PGM1();
		}
		private void SubTotalGrid()
		{
			fgrid_main1.Subtotal(AggregateEnum.Clear);
			fgrid_main1.SubtotalPosition = SubtotalPositionEnum.BelowData;
//			fgrid_main1.Subtotal(AggregateEnum.Sum, -1,-1, 3, "GTotal");
			fgrid_main1.Subtotal(AggregateEnum.Sum, 0, 1, 3, "STotal");			 
		}

		private void fgrid_main1_Click(object sender, System.EventArgs e)
		{
			if (fgrid_main1.ColSel > 1)
			{	
				fgrid_main2.Visible = true;
				Chart3.Visible = true;
				FlexMold.ClassLib.ComVar.div = "3";
				Search_PGM();
				Search_no();
				Chart_PGM2();
			}
			else
				return;
		}
		private void Search_no()
		{
			for ( int k = 1 ; k < fgrid_main2.Rows.Count -1 ; k++ )
			{				
				fgrid_main2[k+1,0] = k ;
			}

		}
		private void Chart_PGM2()
		{
			setupChart2();
			setupData2();
		}
		void setupChart2()
		{
			
			//setup the chart style
			Chart3.Style.BackColor = Color.LightBlue;

			//setup the chart header
			Chart3.Header.Text="PGM By User";
			Chart3.Header.Style.Border.BorderStyle=C1.Win.C1Chart.BorderStyleEnum.Raised;
			Chart3.Header.Style.Font = new Font( "Arial", 12);

			//setup the chart area
			Chart3.ChartArea.Style.BackColor = Color.LightYellow;
			Chart3.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			Chart3.ChartArea.Style.Border.Thickness = 4;

			//setup axes
			Chart3.ChartArea.AxisX.ForeColor = Color.Red;
			Chart3.ChartArea.AxisX.Min = 0;
			Chart3.ChartArea.AxisX.Max = fgrid_main2.Rows.Count-1;

			Chart3.ChartArea.AxisY.ForeColor = Color.Blue;

		}

		void setupData2()
		{
			// Setup the Axis X
//			C1.Win.C1Chart.Axis ax = Chart3.ChartArea.AxisX;
//			ax.Font = new Font("Arial", 8);
//			ax.Thickness = 2;
//			ax.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels; 
//			ax.GridMajor.Color = Color.DarkGray;
//			ax.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
//			ax.GridMajor.Thickness = 2;
//			ax.GridMajor.Visible = true;
//
//			ax.ValueLabels.Clear();
//			for( int j = 2 ; j <= fgrid_main2.Rows.Count-1 ; j++) 
//			{
//				string temp = fgrid_main2[j,1].ToString();
//				C1.Win.C1Chart.ValueLabel vlbl = ax.ValueLabels.AddNewLabel();
//				vlbl.NumericValue = j-1;
//				vlbl.Text = temp ;
//				
//			}

			ArrayList arrQty	= new ArrayList();
			ArrayList arrUser   = new ArrayList();
			
			Chart3.ChartGroups[0].ChartData[0].Y.Length =  fgrid_main2.Rows.Count-2;

			for ( int i = 2 ; i < fgrid_main2.Rows.Count; i++)
			{
				arrUser.Add(double.Parse(Convert.ToString(fgrid_main2[(short)i,0])));
				arrQty.Add(double.Parse(Convert.ToString(fgrid_main2[(short)i,2])));
			}

			Chart3.ChartGroups[0].ChartData[0].X.CopyDataIn((double[])arrUser.ToArray(typeof(double)));
			Chart3.ChartGroups[0].ChartData[0].Y.CopyDataIn((double[])arrQty.ToArray(typeof(double)));

		}
		
		

	}
}

