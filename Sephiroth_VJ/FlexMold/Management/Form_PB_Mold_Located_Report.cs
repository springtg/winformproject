using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexMold.Management
{
	public class Form_PB_Mold_Located_Report : COM.MoldWinForm.Form_Top
	{
		public COM.FSP fgrid_main;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnel1;
		private System.Windows.Forms.Label lbl_wp;
		private C1.Win.C1List.C1Combo cbo_area;
		private C1.Win.C1List.C1Combo cbo_wh;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_sf;
		private System.Windows.Forms.Panel pnel3;
		private C1.Win.C1List.C1Combo cbo_mc;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cbo_sec;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel pnel2;
		private C1.Win.C1List.C1Combo cbo_rank;
		private System.Windows.Forms.Label lbl_level;
		private C1.Win.C1List.C1Combo cbo_level;
		private System.Windows.Forms.Label lbl_rank;
		private System.Windows.Forms.Label lbl_shelf;
		private C1.Win.C1List.C1Combo cbo_shelf;
		private System.Windows.Forms.Button btn_wh;
		private System.Windows.Forms.Button button2;

		private COM.OraDB OraDB = new COM.OraDB();

		public Form_PB_Mold_Located_Report()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Located_Report));
			this.fgrid_main = new COM.FSP();
			this.pnel1 = new System.Windows.Forms.Panel();
			this.pnel3 = new System.Windows.Forms.Panel();
			this.cbo_mc = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.cbo_sec = new C1.Win.C1List.C1Combo();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pnel2 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.cbo_rank = new C1.Win.C1List.C1Combo();
			this.lbl_level = new System.Windows.Forms.Label();
			this.cbo_level = new C1.Win.C1List.C1Combo();
			this.lbl_rank = new System.Windows.Forms.Label();
			this.lbl_shelf = new System.Windows.Forms.Label();
			this.cbo_shelf = new C1.Win.C1List.C1Combo();
			this.lbl_wp = new System.Windows.Forms.Label();
			this.cbo_area = new C1.Win.C1List.C1Combo();
			this.cbo_wh = new C1.Win.C1List.C1Combo();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.btn_wh = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_sf = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnel1.SuspendLayout();
			this.pnel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbo_mc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_sec)).BeginInit();
			this.pnel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbo_rank)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_level)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_shelf)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_area)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
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
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// fgrid_main
			// 
			this.fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 96);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 2;
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_main.Size = new System.Drawing.Size(1008, 544);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 50;
			// 
			// pnel1
			// 
			this.pnel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnel1.BackColor = System.Drawing.Color.Transparent;
			this.pnel1.Controls.Add(this.pnel3);
			this.pnel1.Controls.Add(this.pnel2);
			this.pnel1.Controls.Add(this.lbl_wp);
			this.pnel1.Controls.Add(this.cbo_area);
			this.pnel1.Controls.Add(this.cbo_wh);
			this.pnel1.Controls.Add(this.cbo_factory);
			this.pnel1.Controls.Add(this.lbl_factory);
			this.pnel1.Location = new System.Drawing.Point(0, 56);
			this.pnel1.Name = "pnel1";
			this.pnel1.Size = new System.Drawing.Size(1008, 40);
			this.pnel1.TabIndex = 51;
			// 
			// pnel3
			// 
			this.pnel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnel3.Controls.Add(this.cbo_mc);
			this.pnel3.Controls.Add(this.label1);
			this.pnel3.Controls.Add(this.cbo_sec);
			this.pnel3.Controls.Add(this.label3);
			this.pnel3.Controls.Add(this.button1);
			this.pnel3.Location = new System.Drawing.Point(601, 0);
			this.pnel3.Name = "pnel3";
			this.pnel3.Size = new System.Drawing.Size(352, 32);
			this.pnel3.TabIndex = 21;
			// 
			// cbo_mc
			// 
			this.cbo_mc.AddItemCols = 0;
			this.cbo_mc.AddItemSeparator = ';';
			this.cbo_mc.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_mc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbo_mc.Caption = "";
			this.cbo_mc.CaptionHeight = 17;
			this.cbo_mc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_mc.ColumnCaptionHeight = 17;
			this.cbo_mc.ColumnFooterHeight = 17;
			this.cbo_mc.ContentHeight = 17;
			this.cbo_mc.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_mc.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_mc.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_mc.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_mc.EditorHeight = 17;
			this.cbo_mc.GapHeight = 2;
			this.cbo_mc.ItemHeight = 15;
			this.cbo_mc.Location = new System.Drawing.Point(86, 6);
			this.cbo_mc.MatchEntryTimeout = ((long)(2000));
			this.cbo_mc.MaxDropDownItems = ((short)(5));
			this.cbo_mc.MaxLength = 32767;
			this.cbo_mc.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_mc.Name = "cbo_mc";
			this.cbo_mc.PartialRightColumn = false;
			this.cbo_mc.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_mc.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_mc.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_mc.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_mc.Size = new System.Drawing.Size(96, 23);
			this.cbo_mc.TabIndex = 12;
			this.cbo_mc.SelectedValueChanged += new System.EventHandler(this.cbo_mc_SelectedValueChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(6, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Section";
			// 
			// cbo_sec
			// 
			this.cbo_sec.AddItemCols = 0;
			this.cbo_sec.AddItemSeparator = ';';
			this.cbo_sec.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbo_sec.Caption = "";
			this.cbo_sec.CaptionHeight = 17;
			this.cbo_sec.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_sec.ColumnCaptionHeight = 17;
			this.cbo_sec.ColumnFooterHeight = 17;
			this.cbo_sec.ContentHeight = 17;
			this.cbo_sec.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_sec.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_sec.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_sec.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_sec.EditorHeight = 17;
			this.cbo_sec.GapHeight = 2;
			this.cbo_sec.ItemHeight = 15;
			this.cbo_sec.Location = new System.Drawing.Point(86, 32);
			this.cbo_sec.MatchEntryTimeout = ((long)(2000));
			this.cbo_sec.MaxDropDownItems = ((short)(5));
			this.cbo_sec.MaxLength = 32767;
			this.cbo_sec.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_sec.Name = "cbo_sec";
			this.cbo_sec.PartialRightColumn = false;
			this.cbo_sec.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_sec.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_sec.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_sec.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_sec.Size = new System.Drawing.Size(96, 23);
			this.cbo_sec.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(6, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "M/C(May)";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Location = new System.Drawing.Point(191, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 24);
			this.button1.TabIndex = 14;
			this.button1.Text = "S/F Info";
			// 
			// pnel2
			// 
			this.pnel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnel2.Controls.Add(this.button2);
			this.pnel2.Controls.Add(this.cbo_rank);
			this.pnel2.Controls.Add(this.lbl_level);
			this.pnel2.Controls.Add(this.cbo_level);
			this.pnel2.Controls.Add(this.lbl_rank);
			this.pnel2.Controls.Add(this.lbl_shelf);
			this.pnel2.Controls.Add(this.cbo_shelf);
			this.pnel2.Location = new System.Drawing.Point(608, 0);
			this.pnel2.Name = "pnel2";
			this.pnel2.Size = new System.Drawing.Size(360, 32);
			this.pnel2.TabIndex = 20;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(200, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 24);
			this.button2.TabIndex = 15;
			this.button2.Text = "WH Info";
			// 
			// cbo_rank
			// 
			this.cbo_rank.AddItemCols = 0;
			this.cbo_rank.AddItemSeparator = ';';
			this.cbo_rank.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_rank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbo_rank.Caption = "";
			this.cbo_rank.CaptionHeight = 17;
			this.cbo_rank.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_rank.ColumnCaptionHeight = 17;
			this.cbo_rank.ColumnFooterHeight = 17;
			this.cbo_rank.ContentHeight = 17;
			this.cbo_rank.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_rank.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_rank.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_rank.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_rank.EditorHeight = 17;
			this.cbo_rank.GapHeight = 2;
			this.cbo_rank.ItemHeight = 15;
			this.cbo_rank.Location = new System.Drawing.Point(80, 6);
			this.cbo_rank.MatchEntryTimeout = ((long)(2000));
			this.cbo_rank.MaxDropDownItems = ((short)(5));
			this.cbo_rank.MaxLength = 32767;
			this.cbo_rank.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_rank.Name = "cbo_rank";
			this.cbo_rank.PartialRightColumn = false;
			this.cbo_rank.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_rank.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_rank.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_rank.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_rank.Size = new System.Drawing.Size(104, 23);
			this.cbo_rank.TabIndex = 12;
			this.cbo_rank.SelectedValueChanged += new System.EventHandler(this.cbo_rank_SelectedValueChanged);
			// 
			// lbl_level
			// 
			this.lbl_level.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_level.Location = new System.Drawing.Point(8, 40);
			this.lbl_level.Name = "lbl_level";
			this.lbl_level.Size = new System.Drawing.Size(50, 16);
			this.lbl_level.TabIndex = 10;
			this.lbl_level.Text = "Cell(O)";
			// 
			// cbo_level
			// 
			this.cbo_level.AddItemCols = 0;
			this.cbo_level.AddItemSeparator = ';';
			this.cbo_level.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_level.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbo_level.Caption = "";
			this.cbo_level.CaptionHeight = 17;
			this.cbo_level.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_level.ColumnCaptionHeight = 17;
			this.cbo_level.ColumnFooterHeight = 17;
			this.cbo_level.ContentHeight = 17;
			this.cbo_level.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_level.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_level.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_level.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_level.EditorHeight = 17;
			this.cbo_level.GapHeight = 2;
			this.cbo_level.ItemHeight = 15;
			this.cbo_level.Location = new System.Drawing.Point(80, 32);
			this.cbo_level.MatchEntryTimeout = ((long)(2000));
			this.cbo_level.MaxDropDownItems = ((short)(5));
			this.cbo_level.MaxLength = 32767;
			this.cbo_level.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_level.Name = "cbo_level";
			this.cbo_level.PartialRightColumn = false;
			this.cbo_level.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_level.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_level.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_level.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_level.Size = new System.Drawing.Size(104, 23);
			this.cbo_level.TabIndex = 13;
			// 
			// lbl_rank
			// 
			this.lbl_rank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_rank.Location = new System.Drawing.Point(8, 8);
			this.lbl_rank.Name = "lbl_rank";
			this.lbl_rank.Size = new System.Drawing.Size(96, 16);
			this.lbl_rank.TabIndex = 8;
			this.lbl_rank.Text = "Rank(Day)";
			// 
			// lbl_shelf
			// 
			this.lbl_shelf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_shelf.Location = new System.Drawing.Point(192, 8);
			this.lbl_shelf.Name = "lbl_shelf";
			this.lbl_shelf.Size = new System.Drawing.Size(64, 16);
			this.lbl_shelf.TabIndex = 9;
			this.lbl_shelf.Text = "Shelf(Ke)";
			this.lbl_shelf.Visible = false;
			// 
			// cbo_shelf
			// 
			this.cbo_shelf.AddItemCols = 0;
			this.cbo_shelf.AddItemSeparator = ';';
			this.cbo_shelf.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_shelf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbo_shelf.Caption = "";
			this.cbo_shelf.CaptionHeight = 17;
			this.cbo_shelf.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_shelf.ColumnCaptionHeight = 17;
			this.cbo_shelf.ColumnFooterHeight = 17;
			this.cbo_shelf.ContentHeight = 17;
			this.cbo_shelf.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_shelf.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_shelf.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_shelf.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_shelf.EditorHeight = 17;
			this.cbo_shelf.GapHeight = 2;
			this.cbo_shelf.ItemHeight = 15;
			this.cbo_shelf.Location = new System.Drawing.Point(256, 6);
			this.cbo_shelf.MatchEntryTimeout = ((long)(2000));
			this.cbo_shelf.MaxDropDownItems = ((short)(5));
			this.cbo_shelf.MaxLength = 32767;
			this.cbo_shelf.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_shelf.Name = "cbo_shelf";
			this.cbo_shelf.PartialRightColumn = false;
			this.cbo_shelf.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_shelf.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_shelf.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_shelf.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_shelf.Size = new System.Drawing.Size(97, 23);
			this.cbo_shelf.TabIndex = 12;
			this.cbo_shelf.Visible = false;
			this.cbo_shelf.SelectedValueChanged += new System.EventHandler(this.cbo_shelf_SelectedValueChanged);
			// 
			// lbl_wp
			// 
			this.lbl_wp.Location = new System.Drawing.Point(248, 12);
			this.lbl_wp.Name = "lbl_wp";
			this.lbl_wp.Size = new System.Drawing.Size(80, 16);
			this.lbl_wp.TabIndex = 17;
			this.lbl_wp.Text = "Work Place";
			// 
			// cbo_area
			// 
			this.cbo_area.AddItemCols = 0;
			this.cbo_area.AddItemSeparator = ';';
			this.cbo_area.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_area.Caption = "";
			this.cbo_area.CaptionHeight = 17;
			this.cbo_area.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_area.ColumnCaptionHeight = 17;
			this.cbo_area.ColumnFooterHeight = 17;
			this.cbo_area.ContentHeight = 17;
			this.cbo_area.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_area.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_area.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_area.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_area.EditorHeight = 17;
			this.cbo_area.GapHeight = 2;
			this.cbo_area.ItemHeight = 15;
			this.cbo_area.Location = new System.Drawing.Point(472, 8);
			this.cbo_area.MatchEntryTimeout = ((long)(2000));
			this.cbo_area.MaxDropDownItems = ((short)(5));
			this.cbo_area.MaxLength = 32767;
			this.cbo_area.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_area.Name = "cbo_area";
			this.cbo_area.PartialRightColumn = false;
			this.cbo_area.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_area.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_area.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_area.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_area.Size = new System.Drawing.Size(112, 23);
			this.cbo_area.TabIndex = 16;
			this.cbo_area.SelectedValueChanged += new System.EventHandler(this.cbo_area_SelectedValueChanged);
			// 
			// cbo_wh
			// 
			this.cbo_wh.AddItemCols = 0;
			this.cbo_wh.AddItemSeparator = ';';
			this.cbo_wh.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_wh.Caption = "";
			this.cbo_wh.CaptionHeight = 17;
			this.cbo_wh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_wh.ColumnCaptionHeight = 17;
			this.cbo_wh.ColumnFooterHeight = 17;
			this.cbo_wh.ContentHeight = 17;
			this.cbo_wh.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_wh.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_wh.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_wh.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_wh.EditorHeight = 17;
			this.cbo_wh.GapHeight = 2;
			this.cbo_wh.ItemHeight = 15;
			this.cbo_wh.Location = new System.Drawing.Point(336, 8);
			this.cbo_wh.MatchEntryTimeout = ((long)(2000));
			this.cbo_wh.MaxDropDownItems = ((short)(5));
			this.cbo_wh.MaxLength = 32767;
			this.cbo_wh.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_wh.Name = "cbo_wh";
			this.cbo_wh.PartialRightColumn = false;
			this.cbo_wh.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_wh.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_wh.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_wh.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_wh.Size = new System.Drawing.Size(128, 23);
			this.cbo_wh.TabIndex = 4;
			this.cbo_wh.TextChanged += new System.EventHandler(this.cbo_wh_TextChanged);
			this.cbo_wh.SelectedValueChanged += new System.EventHandler(this.cbo_wh_SelectedValueChanged);
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
			this.cbo_factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_factory.EditorHeight = 17;
			this.cbo_factory.Enabled = false;
			this.cbo_factory.GapHeight = 2;
			this.cbo_factory.ItemHeight = 15;
			this.cbo_factory.Location = new System.Drawing.Point(96, 8);
			this.cbo_factory.MatchEntryTimeout = ((long)(2000));
			this.cbo_factory.MaxDropDownItems = ((short)(5));
			this.cbo_factory.MaxLength = 32767;
			this.cbo_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_factory.Name = "cbo_factory";
			this.cbo_factory.PartialRightColumn = false;
			this.cbo_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_factory.Size = new System.Drawing.Size(128, 23);
			this.cbo_factory.TabIndex = 3;
			// 
			// lbl_factory
			// 
			this.lbl_factory.Location = new System.Drawing.Point(8, 10);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(56, 16);
			this.lbl_factory.TabIndex = 0;
			this.lbl_factory.Text = "Factory";
			// 
			// btn_wh
			// 
			this.btn_wh.Location = new System.Drawing.Point(0, 0);
			this.btn_wh.Name = "btn_wh";
			this.btn_wh.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.TabIndex = 0;
			// 
			// btn_sf
			// 
			this.btn_sf.Location = new System.Drawing.Point(0, 0);
			this.btn_sf.Name = "btn_sf";
			this.btn_sf.TabIndex = 0;
			// 
			// Form_PB_Mold_Located_Report
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnel1);
			this.Controls.Add(this.fgrid_main);
			this.Name = "Form_PB_Mold_Located_Report";
			this.Text = "Form_Mold_Located_Report";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Located_Report_Load);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			this.Controls.SetChildIndex(this.pnel1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnel1.ResumeLayout(false);
			this.pnel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbo_mc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_sec)).EndInit();
			this.pnel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbo_rank)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_level)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_shelf)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_area)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Located_Report_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			FlexMold.ClassLib.ComVar.This_Win_ID = lbl_MainTitle.Text;
			FlexMold.ClassLib.ComVar.This_Computer = Environment.MachineName;

			tbtn_Save.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled = false;
			tbtn_New.Enabled = false;
			tbtn_Delete.Enabled = false;
		}
		private void Init_Form()
		{
			this.Text = "Mold Located Management Report";
			
			cbo_factory.Text = "VJ";
			this.lbl_MainTitle.Text = "Mold Located Management Report";
			ClassLib.ComFunction.SetLangDic(this);
		
			fgrid_main.Set_Grid("SDT_MOLD_LOCATE_REPORT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			//_RowFixed_desc = fgrip_main.Rows.Fixed;
			fgrid_main.ExtendLastCol = false;
			fgrid_main.AutoSizeCols();
 
//			DataTable dt_ret = Select_com_filter_code_List("SDV34");
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_Incom_type, 0, 1, false, false);

			DataTable dt_ret = Select_com_filter_code_List("SDV15");
//			dt_ret = Select_com_filter_code_List1("SDV15",ClassLib.ComVar.This_Dept);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List("SDV37");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_area, 0, 1, false, false);
			//cbo_area.SelectedIndex = 0;

			//Model_List();
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
		private DataTable Select_com_filter_code_List1(string com_cd,string dept_cd)
		{
			string Proc_Name = "PKG_SDT_MOLD_WH.select_com_filter_code_list";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_COM_CD";
			OraDB.Parameter_Name[2] = "ARG_DEPT_CD";
			OraDB.Parameter_Name[3] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = com_cd;
			OraDB.Parameter_Values[2] = dept_cd;
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		private void cbo_wh_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void cbo_wh_SelectedValueChanged(object sender, System.EventArgs e)
		{
			cbo_area.SelectedIndex = 0;
			init_cbo_rank();
		}	
		private void init_cbo_rank()
		{
			DataTable vDt1 = null;
						
			try
			{
				vDt1 = SELECT_WH_RANK_INFO();    
				ClassLib.ComCtl.Set_ComboList(vDt1, cbo_rank, 0, 1, false, false);
				
			}
			catch
			{

			}
		}
		private System.Data.DataTable SELECT_WH_RANK_INFO()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SEARCH_WH_RANK_INF";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WH_CD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString()  ;
			OraDB.Parameter_Values[0] = "VJ"  ;
			OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();
			OraDB.Parameter_Values[2] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}

		private void cbo_area_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if((cbo_area.SelectedValue.ToString()== "10")||(cbo_area.SelectedValue.ToString()== "80")||(cbo_area.SelectedValue.ToString()== "90"))
			{
				pnel2.Visible = true;
				pnel3.Visible = false;
				init_cbo_rank();
			}
			else
			{
				pnel3.Visible = true;
				pnel2.Visible = false;
				init_cbo_mc();
			}
		}
		private void init_cbo_mc()
		{
			DataTable vDt1 = null;
						
			try
			{
				vDt1 = SELECT_SF_MC_INFO();    
				
				ClassLib.ComCtl.Set_ComboList(vDt1, cbo_mc, 0, 1, false, false);
				
			}
			catch
			{

			}
		}
		private System.Data.DataTable SELECT_SF_MC_INFO()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SEARCH_SF_MC_INF";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WH_CD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString()  ;
			OraDB.Parameter_Values[0] = "VJ"  ;
			OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();
			OraDB.Parameter_Values[2] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}

		private void cbo_mc_SelectedValueChanged(object sender, System.EventArgs e)
		{
			init_cbo_sec();
		}
		private void init_cbo_sec()
		{
			DataTable vDt1 = null;
						
			try
			{
				vDt1 = SELECT_SF_SEC_INFO();    

				ClassLib.ComCtl.Set_ComboList(vDt1, cbo_sec, 0, 1, false, false);
				
			}
			catch
			{

			}
		}
		private System.Data.DataTable SELECT_SF_SEC_INFO()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SEARCH_SF_SEC_INF";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WH_CD";
			OraDB.Parameter_Name[2] = "ARG_MC_CD";
			OraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//	OraDB.Parameter_Values[0] = cbo_factory.Text.ToString()  ;
			OraDB.Parameter_Values[0] = "VJ"  ;
			OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();
			OraDB.Parameter_Values[2] = cbo_mc.SelectedValue.ToString();
			OraDB.Parameter_Values[3] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}

		private void cbo_rank_SelectedValueChanged(object sender, System.EventArgs e)
		{
			init_cbo_shelf();
		}
		private void init_cbo_shelf()
		{
			DataTable vDt1 = null;
			try
			{
				vDt1 = SELECT_WH_SHELF_INFO();    

				ClassLib.ComCtl.Set_ComboList(vDt1, cbo_shelf, 0, 1, false, false);
				
			}
			catch
			{

			}
		}
		private System.Data.DataTable SELECT_WH_SHELF_INFO()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SEARCH_WH_SHELF_INF";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WH_CD";
			OraDB.Parameter_Name[2] = "ARG_RANK_CD";
			OraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString()  ;
			OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();
			OraDB.Parameter_Values[2] = cbo_rank.SelectedValue.ToString();
			OraDB.Parameter_Values[3] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}

		private void cbo_shelf_SelectedValueChanged(object sender, System.EventArgs e)
		{
			init_cbo_level();
		}

		private void init_cbo_level()
		{
			DataTable vDt1 = null;
						
			try
			{
				vDt1 = SELECT_WH_LEVEL_INFO();    

				ClassLib.ComCtl.Set_ComboList(vDt1, cbo_level, 0, 1, false, false);
				
			}
			catch
			{

			}
		}
		private System.Data.DataTable SELECT_WH_LEVEL_INFO()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SEARCH_WH_LEVEL_INF";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WH_CD";
			OraDB.Parameter_Name[2] = "ARG_RANK_CD";
			OraDB.Parameter_Name[3] = "ARG_SHELF_CD";
			OraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString()  ;
			OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();
			OraDB.Parameter_Values[2] = cbo_rank.SelectedValue.ToString();
			OraDB.Parameter_Values[3] = cbo_shelf.SelectedValue.ToString();
			OraDB.Parameter_Values[4] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}

		private void pnel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_main.Clear();
			fgrid_main.Set_Grid("SDT_MOLD_LOCATE_REPORT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			Search_Main();
		}
		private void Search_Main()
		{
			DataTable vDt1 = null;						
			try
			{
				vDt1 = SELECT_MOLD_LOCATED_MAIN();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_main.AddItem(vDt1.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);
						fgrid_main.ExtendLastCol = false;
					}
					fgrid_main.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.RestrictCols;
//					fgrid_main.Cols[1].AllowMerging = true; // Merg ROUND 1, ROUND 2,..., ROUND N
					
				}
				else            
				{
					MessageBox.Show("No Data !!");
					return;
				}
				for(int i =2; i<fgrid_main.Rows.Count;i++)
					fgrid_main[i,0] = "  ";
			}
			catch
			{
			}
		}
		private System.Data.DataTable SELECT_MOLD_LOCATED_MAIN()
		{
			System.Data.DataSet retDS;                  
			OraDB.ReDim_Parameter(5); 

			//01.PROCEDURE¸i

			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SELECT_MOLD_LOCATE_REPORT";

			//02.ARGURMENT ¸i
			
			OraDB.Parameter_Name[0] = "ARG_DIV";
			OraDB.Parameter_Name[1] = "ARG_FACTORY";
			OraDB.Parameter_Name[2] = "ARG_WH";
			OraDB.Parameter_Name[3] = "ARG_LOCATED";

			OraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE A¤AC

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			if(cbo_area.SelectedValue.ToString() == "20")
				OraDB.Parameter_Values[0] = "1";
			else
				OraDB.Parameter_Values[0] = "2";
			OraDB.Parameter_Values[1] = cbo_factory.Text.ToString()  ;
			OraDB.Parameter_Values[2] = cbo_wh.SelectedValue.ToString();

			if(cbo_area.SelectedValue.ToString() == "20")
				OraDB.Parameter_Values[3] = cbo_mc.SelectedValue.ToString();
			else
				OraDB.Parameter_Values[3] = cbo_rank.SelectedValue.ToString();

			OraDB.Parameter_Values[4] = "" ;

			OraDB.Add_Select_Parameter(true);

			retDS = OraDB.Exe_Select_Procedure();

			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				//				if (ExistData)
				Print();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Print()
		{
			string name;
			string Def_Ret_YM = "";
			string Def_status ="";
			
			if(fgrid_main.Rows.Count < 2 ) return;
			//				fgrid_main.Rows.Remove(fgrid_main.Rows.Count-1);
//			this.Name = "Form_Mold_Repair_Report";
						
			string filename = this.Name + ".txt";
			FileInfo file  = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;
			
            //fgrid_main.SaveGrid(filename, FileFormatEnum.TextComma, false);
            fgrid_main.SaveGrid(filename, FileFormatEnum.TextComma);
			Def_Ret_YM = cbo_wh.Text.ToString();
			if(cbo_area.SelectedValue.ToString() == "20")
				Def_status = cbo_mc.SelectedValue.ToString();
			else
				Def_status = cbo_rank.SelectedValue.ToString();

			string para = "/rfn [" + Application.StartupPath + @"\" + this.Name + ".txt] /rv V_MTYPE[" +Def_Ret_YM
				+ "] V_MSTATUS[" + Def_status + "]";
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report("Status Mold", this.Name +".mrd", para);
			report.ShowDialog();
		}

	
		

	}
}

