using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;
//using RKLib.ExportData;
using System.Data.OleDb;

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
		private System.Windows.Forms.Label lbl_work_ymd;
		private System.Windows.Forms.DateTimePicker dtp1;
		private System.Windows.Forms.Label lbl_to;
		private System.Windows.Forms.DateTimePicker dtp2;
		private System.Windows.Forms.DateTimePicker dtpFinish_Date;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_repairarea1;
		private System.Windows.Forms.Label lbl_repairarea;

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
			this.cmb_repairarea1 = new C1.Win.C1List.C1Combo();
			this.lbl_repairarea = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpFinish_Date = new System.Windows.Forms.DateTimePicker();
			this.dtp2 = new System.Windows.Forms.DateTimePicker();
			this.lbl_to = new System.Windows.Forms.Label();
			this.dtp1 = new System.Windows.Forms.DateTimePicker();
			this.lbl_work_ymd = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.cmb_repairarea1)).BeginInit();
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
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Append
			// 
			this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
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
			this.cbo_wh.Location = new System.Drawing.Point(96, 32);
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
			this.cbo_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.pnel1.Controls.Add(this.cmb_repairarea1);
			this.pnel1.Controls.Add(this.lbl_repairarea);
			this.pnel1.Controls.Add(this.label2);
			this.pnel1.Controls.Add(this.dtpFinish_Date);
			this.pnel1.Controls.Add(this.dtp2);
			this.pnel1.Controls.Add(this.lbl_to);
			this.pnel1.Controls.Add(this.dtp1);
			this.pnel1.Controls.Add(this.lbl_work_ymd);
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
			this.pnel1.Size = new System.Drawing.Size(1008, 64);
			this.pnel1.TabIndex = 30;
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
			this.cmb_repairarea1.ContentHeight = 17;
			this.cmb_repairarea1.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_repairarea1.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_repairarea1.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_repairarea1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_repairarea1.EditorHeight = 17;
			this.cmb_repairarea1.GapHeight = 2;
			this.cmb_repairarea1.ItemHeight = 15;
			this.cmb_repairarea1.Location = new System.Drawing.Point(760, 32);
			this.cmb_repairarea1.MatchEntryTimeout = ((long)(2000));
			this.cmb_repairarea1.MaxDropDownItems = ((short)(5));
			this.cmb_repairarea1.MaxLength = 32767;
			this.cmb_repairarea1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_repairarea1.Name = "cmb_repairarea1";
			this.cmb_repairarea1.PartialRightColumn = false;
			this.cmb_repairarea1.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_repairarea1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_repairarea1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_repairarea1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_repairarea1.Size = new System.Drawing.Size(179, 23);
			this.cmb_repairarea1.TabIndex = 27;
			// 
			// lbl_repairarea
			// 
			this.lbl_repairarea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_repairarea.ForeColor = System.Drawing.Color.Blue;
			this.lbl_repairarea.Location = new System.Drawing.Point(646, 36);
			this.lbl_repairarea.Name = "lbl_repairarea";
			this.lbl_repairarea.Size = new System.Drawing.Size(114, 16);
			this.lbl_repairarea.TabIndex = 26;
			this.lbl_repairarea.Text = "Repairing Area";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(647, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 16);
			this.label2.TabIndex = 25;
			this.label2.Text = "Finish Date";
			// 
			// dtpFinish_Date
			// 
			this.dtpFinish_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFinish_Date.Location = new System.Drawing.Point(760, 8);
			this.dtpFinish_Date.Name = "dtpFinish_Date";
			this.dtpFinish_Date.Size = new System.Drawing.Size(112, 22);
			this.dtpFinish_Date.TabIndex = 24;
			// 
			// dtp2
			// 
			this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp2.Location = new System.Drawing.Point(496, 8);
			this.dtp2.Name = "dtp2";
			this.dtp2.Size = new System.Drawing.Size(112, 22);
			this.dtp2.TabIndex = 23;
			// 
			// lbl_to
			// 
			this.lbl_to.Location = new System.Drawing.Point(458, 8);
			this.lbl_to.Name = "lbl_to";
			this.lbl_to.Size = new System.Drawing.Size(16, 16);
			this.lbl_to.TabIndex = 22;
			this.lbl_to.Text = "~";
			// 
			// dtp1
			// 
			this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp1.Location = new System.Drawing.Point(336, 7);
			this.dtp1.Name = "dtp1";
			this.dtp1.Size = new System.Drawing.Size(104, 22);
			this.dtp1.TabIndex = 21;
			// 
			// lbl_work_ymd
			// 
			this.lbl_work_ymd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_work_ymd.ForeColor = System.Drawing.Color.Blue;
			this.lbl_work_ymd.Location = new System.Drawing.Point(248, 10);
			this.lbl_work_ymd.Name = "lbl_work_ymd";
			this.lbl_work_ymd.Size = new System.Drawing.Size(88, 16);
			this.lbl_work_ymd.TabIndex = 20;
			this.lbl_work_ymd.Text = "Work Date:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(442, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 16);
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
			this.cbo_Status.Location = new System.Drawing.Point(496, 32);
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
			this.lbl_wp.Location = new System.Drawing.Point(8, 36);
			this.lbl_wp.Name = "lbl_wp";
			this.lbl_wp.Size = new System.Drawing.Size(88, 16);
			this.lbl_wp.TabIndex = 17;
			this.lbl_wp.Text = "Warehouse";
			// 
			// txt_moldcode
			// 
			this.txt_moldcode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_moldcode.Location = new System.Drawing.Point(336, 32);
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
			this.lbl_moldcode.Location = new System.Drawing.Point(248, 36);
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
			this.fgrid_mold.Location = new System.Drawing.Point(0, 128);
			this.fgrid_mold.Name = "fgrid_mold";
			this.fgrid_mold.Rows.Count = 2;
			this.fgrid_mold.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_mold.Size = new System.Drawing.Size(1008, 504);
			this.fgrid_mold.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;BackColor:Transparent;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_mold.TabIndex = 52;
			this.fgrid_mold.Click += new System.EventHandler(this.fgrid_mold_Click);
			this.fgrid_mold.CellChanged += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_mold_CellChanged);
			this.fgrid_mold.ComboCloseUp += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_mold_ComboCloseUp);
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
			((System.ComponentModel.ISupportInitialize)(this.cmb_repairarea1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_Status)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_mold)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Repair_Search_Load(object sender, System.EventArgs e)
		{
			if((ClassLib.ComVar.This_Dept.ToString() =="360200")||(ClassLib.ComVar.This_Dept.ToString() =="110200")||(FlexMold.ClassLib.ComVar.This_Dept.ToString() =="0000"))
				tbtn_Save.Enabled = true ;
			else
			{
				tbtn_Save.Enabled = false ;
			}
			Init_Form();
			FlexMold.ClassLib.ComVar.This_Win_ID = lbl_MainTitle.Text;
			FlexMold.ClassLib.ComVar.This_Computer = Environment.MachineName;
			tbtn_Print.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled = false;		
			tbtn_Delete.Enabled = false;

			FlexMold.ClassLib.ComVar.This_Err = "S";
		}
		private void Init_Form()
		{
			FlexMold.ClassLib.ComVar.This_Err = "S";
			cbo_factory.Text = "VJ";
			this.lbl_MainTitle.Text = "Mold Repairing Management By Warehouse";
			ClassLib.ComFunction.SetLangDic(this);
			
			//fgrid_mold.Set_Grid("SDT_MOLD_MASTER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
//			fgrid_mold.Set_Grid("SDT_MOLD_LOCATE_MANAGER1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
//			fgrid_mold.Set_Action_Image(img_Action);
//			//_RowFixed_desc = fgrip_main.Rows.Fixed;fgrid_moldrepair
//			fgrid_mold.ExtendLastCol = false;
//			fgrid_mold.AutoSizeCols();

			fgrid_mold.Set_Grid("SDT_MOLD_REPAIR_TAIL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
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
			dt_ret = Select_com_filter_code_List("SDV40");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_repairarea1, 0, 1, false, false);
			cmb_repairarea1.SelectedIndex = 1;			
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
			if (cbo_wh.SelectedValue.ToString() == "30")
				FlexMold.ClassLib.ComVar.This_Err = "S";
			else if(cbo_wh.SelectedValue.ToString() == "40")
				FlexMold.ClassLib.ComVar.This_Err = "K";

			Search_Main();//SDT_MOLD_REPAIR_TAIL --- SDT_MOLD_REPAIR_WH
			FlexMold.ClassLib.ComVar.This_Action ="S" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
			fgrid_mold.Cols.Frozen = 3;
			tbtn_Save.Enabled = true ;
			Search_Color();
		}

		private void Search_Main()
		{
			fgrid_mold.Clear();
			fgrid_mold.Set_Grid("SDT_MOLD_REPAIR_TAIL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_mold.Set_Action_Image(img_Action);
			DataTable vDt1 = null;
			try
			{
				vDt1 = SELECT_MOLD_REPAIR_MAIN();    
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
		//--------------------------------------------------------
		
		//--------------------------------------------------------
		private System.Data.DataTable SELECT_MOLD_REPAIR_MAIN()
		{
			System.Data.DataSet retDS;                  
			OraDB.ReDim_Parameter(8); 
			//01.PROCEDURE¢¬i
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_MOLD_REPAIR_BY_WH1";

			//02.ARGURMENT ¢¬i
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WH";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			OraDB.Parameter_Name[3] = "ARG_STATUS";
			OraDB.Parameter_Name[4] = "ARG_FRYMD";
			OraDB.Parameter_Name[5] = "ARG_TOYMD";
			OraDB.Parameter_Name[6] = "ARG_REPAIR_AREA";
			OraDB.Parameter_Name[7] = "OUT_CURSOR";
			//03.DATA TYPE A¢´AC
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[7] = (int)OracleType.Cursor;

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

			OraDB.Parameter_Values[4] = dtp1.Text.Trim().Replace("-","").Replace("/","") ;
			OraDB.Parameter_Values[5] = dtp2.Text.Trim().Replace("-","").Replace("/","");
			OraDB.Parameter_Values[6] = cmb_repairarea1.SelectedValue.ToString();
			OraDB.Parameter_Values[7] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();

			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

		private void fgrid_mold_Click(object sender, System.EventArgs e)
		{
//			string temp ="";
//			if ( ClassLib.ComVar.This_User != "HOANG.IT")
//			{
//				fgrid_mold.StartEditing(fgrid_mold.RowSel,1);
//				//fgrid_mold[fgrid_mold.RowSel,0] = "U";
//			}
		}

		private void fgrid_mold_ComboCloseUp(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if (fgrid_mold[fgrid_mold.RowSel,11].ToString() == "30")
				tbtn_Save.Enabled = false;
			else
			{
				tbtn_Save.Enabled = true ;
				fgrid_mold[fgrid_mold.RowSel,0] = "U";
			}
		}

		private void fgrid_mold_CellChanged(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
//			fgrid_mold[fgrid_mold.RowSel,3] = "U";
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			update_mold_repair_status();
			FlexMold.ClassLib.ComVar.This_Action ="U" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
		}
		private void update_mold_repair_status()
		{
			try
			{
				for (int i = 2; i < fgrid_mold.Rows.Count; i++)
				{
					if(fgrid_mold[i, 0]!= null)
					{
						if (fgrid_mold[i, 0]== "U") 
						{
							string[] arr_save = new string[fgrid_mold.Cols.Count];
							for(int j=0;j< fgrid_mold.Cols.Count;j++)
							{
								if(fgrid_mold[i,j] != null)
									arr_save[j] = fgrid_mold[i,j].ToString();
								else 
									arr_save[j] = "";
							}
							//save_mold_repair_head(arr_save);
							save_mold_repair_tail(arr_save); 
							//save_mold_repair_head(arr_save); 
						}
						
					}
					
				}

			}
			catch
			{
			}
			finally
			{
			}
			//save_mold_repair_head(arr_save); 
			Search_Main();
		}
		private void save_mold_repair_tail(string[] arg_array)
		{
			string process_name = "PKG_SDT_MOLD.UPDATE_MOLD_REPAIR_STATUS";
			//int arg_len =arg_array.Length + 7;
			OraDB.ReDim_Parameter(16); 

			//01.PROCEDURE¸í
			OraDB.Process_Name = process_name;
 
			//02.ARGURMENT¸í
			OraDB.Parameter_Name[0]  = "ARG_DIVISION";
			OraDB.Parameter_Name[1]  = "ARG_FACTORY";
			OraDB.Parameter_Name[2]  = "ARG_WORK_YMD";
			OraDB.Parameter_Name[3]  = "ARG_WORK_PLACE";
			OraDB.Parameter_Name[4]  = "ARG_PART_CD";
			OraDB.Parameter_Name[5]  = "ARG_MODEL_CD"; //ARG_SPEC_CD
			OraDB.Parameter_Name[6]  = "ARG_MOLD_CD";
			OraDB.Parameter_Name[7]  = "ARG_USE_SIZE";
			OraDB.Parameter_Name[8]  = "ARG_SEQ";
			OraDB.Parameter_Name[9]  = "ARG_REPAIR_AREA";
			OraDB.Parameter_Name[10]  = "ARG_STATUS";
			OraDB.Parameter_Name[11] = "ARG_ERR_CD";
			OraDB.Parameter_Name[12] = "ARG_REMARK";
			OraDB.Parameter_Name[13] = "ARG_UPD_USER";
			OraDB.Parameter_Name[14] = "ARG_UPD_YMD";
			OraDB.Parameter_Name[15] = "ARG_AMOUNT";			

			for(int i=0; i< 15; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			 
			OraDB.Parameter_Values[0]  = arg_array[0].ToString(); 
			OraDB.Parameter_Values[1]  = arg_array[1].ToString(); 
			OraDB.Parameter_Values[2]  = arg_array[2].ToString().Replace("-","").Replace("/",""); 		
			OraDB.Parameter_Values[3]  = cbo_wh.SelectedValue.ToString().Trim(); 
			OraDB.Parameter_Values[4]  = arg_array[4].ToString(); 
			OraDB.Parameter_Values[5]  = arg_array[5].ToString(); 
			OraDB.Parameter_Values[6]  = arg_array[7].ToString(); 
			OraDB.Parameter_Values[7]  = arg_array[8].ToString(); 
			OraDB.Parameter_Values[8]  = arg_array[9].ToString();
			OraDB.Parameter_Values[9]  = arg_array[18].ToString(); // repair area
			OraDB.Parameter_Values[10] = arg_array[11].ToString();
			OraDB.Parameter_Values[11] = arg_array[12].ToString();
			OraDB.Parameter_Values[12] = arg_array[17].ToString();
			OraDB.Parameter_Values[13] = COM.ComVar.This_User;
//			OraDB.Parameter_Values[14] = arg_array[19].ToString().Substring(0,10).Replace("-","")  ;
			OraDB.Parameter_Values[14] = dtpFinish_Date.Text.Replace("/","").Replace("-","") ;
			OraDB.Parameter_Values[15]  = arg_array[16].ToString(); // Amount

			OraDB.Add_Modify_Parameter(true);	
			OraDB.Exe_Modify_Procedure();
		}

		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
//			ExportExcel_Click();
		}
		private void Search_Color()
		{
			for ( int i = 2 ; i < fgrid_mold.Rows.Count ; i++)
			{
				if ( fgrid_mold[i,17].ToString() == "10")
				{
					fgrid_mold.Rows[i].StyleNew.ForeColor = Color.Red;
					fgrid_mold.Rows[i].StyleNew.BackColor = Color.FromArgb(217, 225, 157);
				}
				else if ( fgrid_mold[i,17].ToString() == "20")
				{
					fgrid_mold.Rows[i].StyleNew.ForeColor = Color.FromArgb(255, 0, 255);
//					fgrid_mold.Rows[i].StyleNew.BackColor = Color.FromArgb(255, 230, 255);
				}
			}
		}

		private void cbo_wh_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (cbo_wh.SelectedValue.ToString() == "30")
				COM.ComVar.Job_Process = "S";
			else if(cbo_wh.SelectedValue.ToString() == "40")
				COM.ComVar.Job_Process = "K";
		}
		
//		private void ExportExcel_Click()
//		{
//			//lblMessage.Text = "";
//			DataTable vDt1 = null;
//			// Export all the details
//			//try
//			//{	
//				vDt1 = SELECT_MOLD_REPAIR_MAIN();    
//				if(vDt1.Rows.Count > 0)
//				{
//					// Get the datatable to export			
//					//DataTable dtEmployee = dgTables["Employee"].Copy();
//
//					// Export all the details to Excel
//					//RKLib.ExportData.Export objExport = new RKLib.ExportData.Export("Win");		
//		
//					//objExport.ExportDetails(vDt1, Export.ExportFormat.Excel, "C:\\EmployeesInfo1.xls");
//					int[] iColumns = {1,2,3,5,6};
//				
//					// Export the details of specified columns to CSV
//					RKLib.ExportData.Export objExport = new RKLib.ExportData.Export("Win");
//					objExport.ExportDetails(vDt1, iColumns, Export.ExportFormat.CSV, "C:\\EmployeesInfo.csv");
//					MessageBox.Show("Successfully exported to C:\\EmployeesInfo.csv");
//				}
//			//}
//			//catch(Exception Ex)
//			//{
//			//	MessageBox.Show(Ex.Message);
//			//}
//		}
	}
}

