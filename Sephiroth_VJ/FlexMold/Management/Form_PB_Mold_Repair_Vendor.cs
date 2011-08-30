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
	public class Form_PB_Mold_Repair_Vendor : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel pnel1;
		private System.Windows.Forms.Button btn_Search;
		private C1.Win.C1List.C1Combo cmb_repairarea1;
		private System.Windows.Forms.Label lbl_repairarea;
		private C1.Win.C1List.C1Combo cbo_parttype;
		private System.Windows.Forms.Label lbl_parttype;
		private System.Windows.Forms.DateTimePicker cmb_workday;
		private System.Windows.Forms.Label lbl_work_ymd;
		private System.Windows.Forms.Label lbl_wp;
		private System.Windows.Forms.TextBox txt_moldcode;
		private System.Windows.Forms.Label lbl_moldcode;
		private C1.Win.C1List.C1Combo cbo_wh;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label lbl_factory;
		public COM.FSP fgrid_moldrepair;
		public COM.FSP fgrid_err;
		private System.ComponentModel.IContainer components = null;

		private COM.OraDB OraDB = new COM.OraDB();

		public Form_PB_Mold_Repair_Vendor()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Repair_Vendor));
			this.pnel1 = new System.Windows.Forms.Panel();
			this.btn_Search = new System.Windows.Forms.Button();
			this.cmb_repairarea1 = new C1.Win.C1List.C1Combo();
			this.lbl_repairarea = new System.Windows.Forms.Label();
			this.cbo_parttype = new C1.Win.C1List.C1Combo();
			this.lbl_parttype = new System.Windows.Forms.Label();
			this.cmb_workday = new System.Windows.Forms.DateTimePicker();
			this.lbl_work_ymd = new System.Windows.Forms.Label();
			this.lbl_wp = new System.Windows.Forms.Label();
			this.txt_moldcode = new System.Windows.Forms.TextBox();
			this.lbl_moldcode = new System.Windows.Forms.Label();
			this.cbo_wh = new C1.Win.C1List.C1Combo();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.fgrid_moldrepair = new COM.FSP();
			this.fgrid_err = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_repairarea1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_parttype)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_moldrepair)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_err)).BeginInit();
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
			this.lbl_MainTitle.Size = new System.Drawing.Size(368, 23);
			// 
			// pnel1
			// 
			this.pnel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnel1.BackColor = System.Drawing.Color.Transparent;
			this.pnel1.Controls.Add(this.btn_Search);
			this.pnel1.Controls.Add(this.cmb_repairarea1);
			this.pnel1.Controls.Add(this.lbl_repairarea);
			this.pnel1.Controls.Add(this.cbo_parttype);
			this.pnel1.Controls.Add(this.lbl_parttype);
			this.pnel1.Controls.Add(this.cmb_workday);
			this.pnel1.Controls.Add(this.lbl_work_ymd);
			this.pnel1.Controls.Add(this.lbl_wp);
			this.pnel1.Controls.Add(this.txt_moldcode);
			this.pnel1.Controls.Add(this.lbl_moldcode);
			this.pnel1.Controls.Add(this.cbo_wh);
			this.pnel1.Controls.Add(this.cbo_factory);
			this.pnel1.Controls.Add(this.lbl_factory);
			this.pnel1.Location = new System.Drawing.Point(0, 64);
			this.pnel1.Name = "pnel1";
			this.pnel1.Size = new System.Drawing.Size(1016, 72);
			this.pnel1.TabIndex = 30;
			// 
			// btn_Search
			// 
			this.btn_Search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Search.ForeColor = System.Drawing.Color.Red;
			this.btn_Search.Location = new System.Drawing.Point(760, 24);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(72, 24);
			this.btn_Search.TabIndex = 25;
			this.btn_Search.Text = "Search";
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
			this.cmb_repairarea1.Location = new System.Drawing.Point(557, 40);
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
			this.cmb_repairarea1.TabIndex = 24;
			// 
			// lbl_repairarea
			// 
			this.lbl_repairarea.Location = new System.Drawing.Point(448, 43);
			this.lbl_repairarea.Name = "lbl_repairarea";
			this.lbl_repairarea.Size = new System.Drawing.Size(104, 16);
			this.lbl_repairarea.TabIndex = 23;
			this.lbl_repairarea.Text = "Repairing Area";
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
			this.cbo_parttype.Location = new System.Drawing.Point(96, 40);
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
			this.cbo_parttype.Size = new System.Drawing.Size(128, 23);
			this.cbo_parttype.TabIndex = 21;
			this.cbo_parttype.SelectedValueChanged += new System.EventHandler(this.cbo_parttype_SelectedValueChanged);
			// 
			// lbl_parttype
			// 
			this.lbl_parttype.Location = new System.Drawing.Point(8, 47);
			this.lbl_parttype.Name = "lbl_parttype";
			this.lbl_parttype.Size = new System.Drawing.Size(72, 16);
			this.lbl_parttype.TabIndex = 20;
			this.lbl_parttype.Text = "Part Type";
			// 
			// cmb_workday
			// 
			this.cmb_workday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.cmb_workday.Location = new System.Drawing.Point(558, 8);
			this.cmb_workday.Name = "cmb_workday";
			this.cmb_workday.Size = new System.Drawing.Size(104, 22);
			this.cmb_workday.TabIndex = 19;
			// 
			// lbl_work_ymd
			// 
			this.lbl_work_ymd.Location = new System.Drawing.Point(448, 16);
			this.lbl_work_ymd.Name = "lbl_work_ymd";
			this.lbl_work_ymd.Size = new System.Drawing.Size(120, 16);
			this.lbl_work_ymd.TabIndex = 18;
			this.lbl_work_ymd.Text = "Working Date";
			// 
			// lbl_wp
			// 
			this.lbl_wp.Location = new System.Drawing.Point(232, 15);
			this.lbl_wp.Name = "lbl_wp";
			this.lbl_wp.Size = new System.Drawing.Size(80, 16);
			this.lbl_wp.TabIndex = 17;
			this.lbl_wp.Text = "Work Place";
			// 
			// txt_moldcode
			// 
			this.txt_moldcode.Location = new System.Drawing.Point(312, 40);
			this.txt_moldcode.Name = "txt_moldcode";
			this.txt_moldcode.Size = new System.Drawing.Size(128, 22);
			this.txt_moldcode.TabIndex = 7;
			this.txt_moldcode.Text = "";
			// 
			// lbl_moldcode
			// 
			this.lbl_moldcode.Location = new System.Drawing.Point(232, 48);
			this.lbl_moldcode.Name = "lbl_moldcode";
			this.lbl_moldcode.Size = new System.Drawing.Size(98, 16);
			this.lbl_moldcode.TabIndex = 6;
			this.lbl_moldcode.Text = "Mold Code:";
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
			this.cbo_wh.Location = new System.Drawing.Point(312, 8);
			this.cbo_wh.MatchEntryTimeout = ((long)(2000));
			this.cbo_wh.MaxDropDownItems = ((short)(5));
			this.cbo_wh.MaxLength = 32767;
			this.cbo_wh.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_wh.Name = "cbo_wh";
			this.cbo_wh.PartialRightColumn = false;
			this.cbo_wh.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_wh.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_wh.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_wh.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_wh.Size = new System.Drawing.Size(128, 23);
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
			this.cbo_factory.Size = new System.Drawing.Size(128, 23);
			this.cbo_factory.TabIndex = 3;
			// 
			// lbl_factory
			// 
			this.lbl_factory.Location = new System.Drawing.Point(8, 14);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(56, 16);
			this.lbl_factory.TabIndex = 0;
			this.lbl_factory.Text = "Factory";
			// 
			// fgrid_moldrepair
			// 
			this.fgrid_moldrepair.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_moldrepair.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_moldrepair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.fgrid_moldrepair.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_moldrepair.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_moldrepair.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:22;}\t";
			this.fgrid_moldrepair.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_moldrepair.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_moldrepair.Location = new System.Drawing.Point(0, 136);
			this.fgrid_moldrepair.Name = "fgrid_moldrepair";
			this.fgrid_moldrepair.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_moldrepair.Size = new System.Drawing.Size(600, 504);
			this.fgrid_moldrepair.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_moldrepair.TabIndex = 53;
			// 
			// fgrid_err
			// 
			this.fgrid_err.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_err.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_err.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_err.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_err.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_err.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:22;}\t";
			this.fgrid_err.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_err.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_err.Location = new System.Drawing.Point(608, 136);
			this.fgrid_err.Name = "fgrid_err";
			this.fgrid_err.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_err.Size = new System.Drawing.Size(408, 504);
			this.fgrid_err.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_err.TabIndex = 55;
			this.fgrid_err.DoubleClick += new System.EventHandler(this.fgrid_err_DoubleClick);
			// 
			// Form_PB_Mold_Repair_Vendor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_err);
			this.Controls.Add(this.fgrid_moldrepair);
			this.Controls.Add(this.pnel1);
			this.Name = "Form_PB_Mold_Repair_Vendor";
			this.Text = "Form_PB_Mold_Repair_Vendor";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Repair_Vendor_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnel1, 0);
			this.Controls.SetChildIndex(this.fgrid_moldrepair, 0);
			this.Controls.SetChildIndex(this.fgrid_err, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_repairarea1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_parttype)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_moldrepair)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_err)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Repair_Vendor_Load(object sender, System.EventArgs e)
		{
			FlexMold.ClassLib.ComVar.This_Partcode = "R";
			Init_Form();
			tbtn_Print.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled = false;			
			tbtn_Save.Enabled = false;
		}

		private void Init_Form()
		{
			cbo_factory.Text = "VJ";
			this.lbl_MainTitle.Text = "Mold Repairing Management By Vendor";
			ClassLib.ComFunction.SetLangDic(this);
			
			fgrid_moldrepair.Set_Grid("SDT_MOLD_REPAIR_TAIL1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_moldrepair.Set_Action_Image(img_Action);
			fgrid_moldrepair.ExtendLastCol = false;
			//			fgrid_moldrepair.AutoSizeCols();

			fgrid_err.Set_Grid("SDT_MOLD_BASIC_ERROR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_err.Set_Action_Image(img_Action);
			fgrid_err.ExtendLastCol = false;
			//			fgrid_err.AutoSizeCols();
 
			DataTable dt_ret = Select_com_filter_code_List("SDV15");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List("MD03");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_parttype, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List("SDV40");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_repairarea1, 0, 1, false, false);
			cmb_repairarea1.SelectedIndex = 0;
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

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_moldrepair.Clear();
			fgrid_moldrepair.Set_Grid("SDT_MOLD_REPAIR_TAIL1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_moldrepair.Set_Action_Image(img_Action);
			fgrid_moldrepair.ExtendLastCol = false;
			
			fgrid_moldrepair.Rows.Add();
			fgrid_moldrepair[fgrid_moldrepair.RowSel,15] = cmb_repairarea1.Columns[0].Text ; 
			tbtn_Save.Enabled = true;
		}

		private void cbo_parttype_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Search_err();			
		}
		private void Search_err()
		{
			DataTable vDt1 = null;
			fgrid_err.Clear();

			fgrid_err.Set_Grid("SDT_MOLD_BASIC_ERROR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_err.Set_Action_Image(img_Action);
			fgrid_err.ExtendLastCol = false;
			try
			{
				vDt1 = SELECT_MOLD_ERR();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_err.AddItem(vDt1.Rows[i].ItemArray, fgrid_err.Rows.Count, 1);						
					}
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

		private System.Data.DataTable SELECT_MOLD_ERR()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SEARCH_MOLD_BASIC_ERR";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_PART_CD";			
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;			
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = "VJ"  ;
			OraDB.Parameter_Values[1] = cbo_parttype.SelectedValue.ToString();
			OraDB.Parameter_Values[2] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

		private void fgrid_err_DoubleClick(object sender, System.EventArgs e)
		{
			int cost =0;
			int qty =0;
			int amount =0;
			fgrid_moldrepair[fgrid_moldrepair.RowSel,9] = fgrid_err[fgrid_err.RowSel,2].ToString();
			fgrid_moldrepair[fgrid_moldrepair.RowSel,10] = fgrid_err[fgrid_err.RowSel,3].ToString();
			fgrid_moldrepair[fgrid_moldrepair.RowSel,11] = fgrid_err[fgrid_err.RowSel,5].ToString();
			fgrid_moldrepair[fgrid_moldrepair.RowSel,12] = fgrid_err[fgrid_err.RowSel,4].ToString();
			cost = System.Convert.ToInt32(fgrid_moldrepair[fgrid_moldrepair.RowSel,11].ToString());
			qty  = 1;
			amount = cost * qty;
			fgrid_moldrepair[fgrid_moldrepair.RowSel,13] = amount.ToString();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fnSave();
			Search_mold_repair();
		}
		private void fnSave()
		{	
			try
			{
				for (int i = 2; i < fgrid_moldrepair.Rows.Count; i++)
				{
					string[] arr_save = new string[fgrid_moldrepair.Cols.Count];
					for(int j=0;j< fgrid_moldrepair.Cols.Count;j++)
					{
						if(fgrid_moldrepair[i,j] != null)
							arr_save[j] = fgrid_moldrepair[i,j].ToString();
						else 
							arr_save[j] = "";
					}
					save_mold_repair_tail(arr_save); 
					save_mold_repair_head(arr_save); 
				}
	
//					if(fgrid_moldrepair[i, 0]!= null)
//					{
//						if (fgrid_moldrepair[i, 0]== "I") 
//						{
//							string[] arr_save = new string[fgrid_moldrepair.Cols.Count];
//							for(int j=0;j< fgrid_moldrepair.Cols.Count;j++)
//							{
//								if(fgrid_moldrepair[i,j] != null)
//									arr_save[j] = fgrid_moldrepair[i,j].ToString();
//								else 
//									arr_save[j] = "";
//							}
//							//save_mold_repair_head(arr_save);
//							save_mold_repair_tail(arr_save); 
//							save_mold_repair_head(arr_save); 
//						}
//						else if(fgrid_moldrepair[i, 0]== "U")
//						{
//							string[] arr_save = new string[fgrid_moldrepair.Cols.Count];
//							for(int j=0;j< fgrid_moldrepair.Cols.Count;j++)
//							{
//								if(fgrid_moldrepair[i,j] != null)
//									arr_save[j] = fgrid_moldrepair[i,j].ToString();
//								else 
//									arr_save[j] = "";
//							}
//							//save_mold_repair_head(arr_save);  
//							save_mold_repair_tail(arr_save);
//							save_mold_repair_head(arr_save); 
//							//Search_mold_repair();
//						}
//						else if(fgrid_moldrepair[i, 0]== "D")
//						{
//							string[] arr_upgrade = new string[fgrid_moldrepair.Cols.Count];
//							for(int j=0;j< fgrid_moldrepair.Cols.Count;j++)
//							{
//								arr_upgrade[j] = fgrid_moldrepair[i,j].ToString();
//							}
//							//save_mold_repair_head(arr_upgrade);  
//							save_mold_repair_tail(arr_upgrade);
//							save_mold_repair_head(arr_upgrade); 
//							//Search_mold_repair();
//						}
//					}
//				}

			}
			catch
			{
			}
			finally
			{
			}

		}

		private void save_mold_repair_head(string[] arg_array)
		{
			string process_name = "PKG_SDT_MOLD.SAVE_MOLD_REPAIR_HEAD";
			//int arg_len =arg_array.Length + 7;
			OraDB.ReDim_Parameter(11); 

			//01.PROCEDURE명
			OraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			OraDB.Parameter_Name[0]  = "ARG_DIVISION";
			OraDB.Parameter_Name[1]  = "ARG_FACTORY";
			OraDB.Parameter_Name[2]  = "ARG_WORK_YMD";
			OraDB.Parameter_Name[3]  = "ARG_WORK_PLACE";
			OraDB.Parameter_Name[4]  = "ARG_PART_CD"; 
			OraDB.Parameter_Name[5]  = "ARG_MODEL_CD";
			OraDB.Parameter_Name[6]  = "ARG_MOLD_CD";
			OraDB.Parameter_Name[7]  = "ARG_AMOUNT";
			OraDB.Parameter_Name[8]  = "ARG_REMARK";
			OraDB.Parameter_Name[9] = "ARG_UPD_USER";
			OraDB.Parameter_Name[10] = "ARG_UPD_YMD";

			for(int i=0; i< 11; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			 
			OraDB.Parameter_Values[0] ="I"; 
			OraDB.Parameter_Values[1] = "VJ"; 
			OraDB.Parameter_Values[2] = cmb_workday.Text.ToString().Replace("-","").Replace("/","").Trim(); 
			OraDB.Parameter_Values[3] = cbo_wh.SelectedValue.ToString(); 
			OraDB.Parameter_Values[4] = arg_array[1].ToString(); 
			OraDB.Parameter_Values[5] = arg_array[3].ToString(); 
			OraDB.Parameter_Values[6] = arg_array[4].ToString(); 
			OraDB.Parameter_Values[7] = "";
			OraDB.Parameter_Values[8] = arg_array[14].ToString();
			OraDB.Parameter_Values[9] = ClassLib.ComVar.This_User.ToString();
			OraDB.Parameter_Values[10] = "";

			OraDB.Add_Modify_Parameter(true);	
			OraDB.Exe_Modify_Procedure();
		}
		private void save_mold_repair_tail(string[] arg_array)
		{
			string process_name = "PKG_SDT_MOLD.SAVE_MOLD_REPAIR_TAIL";
			//int arg_len =arg_array.Length + 7;
			OraDB.ReDim_Parameter(19); 

			//01.PROCEDURE명
			OraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
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
			OraDB.Parameter_Name[11] = "ARG_QTY";
			OraDB.Parameter_Name[12] = "ARG_ERR_CD";
			OraDB.Parameter_Name[13] = "ARG_ERR_COST";
			OraDB.Parameter_Name[14] = "ARG_UNIT";
			OraDB.Parameter_Name[15] = "ARG_AMOUNT";
			OraDB.Parameter_Name[16] = "ARG_REMARK";
			OraDB.Parameter_Name[17] = "ARG_UPD_USER";
			OraDB.Parameter_Name[18] = "ARG_UPD_YMD";
			

			for(int i=0; i< 19; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			 
			OraDB.Parameter_Values[0]  = "I"; 
			OraDB.Parameter_Values[1]  = "VJ"; 
			OraDB.Parameter_Values[2]  = cmb_workday.Text.ToString().Replace("-","").Replace("/",""); 
			OraDB.Parameter_Values[3]  = cbo_wh.SelectedValue.ToString().Trim(); 
			OraDB.Parameter_Values[4]  = arg_array[1].ToString(); 
			OraDB.Parameter_Values[5]  = arg_array[3].ToString(); 
			OraDB.Parameter_Values[6]  = arg_array[4].ToString(); 
			OraDB.Parameter_Values[7]  = arg_array[5].ToString(); 
			OraDB.Parameter_Values[8]  = arg_array[6].ToString();
			OraDB.Parameter_Values[9]  = arg_array[15].ToString(); 
			OraDB.Parameter_Values[10] = arg_array[8].ToString();
			OraDB.Parameter_Values[11] = arg_array[7].ToString();
			OraDB.Parameter_Values[12] = arg_array[9].ToString();
			OraDB.Parameter_Values[13] = arg_array[11].ToString();
			OraDB.Parameter_Values[14] = arg_array[12].ToString(); 
			OraDB.Parameter_Values[15] = arg_array[13].ToString();
			OraDB.Parameter_Values[16] = arg_array[14].ToString();

			OraDB.Parameter_Values[17] = ClassLib.ComVar.This_User.ToString(); 
			OraDB.Parameter_Values[18] = cmb_workday.Text.Substring(0,10).Replace("-","")  ;

			OraDB.Add_Modify_Parameter(true);	
			OraDB.Exe_Modify_Procedure();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Search_mold_repair();
			tbtn_Save.Enabled = false;
		}
		private void Search_mold_repair()
		{
			DataTable vDt1 = null;
			fgrid_moldrepair.Clear();

			fgrid_moldrepair.Set_Grid("SDT_MOLD_REPAIR_TAIL1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_moldrepair.Set_Action_Image(img_Action);
			fgrid_moldrepair.ExtendLastCol = false;
			fgrid_moldrepair.AutoSizeCols();
			try
			{
				vDt1 = SELECT_MOLD_REPAIR();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_moldrepair.AddItem(vDt1.Rows[i].ItemArray, fgrid_moldrepair.Rows.Count, 1);						
					}
					fgrid_moldrepair.Cols.Frozen = 3;
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

		private System.Data.DataTable SELECT_MOLD_REPAIR()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_MOLD_REPAIR_VENDOR";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WORK_YMD";
			OraDB.Parameter_Name[2] = "ARG_WORK_PLACE";
			OraDB.Parameter_Name[3] = "ARG_PART_CD";
			OraDB.Parameter_Name[4] = "ARG_MOLD_CD";
			OraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = "VJ"  ;
			OraDB.Parameter_Values[1] = cmb_workday.Value.ToString().Substring(0,10).Replace("-","").Replace("/","");
			OraDB.Parameter_Values[2] = cbo_wh.SelectedValue.ToString();
			if (cbo_parttype.Text == "")
				OraDB.Parameter_Values[3] = "";
			else
				OraDB.Parameter_Values[3] = cbo_parttype.SelectedValue.ToString();
			if (txt_moldcode.Text.ToString() == "")
				OraDB.Parameter_Values[4] = "";
			else				
				OraDB.Parameter_Values[4] = txt_moldcode.Text.Trim();
			OraDB.Parameter_Values[5] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}

	}
}

