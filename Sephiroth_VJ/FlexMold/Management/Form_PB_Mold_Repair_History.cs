using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;
using System.Threading;
using System.Data.OleDb;


namespace FlexMold.Management
{
	public class Form_PB_Mold_Repair_History : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo CboMold_CD;
		private System.Windows.Forms.DateTimePicker dtp_In;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cbo_wh;
		private System.Windows.Forms.Label label12;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label label1;
		public COM.FSP fgrid_Search;
		public COM.FSP fgrid_Detail;
		private System.ComponentModel.IContainer components = null;

		private COM.OraDB OraDB = new COM.OraDB();
		private System.Windows.Forms.Panel panel2;
		private System.Data.DataTable dt_list;

		public Form_PB_Mold_Repair_History()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Repair_History));
			this.panel1 = new System.Windows.Forms.Panel();
			this.CboMold_CD = new C1.Win.C1List.C1Combo();
			this.dtp_In = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbo_wh = new C1.Win.C1List.C1Combo();
			this.label12 = new System.Windows.Forms.Label();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.fgrid_Search = new COM.FSP();
			this.fgrid_Detail = new COM.FSP();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CboMold_CD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Search)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Detail)).BeginInit();
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
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.CboMold_CD);
			this.panel1.Controls.Add(this.dtp_In);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbo_wh);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.cbo_factory);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 72);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 40);
			this.panel1.TabIndex = 31;
			// 
			// CboMold_CD
			// 
			this.CboMold_CD.AddItemCols = 0;
			this.CboMold_CD.AddItemSeparator = ';';
			this.CboMold_CD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.CboMold_CD.Caption = "";
			this.CboMold_CD.CaptionHeight = 17;
			this.CboMold_CD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.CboMold_CD.ColumnCaptionHeight = 17;
			this.CboMold_CD.ColumnFooterHeight = 17;
			this.CboMold_CD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.CboMold_CD.ContentHeight = 17;
			this.CboMold_CD.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.CboMold_CD.EditorBackColor = System.Drawing.SystemColors.Window;
			this.CboMold_CD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.CboMold_CD.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.CboMold_CD.EditorHeight = 17;
			this.CboMold_CD.GapHeight = 2;
			this.CboMold_CD.ItemHeight = 15;
			this.CboMold_CD.Location = new System.Drawing.Point(776, 8);
			this.CboMold_CD.MatchEntryTimeout = ((long)(2000));
			this.CboMold_CD.MaxDropDownItems = ((short)(5));
			this.CboMold_CD.MaxLength = 32767;
			this.CboMold_CD.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.CboMold_CD.Name = "CboMold_CD";
			this.CboMold_CD.PartialRightColumn = false;
			this.CboMold_CD.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.CboMold_CD.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.CboMold_CD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.CboMold_CD.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.CboMold_CD.Size = new System.Drawing.Size(232, 23);
			this.CboMold_CD.TabIndex = 75;
			this.CboMold_CD.SelectedValueChanged += new System.EventHandler(this.CboMold_CD_SelectedValueChanged);
			// 
			// dtp_In
			// 
			this.dtp_In.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_In.Location = new System.Drawing.Point(344, 8);
			this.dtp_In.Name = "dtp_In";
			this.dtp_In.Size = new System.Drawing.Size(112, 22);
			this.dtp_In.TabIndex = 73;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(280, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 21);
			this.label5.TabIndex = 72;
			this.label5.Text = "Date";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(696, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 24);
			this.label2.TabIndex = 64;
			this.label2.Text = "Mold Code";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cbo_wh.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_wh.ContentHeight = 17;
			this.cbo_wh.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_wh.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_wh.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_wh.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_wh.EditorHeight = 17;
			this.cbo_wh.GapHeight = 2;
			this.cbo_wh.ItemHeight = 15;
			this.cbo_wh.Location = new System.Drawing.Point(552, 8);
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
			this.cbo_wh.Size = new System.Drawing.Size(136, 23);
			this.cbo_wh.TabIndex = 63;
			this.cbo_wh.SelectedValueChanged += new System.EventHandler(this.cbo_wh_SelectedValueChanged);
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(464, 9);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(96, 18);
			this.label12.TabIndex = 62;
			this.label12.Text = "Warehouse";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cbo_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_factory.ContentHeight = 17;
			this.cbo_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_factory.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cbo_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_factory.EditorHeight = 17;
			this.cbo_factory.Enabled = false;
			this.cbo_factory.GapHeight = 2;
			this.cbo_factory.ItemHeight = 15;
			this.cbo_factory.Location = new System.Drawing.Point(80, 8);
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
			this.cbo_factory.Size = new System.Drawing.Size(184, 23);
			this.cbo_factory.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(15, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Factory";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fgrid_Search
			// 
			this.fgrid_Search.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.fgrid_Search.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromCursor;
			this.fgrid_Search.BackColor = System.Drawing.Color.Transparent;
			this.fgrid_Search.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Search.ColumnInfo = "5,1,0,0,0,95,Columns:0{Width:29;}\t";
			this.fgrid_Search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Search.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Search.Location = new System.Drawing.Point(0, 112);
			this.fgrid_Search.Name = "fgrid_Search";
			this.fgrid_Search.Rows.Count = 2;
			this.fgrid_Search.Size = new System.Drawing.Size(512, 528);
			this.fgrid_Search.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:Transparent;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{Font:Verdana, 9pt, style=Bold;BackColor:128, 255, 255;ForeColor:Red;}	Subtotal0{BackColor:MistyRose;ForeColor:Blue;Border:Flat,1,255, 224, 192,Both;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Search.TabIndex = 53;
			this.fgrid_Search.Click += new System.EventHandler(this.fgrid_Search_Click);
			// 
			// fgrid_Detail
			// 
			this.fgrid_Detail.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_Detail.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Detail.BackColor = System.Drawing.Color.Transparent;
			this.fgrid_Detail.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Detail.ColumnInfo = "100,1,0,0,0,95,Columns:0{Width:50;TextAlign:CenterCenter;TextAlignFixed:CenterCen" +
				"ter;ImageAlign:CenterCenter;}\t";
			this.fgrid_Detail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Detail.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Detail.Location = new System.Drawing.Point(552, 112);
			this.fgrid_Detail.Name = "fgrid_Detail";
			this.fgrid_Detail.Rows.Count = 2;
			this.fgrid_Detail.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			this.fgrid_Detail.Size = new System.Drawing.Size(464, 528);
			this.fgrid_Detail.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:Transparent;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Detail.TabIndex = 54;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.panel2.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.panel2.Location = new System.Drawing.Point(512, 112);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(40, 528);
			this.panel2.TabIndex = 55;
			// 
			// Form_PB_Mold_Repair_History
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.fgrid_Detail);
			this.Controls.Add(this.fgrid_Search);
			this.Controls.Add(this.panel1);
			this.Name = "Form_PB_Mold_Repair_History";
			this.Text = "Mold_Repair_History";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Repair_History_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.fgrid_Search, 0);
			this.Controls.SetChildIndex(this.fgrid_Detail, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CboMold_CD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Search)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Detail)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Repair_History_Load(object sender, System.EventArgs e)
		{
			Init_Form();		
			this.tbtn_New.Enabled = false;
			this.tbtn_Save.Enabled = false;
			this.tbtn_Append.Enabled = false;
			this.tbtn_Color.Enabled = false;
			this.tbtn_Delete.Enabled = false;
			this.tbtn_Insert.Enabled = false;
		}
		
		private void Init_Form()	
		{
			this.lbl_MainTitle.Text = "Mold Repair History";
			ClassLib.ComFunction.SetLangDic(this);

			fgrid_Detail.Set_Grid("SDT_MOLD_HIS_DETAIL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Detail.Set_Action_Image(img_Action);
			fgrid_Detail.ExtendLastCol = false;

			DataTable dt_ret = Select_com_filter_code_List("SBC21");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_factory, 0, 1, false, false);
			cbo_factory.SelectedValue = "VJ";			

//			dt_ret = Select_com_filter_code_List1("SDV15",ClassLib.ComVar.This_Dept);
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

			// set up GrandTotal
			fgrid_Detail.Tree.Column = 1;
			CellStyle s = fgrid_Detail.Styles[CellStyleEnum.GrandTotal];
			s.BackColor = Color.YellowGreen;
			s.ForeColor = Color.White;
			s.Font = new Font(fgrid_Detail.Font, FontStyle.Bold);
//
//			fgrid_main.Rows[1].AllowMerging = true;
//			fgrid_main.Cols[1].AllowMerging = true; 
//			fgrid_main.Cols[2].AllowMerging = true; 
//			fgrid_main.Cols[3].AllowMerging = true; 
//			fgrid_main.Cols[4].AllowMerging = true; 
//
			fgrid_Search.Set_Grid("SDT_MOLD_HIS", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Search.Set_Action_Image(img_Action);
			fgrid_Search.ExtendLastCol = false;
//			
//			fgrid_Search.Tree.Column = 1;
//			CellStyle s1 = fgrid_Search.Styles[CellStyleEnum.Subtotal0];
//			s1.BackColor = Color.YellowGreen;
//			s1.ForeColor = Color.White;
//			s1.Font = new Font(fgrid_Search.Font, FontStyle.Bold);

			dt_ret = Select_com_filter_code_List("SDV15");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

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

		private void cbo_wh_SelectedValueChanged(object sender, System.EventArgs e)
		{
			dt_list = Select_Mold();
			COM.ComCtl.Set_ComboList(dt_list, CboMold_CD, 0, 1, true);  			
			CboMold_CD.SelectedIndex = 0;
		}

		private System.Data.DataTable Select_Mold()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SELECT_MOLD_CD";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WH_CD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();
			
			OraDB.Parameter_Values[2] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

		private void CboMold_CD_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if( (CboMold_CD.Text.ToString() != "ALL")||(CboMold_CD.Text.Trim() !=""))
			{
				Search_Mold_His();	
				fgrid_Detail.Clear();
				fgrid_Detail.Set_Grid("SDT_MOLD_HIS_DETAIL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			}
		}
		private void Search_Mold_His()
		{
			//			FlexMold.ClassLib.ComVar.vDt1 = null;

			System.Data.DataTable vDt1 = null;
			fgrid_Search.Clear();
			fgrid_Search.Set_Grid("SDT_MOLD_HIS", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			try
			{
				vDt1 = SELECT_HIS();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_Search.AddItem( vDt1.Rows[i].ItemArray, fgrid_Search.Rows.Count, 1);
						
					}
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

		private System.Data.DataTable SELECT_HIS()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_HIS";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_DEF_YMD";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			OraDB.Parameter_Name[3] = "ARG_WH_CD";
			OraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.SelectedValue.ToString();
			OraDB.Parameter_Values[1] = dtp_In.Text.ToString().Replace("/","").Replace("-","");
			OraDB.Parameter_Values[2] = CboMold_CD.SelectedValue.ToString();
			OraDB.Parameter_Values[3] = cbo_wh.SelectedValue.ToString();

			OraDB.Parameter_Values[4] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}

		private void fgrid_Search_Click(object sender, System.EventArgs e)
		{
			Search_His_Detail();
		}
		private void Search_His_Detail()
		{
			System.Data.DataTable vDt1 = null;
			fgrid_Detail.Clear();
			fgrid_Detail.Set_Grid("SDT_MOLD_HIS_DETAIL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			try
			{
				vDt1 = SELECT_REPAIR_HIS_DETAIL();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_Detail.AddItem( vDt1.Rows[i].ItemArray, fgrid_Detail.Rows.Count, 1);
						
					}
					SubTotalGrid();
				}
				else
				{
//					MessageBox.Show("No Data !!");
//					return;
				}
			}
			catch
			{

			}
		}
		private System.Data.DataTable SELECT_REPAIR_HIS_DETAIL()
		{
			System.Data.DataSet retDS;                  

			OraDB.ReDim_Parameter(6); 

			//01.PROCEDURE¸i

			OraDB.Process_Name  = "PKG_SDT_MOLD.SELECT_HIS_DETAIL";

			//02.ARGURMENT ¸i
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WH_CD";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			OraDB.Parameter_Name[3] = "ARG_USE_SIZE";
			OraDB.Parameter_Name[4] = "ARG_SEQ_NO";

			OraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE A¤AC
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;

			OraDB.Parameter_Type[5] = (int)OracleType.Cursor;

 
			OraDB.Parameter_Values[0] = "VJ" ;
			OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();
			OraDB.Parameter_Values[2] = CboMold_CD.SelectedValue.ToString().Trim();
			OraDB.Parameter_Values[3] = fgrid_Search[fgrid_Search.RowSel,3].ToString();
			OraDB.Parameter_Values[4] = fgrid_Search[fgrid_Search.RowSel,4].ToString();
			OraDB.Parameter_Values[5] = "";

			OraDB.Add_Select_Parameter(true);

			retDS = OraDB.Exe_Select_Procedure();

			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}
		private void SubTotalGrid()
		{
			fgrid_Detail.Subtotal(AggregateEnum.Clear);
			fgrid_Detail.SubtotalPosition = SubtotalPositionEnum.BelowData;
			fgrid_Detail.Subtotal(AggregateEnum.Sum, -1,-1, 4, "GTotal");
//			fgrid_Detail.Subtotal(AggregateEnum.Sum, 0, 2, 3, "STotal");			 
		}

	}
}

