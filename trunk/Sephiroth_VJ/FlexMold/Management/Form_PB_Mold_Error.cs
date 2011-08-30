using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using C1.Win.C1FlexGrid;

namespace FlexMold.Management
{
	public class Form_PB_Mold_Error : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dtpdate_to;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl15;
		private C1.Win.C1List.C1Combo cmb_repairarea1;
		private System.Windows.Forms.Label lbl_repairarea;
		private System.Windows.Forms.DateTimePicker cmb_workday;
		private System.Windows.Forms.Label lbl_work_ymd;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cbo_parttype;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo Cbo_Error;
		private System.ComponentModel.IContainer components = null;

		private COM.OraDB OraDB = new COM.OraDB();
		public COM.FSP fgrid_main;
		private System.Data.DataTable dt_list;

		public Form_PB_Mold_Error()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Error));
			this.panel1 = new System.Windows.Forms.Panel();
			this.Cbo_Error = new C1.Win.C1List.C1Combo();
			this.label2 = new System.Windows.Forms.Label();
			this.cbo_parttype = new C1.Win.C1List.C1Combo();
			this.dtpdate_to = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl15 = new System.Windows.Forms.Label();
			this.cmb_repairarea1 = new C1.Win.C1List.C1Combo();
			this.lbl_repairarea = new System.Windows.Forms.Label();
			this.cmb_workday = new System.Windows.Forms.DateTimePicker();
			this.lbl_work_ymd = new System.Windows.Forms.Label();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.fgrid_main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Cbo_Error)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_parttype)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_repairarea1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
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
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.Cbo_Error);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbo_parttype);
			this.panel1.Controls.Add(this.dtpdate_to);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lbl15);
			this.panel1.Controls.Add(this.cmb_repairarea1);
			this.panel1.Controls.Add(this.lbl_repairarea);
			this.panel1.Controls.Add(this.cmb_workday);
			this.panel1.Controls.Add(this.lbl_work_ymd);
			this.panel1.Controls.Add(this.cbo_factory);
			this.panel1.Controls.Add(this.lbl_factory);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 72);
			this.panel1.TabIndex = 30;
			// 
			// Cbo_Error
			// 
			this.Cbo_Error.AddItemCols = 0;
			this.Cbo_Error.AddItemSeparator = ';';
			this.Cbo_Error.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.Cbo_Error.Caption = "";
			this.Cbo_Error.CaptionHeight = 17;
			this.Cbo_Error.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.Cbo_Error.ColumnCaptionHeight = 17;
			this.Cbo_Error.ColumnFooterHeight = 17;
			this.Cbo_Error.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.Cbo_Error.ContentHeight = 17;
			this.Cbo_Error.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.Cbo_Error.EditorBackColor = System.Drawing.SystemColors.Window;
			this.Cbo_Error.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Cbo_Error.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.Cbo_Error.EditorHeight = 17;
			this.Cbo_Error.GapHeight = 2;
			this.Cbo_Error.ItemHeight = 15;
			this.Cbo_Error.Location = new System.Drawing.Point(344, 40);
			this.Cbo_Error.MatchEntryTimeout = ((long)(2000));
			this.Cbo_Error.MaxDropDownItems = ((short)(5));
			this.Cbo_Error.MaxLength = 32767;
			this.Cbo_Error.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.Cbo_Error.Name = "Cbo_Error";
			this.Cbo_Error.PartialRightColumn = false;
			this.Cbo_Error.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.Cbo_Error.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.Cbo_Error.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.Cbo_Error.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.Cbo_Error.Size = new System.Drawing.Size(168, 23);
			this.Cbo_Error.TabIndex = 35;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(248, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 34;
			this.label2.Text = "Error Name";
			// 
			// cbo_parttype
			// 
			this.cbo_parttype.AddItemCols = 0;
			this.cbo_parttype.AddItemSeparator = ';';
			this.cbo_parttype.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_parttype.Caption = "";
			this.cbo_parttype.CaptionHeight = 17;
			this.cbo_parttype.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_parttype.ColumnCaptionHeight = 17;
			this.cbo_parttype.ColumnFooterHeight = 17;
			this.cbo_parttype.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_parttype.ContentHeight = 17;
			this.cbo_parttype.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_parttype.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_parttype.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_parttype.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_parttype.EditorHeight = 17;
			this.cbo_parttype.GapHeight = 2;
			this.cbo_parttype.ItemHeight = 15;
			this.cbo_parttype.Location = new System.Drawing.Point(88, 40);
			this.cbo_parttype.MatchEntryTimeout = ((long)(2000));
			this.cbo_parttype.MaxDropDownItems = ((short)(5));
			this.cbo_parttype.MaxLength = 32767;
			this.cbo_parttype.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_parttype.Name = "cbo_parttype";
			this.cbo_parttype.PartialRightColumn = false;
			this.cbo_parttype.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_parttype.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_parttype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_parttype.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_parttype.Size = new System.Drawing.Size(144, 23);
			this.cbo_parttype.TabIndex = 33;
			this.cbo_parttype.SelectedValueChanged += new System.EventHandler(this.cbo_parttype_SelectedValueChanged);
			// 
			// dtpdate_to
			// 
			this.dtpdate_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpdate_to.Location = new System.Drawing.Point(392, 9);
			this.dtpdate_to.Name = "dtpdate_to";
			this.dtpdate_to.Size = new System.Drawing.Size(120, 22);
			this.dtpdate_to.TabIndex = 32;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(354, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 26);
			this.label1.TabIndex = 31;
			this.label1.Text = "~";
			// 
			// lbl15
			// 
			this.lbl15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl15.ForeColor = System.Drawing.Color.Blue;
			this.lbl15.Location = new System.Drawing.Point(8, 41);
			this.lbl15.Name = "lbl15";
			this.lbl15.Size = new System.Drawing.Size(80, 24);
			this.lbl15.TabIndex = 29;
			this.lbl15.Text = "Part Type";
			// 
			// cmb_repairarea1
			// 
			this.cmb_repairarea1.AddItemCols = 0;
			this.cmb_repairarea1.AddItemSeparator = ';';
			this.cmb_repairarea1.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_repairarea1.Caption = "";
			this.cmb_repairarea1.CaptionHeight = 17;
			this.cmb_repairarea1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_repairarea1.ColumnCaptionHeight = 17;
			this.cmb_repairarea1.ColumnFooterHeight = 17;
			this.cmb_repairarea1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_repairarea1.ContentHeight = 17;
			this.cmb_repairarea1.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_repairarea1.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_repairarea1.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_repairarea1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_repairarea1.EditorHeight = 17;
			this.cmb_repairarea1.GapHeight = 2;
			this.cmb_repairarea1.ItemHeight = 15;
			this.cmb_repairarea1.Location = new System.Drawing.Point(648, 40);
			this.cmb_repairarea1.MatchEntryTimeout = ((long)(2000));
			this.cmb_repairarea1.MaxDropDownItems = ((short)(5));
			this.cmb_repairarea1.MaxLength = 32767;
			this.cmb_repairarea1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_repairarea1.Name = "cmb_repairarea1";
			this.cmb_repairarea1.PartialRightColumn = false;
			this.cmb_repairarea1.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_repairarea1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_repairarea1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_repairarea1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_repairarea1.Size = new System.Drawing.Size(187, 23);
			this.cmb_repairarea1.TabIndex = 26;
			// 
			// lbl_repairarea
			// 
			this.lbl_repairarea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_repairarea.ForeColor = System.Drawing.Color.Blue;
			this.lbl_repairarea.Location = new System.Drawing.Point(532, 45);
			this.lbl_repairarea.Name = "lbl_repairarea";
			this.lbl_repairarea.Size = new System.Drawing.Size(108, 16);
			this.lbl_repairarea.TabIndex = 25;
			this.lbl_repairarea.Text = "Repairing Area";
			// 
			// cmb_workday
			// 
			this.cmb_workday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.cmb_workday.Location = new System.Drawing.Point(232, 9);
			this.cmb_workday.Name = "cmb_workday";
			this.cmb_workday.Size = new System.Drawing.Size(112, 22);
			this.cmb_workday.TabIndex = 23;
			// 
			// lbl_work_ymd
			// 
			this.lbl_work_ymd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_work_ymd.ForeColor = System.Drawing.Color.Blue;
			this.lbl_work_ymd.Location = new System.Drawing.Point(168, 12);
			this.lbl_work_ymd.Name = "lbl_work_ymd";
			this.lbl_work_ymd.Size = new System.Drawing.Size(49, 20);
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
			this.cbo_factory.Location = new System.Drawing.Point(88, 10);
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
			this.cbo_factory.Size = new System.Drawing.Size(64, 23);
			this.cbo_factory.TabIndex = 21;
			// 
			// lbl_factory
			// 
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ForeColor = System.Drawing.Color.Blue;
			this.lbl_factory.Location = new System.Drawing.Point(8, 12);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(72, 20);
			this.lbl_factory.TabIndex = 20;
			this.lbl_factory.Text = "Factory";
			// 
			// fgrid_main
			// 
			this.fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_main.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromCursor;
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main.ColumnInfo = "9,1,0,0,0,95,Columns:0{Width:29;}\t";
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 136);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 2;
			this.fgrid_main.Size = new System.Drawing.Size(1016, 504);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{Font:Verdana, 9pt, style=Bold;BackColor:128, 255, 255;ForeColor:Red;}	Subtotal0{BackColor:MistyRose;ForeColor:Blue;Border:Flat,1,255, 224, 192,Both;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 53;
			// 
			// Form_PB_Mold_Error
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_main);
			this.Controls.Add(this.panel1);
			this.Name = "Form_PB_Mold_Error";
			this.Text = "Form_PB_Mold_Error";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Error_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Cbo_Error)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_parttype)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_repairarea1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Error_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			DateTime Month = DateTime.Parse(cmb_workday.Text);
			//			Ngay Dau cua thang
			DateTime firstDayOfMonth = new DateTime(Month.Year, Month.Month, 1);
			cmb_workday.Value = firstDayOfMonth;
			//			Ngay cuoi cua thang
//			DateTime lastDayOfMonth = new DateTime(Month.Year, Month.Month, -1);
//			dtpdate_to.Value = lastDayOfMonth;
			this.tbtn_New.Enabled = false;
			this.tbtn_Save.Enabled = false;
			this.tbtn_Append.Enabled = false;
			this.tbtn_Color.Enabled = false;
			this.tbtn_Delete.Enabled = false;
			this.tbtn_Insert.Enabled = false;
		}
		private void Init_Form()
		{
			cbo_factory.Text = "VJ";
			this.lbl_MainTitle.Text = "Mold Repair && Coating Error Report";
			ClassLib.ComFunction.SetLangDic(this);

			fgrid_main.Set_Grid("SDT_MOLD_ERROR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.ExtendLastCol = false;
			
			DataTable dt_ret = Select_com_filter_code_List("SDV40");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_repairarea1, 0, 1, false, false);
			cmb_repairarea1.SelectedIndex = 0;

			dt_ret = Select_com_filter_code_List("MD03");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_parttype, 0, 1, false, false);
			
			fgrid_main.Tree.Column = 1;
			CellStyle s = fgrid_main.Styles[CellStyleEnum.Subtotal0];
			s.BackColor = Color.YellowGreen;
			s.ForeColor = Color.White;
			s.Font = new Font(fgrid_main.Font, FontStyle.Bold);

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
		public System.Data.DataTable SELECT_ERROR()
		{
			//			DataTable dt;
			System.Data.DataSet retDS;

			OraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SELECT_ERR_NAME";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FAC";
			OraDB.Parameter_Name[1] = "ARG_PART_CD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = cbo_parttype.SelectedValue.ToString();
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

		private void cbo_parttype_SelectedValueChanged(object sender, System.EventArgs e)
		{
			dt_list = SELECT_ERROR();
			COM.ComCtl.Set_ComboList(dt_list, Cbo_Error, 0, 1, true);  			
			Cbo_Error.SelectedIndex = 0;
		}
		private void SubTotalGrid()
		{
			fgrid_main.Subtotal(AggregateEnum.Clear);
			fgrid_main.SubtotalPosition = SubtotalPositionEnum.BelowData;
			fgrid_main.Subtotal(AggregateEnum.Sum, -1,-1, 9, "GTotal");

			if ((Cbo_Error.Text.Trim() == "ALL")||(Cbo_Error.Text.Trim() == null))
				fgrid_main.Subtotal(AggregateEnum.Sum, 0,2, 9, "STotal");			 

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Search();
		}
		private void Search()
		{
			System.Data.DataTable vDt1 = null;
			fgrid_main.Clear();
			fgrid_main.Set_Grid("SDT_MOLD_ERROR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			try
			{
				vDt1 = SELECT_ERR();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_main.AddItem( vDt1.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);						
					}
					SubTotalGrid();
					fgrid_main.AutoSizeCols();
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
		private System.Data.DataTable SELECT_ERR()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SEARCH_MOLD_ERR";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_FROM_YMD";
			OraDB.Parameter_Name[2] = "ARG_TO_YMD";
			OraDB.Parameter_Name[3] = "ARG_PART_CD";
			OraDB.Parameter_Name[4] = "ARG_ERR_CD";
			OraDB.Parameter_Name[5] = "ARG_REPAIR_AREA";
			OraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = cbo_factory.Text.ToString();
//			OraDB.Parameter_Values[1] = cmb_workday.Text.ToString().Replace("/","").Replace("-","");
			OraDB.Parameter_Values[1] = cmb_workday.Value.ToString("yyyyMMdd").Replace("/","").Replace("-","");
//			OraDB.Parameter_Values[2] = dtpdate_to.Text.ToString().Replace("/","").Replace("-","");
			OraDB.Parameter_Values[2] = dtpdate_to.Value.ToString("yyyyMMdd").Replace("/","").Replace("-","");
			OraDB.Parameter_Values[3] = cbo_parttype.SelectedValue.ToString();
//			if ((Cbo_Error.SelectedValue.ToString() == "ALL")||(Cbo_Error.SelectedValue.ToString() == ""))
//				OraDB.Parameter_Values[4] = "";
//			else
			OraDB.Parameter_Values[4] = Cbo_Error.SelectedValue.ToString();
			OraDB.Parameter_Values[5] = cmb_repairarea1.SelectedValue.ToString();
			OraDB.Parameter_Values[6] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_main.AddItem("",0);
			for (int i = 1 ; i < fgrid_main.Cols.Count ; i ++)
				fgrid_main[0,i]= "REPAIR ERROR REPORT " ;
			fgrid_main.Rows[0].AllowMerging = true ;
			fgrid_main.Rows[0].Height = 60 ;
			fgrid_main.Rows[0].TextAlign = TextAlignEnum.CenterCenter ;
			fgrid_main.Rows[0].StyleNew.ForeColor = Color.Red ;
			fgrid_main.GetCellRange(0,0,0,fgrid_main.Cols.Count-1).StyleNew.Font = new Font("Verdana", 18, FontStyle.Bold);

//			fgrid_main.PrintGrid("",PrintGridFlags.ShowPreviewDialog,"","");
			fgrid_main.PrintGrid("",PrintGridFlags.ShowPageSetupDialog,"","");
			fgrid_main.RemoveItem(0);
		}

	}
}

