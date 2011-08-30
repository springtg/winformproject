using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexMold.Management
{
	public class Form_PB_Mold_Repair_Search : COM.MoldWinForm.Form_Top
	{
		private C1.Win.C1List.C1Combo cbo_wh;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Panel pnel1;
		private System.Windows.Forms.Label lbl_wp;
		private System.Windows.Forms.TextBox txt_moldcode;
		private System.Windows.Forms.Label lbl_moldcode;
		public COM.FSP fgrid_mold;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cbo_Status;
		private System.Windows.Forms.Label label1;

		private COM.OraDB OraDB = new COM.OraDB();

		public Form_PB_Mold_Repair_Search()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Repair_Search));
			this.cbo_wh = new C1.Win.C1List.C1Combo();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pnel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.cbo_Status = new C1.Win.C1List.C1Combo();
			this.lbl_wp = new System.Windows.Forms.Label();
			this.txt_moldcode = new System.Windows.Forms.TextBox();
			this.lbl_moldcode = new System.Windows.Forms.Label();
			this.fgrid_mold = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
			this.pnel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Status)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_mold)).BeginInit();
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
			this.lbl_MainTitle.Size = new System.Drawing.Size(408, 23);
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
			this.cbo_wh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_wh.GapHeight = 2;
			this.cbo_wh.ItemHeight = 15;
			this.cbo_wh.Location = new System.Drawing.Point(304, 8);
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
			this.cbo_wh.Size = new System.Drawing.Size(144, 23);
			this.cbo_wh.TabIndex = 4;
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
			this.cbo_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.cbo_factory.Size = new System.Drawing.Size(88, 23);
			this.cbo_factory.TabIndex = 3;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.Transparent;
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ForeColor = System.Drawing.Color.Blue;
			this.lbl_factory.Location = new System.Drawing.Point(8, 13);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(56, 16);
			this.lbl_factory.TabIndex = 0;
			this.lbl_factory.Text = "Factory";
			// 
			// pnel1
			// 
			this.pnel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnel1.BackColor = System.Drawing.Color.Transparent;
			this.pnel1.Controls.Add(this.label1);
			this.pnel1.Controls.Add(this.cbo_Status);
			this.pnel1.Controls.Add(this.lbl_wp);
			this.pnel1.Controls.Add(this.txt_moldcode);
			this.pnel1.Controls.Add(this.lbl_moldcode);
			this.pnel1.Controls.Add(this.cbo_wh);
			this.pnel1.Controls.Add(this.cbo_factory);
			this.pnel1.Controls.Add(this.lbl_factory);
			this.pnel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnel1.Location = new System.Drawing.Point(0, 64);
			this.pnel1.Name = "pnel1";
			this.pnel1.Size = new System.Drawing.Size(1008, 40);
			this.pnel1.TabIndex = 30;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(680, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "Status";
			// 
			// cbo_Status
			// 
			this.cbo_Status.AddItemCols = 0;
			this.cbo_Status.AddItemSeparator = ';';
			this.cbo_Status.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_Status.Caption = "";
			this.cbo_Status.CaptionHeight = 17;
			this.cbo_Status.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_Status.ColumnCaptionHeight = 17;
			this.cbo_Status.ColumnFooterHeight = 17;
			this.cbo_Status.ContentHeight = 17;
			this.cbo_Status.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_Status.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_Status.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_Status.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_Status.EditorHeight = 17;
			this.cbo_Status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_Status.GapHeight = 2;
			this.cbo_Status.ItemHeight = 15;
			this.cbo_Status.Location = new System.Drawing.Point(744, 8);
			this.cbo_Status.MatchEntryTimeout = ((long)(2000));
			this.cbo_Status.MaxDropDownItems = ((short)(5));
			this.cbo_Status.MaxLength = 32767;
			this.cbo_Status.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_Status.Name = "cbo_Status";
			this.cbo_Status.PartialRightColumn = false;
			this.cbo_Status.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_Status.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_Status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_Status.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_Status.Size = new System.Drawing.Size(112, 23);
			this.cbo_Status.TabIndex = 18;
			// 
			// lbl_wp
			// 
			this.lbl_wp.BackColor = System.Drawing.Color.Transparent;
			this.lbl_wp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_wp.ForeColor = System.Drawing.Color.Blue;
			this.lbl_wp.Location = new System.Drawing.Point(216, 11);
			this.lbl_wp.Name = "lbl_wp";
			this.lbl_wp.Size = new System.Drawing.Size(88, 16);
			this.lbl_wp.TabIndex = 17;
			this.lbl_wp.Text = "Work Place";
			// 
			// txt_moldcode
			// 
			this.txt_moldcode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_moldcode.Location = new System.Drawing.Point(544, 8);
			this.txt_moldcode.Name = "txt_moldcode";
			this.txt_moldcode.Size = new System.Drawing.Size(104, 22);
			this.txt_moldcode.TabIndex = 7;
			this.txt_moldcode.Text = "";
			// 
			// lbl_moldcode
			// 
			this.lbl_moldcode.BackColor = System.Drawing.Color.Transparent;
			this.lbl_moldcode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_moldcode.ForeColor = System.Drawing.Color.Blue;
			this.lbl_moldcode.Location = new System.Drawing.Point(456, 11);
			this.lbl_moldcode.Name = "lbl_moldcode";
			this.lbl_moldcode.Size = new System.Drawing.Size(85, 16);
			this.lbl_moldcode.TabIndex = 6;
			this.lbl_moldcode.Text = "Mold Code:";
			// 
			// fgrid_mold
			// 
			this.fgrid_mold.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_mold.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_mold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_mold.BackColor = System.Drawing.Color.Transparent;
			this.fgrid_mold.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_mold.ColumnInfo = "17,1,0,0,0,75,Columns:";
			this.fgrid_mold.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_mold.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_mold.Location = new System.Drawing.Point(0, 105);
			this.fgrid_mold.Name = "fgrid_mold";
			this.fgrid_mold.Rows.Count = 2;
			this.fgrid_mold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_mold.Size = new System.Drawing.Size(1008, 528);
			this.fgrid_mold.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;BackColor:Transparent;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_mold.TabIndex = 52;
			// 
			// Form_PB_Mold_Repair_Search
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_mold);
			this.Controls.Add(this.pnel1);
			this.Name = "Form_PB_Mold_Repair_Search";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Repair_Search_Load);
			this.Controls.SetChildIndex(this.pnel1, 0);
			this.Controls.SetChildIndex(this.fgrid_mold, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			this.pnel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbo_Status)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_mold)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Repair_Search_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		private void Init_Form()
		{
			cbo_factory.Text = "VJ";
			this.lbl_MainTitle.Text = "Mold Repairing Management By Warehouse";
			ClassLib.ComFunction.SetLangDic(this);
			
			//fgrid_mold.Set_Grid("SDT_MOLD_MASTER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
//			fgrid_mold.Set_Grid("SDT_MOLD_LOCATE_MANAGER1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
//			fgrid_mold.Set_Action_Image(img_Action);
//			//_RowFixed_desc = fgrip_main.Rows.Fixed;fgrid_moldrepair
//			fgrid_mold.ExtendLastCol = false;
//			fgrid_mold.AutoSizeCols();

			fgrid_mold.Set_Grid("SDT_MOLD_REPAIR_WH", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_mold.Set_Action_Image(img_Action);
			fgrid_mold.ExtendLastCol = false;
			fgrid_mold.AutoSizeCols();

//			fgrid_err.Set_Grid("SDT_MOLD_BASIC_ERROR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
//			fgrid_err.Set_Action_Image(img_Action);
//			//_RowFixed_desc = fgrip_main.Rows.Fixed;fgrid_moldrepair
//			fgrid_err.ExtendLastCol = false;
//			fgrid_err.AutoSizeCols();
 
			DataTable dt_ret = Select_com_filter_code_List("SDV15");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List("SDV39");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_Status, 0, 1, false, false);
//
//			dt_ret = Select_com_filter_code_List("SDV40");
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_repairarea1, 0, 1, false, false);
//			cmb_repairarea.SelectedIndex = 1;
			
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
			fgrid_mold.Clear();
			fgrid_mold.Set_Grid("SDT_MOLD_REPAIR_WH", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			Search_Main();
		}

		private void Search_Main()
		{
			DataTable vDt1 = null;
			try
			{
				vDt1 = SELECT_MOLD_MAIN();    
				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_mold.AddItem(vDt1.Rows[i].ItemArray, fgrid_mold.Rows.Count, 1);
						fgrid_mold.ExtendLastCol = false;
						fgrid_mold.AutoSizeCols();
					}
				}
				else            
				{
					MessageBox.Show("No Data !!");
					return;
				}
				for(int i =2; i<fgrid_mold.Rows.Count;i++)
					fgrid_mold[i,0] = "  ";
			}
			catch
			{
			}
		}

		private System.Data.DataTable SELECT_MOLD_MAIN()
		{
			System.Data.DataSet retDS;                  
			OraDB.ReDim_Parameter(5); 
			//01.PROCEDURE¢¬i
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_MOLD_REPAIR_BY_WH";

			//02.ARGURMENT ¢¬i
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WH";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			OraDB.Parameter_Name[3] = "ARG_STATUS";
			OraDB.Parameter_Name[4] = "OUT_CURSOR";
			//03.DATA TYPE A¢´AC
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString()  ;
			if (cbo_wh.Text == "")
				OraDB.Parameter_Values[1] = "";
			else
				OraDB.Parameter_Values[1] = cbo_wh.SelectedValue.ToString();
			if (txt_moldcode.Text == "")
				OraDB.Parameter_Values[2] = "";
			else
				OraDB.Parameter_Values[2] = txt_moldcode.Text.Trim().ToString();
			if (cbo_Status.Text == "")
				OraDB.Parameter_Values[3] = "";
			else
				OraDB.Parameter_Values[3] = cbo_Status.SelectedValue.ToString();
			OraDB.Parameter_Values[4] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();

			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

	}
}

